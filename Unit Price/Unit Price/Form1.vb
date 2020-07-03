Public Class frmUnitPrice
    Private Sub btnDetermineUnitPrice_Click(sender As Object, e As EventArgs) Handles btnDetermineUnitPrice.Click

        ' The following are declared as double as they will hold floating numeric values '


        Dim price, pricePerOunce As Double

        ' Variables below will hold floating numbers e.g including decimal places '


        Dim pounds, ounces As Integer

        ' The following objects are converted from String to Double's in order to perform equations '


        price = CDbl(txtPriceOfItem.Text)
        pounds = CDbl(txtPounds.Text)
        ounces = CDbl(txtOunces.Text)

        ' Determines the total number of ounces '

        Dim totalOunces = ounces + (pounds * 16)

        ' Displays the total price per ounce in currency format with 2 decimal places '

        pricePerOunce = price / totalOunces
        txtPricePerOunce.Text = pricePerOunce.ToString("C2")

    End Sub
End Class
