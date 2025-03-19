<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pemasok
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
        Me.btn5 = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtnh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkdp = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(583, 166)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(550, 444)
        Me.dgv.TabIndex = 28
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(330, 348)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(142, 46)
        Me.btn5.TabIndex = 27
        Me.btn5.Text = "KELUAR"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(573, 92)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(281, 20)
        Me.txtcari.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(569, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 33)
        Me.Panel3.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cek Data Pemasok Berdasarkan Nama pemasok"
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(419, 24)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(92, 46)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "Hapus"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(298, 24)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(92, 46)
        Me.btn3.TabIndex = 23
        Me.btn3.Text = "Batal"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(154, 24)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(92, 46)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "Simpan"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(21, 24)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(92, 46)
        Me.btn1.TabIndex = 21
        Me.btn1.Text = "Tambah"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.txtnh)
        Me.Panel2.Controls.Add(Me.btn5)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtp)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txta)
        Me.Panel2.Controls.Add(Me.btn4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn3)
        Me.Panel2.Controls.Add(Me.txtkdp)
        Me.Panel2.Controls.Add(Me.btn2)
        Me.Panel2.Controls.Add(Me.btn1)
        Me.Panel2.Location = New System.Drawing.Point(51, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 444)
        Me.Panel2.TabIndex = 20
        '
        'txtnh
        '
        Me.txtnh.Location = New System.Drawing.Point(201, 269)
        Me.txtnh.Name = "txtnh"
        Me.txtnh.Size = New System.Drawing.Size(271, 20)
        Me.txtnh.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(33, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "No hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(33, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'txtp
        '
        Me.txtp.Location = New System.Drawing.Point(201, 133)
        Me.txtp.Name = "txtp"
        Me.txtp.Size = New System.Drawing.Size(271, 20)
        Me.txtp.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(33, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Pemasok"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(201, 170)
        Me.txta.Multiline = True
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(271, 79)
        Me.txta.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(31, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Pemasok"
        '
        'txtkdp
        '
        Me.txtkdp.Location = New System.Drawing.Point(201, 94)
        Me.txtkdp.Name = "txtkdp"
        Me.txtkdp.Size = New System.Drawing.Size(271, 20)
        Me.txtkdp.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(83, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 56)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Data Pemasok"
        '
        'pemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1331, 622)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pemasok"
        Me.Text = "pemasok"
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
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtnh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtkdp As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
