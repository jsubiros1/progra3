<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrimerUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarioAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnSiguienteUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimoUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnadirUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnEditarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscarUsuario = New System.Windows.Forms.ToolStripTextBox()
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
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtTelCasa)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 234)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empleado"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCedula.Location = New System.Drawing.Point(22, 44)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cedula:"
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCod.Location = New System.Drawing.Point(22, 127)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(63, 20)
        Me.txtCod.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(278, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Direccion"
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(151, 124)
        Me.dtFechaNacimiento.MaxDate = New Date(2013, 11, 25, 0, 0, 0, 0)
        Me.dtFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaNacimiento.TabIndex = 28
        Me.dtFechaNacimiento.Value = New Date(2013, 11, 25, 0, 0, 0, 0)
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCelular.Location = New System.Drawing.Point(391, 44)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCelular.TabIndex = 26
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTelCasa.Location = New System.Drawing.Point(524, 44)
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(100, 20)
        Me.txtTelCasa.TabIndex = 27
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCorreo.Location = New System.Drawing.Point(22, 179)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(175, 20)
        Me.txtCorreo.TabIndex = 30
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDireccion.Location = New System.Drawing.Point(281, 109)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(186, 90)
        Me.txtDireccion.TabIndex = 31
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNombre.Location = New System.Drawing.Point(151, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Codigo Dpto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Telefono Casa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Telefono Celular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nombre Completo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrimerUsuario, Me.btnUsuarioAnterior, Me.btnSiguienteUsuario, Me.btnUltimoUsuario, Me.ToolStripSeparator1, Me.btnAnadirUsuario, Me.btnEditarUsuario, Me.btnBuscarUsuario, Me.txtBuscarUsuario, Me.ToolStripSeparator2, Me.btnImprimir, Me.btnGuardar, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(789, 25)
        Me.ToolStrip1.TabIndex = 2
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
        Me.btnAnadirUsuario.Image = CType(resources.GetObject("btnAnadirUsuario.Image"), System.Drawing.Image)
        Me.btnAnadirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnadirUsuario.Name = "btnAnadirUsuario"
        Me.btnAnadirUsuario.Size = New System.Drawing.Size(105, 22)
        Me.btnAnadirUsuario.Text = "Añadir Usuario"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.Image = CType(resources.GetObject("btnEditarUsuario.Image"), System.Drawing.Image)
        Me.btnEditarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(100, 22)
        Me.btnEditarUsuario.Text = "Editar Usuario"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(110, 22)
        Me.btnBuscarUsuario.Text = "Buscar x Cedula"
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(100, 25)
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
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmEmpleados"
        Me.Text = "frmEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtFechaNacimiento As DateTimePicker
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelCasa As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrimerUsuario As ToolStripButton
    Friend WithEvents btnUsuarioAnterior As ToolStripButton
    Friend WithEvents btnSiguienteUsuario As ToolStripButton
    Friend WithEvents btnUltimoUsuario As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnAnadirUsuario As ToolStripButton
    Friend WithEvents btnEditarUsuario As ToolStripButton
    Friend WithEvents btnBuscarUsuario As ToolStripButton
    Friend WithEvents txtBuscarUsuario As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnCancelar As ToolStripButton
End Class
