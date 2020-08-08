<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConclusion
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.gbxOptionalExtras = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.gbxOptionalExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(222, 551)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 39)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(559, 550)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 40)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'gbxOptionalExtras
        '
        Me.gbxOptionalExtras.Controls.Add(Me.TextBox2)
        Me.gbxOptionalExtras.Controls.Add(Me.TextBox1)
        Me.gbxOptionalExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOptionalExtras.Location = New System.Drawing.Point(32, 52)
        Me.gbxOptionalExtras.Name = "gbxOptionalExtras"
        Me.gbxOptionalExtras.Size = New System.Drawing.Size(853, 427)
        Me.gbxOptionalExtras.TabIndex = 9
        Me.gbxOptionalExtras.TabStop = False
        Me.gbxOptionalExtras.Text = "Lease  Details"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(313, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 32)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(313, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 32)
        Me.TextBox2.TabIndex = 1
        '
        'frmConclusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(934, 681)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.gbxOptionalExtras)
        Me.Name = "frmConclusion"
        Me.Text = "Conclusion"
        Me.gbxOptionalExtras.ResumeLayout(False)
        Me.gbxOptionalExtras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents gbxOptionalExtras As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
