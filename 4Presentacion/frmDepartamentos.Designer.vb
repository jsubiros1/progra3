<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoDep = New System.Windows.Forms.TextBox()
        Me.txtNombreDep = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrimerUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarioAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnSiguienteUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimoUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnadirUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnEditarDepartamento = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigoDep)
        Me.GroupBox1.Controls.Add(Me.txtNombreDep)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 200)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtObservaciones.Location = New System.Drawing.Point(117, 98)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(175, 90)
        Me.txtObservaciones.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cod dpto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Observaciones: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre dpto"
        '
        'txtCodigoDep
        '
        Me.txtCodigoDep.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCodigoDep.Location = New System.Drawing.Point(82, 46)
        Me.txtCodigoDep.Name = "txtCodigoDep"
        Me.txtCodigoDep.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigoDep.TabIndex = 10
        '
        'txtNombreDep
        '
        Me.txtNombreDep.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNombreDep.Location = New System.Drawing.Point(192, 46)
        Me.txtNombreDep.Name = "txtNombreDep"
        Me.txtNombreDep.Size = New System.Drawing.Size(118, 20)
        Me.txtNombreDep.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrimerUsuario, Me.btnUsuarioAnterior, Me.btnSiguienteUsuario, Me.btnUltimoUsuario, Me.ToolStripSeparator1, Me.btnAnadirUsuario, Me.btnEditarDepartamento, Me.btnBuscarUsuario, Me.ToolStripSeparator2, Me.btnImprimir, Me.btnGuardar, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPrimerUsuario
        '
        Me.btnPrimerUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrimerUsuario.Image = CType(resources.GetObject("btnPrimerUsuario.Image"), System.Drawing.Image)
        Me.btnPrimerUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrimerUsuario.Name = "btnPrimerUsuario"
        Me.btnPrimerUsuario.Size = New System.Drawing.Size(23, 22)
        Me.btnPrimerUsuario.Text = "Ir al Primer Usuario"
        Me.btnPrimerUsuario.ToolTipText = "Ir al Primer Usuario"
        '
        'btnUsuarioAnterior
        '
        Me.btnUsuarioAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUsuarioAnterior.Image = CType(resources.GetObject("btnUsuarioAnterior.Image"), System.Drawing.Image)
        Me.btnUsuarioAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuarioAnterior.Name = "btnUsuarioAnterior"
        Me.btnUsuarioAnterior.Size = New System.Drawing.Size(23, 22)
        Me.btnUsuarioAnterior.Text = "Usuario Anterior"
        Me.btnUsuarioAnterior.ToolTipText = "Usuario Anterior"
        '
        'btnSiguienteUsuario
        '
        Me.btnSiguienteUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSiguienteUsuario.Image = CType(resources.GetObject("btnSiguienteUsuario.Image"), System.Drawing.Image)
        Me.btnSiguienteUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSiguienteUsuario.Name = "btnSiguienteUsuario"
        Me.btnSiguienteUsuario.Size = New System.Drawing.Size(23, 22)
        Me.btnSiguienteUsuario.Text = "Siguiente Usuario"
        '
        'btnUltimoUsuario
        '
        Me.btnUltimoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimoUsuario.Image = CType(resources.GetObject("btnUltimoUsuario.Image"), System.Drawing.Image)
        Me.btnUltimoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimoUsuario.Name = "btnUltimoUsuario"
        Me.btnUltimoUsuario.Size = New System.Drawing.Size(23, 22)
        Me.btnUltimoUsuario.Text = "Ir al Ultimo Usuario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnadirUsuario
        '
        Me.btnAnadirUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnadirUsuario.Image = CType(resources.GetObject("btnAnadirUsuario.Image"), System.Drawing.Image)
        Me.btnAnadirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnadirUsuario.Name = "btnAnadirUsuario"
        Me.btnAnadirUsuario.Size = New System.Drawing.Size(23, 22)
        Me.btnAnadirUsuario.Text = "Añadir Departamento"
        '
        'btnEditarDepartamento
        '
        Me.btnEditarDepartamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditarDepartamento.Image = CType(resources.GetObject("btnEditarDepartamento.Image"), System.Drawing.Image)
        Me.btnEditarDepartamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditarDepartamento.Name = "btnEditarDepartamento"
        Me.btnEditarDepartamento.Size = New System.Drawing.Size(23, 22)
        Me.btnEditarDepartamento.Text = "Editar Departamento"
        Me.btnEditarDepartamento.ToolTipText = "Editar Departamento"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscarUsuario.Text = "Buscar Usuario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDepartamentos"
        Me.Text = "frmDepartamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoDep As TextBox
    Friend WithEvents txtNombreDep As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrimerUsuario As ToolStripButton
    Friend WithEvents btnUsuarioAnterior As ToolStripButton
    Friend WithEvents btnSiguienteUsuario As ToolStripButton
    Friend WithEvents btnUltimoUsuario As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnAnadirUsuario As ToolStripButton
    Friend WithEvents btnEditarDepartamento As ToolStripButton
    Friend WithEvents btnBuscarUsuario As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnCancelar As ToolStripButton
End Class
