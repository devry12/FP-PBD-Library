Public Class Buku
    Private nama As String
    Private kategori As Integer
    Private penerbit As Integer
    Private pengarang As Integer
    Private thnterbit As Date

    Public Property NamaBuku() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property Kategori1 As Integer
        Get
            Return kategori
        End Get
        Set(value As Integer)
            kategori = value
        End Set
    End Property

    Public Property Penerbit1 As Integer
        Get
            Return penerbit
        End Get
        Set(value As Integer)
            penerbit = value
        End Set
    End Property

    Public Property Pengarang1 As Integer
        Get
            Return pengarang
        End Get
        Set(value As Integer)
            pengarang = value
        End Set
    End Property

    Public Property Thnterbit1 As Date
        Get
            Return thnterbit
        End Get
        Set(value As Date)
            thnterbit = value
        End Set
    End Property
End Class
