Public Class Checkin

    Private Sub Checkin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        P1.Visible = True
        P2.Visible = False
    End Sub

    Private Sub Bcheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcheck.Click
        P1.Visible = False
        P2.Visible = True
    End Sub

    Private Sub Bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclose.Click
        Me.Close()
    End Sub
End Class
