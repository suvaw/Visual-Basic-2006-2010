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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindows))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.LBF = New System.Windows.Forms.Label()
        Me.LFS = New System.Windows.Forms.Label()
        Me.LCI = New System.Windows.Forms.Label()
        Me.LVCB = New System.Windows.Forms.Label()
        Me.LSU = New System.Windows.Forms.Label()
        Me.PTitle = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ltitle = New System.Windows.Forms.Label()
        Me.Transition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Btsearch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DPR = New System.Windows.Forms.DateTimePicker()
        Me.DPD = New System.Windows.Forms.DateTimePicker()
        Me.Cbxto = New System.Windows.Forms.ComboBox()
        Me.Cbxform = New System.Windows.Forms.ComboBox()
        Me.Cbxseat = New System.Windows.Forms.ComboBox()
        Me.RBOne = New System.Windows.Forms.RadioButton()
        Me.RBReturn = New System.Windows.Forms.RadioButton()
        Me.Ck1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Ck2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Ck3 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Psearch = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.des7 = New System.Windows.Forms.Panel()
        Me.des1 = New System.Windows.Forms.Panel()
        Me.des2 = New System.Windows.Forms.Panel()
        Me.des3 = New System.Windows.Forms.Panel()
        Me.des4 = New System.Windows.Forms.Panel()
        Me.des5 = New System.Windows.Forms.Panel()
        Me.des6 = New System.Windows.Forms.Panel()
        Me.Transition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PMenu.SuspendLayout()
        Me.PTitle.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Psearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PMenu.Controls.Add(Me.LBF)
        Me.PMenu.Controls.Add(Me.LFS)
        Me.PMenu.Controls.Add(Me.LCI)
        Me.PMenu.Controls.Add(Me.LVCB)
        Me.PMenu.Controls.Add(Me.LSU)
        Me.Transition1.SetDecoration(Me.PMenu, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.PMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PMenu.Location = New System.Drawing.Point(0, 61)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(1366, 53)
        Me.PMenu.TabIndex = 0
        '
        'LBF
        '
        Me.LBF.AutoSize = True
        Me.Transition1.SetDecoration(Me.LBF, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.LBF, BunifuAnimatorNS.DecorationType.None)
        Me.LBF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBF.Location = New System.Drawing.Point(475, 13)
        Me.LBF.Name = "LBF"
        Me.LBF.Size = New System.Drawing.Size(115, 24)
        Me.LBF.TabIndex = 0
        Me.LBF.Text = "Book Flight"
        '
        'LFS
        '
        Me.LFS.AutoSize = True
        Me.Transition1.SetDecoration(Me.LFS, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.LFS, BunifuAnimatorNS.DecorationType.None)
        Me.LFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFS.Location = New System.Drawing.Point(651, 13)
        Me.LFS.Name = "LFS"
        Me.LFS.Size = New System.Drawing.Size(124, 24)
        Me.LFS.TabIndex = 0
        Me.LFS.Text = "Flight Status"
        '
        'LCI
        '
        Me.LCI.AutoSize = True
        Me.Transition1.SetDecoration(Me.LCI, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.LCI, BunifuAnimatorNS.DecorationType.None)
        Me.LCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCI.Location = New System.Drawing.Point(836, 13)
        Me.LCI.Name = "LCI"
        Me.LCI.Size = New System.Drawing.Size(86, 24)
        Me.LCI.TabIndex = 0
        Me.LCI.Text = "CheckIn"
        '
        'LVCB
        '
        Me.LVCB.AutoSize = True
        Me.Transition1.SetDecoration(Me.LVCB, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.LVCB, BunifuAnimatorNS.DecorationType.None)
        Me.LVCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVCB.Location = New System.Drawing.Point(983, 13)
        Me.LVCB.Name = "LVCB"
        Me.LVCB.Size = New System.Drawing.Size(138, 24)
        Me.LVCB.TabIndex = 0
        Me.LVCB.Text = "View Booking"
        '
        'LSU
        '
        Me.LSU.AutoSize = True
        Me.Transition1.SetDecoration(Me.LSU, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.LSU, BunifuAnimatorNS.DecorationType.None)
        Me.LSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSU.Location = New System.Drawing.Point(1182, 13)
        Me.LSU.Name = "LSU"
        Me.LSU.Size = New System.Drawing.Size(136, 24)
        Me.LSU.TabIndex = 0
        Me.LSU.Text = "Login/SignUp"
        '
        'PTitle
        '
        Me.PTitle.Controls.Add(Me.PictureBox2)
        Me.PTitle.Controls.Add(Me.PictureBox1)
        Me.PTitle.Controls.Add(Me.Ltitle)
        Me.Transition1.SetDecoration(Me.PTitle, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.PTitle, BunifuAnimatorNS.DecorationType.None)
        Me.PTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitle.Location = New System.Drawing.Point(0, 0)
        Me.PTitle.Name = "PTitle"
        Me.PTitle.Size = New System.Drawing.Size(1366, 61)
        Me.PTitle.TabIndex = 4
        '
        'PictureBox2
        '
        Me.Transition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.AirlineReservationSystem.My.Resources.Resources.power_button_icon_22
        Me.PictureBox2.Location = New System.Drawing.Point(1311, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.Transition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.AirlineReservationSystem.My.Resources.Resources._827312_airport_512x512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Ltitle
        '
        Me.Ltitle.AutoSize = True
        Me.Transition1.SetDecoration(Me.Ltitle, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Ltitle, BunifuAnimatorNS.DecorationType.None)
        Me.Ltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitle.Location = New System.Drawing.Point(472, 12)
        Me.Ltitle.Name = "Ltitle"
        Me.Ltitle.Size = New System.Drawing.Size(423, 37)
        Me.Ltitle.TabIndex = 3
        Me.Ltitle.Text = "Airline Reservation System"
        '
        'Transition1
        '
        Me.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.Transition1.DefaultAnimation = Animation1
        '
        'Btsearch
        '
        Me.Btsearch.BackColor = System.Drawing.Color.Transparent
        Me.Btsearch.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.Search_Button_PNG_Transparent_Image
        Me.Btsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.Btsearch, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Btsearch, BunifuAnimatorNS.DecorationType.None)
        Me.Btsearch.FlatAppearance.BorderSize = 0
        Me.Btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btsearch.Location = New System.Drawing.Point(1136, 93)
        Me.Btsearch.Name = "Btsearch"
        Me.Btsearch.Size = New System.Drawing.Size(213, 48)
        Me.Btsearch.TabIndex = 5
        Me.Btsearch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Transition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(326, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Indian Armed Force"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Transition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(169, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Senior Citizen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Transition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(44, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Student"
        '
        'DPR
        '
        Me.DPR.Checked = False
        Me.Transition2.SetDecoration(Me.DPR, BunifuAnimatorNS.DecorationType.None)
        Me.Transition1.SetDecoration(Me.DPR, BunifuAnimatorNS.DecorationType.None)
        Me.DPR.Enabled = False
        Me.DPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPR.Location = New System.Drawing.Point(924, 95)
        Me.DPR.MaxDate = New Date(2018, 8, 31, 0, 0, 0, 0)
        Me.DPR.MinDate = New Date(2018, 4, 15, 0, 0, 0, 0)
        Me.DPR.Name = "DPR"
        Me.DPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPR.Size = New System.Drawing.Size(188, 44)
        Me.DPR.TabIndex = 12
        '
        'DPD
        '
        Me.Transition2.SetDecoration(Me.DPD, BunifuAnimatorNS.DecorationType.None)
        Me.Transition1.SetDecoration(Me.DPD, BunifuAnimatorNS.DecorationType.None)
        Me.DPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPD.Location = New System.Drawing.Point(712, 95)
        Me.DPD.MaxDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DPD.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DPD.Name = "DPD"
        Me.DPD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPD.Size = New System.Drawing.Size(188, 44)
        Me.DPD.TabIndex = 4
        '
        'Cbxto
        '
        Me.Transition1.SetDecoration(Me.Cbxto, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Cbxto, BunifuAnimatorNS.DecorationType.None)
        Me.Cbxto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxto.FormattingEnabled = True
        Me.Cbxto.Location = New System.Drawing.Point(308, 95)
        Me.Cbxto.Name = "Cbxto"
        Me.Cbxto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxto.Size = New System.Drawing.Size(267, 45)
        Me.Cbxto.TabIndex = 2
        Me.Cbxto.Text = "To"
        '
        'Cbxform
        '
        Me.Transition1.SetDecoration(Me.Cbxform, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Cbxform, BunifuAnimatorNS.DecorationType.None)
        Me.Cbxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxform.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxform.FormattingEnabled = True
        Me.Cbxform.Location = New System.Drawing.Point(17, 95)
        Me.Cbxform.Name = "Cbxform"
        Me.Cbxform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxform.Size = New System.Drawing.Size(267, 45)
        Me.Cbxform.TabIndex = 1
        Me.Cbxform.Text = "Form"
        '
        'Cbxseat
        '
        Me.Transition1.SetDecoration(Me.Cbxseat, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Cbxseat, BunifuAnimatorNS.DecorationType.None)
        Me.Cbxseat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxseat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxseat.FormattingEnabled = True
        Me.Cbxseat.Location = New System.Drawing.Point(599, 95)
        Me.Cbxseat.Name = "Cbxseat"
        Me.Cbxseat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxseat.Size = New System.Drawing.Size(89, 45)
        Me.Cbxseat.TabIndex = 3
        Me.Cbxseat.Text = "Sit"
        '
        'RBOne
        '
        Me.RBOne.AutoSize = True
        Me.RBOne.BackColor = System.Drawing.Color.Transparent
        Me.Transition1.SetDecoration(Me.RBOne, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.RBOne, BunifuAnimatorNS.DecorationType.None)
        Me.RBOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOne.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RBOne.Location = New System.Drawing.Point(17, 55)
        Me.RBOne.Name = "RBOne"
        Me.RBOne.Size = New System.Drawing.Size(114, 28)
        Me.RBOne.TabIndex = 0
        Me.RBOne.Text = "One Way"
        Me.RBOne.UseVisualStyleBackColor = False
        '
        'RBReturn
        '
        Me.RBReturn.AutoSize = True
        Me.RBReturn.BackColor = System.Drawing.Color.Transparent
        Me.Transition1.SetDecoration(Me.RBReturn, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.RBReturn, BunifuAnimatorNS.DecorationType.None)
        Me.RBReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBReturn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RBReturn.Location = New System.Drawing.Point(155, 55)
        Me.RBReturn.Name = "RBReturn"
        Me.RBReturn.Size = New System.Drawing.Size(133, 28)
        Me.RBReturn.TabIndex = 0
        Me.RBReturn.Text = "Round Trip"
        Me.RBReturn.UseVisualStyleBackColor = False
        '
        'Ck1
        '
        Me.Ck1.BackColor = System.Drawing.Color.Lavender
        Me.Ck1.ChechedOffColor = System.Drawing.Color.Lavender
        Me.Ck1.Checked = False
        Me.Ck1.CheckedOnColor = System.Drawing.Color.LightSteelBlue
        Me.Transition1.SetDecoration(Me.Ck1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Ck1, BunifuAnimatorNS.DecorationType.None)
        Me.Ck1.ForeColor = System.Drawing.Color.White
        Me.Ck1.Location = New System.Drawing.Point(19, 174)
        Me.Ck1.Name = "Ck1"
        Me.Ck1.Size = New System.Drawing.Size(20, 20)
        Me.Ck1.TabIndex = 6
        '
        'Ck2
        '
        Me.Ck2.BackColor = System.Drawing.Color.Lavender
        Me.Ck2.ChechedOffColor = System.Drawing.Color.Lavender
        Me.Ck2.Checked = False
        Me.Ck2.CheckedOnColor = System.Drawing.Color.LightSteelBlue
        Me.Transition1.SetDecoration(Me.Ck2, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Ck2, BunifuAnimatorNS.DecorationType.None)
        Me.Ck2.ForeColor = System.Drawing.Color.White
        Me.Ck2.Location = New System.Drawing.Point(144, 174)
        Me.Ck2.Name = "Ck2"
        Me.Ck2.Size = New System.Drawing.Size(20, 20)
        Me.Ck2.TabIndex = 6
        '
        'Ck3
        '
        Me.Ck3.BackColor = System.Drawing.Color.Lavender
        Me.Ck3.ChechedOffColor = System.Drawing.Color.Lavender
        Me.Ck3.Checked = False
        Me.Ck3.CheckedOnColor = System.Drawing.Color.LightSteelBlue
        Me.Transition1.SetDecoration(Me.Ck3, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Ck3, BunifuAnimatorNS.DecorationType.None)
        Me.Ck3.ForeColor = System.Drawing.Color.White
        Me.Ck3.Location = New System.Drawing.Point(302, 174)
        Me.Ck3.Name = "Ck3"
        Me.Ck3.Size = New System.Drawing.Size(20, 20)
        Me.Ck3.TabIndex = 6
        '
        'Psearch
        '
        Me.Psearch.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._5
        Me.Psearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Psearch.Controls.Add(Me.Btsearch)
        Me.Psearch.Controls.Add(Me.Cbxto)
        Me.Psearch.Controls.Add(Me.Label8)
        Me.Psearch.Controls.Add(Me.Ck3)
        Me.Psearch.Controls.Add(Me.Label7)
        Me.Psearch.Controls.Add(Me.Ck2)
        Me.Psearch.Controls.Add(Me.Label6)
        Me.Psearch.Controls.Add(Me.Ck1)
        Me.Psearch.Controls.Add(Me.DPR)
        Me.Psearch.Controls.Add(Me.RBReturn)
        Me.Psearch.Controls.Add(Me.DPD)
        Me.Psearch.Controls.Add(Me.RBOne)
        Me.Psearch.Controls.Add(Me.Cbxseat)
        Me.Psearch.Controls.Add(Me.Cbxform)
        Me.Transition1.SetDecoration(Me.Psearch, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Psearch, BunifuAnimatorNS.DecorationType.None)
        Me.Psearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.Psearch.Location = New System.Drawing.Point(0, 114)
        Me.Psearch.Name = "Psearch"
        Me.Psearch.Size = New System.Drawing.Size(1366, 248)
        Me.Psearch.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.des7)
        Me.Panel1.Controls.Add(Me.des1)
        Me.Panel1.Controls.Add(Me.des2)
        Me.Panel1.Controls.Add(Me.des3)
        Me.Panel1.Controls.Add(Me.des4)
        Me.Panel1.Controls.Add(Me.des5)
        Me.Panel1.Controls.Add(Me.des6)
        Me.Transition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 409)
        Me.Panel1.TabIndex = 6
        '
        'des7
        '
        Me.des7.BackgroundImage = CType(resources.GetObject("des7.BackgroundImage"), System.Drawing.Image)
        Me.des7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des7, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des7, BunifuAnimatorNS.DecorationType.None)
        Me.des7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des7.Location = New System.Drawing.Point(0, 0)
        Me.des7.Name = "des7"
        Me.des7.Size = New System.Drawing.Size(1366, 409)
        Me.des7.TabIndex = 5
        '
        'des1
        '
        Me.des1.BackgroundImage = CType(resources.GetObject("des1.BackgroundImage"), System.Drawing.Image)
        Me.des1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des1, BunifuAnimatorNS.DecorationType.None)
        Me.des1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des1.Location = New System.Drawing.Point(0, 0)
        Me.des1.Name = "des1"
        Me.des1.Size = New System.Drawing.Size(1366, 409)
        Me.des1.TabIndex = 1
        Me.des1.Visible = False
        '
        'des2
        '
        Me.des2.BackgroundImage = CType(resources.GetObject("des2.BackgroundImage"), System.Drawing.Image)
        Me.des2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des2, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des2, BunifuAnimatorNS.DecorationType.None)
        Me.des2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des2.Location = New System.Drawing.Point(0, 0)
        Me.des2.Name = "des2"
        Me.des2.Size = New System.Drawing.Size(1366, 409)
        Me.des2.TabIndex = 1
        Me.des2.Visible = False
        '
        'des3
        '
        Me.des3.BackgroundImage = CType(resources.GetObject("des3.BackgroundImage"), System.Drawing.Image)
        Me.des3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des3, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des3, BunifuAnimatorNS.DecorationType.None)
        Me.des3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des3.Location = New System.Drawing.Point(0, 0)
        Me.des3.Name = "des3"
        Me.des3.Size = New System.Drawing.Size(1366, 409)
        Me.des3.TabIndex = 2
        Me.des3.Visible = False
        '
        'des4
        '
        Me.des4.BackgroundImage = CType(resources.GetObject("des4.BackgroundImage"), System.Drawing.Image)
        Me.des4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des4, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des4, BunifuAnimatorNS.DecorationType.None)
        Me.des4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des4.Location = New System.Drawing.Point(0, 0)
        Me.des4.Name = "des4"
        Me.des4.Size = New System.Drawing.Size(1366, 409)
        Me.des4.TabIndex = 1
        Me.des4.Visible = False
        '
        'des5
        '
        Me.des5.BackgroundImage = CType(resources.GetObject("des5.BackgroundImage"), System.Drawing.Image)
        Me.des5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des5, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des5, BunifuAnimatorNS.DecorationType.None)
        Me.des5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des5.Location = New System.Drawing.Point(0, 0)
        Me.des5.Name = "des5"
        Me.des5.Size = New System.Drawing.Size(1366, 409)
        Me.des5.TabIndex = 3
        Me.des5.Visible = False
        '
        'des6
        '
        Me.des6.BackgroundImage = CType(resources.GetObject("des6.BackgroundImage"), System.Drawing.Image)
        Me.des6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transition1.SetDecoration(Me.des6, BunifuAnimatorNS.DecorationType.None)
        Me.Transition2.SetDecoration(Me.des6, BunifuAnimatorNS.DecorationType.None)
        Me.des6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.des6.Location = New System.Drawing.Point(0, 0)
        Me.des6.Name = "des6"
        Me.des6.Size = New System.Drawing.Size(1366, 409)
        Me.des6.TabIndex = 4
        Me.des6.Visible = False
        '
        'Transition2
        '
        Me.Transition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.Transition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.Transition2.DefaultAnimation = Animation2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Psearch)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.PTitle)
        Me.Transition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Transition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainWindows"
        Me.Text = "MainWindows"
        Me.PMenu.ResumeLayout(False)
        Me.PMenu.PerformLayout()
        Me.PTitle.ResumeLayout(False)
        Me.PTitle.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Psearch.ResumeLayout(False)
        Me.Psearch.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PMenu As System.Windows.Forms.Panel
    Friend WithEvents LBF As System.Windows.Forms.Label
    Friend WithEvents LFS As System.Windows.Forms.Label
    Friend WithEvents LSU As System.Windows.Forms.Label
    Friend WithEvents LCI As System.Windows.Forms.Label
    Friend WithEvents LVCB As System.Windows.Forms.Label
    Friend WithEvents PTitle As System.Windows.Forms.Panel
    Friend WithEvents RBReturn As System.Windows.Forms.RadioButton
    Friend WithEvents RBOne As System.Windows.Forms.RadioButton
    Friend WithEvents Ck3 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Ck2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Ck1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cbxseat As System.Windows.Forms.ComboBox
    Friend WithEvents Ltitle As System.Windows.Forms.Label
    Friend WithEvents Cbxto As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxform As System.Windows.Forms.ComboBox
    Friend WithEvents DPD As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Transition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Transition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Btsearch As System.Windows.Forms.Button
    Friend WithEvents Psearch As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents des1 As System.Windows.Forms.Panel
    Friend WithEvents des2 As System.Windows.Forms.Panel
    Friend WithEvents des3 As System.Windows.Forms.Panel
    Friend WithEvents des4 As System.Windows.Forms.Panel
    Friend WithEvents des5 As System.Windows.Forms.Panel
    Friend WithEvents des6 As System.Windows.Forms.Panel
    Friend WithEvents des7 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
