
Imports _1AccesoADatos
Imports _3Entidades
Public Class AsignacionActivosLN



    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try
            If (pAsignacion.Cod_Asignacion.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If


            Dim socAcceso As New AsignacionActivosAD

            If Not IsNothing(socAcceso.ObtenerAsignacionPorCodAsig(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            socAcceso.InsertarAsignacion(pAsignacion)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try

            If (pAsignacion.Cod_Asignacion.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New AsignacionActivosAD

            If IsNothing(userAcceso.ObtenerAsignacionPorCodAsig(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarAsignacion(pAsignacion)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try


            Dim SocAcceso As New AsignacionActivosAD


            If IsNothing(SocAcceso.ObtenerAsignacionPorCodAsig(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            SocAcceso.BorrarAsignacion(pAsignacion)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerAsignacionPorCodAsig(ByVal pCod As String) As AsignacionActivosEN
        Try

            If (pCod.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim userAcceso As New AsignacionActivosAD
            Return userAcceso.ObtenerAsignacionPorCodAsig(pCod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosAsignacion() As List(Of AsignacionActivosEN)
        Try
            Dim SocAcceso As New AsignacionActivosAD
            Return SocAcceso.obtenerTodosAsignacion
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
