Public Class keep
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim farmer As String = cboFarmer.SelectedItem.ToString()
            Dim warehouse As String = cboWarehouse.SelectedItem.ToString()
            Dim farmerId As String = ""
            Dim warehouseId As String = ""

            Dim c As Char
            For Each c In farmer
                If c = "-" Then
                    Exit For
                End If
                farmerId += c
            Next
            For Each c In warehouse
                If c = "-" Then
                    Exit For
                End If
                warehouseId += c
            Next

            Dim quantity As Integer = CInt(txtQuantity.Text)
            Dim prevQ As Integer

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO operations (farmerId,warehouseId,quantity, type) VALUES (@farmerId,@warehouseId,@quantity, @type)"
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@farmerId", System.Data.OleDb.OleDbType.VarChar, 255, farmerId))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@warehouseId", System.Data.OleDb.OleDbType.VarChar, 255, warehouseId))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@quantity", System.Data.OleDb.OleDbType.VarChar, 255, quantity))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@type", System.Data.OleDb.OleDbType.VarChar, 255, "IN"))


                ' RUN THE COMMAND
                cm.Parameters("@farmerId").Value = farmerId
                cm.Parameters("@warehouseId").Value = warehouseId
                cm.Parameters("@quantity").Value = quantity
                cm.Parameters("@type").Value = "IN"


                cm.ExecuteNonQuery()

            End With
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM warehouse where id = " & warehouseId
                dr = .ExecuteReader
            End With
            dr.Read()
            prevQ = CInt(dr("inStock"))
                quantity += prevQ
                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE warehouse set inStock = @inStock where ID = @warehouseId"
                    .Parameters.Add(New System.Data.OleDb.OleDbParameter("@inStock", System.Data.OleDb.OleDbType.Numeric, 255, quantity))
                    .Parameters.Add(New System.Data.OleDb.OleDbParameter("@warehouseId", System.Data.OleDb.OleDbType.Integer, 255, warehouseId))



                    ' RUN THE COMMAND
                    cm.Parameters("@inStock").Value = quantity
                    cm.Parameters("@warehouseId").Value = warehouseId



                    cm.ExecuteNonQuery()

                    MsgBox("Record saved.", MsgBoxStyle.Information)

                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWarehouse.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFarmer.SelectedIndexChanged

    End Sub

    Private Sub keep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM farmers"
                dr = .ExecuteReader
            End With
            cboFarmer.Items.Clear()
            While dr.Read()

                cboFarmer.Items.Add(dr("id") & "-" & dr("fname"))


            End While
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM warehouse"
                dr = .ExecuteReader
            End With

            cboWarehouse.Items.Clear()

            While dr.Read()

                cboWarehouse.Items.Add(dr("ID") & "-" & dr("location"))
            End While

        Catch ex As Exception

        End Try
    End Sub
End Class