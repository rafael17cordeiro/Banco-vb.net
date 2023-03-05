Public Class Form_pagamentos

    Private Sub Form_pagamentos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair dos pagamentos?", "Sair de Pagamentos", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Me.Close()
                Form_opçoes.Show()
            ElseIf result = DialogResult.No Then

            End If
        End If

        If e.KeyCode = 13 Then
            Timer1.Interval = 5
            Timer1.Start()

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

    Private Sub Form_pagamentos_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_pagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saldo = clientes(Form_login.num_ut, 0)
        Label12.Text = Form_login.num_ut
        Label11.Text = saldo & "$"


        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With



    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair dos pagamentos?", "Sair de deposito", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_opçoes.Show()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_pagar.Click
        Timer1.Interval = 5
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 1
        If BunifuProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Timer1.Enabled = False Then 
                If Val(TextBox_montante.Text) > saldo Then
                    MsgBox("Não têm denheiro suficiente")
                    BunifuProgressBar1.Value = 0
                ElseIf TextBox_montante.Text = "" And TextBox_referencia.Text = "" Then
                    MsgBox("dados invalidos")
                    BunifuProgressBar1.Value = 0
                Else
                    clientes(Form_login.num_ut, 0) -= Val(TextBox_montante.Text)
                    MsgBox("Pagamento executado com sucesso!")
                    Me.Close()
                    Form_opçoes.Show()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_referencia.KeyPress, TextBox_montante.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class