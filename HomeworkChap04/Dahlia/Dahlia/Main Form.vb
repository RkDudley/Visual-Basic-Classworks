
' Name:             Dahlia's project
' Purpose           Display the total dvds, blu-rays and total due
' Programmer        Rattikarn Dudley

Public Class frmDahlia

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'calculate and display total dvds, sales tax and total due

        Const dblDVDS_RATE As Double = 9.99
        Const dblBLURAYS_RATE As Double = 11.99
        Const dblSALES_TAX As Double = 0.065
        Dim intDvds As Integer
        Dim intBlurays As Integer
        Dim dblDvdsTotal As Double
        Dim dblBluraysTotal As Double
        Dim dblSubtotal As Double
        Dim dblTotalDue As Double
        Dim dblTotalTax As Double
        Dim intCount As Integer
        Dim dblPromotion As Double
        Dim strPromotion As String = "Earn $10 in Dahlia Cash for every $50 spend" & ControlChars.NewLine _
                           & "You earn "

        ' store input variable 
        Integer.TryParse(txtDvds.Text, intDvds)
        Integer.TryParse(txtBlurays.Text, intBlurays)

        'calculate the total of dvds
        dblDvdsTotal = intDvds * dblDVDS_RATE

        'calculate the total of blu-rays
        dblBluraysTotal = intBlurays * dblBLURAYS_RATE

        'calculate total before tax
        dblSubtotal = dblDvdsTotal + dblBluraysTotal

        'calculate total tax
        dblTotalTax = dblSubtotal * dblSALES_TAX

        'calculate total due
        dblTotalDue = dblSubtotal + dblTotalTax

        'determine a promotion
        If dblSubtotal >= 50 Then
            dblPromotion = dblSubtotal \ 50
            intCount = Convert.ToInt32(dblPromotion) * 10
            lblText.Text = strPromotion & intCount.ToString("c2")
        Else
            lblText.Text = String.Empty
        End If

        'Display charges
        lblSub.Text = dblSubtotal.ToString("c2")
        lblSale.Text = dblTotalTax.ToString("c2")
        lblTotal.Text = dblTotalDue.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub CancleKeys(sender As Object, e As KeyPressEventArgs) Handles txtDvds.KeyPress, txtBlurays.KeyPress

        'allow the text box to accept only number and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancle the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtBlurays_Enter(sender As Object, e As EventArgs) Handles txtBlurays.Enter
        ' select content when tex box recieve focus
        txtBlurays.SelectAll()
    End Sub

    Private Sub txtBlurays_TextChanged(sender As Object, e As EventArgs) _
        Handles txtBlurays.TextChanged, txtDvds.TextChanged, txtDvds.TextChanged

        'clear calculate amount
        lblSub.Text = String.Empty
        lblSale.Text = String.Empty
        lblTotal.Text = String.Empty
        lblText.Text = String.Empty
    End Sub

    Private Sub txtDate_Enter(sender As Object, e As EventArgs) Handles txtDate.Enter
        ' select content when tex box recieve focus
        txtDate.SelectAll()
    End Sub

    Private Sub txtDvds_Enter(sender As Object, e As EventArgs) Handles txtDvds.Enter
        ' select content when tex box recieve focus
        txtDvds.SelectAll()
    End Sub


End Class
