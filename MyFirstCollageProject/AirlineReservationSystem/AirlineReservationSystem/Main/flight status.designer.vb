<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flight_status
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bclear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bback = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._3
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bclear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.input)
        Me.Panel1.Location = New System.Drawing.Point(183, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 212)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.Search_Button_PNG_Transparent_Image
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(352, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(349, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'bclear
        '
        Me.bclear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bclear.BorderRadius = 0
        Me.bclear.ButtonText = "Clear"
        Me.bclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bclear.DisabledColor = System.Drawing.Color.Gray
        Me.bclear.Iconcolor = System.Drawing.Color.Transparent
        Me.bclear.Iconimage = Nothing
        Me.bclear.Iconimage_right = Nothing
        Me.bclear.Iconimage_right_Selected = Nothing
        Me.bclear.Iconimage_Selected = Nothing
        Me.bclear.IconMarginLeft = 0
        Me.bclear.IconMarginRight = 0
        Me.bclear.IconRightVisible = True
        Me.bclear.IconRightZoom = 0.0R
        Me.bclear.IconVisible = True
        Me.bclear.IconZoom = 90.0R
        Me.bclear.IsTab = False
        Me.bclear.Location = New System.Drawing.Point(532, 130)
        Me.bclear.Name = "bclear"
        Me.bclear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bclear.OnHoverTextColor = System.Drawing.Color.White
        Me.bclear.selected = False
        Me.bclear.Size = New System.Drawing.Size(117, 38)
        Me.bclear.TabIndex = 3
        Me.bclear.Text = "Clear"
        Me.bclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bclear.Textcolor = System.Drawing.Color.White
        Me.bclear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Flight No."
        '
        'input
        '
        Me.input.AutoCompleteCustomSource.AddRange(New String() {"SG 125", "SG 196", "SG 715", "SG 626", "SG 696", "SG 125", "SG 129", "SG 3288", "SG 685", "SG 750", "SG 687", "SG 784", "SG 715", "SG 758", "SG 764", "SG 3302", "SG 3425", "SG 1233", "SG 3318", "SG 192", "SG 136", "SG 712", "SG 715", "SG 631", "SG 637", "SG 438", "SG 635", "SG 456", "SG 516", "SG 573", "SG 623", "SG 3426", "SG 3309", "SG 3307", "SG 3309", "SG 3301", "SG 731", "SG 3309", "SG 106", "SG 623", "SG 278", "SG 678", "SG 658", "SG 3309", "SG 530", "SG 424", "SG 3307", "SG 3468", "SG 530", "SG 1546", "SG 658", "SG 209", "SG 126", "SG 263", "SG 3307", "SG 133", "SG 261", "SG 8189", "SG 658", "SG 1546", "SG 530", "SG 3246", "SG 277", "SG 3307", "SG 177", "SG 658", "SG 488", "SG 567SG 1546", "SG 611", "SG 537", "SG 637", "SG 792", "SG160", "SG 530", "SG 789", "SG 1546", "SG 611", "SG 3307", "SG 530", "SG 320", "SG 3614", "SG 5684", "SG 1546", "SG 253", "SG 457", ""})
        Me.input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(351, 73)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(298, 32)
        Me.input.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.bclose)
        Me.Panel2.Controls.Add(Me.bback)
        Me.Panel2.Controls.Add(Me.dgvdata)
        Me.Panel2.Location = New System.Drawing.Point(183, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 212)
        Me.Panel2.TabIndex = 1
        '
        'bclose
        '
        Me.bclose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bclose.BorderRadius = 0
        Me.bclose.ButtonText = "Close"
        Me.bclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bclose.DisabledColor = System.Drawing.Color.Gray
        Me.bclose.Iconcolor = System.Drawing.Color.Transparent
        Me.bclose.Iconimage = Nothing
        Me.bclose.Iconimage_right = Nothing
        Me.bclose.Iconimage_right_Selected = Nothing
        Me.bclose.Iconimage_Selected = Nothing
        Me.bclose.IconMarginLeft = 0
        Me.bclose.IconMarginRight = 0
        Me.bclose.IconRightVisible = True
        Me.bclose.IconRightZoom = 0.0R
        Me.bclose.IconVisible = True
        Me.bclose.IconZoom = 90.0R
        Me.bclose.IsTab = False
        Me.bclose.Location = New System.Drawing.Point(785, 115)
        Me.bclose.Name = "bclose"
        Me.bclose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bclose.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bclose.OnHoverTextColor = System.Drawing.Color.White
        Me.bclose.selected = False
        Me.bclose.Size = New System.Drawing.Size(154, 53)
        Me.bclose.TabIndex = 2
        Me.bclose.Text = "Close"
        Me.bclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bclose.Textcolor = System.Drawing.Color.White
        Me.bclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bback
        '
        Me.bback.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bback.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bback.BorderRadius = 0
        Me.bback.ButtonText = "Back"
        Me.bback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bback.DisabledColor = System.Drawing.Color.Gray
        Me.bback.Iconcolor = System.Drawing.Color.Transparent
        Me.bback.Iconimage = Nothing
        Me.bback.Iconimage_right = Nothing
        Me.bback.Iconimage_right_Selected = Nothing
        Me.bback.Iconimage_Selected = Nothing
        Me.bback.IconMarginLeft = 0
        Me.bback.IconMarginRight = 0
        Me.bback.IconRightVisible = True
        Me.bback.IconRightZoom = 0.0R
        Me.bback.IconVisible = True
        Me.bback.IconZoom = 90.0R
        Me.bback.IsTab = False
        Me.bback.Location = New System.Drawing.Point(785, 37)
        Me.bback.Name = "bback"
        Me.bback.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bback.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bback.OnHoverTextColor = System.Drawing.Color.White
        Me.bback.selected = False
        Me.bback.Size = New System.Drawing.Size(154, 53)
        Me.bback.TabIndex = 1
        Me.bback.Text = "Back"
        Me.bback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bback.Textcolor = System.Drawing.Color.White
        Me.bback.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvdata
        '
        Me.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdata.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdata.Location = New System.Drawing.Point(25, 15)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdata.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvdata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgvdata.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.RowTemplate.Height = 40
        Me.dgvdata.RowTemplate.ReadOnly = True
        Me.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdata.Size = New System.Drawing.Size(714, 180)
        Me.dgvdata.TabIndex = 0
        '
        'flight_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._6
        Me.ClientSize = New System.Drawing.Size(1366, 244)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "flight_status"
        Me.Text = "flight_status"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents bclose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bback As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bclear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
