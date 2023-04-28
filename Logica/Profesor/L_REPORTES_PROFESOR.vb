Imports DataBase
Imports Modelo
Public Class L_REPORTES_PROFESOR
    Public dbjuego_grupo As DBNotas = New DBNotas()
    Public Function Consultar(ID_GRUPO As Integer) As List(Of Reportes)
        Return dbjuego_grupo.CONSULTAR(ID_GRUPO)
    End Function

    Public Function ConsultarPreguntas(ID_GRUPO As Integer) As List(Of Reportes)
        Return dbjuego_grupo.CONSULTARPREGUNTA(ID_GRUPO)
    End Function
    Public Function CONSULTA_FILTRADA(ID_JUEGO As Integer) As List(Of Reportes)
        Return dbjuego_grupo.CONSULTAR_NULL(ID_JUEGO)
    End Function
    Public Function Paginacion(ID As Integer, NumeroPaneles As Integer, ByRef Pagina As Integer, ByRef CantidadPaginas As Integer, Optional Filtro As String = "") As List(Of Reportes)
        Dim lista As List(Of Reportes) = Consultar(ID)
        If lista.Count > 0 Then


            If (Filtro <> "") Then

                lista = lista.Where(Function(x) x.JUEGO.ToLower().Contains(Filtro.ToLower())).ToList() 'LinQ

            End If
            CantidadPaginas = Math.Ceiling(lista.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
            Dim listaPaginacion As List(Of Reportes) = lista.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
            Return listaPaginacion
        Else
            Dim lista2 As List(Of Reportes) = CONSULTA_FILTRADA(ID)
            If (Filtro <> "") Then

                lista2 = lista2.Where(Function(x) x.JUEGO.ToLower().Contains(Filtro.ToLower())).ToList() 'LinQ

            End If
            CantidadPaginas = Math.Ceiling(lista2.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
            Dim listaPaginacion As List(Of Reportes) = lista2.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
            Return listaPaginacion
        End If

    End Function
End Class
