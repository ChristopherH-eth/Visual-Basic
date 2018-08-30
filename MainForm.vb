' Home Utility Program
' Version 1.2

' Christopher Hardy
' January 11th, 2016
' POS/408
' Paul Rodriguez

' Main Form

' This form contains the core functionality of the Home Utility program.  It provides the user with a brief overview of what
' the program does, requires the user to input into various fields and make a selection, and then begins processing.
' While processing, the program does a calculation to determine the appliance run cost for a given day and provides the
' user with output in a MessageBox format.  After each use, the form is reset for continued use, or the user can chooose
' to exit.

' Version 1.1 Updates:
' In version 1.1, the program now allows the user to choose a washer as their appliance.  Once selected, the user is asked
' to enter the number of gallons it uses, as well as the cost per gallon, which is then factored into the total cost to run
' the appliance.  After each appliance is submitted, the program adds it to a list, and it then adds to cost to run each
' appliance to a running total displayeed below the list.

' Version 1.2 Updates:
' In version 1.2, functionality has been added to the program that not only allows the user to clear the list of appliances
' if they wish, but it also provides them with the ability to save the list to a file and load a saved list from said file.
' The code now utilizes structures to better organize appliance data.

Imports System.ComponentModel

Public Class MainForm

    ' Structure for appliances
    Structure ApplianceData
        Dim dblTotal As Double
        Dim dblKWCost As Double
        Dim dblKWPower As Double
        Dim dblGal As Double
        Dim dblCPG As Double
        Dim intHours As Integer
        Dim strAppliance As String
    End Structure

    Dim appliance As ApplianceData

    Public dblAllTotal As Double
    Public blnClose As Boolean

    ' Load handler method
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blnClose = False

        lblKWPower.Text = "How much power (in kilowatts) " & ControlChars.CrLf & "does this appliance need?"
        lblMessage.Text = "Welcome to the Home Utility Program!" & ControlChars.CrLf & ControlChars.CrLf & "This program " &
            "is designed to provide you with an easy way to calculate your daily appliance cost" & ControlChars.CrLf &
            "to run.  Each appliance entered will be added to a list, and the total cost of all running appliances can " &
            ControlChars.CrLf & "be found below it"

        txtAllTotal.Text = "Total appliance cost:  " & dblAllTotal
    End Sub

    ' Method for Submit button selection
    Private Sub btnSubmit_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSubmit.MouseClick

        ' Try block to validate kilowatt hour cost
        Try
            appliance.dblKWCost = Double.Parse(txtCost.Text)

            If ((appliance.dblKWCost < 0) Or (appliance.dblKWCost > 1000)) Then
                Throw New System.Exception
            End If

        Catch
            MessageBox.Show("Input invalid.  Please enter a non-negative number less than 1,000.")
            txtCost.Clear()
            txtCost.Focus()
            Exit Sub
        End Try

        ' Try block to ensure user selected an appliance
        Try
            If rbRefrigerator.Checked = True Then
                appliance.strAppliance = "refrigerator"
            ElseIf rbTV.Checked = True Then
                appliance.strAppliance = "TV"
            ElseIf rbSpaceHeater.Checked = True Then
                appliance.strAppliance = "space heater"
            ElseIf rbFan.Checked = True Then
                appliance.strAppliance = "fan"
            ElseIf rbDryer.Checked = True Then
                appliance.strAppliance = "dryer"
            ElseIf rbOven.Checked = True Then
                appliance.strAppliance = "oven"
            ElseIf rbWasher.Checked = True Then
                appliance.strAppliance = "Laundry Washer"
            Else
                Throw New System.Exception
            End If

        Catch
            MessageBox.Show("Please select an appliance.")
            Exit Sub
        End Try

        ' Try block to validate Laundry Washer cost per gallon variable
        If rbWasher.Checked = True Then
            Try
                appliance.dblCPG = Double.Parse(txtCPG.Text)

                If ((appliance.dblCPG < 0) Or (appliance.dblCPG > 100)) Then
                    Throw New System.Exception
                End If

            Catch ex As Exception
                MessageBox.Show("Input Invalid.  Please enter a non-negative number less than 100.")
                txtCPG.Clear()
                txtCPG.Focus()
                Exit Sub
            End Try
        End If

        ' Try block to validate Laundry Washer gallons used variable
        If rbWasher.Checked = True Then
            Try
                appliance.dblGal = Double.Parse(txtGallons.Text)

                If ((appliance.dblGal < 0) Or (appliance.dblGal > 1000)) Then
                    Throw New System.Exception
                End If

            Catch ex As Exception
                MessageBox.Show("Input Invalid.  Please enter a non-negative number less than 1000.")
                txtGallons.Clear()
                txtGallons.Focus()
            End Try
        End If

        ' Try block to validate appliance power in kilowatts
        Try
            appliance.dblKWPower = Double.Parse(txtPower.Text)

            If ((appliance.dblKWPower < 0) Or (appliance.dblKWPower > 100)) Then
                Throw New System.Exception
            End If

        Catch
            MessageBox.Show("Input invalid.  Please enter a non-negative number less than 100.")
            txtPower.Clear()
            txtPower.Focus()
            Exit Sub
        End Try

        ' Try block to validate number of hours appliance is used
        Try
            appliance.intHours = Integer.Parse(txtHours.Text)

            If ((appliance.intHours < 0) Or (appliance.intHours > 24)) Then
                Throw New System.Exception
            End If

        Catch
            MessageBox.Show("Input invalid.  Please enter a non-negative integer less than 24.")
            txtHours.Clear()
            txtHours.Focus()
            Exit Sub
        End Try

        executeCalculations()
        addAppliances()
        displayTotal()

        IOControls.aryApp(IOControls.intListSize).strAppliance = appliance.strAppliance
        IOControls.aryApp(IOControls.intListSize).intHours = appliance.intHours
        IOControls.aryApp(IOControls.intListSize).dblTotal = appliance.dblTotal
        IOControls.intListSize += 1

        ReDim Preserve IOControls.aryApp(IOControls.intListSize)
    End Sub

    ' Method to display total cost to run a given appliance and reset form for further use
    Private Sub displayTotal()
        MessageBox.Show("Your " & appliance.strAppliance & " will cost approximately $" & Format(appliance.dblTotal,
            "#########0.00") & " to run per day.")
        txtCost.Text = "Kilowatt Hour Cost"
        txtHours.Text = "Hours Used Per Day"
        txtPower.Text = "Kilowatt Usage"
        txtCPG.Text = "Enter Cost Per Gallon"
        txtGallons.Text = "Enter Gallons Per Hour"

        rbDryer.Checked = False
        rbFan.Checked = False
        rbOven.Checked = False
        rbRefrigerator.Checked = False
        rbSpaceHeater.Checked = False
        rbTV.Checked = False
        rbWasher.Checked = False

        txtCost.Focus()
    End Sub

    ' Method to calculate cost of operating a given appliance
    Private Sub executeCalculations()
        If rbWasher.Checked = True Then
            appliance.dblTotal = ((appliance.dblCPG * appliance.dblGal) + (appliance.dblKWCost * appliance.dblKWPower)) *
                appliance.intHours
        Else
            appliance.dblTotal = (appliance.dblKWCost * appliance.dblKWPower) * appliance.intHours
        End If
    End Sub

    ' Method to add appliances to the appliance list
    Private Sub addAppliances()
        lstAppliances.Items.Add("Appliance type:  " & vbTab & vbTab & appliance.strAppliance)
        lstAppliances.Items.Add("Hours used per day:  " & vbTab & appliance.intHours)
        lstAppliances.Items.Add("Cost per day:  " & vbTab & vbTab & "$" & Format(appliance.dblTotal, "#########0.00"))
        lstAppliances.Items.Add("")

        dblAllTotal += appliance.dblTotal
        txtAllTotal.Text = "Total appliance cost:  $" & Format(dblAllTotal, "#########0.00")
    End Sub

    ' Method for Exit button selection
    Private Sub btnExit_MouseClick(sender As Object, e As MouseEventArgs) Handles btnExit.MouseClick
        Me.Close()
    End Sub

    ' Closing handler method
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim frmExit As New ExitForm()

        frmExit.ShowDialog()

        If (Not blnClose) Then
            e.Cancel = True
        End If
    End Sub

    ' CheckedChanged handler method for Laundry Washer radio button
    Private Sub rbWasher_CheckedChanged(sender As Object, e As EventArgs) Handles rbWasher.CheckedChanged
        If txtCPG.Enabled = True Then
            txtCPG.Enabled = False
            txtGallons.Enabled = False
        ElseIf txtCPG.Enabled = False Then
            txtCPG.Enabled = True
            txtGallons.Enabled = True
        End If
    End Sub

    ' Method for Save button selection
    Private Sub btnSave_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSave.MouseClick
        dblAllTotal = 0
        IOControls.saveFile()
    End Sub

    ' Method for Load button selection
    Private Sub btnLoad_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLoad.MouseClick
        dblAllTotal = 0
        IOControls.loadFile()
    End Sub

    ' Method for Clear List button selection
    Private Sub btnClear_MouseClick(sender As Object, e As MouseEventArgs) Handles btnClear.MouseClick
        lstAppliances.Items.Clear()
    End Sub
End Class
