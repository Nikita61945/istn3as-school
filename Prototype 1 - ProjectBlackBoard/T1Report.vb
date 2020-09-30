Public Class T1Report
    Public sql As New DataBaseControl
    Private Sub T1Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TRTemp' table. You can move, or remove it, as needed.
        'Me.TRTempTableAdapter.Fill(Me.DataSet1.TRTemp)

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
        ' Check if tables exist, if so drop them
        Dim msg As String = vbNullString
        If ComboBoxGrade.SelectedIndex = -1 Then
            msg = msg + "Grade is not Selected" + Environment.NewLine
        End If
        If TextBox1.Text.Length.Equals(4) Then
            If IsNumeric(TextBox1.Text) = False Then
                msg = msg + "Year must be numeric" + Environment.NewLine
            End If
        Else
            msg = msg + "Year must be 4 digits" + Environment.NewLine
        End If
        If msg = vbNullString Then
            If Sql.HasConnnection = True Then
                If Sql.SQLDataSet IsNot Nothing Then
                    Sql.SQLDataSet.Clear()
                End If
                Sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'trtemp'")
                If Sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                    Sql.RunQuery("DROP TABLE trtemp")
                    Sql.RunQuery("Drop table tmtemp")
                End If
            Else
                MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Create tables for the report

            sql.RunQuery("Create table TMTemp (learnerid int,GRadeId int ,Subjectid varchar(20),Term int,Mark decimal(18,2),Total decimal(18,2)) ")
            sql.RunQuery("Create table TRTemp (learnerid int,IDNo varchar(13),LName varchar(50),LSurname varchar(30),Gradeid int,Subjectid varchar(20),SubjectName varchar(50),T1T decimal(18,2),T1M decimal(18,2),T1 decimal(18,2),T2T decimal(18,2),T2M decimal(18,2),T2 decimal(18,2),T3 decimal(18,2),T3T decimal(18,2),T3M decimal(18,2),T4 decimal(18,2),T4T decimal(18,2),T4M decimal(18,2),SBA decimal(18,2),SBAT decimal(18,2),SBAM decimal(18,2),EOY decimal(18,2),EOYT decimal(18,2),EOYM decimal(18,2),Ltotal decimal(18,2), Ranking int) ")

            'Insert Learner and subject info

            sql.RunQuery("Insert into trtemp (learnerid, idno, lname, lsurname, gradeid, subjectid, subjectname)  select distinct tbllearner.learnerid, tbllearner.IDno, tbllearner.lname, tbllearner.lsurname, tbllearnerGrade.gradeid, tblenrolment.subjectid, tblsubject.subjectname from tbllearner, tbllearnerGrade, tblenrolment, tblsubgrade, tblsubject where tbllearner.learnerid = tbllearnergrade.learnerid and tbllearner.learnerid= tblenrolment.learnerid and tblenrolment.subjectid = tblsubgrade.subjectid and tblenrolment.gradeid = tblsubgrade.gradeid and tblsubgrade.subjectid = tblsubject.subjectid and tbllearnergrade.gradeid = '" & Integer.Parse(ComboBoxGrade.SelectedItem) & "' and tbllearnergrade.accademicyear = '" & Integer.Parse(TextBox1.Text) & "' and tbllearner.lstatus=1")

            'Insert detailed mark  info into tmtemp

            sql.RunQuery("Insert into TMtemp(learnerid,gradeid,SubjectID,term,mark,total) Select tbllearnergrade.Learnerid,tblpoa.gradeid,tblpoa.subjectid, tblpoa.term, tblmark.mark, tblpoa.total from tbllearnergrade,tblmark, tblpoa where tbllearnergrade.learnerid = tblmark.learnerid and tblmark.poaid = tblpoa.poaid and tbllearnergrade.gradeid = '" & Integer.Parse(ComboBoxGrade.SelectedItem) & "' and tbllearnergrade.accademicyear = '" & Integer.Parse(TextBox1.Text) & "' and tblpoa.term = 1 ")

            'Update the TRTemp table with sum of marks

            sql.RunQuery("Update trtemp set trtemp.t1m = (select sum(tmtemp.mark) from tmtemp where trtemp.learnerid = tmtemp.learnerid and trtemp.gradeid = tmtemp.gradeid and trtemp.Subjectid = tmtemp.Subjectid and tmtemp.term = 1 group by tmtemp.learnerid, tmtemp.gradeid, tmtemp.SUbjectid )")
            sql.RunQuery("Update trtemp set trtemp.t1t = (select sum(tmtemp.total) from tmtemp where trtemp.learnerid = tmtemp.learnerid and trtemp.gradeid = tmtemp.gradeid and trtemp.Subjectid = tmtemp.Subjectid and tmtemp.term = 1 group by tmtemp.learnerid, tmtemp.gradeid, tmtemp.SUbjectid )")

            sql.RunQuery("update trtemp set ranking=7 where ((t1m/t1t)*100) between 80 and 100")
            sql.RunQuery("update trtemp set ranking=6 where ((t1m/t1t)*100) between 70 and 79")
            sql.RunQuery("update trtemp set ranking=5 where ((t1m/t1t)*100) between 60 and 69")
            sql.RunQuery("update trtemp set ranking=4 where ((t1m/t1t)*100) between 50 and 59")
            sql.RunQuery("update trtemp set ranking=3 where ((t1m/t1t)*100) between 40 and 49")
            sql.RunQuery("update trtemp set ranking=2 where ((t1m/t1t)*100) between 30 and 39")
            sql.RunQuery("update trtemp set ranking=1 where ((t1m/t1t)*100) between 0 and 29")


            Me.DataSet1.EnforceConstraints = False
            Me.TRTempTableAdapter.Fill(Me.DataSet1.TRTemp)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show(msg, "Errors in informaton", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub T1Report_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class