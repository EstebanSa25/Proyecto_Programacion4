<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.TIEMPO_BARRA = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.PANEL_ARCHIVO_M = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Segundos = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.alerta_transicion = New Guna.UI2.WinForms.Guna2Transition()
        Me.FOTO_PREGUNTA = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_OPCION4 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCION1 = New Guna.UI2.WinForms.Guna2Button()
        Me.FONDO_BOTONES = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_OPCION2 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCION3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Video_reproductor = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TXT_PREGUNTA = New Guna.UI2.WinForms.Guna2Button()
        Me.Video_fondo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Tiempo_categoria = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.FOTO_PREGUNTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FONDO_BOTONES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Video_reproductor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TIEMPO_BARRA
        '
        Me.TIEMPO_BARRA.BackColor = System.Drawing.Color.Transparent
        Me.TIEMPO_BARRA.BorderRadius = 6
        Me.alerta_transicion.SetDecoration(Me.TIEMPO_BARRA, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TIEMPO_BARRA.FillColor = System.Drawing.Color.Black
        Me.TIEMPO_BARRA.Location = New System.Drawing.Point(200, 693)
        Me.TIEMPO_BARRA.Maximum = 120
        Me.TIEMPO_BARRA.Name = "TIEMPO_BARRA"
        Me.TIEMPO_BARRA.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TIEMPO_BARRA.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TIEMPO_BARRA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIEMPO_BARRA.Size = New System.Drawing.Size(888, 15)
        Me.TIEMPO_BARRA.TabIndex = 9
        Me.TIEMPO_BARRA.Text = "Tiempo_barra"
        Me.TIEMPO_BARRA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.TIEMPO_BARRA.UseTransparentBackground = True
        '
        'PANEL_ARCHIVO_M
        '
        Me.PANEL_ARCHIVO_M.BackColor = System.Drawing.Color.Transparent
        Me.PANEL_ARCHIVO_M.BorderRadius = 19
        Me.alerta_transicion.SetDecoration(Me.PANEL_ARCHIVO_M, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PANEL_ARCHIVO_M.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.PANEL_ARCHIVO_M.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.PANEL_ARCHIVO_M.Location = New System.Drawing.Point(445, 120)
        Me.PANEL_ARCHIVO_M.Name = "PANEL_ARCHIVO_M"
        Me.PANEL_ARCHIVO_M.Size = New System.Drawing.Size(416, 257)
        Me.PANEL_ARCHIVO_M.TabIndex = 11
        Me.PANEL_ARCHIVO_M.UseTransparentBackground = True
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 1000
        '
        'Guna2TaskBarProgress1
        '
        Me.Guna2TaskBarProgress1.TargetForm = Me
        Me.Guna2TaskBarProgress1.Value = 10
        '
        'Segundos
        '
        Me.Segundos.BackColor = System.Drawing.Color.Transparent
        Me.alerta_transicion.SetDecoration(Me.Segundos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Segundos.Location = New System.Drawing.Point(50, 301)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(282, 41)
        Me.Segundos.TabIndex = 17
        Me.Segundos.Text = "Guna2HtmlLabel1"
        Me.Segundos.Visible = False
        '
        'alerta_transicion
        '
        Me.alerta_transicion.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.alerta_transicion.DefaultAnimation = Animation1
        '
        'FOTO_PREGUNTA
        '
        Me.FOTO_PREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.FOTO_PREGUNTA.BorderRadius = 19
        Me.alerta_transicion.SetDecoration(Me.FOTO_PREGUNTA, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FOTO_PREGUNTA.ImageRotate = 0!
        Me.FOTO_PREGUNTA.Location = New System.Drawing.Point(438, 115)
        Me.FOTO_PREGUNTA.Name = "FOTO_PREGUNTA"
        Me.FOTO_PREGUNTA.Size = New System.Drawing.Size(416, 254)
        Me.FOTO_PREGUNTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO_PREGUNTA.TabIndex = 10
        Me.FOTO_PREGUNTA.TabStop = False
        Me.FOTO_PREGUNTA.UseTransparentBackground = True
        '
        'BTN_OPCION4
        '
        Me.BTN_OPCION4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OPCION4.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OPCION4.BorderRadius = 10
        Me.alerta_transicion.SetDecoration(Me.BTN_OPCION4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_OPCION4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCION4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCION4.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION4.Font = New System.Drawing.Font("Rounded Mplus 1c", 21.75!)
        Me.BTN_OPCION4.ForeColor = System.Drawing.Color.Black
        Me.BTN_OPCION4.HoverState.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION4.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.BTN_OPCION4.Image = CType(resources.GetObject("BTN_OPCION4.Image"), System.Drawing.Image)
        Me.BTN_OPCION4.ImageSize = New System.Drawing.Size(620, 91)
        Me.BTN_OPCION4.Location = New System.Drawing.Point(653, 563)
        Me.BTN_OPCION4.Name = "BTN_OPCION4"
        Me.BTN_OPCION4.Size = New System.Drawing.Size(615, 86)
        Me.BTN_OPCION4.TabIndex = 14
        Me.BTN_OPCION4.Text = "Respuesta1"
        Me.BTN_OPCION4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_OPCION4.UseTransparentBackground = True
        Me.BTN_OPCION4.Visible = False
        '
        'BTN_OPCION1
        '
        Me.BTN_OPCION1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OPCION1.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OPCION1.BorderRadius = 10
        Me.alerta_transicion.SetDecoration(Me.BTN_OPCION1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_OPCION1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCION1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCION1.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION1.Font = New System.Drawing.Font("Rounded Mplus 1c", 21.75!)
        Me.BTN_OPCION1.ForeColor = System.Drawing.Color.Black
        Me.BTN_OPCION1.HoverState.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION1.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.BTN_OPCION1.Image = CType(resources.GetObject("BTN_OPCION1.Image"), System.Drawing.Image)
        Me.BTN_OPCION1.ImageSize = New System.Drawing.Size(620, 91)
        Me.BTN_OPCION1.Location = New System.Drawing.Point(23, 434)
        Me.BTN_OPCION1.Name = "BTN_OPCION1"
        Me.BTN_OPCION1.Size = New System.Drawing.Size(615, 86)
        Me.BTN_OPCION1.TabIndex = 0
        Me.BTN_OPCION1.Text = "Respuesta1"
        Me.BTN_OPCION1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_OPCION1.UseTransparentBackground = True
        Me.BTN_OPCION1.Visible = False
        '
        'FONDO_BOTONES
        '
        Me.FONDO_BOTONES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FONDO_BOTONES.BackColor = System.Drawing.Color.Transparent
        Me.alerta_transicion.SetDecoration(Me.FONDO_BOTONES, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FONDO_BOTONES.FillColor = System.Drawing.Color.IndianRed
        Me.FONDO_BOTONES.ImageRotate = 0!
        Me.FONDO_BOTONES.Location = New System.Drawing.Point(0, 429)
        Me.FONDO_BOTONES.Name = "FONDO_BOTONES"
        Me.FONDO_BOTONES.Size = New System.Drawing.Size(1280, 291)
        Me.FONDO_BOTONES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FONDO_BOTONES.TabIndex = 22
        Me.FONDO_BOTONES.TabStop = False
        Me.FONDO_BOTONES.UseTransparentBackground = True
        '
        'BTN_OPCION2
        '
        Me.BTN_OPCION2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OPCION2.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OPCION2.BorderRadius = 10
        Me.alerta_transicion.SetDecoration(Me.BTN_OPCION2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_OPCION2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCION2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCION2.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION2.Font = New System.Drawing.Font("Rounded Mplus 1c", 21.75!)
        Me.BTN_OPCION2.ForeColor = System.Drawing.Color.Black
        Me.BTN_OPCION2.HoverState.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION2.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BTN_OPCION2.Image = CType(resources.GetObject("BTN_OPCION2.Image"), System.Drawing.Image)
        Me.BTN_OPCION2.ImageSize = New System.Drawing.Size(620, 91)
        Me.BTN_OPCION2.Location = New System.Drawing.Point(23, 563)
        Me.BTN_OPCION2.Name = "BTN_OPCION2"
        Me.BTN_OPCION2.Size = New System.Drawing.Size(615, 86)
        Me.BTN_OPCION2.TabIndex = 23
        Me.BTN_OPCION2.Text = "Respuesta1"
        Me.BTN_OPCION2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_OPCION2.UseTransparentBackground = True
        Me.BTN_OPCION2.Visible = False
        '
        'BTN_OPCION3
        '
        Me.BTN_OPCION3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OPCION3.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OPCION3.BorderRadius = 10
        Me.alerta_transicion.SetDecoration(Me.BTN_OPCION3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_OPCION3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCION3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCION3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCION3.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION3.Font = New System.Drawing.Font("Rounded Mplus 1c", 21.75!)
        Me.BTN_OPCION3.ForeColor = System.Drawing.Color.Black
        Me.BTN_OPCION3.HoverState.FillColor = System.Drawing.Color.White
        Me.BTN_OPCION3.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTN_OPCION3.Image = CType(resources.GetObject("BTN_OPCION3.Image"), System.Drawing.Image)
        Me.BTN_OPCION3.ImageSize = New System.Drawing.Size(620, 91)
        Me.BTN_OPCION3.Location = New System.Drawing.Point(653, 434)
        Me.BTN_OPCION3.Name = "BTN_OPCION3"
        Me.BTN_OPCION3.Size = New System.Drawing.Size(615, 86)
        Me.BTN_OPCION3.TabIndex = 24
        Me.BTN_OPCION3.Text = "Respuesta1"
        Me.BTN_OPCION3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_OPCION3.UseTransparentBackground = True
        Me.BTN_OPCION3.Visible = False
        '
        'Video_reproductor
        '
        Me.alerta_transicion.SetDecoration(Me.Video_reproductor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Video_reproductor.Enabled = True
        Me.Video_reproductor.Location = New System.Drawing.Point(507, 120)
        Me.Video_reproductor.Name = "Video_reproductor"
        Me.Video_reproductor.OcxState = CType(resources.GetObject("Video_reproductor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Video_reproductor.Size = New System.Drawing.Size(315, 249)
        Me.Video_reproductor.TabIndex = 18
        Me.Video_reproductor.Visible = False
        '
        'TXT_PREGUNTA
        '
        Me.TXT_PREGUNTA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_PREGUNTA.BorderRadius = 10
        Me.alerta_transicion.SetDecoration(Me.TXT_PREGUNTA, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TXT_PREGUNTA.DisabledState.BorderColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.DisabledState.FillColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.TXT_PREGUNTA.Enabled = False
        Me.TXT_PREGUNTA.FillColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 20.25!, System.Drawing.FontStyle.Bold)
        Me.TXT_PREGUNTA.ForeColor = System.Drawing.Color.Black
        Me.TXT_PREGUNTA.HoverState.BorderColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.HoverState.CustomBorderColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.HoverState.FillColor = System.Drawing.Color.White
        Me.TXT_PREGUNTA.HoverState.ForeColor = System.Drawing.Color.Black
        Me.TXT_PREGUNTA.Location = New System.Drawing.Point(0, 12)
        Me.TXT_PREGUNTA.Name = "TXT_PREGUNTA"
        Me.TXT_PREGUNTA.Size = New System.Drawing.Size(1280, 51)
        Me.TXT_PREGUNTA.TabIndex = 25
        Me.TXT_PREGUNTA.Text = "Guna2Button1"
        '
        'Video_fondo
        '
        Me.alerta_transicion.SetDecoration(Me.Video_fondo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Video_fondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Video_fondo.Enabled = True
        Me.Video_fondo.Location = New System.Drawing.Point(0, 0)
        Me.Video_fondo.Name = "Video_fondo"
        Me.Video_fondo.OcxState = CType(resources.GetObject("Video_fondo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Video_fondo.Size = New System.Drawing.Size(1280, 720)
        Me.Video_fondo.TabIndex = 26
        '
        'Tiempo_categoria
        '
        Me.Tiempo_categoria.Interval = 1000
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.TXT_PREGUNTA)
        Me.Controls.Add(Me.BTN_OPCION3)
        Me.Controls.Add(Me.BTN_OPCION2)
        Me.Controls.Add(Me.Video_reproductor)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.FOTO_PREGUNTA)
        Me.Controls.Add(Me.BTN_OPCION4)
        Me.Controls.Add(Me.PANEL_ARCHIVO_M)
        Me.Controls.Add(Me.TIEMPO_BARRA)
        Me.Controls.Add(Me.BTN_OPCION1)
        Me.Controls.Add(Me.FONDO_BOTONES)
        Me.Controls.Add(Me.Video_fondo)
        Me.alerta_transicion.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FOTO_PREGUNTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FONDO_BOTONES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Video_reproductor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_OPCION1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TIEMPO_BARRA As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents FOTO_PREGUNTA As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PANEL_ARCHIVO_M As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BTN_OPCION4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Segundos As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Video_reproductor As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents alerta_transicion As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Tiempo_categoria As Timer
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FONDO_BOTONES As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_OPCION3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_OPCION2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_PREGUNTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Video_fondo As AxWMPLib.AxWindowsMediaPlayer
End Class
