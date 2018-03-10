Imports System.IO
Imports System.Data.SqlClient
Module modGlobal
    Public WordList As New List(Of String)
    Private RandomClass As New Random()
    Public chinawords As String = "words/china.txt"
    Public chinawordsmeaning As String = "words/chinameaning.txt"
    Public greecewords As String = "words/greece.txt"
    Public greecewordsmeaning As String = "words/greecemeaning.txt"
    Public romeword As String = "words/rome.txt"
    Public romewordsmeanin As String = "words/romemeaning.txt"
    Public italywords As String = "words/italy.txt"
    Public italywordsmeaning As String = "words/italymeaning.txt"
    Public china As String = "Ying Zheng, the first emperor of the Qin Dynasty and the people began to construct the Great Wall"
    Public greece As String = vbNewLine & "The Acropolis is the most important ancient site in the Western world"
    Public italy As String = vbNewLine & "The Acropolis is the most important ancient site in the Western world"

    Public s11 As Integer


    Public DictionaryWords As String = "words/WordList.txt"
    Public CusMes As New CustomMsgBox
    Public ChoMes As New ChooseMsgBox
    Public seMes As New SEMsgBox
    Public YNMes As New YEsNoMsgBox
    Public QYNMes As New QYEsNoMsgBox
    Public M1Mes As New Mini1MsgBox
    Public tMes As New TriviaMsgBox
    Public HMes As New helpMsgBox
    Public TutMes As New TutorialMsgBox
    Public badWord As String = "words/BadWords.txt"
    Public kit As New kitchanismo.betsayda
    Public rn As New betsayda.kitchanismo
    Public TriviaWords As String = "words/TriviaList.txt"
    Public ScoreStage1 As Integer
    Public sql As String
    Public togmusic As Boolean = True
    Public togSE As Boolean = True
    Public startpath As String = Application.StartupPath
    Public pname As String = "..."
    Public blx As Boolean
    Public bly As Boolean
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public con As New SqlConnection
    Public strgender As String
    Public tutorial As Boolean = True

    Public pbt As Boolean = True
    Public pbm As Boolean = True
    Public pbn As Boolean = True
    Public pbb As Boolean = True
    Public pbtt As Boolean = True
    Public Sub connected()
        With con
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\savegame\dbscore.mdf;Integrated Security=True;Connect Timeout=30"
            .Open()
        End With
    End Sub
    Sub CommandDB()
        cmd = New SqlCommand(sql, con)
    End Sub


    Public Function GetMeaning(ByVal lv2 As ListBox, ByVal lv3 As ListBox, ByVal str As String) As String
        Dim i As String
        Dim y As Integer = lv2.FindString(str).ToString
        i = lv3.Items.Item(y)
        Return i
    End Function
    Public Sub ShowMessageBox(ByVal str As String, ByVal e As Form, ByVal col As Color)
        CusMes.Width = e.Width
        CusMes.tbmessage.Text = str
        CusMes.BackColor = col
        CusMes.tbmessage.BackColor = col
        frmTransparent.Show()
        CusMes.ShowDialog()
    End Sub
    Public Sub ShowHelpMessageBox(ByVal str As String, ByVal e As Form, ByVal col As Color)
        HMes.Width = e.Width
        'HMes.tbmessage.Text = str
        HMes.BackColor = col
        'HMes.tbmessage.BackColor = col
        frmTransparent.Show()
        HMes.ShowDialog()
    End Sub
    Public Sub ShowTutorialMessageBox(ByVal str As String, ByVal e As Form, ByVal col As Color, ByVal bl As Boolean)
    
        TutMes.LinkLabel2.Visible = bl
        TutMes.Width = e.Width
        TutMes.tbmessage.Text = str
        TutMes.BackColor = col
        TutMes.tbmessage.BackColor = col
        frmTransparent.Show()
        '   Try
        TutMes.ShowDialog()
        '   Catch
        '  End Try
        TutMes.LinkLabel2.Visible = bl
    End Sub
    Public Sub ShowTMessageBox(ByVal str As String, ByVal e As Form, ByVal col As Color)
        tMes.Width = e.Width
        tMes.tbmessage.Text = str
        tMes.BackColor = col
        tMes.tbmessage.BackColor = col
        frmTransparent.Show()
        tMes.ShowDialog()
    End Sub
    Public Sub M1ShowMessageBox(ByVal str As String, ByVal e As Form, ByVal col As Color)
        M1Mes.Width = e.Width
        M1Mes.tbmessage.Text = str
        M1Mes.BackColor = col
        M1Mes.tbmessage.BackColor = col
        frmTransparent.Show()
        M1Mes.ShowDialog()
    End Sub

    Public Sub ShowChooseMessageBox(ByVal e As Form, ByVal col As Color)
        ChoMes.Width = e.Width
        ChoMes.BackColor = col
        frmTransparent.Show()
        ChoMes.ShowDialog()
    End Sub
    Public Sub ShowYesNoMessageBox(ByVal e As Form, ByVal col As Color)
        YNMes.Width = e.Width
        YNMes.BackColor = col
        frmTransparent.Show()
        YNMes.ShowDialog()
    End Sub
    Public Sub ShowQYesNoMessageBox(ByVal e As Form, ByVal col As Color)
        QYNMes.Width = e.Width
        QYNMes.BackColor = col
        frmTransparent.Show()
        QYNMes.ShowDialog()
    End Sub
    Public Sub ShowSSMessageBox(ByVal e As Form, ByVal col As Color)
        seMes.Width = e.Width
        seMes.BackColor = col
        frmTransparent.Show()
        seMes.ShowDialog()
    End Sub


    Function GetInfo(ByVal i As String) As Integer
        connected()
        Dim str As Integer
        Dim cname As String = pname.ToLower
        sql = "SELECT " & i & " FROM tblScore where studcname = '" & cname & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString
            Loop
        End If
        Return str
    End Function

    Function GetGen(ByVal i As String) As String
        connected()
        Dim str As String
        Dim cname As String = pname.ToLower
        sql = "SELECT " & i & " FROM tblScore where studcname = '" & cname & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString
            Loop
        End If
        Return str
    End Function

    Public Sub UpdateInfo(ByVal i As String, ByVal j As Integer)
        connected()
        Dim cname As String = pname.ToLower
        sql = "UPDATE tblScore SET " & i & " = " & j & " WHERE studcname = '" & cname & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateGen(ByVal i As String, ByVal j As String)
        connected()
        Dim cname As String = pname.ToLower
        sql = "UPDATE tblScore SET " & i & " = '" & j & "' WHERE studcname = '" & cname & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub


    Public stopremoveletter As Boolean = False
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


    Public Function btnNumber(ByVal btn As Button) As Integer 'function to get the number in each letter
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
    Public Sub xChooseWord(ByVal Word As Label, ByVal WordLength As Integer)
        Try
            Dim TextFile As New StreamReader("words\rome.txt")
            While TextFile.EndOfStream = False
                WordList.Add(TextFile.ReadLine())
            End While

            For Counter As Integer = WordList.Count - 1 To 0 Step -1
                If WordList(Counter).Length <> WordLength Then
                    WordList.RemoveAt(Counter)
                End If
            Next
            Word.Text = WordList(RandomClass.Next(0, WordList.Count)).ToUpper
        Catch ex As Exception
            MessageBox.Show("Error:" & ControlChars.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Public Sub Chooseword(ByVal _word As Label)
        'StreamReader to read our files
        Dim ioFile As New StreamReader("words\rome.txt")
        'Generic list for holding the lines
        Dim lines As New List(Of String)
        'Random class to generate our random number
        Dim rnd As New Random()
        'Variable to hold our random line number
        Dim line As Integer
        'Now we loop through each line of our text file
        'adding each line to our list
        While ioFile.Peek <> -1
            lines.Add(ioFile.ReadLine())
        End While
        'Now we need a random number
        line = rnd.Next(lines.Count + 1)
        'Now write out the random line to the TextBox
        _word.Text = (lines(line).Trim()).ToUpper
        'Close our StreamReader
        ioFile.Close()
        'Dispose of the instance
        ioFile.Dispose()
    End Sub

   
End Module
