Imports System.Text.RegularExpressions                          'Imports system textregular Expression
Public Class Login
    Dim access As New DBControls                                'DB object create
    Function EmailCheck(ByVal emailAddress As String) As Boolean

        'Email Checking Patten Declear
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern) 'email check

        'Email address check success
        If emailAddressMatch.Success Then                       'check email address
            Return True                                         'Return Value
        Else
            Return False                                        'Return Value
        End If
    End Function

    'Button click event
    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        MainWindows.Transition1.ShowSync(loading)               'Form open
        access.ExecQuery("SELECT phone FROM [Admin] where email='" & Tinput.Text & "' and password='" & Tpassword.Text & "'")
        If access.DBDT.Rows.Count <> 0 Then                     'check login
            logindata = True                                    'login data store
            usernamedata = Tinput.Text                          'username data store
            MainWindows.Transition2.ShowSync(MyProfile)         'Form open
            Me.Close()
        Else
            Lwarning.ForeColor = Color.Black
            Lwarning.BackColor = Color.Red
            Lwarning.Text = "Username or Password is not match!"
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(Tinput, "Enter Worng User Name and Password")
            ErrorProvider2.SetError(Tpassword, "Enter Worng User Name and Password")
        End If
        loading.Close()
    End Sub


    Private Sub LForgetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LForgetPassword.Click
        ForgetPassword.Show()
        Me.Close()
    End Sub

    Private Sub BSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSignup.Click
        MainWindows.Transition2.ShowSync(MemberRegistation)
        If MemberRegistation.Visible Then
            Me.Close()
        End If

    End Sub

    'event calling
    Private Sub Tpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tpassword.Enter
        Tpassword.Text = ""
        Tpassword.isPassword = True
    End Sub
    Private Sub Tinput_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tinput.KeyPress
        Dim MyEmail As String = Tinput.Text
        If EmailCheck(MyEmail) = True Then
            ErrorProvider2.Clear()
            Lwarning.Text = "Valid Email!"
            ErrorProvider1.SetError(Tinput, "Vaild mail")
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(Tinput, "Invaild mail")
            Lwarning.Text = "Invalid Email!"
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        background.Show()
        ExitPopup.Show()
        ExitPopup.TopMost = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MainWindows.Transition2.ShowSync(MainWindows)
        If MainWindows.Visible Then
            Me.Close()
        End If
    End Sub
End Class