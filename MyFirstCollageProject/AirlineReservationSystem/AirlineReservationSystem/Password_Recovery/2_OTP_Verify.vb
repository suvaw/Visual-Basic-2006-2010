Public Class OTP_Verify
    Dim rdata As New Random

    Private Sub OTP_Verify_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        i1.Focus()
        Breset.Visible = False
        T1.Start()
    End Sub


    Private Sub i1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles i1.TextChanged, i2.TextChanged, i3.TextChanged, i4.TextChanged
        If i1.Text.Length = 1 Then
            i2.Focus()
        End If
        If i2.Text.Length = 1 Then
            i3.Focus()
        End If
        If i3.Text.Length = 1 Then
            i4.Focus()
        End If
        If i4.Text.Length = 1 Then
            Bverify.Focus()
        End If
    End Sub


    Private Sub Bverify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bverify.Click
        If data1.ToString = i1.Text + i2.Text + i3.Text + i4.Text Then
            RESET_PASSWORD.Show()
            If RESET_PASSWORD.Visible Then
                Me.Close()
                Mobile.Close()
            End If
        Else
            Lmassage.Text = "Worng OTP .Try Again!"
        End If

    End Sub


    Private Sub T1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            T1.Stop()
            Breset.Visible = True
        End If
    End Sub

    
    Private Sub Breset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Breset.Click
        T1.Start()
        Breset.Visible = False
        ProgressBar1.Value = 0
        Mobile.Close()
        data1 = rdata.Next(1111, 9999)
        Mobile.Show()
    End Sub

End Class