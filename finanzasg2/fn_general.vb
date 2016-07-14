Public Class fn_general
    Public Function login(nusuario, pusuario)

        Dim con As New claseconexion
        Dim ds As DataSet
        Dim la_tabla As String = "DB2.dbo.tbl_mf_usuario"
        ds = con.consultar("select user_nombre,user_password from db2.dbo.tbl_mf_usuarios where user_nombre = '" & nusuario & "' and user_password = '" & pusuario & "'", la_tabla)
        If ds.Tables(0).Rows.Count > 0 Then
            'si trae alguna fila es porque encontro el usuario y la clave es correcta 
            Dim mdi As New MDIPrincipal()
            mdi.Show()
        Else
            'sino encontro coicidencias no deja entrar 
            MsgBox("el usuario o contaseña incorrecta")

        End If
    End Function

    Public Function tipo_movimiento(TipoMov, Desc)
        Dim dss As DataSet
        Dim con As New claseconexion
        Dim la_tabla As String = "DB2.dbo.tbl_mf_tipo_movimiento"
        dss = con.inserta("insert into db2.dbo.tbl_mf_tipo_movimiento (tpm_descripcion,tpm_tipo_trans,id_estado) values('" & TipoMov & "','1','1')", la_tabla)
        MsgBox("Se ha guardado con exito")
    End Function
End Class
