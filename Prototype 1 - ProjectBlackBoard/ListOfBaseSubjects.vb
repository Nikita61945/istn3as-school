Public Class ListOfBaseSubjects
    Public SQl As New DataBaseControl
    Dim Isedit As Boolean = False
    Private Sub ListOfBaseSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.MdiParent = Form1
        AddButton.Enabled = True
        EditButton.Enabled = False
        SubCodeTextBox.Enabled = False
        SubNameTextBox.Enabled = False
        IsOfferedCheckBox.Enabled = False
        DisplayOrderVal.Enabled = False
        popListBox()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub SubjectListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectListBox.SelectedIndexChanged
        EditButton.Enabled = True
    End Sub
    Public Sub popListBox()
        If SQl.HasConnnection = True Then

            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SubjectListBox.Items.Clear()
            SQl.RunQuery("SELECT SubjectName From tblSubject Order BY DisplayOrder ")
            If SQl.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQl.SQLDataSet.Tables(0).Rows
                    SubjectListBox.Items.Add(SQl.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        SubCodeTextBox.Enabled = True
        SubNameTextBox.Enabled = True
        IsOfferedCheckBox.Enabled = True
        DisplayOrderVal.Enabled = True
        AddButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = True

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SQl.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If

            If Isedit = False Then

                Dim id As String = SubCodeTextBox.Text
                SQl.RunQuery("SELECT * from tblSubject Where SubjectID ='" & id & "'")

                If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                    SQl.SQLDataSet.Clear()

                    SQl.RunQuery("SELECT SubjectName from tblSubject Where DisplayOrder ='" & DisplayOrderVal.Value & "'")
                    If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                        Dim name As String = SQl.SQLDataSet.Tables(0).Rows(0).Item("SubjectName")
                        SQl.SQLDataSet.Clear()
                        SQl.RunQuery("Select Max(DisplayOrder) as 'MAxOrder' from tblSubject")
                        Dim newno = SQl.SQLDataSet.Tables(0).Rows(0).Item("MAxOrder") + 1
                        SQl.SQLDataSet.Clear()
                        If MessageBox.Show(name + " is the " + DisplayOrderVal.Value.ToString + " place in the list , Do you want to replace it Other wise subject display order will be " & newno.ToString, "Display Order Number taken", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            SQl.RunQuery("Update tblSubject Set DisplayOrder = '" & newno & "' WHere SubjectName = '" & name & "'")
                            SQl.SQLDataSet.Clear()
                            SQl.RunQuery("INSERT INTO tblSUbject VAlues('" & SubNameTextBox.Text & "', 1 ,'" & id & "','" & DisplayOrderVal.Value & "')")
                        Else
                            SQl.RunQuery("INSERT INTO tblSUbject VAlues('" & SubNameTextBox.Text & "', 1 ,'" & id & "','" & newno & "')")
                        End If
                    Else
                        SQl.RunQuery("INSERT INTO tblSUbject VAlues('" & SubNameTextBox.Text & "', 1 ,'" & id & "','" & DisplayOrderVal.Value & "')")
                    End If
                    Cursor.Current = Cursors.Arrow
                    MessageBox.Show("New Subject Added", "Subject Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Cursor.Current = Cursors.Arrow
                    MessageBox.Show("Subject already exists", "Error : Subject Exists", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                SQl.SQLDataSet.Clear()

                SQl.RunQuery("SELECT SubjectName from tblSubject Where DisplayOrder ='" & DisplayOrderVal.Value & "' AND NOT(SubjectID ='" & SubCodeTextBox.Text.ToString & "')")
                If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                    Dim name As String = SQl.SQLDataSet.Tables(0).Rows(0).Item("SubjectName")
                    SQl.SQLDataSet.Clear()
                    SQl.RunQuery("Select Max(DisplayOrder) as 'MAxOrder' from tblSubject")
                    Dim newno = SQl.SQLDataSet.Tables(0).Rows(0).Item("MAxOrder") + 1
                    SQl.SQLDataSet.Clear()
                    If MessageBox.Show(name + " is the " + DisplayOrderVal.Value.ToString + " place in the list , Do you want to replace it then " + name + " display order will be moved " & newno.ToString, "Display Order Number taken", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        SQl.RunQuery("Update tblSubject Set DisplayOrder = '" & newno & "' WHere SubjectName = '" & name & "'")
                        SQl.SQLDataSet.Clear()
                        SQl.RunQuery("UPDATE tblSubject SET SubjectName='" & SubNameTextBox.Text & "',isOffered='" & IsOfferedCheckBox.Checked() & "',DisplayOrder = '" & DisplayOrderVal.Value & "'WHERE SubjectID='" & SubCodeTextBox.Text & "'")
                    Else
                        SQl.RunQuery("UPDATE tblSubject SET SubjectName='" & SubNameTextBox.Text & "',isOffered='" & IsOfferedCheckBox.Checked() & "' WHERE SubjectID='" & SubCodeTextBox.Text & "'")
                    End If

                Else
                    SQl.RunQuery("UPDATE tblSubject SET SubjectName='" & SubNameTextBox.Text & "',isOffered='" & IsOfferedCheckBox.Checked() & "',DisplayOrder = '" & DisplayOrderVal.Value & "'WHERE SubjectID='" & SubCodeTextBox.Text & "'")
                End If
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Subject is Updated", "Subject Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
            SubCodeTextBox.Clear()
            SubNameTextBox.Clear()
            IsOfferedCheckBox.ResetText()
            SaveButton.Enabled = False
            AddButton.Enabled = True
            DisplayOrderVal.Value = 0
            popListBox()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If SQl.HasConnnection Then
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            Isedit = True
            Cursor.Current = Cursors.WaitCursor
            SubCodeTextBox.Enabled = False
            SubNameTextBox.Enabled = True
            DisplayOrderVal.Enabled = True
            IsOfferedCheckBox.Enabled = True
            EditButton.Enabled = False
            AddButton.Enabled = False
            SaveButton.Enabled = True
            SQl.RunQuery("SELECT SubjectName,isOffered,SubjectID , Displayorder FROM tblSubject WHERE SubjectName='" & SubjectListBox.SelectedItem.ToString & "' ")
            If SQl.SQLDataSet.Tables(0).Rows.Count > 0 Then

                For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1
                    SubNameTextBox.Text() = SubjectListBox.SelectedItem()
                    SubCodeTextBox.Text() = SQl.SQLDataSet.Tables(0).Rows(x).Item("SubjectID")
                    DisplayOrderVal.Value = SQl.SQLDataSet.Tables(0).Rows(x).Item("DisplayOrder")
                    If SQl.SQLDataSet.Tables(0).Rows(x).Item("isOffered").Equals(True) Then
                        IsOfferedCheckBox.Checked() = True
                    Else
                        IsOfferedCheckBox.Checked() = False
                    End If
                Next x
            End If

        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class