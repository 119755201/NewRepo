<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsuranceInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsuranceInformation))
        Dim cbxVehicleContents As System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVehicleContents = New System.Windows.Forms.TextBox()
        Me.txtTheft = New System.Windows.Forms.TextBox()
        Me.txtCollisionDamageWaiver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTheft = New System.Windows.Forms.CheckBox()
        Me.cbxCollisionDamage = New System.Windows.Forms.CheckBox()
        Me.lblRoofRack = New System.Windows.Forms.Label()
        Me.lblTheft = New System.Windows.Forms.Label()
        Me.lblColisionWaiver = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        cbxVehicleContents = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Important to Note!"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(44, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(763, 179)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVehicleContents)
        Me.GroupBox2.Controls.Add(Me.txtTheft)
        Me.GroupBox2.Controls.Add(Me.txtCollisionDamageWaiver)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(cbxVehicleContents)
        Me.GroupBox2.Controls.Add(Me.cbxTheft)
        Me.GroupBox2.Controls.Add(Me.cbxCollisionDamage)
        Me.GroupBox2.Controls.Add(Me.lblRoofRack)
        Me.GroupBox2.Controls.Add(Me.lblTheft)
        Me.GroupBox2.Controls.Add(Me.lblColisionWaiver)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 267)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insurance Options"
        '
        'txtVehicleContents
        '
        Me.txtVehicleContents.Location = New System.Drawing.Point(471, 167)
        Me.txtVehicleContents.Name = "txtVehicleContents"
        Me.txtVehicleContents.ReadOnly = True
        Me.txtVehicleContents.Size = New System.Drawing.Size(100, 30)
        Me.txtVehicleContents.TabIndex = 26
        '
        'txtTheft
        '
        Me.txtTheft.Location = New System.Drawing.Point(471, 116)
        Me.txtTheft.Name = "txtTheft"
        Me.txtTheft.ReadOnly = True
        Me.txtTheft.Size = New System.Drawing.Size(100, 30)
        Me.txtTheft.TabIndex = 25
        '
        'txtCollisionDamageWaiver
        '
        Me.txtCollisionDamageWaiver.Location = New System.Drawing.Point(471, 70)
        Me.txtCollisionDamageWaiver.Name = "txtCollisionDamageWaiver"
        Me.txtCollisionDamageWaiver.ReadOnly = True
        Me.txtCollisionDamageWaiver.Size = New System.Drawing.Size(100, 30)
        Me.txtCollisionDamageWaiver.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(484, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Prices"
        '
        'cbxVehicleContents
        '
        cbxVehicleContents.AutoSize = True
        cbxVehicleContents.Location = New System.Drawing.Point(628, 171)
        cbxVehicleContents.Name = "cbxVehicleContents"
        cbxVehicleContents.Size = New System.Drawing.Size(22, 21)
        cbxVehicleContents.TabIndex = 22
        cbxVehicleContents.UseVisualStyleBackColor = True
        '
        'cbxTheft
        '
        Me.cbxTheft.AutoSize = True
        Me.cbxTheft.Location = New System.Drawing.Point(628, 120)
        Me.cbxTheft.Name = "cbxTheft"
        Me.cbxTheft.Size = New System.Drawing.Size(22, 21)
        Me.cbxTheft.TabIndex = 21
        Me.cbxTheft.UseVisualStyleBackColor = True
        '
        'cbxCollisionDamage
        '
        Me.cbxCollisionDamage.AutoSize = True
        Me.cbxCollisionDamage.Location = New System.Drawing.Point(628, 70)
        Me.cbxCollisionDamage.Name = "cbxCollisionDamage"
        Me.cbxCollisionDamage.Size = New System.Drawing.Size(22, 21)
        Me.cbxCollisionDamage.TabIndex = 20
        Me.cbxCollisionDamage.UseVisualStyleBackColor = True
        '
        'lblRoofRack
        '
        Me.lblRoofRack.AutoSize = True
        Me.lblRoofRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoofRack.Location = New System.Drawing.Point(174, 171)
        Me.lblRoofRack.Name = "lblRoofRack"
        Me.lblRoofRack.Size = New System.Drawing.Size(200, 29)
        Me.lblRoofRack.TabIndex = 18
        Me.lblRoofRack.Text = "Vehicle Contents "
        '
        'lblTheft
        '
        Me.lblTheft.AutoSize = True
        Me.lblTheft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheft.Location = New System.Drawing.Point(239, 117)
        Me.lblTheft.Name = "lblTheft"
        Me.lblTheft.Size = New System.Drawing.Size(68, 29)
        Me.lblTheft.TabIndex = 16
        Me.lblTheft.Text = "Theft"
        '
        'lblColisionWaiver
        '
        Me.lblColisionWaiver.AutoSize = True
        Me.lblColisionWaiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColisionWaiver.Location = New System.Drawing.Point(124, 69)
        Me.lblColisionWaiver.Name = "lblColisionWaiver"
        Me.lblColisionWaiver.Size = New System.Drawing.Size(284, 29)
        Me.lblColisionWaiver.TabIndex = 13
        Me.lblColisionWaiver.Text = "Collision Damage Waiver"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(195, 599)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 39)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(532, 598)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 40)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmInsuranceInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 681)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmInsuranceInformation"
        Me.Text = "Insurance Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtVehicleContents As TextBox
    Friend WithEvents txtTheft As TextBox
    Friend WithEvents txtCollisionDamageWaiver As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTheft As CheckBox
    Friend WithEvents cbxCollisionDamage As CheckBox
    Friend WithEvents lblRoofRack As Label
    Friend WithEvents lblTheft As Label
    Friend WithEvents lblColisionWaiver As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
