Public Class MainWindows
    Private access As New DBControls


    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub MainWindows_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY from ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            Cbxform.Items.Add(R("from"))
        Next

        
    End Sub

    Private Sub MainWindows_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.TopMost = True Then
            MyProfile.Dispose()
        End If
    End Sub

    Private Sub LExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LExit.Click
        Application.Exit()
    End Sub


    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSmenu.MouseLeave
        Timer1.Start()
        Threading.Thread.Sleep(1000)
        'Panel2.Location = New Point(2, 2)
    End Sub

    Private Sub LSU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSU.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSearch.Click
        'source and destination data sent search form
        source = Cbxform.Text
        destination = Cbxto.Text

        Me.Hide()
        Search.Show()
    End Sub


    Private Sub LCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCI.Click
        Checkin.TopMost = True
        Checkin.Show()
        Checkin.Location = New Point(0, 114)
    End Sub

    Private Sub Cbxform_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbxform.SelectedIndexChanged
        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY to ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        'Searching fild2 data clear
        Cbxto.Items.Clear()

        'searching fild2 text clear
        Cbxto.Text = "Select"

        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            If R("to") = Cbxform.Text Then
                GoTo l
            Else
                Cbxto.Items.Add(R("to"))
            End If

l:
        Next

    End Sub
End Class