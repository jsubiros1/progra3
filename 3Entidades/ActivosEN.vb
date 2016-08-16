Public Class ActivosEN

#Region "Propiedades"
    Property Cod_Activo
    Property Descripcion
    Property Cod_Categoria
    Property Fec_Compra
    Property Costo
    Property Observaciones
#End Region

#Region "Constructores"

    ''' <summary>
    ''' Activos constructor vacio
    ''' </summary>
    Public Sub New()
        Cod_Activo = ""
        Descripcion = ""
        Cod_Categoria = ""
        Fec_Compra = ""
        Costo = ""
        Observaciones = ""
    End Sub

    ''' <summary>
    ''' Activos constructor con parametros
    ''' </summary>
    ''' <param name="Cod_Activo">Codigo del Activo</param>
    ''' <param name="Descripcion">Descripcion del Activo</param>
    ''' <param name="Cod_Categoria">Codigo de la Categoria</param>
    ''' <param name="Fec_Compra">Fecha de Compra</param>
    ''' <param name="Costo">Costo del Activo</param>
    ''' <param name="Observaciones">Observaciones</param>
    Public Sub New(ByVal Cod_Activo, ByVal Descripcion, ByVal Cod_Categoria, ByVal Fec_Compra, ByVal Costo, ByVal Observaciones)
        _Cod_Activo = Cod_Activo
        _Descripcion = Descripcion
        _Cod_Categoria = Cod_Categoria
        _Fec_Compra = Fec_Compra
        _Costo = Costo
        _Observaciones = Observaciones
    End Sub

#End Region

#Region "toString"

    Public Overrides Function ToString() As String
        Return "Activos -> Cod Activo: " & Cod_Activo & ", Descrip: " & Descripcion & ", Cod Cat: " & Cod_Categoria & ", Fecha Comp: " & Fec_Compra &
            ", Costo: " & Costo & ", Observaciones: " & Observaciones
    End Function

#End Region



End Class
