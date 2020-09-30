Public Class ProjectedTutorSalariesForMonth
    Public SQL As New DataBaseControl
    Private Sub ProjectedTutorSalariesForMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Me.WindowState = FormWindowState.Maximized
        Dim thismonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        Dim day = thismonth.DayOfWeek + 7

        SQL.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'ProposedTSalary'")
        If Sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
            SQL.RunQuery("DROP TABLE ProposedTSalary")
        End If
        SQL.RunQuery("Create TABLE PropsedTSalary(TutorID int, TutorName VArchar(5) , Propsesed Salary Decimal(18,2))")

        SQL.RunQuery("INSERT INTO GradesDetails(TutorID,TutorNAme) SELECT TutorID, Fname + ' ' + Surname AS 'Tutor Name' FROM tblTutor")

        SQL.RunQuery("SELECT tblTUtor.TUtorID, tblTUtor.salary FROM tblTUtor WHERE PAymentStyle = 'Hourly' ")
        For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
            Dim TID As Integer = SQL.SQLDataSet.Tables(0).Rows(x).Item("TutorID")
            Dim TSal As Decimal = SQL.SQLDataSet.Tables(0).Rows(x).Item("Salary")
            SQL.RunQuery("SELECT * FROM TutorTimes WHERE TutorID = " & TID & "")
            Dim NoOfHours As Integer = 0
            For a = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                If SQL.SQLDataSet.Tables(0).Rows(x).Item("AllDAY") = vbNull Then
                    NoOfHours += SQL.SQLDataSet.Tables(0).Rows(x).Item("ENdTime") - SQL.SQLDataSet.Tables(0).Rows(x).Item("StartTIme")
                Else
                    NoOfHours += 6
                End If
            Next a
            '' Dim PSal = TSal * NoOfHours * 

            SQL.RunQuery("SELECT tblTUtor.TUtorID, tblTUtor.salary FROM tblTUtor WHERE PAymentStyle = 'Hourly' ")
        Next x






    End Sub
End Class