Public Class CreateExamTimeTable
    Private SQL As New DataBaseControl
    Dim sender As Object
    Dim btn As Button = CType(sender, Button)
    Dim btnName As String
    Dim cords As New Point
    Dim allButtons As ArrayList = New ArrayList

    Dim startDate As String
    Dim endDate As String
    Dim sesh1StartTime As String
    Dim sesh2StartTime As String
    Dim sesh1EndTime As String
    Dim sesh2EndTime As String

    Dim term As Integer = 0
    Dim year As Integer = Convert.ToInt32(Now.ToString("yyyy"))

    Public cellCont As String = " "
    Public rowIndex As Integer = 0
    Public colIndex As Integer = 0
    Public panelHeading As String = " "
    Dim saved As Boolean = False
    Private Sub CreateExamTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExamTT.AllowDrop = True
        ExamTT.RowTemplate.MinimumHeight = 30

        Me.MdiParent = Form1

        GenerateButtons()

        SQL.RunQuery("Select TermNumber, Status,StartDate,EndDate FROM tblTerm")

        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows

                If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = "True") Then

                    DateTimePicker1.MinDate = (SQL.SQLDataSet.Tables(0).Rows(y).Item("StartDate"))
                    DateTimePicker1.MaxDate = (SQL.SQLDataSet.Tables(0).Rows(y).Item("EndDate"))
                    DateTimePicker1.Value = (SQL.SQLDataSet.Tables(0).Rows(y).Item("StartDate"))
                    DateTimePicker2.MinDate = (SQL.SQLDataSet.Tables(0).Rows(y).Item("StartDate"))
                    DateTimePicker2.MaxDate = (SQL.SQLDataSet.Tables(0).Rows(y).Item("EndDate"))
                    DateTimePicker1.Value = (SQL.SQLDataSet.Tables(0).Rows(y).Item("StartDate"))

                    Exit For
                End If
                y = y + 1
            Next
        End If

        startDate = DateTimePicker1.Value.ToLongDateString
        endDate = DateTimePicker2.Value.ToLongDateString

        sesh1StartTime = DateTimePicker3.Value.ToShortTimeString
        sesh1EndTime = DateTimePicker4.Value.ToShortTimeString
        sesh2StartTime = DateTimePicker5.Value.ToShortTimeString
        sesh2EndTime = DateTimePicker6.Value.ToShortTimeString

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
    Private Sub ExamTT_DragOver(sender As Object, e As DragEventArgs) Handles ExamTT.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub ExamTT_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ExamTT.DragDrop

        Dim clientPoint As Point = ExamTT.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = ExamTT.HitTest(clientPoint.X, clientPoint.Y)

        Dim destRow As Integer = hit.RowIndex
        Dim destCol As Integer = hit.ColumnIndex

        Dim clash As Boolean = False
        Dim Subj As String = btnName.Substring(0, btnName.IndexOf("-")).Trim

        Dim cellValue As String = ExamTT.Rows(destRow).Cells(destCol).Value.ToString
        Dim grade As String = btn.Name.Substring(btn.Name.IndexOf("Grade")).Trim
        Dim gradeInt As Integer = Integer.Parse(grade.Substring(grade.IndexOf(" "), grade.Length - grade.IndexOf(" ")).Trim)

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select LearnerID From tblLearner")

            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1

                If (SQL.SQLDataSet.Tables(0).Rows.Count > 0) Then

                    Dim learnerID As Integer = SQL.SQLDataSet.Tables(0).Rows(x).Item("LearnerID")
                    Dim subInd As ArrayList = New ArrayList
                    Dim eachSub As String = " "
                    Dim startIndexs As Integer = 0
                    Dim cellGrade As String = 0
                    Dim cellGradeInt As String = 0
                    For i As Integer = 0 To cellValue.Length - 1
                        If (cellValue.Substring(i, 1) = "|") Then
                            subInd.Add(i)
                        End If
                    Next


                    For j As Integer = 0 To subInd.Count
                        If (j < subInd.Count) Then
                            Dim endIndex As Integer = subInd(j) - 1

                            If (j = subInd.Count) Then
                                startIndexs = startIndexs - 2
                            End If

                            eachSub = cellValue.Substring(startIndexs, endIndex - startIndexs)
                            cellGrade = eachSub.Substring(eachSub.IndexOf("Grade")).Trim
                            cellGradeInt = Integer.Parse(cellGrade.Substring(cellGrade.IndexOf(" "), cellGrade.Length - cellGrade.IndexOf(" ")).Trim)
                            eachSub = eachSub.Substring(0, eachSub.IndexOf("-") - 1)
                            startIndexs = endIndex + 2

                        ElseIf (j = subInd.Count And j > 0) Then
                                startIndexs = (subInd(j - 1) + 1)
                                Dim endIndex As Integer = cellValue.Length
                                eachSub = cellValue.Substring(startIndexs, endIndex - startIndexs)
                                cellGrade = eachSub.Substring(eachSub.IndexOf("Grade")).Trim
                                cellGradeInt = Integer.Parse(cellGrade.Substring(cellGrade.IndexOf(" "), cellGrade.Length - cellGrade.IndexOf(" ")).Trim)
                                eachSub = eachSub.Substring(0, eachSub.IndexOf("-") - 1)
                            ElseIf (subInd.Count = 0 And Not (ExamTT.Rows(destRow).Cells(destCol).Value = " ")) Then
                                eachSub = cellValue
                            cellGrade = eachSub.Substring(eachSub.IndexOf("Grade")).Trim
                            cellGradeInt = cellGrade.Substring(cellGrade.IndexOf(" "), cellGrade.Length - cellGrade.IndexOf(" ")).Trim
                            eachSub = eachSub.Substring(0, eachSub.IndexOf("-") - 1)
                        End If

                        SQL.RunQuery("Select LearnerID,GradeID,SubjectName,AcademicYear from tblEnrolment INNER JOIN tblSubject ON tblEnrolment.SubjectID = tblSubject.SubjectID WHERE( LearnerID = '" & learnerID & "' AND GradeID = '" & cellGradeInt & "' AND SubjectName = '" & eachSub.Trim & "' AND AcademicYear = '" & year & "') OR (LearnerID = '" & learnerID & "' AND GradeID = '" & gradeInt & "' AND SubjectName = '" & Subj.Trim & "' AND AcademicYear = '" & year & "')")

                        If (SQL.SQLDataSet.Tables(0).Rows.Count > 1) Then
                            clash = True
                        End If

                        SQL.RunQuery("Select LearnerID From tblLearner")
                    Next
                End If
            Next x
        End If

        If (clash) Then
            MessageBox.Show("This is going to cause a clash for the students.", "Clash")
        Else
            If hit.Type = DataGridViewHitTestType.Cell Then
                If (ExamTT.Rows(destRow).Cells(destCol).Value = " ") Then

                    ExamTT.Rows(destRow).Cells(destCol).Value = btn.Text
                    btn.Enabled = False
                Else
                    ExamTT.Rows(destRow).Cells(destCol).Value = ExamTT.Rows(destRow).Cells(destCol).Value + vbNewLine + "|" + vbNewLine + btn.Text
                    btn.Enabled = False
                End If

            End If
        End If


    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        startDate = DateTimePicker1.Value.ToLongDateString

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        endDate = DateTimePicker2.Value.ToLongDateString

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        sesh1StartTime = DateTimePicker3.Value.ToShortTimeString
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        sesh1EndTime = DateTimePicker4.Value.ToShortTimeString

    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged
        sesh2StartTime = DateTimePicker5.Value.ToShortTimeString

    End Sub

    Private Sub DateTimePicker6_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker6.ValueChanged
        sesh2EndTime = DateTimePicker6.Value.ToShortTimeString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (DateTimePicker1.Value < DateTimePicker2.Value) Then
            If MessageBox.Show("Do you wish to confirm the exam period to be from " + vbNewLine + startDate + " - " + endDate + " ?", "Confirm Start And End Date", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                DateTimePicker1.Enabled = False
                DateTimePicker2.Enabled = False

                Dim startP As DateTime = DateTimePicker1.Value
                Dim endP As DateTime = DateTimePicker2.Value
                Dim currDay As DateTime = startP

                While (currDay <= endP)
                    Dim disp As String = currDay.ToLongDateString.Substring(currDay.ToLongDateString.IndexOf(",") + 1, currDay.ToLongDateString.Length - currDay.ToLongDateString.IndexOf(",") - 1).Trim
                    ExamTT.Rows.Add(disp)

                    currDay = currDay.AddDays(1)
                End While
                For x As Integer = 0 To ExamTT.Rows.Count - 1 Step +1

                    For y As Integer = 1 To ExamTT.Rows(x).Cells.Count - 1 Step +1

                        ExamTT.Rows(x).Cells(y).Value = " "
                    Next
                Next

            End If
        Else
            MessageBox.Show("Please enter a start date that comes before the end date.", "Invalid Date Period")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (DateTimePicker3.Value < DateTimePicker4.Value) Then

            If MessageBox.Show("Do you wish to confirm the session one time period to be from " + vbNewLine + sesh1StartTime + " - " + sesh1EndTime + " ?", "Confirm Session One Time Period", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                DateTimePicker3.Enabled = False
                DateTimePicker4.Enabled = False
                ExamTT.Columns(1).HeaderText = ExamTT.Columns(1).HeaderText + " - " + sesh1StartTime + " till " + sesh1EndTime
            End If
        Else
            MessageBox.Show("Please enter a start time that comes before the end time.", "Invalid Session Time Period")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DateTimePicker5.Value < DateTimePicker3.Value Then

            MessageBox.Show("Session two will start before session one. Please pick a session two period that is after session one.", "Session Clash")

        ElseIf (DateTimePicker5.Value < DateTimePicker6.Value) Then

            If MessageBox.Show("Do you wish to confirm the session two time period to be from " + vbNewLine + sesh2StartTime + " - " + sesh2EndTime + " ?", "Confirm Session Two Time Period", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                DateTimePicker5.Enabled = False
                DateTimePicker6.Enabled = False

                ExamTT.Columns(2).HeaderText = ExamTT.Columns(2).HeaderText + " - " + sesh2StartTime + " till " + sesh2EndTime
            End If

        Else
            MessageBox.Show("Please enter a start time that comes before the end time.", "Invalid Session Time Period")

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
                        SQL.RunQuery("INSERT INTO ExamTimeTable (Day, SessionOne, SessionTwo, SessionOneTime, SessionTwoTime, Term) VALUES ('" & ExamTT.Rows(x).Cells(0).Value.ToString & "','" & ExamTT.Rows(x).Cells(1).Value.ToString & "','" & ExamTT.Rows(x).Cells(2).Value.ToString & "','" & sesh1StartTime + "-" + sesh1EndTime & "','" & sesh2StartTime + "-" + sesh2EndTime & "','" & term & "')")
                    Next

                    MessageBox.Show("Exam Timetable Created!")
                End If
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to create this exam timetable ?", "Exam Timetable Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                For x As Integer = 0 To ExamTT.Rows.Count - 1 Step +1

                    SQL.RunQuery("INSERT INTO ExamTimeTable (Day, SessionOne, SessionTwo, SessionOneTime, SessionTwoTime, Term) VALUES ('" & ExamTT.Rows(x).Cells(0).Value.ToString & "','" & ExamTT.Rows(x).Cells(1).Value.ToString & "','" & ExamTT.Rows(x).Cells(2).Value.ToString & "','" & sesh1StartTime + "-" + sesh1EndTime & "','" & sesh2StartTime + "-" + sesh2EndTime & "','" & term & "')")
                Next

                MessageBox.Show("Exam Timetable Created!", "Comfirmation")
                saved = True

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
            CellContent.Show()
        ElseIf (ExamTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = " ") Then
            MessageBox.Show("There is no data in this cell", "No Data In Selected Cell")
        End If
    End Sub
End Class