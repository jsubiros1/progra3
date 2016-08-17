Imports _3Entidades
Imports System.Data.OleDb

Public Class UsuariosAD


    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoDB.accdb")

    Public Sub New()
            ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
        End Sub

    Public Sub InsertarUsuarios(ByVal pUsuarios As UsuariosEN)
        Try


            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Usuarios(Login,NombreCompleto,Clave,Administrador,Contador) values(@Login,@NombreCompleto,@Clave,@Administrador,@Contador)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuarios.login
            cmdSocio.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pUsuarios.nombreCompleto
            cmdSocio.Parameters.Add("@Clave", OleDbType.VarChar).Value = pUsuarios.clave
            cmdSocio.Parameters.Add("@Administrador", OleDbType.Boolean).Value = pUsuarios.administrador
            cmdSocio.Parameters.Add("@Contador", OleDbType.Boolean).Value = pUsuarios.contador

            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarUsuarios(ByVal pUsuarios As UsuariosEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  Usuarios SET @NombreCompleto,@Clave,@Administrador,@Contador WHERE Login=@Login"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)

            cmdSocio.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pUsuarios.nombreCompleto
            cmdSocio.Parameters.Add("@Clave", OleDbType.VarChar).Value = pUsuarios.clave
            cmdSocio.Parameters.Add("@Administrador", OleDbType.Boolean).Value = pUsuarios.administrador
            cmdSocio.Parameters.Add("@Contador", OleDbType.Boolean).Value = pUsuarios.contador
            cmdSocio.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuarios.login
            cmdSocio.ExecuteNonQuery()
            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarUsuarios(ByVal pUsuarios As UsuariosEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM Usuarios Login =@ Login"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Login", OleDbType.VarWChar).Value = pUsuarios.login




            cmdSocio.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerUsuariosPorLogin(ByVal pLogin As String) As UsuariosEN
        Try

            Dim strBuscar As String = "SELECT Login,NombreCompleto,Clave,Administrador,Contador FROM Usuarios WHERE Login=@Login"
            miConexion.Open()
            Dim cmdUsuario As New OleDbCommand(strBuscar, miConexion)
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pLogin

            Dim myUsuario As UsuariosEN = Nothing

            Dim drUsuario As OleDbDataReader = cmdUsuario.ExecuteReader
            While (drUsuario.Read())
                myUsuario = New UsuariosEN
                myUsuario.Login = drUsuario("Login")
                myUsuario.nombreCompleto = drUsuario("NombreCompleto")
                myUsuario.Clave = drUsuario("Clave")
                myUsuario.administrador = drUsuario("Administrador")
                myUsuario.Contador = drUsuario("Contador")
            End While
            drUsuario.Close()
            miConexion.Close()
            Return myUsuario


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosUsuarioss() As List(Of UsuariosEN)
        Try

            miConexion.Open()

            Dim strSelect As String
            strSelect = "SELECT SELECT Login,NombreCompleto,Clave,Administrador,Contador FROM Usuarios  "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            Dim lstSocios As New List(Of UsuariosEN)
            Dim druser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (druser.Read())
                Dim myUser = New UsuariosEN
                myUser.login = druser("Login")
                myUser.nombreCompleto = druser("NombreCompleto")
                myUser.clave = druser("Clave")
                myUser.administrador = druser("Administrador")
                myUser.contador = druser("Contador")


                lstSocios.Add(myUser)
            End While
            druser.Close()
            miConexion.Close()
            Return lstSocios
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function






End Class
