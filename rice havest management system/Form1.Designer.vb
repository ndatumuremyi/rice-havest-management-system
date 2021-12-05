<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehousesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FarmerToolStripMenuItem, Me.LeadersToolStripMenuItem, Me.WarehousesToolStripMenuItem, Me.OperationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.HomeToolStripMenuItem.Text = "home"
        '
        'FarmerToolStripMenuItem
        '
        Me.FarmerToolStripMenuItem.Name = "FarmerToolStripMenuItem"
        Me.FarmerToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FarmerToolStripMenuItem.Text = "farmers"
        '
        'LeadersToolStripMenuItem
        '
        Me.LeadersToolStripMenuItem.Name = "LeadersToolStripMenuItem"
        Me.LeadersToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.LeadersToolStripMenuItem.Text = "leaders"
        '
        'WarehousesToolStripMenuItem
        '
        Me.WarehousesToolStripMenuItem.Name = "WarehousesToolStripMenuItem"
        Me.WarehousesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.WarehousesToolStripMenuItem.Text = "warehouses"
        '
        'OperationsToolStripMenuItem
        '
        Me.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem"
        Me.OperationsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.OperationsToolStripMenuItem.Text = "operations"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(462, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 55)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "withdraw"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(462, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "keep rice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(214, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(621, 39)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Welcome to Rice Harvest Management"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1063, 473)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WarehousesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
