Imports DataBase
Imports Modelo
Public Class L_GRUPO_ALUMNO
    Public dbgrupo_alumno As DBGRUPO_ALUMNO = New DBGRUPO_ALUMNO()
    Public Function INSERTAR(ID_USUARIO As Integer, ID_GRUPO As Integer) As Boolean

        Return dbgrupo_alumno.INSERTAR(ID_USUARIO, ID_GRUPO)
    End Function
    Public Function CONSULTAR(ID_GRUPO As Integer) As List(Of Grupo_alumno)
        Return dbgrupo_alumno.CONSULTAR(ID_GRUPO)
    End Function
    Public Function BORRAR(ID_ALUMNO As Integer, ID_GRUPO As Integer)
        Return dbgrupo_alumno.BORRAR(ID_ALUMNO, ID_GRUPO)
    End Function
End Class
