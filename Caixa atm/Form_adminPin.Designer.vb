<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_adminPin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_adminPin))
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.TextBox_pin = New System.Windows.Forms.TextBox()
        Me.button_cancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_alterar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox_num = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TextBox_confirmar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox4 = New Bunifu.Framework.UI.BunifuTextbox()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(717, 44)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 64
        Me.PictureBox_logo.TabStop = False
        '
        'TextBox_pin
        '
        Me.TextBox_pin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_pin.Location = New System.Drawing.Point(193, 282)
        Me.TextBox_pin.Name = "TextBox_pin"
        Me.TextBox_pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_pin.Size = New System.Drawing.Size(231, 33)
        Me.TextBox_pin.TabIndex = 51
        '
        'button_cancelar
        '
        Me.button_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.button_cancelar.ActiveBorderThickness = 1
        Me.button_cancelar.ActiveCornerRadius = 20
        Me.button_cancelar.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.button_cancelar.ActiveForecolor = System.Drawing.Color.White
        Me.button_cancelar.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.button_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.button_cancelar.BackgroundImage = CType(resources.GetObject("button_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.button_cancelar.ButtonText = "Cancelar"
        Me.button_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancelar.ForeColor = System.Drawing.Color.White
        Me.button_cancelar.IdleBorderThickness = 1
        Me.button_cancelar.IdleCornerRadius = 20
        Me.button_cancelar.IdleFillColor = System.Drawing.Color.Firebrick
        Me.button_cancelar.IdleForecolor = System.Drawing.Color.White
        Me.button_cancelar.IdleLineColor = System.Drawing.Color.White
        Me.button_cancelar.Location = New System.Drawing.Point(463, 472)
        Me.button_cancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(162, 46)
        Me.button_cancelar.TabIndex = 63
        Me.button_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Novo Pin :"
        '
        'button_alterar
        '
        Me.button_alterar.ActiveBorderThickness = 1
        Me.button_alterar.ActiveCornerRadius = 20
        Me.button_alterar.ActiveFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_alterar.ActiveForecolor = System.Drawing.Color.White
        Me.button_alterar.ActiveLineColor = System.Drawing.Color.MediumSeaGreen
        Me.button_alterar.BackColor = System.Drawing.Color.Transparent
        Me.button_alterar.BackgroundImage = CType(resources.GetObject("button_alterar.BackgroundImage"), System.Drawing.Image)
        Me.button_alterar.ButtonText = "Alterar"
        Me.button_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_alterar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_alterar.ForeColor = System.Drawing.Color.White
        Me.button_alterar.IdleBorderThickness = 1
        Me.button_alterar.IdleCornerRadius = 20
        Me.button_alterar.IdleFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_alterar.IdleForecolor = System.Drawing.Color.White
        Me.button_alterar.IdleLineColor = System.Drawing.Color.White
        Me.button_alterar.Location = New System.Drawing.Point(635, 472)
        Me.button_alterar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_alterar.Name = "button_alterar"
        Me.button_alterar.Size = New System.Drawing.Size(162, 46)
        Me.button_alterar.TabIndex = 62
        Me.button_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_num
        '
        Me.TextBox_num.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_num.Location = New System.Drawing.Point(290, 208)
        Me.TextBox_num.Name = "TextBox_num"
        Me.TextBox_num.Size = New System.Drawing.Size(231, 33)
        Me.TextBox_num.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(79, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 25)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Número da conta :"
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(996, 450)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(243, 42)
        Me.BunifuTextbox1.TabIndex = 56
        Me.BunifuTextbox1.text = "Bunifu TextBox"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(589, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 28)
        Me.Label10.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 28)
        Me.Label5.TabIndex = 59
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_confirmar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_pin)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_cancelar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_alterar)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label13)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox4)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-9, -32)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(813, 536)
        Me.BunifuGradientPanel1.TabIndex = 61
        '
        'TextBox_confirmar
        '
        Me.TextBox_confirmar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_confirmar.Location = New System.Drawing.Point(210, 358)
        Me.TextBox_confirmar.Name = "TextBox_confirmar"
        Me.TextBox_confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_confirmar.Size = New System.Drawing.Size(231, 33)
        Me.TextBox_confirmar.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Confirmar :"
        '
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.Enabled = False
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(43, 199)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(496, 51)
        Me.BunifuTextbox2.TabIndex = 72
        Me.BunifuTextbox2.text = ""
        '
        'BunifuTextbox3
        '
        Me.BunifuTextbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox3.BackgroundImage = CType(resources.GetObject("BunifuTextbox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox3.Enabled = False
        Me.BunifuTextbox3.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox3.Icon = CType(resources.GetObject("BunifuTextbox3.Icon"), System.Drawing.Image)
        Me.BunifuTextbox3.Location = New System.Drawing.Point(44, 273)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(401, 51)
        Me.BunifuTextbox3.TabIndex = 73
        Me.BunifuTextbox3.text = ""
        '
        'BunifuTextbox4
        '
        Me.BunifuTextbox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox4.BackgroundImage = CType(resources.GetObject("BunifuTextbox4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox4.Enabled = False
        Me.BunifuTextbox4.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox4.Icon = CType(resources.GetObject("BunifuTextbox4.Icon"), System.Drawing.Image)
        Me.BunifuTextbox4.Location = New System.Drawing.Point(45, 349)
        Me.BunifuTextbox4.Name = "BunifuTextbox4"
        Me.BunifuTextbox4.Size = New System.Drawing.Size(419, 51)
        Me.BunifuTextbox4.TabIndex = 74
        Me.BunifuTextbox4.text = ""
        '
        'Form_adminPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_adminPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_adminPin"
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents TextBox_pin As TextBox
    Friend WithEvents button_cancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents button_alterar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox_num As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TextBox_confirmar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox4 As Bunifu.Framework.UI.BunifuTextbox
End Class
