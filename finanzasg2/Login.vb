Public Class Login
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "sfulgan" Or TextBox1.Text = "rcaracun") Then
            Dim mdi As New MDIPrincipal()
            mdi.Show()
        Else
            MsgBox("el usuario no existe")
        End If
    End Sub
End Class