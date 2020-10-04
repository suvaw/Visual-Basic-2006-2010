<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyProfile))
        Me.PTitle = New System.Windows.Forms.Panel()
        Me.Pmenu = New System.Windows.Forms.Panel()
        Me.LDB = New System.Windows.Forms.Label()
        Me.LMP = New System.Windows.Forms.Label()
        Me.LMMB = New System.Windows.Forms.Label()
        Me.LPL = New System.Windows.Forms.Label()
        Me.Lselect = New System.Windows.Forms.Label()
        Me.LSO = New System.Windows.Forms.Label()
        Me.PContener = New System.Windows.Forms.Panel()
        Me.PDashbord = New System.Windows.Forms.Panel()
        Me.PPassangerList = New System.Windows.Forms.Panel()
        Me.PMyProfile = New System.Windows.Forms.Panel()
        Me.PSpecialOffer = New System.Windows.Forms.Panel()
        Me.PManageMyBook = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BBflight = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BFlightS = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BCheckin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BCDU = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bnotification = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BWheather = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BShedule = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BAbout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BHelp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Blogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Pmenu.SuspendLayout()
        Me.PContener.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PTitle
        '
        Me.PTitle.BackColor = System.Drawing.Color.SaddleBrown
        Me.PTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitle.Location = New System.Drawing.Point(0, 0)
        Me.PTitle.Name = "PTitle"
        Me.PTitle.Size = New System.Drawing.Size(1366, 57)
        Me.PTitle.TabIndex = 0
        '
        'Pmenu
        '
        Me.Pmenu.Controls.Add(Me.LDB)
        Me.Pmenu.Controls.Add(Me.LMP)
        Me.Pmenu.Controls.Add(Me.LMMB)
        Me.Pmenu.Controls.Add(Me.LPL)
        Me.Pmenu.Controls.Add(Me.Lselect)
        Me.Pmenu.Controls.Add(Me.LSO)
        Me.Pmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pmenu.Location = New System.Drawing.Point(0, 57)
        Me.Pmenu.Name = "Pmenu"
        Me.Pmenu.Size = New System.Drawing.Size(1366, 69)
        Me.Pmenu.TabIndex = 0
        '
        'LDB
        '
        Me.LDB.AutoSize = True
        Me.LDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDB.Location = New System.Drawing.Point(942, 25)
        Me.LDB.Name = "LDB"
        Me.LDB.Size = New System.Drawing.Size(99, 20)
        Me.LDB.TabIndex = 0
        Me.LDB.Text = "DashBoard"
        '
        'LMP
        '
        Me.LMP.AutoSize = True
        Me.LMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMP.Location = New System.Drawing.Point(760, 25)
        Me.LMP.Name = "LMP"
        Me.LMP.Size = New System.Drawing.Size(87, 20)
        Me.LMP.TabIndex = 0
        Me.LMP.Text = "My Profile"
        '
        'LMMB
        '
        Me.LMMB.AutoSize = True
        Me.LMMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMMB.Location = New System.Drawing.Point(540, 25)
        Me.LMMB.Name = "LMMB"
        Me.LMMB.Size = New System.Drawing.Size(146, 20)
        Me.LMMB.TabIndex = 0
        Me.LMMB.Text = "Manage My Book"
        '
        'LPL
        '
        Me.LPL.AutoSize = True
        Me.LPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPL.Location = New System.Drawing.Point(335, 25)
        Me.LPL.Name = "LPL"
        Me.LPL.Size = New System.Drawing.Size(128, 20)
        Me.LPL.TabIndex = 0
        Me.LPL.Text = "Passanger List"
        '
        'Lselect
        '
        Me.Lselect.AutoSize = True
        Me.Lselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lselect.Location = New System.Drawing.Point(983, 45)
        Me.Lselect.Name = "Lselect"
        Me.Lselect.Size = New System.Drawing.Size(17, 20)
        Me.Lselect.TabIndex = 0
        Me.Lselect.Text = "^"
        '
        'LSO
        '
        Me.LSO.AutoSize = True
        Me.LSO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSO.Location = New System.Drawing.Point(138, 25)
        Me.LSO.Name = "LSO"
        Me.LSO.Size = New System.Drawing.Size(114, 20)
        Me.LSO.TabIndex = 0
        Me.LSO.Text = "Special Offer"
        '
        'PContener
        '
        Me.PContener.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PContener.Controls.Add(Me.PDashbord)
        Me.PContener.Controls.Add(Me.PPassangerList)
        Me.PContener.Controls.Add(Me.PMyProfile)
        Me.PContener.Controls.Add(Me.PSpecialOffer)
        Me.PContener.Controls.Add(Me.PManageMyBook)
        Me.PContener.Controls.Add(Me.PanelMenu)
        Me.PContener.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PContener.Location = New System.Drawing.Point(0, 126)
        Me.PContener.Name = "PContener"
        Me.PContener.Size = New System.Drawing.Size(1366, 642)
        Me.PContener.TabIndex = 0
        '
        'PDashbord
        '
        Me.PDashbord.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PDashbord.Location = New System.Drawing.Point(0, 0)
        Me.PDashbord.Name = "PDashbord"
        Me.PDashbord.Size = New System.Drawing.Size(1117, 642)
        Me.PDashbord.TabIndex = 1
        '
        'PPassangerList
        '
        Me.PPassangerList.BackColor = System.Drawing.SystemColors.Highlight
        Me.PPassangerList.Location = New System.Drawing.Point(0, 0)
        Me.PPassangerList.Name = "PPassangerList"
        Me.PPassangerList.Size = New System.Drawing.Size(1117, 642)
        Me.PPassangerList.TabIndex = 4
        '
        'PMyProfile
        '
        Me.PMyProfile.BackColor = System.Drawing.Color.Red
        Me.PMyProfile.Location = New System.Drawing.Point(0, 0)
        Me.PMyProfile.Name = "PMyProfile"
        Me.PMyProfile.Size = New System.Drawing.Size(1117, 642)
        Me.PMyProfile.TabIndex = 2
        '
        'PSpecialOffer
        '
        Me.PSpecialOffer.BackColor = System.Drawing.Color.RosyBrown
        Me.PSpecialOffer.Location = New System.Drawing.Point(0, 0)
        Me.PSpecialOffer.Name = "PSpecialOffer"
        Me.PSpecialOffer.Size = New System.Drawing.Size(1117, 642)
        Me.PSpecialOffer.TabIndex = 5
        '
        'PManageMyBook
        '
        Me.PManageMyBook.BackColor = System.Drawing.Color.DimGray
        Me.PManageMyBook.Location = New System.Drawing.Point(0, 0)
        Me.PManageMyBook.Name = "PManageMyBook"
        Me.PManageMyBook.Size = New System.Drawing.Size(1117, 642)
        Me.PManageMyBook.TabIndex = 3
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Firebrick
        Me.PanelMenu.Controls.Add(Me.BBflight)
        Me.PanelMenu.Controls.Add(Me.BFlightS)
        Me.PanelMenu.Controls.Add(Me.BCheckin)
        Me.PanelMenu.Controls.Add(Me.BCDU)
        Me.PanelMenu.Controls.Add(Me.Bnotification)
        Me.PanelMenu.Controls.Add(Me.BWheather)
        Me.PanelMenu.Controls.Add(Me.BShedule)
        Me.PanelMenu.Controls.Add(Me.BAbout)
        Me.PanelMenu.Controls.Add(Me.BHelp)
        Me.PanelMenu.Controls.Add(Me.Blogout)
        Me.PanelMenu.Controls.Add(Me.BExit)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMenu.Location = New System.Drawing.Point(1116, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 642)
        Me.PanelMenu.TabIndex = 0
        '
        'BBflight
        '
        Me.BBflight.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BBflight.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BBflight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBflight.BorderRadius = 0
        Me.BBflight.ButtonText = "Book Flight"
        Me.BBflight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBflight.DisabledColor = System.Drawing.Color.Gray
        Me.BBflight.Iconcolor = System.Drawing.Color.Transparent
        Me.BBflight.Iconimage = CType(resources.GetObject("BBflight.Iconimage"), System.Drawing.Image)
        Me.BBflight.Iconimage_right = Nothing
        Me.BBflight.Iconimage_right_Selected = Nothing
        Me.BBflight.Iconimage_Selected = Nothing
        Me.BBflight.IconMarginLeft = 0
        Me.BBflight.IconMarginRight = 0
        Me.BBflight.IconRightVisible = True
        Me.BBflight.IconRightZoom = 0.0R
        Me.BBflight.IconVisible = True
        Me.BBflight.IconZoom = 90.0R
        Me.BBflight.IsTab = False
        Me.BBflight.Location = New System.Drawing.Point(0, 4)
        Me.BBflight.Name = "BBflight"
        Me.BBflight.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BBflight.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BBflight.OnHoverTextColor = System.Drawing.Color.White
        Me.BBflight.selected = False
        Me.BBflight.Size = New System.Drawing.Size(250, 55)
        Me.BBflight.TabIndex = 1
        Me.BBflight.Text = "Book Flight"
        Me.BBflight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBflight.Textcolor = System.Drawing.Color.White
        Me.BBflight.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BFlightS
        '
        Me.BFlightS.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BFlightS.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BFlightS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BFlightS.BorderRadius = 0
        Me.BFlightS.ButtonText = "Flight Status"
        Me.BFlightS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BFlightS.DisabledColor = System.Drawing.Color.Gray
        Me.BFlightS.Iconcolor = System.Drawing.Color.Transparent
        Me.BFlightS.Iconimage = CType(resources.GetObject("BFlightS.Iconimage"), System.Drawing.Image)
        Me.BFlightS.Iconimage_right = Nothing
        Me.BFlightS.Iconimage_right_Selected = Nothing
        Me.BFlightS.Iconimage_Selected = Nothing
        Me.BFlightS.IconMarginLeft = 0
        Me.BFlightS.IconMarginRight = 0
        Me.BFlightS.IconRightVisible = True
        Me.BFlightS.IconRightZoom = 0.0R
        Me.BFlightS.IconVisible = True
        Me.BFlightS.IconZoom = 90.0R
        Me.BFlightS.IsTab = False
        Me.BFlightS.Location = New System.Drawing.Point(0, 62)
        Me.BFlightS.Name = "BFlightS"
        Me.BFlightS.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BFlightS.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BFlightS.OnHoverTextColor = System.Drawing.Color.White
        Me.BFlightS.selected = False
        Me.BFlightS.Size = New System.Drawing.Size(250, 55)
        Me.BFlightS.TabIndex = 1
        Me.BFlightS.Text = "Flight Status"
        Me.BFlightS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BFlightS.Textcolor = System.Drawing.Color.White
        Me.BFlightS.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BCheckin
        '
        Me.BCheckin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCheckin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCheckin.BorderRadius = 0
        Me.BCheckin.ButtonText = "Check-In"
        Me.BCheckin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCheckin.DisabledColor = System.Drawing.Color.Gray
        Me.BCheckin.Iconcolor = System.Drawing.Color.Transparent
        Me.BCheckin.Iconimage = CType(resources.GetObject("BCheckin.Iconimage"), System.Drawing.Image)
        Me.BCheckin.Iconimage_right = Nothing
        Me.BCheckin.Iconimage_right_Selected = Nothing
        Me.BCheckin.Iconimage_Selected = Nothing
        Me.BCheckin.IconMarginLeft = 0
        Me.BCheckin.IconMarginRight = 0
        Me.BCheckin.IconRightVisible = True
        Me.BCheckin.IconRightZoom = 0.0R
        Me.BCheckin.IconVisible = True
        Me.BCheckin.IconZoom = 90.0R
        Me.BCheckin.IsTab = False
        Me.BCheckin.Location = New System.Drawing.Point(0, 120)
        Me.BCheckin.Name = "BCheckin"
        Me.BCheckin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCheckin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BCheckin.OnHoverTextColor = System.Drawing.Color.White
        Me.BCheckin.selected = False
        Me.BCheckin.Size = New System.Drawing.Size(250, 55)
        Me.BCheckin.TabIndex = 1
        Me.BCheckin.Text = "Check-In"
        Me.BCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCheckin.Textcolor = System.Drawing.Color.White
        Me.BCheckin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BCDU
        '
        Me.BCDU.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCDU.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCDU.BorderRadius = 0
        Me.BCDU.ButtonText = "Contact Details Update"
        Me.BCDU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCDU.DisabledColor = System.Drawing.Color.Gray
        Me.BCDU.Iconcolor = System.Drawing.Color.Transparent
        Me.BCDU.Iconimage = CType(resources.GetObject("BCDU.Iconimage"), System.Drawing.Image)
        Me.BCDU.Iconimage_right = Nothing
        Me.BCDU.Iconimage_right_Selected = Nothing
        Me.BCDU.Iconimage_Selected = Nothing
        Me.BCDU.IconMarginLeft = 0
        Me.BCDU.IconMarginRight = 0
        Me.BCDU.IconRightVisible = True
        Me.BCDU.IconRightZoom = 0.0R
        Me.BCDU.IconVisible = True
        Me.BCDU.IconZoom = 90.0R
        Me.BCDU.IsTab = False
        Me.BCDU.Location = New System.Drawing.Point(0, 178)
        Me.BCDU.Name = "BCDU"
        Me.BCDU.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BCDU.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BCDU.OnHoverTextColor = System.Drawing.Color.White
        Me.BCDU.selected = False
        Me.BCDU.Size = New System.Drawing.Size(250, 55)
        Me.BCDU.TabIndex = 1
        Me.BCDU.Text = "Contact Details Update"
        Me.BCDU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCDU.Textcolor = System.Drawing.Color.White
        Me.BCDU.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Bnotification
        '
        Me.Bnotification.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bnotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bnotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bnotification.BorderRadius = 0
        Me.Bnotification.ButtonText = "Notification"
        Me.Bnotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bnotification.DisabledColor = System.Drawing.Color.Gray
        Me.Bnotification.Iconcolor = System.Drawing.Color.Transparent
        Me.Bnotification.Iconimage = CType(resources.GetObject("Bnotification.Iconimage"), System.Drawing.Image)
        Me.Bnotification.Iconimage_right = Nothing
        Me.Bnotification.Iconimage_right_Selected = Nothing
        Me.Bnotification.Iconimage_Selected = Nothing
        Me.Bnotification.IconMarginLeft = 0
        Me.Bnotification.IconMarginRight = 0
        Me.Bnotification.IconRightVisible = True
        Me.Bnotification.IconRightZoom = 0.0R
        Me.Bnotification.IconVisible = True
        Me.Bnotification.IconZoom = 90.0R
        Me.Bnotification.IsTab = False
        Me.Bnotification.Location = New System.Drawing.Point(0, 236)
        Me.Bnotification.Name = "Bnotification"
        Me.Bnotification.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bnotification.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bnotification.OnHoverTextColor = System.Drawing.Color.White
        Me.Bnotification.selected = False
        Me.Bnotification.Size = New System.Drawing.Size(250, 55)
        Me.Bnotification.TabIndex = 1
        Me.Bnotification.Text = "Notification"
        Me.Bnotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bnotification.Textcolor = System.Drawing.Color.White
        Me.Bnotification.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BWheather
        '
        Me.BWheather.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BWheather.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BWheather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BWheather.BorderRadius = 0
        Me.BWheather.ButtonText = "weather"
        Me.BWheather.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BWheather.DisabledColor = System.Drawing.Color.Gray
        Me.BWheather.Iconcolor = System.Drawing.Color.Transparent
        Me.BWheather.Iconimage = CType(resources.GetObject("BWheather.Iconimage"), System.Drawing.Image)
        Me.BWheather.Iconimage_right = Nothing
        Me.BWheather.Iconimage_right_Selected = Nothing
        Me.BWheather.Iconimage_Selected = Nothing
        Me.BWheather.IconMarginLeft = 0
        Me.BWheather.IconMarginRight = 0
        Me.BWheather.IconRightVisible = True
        Me.BWheather.IconRightZoom = 0.0R
        Me.BWheather.IconVisible = True
        Me.BWheather.IconZoom = 90.0R
        Me.BWheather.IsTab = False
        Me.BWheather.Location = New System.Drawing.Point(0, 294)
        Me.BWheather.Name = "BWheather"
        Me.BWheather.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BWheather.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BWheather.OnHoverTextColor = System.Drawing.Color.White
        Me.BWheather.selected = False
        Me.BWheather.Size = New System.Drawing.Size(250, 55)
        Me.BWheather.TabIndex = 1
        Me.BWheather.Text = "weather"
        Me.BWheather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BWheather.Textcolor = System.Drawing.Color.White
        Me.BWheather.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BShedule
        '
        Me.BShedule.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BShedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BShedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BShedule.BorderRadius = 0
        Me.BShedule.ButtonText = "Shedules"
        Me.BShedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BShedule.DisabledColor = System.Drawing.Color.Gray
        Me.BShedule.Iconcolor = System.Drawing.Color.Transparent
        Me.BShedule.Iconimage = CType(resources.GetObject("BShedule.Iconimage"), System.Drawing.Image)
        Me.BShedule.Iconimage_right = Nothing
        Me.BShedule.Iconimage_right_Selected = Nothing
        Me.BShedule.Iconimage_Selected = Nothing
        Me.BShedule.IconMarginLeft = 0
        Me.BShedule.IconMarginRight = 0
        Me.BShedule.IconRightVisible = True
        Me.BShedule.IconRightZoom = 0.0R
        Me.BShedule.IconVisible = True
        Me.BShedule.IconZoom = 90.0R
        Me.BShedule.IsTab = False
        Me.BShedule.Location = New System.Drawing.Point(0, 352)
        Me.BShedule.Name = "BShedule"
        Me.BShedule.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BShedule.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BShedule.OnHoverTextColor = System.Drawing.Color.White
        Me.BShedule.selected = False
        Me.BShedule.Size = New System.Drawing.Size(250, 55)
        Me.BShedule.TabIndex = 1
        Me.BShedule.Text = "Shedules"
        Me.BShedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BShedule.Textcolor = System.Drawing.Color.White
        Me.BShedule.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BAbout
        '
        Me.BAbout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BAbout.BorderRadius = 0
        Me.BAbout.ButtonText = "About"
        Me.BAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BAbout.DisabledColor = System.Drawing.Color.Gray
        Me.BAbout.Iconcolor = System.Drawing.Color.Transparent
        Me.BAbout.Iconimage = CType(resources.GetObject("BAbout.Iconimage"), System.Drawing.Image)
        Me.BAbout.Iconimage_right = Nothing
        Me.BAbout.Iconimage_right_Selected = Nothing
        Me.BAbout.Iconimage_Selected = Nothing
        Me.BAbout.IconMarginLeft = 0
        Me.BAbout.IconMarginRight = 0
        Me.BAbout.IconRightVisible = True
        Me.BAbout.IconRightZoom = 0.0R
        Me.BAbout.IconVisible = True
        Me.BAbout.IconZoom = 90.0R
        Me.BAbout.IsTab = False
        Me.BAbout.Location = New System.Drawing.Point(0, 410)
        Me.BAbout.Name = "BAbout"
        Me.BAbout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BAbout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BAbout.OnHoverTextColor = System.Drawing.Color.White
        Me.BAbout.selected = False
        Me.BAbout.Size = New System.Drawing.Size(250, 55)
        Me.BAbout.TabIndex = 1
        Me.BAbout.Text = "About"
        Me.BAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAbout.Textcolor = System.Drawing.Color.White
        Me.BAbout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BHelp
        '
        Me.BHelp.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BHelp.BorderRadius = 0
        Me.BHelp.ButtonText = "Help"
        Me.BHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BHelp.DisabledColor = System.Drawing.Color.Gray
        Me.BHelp.Iconcolor = System.Drawing.Color.Transparent
        Me.BHelp.Iconimage = CType(resources.GetObject("BHelp.Iconimage"), System.Drawing.Image)
        Me.BHelp.Iconimage_right = Nothing
        Me.BHelp.Iconimage_right_Selected = Nothing
        Me.BHelp.Iconimage_Selected = Nothing
        Me.BHelp.IconMarginLeft = 0
        Me.BHelp.IconMarginRight = 0
        Me.BHelp.IconRightVisible = True
        Me.BHelp.IconRightZoom = 0.0R
        Me.BHelp.IconVisible = True
        Me.BHelp.IconZoom = 90.0R
        Me.BHelp.IsTab = False
        Me.BHelp.Location = New System.Drawing.Point(0, 468)
        Me.BHelp.Name = "BHelp"
        Me.BHelp.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BHelp.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BHelp.OnHoverTextColor = System.Drawing.Color.White
        Me.BHelp.selected = False
        Me.BHelp.Size = New System.Drawing.Size(250, 55)
        Me.BHelp.TabIndex = 1
        Me.BHelp.Text = "Help"
        Me.BHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BHelp.Textcolor = System.Drawing.Color.White
        Me.BHelp.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Blogout
        '
        Me.Blogout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Blogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Blogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Blogout.BorderRadius = 0
        Me.Blogout.ButtonText = "Logout"
        Me.Blogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Blogout.DisabledColor = System.Drawing.Color.Gray
        Me.Blogout.Iconcolor = System.Drawing.Color.Transparent
        Me.Blogout.Iconimage = CType(resources.GetObject("Blogout.Iconimage"), System.Drawing.Image)
        Me.Blogout.Iconimage_right = Nothing
        Me.Blogout.Iconimage_right_Selected = Nothing
        Me.Blogout.Iconimage_Selected = Nothing
        Me.Blogout.IconMarginLeft = 0
        Me.Blogout.IconMarginRight = 0
        Me.Blogout.IconRightVisible = True
        Me.Blogout.IconRightZoom = 0.0R
        Me.Blogout.IconVisible = True
        Me.Blogout.IconZoom = 90.0R
        Me.Blogout.IsTab = False
        Me.Blogout.Location = New System.Drawing.Point(0, 526)
        Me.Blogout.Name = "Blogout"
        Me.Blogout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Blogout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Blogout.OnHoverTextColor = System.Drawing.Color.White
        Me.Blogout.selected = False
        Me.Blogout.Size = New System.Drawing.Size(250, 55)
        Me.Blogout.TabIndex = 1
        Me.Blogout.Text = "Logout"
        Me.Blogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Blogout.Textcolor = System.Drawing.Color.White
        Me.Blogout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BExit
        '
        Me.BExit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExit.BorderRadius = 0
        Me.BExit.ButtonText = "Exit"
        Me.BExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BExit.DisabledColor = System.Drawing.Color.Gray
        Me.BExit.Iconcolor = System.Drawing.Color.Transparent
        Me.BExit.Iconimage = CType(resources.GetObject("BExit.Iconimage"), System.Drawing.Image)
        Me.BExit.Iconimage_right = Nothing
        Me.BExit.Iconimage_right_Selected = Nothing
        Me.BExit.Iconimage_Selected = Nothing
        Me.BExit.IconMarginLeft = 0
        Me.BExit.IconMarginRight = 0
        Me.BExit.IconRightVisible = True
        Me.BExit.IconRightZoom = 0.0R
        Me.BExit.IconVisible = True
        Me.BExit.IconZoom = 90.0R
        Me.BExit.IsTab = False
        Me.BExit.Location = New System.Drawing.Point(0, 584)
        Me.BExit.Name = "BExit"
        Me.BExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BExit.OnHoverTextColor = System.Drawing.Color.White
        Me.BExit.selected = False
        Me.BExit.Size = New System.Drawing.Size(250, 55)
        Me.BExit.TabIndex = 1
        Me.BExit.Text = "Exit"
        Me.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BExit.Textcolor = System.Drawing.Color.White
        Me.BExit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PContener)
        Me.Controls.Add(Me.Pmenu)
        Me.Controls.Add(Me.PTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyProfile"
        Me.Pmenu.ResumeLayout(False)
        Me.Pmenu.PerformLayout()
        Me.PContener.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PTitle As System.Windows.Forms.Panel
    Friend WithEvents Pmenu As System.Windows.Forms.Panel
    Friend WithEvents LDB As System.Windows.Forms.Label
    Friend WithEvents LMP As System.Windows.Forms.Label
    Friend WithEvents LMMB As System.Windows.Forms.Label
    Friend WithEvents LPL As System.Windows.Forms.Label
    Friend WithEvents LSO As System.Windows.Forms.Label
    Friend WithEvents PContener As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents BCDU As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BCheckin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BFlightS As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BBflight As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BHelp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Blogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BAbout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BShedule As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BWheather As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bnotification As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PDashbord As System.Windows.Forms.Panel
    Friend WithEvents PMyProfile As System.Windows.Forms.Panel
    Friend WithEvents PManageMyBook As System.Windows.Forms.Panel
    Friend WithEvents PPassangerList As System.Windows.Forms.Panel
    Friend WithEvents PSpecialOffer As System.Windows.Forms.Panel
    Friend WithEvents Lselect As System.Windows.Forms.Label
End Class
