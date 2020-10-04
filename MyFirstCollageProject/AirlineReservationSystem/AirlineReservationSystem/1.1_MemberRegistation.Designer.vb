<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberRegistation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberRegistation))
        Me.Ptitle = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PCover = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pform = New System.Windows.Forms.Panel()
        Me.Ltitle = New System.Windows.Forms.Label()
        Me.Ntitle = New System.Windows.Forms.Label()
        Me.Cbxtitle = New System.Windows.Forms.ComboBox()
        Me.Lname = New System.Windows.Forms.Label()
        Me.Tname = New System.Windows.Forms.TextBox()
        Me.Lsurname = New System.Windows.Forms.Label()
        Me.Tlname = New System.Windows.Forms.TextBox()
        Me.LDOB = New System.Windows.Forms.Label()
        Me.CbxDay = New System.Windows.Forms.ComboBox()
        Me.CbxMonth = New System.Windows.Forms.ComboBox()
        Me.CbxYear = New System.Windows.Forms.ComboBox()
        Me.Lstate = New System.Windows.Forms.Label()
        Me.CbxState = New System.Windows.Forms.ComboBox()
        Me.Lcountry = New System.Windows.Forms.Label()
        Me.CbxCountry = New System.Windows.Forms.ComboBox()
        Me.Lpassword = New System.Windows.Forms.Label()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Lpassword1 = New System.Windows.Forms.Label()
        Me.Tpassword1 = New System.Windows.Forms.TextBox()
        Me.Lemail = New System.Windows.Forms.Label()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Laddress = New System.Windows.Forms.Label()
        Me.Taddress = New System.Windows.Forms.TextBox()
        Me.Lmobile = New System.Windows.Forms.Label()
        Me.Tmobile = New System.Windows.Forms.TextBox()
        Me.Lid = New System.Windows.Forms.Label()
        Me.Tid = New System.Windows.Forms.TextBox()
        Me.Submit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bclear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CbxCountryCode = New System.Windows.Forms.ComboBox()
        Me.Ptitle.SuspendLayout()
        Me.PCover.SuspendLayout()
        Me.Pform.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ptitle
        '
        Me.Ptitle.BackgroundImage = CType(resources.GetObject("Ptitle.BackgroundImage"), System.Drawing.Image)
        Me.Ptitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ptitle.Controls.Add(Me.Label4)
        Me.Ptitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ptitle.GradientBottomLeft = System.Drawing.Color.White
        Me.Ptitle.GradientBottomRight = System.Drawing.Color.White
        Me.Ptitle.GradientTopLeft = System.Drawing.Color.White
        Me.Ptitle.GradientTopRight = System.Drawing.Color.White
        Me.Ptitle.Location = New System.Drawing.Point(0, 0)
        Me.Ptitle.Name = "Ptitle"
        Me.Ptitle.Quality = 10
        Me.Ptitle.Size = New System.Drawing.Size(1366, 42)
        Me.Ptitle.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Airline Reservation System"
        '
        'PCover
        '
        Me.PCover.BackColor = System.Drawing.Color.White
        Me.PCover.BackgroundImage = CType(resources.GetObject("PCover.BackgroundImage"), System.Drawing.Image)
        Me.PCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PCover.Controls.Add(Me.Pform)
        Me.PCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PCover.GradientBottomLeft = System.Drawing.Color.Maroon
        Me.PCover.GradientBottomRight = System.Drawing.Color.Maroon
        Me.PCover.GradientTopLeft = System.Drawing.Color.Maroon
        Me.PCover.GradientTopRight = System.Drawing.Color.Maroon
        Me.PCover.Location = New System.Drawing.Point(0, 42)
        Me.PCover.Name = "PCover"
        Me.PCover.Quality = 10
        Me.PCover.Size = New System.Drawing.Size(1366, 726)
        Me.PCover.TabIndex = 1
        '
        'Pform
        '
        Me.Pform.Controls.Add(Me.Ltitle)
        Me.Pform.Controls.Add(Me.Ntitle)
        Me.Pform.Controls.Add(Me.Cbxtitle)
        Me.Pform.Controls.Add(Me.Lname)
        Me.Pform.Controls.Add(Me.Tname)
        Me.Pform.Controls.Add(Me.Lsurname)
        Me.Pform.Controls.Add(Me.Tlname)
        Me.Pform.Controls.Add(Me.LDOB)
        Me.Pform.Controls.Add(Me.CbxCountryCode)
        Me.Pform.Controls.Add(Me.CbxDay)
        Me.Pform.Controls.Add(Me.CbxMonth)
        Me.Pform.Controls.Add(Me.CbxYear)
        Me.Pform.Controls.Add(Me.Lstate)
        Me.Pform.Controls.Add(Me.CbxState)
        Me.Pform.Controls.Add(Me.Lcountry)
        Me.Pform.Controls.Add(Me.CbxCountry)
        Me.Pform.Controls.Add(Me.Lpassword)
        Me.Pform.Controls.Add(Me.Tpassword)
        Me.Pform.Controls.Add(Me.Lpassword1)
        Me.Pform.Controls.Add(Me.Tpassword1)
        Me.Pform.Controls.Add(Me.Lemail)
        Me.Pform.Controls.Add(Me.Temail)
        Me.Pform.Controls.Add(Me.Laddress)
        Me.Pform.Controls.Add(Me.Taddress)
        Me.Pform.Controls.Add(Me.Lmobile)
        Me.Pform.Controls.Add(Me.Tmobile)
        Me.Pform.Controls.Add(Me.Lid)
        Me.Pform.Controls.Add(Me.Tid)
        Me.Pform.Controls.Add(Me.Submit)
        Me.Pform.Controls.Add(Me.Bclear)
        Me.Pform.Location = New System.Drawing.Point(182, 88)
        Me.Pform.Name = "Pform"
        Me.Pform.Size = New System.Drawing.Size(1002, 593)
        Me.Pform.TabIndex = 9
        '
        'Ltitle
        '
        Me.Ltitle.AutoSize = True
        Me.Ltitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ltitle.Font = New System.Drawing.Font("Britannic Bold", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitle.Location = New System.Drawing.Point(254, 46)
        Me.Ltitle.Name = "Ltitle"
        Me.Ltitle.Size = New System.Drawing.Size(495, 38)
        Me.Ltitle.TabIndex = 1
        Me.Ltitle.Text = "AIRLINE MEMBER REGISTATION"
        '
        'Ntitle
        '
        Me.Ntitle.AutoSize = True
        Me.Ntitle.Location = New System.Drawing.Point(232, 133)
        Me.Ntitle.Name = "Ntitle"
        Me.Ntitle.Size = New System.Drawing.Size(27, 13)
        Me.Ntitle.TabIndex = 1
        Me.Ntitle.Text = "Title"
        '
        'Cbxtitle
        '
        Me.Cbxtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxtitle.FormattingEnabled = True
        Me.Cbxtitle.Location = New System.Drawing.Point(235, 153)
        Me.Cbxtitle.Name = "Cbxtitle"
        Me.Cbxtitle.Size = New System.Drawing.Size(121, 28)
        Me.Cbxtitle.TabIndex = 8
        Me.Cbxtitle.Text = "Select"
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(387, 133)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(57, 13)
        Me.Lname.TabIndex = 1
        Me.Lname.Text = "First Name"
        '
        'Tname
        '
        Me.Tname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tname.Location = New System.Drawing.Point(387, 154)
        Me.Tname.Name = "Tname"
        Me.Tname.Size = New System.Drawing.Size(249, 26)
        Me.Tname.TabIndex = 2
        Me.Tname.Text = "Enter First Your Name"
        '
        'Lsurname
        '
        Me.Lsurname.AutoSize = True
        Me.Lsurname.Location = New System.Drawing.Point(679, 133)
        Me.Lsurname.Name = "Lsurname"
        Me.Lsurname.Size = New System.Drawing.Size(58, 13)
        Me.Lsurname.TabIndex = 1
        Me.Lsurname.Text = "Last Name"
        '
        'Tlname
        '
        Me.Tlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlname.Location = New System.Drawing.Point(679, 152)
        Me.Tlname.Name = "Tlname"
        Me.Tlname.Size = New System.Drawing.Size(216, 26)
        Me.Tlname.TabIndex = 2
        Me.Tlname.Text = "Enter Your Last Name"
        '
        'LDOB
        '
        Me.LDOB.AutoSize = True
        Me.LDOB.Location = New System.Drawing.Point(107, 197)
        Me.LDOB.Name = "LDOB"
        Me.LDOB.Size = New System.Drawing.Size(66, 13)
        Me.LDOB.TabIndex = 1
        Me.LDOB.Text = "Date of Birth"
        '
        'CbxDay
        '
        Me.CbxDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDay.FormattingEnabled = True
        Me.CbxDay.Location = New System.Drawing.Point(107, 213)
        Me.CbxDay.Name = "CbxDay"
        Me.CbxDay.Size = New System.Drawing.Size(85, 28)
        Me.CbxDay.TabIndex = 3
        Me.CbxDay.Text = "Day"
        '
        'CbxMonth
        '
        Me.CbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.FormattingEnabled = True
        Me.CbxMonth.Location = New System.Drawing.Point(192, 213)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(88, 28)
        Me.CbxMonth.TabIndex = 3
        Me.CbxMonth.Text = "Month"
        '
        'CbxYear
        '
        Me.CbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxYear.FormattingEnabled = True
        Me.CbxYear.Location = New System.Drawing.Point(280, 213)
        Me.CbxYear.Name = "CbxYear"
        Me.CbxYear.Size = New System.Drawing.Size(76, 28)
        Me.CbxYear.TabIndex = 3
        Me.CbxYear.Text = "Year"
        '
        'Lstate
        '
        Me.Lstate.AutoSize = True
        Me.Lstate.Location = New System.Drawing.Point(387, 197)
        Me.Lstate.Name = "Lstate"
        Me.Lstate.Size = New System.Drawing.Size(32, 13)
        Me.Lstate.TabIndex = 1
        Me.Lstate.Text = "State"
        '
        'CbxState
        '
        Me.CbxState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxState.FormattingEnabled = True
        Me.CbxState.Location = New System.Drawing.Point(387, 212)
        Me.CbxState.Name = "CbxState"
        Me.CbxState.Size = New System.Drawing.Size(249, 28)
        Me.CbxState.TabIndex = 8
        Me.CbxState.Text = "Select"
        '
        'Lcountry
        '
        Me.Lcountry.AutoSize = True
        Me.Lcountry.Location = New System.Drawing.Point(679, 194)
        Me.Lcountry.Name = "Lcountry"
        Me.Lcountry.Size = New System.Drawing.Size(43, 13)
        Me.Lcountry.TabIndex = 1
        Me.Lcountry.Text = "Country"
        '
        'CbxCountry
        '
        Me.CbxCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCountry.FormattingEnabled = True
        Me.CbxCountry.Location = New System.Drawing.Point(679, 210)
        Me.CbxCountry.Name = "CbxCountry"
        Me.CbxCountry.Size = New System.Drawing.Size(216, 28)
        Me.CbxCountry.TabIndex = 8
        Me.CbxCountry.Text = "Select"
        '
        'Lpassword
        '
        Me.Lpassword.AutoSize = True
        Me.Lpassword.Location = New System.Drawing.Point(107, 255)
        Me.Lpassword.Name = "Lpassword"
        Me.Lpassword.Size = New System.Drawing.Size(106, 13)
        Me.Lpassword.TabIndex = 1
        Me.Lpassword.Text = "Enter Your Password"
        '
        'Tpassword
        '
        Me.Tpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tpassword.Location = New System.Drawing.Point(107, 274)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.Size = New System.Drawing.Size(249, 26)
        Me.Tpassword.TabIndex = 2
        Me.Tpassword.Text = "Enter Your Password"
        '
        'Lpassword1
        '
        Me.Lpassword1.AutoSize = True
        Me.Lpassword1.Location = New System.Drawing.Point(387, 256)
        Me.Lpassword1.Name = "Lpassword1"
        Me.Lpassword1.Size = New System.Drawing.Size(97, 13)
        Me.Lpassword1.TabIndex = 1
        Me.Lpassword1.Text = "Re-Type Password"
        '
        'Tpassword1
        '
        Me.Tpassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tpassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tpassword1.Location = New System.Drawing.Point(387, 272)
        Me.Tpassword1.Name = "Tpassword1"
        Me.Tpassword1.Size = New System.Drawing.Size(249, 26)
        Me.Tpassword1.TabIndex = 2
        Me.Tpassword1.Text = "Re-Type Password"
        '
        'Lemail
        '
        Me.Lemail.AutoSize = True
        Me.Lemail.Location = New System.Drawing.Point(679, 254)
        Me.Lemail.Name = "Lemail"
        Me.Lemail.Size = New System.Drawing.Size(32, 13)
        Me.Lemail.TabIndex = 1
        Me.Lemail.Text = "Email"
        '
        'Temail
        '
        Me.Temail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Temail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temail.Location = New System.Drawing.Point(679, 270)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(216, 26)
        Me.Temail.TabIndex = 2
        Me.Temail.Text = "Enter Your Email Id"
        '
        'Laddress
        '
        Me.Laddress.AutoSize = True
        Me.Laddress.Location = New System.Drawing.Point(71, 365)
        Me.Laddress.Name = "Laddress"
        Me.Laddress.Size = New System.Drawing.Size(99, 26)
        Me.Laddress.TabIndex = 1
        Me.Laddress.Text = "Gov Register" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Parmanent Address"
        Me.Laddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Taddress
        '
        Me.Taddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Taddress.Location = New System.Drawing.Point(176, 336)
        Me.Taddress.Multiline = True
        Me.Taddress.Name = "Taddress"
        Me.Taddress.Size = New System.Drawing.Size(416, 85)
        Me.Taddress.TabIndex = 9
        Me.Taddress.Text = "Enter Your Full Adress"
        '
        'Lmobile
        '
        Me.Lmobile.AutoSize = True
        Me.Lmobile.Location = New System.Drawing.Point(623, 336)
        Me.Lmobile.Name = "Lmobile"
        Me.Lmobile.Size = New System.Drawing.Size(38, 13)
        Me.Lmobile.TabIndex = 1
        Me.Lmobile.Text = "Mobile"
        '
        'Tmobile
        '
        Me.Tmobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmobile.Location = New System.Drawing.Point(725, 330)
        Me.Tmobile.Name = "Tmobile"
        Me.Tmobile.Size = New System.Drawing.Size(170, 26)
        Me.Tmobile.TabIndex = 2
        Me.Tmobile.Text = "Enter Your Mob No."
        '
        'Lid
        '
        Me.Lid.AutoSize = True
        Me.Lid.Location = New System.Drawing.Point(623, 394)
        Me.Lid.Name = "Lid"
        Me.Lid.Size = New System.Drawing.Size(41, 13)
        Me.Lid.TabIndex = 1
        Me.Lid.Text = "Id Card"
        '
        'Tid
        '
        Me.Tid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tid.Location = New System.Drawing.Point(679, 387)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(216, 26)
        Me.Tid.TabIndex = 2
        Me.Tid.Text = "Enter Your ID Card No."
        '
        'Submit
        '
        Me.Submit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Submit.BorderRadius = 0
        Me.Submit.ButtonText = "Submit"
        Me.Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Submit.DisabledColor = System.Drawing.Color.Gray
        Me.Submit.Iconcolor = System.Drawing.Color.Transparent
        Me.Submit.Iconimage = Nothing
        Me.Submit.Iconimage_right = Nothing
        Me.Submit.Iconimage_right_Selected = Nothing
        Me.Submit.Iconimage_Selected = Nothing
        Me.Submit.IconMarginLeft = 0
        Me.Submit.IconMarginRight = 0
        Me.Submit.IconRightVisible = True
        Me.Submit.IconRightZoom = 0.0R
        Me.Submit.IconVisible = True
        Me.Submit.IconZoom = 90.0R
        Me.Submit.IsTab = False
        Me.Submit.Location = New System.Drawing.Point(284, 500)
        Me.Submit.Name = "Submit"
        Me.Submit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Submit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Submit.OnHoverTextColor = System.Drawing.Color.White
        Me.Submit.selected = False
        Me.Submit.Size = New System.Drawing.Size(132, 46)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "Submit"
        Me.Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Submit.Textcolor = System.Drawing.Color.White
        Me.Submit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Bclear
        '
        Me.Bclear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bclear.BorderRadius = 0
        Me.Bclear.ButtonText = "Clear"
        Me.Bclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bclear.DisabledColor = System.Drawing.Color.Gray
        Me.Bclear.Iconcolor = System.Drawing.Color.Transparent
        Me.Bclear.Iconimage = Nothing
        Me.Bclear.Iconimage_right = Nothing
        Me.Bclear.Iconimage_right_Selected = Nothing
        Me.Bclear.Iconimage_Selected = Nothing
        Me.Bclear.IconMarginLeft = 0
        Me.Bclear.IconMarginRight = 0
        Me.Bclear.IconRightVisible = True
        Me.Bclear.IconRightZoom = 0.0R
        Me.Bclear.IconVisible = True
        Me.Bclear.IconZoom = 90.0R
        Me.Bclear.IsTab = False
        Me.Bclear.Location = New System.Drawing.Point(587, 500)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bclear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bclear.OnHoverTextColor = System.Drawing.Color.White
        Me.Bclear.selected = False
        Me.Bclear.Size = New System.Drawing.Size(132, 46)
        Me.Bclear.TabIndex = 5
        Me.Bclear.Text = "Clear"
        Me.Bclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bclear.Textcolor = System.Drawing.Color.White
        Me.Bclear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CbxCountryCode
        '
        Me.CbxCountryCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCountryCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCountryCode.FormattingEnabled = True
        Me.CbxCountryCode.Location = New System.Drawing.Point(667, 330)
        Me.CbxCountryCode.Name = "CbxCountryCode"
        Me.CbxCountryCode.Size = New System.Drawing.Size(52, 28)
        Me.CbxCountryCode.TabIndex = 3
        Me.CbxCountryCode.Text = "+91"
        '
        'MemberRegistation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PCover)
        Me.Controls.Add(Me.Ptitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MemberRegistation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberRegistation"
        Me.Ptitle.ResumeLayout(False)
        Me.Ptitle.PerformLayout()
        Me.PCover.ResumeLayout(False)
        Me.Pform.ResumeLayout(False)
        Me.Pform.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ptitle As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PCover As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Ntitle As System.Windows.Forms.Label
    Friend WithEvents Ltitle As System.Windows.Forms.Label
    Friend WithEvents CbxDay As System.Windows.Forms.ComboBox
    Friend WithEvents CbxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents CbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents Tmobile As System.Windows.Forms.TextBox
    Friend WithEvents Submit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Lsurname As System.Windows.Forms.Label
    Friend WithEvents Lcountry As System.Windows.Forms.Label
    Friend WithEvents Lmobile As System.Windows.Forms.Label
    Friend WithEvents Lpassword As System.Windows.Forms.Label
    Friend WithEvents LDOB As System.Windows.Forms.Label
    Friend WithEvents Lstate As System.Windows.Forms.Label
    Friend WithEvents Lname As System.Windows.Forms.Label
    Friend WithEvents Temail As System.Windows.Forms.TextBox
    Friend WithEvents Tpassword As System.Windows.Forms.TextBox
    Friend WithEvents Tname As System.Windows.Forms.TextBox
    Friend WithEvents Tlname As System.Windows.Forms.TextBox
    Friend WithEvents Pform As System.Windows.Forms.Panel
    Friend WithEvents Cbxtitle As System.Windows.Forms.ComboBox
    Friend WithEvents Taddress As System.Windows.Forms.TextBox
    Friend WithEvents CbxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents CbxState As System.Windows.Forms.ComboBox
    Friend WithEvents Tpassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Tid As System.Windows.Forms.TextBox
    Friend WithEvents Lid As System.Windows.Forms.Label
    Friend WithEvents Lpassword1 As System.Windows.Forms.Label
    Friend WithEvents Lemail As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Laddress As System.Windows.Forms.Label
    Friend WithEvents Bclear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CbxCountryCode As System.Windows.Forms.ComboBox
End Class
