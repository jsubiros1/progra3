Imports _3Entidades
Imports _2LogicaNegocios

Public Class frmUsuarios


    Private Sub frmUsuario(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CType(Me.MdiParent, frmMenu).mnuUsuarios.Enabled = True




    End Sub
    Private Sub btnAnadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAnadirUsuario.Click
        Try

            btnBuscarUsuario.Enabled = False
            btnEditarUsuario.Enabled = False
            btnImprimir.Enabled = False
            btnPrimerUsuario.Enabled = False
            btnSiguienteUsuario.Enabled = False
            btnUltimoUsuario.Enabled = False
            btnUsuarioAnterior.Enabled = False
            txtLogIn.Enabled = True
            txtNombreUsuario.Enabled = True
            txtPassword.Enabled = True





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click
        Try
            Dim strLogin As String = InputBox("Digite su Login")
            Dim myUser As New UsuariosEN
            Dim userValida As New UsuariosLN
            myUser = userValida.ObtenerUsuariosPorLogin(strLogin)


            If Not IsNothing(myUser) Then


                txtLogIn.Text = myUser.login
                txtNombreUsuario.Text = myUser.nombreCompleto
                txtPassword.Text = myUser.clave

                If myUser.administrador Then
                    rbAdmi.Checked = True
                    rbConta.Checked = False
                ElseIf myUser.contador Then
                    rbAdmi.Checked = False
                    rbConta.Checked = True
                End If

            Else
                MessageBox.Show("El Usuario con el Login: " & strLogin & " no existe ")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        Try
            Dim user1 As New UsuariosEN

            user1.login = txtLogIn.Text
            user1.nombreCompleto = txtNombreUsuario.Text
            user1.clave = txtPassword.Text


            If rbAdmi.Checked Then
                user1.administrador = True
                user1.contador = False
            ElseIf rbConta.Checked Then
                user1.administrador = False
                user1.contador = True
            End If



            Dim UserLogNegocio As New UsuariosLN
            UserLogNegocio.ModificarUsuarios(user1)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim user1 As New UsuariosEN

            user1.login = txtLogIn.Text
            user1.nombreCompleto = txtNombreUsuario.Text
            user1.clave = txtPassword.Text


            If rbAdmi.Checked Then
                user1.administrador = True
                user1.contador = False
            ElseIf rbConta.Checked Then
                user1.administrador = False
                user1.contador = True
            End If

            Dim userLN As New UsuariosLN
            userLN.InsertarUsuarios(user1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtLogIn.Enabled = False
        txtNombreUsuario.Enabled = False
        txtPassword.Enabled = False

    End Sub

End Class