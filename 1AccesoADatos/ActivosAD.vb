Imports System.Data.OleDb
Imports _3Entidades




Public Class ActivosAD

    Dim miConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProyectoDB.accdb")
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarActivo(ByVal pActivo As ActivosEN)
        Try

            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Activos(Cod_Activo,Descripcion,Cod_Categoria,Fec_Compra,Costo,Observaciones) values(@Cod_Activo,@Descripcion,@Cod_Categoria,@Fec_Compra,@Costo,@Observaciones)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Cod_Activo", OleDbType.VarChar).Value = pActivo.Cod_Activo
            cmdSocio.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pActivo.Descripcion
            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarChar).Value = pActivo.Cod_Categoria
            cmdSocio.Parameters.Add("@Fec_Compra", OleDbType.Boolean).Value = pActivo.Fec_Compra
            cmdSocio.Parameters.Add("@Costo", OleDbType.Boolean).Value = pActivo.Costo
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.Boolean).Value = pActivo.Observaciones

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

    Public Sub ModificarActivo(ByVal pActivo As ActivosEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  Activos SET @Descripcion,@Cod_Categoria,@Fec_Compra,@Costo,@Observaciones WHERE @Cod_Activo=@Cod_Activo"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)

            cmdSocio.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pActivo.Descripcion
            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarChar).Value = pActivo.Cod_Categoria
            cmdSocio.Parameters.Add("@Fec_Compra", OleDbType.Boolean).Value = pActivo.Fec_Compra
            cmdSocio.Parameters.Add("@Costo", OleDbType.Boolean).Value = pActivo.Costo
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pActivo.Observaciones
            cmdSocio.Parameters.Add("@Cod_Activo", OleDbType.VarChar).Value = pActivo.Cod_Activo
            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarActivo(ByVal pActivo As ActivosEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM Activos Cod_Activo =@ Cod_Activo"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Cedula", OleDbType.VarWChar).Value = pActivo.Cod_Activo




            cmdSocio.ExecuteNonQuery()


            miConexion.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerActivoPorCod(ByVal pCod As String) As ActivosEN
        Try

            miConexion.Open()
            Dim strSelect As String
            strSelect = "SELECT Cod_Activo,Descripcion,Cod_Categoria,Fec_Compra,Costo,Observaciones FROM Activos WHERE Cod_Activo=@Cod_Activo"
            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            cmdSocio.Parameters.Add("@Cod_Activo", OleDbType.VarChar).Value = pCod

            Dim myUser As ActivosEN = Nothing
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()

            While (drUser.Read())
                myUser = New ActivosEN
                myUser.cod_Activo = drUser("Cod_Activo")
                myUser.Descripcion = drUser("Descripcion")
                myUser.Cod_Categoria = drUser("Cod_Categoria")
                myUser.fec_Compra = drUser("Fec_Compra")
                myUser.costo = drUser("Costo")
                myUser.observaciones = drUser("Observaciones")


            End While
            drUser.Close()
            miConexion.Close()
            Return myUser


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosActivos() As List(Of ActivosEN)
        Try
            miConexion.Open()

            Dim strSelect As String
            strSelect = "Cod_Activo,Descripcion,Cod_Categoria,Fec_Compra,Costo,Observaciones FROM Activos WHERE "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)


            Dim lstSocios As New List(Of ActivosEN)
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (drUser.Read())
                Dim myUser As New ActivosEN
                myUser.Cod_Activo = drUser("Cod_Activo")
                myUser.Descripcion = drUser("Descripcion")
                myUser.Cod_Categoria = drUser("Cod_Categoria")
                myUser.Fec_Compra = drUser("Fec_Compra")
                myUser.Costo = drUser("Costo")
                myUser.Observaciones = drUser("Observaciones")
                lstSocios.Add(myUser)
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
