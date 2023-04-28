<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mostrar_categoria
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mostrar_categoria))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TXT_CATEGORIA = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FOTO_CAT = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.transicion = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.FOTO_CAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.BorderThickness = 10
        Me.Guna2GradientPanel1.Controls.Add(Me.TXT_CATEGORIA)
        Me.transicion.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(225, 262)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(572, 108)
        Me.Guna2GradientPanel1.TabIndex = 0
        Me.Guna2GradientPanel1.UseTransparentBackground = True
        '
        'TXT_CATEGORIA
        '
        Me.TXT_CATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.transicion.SetDecoration(Me.TXT_CATEGORIA, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.TXT_CATEGORIA, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TXT_CATEGORIA.Font = New System.Drawing.Font("Rounded Mplus 1c Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORIA.ForeColor = System.Drawing.Color.White
        Me.TXT_CATEGORIA.Location = New System.Drawing.Point(208, 38)
        Me.TXT_CATEGORIA.Name = "TXT_CATEGORIA"
        Me.TXT_CATEGORIA.Size = New System.Drawing.Size(223, 36)
        Me.TXT_CATEGORIA.TabIndex = 0
        Me.TXT_CATEGORIA.Text = "Guna2HtmlLabel1"
        Me.TXT_CATEGORIA.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FOTO_CAT
        '
        Me.FOTO_CAT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FOTO_CAT.BackColor = System.Drawing.Color.Transparent
        Me.transicion.SetDecoration(Me.FOTO_CAT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.FOTO_CAT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FOTO_CAT.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FOTO_CAT.ImageRotate = 0!
        Me.FOTO_CAT.Location = New System.Drawing.Point(402, 64)
        Me.FOTO_CAT.Name = "FOTO_CAT"
        Me.FOTO_CAT.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO_CAT.Size = New System.Drawing.Size(254, 242)
        Me.FOTO_CAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO_CAT.TabIndex = 1
        Me.FOTO_CAT.TabStop = False
        Me.FOTO_CAT.UseTransparentBackground = True
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.BorderRadius = 10
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.White
        Me.transicion.SetDecoration(Me.Guna2Shapes1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Shapes1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes1.Location = New System.Drawing.Point(356, 16)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
        Me.Guna2Shapes1.Size = New System.Drawing.Size(347, 351)
        Me.Guna2Shapes1.TabIndex = 2
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.UseTransparentBackground = True
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation2
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 1000
        '
        'transicion
        '
        Me.transicion.Cursor = Nothing
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
        Me.transicion.DefaultAnimation = Animation1
        '
        'Mostrar_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1009, 507)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.FOTO_CAT)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.transicion.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mostrar_categoria"
        Me.Text = "Mostrar_categoria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.FOTO_CAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents FOTO_CAT As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents TXT_CATEGORIA As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Tiempo As Timer
    Friend WithEvents transicion As Guna.UI2.WinForms.Guna2Transition
End Class
