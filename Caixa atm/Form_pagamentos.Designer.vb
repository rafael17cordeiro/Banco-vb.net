<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pagamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_pagamentos))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_saldo = New System.Windows.Forms.Label()
        Me.Label_num = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.TextBox_montante = New System.Windows.Forms.TextBox()
        Me.button_cancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button_pagar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox_referencia = New System.Windows.Forms.TextBox()
        Me.Label_montante = New System.Windows.Forms.Label()
        Me.Label_referencia = New System.Windows.Forms.Label()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(218, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 24)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Saldo disponivel :"
        '
        'Label_saldo
        '
        Me.Label_saldo.AutoSize = True
        Me.Label_saldo.BackColor = System.Drawing.Color.Transparent
        Me.Label_saldo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_saldo.ForeColor = System.Drawing.Color.White
        Me.Label_saldo.Location = New System.Drawing.Point(35, 181)
        Me.Label_saldo.Name = "Label_saldo"
        Me.Label_saldo.Size = New System.Drawing.Size(190, 25)
        Me.Label_saldo.TabIndex = 41
        Me.Label_saldo.Text = "Saldo disponivel :"
        '
        'Label_num
        '
        Me.Label_num.AutoSize = True
        Me.Label_num.BackColor = System.Drawing.Color.Transparent
        Me.Label_num.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_num.ForeColor = System.Drawing.Color.White
        Me.Label_num.Location = New System.Drawing.Point(35, 132)
        Me.Label_num.Name = "Label_num"
        Me.Label_num.Size = New System.Drawing.Size(205, 25)
        Me.Label_num.TabIndex = 40
        Me.Label_num.Text = "Numero da conta :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(240, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 24)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Numero da conta :"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuProgressBar1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_montante)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_cancelar)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_pagar)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_referencia)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_montante)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_referencia)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label11)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_saldo)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label12)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-7, -33)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(829, 540)
        Me.BunifuGradientPanel1.TabIndex = 58
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuProgressBar1.BorderRadius = 10
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(19, 34)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(798, 17)
        Me.BunifuProgressBar1.TabIndex = 67
        Me.BunifuProgressBar1.Value = 0
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(715, 57)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 64
        Me.PictureBox_logo.TabStop = False
        '
        'TextBox_montante
        '
        Me.TextBox_montante.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_montante.Location = New System.Drawing.Point(216, 317)
        Me.TextBox_montante.Multiline = True
        Me.TextBox_montante.Name = "TextBox_montante"
        Me.TextBox_montante.Size = New System.Drawing.Size(231, 25)
        Me.TextBox_montante.TabIndex = 51
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
        Me.button_cancelar.Location = New System.Drawing.Point(445, 473)
        Me.button_cancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(169, 46)
        Me.button_cancelar.TabIndex = 63
        Me.button_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_pagar
        '
        Me.button_pagar.ActiveBorderThickness = 1
        Me.button_pagar.ActiveCornerRadius = 20
        Me.button_pagar.ActiveFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_pagar.ActiveForecolor = System.Drawing.Color.White
        Me.button_pagar.ActiveLineColor = System.Drawing.Color.MediumSeaGreen
        Me.button_pagar.BackColor = System.Drawing.Color.Transparent
        Me.button_pagar.BackgroundImage = CType(resources.GetObject("button_pagar.BackgroundImage"), System.Drawing.Image)
        Me.button_pagar.ButtonText = "Pagar"
        Me.button_pagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_pagar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_pagar.ForeColor = System.Drawing.Color.White
        Me.button_pagar.IdleBorderThickness = 1
        Me.button_pagar.IdleCornerRadius = 20
        Me.button_pagar.IdleFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_pagar.IdleForecolor = System.Drawing.Color.White
        Me.button_pagar.IdleLineColor = System.Drawing.Color.White
        Me.button_pagar.Location = New System.Drawing.Point(624, 473)
        Me.button_pagar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_pagar.Name = "button_pagar"
        Me.button_pagar.Size = New System.Drawing.Size(169, 46)
        Me.button_pagar.TabIndex = 62
        Me.button_pagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_referencia
        '
        Me.TextBox_referencia.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_referencia.Location = New System.Drawing.Point(214, 253)
        Me.TextBox_referencia.Multiline = True
        Me.TextBox_referencia.Name = "TextBox_referencia"
        Me.TextBox_referencia.Size = New System.Drawing.Size(231, 30)
        Me.TextBox_referencia.TabIndex = 39
        '
        'Label_montante
        '
        Me.Label_montante.AutoSize = True
        Me.Label_montante.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label_montante.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_montante.ForeColor = System.Drawing.Color.White
        Me.Label_montante.Location = New System.Drawing.Point(90, 317)
        Me.Label_montante.Name = "Label_montante"
        Me.Label_montante.Size = New System.Drawing.Size(121, 25)
        Me.Label_montante.TabIndex = 49
        Me.Label_montante.Text = "Montante :"
        '
        'Label_referencia
        '
        Me.Label_referencia.AutoSize = True
        Me.Label_referencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label_referencia.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_referencia.ForeColor = System.Drawing.Color.White
        Me.Label_referencia.Location = New System.Drawing.Point(83, 254)
        Me.Label_referencia.Name = "Label_referencia"
        Me.Label_referencia.Size = New System.Drawing.Size(133, 25)
        Me.Label_referencia.TabIndex = 49
        Me.Label_referencia.Text = "Referência :"
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
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.Enabled = False
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(43, 241)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(428, 51)
        Me.BunifuTextbox2.TabIndex = 70
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
        Me.BunifuTextbox3.Location = New System.Drawing.Point(43, 304)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(430, 51)
        Me.BunifuTextbox3.TabIndex = 71
        Me.BunifuTextbox3.text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Montante :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(417, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 28)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "$"
        '
        'Timer1
        '
        '
        'Form_pagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_pagamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_pagamentos"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label_saldo As Label
    Friend WithEvents Label_num As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents TextBox_montante As TextBox
    Friend WithEvents button_cancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_pagar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox_referencia As TextBox
    Friend WithEvents Label_referencia As Label
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_montante As Label
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
End Class
