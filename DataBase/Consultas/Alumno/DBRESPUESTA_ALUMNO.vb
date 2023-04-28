Imports Modelo

Public Class DBRESPUESTA_ALUMNO
    Inherits ConsultaGenerica
    Private spNombre As String = "SP_RESPUESTA_ALUMNO"
    Private spNombre2 As String = "SP_RESPUESTA_ALUMNO_RETO"
    Public Function INSERTAR(ID_OPCION As Integer, ID_ALUMNO As Integer) As Boolean

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_OPCION", False)

        listaNombreParametros.Add("ID_ALUMNO", False)
        listaValores.Add(CStr(ID_OPCION))
        listaValores.Add(CStr(ID_ALUMNO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If
        Return True

    End Function
    Public Function INSERTAR_RETO(ID_ALUMNO As Integer, ID_OPCION As Integer) As Boolean

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_ALUMNO", False)

        listaNombreParametros.Add("ID_OPCION", False)
        listaValores.Add(CStr(ID_ALUMNO))
        listaValores.Add(CStr(ID_OPCION))
        If EjecutarSP(spNombre2, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If
        Return True

    End Function
End Class
