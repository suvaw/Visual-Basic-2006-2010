Imports System.Text.RegularExpressions
Public Class travelling
    Dim access As New DBControls                                        'New database object create
    Private Sub travelling_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loadpanel(True, False)                                              'Send argument sub func
        loginpanel(True, False)                                             'Send argument sub func
        cbxtitle.Items.Add("Mr.")                                           'Add combobox items
        cbxtitle.Items.Add("Mrs.")                                          'Add combobox items
        access.ExecQuery("SELECT * FROM Country ORDER BY state ASC")        'Combobox State queary
        For Each R As DataRow In access.DBDT.Rows                           'FILL COMBOBOX
            Cbxstate.Items.Add(R("state"))                                  'ComboBox Add item
        Next
        access.ExecQuery("SELECT * FROM Country ORDER BY country ASC")      'Execute Quary
        For Each R As DataRow In access.DBDT.Rows                           ' FILL COMBOBOX
            Cbxcountry.Items.Add(R("country"))                              'Add item
        Next
    End Sub

    'Declear load panel sub function
    Private Sub loadpanel(ByVal e1 As Boolean, ByVal e2 As Boolean)         'Reciver argument
        P3.Visible = e1                                                     'Visiblity switching
        P4.Visible = e2                                                     'Visiblity switching
    End Sub

    'Declear logIn panel sub function
    Private Sub loginpanel(ByVal e1 As Boolean, ByVal e2 As Boolean)        'Reciver argument
        P2.Visible = e1                                                     'Visiblity switching
        P2a.Visible = e2                                                    'Visiblity switching
    End Sub

    'Declear email checking function
    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern) 'Call system function
        If emailAddressMatch.Success Then                                   'Checking condition
            Return True                                                     'Value return
        Else
            Return False                                                    'Value return
        End If
    End Function

    'BsignUp button click event
    Private Sub Bsignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsignup.Click
        MainWindows.Transition2.ShowSync(MemberRegistation)                 'Main window form show
        If MemberRegistation.Visible Then                                   'Form visiblity Check
            Me.Hide()                                                       'Recent Form Hide
        End If
    End Sub

    'Blogin button click event
    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogin.Click
        MainWindows.Transition1.ShowSync(loading)                           'Form show
        access.ExecQuery("SELECT phone FROM Admin where email='" & T1.Text & "' and password='" & Tpassword.Text & "'")
        If access.DBDT.Rows.Count <> 0 Then                                 'DB row count Check
            loginpanel(False, True)                                     'Sent argument Sub Function
            access.ExecQuery("SELECT firstname,lastname,phone,email FROM Admin where email='" & T1.Text & "' and password='" & Tpassword.Text & "'")
            dgv1.DataSource = access.DBDT                                   'DGV Data Fill
            Dim selectedRow As DataGridViewRow                              'Select the row
            selectedRow = dgv1.Rows(0)                                      'Default Select Row Set
            Lfname.Text = selectedRow.Cells(0).Value                        'Label Text Set
            Llname.Text = selectedRow.Cells(1).Value                        'Label Text Set
            Lemail.Text = selectedRow.Cells(2).Value                        'Label Text Set
            Lphone.Text = selectedRow.Cells(3).Value                        'Label Text Set
            useremail = selectedRow.Cells(3).Value                          'Label Text Set
            T1.Text = ""                                                    'Label Text Clear
            Tpassword.Text = ""                                             'Label Text Clear
        Else
            ErrorProvider1.Clear()                                          'ErrorProvider Clear
            ErrorProvider2.SetError(T1, "Enter Worng User Name and Password") 'ErrorProvider Set
            ErrorProvider2.SetError(Tpassword, "Enter Worng User Name and Password")
        End If
        loading.Close()                                                     'Form Close
    End Sub

    'Declear Forgot password link click
    Private Sub LL1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LL1.LinkClicked
        MainWindows.Transition2.ShowSync(ForgetPassword)                    'Animated Form Open
        If ForgetPassword.Visible Then                                      'Form visibility check
            Me.Close()                                                      'Recent Form Close
        End If
    End Sub

    'Bnext button click event
    Private Sub Bnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnext.Click
        If cbxtitle.Text = "Select" Or Cbxstate.Text = "Select" Or Cbxcountry.Text = "Select" Or Tbpin.Text = "" Or Tbpin.Text = "Enter PIN" _
 Or Tbfname.Text = "Enter Your First Name" Or Tbfname.Text = "" Or Tblname.Text = "Enter Your Last Name" Or Tblname.Text = "" Then
            MsgBox("Please Fill The Total Filds", MsgBoxStyle.Exclamation)
        Else
            loadpanel(False, True)                              'Call sub function with argument
        End If
    End Sub
    Private Sub Bfsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfsubmit.Click
        MainWindows.Transition1.ShowSync(loading)                           'Form Open
        If Taddress.Text = "" Or Taddress.Text = "" Or TIDcard.Text = "Enter Your ID Card Number" Or TIDcard.Text = "" Or Tbemail.Text = "Enter Your Email Address" Or Tbemail.Text = "" Then
            MsgBox("Please Enter Your Filds!", MsgBoxStyle.Exclamation)     'Worning Massage
        Else
            MainWindows.Transition2.ShowSync(add_ons)                       'Form Open
            tt0 = cbxtitle.Text                                             'Load data variable
            tt1 = Tbfname.Text                                              'Load data variable
            tt2 = Tblname.Text                                              'Load data variable
            tt3 = Tbphone.Text                                              'Load data variable
            tt4 = Tbemail.Text                                              'Load data variable
            tt5 = Cbxstate.Text                                             'Load data variable
            tt6 = Cbxcountry.Text                                           'Load data variable
            tt7 = Tbpin.Text                                                'Load data variable
            tt8 = TIDcard.Text                                              'Load data variable
            tt9 = Taddress.Text                                             'Load data variable
            If add_ons.Visible Then                                         'Form visibility Check
                loadpanel(True, False)                              'Call sub function With argument
                Me.Hide()                                                   'Recent Form Hide
            End If
        End If
        loading.Close()                                                     'Form Close
    End Sub

    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClear.Click, BBackold.Click
        cbxtitle.Text = "Select"                                            'Textbox Text Set
        Cbxcountry.Text = "Select"                                          'Textbox Text Set
        Cbxstate.Text = "Select"                                            'Textbox Text Clear
        Tblname.Clear()                                                     'Textbox Text Clear
        Tbfname.Clear()                                                     'Textbox Text Clear
        Tbphone.Clear()                                                     'Textbox Text Clear
    End Sub
    Private Sub Bfclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfclear.Click
        Taddress.Clear()                                                    'Textbox Text Clear
        Tbemail.Clear()                                                     'Textbox Text Clear
        TIDcard.Clear()                                                     'Textbox Text Clear
    End Sub
    Private Sub Bbackold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBackold.Click
        Search.Show()                                                       'Form Show
        Me.Close()                                                          'Recent Form Close
    End Sub
    Private Sub Bback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bback.Click
        loadpanel(True, False)                                      'Call Sub function With Argument
    End Sub

    Private Sub blogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogout.Click
        loginpanel(True, False)                                     'Call sub function with Argument
        T1.Text = ""                                                        'Textbox Text Clear 
        Tpassword.Text = ""                                                 'Textbox Text Clear 
        ErrorProvider1.Clear()                                              'ErrorProvider Label clear
        ErrorProvider2.Clear()                                              'ErrorProvider Label Clear
    End Sub

    Private Sub Tpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tpassword.Enter
        Tpassword.Text = ""                                                 'Textbox Text Clear 
        Tpassword.isPassword = True                                         'Textbox Text Mask
    End Sub

    'Textbox Keypress event create
    Private Sub T1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        Dim MyEmail As String = T1.Text                         'String Variable Declear with initialize
        If EmailCheck(MyEmail) = True Then                                  'Check Eamil Validation
            ErrorProvider2.Clear()                                          'ErrorProvider Label Clear
            Label2.Text = "Valid Email!"                                    'Label Text Set
            ErrorProvider1.SetError(T1, "Valid Mail")                       'ErrorProvider set
            Blogin.Visible = True                                           'Panel Visibility Set
        Else
            ErrorProvider1.Clear()                                          'ErrorProvider Clear
            ErrorProvider2.SetError(T1, "invaild mail")                     'ErrorProvider Set
            ErrorProvider2.SetError(T1, "Invalid Mail!")                    'ErrorProvider Set
            Blogin.Visible = False                                          'Panel Visibility Set
        End If
    End Sub

    'Textbox Keypress event create
    Private Sub Tbemail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbemail.KeyPress
        Dim MyEmail As String = Tbemail.Text                    'String Variable Declear with initialize
        If EmailCheck(MyEmail) = True Then                                  'Check Eamil Validation
            ErrorProvider2.Clear()                                          'ErrorProvider Label Clear
            ErrorProvider1.SetError(Tbemail, "vaild mail")                  'ErrorProvider set
            Bnext.Visible = True                                            'Panel Visibility Set
        Else
            ErrorProvider1.Clear()                                          'ErrorProvider Label Clear
            ErrorProvider2.SetError(Tbemail, "invaild mail")                'ErrorProvider set
        End If
    End Sub

    'Textbox keypress event create
    Private Sub T_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbpin.KeyPress
        'the following is all the special characters that we dont want our phonenumbers
        Dim DisallowedChars As String = ",<.>/?;:'][{}*!@#$%^&()_+-=" 'Variable declear with initialize
        If Char.IsLetter(e.KeyChar) = True Then                             'Check Character
            e.Handled = True                                                'Handaler enable
            Label4.Text = "No Character Allow!"
            ErrorProvider2.SetError(Tbpin, "PIN Number must be number only NO Character Allow!")
            Label4.BackColor = Color.Red                                    'Label Backcolor Set
            Label4.ForeColor = Color.White                                  'Label Foreclolr Set
        ElseIf DisallowedChars.Contains(e.KeyChar.ToString.ToLower) Then    'check if character
            e.KeyChar = ChrW(0)
            e.Handled = True                                                'Handaler enable
            Label4.Text = (" no Special Character Allow!")                  'Label Text Set
            ErrorProvider2.SetError(Tbpin, "Phone Numbers Must be Numbers only no Special Character Allow!")
            Label4.BackColor = Color.Red                                    'Label Backcolor Set
            Label4.ForeColor = Color.White                                  'Label Foreclolr Set
        Else
            'if character entered is numbers
            Label4.BackColor = Color.Red                                    'Label Backcolor Set
            Label4.ForeColor = Color.White                                  'Label Foreclolr Set
        End If
    End Sub

    'Textbox Keypress event Sub Function Declear
    Private Sub Tbphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbphone.KeyPress
        'the following is all the special characters that we dont want our phonenumbers
        Dim DisallowedChars As String = ",<.>/?;:'][{}*!@#$%^&()_+-=" 'Variable declear With Initilaize
        'Disallow allow all the alphabets
        If Char.IsLetter(e.KeyChar) = True Then                             'check  character
            e.Handled = True                                                'Handaler enable
            L11.Text = "No Character Allow!"                                'Label Text Set
            ErrorProvider2.SetError(Tbphone, "PIN Number must be number only NO Character Allow!")
            L11.BackColor = Color.Red                                       'Label Backcolor Set
            L11.ForeColor = Color.White                                     'Label Foreclolr Set
            'check if character that we disallowed
        ElseIf DisallowedChars.Contains(e.KeyChar.ToString.ToLower) Then     'check  character
            e.KeyChar = ChrW(0)
            e.Handled = True                                                'Handaler enable
            L11.Text = (" no Special Character Allow!")                     'Label Text Set
            ErrorProvider2.SetError(Tbphone, "Phone Numbers Must be Numbers only no Special Character Allow!")
            L11.BackColor = Color.Red                                       'Label Backcolor Set
            L11.ForeColor = Color.White                                     'Label Foreclolr Set
        Else
            'if character entered is numbers
            L11.BackColor = Color.Red
            L11.ForeColor = Color.White
        End If
    End Sub

    'Textbox Enter Event Declear
    Private Sub Tbfname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbfname.Enter
        Tbfname.Clear()
    End Sub
    Private Sub Tblname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tblname.Enter
        Tblname.Clear()
    End Sub
    Private Sub Tbphone_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbphone.Enter
        Tbphone.Clear()
    End Sub
    Private Sub Tbpin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbpin.Enter
        Tbpin.Clear()
    End Sub
    Private Sub Taddress_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Taddress.Enter
        Taddress.Clear()
    End Sub
    Private Sub TIDcard_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIDcard.Enter
        TIDcard.Clear()
    End Sub
    Private Sub Tbemail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbemail.Enter
        Tbemail.Clear()
    End Sub
    'Textbox Clear event Close

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        background.Show()                                                   'Form Open
        ExitPopup.Show()                                                    'Form Open
        ExitPopup.TopMost = True                                            'Topmost priority Set
    End Sub

    'Button Click Event Genetate
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MainWindows.Transition2.ShowSync(MainWindows)                       'Form Open
        If MainWindows.Visible Then                                         'Check visibility
            Me.Close()                                                      'Recent Form Close
        End If
    End Sub
End Class