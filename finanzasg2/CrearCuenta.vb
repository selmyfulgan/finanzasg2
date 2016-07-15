Public Class CrearCuenta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CBBancos As Integer = ComboBox1.SelectedValue
        Dim CBTipoCuenta As Integer = ComboBox2.SelectedValue
        Dim TBNumCuenta As String = TextBox1.Text
        Dim DTApertura As Date = DateTimePicker1.Value

        TextBox1.Text = ""

        Dim consulta As New fn_general
        Dim content As String
        content = consulta.cuenta(CBBancos, CBTipoCuenta, TBNumCuenta, DTApertura)

        TextBox1.Text = ""
        Dim ds As New DataSet

        ds = consulta.DGVBancos
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class