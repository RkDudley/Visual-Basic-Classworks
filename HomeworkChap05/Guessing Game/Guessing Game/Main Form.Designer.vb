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
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.BtnGuess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTopic = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(66, 197)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(332, 112)
        Me.lblMsg.TabIndex = 6
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuess
        '
        Me.txtGuess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuess.Location = New System.Drawing.Point(304, 86)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(74, 29)
        Me.txtGuess.TabIndex = 1
        Me.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.Location = New System.Drawing.Point(87, 94)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(212, 21)
        Me.lblGuess.TabIndex = 0
        Me.lblGuess.Text = "Enter number between 1-30: "
        '
        'BtnGuess
        '
        Me.BtnGuess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuess.Location = New System.Drawing.Point(171, 137)
        Me.BtnGuess.Name = "BtnGuess"
        Me.BtnGuess.Size = New System.Drawing.Size(122, 31)
        Me.BtnGuess.TabIndex = 3
        Me.BtnGuess.Text = "&Enter Guess"
        Me.BtnGuess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(253, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTopic
        '
        Me.lblTopic.AutoSize = True
        Me.lblTopic.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopic.Location = New System.Drawing.Point(86, 25)
        Me.lblTopic.Name = "lblTopic"
        Me.lblTopic.Size = New System.Drawing.Size(292, 32)
        Me.lblTopic.TabIndex = 7
        Me.lblTopic.Text = "Number Guessing Game"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(113, 336)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 31)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblGen
        '
        Me.lblGen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGen.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen.Location = New System.Drawing.Point(171, 410)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(109, 51)
        Me.lblGen.TabIndex = 8
        Me.lblGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 400)
        Me.Controls.Add(Me.lblGen)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTopic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnGuess)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents lblGuess As Label
    Friend WithEvents BtnGuess As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTopic As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblGen As Label
End Class
