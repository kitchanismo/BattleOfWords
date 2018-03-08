Imports System.Runtime.InteropServices
Public Class BoWStage3
    Dim wordlenght As Integer
    Dim rambleletters As String
    Dim str As String
    Dim n As Integer = 0
    Dim arTemp() As String = Nothing '// used to get all lines from TextBox.
    Dim sTemp As String = Nothing '// used to add lines back to TextBox.
    Dim enemybluename As String = "Psyduck".ToUpper
    Dim enemyvioletname As String = "Rattata".ToUpper
    Dim enemyredname As String = "Charmander"
    Dim enemybluedetail As String = "     'He Loves Milk'"
    Dim enemyvioletdetail As String = "'He Loves Chocolate'"
    Dim enemyreddetail As String = "'He Loves Strawberry'"
    Dim enemybluecolor As Color = Color.White
    Dim enemyvioletcolor As Color = Color.Chocolate
    Dim enemyredcolor As Color = Color.Crimson
    Dim lines() As String
    Dim lines2() As String
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Private Sub BoWStage2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'blackscreen.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tutorial = True

        ShowMessageBox("Shoot Them All!", Me, Color.WhiteSmoke)
        ShowMessageBox("Stage 3 is about the History of Italy.", Me, Color.WhiteSmoke)
        lblpname.Text = pname.ToUpper
        'lblpname.Text = "sdsd"

        ' wordlenght = 5 'number of letter to get 
        SeperateLetter(GenerateWords()) 'seperate each letter in btn
        AssignButtonNumber() 'assigning number in btn 
        lblcname.Text = enemybluename

        lines = IO.File.ReadAllLines(Application.StartupPath & "\" & italywords)
        ListBox2.Items.AddRange(lines)
        lines2 = IO.File.ReadAllLines(Application.StartupPath & "\" & italywordsmeaning)
        ListBox3.Items.AddRange(lines2)
        LoadPrivi()
        levelnum = GetInfo("studlevel")
        ConditionForLevel(levelnum)
        TimerPlayerTurn.Start() ' start the thinking time
        TimerStartGame.Start()
    
        LoadPlayerInfo()
        GetGender()
        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)

    End Sub
    Public Sub GetGender()
        If "male" = GetGen("studavatar") Then
            pnavatar.BackgroundImage = My.Resources.male
        Else
            pnavatar.BackgroundImage = My.Resources.female
        End If
    End Sub
    Public Sub LoadPrivi()
        'lblhintnum.Text = 1
        'lbltnum.Text = 1
        ' lblBnum.Text = 1
        lblhintnum.Text = BoWStage2.lblhintnum.Text
        lbltnum.Text = BoWStage2.lbltnum.Text
        lblBnum.Text = BoWStage2.lblNnum.Text
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
        PrivilegeStart()
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
        PrivilegeStart() 'color privi
        stopremoveletter = False

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
        PrivilegeStart()
        stopremoveletter = False
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
        PrivilegeStart()
        stopremoveletter = False

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
        PrivilegeStart()
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
        PrivilegeStart() 'color privi
        pattackp = 0
    End Sub
    Private Sub btnshuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshuffle.Click
        ClickEffects()
        ShuffleWords()
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
        lblBnum.Text = GetInfo("studnb")
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
        pname = InputBox("Enter Your Name:")
        If pname = "" Then
            pname = "Player"
        End If
        lblpname.Text = pname.ToUpper
    End Sub
    Dim w1, w2, w3 As String
    Function GenerateWords() As String 'get 3 words from list and combine
        Dim word1 As String = ""
        Dim word2 As String = ""
        Dim word3 As String = ""

        kit.ChooseWord(lblwords, 5, italywords)
        word1 = lblwords.Text
        ListBox1.Items.Add(word1)

        kit.ChooseWord(lblwords, 4, italywords)
        word2 = lblwords.Text
        ListBox1.Items.Add(word2)

        kit.ChooseWord(lblwords, 3, italywords)
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
        pnpfuel.BackColor = Color.Yellow
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

        kit.ChooseWord(lblNewWord, i, italywords)
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


    Public Sub ReplaceWord() 'add word after delete one
        '   Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text
        ' Dim wordreplace As String
        ' strword = ""
        'RemoveWord(str.ToLower)
        '  RemoveWord(btnl1.Text.ToLower)
        '  RemoveWord(btnl2.Text.ToLower)
        ' RemoveWord(btnl3.Text.ToLower)
        ' RemoveWord(btnl4.Text.ToLower)
        'RemoveWord(btnl5.Text.ToLower)

        'kit.ChooseWord(lblwords, i, DictionaryWords)
        ' wordreplace = lblwords.Text
        'lblNewWord.Text = strword & wordreplace
        ' TextBox1.Text = TextBox1.Text & "+" & wordreplace
        ' ListBox1.Items.Remove(wordtouse(str.Length))
        ' ListBox1.Items.Add(wordreplace)
        ListBox1.Items.Clear()

        SeperateLetter(GenerateWords)
        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        ResetButton()
    End Sub


    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click

        Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text

        If str.Length < 5 Then '3-5 char only
            'FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "3-5 Characters only!", 2000)
            Exit Sub
        End If
        ResetTime() 'reset time to 30
        If ListBox2.Items.Contains(str.ToLower) Then

            Dim i As Integer
            pmovectr += ComputeMovePoints() * usebomb 'distance reach
            i = ComputeMovePoints() * usebomb
            If usebomb = 2 Then
                TimerBomb.Start()
            Else
                TimerPlayerFire.Start() 'start to move pbox
            End If
            EnabledButton(False)
            TimerHotkey.Stop()
            TimerHotkeyBack.Stop()
            TimerPlayerTurn.Stop()
            pnguessword.BackColor = Color.MediumSeaGreen
            If (i > 49 And i < 101) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Good!", 3000)
            ElseIf (i > 101 And i < 201) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Nice!", 3000)
            ElseIf (i > 201 And i < 1000) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Excellent!", 3000)
            End If
            If usebomb = 2 Then
                LaserEffects()
            Else
                ShootEffects()
            End If
            pnplayer.BackColor = Color.RoyalBlue
            pncomputer.BackColor = Color.FromArgb(180, 120, 25, 0)
            ReplaceWord() ' add another word
            ResetLetterNumberColor(Color.LightGray) 'color of btn number
            AssignButtonNumber() 'assigning number in btn 
            BtnGuessWordVisible(False)

            LabelVisible(True) 'hide labels
            IncreasePrivi() 'add privileges 
            rn = kit.RN(1, 3) 'select random number form 1-6
            If ctrwrong = 3 Then 'back to 1 privi
                ctrwrong -= 1
            End If
            PrivilegeStart() 'add scolor privi
            'add

        Else
            BuzzEffects()
            pnguessword.BackColor = Color.PaleVioletRed
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Wrong!", 4000)
            EnabledButton(False)
            If tutorial = True Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.btnNitro.Visible = False
                TutMes.pnpoke.Visible = False
                TimerPlayerTurn.Stop()

                ShowTutorialMessageBox(vbNewLine & "WRONG!" & vbNewLine & "Your opponent will turn and answer.", Me, Color.WhiteSmoke, False)
                '  TimerPlayerTurn.Start()
                ' tutorial = False
            End If
            TimerCompTurn.Start()
            TimerPlayerTurn.Stop()
            TimerHotkey.Stop()
            TimerHotkeyBack.Stop()
            pnpfuel.Width = 0
            pattackp = 0
            'ctrwrong += 1 'count the wrong guess
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
        pnPrivileges.Enabled = bool
    End Sub

    Function ComputerAnswer() As String
        Dim j As String = ""
        If levelnum = 1 Then
            ' j = wordtouse(3)
            j = wordtouse(5)
        ElseIf levelnum = 2 Then
            ' j = wordtouse(4)
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
        '  If levelnum = 2 Then
        Dim str4 As Char = value(3)
        btnl4.Text = str4
        lblg4.Text = btnNumber(btnl4)
        btnl4.Visible = True
        lblg4.Visible = True
        'End If
        'If levelnum = 3 Then
        ' Dim str4 As Char = value(3)
        btnl4.Text = str4
        lblg4.Text = btnNumber(btnl4)
        btnl4.Visible = True
        lblg4.Visible = True
        Dim str5 As Char = value(4)
        btnl5.Text = str5
        lblg5.Text = btnNumber(btnl5)
        btnl5.Visible = True
        lblg5.Visible = True
        'End If
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
        pnpbox.Left = 99
        pncbox.Left = 702
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
        pnplayer.BackColor = Color.RoyalBlue
        pncomputer.BackColor = Color.FromArgb(180, 120, 25, 0)
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
        lblcname.Text = str
    End Sub

    Dim cattack As Integer

    Public Sub HealthLifeBarVisible(ByVal bool As Boolean)
        pnh1.Visible = bool
        pnh2.Visible = bool
        pnh3.Visible = bool
        pnh1.BackColor = Color.MediumSeaGreen
        pnh2.BackColor = Color.MediumSeaGreen
        pnh3.BackColor = Color.MediumSeaGreen
    End Sub


    Public Sub FuelColor(ByVal i As Integer)
        If i = 1 Then

            EnemyChange(enemybluecolor, enemybluename, enemybluedetail)
            cfuel = 100
            cattack = 30
        ElseIf i = 2 Then

            cfuel = 150
            EnemyChange(enemyvioletcolor, enemyvioletname, enemyvioletdetail)
            cattack = 40
        ElseIf i = 3 And bl = False Then

            cfuel = 200
            EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
            cattack = 45
            bl = True
            If i = 3 And bl = True Then
                HealthLifeBarVisible(True)
            End If
        ElseIf i = 3 Then
            cfuel = 200
            EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
            cattack = 70
        End If
    End Sub

#End Region

#Region "Timers"

    Dim pctr As Integer = 30
    Dim ctr As Integer
    Private Sub TimerTurn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCompTurn.Tick
        Try
            ctr += 1
            If ctr = 2 Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text.ToUpper & "'s Turn!", 2000)
                pncomputer.BackColor = Color.RoyalBlue
                pnplayer.BackColor = Color.FromArgb(180, 120, 25, 0)
                pnpbox.Visible = False
                pncbox.Visible = True
            End If
            If ctr = 4 Then ' 3 sc
                ' MsgBox("1")
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text.ToUpper & " is thinking ...", 4000)
                btnGuess.BackColor = Color.LightGray
                pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
                ResetLetterNumberColor(Color.LightGray)
                BtnGuessWordColor(Color.LightGray)
                LabelVisible(True)
                BtnGuessWordVisible(True)
                TimerThinking.Start()
                FuelColor(levelnum)
                'ConditionForLevel(levelnum)
                ResetButton()
            End If
            If ctr = 8 Then ' 8 sc
                'MsgBox("2")
                ResetLetterNumberColor(Color.LightGray) 'color of btn number
                FlatAlertBox1.Visible = False
                ComputerTurn(ComputerAnswer()) ' computer will answer
                cmovectr += cfuel 'distance reach of computer
                rn = kit.RN(1, 3)
                TimerThinking.Stop()
                pnguessword.BackColor = Color.MediumSeaGreen
                TickEffects()
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text.ToUpper & " ANSWERED: " & lblCompAns.Text.ToUpper & "", 5000)

            End If
            If ctr = 13 Then ' 13 sc
                ' MsgBox("3")
                ShootEffects()
                pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
                BtnGuessWordVisible(False)
                ReplaceWordComputerAnswer(ComputerAnswer().Length) 'add another word
                pnplayer.BackColor = Color.RoyalBlue
                pncomputer.BackColor = Color.FromArgb(180, 120, 25, 0)
                AssignButtonNumber()
                lblg1.Text = ""
                lblg2.Text = ""
                lblg3.Text = ""
                lblg4.Text = ""
                lblg5.Text = ""
                rn2 = kit.RN(4, 6)
                ii = kit.RN(1, 4)
                'PrivilegeStart()
                TimerCompMove.Start() 'start to move cbox
                usebomb = 1
                'enemy gain health
                If pnchbarbase.Width >= 90 And levelnum = 3 Then
                    If pnh1.Visible = True And pnh2.Visible = True And pnh3.Visible = True Then
                        pnh1.Visible = False
                        pnchbarbase.Width -= 30
                        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text & " Added More Life!", 3000)
                    ElseIf pnh2.Visible = True And pnh3.Visible = True Then
                        pnh2.Visible = False
                        pnh3.BackColor = Color.PaleVioletRed
                        pnchbarbase.Width -= 30
                        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text & " Added More Life!", 3000)
                    ElseIf pnh3.Visible = True Then
                        pnh3.Visible = False
                        pnchbarbase.Width -= 30
                        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblcname.Text & " Added More Life!", 3000)
                    End If
                End If

            End If
            If ctr = 15 Then
                ' MsgBox("4")
                ctr = 0
                If ctrwrong < 4 Then 'wrong til 4 only
                    ctrwrong += 1
                End If
                TimerCompTurn.Stop()
                TimerPlayerTurn.Start()
                PrivilegeStart()
                ' pnpbox.Visible = True
                'pncbox.Visible = False
            End If
        Catch
        End Try
    End Sub

    Private Sub TimerPlayerTurn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerTurn.Tick
        pctr -= 1
        lbltime.Text = pctr

        If pctr = 27 Then
            pnpbox.Left = 99
            pnpbox.Visible = True
            pncbox.Visible = False
        End If

        If pctr = 22 Then

            If tutorial = True And levelnum = 1 Then
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = False
                TutMes.btnNitro.Visible = False

                TutMes.LinkLabel2.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Now Click or Type the term " & wordtouse(5).ToUpper & " in the ramble letters! Then Click Race", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
            ElseIf tutorial = True And levelnum = 2 Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TimerPlayerTurn.Stop()
                TutMes.pnpoke.Visible = False
                TutMes.btnNitro.Visible = False
                TutMes.LinkLabel2.Visible = False
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Now Click or Type the term " & wordtouse(5).ToUpper & " that shows the picture! Then Click Race", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
            End If
       
        End If
     
        If pctr = 10 Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Warning! You're about to lose your turn.", 5000)
        End If
        If pctr = 0 Then 'when timer reach
            If pbt = True Then
                TimerPlayerTurn.Stop()
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = True
                TutMes.btnNitro.Visible = False
                TutMes.Button3.BackColor = Color.FromArgb(255, 192, 128)
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "You have given 30 seconds to submit your answer. " & vbNewLine & "If thinking time reached to 0 your opponent will turn and answer.", Me, Color.WhiteSmoke, False)

                TimerPlayerTurn.Start()
                pbt = False
            End If
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Times up! Sorry! You lost your turn.", 5000)
            TimerPlayerTurn.Stop()
            TimerHotkey.Stop()
            TimerHotkeyBack.Stop()
            pctr = 30
            TimerCompTurn.Start()
            EnabledButton(False)
        End If
    End Sub
    Dim scoresum As Integer = GetInfo("studscore")
    Dim pmovectr As Integer
    Private Sub TimerPlayerFire_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerFire.Tick
        pnpbox.Left += 5
        pnpfuel.Width -= 2
        If pnpbox.Left >= pngamearea.Width - 160 Then 'when the player hit the enemy
            HitEffects()
            TimerPlayerFire.Stop()

            scoresum += ComputeScore()
            lblscore.Text = "Score " & scoresum

            pnchbarbase.Width += pattackp
            pnpbox.Left = 99
            pattackp = 0
            kit.Shake(pncc, 25, 4, 1)
            pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
            FlatAlertBox1.Visible = False
            pnpbox.Visible = False
            ' EnabledButton(True)
            If tutorial = True Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.btnNitro.Visible = False
                TutMes.pnpoke.Visible = False
                TimerPlayerTurn.Stop()
                ShowTutorialMessageBox(vbNewLine & "WELL DONE! " & vbNewLine & "Defeat your enemy until your health meter runs out.", Me, Color.WhiteSmoke, False)
                ' TutMes.pnpoke.Visible = True
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Your opponent will turn and answer", Me, Color.WhiteSmoke, False)
                '  TimerPlayerTurn.Start()
                tutorial = False
            End If
            TimerCompTurn.Start()

            If pnchbarbase.Width >= 160 Then
                pnchbar.BackColor = Color.PaleVioletRed
            End If
            If pnchbarbase.Width >= 236 Then
                ExplosionEffects()
                BGMStop()
                levelnum += 1 'increase level
                kit.Forward(pnc, pnc.Location.X, (pp.Width - pnc.Width) + 360)
                TimerCompTurn.Stop()
                scoresum += ComputeScore()
                lblscore.Text = "Score " & scoresum
                ResetGame()
                UpdateInfo("studlevel", levelnum)
                UpdateInfo("studscore", scoresum)
                UpdateInfo("studhint", lblhintnum.Text)
                UpdateInfo("studta", lbltnum.Text)
                UpdateInfo("studnb", lblBnum.Text)
                ConditionForLevel(levelnum)

                If levelnum = 1 Then
                    tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))
                    Exit Sub
                End If

                ShowMessageBox("Level " & levelnum - 1 & " Cleared!", Me, Color.WhiteSmoke)
                ShowMessageBox("Saved!", Me, Color.WhiteSmoke)
                lbllvl.Text = "Level " & levelnum
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
                TimerPlayerTurn.Start()
                kit.Back()
                usebomb = 1
                stopgetprivi = True
                ctrwrong = 0 'reset
                TimerStartGame.Start()

                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
            End If
            If levelnum = 2 Then
                GeneratePic()
                Exit Sub
            End If
            ' lblrword.Top = 15
            ' lblrword.Text = kit.ScrambleWord(wordtouse(5))
            tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))

        End If
    End Sub
    Dim cmovectr As Integer
    Private Sub TimerCompMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCompMove.Tick
        pncbox.Left -= 5
        pnpfuel.Width -= 2
        If pncbox.Left <= 80 Then

            HitEffects()
            TimerCompMove.Stop()
            TimerCompTurn.Stop()
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            kit.Shake(pnpp, 25, 4, 1)
            pnphbar.Width -= cattack
            pncbox.Left = 702
            EnabledButton(True)

            If pnphbar.Width <= 86 Then
                pnphbar.BackColor = Color.PaleVioletRed
            End If
            pncbox.Visible = False

            If pbb = True Then
                TutMes.btnhint.Visible = False
                TutMes.btnTime.Visible = False
                TutMes.PNLETTERS.Visible = False
                TutMes.pnpoke.Visible = False
                TutMes.btnNitro.BackgroundImage = My.Resources.bomb
                TutMes.btnNitro.Visible = True
                TimerPlayerTurn.Stop()
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "You can use Bomb to increase twice the attack and points.", Me, Color.WhiteSmoke, False)
                TimerPlayerTurn.Start()
                pbb = False
            End If
            If ctrwrong > 1 Then ' 3 wrongs
                TimerPlayerTurn.Stop()
                If pbt = True Then
                    TutMes.btnhint.Visible = False
                    TutMes.btnTime.Visible = False
                    TutMes.PNLETTERS.Visible = True
                    TutMes.pnpoke.Visible = False
                    TutMes.btnNitro.Visible = False
                    TutMes.Button3.BackColor = Color.FromArgb(255, 192, 128)
                    TimerPlayerTurn.Stop()
                    ShowTutorialMessageBox(vbNewLine & vbNewLine & "If you missed the term, the color tiles will appear on ramble letters.", Me, Color.WhiteSmoke, False)
                    ShowTutorialMessageBox(vbNewLine & vbNewLine & "If color tiles is used in the guess term, the privilege will add 1 depending on the color of tiles. Orange for Boost, Lightblue for Hint, Pink for Time Adder", Me, Color.WhiteSmoke, False)
                    TimerPlayerTurn.Start()
                    pbt = False
                End If
            End If
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, lblpname.Text.ToUpper & " is now your turn!", 5000)

            If pnphbar.Width <= 0 + 30 Then

                ResetGame()
                TimerCompTurn.Stop()

                kit.Forward(pnavatar, pnavatar.Location.X, (pc.Width - pnavatar.Width) - 1000)
                ExplosionEffects()
                BGMStop()
                ShowMessageBox("You Lost!", Me, Color.WhiteSmoke)
                ShowChooseMessageBox(Me, Color.WhiteSmoke)
                LoadPlayerInfo()
                ConditionForLevel(levelnum)
                kit.Back()
                TimerPlayerTurn.Start()
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
                usebomb = 1
                stopgetprivi = True
                ctrwrong = 0 'reset
                TimerStartGame.Start()
                pattackp = 0
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
                If levelnum = 3 Then
                    HealthLifeBarVisible(True)
                    bl = False
                End If
            End If
            TimerPlayerTurn.Start()
            If levelnum = 2 Then
                GeneratePic()
                Exit Sub
            End If
            ' lblrword.Top = 15
            ' lblrword.Text = kit.ScrambleWord(wordtouse(5))
            tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))

        End If
    End Sub

#End Region

#Region "Hint"
    Dim stophidebutton As Boolean = False
    Dim stopgetprivi As Boolean = False
    Dim rn As Integer
    Dim rn2 As Integer
    Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
        ClickEffects()
        If lbltnum.Text = 0 Then
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Time-Adder is Zero.", 2000)
            Exit Sub
        End If
        lbltnum.Text -= 1 'decrease hint
        pctr += 10
        lbltime.Text += 10 'add 30
        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Your thinking time is added by 10 seconds.", 5000)
    End Sub

    Private Sub btnnitro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBomb.Click
        ClickEffects()
        If pnguessword.BackColor = Color.FromArgb(255, 192, 128) Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Bomb Activated!", 2000)
            GoTo n
        End If
        If lblBnum.Text = 0 Then
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Bomb is Zero.", 2000)
            pnguessword.BackColor = Color.LightSlateGray
            Exit Sub
        End If
        lblBnum.Text -= 1
        usebomb = 2 'twice
        pnpfuel.Width = pnpfuel.Width * 2 'times 2
n:      FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Bomb Activated!", 2000)
        pnguessword.BackColor = Color.FromArgb(255, 192, 128)
    End Sub

    Private Sub btnhint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhint.Click
        ClickEffects()
        If pnguessword.BackColor = Color.FromArgb(128, 255, 255) Then
            'FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Hint: " & GetMeaning(ListBox2, ListBox3, wordtouse(5)), 5000)
            GoTo a
        ElseIf pnguessword.BackColor = Color.FromArgb(255, 192, 128) Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Can't Use Hint. Nitro Still Activated!", 3000)
            Exit Sub
        End If
        If lblhintnum.Text = 0 Then
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Hint is Zero.", 2000)
            pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
            Exit Sub
        End If
        lblhintnum.Text -= 1
a:
        pnpfuel.Width = 0
        FuelBarCondition(lbl1)
        pnguessword.BackColor = Color.FromArgb(128, 255, 255)
        'If btnl1.Text <> TextBox1.Text.Substring(0, 1).ToUpper Then

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
        '  FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Hint: " & GetMeaning(ListBox2, ListBox3, wordtouse(5)), 5000)
        ResetLetterNumberColor(Color.LightGray)
        PrivilegeStart()
    End Sub

    Public Sub btnVisible(ByVal btn As Button, ByVal btng As Button, ByVal lbl As Label) 'hide btn in ramble letter
        lbl.Visible = True
        btng.BackColor = Color.LightGray
        lblg1.BackColor = Color.LightGray
        PrivilegeStart()
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
    Dim str1 As String
    Dim ii As Integer
    Public Sub GetPrivilege1(ByVal btn As Button, ByVal lbl As Label, ByVal str As String) 'get letter to be use in privi
        str1 = wordtouse(5).Substring(ii, 1).ToUpper()
        If str1 = btn.Text Then
            If stopgetprivi = False Then
                btn.BackColor = ColorPrivi()
                lbl.BackColor = ColorPrivi()
                stopgetprivi = True
            Else
                stopgetprivi = True
                Exit Sub
            End If
        Else
            btn.BackColor = Color.LightGray
            lbl.BackColor = Color.LightGray
        End If
    End Sub

    Dim str2 As String
    Dim stopgetprivi2 As Boolean = False
    Public Sub GetPrivilege2(ByVal btn As Button, ByVal lbl As Label, ByVal str As String) 'get letter to be use in privi
        str2 = TextBox1.Text.Substring(3, 1).ToUpper() '9th character in textbox
        If str2 = btn.Text Then
            If stopgetprivi2 = False Then
                btn.BackColor = ColorPrivi2()
                lbl.BackColor = ColorPrivi2()
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


    Public Sub PrivilegeActivate()
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


    Function ColorPrivi() As Color ' assign random color
        Dim col As Color
        If rn = 1 Then
            col = Color.FromArgb(128, 255, 255)
        ElseIf rn = 2 Then
            col = Color.FromArgb(255, 128, 255)
        ElseIf rn = 3 Then
            col = Color.FromArgb(255, 192, 128)
        End If
        Return col
    End Function
    Function ColorPrivi2() As Color ' assign random color
        Dim col As Color
        If rn2 = 4 Then
            col = Color.FromArgb(128, 255, 255)
        ElseIf rn2 = 5 Then
            col = Color.FromArgb(255, 128, 255)
        ElseIf rn2 = 6 Then
            col = Color.FromArgb(255, 192, 128)
        End If
        Return col
    End Function
    Public Sub PrivilegeStart() 'condition for wrong guess
        stopgetprivi = False
        stopgetprivi2 = False
        If ctrwrong >= 1 Then ' 3 wrongs

            PrivilegeActivate()
        End If

    End Sub

    Public Sub IncreasePrivi() 'add privi
        If btnl1.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
        End If
        If btnl2.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
        End If
        If btnl3.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
        End If
        If btnl4.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
        End If
        If btnl4.BackColor = Color.FromArgb(255, 128, 255) Then
            lbltnum.Text += 1
        End If

        If btnl1.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
        End If
        If btnl2.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
        End If
        If btnl3.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
        End If
        If btnl4.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
        End If
        If btnl5.BackColor = Color.FromArgb(128, 255, 255) Then
            lblhintnum.Text += 1
        End If

        If btnl1.BackColor = Color.FromArgb(255, 192, 128) Then
            lblBnum.Text += 1
        End If
        If btnl2.BackColor = Color.FromArgb(255, 192, 128) Then
            lblBnum.Text += 1
        End If
        If btnl3.BackColor = Color.FromArgb(255, 192, 128) Then
            lblBnum.Text += 1
        End If
        If btnl4.BackColor = Color.FromArgb(255, 192, 128) Then
            lblBnum.Text += 1
        End If
        If btnl5.BackColor = Color.FromArgb(255, 192, 128) Then
            lblBnum.Text += 1
        End If
    End Sub
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
            End If
        Next i
    End Sub

    Public Sub RemoveLetterHK(ByVal btn As Button, ByVal lbl As Label) 'method to hide the btn and label
        If stopremoveletterhk = True Then
            Exit Sub
        End If
        If hkstr.ToUpper = btn.Text And btn.Visible = True Then
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
            PrivilegeStart()
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
            PrivilegeStart()
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
            PrivilegeStart()
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
            PrivilegeStart()
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
            PrivilegeStart()
            Exit Sub
        End If
    End Sub

#End Region




    Private Sub lbltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltime.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If

    End Sub
    Dim bombctr As Integer
    Private Sub TimerBomb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBomb.Tick
        pnpbox.Width += 10
        pnpfuel.Width -= 4
        If pnpbox.Width >= pngamearea.Width - 150 Then
            pnpbox.Left += 10

            If pnpbox.Left >= pngamearea.Width - 80 Then
                HitEffects()
                TimerBomb.Stop()
                TimerHotkey.Start()
                TimerHotkeyBack.Start()
                pnchbarbase.Width += pattackp * usebomb

                If pnchbarbase.Width >= 160 Then
                    pnchbar.BackColor = Color.PaleVioletRed
                End If

                scoresum += ComputeScore()
                lblscore.Text = "Score " & scoresum

                pnpbox.Left = 99
                pnpfuel.Width = 0
                pnpbox.Visible = False
                pnpbox.Width = 90
                pnpbox.Height = 90
                pnpbox.Left = 0
                pnpbox.Visible = True
                pattackp = 0
                ' EnabledButton(True)
                ResetTime()
                TimerPlayerTurn.Stop()
                If tutorial = True Then
                    TutMes.btnhint.Visible = False
                    TutMes.btnTime.Visible = False
                    TutMes.PNLETTERS.Visible = False
                    TutMes.btnNitro.Visible = False
                    TutMes.pnpoke.Visible = False
                    TimerPlayerTurn.Stop()
                    ShowTutorialMessageBox(vbNewLine & "CORRECT! " & vbNewLine & "Keep on playing! Until your battlemon win the race.", Me, Color.WhiteSmoke, False)
                    ' TutMes.pnpoke.Visible = True
                    ShowTutorialMessageBox(vbNewLine & vbNewLine & "Your opponent will turn and answer", Me, Color.WhiteSmoke, False)
                    '  TimerPlayerTurn.Start()
                    tutorial = False
                End If
                TimerCompTurn.Start()
                pnguessword.BackColor = Color.FromArgb(180, 120, 25, 0)
                If pnchbarbase.Width >= 236 Then
                    ExplosionEffects()
                    BGMStop()
                    levelnum += 1 'increase level
                    kit.Forward(pnc, pnc.Location.X, (pp.Width - pnc.Width) + 360)
                    TimerCompTurn.Stop()

                    scoresum += ComputeScore()
                    ResetGame()
                    lblscore.Text = "Score " & scoresum

                    UpdateInfo("studlevel", levelnum)
                    UpdateInfo("studscore", scoresum)
                    UpdateInfo("studhint", lblhintnum.Text)
                    UpdateInfo("studta", lbltnum.Text)
                    UpdateInfo("studnb", lblBnum.Text)
                    ConditionForLevel(levelnum)
                    If levelnum = 1 Then
                        Exit Sub
                    End If
                    ShowMessageBox("Level " & levelnum - 1 & " Cleared!", Me, Color.White)
                    ShowMessageBox("Saved!", Me, Color.White)
                    lbllvl.Text = "Level " & levelnum
                    TimerPlayerTurn.Start()
                    kit.Back()
                    usebomb = 1
                    stopgetprivi = True
                    ctrwrong = 0 'reset
                    TimerStartGame.Start()
                    TimerHotkey.Start()
                    TimerHotkeyBack.Start()
                    FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
                End If
                usebomb = 1
                kit.Shake(pncbox, 25, 4, 1)
                tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))
                If levelnum = 2 Then
                    GeneratePic()
                End If
                ' TimerPlayerTurn.Start()
            End If
        End If
    End Sub
    Dim ctrsgame As Integer
    Private Sub TimerStartGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerStartGame.Tick
        ctrsgame += 1
        pnphbar.Width += 3
        pnchbarbase.Width -= 3
        If ctrsgame = 110 Then
            TickEffects()
            pnphbar.Width = 236
            pnchbarbase.Width = 0
            pnchbar.BackColor = Color.MediumSeaGreen
            pnphbar.BackColor = Color.MediumSeaGreen
            TimerStartGame.Stop()
            ctrsgame = 0

        End If
    End Sub

    Private Sub pnphbar_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnphbar.MouseDoubleClick
        pnphbar.Width += 10
    End Sub


    Private Sub TimerPause_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPause.Tick
        TimerPlayerTurn.Stop()
        TimerCompTurn.Stop()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BGMStop()
        TimerPause.Start()

        ShowSSMessageBox(Me, Color.WhiteSmoke)
        TimerPause.Stop()
        If pnplayer.BackColor = Color.MediumSeaGreen Then
            TimerPlayerTurn.Start()
        Else
            TimerCompTurn.Start()
        End If
        If levelnum = 1 Then
            BGMLevel1()
        ElseIf levelnum = 2 Then
            BGMLevel2()
        Else
            BGMLevel3()
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        BGMStop()
        TimerPause.Start()
        If Not GetInfo("studscore") < scoresum Then
            TimerPause.Stop()
            BoWMain.Show()
            BGMStop()
            Me.Close()
        Else
            ShowYesNoMessageBox(Me, Color.WhiteSmoke)
            TimerPause.Stop()
            If pnplayer.BackColor = Color.MediumSeaGreen Then
                TimerPlayerTurn.Start()
            Else
                If blx = False Then
                    Exit Sub
                End If
                TimerCompTurn.Start()

            End If
            If levelnum = 1 Then
                BGMLevel1()
            ElseIf levelnum = 2 Then
                BGMLevel2()
            Else
                BGMLevel3()
            End If
            tutorial = False
        End If
    End Sub


    Public Sub GeneratePic()
        Dim s As Integer = ListBox2.FindString(wordtouse(5))
        PictureBox1.ImageLocation = Application.StartupPath & "\imgitaly\" & Val(s) + 1 & ".png"
    End Sub
    Dim bl As Boolean = False
    Public Sub ConditionForLevel(ByVal i As Integer)
        If i = 1 Then
            TutMes.btnhint.Visible = False
            TutMes.btnTime.Visible = False
            TutMes.PNLETTERS.Visible = False
            TutMes.pnpoke.Visible = False
            TutMes.btnNitro.Visible = False
           
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Level 1 Tutorials", Me, Color.WhiteSmoke, True)
                ShowTutorialMessageBox(vbNewLine & vbNewLine & "Read and submit the missing letter in a term (5 letters) that shows in a given sentence", Me, Color.WhiteSmoke, False)
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            BGMLevel1()
            EnemyChange(Color.RoyalBlue, enemybluename.ToUpper, enemybluedetail)
            cfuel = 100
            cattack = 30
            pnpfuel.BackColor = Color.FromArgb(59, 91, 52)
            ' pnc.BackgroundImage = My.Resources.mystic
            pncc.BackgroundImage = My.Resources.squirtlex
            pnpp.BackgroundImage = My.Resources.bulbasor2
            pnbuddy.BackgroundImage = My.Resources.bulbasor2
            'pngamearea.BackgroundImage = My.Resources.grasses
            tbphrase.Visible = True
            PictureBox1.Visible = False
            tbphrase.Text = GetMeaning(ListBox2, ListBox3, wordtouse(5))
        ElseIf i = 2 Then
            TutMes.btnhint.Visible = False
            TutMes.btnTime.Visible = False
            TutMes.PNLETTERS.Visible = False
            TutMes.pnpoke.Visible = False
            TutMes.btnNitro.Visible = False
            ' ShowTutorialMessageBox(vbNewLine & vbNewLine & "Level 2 Tutorials", Me, Color.WhiteSmoke, True)


            ShowTutorialMessageBox(vbNewLine & vbNewLine & "Level 2 Tutorials", Me, Color.WhiteSmoke, True)
            ShowTutorialMessageBox(vbNewLine & vbNewLine & "Submit the term (5 letters) that shows in a given picture", Me, Color.WhiteSmoke, False)

            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            BGMLevel2()
            cfuel = 150
            EnemyChange(Color.RoyalBlue, enemyvioletname.ToUpper, enemyvioletdetail)
            cattack = 40
            '  pnc.BackgroundImage = My.Resources.valor
            pncc.BackgroundImage = My.Resources.rattatax
            pnpp.BackgroundImage = My.Resources.chanmander
            pnbuddy.BackgroundImage = My.Resources.chanmander
            ' pngamearea.BackgroundImage = My.Resources.fires

            tbphrase.Visible = False
            PictureBox1.Visible = True
            'MsgBox(Application.StartupPath & "\imgitaly\" & ListBox2.FindString(wordtouse(5)) & ".png")
            GeneratePic()

            'ElseIf i = 3 And bl = False Then
            '    BGMLevel3()
            '   cfuel = 200
            '   EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
            '  cattack = 45
            '  bl = True
            ''  If i = 3 And bl = True Then
            'HealthLifeBarVisible(True)
            ' End If
            'pnc.BackgroundImage = My.Resources.instinct
            ' pncc.BackgroundImage = My.Resources.psyduck
            ' pnpp.BackgroundImage = My.Resources.pikachu
            ' pngamearea.BackgroundImage = My.Resources.electrics

            ' ElseIf i = 3 Then
            ' BGMLevel3()
            ' cfuel = 200
            ' EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
            ' cattack = 70
            ' pnc.BackgroundImage = My.Resources.instinct
            'pncc.BackgroundImage = My.Resources.psyduck
            'pnpp.BackgroundImage = My.Resources.pikachu
            ' pngamearea.BackgroundImage = My.Resources.electrics

        Else
            TimerPlayerTurn.Stop()
            levelnum = 1
            UpdateInfo("studlevel", 3)
            UpdateInfo("studstage", 3)
            UpdateInfo("studhint", lblhintnum.Text)
            UpdateInfo("studta", lbltnum.Text)
            UpdateInfo("studnb", lblBnum.Text)
            s11 = 3
            ShowMessageBox("Stage " & 3 & " Cleared!", Me, Color.White)
            ShowTMessageBox(italy, Me, Color.WhiteSmoke)
            ShowMessageBox("Congratulations!", Me, Color.White)
            Me.Close()
            BGMStop()
            BoWMain.Show()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BGMStop()
        TimerPause.Start()
        BoWInstructions.ShowDialog()
        TimerPause.Stop()
        If pnplayer.BackColor = Color.RoyalBlue Then
            TimerPlayerTurn.Start()
        Else
            TimerCompTurn.Start()
        End If
    End Sub
End Class

