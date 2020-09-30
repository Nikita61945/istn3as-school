
Public Class Record_Fees
    Public SQL As New DataBaseControl
    Public MonthlyAmm As Decimal = 0
    Private LastMonth As Decimal
    Public Amount As Decimal = 0
    Public arrMonths As String() = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
    Public leaners As String
    Public Start As Integer = 1
    Public EndDate As Integer = 12
    Public gid As Integer
    Public NumberofMonths As Integer
    Private Sub Record_Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = Form1
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            SQL.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblPay'")
            If SQL.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                SQL.RunQuery("DROP TABLE tblPAy")
            End If

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID From tblGrade WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If

            AmountTextBox.Enabled = False
            NoteTextBox.Enabled = False
            AccountComboBox.Enabled = False
            EndMonthTextBox.Enabled = False
            StartMonthTextBox.Enabled = False

            If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If


            SQL.RunQuery("Create Table tblPay (LearnerID int Unique Not NULL , LFName varchar(50), Amount Decimal(18,2) Default 0, Selected Bit Default 0 ) ")
                Cursor.Current = Cursors.Arrow


            PopMonths()
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub AccountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountComboBox.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor
        If AccountComboBox.SelectedIndex > -1 Then
            NoteTextBox.Text = AccountComboBox.Text
            If SQL.HasConnnection = True Then
                Cursor.Current = Cursors.WaitCursor
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                SQL.RunQuery("SELECT * FRom tblACCOUNT , tblLearnerGrade where tblAccount.LearnerID = tblLearnerGrade.LearnerID and tblLearnerGrade.GradeID = '" & Integer.Parse(GradeComboBox.SelectedItem) & "' AND tblAccount.TransType =1 AND AType = '" & AccountComboBox.SelectedItem.ToString & "' ")
                If SQL.SQLDataSet.Tables(0).Rows.Count = 0 Then
                    setUpTable()
                Else
                    SQL.SQLDataSet.Clear()
                    SQL.RunQuery("DELETE FROM tblPAY")
                    SQL.RunQuery("Insert into tblPay(LearnerID,LFname , Amount) Select tblLearner.LearnerID, tblLearner.LName +' '+ tblLearner.LSurname AS 'LFname',SUM(tblAccount.Amount) AS 'Total'  FROM tblLearner , tblLearnerGrade,tblAccount WHERE tblLearner.LearnerID = tblLearnerGrade.LearnerID AND tblAccount.LearnerID = tblLearnerGrade.LearnerID and tblLearner.LAccount = 1 AND tblLearner.LStatus = 1 AND tblLearnerGrade.GradeID = '" & Integer.Parse(GradeComboBox.SelectedItem) & "' AND tblAccount.TransType =1 AND AType = '" & AccountComboBox.SelectedItem.ToString & "' Group By TblLearner.LearnerId, LName , tblLearner.LSurname")
                    PopGrid()
                    SQL.RunQuery("SELECT * FROm tblLearnerGrade WHERE tblLearnerGrade.GradeID = '" & Integer.Parse(GradeComboBox.SelectedItem) & "'")
                    If (SQL.SQLDataSet.Tables(0).Rows.Count <> dgvLAccounts.Rows.Count) Then

                        SQL.RunQuery("Insert into tblPay(LearnerID,LFname) SELECT tblLearner.LearnerID , tblLearner.LName +' '+ tblLearner.LSurname AS 'LFname' FROM tbllearner,tblLearnerGrade WHERE tblLearnerGrade.LearnerID = tblLearner.LearnerID AND tblLearner.LAccount =1 AND tblLearner.LStatus =1 AND tblLearnerGrade.GradeId=  '" & Integer.Parse(GradeComboBox.SelectedItem) & "' AND tblLearner.LearnerID NOt IN(Select Distinct tbllearner.LearnerID FROM tbllearnergrade,tblLearner right JOin tblaccount on tblAccount.LearnerID = tblLearner.LearnerID WHERE  tblLearner.LearnerID = tblLearnerGrade.LearnerID AND tblLearner.LAccount = 1 AND tblLearner.LStatus = 1 AND tblLearnerGrade.GradeID =  '" & Integer.Parse(GradeComboBox.SelectedItem) & "' AND tblAccount.TransType =1 AND AType = '" & AccountComboBox.SelectedItem.ToString & "')")
                    End If
                End If
                PopGrid()
                Cursor.Current = Cursors.Arrow
            Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Public Sub PopGrid()
        If SQL.HasConnnection Then
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("SELECT * FROM tblPay ORDER BY LearnerID")

            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvLAccounts.DataSource = dbTable
            dgvLAccounts.Columns(1).HeaderText = "Learner Name"
            dgvLAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            'dgvLAccounts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'dgvLAccounts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'dgvLAccounts.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'dgvLAccounts.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvLAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub setUpTable()
        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("DELETE FROM tblPay")
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("Insert into tblPay(LearnerID,LFname) Select tblLearner.LearnerID, tblLearner.LName +' '+ tblLearner.LSurname AS 'LFname' FROM tblLearner , tblLearnerGrade WHERE tblLearner.LearnerID = tblLearnerGrade.LearnerID  and tblLearner.LAccount = 1 AND tblLearner.LStatus = 1 AND tblLearnerGrade.GradeID = '" & Integer.Parse(GradeComboBox.SelectedItem) & "'")
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("Update tblPay Set Selected = 0")
            SQL.SQLDataSet.Clear()

            PopGrid()
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub EndMonthTextBox_Leave(sender As Object, e As EventArgs) Handles EndMonthTextBox.Leave

        If IsNumeric(EndMonthTextBox.Text) AndAlso (Integer.Parse(EndMonthTextBox.Text)) >= 1 AndAlso (Integer.Parse(EndMonthTextBox.Text)) <= 12 Then
            If Integer.Parse(StartMonthTextBox.Text) <= Integer.Parse(EndMonthTextBox.Text) Then
                PopMonths()
            Else
                MessageBox.Show("End Month Cannot be before Start Month", "Error: Month incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EndMonthTextBox.Clear()
                EndMonthTextBox.Focus()
            End If

        Else
            MessageBox.Show("Month Invalid: Month must be between 1-12", "Error: Month incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndMonthTextBox.Clear()
            EndMonthTextBox.Focus()
        End If

    End Sub




    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If AccountComboBox.SelectedIndex > -1 Then
            If MessageBox.Show("Canceling will result in loss of data. Do you still wish to cancel? ", "Canceling of Data Caputure ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
                Form1.Show()
            End If
        Else
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub GradeComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedValueChanged
        If GradeComboBox.SelectedIndex > -1 Then
            AmountTextBox.Enabled = True
            NoteTextBox.Enabled = True
            AccountComboBox.Enabled = True
            SQL.SQLDataSet.Clear()
            setUpTable()
        End If

    End Sub

    Public Sub PopMonths()
        MonthBreakDownBox.Text = ""
        MonthBreakDownBox.AppendText("Month" + vbTab + "Montly Amount" & Environment.NewLine)
        If (Integer.Parse(StartMonthTextBox.Text)) > (Integer.Parse(EndMonthTextBox.Text)) Then
            MessageBox.Show("End Month can not be before Start Month", "Error in Payment Period ", MessageBoxButtons.OKCancel)
            EndMonthTextBox.Clear()
        End If
        If (AccountComboBox.SelectedItem IsNot Nothing) AndAlso (AmountTextBox.Text IsNot Nothing) AndAlso (StartMonthTextBox.Text IsNot Nothing) AndAlso (EndMonthTextBox.Text IsNot Nothing) Then
            Amount = Decimal.Parse(AmountTextBox.Text)
            Start = Integer.Parse(StartMonthTextBox.Text)
            EndDate = Integer.Parse(EndMonthTextBox.Text)
            If (Start = EndDate) Then
                MonthlyAmm = Amount
            Else
                NumberofMonths = ((EndDate - Start) + 1)
                MonthlyAmm = Amount / NumberofMonths
                MonthlyAmm = Math.Round(MonthlyAmm, 2)
            End If

        End If
        For x = 0 To arrMonths.Length - 1
            If (x >= Start) And (x <= EndDate) Then
                If x = EndDate Then
                    LastMonth = MonthlyAmm - ((MonthlyAmm * NumberofMonths) - Amount)
                    MonthBreakDownBox.AppendText(arrMonths(x - 1) + vbTab + FormatNumber(LastMonth, 2) & Environment.NewLine)
                Else
                    MonthBreakDownBox.AppendText(arrMonths(x - 1) + vbTab + FormatNumber(MonthlyAmm, 2) & Environment.NewLine)
                End If

            End If
        Next x

    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim ID As Integer = 0

        Dim no As Integer = 0
        Cursor.Current = Cursors.WaitCursor
        If (AccountComboBox.SelectedItem IsNot Nothing) AndAlso (AmountTextBox.Text IsNot Nothing) AndAlso (StartMonthTextBox.Text IsNot Nothing) AndAlso (EndMonthTextBox.Text IsNot Nothing) Then
            Amount = Decimal.Parse(AmountTextBox.Text)
            For x = 0 To dgvLAccounts.Rows.Count - 1
                If dgvLAccounts.Rows(x).Cells.Item(3).Value = True Then
                    dgvLAccounts.Item(2, x).Value = dgvLAccounts.Item(2, x).Value + Amount
                    SQL.RunQuery("SELECT * FROm tblACCOUNT where TransType = 1 AND LearnerID = '" & dgvLAccounts.Item(0, x).Value & "' AND AType = '" & AccountComboBox.SelectedItem.ToString & "'")
                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                        SQL.RunQuery("DELETE FROm tblAccount WHERE TransType = 1 AND LearnerID = '" & dgvLAccounts.Item(0, x).Value & "' And AType = '" & AccountComboBox.SelectedItem.ToString & "'")
                    End If
                    no = no + 1
                End If
            Next x

            If no = 0 Then
                MessageBox.Show("Please Select Learners", "No Learners selected", MessageBoxButtons.OK)

            Else
                If SQL.HasConnnection Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If
                    For x = 0 To dgvLAccounts.Rows.Count - 1
                        If dgvLAccounts.Rows(x).Cells.Item(3).Value = True Then
                            If dgvLAccounts.Item(2, x).Value > 0 Then
                                MonthlyAmm = dgvLAccounts.Item(2, x).Value / NumberofMonths
                                For i = 0 To arrMonths.Length - 1
                                    If (i >= Start) And (i <= EndDate) Then
                                        SQL.RunQuery("Select * From tblAccount")
                                        If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                                            SQL.RunQuery("Select MAX(AccountID) AS HighestID FROM tblAccount")
                                            ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                                        Else
                                            ID = 0
                                        End If
                                        SQL.SQLDataSet.Clear()
                                        If i = EndDate Then
                                            MonthlyAmm = LastMonth
                                        End If
                                        SQL.RunQuery("INSERT INTO tblAccount(AccountID,LearnerID,AType,TransDay,TransMonth,TransYear,Amount,TransNote,TransType) VALUES('" & ID & "','" & dgvLAccounts.Item(0, x).Value & "','" & AccountComboBox.SelectedItem & "','" & 1 & "','" & i & "','" & System.DateTime.Today.Year & "','" & MonthlyAmm & "','" & NoteTextBox.Text & "','" & 1 & "')")
                                        SQL.SQLDataSet.Clear()

                                    End If
                                Next i
                            End If
                        End If
                    Next x
                    Cursor.Current = Cursors.Default
                    MessageBox.Show(no.ToString + " Accounts Updated", "Confirmation of Accounts Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If MessageBox.Show("Do you want to record fees for another Learner", "Record Fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        GradeComboBox.SelectedIndex = -1
                        AccountComboBox.SelectedIndex = -1
                        AmountTextBox.Clear()
                        NoteTextBox.Clear()
                        StartMonthTextBox.Text = "2"
                        EndMonthTextBox.Text = "11"
                        AmountTextBox.Enabled = False
                        NoteTextBox.Enabled = False
                        AccountComboBox.Enabled = False
                        EndMonthTextBox.Enabled = False
                        StartMonthTextBox.Enabled = False
                        MonthBreakDownBox.Clear()
                    Else
                        Me.Close()
                        Form1.Show()
                    End If
                End If

            End If
        Else
            MessageBox.Show("Enter All relevant information", "Error: Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Default
    End Sub



    Private Sub AmountTextBox_Leave(sender As Object, e As EventArgs) Handles AmountTextBox.Leave
        If IsNumeric(AmountTextBox.Text) Then
            EndMonthTextBox.Enabled = True
            StartMonthTextBox.Enabled = True
            PopMonths()
        Else
            MessageBox.Show("Enter digits only for Amount", "Error: Amount incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AmountTextBox.Clear()
        End If
    End Sub


    Private Sub Record_Fees_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SQL.RunQuery("drop table tblPay")
    End Sub

    Private Sub StartMonthTextBox_Leave(sender As Object, e As EventArgs) Handles StartMonthTextBox.Leave
        If IsNumeric(StartMonthTextBox.Text) AndAlso Integer.Parse(StartMonthTextBox.Text) >= 1 AndAlso Integer.Parse(StartMonthTextBox.Text) <= 12 Then
            PopMonths()
        Else
            MessageBox.Show("Month Invalid: Month must be between 1-12", "Error: Month incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StartMonthTextBox.Clear()
            StartMonthTextBox.Focus()
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged

    End Sub
End Class