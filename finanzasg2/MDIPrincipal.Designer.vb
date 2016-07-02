<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsiliaciónBancariaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PeríodoContableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(806, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilidadToolStripMenuItem, Me.ToolStripMenuItem1, Me.AyudaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilidadToolStripMenuItem1, Me.PeríodoContableToolStripMenuItem, Me.BancosToolStripMenuItem, Me.ConsiliaciónBancariaToolStripMenuItem1})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ContabilidadToolStripMenuItem.Text = "Catálogos"
        '
        'ContabilidadToolStripMenuItem1
        '
        Me.ContabilidadToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoDeCuentasToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem1.Name = "ContabilidadToolStripMenuItem1"
        Me.ContabilidadToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ContabilidadToolStripMenuItem1.Text = "Contabilidad"
        '
        'CatalogoDeCuentasToolStripMenuItem
        '
        Me.CatalogoDeCuentasToolStripMenuItem.Name = "CatalogoDeCuentasToolStripMenuItem"
        Me.CatalogoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CatalogoDeCuentasToolStripMenuItem.Text = "Catalogo de Cuentas"
        '
        'ConsiliaciónBancariaToolStripMenuItem1
        '
        Me.ConsiliaciónBancariaToolStripMenuItem1.Name = "ConsiliaciónBancariaToolStripMenuItem1"
        Me.ConsiliaciónBancariaToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ConsiliaciónBancariaToolStripMenuItem1.Text = "Consiliación Bancaria"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDeContabilidadToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Procesos"
        '
        'ReportesDeContabilidadToolStripMenuItem
        '
        Me.ReportesDeContabilidadToolStripMenuItem.Name = "ReportesDeContabilidadToolStripMenuItem"
        Me.ReportesDeContabilidadToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReportesDeContabilidadToolStripMenuItem.Text = "Reportes de Contabilidad"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReportesToolStripMenuItem.Text = " Reportes Conciliación bancaria"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AyudaToolStripMenuItem.Text = "Reportes"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Image = Global.finanzasg2.My.Resources.Resources.free_office_wallpaper_26001_26685_hd_wallpapers_e14420084284972
        Me.Label1.Location = New System.Drawing.Point(670, 335)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 54)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Módulo de Finanzas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PeríodoContableToolStripMenuItem
        '
        Me.PeríodoContableToolStripMenuItem.Name = "PeríodoContableToolStripMenuItem"
        Me.PeríodoContableToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PeríodoContableToolStripMenuItem.Text = "Período contable"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.finanzasg2.My.Resources.Resources.free_office_wallpaper_26001_26685_hd_wallpapers_e14420084284971
        Me.ClientSize = New System.Drawing.Size(806, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
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
    Friend WithEvents Label1 As Label
    Friend WithEvents CatalogoDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeríodoContableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As ToolStripMenuItem
End Class
