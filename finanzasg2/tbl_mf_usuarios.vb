'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tbl_mf_usuarios
    Public Property id_usuarios As Integer
    Public Property user_nombre As String
    Public Property user_password As String
    Public Property user_estado As Boolean
    Public Property user_correo As String
    Public Property user_fecha_ingreso As Date

    Public Overridable Property tbl_mf_detalle_usuarios As ICollection(Of tbl_mf_detalle_usuarios) = New HashSet(Of tbl_mf_detalle_usuarios)

End Class
