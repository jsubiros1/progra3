Imports _2LogicaNegocios
Imports _3Entidades

Public Class frmCategoriaActivo
    Private Sub frmUsuario(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CType(Me.MdiParent, frmMenu).mnuCategoria.Enabled = True




    End Sub
    Private Sub btnAnadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAnadirUsuario.Click
        Try
            Dim user1 As New CategoriaActivoEN

            user1.cod_categoria = txtCodCategoria.Text
            user1.descripcion = txtDescripcion.Text
            user1.observaciones = txtObservaciones.Text



            Dim userLN As New CategoriaActivoLN
            userLN.InsertarCategoria(user1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click

    End Sub
End Class