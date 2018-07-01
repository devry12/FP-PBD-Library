<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tamkategori
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
        Me.datakategori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.lblidkat = New System.Windows.Forms.Label()
        Me.idkat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namakategori = New System.Windows.Forms.TextBox()
        CType(Me.datakategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datakategori
        '
        Me.datakategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datakategori.Location = New System.Drawing.Point(15, 134)
        Me.datakategori.Name = "datakategori"
        Me.datakategori.Size = New System.Drawing.Size(240, 126)
        Me.datakategori.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Hapus)
        Me.GroupBox1.Controls.Add(Me.edit)
        Me.GroupBox1.Controls.Add(Me.tambah)
        Me.GroupBox1.Controls.Add(Me.lblidkat)
        Me.GroupBox1.Controls.Add(Me.idkat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.namakategori)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(7, 78)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Hapus.TabIndex = 2
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(88, 78)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 2
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(169, 78)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(75, 23)
        Me.tambah.TabIndex = 2
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'lblidkat
        '
        Me.lblidkat.AutoSize = True
        Me.lblidkat.Location = New System.Drawing.Point(7, 16)
        Me.lblidkat.Name = "lblidkat"
        Me.lblidkat.Size = New System.Drawing.Size(58, 13)
        Me.lblidkat.TabIndex = 1
        Me.lblidkat.Text = "Id Kategori"
        '
        'idkat
        '
        Me.idkat.Enabled = False
        Me.idkat.Location = New System.Drawing.Point(144, 13)
        Me.idkat.Name = "idkat"
        Me.idkat.Size = New System.Drawing.Size(100, 20)
        Me.idkat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Kategori"
        '
        'namakategori
        '
        Me.namakategori.Location = New System.Drawing.Point(143, 39)
        Me.namakategori.Name = "namakategori"
        Me.namakategori.Size = New System.Drawing.Size(100, 20)
        Me.namakategori.TabIndex = 0
        '
        'tamkategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 274)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datakategori)
        Me.Name = "tamkategori"
        Me.Text = "tamkategori"
        CType(Me.datakategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datakategori As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents namakategori As TextBox
    Friend WithEvents Hapus As Button
    Friend WithEvents edit As Button
    Friend WithEvents tambah As Button
    Friend WithEvents lblidkat As Label
    Friend WithEvents idkat As TextBox
End Class
