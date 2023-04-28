Imports Modelo
'Imports Cons

Public Class DBJuego
    Inherits ConsultaGenerica
    Dim spNombre As String = "SP_FORMULARIO"

    Public Function INSERTAR(JUEGO As String, ID_USUARIO As Integer, FECHA_INICIO As String, HORA_INICIO As String, FECHA_FIN As String, HORA_FIN As String, VISIBILIDAD As Integer) As Boolean
        'Falso si no lleva comillas(datos int,float,double) y true si lleva comillas es String
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("JUEGO", True)
        listaNombreParametros.Add("ID_USUARIO", False)
        listaNombreParametros.Add("FECHA_INICIO", True)
        listaNombreParametros.Add("HORA_INICIO", True)
        listaNombreParametros.Add("FECHA_FIN", True)
        listaNombreParametros.Add("HORA_FIN", True)
        listaNombreParametros.Add("VISIBILIDAD", False)

        listaValores.Add(CStr(JUEGO))
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(FECHA_INICIO))
        listaValores.Add(CStr(HORA_INICIO))
        listaValores.Add(CStr(FECHA_FIN))
        listaValores.Add(CStr(HORA_FIN))
        listaValores.Add(CStr(VISIBILIDAD))

        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function BORRAR(ID_JUEGO As Integer) As Boolean
        'Falso si no lleva comillas(datos int,float,double) y true si lleva comillas es String
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("id_formulario", False)
        listaValores.Add(CStr(ID_JUEGO))

        If EjecutarSP(spNombre, TipoSentenciaSQL.BORRAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function CONSULTAR(ID_USUARIO As Integer, JUEGO As String, ID_JUEGO As Integer) As List(Of FORMULARIO)

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("id_usuario", False)
        listaNombreParametros.Add("JUEGO", True)
        listaNombreParametros.Add("id_formulario", False)
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(JUEGO))
        listaValores.Add(CStr(ID_JUEGO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lstjuego As List(Of FORMULARIO) = ConvertirJuego()

        Return lstjuego

    End Function
    Public Function CONSULTAR_FILTRADA(ID_USUARIO As Integer, JUEGO As String) As FORMULARIO

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("id_usuario", False)
        listaNombreParametros.Add("JUEGO", True)
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(JUEGO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTA_FILTRADA) = False Then
            Return Nothing
        End If

        Dim JUEG0 As FORMULARIO = ConvertirJuego().First

        Return JUEG0

    End Function
    Public Function ACTUALIZAR(JUEGO As String, FECHA_INICIO As String, HORA_INICIO As String, FECHA_FIN As String, HORA_FIN As String, VISIBILIDAD As Integer, ID_JUEGO As Integer) As Boolean
        ' UPDATE FORMULARIO SET JUEGO=@Juego,FECHA_INICIO=@FECHA_INICIO,HORA_INICIO=@HORA_INICIO,FECHA_FIN=@FECHA_FIN,HORA_FIN=@HORA_FIN,VISIBILIDAD=@VISIBILIDAD WHERE ID_JUEGO=@id_formulario
        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("Juego", True)
        listaNombreParametros.Add("FECHA_INICIO", True)
        listaNombreParametros.Add("HORA_INICIO", True)
        listaNombreParametros.Add("FECHA_FIN", True)
        listaNombreParametros.Add("HORA_FIN", True)
        listaNombreParametros.Add("VISIBILIDAD", False)
        listaNombreParametros.Add("id_formulario", False)

        listaValores.Add(CStr(JUEGO))
        listaValores.Add(CStr(FECHA_INICIO))
        listaValores.Add(CStr(HORA_INICIO))
        listaValores.Add(CStr(FECHA_FIN))
        listaValores.Add(CStr(HORA_FIN))
        listaValores.Add(CStr(VISIBILIDAD))
        listaValores.Add(CStr(ID_JUEGO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If
        Return True


    End Function
    Private Function ConvertirJuego() As List(Of FORMULARIO)

        Dim lista As List(Of FORMULARIO) = New List(Of FORMULARIO)
        For Each fila In dataSet.Tables(0).Rows
            Dim juego As FORMULARIO = New FORMULARIO
            juego.ID_JUEGO = fila("ID_JUEGO")
            juego.JUEGO = fila("JUEGO")
            juego.ID_USUARIO = fila("ID_USUARIO")
            If IsDBNull(fila("FECHA_INICIO")) <> True Then
                juego.FECHA_INICIO = fila("FECHA_INICIO")
                juego.HORA_INICIO = fila("HORA_INICIO")
                juego.FECHA_FIN = fila("FECHA_FIN")
                juego.HORA_FIN = fila("HORA_FIN")
            Else
                juego.FECHA_INICIO = Nothing
                juego.HORA_INICIO = Nothing
                juego.FECHA_FIN = Nothing
                juego.HORA_FIN = Nothing
            End If
            juego.VISIBILIDAD = fila("VISIBILIDAD")
            lista.Add(juego)
        Next
        Return lista
    End Function

End Class




