Imports Modelo
'Imports Cons
Public Class DBPREGUNTA
    Inherits ConsultaGenerica
    Dim spNombre = "SP_PREGUNTA"
    Public Function INSERTAR(ID_CATEGORIA As Integer, PREGUNTA As String, ID_JUEGO As Integer, PUNTO As Integer, TIEMPO As Integer, FOTO As String, VIDEO As String, AUDIO As String, EXTENSION As String) As Boolean
        'Falso si no lleva comillas(datos int,float,double) y true si lleva comillas es String
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_CATEGORIA", False)
        listaNombreParametros.Add("PREGUNTA", True)
        listaNombreParametros.Add("ID_JUEGO", False)
        listaNombreParametros.Add("PUNTO", False)
        listaNombreParametros.Add("TIEMPO", False)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("VIDEO", True)
        listaNombreParametros.Add("AUDIO", True)
        listaNombreParametros.Add("EXTENSION", True)
        listaValores.Add(CStr(ID_CATEGORIA))
        listaValores.Add(CStr(PREGUNTA))
        listaValores.Add(CStr(ID_JUEGO))
        listaValores.Add(CStr(PUNTO))
        listaValores.Add(CStr(TIEMPO))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(VIDEO))
        listaValores.Add(CStr(AUDIO))
        listaValores.Add(CStr(EXTENSION))
        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function ACTUALIZAR(ID_CATEGORIA As Integer, PREGUNTA As String, PUNTO As Integer, TIEMPO As Integer, FOTO As String, VIDEO As String, AUDIO As String, ID_PREGUNTA As Integer, EXTENSION As String) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_CATEGORIA", False)
        listaNombreParametros.Add("PREGUNTA", True)
        listaNombreParametros.Add("PUNTO", False)
        listaNombreParametros.Add("TIEMPO", False)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("VIDEO", True)
        listaNombreParametros.Add("AUDIO", True)
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaNombreParametros.Add("EXTENSION", True)
        listaValores.Add(CStr(ID_CATEGORIA))
        listaValores.Add(CStr(PREGUNTA))
        listaValores.Add(CStr(PUNTO))
        listaValores.Add(CStr(TIEMPO))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(VIDEO))
        listaValores.Add(CStr(AUDIO))
        listaValores.Add(CStr(ID_PREGUNTA))
        listaValores.Add(CStr(EXTENSION))
        If EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function BORRAR(ID_PREGUNTA As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaValores.Add(CStr(ID_PREGUNTA))
        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function CONSULTAR(ID_PREGUNTA As Integer, PREGUNTA As String, ID_JUEGO As Integer, ID_CATEGORIA As Integer)
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaNombreParametros.Add("PREGUNTA", True)
        listaNombreParametros.Add("ID_JUEGO", False)
        listaNombreParametros.Add("ID_CATEGORIA", False)
        listaValores.Add(CStr(ID_PREGUNTA))
        listaValores.Add(CStr(PREGUNTA))
        listaValores.Add(CStr(ID_JUEGO))
        listaValores.Add(CStr(ID_CATEGORIA))
        EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR)
        Dim lstPreguntas As List(Of Pregunta) = ConvertirJUEGO()
        Return lstPreguntas
    End Function
    Public Function CONSULTAR_ID(ID_JUEGO As Integer)
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_JUEGO", False)
        listaValores.Add(CStr(ID_JUEGO))
        EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTA_FILTRADA)
        Dim lstPreguntas As List(Of Pregunta) = ConvertirJUEGO()
        Return lstPreguntas
    End Function
    'Public Function CONSULTAR_ID_PUNTAJE(ID_JUEGO As Integer) As Integer
    '    listaNombreParametros.Clear()
    '    listaValores.Clear()
    '    listaNombreParametros.Add("ID_JUEGO", False)
    '    listaValores.Add(CStr(ID_JUEGO))
    '    EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTA_FILTRADA)
    '    Dim lstPreguntas As List(Of Pregunta) = ConvertirJUEGO()
    '    Return lstPreguntas
    'End Function
    Private Function ConvertirJUEGO() As List(Of Pregunta)
        Dim lstPreguntas As List(Of Pregunta) = New List(Of Pregunta)
        For Each fila In dataSet.Tables(0).Rows
            Dim pregunta As Pregunta = New Pregunta
            pregunta.ID_CATEGORIA = fila("ID_CATEGORIA")
            pregunta.PREGUNTA = fila("PREGUNTA")
            pregunta.ID_JUEGO = fila("ID_JUEGO")
            pregunta.PUNTAJE = fila("PUNTAJE")
            pregunta.ID_PREGUNTA = fila("ID_PREGUNTA")
            pregunta.TIEMPO = fila("TIEMPO")
            pregunta.FOTO = fila("FOTO")
            pregunta.VIDEO = fila("VIDEO")
            pregunta.AUDIO = fila("AUDIO")
            If IsDBNull(fila("EXTENSION")) = True Then
                pregunta.EXTENSION = ""
            Else
                pregunta.EXTENSION = fila("EXTENSION")
            End If

            lstPreguntas.Add(pregunta)
        Next
        Return lstPreguntas
    End Function
    'Private Function ConvertirJUEGO_NOTA() As Integer
    '    Dim lstPreguntas As List(Of Pregunta) = New List(Of Pregunta)
    '    For Each fila In dataSet.Tables(0).Rows
    '        Dim pregunta As Pregunta = New Pregunta
    '        pregunta.PUNTAJE = fila("PUNTAJE")


    '        lstPreguntas.Add(pregunta)
    '    Next
    '    Dim TOTAL_PUNTAJE
    '    For Each datos In lstPreguntas
    '        datos.PUNTAJE
    '    Next
    'End Function
End Class
