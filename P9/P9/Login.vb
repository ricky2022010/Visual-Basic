Imports MySql.Data.MySqlClient
Public Class Login
    Dim strkon As String = "server=localhost;uid=root;database=ramart"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from username where pengguna =('" &
            txtuser.Text & "') and userpass=MD5('" & txtpass.Text & "')"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                user = txtuser.Text
                menu_utama.lblufn.Text = cek.Item("userfullname")
                gantipass.Label4.Text = cek.Item("userfullname")
                menu_utama.lblua.Text = cek.Item("useraktif")
                trspenjualan.lblu.Text = cek.Item("pengguna")
                cek.Close()

                MsgBox("Selamat Datang... Anda Telah Bisa Mengakses Halaman Menu Utama", MsgBoxStyle.Information, "Konfirmasi")
                menu_utama.Show()
                Me.Hide()
            Else
                MsgBox("ANDA TIDAK BISA LOGIN", MsgBoxStyle.Critical, "INFORMATION")
                txtuser.Clear()
                txtpass.Clear()
                txtuser.Focus()
            End If
            kon.Close()
        Catch ex As Exception
            MsgBox("TIDAK ADA KONEKSI", MsgBoxStyle.Critical, "INFORMATION")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
