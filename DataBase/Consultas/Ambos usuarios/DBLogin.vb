Public Class DBLogin
    Public Function Validar_Login(EMAIL As String, CLAVE As String) As Boolean
        Try
            T.Clear()
            SQL = "declare @retorno bit;exec @retorno=PR_VALIDAR_LOGIN'" & EMAIL & "','" & CLAVE & "'select 'LOGIN'=@retorno;"
            CARGAR_TABLA(T, SQL)
            Dim Login As Boolean = T.Tables(0).Rows(0)("LOGIN")
            T.Clear()
            Return Login
        Catch ex As Exception
            MsgBox("Error de DB")
            Return False
        End Try

    End Function
End Class
