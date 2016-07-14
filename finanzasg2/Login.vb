Imports finanzasg2.claseconexion
Public Class Login

    Dim ds As DataSet

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nusuario As String = TextBox1.Text
        Dim pusuario As String = TextBox2.Text
        Dim consulta As New fn_general
        Dim content As String
        content = consulta.login(nusuario, pusuario)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class