Imports DataBase
Imports Modelo
Public Class L_REPORTE_ALUMNO

    Public DB As DBREPORTE_ALUMNO = New DBREPORTE_ALUMNO
    Public Function CONSULTA_GENERAL() As List(Of Reporte_general_alumno)
        Return DB.CONSULTAR(ID_USUARIO_SESION)
    End Function
    Public Function Paginacion(NumeroPaneles As Integer, ByRef Pagina As Integer, ByRef CantidadPaginas As Integer, Optional Filtro As String = "") As List(Of Reporte_general_alumno)

        Dim lista As List(Of Reporte_general_alumno) = CONSULTA_GENERAL()


        CantidadPaginas = Math.Ceiling(lista.Count / NumeroPaneles) 'Se redondea en caso que sea un numero impar
        Dim listaPaginacion As List(Of Reporte_general_alumno) = lista.Skip((Pagina - 1) * NumeroPaneles).
                                                Take(NumeroPaneles).ToList()
        Return listaPaginacion
    End Function
    Public Function CONSULTA_PREGUNTA(ID_JUEGO As Integer, ID_USUARIO As Integer) As List(Of Reporte_Preguntas)
        Return DB.CONSULTAR_PREGUNTA(ID_JUEGO, ID_USUARIO)
    End Function
    Public Function CONSULTA_RETO(ID_PREGUNTA As Integer) As List(Of Reporte_alumno_Retos)
        Return DB.CONSULTAR_RETO(ID_PREGUNTA, ID_USUARIO_SESION)
    End Function
End Class
