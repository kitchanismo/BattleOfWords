Public Class BoWMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplay.Click
        If GetInfo("studlevel") = 2 Or GetInfo("studstage") >= 2 Then
            BoWMap.Show()
            Me.Close()
        Else
            BoWChooseChar.Show()
            Me.Close()
        End If
      
    End Sub
 

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        BoWHighscore.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BoWregister.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ShowSSMessageBox(Me, Color.WhiteSmoke)
        Me.Show()
    End Sub

    Private Sub BoWMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If GetInfo("studlevel") = 2 Or GetInfo("studstage") >= 2 Then
            btnnew.Visible = True
            btnplay.Text = "Resume"
        Else
            btnnew.Visible = False
            btnplay.Text = "Play"
        End If

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        resetinfo()
        BoWChooseChar.Show()
        Me.Close()
    End Sub

    Sub resetinfo()
        UpdateInfo("studstage", 1)
        UpdateInfo("studlevel", 1)
        UpdateInfo("studhint", 3)
        UpdateInfo("studta", 3)
        UpdateInfo("studnb", 3)
        UpdateInfo("studm1", 0)
        UpdateInfo("studm2", 0)
        UpdateInfo("studscore", 0)
        UpdateInfo("studpokenum", 5)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BoWInstructions.ShowDialog()
    End Sub
End Class