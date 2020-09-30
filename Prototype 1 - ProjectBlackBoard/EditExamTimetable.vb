Public Class EditExamTimetable
    Private SQL As New DataBaseControl
    Dim term As Integer
    Dim sender As Object
    Dim btn As Button = CType(sender, Button)
    Dim btnName As String
    Dim cords As New Point
    Dim allButtons As ArrayList = New ArrayList
    Dim saved As Boolean = False

    Public cellCont As String = " "
    Public rowIndex As Integer = 0
    Public colIndex As Integer = 0
    Public panelHeading As String = " "
    Private Sub EditExamTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExamTT.RowTemplate.MinimumHeight = 30
        GenerateButtons()

        SQL.RunQuery("Select TermNumber, Status FROM tblTerm")

        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows

                If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = "True") Then

                    term = SQL.SQLDataSet.Tables(0).Rows(y).Item("TermNumber")

                    Exit For
                End If
                y = y + 1
            Next
        End If

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("SELECT Day,SessionOne,SessionTwo,SessionOneTime,SessionTwoTime,Term FROM ExamTimeTable WHERE Term = '" & term & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    Dim y As Integer = 0
                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                        ExamTT.Rows.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Day"))
                        y = y + 1
                    Next

                End If
            End If
        End If

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("SELECT Day,SessionOne,SessionTwo,SessionOneTime,SessionTwoTime,Term FROM ExamTimeTable WHERE Term = '" & term & "'")
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    Dim y As Integer = 0
                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                        ExamTT.Rows(y).Cells(1).Value = SQL.SQLDataSet.Tables(0).Rows(y).Item("SessionOne")
                        ExamTT.Rows(y).Cells(2).Value = SQL.SQLDataSet.Tables(0).Rows(y).Item("SessionTwo")
                        y = y + 1
                    Next

                End If
            End If
        End If
        For z As Integer = 0 To panel.Controls.Count - 1
            For m As Integer = 0 To ExamTT.Rows.Count - 1
                If (panel.Controls.Item(z).Name = ExamTT.Rows(m).Cells(1).Value) Then
                    panel.Controls.Item(z).Enabled = False
                End If
                If (panel.Controls.Item(z).Name = ExamTT.Rows(m).Cells(2).Value) Then
                    panel.Controls.Item(z).Enabled = False
                End If
            Next
        Next


    End Sub
    Private Sub ExamTT_DragOver(sender As Object, e As DragEventArgs) Handles ExamTT.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to update the exam timetable ?", "Exam Timetable Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                For x As Integer = 0 To ExamTT.Rows.Count - 1 Step +1

                    SQL.RunQuery("Update ExamTimeTable SET SessionOne = '" & ExamTT.Rows(x).Cells(1).Value.ToString & "', SessionTwo = '" & ExamTT.Rows(x).Cells(2).Value.ToString & "' WHERE Term = '" & term & "' and Day = '" & ExamTT.Rows(x).Cells(0).Value.ToString & "'")
                    saved = True
                Next

                MessageBox.Show("The exam timetable has been updated.", "Comfirmation")

            End If
        End If
    End Sub
    Private Sub ExamTT_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ExamTT.DragDrop

        Dim clientPoint As Point = ExamTT.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = ExamTT.HitTest(clientPoint.X, clientPoint.Y)

        Dim destRow As Integer = hit.RowIndex
        Dim destCol As Integer = hit.ColumnIndex

        If hit.Type = DataGridViewHitTestType.Cell Then
            If (ExamTT.Rows(destRow).Cells(destCol).Value = " ") Then

                ExamTT.Rows(destRow).Cells(destCol).Value = btn.Text
                btn.Enabled = False
            Else
                ExamTT.Rows(destRow).Cells(destCol).Value = ExamTT.Rows(destRow).Cells(destCol).Value + vbNewLine + "|" + vbNewLine + btn.Text
                btn.Enabled = False
            End If

        End If
    End Sub
    Private Sub createButton(btnLabel As String, y As Integer)

        btn = New Button
        btn.Text = btnLabel
        btn.Name = btnLabel
        btn.Width = 170
        btn.Height = 50
        btn.Left = 5
        btn.Top = 5
        btn.Location = New Point(18, y)
        btn.Cursor = Cursors.SizeAll
        btn.BackColor = Color.LightBlue
        btn.BringToFront()

        AddHandler btn.MouseDown, AddressOf btnMouseDown
        AddHandler btn.MouseUp, AddressOf btnMouseUp
        AddHandler btn.MouseMove, AddressOf btnMouseMove

        Me.Controls.Add(btn)
        Me.panel.Controls.Add(btn)

    End Sub
    Private Sub btnMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        cords.Y = MousePosition.Y - sender.top
        cords.X = MousePosition.X - sender.left
        btn = TryCast(sender, Button)
        btnName = btn.Text.ToString
        btn.DoDragDrop(btn, DragDropEffects.Copy)

    End Sub
    Private Sub btnMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim btn As Button = TryCast(sender, Button)
        btn.BackColor = Color.LightBlue


        Dim clientPoint As Point = ExamTT.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = ExamTT.HitTest(clientPoint.X, clientPoint.Y)
        If hit.Type = DataGridViewHitTestType.Cell Then
            Dim destRow As Integer = hit.RowIndex
            Dim destCol As Integer = hit.ColumnIndex
            ExamTT.Rows(destRow).Cells(destCol).Value = btn.Text
        End If
    End Sub
    Private Sub btnMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - cords.Y
            sender.left = MousePosition.X - cords.X
            Dim btn As Button = TryCast(sender, Button)
            btn.BackColor = Color.RoyalBlue

        End If
    End Sub
    Public Sub GenerateButtons()

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            Dim AcademicYear As Integer = Convert.ToInt32(Now.ToString("yyyy"))
            SQL.RunQuery("Select TermNumber, Status FROM tblTerm")

            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows

                    If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = "True") Then

                        term = SQL.SQLDataSet.Tables(0).Rows(y).Item("TermNumber")

                        Exit For
                    End If
                    y = y + 1
                Next
            End If

            SQL.RunQuery("Select tblSubject.SubjectName, tblSubject.isOffered, tblPOA.Topic, tblPOA.Active, tblPOA.Year, tblPOA.GradeID, tblPOA.Term FROM tblSubject INNER JOIN tblPOA ON tblSubject.SubjectID = tblPOA.SubjectID WHERE (tblPOA.Term = '" & term & "') AND (tblPOA.Year = '" & AcademicYear & "') AND (tblPOA.Topic LIKE '" & "term" & "' + '%' OR tblPOA.Topic LIKE '" & "exam" & "' + '%' OR tblPOA.Topic LIKE '" & "paper" & "' + '%')")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0

                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    Dim btnText = SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName") + " - " + SQL.SQLDataSet.Tables(0).Rows(y).Item("Topic") + vbNewLine + " - " + "Grade " + SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID").ToString

                    If y = 0 Then
                        createButton(btnText, 18)
                    Else
                        createButton(btnText, btn.Location.Y + 55)
                    End If
                    allButtons.Add(btnText)
                    y = y + 1
                Next x
            End If

        End If
    End Sub
    Private Sub ExamTT_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ExamTT.CellDoubleClick

        If Not (ExamTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = " ") Then
            rowIndex = e.RowIndex
            colIndex = e.ColumnIndex
            cellCont = ExamTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            panelHeading = ExamTT.Columns(colIndex).HeaderText
            CellContent4.Show()
        ElseIf (ExamTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = " ") Then
            MessageBox.Show("There is no data in this cell", "No Data In Selected Cell")
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        If Not (saved) Then
            If MessageBox.Show("If you leave now all data will be lost." + vbNewLine + "Do you want to save your current data?", "Error", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If SQL.HasConnnection = True Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If
                    For x As Integer = 0 To ExamTT.Rows.Count - 1 Step +1
                        SQL.RunQuery("Update ExamTimeTable SET SessionOne = '" & ExamTT.Rows(x).Cells(1).Value.ToString & "', SessionTwo = '" & ExamTT.Rows(x).Cells(2).Value.ToString & "' WHERE Term = '" & term & "' and Day = '" & ExamTT.Rows(x).Cells(0).Value.ToString & "'")
                    Next

                    MessageBox.Show("The exam timetable has been updated", "Exam Timetable Updated")
                End If
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class