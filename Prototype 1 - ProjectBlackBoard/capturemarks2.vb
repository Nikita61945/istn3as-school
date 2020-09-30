Public Class captureMarks2
    Public SQL As New DataBaseControl
    Dim Learner_ID As Integer = 0
    Dim POA_ID As Integer
    Dim LFirst_Name As String
    Dim LSurname As String
    Dim Mark As Integer = 0
    Dim Count As Integer
    Dim Countp As Integer
    Dim isEditable As Boolean = False
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Mark Capture", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            CaptureMarks.Show()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Action cancelled ")
        End If

    End Sub

    Private Sub captureMarks2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblMArk.LearnerID , tblLearner.LName, tblLearner.LSurname ,tblMArk.Mark FROm tblMArk ,tblLearner WHere tblLearner.LearnerID = tblMArk.LearnerID and POAID ='" & Integer.Parse(LabelPoaDet.Text) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                isEditable = True
                getMarks()
            Else
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("SELECT tblEnrolment.LearnerID, tblLearner.LName, tblLearner.LSurname FROM tblEnrolment INNER JOIN tblLearner ON tblEnrolment.LearnerID = tblLearner.LearnerID INNER JOIN tblPOA ON tblEnrolment.SubjectID = tblPOA.SubjectID AND tblEnrolment.GradeID = tblPOA.GradeID WHERE (tblPOA.POAID = '" & Integer.Parse(LabelPoaDet.Text) & "')")
                getMarks()
            End If

        End If

        'Me.MdiParent = Form1
    End Sub

    Public Sub changeStatus() 'change status when all marks are entered 
        SQL.RunQuery("select count(*) as NoEmpty from tblMark where POAID = '" & Integer.Parse(LabelPoaDet.Text) & "' and Mark is NULL ")
        Dim CountPOA As Integer = SQL.SQLDataSet.Tables(0).Rows(0).Item("NoEmpty")
        If CountPOA > 0 Then
            SQL.RunQuery("UPDATE tblPOA SET Status = 'C' WHERE POAID = '" & Integer.Parse(LabelPoaDet.Text) & "'")
        Else
            SQL.RunQuery("UPDATE tblPOA SET Status = 'F' WHERE POAID = '" & Integer.Parse(LabelPoaDet.Text) & "'")
        End If
    End Sub

    Public Sub getMarks()
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvMark.DataSource = dbTable
            If isEditable = False Then
                dgvMark.Columns.Add("Mark", "Mark")
            End If
            dgvMark.Columns(0).ReadOnly = True
            dgvMark.Columns(1).ReadOnly = True
            dgvMark.Columns(2).ReadOnly = True

            dgvMark.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            For x As Integer = 0 To dgvMark.Rows.Count - 1

                Learner_ID = dgvMark.Rows(x).Cells(0).Value
                If IsNumeric(dgvMark.Rows(x).Cells(3).Value) Then

                    Mark = Decimal.Parse(dgvMark.Rows(x).Cells(3).Value)
                End If
                If isEditable = False Then
                    Learner_ID = dgvMark.Rows(x).Cells(0).Value
                    If IsNumeric(dgvMark.Rows(x).Cells(3).Value) = False Then
                        SQL.SQLDataSet.Clear()

                        SQL.RunQuery("INSERT INTO tblMark(LearnerID,POAID,UserID) VALUES ('" & Learner_ID & "','" & Integer.Parse(LabelPoaDet.Text) & "','" & Login.userID & "') ")

                    Else
                        SQL.SQLDataSet.Clear()
                        SQL.RunQuery("INSERT INTO tblMark(LearnerID,POAID,UserID,Mark) VALUES ('" & Learner_ID & "','" & Integer.Parse(LabelPoaDet.Text) & "','" & Login.userID & "','" & Decimal.Parse(dgvMark.Rows(x).Cells(3).Value) & "')")


                    End If

                Else
                    If IsNumeric(dgvMark.Rows(x).Cells(3).Value) Then
                        SQL.RunQuery("UPdate tblMark Set Mark = '" & Mark & "'WHere POAID ='" & Integer.Parse(LabelPoaDet.Text) & "' AND LearnerID = '" & Learner_ID & "'")

                    End If
                End If

            Next x
            changeStatus()
            MessageBox.Show("Marks Updated", "Marks Enter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        CaptureMarks.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMark.CellMouseClick
        btnSave.Enabled() = True
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMark.CellEndEdit
        If IsNumeric(dgvMark.CurrentCell.Value) Then

            If Decimal.Parse(dgvMark.CurrentCell.Value) > Decimal.Parse(labaelTotal.Text.ToString) Then
                MessageBox.Show("Mark greater than total")
                dgvMark.CurrentCell.Value = " "
            End If
        End If
    End Sub



End Class