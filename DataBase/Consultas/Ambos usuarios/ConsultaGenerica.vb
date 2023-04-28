Public Class ConsultaGenerica

    Public dataSet As DataSet
    Public listaNombreParametros As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)
    Public listaValores As List(Of String) = New List(Of String)
    Private Function ObtenerParametros() As String

        Dim contador As Integer = 0
        Dim SQLParametros As String = ""

        For Each NombreParametro In listaNombreParametros.Keys() 'Recorremos la lista (todas sus keys)
            Dim LlevaComillas As Boolean 'Con esta variable vamos a saber si el dato ocupa comillas si es string o no ocupa si es entero
            listaNombreParametros.TryGetValue(NombreParametro, LlevaComillas) 'Devolvemos el valor true o false con base a lo que tenga el Key

            If LlevaComillas Then 'Si el dato es string
                SQLParametros += $"@{NombreParametro} = '{listaValores(contador)}',"

            Else 'Si el dato no es string""
                SQLParametros += $"@{NombreParametro} = {listaValores(contador)},"
            End If
            contador = contador + 1
        Next

        SQLParametros = SQLParametros.Substring(0, SQLParametros.Length - 1) 'Quita la ultima coma

        Return SQLParametros
    End Function
    Public Function EjecutarSP(nombre_SP As String, tipoSentencia As TipoSentenciaSQL) As Boolean
        Try
            T.Clear()
            Dim SQLParametros As String
            SQLParametros = ObtenerParametros()
            SQL = $"exec {nombre_SP} @PROCEDIMIENTO={CInt(tipoSentencia)}, {SQLParametros}"
            If tipoSentencia <> TipoSentenciaSQL.CONSULTAR And tipoSentencia <> TipoSentenciaSQL.CONSULTA_FILTRADA Then
                Dim correcto As Boolean = EJECUTAR(SQL)
                If correcto = True Then
                    Return True
                Else
                    Return False
                End If
            Else

                Dim correcto As Boolean = CARGAR_TABLA(T, SQL)
                If correcto = True Then
                    dataSet = T
                    Return True
                Else
                    Return False
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class


Public Enum TipoSentenciaSQL
    INSERTAR = 1
    ACTUALIZAR = 2
    CONSULTAR = 3
    BORRAR = 4
    CONSULTA_FILTRADA = 5
End Enum