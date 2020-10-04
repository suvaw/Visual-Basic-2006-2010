<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgetPassword))
        Me.Title = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lmeaage = New System.Windows.Forms.Label()
        Me.CarveWindows = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Error2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pform = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BOTP = New System.Windows.Forms.Button()
        Me.Tmobile = New System.Windows.Forms.TextBox()
        Me.Lnotice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tcountry = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Notice = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Error2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pform.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Lime
        Me.Title.Controls.Add(Me.PictureBox2)
        Me.Title.Controls.Add(Me.PictureBox1)
        Me.Title.Controls.Add(Me.Lmeaage)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(650, 44)
        Me.Title.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AirlineReservationSystem.My.Resources.Resources.power_button_icon_22
        Me.PictureBox2.Location = New System.Drawing.Point(599, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirlineReservationSystem.My.Resources.Resources._827312_airport_512x512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Lmeaage
        '
        Me.Lmeaage.AutoSize = True
        Me.Lmeaage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmeaage.Location = New System.Drawing.Point(214, 9)
        Me.Lmeaage.Name = "Lmeaage"
        Me.Lmeaage.Size = New System.Drawing.Size(223, 26)
        Me.Lmeaage.TabIndex = 0
        Me.Lmeaage.Text = "Password Recovery"
        '
        'CarveWindows
        '
        Me.CarveWindows.ElipseRadius = 20
        Me.CarveWindows.TargetControl = Me
        '
        'Error1
        '
        Me.Error1.ContainerControl = Me
        Me.Error1.Icon = CType(resources.GetObject("Error1.Icon"), System.Drawing.Icon)
        '
        'Error2
        '
        Me.Error2.ContainerControl = Me
        Me.Error2.Icon = CType(resources.GetObject("Error2.Icon"), System.Drawing.Icon)
        '
        'T1
        '
        Me.T1.Interval = 1000
        '
        'Pform
        '
        Me.Pform.BackgroundImage = CType(resources.GetObject("Pform.BackgroundImage"), System.Drawing.Image)
        Me.Pform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pform.Controls.Add(Me.Button1)
        Me.Pform.Controls.Add(Me.BOTP)
        Me.Pform.Controls.Add(Me.Tmobile)
        Me.Pform.Controls.Add(Me.Lnotice)
        Me.Pform.Controls.Add(Me.Tcountry)
        Me.Pform.GradientBottomLeft = System.Drawing.Color.Navy
        Me.Pform.GradientBottomRight = System.Drawing.Color.Pink
        Me.Pform.GradientTopLeft = System.Drawing.Color.White
        Me.Pform.GradientTopRight = System.Drawing.Color.White
        Me.Pform.Location = New System.Drawing.Point(87, 168)
        Me.Pform.Name = "Pform"
        Me.Pform.Quality = 10
        Me.Pform.Size = New System.Drawing.Size(477, 254)
        Me.Pform.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.orange_rectangle_button_hi
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BOTP
        '
        Me.BOTP.AutoEllipsis = True
        Me.BOTP.BackColor = System.Drawing.Color.Transparent
        Me.BOTP.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.orange_rectangle_button_hi1
        Me.BOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BOTP.FlatAppearance.BorderSize = 0
        Me.BOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOTP.Location = New System.Drawing.Point(60, 169)
        Me.BOTP.Margin = New System.Windows.Forms.Padding(0)
        Me.BOTP.Name = "BOTP"
        Me.BOTP.Size = New System.Drawing.Size(165, 48)
        Me.BOTP.TabIndex = 5
        Me.BOTP.Text = "Sent OTP"
        Me.BOTP.UseVisualStyleBackColor = False
        '
        'Tmobile
        '
        Me.Tmobile.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmobile.Location = New System.Drawing.Point(167, 98)
        Me.Tmobile.Name = "Tmobile"
        Me.Tmobile.Size = New System.Drawing.Size(235, 41)
        Me.Tmobile.TabIndex = 4
        Me.Tmobile.Text = "Mobile Number"
        '
        'Lnotice
        '
        Me.Lnotice.AutoSize = True
        Me.Lnotice.BackColor = System.Drawing.Color.Transparent
        Me.Lnotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lnotice.Location = New System.Drawing.Point(33, 35)
        Me.Lnotice.Name = "Lnotice"
        Me.Lnotice.Size = New System.Drawing.Size(260, 20)
        Me.Lnotice.TabIndex = 0
        Me.Lnotice.Text = "Enter Your Register Mobile Number"
        '
        'Tcountry
        '
        Me.Tcountry.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Tcountry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Tcountry.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tcountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tcountry.HintForeColor = System.Drawing.Color.Empty
        Me.Tcountry.HintText = ""
        Me.Tcountry.isPassword = False
        Me.Tcountry.LineFocusedColor = System.Drawing.Color.Blue
        Me.Tcountry.LineIdleColor = System.Drawing.Color.Gray
        Me.Tcountry.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Tcountry.LineThickness = 4
        Me.Tcountry.Location = New System.Drawing.Point(77, 98)
        Me.Tcountry.Margin = New System.Windows.Forms.Padding(4)
        Me.Tcountry.Name = "Tcountry"
        Me.Tcountry.Size = New System.Drawing.Size(68, 38)
        Me.Tcountry.TabIndex = 3
        Me.Tcountry.Text = "+91"
        Me.Tcountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Notice
        '
        Me.Notice.AutoSize = True
        Me.Notice.BackColor = System.Drawing.Color.Transparent
        Me.Notice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Notice.Location = New System.Drawing.Point(26, 43)
        Me.Notice.Name = "Notice"
        Me.Notice.Size = New System.Drawing.Size(323, 24)
        Me.Notice.TabIndex = 0
        Me.Notice.Text = "Hi user, Recovery Your Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Notice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 216)
        Me.Panel1.TabIndex = 2
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 454)
        Me.Controls.Add(Me.Pform)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgetPassword"
        Me.Text = "Recovery"
        Me.TopMost = True
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Error2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pform.ResumeLayout(False)
        Me.Pform.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pform As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Lnotice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Tcountry As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents CarveWindows As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Notice As System.Windows.Forms.Label
    Friend WithEvents Lmeaage As System.Windows.Forms.Label
    Friend WithEvents Tmobile As System.Windows.Forms.TextBox
    Friend WithEvents Error1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Error2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents BOTP As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
