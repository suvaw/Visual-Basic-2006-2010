Imports System.Text.RegularExpressions
Public Class Login

    Function EmailCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        If Tinput.Text = "admin@gamil.com" Or Tpassword.Text = "admin" Then
            logindata = True
            usernamedata = Tinput.Text
            MyProfile.Show()
            Me.Hide()
        Else
            Lwarning.ForeColor = Color.Black
            Lwarning.BackColor = Color.Red
            Lwarning.Text = "Username or Password is not match!"
        End If
    End Sub


    Private Sub LForgetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LForgetPassword.Click
        ForgetPassword.Show()
        Me.Close()
    End Sub

    Private Sub BSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSignup.Click
        MemberRegistation.Show()
        If MemberRegistation.Visible Then
            Me.Hide()
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
End Class