Module PROCEDIMIENTOS
    Friend Function CARGAR_TABLA(ByRef Tabla_temporal As DataSet, ByVal Sql As String) As Boolean
        Try
            CONECTAR()
            Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
            Consulta.Fill(Tabla_temporal)
            DESCONECTAR()
            Return True
        Catch ex As Exception
            DESCONECTAR()
            Return False
        End Try

    End Function

    Friend Function EJECUTAR(ByVal Sql As String) As Boolean
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)

        Try
            Comando.ExecuteNonQuery()
            DESCONECTAR()
            Return True
        Catch ex As Exception
            DESCONECTAR()
            Return False
        End Try

    End Function
    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        T.Tables.Clear()
        SQL = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            SQL = "SELECT MAX(ID) FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If
    End Function
End Module