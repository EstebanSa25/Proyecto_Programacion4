<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_Preguntas
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Grupo1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXT1 = New Guna.UI2.WinForms.Guna2Button()
        Me.CHK4 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.CHK3 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.CHK2 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.CHK1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.PUNTAJE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_RETO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.R4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.R2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.R3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.R1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Grupo1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grupo1
        '
        Me.Grupo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grupo1.Controls.Add(Me.Guna2Panel1)
        Me.Grupo1.Controls.Add(Me.CHK4)
        Me.Grupo1.Controls.Add(Me.CHK3)
        Me.Grupo1.Controls.Add(Me.CHK2)
        Me.Grupo1.Controls.Add(Me.CHK1)
        Me.Grupo1.Controls.Add(Me.PUNTAJE)
        Me.Grupo1.Controls.Add(Me.TXT_RETO)
        Me.Grupo1.Controls.Add(Me.R4)
        Me.Grupo1.Controls.Add(Me.R2)
        Me.Grupo1.Controls.Add(Me.R3)
        Me.Grupo1.Controls.Add(Me.R1)
        Me.Grupo1.Controls.Add(Me.Splitter1)
        Me.Grupo1.Location = New System.Drawing.Point(8, 15)
        Me.Grupo1.Name = "Grupo1"
        Me.Grupo1.ShadowDecoration.Depth = 40
        Me.Grupo1.ShadowDecoration.Enabled = True
        Me.Grupo1.Size = New System.Drawing.Size(1351, 343)
        Me.Grupo1.TabIndex = 16
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXT1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1348, 94)
        Me.Guna2Panel1.TabIndex = 39
        '
        'TXT1
        '
        Me.TXT1.BackColor = System.Drawing.Color.Transparent
        Me.TXT1.DefaultAutoSize = True
        Me.TXT1.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.TXT1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.TXT1.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.TXT1.DisabledState.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT1.Enabled = False
        Me.TXT1.FillColor = System.Drawing.Color.Transparent
        Me.TXT1.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TXT1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT1.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.TXT1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.TXT1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.TXT1.HoverState.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT1.Location = New System.Drawing.Point(0, 0)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(1348, 94)
        Me.TXT1.TabIndex = 32
        Me.TXT1.Text = "Guna2Button1"
        Me.TXT1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'CHK4
        '
        Me.CHK4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CHK4.BackColor = System.Drawing.Color.Transparent
        Me.CHK4.BackgroundImage = Global.Preguntados.My.Resources.Resources.unchecked
        Me.CHK4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHK4.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK4.CheckedState.BorderRadius = 2
        Me.CHK4.CheckedState.BorderThickness = 0
        Me.CHK4.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.CHK4.CheckMarkColor = System.Drawing.Color.Transparent
        Me.CHK4.ForeColor = System.Drawing.Color.Tomato
        Me.CHK4.Location = New System.Drawing.Point(66, 298)
        Me.CHK4.Name = "CHK4"
        Me.CHK4.Size = New System.Drawing.Size(28, 29)
        Me.CHK4.TabIndex = 38
        Me.CHK4.Text = "Guna2CustomCheckBox1"
        Me.CHK4.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK4.UncheckedState.BorderRadius = 2
        Me.CHK4.UncheckedState.BorderThickness = 0
        Me.CHK4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'CHK3
        '
        Me.CHK3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CHK3.BackColor = System.Drawing.Color.Transparent
        Me.CHK3.BackgroundImage = Global.Preguntados.My.Resources.Resources.unchecked
        Me.CHK3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHK3.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK3.CheckedState.BorderRadius = 2
        Me.CHK3.CheckedState.BorderThickness = 0
        Me.CHK3.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.CHK3.CheckMarkColor = System.Drawing.Color.Transparent
        Me.CHK3.ForeColor = System.Drawing.Color.Tomato
        Me.CHK3.Location = New System.Drawing.Point(66, 230)
        Me.CHK3.Name = "CHK3"
        Me.CHK3.Size = New System.Drawing.Size(28, 29)
        Me.CHK3.TabIndex = 37
        Me.CHK3.Text = "Guna2CustomCheckBox1"
        Me.CHK3.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK3.UncheckedState.BorderRadius = 2
        Me.CHK3.UncheckedState.BorderThickness = 0
        Me.CHK3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'CHK2
        '
        Me.CHK2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CHK2.BackColor = System.Drawing.Color.Transparent
        Me.CHK2.BackgroundImage = Global.Preguntados.My.Resources.Resources.unchecked
        Me.CHK2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHK2.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK2.CheckedState.BorderRadius = 2
        Me.CHK2.CheckedState.BorderThickness = 0
        Me.CHK2.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.CHK2.CheckMarkColor = System.Drawing.Color.Transparent
        Me.CHK2.ForeColor = System.Drawing.Color.Tomato
        Me.CHK2.Location = New System.Drawing.Point(66, 157)
        Me.CHK2.Name = "CHK2"
        Me.CHK2.Size = New System.Drawing.Size(28, 29)
        Me.CHK2.TabIndex = 36
        Me.CHK2.Text = "Guna2CustomCheckBox1"
        Me.CHK2.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK2.UncheckedState.BorderRadius = 2
        Me.CHK2.UncheckedState.BorderThickness = 0
        Me.CHK2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'CHK1
        '
        Me.CHK1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CHK1.BackColor = System.Drawing.Color.Transparent
        Me.CHK1.BackgroundImage = Global.Preguntados.My.Resources.Resources.unchecked
        Me.CHK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHK1.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK1.CheckedState.BorderRadius = 2
        Me.CHK1.CheckedState.BorderThickness = 0
        Me.CHK1.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.CHK1.CheckMarkColor = System.Drawing.Color.Transparent
        Me.CHK1.ForeColor = System.Drawing.Color.Tomato
        Me.CHK1.Location = New System.Drawing.Point(66, 90)
        Me.CHK1.Name = "CHK1"
        Me.CHK1.Size = New System.Drawing.Size(28, 29)
        Me.CHK1.TabIndex = 35
        Me.CHK1.Text = "Guna2CustomCheckBox1"
        Me.CHK1.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.CHK1.UncheckedState.BorderRadius = 2
        Me.CHK1.UncheckedState.BorderThickness = 0
        Me.CHK1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'PUNTAJE
        '
        Me.PUNTAJE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PUNTAJE.BackColor = System.Drawing.Color.Transparent
        Me.PUNTAJE.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.PUNTAJE.ForeColor = System.Drawing.Color.Black
        Me.PUNTAJE.Location = New System.Drawing.Point(1170, 301)
        Me.PUNTAJE.Name = "PUNTAJE"
        Me.PUNTAJE.Size = New System.Drawing.Size(96, 29)
        Me.PUNTAJE.TabIndex = 34
        Me.PUNTAJE.Text = "Puntaje:"
        Me.PUNTAJE.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_RETO
        '
        Me.TXT_RETO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_RETO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_RETO.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_RETO.ForeColor = System.Drawing.Color.Black
        Me.TXT_RETO.Location = New System.Drawing.Point(1255, 301)
        Me.TXT_RETO.Name = "TXT_RETO"
        Me.TXT_RETO.Size = New System.Drawing.Size(55, 29)
        Me.TXT_RETO.TabIndex = 33
        Me.TXT_RETO.Text = "Reto"
        Me.TXT_RETO.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TXT_RETO.Visible = False
        '
        'R4
        '
        Me.R4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.R4.BackColor = System.Drawing.Color.Transparent
        Me.R4.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.R4.ForeColor = System.Drawing.Color.Black
        Me.R4.Location = New System.Drawing.Point(119, 298)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(119, 29)
        Me.R4.TabIndex = 25
        Me.R4.Text = "Respuesta"
        Me.R4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R2
        '
        Me.R2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.R2.BackColor = System.Drawing.Color.Transparent
        Me.R2.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.R2.ForeColor = System.Drawing.Color.Black
        Me.R2.Location = New System.Drawing.Point(119, 157)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(119, 29)
        Me.R2.TabIndex = 24
        Me.R2.Text = "Respuesta"
        Me.R2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R3
        '
        Me.R3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.R3.BackColor = System.Drawing.Color.Transparent
        Me.R3.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.R3.ForeColor = System.Drawing.Color.Black
        Me.R3.Location = New System.Drawing.Point(119, 230)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(119, 29)
        Me.R3.TabIndex = 23
        Me.R3.Text = "Respuesta"
        Me.R3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R1
        '
        Me.R1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.R1.BackColor = System.Drawing.Color.Transparent
        Me.R1.Font = New System.Drawing.Font("Montserrat Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Location = New System.Drawing.Point(119, 90)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(119, 29)
        Me.R1.TabIndex = 18
        Me.R1.Text = "Respuesta"
        Me.R1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 343)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'C_Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Grupo1)
        Me.Name = "C_Preguntas"
        Me.Size = New System.Drawing.Size(1366, 372)
        Me.Grupo1.ResumeLayout(False)
        Me.Grupo1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grupo1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Splitter1 As Splitter
    Public WithEvents TXT1 As Guna.UI2.WinForms.Guna2Button
    Public WithEvents PUNTAJE As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents TXT_RETO As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents CHK4 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Public WithEvents CHK3 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Public WithEvents CHK2 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Public WithEvents CHK1 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Public WithEvents R4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents R2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents R3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents R1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
