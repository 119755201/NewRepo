Public Class frmRentACar
    Private Sub frmRentACar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' Shows the next form when the 'Next' button is selected and hides the current form from view '

        frmCarInformation.Show()
        Me.Hide()

    End Sub

    Private Sub gbxCustomerInformation_Enter(sender As Object, e As EventArgs) Handles gbxCustomerInformation.Enter

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the program ' 

        Me.Close()

    End Sub
End Class
