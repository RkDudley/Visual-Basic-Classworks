
' Name:             Barclay Candies
' Purpose           Display the totaldue and list of prices the user have purchased
' Programmer        Rattikarn Dudley

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate the prices of candies purchased by users

        Const strPROMPT As String =
            "Enter candy prices. " &
            "Click cancle or leave blank to end."
        Const strTITLE As String = " Candy Prices"
        Const dblSALESTAX As Double = 0.05 'add sales taxes 5%
        Dim strPrices As String
        Dim dblPrices As Double
        Dim blnNumeric As Boolean
        Dim intCount As Integer 'counter
        Dim dblTotal As Double   'accumulator
        Dim dblTax As Double
        Dim dblTotalDue As Double

        'clear lstList and lblTotal
        lstPrices.Items.Clear()
        lblMsg.Text = String.Empty

        ' get first amount
        strPrices = InputBox(strPROMPT, strTITLE, "0")

        'repeat as long as the user enter an amount
        Do While strPrices <> String.Empty
            blnNumeric = Double.TryParse(strPrices, dblPrices)
            If blnNumeric Then
                'display the amount in the list box
                lstPrices.Items.Add(dblPrices.ToString("c2"))

                'update teh counter and accumulator
                intCount += 1
                dblTotal += dblPrices

            Else
                MessageBox.Show("Please enter a number.",
                                "Prices",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End If
            strPrices = InputBox(strPROMPT, strTITLE, "0")
                Loop

        'verify that the counter greater than 0
        If intCount > 0 Then
            'calculate sale tax
            dblTax = dblTotal * dblSALESTAX
            'totaldue
            dblTotalDue = dblTotal + dblTax
            lblMsg.Text = dblTotalDue.ToString("c2")
        Else
            lblMsg.Text = "N/A"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
