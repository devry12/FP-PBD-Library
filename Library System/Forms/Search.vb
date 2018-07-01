Public Class Search
    Public Function Fkategori() As String()
        Dim kategori() As String = {"Novel", "Ilmu Pengetahuan", "Sains", "pemrograman"}
        Return kategori
    End Function

    Public Sub RefreshGrid()

    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.LibraryDataSet.buku)
        RefreshGrid()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub databuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles databuku.CellContentClick

    End Sub
End Class