<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialMsgBox
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.tbmessage = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnhint = New System.Windows.Forms.Button()
        Me.PNLETTERS = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnball = New System.Windows.Forms.Panel()
        Me.pnpoke = New System.Windows.Forms.Panel()
        Me.lblpokenum = New System.Windows.Forms.Label()
        Me.btnNitro = New System.Windows.Forms.Button()
        Me.PNLETTERS.SuspendLayout()
        Me.pnpoke.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(563, 361)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "wew"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(690, 312)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(113, 32)
        Me.LinkLabel2.TabIndex = 26
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Continue"
        '
        'tbmessage
        '
        Me.tbmessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbmessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbmessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbmessage.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbmessage.Location = New System.Drawing.Point(-21, 47)
        Me.tbmessage.Multiline = True
        Me.tbmessage.Name = "tbmessage"
        Me.tbmessage.ReadOnly = True
        Me.tbmessage.ShortcutsEnabled = False
        Me.tbmessage.Size = New System.Drawing.Size(977, 267)
        Me.tbmessage.TabIndex = 27
        Me.tbmessage.Text = "........."
        Me.tbmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(850, 312)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 32)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Skip"
        '
        'btnTime
        '
        Me.btnTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTime.BackgroundImage = Global.WWWords.My.Resources.Resources.time
        Me.btnTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.Location = New System.Drawing.Point(426, 34)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(98, 89)
        Me.btnTime.TabIndex = 29
        Me.btnTime.UseVisualStyleBackColor = False
        Me.btnTime.Visible = False
        '
        'btnhint
        '
        Me.btnhint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnhint.BackgroundImage = Global.WWWords.My.Resources.Resources.idea
        Me.btnhint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhint.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhint.Location = New System.Drawing.Point(426, 34)
        Me.btnhint.Name = "btnhint"
        Me.btnhint.Size = New System.Drawing.Size(98, 89)
        Me.btnhint.TabIndex = 30
        Me.btnhint.UseVisualStyleBackColor = False
        Me.btnhint.Visible = False
        '
        'PNLETTERS
        '
        Me.PNLETTERS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PNLETTERS.Controls.Add(Me.Button3)
        Me.PNLETTERS.Controls.Add(Me.Button2)
        Me.PNLETTERS.Controls.Add(Me.Button1)
        Me.PNLETTERS.Location = New System.Drawing.Point(343, 21)
        Me.PNLETTERS.Name = "PNLETTERS"
        Me.PNLETTERS.Size = New System.Drawing.Size(268, 88)
        Me.PNLETTERS.TabIndex = 31
        Me.PNLETTERS.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(177, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "A"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(91, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "A"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnball
        '
        Me.pnball.BackColor = System.Drawing.Color.Transparent
        Me.pnball.BackgroundImage = Global.WWWords.My.Resources.Resources.ball
        Me.pnball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnball.Location = New System.Drawing.Point(3, 3)
        Me.pnball.Name = "pnball"
        Me.pnball.Size = New System.Drawing.Size(93, 95)
        Me.pnball.TabIndex = 32
        '
        'pnpoke
        '
        Me.pnpoke.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnpoke.Controls.Add(Me.lblpokenum)
        Me.pnpoke.Controls.Add(Me.pnball)
        Me.pnpoke.Location = New System.Drawing.Point(406, 12)
        Me.pnpoke.Name = "pnpoke"
        Me.pnpoke.Size = New System.Drawing.Size(153, 101)
        Me.pnpoke.TabIndex = 33
        Me.pnpoke.Visible = False
        '
        'lblpokenum
        '
        Me.lblpokenum.AutoSize = True
        Me.lblpokenum.BackColor = System.Drawing.Color.Transparent
        Me.lblpokenum.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpokenum.ForeColor = System.Drawing.Color.Black
        Me.lblpokenum.Location = New System.Drawing.Point(102, 32)
        Me.lblpokenum.Name = "lblpokenum"
        Me.lblpokenum.Size = New System.Drawing.Size(46, 35)
        Me.lblpokenum.TabIndex = 33
        Me.lblpokenum.Text = "-1"
        '
        'btnNitro
        '
        Me.btnNitro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNitro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNitro.BackgroundImage = Global.WWWords.My.Resources.Resources.rocket
        Me.btnNitro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNitro.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNitro.Location = New System.Drawing.Point(426, 26)
        Me.btnNitro.Name = "btnNitro"
        Me.btnNitro.Size = New System.Drawing.Size(98, 97)
        Me.btnNitro.TabIndex = 34
        Me.btnNitro.UseVisualStyleBackColor = False
        Me.btnNitro.Visible = False
        '
        'TutorialMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(951, 362)
        Me.Controls.Add(Me.btnNitro)
        Me.Controls.Add(Me.pnpoke)
        Me.Controls.Add(Me.PNLETTERS)
        Me.Controls.Add(Me.btnhint)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.tbmessage)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorialMsgBox"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLETTERS.ResumeLayout(False)
        Me.pnpoke.ResumeLayout(False)
        Me.pnpoke.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents tbmessage As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents btnhint As System.Windows.Forms.Button
    Friend WithEvents PNLETTERS As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnball As System.Windows.Forms.Panel
    Friend WithEvents pnpoke As System.Windows.Forms.Panel
    Friend WithEvents lblpokenum As System.Windows.Forms.Label
    Friend WithEvents btnNitro As System.Windows.Forms.Button
End Class
