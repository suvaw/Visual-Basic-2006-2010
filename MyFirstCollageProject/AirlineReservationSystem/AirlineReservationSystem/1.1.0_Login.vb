Public Class Login

    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        Me.Hide()
        MyProfile.Show()
    End Sub

    
    Private Sub LForgetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LForgetPassword.Click
        Me.Hide()
        ForgetPassword.Show()
    End Sub

    Private Sub BSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSignup.Click
        MemberRegistation.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class