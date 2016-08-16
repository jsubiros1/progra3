Public Class DepartamentosEN

#Region "Propiedades"

    Property Cod_Dept
    Property Nombre
    Property Observaciones

#End Region


#Region "Constructores"

    ''' <summary>
    '''Departamentos constructor vacio 
    ''' </summary>
    Public Sub New()
        Cod_Dept = ""
        Nombre = ""
        Observaciones = ""
    End Sub



    ''' <summary>
    ''' Departamentos constructor con parametros
    ''' </summary>
    ''' <param name="Cod_Dept">Codigo del Departamento</param>
    ''' <param name="Nombre">Nombre del Departamento</param>
    ''' <param name="Observaciones">Observaciones</param>
    ''' 
    Public Sub New(ByVal Cod_Dept, ByVal Nombre, ByVal Observaciones)
        _Cod_Dept = Cod_Dept
        _Nombre = Nombre
        _Observaciones = Observaciones
    End Sub

#End Region


#Region "toString"

    ''' <summary>
    ''' FUncion toString
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return "Depto -> Nombre: " & Nombre & ", Codigo: " & Cod_Dept & ", Observaciones: " & Observaciones
    End Function
#End Region

End Class
