Public Class frmRentalCost
    Private Sub btnDisplayRates_Click(sender As Object, e As EventArgs) Handles btnDisplayRates.Click

        ' The rates displayed in the Rental Rates list box when the button Is selected '

        lstRentalRates.Items.Add("Price of Equipment" & vbTab & vbTab & "Half Day" & vbTab & "Full day")
        lstRentalRates.Items.Add("")
        lstRentalRates.Items.Add("1. Rug Cleaner" & vbTab & vbTab & "€16.00" & vbTab & "€24.00")
        lstRentalRates.Items.Add("2. Lawn Mower" & vbTab & vbTab & "€12.00" & vbTab & "€18.00")
        lstRentalRates.Items.Add("3. Paint Sprayer" & vbTab & vbTab & "€20.00" & vbTab & "€30.00")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDisplayBill.Click

        ' Clears Items in the list box '

        lstDisplayBill.Items.Clear()

        ' Declares that If the text in txtItem.Text = 1, 2 or 3 and the text in txtDuration.text = H or F  to proceed with the function '

        If (txtItem.Text = "1" Or txtItem.Text = "2" Or txtItem.Text = "3") And (txtDuration.Text.ToUpper() = "H" Or txtDuration.Text.ToUpper() = "F") Then
            Const deposit = 30
            Dim Item, Duration As String
            Dim ItemsCost As Double

            Item = txtItem.Text
            Duration = txtDuration.Text.ToUpper()

            ' Declares that if the text entered in txtItems.Text matches either 1, 2 or 3, then the variable ItemCost will be calculated accordingly "

            Select Case Item
                Case "1"
                    Item = "Rug Cleaner"
                    ItemsCost = 16
                Case "2"
                    Item = "Lawn Mower"
                    ItemsCost = "12"
                Case "3"
                    ItemsCost = "20"
            End Select

            ' Determines if the text in txtDuration.Text matches 'F' e.g Full Day the following code will execute and determine the price "

            If Duration = "F" Then
                ItemsCost = ItemsCost + (ItemsCost * 0.5)
                Duration = "Full Day"

            Else

                ' If the above criteria isnt met, then the variable 'Duration' will equal 'Half Day' " 

                Duration = "Half Day"

            End If

            lstDisplayBill.Items.Add("Reciept for your equipment rental")
            lstDisplayBill.Items.Add("")
            lstDisplayBill.Items.Add(Item & ": " & ItemsCost.ToString("C2") & " " & Duration)
            lstDisplayBill.Items.Add("Deposit: " & deposit.ToString("C2"))
            lstDisplayBill.Items.Add("")
            lstDisplayBill.Items.Add("Total: " & (ItemsCost + deposit).ToString("C2"))

            ' Declares that if the above criteria isnt met, a messagebox will appear with the following instruction "

        Else

            MessageBox.Show("Please enter the correct input", "Invalid Input", MessageBoxButtons.OK)

        End If

    End Sub
End Class
