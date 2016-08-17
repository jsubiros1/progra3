Imports System.Data.OleDb
Imports _3Entidades




Public Class EmpleadosAD

    Dim miConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProyectoDB.accdb")
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Empleados(Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_mail,Cod_Depto,Dir_Completa) values(@Cedula,@NombreCompleto,@Tel_Celular,@Tel_Casa,@Fec_Nacimiento,@E_mail,@Cod_Depto,@Dir_Completa)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdSocio.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdSocio.Parameters.Add("@Tel_Celular", OleDbType.VarChar).Value = pEmpleado.Tel_Celular
            cmdSocio.Parameters.Add("@Tel_Casa", OleDbType.VarChar).Value = pEmpleado.Tel_Casa
            cmdSocio.Parameters.Add("@Fec_Nacimiento", OleDbType.Date).Value = pEmpleado.Fec_Nacimiento
            cmdSocio.Parameters.Add("@E_mail", OleDbType.VarChar).Value = pEmpleado.E_Mail
            cmdSocio.Parameters.Add("@Cod_Depto", OleDbType.VarChar).Value = pEmpleado.Cod_Dept
            cmdSocio.Parameters.Add("@Dir_Completa", OleDbType.VarChar).Value = pEmpleado.Dir_Completa


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

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  Empleados SET @NombreCompleto,@Tel_Celular,@Tel_Casa,@Fec_Nacimiento,@E_mail,@Cod_Depto,@Dir_Completa WHERE Cedula=@Cedula"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)

            cmdSocio.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdSocio.Parameters.Add("@Tel_Celular", OleDbType.VarChar).Value = pEmpleado.Tel_Celular
            cmdSocio.Parameters.Add("@Tel_Casa", OleDbType.VarChar).Value = pEmpleado.Tel_Casa
            cmdSocio.Parameters.Add("@Fec_Nacimiento", OleDbType.Date).Value = pEmpleado.Fec_Nacimiento
            cmdSocio.Parameters.Add("@E_mail", OleDbType.VarChar).Value = pEmpleado.E_Mail
            cmdSocio.Parameters.Add("@Cod_Depto", OleDbType.VarChar).Value = pEmpleado.Cod_Dept
            cmdSocio.Parameters.Add("@Dir_Completa", OleDbType.VarChar).Value = pEmpleado.Dir_Completa


            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM Empleados CEDULA =@ CEDULA"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarWChar).Value = pEmpleado.Cedula




            cmdSocio.ExecuteNonQuery()


            miConexion.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadosPorCedula(ByVal pCedula As String) As EmpleadosEN
        Try

            miConexion.Open()
            Dim strSelect As String
            strSelect = "SELECT Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_mail,Cod_Depto,Dir_Completa FROM Empleados WHERE Cedula=@Cedula"
            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCedula

            Dim myUser As EmpleadosEN = Nothing
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()

            While (drUser.Read())
                myUser = New EmpleadosEN
                myUser.Cedula = drUser("Cedula")
                myUser.NombreCompleto = drUser("NombreCompleto")
                myUser.Tel_Celular = drUser("Tel_Celular")
                myUser.Tel_Casa = drUser("Tel_Casa")
                myUser.Fec_Nacimiento = drUser("Fec_Nacimiento")
                myUser.E_Mail = drUser("E_mail")
                myUser.Cod_Dept = drUser("Cod_Depto")
                myUser.Dir_Completa = drUser("Dir_Completa")



            End While
            drUser.Close()
            miConexion.Close()
            Return myUser


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadosEN)
        Try
            miConexion.Open()

            Dim strSelect As String
            strSelect = " SELECT Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_mail,Cod_Depto,Dir_Completa FROM Empleados  "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)


            Dim lstSocios As New List(Of EmpleadosEN)
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (drUser.Read())
                Dim myUser As New EmpleadosEN

                myUser.Cedula = drUser("Cedula")
                myUser.NombreCompleto = drUser("NombreCompleto")
                myUser.tel_Celular = drUser("Tel_Celular")
                myUser.tel_Casa = drUser("Tel_Casa")
                myUser.fec_Nacimiento = drUser("Fec_Nacimiento")
                myUser.E_Mail = drUser("E_mail")
                myUser.Cod_Dept = drUser("Cod_Depto")
                myUser.dir_completa = drUser("Dir_Completa")

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
