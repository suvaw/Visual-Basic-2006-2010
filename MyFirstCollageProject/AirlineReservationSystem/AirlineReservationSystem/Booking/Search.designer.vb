<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bsearch = New System.Windows.Forms.Button()
        Me.DPD = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cbxto = New System.Windows.Forms.ComboBox()
        Me.Cbxform = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lflightprice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Bregister = New System.Windows.Forms.Button()
        Me.Bhome = New System.Windows.Forms.Button()
        Me.Blogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Bsearch)
        Me.Panel1.Controls.Add(Me.DPD)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Cbxto)
        Me.Panel1.Controls.Add(Me.Cbxform)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Lflightprice)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 221)
        Me.Panel1.TabIndex = 1
        '
        'Bsearch
        '
        Me.Bsearch.BackColor = System.Drawing.Color.Transparent
        Me.Bsearch.BackgroundImage = CType(resources.GetObject("Bsearch.BackgroundImage"), System.Drawing.Image)
        Me.Bsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bsearch.FlatAppearance.BorderSize = 0
        Me.Bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsearch.Location = New System.Drawing.Point(1135, 62)
        Me.Bsearch.Name = "Bsearch"
        Me.Bsearch.Size = New System.Drawing.Size(218, 52)
        Me.Bsearch.TabIndex = 4
        Me.Bsearch.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Bsearch.UseVisualStyleBackColor = False
        '
        'DPD
        '
        Me.DPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPD.Location = New System.Drawing.Point(759, 66)
        Me.DPD.MaxDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DPD.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DPD.Name = "DPD"
        Me.DPD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPD.Size = New System.Drawing.Size(188, 44)
        Me.DPD.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(357, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Cbxto
        '
        Me.Cbxto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxto.FormattingEnabled = True
        Me.Cbxto.Location = New System.Drawing.Point(455, 66)
        Me.Cbxto.Name = "Cbxto"
        Me.Cbxto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxto.Size = New System.Drawing.Size(267, 45)
        Me.Cbxto.TabIndex = 2
        Me.Cbxto.Text = "Form"
        '
        'Cbxform
        '
        Me.Cbxform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbxform.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbxform.FormattingEnabled = True
        Me.Cbxform.Location = New System.Drawing.Point(79, 66)
        Me.Cbxform.Name = "Cbxform"
        Me.Cbxform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbxform.Size = New System.Drawing.Size(267, 45)
        Me.Cbxform.TabIndex = 1
        Me.Cbxform.Text = "Form"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(987, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Per Person"
        '
        'Lflightprice
        '
        Me.Lflightprice.AutoSize = True
        Me.Lflightprice.BackColor = System.Drawing.Color.Transparent
        Me.Lflightprice.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lflightprice.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lflightprice.Location = New System.Drawing.Point(987, 69)
        Me.Lflightprice.Name = "Lflightprice"
        Me.Lflightprice.Size = New System.Drawing.Size(85, 32)
        Me.Lflightprice.TabIndex = 2
        Me.Lflightprice.Text = "₹ 0 /-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(810, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Departure Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(189, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FROM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(576, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TO"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.Bregister)
        Me.Panel3.Controls.Add(Me.Bhome)
        Me.Panel3.Controls.Add(Me.Blogin)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(59, 646)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1249, 75)
        Me.Panel3.TabIndex = 4
        '
        'Bregister
        '
        Me.Bregister.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.orange_rectangle_button_hi
        Me.Bregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bregister.FlatAppearance.BorderSize = 0
        Me.Bregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bregister.Location = New System.Drawing.Point(426, 10)
        Me.Bregister.Name = "Bregister"
        Me.Bregister.Size = New System.Drawing.Size(130, 57)
        Me.Bregister.TabIndex = 1
        Me.Bregister.Text = "REGISTATION"
        Me.Bregister.UseVisualStyleBackColor = True
        '
        'Bhome
        '
        Me.Bhome.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.home_button
        Me.Bhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bhome.FlatAppearance.BorderSize = 0
        Me.Bhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhome.Location = New System.Drawing.Point(160, 10)
        Me.Bhome.Name = "Bhome"
        Me.Bhome.Size = New System.Drawing.Size(173, 57)
        Me.Bhome.TabIndex = 1
        Me.Bhome.UseVisualStyleBackColor = True
        '
        'Blogin
        '
        Me.Blogin.BackColor = System.Drawing.Color.Transparent
        Me.Blogin.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources.orange_rectangle_button_hi
        Me.Blogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Blogin.FlatAppearance.BorderSize = 0
        Me.Blogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Blogin.Location = New System.Drawing.Point(692, 8)
        Me.Blogin.Name = "Blogin"
        Me.Blogin.Size = New System.Drawing.Size(130, 57)
        Me.Blogin.TabIndex = 1
        Me.Blogin.Text = "MY PROFILE"
        Me.Blogin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(958, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.dgvdata)
        Me.Panel2.Controls.Add(Me.BunifuGradientPanel3)
        Me.Panel2.Controls.Add(Me.BunifuGradientPanel2)
        Me.Panel2.Location = New System.Drawing.Point(59, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1249, 449)
        Me.Panel2.TabIndex = 5
        '
        'dgvdata
        '
        Me.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.ColumnHeadersVisible = False
        Me.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvdata.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvdata.Location = New System.Drawing.Point(0, 84)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdata.RowHeadersVisible = False
        Me.dgvdata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgvdata.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.RowTemplate.Height = 40
        Me.dgvdata.RowTemplate.ReadOnly = True
        Me.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdata.Size = New System.Drawing.Size(1249, 365)
        Me.dgvdata.TabIndex = 2
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.Label20)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label21)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label22)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label23)
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(0, 39)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(1249, 45)
        Me.BunifuGradientPanel3.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Info
        Me.Label20.Location = New System.Drawing.Point(1081, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 24)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "PRICE"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Info
        Me.Label21.Location = New System.Drawing.Point(565, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 24)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "DURATION"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Info
        Me.Label22.Location = New System.Drawing.Point(818, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(125, 24)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "FLIGHT NO."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(112, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DEPART"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Info
        Me.Label23.Location = New System.Drawing.Point(342, 10)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 24)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "ARRIVE"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1249, 39)
        Me.BunifuGradientPanel2.TabIndex = 1
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Yellow
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(461, 7)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(326, 24)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "CHOOSE A DEPARTURE FLIGHT"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1366, 54)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1314, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.AirlineReservationSystem.My.Resources.Resources._827312_airport_512x512
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Blue
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(447, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(473, 39)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "AirLine Reservation System"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lflightprice As System.Windows.Forms.Label
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Cbxto As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxform As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DPD As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Bregister As System.Windows.Forms.Button
    Friend WithEvents Bhome As System.Windows.Forms.Button
    Friend WithEvents Blogin As System.Windows.Forms.Button
    Friend WithEvents Bsearch As System.Windows.Forms.Button

End Class
