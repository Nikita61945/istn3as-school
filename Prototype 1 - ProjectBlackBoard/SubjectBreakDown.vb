Public Class SubjectBreakDown
    Public sql As New DataBaseControl
    Private Sub SubjectBreakDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Sql.HasConnnection = True Then
            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If
            sql.RunQuery("SELECT COUNT(*) As 'Total' FROM information_schema.tables WHERE table_name = 'tblPRaw'")
            If Sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                sql.RunQuery("DROP TABLE tblPRaw")
                sql.RunQuery("Drop table tblpSUm")
            End If


            sql.RunQuery("CREATE TABLE tblPRaw(GradeID int , year int, LearnerID int, SubjectID varchar(50), SubjectName varchar(50), LSUbmark decimal(18,2))")

            sql.RunQuery("INSERT into tblPRaw(GradeID,LearnerID,SubjectID,year,SubjectName,Lsubmark) SELECT tblPoa.gradeid, tblMark.learnerid, tblSubgrade.subjectid, tblpoa.year, tblSubject.SubjectName,  (sum( tblMark.mark)/sum( tblPoa.total))*100 as LSubmark  FROM tblpoa INNER JOIN tblmark ON  tblPoa.poaid = tblMark.poaid INNER JOIN tblsubgrade ON tblSubgrade.subjectid = tblPoa.subjectid and tblSubgrade.gradeid = tblPoa.gradeid INNER JOIN tblsubject ON tblSubject.subjectid = tblPoa.subjectid  WHERE tblPoa.active = 1 AND NOt(tblPoa.status = 'F')  GROUP BY tblPoa.gradeid, tblMark.learnerid, tblSubgrade.subjectid, tblSubject.subjectname,tblpoa.year ")

            sql.RunQuery("Create table tblPSum(SubjectID varchar(50) , SubjectNAme varchar(50) , NoWrote int , NoFailed int Default 0, PAssrate NUmeric(18,2), GradeID int, year int)")

            sql.RunQuery("INSERT INTO tblPsum (subjectid, subjectname,gradeID,year) SELECT distinct subjectid, subjectName , gradeid , year FROM tblPRaw ")

            sql.RunQuery("UPDATE tblPSUm SET nowrote  = (select COUNT(learnerid) from tblPraw WHERE TblPSUm.subjectid = tblPraw.subjectid and tblPraw.GRADEID = tblPSum.gradeid and tblPraw.year = tblPSum.year  )")

            sql.RunQuery("UPDATE tblPsum SET nofailed  = (select COUNT(learnerid) from tblPRaw WHERE TBlpSUm.subjectid = tblpraw.subjectid 
            AND lsubmark < 40 and tblPraw.GRADEID = tblPSum.gradeid and tblPraw.year = tblPSum.year)")
            sql.RunQuery("UPDATE tblPSUm SET passrate = (((Nowrote-Nofailed)/nowrote)*100)")
            sql.RunQuery("Select * FROm tblpSUm Where NoFailed > 0")
            Dim y = sql.SQLDataSet.Tables(0).Rows.Count - 1
            For x = 0 To y
                Dim NoPass = FormatNumber(((sql.SQLDataSet.Tables(0).Rows(x).Item("NoWrote") - sql.SQLDataSet.Tables(0).Rows(x).Item("NoFailed")) / sql.SQLDataSet.Tables(0).Rows(x).Item("NoWrote")) * 100, 2)
                Dim SubjID = sql.SQLDataSet.Tables(0).Rows(x).Item("SubjectID")
                Dim gID = sql.SQLDataSet.Tables(0).Rows(x).Item("GradeID")
                Dim ryear = sql.SQLDataSet.Tables(0).Rows(x).Item("Year")
                sql.RunQuery("Update tblpSUm Set Passrate = " & NoPass & " WHERE SUbjectID ='" & SubjID & "' AND GradeID = " & gID & " AND year =" & ryear & "")
                sql.RunQuery("Select * FROm tblpSUm Where NoFailed > 0")
            Next x




        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Dim report As New SubjectReportB
        'CrystalReportViewer1.ReportSource = report
        'CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class