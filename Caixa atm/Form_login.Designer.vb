<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_login))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button_admin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.button_sair = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button_entrar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox_pin = New System.Windows.Forms.TextBox()
        Me.TextBox_user = New System.Windows.Forms.TextBox()
        Me.PictureBox_pin = New System.Windows.Forms.PictureBox()
        Me.PictureBox_user = New System.Windows.Forms.PictureBox()
        Me.Label_titulo = New System.Windows.Forms.Label()
        Me.PictureBox_ver = New System.Windows.Forms.PictureBox()
        Me.PictureBox_esconder = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_pin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_ver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_esconder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuProgressBar1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_admin)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_sair)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_entrar)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_pin)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_user)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_pin)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_user)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_titulo)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_ver)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_esconder)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(804, 501)
        Me.BunifuGradientPanel1.TabIndex = 25
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
        Me.BunifuProgressBar1.TabIndex = 66
        Me.BunifuProgressBar1.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(687, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 36)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Sobre"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Caixa_atm.My.Resources.Resources.menu__2_
        Me.PictureBox1.Location = New System.Drawing.Point(747, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'button_admin
        '
        Me.button_admin.BackColor = System.Drawing.Color.Transparent
        Me.button_admin.color = System.Drawing.Color.Transparent
        Me.button_admin.colorActive = System.Drawing.Color.Transparent
        Me.button_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_admin.Enabled = False
        Me.button_admin.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.button_admin.ForeColor = System.Drawing.Color.White
        Me.button_admin.Image = CType(resources.GetObject("button_admin.Image"), System.Drawing.Image)
        Me.button_admin.ImagePosition = 20
        Me.button_admin.ImageZoom = 50
        Me.button_admin.LabelPosition = 41
        Me.button_admin.LabelText = "Admin"
        Me.button_admin.Location = New System.Drawing.Point(0, 396)
        Me.button_admin.Margin = New System.Windows.Forms.Padding(6)
        Me.button_admin.Name = "button_admin"
        Me.button_admin.Size = New System.Drawing.Size(94, 111)
        Me.button_admin.TabIndex = 60
        '
        'button_sair
        '
        Me.button_sair.ActiveBorderThickness = 1
        Me.button_sair.ActiveCornerRadius = 20
        Me.button_sair.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.button_sair.ActiveForecolor = System.Drawing.Color.White
        Me.button_sair.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.button_sair.BackColor = System.Drawing.Color.Transparent
        Me.button_sair.BackgroundImage = CType(resources.GetObject("button_sair.BackgroundImage"), System.Drawing.Image)
        Me.button_sair.ButtonText = "Sair"
        Me.button_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_sair.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_sair.ForeColor = System.Drawing.Color.White
        Me.button_sair.IdleBorderThickness = 1
        Me.button_sair.IdleCornerRadius = 20
        Me.button_sair.IdleFillColor = System.Drawing.Color.Brown
        Me.button_sair.IdleForecolor = System.Drawing.Color.White
        Me.button_sair.IdleLineColor = System.Drawing.Color.White
        Me.button_sair.Location = New System.Drawing.Point(617, 440)
        Me.button_sair.Margin = New System.Windows.Forms.Padding(5)
        Me.button_sair.Name = "button_sair"
        Me.button_sair.Size = New System.Drawing.Size(169, 46)
        Me.button_sair.TabIndex = 58
        Me.button_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_entrar
        '
        Me.button_entrar.ActiveBorderThickness = 1
        Me.button_entrar.ActiveCornerRadius = 20
        Me.button_entrar.ActiveFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_entrar.ActiveForecolor = System.Drawing.Color.White
        Me.button_entrar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button_entrar.BackColor = System.Drawing.Color.Transparent
        Me.button_entrar.BackgroundImage = CType(resources.GetObject("button_entrar.BackgroundImage"), System.Drawing.Image)
        Me.button_entrar.ButtonText = "Entrar"
        Me.button_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_entrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_entrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.button_entrar.IdleBorderThickness = 1
        Me.button_entrar.IdleCornerRadius = 20
        Me.button_entrar.IdleFillColor = System.Drawing.Color.White
        Me.button_entrar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.button_entrar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.button_entrar.Location = New System.Drawing.Point(108, 340)
        Me.button_entrar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_entrar.Name = "button_entrar"
        Me.button_entrar.Size = New System.Drawing.Size(137, 41)
        Me.button_entrar.TabIndex = 25
        Me.button_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_pin
        '
        Me.TextBox_pin.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox_pin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_pin.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_pin.ForeColor = System.Drawing.Color.White
        Me.TextBox_pin.Location = New System.Drawing.Point(92, 299)
        Me.TextBox_pin.Name = "TextBox_pin"
        Me.TextBox_pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_pin.Size = New System.Drawing.Size(173, 34)
        Me.TextBox_pin.TabIndex = 24
        '
        'TextBox_user
        '
        Me.TextBox_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox_user.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_user.ForeColor = System.Drawing.Color.White
        Me.TextBox_user.Location = New System.Drawing.Point(92, 257)
        Me.TextBox_user.Name = "TextBox_user"
        Me.TextBox_user.Size = New System.Drawing.Size(173, 34)
        Me.TextBox_user.TabIndex = 23
        '
        'PictureBox_pin
        '
        Me.PictureBox_pin.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_pin.Image = Global.Caixa_atm.My.Resources.Resources.padlock1
        Me.PictureBox_pin.Location = New System.Drawing.Point(49, 299)
        Me.PictureBox_pin.Name = "PictureBox_pin"
        Me.PictureBox_pin.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox_pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_pin.TabIndex = 22
        Me.PictureBox_pin.TabStop = False
        '
        'PictureBox_user
        '
        Me.PictureBox_user.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_user.Image = Global.Caixa_atm.My.Resources.Resources.user2
        Me.PictureBox_user.Location = New System.Drawing.Point(49, 257)
        Me.PictureBox_user.Name = "PictureBox_user"
        Me.PictureBox_user.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_user.TabIndex = 21
        Me.PictureBox_user.TabStop = False
        '
        'Label_titulo
        '
        Me.Label_titulo.AutoSize = True
        Me.Label_titulo.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_titulo.ForeColor = System.Drawing.Color.White
        Me.Label_titulo.Location = New System.Drawing.Point(39, 97)
        Me.Label_titulo.Name = "Label_titulo"
        Me.Label_titulo.Size = New System.Drawing.Size(254, 112)
        Me.Label_titulo.TabIndex = 10
        Me.Label_titulo.Text = "Introduza " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "os dados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox_ver
        '
        Me.PictureBox_ver.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_ver.Image = Global.Caixa_atm.My.Resources.Resources.view
        Me.PictureBox_ver.Location = New System.Drawing.Point(271, 297)
        Me.PictureBox_ver.Name = "PictureBox_ver"
        Me.PictureBox_ver.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ver.TabIndex = 62
        Me.PictureBox_ver.TabStop = False
        '
        'PictureBox_esconder
        '
        Me.PictureBox_esconder.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_esconder.Image = Global.Caixa_atm.My.Resources.Resources.hide
        Me.PictureBox_esconder.Location = New System.Drawing.Point(271, 299)
        Me.PictureBox_esconder.Name = "PictureBox_esconder"
        Me.PictureBox_esconder.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox_esconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_esconder.TabIndex = 61
        Me.PictureBox_esconder.TabStop = False
        Me.PictureBox_esconder.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(751, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 32)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "X"
        Me.Label2.Visible = False
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(372, 55)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(353, 338)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 9
        Me.PictureBox_logo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "w"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_pin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_ver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_esconder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_titulo As Label
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents PictureBox_user As PictureBox
    Friend WithEvents PictureBox_pin As PictureBox
    Friend WithEvents TextBox_user As TextBox
    Friend WithEvents TextBox_pin As TextBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents button_entrar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_sair As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_admin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox_esconder As PictureBox
    Friend WithEvents PictureBox_ver As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Timer1 As Timer
End Class
