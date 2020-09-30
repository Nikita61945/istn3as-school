Public Class CreatePOA
    Public SQL As New DataBaseControl
    Dim selectedGrade As Integer
    Dim TopicName As String
    Dim SubGradeID As String
    Dim Mesg As String

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CreatePOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = Form1

        YearTextBox.Text = Date.Today.Year.ToString

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
        End If

        SQL.RunQuery("SELECT GradeID from tblGrade WHERE isOffered = 1")
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                Grades.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                y = y + 1
            Next
        End If

        SQL.RunQuery("SELECT POAID FROM tblPOA")
        Dim ID As Integer
        If (SQL.SQLDataSet.Tables(0).Rows.Count = 0) Then
            ID = 1
        Else
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("SELECT MAX(POAID) AS HIGHESTID FROM tblPOA")
            ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HIGHESTID") + 1
        End If
        PoaIDTextBox.Text = ID
        DateGiven.MinDate = Date.Parse(Today.Year.ToString + "/01/01")
        DateGiven.MaxDate = Date.Parse(Today.Year.ToString + "/12/31")
        DateDue.MinDate = Date.Parse(Today.Year.ToString + "/01/01")
        DateDue.MaxDate = Date.Parse(Today.Year.ToString + "/12/31")


    End Sub

    Public Sub checkTerm()
        If (Integer.Parse(termCombo.SelectedIndex) = 0) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 1")
            DateGiven.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 1")
            DateDue.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termCombo.SelectedIndex) = 1) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 2")
            DateGiven.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 2")
            DateDue.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termCombo.SelectedIndex) = 2) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 3")
            DateGiven.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 3")
            DateDue.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termCombo.SelectedIndex) = 3) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 4")
            DateGiven.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 4")
            DateDue.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Mesg = vbNullString
        If IsNumeric(TotalTextBox.Text) = False Then
            Mesg += "Invalid total, please enter a valid numeric value" + Environment.NewLine
            TotalTextBox.Clear()
        End If

        If Grades.SelectedIndex = -1 Then
            Mesg += ("No grade has been selected, please select a grade") + Environment.NewLine
            Grades.SelectedIndex = -1
        End If

        If Subjects.SelectedIndex = -1 Then
            Mesg += ("No subject has been selected, please select a subject") + Environment.NewLine
            Subjects.SelectedIndex = -1
        End If
        If termCombo.SelectedIndex = -1 Then
            Mesg += ("No term has been selected, please select a term") + Environment.NewLine
            termCombo.SelectedIndex = -1
        End If
        If CalculationType.SelectedIndex = -1 Then
            Mesg += ("No calculation has been selected, please select a calculation") + Environment.NewLine
            CalculationType.SelectedIndex = -1
        End If
        If (PassMarkTextBox.Text).Length > 0 Then
            If IsNumeric(PassMarkTextBox.Text) Then
                If (Integer.Parse(PassMarkTextBox.Text) <= 100 And Integer.Parse(PassMarkTextBox.Text) > Integer.Parse(TotalTextBox.Text)) Then
                    Mesg += ("Invalid passmark, please re-enter") + Environment.NewLine
                    PassMarkTextBox.Clear()
                End If
            Else
                Mesg += ("Pass mark has to be numeric") + Environment.NewLine
                PassMarkTextBox.Clear()
            End If
        Else
            Mesg += ("Pass mark cannot be empty") + Environment.NewLine
            PassMarkTextBox.Clear()
        End If

        If (WeightingTextBox.Text).Length > 0 Then
            If IsNumeric(WeightingTextBox.Text) Then
                If (Integer.Parse(WeightingTextBox.Text) > 100) Then
                    Mesg += ("Invalid weighting, weighting cannot be more than 100 ") + Environment.NewLine
                    WeightingTextBox.Clear()
                End If
            Else
                Mesg += ("Invalid weighting, please enter a valid numeric value") + Environment.NewLine
                WeightingTextBox.Clear()
            End If
        Else
            Mesg += ("Weighting cannot be empty") + Environment.NewLine
            WeightingTextBox.Clear()
        End If

        If (TopicTextBox.Text).Length = 0 Then
            Mesg += ("Topic cannot be empty") + Environment.NewLine
            TopicTextBox.Text = ""
        End If
        If (txtTaskNo.Text).Length > 0 Then
            If IsNumeric(txtTaskNo.Text) = False Then
                Mesg += ("Invalid Task Number, please enter a valid numeric value") + Environment.NewLine
                txtTaskNo.Clear()
            End If
        Else
            Mesg += ("Task No cannot be empty please enter a numeric value") + Environment.NewLine
            txtTaskNo.Clear()
        End If

        If DateDue.Value < DateGiven.Value Then
            Mesg += ("Invalid due date, Date due cannot be be before Date given") + Environment.NewLine
        End If

        If Mesg = vbNullString Then
            SQL.RunQuery("SELECT Topic,TaskNo FROM tblPOA WHERE Topic ='" & TopicName & "' AND TaskNo ='" & Integer.Parse(txtTaskNo.Text) & "' AND SubjectID ='" & Subjects.SelectedItem.ToString & "'AND GradeID ='" & Integer.Parse(Grades.SelectedItem.ToString) & "' AND Term ='" & Integer.Parse(termCombo.SelectedItem) & "' AND Year ='" & Integer.Parse(YearTextBox.Text) & "'")
            If (SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False) Then
                MessageBox.Show("POA already exists", "Error : POA EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim TermNo As Integer = Integer.Parse(termCombo.SelectedItem)
                Dim YearNo As Integer = Integer.Parse(YearTextBox.Text)
                Dim Given As Date = DateGiven.Value
                Dim Due As Date = DateDue.Value
                TopicName = TopicTextBox.Text
                Dim TotalNo As Decimal = Convert.ToDecimal(TotalTextBox.Text)
                Dim PassMark As Decimal = Convert.ToDecimal(PassMarkTextBox.Text)
                Dim WeightingP As Decimal = Convert.ToDecimal(WeightingTextBox.Text)
                Dim Calculation As String = CalculationType.SelectedItem

                Dim ActiveB As Integer
                If Active.Checked = True Then
                    ActiveB = 1
                Else
                    ActiveB = 0
                End If

                Dim SBA As Integer
                If isSBA.Checked = True Then
                    SBA = 1
                Else
                    SBA = 0
                End If
                SQL.RunQuery("Select sum(Weighting) as Sum from tblPOA where Active=1 and SubjectID = '" & Subjects.SelectedItem & "' AND GradeID = " & Integer.Parse(Grades.SelectedItem) & " group by SubjectID,GradeID")
                If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                    Dim sum As Integer = SQL.SQLDataSet.Tables(0).Rows(0).Item("Sum")

                    If (sum > 100) Then
                        MessageBox.Show("POA cannot be created, SBA weightings are 100", "SBA Full", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                        Form1.Show()
                    End If
                Else
                    SQL.RunQuery("INSERT into tblPOA (POAID,SubjectID,GradeID,Term,Year,DateGiven,DateDue,Topic,Total,PassMark,Weighting,CalcType,Active,Status,isSBA,TaskNo) VALUES ('" & Integer.Parse(PoaIDTextBox.Text) & "','" & Subjects.SelectedItem.ToString & "','" & Integer.Parse(Grades.SelectedItem) & "','" & TermNo & "','" & YearNo & "','" & Given & "','" & Due & "','" & TopicName & "','" & TotalNo & "','" & PassMark & "','" & WeightingP & "','" & Calculation & "','" & ActiveB & "','" & "O" & "','" & SBA & "','" & Integer.Parse(txtTaskNo.Text) & "')")
                    ' MsgBox("Record successfully saved!")
                    If (MessageBox.Show("POA successfully Created. Do you wish to create another?", "Confirmation of POA", MessageBoxButtons.YesNo)) = DialogResult.Yes Then
                        PoaIDTextBox.Text = ""
                        Grades.Text = ""
                        Subjects.SelectedIndex = -1
                        termCombo.SelectedIndex = -1
                        DateGiven.Value = Date.Now
                        DateDue.Value = Date.Now
                        TopicTextBox.Text = " "
                        TotalTextBox.Text = ""
                        WeightingTextBox.Text = ""
                        PassMarkTextBox.Text = ""
                        CalculationType.SelectedIndex = -1
                        Active.Checked = False
                        isSBA.Checked = False
                        txtTaskNo.Text = " "
                    Else
                        Me.Close()
                        Form1.Show()
                    End If
                End If

            End If



        Else
            MessageBox.Show(Mesg, "Errors in form", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mesg = vbNullString
        End If

    End Sub

    Private Sub Grades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grades.SelectedIndexChanged
        SQL.SQLDataSet.Clear()
        If Grades.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Grade", "NO Grade Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            selectedGrade = Grades.SelectedItem
        End If
        Subjects.Text = ""
        Subjects.Items.Clear()
        SQL.RunQuery("SELECT SubjectID FROM tblSubGrade WHERE GradeID =" & selectedGrade & " AND isOffered = 1 ")
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                Subjects.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID"))
                y = y + 1
            Next
        End If

    End Sub


    Private Sub POACancelButton_Click_1(sender As Object, e As EventArgs) Handles POACancelButton.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to cancel attempt?", vbYesNo, "Cancelation of POA Capture")
        If ans = vbYes Then
            PoaIDTextBox.Text = ""
            Grades.Text = ""
            Subjects.SelectedIndex = -1
            termCombo.SelectedIndex = -1
            DateGiven.Value = Date.Now
            DateDue.Value = Date.Now
            TopicTextBox.Text = " "
            TotalTextBox.Text = ""
            WeightingTextBox.Text = ""
            PassMarkTextBox.Text = ""
            CalculationType.SelectedIndex = -1
            Active.Checked = False
            isSBA.Checked = False
            txtTaskNo.Text = " "
        End If

    End Sub

    Private Sub YearTextBox_TextChanged(sender As Object, e As EventArgs) Handles YearTextBox.TextChanged

    End Sub
    Private Sub termCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles termCombo.SelectedIndexChanged
        If termCombo.SelectedIndex > -1 Then
            checkTerm()
        End If
    End Sub
End Class