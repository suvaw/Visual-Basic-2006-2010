Public Class RESET_PASSWORD

    Private Sub Bsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsubmit.Click
        If TPassword.Text = TConPassword.Text Then
            MyProfile.Show()
            If MyProfile.Visible = False Then
                Me.Close()
                LMSG2.Text = ""
            End If
        Else
            LMSG2.Text = "Password Is Not Match!"
        End If
        TPassword.isPassword = False
        TConPassword.isPassword = False
        TPassword.Text = "Enter Your Password"
        TConPassword.Text = "Re-Type Password"
    End Sub


    Private Sub TPassword_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TPassword.Enter
        TPassword.isPassword = True
        TPassword.Text = ""
        LMSG2.Text = ""
    End Sub

    Private Sub TConPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TConPassword.Enter
        TConPassword.isPassword = True
        TConPassword.Text = ""
    End Sub
End Class