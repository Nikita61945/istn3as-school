Imports System.IO

Public Class TermInfoForm
    Dim sql As New DataBaseControl

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If sql.HasConnnection Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("Insert into tblTerm (TermNumber, StartDate, EndDate, Status)VALUES('" & 1 & "','" & TermOneStartDate.Value & "','" & TermOneEndDate.Value & "','" & "1" & "')")
        sql.RunQuery("Insert into tblTerm (TermNumber, StartDate, EndDate, Status)VALUES('" & 2 & "','" & TermTwoStartDate.Value & "','" & TermTwoEndDate.Value & "','" & "1" & "')")
        sql.RunQuery("Insert into tblTerm (TermNumber, StartDate, EndDate, Status)VALUES('" & 3 & "','" & TermThreeStartDate.Value & "','" & TermThreeEndDate.Value & "','" & "1" & "')")
        sql.RunQuery("Insert into tblTerm (TermNumber, StartDate, EndDate, Status)VALUES('" & 4 & "','" & TermFourStartDate.Value & "','" & TermFourEndDate.Value & "','" & "1" & "')")


            MessageBox.Show("Data has been saved!", "Successful Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
        MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub TermNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TermNumTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TermInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        TermOneStartDate.MinDate = Date.Parse(Today.Year.ToString + "/01/01")

        TermOneStartDate.Format = DateTimePickerFormat.Custom
        TermOneStartDate.CustomFormat = "dd/MM/yyyy"
        TermOneEndDate.Format = DateTimePickerFormat.Custom
        TermOneEndDate.CustomFormat = "dd/MM/yyyy"
        If sql.HasConnnection Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("Select * from tblTerm")
        If Not (sql.SQLDataSet.Tables(0).Rows.Count = 0) Then
            TermOneStartDate.Text = sql.SQLDataSet.Tables(0).Rows(0).Item("StartDate")
            TermOneEndDate.Text = sql.SQLDataSet.Tables(0).Rows(0).Item("EndDate")
            TermTwoStartDate.Text = sql.SQLDataSet.Tables(0).Rows(1).Item("StartDate")
            TermTwoEndDate.Text = sql.SQLDataSet.Tables(0).Rows(1).Item("EndDate")
            TermThreeStartDate.Text = sql.SQLDataSet.Tables(0).Rows(2).Item("StartDate")
            TermThreeEndDate.Text = sql.SQLDataSet.Tables(0).Rows(2).Item("EndDate")
            TermFourStartDate.Text = sql.SQLDataSet.Tables(0).Rows(3).Item("StartDate")
            TermFourEndDate.Text = sql.SQLDataSet.Tables(0).Rows(3).Item("EndDate")

            TermOneStartDate.Enabled = False
            TermOneEndDate.Enabled = False
            TermTwoStartDate.Enabled = False
            TermTwoEndDate.Enabled = False
            TermThreeStartDate.Enabled = False
            TermThreeEndDate.Enabled = False
            TermFourStartDate.Enabled = False
            TermFourEndDate.Enabled = False
        End If
        Else
        MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        TermOneStartDate.Enabled = True
        TermOneEndDate.Enabled = True
        TermTwoStartDate.Enabled = True
        TermTwoEndDate.Enabled = True
        TermThreeStartDate.Enabled = True
        TermThreeEndDate.Enabled = True
        TermFourStartDate.Enabled = True
        TermFourEndDate.Enabled = True

    End Sub


    Private Sub TermOneStartDate_ValueChanged(sender As Object, e As EventArgs) Handles TermOneStartDate.ValueChanged
        TermOneEndDate.MinDate = TermOneStartDate.Value.AddDays(60)
    End Sub

    Private Sub TermOneEndDate_ValueChanged(sender As Object, e As EventArgs) Handles TermOneEndDate.ValueChanged
        TermTwoStartDate.MinDate = TermOneEndDate.Value.AddDays(10)

    End Sub

    Private Sub TermTwoStartDate_ValueChanged(sender As Object, e As EventArgs) Handles TermTwoStartDate.ValueChanged
        TermTwoEndDate.MinDate = TermTwoStartDate.Value.AddDays(60)
    End Sub

    Private Sub TermTwoEndDate_ValueChanged(sender As Object, e As EventArgs) Handles TermTwoEndDate.ValueChanged
        TermThreeStartDate.MinDate = TermTwoEndDate.Value.AddDays(20)
    End Sub

    Private Sub TermThreeStartDate_ValueChanged(sender As Object, e As EventArgs) Handles TermThreeStartDate.ValueChanged
        TermThreeEndDate.MinDate = TermThreeStartDate.Value.AddDays(60)
    End Sub

    Private Sub TermThreeEndDate_ValueChanged(sender As Object, e As EventArgs) Handles TermThreeEndDate.ValueChanged
        TermFourStartDate.MinDate = TermThreeEndDate.Value.AddDays(10)
    End Sub

    Private Sub TermFourStartDate_ValueChanged(sender As Object, e As EventArgs) Handles TermFourStartDate.ValueChanged
        TermFourEndDate.MinDate = TermFourStartDate.Value.AddDays(60)
    End Sub
End Class