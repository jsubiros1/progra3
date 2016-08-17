<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbConta = New System.Windows.Forms.RadioButton()
        Me.rbAdmi = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogIn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLogIn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 126)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbConta)
        Me.GroupBox2.Controls.Add(Me.rbAdmi)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 49)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Usuario"
        '
        'rbConta
        '
        Me.rbConta.AutoSize = True
        Me.rbConta.Location = New System.Drawing.Point(100, 26)
        Me.rbConta.Name = "rbConta"
        Me.rbConta.Size = New System.Drawing.Size(68, 17)
        Me.rbConta.TabIndex = 1
        Me.rbConta.TabStop = True
        Me.rbConta.Text = "Contador"
        Me.rbConta.UseVisualStyleBackColor = True
        '
        'rbAdmi
        '
        Me.rbAdmi.AutoSize = True
        Me.rbAdmi.Location = New System.Drawing.Point(6, 26)
        Me.rbAdmi.Name = "rbAdmi"
        Me.rbAdmi.Size = New System.Drawing.Size(88, 17)
        Me.rbAdmi.TabIndex = 0
        Me.rbAdmi.TabStop = True
        Me.rbAdmi.Text = "Administrador"
        Me.rbAdmi.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(343, 53)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Usuario"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(118, 23)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "LogIn"
        '
        'txtLogIn
        '
        Me.txtLogIn.Location = New System.Drawing.Point(343, 16)
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.Size = New System.Drawing.Size(100, 20)
        Me.txtLogIn.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrimerUsuario, Me.btnUsuarioAnterior, Me.btnSiguienteUsuario, Me.btnUltimoUsuario, Me.ToolStripSeparator1, Me.btnAnadirUsuario, Me.btnEditarUsuario, Me.btnBuscarUsuario, Me.ToolStripSeparator2, Me.btnImprimir, Me.btnGuardar, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(526, 25)
        Me.ToolStrip1.TabIndex = 12
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
        Me.btnAnadirUsuario.Size = New System.Drawing.Size(62, 22)
        Me.btnAnadirUsuario.Text = "Nuevo"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.Image = CType(resources.GetObject("btnEditarUsuario.Image"), System.Drawing.Image)
        Me.btnEditarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(100, 22)
        Me.btnEditarUsuario.Text = "Editar Usuario"
        Me.btnEditarUsuario.ToolTipText = "Editar Pago"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(105, 22)
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
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbConta As RadioButton
    Friend WithEvents rbAdmi As RadioButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLogIn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
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
