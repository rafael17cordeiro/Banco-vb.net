<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Desbloquear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Desbloquear))
        Me.TextBox_blockers = New System.Windows.Forms.TextBox()
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.button_sair = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button_desbloquear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox_num = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_num = New System.Windows.Forms.Label()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_blockers
        '
        Me.TextBox_blockers.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBox_blockers.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_blockers.ForeColor = System.Drawing.Color.White
        Me.TextBox_blockers.Location = New System.Drawing.Point(548, 170)
        Me.TextBox_blockers.Multiline = True
        Me.TextBox_blockers.Name = "TextBox_blockers"
        Me.TextBox_blockers.Size = New System.Drawing.Size(231, 255)
        Me.TextBox_blockers.TabIndex = 65
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(722, 50)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 64
        Me.PictureBox_logo.TabStop = False
        '
        'button_sair
        '
        Me.button_sair.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
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
        Me.button_sair.IdleFillColor = System.Drawing.Color.Firebrick
        Me.button_sair.IdleForecolor = System.Drawing.Color.White
        Me.button_sair.IdleLineColor = System.Drawing.Color.White
        Me.button_sair.Location = New System.Drawing.Point(466, 478)
        Me.button_sair.Margin = New System.Windows.Forms.Padding(5)
        Me.button_sair.Name = "button_sair"
        Me.button_sair.Size = New System.Drawing.Size(162, 46)
        Me.button_sair.TabIndex = 63
        Me.button_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_desbloquear
        '
        Me.button_desbloquear.ActiveBorderThickness = 1
        Me.button_desbloquear.ActiveCornerRadius = 20
        Me.button_desbloquear.ActiveFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_desbloquear.ActiveForecolor = System.Drawing.Color.White
        Me.button_desbloquear.ActiveLineColor = System.Drawing.Color.MediumSeaGreen
        Me.button_desbloquear.BackColor = System.Drawing.Color.Transparent
        Me.button_desbloquear.BackgroundImage = CType(resources.GetObject("button_desbloquear.BackgroundImage"), System.Drawing.Image)
        Me.button_desbloquear.ButtonText = "Desbloquear"
        Me.button_desbloquear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_desbloquear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_desbloquear.ForeColor = System.Drawing.Color.White
        Me.button_desbloquear.IdleBorderThickness = 1
        Me.button_desbloquear.IdleCornerRadius = 20
        Me.button_desbloquear.IdleFillColor = System.Drawing.Color.MediumSeaGreen
        Me.button_desbloquear.IdleForecolor = System.Drawing.Color.White
        Me.button_desbloquear.IdleLineColor = System.Drawing.Color.White
        Me.button_desbloquear.Location = New System.Drawing.Point(638, 478)
        Me.button_desbloquear.Margin = New System.Windows.Forms.Padding(5)
        Me.button_desbloquear.Name = "button_desbloquear"
        Me.button_desbloquear.Size = New System.Drawing.Size(162, 46)
        Me.button_desbloquear.TabIndex = 62
        Me.button_desbloquear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_num
        '
        Me.TextBox_num.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_num.Location = New System.Drawing.Point(272, 208)
        Me.TextBox_num.Multiline = True
        Me.TextBox_num.Name = "TextBox_num"
        Me.TextBox_num.Size = New System.Drawing.Size(231, 28)
        Me.TextBox_num.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(584, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 28)
        Me.Label10.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 28)
        Me.Label5.TabIndex = 62
        '
        'Label_num
        '
        Me.Label_num.AutoSize = True
        Me.Label_num.BackColor = System.Drawing.Color.Transparent
        Me.Label_num.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_num.ForeColor = System.Drawing.Color.White
        Me.Label_num.Location = New System.Drawing.Point(61, 211)
        Me.Label_num.Name = "Label_num"
        Me.Label_num.Size = New System.Drawing.Size(205, 25)
        Me.Label_num.TabIndex = 49
        Me.Label_num.Text = "Número da conta :"
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
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_blockers)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_sair)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_desbloquear)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuTextbox3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-14, -38)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(823, 538)
        Me.BunifuGradientPanel1.TabIndex = 64
        '
        'BunifuTextbox3
        '
        Me.BunifuTextbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox3.BackgroundImage = CType(resources.GetObject("BunifuTextbox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox3.Enabled = False
        Me.BunifuTextbox3.ForeColor = System.Drawing.Color.White
        Me.BunifuTextbox3.Icon = CType(resources.GetObject("BunifuTextbox3.Icon"), System.Drawing.Image)
        Me.BunifuTextbox3.Location = New System.Drawing.Point(25, 198)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(492, 51)
        Me.BunifuTextbox3.TabIndex = 74
        Me.BunifuTextbox3.text = ""
        '
        'Form_Desbloquear
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
        Me.Name = "Form_Desbloquear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Desbloquear"
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_blockers As TextBox
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents button_sair As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_desbloquear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox_num As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_num As Label
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
End Class
