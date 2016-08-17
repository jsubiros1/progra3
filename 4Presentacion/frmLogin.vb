Imports _2LogicaNegocios
Imports _3Entidades

Public Class frmLogin

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim validaUser As New UsuariosLN
        UsuarioActual = validaUser.ObtenerUsuariosPorLogin(txtUsuario.Text)

        If IsNothing(UsuarioActual) Then
            MessageBox.Show("No existe ese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        ElseIf UsuarioActual.clave = txtPassword.Text Then
            Me.DialogResult = DialogResult.Yes
        Else
            MessageBox.Show("La clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If



    End Sub

End Class
