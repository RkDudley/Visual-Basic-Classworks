<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picWeight = New System.Windows.Forms.PictureBox()
        Me.lblEarth = New System.Windows.Forms.Label()
        Me.lblVenus = New System.Windows.Forms.Label()
        Me.lblMars = New System.Windows.Forms.Label()
        Me.txtWeightEarth = New System.Windows.Forms.TextBox()
        Me.lblJupiter = New System.Windows.Forms.Label()
        Me.lblWeightVenus = New System.Windows.Forms.Label()
        Me.lblWeightMars = New System.Windows.Forms.Label()
        Me.lblWeightJupiter = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWeight
        '
        Me.picWeight.Image = Global.Planet.My.Resources.Resources.pic01
        Me.picWeight.Location = New System.Drawing.Point(39, 30)
        Me.picWeight.Name = "picWeight"
        Me.picWeight.Size = New System.Drawing.Size(70, 72)
        Me.picWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeight.TabIndex = 0
        Me.picWeight.TabStop = False
        '
        'lblEarth
        '
        Me.lblEarth.AutoSize = True
        Me.lblEarth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarth.Location = New System.Drawing.Point(120, 48)
        Me.lblEarth.Name = "lblEarth"
        Me.lblEarth.Size = New System.Drawing.Size(140, 21)
        Me.lblEarth.TabIndex = 0
        Me.lblEarth.Text = "&Enter your weight :"
        '
        'lblVenus
        '
        Me.lblVenus.AutoSize = True
        Me.lblVenus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenus.Location = New System.Drawing.Point(57, 117)
        Me.lblVenus.Name = "lblVenus"
        Me.lblVenus.Size = New System.Drawing.Size(60, 21)
        Me.lblVenus.TabIndex = 6
        Me.lblVenus.Text = "Venus :"
        '
        'lblMars
        '
        Me.lblMars.AutoSize = True
        Me.lblMars.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMars.Location = New System.Drawing.Point(57, 163)
        Me.lblMars.Name = "lblMars"
        Me.lblMars.Size = New System.Drawing.Size(52, 21)
        Me.lblMars.TabIndex = 8
        Me.lblMars.Text = "Mars :"
        '
        'txtWeightEarth
        '
        Me.txtWeightEarth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeightEarth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeightEarth.Location = New System.Drawing.Point(266, 46)
        Me.txtWeightEarth.Name = "txtWeightEarth"
        Me.txtWeightEarth.Size = New System.Drawing.Size(96, 29)
        Me.txtWeightEarth.TabIndex = 1
        Me.txtWeightEarth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblJupiter
        '
        Me.lblJupiter.AutoSize = True
        Me.lblJupiter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJupiter.Location = New System.Drawing.Point(57, 209)
        Me.lblJupiter.Name = "lblJupiter"
        Me.lblJupiter.Size = New System.Drawing.Size(68, 21)
        Me.lblJupiter.TabIndex = 10
        Me.lblJupiter.Text = "Jupiter : "
        '
        'lblWeightVenus
        '
        Me.lblWeightVenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightVenus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightVenus.Location = New System.Drawing.Point(138, 117)
        Me.lblWeightVenus.Name = "lblWeightVenus"
        Me.lblWeightVenus.Size = New System.Drawing.Size(70, 27)
        Me.lblWeightVenus.TabIndex = 7
        Me.lblWeightVenus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeightMars
        '
        Me.lblWeightMars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightMars.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightMars.Location = New System.Drawing.Point(138, 163)
        Me.lblWeightMars.Name = "lblWeightMars"
        Me.lblWeightMars.Size = New System.Drawing.Size(70, 27)
        Me.lblWeightMars.TabIndex = 9
        Me.lblWeightMars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeightJupiter
        '
        Me.lblWeightJupiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightJupiter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightJupiter.Location = New System.Drawing.Point(138, 209)
        Me.lblWeightJupiter.Name = "lblWeightJupiter"
        Me.lblWeightJupiter.Size = New System.Drawing.Size(70, 27)
        Me.lblWeightJupiter.TabIndex = 11
        Me.lblWeightJupiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(258, 117)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(104, 30)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(258, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(258, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 274)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblWeightJupiter)
        Me.Controls.Add(Me.lblWeightMars)
        Me.Controls.Add(Me.lblWeightVenus)
        Me.Controls.Add(Me.lblJupiter)
        Me.Controls.Add(Me.txtWeightEarth)
        Me.Controls.Add(Me.lblMars)
        Me.Controls.Add(Me.lblVenus)
        Me.Controls.Add(Me.lblEarth)
        Me.Controls.Add(Me.picWeight)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weight On the Other Planets"
        CType(Me.picWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picWeight As PictureBox
    Friend WithEvents lblEarth As Label
    Friend WithEvents lblVenus As Label
    Friend WithEvents lblMars As Label
    Friend WithEvents txtWeightEarth As TextBox
    Friend WithEvents lblJupiter As Label
    Friend WithEvents lblWeightVenus As Label
    Friend WithEvents lblWeightMars As Label
    Friend WithEvents lblWeightJupiter As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
