Imports System.Text.RegularExpressions
Public Class MemberRegistation
    Private Access As New DBControls
    Dim datepick As String

    Private Sub MemberRegistation_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Cbxtitle.Focus()
        popup.Visible = False
        Cbxtitle.Items.Add("Mr.")
        Cbxtitle.Items.Add("Mrs.")
        CbxDay.Items.Add("01")

        'Combobox Month data initialize
        CbxMonth.Items.Add("01")
        CbxMonth.Items.Add("02")
        CbxMonth.Items.Add("03")
        CbxMonth.Items.Add("04")
        CbxMonth.Items.Add("05")
        CbxMonth.Items.Add("06")
        CbxMonth.Items.Add("07")
        CbxMonth.Items.Add("08")
        CbxMonth.Items.Add("09")
        CbxMonth.Items.Add("10")
        CbxMonth.Items.Add("11")
        CbxMonth.Items.Add("12")
        CbxYear.Items.Add("2017")
        CbxState.Items.Add("West Bengal")
        CbxCountry.Items.Add("India")
    End Sub

    Private Sub AddUser()
        ' ADD PARAMETERS
        Access.AddParam("@title", Cbxtitle.Text)
        Access.AddParam("@fname", Tname.Text)
        Access.AddParam("@lname", Tlname.Text)
        Access.AddParam("@state", CbxState.Text)
        Access.AddParam("@country", CbxCountry.Text)
        Access.AddParam("@phone", Tmobile.Text)
        Access.AddParam("@password", Tpassword.Text)
        Access.AddParam("@dob", datepick)
        Access.AddParam("@email", Temail.Text)
        Access.AddParam("@Address", Taddress.Text)


        ' EXECUTE INSERT COMMAND
        Access.ExecQuery("INSERT INTO [Admin] ([title],[firstname],[lastname],[state],[country],[phone],[password],[dob],[email],[address]) " & _
                         "VALUES (@title,@fname,@lname,@state,@country,@phone,@password,@dob,@email,@Address); ")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' SUCCESS!!
        MsgBox("User was added successfully.")
    End Sub

    'Clear function create
    Public Sub runclear()
        Cbxtitle.Text = "Select"
        Tname.Clear()
        Tlname.Clear()
        CbxDay.Text = "Select"
        CbxMonth.Text = "Select"
        CbxYear.Text = "Select"
        CbxState.Text = "Select"
        CbxCountry.Text = "Select"
        Tpassword.Clear()
        Tpassword1.Clear()
        Temail.Clear()
        Taddress.Clear()
        CbxCountryCode.Text = "Select"
        Tmobile.Clear()
        Tid.Clear()
        Me.Error1.Clear()
    End Sub
    'Clear function ending

    Function EmailCheck(ByVal emailAddress As String) As Boolean


        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)


        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        runclear()
    End Sub

    'Textbox Event generate
    Private Sub Tname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tname.Enter
        Tname.Clear()
    End Sub
    Private Sub Tlname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tlname.Enter
        Tlname.Clear()
    End Sub
    Private Sub Tpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tpassword.Enter
        Tpassword.Clear()
        Tpassword.UseSystemPasswordChar = True
    End Sub
    Private Sub Tpassword1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tpassword1.Enter
        Tpassword1.Clear()
        Tpassword1.UseSystemPasswordChar = True
    End Sub
    Private Sub Tmobile_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmobile.Enter
        Tmobile.Clear()
    End Sub
    Private Sub Tid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tid.Enter
        Tid.Clear()
        Tid.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub Taddress_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Taddress.Enter
        Taddress.Clear()
    End Sub
    Private Sub Temail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temail.Enter
        Temail.Clear()
    End Sub
    'textbox event ending


    Private Sub Tpassword1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tpassword1.Validated
        If Not Tpassword.Text = Tpassword1.Text Then
            Error1.SetError(Tpassword1, "Password is not Match")
        End If
    End Sub
    Private Sub Tmobile_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Tmobile.Validating
        If Not IsNumeric(Tmobile.Text) Then
            Error1.SetError(Tmobile, "Character is not Numaric")
        Else
            Error1.Clear()
        End If
    End Sub

    'Submit form data in database
    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If Tpassword.Text = Tpassword1.Text Then
            datepick = CbxDay.Text + "-" + CbxMonth.Text + "-" + CbxYear.Text
            AddUser()
            popup.Visible = True
            Lmsg.Text = Temail.Text
            logindata = True
            usernamedata = Tname.Text
        End If
    End Sub

    Private Sub Bconf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bconf.Click
        MyProfile.Show()
        If MyProfile.Visible Then
            Me.Hide()
            runclear()
            popup.Visible = False
        End If
    End Sub

    Private Sub Temail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Temail.KeyPress
        Dim MyEmail As String = Temail.Text
        If EmailCheck(MyEmail) = True Then
            Error1.Clear()
            Label2.Text = "Valid Email!"
            Error2.SetError(Temail, "vaild mail")

        Else
            Error2.Clear()
            Error1.SetError(Temail, "invaild mail")
            Label1.Text = "Invalid Email!"
        End If
    End Sub
End Class