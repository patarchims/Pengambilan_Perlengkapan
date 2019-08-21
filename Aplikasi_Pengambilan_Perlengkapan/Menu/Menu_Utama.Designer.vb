<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerbanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisMaskapaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TandaTerimaBarnagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMinimaze = New System.Windows.Forms.Label()
        Me.lblClosed = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.LblUser_Type = New System.Windows.Forms.Label()
        Me.Panel_Footer = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhari = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Fill = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.LblMinimaze)
        Me.Panel1.Controls.Add(Me.lblClosed)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 50)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(144, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 28)
        Me.Panel2.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.REPORTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerbanganToolStripMenuItem, Me.JenisMaskapaiToolStripMenuItem, Me.MahasiswaToolStripMenuItem, Me.BarangToolStripMenuItem, Me.PemasokBarangToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.FileToolStripMenuItem.Text = "Data Master"
        '
        'PenerbanganToolStripMenuItem
        '
        Me.PenerbanganToolStripMenuItem.Name = "PenerbanganToolStripMenuItem"
        Me.PenerbanganToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.PenerbanganToolStripMenuItem.Text = "Kelas"
        '
        'JenisMaskapaiToolStripMenuItem
        '
        Me.JenisMaskapaiToolStripMenuItem.Name = "JenisMaskapaiToolStripMenuItem"
        Me.JenisMaskapaiToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.JenisMaskapaiToolStripMenuItem.Text = "Jurusan"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PemasokBarangToolStripMenuItem
        '
        Me.PemasokBarangToolStripMenuItem.Name = "PemasokBarangToolStripMenuItem"
        Me.PemasokBarangToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.PemasokBarangToolStripMenuItem.Text = "Pemasok Perlengkapan"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengambilanBarangToolStripMenuItem, Me.BarangMasukToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.MenuToolStripMenuItem.Text = "Data Transakasi"
        '
        'PengambilanBarangToolStripMenuItem
        '
        Me.PengambilanBarangToolStripMenuItem.Name = "PengambilanBarangToolStripMenuItem"
        Me.PengambilanBarangToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PengambilanBarangToolStripMenuItem.Text = "Pengambilan Barang"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TandaTerimaBarnagToolStripMenuItem})
        Me.REPORTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.REPORTToolStripMenuItem.Text = "Laporan"
        '
        'TandaTerimaBarnagToolStripMenuItem
        '
        Me.TandaTerimaBarnagToolStripMenuItem.Name = "TandaTerimaBarnagToolStripMenuItem"
        Me.TandaTerimaBarnagToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.TandaTerimaBarnagToolStripMenuItem.Text = "Tanda Terima Perlengkapan"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(144, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(720, 22)
        Me.Panel5.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sistem Informasi Rekapitulasi Pengambilan Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMinimaze
        '
        Me.LblMinimaze.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LblMinimaze.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinimaze.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblMinimaze.Location = New System.Drawing.Point(861, 0)
        Me.LblMinimaze.Name = "LblMinimaze"
        Me.LblMinimaze.Size = New System.Drawing.Size(59, 50)
        Me.LblMinimaze.TabIndex = 3
        Me.LblMinimaze.Text = "-"
        Me.LblMinimaze.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClosed
        '
        Me.lblClosed.BackColor = System.Drawing.Color.Crimson
        Me.lblClosed.Font = New System.Drawing.Font("Franklin Gothic Medium", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblClosed.Location = New System.Drawing.Point(920, 0)
        Me.lblClosed.Name = "lblClosed"
        Me.lblClosed.Size = New System.Drawing.Size(59, 50)
        Me.lblClosed.TabIndex = 2
        Me.lblClosed.Text = "X"
        Me.lblClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Lbl_User)
        Me.Panel3.Controls.Add(Me.LblUser_Type)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(144, 50)
        Me.Panel3.TabIndex = 0
        '
        'Lbl_User
        '
        Me.Lbl_User.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_User.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl_User.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(144, 24)
        Me.Lbl_User.TabIndex = 4
        Me.Lbl_User.Text = "Username"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUser_Type
        '
        Me.LblUser_Type.BackColor = System.Drawing.Color.Transparent
        Me.LblUser_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblUser_Type.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser_Type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblUser_Type.Location = New System.Drawing.Point(0, 25)
        Me.LblUser_Type.Name = "LblUser_Type"
        Me.LblUser_Type.Size = New System.Drawing.Size(144, 25)
        Me.LblUser_Type.TabIndex = 3
        Me.LblUser_Type.Text = "User_Type"
        Me.LblUser_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Footer
        '
        Me.Panel_Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel_Footer.Controls.Add(Me.Label3)
        Me.Panel_Footer.Controls.Add(Me.Label2)
        Me.Panel_Footer.Controls.Add(Me.lblhari)
        Me.Panel_Footer.Controls.Add(Me.lbltime)
        Me.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Footer.Location = New System.Drawing.Point(0, 584)
        Me.Panel_Footer.Name = "Panel_Footer"
        Me.Panel_Footer.Size = New System.Drawing.Size(979, 50)
        Me.Panel_Footer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(686, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhari
        '
        Me.lblhari.BackColor = System.Drawing.Color.Transparent
        Me.lblhari.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhari.ForeColor = System.Drawing.SystemColors.Control
        Me.lblhari.Location = New System.Drawing.Point(798, 18)
        Me.lblhari.Name = "lblhari"
        Me.lblhari.Size = New System.Drawing.Size(169, 23)
        Me.lblhari.TabIndex = 19
        Me.lblhari.Text = "hari"
        Me.lblhari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltime.Location = New System.Drawing.Point(67, 16)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(187, 23)
        Me.lbltime.TabIndex = 18
        Me.lbltime.Text = "waktu"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Panel_Fill
        '
        Me.Panel_Fill.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel_Fill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Fill.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel_Fill.Location = New System.Drawing.Point(0, 50)
        Me.Panel_Fill.Name = "Panel_Fill"
        Me.Panel_Fill.Size = New System.Drawing.Size(979, 584)
        Me.Panel_Fill.TabIndex = 2
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 634)
        Me.Controls.Add(Me.Panel_Footer)
        Me.Controls.Add(Me.Panel_Fill)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Utama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel_Footer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblMinimaze As System.Windows.Forms.Label
    Friend WithEvents lblClosed As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Footer As System.Windows.Forms.Panel
    Friend WithEvents lblhari As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_User As System.Windows.Forms.Label
    Friend WithEvents LblUser_Type As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_Fill As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PenerbanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JenisMaskapaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengambilanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasokBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TandaTerimaBarnagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
