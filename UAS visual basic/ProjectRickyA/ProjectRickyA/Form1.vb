Public Class Form1
    Sub bersih()
        txtid.Text = ""
        txtpass.Text = ""
    End Sub
    Sub formkasir()
        menuutama.Button4.Visible = False
        menuutama.Button3.Visible = False
        menuutama.Button6.Visible = False
        menuutama.Button5.Visible = False
        menuutama.Button7.Visible = False
        menuutama.Button11.Visible = False
        item.txtkd.Visible = False
        item.txtnama.Visible = False
        item.txtharga.Visible = False
        item.txtjumlah.Visible = False
        item.tambah.Visible = False
        item.simpan.Visible = False
        item.batal.Visible = False
        item.hapus.Visible = False
        item.Label2.Visible = False
        item.Label3.Visible = False
        item.Label4.Visible = False
        item.Label5.Visible = False
        item.Label9.Visible = False
    End Sub
    Sub formadmin()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from user where id =('" & txtid.Text & "') and pass=MD5('" & txtpass.Text & "')"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                user = txtid.Text
                menuutama.penggunaa.Text = cek.Item("userlevel")
                menuutama.username.Text = cek.Item("id")
                cek.Close()
                MsgBox("Selamat Datang... Anda Telah Bisa Mengakses Halaman Menu Utama", MsgBoxStyle.Information, "Konfirmasi")
                menuutama.Show()
                Me.Hide()
                bersih()

                If menuutama.penggunaa.Text = "Admin" Then
                    formadmin()
                Else
                    formkasir()
                End If
            Else
                MsgBox("ANDA TIDAK BISA LOGIN", MsgBoxStyle.Critical, "INFORMATION")
                txtid.Clear()
                txtpass.Clear()
                txtid.Focus()
            End If
            kon.Close()
        Catch ex As Exception
            MsgBox("TIDAK ADA KONEKSI", MsgBoxStyle.Critical, "INFORMATION")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
