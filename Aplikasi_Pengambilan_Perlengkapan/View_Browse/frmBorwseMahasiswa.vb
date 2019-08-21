Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmBorwseMahasiswa
    Private Sub frmBorwseMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilGrid()
        AturGrid()
    End Sub
    Sub TampilGrid()
        On Error Resume Next
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT mahasiswa.nim, mahasiswa.nama, mahasiswa.jurusan from mahasiswa  where " & _
        "nama like '" & Trim(txtcari.Text) & "%' order by nim", conn)
        Adapter.Fill(table)
        GrdView.DataSource = table
        GrdView.Refresh()
        tutupkoneksi()
        Me.GrdView.Columns(0).HeaderText = "NIM"
        Me.GrdView.Columns(1).HeaderText = "Nama"
        Me.GrdView.Columns(2).HeaderText = "Jurusan"
    End Sub
    Sub AturGrid()
        GrdView.Columns(0).Width = 100
        GrdView.Columns(1).Width = 220
        GrdView.Columns(2).Width = 200
    End Sub
    Sub GridKlik()
        With Barang_Masuk
            Pengambilan_Barang.txtnim.Text = GrdView.CurrentRow.Cells(0).Value
            Pengambilan_Barang.txtnama.Text = GrdView.CurrentRow.Cells(1).Value
            Pengambilan_Barang.txtjurusan.Text = GrdView.CurrentRow.Cells(2).Value
            'Pengambilan_Barang.txtkelas.Text = GrdView.CurrentRow.Cells(3).Value
            Me.Close()
            Pengambilan_Barang.txtbarang.Focus()
            Barang_Masuk.txtbarang.Focus()
        End With
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub


    Private Sub lblClosed_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseEnter
        lblClosed.BackColor = Color.Crimson
    End Sub

    Private Sub lblClosed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseLeave
        lblClosed.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub lblClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClosed.Click
        Pengambilan_Barang.BtnTambah.Enabled = True
        Pengambilan_Barang.BtnHapus.Enabled = False
        Pengambilan_Barang.BtnBatal.Enabled = False
        Pengambilan_Barang.BtnSimpan.Enabled = False
        Me.Close()
    End Sub


    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        GridKlik()
    End Sub

    Private Sub GrdView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentDoubleClick
        GridKlik()
    End Sub
End Class