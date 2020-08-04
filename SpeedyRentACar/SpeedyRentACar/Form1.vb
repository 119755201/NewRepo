Public Class frmRentACar
    Private Sub frmRentACar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        frmCarInformation.Show()
        Me.Hide()

    End Sub
End Class
