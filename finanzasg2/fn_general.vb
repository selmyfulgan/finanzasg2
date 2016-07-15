﻿Public Class fn_general
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
        dss = con.inserta("insert into db2.dbo.tbl_mf_tipo_movimiento (tpm_descripcion,tpm_tipo_trans,id_estado) values('" & TipoMov & "','" & Desc & "','1')", la_tabla)
        MsgBox("Se ha guardado con exito")
    End Function

    Public Function cuenta(CBBancos, CBTipoCuenta, TBNumCuenta, DTApertura)
        Dim dss As DataSet
        Dim con As New claseconexion
        Dim fecha As String = DTApertura.Year & "/" & DTApertura.Month & "/" & DTApertura.Day
        Dim la_tabla As String = "DB2.dbo.tbl_mf_cuenta"
        dss = con.inserta("insert into db2.dbo.tbl_mf_cuenta (id_banco,id_tipo_cuenta,cta_num_cuenta,cta_fecha,id_estado) values(" & CBBancos & "," & CBTipoCuenta & ",'" & TBNumCuenta & "','" & fecha & "',1)", la_tabla)

        MsgBox("Se ingreso exitosamente")
    End Function

    Public Function manejo_banco(CBEmpresa As Integer, TBBanco As String, DFecha As Date)
        Dim la_tabla As String = "db2.dbo.tbl_mf_bancos"
        Dim dss As DataSet
        Dim con As New claseconexion
        Debug.WriteLine(TBBanco)
        Dim fecha As String = DFecha.Year & "/" & DFecha.Month & "/" & DFecha.Day
        'Debug.WriteLine(DFecha.Date.ToString)
        dss = con.inserta("insert into db2.dbo.tbl_mf_bancos(id_empresa,id_banco_1,bc_id_externo,bc_fecha_cierre,bc_fecha,id_estado) values (" & CBEmpresa & ",'" & TBBanco & "',3,'','" & fecha & "',1 )", la_tabla)
        'MsgBox("Se ingreso exitosamente")

    End Function
    Public Function cb_entidad()
        Dim la_tabla As String = "db2.dbo.tbl_mf_bancos"
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.llena_combo_box("select id_empresa, eps_razon_social from DB2.dbo.tbl_mf_empresa")
        'MsgBox("Se ingreso exitosamente")
        Return dss
    End Function
    Public Function cb_entidad_gbBancos()
        Dim la_tabla As String = "listado_bancos"
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.consultar("select b.id_banco,e.eps_razon_social as Empresa,b.id_banco_1 as Banco,b.bc_fecha as Apertura from db2.dbo.tbl_mf_bancos b inner join db2.dbo.tbl_mf_empresa e on b.id_empresa = e.id_empresa ", la_tabla)
        'MsgBox("Se ingreso exitosamente")
        Return dss
    End Function
    Public Function DGVBancos()
        Dim la_tabla As String = "listado_cuentas"
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.consultar("select b.id_banco_1 as Banco, tc.tpc_descripcion as Descripciòn,c.cta_num_cuenta as Cuenta,c.cta_fecha as Apertura,c.id_estado as Estado from db2.dbo.tbl_mf_cuenta c inner join db2.dbo.tbl_mf_bancos b on c.id_banco = b.id_banco inner join db2.dbo.tbl_mf_tipo_cuenta tc on c.id_tipo_cuenta = tc.id_tipo_cuenta ", la_tabla)
        'MsgBox("Se ingreso exitosamente")
        Return dss
    End Function
    Public Function selecciona_tipo_movimiento()
        Dim la_tabla As String = "listado_tipo_mov"
        Dim dss As DataSet
        Dim con As New claseconexion
        dss = con.consultar("select id_tipo_movimiento,tpm_descripcion from db2.dbo.tbl_mf_tipo_movimiento ", la_tabla)
        'MsgBox("Se ingreso exitosamente")
        Return dss
    End Function

    Public Function cb_entidad_delete(CBEmpresa As Integer)
        Dim dss As DataSet
        Dim con As New claseconexion
        Dim la_tabla As String = "db2.dbo.tbl_mf_bancos"
        dss = con.inserta("DELETE FROM db2.dbo.tbl_mf_bancos where id_banco = " & CBEmpresa & " ", la_tabla)
        MsgBox("Se ha eliminado con exito")
    End Function

    Public Function cb_tipo_mov_delete(CBEmpresa As Integer)
        Dim dss As DataSet
        Dim con As New claseconexion
        Dim la_tabla As String = "db2.dbo.tbl_mf_tipo_movimiento"
        dss = con.inserta("DELETE FROM db2.dbo.tbl_mf_tipo_movimiento where id_tipo_movimiento = " & CBEmpresa & " ", la_tabla)
        MsgBox("Se ha eliminado con exito")
    End Function
End Class
