Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient

Public Class claseconexion
    Public Function conexion()
        Dim connstring As String = "data source=168.234.74.21;initial catalog=DB2;user id=db2admin;password=db2admin$;"
        ' Dim con As [String] = HRM_NOMINAS.Properties.Settings.[Default].NominaConnectionString

        Return connstring
    End Function


    Public Function abrirconexion() As SqlConnection
        Dim con As String = conexion()
        Dim abreconexion As New SqlConnection(con)
        Console.WriteLine(abreconexion.State.ToString())
        'if (abiertaconexion.State.ToString() == "Open")
        '{
        '   Console.WriteLine(abiertaconexion.State.ToString());
        '}
        abreconexion.Open()
        Return abreconexion
    End Function

    Public Function Insertar(ByVal inserta As String)
        Dim ds As New DataSet
        Try
            Dim Comando As New SqlCommand(inserta, abrirconexion())
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function

    Public Function consultar(ByVal consulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(consulta)
            Dim adapter As New SqlDataAdapter(consulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_usuario")
            'Comando.ExecuteNonQuery()
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

    Public Function insertaMov(ByVal cbConsulta As String)
        Dim ds As New DataSet

        Try
            'Dim Comando As New SqlCommand(consulta, abrirconexion())
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_tipo_movimiento")
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
            Debug.WriteLine(cbConsulta)
            Dim adapter As New SqlDataAdapter(cbConsulta, abrirconexion())
            adapter.Fill(ds, "DB2.dbo.tbl_mf_tipo_cuenta")
            'Comando.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Return ds
    End Function
End Class





