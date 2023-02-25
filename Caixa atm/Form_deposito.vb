
Imports Bunifu.Framework.UI

Public Class Form_deposito

    Dim i As Integer
    Public num_ut As Integer
    Private borderForm As New Form
    Dim pin As Integer


    Private Sub FormDeposito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do deposito?", "Sair de deposito", MessageBoxButtons.YesNo)

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

    Private Sub Form_deposito_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        saldo = clientes(Form_login.num_ut, 0)
        Label_conta.Text = Form_login.num_ut
        Label_saldo.Text = saldo & "$"
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_opçoes.Show()
    End Sub





    Private Sub Label16_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_opçoes.Show()
    End Sub



    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Timer1.Interval = 5
        Timer1.Start()


    End Sub



    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim result As DialogResult = MessageBox.Show("Tem a certeza que pretende sair do deposito?", "Sair de deposito", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            Form_opçoes.Show()
        ElseIf result = DialogResult.No Then
            ' Code to be executed if "No" button is clicked
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 1 'increment the value of the progress bar
        If BunifuProgressBar1.Value = 100 Then 'stop the timer when progress bar is filled
            Timer1.Stop()
            If Timer1.Enabled = False Then 'execute code when the timer stops
                Dim montante As Integer = Val(TextBox1.Text)
                If montante < 0 Or TextBox1.Text = "" Then
                    MsgBox("Montante invalido")
                    BunifuProgressBar1.Value = 0
                Else
                    clientes(Form_login.num_ut, 0) += Val(TextBox1.Text)
                    MsgBox("Dinheiro Depositado com sucesso!")
                    Me.Close()
                    Form_opçoes.Show()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class