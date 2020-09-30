Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class OpenAccount
    Public SQL As New DataBaseControl
    Public id

    Public Sub PopulateListBox()
        ListBox1.Items.Clear()
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            If (ComboBoxGrade.SelectedIndex > -1) Then
                SQL.RunQuery("SELECT tbllearner.LearnerID,tbllearner.LName +' '+ tbllearner.LSurname AS 'Full Name' FROM tblLearner, tblLearnerGrade WHERE tbllearner.LearnerID = tbllearnerGrade.LearnerID and tbllearner.LAccount = 0 and tbllearner.LStatus=1 and tbllearnerGrade.GradeID=" & ComboBoxGrade.SelectedItem & "")
            Else
                SQL.RunQuery("SELECT LearnerID,LName +' '+ LSurname AS 'Full Name' FROM tblLearner WHERE LAccount = 0 and LStatus=1")
            End If


            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then


                    Dim y As Integer = 0
                    For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                        ListBox1.Items.Add(SQL.SQLDataSet.Tables(0).Rows(y).Item("LearnerID") & " " & SQL.SQLDataSet.Tables(0).Rows(y).Item("Full Name"))
                        ListBox1.ValueMember = "LearnerID"
                        ListBox1.DisplayMember = "Full Name"
                        y = y + 1
                    Next
                End If
            Else
                MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub OpenAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            SQL.RunQuery("SELECT GradeID from tblGrade ")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then


                Dim y As Integer = 0
                For x = 0 To SQL.SQLDataSet.Tables(0).Rows.Count - 1
                    ComboBoxGrade.Items.Add(SQL.SQLDataSet.Tables(0).Rows(x).Item("GradeID").ToString)
                Next x
            End If
        Else
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        PopulateListBox()
        OpenButton.Enabled = False
        Me.MdiParent = Form1
    End Sub



    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim count As Integer = 0
        Dim ID As Integer
        If SQL.HasConnnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Cursor.Current = Cursors.WaitCursor
            For x = 0 To ListBox1.Items.Count - 1
                If ListBox1.GetSelected(x) Then
                    ID = (ListBox1.Items(x).ToString).Substring(0, ListBox1.Items(x).ToString.IndexOf(" "))
                    SQL.RunQuery("UPDATE tblLearner SET LAccount = 1 WHERE LearnerID = '" &
                              id & "'")
                    SQL.SQLDataSet.Clear()
                    count = count + 1
                End If
            Next x
            Cursor.Current = Cursors.Arrow
            MessageBox.Show(count.ToString + " Learner Accounts Opened ", "Opening Learner Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListBox1.Items.Clear()
            PopulateListBox()
            OpenButton.Enabled = False

        Else
            MessageBox.Show("Database not avilable, Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        OpenButton.Enabled = True
    End Sub

    Private Sub ComboBoxGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGrade.SelectedIndexChanged
        PopulateListBox()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ListBox1.selec
        End If
    End Sub
End Class