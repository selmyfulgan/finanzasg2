Public Class CrearCuenta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Trandds As String = TextBox1.Text
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.InsertaCuenta("insert into db2.dbo.tbl_mf_tipo_cuenta (tpc_descripcion,id_estado) values(1,1)")

        MsgBox("Se ingreso exitosamente")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class