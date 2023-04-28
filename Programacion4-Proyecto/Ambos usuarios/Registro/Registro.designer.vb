<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FOTO_PERSONA = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BTN_LOGIN = New Guna.UI2.WinForms.Guna2Button()
        Me.L_ROL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_ROL = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXT_TELEFONO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LOGIN = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_REGISTRO = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.FOTO_PERSONA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ABRIR
        '
        Me.ABRIR.FileName = "OpenFileDialog1"
        Me.ABRIR.Filter = "Imágenes|*.jpg; *.bmp; *.jpeg; *.png"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.Controls.Add(Me.NOMBRE)
        Me.Guna2Panel1.Controls.Add(Me.FOTO_PERSONA)
        Me.Guna2Panel1.Controls.Add(Me.BTN_LOGIN)
        Me.Guna2Panel1.Controls.Add(Me.L_ROL)
        Me.Guna2Panel1.Controls.Add(Me.TXT_ROL)
        Me.Guna2Panel1.Controls.Add(Me.TXT_TELEFONO)
        Me.Guna2Panel1.Controls.Add(Me.LOGIN)
        Me.Guna2Panel1.Controls.Add(Me.BTN_REGISTRO)
        Me.Guna2Panel1.Controls.Add(Me.TXT_CLAVE)
        Me.Guna2Panel1.Controls.Add(Me.TXT_CORREO)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(349, 710)
        Me.Guna2Panel1.TabIndex = 19
        '
        'NOMBRE
        '
        Me.NOMBRE.Animated = True
        Me.NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.NOMBRE.BorderRadius = 10
        Me.NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE.DefaultText = ""
        Me.NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.NOMBRE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE.Location = New System.Drawing.Point(15, 410)
        Me.NOMBRE.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.NOMBRE.PlaceholderText = "Nombre completo"
        Me.NOMBRE.SelectedText = ""
        Me.NOMBRE.ShadowDecoration.BorderRadius = 10
        Me.NOMBRE.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NOMBRE.ShadowDecoration.Depth = 255
        Me.NOMBRE.ShadowDecoration.Enabled = True
        Me.NOMBRE.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.NOMBRE.Size = New System.Drawing.Size(294, 48)
        Me.NOMBRE.TabIndex = 13
        '
        'FOTO_PERSONA
        '
        Me.FOTO_PERSONA.BackColor = System.Drawing.Color.Transparent
        Me.FOTO_PERSONA.ImageRotate = 0!
        Me.FOTO_PERSONA.Location = New System.Drawing.Point(108, 13)
        Me.FOTO_PERSONA.Name = "FOTO_PERSONA"
        Me.FOTO_PERSONA.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO_PERSONA.Size = New System.Drawing.Size(135, 125)
        Me.FOTO_PERSONA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO_PERSONA.TabIndex = 12
        Me.FOTO_PERSONA.TabStop = False
        Me.FOTO_PERSONA.UseTransparentBackground = True
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.Animated = True
        Me.BTN_LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_LOGIN.BorderRadius = 10
        Me.BTN_LOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_LOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_LOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_LOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_LOGIN.FillColor = System.Drawing.Color.Transparent
        Me.BTN_LOGIN.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BTN_LOGIN.ForeColor = System.Drawing.Color.White
        Me.BTN_LOGIN.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BTN_LOGIN.Location = New System.Drawing.Point(1, 616)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(133, 56)
        Me.BTN_LOGIN.TabIndex = 11
        Me.BTN_LOGIN.Text = "Prefiero iniciar sesion"
        Me.BTN_LOGIN.UseTransparentBackground = True
        '
        'L_ROL
        '
        Me.L_ROL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.L_ROL.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ROL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.L_ROL.Location = New System.Drawing.Point(20, 560)
        Me.L_ROL.Name = "L_ROL"
        Me.L_ROL.Size = New System.Drawing.Size(36, 31)
        Me.L_ROL.TabIndex = 10
        Me.L_ROL.Text = "Rol"
        '
        'TXT_ROL
        '
        Me.TXT_ROL.BackColor = System.Drawing.Color.Transparent
        Me.TXT_ROL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_ROL.BorderRadius = 10
        Me.TXT_ROL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXT_ROL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXT_ROL.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_ROL.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ROL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ROL.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ROL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_ROL.ItemHeight = 30
        Me.TXT_ROL.Items.AddRange(New Object() {"Alumno", "Profesor"})
        Me.TXT_ROL.Location = New System.Drawing.Point(15, 560)
        Me.TXT_ROL.Name = "TXT_ROL"
        Me.TXT_ROL.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_ROL.ShadowDecoration.Depth = 255
        Me.TXT_ROL.ShadowDecoration.Enabled = True
        Me.TXT_ROL.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_ROL.Size = New System.Drawing.Size(294, 36)
        Me.TXT_ROL.TabIndex = 9
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.Animated = True
        Me.TXT_TELEFONO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TELEFONO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_TELEFONO.BorderRadius = 10
        Me.TXT_TELEFONO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TELEFONO.DefaultText = ""
        Me.TXT_TELEFONO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TELEFONO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TELEFONO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TELEFONO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TELEFONO.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_TELEFONO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TELEFONO.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_TELEFONO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_TELEFONO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(15, 482)
        Me.TXT_TELEFONO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TELEFONO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_TELEFONO.PlaceholderText = "Numero telefonico"
        Me.TXT_TELEFONO.SelectedText = ""
        Me.TXT_TELEFONO.ShadowDecoration.BorderRadius = 10
        Me.TXT_TELEFONO.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_TELEFONO.ShadowDecoration.Depth = 255
        Me.TXT_TELEFONO.ShadowDecoration.Enabled = True
        Me.TXT_TELEFONO.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(294, 48)
        Me.TXT_TELEFONO.TabIndex = 8
        '
        'LOGIN
        '
        Me.LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGIN.ForeColor = System.Drawing.Color.White
        Me.LOGIN.Location = New System.Drawing.Point(48, 175)
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(261, 57)
        Me.LOGIN.TabIndex = 7
        Me.LOGIN.Text = "REGISTRO"
        '
        'BTN_REGISTRO
        '
        Me.BTN_REGISTRO.Animated = True
        Me.BTN_REGISTRO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REGISTRO.BorderRadius = 10
        Me.BTN_REGISTRO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRO.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BTN_REGISTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_REGISTRO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTN_REGISTRO.Location = New System.Drawing.Point(140, 617)
        Me.BTN_REGISTRO.Name = "BTN_REGISTRO"
        Me.BTN_REGISTRO.Size = New System.Drawing.Size(169, 53)
        Me.BTN_REGISTRO.TabIndex = 6
        Me.BTN_REGISTRO.Text = "Registrarse"
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.Animated = True
        Me.TXT_CLAVE.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CLAVE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CLAVE.BorderRadius = 10
        Me.TXT_CLAVE.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TXT_CLAVE.Location = New System.Drawing.Point(15, 332)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CLAVE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CLAVE.PlaceholderText = "Clave"
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.ShadowDecoration.BorderRadius = 10
        Me.TXT_CLAVE.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CLAVE.ShadowDecoration.Depth = 255
        Me.TXT_CLAVE.ShadowDecoration.Enabled = True
        Me.TXT_CLAVE.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_CLAVE.Size = New System.Drawing.Size(294, 48)
        Me.TXT_CLAVE.TabIndex = 1
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.Animated = True
        Me.TXT_CORREO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CORREO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.TXT_CORREO.BorderRadius = 10
        Me.TXT_CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TXT_CORREO.Location = New System.Drawing.Point(15, 256)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CORREO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TXT_CORREO.PlaceholderText = "Correo electrónico"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.ShadowDecoration.BorderRadius = 10
        Me.TXT_CORREO.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CORREO.ShadowDecoration.Depth = 255
        Me.TXT_CORREO.ShadowDecoration.Enabled = True
        Me.TXT_CORREO.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.TXT_CORREO.Size = New System.Drawing.Size(294, 48)
        Me.TXT_CORREO.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImage = CType(resources.GetObject("Guna2PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(344, 0)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(763, 697)
        Me.Guna2PictureBox2.TabIndex = 20
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderThickness = 2
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Red
        Me.Guna2Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(1070, -1)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedDepth = 100
        Me.Guna2Button3.ShadowDecoration.Enabled = True
        Me.Guna2Button3.Size = New System.Drawing.Size(37, 34)
        Me.Guna2Button3.TabIndex = 21
        Me.Guna2Button3.Text = "X"
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'Registro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1107, 697)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.FOTO_PERSONA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LOGIN As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_REGISTRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_ROL As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXT_TELEFONO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L_ROL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_LOGIN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FOTO_PERSONA As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents NOMBRE As Guna.UI2.WinForms.Guna2TextBox
End Class
