Public Class UsuariosEN
#Region "Atributos"

    Property login
    Property nombreCompleto
    Property clave
    Property administrador
    Property contador

#End Region


#Region "Constructores"

    ''' <summary>
    ''' Usuarios constructor vacio
    ''' </summary>

    Public Sub New()
        login = ""
        nombreCompleto = ""
        clave = ""
        administrador = ""
        contador = ""
    End Sub


    ''' <summary>
    ''' Usuarios constructor con parametros
    ''' </summary>
    ''' <param name="login">Nombre de Usuario</param>
    ''' <param name="nombreCompleto">Nombre Completo</param>
    ''' <param name="clave">Clave del Usuario</param>
    ''' <param name="administrador">Si es administrador o no</param>
    ''' <param name="contador">Si es contador o no</param>

    Public Sub New(ByVal login, ByVal nombreCompleto, ByVal clave, ByVal administrador, ByVal contador)
        _login = login
        _nombreCompleto = nombreCompleto
        _clave = clave
        _administrador = administrador
        _contador = contador
    End Sub

#End Region


#Region "toString"


    ''' <summary>
    ''' Funcion toString
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return "Usuario -> Login: " & login & ", Nombre: " & nombreCompleto & ", Clave: ********, Admin: " &
            administrador & ", Contador: " & contador
    End Function


#End Region


End Class
