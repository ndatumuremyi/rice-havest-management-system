Public Class leader
    Dim id As Integer
    Private Sub clear()
        txtFname.Clear()
        txtLname.Clear()
        txtSex.Clear()
    End Sub
    Private Sub DeleteIt(ByRef s_id As String)

        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            sql = "DELETE * from leaders WHERE id=" & s_id & ""
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm
            dr = cm.ExecuteReader
            MsgBox("leader is successfully deleted!")
            txtFname.Clear()
            txtLname.Clear()
            txtSex.Clear()
            View()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim fN As String = txtFname.Text
        Dim LN As String = txtLname.Text
        Dim SX As String = txtSex.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO leaders (fname,lname,sex) VALUES (@fname,@lname,@sex)"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, LN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@sex", System.Data.OleDb.OleDbType.VarChar, 255, SX))


            ' RUN THE COMMAND
            cm.Parameters("@fname").Value = fN
            cm.Parameters("@lname").Value = LN
            cm.Parameters("@sex").Value = SX


            cm.ExecuteNonQuery()
            View()
            clear()


        End With
    End Sub
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            txtFname.Text = row.Cells(1).Value.ToString
            txtLname.Text = row.Cells(2).Value.ToString
            txtSex.Text = row.Cells(3).Value.ToString
            Try
                id = CInt(row.Cells(0).Value.ToString)
            Catch ex As Exception
            End Try



        End If
    End Sub
    Private Sub leader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()
    End Sub
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from leaders"
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteIt(id)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fN As String = txtFname.Text
        Dim LN As String = txtLname.Text
        Dim SX As String = txtSex.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "UPDATE leaders SET fname = @fname,lname =@lname ,sex=@sex) WHERE id=@id"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, LN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@sex", System.Data.OleDb.OleDbType.VarChar, 255, SX))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id", System.Data.OleDb.OleDbType.VarChar, 255, id))


            ' RUN THE COMMAND
            cm.Parameters("@fname").Value = fN
            cm.Parameters("@lname").Value = LN
            cm.Parameters("@sex").Value = SX
            cm.Parameters("@id").Value = id


            cm.ExecuteNonQuery()
            View()
            clear()
            MsgBox("done")


        End With
    End Sub
End Class