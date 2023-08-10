<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TbAbsenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBAbsensiDataSet = New AbsensiPegawaiTA.DBAbsensiDataSet()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbAbsenTableAdapter = New AbsensiPegawaiTA.DBAbsensiDataSetTableAdapters.TbAbsenTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TbAbsenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBAbsensiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAbsenBindingSource, "tanggal", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker1.TabIndex = 28
        '
        'TbAbsenBindingSource
        '
        Me.TbAbsenBindingSource.DataMember = "TbAbsen"
        Me.TbAbsenBindingSource.DataSource = Me.DBAbsensiDataSet
        '
        'DBAbsensiDataSet
        '
        Me.DBAbsensiDataSet.DataSetName = "DBAbsensiDataSet"
        Me.DBAbsensiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAbsenBindingSource, "keterangan", True))
        Me.TextBox5.Location = New System.Drawing.Point(108, 236)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(184, 20)
        Me.TextBox5.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tanggal"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAbsenBindingSource, "jabatan", True))
        Me.TextBox3.Location = New System.Drawing.Point(108, 159)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 20)
        Me.TextBox3.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jabatan"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAbsenBindingSource, "nama_karyawan", True))
        Me.TextBox2.Location = New System.Drawing.Point(108, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 20)
        Me.TextBox2.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 37)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Absen Karyawan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(217, 285)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "Save"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamakaryawanDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbAbsenBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(328, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 232)
        Me.DataGridView1.TabIndex = 32
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NamakaryawanDataGridViewTextBoxColumn
        '
        Me.NamakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.HeaderText = "nama_karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.Name = "NamakaryawanDataGridViewTextBoxColumn"
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'TbAbsenTableAdapter
        '
        Me.TbAbsenTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.TbAbsenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBAbsensiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBAbsensiDataSet As DBAbsensiDataSet
    Friend WithEvents TbAbsenBindingSource As BindingSource
    Friend WithEvents TbAbsenTableAdapter As DBAbsensiDataSetTableAdapters.TbAbsenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
