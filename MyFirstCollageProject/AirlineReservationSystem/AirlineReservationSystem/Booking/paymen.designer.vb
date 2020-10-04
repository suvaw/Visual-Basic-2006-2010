<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
        Me.CCDCButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.IBButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.UPIButon = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.WalletButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.VoutureButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PCreditCard = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Lcaedtitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lcard = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CbxCardname = New System.Windows.Forms.ComboBox()
        Me.Lcard2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tcardname = New System.Windows.Forms.TextBox()
        Me.Lvalid = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CbxValid = New System.Windows.Forms.ComboBox()
        Me.CbxValid2 = New System.Windows.Forms.ComboBox()
        Me.Lcvv = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tcvv = New System.Windows.Forms.TextBox()
        Me.Lcardholder = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tcardholder = New System.Windows.Forms.TextBox()
        Me.Bsubmit = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Ppaydetails = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pupi = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Lupititle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tupiinput = New System.Windows.Forms.TextBox()
        Me.lupiinfo = New System.Windows.Forms.Label()
        Me.Bupiubmit = New System.Windows.Forms.Button()
        Me.Bupiclear = New System.Windows.Forms.Button()
        Me.pupitrans = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pnetbanking = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Lnbtitle = New System.Windows.Forms.Label()
        Me.Tbank = New System.Windows.Forms.Label()
        Me.CbxBanklist = New System.Windows.Forms.ComboBox()
        Me.Bnbsubmit = New System.Windows.Forms.Button()
        Me.Bnbcancle = New System.Windows.Forms.Button()
        Me.Pnbtransi = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Pwallet = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Ltbanner = New System.Windows.Forms.Label()
        Me.Lwtitle = New System.Windows.Forms.Label()
        Me.Cb1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lwinfo = New System.Windows.Forms.Label()
        Me.Bwsubmit = New System.Windows.Forms.Button()
        Me.Bwcancle = New System.Windows.Forms.Button()
        Me.Pwpanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Pvoucher = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Lvtitle = New System.Windows.Forms.Label()
        Me.Lvtype = New System.Windows.Forms.Label()
        Me.Cbxvinput = New System.Windows.Forms.ComboBox()
        Me.Lvvouch = New System.Windows.Forms.Label()
        Me.Tvinput = New System.Windows.Forms.TextBox()
        Me.Bvsubmit = New System.Windows.Forms.Button()
        Me.Bvclear = New System.Windows.Forms.Button()
        Me.Pvtrans = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PayExit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PTitle = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PSmenu = New System.Windows.Forms.Panel()
        Me.PDetails = New System.Windows.Forms.Panel()
        Me.Pwelcome = New System.Windows.Forms.Panel()
        Me.Lwelmsg = New System.Windows.Forms.Label()
        Me.Pcomplite = New System.Windows.Forms.Panel()
        Me.Printbox = New System.Windows.Forms.TextBox()
        Me.LtransMsg = New System.Windows.Forms.Label()
        Me.Bsave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Bprint = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BPprivew = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BHome = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewd = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFiled = New System.Windows.Forms.SaveFileDialog()
        Me.PCreditCard.SuspendLayout()
        Me.Ppaydetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pupi.SuspendLayout()
        Me.pupitrans.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnetbanking.SuspendLayout()
        Me.Pnbtransi.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pwallet.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pwpanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pvoucher.SuspendLayout()
        Me.Pvtrans.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTitle.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PMenu.SuspendLayout()
        Me.PSmenu.SuspendLayout()
        Me.PDetails.SuspendLayout()
        Me.Pwelcome.SuspendLayout()
        Me.Pcomplite.SuspendLayout()
        Me.SuspendLayout()
        '
        'CCDCButton
        '
        Me.CCDCButton.ActiveBorderThickness = 1
        Me.CCDCButton.ActiveCornerRadius = 20
        Me.CCDCButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.CCDCButton.ActiveForecolor = System.Drawing.Color.White
        Me.CCDCButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.CCDCButton.BackColor = System.Drawing.SystemColors.Control
        Me.CCDCButton.BackgroundImage = CType(resources.GetObject("CCDCButton.BackgroundImage"), System.Drawing.Image)
        Me.CCDCButton.ButtonText = "Credit / Debit Cards"
        Me.CCDCButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CCDCButton.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCDCButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.CCDCButton.IdleBorderThickness = 1
        Me.CCDCButton.IdleCornerRadius = 20
        Me.CCDCButton.IdleFillColor = System.Drawing.Color.DimGray
        Me.CCDCButton.IdleForecolor = System.Drawing.Color.White
        Me.CCDCButton.IdleLineColor = System.Drawing.Color.DimGray
        Me.CCDCButton.Location = New System.Drawing.Point(10, 77)
        Me.CCDCButton.Margin = New System.Windows.Forms.Padding(5)
        Me.CCDCButton.Name = "CCDCButton"
        Me.CCDCButton.Size = New System.Drawing.Size(356, 62)
        Me.CCDCButton.TabIndex = 0
        Me.CCDCButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IBButton
        '
        Me.IBButton.ActiveBorderThickness = 1
        Me.IBButton.ActiveCornerRadius = 20
        Me.IBButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.IBButton.ActiveForecolor = System.Drawing.Color.White
        Me.IBButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.IBButton.BackColor = System.Drawing.SystemColors.Control
        Me.IBButton.BackgroundImage = CType(resources.GetObject("IBButton.BackgroundImage"), System.Drawing.Image)
        Me.IBButton.ButtonText = "Internet Banking"
        Me.IBButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IBButton.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.IBButton.IdleBorderThickness = 1
        Me.IBButton.IdleCornerRadius = 20
        Me.IBButton.IdleFillColor = System.Drawing.Color.DimGray
        Me.IBButton.IdleForecolor = System.Drawing.Color.White
        Me.IBButton.IdleLineColor = System.Drawing.Color.DimGray
        Me.IBButton.Location = New System.Drawing.Point(10, 371)
        Me.IBButton.Margin = New System.Windows.Forms.Padding(5)
        Me.IBButton.Name = "IBButton"
        Me.IBButton.Size = New System.Drawing.Size(356, 62)
        Me.IBButton.TabIndex = 0
        Me.IBButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UPIButon
        '
        Me.UPIButon.ActiveBorderThickness = 1
        Me.UPIButon.ActiveCornerRadius = 20
        Me.UPIButon.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.UPIButon.ActiveForecolor = System.Drawing.Color.White
        Me.UPIButon.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.UPIButon.BackColor = System.Drawing.SystemColors.Control
        Me.UPIButon.BackgroundImage = CType(resources.GetObject("UPIButon.BackgroundImage"), System.Drawing.Image)
        Me.UPIButon.ButtonText = "UPI"
        Me.UPIButon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UPIButon.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPIButon.ForeColor = System.Drawing.Color.SeaGreen
        Me.UPIButon.IdleBorderThickness = 1
        Me.UPIButon.IdleCornerRadius = 20
        Me.UPIButon.IdleFillColor = System.Drawing.Color.DimGray
        Me.UPIButon.IdleForecolor = System.Drawing.Color.Transparent
        Me.UPIButon.IdleLineColor = System.Drawing.Color.DimGray
        Me.UPIButon.Location = New System.Drawing.Point(10, 469)
        Me.UPIButon.Margin = New System.Windows.Forms.Padding(5)
        Me.UPIButon.Name = "UPIButon"
        Me.UPIButon.Size = New System.Drawing.Size(356, 62)
        Me.UPIButon.TabIndex = 0
        Me.UPIButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WalletButton
        '
        Me.WalletButton.ActiveBorderThickness = 1
        Me.WalletButton.ActiveCornerRadius = 20
        Me.WalletButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.WalletButton.ActiveForecolor = System.Drawing.Color.White
        Me.WalletButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.WalletButton.BackColor = System.Drawing.SystemColors.Control
        Me.WalletButton.BackgroundImage = CType(resources.GetObject("WalletButton.BackgroundImage"), System.Drawing.Image)
        Me.WalletButton.ButtonText = "Wallet"
        Me.WalletButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WalletButton.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WalletButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.WalletButton.IdleBorderThickness = 1
        Me.WalletButton.IdleCornerRadius = 20
        Me.WalletButton.IdleFillColor = System.Drawing.Color.DimGray
        Me.WalletButton.IdleForecolor = System.Drawing.Color.White
        Me.WalletButton.IdleLineColor = System.Drawing.Color.DimGray
        Me.WalletButton.Location = New System.Drawing.Point(10, 175)
        Me.WalletButton.Margin = New System.Windows.Forms.Padding(5)
        Me.WalletButton.Name = "WalletButton"
        Me.WalletButton.Size = New System.Drawing.Size(356, 62)
        Me.WalletButton.TabIndex = 0
        Me.WalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VoutureButton
        '
        Me.VoutureButton.ActiveBorderThickness = 1
        Me.VoutureButton.ActiveCornerRadius = 20
        Me.VoutureButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.VoutureButton.ActiveForecolor = System.Drawing.Color.White
        Me.VoutureButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.VoutureButton.BackColor = System.Drawing.SystemColors.Control
        Me.VoutureButton.BackgroundImage = CType(resources.GetObject("VoutureButton.BackgroundImage"), System.Drawing.Image)
        Me.VoutureButton.ButtonText = "Voucher"
        Me.VoutureButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VoutureButton.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoutureButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.VoutureButton.IdleBorderThickness = 1
        Me.VoutureButton.IdleCornerRadius = 20
        Me.VoutureButton.IdleFillColor = System.Drawing.Color.DimGray
        Me.VoutureButton.IdleForecolor = System.Drawing.Color.White
        Me.VoutureButton.IdleLineColor = System.Drawing.Color.DimGray
        Me.VoutureButton.Location = New System.Drawing.Point(10, 273)
        Me.VoutureButton.Margin = New System.Windows.Forms.Padding(5)
        Me.VoutureButton.Name = "VoutureButton"
        Me.VoutureButton.Size = New System.Drawing.Size(356, 62)
        Me.VoutureButton.TabIndex = 0
        Me.VoutureButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCreditCard
        '
        Me.PCreditCard.BackColor = System.Drawing.SystemColors.Control
        Me.PCreditCard.BackgroundImage = CType(resources.GetObject("PCreditCard.BackgroundImage"), System.Drawing.Image)
        Me.PCreditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PCreditCard.Controls.Add(Me.Lcaedtitle)
        Me.PCreditCard.Controls.Add(Me.Lcard)
        Me.PCreditCard.Controls.Add(Me.CbxCardname)
        Me.PCreditCard.Controls.Add(Me.Lcard2)
        Me.PCreditCard.Controls.Add(Me.Tcardname)
        Me.PCreditCard.Controls.Add(Me.Lvalid)
        Me.PCreditCard.Controls.Add(Me.CbxValid)
        Me.PCreditCard.Controls.Add(Me.CbxValid2)
        Me.PCreditCard.Controls.Add(Me.Lcvv)
        Me.PCreditCard.Controls.Add(Me.Tcvv)
        Me.PCreditCard.Controls.Add(Me.Lcardholder)
        Me.PCreditCard.Controls.Add(Me.Tcardholder)
        Me.PCreditCard.Controls.Add(Me.Bsubmit)
        Me.PCreditCard.Controls.Add(Me.Bclear)
        Me.PCreditCard.Controls.Add(Me.Ppaydetails)
        Me.PCreditCard.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaptionText
        Me.PCreditCard.GradientBottomRight = System.Drawing.Color.Black
        Me.PCreditCard.GradientTopLeft = System.Drawing.SystemColors.WindowFrame
        Me.PCreditCard.GradientTopRight = System.Drawing.Color.SpringGreen
        Me.PCreditCard.Location = New System.Drawing.Point(81, 113)
        Me.PCreditCard.Name = "PCreditCard"
        Me.PCreditCard.Quality = 10
        Me.PCreditCard.Size = New System.Drawing.Size(830, 425)
        Me.PCreditCard.TabIndex = 1
        '
        'Lcaedtitle
        '
        Me.Lcaedtitle.AutoSize = True
        Me.Lcaedtitle.BackColor = System.Drawing.Color.Transparent
        Me.Lcaedtitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lcaedtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcaedtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lcaedtitle.Location = New System.Drawing.Point(246, 14)
        Me.Lcaedtitle.Name = "Lcaedtitle"
        Me.Lcaedtitle.Size = New System.Drawing.Size(338, 16)
        Me.Lcaedtitle.TabIndex = 0
        Me.Lcaedtitle.Text = "Provide your card details to confirm the booking"
        '
        'Lcard
        '
        Me.Lcard.AutoSize = True
        Me.Lcard.BackColor = System.Drawing.Color.Transparent
        Me.Lcard.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcard.ForeColor = System.Drawing.Color.Snow
        Me.Lcard.Location = New System.Drawing.Point(67, 50)
        Me.Lcard.Name = "Lcard"
        Me.Lcard.Size = New System.Drawing.Size(166, 15)
        Me.Lcard.TabIndex = 0
        Me.Lcard.Text = "CREDIT / DEBIT CARD:"
        '
        'CbxCardname
        '
        Me.CbxCardname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCardname.FormattingEnabled = True
        Me.CbxCardname.Location = New System.Drawing.Point(67, 73)
        Me.CbxCardname.Name = "CbxCardname"
        Me.CbxCardname.Size = New System.Drawing.Size(236, 32)
        Me.CbxCardname.TabIndex = 1
        '
        'Lcard2
        '
        Me.Lcard2.AutoSize = True
        Me.Lcard2.BackColor = System.Drawing.Color.Transparent
        Me.Lcard2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcard2.ForeColor = System.Drawing.Color.Snow
        Me.Lcard2.Location = New System.Drawing.Point(67, 120)
        Me.Lcard2.Name = "Lcard2"
        Me.Lcard2.Size = New System.Drawing.Size(123, 15)
        Me.Lcard2.TabIndex = 0
        Me.Lcard2.Text = "*CARD NUMBER:"
        '
        'Tcardname
        '
        Me.Tcardname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcardname.Location = New System.Drawing.Point(67, 141)
        Me.Tcardname.Name = "Tcardname"
        Me.Tcardname.Size = New System.Drawing.Size(236, 29)
        Me.Tcardname.TabIndex = 2
        '
        'Lvalid
        '
        Me.Lvalid.AutoSize = True
        Me.Lvalid.BackColor = System.Drawing.Color.Transparent
        Me.Lvalid.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvalid.ForeColor = System.Drawing.Color.Snow
        Me.Lvalid.Location = New System.Drawing.Point(69, 188)
        Me.Lvalid.Name = "Lvalid"
        Me.Lvalid.Size = New System.Drawing.Size(106, 15)
        Me.Lvalid.TabIndex = 0
        Me.Lvalid.Text = "*VALID UPTO:"
        '
        'CbxValid
        '
        Me.CbxValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxValid.FormattingEnabled = True
        Me.CbxValid.Location = New System.Drawing.Point(67, 206)
        Me.CbxValid.Name = "CbxValid"
        Me.CbxValid.Size = New System.Drawing.Size(62, 32)
        Me.CbxValid.TabIndex = 1
        '
        'CbxValid2
        '
        Me.CbxValid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxValid2.FormattingEnabled = True
        Me.CbxValid2.Location = New System.Drawing.Point(129, 206)
        Me.CbxValid2.Name = "CbxValid2"
        Me.CbxValid2.Size = New System.Drawing.Size(62, 32)
        Me.CbxValid2.TabIndex = 1
        '
        'Lcvv
        '
        Me.Lcvv.AutoSize = True
        Me.Lcvv.BackColor = System.Drawing.Color.Transparent
        Me.Lcvv.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcvv.ForeColor = System.Drawing.Color.Snow
        Me.Lcvv.Location = New System.Drawing.Point(207, 190)
        Me.Lcvv.Name = "Lcvv"
        Me.Lcvv.Size = New System.Drawing.Size(46, 15)
        Me.Lcvv.TabIndex = 0
        Me.Lcvv.Text = "*CVV:"
        '
        'Tcvv
        '
        Me.Tcvv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcvv.Location = New System.Drawing.Point(203, 208)
        Me.Tcvv.Name = "Tcvv"
        Me.Tcvv.Size = New System.Drawing.Size(100, 29)
        Me.Tcvv.TabIndex = 2
        '
        'Lcardholder
        '
        Me.Lcardholder.AutoSize = True
        Me.Lcardholder.BackColor = System.Drawing.Color.Transparent
        Me.Lcardholder.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcardholder.ForeColor = System.Drawing.Color.Snow
        Me.Lcardholder.Location = New System.Drawing.Point(70, 263)
        Me.Lcardholder.Name = "Lcardholder"
        Me.Lcardholder.Size = New System.Drawing.Size(117, 15)
        Me.Lcardholder.TabIndex = 0
        Me.Lcardholder.Text = "*CARDHOLDER:"
        '
        'Tcardholder
        '
        Me.Tcardholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcardholder.Location = New System.Drawing.Point(67, 282)
        Me.Tcardholder.Name = "Tcardholder"
        Me.Tcardholder.Size = New System.Drawing.Size(236, 29)
        Me.Tcardholder.TabIndex = 2
        '
        'Bsubmit
        '
        Me.Bsubmit.Location = New System.Drawing.Point(67, 340)
        Me.Bsubmit.Name = "Bsubmit"
        Me.Bsubmit.Size = New System.Drawing.Size(100, 39)
        Me.Bsubmit.TabIndex = 4
        Me.Bsubmit.Text = "Submit"
        Me.Bsubmit.UseVisualStyleBackColor = True
        '
        'Bclear
        '
        Me.Bclear.Location = New System.Drawing.Point(203, 340)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(100, 39)
        Me.Bclear.TabIndex = 4
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'Ppaydetails
        '
        Me.Ppaydetails.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ppaydetails.Controls.Add(Me.PictureBox1)
        Me.Ppaydetails.Location = New System.Drawing.Point(414, 51)
        Me.Ppaydetails.Name = "Ppaydetails"
        Me.Ppaydetails.Size = New System.Drawing.Size(375, 318)
        Me.Ppaydetails.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Pupi
        '
        Me.Pupi.BackgroundImage = CType(resources.GetObject("Pupi.BackgroundImage"), System.Drawing.Image)
        Me.Pupi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pupi.Controls.Add(Me.Lupititle)
        Me.Pupi.Controls.Add(Me.Label4)
        Me.Pupi.Controls.Add(Me.Tupiinput)
        Me.Pupi.Controls.Add(Me.lupiinfo)
        Me.Pupi.Controls.Add(Me.Bupiubmit)
        Me.Pupi.Controls.Add(Me.Bupiclear)
        Me.Pupi.Controls.Add(Me.pupitrans)
        Me.Pupi.GradientBottomLeft = System.Drawing.Color.White
        Me.Pupi.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.Pupi.GradientTopLeft = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pupi.GradientTopRight = System.Drawing.Color.Turquoise
        Me.Pupi.Location = New System.Drawing.Point(81, 113)
        Me.Pupi.Name = "Pupi"
        Me.Pupi.Quality = 10
        Me.Pupi.Size = New System.Drawing.Size(830, 425)
        Me.Pupi.TabIndex = 2
        '
        'Lupititle
        '
        Me.Lupititle.AutoSize = True
        Me.Lupititle.BackColor = System.Drawing.Color.Transparent
        Me.Lupititle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lupititle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Lupititle.Location = New System.Drawing.Point(359, 9)
        Me.Lupititle.Name = "Lupititle"
        Me.Lupititle.Size = New System.Drawing.Size(113, 18)
        Me.Lupititle.TabIndex = 0
        Me.Lupititle.Text = "Pay using UPI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Honeydew
        Me.Label4.Location = New System.Drawing.Point(61, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Enter your Virtual Payment Address (VPA)"
        '
        'Tupiinput
        '
        Me.Tupiinput.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Tupiinput.Location = New System.Drawing.Point(61, 147)
        Me.Tupiinput.Multiline = True
        Me.Tupiinput.Name = "Tupiinput"
        Me.Tupiinput.Size = New System.Drawing.Size(316, 34)
        Me.Tupiinput.TabIndex = 1
        '
        'lupiinfo
        '
        Me.lupiinfo.AutoSize = True
        Me.lupiinfo.BackColor = System.Drawing.Color.Transparent
        Me.lupiinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lupiinfo.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lupiinfo.Location = New System.Drawing.Point(61, 229)
        Me.lupiinfo.Name = "lupiinfo"
        Me.lupiinfo.Size = New System.Drawing.Size(320, 32)
        Me.lupiinfo.TabIndex = 0
        Me.lupiinfo.Text = "VPA is a unique payment address that can be linked " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to a person'sbank accounts t" & _
    "o make payments"
        '
        'Bupiubmit
        '
        Me.Bupiubmit.Location = New System.Drawing.Point(101, 332)
        Me.Bupiubmit.Name = "Bupiubmit"
        Me.Bupiubmit.Size = New System.Drawing.Size(100, 39)
        Me.Bupiubmit.TabIndex = 5
        Me.Bupiubmit.Text = "Submit"
        Me.Bupiubmit.UseVisualStyleBackColor = True
        '
        'Bupiclear
        '
        Me.Bupiclear.Location = New System.Drawing.Point(249, 332)
        Me.Bupiclear.Name = "Bupiclear"
        Me.Bupiclear.Size = New System.Drawing.Size(100, 39)
        Me.Bupiclear.TabIndex = 6
        Me.Bupiclear.Text = "Clear"
        Me.Bupiclear.UseVisualStyleBackColor = True
        '
        'pupitrans
        '
        Me.pupitrans.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pupitrans.Controls.Add(Me.PictureBox2)
        Me.pupitrans.Location = New System.Drawing.Point(417, 53)
        Me.pupitrans.Name = "pupitrans"
        Me.pupitrans.Size = New System.Drawing.Size(375, 318)
        Me.pupitrans.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Pnetbanking
        '
        Me.Pnetbanking.BackgroundImage = CType(resources.GetObject("Pnetbanking.BackgroundImage"), System.Drawing.Image)
        Me.Pnetbanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnetbanking.Controls.Add(Me.Lnbtitle)
        Me.Pnetbanking.Controls.Add(Me.Tbank)
        Me.Pnetbanking.Controls.Add(Me.CbxBanklist)
        Me.Pnetbanking.Controls.Add(Me.Bnbsubmit)
        Me.Pnetbanking.Controls.Add(Me.Bnbcancle)
        Me.Pnetbanking.Controls.Add(Me.Pnbtransi)
        Me.Pnetbanking.GradientBottomLeft = System.Drawing.Color.Teal
        Me.Pnetbanking.GradientBottomRight = System.Drawing.Color.White
        Me.Pnetbanking.GradientTopLeft = System.Drawing.Color.Yellow
        Me.Pnetbanking.GradientTopRight = System.Drawing.SystemColors.Window
        Me.Pnetbanking.Location = New System.Drawing.Point(81, 113)
        Me.Pnetbanking.Name = "Pnetbanking"
        Me.Pnetbanking.Quality = 10
        Me.Pnetbanking.Size = New System.Drawing.Size(830, 425)
        Me.Pnetbanking.TabIndex = 3
        '
        'Lnbtitle
        '
        Me.Lnbtitle.AutoSize = True
        Me.Lnbtitle.BackColor = System.Drawing.Color.Transparent
        Me.Lnbtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnbtitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lnbtitle.Location = New System.Drawing.Point(242, 12)
        Me.Lnbtitle.Name = "Lnbtitle"
        Me.Lnbtitle.Size = New System.Drawing.Size(346, 24)
        Me.Lnbtitle.TabIndex = 0
        Me.Lnbtitle.Text = "Pay using your Net banking account"
        '
        'Tbank
        '
        Me.Tbank.AutoSize = True
        Me.Tbank.BackColor = System.Drawing.Color.Transparent
        Me.Tbank.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbank.ForeColor = System.Drawing.Color.DarkBlue
        Me.Tbank.Location = New System.Drawing.Point(57, 176)
        Me.Tbank.Name = "Tbank"
        Me.Tbank.Size = New System.Drawing.Size(171, 19)
        Me.Tbank.TabIndex = 0
        Me.Tbank.Text = "*SELECT YOUR BANK:"
        '
        'CbxBanklist
        '
        Me.CbxBanklist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxBanklist.FormattingEnabled = True
        Me.CbxBanklist.Location = New System.Drawing.Point(56, 200)
        Me.CbxBanklist.Name = "CbxBanklist"
        Me.CbxBanklist.Size = New System.Drawing.Size(292, 32)
        Me.CbxBanklist.TabIndex = 1
        '
        'Bnbsubmit
        '
        Me.Bnbsubmit.Location = New System.Drawing.Point(228, 350)
        Me.Bnbsubmit.Name = "Bnbsubmit"
        Me.Bnbsubmit.Size = New System.Drawing.Size(100, 39)
        Me.Bnbsubmit.TabIndex = 11
        Me.Bnbsubmit.Text = "Clear"
        Me.Bnbsubmit.UseVisualStyleBackColor = True
        '
        'Bnbcancle
        '
        Me.Bnbcancle.Location = New System.Drawing.Point(84, 350)
        Me.Bnbcancle.Name = "Bnbcancle"
        Me.Bnbcancle.Size = New System.Drawing.Size(100, 39)
        Me.Bnbcancle.TabIndex = 10
        Me.Bnbcancle.Text = "Submit"
        Me.Bnbcancle.UseVisualStyleBackColor = True
        '
        'Pnbtransi
        '
        Me.Pnbtransi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Pnbtransi.Controls.Add(Me.PictureBox4)
        Me.Pnbtransi.Location = New System.Drawing.Point(414, 69)
        Me.Pnbtransi.Name = "Pnbtransi"
        Me.Pnbtransi.Size = New System.Drawing.Size(375, 318)
        Me.Pnbtransi.TabIndex = 9
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Pwallet
        '
        Me.Pwallet.BackgroundImage = CType(resources.GetObject("Pwallet.BackgroundImage"), System.Drawing.Image)
        Me.Pwallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pwallet.Controls.Add(Me.PictureBox7)
        Me.Pwallet.Controls.Add(Me.PictureBox6)
        Me.Pwallet.Controls.Add(Me.Ltbanner)
        Me.Pwallet.Controls.Add(Me.Lwtitle)
        Me.Pwallet.Controls.Add(Me.Cb1)
        Me.Pwallet.Controls.Add(Me.Cb2)
        Me.Pwallet.Controls.Add(Me.Lwinfo)
        Me.Pwallet.Controls.Add(Me.Bwsubmit)
        Me.Pwallet.Controls.Add(Me.Bwcancle)
        Me.Pwallet.Controls.Add(Me.Pwpanel)
        Me.Pwallet.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pwallet.GradientBottomRight = System.Drawing.Color.AliceBlue
        Me.Pwallet.GradientTopLeft = System.Drawing.SystemColors.WindowFrame
        Me.Pwallet.GradientTopRight = System.Drawing.Color.Yellow
        Me.Pwallet.Location = New System.Drawing.Point(81, 113)
        Me.Pwallet.Name = "Pwallet"
        Me.Pwallet.Quality = 10
        Me.Pwallet.Size = New System.Drawing.Size(830, 425)
        Me.Pwallet.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(246, 169)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(143, 62)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(56, 173)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(143, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'Ltbanner
        '
        Me.Ltbanner.AutoSize = True
        Me.Ltbanner.BackColor = System.Drawing.Color.Transparent
        Me.Ltbanner.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltbanner.ForeColor = System.Drawing.Color.Yellow
        Me.Ltbanner.Location = New System.Drawing.Point(348, 12)
        Me.Ltbanner.Name = "Ltbanner"
        Me.Ltbanner.Size = New System.Drawing.Size(135, 29)
        Me.Ltbanner.TabIndex = 0
        Me.Ltbanner.Text = "WALLET"
        '
        'Lwtitle
        '
        Me.Lwtitle.AutoSize = True
        Me.Lwtitle.BackColor = System.Drawing.Color.Transparent
        Me.Lwtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lwtitle.Location = New System.Drawing.Point(23, 121)
        Me.Lwtitle.Name = "Lwtitle"
        Me.Lwtitle.Size = New System.Drawing.Size(244, 24)
        Me.Lwtitle.TabIndex = 0
        Me.Lwtitle.Text = "Pay using your digital wallet."
        '
        'Cb1
        '
        Me.Cb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb1.Checked = False
        Me.Cb1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Cb1.ForeColor = System.Drawing.Color.White
        Me.Cb1.Location = New System.Drawing.Point(212, 195)
        Me.Cb1.Name = "Cb1"
        Me.Cb1.Size = New System.Drawing.Size(20, 20)
        Me.Cb1.TabIndex = 1
        '
        'Cb2
        '
        Me.Cb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb2.Checked = False
        Me.Cb2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Cb2.ForeColor = System.Drawing.Color.White
        Me.Cb2.Location = New System.Drawing.Point(26, 195)
        Me.Cb2.Name = "Cb2"
        Me.Cb2.Size = New System.Drawing.Size(20, 20)
        Me.Cb2.TabIndex = 1
        '
        'Lwinfo
        '
        Me.Lwinfo.AutoSize = True
        Me.Lwinfo.BackColor = System.Drawing.Color.Transparent
        Me.Lwinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwinfo.ForeColor = System.Drawing.Color.Cornsilk
        Me.Lwinfo.Location = New System.Drawing.Point(24, 269)
        Me.Lwinfo.Name = "Lwinfo"
        Me.Lwinfo.Size = New System.Drawing.Size(317, 26)
        Me.Lwinfo.TabIndex = 0
        Me.Lwinfo.Text = "Note : On clicking arrow icon you will be redirected to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paytm payment gateway t" & _
    "o complete the transaction"
        '
        'Bwsubmit
        '
        Me.Bwsubmit.Location = New System.Drawing.Point(67, 353)
        Me.Bwsubmit.Name = "Bwsubmit"
        Me.Bwsubmit.Size = New System.Drawing.Size(100, 39)
        Me.Bwsubmit.TabIndex = 12
        Me.Bwsubmit.Text = "Submit"
        Me.Bwsubmit.UseVisualStyleBackColor = True
        '
        'Bwcancle
        '
        Me.Bwcancle.Location = New System.Drawing.Point(228, 353)
        Me.Bwcancle.Name = "Bwcancle"
        Me.Bwcancle.Size = New System.Drawing.Size(100, 39)
        Me.Bwcancle.TabIndex = 11
        Me.Bwcancle.Text = "Clear"
        Me.Bwcancle.UseVisualStyleBackColor = True
        '
        'Pwpanel
        '
        Me.Pwpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Pwpanel.Controls.Add(Me.PictureBox5)
        Me.Pwpanel.Location = New System.Drawing.Point(417, 74)
        Me.Pwpanel.Name = "Pwpanel"
        Me.Pwpanel.Size = New System.Drawing.Size(375, 318)
        Me.Pwpanel.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'Pvoucher
        '
        Me.Pvoucher.BackgroundImage = CType(resources.GetObject("Pvoucher.BackgroundImage"), System.Drawing.Image)
        Me.Pvoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pvoucher.Controls.Add(Me.Lvtitle)
        Me.Pvoucher.Controls.Add(Me.Lvtype)
        Me.Pvoucher.Controls.Add(Me.Cbxvinput)
        Me.Pvoucher.Controls.Add(Me.Lvvouch)
        Me.Pvoucher.Controls.Add(Me.Tvinput)
        Me.Pvoucher.Controls.Add(Me.Bvsubmit)
        Me.Pvoucher.Controls.Add(Me.Bvclear)
        Me.Pvoucher.Controls.Add(Me.Pvtrans)
        Me.Pvoucher.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaption
        Me.Pvoucher.GradientBottomRight = System.Drawing.Color.AntiqueWhite
        Me.Pvoucher.GradientTopLeft = System.Drawing.Color.YellowGreen
        Me.Pvoucher.GradientTopRight = System.Drawing.SystemColors.WindowFrame
        Me.Pvoucher.Location = New System.Drawing.Point(81, 113)
        Me.Pvoucher.Name = "Pvoucher"
        Me.Pvoucher.Quality = 10
        Me.Pvoucher.Size = New System.Drawing.Size(830, 425)
        Me.Pvoucher.TabIndex = 4
        '
        'Lvtitle
        '
        Me.Lvtitle.AutoSize = True
        Me.Lvtitle.BackColor = System.Drawing.Color.Transparent
        Me.Lvtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvtitle.ForeColor = System.Drawing.Color.FloralWhite
        Me.Lvtitle.Location = New System.Drawing.Point(214, 19)
        Me.Lvtitle.Name = "Lvtitle"
        Me.Lvtitle.Size = New System.Drawing.Size(402, 18)
        Me.Lvtitle.TabIndex = 0
        Me.Lvtitle.Text = "Use your voucher code to avail discount for booking"
        '
        'Lvtype
        '
        Me.Lvtype.AutoSize = True
        Me.Lvtype.BackColor = System.Drawing.Color.Transparent
        Me.Lvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvtype.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lvtype.Location = New System.Drawing.Point(51, 119)
        Me.Lvtype.Name = "Lvtype"
        Me.Lvtype.Size = New System.Drawing.Size(131, 17)
        Me.Lvtype.TabIndex = 0
        Me.Lvtype.Text = "PAYMENT TYPE:"
        '
        'Cbxvinput
        '
        Me.Cbxvinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxvinput.FormattingEnabled = True
        Me.Cbxvinput.Location = New System.Drawing.Point(51, 140)
        Me.Cbxvinput.Name = "Cbxvinput"
        Me.Cbxvinput.Size = New System.Drawing.Size(266, 32)
        Me.Cbxvinput.TabIndex = 1
        '
        'Lvvouch
        '
        Me.Lvvouch.AutoSize = True
        Me.Lvvouch.BackColor = System.Drawing.Color.Transparent
        Me.Lvvouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvvouch.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lvvouch.Location = New System.Drawing.Point(51, 215)
        Me.Lvvouch.Name = "Lvvouch"
        Me.Lvvouch.Size = New System.Drawing.Size(164, 17)
        Me.Lvvouch.TabIndex = 0
        Me.Lvvouch.Text = "*VOUCHER NUMBER:"
        '
        'Tvinput
        '
        Me.Tvinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tvinput.Location = New System.Drawing.Point(51, 237)
        Me.Tvinput.Name = "Tvinput"
        Me.Tvinput.Size = New System.Drawing.Size(266, 29)
        Me.Tvinput.TabIndex = 2
        '
        'Bvsubmit
        '
        Me.Bvsubmit.Location = New System.Drawing.Point(65, 351)
        Me.Bvsubmit.Name = "Bvsubmit"
        Me.Bvsubmit.Size = New System.Drawing.Size(100, 39)
        Me.Bvsubmit.TabIndex = 6
        Me.Bvsubmit.Text = "Submit"
        Me.Bvsubmit.UseVisualStyleBackColor = True
        '
        'Bvclear
        '
        Me.Bvclear.Location = New System.Drawing.Point(203, 351)
        Me.Bvclear.Name = "Bvclear"
        Me.Bvclear.Size = New System.Drawing.Size(100, 39)
        Me.Bvclear.TabIndex = 7
        Me.Bvclear.Text = "Clear"
        Me.Bvclear.UseVisualStyleBackColor = True
        '
        'Pvtrans
        '
        Me.Pvtrans.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Pvtrans.Controls.Add(Me.PictureBox3)
        Me.Pvtrans.Location = New System.Drawing.Point(420, 71)
        Me.Pvtrans.Name = "Pvtrans"
        Me.Pvtrans.Size = New System.Drawing.Size(375, 318)
        Me.Pvtrans.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PayExit
        '
        Me.PayExit.ActiveBorderThickness = 1
        Me.PayExit.ActiveCornerRadius = 20
        Me.PayExit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.PayExit.ActiveForecolor = System.Drawing.Color.White
        Me.PayExit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.PayExit.BackColor = System.Drawing.SystemColors.Control
        Me.PayExit.BackgroundImage = CType(resources.GetObject("PayExit.BackgroundImage"), System.Drawing.Image)
        Me.PayExit.ButtonText = "Exit"
        Me.PayExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayExit.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayExit.ForeColor = System.Drawing.Color.Moccasin
        Me.PayExit.IdleBorderThickness = 1
        Me.PayExit.IdleCornerRadius = 20
        Me.PayExit.IdleFillColor = System.Drawing.Color.Red
        Me.PayExit.IdleForecolor = System.Drawing.Color.Honeydew
        Me.PayExit.IdleLineColor = System.Drawing.Color.Red
        Me.PayExit.Location = New System.Drawing.Point(778, 571)
        Me.PayExit.Margin = New System.Windows.Forms.Padding(5)
        Me.PayExit.Name = "PayExit"
        Me.PayExit.Size = New System.Drawing.Size(156, 41)
        Me.PayExit.TabIndex = 1
        Me.PayExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PTitle
        '
        Me.PTitle.Controls.Add(Me.PictureBox8)
        Me.PTitle.Controls.Add(Me.Label1)
        Me.PTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitle.Location = New System.Drawing.Point(0, 0)
        Me.PTitle.Name = "PTitle"
        Me.PTitle.Size = New System.Drawing.Size(1366, 37)
        Me.PTitle.TabIndex = 5
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.AirlineReservationSystem.My.Resources.Resources._827312_airport_512x512
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Airline Reservation System"
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PMenu.Controls.Add(Me.Label2)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PMenu.Location = New System.Drawing.Point(0, 37)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(1366, 80)
        Me.PMenu.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Payment Potal"
        '
        'PSmenu
        '
        Me.PSmenu.Controls.Add(Me.CCDCButton)
        Me.PSmenu.Controls.Add(Me.WalletButton)
        Me.PSmenu.Controls.Add(Me.VoutureButton)
        Me.PSmenu.Controls.Add(Me.IBButton)
        Me.PSmenu.Controls.Add(Me.UPIButon)
        Me.PSmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PSmenu.Location = New System.Drawing.Point(0, 117)
        Me.PSmenu.Name = "PSmenu"
        Me.PSmenu.Size = New System.Drawing.Size(374, 651)
        Me.PSmenu.TabIndex = 5
        '
        'PDetails
        '
        Me.PDetails.Controls.Add(Me.Pwelcome)
        Me.PDetails.Controls.Add(Me.Pcomplite)
        Me.PDetails.Controls.Add(Me.Pwallet)
        Me.PDetails.Controls.Add(Me.Pvoucher)
        Me.PDetails.Controls.Add(Me.Pupi)
        Me.PDetails.Controls.Add(Me.PCreditCard)
        Me.PDetails.Controls.Add(Me.Pnetbanking)
        Me.PDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDetails.Location = New System.Drawing.Point(374, 117)
        Me.PDetails.Name = "PDetails"
        Me.PDetails.Size = New System.Drawing.Size(992, 651)
        Me.PDetails.TabIndex = 5
        '
        'Pwelcome
        '
        Me.Pwelcome.Controls.Add(Me.Lwelmsg)
        Me.Pwelcome.Location = New System.Drawing.Point(81, 113)
        Me.Pwelcome.Name = "Pwelcome"
        Me.Pwelcome.Size = New System.Drawing.Size(830, 425)
        Me.Pwelcome.TabIndex = 4
        '
        'Lwelmsg
        '
        Me.Lwelmsg.AutoSize = True
        Me.Lwelmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwelmsg.Location = New System.Drawing.Point(179, 197)
        Me.Lwelmsg.Name = "Lwelmsg"
        Me.Lwelmsg.Size = New System.Drawing.Size(472, 31)
        Me.Lwelmsg.TabIndex = 0
        Me.Lwelmsg.Text = "Choose any One Payment methods"
        '
        'Pcomplite
        '
        Me.Pcomplite.Controls.Add(Me.Printbox)
        Me.Pcomplite.Controls.Add(Me.LtransMsg)
        Me.Pcomplite.Controls.Add(Me.Bsave)
        Me.Pcomplite.Controls.Add(Me.Bprint)
        Me.Pcomplite.Controls.Add(Me.BPprivew)
        Me.Pcomplite.Controls.Add(Me.BHome)
        Me.Pcomplite.Controls.Add(Me.PayExit)
        Me.Pcomplite.Location = New System.Drawing.Point(0, 0)
        Me.Pcomplite.Name = "Pcomplite"
        Me.Pcomplite.Size = New System.Drawing.Size(992, 665)
        Me.Pcomplite.TabIndex = 3
        '
        'Printbox
        '
        Me.Printbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Printbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Printbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Printbox.Location = New System.Drawing.Point(106, 70)
        Me.Printbox.Multiline = True
        Me.Printbox.Name = "Printbox"
        Me.Printbox.ReadOnly = True
        Me.Printbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Printbox.Size = New System.Drawing.Size(780, 455)
        Me.Printbox.TabIndex = 2
        '
        'LtransMsg
        '
        Me.LtransMsg.AutoSize = True
        Me.LtransMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtransMsg.Location = New System.Drawing.Point(324, 14)
        Me.LtransMsg.Name = "LtransMsg"
        Me.LtransMsg.Size = New System.Drawing.Size(345, 31)
        Me.LtransMsg.TabIndex = 1
        Me.LtransMsg.Text = "Your Transiction complite"
        '
        'Bsave
        '
        Me.Bsave.ActiveBorderThickness = 1
        Me.Bsave.ActiveCornerRadius = 20
        Me.Bsave.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Bsave.ActiveForecolor = System.Drawing.Color.White
        Me.Bsave.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Bsave.BackColor = System.Drawing.SystemColors.Control
        Me.Bsave.BackgroundImage = CType(resources.GetObject("Bsave.BackgroundImage"), System.Drawing.Image)
        Me.Bsave.ButtonText = "Save"
        Me.Bsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bsave.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.Color.Chartreuse
        Me.Bsave.IdleBorderThickness = 1
        Me.Bsave.IdleCornerRadius = 20
        Me.Bsave.IdleFillColor = System.Drawing.Color.DarkSlateGray
        Me.Bsave.IdleForecolor = System.Drawing.Color.Chartreuse
        Me.Bsave.IdleLineColor = System.Drawing.Color.DarkSlateGray
        Me.Bsave.Location = New System.Drawing.Point(58, 571)
        Me.Bsave.Margin = New System.Windows.Forms.Padding(5)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(156, 41)
        Me.Bsave.TabIndex = 1
        Me.Bsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bprint
        '
        Me.Bprint.ActiveBorderThickness = 1
        Me.Bprint.ActiveCornerRadius = 20
        Me.Bprint.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Bprint.ActiveForecolor = System.Drawing.Color.White
        Me.Bprint.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Bprint.BackColor = System.Drawing.SystemColors.Control
        Me.Bprint.BackgroundImage = CType(resources.GetObject("Bprint.BackgroundImage"), System.Drawing.Image)
        Me.Bprint.ButtonText = "Print"
        Me.Bprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bprint.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bprint.ForeColor = System.Drawing.Color.Chartreuse
        Me.Bprint.IdleBorderThickness = 1
        Me.Bprint.IdleCornerRadius = 20
        Me.Bprint.IdleFillColor = System.Drawing.Color.DarkSlateGray
        Me.Bprint.IdleForecolor = System.Drawing.Color.LawnGreen
        Me.Bprint.IdleLineColor = System.Drawing.Color.DarkSlateGray
        Me.Bprint.Location = New System.Drawing.Point(238, 571)
        Me.Bprint.Margin = New System.Windows.Forms.Padding(5)
        Me.Bprint.Name = "Bprint"
        Me.Bprint.Size = New System.Drawing.Size(156, 41)
        Me.Bprint.TabIndex = 1
        Me.Bprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BPprivew
        '
        Me.BPprivew.ActiveBorderThickness = 1
        Me.BPprivew.ActiveCornerRadius = 20
        Me.BPprivew.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BPprivew.ActiveForecolor = System.Drawing.Color.White
        Me.BPprivew.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BPprivew.BackColor = System.Drawing.SystemColors.Control
        Me.BPprivew.BackgroundImage = CType(resources.GetObject("BPprivew.BackgroundImage"), System.Drawing.Image)
        Me.BPprivew.ButtonText = "Print Preview"
        Me.BPprivew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BPprivew.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPprivew.ForeColor = System.Drawing.Color.Chartreuse
        Me.BPprivew.IdleBorderThickness = 1
        Me.BPprivew.IdleCornerRadius = 20
        Me.BPprivew.IdleFillColor = System.Drawing.Color.DarkSlateGray
        Me.BPprivew.IdleForecolor = System.Drawing.Color.Chartreuse
        Me.BPprivew.IdleLineColor = System.Drawing.Color.DarkSlateGray
        Me.BPprivew.Location = New System.Drawing.Point(418, 571)
        Me.BPprivew.Margin = New System.Windows.Forms.Padding(5)
        Me.BPprivew.Name = "BPprivew"
        Me.BPprivew.Size = New System.Drawing.Size(156, 41)
        Me.BPprivew.TabIndex = 1
        Me.BPprivew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BHome
        '
        Me.BHome.ActiveBorderThickness = 1
        Me.BHome.ActiveCornerRadius = 20
        Me.BHome.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BHome.ActiveForecolor = System.Drawing.Color.White
        Me.BHome.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BHome.BackColor = System.Drawing.SystemColors.Control
        Me.BHome.BackgroundImage = CType(resources.GetObject("BHome.BackgroundImage"), System.Drawing.Image)
        Me.BHome.ButtonText = "Home"
        Me.BHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BHome.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHome.ForeColor = System.Drawing.Color.GreenYellow
        Me.BHome.IdleBorderThickness = 1
        Me.BHome.IdleCornerRadius = 20
        Me.BHome.IdleFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BHome.IdleForecolor = System.Drawing.Color.White
        Me.BHome.IdleLineColor = System.Drawing.Color.Aqua
        Me.BHome.Location = New System.Drawing.Point(598, 571)
        Me.BHome.Margin = New System.Windows.Forms.Padding(5)
        Me.BHome.Name = "BHome"
        Me.BHome.Size = New System.Drawing.Size(156, 41)
        Me.BHome.TabIndex = 1
        Me.BHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'PrintDocument1
        '
        '
        'PrintPreviewd
        '
        Me.PrintPreviewd.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewd.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewd.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewd.Document = Me.PrintDocument1
        Me.PrintPreviewd.Enabled = True
        Me.PrintPreviewd.Icon = CType(resources.GetObject("PrintPreviewd.Icon"), System.Drawing.Icon)
        Me.PrintPreviewd.Name = "PrintPreviewd"
        Me.PrintPreviewd.Visible = False
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PDetails)
        Me.Controls.Add(Me.PSmenu)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.PTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payment"
        Me.PCreditCard.ResumeLayout(False)
        Me.PCreditCard.PerformLayout()
        Me.Ppaydetails.ResumeLayout(False)
        Me.Ppaydetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pupi.ResumeLayout(False)
        Me.Pupi.PerformLayout()
        Me.pupitrans.ResumeLayout(False)
        Me.pupitrans.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnetbanking.ResumeLayout(False)
        Me.Pnetbanking.PerformLayout()
        Me.Pnbtransi.ResumeLayout(False)
        Me.Pnbtransi.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pwallet.ResumeLayout(False)
        Me.Pwallet.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pwpanel.ResumeLayout(False)
        Me.Pwpanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pvoucher.ResumeLayout(False)
        Me.Pvoucher.PerformLayout()
        Me.Pvtrans.ResumeLayout(False)
        Me.Pvtrans.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTitle.ResumeLayout(False)
        Me.PTitle.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMenu.ResumeLayout(False)
        Me.PMenu.PerformLayout()
        Me.PSmenu.ResumeLayout(False)
        Me.PDetails.ResumeLayout(False)
        Me.Pwelcome.ResumeLayout(False)
        Me.Pwelcome.PerformLayout()
        Me.Pcomplite.ResumeLayout(False)
        Me.Pcomplite.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CCDCButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents IBButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents UPIButon As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents WalletButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents VoutureButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PCreditCard As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Tcardname As System.Windows.Forms.TextBox
    Friend WithEvents Tcvv As System.Windows.Forms.TextBox
    Friend WithEvents Tcardholder As System.Windows.Forms.TextBox
    Friend WithEvents CbxValid As System.Windows.Forms.ComboBox
    Friend WithEvents CbxValid2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbxCardname As System.Windows.Forms.ComboBox
    Friend WithEvents Lcvv As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lcard2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lvalid As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lcard As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lcaedtitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pupi As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Tupiinput As System.Windows.Forms.TextBox
    Friend WithEvents lupiinfo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lupititle As System.Windows.Forms.Label
    Friend WithEvents Pnetbanking As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents CbxBanklist As System.Windows.Forms.ComboBox
    Friend WithEvents Tbank As System.Windows.Forms.Label
    Friend WithEvents Lnbtitle As System.Windows.Forms.Label
    Friend WithEvents Pwallet As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Pvoucher As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Cbxvinput As System.Windows.Forms.ComboBox
    Friend WithEvents Lvvouch As System.Windows.Forms.Label
    Friend WithEvents Lvtype As System.Windows.Forms.Label
    Friend WithEvents Lvtitle As System.Windows.Forms.Label
    Friend WithEvents Cb1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lwinfo As System.Windows.Forms.Label
    Friend WithEvents Lwtitle As System.Windows.Forms.Label
    Friend WithEvents Ltbanner As System.Windows.Forms.Label
    Friend WithEvents Tvinput As System.Windows.Forms.TextBox
    Friend WithEvents PayExit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PTitle As System.Windows.Forms.Panel
    Friend WithEvents PMenu As System.Windows.Forms.Panel
    Friend WithEvents PSmenu As System.Windows.Forms.Panel
    Friend WithEvents PDetails As System.Windows.Forms.Panel
    Friend WithEvents Pcomplite As System.Windows.Forms.Panel
    Friend WithEvents Pwelcome As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LtransMsg As System.Windows.Forms.Label
    Friend WithEvents Lwelmsg As System.Windows.Forms.Label
    Friend WithEvents Bsubmit As System.Windows.Forms.Button
    Friend WithEvents Bclear As System.Windows.Forms.Button
    Friend WithEvents Ppaydetails As System.Windows.Forms.Panel
    Friend WithEvents Lcardholder As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Bupiubmit As System.Windows.Forms.Button
    Friend WithEvents Bupiclear As System.Windows.Forms.Button
    Friend WithEvents pupitrans As System.Windows.Forms.Panel
    Friend WithEvents Bvsubmit As System.Windows.Forms.Button
    Friend WithEvents Bvclear As System.Windows.Forms.Button
    Friend WithEvents Pnbtransi As System.Windows.Forms.Panel
    Friend WithEvents Pvtrans As System.Windows.Forms.Panel
    Friend WithEvents Bnbsubmit As System.Windows.Forms.Button
    Friend WithEvents Bnbcancle As System.Windows.Forms.Button
    Friend WithEvents Bwsubmit As System.Windows.Forms.Button
    Friend WithEvents Bwcancle As System.Windows.Forms.Button
    Friend WithEvents Pwpanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Bprint As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BPprivew As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BHome As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Printbox As System.Windows.Forms.TextBox
    Friend WithEvents Bsave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewd As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SaveFiled As System.Windows.Forms.SaveFileDialog

End Class
