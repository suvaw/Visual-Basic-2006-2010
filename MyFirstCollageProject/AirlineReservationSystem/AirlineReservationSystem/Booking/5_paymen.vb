Public Class payment

    Dim i As Integer = 0

    Private Sub payment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'call Panel Loading function
        pload(True, False, False, False, False, False, False)

        'call picture Loading function
        picload(False, False, False, False, False)

    End Sub

    'declear wallet checking function
    Private Sub walletchk(ByVal ck As Boolean, ByVal ck1 As Boolean)
        Cb2.Checked = ck
        Cb1.Checked = ck1
    End Sub

    'declear panel loading function 
    Private Sub pload(ByVal v1 As Boolean, ByVal v2 As Boolean, ByVal v3 As Boolean, ByVal v4 As Boolean, ByVal v5 As Boolean, ByVal v6 As Boolean, ByVal v7 As Boolean)
        Pwelcome.Visible = v1
        Pcomplite.Visible = v2
        PCreditCard.Visible = v3
        Pupi.Visible = v4
        Pvoucher.Visible = v5
        Pnetbanking.Visible = v6
        Pwallet.Visible = v7
    End Sub

    'declear waiting picture loading function
    Private Sub picload(ByVal p1 As Boolean, ByVal p2 As Boolean, ByVal p3 As Boolean, ByVal p4 As Boolean, ByVal p5 As Boolean)
        PictureBox1.Visible = p1
        PictureBox2.Visible = p2
        PictureBox3.Visible = p3
        PictureBox4.Visible = p4
        PictureBox5.Visible = p5
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        'call Panel Loading function
        pload(False, False, True, False, False, False, False)

    End Sub

    Private Sub BunifuThinButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton24.Click
        'call Panel Loading function
        pload(False, False, False, False, False, False, True)

    End Sub

    Private Sub BunifuThinButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton25.Click
        'call Panel Loading function
        pload(False, False, False, False, True, False, False)

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        'call Panel Loading function
        pload(False, False, True, False, False, True, False)

    End Sub

    Private Sub BunifuThinButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton23.Click
        'call Panel Loading function
        pload(False, False, False, True, False, False, False)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 100 Then
            'stop timer
            Timer1.Stop()

            'call Panel Loading function
            pload(False, True, False, False, False, False, False)

            'timer variable value initialize
            i = 0
        End If
    End Sub


    Private Sub Cb1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb1.OnChange
        'call wallet checking function
        walletchk(False, True)
    End Sub
    Private Sub Cb2_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb2.OnChange
        'call wallet checking function
        walletchk(True, False)

    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bwsubmit.Click, Bnbcancle.Click, Bvsubmit.Click, Bupiubmit.Click, Bsubmit.Click
        'timer start 
        Timer1.Start()

        'call Picture Loading function
        picload(True, True, True, True, True)
    End Sub

    Private Sub Paynext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paynext.Click
        MyProfile.Show()
        Me.Close()
    End Sub
End Class
