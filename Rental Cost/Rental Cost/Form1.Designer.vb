<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalCost
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
        Me.btnDisplayRates = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.lblSelectDuration = New System.Windows.Forms.Label()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstDisplayBill = New System.Windows.Forms.ListBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplayRates
        '
        Me.btnDisplayRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayRates.Location = New System.Drawing.Point(73, 30)
        Me.btnDisplayRates.Name = "btnDisplayRates"
        Me.btnDisplayRates.Size = New System.Drawing.Size(203, 74)
        Me.btnDisplayRates.TabIndex = 0
        Me.btnDisplayRates.Text = "Display Rental Rates"
        Me.btnDisplayRates.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBill.Location = New System.Drawing.Point(73, 312)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(203, 74)
        Me.btnDisplayBill.TabIndex = 1
        Me.btnDisplayBill.Text = "Display Rental Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'lblSelectDuration
        '
        Me.lblSelectDuration.AutoSize = True
        Me.lblSelectDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDuration.Location = New System.Drawing.Point(68, 257)
        Me.lblSelectDuration.Name = "lblSelectDuration"
        Me.lblSelectDuration.Size = New System.Drawing.Size(217, 25)
        Me.lblSelectDuration.TabIndex = 2
        Me.lblSelectDuration.Text = "Select Duration (H or F)"
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectItem.Location = New System.Drawing.Point(78, 138)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(198, 25)
        Me.lblSelectItem.TabIndex = 3
        Me.lblSelectItem.Text = "Select Item (1, 2 or 3)"
        '
        'lstRentalRates
        '
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.ItemHeight = 20
        Me.lstRentalRates.Location = New System.Drawing.Point(412, 30)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(347, 164)
        Me.lstRentalRates.TabIndex = 4
        '
        'lstDisplayBill
        '
        Me.lstDisplayBill.FormattingEnabled = True
        Me.lstDisplayBill.ItemHeight = 20
        Me.lstDisplayBill.Location = New System.Drawing.Point(412, 222)
        Me.lstDisplayBill.Name = "lstDisplayBill"
        Me.lstDisplayBill.Size = New System.Drawing.Size(347, 164)
        Me.lstDisplayBill.TabIndex = 5
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(315, 256)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(76, 26)
        Me.txtDuration.TabIndex = 6
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(315, 139)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(76, 26)
        Me.txtItem.TabIndex = 7
        '
        'frmRentalCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.lstDisplayBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Controls.Add(Me.lblSelectItem)
        Me.Controls.Add(Me.lblSelectDuration)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRates)
        Me.Name = "frmRentalCost"
        Me.Text = "Rental Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayRates As Button
    Friend WithEvents btnDisplayBill As Button
    Friend WithEvents lblSelectDuration As Label
    Friend WithEvents lblSelectItem As Label
    Friend WithEvents lstRentalRates As ListBox
    Friend WithEvents lstDisplayBill As ListBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtItem As TextBox
End Class
