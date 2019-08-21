Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Pemasok

    Private Sub Pemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bersih()
        TidakAktif()
        TampilGrid()
        AturGrid()
        txtkode.Enabled = False
        BtnTambah.Enabled = True
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
    Sub IDautomatis()
        tutupkoneksi()
        txtkode.Enabled = False
        cekkoneksi()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        sqlcommand = New MySqlCommand("select * from supplier order by id_supplier desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("id_supplier"), 5, 6)
            strIsi = Val(strSementara) + 1
            txtkode.Text = "SP" + Mid("00000", 1, 6 - strIsi.Length) & strIsi
        Else
            txtkode.Text = "SP000001"
        End If
        txtnama.Focus()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim Message As DialogResult
        tutupkoneksi()
        cekkoneksi()
        sql = "SELECT * FROM supplier where id_supplier='" & txtkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        Message = ShowMessageBox("Apakah Anda Yakin Untuk Menghapus Data ini?", "Konfirmasi", MessageBoxType.Question)
        If Message = Windows.Forms.DialogResult.Yes Then
            tutupkoneksi()
            sql = "Delete From supplier where id_supplier ='" & txtkode.Text & "'"
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
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from supplier where " & _
        "nm_supplier like '" & Trim(txtcari.Text) & "%' order by id_supplier", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "Kode Supplier"
        Me.GrdView.Columns(1).HeaderText = "Nama"
        Me.GrdView.Columns(2).HeaderText = "Alamat"
        Me.GrdView.Columns(3).HeaderText = "Telphone"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 100
        GrdView.Columns(1).Width = 300
        GrdView.Columns(2).Width = 250
        GrdView.Columns(3).Width = 220
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtnama.Text = ""
        txttelp.Text = ""
        txtalamat.Text = ""
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
    End Sub
    Sub TidakAktif()
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            ShowMessageBox("Data Isian Harus Lengkap", "Critical", MessageBoxType.Critical)
        Else
            tutupkoneksi()
            cekkoneksi()
            sql = "SELECT * FROM supplier WHERE id_supplier='" & Trim(txtkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO supplier values ('" & txtkode.Text & "','" & _
                    txtnama.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
                sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                tutupkoneksi()
                cekkoneksi()
                sqlcommand.ExecuteNonQuery()
                bersih()
                tutupkoneksi()
                TampilGrid()
                ShowMessageBox("Data Berhasil Disimpan.", "Infomasi!", MessageBoxType.Information)
                TidakAktif()
                BtnTambah.Enabled = True
            Else
                sql = "UPDATE supplier set nm_supplier='" & txtnama.Text & "',almt_supplier='" & txtalamat.Text & "',tlp_supplier='" & txttelp.Text & "' WHERE id_supplier='" & Trim(txtkode.Text) & "'"
                sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
                tutupkoneksi()
                cekkoneksi()
                sqlcommand.ExecuteNonQuery()
                bersih()
                tutupkoneksi()
                TampilGrid()
                ShowMessageBox("Data Berhasil Diubah.", "Infomasi!", MessageBoxType.Information)
                TidakAktif()
                BtnTambah.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        bersih()
        TidakAktif()
        TampilGrid()
        BtnTambah.Enabled = True
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub
    Sub KlikGrid()
        Aktif()
        txtkode.Enabled = False
        txtkode.Text = GrdView.CurrentRow.Cells(0).Value
        txtnama.Text = GrdView.CurrentRow.Cells(1).Value
        txtalamat.Text = GrdView.CurrentRow.Cells(2).Value
        txttelp.Text = GrdView.CurrentRow.Cells(3).Value
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        bersih()
        IDautomatis()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
    End Sub

    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txttelp.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttelp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelp.TextChanged

    End Sub
End Class