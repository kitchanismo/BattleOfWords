Public Class BoWInstructions
    Dim ctr As Integer = 1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnn.Click
        ctr += 1

        If ctr = 2 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 1"
            l2.Text = "*Level 1- Capture the wild battlemon by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Capture the wild battlemon by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            btnp.Enabled = True
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 3 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 2"
            l2.Text = "*Level 1- Race your battlemon by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Race your battlemon by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 4 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 3"
            l2.Text = "*Level 1- Defeat your enemy by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Defeat your enemy by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 5 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = True
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            panellocation(Panel2)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 6 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
            Panel4.Visible = False
            Panel5.Visible = False
            panellocation(Panel3)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 7 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = True
            Panel5.Visible = False
            panellocation(Panel4)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 8 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = True
            btnn.Enabled = False
            panellocation(Panel5)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 9 Then
            ctr = 8
        End If
    End Sub
    Private Sub btnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnp.Click
        ctr -= 1
        If ctr = 1 Then
            lbltitle.Text = "Game Concept"
            l1.Text = "*Battle of Words is about World History. Particularly" & vbNewLine & "  in China, Greece, Italy and Rome."
            l2.Text = "*Each stage has different country to represent. " & vbNewLine & "  Stage 1 for China, " & vbNewLine & "  Stage 2 for Greece and Stage 3 is for Italy."
            l3.Text = "*Minigames is about Rome. The game concept" & vbNewLine & "  is speed typing."
            l4.Text = "*Each stage has 2 Levels. Level 1 is about reading " & vbNewLine & "  sentence and Level 2 is showing images."
            ctr = 1
            btnp.Enabled = False
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 2 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 1"
            l2.Text = "*Level 1- Capture the wild battlemon by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Capture the wild battlemon by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            btnp.Enabled = True
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 3 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 2"
            l2.Text = "*Level 1- Race your battlemon by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Race your battlemon by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 4 Then
            lbltitle.Text = "Instructions"
            l1.Text = "*Stage 3"
            l2.Text = "*Level 1- Defeat your enemy by spelling " & vbNewLine & "  the right term in a given sentence."
            l3.Text = "*Level 2- Defeat your enemy by spelling " & vbNewLine & "  the right term in a given image."
            l4.Text = ""
            PreventFlick()
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 5 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = True
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            panellocation(Panel2)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 6 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = True
            Panel4.Visible = False
            Panel5.Visible = False
            panellocation(Panel3)
            lblpage.Text = ctr & " of 8"
        ElseIf ctr = 7 Then
            PreventFlick()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = True
            Panel5.Visible = False
            panellocation(Panel4)
            btnn.Enabled = True
            lblpage.Text = ctr & " of 8"
        End If
    End Sub
    Protected Overloads Overrides ReadOnly Property Createparams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle
            Return cp
        End Get
    End Property
    Private Sub PreventFlick()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
 

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BoWInstructions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub panellocation(ByVal pn As Panel)
        pn.Left = Panel1.Location.X
        pn.Top = Panel1.Location.Y
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub
End Class