Imports Modelo
Public Class DBJUEGO_GRUPO
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_JUEGO_GRUPO"
    Public Function INSERTAR(ID_GRUPO As Integer, ID_JUEGO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_GRUPO", True)
        listaNombreParametros.Add("ID_JUEGO", True)
        listaValores.Add(CStr(ID_GRUPO))
        listaValores.Add(CStr(ID_JUEGO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function CONSULTAR(ID_GRUPO As Integer) As List(Of Juego_grupo)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_GRUPO", False)
        listaValores.Add(CStr(ID_GRUPO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim juego_grupo As List(Of Juego_grupo) = ConvertirJuego_grupo()

        Return juego_grupo

    End Function
    Private Function ConvertirJuego_grupo() As List(Of Juego_grupo)

        Dim lista As List(Of Juego_grupo) = New List(Of Juego_grupo)
        For Each fila In dataSet.Tables(0).Rows
            Dim juego_grupo As Juego_grupo = New Juego_grupo
            juego_grupo.ID_JUEGO = fila("ID_JUEGO")
            juego_grupo.ID_JUEGO_GRUPO = fila("ID_JUEGO_GRUPO")
            juego_grupo.JUEGO = fila("JUEGO")

            If IsDBNull(fila("FECHA_INICIO")) <> True Then
                juego_grupo.FECHA_INICIO = fila("FECHA_INICIO")
                juego_grupo.HORA_INICIO = fila("HORA_INICIO")
                juego_grupo.FECHA_FIN = fila("FECHA_FIN")
                juego_grupo.HORA_FIN = fila("HORA_FIN")
            Else
                juego_grupo.FECHA_INICIO = Nothing
                juego_grupo.HORA_INICIO = Nothing
                juego_grupo.FECHA_FIN = Nothing
                juego_grupo.HORA_FIN = Nothing
            End If
            lista.Add(juego_grupo)
        Next
        Return lista
    End Function
    Public Function BORRAR(ID_JUEGO_GRUPO As Integer) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_JUEGO_GRUPO", False)
        listaValores.Add(CStr(ID_JUEGO_GRUPO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If

        Return True

    End Function
End Class
