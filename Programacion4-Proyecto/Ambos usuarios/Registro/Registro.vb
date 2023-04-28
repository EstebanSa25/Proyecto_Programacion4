Imports System.IO
Imports DataBase
Imports Modelo
Imports Logica
Public Class Registro

    Dim NUEVO As Boolean
    Dim ID As Integer
    Dim Foto As Byte()
    Dim Usuario_db As Usuario = New Usuario
    Dim FOTO_DEFINICION As Boolean = False
    Public l_registro As L_REGISTRO = New L_REGISTRO()
    'Dim usuarioDB As DBUsuario = New DBUsuario

    Public Sub Validaciones()
        If l_registro.VALIDAR_DATOS(TXT_CORREO.Text, TXT_CLAVE.Text, TXT_TELEFONO.Text, TXT_ROL.Text, FOTO_DEFINICION, NOMBRE.Text) Then
            BTN_REGISTRO.Enabled = True
        Else
            BTN_REGISTRO.Enabled = False
        End If
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Validaciones()
    End Sub

    Private Sub Usuario_TextChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub

    Private Sub RegistroButtom_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRO.Click

        If l_registro.INSERTAR(TXT_CORREO.Text, TXT_CLAVE.Text, TXT_TELEFONO.Text, TXT_ROL.Text, Imagen_string1(FOTO_PERSONA.Image), NOMBRE.Text) Then
            MsgBox("Registro completado")
            Login2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub

    Private Sub Correo_TextChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub

    Private Sub Contra_TextChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub

    Private Sub Id_rol_SelectedIndexChanged(sender As Object, e As EventArgs)
        Validaciones()
    End Sub


    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ROL.SelectedIndexChanged
        If L_ROL.Text = "" Then
            L_ROL.Show()
        End If
        Validaciones()
    End Sub
    Private Sub Guna2ComboBox1_click(sender As Object, e As EventArgs) Handles TXT_ROL.Click
        L_ROL.Hide()
    End Sub

    Private Sub BTN_LOGIN_Click(sender As Object, e As EventArgs) Handles BTN_LOGIN.Click
        Me.Close()
        Login2.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Login2.Close()
    End Sub

    Private Sub FOTO_PERSONA_Click(sender As Object, e As EventArgs) Handles FOTO_PERSONA.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            FOTO_PERSONA.Image = Image.FromFile(ABRIR.FileName)
            FOTO_DEFINICION = True
        Else
            FOTO_DEFINICION = False
        End If
        Validaciones()
    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CORREO.TextChanged
        Validaciones()
    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        Validaciones()
    End Sub

    Private Sub TXT_TELEFONO_TextChanged(sender As Object, e As EventArgs) Handles TXT_TELEFONO.TextChanged
        If TXT_TELEFONO.Text <> "" Then


            If IsNumeric(TXT_TELEFONO.Text) <> True Or TXT_TELEFONO.Text.Contains(".") Or TXT_TELEFONO.Text.Contains(",") Then
                MsgBox("Solo se aceptan campos numericos")
                TXT_TELEFONO.Text = ""
            End If
        End If
        Validaciones()
    End Sub

    Private Sub NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE.TextChanged
        Validaciones()
    End Sub
End Class