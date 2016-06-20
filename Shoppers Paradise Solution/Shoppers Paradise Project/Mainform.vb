'Roshan Koirala
'Dr. Smith
'CSCI 2000
'Sept 29, 2013

'Purpose of the program- This is an application that displays the number of reward points a customer earns each month.
'Discription of the program- The reward points are based on the customer's membership type and total montly purchase amout.

Option Explicit On
Option Strict On
Option Infer Off

Public Class Mainform

    Private Sub Exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbutton.Click
        Me.Close() ' code for exit button
    End Sub

    Private Sub Calculaterewardpointbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculaterewardpointbutton.Click
        Dim tmp As Double ' Declaration Statement
        Dim rp As Double ' Declaration Statement
        Double.TryParse(Totalmonthlypurchasetextbox.Text, tmp)
        If Basicradiobutton.Checked Then
            'Use of Nested Selection Structure
            If tmp > 0 AndAlso tmp < 75 Then
                rp = 5 * tmp / 100
            ElseIf tmp >= 75 AndAlso tmp < 150 Then
                rp = 7.5 * tmp / 100
            ElseIf tmp >= 150 Then
                rp = 10 * tmp / 100
            End If
        ElseIf Standardradiobutton.Checked Then
            If tmp > 0 AndAlso tmp < 150 Then
                rp = 6 * tmp / 100
            ElseIf tmp >= 150 Then
                rp = 13 * tmp / 100
            End If
        ElseIf Premiumradiobutton.Checked Then
            If tmp > 0 AndAlso tmp < 200 Then
                rp = 7 * tmp / 100
            ElseIf tmp >= 200 Then
                rp = 15 * tmp / 100
            End If
        End If
        Displaylabel.Text = rp.ToString("n0") ' To Display the result in Displaylabel
    End Sub
End Class
