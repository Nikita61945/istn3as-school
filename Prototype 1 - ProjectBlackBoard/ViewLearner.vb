Public Class ViewLearner
    Private SQL As New DataBaseControl
    Friend ID As String
    Dim GradeID As Integer = 0
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "Blackboard.chm")
    Public Sub PopComboBox()
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
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub GetLearners()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        Dim ds As New DataSet
        SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAdap.Fill(dbTable)
        bSource.DataSource = dbTable
        SQL.SQLDataAdap.Update(dbTable)
        dgvLearners.DataSource = dbTable

    End Sub

    Private Sub NameRB_CheckedChanged(sender As Object, e As EventArgs) Handles NameRB.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery(" SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "' ORDER BY LName ASC")
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        GetLearners()
    End Sub

    Private Sub SurnameRB_CheckedChanged(sender As Object, e As EventArgs) Handles SurnameRB.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "' ORDER BY LSurname ASC")
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        GetLearners()
    End Sub
    Private Sub GradeRB_CheckedChanged(sender As Object, e As EventArgs) Handles GradeRB.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "' ORDER BY tblGrade.GradeID ASC")
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        GetLearners()
    End Sub

    Private Sub GenderRB_CheckedChanged(sender As Object, e As EventArgs) Handles GenderRB.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID)WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "' ORDER BY LGender ASC")
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        GetLearners()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditLearnerForm.Show()

        Dim rowClicked As Integer = dgvLearners.CurrentRow.Index()
        ID = dgvLearners.Item(0, rowClicked).Value().ToString
        Me.Hide()
        EditLearnerForm.LID.Clear()
        EditLearnerForm.IDNoTextBox.Clear()
        EditLearnerForm.ExamNoTextBox.Clear()
        EditLearnerForm.NameTextBox.Clear()
        EditLearnerForm.SurnameTextBox.Clear()
        EditLearnerForm.StreetAdTextBox.Clear()
        EditLearnerForm.SuburbTextBox.Clear()
        EditLearnerForm.CityTextBox.Clear()
        EditLearnerForm.PCodeTextBox.Clear()
        EditLearnerForm.GenderComboBox.SelectedItem = -1
        EditLearnerForm.P1NameTextBox.Clear()
        EditLearnerForm.P1CellNoTextBox.Clear()
        EditLearnerForm.P1EmailTextBox.Clear()
        EditLearnerForm.P2NameTextBox.Clear()
        EditLearnerForm.P2CellNoTextBox.Clear()
        EditLearnerForm.P2EmailTextBox.Clear()

        'autofill details
        EditLearnerForm.LID.Text = ID
        EditLearnerForm.IDNoTextBox.Text = dgvLearners.Item(1, rowClicked).Value


        If ((dgvLearners.Item(2, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.ExamNoTextBox.Text = dgvLearners.Item(2, rowClicked).Value
        End If

        EditLearnerForm.NameTextBox.Text = dgvLearners.Item(3, rowClicked).Value
        EditLearnerForm.SurnameTextBox.Text = dgvLearners.Item(4, rowClicked).Value
        If ((dgvLearners.Item(7, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.StreetAdTextBox.Text = dgvLearners.Item(7, rowClicked).Value
        End If

        If ((dgvLearners.Item(8, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.SuburbTextBox.Text = dgvLearners.Item(8, rowClicked).Value
        End If
        If ((dgvLearners.Item(9, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.CityTextBox.Text = dgvLearners.Item(9, rowClicked).Value
        End If
        If ((dgvLearners.Item(10, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.PCodeTextBox.Text = dgvLearners.Item(10, rowClicked).Value
        End If
        If ((dgvLearners.Item(14, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.P2NameTextBox.Text = dgvLearners.Item(14, rowClicked).Value
        End If
        If ((dgvLearners.Item(15, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.P2CellNoTextBox.Text = dgvLearners.Item(15, rowClicked).Value
        End If
        If ((dgvLearners.Item(16, rowClicked).Value) Is DBNull.Value) = False Then
            EditLearnerForm.P2EmailTextBox.Text = dgvLearners.Item(16, rowClicked).Value
        End If

        EditLearnerForm.GenderComboBox.SelectedItem = dgvLearners.Item(11, rowClicked).Value
        EditLearnerForm.P1NameTextBox.Text = dgvLearners.Item(12, rowClicked).Value
        EditLearnerForm.P1CellNoTextBox.Text = dgvLearners.Item(13, rowClicked).Value
        EditLearnerForm.P1EmailTextBox.Text = dgvLearners.Item(17, rowClicked).Value
        EditLearnerForm.TextBox1.Text = dgvLearners.Item(5, rowClicked).Value

    End Sub

    Private Sub ViewLearner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        HelpProvider1.HelpNamespace = strHelpPath
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")

            GetLearners()
            PopComboBox()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub ViewLearner_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'test all conditions 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' surname name grade
        If (isFieldBlank(SurnameTextBox.Text) = False) And (isFieldBlank(NameTextBox.Text) = False) And (GradeComboBox.SelectedIndex <> -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE tblLearner.LSurname = '" & SurnameTextBox.Text & "' AND tblLearner.LName = '" & NameTextBox.Text & "' AND tblGrade.GradeID =  '" & GradeID & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ' surname and name
        ElseIf (isFieldBlank(SurnameTextBox.Text) = False) And (isFieldBlank(NameTextBox.Text) = False) And (GradeComboBox.SelectedIndex = -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE LSurname = '" & SurnameTextBox.Text & "' AND LName = '" & NameTextBox.Text & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'surname and grade
        ElseIf (isFieldBlank(SurnameTextBox.Text) = False) And (isFieldBlank(NameTextBox.Text) = True) And (GradeComboBox.SelectedIndex <> -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE tblLearner.LSurname = '" & SurnameTextBox.Text & "' AND tblGrade.GradeID =  '" & GradeID & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'name and grade
        ElseIf (isFieldBlank(SurnameTextBox.Text) = True) And (isFieldBlank(NameTextBox.Text) = False) And (GradeComboBox.SelectedIndex <> -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE tblLearner.LName = '" & NameTextBox.Text & "' AND tblGrade.GradeID =  '" & GradeID & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'surname
        ElseIf (isFieldBlank(SurnameTextBox.Text) = False) And (isFieldBlank(NameTextBox.Text) = True) And (GradeComboBox.SelectedIndex = -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE LSurname ='" & SurnameTextBox.Text & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'name
        ElseIf (isFieldBlank(SurnameTextBox.Text) = True) And (isFieldBlank(NameTextBox.Text) = False) And (GradeComboBox.SelectedIndex = -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE LName = '" & NameTextBox.Text & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'grade
        ElseIf (isFieldBlank(SurnameTextBox.Text) = True) And (isFieldBlank(NameTextBox.Text) = True) And (GradeComboBox.SelectedIndex <> -1) Then
            If SQL.HasConnnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
                SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM ((tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) INNER JOIN tblGrade ON tblLearnerGrade.GRADEID = tblGrade.GradeID) WHERE tblGrade.GradeID =  '" & GradeID & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
                GetLearners()
            Else
                Cursor.Current = Cursors.Arrow
                MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If (dgvLearners.RowCount = 0) Then
            MessageBox.Show("No Learner Found", "Learner Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function isFieldBlank(ByVal CheckField As String)
        If CheckField.Length = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DisplayAllLearners_Click(sender As Object, e As EventArgs) Handles DisplayAllLearners.Click
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            NameRB.Checked = False
            GradeRB.Checked = False
            SurnameRB.Checked = False
            GenderRB.Checked = False
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            SQL.RunQuery("Select tblLearner.LearnerID As [Learner ID], IDNo As [Identity Number], ExamNo As [Exam Number], LName As [Learner Name], LSurname As [Learner Surname], tblLearnerGrade.GRADEID As [Grade], LStatus As [Learner Status], LStreetAdd As [Street Address], LSuburb As [Suburb], LCity As [City], LPCode As [Postal Code], LGender As [Gender], POneName As [Parent One], POneNo As [Parent One Cell Number], PTwoName As [Parent Two Name], PTwoNo As [Parent Two Cell Number], PTwoEmail As [Parent Two Email], POneEmail As [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade On tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            GetLearners()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SurnameTextBox.Clear()
        NameTextBox.Clear()
        GradeComboBox.SelectedIndex = -1
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If (GradeComboBox.SelectedIndex = -1) Then
            GradeID = 0
        Else
            GradeID = Integer.Parse((GradeComboBox.SelectedItem.ToString.Substring(0, GradeComboBox.SelectedItem.ToString.Length)))
        End If
    End Sub

    Private Sub SurnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameTextBox.TextChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade On tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE (LSurname Like '" & SurnameTextBox.Text & "' + '%') AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            GetLearners()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE (LName LIKE '" & NameTextBox.Text & "' + '%') AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            GetLearners()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearner.LStatus = '" & 1 & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            GetLearners()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT tblLearner.LearnerID AS [Learner ID], IDNo AS [Identity Number], ExamNo AS [Exam Number], LName AS [Learner Name], LSurname AS [Learner Surname],tblLearnerGrade.GRADEID AS [Grade], LStatus AS [Learner Status],LStreetAdd AS [Street Address], LSuburb AS [Suburb], LCity AS [City], LPCode AS [Postal Code], LGender AS [Gender], POneName AS [Parent One], POneNo AS [Parent One Cell Number], PTwoName AS [Parent Two Name], PTwoNo AS [Parent Two Cell Number], PTwoEmail AS [Parent Two Email], POneEmail AS [Parent One Email] FROM (tblLearner INNER JOIN tblLearnerGrade ON tblLearner.LearnerID = tblLearnerGrade.LearnerID) WHERE tblLearner.LStatus = '" & 0 & "' AND tblLearnerGrade.AccademicYear = '" & Convert.ToInt32(Now.ToString("yyyy")) & "'")
            GetLearners()
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable , Contact the Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ViewLearner_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.Topic)
    End Sub
End Class