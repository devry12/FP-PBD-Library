Imports MySql.Data.MySqlClient
Public Class Admin
    Public Sub RefreshGrid()
        Call Opencon()
        DTA = New MySqlDataAdapter("SELECT buku.id_buku, buku.judul_buku,kategori.nama_kategori,pengarang.nama_pengarang,penerbit.nama_penerbit,buku.tahun_terbit,buku.no_rak FROM buku,kategori,pengarang,penerbit WHERE buku.id_kategori = kategori.id_kategori AND buku.id_penerbit = penerbit.id_penerbit AND buku.id_pengarang = pengarang.id_pengarang
", koneksi)
        DTS = New DataSet
        DTA.Fill(DTS, "buku")
        databuku.DataSource = DTS.Tables("buku")
    End Sub

    Public Sub TampkategoriAdd()
        Call Opencon()
        CMD = New MySqlCommand("select * from kategori", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbKategoriAdd.Items.Add(DTR("id_kategori") & " - " & DTR("nama_kategori"))
        Loop
        koneksi.Close()
    End Sub
    Public Sub TampPenerbitAdd()
        Call Opencon()
        CMD = New MySqlCommand("select * from penerbit", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbPenerbitAdd.Items.Add(DTR("id_penerbit") & " - " & DTR("nama_penerbit"))
        Loop
        koneksi.Close()
    End Sub

    Public Sub TampPengarangAdd()
        Call Opencon()
        CMD = New MySqlCommand("select * from pengarang", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbPengarangAdd.Items.Add(DTR("id_pengarang") & " - " & DTR("nama_pengarang"))
        Loop
        koneksi.Close()
    End Sub

    Public Sub TampkategoriEdit()
        Call Opencon()
        CMD = New MySqlCommand("select * from kategori", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbKategoriEdit.Items.Add(DTR("id_kategori") & " - " & DTR("nama_kategori"))
        Loop
        koneksi.Close()
    End Sub
    Public Sub TampPenerbitEdit()
        Call Opencon()
        CMD = New MySqlCommand("select * from penerbit", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbPenerbitEdit.Items.Add(DTR("id_penerbit") & " - " & DTR("nama_penerbit"))
        Loop
        koneksi.Close()
    End Sub

    Public Sub TampPengarangEdit()
        Call Opencon()
        CMD = New MySqlCommand("select * from pengarang", koneksi)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbPengarangEdit.Items.Add(DTR("id_pengarang") & " - " & DTR("nama_pengarang"))
        Loop
        koneksi.Close()
    End Sub

    Public Sub AktifAdd()
        cmbKategoriAdd.Enabled = True
        cmbPenerbitAdd.Enabled = True
        cmbPengarangAdd.Enabled = True
        cmbThnterbitAdd.Enabled = True
    End Sub



    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TampkategoriAdd()
        TampPenerbitAdd()
        TampPengarangAdd()
        TampkategoriEdit()
        TampPenerbitEdit()
        TampPengarangEdit()

    End Sub


    Private Sub SimpanAdd_Click(sender As Object, e As EventArgs) Handles simpanAdd.Click
        Call Opencon()
        Try
            Dim query, txtnama, kateno, penerno, pengarno, thnterbit, norak As String
            txtnama = txtNamaAdd.Text
            kateno = cmbKategoriAdd.SelectedItem
            penerno = cmbPenerbitAdd.SelectedItem
            pengarno = cmbPengarangAdd.SelectedItem
            pengarno = cmbPengarangAdd.SelectedItem
            thnterbit = cmbThnterbitAdd.SelectedItem
            norak = cmbNorakAdd.SelectedItem

            kateno = Strings.Left(kateno, 1)
            penerno = Strings.Left(penerno, 1)
            pengarno = Strings.Left(pengarno, 1)

            query = "INSERT into buku (judul_buku,id_kategori,id_penerbit,id_pengarang,tahun_terbit,no_rak) VALUES ('" & txtnama & "'," & kateno & "," & penerno & "," & pengarno & ",'" & thnterbit & "'," & norak & ")"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Buku Berhasil Di Tambahkan")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Buku Gagal Di Tambahkan")

        End Try
        koneksi.Close()
    End Sub

    Private Sub Databuku_CelltClick(sender As Object, e As DataGridViewCellEventArgs) Handles databuku.CellContentClick
        Dim row As Integer
        row = databuku.SelectedCells(0).RowIndex
        txtIdbukuEdit.Text = databuku.Rows(row).Cells(0).Value.ToString()
        txtNamaEdit.Text = databuku.Rows(row).Cells(1).Value.ToString()
        Call Opencon()
        Dim query As String
        query = "SELECT * FROM buku WHERE id_buku = '" & txtIdbukuEdit.Text & "'"
        CMD = New MySqlCommand(query, koneksi)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            Dim kik, kipg, kiper, kin As Integer
            kik = DTR.Item(2) - 1
            kipg = DTR.Item(3) - 1
            kiper = DTR.Item(4) - 1
            kin = DTR.Item(6) - 1
            cmbKategoriEdit.SelectedIndex = kik
            cmbPenerbitEdit.SelectedIndex = kipg
            cmbPengarangEdit.SelectedIndex = kiper
            cmbThnterbitEdit.SelectedText = DTR.Item(5)
            cmbNorakEdit.SelectedIndex = kin
        End If
        koneksi.Close()
    End Sub

    Private Sub SimpanEdit_Click(sender As Object, e As EventArgs) Handles SimpanEdit.Click
        Call Opencon()
        Try
            Dim idbuk, query, txtnama, kateno, penerno, pengarno, thnterbit, norak As String
            idbuk = txtIdbukuEdit.Text
            txtnama = txtNamaEdit.Text
            kateno = cmbKategoriEdit.SelectedItem
            penerno = cmbPenerbitEdit.SelectedItem
            pengarno = cmbPengarangEdit.SelectedItem
            pengarno = cmbPengarangEdit.SelectedItem
            thnterbit = cmbThnterbitEdit.SelectedItem
            norak = cmbNorakEdit.SelectedItem

            kateno = Strings.Left(kateno, 1)
            penerno = Strings.Left(penerno, 1)
            pengarno = Strings.Left(pengarno, 1)

            query = "UPDATE buku SET judul_buku = '" & txtnama & "',id_kategori = " & kateno & ", id_penerbit = " & penerno & ",id_pengarang = " & pengarno & ", tahun_terbit = '" & thnterbit & "',no_rak = " & norak & " WHERE id_buku = '" & idbuk & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Buku Berhasil Di Edit")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Buku Gagal Di Edit")

        End Try
        koneksi.Close()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Opencon()
        Try


            Dim query As String
            query = "Delete FROM buku where id_buku = '" & txtIdbukuEdit.Text & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Buku Berhasil Di Hapus")
            RefreshGrid()

        Catch ex As Exception

        End Try

        koneksi.Close()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        Dim kategori As Form
        kategori = New tamkategori
        kategori.Show()
    End Sub

    Private Sub PengarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengarangToolStripMenuItem.Click
        Dim kategori As Form
        kategori = New TamPengarang
        kategori.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click

    End Sub
End Class