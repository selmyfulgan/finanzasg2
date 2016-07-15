Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.tbl_mf_empresa' Puede moverla o quitarla según sea necesario.
        Dim ds As New DataSet
        Dim consulta As New fn_general
        ds = consulta.cb_permisos
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.ValueMember = "id_permisos"
        ComboBox1.DisplayMember = "per_nombre"

        Dim ds_mod As New DataSet
        Dim consulta2 As New fn_general
        ds_mod = consulta2.cb_modulo
        ComboBox2.DataSource = ds_mod.Tables(0)
        ComboBox2.ValueMember = "id_modulo"
        ComboBox2.DisplayMember = "mod_descripcion"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ListadoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim DUsu As New DetalleUsuarios()
        DUsu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TBpass As String = TextBox2.Text
        Dim TBusu As String = TextBox1.Text
        Dim TBcorreo As String = TextBox3.Text
        Dim CBpermiso As Integer = ComboBox1.SelectedValue
        Dim CBmodulo As Integer = ComboBox2.SelectedValue
        Dim DFecha As Date = DateTimePicker1.Value
        Dim consulta As New fn_general
        Dim content As String
        content = consulta.ingresa_usuarios(TBusu, TBpass, TBcorreo, CBpermiso, DFecha, CBmodulo)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        Dim ds As New DataSet

        'Me.Tbl_mf_empresaTableAdapter3.Fill(Me.DataSet1.tbl_mf_empresa)
        Dim consulta2 As New fn_general

        ds = consulta2.cb_usuarios_sistema
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim indice As Integer
        indice = DataGridView1.CurrentCell.RowIndex
        Dim dato As Integer = DataGridView1.Rows.SharedRow(indice).Cells(0).Value
        Debug.WriteLine(dato)

        Dim consulta2 As New fn_general
        ds = consulta2.cb_usuario_delete(dato)
        ds = consulta2.cb_usuarios_sistema
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class