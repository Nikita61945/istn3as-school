Public Class EditPOA
    Public SQL As New DataBaseControl
    Dim Mesgs As String = " "

    Private Sub EditPOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YearText.Text = Date.Today.Year.ToString

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
        End If
    End Sub

    Public Sub checkTerm() 'Bloop
        If (Integer.Parse(termsCmb.SelectedIndex) = 0) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 1")
            DateGive.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 1")
            DateDuetxt.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termsCmb.SelectedIndex) = 1) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 2")
            DateGive.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 2")
            DateDuetxt.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termsCmb.SelectedIndex) = 2) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 3")
            DateGive.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 3")
            DateDuetxt.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        ElseIf (Integer.Parse(termsCmb.SelectedIndex) = 3) Then
            SQL.RunQuery("Select StartDate from tblTerm where TermNumber = 4")
            DateGive.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("StartDate")

            SQL.RunQuery("Select EndDate from tblTerm where TermNumber = 4")
            DateDuetxt.Value = SQL.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Mesgs = vbNullString
        If IsNumeric(PassMarkText.Text) = False Or (PassMarkText.Text.Length = 0) Or (Decimal.Parse(PassMarkText.Text)) > (Decimal.Parse(TotalText.Text)) Then
            Mesgs += ("Invalid passmark, please re-enter") + Environment.NewLine
            PassMarkText.Clear()
        End If



        If IsNumeric(WeightingText.Text) = False Or (WeightingText.Text) = " " Then
                If (WeightingText.Text > 100) Then
                    Mesgs += ("Invalid weighting, please enter a valid numeric value") + Environment.NewLine
                    WeightingText.Clear()
                End If
            End If

            If CalCmb.SelectedIndex = -1 Then
                Mesgs += ("No calculation has been selected, please select a calculation") + Environment.NewLine
                CalCmb.SelectedIndex = -1
            End If

        If termsCmb.SelectedIndex = -1 Then
            Mesgs += ("No term has been selected, please select a term") + Environment.NewLine
            termsCmb.SelectedIndex = -1
        End If

        If DateDuetxt.Value < DateGive.Value Or (DateDuetxt.Value.Year < Date.Today.Year Or DateDuetxt.Value.Year > Date.Today.Year) Then
            Mesgs += ("Invalid due date, please enter a valid numeric value") + Environment.NewLine
            'DateDuetxt.Focus()
        End If

        If DateGive.Value.Year < Date.Today.Year Then
            Mesgs += ("Invalid date given, please enter a valid numeric value") + Environment.NewLine
            'DateGive.Focus()

        End If

        If Mesgs = vbNullString Then

            Dim SubGrade As String = txtGrade.Text
            Dim TermN As Integer = Integer.Parse(termsCmb.SelectedItem)
            Dim YearN As Integer = Integer.Parse(YearText.Text)
            Dim Give As Date = DateTime.Parse(DateGive.Value)
            Dim DueD As Date = DateTime.Parse(DateDuetxt.Value)
            Dim TopicTitle As String = TopicText.Text
            Dim TotalN As Decimal = Decimal.Parse(TotalText.Text)
            Dim TaskN As Integer = Integer.Parse(txtTask.Text)
            Dim PMark As Decimal = Decimal.Parse(PassMarkText.Text.ToString) 'Chooth error
            Dim WeightingS As Decimal = Decimal.Parse(WeightingText.Text.ToString)
            Dim CalculationT As String = CalCmb.SelectedItem.ToString

            Dim ActiveB As Integer
            If chkActive.Checked = True Then
                ActiveB = 1
            Else
                ActiveB = 0
            End If

            Dim SBA As Integer
            If chkSBA.Checked = True Then
                SBA = 1
            Else
                SBA = 0
            End If


            SQL.RunQuery("SELECT Status FROM tblPOA WHERE POAID='" & Integer.Parse(PoaIDText.Text) & "'")
            Dim Status As String = (SQL.SQLDataSet.Tables(0).Rows(0).Item("Status")).ToString

            SQL.RunQuery("UPDATE tblPOA SET SubGradeID='" & SubGrade & "', Term='" & TermN & "', Year='" & YearN & "', DateGiven='" & Give & "', DateDue='" & DueD & "', Topic='" & TopicTitle & "', Total='" & TotalN & "', PassMark='" & PMark & "', Weighting='" & WeightingS & "', CalcType='" & CalculationT & "', Active='" & ActiveB & "', Status='" & Status & "', isSBA='" & SBA & "', TaskNo= '" & TaskN & "' WHERE POAID='" & Integer.Parse(PoaIDText.Text) & "'")
            MessageBox.Show("POA has been updated", "Updated POA", MessageBoxButtons.OK)
            Me.Hide()
            ViewPOA.Show()
        Else
            MessageBox.Show(Mesgs, "Errors in form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (MessageBox.Show("POA will not be updated. Are you sure?", "Exit Update", MessageBoxButtons.YesNo)) = DialogResult.Yes Then
            Me.Close()
            ViewPOA.Show()
        End If
    End Sub

    Private Sub termsCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles termsCmb.SelectedIndexChanged
        If termsCmb.SelectedIndex > -1 Then
            checkTerm()
        End If
    End Sub
End Class