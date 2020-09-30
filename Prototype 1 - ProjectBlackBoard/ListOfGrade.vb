Public Class ListOfGradesForm
    Private sql As New DataBaseControl
    Dim Isedit As Boolean = False
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        SaveButton.Enabled = True
        NumericUpDown1.Enabled = True
        CheckBox1.Checked = True
        AddButton.Enabled = False
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub



    Public Sub populateListBox()
        If sql.HasConnnection = True Then

            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("SELECT GradeName FROM tblGRADE")
            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then
                Dim y As Integer = 0
                For Each x As DataRow In sql.SQLDataSet.Tables(0).Rows
                    GradeListBox.Items.Add(sql.SQLDataSet.Tables(0).Rows(y).Item("GradeName"))
                    y = y + 1
                Next x
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub ListOfGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        CheckBox1.Enabled = False
        NumericUpDown1.Enabled = False
        populateListBox()
        AddButton.Enabled = True

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        AddButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = True
        CheckBox1.Enabled = True
        Isedit = True
    End Sub


    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If sql.HasConnnection Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If
            If Isedit = False Then
                'Get GradeID

                Dim id As Integer = NumericUpDown1.Value
                sql.RunQuery("SELECT * from tblGrade Where GradeID ='" & id & "'")

                If sql.SQLDataSet.Tables(0).Rows.Count.Equals(0) Then
                    sql.SQLDataSet.Clear()

                    Dim name As String = getNumberName(id).ToString
                    sql.RunQuery("INSERT INTO tblGrade(GradeID,GradeName,isOffered) VALUES ('" & id & "','" & name & "',1)")
                    MessageBox.Show("New Grade Added", "Grade Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Grade already exists", "Error : Grade Exists", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                sql.RunQuery("UPDATE tblGrade SET isOffered = '" & CheckBox1.CheckState & "' Where GradeID = '" & Integer.Parse(NumericUpDown1.Value) & "'")
                MessageBox.Show("Grade is Updated", "Grade Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Add to table
            GradeListBox.Items.Clear()
            populateListBox()
            NumericUpDown1.ResetText()
            CheckBox1.Enabled = False
            SaveButton.Enabled = False
            AddButton.Enabled = True

        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub





    Private Function getNumberName(ByRef number As Integer) As String
        Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"}
        Return "Grade " + arr(number - 1)

    End Function



    Private Sub GradeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeListBox.SelectedIndexChanged
        EditButton.Enabled = True
        NumericUpDown1.Enabled = False
        CheckBox1.Enabled = False
        AddButton.Enabled = False
        If sql.HasConnnection Then
            If sql.SQLDataSet IsNot Nothing Then
                sql.SQLDataSet.Clear()
            End If

            sql.RunQuery("SELECT GradeID,GradeName,isOffered FROM tblGrade WHERE GradeName='" & GradeListBox.SelectedItem.ToString & "' ")
            If sql.SQLDataSet.Tables(0).Rows.Count > 0 Then

                For x = 0 To sql.SQLDataSet.Tables(0).Rows.Count - 1
                    NumericUpDown1.Value = sql.SQLDataSet.Tables(0).Rows(x).Item("GradeID")
                    If sql.SQLDataSet.Tables(0).Rows(x).Item("isOffered").Equals(True) Then
                        CheckBox1.Checked() = True
                    Else
                        CheckBox1.Checked() = False

                    End If
                Next x
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class