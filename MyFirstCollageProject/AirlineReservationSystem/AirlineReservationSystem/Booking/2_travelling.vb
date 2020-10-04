Imports System.Text.RegularExpressions
Public Class travelling
    
    Private Sub travelling_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loadpanel(True, False)
        loginpanel(True, False)
    End Sub

    
    Private Sub flightchk(ByVal e1 As Boolean, ByVal e2 As Boolean)
        Tfname.ReadOnly = e1
        Tlname.ReadOnly = e2
    End Sub
    Private Sub loadpanel(ByVal e1 As Boolean, ByVal e2 As Boolean)
        P3.Visible = e1
        P4.Visible = e2
    End Sub
    Private Sub loginpanel(ByVal e1 As Boolean, ByVal e2 As Boolean)
        P2.Visible = e1
        P2a.Visible = e2
    End Sub
    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub Bsignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsignup.Click
        MemberRegistation.Show()
        If MemberRegistation.Visible Then
            Me.Hide()
        End If
    End Sub
    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        If T1.Text = "admin@gmail.com" And Tpassword.Text = "admin" Then
            loginpanel(False, True)
        Else
            ErrorProvider2.SetError(T1, "Enter Worng User Name and Password")
            ErrorProvider2.SetError(Tpassword, "Enter Worng User Name and Password")
        End If
    End Sub
    Private Sub LL1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LL1.LinkClicked
        ForgetPassword.Show()
        If ForgetPassword.Visible Then
            Me.Close()
        End If
    End Sub

    Private Sub Bnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnext.Click
        loadpanel(False, True)
        Bfclear.Visible = False
    End Sub
    Private Sub Bfsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfsubmit.Click
        add_ons.Show()
        If add_ons.Visible Then
            loadpanel(False, False)
            Me.Hide()
        End If
    End Sub
    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClear.Click
        CB1.Text = "Select"
        CB2.Text = "Select"
        CB3.Text = "Select"
        T.Clear()
        T2.Clear()
        T3.Clear()
        T5.Clear()
    End Sub
    Private Sub Bfclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfclear.Click
        CB4.Text = "Select"
        Tfname.Clear()
        Tlname.Clear()
    End Sub
    Private Sub Bback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bback.Click
        loadpanel(True, False)
        flightchk(True, True)
        Bfclear.Visible = False
    End Sub
    Private Sub Check3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check3.CheckedChanged
        If Check3.Checked = True Then
            flightchk(False, False)
            Bfclear.Visible = True
        Else
            flightchk(True, True)
            Bfclear.Visible = False
        End If
    End Sub

    Private Sub T1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        Dim MyEmail As String = T1.Text
        If EmailCheck(MyEmail) = True Then
            ErrorProvider2.Clear()
            Label2.Text = "Valid Email!"
            ErrorProvider1.SetError(T1, "Valid Mail")
            BLogin.Visible = True
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(T1, "invaild mail")
            ErrorProvider2.SetError(T1, "Invalid Mail!")
            BLogin.Visible = False
        End If
    End Sub
    Private Sub T_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T.KeyPress
        Dim MyEmail As String = T.Text
        If EmailCheck(MyEmail) = True Then
            ErrorProvider2.Clear()
            'Label2.Text = "Valid Email!"
            ErrorProvider1.SetError(T, "vaild mail")
            Bnext.Visible = True
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(T, "invaild mail")
            'Label2.Text = "Invalid Email!"
            Bnext.Visible = False
        End If
    End Sub

    
    
    Private Sub blogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogout.Click
        loginpanel(True, False)
    End Sub
End Class