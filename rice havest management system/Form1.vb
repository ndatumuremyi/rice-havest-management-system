Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As New keep()
        k.Show()
    End Sub

    Private Sub OperationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperationsToolStripMenuItem.Click
        Dim op As New OpForm
        op.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call closeConnection()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim withD As New withdraw()
        withD.Show()
    End Sub

    Private Sub FarmerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarmerToolStripMenuItem.Click
        Dim f As New famers
        f.Show()
    End Sub

    Private Sub LeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadersToolStripMenuItem.Click
        Dim c As New leader
        c.Show()
    End Sub

    Private Sub WarehousesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehousesToolStripMenuItem.Click
        Dim w As New warehouseF
        w.Show()
    End Sub

    Private Sub Welcome_Click(sender As Object, e As EventArgs)

    End Sub
End Class
