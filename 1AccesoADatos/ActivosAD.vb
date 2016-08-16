Imports System.Data.OleDb
Imports _3Entidades

Public Class ActivosAD

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
    ''' Insertar un activo
    ''' </summary>
    ''' <param name="pActivos">Objero Activos</param>

    Public Sub InsertarActivos(ByVal pActivos As ActivosEN)
            Try

                Dim strInsert As String
                miConexion.Open()

                strInsert = "INSERT INTO Activos(Cod_Activo, Descripcion, Cod_Categoria, Fec_Compra, Costo, Observaciones) 
                        VALUES(@codActivo, @descrip, @codCat, @fechaCompra, @costo, @observaciones)"

                Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

                cmdInsert.Parameters.Add("@codActivo", OleDbType.VarChar).Value = pActivos.Cod_Activo
                cmdInsert.Parameters.Add("@descrip", OleDbType.VarChar).Value = pActivos.Descripcion
                cmdInsert.Parameters.Add("@codCat", OleDbType.Date).Value = pActivos.Cod_Categoria
                cmdInsert.Parameters.Add("@fechaCompra", OleDbType.Date).Value = pActivos.Fec_Compra
                cmdInsert.Parameters.Add("@costo", OleDbType.Date).Value = pActivos.Costo
                cmdInsert.Parameters.Add("@observaciones", OleDbType.Date).Value = pActivos.Observaciones

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
    ''' Modificar un activo
    ''' </summary>
    ''' <param name="pActivos">Objeto activo</param>

    Public Sub ModificarActivos(ByVal pActivos As ActivosEN)
            Try

                Dim strInsert As String
                miConexion.Open()

                strInsert = "UPDATE Activos 
                             SET(Descripcion = @descrip, Cod_Categoria = @codCat, Fec_Compra = @fechaCompra, Costo = @costo, Observaciones = @observaciones) 
                             WHERE Cod_Activo = @codActivo"

                Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

                cmdInsert.Parameters.Add("@descrip", OleDbType.VarChar).Value = pActivos.Descripcion
                cmdInsert.Parameters.Add("@codCat", OleDbType.VarChar).Value = pActivos.Cod_Categoria
                cmdInsert.Parameters.Add("@fechaCompra", OleDbType.VarChar).Value = pActivos.Fec_Compra
                cmdInsert.Parameters.Add("@costo", OleDbType.VarChar).Value = pActivos.Costo
                cmdInsert.Parameters.Add("@observaciones", OleDbType.VarChar).Value = pActivos.Observaciones
                cmdInsert.Parameters.Add("@codActivo", OleDbType.VarChar).Value = pActivos.Cod_Activo

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
    ''' Borrar un activo
    ''' </summary>
    ''' <param name="pActivos">Objeto Activos</param>

    Public Sub BorrarActivos(ByVal pActivos As ActivosEN)
            Try
                Dim strInsert As String
                miConexion.Open()

                strInsert = "DELETE * FROM Activos
                        WHERE Cod_Activo = @cod"

                Dim cmdInsert As New OleDbCommand(strInsert, miConexion)

                cmdInsert.Parameters.Add("@cod", OleDbType.VarChar).Value = pActivos.Cod_Activo

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
    ''' Obtener un activo segun codigo
    ''' </summary>
    ''' <param name="pCod">Codigo del activo</param>
    ''' <returns>Objeto Activos</returns>

    Public Function ObtenerActivosPorCod(ByVal pCod As String) As ActivosEN

            Dim activo As New ActivosEN

            Try

                Dim strSelect As String
                miConexion.Open()

                strSelect = "SELECT * FROM Activos 
                        WHERE Cod_Asignacion = @cod"

                Dim cmdSelect As New OleDbCommand(strSelect, miConexion)

                cmdSelect.Parameters.Add("@cod", OleDbType.VarChar).Value = pCod

                Dim drActivo As OleDbDataReader = cmdSelect.ExecuteReader
                While (drActivo.Read())

                    activo.Cod_Activo = drActivo("Cod_Activo")
                    activo.Descripcion = drActivo("Descripcion")
                    activo.Cod_Categoria = drActivo("Cod_Categoria")
                    activo.Fec_Compra = drActivo("Fec_Compra")
                    activo.Costo = drActivo("Costo")
                    activo.Observaciones = drActivo("Observaciones")

                End While

                miConexion.Close()
                Return activo


            Catch ex As Exception
                If (miConexion.State = ConnectionState.Open) Then
                    miConexion.Close()
                End If
                Throw New Exception(ex.Message)

            End Try
        End Function


    ''' <summary>
    ''' Obtener todos los activos
    ''' </summary>
    ''' <returns>Lista de objetos Activos</returns>

    Public Function obtenerTodosActivos() As List(Of ActivosEN)

        Dim activos As New List(Of ActivosEN)

        Try

            Dim strSelect As String
            miConexion.Open()

            strSelect = "SELECT * FROM AsignacionActivos"

            Dim cmdSelect As New OleDbCommand(strSelect, miConexion)
            Dim drActivo As OleDbDataReader = cmdSelect.ExecuteReader

            While (drActivo.Read())

                Dim act As New ActivosEN

                act.Cod_Activo = drActivo("Cod_Activo")
                act.Descripcion = drActivo("Descripcion")
                act.Cod_Categoria = drActivo("Cod_Categoria")
                act.Fec_Compra = drActivo("Fec_Compra")
                act.Costo = drActivo("Costo")
                act.Observaciones = drActivo("Observaciones")

                activos.Add(act)

            End While

            miConexion.Close()
            Return activos

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)

        End Try
    End Function

#End Region

End Class