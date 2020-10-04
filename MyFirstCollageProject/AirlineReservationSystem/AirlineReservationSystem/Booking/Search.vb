Public Class Search
    Private access As New DBControls                                        ' database object create
    Private Sub Search_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Cbxform.Text = source                                               ' label text set
        Cbxto.Text = destination                                            ' label text set
        access.ExecQuery("SELECT * FROM airport ORDER BY from ASC")         ' RUN QUERY
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        For Each R As DataRow In access.DBDT.Rows                           ' FILL COMBOBOX
            Cbxform.Items.Add(R("from"))                                    ' combobox data add
        Next
        RefreshGrid()                                                       'call sub function
    End Sub

    'declear notempty private function
    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    'declear refreshgrid sub function
    Public Sub RefreshGrid()
        access.ExecQuery("SELECT depart,arrive,duration,flightname,price FROM shedule " & _
                         " where source='" & Cbxform.Text & "' and destination='" & Cbxto.Text & "'") ' RUN QUERY
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        dgvdata.DataSource = access.DBDT                                    ' FILL DATAGRID
    End Sub

    'button click event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindows.Transition1.ShowSync(loading)                           'loading form check
        If Not selectseatprice = 0 Then                                     'check global variable value
            MainWindows.Transition2.ShowSync(travelling)
            If travelling.Visible Then                                      'Form visibility check
                Me.Close()                                                  'recent open form close
            End If
        Else
            MsgBox("Please choose one flight", MsgBoxStyle.Exclamation)     ' msgbox function declear
        End If
        loading.Close()                                                     ' loading form close
    End Sub
    
    Private Sub Cbxform_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbxform.SelectedIndexChanged

        access.ExecQuery("SELECT * FROM airport ORDER BY to ASC")            ' RUN QUERY
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        Cbxto.Items.Clear()                                                  'Combobox clear
        Cbxto.Text = "Select"                                                'Combobox text set
        For Each R As DataRow In access.DBDT.Rows                            'FILL COMBOBOX
            If R("to") = Cbxform.Text Then                                   'check cbx1 and cbx2 text
                GoTo l                                                       'label goto
            Else
                Cbxto.Items.Add(R("to"))                                     'add combobox data
            End If
l:          ' label declear
        Next
    End Sub

    Private Sub dgvdata_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdata.CellClick
        Dim index As Integer                                                'integer variable declear
        index = e.RowIndex                                                  'get the index
        Dim selectedRow As DataGridViewRow                                  'ariable declear
        selectedRow = dgvdata.Rows(index)                                   'store selected row value
        selectseatprice = selectedRow.Cells(4).Value                        'Store Global veriable data
        flightno = selectedRow.Cells(3).Value                               'Store Global veriable data
        Lflightprice.Text = "₹ " + selectseatprice.ToString + " /-"         'Level Text Set
    End Sub

    'Blogin button click event
    Private Sub Blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogin.Click
        MainWindows.Transition1.ShowSync(Login)                              'Animater LogIn from show
        If Login.Visible Then                                                'Visiblity Check
            Me.Close()                                                       'Recent open from close
        End If
    End Sub

    'Bregister click event
    Private Sub Bregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bregister.Click
        MainWindows.Transition2.ShowSync(MemberRegistation)                   'Animater LogIn from show
        If MemberRegistation.Visible Then                                     'Visiblity Check
            Me.Close()                                                        'Recent open from close
        End If
    End Sub

    'Bhome button click event
    Private Sub Bhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhome.Click
        MainWindows.Transition2.ShowSync(MainWindows)                          'Animated Form open
        If MainWindows.Visible Then                                            'Form visibility check
            Me.Close()                                                         'recent open form close
        End If
    End Sub

    'Bsearch click event
    Private Sub Bsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsearch.Click
        RefreshGrid()                                                          'call sub function
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MainWindows.Transition2.ShowSync(MainWindows)                          'animated Form open
        If MainWindows.Visible Then                                            'Form visibility check
            Me.Close()                                                         'recent open form close
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        background.Show()                                                       'backgroup form open
        ExitPopup.Show()                                                        'exitpupup form open
        ExitPopup.TopMost = True                                                'topmost priority set
    End Sub
End Class
