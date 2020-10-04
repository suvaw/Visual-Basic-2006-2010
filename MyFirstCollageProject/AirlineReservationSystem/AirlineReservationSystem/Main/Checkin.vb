Imports System.Text.RegularExpressions
Public Class Checkin
    Private access As New DBControls
    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub dataclear()
        Temail.Clear()
        Label1.Text = ""
        Cbxfrom.Text = "Select"
        Cbxto.Text = "Select"
    End Sub
    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshGrid()
        access.AddParam("@form", Cbxfrom.Text)
        access.AddParam("@to", Cbxto.Text)
        ' RUN QUERY
        access.ExecQuery("SELECT Form,to,price FROM flightcity where form=@form and to=@to")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvdata.DataSource = access.DBDT
    End Sub

    Private Sub Checkin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        P1.Visible = True
        P2.Visible = False

        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY from ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            Cbxfrom.Items.Add(R("from"))
        Next
    End Sub

    Private Sub Bcheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcheck.Click
        P1.Visible = False
        P2.Visible = True
        RefreshGrid()
    End Sub

    Private Sub Bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclose.Click
        Me.Close()
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        dataclear()
    End Sub

    Private Sub bback_Click(sender As Object, e As EventArgs) Handles bback.Click
        P1.Visible = True
        P2.Visible = False
        dataclear()
    End Sub

    Private Sub Temail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Temail.KeyPress
        Dim MyEmail As String = Temail.Text
        If EmailCheck(MyEmail) = True Then
            Label1.Text = "Valid Email!"
            ErrorProvider1.SetError(Temail, "vaild mail")
        Else
            ErrorProvider2.SetError(Temail, "invaild mail")
            Label1.Text = "Invalid Email!"
        End If
    End Sub

    Private Sub Tref_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Tref.Text.Length = 10 Then
            Bcheck.Focus()
        End If
    End Sub

    Private Function Tref() As Object
        Throw New NotImplementedException
    End Function

    Private Sub CbxFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbxfrom.SelectedIndexChanged
        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY to ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        'Searching fild2 data clear
        Cbxto.Items.Clear()

        'searching fild2 text clear
        Cbxto.Text = "Select"

        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            If R("to") = Cbxfrom.Text Then
                GoTo l
            Else
                Cbxto.Items.Add(R("to"))
            End If
l:
        Next
    End Sub
End Class
