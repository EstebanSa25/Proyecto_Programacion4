Imports DataBase
Imports Modelo
Public Class L_PREGUNTAS
    Dim PREGUNTAdb As DBPREGUNTA = New DBPREGUNTA
    Dim categoriaDB As DBCATEGORIA = New DBCATEGORIA
    Private LOGICAJUEGO As L_JUEGO = New L_JUEGO
    Private LOGICAOPCIONES As L_OPCIONES = New L_OPCIONES
    Public Sub INSERTAR(ID_CATEGORIA As Integer, PREGUNTA As String, ID_JUEGO As Integer, PUNTO As Integer, TIEMPO As Double, FOTO As String, VIDEO As String, AUDIO As String, EXTENSION As String)
        PREGUNTAdb.INSERTAR(ID_CATEGORIA, PREGUNTA, ID_JUEGO, PUNTO, TIEMPO, FOTO, VIDEO, AUDIO, EXTENSION)
    End Sub
    Public Function CONSULTAR_POR_JUEGO(PREGUNTA As String, ID_JUEGO As Integer, ID_CATEGORIA As Integer) As List(Of Pregunta)
        Return PREGUNTAdb.CONSULTAR(0, PREGUNTA, ID_JUEGO, ID_CATEGORIA)
    End Function
    Public Function CONSULTAR_ID(ID_JUEGO As Integer) As List(Of Pregunta)
        Return PREGUNTAdb.CONSULTAR_ID(ID_JUEGO)
    End Function
    Public Function ACTUALIZAR(ID_CATEGORIA As Integer, PREGUNTA As String, PUNTO As Integer, TIEMPO As Double, FOTO As String, VIDEO As String, AUDIO As String, ID_PREGUNTA As Integer, EXTENSION As String)
        Return PREGUNTAdb.ACTUALIZAR(ID_CATEGORIA, PREGUNTA, PUNTO, TIEMPO, FOTO, VIDEO, AUDIO, ID_PREGUNTA, EXTENSION)
    End Function
    Public Function INSERTAR_EDITAR_PREGUNTA_OPCIONES(Checkboxs() As Boolean, JUEGO_TEXTO As String, ID_CATEGORIA As Integer, Pregunta As String, Puntos As Integer, Tiempo As Integer, respuestas() As String, Procedimiento As Integer, ID_PREGUNTA_F As Integer, LST_OPCIONES As List(Of Opciones), video As String, EXTENSION As String, foto As String, Audio As String)
        Dim ID_JUEG0 = LOGICAJUEGO.CONSULTAR_POR_JUEGO_IDUSUARIO(JUEGO_TEXTO)
        If Procedimiento = 2 Then

            INSERTAR(ID_CATEGORIA, Pregunta, ID_JUEG0.ID_JUEGO, CInt(Puntos), Tiempo, foto, video, Audio, EXTENSION)

            Dim LST_PREGUNTA As List(Of Pregunta) = CONSULTAR_POR_JUEGO(Pregunta, ID_JUEG0.ID_JUEGO, ID_CATEGORIA)
            LOGICAOPCIONES.INSERTAR(LST_PREGUNTA.First.ID_PREGUNTA, respuestas(0), Checkboxs(0))
            LOGICAOPCIONES.INSERTAR(LST_PREGUNTA.First.ID_PREGUNTA, respuestas(1), Checkboxs(1))
            LOGICAOPCIONES.INSERTAR(LST_PREGUNTA.First.ID_PREGUNTA, respuestas(2), Checkboxs(2))
            LOGICAOPCIONES.INSERTAR(LST_PREGUNTA.First.ID_PREGUNTA, respuestas(3), Checkboxs(3))
            If MsgBox("¿Deseas agregar mas preguntas?", vbInformation + vbYesNo, "ok") = vbYes Then
                Return True
            Else
                Return False
            End If
        Else
            ACTUALIZAR(ID_CATEGORIA, Pregunta, Puntos, Tiempo, foto, video, Audio, ID_PREGUNTA_F, EXTENSION)
            LOGICAOPCIONES.ACTUALIZAR(respuestas(0), Checkboxs(0), LST_OPCIONES.First.ID_opciones)
            LOGICAOPCIONES.ACTUALIZAR(respuestas(1), Checkboxs(1), LST_OPCIONES.Skip(1).Take(1).First.ID_opciones)
            LOGICAOPCIONES.ACTUALIZAR(respuestas(2), Checkboxs(2), LST_OPCIONES.Skip(2).Take(1).First.ID_opciones)
            LOGICAOPCIONES.ACTUALIZAR(respuestas(3), Checkboxs(3), LST_OPCIONES.Skip(3).Take(1).First.ID_opciones)
            Return False
        End If

    End Function
    Public Function BORRAR(ID_PREGUNTA As Integer) As Boolean
        Return PREGUNTAdb.BORRAR(ID_PREGUNTA)
    End Function

    Public Function Validar_checkbox(Checkbox As Integer, ByRef CheckBox1 As Boolean, ByRef CheckBox2 As Boolean, ByRef CheckBox3 As Boolean, ByRef CheckBox4 As Boolean) As Boolean
        Select Case Checkbox
            Case 1
                If CheckBox1 = True Then
                    ' CheckBox1.BackgroundImage = My.Resources.checked
                    CheckBox2 = False
                    CheckBox3 = False
                    CheckBox4 = False
                    Return True
                Else
                    ' CheckBox1.BackgroundImage = My.Resources.unchecked
                    CheckBox2 = True
                    CheckBox3 = True
                    CheckBox4 = True
                    Return False
                End If
            Case 2
                If CheckBox2 = True Then
                    '  CheckBox2.BackgroundImage = My.Resources.checked
                    CheckBox1 = False
                    CheckBox3 = False
                    CheckBox4 = False
                    Return True
                Else
                    ' CheckBox2.BackgroundImage = My.Resources.unchecked
                    CheckBox1 = True
                    CheckBox3 = True
                    CheckBox4 = True
                    Return False
                End If
            Case 3
                If CheckBox3 = True Then
                    ' CheckBox3.BackgroundImage = My.Resources.checked
                    CheckBox2 = False
                    CheckBox1 = False
                    CheckBox4 = False
                    Return True
                Else
                    '   CheckBox3.BackgroundImage = My.Resources.unchecked
                    CheckBox2 = True
                    CheckBox1 = True
                    CheckBox4 = True
                    Return False
                End If
            Case 4
                If CheckBox4 = True Then
                    '   CheckBox4.BackgroundImage = My.Resources.checked
                    CheckBox2 = False
                    CheckBox3 = False
                    CheckBox1 = False
                    Return True
                Else
                    '  CheckBox4.BackgroundImage = My.Resources.unchecked
                    CheckBox2 = True
                    CheckBox3 = True
                    CheckBox1 = True
                    Return False
                End If
        End Select
        Return False
    End Function
    Public Function validar_lleno(Pregunta As String, TXT_RESPUESTA3 As String, TXT_RESPUESTA2 As String, TXT_RESPUESTA1 As String, TXT_RESPUESTA4 As String, Puntos As String, Tiempo As Integer, checkbox1 As Boolean, checkbox2 As Boolean, checkbox3 As Boolean, checkbox4 As Boolean)
        If Pregunta <> "" And TXT_RESPUESTA3 <> "" And TXT_RESPUESTA2 <> "" And TXT_RESPUESTA1 <> "" And TXT_RESPUESTA4 <> "" And Puntos <> "" And Tiempo <> 0 Then
            If checkbox1 = True Or checkbox2 = True Or checkbox3 = True Or checkbox4 = True Then
                Return True
            Else
                Return False
            End If
        Else
                Return False
        End If
    End Function
End Class
