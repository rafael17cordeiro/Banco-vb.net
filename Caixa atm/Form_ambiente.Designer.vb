<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label_ambiente1 = New System.Windows.Forms.Label()
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.Label_ambiente2 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.button_2 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button_1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_ambiente1
        '
        Me.Label_ambiente1.AutoSize = True
        Me.Label_ambiente1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ambiente1.ForeColor = System.Drawing.Color.White
        Me.Label_ambiente1.Location = New System.Drawing.Point(12, 39)
        Me.Label_ambiente1.Name = "Label_ambiente1"
        Me.Label_ambiente1.Size = New System.Drawing.Size(415, 32)
        Me.Label_ambiente1.TabIndex = 0
        Me.Label_ambiente1.Text = "PRETENDE RECEBER UM TALÃO?"
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_logo.Image = Global.Caixa_atm.My.Resources.Resources.holding_hand__1_
        Me.PictureBox_logo.Location = New System.Drawing.Point(96, 110)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(197, 194)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 1
        Me.PictureBox_logo.TabStop = False
        '
        'Label_ambiente2
        '
        Me.Label_ambiente2.AutoSize = True
        Me.Label_ambiente2.BackColor = System.Drawing.Color.Transparent
        Me.Label_ambiente2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ambiente2.ForeColor = System.Drawing.Color.White
        Me.Label_ambiente2.Location = New System.Drawing.Point(350, 150)
        Me.Label_ambiente2.Name = "Label_ambiente2"
        Me.Label_ambiente2.Size = New System.Drawing.Size(277, 64)
        Me.Label_ambiente2.TabIndex = 2
        Me.Label_ambiente2.Text = "ANTES DE IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PENSE NO AMBIENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.button_2)
        Me.BunifuGradientPanel1.Controls.Add(Me.button_1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuThinButton23)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_ambiente2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox_logo)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label_ambiente1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.ForestGreen
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.ForestGreen
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.ForestGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(814, 509)
        Me.BunifuGradientPanel1.TabIndex = 23
        '
        'button_2
        '
        Me.button_2.ActiveBorderThickness = 1
        Me.button_2.ActiveCornerRadius = 30
        Me.button_2.ActiveFillColor = System.Drawing.Color.LightGreen
        Me.button_2.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button_2.ActiveLineColor = System.Drawing.Color.LightGreen
        Me.button_2.BackColor = System.Drawing.Color.Transparent
        Me.button_2.BackgroundImage = CType(resources.GetObject("button_2.BackgroundImage"), System.Drawing.Image)
        Me.button_2.ButtonText = "2"
        Me.button_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_2.ForeColor = System.Drawing.Color.SeaGreen
        Me.button_2.IdleBorderThickness = 1
        Me.button_2.IdleCornerRadius = 30
        Me.button_2.IdleFillColor = System.Drawing.Color.White
        Me.button_2.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.button_2.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.button_2.Location = New System.Drawing.Point(727, 389)
        Me.button_2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button_2.Name = "button_2"
        Me.button_2.Size = New System.Drawing.Size(60, 56)
        Me.button_2.TabIndex = 65
        Me.button_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_1
        '
        Me.button_1.ActiveBorderThickness = 1
        Me.button_1.ActiveCornerRadius = 30
        Me.button_1.ActiveFillColor = System.Drawing.Color.LightGreen
        Me.button_1.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button_1.ActiveLineColor = System.Drawing.Color.LightGreen
        Me.button_1.BackColor = System.Drawing.Color.Transparent
        Me.button_1.BackgroundImage = CType(resources.GetObject("button_1.BackgroundImage"), System.Drawing.Image)
        Me.button_1.ButtonText = "1"
        Me.button_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_1.ForeColor = System.Drawing.Color.SeaGreen
        Me.button_1.IdleBorderThickness = 1
        Me.button_1.IdleCornerRadius = 30
        Me.button_1.IdleFillColor = System.Drawing.Color.White
        Me.button_1.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.button_1.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.button_1.Location = New System.Drawing.Point(18, 389)
        Me.button_1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button_1.Name = "button_1"
        Me.button_1.Size = New System.Drawing.Size(59, 56)
        Me.button_1.TabIndex = 64
        Me.button_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 50
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Não"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 50
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.Location = New System.Drawing.Point(450, 383)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(371, 71)
        Me.BunifuThinButton21.TabIndex = 61
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 30
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Black
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Sim"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 30
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.Black
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton23.Location = New System.Drawing.Point(-23, 383)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(371, 71)
        Me.BunifuThinButton23.TabIndex = 61
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(803, 503)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_ambiente1 As Label
    Friend WithEvents PictureBox_logo As PictureBox
    Friend WithEvents Label_ambiente2 As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button_2 As Bunifu.Framework.UI.BunifuThinButton2
End Class
