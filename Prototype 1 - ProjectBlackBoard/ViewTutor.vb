Public Class ViewTutor
    Public SQL As New DataBaseControl
    Friend ID As String
    Friend RowSelected As Integer

    Public Sub PopComboBox()

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT  TutorID,  convert(varChar(6),TutorID)+' '+FName +' '+Surname AS 'Identify' FROM tblTutor")
            TutorComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            TutorComboBox.ValueMember = "TutorID"
            TutorComboBox.DisplayMember = "Identify"
        End If

    End Sub
    Public Sub GetTutors()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAdap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAdap.Update(dbTable)
        dgvTutor.DataSource = dbTable
        dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        If dgvTutor.ColumnCount = 5 Then
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvTutor.Columns(0).Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If TutorComboBox.SelectedIndex > -1 Then
            Dim id As Integer = Integer.Parse(TutorComboBox.SelectedValue.ToString)
            SQL.SQLDataSet.Clear()
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor WHERE TutorID ='" & id & "'")

            GetTutors()
            PopComboBox()
        Else
            MessageBox.Show("Please select a tutor first", "No Tutor Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ViewTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        ToolTip1.SetToolTip(dgvTutor, "Double click to edit tutor details")
        EditButton.Enabled = False
    End Sub

    Private Sub ViewTutor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor")
            GetTutors()
            SQL.RunQuery("SELECT GradeID From tblGrade WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    GradeComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next x
            End If
            SQL.SQLDataSet.Clear()

            SQL.RunQuery("SELECT SubjectID From tblSubject WHERE isOffered = 1")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In SQL.SQLDataSet.Tables(0).Rows
                    SubjectComboBox.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("SubjectID"))
                    y = y + 1
                Next x
            End If
            SQL.SQLDataSet.Clear()

            PopComboBox()

        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If dgvTutor.CurrentRow.Index > -1 Then
            Me.Hide()
            EditTutor.Show()

            RowSelected = dgvTutor.CurrentRow.Index()
            ID = dgvTutor.Item(0, RowSelected).Value().ToString
            EditTutor.TutorIDTextBox.Text = ID
            EditTutor.NameTextBox.Text = dgvTutor.Item(1, RowSelected).Value()
            EditTutor.SurnameTextBox.Text = dgvTutor.Item(2, RowSelected).Value()
            EditTutor.SACETextBox.Text = dgvTutor.Item(9, RowSelected).Value()
            EditTutor.PayComboBox.SelectedItem = dgvTutor.Item(10, RowSelected).Value().ToString
            EditTutor.TelNumTextBox.Text = dgvTutor.Item(3, RowSelected).Value()
            EditTutor.CellNumTextBox.Text = dgvTutor.Item(4, RowSelected).Value()
            EditTutor.IDNumTextBox.Text = dgvTutor.Item(7, RowSelected).Value()
            EditTutor.EmailTextBox.Text = dgvTutor.Item(5, RowSelected).Value()
            EditTutor.QualTextBox.Text = dgvTutor.Item(8, RowSelected).Value()
            EditTutor.SalaryTextBox.Text = dgvTutor.Item(11, RowSelected).Value()
            EditTutor.ActiveCheckBox.Checked = dgvTutor.Item(6, RowSelected).Value()
        Else
            MessageBox.Show("Please Select tutor to edit", "Edit Tutor", MessageBoxButtons.OKCancel)
        End If

    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub TutorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TutorComboBox.SelectedIndexChanged
        btnSearch.Enabled = True
    End Sub

    Private Sub DisplayAllButton_Click(sender As Object, e As EventArgs) Handles DisplayAllButton.Click
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor")
            GetTutors()
            PopComboBox()

        End If
    End Sub

    Private Sub NameRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NameRadioButton.CheckedChanged
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor ORDER BY FName ASC")
            GetTutors()
            PopComboBox()


        End If
    End Sub

    Private Sub PaymentStyleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PaymentStyleRadioButton.CheckedChanged
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor ORDER BY PaymentStyle ASC")
            GetTutors()
            PopComboBox()

        End If
    End Sub

    Private Sub SalaryASCRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SalaryASCRadioButton.CheckedChanged
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor ORDER BY Salary ASC")
            GetTutors()
            PopComboBox()

        End If
    End Sub

    Private Sub SalarydescRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SalarydescRadioButton.CheckedChanged
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tutorID ,FName,Surname,TellNo,CellNo,Email,Active,IDNo,Qualification,SACENo,PaymentStyle,Salary FROM tblTutor ORDER BY Salary DESC")
            GetTutors()
            PopComboBox()

        End If
    End Sub


    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If GradeComboBox.SelectedIndex > -1 Then
            If SQL.HasConnnection = True Then

                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblTutor.TutorID ,tblTutor.FName,tblTutor.Surname, tblSubGrade.SubjectID,tblTutor.Active FROM tblTutor, tblSubGrade WHERE tblSubGrade.TutorID = tblTutor.TutorID and tblSubGrade.GradeID =  '" & Integer.Parse(GradeComboBox.SelectedItem.ToString) & "'")
                GetTutors()
                PopComboBox()

                GradeComboBox.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub dgvTutor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellClick
        EditButton.Enabled = True
    End Sub

    Private Sub SubjectComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SubjectComboBox.SelectionChangeCommitted
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubjectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        If SubjectComboBox.SelectedIndex > -1 Then
            If SQL.HasConnnection = True Then

                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblTutor.TutorID, tblTutor.FName,tblTutor.Surname, tblSubGrade.GradeID,tblTutor.Active FROM tblTutor, tblSubGrade WHERE tblSubGrade.TutorID = tblTutor.TutorID and tblSubGrade.SubjectID =  '" & SubjectComboBox.SelectedItem.ToString & "'")
                GetTutors()
                PopComboBox()
                SubjectComboBox.SelectedIndex = -1


            End If
        End If
    End Sub

    Private Sub dgvTutor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTutor.CellMouseDoubleClick
        EditButton_Click(dgvTutor, e)
    End Sub

    Private Sub dgvTutor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellContentClick
        ToolTip1.SetToolTip(dgvTutor, "Double Click to edit Tutor Info")
    End Sub

    Private Sub dgvTutor_MouseEnter(sender As Object, e As EventArgs) Handles dgvTutor.MouseEnter
        ToolTip1.SetToolTip(dgvTutor, "Double Click to edit Tutor Info")
    End Sub

    Private Sub dgvTutor_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvTutor.MouseMove
        ToolTip1.SetToolTip(dgvTutor, "Double Click to edit Tutor Info")
    End Sub

    Private Sub dgvTutor_MouseHover(sender As Object, e As EventArgs) Handles dgvTutor.MouseHover
        ToolTip1.SetToolTip(dgvTutor, "Double Click to edit Tutor Info")
    End Sub

    Private Sub dgvTutor_CellToolTipTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellToolTipTextChanged
        ToolTip1.SetToolTip(dgvTutor, "Double Click to edit Tutor Info")
    End Sub
End Class