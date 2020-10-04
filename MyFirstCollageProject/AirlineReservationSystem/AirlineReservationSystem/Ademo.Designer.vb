<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ademo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ademo))
        Me.DTVdata = New System.Windows.Forms.DataGridView()
        Me.CMD = New System.Windows.Forms.Button()
        Me.Tput = New System.Windows.Forms.TextBox()
        Me.CBdata = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CButton1 = New c.CButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DTVdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTVdata
        '
        Me.DTVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTVdata.Location = New System.Drawing.Point(12, 137)
        Me.DTVdata.Name = "DTVdata"
        Me.DTVdata.Size = New System.Drawing.Size(631, 161)
        Me.DTVdata.TabIndex = 0
        '
        'CMD
        '
        Me.CMD.Location = New System.Drawing.Point(497, 63)
        Me.CMD.Name = "CMD"
        Me.CMD.Size = New System.Drawing.Size(146, 23)
        Me.CMD.TabIndex = 2
        Me.CMD.Text = "Button1"
        Me.CMD.UseVisualStyleBackColor = True
        '
        'Tput
        '
        Me.Tput.Location = New System.Drawing.Point(213, 64)
        Me.Tput.Name = "Tput"
        Me.Tput.Size = New System.Drawing.Size(248, 20)
        Me.Tput.TabIndex = 3
        '
        'CBdata
        '
        Me.CBdata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBdata.FormattingEnabled = True
        Me.CBdata.Location = New System.Drawing.Point(12, 64)
        Me.CBdata.Name = "CBdata"
        Me.CBdata.Size = New System.Drawing.Size(181, 21)
        Me.CBdata.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CButton1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(58, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 363)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'CButton1
        '
        Me.CButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CButton1.BackColor = System.Drawing.Color.Transparent
        Me.CButton1.FlatAppearance.BorderSize = 0
        Me.CButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton1.Image = CType(resources.GetObject("CButton1.Image"), System.Drawing.Image)
        Me.CButton1.Location = New System.Drawing.Point(439, 77)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(160, 143)
        Me.CButton1.TabIndex = 1
        Me.CButton1.Text = "CButton1"
        Me.CButton1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(21, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(303, 20)
        Me.TextBox3.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(21, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(303, 20)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Ademo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBdata)
        Me.Controls.Add(Me.Tput)
        Me.Controls.Add(Me.CMD)
        Me.Controls.Add(Me.DTVdata)
        Me.Name = "Ademo"
        Me.Text = "Ademo"
        CType(Me.DTVdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTVdata As System.Windows.Forms.DataGridView
    Friend WithEvents CMD As System.Windows.Forms.Button
    Friend WithEvents Tput As System.Windows.Forms.TextBox
    Friend WithEvents CBdata As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CButton1 As c.CButton
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
