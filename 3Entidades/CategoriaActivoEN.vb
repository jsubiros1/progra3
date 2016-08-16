Public Class CategoriaActivoEN
#Region "Propiedades"
    Property Cod_Categoria
    Property Descripcion
    Property Observaciones
#End Region


#Region "Constructores"

    ''' <summary>
    ''' CategoriaActivo constructor vacio
    ''' </summary>
    Public Sub New()
        Cod_Categoria = ""
        Descripcion = ""
        Observaciones = ""
    End Sub

    ''' <summary>
    ''' CategoriaActivo constructor con parametros
    ''' </summary>
    ''' <param name="Cod_Categoria">Codigo de la categoria</param>
    ''' <param name="Descripcion">Descripcion</param>
    ''' <param name="Observaciones">Observaciones</param>
    Public Sub New(ByVal Cod_Categoria, ByVal Descripcion, ByVal Observaciones)
        _Cod_Categoria = Cod_Categoria
        _Descripcion = Descripcion
        _Observaciones = Observaciones
    End Sub

#End Region


#Region "toString"

    Public Overrides Function ToString() As String
        Return "CategoriaActivo -> CodCat: " & Cod_Categoria & ", Descrip: " & Descripcion & ", Observaciones: " & Observaciones
    End Function

#End Region

End Class

