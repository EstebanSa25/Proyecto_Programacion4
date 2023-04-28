Public Class ALERTAS_POPUP
    Public Segundo As Integer
    Public Barra As Integer
    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Private Sub Guna2ProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles BARRA_CARGA.ValueChanged
    End Sub

    Private Sub GRUPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Size(CInt(pantalla.Bounds.Width.ToString() - 450), CInt(pantalla.Bounds.Height.ToString()) - 80)
        Tiempo.Start()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Segundo += 1
        If Segundo >= 40 Then
            Tiempo.Stop()
            Me.Close()
        End If
    End Sub

    Public Sub EJECUTAR_ALERTA(Titulo As String, contenido As String, tipo As Integer)
        Select Case tipo
            Case 1 'correcto
                Dim color_oscuro() As Integer = {42, 95, 0}
                Dim Fondo_color() As Integer = {143, 206, 0}
                obtener_color(Fondo_color, color_oscuro)
                Me.ICONO_ALERTA.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
                Texto_titulo.Text = Titulo
                Texto_contenido.Text = contenido
            Case 2 'incorrecto
                Dim color_oscuro() As Integer = {153, 0, 0}
                Dim Fondo_color() As Integer = {250, 71, 71}
                obtener_color(Fondo_color, color_oscuro)
                Me.ICONO_ALERTA.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
                Texto_titulo.Text = Titulo
                Texto_contenido.Text = contenido
            Case 3 'Alerta
                Dim color_oscuro() As Integer = {127, 96, 0}
                Dim Fondo_color() As Integer = {241, 194, 50}
                obtener_color(Fondo_color, color_oscuro)
                Me.ICONO_ALERTA.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
                Texto_titulo.Text = Titulo
                Texto_contenido.Text = contenido
        End Select


    End Sub

    Public Sub obtener_color(Fondo As Integer(), color_oscuro As Integer())
        Me.BARRA_CARGA.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(color_oscuro(0), Byte), Integer), CType(CType(color_oscuro(1), Byte), Integer), CType(CType(color_oscuro(2), Byte), Integer))
        Me.ICONO_ALERTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(Fondo(0), Byte), Integer), CType(CType(Fondo(1), Byte), Integer), CType(CType(Fondo(2), Byte), Integer))
        Me.ICONO_ALERTA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(color_oscuro(0), Byte), Integer), CType(CType(color_oscuro(1), Byte), Integer), CType(CType(color_oscuro(2), Byte), Integer))
        Me.FONDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(Fondo(0), Byte), Integer), CType(CType(Fondo(1), Byte), Integer), CType(CType(Fondo(2), Byte), Integer))
        Texto_titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(color_oscuro(0), Byte), Integer), CType(CType(color_oscuro(1), Byte), Integer), CType(CType(color_oscuro(2), Byte), Integer))
        Texto_contenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(color_oscuro(0), Byte), Integer), CType(CType(color_oscuro(1), Byte), Integer), CType(CType(color_oscuro(2), Byte), Integer))
        BTN_CERRAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(color_oscuro(0), Byte), Integer), CType(CType(color_oscuro(1), Byte), Integer), CType(CType(color_oscuro(2), Byte), Integer))
    End Sub

    Private Sub FONDO_Paint(sender As Object, e As PaintEventArgs) Handles FONDO.Paint

    End Sub

    Private Sub Texto_contenido_Click(sender As Object, e As EventArgs) Handles Texto_contenido.Click

    End Sub

    Private Sub ICONO_ALERTA_Click(sender As Object, e As EventArgs) Handles ICONO_ALERTA.Click

    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        Me.Close()
    End Sub
End Class
