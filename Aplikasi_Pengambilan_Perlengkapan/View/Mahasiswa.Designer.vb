<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mahasiswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mahasiswa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbokelas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.cboJurusan = New System.Windows.Forms.ComboBox()
        Me.txthp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.cbokelamin = New System.Windows.Forms.ComboBox()
        Me.dptlahir = New System.Windows.Forms.DateTimePicker()
        Me.txttmptLahir = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboagama = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrdView = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(2, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(978, 44)
        Me.Panel4.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 39)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Data Mahasiswa"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbokelas)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cboJurusan)
        Me.Panel1.Controls.Add(Me.txthp)
        Me.Panel1.Controls.Add(Me.txtalamat)
        Me.Panel1.Controls.Add(Me.cbokelamin)
        Me.Panel1.Controls.Add(Me.dptlahir)
        Me.Panel1.Controls.Add(Me.txttmptLahir)
        Me.Panel1.Controls.Add(Me.txtnama)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboagama)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtnim)
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 113)
        Me.Panel1.TabIndex = 78
        '
        'cbokelas
        '
        Me.cbokelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbokelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbokelas.FormattingEnabled = True
        Me.cbokelas.Location = New System.Drawing.Point(355, 55)
        Me.cbokelas.Name = "cbokelas"
        Me.cbokelas.Size = New System.Drawing.Size(124, 24)
        Me.cbokelas.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(262, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Kelas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 102)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(6, 54)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(102, 44)
        Me.BtnBatal.TabIndex = 92
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(109, 54)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(102, 44)
        Me.BtnHapus.TabIndex = 91
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(109, 10)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(102, 43)
        Me.BtnSimpan.TabIndex = 90
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(7, 10)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(101, 44)
        Me.BtnTambah.TabIndex = 89
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'cboJurusan
        '
        Me.cboJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJurusan.FormattingEnabled = True
        Me.cboJurusan.Location = New System.Drawing.Point(355, 79)
        Me.cboJurusan.Name = "cboJurusan"
        Me.cboJurusan.Size = New System.Drawing.Size(124, 24)
        Me.cboJurusan.TabIndex = 41
        '
        'txthp
        '
        Me.txthp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthp.ForeColor = System.Drawing.Color.Black
        Me.txthp.Location = New System.Drawing.Point(553, 79)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(165, 23)
        Me.txthp.TabIndex = 40
        '
        'txtalamat
        '
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.ForeColor = System.Drawing.Color.Black
        Me.txtalamat.Location = New System.Drawing.Point(553, 6)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(165, 70)
        Me.txtalamat.TabIndex = 39
        '
        'cbokelamin
        '
        Me.cbokelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbokelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbokelamin.FormattingEnabled = True
        Me.cbokelamin.Location = New System.Drawing.Point(355, 30)
        Me.cbokelamin.Name = "cbokelamin"
        Me.cbokelamin.Size = New System.Drawing.Size(124, 24)
        Me.cbokelamin.TabIndex = 38
        '
        'dptlahir
        '
        Me.dptlahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptlahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptlahir.Location = New System.Drawing.Point(91, 76)
        Me.dptlahir.Name = "dptlahir"
        Me.dptlahir.Size = New System.Drawing.Size(165, 24)
        Me.dptlahir.TabIndex = 37
        '
        'txttmptLahir
        '
        Me.txttmptLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttmptLahir.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttmptLahir.ForeColor = System.Drawing.Color.Black
        Me.txttmptLahir.Location = New System.Drawing.Point(91, 52)
        Me.txttmptLahir.Name = "txttmptLahir"
        Me.txttmptLahir.Size = New System.Drawing.Size(165, 23)
        Me.txttmptLahir.TabIndex = 30
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.Black
        Me.txtnama.Location = New System.Drawing.Point(91, 28)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(165, 23)
        Me.txtnama.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(262, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Jurusan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(485, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Nomor HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(485, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(262, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(262, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tempat Lahir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama"
        '
        'cboagama
        '
        Me.cboagama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboagama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboagama.FormattingEnabled = True
        Me.cboagama.Location = New System.Drawing.Point(355, 5)
        Me.cboagama.Name = "cboagama"
        Me.cboagama.Size = New System.Drawing.Size(124, 24)
        Me.cboagama.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "NIM"
        '
        'txtnim
        '
        Me.txtnim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnim.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnim.ForeColor = System.Drawing.Color.Black
        Me.txtnim.Location = New System.Drawing.Point(91, 4)
        Me.txtnim.MaxLength = 12
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(165, 23)
        Me.txtnim.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtcari)
        Me.Panel2.Location = New System.Drawing.Point(12, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 325)
        Me.Panel2.TabIndex = 79
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GrdView)
        Me.Panel3.Location = New System.Drawing.Point(2, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 288)
        Me.Panel3.TabIndex = 22
        '
        'GrdView
        '
        Me.GrdView.AllowUserToAddRows = False
        Me.GrdView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.GrdView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdView.BackgroundColor = System.Drawing.Color.White
        Me.GrdView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrdView.ColumnHeadersHeight = 24
        Me.GrdView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdView.DefaultCellStyle = DataGridViewCellStyle3
        Me.GrdView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdView.EnableHeadersVisualStyles = False
        Me.GrdView.GridColor = System.Drawing.Color.White
        Me.GrdView.Location = New System.Drawing.Point(0, 0)
        Me.GrdView.Margin = New System.Windows.Forms.Padding(5)
        Me.GrdView.MultiSelect = False
        Me.GrdView.Name = "GrdView"
        Me.GrdView.ReadOnly = True
        Me.GrdView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdView.RowHeadersWidth = 30
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.GrdView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrdView.RowTemplate.Height = 18
        Me.GrdView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdView.Size = New System.Drawing.Size(948, 286)
        Me.GrdView.TabIndex = 299
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(634, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(670, 3)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(279, 23)
        Me.txtcari.TabIndex = 20
        '
        'Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 584)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mahasiswa"
        Me.Text = "Mahasiswa"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboagama As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttmptLahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cboJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents txthp As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents cbokelamin As System.Windows.Forms.ComboBox
    Friend WithEvents dptlahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GrdView As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents cbokelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
