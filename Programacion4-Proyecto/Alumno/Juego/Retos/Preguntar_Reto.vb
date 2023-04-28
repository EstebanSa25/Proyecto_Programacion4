Public Class Preguntar_Reto
    Public pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Private Sub Preguntar_Reto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Video_fondo.URL = $"{Application.StartupPath}\Videos_fondo\Fondo_Retos.mkv"
        Video_fondo.settings.setMode("loop", True)
        Video_fondo.settings.volume = 0

        Video_fondo.Size = New System.Drawing.Size(Convert.ToInt32(pantalla.Bounds.Width.ToString()), Convert.ToInt32(pantalla.Bounds.Height.ToString()))
    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        RETO_ACEPTADO = True
        Juego.pagina += 1
        Juego.REFRESCAR()
        Me.Close()
    End Sub

    Private Sub BTN_RECHAZAR_Click(sender As Object, e As EventArgs) Handles BTN_RECHAZAR.Click
        RETO_ACEPTADO = False
        If Juego.ULTIMO Then
            MenuJugador.Show()
            Juego.Close()
            Me.Close()
        Else
            Juego.pagina += 1
            Juego.REFRESCAR()
            Me.Close()
        End If

    End Sub


End Class