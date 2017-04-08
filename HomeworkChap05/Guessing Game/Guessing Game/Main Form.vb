' Name:             Guessing Game Project lesson c exercise 5
' Purpose           Display the matching number and how many guesses user have tried
' Programmer        Rattikarn Dudley

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    'class scope variables to be able to access in different procedures
    Private intCount As Integer
    Private intNum As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'generate number 
        Dim randGen As New Random
        intNum = randGen.Next(1, 30)
        'hide the correct random number
        lblGen.Text = intNum.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'reset random number
        Dim randGen As New Random
        intNum = randGen.Next(1, 30)
        lblGen.Text = intNum.ToString

        'clear the genereate and the output messege
        lblMsg.Text = String.Empty
        txtGuess.Text = String.Empty

        'reset guesses times to 0 
        intCount = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application 
        Me.Close()
    End Sub

    Private Sub BtnGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        'determine if the user guess match with the generate number
        Dim intGuess As Integer
        Dim intGen As Integer

        'convert lblGen to integer
        Integer.TryParse(lblGen.Text, intGen)
        Integer.TryParse(txtGuess.Text, intGuess)

        'store how many time user have been guess
        intCount += 1

        'determine if the number too high, too low or correct
        If intGuess = intGen Then
            lblMsg.Text = "Correct !" & ControlChars.NewLine _
                & "The correct number is " & intGen.ToString & ControlChars.NewLine _
                & "Total guesses = " & intCount.ToString
        ElseIf intGuess > intGen Then
            lblMsg.Text = " Guess Lower! "
        ElseIf intGuess < intGen Then
            lblMsg.Text = "Guess Higher!"
        Else
            lblMsg.Text = "invalid input!"
        End If

    End Sub

    Private Sub cancleKey(sender As Object, e As KeyPressEventArgs) Handles txtGuess.KeyPress
        'allow the text box to accept only number and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancle the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub txtGuess_Enter(sender As Object, e As EventArgs) Handles txtGuess.Enter
        txtGuess.SelectAll()
    End Sub

End Class

