Imports System.Globalization

Public Class TutorTimes
    Public SQL As New DataBaseControl
    Public isSpec As Boolean = False
    Public tutorID
    Public isEdit As Boolean = False
    Private Sub TutorTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT  TutorID,  convert(varChar(6),TutorID)+' '+FName +' '+Surname AS 'Identify' FROM tblTutor")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    TutorComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Identify"))

                    y = y + 1
                Next x
            End If
            reset()
            ButtonEdit.Enabled = False
            ButtonRemove.Enabled = False

        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Public Sub UpdateGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select Day,StartTime,EndTime,AllDay FROm TutorTimes WHere tutorID= '" & tutorID & "' ORDER BY DAy ")

            If (SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False) And (DaysComboBox.Items.Count > 0) Then

                For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                    Dim z = DaysComboBox.Items.Count
                    Dim i = 0

                    While Not (i = z)
                        If SQL.SQLDataSet.Tables(0).Rows(x).Item("Day").ToString = DaysComboBox.Items(i).ToString Then
                            DaysComboBox.Items.RemoveAt(i)
                            i = i - 1
                            z = z - 1
                        End If
                        i = i + 1
                    End While
                Next x
            End If

            If DaysComboBox.Items.Count = 0 Then
                MessageBox.Show("Tutor assigned times for everday of the week , Select one to Edit", "Tutor Times", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtonSave.Enabled = False
                Button2.Enabled = False
                ButtonAdd.Enabled = False
                startTime.Enabled = False
                endTime.Enabled = False
                DaysComboBox.Enabled = False
                ComboBoxTimes.Enabled = False
            End If
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            DataGridView1.DataSource = dbTable
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        isEdit = False

        If TutorComboBox.SelectedIndex > -1 Then
            tutorID = (TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" ")))
            TutorComboBox.Enabled = False
            DaysComboBox.Enabled = True
            ComboBoxTimes.Enabled = True
            Button2.Enabled = True
            ButtonAdd.Enabled = False
            ButtonSave.Enabled = True
            UpdateGrid()
        Else
            MessageBox.Show("Select a tutor first", "No Tutor selected", MessageBoxButtons.OK, MessageBoxIcon.Warning
                            )
        End If
    End Sub

    Private Sub ComboBoxTimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTimes.SelectedIndexChanged
        If ComboBoxTimes.SelectedItem = "Specific Times" Then
            Label4.Enabled = True
            Label5.Enabled = True
            startTime.Enabled = True
            endTime.Enabled = True
            isSpec = True
        End If
    End Sub
    Public Sub reset()
        Label4.Enabled = False
        Label5.Enabled = False

        startTime.Enabled = False
        endTime.Enabled = False
        DaysComboBox.Enabled = False
        ComboBoxTimes.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = True
        TutorComboBox.Enabled = True
        ButtonEdit.Enabled = False
        ButtonRemove.Enabled = False
        ButtonAdd.Enabled = False
        ButtonSave.Enabled = False
        startTime.MinDate = Today
        endTime.MinDate = Today
        ComboBoxTimes.SelectedIndex = -1
        TutorComboBox.SelectedIndex = -1
        DaysComboBox.SelectedIndex = -1
        DaysComboBox.Items.Clear()
        DaysComboBox.Items.Add("Monday")
        DaysComboBox.Items.Add("Tuesday")
        DaysComboBox.Items.Add("Wednesday")
        DaysComboBox.Items.Add("Thursday")
        DaysComboBox.Items.Add("Friday")
        DaysComboBox.Items.Add("Saturday")
        isSpec = False
    End Sub
    Private Sub TutorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorComboBox.SelectedIndexChanged
        ButtonAdd.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ButtonEdit.Enabled = True
        ButtonRemove.Enabled = True
        Dim RowSelected As Integer
        Dim provider As New CultureInfo(CultureTypes.AllCultures)
        If DataGridView1.CurrentRow.Index > -1 Then
            RowSelected = DataGridView1.CurrentRow.Index()
            DaysComboBox.Items.Add(DataGridView1.Item(0, RowSelected).Value.ToString)
            DaysComboBox.SelectedItem = DataGridView1.Item(0, RowSelected).Value.ToString
            If DataGridView1.Item(2, RowSelected).Value.ToString.Length > 0 Then
                ComboBoxTimes.SelectedItem = "Specific Times"

                startTime.Value = DateTime.ParseExact(FormatDateTime(DataGridView1.Item(1, RowSelected).Value.ToString, DateFormat.ShortTime), "HH:mm", provider)
                endTime.Value = DateTime.ParseExact(FormatDateTime(DataGridView1.Item(2, RowSelected).Value.ToString, DateFormat.ShortTime), "HH:mm", provider)

            Else
                ComboBoxTimes.SelectedItem = "All Day"
            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Cancelling will result in data not being saved", "Warning :Data lost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TutorComboBox.SelectedIndex = -1
            reset()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim mesg As String = vbNullString

        If TutorComboBox.SelectedIndex > -1 Then
            If DataGridView1.CurrentRow.Index > -1 Then
                tutorID = (TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" ")))
                isEdit = True
                TutorComboBox.Enabled = False
                DaysComboBox.Enabled = False
                ComboBoxTimes.Enabled = True
                Button2.Enabled = True
                ButtonAdd.Enabled = False
                ButtonSave.Enabled = True
                ButtonEdit.Enabled = False
                ButtonRemove.Enabled = False
                Button1.Enabled = False
                If DaysComboBox.Items.Count > 0 Then
                    UpdateGrid()
                End If

            Else
                MessageBox.Show("Select a row to edit first", "No Row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Select a tutor first", "No Tutor selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim mesg As String = ""
            Dim isFine As Boolean = True
            If ComboBoxTimes.SelectedIndex = -1 Then
                mesg = mesg + "Times Not Selected , Please Select Times " + Environment.NewLine
                isFine = False
            End If

            If DaysComboBox.SelectedIndex = -1 Then
                mesg = mesg + "Day Not Selected , Please Select Day " + Environment.NewLine
                isFine = False
            End If
            If isSpec = True Then
                If endTime.Value.ToLocalTime < startTime.Value.ToLocalTime Then
                    mesg = mesg + "End Time cannot be before start " + Environment.NewLine
                    isFine = False
                End If
            End If


            If isFine Then
                If isEdit Then
                    If isSpec Then
                        SQL.RunQuery("SELECT ALLDAY FRPM tutorTimes WHERE TutorID = '" & tutorID & "Day ='" & DaysComboBox.SelectedItem.ToString & "'")
                        If SQL.SQLDataSet.Tables(0).Rows(0).Item("ALlDAY") = 1 Then
                            SQL.RunQuery("UPdate TutorTimes SET StartTime = '" & startTime.Value.ToShortTimeString & "', Endtime='" & endTime.Value.ToShortTimeString & "', AllDay = 0 WHERE TutorID = '" & tutorID & "Day ='" & DaysComboBox.SelectedItem.ToString & "'")
                        Else
                            SQL.RunQuery("UPdate TutorTimes SET StartTime = '" & startTime.Value.ToShortTimeString & "', Endtime='" & endTime.Value.ToShortTimeString & "' WHERE TutorID = '" & tutorID & "Day ='" & DaysComboBox.SelectedItem.ToString & "'")
                        End If

                    Else
                        SQL.RunQuery("SELECT ALLDAY FRPM tutorTimes WHERE TutorID = '" & tutorID & "Day ='" & DaysComboBox.SelectedItem.ToString & "'")
                        If SQL.SQLDataSet.Tables(0).Rows(0).Item("ALlDAY") = 0 Then
                            SQL.RunQuery("UPdate TutorTimes SET StartTime = NULL, Endtime= null , AllDay = 1 WHERE TutorID = '" & tutorID & "Day ='" & DaysComboBox.SelectedItem.ToString & "'")
                        End If

                    End If
                    If MessageBox.Show("Tutor Time Added for " + DaysComboBox.SelectedItem + " , Do you want to add for Times for this Tutor?", "Confrirmation of Times Added", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        DaysComboBox.Items.Remove(DaysComboBox.SelectedItem)
                        UpdateGrid()
                    Else
                        reset()
                    End If
                Else
                    If isSpec Then

                        SQL.RunQuery("Insert into TutorTimes(Day, TutorID, startTime, endTime) Values('" & DaysComboBox.SelectedItem.ToString & "','" & tutorID & "','" & startTime.Value.ToShortTimeString & "' ,'" & endTime.Value.ToShortTimeString & "')")
                    Else
                        SQL.RunQuery("Insert into TutorTimes(Day,TutorID,Allday) Values('" & DaysComboBox.SelectedItem.ToString & "','" & tutorID & "',1 )")
                    End If
                    If MessageBox.Show("Tutor Time Added for " + DaysComboBox.SelectedItem + " , Do you want to add for Times for this Tutor?", "Confrirmation of Times Added", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        DaysComboBox.Items.Remove(DaysComboBox.SelectedItem)
                        UpdateGrid()
                    Else
                        reset()
                    End If
                End If


            Else
                MessageBox.Show(mesg, "Error(s) in Tutor times", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub DaysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DaysComboBox.SelectedIndexChanged

    End Sub
End Class