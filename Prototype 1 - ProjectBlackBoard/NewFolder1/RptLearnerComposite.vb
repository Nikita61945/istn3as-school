Public Class RptLearnerComposite
    Private Sub RptLearnerComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataLearnerComp' table. You can move, or remove it, as needed.
        '      Me.DataLearnerCompTableAdapter.Fill(Me.DataSet1.DataLearnerComp)
        'TODO: This line of code loads data into the 'DataSet1.DataLearnerComp' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataSet1.EnforceConstraints = False
        Me.DataLearnerCompTableAdapter.Fill(Me.DataSet1.DataLearnerComp, TextBox2.Text, TextBox1.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class