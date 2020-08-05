Public Class frmInsuranceInformation
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblRoofRack_Click(sender As Object, e As EventArgs) Handles lblRoofRack.Click

    End Sub

    Private Sub cbxCollisionDamage_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCollisionDamage.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Displayes the next form, frmConclusion & hides the current form

        frmConclusion.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' Displays the previous form, frmExtras and hides the current form

        frmExtras.Show()
        Me.Hide()

    End Sub
End Class