<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBegin = New System.Windows.Forms.Label()
        Me.lblend = New System.Windows.Forms.Label()
        Me.txtMilesBegin = New System.Windows.Forms.TextBox()
        Me.txtMilesEnd = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblBaseCharges = New System.Windows.Forms.Label()
        Me.lblMilesDriven = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblChargeFee = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrtScn = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(22, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(135, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Customer's &name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(163, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 29)
        Me.txtName.TabIndex = 1
        '
        'lblBegin
        '
        Me.lblBegin.AutoSize = True
        Me.lblBegin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBegin.Location = New System.Drawing.Point(22, 76)
        Me.lblBegin.Name = "lblBegin"
        Me.lblBegin.Size = New System.Drawing.Size(93, 21)
        Me.lblBegin.TabIndex = 2
        Me.lblBegin.Text = "Miles &begin:"
        Me.lblBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblend
        '
        Me.lblend.AutoSize = True
        Me.lblend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblend.Location = New System.Drawing.Point(22, 121)
        Me.lblend.Name = "lblend"
        Me.lblend.Size = New System.Drawing.Size(80, 21)
        Me.lblend.TabIndex = 4
        Me.lblend.Text = "Miles &end:"
        Me.lblend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMilesBegin
        '
        Me.txtMilesBegin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilesBegin.Location = New System.Drawing.Point(163, 77)
        Me.txtMilesBegin.Name = "txtMilesBegin"
        Me.txtMilesBegin.Size = New System.Drawing.Size(113, 29)
        Me.txtMilesBegin.TabIndex = 3
        '
        'txtMilesEnd
        '
        Me.txtMilesEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilesEnd.Location = New System.Drawing.Point(163, 123)
        Me.txtMilesEnd.Name = "txtMilesEnd"
        Me.txtMilesEnd.Size = New System.Drawing.Size(113, 29)
        Me.txtMilesEnd.TabIndex = 5
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(363, 31)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(70, 21)
        Me.lblBase.TabIndex = 10
        Me.lblBase.Text = "B&ase fee:"
        Me.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMiles.Location = New System.Drawing.Point(363, 125)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(136, 21)
        Me.lblTotalMiles.TabIndex = 14
        Me.lblTotalMiles.Text = "T&otal miles driven:"
        Me.lblTotalMiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(363, 172)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(79, 21)
        Me.lblTotalCost.TabIndex = 16
        Me.lblTotalCost.Text = "&Total cost:"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBaseCharges
        '
        Me.lblBaseCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBaseCharges.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseCharges.Location = New System.Drawing.Point(524, 31)
        Me.lblBaseCharges.Name = "lblBaseCharges"
        Me.lblBaseCharges.Size = New System.Drawing.Size(92, 29)
        Me.lblBaseCharges.TabIndex = 11
        Me.lblBaseCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMilesDriven
        '
        Me.lblMilesDriven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMilesDriven.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesDriven.Location = New System.Drawing.Point(524, 125)
        Me.lblMilesDriven.Name = "lblMilesDriven"
        Me.lblMilesDriven.Size = New System.Drawing.Size(92, 29)
        Me.lblMilesDriven.TabIndex = 15
        Me.lblMilesDriven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(524, 172)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 29)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(52, 221)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(112, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(333, 221)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(481, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.Location = New System.Drawing.Point(363, 78)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(124, 21)
        Me.lblCharge.TabIndex = 12
        Me.lblCharge.Text = "C&harge per mile:"
        Me.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChargeFee
        '
        Me.lblChargeFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChargeFee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChargeFee.Location = New System.Drawing.Point(524, 78)
        Me.lblChargeFee.Name = "lblChargeFee"
        Me.lblChargeFee.Size = New System.Drawing.Size(92, 29)
        Me.lblChargeFee.TabIndex = 13
        Me.lblChargeFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(191, 221)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 35)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrtScn
        '
        Me.PrtScn.DocumentName = "document"
        Me.PrtScn.Form = Me
        Me.PrtScn.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrtScn.PrinterSettings = CType(resources.GetObject("PrtScn.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrtScn.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 292)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblChargeFee)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMilesDriven)
        Me.Controls.Add(Me.lblBaseCharges)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtMilesEnd)
        Me.Controls.Add(Me.txtMilesBegin)
        Me.Controls.Add(Me.lblend)
        Me.Controls.Add(Me.lblBegin)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent-A-Van"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblBegin As Label
    Friend WithEvents lblend As Label
    Friend WithEvents txtMilesBegin As TextBox
    Friend WithEvents txtMilesEnd As TextBox
    Friend WithEvents lblBase As Label
    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblBaseCharges As Label
    Friend WithEvents lblMilesDriven As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblChargeFee As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrtScn As PowerPacks.Printing.PrintForm
End Class
