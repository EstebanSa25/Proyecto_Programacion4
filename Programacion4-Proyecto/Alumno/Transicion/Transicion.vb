Public Class Transicion
    Dim segundos As Double = 0

    Private Sub Transicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Video_fondo.URL = Application.StartupPath + "/Transicion.mp4"
        Video_fondo.settings.setMode("play", True)
        Tiempo.Start()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        segundos += 1
        If segundos > 1.29 Then
            Tiempo.Stop()
            Juego.Show()
            Mostrar_categoria.Show()
            Mostrar_categoria.Focus()
            Me.Close()
        End If
    End Sub
End Class