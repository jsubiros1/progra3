Public Class AsignacionActivosEN
#Region "Propiedades"
    Property Cod_Asignacion
    Property Cedula
    Property Cod_Activo
    Property Fec_Asignacion
    Property Observaciones
    Property Usuario_Asigno
#End Region

#Region "Constructores"

    ''' <summary>
    ''' AsignacionActivos constructor vacio
    ''' </summary>
    Public Sub New()
        Cod_Asignacion = ""
        Cedula = ""
        Cod_Activo = ""
        Fec_Asignacion = ""
        Observaciones = ""
        Usuario_Asigno = ""
    End Sub

    ''' <summary>
    ''' AsignacionActivos constructor con parametros
    ''' </summary>
    ''' <param name="Cod_Asignacion">Codigo de asignacion</param>
    ''' <param name="Cedula">Cedula</param>
    ''' <param name="Cod_Activo">Codigo del Activo</param>
    ''' <param name="Fec_Asignacion">Fecha de la asignacion</param>
    ''' <param name="Observaciones">Observaciones</param>
    ''' <param name="Usuario_Asigno">Usuario asignado</param>
    Public Sub New(ByVal Cod_Asignacion, ByVal Cedula, ByVal Cod_Activo, ByVal Fec_Asignacion, ByVal Observaciones, ByVal Usuario_Asigno)
        _Cod_Asignacion = Cod_Asignacion
        _Cedula = Cedula
        _Cod_Activo = Cod_Activo
        _Fec_Asignacion = Fec_Asignacion
        _Observaciones = Observaciones
        _Usuario_Asigno = Usuario_Asigno
    End Sub

#End Region


#Region "toString"

    Public Overrides Function ToString() As String
        Return "AsignacionActivos -> Cod Asig: " & Cod_Asignacion & ", Cedula: " & Cedula & ", Cod Act: " & Cod_Activo &
        ", Fecha Asig: " & Fec_Asignacion & ", Observaciones: " & Observaciones & ", Usuario Asigno: " & Usuario_Asigno
    End Function

#End Region

End Class
