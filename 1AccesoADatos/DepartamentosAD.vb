Imports System.Data.OleDb
Imports _3Entidades

Public Class DepartamentosAD
#Region "Variable para conexion a base de datos"
    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Facturacion.accdb")
#End Region

#Region "Constructores"
    Public Sub New()
            ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
        End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Insertar un nuevo departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>

    Public Sub InsertarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "INSERT INTO Departamentos(Cod_dept, Nombre, Observaciones) 
                        VALUES(@cod, @nombre, @observaciones)"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pDepartamento.Cod_Dept
            cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar).Value = pDepartamento.Nombre
            cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pDepartamento.Observaciones

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
    ''' Modificar un departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>

    Public Sub ModificarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "UPDATE Departamentos SET(Nombre = @nombre, Observaciones = @observaciones) 
                        WHERE Cod_dept = @cod"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pDepartamento.Cod_Dept
            cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar).Value = pDepartamento.Nombre
            cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pDepartamento.Observaciones

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
    ''' Borrar un departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>


    Public Sub BorrarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "DELETE * FROM Departamentos 
                        WHERE Cod_dept = @cod"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pDepartamento.Cod_Dept

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
    ''' Obtener un departamento por codigo
    ''' </summary>
    ''' <param name="pCod">Codigo del departamento</param>
    ''' <returns>Objeto departamento</returns>

    Public Function ObtenerDepartamentoPorCod(ByVal pCod As String) As DepartamentosEN
        Dim dept As New DepartamentosEN

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Departamentos 
                        WHERE Cod_dept = @cod"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            cmdSelect.Parameters.Add("@cod", OleDbType.VarChar).Value = pCod

            Dim drDept As OleDbDataReader = cmdSelect.ExecuteReader
            While (drDept.Read())

                dept.Cod_Dept = drDept("Cod_dept")
                dept.Nombre = drDept("Nombre")
                dept.Cod_Dept = drDept("Observaciones")

            End While

            miConexion.Close()
            Return dept

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function


    ''' <summary>
    ''' Obtener todos los departamentos
    ''' </summary>
    ''' <returns>Lista de objetos departamentos</returns>

    Public Function obtenerTodosDepartamentos() As List(Of DepartamentosEN)
        Dim departamentos As New List(Of DepartamentosEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM Departamentos"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)
            Dim drDepts As OleDbDataReader = cmdSelect.ExecuteReader

            While (drDepts.Read())

                Dim d As New DepartamentosEN

                d.Cod_Dept = drDepts("Cod_dept")
                d.Nombre = drDepts("Nombre")
                d.Observaciones = drDepts("Observaciones")

                departamentos.Add(d)

            End While

            miConexion.Close()
            Return departamentos

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function

#End Region

End Class
