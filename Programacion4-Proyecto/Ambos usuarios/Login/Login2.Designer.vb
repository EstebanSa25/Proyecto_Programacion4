<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login2))
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_ACORDARSE = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LOGIN = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_REGISTRO = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_INGRESAR = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Alertas_msg = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Transicion_guna = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.BTN_ACORDARSE)
        Me.Guna2Panel1.Controls.Add(Me.LOGIN)
        Me.Guna2Panel1.Controls.Add(Me.BTN_REGISTRO)
        Me.Guna2Panel1.Controls.Add(Me.BTN_INGRESAR)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.TXT_CLAVE)
        Me.Guna2Panel1.Controls.Add(Me.TXT_CORREO)
        Me.Transicion_guna.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-7, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(349, 697)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Transicion_guna.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(123, 553)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(128, 23)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "Acuérdate de mí"
        '
        'BTN_ACORDARSE
        '
        Me.BTN_ACORDARSE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ACORDARSE.BackgroundImage = CType(resources.GetObject("BTN_ACORDARSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_ACORDARSE.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_ACORDARSE.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ACORDARSE.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.BTN_ACORDARSE.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Transicion_guna.SetDecoration(Me.BTN_ACORDARSE, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_ACORDARSE.Location = New System.Drawing.Point(82, 556)
        Me.BTN_ACORDARSE.Name = "BTN_ACORDARSE"
        Me.BTN_ACORDARSE.Size = New System.Drawing.Size(35, 20)
        Me.BTN_ACORDARSE.TabIndex = 8
        Me.BTN_ACORDARSE.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BTN_ACORDARSE.UncheckedState.BorderThickness = 2
        Me.BTN_ACORDARSE.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.BTN_ACORDARSE.UncheckedState.InnerBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_ACORDARSE.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        '
        'LOGIN
        '
        Me.LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.Transicion_guna.SetDecoration(Me.LOGIN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LOGIN.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGIN.ForeColor = System.Drawing.Color.White
        Me.LOGIN.Location = New System.Drawing.Point(35, 234)
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(260, 114)
        Me.LOGIN.TabIndex = 7
        Me.LOGIN.Text = "LOGIN"
        '
        'BTN_REGISTRO
        '
        Me.BTN_REGISTRO.Animated = True
        Me.BTN_REGISTRO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REGISTRO.BorderRadius = 10
        Me.Transicion_guna.SetDecoration(Me.BTN_REGISTRO, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_REGISTRO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRO.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BTN_REGISTRO.Font = New System.Drawing.Font("Mikado Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_REGISTRO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTN_REGISTRO.Location = New System.Drawing.Point(182, 599)
        Me.BTN_REGISTRO.Name = "BTN_REGISTRO"
        Me.BTN_REGISTRO.Size = New System.Drawing.Size(139, 53)
        Me.BTN_REGISTRO.TabIndex = 6
        Me.BTN_REGISTRO.Text = "Registro"
        '
        'BTN_INGRESAR
        '
        Me.BTN_INGRESAR.Animated = True
        Me.BTN_INGRESAR.BackColor = System.Drawing.Color.Transparent
        Me.BTN_INGRESAR.BorderRadius = 10
        Me.Transicion_guna.SetDecoration(Me.BTN_INGRESAR, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_INGRESAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_INGRESAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_INGRESAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTN_INGRESAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BTN_INGRESAR.Font = New System.Drawing.Font("Rounded Mplus 1c ExtraBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_INGRESAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTN_INGRESAR.Location = New System.Drawing.Point(19, 599)
        Me.BTN_INGRESAR.Name = "BTN_INGRESAR"
        Me.BTN_INGRESAR.Size = New System.Drawing.Size(139, 53)
        Me.BTN_INGRESAR.TabIndex = 5
        Me.BTN_INGRESAR.Text = "Ingresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Transicion_guna.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(64, 25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(210, 203)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.Animated = True
        Me.TXT_CLAVE.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CLAVE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CLAVE.BorderRadius = 10
        Me.TXT_CLAVE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transicion_guna.SetDecoration(Me.TXT_CLAVE, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TXT_CLAVE.DefaultText = ""
        Me.TXT_CLAVE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CLAVE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_CLAVE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CLAVE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Location = New System.Drawing.Point(20, 478)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CLAVE.PlaceholderText = "Clave"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.ShadowDecoration.BorderRadius = 10
        Me.TXT_CLAVE.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TXT_CLAVE.ShadowDecoration.Depth = 255
        Me.TXT_CLAVE.ShadowDecoration.Enabled = True
        Me.TXT_CLAVE.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_CLAVE.Size = New System.Drawing.Size(301, 47)
        Me.TXT_CLAVE.TabIndex = 1
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.Animated = True
        Me.TXT_CORREO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CORREO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CORREO.BorderRadius = 10
        Me.TXT_CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transicion_guna.SetDecoration(Me.TXT_CORREO, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TXT_CORREO.DefaultText = ""
        Me.TXT_CORREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CORREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CORREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CORREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_CORREO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CORREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Location = New System.Drawing.Point(19, 373)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CORREO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CORREO.PlaceholderText = "Correo electrónico"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.ShadowDecoration.BorderRadius = 10
        Me.TXT_CORREO.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TXT_CORREO.ShadowDecoration.Depth = 255
        Me.TXT_CORREO.ShadowDecoration.Enabled = True
        Me.TXT_CORREO.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_CORREO.Size = New System.Drawing.Size(301, 47)
        Me.TXT_CORREO.TabIndex = 0
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderThickness = 2
        Me.Transicion_guna.SetDecoration(Me.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkViolet
        Me.Guna2Button3.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(1065, 0)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedDepth = 100
        Me.Guna2Button3.ShadowDecoration.Enabled = True
        Me.Guna2Button3.Size = New System.Drawing.Size(37, 34)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "X"
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'Alertas_msg
        '
        Me.Alertas_msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.Alertas_msg.Caption = Nothing
        Me.Alertas_msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Alertas_msg.Parent = Nothing
        Me.Alertas_msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        Me.Alertas_msg.Text = "hola"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImage = CType(resources.GetObject("Guna2PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.Transicion_guna.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(340, 0)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(762, 697)
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        '
        'Transicion_guna
        '
        Me.Transicion_guna.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Transicion_guna.Cursor = Nothing
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
        Me.Transicion_guna.DefaultAnimation = Animation1
        Me.Transicion_guna.MaxAnimationTime = 2000
        '
        'Login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 695)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Transicion_guna.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_REGISTRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_INGRESAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LOGIN As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Alertas_msg As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents BTN_ACORDARSE As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Transicion_guna As Guna.UI2.WinForms.Guna2Transition
End Class
