<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindows
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindows))
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.LFS = New System.Windows.Forms.Label()
        Me.LSU = New System.Windows.Forms.Label()
        Me.LBF = New System.Windows.Forms.Label()
        Me.LCI = New System.Windows.Forms.Label()
        Me.LExit = New System.Windows.Forms.Label()
        Me.LVCB = New System.Windows.Forms.Label()
        Me.PAdv = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Psearch = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PSmenu = New System.Windows.Forms.Panel()
        Me.Bbook = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bweather = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bshedules = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bnotification = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Babout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Cbxto = New System.Windows.Forms.ComboBox()
        Me.Cbxform = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RBOne = New System.Windows.Forms.RadioButton()
        Me.RBReturn = New System.Windows.Forms.RadioButton()
        Me.BSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Ck1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Ck2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Ck3 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.PTitle = New System.Windows.Forms.Panel()
        Me.Ltitle = New System.Windows.Forms.Label()
        Me.DPD = New System.Windows.Forms.DateTimePicker()
        Me.DPR = New System.Windows.Forms.DateTimePicker()
        Me.PMenu.SuspendLayout()
        Me.Psearch.SuspendLayout()
        Me.PSmenu.SuspendLayout()
        Me.PTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PMenu.Controls.Add(Me.LFS)
        Me.PMenu.Controls.Add(Me.LSU)
        Me.PMenu.Controls.Add(Me.LBF)
        Me.PMenu.Controls.Add(Me.LCI)
        Me.PMenu.Controls.Add(Me.LExit)
        Me.PMenu.Controls.Add(Me.LVCB)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PMenu.Location = New System.Drawing.Point(0, 61)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(1366, 53)
        Me.PMenu.TabIndex = 0
        '
        'LFS
        '
        Me.LFS.AutoSize = True
        Me.LFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFS.Location = New System.Drawing.Point(640, 13)
        Me.LFS.Name = "LFS"
        Me.LFS.Size = New System.Drawing.Size(124, 24)
        Me.LFS.TabIndex = 3
        Me.LFS.Text = "Flight Status"
        '
        'LSU
        '
        Me.LSU.AutoSize = True
        Me.LSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSU.Location = New System.Drawing.Point(1182, 13)
        Me.LSU.Name = "LSU"
        Me.LSU.Size = New System.Drawing.Size(136, 24)
        Me.LSU.TabIndex = 3
        Me.LSU.Text = "Login/SignUp"
        '
        'LBF
        '
        Me.LBF.AutoSize = True
        Me.LBF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF.Location = New System.Drawing.Point(475, 13)
        Me.LBF.Name = "LBF"
        Me.LBF.Size = New System.Drawing.Size(115, 24)
        Me.LBF.TabIndex = 3
        Me.LBF.Text = "Book Flight"
        '
        'LCI
        '
        Me.LCI.AutoSize = True
        Me.LCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCI.Location = New System.Drawing.Point(802, 13)
        Me.LCI.Name = "LCI"
        Me.LCI.Size = New System.Drawing.Size(86, 24)
        Me.LCI.TabIndex = 3
        Me.LCI.Text = "CheckIn"
        '
        'LExit
        '
        Me.LExit.AutoSize = True
        Me.LExit.Location = New System.Drawing.Point(1340, 19)
        Me.LExit.Name = "LExit"
        Me.LExit.Size = New System.Drawing.Size(14, 13)
        Me.LExit.TabIndex = 2
        Me.LExit.Text = "X"
        '
        'LVCB
        '
        Me.LVCB.AutoSize = True
        Me.LVCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVCB.Location = New System.Drawing.Point(926, 13)
        Me.LVCB.Name = "LVCB"
        Me.LVCB.Size = New System.Drawing.Size(218, 24)
        Me.LVCB.TabIndex = 3
        Me.LVCB.Text = "View/Chenge Booking"
        '
        'PAdv
        '
        Me.PAdv.BackgroundImage = CType(resources.GetObject("PAdv.BackgroundImage"), System.Drawing.Image)
        Me.PAdv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAdv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PAdv.GradientBottomLeft = System.Drawing.Color.White
        Me.PAdv.GradientBottomRight = System.Drawing.Color.White
        Me.PAdv.GradientTopLeft = System.Drawing.Color.White
        Me.PAdv.GradientTopRight = System.Drawing.Color.White
        Me.PAdv.Location = New System.Drawing.Point(0, 358)
        Me.PAdv.Name = "PAdv"
        Me.PAdv.Quality = 10
        Me.PAdv.Size = New System.Drawing.Size(1366, 410)
        Me.PAdv.TabIndex = 3
        '
        'Psearch
        '
        Me.Psearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Psearch.BackgroundImage = CType(resources.GetObject("Psearch.BackgroundImage"), System.Drawing.Image)
        Me.Psearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Psearch.Controls.Add(Me.DPR)
        Me.Psearch.Controls.Add(Me.DPD)
        Me.Psearch.Controls.Add(Me.PSmenu)
        Me.Psearch.Controls.Add(Me.Cbxto)
        Me.Psearch.Controls.Add(Me.Cbxform)
        Me.Psearch.Controls.Add(Me.ComboBox1)
        Me.Psearch.Controls.Add(Me.RBOne)
        Me.Psearch.Controls.Add(Me.RBReturn)
        Me.Psearch.Controls.Add(Me.BSearch)
        Me.Psearch.Controls.Add(Me.Ck1)
        Me.Psearch.Controls.Add(Me.Ck2)
        Me.Psearch.Controls.Add(Me.Ck3)
        Me.Psearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Psearch.GradientBottomLeft = System.Drawing.Color.LightGray
        Me.Psearch.GradientBottomRight = System.Drawing.Color.DarkGray
        Me.Psearch.GradientTopLeft = System.Drawing.Color.White
        Me.Psearch.GradientTopRight = System.Drawing.Color.White
        Me.Psearch.Location = New System.Drawing.Point(0, 114)
        Me.Psearch.Name = "Psearch"
        Me.Psearch.Quality = 10
        Me.Psearch.Size = New System.Drawing.Size(1366, 244)
        Me.Psearch.TabIndex = 2
        '
        'PSmenu
        '
        Me.PSmenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PSmenu.Controls.Add(Me.Bbook)
        Me.PSmenu.Controls.Add(Me.Bweather)
        Me.PSmenu.Controls.Add(Me.Bshedules)
        Me.PSmenu.Controls.Add(Me.Bnotification)
        Me.PSmenu.Controls.Add(Me.Babout)
        Me.PSmenu.Location = New System.Drawing.Point(0, 0)
        Me.PSmenu.Name = "PSmenu"
        Me.PSmenu.Size = New System.Drawing.Size(50, 244)
        Me.PSmenu.TabIndex = 4
        '
        'Bbook
        '
        Me.Bbook.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bbook.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bbook.BorderRadius = 0
        Me.Bbook.ButtonText = "BOOK"
        Me.Bbook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bbook.DisabledColor = System.Drawing.Color.Gray
        Me.Bbook.Iconcolor = System.Drawing.Color.Transparent
        Me.Bbook.Iconimage = CType(resources.GetObject("Bbook.Iconimage"), System.Drawing.Image)
        Me.Bbook.Iconimage_right = Nothing
        Me.Bbook.Iconimage_right_Selected = Nothing
        Me.Bbook.Iconimage_Selected = Nothing
        Me.Bbook.IconMarginLeft = 0
        Me.Bbook.IconMarginRight = 0
        Me.Bbook.IconRightVisible = True
        Me.Bbook.IconRightZoom = 0.0R
        Me.Bbook.IconVisible = True
        Me.Bbook.IconZoom = 90.0R
        Me.Bbook.IsTab = False
        Me.Bbook.Location = New System.Drawing.Point(0, 3)
        Me.Bbook.Name = "Bbook"
        Me.Bbook.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bbook.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bbook.OnHoverTextColor = System.Drawing.Color.White
        Me.Bbook.selected = False
        Me.Bbook.Size = New System.Drawing.Size(200, 48)
        Me.Bbook.TabIndex = 0
        Me.Bbook.Text = "BOOK"
        Me.Bbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bbook.Textcolor = System.Drawing.Color.White
        Me.Bbook.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Bweather
        '
        Me.Bweather.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bweather.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bweather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bweather.BorderRadius = 0
        Me.Bweather.ButtonText = "Weather"
        Me.Bweather.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bweather.DisabledColor = System.Drawing.Color.Gray
        Me.Bweather.Iconcolor = System.Drawing.Color.Transparent
        Me.Bweather.Iconimage = CType(resources.GetObject("Bweather.Iconimage"), System.Drawing.Image)
        Me.Bweather.Iconimage_right = Nothing
        Me.Bweather.Iconimage_right_Selected = Nothing
        Me.Bweather.Iconimage_Selected = Nothing
        Me.Bweather.IconMarginLeft = 0
        Me.Bweather.IconMarginRight = 0
        Me.Bweather.IconRightVisible = True
        Me.Bweather.IconRightZoom = 0.0R
        Me.Bweather.IconVisible = True
        Me.Bweather.IconZoom = 90.0R
        Me.Bweather.IsTab = False
        Me.Bweather.Location = New System.Drawing.Point(0, 51)
        Me.Bweather.Name = "Bweather"
        Me.Bweather.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bweather.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bweather.OnHoverTextColor = System.Drawing.Color.White
        Me.Bweather.selected = False
        Me.Bweather.Size = New System.Drawing.Size(200, 48)
        Me.Bweather.TabIndex = 0
        Me.Bweather.Text = "Weather"
        Me.Bweather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bweather.Textcolor = System.Drawing.Color.White
        Me.Bweather.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Bshedules
        '
        Me.Bshedules.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bshedules.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bshedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bshedules.BorderRadius = 0
        Me.Bshedules.ButtonText = "Shedules"
        Me.Bshedules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bshedules.DisabledColor = System.Drawing.Color.Gray
        Me.Bshedules.Iconcolor = System.Drawing.Color.Transparent
        Me.Bshedules.Iconimage = CType(resources.GetObject("Bshedules.Iconimage"), System.Drawing.Image)
        Me.Bshedules.Iconimage_right = Nothing
        Me.Bshedules.Iconimage_right_Selected = Nothing
        Me.Bshedules.Iconimage_Selected = Nothing
        Me.Bshedules.IconMarginLeft = 0
        Me.Bshedules.IconMarginRight = 0
        Me.Bshedules.IconRightVisible = True
        Me.Bshedules.IconRightZoom = 0.0R
        Me.Bshedules.IconVisible = True
        Me.Bshedules.IconZoom = 90.0R
        Me.Bshedules.IsTab = False
        Me.Bshedules.Location = New System.Drawing.Point(0, 99)
        Me.Bshedules.Name = "Bshedules"
        Me.Bshedules.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bshedules.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bshedules.OnHoverTextColor = System.Drawing.Color.White
        Me.Bshedules.selected = False
        Me.Bshedules.Size = New System.Drawing.Size(200, 48)
        Me.Bshedules.TabIndex = 0
        Me.Bshedules.Text = "Shedules"
        Me.Bshedules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bshedules.Textcolor = System.Drawing.Color.White
        Me.Bshedules.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Bnotification.Location = New System.Drawing.Point(0, 147)
        Me.Bnotification.Name = "Bnotification"
        Me.Bnotification.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bnotification.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bnotification.OnHoverTextColor = System.Drawing.Color.White
        Me.Bnotification.selected = False
        Me.Bnotification.Size = New System.Drawing.Size(200, 48)
        Me.Bnotification.TabIndex = 0
        Me.Bnotification.Text = "Notification"
        Me.Bnotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bnotification.Textcolor = System.Drawing.Color.White
        Me.Bnotification.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Babout
        '
        Me.Babout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Babout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Babout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Babout.BorderRadius = 0
        Me.Babout.ButtonText = "About"
        Me.Babout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Babout.DisabledColor = System.Drawing.Color.Gray
        Me.Babout.Iconcolor = System.Drawing.Color.Transparent
        Me.Babout.Iconimage = CType(resources.GetObject("Babout.Iconimage"), System.Drawing.Image)
        Me.Babout.Iconimage_right = Nothing
        Me.Babout.Iconimage_right_Selected = Nothing
        Me.Babout.Iconimage_Selected = Nothing
        Me.Babout.IconMarginLeft = 0
        Me.Babout.IconMarginRight = 0
        Me.Babout.IconRightVisible = True
        Me.Babout.IconRightZoom = 0.0R
        Me.Babout.IconVisible = True
        Me.Babout.IconZoom = 90.0R
        Me.Babout.IsTab = False
        Me.Babout.Location = New System.Drawing.Point(0, 195)
        Me.Babout.Name = "Babout"
        Me.Babout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Babout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Babout.OnHoverTextColor = System.Drawing.Color.White
        Me.Babout.selected = False
        Me.Babout.Size = New System.Drawing.Size(200, 48)
        Me.Babout.TabIndex = 0
        Me.Babout.Text = "About"
        Me.Babout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Babout.Textcolor = System.Drawing.Color.White
        Me.Babout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Cbxto
        '
        Me.Cbxto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxto.FormattingEnabled = True
        Me.Cbxto.Location = New System.Drawing.Point(341, 98)
        Me.Cbxto.Name = "Cbxto"
        Me.Cbxto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxto.Size = New System.Drawing.Size(227, 45)
        Me.Cbxto.TabIndex = 11
        Me.Cbxto.Text = "To"
        '
        'Cbxform
        '
        Me.Cbxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxform.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxform.FormattingEnabled = True
        Me.Cbxform.Location = New System.Drawing.Point(90, 98)
        Me.Cbxform.Name = "Cbxform"
        Me.Cbxform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxform.Size = New System.Drawing.Size(227, 45)
        Me.Cbxform.TabIndex = 11
        Me.Cbxform.Text = "Form"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(588, 99)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(89, 45)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "Sele"
        '
        'RBOne
        '
        Me.RBOne.AutoSize = True
        Me.RBOne.BackColor = System.Drawing.Color.Transparent
        Me.RBOne.Location = New System.Drawing.Point(90, 55)
        Me.RBOne.Name = "RBOne"
        Me.RBOne.Size = New System.Drawing.Size(70, 17)
        Me.RBOne.TabIndex = 5
        Me.RBOne.TabStop = True
        Me.RBOne.Text = "One Way"
        Me.RBOne.UseVisualStyleBackColor = False
        '
        'RBReturn
        '
        Me.RBReturn.AutoSize = True
        Me.RBReturn.BackColor = System.Drawing.Color.Transparent
        Me.RBReturn.Location = New System.Drawing.Point(166, 55)
        Me.RBReturn.Name = "RBReturn"
        Me.RBReturn.Size = New System.Drawing.Size(78, 17)
        Me.RBReturn.TabIndex = 5
        Me.RBReturn.TabStop = True
        Me.RBReturn.Text = "Round Trip"
        Me.RBReturn.UseVisualStyleBackColor = False
        '
        'BSearch
        '
        Me.BSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BSearch.BorderRadius = 0
        Me.BSearch.ButtonText = "Search"
        Me.BSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSearch.DisabledColor = System.Drawing.Color.Gray
        Me.BSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.BSearch.Iconimage = CType(resources.GetObject("BSearch.Iconimage"), System.Drawing.Image)
        Me.BSearch.Iconimage_right = Nothing
        Me.BSearch.Iconimage_right_Selected = Nothing
        Me.BSearch.Iconimage_Selected = Nothing
        Me.BSearch.IconMarginLeft = 0
        Me.BSearch.IconMarginRight = 0
        Me.BSearch.IconRightVisible = True
        Me.BSearch.IconRightZoom = 0.0R
        Me.BSearch.IconVisible = True
        Me.BSearch.IconZoom = 90.0R
        Me.BSearch.IsTab = False
        Me.BSearch.Location = New System.Drawing.Point(1171, 97)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.BSearch.selected = False
        Me.BSearch.Size = New System.Drawing.Size(136, 48)
        Me.BSearch.TabIndex = 9
        Me.BSearch.Text = "Search"
        Me.BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BSearch.Textcolor = System.Drawing.Color.White
        Me.BSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Ck1
        '
        Me.Ck1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Ck1.Checked = True
        Me.Ck1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck1.ForeColor = System.Drawing.Color.White
        Me.Ck1.Location = New System.Drawing.Point(90, 169)
        Me.Ck1.Name = "Ck1"
        Me.Ck1.Size = New System.Drawing.Size(20, 20)
        Me.Ck1.TabIndex = 10
        '
        'Ck2
        '
        Me.Ck2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Ck2.Checked = True
        Me.Ck2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck2.ForeColor = System.Drawing.Color.White
        Me.Ck2.Location = New System.Drawing.Point(215, 169)
        Me.Ck2.Name = "Ck2"
        Me.Ck2.Size = New System.Drawing.Size(20, 20)
        Me.Ck2.TabIndex = 10
        '
        'Ck3
        '
        Me.Ck3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck3.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Ck3.Checked = True
        Me.Ck3.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Ck3.ForeColor = System.Drawing.Color.White
        Me.Ck3.Location = New System.Drawing.Point(340, 169)
        Me.Ck3.Name = "Ck3"
        Me.Ck3.Size = New System.Drawing.Size(20, 20)
        Me.Ck3.TabIndex = 10
        '
        'PTitle
        '
        Me.PTitle.Controls.Add(Me.Ltitle)
        Me.PTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitle.Location = New System.Drawing.Point(0, 0)
        Me.PTitle.Name = "PTitle"
        Me.PTitle.Size = New System.Drawing.Size(1366, 61)
        Me.PTitle.TabIndex = 4
        '
        'Ltitle
        '
        Me.Ltitle.AutoSize = True
        Me.Ltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitle.Location = New System.Drawing.Point(472, 12)
        Me.Ltitle.Name = "Ltitle"
        Me.Ltitle.Size = New System.Drawing.Size(423, 37)
        Me.Ltitle.TabIndex = 3
        Me.Ltitle.Text = "Airline Reservation System"
        '
        'DPD
        '
        Me.DPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPD.Location = New System.Drawing.Point(707, 99)
        Me.DPD.Name = "DPD"
        Me.DPD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPD.Size = New System.Drawing.Size(188, 44)
        Me.DPD.TabIndex = 12
        '
        'DPR
        '
        Me.DPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPR.Location = New System.Drawing.Point(916, 99)
        Me.DPR.MaxDate = New Date(2018, 8, 31, 0, 0, 0, 0)
        Me.DPR.MinDate = New Date(2018, 4, 15, 0, 0, 0, 0)
        Me.DPR.Name = "DPR"
        Me.DPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPR.Size = New System.Drawing.Size(188, 44)
        Me.DPR.TabIndex = 12
        '
        'MainWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Psearch)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.PTitle)
        Me.Controls.Add(Me.PAdv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainWindows"
        Me.Text = "MainWindows"
        Me.PMenu.ResumeLayout(False)
        Me.PMenu.PerformLayout()
        Me.Psearch.ResumeLayout(False)
        Me.Psearch.PerformLayout()
        Me.PSmenu.ResumeLayout(False)
        Me.PTitle.ResumeLayout(False)
        Me.PTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PMenu As System.Windows.Forms.Panel
    Friend WithEvents LExit As System.Windows.Forms.Label
    Friend WithEvents PAdv As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LBF As System.Windows.Forms.Label
    Friend WithEvents LFS As System.Windows.Forms.Label
    Friend WithEvents LSU As System.Windows.Forms.Label
    Friend WithEvents LCI As System.Windows.Forms.Label
    Friend WithEvents LVCB As System.Windows.Forms.Label
    Friend WithEvents Psearch As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PTitle As System.Windows.Forms.Panel
    Friend WithEvents PSmenu As System.Windows.Forms.Panel
    Friend WithEvents Babout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bnotification As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bshedules As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bweather As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bbook As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RBReturn As System.Windows.Forms.RadioButton
    Friend WithEvents RBOne As System.Windows.Forms.RadioButton
    Friend WithEvents Ck3 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Ck2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Ck1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ltitle As System.Windows.Forms.Label
    Friend WithEvents Cbxto As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxform As System.Windows.Forms.ComboBox
    Friend WithEvents DPD As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPR As System.Windows.Forms.DateTimePicker
End Class
