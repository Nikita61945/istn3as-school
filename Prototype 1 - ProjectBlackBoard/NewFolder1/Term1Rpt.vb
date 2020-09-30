

Public Class Term1Rpt
    Public sql As New DataBaseControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TRTemp' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Check if tables exist, if so drop them
        If sql.HasConnnection = True Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If
            sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'trtemp'")
            If sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                sql.RunQuery("DROP TABLE trtemp")
                sql.RunQuery("Drop table tmtemp")
            End If
        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Create tables for the report

        sql.RunQuery("Create table TMTemp (learnerid int,SubGradeid varchar(20),Term int,Mark decimal(18,2),Total decimal(18,2)) ")
        sql.RunQuery("Create table TRTemp (learnerid int,IDNo varchar(13),LName varchar(50),LSurname varchar(30),Gradeid int,SubGradeid varchar(20),SubjectName varchar(50),T1T decimal(18,2),T1M decimal(18,2),T1 decimal(18,2),T2T decimal(18,2),T2M decimal(18,2),T2 decimal(18,2),T3 decimal(18,2),T3T decimal(18,2),T3M decimal(18,2),T4 decimal(18,2),T4T decimal(18,2),T4M decimal(18,2),SBA decimal(18,2),SBAT decimal(18,2),SBAM decimal(18,2),EOY decimal(18,2),EOYT decimal(18,2),EOYM decimal(18,2),Ltotal decimal(18,2)) ")

        'Insert Learner and subject info

        sql.RunQuery("Insert into trtemp (learnerid, idno, lname, lsurname, gradeid, subgradeid, subjectname)  select tbllearner.learnerid, tbllearner.IDno, tbllearner.lname, tbllearner.lsurname, tbllearnerGrade.gradeid, tblenrollment.subgradeid, tblsubject.subjectname from tbllearner, tbllearnerGrade, tblenrollment, tblsubgrade, tblsubject where tbllearner.learnerid = tbllearnergrade.learnerid and tbllearner.learnerid= tblenrollment.learnerid and tblenrollment.subgradeid = tblsubgrade.subgradeid and tblsubgrade.subjectid = tblsubject.subjectid and tbllearnergrade.gradeid = '" & Integer.Parse(TextBox2.Text) & "' and tbllearnergrade.accademicyear = '" & Integer.Parse(TextBox1.Text) & "' and tbllearner.lstatus=1")

        'Insert detailed mark  info into tmtemp

        sql.RunQuery("Insert into TMtemp(learnerid,subgradeid,term,mark,total) Select tbllearnergrade.Learnerid,tblpoa.subgradeid, tblpoa.term, tblmark.mark, tblpoa.total from tbllearnergrade,tblmark, tblpoa where tbllearnergrade.learnerid = tblmark.learnerid and tblmark.poaid = tblpoa.poaid and tbllearnergrade.gradeid = '" & Integer.Parse(TextBox2.Text) & "' and tbllearnergrade.accademicyear = '" & Integer.Parse(TextBox1.Text) & "' and tblpoa.term = 1 ")

        'Update the TRTemp table with sum of marks

        sql.RunQuery("Update trtemp set trtemp.t1m = (select sum(tmtemp.mark) from tmtemp where trtemp.learnerid = tmtemp.learnerid and trtemp.subgradeid = tmtemp.subgradeid and tmtemp.term = 1 group by tmtemp.learnerid, tmtemp.subgradeid )")
        sql.RunQuery("Update trtemp set trtemp.t1t = (select sum(tmtemp.total) from tmtemp where trtemp.learnerid = tmtemp.learnerid and trtemp.subgradeid = tmtemp.subgradeid and tmtemp.term = 1 group by tmtemp.learnerid, tmtemp.subgradeid )")


        Me.DataSet1.EnforceConstraints = False
        Me.TRTempTableAdapter.Fill(Me.DataSet1.TRTemp)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class