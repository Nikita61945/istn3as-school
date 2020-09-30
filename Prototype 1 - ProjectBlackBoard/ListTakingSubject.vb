Public Class ListTakingSubject
    Private SQL As New DataBaseControl
    Dim GradeID As String
    Dim name As String
    Dim LearnerID As Integer
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "Blackboard.chm")
    Dim numOfActiveTerms As Integer
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
        End If
    End Sub
    Public Sub populateNameComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblLearner.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    Dim nameAndID As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString()
                    NameComboBox.Items.Add(nameAndID)
                    y = y + 1
                Next x
            End If
            NameComboBox.ValueMember = "LName"
        End If
    End Sub
    Public Sub populateSubjectsListBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblSubject.SubjectName, tblSubject.SubjectID, tblSubGrade.SubjectID, tblEnrolment.SubjectiD AS Expr1 
                          FROM tblSubject INNER JOIN tblSubGrade ON tblSubject.SubjectID = tblSubGrade.SubjectID 
                          INNER JOIN tblEnrolment ON tblSubGrade.SubjectId = tblEnrolment.SubjectId and tblSubgrade.Gradeid = tblEnrolment.GradeId
                            WHERE (tblEnrolment.LearnerID = '" & LearnerID & "' AND tblEnrolment.Active ='" & True & "' and tblSubGrade.GradeID ='" & GradeID & "')")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    CurrentSubjectsListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
            CurrentSubjectsListBox.ValueMember = "SubjectName"

        End If
    End Sub


    Private Sub SubjectChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Buttondrop.Enabled = False
        populateGradeComboBox()
        HelpProvider1.HelpNamespace = strHelpPath
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If GradeComboBox.SelectedIndex <> -1 Then
            GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
            NameComboBox.Items.Clear()
            populateNameComboBox()
        End If

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

        LearnerID = Integer.Parse(NameComboBox.SelectedItem.ToString.Substring(0, NameComboBox.SelectedItem.ToString.IndexOf(" ")))

        CurrentSubjectsListBox.Items.Clear()
        populateSubjectsListBox()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Close()
    End Sub

    Private Sub ListTakingSubject_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.Topic)
    End Sub

    Private Sub CurrentSubjectsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CurrentSubjectsListBox.SelectedIndexChanged
        Buttondrop.Enabled = True

    End Sub
    Public Sub checkTerm()
        numOfActiveTerms = 0
        If SQL.HasConnnection = True Then

            SQL.RunQuery("Select * from tblTerm")

            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = False) Then
                        numOfActiveTerms = numOfActiveTerms + 1
                    End If
                    y = y + 1
                Next x
            End If

        End If
    End Sub

    Private Sub Buttondrop_Click(sender As Object, e As EventArgs) Handles Buttondrop.Click
        If CurrentSubjectsListBox.SelectedIndex <> -1 Then
            If SQL.HasConnnection Then
                Dim DropCount = CurrentSubjectsListBox.SelectedItems.Count
                checkTerm()
                If numOfActiveTerms <= 2 Then
                    Dim substaken = CurrentSubjectsListBox.Items.Count - CurrentSubjectsListBox.SelectedItems.Count
                    If substaken > 6 Then
                        If DropCount <= 2 Then
                            If MessageBox.Show("Are you sure you want to drop " & DropCount.ToString & " Subjects", "Confirmation of Subject Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                For x = 0 To CurrentSubjectsListBox.Items.Count - 1
                                    If CurrentSubjectsListBox.GetSelected(x) Then
                                        SQL.RunQuery("Select SUbjectID From tblSubject Where SubjectName = '" & CurrentSubjectsListBox.Items(x).ToString & "'")
                                        Dim subID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectId")
                                        Select Case (numOfActiveTerms)
                                            Case 0 : SQL.RunQuery("Update tblEnrolment Set TermOne = 0, TermTwo = 0,TermThree = 0, TermFour = 0, Active =0 Where LearnerID =" & LearnerID & " AND SubjectID = '" & subID & "' AND GradeID = " & GradeID & "")

                                            Case 1 : SQL.RunQuery("Update tblEnrolment Set TermTwo = 0,TermThree = 0, TermFour = 0, Active =0 Where LearnerID =" & LearnerID & " AND SubjectID = '" & subID & "' AND GradeID = " & GradeID & "")
                                            Case 2 : SQL.RunQuery("Update tblEnrolment Set TermThree = 0, TermFour = 0, Active =0 Where LearnerID =" & LearnerID & " AND SubjectID = '" & subID & "' AND GradeID = " &
                                   GradeID & "")

                                        End Select
                                    End If
                                Next x
                                CurrentSubjectsListBox.Items.Clear()
                                populateSubjectsListBox()
                                If MessageBox.Show("Confirmation of Subjects dropped , Would you like to see Subjects for another learner ", "Confirmation of Subject Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    NameComboBox.Items.Clear()
                                    CurrentSubjectsListBox.Items.Clear()
                                    GradeComboBox.SelectedIndex = -1
                                End If
                            End If
                        Else
                            MessageBox.Show("More than 2 subjects cannot be dropped", "Subject Drop", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    Else
                        MessageBox.Show("Á student cannot take less than six subjects", "Subject Drop", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Else
                        MessageBox.Show("Subject(s) cannot be dropped in the last term", "Subject Drop", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


            Else
                    MessageBox.Show("Database not avilable, please contact admnistrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Select a subject(s) to drop", "No subjects selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class