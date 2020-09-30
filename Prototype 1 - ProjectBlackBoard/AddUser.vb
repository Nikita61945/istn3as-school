Public Class AddUser
    Public SQL As New DataBaseControl
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManageUsersForm.Hide()
        Panel1.Hide()
        Panel2.Hide()

    End Sub

    Private Sub CategoryCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryCB.SelectedIndexChanged
        Panel1.Hide()
        Panel2.Hide()
        Cursor.Current = Cursors.WaitCursor
        If CategoryCB.SelectedIndex > -1 Then
            If CategoryCB.SelectedIndex = 0 Then
                Panel2.Show()
            End If
            If CategoryCB.SelectedIndex = 1 Then
                Panel1.Show()
                popListBox()
            End If
            Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Public Sub PopListBox()
        If SQL.HasConnnection = True Then
            ListBox1.Items.Clear()
            Cursor.Current = Cursors.WaitCursor
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblTutor.FName +' '+tblTutor.Surname AS 'Identify' FROM tblTutor")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                    ListBox1.Items.Add(SQL.SQLDataSet.Tables(0).Rows(x).Item("Identify"))
                Next x
            End If
            Cursor.Current = Cursors.Arrow
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Sql.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select MAX(userID) AS HighestID FROM tblUser")
            Dim ID As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
            Else
                ID = 1
            End If

            If CategoryCB.SelectedIndex = 0 Then
                If TextBoxAdin.Text IsNot Nothing Then
                    SQL.RunQuery("Insert into tblUser Values('" & TextBoxAdin.Text & "','" & TextBoxAdin.Text & "','" & CategoryCB.SelectedItem.ToString & "','" & ID & "',1)")
                End If
            End If
            If CategoryCB.SelectedIndex = 1 Then

                For x = 0 To ListBox1.Items.Count - 1
                    If ListBox1.GetSelected(x) Then
                        Dim Username = (ListBox1.Items(x).ToString)
                        SQL.RunQuery("SELECT * From tblUser Where USerName = '" & Username & "'")
                        If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                            SQL.SQLDataSet.Clear()
                            SQL.RunQuery("Insert into tblUser Values('" & Username & "','" & Username & "','" & CategoryCB.SelectedItem.ToString & "','" & ID & "',1)")
                            SQL.SQLDataSet.Clear()
                        Else
                            MessageBox.Show("Username already exists Username will be : " & Username + ID.ToString, "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            SQL.SQLDataSet.Clear()
                            SQL.RunQuery("Insert into tblUser Values('" & Username + ID.ToString & "','" & Username + ID.ToString & "','" & CategoryCB.SelectedItem.ToString & "','" & ID & "',1)")
                            SQL.SQLDataSet.Clear()
                        End If

                    End If
                Next x
            End If
            Cursor.Current = Cursors.Arrow
            If MessageBox.Show("User(s) added Do you want to add more Users", "Adding User", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                CategoryCB.SelectedIndex = -1
            Else
                Me.Close()
                ManageUsersForm.Show()
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to cancel , no data will be saved", "Manage Users", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Me.Close()
            ManageUsersForm.Show()
        End If
    End Sub
End Class