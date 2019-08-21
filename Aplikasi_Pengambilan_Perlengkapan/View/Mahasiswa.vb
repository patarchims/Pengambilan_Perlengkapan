Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Mahasiswa

    Private Sub Mahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bersih()
        TidakAktif()
        Jurusan()
        Kelas()
        Agama()
        TampilGrid()
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
        txtnim.Text = ""
        txtalamat.Text = ""
        cboagama.Items.Clear()
        cbokelamin.Items.Clear()
        txthp.Text = ""
        cboJurusan.Items.Clear()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Aktif()
        Bersih()
        txtnim.Focus()
        Jurusan()
        Kelas()
    End Sub
    
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = True
        txtnama.Enabled = True
        cboagama.Enabled = True
        txtnim.Enabled = True
        txttmptLahir.Enabled = True
        dptlahir.Enabled = True
        cbokelamin.Enabled = True
        txtalamat.Enabled = True
        txthp.Enabled = True
        cboJurusan.Enabled = True
        cbokelamin.Enabled = True
        cbokelas.Enabled = True
    End Sub
    Sub TidakAktif()
        txtnim.Enabled = False
        txtnama.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        cboagama.Enabled = False
        dptlahir.Enabled = False
        cbokelamin.Enabled = False
        txtalamat.Enabled = False
        txthp.Enabled = False
        cboJurusan.Enabled = False
        txttmptLahir.Enabled = False
        cbokelas.Enabled = False
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT mahasiswa.nim, mahasiswa.nama, mahasiswa.tmp_lahir, mahasiswa.tgl_lahir, mahasiswa.agama, mahasiswa.kelamin, mahasiswa.alamat, mahasiswa.telp, mahasiswa.jurusan, kelas.nama as Kelas from mahasiswa inner join kelas on kelas.kd_kelas=mahasiswa.kd_kelas  where " & _
        "nim like '" & Trim(txtcari.Text) & "%' order by nim", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "NIM"
        Me.GrdView.Columns(1).HeaderText = "Nama"
        Me.GrdView.Columns(2).HeaderText = "Tempat Lahir"
        Me.GrdView.Columns(3).HeaderText = "Tanggal Lahir"
        Me.GrdView.Columns(4).HeaderText = "Agama"
        Me.GrdView.Columns(5).HeaderText = "Jenis Kelamin"
        Me.GrdView.Columns(6).HeaderText = "Alamat"
        Me.GrdView.Columns(7).HeaderText = "Telephone"
        Me.GrdView.Columns(8).HeaderText = "Jurusan"
        Me.GrdView.Columns(9).HeaderText = "Kelas"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 95
        GrdView.Columns(1).Width = 150
        GrdView.Columns(2).Width = 100
        GrdView.Columns(3).Width = 65
        GrdView.Columns(4).Width = 75
        GrdView.Columns(5).Width = 75
        GrdView.Columns(6).Width = 85
        GrdView.Columns(7).Width = 75
        GrdView.Columns(8).Width = 100
        GrdView.Columns(9).Width = 75
    End Sub
    Sub Agama()
        cboagama.Items.Clear()
        cboagama.Items.Add("Islam")
        cboagama.Items.Add("Kristen Protestan")
        cboagama.Items.Add("Katolik")
        cboagama.Items.Add("Hindu")
        cboagama.Items.Add("Buddha")
        cboagama.Items.Add("Kong Hu Cu")
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtnama.Text = "" Or txtnim.Text = "" Or txttmptLahir.Text = "" Or txtalamat.Text = "" Or cboagama.Text = "" Or cbokelamin.Text = "" Or cboJurusan.Text = "" Or txthp.Text = "" Then
            ShowMessageBox("Data Isian Harus Lengkap", "Critical", MessageBoxType.Critical)
        Else
            tutupkoneksi()
            cekkoneksi()
            sql = "SELECT * FROM mahasiswa WHERE nim='" & Trim(txtnim.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO mahasiswa values ('" & txtnim.Text & "','" & _
                     txtnama.Text & "','" & txttmptLahir.Text & "','" & Format(dptlahir.Value, "yyyy/MM/dd") & "','" & _
                     cboagama.Text & "','" & cbokelamin.Text & "','" & txtalamat.Text & "','" & txthp.Text & "','" & _
                     cboJurusan.Text & "','" & Microsoft.VisualBasic.Left(cbokelas.Text, 8) & "')"
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
                sql = "UPDATE mahasiswa set nama='" & txtnama.Text & "', tmp_lahir ='" & txttmptLahir.Text & "', tgl_lahir='" & _
                    Format(dptlahir.Value, "yyyy/MM/dd") & "', agama='" & cboagama.Text & "', kelamin='" & cbokelamin.Text & "', alamat='" & _
                    txtalamat.Text & "' , telp='" & txthp.Text & "', jurusan='" & cboJurusan.Text & _
                    "',  telp='" & Microsoft.VisualBasic.Left(cbokelas.Text, 8) & "' WHERE nim='" & Trim(txtnim.Text) & "'"
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
    Sub Jurusan()
        On Error Resume Next
        cboJurusan.Items.Clear()
        cekkoneksi()
        sql = "Select * From jurusan"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        If Dr.HasRows Then
            Do Until Not Dr.Read
                cboJurusan.Items.Add(Dr!nama)
            Loop
        Else
            cboJurusan.Items.Clear()
        End If
        tutupkoneksi()
    End Sub
    Sub Kelas()
        On Error Resume Next
        cbokelas.Items.Clear()
        cekkoneksi()
        sql = "Select * From kelas"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        If Dr.HasRows Then
            Do Until Not Dr.Read
                cbokelas.Items.Add(Dr!kd_kelas & "|" & Dr!nama)
            Loop
        Else
            cbokelas.Items.Clear()
        End If
        tutupkoneksi()
    End Sub

    Private Sub cboJurusan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboJurusan.Click

    End Sub

    Private Sub cboJurusan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJurusan.SelectedIndexChanged

    End Sub

    Private Sub cbokelas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokelas.SelectedIndexChanged

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM mahasiswa where nim='" & txtnim.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From mahasiswa where nim='" & txtnim.Text & "'"
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

    Private Sub txtnim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnim.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txtnim.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnim.TextChanged

    End Sub

    Private Sub txthp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthp.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txthp.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txthp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthp.TextChanged
        
    End Sub
    Sub KlikGrid()
        Aktif()
        On Error Resume Next
        cbokelas.Items.Clear()
        cekkoneksi()
        sql = "Select * From kelas WHERE nama='" & GrdView.CurrentRow.Cells(9).Value & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        If Dr.HasRows Then
            Do Until Not Dr.Read
                cbokelas.Text = Dr!kd_kelas & " | " & Dr!nama
                txtnim.Enabled = False
                txtnim.Text = GrdView.CurrentRow.Cells(0).Value
                txtnama.Text = GrdView.CurrentRow.Cells(1).Value
                txttmptLahir.Text = GrdView.CurrentRow.Cells(2).Value
                dptlahir.Text = GrdView.CurrentRow.Cells(3).Value
                cboagama.Text = GrdView.CurrentRow.Cells(4).Value
                cbokelamin.Text = GrdView.CurrentRow.Cells(5).Value
                txtalamat.Text = GrdView.CurrentRow.Cells(6).Value
                txthp.Text = GrdView.CurrentRow.Cells(7).Value
                cboJurusan.Text = GrdView.CurrentRow.Cells(8).Value
            Loop
        Else
            cbokelas.Items.Clear()
        End If
        tutupkoneksi()
        Jurusan()
        Kelas()
    End Sub

    Private Sub cboagama_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboagama.Click
        Agama()
    End Sub
    Sub JenisKelamin()
        cbokelamin.Items.Clear()
        cbokelamin.Items.Add("Laki-Laki")
        cbokelamin.Items.Add("Perempuan")
    End Sub
    Private Sub cboagama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboagama.SelectedIndexChanged

    End Sub

    Private Sub cbokelamin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbokelamin.Click
        JenisKelamin()
    End Sub

    Private Sub cbokelamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokelamin.SelectedIndexChanged

    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid()
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid()
    End Sub
End Class