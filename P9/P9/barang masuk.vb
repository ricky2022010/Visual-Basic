Imports MySql.Data.MySqlClient
Public Class barangmasuk
    Dim strkon As String = "server=localhost;uid=root;database=ramart"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Dim dg As DataGrid
    Dim cek As MySqlDataReader
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang order by kdbarang"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "barang")
        dgv.DataSource = ds.Tables("barang")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "barang")
        dgv.DataSource = datas.Tables("barang")
        kon.Close()
    End Sub
    Sub bersih()
        txtkdb.Text = ""
        txtmt.Text = ""
        txtm.Text = ""
        txthb.Text = ""
    End Sub
    Sub tidakaktif()
        txtkdb.Enabled = False
        txtm.Enabled = False
        txtmt.Enabled = False
        txthb.Enabled = False
        txtjb.Enabled = False
        txts.Enabled = False
    End Sub
    Sub aktif1()
        txtkdb.Enabled = True
        txtm.Enabled = True
        txtmt.Enabled = True
        txthb.Enabled = True
        txtjb.Enabled = True
        txts.Enabled = True
    End Sub

    Private Sub barangmasuk_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang order by kdbarang"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "barang")
        dgv.DataSource = ds.Tables("barang")
        kon.Close()
    End Sub
    Private Sub pengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tidakaktif()
        tampildata()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        dgv.Columns(0).Width = 200
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 150
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 150
        dgv.Font = New Font("calibri", 11)
        dgv.Columns(0).HeaderText = "KODE"
        dgv.Columns(1).HeaderText = "Merk"
        dgv.Columns(2).HeaderText = "motif"
        dgv.Columns(3).HeaderText = "Harga"
        dgv.Columns(4).HeaderText = "Jumlah Barang"
        dgv.Columns(5).HeaderText = "Satuan"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdb.TextChanged
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang where kdbarang='" & txtkdb.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtm.Text = cek.Item("merk")
            txtmt.Text = cek.Item("motif")
            txthb.Text = cek.Item("harga")
            txtjb.Text = cek.Item("JB")
            txts.Text = cek.Item("satuan")
        Else
            txtm.Text = ""
            txtmt.Text = ""
            txthb.Text = ""
            txtjb.Text = ""
            txts.Text = ""

        End If
        kon.Close()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        aktif1()
        btn2.Text = "EDIT"
        btn4.Enabled = True
        btn3.Enabled = True
        txtkdb.Enabled = False
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                btn1.Enabled = False
                txtkdb.Text = .Cells(0).Value
                txtm.Text = .Cells(1).Value
                txtmt.Text = .Cells(2).Value
                txthb.Text = .Cells(3).Value
                txtjb.Text = .Cells(4).Value
                txts.Text = .Cells(5).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        aktif1()
        btn1.Enabled = False
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = False
        btn2.Text = "simpan"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        bersih()
        tidakaktif()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtm.Text = "" Or txtmt.Text = "" Or txthb.Text = "" Or txtjb.Text = "" Or txts.Text = "" Then
            MsgBox("Mohon Lengkapi Data anda ...", MsgBoxStyle.Information, "konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btn2.Text = "simpan" Then
                perintah.CommandText = "insert into barang values ('" & txtkdb.Text & "','" &
               txtm.Text & "',('" & txtmt.Text & "'),('" & txthb.Text & "'),('" & txtjb.Text & "'),'" & txts.Text & "')"
            Else
                perintah.CommandText = "UPDATE barang SET merk='" & txtm.Text & "',motif='" & txtmt.Text & "',harga='" & txthb.Text & "',JB='" & txtjb.Text & "',satuan='" & txts.Text & "' WHERE kdbarang='" & txtkdb.Text & "'"
            End If
            perintah.ExecuteNonQuery()
            kon.Close()
            tampildata()
            MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
            bersih()
            tidakaktif()
            btn1.Enabled = True
            btn1.Enabled = False
            btn4.Enabled = False
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from barang where kdbarang='" & txtkdb.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
        bersih()
        tidakaktif()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        tampiluser("select * from barang where merk like '%" & txtcari.Text & "%' or kdbarang like '%" & txtcari.Text & "%'")
    End Sub
End Class