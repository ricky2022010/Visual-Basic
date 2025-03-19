Imports MySql.Data.MySqlClient
Public Class pengguna
    Dim strkon As String = "server=localhost;uid=root;database=ramart"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Dim dg As DataGrid
    Dim status As String
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from username"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "username")
        dgv.DataSource = ds.Tables("username")
        kon.Close()
    End Sub
    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "username")
        dgv.DataSource = datas.Tables("username")
        kon.Close()
    End Sub
    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
        txtufn.Text = ""
        cbua.Text = ""
    End Sub
    Sub tidakaktif()
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtufn.Enabled = False
        cbua.Enabled = False
    End Sub
    Sub aktif1()
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtufn.Enabled = True
        cbua.Enabled = True
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
        dgv.Font = New Font("calibri", 11)
        dgv.Columns(0).HeaderText = "USER NAME"
        dgv.Columns(1).HeaderText = "USER FULL NAME"
        dgv.Columns(2).HeaderText = "PASSWORD"
        dgv.Columns(3).HeaderText = "USER AKTIF"
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from username where pengguna='" & txtuser.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtufn.Text = cek.Item("userfullname")
            cbua.Text = cek.Item("useraktif")
        Else
            txtufn.Text = ""
            cbua.Text = ""
        End If
        kon.Close()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Me.Close()
        menu_utama.Show()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        txtuser.Enabled = False
        btn4.Enabled = True
        btn3.Enabled = True
        Try
            Dim i As Integer
            i = dgv.CurrentRow.Index
            With dgv.Rows.Item(i)
                btn1.Enabled = False
                txtuser.Text = .Cells(0).Value
                txtufn.Text = .Cells(1).Value
                txtpass.Text = .Cells(2).Value
                cbua.Text = .Cells(3).Value
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
        btn3.Enabled = False
        btn2.Enabled = False
        btn4.Enabled = False
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtuser.Text = "" Or txtufn.Text = "" Or txtpass.Text = "" Or cbua.Text = "" Then
            MsgBox("Mohon Lengkapi Data anda ...", MsgBoxStyle.Information, "kondirmasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "insert into username values ('" & txtuser.Text & "','" &
           txtufn.Text & "',MD5('" & txtpass.Text & "'),'" & cbua.Text & "')"
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
        tidakaktif()
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from username where pengguna='" & txtuser.Text & "'"
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

    Private Sub txtcari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcari.KeyPress
        kon.Open()
        mda = New MySqlDataAdapter("SELECT * FROM username where userfullname like'" & txtcari.Text & "%'", kon)
        ds = New DataSet
        mda.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        txtcari.Focus()
        kon.Close()
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        kon.Open()
        mda = New MySqlDataAdapter("SELECT * FROM username where pengguna like'" & txtcari.Text & "%'", kon)
        ds = New DataSet
        mda.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        txtcari.Focus()
        kon.Close()
    End Sub

    Private Sub cbua_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbua.SelectedIndexChanged
        Select Case status
            Case 1
                status = "1"
            Case 2
                status = "2"
            Case 3
                status = "3"
            Case 4
                status = "4"
        End Select
    End Sub
End Class