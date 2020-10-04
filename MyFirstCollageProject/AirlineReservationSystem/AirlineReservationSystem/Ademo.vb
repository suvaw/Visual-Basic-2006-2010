Public Class Ademo
    Private access As New DBControls
    Dim al As String
    Private Function NotEmpty(ByVal text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub RefreshGrid()
        ' RUN QUERY
        access.ExecQuery("SELECT * FROM [Table] ORDER BY username DESC")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        DTVdata.DataSource = access.DBDT

        ' CLEAR COMBOBOX
        CBdata.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            CBdata.Items.Add(R("username"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If access.RecordCount > 0 Then CBdata.SelectedIndex = 0
    End Sub

    Private Sub Ademo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' RUN QUERY
        access.ExecQuery("SELECT * FROM [Table] ORDER BY username ASC")
        If NotEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        RefreshGrid()

        '' FILL DATAGRID
        DTVdata.DataSource = access.DBDT

        '' FILL COMBOBOX
        'For Each R As DataRow In access.DBDT.Rows
        '    CBdata.Items.Add(R("username"))
        'Next

        '' DISPLAY FIRS NAME FOUND
        If access.RecordCount > 0 Then CBdata.SelectedIndex = 0
        Panel1.Visible = False
    End Sub

    Private Sub SearchMember(ByVal Name As String)
        ' ADD PARAMETERS & RUN QUERY
        access.AddParam("@user", "%" & Name & "%")
        access.ExecQuery("SELECT username, userpassword, email " & "FROM [Table] " & "WHERE username LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(access.Exception) Then Label1.Text = (access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        DTVdata.DataSource = access.DBDT
    End Sub

    Private Sub CMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD.Click
        SearchMember(Tput.Text)
    End Sub

    
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Panel1.Visible = True
    End Sub


    Private Sub CBdata_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBdata.SelectedIndexChanged
        Label1.Text = CBdata.Text
    End Sub


    

    'Private Sub TextBox_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged, TextBox1.TextChanged
    '    If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBox2.Text) Then CButton1.Enabled = True
    'End Sub

    Private Sub AddUser()
        ' ADD PARAMETERS
        access.AddParam("@user", TextBox1.Text)
        access.AddParam("@pass", TextBox2.Text)
        access.AddParam("@email", TextBox3.Text)


        ' EXECUTE INSERT COMMAND
        access.ExecQuery("INSERT INTO [Table] (username,[userpassword],email) " & _
                         "VALUES (@pass,@user,@email); ")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' SUCCESS!!
        MsgBox("User was added successfully.")

        RefreshGrid()

        'Me.Close()
    End Sub

    Private Sub CButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CButton1.Click
        AddUser()
        Panel1.Visible = False
    End Sub
End Class