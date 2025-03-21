Public Class item
    Sub noitem()
        Dim kode, nofaktur As String
        Dim no As Integer
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_item from item order by id_item desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_item")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            nofaktur = "IT" + Format(dtp.Value, "yyyyMM") + Format(no, "0000")
            txtkd.Text = nofaktur
        Else
            txtkd.Text = "IT" + Format(dtp.Value, "yyyyMM") + "0001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from item"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "item")
        dgv.DataSource = ds.Tables("item")
        kon.Close()
    End Sub
    Sub bersih()
        txtkd.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
    End Sub
    Sub mati()
        txtkd.Enabled = False
        txtnama.Enabled = False
        txtharga.Enabled = False
        txtjumlah.Enabled = False
    End Sub
    Sub hidup()
        txtnama.Enabled = True
        txtharga.Enabled = True
        txtjumlah.Enabled = True
    End Sub
    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        menuutama.Show()
        Me.Close()

    End Sub

    Private Sub item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        noitem()
        tambah.Enabled = True
        simpan.Enabled = False
        hapus.Enabled = False
        mati()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        simpan.Text = "EDIT"
        txtkd.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                hidup()
                tambah.Enabled = False
                simpan.Enabled = True
                hapus.Enabled = True
                txtkd.Text = .Cells(0).Value
                txtnama.Text = .Cells(1).Value
                txtharga.Text = .Cells(3).Value
                txtjumlah.Text = .Cells(2).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If txtkd.Text = "" Or txtnama.Text = "" Or txtharga.Text = "" Or txtjumlah.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If simpan.Text = "SIMPAN" Then
                perintah.CommandText = "insert into item values ('" & txtkd.Text & "','" & txtnama.Text & "','" & txtjumlah.Text & "','" & txtharga.Text & "')"
            Else
                perintah.CommandText = "UPDATE item SET nama_item='" & txtnama.Text & "',jumlahstok='" & txtjumlah.Text & "',harga='" & txtharga.Text & "'WHERE id_item='" & txtkd.Text & "'"
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

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        noitem()
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

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from item where id_item='" & txtkd.Text & "'"
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

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from item where nama_item like '" & txtcari.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "item")
        dgv.DataSource = ds.Tables("item")
        kon.Close()
    End Sub
End Class