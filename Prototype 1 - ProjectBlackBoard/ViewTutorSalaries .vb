Public Class ViewTutorSalaries
    Public SQl As New DataBaseControl

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewTutorSalaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        If SQl.HasConnnection = True Then
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            SQl.RunQuery("SELECT  TutorID,  convert(varChar(6),TutorID)+' '+FName +' '+Surname AS 'Identify' FROM tblTutor")
        If SQl.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQl.SQLDataSet.Tables(0).Rows
                TutorComboBox.Items.Add(SQl.SQLDataSet.Tables(0).Rows(y).Item("Identify"))

                y = y + 1
            Next x
        End If

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthComboBox.SelectedIndexChanged
        If SQl.HasConnnection = True Then
            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If
            monthlyRTB.Clear()

            SQl.RunQuery("Select tblTutor.FName + ' ' + tblTutor.Surname As 'Full Name' , Sum(tblRegister.HoursWorked) As 'Total Hours' , tblTutor.Salary From tblTutor, tblRegister Where tblRegister.TutorID = tblTutor.TutorID and WorkingDate LIke '" & DateTime.Today.Year.ToString + "-" + MonthComboBox.SelectedItem.ToString.Substring(0, 2) + "-__" & "' And tblRegister.TutorID  in (Select TutorID From tblTutor Where PaymentStyle = 'Hourly') Group By tblRegister.TutorID,tblTutor.FName,tblTutor.Surname,tblTutor.Salary ")
            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                monthlyRTB.AppendText("Tutor(s) paid Hourly" + Environment.NewLine)

                monthlyRTB.AppendText("Tutor Name" + vbTab + "Hours Worked" + vbTab + "Salary" + Environment.NewLine)
                For x As Integer = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1
                    monthlyRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("Full Name").ToString + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("Total Hours").ToString + vbTab + vbTab + FormatNumber((SQl.SQLDataSet.Tables(0).Rows(x).Item("Salary") * SQl.SQLDataSet.Tables(0).Rows(x).Item("Total Hours")).ToString, 2) + Environment.NewLine)
                Next x
            Else
                monthlyRTB.AppendText("No Tutors paid Hourly : " + Environment.NewLine)
            End If
            monthlyRTB.AppendText("____________________________________________________________________________" + Environment.NewLine)


            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If


            SQl.RunQuery("Select tblTutor.FName + ' ' + tblTutor.Surname As 'Full Name' , Count(*) As 'Days Worked' , tblTutor.Salary From tblTutor, tblRegister Where tblRegister.TutorID = tblTutor.TutorID and WorkingDate LIke '" & DateTime.Today.Year.ToString + "-" + MonthComboBox.SelectedItem.ToString.Substring(0, 2) + "-__" & "' And tblRegister.TutorID  in (Select TutorID From tblTutor Where PaymentStyle = 'Daily') Group By tblRegister.TutorID,tblTutor.FName,tblTutor.Surname,tblTutor.Salary ")
            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                monthlyRTB.AppendText("Tutor(s) paid Daily" + Environment.NewLine)

                monthlyRTB.AppendText("Tutor Name" + vbTab + "Days Worked" + vbTab + "Salary" + Environment.NewLine)
                For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1
                    monthlyRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("Full Name").ToString + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("Days Worked").ToString + vbTab + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("Salary").ToString + Environment.NewLine)
                Next x
            Else
                monthlyRTB.AppendText("No Tutors paid Daily" + Environment.NewLine)
            End If
            monthlyRTB.AppendText("____________________________________________________________________________" + Environment.NewLine)

            If SQl.SQLDataSet IsNot Nothing Then
                SQl.SQLDataSet.Clear()
            End If

            SQl.RunQuery("Select tblTutor.FName + ' ' + tblTutor.Surname As 'Full Name' , tblTutor.Salary From tblTutor, tblRegister Where tblRegister.TutorID = tblTutor.TutorID and WorkingDate LIke '" & DateTime.Today.Year.ToString + "-" + MonthComboBox.SelectedItem.ToString.Substring(0, 2) + "-__" & "' And tblRegister.TutorID  in (Select TutorID From tblTutor Where PaymentStyle = 'Weekly') Group By tblRegister.TutorID,tblTutor.FName,tblTutor.Surname,tblTutor.Salary ")
            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                monthlyRTB.AppendText("Tutor(s) paid Weekly" + Environment.NewLine)

                monthlyRTB.AppendText("Tutor Name " + vbTab + "Salary" + Environment.NewLine)

                For x As Integer = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1

                    monthlyRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("Full Name").ToString + (SQl.SQLDataSet.Tables(0).Rows(x).Item("Salary") * 4).ToString + Environment.NewLine)
                Next x

            Else
                monthlyRTB.AppendText("No Tutors paid Weekly" + Environment.NewLine)
            End If
            monthlyRTB.AppendText("____________________________________________________________________________" + Environment.NewLine)




            SQl.RunQuery("Select tblTutor.FName + ' ' + tblTutor.Surname As 'Full Name' , tblTutor.Salary From tblTutor, tblRegister Where tblRegister.TutorID = tblTutor.TutorID and WorkingDate LIke '" & DateTime.Today.Year.ToString + "-" + MonthComboBox.SelectedItem.ToString.Substring(0, 2) + "-__" & "' And tblRegister.TutorID  in (Select TutorID From tblTutor Where PaymentStyle = 'Monthly') Group By tblRegister.TutorID,tblTutor.FName,tblTutor.Surname,tblTutor.Salary ")

            If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                monthlyRTB.AppendText("Tutor(s) paid Monthly" + Environment.NewLine)


                monthlyRTB.AppendText("Tutor Name " + vbTab + "Salary" + Environment.NewLine)
                For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1
                    monthlyRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("Full Name").ToString + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("Salary").ToString + Environment.NewLine)
                Next x
            Else
                monthlyRTB.AppendText("No Tutors paid Monthly" + Environment.NewLine)
            End If
            monthlyRTB.AppendText("____________________________________________________________________________" + Environment.NewLine)


        Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub



    Private Sub TutorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorComboBox.SelectedIndexChanged
        If TutorComboBox.SelectedIndex > -1 Then
            TutorRTB.Clear()
            If SQl.HasConnnection() Then
                If SQl.SQLDataSet IsNot Nothing Then
                    SQl.SQLDataSet.Clear()
                End If
                Dim TutorId = TutorComboBox.SelectedItem.ToString.Substring(0, TutorComboBox.SelectedItem.ToString.IndexOf(" "))
                SQl.RunQuery("SELECT Salary,PaymentStyle FROM tblTutor WHERE tutorID = '" & Integer.Parse(TutorId) & "'")
                Dim PStyle As String = SQl.SQLDataSet.Tables(0).Rows(0).Item("PaymentSTyle").ToString
                Dim Salary = SQl.SQLDataSet.Tables(0).Rows(0).Item("Salary")
                If PStyle = "Daily" Then
                    TutorRTB.AppendText("Month" + vbTab + "No of Days Worked" + vbTab + vbTab + "Salary per Day" + vbTab + "Total Month Salary" + Environment.NewLine)
                    SQl.SQLDataSet.Clear()
                    SQl.RunQuery("SELECT DIstinct(MONTH(WorkingDATE)) AS 'Month',COunt(*) As 'DaysforMonth' FROM tblRegister WHERE TutorID = '" & Integer.Parse(TutorId) & "' group by Month(WorkingDate)")

                    If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                        For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1

                            TutorRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("month").ToString + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("DaysforMonth").ToString + vbTab + vbTab + vbTab + Salary.ToString + vbTab + vbTab + (SQl.SQLDataSet.Tables(0).Rows(x).Item("DaysforMonth") * Salary).ToString + Environment.NewLine)
                        Next x
                    End If
                End If

                If PStyle = "Hourly" Then
                    SQl.SQLDataSet.Clear()
                    TutorRTB.AppendText("Month" + vbTab + "No of Hours Worked" + vbTab + "Salary per Hour" + vbTab + "Total Month Salary" + Environment.NewLine)
                    SQl.RunQuery("SELECT DIstinct(MONTH(WorkingDATE)) AS 'Month',SUm(HoursWorked) As 'HoursforMonth' FROM tblRegister WHERE TutorID = '" & Integer.Parse(TutorId) & "' group by Month(WorkingDate)")

                    If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                        For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1

                            TutorRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("month").ToString + vbTab + SQl.SQLDataSet.Tables(0).Rows(x).Item("HoursforMonth").ToString + vbTab + vbTab + vbTab + Salary.ToString + vbTab + vbTab + FormatNumber(SQl.SQLDataSet.Tables(0).Rows(x).Item("HoursforMonth") * Salary, 2).ToString + Environment.NewLine)
                        Next x
                    End If
                End If

                If PStyle = "Weekly" Then
                    SQl.SQLDataSet.Clear()
                    TutorRTB.AppendText("Month" + vbTab + "Salary per Week" + vbTab + vbTab + "Total Month Salary" + Environment.NewLine)
                    SQl.RunQuery("SELECT DIstinct(MONTH(WorkingDATE)) AS 'Month' FROM tblRegister WHERE TutorID = '" & Integer.Parse(TutorId) & "' group by Month(WorkingDate)")

                    If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                        For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1

                            TutorRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("month").ToString + vbTab + Salary.ToString + vbTab + vbTab + vbTab + (4 * Salary).ToString + Environment.NewLine)
                        Next x
                    End If
                End If


                If PStyle = "Mothly" Then
                    SQl.SQLDataSet.Clear()
                    TutorRTB.AppendText("Month" + vbTab + "Total Month Salary" + Environment.NewLine)
                    SQl.RunQuery("SELECT DIstinct(MONTH(WorkingDATE)) AS 'Month' FROM tblRegister WHERE TutorID = '" & Integer.Parse(TutorId) & "'")

                    If SQl.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then

                        For x = 0 To SQl.SQLDataSet.Tables(0).Rows.Count - 1

                            TutorRTB.AppendText(SQl.SQLDataSet.Tables(0).Rows(x).Item("month").ToString + vbTab + Salary.ToString + vbTab + (Salary).ToString + Environment.NewLine)
                        Next x
                    End If
                End If

            Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class