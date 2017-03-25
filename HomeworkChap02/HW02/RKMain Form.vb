'Name:       Planet Project
'Purpose:    Calculate a person weight on the following planets 
'            (Venus, Mars and Jupiter)
'Programmer: Rattikarn Dudley

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate a person weight on the following planets display output number in 2 decimal places
        'Venus
        lblWeightVenus.Text = Format(Val(txtWeightEarth.Text) * 0.91, "fixed")
        'Mars
        lblWeightMars.Text = Format(Val(txtWeightEarth.Text) * 0.38, "fixed")
        'Jupiter
        lblWeightJupiter.Text = Format(Val(txtWeightEarth.Text) * 2.53, "fixed")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen for the next calculation
        txtWeightEarth.Text = String.Empty
        lblWeightVenus.Text = String.Empty
        lblWeightMars.Text = String.Empty
        lblWeightJupiter.Text = String.Empty

        ' send the focus to weight box
        txtWeightEarth.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
