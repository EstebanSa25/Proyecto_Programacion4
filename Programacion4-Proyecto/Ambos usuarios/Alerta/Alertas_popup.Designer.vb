<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALERTAS_POPUP
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALERTAS_POPUP))
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.BARRA_CARGA = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.ICONO_ALERTA = New FontAwesome.Sharp.IconPictureBox()
        Me.FONDO = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_CERRAR = New FontAwesome.Sharp.IconPictureBox()
        Me.Texto_contenido = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Texto_titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        CType(Me.ICONO_ALERTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FONDO.SuspendLayout()
        CType(Me.BTN_CERRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 200
        '
        'BARRA_CARGA
        '
        Me.BARRA_CARGA.AutoRoundedCorners = True
        Me.BARRA_CARGA.BackColor = System.Drawing.Color.Transparent
        Me.BARRA_CARGA.BorderRadius = 4
        Me.BARRA_CARGA.FillColor = System.Drawing.Color.Transparent
        Me.BARRA_CARGA.Location = New System.Drawing.Point(-1536, 57)
        Me.BARRA_CARGA.Name = "BARRA_CARGA"
        Me.BARRA_CARGA.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid
        Me.BARRA_CARGA.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BARRA_CARGA.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BARRA_CARGA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BARRA_CARGA.Size = New System.Drawing.Size(1979, 10)
        Me.BARRA_CARGA.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.BARRA_CARGA.TabIndex = 2
        Me.BARRA_CARGA.Text = "Guna2ProgressBar1"
        Me.BARRA_CARGA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ICONO_ALERTA
        '
        Me.ICONO_ALERTA.BackColor = System.Drawing.Color.Transparent
        Me.ICONO_ALERTA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ICONO_ALERTA.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.ICONO_ALERTA.IconColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ICONO_ALERTA.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.ICONO_ALERTA.IconSize = 45
        Me.ICONO_ALERTA.Location = New System.Drawing.Point(12, 6)
        Me.ICONO_ALERTA.Name = "ICONO_ALERTA"
        Me.ICONO_ALERTA.Size = New System.Drawing.Size(46, 45)
        Me.ICONO_ALERTA.TabIndex = 4
        Me.ICONO_ALERTA.TabStop = False
        '
        'FONDO
        '
        Me.FONDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FONDO.Controls.Add(Me.BTN_CERRAR)
        Me.FONDO.Controls.Add(Me.ICONO_ALERTA)
        Me.FONDO.Controls.Add(Me.Texto_contenido)
        Me.FONDO.Controls.Add(Me.BARRA_CARGA)
        Me.FONDO.Controls.Add(Me.Texto_titulo)
        Me.FONDO.Location = New System.Drawing.Point(0, 0)
        Me.FONDO.Name = "FONDO"
        Me.FONDO.Size = New System.Drawing.Size(409, 67)
        Me.FONDO.TabIndex = 0
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_CERRAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_CERRAR.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.BTN_CERRAR.IconColor = System.Drawing.SystemColors.ControlText
        Me.BTN_CERRAR.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTN_CERRAR.Location = New System.Drawing.Point(365, 0)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(32, 32)
        Me.BTN_CERRAR.TabIndex = 5
        Me.BTN_CERRAR.TabStop = False
        '
        'Texto_contenido
        '
        Me.Texto_contenido.BackColor = System.Drawing.Color.Transparent
        Me.Texto_contenido.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto_contenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Texto_contenido.Location = New System.Drawing.Point(84, 31)
        Me.Texto_contenido.Name = "Texto_contenido"
        Me.Texto_contenido.Size = New System.Drawing.Size(120, 20)
        Me.Texto_contenido.TabIndex = 3
        Me.Texto_contenido.Text = "Guna2HtmlLabel1"
        '
        'Texto_titulo
        '
        Me.Texto_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Texto_titulo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto_titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Texto_titulo.Location = New System.Drawing.Point(84, 6)
        Me.Texto_titulo.Name = "Texto_titulo"
        Me.Texto_titulo.Size = New System.Drawing.Size(141, 23)
        Me.Texto_titulo.TabIndex = 1
        Me.Texto_titulo.Text = "Guna2HtmlLabel1"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Empty
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Empty
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ALERTAS_POPUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 67)
        Me.Controls.Add(Me.FONDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ALERTAS_POPUP"
        Me.Text = "GRUPOS"
        CType(Me.ICONO_ALERTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FONDO.ResumeLayout(False)
        Me.FONDO.PerformLayout()
        CType(Me.BTN_CERRAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tiempo As Timer
    Friend WithEvents FONDO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ICONO_ALERTA As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Texto_contenido As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BARRA_CARGA As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Texto_titulo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_CERRAR As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
