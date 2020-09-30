Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class AddTutor
    Public SQL As New DataBaseControl

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Mesg As String = ""
        Dim ID As Integer = 2000
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select MAX(TutorID) AS HighestID FROM tblTutor")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
            End If
            SQL.SQLDataSet.Clear()

            If ((Form1.isFieldBlank(NameTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SurnameTextBox.Text) = False) AndAlso (Form1.isFieldBlank(TelNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(CellNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(IDNumTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SACETextBox.Text) = False) AndAlso (Form1.isFieldBlank(EmailTextBox.Text) = False) AndAlso (Form1.isFieldBlank(QualTextBox.Text) = False) AndAlso (Form1.isFieldBlank(SalaryTextBox.Text) = False)) Then
                If PayComboBox.SelectedIndex = -1 Then
                    Mesg = Mesg + "Payment Style must be selected" + Environment.NewLine
                End If

                If (TelNumTextBox.Text.Length.Equals(10) = False) Then
                    Mesg = Mesg + "Telephone Number is Invalid : Lenght must equal to ten " + Environment.NewLine
                    TelNumTextBox.Clear()

                ElseIf (IsNumeric(TelNumTextBox.Text) = False) Then
                    Mesg = Mesg + "Telephone Number is Invalid : Number must on be Digits " + Environment.NewLine
                    TelNumTextBox.Clear()
                ElseIf (TelNumTextBox.Text(0).ToString.Equals("0") = False) Then
                    Mesg = Mesg + "Telephone Number is Invalid : Number must start with a 0 " + Environment.NewLine
                    TelNumTextBox.Clear()

                End If


                If (CellNumTextBox.Text.Length.Equals(10) = False) Then
                    Mesg = Mesg + "Cell Phone Number is Invalid : Lenght must equal to ten" + Environment.NewLine
                    CellNumTextBox.Clear()
                ElseIf (IsNumeric(CellNumTextBox.Text) = False) Then
                    Mesg = Mesg + "Cell Phone Number is Invalid : Number must on be Digits" + Environment.NewLine
                    CellNumTextBox.Clear()

                ElseIf (CellNumTextBox.Text(0).ToString.Equals("0") = False) Then
                    Mesg = Mesg + "Cell Phone Number is Invalid : Number must start with a 0 " + Environment.NewLine
                    CellNumTextBox.Clear()

                End If

                If ((IDNumTextBox.Text.Length.Equals(13) = False) OrElse (IsNumeric(IDNumTextBox.Text) = False)) Then
                    Mesg = Mesg + "ID Number is Invalid " + Environment.NewLine
                    IDNumTextBox.Clear()
                End If

                If (IsNumeric(SACETextBox.Text) = False) Then
                    Mesg = Mesg + "SACE Number is Invalid" + Environment.NewLine
                    SACETextBox.Clear()
                End If

                If EmailTextBox.Text.Contains("@") = False Then
                    Mesg = Mesg + "Email Address is Invalid : must contain @ " + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.Contains(".") = False Then
                    Mesg = Mesg + "Email Address is Invalid : must contain . " + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.IndexOf("@") = 0 Then
                    Mesg = Mesg + "Email Address is Invalid : @ cannot be first character" + Environment.NewLine
                    EmailTextBox.Clear()
                ElseIf EmailTextBox.Text.IndexOf(".") > EmailTextBox.Text.Length - 2 Then
                    Mesg = Mesg + "Email Address is Invalid " + Environment.NewLine
                    EmailTextBox.Clear()
                End If

                If (IsNumeric(SalaryTextBox.Text) = False) Then
                    Mesg = Mesg + "Salary is must be numeric and not equal to zero" + Environment.NewLine
                    SalaryTextBox.Clear()
                End If



            Else
                Mesg = Mesg + "Fields cannot be blank : Please fill in all relevant Fields" + Environment.NewLine
            End If



            If Mesg = "" Then
                SQL.RunQuery("INSERT INTO tblTutor(TutorID,SACENo,FName,Surname,TellNo,CellNo,IDNo,Email,Qualification,PaymentStyle,Salary,Active) VALUES('" & ID & "','" & SACETextBox.Text & "','" & NameTextBox.Text & "','" & SurnameTextBox.Text & "','" & TelNumTextBox.Text & "','" & CellNumTextBox.Text & "','" & IDNumTextBox.Text & "','" & EmailTextBox.Text & "','" & QualTextBox.Text & "','" & PayComboBox.SelectedItem.ToString & "','" & Decimal.Parse(SalaryTextBox.Text) & "','" & 1 & "')")
                Cursor.Current = Cursors.Arrow
                If MessageBox.Show("Tutor Data Added. Do you wish to add another Tutor ?", "Confirmation of Tutor Added ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    NameTextBox.Clear()
                    SurnameTextBox.Clear()
                    TelNumTextBox.Clear()
                    CellNumTextBox.Clear()
                    EmailTextBox.Clear()
                    QualTextBox.Clear()
                    IDNumTextBox.Clear()
                    SACETextBox.Clear()
                    SalaryTextBox.Clear()
                    PayComboBox.SelectedIndex = -1
                Else
                    Me.Close()
                    Form1.Show()
                End If
            Else
                MessageBox.Show(Mesg, "Errors in form", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Mesg = ""
                Cursor.Current = Cursors.Arrow
            End If

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If NameTextBox.Text IsNot Nothing Then
            If MessageBox.Show("Canceling will result in loss of data. Do you still wish to cancel? ", "Canceling of Data Caputure ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
                Cursor.Current = Cursors.WaitCursor
                Form1.Show()
                SalaryTextBox.Clear()
                NameTextBox.Clear()
                SurnameTextBox.Clear()
                CellNumTextBox.Clear()
                TelNumTextBox.Clear()
                IDNumTextBox.Clear()
                SACETextBox.Clear()
                EmailTextBox.Clear()
                QualTextBox.Clear()
                PayComboBox.SelectedIndex = -1
                Cursor.Current = Cursors.Arrow
            End If
        Else
            Me.Close()
            Form1.Show()
        End If

    End Sub



    Private Sub AddTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.MdiParent = Form1
        SalaryTextBox.Clear()
        NameTextBox.Clear()
        SurnameTextBox.Clear()
        CellNumTextBox.Clear()
        TelNumTextBox.Clear()
        IDNumTextBox.Clear()
        SACETextBox.Clear()
        EmailTextBox.Clear()
        QualTextBox.Clear()
        PayComboBox.SelectedIndex = -1
        Cursor.Current = Cursors.Arrow
    End Sub
End Class