<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeBancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoMovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaciònDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsiliaciónBancariaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesMovimientosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PeriodoContableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StatusStrip.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1075, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripStatusLabel.Text = "Usuario:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripStatusLabel1.Text = "invitado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilidadToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ToolStripMenuItem1, Me.SeguridadToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilidadToolStripMenuItem1, Me.BancosToolStripMenuItem, Me.ConsiliaciónBancariaToolStripMenuItem1})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.ContabilidadToolStripMenuItem.Text = "Catálogos"
        '
        'ContabilidadToolStripMenuItem1
        '
        Me.ContabilidadToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoDeCuentasToolStripMenuItem, Me.PeriodoContableToolStripMenuItem, Me.PolizaToolStripMenuItem, Me.TipoPolizaToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem1.Name = "ContabilidadToolStripMenuItem1"
        Me.ContabilidadToolStripMenuItem1.Size = New System.Drawing.Size(225, 26)
        Me.ContabilidadToolStripMenuItem1.Text = "Contabilidad"
        '
        'CatalogoDeCuentasToolStripMenuItem
        '
        Me.CatalogoDeCuentasToolStripMenuItem.Name = "CatalogoDeCuentasToolStripMenuItem"
        Me.CatalogoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.CatalogoDeCuentasToolStripMenuItem.Text = "Catalogo de Cuentas"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeBancosToolStripMenuItem})
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'IngresoDeBancosToolStripMenuItem
        '
        Me.IngresoDeBancosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BancosToolStripMenuItem1, Me.TipoMovimientoToolStripMenuItem, Me.TipoDeCuentaToolStripMenuItem, Me.CreaciònDeCuentasToolStripMenuItem})
        Me.IngresoDeBancosToolStripMenuItem.Name = "IngresoDeBancosToolStripMenuItem"
        Me.IngresoDeBancosToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.IngresoDeBancosToolStripMenuItem.Text = "Mantenimientos"
        '
        'BancosToolStripMenuItem1
        '
        Me.BancosToolStripMenuItem1.Name = "BancosToolStripMenuItem1"
        Me.BancosToolStripMenuItem1.Size = New System.Drawing.Size(219, 26)
        Me.BancosToolStripMenuItem1.Text = "Bancos"
        '
        'TipoMovimientoToolStripMenuItem
        '
        Me.TipoMovimientoToolStripMenuItem.Name = "TipoMovimientoToolStripMenuItem"
        Me.TipoMovimientoToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.TipoMovimientoToolStripMenuItem.Text = "Tipo Movimiento"
        '
        'TipoDeCuentaToolStripMenuItem
        '
        Me.TipoDeCuentaToolStripMenuItem.Name = "TipoDeCuentaToolStripMenuItem"
        Me.TipoDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.TipoDeCuentaToolStripMenuItem.Text = "Tipo de Cuenta"
        '
        'CreaciònDeCuentasToolStripMenuItem
        '
        Me.CreaciònDeCuentasToolStripMenuItem.Name = "CreaciònDeCuentasToolStripMenuItem"
        Me.CreaciònDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.CreaciònDeCuentasToolStripMenuItem.Text = "Creaciòn de Cuentas"
        '
        'ConsiliaciónBancariaToolStripMenuItem1
        '
        Me.ConsiliaciónBancariaToolStripMenuItem1.Name = "ConsiliaciónBancariaToolStripMenuItem1"
        Me.ConsiliaciónBancariaToolStripMenuItem1.Size = New System.Drawing.Size(225, 26)
        Me.ConsiliaciónBancariaToolStripMenuItem1.Text = "Consiliación Bancaria"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosBancariosToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.AyudaToolStripMenuItem.Text = "Procesos"
        '
        'MovimientosBancariosToolStripMenuItem
        '
        Me.MovimientosBancariosToolStripMenuItem.Name = "MovimientosBancariosToolStripMenuItem"
        Me.MovimientosBancariosToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.MovimientosBancariosToolStripMenuItem.Text = "Movimientos Bancarios"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.ConsultaToolStripMenuItem.Text = "Historico Movimientos Bancarios"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDeContabilidadToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ReportesMovimientosBancariosToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 24)
        Me.ToolStripMenuItem1.Text = "Reportes"
        '
        'ReportesDeContabilidadToolStripMenuItem
        '
        Me.ReportesDeContabilidadToolStripMenuItem.Name = "ReportesDeContabilidadToolStripMenuItem"
        Me.ReportesDeContabilidadToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.ReportesDeContabilidadToolStripMenuItem.Text = "Reportes de Contabilidad"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.ReportesToolStripMenuItem.Text = " Reportes Conciliación bancaria"
        '
        'ReportesMovimientosBancariosToolStripMenuItem
        '
        Me.ReportesMovimientosBancariosToolStripMenuItem.Name = "ReportesMovimientosBancariosToolStripMenuItem"
        Me.ReportesMovimientosBancariosToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.ReportesMovimientosBancariosToolStripMenuItem.Text = "Reportes Movimientos Bancarios"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDeUsuariosToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'MantenimientoDeUsuariosToolStripMenuItem
        '
        Me.MantenimientoDeUsuariosToolStripMenuItem.Name = "MantenimientoDeUsuariosToolStripMenuItem"
        Me.MantenimientoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(264, 26)
        Me.MantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de usuarios"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de ..."
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(978, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "FINANZAS"
        '
        'PeriodoContableToolStripMenuItem
        '
        Me.PeriodoContableToolStripMenuItem.Name = "PeriodoContableToolStripMenuItem"
        Me.PeriodoContableToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.PeriodoContableToolStripMenuItem.Text = "Periodo Contable"
        '
        'PolizaToolStripMenuItem
        '
        Me.PolizaToolStripMenuItem.Name = "PolizaToolStripMenuItem"
        Me.PolizaToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.PolizaToolStripMenuItem.Text = "Poliza"
        '
        'TipoPolizaToolStripMenuItem
        '
        Me.TipoPolizaToolStripMenuItem.Name = "TipoPolizaToolStripMenuItem"
        Me.TipoPolizaToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.TipoPolizaToolStripMenuItem.Text = "Tipo Poliza"
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIPrincipal"
        Me.Text = "Módulo de Finanazas"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContabilidadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsiliaciónBancariaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeBancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoMovimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreaciònDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AyudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TipoDeCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesMovimientosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeriodoContableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoPolizaToolStripMenuItem As ToolStripMenuItem
End Class
