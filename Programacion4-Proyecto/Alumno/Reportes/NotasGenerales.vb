Imports DataBase
Imports Logica
Imports Modelo

Public Class Stats
    Public LOGICA As L_REPORTE_ALUMNO = New L_REPORTE_ALUMNO
    Public pagina As Integer = 1
    Public CantidadPaginas As Integer
    Public LST As List(Of Reporte_general_alumno) = New List(Of Reporte_general_alumno)
    Private Sub btnATRAS_Click(sender As Object, e As EventArgs) Handles btnATRAS.Click
        MenuJugador.Show()
        Me.Close()
    End Sub

    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles Me.Load

        LST = LOGICA.CONSULTA_GENERAL()
        REFRESCAR()
        If (CantidadPaginas = 1 Or CantidadPaginas = 0) Then
            BTN_SIGUIENTE.Visible = False
        Else
            BTN_SIGUIENTE.Visible = True
        End If
    End Sub

    Public Sub REFRESCAR()
        P_JUEGO1.Visible = False
        P_JUEGO2.Visible = False
        P_JUEGO3.Visible = False
        P_JUEGO4.Visible = False
        P_JUEGO5.Visible = False
        P_JUEGO6.Visible = False
        If pagina = 1 Then
            BTN_REGRESAR.Visible = False
            BTN_SIGUIENTE.Visible = True
        Else
            BTN_REGRESAR.Visible = True
        End If
        If pagina = CantidadPaginas Then
            BTN_SIGUIENTE.Visible = False
        End If
        Dim LLENADO() As Boolean = {False, False, False, False, False, False}
        Dim contador As Integer = 0
        For Each fila In LOGICA.Paginacion(6, pagina, CantidadPaginas)
            If LLENADO(contador) = False Then
                Select Case contador
                    Case 0
                        TXT1.Text = fila.JUEGO
                        NOTA1.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA1.Text = "" Then
                            NOTA1.Text = 0
                        End If
                        BUENAS1.Text = fila.BUENAS
                        MALA1.Text = fila.MALAS
                        P_JUEGO1.Visible = True
                        PUNTAJE1.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                    Case 1
                        TXT2.Text = fila.JUEGO
                        NOTA2.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA2.Text = "" Then
                            NOTA2.Text = 0
                        End If
                        BUENAS2.Text = fila.BUENAS
                        MALA2.Text = fila.MALAS
                        P_JUEGO2.Visible = True
                        PUNTAJE2.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                    Case 2
                        TXT3.Text = fila.JUEGO
                        NOTA3.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA3.Text = "" Then
                            NOTA3.Text = 0
                        End If
                        BUENAS3.Text = fila.BUENAS
                        MALA3.Text = fila.MALAS
                        P_JUEGO3.Visible = True
                        PUNTAJE3.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                    Case 3
                        TXT4.Text = fila.JUEGO
                        NOTA4.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA4.Text = "" Then
                            NOTA4.Text = 0
                        End If
                        BUENAS4.Text = fila.BUENAS
                        MALA4.Text = fila.MALAS
                        P_JUEGO4.Visible = True
                        PUNTAJE4.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                    Case 4
                        TXT5.Text = fila.JUEGO
                        NOTA5.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA5.Text = "" Then
                            NOTA5.Text = 0
                        End If
                        BUENAS5.Text = fila.BUENAS
                        MALA5.Text = fila.MALAS
                        P_JUEGO5.Visible = True
                        PUNTAJE5.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                    Case 5
                        TXT6.Text = fila.JUEGO
                        NOTA6.Text = Format((fila.PUNTAJE_TOTAL / fila.PUNTAJE_TOTAL_JUEGO) * 100, "#.##")
                        If NOTA6.Text = "" Then
                            NOTA6.Text = 0
                        End If
                        BUENAS6.Text = fila.BUENAS
                        MALA6.Text = fila.MALAS
                        P_JUEGO6.Visible = True
                        PUNTAJE6.Text = $"{fila.PUNTAJE_TOTAL}/{fila.PUNTAJE_TOTAL_JUEGO}"
                End Select
                LLENADO(contador) = True
            End If
            contador += 1
        Next
    End Sub

    Private Sub NOTA1_Click(sender As Object, e As EventArgs) Handles NOTA1.Click

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub


    Private Sub P_JUEGO1_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO1.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT1.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA1.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE1.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub

    Private Sub P_JUEGO2_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO2.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT2.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA2.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE2.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub
    Private Sub P_JUEGO3_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO3.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT3.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA3.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE3.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub
    Private Sub P_JUEGO4_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO4.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT4.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA4.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE4.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub
    Private Sub P_JUEGO5_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO5.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT5.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA5.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE5.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub
    Private Sub P_JUEGO6_CLICK(sender As Object, e As EventArgs) Handles P_JUEGO6.Click
        Reporte_preguntas.ID_JUEGO_F = LST.Where(Function(x) x.JUEGO = TXT6.Text).First.ID_JUEGO
        Reporte_preguntas.NOTA1.Text = NOTA6.Text
        Reporte_preguntas.PUNTAJE1.Text = PUNTAJE6.Text
        Reporte_preguntas.ID_DEL_ALUMNO = CONEXIONES.ID_USUARIO_SESION
        Reporte_preguntas.Show()
    End Sub

    Private Sub BTN_SIGUIENTE_Click(sender As Object, e As EventArgs) Handles BTN_SIGUIENTE.Click
        pagina += 1
        REFRESCAR()
    End Sub

    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        pagina -= 1
        REFRESCAR()
    End Sub


End Class