Public Class MainWindows
    Dim i As Integer = 1
    Private access As New DBControls                                'Database connecton object create

    Private Function NotEmpty(ByVal text As String) As Boolean      'Database empty checked data in database
        Return Not String.IsNullOrEmpty(text)                       'return text
    End Function
    Private Sub checkdiscount(ByVal e1 As Boolean, ByVal e2 As Boolean, ByVal e3 As Boolean)
        Ck1.Checked = e1                                            'Checked box state change
        Ck2.Checked = e2                                            'Checked box state change
        Ck3.Checked = e3                                            'Checked box state change
    End Sub

    'checking panel status
    Private Sub checkingstatus()                                    'Checking Manu color function
        If LVCB.ForeColor = Color.Blue Then                         'If label view/check booking color is blue
            Transition2.ShowSync(view_book)                         'form view book show
            Checkin.Close()                                         'form checkin close
            flight_status.Close()                                   'form flight status close
        ElseIf LCI.ForeColor = Color.Blue Then
            Transition2.ShowSync(Checkin)
            view_book.Close()
            flight_status.Close()
        ElseIf LFS.ForeColor = Color.Blue Then
            Transition2.ShowSync(flight_status)
            view_book.Close()
            Checkin.Close()
        Else
            view_book.Close()
            Checkin.Close()
            flight_status.Close()
        End If
    End Sub

    'label color set function
    Private Sub labelcolor(ByVal e1 As Color, ByVal e2 As Color, ByVal e3 As Color, ByVal e4 As Color, ByVal e5 As Color)
        LSU.ForeColor = e1                                          'Flight search coler set
        LFS.ForeColor = e2                                          'login/sign coler set
        LCI.ForeColor = e3                                          'Check in coler set
        LVCB.ForeColor = e4                                         'Check Booking coler set
        LBF.ForeColor = e5                                          'Booking Flight coler set
    End Sub
    Private Sub seatdisc()                                          'Seat Discount generate function
        If Ck1.Checked = True Then                                  'if user select student checkbox then this condition run
            seatdiscount = 30                                       'if user choose student checkbox then discount store 30%
        ElseIf Ck2.Checked = True Then                              'if user select seneior citizen checkbox then this condition run
            seatdiscount = 8                                        'if user choose senior citizen checkbox then discount store 8%
        ElseIf Ck3.Checked = True Then                              'if user select IAF checkbox then this condition run
            seatdiscount = 50                                       'if user choose IAF checkbox then discount store 50%
        End If
    End Sub

    'By This Form Load Which Property Working or Loading
    Private Sub MainWindows_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Total Passenger Choose
        For k = 1 To 6
            Cbxseat.Items.Add(k)
        Next

        ' RUN QUERY
        access.ExecQuery("SELECT * FROM airport ORDER BY from ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        ' FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            Cbxform.Items.Add(R("from"))
        Next
        RBOne.Checked = True
    End Sub
    Private Sub MainWindows_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.TopMost = True Then
            MyProfile.Close()
        End If
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Black, Color.Blue)
    End Sub

    'Button or Checkbox Click Event
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
    Private Sub LBF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBF.Click
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Black, Color.Blue)
        checkingstatus()
    End Sub
    Private Sub LCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCI.Click
        labelcolor(Color.Black, Color.Black, Color.Blue, Color.Black, Color.Black)
        checkingstatus()
        Checkin.Location = New Point(0, 114)
    End Sub
    Private Sub LFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFS.Click
        labelcolor(Color.Black, Color.Blue, Color.Black, Color.Black, Color.Black)
        checkingstatus()
        flight_status.Location = New Point(0, 114)
    End Sub
    Private Sub LVCB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVCB.Click
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Blue, Color.Black)
        checkingstatus()
        view_book.Location = New Point(0, 114)
    End Sub
    Private Sub LSU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSU.Click
        labelcolor(Color.Black, Color.Black, Color.Black, Color.Black, Color.Blue)
        checkingstatus()
        Transition2.ShowSync(Login)
        If Login.Visible Then
            Me.Hide()
        End If
    End Sub
    
    Private Sub Ck1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck1.OnChange
        checkdiscount(True, False, False)
        DPR.Checked = True
    End Sub
    Private Sub Ck2_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck2.OnChange
        checkdiscount(False, True, False)
    End Sub
    Private Sub Ck3_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ck3.OnChange
        checkdiscount(False, False, True)
    End Sub

    'search button Click event
    Private Sub Btsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btsearch.Click
        Transition1.ShowSync(loading)
        'source and destination data sent search form
        userdate = DPD.Text
        source = Cbxform.Text
        destination = Cbxto.Text
        If Cbxform.Text = "Form" And Cbxto.Text = "To" Or Cbxto.Text = "Select" Or Cbxseat.Text = "Sit" Then
            MsgBox("Fill in The Your Source and destination and Sit Filds", MsgBoxStyle.Exclamation)
            loading.Close()
        Else
            Me.Hide()
            seatdisc()
            Transition2.ShowSync(Search)
            Search.DPD.Text = userdate
            seatchoose = Convert.ToInt32(Cbxseat.Text)
            loading.Close()
        End If
    End Sub

    'check Radiobutton status
    Private Sub RBReturn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBReturn.CheckedChanged
        If RBReturn.Checked = True Then
            DPR.Enabled = True
        Else
            DPR.Enabled = False
        End If
    End Sub

    'Exit Button Function Create
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        background.Show()
        ExitPopup.Show()
        ExitPopup.TopMost = True
    End Sub

    'Animated panel create   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 10 Then
            des1.Visible = True
            des7.Visible = False
            i += 1
        ElseIf i = 20 Then
            des2.Visible = True
            des1.Visible = False
            i += 1
        ElseIf i = 30 Then
            des3.Visible = True
            des2.Visible = False
            i += 1
        ElseIf i = 40 Then
            des4.Visible = True
            des3.Visible = False
            i += 1
        ElseIf i = 50 Then
            des5.Visible = True
            des4.Visible = False
            i += 1
        ElseIf i = 60 Then
            des6.Visible = True
            des5.Visible = False
            i += 1
        ElseIf i = 70 Then
            des7.Visible = True
            des6.Visible = False
            i = 1
        Else
            i += 1
        End If
    End Sub
End Class