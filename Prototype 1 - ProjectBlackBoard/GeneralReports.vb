Public Class GeneralReports
    Public sql As New DataBaseControl

    Private Sub GeneralReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sql.HasConnnection = True Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If
            sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblOutBal'")
            If sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                sql.RunQuery("DROP TABLE tbloutbal")

            End If

            sql.RunQuery("CREATE table tblOutBal(Learnerid int,Learner varchar(75), TotalFees decimal(18,2),AmountPaid decimal(18,2) default 0.00)")

            sql.RunQuery("INsERT into tbloutbal(learnerID,Learner,TotalFees) SELECT tblAccount.LearnerID, tblLearner.lName + ' '+ tblLearner.lSurName AS 'Learner' , Sum(tblAccount.amount) AS 'Total Fees'  FROm tblLearner,tblAccount WHERE tblLearner.learnerid = tblaccount.learnerid AND TRansType in (0,1,2,3) GRoup by tblaccount.learnerID ,  tblLearner.lName ,tblLearner.lSurName")

            sql.RunQuery("UPDATE tbloutbal set tbloutbal.AmountPaid = (SELECT SUM(AMOUNT) from tblaccount where tblAccount.Learnerid = tbloutbal.learnerid and transtype = 4 group by tblaccount.learnerid )")
            sql.RunQuery("UPDATE tbloutbal set tbloutbal.AmountPaid = 0 where tbloutbal.AmountPaid IS NULL")
        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class