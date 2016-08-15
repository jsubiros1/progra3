Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sslabelFecha.Text = Date.Today.ToShortDateString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub SalirDeLaAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicacionToolStripMenuItem.Click

        If MessageBox.Show("Quiere Salir de la Aplicación?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
