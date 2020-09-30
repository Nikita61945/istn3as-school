Public Class YEComposite
    Public sql As New DataBaseControl

    Private Sub YEComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Check if tables exist, if so drop them
        If sql.HasConnnection = True Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If
            sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblComp'")
            If sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                sql.RunQuery("DROP TABLE tblcomp")
                sql.RunQuery("Drop table tblCompMark")
            End If
        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Create tables for the report

        sql.RunQuery("Create table TblCompMark (learnerid int,SubGradeid varchar(20),LMark decimal(18,2),LTotal decimal(18,2)) ")

        sql.RunQuery("Create table TblComp (learnerid int, LName varchar(50), LSurname varchar(30), Gradeid int, Year int, SubGradeid varchar(20),SubjectName varchar(50), SBARate decimal(18,2),MSba decimal(18,2),TSba decimal(18,2),Meoy decimal(18,2),TEoy decimal(18,2)) ")

        ' insert learner and subject info

        sql.RunQuery("insert into tblcomp(learnerid, subgradeid, lname,  lsurname, subjectname, year, gradeid, sbarate) SELECT tblLearner.LearnerID, tblSubGrade.SubGradeID, tblLearner.LName, tblLearner.LSurname, tblSubject.SubjectName, tblEnrollment.AcademicYear, tblSubGrade.GradeID, tblSubGrade.SBA_Weight FROM tblEnrollment INNER JOIN tblLearner ON tblEnrollment.LearnerID = tblLearner.LearnerID INNER JOIN tblSubGrade ON tblEnrollment.SubGradeID = tblSubGrade.SubGradeID INNER JOIN tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE (tblLearner.LStatus = 1) AND (tblEnrollment.AcademicYear = 2019) AND (tblSubGrade.GradeID = 8) AND (tblEnrollment.Active = 1) ORDER BY tblLearner.LSurname, tblLearner.LName, tblSubject.DisplayOrder ")

        ' insert mark info in tblcompmark - SBA
        sql.RunQuery("SELECT tblMark.LearnerID, tblPOA.SubGradeID, tblMark.mark, tblPOA.Total FROM tblPOA INNER JOIN tblMark ON tblPOA.POAID = tblMark.POAID INNER JOIN tblSubGrade ON tblPOA.SubGradeID = tblSubGrade.SubGradeID WHERE (tblSubGrade.GradeID = 8) AND (tblPOA.Year = 2019) AND (tblPOA.isSBA = 1) ")

        sql.RunQuery("Update tblcomp set tblcomp.Msba = (select sum(tblcompmark.lmark) from tblCompMark where tblcomp.learnerid = tmcompmark.learnerid and tblcomp.subgradeid = tblcompmark.subgradeid group by tblcompmark.learnerid, tblcompmark.subgradeid)")

        sql.RunQuery("Update tblcomp set tblcomp.Tsba = (select sum(tblcompmark.Ltotal) from tblCompMark where tblcomp.learnerid = tmcompmark.learnerid and tblcomp.subgradeid = tblcompmark.subgradeid group by tblcompmark.learnerid, tblcompmark.subgradeid)")

        ' insert mark info in tblcompmark - EOY
        sql.RunQuery("SELECT tblMark.LearnerID, tblPOA.SubGradeID, tblMark.mark, tblPOA.Total FROM tblPOA INNER JOIN tblMark ON tblPOA.POAID = tblMark.POAID INNER JOIN tblSubGrade ON tblPOA.SubGradeID = tblSubGrade.SubGradeID WHERE (tblSubGrade.GradeID = 8) AND (tblPOA.Year = 2019) AND (tblPOA.isSBA = 0) ")

        sql.RunQuery("Update tblcomp set tblcomp.Meoy = (select sum(tblcompmark.lmark) from tblCompMark where tblcomp.learnerid = tmcompmark.learnerid and tblcomp.subgradeid = tblcompmark.subgradeid group by tblcompmark.learnerid, tblcompmark.subgradeid)")

        sql.RunQuery("Update tblcomp set tblcomp.Teoy = (select sum(tblcompmark.lTotal) from tblCompMark where tblcomp.learnerid = tmcompmark.learnerid and tblcomp.subgradeid = tblcompmark.subgradeid group by tblcompmark.learnerid, tblcompmark.subgradeid)")


    End Sub
End Class