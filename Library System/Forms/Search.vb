Public Class Search
    Public Function Fkategori() As String()
        Dim kategori() As String = {"Novel", "Ilmu Pengetahuan", "Sains", "pemrograman"}
        Return kategori
    End Function

    Public Sub RefreshGrid()
        DTGrid = books.SelectBook.ToTable
        databuku.DataSource = DTGrid
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.LibraryDataSet.buku)
        RefreshGrid()
    End Sub
End Class