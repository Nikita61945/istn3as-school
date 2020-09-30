Public Class TransferOutForm
    Dim SQL As New DataBaseControl
    Dim GradeID As Integer
    Dim LName As String
    Dim learnerID As Integer
    Dim LearnerBalance As Double = 0
    Dim numOfActiveTerms = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MessageBox.Show("Are you sure you want to de-activate this learner ?", "Confirmation of Learner Transfer ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If SQL.HasConnnection = True Then

                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("Select Amount From tblAccount Where (learnerID ='" & learnerID & "')")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    Dim y As Integer = 0
                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                        LearnerBalance = LearnerBalance + SQL.SQLDataSet.Tables(0).Rows(y).Item("Amount")
                        y = y + 1
                    Next x
                End If
                If (numOfActiveTerms = 0) Then
                    SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & False & "',TermOne = '" & 0 & "',TermTwo = '" & 0 & "',TermThree = '" & 0 & "',TermFour = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                End If
                If (numOfActiveTerms = 1) Then
                    SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & False & "',TermTwo = '" & 0 & "',TermThree = '" & 0 & "',TermFour = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                End If
                If (numOfActiveTerms = 2) Then
                    SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & False & "',TermThree = '" & 0 & "',TermFour = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                End If
                If (numOfActiveTerms = 3) Then
                    SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & False & "',TermFour = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                End If
                If (numOfActiveTerms = 4) Then
                    SQL.RunQuery("UPDATE tblEnrolment SET Active = '" & False & "' WHERE LearnerID = '" & learnerID & "'")
                End If
                If LearnerBalance > 0 Then
                    SQL.RunQuery("UPDATE tblLearner SET LStatus = '" & False & "' WHERE LearnerID = '" & learnerID & "'")
                    MessageBox.Show("Learner trannsfered out. Amount owing = R" + LearnerBalance.ToString)
                ElseIf LearnerBalance = 0 Then
                    SQL.RunQuery("UPDATE tblLearner SET LStatus = '" & False & "',LAccount = '" & 0 & "' WHERE LearnerID = '" & learnerID & "'")
                    MessageBox.Show("Learner has been transferred out and their account has no balance!")
                End If
            End If
        End If
    End Sub
    Public Sub populateGradeComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID, convert(varChar(6),GradeID) FROM tblGrade WHERE isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
            GradeComboBox.ValueMember = "GradeID"
        End If
    End Sub
    Public Sub populateNameComboBox()
        If sql.HasConnnection = True Then

            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblLearner.LearnerID, tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "' AND tblLearner.LStatus = '" & 1 & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    Dim nameAndID As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString
                    NameComboBox.Items.Add(nameAndID)
                    y = y + 1
                Next x
            End If
            NameComboBox.ValueMember = "LName"
        End If
    End Sub

    Private Sub TransferOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        populateGradeComboBox()
        checkTerm()
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
        NameComboBox.Items.Clear()
        populateNameComboBox()
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

        learnerID = Integer.Parse(NameComboBox.SelectedItem.ToString.Substring(0, NameComboBox.SelectedItem.ToString.IndexOf(" ")))

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Public Sub checkTerm()
        numOfActiveTerms = 0
        If SQL.HasConnnection = True Then

            SQL.RunQuery("Select * from tblTerm")

            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = False) Then
                        numOfActiveTerms = numOfActiveTerms + 1
                    End If
                    y = y + 1
                Next x
            End If

        End If
    End Sub
End Class