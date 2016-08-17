Imports System.Data.OleDb
Imports _3Entidades

Public Class AsignacionActivosAD
#Region "Variable para la conexion a base de datos"
    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Facturacion.accdb")
#End Region

#Region "Constructor"
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
#End Region

#Region "Funciones"

    ''' <summary>
    ''' Insertar nueva asignacion de activos
    ''' </summary>
    ''' <param name="pAsignacionActivos">Objerto asignacion de activos</param>

    Public Sub InsertarAsignacionActivos(ByVal pAsignacionActivos As AsignacionActivosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "INSERT INTO AsignacionActivos(Cod_Asignacion, Cedula, Cod_Activo, Fec_Asignacion, Observaciones, Usuario_Asigno) 
                        VALUES(@codAsig, @ced, @codActivo, @fecha, @observaiones, @usrAsigno)"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@codAsig", OleDbType.VarChar).Value = pAsignacionActivos.Cod_Asignacion
            cmdInsert.Parameters.Add("@ced", OleDbType.VarChar).Value = pAsignacionActivos.Cedula
            cmdInsert.Parameters.Add("@codActivo", OleDbType.Date).Value = pAsignacionActivos.Cod_Activo
            cmdInsert.Parameters.Add("@fecha", OleDbType.Date).Value = pAsignacionActivos.Fec_Asignacion
            cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pAsignacionActivos.Observaciones
            cmdInsert.Parameters.Add("@userAsigno", OleDbType.Date).Value = pAsignacionActivos.Usuario_Asigno

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
    ''' Modificar asignacion de activos
    ''' </summary>
    ''' <param name="pAsignacionActivos">Objeto AsignacionActivos</param>

    Public Sub ModificarAsignacionActivos(ByVal pAsignacionActivos As AsignacionActivosEN)
        Try
            Dim strInsert As String
            miConexion.Open()

            strInsert = "UPDATE AsignacionActivos SET(Cedula = @ced, Cod_Activo = @codAct, Fec_Asignacion = @fecha, Observaciones = @observaciones, Usuario_Asigno = @usuarioAsigno) 
                        WHERE Cod_Asigancion = @codAsign"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@ced", OleDbType.VarChar).Value = pAsignacionActivos.Cedula
            cmdInsert.Parameters.Add("@codAct", OleDbType.VarChar).Value = pAsignacionActivos.Cod_Activo
            cmdInsert.Parameters.Add("@fecha", OleDbType.VarChar).Value = pAsignacionActivos.Fec_Asignacion
            cmdInsert.Parameters.Add("@observaciones", OleDbType.VarChar).Value = pAsignacionActivos.Observaciones
            cmdInsert.Parameters.Add("@usuarioAsigno", OleDbType.VarChar).Value = pAsignacionActivos.Usuario_Asigno
            cmdInsert.Parameters.Add("@codAsign", OleDbType.VarChar).Value = pAsignacionActivos.Cod_Asignacion

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
    ''' Borrar asignacion de activos
    ''' </summary>
    ''' <param name="pAsignacionActivos">Objerto asignacion de activos</param>

    Public Sub BorrarAsignacionActivos(ByVal pAsignacionActivos As AsignacionActivosEN)
        Try
            Dim strInsert As String
            miConexion.Open()

            strInsert = "DELETE * FROM AsignacionActivo 
                        WHERE Cod_Asignacion = @cod"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pAsignacionActivos.Cod_Asignacion

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
    ''' Obtener una asignacion de activo por codigo
    ''' </summary>
    ''' <param name="pCod">Codigo de la asignacion del activo</param>
    ''' <returns>Objerto AsignacionActivos</returns>

    Public Function ObtenerAsignacionActivosPorCod(ByVal pCod As String) As AsignacionActivosEN

        Dim asignacionActivo As New AsignacionActivosEN

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM AsignacionActivos 
                        WHERE Cod_Asignacion = @cod"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            cmdSelect.Parameters.Add("@cod", OleDbType.VarChar).Value = pCod

            Dim drAsignActiv As OleDbDataReader = cmdSelect.ExecuteReader
            While (drAsignActiv.Read())

                asignacionActivo.Cod_Asignacion = drAsignActiv("Cod_Asignacion")
                asignacionActivo.Cedula = drAsignActiv("Cedula")
                asignacionActivo.Cod_Activo = drAsignActiv("Cod_Activo")
                asignacionActivo.Fec_Asignacion = drAsignActiv("Fec_Asignacion")
                asignacionActivo.Observaciones = drAsignActiv("Observaciones")
                asignacionActivo.Usuario_Asigno = drAsignActiv("Usuario_Asigno")


            End While

            miConexion.Close()
            Return asignacionActivo


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function


    ''' <summary>
    ''' Obtener todas las asicnaciones de activos
    ''' </summary>
    ''' <returns>Lista de objetos AsignacionActivos</returns>

    Public Function obtenerTodosAsignacionActivos() As List(Of AsignacionActivosEN)

        Dim asignacionActiv As New List(Of AsignacionActivosEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM AsignacionActivos"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)
            Dim drAsignActiv As OleDbDataReader = cmdSelect.ExecuteReader

            While (drAsignActiv.Read())

                Dim aa As New AsignacionActivosEN

                aa.Cod_Asignacion = drAsignActiv("Cod_Asignacion")
                aa.Cedula = drAsignActiv("Cedula")
                aa.Cod_Activo = drAsignActiv("Cod_Activo")
                aa.Fec_Asignacion = drAsignActiv("Fec_Asignacion")
                aa.Observaciones = drAsignActiv("Observaciones")
                aa.Usuario_Asigno = drAsignActiv("Usuario_Asigno")

                asignacionActiv.Add(aa)

            End While

            miConexion.Close()
            Return asignacionActiv

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function

#End Region

End Class
