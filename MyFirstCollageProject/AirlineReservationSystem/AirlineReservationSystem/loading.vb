Public Class loading
    Dim i As Integer = 10
    Dim j As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If i >= 100 Then
            i = 0
        Else
            i += 10
            loadingprogress.Value = i
        End If

        If j = 0 Then
            Label1.Text = "Loading."
            loadingprogress.ProgressColor = Color.MediumAquamarine
            j += 1
        ElseIf j = 1 Then
            Label1.Text = "Loading.."
            loadingprogress.ProgressColor = Color.MediumVioletRed
            j += 1
        ElseIf j = 2 Then
            Label1.Text = "Loading..."
            loadingprogress.ProgressColor = Color.LightGreen
            j += 1
        ElseIf j = 3 Then
            Label1.Text = "Loading...."
            loadingprogress.ProgressColor = Color.LightSeaGreen
            j += 1
        ElseIf j = 4 Then
            Label1.Text = "Loading....."
            loadingprogress.ProgressColor = Color.LightSkyBlue
            j = 0
        End If
    End Sub

    Private Sub loading_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Start()
    End Sub
End Class