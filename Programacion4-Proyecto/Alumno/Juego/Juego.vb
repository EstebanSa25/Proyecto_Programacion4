Imports System.Windows.Documents
Imports DataBase
Imports Logica
Imports Microsoft.VisualBasic.Devices
Imports Modelo
Imports System.Windows.Media

Public Class Juego
    Public pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public Tiempo_contador_s As Integer
    Public tiempo_temporal As Double
    Public ID_JUEGO As Integer
    Public LST_PREGUNTAS As List(Of Preguntas_mostrar) = New List(Of Preguntas_mostrar)
    Public LST_OPCIONES As List(Of Opciones) = New List(Of Opciones)
    Public LST_OPCIONES_RETOS As List(Of Opciones_retos) = New List(Of Opciones_retos)
    Public contador As Integer
    Public pagina As Integer = 1
    Public CantidadPaginas As Integer
    Public JUGABILIDAD As L_JUGABILIDAD = New L_JUGABILIDAD
    Public LOGICA_OPCIONES As L_OPCIONES = New L_OPCIONES
    Public LOGICA_OPCIONES_retos As L_OPCIONES_RETOS = New L_OPCIONES_RETOS
    Public LOGICA_RESPUESTA_ALUMNO As L_RESPUESTA_ALUMNO = New L_RESPUESTA_ALUMNO
    Public LOGICA_RETO As L_RETOS = New L_RETOS
    Public VALIDACION_RETO As Boolean = False
    Public Tiempo_categoria_segundos As Integer
    Public CATEGORIA_EFECTO As Boolean
    Public CONT_VIDEO_AUDIO As Boolean
    Public CONT_FOTO As Boolean
    Public URL_VIDEO As String
    Public LST_RETO As List(Of Retos_mostrar) = New List(Of Retos_mostrar)
    Public ISRETO As Boolean
    Public ULTIMO As Boolean

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then 'Responsive 1920 0 1280
            BTN_OPCION1.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION1.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION1.Location = New Point(104, 768)
            BTN_OPCION2.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION2.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION2.Location = New Point(104, 890)
            BTN_OPCION3.Location = New Point(972, 768)
            BTN_OPCION3.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION3.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION4.Location = New Point(972, 890)
            BTN_OPCION4.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION4.ImageSize = New System.Drawing.Size(846, 93)
            TIEMPO_BARRA.Size = New System.Drawing.Size(1566, 20)
            TIEMPO_BARRA.Location = New System.Drawing.Size(189, 1016)
            TXT_PREGUNTA.Location = New Point(0, 29)
            'TXT_PREGUNTA.Size = New System.Drawing.Size(960, 41)
            FOTO_PREGUNTA.Location = New Point(529, 309)
            FOTO_PREGUNTA.Size = New System.Drawing.Size(624, 335)

            PANEL_ARCHIVO_M.Size = New System.Drawing.Size(624, 335)
            PANEL_ARCHIVO_M.Location = New Point(480, 318)

            TXT_PREGUNTA.Location = New Point(0, 82)
            Video_reproductor.Size = New System.Drawing.Size(624, 335)
            Video_reproductor.Location = New Point(480, 318)
        Else
            FONDO_BOTONES.Visible = False
        End If
    End Sub
    Public Sub REPRODUCIR(control As Boolean)
        If control Then
            Video_fondo.settings.setMode("loop", True)
            Video_fondo.Ctlcontrols.play()
            If CONT_VIDEO_AUDIO Then
                Video_fondo.settings.volume = 0
            Else
                Video_fondo.settings.volume = 100
            End If

        End If

    End Sub
    Friend Sub REFRESCAR()
        Video_reproductor.settings.volume = 0
        Try
            Video_reproductor.URL = ""
        Catch ex As Exception

        End Try

        If RETO_ACEPTADO = False Then
            CONT_FOTO = False
            CONT_VIDEO_AUDIO = False
            TXT_PREGUNTA.Visible = False
            BTN_OPCION1.Visible = False
            BTN_OPCION2.Visible = False
            BTN_OPCION3.Visible = False
            BTN_OPCION4.Visible = False
            TXT_PREGUNTA.Visible = False
            FOTO_PREGUNTA.Visible = False
            PANEL_ARCHIVO_M.Visible = False
            Video_reproductor.Visible = False
            Segundos.Visible = False
            TIEMPO_BARRA.Visible = False
            Me.Hide()
            Transicion.Show()
            TIEMPO_BARRA.Value = 0
            Tiempo.Dispose()
            Dim numero As Integer = Int((14 * Rnd()) + 1)
            Dim ruta As String = $"{Application.StartupPath}\Fotos_fondo\Juego{numero}.png"
            FONDO_BOTONES.Image = Image.FromFile(ruta)
            Video_fondo.URL = $"{Application.StartupPath}\Videos_fondo\Juego_fondo{numero}.mkv"

            Tiempo_contador_s = 0
            For Each fila In JUGABILIDAD.Paginacion_PREGUNTAS(pagina, CantidadPaginas, LST_PREGUNTAS)
                If LST_PREGUNTAS.Last.Preguntas.ID_PREGUNTA = fila.Preguntas.ID_PREGUNTA Then
                    ULTIMO = True
                End If
                LST_RETO = JUGABILIDAD.CONSULTAR_RETO(fila.Preguntas.ID_PREGUNTA)

                If fila.Preguntas.VIDEO <> "" Or fila.Preguntas.AUDIO <> "" Then
                    TXT_PREGUNTA.Location = New Point(0, 82)
                    CONT_VIDEO_AUDIO = True
                    Video_reproductor.Visible = False
                    Video_fondo.settings.volume = 0
                    Video_reproductor.settings.volume = 80
                    URL_VIDEO = $"{Application.StartupPath}\Video_{fila.Preguntas.ID_PREGUNTA}{fila.Preguntas.EXTENSION}"
                    Video_reproductor.settings.autoStart = False
                    CONT_FOTO = False
                ElseIf fila.Preguntas.FOTO <> "" Then
                    TXT_PREGUNTA.Location = New Point(0, 82)
                    CONT_FOTO = True
                    Video_fondo.settings.volume = 100
                    FOTO_PREGUNTA.Image = String_imagen(fila.Preguntas.FOTO)
                    CONT_VIDEO_AUDIO = False
                Else
                    TXT_PREGUNTA.Location = New Point(0, 350)
                    Video_reproductor.Visible = False
                    FOTO_PREGUNTA.Visible = False
                    PANEL_ARCHIVO_M.Visible = False
                    Video_fondo.settings.volume = 100
                    CONT_FOTO = False
                    CONT_VIDEO_AUDIO = False
                End If
                TXT_PREGUNTA.Text = fila.Preguntas.PREGUNTA
                FOTO_CAT_JUEGO = fila.FOTO_CATEGORIA
                CAT_JUEGO = fila.CATEGORIA
                LST_OPCIONES = LOGICA_OPCIONES.CONSULTAR(Nothing, Nothing, fila.Preguntas.ID_PREGUNTA)
                tiempo_temporal = fila.Preguntas.TIEMPO

                Tiempo_categoria.Start()

                Dim contador As Integer = 0
                For Each opcion In LST_OPCIONES
                    Select Case contador
                        Case 0
                            BTN_OPCION1.Text = opcion.Descripcion
                        Case 1
                            BTN_OPCION2.Text = opcion.Descripcion
                        Case 2
                            BTN_OPCION3.Text = opcion.Descripcion
                        Case 3
                            BTN_OPCION4.Text = opcion.Descripcion
                    End Select
                    contador += 1
                Next

            Next
        Else
            CONT_FOTO = False
            CONT_VIDEO_AUDIO = False
            TXT_PREGUNTA.Visible = False
            BTN_OPCION1.Visible = False
            BTN_OPCION2.Visible = False
            BTN_OPCION3.Visible = False
            BTN_OPCION4.Visible = False
            TXT_PREGUNTA.Visible = False
            Video_reproductor.Visible = False
            Segundos.Visible = False
            TIEMPO_BARRA.Visible = False
            Me.Hide()
            Transicion.Show()
            TIEMPO_BARRA.Value = 0
            Tiempo.Dispose()
            Dim numero As Integer = Int((14 * Rnd()) + 1)
            Dim ruta As String = $"{Application.StartupPath}\Fotos_fondo\Juego{numero}.png"
            FONDO_BOTONES.Image = Image.FromFile(ruta)
            Video_fondo.URL = $"{Application.StartupPath}\Videos_fondo\Juego_fondo{numero}.mkv"

            Tiempo_contador_s = 0




            If LST_RETO.First.Retos.VIDEO <> "" Or LST_RETO.First.Retos.AUDIO <> "" Then
                TXT_PREGUNTA.Location = New Point(0, 82)
                CONT_VIDEO_AUDIO = True
                Video_reproductor.Visible = False
                Video_fondo.settings.volume = 0
                Dim String_byte_2 As Byte() = String_byte(LST_RETO.First.Retos.VIDEO)
                CrearArchivo(String_byte_2, Application.StartupPath, $"Reto_{LST_RETO.First.Retos.ID_RETO}", $"{LST_RETO.First.Retos.EXTENSION}")
                URL_VIDEO = $"{Application.StartupPath}\Reto_{LST_RETO.First.Retos.ID_RETO}{LST_RETO.First.Retos.EXTENSION}"
                Video_reproductor.settings.volume = 80
                Video_reproductor.settings.autoStart = False
            ElseIf LST_RETO.First.Retos.FOTO <> "" Then

                TXT_PREGUNTA.Location = New Point(0, 82)
                CONT_FOTO = True
                Video_fondo.settings.volume = 100

            Else
                TXT_PREGUNTA.Location = New Point(0, 350)
                Video_reproductor.Visible = False
                FOTO_PREGUNTA.Visible = False
                PANEL_ARCHIVO_M.Visible = False
                Video_fondo.settings.volume = 100
            End If
            TXT_PREGUNTA.Text = LST_RETO.First.Retos.RETO
            FOTO_CAT_JUEGO = LST_RETO.First.FOTO_CATEGORIA
            CAT_JUEGO = LST_RETO.First.CATEGORIA
            LST_OPCIONES_RETOS = LOGICA_OPCIONES_retos.CONSULTAR(LST_RETO.First.Retos.ID_RETO)
            tiempo_temporal = LST_RETO.First.Retos.TIEMPO

            Tiempo_categoria.Start()

            Dim contador As Integer = 0
            For Each opcion In LST_OPCIONES_RETOS
                Select Case contador
                    Case 0
                        BTN_OPCION1.Text = opcion.DESCRIPCION
                    Case 1
                        BTN_OPCION2.Text = opcion.DESCRIPCION
                    Case 2
                        BTN_OPCION3.Text = opcion.DESCRIPCION
                    Case 3
                        BTN_OPCION4.Text = opcion.DESCRIPCION
                End Select
                contador += 1
            Next

            ISRETO = True
        End If


    End Sub
    Public Sub TIEMPO_CONTAR(Control As Boolean)
        If Control Then
            TXT_PREGUNTA.Visible = True
            BTN_OPCION1.Visible = True
            BTN_OPCION2.Visible = True
            BTN_OPCION3.Visible = True
            BTN_OPCION4.Visible = True
            TXT_PREGUNTA.Visible = True
            Segundos.Visible = True


            TIEMPO_BARRA.Visible = True
            If CONT_VIDEO_AUDIO = True Then
                FOTO_PREGUNTA.Visible = False
                PANEL_ARCHIVO_M.Visible = False
                Video_reproductor.Visible = True
                Video_reproductor.URL = URL_VIDEO
                Video_fondo.settings.volume = 0
            ElseIf CONT_FOTO Then
                Video_reproductor.Visible = False

                FOTO_PREGUNTA.Visible = True
                PANEL_ARCHIVO_M.Visible = True
            End If
            Tiempo.Start()
        End If

    End Sub
    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Tiempo_contador_s += 1
        TIEMPO_BARRA.Text = Tiempo_contador_s
        TIEMPO_BARRA.Value += 120 / tiempo_temporal
        If Tiempo_contador_s = tiempo_temporal Then
            Tiempo.Stop()
            Alerta_advertencia(alerta_transicion, "Tiempo acabado", "Se agoto el tiempo")
            If ISRETO = False Then
                If CONT_VIDEO_AUDIO Then
                    Video_reproductor.settings.volume = 0
                    Try
                        Video_reproductor.URL = ""
                    Catch ex As Exception

                    End Try
                    Dim PREGUNTA_VIDEO = LST_PREGUNTAS.Where(Function(x) x.Preguntas.PREGUNTA = TXT_PREGUNTA.Text).First
                    My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Video_{PREGUNTA_VIDEO.Preguntas.ID_PREGUNTA}{PREGUNTA_VIDEO.Preguntas.EXTENSION}")
                End If
            Else
                If CONT_VIDEO_AUDIO Then
                    Video_reproductor.settings.volume = 0
                    Try
                        Video_reproductor.URL = ""
                    Catch ex As Exception

                    End Try
                    Dim RETO_VIDEO = LST_RETO.Where(Function(x) x.Retos.RETO = TXT_PREGUNTA.Text).First
                    My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Reto_{RETO_VIDEO.Retos.ID_RETO}{RETO_VIDEO.Retos.EXTENSION}")
                End If

            End If
            If ULTIMO Then
                MenuJugador.Show()
                Me.Close()
            Else
                If ISRETO Then
                    ISRETO = False
                    RETO_ACEPTADO = False
                    REFRESCAR()
                Else
                    pagina += 1
                    Me.Hide()
                    REFRESCAR()
                End If

            End If


        End If
        Segundos.Text = Tiempo_contador_s

    End Sub
    Friend Sub BTN_EFECTO_HOVER(Numero As Integer)

    End Sub
    Private Sub BTN_OPCION1_MouseHover(sender As Object, e As EventArgs) Handles BTN_OPCION1.MouseHover
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then


            BTN_OPCION1.ImageSize = New System.Drawing.Size(845, 86)
        End If

    End Sub


    Private Sub FONDO_MouseHover(sender As Object, e As EventArgs) Handles FONDO_BOTONES.MouseHover
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then
            BTN_OPCION1.Location = New Point(104, 768)
            BTN_OPCION2.Location = New Point(104, 890)
            BTN_OPCION3.Location = New Point(972, 768)
            BTN_OPCION4.Location = New Point(972, 890)

            BTN_OPCION1.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION1.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION2.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION2.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION3.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION3.ImageSize = New System.Drawing.Size(846, 93)
            BTN_OPCION4.Size = New System.Drawing.Size(838, 86)
            BTN_OPCION4.ImageSize = New System.Drawing.Size(846, 93)
        End If

    End Sub


    Private Sub BTN_OPCION2_MouseHover(sender As Object, e As EventArgs) Handles BTN_OPCION2.MouseHover
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then

            BTN_OPCION2.ImageSize = New System.Drawing.Size(845, 86)
        End If

    End Sub

    Private Sub BTN_OPCION3_MouseHover(sender As Object, e As EventArgs) Handles BTN_OPCION3.MouseHover
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then

            BTN_OPCION3.ImageSize = New System.Drawing.Size(845, 86)

        End If

    End Sub

    Private Sub BTN_OPCION4_MouseHover(sender As Object, e As EventArgs) Handles BTN_OPCION4.MouseHover
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then


            BTN_OPCION4.ImageSize = New System.Drawing.Size(845, 86)
        End If

    End Sub

    Private Sub PANEL_OPCION1_MouseHover(sender As Object, e As EventArgs)

    End Sub
    'TODO:ENUM PENDIENTE

    Friend Enum BOTON_NUM
        BTN_1 = 1
        BTN_2 = 2
        BTN_3 = 3
        BTN_4 = 4
    End Enum

    Private Sub BTN_OPCION1_Click(sender As Object, e As EventArgs) Handles BTN_OPCION1.Click

        If ISRETO = False Then
            Dim lst_id = LST_OPCIONES.Where(Function(x) x.Descripcion = BTN_OPCION1.Text).First.ID_opciones
            LOGICA_RESPUESTA_ALUMNO.INSERTAR(lst_id)
            If CONT_VIDEO_AUDIO Then
                If CONT_VIDEO_AUDIO Then
                    Video_reproductor.settings.volume = 0
                    Try
                        Video_reproductor.URL = ""
                    Catch ex As Exception

                    End Try
                    Dim PREGUNTA_VIDEO = LST_PREGUNTAS.Where(Function(x) x.Preguntas.PREGUNTA = TXT_PREGUNTA.Text).First
                    My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Video_{PREGUNTA_VIDEO.Preguntas.ID_PREGUNTA}{PREGUNTA_VIDEO.Preguntas.EXTENSION}")
                End If

            End If
            If LST_RETO.Count > 0 Then
                RETO_ACEPTADO = True
                Me.Hide()
                Preguntar_Reto.Show()
            Else
                If ULTIMO Then
                    MenuJugador.Show()
                    Me.Close()
                Else
                    pagina += 1
                    REFRESCAR()
                    RETO_ACEPTADO = False
                End If

            End If
            Tiempo.Stop()
        Else
            Dim lst_id = LST_OPCIONES_RETOS.Where(Function(x) x.DESCRIPCION = BTN_OPCION1.Text).First.ID_OPCIONES_RETOS
            LOGICA_RESPUESTA_ALUMNO.INSERTAR_RESPUESTA_RETO(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim RETO_VIDEO = LST_RETO.Where(Function(x) x.Retos.RETO = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Reto_{RETO_VIDEO.Retos.ID_RETO}{RETO_VIDEO.Retos.EXTENSION}")
            End If
            ISRETO = False
            RETO_ACEPTADO = False
            If ULTIMO Then
                MenuJugador.Show()
                Me.Close()
            Else
                REFRESCAR()
            End If
            Tiempo.Stop()
        End If


    End Sub

    Private Sub BTN_OPCION3_Click(sender As Object, e As EventArgs) Handles BTN_OPCION3.Click
        If ISRETO = False Then
            Dim lst_id = LST_OPCIONES.Where(Function(x) x.Descripcion = BTN_OPCION3.Text).First.ID_opciones
            LOGICA_RESPUESTA_ALUMNO.INSERTAR(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim PREGUNTA_VIDEO = LST_PREGUNTAS.Where(Function(x) x.Preguntas.PREGUNTA = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Video_{PREGUNTA_VIDEO.Preguntas.ID_PREGUNTA}{PREGUNTA_VIDEO.Preguntas.EXTENSION}")
            End If


            If LST_RETO.Count > 0 Then
                RETO_ACEPTADO = True
                Me.Hide()
                Preguntar_Reto.Show()
            Else
                If ULTIMO Then
                    MenuJugador.Show()
                    Me.Close()
                Else
                    pagina += 1
                    REFRESCAR()
                    RETO_ACEPTADO = False
                End If


            End If
            Tiempo.Stop()
        Else
            Dim lst_id = LST_OPCIONES_RETOS.Where(Function(x) x.DESCRIPCION = BTN_OPCION1.Text).First.ID_OPCIONES_RETOS
            LOGICA_RESPUESTA_ALUMNO.INSERTAR_RESPUESTA_RETO(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim RETO_VIDEO = LST_RETO.Where(Function(x) x.Retos.RETO = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Reto_{RETO_VIDEO.Retos.ID_RETO}{RETO_VIDEO.Retos.EXTENSION}")
            End If
            ISRETO = False
            RETO_ACEPTADO = False
            If ULTIMO Then
                MenuJugador.Show()
                Me.Close()
            Else
                REFRESCAR()
            End If
            Tiempo.Stop()
        End If


    End Sub

    Private Sub BTN_OPCION2_Click(sender As Object, e As EventArgs) Handles BTN_OPCION2.Click
        If ISRETO = False Then
            Dim lst_id = LST_OPCIONES.Where(Function(x) x.Descripcion = BTN_OPCION2.Text).First.ID_opciones
            LOGICA_RESPUESTA_ALUMNO.INSERTAR(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim PREGUNTA_VIDEO = LST_PREGUNTAS.Where(Function(x) x.Preguntas.PREGUNTA = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Video_{PREGUNTA_VIDEO.Preguntas.ID_PREGUNTA}{PREGUNTA_VIDEO.Preguntas.EXTENSION}")
            End If
            If LST_RETO.Count > 0 Then
                RETO_ACEPTADO = True
                Me.Hide()
                Preguntar_Reto.Show()
            Else
                If ULTIMO Then
                    MenuJugador.Show()
                    Me.Close()
                Else
                    pagina += 1
                    REFRESCAR()
                    RETO_ACEPTADO = False
                End If


            End If
            Tiempo.Stop()
        Else
            Dim lst_id = LST_OPCIONES_RETOS.Where(Function(x) x.DESCRIPCION = BTN_OPCION1.Text).First.ID_OPCIONES_RETOS
            LOGICA_RESPUESTA_ALUMNO.INSERTAR_RESPUESTA_RETO(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim RETO_VIDEO = LST_RETO.Where(Function(x) x.Retos.RETO = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Reto_{RETO_VIDEO.Retos.ID_RETO}{RETO_VIDEO.Retos.EXTENSION}")
            End If
            ISRETO = False
            RETO_ACEPTADO = False
            RETO_ACEPTADO = False
            If ULTIMO Then
                MenuJugador.Show()
                Me.Close()
            Else
                REFRESCAR()
            End If
            Tiempo.Stop()
        End If

    End Sub

    Private Sub BTN_OPCION4_Click(sender As Object, e As EventArgs) Handles BTN_OPCION4.Click
        If ISRETO = False Then
            Dim lst_id = LST_OPCIONES.Where(Function(x) x.Descripcion = BTN_OPCION4.Text).First.ID_opciones
            LOGICA_RESPUESTA_ALUMNO.INSERTAR(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim PREGUNTA_VIDEO = LST_PREGUNTAS.Where(Function(x) x.Preguntas.PREGUNTA = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Video_{PREGUNTA_VIDEO.Preguntas.ID_PREGUNTA}{PREGUNTA_VIDEO.Preguntas.EXTENSION}")
            End If
            If LST_RETO.Count > 0 Then
                RETO_ACEPTADO = True
                Me.Hide()
                Preguntar_Reto.Show()
            Else
                If ULTIMO Then
                    MenuJugador.Show()
                    Me.Close()
                Else
                    pagina += 1
                    REFRESCAR()
                    RETO_ACEPTADO = False
                End If

            End If
            Tiempo.Stop()
        Else
            Dim lst_id = LST_OPCIONES_RETOS.Where(Function(x) x.DESCRIPCION = BTN_OPCION1.Text).First.ID_OPCIONES_RETOS
            LOGICA_RESPUESTA_ALUMNO.INSERTAR_RESPUESTA_RETO(lst_id)
            If CONT_VIDEO_AUDIO Then
                Video_reproductor.settings.volume = 0
                Try
                    Video_reproductor.URL = ""
                Catch ex As Exception

                End Try
                Dim RETO_VIDEO = LST_RETO.Where(Function(x) x.Retos.RETO = TXT_PREGUNTA.Text).First
                My.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\Reto_{RETO_VIDEO.Retos.ID_RETO}{RETO_VIDEO.Retos.EXTENSION}")
            End If
            ISRETO = False
            RETO_ACEPTADO = False
            If ULTIMO Then
                MenuJugador.Show()
                Me.Close()
            Else
                REFRESCAR()
            End If
            Tiempo.Stop()
        End If

    End Sub

    Private Sub Juego_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
        REFRESCAR()
        If Convert.ToInt32(pantalla.Bounds.Width.ToString()) >= 1920 Then
            BTN_OPCION1.Location = New Point(104, 768)
            BTN_OPCION2.Location = New Point(104, 890)
            BTN_OPCION3.Location = New Point(972, 768)
            BTN_OPCION4.Location = New Point(972, 890)
        End If

    End Sub

    Private Sub Tiempo_categoria_Tick(sender As Object, e As EventArgs) Handles Tiempo_categoria.Tick
        Tiempo_categoria_segundos += 1
        If Tiempo_categoria_segundos >= 3 Then
            Tiempo_categoria.Stop()

            CATEGORIA_EFECTO = True
        Else
            CATEGORIA_EFECTO = False
        End If
    End Sub

    Private Sub TXT_PREGUNTA_Click(sender As Object, e As EventArgs)

    End Sub
End Class