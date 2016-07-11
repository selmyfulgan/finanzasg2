<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frExtracto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtHoja = New System.Windows.Forms.TextBox()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Cargar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hoja"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Archivo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 100)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(979, 320)
        Me.DataGridView1.TabIndex = 9
        '
        'txtHoja
        '
        Me.txtHoja.Location = New System.Drawing.Point(507, 42)
        Me.txtHoja.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoja.Name = "txtHoja"
        Me.txtHoja.Size = New System.Drawing.Size(132, 22)
        Me.txtHoja.TabIndex = 8
        Me.txtHoja.Text = "Hoja1"
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(111, 37)
        Me.txtArchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(271, 22)
        Me.txtArchivo.TabIndex = 7
        '
        'Cargar
        '
        Me.Cargar.Location = New System.Drawing.Point(733, 495)
        Me.Cargar.Margin = New System.Windows.Forms.Padding(4)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(68, 53)
        Me.Cargar.TabIndex = 6
        Me.Cargar.Text = "Abrir"
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'frExtracto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 571)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtHoja)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.Cargar)
        Me.Name = "frExtracto"
        Me.Text = "Extracto Bancario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtHoja As TextBox
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents Cargar As Button
End Class
