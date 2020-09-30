Public Class ArrearsListings
    Public sql As New DataBaseControl
    Private Sub ArrearsListings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sql.HasConnnection = True Then
            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If
            Sql.RunQuery("SELECT COUNT( * ) As 'Total' FROM information_schema.tables WHERE table_name = 'tblArrear'")
            If Sql.SQLDataSet.Tables(0).Rows(0).Item("Total") > 0 Then
                Sql.RunQuery("DROP TABLE tblarrear")
            End If

            Sql.RunQuery("CREATE table tblArrear(Learnerid int,Learner varchar(75), AmountOverDue decimal(18,2),CurrentDue decimal(18,2) default 0.00)")

            Sql.RunQuery("INsERT into tblArrear(learnerID,Learner) SELECT tblAccount.LearnerID, tblLearner.lName + ' '+ tblLearner.lSurName AS 'Learner'  FROm tblLearner,tblAccount WHERE tblLearner.learnerid = tblaccount.learnerid  GRoup by tblaccount.learnerID ,  tblLearner.lName ,tblLearner.lSurName")
            Sql.RunQuery("Select LearnerID, SUM(Amount) As 'currentBal' From tblAccount Where TransMonth <= Month(GETDATE()) - 1 Group By LearnerID")
            For x = 0 To Sql.SQLDataSet.Tables(0).Rows.Count - 1

                If Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal") > 0 Then

                    Dim bal = Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal")
                    Dim id = Sql.SQLDataSet.Tables(0).Rows(x).Item("LearnerID")
                    Sql.RunQuery("UPDATE tblArrear SET AmountOVerDue ='" & Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal") & "' WHERE LearnerID ='" & id & "'")
                End If
                sql.RunQuery("Select LearnerID, SUM(Amount) As 'currentBal' From tblAccount Where TransMonth <= Month(GETDATE()) - 1 Group By LearnerID")
            Next x

            Sql.RunQuery("Select LearnerID, SUM(Amount) As currentBal From tblAccount Where (TransMonth = Month(GETDATE())) Group By LearnerID")
            For x = 0 To Sql.SQLDataSet.Tables(0).Rows.Count - 1
                If Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal") > 0 Then
                    Dim bal = Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal")
                    Dim id = Sql.SQLDataSet.Tables(0).Rows(x).Item("LearnerID")
                    Sql.RunQuery("UPDATE tblArrear SET CurrentDue ='" & Sql.SQLDataSet.Tables(0).Rows(x).Item("currentbal") & "' WHERE LearnerID ='" & id & "'")
                End If
                Sql.RunQuery("Select LearnerID, SUM(Amount) As currentBal From tblAccount Where (TransMonth = Month(GETDATE())) Group By LearnerID")
            Next x
        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class