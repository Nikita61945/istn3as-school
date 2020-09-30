Imports Microsoft.Reporting
Imports Microsoft.ReportingServices
Public Class MonthlyStatement
    Public SQL As New DataBaseControl
    Private Sub MonthlyStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        ' Me.DataTable1TableAdapter.FillMS(Me.DataSet1.DataTable1)

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT LearnerID, convert(varChar(6),LearnerID) +' '+LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE LStatus = 1 and LAccount =1 ")

            Dim y As Integer = 0
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    LearnerCB.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                    y = y + 1
                Next
            End If
        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataSet1.EnforceConstraints = False
        If LearnerCB.SelectedIndex > -1 Then
            WindowState = 2
            Me.DataTable1TableAdapter.FillMS(Me.DataSet1.DataTable1, Integer.Parse(LearnerCB.SelectedItem.ToString.Substring(0, LearnerCB.SelectedItem.ToString.IndexOf(" "))), NumericUpDown1.Value)
            Dim parMS As New Microsoft.Reporting.WinForms.ReportParameter("RepMonth", NumericUpDown1.Value.ToString)
            ReportViewer1.LocalReport.SetParameters(parMS)

            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Select a learner first please", "No learner selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MonthlyStatement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class