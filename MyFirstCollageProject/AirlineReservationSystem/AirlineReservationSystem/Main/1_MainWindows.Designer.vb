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
        Me.DPR = New System.Windows.Forms.DateTimePicker()
        Me.DPD = New System.Windows.Forms.DateTimePicker()
        Me.PSmenu = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'DPR
        '
        Me.DPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPR.Location = New System.Drawing.Point(986, 99)
        Me.DPR.MaxDate = New Date(2018, 8, 31, 0, 0, 0, 0)
        Me.DPR.MinDate = New Date(2018, 4, 15, 0, 0, 0, 0)
        Me.DPR.Name = "DPR"
        Me.DPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPR.Size = New System.Drawing.Size(188, 44)
        Me.DPR.TabIndex = 12
        '
        'DPD
        '
        Me.DPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPD.Location = New System.Drawing.Point(777, 99)
        Me.DPD.Name = "DPD"
        Me.DPD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPD.Size = New System.Drawing.Size(188, 44)
        Me.DPD.TabIndex = 12
        '
        'PSmenu
        '
        Me.PSmenu.BackColor = System.Drawing.Color.DarkRed
        Me.PSmenu.Controls.Add(Me.Label5)
        Me.PSmenu.Controls.Add(Me.Label4)
        Me.PSmenu.Controls.Add(Me.Label3)
        Me.PSmenu.Controls.Add(Me.Label2)
        Me.PSmenu.Controls.Add(Me.Label1)
        Me.PSmenu.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PSmenu.Location = New System.Drawing.Point(0, 0)
        Me.PSmenu.Name = "PSmenu"
        Me.PSmenu.Size = New System.Drawing.Size(50, 244)
        Me.PSmenu.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "About         "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Notification "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Shedules   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Weather     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Book Flight"
        '
        'Cbxto
        '
        Me.Cbxto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxto.FormattingEnabled = True
        Me.Cbxto.Location = New System.Drawing.Point(357, 98)
        Me.Cbxto.Name = "Cbxto"
        Me.Cbxto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxto.Size = New System.Drawing.Size(267, 45)
        Me.Cbxto.TabIndex = 11
        Me.Cbxto.Text = "To"
        '
        'Cbxform
        '
        Me.Cbxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxform.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxform.FormattingEnabled = True
        Me.Cbxform.Location = New System.Drawing.Point(74, 98)
        Me.Cbxform.Name = "Cbxform"
        Me.Cbxform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxform.Size = New System.Drawing.Size(267, 45)
        Me.Cbxform.TabIndex = 11
        Me.Cbxform.Text = "Form"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(660, 99)
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
        Me.BSearch.Location = New System.Drawing.Point(1205, 97)
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
        'Timer1
        '
        Me.Timer1.Interval = 10
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
        Me.PSmenu.PerformLayout()
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
