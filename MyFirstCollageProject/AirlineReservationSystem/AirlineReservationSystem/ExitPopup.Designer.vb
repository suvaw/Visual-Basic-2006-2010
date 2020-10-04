<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitPopup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bcancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Airline Reservation System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Bcancel)
        Me.Panel2.Controls.Add(Me.BExit)
        Me.Panel2.Location = New System.Drawing.Point(75, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 179)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Are You Sure?"
        '
        'Bcancel
        '
        Me.Bcancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bcancel.BorderRadius = 0
        Me.Bcancel.ButtonText = "Cancel"
        Me.Bcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bcancel.DisabledColor = System.Drawing.Color.Gray
        Me.Bcancel.Iconcolor = System.Drawing.Color.Transparent
        Me.Bcancel.Iconimage = Nothing
        Me.Bcancel.Iconimage_right = Nothing
        Me.Bcancel.Iconimage_right_Selected = Nothing
        Me.Bcancel.Iconimage_Selected = Nothing
        Me.Bcancel.IconMarginLeft = 0
        Me.Bcancel.IconMarginRight = 0
        Me.Bcancel.IconRightVisible = True
        Me.Bcancel.IconRightZoom = 0.0R
        Me.Bcancel.IconVisible = True
        Me.Bcancel.IconZoom = 90.0R
        Me.Bcancel.IsTab = False
        Me.Bcancel.Location = New System.Drawing.Point(243, 81)
        Me.Bcancel.Margin = New System.Windows.Forms.Padding(2)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Bcancel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Bcancel.OnHoverTextColor = System.Drawing.Color.White
        Me.Bcancel.selected = False
        Me.Bcancel.Size = New System.Drawing.Size(156, 69)
        Me.Bcancel.TabIndex = 0
        Me.Bcancel.Text = "Cancel"
        Me.Bcancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bcancel.Textcolor = System.Drawing.Color.White
        Me.Bcancel.TextFont = New System.Drawing.Font("Good Times", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BExit
        '
        Me.BExit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BExit.BorderRadius = 0
        Me.BExit.ButtonText = "Yes"
        Me.BExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BExit.DisabledColor = System.Drawing.Color.Gray
        Me.BExit.Iconcolor = System.Drawing.Color.Transparent
        Me.BExit.Iconimage = Nothing
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
        Me.BExit.Location = New System.Drawing.Point(35, 81)
        Me.BExit.Name = "BExit"
        Me.BExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BExit.OnHoverTextColor = System.Drawing.Color.White
        Me.BExit.selected = False
        Me.BExit.Size = New System.Drawing.Size(163, 69)
        Me.BExit.TabIndex = 0
        Me.BExit.Text = "Yes"
        Me.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BExit.Textcolor = System.Drawing.Color.White
        Me.BExit.TextFont = New System.Drawing.Font("Good Times", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 128)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "System is automatically logout." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exit this Application"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirlineReservationSystem.My.Resources.Resources._827312_airport_512x512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ExitPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(588, 342)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExitPopup"
        Me.Text = "ExitPopup"
        Me.TransparencyKey = System.Drawing.SystemColors.Info
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bcancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
