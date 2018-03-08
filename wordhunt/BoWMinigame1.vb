
Imports System.IO
Public Class BoWMinigame1
    Dim pts As Integer
    Dim tryagain As Integer
    Dim ctr As Integer = 2
    Dim hs As String
    Dim wLenght As Integer = 4
    Public Sub GetGender()
        If "male" = GetGen("studavatar") Then
            pnavatar.BackgroundImage = My.Resources.male
        Else
            pnavatar.BackgroundImage = My.Resources.female
        End If
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbguess.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
            If tbguess.Text = "" Then
                Exit Sub
            End If

            If lblword.Text = tbguess.Text.Trim Then
                tbguess.Text = ""
                tbguess.ForeColor = Color.White

                lblpts.Text = pts
                lblword.Top = 25 'reset location
                xChooseWord(lblword, wLenght)
                pts += 1
                If pts = 2 Then
                    wLenght = 5 ' word lenght change to 6
                    xChooseWord(lblword, wLenght)
                ElseIf pts = 3 Then
                    wLenght = 6
                    xChooseWord(lblword2, wLenght)
                ElseIf pts = 4 Then
                    wLenght = 7
                    timermove.Interval = 20
                    xChooseWord(lblword2, wLenght)
                ElseIf pts = 5 Then
                    wLenght = 8
                    timermove.Interval = 10
                    xChooseWord(lblword2, wLenght)
                ElseIf pts > 5 Then
                    wLenght = 6 ' word lenght change to 10
                    timerstop() 'timer stop
                    timerstart() 'timer start
                    timermove.Interval = 20
                    ' timermove2.Interval = 30 '2nd word fast
                    xChooseWord(lblword, wLenght)
                    'xChooseWord(lblword2, wLenght)
                    lblword2.Visible = True
                End If

            ElseIf lblword2.Text = tbguess.Text.Trim Then
                tbguess.Text = ""
                tbguess.ForeColor = Color.White

                lblpts.Text = pts
                lblword2.Top = 25 'reset location
                xChooseWord(lblword2, wLenght)
            Else
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Wrong Spelling!", 2000)
                BuzzEffects()
                Exit Sub
            End If
            AddPrivi()
            RandomPrivi()
            rn = kit.RN(1, 3)
            lblpts.Text += 1
        End If
    End Sub

    Public Sub AddPrivi()
        If lblword.BackColor = Color.FromArgb(128, 255, 255) Then 'hint
            lblh.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint!", 2000)
        ElseIf lblword.BackColor = Color.FromArgb(255, 128, 255) Then ' time
            lblta.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time!", 2000)
        ElseIf lblword.BackColor = Color.FromArgb(255, 192, 128) Then ' booster
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Booster!", 2000)
            lbln.Text += 1
        Else
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowMessageBox("Catch all the Privileges!", Me, Color.White)
        ShowMessageBox("Type the Terms from History of Rome to Gain More Privileges!", Me, Color.White)
        xChooseWord(lblword, wLenght)
        timermove.Start()
        lbllyfpts.Text = lyfpts
        rn = kit.RN(1, 3)
        RandomPrivi()
        BGMLevel1()
        GetGender()
        lblname.Text = pname.ToUpper
    End Sub

    Dim rn As Integer

    Public Sub RandomPrivi()
        If rn = 1 Then
            lblword.BackColor = Color.FromArgb(128, 255, 255)
            lblword2.BackColor = Color.FromArgb(255, 128, 255)
        ElseIf rn = 2 Then
            lblword.BackColor = Color.FromArgb(255, 128, 255)
            lblword2.BackColor = Color.FromArgb(128, 255, 255)
        ElseIf rn = 3 Then
            lblword.BackColor = Color.FromArgb(255, 192, 128)
            lblword2.BackColor = Color.FromArgb(128, 255, 255)
        End If
    End Sub


    Dim lyfpts As Integer = 3
    Private Sub timermove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timermove.Tick
        lblword.Top += ctr
        If lblword.Top >= Panel1.Height - 50 Then
            lblword.Top = 25
            lyfpts -= 1
            pnphbar.Width -= 50
            lbllyfpts.Text = lyfpts
            xChooseWord(lblword, wLenght)
            tbguess.ForeColor = Color.White
            tbguess.Text = ""
            'condition for life points 
            BuzzEffects()
            kit.Shake(pnavatar, 25, 4, 1)
            ' If lyfpts <= 0 Then
            If pnphbar.Width <= 100 Then
                pnphbar.BackColor = Color.LightCoral
            End If
            If pnphbar.Width <= 0 Then
                timerstop()
                ExplosionEffects()
                BGMStop()
                ShowMessageBox("Game Over!", Me, Color.White)
                UpdateInfo("studhint", Val(lblh.Text) + GetInfo("studhint"))
                UpdateInfo("studta", Val(lblta.Text) + GetInfo("studta"))
                UpdateInfo("studnb", Val(lbln.Text) + GetInfo("studnb"))
                UpdateInfo("studm1", 0)
                M1ShowMessageBox("Added Privileges!", Me, Color.White)
                timerstop()
                BoWMap.Show()
                Me.Close()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub timermove2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timermove2.Tick
        lblword2.Top += ctr
        If lblword2.Top >= Panel1.Height - 50 Then
            lblword2.Top = 25
            pnphbar.Width -= 50
            lyfpts -= 1
            lbllyfpts.Text = lyfpts
            xChooseWord(lblword2, wLenght)
         tbguess.ForeColor = Color.White
            tbguess.Text = ""
            'condition for life points 
            BuzzEffects()
            kit.Shake(pnavatar, 25, 4, 1)
            ' If lyfpts <= 0 Then
            If pnphbar.Width <= 100 Then
                pnphbar.BackColor = Color.LightCoral
            End If
            If pnphbar.Width <= 0 Then
                ExplosionEffects()
                BGMStop()
                timerstop()
                ShowMessageBox("Game Over!", Me, Color.White)
                UpdateInfo("studhint", lblh.Text)
                UpdateInfo("studta", lblta.Text)
                UpdateInfo("studnb", lbln.Text)
                UpdateInfo("studm1", 0)
                M1ShowMessageBox("Added Privileges!", Me, Color.White)
                timerstop()
                BoWMap.Show()
                Me.Close()
                Exit Sub
            End If
        End If

    End Sub

    Public Sub timerstop()
        timermove.Stop()
        timermove2.Stop()
    End Sub
    Public Sub timerstart()
        timermove.Start()
        timermove2.Start()
    End Sub
    Public Sub timerintervalreset()
        timermove.Interval = 50
        timermove2.Interval = 50
    End Sub

  
    Private Sub tbguess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbguess.KeyPress
        ClickEffects()
    End Sub

  
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BGMStop()
     
        timerstop()
        ShowSSMessageBox(Me, Color.RoyalBlue)
        timerstart()
        BGMLevel1()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BGMStop()
        timerstop()
        ShowQYesNoMessageBox(Me, Color.LightCoral)
        timerstart()
        BGMLevel1()
    End Sub
End Class
