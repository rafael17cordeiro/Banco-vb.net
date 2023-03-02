Public Class Form_adminPin



    Private Sub FormAdmPin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            Dim num_ut As Integer
            Dim checker_ut As Boolean = False
            Dim pin As Integer = Val(TextBox_pin.Text)

            num_ut = Val(TextBox_num.Text)
            For i = 0 To LIM
                If num_ut = i Then
                    checker_ut = True
                    Exit For
                Else
                    checker_ut = False
                End If
            Next

            If checker_ut = False Or TextBox_num.Text = "" Or num_ut = 0 Then
                MsgBox("Numero de utilizador ivalido")
                TextBox_num.Text = ""
                TextBox_pin.Text = ""
                TextBox_confirmar.Text = ""
            ElseIf checker_ut = True Then

                If Val(TextBox_pin.Text) <> Val(TextBox_confirmar.Text) Then
                    MsgBox("Os pins inseridos não são iguais")
                ElseIf pin = Form_login.pin Then
                    MsgBox("O novo pin não pode ser o pin atual")
                    TextBox_pin.Text = ""
                    TextBox_confirmar.Text = ""

                Else

                    clientes(num_ut, 1) = pin 'probs reis que ajudou 


                    MsgBox("Multibanco" & vbNewLine & "--------------------------------" & vbNewLine & "Pin alterado com sucesso")
                    Me.Close()
                    Form_admin.Show()
                End If

            End If


        End If

        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do alterar pin?", "Sair de deposito", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Close()
                Form_admin.Show()
            ElseIf result = DialogResult.No Then

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

    Private Sub Form_adminPin_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_adminPin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_pin.MaxLength = 4
        TextBox_confirmar.MaxLength = 4
        inciarClientes()
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_alterar.Click
        Dim num_ut As Integer
        Dim checker_ut As Boolean = False
        Dim pin As Integer = Val(TextBox_pin.Text)

        num_ut = Val(TextBox_num.Text)
        For i = 0 To LIM
            If num_ut = i Then
                checker_ut = True
                Exit For
            Else
                checker_ut = False
            End If
        Next

        If checker_ut = False Or TextBox_num.Text = "" Or num_ut = 0 Then
            MsgBox("Numero de utilizador ivalido")
            TextBox_num.Text = ""
            TextBox_pin.Text = ""
            TextBox_confirmar.Text = ""
        ElseIf checker_ut = True Then

            If Val(TextBox_pin.Text) <> Val(TextBox_confirmar.Text) Then
                MsgBox("Os pins inseridos não são iguais")
            ElseIf pin = Form_login.pin Then
                MsgBox("O novo pin não pode ser o pin atual")
                TextBox_pin.Text = ""
                TextBox_confirmar.Text = ""

            Else

                clientes(num_ut, 1) = pin


                MsgBox("Multibanco" & vbNewLine & "--------------------------------" & vbNewLine & "Pin alterado com sucesso")
                Me.Close()
                Form_admin.Show()
            End If

        End If

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do Desbloquear?", "Sair de deposito", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Form_admin.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_num.KeyPress, TextBox_pin.KeyPress, TextBox_confirmar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class