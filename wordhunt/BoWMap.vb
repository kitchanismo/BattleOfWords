Public Class BoWMap

  
    Private Sub BoWMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetStage()
    End Sub

    Sub GetStage()
        If GetInfo("studstage") = 1 Then
            ' Panel1.BackColor = Color.MediumSeaGreen '
            ' Label1.Text = "1-" & GetInfo("studlevel")
            lbls1.Text = lbls1.Text & "-" & GetInfo("studlevel")
            Panel1.BackgroundImage = My.Resources.chinaflag
        ElseIf GetInfo("studstage") = 2 Then
            ' Panel1.BackColor = Color.MediumSeaGreen
            '  Panel2.BackColor = Color.MediumSeaGreen
            lbls1.Text = "Completed"
            Panel1.BackgroundImage = My.Resources.chinacheck
            Panel2.BackgroundImage = My.Resources.greece
            lbls2.Text = lbls2.Text & "-" & GetInfo("studlevel")
            Label1.Left = 25
            Label1.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ' Label2.Text = "2-" & GetInfo("studlevel")
            If GetInfo("studm1") = 1 Then
                ' pnm1.BackColor = Color.MediumSeaGreen
                pnm1.BackgroundImage = My.Resources.minigame
            End If
        ElseIf GetInfo("studstage") = 3 And GetInfo("studlevel") <> 3 Then
            lbls1.Text = "Completed"
            lbls2.Text = "Completed"
            Panel1.BackgroundImage = My.Resources.chinacheck
            Panel2.BackgroundImage = My.Resources.greececheck
            Panel3.BackgroundImage = My.Resources.italy
            ' Panel1.BackColor = Color.MediumSeaGreen
            ' Panel2.BackColor = Color.MediumSeaGreen
            ' Panel3.BackColor = Color.MediumSeaGreen
            lbls3.Text = lbls3.Text & "-" & GetInfo("studlevel")
            Label1.Left = 25
            Label1.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            '  Label2.Left = 25
            'Label2.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            ' Label1.Text = "Stage 1 Completed"
            'Label2.Text = "Stage 2 Completed"
            ' Label3.Text = "3-" & GetInfo("studlevel")

            If GetInfo("studm1") = 1 Then
                pnm1.BackgroundImage = My.Resources.minigame
            Else
                pnm1.BackgroundImage = My.Resources.blacklocation

            End If
            If GetInfo("studm2") = 1 Then
                pnm2.BackgroundImage = My.Resources.minigame
            Else
                pnm2.BackgroundImage = My.Resources.blacklocation

            End If
        ElseIf GetInfo("studstage") = 3 And GetInfo("studlevel") = 3 Then
            lbls1.Text = "Completed"
            lbls2.Text = "Completed"
            lbls3.Text = "Completed"
            Panel1.BackgroundImage = My.Resources.chinacheck
            Panel2.BackgroundImage = My.Resources.greececheck
            Panel3.BackgroundImage = My.Resources.italycheck

        End If
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick, Label1.MouseClick
        If GetInfo("studstage") = 1 Then
            ' BoWStage1.Show()
            BoWStage1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        If GetInfo("studstage") = 2 Then
            BoWStage2.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Panel3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick, Label3.MouseClick
        If GetInfo("studstage") = 3 And GetInfo("studlevel") <> 3 Then
            BoWStage3.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub pnm1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnm1.MouseClick, Label4.MouseClick
        If GetInfo("studm1") = 1 Then
            BoWMinigame1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pnm2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnm2.MouseClick
        If GetInfo("studm2") = 1 Then
            BoWMinigame1.Show()
            Me.Close()
        End If
    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BoWMain.Show()
        Me.Close()
    End Sub

  

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbls3.Click

    End Sub
End Class