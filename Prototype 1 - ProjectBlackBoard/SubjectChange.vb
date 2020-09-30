
Public Class SubjectChange
    Private SQL As New DataBaseControl
    Dim GradeID As String
    Dim SubjectID As String
    Dim name As String
    Dim LearnerID As Integer

    Dim newSubGradeID As String
    Dim newSubjectID As String
    Dim newGradeID As String

    Dim oldSubGradeID As String
    Dim oldSubjectID As String
    Dim oldGradeID As String

    Dim isThere As Boolean = False
    Dim numOfActiveTerms = 0
    Public Sub populateGradeComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT GradeID, convert(varChar(6),GradeID) FROM tblGrade WHERE isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
            GradeComboBox.ValueMember = "GradeID"
        End If
    End Sub
    Public Sub populateNameComboBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblLearner.LearnerID,tblLearner.LName,tblLearner.LSurname FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.GRADEID = '" & GradeID & "' AND tblLearner.LStatus = '" & 1 & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows

                    Dim nameAndID As String = SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID").ToString + " " + "-" + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LName").ToString + " " + SQL.SQLDataSet.Tables(0).Rows(y).Item("LSurname").ToString
                    NameComboBox.Items.Add(nameAndID)
                    y = y + 1
                Next x
            End If
            NameComboBox.ValueMember = "LName"
        End If
    End Sub
    Public Sub populateAvailableSubjectsListBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT tblSubject.SubjectName FROM (tblSubject INNER JOIN tblSubGrade ON tblSubject.SubjectID = tblSubGrade.SubjectID) WHERE tblSubGrade.GRADEID = '" & GradeID & "' AND tblSubGrade.isOffered = '1'")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    AvailableSubjectListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
            AvailableSubjectListBox.ValueMember = "SubjectName"

        End If
    End Sub
    Public Sub populateSubjectsListBox()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblSubject.SubjectName, tblSubject.SubjectID, tblSubGrade.SubjectID, tblSubGrade.GradeID,tblEnrolment.SubjectID AS Expr1,tblEnrolment.GradeID as Expr2 FROM tblSubject INNER JOIN tblSubGrade ON tblSubject.SubjectID = tblSubGrade.SubjectID 
                          INNER JOIN tblEnrolment ON tblSubGrade.SubjectID = tblEnrolment.SubjectID AND tblSubGrade.GradeID = tblEnrolment.GradeID 
                            WHERE (tblEnrolment.LearnerID = '" & LearnerID & "' AND tblSubGrade.GradeID ='" & GradeID & "' AND tblEnrolment.Active ='" & True & "')")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    CurrentSubjectsListBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectName"))
                    y = y + 1
                Next x
            End If
            CurrentSubjectsListBox.ValueMember = "SubjectName"

        End If
    End Sub


    Private Sub SubjectChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        populateGradeComboBox()
        checkTerm()
        If (numOfActiveTerms = 1) Then
            CheckBox8.Enabled = False
        End If
        If (numOfActiveTerms = 2) Then
            CheckBox8.Enabled = False
            CheckBox7.Enabled = False
        End If
        If (numOfActiveTerms = 3) Then
            CheckBox8.Enabled = False
            CheckBox7.Enabled = False
            CheckBox6.Enabled = False
        End If
        If (numOfActiveTerms = 4) Then
            CheckBox8.Enabled = False
            CheckBox7.Enabled = False
            CheckBox6.Enabled = False
            CheckBox5.Enabled = False
            MessageBox.Show("Its too late to change subjects now!", "End of the year")
            Me.Close()
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
        NameComboBox.Items.Clear()
        populateNameComboBox()

        AvailableSubjectListBox.Items.Clear()
        populateAvailableSubjectsListBox()
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

        LearnerID = (NameComboBox.SelectedItem.ToString.Substring(0, NameComboBox.SelectedItem.ToString.IndexOf(" ")))

        CurrentSubjectsListBox.Items.Clear()
        populateSubjectsListBox()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If MessageBox.Show("Are you sure you want to change this learners subjects ?", "Confirmation Of Subject Change ", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            If SQL.HasConnnection = True Then

                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                SQL.RunQuery("SELECT tblSubGrade.SubjectID,tblSubGrade.GradeID FROM tblSubGrade INNER JOIN tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE (tblSubject.SubjectName = '" & CurrentSubjectsListBox.SelectedItem & "' AND tblSubGrade.GradeID = '" & GradeID & "' )")
                oldSubjectID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID").ToString
                oldGradeID = SQL.SQLDataSet.Tables(0).Rows(0).Item("GradeID").ToString

                SQL.RunQuery("SELECT tblSubGrade.SubjectID,tblSubGrade.GradeID From tblSubGrade INNER Join tblSubject On tblSubGrade.SubjectID = tblSubject.SubjectID Where (tblSubject.SubjectName = '" & AvailableSubjectListBox.SelectedItem & "' AND tblSubGrade.GradeID = '" & GradeID & "')")
                newSubjectID = SQL.SQLDataSet.Tables(0).Rows(0).Item("SubjectID")
                newGradeID = SQL.SQLDataSet.Tables(0).Rows(0).Item("GradeID")
                Dim AcademicYear As Integer = Convert.ToInt32(Now.ToString("yyyy"))

                For a = 0 To CurrentSubjectsListBox.Items.Count - 1

                    If (CurrentSubjectsListBox.Items(a).ToString = AvailableSubjectListBox.SelectedItem) Then
                        isThere = True
                    End If
                Next




                If (CheckBox8.Checked = True And CheckBox7.Checked = True And CheckBox6.Checked = True And CheckBox5.Checked = True) Then

                    SQL.RunQuery("Update tblEnrolment SET Active = '" & False & "', TermOne = '" & 0 & "',TermTwo = '" & 0 & "',TermThree = '" & 0 & "',TermFour = '" & 0 & "' WHERE LearnerID = '" & LearnerID & "' AND SubjectID = '" & oldSubjectID & "' AND GradeID = '" & oldGradeID & "' ")

                    SQL.RunQuery(" Select LearnerID, Active, SubGradeID From tblEnrolment Where (LearnerID = '" & LearnerID & "') And (SubjectID = '" & newSubjectID & "') And (GradeID = '" & newGradeID & "')")

                    If (SQL.SQLDataSet.Tables(0).Rows.Count = 0) Then
                        SQL.RunQuery("INSERT INTO tblEnrolment (LearnerID, AcademicYear, TermOne, TermTwo, TermThree, TermFour, Active, SubjectID,GradeID)VALUES('" & LearnerID & "','" & AcademicYear & "','" & 1 & "','" & 1 & "','" & 1 & "','" & 1 & "','" & 1 & "','" & newSubjectID & "','" & newGradeID & "')")
                        MessageBox.Show("Subjects were change!", "Subjects Changed Successfully")

                        Else
                        SQL.RunQuery("Update tblEnrolment SET Active = '" & True & "',  TermOne = '" & 1 & "',TermTwo = '" & 1 & "',TermThree = '" & 1 & "',TermFour = '" & 1 & "' WHERE (tblEnrolment.LearnerID ='" & LearnerID & "') And (SubjectID = '" & newSubjectID & "')  And (GradeID = '" & newGradeID & "')")
                        MessageBox.Show("Learner re-enrolled for " + AvailableSubjectListBox.SelectedItem.ToString, "Learner Re-Enrolled")

                        End If
                    Else

                        If (CheckBox8.Checked = True Or CheckBox7.Checked = True Or CheckBox6.Checked = True Or CheckBox5.Checked = True) Then

                            Dim Term1 As Integer = 0
                            Dim Term2 As Integer = 0
                            Dim Term3 As Integer = 0
                            Dim Term4 As Integer = 0

                            Dim OTerm1 As Integer = 0
                            Dim OTerm2 As Integer = 0
                            Dim OTerm3 As Integer = 0
                            Dim OTerm4 As Integer = 0

                            If (CheckBox8.Checked = True) Then
                                Term1 = 1
                            End If
                            If (CheckBox7.Checked = True) Then
                                Term2 = 1
                            End If
                            If (CheckBox6.Checked = True) Then
                                Term3 = 1
                            End If
                            If (CheckBox5.Checked = True) Then
                                Term4 = 1
                            End If

                            If (CheckBox1.Checked = True) Then
                                OTerm1 = 1
                            End If
                            If (CheckBox2.Checked = True) Then
                                OTerm2 = 1
                            End If
                            If (CheckBox3.Checked = True) Then
                                OTerm3 = 1
                            End If
                            If (CheckBox4.Checked = True) Then
                                OTerm4 = 1
                            End If

                        SQL.RunQuery("Update tblEnrolment SET Active = '" & True & "', TermOne = '" & OTerm1 & "',TermTwo = '" & OTerm2 & "',TermThree = '" & OTerm3 & "',TermFour = '" & OTerm4 & "' WHERE LearnerID = '" & LearnerID & "' AND SubjectID = '" & oldSubjectID & "' AND GradeID = '" & oldGradeID & "'")

                        SQL.RunQuery("Select LearnerID, Active, SubjectID,GradeID From tblEnrolment Where (LearnerID = '" & LearnerID & "') And (SubjectID = '" & newSubjectID & "')  And (GradeID = '" & newGradeID & "')")
                        If (SQL.SQLDataSet.Tables(0).Rows.Count = 0) Then
                            SQL.RunQuery("INSERT INTO tblEnrolment (LearnerID, AcademicYear, TermOne, TermTwo, TermThree, TermFour, Active, SubjectID,GradeID)VALUES('" & LearnerID & "','" & AcademicYear & "','" & Term1 & "','" & Term2 & "','" & Term3 & "','" & Term4 & "','" & 1 & "','" & newSubjectID & "','" & newGradeID & "')")
                            MessageBox.Show("Subjects were changed!", "Subjects Changed Successfully")
                        Else
                            SQL.RunQuery("Update tblEnrolment SET Active = '" & True & "',  TermOne = '" & Term1 & "',TermTwo = '" & Term2 & "',TermThree = '" & Term3 & "',TermFour = '" & Term4 & "' WHERE (tblEnrolment.LearnerID ='" & LearnerID & "') And (SubjectID = '" & newSubjectID & "') And (GradeID = '" & newGradeID & "') ")
                            MessageBox.Show("Learner re-enrolled for " + AvailableSubjectListBox.SelectedItem.ToString, "Learner Re-Enrolled")
                            End If
                        End If


                        If (CheckBox8.Checked = False And CheckBox7.Checked = False And CheckBox6.Checked = False And CheckBox5.Checked = False) Then
                            MessageBox.Show("Please select the terms the learner should be enrolled in the subject.")
                        End If
                    End If

                End If


            CurrentSubjectsListBox.Items.Clear()
            populateSubjectsListBox()

            CheckBox8.Checked = False
            CheckBox7.Checked = False
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            CheckBox4.Checked = False
            CheckBox3.Checked = False
            CheckBox2.Checked = False
            CheckBox1.Checked = False

        End If
    End Sub

    Private Sub CurrentSubjectsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CurrentSubjectsListBox.SelectedIndexChanged
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        SQL.RunQuery("Select tblEnrolment.LearnerID, tblEnrolment.TermOne, tblEnrolment.TermTwo, tblEnrolment.TermThree, tblEnrolment.TermFour, tblEnrolment.Active From tblEnrolment INNER Join tblSubGrade On tblEnrolment.SubjectID = tblSubGrade.SubjectID AND tblEnrolment.GradeID = tblSubGrade.GradeID INNER Join tblSubject On tblSubGrade.SubjectID = tblSubject.SubjectID Where (tblEnrolment.LearnerID = '" & LearnerID & "') And (tblEnrolment.Active = '" & True & "') And (tblSubject.SubjectName = '" & CurrentSubjectsListBox.SelectedItem & "') And (tblSubGrade.GradeID = '" & GradeID & "')")
        If (SQL.SQLDataSet.Tables(0).Rows(0).Item("TermOne") = True) Then
            CheckBox1.Checked = True
        End If
        If (SQL.SQLDataSet.Tables(0).Rows(0).Item("TermTwo") = True) Then
            CheckBox2.Checked = True
        End If
        If (SQL.SQLDataSet.Tables(0).Rows(0).Item("TermThree") = True) Then
            CheckBox3.Checked = True
        End If
        If (SQL.SQLDataSet.Tables(0).Rows(0).Item("TermFour") = True) Then
            CheckBox4.Checked = True
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If (CheckBox8.Checked = True) Then
            CheckBox1.Checked = False
        End If
        If (CheckBox8.Checked = False) Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If (CheckBox7.Checked = True) Then
            CheckBox2.Checked = False
        End If
        If (CheckBox7.Checked = False) Then
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If (CheckBox6.Checked = True) Then
            CheckBox3.Checked = False
        End If
        If (CheckBox6.Checked = False) Then
            CheckBox3.Checked = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If (CheckBox5.Checked = True) Then
            CheckBox4.Checked = False
        End If
        If (CheckBox5.Checked = False) Then
            CheckBox4.Checked = True
        End If
    End Sub
    Public Sub checkTerm()
        numOfActiveTerms = 0
        If SQL.HasConnnection = True Then

            SQL.RunQuery("Select * from tblTerm")

            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    If (SQL.SQLDataSet.Tables(0).Rows(y).Item("Status") = False) Then
                        numOfActiveTerms = numOfActiveTerms + 1
                    End If
                    y = y + 1
                Next x
            End If

        End If
    End Sub
End Class