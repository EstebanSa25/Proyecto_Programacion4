<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALUMNOGRUPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALUMNOGRUPOS))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_SIGUIENTE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTN_REGRESAR = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Grupo3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Foto3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Txt3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Grupo2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Foto2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Txt2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Grupo1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Foto1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Txt1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnATRAS = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TITULO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Grupo3.SuspendLayout()
        CType(Me.Foto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo2.SuspendLayout()
        CType(Me.Foto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo1.SuspendLayout()
        CType(Me.Foto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_SIGUIENTE)
        Me.Guna2Panel1.Controls.Add(Me.BTN_REGRESAR)
        Me.Guna2Panel1.Controls.Add(Me.Grupo3)
        Me.Guna2Panel1.Controls.Add(Me.Grupo2)
        Me.Guna2Panel1.Controls.Add(Me.Grupo1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1251, 684)
        Me.Guna2Panel1.TabIndex = 0
        '
        'BTN_SIGUIENTE
        '
        Me.BTN_SIGUIENTE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SIGUIENTE.BorderRadius = 8
        Me.BTN_SIGUIENTE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SIGUIENTE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SIGUIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SIGUIENTE.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SIGUIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SIGUIENTE.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.BTN_SIGUIENTE.FillColor2 = System.Drawing.Color.DarkCyan
        Me.BTN_SIGUIENTE.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SIGUIENTE.ForeColor = System.Drawing.Color.White
        Me.BTN_SIGUIENTE.Location = New System.Drawing.Point(1044, 618)
        Me.BTN_SIGUIENTE.Name = "BTN_SIGUIENTE"
        Me.BTN_SIGUIENTE.Size = New System.Drawing.Size(184, 45)
        Me.BTN_SIGUIENTE.TabIndex = 16
        Me.BTN_SIGUIENTE.Text = "Siguiente"
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_REGRESAR.BorderRadius = 8
        Me.BTN_REGRESAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGRESAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGRESAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGRESAR.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGRESAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGRESAR.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.BTN_REGRESAR.FillColor2 = System.Drawing.Color.DarkCyan
        Me.BTN_REGRESAR.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGRESAR.ForeColor = System.Drawing.Color.White
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(854, 618)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(184, 45)
        Me.BTN_REGRESAR.TabIndex = 15
        Me.BTN_REGRESAR.Text = "Atrás"
        '
        'Grupo3
        '
        Me.Grupo3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grupo3.Controls.Add(Me.Foto3)
        Me.Grupo3.Controls.Add(Me.Txt3)
        Me.Grupo3.Location = New System.Drawing.Point(790, 218)
        Me.Grupo3.Name = "Grupo3"
        Me.Grupo3.ShadowDecoration.Depth = 40
        Me.Grupo3.ShadowDecoration.Enabled = True
        Me.Grupo3.Size = New System.Drawing.Size(266, 314)
        Me.Grupo3.TabIndex = 5
        '
        'Foto3
        '
        Me.Foto3.BackColor = System.Drawing.Color.Gray
        Me.Foto3.ImageRotate = 0!
        Me.Foto3.Location = New System.Drawing.Point(0, 0)
        Me.Foto3.Name = "Foto3"
        Me.Foto3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Foto3.Size = New System.Drawing.Size(266, 244)
        Me.Foto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto3.TabIndex = 7
        Me.Foto3.TabStop = False
        '
        'Txt3
        '
        Me.Txt3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt3.BackColor = System.Drawing.Color.Transparent
        Me.Txt3.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Txt3.Location = New System.Drawing.Point(3, 250)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(88, 39)
        Me.Txt3.TabIndex = 4
        Me.Txt3.Text = "Grupo"
        Me.Txt3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grupo2
        '
        Me.Grupo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grupo2.Controls.Add(Me.Foto2)
        Me.Grupo2.Controls.Add(Me.Txt2)
        Me.Grupo2.Location = New System.Drawing.Point(462, 218)
        Me.Grupo2.Name = "Grupo2"
        Me.Grupo2.ShadowDecoration.Depth = 40
        Me.Grupo2.ShadowDecoration.Enabled = True
        Me.Grupo2.Size = New System.Drawing.Size(266, 314)
        Me.Grupo2.TabIndex = 3
        '
        'Foto2
        '
        Me.Foto2.BackColor = System.Drawing.Color.Gray
        Me.Foto2.ImageRotate = 0!
        Me.Foto2.Location = New System.Drawing.Point(0, 0)
        Me.Foto2.Name = "Foto2"
        Me.Foto2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Foto2.Size = New System.Drawing.Size(266, 244)
        Me.Foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto2.TabIndex = 6
        Me.Foto2.TabStop = False
        '
        'Txt2
        '
        Me.Txt2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt2.BackColor = System.Drawing.Color.Transparent
        Me.Txt2.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Txt2.Location = New System.Drawing.Point(3, 250)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(88, 39)
        Me.Txt2.TabIndex = 4
        Me.Txt2.Text = "Grupo"
        Me.Txt2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grupo1
        '
        Me.Grupo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grupo1.Controls.Add(Me.Foto1)
        Me.Grupo1.Controls.Add(Me.Txt1)
        Me.Grupo1.Location = New System.Drawing.Point(117, 218)
        Me.Grupo1.Name = "Grupo1"
        Me.Grupo1.ShadowDecoration.Depth = 40
        Me.Grupo1.ShadowDecoration.Enabled = True
        Me.Grupo1.Size = New System.Drawing.Size(266, 314)
        Me.Grupo1.TabIndex = 1
        '
        'Foto1
        '
        Me.Foto1.BackColor = System.Drawing.Color.Gray
        Me.Foto1.ImageRotate = 0!
        Me.Foto1.Location = New System.Drawing.Point(0, 0)
        Me.Foto1.Name = "Foto1"
        Me.Foto1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Foto1.Size = New System.Drawing.Size(266, 244)
        Me.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto1.TabIndex = 5
        Me.Foto1.TabStop = False
        '
        'Txt1
        '
        Me.Txt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt1.BackColor = System.Drawing.Color.Transparent
        Me.Txt1.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Txt1.Location = New System.Drawing.Point(3, 250)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(88, 39)
        Me.Txt1.TabIndex = 4
        Me.Txt1.Text = "Grupo"
        Me.Txt1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.Controls.Add(Me.btnATRAS)
        Me.Guna2Panel2.Controls.Add(Me.TITULO)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1251, 100)
        Me.Guna2Panel2.TabIndex = 0
        '
        'btnATRAS
        '
        Me.btnATRAS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnATRAS.BackgroundImage = CType(resources.GetObject("btnATRAS.BackgroundImage"), System.Drawing.Image)
        Me.btnATRAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnATRAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnATRAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnATRAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnATRAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnATRAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnATRAS.FillColor = System.Drawing.Color.Transparent
        Me.btnATRAS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnATRAS.ForeColor = System.Drawing.Color.Transparent
        Me.btnATRAS.Location = New System.Drawing.Point(1198, 27)
        Me.btnATRAS.Name = "btnATRAS"
        Me.btnATRAS.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnATRAS.Size = New System.Drawing.Size(30, 30)
        Me.btnATRAS.TabIndex = 4
        '
        'TITULO
        '
        Me.TITULO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TITULO.BackColor = System.Drawing.Color.Transparent
        Me.TITULO.Font = New System.Drawing.Font("Montserrat Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITULO.ForeColor = System.Drawing.Color.SkyBlue
        Me.TITULO.Location = New System.Drawing.Point(472, 14)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(220, 53)
        Me.TITULO.TabIndex = 3
        Me.TITULO.Text = "Mis grupos"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(218, 40)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'ALUMNOGRUPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1251, 684)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ALUMNOGRUPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALUMNOGRUPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Grupo3.ResumeLayout(False)
        Me.Grupo3.PerformLayout()
        CType(Me.Foto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo2.ResumeLayout(False)
        Me.Grupo2.PerformLayout()
        CType(Me.Foto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo1.ResumeLayout(False)
        Me.Grupo1.PerformLayout()
        CType(Me.Foto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Grupo3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Txt3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Grupo2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Txt2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Grupo1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Txt1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TITULO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_SIGUIENTE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTN_REGRESAR As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Foto3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Foto2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Foto1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnATRAS As Guna.UI2.WinForms.Guna2CircleButton
End Class
