Imports System.Data.OleDb                                       'Import system OleDb function
Public Class payment
    Dim access As New DBControls                                'DBcontrols object create
    Dim i As Integer = 0                                        'Integer varible declear as initilise

    'Payment form shown event
    Private Sub payment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'call Panel Loading function
        pload(True, False, False, False, False, False, False)    'Send argument pload sub function
        'call picture Loading function
        picload(False, False, False, False, False)               'send argument picload sub function
    End Sub

    'declear wallet checking function
    Private Sub walletchk(ByVal ck As Boolean, ByVal ck1 As Boolean) 'Recive argument walletchk sub function
        Cb2.Checked = ck                                          'Checkbox2 checked switcthing
        Cb1.Checked = ck1                                         'Checkbox1 checked switcthing
    End Sub

    'declear panel loading function 
    Private Sub pload(ByVal v1 As Boolean, ByVal v2 As Boolean, ByVal v3 As Boolean, ByVal v4 As Boolean, ByVal v5 As Boolean, _
                      ByVal v6 As Boolean, ByVal v7 As Boolean)    'Recived argument pload sub function
        Pwelcome.Visible = v1                                       'panel visiblity switching
        Pcomplite.Visible = v2                                      'panel visiblity switching
        PCreditCard.Visible = v3                                    'panel visiblity switching
        Pupi.Visible = v4                                           'panel visiblity switching
        Pvoucher.Visible = v5                                       'panel visiblity switching
        Pnetbanking.Visible = v6                                    'panel visiblity switching
        Pwallet.Visible = v7                                        'panel visiblity switching
    End Sub

    'declear waiting picture loading function
    Private Sub picload(ByVal p1 As Boolean, ByVal p2 As Boolean, ByVal p3 As Boolean, ByVal p4 As Boolean, _
                        ByVal p5 As Boolean)                         'Recive picture loading function
        PictureBox1.Visible = p1                                     'PictureBox1 visiblity switching
        PictureBox2.Visible = p2                                     'PictureBox2 visiblity switching
        PictureBox3.Visible = p3                                     'PictureBox3 visiblity switching
        PictureBox4.Visible = p4                                     'PictureBox4 visiblity switching
        PictureBox5.Visible = p5                                     'PictureBox5 visiblity switching
    End Sub

    'Credit card button click event 
    Private Sub CCDButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCDCButton.Click

        'call Panel Loading function
        pload(False, False, True, False, False, False, False)           'Send argument pload sub function
    End Sub

    'Wallet button click event
    Private Sub WalletButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WalletButton.Click

        'call Panel Loading function
        pload(False, False, False, False, False, False, True)           'Send argument pload subfunction
    End Sub

    'Vouture button click event
    Private Sub VoutureButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoutureButton.Click

        'call Panel Loading function
        pload(False, False, False, False, True, False, False)           'Send argument pload sub function

    End Sub

    'Internet Banking Button click event
    Private Sub IBButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IBButton.Click

        'call Panel Loading function
        pload(False, False, True, False, False, True, False)            'Send argument pload sub function
    End Sub

    'UPI button click event
    Private Sub UPIButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPIButon.Click

        'call Panel Loading function
        pload(False, False, False, True, False, False, False)           'Send argument pload sub function
    End Sub

    'Timer tick event 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim time1, time2 As New Random                                   'Declear time1 and time2 randiom variable
        Dim depature As String                                           'Declear string variable
        i += 1                                                            'Increment 1 values bye 'i' varible
        If i = 50 Then                                                    'check value of 'i'
            MainWindows.Transition1.ShowSync(loading)
            depature = time1.Next(0, 24).ToString + ":" + time2.Next(0, 59).ToString 'Store two random variable data
            Timer1.Stop()                                                 'stop timer
            Dim name As String                                            'Declear string variable
            name = tt0 + " " + tt1 + " " + tt2                            'Store data tt0,tt1 and tt3's values
            access.AddParam("@bncinfo", source)                           'send data database object
            access.AddParam("@status", "CNF")                             'send data database object
            access.AddParam("@flightdate", userdate)                      'send data database object
            access.AddParam("@flightname", flightno)                      'send data database object
            access.AddParam("@source", source)                            'send data database object
            access.AddParam("@destination", destination)                  'send data database object
            access.AddParam("@flighttime", depature)                      'send data database object
            Dim thisday As Date                                           'Declear date variable
            thisday = Today                                               'Store System Date data
            access.AddParam("@rdate", thisday)                            'send data database object
            access.AddParam("@name", name)                                'send data database object
            access.AddParam("@address", tt9)                              'send data database object
            access.AddParam("@phone", tt3)                                'send data database object
            access.AddParam("@email", tt4)                                'send data database object
            access.AddParam("@state", tt5)                                'send data database object
            access.AddParam("@country", tt6)                              'send data database object
            access.AddParam("@pin", tt7)                                  'send data database object
            access.AddParam("@idno", tt8)                                 'send data database object
            access.AddParam("@amount", selectseatprice)                   'send data database object
            access.AddParam("@addon", addon)                              'send data database object
            access.AddParam("@totalamount", totalprice)                   'send data database object
            access.AddParam("@tpassenger", seatchoose)                    'send data database object
            access.AddParam("@discount", seatdiscount)                    'send data database object

            'call Panel Loading function
            pload(False, True, False, False, False, False, False)         'Send Argument sub function

            ' EXECUTE INSERT COMMAND
            access.ExecQuery("INSERT INTO [passengers] ([bncinfo],[status],[flightdate],[flightno]," & _
                             "[source],[destination],[departure],[resdate],[name],[address],[phone],[email]," & _
                             "[state],[country],[pin],[idno],[amount],[addon],[totalamount],[tpassenger]," & _
                             "[discount]) VALUES (@bncinfo,@status,@flightdate,@flightname,@source,@destination,@flighttime," & _
                             "@rdate,@name,@address,@phone,@email,@state,@country,@pin" & _
                             ",@idno,@amount,@addon,@totalamount,@tpassenger,@discount);")

            'REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            Dim maxid As Object                                             'declear object variable
            access.ExecQuery("select MAX(PNR) from passengers")             'Execute Quary
            access.DBDA.SelectCommand.Connection.Open()                     'DB connection Open
            maxid = access.DBDA.SelectCommand.ExecuteScalar()               'Command Execute

            'Print flight ticket initilazition
            Dim star As String                                              'Declear string variable
            star = "**********************************************************************************"
            Printbox.Text = star + vbNewLine + "                                AIRLINE RESERVATION TICKET" + vbNewLine + star + vbNewLine + star + vbNewLine + vbNewLine + "" & _
                "BRANCH INFO.   	:" + source + "		STATUS		CNF" + vbNewLine + star + vbNewLine + "" & _
"" + vbNewLine + "TICKET INFORMATION" & _
"" + vbNewLine + "'''''''''''''''''''''''''''''''''''''''''''''" + vbNewLine + "" & _
"" + vbNewLine + "PNR		:	" + maxid.ToString + "" & _
"" + vbNewLine + "FLIGHT DATE       :	" + userdate + "          FLIGHT NO	:" + flightno + "" & _
"" + vbNewLine + "FROM		:	" + source + "	DEPARTURE	:" + depature + "" & _
"" + vbNewLine + "TO  		:	" + destination + "	JOURNEY	:" + seatchoose.ToString + "" & _
"" + vbNewLine + "DESCRIPTION 	:	" + source + " TO " + destination + "" & _
"" + vbNewLine + "RESERVATION DATE:	" + thisday + "" + vbNewLine + star + vbNewLine + "" & _
"" + vbNewLine + "PASSENGER'S INFORMATION:" & _
"" + vbNewLine + "''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''" + vbNewLine + "" & _
"" + vbNewLine + "NAME		:	" + name + "" & _
"" + vbNewLine + "ADDRESS	:	" + tt9 + "" & _
"" + vbNewLine + "MOBILE NO	:	" + tt3 + "" & _
"" + vbNewLine + "Email		:	" + tt4 + "" & _
"" + vbNewLine + "PIN		:	" + tt7 + "" & _
"" + vbNewLine + "ID NO		:	" + tt8 + "" & _
"" + vbNewLine + "AMOUNT            :	" + selectseatprice.ToString + "" & _
"" + vbNewLine + "Addon		:	" + addon.ToString + "" & _
"" + vbNewLine + "Total Passengers  :	" + seatchoose.ToString + "" & _
"" + vbNewLine + "Discount              :         " + seatdiscount.ToString + "% " + vbNewLine + star + "" & _
"" + vbNewLine + "Total price	:	" + totalprice.ToString + " /- Rupees Only" + vbNewLine + star + " "
            'timer variable value initialize
            i = 0
            loading.Close()
        End If
    End Sub

    'Checkbox1 Change event
    Private Sub Cb1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb1.OnChange
        'call wallet checking function
        walletchk(False, True)                                              'Send argument Sub function
    End Sub
    Private Sub Cb2_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb2.OnChange
        'call wallet checking function
        walletchk(True, False)                                              'Send argument sub functiom

    End Sub

    'Submit clock event
    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bwsubmit.Click, Bnbcancle.Click, Bvsubmit.Click, Bupiubmit.Click, Bsubmit.Click
        'timer start 
        Timer1.Start()
        'call Picture Loading function
        picload(True, True, True, True, True)                               'Send argument sub functiom
    End Sub

    'PayExit button click event
    Private Sub PayExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayExit.Click
        ExitPopup.Show()                                                    'Form show
        ExitPopup.TopMost = True                                            'TopMost priority set
    End Sub

    'Bsave button click event
    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        SaveFiled.Filter = "Text File|*.txt |All File|*.*"                  'Printing tikit format Filter
        If Printbox.Text = "" Then                                          'Check textbox value
            MsgBox("Your text box is empty", MsgBoxStyle.Information)       'massagebox data set
        ElseIf SaveFiled.ShowDialog = Windows.Forms.DialogResult.OK Then                                        '
            My.Computer.FileSystem.WriteAllText(SaveFiled.FileName, Printbox.Text, True) 'Open windows file system
        End If
    End Sub

    'Bprint button click event
    Private Sub Bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bprint.Click
        PrintDocument1.Print()                                                'Tickit details Print Document 
    End Sub

    'Bpreview Button Click event
    Private Sub BPprivew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPprivew.Click
        PrintPreviewd.ShowDialog()                                            'TPrint Preview in Show Dialog
    End Sub

    'Bhome button Click event
    Private Sub BHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHome.Click
        MainWindows.Transition2.ShowSync(MainWindows)                         'Show Main window From
        Me.Close()                                                            'REcent form close
    End Sub

    'Document print function declear
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Century Gothic", 16, FontStyle.Bold)           'Printing front style object create
        e.Graphics.DrawString(Printbox.Text, font1, Brushes.Black, 20, 20)    'Object passing Graphics function
    End Sub

    'Picturebox8 click event
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        MainWindows.Transition2.ShowSync(MainWindows)                          'Show Form
        If MainWindows.Visible Then                                            'Form visiblity check
            Me.Close()                                                         'Close the recent form
        End If
    End Sub
End Class
