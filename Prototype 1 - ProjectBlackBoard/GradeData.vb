Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class GradeData
    Public sql As New DataBaseControl
    Private Sub GradeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        cryRpt.Load("C:\Users\Bibi Ayesha\Desktop\ISTNAS_Final - With Splash\ISTNAS_Final - I think\ISTNAS_Final with Scheduling\ISTNAS_Final\Prototype 1 - ProjectBlackBoard\GradeDetails.rpt")


        With crConnectionInfo
            .ServerName = "146.230.177.46\ist3"
            .DatabaseName = "group31"
            .UserID = "group31"
            .Password = "78bdn"
            .IntegratedSecurity = False
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load



    End Sub


End Class