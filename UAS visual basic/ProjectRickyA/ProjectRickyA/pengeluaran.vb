Public Class pengeluaran
    Dim total As Double
    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pengeluaran"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "from pengeluaran")
        dgv.DataSource = ds.Tables("from pengeluaran")
        kon.Close()
    End Sub
    Sub ambilkdp()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_pemasok from pemasok"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbkdp.Items.Add(cek.Item("id_pemasok"))
        End While
        kon.Close()
    End Sub
    Sub bersih()
        idp.Text = ""
        cmbkdp.Text = ""
        namabarang.Text = ""
        txtjumlah.Text = ""
        hargasatuan.Text = ""
        hargatotal.Text = ""
    End Sub
    Sub hidup()
        idp.Enabled = True
        cmbkdp.Enabled = True
        namabarang.Enabled = True
        txtjumlah.Enabled = True
        hargasatuan.Enabled = True
        hargatotal.Enabled = True
    End Sub
    Sub mati()
        idp.Enabled = False
        cmbkdp.Enabled = False
        namabarang.Enabled = False
        txtjumlah.Enabled = False
        hargasatuan.Enabled = False
        hargatotal.Enabled = False
    End Sub
    Sub nofaktur()
        Dim kode, no_beli As String
        Dim no As Integer
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_pengeluaran from pengeluaran order by id_pengeluaran desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_pengeluaran")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            no_beli = "BE" + Format(dtp.Value, "yyyyMM") + Format(no, "0000")
            idp.Text = no_beli
        Else
            idp.Text = "BE" + Format(dtp.Value, "yyyyMM") + "0001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Private Sub pengeluaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ambilkdp()
        tampil()
        mati()
        nofaktur()
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pengeluaran where id_pengeluaran like '" & txtcari.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pengeluaran")
        dgv.DataSource = ds.Tables("pengeluaran")
        kon.Close()
    End Sub

    Private Sub cmbkdp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkdp.SelectedIndexChanged
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasok where id_pemasok = '" & cmbkdp.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            cmbkdp.Text = cek.Item("id_pemasok")
        End If
        kon.Close()
    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        nofaktur()
        hidup()
        tambah.Enabled = False
        simpan.Enabled = True
        hapus.Enabled = True
        simpan.Text = "SIMPAN"
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        bersih()
        mati()
        tambah.Enabled = True
        simpan.Enabled = False
        hapus.Enabled = True
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
        menuutama.Show()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If idp.Text = "" Or cmbkdp.Text = "" Or namabarang.Text = "" Or txtjumlah.Text = "" Or hargasatuan.Text = "" Or hargatotal.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If simpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into pengeluaran values('" & idp.Text & "','" & cmbkdp.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & namabarang.Text & "','" & txtjumlah.Text & "','" & hargasatuan.Text & "','" & hargatotal.Text & "')"
            Else
                perintah.CommandText = "UPDATE pengeluaran SET id_pemasok='" & cmbkdp.Text & "',tanggal='" & Format(dtp.Value, "yyyy-MM-dd") & "',nama_barang='" & namabarang.Text & "',jumlah='" & txtjumlah.Text & "',hargasatuan='" & hargasatuan.Text & "',total='" & hargatotal.Text & "' WHERE id_pengeluaran='" & idp.Text & "'"
            End If
            perintah.ExecuteNonQuery()
            kon.Close()
            tampil()
            MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
            bersih()
            mati()
            tambah.Enabled = True
            simpan.Enabled = False
            hapus.Enabled = True
        End If
    End Sub

    Private Sub hargasatuan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hargasatuan.TextChanged
        total = Val(txtjumlah.Text) * Val(hargasatuan.Text)
        hargatotal.Text = total
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from pengeluaran where id_pengeluaran='" & idp.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        mati()
        tambah.Enabled = True
        simpan.Enabled = False
        hapus.Enabled = True
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        simpan.Text = "EDIT"
        idp.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                hidup()
                tambah.Enabled = False
                simpan.Enabled = True
                hapus.Enabled = True
                idp.Text = .Cells(0).Value
                cmbkdp.Text = .Cells(1).Value
                dtp.Text = .Cells(2).Value
                namabarang.Text = .Cells(3).Value
                txtjumlah.Text = .Cells(4).Value
                hargasatuan.Text = .Cells(5).Value
                hargatotal.Text = .Cells(6).Value
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class