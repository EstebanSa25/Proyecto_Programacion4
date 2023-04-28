Imports DataBase
Imports Modelo

Public Class L_OPCIONES_RETOS
    Public DBOPCIONES As DBOPCIONES_RETOS = New DBOPCIONES_RETOS
    Public Function INSERTAR(ID_RETO As Integer, DESCRIPCION As String, CORRECTA As Boolean)
        Return DBOPCIONES.INSERTAR(ID_RETO, DESCRIPCION, CORRECTA)
    End Function
    Public Function ACTUALIZAR(DESCRIPCION As String, CORRECTA As Boolean, ID_OPCIONES_RETOS As Integer)
        Return DBOPCIONES.ACTUALIZAR(DESCRIPCION, CORRECTA, ID_OPCIONES_RETOS)
    End Function
    Public Function CONSULTAR(ID_RETO As Integer) As List(Of Opciones_retos)
        Return DBOPCIONES.CONSULTAR(ID_RETO)
    End Function
End Class
