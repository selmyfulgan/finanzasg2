Imports finanzasg2.claseconexion
Public Class Login

    Dim ds As DataSet

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If (TextBox1.Text = "sfulgan" Or TextBox1.Text = "rcaracun") Then
        'Dim mdi As New MDIPrincipal()
        'mdi.Show()
        'Else
        'MsgBox("el usuario no existe")
        'End If
        Dim nusuario As String = TextBox1.Text
        Dim pusuario As String = TextBox2.Text
        Dim con As New claseconexion

        ds = con.consultar("select user_nombre,user_password from db2.dbo.tbl_mf_usuarios where user_nombre = '" & nusuario & "' and user_password = '" & pusuario & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            'si trae alguna fila es porque encontro el usuario y la clave es correcta 
            Dim mdi As New MDIPrincipal()
            mdi.Show()
        Else
            MsgBox("el usuario o contaseña incorrecta")
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New claseconexion
        con.abrirconexion()
    End Sub
End Class