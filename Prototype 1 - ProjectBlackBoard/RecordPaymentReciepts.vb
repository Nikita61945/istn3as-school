Public Class RecordPaymentReciepts
    Private Month As Integer
    Public SQL As New DataBaseControl
    Dim Source As String = vbNullString
    Dim ref As Integer = vbNull
    Public isEdit = False
    Private AID As Integer

    Private Sub RecordPaymentReciepts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        MonthTextBox.Text = System.DateTime.Today.Month.ToString
        MonthTextBox.Enabled = True
        CaptureButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = False
        CancelButton.Enabled = False
        daySel.Enabled = False
        LearnerComboBox.Enabled = False
        SubAccountComboBox.Enabled = False
        transnoteTextBox.Enabled = False
        RefNoTextBox.Enabled = False
        AmountTextBox.Enabled = False
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            SQL.RunQuery("SELECT LearnerID, convert(varChar(6),LearnerID) +' '+LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE LAccount = 1 and LStatus =1 and LearnerID in (SELECT Distinct(LearnerID) FROM tblAccount )")
            Dim y As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    LearnerComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                    y = y + 1
                Next
            End If
            Cursor.Current = Cursors.Arrow

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub GetData()
        SQL.RunQuery("SELECT Distinct(tblAccount.learnerId), tblAccount.TransDay,tblAccount.RefNo ,tblLearner.LName +' '+ tblLearner.LSurname As 'Learner Full Name' ,tblAccount.AType, tblAccount.TransNote,tblAccount.Amount,tblAccount.AccountID From tblLearner ,tblAccount Where tblAccount.LearnerID = tblLearner.LearnerID AND tblAccount.TransMonth ='" & Month & "' And tblAccount.transtype = 4 And tblAccount.SourceDoc ='" & Source & "' Order By tblAccount.TransDay")
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAdap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAdap.Update(dbTable)
        dgvPay.DataSource = dbTable
        dgvPay.Columns(0).Visible = False
        dgvPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPay.Columns(7).Visible = False
        dgvPay.Columns(4).HeaderCell.Value = "Sub Account"
    End Sub
    Private Sub MonthTextBox_Leave(sender As Object, e As EventArgs) Handles MonthTextBox.Leave
        CaptureButton.Enabled = True

        Month = Integer.Parse(MonthTextBox.Text)
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If BankRadioButton.Checked = True Or RecieptRadioButton.Checked = True Then
                If BankRadioButton.Checked = True Then
                    Source = "B"
                End If

                If RecieptRadioButton.Checked = True Then
                    Source = "R"
                End If

                GetData()

                If (Month.Equals(1) = True) Or (Month.Equals(3) = True) Or (Month.Equals(5) = True) Or (Month.Equals(7) = True) Or (Month.Equals(1) = True) Or (Month.Equals(8) = True) Or (Month.Equals(10) = True) Or (Month.Equals(12) = True) Then
                    daySel.Maximum = 31
                ElseIf (Month.Equals(4) = True) Or (Month.Equals(6) = True) Or (Month.Equals(11) = True) Or (Month.Equals(9) = True) Then
                    daySel.Maximum = 30
                Else
                    If DateTime.IsLeapYear(Today.Year) Then
                        daySel.Maximum = 29
                    Else
                        daySel.Maximum = 28
                    End If
                End If
            Else
                MessageBox.Show("Source Type not Selected, Please Select Source", "Error: Source not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CaptureButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        EditButton.Enabled = False
        CaptureButton.Enabled = False
        BackButton.Enabled = False
        SaveButton.Enabled = True
        CancelButton.Enabled = True
        daySel.Enabled = True
        LearnerComboBox.Enabled = True
        SubAccountComboBox.Enabled = True
        transnoteTextBox.Enabled = True
        RefNoTextBox.Enabled = True
        AmountTextBox.Enabled = True


    End Sub

    Private Sub dgvPay_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPay.SelectionChanged
        EditButton.Enabled = True
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If dgvPay.CurrentRow IsNot Nothing Then
            Cursor.Current = Cursors.WaitCursor
            isEdit = True
            dgvPay.Enabled = False
            EditButton.Enabled = False
            CaptureButton.Enabled = False
            BackButton.Enabled = False
            SaveButton.Enabled = True
            CancelButton.Enabled = True
            daySel.Enabled = True
            LearnerComboBox.Enabled = True
            SubAccountComboBox.Enabled = True
            transnoteTextBox.Enabled = True
            RefNoTextBox.Enabled = True
            AmountTextBox.Enabled = True
            Dim RowSelected = dgvPay.CurrentRow.Index()
            daySel.Value = dgvPay.Item(1, RowSelected).Value()
            RefNoTextBox.Text = dgvPay.Item(2, RowSelected).Value()
            LearnerComboBox.SelectedItem = dgvPay.Item(0, RowSelected).Value().ToString + " " + dgvPay.Item(3, RowSelected).Value().ToString
            GetData()
            SubAccountComboBox.SelectedItem = dgvPay.Item(4, RowSelected).Value().ToString
            GetData()
            transnoteTextBox.Text = dgvPay.Item(5, RowSelected).Value().ToString
            AmountTextBox.Text = dgvPay.Item(6, RowSelected).Value().ToString
            AID = dgvPay.Item(7, RowSelected).Value()
            LearnerComboBox_SelectedIndexChanged(EditButton, e)
            SubAccountComboBox_SelectedIndexChanged(EditButton, e)
            Cursor.Current = Cursors.Arrow
        Else
            MessageBox.Show("No Record Selected : Please Select a record", "Error : Record not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim msg As String = vbNullString
        Dim id As Integer
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            If LearnerComboBox.SelectedIndex = -1 Then
                msg = msg + Environment.NewLine + " Learner Not Selected : Please Select Learner "
            End If
            If SubAccountComboBox.SelectedIndex = -1 Then
                msg = msg + Environment.NewLine + " Sub Account Not Selected  Please select a Sub Account"
            End If
            If transnoteTextBox.Text Is Nothing Then
                msg = msg + Environment.NewLine + " Transaction Note cannnot be Empty  Please Enter a Transaction  Note "
            End If
            If IsNumeric(AmountTextBox.Text) = False Then
                msg = msg + Environment.NewLine + " Ammout must be Digits : Please Enter Digits"
                AmountTextBox.Clear()
            End If
            If msg Is vbNullString Then
                ref = Integer.Parse(RefNoTextBox.Text)

                If isEdit = False Then
                    SQL.RunQuery("Select MAX(AccountID) AS HighestID FROM tblAccount")
                    If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                        id = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                    End If
                    SQL.SQLDataSet.Clear()


                    SQL.RunQuery("INSERT INTO tblAccount(AccountID,LearnerID,AType,TransDay,TransMonth,TransYear,Amount,TransNote,TransType,refNo, sourceDoc) VALUES('" & id & "','" & Integer.Parse(LearnerComboBox.SelectedItem.ToString.Substring(0, LearnerComboBox.SelectedItem.ToString.IndexOf(" "))) & "','" & SubAccountComboBox.SelectedItem & "','" & daySel.Value & "','" & Month & "','" & System.DateTime.Today.Year & "','" & Decimal.Parse(AmountTextBox.Text.ToString) * -1 & "','" & transnoteTextBox.Text & "', 4 ,'" & ref & "','" & Source & "')")
                    msg = "Record Added" + Environment.NewLine
                Else
                    SQL.RunQuery("Update tblAccount Set LearnerID = '" & Integer.Parse(LearnerComboBox.SelectedItem.ToString.Substring(0, LearnerComboBox.SelectedItem.ToString.IndexOf(" "))) & "', Atype = '" & SubAccountComboBox.SelectedItem & "', TransDay = '" & daySel.Value & "', Amount = '" & Decimal.Parse(AmountTextBox.Text.ToString) * -1 & "', TransNote = '" & transnoteTextBox.Text & "', refNo = '" & ref & "' WHERE AccountID = '" & AID & "'")
                    msg = "Record Updated" + Environment.NewLine
                End If
                Cursor.Current = Cursors.Arrow
                If MessageBox.Show(msg + "Do you want to enter another record", "Add Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    daySel.Value = 1
                    LearnerComboBox.SelectedIndex = -1
                    SubAccountComboBox.SelectedIndex = -1
                    transnoteTextBox.Text = "Payment Recieved"
                    RefNoTextBox.Clear()
                    AmountTextBox.Clear()
                Else
                    GetData()
                    SaveButton.Enabled = False
                    CancelButton.Enabled = False
                    daySel.Enabled = True
                    BackButton.Enabled = True
                    LearnerComboBox.Enabled = False
                    SubAccountComboBox.Enabled = False
                    transnoteTextBox.Enabled = False
                    RefNoTextBox.Enabled = False
                    AmountTextBox.Enabled = False
                    LearnerComboBox.SelectedIndex = -1
                    SubAccountComboBox.SelectedIndex = -1
                    AmountTextBox.Clear()
                    RefNoTextBox.Clear()
                    daySel.Value = 1
                    daySel.Enabled = False
                    dgvPay.Enabled = True
                    GetData()
                    CaptureButton.Enabled = True
                End If


            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show(msg, "Error(s) in Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        If MessageBox.Show("Canceling will result in loss of data. Do you still wish to cancel? ", "Canceling of Data Caputure ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            SaveButton.Enabled = False
            CancelButton.Enabled = False
            daySel.Enabled = True
            BackButton.Enabled = True
            LearnerComboBox.Enabled = False
            SubAccountComboBox.Enabled = False
            transnoteTextBox.Enabled = False
            RefNoTextBox.Enabled = False
            AmountTextBox.Enabled = False
            LearnerComboBox.SelectedIndex = -1
            SubAccountComboBox.SelectedIndex = -1
            AmountTextBox.Clear()
            RefNoTextBox.Clear()
            daySel.Value = 1
            dgvPay.Enabled = True
            CaptureButton.Enabled = True
            MonthTextBox_Leave(CancelButton, e)
        End If

    End Sub



    Private Sub LearnerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LearnerComboBox.SelectedIndexChanged
        If LearnerComboBox.SelectedIndex > -1 Then

            If SQL.HasConnnection() = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT AType,Sum(Amount) As 'Total per Sub Account' from tblAccount Where LearnerID ='" & LearnerComboBox.SelectedItem.ToString.Substring(0, LearnerComboBox.SelectedItem.ToString.IndexOf(" ")) & "' Group By Atype ")
                PopGrid()
                EditButton.Enabled = False
            Else

                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Public Sub PopGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAdap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAdap.Update(dbTable)
        dgvPay.DataSource = dbTable
        If dgvPay.ColumnCount = 2 Then
            dgvPay.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvPay.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvPay.Columns(0).HeaderCell.Value = "Sub Accounts"
        Else
            dgvPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPay.Columns(2).HeaderCell.Value = "Transaction Note"
        End If



    End Sub

    Private Sub SubAccountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubAccountComboBox.SelectedIndexChanged
        If SubAccountComboBox.SelectedIndex > -1 Then
            If SQL.HasConnnection() = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT TransDay,TransMonth,TransNote, Amount from tblAccount Where LearnerID ='" & LearnerComboBox.SelectedItem.ToString.Substring(0, LearnerComboBox.SelectedItem.ToString.IndexOf(" ")) & "' And Atype = '" & SubAccountComboBox.SelectedItem.ToString & "' Order BY transMonth,transDay")
                PopGrid()
                EditButton.Enabled = False
            Else

                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BankRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BankRadioButton.CheckedChanged
        MonthTextBox_Leave(BankRadioButton, e)

    End Sub

    Private Sub RecieptRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RecieptRadioButton.CheckedChanged
        MonthTextBox_Leave(RecieptRadioButton, e)
    End Sub
End Class