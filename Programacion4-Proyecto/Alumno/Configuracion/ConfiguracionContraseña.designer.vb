<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfiguracionContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionContraseña))
        Me.btnAtras = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNUEVA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPASSVIEJA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCONFIRMAR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BorderRadius = 10
        Me.btnAtras.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAtras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAtras.FillColor = System.Drawing.Color.White
        Me.btnAtras.Font = New System.Drawing.Font("Rounded Mplus 1c Bold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(871, 490)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.ShadowDecoration.BorderRadius = 10
        Me.btnAtras.ShadowDecoration.Depth = 45
        Me.btnAtras.ShadowDecoration.Enabled = True
        Me.btnAtras.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnAtras.Size = New System.Drawing.Size(158, 50)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Atrás"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BorderRadius = 10
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.FillColor = System.Drawing.Color.White
        Me.btnGuardar.Font = New System.Drawing.Font("Rounded Mplus 1c Bold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(285, 490)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.ShadowDecoration.BorderRadius = 10
        Me.btnGuardar.ShadowDecoration.Depth = 45
        Me.btnGuardar.ShadowDecoration.Enabled = True
        Me.btnGuardar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnGuardar.Size = New System.Drawing.Size(158, 50)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        '
        'txtNUEVA
        '
        Me.txtNUEVA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNUEVA.BackColor = System.Drawing.Color.Transparent
        Me.txtNUEVA.BorderRadius = 15
        Me.txtNUEVA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNUEVA.DefaultText = ""
        Me.txtNUEVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNUEVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNUEVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNUEVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNUEVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNUEVA.Font = New System.Drawing.Font("Rounded Mplus 1c Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtNUEVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNUEVA.Location = New System.Drawing.Point(285, 263)
        Me.txtNUEVA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtNUEVA.MaxLength = 100
        Me.txtNUEVA.Name = "txtNUEVA"
        Me.txtNUEVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNUEVA.PlaceholderText = "Nueva contraseña"
        Me.txtNUEVA.SelectedText = ""
        Me.txtNUEVA.ShadowDecoration.BorderRadius = 15
        Me.txtNUEVA.ShadowDecoration.Depth = 40
        Me.txtNUEVA.ShadowDecoration.Enabled = True
        Me.txtNUEVA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.txtNUEVA.Size = New System.Drawing.Size(744, 50)
        Me.txtNUEVA.TabIndex = 11
        Me.txtNUEVA.UseSystemPasswordChar = True
        '
        'txtPASSVIEJA
        '
        Me.txtPASSVIEJA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPASSVIEJA.BackColor = System.Drawing.Color.Transparent
        Me.txtPASSVIEJA.BorderRadius = 15
        Me.txtPASSVIEJA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPASSVIEJA.DefaultText = ""
        Me.txtPASSVIEJA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPASSVIEJA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPASSVIEJA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPASSVIEJA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPASSVIEJA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPASSVIEJA.Font = New System.Drawing.Font("Rounded Mplus 1c Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtPASSVIEJA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPASSVIEJA.Location = New System.Drawing.Point(285, 190)
        Me.txtPASSVIEJA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPASSVIEJA.MaxLength = 100
        Me.txtPASSVIEJA.Name = "txtPASSVIEJA"
        Me.txtPASSVIEJA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPASSVIEJA.PlaceholderText = "Contraseña actual"
        Me.txtPASSVIEJA.SelectedText = ""
        Me.txtPASSVIEJA.ShadowDecoration.BorderRadius = 15
        Me.txtPASSVIEJA.ShadowDecoration.Depth = 40
        Me.txtPASSVIEJA.ShadowDecoration.Enabled = True
        Me.txtPASSVIEJA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.txtPASSVIEJA.Size = New System.Drawing.Size(744, 50)
        Me.txtPASSVIEJA.TabIndex = 12
        '
        'txtCONFIRMAR
        '
        Me.txtCONFIRMAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCONFIRMAR.BackColor = System.Drawing.Color.Transparent
        Me.txtCONFIRMAR.BorderRadius = 15
        Me.txtCONFIRMAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCONFIRMAR.DefaultText = ""
        Me.txtCONFIRMAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCONFIRMAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCONFIRMAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCONFIRMAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCONFIRMAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCONFIRMAR.Font = New System.Drawing.Font("Rounded Mplus 1c Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtCONFIRMAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCONFIRMAR.Location = New System.Drawing.Point(285, 346)
        Me.txtCONFIRMAR.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCONFIRMAR.MaxLength = 100
        Me.txtCONFIRMAR.Name = "txtCONFIRMAR"
        Me.txtCONFIRMAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCONFIRMAR.PlaceholderText = "Confirmar contraseña"
        Me.txtCONFIRMAR.SelectedText = ""
        Me.txtCONFIRMAR.ShadowDecoration.BorderRadius = 15
        Me.txtCONFIRMAR.ShadowDecoration.Depth = 40
        Me.txtCONFIRMAR.ShadowDecoration.Enabled = True
        Me.txtCONFIRMAR.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.txtCONFIRMAR.Size = New System.Drawing.Size(744, 50)
        Me.txtCONFIRMAR.TabIndex = 13
        Me.txtCONFIRMAR.UseSystemPasswordChar = True
        '
        'Titulo
        '
        Me.Titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Transparent
        Me.Titulo.IsSelectionEnabled = False
        Me.Titulo.Location = New System.Drawing.Point(402, 29)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(494, 62)
        Me.Titulo.TabIndex = 14
        Me.Titulo.Text = "Cambio de contraseña"
        '
        'ConfiguracionContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.txtCONFIRMAR)
        Me.Controls.Add(Me.txtPASSVIEJA)
        Me.Controls.Add(Me.txtNUEVA)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ConfiguracionContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfiguracionContraseña"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNUEVA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPASSVIEJA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCONFIRMAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
