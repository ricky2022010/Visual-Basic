Public Class barang
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
    Private Sub barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
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
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        tampiluser("select * from barang where merk like '%" & txtcari.Text & "%' or kdbarang like '%" & txtcari.Text & "%'")
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        menu_utama.Show()
    End Sub
End Class