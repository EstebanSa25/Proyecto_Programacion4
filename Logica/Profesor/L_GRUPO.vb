Imports DataBase
Imports Modelo
Public Class L_GRUPO

    Public Function CONSULTAR_POR_ID_USUARIO() As List(Of Grupo)
        Dim dbgrupo As DBGRUPO = New DBGRUPO()
        Dim lista As List(Of Grupo) = New List(Of Grupo)
        Return dbgrupo.CONSULTAR(0, ID_USUARIO_SESION, "")
    End Function
    Public Function CONSULTAR_POR_GRUPO(Nombre_grupo As String) As List(Of Grupo)
        Dim dbgrupo As DBGRUPO = New DBGRUPO()
        Dim lista As List(Of Grupo) = New List(Of Grupo)
        Return dbgrupo.CONSULTAR(0, 0, Nombre_grupo)
    End Function

    Public Function Paginacion(NumeroPaneles As Integer, ByRef Pagina As Integer, ByRef CantidadPaginas As Integer, Optional Filtro As String = "") As List(Of Grupo)

        Dim lista As List(Of Grupo) = CONSULTAR_POR_ID_USUARIO()

        If (Filtro <> "") Then

            lista = lista.Where(Function(x) x.GRUPO.ToLower().Contains(Filtro.ToLower())).ToList() 'LinQ

        End If
        CantidadPaginas = Math.Ceiling(lista.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
        Dim listaPaginacion As List(Of Grupo) = lista.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
        Return listaPaginacion
    End Function
End Class
