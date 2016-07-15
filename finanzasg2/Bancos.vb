Public Class Bancos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.tbl_mf_empresa' Puede moverla o quitarla según sea necesario.
        Dim ds As New DataSet

        'Me.Tbl_mf_empresaTableAdapter3.Fill(Me.DataSet1.tbl_mf_empresa)
        Dim consulta As New fn_general

        ds = consulta.cb_entidad
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.ValueMember = "id_empresa"
        ComboBox1.DisplayMember = "eps_razon_social"


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CBEmpresa As Integer = ComboBox1.SelectedValue
        Dim TBBanco As String = TextBox1.Text
        Dim DFecha As Date = DateTimePicker1.Value

        Dim consulta As New fn_general
        Dim content As String
        content = consulta.manejo_banco(CBEmpresa, TBBanco, DFecha)

        TextBox1.Text = ""
        Dim ds As New DataSet

        'Me.Tbl_mf_empresaTableAdapter3.Fill(Me.DataSet1.tbl_mf_empresa)
        Dim consulta2 As New fn_general

        ds = consulta2.cb_entidad_gbBancos
        DataGridView1.DataSource = ds.Tables(0)
        'DataGridView1.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_mf_empresaTableAdapter1.FillBy(Me.DataSet2.tbl_mf_empresa)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim indice As Integer
        indice = DataGridView1.CurrentCell.RowIndex
        Dim dato As Integer = DataGridView1.Rows.SharedRow(indice).Cells(0).Value
        Debug.WriteLine(dato)

        Dim consulta2 As New fn_general
        ds = consulta2.cb_entidad_delete(dato)
        ds = consulta2.cb_entidad_gbBancos
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class