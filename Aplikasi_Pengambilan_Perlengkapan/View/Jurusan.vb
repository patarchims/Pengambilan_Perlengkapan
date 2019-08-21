Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Jurusan

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        KodeAuto()
        txtnama.Enabled = True
        txtnama.Text = ""
        txtnama.Focus()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
        BtnTambah.Enabled = False
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
        lblnama.Text = ""
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = True
    End Sub
    Sub TidakAktif()
        txtnama.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
    End Sub

    Private Sub Jurusan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TidakAktif()
        TampilGrid()
        lblID.Hide()
        lblnama.Hide()
        AturGrid()
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" Select * FROM jurusan  where " & _
        "nama like '" & Trim(txtcari.Text) & "%' order by kd_jurusan", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "Kode Jurusan"
        Me.GrdView.Columns(1).HeaderText = "Nama Jurusan"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 115
        GrdView.Columns(1).Width = 950
    End Sub
    Sub KodeAuto()
        tutupkoneksi()
        lblnama.Hide()
        lblnama.Enabled = True
        cekkoneksi()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        sqlcommand = New MySqlCommand("select * from jurusan order by kd_jurusan desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("kd_jurusan"), 4, 5)
            strIsi = Val(strSementara) + 1
            lblnama.Text = "JRS" + Mid("00000", 1, 5 - strIsi.Length) & strIsi
        Else
            lblnama.Text = "JRS00001"
        End If
        txtnama.Focus()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtnama.Text = "" Then
            ShowMessageBox("Data Isian Harus Lengkap", "Critical", MessageBoxType.Critical)
        Else
            tutupkoneksi()
            cekkoneksi()
            sql = "SELECT * FROM jurusan  WHERE kd_jurusan='" & Trim(lblnama.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO jurusan values ('" & lblnama.Text & "','" & _
                     txtnama.Text & "')"
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
                sql = "UPDATE jurusan set nama='" & txtnama.Text & "' WHERE kd_jurusan='" & Trim(lblnama.Text) & "'"
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

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM jurusan where kd_jurusan='" & lblnama.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From jurusan where kd_jurusan ='" & lblnama.Text & "'"
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
    Sub KlikGrid()
        Aktif()
        txtnama.Enabled = True
        lblnama.Enabled = False
        lblnama.Text = ""
        lblnama.Hide()
        lblnama.Text = GrdView.CurrentRow.Cells(0).Value
        txtnama.Text = GrdView.CurrentRow.Cells(1).Value
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid()
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid()
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub

End Class