Imports Modelo
Public Class DBALUMNOGRUPOS
    Inherits ConsultaGenerica
    Dim spNombre = "SP_VERGRUPOALUMNO"

    Public Function CONSULTAR(ID_USUARIO As Nullable(Of Integer)) As List(Of Grupo)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_USUARIO", False)
        listaValores.Add(CStr(ID_USUARIO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo As List(Of Grupo) = ConvertirGrupo()

        Return lstGrupo

    End Function

    Private Function ConvertirGrupo() As List(Of Grupo)

        Dim lista As List(Of Grupo) = New List(Of Grupo)
        For Each fila In dataSet.Tables(0).Rows
            Dim grupo As Grupo = New Grupo
            grupo.ID_GRUPO = fila("ID_GRUPO")
            grupo.FOTO = fila("FOTO")
            grupo.GRUPO = fila("GRUPO")
            lista.Add(grupo)
        Next
        Return lista
    End Function

End Class
