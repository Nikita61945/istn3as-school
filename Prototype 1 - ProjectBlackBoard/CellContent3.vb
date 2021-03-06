﻿Public Class CellContent3
    Public cellContent As String = EditTimeTable.cellCont
    Public rowIndex As Integer = EditTimeTable.rowIndex
    Public colIndex As Integer = EditTimeTable.rowIndex
    Public panelHeading As String = EditTimeTable.panelHeading
    Public day As String = EditTimeTable.Editday
    Public period As String = EditTimeTable.period
    Public grade As Integer = EditTimeTable.EditGrade
    Private SQL As New DataBaseControl
    Dim sender As Object
    Dim btn As Button = CType(sender, Button)
    Dim btnName As String
    Dim cords As New Point
    Dim allButtons As ArrayList = New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseName.Click

        If MessageBox.Show("If you leave now all data will be lost." + vbNewLine + "Do you want to save changes you have made?", "Unsaved Data", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            EditTimeTable.CreateTT.Rows(EditTimeTable.rowIndex).Cells(EditTimeTable.colIndex).Value = cellContent
        End If
        Me.Close()
    End Sub
    Private Sub createButton(btnLabel As String, y As Integer)

        btn = New Button
        btn.Text = btnLabel
        btn.Name = btnLabel
        btn.Width = 170
        btn.Height = 50
        btn.Left = 5
        btn.Top = 5
        btn.Location = New Point(y, 18)
        btn.BackColor = Color.LightBlue
        btn.BringToFront()

        Me.Controls.Add(btn)
        Me.panel.Controls.Add(btn)

        AddHandler btn.MouseDown, AddressOf btnMouseDown
        AddHandler btn.MouseUp, AddressOf btnMouseUp
    End Sub

    Private Sub btnMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        cords.Y = MousePosition.Y - sender.top
        cords.X = MousePosition.X - sender.left
        Dim btn As Button = TryCast(sender, Button)
        Dim newStuff As String = " "

        If MessageBox.Show("Are you sure you want to remove " + vbNewLine + vbNewLine + btn.Name.Trim + " ?", "Remove Subject", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            SQL.RunQuery("DELETE FROM AssignRooms WHERE (Grade = '" & grade & "') and Period = '" & period & "' and Day = '" & day & "'")

            Me.Controls.Remove(btn)
            Me.panel.Controls.Remove(btn)

            For i As Integer = 0 To panel.Controls.Count - 1
                If (i = 0) Then
                    newStuff = panel.Controls.Item(i).Name.ToString
                Else
                    newStuff = newStuff + vbNewLine + "|" + vbNewLine + panel.Controls.Item(i).Name.ToString
                End If
            Next

            panel.Controls.Clear()
            cellContent = newStuff
            If Not (newStuff = " ") Then
                GenerateButtons()

            End If
        End If

    End Sub
    Private Sub btnMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim btn As Button = TryCast(sender, Button)
        btn.BackColor = Color.LightBlue
    End Sub
    Public Sub GenerateButtons()
        Dim subInd As ArrayList = New ArrayList

        Dim startIndex As Integer = 0

        For i As Integer = 0 To cellContent.Length - 1

            If (cellContent.Substring(i, 1) = "|") Then
                subInd.Add(i)
            End If
        Next

        If (subInd.Count = 0) Then
            createButton(cellContent, 18)
        Else
            For x As Integer = 0 To subInd.Count
                If (x < subInd.Count) Then
                    Dim endIndex As Integer = subInd(x) - 1
                    Dim thing As String = cellContent.Substring(startIndex, endIndex - startIndex).Trim
                    If (x = 0) Then
                        createButton(thing, 18)
                    Else
                        createButton(thing, btn.Location.X + 175)
                    End If
                    startIndex = endIndex + 2
                ElseIf (x = subInd.Count) Then
                    startIndex = subInd(x - 1) + 1

                    createButton(cellContent.Substring(startIndex + 1, cellContent.Length - startIndex - 1).Trim, btn.Location.X + 175)
                End If
            Next
        End If
    End Sub

    Private Sub CellContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = panelHeading.ToString + " " + Label2.Text
        panel.VerticalScroll.Visible = False
        GenerateButtons()

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If (panel.Controls.Count = 0) Then

            If MessageBox.Show("You have removed all the exams from the cell. Do you wish to save these changes?", "Cell Update", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                EditTimeTable.CreateTT.Rows(EditTimeTable.rowIndex).Cells(EditTimeTable.colIndex).Value = " "
            End If
            Me.Close()
        Else
            If MessageBox.Show("Are you sure you want to set the new value of the cell to " + vbNewLine + vbNewLine + cellContent + " ?", "Cell Update", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                EditTimeTable.CreateTT.Rows(EditTimeTable.rowIndex).Cells(EditTimeTable.colIndex).Value = cellContent
            End If
            Me.Close()
        End If
    End Sub
End Class