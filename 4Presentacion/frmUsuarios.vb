Public Class frmUsuarios

    Public Shared Sub Main()
        Application.EnableVisualStyles()

        Dim fAcceso As New LoginForm1
        If fAcceso.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            fAcceso.Close()
            Application.Run(New frmUsuarios)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sslabelFecha.Text = Date.Today.ToShortDateString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub SalirDeLaAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicacionToolStripMenuItem.Click


        Application.Exit()

    End Sub
End Class
