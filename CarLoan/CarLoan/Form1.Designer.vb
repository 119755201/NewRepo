<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
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
        Me.btnCalculatePayments = New System.Windows.Forms.Button()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblNumberOfYears = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblAmountOfLoan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculatePayments
        '
        Me.btnCalculatePayments.Location = New System.Drawing.Point(240, 261)
        Me.btnCalculatePayments.Name = "btnCalculatePayments"
        Me.btnCalculatePayments.Size = New System.Drawing.Size(332, 46)
        Me.btnCalculatePayments.TabIndex = 17
        Me.btnCalculatePayments.Text = "Calculate Monthly Payments"
        Me.btnCalculatePayments.UseVisualStyleBackColor = True
        '
        'txtPayments
        '
        Me.txtPayments.Location = New System.Drawing.Point(412, 358)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(153, 26)
        Me.txtPayments.TabIndex = 16
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(419, 196)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(153, 26)
        Me.txtYears.TabIndex = 15
        '
        'txtinterest
        '
        Me.txtinterest.Location = New System.Drawing.Point(419, 134)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.Size = New System.Drawing.Size(153, 26)
        Me.txtinterest.TabIndex = 14
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(419, 67)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(153, 26)
        Me.txtAmount.TabIndex = 13
        '
        'lblNumberOfYears
        '
        Me.lblNumberOfYears.AutoSize = True
        Me.lblNumberOfYears.Location = New System.Drawing.Point(236, 199)
        Me.lblNumberOfYears.Name = "lblNumberOfYears"
        Me.lblNumberOfYears.Size = New System.Drawing.Size(129, 20)
        Me.lblNumberOfYears.TabIndex = 12
        Me.lblNumberOfYears.Text = "Number of Years"
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(229, 361)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(130, 20)
        Me.lblMonthlyPayment.TabIndex = 11
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(236, 137)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(131, 20)
        Me.lblInterestRate.TabIndex = 10
        Me.lblInterestRate.Text = "Interest Rate (%)"
        '
        'lblAmountOfLoan
        '
        Me.lblAmountOfLoan.AutoSize = True
        Me.lblAmountOfLoan.Location = New System.Drawing.Point(236, 70)
        Me.lblAmountOfLoan.Name = "lblAmountOfLoan"
        Me.lblAmountOfLoan.Size = New System.Drawing.Size(123, 20)
        Me.lblAmountOfLoan.TabIndex = 9
        Me.lblAmountOfLoan.Text = "Amount of Loan"
        '
        'frmCarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculatePayments)
        Me.Controls.Add(Me.txtPayments)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtinterest)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblNumberOfYears)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblAmountOfLoan)
        Me.Name = "frmCarLoan"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculatePayments As Button
    Friend WithEvents txtPayments As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtinterest As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblNumberOfYears As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblAmountOfLoan As Label
End Class
