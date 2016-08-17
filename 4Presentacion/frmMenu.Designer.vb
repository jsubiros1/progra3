<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDepartamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsigActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosXEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslFecha, Me.tslNombre})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 348)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(256, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Derechos Reservados"
        '
        'tslFecha
        '
        Me.tslFecha.Name = "tslFecha"
        Me.tslFecha.Size = New System.Drawing.Size(256, 17)
        Me.tslFecha.Spring = True
        Me.tslFecha.Text = "ToolStripStatusLabel2"
        '
        'tslNombre
        '
        Me.tslNombre.Name = "tslNombre"
        Me.tslNombre.Size = New System.Drawing.Size(256, 17)
        Me.tslNombre.Spring = True
        Me.tslNombre.Text = "ToolStripStatusLabel3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosDatosToolStripMenuItem, Me.ActivosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogosDatosToolStripMenuItem
        '
        Me.CatalogosDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDepartamentos, Me.mnuEmpleados, Me.mnuCategoria, Me.mnuUsuarios, Me.SalirToolStripMenuItem})
        Me.CatalogosDatosToolStripMenuItem.Name = "CatalogosDatosToolStripMenuItem"
        Me.CatalogosDatosToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.CatalogosDatosToolStripMenuItem.Text = "Catalogos Datos"
        '
        'mnuDepartamentos
        '
        Me.mnuDepartamentos.Name = "mnuDepartamentos"
        Me.mnuDepartamentos.Size = New System.Drawing.Size(188, 22)
        Me.mnuDepartamentos.Text = "Departamentos"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(188, 22)
        Me.mnuEmpleados.Text = "Empleados"
        '
        'mnuCategoria
        '
        Me.mnuCategoria.Name = "mnuCategoria"
        Me.mnuCategoria.Size = New System.Drawing.Size(188, 22)
        Me.mnuCategoria.Text = "Categorias de Activos"
        '
        'mnuUsuarios
        '
        Me.mnuUsuarios.Name = "mnuUsuarios"
        Me.mnuUsuarios.Size = New System.Drawing.Size(188, 22)
        Me.mnuUsuarios.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ActivosToolStripMenuItem
        '
        Me.ActivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActivos, Me.AsigActivosToolStripMenuItem})
        Me.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        Me.ActivosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ActivosToolStripMenuItem.Text = "Activos"
        '
        'mnuActivos
        '
        Me.mnuActivos.Name = "mnuActivos"
        Me.mnuActivos.Size = New System.Drawing.Size(144, 22)
        Me.mnuActivos.Text = "Mant.Activos"
        '
        'AsigActivosToolStripMenuItem
        '
        Me.AsigActivosToolStripMenuItem.Name = "AsigActivosToolStripMenuItem"
        Me.AsigActivosToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AsigActivosToolStripMenuItem.Text = "Asig.Activos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivosXEmpleadoToolStripMenuItem, Me.ListaEmpleadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ActivosXEmpleadoToolStripMenuItem
        '
        Me.ActivosXEmpleadoToolStripMenuItem.Name = "ActivosXEmpleadoToolStripMenuItem"
        Me.ActivosXEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ActivosXEmpleadoToolStripMenuItem.Text = "Activos x Empleado"
        '
        'ListaEmpleadosToolStripMenuItem
        '
        Me.ListaEmpleadosToolStripMenuItem.Name = "ListaEmpleadosToolStripMenuItem"
        Me.ListaEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ListaEmpleadosToolStripMenuItem.Text = "Lista Empleados"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcerca, Me.SalirToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'mnuAcerca
        '
        Me.mnuAcerca.Name = "mnuAcerca"
        Me.mnuAcerca.Size = New System.Drawing.Size(126, 22)
        Me.mnuAcerca.Text = "Acerca de"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 370)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslFecha As ToolStripStatusLabel
    Friend WithEvents tslNombre As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogosDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDepartamentos As ToolStripMenuItem
    Friend WithEvents mnuEmpleados As ToolStripMenuItem
    Friend WithEvents mnuCategoria As ToolStripMenuItem
    Friend WithEvents mnuUsuarios As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuActivos As ToolStripMenuItem
    Friend WithEvents AsigActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosXEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcerca As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
End Class
