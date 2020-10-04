Imports System.Text.RegularExpressions
Public Class MyProfile
    Dim access As New DBControls
    Dim date1, pname, pno, pamount, ptamount, pflight As String
    Dim date2() As String
    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Panelsetup(ByVal s0 As Boolean, ByVal s1 As Boolean, _
                            ByVal s2 As Boolean, ByVal s3 As Boolean, ByVal s4 As Boolean)
        PDashbord.Visible = s0
        PManageMyBook.Visible = s1
        PSpecialOffer.Visible = s2
        PMyProfile.Visible = s3
        PPassangerList.Visible = s4
        sidepanelcheck()
        If PDashbord.Visible = True Then

            access.ExecQuery("SELECT firstname,lastname,phone,email,address,city,state,country,pin " & _
                             "FROM Admin where email='" & usernamedata & "' or phone='" & userphone & "'")
            DGV3.DataSource = access.DBDT
            Dim selectedRow As DataGridViewRow
            selectedRow = DGV3.Rows(0)
            TDBfname.Text = selectedRow.Cells(0).Value
            TDBlname.Text = selectedRow.Cells(1).Value
            TDBphone.Text = selectedRow.Cells(2).Value
            TDBemail.Text = selectedRow.Cells(3).Value
            TDBaddress.Text = selectedRow.Cells(4).Value
            TDBcity.Text = selectedRow.Cells(5).Value
            TDBstate.Text = selectedRow.Cells(6).Value
            TDBcountry.Text = selectedRow.Cells(7).Value
            TDBpin.Text = selectedRow.Cells(8).Value
            useremail = selectedRow.Cells(3).Value
        ElseIf PManageMyBook.Visible = True Then
            access.ExecQuery("SELECT name,tpassenger,amount,totalamount,source,destination,flightno,status " & _
                             "from [passengers] WHERE email='" & usernamedata & "' or phone='" & userphone & "'")
            DataGridView1.DataSource = access.DBDT
        ElseIf PSpecialOffer.Visible = True Then

        ElseIf PMyProfile.Visible = True Then
            access.ExecQuery("SELECT title,firstname,lastname,dob,address,address2,city,state" & _
                             ",country,phone,email,pin FROM Admin where email='" & usernamedata & "' or phone='" & userphone & "'")
            DGV3.DataSource = access.DBDT
            Dim selectedRow As DataGridViewRow
            selectedRow = DGV3.Rows(0)
            cbxtitle.Text = selectedRow.Cells(0).Value
            TMPfname.Text = selectedRow.Cells(1).Value
            TMPlname.Text = selectedRow.Cells(2).Value
            date1 = selectedRow.Cells(3).Value
            date2 = date1.Split("/")
            cbxday.Text = date2(0)
            cbxmonth.Text = date2(1)
            cbxyear.Text = date2(2)
            TMPaddress1.Text = selectedRow.Cells(4).Value
            TMPaddress2.Text = selectedRow.Cells(5).Value
            TMPcity.Text = selectedRow.Cells(6).Value
            cbxstate.Text = selectedRow.Cells(7).Value
            cbxcountry.Text = selectedRow.Cells(8).Value
            TMPmobile.Text = selectedRow.Cells(9).Value
            TMPemail.Text = selectedRow.Cells(10).Value
            TMPpin.Text = selectedRow.Cells(11).Value
        ElseIf PPassangerList.Visible = True Then
            access.ExecQuery("SELECT PNR,name,tpassenger,amount,addon,discount,source,destination," & _
                             "flightno,status from [passengers] WHERE email='" & usernamedata & "' or phone='" & userphone & "'")
            DataGridView2.DataSource = access.DBDT
        End If
    End Sub
    Private Sub labelcolor(ByVal c1 As Color, ByVal c2 As Color, ByVal c3 As Color, ByVal c4 As Color, ByVal c5 As Color)
        LDB.ForeColor = c1
        LMMB.ForeColor = c2
        LMP.ForeColor = c3
        LPL.ForeColor = c4
        LSO.ForeColor = c5
    End Sub

    Private Sub MyProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Exitpopup From close
        If Me.Visible = True Then
            ExitPopup.Dispose()
        End If
        If RESET_PASSWORD.Visible = False Then
            RESET_PASSWORD.Dispose()
        End If

        'panel fn call
        Panelsetup(True, False, False, False, False)

        'label fn initilation
        labelcolor(Color.Blue, Color.Black, Color.Black, Color.Black, Color.Black)
        Lselect.ForeColor = Color.Blue

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set
    End Sub
    Private Sub MyProfile_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim username As String
        If logindata = True Then
            access.ExecQuery("SELECT firstname FROM Admin where email='" & usernamedata & "' or phone='" & userphone & "'")
            DGV3.DataSource = access.DBDT
            Dim selectedRow As DataGridViewRow
            selectedRow = DGV3.Rows(0)
            username = selectedRow.Cells(0).Value
            Lmpusername.Text = "Hi, " + username
        Else
            Lmpusername.Text = ""
        End If

        'Combobox title data initialize
        cbxtitle.Items.Add("Mr.")
        cbxtitle.Items.Add("Mrs.")

        'Combobox Day data initialize
        For i = 1 To 31
            If i < 10 Then
                cbxday.Items.Add("0" + i.ToString)
            Else
                cbxday.Items.Add(i)
            End If
        Next

        'Combobox Month data initialize
        For i = 1 To 12
            If i < 10 Then
                cbxmonth.Items.Add("0" + i.ToString)
            Else
                cbxmonth.Items.Add(i)
            End If
        Next

        'Combobox Year data initialize
        For i = 1965 To 2018
            cbxyear.Items.Add(i)
        Next

        'Combobox State data initialize
        access.ExecQuery("SELECT * FROM Country ORDER BY state ASC")
        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxstate.Items.Add(R("state"))
        Next

        'Combobox Country data initialize
        access.ExecQuery("SELECT * FROM Country ORDER BY country ASC")
        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxcountry.Items.Add(R("country"))
        Next
    End Sub


    Private Sub LDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDB.Click

        'panel fn call
        Panelsetup(True, False, False, False, False)

        'label fn initilation
        labelcolor(Color.Blue, Color.Black, Color.Black, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(983, 45)
        'end label location set

    End Sub

    Private Sub LMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMP.Click

        'panel fn call
        Panelsetup(False, False, False, True, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Blue, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(795, 45)
        'end label location set
    End Sub

    Private Sub LMMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMMB.Click

        'panel fn call
        Panelsetup(False, True, False, False, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Blue, Color.Black, Color.Black, Color.Black)

        'select label location
        Lselect.Location = New Point(605, 45)
        'end label location set

    End Sub

    Private Sub LPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPL.Click

        'panel fn call
        Panelsetup(False, False, False, False, True)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Blue, Color.Black)

        'select label location
        Lselect.Location = New Point(391, 45)

    End Sub

    Private Sub LSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSO.Click, Lselect.Click

        'panel fn call
        Panelsetup(False, False, True, False, False)

        'label fn initilation
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Black, Color.Blue)

        'select label location
        Lselect.Location = New Point(187, 45)

    End Sub

    'Logout button call
    Private Sub Blogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogout.Click
        MainWindows.Transition1.ShowSync(loading)
        MainWindows.Transition2.ShowSync(MainWindows)
        logindata = False
        usernamedata = ""
        userphone = ""
        seatchoose = 0
        seatdiscount = 0
        addon = 0
        source = ""
        destination = ""
        flightno = ""
        selectseatprice = 0
        totalprice = 0
        If MainWindows.Visible = True Then
            Me.Hide()
        End If
        loading.Close()
    End Sub

    'Exit Button click
    Private Sub BExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExit.Click
        ExitPopup.TopMost = True
        ExitPopup.Show()
    End Sub


    Private Sub BBflight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBflight.Click
        MainWindows.Transition2.ShowSync(Search)
        If Search.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TDBphone.TextChanged, TDBstate.TextChanged, TDBpin.TextChanged, TDBcountry.TextChanged, TDBcity.TextChanged, TDBaddress.TextChanged

    End Sub

    Private Sub BMPcngpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMPcngpass.Click
        access.ExecQuery("SELECT password FROM Admin where password='" & TMPoldpass.Text & "' and email='" & usernamedata & "'")
        If TMPnewpass.Text = TMPcnfpass.Text Then
            If access.DBDT.Rows.Count <> 0 Then
                access.AddParam("@newpassword", TMPnewpass.Text)
                access.ExecQuery("update Admin set [password]='" & TMPnewpass.Text & "' where password='" & TMPoldpass.Text & "' and email='" & usernamedata & "'")
                If Not String.IsNullOrEmpty(access.Exception) Then LMPwarning.Text = "Your old password is not match!" : Exit Sub
                MsgBox("User password change successfully.", MsgBoxStyle.Information)
                TMPoldpass.Clear()
                TMPnewpass.Clear()
                TMPcnfpass.Clear()
            Else
                MsgBox("Your Old Password Is Not Match!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("You enter password are not match!", MsgBoxStyle.OkOnly, vbCritical)
        End If
    End Sub

    Private Sub BMPupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMPupdate.Click
        Dim datejoin As String

        datejoin = cbxday.Text + "/" + cbxmonth.Text + "/" + cbxyear.Text

        access.ExecQuery("update Admin set title='" & cbxtitle.Text & "',firstname='" & TMPfname.Text & "'" & _
                         ",lastname='" & TMPlname.Text & "',dob='" & datejoin & "',address='" & TMPaddress1.Text & "' " & _
                         ",address2='" & TMPaddress2.Text & "',city='" & TMPcity.Text & "',state='" & cbxstate.Text & "'" & _
                         ",country='" & cbxcountry.Text & "',phone='" & TMPmobile.Text & "',email='" & TMPemail.Text & "' " & _
                         ",pin='" & TMPpin.Text & "' where email='" & usernamedata & "' or phone='" & userphone & "'")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        usernamedata = TMPemail.Text
        MsgBox("User Data update successfully.", MsgBoxStyle.Information)
    End Sub

    'side panel button option
    Private Sub BFlightS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFlightS.Click
        sidepanelcheck()
        flightstatuepanel()
    End Sub
    Private Sub BCheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCheckin.Click
        sidepanelcheck()
        checkinpanel()
    End Sub
    Private Sub BCDU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCDU.Click
        sidepanelcheck()
        bookingviewpanel()
    End Sub
    Private Sub Bnotification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnotification.Click
        sidepanelcheck()
        Pnotification.Visible = True
    End Sub
    Private Sub BWheather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWheather.Click
        sidepanelcheck()
        wheather()
    End Sub
    Private Sub BShedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BShedule.Click
        sidepanelcheck()
        shedule()
    End Sub
    Private Sub BAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAbout.Click
        sidepanelcheck()
        Pabout.Visible = True
    End Sub
    Private Sub BHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHelp.Click
        sidepanelcheck()
        Phelp.Visible = True
    End Sub

    Private Sub wheather()
        Pweather.Visible = True
        Dim temp, humidity, wind, pre As New Random
        Ltemp.Text = temp.Next(20, 35)
        Lhumidity.Text = humidity.Next(60, 80)
        Lprecipitation.Text = pre.Next(2, 6)
        Lwind.Text = wind.Next(8, 20)
    End Sub
    Private Sub shedule()
        Pshedule.Visible = True
        access.ExecQuery("SELECT source,destination,flightname,depart,arrive,duration from Shedule")
        dgvshedule.DataSource = access.DBDT
    End Sub
    Private Sub checkinpanel()
        MainWindows.Transition2.ShowSync(Checkin)
        Checkin.Size = New Size(1116, 642)
        Checkin.Location = New Point(0, 126)
        Checkin.P1.Location = New Point(-125, 199)
        Checkin.P2.Location = New Point(-125, 199)
    End Sub
    Private Sub flightstatuepanel()
        MainWindows.Transition2.ShowSync(flight_status)
        flight_status.Size = New Size(1116, 642)
        flight_status.Location = New Point(0, 126)
        flight_status.Panel1.Location = New Point(58, 215)
        flight_status.Panel2.Location = New Point(58, 215)
    End Sub
    Private Sub bookingviewpanel()
        MainWindows.Transition2.ShowSync(view_book)
        view_book.Size = New Size(1116, 642)
        view_book.Location = New Point(0, 126)
        view_book.Panel1.Location = New Point(58, 221)
        view_book.Panel2.Location = New Point(58, 221)
    End Sub
    Private Sub sidepanelcheck()
        view_book.Close()
        flight_status.Close()
        Checkin.Close()
        Phelp.Visible = False
        Pshedule.Visible = False
        Pabout.Visible = False
        Pweather.Visible = False
        Pnotification.Visible = False
    End Sub



    Private Sub MPcheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPcheck.Click
        access.ExecQuery("SELECT name,tpassenger,amount,totalamount,source,destination,flightno,status" &
                         " from [passengers] WHERE email='" & usernamedata & "' or phone='" & userphone & "'")
        DataGridView1.DataSource = access.DBDT
    End Sub


    Private Sub TMPmobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TMPmobile.KeyPress
        'the following is all the special characters that we dont want our phonenumbers
        Dim DisallowedChars As String = ",<.>/?;:'][{}*!@#$%^&()_+-="

        'Disallow allow all the alphabets
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
            Label4.Text = "No Character Allow!"
            ErrorProvider2.SetError(TMPmobile, "PIN Number must be number only NO Character Allow!")
            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White

            'check if character that we disallowed
        ElseIf DisallowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            e.KeyChar = ChrW(0)
            e.Handled = True

            Label4.Text = (" no Special Character Allow!")
            ErrorProvider2.SetError(TMPmobile, "Phone Numbers Must be Numbers only no Special Character Allow!")
            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White

        Else
            'if character entered is numbers

            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White

        End If
    End Sub
    Private Sub TMPemail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TMPemail.KeyPress
        Dim MyEmail As String = TMPemail.Text
        If EmailCheck(MyEmail) = True Then
            ErrorProvider2.Clear()
            'Label2.Text = "Valid Email!"
            ErrorProvider1.SetError(TMPemail, "vaild mail")

        Else
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(TMPemail, "invaild mail")
            'Label2.Text = "Invalid Email!"
        End If
    End Sub
    Private Sub TMPpin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TMPpin.KeyPress
        'the following is all the special characters that we dont want our phonenumbers
        Dim DisallowedChars As String = ",<.>/?;:'][{}*!@#$%^&()_+-="

        'Disallow allow all the alphabets
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
            Label4.Text = "No Character Allow!"
            ErrorProvider2.SetError(TMPpin, "PIN Number must be number only NO Character Allow!")
            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White

            'check if character that we disallowed
        ElseIf DisallowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            Label4.Text = (" no Special Character Allow!")
            ErrorProvider2.SetError(TMPpin, "Phone Numbers Must be Numbers only no Special Character Allow!")
            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White
        Else
            'if character entered is numbers
            Label4.BackColor = Color.Red
            Label4.ForeColor = Color.White
        End If
    End Sub

    Private Sub MPcancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPcancle.Click
        If Not pno = pname Then
            access.ExecQuery("update [passengers] set [status]='" & "CAN" & "' where name='" & pname & "' and tpassenger='" & pno & "' and " & _
                         "amount='" & pamount & "' and totalamount='" & ptamount & "' and flightno='" & pflight & "'")

            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

            MsgBox("User Cancel successfully." + vbNewLine + "Your Amoun Refund Next 24 hr.", MsgBoxStyle.Information)
            pname = ""
            pno = ""
            pamount = ""
            ptamount = ""
            pflight = ""
        Else
            MsgBox("Please Select Your Ticket !", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ' now show data from the selected row to textboxes
        pname = selectedRow.Cells(0).Value
        pno = selectedRow.Cells(1).Value
        pamount = selectedRow.Cells(2).Value
        ptamount = selectedRow.Cells(3).Value
        pflight = selectedRow.Cells(6).Value
    End Sub

End Class