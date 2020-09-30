Public Class PasswordChange
    Public sql As New DataBaseControl

    Dim UserID As Integer = Login.userID

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If IsNumeric(UserID) Then
            If sql.HasConnnection = True Then

                If sql.SQLDataSet IsNot Nothing Then
                    sql.SQLDataSet.Clear()
                End If
                sql.RunQuery("SELECT UserPassword FROM tblUSer WHERE UserID = '" & UserID & "'")
                If (sql.SQLDataSet.Tables(0).Rows(0).Item("Password").Equals(edtOldPass.Text)) Then
                    If (edtNewPass.Text = edtnewpassconfirm.Text) Then
                        sql.SQLDataSet.Clear()
                        sql.RunQuery("Update tblUSer Set UserPassword = '" & edtNewPass.Text & "'" &
                                 "WHERE  UserID = '" & UserID & "'")
                    Else
                        MsgBox("New Password do not match", MsgBoxStyle.OkOnly, "Passwords ")
                        edtNewPass.Clear()
                        edtnewpassconfirm.Clear()
                    End If
                ElseIf (sql.SQLDataSet.Tables(0).Rows(0).Item("Password").Equals(edtOldPass.Text)) = False Then
                    MsgBox("Old Password Incorrect", MsgBoxStyle.OkOnly, "Passwords ")
                    edtNewPass.Clear()
                    edtnewpassconfirm.Clear()
                    edtOldPass.Clear()
                    End

                End If
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable,Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            Form1.Show()
        Else
            MessageBox.Show("Login first", "Login required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Pasword wont be updated", "Password Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If

    End Sub



    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub
End Class