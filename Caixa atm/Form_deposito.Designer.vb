<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_deposito
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_deposito))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_saldo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label_conta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(608, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 28)
        Me.Label10.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 28)
        Me.Label5.TabIndex = 28
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuProgressBar1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuThinButton22)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label8)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_saldo)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_conta)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(1, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(802, 502)
        Me.BunifuGradientPanel1.TabIndex = 56
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuProgressBar1.BorderRadius = 10
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(3, 0)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(798, 17)
        Me.BunifuProgressBar1.TabIndex = 67
        Me.BunifuProgressBar1.Value = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox3.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox3.Location = New System.Drawing.Point(707, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Cancelar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(449, 440)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(163, 46)
        Me.BunifuThinButton21.TabIndex = 61
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Depositar"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(622, 442)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(163, 44)
        Me.BunifuThinButton22.TabIndex = 60
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuTextbox1.Size = New System.Drawing.Size(244, 39)
        Me.BunifuTextbox1.TabIndex = 56
        Me.BunifuTextbox1.text = "Bunifu TextBox"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(433, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 28)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "$"
        '
        'Label_saldo
        '
        Me.Label_saldo.AutoSize = True
        Me.Label_saldo.BackColor = System.Drawing.Color.Transparent
        Me.Label_saldo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_saldo.ForeColor = System.Drawing.Color.White
        Me.Label_saldo.Location = New System.Drawing.Point(224, 167)
        Me.Label_saldo.Name = "Label_saldo"
        Me.Label_saldo.Size = New System.Drawing.Size(185, 24)
        Me.Label_saldo.TabIndex = 30
        Me.Label_saldo.Text = "Saldo disponivel :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(191, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 33)
        Me.TextBox1.TabIndex = 25
        '
        'Label_conta
        '
        Me.Label_conta.AutoSize = True
        Me.Label_conta.BackColor = System.Drawing.Color.Transparent
        Me.Label_conta.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_conta.ForeColor = System.Drawing.Color.White
        Me.Label_conta.Location = New System.Drawing.Point(235, 118)
        Me.Label_conta.Name = "Label_conta"
        Me.Label_conta.Size = New System.Drawing.Size(207, 24)
        Me.Label_conta.TabIndex = 29
        Me.Label_conta.Text = "Numero da conta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Montante :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Número da conta :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Saldo disponivel :"
        '
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.Enabled = False
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(19, 240)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(447, 51)
        Me.BunifuTextbox2.TabIndex = 68
        Me.BunifuTextbox2.text = ""
        '
        'Timer1
        '
        '
        'Form_deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_deposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_deposito"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_saldo As Label
    Friend WithEvents Label_conta As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents TextBox1 As TextBox
End Class
