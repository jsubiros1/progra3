

Imports _1AccesoADatos
Imports _3Entidades
Public Class CategoriaActivoLN


#Region "Constructor"
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
#End Region

#Region "Funciones"

    ''' <summary>
    ''' Insertar nueva categoria activo
    ''' </summary>
    ''' <param name="pCategoria">Objeto CategoriaActivo</param>
    ''' 
    Public Sub InsertarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try
            Try
                If (pCategoria.cod_categoria.Trim().Length = 0) Then
                    Throw New Exception("El codigo de categoria es obligatorio")
                End If

                Dim catAct As New CategoriaActivoAD

                If Not IsNothing(catAct.ObtenerCategoriaActivoPorCod(pCategoria.Cod_Categoria)) Then
                    Throw New Exception("Este Categoria Activo ya existe")
                End If

                catAct.InsertarCategoriaActivo(pCategoria)


            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Modificar una categoria activo
    ''' </summary>
    ''' <param name="pCategoria">Objeto categoriaActivo</param>

    Public Sub ModificarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try

            If (pCategoria.Cod_Categoria.Trim().Length = 0) Then
                Throw New Exception("El codigo de categoria es obligatorio")
            End If

            Dim catAct As New CategoriaActivoAD

            If IsNothing(catAct.ObtenerCategoriaActivoPorCod(pCategoria.Cod_Categoria)) Then
                Throw New Exception("Esta categoria activo no existe")
            End If

            catAct.ModificarCategoriaActivo(pCategoria)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Borrar categoria activo
    ''' </summary>
    ''' <param name="pCategoria">Objeto categoriaActivo</param>

    Public Sub BorrarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try

            Dim catAct As New CategoriaActivoAD

            If IsNothing(catAct.ObtenerCategoriaActivoPorCod(pCategoria.Cod_Categoria)) Then
                Throw New Exception("Esta categoia activo no existe")
            End If

            catAct.BorrarCategoriaActivo(pCategoria)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Obtener categoria por codigo
    ''' </summary>
    ''' <param name="pCodCateg">Codigo de categoria</param>
    ''' <returns></returns>

    Public Function ObtenerCategoriaPorCod(ByVal pCodCateg As String) As CategoriaActivoEN
        Try

            If (pCodCateg.Trim().Length = 0) Then
                Throw New Exception("El codigo de categoria es obligatorio")
            End If

            Dim catAct As New CategoriaActivoAD

            Return catAct.ObtenerCategoriaActivoPorCod(pCodCateg)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    ''' <summary>
    ''' Obtener toda las categorias
    ''' </summary>
    ''' <returns>Lista de bbjetos de categoriaActivo</returns>

    Public Function obtenerTodasCategoria() As List(Of CategoriaActivoEN)
        Try
            Dim catAct As New CategoriaActivoAD
            Return catAct.obtenerTodosCategoriaActivos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region


End Class
