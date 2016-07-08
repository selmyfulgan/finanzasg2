<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frPanelConciliacion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConciliacionBancareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChequesPendientesDeCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsigancionesPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtractoBancarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConciliacionBancareaToolStripMenuItem, Me.ExtractoBancarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConciliacionBancareaToolStripMenuItem
        '
        Me.ConciliacionBancareaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChequesPendientesDeCobroToolStripMenuItem, Me.NotasDeCrèditoYDèbitoToolStripMenuItem, Me.ConsigancionesPendientesToolStripMenuItem})
        Me.ConciliacionBancareaToolStripMenuItem.Name = "ConciliacionBancareaToolStripMenuItem"
        Me.ConciliacionBancareaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ConciliacionBancareaToolStripMenuItem.Text = "Archivo"
        '
        'ChequesPendientesDeCobroToolStripMenuItem
        '
        Me.ChequesPendientesDeCobroToolStripMenuItem.Name = "ChequesPendientesDeCobroToolStripMenuItem"
        Me.ChequesPendientesDeCobroToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ChequesPendientesDeCobroToolStripMenuItem.Text = "Nuevo Conciliacion"
        '
        'NotasDeCrèditoYDèbitoToolStripMenuItem
        '
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Name = "NotasDeCrèditoYDèbitoToolStripMenuItem"
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Text = "Conciliacion Pendiente"
        '
        'ConsigancionesPendientesToolStripMenuItem
        '
        Me.ConsigancionesPendientesToolStripMenuItem.Name = "ConsigancionesPendientesToolStripMenuItem"
        Me.ConsigancionesPendientesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConsigancionesPendientesToolStripMenuItem.Text = "Ajustes Contables"
        '
        'ExtractoBancarioToolStripMenuItem
        '
        Me.ExtractoBancarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDocumentoToolStripMenuItem, Me.AbrirDocumentoToolStripMenuItem, Me.ExportarDocumentoToolStripMenuItem})
        Me.ExtractoBancarioToolStripMenuItem.Name = "ExtractoBancarioToolStripMenuItem"
        Me.ExtractoBancarioToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ExtractoBancarioToolStripMenuItem.Text = "Extracto Bancario"
        '
        'ImportarDocumentoToolStripMenuItem
        '
        Me.ImportarDocumentoToolStripMenuItem.Name = "ImportarDocumentoToolStripMenuItem"
        Me.ImportarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ImportarDocumentoToolStripMenuItem.Text = "Importar Documento"
        '
        'AbrirDocumentoToolStripMenuItem
        '
        Me.AbrirDocumentoToolStripMenuItem.Name = "AbrirDocumentoToolStripMenuItem"
        Me.AbrirDocumentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AbrirDocumentoToolStripMenuItem.Text = "Abrir Documento"
        '
        'ExportarDocumentoToolStripMenuItem
        '
        Me.ExportarDocumentoToolStripMenuItem.Name = "ExportarDocumentoToolStripMenuItem"
        Me.ExportarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExportarDocumentoToolStripMenuItem.Text = "Exportar Documento"
        '
        'frPanelConciliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(926, 648)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frPanelConciliacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliaciòn Bancaria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConciliacionBancareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChequesPendientesDeCobroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasDeCrèditoYDèbitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsigancionesPendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtractoBancarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarDocumentoToolStripMenuItem As ToolStripMenuItem
End Class
