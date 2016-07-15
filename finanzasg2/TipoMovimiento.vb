Imports System.Data.SqlClient

Public Class TipoMovimiento

    'Dim cn As New SqlConnection('metadata=res://*/Modelos.csdl|res://*/Modelos.ssdl|res://*/Modelos.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-OKTPPAA\SQLEXPRESS;initial catalog=FinanzaG2;user id=sa;password=12345;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient')
    'Dim cmd As New SqlCommand
    'Dim dr As SqlDataReader


    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TipoMov As String = TextBox2.Text
        Dim Desc As String = TextBox1.Text
        Dim consulta As New fn_general
        Dim content As String
        content = consulta.tipo_movimiento(TipoMov, Desc)

        Dim consulta2 As New fn_general
        TextBox1.Text = ""
        TextBox2.Text = ""
        Dim ds As New DataSet
        ds = consulta2.selecciona_tipo_movimiento
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB2DataSet1.tbl_mf_tipo_movimiento' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim indice As Integer
        indice = DataGridView1.CurrentCell.RowIndex
        Dim dato As Integer = DataGridView1.Rows.SharedRow(indice).Cells(0).Value
        Debug.WriteLine(dato)

        Dim consulta2 As New fn_general
        ds = consulta2.cb_tipo_mov_delete(dato)
        ds = consulta2.selecciona_tipo_movimiento
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class