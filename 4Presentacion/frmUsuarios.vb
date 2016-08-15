Public Class frmUsuarios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sslabelFecha.Text = Date.Today.ToShortDateString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub SalirDeLaAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicacionToolStripMenuItem.Click


        Application.Exit()

    End Sub
End Class
