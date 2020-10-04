Imports System.Text.RegularExpressions
Public Class MemberRegistation
    Public Access As New DBControls
    Dim datepick As String
    Private Sub MemberRegistation_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Cbxtitle.Focus()
        popup.Visible = False
        'Combobox title data initialize
        Cbxtitle.Items.Add("Mr.")
        Cbxtitle.Items.Add("Mrs.")
        'Combobox Day data initialize
        For i = 1 To 31
            If i < 10 Then
                CbxDay.Items.Add("0" + i.ToString)
            Else
                CbxDay.Items.Add(i)
            End If
        Next
        'Combobox Month data initialize
        For i = 1 To 12
            If i < 10 Then
                CbxMonth.Items.Add("0" + i.ToString)
            Else
                CbxMonth.Items.Add(i)
            End If
        Next
        'Combobox Year data initialize
        For i = 1965 To 2018
            CbxYear.Items.Add(i)
        Next
        'Combobox State data initialize
        Access.ExecQuery("SELECT * FROM Country ORDER BY state ASC")
        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            CbxState.Items.Add(R("state"))
        Next
        'Combobox Country data initialize
        Access.ExecQuery("SELECT * FROM Country ORDER BY country ASC")
        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            CbxCountry.Items.Add(R("country"))
        Next
    End Sub

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
        Label5.Text = ""
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
        If (Not String.IsNullOrEmpty(Tname.Text)) Then
            Tname.SelectionStart = 0
            Tname.SelectionLength = Tname.Text.Length
        End If
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
            If Tpassword.Text.Length >= 6 Then
                datepick = CbxDay.Text + "/" + CbxMonth.Text + "/" + CbxYear.Text
                ' ADD PARAMETERS
                Access.AddParam("@title", Cbxtitle.Text)
                Access.AddParam("@fname", Tname.Text)
                Access.AddParam("@lname", Tlname.Text)
                Access.AddParam("@country", CbxCountry.Text)
                Access.AddParam("@state", CbxState.Text)
                Access.AddParam("@phone", Tmobile.Text)
                Access.AddParam("@password", Tpassword.Text)
                Access.AddParam("@dob", datepick)
                Access.AddParam("@email", Temail.Text)
                Access.AddParam("@Address", Taddress.Text)
                Access.AddParam("@data", "No Data")

                ' EXECUTE INSERT COMMAND
                Access.ExecQuery("INSERT INTO [Admin] ([title],[firstname],[lastname],[country],[state],[phone],[password],[dob],[email],[address],city,pin,address2) " & _
                                 "VALUES (@title,@fname,@lname,@country,@state,@phone,@password,@dob,@email,@Address,@data,@data,@data); ")

                ' REPORT & ABORT ON ERRORS
                If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

                ' SUCCESS!!
                'MsgBox("User was added successfully.")
                popup.Visible = True
                Lmsg.Text = Temail.Text
                logindata = True
                usernamedata = Temail.Text
                userphone = Tmobile.Text
                runclear()
            Else
                Label5.Text = "Password Length Minimun 6 character !"
            End If
        Else
            MsgBox("Your Password are not match !")
            Error1.SetError(Tpassword1, "Your two password is not match")
            Error1.SetError(Tpassword, "Your two password is not match")
        End If
    End Sub

    Private Sub Bconf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bconf.Click
        MainWindows.Transition1.ShowSync(loading)
        MainWindows.Transition2.ShowSync(MyProfile)
        If MyProfile.Visible Then
            Me.Hide()
            runclear()
            popup.Visible = False
        End If
        loading.Close()
    End Sub

    Private Sub Temail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Temail.KeyPress
        Dim MyEmail As String = Temail.Text
        If EmailCheck(MyEmail) = True Then
            Error1.Clear()
            'Label2.Text = "Valid Email!"
            Error2.SetError(Temail, "vaild mail")
        Else
            Error2.Clear()
            Error1.SetError(Temail, "invaild mail")
            'Label1.Text = "Invalid Email!"
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        background.Show()
        ExitPopup.Show()
        ExitPopup.TopMost = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MainWindows.Transition2.ShowSync(MainWindows)
        If MainWindows.Visible Then
            Me.Close()
        End If
    End Sub

    Private Sub Tmobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tmobile.KeyPress

    End Sub
End Class