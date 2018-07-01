Imports MySql.Data.MySqlClient
Public Class tamkategori

    Public Sub RefreshGrid()
        Call Opencon()
        DTA = New MySqlDataAdapter("SELECT * FROM kategori", koneksi)
        DTS = New DataSet
        DTA.Fill(DTS, "kategori")
        datakategori.DataSource = DTS.Tables("kategori")
    End Sub


    Private Sub Tamkategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Call Opencon()
        Try
            Dim query, txtnama As String
            txtnama = namakategori.Text

            query = "INSERT into kategori (nama_kategori) VALUES ('" & txtnama & "')"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Kategori Berhasil Di Tambahkan")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Kategori Gagal Di Tambahkan")

        End Try
        koneksi.Close()
    End Sub


    Private Sub Datakategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datakategori.CellClick
        Dim row As Integer
        row = datakategori.SelectedCells(0).RowIndex
        namakategori.Text = datakategori.Rows(row).Cells(1).Value.ToString()
        idkat.Text = datakategori.Rows(row).Cells(0).Value.ToString()

        koneksi.Close()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Opencon()
        Try
            Dim idkate, query, txtnama As String
            idkate = idkat.Text
            txtnama = namakategori.Text

            query = "UPDATE kategori SET nama_kategori = '" & txtnama & "' WHERE id_kategori = '" & idkate & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Kategori Berhasil Di Edit")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Kategori Gagal Di Edit")

        End Try
        koneksi.Close()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Call Opencon()
        Try


            Dim query As String
            query = "Delete FROM kategori where id_kategori = '" & idkat.Text & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Kategori Berhasil Di Hapus")
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Data Kategori Gagal Di Hapus")
        End Try

        koneksi.Close()
    End Sub
End Class