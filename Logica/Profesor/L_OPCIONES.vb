Imports DataBase
Imports Modelo
Public Class L_OPCIONES
    Dim DBOPCIONES As DBOPCIONES = New DBOPCIONES()
    Public Function INSERTAR(ID_PREGUNTA As Integer, DESCRIPCION As String, CORRECTA As Boolean)
        Return DBOPCIONES.INSERTAR(ID_PREGUNTA, DESCRIPCION, CORRECTA)
    End Function
    Public Function ACTUALIZAR(DESCRIPCION As String, CORRECTA As Boolean, ID_OPCIONES As Integer)
        Return DBOPCIONES.ACTUALIZAR(DESCRIPCION, CORRECTA, ID_OPCIONES)
    End Function
    Public Function CONSULTAR(ID_OPCIONES As Integer, DESCRIPCION As String, ID_PREGUNTA As Integer) As List(Of Opciones)
        Return DBOPCIONES.CONSULTAR(ID_OPCIONES, DESCRIPCION, ID_PREGUNTA)
    End Function
End Class
