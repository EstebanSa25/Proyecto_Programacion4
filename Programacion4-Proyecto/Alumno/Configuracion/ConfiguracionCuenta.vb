Imports DataBase
Imports Modelo
Imports Logica
Public Class ConfiguracionCuenta
    Dim l_datos_personales As L_DATOS_PERSONALES = New L_DATOS_PERSONALES()
    Private Sub Titulo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Configuracion.Show()
        Me.Close()
    End Sub

    Private Sub btnContraseña_Click(sender As Object, e As EventArgs) Handles btnContraseña.Click
        ConfiguracionContraseña.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ALERTAS_POPUP.Close()

        Try
            Select Case l_datos_personales.ACTUALIZAR_DATOS_PERSONALES(txtCorreo.Text, txtNum.Text, Imagen_string1(FOTO.Image))
                Case True

                    Alerta_correcto(transicion_para_alertas, "Correcto", "Datos actualizados")
                Case False
                    Alerta_incorrecto(transicion_para_alertas, "Incorrecto", "Erros al actualizar los datos")
            End Select
        Catch ex As Exception
            Alerta_advertencia(transicion_para_alertas, "Advertencia", "Verifica tus datos")
        End Try

    End Sub

    Private Sub ConfiguracionCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Datos_usuario = l_datos_personales.OBTENER_DATOS()
        txtCorreo.Text = Datos_usuario.EMAIL
        txtNum.Text = Datos_usuario.TELEFONO
        FOTO.Image = String_imagen(Datos_usuario.FOTO)
    End Sub

    Private Sub FOTO_Click(sender As Object, e As EventArgs) Handles FOTO.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            FOTO.Image.Dispose()
            FOTO.Image = Image.FromFile(ABRIR.FileName)
        End If
    End Sub
End Class