Imports System.Runtime.InteropServices
Public Class BoW2Player

#Region "Declarations"
    Dim wordlenght As Integer
    Dim rambleletters As String
    Dim str As String
    Dim n As Integer = 0
    Dim arTemp() As String = Nothing '// used to get all lines from TextBox.
    Dim sTemp As String = Nothing '// used to add lines back to TextBox.
    Dim enemybluename As String = "Squirtle"
    Dim enemyvioletname As String = "Rattata"
    Dim enemyredname As String = "Snorlax"
    Dim enemybluedetail As String = "'He Loves Blueberry'"
    Dim enemyvioletdetail As String = "   'He Loves Ube'"
    Dim enemyreddetail As String = "  'He Loves Poncan'"
    Dim enemybluecolor As Color = Color.RoyalBlue
    Dim enemyvioletcolor As Color = Color.DarkViolet
    Dim enemyredcolor As Color = Color.IndianRed
    Dim lines() As String
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short 'for hotkey declaration
#End Region

#Region "Form Load"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTransparent.Show()
        EnterPName()
        ShowMessageBox("Create Greek History Terms  (3 to 5 Letters)!", Me, Color.RoyalBlue)

        TimerPlayer1Turn.Start() ' start the thinking time 30 seconds
        SeperateLetter(GenerateWords()) 'seperate each letter in btn
        AssignButtonNumber() 'assigning number in btn 
        lblcname.Text = enemybluename
        lblcdetails.Text = enemybluedetail
        lines = IO.File.ReadAllLines(Application.StartupPath & "\" & DictionaryWords) 'read all words
        ListBox2.Items.AddRange(lines) 'add words to listbox

        TimerHotkey.Start() 'start of hotkey for letter
        TimerHotkeyBack.Start() 'start of hotkey for backspace
        CusMes.Width = Me.Width 'assigning Cusmes width to this form


        FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
    End Sub
#End Region

#Region "Buttons"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClickEffects()
        FuelBarCondition(lbl1)
        AppendLetter(Button1, lbl1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClickEffects()
        FuelBarCondition(lbl2)
        AppendLetter(Button2, lbl2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ClickEffects()
        FuelBarCondition(lbl3)
        AppendLetter(Button3, lbl3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ClickEffects()
        FuelBarCondition(lbl4)
        AppendLetter(Button4, lbl4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ClickEffects()
        FuelBarCondition(lbl5)
        AppendLetter(Button5, lbl5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ClickEffects()
        FuelBarCondition(lbl6)
        AppendLetter(Button6, lbl6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ClickEffects()
        FuelBarCondition(lbl7)
        AppendLetter(Button7, lbl7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ClickEffects()
        FuelBarCondition(lbl8)
        AppendLetter(Button8, lbl8)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ClickEffects()
        FuelBarCondition(lbl9)
        AppendLetter(Button9, lbl9)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ClickEffects()
        FuelBarCondition(lbl10)
        AppendLetter(Button10, lbl10)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ClickEffects()
        FuelBarCondition(lbl11)
        AppendLetter(Button11, lbl11)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ClickEffects()
        FuelBarCondition(lbl12)
        AppendLetter(Button12, lbl12)
    End Sub

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        ClickEffects()
        GuessTheWord()
    End Sub
    Public Sub GuessTheWord() 'Player will Guess
        Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text
        If str.Length < 3 Then '3-5 char only
            'FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "3-5 Characters only!", 2000)
            Exit Sub
        End If
        ResetTime() 'reset time to 30
        If ListBox2.Items.Contains(str.ToLower) Then 'if guessword validate

            Dim i As Integer
            pmovectr += ComputeMovePoints() * nfuel 'distance reach
            i = ComputeMovePoints() * nfuel
            TimerPlayer1Turn.Stop()
            TimerHotkey.Stop()
            TimerHotkeyBack.Stop()
            'start to move pbox
            If pnplayer.BackColor = Color.MediumSeaGreen Then
                TimerPlayer1Move.Start()
            Else
                TimerPlayer2Move.Start()
            End If


            pnguessword.BackColor = Color.MediumSeaGreen
            If (i > 49 And i < 101) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Good!", 3000)
            ElseIf (i > 101 And i < 201) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Nice!", 3000)
            ElseIf (i > 201 And i < 1000) Then
                FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Success, "Excellent!", 3000)
            End If
            pnplayer.BackColor = Color.MediumSeaGreen
            pncomputer.BackColor = Color.LightSlateGray
            ReplaceWord() ' add another word
            ResetLetterNumberColor(Color.LightGray) 'color of btn number
            AssignButtonNumber() 'assigning number in btn 
            BtnGuessWordVisible(False)


            EnabledButton(False)
            CarEffects()

        Else
            BuzzEffects()
            pnguessword.BackColor = Color.PaleVioletRed
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Wrong!", 4000)

            TimerPlayer1Turn.Stop()
            TimerHotkeyBack.Start()
            TimerHotkey.Start()
            pnpfuel.Width = 0

            pctr = 30
            TimerPlayer2Turn.Start()
            pnplayer.BackColor = Color.LightSlateGray
            pncomputer.BackColor = Color.MediumSeaGreen

            ReplaceWord() ' add another word
            ResetLetterNumberColor(Color.LightGray) 'color of btn number
            AssignButtonNumber() 'assigning number in btn 
            BtnGuessWordVisible(False)
        End If
    End Sub


    Private Sub btnl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl1.Click
        ClickEffects()
        pnpfuel.Width = 0 ' reset fuel to 0
        Btnl1Remove()

    End Sub

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

    Private Sub btnl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl2.Click
        ClickEffects()
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg2) * nfuel) - Val(FuelBar(lblg3) * nfuel) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel) 'minus fuel
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
    End Sub
    Private Sub btnl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl3.Click
        ClickEffects()
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg3) * nfuel) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel)
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
    End Sub

    Private Sub btnl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl4.Click
        ClickEffects()
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel)
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
    End Sub


    Private Sub btnl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl5.Click
        ClickEffects()
        pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg5) * nfuel)
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

        stopremoveletter = False
    End Sub

    Private Sub btnshuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshuffle.Click
        ClickEffects()
        ShuffleWords()
    End Sub

    Private Sub Buttonreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonreset.Click

        ResetGame()
    End Sub


    Private Sub btnpause_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpause.Click
        If btnpause.Text = "Pause" Then
            TimerPlayer1Turn.Stop()
            btnpause.Text = "Resume"
        Else
            TimerPlayer1Turn.Start()
            btnpause.Text = "Pause"
        End If
    End Sub

#End Region

#Region "Main Methods and Functions"



    Dim levelnum As Integer
    Dim cfuel As Integer 'initial enemy fuel
    Dim nfuel As Integer = 1
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

    Public Sub FuelBarCondition(ByVal lbl As Label)
        If btnl5.Text = "" Then 'condition if btn word is not completed
            pnpfuel.Width = ((FuelBar(lbl) * nfuel) + pnpfuel.Width) 'fuelbar = selected fuelbarnum * nitro + fuelbar width
        End If
    End Sub

    Public Sub EnterPName()
        lblpname.Text = pname.ToUpper
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


    Dim w1, w2, w3 As String
    Function GenerateWords() As String 'get 3 words from list and combine
        Dim word1 As String = ""
        Dim word2 As String = ""
        Dim word3 As String = ""

        kit.ChooseWord(lblwords, 5, DictionaryWords)
        word1 = lblwords.Text
        ListBox1.Items.Add(word1)

        kit.ChooseWord(lblwords, 4, DictionaryWords)
        word2 = lblwords.Text
        ListBox1.Items.Add(word2)

        kit.ChooseWord(lblwords, 3, DictionaryWords)
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

    Function wordtouse(ByVal i As Integer) As String 'function for which word to use
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

    Public Sub ReplaceWordComputerAnswer(ByVal i As Integer) 'computer answer
        Dim str As String = btnl1.Text & btnl2.Text & btnl3.Text & btnl4.Text & btnl5.Text
        Dim wordreplace As String
        strword = ""
        RemoveWord(str.ToLower)
        kit.ChooseWord(lblNewWord, i, DictionaryWords)
        wordreplace = lblNewWord.Text
        lblwords.Text = strword & wordreplace
        TextBox1.Text = TextBox1.Text & "+" & wordreplace
        ListBox1.Items.Remove(str.ToLower)
        ListBox1.Items.Add(wordreplace)
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

    Public Sub ReplaceWord() 'player answer
        ListBox1.Items.Clear()
        SeperateLetter(GenerateWords)
        btnl1.Text = ""
        btnl2.Text = ""
        btnl3.Text = ""
        btnl4.Text = ""
        btnl5.Text = ""
        ResetButton()
    End Sub

  

    Public Sub LabelVisible(ByVal bool As Boolean) 'label number will visible
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

    Function ComputeMovePoints() As Integer 'Compute sum all letter to be use
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

    Function FuelBar(ByVal lbl As Label) As Integer 'assigning distance of letter use for enemy
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

    Public Sub EnabledButton(ByVal bool As Boolean) 'Enabling buttons
        pnguessword.Enabled = bool
        pnrambleletter.Enabled = bool
        btnGuess.Enabled = bool
        btnshuffle.Enabled = bool

    End Sub

    Function ComputerAnswer() As String 'function getting the word lenght of computer answer
        Dim j As String = ""
        If levelnum = 1 Then
            j = wordtouse(3)
        ElseIf levelnum = 2 Then
            j = wordtouse(4)
        ElseIf levelnum = 3 Then
            j = wordtouse(5)
        End If
        Return j
    End Function

    Private Sub ComputerTurn(ByVal str As String) 'computer will answer

    End Sub

    Dim strshuffle As String


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
        pnpbox.Left = 1
        pncbox.Left = 1
        pmovectr = 0
        cmovectr = 0
        ctr = 0
        EnabledButton(True)
        TimerPlayer1Turn.Stop()

        ResetTime()
        AssignButtonNumber()
        ResetLetterNumberColor(Color.LightGray)
        pnpfuel.Width = 0
        pnguessword.BackColor = Color.LightSlateGray
        pnplayer.BackColor = Color.MediumSeaGreen
        pncomputer.BackColor = Color.LightSlateGray
        lblg1.Text = ""
        lblg2.Text = ""
        lblg3.Text = ""
        lblg4.Text = ""
        lblg5.Text = ""
    End Sub

    Public Sub ResetTime() 'reset time to 30
        pctr = 30
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

    Public Sub EnemyChange(ByVal col As Color, ByVal str As String, ByVal strx As String) 'Enemy color
        pncbox.BackColor = col
        pnchead.BackColor = col
        pncbody.BackColor = col
        pnpfuel.BackColor = col
        lblcname.Text = str
        lblcdetails.Text = strx
    End Sub




    Public Sub FuelColor(ByVal i As Integer)
        If i = 1 Then
            EnemyChange(enemybluecolor, enemybluename, enemybluedetail)
            cfuel = 100
        ElseIf i = 2 Then

            cfuel = 120
            EnemyChange(enemyvioletcolor, enemyvioletname, enemyvioletdetail)
        ElseIf i = 3 Then
            cfuel = 140
            EnemyChange(enemyredcolor, enemyredname, enemyreddetail)
        End If
    End Sub



#End Region

#Region "Timers"
    Dim pctr As Integer = 30
    Dim ctr As Integer






    Private Sub TimerPlayerTurn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayer1Turn.Tick
        pctr -= 1
        lbltime.Text = pctr
        If pctr = 27 Then
            pnguessword.BackColor = Color.LightSlateGray
        End If
        If pctr = 10 Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Warning! You're about to lose your turn.", 5000)
        End If
        If pctr = 0 Then 'when timer reach
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Times up! Sorry! You lost your turn.", 5000)
            TimerPlayer1Turn.Stop()
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            pctr = 30
            TimerPlayer2Turn.Start()
            pnplayer.BackColor = Color.LightSlateGray
            pncomputer.BackColor = Color.MediumSeaGreen
        End If

    End Sub
    Dim pmovectr As Integer
    Private Sub TimerPlayerMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayer1Move.Tick
        pnpbox.Left += nfuel
        pnpfuel.Width -= nfuel
        ' EnabledButton(False)
        If pnpbox.Left >= pmovectr Then 'stop to move the player box
            StopEffects()
            TimerPlayer1Move.Stop()
            EnabledButton(True)
            kit.Shake(pnpbox, 25, 4, 1)
            pnpfuel.Width = 0
            pnguessword.BackColor = Color.LightSlateGray
            FlatAlertBox1.Visible = False
            nfuel = 1 'times 1

            TimerPlayer1Turn.Stop()
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            pctr = 30
            TimerPlayer2Turn.Start()
            pnplayer.BackColor = Color.LightSlateGray
            pncomputer.BackColor = Color.MediumSeaGreen
            Exit Sub
        End If
        If pnpbox.Left >= pngamearea.Width - 60 Then 'when the player reach the finish line
            ExplosionEffects()
            BGMStop()
            kit.Forward(pnc, pnc.Location.X, (pp.Width - pnc.Width) + 360)
            TimerPlayer1Move.Stop()
            TimerPlayer1Turn.Stop()

            'lbllevel.Text = levelnum

        

            nfuel = 1
            ResetGame()
            kit.Shake(pnpbox, 25, 4, 1)
           
            ShowMessageBox("Level " & levelnum - 1 & " Cleared!", Me, Color.RoyalBlue)
            ShowMessageBox("Saved!", Me, Color.MediumSeaGreen)


            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
            TimerPlayer1Turn.Start()
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            kit.Back()
        End If
    End Sub

   
    Private Sub TimerPlayer2Turn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayer2Turn.Tick
        pctr -= 1
        lbltime2.Text = pctr
        If pctr = 27 Then
            pnguessword.BackColor = Color.LightSlateGray
        End If
        If pctr = 10 Then
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Warning! You're about to lose your turn.", 5000)
        End If
        If pctr = 0 Then 'when timer reach
            BuzzEffects()
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "Times up! Sorry! You lost your turn.", 5000)
            TimerPlayer2Turn.Stop()
            TimerHotkey.Stop()
            TimerHotkeyBack.Stop()
            pctr = 30
            TimerPlayer1Turn.Start()
            pnplayer.BackColor = Color.MediumSeaGreen
            pncomputer.BackColor = Color.LightSlateGray
        End If
    End Sub
    Dim cmovectr As Integer
    Private Sub TimerPlayer2Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayer2Move.Tick
        pncbox.Left += 1
        pnpfuel.Width -= 1
        If pncbox.Left >= cmovectr Then 'stop to move the computer box
            TimerPlayer2Move.Stop()
            TimerHotkey.Start()
            TimerPlayer1Turn.Start()
            TimerHotkeyBack.Start()
            kit.Shake(pncbox, 25, 4, 1)
            pnpfuel.Width = 0
            EnabledButton(True)
            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, pname.ToUpper & " is now your turn!", 5000)
            StopEffects()
            Exit Sub
        End If
        If pncbox.Left >= pngamearea.Width - 60 Then 'when the computer reach the finish line
            ExplosionEffects()
            BGMStop()
            TimerPlayer2Move.Stop()

            TimerPlayer1Turn.Stop()
            ResetGame()
            kit.Shake(pncbox, 25, 4, 1)
            kit.Forward(pnp, pnp.Location.X, (pc.Width - pnp.Width) - 1000)
            ShowMessageBox("You Lost!", Me, Color.LightCoral)
            ShowChooseMessageBox(Me, Color.RoyalBlue)


            kit.Back()
            TimerPlayer1Turn.Start()
            TimerHotkey.Start()
            TimerHotkeyBack.Start()
            nfuel = 1

            FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, "Level " & levelnum & ". Start", 3000)
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
            AppendLetter(btn, lbl)
            lbl.Visible = False
            btn.Visible = False
            stopremoveletterhk = True
            FuelBarCondition(lbl)
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
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg2) * nfuel) - Val(FuelBar(lblg3) * nfuel) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel) 'minus fuel
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
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg3) * nfuel) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel)
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
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg4) * nfuel) - Val(FuelBar(lblg5) * nfuel)
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
            pnpfuel.Width = Val(pnpfuel.Width) - Val(FuelBar(lblg5) * nfuel)
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

    Private Sub lbltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltime.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub



    Private Sub TimerPause_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPause.Tick
        TimerPlayer1Turn.Stop()

    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BGMStop()
        TimerPause.Start()

        ShowSSMessageBox(Me, Color.RoyalBlue)
        TimerPause.Stop()
        If pnplayer.BackColor = Color.MediumSeaGreen Then
            TimerPlayer1Turn.Start()
        Else
            'TimerCompTurn.Start()
        End If
       
    End Sub

 
End Class

