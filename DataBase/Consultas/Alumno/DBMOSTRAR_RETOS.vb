Imports Modelo

Public Class DBMOSTRAR_RETOS
    Inherits ConsultaGenerica
    Dim spNombre = "SP_MOSTRAR_RETO_JUEGO"

    Public Function CONSULTAR(ID_PREGUNTA As Integer) As List(Of Retos_mostrar)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_PREGUNTA", False)
        listaValores.Add(CStr(ID_PREGUNTA))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lst_preguntas As List(Of Retos_mostrar) = ConvertirPreguntas()

        Return lst_preguntas

    End Function

    Private Function ConvertirPreguntas() As List(Of Retos_mostrar)

        Dim lista As List(Of Retos_mostrar) = New List(Of Retos_mostrar)
        For Each fila In dataSet.Tables(0).Rows

            Dim pregunta As Retos_mostrar = New Retos_mostrar
            pregunta.Retos.ID_CATEGORIA = fila("ID_CATEGORIA")
            pregunta.Retos.RETO = fila("RETO")
            pregunta.Retos.ID_RETO = fila("ID_RETO")
            pregunta.Retos.ID_PREGUNTA = fila("ID_PREGUNTA")
            pregunta.Retos.PUNTAJE = fila("PUNTAJE")
            pregunta.Retos.TIEMPO = fila("TIEMPO")
            pregunta.Retos.FOTO = fila("FOTO")
            pregunta.Retos.VIDEO = fila("VIDEO")
            pregunta.Retos.AUDIO = fila("AUDIO")
            pregunta.CATEGORIA = fila("CATEGORIA")
            pregunta.FOTO_CATEGORIA = fila("FOTO_CATEGORIA")
            If IsDBNull(fila("EXTENSION")) = True Then
                pregunta.Retos.EXTENSION = ""
            Else
                pregunta.Retos.EXTENSION = fila("EXTENSION")
            End If
            lista.Add(pregunta)
        Next
        Return lista
    End Function
End Class
