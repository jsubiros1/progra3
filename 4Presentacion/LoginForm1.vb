Imports _2LogicaNegocios
Imports _3Entidades

Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click


        Dim validaUser As New UsuariosLN
            usuarioActual = validaUser.ObtenerUsuariosPorLogin(txtUsr.Text)

        If IsNothing(usuarioActual) Then
            MessageBox.Show("No existe ese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usuarioActual.clave = txtPss.Text Then
            Me.DialogResult = DialogResult.Yes
        Else
            MessageBox.Show("La clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
