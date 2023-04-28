Public Class Mostrar_categoria
    Public tiempo_s As Integer
    Private Sub Mostrar_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.Black
        Me.BackColor = Color.Black
        FOTO_CAT.Image = String_imagen(FOTO_CAT_JUEGO)
        TXT_CATEGORIA.Text = CAT_JUEGO
        Tiempo.Start()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        tiempo_s += 1
        If tiempo_s >= 3 Then
            Tiempo.Stop()
            Juego.TIEMPO_CONTAR(True)
            Juego.REPRODUCIR(True)
            Me.Close()
        End If
    End Sub
End Class