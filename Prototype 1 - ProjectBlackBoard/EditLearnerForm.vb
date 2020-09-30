Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditLearnerForm
    Public SQL As New DataBaseControl
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim msg As String = vbNullString
        If MessageBox.Show("Are you sure you want to update these details ?", "Confirmation of Update ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If (isFieldBlank(NameTextBox.Text) = False) And (isFieldBlank(SurnameTextBox.Text) = False) And (IDNoTextBox.Text.Length = 13) And (isFieldBlank(StreetAdTextBox.Text) = False) And (isFieldBlank(CityTextBox.Text) = False) And (isFieldBlank(PCodeTextBox.Text) = False) And (GenderComboBox.SelectedIndex <> -1) And (((isFieldBlank(P1NameTextBox.Text) = False) And ((P1CellNoTextBox.Text.Length = 10) And (P1CellNoTextBox.Text.StartsWith("0"))) And (checkEmail(P1EmailTextBox.Text)) And (isFieldBlank(P2NameTextBox.Text) = False) And ((P2CellNoTextBox.Text.Length = 10) And (P2CellNoTextBox.Text.StartsWith("0"))) And (checkEmail(P2EmailTextBox.Text))) Or ((isFieldBlank(P1NameTextBox.Text) = False) And ((P1CellNoTextBox.Text.Length = 10) And (P1CellNoTextBox.Text.StartsWith("0"))) And (checkEmail(P1EmailTextBox.Text)))) Then
                If SQL.HasConnnection = True Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    Dim ID As Integer = Integer.Parse(ViewLearner.ID.ToString)
                    Dim gender As String = (GenderComboBox.SelectedItem).ToString

                    SQL.RunQuery("UPDATE tblLearner SET IDNo = '" & IDNoTextBox.Text & "', ExamNo = '" & ExamNoTextBox.Text & "', LName = '" & NameTextBox.Text & "', LSurname = '" & SurnameTextBox.Text & "', LStreetAdd = '" & StreetAdTextBox.Text & "', LSuburb = '" & SuburbTextBox.Text & "', LCity = '" & CityTextBox.Text & "', LPCode = '" & PCodeTextBox.Text & "', LGender = '" & gender & "', POneName = '" & P1NameTextBox.Text & "', POneNo = '" & P1CellNoTextBox.Text & "', POneEmail = '" & P1EmailTextBox.Text & "', PTwoName = '" & P2NameTextBox.Text & "', PTwoNo = '" & P2CellNoTextBox.Text & "', PTwoEmail = '" & P2EmailTextBox.Text & "' WHERE LearnerID = '" & ID & "'")

                    SQL.RunQuery("UPDATE tblLearnerGrade SET AccademicYear = '" & 2019 & "' WHERE LearnerID = '" & ID & "'")

                    MessageBox.Show("Learner Data Updated.", "Confirmation of Learner Updated ", MessageBoxButtons.OK)
                    Me.Close()
                    ViewLearner.Show()
                End If
            Else
                If (NameTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners name."
                End If

                If (SurnameTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners surname."
                End If

                If Not (IDNoTextBox.Text.Length = 13) Then
                    msg = msg + vbNewLine + "Please enter a 13 digit identity number."
                End If

                If (ExamNoTextBox.Text.Length > 0) Then
                    If ((Not (ExamNoTextBox.Text.Length = 13))) Then
                        msg = msg + vbNewLine + "Please enter a 13 digit exam number."
                    End If
                End If

                If Not (GenderComboBox.SelectedIndex <> -1) Then
                    msg = msg + vbNewLine + "Select the appropriate gender of the learner from the combo box."
                End If

                If (StreetAdTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners street address."
                End If

                If (SuburbTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners suburb."
                End If
                If (CityTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the city the learner stays in."
                End If

                If (PCodeTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners postal code."
                End If
                If (P1NameTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the first parents name."
                End If

                If Not (P1CellNoTextBox.Text.Length = 10) Then
                    msg = msg + vbNewLine + "Please enter the first parents 10 digit cell number."
                End If

                If checkEmail(P1EmailTextBox.Text) = False Then
                    msg = msg + vbNewLine + "Please enter a valid email address for the first parent."
                End If

                If (P2NameTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "Please enter the learners seconf parents name."
                End If

                If Not (P2CellNoTextBox.Text.Length = 10) Then
                    msg = msg + vbNewLine + "Please enter the second parents 10 digit cell number."
                End If
                If checkEmail(P2EmailTextBox.Text) = False Then
                    msg = msg + vbNewLine + "Please enter a valid email address for the second parent."

                End If

                If Not (P1CellNoTextBox.Text.Length = 0) Then

                    If Not (Integer.Parse(P1CellNoTextBox.Text.ToString.Substring(0, 1)) = 0) Then
                        msg = msg + vbNewLine + "Invalid parent one cell number. Cell number does not begin with 0."
                    End If
                End If
                If Not (P2CellNoTextBox.Text.Length = 0) Then
                    If Not (Integer.Parse(P2CellNoTextBox.Text.ToString.Substring(0, 1)) = 0) Then
                        msg = msg + vbNewLine + "Invalid parent two cell number. Cell number does not begin with 0."
                    End If
                End If

                MessageBox.Show("You are missing the following details : " + msg, " Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        SQL.RunQuery("Select tblLearner.LearnerID As [Learner ID], IDNo As [Identity Number], ExamNo As [Exam Number], LName As [Learner Name], LSurname As [Learner Surname], tblLearnerGrade.GRADEID As [Grade], LStatus As [Learner Status], LStreetAdd As [Street Address], LSuburb As [Suburb], LCity As [City], LPCode As [Postal Code], LGender As [Gender], POneName As [Parent One], POneNo As [Parent One Cell Number], PTwoName As [Parent Two Name], PTwoNo As [Parent Two Cell Number], PTwoEmail As [Parent Two Email], POneEmail As [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade On tblLearner.LearnerID = tblLearnerGrade.LearnerID)")
        ViewLearner.GetLearners()
    End Sub
    Private Sub IDNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ExamNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExamNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PCodeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PCodeTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub P1CellNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P1CellNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub P2CellNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P2CellNoTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Function checkEmail(ByVal str As String) As Boolean
        Dim tf = True
        If Not str.Contains("@") And Not str.Contains(".") And str.Length > 30 Then
            tf = False
        End If
        Return tf
    End Function

    Public Function isFieldBlank(ByVal CheckField As String)
        If CheckField.Length = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        ViewLearner.Show()
    End Sub

    Private Sub EditLearnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub P2EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles P2EmailTextBox.TextChanged

    End Sub
End Class