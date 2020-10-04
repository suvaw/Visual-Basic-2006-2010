Public Class add_ons

    Private Sub BunifuFlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton4.Click
        Seat.Show()
        If Seat.Visible Then
            Me.Hide()
        End If
    End Sub

End Class