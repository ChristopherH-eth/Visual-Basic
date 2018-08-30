' Home Utility Program
' Version 1.2

' Christopher Hardy
' January 11th, 2016
' POS/408
' Paul Rodriguez

' Exit Form

' This form is used to prompt the user when they choose an exit option to ensure choice accuracy

Public Class ExitForm

    ' Method for No button selection
    Private Sub btnNo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNo.MouseClick
        MainForm.blnClose = False
        Me.Close()
    End Sub

    ' Method for Yes button selection
    Private Sub btnYes_MouseClick(sender As Object, e As MouseEventArgs) Handles btnYes.MouseClick
        MainForm.blnClose = True
        Me.Close()
    End Sub

    Private Sub ExitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class