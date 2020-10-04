<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkin
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
        Me.P1 = New System.Windows.Forms.Panel()
        Me.ltitle = New System.Windows.Forms.Label()
        Me.Pmenu = New System.Windows.Forms.Panel()
        Me.Lref = New System.Windows.Forms.Label()
        Me.Tref = New System.Windows.Forms.TextBox()
        Me.Lemail = New System.Windows.Forms.Label()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Bcheck = New System.Windows.Forms.Button()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.Bclose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.P1.SuspendLayout()
        Me.Pmenu.SuspendLayout()
        Me.P2.SuspendLayout()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Gold
        Me.P1.Controls.Add(Me.ltitle)
        Me.P1.Controls.Add(Me.Pmenu)
        Me.P1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.P1.Location = New System.Drawing.Point(0, 0)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(1366, 244)
        Me.P1.TabIndex = 0
        '
        'ltitle
        '
        Me.ltitle.AutoSize = True
        Me.ltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.ltitle.Location = New System.Drawing.Point(601, 9)
        Me.ltitle.Name = "ltitle"
        Me.ltitle.Size = New System.Drawing.Size(164, 39)
        Me.ltitle.TabIndex = 0
        Me.ltitle.Text = "Check-In"
        '
        'Pmenu
        '
        Me.Pmenu.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Pmenu.Controls.Add(Me.Lref)
        Me.Pmenu.Controls.Add(Me.Tref)
        Me.Pmenu.Controls.Add(Me.Lemail)
        Me.Pmenu.Controls.Add(Me.Temail)
        Me.Pmenu.Controls.Add(Me.Bcheck)
        Me.Pmenu.Location = New System.Drawing.Point(374, 67)
        Me.Pmenu.Name = "Pmenu"
        Me.Pmenu.Size = New System.Drawing.Size(619, 149)
        Me.Pmenu.TabIndex = 0
        '
        'Lref
        '
        Me.Lref.AutoSize = True
        Me.Lref.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Lref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lref.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Lref.Location = New System.Drawing.Point(36, 48)
        Me.Lref.Name = "Lref"
        Me.Lref.Size = New System.Drawing.Size(132, 16)
        Me.Lref.TabIndex = 2
        Me.Lref.Text = "* Booking Reference"
        '
        'Tref
        '
        Me.Tref.Location = New System.Drawing.Point(36, 67)
        Me.Tref.Multiline = True
        Me.Tref.Name = "Tref"
        Me.Tref.Size = New System.Drawing.Size(193, 30)
        Me.Tref.TabIndex = 0
        Me.Tref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lemail
        '
        Me.Lemail.AutoSize = True
        Me.Lemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lemail.ForeColor = System.Drawing.Color.Cornsilk
        Me.Lemail.Location = New System.Drawing.Point(261, 46)
        Me.Lemail.Name = "Lemail"
        Me.Lemail.Size = New System.Drawing.Size(50, 16)
        Me.Lemail.TabIndex = 2
        Me.Lemail.Text = "* Email"
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(261, 67)
        Me.Temail.Multiline = True
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(193, 30)
        Me.Temail.TabIndex = 0
        Me.Temail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bcheck
        '
        Me.Bcheck.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Bcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcheck.ForeColor = System.Drawing.Color.DarkRed
        Me.Bcheck.Location = New System.Drawing.Point(486, 59)
        Me.Bcheck.Name = "Bcheck"
        Me.Bcheck.Size = New System.Drawing.Size(96, 46)
        Me.Bcheck.TabIndex = 1
        Me.Bcheck.Text = "Check-in"
        Me.Bcheck.UseVisualStyleBackColor = False
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.Color.White
        Me.P2.Controls.Add(Me.Bclose)
        Me.P2.Controls.Add(Me.Label4)
        Me.P2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.P2.Location = New System.Drawing.Point(0, 0)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(1366, 244)
        Me.P2.TabIndex = 1
        '
        'Bclose
        '
        Me.Bclose.Location = New System.Drawing.Point(1218, 171)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(117, 45)
        Me.Bclose.TabIndex = 1
        Me.Bclose.Text = "Exit"
        Me.Bclose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(601, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Check-In"
        '
        'Checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 244)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Checkin"
        Me.Text = "Form1"
        Me.P1.ResumeLayout(False)
        Me.P1.PerformLayout()
        Me.Pmenu.ResumeLayout(False)
        Me.Pmenu.PerformLayout()
        Me.P2.ResumeLayout(False)
        Me.P2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents ltitle As System.Windows.Forms.Label
    Friend WithEvents Pmenu As System.Windows.Forms.Panel
    Friend WithEvents Lemail As System.Windows.Forms.Label
    Friend WithEvents Lref As System.Windows.Forms.Label
    Friend WithEvents Bcheck As System.Windows.Forms.Button
    Friend WithEvents Temail As System.Windows.Forms.TextBox
    Friend WithEvents Tref As System.Windows.Forms.TextBox
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bclose As System.Windows.Forms.Button

End Class
