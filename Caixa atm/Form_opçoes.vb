Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form_opçoes
    Private Sub Form_opçoes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 49 Then
            Form_levantamentos.Show()
            Me.Hide()
        ElseIf e.KeyCode = 50 Then
            Form_deposito.Show()
            Me.Hide()
        ElseIf e.KeyCode = 51 Then
            Form2.Show()
            Me.Hide()
        ElseIf e.KeyCode = 52 Then
            Form_transferir.Show()
            Me.Hide()
        ElseIf e.KeyCode = 53 Then
            Form_pagamentos.Show()
            Me.Hide()
        ElseIf e.KeyCode = 54 Then
            Me.Hide()
            form_alterarPin.Show()
        ElseIf e.KeyCode = 27 Then
            Form_avisoSair.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub opçoes_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
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

    Private Sub Form3_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_2.BackColor = Color.Black
        button_1.BackColor = Color.Black
        button_4.BackColor = Color.Black
        button_3.BackColor = Color.Black
        button_5.BackColor = Color.Black
        button_6.BackColor = Color.Black
        inciarClientes()
        Dim user As Integer = Val(Form_login.TextBox_user.Text)
        With Me
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_login.Close()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Form_deposito.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_login.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form_transferir.Show()

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles button_sair.Click

        Form_avisoSair.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles button_2.Click
        Form_deposito.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton210_Click(sender As Object, e As EventArgs) Handles button_3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs) Handles button_4.Click
        Form_transferir.Show()
        Me.Hide()
    End Sub



    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles button_5.Click
        Form_pagamentos.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles button_1.Click
        Form_levantamentos.Show()
        Me.Hide()

    End Sub



    Private Sub BunifuThinButton213_Click(sender As Object, e As EventArgs) Handles button_6.Click
        Me.Hide()
        form_alterarPin.show
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class