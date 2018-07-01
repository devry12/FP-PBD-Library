Public Class Login


    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        If MessageBox.Show("Yakin Ingin Membatalkan Login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Logins_Click(sender As Object, e As EventArgs) Handles logins.Click
        Dim member, pass As String
        member = idmember.Text
        pass = password.Text

        If member.Equals("devry") And pass.Equals("devry") Then
            MessageBox.Show("berhasil Login")
        Else
            MessageBox.Show("gagal login")
        End If



    End Sub
End Class