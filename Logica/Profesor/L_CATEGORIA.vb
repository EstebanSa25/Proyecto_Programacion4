Imports DataBase
Imports Modelo
Public Class L_CATEGORIA
    Dim categoriaDB As DBCATEGORIA = New DBCATEGORIA
    Public Sub INSERTAR(CATEGORIA As String, FOTO As String)
        categoriaDB.INSERTAR(CATEGORIA, ID_USUARIO_SESION, FOTO)
    End Sub
    Public Function ACTUALIZAR(CATEGORIA As String, FOTO As String, ID_CATEGORIA As Integer) As Boolean
        Return categoriaDB.ACTUALIZAR(CATEGORIA, FOTO, ID_CATEGORIA)
    End Function
    Public Sub BORRAR(ID_CATEGORIA As Integer)
        categoriaDB.BORRAR(ID_CATEGORIA)
    End Sub

    Public Function CONSULTAR_POR_NOMBRE(CATEGORIA As String) As List(Of Categoria)
        Return categoriaDB.CONSULTAR(0, CATEGORIA)
    End Function
    Public Function CONSULTAR_POR_ID() As List(Of Categoria)
        Return categoriaDB.CONSULTAR(ID_USUARIO_SESION, "")
    End Function
    Public Function Paginacion(NumeroPaneles As Integer, ByRef Pagina As Integer, ByRef CantidadPaginas As Integer, Optional Filtro As String = "") As List(Of Categoria)
        Dim lista As List(Of Categoria) = CONSULTAR_POR_ID()

        If (Filtro <> "") Then

            lista = lista.Where(Function(x) x.CATEGORIA.ToLower().Contains(Filtro.ToLower())).ToList() 'LinQ

        End If
        CantidadPaginas = Math.Ceiling(lista.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
        Dim listaPaginacion As List(Of Categoria) = lista.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
        Return listaPaginacion
    End Function
End Class