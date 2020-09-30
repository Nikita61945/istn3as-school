Public Class ListOfLearnersTakingSubject
    Public SQL As New DataBaseControl
    Private Sub ListOfLearnersTakingSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
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
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        NamesRTB.Clear()
        SubjectsListBox.Items.Clear()
        LabelLNUmber.Text = vbNullString
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT SubjectName FROM tblSubject , tblSUbgrade WHERE tblSubject.SubjectID = tblSUbgrade.SubjectID AND tblSUbgrade.GradeID ='" & Integer.Parse(GradeComboBox.SelectedItem.ToString) & "' AND tblSUbgrade.isOffered =1 ")
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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NamesRTB.TextChanged

    End Sub

    Private Sub SubjectsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectsListBox.SelectedIndexChanged
        If SQL.HasConnnection = True Then
            NamesRTB.Clear()
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LName ,tblLearner.LSUrname FRom tblLearner, tblenrolment , tblSubgrade , tblSUbject WHERE tblLearner.LearnerID = tblEnrolment.LearnerID AND tblSubgrade.SUbjectid = tblEnrolment.subjectid and tblSubgrade.gradeid = tblEnrolment.gradeid and  tblSUBGRADE.GRadeID = '" & GradeComboBox.SelectedItem & "' and tblsubgrade.SubjectID = tblSUbject.SubjectID and tblSUbject.Subjectname ='" & SubjectsListBox.SelectedItem.ToString & "' ANd TblEnrolment.AcademicYear = 2019")
            Dim y As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    NamesRTB.AppendText(SQL.SQLDataSet.Tables(0).Rows(y).Item("LName") + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LsurName") + Environment.NewLine)
                    y = y + 1
                Next x

            End If
            LabelLNUmber.Text = "Number of Learners Taking Subject : " + y.ToString


        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class