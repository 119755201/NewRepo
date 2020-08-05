Public Class frmExtras

    Private Sub gbxOptionalExtras_Enter(sender As Object, e As EventArgs) Handles gbxOptionalExtras.Enter



    End Sub

    Private Sub frmExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        frmInsuranceInformation.Show()
        Me.Hide()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmCarInformation.Show()
        Me.Hide()

    End Sub
End Class