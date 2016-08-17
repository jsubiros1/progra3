Imports _3Entidades
Imports _2LogicaNegocios

Public Class frmActivos
    Private Sub frmActivos(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CType(Me.MdiParent, frmMenu).mnuActivos.Enabled = True




    End Sub
    Private Sub frmActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lstCategorias As New List(Of CategoriaActivoEN)
        lstCategorias = New CategoriaActivoLN().obtenerTodasCategoria

        cbxCategoria.DataSource = lstCategorias
        cbxCategoria.DisplayMember = "cod_categoria"
        cbxCategoria.ValueMember = "cod_categoria"
    End Sub

    Private Sub btnAnadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAnadirUsuario.Click

    End Sub
End Class