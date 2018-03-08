<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoWMinigame1
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
        Me.lblword = New System.Windows.Forms.Label()
        Me.tbguess = New System.Windows.Forms.TextBox()
        Me.lblpts = New System.Windows.Forms.Label()
        Me.lbllyfpts = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatAlertBox1 = New WWWords.FlatAlertBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblword2 = New System.Windows.Forms.Label()
        Me.timermove = New System.Windows.Forms.Timer(Me.components)
        Me.timermove2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbln = New System.Windows.Forms.Label()
        Me.lblta = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.pnavatar = New System.Windows.Forms.Panel()
        Me.pnphbarbase = New System.Windows.Forms.Panel()
        Me.pnphbar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnphbarbase.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblword
        '
        Me.lblword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblword.AutoSize = True
        Me.lblword.BackColor = System.Drawing.Color.Transparent
        Me.lblword.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblword.ForeColor = System.Drawing.Color.Black
        Me.lblword.Location = New System.Drawing.Point(102, 70)
        Me.lblword.Name = "lblword"
        Me.lblword.Size = New System.Drawing.Size(53, 38)
        Me.lblword.TabIndex = 1
        Me.lblword.Text = "..."
        '
        'tbguess
        '
        Me.tbguess.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbguess.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbguess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbguess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbguess.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbguess.ForeColor = System.Drawing.Color.White
        Me.tbguess.Location = New System.Drawing.Point(78, 606)
        Me.tbguess.Name = "tbguess"
        Me.tbguess.Size = New System.Drawing.Size(798, 59)
        Me.tbguess.TabIndex = 2
        Me.tbguess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpts
        '
        Me.lblpts.AutoSize = True
        Me.lblpts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpts.Location = New System.Drawing.Point(847, 311)
        Me.lblpts.Name = "lblpts"
        Me.lblpts.Size = New System.Drawing.Size(20, 24)
        Me.lblpts.TabIndex = 3
        Me.lblpts.Text = "0"
        Me.lblpts.Visible = False
        '
        'lbllyfpts
        '
        Me.lbllyfpts.AutoSize = True
        Me.lbllyfpts.BackColor = System.Drawing.Color.Transparent
        Me.lbllyfpts.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllyfpts.Location = New System.Drawing.Point(21, 600)
        Me.lbllyfpts.Name = "lbllyfpts"
        Me.lbllyfpts.Size = New System.Drawing.Size(37, 38)
        Me.lbllyfpts.TabIndex = 5
        Me.lbllyfpts.Text = "0"
        Me.lbllyfpts.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-13, 568)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Life Points"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(837, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "score"
        Me.Label6.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatAlertBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblword2)
        Me.Panel1.Controls.Add(Me.lblword)
        Me.Panel1.Location = New System.Drawing.Point(77, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 472)
        Me.Panel1.TabIndex = 8
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatAlertBox1.kind = WWWords.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(-1, 0)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(524, 42)
        Me.FlatAlertBox1.TabIndex = 5
        Me.FlatAlertBox1.Text = "FlatAlertBox1"
        Me.FlatAlertBox1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Location = New System.Drawing.Point(-4, 464)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(725, 10)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel4.Location = New System.Drawing.Point(0, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(725, 10)
        Me.Panel4.TabIndex = 4
        '
        'lblword2
        '
        Me.lblword2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblword2.AutoSize = True
        Me.lblword2.BackColor = System.Drawing.Color.Transparent
        Me.lblword2.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblword2.ForeColor = System.Drawing.Color.Black
        Me.lblword2.Location = New System.Drawing.Point(298, 122)
        Me.lblword2.Name = "lblword2"
        Me.lblword2.Size = New System.Drawing.Size(53, 38)
        Me.lblword2.TabIndex = 4
        Me.lblword2.Text = "..."
        Me.lblword2.Visible = False
        '
        'timermove
        '
        Me.timermove.Interval = 40
        '
        'timermove2
        '
        Me.timermove2.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.WWWords.My.Resources.Resources.idea
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(82, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 60)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.WWWords.My.Resources.Resources.time
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(209, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 60)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox3.BackgroundImage = Global.WWWords.My.Resources.Resources.rocket
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(337, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 60)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbln)
        Me.Panel2.Controls.Add(Me.lblta)
        Me.Panel2.Controls.Add(Me.lblh)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(78, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 116)
        Me.Panel2.TabIndex = 5
        '
        'lbln
        '
        Me.lbln.AutoSize = True
        Me.lbln.BackColor = System.Drawing.Color.Transparent
        Me.lbln.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbln.ForeColor = System.Drawing.Color.White
        Me.lbln.Location = New System.Drawing.Point(423, 62)
        Me.lbln.Name = "lbln"
        Me.lbln.Size = New System.Drawing.Size(28, 29)
        Me.lbln.TabIndex = 16
        Me.lbln.Text = "0"
        '
        'lblta
        '
        Me.lblta.AutoSize = True
        Me.lblta.BackColor = System.Drawing.Color.Transparent
        Me.lblta.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblta.ForeColor = System.Drawing.Color.White
        Me.lblta.Location = New System.Drawing.Point(293, 62)
        Me.lblta.Name = "lblta"
        Me.lblta.Size = New System.Drawing.Size(28, 29)
        Me.lblta.TabIndex = 15
        Me.lblta.Text = "0"
        '
        'lblh
        '
        Me.lblh.AutoSize = True
        Me.lblh.BackColor = System.Drawing.Color.Transparent
        Me.lblh.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.ForeColor = System.Drawing.Color.White
        Me.lblh.Location = New System.Drawing.Point(168, 62)
        Me.lblh.Name = "lblh"
        Me.lblh.Size = New System.Drawing.Size(28, 29)
        Me.lblh.TabIndex = 14
        Me.lblh.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(406, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(277, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(151, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "x"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.pnphbarbase)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.pnavatar)
        Me.Panel5.Location = New System.Drawing.Point(606, 132)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(270, 471)
        Me.Panel5.TabIndex = 5
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel11.Controls.Add(Me.LinkLabel1)
        Me.Panel11.Controls.Add(Me.LinkLabel2)
        Me.Panel11.Location = New System.Drawing.Point(77, 667)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(799, 42)
        Me.Panel11.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Snow
        Me.LinkLabel1.Location = New System.Drawing.Point(329, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(138, 25)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sound Settings"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Snow
        Me.LinkLabel2.Location = New System.Drawing.Point(698, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(48, 25)
        Me.LinkLabel2.TabIndex = 24
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Quit"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Controls.Add(Me.lblname)
        Me.Panel7.Location = New System.Drawing.Point(606, 12)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(270, 114)
        Me.Panel7.TabIndex = 6
        '
        'lblname
        '
        Me.lblname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(30, 41)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(48, 35)
        Me.lblname.TabIndex = 7
        Me.lblname.Text = "..."
        '
        'pnavatar
        '
        Me.pnavatar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnavatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnavatar.Location = New System.Drawing.Point(16, 15)
        Me.pnavatar.Name = "pnavatar"
        Me.pnavatar.Size = New System.Drawing.Size(237, 363)
        Me.pnavatar.TabIndex = 22
        '
        'pnphbarbase
        '
        Me.pnphbarbase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnphbarbase.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnphbarbase.Controls.Add(Me.pnphbar)
        Me.pnphbarbase.Location = New System.Drawing.Point(17, 405)
        Me.pnphbarbase.Name = "pnphbarbase"
        Me.pnphbarbase.Size = New System.Drawing.Size(236, 15)
        Me.pnphbarbase.TabIndex = 33
        '
        'pnphbar
        '
        Me.pnphbar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnphbar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnphbar.Location = New System.Drawing.Point(1, 1)
        Me.pnphbar.Name = "pnphbar"
        Me.pnphbar.Size = New System.Drawing.Size(235, 13)
        Me.pnphbar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(114, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "HP"
        '
        'BoWMinigame1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = Global.WWWords.My.Resources.Resources.background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 755)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbllyfpts)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblpts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbguess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BoWMinigame1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoWMiniGame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnphbarbase.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblword As System.Windows.Forms.Label
    Friend WithEvents tbguess As System.Windows.Forms.TextBox
    Friend WithEvents lblpts As System.Windows.Forms.Label
    Friend WithEvents lbllyfpts As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents timermove As System.Windows.Forms.Timer
    Friend WithEvents lblword2 As System.Windows.Forms.Label
    Friend WithEvents timermove2 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbln As System.Windows.Forms.Label
    Friend WithEvents lblta As System.Windows.Forms.Label
    Friend WithEvents lblh As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents FlatAlertBox1 As WWWords.FlatAlertBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents pnavatar As System.Windows.Forms.Panel
    Friend WithEvents pnphbarbase As System.Windows.Forms.Panel
    Friend WithEvents pnphbar As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
