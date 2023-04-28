Imports Modelo

Public Class DBREPORTE_ALUMNO
    Inherits ConsultaGenerica

    Dim spNombre = "SP_REPORTE_ALUMNO_JUEGO_GENERAL"
    Dim spNombre2 = "SP_REPORTE_ALUMNO_PREGUNTAS"
    Dim spNombre3 = "SP_REPORTE_ALUMNO_RETO"
    Public Function CONSULTAR(ID_USUARIO As Nullable(Of Integer)) As List(Of Reporte_general_alumno)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_ALUMNO", False)
        listaValores.Add(CStr(ID_USUARIO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim LST_REPORTE As List(Of Reporte_general_alumno) = ConvertirReporteGeneral()

        Return LST_REPORTE

    End Function

    Private Function ConvertirReporteGeneral() As List(Of Reporte_general_alumno)

        Dim lista As List(Of Reporte_general_alumno) = New List(Of Reporte_general_alumno)
        For Each fila In dataSet.Tables(0).Rows
            Dim reporte As Reporte_general_alumno = New Reporte_general_alumno
            reporte.ID_JUEGO = fila("ID_JUEGO")
            reporte.JUEGO = fila("JUEGO")
            reporte.PUNTAJE_TOTAL_JUEGO = fila("PUNTAJE_TOTAL_JUEGO")
            reporte.PUNTAJE_TOTAL = fila("PUNTAJE_TOTAL")
            reporte.BUENAS = fila("BUENAS")
            reporte.MALAS = fila("MALAS")
            lista.Add(reporte)
        Next
        Return lista
    End Function


    Public Function CONSULTAR_PREGUNTA(ID_JUEGO As Integer, ID_ALUMNO As Integer) As List(Of Reporte_Preguntas)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_JUEGO", False)
        listaNombreParametros.Add("ID_ALUMNO", False)
        listaValores.Add(CStr(ID_JUEGO))
        listaValores.Add(CStr(ID_ALUMNO))
        If EjecutarSP(spNombre2, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo As List(Of Reporte_Preguntas) = Convertir_reporte_pregunta()

        Return lstGrupo

    End Function

    Private Function Convertir_reporte_pregunta() As List(Of Reporte_Preguntas)

        Dim lista As List(Of Reporte_Preguntas) = New List(Of Reporte_Preguntas)
        For Each fila In dataSet.Tables(0).Rows
            Dim preguntas As Reporte_Preguntas = New Reporte_Preguntas
            preguntas.ID_PREGUNTA = fila("ID_PREGUNTA")
            preguntas.PREGUNTA = fila("PREGUNTA")
            preguntas.OPCION = fila("DESCRIPCION")
            preguntas.CORRECTA = fila("CORRECTA")
            preguntas.PUNTAJE = fila("PUNTAJE")
            preguntas.RESPUESTA_ALUMNO = fila("RESPUESTA_ALUMNO")
            lista.Add(preguntas)
        Next
        Return lista
    End Function
    Public Function CONSULTAR_RETO(ID_PREGUNTA As Integer, ID_ALUMNO As Integer) As List(Of Reporte_alumno_Retos)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaNombreParametros.Add("ID_ALUMNO", False)
        listaValores.Add(CStr(ID_PREGUNTA))
        listaValores.Add(CStr(ID_ALUMNO))
        If EjecutarSP(spNombre3, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo As List(Of Reporte_alumno_Retos) = Convertir_reporte_reto()

        Return lstGrupo

    End Function

    Private Function Convertir_reporte_reto() As List(Of Reporte_alumno_Retos)

        Dim lista As List(Of Reporte_alumno_Retos) = New List(Of Reporte_alumno_Retos)
        For Each fila In dataSet.Tables(0).Rows
            Dim reto As Reporte_alumno_Retos = New Reporte_alumno_Retos
            reto.RETO = fila("RETO")
            reto.CORRECTA = fila("CORRECTA")
            reto.OPCION = fila("DESCRIPCION")
            reto.RESPUESTA_ALUMNO = fila("RESPUESTA_ALUMNO")
            lista.Add(reto)
        Next
        Return lista
    End Function
End Class
