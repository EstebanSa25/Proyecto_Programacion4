<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte_preguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_preguntas))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnATRAS = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.P_JUEGO1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PUNTAJE1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NOTA1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MALA1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Contenedor = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.P_JUEGO1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.btnATRAS)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.P_JUEGO1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 1
        Me.Guna2Panel1.ShadowDecoration.Depth = 50
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1280, 127)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Montserrat Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.MediumPurple
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(719, 12)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(127, 39)
        Me.Guna2HtmlLabel4.TabIndex = 21
        Me.Guna2HtmlLabel4.Text = "PUNTOS"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnATRAS.Location = New System.Drawing.Point(1205, 26)
        Me.btnATRAS.Name = "btnATRAS"
        Me.btnATRAS.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnATRAS.Size = New System.Drawing.Size(38, 30)
        Me.btnATRAS.TabIndex = 4
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Montserrat Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(432, 16)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(88, 39)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "NOTA"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_JUEGO1
        '
        Me.P_JUEGO1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_JUEGO1.Controls.Add(Me.PUNTAJE1)
        Me.P_JUEGO1.Controls.Add(Me.NOTA1)
        Me.P_JUEGO1.Controls.Add(Me.MALA1)
        Me.P_JUEGO1.Controls.Add(Me.Splitter1)
        Me.P_JUEGO1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P_JUEGO1.Location = New System.Drawing.Point(405, 61)
        Me.P_JUEGO1.Name = "P_JUEGO1"
        Me.P_JUEGO1.ShadowDecoration.Depth = 40
        Me.P_JUEGO1.ShadowDecoration.Enabled = True
        Me.P_JUEGO1.Size = New System.Drawing.Size(487, 46)
        Me.P_JUEGO1.TabIndex = 3
        '
        'PUNTAJE1
        '
        Me.PUNTAJE1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PUNTAJE1.BackColor = System.Drawing.Color.Transparent
        Me.PUNTAJE1.Font = New System.Drawing.Font("Montserrat Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.PUNTAJE1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PUNTAJE1.Location = New System.Drawing.Point(361, 4)
        Me.PUNTAJE1.Name = "PUNTAJE1"
        Me.PUNTAJE1.Size = New System.Drawing.Size(52, 39)
        Me.PUNTAJE1.TabIndex = 9
        Me.PUNTAJE1.Text = "100"
        Me.PUNTAJE1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NOTA1
        '
        Me.NOTA1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NOTA1.BackColor = System.Drawing.Color.Transparent
        Me.NOTA1.Font = New System.Drawing.Font("Montserrat Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.NOTA1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.NOTA1.Location = New System.Drawing.Point(44, 3)
        Me.NOTA1.Name = "NOTA1"
        Me.NOTA1.Size = New System.Drawing.Size(52, 39)
        Me.NOTA1.TabIndex = 8
        Me.NOTA1.Text = "100"
        Me.NOTA1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MALA1
        '
        Me.MALA1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MALA1.BackColor = System.Drawing.Color.Transparent
        Me.MALA1.Font = New System.Drawing.Font("Montserrat Medium", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MALA1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.MALA1.Location = New System.Drawing.Point(714, 3)
        Me.MALA1.Name = "MALA1"
        Me.MALA1.Size = New System.Drawing.Size(22, 39)
        Me.MALA1.TabIndex = 6
        Me.MALA1.Text = "0"
        Me.MALA1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 46)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'Contenedor
        '
        Me.Contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Contenedor.AutoScroll = True
        Me.Contenedor.Location = New System.Drawing.Point(0, 147)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1280, 574)
        Me.Contenedor.TabIndex = 2
        '
        'Reporte_preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte_preguntas"
        Me.Text = "Reporte_preguntas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.P_JUEGO1.ResumeLayout(False)
        Me.P_JUEGO1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnATRAS As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Contenedor As FlowLayoutPanel
    Friend WithEvents P_JUEGO1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MALA1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents PUNTAJE1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents NOTA1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
