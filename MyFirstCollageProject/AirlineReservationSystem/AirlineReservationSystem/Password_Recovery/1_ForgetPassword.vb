Public Class ForgetPassword
    Dim i As Integer = 0
    Dim rdata As New Random
    Private Sub ForgetPassword_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Tmobile.MaxLength = 10
        Tmobile.Focus()
    End Sub


    Private Sub Tmobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tmobile.KeyPress

        'the following is all the special characters that we dont want our phonenumbers
        Dim DisallowedChars As String = ",<.>/?;:'][{}*!@#$%^&()_+-="

        'Disallow allow all the alphabets
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
            Lnotice.Text = "Phone Number must be number only NO Character Allow!"
            Error1.SetError(Tmobile, "Phone Number must be number only NO Character Allow!")
            T1.Start()
            Lnotice.BackColor = Color.Red
            Lnotice.ForeColor = Color.White

            'check if character that we disallowed
        ElseIf DisallowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            e.KeyChar = ChrW(0)
            e.Handled = True

            Lnotice.Text = ("Must be Numbers only no Special Character Allow!")
            Error1.SetError(Tmobile, "Phone Numbers Must be Numbers only no Special Character Allow!")
            T1.Start()
            Lnotice.BackColor = Color.Red
            Lnotice.ForeColor = Color.White

        Else
            'if character entered is numbers

            Lnotice.BackColor = Color.Red
            Lnotice.ForeColor = Color.White

            'focous botton
        End If
        If Tmobile.Text.Length = 10 Then
            BOTP.Focus()
        End If
    End Sub


    Private Sub Tmobile_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tmobile.MouseClick
        Tmobile.Clear()
    End Sub


    Private Sub Tmobile_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmobile.Validated
        If Tmobile.Text.Length = 10 Then
            Lnotice.Text = ("Valid Phonenumber")
            Error2.SetError(Tmobile, "Valid Phonenumber")
            T1.Start()
        Else
            Lnotice.Text = ("Phonenumber must be 10 Number long")
            Error1.SetError(Tmobile, "Phone Number Must 10 Number long")
            T1.Start()
        End If
    End Sub


    Private Sub T1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        i = i + 1
        If i = 15 Then
            T1.Stop()
            Me.Error1.Clear()
            Me.Error2.Clear()
            i = 0
        End If
    End Sub


    Private Sub BOTP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOTP.Click
        If Tmobile.Text.Length = 10 Then
            OTP_Verify.Show()
            If OTP_Verify.Visible Then
                data1 = rdata.Next(1111, 9999)
                Mobile.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class