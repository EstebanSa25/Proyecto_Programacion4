Imports DataBase
Public Class L_REGISTRO
    Dim usuarioDB As DBUsuario = New DBUsuario
    Public Function INSERTAR(EMAIL As String, CLAVE As String, TELEFONO As Integer, ID_ROL_COMBOBOX As String, IMAGEN As String, NOMBRE As String) As Boolean
        Dim ID As Integer
        Select Case ID_ROL_COMBOBOX
            Case "Alumno"
                ID = 1
            Case "Profesor"
                ID = 2
        End Select
        Try

        Catch ex As Exception

        End Try

        If usuarioDB.INSERTAR(EMAIL, CLAVE, TELEFONO, ID, IMAGEN, NOMBRE) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function VALIDAR_DATOS(EMAIL As String, CLAVE As String, TELEFONO As String, ROL As String, FOTO As Boolean, NOMBRE As String) As Boolean
        If EMAIL <> "" And CLAVE <> "" And TELEFONO <> "" And ROL <> "" And FOTO <> False And NOMBRE <> "" Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
