Public Class SetupRooms
    Public SQL As New DataBaseControl
    Public isEDIT As Boolean = False
    Private Sub SetupRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRooms()
        Me.MdiParent = Form1
        Cursor.Current = Cursors.Arrow
        Button3.Enabled = True
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
        ButtonEdit.Enabled = False
        TextBoxName.Enabled = False
        CapacityNUD.Enabled = False
        ButtonCan.Enabled = False
    End Sub
    Public Sub GetRooms()
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT RoomName ,Capacity FROM Rooms")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            Dim ds As New DataSet
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)
            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvRooms.DataSource = dbTable
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ButtonSave.Enabled = True
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCan.Enabled = True
        Button1.Enabled = False
        Button3.Enabled = False
        CapacityNUD.Enabled = True
        TextBoxName.Enabled = True
        isEDIT = False
    End Sub

    Private Sub dgvRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRooms.CellClick
        ButtonDelete.Enabled = True
        ButtonEdit.Enabled = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If dgvRooms.CurrentRow.Index > -1 Then
            Dim ROwSelected = dgvRooms.CurrentRow.Index
            TextBoxName.Text = dgvRooms.Item(0, ROwSelected).Value.ToString
            CapacityNUD.Value = dgvRooms.Item(1, ROwSelected).Value
            CapacityNUD.Enabled = True
            TextBoxName.Enabled = False
            isEDIT = True
            ButtonSave.Enabled = True
            ButtonEdit.Enabled = False
            ButtonDelete.Enabled = False
            ButtonCan.Enabled = True
            Button1.Enabled = False
            Button3.Enabled = False
        Else
            MessageBox.Show("Please select a room to edit first", "Select a Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim mesg As String = ""
            If TextBoxName.Text Is Nothing Then
                mesg = mesg + "Fill in Room Name" + Environment.NewLine
            End If

            If CapacityNUD.Value = 0 Then
                mesg = mesg + "Room capacity cannot be zero" + Environment.NewLine
            End If
            If mesg = "" Then
                If isEDIT = False Then
                    SQL.RunQuery("SELECT * FROM ROOMS WHERE RoomNAme ='" & TextBoxName.Text & "'")
                    If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then

                        SQL.RunQuery("INSERT INTO Rooms(RoomName,Capacity) VALUES('" & TextBoxName.Text & "','" & CapacityNUD.Value & "')")
                        MessageBox.Show("New Room Successfully Added", "New Room", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Room is Exists Already", "Room Exists", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else

                    SQL.RunQuery("UPDATE Rooms SET Capacity = '" & CapacityNUD.Value & "' WHERE RoomNAme = '" & TextBoxName.Text.ToString & "'")
                    MessageBox.Show("Room Successfully Updated", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                TextBoxName.Clear()
                Button1.Enabled = True
                ButtonSave.Enabled = False
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                Button3.Enabled = True
                ButtonCan.Enabled = False
                CapacityNUD.Value = 0
                TextBoxName.Enabled = False
                CapacityNUD.Enabled = False
            Else
                MessageBox.Show(mesg, "Error(s) in Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
        GetRooms()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If dgvRooms.CurrentRow.Index > -1 Then
            Dim ROwSelected = dgvRooms.CurrentRow.Index
            If MessageBox.Show("Areyou sure you want to delete Room: " + dgvRooms.Item(0, ROwSelected).Value.ToString, "Confirmation of room deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                SQL.RunQuery("DELETE from Rooms WHERE RoomName = '" & dgvRooms.Item(0, ROwSelected).Value.ToString & "'")
            End If
            GetRooms()
        Else
            MessageBox.Show("Please select a Room to delete first", "Select a Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonCan_Click(sender As Object, e As EventArgs) Handles ButtonCan.Click
        If MessageBox.Show("Areyou sure you want to Cancel ,data will not be saved", "Confirmation of Room capture cancelation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            TextBoxName.Clear()
            Button1.Enabled = True
            ButtonSave.Enabled = False
            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = True
            ButtonCan.Enabled = False
            Button3.Enabled = True
            CapacityNUD.Value = 0
            TextBoxName.Enabled = False
            CapacityNUD.Enabled = False
            GetRooms()

        End If
    End Sub
End Class