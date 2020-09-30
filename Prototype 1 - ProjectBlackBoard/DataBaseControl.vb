Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DataBaseControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source = 146.230.177.46\ist3; Initial Catalog=group31;User ID=group31; Password='78bdn'"}

    Public SQLComd As SqlCommand
    Public SQLDataAdap As SqlDataAdapter
    Public SQLDataSet As DataSet

    Public Function HasConnnection() As Boolean

        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()

            SQLComd = New SqlCommand(Query, SQLCon)
            SQLDataAdap = New SqlDataAdapter(SQLComd)
            SQLDataSet = New DataSet
            SQLDataAdap.Fill(SQLDataSet)

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (SQLCon.State = ConnectionState.Open) Then
                SQLCon.Close()
            End If
        End Try

    End Sub
End Class
