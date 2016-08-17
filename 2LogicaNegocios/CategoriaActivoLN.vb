

Imports _1AccesoADatos
Imports _3Entidades
Public Class CategoriaActivoLN



    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try
            Try
                If (pCategoria.cod_categoria.Trim().Length = 0) Then
                    Throw New Exception("El Login es obligatoria")

                End If


                Dim socAcceso As New CategoriaActivoAD

                If Not IsNothing(socAcceso.ObtenerCategoriaPorCod(pCategoria.Cod_Categoria)) Then
                    Throw New Exception("Ese Usuario ya Existe")

                End If

                socAcceso.InsertarCategoria(pCategoria)


            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try

            If (pCategoria.Cod_Categoria.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New CategoriaActivoAD

            If IsNothing(userAcceso.ObtenerCategoriaPorCod(pCategoria.Cod_Categoria)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarCategoria(pCategoria)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarCategoria(ByVal pCategoria As CategoriaActivoEN)
        Try


            Dim SocAcceso As New CategoriaActivoAD


            If IsNothing(SocAcceso.ObtenerCategoriaPorCod(pCategoria.Cod_Categoria)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            SocAcceso.BorrarCategoria(pCategoria)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerCategoriaPorCod(ByVal pCodCateg As String) As CategoriaActivoEN
        Try

            If (pCodCateg.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim userAcceso As New CategoriaActivoAD
            Return userAcceso.ObtenerCategoriaPorCod(pCodCateg)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodasCategoria() As List(Of CategoriaActivoEN)
        Try
            Dim SocAcceso As New CategoriaActivoAD
            Return SocAcceso.obtenerTodasCategoria
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function




End Class
