Imports Microsoft.Reporting
Imports Microsoft.ReportingServices
Public Class MonthStatement
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Monthly statment
        Me.DataSet1.EnforceConstraints = False
        Me.DataTable1TableAdapter.FillMS(Me.DataSet1.DataTable1, TextBox1.Text, TextBox2.Text)
        Dim parMS As New Microsoft.Reporting.WinForms.ReportParameter("RepMonth", TextBox2.Text)
        ReportViewer1.LocalReport.SetParameters(parMS)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub MonthStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        '  Me.DataTable1TableAdapter.FillMS(Me.DataSet1.DataTable1)

    End Sub
End Class