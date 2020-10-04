Public Class Search
    Private access As New DBControls

    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        travelling.Show()
        If travelling.Visible Then
            Me.Close()
        End If
    End Sub


    Private Sub Search_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Cbxform.Text = source
        Cbxto.Text = destination

        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY from ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            Cbxform.Items.Add(R("from"))
        Next

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
