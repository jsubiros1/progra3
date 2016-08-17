Imports _3Entidades
Imports _1AccesoADatos


Public Class UsuariosLN

    Public Function ObtenerUsuariosPorLogin(ByVal pLogin As String) As UsuariosEN
        Try

            If (pLogin.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")
            Else
                Dim myUserAD As New UsuariosAD
                Return myUserAD.ObtenerUsuarioPorLogin(pLogin)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
