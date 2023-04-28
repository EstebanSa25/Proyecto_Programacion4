Imports Modelo

Public Class DBOPCIONES_RETOS
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_OPCIONES_RETOS"
    Public Function INSERTAR(ID_RETO As Integer, DESCRIPCION As String, CORRECTA As Boolean) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_RETO", False)
        listaNombreParametros.Add("DESCRIPCION", True)
        listaNombreParametros.Add("CORRECTA", False)
        listaValores.Add(ID_RETO)
        listaValores.Add(DESCRIPCION)
        listaValores.Add(CORRECTA)
        Return EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR)
    End Function
    Public Function ACTUALIZAR(DESCRIPCION As String, CORRECTA As Boolean, ID_OPCIONES_RETOS As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("DESCRIPCION", True)
        listaNombreParametros.Add("CORRECTA", False)
        listaNombreParametros.Add("ID_OPCIONES_RETOS", False)
        listaValores.Add(DESCRIPCION)
        listaValores.Add(CORRECTA)
        listaValores.Add(ID_OPCIONES_RETOS)
        Return EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR)
    End Function

    Public Function CONSULTAR(ID_RETO As Integer) As List(Of Opciones_retos)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_RETO", False)
        listaValores.Add(CStr(ID_RETO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstopciones As List(Of Opciones_retos) = ConvertirOpciones()

        Return lstopciones

    End Function
    Private Function ConvertirOpciones() As List(Of Opciones_retos)

        Dim lista As List(Of Opciones_retos) = New List(Of Opciones_retos)
        For Each fila In dataSet.Tables(0).Rows
            Dim opciones As Opciones_retos = New Opciones_retos
            opciones.ID_OPCIONES_RETOS = fila("ID_OPCIONES_RETOS")
            opciones.ID_RETO = fila("ID_RETO")
            opciones.DESCRIPCION = fila("DESCRIPCION")
            opciones.CORRECTA = fila("CORRECTA")
            lista.Add(opciones)
        Next
        Return lista
    End Function
End Class
