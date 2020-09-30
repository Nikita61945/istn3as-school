Public Class AddTutorToSubjects
    Public SQL As New DataBaseControl
    Dim TutorId As Integer
    Private Sub AddTutorToSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.MdiParent = Form1
        GradeComboBox.Enabled = False
        AddButton.Enabled = False
        If Sql.HasConnnection() = True Then
            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT  TutorID,  convert(varChar(6),TutorID)+' '+FName +' '+Surname AS 'Identify' FROM tblTutor")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    TutorComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Identify"))

                    y = y + 1
                Next x
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        SubjectListBox.Items.Clear()
        Cursor.Current = Cursors.WaitCursor
        If GradeComboBox.SelectedIndex > -1 Then
            If SQL.HasConnnection() = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblSubject.SubjectName FROM tblSubject, tblSubGrade WHERE tblSubject.SubjectId = tblSubGrade.SubjectID and tblSubGrade.isOffered= 1 and tblSubGrade.GradeID ='" & Integer.Parse(GradeComboBox.SelectedItem.ToString) & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then

                    Dim y As Integer = 0
                    For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                        SubjectListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                        y = y + 1
                    Next
                End If
            Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub SubjectListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectListBox.SelectedIndexChanged
        AddButton.Enabled = True

    End Sub

    Private Sub TutorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorComboBox.SelectedIndexChanged
        GradeComboBox.Enabled = True
        If TutorComboBox.SelectedIndex > -1 Then
            Cursor.Current = Cursors.WaitCursor
            TutorSubListBox.Items.Clear()
            TutorSubListBox.Items.Add("Grade" + vbTab + "Subject")
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                TutorId = TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" "))
                SQL.RunQuery("SELECT tblSubgrade.GradeID , tblSubject.SubjectName FROM tblSubgrade,tblSubject WHERE tblSubgrade.SubjectID = tblSubject.SubjectID AND TutorID = '" & Integer.Parse(TutorId) & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                    For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                        TutorSubListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(x).Item("GradeID").ToString + vbTab + SQL.SQLDataSet.Tables(0).Rows(x).Item("SUbjectNAme").ToString)
                    Next x
                Else
                    MessageBox.Show("Tutor is not assigned to any subjects", "No Subjects assigned to tutor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Cursor.Current = Cursors.WaitCursor
        Dim count As Integer = 0
        Dim ID As String
        TutorId = TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" "))
        Dim Grade As Integer = Integer.Parse(GradeComboBox.SelectedItem.ToString)
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            For x = 0 To SubjectListBox.Items.Count - 1
                If SubjectListBox.GetSelected(x) Then
                    SQL.RunQuery("SELECT SUBjectID FRom tblsubject where SUbjectName ='" & (SubjectListBox.Items(x).ToString) & "'")
                    ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID")
                    SQL.RunQuery("SELECT tblTutor.TutorID,tblTutor.FName + ' ' + tblTutor.Surname AS FullName FROM tblTutor,tblSubgrade where tblTutor.TutorId= tblSubGrade.TutorID and tblSubGrade.GradeId = '" & Grade & "' AND tblSubGrade.SubjectID = '" & ID & "'")

                    If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                        SQL.RunQuery("UPDATE tblSubgrade SET TutorID = '" & TutorId & "' WHERE GradeId = '" & Grade & "' AND tblSubGrade.SubjectID = '" & ID & "'")
                        SQL.SQLDataSet.Clear()
                        count = count + 1
                    Else
                        Dim tutorname As String = SQL.SQLDataSet.Tables(0).Rows(0).Item("FullName")
                        If SQL.SQLDataSet.Tables(0).Rows(0).Item("TutorID").Equals(TutorId) = False Then
                            If MessageBox.Show(tutorname + " is currently teaching : Grade " + Grade.ToString + " " + ID.ToString + ".Do you want to replace them ?", "Tutor already assigned", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                SQL.RunQuery("UPDATE tblSubgrade SET TutorID = '" & TutorId & "' WHERE GradeId = '" & Grade & "' AND tblSubGrade.SubjectID = '" & ID & "'")
                                SQL.SQLDataSet.Clear()
                                count = count + 1
                            End If
                        End If
                    End If

                End If
            Next x
            MessageBox.Show(count.ToString + " Subjects assigned to tutor " + (TutorComboBox.SelectedItem.ToString).Substring(TutorComboBox.SelectedItem.ToString.IndexOf(" ")), "Confirmation of Tutor Added to subjects", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MessageBox.Show("Do you want to assign subjects to a different tutor ? ", "Adding Subjects to Tutor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                SubjectListBox.Items.Clear()
                AddButton.Enabled = False
                TutorSubListBox.Items.Clear()
                TutorComboBox.SelectedIndex = -1
                GradeComboBox.SelectedIndex = -1
            Else
                Form1.Show()
                Me.Close()
            End If

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub AddTutorToSubjects_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Cursor.Current = Cursors.WaitCursor
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID From tblGrade WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub TutorSubListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorSubListBox.SelectedIndexChanged

    End Sub
End Class