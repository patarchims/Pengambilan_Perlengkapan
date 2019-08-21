<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang_Masuk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang_Masuk))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrdView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblnomor = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBatalHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtbarang = New System.Windows.Forms.TextBox()
        Me.txtkdbarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dptTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.txtkdsupplier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrdBarang = New System.Windows.Forms.DataGridView()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
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
        Me.Label3.Location = New System.Drawing.Point(357, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 39)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Data Barang Masuk"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GrdView)
        Me.Panel3.Location = New System.Drawing.Point(23, 159)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(944, 287)
        Me.Panel3.TabIndex = 82
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
        Me.GrdView.Size = New System.Drawing.Size(944, 287)
        Me.GrdView.TabIndex = 298
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblnomor)
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtjumlah)
        Me.Panel2.Controls.Add(Me.txtbarang)
        Me.Panel2.Controls.Add(Me.txtkdbarang)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dptTanggal)
        Me.Panel2.Controls.Add(Me.txtsupplier)
        Me.Panel2.Controls.Add(Me.txtkdsupplier)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtnota)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(23, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(944, 108)
        Me.Panel2.TabIndex = 87
        '
        'lblnomor
        '
        Me.lblnomor.AutoSize = True
        Me.lblnomor.BackColor = System.Drawing.Color.Transparent
        Me.lblnomor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblnomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomor.Location = New System.Drawing.Point(429, 9)
        Me.lblnomor.Name = "lblnomor"
        Me.lblnomor.Size = New System.Drawing.Size(72, 18)
        Me.lblnomor.TabIndex = 92
        Me.lblnomor.Text = "NOMOR"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(628, 71)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(66, 27)
        Me.btnOK.TabIndex = 91
        Me.btnOK.Text = "OK"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBatalHapus)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(706, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 102)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        '
        'BtnBatalHapus
        '
        Me.BtnBatalHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnBatalHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBatalHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatalHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatalHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBatalHapus.Image = CType(resources.GetObject("BtnBatalHapus.Image"), System.Drawing.Image)
        Me.BtnBatalHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatalHapus.Location = New System.Drawing.Point(7, 55)
        Me.BtnBatalHapus.Name = "BtnBatalHapus"
        Me.BtnBatalHapus.Size = New System.Drawing.Size(102, 44)
        Me.BtnBatalHapus.TabIndex = 299
        Me.BtnBatalHapus.Text = "Batal"
        Me.BtnBatalHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatalHapus.UseVisualStyleBackColor = False
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
        Me.BtnBatal.Location = New System.Drawing.Point(7, 54)
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
        'txtjumlah
        '
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.ForeColor = System.Drawing.Color.Black
        Me.txtjumlah.Location = New System.Drawing.Point(572, 72)
        Me.txtjumlah.MaxLength = 12
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(50, 26)
        Me.txtjumlah.TabIndex = 45
        '
        'txtbarang
        '
        Me.txtbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbarang.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarang.ForeColor = System.Drawing.Color.Black
        Me.txtbarang.Location = New System.Drawing.Point(223, 72)
        Me.txtbarang.MaxLength = 12
        Me.txtbarang.Name = "txtbarang"
        Me.txtbarang.Size = New System.Drawing.Size(345, 26)
        Me.txtbarang.TabIndex = 44
        '
        'txtkdbarang
        '
        Me.txtkdbarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtkdbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkdbarang.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdbarang.ForeColor = System.Drawing.Color.Black
        Me.txtkdbarang.Location = New System.Drawing.Point(122, 71)
        Me.txtkdbarang.MaxLength = 12
        Me.txtkdbarang.Name = "txtkdbarang"
        Me.txtkdbarang.Size = New System.Drawing.Size(96, 26)
        Me.txtkdbarang.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "TANGGAL"
        '
        'dptTanggal
        '
        Me.dptTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptTanggal.Location = New System.Drawing.Point(547, 36)
        Me.dptTanggal.Name = "dptTanggal"
        Me.dptTanggal.Size = New System.Drawing.Size(147, 24)
        Me.dptTanggal.TabIndex = 38
        '
        'txtsupplier
        '
        Me.txtsupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtsupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsupplier.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplier.ForeColor = System.Drawing.Color.Black
        Me.txtsupplier.Location = New System.Drawing.Point(311, 34)
        Me.txtsupplier.MaxLength = 12
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.Size = New System.Drawing.Size(230, 26)
        Me.txtsupplier.TabIndex = 35
        '
        'txtkdsupplier
        '
        Me.txtkdsupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtkdsupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkdsupplier.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdsupplier.ForeColor = System.Drawing.Color.Black
        Me.txtkdsupplier.Location = New System.Drawing.Point(200, 34)
        Me.txtkdsupplier.MaxLength = 12
        Me.txtkdsupplier.Name = "txtkdsupplier"
        Me.txtkdsupplier.Size = New System.Drawing.Size(107, 26)
        Me.txtkdsupplier.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "SUPPLIER"
        '
        'txtnota
        '
        Me.txtnota.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtnota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnota.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnota.ForeColor = System.Drawing.Color.Black
        Me.txtnota.Location = New System.Drawing.Point(12, 34)
        Me.txtnota.MaxLength = 12
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(182, 26)
        Me.txtnota.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "No. Struk Pembelian"
        '
        'GrdBarang
        '
        Me.GrdBarang.AllowUserToAddRows = False
        Me.GrdBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GrdBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdBarang.Location = New System.Drawing.Point(248, 150)
        Me.GrdBarang.Name = "GrdBarang"
        Me.GrdBarang.RowHeadersVisible = False
        Me.GrdBarang.Size = New System.Drawing.Size(398, 128)
        Me.GrdBarang.TabIndex = 88
        '
        'lblitem
        '
        Me.lblitem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblitem.BackColor = System.Drawing.Color.Transparent
        Me.lblitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(586, 449)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(389, 41)
        Me.lblitem.TabIndex = 89
        Me.lblitem.Text = "TOTAL ITEM"
        Me.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 584)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.GrdBarang)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Barang_Masuk"
        Me.Text = "Barang_Masuk"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrdBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GrdView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dptTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtkdsupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtkdbarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrdBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblnomor As System.Windows.Forms.Label
    Friend WithEvents BtnBatalHapus As System.Windows.Forms.Button
    Friend WithEvents lblitem As System.Windows.Forms.Label
End Class
