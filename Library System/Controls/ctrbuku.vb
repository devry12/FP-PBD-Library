Imports Library_System
Imports MySql.Data.MySqlClient

Public Class Ctrbuku : Implements INFproses

    Public Function SelectBook() As DataView Implements INFproses.SelectBook
        Try


            DTA = New MySqlDataAdapter("SELECT * FROM buku", Opencon)
            DTS = New DataSet()
            DTA.Fill(DTS, "SearchBook")
            Dim grid As New DataView(DTS.Tables("SearchBook"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
