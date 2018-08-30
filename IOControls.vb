' Home Utility Program
' Version 1.2

' Christopher Hardy
' January 11th, 2016
' POS/408
' Paul Rodriguez

' IO Controls

' This form is used solely to execute the saving and loading of files

Imports System.IO

Public Class IOControls

    Public intListSize As Integer = 0
    Public intPreviousValue As Integer = 0
    Public aryApp(intListSize) As MainForm.ApplianceData

    Private Sub IOControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Method to save appliances to a file
    Public Sub saveFile()
        Dim applianceFile As StreamWriter

        Try
            My.Computer.FileSystem.DeleteFile("appliancelist.txt")
        Catch
        End Try

        applianceFile = File.CreateText("appliancelist.txt")

        For intCount = 0 To intListSize
            applianceFile.WriteLine(aryApp(intCount).strAppliance)
            applianceFile.WriteLine(aryApp(intCount).intHours)
            applianceFile.WriteLine(aryApp(intCount).dblTotal)
        Next

        MainForm.lstAppliances.Items.Clear()
        MainForm.txtAllTotal.Clear()
        intPreviousValue = intListSize

        ReDim aryApp(intListSize)

        applianceFile.Close()
    End Sub

    ' Method to read appliances from a file
    Public Sub loadFile()
        If File.Exists("appliancelist.txt") Then

            Dim applianceFile As StreamReader
            Dim intCount As Integer = 0
            ReDim aryApp(intPreviousValue)

            MainForm.lstAppliances.Items.Clear()

            applianceFile = File.OpenText("appliancelist.txt")

            Do Until applianceFile.EndOfStream
                aryApp(intCount).strAppliance = applianceFile.ReadLine()
                aryApp(intCount).intHours = applianceFile.ReadLine()
                aryApp(intCount).dblTotal = applianceFile.ReadLine()

                If Not aryApp(intCount).intHours = 0 Then
                    MainForm.lstAppliances.Items.Add("Appliance type:  " & vbTab & vbTab & aryApp(intCount).strAppliance)
                    MainForm.lstAppliances.Items.Add("Hours used per day:  " & vbTab & aryApp(intCount).intHours)
                    MainForm.lstAppliances.Items.Add("Cost per day:  " & vbTab & vbTab & "$" & Format(aryApp(intCount).dblTotal,
                        "#########0.00"))
                    MainForm.lstAppliances.Items.Add("")

                    MainForm.dblAllTotal += aryApp(intCount).dblTotal
                End If

                intCount += 1
            Loop

            MainForm.txtAllTotal.Text = "Total appliance cost:  $" & Format(MainForm.dblAllTotal, "#########0.00")

            intCount = 0
            applianceFile.Close()
        Else
            MessageBox.Show("The file does not exist.")
        End If
    End Sub
End Class