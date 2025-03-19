Imports MySql.Data.MySqlClient
Public Class gantipass
    Dim strkon As String = "server=localhost;uid=root;database=ramart"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "update username set userpass =md5('" & txtpb.Text & "') where userfullname = '" & Label4.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("PASSWORD DIGANTI", MsgBoxStyle.Information, "Pesan")
        Button1.Enabled = False
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        menu_utama.Show()
    End Sub
End Class