<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdraw
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
        Me.lboQuantity = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cboWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFarmer = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboQuantity
        '
        Me.lboQuantity.AutoSize = True
        Me.lboQuantity.Location = New System.Drawing.Point(246, 189)
        Me.lboQuantity.Name = "lboQuantity"
        Me.lboQuantity.Size = New System.Drawing.Size(31, 13)
        Me.lboQuantity.TabIndex = 24
        Me.lboQuantity.Text = "none"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "quantity you have"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(212, 243)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 21
        '
        'cboWarehouse
        '
        Me.cboWarehouse.FormattingEnabled = True
        Me.cboWarehouse.Location = New System.Drawing.Point(212, 113)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(121, 21)
        Me.cboWarehouse.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Enter quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "choose warehouse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "choose user"
        '
        'cboFarmer
        '
        Me.cboFarmer.FormattingEnabled = True
        Me.cboFarmer.Location = New System.Drawing.Point(212, 33)
        Me.cboFarmer.Name = "cboFarmer"
        Me.cboFarmer.Size = New System.Drawing.Size(121, 21)
        Me.cboFarmer.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(382, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 39)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Get Rice from store"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboFarmer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lboQuantity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.cboWarehouse)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(389, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 382)
        Me.Panel1.TabIndex = 26
        '
        'withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 546)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "withdraw"
        Me.Text = "withdraw"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboQuantity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cboWarehouse As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFarmer As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
