Imports DataBase

Public Class L_RESPUESTA_ALUMNO
    Public DB As DBRESPUESTA_ALUMNO = New DBRESPUESTA_ALUMNO
    Public Function INSERTAR(ID_OPCION As Integer) As Boolean
        Return DB.INSERTAR(ID_OPCION, ID_USUARIO_SESION)
    End Function
    Public Function INSERTAR_RESPUESTA_RETO(ID_OPCION As Integer) As Boolean
        Return DB.INSERTAR_RETO(ID_USUARIO_SESION, ID_OPCION)
    End Function
End Class
