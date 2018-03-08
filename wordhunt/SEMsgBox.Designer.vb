<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEMsgBox
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
        Me.FlatToggleBM = New WWWords.FlatToggle()
        Me.lblcturn = New System.Windows.Forms.Label()
        Me.FlatToggleSE = New WWWords.FlatToggle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(567, 271)
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
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(874, 48)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(57, 40)
        Me.LinkLabel2.TabIndex = 27
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "<<"
        '
        'FlatToggleBM
        '
        Me.FlatToggleBM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatToggleBM.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggleBM.Checked = True
        Me.FlatToggleBM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggleBM.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggleBM.Location = New System.Drawing.Point(262, 78)
        Me.FlatToggleBM.Name = "FlatToggleBM"
        Me.FlatToggleBM.Options = WWWords.FlatToggle._Options.Style2
        Me.FlatToggleBM.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggleBM.TabIndex = 29
        Me.FlatToggleBM.Text = "FlatToggle1"
        '
        'lblcturn
        '
        Me.lblcturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcturn.AutoSize = True
        Me.lblcturn.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcturn.Location = New System.Drawing.Point(176, 32)
        Me.lblcturn.Name = "lblcturn"
        Me.lblcturn.Size = New System.Drawing.Size(277, 35)
        Me.lblcturn.TabIndex = 28
        Me.lblcturn.Text = "Background Music"
        '
        'FlatToggleSE
        '
        Me.FlatToggleSE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatToggleSE.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggleSE.Checked = True
        Me.FlatToggleSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggleSE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggleSE.Location = New System.Drawing.Point(585, 73)
        Me.FlatToggleSE.Name = "FlatToggleSE"
        Me.FlatToggleSE.Options = WWWords.FlatToggle._Options.Style2
        Me.FlatToggleSE.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggleSE.TabIndex = 31
        Me.FlatToggleSE.Text = "FlatToggle2"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(528, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 35)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Sound Effect"
        '
        'SEMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(951, 148)
        Me.Controls.Add(Me.FlatToggleSE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlatToggleBM)
        Me.Controls.Add(Me.lblcturn)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SEMsgBox"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents FlatToggleBM As WWWords.FlatToggle
    Friend WithEvents lblcturn As System.Windows.Forms.Label
    Friend WithEvents FlatToggleSE As WWWords.FlatToggle
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
