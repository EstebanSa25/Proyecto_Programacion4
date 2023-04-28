Imports Modelo
Public Class DBOPCIONES
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_OPCIONES"
    Public Function INSERTAR(ID_PREGUNTA As Integer, DESCRIPCION As String, CORRECTA As Boolean) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaNombreParametros.Add("DESCRIPCION", True)
        listaNombreParametros.Add("CORRECTA", False)
        listaValores.Add(ID_PREGUNTA)
        listaValores.Add(DESCRIPCION)
        listaValores.Add(CORRECTA)
        Return EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR)
    End Function
    Public Function ACTUALIZAR(DESCRIPCION As String, CORRECTA As Boolean, ID_OPCIONES As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("DESCRIPCION", True)
        listaNombreParametros.Add("CORRECTA", False)
        listaNombreParametros.Add("ID_OPCIONES", False)
        listaValores.Add(DESCRIPCION)
        listaValores.Add(CORRECTA)
        listaValores.Add(ID_OPCIONES)
        Return EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR)
    End Function

    Public Function CONSULTAR(ID_OPCIONES As Integer, DESCRIPCION As String, ID_PREGUNTA As Integer) As List(Of Opciones)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_OPCIONES", False)
        listaNombreParametros.Add("DESCRIPCION", True)
        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaValores.Add(CStr(ID_OPCIONES))
        listaValores.Add(CStr(DESCRIPCION))
        listaValores.Add(CStr(ID_PREGUNTA))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstopciones As List(Of Opciones) = ConvertirOpciones()

        Return lstopciones

    End Function
    Private Function ConvertirOpciones() As List(Of Opciones)

        Dim lista As List(Of Opciones) = New List(Of Opciones)
        For Each fila In dataSet.Tables(0).Rows
            Dim opciones As Opciones = New Opciones
            opciones.ID_opciones = fila("ID_OPCIONES")
            opciones.ID_Pregunta = fila("ID_PREGUNTA")
            opciones.Descripcion = fila("DESCRIPCION")
            opciones.Corrrecta = fila("CORRECTA")
            lista.Add(opciones)
        Next
        Return lista
    End Function
End Class
