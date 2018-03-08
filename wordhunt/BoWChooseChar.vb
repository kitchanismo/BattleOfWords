Public Class BoWChooseChar
    Dim by, br, bb As Boolean

    Private Sub pnyellow_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnyellow.MouseClick
        pnyellow.BackColor = Color.Firebrick
        pnred.BackColor = Color.FromArgb(180, 120, 25, 0)
        by = True
        br = False
        bb = False
        strgender = "female"
    End Sub

    Private Sub pnred_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnred.MouseClick
        pnred.BackColor = Color.Firebrick
        pnyellow.BackColor = Color.FromArgb(180, 120, 25, 0)
        br = True
        by = False
        bb = False
        strgender = "male"
    End Sub



   

    Private Sub BoWChooseChar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GetGen("studavatar") = "female" Then
            pnyellow.BackColor = Color.Firebrick
            by = True
            br = False
            bb = False
            strgender = "female"
        Else
            pnred.BackColor = Color.Firebrick
            br = True
            by = False
            bb = False
            strgender = "male"
        End If
    End Sub

   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If strgender = "" Then

            Exit Sub
        End If
        UpdateGen("studavatar", strgender)
        BoWMap.Show()
        Me.Close()
    End Sub

    Private Sub pnyellow_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnyellow.Paint

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BoWMain.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If strgender = "" Then

            Exit Sub
        End If
        UpdateGen("studavatar", strgender)
        BoWMap.Show()
        Me.Close()
    End Sub
End Class