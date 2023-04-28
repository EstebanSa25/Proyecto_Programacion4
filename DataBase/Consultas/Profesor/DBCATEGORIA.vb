Imports Modelo
Public Class DBCATEGORIA
    Inherits ConsultaGenerica
    Dim spCategoria = "SP_CATEGORIA"
    Public Function INSERTAR(CATEGORIA As String, ID_USUARIO As Integer, FOTO As String) As Boolean
        'Falso si no lleva comillas(datos int,float,double) y true si lleva comillas es String
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("CATEGORIA", True)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("ID_USUARIO", False)

        listaValores.Add(CStr(CATEGORIA))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(ID_USUARIO))


        If EjecutarSP(spCategoria, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function

    Public Function ACTUALIZAR(CATEGORIA As String, FOTO As String, ID_CATEGORIA As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("CATEGORIA", True)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("ID_CATEGORIA", True)
        listaValores.Add(CStr(CATEGORIA))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(ID_CATEGORIA))

        If EjecutarSP(spCategoria, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If
        Return True

    End Function
    Public Function BORRAR(ID_CATEGORIA As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_CATEGORIA", False)

        listaValores.Add(CStr(ID_CATEGORIA))


        If EjecutarSP(spCategoria, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If
        Return True

    End Function
    Public Function CONSULTAR(ID_USUARIO As Integer, CATEGORIA As String) As List(Of Categoria)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("id_usuario", False)
        listaNombreParametros.Add("categoria", True)
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(CATEGORIA))
        If EjecutarSP(spCategoria, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstCategoria As List(Of Categoria) = ConvertirCategoria()

        Return lstCategoria

    End Function
    Private Function ConvertirCategoria() As List(Of Categoria)

        Dim lista As List(Of Categoria) = New List(Of Categoria)
        For Each fila In dataSet.Tables(0).Rows
            Dim categoria As Categoria = New Categoria
            categoria.ID_CATEGORIA = fila("ID_CATEGORIA")
            categoria.CATEGORIA = fila("CATEGORIA")
            categoria.FOTO = fila("FOTO")
            categoria.ID_USUARIO = fila("ID_USUARIO")
            lista.Add(categoria)
        Next
        Return lista
    End Function

End Class
