Imports System.IO

Public Class GeInfoForm


    Private Sub GeInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dir("GeneralInfo.txt") <> "" Then
            Dim reader As New System.IO.StreamReader("GeneralInfo.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            NameTextBox.Text = ReadLine(1, allLines)
            AddTextBox1.Text = ReadLine(2, allLines)
            AddTextBox2.Text = ReadLine(3, allLines)
            AddTextBox3.Text = ReadLine(4, allLines)
            AddTextBox4.Text = ReadLine(5, allLines)
            TeleTextBox.Text = ReadLine(6, allLines)
            CellTextBox.Text = ReadLine(7, allLines)
            EmailTextBox.Text = ReadLine(8, allLines)
            WebsiteTextBox.Text = ReadLine(9, allLines)
        Else
            MsgBox("Please enter in data. Thank You", MsgBoxStyle.Information, "Data Entry Required")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show("Are you sure you want to close this form? Any new information captured will be lost", "Co0nfirmation on Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If (isFieldBlank(NameTextBox.Text) = False) And (isFieldBlank(AddTextBox1.Text) = False) And (isFieldBlank(AddTextBox2.Text) = False) And (isFieldBlank(AddTextBox3.Text) = False) And (isFieldBlank(AddTextBox4.Text) = False) And (TeleTextBox.Text.Length = 10) And (CellTextBox.Text.Length = 10) And (TeleTextBox.Text.StartsWith("0")) And (CellTextBox.Text.StartsWith("0")) And (checkEmail(EmailTextBox.Text)) And (checkWebsite(WebsiteTextBox.Text)) Then
            Dim FileWriter As StreamWriter
            FileWriter = New StreamWriter("GeneralInfo.txt", True)
            FileWriter.WriteLine(NameTextBox.Text)
            FileWriter.WriteLine(AddTextBox1.Text)
            FileWriter.WriteLine(AddTextBox2.Text)
            FileWriter.WriteLine(AddTextBox3.Text)
            FileWriter.WriteLine(AddTextBox4.Text)
            FileWriter.WriteLine(TeleTextBox.Text)
            FileWriter.WriteLine(CellTextBox.Text)
            FileWriter.WriteLine(EmailTextBox.Text)
            FileWriter.WriteLine(WebsiteTextBox.Text)
            FileWriter.Close()
            MsgBox("Data has been saved!", MsgBoxStyle.Exclamation, "Successful Save")
        Else
            MsgBox("Please enter all details.", MsgBoxStyle.Information, "Incomplete Data")
        End If
    End Sub

    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function

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


    Private Function checkWebsite(ByVal str As String) As Boolean
        Dim value = False
        If (str.Contains(".com")) Or (str.Contains("co.za")) Then
            value = True
        End If
        Return value
    End Function

    Private Sub TeleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TeleTextBox.TextChanged

    End Sub

    Private Sub TeleTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TeleTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub



    Private Sub AddTextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddTextBox4.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class