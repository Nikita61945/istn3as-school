Public Class CloseTerm

    Private SQL As New DataBaseControl
    Dim Termno As Integer

    Private Sub CloseTerm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        Dim termFound As Boolean = False
        Termno = 1
        If SQL.HasConnnection = True Then
            Cursor.Current = Cursors.WaitCursor
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM tblTerm")
            If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                For x = 0 To 3

                    If (SQL.SQLDataSet.Tables(0).Rows(x).Item("Status").Equals(True)) And (termFound = False) Then
                        Termno = x + 1
                        termFound = True
                    End If

                Next x
            End If

            populateGrid()
            If (dgvMarks.RowCount = 0) Then
                CloseTermButton.Enabled = True
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub populateGrid()
        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim currentyear As Integer = System.DateTime.Now.Year

            SQL.RunQuery("Select tblSubGrade.GradeID, tblSubject.SubjectName, tblPOA.Topic  FROM tblPOA INNER JOIN tblSubGrade On tblPOA.SubjectID = tblSubGrade.SubjectID INNER JOIN
                         tblSubject ON tblSubGrade.SubjectID = tblSubject.SubjectID WHERE tblPOA.Status = 'O'  OR tblPOA.Status = 'C' AND TERM = '" & Termno & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count.Equals(0) = False Then
                Dim dbTable As New DataTable
                Dim bSource As New BindingSource
                Dim ds As New DataSet
                SQL.SQLDataAdap.SelectCommand = SQL.SQLComd
                SQL.SQLDataAdap.Fill(dbTable)
                bSource.DataSource = dbTable
                SQL.SQLDataAdap.Update(dbTable)
                dgvMarks.DataSource = dbTable
                dgvMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Else
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CloseTermButton_Click(sender As Object, e As EventArgs) Handles CloseTermButton.Click

        If SQL.HasConnnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Update tblTerm SET Status = 0 WHere termNumber ='" & Termno & "'")

            SQL.RunQuery("UPDATE tblPOA SET Status='T' WHERE Term='" & Termno & "' AND Year='" & System.DateTime.Now.Year() & "'")
            SQL.RunQuery("UPDATE tblPOA SET Status='O' WHERE Term='" & Termno + 1 & "' AND Year='" & System.DateTime.Now.Year() & "'")
        Else

            MessageBox.Show("Database not avilable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class