<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kelas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kelas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbojurusan = New System.Windows.Forms.ComboBox()
        Me.lblkode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosesi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrdView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnama)
        Me.Panel1.Controls.Add(Me.cbojurusan)
        Me.Panel1.Controls.Add(Me.lblkode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbosesi)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(15, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 50)
        Me.Panel1.TabIndex = 15
        '
        'cbojurusan
        '
        Me.cbojurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbojurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbojurusan.FormattingEnabled = True
        Me.cbojurusan.Location = New System.Drawing.Point(453, 11)
        Me.cbojurusan.Name = "cbojurusan"
        Me.cbojurusan.Size = New System.Drawing.Size(161, 24)
        Me.cbojurusan.TabIndex = 23
        '
        'lblkode
        '
        Me.lblkode.AutoSize = True
        Me.lblkode.BackColor = System.Drawing.Color.Transparent
        Me.lblkode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkode.ForeColor = System.Drawing.Color.Black
        Me.lblkode.Location = New System.Drawing.Point(863, 15)
        Me.lblkode.Name = "lblkode"
        Me.lblkode.Size = New System.Drawing.Size(85, 15)
        Me.lblkode.TabIndex = 22
        Me.lblkode.Text = "Nama Jurusan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(658, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sesi"
        '
        'cbosesi
        '
        Me.cbosesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbosesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosesi.FormattingEnabled = True
        Me.cbosesi.Location = New System.Drawing.Point(697, 11)
        Me.cbosesi.Name = "cbosesi"
        Me.cbosesi.Size = New System.Drawing.Size(137, 24)
        Me.cbosesi.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nama Jurusan"
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
        Me.BtnSimpan.Location = New System.Drawing.Point(409, 437)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(96, 43)
        Me.BtnSimpan.TabIndex = 74
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(511, 437)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(97, 44)
        Me.BtnBatal.TabIndex = 73
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
        Me.BtnHapus.Location = New System.Drawing.Point(614, 437)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(100, 44)
        Me.BtnHapus.TabIndex = 72
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(303, 437)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(101, 44)
        Me.BtnTambah.TabIndex = 71
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtcari)
        Me.Panel2.Location = New System.Drawing.Point(12, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 325)
        Me.Panel2.TabIndex = 16
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(637, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(673, 3)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(279, 23)
        Me.txtcari.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(978, 44)
        Me.Panel4.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(439, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 39)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Data Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nama Kelas"
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.Black
        Me.txtnama.Location = New System.Drawing.Point(109, 11)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(165, 23)
        Me.txtnama.TabIndex = 24
        '
        'Kelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 584)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kelas"
        Me.Text = "Kelas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbosesi As System.Windows.Forms.ComboBox
    Friend WithEvents lblkode As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GrdView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbojurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
End Class
