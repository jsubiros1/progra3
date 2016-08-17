Public Class EmpleadosEN


#Region "Propiedades"

    Property Cedula
    Property NombreCompleto
    Property Cod_Dept
    Property Tel_Celular
    Property Tel_Casa
    Property Fec_Nacimiento
    Property E_Mail
    Property Dir_Completa

#End Region


#Region "Constructores"

    ''' <summary>
    ''' Empleados constructor vacio
    ''' </summary>
    Public Sub New()
        Cedula = ""
        NombreCompleto = ""
        Cod_Dept = ""
        Tel_Celular = ""
        Tel_Casa = ""
        Fec_Nacimiento = ""
        E_Mail = ""
        Dir_Completa = ""
    End Sub


    ''' <summary>
    ''' Empleados constructor con parametros
    ''' </summary>
    ''' <param name="Cedula">Cedula del Empleado</param>
    ''' <param name="NombreCompleto">Nombre Completo del Empleado</param>
    ''' <param name="Cod_Dept">Codigo del Departamento</param>
    ''' <param name="Tel_Celular">Telefono Celular</param>
    ''' <param name="Tel_Casa">Telefono de la Casa</param>
    ''' <param name="Fec_Nacimiento">Fecha de Nacimiento</param>
    ''' <param name="E_Mail">Correo Electronico (Email)</param>
    ''' <param name="Dir_Completa">Direccion completa</param>
    Public Sub New(ByVal Cedula, ByVal NombreCompleto, ByVal Cod_Dept, ByVal Tel_Celular, ByVal Tel_Casa, ByVal Fec_Nacimiento, ByVal E_Mail, ByVal Dir_Completa)

        _Cedula = Cedula
        _NombreCompleto = NombreCompleto
        _Cod_Dept = Cod_Dept
        _Tel_Celular = Tel_Celular
        _Tel_Casa = Tel_Casa
        _Fec_Nacimiento = Fec_Nacimiento
        _E_Mail = E_Mail
        _Dir_Completa = Dir_Completa

    End Sub

#End Region


#Region "toString"

    ''' <summary>
    ''' Funcion toString
    ''' </summary>
    ''' <returns></returns>

    Public Overrides Function ToString() As String
        Return "Empleado -> Ced: " & Cedula & ", Nombre: " & NombreCompleto & ", Cod Dept: " & Cod_Dept &
        ", Tel Celular: " & Tel_Casa & ", Tel Casa: " & Tel_Casa &
        ", Fecha Nacimiento: " & Fec_Nacimiento & ", EMail: " & E_Mail & "Direccion: " & Dir_Completa
    End Function


#End Region

End Class
