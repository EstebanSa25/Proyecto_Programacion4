Imports DataBase
Imports Modelo
Public Class L_JUEGO_GRUPO
    Public dbjuego_grupo As DBJUEGO_GRUPO = New DBJUEGO_GRUPO()
    Public Function Consultar(ID_GRUPO As Integer) As List(Of Juego_grupo)
        Return dbjuego_grupo.CONSULTAR(ID_GRUPO)
    End Function
    Public Function INSERTAR(ID_GRUPO As Integer, ID_JUEGO As Integer)
        Return dbjuego_grupo.INSERTAR(ID_GRUPO, ID_JUEGO)
    End Function
    Public Function BORRAR(ID_JUEGO_GRUPO As Integer)
        Return dbjuego_grupo.BORRAR(ID_JUEGO_GRUPO)
    End Function

    Public Function Paginacion(ID As Integer, NumeroPaneles As Integer, ByRef Pagina As Integer, ByRef CantidadPaginas As Integer, Optional Filtro As String = "") As List(Of Juego_grupo)
        Dim lista As List(Of Juego_grupo) = Consultar(ID)

        If (Filtro <> "") Then

            lista = lista.Where(Function(x) x.JUEGO.ToLower().Contains(Filtro.ToLower())).ToList() 'LinQ

        End If
        CantidadPaginas = Math.Ceiling(lista.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
        Dim listaPaginacion As List(Of Juego_grupo) = lista.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
        Return listaPaginacion
    End Function

End Class
