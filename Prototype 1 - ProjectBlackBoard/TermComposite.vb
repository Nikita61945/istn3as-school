Public Class TermComposite

    Private Sub TermComposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTermComp' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.DataSet1.EnforceConstraints = False
        Me.DataTermCompTableAdapter.Fill(Me.DataSet1.DataTermComp, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class