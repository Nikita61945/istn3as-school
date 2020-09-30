Public Class SubjectDetails
    Public SQL As New DataBaseControl
    Private Sub SBATextBox_TextChanged(sender As Object, e As EventArgs) Handles SBATextBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to cancel ? Subject Details will not be saved", "Data will not be save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            AssignSubjectstoGrade.Show()
        End If
    End Sub

    Private Sub SubjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        If AssignSubjectstoGrade.GradeComboBox.SelectedIndex > -1 Then
            LabelGrade.Text = AssignSubjectstoGrade.GradeComboBox.SelectedItem.ToString
        End If

        If AssignSubjectstoGrade.isEdit = True Then
            If AssignSubjectstoGrade.SubGradeListBox.SelectedIndex > -1 Then
                LabelSubject.Text = AssignSubjectstoGrade.SubGradeListBox.SelectedItem.ToString
            End If
            If SQL.HasConnnection Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                Cursor.Current = Cursors.WaitCursor
                SQL.RunQuery("SELECT * FROM tblSubGrade, tblSubject WHERE tblSubject.SubjectID = tblSubGrade.SubjectID and tblSubject.SUbjectName = '" & AssignSubjectstoGrade.SubGradeListBox.SelectedItem.ToString & "' AND tblSubGrade.GradeID = '" & Integer.Parse(AssignSubjectstoGrade.GradeComboBox.SelectedItem.ToString) & "'")
                PassmarkTextBox.Text = SQL.SQLDataSet.Tables(0).Rows(0).Item("PassMark")
                SBATextBox.Text = FormatNumber(SQL.SQLDataSet.Tables(0).Rows(0).Item("SBA_Weight"), 2)
                If SQL.SQLDataSet.Tables(0).Rows(0).Item("isOffered") = True Then
                    IsOfferedCheckBox.Checked = True
                Else
                    IsOfferedCheckBox.Checked = False
                End If
                HoursReqNUD.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("NoOFHoursReq")

            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            Cursor.Current = Cursors.Arrow
        Else
            If AssignSubjectstoGrade.SubjectsListBox.SelectedIndex > -1 Then
                LabelSubject.Text = AssignSubjectstoGrade.SubjectsListBox.SelectedItem.ToString
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If AssignSubjectstoGrade.isEdit Then
                If (PassmarkTextBox.Text.Length > 0) And (SBATextBox.Text.Length > 0) Then
                    SQL.RunQuery("Update tblSubgrade SET PassMark ='" & PassmarkTextBox.Text & "' , SBA_Weight ='" & SBATextBox.Text & "' , NoOfHoursReq = '" & Integer.Parse(HoursReqNUD.Value) & "' WHERE SUBjectid = '" & LabelSubject.Text.ToString & "' AND GRadeID = '" & Integer.Parse(LabelGrade.Text.ToString) & "'")
                    SQL.SQLDataSet.Clear()
                    If IsOfferedCheckBox.Checked = True Then
                        SQL.RunQuery("Update tblSubgrade SET isOffered = 1 WHERE SUBjectid = '" & LabelSubject.ToString & "' AND GRadeID = '" & Integer.Parse(LabelGrade.Text.ToString) & "'")
                    Else
                        SQL.RunQuery("Update tblSubgrade SET isOffered = 0 WHERE SUBjectid = '" & LabelSubject.ToString & "' AND GRadeID = '" & Integer.Parse(LabelGrade.Text.ToString) & "'")
                    End If
                    MessageBox.Show("Subject information updated", "Subject update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Please fill In required fields", "Fields left empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If (PassmarkTextBox.Text.Length > 0) And (SBATextBox.Text.Length > 0) Then
                    SQL.RunQuery("Select * FROM tblsubgrade , tblSubject WHERE tblSubject.SubjectID = tblSubGrade.SubjectID And tblSubject.SUbjectName = '" & LabelSubject.Text.ToString & "' AND tblSubGrade.GradeID = '" & Integer.Parse(LabelGrade.Text.ToString) & "'")
                    If HoursReqNUD.Value = 0 Then
                        MessageBox.Show("Number of Teaching Hours Required cannot be 0")
                    Else
                        If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                            SQL.RunQuery("SELECT SUBJECTID FROM TblSubject WHERE SubjectName ='" & LabelSubject.Text.ToString & "'")
                            Dim SubID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SUBJECTID").ToString
                            SQL.SQLDataSet.Clear()
                            SQL.RunQuery("INSERT INTO tblSubGrade(SubjectID, GradeID, PassMark, isOffered, SBA_Weight, noOfhoursReq) VALUES('" & SubID & "','" & Integer.Parse(LabelGrade.Text.ToString) & "','" & Decimal.Parse(PassmarkTextBox.Text) & "','" & IsOfferedCheckBox.CheckState & "','" & Decimal.Parse(SBATextBox.Text) & "','" & Integer.Parse(HoursReqNUD.Value) & "')")
                            Cursor.Current = Cursors.Arrow
                            MessageBox.Show("New Subject added to grade", "Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If


                Else
                    Cursor.Current = Cursors.Arrow
                    MessageBox.Show("Please fill In required fields", "Fields left empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

            PassmarkTextBox.Clear()
            SBATextBox.Clear()
            LabelGrade.Text = ""
            LabelSubject.Text = ""
            HoursReqNUD.Value = 0
            Me.Close()
            AssignSubjectstoGrade.Show()


        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
End Class