Imports Modelo

Public Class DBUsuario
    Inherits ConsultaGenerica

    Dim spNombre As String = "SP_USUARIO"

    Public Function INSERTAR(EMAIL As String, CLAVE As String, TELEFONO As Integer, ID_ROL As Integer, FOTO As String, NOMBRE As String) As Boolean

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("EMAIL", True)
        listaNombreParametros.Add("CLAVE", True)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("TELEFONO", False)
        listaNombreParametros.Add("ID_ROL", False)
        listaNombreParametros.Add("NOMBRE", True)
        listaValores.Add(CStr(EMAIL))
        listaValores.Add(CStr(CLAVE))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(TELEFONO))
        listaValores.Add(CStr(ID_ROL))
        listaValores.Add(CStr(NOMBRE))
        If EjecutarSP(spNombre, TipoSentenciaSQL.INSERTAR) = False Then
            Return False
        End If

        Return True

    End Function
    Public Function CONSULTAR(ID_USUARIO As Nullable(Of Integer), Email As String) As Usuario

        listaNombreParametros.Clear()
        listaValores.Clear()

        listaNombreParametros.Add("ID_USUARIO", False)
        listaNombreParametros.Add("EMAIL", True)
        listaValores.Add(CStr(ID_USUARIO))
        listaValores.Add(CStr(Email))

        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim usuario As Usuario = ConvertirUsuario().First

        Return usuario

    End Function
    Public Function CONSULTAR_TODOS_FILTRADO(ID_ROL As Integer) As List(Of Usuario)

        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_ROL", False)
        listaValores.Add(ID_ROL)
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTA_FILTRADA) = False Then
            Return Nothing
        End If
        Dim lstUsuario As List(Of Usuario) = New List(Of Usuario)
        lstUsuario = ConvertirUsuario()

        Return lstUsuario

    End Function
    Public Function ACTUALIZAR(EMAIL As String, CLAVE As String, TELEFONO As Integer, ID_ROL As Integer, FOTO As String) As Boolean
        listaNombreParametros.Clear()
        listaValores.Clear()
        listaNombreParametros.Add("ID_USUARIO", True)
        listaNombreParametros.Add("EMAIL", True)
        listaNombreParametros.Add("CLAVE", True)
        listaNombreParametros.Add("FOTO", True)
        listaNombreParametros.Add("TELEFONO", False)
        listaNombreParametros.Add("ID_ROL", False)
        listaValores.Add(CStr(ID_USUARIO_SESION))
        listaValores.Add(CStr(EMAIL))
        listaValores.Add(CStr(CLAVE))
        listaValores.Add(CStr(FOTO))
        listaValores.Add(CStr(TELEFONO))
        listaValores.Add(CStr(ID_ROL))

        If EjecutarSP(spNombre, TipoSentenciaSQL.ACTUALIZAR) = False Then
            Return False
        End If
        Return True

    End Function
    Private Function ConvertirUsuario() As List(Of Usuario)

        Dim lista As List(Of Usuario) = New List(Of Usuario)
        For Each fila In dataSet.Tables(0).Rows
            Dim usuario As Usuario = New Usuario
            usuario.ID_USUARIO = fila("ID_USUARIO")
            Usuario.EMAIL = fila("EMAIL")
            Usuario.CLAVE = fila("CLAVE")
            usuario.FOTO = fila("FOTO")
            usuario.TELEFONO = fila("TELEFONO")
            usuario.ID_ROL = fila("ID_ROL")
            lista.Add(usuario)
        Next
        Return lista
    End Function

End Class
