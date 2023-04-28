<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionCuenta))
        Me.FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnContraseña = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAtras = New Guna.UI2.WinForms.Guna2Button()
        Me.Titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.transicion_para_alertas = New Guna.UI2.WinForms.Guna2Transition()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FOTO
        '
        Me.FOTO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FOTO.BackColor = System.Drawing.Color.Transparent
        Me.transicion_para_alertas.SetDecoration(Me.FOTO, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FOTO.Image = CType(resources.GetObject("FOTO.Image"), System.Drawing.Image)
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(105, 169)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.ShadowDecoration.BorderRadius = 1
        Me.FOTO.ShadowDecoration.Depth = 40
        Me.FOTO.ShadowDecoration.Enabled = True
        Me.FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO.Size = New System.Drawing.Size(323, 301)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO.TabIndex = 2
        Me.FOTO.TabStop = False
        '
        'btnContraseña
        '
        Me.btnContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnContraseña.BackColor = System.Drawing.Color.Transparent
        Me.btnContraseña.BorderRadius = 10
        Me.transicion_para_alertas.SetDecoration(Me.btnContraseña, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnContraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnContraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnContraseña.FillColor = System.Drawing.Color.White
        Me.btnContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnContraseña.ForeColor = System.Drawing.Color.Black
        Me.btnContraseña.Location = New System.Drawing.Point(452, 389)
        Me.btnContraseña.Name = "btnContraseña"
        Me.btnContraseña.ShadowDecoration.BorderRadius = 10
        Me.btnContraseña.ShadowDecoration.Depth = 45
        Me.btnContraseña.ShadowDecoration.Enabled = True
        Me.btnContraseña.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnContraseña.Size = New System.Drawing.Size(641, 60)
        Me.btnContraseña.TabIndex = 3
        Me.btnContraseña.Text = "Contraseña"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorreo.BackColor = System.Drawing.Color.Transparent
        Me.txtCorreo.BorderRadius = 10
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion_para_alertas.SetDecoration(Me.txtCorreo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Location = New System.Drawing.Point(452, 193)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = "Correo"
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.ShadowDecoration.BorderRadius = 10
        Me.txtCorreo.ShadowDecoration.Depth = 40
        Me.txtCorreo.ShadowDecoration.Enabled = True
        Me.txtCorreo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.txtCorreo.Size = New System.Drawing.Size(641, 60)
        Me.txtCorreo.TabIndex = 5
        '
        'txtNum
        '
        Me.txtNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNum.BackColor = System.Drawing.Color.Transparent
        Me.txtNum.BorderRadius = 10
        Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion_para_alertas.SetDecoration(Me.txtNum, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtNum.DefaultText = ""
        Me.txtNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNum.Location = New System.Drawing.Point(452, 285)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNum.PlaceholderText = "Número"
        Me.txtNum.SelectedText = ""
        Me.txtNum.ShadowDecoration.BorderRadius = 10
        Me.txtNum.ShadowDecoration.Depth = 40
        Me.txtNum.ShadowDecoration.Enabled = True
        Me.txtNum.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.txtNum.Size = New System.Drawing.Size(641, 60)
        Me.txtNum.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BorderRadius = 10
        Me.transicion_para_alertas.SetDecoration(Me.btnGuardar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.FillColor = System.Drawing.Color.White
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(44, 656)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.ShadowDecoration.BorderRadius = 10
        Me.btnGuardar.ShadowDecoration.Depth = 45
        Me.btnGuardar.ShadowDecoration.Enabled = True
        Me.btnGuardar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnGuardar.Size = New System.Drawing.Size(214, 60)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BorderRadius = 10
        Me.transicion_para_alertas.SetDecoration(Me.btnAtras, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAtras.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAtras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAtras.FillColor = System.Drawing.Color.White
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(1020, 656)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.ShadowDecoration.BorderRadius = 10
        Me.btnAtras.ShadowDecoration.Depth = 45
        Me.btnAtras.ShadowDecoration.Enabled = True
        Me.btnAtras.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnAtras.Size = New System.Drawing.Size(214, 60)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Atrás"
        '
        'Titulo
        '
        Me.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.transicion_para_alertas.SetDecoration(Me.Titulo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Transparent
        Me.Titulo.IsSelectionEnabled = False
        Me.Titulo.Location = New System.Drawing.Point(246, 37)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(793, 75)
        Me.Titulo.TabIndex = 9
        Me.Titulo.Text = "Configuración de la cuenta"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.FOTO)
        Me.Guna2Panel1.Controls.Add(Me.btnGuardar)
        Me.Guna2Panel1.Controls.Add(Me.btnAtras)
        Me.Guna2Panel1.Controls.Add(Me.txtCorreo)
        Me.Guna2Panel1.Controls.Add(Me.txtNum)
        Me.Guna2Panel1.Controls.Add(Me.btnContraseña)
        Me.Guna2Panel1.Controls.Add(Me.Titulo)
        Me.transicion_para_alertas.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1283, 762)
        Me.Guna2Panel1.TabIndex = 10
        '
        'transicion_para_alertas
        '
        Me.transicion_para_alertas.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.transicion_para_alertas.Cursor = Nothing
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
        Me.transicion_para_alertas.DefaultAnimation = Animation1
        '
        'ABRIR
        '
        Me.ABRIR.FileName = "OpenFileDialog1"
        Me.ABRIR.Filter = "Imágenes|*.jpg; *.bmp; *.jpeg; *.png"
        '
        'ConfiguracionCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 762)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion_para_alertas.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfiguracionCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfiguracionCuenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnContraseña As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAtras As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents transicion_para_alertas As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ABRIR As OpenFileDialog
End Class
