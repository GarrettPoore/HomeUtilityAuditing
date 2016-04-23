Imports System.IO 'Needed for StreamWriter

Public Class frmMain

    'Contains information for each appliance
    Structure ApplianceInfo

        Dim Appliance As String 'Appliance name
        Dim PowerRating As Double 'Appliance kilowatt usage
        Dim Hours As Double 'Appliance hours per day
        Dim Cost As Double 'Appliance cost per day

    End Structure

    'Global variables
    Const intMAX_APPLIANCES As Integer = 7 'Number of appliances supported by the program
    Dim Appliance(intMAX_APPLIANCES) As ApplianceInfo 'Array of Appliance Structure that will hold enough appliances for the program
    Dim SelectedAppliance As String = "" 'The currently selected appliance
    Dim KWHTotalCost As Double = 0.0 'Contains the total cost per day of all appliances

    'Load event for the program
    'Opens the configuration file
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'StreamReader object
        Dim config As StreamReader

        'Opens the config.txt file
        config = File.OpenText("config.txt")

        'Read loop
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Reads the appliance
            Appliance(counter).Appliance = config.ReadLine

            'Reads the default power rating for that appliance
            Appliance(counter).PowerRating = CDbl(config.ReadLine)

            'Defaults the remaining structure values to 0
            Appliance(counter).Hours = 0.0
            Appliance(counter).Cost = 0.0

        Next

        'Closes the StreamReader
        config.Close()

    End Sub

    'When the user types in any amount, in any text box, this event triggers
    Private Sub TextboxInputChange(sender As Object, e As EventArgs) Handles txtCostPerKWH.TextChanged, txtPowerRating.TextChanged, txtHoursPerDay.TextChanged, txtWaterUse.TextChanged, txtWaterCost.TextChanged

        'Calls the CalculateKW procedure
        CalculateKW()

    End Sub


    'Triggers when any appliance is selected from the combo list box
    Private Sub cboAppliance_TextChanged(sender As Object, e As EventArgs) Handles cboAppliance.TextChanged

        'Sets the global SelectedAppliance variable
        SelectedAppliance = cboAppliance.SelectedItem

        'Loop to set the power rating textbox to the default power rating
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Finds the correct appliance line in the structure
            If SelectedAppliance = Appliance(counter).Appliance Then

                'Sets the textbox to the default
                txtPowerRating.Text = Appliance(counter).PowerRating.ToString

            End If

        Next

        'Shows the Cloth Washer group box when it is selected, and hides it when it is not selected
        If cboAppliance.Text = "Cloth Washer" Then

            'Show the group box
            grpWasher.Visible = True

        Else

            'Hide the group box
            grpWasher.Visible = False

        End If

        'Calls the CalculateKW procedure
        CalculateKW()

    End Sub

    'Exports the data from the listing area to a text file
    Private Sub btnReportCreation_Click(sender As Object, e As EventArgs) Handles btnReportCreation.Click

        'StreamWriter object
        Dim Report As StreamWriter

        'Intialize Appliance_Report.txt
        Report = File.CreateText("Appliance_Report.txt")

        'Writes the header to the report
        Report.WriteLine(String.Format(" {0, 20} {1, 20} {2, 20}", "Appliance", "Hours Per Day", "Cost Per Day"))

        'Writes a seperater for the header and main information
        Report.WriteLine(String.Format(" {0, 20} {1, 20} {2, 20}", "---------", "-------------", "------------"))

        'Loop to write appliances and information
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Makes sure that each appliance is only written if it has a calculated value
            If Appliance(counter).Cost > 0.0 Then

                'Write the appliance name, hours of use, and cost per day
                Report.WriteLine(String.Format("{0, 20} {1, 20} {2, 20}", Appliance(counter).Appliance, Appliance(counter).Hours, Appliance(counter).Cost.ToString("c")))

            End If

        Next

        'Creates two blank lines between the table and the total
        Report.WriteLine(vbCrLf)

        'Writes the total cost at the end of the report
        Report.WriteLine(String.Format("{0, 60}", "Total Cost: " & KWHTotalCost.ToString("c")))


        'Verification message to the user
        stsLabel.Text = "Appliance_Report.txt Created"

        'Close the report
        Report.Close()

    End Sub

    'Closes the window
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    'Closing event to save the new default power ratings
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Check the Change Defaults check box
        'Only changes the defaults if it is checked
        If chkChangeDefaults.Checked Then

            'StreamWriter object
            Dim config As StreamWriter

            'Initialize the new config file
            config = File.CreateText("config.txt")

            'Write loop
            For counter As Integer = 0 To intMAX_APPLIANCES - 1

                'Write the current appliance name
                config.WriteLine(Appliance(counter).Appliance)

                'Write the new default power rating
                config.WriteLine(Appliance(counter).PowerRating)

            Next

            'Close the config.txt file
            config.Close()

        End If

    End Sub



    'Updates the labels whenever a valid output can be created
    'Only runs after the text boxes have been checked and validated
    Private Sub LabelChange()


        'Determins if an appliance selection has been made
        If SelectedAppliance = "" Then

            'Error message for no appliance being selected
            stsLabel.Text = "Please select an appliance from the list on the left."

        Else

            'Clear any erroneous error messages
            stsLabel.Text = ""

        End If

        'Clears the listing box to prepare for new listings
        lbxListing.Items.Clear()

        'Listing box write loop
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Verifies that the current appliance has a cost value
            If Appliance(counter).Cost > 0.0 Then

                'Writes the new item in the listing box
                lbxListing.Items.Add("The " & Appliance(counter).Appliance & " costs " & Appliance(counter).Cost.ToString("c") & " over the course of one day.")

            End If

        Next


        'Total Cost Calculation
        KWHTotalCost = 0.0 'Reset total cost before recalculation

        'Total cost calculation loop
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Increments the total cost with the cost of each appliance (will be 0 if it has not been calculated)
            KWHTotalCost += Appliance(counter).Cost

        Next

        'Changes the total label
        lblKWHTotal.Text = KWHTotalCost.ToString("c")


        'Resizing for the total label
        Dim FormWidth As Integer = Me.Size.Width 'width of the form
        Dim TotalCostWdith As Integer = lblKWHTotal.Size.Width 'width of the label (after it is updated)
        Dim TotalCostLocationX As Integer 'holds the new X location of the label

        'Creates the needed X variable to center the label in the form
        TotalCostLocationX = (FormWidth - TotalCostWdith) / 2

        'Sets the new X location for the total label
        lblKWHTotal.Location = New Point(TotalCostLocationX, lblKWHTotal.Location.Y)


    End Sub

    'Validates data entries and calculates the usage amount for the selected appliance
    'Run when any change has been made by the user
    Private Sub CalculateKW()

        'Working variables
        Dim KWHCost As Double 'Cost per killowatt hour
        Dim Hours As Double 'Length of time in hours that the appliance is run per day
        Dim PowerRating As Double 'Usage per hour of the selected appliance
        Dim ApplianceCost As Double 'Cost of the selected appliance

        Dim WasherGallons As Double 'Total number of gallons used by the washer per hour
        Dim WasherGallonsCost As Double 'Cost of water per gallon
        Dim WaterTotalCost As Double = 0.0 'Total cost of the water usage

        Dim InvalidFlag As Integer = 0 '0 means no error, 1 is too large, -1 is too small



        'Checks that a number amount is in each textbox
        Try
            'Attempts to obtain the cost per killowatt hour
            'Validates that a double was entered
            KWHCost = CDbl(txtCostPerKWH.Text)

            'Validates the amount
            'Sets the flag and ends the current Try (and activates it's Catch) if the amount is incorrect
            'The flag will show the Catch if the amount is too large or too small            
            If KWHCost > 200.0 Then 'Cost per Killowatt hour should not be more than $200.00

                InvalidFlag = 1 'Too large flag
                Throw New System.Exception("")

            ElseIf KWHCost <= 0 Then

                InvalidFlag = -1 'Too small flag
                Throw New System.Exception("")

            Else

                InvalidFlag = 0 'Reset flag

            End If

            Try
                'Attempts to obtain the amount of killowatts used by the appliance
                'Validates that a double was entered
                PowerRating = CDbl(txtPowerRating.Text)

                'Validates the amount
                'Sets the flag and ends the current Try (and activates it's Catch) if the amount is incorrect
                'The flag will show the Catch if the amount is too large or too small   
                If PowerRating > 500.0 Then

                    InvalidFlag = 1 'Too large flag
                    Throw New System.Exception("")

                ElseIf PowerRating <= 0 Then

                    InvalidFlag = -1 'Too small flag
                    Throw New System.Exception("")

                Else

                    InvalidFlag = 0 'Reset flag

                End If

                Try
                    'Attempts to obtain the length of time the appliance is run per day
                    'Validates that a double was entered
                    Hours = CDbl(txtHoursPerDay.Text)

                    'Validates the amount
                    'Sets the flag and ends the current Try (and activates it's Catch) if the amount is incorrect
                    'The flag will show the Catch if the amount is too large or too small   
                    If Hours > 24.0 Then

                        InvalidFlag = 1 'Too large flag
                        Throw New System.Exception("")

                    ElseIf Hours <= 0 Then

                        InvalidFlag = -1 'Too small flag
                        Throw New System.Exception("")

                    Else

                        InvalidFlag = 0 'Reset flag

                    End If

                    'Checks if the Cloth Washer is selected
                    If SelectedAppliance = "Cloth Washer" Then

                        Try
                            'Attempts to obtain the number of gallons used per hour
                            'Validates that a double was entered
                            WasherGallons = CDbl(txtWaterUse.Text)

                            'Validates the amount
                            'Sets the flag and ends the current Try (and activates it's Catch) if the amount is incorrect
                            'The flag will show the Catch if the amount is too large or too small  
                            If WasherGallons > 50.0 Then 'Total gallons per hour should not be more than 50

                                InvalidFlag = 1 'Too large flag
                                Throw New System.Exception("")

                            ElseIf WasherGallons <= 0 Then

                                InvalidFlag = -1 'Too small flag
                                Throw New System.Exception("")

                            Else

                                InvalidFlag = 0 'Reset flag

                            End If

                            Try
                                'Attempts to obtain the cost per gallon
                                'Validates that a double was entered
                                WasherGallonsCost = CDbl(txtWaterCost.Text)

                                'Validates the amount
                                'Sets the flag and ends the current Try (and activates it's Catch) if the amount is incorrect
                                'The flag will show the Catch if the amount is too large or too small  
                                If WasherGallonsCost > 200.0 Then 'Total cost per gallon should not be more than $200.00

                                    InvalidFlag = 1 'Too large flag
                                    Throw New System.Exception("")

                                ElseIf WasherGallonsCost <= 0 Then

                                    InvalidFlag = -1 'Too small flag
                                    Throw New System.Exception("")

                                Else

                                    InvalidFlag = 0 'Reset flag

                                End If


                                'Calculates the total cost of water
                                WaterTotalCost = WasherGallons * Hours * WasherGallonsCost

                                'Calculates the total cost for the selected appliance
                                ApplianceCost = (PowerRating * Hours * KWHCost) + WaterTotalCost

                                'Sends the needed values to update the Appliance structure
                                UpdateApplianceValues(Hours, ApplianceCost, PowerRating)

                                'Calls the LabelChange procedure
                                LabelChange()

                            Catch ex As Exception

                                'Washer error
                                'Errors for an incorrect cost per gallon of water
                                'Checks the flag
                                If InvalidFlag = 0 Then 'Invalid data type

                                    stsLabel.Text = "Please enter a valid cost per gallon of the Cloth Washer."

                                ElseIf InvalidFlag = 1 Then 'Amount too large

                                    stsLabel.Text = "Please enter no more than $200.00 for the cost per gallon."

                                ElseIf InvalidFlag = -1 Then 'Amount too small

                                    stsLabel.Text = "Please enter an amount for the cost per gallon more than 0."

                                End If

                            End Try

                        Catch ex As Exception

                            'Washer error
                            'Errors for an incorrect gallons used per hour
                            'Checks the flag
                            If InvalidFlag = 0 Then 'Invalid data type

                                stsLabel.Text = "Please enter a amount of gallons used per hour for the Cloth Washer."

                            ElseIf InvalidFlag = 1 Then 'Amount too large

                                stsLabel.Text = "Please enter no more than 50 gallons per hour."

                            ElseIf InvalidFlag = -1 Then 'Amount too small

                                stsLabel.Text = "Please enter an amount for the gallons used per hour more than 0."

                            End If

                        End Try

                    Else
                        'Non-cloth washer appliance

                        'Calculates the total cost for the selected appliance
                        ApplianceCost = PowerRating * Hours * KWHCost

                        'Sends the needed values to update the Appliance structure
                        UpdateApplianceValues(Hours, ApplianceCost, PowerRating)

                        'Calls the LabelChange procedure
                        LabelChange()

                    End If

                Catch ex As Exception

                    'Errors for an incorrect length of time that the appliance is run per day
                    'Checks the flag
                    If InvalidFlag = 0 Then 'Invalid data type

                        stsLabel.Text = "Please enter a valid number of hours that the selected appliance uses per day."

                    ElseIf InvalidFlag = 1 Then 'Amount too large

                        stsLabel.Text = "Please enter no more than 24 hours."

                    ElseIf InvalidFlag = -1 Then 'Amount too small

                        stsLabel.Text = "Please enter an amount of hours more than 0."

                    End If

                End Try

            Catch ex As Exception

                'Error for an incorrect amount of kilowatts used by the appliance
                'Checks the flag
                If InvalidFlag = 0 Then 'Invalid data type

                    stsLabel.Text = "Please enter a valid amount of Kilowatts needed for the selected appliance."

                ElseIf InvalidFlag = 1 Then 'Amount too large

                    stsLabel.Text = "Please enter no more than 500 kilowatts needed."

                ElseIf InvalidFlag = -1 Then 'Amount too small

                    stsLabel.Text = "Please enter an amount for the kilowatts needed more than 0."

                End If

            End Try

        Catch ex As Exception

            'Error for an incorrect cost per killowatt-hour
            'Checks the flag
            If InvalidFlag = 0 Then 'Invalid data type

                stsLabel.Text = "Please enter a valid dollar amount for cost per Kilowatt-hour."

            ElseIf InvalidFlag = 1 Then 'Amount too large

                stsLabel.Text = "Please enter no more than $200.00 cost per Kilowatt-hour."

            ElseIf InvalidFlag = -1 Then 'Amount too small

                stsLabel.Text = "Please enter an amount for the cost per Kilowatt-hour more than 0."

            End If

        End Try

    End Sub

    'Updates the current appliances information in the Appliance structure
    Private Sub UpdateApplianceValues(Hours As Double, Cost As Double, PowerRating As Double)

        'Update loop
        For counter As Integer = 0 To intMAX_APPLIANCES - 1

            'Find the current appliance
            If SelectedAppliance = Appliance(counter).Appliance Then

                'Update values
                With Appliance(counter)
                    .Cost = Cost 'Update the cost of the appliance
                    .Hours = Hours 'Update the hours of use of the appliance
                    .PowerRating = PowerRating 'Update the amount of power used by the appliance
                End With

            End If

        Next

    End Sub

End Class