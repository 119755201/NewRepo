Public Class frmCarInformation
    Dim carChoice As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click



        ' Declaring the following as variables as they will hold pricing information '

        Dim ChildSeat, SkiEquipment, RoofRack, SatNav As Double

        ' Pricing associated with each variable 

        ChildSeat = 22
        SkiEquipment = 78
        RoofRack = 45

        ' Sat-Nav's are charged at €5 per day '

        SatNav = CDbl(txtTotalDays.Text) * 5

        ' The prices associated with the extras on the next form '

        frmExtras.txtChildSeat.Text = ChildSeat

        frmExtras.txtSkiEquipment.Text = SkiEquipment

        frmExtras.txtRoofRack.Text = RoofRack

        frmExtras.txtSatNav.Text = SatNav

        frmExtras.Show()
        Me.Hide()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        txtTotalIncVAT.Text = ""
        txtTotalExVAT.Text = ""
        txtTotalVAT.Text = ""


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



        ' If the user selects a duration longer than 14 days, the below rate will be applied for every 14 day period incurred '

        FortnightlyRate = 175

        ' If the user selects a duration longer than 7 days, the below rate will be applied for every 7 day period that's incurred '

        WeeklyRate = 100

        ' If the user selects a duration of between 1 - 6 days then the following rate will be applied for each day incurred '

        DailyRate = 20

        ' The formulas below are used to calculate the correct cost total based on the duration selected by the end user '

        TotalFortnightlyPrice = TotalFortnights * fortnightlyRate

        TotalWeeklyPrice = TotalWeeks * WeeklyRate

        TotalDaysPrice = TotalDailyCharges * DailyRate

        ' Declaring variables that will be used to apply tax and other payment information '

        Dim TaxRate, TotalVAT, TotalExVAT, TotalIncVAT As Double

        ' Declares the tax rate to be the equivalent of 20% '

        TaxRate = 0.2

        ' Adds the total costs gathered from the number of different prices applied e.g Number of Days + Number of Weeks + Number of Fortnights '

        TotalExVAT = TotalFortnightlyPrice + TotalWeeklyPrice + TotalDaysPrice

        ' Determines the Total VAT to apply to charge based on the level of cost ' 

        TotalVAT = TotalExVAT * TaxRate

        ' Calculates the end Total by adding the VAT to the ex VAT cost. '

        TotalIncVAT = TotalExVAT + TotalVAT

        ' Displays the relevant information to the end user '

        txtTotalExVAT.Text = TotalExVAT

        txtTotalVAT.Text = TotalVAT

        txtTotalIncVAT.Text = TotalIncVAT

        ' The following are string variables which are going to contain the different models of cars available '

        Dim VW, MiniHatchback, AudiA1, AFG, Subaru As String

        ' The following is the naming and pricing information for the model "VW Up 1.0 Litre (Or equivalent)" ,

        Dim VWDayRate, VWWeeklyRate, VWFortnightlyRate As Double

        VW = "VW Up 1.0 Litre (Or equivalent)"

        VWDayRate = 37.5
        VWWeeklyRate = 236.25
        VWFortnightlyRate = 448.9

        If cbxCarChoice.Text = VW Then

            VWDayRate = DailyRate
            VWWeeklyRate = WeeklyRate
            VWFortnightlyRate = FortnightlyRate

        End If


        ' The following is the naming and pricing information for the model Mini hatchback 1.2 Litre (or equivalent)" ' 

        Dim MHDayRate, MHWeeklyRate, MHFortnightlyRate As Double

        MiniHatchback = "Mini hatchback 1.2 Litre (or equivalent)"

        MHDayRate = 43.25
        MHWeeklyRate = 272.48
        MHFortnightlyRate = 517.7

        If cbxCarChoice.Text = MiniHatchback Then

            MHDayRate = DailyRate
            MHWeeklyRate = WeeklyRate
            MHFortnightlyRate = FortnightlyRate

        End If

        ' The following is the naming and pricing information for the model "Audi A1 1.4 Litre or Equivalen" ' 

        Dim AudiDayRate, AudiWeeklyRate, AudiFortnightlyRate As Double

        AudiA1 = "Audi A1 1.4 Litre (or equivalent)"

        AudiDayRate = 49.7
        AudiWeeklyRate = 313.11
        AudiFortnightlyRate = 594.91

        If cbxCarChoice.Text = AudiA1 Then

            AudiDayRate = DailyRate
            AudiWeeklyRate = WeeklyRate
            AudiFortnightlyRate = FortnightlyRate

        End If

        ' The following is the naming and pricing information for the model "Alfa Romeo Giulietta 1.6 Litre or Equivalent "  ' 

        Dim AFGDayRate, AFGWeeklyRate, AFGFortnightlyRate As Double

        AFG = "Alfa Romeo Giulietta 1.6 Litre (or equivalent)"

        AFGDayRate = 55.3
        AFGWeeklyRate = 348.39
        AFGFortnightlyRate = 661.95

        If cbxCarChoice.Text = AFG Then

            AFGDayRate = DailyRate
            AFGWeeklyRate = WeeklyRate
            AFGFortnightlyRate = FortnightlyRate

        End If

        ' The following is the naming and pricing information for the model "Subaru Outback 2.0 Litre or Equivalent "  ' 


        Dim SubDayRate, SubWeeklyRate, SubFortnightlyRate As Double

        Subaru = "Subaru Outback 2.0 Litre (Or equivalent)"

        SubDayRate = 37.5
        SubWeeklyRate = 236.25
        SubFortnightlyRate = 448.9

        If cbxCarChoice.Text = Subaru Then

            AFGDayRate = DailyRate
            AFGWeeklyRate = WeeklyRate
            AFGFortnightlyRate = FortnightlyRate

        End If



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCarChoice.SelectedIndexChanged

        ' Declares the variable carChoice is the text entered into the available cars text box '

        carChoice = cbxCarChoice.Text


    End Sub

    Private Sub txtTotalDays_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDays.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmRentACar.Show()
        Me.Hide()

    End Sub

    Private Sub frmCarInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class