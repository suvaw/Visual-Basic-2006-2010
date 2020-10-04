Public Class MyProfile

    
    Private Sub MyProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Exitpopup From close
        If Me.Visible = True Then
            ExitPopup.Dispose()
        End If

        If RESET_PASSWORD.Visible = False Then
            RESET_PASSWORD.Dispose()
        End If

        'panel setup
        PDashbord.Visible = True
        PManageMyBook.Visible = False
        PSpecialOffer.Visible = False
        PMyProfile.Visible = False
        PPassangerList.Visible = False
        'panel setup ending

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set

        'label color set initilation
        LDB.ForeColor = Color.Black
        LMMB.ForeColor = Color.Black
        LMP.ForeColor = Color.Black
        LPL.ForeColor = Color.Black
        LSO.ForeColor = Color.Black
        Lselect.ForeColor = Color.Blue
        'label coler set ending
    End Sub

    Private Sub BExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExit.Click
        ExitPopup.TopMost = True
        ExitPopup.Show()
    End Sub

    Private Sub LDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDB.Click
        'panel setup
        PDashbord.Visible = True
        PManageMyBook.Visible = False
        PSpecialOffer.Visible = False
        PMyProfile.Visible = False
        PPassangerList.Visible = False
        'panel setup ending

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set

        'label color set
        LDB.ForeColor = Color.Blue
        LMMB.ForeColor = Color.Black
        LMP.ForeColor = Color.Black
        LPL.ForeColor = Color.Black
        LSO.ForeColor = Color.Black
        'label coler set ending
    End Sub

    Private Sub LMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMP.Click
        'panel setup
        PDashbord.Visible = False
        PManageMyBook.Visible = False
        PSpecialOffer.Visible = False
        PMyProfile.Visible = True
        PPassangerList.Visible = False
        'panel setup ending

        'select label location
        Lselect.Location = New Point(795, 45)
        'end label location set

        'label color set
        LDB.ForeColor = Color.Black
        LMMB.ForeColor = Color.Black
        LMP.ForeColor = Color.Blue
        LPL.ForeColor = Color.Black
        LSO.ForeColor = Color.Black
        'label coler set ending
    End Sub

    Private Sub LMMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMMB.Click
        'panel setup
        PDashbord.Visible = False
        PManageMyBook.Visible = True
        PSpecialOffer.Visible = False
        PMyProfile.Visible = False
        PPassangerList.Visible = False
        'panel setup ending

        'select label location
        Lselect.Location = New Point(605, 45)
        'end label location set

        'label color set
        LDB.ForeColor = Color.Black
        LMMB.ForeColor = Color.Blue
        LMP.ForeColor = Color.Black
        LPL.ForeColor = Color.Black
        LSO.ForeColor = Color.Black
        'label coler set ending
    End Sub

    Private Sub LPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPL.Click
        'panel setup
        PDashbord.Visible = False
        PManageMyBook.Visible = False
        PSpecialOffer.Visible = False
        PMyProfile.Visible = False
        PPassangerList.Visible = True
        'panel setup ending

        'select label location
        Lselect.Location = New Point(391, 45)
        'end label location set

        'label color set
        LDB.ForeColor = Color.Black
        LMMB.ForeColor = Color.Black
        LMP.ForeColor = Color.Black
        LPL.ForeColor = Color.Blue
        LSO.ForeColor = Color.Black
        'label coler set ending
    End Sub

    Private Sub LSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSO.Click, Lselect.Click
        'panel setup
        PDashbord.Visible = False
        PManageMyBook.Visible = False
        PSpecialOffer.Visible = True
        PMyProfile.Visible = False
        PPassangerList.Visible = False
        'panel setup ending

        'select label location
        Lselect.Location = New Point(187, 45)
        'end label location set

        'label color set
        LDB.ForeColor = Color.Black
        LMMB.ForeColor = Color.Black
        LMP.ForeColor = Color.Black
        LPL.ForeColor = Color.Black
        LSO.ForeColor = Color.Blue
        'label coler set ending
    End Sub

    
    Private Sub Blogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogout.Click
        MainWindows.Show()
        If MainWindows.Visible = True Then
            Me.Hide()
        End If
    End Sub
End Class