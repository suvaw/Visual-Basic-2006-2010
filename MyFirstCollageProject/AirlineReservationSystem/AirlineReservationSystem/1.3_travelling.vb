Public Class travelling

    Private Sub Bnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnext.Click, BClear.Click
        P3.Visible = False
        P4.Visible = True
    End Sub

    Private Sub travelling_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        P3.Visible = True
        P4.Visible = False
        P2a.Visible = False
    End Sub

    Private Sub Bsignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsignup.Click
        MemberRegistation.Show()
        If MemberRegistation.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub LL1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LL1.LinkClicked
        ForgetPassword.Show()
        If ForgetPassword.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        P2.Visible = False
        P2a.Visible = True
    End Sub

    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click, Bfclear.Click
        add_ons.Show()
        If add_ons.Visible Then
            Me.Hide()
        End If
    End Sub
End Class