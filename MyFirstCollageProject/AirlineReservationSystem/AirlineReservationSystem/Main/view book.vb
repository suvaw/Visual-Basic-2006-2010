Public Class view_book
    Dim pnr, email As String
    Dim access As New DBControls
    Private Sub dataclear()
        Temail.Clear()
        Tpnr.Clear()
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bview.Click
        access.ExecQuery("SELECT addon FROM [passengers] where (PNR=" & Tpnr.Text & "  and email='" & Temail.Text & "') ")
        If access.DBDT.Rows.Count <> 0 Then
            Login.Show()
            Panel2.Visible = False
            Panel1.Visible = True
            access.ExecQuery("SELECT PNR,name,tpassenger,source,destination,flightno,status from passengers WHERE email='" & Temail.Text & "' and PNR=" & Tpnr.Text & " ")
            DataGridView1.DataSource = access.DBDT
            Login.Close()
        Else
            MsgBox("You enter Worng PNR Number Or Worng Email", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bclear.Click
        Temail.Clear()
        Tpnr.Clear()
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        dataclear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub view_book_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Panel2.Visible = True
        Panel1.Visible = False
        Label3.Text = ""
        Label4.Text = ""
    End Sub
End Class