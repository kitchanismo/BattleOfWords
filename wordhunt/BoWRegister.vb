Public Class BoWregister

#Region "Register"

    Private Sub btnsubmit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnsubmit.KeyDown
        'Hit Enter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Validator() = True Then
                SavePlayer()
                ShowMessageBox("Account Successfully Saved!", Me, Color.WhiteSmoke)
                ' pnlogin.Visible = True
                'pnregister.Visible = False
                ' ShowMessageBox("You may now Login!", Me, Color.RoyalBlue)
                ClearData()
                ' pnfaculty.Visible = False
            Else
                BuzzEffects()
                ' lblnotif.ForeColor = Color.Brown
                lblnotif.Visible = Not Validator()
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        'Condition for Login
        If Validator() = True Then
            SavePlayer()
            ShowMessageBox("Account Successfully Saved!", Me, Color.WhiteSmoke)
            ' pnlogin.Visible = True
            ' pnregister.Visible = False
            '  ShowMessageBox("You may now Login!", Me, Color.WhiteSmoke)
            ' pnfaculty.Visible = False
            ClearData()
        Else
            BuzzEffects()
            ' lblnotif.ForeColor = Color.Brown
            lblnotif.Visible = Not Validator()
        End If
    End Sub
    Public Sub SavePlayer() 'Save Student Info.
        connected()
        sql = "INSERT INTO tblscore (studcname, studfname, studlname, studpword, studscore, studstage, studlevel, studhint, studta, studnb, studpokenum, studm1, studm2) VALUES ('" & tbcname.Text.ToLower & "','" & tbfname.Text.ToLower & "','" & tblname.Text.ToLower & "','" & tbpword.Text.ToLower & "',0 ,1, 1,3,3,3,5,0,0)"
        CommandDB()
        dr = cmd.ExecuteReader()
    End Sub

    Function Validator() As Boolean 'If login validated return true else false
        Dim i As Boolean = True
        If tbcname.Text = "" Or tbfname.Text = "" Or tblname.Text = "" Or tbpword.Text = "" Or tbrtpword.Text = "" Then
            lblnotif.Text = "*Fill-up All the Fields!"
            i = False
            Return i
            Exit Function
        End If
        If PlayerDoesExist(tbcname.Text) = True Then
            lblnotif.Text = "*Codename Exist!"
            tbcname.SelectAll()
            tbcname.Focus()

            i = False
            Return i
            Exit Function
        End If
        If tbpword.Text <> tbrtpword.Text Then
            lblnotif.Text = "*Password Not Match!"
            tbrtpword.SelectAll()
            tbrtpword.Focus()

            i = False
            Return i
            Exit Function
        End If
        If tbcname.TextLength < 5 Or tbcname.TextLength > 12 Then
            lblnotif.Text = "*Codename must be 5 to 12 Characters Only!"
            tbcname.SelectAll()
            tbcname.Focus()

            i = False
            Return i
            Exit Function
        End If
        If tbpword.TextLength < 5 Or tbpword.TextLength > 12 Then
            lblnotif.Text = "*Password must be 5 to 12 Characters Only!"
            tbpword.SelectAll()
            tbpword.Focus()

            i = False
            Return i
            Exit Function
        End If
        Return i
    End Function

    Public Function PlayerDoesExist(ByVal str As String) As Boolean 'Avoid duplicating codename
        connected()
        sql = "Select COUNT(*) FROM tblscore  WHERE studcname = '" & str & "'"
        CommandDB()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tbfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbfname.KeyPress, tblname.KeyPress
        'Press Letter Only
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Login"



    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmitl.Click
        If Loginfaculty() = True Then
            pname = tbcnamel.Text
            lblnotifl.Visible = False
            ShowMessageBox("Welcome! " & pname.ToUpper, Me, Color.WhiteSmoke)
            GetFacultyAccount()
            ClearData()
            pnregister.Visible = True
            pnfaculty.Visible = True
            pnlogin.Visible = False
            pnlogo.Visible = False
          
            Exit Sub
        End If

        If Login() = True Then
            pname = tbcnamel.Text
            lblnotifl.Visible = False
            ShowMessageBox("Welcome! " & pname.ToUpper, Me, Color.WhiteSmoke)
            ClearData()
            BoWMain.Show()
            Me.Hide()
        Else
            BuzzEffects()
            lblnotifl.Visible = True
        End If

    End Sub

    Public Sub ClearData()
        tbcnamel.Text = ""
        tbpwordl.Text = ""
        tbcname.Text = ""
        tbpword.Text = ""
        tbfname.Text = ""
        tblname.Text = ""
        tbpword.Text = ""
        tbrtpword.Text = ""
    End Sub

    Function Login() As Boolean 'function for login: if validated return true else false
        Dim i As Boolean
        If tbcnamel.Text = "" Then
            lblnotifl.Text = "*Codename is Empty!"
            tbcnamel.SelectAll()
            tbcnamel.Focus()

            i = False
            Exit Function
        End If
        If tbpwordl.Text = "" Then
            lblnotifl.Text = "*Password is Empty!"
            tbpwordl.SelectAll()
            tbpwordl.Focus()

            i = False
            Exit Function
        End If
        connected()
        sql = "SELECT * FROM tblscore WHERE studcname = '" & tbcnamel.Text.ToLower & "' AND studpword = '" & tbpwordl.Text.ToLower & "' "
        CommandDB()
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            i = True
        Else
            i = False
            lblnotifl.Text = "*Incorrect Username/Password! Please try again."

        End If
        Return i
    End Function

    Function Loginfaculty() As Boolean 'function for login: if validated return true else false
        Dim i As Boolean
        If tbcnamel.Text = "" Then
            lblnotifl.Text = "*Codename is Empty!"
            tbcnamel.SelectAll()
            tbcnamel.Focus()

            i = False
            Exit Function
        End If
        If tbpwordl.Text = "" Then
            lblnotifl.Text = "*Password is Empty!"
            tbpwordl.SelectAll()
            tbpwordl.Focus()

            i = False
            Exit Function
        End If
        connected()
        sql = "SELECT * FROM tblfacu WHERE facuuname = '" & tbcnamel.Text.ToLower & "' AND facupword = '" & tbpwordl.Text.ToLower & "' "
        CommandDB()
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            i = True
        Else
            i = False
            lblnotifl.Text = "*Incorrect Username/Password! Please try again."
         
        End If
        Return i
    End Function

    Private Sub tbcnamel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbcnamel.KeyDown, tbpwordl.KeyDown
        'Hit Enter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Loginfaculty() = True Then
                pname = tbcnamel.Text
                lblnotifl.Visible = False
                ShowMessageBox("Welcome! Faculty.".ToUpper, Me, Color.WhiteSmoke)
                GetFacultyAccount()
                ClearData()
                pnregister.Visible = True
                pnlogin.Visible = False
                pnfaculty.Visible = True
                pnlogo.Visible = False
             
                Exit Sub
            End If
            If Login() = True Then
                pname = tbcnamel.Text
                lblnotifl.Visible = False
                ShowMessageBox("Welcome! Student.".ToUpper, Me, Color.WhiteSmoke)
                ClearData()
                BoWMain.Show()
                Me.Hide()
            Else
                BuzzEffects()
                lblnotifl.Visible = True
            End If
        End If
    End Sub

    Private Sub tbpword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpwordl.TextChanged, tbcnamel.TextChanged, tbcname.TextChanged, tbfname.TextChanged, tblname.TextChanged, tbpword.TextChanged, tbrtpword.TextChanged
        lblnotifl.Visible = False
        lblnotif.Visible = False
    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pnregister.Visible = False
        pnlogin.Visible = True
        pnfaculty.Visible = False
        pnlogo.Visible = True
      
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        pnregister.Visible = True
        pnlogin.Visible = False
    End Sub

    Dim s As String
    Public Sub GetFacultyAccount()
        connected()
        sql = "SELECT * FROM tblfacu WHERE facuuname = '" & tbcnamel.Text.ToLower & "' "
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                tbfacuname.Text = dr.Item(1).ToString
                s = dr.Item(1).ToString
                tbfacupword.Text = dr.Item(2).ToString
            Loop
        End If

    End Sub

    Function ComparePassword() As Boolean
        Dim i As Boolean
        If tbfacurepword.Text = tbfacupword.Text Then
            i = False
        Else
            i = True
        End If

        Return i
    End Function
   
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComparePassword() = False Then
            UpdateFaculty()
            lblnotif2.Text = "Successfully Updated!"
            lblnotif2.Visible = True
            GetFacultyAccount()
            tbnewpword.Text = ""
            tbfacurepword.Text = ""
        Else
            lblnotif2.Text = "Password not Match!"
            lblnotif2.Visible = True
        End If
    End Sub


    Public Sub UpdateFaculty()
        connected()
        sql = "UPDATE tblfacu SET facupword = '" & tbnewpword.Text & "' , facuuname = '" & tbfacuname.Text & "' WHERE facuuname = '" & s & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ShowQYesNoMessageBox(Me, Color.WhiteSmoke)
        If blx = False Then
            End
            Exit Sub
        End If
       
    End Sub
 

    Private Sub BoWregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreventFlick()

    End Sub
    Public Sub PreventFlick()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
End Class