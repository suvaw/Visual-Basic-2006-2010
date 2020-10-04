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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pcover = New System.Windows.Forms.Panel()
        Me.Plogin = New System.Windows.Forms.Panel()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.Banner = New System.Windows.Forms.Label()
        Me.Lusername = New System.Windows.Forms.Label()
        Me.Lpassword = New System.Windows.Forms.Label()
        Me.Tinput = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Tpassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Lwarning = New System.Windows.Forms.Label()
        Me.LForgetPassword = New System.Windows.Forms.Label()
        Me.Psignup = New System.Windows.Forms.Panel()
        Me.BSignup = New System.Windows.Forms.Button()
        Me.Banner1 = New System.Windows.Forms.Label()
        Me.Banner2 = New System.Windows.Forms.Label()
        Me.Notification = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Ptitle.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Plogin.SuspendLayout()
        Me.Psignup.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ptitle
        '
        Me.Ptitle.BackColor = System.Drawing.Color.SpringGreen
        Me.Ptitle.Controls.Add(Me.PictureBox2)
        Me.Ptitle.Controls.Add(Me.PictureBox1)
        Me.Ptitle.Controls.Add(Me.Label1)
        Me.Ptitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ptitle.Location = New System.Drawing.Point(0, 0)
        Me.Ptitle.Name = "Ptitle"
        Me.Ptitle.Size = New System.Drawing.Size(1366, 43)
        Me.Ptitle.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.AirlineReservationSystem.My.Resources.Resources.power_button_icon_22
        Me.PictureBox2.Location = New System.Drawing.Point(1323, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirlineReservationSystem.My.Resources.Resources.flight1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Airline Reservation System"
        '
        'Pcover
        '
        Me.Pcover.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Pcover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pcover.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pcover.Location = New System.Drawing.Point(0, 43)
        Me.Pcover.Name = "Pcover"
        Me.Pcover.Size = New System.Drawing.Size(1366, 183)
        Me.Pcover.TabIndex = 1
        '
        'Plogin
        '
        Me.Plogin.BackColor = System.Drawing.Color.Orange
        Me.Plogin.Controls.Add(Me.BLogin)
        Me.Plogin.Controls.Add(Me.Banner)
        Me.Plogin.Controls.Add(Me.Lusername)
        Me.Plogin.Controls.Add(Me.Lpassword)
        Me.Plogin.Controls.Add(Me.Tinput)
        Me.Plogin.Controls.Add(Me.Tpassword)
        Me.Plogin.Controls.Add(Me.Lwarning)
        Me.Plogin.Controls.Add(Me.LForgetPassword)
        Me.Plogin.Location = New System.Drawing.Point(73, 149)
        Me.Plogin.Name = "Plogin"
        Me.Plogin.Size = New System.Drawing.Size(1221, 239)
        Me.Plogin.TabIndex = 1
        '
        'BLogin
        '
        Me.BLogin.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.login_button_png_13
        Me.BLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BLogin.FlatAppearance.BorderSize = 0
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Location = New System.Drawing.Point(993, 96)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(188, 48)
        Me.BLogin.TabIndex = 5
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'Banner
        '
        Me.Banner.AutoSize = True
        Me.Banner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banner.Location = New System.Drawing.Point(34, 110)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(217, 37)
        Me.Banner.TabIndex = 0
        Me.Banner.Text = "Login/Signup"
        '
        'Lusername
        '
        Me.Lusername.AutoSize = True
        Me.Lusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lusername.Location = New System.Drawing.Point(289, 70)
        Me.Lusername.Name = "Lusername"
        Me.Lusername.Size = New System.Drawing.Size(115, 24)
        Me.Lusername.TabIndex = 3
        Me.Lusername.Text = "User Name :"
        '
        'Lpassword
        '
        Me.Lpassword.AutoSize = True
        Me.Lpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lpassword.Location = New System.Drawing.Point(646, 70)
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
        Me.Tinput.Location = New System.Drawing.Point(289, 98)
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
        Me.Tpassword.Location = New System.Drawing.Point(646, 98)
        Me.Tpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.Size = New System.Drawing.Size(319, 44)
        Me.Tpassword.TabIndex = 1
        Me.Tpassword.Text = "Enter Your Password"
        Me.Tpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Lwarning
        '
        Me.Lwarning.AutoSize = True
        Me.Lwarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwarning.Location = New System.Drawing.Point(295, 162)
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
        Me.LForgetPassword.Location = New System.Drawing.Point(653, 162)
        Me.LForgetPassword.Name = "LForgetPassword"
        Me.LForgetPassword.Size = New System.Drawing.Size(144, 20)
        Me.LForgetPassword.TabIndex = 4
        Me.LForgetPassword.Text = "Forget Password"
        '
        'Psignup
        '
        Me.Psignup.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Psignup.Controls.Add(Me.BSignup)
        Me.Psignup.Controls.Add(Me.Banner1)
        Me.Psignup.Controls.Add(Me.Banner2)
        Me.Psignup.Controls.Add(Me.Notification)
        Me.Psignup.Location = New System.Drawing.Point(73, 385)
        Me.Psignup.Name = "Psignup"
        Me.Psignup.Size = New System.Drawing.Size(1221, 156)
        Me.Psignup.TabIndex = 2
        '
        'BSignup
        '
        Me.BSignup.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.show_image
        Me.BSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BSignup.FlatAppearance.BorderSize = 0
        Me.BSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSignup.Location = New System.Drawing.Point(955, 39)
        Me.BSignup.Name = "BSignup"
        Me.BSignup.Size = New System.Drawing.Size(194, 79)
        Me.BSignup.TabIndex = 5
        Me.BSignup.UseVisualStyleBackColor = True
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
        Me.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Tpassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Tinput As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Banner As System.Windows.Forms.Label
    Friend WithEvents Banner2 As System.Windows.Forms.Label
    Friend WithEvents Notification As System.Windows.Forms.Label
    Friend WithEvents Banner1 As System.Windows.Forms.Label
    Friend WithEvents LForgetPassword As System.Windows.Forms.Label
    Friend WithEvents Lwarning As System.Windows.Forms.Label
    Friend WithEvents Lusername As System.Windows.Forms.Label
    Friend WithEvents Lpassword As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BLogin As System.Windows.Forms.Button
    Friend WithEvents BSignup As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
