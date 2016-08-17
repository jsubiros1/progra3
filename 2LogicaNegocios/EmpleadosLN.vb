

Imports _1AccesoADatos
Imports _3Entidades
Public Class EmpleadosLN


    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try
            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If


            Dim socAcceso As New EmpleadosAD

            If Not IsNothing(socAcceso.ObtenerEmpleadosPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            socAcceso.InsertarEmpleado(pEmpleado)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try

            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New EmpleadosAD

            If IsNothing(userAcceso.ObtenerEmpleadosPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadosEN)
        Try


            Dim SocAcceso As New EmpleadosAD


            If IsNothing(SocAcceso.ObtenerEmpleadosPorCedula(pEmpleado.Cedula)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            SocAcceso.BorrarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadosPorCedula(ByVal pCedula As String) As EmpleadosEN
        Try

            If (pCedula.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim userAcceso As New EmpleadosAD
            Return userAcceso.ObtenerEmpleadosPorCedula(pCedula)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadosEN)
        Try
            Dim SocAcceso As New EmpleadosAD
            Return SocAcceso.obtenerTodosEmpleados
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
