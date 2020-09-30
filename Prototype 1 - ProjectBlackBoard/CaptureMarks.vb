Public Class CaptureMarks
    Public SQL As New DataBaseControl
    Dim selectedGrade As String
    Dim selectedSub As String
    Public ActMark As Integer = 1
    Public PaperMark As Integer = 1
    Public Conversion As Integer
    Public covertM As Boolean = False
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Home", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Action cancelled ")
        End If

    End Sub

    Private Sub GradeChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeChoice.SelectedIndexChanged
        SQL.SQLDataSet.Clear()
        If GradeChoice.SelectedIndex = -1 Then
            MessageBox.Show("please select a Grade")
        Else
            selectedGrade = Integer.Parse(GradeChoice.SelectedItem)
        End If
        listSub.Items.Clear()
        SQL.RunQuery("SELECT SubjectID from tblSubGrade WHERE GradeID ='" & selectedGrade & "'")
        Dim y As Integer
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                listSub.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID"))
                y += 1
            Next
        End If
    End Sub

    Private Sub CaptureMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT GradeID from tblGrade WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeChoice.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next
            End If
        End If
    End Sub

    Public Sub getPOALoaded()

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select tblPoa.poAID,tblPOA.TaskNo,tblPOA.Term,tblPOA.DateGiven,tblPOA.DateDue, tblPOA.Topic,tblPOA.Total, tblPOA.Status, tblPOA.Weighting From tblPOA , tblSUbgrade WHERE tblPOA.SubjectID = tblSUbGrade.SUbjectid AND tblPOA.GradeID = tblSUbGrade.Gradeid  And tblPOA.Active = 1 And tblSubgrade.GradeID='" & selectedGrade & "' AND tblSubgrade.SubjectID= '" & selectedSub & "'")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            DataGridView1.DataSource = dbTable


            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False

            DataGridView1.Columns(8).Visible = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnCM_Click(sender As Object, e As EventArgs) Handles btnCM.Click


        Dim rowSelected As Integer
        rowSelected = DataGridView1.CurrentRow.Index
        If rowSelected > -1 Then
            capturemarks2.LabelPoaDet.Text = DataGridView1.Item(0, rowSelected).Value
            capturemarks2.LabelTopic.Text = DataGridView1.Item(5, rowSelected).Value
            capturemarks2.LabelGIv.Text = DataGridView1.Item(3, rowSelected).Value
            capturemarks2.LabelDue.Text = DataGridView1.Item(4, rowSelected).Value
            capturemarks2.labaelTotal.Text = DataGridView1.Item(6, rowSelected).Value
            capturemarks2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select a row from the grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub


    Private Sub listSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSub.SelectedIndexChanged
        selectedSub = listSub.SelectedItem.ToString

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            getPOALoaded()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        btnCM.Enabled = True
    End Sub
End Class