Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class penjualan
    Dim disc, totbay, sisa As Double
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim sisastok As Double
    Sub ambilkdbrg()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_item from item"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbidi.Items.Add(cek.Item("id_item"))
        End While
        kon.Close()
    End Sub
    Sub tampilpembayaran()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pembayaran"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pembayaran")
        dgv1.DataSource = ds.Tables("pembayaran")
        kon.Close()
    End Sub
    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasukan"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pemasukan")
        dgv.DataSource = ds.Tables("pemasukan")
        kon.Close()
    End Sub
    Sub bersih()
        idpenj.Text = ""
        cmbidi.Text = ""
        lblnama.Text = ""
        lblharga.Text = ""
        txtbeli.Text = ""
        lbltotal.Text = ""
        txtdibayar.Text = ""
        kembalian.Text = ""
    End Sub
    Sub mati()
        idpenj.Enabled = False
        cmbidi.Enabled = False
        lblnama.Enabled = False
        lblharga.Enabled = False
        txtbeli.Enabled = False
        lbltotal.Enabled = False
        txtdibayar.Enabled = False
        kembalian.Enabled = False
    End Sub
    Sub hidup()
        idpenj.Enabled = True
        cmbidi.Enabled = True
        lblnama.Enabled = True
        lblharga.Enabled = True
        txtbeli.Enabled = True
        lbltotal.Enabled = True
        txtdibayar.Enabled = True
        kembalian.Enabled = True
    End Sub
    Sub nofaktur()
        Dim kode, nofaktur As String
        Dim no As Integer
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select id_pemasukan from pemasukan order by id_pemasukan desc limit 1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("id_pemasukan")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            nofaktur = "JU" + Format(dtp.Value, "yyyyMM") + Format(no, "0000")
            idpenj.Text = nofaktur
        Else
            idpenj.Text = "JU" + Format(dtp.Value, "yyyyMM") + "0001"
        End If
        cek.Close()
        kon.Close()
    End Sub
    Private Sub penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
        dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow
        tampil()
        mati()
        ambilkdbrg()
        tampilpembayaran()
        nofaktur()
    End Sub

    Private Sub cmbidi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbidi.SelectedIndexChanged
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from item where id_item = '" & cmbidi.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()

        If cek.HasRows Then
            lblharga.Text = cek.Item("harga")
            lblnama.Text = cek.Item("nama_item")
            Label16.Text = cek.Item("jumlahstok")
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

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
        menuutama.Show()

    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        bersih()
        mati()
        tambah.Enabled = True
        simpan.Enabled = False
        hapus.Enabled = True
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If idpenj.Text = "" Or cmbidi.Text = "" Or lblnama.Text = "" Or lblharga.Text = "" Or txtbeli.Text = "" Or lbltotal.Text = "" Or txtdibayar.Text = "" Or kembalian.Text = "" Then
            MsgBox("Mohon Lengkapi Isian Data Anda...", MsgBoxStyle.Information, "Konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If txtbeli.Text <= Val(Label16.Text) Then
                If simpan.Text = "SIMPAN" Then
                    perintah.CommandText = "insert into pemasukan values ('" & idpenj.Text & "','" & cmbidi.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & lblnama.Text & "','" & lblharga.Text & "','" &
                    txtbeli.Text & "','" & lbltotal.Text & "')"
                    perintah.ExecuteNonQuery()
                    perintah.CommandText = "insert into pembayaran values ('" & idpenj.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & lbltotal.Text & "','" &
                    txtdibayar.Text & "','" & sisa & "')"
                    perintah.ExecuteNonQuery()
                    MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
                    For baris As Integer = 0 To dgv.Rows.Count - 2
                        Dim kurang As String = "update item set jumlahstok= '" & Label15.Text & "' WHERE id_item='" & cmbidi.Text & "'"
                        perintah = New MySqlCommand(kurang, kon)
                        perintah.ExecuteNonQuery()
                    Next
                    PPD.Document = PD
                    PPD.ShowDialog()
                    'PD.Print()
                Else
                    perintah.CommandText = "UPDATE pemasukan SET id_item='" & cmbidi.Text & "',tanggal='" & Format(dtp.Value, "yyyy-MM-dd") & "',nama_item='" & lblnama.Text & "',harga='" & lblharga.Text & "',jumlah='" & txtbeli.Text & "',total='" & lbltotal.Text & "' WHERE id_pemasukan='" & idpenj.Text & "'"
                    perintah.ExecuteNonQuery()
                    perintah.CommandText = "UPDATE pembayaran SET tglbayar='" & Format(dtp.Value, "yyyy-MM-dd") & "',total='" & lbltotal.Text & "',dibayar='" & txtdibayar.Text & "',kembalian='" & sisa & "' WHERE id_pemasukan='" & idpenj.Text & "'"
                    perintah.ExecuteNonQuery()
                    MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
                End If
            Else
                MsgBox("Stok barang tidak cukup", MsgBoxStyle.Critical, "Alert")
            End If
            kon.Close()
            tampil()
            tampilpembayaran()
            bersih()
            mati()
            tambah.Enabled = True
            simpan.Enabled = False
            hapus.Enabled = True
        End If
    End Sub

    Private Sub txtbeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbeli.TextChanged
        lbltotal.Text = Val(txtbeli.Text) * Val(lblharga.Text)

        sisastok = Val(Label16.Text) - Val(txtbeli.Text)
        Label15.Text = sisastok
    End Sub

    Private Sub txtdibayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdibayar.TextChanged
        sisa = Val(txtdibayar.Text) - Val(lbltotal.Text)
        kembalian.Text = sisa
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        simpan.Text = "Edit"
        idpenj.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                hidup()
                tambah.Enabled = False
                idpenj.Text = .Cells(0).Value
                dtp.Text = .Cells(2).Value
                cmbidi.Text = .Cells(1).Value
                lblnama.Text = .Cells(3).Value
                lblharga.Text = .Cells(4).Value
                txtbeli.Text = .Cells(5).Value
                lbltotal.Text = .Cells(6).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            Dim i As Integer
            i = dgv1.CurrentRow.Index
            With dgv1.Rows.Item(i)
                hidup()
                tambah.Enabled = False
                idpenj.Text = .Cells(0).Value
                dtp.Text = .Cells(1).Value
                lbltotal.Text = .Cells(2).Value
                txtdibayar.Text = .Cells(3).Value
                kembalian.Text = .Cells(4).Value
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from pemasukan where id_pemasukan='" & idpenj.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from pembayaran where id_pemasukan='" & idpenj.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampil()
        tampilpembayaran()
        bersih()
        mati()
        tambah.Enabled = True
        simpan.Enabled = False
        hapus.Enabled = True
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasukan where id_pemasukan like '" & txtcari.Text & "%'"
        perintah.CommandText = "select * from pembayaran where id_pemasukan like '" & txtcari.Text & "%'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pemasukan")
        dgv.DataSource = ds.Tables("pemasukan")
        mda.Fill(ds, "pembayaran")
        dgv1.DataSource = ds.Tables("pembayaran")
        kon.Close()
    End Sub
    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14b As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim f8 As New Font("Times New Roman", 8, FontStyle.Regular)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim tinggi As New Integer
        Dim i As New Long
        Dim garis As String
        garis = "================================================================================================================="
        tinggi += 20

        e.Graphics.DrawString("ANGKRINGAN RA", f14b, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Batu Aji", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("NO HP: 083824115048", f10, Brushes.Black, centermargin, 40, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 50, tengah)
        e.Graphics.DrawString("Nota Penjualan", f14b, Brushes.Black, centermargin, 60, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 145, tengah)
        e.Graphics.DrawString("Kasir", f10b, Brushes.Black, 10, 90)
        e.Graphics.DrawString(menuutama.username.Text, f10, Brushes.Black, 100, 90)
        e.Graphics.DrawString(DateTimePicker1.Value, f10, Brushes.Black, 10, 135)

        e.Graphics.DrawString("ID", f10b, Brushes.Black, 10, 120)
        e.Graphics.DrawString(idpenj.Text, f10, Brushes.Black, 100, 120)

        e.Graphics.DrawString("Item", f10b, Brushes.Black, 10, 155)
        e.Graphics.DrawString(lblnama.Text, f10, Brushes.Black, 10, 155 + tinggi)

        e.Graphics.DrawString("Qty", f10b, Brushes.Black, 160, 155)
        e.Graphics.DrawString(txtbeli.Text, f10, Brushes.Black, 160, 155 + tinggi)

        e.Graphics.DrawString("Harga", f10b, Brushes.Black, 225, 155)
        e.Graphics.DrawString(lblharga.Text, f10, Brushes.Black, 225, 155 + tinggi)

        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 255, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 145 + tinggi, tengah)


        e.Graphics.DrawString("Total Belanja", f10b, Brushes.Black, 10, 265)
        e.Graphics.DrawString(lbltotal.Text, f10, Brushes.Black, 140, 265)
        e.Graphics.DrawString("Rp.", f10, Brushes.Black, 110, 265)

        e.Graphics.DrawString("Dibayar", f10b, Brushes.Black, 10, 315)
        e.Graphics.DrawString(txtdibayar.Text, f10, Brushes.Black, 140, 315)
        e.Graphics.DrawString("Rp.", f10, Brushes.Black, 110, 315)

        e.Graphics.DrawString("Kembalian", f10b, Brushes.Black, 10, 335)
        e.Graphics.DrawString(kembalian.Text, f10, Brushes.Black, 140, 335)
        e.Graphics.DrawString("Rp.", f10, Brushes.Black, 110, 335)

        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 305, tengah)

        e.Graphics.DrawString("Thank You", f10b, Brushes.Black, centermargin, 450, tengah)
        e.Graphics.DrawString("Please Come Again", f10b, Brushes.Black, centermargin, 465, tengah)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub
End Class