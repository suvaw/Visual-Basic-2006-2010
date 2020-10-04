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
        Me.Pform = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Tmobile = New System.Windows.Forms.TextBox()
        Me.Lnotice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tcountry = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Pcover = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Notice = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Panel()
        Me.Lmeaage = New System.Windows.Forms.Label()
        Me.CarveWindows = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Error2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.BOTP = New System.Windows.Forms.Button()
        Me.Pform.SuspendLayout()
        Me.Pcover.SuspendLayout()
        Me.Title.SuspendLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Error2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pform
        '
        Me.Pform.BackgroundImage = CType(resources.GetObject("Pform.BackgroundImage"), System.Drawing.Image)
        Me.Pform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pform.Controls.Add(Me.BOTP)
        Me.Pform.Controls.Add(Me.Tmobile)
        Me.Pform.Controls.Add(Me.Lnotice)
        Me.Pform.Controls.Add(Me.Tcountry)
        Me.Pform.GradientBottomLeft = System.Drawing.Color.Navy
        Me.Pform.GradientBottomRight = System.Drawing.Color.Pink
        Me.Pform.GradientTopLeft = System.Drawing.Color.White
        Me.Pform.GradientTopRight = System.Drawing.Color.White
        Me.Pform.Location = New System.Drawing.Point(87, 167)
        Me.Pform.Name = "Pform"
        Me.Pform.Quality = 10
        Me.Pform.Size = New System.Drawing.Size(477, 254)
        Me.Pform.TabIndex = 1
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
        'Pcover
        '
        Me.Pcover.BackgroundImage = CType(resources.GetObject("Pcover.BackgroundImage"), System.Drawing.Image)
        Me.Pcover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pcover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pcover.Controls.Add(Me.Notice)
        Me.Pcover.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pcover.GradientBottomLeft = System.Drawing.Color.Navy
        Me.Pcover.GradientBottomRight = System.Drawing.Color.Violet
        Me.Pcover.GradientTopLeft = System.Drawing.Color.Silver
        Me.Pcover.GradientTopRight = System.Drawing.Color.Gainsboro
        Me.Pcover.Location = New System.Drawing.Point(0, 44)
        Me.Pcover.Name = "Pcover"
        Me.Pcover.Quality = 10
        Me.Pcover.Size = New System.Drawing.Size(650, 177)
        Me.Pcover.TabIndex = 1
        '
        'Notice
        '
        Me.Notice.AutoSize = True
        Me.Notice.BackColor = System.Drawing.Color.Transparent
        Me.Notice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notice.Location = New System.Drawing.Point(12, 47)
        Me.Notice.Name = "Notice"
        Me.Notice.Size = New System.Drawing.Size(414, 24)
        Me.Notice.TabIndex = 0
        Me.Notice.Text = "Hi user, Enter Your Recovery Potal is Open"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Lime
        Me.Title.Controls.Add(Me.Lmeaage)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(650, 44)
        Me.Title.TabIndex = 0
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
        'BOTP
        '
        Me.BOTP.AutoEllipsis = True
        Me.BOTP.BackColor = System.Drawing.Color.ForestGreen
        Me.BOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOTP.Location = New System.Drawing.Point(128, 172)
        Me.BOTP.Margin = New System.Windows.Forms.Padding(0)
        Me.BOTP.Name = "BOTP"
        Me.BOTP.Size = New System.Drawing.Size(219, 48)
        Me.BOTP.TabIndex = 5
        Me.BOTP.Text = "Sent OTP"
        Me.BOTP.UseVisualStyleBackColor = False
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 454)
        Me.Controls.Add(Me.Pform)
        Me.Controls.Add(Me.Pcover)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgetPassword"
        Me.Text = "Recovery"
        Me.Pform.ResumeLayout(False)
        Me.Pform.PerformLayout()
        Me.Pcover.ResumeLayout(False)
        Me.Pcover.PerformLayout()
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Error2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pform As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Lnotice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Tcountry As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Pcover As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents CarveWindows As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Notice As System.Windows.Forms.Label
    Friend WithEvents Lmeaage As System.Windows.Forms.Label
    Friend WithEvents Tmobile As System.Windows.Forms.TextBox
    Friend WithEvents Error1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Error2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents BOTP As System.Windows.Forms.Button
End Class
