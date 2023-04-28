<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preguntar_Reto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preguntar_Reto))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Video_fondo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_RECHAZAR = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTN_ACEPTAR = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1280, 100)
        Me.Guna2Panel1.TabIndex = 28
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(392, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(517, 91)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Reto disponible"
        '
        'Video_fondo
        '
        Me.Video_fondo.Enabled = True
        Me.Video_fondo.Location = New System.Drawing.Point(0, 0)
        Me.Video_fondo.Name = "Video_fondo"
        Me.Video_fondo.OcxState = CType(resources.GetObject("Video_fondo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Video_fondo.Size = New System.Drawing.Size(1280, 720)
        Me.Video_fondo.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BTN_RECHAZAR)
        Me.Guna2Panel2.Controls.Add(Me.BTN_ACEPTAR)
        Me.Guna2Panel2.Controls.Add(Me.Video_fondo)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1280, 720)
        Me.Guna2Panel2.TabIndex = 30
        '
        'BTN_RECHAZAR
        '
        Me.BTN_RECHAZAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_RECHAZAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RECHAZAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RECHAZAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RECHAZAR.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RECHAZAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RECHAZAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_RECHAZAR.FillColor2 = System.Drawing.Color.Maroon
        Me.BTN_RECHAZAR.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 27.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_RECHAZAR.ForeColor = System.Drawing.Color.White
        Me.BTN_RECHAZAR.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BTN_RECHAZAR.Location = New System.Drawing.Point(808, 585)
        Me.BTN_RECHAZAR.Name = "BTN_RECHAZAR"
        Me.BTN_RECHAZAR.ShadowDecoration.Enabled = True
        Me.BTN_RECHAZAR.Size = New System.Drawing.Size(301, 87)
        Me.BTN_RECHAZAR.TabIndex = 31
        Me.BTN_RECHAZAR.Text = "Rechazar"
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_ACEPTAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACEPTAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACEPTAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ACEPTAR.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ACEPTAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ACEPTAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ACEPTAR.FillColor2 = System.Drawing.Color.Maroon
        Me.BTN_ACEPTAR.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 27.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_ACEPTAR.ForeColor = System.Drawing.Color.White
        Me.BTN_ACEPTAR.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(188, 585)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.ShadowDecoration.Enabled = True
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(301, 87)
        Me.BTN_ACEPTAR.TabIndex = 30
        Me.BTN_ACEPTAR.Text = "Aceptar"
        '
        'Preguntar_Reto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Preguntar_Reto"
        Me.Text = "Preguntar_Reto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Video_fondo As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_RECHAZAR As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTN_ACEPTAR As Guna.UI2.WinForms.Guna2GradientButton
End Class
