Public Class frmCarInformation
    Dim carChoice As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Passes the number of days input by the user to the next stage of the form '

        txtTotalDays.Text = frmRentACar.txtDaysRequiredTotal.Text

        ' Ensures that only available cars can be selected ' 

        txtCarSelected.Text = carChoice

        ' Declare variables that will hold information for later use during price calculation '

        Dim TotalDays, TotalWeeks, TotalFortnights As Integer

        ' Creating the following variables as doubles as they will contain pricing data '

        Dim FortnightlyRate, WeeklyRate, DailyRate, TotalFortnightlyPrice, TotalWeeklyPrice, TotalDaysPrice, TotalDailyCharges As Double

        ' Converts the data entered in the text box on 'frmRentACar' to a local variable that is used later for price calculation'

        TotalDays = CInt(frmRentACar.txtDaysRequiredTotal.Text)

        ' Calculates the number of fortnights are in the total duration entered by the end user '

        TotalFortnights = TotalDays / 14

        ' Determines the number of weeks left after all/if any fortnights are found e.g durations such as 1 week or 5 weeks etc ' 

        TotalWeeks = (TotalDays - (TotalFortnights * 14)) / 7

        ' Determines the total number of days to apply the daily charge to once all fortnights/weeks are accounted for if necessary '

        TotalDailyCharges = TotalDays - ((TotalFortnights * 14) + (TotalWeeks * 7))

        FortnightlyRate = 175

        WeeklyRate = 100

        DailyRate = 20


        TotalFortnightlyPrice = TotalFortnights * fortnightlyRate

        TotalWeeklyPrice = TotalWeeks * WeeklyRate

        TotalDaysPrice = TotalDailyCharges * DailyRate

        txtTotalExVAT.Text = TotalFortnightlyPrice + TotalWeeklyPrice + TotalDaysPrice


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCarChoice.SelectedIndexChanged

        ' Declares the variable carChoice is the text entered into the available cars text box '

        carChoice = cbxCarChoice.Text


    End Sub

    Private Sub txtTotalDays_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDays.TextChanged

    End Sub
End Class