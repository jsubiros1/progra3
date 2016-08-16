Imports System.Data.OleDb
Imports _3Entidades

Public Class CategoriaActivoAD
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
    ''' Insertar una nueva categoria de activos
    ''' </summary>
    ''' <param name="pCategoriaActivo">Objerto CategoriaActivo</param>

    Public Sub InsertarCategoriaActivo(ByVal pCategoriaActivo As CategoriaActivoEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "INSERT INTO CategoriaActivo(Cod_Categoria, Descripcion, Observaciones) 
                        VALUES(@cod, @descrip, @observaciones)"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pCategoriaActivo.Cod_Categoria
            cmdInsert.Parameters.Add("@descrip", OleDbType.VarChar).Value = pCategoriaActivo.Descripcion
            cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pCategoriaActivo.Observaciones

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
    ''' Modificar CategoriaActivo
    ''' </summary>
    ''' <param name="pCategoriaActivo">Objeto CategoriaActivo</param>

    Public Sub ModificarCategoriaActivo(ByVal pCategoriaActivo As CategoriaActivoEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "UPDATE CategoriaActivo SET(Descripcion = @descrip, Observaciones = @observaciones) 
                        WHERE Cod_Categoria = @cod"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pCategoriaActivo.Cod_Categoria
            cmdInsert.Parameters.Add("@descrip", OleDbType.VarChar).Value = pCategoriaActivo.Descripcion
            cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pCategoriaActivo.Observaciones

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
    ''' Borrar CategoriaActivo
    ''' </summary>
    ''' <param name="pCategoriaActivo">Objeto CategoriaActivo</param>

    Public Sub BorrarCategoriaActivo(ByVal pCategoriaActivo As CategoriaActivoEN)
        Try

            Dim strInsert As String
            miConexion.Open()

            strInsert = "DELETE * FROM CategoriaActivo 
                        WHERE Cod_Categoria = @cod"

            Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

            cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pCategoriaActivo.Cod_Categoria

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
    ''' Obtener una CategoriaActivo por codigo
    ''' </summary>
    ''' <param name="pCod">Codigo de CategoriaActivo</param>
    ''' <returns></returns>

    Public Function ObtenerCategoriaActivoPorCod(ByVal pCod As String) As CategoriaActivoEN

        Dim categoriaActivo As New CategoriaActivoEN

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM CategoriaAcivo 
                        WHERE Cod_Categoria = @cod"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

            cmdSelect.Parameters.Add("@cod", OleDbType.VarChar).Value = pCod

            Dim drCat As OleDbDataReader = cmdSelect.ExecuteReader
            While (drCat.Read())

                categoriaActivo.Cod_Categoria = drCat("Cod_Categoria")
                categoriaActivo.Descripcion = drCat("Descripcion")
                categoriaActivo.Observaciones = drCat("Observaciones")

            End While

            miConexion.Close()
            Return categoriaActivo

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function


    ''' <summary>
    ''' Obtener todas las CategoriasActivos
    ''' </summary>
    ''' <returns>Lista de objetos CategoriaActivos</returns>

    Public Function obtenerTodosCategoriaActivos() As List(Of CategoriaActivoEN)

        Dim CategoriaActivo As New List(Of CategoriaActivoEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM CategoriaActivo"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)
            Dim drCats As OleDbDataReader = cmdSelect.ExecuteReader

            While (drCats.Read())

                Dim ca As New CategoriaActivoEN

                ca.Cod_Categoria = drCats("Cod_Categoria")
                ca.Descripcion = drCats("Descripcion")
                ca.Observaciones = drCats("Observaciones")

                CategoriaActivo.Add(ca)

            End While

            miConexion.Close()
            Return CategoriaActivo


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function

#End Region
End Class
