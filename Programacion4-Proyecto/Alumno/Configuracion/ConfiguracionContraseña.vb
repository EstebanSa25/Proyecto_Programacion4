Imports System.IO
Imports DataBase
Imports Modelo
Imports Logica
Public Class ConfiguracionContraseña
    Dim l_datos_personales As L_DATOS_PERSONALES = New L_DATOS_PERSONALES()
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Alerta_estado As Integer
        Select Case l_datos_personales.Actualizar_Clave(txtPASSVIEJA.Text, txtNUEVA.Text, txtCONFIRMAR.Text, Alerta_estado)
            Case True
                MsgBox("Contraseña actualizada correctamente")
                'Alerta_correcto(transicion_para_alertas, "Dato acualizado", "Contraseña actualizada correctamente")
                txtPASSVIEJA.Text = ""
                txtCONFIRMAR.Text = ""
                txtNUEVA.Text = ""
            Case False
                Select Case Alerta_estado
                    Case 2
                        MsgBox("Las contraseñas no son iguales")
                        'Alerta_advertencia(transicion_para_alertas, "Las contraseñas no son iguales")
                        txtCONFIRMAR.Text = ""
                    Case 3
                        MsgBox("Esta no es tu contraseña actual")
                        'Alerta_incorrecto(transicion_para_alertas, "Error", "Esta no es tu contraseña actual")
                        txtPASSVIEJA.Text = ""
                End Select

        End Select
    End Sub



    Private Sub Titulo_Click(sender As Object, e As EventArgs) Handles Titulo.Click

    End Sub

    Private Sub txtCONFIRMAR_TextChanged(sender As Object, e As EventArgs) Handles txtCONFIRMAR.TextChanged

    End Sub
End Class