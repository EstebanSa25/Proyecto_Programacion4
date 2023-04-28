Imports DataBase
Imports Modelo
Public Class L_CRUD_GRUPO
    Public Function ACTUALIZAR(TXT_NOMBRE As String, FOTO As String, ID_GRUPO As Integer)
        Try
            Dim dbgrupo As DBGRUPO = New DBGRUPO()
            dbgrupo.ACTUALIZAR(TXT_NOMBRE, FOTO, ID_GRUPO)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function INSERTAR(TXT_NOMBRE As String, FOTO As String)
        Try
            Dim dbgrupo As DBGRUPO = New DBGRUPO()
            dbgrupo.INSERTAR(TXT_NOMBRE, ID_USUARIO_SESION, FOTO)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function CONSULTAR_POR_NOMBRE(TXT_NOMBRE As String) As List(Of Grupo)
        Try
            Dim dbgrupo As DBGRUPO = New DBGRUPO()

            Return dbgrupo.CONSULTAR(0, 0, TXT_NOMBRE)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function ELIMINAR(ID_GRUPO As Integer) As Boolean
        Try
            Dim dbgrupo As DBGRUPO = New DBGRUPO()

            Return dbgrupo.BORRAR(ID_GRUPO)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
