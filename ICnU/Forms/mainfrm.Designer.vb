<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainfrm))
        Me.main = New ICnU.CrystalClearThemeContainer()
        Me.exbtn = New ICnU.CrystalClearButton()
        Me.minbtn = New ICnU.CrystalClearButton()
        Me.setbtn = New ICnU.CrystalClearButton()
        Me.crbtn = New ICnU.CrystalClearButton()
        Me.cfsbtn = New ICnU.CrystalClearButton()
        Me.main.SuspendLayout()
        Me.SuspendLayout()
        '
        'main
        '
        Me.main.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.main.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.main.Controls.Add(Me.exbtn)
        Me.main.Controls.Add(Me.minbtn)
        Me.main.Controls.Add(Me.setbtn)
        Me.main.Controls.Add(Me.crbtn)
        Me.main.Controls.Add(Me.cfsbtn)
        Me.main.Customization = "5ubm/9LS0v/m5ub/5ubm/6qqqv8="
        Me.main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.main.Image = CType(resources.GetObject("main.Image"), System.Drawing.Image)
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.MinimumSize = New System.Drawing.Size(175, 150)
        Me.main.Movable = True
        Me.main.Name = "main"
        Me.main.NoRounding = False
        Me.main.Rounding = ICnU.CrystalClearThemeContainer.RoundingType.None
        Me.main.Sizable = False
        Me.main.Size = New System.Drawing.Size(231, 204)
        Me.main.SmartBounds = True
        Me.main.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.main.TabIndex = 0
        Me.main.Text = "Image Capturer n Uploader "
        Me.main.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.main.Transparent = False
        '
        'exbtn
        '
        Me.exbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.exbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exbtn.Image = Nothing
        Me.exbtn.Location = New System.Drawing.Point(14, 165)
        Me.exbtn.Name = "exbtn"
        Me.exbtn.NoRounding = False
        Me.exbtn.Size = New System.Drawing.Size(203, 25)
        Me.exbtn.TabIndex = 5
        Me.exbtn.Text = "Exit"
        Me.exbtn.Transparent = False
        '
        'minbtn
        '
        Me.minbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.minbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.minbtn.Image = Nothing
        Me.minbtn.Location = New System.Drawing.Point(14, 134)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.NoRounding = False
        Me.minbtn.Size = New System.Drawing.Size(203, 25)
        Me.minbtn.TabIndex = 4
        Me.minbtn.Text = "Minimize"
        Me.minbtn.Transparent = False
        '
        'setbtn
        '
        Me.setbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.setbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.setbtn.Image = Nothing
        Me.setbtn.Location = New System.Drawing.Point(12, 103)
        Me.setbtn.Name = "setbtn"
        Me.setbtn.NoRounding = False
        Me.setbtn.Size = New System.Drawing.Size(203, 25)
        Me.setbtn.TabIndex = 3
        Me.setbtn.Text = "Settings"
        Me.setbtn.Transparent = False
        '
        'crbtn
        '
        Me.crbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.crbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.crbtn.Image = Nothing
        Me.crbtn.Location = New System.Drawing.Point(12, 72)
        Me.crbtn.Name = "crbtn"
        Me.crbtn.NoRounding = False
        Me.crbtn.Size = New System.Drawing.Size(203, 25)
        Me.crbtn.TabIndex = 2
        Me.crbtn.Text = "Capture Region"
        Me.crbtn.Transparent = False
        '
        'cfsbtn
        '
        Me.cfsbtn.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.cfsbtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cfsbtn.Image = Nothing
        Me.cfsbtn.Location = New System.Drawing.Point(14, 41)
        Me.cfsbtn.Name = "cfsbtn"
        Me.cfsbtn.NoRounding = False
        Me.cfsbtn.Size = New System.Drawing.Size(203, 25)
        Me.cfsbtn.TabIndex = 0
        Me.cfsbtn.Text = "Capture FullScreen"
        Me.cfsbtn.Transparent = False
        '
        'mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 204)
        Me.Controls.Add(Me.main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "mainfrm"
        Me.Text = "Image Capturer n Uploader -loyalty"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main As ICnU.CrystalClearThemeContainer
    Friend WithEvents exbtn As ICnU.CrystalClearButton
    Friend WithEvents minbtn As ICnU.CrystalClearButton
    Friend WithEvents setbtn As ICnU.CrystalClearButton
    Friend WithEvents crbtn As ICnU.CrystalClearButton
    Friend WithEvents cfsbtn As ICnU.CrystalClearButton

End Class
