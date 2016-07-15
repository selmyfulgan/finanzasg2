Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient

Public Class claseconexion
    Public Function conexion()

        Dim connstring As String = "data source=168.234.74.21;initial catalog=DB2;user id=db2admin;password=db2admin$;"
        Return connstring
    End Function


    Public Function abrirconexion() As SqlConnection
        Dim con As String = conexion()
        Dim abreconexion As New SqlConnection(con)
        Console.WriteLine(abreconexion.State.ToString())
        abreconexion.Open()
        Return abreconexion
    End Function

    Public Function consultar(consulta, la_tabla)
        Dim ds As New DataSet
        Try
            Debug.WriteLine(consulta)
            Dim adapter As New SqlDataAdapter(consulta, abrirconexion())
            adapter.Fill(ds, la_tabla)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function llena_combo_box(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_empresa")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function inserta(Consulta, la_tabla)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(Consulta)
            Dim adapter As New SqlDataAdapter(Consulta, abrirconexion())
            adapter.Fill(ds, la_tabla)
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function InsertaCuenta(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())

            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_tipo_cuenta")
            Debug.WriteLine(cbConsulta)
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds

    End Function
    Public Function llena_combo_box_bancos(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_bancos")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function llena_combo_box_tipo_cuenta(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_tipo_cuenta")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function llena_cb_permisos(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_permisos")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function
    Public Function consultar_detalle_usuario(consulta)
        Dim ds As New DataSet
        Try
            Debug.WriteLine(consulta)
            Dim adapter As New SqlDataAdapter(consulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_usuarios")
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function llena_combo_box_modulo(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_modulo")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function
End Class





