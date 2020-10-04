<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Ptitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pcover = New System.Windows.Forms.Panel()
        Me.Plogin = New System.Windows.Forms.Panel()
        Me.Banner = New System.Windows.Forms.Label()
        Me.Lusername = New System.Windows.Forms.Label()
        Me.Lpassword = New System.Windows.Forms.Label()
        Me.Tinput = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Tpassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Lwarning = New System.Windows.Forms.Label()
        Me.LForgetPassword = New System.Windows.Forms.Label()
        Me.Psignup = New System.Windows.Forms.Panel()
        Me.Banner1 = New System.Windows.Forms.Label()
        Me.Banner2 = New System.Windows.Forms.Label()
        Me.Notification = New System.Windows.Forms.Label()
        Me.BSignup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Ptitle.SuspendLayout()
        Me.Plogin.SuspendLayout()
        Me.Psignup.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ptitle
        '
        Me.Ptitle.BackColor = System.Drawing.Color.DarkCyan
        Me.Ptitle.Controls.Add(Me.Label1)
        Me.Ptitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ptitle.Location = New System.Drawing.Point(0, 0)
        Me.Ptitle.Name = "Ptitle"
        Me.Ptitle.Size = New System.Drawing.Size(1366, 32)
        Me.Ptitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Airline Reservation System"
        '
        'Pcover
        '
        Me.Pcover.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Pcover.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pcover.Location = New System.Drawing.Point(0, 32)
        Me.Pcover.Name = "Pcover"
        Me.Pcover.Size = New System.Drawing.Size(1366, 183)
        Me.Pcover.TabIndex = 1
        '
        'Plogin
        '
        Me.Plogin.BackColor = System.Drawing.Color.Orange
        Me.Plogin.Controls.Add(Me.Banner)
        Me.Plogin.Controls.Add(Me.Lusername)
        Me.Plogin.Controls.Add(Me.Lpassword)
        Me.Plogin.Controls.Add(Me.Tinput)
        Me.Plogin.Controls.Add(Me.Tpassword)
        Me.Plogin.Controls.Add(Me.BLogin)
        Me.Plogin.Controls.Add(Me.Lwarning)
        Me.Plogin.Controls.Add(Me.LForgetPassword)
        Me.Plogin.Location = New System.Drawing.Point(73, 149)
        Me.Plogin.Name = "Plogin"
        Me.Plogin.Size = New System.Drawing.Size(1221, 239)
        Me.Plogin.TabIndex = 1
        '
        'Banner
        '
        Me.Banner.AutoSize = True
        Me.Banner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banner.Location = New System.Drawing.Point(57, 110)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(217, 37)
        Me.Banner.TabIndex = 0
        Me.Banner.Text = "Login/Signup"
        '
        'Lusername
        '
        Me.Lusername.AutoSize = True
        Me.Lusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lusername.Location = New System.Drawing.Point(334, 70)
        Me.Lusername.Name = "Lusername"
        Me.Lusername.Size = New System.Drawing.Size(115, 24)
        Me.Lusername.TabIndex = 3
        Me.Lusername.Text = "User Name :"
        '
        'Lpassword
        '
        Me.Lpassword.AutoSize = True
        Me.Lpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lpassword.Location = New System.Drawing.Point(691, 70)
        Me.Lpassword.Name = "Lpassword"
        Me.Lpassword.Size = New System.Drawing.Size(102, 24)
        Me.Lpassword.TabIndex = 3
        Me.Lpassword.Text = "Password :"
        '
        'Tinput
        '
        Me.Tinput.BorderColorFocused = System.Drawing.Color.Blue
        Me.Tinput.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tinput.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Tinput.BorderThickness = 3
        Me.Tinput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Tinput.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Tinput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tinput.isPassword = False
        Me.Tinput.Location = New System.Drawing.Point(334, 98)
        Me.Tinput.Margin = New System.Windows.Forms.Padding(4)
        Me.Tinput.Name = "Tinput"
        Me.Tinput.Size = New System.Drawing.Size(319, 44)
        Me.Tinput.TabIndex = 1
        Me.Tinput.Text = "Enter Your Register User Name"
        Me.Tinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Tpassword
        '
        Me.Tpassword.BorderColorFocused = System.Drawing.Color.Blue
        Me.Tpassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tpassword.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Tpassword.BorderThickness = 3
        Me.Tpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Tpassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Tpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tpassword.isPassword = False
        Me.Tpassword.Location = New System.Drawing.Point(691, 98)
        Me.Tpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.Size = New System.Drawing.Size(319, 44)
        Me.Tpassword.TabIndex = 1
        Me.Tpassword.Text = "Enter Your Password"
        Me.Tpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BLogin
        '
        Me.BLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BLogin.BorderRadius = 0
        Me.BLogin.ButtonText = "LOGIN"
        Me.BLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BLogin.DisabledColor = System.Drawing.Color.Gray
        Me.BLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.BLogin.Iconimage = Nothing
        Me.BLogin.Iconimage_right = Nothing
        Me.BLogin.Iconimage_right_Selected = Nothing
        Me.BLogin.Iconimage_Selected = Nothing
        Me.BLogin.IconMarginLeft = 0
        Me.BLogin.IconMarginRight = 0
        Me.BLogin.IconRightVisible = True
        Me.BLogin.IconRightZoom = 0.0R
        Me.BLogin.IconVisible = True
        Me.BLogin.IconZoom = 90.0R
        Me.BLogin.IsTab = False
        Me.BLogin.Location = New System.Drawing.Point(1050, 96)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.BLogin.selected = False
        Me.BLogin.Size = New System.Drawing.Size(112, 48)
        Me.BLogin.TabIndex = 2
        Me.BLogin.Text = "LOGIN"
        Me.BLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BLogin.Textcolor = System.Drawing.Color.White
        Me.BLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Lwarning
        '
        Me.Lwarning.AutoSize = True
        Me.Lwarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwarning.Location = New System.Drawing.Point(340, 162)
        Me.Lwarning.Name = "Lwarning"
        Me.Lwarning.Size = New System.Drawing.Size(54, 20)
        Me.Lwarning.TabIndex = 4
        Me.Lwarning.Text = "Notice"
        '
        'LForgetPassword
        '
        Me.LForgetPassword.AutoSize = True
        Me.LForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LForgetPassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LForgetPassword.Location = New System.Drawing.Point(698, 162)
        Me.LForgetPassword.Name = "LForgetPassword"
        Me.LForgetPassword.Size = New System.Drawing.Size(144, 20)
        Me.LForgetPassword.TabIndex = 4
        Me.LForgetPassword.Text = "Forget Password"
        '
        'Psignup
        '
        Me.Psignup.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Psignup.Controls.Add(Me.Banner1)
        Me.Psignup.Controls.Add(Me.Banner2)
        Me.Psignup.Controls.Add(Me.Notification)
        Me.Psignup.Controls.Add(Me.BSignup)
        Me.Psignup.Location = New System.Drawing.Point(73, 385)
        Me.Psignup.Name = "Psignup"
        Me.Psignup.Size = New System.Drawing.Size(1221, 156)
        Me.Psignup.TabIndex = 2
        '
        'Banner1
        '
        Me.Banner1.AutoSize = True
        Me.Banner1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banner1.Location = New System.Drawing.Point(66, 47)
        Me.Banner1.Name = "Banner1"
        Me.Banner1.Size = New System.Drawing.Size(219, 24)
        Me.Banner1.TabIndex = 0
        Me.Banner1.Text = "Not a Airline Member?"
        '
        'Banner2
        '
        Me.Banner2.AutoSize = True
        Me.Banner2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banner2.Location = New System.Drawing.Point(67, 72)
        Me.Banner2.Name = "Banner2"
        Me.Banner2.Size = New System.Drawing.Size(217, 37)
        Me.Banner2.TabIndex = 0
        Me.Banner2.Text = "Login/Signup"
        '
        'Notification
        '
        Me.Notification.AutoSize = True
        Me.Notification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notification.Location = New System.Drawing.Point(458, 60)
        Me.Notification.Name = "Notification"
        Me.Notification.Size = New System.Drawing.Size(304, 36)
        Me.Notification.TabIndex = 0
        Me.Notification.Text = "Became a Airline Member by registering now " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and enjoyexclusive benifits."
        '
        'BSignup
        '
        Me.BSignup.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BSignup.BorderRadius = 0
        Me.BSignup.ButtonText = "SIGN UP"
        Me.BSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSignup.DisabledColor = System.Drawing.Color.Gray
        Me.BSignup.Iconcolor = System.Drawing.Color.Transparent
        Me.BSignup.Iconimage = Nothing
        Me.BSignup.Iconimage_right = Nothing
        Me.BSignup.Iconimage_right_Selected = Nothing
        Me.BSignup.Iconimage_Selected = Nothing
        Me.BSignup.IconMarginLeft = 0
        Me.BSignup.IconMarginRight = 0
        Me.BSignup.IconRightVisible = True
        Me.BSignup.IconRightZoom = 0.0R
        Me.BSignup.IconVisible = True
        Me.BSignup.IconZoom = 90.0R
        Me.BSignup.IsTab = False
        Me.BSignup.Location = New System.Drawing.Point(1050, 54)
        Me.BSignup.Name = "BSignup"
        Me.BSignup.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSignup.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BSignup.OnHoverTextColor = System.Drawing.Color.White
        Me.BSignup.selected = False
        Me.BSignup.Size = New System.Drawing.Size(112, 48)
        Me.BSignup.TabIndex = 2
        Me.BSignup.Text = "SIGN UP"
        Me.BSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BSignup.Textcolor = System.Drawing.Color.White
        Me.BSignup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        Me.ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), System.Drawing.Icon)
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Psignup)
        Me.Controls.Add(Me.Plogin)
        Me.Controls.Add(Me.Pcover)
        Me.Controls.Add(Me.Ptitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Ptitle.ResumeLayout(False)
        Me.Ptitle.PerformLayout()
        Me.Plogin.ResumeLayout(False)
        Me.Plogin.PerformLayout()
        Me.Psignup.ResumeLayout(False)
        Me.Psignup.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ptitle As System.Windows.Forms.Panel
    Friend WithEvents Pcover As System.Windows.Forms.Panel
    Friend WithEvents Plogin As System.Windows.Forms.Panel
    Friend WithEvents Psignup As System.Windows.Forms.Panel
    Friend WithEvents BSignup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Tpassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Tinput As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Banner As System.Windows.Forms.Label
    Friend WithEvents Banner2 As System.Windows.Forms.Label
    Friend WithEvents Notification As System.Windows.Forms.Label
    Friend WithEvents Banner1 As System.Windows.Forms.Label
    Friend WithEvents BLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LForgetPassword As System.Windows.Forms.Label
    Friend WithEvents Lwarning As System.Windows.Forms.Label
    Friend WithEvents Lusername As System.Windows.Forms.Label
    Friend WithEvents Lpassword As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
End Class
