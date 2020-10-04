Public Class payment

    Dim i As Integer = 0
    Private Sub BunifuThinButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paynext.Click
        MyProfile.Show()
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        Pwelcome.Visible = False
        Pcomplite.Visible = False
        PCreditCard.Visible = True
        Pupi.Visible = False
        Pvoucher.Visible = False
        Pnetbanking.Visible = False
        Pwallet.Visible = False
    End Sub

    Private Sub BunifuThinButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton24.Click
        Pwelcome.Visible = False
        Pcomplite.Visible = False
        PCreditCard.Visible = False
        Pupi.Visible = False
        Pvoucher.Visible = False
        Pnetbanking.Visible = False
        Pwallet.Visible = True
    End Sub

    Private Sub BunifuThinButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton25.Click
        Pwelcome.Visible = False
        Pcomplite.Visible = False
        PCreditCard.Visible = False
        Pupi.Visible = False
        Pvoucher.Visible = True
        Pnetbanking.Visible = False
        Pwallet.Visible = False
    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Pwelcome.Visible = False
        Pcomplite.Visible = False
        PCreditCard.Visible = False
        Pupi.Visible = False
        Pvoucher.Visible = False
        Pnetbanking.Visible = True
        Pwallet.Visible = False
    End Sub

    Private Sub BunifuThinButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton23.Click
        Pwelcome.Visible = False
        Pcomplite.Visible = False
        PCreditCard.Visible = False
        Pupi.Visible = True
        Pvoucher.Visible = False
        Pnetbanking.Visible = False
        Pwallet.Visible = False
    End Sub

    Private Sub payment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Pwelcome.Visible = True
        Pcomplite.Visible = False
        PCreditCard.Visible = False
        Pupi.Visible = False
        Pvoucher.Visible = False
        Pnetbanking.Visible = False
        Pwallet.Visible = False

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 100 Then
            Pwelcome.Visible = False
            Pcomplite.Visible = True
            PCreditCard.Visible = False
            Pupi.Visible = False
            Pvoucher.Visible = False
            Pnetbanking.Visible = False
            Pwallet.Visible = False
            i = 0
        End If
    End Sub


    Private Sub Cb1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb1.OnChange
        Cb2.Checked = False
        Cb1.Checked = True
    End Sub
    Private Sub Cb2_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb2.OnChange
        Cb2.Checked = True
        Cb1.Checked = False
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bwsubmit.Click, Bnbcancle.Click, Bvsubmit.Click, Bupiubmit.Click, Bsubmit.Click
        Timer1.Start()
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
    End Sub
End Class
