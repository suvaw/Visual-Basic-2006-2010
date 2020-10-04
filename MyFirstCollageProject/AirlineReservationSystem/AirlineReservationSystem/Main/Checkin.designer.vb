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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.P1 = New System.Windows.Forms.Panel()
        Me.ltitle = New System.Windows.Forms.Label()
        Me.Pmenu = New System.Windows.Forms.Panel()
        Me.Cbxto = New System.Windows.Forms.ComboBox()
        Me.Cbxfrom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bclear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lemail = New System.Windows.Forms.Label()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Bcheck = New System.Windows.Forms.Button()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.bback = New System.Windows.Forms.Button()
        Me.Bclose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.P1.SuspendLayout()
        Me.Pmenu.SuspendLayout()
        Me.P2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Gold
        Me.P1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._4
        Me.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.Pmenu.Controls.Add(Me.Cbxto)
        Me.Pmenu.Controls.Add(Me.Cbxfrom)
        Me.Pmenu.Controls.Add(Me.Label1)
        Me.Pmenu.Controls.Add(Me.bclear)
        Me.Pmenu.Controls.Add(Me.Label3)
        Me.Pmenu.Controls.Add(Me.Label2)
        Me.Pmenu.Controls.Add(Me.Lemail)
        Me.Pmenu.Controls.Add(Me.Temail)
        Me.Pmenu.Controls.Add(Me.Bcheck)
        Me.Pmenu.Location = New System.Drawing.Point(374, 67)
        Me.Pmenu.Name = "Pmenu"
        Me.Pmenu.Size = New System.Drawing.Size(619, 149)
        Me.Pmenu.TabIndex = 0
        '
        'Cbxto
        '
        Me.Cbxto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxto.FormattingEnabled = True
        Me.Cbxto.Location = New System.Drawing.Point(249, 28)
        Me.Cbxto.Name = "Cbxto"
        Me.Cbxto.Size = New System.Drawing.Size(193, 32)
        Me.Cbxto.TabIndex = 5
        '
        'Cbxfrom
        '
        Me.Cbxfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxfrom.FormattingEnabled = True
        Me.Cbxfrom.Location = New System.Drawing.Point(40, 28)
        Me.Cbxfrom.Name = "Cbxfrom"
        Me.Cbxfrom.Size = New System.Drawing.Size(193, 32)
        Me.Cbxfrom.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'bclear
        '
        Me.bclear.BackColor = System.Drawing.Color.Transparent
        Me.bclear.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._15788_illustration_of_a_blank_glossy_rectangular_button_pv
        Me.bclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bclear.FlatAppearance.BorderSize = 0
        Me.bclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclear.ForeColor = System.Drawing.Color.White
        Me.bclear.Location = New System.Drawing.Point(461, 80)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(130, 46)
        Me.bclear.TabIndex = 3
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Location = New System.Drawing.Point(246, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Location = New System.Drawing.Point(37, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'Lemail
        '
        Me.Lemail.AutoSize = True
        Me.Lemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lemail.ForeColor = System.Drawing.Color.Cornsilk
        Me.Lemail.Location = New System.Drawing.Point(37, 97)
        Me.Lemail.Name = "Lemail"
        Me.Lemail.Size = New System.Drawing.Size(50, 16)
        Me.Lemail.TabIndex = 2
        Me.Lemail.Text = "* Email"
        '
        'Temail
        '
        Me.Temail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temail.Location = New System.Drawing.Point(93, 90)
        Me.Temail.Multiline = True
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(349, 30)
        Me.Temail.TabIndex = 0
        Me.Temail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bcheck
        '
        Me.Bcheck.BackColor = System.Drawing.Color.Transparent
        Me.Bcheck.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._15788_illustration_of_a_blank_glossy_rectangular_button_pv
        Me.Bcheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bcheck.FlatAppearance.BorderSize = 0
        Me.Bcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcheck.ForeColor = System.Drawing.Color.Black
        Me.Bcheck.Location = New System.Drawing.Point(461, 22)
        Me.Bcheck.Name = "Bcheck"
        Me.Bcheck.Size = New System.Drawing.Size(130, 46)
        Me.Bcheck.TabIndex = 1
        Me.Bcheck.Text = "Check-in"
        Me.Bcheck.UseVisualStyleBackColor = False
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.Color.White
        Me.P2.Controls.Add(Me.dgvdata)
        Me.P2.Controls.Add(Me.bback)
        Me.P2.Controls.Add(Me.Bclose)
        Me.P2.Controls.Add(Me.Label4)
        Me.P2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.P2.Location = New System.Drawing.Point(0, 0)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(1366, 244)
        Me.P2.TabIndex = 1
        '
        'dgvdata
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(258, 59)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvdata.RowHeadersVisible = False
        Me.dgvdata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgvdata.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.RowTemplate.Height = 30
        Me.dgvdata.RowTemplate.ReadOnly = True
        Me.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdata.Size = New System.Drawing.Size(850, 173)
        Me.dgvdata.TabIndex = 3
        '
        'bback
        '
        Me.bback.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.glossy_button_blank_yellow_rectangle
        Me.bback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bback.FlatAppearance.BorderSize = 0
        Me.bback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bback.Location = New System.Drawing.Point(1114, 150)
        Me.bback.Name = "bback"
        Me.bback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bback.Size = New System.Drawing.Size(117, 81)
        Me.bback.TabIndex = 2
        Me.bback.Text = "Back"
        Me.bback.UseVisualStyleBackColor = True
        '
        'Bclose
        '
        Me.Bclose.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.glossy_button_blank_yellow_rectangle
        Me.Bclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bclose.FlatAppearance.BorderSize = 0
        Me.Bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclose.Location = New System.Drawing.Point(1114, 59)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(117, 81)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 244)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Checkin"
        Me.Text = "Form1"
        Me.P1.ResumeLayout(False)
        Me.P1.PerformLayout()
        Me.Pmenu.ResumeLayout(False)
        Me.Pmenu.PerformLayout()
        Me.P2.ResumeLayout(False)
        Me.P2.PerformLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents ltitle As System.Windows.Forms.Label
    Friend WithEvents Pmenu As System.Windows.Forms.Panel
    Friend WithEvents Lemail As System.Windows.Forms.Label
    Friend WithEvents Bcheck As System.Windows.Forms.Button
    Friend WithEvents Temail As System.Windows.Forms.TextBox
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bclose As System.Windows.Forms.Button
    Friend WithEvents bclear As System.Windows.Forms.Button
    Friend WithEvents bback As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Cbxto As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxfrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView

End Class
