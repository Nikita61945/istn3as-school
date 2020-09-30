Public Class TutorRegister
    Public SQl As New DataBaseControl
    Private isHourly As Boolean = False
    Dim tutorID As Integer
    Dim isEdit As Boolean
    Public Sub PopComboBox()

        If SQl.HasConnnection = True Then

            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT  TutorID,  convert(varChar(6),TutorID)+' '+FName +' '+Surname AS 'Identify' FROM tblTutor")

            Dim y As Integer = 0
            If SQl.SQLDataSet.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In SQl.SQLDataSet.Tables(0).Rows
                    TutorComboBox.Items.Add(SQl.SQLDataSet.Tables(0).Rows(y).Item("Identify"))
                    ComboBoxTutor.Items.Add(SQl.SQLDataSet.Tables(0).Rows(y).Item("Identify"))
                    y = y + 1
                Next
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Public Sub GetTutors()


        Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQl.SQLDataAdap.SelectCommand = SQl.SQLComd
            SQl.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQl.SQLDataAdap.Update(dbTable)
            dgvTutor.DataSource = dbTable
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





    End Sub
    Private Sub TutorRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        startTime.Value = DateOfWork.Value
        endTime.Value = DateOfWork.Value
        Cursor.Current = Cursors.WaitCursor
        If SQl.HasConnnection() = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT tblRegister.WorkingDate, TblTutor.TutorID,TblTutor.FName + ' ' + TblTutor.Surname As 'Full Name', tblRegister.HoursWorked FROM tblTutor, tblRegister WHERE TblTutor.TutorID =TblRegister.TutorID")
            GetTutors()
            PopComboBox()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DateOfWork.MinDate = Date.Parse(Today.Year.ToString + "/01/01")
        Cursor.Current = Cursors.Arrow
        AddButton.Enabled = False
        endTime.Enabled = False
        startTime.Enabled = False
        ComboBoxTutor.Enabled = False
        DateOfWork.Enabled = False
        DateOfWork.MaxDate = Today
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer = Integer.Parse(TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" ")))
        btnSearch.Enabled = False
        Cursor.Current = Cursors.WaitCursor
        If SQl.HasConnnection = True Then

            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT tblRegister.WorkingDate, TblTutor.TutorID,TblTutor.FName + ' ' + TblTutor.Surname As 'Full Name', tblRegister.HoursWorked FROM tblTutor, tblRegister WHERE TblTutor.TutorID =TblRegister.TutorID and TblRegister.TutorID ='" & id & "'")
            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                MessageBox.Show("Tutor : " + TutorComboBox.SelectedItem.ToString + " has no days recorded", "No Record for tutor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            GetTutors()

        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        If SQl.HasConnnection = True Then

            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT tblRegister.WorkingDate, TblTutor.TutorID,TblTutor.FName + ' ' + TblTutor.Surname As 'Full Name', tblRegister.HoursWorked FROM tblTutor, tblRegister WHERE TblTutor.TutorID =TblRegister.TutorID ")
            GetTutors()
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub ComboBoxTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTutor.SelectedIndexChanged
        AddButton.Enabled = True
        endTime.Enabled = False
        startTime.Enabled = False
        dgvTutor.Enabled = False

        If SQl.HasConnnection = True Then
            tutorID = Integer.Parse(ComboBoxTutor.SelectedItem.ToString.Substring(0, ComboBoxTutor.SelectedItem.ToString.IndexOf(" ")))
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("SElect PaymentStyle from tblTutor WHere TutorID = '" & tutorID & "'")
            If SQl.SQLDataSet.Tables(0).Rows(0).Item("PaymentStyle") = "Hourly" Then
                endTime.Enabled = True
                startTime.Enabled = True
                isHourly = True
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim isError As Boolean = False
        If SQl.HasConnnection = True Then
            Dim tutorID = (ComboBoxTutor.SelectedItem.ToString.Substring(0, ComboBoxTutor.SelectedItem.ToString.IndexOf(" ")))
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("Select * From tblRegister Where tutorId = '" & tutorID & "' And WorkingDate ='" & DateOfWork.Value.ToShortDateString & "'")
            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                If isHourly Then

                    If endTime.Value.ToLocalTime > startTime.Value.ToLocalTime Then

                        Dim noofHours = FormatNumber((endTime.Value.Hour - startTime.Value.Hour) + ((endTime.Value.Minute - startTime.Value.Minute) / 60), 2)

                        SQl.RunQuery("Insert into tblRegister(TutorID,WorkingDate,HoursWorked) Values('" & tutorID & "','" & DateOfWork.Value.ToShortDateString & "' ," & Decimal.Parse(noofHours.ToString) & ")")
                    Else
                        MessageBox.Show("End Time cannot be before start", "Error: Times", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        endTime.Focus()
                        isError = True

                    End If

                Else
                    SQl.RunQuery("Insert into tblRegister(TutorID,WorkingDate) Values('" & tutorID & "','" & DateOfWork.Value & "')")
                End If
                If isError = False Then
                    If SQl.SQLDataSet IsNot Nothing Then
                        SQl.SQLDataSet.Clear()
                    End If
                    SQl.RunQuery("SELECT tblRegister.WorkingDate, TblTutor.TutorID,TblTutor.FName + ' ' + TblTutor.Surname As 'Full Name', tblRegister.HoursWorked FROM tblTutor, tblRegister WHERE TblTutor.TutorID =TblRegister.TutorID")
                    GetTutors()
                    AddButton.Enabled = False
                    Button2.Enabled = False
                    Button1.Enabled = True
                    EditButton.Enabled = True
                    DeleteButton.Enabled = True
                    btnSearch.Enabled = True
                    DisplayAllButton.Enabled = True
                    ComboBoxTutor.Enabled = False
                    dgvTutor.Enabled = True
                    startTime.Enabled = False
                    endTime.Enabled = False
                    DateOfWork.Enabled = False
                End If

            Else
                MessageBox.Show("Tutor's Details have already been captured for selected date", "Tutor Details already Captured ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If dgvTutor.CurrentRow IsNot Nothing Then
            isEdit = False
            ComboBoxTutor.Enabled = True
            DateOfWork.Enabled = True
            TutorComboBox.Enabled = False
            btnSearch.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            ButtonBack.Enabled = False
            AddButton.Enabled = True
            Button1.Enabled = False
            Dim RowSelected = dgvTutor.CurrentRow.Index()
            ComboBoxTutor.SelectedItem = dgvTutor.Item(1, RowSelected).Value().ToString + " " + dgvTutor.Item(2, RowSelected).Value().ToString

            DateOfWork.Value = dgvTutor.Item(0, RowSelected).Value
            SQl.SQLDataSet.Clear()
            SQl.RunQuery("DELETE FROm tblRegister WHERE TutorID = '" & dgvTutor.Item(1, RowSelected).Value() & "' AND WorkingDate = '" & dgvTutor.Item(0, RowSelected).Value & "'")

        Else
            MessageBox.Show("No Record Selected : Please Select a record", "Error : Record not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub dgvTutor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellClick
        EditButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonBack.Enabled = False
        DateOfWork.Enabled = True
        ComboBoxTutor.Enabled = True
        TutorComboBox.Enabled = False
        btnSearch.Enabled = False
        EditButton.Enabled = False
        DeleteButton.Enabled = False
        AddButton.Enabled = True
        Button1.Enabled = False


    End Sub

    Private Sub TutorComboBox_Click(sender As Object, e As EventArgs) Handles TutorComboBox.Click
        Cursor.Current = Cursors.WaitCursor
        btnSearch.Enabled = True

        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim RowSelected = dgvTutor.CurrentRow.Index()
        If MessageBox.Show("Are you sure you want to delete working record for : " + dgvTutor.Item(1, RowSelected).Value().ToString + " " + dgvTutor.Item(2, RowSelected).Value().ToString + " on Date : " + dgvTutor.Item(0, RowSelected).Value().ToString, "Confirmation of Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            SQl.SQLDataSet.Clear()
            SQl.RunQuery("DELETE FROm tblRegister WHERE TutorID = '" & dgvTutor.Item(1, RowSelected).Value() & "' AND WorkingDate = '" & dgvTutor.Item(0, RowSelected).Value & "'")
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT tblRegister.WorkingDate, TblTutor.TutorID,TblTutor.FName + ' ' + TblTutor.Surname As 'Full Name', tblRegister.HoursWorked FROM tblTutor, tblRegister WHERE TblTutor.TutorID =TblRegister.TutorID")
            GetTutors()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Canceling will result in loss of data. Do you still wish to cancel? ", "Canceling of Data Caputure ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            AddButton.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            btnSearch.Enabled = True
            DisplayAllButton.Enabled = True
            ComboBoxTutor.Enabled = False
            dgvTutor.Enabled = True
            TutorComboBox.Enabled = True
            startTime.Enabled = False
            endTime.Enabled = False
            DateOfWork.Enabled = False
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click

        Me.Close()
            Form1.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class