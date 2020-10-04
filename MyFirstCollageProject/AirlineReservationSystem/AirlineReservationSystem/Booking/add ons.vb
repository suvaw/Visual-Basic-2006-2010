Public Class add_ons
    'bhot button click event
    Private Sub Bhot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhot.Click
        addon += 180                                    'addon valu add 180
        Bhot.Visible = False                            'add bhot button don't visible
        Brhot.Visible = True                            'remove bhot button visible show
    End Sub

    'btravel button click event
    Private Sub Btravel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btravel.Click
        addon += 519                                    'addon value add 519
        Btravel.Visible = False                         'Btravel button visiblity disible
        Brtravel.Visible = True                         'Btravel button visilibity enable
    End Sub

    'Bseat button click event
    Private Sub Bseat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bseat.Click
        addon += 499                                    'Bseat value add 499
        Bseat.Visible = False                           'Bseat button visiblity disible
        Brseat.Visible = True                           'Brseat button visiblity enable
    End Sub

    'Brhot click event
    Private Sub Brhot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brhot.Click
        addon -= 180                                    'Brhot value sub 180
        Bhot.Visible = True                             'Bhot button visiblity enable
        Brhot.Visible = False                           'Brhot button visiblity Disible
    End Sub

    'Brtravel button click event
    Private Sub Brtravel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brtravel.Click
        addon -= 519                                    'Brtravel value sub 519
        Btravel.Visible = True                          'Btravel button visiblity enable
        Brtravel.Visible = False                        'Brtavel button visiblity disable
    End Sub

    'Brseat button click event
    Private Sub Brseat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brseat.Click
        addon -= 499                                    'Brseat add on value sub 499
        Bseat.Visible = True                            'Brseat button visiblity enable
        Brseat.Visible = False                          'Brseat button visiblity disable
    End Sub

    'Bcontinue button click event
    Private Sub Bcontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcontinue.Click
        MainWindows.Transition1.ShowSync(loading)       'animated loading form show
        Seat.Show() 'seat form show
        If Seat.Visible Then                            'Check seat form visiblity
            Me.Hide()                                   'Recent open form hide
        End If
        loading.Close()                                 'Loding form dispose
    End Sub

    'Bback button click event
    Private Sub BBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBack.Click
        addon = 0                                        'initialize addon value
        MainWindows.Transition2.ShowSync(travelling)     'travel form show
        Me.Hide()                                        'Recent oprn form hide
    End Sub

    'Picturebox4 click event
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        MainWindows.Transition2.ShowSync(MainWindows)   'Animated main windows form open
        If MainWindows.Visible Then                     'Check main windows form visiblity
            Me.Close()                                  'Recent form close
        End If
    End Sub
End Class