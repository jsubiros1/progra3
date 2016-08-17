Imports _1AccesoADatos
Imports _3Entidades

Public Class UsuariosLN

#Region "Cobstructor"
    Public Sub New()
            ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
        End Sub
#End Region


#Region "Funciones"
    ''' <summary>
    ''' Inserta un usuario
    ''' </summary>
    ''' <param name="pUsuarios">Objeto Usuario</param>
    Public Sub InsertarUsuario(ByVal pUsuarios As UsuariosEN)
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

    ''' <summary>
    ''' Modificar usuario
    ''' </summary>
    ''' <param name="pUsuarios">Objeto Usuario</param>


    Public Sub ModificarUsuario(ByVal pUsuarios As UsuariosEN)
        Try

            If (pUsuarios.login.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")
            End If

            Dim user As New UsuariosAD

            If IsNothing(user.ObtenerUsuarioPorLogin(pUsuarios.login)) Then
                Throw New Exception("Este Usuario NO  Existe")

            End If
            user.ModificarUsuario(pUsuarios)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Borrar Usuario
    ''' </summary>
    ''' <param name="pUsuarios"></param>

    Public Sub BorrarUsuario(ByVal pUsuarios As UsuariosEN)
        Try

            Dim usr As New UsuariosAD


            If IsNothing(usr.ObtenerUsuarioPorLogin(pUsuarios.login)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            usr.BorrarUsuario(pUsuarios)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Obtener un usuario por login
    ''' </summary>
    ''' <param name="pLogin">String nombre de usuario</param>
    ''' <returns>Objeto Usuario</returns>

    Public Function ObtenerUsuarioPorLogin(ByVal pLogin As String) As UsuariosEN
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


    ''' <summary>
    ''' Obtener todos los usuarios
    ''' </summary>
    ''' <returns>Lista de objetos de usuarios</returns>

    Public Function obtenerTodoLosUsuarios() As List(Of UsuariosEN)
        Try
            Dim usr As New UsuariosAD
            Return usr.obtenerTodosUsuarios

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region

End Class
