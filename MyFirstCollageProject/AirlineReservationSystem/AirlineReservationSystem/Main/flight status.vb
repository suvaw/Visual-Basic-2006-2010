Public Class flight_status
    Private access As New DBControls
    Private Sub bback_Click(sender As Object, e As EventArgs) Handles bback.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshGrid()
        access.AddParam("@input", input.Text)
        ' RUN QUERY
        access.ExecQuery("SELECT flightname,status,delay FROM Statuscheck where flightname=@input")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvdata.DataSource = access.DBDT
    End Sub
    Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
        Me.Hide()
    End Sub

    Private Sub bclear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bclear.Click
        input.Clear()
        Label2.Text = ""
    End Sub

    Private Sub flight_status_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label2.Text = ""
        input.Text = "Enter Your Flight No"
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input.KeyPress
        If input.Text.Length = 10 Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(input.Text) Then
            Panel1.Visible = False
            Panel2.Visible = True
            RefreshGrid()
            Label2.Text = ""
            input.Text = "Enter Your Flight No"
        Else
            Label2.Text = ("You Enter Worng Flight No")
        End If
    End Sub
End Class