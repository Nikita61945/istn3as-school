Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditTutor
    Public SQL As New DataBaseControl
    Private Sub ViewTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewTutor.Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If NameTextBox.Text IsNot Nothing Then
            If MessageBox.Show("Canceling will result in loss of data. Do you still wish to cancel? ", "Canceling od Data Caputure ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Hide()
                ViewTutor.Show()
            End If
        Else
            Me.Hide()
            ViewTutor.Show()
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim mesg As String = ""

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            If ((Form1.isFieldBlank(NameTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SurnameTextBox.Text) = False) AndAlso (Form1.isFieldBlank(TelNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(CellNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(IDNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SACETextBox.Text) = False) AndAlso (Form1.isFieldBlank(EmailTextBox.Text) = False) AndAlso (Form1.isFieldBlank(QualTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SalaryTextBox.Text) = False)) Then
                If PayComboBox.SelectedIndex = -1 Then
                    mesg = mesg + "Payment Style must be selected" + Environment.NewLine
                End If

                If (TelNumTextBox.Text.Length.Equals(10) = False) Then
                    mesg = mesg + "Telephone Number is Invalid : Lenght must equal to ten " + Environment.NewLine
                    TelNumTextBox.Clear()

                ElseIf (IsNumeric(TelNumTextBox.Text) = False) Then
                    mesg = mesg + "Telephone Number is Invalid : Number must on be Digits " + Environment.NewLine
                    TelNumTextBox.Clear()
                ElseIf (TelNumTextBox.Text(0).ToString.Equals("0") = False) Then
                    mesg = mesg + "Telephone Number is Invalid : Number must start with a 0 " + Environment.NewLine
                    TelNumTextBox.Clear()

                End If


                If (CellNumTextBox.Text.Length.Equals(10) = False) Then
                    mesg = mesg + "Cell Phone Number is Invalid : Lenght must equal to ten" + Environment.NewLine
                    CellNumTextBox.Clear()
                ElseIf (IsNumeric(CellNumTextBox.Text) = False) Then
                    mesg = mesg + "Cell Phone Number is Invalid : Number must on be Digits" + Environment.NewLine
                    CellNumTextBox.Clear()

                ElseIf (CellNumTextBox.Text(0).ToString.Equals("0") = False) Then
                    mesg = mesg + "Cell Phone Number is Invalid : Number must start with a 0 " + Environment.NewLine
                    CellNumTextBox.Clear()

                End If

                If ((IDNumTextBox.Text.Length.Equals(13) = False) OrElse (IsNumeric(IDNumTextBox.Text) = False)) Then
                    mesg = mesg + "ID Number is Invalid " + Environment.NewLine
                    IDNumTextBox.Clear()
                End If

                If (IsNumeric(SACETextBox.Text) = False) Then
                    mesg = mesg + "SACE Number is Invalid" + Environment.NewLine
                    SACETextBox.Clear()
                End If

                If EmailTextBox.Text.Contains("@") = False Then
                    mesg = mesg + "Email Address is Invalid : must contain @ " + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.Contains(".") = False Then
                    mesg = mesg + "Email Address is Invalid : must contain . " + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.IndexOf("@") = 0 Then
                    mesg = mesg + "Email Address is Invalid : @ cannot be first character" + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.IndexOf(".") > EmailTextBox.Text.Length - 2 Then
                    mesg = mesg + "Email Address is Invalid " + Environment.NewLine
                    EmailTextBox.Clear()
                End If

                If (IsNumeric(SalaryTextBox.Text) = False) Then
                    mesg = mesg + "Salary is must be numeric and not equal to zero" + Environment.NewLine
                    SalaryTextBox.Clear()
                End If



            Else
                mesg = mesg + "Fields cannot be blank : Please fill in all relevant Fields" + Environment.NewLine
            End If



            If mesg = "" Then

                SQL.RunQuery("UPDATE tblTutor SET SACENo = '" & SACETextBox.Text & "',Surname ='" & SurnameTextBox.Text & "',TellNo = '" & TelNumTextBox.Text & "',CellNo ='" & CellNumTextBox.Text & "',Email ='" & EmailTextBox.Text & "',Qualification ='" & QualTextBox.Text & "',PaymentStyle = '" & PayComboBox.SelectedItem.ToString & "', Salary = '" & Decimal.Parse(SalaryTextBox.Text) & "',Active = '" & ActiveCheckBox.Checked & "' WHERE TutorID = '" & Integer.Parse(ViewTutor.ID) & "'")

                MessageBox.Show("Tutor Data Updated.", "Confirmation of Tutor Added ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                ViewTutor.Show()

            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show(mesg, "Errors in form", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Else
        MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class