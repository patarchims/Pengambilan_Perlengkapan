Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Menu_Utama

    Private Sub Menu_Utama_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblhari.Text = Format(Now, "dd  MMMM yyyy")
    End Sub

    Private Sub Menu_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblClosed.BackColor = Color.FromArgb(9, 134, 60)
        LblMinimaze.BackColor = Color.FromArgb(39, 252, 130)
        Dasboard()
        Timer1.Start()
    End Sub
    Sub Dasboard()
        Panel_Fill.Controls.Clear()
        Dashboard.TopLevel = False
        Panel_Fill.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub
    Private Sub LblMinimaze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMinimaze.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LblMinimaze_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblMinimaze.MouseEnter
        LblMinimaze.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub LblMinimaze_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblMinimaze.MouseLeave
        LblMinimaze.BackColor = Color.FromArgb(39, 252, 130)
    End Sub

    Private Sub lblClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClosed.Click

        Dim Reply As New DialogResult
        Reply = ShowMessageBox("Apakah Anda Yakin Untuk Keluar dari Aplikasi ini?", "Konfirmasi", MessageBoxType.Question)

        If Reply = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Me.Show()
        End If

    End Sub

    Private Sub lblClosed_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseEnter
        lblClosed.BackColor = Color.Crimson
    End Sub

    Private Sub lblClosed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseLeave
        lblClosed.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub Panel_Fill_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_Fill.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Reply As New DialogResult
        Reply = ShowMessageBox("Apakah Anda Yakin Untuk Keluar dari Aplikasi ini?", "Konfirmasi", MessageBoxType.Question)

        If Reply = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Me.Show()
        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub CetakStikerBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmStikerBarang.ShowDialog()
    End Sub


    Private Sub CetakStikerPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmStikerPC.ShowDialog()
    End Sub

    Private Sub PenerbanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenerbanganToolStripMenuItem.Click
        DataKelas()
    End Sub

    Sub Jurusan_Mahasiswa()
        Panel_Fill.Controls.Clear()
        Jurusan.TopLevel = False
        Panel_Fill.Controls.Add(Jurusan)
        Jurusan.Show()
    End Sub

    Sub DataKelas()
        Panel_Fill.Controls.Clear()
        Kelas.TopLevel = False
        Panel_Fill.Controls.Add(Kelas)
        Kelas.Show()
    End Sub

    Private Sub JenisMaskapaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisMaskapaiToolStripMenuItem.Click
        Jurusan_Mahasiswa()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        BarangMenu()
    End Sub
    Sub BarangMenu()
        Panel_Fill.Controls.Clear()
        Barang.TopLevel = False
        Panel_Fill.Controls.Add(Barang)
        Barang.Show()
    End Sub
   
    Private Sub MahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaToolStripMenuItem.Click
        DataMahasiswa()
    End Sub
    Sub DataMahasiswa()
        Panel_Fill.Controls.Clear()
        Mahasiswa.TopLevel = False
        Panel_Fill.Controls.Add(Mahasiswa)
        Mahasiswa.Show()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangMasukToolStripMenuItem.Click
        BarangMasuk()
    End Sub
    Sub BarangMasuk()
        Panel_Fill.Controls.Clear()
        Barang_Masuk.TopLevel = False
        Panel_Fill.Controls.Add(Barang_Masuk)
        Barang_Masuk.Show()
    End Sub

    Private Sub PemasokBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemasokBarangToolStripMenuItem.Click
        Pemasok_Barang()
    End Sub
    Sub Pemasok_Barang()
        Panel_Fill.Controls.Clear()
        Pemasok.TopLevel = False
        Panel_Fill.Controls.Add(Pemasok)
        Pemasok.Show()
    End Sub

    Private Sub PengambilanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengambilanBarangToolStripMenuItem.Click
        Ambil_Barang()
    End Sub
    Sub Ambil_Barang()
        Panel_Fill.Controls.Clear()
        Pengambilan_Barang.TopLevel = False
        Panel_Fill.Controls.Add(Pengambilan_Barang)
        Pengambilan_Barang.Show()
    End Sub

    Private Sub TandaTerimaBarnagToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TandaTerimaBarnagToolStripMenuItem.Click
        Perlengkapan()
    End Sub
    Sub Perlengkapan()
        Panel_Fill.Controls.Clear()
        frmTandaTerima.TopLevel = False
        Panel_Fill.Controls.Add(frmTandaTerima)
        frmTandaTerima.Show()
    End Sub
    Sub LaporanPerlengkapan()
        Panel_Fill.Controls.Clear()
        frmReportPenerimaPerlengkapan.TopLevel = False
        Panel_Fill.Controls.Add(frmReportPenerimaPerlengkapan)
        frmReportPenerimaPerlengkapan.Show()
    End Sub
    Private Sub LaporanPenerimaPerlengkapanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenerimaPerlengkapanToolStripMenuItem.Click
        LaporanPerlengkapan()
    End Sub
End Class