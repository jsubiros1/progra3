

Imports _1AccesoADatos
Imports _3Entidades
Public Class EmpleadosLN

#Region "Cobstructor"
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
#End Region


#Region "Funciones"

    ''' <summary>
    ''' Insertar un empleado
    ''' </summary>
    ''' <param name="pEmpleado">Objeto empleado</param>

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try
            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")
            End If

            Dim emp As New EmpleadosAD

            If Not IsNothing(emp.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Ese Usuario ya Existe")
            End If

            emp.InsertarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Modificar un empleado
    ''' </summary>
    ''' <param name="pEmpleado">Objerto empleado</param>

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("No se ha insertado cedula")
            End If

            Dim usr As New EmpleadosAD

            If IsNothing(usr.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            usr.ModificarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub


    ''' <summary>
    ''' Borrar epleado
    ''' </summary>
    ''' <param name="pEmpleado">Objeto empleado</param>

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            Dim emp As New EmpleadosAD

            If IsNothing(emp.ObtenerEmpleadoPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Este empleado no existe")
            End If

            emp.BorrarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Obtener empleado por cedula
    ''' </summary>
    ''' <param name="pCedula"></param>
    ''' <returns></returns>

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadosEN
        Try

            If (pCedula.Trim().Length = 0) Then
                Throw New Exception("La cedula es obligatroria")
            End If

            Dim usr As New EmpleadosAD
            Return usr.ObtenerEmpleadoPorCedula(pCedula)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


    ''' <summary>
    ''' Obtener todos los empleados
    ''' </summary>
    ''' <returns>Lista de objeto Empleado</returns>

    Public Function obtenerTodosLosEmpleados() As List(Of EmpleadosEN)
        Try
            Dim SocAcceso As New EmpleadosAD
            Return SocAcceso.obtenerTodosEmpleados
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

#End Region

End Class
