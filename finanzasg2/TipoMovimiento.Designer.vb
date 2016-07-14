<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoMovimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoMovimiento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataSet1 = New finanzasg2.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB2DataSet1 = New finanzasg2.DB2DataSet1()
        Me.TblmftipomovimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_mf_tipo_movimientoTableAdapter = New finanzasg2.DB2DataSet1TableAdapters.tbl_mf_tipo_movimientoTableAdapter()
        Me.TpmtipotransDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpmdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmftipomovimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 208)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese la entidad bancaria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Descripcion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(251, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 22)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de transacción "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(906, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 62)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(831, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 62)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 522)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1037, 77)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TpmtipotransDataGridViewTextBoxColumn, Me.TpmdescripcionDataGridViewTextBoxColumn, Me.IdestadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblmftipomovimientoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(548, 111)
        Me.DataGridView1.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(248, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 132)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Tipos de Movimiento"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DB2DataSet1
        '
        Me.DB2DataSet1.DataSetName = "DB2DataSet1"
        Me.DB2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmftipomovimientoBindingSource
        '
        Me.TblmftipomovimientoBindingSource.DataMember = "tbl_mf_tipo_movimiento"
        Me.TblmftipomovimientoBindingSource.DataSource = Me.DB2DataSet1
        '
        'Tbl_mf_tipo_movimientoTableAdapter
        '
        Me.Tbl_mf_tipo_movimientoTableAdapter.ClearBeforeFill = True
        '
        'TpmtipotransDataGridViewTextBoxColumn
        '
        Me.TpmtipotransDataGridViewTextBoxColumn.DataPropertyName = "tpm_tipo_trans"
        Me.TpmtipotransDataGridViewTextBoxColumn.HeaderText = "tpm_tipo_trans"
        Me.TpmtipotransDataGridViewTextBoxColumn.Name = "TpmtipotransDataGridViewTextBoxColumn"
        '
        'TpmdescripcionDataGridViewTextBoxColumn
        '
        Me.TpmdescripcionDataGridViewTextBoxColumn.DataPropertyName = "tpm_descripcion"
        Me.TpmdescripcionDataGridViewTextBoxColumn.HeaderText = "tpm_descripcion"
        Me.TpmdescripcionDataGridViewTextBoxColumn.Name = "TpmdescripcionDataGridViewTextBoxColumn"
        '
        'IdestadoDataGridViewTextBoxColumn
        '
        Me.IdestadoDataGridViewTextBoxColumn.DataPropertyName = "id_estado"
        Me.IdestadoDataGridViewTextBoxColumn.HeaderText = "id_estado"
        Me.IdestadoDataGridViewTextBoxColumn.Name = "IdestadoDataGridViewTextBoxColumn"
        '
        'TipoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1038, 598)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TipoMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Movimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmftipomovimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DB2DataSet1 As DB2DataSet1
    Friend WithEvents TblmftipomovimientoBindingSource As BindingSource
    Friend WithEvents Tbl_mf_tipo_movimientoTableAdapter As DB2DataSet1TableAdapters.tbl_mf_tipo_movimientoTableAdapter
    Friend WithEvents TpmtipotransDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TpmdescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
