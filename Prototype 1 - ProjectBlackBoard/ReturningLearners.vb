Public Class ReturningLearners
    Dim sql As New DataBaseControl
    Dim GradeID As Integer
    Dim newGrade As Integer
    Dim learnerID As Integer
    Dim numOfActiveTerms = 0
    Private Sub ReturningLearners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        populateGradeComboBox()
        checkTerm()
    End Sub
    Public Sub populateNameListBox()
        If sql.HasConnnection = True Then

            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("SELECT tblLearner.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "'AND tblLearner.LStatus = '" & False & "'")
            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In sql.SQLDataSet.Tables(0).Rows

                    Dim nameAndID As String = sql.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + sql.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + sql.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString
                    ListBox1.Items.Add(nameAndID)

                    y = y + 1
                Next x
            End If
            ListBox1.ValueMember = "LName"
        End If
    End Sub
    Public Sub populateGradeComboBox()
        If sql.HasConnnection = True Then

            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If
            sql.RunQuery("SELECT GradeID, convert(varChar(6),GradeID) FROM tblGrade WHERE isOffered = '1'")
            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In sql.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(sql.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
            GradeComboBox.ValueMember = "GradeID"
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If GradeComboBox.SelectedIndex > 0 Then
            GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
            ListBox1.Items.Clear()
            populateNameListBox()
        End If

    End Sub

    Private Sub ReActivate_Click(sender As Object, e As EventArgs) Handles ReActivate.Click
        If sql.HasConnnection = True Then
            If ListBox1.SelectedItems.Count > 0 Then
                If MessageBox.Show("Are you sure you want to re-activate this learner(s) ?", "Confirmation of Learner Transfer ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If sql.SQLDataSet IsNot Nothing Then
                        sql.SQLDataSet.Clear()
                    End If
                    Dim couut As Integer = 0
                    If (RadioButton1.Checked = True Or RadioButton2.Checked = True) Then
                        For a = 0 To ListBox1.Items.Count - 1

                            If (ListBox1.GetSelected(a)) Then
                                learnerID = (ListBox1.Items(a).ToString.Substring(0, ListBox1.Items(a).ToString.IndexOf(" ")))
                                couut += 1


                                If (RadioButton1.Checked = True) Then
                                    sql.RunQuery("UPDATE tblLearner SET LStatus = '" & True & "' WHERE LearnerID = '" & learnerID & "'")
                                    sql.RunQuery("UPDATE tblLearnerGrade SET Repeating = '" & True & "' WHERE LearnerID = '" & learnerID & "'")
                                    If (numOfActiveTerms = 0) Then
                                        sql.RunQuery("UPDATE tblEnrolment SET Active = '" & True & "' WHERE LearnerID = '" & learnerID & "'")
                                    End If

                                    If (numOfActiveTerms = 1) Then
                                        sql.RunQuery("UPDATE tblEnrolment SET Active = '" & True & "',TermOne = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                                    End If

                                    If (numOfActiveTerms = 2) Then
                                        sql.RunQuery("UPDATE tblEnrolment SET Active = '" & True & "',TermOne = '" & 0 & "',TermTwo = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                                    End If

                                    If (numOfActiveTerms = 3) Then

                                        sql.RunQuery("UPDATE tblEnrolment SET Active = '" & True & "',TermOne = '" & 0 & "',TermTwo = '" & 0 & "',TermThree = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                                    End If

                                    If (numOfActiveTerms = 4) Then
                                        MessageBox.Show("Please enter the student into the new academic year", "Learner Enrolment too late")
                                    End If
                                End If

                                If (RadioButton2.Checked = True) Then

                                    sql.RunQuery("UPDATE tblLearner SET LStatus = '" & True & "' WHERE LearnerID = '" & learnerID & "'")
                                    sql.RunQuery("INSERT INTO tblLearnerGrade(LearnerID, GRADEID, AccademicYear, Repeating) VALUES('" & learnerID & "','" & newGrade & "','" & Convert.ToInt32(Now.ToString("yyyy")) & "','" & "0" & "')")

                                End If
                            End If
                        Next a
                        If MessageBox.Show(couut.ToString + " Learner(s) has been re-enroll!, do you want to re-enrol another learner(s) ", "Confirmation of Learner Re-enrol", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            ListBox1.Items.Clear()
                            GradeComboBox.SelectedIndex = 0
                            ReActivate.Enabled = False
                        Else
                            Me.Close()
                            Form1.Show()
                        End If
                    Else
                        MessageBox.Show("Please select a grade to enrol the learner(s) in", "No grade selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            Else
                MessageBox.Show("Please select a learner to re-enroll first", "No learner selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        newGrade = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length))) + 1
    End Sub
    Public Sub checkTerm()
        numOfActiveTerms = 0
        If sql.HasConnnection = True Then

            sql.RunQuery("Select * from tblTerm")

            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In sql.SQLDataSet.Tables(0).Rows
                    If (sql.SQLDataSet.Tables(0).Rows(y).Item("Status") = False) Then
                        numOfActiveTerms = numOfActiveTerms + 1
                    End If
                    y = y + 1
                Next x
            End If

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ReActivate.Enabled = True

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For x = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedItems.Add(ListBox1.Items(x))
            Next x
        Else
            For x = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedItems.Remove(ListBox1.Items(x))
            Next x
        End If

    End Sub
End Class