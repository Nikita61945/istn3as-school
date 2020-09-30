Public Class AddLearner
    Public SQL As New DataBaseControl
    Dim grade As String
    Dim AcademicYear As Integer = Convert.ToInt32(Now.ToString("yyyy"))
    Dim msg As String = vbNewLine
    Dim idExamNoCheck As Integer
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "Blackboard.chm")
    Dim ID As Integer = 0
    Public Sub PopComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID, convert(varChar(6),GradeID) FROM tblGrade WHERE isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
            GradeComboBox.ValueMember = "GradeID"
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Form1.Show()
        GradeComboBox.SelectedIndex = -1
        NameTextBox.Clear()
        SurnameTextBox.Clear()
        IDNoTextBox.Clear()
        ExamNoTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        Add1TextBox.Clear()
        Add2TextBox.Clear()
        Add3TextBox.Clear()
        Add4TextBox.Clear()
        P1NameTextBox.Clear()
        P1CellTextBox.Clear()
        P2CellTextBox.Clear()
        P1EmailTextBox.Clear()
        P2NameTextBox.Clear()
        P2EmailTextBox.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim Exists As Boolean = False

        If MessageBox.Show("Are you sure you want to save these details ?", "Confirmation of Learner Details ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If Not (ExamNoTextBox.Text.Length = 0) Then
                SQL.RunQuery("Select IDNo,ExamNo from tblLearner Where IDNo = '" & IDNoTextBox.Text.ToString & "' OR ExamNo = '" & ExamNoTextBox.Text.ToString & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    idExamNoCheck = 1
                    Exists = True
                End If

            Else
                If Not (IDNoTextBox.Text.Length = 0) Then
                    SQL.RunQuery("Select IDNo,ExamNo from tblLearner Where IDNo = '" & IDNoTextBox.Text.ToString & "'")
                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                        idExamNoCheck = 2
                        Exists = True

                    End If
                End If

            End If

            If Exists = False Then

                If ((isFieldBlank(NameTextBox.Text) = False) And (isFieldBlank(SurnameTextBox.Text) = False) And (IDNoTextBox.Text.Length = 13) And (isFieldBlank(Add1TextBox.Text) = False) And (isFieldBlank(Add3TextBox.Text) = False) And (isFieldBlank(Add4TextBox.Text) = False) And (GenderComboBox.SelectedIndex <> -1) And (GradeComboBox.SelectedIndex <> -1) And (((isFieldBlank(P1NameTextBox.Text) = False) And ((P1CellTextBox.Text.Length = 10) And (P1CellTextBox.Text.StartsWith("0"))) And (checkEmail(P1EmailTextBox.Text)) And (Not (P1EmailTextBox.Text.Length = 0)) And (Not (P2EmailTextBox.Text.Length = 0)) And (isFieldBlank(P2NameTextBox.Text) = False) And ((P2CellTextBox.Text.Length = 10) And (P2CellTextBox.Text.StartsWith("0"))) And (checkEmail(P2EmailTextBox.Text))) Or ((isFieldBlank(P1NameTextBox.Text) = False) And ((P1CellTextBox.Text.Length = 10) And (P1CellTextBox.Text.StartsWith("0"))) And (checkEmail(P1EmailTextBox.Text)) And (isFieldBlank(P2NameTextBox.Text) = True) And (isFieldBlank(P2CellTextBox.Text) = True) And (isFieldBlank(P2EmailTextBox.Text) = True)))) Then

                    If SQL.HasConnnection = True Then
                        If SQL.SQLDataSet IsNot Nothing Then
                            SQL.SQLDataSet.Clear()
                        End If

                        SQL.RunQuery("Select MAX(LearnerID) AS HighestID FROM tblLearner")

                        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                            ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                        Else
                            ID = 1000
                        End If


                        Dim gender As String = (GenderComboBox.SelectedItem).ToString
                        grade = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
                        If (ExamNoTextBox.Text.Length = 0) Then
                            SQL.RunQuery("INSERT INTO tblLearner(LearnerID, IDNo, ExamNo,LName,LSurname,LStreetAdd,LSuburb,LCity,LPCode,LGender,POneName,POneNo,POneEmail,PTwoName,PTwoNo,PTwoEmail,LStatus,LAccount) VALUES('" & ID & "','" & IDNoTextBox.Text & "','" & vbNull & "','" & NameTextBox.Text & "','" & SurnameTextBox.Text & "','" & Add1TextBox.Text & "','" & Add2TextBox.Text & "','" & Add3TextBox.Text & "','" & Add4TextBox.Text & "','" & gender & "','" & P1NameTextBox.Text & "','" & P1CellTextBox.Text & "','" & P1EmailTextBox.Text & "','" & P2NameTextBox.Text & "','" & P2CellTextBox.Text & "','" & P2EmailTextBox.Text & "','" & "1" & "','" & "0" & "')")

                        ElseIf Not (ExamNoTextBox.Text.Length = 0) Then
                            SQL.RunQuery("INSERT INTO tblLearner(LearnerID, IDNo, ExamNo,LName,LSurname,LStreetAdd,LSuburb,LCity,LPCode,LGender,POneName,POneNo,POneEmail,PTwoName,PTwoNo,PTwoEmail,LStatus,LAccount) VALUES('" & ID & "','" & IDNoTextBox.Text & "','" & ExamNoTextBox.Text & "','" & NameTextBox.Text & "','" & SurnameTextBox.Text & "','" & Add1TextBox.Text & "','" & Add2TextBox.Text & "','" & Add3TextBox.Text & "','" & Add4TextBox.Text & "','" & gender & "','" & P1NameTextBox.Text & "','" & P1CellTextBox.Text & "','" & P1EmailTextBox.Text & "','" & P2NameTextBox.Text & "','" & P2CellTextBox.Text & "','" & P2EmailTextBox.Text & "','" & "1" & "','" & "0" & "')")

                        End If

                        Dim GradeID As Integer = Integer.Parse(grade)

                        SQL.RunQuery("INSERT INTO tblLearnerGrade(LearnerID, GRADEID, AccademicYear, Repeating) VALUES('" & ID & "','" & GradeID & "','" & AcademicYear & "','" & "0" & "')")

                        AddUSer()
                        If MessageBox.Show("Learner Data Saved. Do you wish to add another Learner ?", "Confirmation of Learner Added ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                            NameTextBox.Clear()
                            SurnameTextBox.Clear()
                            IDNoTextBox.Clear()
                            ExamNoTextBox.Clear()
                            GenderComboBox.SelectedIndex = -1
                            Add1TextBox.Clear()
                            Add2TextBox.Clear()
                            Add3TextBox.Clear()
                            Add4TextBox.Clear()
                            P1NameTextBox.Clear()
                            P1CellTextBox.Clear()
                            P2CellTextBox.Clear()
                            P1EmailTextBox.Clear()
                            P2NameTextBox.Clear()
                            P2EmailTextBox.Clear()
                            GradeComboBox.SelectedIndex = -1

                        Else
                            Me.Close()
                            Form1.Show()
                        End If
                    End If
                Else
                    msg = vbNewLine
                    If (NameTextBox.Text.Length = 0) Then
                        msg = msg + vbNewLine + "Please enter the learners name."
                    End If

                    If (SurnameTextBox.Text.Length = 0) Then
                        msg = msg + vbNewLine + "Please enter the learners surname."
                    End If

                    If Not (IDNoTextBox.Text.Length = 13) Then
                        msg = msg + vbNewLine + "Please enter a 13 digit identity number."
                    End If

                    If (ExamNoTextBox.Text.Length > 0) Then
                        If ((Not (ExamNoTextBox.Text.Length = 13))) Then
                            msg = msg + vbNewLine + "Please enter a 13 digit exam number."
                        End If
                    End If


                    If Not (GenderComboBox.SelectedIndex <> -1) Then
                            msg = msg + vbNewLine + "Select the appropriate gender of the learner from the combo box."
                        End If

                        If (Add1TextBox.Text.Length = 0) Then
                            msg = msg + vbNewLine + "Please enter the learners street address."
                        End If

                        If (Add2TextBox.Text.Length = 0) Then
                            msg = msg + vbNewLine + "Please enter the learners suburb."
                        End If
                        If (Add3TextBox.Text.Length = 0) Then
                            msg = msg + vbNewLine + "Please enter the city the learner stays in."
                        End If

                        If (Add4TextBox.Text.Length = 0) Then
                            msg = msg + vbNewLine + "Please enter the learners postal code."
                        End If
                        If (P1NameTextBox.Text.Length = 0) Then
                            msg = msg + vbNewLine + "Please enter the learners first parents name."
                        End If

                        If Not (P1CellTextBox.Text.Length = 10) Then
                            msg = msg + vbNewLine + "Please enter the first parents 10 digit cell number."
                        End If

                        If checkEmail(P1EmailTextBox.Text) = False Then
                            msg = msg + vbNewLine + "Please enter a valid email address for the first parent."
                        End If
                        If (P1EmailTextBox.Text.Length = 0) = True Then
                            msg = msg + vbNewLine + "Please enter an email address for the first parent."
                        End If



                    If (Not P2CellTextBox.Text.Length = 10 And P2CellTextBox.Text.Length > 0) Then
                        msg = msg + vbNewLine + "Please enter the second parents 10 digit cell number."
                    End If
                    If (checkEmail(P2EmailTextBox.Text) = False And P2EmailTextBox.Text.Length > 0) Then
                        msg = msg + vbNewLine + "Please enter a valid email address for the second parent."
                    End If

                    If Not (GradeComboBox.SelectedIndex <> -1) Then
                            msg = msg + vbNewLine + "Select the learners grade from the combo box."
                        End If

                    If Not (P1CellTextBox.Text.Length = 0) Then

                        If Not (Integer.Parse(P1CellTextBox.Text.ToString.Substring(0, 1)) = 0) Then
                            msg = msg + vbNewLine + "Invalid parent one cell number. Cell number does not begin with 0."
                        End If
                    End If
                    If (P2CellTextBox.Text.Length > 0) Then
                        If Not (Integer.Parse(P2CellTextBox.Text.ToString.Substring(0, 1)) = 0) Then
                            msg = msg + vbNewLine + "Invalid parent two cell number. Cell number does not begin with 0."
                        End If
                    End If

                    MessageBox.Show("You are missing the following details : " + msg, " Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    ElseIf (SQL.SQLDataSet.Tables(0).Rows.Count > 0) Then
                If (idExamNoCheck = 1) Then

                    If (SQL.SQLDataSet.Tables(0).Rows(0).Item("IDNo") = IDNoTextBox.Text.ToString) Then
                        MessageBox.Show("A learner with this ID number is already saved in the database", "Learner identity number already exists")
                    End If
                    If (SQL.SQLDataSet.Tables(0).Rows(0).Item("ExamNo") = ExamNoTextBox.Text.ToString) Then
                        MessageBox.Show("A learner with this exam number is already saved in the database", "Learner exam number already exists")
                    End If


                ElseIf (idExamNoCheck = 2) Then
                    If (SQL.SQLDataSet.Tables(0).Rows(0).Item("IDNo") = IDNoTextBox.Text.ToString) Then
                        MessageBox.Show("A learner with this ID number is already saved in the database", "Learner identity number already exists")
                    End If
                End If
            End If
        End If

    End Sub
    'only allowed to enter digits in textbox
    Private Sub IDNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ExamNoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExamNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub P1TellTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub P1CellTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1CellTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Public Sub AddUSer()
        Dim userName As String = SurnameTextBox.Text.Substring(0, 3) + ID.ToString

        Dim password As String = IDNoTextBox.Text.Substring(4, 2) + IDNoTextBox.Text.Substring(2, 2) + IDNoTextBox.Text.Substring(0, 2)
        SQL.RunQuery("Insert into tblUser Values('" & userName & "','" & password & "',Learner ,'" & ID & "',1)")

    End Sub
    Private Sub P2TellTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub P2CellTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P2CellTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Add4TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Add4TextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Function checkEmail(ByVal str As String) As Boolean
        Dim tf = True
        If ((Not str.Contains("@")) And (Not str.Contains("."))) Then
            tf = False
        End If
        Return tf
    End Function

    Public Function isFieldBlank(ByVal CheckField As String)
        If CheckField.Length = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub AddLearner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        HelpProvider1.HelpNamespace = strHelpPath
        PopComboBox()
        GradeComboBox.SelectedIndex = -1
        NameTextBox.Clear()
        SurnameTextBox.Clear()
        IDNoTextBox.Clear()
        ExamNoTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        Add1TextBox.Clear()
        Add2TextBox.Clear()
        Add3TextBox.Clear()
        Add4TextBox.Clear()
        P1NameTextBox.Clear()
        P1CellTextBox.Clear()
        P2CellTextBox.Clear()
        P1EmailTextBox.Clear()
        P2NameTextBox.Clear()
        P2EmailTextBox.Clear()

    End Sub

    Private Sub AddLearner_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked

        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.Topic)
    End Sub
End Class