Public Class HighestArchievers
    Public SQL As New DataBaseControl
    Private Sub HighestArchievers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            CBSubject.Items.Clear()
            SQL.RunQuery("SELECT SubjectName FROM tblSubject WHERE isOffered = 1 ")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    CBSubject.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID"))
                    y = y + 1
                Next
            End If

            CBGrade.Items.Clear()
            SQL.RunQuery("SELECT GradeID FROM tbGrade WHERE isOffered = 1 ")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    CBGrade.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next
            End If
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblHighArchievers'")
            If SQL.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                SQL.RunQuery("DROP TABLE tblHighArchievers")

            End If
            SQL.RunQuery("Create TABLE tblHighArchievers(SubjectID varchar(50),GradeID int ,LearnerID int ,LMark ,Total)")
        Else
            MessageBox.Show("Database not connected ,Please contact Administrator", "No Database connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CBSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSubject.SelectedIndexChanged

        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If


        Else
            MessageBox.Show("Database not connected ,Please contact Administrator", "No Database connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub rbSubject_CheckedChanged(sender As Object, e As EventArgs) Handles rbSubject.CheckedChanged

    End Sub
End Class