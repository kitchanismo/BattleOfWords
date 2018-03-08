Imports System.Runtime.InteropServices
Public Class BoWStage1
    Dim wordlenght As Integer
    Dim rambleletters As String
    Dim str As String
    Dim n As Integer = 0
    Dim arTemp() As String = Nothing '// used to get all lines from TextBox.
    Dim sTemp As String = Nothing '// used to add lines back to TextBox.
    Dim enemybluename As String = "Psyduck"
    Dim enemyvioletname As String = "Bulbasor"
    Dim enemyredname As String = "Charmander"
    Dim enemybluedetail As String = "     'He Loves Milk'"
    Dim enemyvioletdetail As String = "'He Loves Chocolate'"
    Dim enemyreddetail As String = "'He Loves Strawberry'"
    Dim enemybluecolor As Color = Color.White
    Dim enemyvioletcolor As Color = Color.Chocolate
    Dim enemyredcolor As Color = Color.Crimson
    Dim lines() As String
    Dim lines2() As String
    Dim pnh1 As Object

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Private Sub BoWStage2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'blackscreen.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tutorial = True
        ShowMessageBox("Catch Them All!", Me, Color.WhiteSmoke)
        ShowMessageBox("Stage 1 is about the History of China.", Me, Color.WhiteSmoke)
        SeperateLetter(GenerateWords()) 'seperate each letter in btn
        AssignButtonNumber() 'assigning number in btn 
        lines = IO.File.ReadAllLines(Application.StartupPath & "\" & chinawords)
        ListBox2.Items.AddRange(lines)
        lines2 = IO.File.ReadAllLines(Application.StartupPath & "\" & chinawordsmeaning)
        ListBox3.Items.AddRange(lines2)
        levelnum = GetInfo("studlevel")
        ConditionForLevel(levelnum)
        TimerPlayerTurn.Start()
        TimerStartGame.Start()
        LoadPlayerInfo()
        GetGender()
        'tbrword.Text = kit.ScrambleWord(wordtouse(5))
        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
        tutorial = False
    End Sub



    Public Sub GetGender()
        If "male" = GetGen("studavatar") Then
            pnavatar.BackgroundImage = My.Resources.male
        Else
            pnavatar.BackgroundImage = My.Resources.female
        End If
    End Sub
#Region "Buttons"
    Public Sub FuelBarCondition(ByVal lbl As Label)
        If btnl5.Text = "" Then 'condition if btn word is not completed
            pnpfuel.Width = ((FuelBar(lbl) * usebomb) + pnpfuel.Width) 'fuelbar = selected fuelbarnum * nitro + fuelbar width
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClickEffects()
        FuelBarCondition(lbl1)
        AppendLetter(Button1, lbl1)
        pattackp += PlayerAttackPoints(Button1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClickEffects()
        FuelBarCondition(lbl2)
        AppendLetter(Button2, lbl2)
        pattackp += PlayerAttackPoints(Button2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ClickEffects()
        FuelBarCondition(lbl3)
        AppendLetter(Button3, lbl3)
        pattackp += PlayerAttackPoints(Button3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ClickEffects()
        FuelBarCondition(lbl4)
        AppendLetter(Button4, lbl4)
        pattackp += PlayerAttackPoints(Button4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ClickEffects()
        FuelBarCondition(lbl5)
        AppendLetter(Button5, lbl5)
        pattackp += PlayerAttackPoints(Button5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ClickEffects()
        FuelBarCondition(lbl6)
        AppendLetter(Button6, lbl6)
        pattackp += PlayerAttackPoints(Button6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ClickEffects()
        FuelBarCondition(lbl7)
        AppendLetter(Button7, lbl7)
        pattackp += PlayerAttackPoints(Button7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ClickEffects()
        FuelBarCondition(lbl8)
        AppendLetter(Button8, lbl8)
        pattackp += PlayerAttackPoints(Button8)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ClickEffects()
        FuelBarCondition(lbl9)
        AppendLetter(Button9, lbl9)
        pattackp += PlayerAttackPoints(Button9)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ClickEffects()
        FuelBarCondition(lbl10)
        AppendLetter(Button10, lbl10)
        pattackp += PlayerAttackPoints(Button10)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ClickEffects()
        FuelBarCondition(lbl11)
        AppendLetter(Button11, lbl11)
        pattackp += PlayerAttackPoints(Button11)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ClickEffects()
        FuelBarCondition(lbl12)
        AppendLetter(Button12, lbl12)
        pattackp += PlayerAttackPoints(Button12)
    End Sub



    Private Sub btnl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl1.Click
        ClickEffects()
        pattackp = 0
        pnpfuel.Width = 0 ' reset fuel to 0
        Btnl1Remove()
        PrivilegeStart2()
    End Sub

    Private Sub btnl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl2.Click
        ClickEffects()
        pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl2)) - Val(PlayerAttackPoints(btnl3)) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg2) * usebomb) - Val(FuelBar(lblg3) * usebomb) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb) 'minus fuel
        'hide btn with the same text and number
        RemoveLetter(Button1, btnl2, lbl1)
        RemoveLetter(Button2, btnl2, lbl2)
        RemoveLetter(Button3, btnl2, lbl3)
        RemoveLetter(Button4, btnl2, lbl4)
        RemoveLetter(Button5, btnl2, lbl5)
        RemoveLetter(Button6, btnl2, lbl6)
        RemoveLetter(Button7, btnl2, lbl7)
        RemoveLetter(Button8, btnl2, lbl8)
        RemoveLetter(Button9, btnl2, lbl9)
        RemoveLetter(Button10, btnl2, lbl10)
        RemoveLetter(Button11, btnl2, lbl11)
        RemoveLetter(Button12, btnl2, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl3, lbl1)
        RemoveLetter(Button2, btnl3, lbl2)
        RemoveLetter(Button3, btnl3, lbl3)
        RemoveLetter(Button4, btnl3, lbl4)
        RemoveLetter(Button5, btnl3, lbl5)
        RemoveLetter(Button6, btnl3, lbl6)
        RemoveLetter(Button7, btnl3, lbl7)
        RemoveLetter(Button8, btnl3, lbl8)
        RemoveLetter(Button9, btnl3, lbl9)
        RemoveLetter(Button10, btnl3, lbl10)
        RemoveLetter(Button11, btnl3, lbl11)
        RemoveLetter(Button12, btnl3, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl4, lbl1)
        RemoveLetter(Button2, btnl4, lbl2)
        RemoveLetter(Button3, btnl4, lbl3)
        RemoveLetter(Button4, btnl4, lbl4)
        RemoveLetter(Button5, btnl4, lbl5)
        RemoveLetter(Button6, btnl4, lbl6)
        RemoveLetter(Button7, btnl4, lbl7)
        RemoveLetter(Button8, btnl4, lbl8)
        RemoveLetter(Button9, btnl4, lbl9)
        RemoveLetter(Button10, btnl4, lbl10)
        RemoveLetter(Button11, btnl4, lbl11)
        RemoveLetter(Button12, btnl4, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl5, lbl1)
        RemoveLetter(Button2, btnl5, lbl2)
        RemoveLetter(Button3, btnl5, lbl3)
        RemoveLetter(Button4, btnl5, lbl4)
        RemoveLetter(Button5, btnl5, lbl5)
        RemoveLetter(Button6, btnl5, lbl6)
        RemoveLetter(Button7, btnl5, lbl7)
        RemoveLetter(Button8, btnl5, lbl8)
        RemoveLetter(Button9, btnl5, lbl9)
        RemoveLetter(Button10, btnl5, lbl10)
        RemoveLetter(Button11, btnl5, lbl11)
        RemoveLetter(Button12, btnl5, lbl12)

        'reset to ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        lblg2.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""

        stopremoveletter = False
        PrivilegeStart2()
    End Sub
    Private Sub btnl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl3.Click
        ClickEffects()
        pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl3)) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg3) * usebomb) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb)
        RemoveLetter(Button1, btnl3, lbl1)
        RemoveLetter(Button2, btnl3, lbl2)
        RemoveLetter(Button3, btnl3, lbl3)
        RemoveLetter(Button4, btnl3, lbl4)
        RemoveLetter(Button5, btnl3, lbl5)
        RemoveLetter(Button6, btnl3, lbl6)
        RemoveLetter(Button7, btnl3, lbl7)
        RemoveLetter(Button8, btnl3, lbl8)
        RemoveLetter(Button9, btnl3, lbl9)
        RemoveLetter(Button10, btnl3, lbl10)
        RemoveLetter(Button11, btnl3, lbl11)
        RemoveLetter(Button12, btnl3, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl4, lbl1)
        RemoveLetter(Button2, btnl4, lbl2)
        RemoveLetter(Button3, btnl4, lbl3)
        RemoveLetter(Button4, btnl4, lbl4)
        RemoveLetter(Button5, btnl4, lbl5)
        RemoveLetter(Button6, btnl4, lbl6)
        RemoveLetter(Button7, btnl4, lbl7)
        RemoveLetter(Button8, btnl4, lbl8)
        RemoveLetter(Button9, btnl4, lbl9)
        RemoveLetter(Button10, btnl4, lbl10)
        RemoveLetter(Button11, btnl4, lbl11)
        RemoveLetter(Button12, btnl4, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl5, lbl1)
        RemoveLetter(Button2, btnl5, lbl2)
        RemoveLetter(Button3, btnl5, lbl3)
        RemoveLetter(Button4, btnl5, lbl4)
        RemoveLetter(Button5, btnl5, lbl5)
        RemoveLetter(Button6, btnl5, lbl6)
        RemoveLetter(Button7, btnl5, lbl7)
        RemoveLetter(Button8, btnl5, lbl8)
        RemoveLetter(Button9, btnl5, lbl9)
        RemoveLetter(Button10, btnl5, lbl10)
        RemoveLetter(Button11, btnl5, lbl11)
        RemoveLetter(Button12, btnl5, lbl12)

        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""

        stopremoveletter = False
        PrivilegeStart2()
    End Sub

    Private Sub btnl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl4.Click
        ClickEffects()
        pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb)
        RemoveLetter(Button1, btnl4, lbl1)
        RemoveLetter(Button2, btnl4, lbl2)
        RemoveLetter(Button3, btnl4, lbl3)
        RemoveLetter(Button4, btnl4, lbl4)
        RemoveLetter(Button5, btnl4, lbl5)
        RemoveLetter(Button6, btnl4, lbl6)
        RemoveLetter(Button7, btnl4, lbl7)
        RemoveLetter(Button8, btnl4, lbl8)
        RemoveLetter(Button9, btnl4, lbl9)
        RemoveLetter(Button10, btnl4, lbl10)
        RemoveLetter(Button11, btnl4, lbl11)
        RemoveLetter(Button12, btnl4, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl5, lbl1)
        RemoveLetter(Button2, btnl5, lbl2)
        RemoveLetter(Button3, btnl5, lbl3)
        RemoveLetter(Button4, btnl5, lbl4)
        RemoveLetter(Button5, btnl5, lbl5)
        RemoveLetter(Button6, btnl5, lbl6)
        RemoveLetter(Button7, btnl5, lbl7)
        RemoveLetter(Button8, btnl5, lbl8)
        RemoveLetter(Button9, btnl5, lbl9)
        RemoveLetter(Button10, btnl5, lbl10)
        RemoveLetter(Button11, btnl5, lbl11)
        RemoveLetter(Button12, btnl5, lbl12)

        btnl4.Text = ""
        btnl5.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""

        stopremoveletter = False
        PrivilegeStart2()
    End Sub


    Private Sub btnl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl5.Click
        ClickEffects()
        pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl5))
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg5) * usebomb)
        RemoveLetter(Button1, btnl5, lbl1)
        RemoveLetter(Button2, btnl5, lbl2)
        RemoveLetter(Button3, btnl5, lbl3)
        RemoveLetter(Button4, btnl5, lbl4)
        RemoveLetter(Button5, btnl5, lbl5)
        RemoveLetter(Button6, btnl5, lbl6)
        RemoveLetter(Button7, btnl5, lbl7)
        RemoveLetter(Button8, btnl5, lbl8)
        RemoveLetter(Button9, btnl5, lbl9)
        RemoveLetter(Button10, btnl5, lbl10)
        RemoveLetter(Button11, btnl5, lbl11)
        RemoveLetter(Button12, btnl5, lbl12)

        btnl5.Text = ""
        lblg5.Text = ""
        PrivilegeStart2()
        stopremoveletter = False
    End Sub

    Public Sub ShuffleWords()
        'error handling
        Try
            SeperateLetter(lblwords.Text)
        Catch
            SeperateLetter(lblNewWord.Text)
        End Try
        ResetButton() ' reset ramble words
        BtnGuessWordVisible(False) 'reset btn guessword
        AssignButtonNumber() 'assign num of letter in btn
        ResetLetterNumberColor(Color.LightGray) 'reset color the num of letter in btn
        LabelVisible(True) 'hide labels
        'clear labels
        lblg1.Text = ""
        lblg2.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""
        pnpfuel.Width = 0 'reset fuel bar to 0

        pattackp = 0
    End Sub
    Private Sub btnshuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshuffle.Click
        ClickEffects()
        ShuffleWords()
        If levelnum >= 3 Then
            DisableLetter()
        End If
        PrivilegeStart2()
    End Sub

    Private Sub Buttonreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonreset.Click
        ClickEffects()
        ResetGame()
    End Sub


    Private Sub btnpause_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpause.Click
        If btnpause.Text = "Pause" Then
            TimerPlayerTurn.Stop()
            btnpause.Text = "Resume"
        Else
            TimerPlayerTurn.Start()
            btnpause.Text = "Pause"
        End If
    End Sub

    Public Sub AssignButtonNumber() 'assigning num in each btn
        lbl1.Text = btnNumber(Button1)
        lbl2.Text = btnNumber(Button2)
        lbl3.Text = btnNumber(Button3)
        lbl4.Text = btnNumber(Button4)
        lbl5.Text = btnNumber(Button5)
        lbl6.Text = btnNumber(Button6)
        lbl7.Text = btnNumber(Button7)
        lbl8.Text = btnNumber(Button8)
        lbl9.Text = btnNumber(Button9)
        lbl10.Text = btnNumber(Button10)
        lbl11.Text = btnNumber(Button11)
        lbl12.Text = btnNumber(Button12)

    End Sub

    Function btnNumber(ByVal btn As Button) As Integer 'function to get the number in each letter
        Dim str As Integer
        If btn.Text = "A" Or btn.Text = "D" Or btn.Text = "E" Or btn.Text = "G" Or btn.Text = "I" Or btn.Text = "L" Or btn.Text = "M" Or btn.Text = "N" Or btn.Text = "O" Or btn.Text = "P" Or btn.Text = "R" Or btn.Text = "S" Or btn.Text = "T" Or btn.Text = "U" Then
            str = 1
        ElseIf btn.Text = "B" Or btn.Text = "C" Or btn.Text = "F" Or btn.Text = "H" Or btn.Text = "J" Or btn.Text = "K" Or btn.Text = "W" Or btn.Text = "Y" Or btn.Text = "V" Then
            str = 3
        ElseIf btn.Text = "Q" Or btn.Text = "X" Or btn.Text = "Z" Then
            str = 5
        End If
        Return str
    End Function
    Dim pattackp As Integer
    Function PlayerAttackPoints(ByVal btn As Button) As Integer 'function to get the number in each letter
        Dim pattack As Integer
        If btn.Text = "A" Or btn.Text = "D" Or btn.Text = "E" Or btn.Text = "G" Or btn.Text = "I" Or btn.Text = "L" Or btn.Text = "M" Or btn.Text = "N" Or btn.Text = "O" Or btn.Text = "P" Or btn.Text = "R" Or btn.Text = "S" Or btn.Text = "T" Or btn.Text = "U" Then
            pattack += 8
        ElseIf btn.Text = "B" Or btn.Text = "C" Or btn.Text = "F" Or btn.Text = "H" Or btn.Text = "J" Or btn.Text = "K" Or btn.Text = "W" Or btn.Text = "Y" Or btn.Text = "V" Then
            pattack += 13
        ElseIf btn.Text = "Q" Or btn.Text = "X" Or btn.Text = "Z" Then
            pattack += 18
        End If
        Return pattack
    End Function

    Public Sub Btnl1Remove()
        RemoveLetter(Button1, btnl1, lbl1)
        RemoveLetter(Button2, btnl1, lbl2)
        RemoveLetter(Button3, btnl1, lbl3)
        RemoveLetter(Button4, btnl1, lbl4)
        RemoveLetter(Button5, btnl1, lbl5)
        RemoveLetter(Button6, btnl1, lbl6)
        RemoveLetter(Button7, btnl1, lbl7)
        RemoveLetter(Button8, btnl1, lbl8)
        RemoveLetter(Button9, btnl1, lbl9)
        RemoveLetter(Button10, btnl1, lbl10)
        RemoveLetter(Button11, btnl1, lbl11)
        RemoveLetter(Button12, btnl1, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl2, lbl1)
        RemoveLetter(Button2, btnl2, lbl2)
        RemoveLetter(Button3, btnl2, lbl3)
        RemoveLetter(Button4, btnl2, lbl4)
        RemoveLetter(Button5, btnl2, lbl5)
        RemoveLetter(Button6, btnl2, lbl6)
        RemoveLetter(Button7, btnl2, lbl7)
        RemoveLetter(Button8, btnl2, lbl8)
        RemoveLetter(Button9, btnl2, lbl9)
        RemoveLetter(Button10, btnl2, lbl10)
        RemoveLetter(Button11, btnl2, lbl11)
        RemoveLetter(Button12, btnl2, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl3, lbl1)
        RemoveLetter(Button2, btnl3, lbl2)
        RemoveLetter(Button3, btnl3, lbl3)
        RemoveLetter(Button4, btnl3, lbl4)
        RemoveLetter(Button5, btnl3, lbl5)
        RemoveLetter(Button6, btnl3, lbl6)
        RemoveLetter(Button7, btnl3, lbl7)
        RemoveLetter(Button8, btnl3, lbl8)
        RemoveLetter(Button9, btnl3, lbl9)
        RemoveLetter(Button10, btnl3, lbl10)
        RemoveLetter(Button11, btnl3, lbl11)
        RemoveLetter(Button12, btnl3, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl4, lbl1)
        RemoveLetter(Button2, btnl4, lbl2)
        RemoveLetter(Button3, btnl4, lbl3)
        RemoveLetter(Button4, btnl4, lbl4)
        RemoveLetter(Button5, btnl4, lbl5)
        RemoveLetter(Button6, btnl4, lbl6)
        RemoveLetter(Button7, btnl4, lbl7)
        RemoveLetter(Button8, btnl4, lbl8)
        RemoveLetter(Button9, btnl4, lbl9)
        RemoveLetter(Button10, btnl4, lbl10)
        RemoveLetter(Button11, btnl4, lbl11)
        RemoveLetter(Button12, btnl4, lbl12)

        stopremoveletter = False
        RemoveLetter(Button1, btnl5, lbl1)
        RemoveLetter(Button2, btnl5, lbl2)
        RemoveLetter(Button3, btnl5, lbl3)
        RemoveLetter(Button4, btnl5, lbl4)
        RemoveLetter(Button5, btnl5, lbl5)
        RemoveLetter(Button6, btnl5, lbl6)
        RemoveLetter(Button7, btnl5, lbl7)
        RemoveLetter(Button8, btnl5, lbl8)
        RemoveLetter(Button9, btnl5, lbl9)
        RemoveLetter(Button10, btnl5, lbl10)
        RemoveLetter(Button11, btnl5, lbl11)
        RemoveLetter(Button12, btnl5, lbl12)


        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        lblg1.Text = ""
        lblg2.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""
        stopremoveletter = False
    End Sub

#End Region

#Region "Methods and Stuffs"
    Public Sub LoadPlayerInfo()
        lblstage.Text = "Stage " & GetInfo("studstage")
        lbllvl.Text = "Level " & GetInfo("studlevel")
        lblscore.Text = "Score " & GetInfo("studscore")
        lblhintnum.Text = GetInfo("studhint")
        lbltnum.Text = GetInfo("studta")
        lblpokenum.Text = GetInfo("studpokenum")
        lblpname.Text = pname.ToUpper

    End Sub

    Function ComputeScore() As Integer
        ' MsgBox(ComputeMovePoints())
        Dim score As Integer = 0
        score = (Val(lblg1.Text) + Val(lblg2.Text) + Val(lblg3.Text) + Val(lblg4.Text) + Val(lblg5.Text)) * usebomb
        Return score
    End Function

    Dim levelnum As Integer = 1
    Dim cfuel As Integer 'initial enemy fuel
    Dim usebomb As Integer = 1
    Dim ctrwrong As Integer = 0

    Dim stopremoveletter As Boolean = False
    Public Sub RemoveLetter(ByVal btn As Button, ByVal btnlx As Button, ByVal lbl As Label) 'method to hide the btn and label
        If stopremoveletter = True Then
            Exit Sub
        End If
        If btn.Visible = False And btnlx.Text = btn.Text And btnlx.BackColor = btn.BackColor Then
            btn.Visible = True
            btn.BackColor = Color.LightGray
            lbl.BackColor = Color.LightGray
            lbl.Visible = True
            btnlx.Visible = False

            stopremoveletter = True
        Else
            btnlx.Visible = False
        End If
    End Sub

    Public Sub EnterPName()

    End Sub
    Dim w1, w2, w3 As String
    Function GenerateWords() As String 'get 3 words from list and combine
        Dim word1 As String = ""
        Dim word2 As String = ""
        Dim word3 As String = ""

        kit.ChooseWord(lblwords, 5, chinawords)
        word1 = lblwords.Text
        ListBox1.Items.Add(word1)

        kit.ChooseWord(lblwords, 4, chinawords)
        word2 = lblwords.Text
        ListBox1.Items.Add(word2)

        kit.ChooseWord(lblwords, 3, chinawords)
        word3 = lblwords.Text
        ListBox1.Items.Add(word3)

        w1 = ListBox1.Items.Item(0)
        w2 = ListBox1.Items.Item(1)
        w3 = ListBox1.Items.Item(2)
        lblwords.Text = word1 & word2 & word3
        TextBox1.Text = word1 & "+" & word2 & "+" & word3
        Return lblwords.Text
    End Function

    Public Sub SeperateLetter(ByVal str As String) 'seperate and ramble letters in button
        rambleletters = kit.ScrambleWord(str.ToUpper)
        Dim value As String = rambleletters
        Dim str1 As Char = value(0)
        Dim str2 As Char = value(1)
        Dim str3 As Char = value(2)
        Dim str4 As Char = value(3)
        Dim str5 As Char = value(4)
        Dim str6 As Char = value(5)
        Dim str7 As Char = value(6)
        Dim str8 As Char = value(7)
        Dim str9 As Char = value(8)
        Dim str10 As Char = value(9)
        Dim str11 As Char = value(10)
        Dim str12 As Char = value(11)

        Button1.Text = str1
        Button2.Text = str2
        Button3.Text = str3
        Button4.Text = str4
        Button5.Text = str5
        Button6.Text = str6
        Button7.Text = str7
        Button8.Text = str8
        Button9.Text = str9
        Button10.Text = str10
        Button11.Text = str11
        Button12.Text = str12

    End Sub



    Public Sub AppendLetter(ByVal btn As Button, ByVal lbl As Label) 'method to append the letter
        If btnl1.Text = "" Then
            btnl1.Text = btn.Text
            lblg1.Text = lbl.Text
            btnl1.Visible = True
            lblg1.Visible = True
            btnl1.BackColor = btn.BackColor
            lblg1.BackColor = btn.BackColor
        ElseIf btnl2.Text = "" Then
            btnl2.Text = btn.Text
            lblg2.Text = lbl.Text
            btnl2.Visible = True
            lblg2.Visible = True
            btnl2.BackColor = btn.BackColor
            lblg2.BackColor = btn.BackColor
        ElseIf btnl3.Text = "" Then
            btnl3.Text = btn.Text
            lblg3.Text = lbl.Text
            btnl3.Visible = True
            lblg3.Visible = True
            btnl3.BackColor = btn.BackColor
            lblg3.BackColor = btn.BackColor
        ElseIf btnl4.Text = "" Then
            btnl4.Text = btn.Text
            lblg4.Text = lbl.Text
            btnl4.Visible = True
            lblg4.Visible = True
            btnl4.BackColor = btn.BackColor
            lblg4.BackColor = btn.BackColor
        ElseIf btnl5.Text = "" Then
            btnl5.Text = btn.Text
            lblg5.Text = lbl.Text
            btnl5.Visible = True
            lblg5.Visible = True
            btnl5.BackColor = btn.BackColor
            lblg5.BackColor = btn.BackColor
        Else
            Exit Sub
            btnGuess.Enabled = False
        End If
        lbl.Visible = False
        btn.Visible = False
        ' pnpfuel.BackColor = Color.Yellow
        btnGuess.Focus()
    End Sub
    Dim strword As String
    Public Sub RemoveWord(ByVal _str As String) 'delete word that guessed
        Dim str As New List(Of String)
        str = TextBox1.Text.Split("+").ToList
        str.Remove(_str)
        For i = 0 To str.Count - 1
            If i < str.Count - 1 Then
                TextBox1.Text = ""
                TextBox1.Text &= str(i) & "+"
                strword &= str(i)
            Else
                TextBox1.Text &= str(i)
                strword &= str(i)
            End If
        Next
    End Sub

    Function wordtouse(ByVal i As Integer) As String
        Dim j As String
        If w1.Length = i Then
            j = w1
        End If
        If w2.Length = i Then
            j = w2
        End If
        If w3.Length = i Then
            j = w3
        End If
        Return j
    End Function




    Public Sub ReplaceWordComputerAnswer(ByVal i As Integer) 'add word after delete one
        Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text
        Dim wordreplace As String
        strword = ""
        RemoveWord(str.ToLower)

        kit.ChooseWord(lblNewWord, i, chinawords)
        wordreplace = lblNewWord.Text
        lblwords.Text = strword & wordreplace
        TextBox1.Text = TextBox1.Text & "+" & wordreplace
        ListBox1.Items.Remove(str.ToLower)
        ListBox1.Items.Add(wordreplace)
        'ListBox1.GetItemText()
        ' MsgBox(lblwords.Text)
        SeperateLetter(lblwords.Text)
        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        ResetButton()
        w1 = ListBox1.Items.Item(0)
        w2 = ListBox1.Items.Item(1)
        w3 = ListBox1.Items.Item(2)
    End Sub
    Public Sub RambleWords() 'add word after delete one

        ListBox1.Items.Clear()

        SeperateLetter(lblwords.Text)
        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        ResetButton()
    End Sub

    Public Sub ReplaceWord() 'add word after delete one
   
        ListBox1.Items.Clear()

        SeperateLetter(GenerateWords)
        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        ResetButton()
    End Sub
    Dim cor As Integer
    Dim ix As Integer
    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text
        If str.Length < 5 Then '3-5 char only
            Exit Sub
        End If
        EnabledButton(False)
        If ListBox2.Items.Contains(str.ToLower) Then
            pmovectr += ComputeMovePoints() * usebomb 'distance reach
            ix = ComputeMovePoints() * usebomb
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            TimerPlayerTurn.Stop()
            pnguessword.BackColor = Color.MediumSeaGreen
            If (ix > 49 And ix < 101) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Good!", 3000)
            ElseIf (ix > 101 And ix < 201) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Nice!", 3000)
            ElseIf (ix > 201 And ix < 1000) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Excellent!", 3000)
            End If
            TimerBallMoveCorrect.Start()
            cor += 1
            If cor = 2 And tutorial = False Then

            End If
        Else
            BuzzEffects()
            pnguessword.BackColor = Color.PaleVioletRed
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Missed!", 4000)
            TimerBallMoveWrong.Start()
            TimerCompTurn.Start()
            TimerPlayerTurn.Stop()
            pnpfuel.Width = 0
            pattackp = 0
        End If

    End Sub

    Public Sub LabelVisible(ByVal bool As Boolean)
        lbl1.Visible = bool
        lbl2.Visible = bool
        lbl3.Visible = bool
        lbl4.Visible = bool
        lbl5.Visible = bool
        lbl6.Visible = bool
        lbl7.Visible = bool
        lbl8.Visible = bool
        lbl9.Visible = bool
        lbl10.Visible = bool
        lbl11.Visible = bool
        lbl12.Visible = bool

    End Sub

    Function ComputeMovePoints() As Integer 'sum all letter to be use
        Dim sum As Integer
        Dim res As Integer
        sum = Val(lblg1.Text) + Val(lblg2.Text) + Val(lblg3.Text) + Val(lblg4.Text) + Val(lblg5.Text)

        If sum = 3 Then '11100
            res = 50
        ElseIf sum = 4 Then '11100
            res = 75
        ElseIf sum = 5 Then ' 11111
            res = 100
        ElseIf sum = 6 Then
            res = 125
        ElseIf sum = 7 Then '11113
            res = 150
        ElseIf sum = 8 Then
            res = 175
        ElseIf sum = 9 Then '11133
            res = 200
        ElseIf sum = 10 Then
            res = 225
        ElseIf sum = 11 Then '11333
            res = 250
        ElseIf sum = 12 Then
            res = 275
        ElseIf sum = 13 Then '13333
            res = 300
        ElseIf sum = 14 Then
            res = 325
        ElseIf sum = 15 Then '33333
            res = 350
        ElseIf sum = 16 Then
            res = 375
        ElseIf sum = 17 Then '33335
            res = 400
        ElseIf sum = 18 Then
            res = 425
        ElseIf sum = 19 Then '33355
            res = 450
        ElseIf res = 20 Then
            res = 475
        ElseIf sum = 21 Then '33555
            res = 500
        ElseIf sum = 22 Then
            res = 525
        ElseIf sum = 23 Then '35555
            res = 550
        ElseIf sum = 575 Then
            res = 575
        ElseIf sum = 25 Then '55555
            res = 600
        ElseIf sum = 26 Then
            res = 625
        End If

        Return res
    End Function

    Function FuelBar(ByVal lbl As Label) As Integer 'assigning distance of letter use
        Dim f As Integer
        If lbl.Text = "1" Then
            f = 20
        ElseIf lbl.Text = "3" Then
            f = 65
        ElseIf lbl.Text = "5" Then
            f = 115
        Else
            f = 0
        End If
        Return f
    End Function

    Public Sub EnabledButton(ByVal bool As Boolean)
        pnguessword.Enabled = bool
        pnrambleletter.Enabled = bool
        btnGuess.Enabled = bool
        btnshuffle.Enabled = bool
        Button1.Enabled = bool
        Button2.Enabled = bool
        Button3.Enabled = bool
        Button4.Enabled = bool
        Button5.Enabled = bool
        Button6.Enabled = bool
        Button7.Enabled = bool
        Button8.Enabled = bool
        Button9.Enabled = bool
        Button10.Enabled = bool
        Button11.Enabled = bool
        Button12.Enabled = bool
        lbl1.Enabled = bool
        lbl2.Enabled = bool
        lbl3.Enabled = bool
        lbl4.Enabled = bool
        lbl5.Enabled = bool
        lbl6.Enabled = bool
        lbl7.Enabled = bool
        lbl8.Enabled = bool
        lbl9.Enabled = bool
        lbl10.Enabled = bool
        lbl11.Enabled = bool
        lbl12.Enabled = bool
    End Sub

    Function ComputerAnswer() As String
        Dim j As String = ""
        If levelnum = 1 Then
            '  j = wordtouse(3)
            j = wordtouse(5)
        ElseIf levelnum = 2 Then
            '    j = wordtouse(4)
            j = wordtouse(5)
        ElseIf levelnum = 3 Then
            j = wordtouse(5)
        End If
        Return j
    End Function

    Public Sub ComputerTurn(ByVal str As String) 'computer will answer
        lblCompAns.Text = str 'computer will answer with first the list in the item
        ResetButton()
        'assigning the btn
        Dim value As String = lblCompAns.Text.ToUpper
        Dim str1 As Char = value(0)
        Dim str2 As Char = value(1)
        Dim str3 As Char = value(2)
        btnl1.Text = str1
        btnl2.Text = str2
        btnl3.Text = str3
        lblg1.Text = btnNumber(btnl1)
        lblg2.Text = btnNumber(btnl2)
        lblg3.Text = btnNumber(btnl3)
        btnl4.Visible = False
        btnl5.Visible = False
        lblg4.Visible = False
        lblg5.Visible = False
        'If levelnum = 2 Then
        Dim str4 As Char = value(3)
        btnl4.Text = str4
        lblg4.Text = btnNumber(btnl4)
        btnl4.Visible = True
        lblg4.Visible = True
        'End If
        'If levelnum = 3 Then
        '  Dim str4 As Char = value(3)
        btnl4.Text = str4
        lblg4.Text = btnNumber(btnl4)
        btnl4.Visible = True
        lblg4.Visible = True
        Dim str5 As Char = value(4)
        btnl5.Text = str5
        lblg5.Text = btnNumber(btnl5)
        btnl5.Visible = True
        lblg5.Visible = True
        ' End If
        pnpfuel.Width = cfuel
        'FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text.ToUpper & " Answer: " & lblCompAns.Text.ToUpper & "", 4000)
    End Sub

    Dim strshuffle As String
    Private Sub TimerThinking_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerThinking.Tick
        strshuffle = kit.ScrambleWord(ComputerAnswer())
        ComputerTurn(strshuffle)
    End Sub

    Public Sub ResetLetterNumberColor(ByVal clr As Color) 'reset the color of number in btn
        lbl1.BackColor = clr
        lbl2.BackColor = clr
        lbl3.BackColor = clr
        lbl4.BackColor = clr
        lbl5.BackColor = clr
        lbl6.BackColor = clr
        lbl7.BackColor = clr
        lbl8.BackColor = clr
        lbl9.BackColor = clr
        lbl10.BackColor = clr
        lbl11.BackColor = clr
        lbl12.BackColor = clr

    End Sub

    Public Sub ResetButton() 'reset the color and hide the btn
        Button1.BackColor = Color.LightGray
        Button2.BackColor = Color.LightGray
        Button3.BackColor = Color.LightGray
        Button4.BackColor = Color.LightGray
        Button5.BackColor = Color.LightGray
        Button6.BackColor = Color.LightGray
        Button7.BackColor = Color.LightGray
        Button8.BackColor = Color.LightGray
        Button9.BackColor = Color.LightGray
        Button10.BackColor = Color.LightGray
        Button11.BackColor = Color.LightGray
        Button12.BackColor = Color.LightGray

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button12.Visible = True

        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
    End Sub

    Public Sub ResetGame()
        ListBox1.Items.Clear()
        SeperateLetter(GenerateWords())
        ResetButton()

        pmovectr = 0
        cmovectr = 0
        ctr = 0
        EnabledButton(True)
        TimerPlayerTurn.Stop()
        TimerCompMove.Stop()
        ResetTime()
        AssignButtonNumber()
        ResetLetterNumberColor(Color.LightGray)
        pnpfuel.Width = 0
        pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
    

        lblg1.Text = ""
        lblg2.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""

    End Sub

    Public Sub ResetTime()
        pctr = 30 'reset time
        lbltime.Text = 30
    End Sub

    Public Sub BtnGuessWordVisible(ByVal bool As Boolean) 'hide the guess btn
        btnl1.Visible = bool
        btnl2.Visible = bool
        btnl3.Visible = bool
        btnl4.Visible = bool
        btnl5.Visible = bool
        lblg1.Visible = bool
        lblg2.Visible = bool
        lblg3.Visible = bool
        lblg4.Visible = bool
        lblg5.Visible = bool
    End Sub

    Public Sub BtnGuessWordColor(ByVal col As Color) 'color the guess btn
        btnl1.BackColor = col
        btnl2.BackColor = col
        btnl3.BackColor = col
        btnl4.BackColor = col
        btnl5.BackColor = col
        lblg1.BackColor = col
        lblg2.BackColor = col
        lblg3.BackColor = col
        lblg4.BackColor = col
        lblg5.BackColor = col
    End Sub

    Public Sub EnemyChange(ByVal col As Color, ByVal str As String, ByVal strx As String) '
        pnpfuel.BackColor = col
        lblpokemon.Text = str
    End Sub

    Dim cattack As Integer

    Public Sub colortext(ByVal col As Color)
        lbltl.BackColor = col
        lbltime.BackColor = col
        lblx.BackColor = col
        lblpokenum.BackColor = col
        'pngs.BackColor = col
        'pnrambleletter.BackColor = col
        'pnPrivileges.BackColor = col
        ' pnname.BackColor = col
        ' pnavatar.BackColor = col
        ' p1.BackColor = col
        ' p2.BackColor = col
        'p3.BackColor = col
        'p4.BackColor = col
        'p5.BackColor = col
    End Sub


    Dim bl As Boolean = False
    

    Public Sub FuelColor(ByVal i As Integer)
        If i = 1 Then

            EnemyChange(enemybluecolor, enemybluename, enemybluedetail)
            cfuel = 100
            cattack = 30
        ElseIf i = 2 Then

            cfuel = 150
            EnemyChange(enemyvioletcolor, enemyvioletname, enemyvioletdetail)
            cattack = 40
            bl = True
        ElseIf i = 3 Then

            cfuel = 200
            EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
            cattack = 45


        End If
    End Sub

#End Region

#Region "Timers"

    Dim pctr As Integer = 30
    Dim ctr As Integer
 
    Dim cr As Integer = 5
    Function getspeed() As Integer
        Dim i As Integer
        If levelnum = 1 Then
            i = 5
        ElseIf levelnum = 2 Then
            i = 6
        ElseIf levelnum = 3 Then
            i = 7
        End If
        Return i
    End Function
    Private Sub TimerPlayerTurn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerTurn.Tick
        pctr -= 1
        lbltime.Text = pctr
        ' lblrword.Top += getspeed()
        '   If pctr = 27 Then
        'If tutorial = True And levelnum = 1 Then
        'TimerPlayerTurn.Stop()
        '  ShowTutorialMessageBox(vbNewLine & vbNewLine & "Click or type the letters in ramble letters that you found in sentence", Me, Color.WhiteSmoke)
        '  TimerPlayerTurn.Start()
        '  ElseIf tutorial = True And levelnum = 2 Then
        '  TimerPlayerTurn.Stop()
        ''  ShowTutorialMessageBox(vbNewLine & vbNewLine & "Click or type the letter that picture shows", Me, Color.WhiteSmoke)
        '  TimerPlayerTurn.Start()
        ' End If
        ' End If
        If pctr = 22 Then
            If tutorial = True And levelnum = 1 Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = False
                TimerPlayerTurn.Stop()
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Now Click or Type the term " & wordtouse(5).ToUpper & " in the ramble letters! Then Click Catch", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
            ElseIf tutorial = True And levelnum = 2 Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TimerPlayerTurn.Stop()
                TutMes.pnpoke.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Now Click or Type the term " & wordtouse(5).ToUpper & " that shows the picture! Then Click Catch", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
            End If
        End If
        If pctr = 10 Then
            If pbtt = True Then
                TimerPlayerTurn.Stop()
                TutMes.btnTime.Visible = True
                TutMes.btnhint.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Warning! Your thinking time is about to reach 0, you can use privilege Time Adder to add thinking time by 10 seconds", Me, Color.WhiteSmoke, False)

                TimerPlayerTurn.Start()
                pbtt = False
            End If
        End If
  
        If pctr = 0 Then 'when timer reach
            ' If lblrword.Top >= Panel1.Height - 30 Then
            BuzzEffects()
            If pbt = True Then
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = True
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "You have given 30 seconds to submit your answer. " & vbNewLine & "If thinking time reached to 0 your pocket ball will deducted by 1 and color tiles will appear", Me, Color.WhiteSmoke, False)

                TimerPlayerTurn.Start()
                pbt = False
            End If
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Times up!-1 Pokeball.", 5000)
            ResetTime()
            'lblrword.Top = 15

            If pbn = True Then
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = True
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "You can use privilege Hint to show the first character of the term.", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
                pbn = False
            End If

            If PokeballAvailable() = False Then
                ExplosionEffects()
                BGMStop()
                TimerPlayerTurn.Stop()
                ResetGame()
                TimerHotkey.Stop()
                TimerHotkeyBack.Stop()
                kit.Forward(pnpokemon, pnpokemon.Location.X, (pnarea.Width - pnpokemon.Width) - 1000)
                ShowMessageBox("You Lost!", Me, Color.WhiteSmoke)
                ShowChooseMessageBox(Me, Color.WhiteSmoke)
                If bly = False Then
                    Me.Close()
                    Exit Sub
                End If
                LoadPlayerInfo()
                ConditionForLevel(levelnum)
                kit.Back()
                TimerPlayerTurn.Start()
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
                stopgetprivi = True
                ctrw = 0 'reset
                ctrr = 0 'reset
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
                ResetTime()
                pnphbar.Width = 234
                lblpokenum.Text = 5
                'lblrword.Top = 15
                pnphbar.BackColor = Color.MediumSeaGreen
            End If
            If levelnum >= 3 Then
                DisableLetter()
            End If
            PrivilegeStart2()
        End If
    End Sub
    Dim scoresum As Integer = GetInfo("studscore")
    Dim pmovectr As Integer

    Dim cmovectr As Integer


#End Region





#Region "HotKey"
    Dim key As Integer
    Dim hotkeybackspace As Boolean
    Dim hotkeyshuffle As Boolean
    Dim hkstr As String
    Dim stopremoveletterhk As Boolean = False

    Private Sub TimerHotkeyBack_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHotkeyBack.Tick
        hotkeybackspace = GetAsyncKeyState(Keys.Back)
        hotkeyshuffle = GetAsyncKeyState(Keys.ShiftKey)
        If hotkeybackspace = True Then
            HotKeyBack()
        End If
        If hotkeyshuffle = True Then
            ShuffleWords()
            If levelnum >= 3 Then
                DisableLetter()
            End If
            PrivilegeStart2()
        End If
    End Sub

    Private Sub TimerHotkey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHotkey.Tick
        For i = 1 To 255
            key = 0
            key = GetAsyncKeyState(i)

            If key = -32767 Then

                Dim value As String = lblwords.Text.ToUpper
                Dim str1 As Char = value(0)
                Dim str2 As Char = value(1)
                Dim str3 As Char = value(2)
                Dim str4 As Char = value(3)
                Dim str5 As Char = value(4)
                Dim str6 As Char = value(5)
                Dim str7 As Char = value(6)
                Dim str8 As Char = value(7)
                Dim str9 As Char = value(8)
                Dim str10 As Char = value(9)
                Dim str11 As Char = value(10)
                Dim str12 As Char = value(11)

                If Chr(i).ToString.Contains(str1) Or Chr(i).ToString.Contains(str2) Or Chr(i).ToString.Contains(str3) Or Chr(i).ToString.Contains(str4) _
                   Or Chr(i).ToString.Contains(str5) Or Chr(i).ToString.Contains(str6) Or Chr(i).ToString.Contains(str7) Or Chr(i).ToString.Contains(str8) _
                   Or Chr(i).ToString.Contains(str9) Or Chr(i).ToString.Contains(str10) Or Chr(i).ToString.Contains(str11) Or Chr(i).ToString.Contains(str12) Then
                    hkstr = Chr(i)

                    RemoveLetterHK(Button1, lbl1)
                    RemoveLetterHK(Button2, lbl2)
                    RemoveLetterHK(Button3, lbl3)
                    RemoveLetterHK(Button4, lbl4)
                    RemoveLetterHK(Button5, lbl5)
                    RemoveLetterHK(Button6, lbl6)
                    RemoveLetterHK(Button7, lbl7)
                    RemoveLetterHK(Button8, lbl8)
                    RemoveLetterHK(Button9, lbl9)
                    RemoveLetterHK(Button10, lbl10)
                    RemoveLetterHK(Button11, lbl11)
                    RemoveLetterHK(Button12, lbl12)

                    stopremoveletterhk = False

                End If
                If levelnum >= 3 Then
                    DisableLetter()
                End If

                    PrivilegeStart2()

                End If
        Next i
    End Sub

    Public Sub RemoveLetterHK(ByVal btn As Button, ByVal lbl As Label) 'method to hide the btn and label
        If stopremoveletterhk = True Then
            Exit Sub
        End If
        If hkstr.ToUpper = btn.Text And btn.Visible = True Then
            If btn.Enabled = False Then 'disable
                Exit Sub
            End If

            lbl.Visible = False
            btn.Visible = False
            stopremoveletterhk = True
            AppendLetter(btn, lbl)
            FuelBarCondition(lbl)
            pattackp += PlayerAttackPoints(btn)
        End If
    End Sub

    Public Sub AppendLetterHK(ByVal btn As Button, ByVal lbl As Label) 'method to append the letter
        If btnl1.Text = "" Then
            btnl1.Text = hkstr.ToUpper
            lblg1.Text = lbl.Text
            btnl1.Visible = True
            lblg1.Visible = True
            btnl1.BackColor = btn.BackColor
            lblg1.BackColor = btn.BackColor
        ElseIf btnl2.Text = "" Then
            btnl2.Text = hkstr.ToUpper
            lblg2.Text = lbl.Text
            btnl2.Visible = True
            lblg2.Visible = True
            btnl2.BackColor = btn.BackColor
            lblg2.BackColor = btn.BackColor
        ElseIf btnl3.Text = "" Then
            btnl3.Text = hkstr.ToUpper
            lblg3.Text = lbl.Text
            btnl3.Visible = True
            lblg3.Visible = True
            btnl3.BackColor = btn.BackColor
            lblg3.BackColor = btn.BackColor
        ElseIf btnl4.Text = "" Then
            btnl4.Text = hkstr.ToUpper
            lblg4.Text = lbl.Text
            btnl4.Visible = True
            lblg4.Visible = True
            btnl4.BackColor = btn.BackColor
            lblg4.BackColor = btn.BackColor
        ElseIf btnl5.Text = "" Then
            btnl5.Text = hkstr.ToUpper
            lblg5.Text = lbl.Text
            btnl5.Visible = True
            lblg5.Visible = True
            btnl5.BackColor = btn.BackColor
            lblg5.BackColor = btn.BackColor
        Else
            Exit Sub
            btnGuess.Enabled = False
        End If
        lbl.Visible = False
        btn.Visible = False
        pnpfuel.BackColor = Color.Yellow
        btnGuess.Focus()
    End Sub

    Public Sub HotKeyBack()
        stopremoveletter = False

        If btnl1.Text <> "" And btnl2.Text = "" And btnl3.Text = "" And btnl4.Text = "" And btnl5.Text = "" Then
            pattackp = 0
            pnpfuel.Width = 0
            RemoveLetter(Button1, btnl1, lbl1)
            RemoveLetter(Button2, btnl1, lbl2)
            RemoveLetter(Button3, btnl1, lbl3)
            RemoveLetter(Button4, btnl1, lbl4)
            RemoveLetter(Button5, btnl1, lbl5)
            RemoveLetter(Button6, btnl1, lbl6)
            RemoveLetter(Button7, btnl1, lbl7)
            RemoveLetter(Button8, btnl1, lbl8)
            RemoveLetter(Button9, btnl1, lbl9)
            RemoveLetter(Button10, btnl1, lbl10)
            RemoveLetter(Button11, btnl1, lbl11)
            RemoveLetter(Button12, btnl1, lbl12)
            stopremoveletter = False
            btnl1.Text = ""
            lblg1.Text = ""

            Exit Sub
        End If
        If btnl2.Text <> "" And btnl3.Text = "" And btnl4.Text = "" And btnl5.Text = "" Then
            pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl2)) - Val(PlayerAttackPoints(btnl3)) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg2) * usebomb) - Val(FuelBar(lblg3) * usebomb) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb) 'minus fuel
            RemoveLetter(Button1, btnl2, lbl1)
            RemoveLetter(Button2, btnl2, lbl2)
            RemoveLetter(Button3, btnl2, lbl3)
            RemoveLetter(Button4, btnl2, lbl4)
            RemoveLetter(Button5, btnl2, lbl5)
            RemoveLetter(Button6, btnl2, lbl6)
            RemoveLetter(Button7, btnl2, lbl7)
            RemoveLetter(Button8, btnl2, lbl8)
            RemoveLetter(Button9, btnl2, lbl9)
            RemoveLetter(Button10, btnl2, lbl10)
            RemoveLetter(Button11, btnl2, lbl11)
            RemoveLetter(Button12, btnl2, lbl12)
            stopremoveletter = False
            btnl2.Text = ""
            lblg2.Text = ""

            Exit Sub
        End If
        If btnl3.Text <> "" And btnl4.Text = "" And btnl5.Text = "" Then
            pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl3)) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg3) * usebomb) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb)
            RemoveLetter(Button1, btnl3, lbl1)
            RemoveLetter(Button2, btnl3, lbl2)
            RemoveLetter(Button3, btnl3, lbl3)
            RemoveLetter(Button4, btnl3, lbl4)
            RemoveLetter(Button5, btnl3, lbl5)
            RemoveLetter(Button6, btnl3, lbl6)
            RemoveLetter(Button7, btnl3, lbl7)
            RemoveLetter(Button8, btnl3, lbl8)
            RemoveLetter(Button9, btnl3, lbl9)
            RemoveLetter(Button10, btnl3, lbl10)
            RemoveLetter(Button11, btnl3, lbl11)
            RemoveLetter(Button12, btnl3, lbl12)
            stopremoveletter = False
            btnl3.Text = ""
            lblg3.Text = ""

            Exit Sub
        End If
        If btnl4.Text <> "" And btnl5.Text = "" Then
            pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl4)) - Val(PlayerAttackPoints(btnl5))
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg4) * usebomb) - Val(FuelBar(lblg5) * usebomb)
            RemoveLetter(Button1, btnl4, lbl1)
            RemoveLetter(Button2, btnl4, lbl2)
            RemoveLetter(Button3, btnl4, lbl3)
            RemoveLetter(Button4, btnl4, lbl4)
            RemoveLetter(Button5, btnl4, lbl5)
            RemoveLetter(Button6, btnl4, lbl6)
            RemoveLetter(Button7, btnl4, lbl7)
            RemoveLetter(Button8, btnl4, lbl8)
            RemoveLetter(Button9, btnl4, lbl9)
            RemoveLetter(Button10, btnl4, lbl10)
            RemoveLetter(Button11, btnl4, lbl11)
            RemoveLetter(Button12, btnl4, lbl12)
            stopremoveletter = False
            btnl4.Text = ""
            lblg4.Text = ""

            Exit Sub
        End If
        If btnl5.Text <> "" Then
            pattackp = Val(pattackp) - Val(PlayerAttackPoints(btnl5))
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg5) * usebomb)
            RemoveLetter(Button1, btnl5, lbl1)
            RemoveLetter(Button2, btnl5, lbl2)
            RemoveLetter(Button3, btnl5, lbl3)
            RemoveLetter(Button4, btnl5, lbl4)
            RemoveLetter(Button5, btnl5, lbl5)
            RemoveLetter(Button6, btnl5, lbl6)
            RemoveLetter(Button7, btnl5, lbl7)
            RemoveLetter(Button8, btnl5, lbl8)
            RemoveLetter(Button9, btnl5, lbl9)
            RemoveLetter(Button10, btnl5, lbl10)
            RemoveLetter(Button11, btnl5, lbl11)
            RemoveLetter(Button12, btnl5, lbl12)
            stopremoveletter = False
            btnl5.Text = ""
            lblg5.Text = ""

            Exit Sub
        End If
    End Sub

#End Region


    Dim ctrsgame As Integer


    Private Sub TimerPause_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPause.Tick
        TimerPlayerTurn.Stop()
        TimerCompTurn.Stop()
    End Sub





    Dim sideleft As Integer = 2
    Dim sideright As Integer = -2
    Dim cntr As Integer = 0
    Dim pokeballspeed As Integer = 7
    Sub ResetBallLocation()
        pnball.Top = 548
        pnball.Left = 210
    End Sub
    Private Sub TimerBallMoveCorrect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBallMoveCorrect.Tick
        pnball.Top -= pokeballspeed
        pnball.Left -= cntr
        pnpfuel.Width -= 3
        If pnball.Top <= 90 Then
            HitEffects()
            kit.Shake(pnpokemon, 10, 2, 1)
            TimerBallMoveCorrect.Stop()
            If pnphbar.Width <= 150 Then
                pnphbar.BackColor = Color.LightCoral
            Else
                pnphbar.BackColor = Color.MediumSeaGreen
            End If

            If levelnum = 3 Then
                usebomb = 1
            Else
                usebomb = 1
            End If

            If tutorial = True Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False

                TimerPlayerTurn.Stop()
                ShowTutorialMessageBox(vbNewLine & "WELL DONE!" & vbNewLine & "Keep on playing! Until the battlemon life runs out and capture the battlemon", Me, Color.WhiteSmoke, False)
                TutMes.pnpoke.Visible = True
                ShowTutorialMessageBox(vbNewLine & "You have given 30 seconds to submit your answer. " & vbNewLine & "If the thinking time reached to 0 or you missed the term, the pocketball will deducted by 1." & vbNewLine & "If the pocket ball reached to 0 the game will be over.", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
                tutorial = False
            End If

            If PokemonLifeIsZero() = True Then
                ExplosionEffects()
                BGMStop()
                TimerPlayerTurn.Stop()
                ResetGame()
                TimerHotkey.Stop()
                TimerHotkeyBack.Stop()
                levelnum += 1
                TimerPlayerTurn.Stop()
                pnball.Visible = False
                pnpokemon.BackgroundImage = My.Resources.ballx
                tbphrase.Text = ""
                ShowMessageBox("Gotcha! " & lblpokemon.Text & " was caught.", Me, Color.WhiteSmoke)
                kit.Forward(pnpokemon, pnpokemon.Location.X, (pnarea.Width - pnpokemon.Width) + 360)
                UpdateInfo("studlevel", levelnum)
                UpdateInfo("studstage", 1)
                UpdateInfo("studscore", scoresum)
                UpdateInfo("studpokenum", Val(lblpokenum.Text))
                UpdateInfo("studhint", lblhintnum.Text)
                UpdateInfo("studta", lbltnum.Text)
                LoadPlayerInfo()
                lbllvl.Text = "Level " & levelnum
                ResetBallLocation()
                ShowMessageBox("Saved.", Me, Color.WhiteSmoke)
                pnball.Visible = True
                ConditionForLevel(levelnum)
                If bl = True Then
                    Exit Sub
                End If
                pnball.Visible = True
                kit.Back()
                pnphbar.Width = 234
                pnphbar.BackColor = Color.MediumSeaGreen
                ctrw = 0
                ctrr = 0
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
            End If
            ReplaceWord() ' add another word
            ResetLetterNumberColor(Color.LightGray) 'color of btn number
            AssignButtonNumber() 'assigning number in btn 
            BtnGuessWordVisible(False)
            LabelVisible(True) 'hide labels
            pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
            ResetBallLocation()
            EnabledButton(True)
            pnpfuel.Width = 0


            ResetTime()
            TimerPlayerTurn.Start()

            If ctrw >= 1 Then
                ctrw = 0
            End If

            ctrr += 1

            If levelnum >= 3 Then
                DisableLetter()
            End If

            ' PrivilegeStart2()

            AddPrivi()

            scoresum += ComputeScore()
            lblscore.Text = "Score " & scoresum

            pattackp = 0
            If levelnum = 2 Then
                GeneratePic()
                Exit Sub
            End If
            ' lblrword.Top = 15
            ' lblrword.Text = kit.ScrambleWord(wordtouse(5))
            tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))
        End If
    End Sub
    Dim x As Integer = AlterMissed()
    Dim ctrw As Integer = 0
    Dim ctrr As Integer = 0
    Private Sub TimerBallMoveWrong_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBallMoveWrong.Tick
        pnball.Top -= pokeballspeed
        pnball.Left -= x
        pnpfuel.Width -= 3
        If pnball.Top <= 0 Then
            HitEffects()
            RambleWords() ' add another word
            ResetLetterNumberColor(Color.LightGray) 'color of btn number
            AssignButtonNumber() 'assigning number in btn 
            BtnGuessWordVisible(False)
            LabelVisible(True) 'hide labels
            TimerBallMoveWrong.Stop()
            pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
            ii = kit.RN(1, 4)
            ResetBallLocation()
            EnabledButton(True)
            pnpfuel.Width = 0
            ResetTime()
            TimerPlayerTurn.Start()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "-1 Pokeball.", 3000)
            'lblrword.Top = 15
            ' lblrword.Text = kit.ScrambleWord(wordtouse(5))


            If pbm = True Then
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = True
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "If you missed the term! The pocketball will deducted by 1 and color tiles will appear", Me, Color.WhiteSmoke, False)
                TutMes.PNLETTERS.Visible = True
                TutMes.pnpoke.Visible = False
                ShowTutorialMessageBox(vbNewLine & "If color tiles is used in the guess term, the privilege will add 1 depending on the color of tiles. Blue for Pokeball, Lightblue for Hint, Pink for Time Adder", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
                pbm = False
            End If
           
            If PokeballAvailable() = False Then
                ExplosionEffects()
                BGMStop()
                TimerPlayerTurn.Stop()
                ResetGame()
                TimerHotkey.Stop()
                TimerHotkeyBack.Stop()
                kit.Forward(pnpokemon, pnpokemon.Location.X, (pnarea.Width - pnpokemon.Width) - 1000)
                ShowMessageBox("You Lost!", Me, Color.WhiteSmoke)
                ShowChooseMessageBox(Me, Color.WhiteSmoke)
                If bly = False Then
                    Me.Close()
                    Exit Sub
                End If
                LoadPlayerInfo()
                ConditionForLevel(levelnum)
                kit.Back()
                TimerPlayerTurn.Start()
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
                stopgetprivi = True
                ctrw = 0 'reset
                ctrr = 0 'reset
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
                ResetTime()
                pnphbar.Width = 234
                lblpokenum.Text = 5

            End If
            x = AlterMissed()
            If lblpokenum.Text = 2 And pbn = True Then
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = True
                TutMes.pnpoke.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Warning! Your pocket ball is about to reach 0, you can use privilege Hint to show the first character of the term.", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
                pbn = False
            End If
            If ctrr >= 1 Then
                ctrr = 0
            End If

            ctrw += 1


            If levelnum >= 3 Then
                DisableLetter()
            End If

            rn = kit.RN(1, 5)
            PrivilegeStart2()
            EnabledButton(True)

        End If
    End Sub

    Dim abool As Boolean = True

    Function AlterMissed() As Integer
        Dim i As Integer
        If abool = True Then
            i = sideleft
            abool = False
        Else
            i = sideright
            abool = True
        End If
        Return i
    End Function

    Function PokeballAvailable() As Boolean
        Dim i As Boolean
        lblpokenum.Text -= 1

        If lblpokenum.Text = 0 Then
            i = False
        Else
            i = True
        End If
        Return i
    End Function


    Function PokemonLifeIsZero() As Boolean
        Dim i As Boolean
        pnphbar.Width -= pattackp * usebomb
        If pnphbar.Width <= 0 Then
            i = True
        Else
            i = False
        End If
        Return i

    End Function


    Dim stophidebutton As Boolean = False
    Dim stopgetprivi As Boolean = False
    Dim rn As Integer
    Dim rn2 As Integer

    Public Sub btnVisible(ByVal btn As Button, ByVal btng As Button, ByVal lbl As Label) 'hide btn in ramble letter
        lbl.Visible = True
        btng.BackColor = Color.LightGray
        lblg1.BackColor = Color.LightGray
        If levelnum = 3 Then
            DisableLetter()
        End If
        If btn.Visible = True And btng.Text = btn.Text Then
            lbl.Visible = True
            If stophidebutton = False Then
                btn.Visible = False
                lbl.Visible = False
                stophidebutton = True
            Else
                Exit Sub
            End If
        End If
    End Sub
    Dim st As String
    Public Sub GetPrivilege1(ByVal btn As Button, ByVal lbl As Label, ByVal str As String) 'get letter to be use in privi
        Dim i As Integer = kit.RN(0, 4)
        st = wordtouse(5).Substring(i, 1).ToUpper() '8th character in textbox
        If st = btn.Text Then
            If stopgetprivi = False Then
                btn.BackColor = Color.SlateGray
                lbl.BackColor = Color.SlateGray
                btn.Enabled = False
                lbl.Enabled = False
                stopgetprivi = True
            Else
                stopgetprivi = True
                Exit Sub
            End If
        Else
            btn.BackColor = Color.LightGray
            lbl.BackColor = Color.LightGray
            ' If levelnum >= 2 Then
            btn.Enabled = True
            lbl.Enabled = True
            'End If
            End If
    End Sub

    Dim str2 As String
    Dim stopgetprivi2 As Boolean = False
    Dim ii As Integer
    Public Sub GetPrivilege2(ByVal btn As Button, ByVal lbl As Label, ByVal str As String) 'get letter to be use in privi

        str2 = wordtouse(5).Substring(ii, 1).ToUpper() '8th character in textbox
        If str2 = btn.Text Then
            If stopgetprivi2 = False Then
                btn.BackColor = ColorPrivi()
                lbl.BackColor = ColorPrivi()
                stopgetprivi2 = True
            Else
                stopgetprivi2 = True
                Exit Sub
            End If
        Else
            '  btn.BackColor = Color.LightGray
            ' lbl.BackColor = Color.LightGray
        End If
    End Sub

    Public Sub PrivilegeActivate() 'Privilege 1 
        GetPrivilege1(Button1, lbl1, rambleletters)
        GetPrivilege1(Button2, lbl2, rambleletters)
        GetPrivilege1(Button3, lbl3, rambleletters)
        GetPrivilege1(Button4, lbl4, rambleletters)
        GetPrivilege1(Button5, lbl5, rambleletters)
        GetPrivilege1(Button6, lbl6, rambleletters)
        GetPrivilege1(Button7, lbl7, rambleletters)
        GetPrivilege1(Button8, lbl8, rambleletters)
        GetPrivilege1(Button9, lbl9, rambleletters)
        GetPrivilege1(Button10, lbl10, rambleletters)
        GetPrivilege1(Button11, lbl11, rambleletters)
        GetPrivilege1(Button12, lbl12, rambleletters)
        stopgetprivi = False
    End Sub

    Public Sub PrivilegeActivate2()

        GetPrivilege2(Button1, lbl1, rambleletters)
        GetPrivilege2(Button2, lbl2, rambleletters)
        GetPrivilege2(Button3, lbl3, rambleletters)
        GetPrivilege2(Button4, lbl4, rambleletters)
        GetPrivilege2(Button5, lbl5, rambleletters)
        GetPrivilege2(Button6, lbl6, rambleletters)
        GetPrivilege2(Button7, lbl7, rambleletters)
        GetPrivilege2(Button8, lbl8, rambleletters)
        GetPrivilege2(Button9, lbl9, rambleletters)
        GetPrivilege2(Button10, lbl10, rambleletters)
        GetPrivilege2(Button11, lbl11, rambleletters)
        GetPrivilege2(Button12, lbl12, rambleletters)


        stopgetprivi2 = False
    End Sub


    Function ColorPrivi() As Color ' assign random color 1
        Dim col As Color
        If rn = 1 Then
            col = Color.FromArgb(128, 255, 255)
        ElseIf rn = 2 Then
            col = Color.FromArgb(255, 128, 255)
        ElseIf rn = 3 Or rn = 4 Or rn = 5 Then
            col = Color.RoyalBlue
        End If
        Return col
    End Function

    Public Sub DisableLetter() 'condition for wrong guess
        stopgetprivi = False
        If ctrr >= 1 Then
            PrivilegeActivate()
        End If
    End Sub

    Public Sub PrivilegeStart2() 'condition for wrong guess

        stopgetprivi2 = False
        If ctrw >= 1 Then
            PrivilegeActivate2()
            
        End If
    End Sub

    Public Sub AddPrivi()
        If btnl1.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time Adder.", 3000)
        End If
        If btnl2.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time Adder.", 3000)
        End If
        If btnl3.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time Adder.", 3000)
        End If
        If btnl4.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time Adder.", 3000)
        End If
        If btnl4.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Time Adder.", 3000)
        End If

        If btnl1.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint.", 3000)
        End If
        If btnl2.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint.", 3000)
        End If
        If btnl3.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint.", 3000)
        End If
        If btnl4.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint.", 3000)
        End If
        If btnl5.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Hint.", 3000)
        End If
        If btnl1.BackColor = Color.RoyalBlue Then
            lblpokenum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Pokeball.", 3000)
        End If
        If btnl2.BackColor = Color.RoyalBlue Then
            lblpokenum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Pokeball.", 3000)
        End If
        If btnl3.BackColor = Color.RoyalBlue Then
            lblpokenum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Pokeball.", 3000)
        End If
        If btnl4.BackColor = Color.RoyalBlue Then
            lblpokenum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Pokeball.", 3000)
        End If
        If btnl5.BackColor = Color.RoyalBlue Then
            lblpokenum.Text += 1
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "+1 Pokeball.", 3000)
        End If
    End Sub

 
    Private Sub btnhint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhint.Click
        ClickEffects()
        '     If pnguessword.BackColor = Color.FromArgb(128, 255, 255) Then
        'FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Hint: " & GetMeaning(ListBox2, ListBox3, wordtouse(5)), 5000)
        'GoTo a
        '  ElseIf pnguessword.BackColor = Color.FromArgb(255, 192, 128) Then
        ' FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Can't Use Hint. Nitro Still Activated!", 3000)
        ' If levelnum >= 2 Then
        ' PrivilegeStart2()
        'd If
        ' Exit Sub
        'End If
        If lblhintnum.Text = 0 Then
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Hint is Zero.", 2000)
            pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
            '   If levelnum >= 2 Then
            PrivilegeStart2()
            'End If
            Exit Sub
        End If
        lblhintnum.Text -= 1
a:
        pnpfuel.Width = 0
        FuelBarCondition(lbl1)
        pnguessword.BackColor = Color.FromArgb(128, 255, 255)
        'If btnl1.Text <> TextBox1.Text.Substring(0, 1).ToUpper Then

        ' End If
        If btnl1.Text <> wordtouse(5).Substring(0, 1).ToUpper Then
            btnl1.Visible = False
            btnl2.Visible = False
            btnl3.Visible = False
            btnl4.Visible = False
            btnl5.Visible = False
            lblg1.Visible = False
            lblg2.Visible = False
            lblg3.Visible = False
            lblg4.Visible = False
            lblg5.Visible = False
            ResetButton()
        End If
        If btnl1.Text = "" Then
            btnl1.Text = wordtouse(5).Substring(0, 1).ToUpper 'get 1 char
            lblg1.Text = btnNumber(btnl1)
            btnVisible(Button1, btnl1, lbl1)
            btnVisible(Button2, btnl1, lbl2)
            btnVisible(Button3, btnl1, lbl3)
            btnVisible(Button4, btnl1, lbl4)
            btnVisible(Button5, btnl1, lbl5)
            btnVisible(Button6, btnl1, lbl6)
            btnVisible(Button7, btnl1, lbl7)
            btnVisible(Button8, btnl1, lbl8)
            btnVisible(Button9, btnl1, lbl9)
            btnVisible(Button10, btnl1, lbl10)
            btnVisible(Button11, btnl1, lbl11)
            btnVisible(Button12, btnl1, lbl12)


            btnl1.Visible = True
            lblg1.Visible = True
        End If
        AssignButtonNumber()
        stophidebutton = False
        ResetLetterNumberColor(Color.LightGray)
        '  FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Hint: " & GetMeaning(ListBox2, ListBox3, wordtouse(5)), 5000)

        If levelnum = 3 Then
            DisableLetter()
        End If

        '    If levelnum >= 2 Then
        PrivilegeStart2()
        '   End If
    End Sub

    Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
        ClickEffects()
        If lbltnum.Text = 0 Then
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Time-Adder is Zero.", 2000)
            Exit Sub
        End If
        lbltnum.Text -= 1 'decrease hint
        pctr += 10
        lbltime.Text += 10 'add 10
        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Your thinking time is added by 10 seconds.", 3000)
        pbtt = False
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        BGMStop()
        TimerPause.Start()
        ShowQYesNoMessageBox(Me, Color.WhiteSmoke)
        If blx = False Then
            Me.Close()
            Exit Sub
        End If
            If levelnum = 1 Then
                BGMLevel1()
            ElseIf levelnum = 2 Then
                BGMLevel2()
            Else
                BGMLevel3()
        End If
        TimerPause.Stop()
        TimerHotkey.Start()
        TimerHotkeyBack.Start()
        TimerPlayerTurn.Start()
        tutorial = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BGMStop()
        TimerPause.Start()

        ShowSSMessageBox(Me, Color.WhiteSmoke)
        TimerPause.Stop()
         TimerPlayerTurn.Start()
        If levelnum = 1 Then
            BGMLevel1()
        ElseIf levelnum = 2 Then
            BGMLevel2()
        Else
            BGMLevel3()
        End If
    End Sub


    Public Sub GeneratePic()
        Dim s As Integer = ListBox2.FindString(wordtouse(5))
        PictureBox1.ImageLocation = Application.StartupPath & "\imgchina\" & Val(s) + 1 & ".png"
        '   MsgBox(s & wordtouse(5))
    End Sub

    Private Sub ConditionForLevel(ByVal i As Integer)
        If i = 1 Then
            TutMes.btnhint.Visible = False
            TutMes.btnTime.Visible = False
            TutMes.PNLETTERS.Visible = False
            TutMes.pnpoke.Visible = False


            If tutorial = True Then
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Level 1 Tutorials", Me, Color.WhiteSmoke, True)
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Ready for your warm up, " & pname.ToUpper, Me, Color.WhiteSmoke, False)
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Read and find the term (5 letters) in a given sentence", Me, Color.WhiteSmoke, False)

            End If
            'ShowMessageBox("Chinese History Terms ! Find the term(5 Letters) in a given sentence.", Me, Color.WhiteSmoke)
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            BGMLevel1()
            EnemyChange(Color.FromArgb(59, 91, 52), enemybluename, enemybluedetail)
            'pnarea.BackgroundImage = My.Resources.grasspng
            '  colortext(Color.FromArgb(59, 91, 52))
            pnpokemon.BackgroundImage = My.Resources.bulbasor2
            lblpokemon.Text = "Bulbasaur"
            'pnarea.BackColor = Color.FromArgb(100, 64, 64)

            tbphrase.Visible = True
            PictureBox1.Visible = False
            tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))
        ElseIf i = 2 Then
            TutMes.btnhint.Visible = False
            TutMes.btnTime.Visible = False
            TutMes.PNLETTERS.Visible = False
            TutMes.pnpoke.Visible = False
            
            If tutorial = True Then
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Level 2 Tutorials", Me, Color.WhiteSmoke, True)
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Submit the term (5 letters) that shows in a given picture", Me, Color.WhiteSmoke, False)
            End If

            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            BGMLevel2()
            EnemyChange(Color.FromArgb(118, 50, 61), enemyvioletname, enemyvioletdetail)
            DisableLetter()
            PrivilegeStart2()
            'pnarea.BackgroundImage = My.Resources.firepng
            ' colortext(Color.FromArgb(118, 50, 61))
            pnpokemon.BackgroundImage = My.Resources.chanmander
            lblpokemon.Text = "Charmander"

            tbphrase.Visible = False
            PictureBox1.Visible = True

            GeneratePic()

            'pnarea.BackColor = Color.FromArgb(100, 64, 64)
            'ElseIf i = 3 Then
            '   PrivilegeStart2()
            ' DisableLetter()
            ' BGMLevel3()
            ' EnemyChange(Color.Yellow, enemyredname, enemyreddetail)
            ' pnarea.BackgroundImage = My.Resources.electricpng
            ' colortext(Color.White)
            ' pnpokemon.BackgroundImage = My.Resources.pikachu
            ' lblpokemon.Text = "Pikachu"
            ' pnarea.BackColor = Color.FromArgb(100, 64, 64)
        Else
            bl = True
            TimerPlayerTurn.Stop()
            levelnum = 1
            UpdateInfo("studlevel", 1)
            UpdateInfo("studstage", 2)
            UpdateInfo("studm1", 1)
            UpdateInfo("studhint", lblhintnum.Text)
            UpdateInfo("studta", lbltnum.Text)
            s11 = 1
            ShowMessageBox("Stage " & 1 & " Cleared!", Me, Color.WhiteSmoke)
            ShowTMessageBox(china, Me, Color.WhiteSmoke)
            BoWMap.Show()
            Me.Close()
            Exit Sub
        End If
    End Sub

  
 
    Private Sub TimerCompMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCompMove.Tick

    End Sub

    Private Sub TimerPlayerFire_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerFire.Tick

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BGMStop()
        TimerPause.Start()
        BoWInstructions.ShowDialog()
        TimerPause.Stop()
        TimerPlayerTurn.Start()
       
    End Sub
End Class

