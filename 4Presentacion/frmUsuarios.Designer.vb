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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoríasActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosPorEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosPorCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDeLaAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sslabelFecha = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.sslabelFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosDatosToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosDatosToolStripMenuItem
        '
        Me.CatálogosDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.CategoríasActivosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ActivosToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.CatálogosDatosToolStripMenuItem.Name = "CatálogosDatosToolStripMenuItem"
        Me.CatálogosDatosToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.CatálogosDatosToolStripMenuItem.Text = "Catálogos Datos"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'CategoríasActivosToolStripMenuItem
        '
        Me.CategoríasActivosToolStripMenuItem.Name = "CategoríasActivosToolStripMenuItem"
        Me.CategoríasActivosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CategoríasActivosToolStripMenuItem.Text = "Categorías Activos" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ActivosToolStripMenuItem
        '
        Me.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        Me.ActivosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ActivosToolStripMenuItem.Text = "Activos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignaciónToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'AsignaciónToolStripMenuItem
        '
        Me.AsignaciónToolStripMenuItem.Name = "AsignaciónToolStripMenuItem"
        Me.AsignaciónToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AsignaciónToolStripMenuItem.Text = "Asignación"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivosPorEmpleadoToolStripMenuItem, Me.ActivosPorCategoríaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ActivosPorEmpleadoToolStripMenuItem
        '
        Me.ActivosPorEmpleadoToolStripMenuItem.Name = "ActivosPorEmpleadoToolStripMenuItem"
        Me.ActivosPorEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ActivosPorEmpleadoToolStripMenuItem.Text = "Activos por Empleado"
        '
        'ActivosPorCategoríaToolStripMenuItem
        '
        Me.ActivosPorCategoríaToolStripMenuItem.Name = "ActivosPorCategoríaToolStripMenuItem"
        Me.ActivosPorCategoríaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ActivosPorCategoríaToolStripMenuItem.Text = "Activos por  Categoría"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de.. "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDeLaAplicacionToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SalirDeLaAplicacionToolStripMenuItem
        '
        Me.SalirDeLaAplicacionToolStripMenuItem.Name = "SalirDeLaAplicacionToolStripMenuItem"
        Me.SalirDeLaAplicacionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SalirDeLaAplicacionToolStripMenuItem.Text = "Salir de la Aplicacion"
        '
        'sslabelFecha
        '
        Me.sslabelFecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.sslabelFecha.Location = New System.Drawing.Point(0, 239)
        Me.sslabelFecha.Name = "sslabelFecha"
        Me.sslabelFecha.Size = New System.Drawing.Size(578, 22)
        Me.sslabelFecha.TabIndex = 1
        Me.sslabelFecha.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(281, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(281, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.sslabelFecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sslabelFecha.ResumeLayout(False)
        Me.sslabelFecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoríasActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosPorEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosPorCategoríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sslabelFecha As StatusStrip
    Friend WithEvents SalirDeLaAplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
