<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDahlia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDvds = New System.Windows.Forms.Label()
        Me.lblBlurays = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDvds = New System.Windows.Forms.TextBox()
        Me.txtBlurays = New System.Windows.Forms.TextBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(42, 46)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 21)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Da&te:"
        '
        'lblDvds
        '
        Me.lblDvds.AutoSize = True
        Me.lblDvds.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDvds.Location = New System.Drawing.Point(42, 90)
        Me.lblDvds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDvds.Name = "lblDvds"
        Me.lblDvds.Size = New System.Drawing.Size(52, 21)
        Me.lblDvds.TabIndex = 2
        Me.lblDvds.Text = "&DVDs:"
        '
        'lblBlurays
        '
        Me.lblBlurays.AutoSize = True
        Me.lblBlurays.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlurays.Location = New System.Drawing.Point(42, 134)
        Me.lblBlurays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlurays.Name = "lblBlurays"
        Me.lblBlurays.Size = New System.Drawing.Size(70, 21)
        Me.lblBlurays.TabIndex = 4
        Me.lblBlurays.Text = "&Blu-rays:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(42, 178)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(71, 21)
        Me.lblSubtotal.TabIndex = 8
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTax.Location = New System.Drawing.Point(42, 222)
        Me.lblSalesTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(73, 21)
        Me.lblSalesTax.TabIndex = 10
        Me.lblSalesTax.Text = "Sales tax:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.Location = New System.Drawing.Point(42, 266)
        Me.lblTotalDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(77, 21)
        Me.lblTotalDue.TabIndex = 12
        Me.lblTotalDue.Text = "Total due:"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(125, 46)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(108, 29)
        Me.txtDate.TabIndex = 1
        '
        'txtDvds
        '
        Me.txtDvds.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDvds.Location = New System.Drawing.Point(125, 84)
        Me.txtDvds.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDvds.Name = "txtDvds"
        Me.txtDvds.Size = New System.Drawing.Size(108, 29)
        Me.txtDvds.TabIndex = 3
        '
        'txtBlurays
        '
        Me.txtBlurays.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlurays.Location = New System.Drawing.Point(125, 126)
        Me.txtBlurays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBlurays.Name = "txtBlurays"
        Me.txtBlurays.Size = New System.Drawing.Size(108, 29)
        Me.txtBlurays.TabIndex = 5
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(125, 178)
        Me.lblSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(108, 29)
        Me.lblSub.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(134, 284)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 21)
        Me.Label9.TabIndex = 15
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Location = New System.Drawing.Point(46, 321)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(366, 75)
        Me.lblText.TabIndex = 14
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(265, 46)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(120, 34)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(265, 90)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 34)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSale
        '
        Me.lblSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Location = New System.Drawing.Point(125, 223)
        Me.lblSale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(108, 29)
        Me.lblSale.TabIndex = 11
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(125, 266)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(108, 29)
        Me.lblTotal.TabIndex = 13
        '
        'frmDahlia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 428)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.txtBlurays)
        Me.Controls.Add(Me.txtDvds)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblBlurays)
        Me.Controls.Add(Me.lblDvds)
        Me.Controls.Add(Me.lblDate)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDahlia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dahlia's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblDvds As Label
    Friend WithEvents lblBlurays As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtDvds As TextBox
    Friend WithEvents txtBlurays As TextBox
    Friend WithEvents lblSub As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblText As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSale As Label
    Friend WithEvents lblTotal As Label
End Class
