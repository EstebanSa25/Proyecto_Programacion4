Imports System.IO
Imports DataBase
Imports Modelo
Imports Newtonsoft.Json

Public Class L_LOGIN
    Public Function Validar_Login(txt_Correo As String, txt_Clave As String, BTN_ACORDARSE As Boolean, appSettings As AppSettings) As Integer
        T.Clear()
        Dim consulta_login As DBLogin = New DBLogin
        Dim Usuario As Usuario = New Usuario
        Dim Login_validacion As Boolean
        Dim DBUsuario As DBUsuario = New DBUsuario

        Login_validacion = consulta_login.Validar_Login(txt_Correo, txt_Clave)
        If Login_validacion.Equals(True) Then
            Usuario = DBUsuario.CONSULTAR(0, txt_Correo)
            ID_USUARIO_SESION = Usuario.ID_USUARIO

            If BTN_ACORDARSE <> True Then
                LIMPIAR(txt_Correo, txt_Clave)
            Else
                appSettings.Correo = txt_Correo
                Dim json As String = JsonConvert.SerializeObject(appSettings)
                File.WriteAllText($"{Ruta_aplicacionDB}\appsettings.json", json)

            End If
            Return Usuario.ID_ROL
        Else
            Return 0
        End If
    End Function

    Public Function LIMPIAR(ByVal TXT_CORREO As String, ByVal TXT_CLAVE As String) As String
        Return Nothing
    End Function
    Public Function VALIDAR_DATOS(EMAIL As String, CLAVE As String)
        If EMAIL <> "" And CLAVE <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
