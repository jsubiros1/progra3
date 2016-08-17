Imports System.Data.OleDb

Imports _3Entidades

Public Class CategoriaActivoAD


    Dim miConexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProyectoDB.accdb")
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try

            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Categoria(Cod_Categoria,Descripcion,Observaciones) values(@Cod_Categoria,@Descripcion,@Observaciones)"


            Dim cmdSocio As New OleDbCommand(strInsert, miConexion)
            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarChar).Value = pCategoria.Cod_Categoria
            cmdSocio.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pCategoria.Descripcion
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pCategoria.Observaciones


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

    Public Sub ModificarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try

            miConexion.Open()
            Dim strModificar As String

            ''llave primaria no se cambia 
            ''la llame va en where
            strModificar = "UPDATE  Categoria SET Descripcion,Observaciones WHERE Cod_Categoria=@Cod_Categoria"

            ''Los parametros tiene q ir en orden de la sentencia 
            Dim cmdSocio As New OleDbCommand(strModificar, miConexion)

            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarChar).Value = pCategoria.Cod_Categoria
            cmdSocio.Parameters.Add("@Descripcion", OleDbType.VarChar).Value = pCategoria.Descripcion
            cmdSocio.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pCategoria.Observaciones

            cmdSocio.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try
            miConexion.Open()
            Dim strborrar As String
            strborrar = "DELETE FROM Categoria Cod_Categoria =@ Cod_Categoria"
            Dim cmdSocio As New OleDbCommand(strborrar, miConexion)

            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarWChar).Value = pCategoria.Cod_Categoria




            cmdSocio.ExecuteNonQuery()


            miConexion.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerCategoriaPorCod(ByVal pCodCateg As String) As CategoriaActivoEN
        Try

            miConexion.Open()
            Dim strSelect As String
            strSelect = "SELECT Cod_Categoria,Descripcion,Observaciones FROM Categoria WHERE Cod_Categoria=@Cod_Categoria"
            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)

            cmdSocio.Parameters.Add("@Cod_Categoria", OleDbType.VarChar).Value = pCodCateg

            Dim myUser As CategoriaActivoEN = Nothing
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()

            While (drUser.Read())
                myUser = New CategoriaActivoEN
                myUser.Cod_Categoria = drUser("Cod_Categoria")
                myUser.Descripcion = drUser("Descripcion")
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

    Public Function obtenerTodasCategoria() As List(Of CategoriaActivoEN)
        Try
            miConexion.Open()

            Dim strSelect As String
            strSelect = "SELECT Cod_Categoria,Descripcion,Observaciones FROM Categoria  "

            Dim cmdSocio As New OleDbCommand(strSelect, miConexion)


            Dim lstSocios As New List(Of CategoriaActivoEN)
            Dim drUser As OleDbDataReader = cmdSocio.ExecuteReader()
            While (drUser.Read())
                Dim myUser As New CategoriaActivoEN
                myUser.cod_categoria = drUser("Cod_Categoria")
                myUser.descripcion = drUser("Descripcion")
                myUser.observaciones = drUser("Observaciones")
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
