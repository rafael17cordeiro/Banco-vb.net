Public Class Form_Desbloquear
    Private Sub FormDesbloquear_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            Dim num As Integer = Val(TextBox_num.Text)

            If num_block(num) = 0 Then
                MsgBox("Numero inserido nao esta bloqueiado")
                TextBox_num.Text = ""
            ElseIf num_block(num) <> 0 Then
                num_block(num) = 0
                MsgBox("Conta liberada com sucesso")
                Me.Close()
                Form_admin.Show()
            End If
        End If

        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do Desbloquear?", "Sair de deposito", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Close()
                Form_admin.Show()
            ElseIf result = DialogResult.No Then

            End If
        End If
    End Sub

    Private Sub Form_Desbloquear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 1 To LIM
            If i = num_block(i) Then
                TextBox_blockers.Text &= "Utilizador :" & num_block(i) & vbNewLine
            End If
        Next

        If TextBox_blockers.Text = "" Then
            TextBox_blockers.Text = "De Momento nenhuma conta suspendida"
            TextBox_num.Enabled = False
        End If


    End Sub



    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_sair.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do deposito?", "Sair de deposito", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_admin.Show()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_desbloquear.Click
        Dim num As Integer = Val(TextBox_num.Text)

        If num_block(num) = 0 Then
            MsgBox("Numero inserido nao esta bloqueiado")
            TextBox_num.Text = ""
        ElseIf num_block(num) <> 0 Then
            num_block(num) = 0
            MsgBox("Conta liberada com sucesso")
            clientes(num, 2) = 0
            Me.Close()
            Form_admin.Show()
        End If



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_num.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class