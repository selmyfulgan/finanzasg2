Imports System.Data.OleDb

Public Class frExtracto


    Private Sub LlenarGrid(ByVal archivo As String, ByVal hoja As String)


        Dim conexion As OleDbConnection = Nothing
        Dim dataset As DataSet = Nothing


        Dim dataAdapter As OleDbDataAdapter = Nothing

        Dim consultaHojaExcel As String = "Select * from [" + hoja + "$]"

        '/Dim cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;"

        Dim cadena2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & archivo & ";" & "Extended Properties=""Excel 12.0 Xml;HDR=NO;"""

        If (String.IsNullOrEmpty(hoja)) Then
            MessageBox.Show("No hay una hoja para leer")
        Else
            Try

                conexion = New OleDbConnection(cadena2)
                '//creamos la conexion con la hoja de excel
                conexion.Open()

                dataAdapter = New OleDbDataAdapter(consultaHojaExcel, conexion)

                dataset = New DataSet()

                dataAdapter.Fill(dataset, hoja) '

                DataGridView1.DataSource = dataset.Tables(0)
                conexion.Close()

                DataGridView1.AllowUserToAddRows = False
            Catch ex As Exception
                MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message)
            End Try
        End If


    End Sub

    Private Sub Cargar_Click(sender As Object, e As EventArgs) Handles Cargar.Click


        Dim hoja As String
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"


        dialog.Title = "Seleccione el archivo de Excel"

        dialog.FileName = String.Empty


        If (dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then


            txtArchivo.Text = dialog.FileName
            hoja = txtHoja.Text
            LlenarGrid(txtArchivo.Text, hoja)



            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub















End Class