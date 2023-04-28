Imports DataBase
Imports Modelo
Public Class L_DATOS_PERSONALES
    Dim DB_USUARIO As DBUsuario = New DBUsuario()
    Dim USUARIO As Usuario = New Usuario()
    Public Function OBTENER_DATOS() As Usuario
        '  Dim datos As List(Of String) = New List(Of String)()
        If ID_USUARIO_SESION <> Nothing Then
            USUARIO = DB_USUARIO.CONSULTAR(ID_USUARIO_SESION, "")
            Return USUARIO
        Else
            Return Nothing
        End If

    End Function
    Public Function VALIDAR_DATOS_LLENOS(TXT_ANTIGUA_CLAVE As String, TXT_NUEVA_CLAVE As String, TXT_CONFIRMAR As String) As Boolean
        If TXT_ANTIGUA_CLAVE <> "" And TXT_NUEVA_CLAVE <> "" And TXT_CONFIRMAR <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ACTUALIZAR_DATOS_PERSONALES(TXT_EMAIL As String, TXT_TELEFONO As Integer, FOTO As String)

        USUARIO = OBTENER_DATOS()

        Return DB_USUARIO.ACTUALIZAR(TXT_EMAIL, USUARIO.CLAVE, TXT_TELEFONO, USUARIO.ID_ROL, FOTO)
    End Function

    Public Function Actualizar_Clave(TXT_CLAVE_ANTIGUA As String, TXT_CLAVE_NUEVA As String, TXT_CLAVE_NUEVA_CONFIRMAR As String, ByRef Alerta_Estado As Integer) As Integer
        USUARIO = OBTENER_DATOS()
        Dim Login As DBLogin = New DBLogin()
        Dim pass_antigua = Login.Validar_Login(USUARIO.EMAIL, TXT_CLAVE_ANTIGUA)
        Select Case pass_antigua
            Case True
                If TXT_CLAVE_NUEVA_CONFIRMAR = TXT_CLAVE_NUEVA Then
                    Alerta_Estado = 1 'Alerta correcto
                    Return DB_USUARIO.ACTUALIZAR(USUARIO.EMAIL, TXT_CLAVE_NUEVA, USUARIO.TELEFONO, USUARIO.ID_ROL, USUARIO.FOTO)
                Else
                    Alerta_Estado = 2 'Alerta advertencia
                    Return False
                End If
            Case False
                Alerta_Estado = 3 'Alerta incorrecta
                Return False
        End Select
        Return False
    End Function


End Class
