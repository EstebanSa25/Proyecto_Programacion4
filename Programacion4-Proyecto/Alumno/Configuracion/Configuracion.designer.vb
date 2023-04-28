<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.Titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCuenta = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreditos = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAtras = New Guna.UI2.WinForms.Guna2Button()
        Me.IconSplitButton1 = New FontAwesome.Sharp.IconSplitButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Transparent
        Me.Titulo.IsSelectionEnabled = False
        Me.Titulo.Location = New System.Drawing.Point(288, 58)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(790, 91)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Configuración del juego"
        '
        'btnCuenta
        '
        Me.btnCuenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnCuenta.BorderRadius = 15
        Me.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCuenta.FillColor = System.Drawing.Color.White
        Me.btnCuenta.Font = New System.Drawing.Font("Rounded Mplus 1c Bold", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnCuenta.ForeColor = System.Drawing.Color.Black
        Me.btnCuenta.Location = New System.Drawing.Point(379, 187)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.ShadowDecoration.BorderRadius = 15
        Me.btnCuenta.ShadowDecoration.Depth = 45
        Me.btnCuenta.ShadowDecoration.Enabled = True
        Me.btnCuenta.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnCuenta.Size = New System.Drawing.Size(615, 76)
        Me.btnCuenta.TabIndex = 5
        Me.btnCuenta.Text = "Cambiar información cuenta"
        Me.btnCuenta.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnCuenta.UseTransparentBackground = True
        '
        'btnCreditos
        '
        Me.btnCreditos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCreditos.BackColor = System.Drawing.Color.Transparent
        Me.btnCreditos.BorderRadius = 15
        Me.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreditos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreditos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreditos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreditos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreditos.FillColor = System.Drawing.Color.White
        Me.btnCreditos.Font = New System.Drawing.Font("Rounded Mplus 1c Bold", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreditos.ForeColor = System.Drawing.Color.Black
        Me.btnCreditos.Location = New System.Drawing.Point(379, 356)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.ShadowDecoration.BorderRadius = 15
        Me.btnCreditos.ShadowDecoration.Depth = 45
        Me.btnCreditos.ShadowDecoration.Enabled = True
        Me.btnCreditos.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnCreditos.Size = New System.Drawing.Size(615, 76)
        Me.btnCreditos.TabIndex = 6
        Me.btnCreditos.Text = "Créditos"
        Me.btnCreditos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnCreditos.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.btnAtras)
        Me.Guna2Panel1.Controls.Add(Me.btnCuenta)
        Me.Guna2Panel1.Controls.Add(Me.btnCreditos)
        Me.Guna2Panel1.Controls.Add(Me.Titulo)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1283, 762)
        Me.Guna2Panel1.TabIndex = 8
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BorderRadius = 15
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAtras.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAtras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAtras.FillColor = System.Drawing.Color.White
        Me.btnAtras.Font = New System.Drawing.Font("Rounded Mplus 1c Bold", 25.0!, System.Drawing.FontStyle.Bold)
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(379, 522)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.ShadowDecoration.BorderRadius = 15
        Me.btnAtras.ShadowDecoration.Depth = 45
        Me.btnAtras.ShadowDecoration.Enabled = True
        Me.btnAtras.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 7, 7)
        Me.btnAtras.Size = New System.Drawing.Size(615, 76)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnAtras.UseTransparentBackground = True
        '
        'IconSplitButton1
        '
        Me.IconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconSplitButton1.IconColor = System.Drawing.Color.Black
        Me.IconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSplitButton1.IconSize = 48
        Me.IconSplitButton1.Name = "IconSplitButton1"
        Me.IconSplitButton1.Rotation = 0R
        Me.IconSplitButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconSplitButton1.Text = "IconSplitButton1"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 762)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCuenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreditos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAtras As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IconSplitButton1 As FontAwesome.Sharp.IconSplitButton
End Class
