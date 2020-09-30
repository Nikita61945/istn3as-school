Public Class Login
    Dim Sql As New DataBaseControl
    Dim msg As String = vbNewLine
    Dim user As String
    Public userID As Integer
    Dim userCategory As String

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Sql.HasConnnection = True Then

            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If
            msg = vbNewLine
            If ((UsernameTextBox.Text.Length <> 0) And (PasswordTextBox.Text.Length <> 0)) Then

                Sql.RunQuery("SELECT Username FROM tblUser WHERE Username = '" & UsernameTextBox.Text & "'")
                If (Sql.SQLDataSet.Tables(0).Rows.Count = 0) Then
                    msg = vbNewLine + "User does not exist"
                End If
                If Sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                    msg = vbNewLine
                    Sql.RunQuery("SELECT UserPassword FROM tblUser WHERE Username = '" & UsernameTextBox.Text & "'")
                    If Sql.SQLDataSet.Tables(0).Rows.Count Then

                        If Sql.SQLDataSet.Tables(0).Rows(0).Item("UserPassword").ToString = PasswordTextBox.Text.ToString Then
                            msg = "Welcome " + UsernameTextBox.Text.ToString
                            Sql.RunQuery("SELECT tblUser.* FROM tblUser WHERE (UserName = '" & UsernameTextBox.Text & "' AND UserPassword = '" & PasswordTextBox.Text & "')")
                            userCategory = Sql.SQLDataSet.Tables(0).Rows(0).Item("UserCategory").ToString
                            userID = Integer.Parse(Sql.SQLDataSet.Tables(0).Rows(0).Item("UserID"))
                            setAccess(userCategory)

                            Me.Close()
                        ElseIf (Sql.SQLDataSet.Tables(0).Rows(0).Item("UserPassword").ToString <> PasswordTextBox.Text.ToString) Then
                            msg = vbNewLine + "Invaild Password!"
                        End If
                    End If
                End If
            Else
                If (UsernameTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "No username entered!"
                End If
                If (PasswordTextBox.Text.Length = 0) Then
                    msg = msg + vbNewLine + "No password entered!"
                End If

            End If
            MessageBox.Show(msg, "Login Status")
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Public Sub setAccess(userCat As String)


        If (userCat = "Admin") Then
            Form1.ListOfGradesLabel.Enabled = True
            Form1.BaseSubLabel.Enabled = True
            Form1.TypeOfAssLabel.Enabled = True
            Form1.TermInfoLabel.Enabled = True
            Form1.CloseYearLabel.Enabled = True
            Form1.AddLearnerLabel.Enabled = True
            Form1.ViewLearnerLabel.Enabled = True
            ViewLearner.Button1.Enabled = True
            Form1.GenInfoLabel.Enabled = True
            Form1.AssSubLabel.Enabled = True
            Form1.SubTakenLabel.Enabled = True
            Form1.TransferLabel.Enabled = True
            Form1.ReturninLearnerLabel.Enabled = True
            Form1.SubChngLabel.Enabled = True
            Form1.CreatePOALabel.Enabled = True
            Form1.ViewPOALabel.Enabled = True
            Form1.CapMarkLabel.Enabled = True
            Form1.OutstandingMarkLabel.Enabled = True
            Form1.PrintTermCompLabel.Enabled = True
            Form1.PrintLearnerCompLabel.Enabled = True
            Form1.PrintYearCompLabel.Enabled = True
            Form1.GenReportLabel.Enabled = True
            Form1.OpenAccLabel.Enabled = True
            Form1.RecordFeesLabel.Enabled = True
            Form1.RecordDisLabel.Enabled = True
            Form1.RecordPaymentRecLabel.Enabled = True
            Form1.GenFeeStLabel.Enabled = True
            Form1.CloseYearLabel.Location = New Point(7, 101)
            Form1.ManageUsersLabel.Location = New Point(7, 166)
            Form1.AssignSubLabel.Visible = False
            Form1.ManageUsersLabel.Visible = False
            Form1.LstLearnerSubLabel.Enabled = True
            Form1.LstLearnerSubLabel.Visible = True
            Form1.RecordsButton.Enabled = True
            Form1.FeesButton.Enabled = True
            Form1.LearnersButton.Enabled = True
            Form1.SetupButton.Enabled = True
            Form1.TutorButton.Enabled = True
            ViewLearner.Button1.Enabled = True
            Form1.SchedulingButton.Enabled = True

        ElseIf (userCat = "Owner") Then
            Form1.PrintYearCompLabel.Enabled = True
            Form1.PrintLearnerCompLabel.Enabled = True
            Form1.OutstandingMarkLabel.Enabled = True
            Form1.PrintTermCompLabel.Enabled = True
            Form1.CapMarkLabel.Enabled = True
            Form1.ViewLearnerLabel.Enabled = True
            Form1.GenInfoLabel.Enabled = True
            Form1.SubTakenLabel.Enabled = True
            Form1.ViewPOALabel.Enabled = True
            Form1.GenFeeStLabel.Enabled = True
            Form1.AddTutorLabel.Enabled = True
            Form1.ViewTutorLabel.Enabled = True
            Form1.ManageUsersLabel.Enabled = True
            Form1.GenReportLabel.Enabled = True
            Form1.ClockInLabel.Enabled = True
            Form1.Label1.Enabled = True
            Form1.ClockOutLabel.Enabled = True
            Form1.OpenAccLabel.Enabled = True
            Form1.RecordFeesLabel.Enabled = True
            Form1.RecordDisLabel.Enabled = True
            Form1.RecordPaymentRecLabel.Enabled = True
            Form1.AddLearnerLabel.Enabled = True
            Form1.AssSubLabel.Enabled = True
            Form1.TransferLabel.Enabled = True
            Form1.ReturninLearnerLabel.Enabled = True
            Form1.SubChngLabel.Enabled = True
            Form1.ListOfGradesLabel.Enabled = True
            Form1.TypeOfAssLabel.Enabled = True
            Form1.TermInfoLabel.Enabled = True
            Form1.BaseSubLabel.Enabled = True
            Form1.AssignSubLabel.Enabled = True
            Form1.CloseYearLabel.Enabled = True
            Form1.CreatePOALabel.Enabled = True
            Form1.LstLearnerSubLabel.Enabled = True
            Form1.RecordsButton.Enabled = True
            Form1.FeesButton.Enabled = True
            Form1.LearnersButton.Enabled = True
            Form1.SetupButton.Enabled = True
            Form1.TutorButton.Enabled = True
            ViewLearner.Button1.Enabled = True
            Form1.AddWorkingHours.Enabled = True
            Form1.SetupRoomsLabel.Enabled = True
            Form1.Label1.Enabled = True
            Form1.GeneralAccount.Enabled = True
            Form1.SubjectBreakdownLabel.Enabled = True
            Form1.AccountsinArrears.Enabled = True
            Form1.LabelApplications.Enabled = True
            Form1.SchedulingButton.Enabled = True

        ElseIf (userCat = "Tutor") Then
            Form1.PrintYearCompLabel.Enabled = True
            Form1.PrintLearnerCompLabel.Enabled = True
            Form1.PrintTermCompLabel.Enabled = True
            Form1.OutstandingMarkLabel.Enabled = True
            Form1.CapMarkLabel.Enabled = True
            Form1.ViewPOALabel.Enabled = True
            Form1.ViewLearnerLabel.Enabled = True
            Form1.SubTakenLabel.Enabled = True
            Form1.LstLearnerSubLabel.Visible = True
            Form1.RecordsButton.Enabled = True
            Form1.LearnersButton.Enabled = True
            Form1.SetupButton.Enabled = False
            Form1.FeesButton.Enabled = False
            Form1.TutorButton.Enabled = False
            Form1.LstLearnerSubLabel.Enabled = True
            Form1.ViewLearnerLabel.Location = New Point(7, 11)
            Form1.SubTakenLabel.Location = New Point(7, 33)

            Form1.AssSubLabel.Visible = False
            Form1.AddLearnerLabel.Visible = False
            Form1.TransferLabel.Visible = False
            Form1.ReturninLearnerLabel.Visible = False
            Form1.SubChngLabel.Visible = False

            Form1.CreatePOALabel.Visible = False
            Form1.GenReportLabel.Visible = False

            Form1.ViewPOALabel.Location = New Point(7, 11)
            Form1.CapMarkLabel.Location = New Point(7, 35)
            Form1.OutstandingMarkLabel.Location = New Point(7, 59)
            Form1.PrintTermCompLabel.Location = New Point(7, 83)
            Form1.PrintLearnerCompLabel.Location = New Point(7, 107)
            Form1.PrintYearCompLabel.Location = New Point(7, 131)

        End If

        Form1.LoginLabel.Enabled = False
        Form1.LoginLabel.Visible = False
        Form1.LogOutButton.Visible = True
        Form1.LogOutButton.Enabled = True
        Form1.ClosedLockIcon.Image = My.Resources.OpenLock
        Form1.LogOutPicBox.Visible = True

        Form1.LoginLabel.Location = New Point(7, 34)
        Form1.ChgPassLabel.Location = New Point(7, 11)


        Form1.LogOutButton.Location = New Point(0, 663)
        Form1.LoginButton.Location = New Point(0, -2)
        Form1.SetupButton.Location = New Point(0, 625)
        Form1.LearnersButton.Location = New Point(0, 587)
        Form1.FeesButton.Location = New Point(0, 549)
        Form1.RecordsButton.Location = New Point(0, 473)
        Form1.TutorButton.Location = New Point(0, 511)
        Form1.SchedulingButton.Location = New Point(0, 435)

        Form1.LogOutPicBox.Location = New Point(3, 667)
        Form1.ClosedLockIcon.Location = New Point(3, 2)
        Form1.RecordsIcon.Location = New Point(3, 477)
        Form1.TutorIcon.Location = New Point(3, 515)
        Form1.FeesIcon.Location = New Point(3, 554)
        Form1.LearnerIcon.Location = New Point(3, 591)
        Form1.SetupIcon.Location = New Point(3, 629)
        Form1.SchedulingIcon.Location = New Point(3, 439)

        Form1.Button1.Enabled = True

    End Sub
End Class