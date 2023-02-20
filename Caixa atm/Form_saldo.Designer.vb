<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_saldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_saldo))
        Me.Label_num = New System.Windows.Forms.Label()
        Me.Label_saldo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_hora = New System.Windows.Forms.Label()
        Me.Label_data = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.button_voltar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_num
        '
        Me.Label_num.AutoSize = True
        Me.Label_num.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_num.ForeColor = System.Drawing.Color.White
        Me.Label_num.Location = New System.Drawing.Point(24, 134)
        Me.Label_num.Name = "Label_num"
        Me.Label_num.Size = New System.Drawing.Size(205, 25)
        Me.Label_num.TabIndex = 1
        Me.Label_num.Text = "Numero da conta :"
        '
        'Label_saldo
        '
        Me.Label_saldo.AutoSize = True
        Me.Label_saldo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_saldo.ForeColor = System.Drawing.Color.White
        Me.Label_saldo.Location = New System.Drawing.Point(24, 174)
        Me.Label_saldo.Name = "Label_saldo"
        Me.Label_saldo.Size = New System.Drawing.Size(190, 25)
        Me.Label_saldo.TabIndex = 2
        Me.Label_saldo.Text = "Saldo disponivel :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 28)
        Me.Label5.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(795, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "---------------------------------------------------------------------------------" &
    "------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label_hora
        '
        Me.Label_hora.AutoSize = True
        Me.Label_hora.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_hora.ForeColor = System.Drawing.Color.White
        Me.Label_hora.Location = New System.Drawing.Point(26, 318)
        Me.Label_hora.Name = "Label_hora"
        Me.Label_hora.Size = New System.Drawing.Size(72, 25)
        Me.Label_hora.TabIndex = 8
        Me.Label_hora.Text = "Hora :"
        '
        'Label_data
        '
        Me.Label_data.AutoSize = True
        Me.Label_data.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_data.ForeColor = System.Drawing.Color.White
        Me.Label_data.Location = New System.Drawing.Point(26, 278)
        Me.Label_data.Name = "Label_data"
        Me.Label_data.Size = New System.Drawing.Size(79, 25)
        Me.Label_data.TabIndex = 7
        Me.Label_data.Text = "Data : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(444, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 28)
        Me.Label10.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(218, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Saldo disponivel :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(229, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Numero da conta :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(102, 318)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 24)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "HORA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(102, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "DATA"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_voltar)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label4)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label13)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label11)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label14)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_saldo)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_num)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_hora)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label12)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_data)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(805, 505)
        Me.BunifuGradientPanel1.TabIndex = 30
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.earth
        Me.PictureBox_logo.Location = New System.Drawing.Point(708, 12)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 63
        Me.PictureBox_logo.TabStop = False
        '
        'button_voltar
        '
        Me.button_voltar.ActiveBorderThickness = 1
        Me.button_voltar.ActiveCornerRadius = 20
        Me.button_voltar.ActiveFillColor = System.Drawing.Color.Goldenrod
        Me.button_voltar.ActiveForecolor = System.Drawing.Color.White
        Me.button_voltar.ActiveLineColor = System.Drawing.Color.Goldenrod
        Me.button_voltar.BackColor = System.Drawing.Color.Transparent
        Me.button_voltar.BackgroundImage = CType(resources.GetObject("button_voltar.BackgroundImage"), System.Drawing.Image)
        Me.button_voltar.ButtonText = "Voltar"
        Me.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_voltar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_voltar.ForeColor = System.Drawing.Color.White
        Me.button_voltar.IdleBorderThickness = 1
        Me.button_voltar.IdleCornerRadius = 20
        Me.button_voltar.IdleFillColor = System.Drawing.Color.Goldenrod
        Me.button_voltar.IdleForecolor = System.Drawing.Color.White
        Me.button_voltar.IdleLineColor = System.Drawing.Color.White
        Me.button_voltar.Location = New System.Drawing.Point(617, 440)
        Me.button_voltar.Margin = New System.Windows.Forms.Padding(5)
        Me.button_voltar.Name = "button_voltar"
        Me.button_voltar.Size = New System.Drawing.Size(169, 46)
        Me.button_voltar.TabIndex = 58
        Me.button_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_saldo
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
        Me.Name = "Form_saldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "b"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_num As Label
    Friend WithEvents Label_saldo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_hora As Label
    Friend WithEvents Label_data As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents button_voltar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
