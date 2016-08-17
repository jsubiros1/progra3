Imports System.Data.OleDb
Imports _3Entidades


Public Class DepartamentosAD

    Dim miConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProyectoDB.accdb")
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Departamentos(Cod_Departamento,Nombre,Observaciones) values(@Cod_Departamento,@Nombre,@Observaciones)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Cod_Departamento", OleDbType.VarChar).Value = pDepartamento.Cod_Dept
            cmdSocio.Parameters.Add("@Nombre", OleDbType.VarChar).Value = pDepartamento.Nombre
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pDepartamento.Observaciones


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

    Public Sub ModificarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  Departamentos SET @Nombre,@Observaciones WHERE Cod_Departamento=@Cod_Departamento"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)


            cmdSocio.Parameters.Add("@Nombre", OleDbType.VarChar).Value = pDepartamento.Nombre
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pDepartamento.Observaciones
            cmdSocio.Parameters.Add("@Cod_Departamento", OleDbType.VarChar).Value = pDepartamento.Cod_Dept

            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM Departamentos Cod_Departamento = @Cod_Departamento"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Cod_Departamento", OleDbType.VarWChar).Value = pDepartamento.Cod_Dept




            cmdSocio.ExecuteNonQuery()


            miConexion.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerSocioPorCodDepartamento(ByVal pCod As String) As DepartamentosEN
        Try

            miConexion.Open()
            Dim strSelect As String
            strSelect = "SELECT Cod_Departamento,Nombre,Observaciones FROM Departamentos WHERE Cod_Departamento=@Cod_Departamento"
            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            cmdSocio.Parameters.Add("@Cod_Departamento", OleDbType.VarChar).Value = pCod

            Dim myUser As DepartamentosEN = Nothing
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()

            While (drUser.Read())
                myUser = New DepartamentosEN
                myUser.Cod_Dept = drUser("Cod_Departamento")
                myUser.Nombre = drUser("Nombre")
                myUser.Observaciones = drUser("Observaciones")



            End While
            drUser.Close()
            miConexion.Close()
            Return myUser


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosDepartamentos() As List(Of DepartamentosEN)
        Try
            miConexion.Open()

            Dim strSelect As String
            strSelect = "SELECT Cod_Departamento,Nombre,Observaciones FROM Departamentos  "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)


            Dim lstSocios As New List(Of DepartamentosEN)
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (drUser.Read())
                Dim myUser As New DepartamentosEN

                myUser.Cod_Dept = drUser("Cod_Departamento")
                myUser.Nombre = drUser("Nombre")
                myUser.Observaciones = drUser("Observaciones")


                lstSocios.Add(myUser) 'nuevo,sellena la lista 
            End While
            drUser.Close()
            miConexion.Close()
            Return lstSocios 'se retorna la lista 
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
