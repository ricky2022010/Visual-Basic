Imports MySql.Data.MySqlClient
Public Class trspenjualan
    Dim strkon As String = "server=localhost;uid=root;database=ramart;convert zero datetime=true"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Dim dg As DataGrid
    Dim cek As MySqlDataReader
    Dim zdt As String
    Dim Hh As Double
    Sub ambilkd()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang order by merk"
        cek = perintah.ExecuteReader()
        cek.Read()
        While cek.Read
            cbkdb.Items.Add(cek.Item("kdbarang"))
        End While
        kon.Close()
    End Sub
    Sub ambilharga()
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang where kdbarang='" & cbkdb.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            Hh = cek.Item("satuan")
        Else
            Hh = ""
        End If
        kon.Close()
    End Sub
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from trans_penjualan order by tgl_transaksi"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "trans_penjualan")
        dgv.DataSource = ds.Tables("trans_penjualan")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "trans_penjualan")
        dgv.DataSource = datas.Tables("trans_penjualan")
        kon.Close()
    End Sub
    Sub bersih()
        zdt = ""
        txtn.Text = ""
        txtnt.Text = ""
        cbkdb.Text = ""
        txtjb.Text = ""
        txth.Text = ""
    End Sub
    Private Sub trspenjualan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cbkdb.Items.Clear()
        ambilkd()
    End Sub
    Private Sub pengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
        btn2.Enabled = True
        btn3.Enabled = False
        btn4.Enabled = False
        dgv.Columns(0).Width = 200
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 150
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 150
        dgv.Columns(6).Width = 150
        dgv.Font = New Font("calibri", 11)
        dgv.Columns(0).HeaderText = "Faktur"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Nama"
        dgv.Columns(3).HeaderText = "No telpon"
        dgv.Columns(4).HeaderText = "Kode Barang"
        dgv.Columns(5).HeaderText = "Jumlah Barang"
        dgv.Columns(6).HeaderText = "Harga"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnf.TextChanged

        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from trans_penjualan where nofaktur='" & txtnf.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            zdt = cek.Item("tgl_transaksi")
            txtn.Text = cek.Item("atas_nama")
            txtnt.Text = cek.Item("notelpon")
            cbkdb.Text = cek.Item("kdbarang")
            txtjb.Text = cek.Item("jml_beli")
            lbltothar.Text = cek.Item("jml_harga")
        Else
            zdt = ""
            txtn.Text = ""
            txtnt.Text = ""
            cbkdb.Text = ""
            txtjb.Text = ""
            lbltothar.Text = ""

        End If
        kon.Close()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        btn4.Enabled = True
        btn3.Enabled = True
        txtnf.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                btn1.Enabled = False
                txtnf.Text = .Cells(0).Value
                zdt = .Cells(1).Value
                txtn.Text = .Cells(2).Value
                txtnt.Text = .Cells(3).Value
                cbkdb.Text = .Cells(4).Value
                txtjb.Text = .Cells(5).Value
                txth.Text = .Cells(6).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        btn1.Enabled = False
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = False
        btn2.Text = "simpan"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        bersih()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click

        If txtn.Text = "" Or txtnt.Text = "" Or cbkdb.Text = "" Or txtjb.Text = "" Or txth.Text = "" Then
            MsgBox("Mohon Lengkapi Data anda ...", MsgBoxStyle.Information, "konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "insert into trans_penjualan values ('" & txtnf.Text & "','" &
            Format(dtp.Value, "yyyy-MM-dd") & "',('" & txtn.Text & "'),('" & txtnt.Text & "'),('" & cbkdb.Text & "'),('" & txtjb.Text & "'),'" & lbltothar.Text & "')"
            perintah.ExecuteNonQuery()
            kon.Close()
            tampildata()
            MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
            bersih()
            btn1.Enabled = True
            btn1.Enabled = False
            btn4.Enabled = False
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from trans_penjualan where nofaktur='" & txtnf.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
        bersih()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        tampiluser("select * from trans_penjualan where nama like '%" & txtcari.Text & "%' or nofaktur like '%" & txtcari.Text & "%'")
    End Sub

    Private Sub cbkdb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkdb.SelectedIndexChanged
        ambilharga()
        txth.Text = Hh
    End Sub

    Private Sub txtjb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjb.TextChanged
        lbltothar.Text = Val(txtjb.Text) * Hh
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbyr.TextChanged
        lblkmb.Text = Val(txtbyr.Text) - Val(lbltothar.Text)
    End Sub

End Class