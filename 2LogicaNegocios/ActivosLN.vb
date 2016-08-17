Imports _3Entidades
Imports _1AccesoADatos

Public Class ActivosLN

#Region "Constructor"

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

#End Region

#Region "Funciones"

    ''' <summary>
    ''' Insertar un nuevo activo
    ''' </summary>
    ''' <param name="pActivo">Objeto Activo</param>

    Public Sub InsertarActivo(ByVal pActivo As ActivosEN)
        Try
            If (pActivo.Cod_Activo.Trim().Length = 0) Then
                Throw New Exception("Es necesario un codigo de activo")

            End If

            Dim act As New ActivosAD

            If Not IsNothing(act.ObtenerActivosPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Este codigo ya existe")

            End If

            act.InsertarActivos(pActivo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Modificar activo
    ''' </summary>
    ''' <param name="pActivo">Objeto de tipo Activo</param>

    Public Sub ModificarActivo(ByVal pActivo As ActivosEN)
        Try

            If (pActivo.Cod_Activo.Trim().Length = 0) Then
                Throw New Exception("Es necesario un codigo de activo")

            End If

            Dim act As New ActivosAD

            If IsNothing(act.ObtenerActivosPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Ese actvo no existe")

            End If
            act.ModificarActivos(pActivo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarActivo(ByVal pActivo As ActivosEN)
        Try

            Dim act As New ActivosAD

            If IsNothing(act.ObtenerActivosPorCod(pActivo.Cod_Activo)) Then
                Throw New Exception("Ese Activo no existe")
            End If

            act.BorrarActivos(pActivo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Obtener activo por codigo
    ''' </summary>
    ''' <param name="pCod">String codigo de activo</param>
    ''' <returns>Objeto de tipo Activo</returns>

    Public Function ObtenerActivoPorCod(ByVal pCod As String) As ActivosEN
        Try

            If (pCod.Trim().Length = 0) Then
                Throw New Exception("Es necesario un codigo de activo")
            End If

            Dim act As New ActivosAD
            Return act.ObtenerActivosPorCod(pCod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    ''' <summary>
    ''' Obtener todos los activos
    ''' </summary>
    ''' <returns>Lista de objetos de tipo Activo</returns>

    Public Function obtenerTodosActivos() As List(Of ActivosEN)
        Try
            Dim SocAcceso As New ActivosAD
            Return SocAcceso.obtenerTodosActivos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region

End Class
