﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInformation
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
        Me.lstCarModels = New System.Windows.Forms.ListBox()
        Me.lblAvailableCars = New System.Windows.Forms.Label()
        Me.gbxCarDetails = New System.Windows.Forms.GroupBox()
        Me.txtTotalDays = New System.Windows.Forms.TextBox()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblCarSelected = New System.Windows.Forms.Label()
        Me.txtCarSelected = New System.Windows.Forms.TextBox()
        Me.gbxPriceDetails = New System.Windows.Forms.GroupBox()
        Me.lblTotalExVAT = New System.Windows.Forms.Label()
        Me.lblTotalVAT = New System.Windows.Forms.Label()
        Me.lblTotalIncVAT = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtTotalExVAT = New System.Windows.Forms.TextBox()
        Me.txtTotalVAT = New System.Windows.Forms.TextBox()
        Me.txtTotalIncVAT = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbxCarDetails.SuspendLayout()
        Me.gbxPriceDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCarModels
        '
        Me.lstCarModels.FormattingEnabled = True
        Me.lstCarModels.ItemHeight = 25
        Me.lstCarModels.Items.AddRange(New Object() {"VW Up 1.0 Litre (or equivalent)", "Mini Hatchback 1.2 Litre (or equivalent)", "Audi A1 1.4 Litre (or equivalent)", "Alfa Romeo Giulietta 1.6 Litre (or equivalent) ", "Subaru Outback 2.0 Litre (or equivalent)"})
        Me.lstCarModels.Location = New System.Drawing.Point(289, 44)
        Me.lstCarModels.Name = "lstCarModels"
        Me.lstCarModels.Size = New System.Drawing.Size(364, 29)
        Me.lstCarModels.TabIndex = 1
        '
        'lblAvailableCars
        '
        Me.lblAvailableCars.AutoSize = True
        Me.lblAvailableCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableCars.Location = New System.Drawing.Point(85, 44)
        Me.lblAvailableCars.Name = "lblAvailableCars"
        Me.lblAvailableCars.Size = New System.Drawing.Size(167, 29)
        Me.lblAvailableCars.TabIndex = 2
        Me.lblAvailableCars.Text = "Available Cars"
        '
        'gbxCarDetails
        '
        Me.gbxCarDetails.Controls.Add(Me.btnCalculate)
        Me.gbxCarDetails.Controls.Add(Me.lblPrice)
        Me.gbxCarDetails.Controls.Add(Me.lblCarSelected)
        Me.gbxCarDetails.Controls.Add(Me.txtCarSelected)
        Me.gbxCarDetails.Controls.Add(Me.lblTotalDays)
        Me.gbxCarDetails.Controls.Add(Me.txtTotalDays)
        Me.gbxCarDetails.Controls.Add(Me.lblAvailableCars)
        Me.gbxCarDetails.Controls.Add(Me.lstCarModels)
        Me.gbxCarDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbxCarDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCarDetails.Location = New System.Drawing.Point(29, 40)
        Me.gbxCarDetails.Name = "gbxCarDetails"
        Me.gbxCarDetails.Size = New System.Drawing.Size(854, 306)
        Me.gbxCarDetails.TabIndex = 3
        Me.gbxCarDetails.TabStop = False
        Me.gbxCarDetails.Text = "Car Details"
        '
        'txtTotalDays
        '
        Me.txtTotalDays.Location = New System.Drawing.Point(289, 103)
        Me.txtTotalDays.Name = "txtTotalDays"
        Me.txtTotalDays.ReadOnly = True
        Me.txtTotalDays.Size = New System.Drawing.Size(77, 30)
        Me.txtTotalDays.TabIndex = 4
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(146, 108)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(106, 25)
        Me.lblTotalDays.TabIndex = 5
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblCarSelected
        '
        Me.lblCarSelected.AutoSize = True
        Me.lblCarSelected.Location = New System.Drawing.Point(126, 170)
        Me.lblCarSelected.Name = "lblCarSelected"
        Me.lblCarSelected.Size = New System.Drawing.Size(126, 25)
        Me.lblCarSelected.TabIndex = 7
        Me.lblCarSelected.Text = "Car Selected"
        '
        'txtCarSelected
        '
        Me.txtCarSelected.Location = New System.Drawing.Point(289, 170)
        Me.txtCarSelected.Name = "txtCarSelected"
        Me.txtCarSelected.ReadOnly = True
        Me.txtCarSelected.Size = New System.Drawing.Size(313, 30)
        Me.txtCarSelected.TabIndex = 6
        '
        'gbxPriceDetails
        '
        Me.gbxPriceDetails.Controls.Add(Me.txtTotalIncVAT)
        Me.gbxPriceDetails.Controls.Add(Me.txtTotalVAT)
        Me.gbxPriceDetails.Controls.Add(Me.txtTotalExVAT)
        Me.gbxPriceDetails.Controls.Add(Me.lblTotalIncVAT)
        Me.gbxPriceDetails.Controls.Add(Me.lblTotalVAT)
        Me.gbxPriceDetails.Controls.Add(Me.lblTotalExVAT)
        Me.gbxPriceDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbxPriceDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPriceDetails.Location = New System.Drawing.Point(29, 374)
        Me.gbxPriceDetails.Name = "gbxPriceDetails"
        Me.gbxPriceDetails.Size = New System.Drawing.Size(854, 224)
        Me.gbxPriceDetails.TabIndex = 4
        Me.gbxPriceDetails.TabStop = False
        Me.gbxPriceDetails.Text = "Price Details"
        '
        'lblTotalExVAT
        '
        Me.lblTotalExVAT.AutoSize = True
        Me.lblTotalExVAT.Location = New System.Drawing.Point(60, 49)
        Me.lblTotalExVAT.Name = "lblTotalExVAT"
        Me.lblTotalExVAT.Size = New System.Drawing.Size(192, 25)
        Me.lblTotalExVAT.TabIndex = 0
        Me.lblTotalExVAT.Text = "Total Excluding VAT"
        '
        'lblTotalVAT
        '
        Me.lblTotalVAT.AutoSize = True
        Me.lblTotalVAT.Location = New System.Drawing.Point(60, 105)
        Me.lblTotalVAT.Name = "lblTotalVAT"
        Me.lblTotalVAT.Size = New System.Drawing.Size(102, 25)
        Me.lblTotalVAT.TabIndex = 1
        Me.lblTotalVAT.Text = "Total VAT"
        '
        'lblTotalIncVAT
        '
        Me.lblTotalIncVAT.AutoSize = True
        Me.lblTotalIncVAT.Location = New System.Drawing.Point(60, 164)
        Me.lblTotalIncVAT.Name = "lblTotalIncVAT"
        Me.lblTotalIncVAT.Size = New System.Drawing.Size(185, 25)
        Me.lblTotalIncVAT.TabIndex = 2
        Me.lblTotalIncVAT.Text = "Total Including VAT"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(196, 237)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(56, 25)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(289, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 47)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtTotalExVAT
        '
        Me.txtTotalExVAT.Location = New System.Drawing.Point(289, 49)
        Me.txtTotalExVAT.Name = "txtTotalExVAT"
        Me.txtTotalExVAT.ReadOnly = True
        Me.txtTotalExVAT.Size = New System.Drawing.Size(313, 30)
        Me.txtTotalExVAT.TabIndex = 7
        '
        'txtTotalVAT
        '
        Me.txtTotalVAT.Location = New System.Drawing.Point(289, 102)
        Me.txtTotalVAT.Name = "txtTotalVAT"
        Me.txtTotalVAT.ReadOnly = True
        Me.txtTotalVAT.Size = New System.Drawing.Size(313, 30)
        Me.txtTotalVAT.TabIndex = 8
        '
        'txtTotalIncVAT
        '
        Me.txtTotalIncVAT.Location = New System.Drawing.Point(289, 164)
        Me.txtTotalIncVAT.Name = "txtTotalIncVAT"
        Me.txtTotalIncVAT.ReadOnly = True
        Me.txtTotalIncVAT.Size = New System.Drawing.Size(313, 30)
        Me.txtTotalIncVAT.TabIndex = 9
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(567, 617)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 40)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(230, 618)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 39)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmCarInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 681)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.gbxCarDetails)
        Me.Controls.Add(Me.gbxPriceDetails)
        Me.Name = "frmCarInformation"
        Me.Text = "Car Information"
        Me.gbxCarDetails.ResumeLayout(False)
        Me.gbxCarDetails.PerformLayout()
        Me.gbxPriceDetails.ResumeLayout(False)
        Me.gbxPriceDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCarModels As ListBox
    Friend WithEvents lblAvailableCars As Label
    Friend WithEvents gbxCarDetails As GroupBox
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents txtTotalDays As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCarSelected As Label
    Friend WithEvents txtCarSelected As TextBox
    Friend WithEvents gbxPriceDetails As GroupBox
    Friend WithEvents lblTotalIncVAT As Label
    Friend WithEvents lblTotalVAT As Label
    Friend WithEvents lblTotalExVAT As Label
    Friend WithEvents txtTotalIncVAT As TextBox
    Friend WithEvents txtTotalVAT As TextBox
    Friend WithEvents txtTotalExVAT As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class