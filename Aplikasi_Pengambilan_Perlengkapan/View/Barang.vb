Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Barang

    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TidakAktif()
        TampilGrid()
        lblkode.Hide()
        AturGrid()
        Jenis()
        Satuan()
    End Sub
    Private Sub BtnTambah_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTambah.MouseEnter
        BtnTambah.BackColor = Color.FromArgb(4, 137, 60)
        BtnTambah.ForeColor = Color.Black
    End Sub

    Private Sub BtnTambah_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTambah.MouseLeave
        BtnTambah.BackColor = Color.FromArgb(0, 211, 91)
        BtnTambah.ForeColor = Color.White
    End Sub

    Private Sub BtnSimpan_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.MouseEnter
        BtnSimpan.BackColor = Color.FromArgb(4, 137, 60)
        BtnSimpan.ForeColor = Color.Black
    End Sub

    Private Sub BtnSimpan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.MouseLeave
        BtnSimpan.BackColor = Color.FromArgb(0, 211, 91)
        BtnSimpan.ForeColor = Color.White
    End Sub

    Private Sub BtnBatal_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.MouseEnter
        BtnBatal.BackColor = Color.FromArgb(4, 137, 60)
        BtnBatal.ForeColor = Color.Black
    End Sub

    Private Sub BtnBatal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.MouseLeave
        BtnBatal.BackColor = Color.FromArgb(0, 211, 91)
        BtnBatal.ForeColor = Color.White
    End Sub

    Private Sub BtnHapus_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapus.MouseEnter
        BtnHapus.BackColor = Color.FromArgb(4, 137, 60)
        BtnHapus.ForeColor = Color.Black
    End Sub

    Private Sub BtnHapus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapus.MouseLeave
        BtnHapus.BackColor = Color.FromArgb(0, 211, 91)
        BtnHapus.ForeColor = Color.White
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Bersih()
        txtnama.Enabled = False
        TidakAktif()
        BtnTambah.Enabled = True
    End Sub
    Sub Bersih()
        txtnama.Text = ""
        txtstok.Text = ""
        lblkode.Text = ""
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        KodeAuto()
        txtnama.Enabled = True
        txtnama.Text = ""
        txtnama.Focus()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
        BtnTambah.Enabled = False
    End Sub
    Sub KodeAuto()
        tutupkoneksi()
        Aktif()
        lblkode.Hide()
        cekkoneksi()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        sqlcommand = New MySqlCommand("select * from barang order by kd_barang desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("kd_barang"), 4, 5)
            strIsi = Val(strSementara) + 1
            lblkode.Text = "BRG" + Mid("00000", 1, 5 - strIsi.Length) & strIsi
        Else
            lblkode.Text = "BRG00001"
        End If
        txtnama.Focus()
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = True
        txtnama.Enabled = True
        cbojenis.Enabled = True
        cbosatuan.Enabled = True
        txtstok.Enabled = True
    End Sub
    Sub TidakAktif()
        txtnama.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        cbojenis.Enabled = False
        cbosatuan.Enabled = False
        txtstok.Enabled = False
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" Select * FROM barang  where " & _
        "nm_barang like '" & Trim(txtcari.Text) & "%' order by kd_barang", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "Kode Barang"
        Me.GrdView.Columns(1).HeaderText = "Nama Barang"
        Me.GrdView.Columns(2).HeaderText = "Jenis"
        Me.GrdView.Columns(2).HeaderText = "Satuan"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 115
        GrdView.Columns(1).Width = 300
        GrdView.Columns(2).Width = 270
        GrdView.Columns(3).Width = 150
        GrdView.Columns(4).Width = 100
    End Sub
    Sub Jenis()
        cbojenis.Items.Clear()
        cbojenis.Items.Add("Pakaian Seragam")
        cbojenis.Items.Add("Elektronika")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM barang where kd_barang='" & lblkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From barang where kd_barang ='" & lblkode.Text & "'"
            cekkoneksi()
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            sqlcommand.ExecuteNonQuery()
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            tutupkoneksi()
            cekkoneksi()
            sqlcommand.ExecuteNonQuery()
            TampilGrid()
            Bersih()
            tutupkoneksi()
            ShowMessageBox("Data Berhasil Dihapus.", "Infomasi!", MessageBoxType.Information)
            TidakAktif()
            BtnTambah.Enabled = True
        Else
            Exit Sub
            TampilGrid()
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtnama.Text = "" Or txtstok.Text = "" Or cbojenis.Text = "" Or cbosatuan.Text = "" Then
            ShowMessageBox("Data Isian Harus Lengkap", "Critical", MessageBoxType.Critical)
        Else
            tutupkoneksi()
            cekkoneksi()
            sql = "SELECT * FROM barang  WHERE kd_barang='" & Trim(lblkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO barang values ('" & lblkode.Text & "','" & _
                     txtnama.Text & "','" & cbojenis.Text & "','" & txtstok.Text & "','" & cbosatuan.Text & "')"
                sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                tutupkoneksi()
                cekkoneksi()
                sqlcommand.ExecuteNonQuery()
                Bersih()
                tutupkoneksi()
                TampilGrid()
                ShowMessageBox("Data Berhasil Disimpan.", "Infomasi!", MessageBoxType.Information)
                TidakAktif()
                BtnTambah.Enabled = True
            Else
                sql = "UPDATE barang set  nm_barang='" & txtnama.Text & "', jenis='" & cbojenis.Text & "', stok='" & txtstok.Text & "', satuan='" & cbosatuan.Text & "'WHERE kd_barang='" & Trim(lblkode.Text) & "'"
                sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                tutupkoneksi()
                cekkoneksi()
                sqlcommand.ExecuteNonQuery()
                Bersih()
                tutupkoneksi()
                TampilGrid()
                ShowMessageBox("Data Berhasil Diubah.", "Infomasi!", MessageBoxType.Information)
                TidakAktif()
                BtnTambah.Enabled = True
            End If
            
        End If
    End Sub
    Sub KlikGrid()
        Aktif()
        Bersih()
        txtnama.Enabled = True
        lblkode.Text = GrdView.CurrentRow.Cells(0).Value
        txtnama.Text = GrdView.CurrentRow.Cells(1).Value
        cbojenis.Text = GrdView.CurrentRow.Cells(2).Value
        txtstok.Text = GrdView.CurrentRow.Cells(3).Value
        cbojenis.Text = GrdView.CurrentRow.Cells(4).Value
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid()
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid()
    End Sub

    Sub Satuan()
        cbosatuan.Items.Clear()
        cbosatuan.Items.Add("Buah")
        cbosatuan.Items.Add("Bungkus")
        cbosatuan.Items.Add("Biji")
        cbosatuan.Items.Add("Exsemplar")
    End Sub

    Private Sub txtstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstok.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtstok.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtstok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstok.TextChanged

    End Sub
End Class