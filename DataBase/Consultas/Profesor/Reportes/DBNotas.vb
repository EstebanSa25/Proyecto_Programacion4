Imports Modelo
Public Class DBNotas
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_NOTAS_PROFESOR"
    Dim spREPORTE As String = "SP_REPORTE_PROFESOR"

    Public Function CONSULTAR(ID_JUEGO As Integer) As List(Of Reportes)
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_JUEGO", False)
        listaValores.Add(CStr(ID_JUEGO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim juego_grupo As List(Of Reportes) = ConvertirJuego_grupo()

        Return juego_grupo
    End Function

    Public Function CONSULTAR_NULL(ID_JUEGO As Integer) As List(Of Reportes)
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_JUEGO", False)
        listaValores.Add(CStr(ID_JUEGO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTA_FILTRADA) = False Then
            Return Nothing
        End If

        Dim juego_grupo As List(Of Reportes) = ConvertirJuego_grupo()

        Return juego_grupo
    End Function


    Public Function CONSULTARPREGUNTA(ID_JUEGO As Integer) As List(Of Reportes)
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_JUEGO", False)
        listaValores.Add(CStr(ID_JUEGO))

        If EjecutarSP(spREPORTE, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim juego_grupo As List(Of Reportes) = ConvertirPregunta()

        Return juego_grupo
    End Function

    Private Function ConvertirJuego_grupo() As List(Of Reportes)

        Dim lista As List(Of Reportes) = New List(Of Reportes)
        For Each fila In dataSet.Tables(0).Rows
            Dim Reportes As Reportes = New Reportes
            Reportes.ID_ALUMNO = fila("ID_ALUMNO")
            Reportes.NOMBRE = fila("NOMBRE_COMPLETO")
            If IsDBNull(fila("PUNTAJE_TOTAL")) Then
                Reportes.PUNTAJE_ALUMNO = 0
            Else
                Reportes.PUNTAJE_ALUMNO = fila("PUNTAJE_TOTAL")
            End If

            Reportes.PUNTAJE_TOTAL_JUEGO = fila("PUNTAJE_TOTAL_JUEGO")
            lista.Add(Reportes)
        Next
        Return lista
    End Function

    Private Function ConvertirPregunta() As List(Of Reportes)

        Dim lista As List(Of Reportes) = New List(Of Reportes)
        For Each fila In dataSet.Tables(0).Rows
            Dim Reportes As Reportes = New Reportes
            Reportes.IDPREGUNTA = fila("ID_PREGUNTA")
            Reportes.PREGUNTA = fila("PREGUNTA")
            Reportes.BUENAS = fila("BUENAS")
            Reportes.MALAS = fila("MALAS")
            lista.Add(Reportes)
        Next
        Return lista
    End Function
End Class
