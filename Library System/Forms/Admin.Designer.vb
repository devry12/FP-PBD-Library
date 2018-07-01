<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.databuku = New System.Windows.Forms.DataGridView()
        Me.Tambah_gb = New System.Windows.Forms.GroupBox()
        Me.batalAdd = New System.Windows.Forms.Button()
        Me.simpanAdd = New System.Windows.Forms.Button()
        Me.cmbNorakAdd = New System.Windows.Forms.ComboBox()
        Me.cmbThnterbitAdd = New System.Windows.Forms.ComboBox()
        Me.cmbPengarangAdd = New System.Windows.Forms.ComboBox()
        Me.cmbPenerbitAdd = New System.Windows.Forms.ComboBox()
        Me.cmbKategoriAdd = New System.Windows.Forms.ComboBox()
        Me.norak = New System.Windows.Forms.Label()
        Me.txtNamaAdd = New System.Windows.Forms.TextBox()
        Me.thnterbit_add_lbl = New System.Windows.Forms.Label()
        Me.pengarang_add_lbl = New System.Windows.Forms.Label()
        Me.penerbit_add_lbl = New System.Windows.Forms.Label()
        Me.kategori_add_lbl = New System.Windows.Forms.Label()
        Me.nama_add_lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hapus = New System.Windows.Forms.Button()
        Me.BatalEdit = New System.Windows.Forms.Button()
        Me.SimpanEdit = New System.Windows.Forms.Button()
        Me.cmbNorakEdit = New System.Windows.Forms.ComboBox()
        Me.cmbThnterbitEdit = New System.Windows.Forms.ComboBox()
        Me.cmbPengarangEdit = New System.Windows.Forms.ComboBox()
        Me.cmbPenerbitEdit = New System.Windows.Forms.ComboBox()
        Me.cmbKategoriEdit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdbukuEdit = New System.Windows.Forms.TextBox()
        Me.txtNamaEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerbitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menustrip = New System.Windows.Forms.MenuStrip()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.databuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tambah_gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'databuku
        '
        Me.databuku.AllowUserToAddRows = False
        Me.databuku.AllowUserToDeleteRows = False
        Me.databuku.AllowUserToOrderColumns = True
        Me.databuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databuku.GridColor = System.Drawing.SystemColors.ControlLight
        Me.databuku.Location = New System.Drawing.Point(12, 302)
        Me.databuku.Name = "databuku"
        Me.databuku.ReadOnly = True
        Me.databuku.Size = New System.Drawing.Size(684, 132)
        Me.databuku.TabIndex = 1
        '
        'Tambah_gb
        '
        Me.Tambah_gb.Controls.Add(Me.batalAdd)
        Me.Tambah_gb.Controls.Add(Me.simpanAdd)
        Me.Tambah_gb.Controls.Add(Me.cmbNorakAdd)
        Me.Tambah_gb.Controls.Add(Me.cmbThnterbitAdd)
        Me.Tambah_gb.Controls.Add(Me.cmbPengarangAdd)
        Me.Tambah_gb.Controls.Add(Me.cmbPenerbitAdd)
        Me.Tambah_gb.Controls.Add(Me.cmbKategoriAdd)
        Me.Tambah_gb.Controls.Add(Me.norak)
        Me.Tambah_gb.Controls.Add(Me.txtNamaAdd)
        Me.Tambah_gb.Controls.Add(Me.thnterbit_add_lbl)
        Me.Tambah_gb.Controls.Add(Me.pengarang_add_lbl)
        Me.Tambah_gb.Controls.Add(Me.penerbit_add_lbl)
        Me.Tambah_gb.Controls.Add(Me.kategori_add_lbl)
        Me.Tambah_gb.Controls.Add(Me.nama_add_lbl)
        Me.Tambah_gb.Location = New System.Drawing.Point(12, 31)
        Me.Tambah_gb.Name = "Tambah_gb"
        Me.Tambah_gb.Size = New System.Drawing.Size(266, 238)
        Me.Tambah_gb.TabIndex = 2
        Me.Tambah_gb.TabStop = False
        Me.Tambah_gb.Text = "Tambah"
        '
        'batalAdd
        '
        Me.batalAdd.Location = New System.Drawing.Point(104, 183)
        Me.batalAdd.Name = "batalAdd"
        Me.batalAdd.Size = New System.Drawing.Size(75, 23)
        Me.batalAdd.TabIndex = 4
        Me.batalAdd.Text = "Batal"
        Me.batalAdd.UseVisualStyleBackColor = True
        '
        'simpanAdd
        '
        Me.simpanAdd.Location = New System.Drawing.Point(185, 183)
        Me.simpanAdd.Name = "simpanAdd"
        Me.simpanAdd.Size = New System.Drawing.Size(75, 23)
        Me.simpanAdd.TabIndex = 4
        Me.simpanAdd.Text = "Simpan"
        Me.simpanAdd.UseVisualStyleBackColor = True
        '
        'cmbNorakAdd
        '
        Me.cmbNorakAdd.FormattingEnabled = True
        Me.cmbNorakAdd.Items.AddRange(New Object() {"1", "2", "4", "5", "6", "7", "8", "9"})
        Me.cmbNorakAdd.Location = New System.Drawing.Point(113, 148)
        Me.cmbNorakAdd.Name = "cmbNorakAdd"
        Me.cmbNorakAdd.Size = New System.Drawing.Size(147, 21)
        Me.cmbNorakAdd.TabIndex = 3
        Me.cmbNorakAdd.Text = "Pilih"
        '
        'cmbThnterbitAdd
        '
        Me.cmbThnterbitAdd.FormattingEnabled = True
        Me.cmbThnterbitAdd.Items.AddRange(New Object() {"2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbThnterbitAdd.Location = New System.Drawing.Point(113, 121)
        Me.cmbThnterbitAdd.Name = "cmbThnterbitAdd"
        Me.cmbThnterbitAdd.Size = New System.Drawing.Size(147, 21)
        Me.cmbThnterbitAdd.TabIndex = 3
        Me.cmbThnterbitAdd.Text = "Pilih"
        '
        'cmbPengarangAdd
        '
        Me.cmbPengarangAdd.FormattingEnabled = True
        Me.cmbPengarangAdd.Location = New System.Drawing.Point(113, 96)
        Me.cmbPengarangAdd.Name = "cmbPengarangAdd"
        Me.cmbPengarangAdd.Size = New System.Drawing.Size(147, 21)
        Me.cmbPengarangAdd.TabIndex = 3
        Me.cmbPengarangAdd.Text = "Pilih"
        '
        'cmbPenerbitAdd
        '
        Me.cmbPenerbitAdd.FormattingEnabled = True
        Me.cmbPenerbitAdd.Location = New System.Drawing.Point(113, 69)
        Me.cmbPenerbitAdd.Name = "cmbPenerbitAdd"
        Me.cmbPenerbitAdd.Size = New System.Drawing.Size(147, 21)
        Me.cmbPenerbitAdd.TabIndex = 3
        Me.cmbPenerbitAdd.Text = "Pilih"
        '
        'cmbKategoriAdd
        '
        Me.cmbKategoriAdd.FormattingEnabled = True
        Me.cmbKategoriAdd.Location = New System.Drawing.Point(113, 43)
        Me.cmbKategoriAdd.Name = "cmbKategoriAdd"
        Me.cmbKategoriAdd.Size = New System.Drawing.Size(147, 21)
        Me.cmbKategoriAdd.TabIndex = 3
        Me.cmbKategoriAdd.Text = "Pilih"
        '
        'norak
        '
        Me.norak.AutoSize = True
        Me.norak.Location = New System.Drawing.Point(6, 151)
        Me.norak.Name = "norak"
        Me.norak.Size = New System.Drawing.Size(61, 13)
        Me.norak.TabIndex = 1
        Me.norak.Text = "Nomer Rak"
        '
        'txtNamaAdd
        '
        Me.txtNamaAdd.Location = New System.Drawing.Point(113, 16)
        Me.txtNamaAdd.Name = "txtNamaAdd"
        Me.txtNamaAdd.Size = New System.Drawing.Size(147, 20)
        Me.txtNamaAdd.TabIndex = 2
        Me.txtNamaAdd.Tag = ""
        '
        'thnterbit_add_lbl
        '
        Me.thnterbit_add_lbl.AutoSize = True
        Me.thnterbit_add_lbl.Location = New System.Drawing.Point(6, 124)
        Me.thnterbit_add_lbl.Name = "thnterbit_add_lbl"
        Me.thnterbit_add_lbl.Size = New System.Drawing.Size(68, 13)
        Me.thnterbit_add_lbl.TabIndex = 1
        Me.thnterbit_add_lbl.Text = "Tahun Terbit"
        '
        'pengarang_add_lbl
        '
        Me.pengarang_add_lbl.AutoSize = True
        Me.pengarang_add_lbl.Location = New System.Drawing.Point(6, 99)
        Me.pengarang_add_lbl.Name = "pengarang_add_lbl"
        Me.pengarang_add_lbl.Size = New System.Drawing.Size(59, 13)
        Me.pengarang_add_lbl.TabIndex = 1
        Me.pengarang_add_lbl.Text = "Pengarang"
        '
        'penerbit_add_lbl
        '
        Me.penerbit_add_lbl.AutoSize = True
        Me.penerbit_add_lbl.Location = New System.Drawing.Point(6, 72)
        Me.penerbit_add_lbl.Name = "penerbit_add_lbl"
        Me.penerbit_add_lbl.Size = New System.Drawing.Size(46, 13)
        Me.penerbit_add_lbl.TabIndex = 1
        Me.penerbit_add_lbl.Text = "Penerbit"
        '
        'kategori_add_lbl
        '
        Me.kategori_add_lbl.AutoSize = True
        Me.kategori_add_lbl.Location = New System.Drawing.Point(6, 46)
        Me.kategori_add_lbl.Name = "kategori_add_lbl"
        Me.kategori_add_lbl.Size = New System.Drawing.Size(46, 13)
        Me.kategori_add_lbl.TabIndex = 1
        Me.kategori_add_lbl.Text = "Kategori"
        '
        'nama_add_lbl
        '
        Me.nama_add_lbl.AutoSize = True
        Me.nama_add_lbl.Location = New System.Drawing.Point(6, 19)
        Me.nama_add_lbl.Name = "nama_add_lbl"
        Me.nama_add_lbl.Size = New System.Drawing.Size(35, 13)
        Me.nama_add_lbl.TabIndex = 0
        Me.nama_add_lbl.Text = "Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hapus)
        Me.GroupBox1.Controls.Add(Me.BatalEdit)
        Me.GroupBox1.Controls.Add(Me.SimpanEdit)
        Me.GroupBox1.Controls.Add(Me.cmbNorakEdit)
        Me.GroupBox1.Controls.Add(Me.cmbThnterbitEdit)
        Me.GroupBox1.Controls.Add(Me.cmbPengarangEdit)
        Me.GroupBox1.Controls.Add(Me.cmbPenerbitEdit)
        Me.GroupBox1.Controls.Add(Me.cmbKategoriEdit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdbukuEdit)
        Me.GroupBox1.Controls.Add(Me.txtNamaEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 238)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(23, 209)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 4
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'BatalEdit
        '
        Me.BatalEdit.Location = New System.Drawing.Point(104, 209)
        Me.BatalEdit.Name = "BatalEdit"
        Me.BatalEdit.Size = New System.Drawing.Size(75, 23)
        Me.BatalEdit.TabIndex = 4
        Me.BatalEdit.Text = "Batal"
        Me.BatalEdit.UseVisualStyleBackColor = True
        '
        'SimpanEdit
        '
        Me.SimpanEdit.Location = New System.Drawing.Point(185, 209)
        Me.SimpanEdit.Name = "SimpanEdit"
        Me.SimpanEdit.Size = New System.Drawing.Size(75, 23)
        Me.SimpanEdit.TabIndex = 4
        Me.SimpanEdit.Text = "Simpan"
        Me.SimpanEdit.UseVisualStyleBackColor = True
        '
        'cmbNorakEdit
        '
        Me.cmbNorakEdit.FormattingEnabled = True
        Me.cmbNorakEdit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbNorakEdit.Location = New System.Drawing.Point(113, 171)
        Me.cmbNorakEdit.Name = "cmbNorakEdit"
        Me.cmbNorakEdit.Size = New System.Drawing.Size(147, 21)
        Me.cmbNorakEdit.TabIndex = 3
        Me.cmbNorakEdit.Text = "Pilih"
        '
        'cmbThnterbitEdit
        '
        Me.cmbThnterbitEdit.FormattingEnabled = True
        Me.cmbThnterbitEdit.Items.AddRange(New Object() {"2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbThnterbitEdit.Location = New System.Drawing.Point(113, 144)
        Me.cmbThnterbitEdit.Name = "cmbThnterbitEdit"
        Me.cmbThnterbitEdit.Size = New System.Drawing.Size(147, 21)
        Me.cmbThnterbitEdit.TabIndex = 3
        '
        'cmbPengarangEdit
        '
        Me.cmbPengarangEdit.FormattingEnabled = True
        Me.cmbPengarangEdit.Location = New System.Drawing.Point(113, 119)
        Me.cmbPengarangEdit.Name = "cmbPengarangEdit"
        Me.cmbPengarangEdit.Size = New System.Drawing.Size(147, 21)
        Me.cmbPengarangEdit.TabIndex = 3
        '
        'cmbPenerbitEdit
        '
        Me.cmbPenerbitEdit.FormattingEnabled = True
        Me.cmbPenerbitEdit.Location = New System.Drawing.Point(113, 92)
        Me.cmbPenerbitEdit.Name = "cmbPenerbitEdit"
        Me.cmbPenerbitEdit.Size = New System.Drawing.Size(147, 21)
        Me.cmbPenerbitEdit.TabIndex = 3
        '
        'cmbKategoriEdit
        '
        Me.cmbKategoriEdit.FormattingEnabled = True
        Me.cmbKategoriEdit.Location = New System.Drawing.Point(113, 66)
        Me.cmbKategoriEdit.Name = "cmbKategoriEdit"
        Me.cmbKategoriEdit.Size = New System.Drawing.Size(147, 21)
        Me.cmbKategoriEdit.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nomer Rak"
        '
        'txtIdbukuEdit
        '
        Me.txtIdbukuEdit.Enabled = False
        Me.txtIdbukuEdit.Location = New System.Drawing.Point(113, 16)
        Me.txtIdbukuEdit.Name = "txtIdbukuEdit"
        Me.txtIdbukuEdit.Size = New System.Drawing.Size(147, 20)
        Me.txtIdbukuEdit.TabIndex = 2
        '
        'txtNamaEdit
        '
        Me.txtNamaEdit.Location = New System.Drawing.Point(113, 39)
        Me.txtNamaEdit.Name = "txtNamaEdit"
        Me.txtNamaEdit.Size = New System.Drawing.Size(147, 20)
        Me.txtNamaEdit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tahun Terbit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pengarang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Id Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KategoriToolStripMenuItem, Me.PenerbitToolStripMenuItem, Me.PengarangToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'PenerbitToolStripMenuItem
        '
        Me.PenerbitToolStripMenuItem.Name = "PenerbitToolStripMenuItem"
        Me.PenerbitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenerbitToolStripMenuItem.Text = "Penerbit"
        '
        'PengarangToolStripMenuItem
        '
        Me.PengarangToolStripMenuItem.Name = "PengarangToolStripMenuItem"
        Me.PengarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PengarangToolStripMenuItem.Text = "Pengarang"
        '
        'Menustrip
        '
        Me.Menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.Menustrip.Location = New System.Drawing.Point(0, 0)
        Me.Menustrip.Name = "Menustrip"
        Me.Menustrip.Size = New System.Drawing.Size(593, 24)
        Me.Menustrip.TabIndex = 3
        Me.Menustrip.Text = "MenuStrip1"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tambah_gb)
        Me.Controls.Add(Me.databuku)
        Me.Controls.Add(Me.Menustrip)
        Me.MainMenuStrip = Me.Menustrip
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.databuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tambah_gb.ResumeLayout(False)
        Me.Tambah_gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Menustrip.ResumeLayout(False)
        Me.Menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents databuku As DataGridView
    Friend WithEvents Tambah_gb As GroupBox
    Friend WithEvents txtNamaAdd As TextBox
    Friend WithEvents thnterbit_add_lbl As Label
    Friend WithEvents pengarang_add_lbl As Label
    Friend WithEvents penerbit_add_lbl As Label
    Friend WithEvents kategori_add_lbl As Label
    Friend WithEvents nama_add_lbl As Label
    Friend WithEvents batalAdd As Button
    Friend WithEvents simpanAdd As Button
    Friend WithEvents cmbThnterbitAdd As ComboBox
    Friend WithEvents cmbPengarangAdd As ComboBox
    Friend WithEvents cmbPenerbitAdd As ComboBox
    Friend WithEvents cmbKategoriAdd As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BatalEdit As Button
    Friend WithEvents SimpanEdit As Button
    Friend WithEvents cmbThnterbitEdit As ComboBox
    Friend WithEvents cmbPengarangEdit As ComboBox
    Friend WithEvents cmbPenerbitEdit As ComboBox
    Friend WithEvents cmbKategoriEdit As ComboBox
    Friend WithEvents txtNamaEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbNorakAdd As ComboBox
    Friend WithEvents norak As Label
    Friend WithEvents txtIdbukuEdit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbNorakEdit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenerbitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menustrip As MenuStrip
    Friend WithEvents hapus As Button
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
End Class
