Imports Modelo

Public Class DBMOSTRAR_PREGUNTAS
    Inherits ConsultaGenerica
    Dim spNombre = "SP_MOSTRAR_PREGUNTAS_JUEGO"

    Public Function CONSULTAR(ID_JUEGO As Integer) As List(Of Preguntas_mostrar)

        listaNombreParametros.Clear()
        listaValores.Clear()


        listaNombreParametros.Add("ID_JUEGO", False)
        listaValores.Add(CStr(ID_JUEGO))
        If EjecutarSP(spNombre, TipoSentenciaSQL.CONSULTAR) = False Then
            Return Nothing
        End If

        Dim lst_preguntas As List(Of Preguntas_mostrar) = ConvertirPreguntas()

        Return lst_preguntas

    End Function

    Private Function ConvertirPreguntas() As List(Of Preguntas_mostrar)

        Dim lista As List(Of Preguntas_mostrar) = New List(Of Preguntas_mostrar)
        For Each fila In dataSet.Tables(0).Rows

            Dim pregunta As Preguntas_mostrar = New Preguntas_mostrar
            pregunta.Preguntas.ID_CATEGORIA = fila("ID_CATEGORIA")
            pregunta.Preguntas.PREGUNTA = fila("PREGUNTA")
            pregunta.Preguntas.ID_JUEGO = fila("ID_JUEGO")
            pregunta.Preguntas.PUNTAJE = fila("PUNTAJE")
            pregunta.Preguntas.ID_PREGUNTA = fila("ID_PREGUNTA")
            pregunta.Preguntas.TIEMPO = fila("TIEMPO")
            pregunta.Preguntas.FOTO = fila("FOTO")
            pregunta.Preguntas.VIDEO = fila("VIDEO")
            pregunta.Preguntas.AUDIO = fila("AUDIO")
            pregunta.CATEGORIA = fila("CATEGORIA")
            pregunta.FOTO_CATEGORIA = fila("FOTO_CATEGORIA")
            If IsDBNull(fila("EXTENSION")) = True Then
                pregunta.Preguntas.EXTENSION = ""
            Else
                pregunta.Preguntas.EXTENSION = fila("EXTENSION")
            End If
            lista.Add(pregunta)
        Next
        Return lista
    End Function
End Class
