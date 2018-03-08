<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TriviaMsgBox
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
        Me.lblcturn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(570, 500)
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
        Me.LinkLabel2.Location = New System.Drawing.Point(874, 218)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(57, 40)
        Me.LinkLabel2.TabIndex = 26
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "<<"
        '
        'tbmessage
        '
        Me.tbmessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbmessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbmessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbmessage.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbmessage.Location = New System.Drawing.Point(124, 142)
        Me.tbmessage.Multiline = True
        Me.tbmessage.Name = "tbmessage"
        Me.tbmessage.ReadOnly = True
        Me.tbmessage.ShortcutsEnabled = False
        Me.tbmessage.Size = New System.Drawing.Size(746, 266)
        Me.tbmessage.TabIndex = 27
        Me.tbmessage.Text = "........."
        Me.tbmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcturn
        '
        Me.lblcturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcturn.AutoSize = True
        Me.lblcturn.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcturn.Location = New System.Drawing.Point(384, 61)
        Me.lblcturn.Name = "lblcturn"
        Me.lblcturn.Size = New System.Drawing.Size(234, 35)
        Me.lblcturn.TabIndex = 29
        Me.lblcturn.Text = "Did You Know?"
        '
        'TriviaMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(951, 487)
        Me.Controls.Add(Me.lblcturn)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.tbmessage)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TriviaMsgBox"
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
    Friend WithEvents tbmessage As System.Windows.Forms.TextBox
    Friend WithEvents lblcturn As System.Windows.Forms.Label
End Class
