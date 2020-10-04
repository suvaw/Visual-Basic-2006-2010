Public Class Seat

    Private Sub Seat_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If add_ons.Visible = False Then
            'MsgBox("working")
            add_ons.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        payment.Show()
        If payment.Visible Then
            Me.Hide()
        End If
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
