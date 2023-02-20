Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_levantamentos
    Private Sub Form_levantamentos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do levantamento?", "Sair de deposito", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Me.Close()
                Form_opçoes.Show()
            ElseIf result = DialogResult.No Then

            End If
        End If
        If e.KeyCode = 13 Then
            Dim montante As Integer = Val(TextBox_montante.Text)
            If montante < 0 Or montante > saldo Or TextBox_montante.Text = "" Or montante Mod 5 Then
                MsgBox("Montante invalido")
            Else
                clientes(Form_login.num_ut, 0) -= Val(TextBox_montante.Text)
                MsgBox("Dinheiro levantado com sucesso!")
                Me.Close()
                Form_opçoes.Show()
            End If
        End If

    End Sub
    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Form_levantamentos_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_levantamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saldo = clientes(Form_login.num_ut, 0)
        Label_num.Text = Form_login.num_ut
        Label_saldo.Text = saldo & "$"



        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles button_levantar.Click
        Dim montante As Integer = Val(TextBox_montante.Text)
        If montante < 0 Or montante > saldo Or TextBox_montante.Text = "" Or montante Mod 5 Then
            MsgBox("Montante invalido")
        Else
            clientes(Form_login.num_ut, 0) -= Val(TextBox_montante.Text)
            MsgBox("Dinheiro levantado com sucesso!")
            Me.Close()
            Form_opçoes.Show()
        End If

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do Levantamento?", "Sair de deposito", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_opçoes.Show()
        ElseIf result = DialogResult.No Then
            ' Code to be executed if "No" button is clicked
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class