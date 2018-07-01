Imports MySql.Data.MySqlClient
Public Class TamPengarang


    Public Sub RefreshGrid()
        Call Opencon()
        DTA = New MySqlDataAdapter("SELECT * FROM pengarang", koneksi)
        DTS = New DataSet
        DTA.Fill(DTS, "pengarang")
        datapengarang.DataSource = DTS.Tables("pengarang")
    End Sub


    Private Sub Tampengarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Call Opencon()
        Try
            Dim query, txtnama As String
            txtnama = namapengarang.Text

            query = "INSERT into pengarang (nama_pengarang) VALUES ('" & txtnama & "')"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Pengarang Berhasil Di Tambahkan")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Pengarang Gagal Di Tambahkan")

        End Try
        koneksi.Close()
    End Sub


    Private Sub Datapengarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datapengarang.CellClick
        Dim row As Integer
        row = datapengarang.SelectedCells(0).RowIndex
        namapengarang.Text = datapengarang.Rows(row).Cells(1).Value.ToString()
        idpengarang.Text = datapengarang.Rows(row).Cells(0).Value.ToString()

        koneksi.Close()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Opencon()
        Try
            Dim idkate, query, txtnama As String
            idkate = idpengarang.Text
            txtnama = namapengarang.Text

            query = "UPDATE Pengarang SET nama_Pengarang = '" & txtnama & "' WHERE id_Pengarang = '" & idkate & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Pengarang Berhasil Di Edit")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Data Pengarang Gagal Di Edit")

        End Try
        koneksi.Close()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Call Opencon()
        Try


            Dim query As String
            query = "Delete FROM Pengarang where id_Pengarang = '" & idpengarang.Text & "'"
            Console.WriteLine(query)
            CMD = New MySqlCommand(query, koneksi)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Pengarang Berhasil Di Hapus")
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Data Pengarang Gagal Di Hapus")
        End Try

        koneksi.Close()
    End Sub
End Class