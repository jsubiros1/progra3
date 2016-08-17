
Imports _1AccesoADatos
Imports _3Entidades

Public Class DepartamentosLN



    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try
            If (pDepartamento.Cod_Dept.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatoria")

            End If


            Dim socAcceso As New DepartamentosAD

            If Not IsNothing(socAcceso.ObtenerSocioPorCodDepartamento(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Ese Usuario ya Existe")

            End If

            socAcceso.InsertarDepartamento(pDepartamento)


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try

            If (pDepartamento.Cod_Dept.Trim().Length = 0) Then
                Throw New Exception("El login es obligatorio")

            End If


            Dim userAcceso As New DepartamentosAD

            If IsNothing(userAcceso.ObtenerSocioPorCodDepartamento(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Ese Usuario NO  Existe")

            End If
            userAcceso.ModificarDepartamento(pDepartamento)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarDepartamento(ByVal pDepartamento As DepartamentosEN)
        Try


            Dim SocAcceso As New DepartamentosAD


            If IsNothing(SocAcceso.ObtenerSocioPorCodDepartamento(pDepartamento.Cod_Dept)) Then
                Throw New Exception("Ese Usuario no existe")
            End If

            SocAcceso.BorrarDepartamento(pDepartamento)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerSocioPorCodDepartamento(ByVal pCod As String) As DepartamentosEN
        Try

            If (pCod.Trim().Length = 0) Then
                Throw New Exception("El Login es obligatorio")
            End If

            Dim userAcceso As New DepartamentosAD
            Return userAcceso.ObtenerSocioPorCodDepartamento(pCod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosDepartamentos() As List(Of DepartamentosEN)
        Try
            Dim SocAcceso As New DepartamentosAD
            Return SocAcceso.obtenerTodosDepartamentos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function


End Class
