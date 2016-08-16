Imports System.Data.OleDb
Imports _3Entidades

Public Class EmpleadosAD
#Region "Variable para conexion a base de datos"
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
    ''' Insertar un Empleado
    ''' </summary>
    ''' <param name="pEmpleado">Objeto Empleado</param>
    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "INSERT INTO Empleados(Cedula, NombreCompleto, Cod_Dept, Tel_Celular, Tel_Casa, Fec_Nacimiento, E_Mail, Dir_Completa) 
                        VALUES(@ced, @nombre, @codDept, @telCel, @telCasa, @fecNac, @email, @dirComp)"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@ced", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdInsert.Parameters.Add("@codDept", OleDbType.Date).Value = pEmpleado.Cod_Dept
            cmdInsert.Parameters.Add("@telCel", OleDbType.Integer).Value = pEmpleado.Tel_Celular
            cmdInsert.Parameters.Add("@telCasa", OleDbType.Double).Value = pEmpleado.Tel_Casa
            cmdInsert.Parameters.Add("@fecNac", OleDbType.Double).Value = pEmpleado.Fec_Nacimiento
            cmdInsert.Parameters.Add("@email", OleDbType.Double).Value = pEmpleado.E_Mail
            cmdInsert.Parameters.Add("@dirComp", OleDbType.Double).Value = pEmpleado.Dir_Completa

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
    ''' Modificar un Empleado
    ''' </summary>
    ''' <param name="pEmpleado">Objeto Empleado</param>

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "UPDATE Empleados SET(NombreCompleto = @nombre, Cod_Dept = @codDept, Tel_Celular = @telCel, Tel_Casa = @telCasa, Fec_Nacimiento = @fecNac, 
                        E_Mail = @email, Dir_Completa = @dirComp)
                        WHERE Cedula = @ced"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@ced", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdInsert.Parameters.Add("@codDept", OleDbType.Date).Value = pEmpleado.Cod_Dept
            cmdInsert.Parameters.Add("@telCel", OleDbType.Integer).Value = pEmpleado.Tel_Celular
            cmdInsert.Parameters.Add("@telCasa", OleDbType.Double).Value = pEmpleado.Tel_Casa
            cmdInsert.Parameters.Add("@fecNac", OleDbType.Double).Value = pEmpleado.Fec_Nacimiento
            cmdInsert.Parameters.Add("@email", OleDbType.Double).Value = pEmpleado.E_Mail
            cmdInsert.Parameters.Add("@dirComp", OleDbType.Double).Value = pEmpleado.Dir_Completa

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
    ''' Borrar un Empleado
    ''' </summary>
    ''' <param name="pEmpleado">Objeto Empleado</param>

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "DELETE FROM Empleados
                        WHERE Cedula = @ced"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@ced", OleDbType.VarChar).Value = pEmpleado.Cedula

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
    ''' Obtener un Empeado por Cedula
    ''' </summary>
    ''' <param name="pCedula">Cedula del Empleado</param>
    ''' <returns>Empleado seleccionado por cedula</returns>

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadosEN

        Dim empleado As New EmpleadosEN

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Empleados 
                        WHERE Cedula = @Cedula"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            cmdSelect.Parameters.Add("@ced", OleDbType.VarChar).Value = pCedula

            Dim drEmpleado As OleDbDataReader = cmdSelect.ExecuteReader
            While (drEmpleado.Read())


                empleado.Cedula = drEmpleado("Cedula")
                empleado.NombreCompleto = drEmpleado("NombreCompleto")
                empleado.Cod_Dept = drEmpleado("Cod_Dept")
                empleado.Tel_Celular = drEmpleado("Tel_Celular")
                empleado.Tel_Casa = drEmpleado("Tel_Casa")
                empleado.Fec_Nacimiento = drEmpleado("Fec_Nacimiento")
                empleado.E_Mail = drEmpleado("E_Mail")
                empleado.Dir_Completa = drEmpleado("Dir_Completa")

            End While

            miConexion.Close()
            Return empleado

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Obtener todos los empleados
    ''' </summary>
    ''' <returns>Lista de empleados</returns>

    Public Function obtenerTodosEmpleados() As List(Of EmpleadosEN)
        Dim empleados As New List(Of EmpleadosEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Empleados"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)
            Dim drEmpleado As OleDbDataReader = cmdSelect.ExecuteReader


            While (drEmpleado.Read())

                Dim e As New EmpleadosEN

                e.Cedula = drEmpleado("Cedula")
                e.NombreCompleto = drEmpleado("NombreCompleto")
                e.Cod_Dept = drEmpleado("Cod_Dept")
                e.Tel_Celular = drEmpleado("Tel_Celular")
                e.Tel_Casa = drEmpleado("Tel_Casa")
                e.Fec_Nacimiento = drEmpleado("Fec_Nacimiento")
                e.E_Mail = drEmpleado("E_Mail")
                e.Dir_Completa = drEmpleado("Dir_Completa")

                empleados.Add(e)

            End While

            miConexion.Close()
            Return empleados

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
