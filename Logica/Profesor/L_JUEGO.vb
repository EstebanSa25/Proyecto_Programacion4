Imports DataBase
Imports Modelo
Public Class L_JUEGO
    Dim JUEGOdb As DBJuego = New DBJuego
    Public Function INSERTAR_POR_FECHA(Juego As String, Fecha_INICIO As String, HoraINICIO As String, FECHA_FIN As String, HoraFIN As String)
        Return JUEGOdb.INSERTAR(Juego, ID_USUARIO_SESION, Fecha_INICIO, HoraINICIO, FECHA_FIN, HoraFIN, 0)
    End Function
    Public Function INSERTAR_POR_VISIBLIDAD(Juego As String, VISIBLE As Integer)
        Return JUEGOdb.INSERTAR(Juego, ID_USUARIO_SESION, Nothing, Nothing, Nothing, Nothing, VISIBLE)
    End Function
    Public Function CONSULTAR_POR_ID() As List(Of FORMULARIO)
        Return JUEGOdb.CONSULTAR(ID_USUARIO_SESION, "", Nothing)
    End Function
    Public Function CONSULTAR_POR_ID_JUEGO(ID_JUEGO As Integer) As List(Of FORMULARIO)
        Return JUEGOdb.CONSULTAR(Nothing, Nothing, ID_JUEGO)
    End Function
    Public Function CONSULTAR_POR_JUEGO_IDUSUARIO(Juego As String) As FORMULARIO
        Return JUEGOdb.CONSULTAR_FILTRADA(ID_USUARIO_SESION, Juego)
    End Function
    Public Function BORRAR(ID_JUEGO As Integer) As Boolean
        Return JUEGOdb.BORRAR(ID_JUEGO)
    End Function
    Public Function ACTUALIZAR(JUEGO As String, FECHA_INICIO As String, HORA_INICIO As String, FECHA_FIN As String, HORA_FIN As String, VISIBILIDAD As Integer, ID_JUEGO As Integer) As Boolean
        Return JUEGOdb.ACTUALIZAR(JUEGO, FECHA_INICIO, HORA_INICIO, FECHA_FIN, HORA_FIN, VISIBILIDAD, ID_JUEGO)
    End Function
    Public Function INSERTAR_JUEGO(C_Visibilidad As String, Combo_configuracion As String, txtJUEGO As String, FECHA_INICIO() As String, HoraINICIO As String, FECHA_FIN() As String, HoraFIN As String) As List(Of String)
        Dim visibility As Integer
        Dim lista As List(Of String) = New List(Of String)
        If C_Visibilidad = "Visible" Then
            visibility = 1
        Else
            visibility = 0
        End If

        If Combo_configuracion = "Configurar visibilidad manualmente" Then
            If MsgBox("¿Deseas crear el juego?", vbInformation + vbYesNo, "ok") = vbYes Then

                If INSERTAR_POR_VISIBLIDAD(txtJUEGO, visibility) = True Then
                    lista.Add("ok")
                Else
                    lista.Add("error")
                End If
            Else
                lista.Add("error-crear")
            End If
        Else
            If MsgBox("¿Deseas crear el juego?", vbInformation + vbYesNo, "ok") = vbYes Then

                If INSERTAR_POR_FECHA(txtJUEGO, $"{FECHA_INICIO(0)}-{FECHA_INICIO(1)}-{FECHA_INICIO(2)}", HoraINICIO, $"{FECHA_FIN(0)}-{FECHA_FIN(1)}-{FECHA_FIN(2)}", HoraFIN) = True Then
                    lista.Add("ok")
                Else
                    lista.Add("error")
                End If
            Else
                lista.Add("error-crear")
            End If
        End If
        Return lista
    End Function

    Public Function VALIDAR_FECHA_NULL(ByRef lst As List(Of FORMULARIO), lst_elementos() As Boolean)
        If lst.First.FECHA_INICIO = "01/01/0001 0:00:00" Then
            For i = 0 To lst_elementos.Length - 1
                lst_elementos(i) = False
            Next
            Return True
        Else
            Return False
        End If
    End Function
End Class
