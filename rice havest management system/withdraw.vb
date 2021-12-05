Public Class withdraw
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


            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO operations (farmerId,warehouseId,quantity, type) VALUES (@farmerId,@warehouseId,@quantity, @type)"
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@farmerId", System.Data.OleDb.OleDbType.VarChar, 255, farmerId))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@warehouseId", System.Data.OleDb.OleDbType.VarChar, 255, warehouseId))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@quantity", System.Data.OleDb.OleDbType.VarChar, 255, quantity))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@type", System.Data.OleDb.OleDbType.VarChar, 255, "OUT"))


                ' RUN THE COMMAND
                cm.Parameters("@farmerId").Value = farmerId
                cm.Parameters("@warehouseId").Value = warehouseId
                cm.Parameters("@quantity").Value = quantity
                cm.Parameters("@type").Value = "OUT"


                cm.ExecuteNonQuery()

            End With
            Dim prevQ As Integer
            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM warehouse where id = " & warehouseId
                dr = .ExecuteReader
            End With
            dr.Read()
            prevQ = CInt(dr("inStock"))
            prevQ -= quantity

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "UPDATE warehouse set inStock = @inStock where ID = @warehouseId"
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@inStock", System.Data.OleDb.OleDbType.Numeric, 255, prevQ))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@warehouseId", System.Data.OleDb.OleDbType.Integer, 255, warehouseId))



                ' RUN THE COMMAND
                cm.Parameters("@inStock").Value = prevQ
                cm.Parameters("@warehouseId").Value = warehouseId



                cm.ExecuteNonQuery()
            End With


            MsgBox("complete")
        Catch ex As Exception

        End Try
    End Sub
    Sub onValueChangeListener(sender As Object, e As EventArgs) Handles cboWarehouse.SelectedIndexChanged, cboFarmer.SelectedIndexChanged

        Try

            If (cboFarmer.SelectedIndex.Equals(-1)) Then
                MsgBox("msg farn")
                'Exit Sub
            End If
            Dim farmer As String = cboFarmer.SelectedItem.ToString()

            Dim farmerId As String = ""
            If (cboWarehouse.SelectedIndex.Equals(-1)) Then
                'MsgBox("msg wr")
                Exit Sub
            End If
            Dim warehouse As String = cboWarehouse.SelectedItem.ToString()
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

            Dim query As String
            query = "SELECT * FROM operations WHERE farmerId =" & farmerId & " AND warehouseId =" & warehouseId



            Try
                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    dr = .ExecuteReader
                End With

                Dim leftQ As Integer = 0
                While dr.Read()
                    If dr("type").Equals("IN") Then
                        leftQ += CInt(dr("quantity"))
                    ElseIf dr("type").Equals("OUT") Then
                        leftQ -= CInt(dr("quantity"))

                    End If


                End While
                lboQuantity.Text = leftQ.ToString
            Catch ex As Exception

            End Try
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub


    Private Sub withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cboWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWarehouse.SelectedIndexChanged

    End Sub
End Class