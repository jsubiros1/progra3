Public Class frmMenu

    'este procedimiento es el inicial y la valida el acceso al sistema
    Public Shared Sub Main()
        Application.EnableVisualStyles()

        Dim fAcceso As New frmLogin
        If fAcceso.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            fAcceso.Close()
            Application.Run(New frmMenu)
        End If
    End Sub
    Private Sub mnuUsuarios_Click(sender As Object, e As EventArgs) Handles mnuUsuarios.Click
        Dim pantalla As New frmUsuarios
        pantalla.MdiParent = Me
        mnuUsuarios.Enabled = False
        pantalla.Show()
    End Sub


    Private Sub mnuAcerca_Click(sender As Object, e As EventArgs) Handles mnuAcerca.Click
        Dim pantalla As New frmAcercaDe
        pantalla.MdiParent = Me
        mnuAcerca.Enabled = False
        pantalla.Show()
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tslFecha.Text = Date.Today.ToShortDateString
        tslNombre.Text = "Usuario:" & UsuarioActual.login

        If UsuarioActual.administrador Then
            mnuAcerca.Enabled = False
        End If
    End Sub


    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEmpleados.Click
        Dim pantalla As New frmEmpleados
        pantalla.MdiParent = Me
        mnuEmpleados.Enabled = False
        pantalla.Show()
    End Sub

    Private Sub mnuCategoria_Click(sender As Object, e As EventArgs) Handles mnuCategoria.Click
        Dim pantalla As New frmCategoriaActivo
        pantalla.MdiParent = Me
        mnuCategoria.Enabled = False
        pantalla.Show()
    End Sub

    Private Sub mnuDepartamentos_Click(sender As Object, e As EventArgs) Handles mnuDepartamentos.Click
        Dim pantalla As New frmDepartamentos
        pantalla.MdiParent = Me
        mnuDepartamentos.Enabled = False
        pantalla.Show()
    End Sub

    Private Sub mnuActivos_Click(sender As Object, e As EventArgs) Handles mnuActivos.Click
        Dim pantalla As New frmActivos
        pantalla.MdiParent = Me
        mnuActivos.Enabled = False
        pantalla.Show()
    End Sub
End Class