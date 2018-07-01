<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbthnterbit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbpenerbit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbpengarang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbkategori = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.databuku = New System.Windows.Forms.DataGridView()
        Me.id_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_terbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_rak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LibraryDataSet = New Library_System.libraryDataSet()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuTableAdapter = New Library_System.libraryDataSetTableAdapters.bukuTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.databuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbthnterbit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbpenerbit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbpengarang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbkategori)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari Buku"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbthnterbit
        '
        Me.cbthnterbit.FormattingEnabled = True
        Me.cbthnterbit.Location = New System.Drawing.Point(528, 32)
        Me.cbthnterbit.Name = "cbthnterbit"
        Me.cbthnterbit.Size = New System.Drawing.Size(121, 21)
        Me.cbthnterbit.TabIndex = 3
        Me.cbthnterbit.Text = "Pilih"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tahun Terbit"
        '
        'cbpenerbit
        '
        Me.cbpenerbit.FormattingEnabled = True
        Me.cbpenerbit.Location = New System.Drawing.Point(401, 32)
        Me.cbpenerbit.Name = "cbpenerbit"
        Me.cbpenerbit.Size = New System.Drawing.Size(121, 21)
        Me.cbpenerbit.TabIndex = 3
        Me.cbpenerbit.Text = "Pilih"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Penerbit"
        '
        'cbpengarang
        '
        Me.cbpengarang.FormattingEnabled = True
        Me.cbpengarang.Location = New System.Drawing.Point(274, 33)
        Me.cbpengarang.Name = "cbpengarang"
        Me.cbpengarang.Size = New System.Drawing.Size(121, 21)
        Me.cbpengarang.TabIndex = 3
        Me.cbpengarang.Text = "Pilih"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "pengarang"
        '
        'cbkategori
        '
        Me.cbkategori.FormattingEnabled = True
        Me.cbkategori.Location = New System.Drawing.Point(147, 33)
        Me.cbkategori.Name = "cbkategori"
        Me.cbkategori.Size = New System.Drawing.Size(121, 21)
        Me.cbkategori.TabIndex = 3
        Me.cbkategori.Text = "Pilih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kategori"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.databuku)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'databuku
        '
        Me.databuku.AllowUserToAddRows = False
        Me.databuku.AllowUserToDeleteRows = False
        Me.databuku.AllowUserToOrderColumns = True
        Me.databuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_buku, Me.judul_buku, Me.id_kategori, Me.Penerbit, Me.id_pengarang, Me.tahun_terbit, Me.no_rak})
        Me.databuku.GridColor = System.Drawing.SystemColors.ControlLight
        Me.databuku.Location = New System.Drawing.Point(9, 19)
        Me.databuku.Name = "databuku"
        Me.databuku.ReadOnly = True
        Me.databuku.Size = New System.Drawing.Size(639, 150)
        Me.databuku.TabIndex = 0
        '
        'id_buku
        '
        Me.id_buku.HeaderText = "Id Buku"
        Me.id_buku.Name = "id_buku"
        Me.id_buku.ReadOnly = True
        '
        'judul_buku
        '
        Me.judul_buku.HeaderText = "Nama"
        Me.judul_buku.Name = "judul_buku"
        Me.judul_buku.ReadOnly = True
        '
        'id_kategori
        '
        Me.id_kategori.HeaderText = "Kategori"
        Me.id_kategori.Name = "id_kategori"
        Me.id_kategori.ReadOnly = True
        '
        'Penerbit
        '
        Me.Penerbit.HeaderText = "Penerbit"
        Me.Penerbit.Name = "Penerbit"
        Me.Penerbit.ReadOnly = True
        '
        'id_pengarang
        '
        Me.id_pengarang.HeaderText = "Pengarang"
        Me.id_pengarang.Name = "id_pengarang"
        Me.id_pengarang.ReadOnly = True
        '
        'tahun_terbit
        '
        Me.tahun_terbit.HeaderText = "Tahun Terbit"
        Me.tahun_terbit.Name = "tahun_terbit"
        Me.tahun_terbit.ReadOnly = True
        '
        'no_rak
        '
        Me.no_rak.HeaderText = "Nomer Rak"
        Me.no_rak.Name = "no_rak"
        Me.no_rak.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "libraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "buku"
        Me.BukuBindingSource.DataSource = Me.LibraryDataSet
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 356)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Search"
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.databuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbthnterbit As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbpenerbit As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbpengarang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbkategori As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents databuku As DataGridView
    Friend WithEvents id_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul_buku As DataGridViewTextBoxColumn
    Friend WithEvents id_kategori As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents id_pengarang As DataGridViewTextBoxColumn
    Friend WithEvents tahun_terbit As DataGridViewTextBoxColumn
    Friend WithEvents no_rak As DataGridViewTextBoxColumn
    Friend WithEvents LibraryDataSet As libraryDataSet
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As libraryDataSetTableAdapters.bukuTableAdapter
End Class
