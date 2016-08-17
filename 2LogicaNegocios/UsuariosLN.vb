Imports _1AccesoADatos
Imports _3Entidades

Public Class UsuariosLN


    Public Sub New()
            ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
        End Sub



    ''' <summary>
    ''' Inserta un usuario
    ''' </summary>
    ''' <param name="pUsuarios"></param>
    Public Sub InsertarUsuarios(ByVal pUsuarios As UsuariosEN)
            Try
            If (pUsuarios.login.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If

            Dim usuario As New UsuariosAD

            If Not IsNothing(usuario.ObtenerUsuarioPorLogin(pUsuarios.login)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            usuario.InsertarUsuario(pUsuarios)



        Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        End Sub

        Public Sub ModificarUsuarios(ByVal pUsuarios As UsuariosEN)
            Try

            If (pUsuarios.login.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New UsuariosAD

            If IsNothing(userAcceso.ObtenerUsuariosPorLogin(pUsuarios.login)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarUsuarios(pUsuarios)


        Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        End Sub

        Public Sub BorrarUsuarios(ByVal pUsuarios As UsuariosEN)
            Try


            Dim SocAcceso As New UsuariosAD


            If IsNothing(SocAcceso.ObtenerUsuariosPorLogin(pUsuarios.login)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            SocAcceso.BorrarUsuarios(pUsuarios)

        Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        End Sub

        Public Function ObtenerUsuariosPorLogin(ByVal pLogin As String) As UsuariosEN
            Try

            If (pLogin.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")
            Else
                Dim myUserAD As New UsuariosAD
                Return myUserAD.ObtenerUsuariosPorLogin(pLogin)
            End If

        Catch ex As Exception
                    Throw New Exception(ex.Message)
                Exit Function
            End Try
        End Function

        Public Function obtenerTodosUsuarioss() As List(Of UsuariosEN)
            Try
            Dim SocAcceso As New UsuariosAD
            Return SocAcceso.obtenerTodosUsuarioss

        Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Function
            End Try
        End Function



    End Class
