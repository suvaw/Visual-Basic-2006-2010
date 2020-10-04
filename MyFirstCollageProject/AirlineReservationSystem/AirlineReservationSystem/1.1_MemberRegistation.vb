Public Class MemberRegistation

    Private Sub MemberRegistation_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        MyProfile.Show()
        If MyProfile.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Cbxtitle.Items.Clear()
        Tname.Clear()
        Tlname.Clear()
        CbxDay.Items.Clear()
        CbxMonth.Items.Clear()
        CbxYear.Items.Clear()
        CbxState.Items.Clear()
        CbxCountry.Items.Clear()
        Tpassword.Clear()
        Tpassword1.Clear()
        Temail.Clear()
        Taddress.Clear()
        CbxCountryCode.Items.Clear()
        Tmobile.Clear()
        Tid.Clear()
    End Sub

    
End Class