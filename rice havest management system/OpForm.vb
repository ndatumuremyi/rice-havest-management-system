Public Class OpForm
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "select * from operations"
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Private Sub OpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View()
    End Sub

End Class