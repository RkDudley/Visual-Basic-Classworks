'Name               Rent-A-Van project
'Purpose            Calculate the total cost of renting a van
'Programmer         Rattikarn Dudley   03/04/2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const decCHARGE_PER_MILE As Decimal = 0.69D
        Const decBASE_FEE As Decimal = 19.95D

        'calculate the total miles and total rental cost
        Dim decMilesBegin As Decimal
        Dim decMilesEnd As Decimal
        Dim decTotalMiles As Decimal
        Dim decTotalCost As Decimal

        ' calculate  the total miles 
        Decimal.TryParse(txtMilesBegin.Text, decMilesBegin)
        Decimal.TryParse(txtMilesEnd.Text, decMilesEnd)
        decTotalMiles = decMilesEnd - decMilesBegin

        ' calculate the total cost
        decTotalCost = (decTotalMiles * decCHARGE_PER_MILE) + decBASE_FEE

        ' display the total amount 
        lblBaseCharges.Text = decBASE_FEE.ToString("c2")
        lblChargeFee.Text = decCHARGE_PER_MILE.ToString("c2")
        lblMilesDriven.Text = decTotalMiles.ToString("n2")
        lblTotal.Text = decTotalCost.ToString("c2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare a screen for the next round

        txtMilesBegin.Text = String.Empty
        txtMilesEnd.Text = String.Empty
        txtName.Text = String.Empty
        lblBaseCharges.Text = String.Empty
        lblMilesDriven.Text = String.Empty
        lblTotal.Text = String.Empty
        lblChargeFee.Text = String.Empty

        ' send a focus to txtname 
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sale reciept

        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        PrtScn.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True
    End Sub
End Class
