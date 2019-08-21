Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmBrowseSupplier

    Private Sub frmBrowseSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilGrid()
        AturGrid()
    End Sub
    Sub TampilGrid()
        On Error Resume Next
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from supplier where " & _
        "nm_supplier like '" & Trim(txtcari.Text) & "%' order by id_supplier", conn)
        Adapter.Fill(table)
        GrdSupplier.DataSource = table
        GrdSupplier.Refresh()
        tutupkoneksi()
        Me.GrdSupplier.Columns(0).HeaderText = "Kode Supplier"
        Me.GrdSupplier.Columns(1).HeaderText = "Nama"
        Me.GrdSupplier.Columns(2).HeaderText = "Alamat"
        Me.GrdSupplier.Columns(3).HeaderText = "Telphone"
    End Sub
    Sub AturGrid()
        GrdSupplier.Columns(0).Width = 100
        GrdSupplier.Columns(1).Width = 220
        GrdSupplier.Columns(2).Width = 200
        GrdSupplier.Columns(3).Width = 220
    End Sub

    Sub GridKlik()
        With Barang_Masuk
            Barang_Masuk.txtkdsupplier.Text = GrdSupplier.CurrentRow.Cells(0).Value
            Barang_Masuk.txtsupplier.Text = GrdSupplier.CurrentRow.Cells(1).Value
            Barang_Masuk.Aktif()
            Me.Close()
            Barang_Masuk.txtbarang.Focus()
        End With
    End Sub




    Private Sub lblClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClosed.Click
        Me.Close()
    End Sub
    Private Sub lblClosed_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseEnter
        lblClosed.BackColor = Color.Crimson
    End Sub

    Private Sub lblClosed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseLeave
        lblClosed.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged

    End Sub


    Private Sub GrdSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplier.CellContentClick
        GridKlik()
    End Sub

    Private Sub GrdSupplier_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplier.CellContentDoubleClick
        GridKlik()
    End Sub
End Class