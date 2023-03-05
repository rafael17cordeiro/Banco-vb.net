Public Class Form_transferir

    Private Sub FormTransferir_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair da Transferencia?", "Sair de deposito", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Me.Close()
                Form_opçoes.Show()
            ElseIf result = DialogResult.No Then
                ' Code to be executed if "No" button is clicked
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

    Private Sub Form_transferir_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_transferir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        saldo = clientes(Form_login.num_ut, 0)


        Label12.Text = Form_login.num_ut
        Label11.Text = saldo & "$"
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_opçoes.Show()

    End Sub



    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        MsgBox("Cancelar transferencia ?" & vbYesNo & vbQuestion)
        If vbYes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub





    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair da Transferencia?", "Sair de transferencia", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_opçoes.Show()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_transferir.Click
        Timer1.Interval = 5
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 1
        If BunifuProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Timer1.Enabled = False Then
                Dim iban As Integer = Val(TextBox_iban.Text)
                Dim montante As Integer = Val(TextBox_montante.Text)
                Dim checker_ut As Boolean = False

                For i = 0 To LIM
                    If iban = i Then
                        checker_ut = True
                        Exit For
                    Else
                        checker_ut = False
                    End If
                Next

                If checker_ut = False Or TextBox_iban.Text = "" Or Val(TextBox_iban.Text) = 0 Or iban = Form_login.num_ut Then
                    MsgBox("O numero de iban inserido não é válido")
                    BunifuProgressBar1.Value = 0
                ElseIf montante < 0 Then
                    MsgBox("Não é possivel fazer transferências negativas")
                    BunifuProgressBar1.Value = 0
                ElseIf montante > saldo Then
                    MsgBox("Não tem saldo suficiente")
                    BunifuProgressBar1.Value = 0
                ElseIf TextBox_montante.Text = "" Then
                    MsgBox("Montante invalidado")
                    BunifuProgressBar1.Value = 0
                Else

                    clientes(Form_login.num_ut, 0) -= montante

                    clientes(iban, 0) += montante

                    MsgBox("Transferência executado com sucesso!")
                    Me.Close()
                    Form_opçoes.Show()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_iban.KeyPress, TextBox_montante.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class