Imports _2LogicaNegocios
Imports _3Entidades

Public Class frmEmpleados

    Private Sub frmEmpleados(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CType(Me.MdiParent, frmMenu).mnuEmpleados.Enabled = True




    End Sub
    Private Sub btnAnadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAnadirUsuario.Click
        Try
            Dim user1 As New EmpleadosEN

            user1.Cedula = txtCedula.Text
            user1.NombreCompleto = txtNombre.Text
            user1.Cod_Dept = txtCod.Text
            user1.Dir_Completa = txtDireccion.Text
            user1.E_Mail = txtCorreo.Text
            user1.Fec_Nacimiento = dtFechaNacimiento.Text

            user1.Tel_Casa = txtTelCasa.Text
            user1.Tel_Celular = txtCelular.Text

            Dim userLN As New EmpleadosLN
            userLN.InsertarEmpleado(user1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        Try
            Dim user1 As New EmpleadosEN

            user1.Cedula = txtCedula.Text
            user1.NombreCompleto = txtNombre.Text
            user1.Cod_Dept = txtCod.Text
            user1.Dir_Completa = txtDireccion.Text
            user1.E_Mail = txtCorreo.Text
            user1.Fec_Nacimiento = dtFechaNacimiento.Text

            user1.Tel_Casa = txtTelCasa.Text
            user1.Tel_Celular = txtCelular.Text






            Dim UserLogNegocio As New EmpleadosLN
            UserLogNegocio.ModificarEmpleado(user1)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click
        Try
            Dim strLogin As String = InputBox("Digite su Cedula")
            Dim myUser As New EmpleadosEN
            Dim userValida As New EmpleadosLN
            myUser = userValida.ObtenerEmpleadosPorCedula(strLogin)


            If Not IsNothing(myUser) Then


                txtCedula.Text = myUser.Cedula
                txtNombre.Text = myUser.NombreCompleto
                txtCelular.Text = myUser.Tel_Celular
                txtCod.Text = myUser.Cod_Dept
                txtCorreo.Text = myUser.E_Mail
                txtDireccion.Text = myUser.dir_completa
                dtFechaNacimiento.Text = myUser.fec_Nacimiento
                txtTelCasa.Text = myUser.tel_Casa



            Else
                MessageBox.Show("El Empleado con la Cedula: " & strLogin & " no existe ")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class