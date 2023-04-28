Imports DataBase
Imports Modelo

Public Class L_JUGABILIDAD
    Public DB As DBMOSTRAR_PREGUNTAS = New DBMOSTRAR_PREGUNTAS
    Public DB_MOSTRAR_RETOS As DBMOSTRAR_RETOS = New DBMOSTRAR_RETOS
    Public Function CONSULTAR(ID_JUEGO As Integer) As List(Of Preguntas_mostrar)
        Return DB.CONSULTAR(ID_JUEGO)
    End Function
    Public Function CONSULTAR_RETO(ID_PREGUNTA As Integer) As List(Of Retos_mostrar)
        Return DB_MOSTRAR_RETOS.CONSULTAR(ID_PREGUNTA)
    End Function
    Public Function Paginacion_PREGUNTAS(ByRef Pagina_juego As Integer, ByRef CantidadPaginas_juego As Integer, lista As List(Of Preguntas_mostrar)) As List(Of Preguntas_mostrar)


        CantidadPaginas_juego = Math.Ceiling(lista.Count / 1) 'Se redondea en caso que sea un numero impar
        Dim listaPaginacion As List(Of Preguntas_mostrar) = lista.Skip((Pagina_juego - 1) * 1).
                                                Take(1).ToList()

        Return listaPaginacion
    End Function

End Class
