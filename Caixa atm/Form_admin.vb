﻿Public Class Form_admin

    Private Sub Form_admin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 49 Then
            Me.Close()
            Form_Desbloquear.Show()
        ElseIf e.KeyCode = 50 Then
            Me.Close()
            Form_adminPin.Show()
        End If
        MsgBox(e.KeyData)
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

    Private Sub Form_admin_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        button_1.BackColor = Color.Black
        button_2.BackColor = Color.Black
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub
    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Me.Close()
        Form_login.Show()

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_2.Click
        Me.Close()
        Form_adminPin.Show()

    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles button_1.Click
        Me.Close()
        Form_Desbloquear.Show()
    End Sub
End Class