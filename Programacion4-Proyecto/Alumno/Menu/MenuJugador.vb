Imports DataBase
Imports Modelo
Imports Logica
Imports System.Threading

Public Class MenuJugador
    Dim lista As List(Of FORMULARIO) = New List(Of FORMULARIO)
    Dim l_datos_personales As L_DATOS_PERSONALES = New L_DATOS_PERSONALES()
    Dim VERJUEGO As L_VERJUEGO = New L_VERJUEGO()
    Public LOGICA_PREGUNTAS As L_JUGABILIDAD = New L_JUGABILIDAD
    Public LST_PREGUNTAS_JUEGO As List(Of Preguntas_mostrar) = New List(Of Preguntas_mostrar)

    Friend Sub REFRESCAR()
        Dim contador As Integer = 0
        lista = VERJUEGO.CONSULTAR_POR_ID()
        L.Rows.Clear()
        If lista.Count > 0 Then
            L.Rows.Add(lista.Count)
            For Each datos In lista
                L.Rows(contador).Cells(0).Value = datos.JUEGO
                L.Rows(contador).Cells(1).Value = datos.ID_JUEGO
                contador += 1
            Next

        End If

    End Sub

    Private Sub btnCONFIG_Click(sender As Object, e As EventArgs) Handles btnCONFIG.Click
        cosa = 2
        Configuracion.Show()
        Me.Close()
    End Sub

    Private Sub btnMIN_Click(sender As Object, e As EventArgs) Handles btnMIN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Login2.Show()
        Me.Close()
    End Sub

    Private Sub FOTO_Click(sender As Object, e As EventArgs)
        cosa = 1
        ConfiguracionCuenta.Show()
        Me.Close()
    End Sub

    Private Sub MenuJugador_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Datos_usuario = l_datos_personales.OBTENER_DATOS()
        REFRESCAR()
        FOTO.Image = String_imagen(Datos_usuario.FOTO)
        Video_fondo.URL = Application.StartupPath + "/Menu_video.mp4"
        Video_fondo.settings.setMode("loop", True)
        Video_fondo.Ctlcontrols.play()
    End Sub

    Private Sub btnGRUPO_Click(sender As Object, e As EventArgs) Handles btnGRUPO.Click
        ALUMNOGRUPOS.Show()
        Me.Hide()
    End Sub
    Friend Sub CONSULTAR_PREGUNTAS()
        LST_PREGUNTAS_JUEGO = LOGICA_PREGUNTAS.CONSULTAR(Convert.ToInt64(L.SelectedCells(1).Value))
        Juego.LST_PREGUNTAS = LST_PREGUNTAS_JUEGO
        For Each lst In LST_PREGUNTAS_JUEGO
            If lst.Preguntas.VIDEO <> "" Then
                Dim String_byte_2 As Byte() = String_byte(lst.Preguntas.VIDEO)
                CrearArchivo(String_byte_2, Application.StartupPath, $"Video_{lst.Preguntas.ID_PREGUNTA}", $"{lst.Preguntas.EXTENSION}")
            ElseIf lst.Preguntas.AUDIO <> "" Then
                Dim String_byte_2 As Byte() = String_byte(lst.Preguntas.AUDIO)
                CrearArchivo(String_byte_2, Application.StartupPath, $"Video_{lst.Preguntas.ID_PREGUNTA}", $"{lst.Preguntas.EXTENSION}")
            End If

        Next
    End Sub
    Private Sub btnJUGAR_Click(sender As Object, e As EventArgs) Handles btnJUGAR.Click
        If L.SelectedCells.Count > 0 Then
            Juego.ID_JUEGO = Convert.ToInt64(L.SelectedCells(1).Value)

            CONSULTAR_PREGUNTAS()
            Juego.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnSTATS_Click(sender As Object, e As EventArgs) Handles btnSTATS.Click
        Reporte_preguntas.Procedimiento = 1
        Stats.Show()
        Me.Close()
    End Sub

    Private Sub L_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles L.CellContentClick
        If L.SelectedCells.Count > 0 Then
            btnJUGAR.Enabled = True
        Else
            btnJUGAR.Enabled = False
        End If
    End Sub
End Class