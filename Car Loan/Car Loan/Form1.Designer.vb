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
        Me.lblAmountOfLoan = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblNumberOfYears = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.btnCalculatePayments = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmountOfLoan
        '
        Me.lblAmountOfLoan.AutoSize = True
        Me.lblAmountOfLoan.Location = New System.Drawing.Point(200, 65)
        Me.lblAmountOfLoan.Name = "lblAmountOfLoan"
        Me.lblAmountOfLoan.Size = New System.Drawing.Size(123, 20)
        Me.lblAmountOfLoan.TabIndex = 0
        Me.lblAmountOfLoan.Text = "Amount of Loan"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(200, 132)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(131, 20)
        Me.lblInterestRate.TabIndex = 1
        Me.lblInterestRate.Text = "Interest Rate (%)"
        '
        'lblNumberOfYears
        '
        Me.lblNumberOfYears.AutoSize = True
        Me.lblNumberOfYears.Location = New System.Drawing.Point(200, 194)
        Me.lblNumberOfYears.Name = "lblNumberOfYears"
        Me.lblNumberOfYears.Size = New System.Drawing.Size(129, 20)
        Me.lblNumberOfYears.TabIndex = 3
        Me.lblNumberOfYears.Text = "Number of Years"
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(193, 356)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(130, 20)
        Me.lblMonthlyPayment.TabIndex = 2
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(383, 62)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(153, 26)
        Me.txtAmount.TabIndex = 4
        '
        'txtinterest
        '
        Me.txtinterest.Location = New System.Drawing.Point(383, 129)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.Size = New System.Drawing.Size(153, 26)
        Me.txtinterest.TabIndex = 5
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(383, 191)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(153, 26)
        Me.txtYears.TabIndex = 6
        '
        'txtPayments
        '
        Me.txtPayments.Location = New System.Drawing.Point(376, 353)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(153, 26)
        Me.txtPayments.TabIndex = 7
        '
        'btnCalculatePayments
        '
        Me.btnCalculatePayments.Location = New System.Drawing.Point(204, 256)
        Me.btnCalculatePayments.Name = "btnCalculatePayments"
        Me.btnCalculatePayments.Size = New System.Drawing.Size(332, 46)
        Me.btnCalculatePayments.TabIndex = 8
        Me.btnCalculatePayments.Text = "Calculate Monthly Payments"
        Me.btnCalculatePayments.UseVisualStyleBackColor = True
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
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmountOfLoan As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblNumberOfYears As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtinterest As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtPayments As TextBox
    Friend WithEvents btnCalculatePayments As Button
End Class
