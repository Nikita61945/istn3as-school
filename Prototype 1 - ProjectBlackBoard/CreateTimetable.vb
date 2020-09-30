
Public Class CreateTimetable
    Public SelectedGrade = vbNullString
    Private SQL As New DataBaseControl
    Dim sender As Object
    Dim btn As Button = CType(sender, Button)
    Dim cords As New Point
    Dim Room As String
    Dim Tutor As String
    Dim Grade As Integer = 0
    Dim btnName As String
    Dim allButtons As ArrayList = New ArrayList
    Public genWithGrade As Integer = 0
    Dim year As Integer = Convert.ToInt32(Now.ToString("yyyy"))
    Dim saved As Boolean = False
    Public cellCont As String = " "
    Public rowIndex As Integer = 0
    Public colIndex As Integer = 0
    Public panelHeading As String = " "
    Public Editday As String = ""
    Public period As String = ""
    Public EditGrade As Integer = 0

    Private Sub createButton(btnLabel As String, y As Integer)

        btn = New Button
        btn.Text = btnLabel
        btn.Name = btnLabel
        btn.Width = 100
        btn.Height = 50
        btn.Left = 10
        btn.Top = 10
        btn.Location = New Point(y, 18)
        btn.Cursor = Cursors.SizeAll
        btn.BackColor = Color.LightBlue
        btn.BringToFront()

        AddHandler btn.MouseDown, AddressOf btnMouseDown
        AddHandler btn.MouseUp, AddressOf btnMouseUp
        AddHandler btn.MouseMove, AddressOf btnMouseMove

        Me.Controls.Add(btn)
        Me.panel.Controls.Add(btn)

    End Sub
    Private Sub CreateTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateTT.AllowDrop = True
        CreateTT.RowTemplate.MinimumHeight = 80

        CreateTT.Rows.Add("Monday")
        CreateTT.Rows.Add("Tuesday")
        CreateTT.Rows.Add("Wednesday")
        CreateTT.Rows.Add("Thursday")
        CreateTT.Rows.Add("Friday")

        For x As Integer = 0 To CreateTT.Rows.Count - 1 Step +1

            For y As Integer = 1 To CreateTT.Rows(x).Cells.Count - 1 Step +1

                CreateTT.Rows(x).Cells(y).Value = " "
                CreateTT.Rows(x).Cells(y).Style.BackColor = Color.LightGray
            Next
        Next

        CreateTT.Rows(0).Cells(5).Value = "                   B"
        CreateTT.Rows(1).Cells(5).Value = "                   R"
        CreateTT.Rows(2).Cells(5).Value = "                   E"
        CreateTT.Rows(3).Cells(5).Value = "                   A"
        CreateTT.Rows(4).Cells(5).Value = "                   K"

        populateGradeComboBox()


    End Sub
    Public Sub GenerateButtons()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblSubGrade.GradeID, tblSubGrade.isOffered, tblSubGrade.TutorID, tblTutor.FName, tblTutor.Surname, tblSubject.SubjectName From tblSubGrade INNER Join tblTutor On tblSubGrade.TutorID = tblTutor.TutorID INNER Join tblSubject On tblSubGrade.SubjectID = tblSubject.SubjectID Where GradeID = '" & Grade & "' ")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0

                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    Dim btnText = SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName") + vbNewLine + " - " + SQL.SQLDataSet.Tables(0).Rows(y).Item("Fname") + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("Surname")

                    If y = 0 Then
                        createButton(btnText, 18)
                    Else
                        createButton(btnText, btn.Location.X + 105)
                    End If
                    allButtons.Add(btnText)
                    y = y + 1
                Next x
            End If

        End If
    End Sub
    Private Sub btnMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        cords.Y = MousePosition.Y - sender.top
        cords.X = MousePosition.X - sender.left
        Dim btn As Button = TryCast(sender, Button)
        btnName = btn.Text.ToString

        Dim tutorName As String = btn.Name.Substring(btnName.IndexOf("-") + 1).Trim

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblTutor.FName, TutorTimes.Day, TutorTimes.StartTime, TutorTimes.EndTime, TutorTimes.Allday, tblTutor.Surname FROM TutorTimes INNER JOIN tblTutor ON TutorTimes.TutorID = tblTutor.TutorID WHERE FName = '" & tutorName.Substring(0, tutorName.IndexOf(" ")) & "'")


            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    If (SQL.SQLDataSet.Tables(0).Rows(x).Item("Allday").ToString = "") Then

                        Dim tStartTime As TimeSpan = SQL.SQLDataSet.Tables(0).Rows(x).Item("StartTime")
                        Dim tEndTime As TimeSpan = SQL.SQLDataSet.Tables(0).Rows(x).Item("EndTime")

                        Dim startIndex As Integer = 1
                        Dim endIndex As Integer = 1

                        For y As Integer = 1 To CreateTT.Rows(0).Cells.Count - 1 Step +1
                            Dim startHour As String = CreateTT.Columns(y).HeaderText.ToString.Substring(0, CreateTT.Columns(y).HeaderText.ToString.IndexOf(":")).Trim
                            Dim startMin As String = CreateTT.Columns(y).HeaderText.ToString.Substring(CreateTT.Columns(y).HeaderText.ToString.IndexOf(":") + 1, CreateTT.Columns(y).HeaderText.ToString.IndexOf("-") - 3).Trim

                            Dim endTimePart As String = CreateTT.Columns(y).HeaderText.ToString.Substring(CreateTT.Columns(y).HeaderText.ToString.IndexOf("-") + 1, CreateTT.Columns(y).HeaderText.ToString.Length - CreateTT.Columns(y).HeaderText.ToString.IndexOf("-") - 1)
                            Dim endHour As String = endTimePart.Substring(0, endTimePart.IndexOf(":")).Trim
                            Dim endMin As String = endTimePart.Substring(endTimePart.IndexOf(":") + 1, endTimePart.Length - endTimePart.IndexOf(":") - 1).Trim

                            If (tStartTime.Hours < 8) Then
                                startIndex = 1
                            End If

                            If (tStartTime.Hours = startHour) Then
                                If (tStartTime.Minutes <= startMin) Then
                                    startIndex = y
                                Else
                                    startIndex = y + 1
                                End If
                            End If

                            If (tEndTime.Hours = endHour) Then
                                If (tEndTime.Minutes <= endMin) Then
                                    endIndex = y
                                Else
                                    startIndex = y - 1
                                End If
                            End If
                        Next
                        If Not (tEndTime.Hours = 0 And tStartTime.Hours = 0) Then
                            Dim day As String = SQL.SQLDataSet.Tables(0).Rows(x).Item("Day")

                            For y As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
                                If CreateTT.Rows(y).Cells(0).Value = day Then
                                    For z As Integer = startIndex To endIndex
                                        If Not (z = 5) Then
                                            CreateTT.Rows(y).Cells(z).Style.BackColor = Color.White
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Else
                        Dim day As String = SQL.SQLDataSet.Tables(0).Rows(x).Item("Day")

                        For y As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
                            If CreateTT.Rows(y).Cells(0).Value = day Then
                                For z As Integer = 1 To CreateTT.Rows(y).Cells.Count - 1
                                    If Not (z = 5) Then
                                        CreateTT.Rows(y).Cells(z).Style.BackColor = Color.White
                                    End If

                                Next
                            End If
                        Next
                    End If
                End If
            Next x
        End If

        btn.DoDragDrop(btn, DragDropEffects.Copy)

        For x As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
            For y As Integer = 1 To CreateTT.Rows(x).Cells.Count - 1 Step +1

                CreateTT.Rows(x).Cells(y).Style.BackColor = Color.LightGray

            Next
        Next

    End Sub
    Private Sub btnMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim btn As Button = TryCast(sender, Button)
        btn.BackColor = Color.LightBlue

        Dim clientPoint As Point = CreateTT.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = CreateTT.HitTest(clientPoint.X, clientPoint.Y)
        If hit.Type = DataGridViewHitTestType.Cell Then
            Dim destRow As Integer = hit.RowIndex
            Dim destCol As Integer = hit.ColumnIndex
            CreateTT.Rows(destRow).Cells(destCol).Value = btn.Text
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

    Private Sub CreateTT_DragOver(sender As Object, e As DragEventArgs) Handles CreateTT.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub CreateTT_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles CreateTT.DragDrop

        Dim btn As Button = TryCast(sender, Button)

        Dim clientPoint As Point = CreateTT.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = CreateTT.HitTest(clientPoint.X, clientPoint.Y)

        Dim destRow As Integer = hit.RowIndex
        Dim destCol As Integer = hit.ColumnIndex

        If hit.Type = DataGridViewHitTestType.Cell Then
            If (CreateTT.Rows(destRow).Cells(destCol).Style.BackColor = Color.LightGray) Then
                Dim SubInTT As String = btnName
                Dim TutorInTT = SubInTT.Substring(SubInTT.IndexOf("-") + 1)
                MessageBox.Show(TutorInTT.ToString + " is not available at this time", "Tutor Unavailable!")
            Else
                Dim period As String = CreateTT.Columns(destCol).Name
                Dim day As String = CreateTT.Rows(destRow).Cells(0).Value

                Dim isTeachingInThatSlot = False
                Dim isTeachingInThatDG = False
                Dim gradeBeingTaught As String = " "

                Dim TutorInTT As String = " "
                Dim SubInDB As String = " "

                If SQL.HasConnnection = True Then

                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    SQL.RunQuery("SELECT Day,Grade, P1, P2, P3, P4, P5, P6, P7,P8,P9 FROM TimeTable WHERE (Day =  '" & day & "' ) AND (NOT (Grade =  '" & Grade & "' ))")

                    Dim y As Integer = 0

                    For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                        SubInDB = SQL.SQLDataSet.Tables(0).Rows(y).Item(period).ToString().Trim()

                        Dim subIndInDB As ArrayList = New ArrayList
                        Dim SubInTT As String = btnName
                        TutorInTT = SubInTT.Substring(SubInTT.IndexOf("-") + 1)

                        Dim TutorInDb As String = SQL.SQLDataSet.Tables(0).Rows(y).Item(period).ToString().Trim()
                        For i As Integer = 0 To TutorInDb.Length - 1

                            If (TutorInDb.Substring(i, 1) = "|") Then
                                subIndInDB.Add(i)
                            End If

                        Next

                        Dim start As Integer = 0

                        For j As Integer = 0 To subIndInDB.Count
                            If (j = 0) Then

                                Dim endIndex As Integer = returnSecondDashIndex(SubInDB.Trim)
                                Dim eachSub As String = SubInDB.Substring(0, endIndex)

                                If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                    isTeachingInThatDG = True
                                    gradeBeingTaught = SQL.SQLDataSet.Tables(0).Rows(y).Item(1).ToString()
                                    SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                                End If
                                start = endIndex + 2

                            ElseIf (j < subIndInDB.Count) Then
                                start = subIndInDB(j - 1) + 1
                                Dim endIndex As Integer = subIndInDB(j) - 1
                                Dim eachSub As String = TutorInDb.Substring(start, endIndex - start)
                                eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)

                                If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                    gradeBeingTaught = SQL.SQLDataSet.Tables(0).Rows(y).Item(1).ToString()
                                    SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                                    isTeachingInThatSlot = True
                                End If
                                start = endIndex + 2

                            ElseIf (j = subIndInDB.Count And j > 0) Then
                                start = (subIndInDB(j - 1) + 1)
                                Dim endIndex As Integer = TutorInDb.Length
                                Dim eachSub As String = TutorInDb.Substring(start, endIndex - start)
                                eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)
                                If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                    isTeachingInThatSlot = True
                                    gradeBeingTaught = SQL.SQLDataSet.Tables(0).Rows(y).Item(1).ToString()
                                    SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                                End If
                            End If
                        Next
                        y = y + 1
                    Next

                    Dim cellValue As String = CreateTT.Rows(destRow).Cells(destCol).Value.ToString
                    TutorInTT = btnName.Substring(btnName.IndexOf("-") + 1)
                    Dim subInd As ArrayList = New ArrayList

                    For i As Integer = 0 To cellValue.Length - 1
                        If (cellValue.Substring(i, 1) = "|") Then
                            subInd.Add(i)
                        End If
                        If (subInd.Count = 0 And i > 0) Then
                            Dim endIndex As Integer = returnSecondDashIndex(cellValue.Trim)
                            Dim eachSub As String = cellValue.Substring(0, endIndex)

                            If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                isTeachingInThatDG = True
                                gradeBeingTaught = Grade
                                SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                            End If
                        End If
                    Next

                    Dim startIndex As Integer = 0

                    For j As Integer = 0 To subInd.Count
                        If (j < subInd.Count) Then
                            Dim endIndex As Integer = subInd(j) - 1
                            Dim eachSub As String = cellValue.Substring(startIndex, endIndex - startIndex)
                            eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)

                            If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                gradeBeingTaught = Grade
                                SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                                isTeachingInThatDG = True
                            End If
                            startIndex = endIndex + 2

                        ElseIf (j = subInd.Count And j > 0) Then
                            startIndex = (subInd(j - 1) + 1)
                            Dim endIndex As Integer = cellValue.Length
                            Dim eachSub As String = cellValue.Substring(startIndex, endIndex - startIndex)

                            eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)

                            If (eachSub.Substring(eachSub.IndexOf("-") + 1).Trim = TutorInTT.Trim) Then
                                isTeachingInThatDG = True
                                gradeBeingTaught = Grade
                                SubInDB = eachSub.Substring(0, eachSub.IndexOf("-")).Trim
                            End If
                        End If
                    Next
                    Dim clash As Boolean = False
                    Dim Subj As String = btnName.Substring(0, btnName.IndexOf("-"))

                    If SQL.HasConnnection = True Then

                        If SQL.SQLDataSet IsNot Nothing Then
                            SQL.SQLDataSet.Clear()
                        End If

                        SQL.RunQuery("Select LearnerID From tblLearner")

                        For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1

                            If (SQL.SQLDataSet.Tables(0).Rows.Count > 0) Then

                                Dim learnerID As Integer = SQL.SQLDataSet.Tables(0).Rows(x).Item("LearnerID")
                                Dim eachSub As String = " "
                                Dim startIndexs As Integer = 0

                                For j As Integer = 0 To subInd.Count
                                    If (j < subInd.Count) Then
                                        Dim endIndex As Integer = subInd(j) - 1
                                        eachSub = cellValue.Substring(startIndexs, endIndex - startIndexs)
                                        eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)

                                        startIndexs = endIndex + 2

                                    ElseIf (j = subInd.Count And j > 0) Then
                                        startIndexs = (subInd(j - 1) + 1)
                                        Dim endIndex As Integer = cellValue.Length
                                        eachSub = cellValue.Substring(startIndexs, endIndex - startIndexs)
                                        eachSub = eachSub.Substring(0, returnSecondDashIndex(eachSub) - 0)

                                    ElseIf (subInd.Count = 0 And Not (CreateTT.Rows(destRow).Cells(destCol).Value = " ")) Then

                                        Dim endIndex As Integer = cellValue.IndexOf("-")
                                        eachSub = cellValue.Substring(0, endIndex)


                                    End If

                                    SQL.RunQuery("Select LearnerID,GradeID,SubjectName,AcademicYear from tblEnrolment INNER JOIN tblSubject ON tblEnrolment.SubjectID = tblSubject.SubjectID WHERE( LearnerID = '" & learnerID & "' AND GradeID = '" & Grade & "' AND SubjectName = '" & eachSub.Trim & "' AND AcademicYear = '" & year & "') OR (LearnerID = '" & learnerID & "' AND GradeID = '" & Grade & "' AND SubjectName = '" & Subj.Trim & "' AND AcademicYear = '" & year & "')")

                                    If (SQL.SQLDataSet.Tables(0).Rows.Count > 1) Then
                                        clash = True
                                    End If

                                    SQL.RunQuery("Select LearnerID From tblLearner")
                                Next
                            End If
                        Next x
                    End If

                    If (isTeachingInThatSlot Or isTeachingInThatDG) Then

                        MessageBox.Show(TutorInTT + " is already teaching " + SubInDB + " in that period for grade " + gradeBeingTaught.ToString() + "!", "Tutor Clash")
                    ElseIf clash = True Then
                        MessageBox.Show(Subj.ToString.Trim + " is going to clash for students.", "Learner Clash")
                    Else

                        Dim classPeriod As String = CreateTT.Columns(destCol).Name
                        Dim classDay As String = CreateTT.Rows(destRow).Cells(0).Value
                        Dim subject As String = (btnName.Substring(0, btnName.IndexOf("-"))).Trim
                        Dim classRoom As String = assignClass(subject, Grade, classPeriod, classDay)

                        If (CreateTT.Rows(destRow).Cells(destCol).Value = " ") Then

                            CreateTT.Rows(destRow).Cells(destCol).Value = btnName + vbNewLine + " - " + classRoom
                        Else
                            CreateTT.Rows(destRow).Cells(destCol).Value = CreateTT.Rows(destRow).Cells(destCol).Value + vbNewLine + "|" + vbNewLine + btnName + vbNewLine + " - " + classRoom
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If MessageBox.Show("Are you sure you want to create this timetable for grade " + Grade.ToString + " ?", "Timetable Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                For x As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
                    SQL.RunQuery("INSERT INTO TimeTable (Day, Grade, P1, P2, P3, P4, P5, P6, P7,P8,P9) VALUES ('" & CreateTT.Rows(x).Cells(0).Value.ToString & "','" & Grade & "','" & CreateTT.Rows(x).Cells(1).Value.ToString & "','" & CreateTT.Rows(x).Cells(2).Value.ToString & "','" & CreateTT.Rows(x).Cells(3).Value.ToString & "','" & CreateTT.Rows(x).Cells(4).Value.ToString & "','" & CreateTT.Rows(x).Cells(5).Value.ToString & "','" & CreateTT.Rows(x).Cells(6).Value.ToString & "','" & CreateTT.Rows(x).Cells(7).Value.ToString & "','" & CreateTT.Rows(x).Cells(8).Value.ToString & "','" & CreateTT.Rows(x).Cells(9).Value.ToString & "')")
                Next
                MessageBox.Show("Timetable Created!", "Confirmation")
                saved = True
            End If
        End If

    End Sub
    Public Sub populateGradeComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID, GradeName AS 'Identify' FROM tblGrade WHERE isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Identify"))
                    y = y + 1
                Next x
            End If
            GradeComboBox.ValueMember = "GradeID"
            GradeComboBox.DisplayMember = "Identify"
            If SelectedGrade <> vbNullString Then
                GradeComboBox.SelectedItem = SelectedGrade
            End If
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        CreateTT.Enabled = True
        saved = False

        Dim newGrade As Integer = (GradeComboBox.SelectedItem.ToString.Substring(GradeComboBox.SelectedItem.ToString.IndexOf(" ")))
        genWithGrade = newGrade
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT Grade FROM TimeTable WHERE Grade = '" & newGrade & "'")

            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("A timetable for grade " + newGrade.ToString() + " has already been created." + vbNewLine + "Do you want to view it and make changes?", "Timetable for selected grade already created.", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    EditTimeTable.Show()
                    Me.Close()

                Else
                    CreateTT.Enabled = False
                End If
            Else
                Grade = (GradeComboBox.SelectedItem.ToString.Substring(GradeComboBox.SelectedItem.ToString.IndexOf(" ")))

                removeButtons()

                For x As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
                    For y As Integer = 1 To CreateTT.Rows(x).Cells.Count - 1 Step +1
                        If (y = 5) Then
                            CreateTT.Rows(x).Cells(y).Style.BackColor = Color.LightGray
                        End If
                        CreateTT.Rows(x).Cells(y).Value = " "
                    Next
                Next
                CreateTT.Rows(0).Cells(5).Value = "                   B"
                CreateTT.Rows(1).Cells(5).Value = "                   R"
                CreateTT.Rows(2).Cells(5).Value = "                   E"
                CreateTT.Rows(3).Cells(5).Value = "                   A"
                CreateTT.Rows(4).Cells(5).Value = "                   K"

                GenerateButtons()
                Dim con As Control
                For controlIndex As Integer = Me.panel.Controls.Count - 1 To 0 Step -1
                    con = Me.panel.Controls(controlIndex)
                    If Not (checkTime(con.Name.Substring(con.Name.IndexOf("-") + 1).Trim)) Then
                        con.BackColor = Color.IndianRed
                    End If
                Next
            End If
        End If
    End Sub
    Public Sub removeButtons()

        Dim con As Control

        For controlIndex As Integer = Me.Controls.Count - 1 To 0 Step -1
            con = Me.Controls(controlIndex)
            For i As Integer = 0 To allButtons.Count - 1
                Dim val As String = allButtons(i).ToString()

                If con.Name = val Then
                    Me.Controls.Remove(con)
                End If
            Next
        Next

        panel.Controls.Clear()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        If Not (saved) Then
            If MessageBox.Show("If you leave now all data will be lost." + vbNewLine + "Do you want to save your current data?", "Loss of Data", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If SQL.HasConnnection = True Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    For x As Integer = 0 To CreateTT.Rows.Count - 1 Step +1
                        SQL.RunQuery("INSERT INTO TimeTable (Day, Grade, P1, P2, P3, P4, P5, P6, P7,P8,P9) VALUES ('" & CreateTT.Rows(x).Cells(0).Value.ToString & "','" & Grade & "','" & CreateTT.Rows(x).Cells(1).Value.ToString & "','" & CreateTT.Rows(x).Cells(2).Value.ToString & "','" & CreateTT.Rows(x).Cells(3).Value.ToString & "','" & CreateTT.Rows(x).Cells(4).Value.ToString & "','" & CreateTT.Rows(x).Cells(5).Value.ToString & "','" & CreateTT.Rows(x).Cells(6).Value.ToString & "','" & CreateTT.Rows(x).Cells(7).Value.ToString & "','" & CreateTT.Rows(x).Cells(8).Value.ToString & "','" & CreateTT.Rows(x).Cells(9).Value.ToString & "')")
                    Next
                    MessageBox.Show("Timetable Created!", "Confirmation")
                End If
            Else

                SQL.RunQuery("DELETE FROM AssignRooms WHERE (Grade = '" & Grade & "')")
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Function checkTime(tutName As String) As Boolean

        Dim tutorName As String = tutName

        Dim tOrF As Boolean = False
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblTutor.FName, TutorTimes.Day, TutorTimes.StartTime, TutorTimes.EndTime, TutorTimes.Allday, tblTutor.Surname FROM TutorTimes INNER JOIN tblTutor ON TutorTimes.TutorID = tblTutor.TutorID WHERE FName = '" & tutorName.Substring(0, tutorName.IndexOf(" ")).Trim & "'")

            For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                If (SQL.SQLDataSet.Tables(0).Rows.Count > 0) Then
                    tOrF = True
                End If
            Next
        End If

        Return tOrF
    End Function
    Private Sub CreateTT_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CreateTT.CellDoubleClick
        If Not (CreateTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = " ") Then
            rowIndex = e.RowIndex
            colIndex = e.ColumnIndex
            cellCont = CreateTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            panelHeading = CreateTT.Columns(colIndex).HeaderText
            Editday = CreateTT.Rows(e.RowIndex).Cells(0).Value
            period = CreateTT.Columns(colIndex).HeaderCell.Value
            EditGrade = Grade
            CellContent2.Show()
        ElseIf (CreateTT.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = " ") Then
            MessageBox.Show("There is no data in this cell", "No Data In Selected Cell")
        End If
    End Sub
    Function assignClass(subject As String, grade As Integer, period As String, day As String) As String
        Dim roomName As String = " "
        Dim roomCapacity As ArrayList = New ArrayList

        SQL.RunQuery("SELECT tblEnrolment.LearnerID, tblSubject.SubjectName From tblEnrolment INNER Join tblSubject On tblEnrolment.SubjectID = tblSubject.SubjectID Where (tblEnrolment.GradeID = '" & grade & "') AND (tblEnrolment.AcademicYear = '" & year & "') AND (tblEnrolment.Active = 1) AND (tblSubject.SubjectName = '" & subject & "')")
        Dim numOfStuds As String = SQL.SQLDataSet.Tables(0).Rows.Count

        SQL.RunQuery("SELECT Capacity FROM Rooms ORDER BY Capacity")
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                roomCapacity.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("Capacity"))
                y = y + 1
            Next
        End If

        Dim roomSet As Boolean = True

        While (roomSet)
            For x As Integer = 0 To roomCapacity.Count - 1
                If (roomCapacity(x) >= numOfStuds) Then
                    SQL.SQLDataSet.Tables.Clear()

                    If (x = 0) Then
                        SQL.RunQuery("Select roomName From Rooms Where (Capacity = '" & roomCapacity(x) & "' )")
                    Else
                        SQL.RunQuery("Select roomName From Rooms Where (Capacity = '" & roomCapacity(x - 1) & "' )")
                    End If

                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then

                        For z As Integer = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1

                            Dim roomNameCheck As String = SQL.SQLDataSet.Tables(0).Rows(z).Item("RoomName")
                            If (checkRoomAvailability(roomNameCheck, period, day)) Then
                                roomName = roomNameCheck
                                roomSet = False
                                Exit While
                            End If

                        Next
                    End If
                End If
            Next
        End While
        SQL.RunQuery("Insert Into AssignRooms (RoomName,Day,Period,Subject,Grade,NumberOfLearners) values ('" & roomName & "','" & day & "','" & period & "','" & subject & "','" & grade & "','" & numOfStuds & "')")

        Return roomName
    End Function
    Function checkRoomAvailability(roomName As String, period As String, day As String) As Boolean
        Dim returnBool As Boolean

        SQL.RunQuery("SELECT RoomName FROM AssignRooms Where Day = '" & day & "' and Period = '" & period & "'")

        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            For x As Integer = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                Dim roomToCheck As String = SQL.SQLDataSet.Tables(0).Rows(x).Item("RoomName").ToString.Trim
                If (roomName = roomToCheck) Then
                    returnBool = False
                    Exit For
                ElseIf (Not (roomName = roomToCheck) And Not (returnBool = True)) Then
                    returnBool = True
                End If
            Next
        Else
            returnBool = True
        End If

        Return returnBool
    End Function
    Function returnSecondDashIndex(s As String) As Integer
        Dim returnIndex As Integer
        Dim count As Integer = 0

        For x As Integer = 0 To s.Trim.Length - 1

            If (s.Substring(x, 1).Equals("-")) Then
                count += 1
            End If

            If (count = 2) Then
                returnIndex = x
                Exit For
            End If

        Next

        Return returnIndex
    End Function
End Class