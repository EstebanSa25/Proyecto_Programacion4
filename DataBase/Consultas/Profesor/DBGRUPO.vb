Imports Modelo
Public Class DBGRUPO
    Inherits ConsultaGenerica

    Dim spNombre As String = "SP_GRUPO"

    Public Function INSERTAR(GRUPO As String, ID_USUARIO As Integer, FOTO As String) As Boolean

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("GRUPO", True)
        listaNombreParametros.Add("ID_USUARIO", False)
        listaNombreParametros.Add("FOTO", True)

        listaValores.Add(CStr(GRUPO))
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(FOTO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function CONSULTAR(ID_GRUPO As Nullable(Of Integer), ID_USUARIO As Nullable(Of Integer), GRUPO As String) As List(Of Grupo)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_GRUPO", False)
        listaNombreParametros.Add("ID_USUARIO", False)
        listaNombreParametros.Add("GRUPO", True)
        listaValores.Add(CStr(ID_GRUPO))
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(GRUPO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo As List(Of Grupo) = ConvertirGrupo()

        Return lstGrupo

    End Function
    Public Function ACTUALIZAR(GRUPO As String, FOTO As String, ID_GRUPO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("GRUPO", True)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("ID_GRUPO", False)
        listaValores.Add(CStr(GRUPO))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(ID_GRUPO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If
        Return True

    End Function
    Public Function BORRAR(ID_GRUPO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_GRUPO", False)
        listaValores.Add(CStr(ID_GRUPO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If
        Return True

    End Function
    Private Function ConvertirGrupo() As List(Of Grupo)

        Dim lista As List(Of Grupo) = New List(Of Grupo)
        For Each fila In dataSet.Tables(0).Rows
            Dim grupo As Grupo = New Grupo
            grupo.ID_GRUPO = fila("ID_GRUPO")
            grupo.GRUPO = fila("GRUPO")
            grupo.ID_USUARIO = fila("ID_USUARIO")
            grupo.FOTO = fila("FOTO")
            lista.Add(grupo)
        Next
        Return lista
    End Function
End Class
