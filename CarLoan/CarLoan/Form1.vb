Public Class frmCarLoan
    Private Sub btnCalculatePayments_Click(sender As Object, e As EventArgs) Handles btnCalculatePayments.Click


        ' Declare the following as variables as they will hold information entered by the end user '

        Dim monthlyPayment, interestRate, loanAmount As Double

        ' Declare the following variable as an Integer as the number of years will be provided as a whole number '

        Dim numberOfYears As Integer

        ' The variables 'loanAmount' & 'interestRate' are converted to a double as they can be floating numbers '

        loanAmount = CDbl(txtAmount.Text)
        interestRate = CDbl(txtinterest.Text)

        ' The variable 'numberOfYears' is converted to an Integer as it will be a whole number '

        numberOfYears = CInt(txtYears.Text)

        ' i is declared as a double integer and is set to be equal to interestRate * 1200 '

        Dim i As Double = interestRate / 1200

        ' The part of the equation '(1 - Math.Pow((1 + i), -12 * numberOfYears)' = 1 - (1 + i) - 12 to the power of numberOfYears' '

        monthlyPayment = (i / (1 - Math.Pow((1 + i), -12 * numberOfYears))) * loanAmount

        ' The information provided in the equation can then be presented to the end user '

        txtPayments.Text = monthlyPayment.ToString("C2")

        ' The function 'monthlyPayment.ToString("C2")' declares that the data is currency and to dislay only 2 decimal places "

    End Sub
End Class
