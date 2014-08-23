<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsfrm))
        Me.settings = New ICnU.CrystalClearThemeContainer()
        Me.closebtn = New ICnU.CrystalClearButton()
        Me.savbtn = New ICnU.CrystalClearButton()
        Me.CrystalClearCheckBox4 = New ICnU.CrystalClearCheckBox()
        Me.CrystalClearCheckBox3 = New ICnU.CrystalClearCheckBox()
        Me.CrystalClearCheckBox2 = New ICnU.CrystalClearCheckBox()
        Me.CrystalClearCheckBox1 = New ICnU.CrystalClearCheckBox()
        Me.settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.settings.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.settings.Controls.Add(Me.closebtn)
        Me.settings.Controls.Add(Me.savbtn)
        Me.settings.Controls.Add(Me.CrystalClearCheckBox4)
        Me.settings.Controls.Add(Me.CrystalClearCheckBox3)
        Me.settings.Controls.Add(Me.CrystalClearCheckBox2)
        Me.settings.Controls.Add(Me.CrystalClearCheckBox1)
        Me.settings.Customization = "5ubm/9LS0v/m5ub/5ubm/6qqqv8="
        Me.settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settings.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.settings.Image = Nothing
        Me.settings.Location = New System.Drawing.Point(0, 0)
        Me.settings.MinimumSize = New System.Drawing.Size(175, 150)
        Me.settings.Movable = True
        Me.settings.Name = "settings"
        Me.settings.NoRounding = False
        Me.settings.Rounding = ICnU.CrystalClearThemeContainer.RoundingType.None
        Me.settings.Sizable = False
        Me.settings.Size = New System.Drawing.Size(175, 168)
        Me.settings.SmartBounds = True
        Me.settings.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.settings.TabIndex = 0
        Me.settings.Text = "Settings"
        Me.settings.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.settings.Transparent = False
        '
        'closebtn
        '
        Me.closebtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.closebtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.closebtn.Image = Nothing
        Me.closebtn.Location = New System.Drawing.Point(149, 3)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.NoRounding = False
        Me.closebtn.Size = New System.Drawing.Size(20, 20)
        Me.closebtn.TabIndex = 5
        Me.closebtn.Text = "X"
        Me.closebtn.Transparent = False
        '
        'savbtn
        '
        Me.savbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.savbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.savbtn.Image = Nothing
        Me.savbtn.Location = New System.Drawing.Point(19, 133)
        Me.savbtn.Name = "savbtn"
        Me.savbtn.NoRounding = False
        Me.savbtn.Size = New System.Drawing.Size(136, 25)
        Me.savbtn.TabIndex = 4
        Me.savbtn.Text = "Save"
        Me.savbtn.Transparent = False
        '
        'CrystalClearCheckBox4
        '
        Me.CrystalClearCheckBox4.Checked = False
        Me.CrystalClearCheckBox4.Customization = "AAAA/+bm5v/S0tL/5ubm/6qqqv/m5ub/"
        Me.CrystalClearCheckBox4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CrystalClearCheckBox4.Image = Nothing
        Me.CrystalClearCheckBox4.Location = New System.Drawing.Point(19, 110)
        Me.CrystalClearCheckBox4.Name = "CrystalClearCheckBox4"
        Me.CrystalClearCheckBox4.NoRounding = False
        Me.CrystalClearCheckBox4.Size = New System.Drawing.Size(136, 17)
        Me.CrystalClearCheckBox4.TabIndex = 3
        Me.CrystalClearCheckBox4.Text = "Show Image"
        Me.CrystalClearCheckBox4.Transparent = False
        '
        'CrystalClearCheckBox3
        '
        Me.CrystalClearCheckBox3.Checked = True
        Me.CrystalClearCheckBox3.Customization = "AAAA/+bm5v/S0tL/5ubm/6qqqv/m5ub/"
        Me.CrystalClearCheckBox3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CrystalClearCheckBox3.Image = Nothing
        Me.CrystalClearCheckBox3.Location = New System.Drawing.Point(19, 87)
        Me.CrystalClearCheckBox3.Name = "CrystalClearCheckBox3"
        Me.CrystalClearCheckBox3.NoRounding = False
        Me.CrystalClearCheckBox3.Size = New System.Drawing.Size(136, 17)
        Me.CrystalClearCheckBox3.TabIndex = 2
        Me.CrystalClearCheckBox3.Text = "Upload Instantly"
        Me.CrystalClearCheckBox3.Transparent = False
        '
        'CrystalClearCheckBox2
        '
        Me.CrystalClearCheckBox2.Checked = False
        Me.CrystalClearCheckBox2.Customization = "AAAA/+bm5v/S0tL/5ubm/6qqqv/m5ub/"
        Me.CrystalClearCheckBox2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CrystalClearCheckBox2.Image = Nothing
        Me.CrystalClearCheckBox2.Location = New System.Drawing.Point(19, 64)
        Me.CrystalClearCheckBox2.Name = "CrystalClearCheckBox2"
        Me.CrystalClearCheckBox2.NoRounding = False
        Me.CrystalClearCheckBox2.Size = New System.Drawing.Size(136, 17)
        Me.CrystalClearCheckBox2.TabIndex = 1
        Me.CrystalClearCheckBox2.Text = "Include ME"
        Me.CrystalClearCheckBox2.Transparent = False
        '
        'CrystalClearCheckBox1
        '
        Me.CrystalClearCheckBox1.Checked = False
        Me.CrystalClearCheckBox1.Customization = "AAAA/+bm5v/S0tL/5ubm/6qqqv/m5ub/"
        Me.CrystalClearCheckBox1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CrystalClearCheckBox1.Image = Nothing
        Me.CrystalClearCheckBox1.Location = New System.Drawing.Point(19, 41)
        Me.CrystalClearCheckBox1.Name = "CrystalClearCheckBox1"
        Me.CrystalClearCheckBox1.NoRounding = False
        Me.CrystalClearCheckBox1.Size = New System.Drawing.Size(136, 17)
        Me.CrystalClearCheckBox1.TabIndex = 0
        Me.CrystalClearCheckBox1.Text = "Include Cursor"
        Me.CrystalClearCheckBox1.Transparent = False
        '
        'settingsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 168)
        Me.Controls.Add(Me.settings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "settingsfrm"
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.settings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settings As ICnU.CrystalClearThemeContainer
    Friend WithEvents closebtn As ICnU.CrystalClearButton
    Friend WithEvents savbtn As ICnU.CrystalClearButton
    Friend WithEvents CrystalClearCheckBox4 As ICnU.CrystalClearCheckBox
    Friend WithEvents CrystalClearCheckBox3 As ICnU.CrystalClearCheckBox
    Friend WithEvents CrystalClearCheckBox2 As ICnU.CrystalClearCheckBox
    Friend WithEvents CrystalClearCheckBox1 As ICnU.CrystalClearCheckBox
End Class
