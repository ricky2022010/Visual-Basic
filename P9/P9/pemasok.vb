Imports MySql.Data.MySqlClient
Public Class pemasok
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
        perintah.CommandText = "select * from pemasok"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pemasok")
        dgv.DataSource = ds.Tables("pemasok")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "pemasok")
        dgv.DataSource = datas.Tables("pemasok")
        kon.Close()
    End Sub
    Sub bersih()
        txtkdp.Text = ""
        txtp.Text = ""
        txta.Text = ""
        txtnh.Text = ""
    End Sub
    Sub tidakaktif()
        txtkdp.Enabled = False
        txtp.Enabled = False
        txta.Enabled = False
        txtnh.Enabled = False
    End Sub
    Sub aktif1()
        txtkdp.Enabled = True
        txtp.Enabled = True
        txta.Enabled = True
        txtnh.Enabled = True
    End Sub
    Private Sub pengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tidakaktif()
        tampildata()
        btn2.Enabled = False
        btn3.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        dgv.Columns(0).Width = 200
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 150
        dgv.Columns(3).Width = 150
        dgv.Font = New Font("calibri", 11)
        dgv.Columns(0).HeaderText = "KODE"
        dgv.Columns(1).HeaderText = "NAMA PEMASOK"
        dgv.Columns(2).HeaderText = "ALAMAT"
        dgv.Columns(3).HeaderText = "NO HP"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkdp.TextChanged
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pemasok where kdpemasok='" & txtkdp.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtp.Text = cek.Item("alamat")
            txtnh.Text = cek.Item("notelpon")
        Else
            txtp.Text = ""
            txtnh.Text = ""
        End If
        kon.Close()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        btn2.Text = "EDIT"
        txtkdp.Enabled = False
        txtp.Enabled = True
        txta.Enabled = True
        txtnh.Enabled = True
        btn4.Enabled = True
        btn3.Enabled = True
        btn2.Enabled = True
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                btn1.Enabled = False
                txtkdp.Text = .Cells(0).Value
                txtp.Text = .Cells(1).Value
                txta.Text = .Cells(2).Value
                txtnh.Text = .Cells(3).Value
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
        If txtp.Text = "" Or txtp.Text = "" Or txtnh.Text = "" Then
            MsgBox("Mohon Lengkapi Data anda ...", MsgBoxStyle.Information, "konfirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            If btn2.Text = "simpan" Then
                perintah.CommandText = "insert into pemasok values ('" & txtkdp.Text & "','" &
               txtp.Text & "',('" & txta.Text & "'),'" & txtnh.Text & "')"
            Else
                perintah.CommandText = "UPDATE pemasok SET nama='" & txtp.Text & "',alamat='" & txta.Text & "',notelpon='" & txtnh.Text & "' WHERE kdpemasok='" & txtkdp.Text & "'"
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
        perintah.CommandText = "delete from pemasok where kdpemasok='" & txtkdp.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
        bersih()
        tidakaktif()
        btn1.Enabled = True
        btn2.Enabled = False
        btn4.Enabled = False
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        tampiluser("select * from pemasok where kdpemasok like '%" & txtcari.Text & "%' or nama like '%" & txtcari.Text & "%'")
    End Sub
End Class