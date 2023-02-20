Public Class Form_Desbloquear
    Private Sub Form_Desbloquear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 1 To LIM
            If i = num_block(i) Then
                TextBox_blockers.Text &= "Utilizador :" & num_block(i) & vbNewLine
            End If

        Next




    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_sair.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do deposito?", "Sair de deposito", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_admin.Show()
        ElseIf result = DialogResult.No Then
            ' Code to be executed if "No" button is clicked
        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_desbloquear.Click
        Dim num As Integer = Val(TextBox_num.Text)
        num_block(num) = 0
        MsgBox("Conta liberada com sucesso")
        Me.Close()
        Form_admin.Show()
    End Sub
End Class