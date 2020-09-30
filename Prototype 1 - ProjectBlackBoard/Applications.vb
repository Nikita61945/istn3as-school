Public Class Applications
    Public SQl As New DataBaseControl
    Public AppID As Integer

    Private Sub Applications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        If SQl.HasConnnection() Then
            If SQl.SQLDataSet Is Nothing = False Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("Select GradeID From TblGrade")
            For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1
                ComboBox1.Items.Add(SQl.SQLDataSet.Tables(0).Rows(x).Item("GradeID"))
            Next x

        End If
        SQl.RunQuery("SELECT * From tblApplication ")
        GetApplications()

    End Sub
    Public Sub GetApplications()

        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        Dim ds As New DataSet
        SQl.SQLDataAdap.SelectCommand = SQl.SQLComd
        SQl.SQLDataAdap.Fill(dbTable)
        bSource.DataSource = dbTable
        SQl.SQLDataAdap.Update(dbTable)
        DataGridView1.DataSource = dbTable

    End Sub

    Private Sub RBRejected_CheckedChanged(sender As Object, e As EventArgs) Handles RBRejected.CheckedChanged
        If SQl.HasConnnection() Then
            If SQl.SQLDataSet Is Nothing = False Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("SELECT * From tblApplication WHERE AppStatus = 'R'")
            GetApplications()
        End If


    End Sub

    Private Sub RBPend_CheckedChanged(sender As Object, e As EventArgs) Handles RBPend.CheckedChanged
        If SQl.HasConnnection() Then
            If SQl.SQLDataSet Is Nothing = False Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("SELECT * From tblApplication WHERE AppStatus = 'P'")
            GetApplications()
        End If
    End Sub

    Private Sub RBAccept_CheckedChanged(sender As Object, e As EventArgs) Handles RBAccept.CheckedChanged
        If SQl.HasConnnection() Then
            If SQl.SQLDataSet Is Nothing = False Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("SELECT * From tblApplication WHERE AppStatus = 'A'")
            GetApplications()
        End If
    End Sub

    Private Sub RBAccptNoE_CheckedChanged(sender As Object, e As EventArgs) Handles RBAccptNoE.CheckedChanged
        If SQl.HasConnnection() Then
            If SQl.SQLDataSet Is Nothing = False Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("SELECT * From tblApplication WHERE AppStatus = 'E'")
            GetApplications()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class