
Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MSDataset.tblAccount' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.tblAccountTableAdapter.Fill(Me.MSDataset.tblAccount)
        'TODO: This line of code loads data into the 'MSDataset.tblLearner' table. You can move, or remove it, as needed.
        Me.tblLearnerTableAdapter.Fill(Me.MSDataset.tblLearner)
        AddHandler Me.ReportViewer1.LocalReport.SubreportProcessing, AddressOf mssubreporteventhandler
        'Me.DataSet1.EnforceConstraints = False
        ' Me.DataTable1TableAdapter.FillMS(Me.DataSet1.DataTable1)
        Me.ReportViewer1.RefreshReport()
    End Sub

    ' Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    'End Sub
    Public Sub mssubreporteventhandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim msDetails As DataTable
        msDetails = Me.MSDataset.Tables("tblAccount")
        Dim strgfilter As String
        strgfilter = e.Parameters("LearnerID").Values.First()
        Me.tblAccountTableAdapter.FillByMS(Me.MSDataset.tblAccount, strgfilter)
        e.DataSources.Add(New ReportDataSource("MSDataset", msDetails))

    End Sub
End Class
