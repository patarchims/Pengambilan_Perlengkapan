Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Kelas
    Sub Jurusan()
        On Error Resume Next
        cbojurusan.Items.Clear()
        cekkoneksi()
        sql = "Select * From jurusan"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        If Dr.HasRows Then
            Do Until Not Dr.Read
                cbojurusan.Items.Add(Dr!nama)
            Loop
        Else
            cbojurusan.Items.Clear()
        End If
        tutupkoneksi()
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

    Private Sub Kelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TidakAktif()
        TampilGrid()
        lblkode.Hide()
        Sesi()
        AturGrid()
        Jurusan()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Bersih()
        cbojurusan.Enabled = False
        TidakAktif()
        BtnTambah.Enabled = True
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM kelas where kd_kelas='" & lblkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From kelas where kd_kelas ='" & lblkode.Text & "'"
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
        sqlcommand = New MySqlCommand("select * from kelas order by kd_kelas desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("kd_kelas"), 4, 5)
            strIsi = Val(strSementara) + 1
            lblkode.Text = "KLS" + Mid("00000", 1, 5 - strIsi.Length) & strIsi
        Else
            lblkode.Text = "KLS00001"
        End If
        cbojurusan.Focus()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If cbojurusan.Text = "" Then
            ShowMessageBox("Data Isian Harus Lengkap", "Critical", MessageBoxType.Critical)
        Else
            tutupkoneksi()
            cekkoneksi()
            sql = "SELECT * FROM kelas  WHERE kd_kelas='" & Trim(lblkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO kelas values ('" & lblkode.Text & "','" & _
                     txtnama.Text & "','" & cbojurusan.Text & "','" & cbosesi.Text & "')"
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
                sql = "UPDATE kelas set nama='" & txtnama.Text & "',jurusan='" & cbojurusan.Text & "', sesi='" & cbosesi.Text & "'WHERE kd_kelas='" & Trim(lblkode.Text) & "'"
                sql = "INSERT INTO kelas values ('" & lblkode.Text & "','" & _
                     txtnama.Text & "','" & cbojurusan.Text & "','" & cbosesi.Text & "')"
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
    Sub Bersih()
        cbojurusan.Text = ""
        lblkode.Text = ""
        txtnama.Text = ""
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = True
        cbojurusan.Enabled = True
        cbosesi.Enabled = True
        txtnama.Enabled = True
    End Sub
    Sub TidakAktif()
        cbojurusan.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        txtnama.Enabled = False
        BtnSimpan.Enabled = False
        cbosesi.Enabled = False
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" Select * FROM kelas  where " & _
        "nama like '" & Trim(txtcari.Text) & "%' order by kd_kelas", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "Kode Kelas"
        Me.GrdView.Columns(1).HeaderText = "Nama Kelas"
        Me.GrdView.Columns(2).HeaderText = "Jurusan"
        Me.GrdView.Columns(3).HeaderText = "Sesi"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 115
        GrdView.Columns(1).Width = 350
        GrdView.Columns(2).Width = 250
        GrdView.Columns(3).Width = 150
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub
    Sub Sesi()
        cbosesi.Items.Clear()
        cbosesi.Items.Add("Pagi")
        cbosesi.Items.Add("Siang")
        cbosesi.Items.Add("Malam")
    End Sub
    Sub KlikGrid()
        Aktif()
        Bersih()
        txtnama.Enabled = True
        lblkode.Text = GrdView.CurrentRow.Cells(0).Value
        txtnama.Text = GrdView.CurrentRow.Cells(1).Value
        cbojurusan.Text = GrdView.CurrentRow.Cells(2).Value
        cbosesi.Text = GrdView.CurrentRow.Cells(3).Value
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid()
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid()
    End Sub

    Private Sub cbojurusan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbojurusan.Click
        Jurusan()
    End Sub


    Private Sub txtnama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbojurusan.SelectedIndexChanged

    End Sub
End Class