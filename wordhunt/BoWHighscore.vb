Public Class BoWHighscore

    Private Sub BoWHighscore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateHighScore()
    End Sub
    Sub PopulateHighScore()
        connected()
        With lvHS
            .Items.Clear()
            sql = " SELECT * FROM tblscore where studscore <> 0 order by studscore desc"
            CommandDB()
            dr = cmd.ExecuteReader()
            lvHS.Items.Clear()
            While (dr.Read())
                With lvHS.Items.Add(dr("studcname"))
                    .SubItems.Add(dr("studscore"))
                End With
            End While
        End With
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BoWMain.Show()
        Me.Close()
    End Sub
End Class