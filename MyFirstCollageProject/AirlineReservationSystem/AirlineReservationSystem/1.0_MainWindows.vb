Public Class MainWindows

    Private Sub MainWindows_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
    End Sub

    Private Sub MainWindows_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.TopMost = True Then
            MyProfile.Dispose()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LExit.Click
        Application.Exit()
    End Sub

    Private Sub Panel2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSmenu.MouseEnter
        'Panel2.Size = New Size(200, Panel2.Size.Height)
        'Panel2.Location = New Point(153, 2)
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSmenu.MouseLeave

        'Panel2.Location = New Point(2, 2)
    End Sub

    Private Sub LSU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSU.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSearch.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub BunifuFlatButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Babout.MouseEnter, Bnotification.MouseEnter, Bshedules.MouseEnter, Bweather.MouseEnter, Bbook.MouseEnter
        PSmenu.Size = New Size(200, PSmenu.Size.Height)
        'Panel2.Location = New Point(153, 2)
    End Sub

    Private Sub BunifuFlatButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Babout.MouseLeave, Bnotification.MouseLeave, Bshedules.MouseLeave, Bweather.MouseLeave, Bbook.MouseLeave
        PSmenu.Size = New Size(50, PSmenu.Size.Height)
    End Sub

    Private Sub BunifuFlatButton_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Babout.MouseMove, Bnotification.MouseMove, Bshedules.MouseMove, Bweather.MouseMove, Bbook.MouseMove
        PSmenu.Size = New Size(200, PSmenu.Size.Height)
    End Sub

    Private Sub LCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCI.Click
        Checkin.TopMost = True
        Checkin.Show()
        Checkin.Location = New Point(0, 114)
    End Sub
End Class