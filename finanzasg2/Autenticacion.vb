Public Class Autenticacion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "sfulgan" Or TextBox1.Text = "rcaracun") Then
            Dim mdi As New MDIPrincipal()
            mdi.Show()
        Else
            MsgBox("el usuario no existe")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class