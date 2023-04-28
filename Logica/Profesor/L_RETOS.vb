Imports DataBase
Imports Modelo
Public Class L_RETOS
    Public DB As DBRETO = New DBRETO
    Public LOGICA_OPCIONES As L_OPCIONES_RETOS = New L_OPCIONES_RETOS
    Public Function CONSULTAR(ID_RETO As Integer, ID_PREGUNTA As Integer) As List(Of Retos)
        Try
            Return DB.CONSULTAR(ID_RETO, ID_PREGUNTA)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function BORRAR(ID_RETO As Integer)
        Return DB.BORRAR(ID_RETO)
    End Function
    Public Sub INSERTAR(ID_CATEGORIA As Integer, RETO As String, ID_PREGUNTA As Integer, PUNTO As Integer, TIEMPO As Double, FOTO As String, VIDEO As String, AUDIO As String, EXTENSION As String)
        DB.INSERTAR(ID_CATEGORIA, RETO, ID_PREGUNTA, PUNTO, TIEMPO, FOTO, VIDEO, AUDIO, EXTENSION)
    End Sub
    Public Function ACTUALIZAR(ID_CATEGORIA As Integer, RETO As String, PUNTO As Integer, TIEMPO As Double, FOTO As String, VIDEO As String, AUDIO As String, ID_RETO As Integer, EXTENSION As String)
        Return DB.ACTUALIZAR(ID_CATEGORIA, RETO, PUNTO, TIEMPO, FOTO, VIDEO, AUDIO, ID_RETO, EXTENSION)
    End Function

    Public Function INSERTAR_EDITAR_RETO_OPCIONES(Checkboxs() As Boolean, ID_CATEGORIA As Integer, Pregunta As String, Puntos As Integer, Tiempo As Integer, respuestas() As String, Procedimiento As Integer, ID_PREGUNTA_F As Integer, video As String, EXTENSION As String, foto As String, Audio As String, ID_RETO As Integer) As Boolean

        If Procedimiento = 4 Then

            INSERTAR(ID_CATEGORIA, Pregunta, ID_PREGUNTA_F, CInt(Puntos), Tiempo, foto, video, Audio, EXTENSION)

            Dim LST_RETOS As List(Of Retos) = CONSULTAR(Nothing, ID_PREGUNTA_F)
            LOGICA_OPCIONES.INSERTAR(LST_RETOS.First.ID_RETO, respuestas(0), Checkboxs(0))
            LOGICA_OPCIONES.INSERTAR(LST_RETOS.First.ID_RETO, respuestas(1), Checkboxs(1))
            LOGICA_OPCIONES.INSERTAR(LST_RETOS.First.ID_RETO, respuestas(2), Checkboxs(2))
            LOGICA_OPCIONES.INSERTAR(LST_RETOS.First.ID_RETO, respuestas(3), Checkboxs(3))
            Return True
        Else

            ACTUALIZAR(ID_CATEGORIA, Pregunta, Puntos, Tiempo, foto, video, Audio, ID_RETO, EXTENSION)
            Dim lst = LOGICA_OPCIONES.CONSULTAR(ID_RETO)
            Dim contador As Integer = 0
            For Each datos In lst
                LOGICA_OPCIONES.ACTUALIZAR(respuestas(contador), Checkboxs(contador), datos.ID_OPCIONES_RETOS)
                contador += 1
            Next
            Return True
        End If
        Return False
    End Function
End Class
