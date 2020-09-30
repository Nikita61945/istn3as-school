Public Class ManageUsersForm
    Public SQL As New DataBaseControl

    Private Sub ManageUsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        ButtonRemove.Enabled = False
        If SQL.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT UserID, Username , UserCategory From tblUser WhERE Active = 1 ")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                popGrid()
            Else
                MessageBox.Show("No Active Users", "No Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Database not avilable, Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub popGrid()

        Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvUser.DataSource = dbTable
            dgvUser.Columns(0).Visible = False
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Me.Hide()
        AddUser.Show()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        ButtonRemove.Enabled = True
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If SQL.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If dgvUser.CurrentRow.Index > -1 Then
                Dim RowSelected = dgvUser.CurrentRow.Index()
                Dim nme As String = dgvUser.Item(1, RowSelected).Value()
                Cursor.Current = Cursors.Arrow
                If MessageBox.Show("Do you want remove User :  " + nme + " ?", "Removing Learner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQL.RunQuery("Update tblUser Set active = 0 Where UserID = '" & dgvUser.Item(0, RowSelected).Value() & "'")
                    popGrid()
                End If
            End If
        Else
            MessageBox.Show("Database not avilable , Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ManageUsersForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        SQL.RunQuery("SELECT UserID, Username , UserCategory From tblUser WhERE Active = 1 ")
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            popGrid()
        Else
            MessageBox.Show("No Active Users", "No Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick
        ButtonRemove.Enabled = True

    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        ButtonRemove.Enabled = True
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUser.SelectedIndexChanged
        If ComboBoxUser.SelectedIndex > -1 Then

            If SQL.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
                SQL.RunQuery("SELECT UserID, Username , UserCategory From tblUser WhERE Active = 1  AND USERCATEGORY ='" & ComboBoxUser.SelectedItem.ToString & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    popGrid()
                Else
                    MessageBox.Show("No Active Users", "No Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            MessageBox.Show("Database not avilable , Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        End If
    End Sub
End Class