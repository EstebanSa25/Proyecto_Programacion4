Public Class Configuracion
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click

        ConfiguracionCuenta.Show()
        Me.Hide()

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        MenuJugador.Show()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub btnGrafics_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub Titulo_Click(sender As Object, e As EventArgs) Handles Titulo.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.Alerta, AudioPlayMode.Background)
    End Sub

    Private Sub IconSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles IconSplitButton1.ButtonClick

    End Sub
End Class