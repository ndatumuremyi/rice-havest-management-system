Public Class famers
    Dim id As Integer
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            txtFName.Text = row.Cells(1).Value.ToString
            txtLName.Text = row.Cells(2).Value.ToString
            txtLocation.Text = row.Cells(3).Value.ToString
            Try
                id = CInt(row.Cells(0).Value.ToString)
            Catch ex As Exception
            End Try



        End If
    End Sub
    Private Sub clear()
        txtFName.Clear()
        txtLName.Clear()
        txtLocation.Clear()
    End Sub
    Private Sub DeleteIt(ByRef s_id As String)

        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            sql = "DELETE * from farmers WHERE id=" & s_id & ""
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm
            dr = cm.ExecuteReader
            MsgBox("leader is successfully deleted!")
            clear()
            View()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub famers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()
    End Sub
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from farmers"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim fN As String = txtFName.Text
        Dim LN As String = txtLName.Text
        Dim locationV As String = txtLocation.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO farmers(fname,lname,location)VALUES(@fname,@lname,@location)"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, LN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@location", System.Data.OleDb.OleDbType.VarChar, 255, locationV))


            ' RUN THE COMMAND
            cm.Parameters("@fname").Value = fN
            cm.Parameters("@lname").Value = LN
            cm.Parameters("@location").Value = locationV


            cm.ExecuteNonQuery()

        End With
        View()
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fN As String = txtFName.Text
        Dim LN As String = txtLName.Text
        Dim locationV As String = txtLocation.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "UPDATE farmers SET fname =@fname ,lname = @lname,location =@location WHERE id=@id"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@fname", System.Data.OleDb.OleDbType.VarChar, 255, fN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@lname", System.Data.OleDb.OleDbType.VarChar, 255, LN))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@location", System.Data.OleDb.OleDbType.VarChar, 255, locationV))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id", System.Data.OleDb.OleDbType.VarChar, 255, id))


            ' RUN THE COMMAND
            cm.Parameters("@fname").Value = fN
            cm.Parameters("@lname").Value = LN
            cm.Parameters("@location").Value = locationV
            cm.Parameters("@id").Value = id


            cm.ExecuteNonQuery()

        End With

        View()
        clear()
        MsgBox("done")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteIt(id)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class