Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Barang_Masuk

    Private Sub Barang_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GrdBarang.Visible = False
        lblitem.Text = ""
        Bersih()
        TidakAktif()
        lblnomor.Hide()
        'BersihPembelian()
        BtnBatalHapus.Hide()
    End Sub
    Private Sub BtnTambah_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnTambah.BackColor = Color.FromArgb(4, 137, 60)
        BtnTambah.ForeColor = Color.Black
    End Sub

    Private Sub BtnTambah_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnTambah.BackColor = Color.FromArgb(0, 211, 91)
        BtnTambah.ForeColor = Color.White
    End Sub

    Private Sub BtnSimpan_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnSimpan.BackColor = Color.FromArgb(4, 137, 60)
        BtnSimpan.ForeColor = Color.Black
    End Sub

    Private Sub BtnSimpan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnSimpan.BackColor = Color.FromArgb(0, 211, 91)
        BtnSimpan.ForeColor = Color.White
    End Sub

    Private Sub BtnBatal_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnBatal.BackColor = Color.FromArgb(4, 137, 60)
        BtnBatal.ForeColor = Color.Black
    End Sub

    Private Sub BtnBatal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnBatal.BackColor = Color.FromArgb(0, 211, 91)
        BtnBatal.ForeColor = Color.White
    End Sub

    Private Sub BtnHapus_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnHapus.BackColor = Color.FromArgb(4, 137, 60)
        BtnHapus.ForeColor = Color.Black
    End Sub

    Private Sub BtnHapus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnHapus.BackColor = Color.FromArgb(0, 211, 91)
        BtnHapus.ForeColor = Color.White
    End Sub

    Sub Bersih()
        txtbarang.Text = ""
        txtjumlah.Text = ""
        txtkdbarang.Text = ""
        txtnota.Text = ""
        txtsupplier.Text = ""
        txtkdsupplier.Text = ""
    End Sub
    Sub TidakAktif()
        dptTanggal.Enabled = False
        txtkdbarang.Enabled = False
        txtbarang.Enabled = False
        txtjumlah.Enabled = False
        btnOK.Enabled = False
        BtnBatal.Enabled = False
        BtnSimpan.Enabled = False
        BtnHapus.Enabled = False
        txtnota.Enabled = False
        txtkdsupplier.Enabled = False
        txtsupplier.Enabled = False
    End Sub

    Sub TampilBarang()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT barang.kd_barang, barang.nm_barang, barang.stok from barang where " & _
        "nm_barang like '" & Trim(txtbarang.Text) & "%' order by kd_barang", conn)
        Adapter.Fill(table)
        GrdBarang.DataSource = table
        GrdBarang.Refresh()
        tutupkoneksi()
        Me.GrdBarang.Columns(0).HeaderText = "Kode Barang"
        Me.GrdBarang.Columns(1).HeaderText = "Nama Barang"
        Me.GrdBarang.Columns(2).HeaderText = "Stok"
    End Sub

    Sub GridBarangKlik()
        txtkdbarang.Text = GrdBarang.CurrentRow.Cells(0).Value
        txtbarang.Text = GrdBarang.CurrentRow.Cells(1).Value
        txtjumlah.Focus()
        GrdBarang.Visible = False
        btnOK.Enabled = True
    End Sub

    Private Sub txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        txtjumlah.Text = FormatNumber(txtjumlah.Text, 0)
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = True
        txtkdbarang.Enabled = True
        txtbarang.Enabled = True
        txtjumlah.Enabled = True
        dptTanggal.Enabled = True
    End Sub

    Sub Bersih_Masuk()
        txtkdbarang.Text = ""
        txtjumlah.Text = ""
        txtbarang.Text = ""
    End Sub
    Sub tambahstok()
        On Error Resume Next
        cekkoneksi()
        sql = "Update barang set stok=stok + " & txtjumlah.Text & " where kd_barang='" & Trim(txtkdbarang.Text) & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        TutupKoneksi()
        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, vbCritical)
    End Sub
    Sub TampilGridBarangMasuk()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT barang_masuk_detail.no,  barang_masuk_detail.struk, barang.nm_barang,  barang_masuk_detail.jml_masuk FROM  barang_masuk_detail inner join barang on barang.kd_barang= barang_masuk_detail.kd_barang where " & _
        "struk = '" & Trim(txtnota.Text) & "' order by no", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "Nomor"
        Me.GrdView.Columns(1).HeaderText = "Struk"
        Me.GrdView.Columns(2).HeaderText = "Nama Barang"
        Me.GrdView.Columns(3).HeaderText = "Jumlah Masuk"
        GrdView.Columns(0).Width = 115
        GrdView.Columns(1).Width = 450
        GrdView.Columns(2).Width = 270
        GrdView.Columns(3).Width = 150
    End Sub

   
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        IDautomatis()
        frmBrowseSupplier.ShowDialog()
    End Sub
    Sub IDautomatis()
        Dim sekarang As Date = Today
        tutupkoneksi()
        txtnota.Enabled = False
        cekkoneksi()
        Dim strSementara As String
        Dim strIsi As String
        sqlcommand = New MySqlCommand("select * from barang_masuk order by struk desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("struk"), 15, 16)
            strIsi = Val(strSementara) + 1
            txtnota.Text = Format(sekarang, "yyyy") & Format(sekarang, "MM") & Format(sekarang, "dd") & Format(Now, "hh") & Format(Now, "mm") & Format(Now, "ss") + Mid("00", 1, 2 - strIsi.Length) & strIsi
        Else
            txtnota.Text = Format(sekarang, "yyyy") & Format(sekarang, "MM") & Format(sekarang, "dd") & Format(Now, "hh") & Format(Now, "mm") & Format(Now, "ss") + "01"

        End If
        'btnplus.Focus()
    End Sub


    Private Sub txtbarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarang.TextChanged
        If txtbarang.Text = "" Then
            GrdBarang.Visible = False
        Else
            GrdBarang.Visible = True
            TampilBarang()
        End If
    End Sub

    Private Sub GrdBarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBarang.CellContentClick
        GridBarangKlik()
    End Sub

    Private Sub GrdBarang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdBarang.Click
        GridBarangKlik()
    End Sub


    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Bersih()
        TidakAktif()
        BtnTambah.Enabled = True
    End Sub

 
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtjumlah.Text = "" Then
            ShowMessageBox("Anda Belum Memasukkan Jumlah Barang", "Critical", MessageBoxType.Critical)
        Else
            cekkoneksi()
            sql = "SELECT * FROM barang_masuk_detail "
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            sql = "INSERT INTO barang_masuk_detail values (NULL,'" & txtnota.Text & "','" & _
                txtkdbarang.Text & "','" & txtjumlah.Text & "')"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            tutupkoneksi()
            cekkoneksi()
            sqlcommand.ExecuteNonQuery()
            tambahstok()
            Bersih_Masuk()
            tutupkoneksi()
            TampilGridBarangMasuk()
            hitung()
        End If
    End Sub

    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtjumlah.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid_View()
        txtkdbarang.Enabled = False
        txtbarang.Enabled = False
        txtjumlah.Enabled = False
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnBatal.Hide()
        BtnBatalHapus.Show()
    End Sub
    Sub KlikGrid_View()
        Aktif()
        lblnomor.Text = GrdView.CurrentRow.Cells(0).Value
        txtbarang.Text = GrdView.CurrentRow.Cells(2).Value
        txtjumlah.Text = GrdView.CurrentRow.Cells(3).Value
        GrdBarang.Visible = False
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid_View()
        txtkdbarang.Enabled = False
        txtbarang.Enabled = False
        txtjumlah.Enabled = False
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnBatal.Hide()
        BtnBatalHapus.Show()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM barang_masuk_detail where no='" & lblnomor.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From barang_masuk_detail where no ='" & lblnomor.Text & "'"
            cekkoneksi()
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            sqlcommand.ExecuteNonQuery()
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            tutupkoneksi()
            cekkoneksi()
            sqlcommand.ExecuteNonQuery()
            TampilGridBarangMasuk()
            kurangstok()
            Bersih_Masuk()
            tutupkoneksi()
            ShowMessageBox("Data Berhasil Dihapus.", "Infomasi!", MessageBoxType.Information)
            TidakAktif()
            BtnSimpan.Enabled = True
            BtnBatalHapus.Show()
            BtnBatalHapus.Enabled = True
            txtbarang.Enabled = True
            txtjumlah.Enabled = True
            hitung()
        Else
            Exit Sub
            TampilGridBarangMasuk()
        End If
    End Sub
    Sub kurangstok()
        On Error Resume Next
        cekkoneksi()
        sql = "Update barang set stok=stok - " & txtjumlah.Text & " where kd_barang='" & Trim(txtkdbarang.Text) & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        tutupkoneksi()
        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, vbCritical)
    End Sub

    Private Sub BtnBatalHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatalHapus.Click
        On Error Resume Next
        txtbarang.Text = ""
        txtkdbarang.Text = ""
        txtjumlah.Text = ""
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = False
        BtnBatalHapus.Hide()
        BtnBatal.Show()
        BtnBatal.Enabled = False
        GrdBarang.Visible = False
        txtbarang.Focus()
        txtbarang.Enabled = True
        txtjumlah.Enabled = True
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        On Error Resume Next
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM barang_masuk  "
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader()
        Dr.Read()
        sql = "INSERT INTO barang_masuk values ('" & txtnota.Text & "','" & _
           Format(dptTanggal.Value, "yyyy/MM/dd") & "','" & txtkdsupplier.Text & "')"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        Bersih()
        tutupkoneksi()
        ShowMessageBox("Data Berhasil Disimpan.", "Infomasi!", MessageBoxType.Information)
        TidakAktif()
        BtnTambah.Enabled = True
        TampilGridBarangMasuk()
        lblitem.Text = ""
    End Sub
    Sub hitung()
        On Error Resume Next
        cekkoneksi()
        sql = "SELECT SUM(jml_masuk) As Jumlah_Masuk from barang_masuk_detail where struk='" & Trim(txtnota.Text) & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dim rs As Integer
        rs = sqlcommand.ExecuteScalar
        lblitem.Text = "Jumlah Barang Masuk " & rs
    End Sub

 
End Class
