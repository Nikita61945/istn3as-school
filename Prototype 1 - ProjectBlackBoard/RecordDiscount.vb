Public Class RecordDiscount
    Public SQL As New DataBaseControl
    Public MonthlyAmm As Decimal = 0
    Private LastMonth As Decimal
    Public Amount As Decimal = 0
    Public arrMonths As String() = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
    Public Start As Integer = 1
    Public EndDate As Integer = 12
    Public NumberofMonths As Integer
    Private Sub StartMonthTextBox_Leave(sender As Object, e As EventArgs) Handles StartMonthTextBox.Leave
        If IsNumeric(StartMonthTextBox.Text) AndAlso Integer.Parse(StartMonthTextBox.Text) >= 1 AndAlso Integer.Parse(StartMonthTextBox.Text) <= 12 Then
            PopMonths()
        Else
            MessageBox.Show("Month Invalid: Month must be between 1-12", "Error: Month incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StartMonthTextBox.Clear()
            StartMonthTextBox.Focus()
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
    Public Sub PopMonths()
        MonthBreakDownBox.Text = ""
        MonthBreakDownBox.AppendText("Month" + vbTab + "Montly Amount" & Environment.NewLine)
        If (Integer.Parse(StartMonthTextBox.Text)) > (Integer.Parse(EndMonthTextBox.Text)) Then
            MessageBox.Show("End Month can not be before Start Month", "Error in Payment Period ", MessageBoxButtons.OKCancel)
            EndMonthTextBox.Clear()
        End If
        If (SubAccountComboBox.SelectedItem IsNot Nothing) AndAlso (DisAmountTextBox.Text IsNot Nothing) AndAlso (StartMonthTextBox.Text IsNot Nothing) AndAlso (EndMonthTextBox.Text IsNot Nothing) Then
            Amount = Decimal.Parse(DisAmountTextBox.Text)
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


    Private Sub RecordDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        EndMonthTextBox.Enabled = False
        StartMonthTextBox.Enabled = False
        SubAccountComboBox.Enabled = False
        Cursor.Current = Cursors.WaitCursor
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT LearnerID ,LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE LAccount = 1 and LStatus =1")
            Dim y As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    LearnersComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID") & " " & SQL.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                    y = y + 1
                Next
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim ID As Integer
        Dim Amount As Decimal = Decimal.Parse(DisAmountTextBox.Text)
        Dim mesg As String = ""
        Dim dsc = TextBox1.Text
        Cursor.Current = Cursors.WaitCursor
        If SQL.HasConnnection() = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If


            If LearnersComboBox.SelectedIndex = -1 Then
                mesg = mesg + "No learner Selected : Please Select Learner"
            End If

            If SubAccountComboBox.SelectedIndex = -1 Then
                mesg = mesg + "No learner Selected : Please Select Learner"
            End If


            If TextBox1.Text = "" Then
                dsc = "Discount"
            End If
            If DisAmountTextBox.Text Is Nothing AndAlso IsNumeric(DisAmountTextBox.Text) = False Then
                mesg = mesg + "Discount Ammount is Required and must be numeric"
            End If
            If mesg = "" Then
                SQL.RunQuery("Select MAX(AccountID) AS HighestID FROM tblAccount")

                If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                    ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                End If
                SQL.SQLDataSet.Clear()

                For x = Start To EndDate
                    SQL.RunQuery("INSERT INTO tblAccount(AccountID,LearnerId, AType,TransDay,TransMonth,TransYear,Amount,RefNo,SourceDoc,TransNote,TransType) Values('" & ID & "','" & Integer.Parse((((LearnersComboBox.SelectedItem).ToString).Substring(0, LearnersComboBox.SelectedItem.ToString.IndexOf(" ")))) & "','" & SubAccountComboBox.SelectedItem.ToString & "', 01 ,'" & x & "','" & System.DateTime.Today.Year & "','" & MonthlyAmm * -1 & "',NULL,NULL,'" & dsc & "',3)")
                    ID = ID + 1
                Next x
                MessageBox.Show("Discount Given", "Confirmation of Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SubAccountComboBox_SelectedIndexChanged(SaveButton, e)
                DisAmountTextBox.Clear()
                SaveButton.Enabled = False
            Else
                MessageBox.Show(mesg, "Errors in input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow



    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub DisAmountTextBox_Leave(sender As Object, e As EventArgs) Handles DisAmountTextBox.Leave
        If IsNumeric(DisAmountTextBox.Text) Then
            PopMonths()
            StartMonthTextBox.Enabled = True
            EndMonthTextBox.Enabled = True
            SaveButton.Enabled = True
        Else
            MessageBox.Show("Enter digits only for Amount", "Error: Amount incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DisAmountTextBox.Clear()
        End If

    End Sub
    Public Sub PopGrid()
        If SQL.HasConnnection Then
            SQL.SQLDataSet.Clear()


            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            DataGridView1.DataSource = dbTable
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub SubAccountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubAccountComboBox.SelectedIndexChanged
        Cursor.Current = Cursors.WaitCursor

        If SQL.HasConnnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            '' AccountInfoText = 7000

            SQL.RunQuery("SELECT tblAccount.transDay , transMonth, tblAccount.TransNote, TblAccount.Amount  From tblAccount WHere tblAccount.LearnerId = '" & Integer.Parse((((LearnersComboBox.SelectedItem).ToString).Substring(0, LearnersComboBox.SelectedItem.ToString.IndexOf(" ")))) & "' and Atype = '" & SubAccountComboBox.SelectedItem.ToString & "' Order BY transMonth , transType")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                PopGrid()
                SQL.RunQuery("SELECT sum(amount) as 'Total' From tblAccount WHere tblAccount.LearnerId = '" & Integer.Parse((((LearnersComboBox.SelectedItem).ToString).Substring(0, LearnersComboBox.SelectedItem.ToString.IndexOf(" ")))) & "' and Atype = '" & SubAccountComboBox.SelectedItem.ToString & "'")
                fullamount.Text = SQL.SQLDataSet.Tables(0).Rows(0).Item("Total").ToString
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub LearnersComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LearnersComboBox.SelectedIndexChanged
        If SubAccountComboBox.SelectedIndex > -1 Then
            SubAccountComboBox_SelectedIndexChanged(LearnersComboBox, e)
        End If
        SubAccountComboBox.Enabled = True

    End Sub



End Class