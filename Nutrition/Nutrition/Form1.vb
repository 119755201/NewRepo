Public Class frmNutrition

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Const FatCaloriesPerGram = 9

        Dim food As String = txtNameOfFood.Text
        Dim AHAapproved As String
        Dim caloriesPerServing, gramsOfFatPerServing, totalCaloriesFromFat As Integer
        Dim percentCaloriesFromFat As Double

        If food <> "" And Integer.TryParse(txtCaloriesPerServing.Text, caloriesPerServing) And Integer.TryParse(txtGramsOfFat.Text, gramsOfFatPerServing) Then

            totalCaloriesFromFat = gramsOfFatPerServing * FatCaloriesPerGram
            percentCaloriesFromFat = totalCaloriesFromFat / caloriesPerServing

            If percentCaloriesFromFat < 0.3 Then

                AHAapproved = "AHA Approved"

            Else

                AHAapproved = "Not AHA Approved"

            End If

            txtDisplay.Text = food & " contains " & FormatPercent(percentCaloriesFromFat, 2) & " calories from fat " & vbNewLine & "It is " & AHAapproved & "."

        Else

            MessageBox.Show("Please enter valid input", "Input Invalid")

        End If

    End Sub
End Class
