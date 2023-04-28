<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transicion))
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Video_fondo = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 1290
        '
        'Video_fondo
        '
        Me.Video_fondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Video_fondo.Enabled = True
        Me.Video_fondo.Location = New System.Drawing.Point(0, 0)
        Me.Video_fondo.Name = "Video_fondo"
        Me.Video_fondo.OcxState = CType(resources.GetObject("Video_fondo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Video_fondo.Size = New System.Drawing.Size(942, 604)
        Me.Video_fondo.TabIndex = 21
        '
        'Transicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 604)
        Me.Controls.Add(Me.Video_fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transicion"
        Me.Text = "Transicion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Video_fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Video_fondo As AxWMPLib.AxWindowsMediaPlayer
End Class
