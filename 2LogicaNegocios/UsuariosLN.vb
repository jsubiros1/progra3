Imports _3Entidades
Imports _1AccesoADatos


Public Class UsuariosLN

    Public Function ObtenerUsuariosPorLogin(ByVal pLogin As String) As UsuariosEN
        Try
            If (pLogin.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim myUsuarioAD As New UsuariosAD
            Return myUsuarioAD.ObtenerUsuarioPorLogin(pLogin)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
