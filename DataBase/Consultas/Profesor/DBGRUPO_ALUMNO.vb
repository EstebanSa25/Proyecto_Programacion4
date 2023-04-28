Imports Modelo
Public Class DBGRUPO_ALUMNO
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_GRUPO_ALUMNO"
    Public Function INSERTAR(ID_ALUMNO, ID_GRUPO) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_ALUMNO", True)
        listaNombreParametros.Add("ID_GRUPO", True)

        listaValores.Add(CStr(ID_ALUMNO))
        listaValores.Add(CStr(ID_GRUPO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True
    End Function
    Public Function BORRAR(ID_ALUMNO As Integer, ID_GRUPO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_ALUMNO", False)
        listaNombreParametros.Add("ID_GRUPO", False)

        listaValores.Add(CStr(ID_ALUMNO))
        listaValores.Add(CStr(ID_GRUPO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If

        Return True
    End Function

    Public Function CONSULTAR(ID_GRUPO As Integer) As List(Of Grupo_alumno)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_GRUPO", False)
        listaValores.Add(CStr(ID_GRUPO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo_alumno As List(Of Grupo_alumno) = ConvertirGrupo_alumno()

        Return lstGrupo_alumno

    End Function
    Private Function ConvertirGrupo_alumno() As List(Of Grupo_alumno)

        Dim lista As List(Of Grupo_alumno) = New List(Of Grupo_alumno)
        For Each fila In dataSet.Tables(0).Rows
            Dim grupo As Grupo_alumno = New Grupo_alumno
            grupo.ID_ALUMNO = fila("ID_ALUMNO")
            grupo.EMAIL = fila("EMAIL")
            lista.Add(grupo)
        Next
        Return lista
    End Function
End Class
