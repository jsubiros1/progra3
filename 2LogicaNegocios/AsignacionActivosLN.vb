
Imports _1AccesoADatos
Imports _3Entidades
Public Class AsignacionActivosLN


#Region "Costructor"
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
#End Region

#Region "Funciones"

    ''' <summary>
    ''' Insertar una nueva asignacion de activos
    ''' </summary>
    ''' <param name="pAsignacion">Objeto asignacionActivos</param>

    Public Sub InsertarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try
            If (pAsignacion.Cod_Asignacion.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If

            Dim ascAct As New AsignacionActivosAD

            If Not IsNothing(ascAct.ObtenerAsignacionActivosPorCod(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            ascAct.InsertarAsignacionActivos(pAsignacion)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Modificar Asignacion
    ''' </summary>
    ''' <param name="pAsignacion">Objeto asignacionActivo</param>

    Public Sub ModificarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try

            If (pAsignacion.Cod_Asignacion.Trim().Length = 0) Then
                Throw New Exception("Es necesario un codigo de asgnacion")

            End If

            Dim ascAct As New AsignacionActivosAD

            If IsNothing(ascAct.ObtenerAsignacionActivosPorCod(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            ascAct.ModificarAsignacionActivos(pAsignacion)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Borrar asignacion
    ''' </summary>
    ''' <param name="pAsignacion">Objeto asignacion de activos</param>

    Public Sub BorrarAsignacion(ByVal pAsignacion As AsignacionActivosEN)
        Try

            Dim ascAct As New AsignacionActivosAD


            If IsNothing(ascAct.ObtenerAsignacionActivosPorCod(pAsignacion.Cod_Asignacion)) Then
                Throw New Exception("Esta codigo no existe")
            End If

            ascAct.BorrarAsignacionActivos(pAsignacion)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Obtener asignacion de activos por codigo
    ''' </summary>
    ''' <param name="pCod">Codigo de asign de activo</param>
    ''' <returns>Objeto asignacion de activos</returns>

    Public Function ObtenerAsignacionPorCodAsig(ByVal pCod As String) As AsignacionActivosEN
        Try

            If (pCod.Trim().Length = 0) Then
                Throw New Exception("Es necesario un codigo")
            End If

            Dim ascAct As New AsignacionActivosAD
            Return ascAct.ObtenerAsignacionActivosPorCod(pCod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    ''' <summary>
    ''' Obtener todas las asignaciones de activos
    ''' </summary>
    ''' <returns>Lista de objetos de tipo asignacion de activos</returns>

    Public Function obtenerTodosAsignacion() As List(Of AsignacionActivosEN)
        Try
            Dim ascAct As New AsignacionActivosAD
            Return ascAct.obtenerTodosAsignacionActivos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region

End Class
