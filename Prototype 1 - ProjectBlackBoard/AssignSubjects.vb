Public Class AssignSubjects
    Private SQL As New DataBaseControl
    Dim GradeID As Integer = 0
    Dim Count As Integer = 0
    Dim LName As String
    Dim Msg As String
    Dim SubGrade As String
    Dim ID As Integer
    Dim choseMsg As Integer
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "Blackboard.chm")
    Dim SubCount As Integer = 0
    Dim GradeMax As Integer = 0
    Public Sub populateGradeComboBox()
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
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub populateNameComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblLearnerGrade.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE (tblLearnerGrade.GRADEID = '" & GradeID & "' AND tblLearner.LStatus = '" & True & "') AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    Dim ItemToAdd As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString()
                    NameComboBox.Items.Add(ItemToAdd)
                    y = y + 1
                Next x
            End If
            NameComboBox.ValueMember = "LName"
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub populateSubjectsListBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select tblSubject.SubjectName FROM (tblSubject INNER JOIN tblSubGrade On tblSubject.SubjectID = tblSubGrade.SubjectID) WHERE tblSubGrade.GRADEID = '" & GradeID & "' AND tblSubGrade.isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    SubjectsListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
            SubjectsListBox.ValueMember = "SubjectName"
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AssignSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        HelpProvider1.HelpNamespace = strHelpPath
    End Sub

    Private Sub AssignSubjects_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        populateGradeComboBox()
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged

        If GradeComboBox.SelectedIndex > 1 Then
            GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
            If (GradeID >= 10) And (GradeID <= 12) Then
                GradeMax = 10
            ElseIf (GradeID >= 7) And (GradeID <= 9) Then
                GradeMax = 12
            Else
                GradeMax = 13
            End If

            NameComboBox.Items.Clear()
            populateNameComboBox()
            SubjectsListBox.Items.Clear()
            populateSubjectsListBox()
        End If

    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If MessageBox.Show("Are you sure you want to enrol this learner for these subjects ?", "Confirmation Of Learner Enrollment ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If (SubCount + SubjectsListBox.SelectedItems.Count) > GradeMax Then
                Dim t = (GradeMax - SubCount).ToString
                MessageBox.Show("Student cannot be enrolled for this many Subjects, Student can only be enrolled for " & t & " more Subjects", "Max Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else


                If GradeComboBox.SelectedIndex <> -1 And NameComboBox.SelectedIndex <> -1 And SubjectsListBox.SelectedItems.Count > 0 Then
                    If SQL.HasConnnection = True Then
                        If SQL.SQLDataSet IsNot Nothing Then
                            SQL.SQLDataSet.Clear()
                        End If
                        Count = 0

                        Dim SubGrade As String = ""
                        Msg = vbNewLine
                        For a = 0 To SubjectsListBox.Items.Count - 1

                            If (SubjectsListBox.GetSelected(a)) Then
                                SQL.RunQuery("SELECT tblSubGrade.SubjectID FROM tblSubGrade INNER JOIN tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE (tblSubject.SubjectName = '" & SubjectsListBox.Items(a) & "' AND tblSubGrade.GradeID = '" & GradeID & "' )")
                                Dim Subject As String = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID")

                                SQL.RunQuery("SELECT * FROM (tblEnrolment INNER JOIN tblSubGrade on tblEnrolment.SubjectID = tblSubGrade.SubjectID and tblEnrolment.GradeID = tblSubGrade.GradeID) WHERE( LearnerID = '" & ID & "' AND tblEnrolment.SubjectID = '" & Subject & "' AND tblSubGrade.GradeID = '" & GradeID & "' AND Active = '" & True & "')")
                                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                                    Dim y As Integer = 0

                                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                                        SQL.RunQuery("Select tblSubject.SubjectName FROM (tblSubject INNER JOIN tblSubGrade On tblSubject.SubjectID = tblSubGrade.SubjectID) WHERE tblSubject.SubjectID = '" & SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID") & "' AND GradeID = '" & SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID") & "'")
                                        Dim subj As String = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectName")
                                        y = y + 1
                                        Msg = Msg + vbNewLine + subj
                                    Next x
                                    choseMsg = 1
                                End If

                                SQL.RunQuery("SELECT SubjectID, GradeID,LearnerID FROM tblEnrolment WHERE( LearnerID = '" & ID & "' AND SubjectID = '" & Subject & "' AND GradeID = '" & GradeID & "' AND Active = '" & False & "')")

                                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                                    Dim upLearner = Integer.Parse(SQL.SQLDataSet.Tables(0).Rows(0).Item("LearnerID"))
                                    Dim upSubID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID").ToString
                                    Dim upGradeID = SQL.SQLDataSet.Tables(0).Rows(0).Item("GradeID").ToString
                                    Dim y As Integer = 0
                                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                                        SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & True & "' WHERE LearnerID = '" & upLearner & "' and SubjectID = '" & upSubID & "' and GradeID = '" & upGradeID & "'")
                                        SQL.RunQuery("Select tblSubject.SubjectName FROM (tblSubject INNER JOIN tblSubGrade On tblSubject.SubjectID = tblSubGrade.SubjectID) WHERE SubjectID = '" & SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID") & "' GradeID = '" & SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID") & "'")
                                        Dim subj As String = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectName")
                                        Msg = Msg + vbNewLine + subj
                                        y = y + 1
                                        choseMsg = 2
                                    Next x
                                End If
                                SQL.RunQuery("SELECT SubjectID,GradeID,LearnerID FROM tblEnrolment WHERE( LearnerID = '" & ID & "' AND SubjectID = '" & Subject & "' AND GradeID = '" & GradeID & "')")

                                If SQL.SQLDataSet.Tables(0).Rows.Count = 0 Then
                                    Dim NSub As String = " "
                                    Dim NGrade As String = " "
                                    Dim AcademicYear As Integer = Convert.ToInt32(Now.ToString("yyyy"))

                                    Dim TermOne As Integer = 1
                                    Dim TermTwo As Integer = 1
                                    Dim TermThree As Integer = 1
                                    Dim TermFour As Integer = 1

                                    Msg = vbNewLine
                                    If (SubjectsListBox.GetSelected(a)) Then
                                        SQL.RunQuery("SELECT tblSubGrade.SubjectID,tblSubGrade.GradeID FROM tblSubGrade INNER JOIN tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE (tblSubject.SubjectName = '" & SubjectsListBox.Items(a) & "' AND tblSubGrade.GradeID = '" & GradeID & "' )")

                                        NSub = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID").ToString
                                        NGrade = SQL.SQLDataSet.Tables(0).Rows(0).Item("GradeID").ToString

                                        SQL.RunQuery("SELECT SubjectID,GradeID FROM tblEnrolment WHERE( LearnerID = '" & ID & "' AND SubjectID = '" & NSub & "' AND GradeID = '" & NGrade & "')")
                                        If SQL.SQLDataSet.Tables(0).Rows.Count = 0 Then
                                            SQL.RunQuery("INSERT INTO tblEnrolment (LearnerID, AcademicYear, TermOne, TermTwo, TermThree, TermFour, Active, SubjectID,GradeID)VALUES('" & ID & "','" & AcademicYear & "','" & TermOne & "','" & TermTwo & "','" & TermThree & "','" & TermFour & "','" & 1 & "','" & NSub & "','" & NGrade & "')")
                                            Count = Count + 1
                                        End If
                                    End If
                                End If

                            End If
                        Next a
                    Else
                        Cursor.Current = Cursors.Arrow
                        MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                If Not (GradeComboBox.SelectedIndex <> -1) Then
                    MessageBox.Show("Please choose a grade from the grade combo box", "No Grade Chosen")
                End If
                If Not (NameComboBox.SelectedIndex <> -1) Then
                    MessageBox.Show("Please choose a learner from the learner name combo box", "No Learner Chosen")
                End If
                If (SubjectsListBox.SelectedItems.Count = 0) Then
                    MessageBox.Show("Please choose subjects to enrol the learner in", "No Subjects Chosen")
                End If
                If (Count > 0) Then
                    If MessageBox.Show("Learner Has Been Enrolled for " + Count.ToString + " Subjects! , do you want to assign subjects to another learner", "Enrollment Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        RichTextBox1.Clear()
                        SubjectsListBox.Items.Clear()
                        NameComboBox.Items.Clear()
                        GradeComboBox.SelectedIndex = -1
                    Else
                        Me.Close()
                    End If

                End If

                If (choseMsg = 1) Then
                    MessageBox.Show(NameComboBox.SelectedItem.ToString.Substring(NameComboBox.SelectedItem.ToString.IndexOf("-") + 2, NameComboBox.SelectedItem.ToString.Length - (NameComboBox.SelectedItem.ToString.IndexOf("-") + 2)) + " has already been enrolled for these subjects : " + Msg, " Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If (choseMsg = 2) Then
                    MessageBox.Show(NameComboBox.SelectedItem.ToString.Substring(NameComboBox.SelectedItem.ToString.IndexOf("-") + 2, NameComboBox.SelectedItem.ToString.Length - (NameComboBox.SelectedItem.ToString.IndexOf("-") + 2)) + " has already been re-enrolled for these subjects : " + Msg, "Learner Re-Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End If

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        SubjectsListBox.SelectedItems.Clear()
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged
        SubjectsListBox.Enabled = True
        SaveButton.Enabled = True
        ID = (NameComboBox.SelectedItem.ToString.Substring(0, NameComboBox.SelectedItem.ToString.IndexOf(" ")))
        SubCount = 0
        Dim CYear As Integer = System.DateTime.Today.Year
        RichTextBox1.Clear()
        SubjectsListBox.Items.Clear()
        populateSubjectsListBox()
        SQL.RunQuery("SELECT * FROm Tblenrolment, tblSubject Where Tblenrolment.SubjectID =TblSubject.SubjectID AND Tblenrolment.LearnerID =" & ID & " AND Tblenrolment.GradeID =" & GradeID & " And Tblenrolment.AcademicYear =" & CYear & "")
        If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1

                RichTextBox1.AppendText(SQL.SQLDataSet.Tables(0).Rows(x).Item("SubjectNAme") + vbNewLine)
                For y = 0 To SubjectsListBox.Items.Count() - 1
                    If (SQL.SQLDataSet.Tables(0).Rows(x).Item("SubjectNAme").ToString = SubjectsListBox.Items(y).ToString) Then
                        SubjectsListBox.Items.RemoveAt(y)
                        SubCount += 1
                        Exit For
                    End If
                Next y
            Next x
        End If

        If SubCount = GradeMax Then
            MessageBox.Show("Student is Enrolled For Maximum No of subjects, to further Enroll Student Subjects must be either dropped or changed", "Max Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SaveButton.Enabled = False
            SubjectsListBox.Enabled = False
        End If

    End Sub

    Private Sub AssignSubjects_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.Topic)
    End Sub


    Private Sub NameComboBox_TextChanged(sender As Object, e As EventArgs) Handles NameComboBox.TextChanged
        If NameComboBox.Text.Length > 0 Then
            If Not (IsNumeric(NameComboBox.Text)) Then
                If SQL.HasConnnection = True Then

                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    SQL.RunQuery("SELECT tblLearner.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "' AND (tblLearner.LName LIKE '" & NameComboBox.Text & "' + '%')")

                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                        NameComboBox.Items.Clear()
                        Dim y As Integer = 0
                        For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                            Dim nameAndID As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString
                            NameComboBox.Items.Add(nameAndID)
                            y = y + 1
                        Next x
                    ElseIf Not (NameComboBox.Items.Count > 0) Then
                        MessageBox.Show("No such student found!", "Learner Does Not Exist")
                    End If
                    NameComboBox.ValueMember = "LName"
                End If
            Else
                If SQL.HasConnnection = True Then

                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    SQL.RunQuery("SELECT tblLearner.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "' AND (tblLearner.LearnerID LIKE '" & NameComboBox.Text & "' + '%')")
                    NameComboBox.Items.Clear()
                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                        Dim y As Integer = 0
                        For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                            Dim nameAndID As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString
                            NameComboBox.Items.Add(nameAndID)
                            y = y + 1
                        Next x

                    End If
                    NameComboBox.ValueMember = "LName"
                End If
            End If
        End If
        If (NameComboBox.Text.Length = 0) Then
            RichTextBox1.Clear()
            SubjectsListBox.Items.Clear()
            populateSubjectsListBox()
        End If
    End Sub

End Class