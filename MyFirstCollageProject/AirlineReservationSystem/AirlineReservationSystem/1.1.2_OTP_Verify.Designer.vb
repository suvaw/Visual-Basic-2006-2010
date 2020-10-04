<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTP_Verify
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
        Me.Ptitle = New System.Windows.Forms.Panel()
        Me.LTitle = New System.Windows.Forms.Label()
        Me.PBanner = New System.Windows.Forms.Panel()
        Me.LBanner = New System.Windows.Forms.Label()
        Me.PDesign = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lmassage = New System.Windows.Forms.Label()
        Me.i1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.i2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.i3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.i4 = New System.Windows.Forms.TextBox()
        Me.Breset = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Bverify = New System.Windows.Forms.Button()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ptitle.SuspendLayout()
        Me.PBanner.SuspendLayout()
        Me.PDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ptitle
        '
        Me.Ptitle.Controls.Add(Me.LTitle)
        Me.Ptitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ptitle.Location = New System.Drawing.Point(0, 0)
        Me.Ptitle.Name = "Ptitle"
        Me.Ptitle.Size = New System.Drawing.Size(673, 56)
        Me.Ptitle.TabIndex = 0
        '
        'LTitle
        '
        Me.LTitle.AutoSize = True
        Me.LTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitle.Location = New System.Drawing.Point(12, 16)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(146, 24)
        Me.LTitle.TabIndex = 0
        Me.LTitle.Text = "OTP Verification"
        '
        'PBanner
        '
        Me.PBanner.BackColor = System.Drawing.Color.DarkRed
        Me.PBanner.Controls.Add(Me.LBanner)
        Me.PBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.PBanner.Location = New System.Drawing.Point(0, 56)
        Me.PBanner.Name = "PBanner"
        Me.PBanner.Size = New System.Drawing.Size(673, 209)
        Me.PBanner.TabIndex = 0
        '
        'LBanner
        '
        Me.LBanner.AutoSize = True
        Me.LBanner.Location = New System.Drawing.Point(81, 43)
        Me.LBanner.Name = "LBanner"
        Me.LBanner.Size = New System.Drawing.Size(39, 13)
        Me.LBanner.TabIndex = 0
        Me.LBanner.Text = "Label1"
        '
        'PDesign
        '
        Me.PDesign.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PDesign.Controls.Add(Me.ProgressBar1)
        Me.PDesign.Controls.Add(Me.Lmassage)
        Me.PDesign.Controls.Add(Me.i1)
        Me.PDesign.Controls.Add(Me.Label2)
        Me.PDesign.Controls.Add(Me.i2)
        Me.PDesign.Controls.Add(Me.Label3)
        Me.PDesign.Controls.Add(Me.i3)
        Me.PDesign.Controls.Add(Me.Label4)
        Me.PDesign.Controls.Add(Me.i4)
        Me.PDesign.Controls.Add(Me.Breset)
        Me.PDesign.Controls.Add(Me.Bverify)
        Me.PDesign.Location = New System.Drawing.Point(87, 171)
        Me.PDesign.Name = "PDesign"
        Me.PDesign.Size = New System.Drawing.Size(499, 237)
        Me.PDesign.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 135)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(435, 11)
        Me.ProgressBar1.TabIndex = 5
        '
        'Lmassage
        '
        Me.Lmassage.AutoSize = True
        Me.Lmassage.Location = New System.Drawing.Point(43, 34)
        Me.Lmassage.Name = "Lmassage"
        Me.Lmassage.Size = New System.Drawing.Size(39, 13)
        Me.Lmassage.TabIndex = 0
        Me.Lmassage.Text = "Label1"
        '
        'i1
        '
        Me.i1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i1.Location = New System.Drawing.Point(30, 79)
        Me.i1.MaxLength = 1
        Me.i1.Name = "i1"
        Me.i1.Size = New System.Drawing.Size(53, 38)
        Me.i1.TabIndex = 2
        Me.i1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "-"
        '
        'i2
        '
        Me.i2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i2.Location = New System.Drawing.Point(125, 79)
        Me.i2.MaxLength = 1
        Me.i2.Name = "i2"
        Me.i2.Size = New System.Drawing.Size(53, 38)
        Me.i2.TabIndex = 2
        Me.i2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "-"
        '
        'i3
        '
        Me.i3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i3.Location = New System.Drawing.Point(220, 79)
        Me.i3.MaxLength = 1
        Me.i3.Name = "i3"
        Me.i3.Size = New System.Drawing.Size(53, 38)
        Me.i3.TabIndex = 2
        Me.i3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "-"
        '
        'i4
        '
        Me.i4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i4.Location = New System.Drawing.Point(315, 79)
        Me.i4.MaxLength = 1
        Me.i4.Name = "i4"
        Me.i4.Size = New System.Drawing.Size(53, 38)
        Me.i4.TabIndex = 2
        Me.i4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Breset
        '
        Me.Breset.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Breset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Breset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Breset.BorderRadius = 0
        Me.Breset.ButtonText = "Re-Send"
        Me.Breset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Breset.DisabledColor = System.Drawing.Color.Gray
        Me.Breset.Iconcolor = System.Drawing.Color.Transparent
        Me.Breset.Iconimage = Nothing
        Me.Breset.Iconimage_right = Nothing
        Me.Breset.Iconimage_right_Selected = Nothing
        Me.Breset.Iconimage_Selected = Nothing
        Me.Breset.IconMarginLeft = 0
        Me.Breset.IconMarginRight = 0
        Me.Breset.IconRightVisible = True
        Me.Breset.IconRightZoom = 0.0R
        Me.Breset.IconVisible = True
        Me.Breset.IconZoom = 90.0R
        Me.Breset.IsTab = False
        Me.Breset.Location = New System.Drawing.Point(384, 79)
        Me.Breset.Name = "Breset"
        Me.Breset.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Breset.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Breset.OnHoverTextColor = System.Drawing.Color.White
        Me.Breset.selected = False
        Me.Breset.Size = New System.Drawing.Size(84, 38)
        Me.Breset.TabIndex = 3
        Me.Breset.Text = "Re-Send"
        Me.Breset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Breset.Textcolor = System.Drawing.Color.White
        Me.Breset.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Bverify
        '
        Me.Bverify.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bverify.Location = New System.Drawing.Point(179, 163)
        Me.Bverify.Name = "Bverify"
        Me.Bverify.Size = New System.Drawing.Size(140, 56)
        Me.Bverify.TabIndex = 4
        Me.Bverify.Text = "OTP Verify"
        Me.Bverify.UseVisualStyleBackColor = True
        '
        'T1
        '
        '
        'OTP_Verify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 448)
        Me.Controls.Add(Me.PDesign)
        Me.Controls.Add(Me.PBanner)
        Me.Controls.Add(Me.Ptitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OTP_Verify"
        Me.Text = "OTP_Verify"
        Me.Ptitle.ResumeLayout(False)
        Me.Ptitle.PerformLayout()
        Me.PBanner.ResumeLayout(False)
        Me.PBanner.PerformLayout()
        Me.PDesign.ResumeLayout(False)
        Me.PDesign.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ptitle As System.Windows.Forms.Panel
    Friend WithEvents LTitle As System.Windows.Forms.Label
    Friend WithEvents PBanner As System.Windows.Forms.Panel
    Friend WithEvents LBanner As System.Windows.Forms.Label
    Friend WithEvents PDesign As System.Windows.Forms.Panel
    Friend WithEvents Lmassage As System.Windows.Forms.Label
    Friend WithEvents i1 As System.Windows.Forms.TextBox
    Friend WithEvents Breset As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents i4 As System.Windows.Forms.TextBox
    Friend WithEvents i3 As System.Windows.Forms.TextBox
    Friend WithEvents i2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bverify As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
