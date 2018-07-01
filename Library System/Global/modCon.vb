
Imports MySql.Data.MySqlClient
Module modCon

    Public conn As New MySqlConnection
    Public CMD As New MySqlCommand
    Public DTA As New MySqlDataAdapter
    Public DTS As New DataSet
    Public DTR As MySqlDataReader
    Public DTGrid As New DataTable
    Public str = "Server=localhost;Database=library;SslMode=none;User ID=root;Password=;Pooling=False;Connection Timeout=10;Protocol=socket;Port=3307;"
    Public koneksi As New MySqlConnection(str)

    Public Function Opencon() As MySqlConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception

        End Try
        Return koneksi
    End Function


    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub

End Module
