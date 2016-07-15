Imports System.Windows.Forms

Public Class MDIPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo. 
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ConsiliaciónBancariaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilidadToolStripMenuItem.Click

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub CatalogoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoDeCuentasToolStripMenuItem.Click
        'Dim frmCatalogo As New dll_Catalogo_Cuentas.frmCatalogoCuentas
        'frmCatalogo.ShowDialog()
    End Sub

    Private Sub ContabilidadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContabilidadToolStripMenuItem1.Click

    End Sub

    Private Sub ConsiliaciónBancariaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsiliaciónBancariaToolStripMenuItem1.Click
        Dim frm As New panelConciliacion()
        frm.Show()
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PeríodoContableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeríodoContableToolStripMenuItem.Click
        Dim frperiodocontable As New dll_periodocontable.frPeriodo()
        frperiodocontable.Show()
    End Sub

    Private Sub MantenimientoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeUsuariosToolStripMenuItem.Click
        Dim frm As New Usuarios()
        frm.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        Dim frm As New Bancos()
        frm.Show()
    End Sub

    Private Sub TipoMovimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoMovimientoToolStripMenuItem.Click
        Dim frm As New TipoMovimiento()
        frm.Show()
    End Sub

    Private Sub CreaciònDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaciònDeCuentasToolStripMenuItem.Click
        Dim CCnt As New CrearCuenta()
        CCnt.Show()
    End Sub

    Private Sub MoviemientoBancarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoviemientoBancarioToolStripMenuItem.Click
        Dim Cm As New Movimientos()
        Cm.Show()
    End Sub

    Private Sub TipoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCuentaToolStripMenuItem.Click
        Dim TC As New TipoCuenta()
        TC.Show()
    End Sub
End Class
