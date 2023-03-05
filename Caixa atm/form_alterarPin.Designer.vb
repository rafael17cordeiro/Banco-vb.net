<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alterarPin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alterarPin))
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.TextBox_confirmar = New System.Windows.Forms.TextBox()
        Me.button_cancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label_confirmar = New System.Windows.Forms.Label()
        Me.button_alterar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox_pin = New System.Windows.Forms.TextBox()
        Me.Label_pin = New System.Windows.Forms.Label()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label_saldo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_num = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(707, 36)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 64
        Me.PictureBox_logo.TabStop = False
        '
        'TextBox_confirmar
        '
        Me.TextBox_confirmar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_confirmar.Location = New System.Drawing.Point(192, 330)
        Me.TextBox_confirmar.Multiline = True
        Me.TextBox_confirmar.Name = "TextBox_confirmar"
        Me.TextBox_confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_confirmar.Size = New System.Drawing.Size(231, 30)
        Me.TextBox_confirmar.TabIndex = 51
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
        Me.button_cancelar.Location = New System.Drawing.Point(453, 452)
        Me.button_cancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(162, 46)
        Me.button_cancelar.TabIndex = 63
        Me.button_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_confirmar
        '
        Me.Label_confirmar.AutoSize = True
        Me.Label_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.Label_confirmar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_confirmar.ForeColor = System.Drawing.Color.White
        Me.Label_confirmar.Location = New System.Drawing.Point(70, 333)
        Me.Label_confirmar.Name = "Label_confirmar"
        Me.Label_confirmar.Size = New System.Drawing.Size(125, 25)
        Me.Label_confirmar.TabIndex = 37
        Me.Label_confirmar.Text = "Confirmar :"
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
        Me.button_alterar.Location = New System.Drawing.Point(625, 452)
        Me.button_alterar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_alterar.Name = "button_alterar"
        Me.button_alterar.Size = New System.Drawing.Size(162, 46)
        Me.button_alterar.TabIndex = 62
        Me.button_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_pin
        '
        Me.TextBox_pin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_pin.Location = New System.Drawing.Point(133, 263)
        Me.TextBox_pin.Multiline = True
        Me.TextBox_pin.Name = "TextBox_pin"
        Me.TextBox_pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_pin.Size = New System.Drawing.Size(231, 30)
        Me.TextBox_pin.TabIndex = 39
        '
        'Label_pin
        '
        Me.Label_pin.AutoSize = True
        Me.Label_pin.BackColor = System.Drawing.Color.Transparent
        Me.Label_pin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_pin.ForeColor = System.Drawing.Color.White
        Me.Label_pin.Location = New System.Drawing.Point(76, 266)
        Me.Label_pin.Name = "Label_pin"
        Me.Label_pin.Size = New System.Drawing.Size(54, 25)
        Me.Label_pin.TabIndex = 49
        Me.Label_pin.Text = "Pin :"
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
        'Label_saldo
        '
        Me.Label_saldo.AutoSize = True
        Me.Label_saldo.BackColor = System.Drawing.Color.Transparent
        Me.Label_saldo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_saldo.ForeColor = System.Drawing.Color.White
        Me.Label_saldo.Location = New System.Drawing.Point(215, 196)
        Me.Label_saldo.Name = "Label_saldo"
        Me.Label_saldo.Size = New System.Drawing.Size(185, 24)
        Me.Label_saldo.TabIndex = 44
        Me.Label_saldo.Text = "Saldo disponivel :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Saldo disponivel :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Número da conta :"
        '
        'Label_num
        '
        Me.Label_num.AutoSize = True
        Me.Label_num.BackColor = System.Drawing.Color.Transparent
        Me.Label_num.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_num.ForeColor = System.Drawing.Color.White
        Me.Label_num.Location = New System.Drawing.Point(237, 147)
        Me.Label_num.Name = "Label_num"
        Me.Label_num.Size = New System.Drawing.Size(207, 24)
        Me.Label_num.TabIndex = 43
        Me.Label_num.Text = "Numero da conta :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(597, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 28)
        Me.Label10.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 28)
        Me.Label5.TabIndex = 56
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuProgressBar1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_confirmar)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_cancelar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_confirmar)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_alterar)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_pin)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_pin)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_saldo)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-1, -12)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(803, 513)
        Me.BunifuGradientPanel1.TabIndex = 58
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuProgressBar1.BorderRadius = 10
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(13, 13)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(798, 17)
        Me.BunifuProgressBar1.TabIndex = 67
        Me.BunifuProgressBar1.Value = 0
        '
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.Enabled = False
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(32, 253)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(355, 51)
        Me.BunifuTextbox2.TabIndex = 71
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
        Me.BunifuTextbox3.Location = New System.Drawing.Point(31, 319)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(445, 51)
        Me.BunifuTextbox3.TabIndex = 72
        Me.BunifuTextbox3.text = ""
        '
        'Timer1
        '
        '
        'form_alterarPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_alterarPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_alterarPin"
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents TextBox_confirmar As TextBox
    Friend WithEvents button_cancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label_confirmar As Label
    Friend WithEvents button_alterar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox_pin As TextBox
    Friend WithEvents Label_pin As Label
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label_saldo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label_num As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
End Class
