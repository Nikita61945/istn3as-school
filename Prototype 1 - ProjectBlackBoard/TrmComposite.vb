Public Class TrmComposite
    Public sql As New DataBaseControl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = vbNullString
        If ComboBoxGrade.SelectedIndex = -1 Then
            msg = msg + "Grade is not Selected" + Environment.NewLine
        End If
        If TextBox1.Text.Length.Equals(4) Then
            If IsNumeric(TextBox1.Text) = False Then
                msg = msg + "Year must be numeric" + Environment.NewLine
            End If
        Else
            msg = msg + "Year must be 4  digits" + Environment.NewLine
        End If
        If TextBox2.Text.Length.Equals(1) Then
            If IsNumeric(TextBox2.Text) = False Then
                msg = msg + "Term must be numeric" + Environment.NewLine
            End If
        Else
            msg = msg + "Term must be one digit" + Environment.NewLine
        End If
        If msg = vbNullString Then
            Me.DataSet1.EnforceConstraints = False
            Me.DataTermCompTableAdapter.Fill(Me.DataSet1.DataTermComp, TextBox1.Text, TextBox2.Text, ComboBoxGrade.SelectedItem)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show(msg, "Errors in informaton", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TrmComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTermComp' table. You can move, or remove it, as needed.
        ' Me.DataTermCompTableAdapter.Fill(Me.DataSet1.DataTermComp)

        If Sql.HasConnnection = True Then

            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If

            Sql.RunQuery("SELECT GradeId FROM tblGrade WHERE isOffered =1")

            Dim y As Integer = 0
            If Sql.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For Each x As DataRow In Sql.SQLDataSet.Tables(0).Rows
                    ComboBoxGrade.Items.Add(Sql.SQLDataSet.Tables(0).Rows(y).Item("GradeID"))
                    y = y + 1
                Next
            End If
        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub TrmComposite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class