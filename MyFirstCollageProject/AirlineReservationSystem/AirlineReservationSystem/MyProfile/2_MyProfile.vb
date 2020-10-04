Public Class MyProfile

    Private Sub Panelsetup(ByVal s0 As Boolean, ByVal s1 As Boolean, _
                            ByVal s2 As Boolean, ByVal s3 As Boolean, ByVal s4 As Boolean)
        PDashbord.Visible = s0
        PManageMyBook.Visible = s1
        PSpecialOffer.Visible = s2
        PMyProfile.Visible = s3
        PPassangerList.Visible = s4
    End Sub
    Private Sub labelcolor(ByVal c1 As Color, ByVal c2 As Color, ByVal c3 As Color, ByVal c4 As Color, ByVal c5 As Color)
        LDB.ForeColor = c1
        LMMB.ForeColor = c2
        LMP.ForeColor = c3
        LPL.ForeColor = c4
        LSO.ForeColor = c5
    End Sub

    Private Sub MyProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Exitpopup From close
        If Me.Visible = True Then
            ExitPopup.Dispose()
        End If

        If RESET_PASSWORD.Visible = False Then
            RESET_PASSWORD.Dispose()
        End If

        'panel fn call
        Panelsetup(True, False, False, False, False)

        'label fn initilation
        labelcolor(Color.Blue, Color.Black, Color.Black, Color.Black, Color.Black)
        Lselect.ForeColor = Color.Blue

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set

    End Sub
    Private Sub MyProfile_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If logindata = True Then
            Lmpusername.Text = "Hi, " + usernamedata
        Else
            Lmpusername.Text = ""
        End If
    End Sub

    
    Private Sub LDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDB.Click

        'panel fn call
        Panelsetup(True, False, False, False, False)

        'label fn initilation
        labelcolor(Color.Blue, Color.Black, Color.Black, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set

    End Sub

    Private Sub LMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMP.Click

        'panel fn call
        Panelsetup(False, False, False, True, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Blue, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(795, 45)
        'end label location set
    End Sub

    Private Sub LMMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMMB.Click

        'panel fn call
        Panelsetup(False, True, False, False, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Blue, Color.Black, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(605, 45)
        'end label location set

    End Sub

    Private Sub LPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPL.Click

        'panel fn call
        Panelsetup(False, False, False, False, True)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Blue, Color.Black)

        'select label location
        Lselect.Location = New Point(391, 45)

    End Sub

    Private Sub LSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSO.Click, Lselect.Click

        'panel fn call
        Panelsetup(False, False, True, False, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Black, Color.Blue)

        'select label location
        Lselect.Location = New Point(187, 45)

    End Sub

    'Logout button call
    Private Sub Blogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogout.Click
        MainWindows.Show()
        logindata = False
        If MainWindows.Visible = True Then
            Me.Hide()
        End If
    End Sub

    'Exit Button click
    Private Sub BExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExit.Click
        ExitPopup.TopMost = True
        ExitPopup.Show()
    End Sub

    
    Private Sub BBflight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBflight.Click
        Search.Show()
        If Search.Visible Then
            Me.Hide()
        End If
    End Sub
End Class