Public Class YeComposite
    Public sql As New DataBaseControl
    Private Sub YeComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TblComp' table. You can move, or remove it, as needed.
        ' Me.TblCompTableAdapter.Fill(Me.DataSet1.TblComp)

        If sql.HasConnnection = True Then

            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("SELECT GradeId FROM tblGrade WHERE isOffered =1")

            Dim y As Integer = 0
            If sql.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For Each x As DataRow In sql.SQLDataSet.Tables(0).Rows
                    ComboBoxGrade.Items.Add(sql.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next
            End If
        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = vbNullString
        If TextBox1.Text.Length.Equals(4) Then
            If IsNumeric(TextBox1.Text) = False Then
                msg = msg + "Year must be numeric" + Environment.NewLine
            End If
        Else
            msg = msg + "Year must be 4  digits" + Environment.NewLine
        End If
        If ComboBoxGrade.SelectedIndex = -1 Then
            msg = msg + "Grade is not Selected" + Environment.NewLine
        End If
        If msg = vbNullString Then
            ' Check if tables exist, if so drop them
            If Sql.HasConnnection = True Then
                If Sql.SQLDataSet IsNot Nothing Then
                    Sql.SQLDataSet.Clear()
                End If
                Sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblComp'")
                If Sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                    Sql.RunQuery("DROP TABLE tblcomp")
                    Sql.RunQuery("Drop table tblCompMark")
                End If
            Else
                MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Create tables for the report

            sql.RunQuery("Create table TblCompMark (learnerid int ,GradeID int,Subjectid varchar(20),LMark decimal(18,2),LTotal decimal(18,2)) ")

            sql.RunQuery("Create table TblComp (learnerid int, LName varchar(50), LSurname varchar(30), Gradeid int, Year int, Subjectid varchar(20),SubjectName varchar(50), SBARate decimal(18,2),MSba decimal(18,2),TSba decimal(18,2),Meoy decimal(18,2),TEoy decimal(18,2)) ")

            ' insert learner and subject info

            sql.RunQuery("insert into tblcomp(learnerid, subjectid, lname,  lsurname, subjectname, year, gradeid, sbarate) SELECT tblLearner.LearnerID, tblSubGrade.SubjectID, tblLearner.LName, tblLearner.LSurname, tblSubject.SubjectName, tblEnrolment.AcademicYear, tblSubGrade.GradeID, tblSubGrade.SBA_Weight FROM tblEnrolment INNER JOIN tblLearner ON tblEnrolment.LearnerID = tblLearner.LearnerID INNER JOIN tblSubGrade ON tblEnrolment.SubjectID = tblSubGrade.SubjectID AND tblEnrolment.GradeID = tblSubGrade.GradeID INNER JOIN tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE (tblLearner.LStatus = 1) AND (tblEnrolment.AcademicYear = '" & Integer.Parse(TextBox1.Text) & "') AND (tblSubGrade.GradeID = '" & ComboBoxGrade.SelectedItem & "') AND (tblEnrolment.Active = 1) ORDER BY tblLearner.LSurname, tblLearner.LName, tblSubject.DisplayOrder ")

            ' insert mark info in tblcompmark - SBA
            sql.RunQuery("Insert into tblcompmark(learnerid,lmark,gradeid,subjectid,ltotal) SELECT tblMark.LearnerID, tblMark.mark,tblsubgrade.gradeid, tblSubGrade.SubjectID, tblPOA.Total FROM tblMark INNER JOIN tblPOA ON tblMark.POAID = tblPOA.POAID INNER JOIN tblSubGrade ON tblPOA.SubjectID = tblSubGrade.SubjectID AND tblPOA.GradeID = tblSubGrade.GradeID WHERE (tblSubGrade.GradeID = '" & ComboBoxGrade.SelectedItem & "') AND (tblPOA.Year = '" & Integer.Parse(TextBox1.Text) & "') AND (tblPOA.isSBA = 1) ")

            sql.RunQuery("Update tblcomp set tblcomp.Msba = (select sum(tblcompmark.lmark) from tblCompMark where tblcomp.learnerid = tblcompmark.learnerid and tblcomp.subjectid = tblcompmark.subjectid and tblcomp.gradeid = tblcompmark.gradeid  group by tblcompmark.learnerid, tblcompmark.gradeid,tblcompmark.subjectid)")

            sql.RunQuery("Update tblcomp set tblcomp.Tsba = (select sum(tblcompmark.Ltotal) from tblCompMark where tblcomp.learnerid = tblcompmark.learnerid and tblcomp.subjectid = tblcompmark.subjectid and tblcomp.gradeid = tblcompmark.gradeid group by tblcompmark.learnerid, tblcompmark.gradeid,tblcompmark.Subjectid)")

            sql.RunQuery("Delete from tblcompmark")
            '' insert mark info in tblcompmark - EOY
            sql.RunQuery("Insert into tblcompmark(learnerid,lmark,gradeid,subjectid,ltotal) SELECT tblMark.LearnerID, tblMark.mark, tblSubGrade.GradeID, tblSubGrade.SubjectID, tblPOA.Total FROM tblMark INNER JOIN tblPOA ON tblMark.POAID = tblPOA.POAID INNER JOIN tblSubGrade ON tblPOA.GradeID = tblSubGrade.GradeID and tblPOA.subjectID = tblSubGrade.subjectID WHERE (tblSubGrade.GradeID = '" & ComboBoxGrade.SelectedItem & "') AND (tblPOA.Year = '" & Integer.Parse(TextBox1.Text) & "') AND (tblPOA.isSBA = 0) ")

            sql.RunQuery("Update tblcomp set tblcomp.Meoy = (select sum(tblcompmark.lmark) from tblCompMark where tblcomp.learnerid = tblcompmark.learnerid and tblcomp.gradeid = tblcompmark.gradeid and tblcomp.subjectid = tblcompmark.subjectid group by tblcompmark.learnerid, tblcompmark.gradeid, tblcompmark.subjectid)")

            sql.RunQuery("Update tblcomp set tblcomp.Teoy = (select sum(tblcompmark.lTotal) from tblCompMark where tblcomp.learnerid = tblcompmark.learnerid and tblcomp.gradeid = tblcompmark.gradeid and tblcomp.subjectid = tblcompmark.Subjectid group by tblcompmark.learnerid, tblcompmark.gradeid,tblcompmark.subjectid)")

            Me.TblCompTableAdapter.Fill(Me.DataSet1.TblComp)

            Me.ReportViewer1.RefreshReport()

        Else
            MessageBox.Show(msg, "Errors in informaton", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub YeComposite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class