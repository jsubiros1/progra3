
Imports System.Data.OleDb
Imports _3Entidades



Public Class AsignacionActivosAD

    Dim miConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProyectoDB.accdb")
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try

            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO AsignacionesActivo(Cod_Asignacion,Cod_Activo,Cedula,Fec_Asignacion,Observaciones,Usuario_Asigno) values(@Cod_Asignacion,@Cod_Activo,@Cedula,@Fec_Asignacion,@Observaciones,@Usuario_Asigno)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Cod_Asignacion", OleDbType.VarChar).Value = pAsignacion.Cod_Asignacion
            cmdSocio.Parameters.Add("@Cod_Activo", OleDbType.VarChar).Value = pAsignacion.Cod_Activo
            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pAsignacion.Cedula
            cmdSocio.Parameters.Add("@Fec_Asignacion", OleDbType.Date).Value = pAsignacion.Fec_Asignacion
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.Boolean).Value = pAsignacion.Observaciones
            cmdSocio.Parameters.Add("@Usuario_Asigno", OleDbType.Boolean).Value = pAsignacion.Usuario_Asigno

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

    Public Sub ModificarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  AsignacionesActivo SET @Cod_Activo,@Cedula,@Fec_Asignacion,@Observaciones,@Usuario_Asigno WHERE Cod_Asignacion=@Cod_Asignacion"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)

            cmdSocio.Parameters.Add("@Cod_Activo", OleDbType.VarChar).Value = pAsignacion.Cod_Activo
            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pAsignacion.Cedula
            cmdSocio.Parameters.Add("@Fec_Asignacion", OleDbType.Boolean).Value = pAsignacion.Fec_Asignacion
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.Boolean).Value = pAsignacion.Observaciones
            cmdSocio.Parameters.Add("@Usuario_Asigno", OleDbType.VarChar).Value = pAsignacion.Usuario_Asigno
            cmdSocio.Parameters.Add("@Cod_Asignacion", OleDbType.VarChar).Value = pAsignacion.Cod_Asignacion
            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM AsignacionesActivo Cod_Asignacion =@Cod_Asignacion"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Cod_Asignacion", OleDbType.VarWChar).Value = pAsignacion.Cod_Asignacion




            cmdSocio.ExecuteNonQuery()


            miConexion.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerAsignacionPorCodAsig(ByVal pCod As String) As AsignacionActivosEN
        Try

            miConexion.Open()
            Dim strSelect As String
            strSelect = "SELECT Cod_Asignacion,Cod_Activo,Cedula,Fec_Asignacion,Observaciones,Usuario_Asigno FROM AsignacionesActivo WHERE Cod_Asignacion=@Cod_Asignacion"
            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            cmdSocio.Parameters.Add("@Cod_Asignacion", OleDbType.VarChar).Value = pCod

            Dim myUser As AsignacionActivosEN = Nothing
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()

            While (drUser.Read())
                myUser = New AsignacionActivosEN
                myUser.Cod_Asignacion = drUser("Cod_Asignacion")
                myUser.Cod_Activo = drUser("Cod_Activo")
                myUser.Cedula = drUser("Cedula")
                myUser.Fec_Asignacion = drUser("Fec_Asignacion")
                myUser.Observaciones = drUser("Observaciones")
                myUser.Usuario_Asigno = drUser("Usuario_Asigno")


            End While
            drUser.Close()
            miConexion.Close()
            Return myUser


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosAsignacion() As List(Of AsignacionActivosEN)
        Try
            miConexion.Open()

            Dim strSelect As String
            strSelect = "SELECT Cod_Asignacion,Cod_Activo,Cedula,Fec_Asignacion,Observaciones,Usuario_Asigno FROM AsignacionesActivo  "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)


            Dim lstSocios As New List(Of AsignacionActivosEN)
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (drUser.Read())
                Dim myUser As New AsignacionActivosEN
                myUser.cod_asignacion = drUser("Cod_Asignacion")
                myUser.Cod_Activo = drUser("Cod_Activo")
                myUser.cedula = drUser("Cedula")
                myUser.fec_Asignacion = drUser("Fec_Asignacion")
                myUser.Observaciones = drUser("Observaciones")
                myUser.Usuario_Asigno = drUser("Usuario_Asigno")

                lstSocios.Add(myUser)
            End While
            drUser.Close()
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
