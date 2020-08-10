<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNutrition
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
        Me.txtNameOfFood = New System.Windows.Forms.TextBox()
        Me.txtCaloriesPerServing = New System.Windows.Forms.TextBox()
        Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.lblCaloriesPerServing = New System.Windows.Forms.Label()
        Me.lblGramsOfFat = New System.Windows.Forms.Label()
        Me.lblNameOfFood = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNameOfFood
        '
        Me.txtNameOfFood.Location = New System.Drawing.Point(490, 57)
        Me.txtNameOfFood.Name = "txtNameOfFood"
        Me.txtNameOfFood.Size = New System.Drawing.Size(100, 26)
        Me.txtNameOfFood.TabIndex = 0
        '
        'txtCaloriesPerServing
        '
        Me.txtCaloriesPerServing.Location = New System.Drawing.Point(490, 112)
        Me.txtCaloriesPerServing.Name = "txtCaloriesPerServing"
        Me.txtCaloriesPerServing.Size = New System.Drawing.Size(100, 26)
        Me.txtCaloriesPerServing.TabIndex = 1
        '
        'txtGramsOfFat
        '
        Me.txtGramsOfFat.Location = New System.Drawing.Point(490, 173)
        Me.txtGramsOfFat.Name = "txtGramsOfFat"
        Me.txtGramsOfFat.Size = New System.Drawing.Size(100, 26)
        Me.txtGramsOfFat.TabIndex = 2
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(266, 221)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(324, 115)
        Me.txtDisplay.TabIndex = 3
        '
        'lblCaloriesPerServing
        '
        Me.lblCaloriesPerServing.AutoSize = True
        Me.lblCaloriesPerServing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaloriesPerServing.Location = New System.Drawing.Point(262, 113)
        Me.lblCaloriesPerServing.Name = "lblCaloriesPerServing"
        Me.lblCaloriesPerServing.Size = New System.Drawing.Size(175, 22)
        Me.lblCaloriesPerServing.TabIndex = 4
        Me.lblCaloriesPerServing.Text = "Calories Per Serving"
        '
        'lblGramsOfFat
        '
        Me.lblGramsOfFat.AutoSize = True
        Me.lblGramsOfFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGramsOfFat.Location = New System.Drawing.Point(263, 177)
        Me.lblGramsOfFat.Name = "lblGramsOfFat"
        Me.lblGramsOfFat.Size = New System.Drawing.Size(213, 22)
        Me.lblGramsOfFat.TabIndex = 5
        Me.lblGramsOfFat.Text = "Grams of Fat Per Serving"
        '
        'lblNameOfFood
        '
        Me.lblNameOfFood.AutoSize = True
        Me.lblNameOfFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfFood.Location = New System.Drawing.Point(263, 58)
        Me.lblNameOfFood.Name = "lblNameOfFood"
        Me.lblNameOfFood.Size = New System.Drawing.Size(123, 22)
        Me.lblNameOfFood.TabIndex = 6
        Me.lblNameOfFood.Text = "Name of Food"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(267, 355)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(323, 83)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Calculate % of Calories From Fat"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmNutrition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblNameOfFood)
        Me.Controls.Add(Me.lblGramsOfFat)
        Me.Controls.Add(Me.lblCaloriesPerServing)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.txtGramsOfFat)
        Me.Controls.Add(Me.txtCaloriesPerServing)
        Me.Controls.Add(Me.txtNameOfFood)
        Me.Name = "frmNutrition"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNameOfFood As TextBox
    Friend WithEvents txtCaloriesPerServing As TextBox
    Friend WithEvents txtGramsOfFat As TextBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents lblCaloriesPerServing As Label
    Friend WithEvents lblGramsOfFat As Label
    Friend WithEvents lblNameOfFood As Label
    Friend WithEvents btnDisplay As Button
End Class
