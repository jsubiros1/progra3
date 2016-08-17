Imports System.Data.OleDb
Imports _3Entidades

Public Class UsuariosAD
#Region "Variable para conexion a base de datos"
    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoDB.accdb")
#End Region

#Region "Constructor"
    Public Sub New()
            ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
        End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Insertar un nuevo usuario
    ''' </summary>
    ''' <param name="pUsuario">Objeto Usuario</param>

    Public Sub InsertarUsuario(ByVal pUsuario As UsuariosEN)
            Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "INSERT INTO Usuarios(Login, NombreCompleto, Clave, Administrador, Contador) 
                        VALUES(@Login, @NombreCompleto, @Clave, @Administrador, @Contador)"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.login
            cmdInsert.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pUsuario.nombreCompleto
            cmdInsert.Parameters.Add("@Clave", OleDbType.Date).Value = pUsuario.clave
            cmdInsert.Parameters.Add("@Administrador", OleDbType.Integer).Value = pUsuario.administrador
            cmdInsert.Parameters.Add("@Contador", OleDbType.Double).Value = pUsuario.contador


            cmdInsert.ExecuteNonQuery()
            miConexion.Close()


        Catch ex As Exception
                If (miConexion.State = ConnectionState.Open) Then
                    miConexion.Close()
                End If
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        End Sub


    ''' <summary>
    ''' Modificar un Usuario
    ''' </summary>
    ''' <param name="pUsuario">Objeto Usuario</param>


    Public Sub ModificarUsuario(ByVal pUsuario As UsuariosEN)
        Try


            Dim strInsert As String
            miConexion.Open()

            strInsert = "UPDATE Usuarios 
                        SET(NombreCompleto = @NombreCompleto, Clave = @Clave, Administrador = @Administrador, Contador = @Contador)
                        WHERE Login = @Login"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.login
            cmdInsert.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pUsuario.nombreCompleto
            cmdInsert.Parameters.Add("@Clave", OleDbType.Date).Value = pUsuario.clave
            cmdInsert.Parameters.Add("@Administrador", OleDbType.Integer).Value = pUsuario.administrador
            cmdInsert.Parameters.Add("@Contador", OleDbType.Double).Value = pUsuario.contador

            cmdInsert.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Borrar un Usuario
    ''' </summary>
    ''' <param name="pUsuario">Objeto Usuario</param>

    Public Sub BorrarUsuario(ByVal pUsuario As UsuariosEN)
            Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "DELETE FROM Usuarios
                        WHERE Login = @Login"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuario.login

            cmdInsert.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
                If (miConexion.State = ConnectionState.Open) Then
                    miConexion.Close()
                End If
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        End Sub


    ''' <summary>
    ''' Obtener un usuario por login
    ''' </summary>
    ''' <param name="pLogin">Login o nombre de usuario</param>
    ''' <returns>Objeto Usuario</returns>

    Public Function ObtenerUsuarioPorLogin(ByVal pLogin As String) As UsuariosEN

        Dim usuario As New UsuariosEN

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Usuarios 
                        WHERE Login= @Login"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            cmdSelect.Parameters.Add("@Login", OleDbType.VarChar).Value = pLogin

            Dim drUsuario As OleDbDataReader = cmdSelect.ExecuteReader
            While (drUsuario.Read())

                usuario.login = drUsuario("Login")
                usuario.nombreCompleto = drUsuario("NombreCompleto")
                usuario.administrador = drUsuario("Administrador")
                usuario.contador = drUsuario("Contador")


            End While

            miConexion.Close()
            Return usuario

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function



    ''' <summary>
    ''' Obtener todos los Usuarios
    ''' </summary>
    ''' <returns></returns>

    Public Function obtenerTodosUsuarios() As List(Of UsuariosEN)

        Dim usuarios As New List(Of UsuariosEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Usuarios"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            Dim drUsuario As OleDbDataReader = cmdSelect.ExecuteReader
            While (drUsuario.Read())

                Dim u As New UsuariosEN

                u.login = drUsuario("Login")
                u.nombreCompleto = drUsuario("NombreCompleto")
                u.clave = drUsuario("Clave")
                u.administrador = drUsuario("Administrador")
                u.contador = drUsuario("Contador")

                usuarios.Add(u)
            End While

            miConexion.Close()
            Return usuarios

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If

            Throw New Exception(ex.Message)
            Return Nothing

        End Try

    End Function

#End Region

End Class
