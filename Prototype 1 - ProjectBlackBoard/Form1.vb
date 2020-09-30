Public Class Form1
    Dim X As String
    Dim open As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoginButton.Location = New Point(1, -2)
        SetupButton.Location = New Point(1, 663)
        LearnersButton.Location = New Point(1, 625)
        FeesButton.Location = New Point(1, 587)
        RecordsButton.Location = New Point(1, 511)
        TutorButton.Location = New Point(1, 549)
        SchedulingButton.Location = New Point(1, 473)

        LoginPanel.Location = New Point(1, 40)
        SetupPanel.Location = New Point(1, 40)
        LearnersPanel.Location = New Point(1, 40)
        FeesPanel.Location = New Point(1, 40)
        RecordsPanel.Location = New Point(1, 40)
        TutorPanel.Location = New Point(1, 40)
        SchedulingPanel.Location = New Point(1, 40)

        LoginPanel.Visible = True
        SetupPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        RecordsPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 2)
        RecordsIcon.Location = New Point(3, 515)
        TutorIcon.Location = New Point(3, 553)
        FeesIcon.Location = New Point(3, 591)
        LearnerIcon.Location = New Point(3, 629)
        SetupIcon.Location = New Point(3, 667)
        SchedulingIcon.Location = New Point(4, 477)

        WindowState = 2
        IsMdiContainer = True
    End Sub

    Public Function isFieldBlank(ByVal CheckField As String)
        If CheckField.Length = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub LoginButton_Click_1(sender As Object, e As EventArgs) Handles LoginButton.Click
        LogOutButton.Location = New Point(0, 663)
        LoginButton.Location = New Point(0, -2)
        SetupButton.Location = New Point(0, 625)
        LearnersButton.Location = New Point(0, 587)
        FeesButton.Location = New Point(0, 549)
        RecordsButton.Location = New Point(0, 473)
        TutorButton.Location = New Point(0, 511)
        SchedulingButton.Location = New Point(1, 435)

        LogOutPicBox.Location = New Point(3, 667)
        ClosedLockIcon.Location = New Point(3, 2)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 554)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 629)
        SchedulingIcon.Location = New Point(4, 439)

        LoginPanel.Visible = True
        SetupPanel.Visible = False
        FeesPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False
    End Sub

    Private Sub PrintTermCompLabel_Click(sender As Object, e As EventArgs) Handles PrintTermCompLabel.Click
        TrmComposite.Show()

    End Sub

    Private Sub FeesButton_Click(sender As Object, e As EventArgs) Handles FeesButton.Click
        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        TutorButton.Location = New Point(1, 511)
        FeesButton.Location = New Point(1, -2)
        RecordsButton.Location = New Point(1, 473)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = True
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 2)
        LearnerIcon.Location = New Point(3, 554)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub LearnersButton_Click(sender As Object, e As EventArgs) Handles LearnersButton.Click
        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, -2)
        FeesButton.Location = New Point(1, 549)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, 511)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = True
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 553)
        LearnerIcon.Location = New Point(3, 2)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click
        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, -2)
        LearnersButton.Location = New Point(1, 587)
        FeesButton.Location = New Point(1, 549)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, 511)
        SchedulingButton.Location = New Point(1, 435)

        SetupPanel.Visible = True
        LoginPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 553)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 2)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RecordsButton.Click
        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        FeesButton.Location = New Point(1, 511)
        RecordsButton.Location = New Point(1, -2)
        TutorButton.Location = New Point(1, 473)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = True
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 2)
        TutorIcon.Location = New Point(3, 477)
        FeesIcon.Location = New Point(3, 515)
        LearnerIcon.Location = New Point(3, 553)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub TutorButton_Click(sender As Object, e As EventArgs) Handles TutorButton.Click
        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        FeesButton.Location = New Point(1, 511)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, -2)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = True
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = True
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 2)
        FeesIcon.Location = New Point(3, 515)
        LearnerIcon.Location = New Point(3, 553)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub
    Private Sub SchedulingButton_Click(sender As Object, e As EventArgs) Handles SchedulingButton.Click
        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = True

        LogOutButton.Location = New Point(0, 663)
        SchedulingButton.Location = New Point(0, -2)
        SetupButton.Location = New Point(0, 625)
        LearnersButton.Location = New Point(0, 587)
        FeesButton.Location = New Point(0, 549)
        RecordsButton.Location = New Point(0, 473)
        TutorButton.Location = New Point(0, 511)
        LoginButton.Location = New Point(0, 435)

        LogOutPicBox.Location = New Point(3, 667)
        ClosedLockIcon.Location = New Point(3, 440)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 554)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 629)
        SchedulingIcon.Location = New Point(5, 2)

    End Sub

    Private Sub GenInfoLabel_Click(sender As Object, e As EventArgs) Handles GenInfoLabel.Click
        GeInfoForm.Show()

    End Sub

    Private Sub CreatePOALabel_Click(sender As Object, e As EventArgs) Handles CreatePOALabel.Click
        CreatePOA.Show()

    End Sub

    Private Sub ViewPOALabel_Click(sender As Object, e As EventArgs) Handles ViewPOALabel.Click

        ViewPOA.Show()
    End Sub

    Private Sub CapMarkLabel_Click(sender As Object, e As EventArgs) Handles CapMarkLabel.Click

        CaptureMarks.Show()
    End Sub

    Private Sub GenReportLabel_Click(sender As Object, e As EventArgs) Handles GenReportLabel.Click

        T1Report.Show()
    End Sub

    Private Sub PrintLearnerCompLabel_Click(sender As Object, e As EventArgs) Handles PrintLearnerCompLabel.Click
        RptLComposite.Show()
    End Sub

    Private Sub PrintYearCompLabel_Click(sender As Object, e As EventArgs) Handles PrintYearCompLabel.Click

        YeComposite.Show()
    End Sub

    Private Sub AddLearnerLabel_Click(sender As Object, e As EventArgs) Handles AddLearnerLabel.Click

        AddLearner.Show()
    End Sub

    Private Sub EditLearnerLabel_Click(sender As Object, e As EventArgs)

        EditLearnerForm.Show()
    End Sub

    Private Sub ViewLearnerLabel_Click(sender As Object, e As EventArgs) Handles ViewLearnerLabel.Click

        ViewLearner.Show()
    End Sub

    Private Sub AssSubLabel_Click(sender As Object, e As EventArgs) Handles AssSubLabel.Click

        AssignSubjects.Show()
    End Sub



    Private Sub ReturninLearnerLabel_Click(sender As Object, e As EventArgs) Handles ReturninLearnerLabel.Click

        ReturningLearners.Show()
    End Sub

    Private Sub SubChngLabel_Click(sender As Object, e As EventArgs) Handles SubChngLabel.Click

        SubjectChange.Show()
    End Sub

    Private Sub OpenAccLabel_Click(sender As Object, e As EventArgs) Handles OpenAccLabel.Click

        OpenAccount.Show()
    End Sub

    Private Sub OpeningBalLabel_Click(sender As Object, e As EventArgs)

        OpeningBalance.Show()
    End Sub

    Private Sub RecordFeesLabel_Click(sender As Object, e As EventArgs) Handles RecordFeesLabel.Click

        Record_Fees.Show()
    End Sub

    Private Sub RecordDisLabel_Click(sender As Object, e As EventArgs) Handles RecordDisLabel.Click

        RecordDiscount.Show()
    End Sub

    Private Sub RecordPaymentRecLabel_Click(sender As Object, e As EventArgs) Handles RecordPaymentRecLabel.Click

        RecordPaymentReciepts.Show()
    End Sub

    Private Sub PrintFeeBalLabel_Click(sender As Object, e As EventArgs) 

        PrintFeeBalance.Show()
    End Sub

    Private Sub ListOfGradesLabel_Click(sender As Object, e As EventArgs) Handles ListOfGradesLabel.Click

        ListOfGradesForm.Show()
    End Sub

    Private Sub TermInfoLabel_Click(sender As Object, e As EventArgs) Handles TermInfoLabel.Click

        TermInfoForm.Show()
    End Sub

    Private Sub ManageUsersLabel_Click(sender As Object, e As EventArgs) Handles ManageUsersLabel.Click

        ManageUsersForm.Show()
    End Sub

    Private Sub BaseSubLabel_Click(sender As Object, e As EventArgs) Handles BaseSubLabel.Click
        ListOfBaseSubjects.Show()

    End Sub

    Private Sub AssignSubLabel_Click(sender As Object, e As EventArgs) Handles AssignSubLabel.Click

        AssignSubjectstoGrade.Show()
    End Sub

    Private Sub OutstandingMarkLabel_Click(sender As Object, e As EventArgs) Handles OutstandingMarkLabel.Click

        OutstandingMarksForm.Show()
    End Sub

    Private Sub GenFeeStLabel_Click(sender As Object, e As EventArgs) Handles GenFeeStLabel.Click
        MonthlyStatement.Show()

    End Sub

    Private Sub SubTakenLabel_Click(sender As Object, e As EventArgs) Handles SubTakenLabel.Click

        ListTakingSubject.Show()
    End Sub

    Private Sub TransferLabel_Click(sender As Object, e As EventArgs) Handles TransferLabel.Click

        TransferOutForm.Show()
    End Sub

    Private Sub TypeOfAssLabel_Click(sender As Object, e As EventArgs) Handles TypeOfAssLabel.Click
        CloseTerm.Show()
    End Sub


    Private Sub CloseYearLabel_Click(sender As Object, e As EventArgs) Handles CloseYearLabel.Click

        CloseYearFormvb.Show()
    End Sub

    Private Sub AddTutorLabel_Click(sender As Object, e As EventArgs) Handles AddTutorLabel.Click

        AddTutor.Show()
    End Sub

    Private Sub ViewTutorLabel_Click(sender As Object, e As EventArgs) Handles ViewTutorLabel.Click

        ViewTutor.Show()
    End Sub

    Private Sub ClockInLabel_Click(sender As Object, e As EventArgs) Handles ClockInLabel.Click
        AddTutorToSubjects.Show()
    End Sub

    Private Sub LoginLabel_Click(sender As Object, e As EventArgs) Handles LoginLabel.Click
        Login.Show()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        If vbYes = MsgBox("Are you sure you want to logout?", vbYesNo, "Log Out") Then
            Me.Close()
        End If
    End Sub

    Private Sub ClockOutLabel_Click(sender As Object, e As EventArgs) Handles ClockOutLabel.Click
        TutorRegister.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ViewTutorSalaries.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LstLearnerSubLabel.Click
        ListOfLearnersTakingSubject.Show()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles AddWorkingHours.Click
        TutorTimes.Show()

    End Sub

    Private Sub ChgPassLabel_Click(sender As Object, e As EventArgs) Handles ChgPassLabel.Click
        PasswordChange.Show()
    End Sub

    Private Sub Label2_Click_2(sender As Object, e As EventArgs) Handles SetupRoomsLabel.Click
        SetupRooms.Show()
    End Sub

    Private Sub Label2_Click_3(sender As Object, e As EventArgs) Handles Label2.Click
        GradeData.Show()
    End Sub

    Private Sub GeneralAccount_Click(sender As Object, e As EventArgs) Handles GeneralAccount.Click
        GeneralReports.Show()
    End Sub

    Private Sub SubjectBreakdownLabel_Click(sender As Object, e As EventArgs) Handles SubjectBreakdownLabel.Click
        SubjectBreakdown.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AccountsinArrears.Click
        ArrearsListings.Show()
    End Sub

    Private Sub LabelApplications_Click(sender As Object, e As EventArgs) Handles LabelApplications.Click
        Applications.Show()
    End Sub

    Private Sub CreateTTable_Click(sender As Object, e As EventArgs) Handles CreateTTable.Click
        CreateTimetable.Show()
    End Sub

    Private Sub ViewTT_Click(sender As Object, e As EventArgs) Handles ViewTT.Click
        ViewTimetable.Show()
    End Sub

    Private Sub CreateExamTT_Click(sender As Object, e As EventArgs) Handles CreateExamTT.Click
        '   CreateExamTimeTable.Show()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        '  ViewExamTimetable.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (open) Then

            Button1.Text = ">"
            Panel1.Location = New Point(0, 0)

            Button1.Location = New Point(48, 0)
            LoginButton.Visible = False
            LogOutButton.Visible = False
            SchedulingButton.Visible = False
            RecordsButton.Visible = False
            TutorButton.Visible = False
            FeesButton.Visible = False
            LearnersButton.Visible = False
            SetupButton.Visible = False
            Panel2.Visible = False

            LoginPanel.Visible = False
            SetupPanel.Visible = False
            LearnersPanel.Visible = False
            FeesPanel.Visible = False
            RecordsPanel.Visible = False
            TutorPanel.Visible = False
            SchedulingPanel.Visible = False

            LoginPanel.Visible = False
            SchedulingIcon.Visible = False

            Min1.Visible = True
            Min2.Visible = True
            Min3.Visible = True
            Min4.Visible = True
            Min5.Visible = True
            Min6.Visible = True
            Min7.Visible = True
            Min8.Visible = True

            Min6.Location = New Point(0, 504)
            Min3.Location = New Point(0, 544)
            Min1.Location = New Point(0, 424)
            Min5.Location = New Point(0, 464)
            Min8.Location = New Point(0, 624)
            Min2.Location = New Point(0, 664)
            Min4.Location = New Point(0, 384)
            Min7.Location = New Point(0, 584)

            ClosedLockIcon.Location = New Point(3, 439)
            RecordsIcon.Location = New Point(3, 477)
            TutorIcon.Location = New Point(3, 515)
            FeesIcon.Location = New Point(3, 553)
            LearnerIcon.Location = New Point(3, 591)
            SetupIcon.Location = New Point(3, 629)
            SchedulingIcon.Location = New Point(3, 400)
            LogOutPicBox.Location = New Point(3, 667)

            open = False
            Panel1.Visible = True
        ElseIf Not (open) Then
            Button1.Location = New Point(219, 0)
            Panel1.Visible = False
            Button1.Text = "<"

            LoginButton.Visible = True
            LogOutButton.Visible = True
            SchedulingButton.Visible = True
            RecordsButton.Visible = True
            TutorButton.Visible = True
            FeesButton.Visible = True
            LearnersButton.Visible = True
            SetupButton.Visible = True
            Panel2.Visible = True

            LogOutButton.Location = New Point(0, 663)
            SchedulingButton.Location = New Point(0, 397)
            SetupButton.Location = New Point(0, 625)
            LearnersButton.Location = New Point(0, 587)
            FeesButton.Location = New Point(0, 549)
            RecordsButton.Location = New Point(0, 473)
            TutorButton.Location = New Point(0, 511)
            LoginButton.Location = New Point(0, 435)


            Min1.Visible = False
            Min2.Visible = False
            Min3.Visible = False
            Min4.Visible = False
            Min5.Visible = False
            Min6.Visible = False
            Min7.Visible = False
            Min8.Visible = False

            ClosedLockIcon.Location = New Point(3, 439)
            RecordsIcon.Location = New Point(3, 477)
            TutorIcon.Location = New Point(3, 515)
            FeesIcon.Location = New Point(3, 553)
            LearnerIcon.Location = New Point(3, 591)
            SetupIcon.Location = New Point(3, 629)
            SchedulingIcon.Location = New Point(3, 400)
            LogOutPicBox.Location = New Point(3, 667)
            SchedulingIcon.Visible = True
            open = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Min8_Click(sender As Object, e As EventArgs) Handles Min8.Click
        openPanel()

        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, -2)
        LearnersButton.Location = New Point(1, 587)
        FeesButton.Location = New Point(1, 549)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, 511)
        SchedulingButton.Location = New Point(1, 435)

        SetupPanel.Visible = True
        LoginPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 553)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 2)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub Min1_Click(sender As Object, e As EventArgs) Handles Min1.Click
        openPanel()

        LogOutButton.Location = New Point(0, 663)
        LoginButton.Location = New Point(0, -2)
        SetupButton.Location = New Point(0, 625)
        LearnersButton.Location = New Point(0, 587)
        FeesButton.Location = New Point(0, 549)
        RecordsButton.Location = New Point(0, 473)
        TutorButton.Location = New Point(0, 511)
        SchedulingButton.Location = New Point(1, 435)

        LogOutPicBox.Location = New Point(3, 667)
        ClosedLockIcon.Location = New Point(3, 2)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 554)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 629)
        SchedulingIcon.Location = New Point(4, 439)

        LoginPanel.Visible = True
        SetupPanel.Visible = False
        FeesPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False
    End Sub
    Public Sub openPanel()
        Button1.Location = New Point(219, 0)
        Panel1.Visible = False
        Button1.Text = "<"

        LoginButton.Visible = True
        LogOutButton.Visible = True
        SchedulingButton.Visible = True
        RecordsButton.Visible = True
        TutorButton.Visible = True
        FeesButton.Visible = True
        LearnersButton.Visible = True
        SetupButton.Visible = True
        Panel2.Visible = True

        LogOutButton.Location = New Point(0, 663)
        SchedulingButton.Location = New Point(0, 397)
        SetupButton.Location = New Point(0, 625)
        LearnersButton.Location = New Point(0, 587)
        FeesButton.Location = New Point(0, 549)
        RecordsButton.Location = New Point(0, 473)
        TutorButton.Location = New Point(0, 511)
        LoginButton.Location = New Point(0, 435)


        Min1.Visible = False
        Min2.Visible = False
        Min3.Visible = False
        Min4.Visible = False
        Min5.Visible = False
        Min6.Visible = False
        Min7.Visible = False
        Min8.Visible = False

        ClosedLockIcon.Location = New Point(3, 439)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 553)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 629)
        SchedulingIcon.Location = New Point(3, 400)
        LogOutPicBox.Location = New Point(3, 667)
        SchedulingIcon.Visible = True
        open = True
    End Sub

    Private Sub Min4_Click(sender As Object, e As EventArgs) Handles Min4.Click
        openPanel()
        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = True

        LogOutButton.Location = New Point(0, 663)
        SchedulingButton.Location = New Point(0, -2)
        SetupButton.Location = New Point(0, 625)
        LearnersButton.Location = New Point(0, 587)
        FeesButton.Location = New Point(0, 549)
        RecordsButton.Location = New Point(0, 473)
        TutorButton.Location = New Point(0, 511)
        LoginButton.Location = New Point(0, 435)

        LogOutPicBox.Location = New Point(3, 667)
        ClosedLockIcon.Location = New Point(3, 440)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 554)
        LearnerIcon.Location = New Point(3, 591)
        SetupIcon.Location = New Point(3, 629)
        SchedulingIcon.Location = New Point(5, 2)
    End Sub

    Private Sub Min2_Click(sender As Object, e As EventArgs) Handles Min2.Click
        openPanel()
        If vbYes = MsgBox("Are you sure you want to logout?", vbYesNo, "Log Out") Then
            Me.Close()
        End If

    End Sub

    Private Sub Min3_Click(sender As Object, e As EventArgs) Handles Min3.Click
        openPanel()

        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        TutorButton.Location = New Point(1, 511)
        FeesButton.Location = New Point(1, -2)
        RecordsButton.Location = New Point(1, 473)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = False
        FeesPanel.Visible = True
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 2)
        LearnerIcon.Location = New Point(3, 554)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub Min7_Click(sender As Object, e As EventArgs) Handles Min7.Click
        openPanel()

        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, -2)
        FeesButton.Location = New Point(1, 549)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, 511)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = False
        LearnersPanel.Visible = True
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 515)
        FeesIcon.Location = New Point(3, 553)
        LearnerIcon.Location = New Point(3, 2)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub Min6_Click(sender As Object, e As EventArgs) Handles Min6.Click
        openPanel()

        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        FeesButton.Location = New Point(1, 511)
        RecordsButton.Location = New Point(1, 473)
        TutorButton.Location = New Point(1, -2)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = True
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = True
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 477)
        TutorIcon.Location = New Point(3, 2)
        FeesIcon.Location = New Point(3, 515)
        LearnerIcon.Location = New Point(3, 553)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub

    Private Sub Min5_Click(sender As Object, e As EventArgs) Handles Min5.Click
        openPanel()

        LoginButton.Location = New Point(1, 625)
        SetupButton.Location = New Point(1, 587)
        LearnersButton.Location = New Point(1, 549)
        FeesButton.Location = New Point(1, 511)
        RecordsButton.Location = New Point(1, -2)
        TutorButton.Location = New Point(1, 473)
        SchedulingButton.Location = New Point(1, 435)

        LoginPanel.Visible = False
        SetupPanel.Visible = False
        RecordsPanel.Visible = True
        LearnersPanel.Visible = False
        FeesPanel.Visible = False
        TutorPanel.Visible = False
        SchedulingPanel.Visible = False

        ClosedLockIcon.Location = New Point(3, 629)
        RecordsIcon.Location = New Point(3, 2)
        TutorIcon.Location = New Point(3, 477)
        FeesIcon.Location = New Point(3, 515)
        LearnerIcon.Location = New Point(3, 553)
        SetupIcon.Location = New Point(3, 591)
        SchedulingIcon.Location = New Point(4, 439)
    End Sub
End Class
