Imports Modelo

Public Class DBRETO
    Inherits ConsultaGenerica
    Public spNombre = "SP_RETO"
    Public Function CONSULTAR(ID_RETO As Integer, ID_PREGUNTA As Integer) As List(Of Retos)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_RETO", False)
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaValores.Add(CStr(ID_RETO))
        listaValores.Add(CStr(ID_PREGUNTA))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lst_Retos As List(Of Retos) = ConvertirReto()

        Return lst_Retos

    End Function

    Private Function ConvertirReto() As List(Of Retos)

        Dim lista As List(Of Retos) = New List(Of Retos)
        For Each fila In dataSet.Tables(0).Rows
            Dim reto As Retos = New Retos
            reto.ID_RETO = fila("ID_RETO")
            reto.ID_CATEGORIA = fila("ID_CATEGORIA")
            reto.RETO = fila("RETO")
            reto.ID_PREGUNTA = fila("ID_PREGUNTA")
            reto.PUNTAJE = fila("PUNTAJE")
            reto.TIEMPO = fila("TIEMPO")
            reto.FOTO = fila("FOTO")
            reto.VIDEO = fila("VIDEO")
            reto.AUDIO = fila("AUDIO")
            reto.EXTENSION = fila("EXTENSION")
            lista.Add(reto)
        Next
        Return lista
    End Function
    Public Function INSERTAR(ID_CATEGORIA As Integer, RETO As String, ID_PREGUNTA As Integer, PUNTO As Integer, TIEMPO As Integer, FOTO As String, VIDEO As String, AUDIO As String, EXTENSION As String) As Boolean
        'Falso si no lleva comillas(datos int,float,double) y true si lleva comillas es String
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_CATEGORIA", False)
        listaNombreParametros.Add("RETO", True)
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaNombreParametros.Add("PUNTO", False)
        listaNombreParametros.Add("TIEMPO", False)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("VIDEO", True)
        listaNombreParametros.Add("AUDIO", True)
        listaNombreParametros.Add("EXTENSION", True)
        listaValores.Add(CStr(ID_CATEGORIA))
        listaValores.Add(CStr(RETO))
        listaValores.Add(CStr(ID_PREGUNTA))
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
    Public Function ACTUALIZAR(ID_CATEGORIA As Integer, RETO As String, PUNTO As Integer, TIEMPO As Integer, FOTO As String, VIDEO As String, AUDIO As String, ID_RETO As Integer, EXTENSION As String) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_CATEGORIA", False)
        listaNombreParametros.Add("RETO", True)
        listaNombreParametros.Add("PUNTO", False)
        listaNombreParametros.Add("TIEMPO", False)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("VIDEO", True)
        listaNombreParametros.Add("AUDIO", True)
        listaNombreParametros.Add("ID_RETO", False)
        listaNombreParametros.Add("EXTENSION", True)
        listaValores.Add(CStr(ID_CATEGORIA))
        listaValores.Add(CStr(RETO))
        listaValores.Add(CStr(PUNTO))
        listaValores.Add(CStr(TIEMPO))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(VIDEO))
        listaValores.Add(CStr(AUDIO))
        listaValores.Add(CStr(ID_RETO))
        listaValores.Add(CStr(EXTENSION))
        If EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function BORRAR(ID_RETO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_RETO", False)
        listaValores.Add(CStr(ID_RETO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If

        Return True

    End Function
End Class
