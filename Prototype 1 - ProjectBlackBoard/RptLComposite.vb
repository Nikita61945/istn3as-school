Public Class RptLComposite
    Public sql As New DataBaseControl
    Private Sub RptLComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataLearnerComp' table. You can move, or remove it, as needed.
        ' Me.DataLearnerCompTableAdapter.Fill(Me.DataSet1.DataLearnerComp)

        If Sql.HasConnnection = True Then

            If Sql.SQLDataSet IsNot Nothing Then
                Sql.SQLDataSet.Clear()
            End If

            Sql.RunQuery("SELECT LearnerID, convert(varChar(6),LearnerID) +' '+LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE LStatus = 1")

            Dim y As Integer = 0
            If Sql.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                For Each x As DataRow In Sql.SQLDataSet.Tables(0).Rows
                    LearnerCB.Items.Add(Sql.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                    y = y + 1
                Next
            End If
        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = vbNullString
        If LearnerCB.SelectedIndex = -1 Then
            msg = msg + "Grade is not Selected" + Environment.NewLine
        End If
        If TextBox2.Text.Length > 0 Then
            If IsNumeric(TextBox2.Text) = False Then
                msg = msg + "Year must be numeric" + Environment.NewLine
            End If
        Else
            msg = msg + "Fill in year" + Environment.NewLine
        End If
        If msg = vbNullString Then
            Me.DataSet1.EnforceConstraints = False
            Me.DataLearnerCompTableAdapter.Fill(Me.DataSet1.DataLearnerComp, TextBox2.Text, Integer.Parse(LearnerCB.SelectedItem.ToString.Substring(0, LearnerCB.SelectedItem.ToString.IndexOf(" "))))
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show(msg, "Errors in informaton", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RptLComposite_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class