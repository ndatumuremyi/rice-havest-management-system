Public Class warehouseF
    Dim id As Integer
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            txtLocation.Text = row.Cells(1).Value.ToString
            txtCapacity.Text = row.Cells(2).Value.ToString
            Try
                cboLeader.SelectedIndex = row.Cells(3).Value.ToString
            Catch ex As Exception

            End Try

            txtPricePerKg.Text = row.Cells(4).Value.ToString
            txtInStock.Text = row.Cells(5).Value.ToString

            Try
            id = CInt(row.Cells(0).Value.ToString)
            Catch ex As Exception
            End Try



        End If
    End Sub
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from warehouse"
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
    Private Sub clear()
        txtLocation.Clear()
        txtCapacity.Clear()
        cboLeader.Items.Clear()
        txtPricePerKg.Clear()
        txtInStock.Clear()

    End Sub
    Private Sub DeleteIt(ByRef s_id As String)

        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            sql = "DELETE * from warehouse WHERE id=" & s_id & ""
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm
            dr = cm.ExecuteReader
            MsgBox("leader is successfully deleted!")
            txtLocation.Clear()
            txtCapacity.Clear()
            View()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub warehouseF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()


        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM leaders"
            dr = .ExecuteReader
        End With
        cboLeader.Items.Clear()
        While dr.Read()

            cboLeader.Items.Add(dr("id") & "-" & dr("fname"))


        End While
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim capacity As String = txtCapacity.Text
        Dim inStock As String = txtInStock.Text
        Dim leader As String = cboLeader.SelectedItem.ToString
        Dim location As String = txtLocation.Text
        Dim pricePerKg As String = txtPricePerKg.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO warehouse (location,capacity,leader,pricePerKg,inStock) VALUES (@location,@capacity,@leader,@pricePerKg,@inStock)"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@location", System.Data.OleDb.OleDbType.VarChar, 255, location))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@capacity", System.Data.OleDb.OleDbType.VarChar, 255, capacity))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@leader", System.Data.OleDb.OleDbType.VarChar, 255, leader))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@pricePerKg", System.Data.OleDb.OleDbType.VarChar, 255, pricePerKg))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@inStock", System.Data.OleDb.OleDbType.VarChar, 255, inStock))


            ' RUN THE COMMAND
            cm.Parameters("@location").Value = location
            cm.Parameters("@capacity").Value = capacity
            cm.Parameters("@leader").Value = leader
            cm.Parameters("@pricePerKg").Value = pricePerKg
            cm.Parameters("@inStock").Value = inStock


            cm.ExecuteNonQuery()
            View()
            clear()


        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim capacity As String = txtCapacity.Text
        Dim inStock As String = txtInStock.Text
        Dim leader As String = cboLeader.SelectedItem.ToString
        Dim location As String = txtLocation.Text
        Dim pricePerKg As String = txtPricePerKg.Text

        cm = New OleDb.OleDbCommand
        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = "UPDATE warehouse SET location = @location,capacity = @capacity,leader = @leader,pricePerKg = @pricePerKg,inStock = @inStock WHERE id = @id"
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@location", System.Data.OleDb.OleDbType.VarChar, 255, location))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@capacity", System.Data.OleDb.OleDbType.VarChar, 255, capacity))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@leader", System.Data.OleDb.OleDbType.VarChar, 255, leader))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@pricePerKg", System.Data.OleDb.OleDbType.VarChar, 255, pricePerKg))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@inStock", System.Data.OleDb.OleDbType.VarChar, 255, inStock))
            .Parameters.Add(New System.Data.OleDb.OleDbParameter("@id", System.Data.OleDb.OleDbType.VarChar, 255, id))


            ' RUN THE COMMAND
            cm.Parameters("@location").Value = location
            cm.Parameters("@capacity").Value = capacity
            cm.Parameters("@leader").Value = leader
            cm.Parameters("@pricePerKg").Value = pricePerKg
            cm.Parameters("@inStock").Value = inStock
            cm.Parameters("@id").Value = id


            cm.ExecuteNonQuery()
            View()
            clear()
            MsgBox("done")


        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteIt(id)
    End Sub
End Class