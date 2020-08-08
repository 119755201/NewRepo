Public Class frmConclusion
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLeaseInformation.SelectedIndexChanged

        lstLeaseInformation.Items.Add("Total Number of Days" & frmCarInformation.txtTotalDays.Text)
        lstLeaseInformation.Items.Add("Chosen Vehicle" & frmCarInformation.txtCarSelected.Text)
        lstLeaseInformation.Items.Add("Total Cost Excluding VAT: " & frmCarInformation.txtTotalExVAT.Text)

    End Sub
End Class