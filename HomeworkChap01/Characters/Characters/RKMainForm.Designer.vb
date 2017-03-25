<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacters
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
        Me.components = New System.ComponentModel.Container()
        Me.PicDarth = New System.Windows.Forms.PictureBox()
        Me.PicTrooper = New System.Windows.Forms.PictureBox()
        Me.TmrExit = New System.Windows.Forms.Timer(Me.components)
        Me.lblDarth = New System.Windows.Forms.Label()
        Me.lblTrooper = New System.Windows.Forms.Label()
        CType(Me.PicDarth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTrooper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicDarth
        '
        Me.PicDarth.Image = Global.Characters.My.Resources.Resources.Darth
        Me.PicDarth.Location = New System.Drawing.Point(26, 30)
        Me.PicDarth.Name = "PicDarth"
        Me.PicDarth.Size = New System.Drawing.Size(166, 208)
        Me.PicDarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDarth.TabIndex = 0
        Me.PicDarth.TabStop = False
        '
        'PicTrooper
        '
        Me.PicTrooper.Image = Global.Characters.My.Resources.Resources.Trooper
        Me.PicTrooper.Location = New System.Drawing.Point(198, 30)
        Me.PicTrooper.Name = "PicTrooper"
        Me.PicTrooper.Size = New System.Drawing.Size(166, 208)
        Me.PicTrooper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTrooper.TabIndex = 1
        Me.PicTrooper.TabStop = False
        '
        'TmrExit
        '
        Me.TmrExit.Enabled = True
        Me.TmrExit.Interval = 5000
        '
        'lblDarth
        '
        Me.lblDarth.AutoSize = True
        Me.lblDarth.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarth.Location = New System.Drawing.Point(68, 261)
        Me.lblDarth.Name = "lblDarth"
        Me.lblDarth.Size = New System.Drawing.Size(83, 37)
        Me.lblDarth.TabIndex = 2
        Me.lblDarth.Text = "Darth"
        '
        'lblTrooper
        '
        Me.lblTrooper.AutoSize = True
        Me.lblTrooper.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrooper.Location = New System.Drawing.Point(193, 261)
        Me.lblTrooper.Name = "lblTrooper"
        Me.lblTrooper.Size = New System.Drawing.Size(177, 37)
        Me.lblTrooper.TabIndex = 3
        Me.lblTrooper.Text = "Stromtrooper"
        '
        'frmCharacters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 327)
        Me.Controls.Add(Me.lblTrooper)
        Me.Controls.Add(Me.lblDarth)
        Me.Controls.Add(Me.PicTrooper)
        Me.Controls.Add(Me.PicDarth)
        Me.Name = "frmCharacters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Star Wars Characters"
        CType(Me.PicDarth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTrooper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicDarth As PictureBox
    Friend WithEvents PicTrooper As PictureBox
    Friend WithEvents TmrExit As Timer
    Friend WithEvents lblDarth As Label
    Friend WithEvents lblTrooper As Label
End Class
