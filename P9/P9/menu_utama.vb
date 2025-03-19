Imports System.Drawing.Printing
Public Class menu_utama
    Dim WithEvents pd1 As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl.Click
        Me.Close()
        Login.Show()
        Login.txtuser.Text = ""
        Login.txtpass.Text = ""
    End Sub
    Sub buka()
        btnb.Enabled = True
        btnbm.Enabled = True
        btncsb.Enabled = True
        btnlp.Enabled = True
        btnlpj.Enabled = True
        btnlpt.Enabled = True
        btnp.Enabled = True
        btnpg.Enabled = True
        btntp.Enabled = True
    End Sub
    Sub tutup()
        btnb.Enabled = False
        btnbm.Enabled = False
        btncsb.Enabled = False
        btnlp.Enabled = False
        btnlpj.Enabled = False
        btnlpt.Enabled = False
        btnp.Enabled = False
        btnpg.Enabled = False
        btntp.Enabled = False
    End Sub
    Sub bukaizin()
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from username where pengguna='" & lblufn.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            lblua.Text = cek.Item("useraktif")
        ElseIf lblua.Text = "1" Then
            buka()
        ElseIf lblua.Text = "2" Then
            buka()
            btnpg.Enabled = False
            btnbm.Enabled = False
            btncsb.Enabled = False
            btnp.Enabled = False
            btnlp.Enabled = False
        ElseIf lblua.Text = "3" Then
            buka()
            btnpg.Enabled = False
            btnbm.Enabled = False
            btncsb.Enabled = False
            btnp.Enabled = False
            btnlp.Enabled = False
        Else
            buka()
        End If
        kon.Close()
    End Sub
    Private Sub pd_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 500)
        pd1.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpg.Click
        bukaizin()
        pengguna.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnp.Click
        pemasok.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngp.Click
        gantipass.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb.Click
        barang.Show()
        Me.Hide()
    End Sub

    Private Sub btnlpj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlpj.Click

    End Sub

    Private Sub menu_utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaizin()
    End Sub

    Private Sub btnbm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbm.Click
        barangmasuk.Show()
        Me.Hide()
    End Sub

    Private Sub btntp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntp.Click
        trspenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub btncsb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsb.Click
        ppd.Document = pd1
        ppd.ShowDialog()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f10 As New Font("times new roman", 10, FontStyle.Regular)
        Dim f10b As New Font("times new roman", 10, FontStyle.Bold)
        Dim f14 As New Font("times new roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = pd1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = pd1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = pd1.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------"

        e.Graphics.DrawString("RAMART 2022010", f14, Brushes.Red, centermargin, 5, tengah)
        e.Graphics.DrawString("Tetap lah putus asa, Jangan pernah semangat", f10, Brushes.Red, centermargin, 25, tengah)

    End Sub
End Class