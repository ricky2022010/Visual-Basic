<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trspenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cbkdb = New System.Windows.Forms.ComboBox()
        Me.lblkmb = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltothar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbyr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnt = New System.Windows.Forms.TextBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lblnf = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.txtnf = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(19, 159)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1246, 254)
        Me.dgv.TabIndex = 38
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(544, 54)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(281, 20)
        Me.txtcari.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(544, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(121, 33)
        Me.Panel3.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cek No Faktur"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.dtp)
        Me.Panel2.Controls.Add(Me.cbkdb)
        Me.Panel2.Controls.Add(Me.lblkmb)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lbltothar)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtbyr)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Tanggal)
        Me.Panel2.Controls.Add(Me.dgv)
        Me.Panel2.Controls.Add(Me.txth)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtjb)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btn5)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtnt)
        Me.Panel2.Controls.Add(Me.btn4)
        Me.Panel2.Controls.Add(Me.lblnf)
        Me.Panel2.Controls.Add(Me.btn3)
        Me.Panel2.Controls.Add(Me.txtnf)
        Me.Panel2.Controls.Add(Me.btn2)
        Me.Panel2.Controls.Add(Me.btn1)
        Me.Panel2.Location = New System.Drawing.Point(68, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 511)
        Me.Panel2.TabIndex = 35
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd-mm-yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(1013, 19)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(136, 20)
        Me.dtp.TabIndex = 48
        '
        'cbkdb
        '
        Me.cbkdb.FormattingEnabled = True
        Me.cbkdb.Location = New System.Drawing.Point(201, 129)
        Me.cbkdb.Name = "cbkdb"
        Me.cbkdb.Size = New System.Drawing.Size(269, 21)
        Me.cbkdb.TabIndex = 47
        '
        'lblkmb
        '
        Me.lblkmb.AutoSize = True
        Me.lblkmb.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkmb.ForeColor = System.Drawing.Color.Maroon
        Me.lblkmb.Location = New System.Drawing.Point(1008, 473)
        Me.lblkmb.Name = "lblkmb"
        Me.lblkmb.Size = New System.Drawing.Size(20, 27)
        Me.lblkmb.TabIndex = 46
        Me.lblkmb.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(834, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 27)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "kembalian"
        '
        'lbltothar
        '
        Me.lbltothar.AutoSize = True
        Me.lbltothar.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltothar.ForeColor = System.Drawing.Color.Maroon
        Me.lbltothar.Location = New System.Drawing.Point(1008, 419)
        Me.lbltothar.Name = "lbltothar"
        Me.lbltothar.Size = New System.Drawing.Size(20, 27)
        Me.lbltothar.TabIndex = 44
        Me.lbltothar.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(834, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 27)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "dibayar"
        '
        'txtbyr
        '
        Me.txtbyr.Location = New System.Drawing.Point(1013, 450)
        Me.txtbyr.Name = "txtbyr"
        Me.txtbyr.Size = New System.Drawing.Size(136, 20)
        Me.txtbyr.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(834, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 27)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Total harga"
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.ForeColor = System.Drawing.Color.Maroon
        Me.Tanggal.Location = New System.Drawing.Point(834, 12)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(91, 27)
        Me.Tanggal.TabIndex = 39
        Me.Tanggal.Text = "Tanggal"
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(1013, 135)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(136, 20)
        Me.txth.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(834, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 27)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Harga"
        '
        'txtjb
        '
        Me.txtjb.Location = New System.Drawing.Point(1013, 75)
        Me.txtjb.Name = "txtjb"
        Me.txtjb.Size = New System.Drawing.Size(136, 20)
        Me.txtjb.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(834, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 27)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Jumlah Barang"
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(1250, 0)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(36, 24)
        Me.btn5.TabIndex = 27
        Me.btn5.Text = "X"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(16, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(16, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No Telpon"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(201, 52)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(271, 20)
        Me.txtn.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(16, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'txtnt
        '
        Me.txtnt.Location = New System.Drawing.Point(201, 94)
        Me.txtnt.Name = "txtnt"
        Me.txtnt.Size = New System.Drawing.Size(271, 20)
        Me.txtnt.TabIndex = 7
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(266, 419)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(92, 46)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "Hapus"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'lblnf
        '
        Me.lblnf.AutoSize = True
        Me.lblnf.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnf.ForeColor = System.Drawing.Color.Maroon
        Me.lblnf.Location = New System.Drawing.Point(16, 9)
        Me.lblnf.Name = "lblnf"
        Me.lblnf.Size = New System.Drawing.Size(111, 27)
        Me.lblnf.TabIndex = 2
        Me.lblnf.Text = "No Faktur"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(378, 419)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(92, 46)
        Me.btn3.TabIndex = 23
        Me.btn3.Text = "Batal"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'txtnf
        '
        Me.txtnf.Location = New System.Drawing.Point(201, 12)
        Me.txtnf.Name = "txtnf"
        Me.txtnf.Size = New System.Drawing.Size(136, 20)
        Me.txtnf.TabIndex = 6
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(143, 419)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(92, 46)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "Simpan"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(21, 419)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(92, 46)
        Me.btn1.TabIndex = 21
        Me.btn1.Text = "Tambah"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblu)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(68, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 56)
        Me.Panel1.TabIndex = 34
        '
        'lblu
        '
        Me.lblu.AutoSize = True
        Me.lblu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblu.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblu.ForeColor = System.Drawing.SystemColors.Control
        Me.lblu.Location = New System.Drawing.Point(160, 9)
        Me.lblu.Name = "lblu"
        Me.lblu.Size = New System.Drawing.Size(28, 36)
        Me.lblu.TabIndex = 2
        Me.lblu.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "user"
        '
        'PrintDocument1
        '
        '
        'trspenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 621)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "trspenjualan"
        Me.Text = "trans_penjualan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txth As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtjb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnt As System.Windows.Forms.TextBox
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents lblnf As System.Windows.Forms.Label
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents txtnf As System.Windows.Forms.TextBox
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblu As System.Windows.Forms.Label
    Friend WithEvents lblkmb As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbltothar As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbyr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents cbkdb As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
