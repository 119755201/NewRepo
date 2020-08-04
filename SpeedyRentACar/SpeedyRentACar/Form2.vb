Public Class frmCarInformation
    Dim carChoice As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Passes the number of days input by the user to the next stage of the form '

        txtTotalDays.Text = frmRentACar.txtDaysRequiredTotal.Text

        ' Ensures that only available cars can be selected ' 

        txtCarSelected.Text = carChoice

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCarChoice.SelectedIndexChanged

        ' Declares the variable carChoice is the text entered into the available cars text box '

        carChoice = cbxCarChoice.Text


    End Sub
End Class