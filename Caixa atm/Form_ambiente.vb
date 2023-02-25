Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 49 Then

            saldo = clientes(Form_login.num_ut, 0)

            MsgBox("Multibanco" & vbNewLine & "--------------------------------" & vbNewLine& & "Numero de utilizador : " & Form_login.num_ut & vbNewLine & "Saldo disponivel :" & saldo & "$" & vbNewLine & vbNewLine & "--------------------------------" & vbNewLine & "data : " & currentDate & vbNewLine & "Hora : " & currentHour)
            Me.Close()

            Form_opçoes.Show()
        ElseIf e.KeyCode = 50 Then
            Form_saldo.Show()
            Me.Close()
        End If

    End Sub

    Private borderForm As New Form
    ' estas function server para arredondar os cantos do formulario
    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Form2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_1.BackColor = Color.Black
        button_2.BackColor = Color.Black
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub


    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles button_1.Click

        saldo = clientes(Form_login.num_ut, 0)


        MsgBox("Multibanco" & vbNewLine & "--------------------------------" & vbNewLine& & "Numero de utilizador : " & Form_login.num_ut & vbNewLine & "Saldo disponivel :" & saldo & "$" & vbNewLine & vbNewLine & "--------------------------------" & vbNewLine & "data : " & currentDate & vbNewLine & "Hora : " & currentHour)
        Me.Close()

        Form_opçoes.Show()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles button_2.Click
        Form_saldo.Show()
        Me.Close()
    End Sub
End Class