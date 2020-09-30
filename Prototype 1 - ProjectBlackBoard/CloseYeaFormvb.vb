Public Class CloseYearFormvb
    Public SQL As New DataBaseControl
    Public CurrentYear As Integer
    Private Sub CloseYearFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        ButtonCloseYear.Enabled = False
        Cursor.Current = Cursors.WaitCursor

        Dim good As Integer = 0
        If Today.Month > 3 Then
            CurrentYear = Today.Year - 1
        Else
            CurrentYear = Today.Year
        End If

        Dim terms = checkTermsClosed()
        If terms Then
            PictureBox1.Visible = True
            good = good + 1
            DoBalances()
            PictureBox4.Visible = True
            good = good + 1
            SettingToInActive()
            PictureBox3.Visible = True
            good = good + 1
            SetNextYearTerms()
            PictureBox2.Visible = True
            good = good + 1
            setupPoas()
            PictureBox5.Visible = True
            good = good + 1
            If good = 5 Then
                ButtonCloseYear.Enabled = True
            End If

        End If
        Cursor.Current = Cursors.Arrow
    End Sub
    Public Sub SetNextYearTerms()
        If SQL.HasConnnection = True Then
            Dim x As Integer
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            For x = 1 To 4
                SQL.RunQuery("update tblterm Set StartDate = ( Select DATEADD(yyyy,-1,startdate) from tblterm where termnumber ='" & x & "'), EndDate = ( Select DATEADD(yyyy,-1,enddate) from tblterm where termnumber ='" & x & "')   where termnumber ='" & x & "'")
            Next x
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Public Sub setupPoas()
        If SQL.HasConnnection = True Then
            Dim poaID As Integer
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select MAX(POAID) AS HighestID FROM tblPOA")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                poaID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
            End If
            SQL.SQLDataSet.Clear()

            SQL.RunQuery("SELECT subgradeId , term, year,dategiven, datedue , topic, total, passmark,weighting,CalcType,Active,Status,isSBA,TaskNo from tblPOA WHERE year = '" & CurrentYear & "'")
            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                SQL.RunQuery("SELECT subgradeId , term, year+1, DATEADD(yyyy,1,dategiven), DATEADD(yyyy,1,datedue) , topic, total, passmark,weighting,CalcType,Active,Status,isSBA,TaskNo from tblPOA")
                Dim SUbgradeID = SQL.SQLDataSet.Tables(0).Rows(x).Item("SubgradeID")
                Dim term = SQL.SQLDataSet.Tables(0).Rows(x).Item("term")
                Dim year = SQL.SQLDataSet.Tables(0).Rows(x).Item("year")
                Dim dategiven = SQL.SQLDataSet.Tables(0).Rows(x).Item("dategiven")
                Dim datedue = SQL.SQLDataSet.Tables(0).Rows(x).Item("datedue")
                Dim topic = SQL.SQLDataSet.Tables(0).Rows(x).Item("topic")
                Dim total = SQL.SQLDataSet.Tables(0).Rows(x).Item("total")
                Dim passmark = SQL.SQLDataSet.Tables(0).Rows(x).Item("Passmark")
                Dim weighting = SQL.SQLDataSet.Tables(0).Rows(x).Item("weighting")
                Dim calcType = SQL.SQLDataSet.Tables(0).Rows(x).Item("calctype")
                Dim Active = SQL.SQLDataSet.Tables(0).Rows(x).Item("Active")
                Dim Status = SQL.SQLDataSet.Tables(0).Rows(x).Item("Status")
                Dim isSBa = SQL.SQLDataSet.Tables(0).Rows(x).Item("IsSBA")
                Dim TaskNo = SQL.SQLDataSet.Tables(0).Rows(x).Item("TaskNo")
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("INSERT INTO tblPOA VALUEs('" & poaID & "','" & SUbgradeID & "','" & term & "','" & year & "','" & dategiven & "','" & datedue & "','" & topic & "','" & total & "','" & passmark & "','" & weighting & "','" & calcType & "','" & Active & "','" & Status & "','" & isSBa & "','" & TaskNo & "')")
                poaID = poaID + 1

            Next x

        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Public Sub SettingToInActive()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("UPDATE tblLearner Set LStatus = 0  And LAccount = 0")
        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Function checkTermsClosed() As Boolean
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select * FROM tblTerm")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                For x = 0 To 3
                    If (SQL.SQLDataSet.Tables(0).Rows(x).Item("Status").Equals(True)) Then

                        MessageBox.Show("Close ALL Terms First", "Error : Terms Open", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                Next x
                Return True
            End If
        Else
            MessageBox.Show("Database Not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Return False
    End Function

    Public Sub DoBalances()
        Dim AccID As Integer
        Dim ID As Integer = 0
        Dim TypeAcc As String = ""
        Dim total As Decimal = 0
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select MAX(AccountID) As HighestID FROM tblAccount")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                AccID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
            End If
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("Select learnerID,Atype, SUM(Amount) As 'Total' From tblAccount WHERE year = '" & CurrentYear & "'  group by learnerid , Atype")
            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("select learnerID,Atype, SUM(Amount) AS 'Total' From tblAccount WHERE year = '" & CurrentYear & "'  group by learnerid , Atype")
                If SQL.SQLDataSet.Tables(0).Rows(x).Item("Total").Equals(0) = False Then
                    ID = SQL.SQLDataSet.Tables(0).Rows(x).Item("LearnerID")
                    TypeAcc = SQL.SQLDataSet.Tables(0).Rows(x).Item("Atype")
                    total = SQL.SQLDataSet.Tables(0).Rows(x).Item("Total")
                    SQL.RunQuery("INSERT into tblAccount(AccountID,LearnerId, AType,TransDay,TransMonth,TransYear,Amount,RefNo,SourceDoc,TransNote,TransType) Values('" & AccID & "','" & ID & "','" & TypeAcc & "',01,02,'" & CurrentYear + 1 & "','" & total & "',NULL,NUll,'Opening Balance : " + TypeAcc + "',0)")
                    AccID = AccID + 1
                End If
                ID = 0
                TypeAcc = ""
                total = 0

            Next x
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCloseYear.Click
        MessageBox.Show(CurrentYear.ToString + " is closed", "Year Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class