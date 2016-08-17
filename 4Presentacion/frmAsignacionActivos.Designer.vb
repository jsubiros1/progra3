<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignacionActivos))
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtxUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodAsiga = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnPrimerUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarioAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnSiguienteUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimoUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnadirUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnEditarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(200, 193)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(153, 58)
        Me.txtDireccion.TabIndex = 44
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(40, 203)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(81, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Usuario Asigna:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Cedula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Codigo Asigna:"
        '
        'txtxUsuario
        '
        Me.txtxUsuario.Location = New System.Drawing.Point(348, 139)
        Me.txtxUsuario.Name = "txtxUsuario"
        Me.txtxUsuario.Size = New System.Drawing.Size(137, 20)
        Me.txtxUsuario.TabIndex = 37
        '
        'txtCodAsiga
        '
        Me.txtCodAsiga.Location = New System.Drawing.Point(46, 139)
        Me.txtCodAsiga.Name = "txtCodAsiga"
        Me.txtCodAsiga.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAsiga.TabIndex = 36
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(200, 139)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 35
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrimerUsuario, Me.btnUsuarioAnterior, Me.btnSiguienteUsuario, Me.btnUltimoUsuario, Me.ToolStripSeparator1, Me.btnAnadirUsuario, Me.btnEditarUsuario, Me.btnBuscarUsuario, Me.ToolStripSeparator2, Me.btnImprimir, Me.btnGuardar, Me.btnCancelar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 27)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnPrimerUsuario
        '
        Me.btnPrimerUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrimerUsuario.Image = CType(resources.GetObject("btnPrimerUsuario.Image"), System.Drawing.Image)
        Me.btnPrimerUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrimerUsuario.Name = "btnPrimerUsuario"
        Me.btnPrimerUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnPrimerUsuario.Text = "Ir al Primer Usuario"
        Me.btnPrimerUsuario.ToolTipText = "Ir al Primer Usuario"
        '
        'btnUsuarioAnterior
        '
        Me.btnUsuarioAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUsuarioAnterior.Image = CType(resources.GetObject("btnUsuarioAnterior.Image"), System.Drawing.Image)
        Me.btnUsuarioAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuarioAnterior.Name = "btnUsuarioAnterior"
        Me.btnUsuarioAnterior.Size = New System.Drawing.Size(23, 20)
        Me.btnUsuarioAnterior.Text = "Usuario Anterior"
        Me.btnUsuarioAnterior.ToolTipText = "Usuario Anterior"
        '
        'btnSiguienteUsuario
        '
        Me.btnSiguienteUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSiguienteUsuario.Image = CType(resources.GetObject("btnSiguienteUsuario.Image"), System.Drawing.Image)
        Me.btnSiguienteUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSiguienteUsuario.Name = "btnSiguienteUsuario"
        Me.btnSiguienteUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnSiguienteUsuario.Text = "Siguiente Usuario"
        '
        'btnUltimoUsuario
        '
        Me.btnUltimoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimoUsuario.Image = CType(resources.GetObject("btnUltimoUsuario.Image"), System.Drawing.Image)
        Me.btnUltimoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimoUsuario.Name = "btnUltimoUsuario"
        Me.btnUltimoUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnUltimoUsuario.Text = "Ir al Ultimo Usuario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'btnAnadirUsuario
        '
        Me.btnAnadirUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnadirUsuario.Image = CType(resources.GetObject("btnAnadirUsuario.Image"), System.Drawing.Image)
        Me.btnAnadirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnadirUsuario.Name = "btnAnadirUsuario"
        Me.btnAnadirUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnAnadirUsuario.Text = "Añadir Usuario"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditarUsuario.Image = CType(resources.GetObject("btnEditarUsuario.Image"), System.Drawing.Image)
        Me.btnEditarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnEditarUsuario.Text = "Editar Usuario"
        Me.btnEditarUsuario.ToolTipText = "Editar Pago"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(23, 20)
        Me.btnBuscarUsuario.Text = "Buscar Usuario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 20)
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 20)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 20)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmAsignacionActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 324)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtxUsuario)
        Me.Controls.Add(Me.txtCodAsiga)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmAsignacionActivos"
        Me.Text = "frmAsignacionActivos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtxUsuario As TextBox
    Friend WithEvents txtCodAsiga As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnPrimerUsuario As ToolStripButton
    Friend WithEvents btnUsuarioAnterior As ToolStripButton
    Friend WithEvents btnSiguienteUsuario As ToolStripButton
    Friend WithEvents btnUltimoUsuario As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnAnadirUsuario As ToolStripButton
    Friend WithEvents btnEditarUsuario As ToolStripButton
    Friend WithEvents btnBuscarUsuario As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnCancelar As ToolStripButton
End Class
