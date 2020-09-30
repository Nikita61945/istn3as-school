Public Class OpeningBalance
    Public SQL As New DataBaseControl

    Private Sub OpeningBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT LearnerID,LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE tblLearner.LAccount =1 and tblLearner.LStatus =1 AND tblLearner.LearnerID NOt IN(Select Distinct tbllearner.LearnerID FROM tblLearner right JOin tblaccount on tblAccount.LearnerID = tblLearner.LearnerID WHERE tblAccount.transtype = 0)")
            Dim y As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    LeanersComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID") & " " & SQL.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                    y = y + 1
                Next
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        Dim ID As Integer = 1

        If (Form1.isFieldBlank(OpeningBalTextBox.Text) = False) And (LeanersComboBox.SelectedIndex > -1) Then
            If (IsNumeric(OpeningBalTextBox.Text)) Then

                If SQL.HasConnnection = True Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If
                    SQL.RunQuery("Select MAX(AccountID) AS HighestID FROM tblAccount")

                    If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                        ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                    End If
                    SQL.SQLDataSet.Clear()


                    SQL.RunQuery("INSERT into tblAccount(AccountID,LearnerId, AType,TransDay,TransMonth,TransYear,Amount,RefNo,SourceDoc,TransNote,TransType) Values('" & ID & "','" & Integer.Parse(((LeanersComboBox.SelectedItem).ToString).Substring(0, 4)) & "','Tutoring and Support Fees',01,02,'" & Integer.Parse(System.DateTime.Today.Year.ToString) & "','" & Decimal.Parse(OpeningBalTextBox.Text) & "',NULL,NUll,'Opening Balance',0)")
                    MessageBox.Show((LeanersComboBox.SelectedItem).ToString + " Account Updated ", "Confimation of Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If MessageBox.Show("Do you want to add Opening Balance for another Learner", "Record Opening Balance", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        OpeningBalTextBox.Clear()
                        LeanersComboBox.SelectedIndex = -1
                    Else
                        Me.Close()
                        Form1.Show()
                    End If


                Else
                    MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter only numbers for Opening Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OpeningBalTextBox.Clear()
                OpeningBalTextBox.Focus()
            End If
        Else
            MessageBox.Show("Please fill in ALL Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


End Class