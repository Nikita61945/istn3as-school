Public Class ViewPOA
    Public SQL As New DataBaseControl
    Dim selectedGrade As Integer
    Dim subject As String
    Dim SGID As String
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ViewPOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If


            SQL.RunQuery("SELECT GradeID from tblGrade WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    ComboGrade.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next
            End If
        End If
    End Sub

    Public Sub getPOAv()

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select tblPOA.Year,tblPOA.Term,tblPOA.Topic,tblPOA.TaskNo,tblPOA.DateGiven,tblPOA.DateDue,tblPOA.Total,tblPOA.POAID,tblPOA.PassMark,tblPOA.Weighting,tblPOA.CalcType,tblPOA.Active,tblPOA.Status,tblPOA.isSBA From tblPOA ,tblSUbgrade WHERE tblPOA.SubjectID = tblSUbGrade.SUbjectid AND tblPOA.GradeID = tblSUbGrade.Gradeid And tblSubgrade.GradeID='" & Integer.Parse(ComboGrade.SelectedItem) & "' AND tblSubgrade.SubjectID= '" & ListSubjects.SelectedItem & "'")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvPOA.DataSource = dbTable

            For x As Integer = 0 To 13
                dgvPOA.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnEditPOA_Click(sender As Object, e As EventArgs) Handles btnEditPOA.Click
        Dim rowSelected As Integer
        rowSelected = dgvPOA.CurrentRow.Index
        If rowSelected > -1 Then
            EditPOA.PoaIDText.Text = dgvPOA.Item(7, rowSelected).Value
            EditPOA.txtGrade.Text = dgvPOA.Item(8, rowSelected).Value
            EditPOA.termsCmb.SelectedItem = dgvPOA.Item(1, rowSelected).Value
            EditPOA.YearText.Text = Date.Today.Year.ToString
            EditPOA.DateGive.Value = dgvPOA.Item(4, rowSelected).Value
            EditPOA.DateDuetxt.Value = dgvPOA.Item(5, rowSelected).Value
            EditPOA.TopicText.Text = dgvPOA.Item(2, rowSelected).Value
            EditPOA.TotalText.Text = dgvPOA.Item(6, rowSelected).Value
            EditPOA.txtTask.Text = dgvPOA.Item(3, rowSelected).Value
            EditPOA.PassMarkText.Text = dgvPOA.Item(9, rowSelected).Value
            EditPOA.WeightingText.Text = dgvPOA.Item(10, rowSelected).Value
            'EditPOA.txtCal.Text = dgvPOA.Item(11, rowSelected).Value
            EditPOA.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select a row from the grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvPOA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPOA.CellClick
        btnEditPOA.Enabled = True
    End Sub

    Private Sub dgvPOA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPOA.CellContentClick

    End Sub

    Private Sub ComboGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGrade.SelectedIndexChanged
        SQL.SQLDataSet.Clear()
        If ComboGrade.SelectedIndex = -1 Then
            MessageBox.Show("please select a Grade")
        Else
            selectedGrade = ComboGrade.SelectedItem
        End If
        ListSubjects.Text = ""
        ListSubjects.Items.Clear()
        SQL.RunQuery("SELECT SubjectID FROM tblSubGrade WHERE GradeID ='" & selectedGrade & "' AND isOffered = 1 ")
        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            Dim y As Integer = 0
            For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                ListSubjects.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID"))
                y = y + 1
            Next
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If


            SQL.RunQuery("SELECT Year,Term,Topic,TaskNo,DateGiven,DateDue,Total,POAID,PassMark,Weighting,CalcType,Active,Status,isSBA FROM tblPOA where GradeID ='" & Integer.Parse(selectedGrade.ToString) & "' AND SubjectID ='" & ListSubjects.SelectedItem & "' ORDER BY TaskNo")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvPOA.DataSource = dbTable

            For x As Integer = 0 To 13
                dgvPOA.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If



            SQL.RunQuery("SELECT Year,Term,Topic,TaskNo,DateGiven,DateDue,Total,POAID,PassMark,Weighting,CalcType,Active,Status,isSBA FROM tblPOA where GradeID ='" & selectedGrade & "' AND SubjectID ='" & ListSubjects.SelectedItem & "' ORDER BY Term")
            Dim dbTable As New DataTable
            Dim bSource As New BindingSource
            SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAdap.Fill(dbTable)

            bSource.DataSource = dbTable
            SQL.SQLDataAdap.Update(dbTable)
            dgvPOA.DataSource = dbTable

            For x As Integer = 0 To 13
                dgvPOA.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Next
        Else

            MessageBox.Show("Database not available", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub ListSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSubjects.SelectedIndexChanged
        Subject = ListSubjects.SelectedItem.ToString

        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            getPOAv()
        End If
    End Sub
End Class