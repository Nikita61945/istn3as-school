Public Class OutstandingMarksForm
    Public SQL As New DataBaseControl
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub OutstandingMarksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            getOutstandingMarks()
        End If
        Me.MdiParent = Form1
    End Sub

    Public Sub getOutstandingMarks()

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT SubjectID,GradeID,TaskNo,Topic,Status FROM tblPOA WHERE Status = 'o' OR Status = 'c'")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvOutstanding.DataSource = dbTable

            dgvOutstanding.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub radTerm_CheckedChanged(sender As Object, e As EventArgs) Handles radTerm.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT GradeID,SubjectID,TaskNo,Topic,Status FROM tblPOA WHERE Status = 'O' OR Status = 'C' ORDER BY Term")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvOutstanding.DataSource = dbTable

            For x As Integer = 0 To 4
                dgvOutstanding.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub radTask_CheckedChanged(sender As Object, e As EventArgs) Handles radTask.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT GRadeID,SubjectID,TaskNo,Topic,Status FROM tblPOA WHERE Status = 'O' OR Status = 'C' ORDER BY TaskNo")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvOutstanding.DataSource = dbTable

            For x As Integer = 0 To 4
                dgvOutstanding.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub radSG_CheckedChanged(sender As Object, e As EventArgs) Handles radSG.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT GradeID,SubjectID,TaskNo,Topic,Status FROM tblPOA WHERE Status = 'O' OR Status = 'C' ORDER BY GradeID")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvOutstanding.DataSource = dbTable

            For x As Integer = 0 To 4
                dgvOutstanding.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class