Imports System.Data.SqlClient

Public Class TipoMovimiento

    'Dim cn As New SqlConnection('metadata=res://*/Modelos.csdl|res://*/Modelos.ssdl|res://*/Modelos.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-OKTPPAA\SQLEXPRESS;initial catalog=FinanzaG2;user id=sa;password=12345;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient')
    'Dim cmd As New SqlCommand
    'Dim dr As SqlDataReader


    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = "" Or TextBox1.Text = "") Then
            MsgBox("llene por lo menos el campo 1")
        Else
            MsgBox(TextBox2.Text)
            'cn.Open()
            'cmd.CommandText = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmd.Connection = cn
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class