Public Class Bancos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.tbl_mf_empresa' Puede moverla o quitarla según sea necesario.
        Me.Tbl_mf_empresaTableAdapter3.Fill(Me.DataSet1.tbl_mf_empresa)


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CBEmpresa As Integer = 1 'ComboBox1.Text
        Dim TBEntidad As Integer = 2 'TextBox1.Text
        Dim DTPfecha As Date = "2016-07-13" 'DateTimePicker1.Text
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.Insertar("insert into db2.dbo.tbl_mf_bancos(id_empresa,id_banco_1,bc_id_externo,bc_fecha_cierre,bc_fecha,id_estado) values (" & CBEmpresa & ",2,3,'','2016-07-11',1 )")

        MsgBox("Se ingreso exitosamente")

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
End Class