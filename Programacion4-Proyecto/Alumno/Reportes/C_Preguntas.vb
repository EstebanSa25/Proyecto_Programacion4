Public Class C_Preguntas
    Private PREGUNTA As String = "TEXTO"
    Private OPCION1 As String = "OPC1"
    Private OPCION2 As String = "OPC2"
    Private OPCION3 As String = "OPC3"
    Private OPCION4 As String = "OPC4"

    Private Sub C_Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        Me.Size = New System.Drawing.Size(Convert.ToInt32(pantalla.Bounds.Width.ToString()), 420)
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then
            Grupo1.Location = New Point((((Convert.ToInt32(pantalla.Bounds.Width.ToString())) - 1081) - 500), 9)
        End If

    End Sub


End Class
