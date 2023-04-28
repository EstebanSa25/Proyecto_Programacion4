Imports System.Drawing.Text
Imports System.IO
Imports DataBase
Imports Logica
Imports Newtonsoft.Json

Public Class Login2

    Dim appSettings As AppSettings

    Public l_login As L_LOGIN = New L_LOGIN()
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Ruta_aplicacionDB = Application.StartupPath
        appSettings = JsonConvert.DeserializeObject(Of AppSettings)(File.ReadAllText($"{Ruta_aplicacionDB}\appsettings.json"))
        TXT_CORREO.Text = appSettings.Correo
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            End
            Application.Exit()
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub



    Private Sub BTN_REGISTRO_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRO.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub BTN_INGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_INGRESAR.Click
        Select Case l_login.Validar_Login(TXT_CORREO.Text, TXT_CLAVE.Text, BTN_ACORDARSE.Checked, appSettings)
            Case 0
                MsgBox("Error")
            Case 1
                MenuJugador.Close()
                MenuJugador.Show()
                Me.Hide()
            Case 2
                Menu_profesor.Close()
                Menu_profesor.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles BTN_ACORDARSE.CheckedChanged

    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs) Handles TXT_CORREO.TextChanged
        If l_login.VALIDAR_DATOS(TXT_CORREO.Text, TXT_CLAVE.Text) Then
            BTN_INGRESAR.Enabled = True
        Else
            BTN_INGRESAR.Enabled = False
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        '  Transicion_guna.Formulario_a_mostrar = Menu_profesor
        ' Transicion_guna.Show()
    End Sub

    Private Sub BTN_ALERTA_Click(sender As Object, e As EventArgs)
        Dim Alerta As ALERTAS_POPUP = New ALERTAS_POPUP()
        ' Alerta.EJECUTAR_ALERTA("Hola", "Hola2")
        ALERTAS_POPUP.EJECUTAR_ALERTA("Hola", "Usuario creado correctamente", 3)
        Transicion_guna.ShowSync(ALERTAS_POPUP)
        ALERTAS_POPUP.Show()

    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        If l_login.VALIDAR_DATOS(TXT_CORREO.Text, TXT_CLAVE.Text) Then
            BTN_INGRESAR.Enabled = True
        Else
            BTN_INGRESAR.Enabled = False
        End If
    End Sub
End Class