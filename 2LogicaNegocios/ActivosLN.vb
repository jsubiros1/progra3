Imports _3Entidades
Imports _1AccesoADatos

Public Class ActivosLN


    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarActivo(ByVal pActivo As ActivosEN)
        Try
            If (pActivo.Cod_Activo.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If


            Dim socAcceso As New ActivosAD

            If Not IsNothing(socAcceso.ObtenerActivoPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            socAcceso.InsertarActivo(pActivo)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarActivo(ByVal pActivo As ActivosEN)
        Try

            If (pActivo.Cod_Activo.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New ActivosAD

            If IsNothing(userAcceso.ObtenerActivoPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarActivo(pActivo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarActivo(ByVal pActivo As ActivosEN)
        Try


            Dim SocAcceso As New ActivosAD


            If IsNothing(SocAcceso.ObtenerActivoPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Ese Activo  no existe")
            End If

            SocAcceso.BorrarActivo(pActivo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerActivoPorCod(ByVal pCod As String) As ActivosEN
        Try

            If (pCod.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim userAcceso As New ActivosAD
            Return userAcceso.ObtenerActivoPorCod(pCod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosActivos() As List(Of ActivosEN)
        Try
            Dim SocAcceso As New ActivosAD
            Return SocAcceso.obtenerTodosActivos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
