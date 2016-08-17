
Imports _1AccesoADatos
Imports _3Entidades

Public Class DepartamentosLN

#Region "Constructor"

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
#End Region


#Region "Funciones"


    ''' <summary>
    ''' Insertar un nuevo departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>
    ''' 
    Public Sub InsertarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try
            If (pDepartamento.Cod_Dept.Trim().Length = 0) Then
                Throw New Exception("El codigo del dpto es obligatorio")
            End If

            Dim dpto As New DepartamentosAD

            If Not IsNothing(dpto.ObtenerDepartamentoPorCod(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Este departamento ya existe")

            End If

            dpto.InsertarDepartamento(pDepartamento)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Modificar departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>

    Public Sub ModificarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            If (pDepartamento.Cod_Dept.Trim().Length = 0) Then
                Throw New Exception("El codigo es obligatorio")
            End If

            Dim dpto As New DepartamentosAD

            If IsNothing(dpto.ObtenerDepartamentoPorCod(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Este departamento no existe")
            End If

            dpto.ModificarDepartamento(pDepartamento)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Borrar departamento
    ''' </summary>
    ''' <param name="pDepartamento">Objeto departamento</param>

    Public Sub BorrarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            Dim dpto As New DepartamentosAD

            If IsNothing(dpto.ObtenerDepartamentoPorCod(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Este departamento no existe")
            End If

            dpto.BorrarDepartamento(pDepartamento)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    'No se que hace esta funcion
    ''Public Function ObtenerSocioPorCodDepartamento(ByVal pCod As String) As DepartamentosEN
    ''Try
    ''
    ''If (pCod.Trim().Length = 0) Then
    ''Throw New Exception("El Login es obligatorio")
    ''End If
    ''
    '' Dim userAcceso As New DepartamentosAD
    ''Return userAcceso.ObtenerSocioPorCodDepartamento(pCod)
    ''
    ''Catch ex As Exception
    ''Throw New Exception(ex.Message)
    ''Exit Function
    ''End Try
    'End Function


    ''' <summary>
    ''' Obtener todos los departamentos
    ''' </summary>
    ''' <returns>Lista de objeto departamentos</returns>

    Public Function obtenerTodosDepartamentos() As List(Of DepartamentosEN)
        Try
            Dim dpts As New DepartamentosAD
            Return dpts.obtenerTodosDepartamentos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region

End Class
