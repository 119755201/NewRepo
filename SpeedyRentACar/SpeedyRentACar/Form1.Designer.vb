﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentACar
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtStAddress = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtDaysRequiredTotal = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtPassportNumber = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerStAddress = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblCustomerRequests = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.gbxCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.rtbCustomerRequestInput = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblCustomerSignUp = New System.Windows.Forms.Label()
        Me.cbxPaymentType = New System.Windows.Forms.ComboBox()
        Me.gbxCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(235, 41)
        Me.txtCustomerName.MaxLength = 30
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 30)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtStAddress
        '
        Me.txtStAddress.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStAddress.Location = New System.Drawing.Point(236, 90)
        Me.txtStAddress.MaxLength = 50
        Me.txtStAddress.Name = "txtStAddress"
        Me.txtStAddress.Size = New System.Drawing.Size(100, 30)
        Me.txtStAddress.TabIndex = 2
        '
        'txtTownCity
        '
        Me.txtTownCity.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTownCity.Location = New System.Drawing.Point(235, 153)
        Me.txtTownCity.MaxLength = 20
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(100, 30)
        Me.txtTownCity.TabIndex = 3
        '
        'txtCounty
        '
        Me.txtCounty.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounty.Location = New System.Drawing.Point(235, 213)
        Me.txtCounty.MaxLength = 10
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 30)
        Me.txtCounty.TabIndex = 4
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(236, 269)
        Me.txtContactNumber.MaxLength = 8
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(100, 30)
        Me.txtContactNumber.TabIndex = 5
        '
        'txtDaysRequiredTotal
        '
        Me.txtDaysRequiredTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysRequiredTotal.Location = New System.Drawing.Point(591, 41)
        Me.txtDaysRequiredTotal.Name = "txtDaysRequiredTotal"
        Me.txtDaysRequiredTotal.Size = New System.Drawing.Size(79, 30)
        Me.txtDaysRequiredTotal.TabIndex = 10
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(591, 210)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(100, 30)
        Me.txtCardNumber.TabIndex = 8
        '
        'txtPassportNumber
        '
        Me.txtPassportNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassportNumber.Location = New System.Drawing.Point(591, 90)
        Me.txtPassportNumber.Name = "txtPassportNumber"
        Me.txtPassportNumber.Size = New System.Drawing.Size(100, 30)
        Me.txtPassportNumber.TabIndex = 6
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(72, 41)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(150, 24)
        Me.lblCustomerName.TabIndex = 11
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblCustomerStAddress
        '
        Me.lblCustomerStAddress.AutoSize = True
        Me.lblCustomerStAddress.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerStAddress.Location = New System.Drawing.Point(89, 90)
        Me.lblCustomerStAddress.Name = "lblCustomerStAddress"
        Me.lblCustomerStAddress.Size = New System.Drawing.Size(136, 24)
        Me.lblCustomerStAddress.TabIndex = 12
        Me.lblCustomerStAddress.Text = "Street Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Town/City"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(146, 213)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(72, 24)
        Me.lblCounty.TabIndex = 14
        Me.lblCounty.Text = "County"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(72, 269)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(154, 24)
        Me.lblContactNumber.TabIndex = 15
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassportNumber.Location = New System.Drawing.Point(424, 90)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassportNumber.Size = New System.Drawing.Size(161, 24)
        Me.lblPassportNumber.TabIndex = 20
        Me.lblPassportNumber.Text = "Passport Number"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(441, 153)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(133, 24)
        Me.lblPaymentType.TabIndex = 19
        Me.lblPaymentType.Text = "Payment Type"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(343, 210)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(242, 24)
        Me.lblCardNumber.TabIndex = 18
        Me.lblCardNumber.Text = "Credit/Debit Card Number"
        '
        'lblCustomerRequests
        '
        Me.lblCustomerRequests.AutoSize = True
        Me.lblCustomerRequests.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerRequests.Location = New System.Drawing.Point(420, 269)
        Me.lblCustomerRequests.Name = "lblCustomerRequests"
        Me.lblCustomerRequests.Size = New System.Drawing.Size(181, 24)
        Me.lblCustomerRequests.TabIndex = 17
        Me.lblCustomerRequests.Text = "Customer Requests "
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(350, 41)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(235, 24)
        Me.lblNumberOfDays.TabIndex = 16
        Me.lblNumberOfDays.Text = "Number of Days Required"
        '
        'gbxCustomerInformation
        '
        Me.gbxCustomerInformation.Controls.Add(Me.cbxPaymentType)
        Me.gbxCustomerInformation.Controls.Add(Me.lblContactNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCardNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.txtCustomerName)
        Me.gbxCustomerInformation.Controls.Add(Me.txtStAddress)
        Me.gbxCustomerInformation.Controls.Add(Me.txtTownCity)
        Me.gbxCustomerInformation.Controls.Add(Me.txtCounty)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCustomerStAddress)
        Me.gbxCustomerInformation.Controls.Add(Me.Label3)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCounty)
        Me.gbxCustomerInformation.Controls.Add(Me.lblPaymentType)
        Me.gbxCustomerInformation.Controls.Add(Me.lblPassportNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.txtPassportNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCustomerName)
        Me.gbxCustomerInformation.Controls.Add(Me.txtCardNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.rtbCustomerRequestInput)
        Me.gbxCustomerInformation.Controls.Add(Me.txtDaysRequiredTotal)
        Me.gbxCustomerInformation.Controls.Add(Me.lblNumberOfDays)
        Me.gbxCustomerInformation.Controls.Add(Me.txtContactNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCustomerRequests)
        Me.gbxCustomerInformation.Location = New System.Drawing.Point(29, 119)
        Me.gbxCustomerInformation.Name = "gbxCustomerInformation"
        Me.gbxCustomerInformation.Size = New System.Drawing.Size(868, 414)
        Me.gbxCustomerInformation.TabIndex = 22
        Me.gbxCustomerInformation.TabStop = False
        Me.gbxCustomerInformation.Text = "Customer Information"
        '
        'rtbCustomerRequestInput
        '
        Me.rtbCustomerRequestInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCustomerRequestInput.Location = New System.Drawing.Point(591, 269)
        Me.rtbCustomerRequestInput.MaxLength = 300
        Me.rtbCustomerRequestInput.Name = "rtbCustomerRequestInput"
        Me.rtbCustomerRequestInput.Size = New System.Drawing.Size(221, 119)
        Me.rtbCustomerRequestInput.TabIndex = 11
        Me.rtbCustomerRequestInput.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 581)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 50)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(571, 581)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(149, 50)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblCustomerSignUp
        '
        Me.lblCustomerSignUp.AutoSize = True
        Me.lblCustomerSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerSignUp.Location = New System.Drawing.Point(242, 37)
        Me.lblCustomerSignUp.Name = "lblCustomerSignUp"
        Me.lblCustomerSignUp.Size = New System.Drawing.Size(417, 55)
        Me.lblCustomerSignUp.TabIndex = 23
        Me.lblCustomerSignUp.Text = "Customer Sign Up"
        '
        'cbxPaymentType
        '
        Me.cbxPaymentType.FormattingEnabled = True
        Me.cbxPaymentType.Items.AddRange(New Object() {"Visa ", "Mastercard"})
        Me.cbxPaymentType.Location = New System.Drawing.Point(591, 154)
        Me.cbxPaymentType.Name = "cbxPaymentType"
        Me.cbxPaymentType.Size = New System.Drawing.Size(121, 28)
        Me.cbxPaymentType.TabIndex = 21
        '
        'frmRentACar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(934, 681)
        Me.Controls.Add(Me.lblCustomerSignUp)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxCustomerInformation)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmRentACar"
        Me.Text = "Rent-A-Car"
        Me.gbxCustomerInformation.ResumeLayout(False)
        Me.gbxCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtStAddress As TextBox
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtDaysRequiredTotal As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtPassportNumber As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerStAddress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblPassportNumber As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblCustomerRequests As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents gbxCustomerInformation As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents rtbCustomerRequestInput As RichTextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblCustomerSignUp As Label
    Friend WithEvents cbxPaymentType As ComboBox
End Class
