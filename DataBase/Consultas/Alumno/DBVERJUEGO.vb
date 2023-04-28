Imports Modelo
Public Class DBVERJUEGO
    Inherits ConsultaGenerica
    Dim spNombre = "SP_VERJUEGO"

    Public Function CONSULTAR(ID_USUARIO As Nullable(Of Integer)) As List(Of FORMULARIO)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_USUARIO", False)
        listaValores.Add(CStr(ID_USUARIO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstGrupo As List(Of FORMULARIO) = ConvertirGrupo()

        Return lstGrupo

    End Function

    Private Function ConvertirGrupo() As List(Of FORMULARIO)

        Dim lista As List(Of FORMULARIO) = New List(Of FORMULARIO)
        For Each fila In dataSet.Tables(0).Rows
            Dim FORMULARIOo As FORMULARIO = New FORMULARIO
            FORMULARIOo.ID_JUEGO = fila("ID_JUEGO")
            FORMULARIOo.JUEGO = fila("JUEGO")
            FORMULARIOo.VISIBILIDAD = fila("VISIBILIDAD")
            If IsDBNull(fila("FECHA_INICIO")) Then
                FORMULARIOo.FECHA_INICIO = Nothing
                FORMULARIOo.HORA_INICIO = Nothing
                FORMULARIOo.FECHA_FIN = Nothing
                FORMULARIOo.HORA_FIN = Nothing
            Else
                FORMULARIOo.FECHA_INICIO = fila("FECHA_INICIO")
                FORMULARIOo.HORA_INICIO = fila("HORA_INICIO")
                FORMULARIOo.FECHA_FIN = fila("FECHA_FIN")
                FORMULARIOo.HORA_FIN = fila("HORA_FIN")
            End If

            lista.Add(FORMULARIOo)
        Next
        Return lista
    End Function
End Class
