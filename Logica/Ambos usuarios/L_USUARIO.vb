Imports DataBase
Imports Modelo
Public Class L_USUARIO
    Public dbusuario As DBUsuario = New DBUsuario()
    Public Function CONSULTAR_POR_ROL(ID_ROL As Integer) As List(Of Usuario)
        Return dbusuario.CONSULTAR_TODOS_FILTRADO(ID_ROL)
    End Function
End Class
