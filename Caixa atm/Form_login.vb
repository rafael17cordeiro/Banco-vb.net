
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Configuration

Module time
    Public currentDate As String = DateTime.Now.ToString("MM/dd/yyyy")
    Public currentHour As String = DateTime.Now.ToString("HH:mm:ss")
End Module

Module codigoAtm

    Public Const LIM As Integer = 20
    Public Const COL As Integer = 2
    Public erro As Integer = 1
    Public saldo As Double
    Public num_block(100) As Integer
    Public notas() As Integer = {100, 50, 20, 10, 5}
    Public clientes(LIM, COL) As Single
    Sub inciarClientes()
        For i = 0 To LIM
            clientes(i, 0) = 2000
            clientes(i, 1) = 1111
            clientes(i, 2) = 0
        Next
    End Sub
End Module



Public Class Form_login
    Private Sub FormLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            Dim checker_pin As Boolean = False
            Dim checker_ut As Boolean = False



            num_ut = Val(TextBox_user.Text)

            For i = 0 To LIM
                If num_ut = i Then
                    checker_ut = True
                    Exit For
                Else
                    checker_ut = False
                End If
            Next

            pin = Val(TextBox_pin.Text)
            If TextBox_pin.TextLength = 4 Then
                For i = 0 To LIM
                    If pin = clientes(i, 1) Then
                        checker_pin = True
                        Exit For
                    Else
                        checker_pin = False
                    End If
                Next
            End If
            If num_ut = 69 And pin = 6969 Then
                button_admin.Enabled = True
            End If





            If num_ut >= 0 And num_ut <= LIM Then
                If TextBox_user.Text = "" Or TextBox_pin.Text = "" Then
                    MsgBox("Preencha todos os espaços")

                ElseIf checker_ut = True And num_block(num_ut) <> num_ut And checker_pin = True Then

                    Timer1.Interval = 5
                    Timer1.Start()


                ElseIf checker_ut = True And checker_pin = False And clientes(num_ut, 2) < 3 Then
                    MsgBox("Pin não correspondente")
                    TextBox_pin.Text = ""
                    clientes(num_ut, 2) += 1
                    BunifuProgressBar1.Value = 0


                ElseIf checker_ut = False And checker_pin = True Then
                    MsgBox("Numero de utilizador não correspondete")
                    TextBox_user.Text = ""
                    TextBox_pin.Text = ""



                ElseIf num_ut <> 69 And pin <> 6969 And clientes(num_ut, 2) < 3 Then
                    MsgBox("Dados não correspondetes")
                    TextBox_user.Text = ""
                    TextBox_pin.Text = ""



                End If
            Else
                MsgBox("Numero de utilizador não correspondete")
                TextBox_user.Text = ""
                TextBox_pin.Text = ""
            End If


            If num_ut >= 0 And num_ut <= LIM Then
                    If clientes(num_ut, 2) = 3 Then
                        MsgBox("A sua conta foi bloqueada . Para recuperação da conta é necessario acesso administrativo")
                        num_block(num_ut) = num_ut
                        error_conter = 0
                    End If
                End If

            ElseIf e.KeyCode = 27 Then

                Form_avisoSair.Show()
        End If
    End Sub
    Public num_ut As Integer
    Dim error_conter As Integer = 0
    Dim i As Integer
    Private borderForm As New Form
    Public pin As Integer

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox_user.MaxLength = 2
        TextBox_pin.MaxLength = 4
        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With

        With borderForm
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .BackColor = Color.Black
            .Opacity = 0.25
            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show(Me)
        End With
        inciarClientes()


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles button_entrar.Click
        Dim checker_pin As Boolean = False
        Dim checker_ut As Boolean = False



        num_ut = Val(TextBox_user.Text)

        For i = 0 To LIM
            If num_ut = i Then
                checker_ut = True
                Exit For
            Else
                checker_ut = False
            End If
        Next

        pin = Val(TextBox_pin.Text)
        If TextBox_pin.TextLength = 4 Then
            For i = 0 To LIM
                If pin = clientes(i, 1) Then
                    checker_pin = True
                    Exit For
                Else
                    checker_pin = False
                End If
            Next
        End If
        If num_ut = 69 And pin = 6969 Then
            button_admin.Enabled = True
        End If





        If num_ut >= 0 And num_ut <= LIM Then
            If TextBox_user.Text = "" Or TextBox_pin.Text = "" Then
                MsgBox("Preencha todos os espaços")

            ElseIf checker_ut = True And num_block(num_ut) <> num_ut And checker_pin = True Then

                Timer1.Interval = 5
                Timer1.Start()


            ElseIf checker_ut = True And checker_pin = False And clientes(num_ut, 2) < 3 Then
                MsgBox("Pin não correspondente")
                TextBox_pin.Text = ""
                clientes(num_ut, 2) += 1
                BunifuProgressBar1.Value = 0


            ElseIf checker_ut = False And checker_pin = True Then
                MsgBox("Numero de utilizador não correspondete")
                TextBox_user.Text = ""
                TextBox_pin.Text = ""



            ElseIf num_ut <> 69 And pin <> 6969 And clientes(num_ut, 2) < 3 Then
                MsgBox("Dados não correspondetes")
                TextBox_user.Text = ""
                TextBox_pin.Text = ""



            End If
        Else
            MsgBox("Numero de utilizador não correspondete")
            TextBox_user.Text = ""
            TextBox_pin.Text = ""
        End If


        If num_ut >= 0 And num_ut <= LIM Then
            If clientes(num_ut, 2) = 3 Then
                MsgBox("A sua conta foi bloqueada . Para recuperação da conta é necessario acesso administrativo")
                num_block(num_ut) = num_ut
                error_conter = 0
            End If
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles button_sair.Click

        Form_avisoSair.Show()
    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox_ver.Click
        PictureBox_esconder.Visible = True
        PictureBox_ver.Visible = False
        TextBox_pin.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_esconder.Click
        PictureBox_esconder.Visible = False
        PictureBox_ver.Visible = True
        TextBox_pin.PasswordChar = "•"
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles button_admin.Click

        Form_admin.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        Label2.Visible = True
        Label1.Visible = True
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PictureBox1.Visible = True
        Label2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form_sobre.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 1
        If BunifuProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Timer1.Enabled = False Then
                Me.Hide()
                Form_opçoes.Show()
            End If
        End If

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_user.KeyPress, TextBox_pin.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class