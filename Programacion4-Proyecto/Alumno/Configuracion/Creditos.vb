Public Class Creditos
    Private Sub Creditos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Configuracion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Configuracion.Show()
        Me.Close()
    End Sub
End Class