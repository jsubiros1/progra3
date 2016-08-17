Imports _2LogicaNegocios
Imports _3Entidades

Public Class frmDepartamentos

    Private Sub frmUsuario(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CType(Me.MdiParent, frmMenu).mnuDepartamentos.Enabled = True




    End Sub


    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoDep.Enabled = False
        txtNombreDep.Enabled = False
        txtObservaciones.Enabled = False
    End Sub

    Private Sub btnAnadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAnadirUsuario.Click
        btnBuscarUsuario.Enabled = False
        btnEditarDepartamento.Enabled = False
        btnImprimir.Enabled = False
        btnPrimerUsuario.Enabled = False
        btnSiguienteUsuario.Enabled = False
        btnUltimoUsuario.Enabled = False
        btnUsuarioAnterior.Enabled = False
        txtCodigoDep.Enabled = True
        txtNombreDep.Enabled = True
        txtObservaciones.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim user1 As New DepartamentosEN

            user1.Cod_Dept = txtCodigoDep.Text
            user1.Nombre = txtNombreDep.Text
            user1.Observaciones = txtObservaciones.Text


            Dim userLN As New DepartamentosLN
            userLN.InsertarDepartamento(user1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class