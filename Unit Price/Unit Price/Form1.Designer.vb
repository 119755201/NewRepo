<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitPrice
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
        Me.txtPriceOfItem = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.lblPriceOfItem = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblOunces = New System.Windows.Forms.Label()
        Me.txtPricePerOunce = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblPricePerOunce = New System.Windows.Forms.Label()
        Me.btnDetermineUnitPrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPriceOfItem
        '
        Me.txtPriceOfItem.Location = New System.Drawing.Point(176, 65)
        Me.txtPriceOfItem.Name = "txtPriceOfItem"
        Me.txtPriceOfItem.Size = New System.Drawing.Size(322, 26)
        Me.txtPriceOfItem.TabIndex = 0
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(176, 165)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 26)
        Me.txtPounds.TabIndex = 1
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(398, 165)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(100, 26)
        Me.txtOunces.TabIndex = 2
        '
        'lblPriceOfItem
        '
        Me.lblPriceOfItem.AutoSize = True
        Me.lblPriceOfItem.Location = New System.Drawing.Point(61, 65)
        Me.lblPriceOfItem.Name = "lblPriceOfItem"
        Me.lblPriceOfItem.Size = New System.Drawing.Size(98, 20)
        Me.lblPriceOfItem.TabIndex = 3
        Me.lblPriceOfItem.Text = "Price of Item"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(96, 165)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(63, 20)
        Me.lblPounds.TabIndex = 4
        Me.lblPounds.Text = "Pounds"
        '
        'lblOunces
        '
        Me.lblOunces.AutoSize = True
        Me.lblOunces.Location = New System.Drawing.Point(311, 168)
        Me.lblOunces.Name = "lblOunces"
        Me.lblOunces.Size = New System.Drawing.Size(64, 20)
        Me.lblOunces.TabIndex = 5
        Me.lblOunces.Text = "Ounces"
        '
        'txtPricePerOunce
        '
        Me.txtPricePerOunce.BackColor = System.Drawing.Color.Cornsilk
        Me.txtPricePerOunce.Location = New System.Drawing.Point(176, 295)
        Me.txtPricePerOunce.Name = "txtPricePerOunce"
        Me.txtPricePerOunce.ReadOnly = True
        Me.txtPricePerOunce.Size = New System.Drawing.Size(322, 26)
        Me.txtPricePerOunce.TabIndex = 6
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(281, 119)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(94, 29)
        Me.lblWeight.TabIndex = 7
        Me.lblWeight.Text = "Weight"
        '
        'lblPricePerOunce
        '
        Me.lblPricePerOunce.AutoSize = True
        Me.lblPricePerOunce.Location = New System.Drawing.Point(36, 295)
        Me.lblPricePerOunce.Name = "lblPricePerOunce"
        Me.lblPricePerOunce.Size = New System.Drawing.Size(123, 20)
        Me.lblPricePerOunce.TabIndex = 8
        Me.lblPricePerOunce.Text = "Price Per Ounce"
        '
        'btnDetermineUnitPrice
        '
        Me.btnDetermineUnitPrice.BackColor = System.Drawing.Color.DarkGray
        Me.btnDetermineUnitPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDetermineUnitPrice.Location = New System.Drawing.Point(176, 221)
        Me.btnDetermineUnitPrice.Name = "btnDetermineUnitPrice"
        Me.btnDetermineUnitPrice.Size = New System.Drawing.Size(322, 49)
        Me.btnDetermineUnitPrice.TabIndex = 9
        Me.btnDetermineUnitPrice.Text = "Determine Unit Price"
        Me.btnDetermineUnitPrice.UseVisualStyleBackColor = False
        '
        'frmUnitPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(617, 379)
        Me.Controls.Add(Me.btnDetermineUnitPrice)
        Me.Controls.Add(Me.lblPricePerOunce)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtPricePerOunce)
        Me.Controls.Add(Me.lblOunces)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.lblPriceOfItem)
        Me.Controls.Add(Me.txtOunces)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.txtPriceOfItem)
        Me.Name = "frmUnitPrice"
        Me.Text = "Unit Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPriceOfItem As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents txtOunces As TextBox
    Friend WithEvents lblPriceOfItem As Label
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblOunces As Label
    Friend WithEvents txtPricePerOunce As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblPricePerOunce As Label
    Friend WithEvents btnDetermineUnitPrice As Button
End Class
