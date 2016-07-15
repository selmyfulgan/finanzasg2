<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bancos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblmfempresaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New finanzasg2.DataSet1()
        Me.TblmfempresaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New finanzasg2.DataSet3()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DB2DataSet = New finanzasg2.DB2DataSet()
        Me.TblmfempresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_mf_empresaTableAdapter = New finanzasg2.DB2DataSetTableAdapters.tbl_mf_empresaTableAdapter()
        Me.Tbl_mf_empresaTableAdapter2 = New finanzasg2.DataSet3TableAdapters.tbl_mf_empresaTableAdapter()
        Me.Tbl_mf_empresaTableAdapter3 = New finanzasg2.DataSet1TableAdapters.tbl_mf_empresaTableAdapter()
        Me.DataSet2 = New finanzasg2.DataSet2()
        Me.TblmfempresaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_mf_empresaTableAdapter1 = New finanzasg2.DataSet2TableAdapters.tbl_mf_empresaTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblmfempresaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmfempresaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DB2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmfempresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmfempresaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 487)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 73)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(441, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 62)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(522, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 62)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(600, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 61)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ingrese Entidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seleccione empresa"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"La costeña", "La paca"})
        Me.ComboBox1.Location = New System.Drawing.Point(182, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'TblmfempresaBindingSource3
        '
        Me.TblmfempresaBindingSource3.DataMember = "tbl_mf_empresa"
        Me.TblmfempresaBindingSource3.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmfempresaBindingSource2
        '
        Me.TblmfempresaBindingSource2.DataMember = "tbl_mf_empresa"
        Me.TblmfempresaBindingSource2.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 197)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de entidades bancarias"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(182, 118)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha apertura"
        '
        'DB2DataSet
        '
        Me.DB2DataSet.DataSetName = "DB2DataSet"
        Me.DB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmfempresaBindingSource
        '
        Me.TblmfempresaBindingSource.DataMember = "tbl_mf_empresa"
        Me.TblmfempresaBindingSource.DataSource = Me.DB2DataSet
        '
        'Tbl_mf_empresaTableAdapter
        '
        Me.Tbl_mf_empresaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_mf_empresaTableAdapter2
        '
        Me.Tbl_mf_empresaTableAdapter2.ClearBeforeFill = True
        '
        'Tbl_mf_empresaTableAdapter3
        '
        Me.Tbl_mf_empresaTableAdapter3.ClearBeforeFill = True
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmfempresaBindingSource1
        '
        Me.TblmfempresaBindingSource1.DataMember = "tbl_mf_empresa"
        Me.TblmfempresaBindingSource1.DataSource = Me.DataSet2
        '
        'Tbl_mf_empresaTableAdapter1
        '
        Me.Tbl_mf_empresaTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(572, 173)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado Bancos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(566, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'Bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(676, 560)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Bancos"
        Me.Text = "Bancos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TblmfempresaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmfempresaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DB2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmfempresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmfempresaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DB2DataSet As DB2DataSet
    Friend WithEvents TblmfempresaBindingSource As BindingSource
    Friend WithEvents Tbl_mf_empresaTableAdapter As DB2DataSetTableAdapters.tbl_mf_empresaTableAdapter
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents TblmfempresaBindingSource1 As BindingSource
    Friend WithEvents Tbl_mf_empresaTableAdapter1 As DataSet2TableAdapters.tbl_mf_empresaTableAdapter
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents TblmfempresaBindingSource2 As BindingSource
    Friend WithEvents Tbl_mf_empresaTableAdapter2 As DataSet3TableAdapters.tbl_mf_empresaTableAdapter
    Friend WithEvents TblmfempresaBindingSource3 As BindingSource
    Friend WithEvents Tbl_mf_empresaTableAdapter3 As DataSet1TableAdapters.tbl_mf_empresaTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
