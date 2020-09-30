Public Class AssignSubjectstoGrade
    Public SQL As New DataBaseControl
    Public SubGradeID As String
    Public isEdit = False

    Private Sub AssignSubjectstoGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        populateGradeComboBox()
        AddButton.Enabled = False
        EditButton.Enabled = False

    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub populateSubjectListBox()
        SubjectsListBox.Items.Clear()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT SubjectName FROM tblSubject WHERE tblSubject.SubjectID NOT IN (SELECT tblSubGrade.SubjectID FROM tblSubGrade Where GradeID =' " & Integer.Parse(GradeComboBox.SelectedItem.ToString) & "' AND isOffered =1 )")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    SubjectsListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
            SubjectsListBox.DisplayMember = "SubjectName"
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub populateGradeComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT GradeID FROM tblGrade WHERE isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeId"))
                    y = y + 1
                Next
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If SubjectsListBox.SelectedIndex > -1 Then
            Me.Hide()

            SubjectDetails.Show()
            populateSubGradeListBox()
            populateSubjectListBox()
        Else
            MessageBox.Show("No Subject selected to be added to Grade , Please select a Subject First", "Warning: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub populateSubGradeListBox()
        SubGradeListBox.Items.Clear()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblSubject.SubjectName FROM tblSubGrade , tblSubject WHERE tblSubject.SubjectID=tblSubGrade.SubjectID and TblSubject.SubjectID IN (SELECT SUbjectID From TblsubGrade)  AND TblSUbGrade.GradeID ='" & Integer.Parse(GradeComboBox.SelectedItem.ToString) & "' AND tblSubGrade.isOffered =1")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    SubGradeListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectNAme"))
                    y = y + 1
                Next x
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        populateSubjectListBox()
        populateSubGradeListBox()
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub SubjectsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectsListBox.SelectedIndexChanged
        AddButton.Enabled = True
        GradeComboBox.Enabled = False
        EditButton.Enabled = False


    End Sub

    Private Sub SubGradeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubGradeListBox.SelectedIndexChanged
        EditButton.Enabled = True

        GradeComboBox.Enabled = False
        AddButton.Enabled = False
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        isEdit = True
        If SubGradeListBox.SelectedIndex > -1 Then
            Me.Hide()
            SubjectDetails.Show()
            populateSubGradeListBox()
            populateSubjectListBox()
        Else
            MessageBox.Show("No Subject selected to be edited , Please select a Subject First", "Warning: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AssignSubjectstoGrade_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        GradeComboBox.Enabled = True
        If GradeComboBox.SelectedIndex > -1 Then
            populateSubGradeListBox()
            populateSubjectListBox()
        End If
        isEdit = False
    End Sub
End Class