<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pengguna
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtufn = New System.Windows.Forms.TextBox()
        Me.cbua = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Data Pengguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(46, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(46, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(49, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fullname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(46, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Useraktif"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(183, 22)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(271, 20)
        Me.txtuser.TabIndex = 6
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(183, 94)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(271, 20)
        Me.txtpass.TabIndex = 7
        '
        'txtufn
        '
        Me.txtufn.Location = New System.Drawing.Point(183, 167)
        Me.txtufn.Name = "txtufn"
        Me.txtufn.Size = New System.Drawing.Size(271, 20)
        Me.txtufn.TabIndex = 8
        '
        'cbua
        '
        Me.cbua.FormattingEnabled = True
        Me.cbua.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbua.Location = New System.Drawing.Point(183, 236)
        Me.cbua.Name = "cbua"
        Me.cbua.Size = New System.Drawing.Size(271, 21)
        Me.cbua.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cbua)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtufn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtuser)
        Me.Panel2.Location = New System.Drawing.Point(33, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 294)
        Me.Panel2.TabIndex = 10
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(34, 521)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(92, 46)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "Tambah"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(160, 521)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(92, 46)
        Me.btn2.TabIndex = 12
        Me.btn2.Text = "Simpan"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(282, 521)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(92, 46)
        Me.btn3.TabIndex = 13
        Me.btn3.Text = "Batal"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(409, 521)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(92, 46)
        Me.btn4.TabIndex = 14
        Me.btn4.Text = "Hapus"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(517, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 33)
        Me.Panel3.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(372, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CEK DATA PENGGUNA ( KETIK : USERNAME / FULLNAME)"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(521, 137)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(281, 20)
        Me.txtcari.TabIndex = 16
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(940, 106)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(142, 46)
        Me.btn5.TabIndex = 17
        Me.btn5.Text = "KELUAR"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(531, 211)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(550, 355)
        Me.dgv.TabIndex = 18
        '
        'pengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 621)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pengguna"
        Me.Text = "pengguna"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtufn As System.Windows.Forms.TextBox
    Friend WithEvents cbua As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
End Class
