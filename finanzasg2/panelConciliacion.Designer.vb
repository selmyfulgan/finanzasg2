<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelConciliacion
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
        Me.DocumentoConciliaciónBancareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConciliacionBancareaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(823, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConciliacionBancareaToolStripMenuItem
        '
        Me.ConciliacionBancareaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChequesPendientesDeCobroToolStripMenuItem, Me.NotasDeCrèditoYDèbitoToolStripMenuItem, Me.ConsigancionesPendientesToolStripMenuItem, Me.DocumentoConciliaciónBancareaToolStripMenuItem})
        Me.ConciliacionBancareaToolStripMenuItem.Name = "ConciliacionBancareaToolStripMenuItem"
        Me.ConciliacionBancareaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.ConciliacionBancareaToolStripMenuItem.Text = "Conciliacion Bancarea"
        '
        'ChequesPendientesDeCobroToolStripMenuItem
        '
        Me.ChequesPendientesDeCobroToolStripMenuItem.Name = "ChequesPendientesDeCobroToolStripMenuItem"
        Me.ChequesPendientesDeCobroToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.ChequesPendientesDeCobroToolStripMenuItem.Text = "Cheques Pendientes de Cobro"
        '
        'NotasDeCrèditoYDèbitoToolStripMenuItem
        '
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Name = "NotasDeCrèditoYDèbitoToolStripMenuItem"
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.NotasDeCrèditoYDèbitoToolStripMenuItem.Text = "Notas de crèdito y dèbito"
        '
        'ConsigancionesPendientesToolStripMenuItem
        '
        Me.ConsigancionesPendientesToolStripMenuItem.Name = "ConsigancionesPendientesToolStripMenuItem"
        Me.ConsigancionesPendientesToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.ConsigancionesPendientesToolStripMenuItem.Text = "Consiganciones Pendientes"
        '
        'DocumentoConciliaciónBancareaToolStripMenuItem
        '
        Me.DocumentoConciliaciónBancareaToolStripMenuItem.Name = "DocumentoConciliaciónBancareaToolStripMenuItem"
        Me.DocumentoConciliaciónBancareaToolStripMenuItem.Size = New System.Drawing.Size(310, 26)
        Me.DocumentoConciliaciónBancareaToolStripMenuItem.Text = "Documento conciliación bancarea"
        '
        'panelConciliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(823, 518)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "panelConciliacion"
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
    Friend WithEvents DocumentoConciliaciónBancareaToolStripMenuItem As ToolStripMenuItem
End Class
