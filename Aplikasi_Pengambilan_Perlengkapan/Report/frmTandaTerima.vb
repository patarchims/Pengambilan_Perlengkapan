Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports JS_FlatMaterialUI.CustomMessageBox
Public Class frmTandaTerima

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmTandaTerima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GrdView.Visible = False
        CRV.ReportSource = Nothing
    End Sub

    Private Sub txtnoKartu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnim.TextChanged
        If txtnim.Text = "" Then
            GrdView.Visible = False
        Else
            GrdView.Visible = True
            TampilPemilik()
        End If
    End Sub
    Sub TampilPemilik()
        Try
            tutupkoneksi()
            cekkoneksi()
            Dim table As New DataTable()
            Dim Adapter As New MySqlDataAdapter("SELECT barang_keluar.no_keluar, mahasiswa.nim, mahasiswa.nama, mahasiswa.jurusan FROM mahasiswa INNER JOIN barang_keluar ON barang_keluar.nim=mahasiswa.nim where " & _
            "mahasiswa.nim like '" & Trim(txtnim.Text) & "%' order by mahasiswa.nim ASC", conn)
            Adapter.Fill(table)
            GrdView.DataSource = table
            GrdView.Refresh()
            tutupkoneksi()
            With Me.GrdView
                .Columns(0).HeaderText = "No Keluar"
                .Columns(1).HeaderText = "NIM"
                .Columns(2).HeaderText = "NAMA"
                .Columns(3).HeaderText = "JURUSAN"


                .Columns(0).Width = 75
                .Columns(1).Width = 100
                .Columns(2).Width = 115
                .Columns(3).Width = 115


            End With
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub GrdView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdView.CellContentClick
        Try
            txtnim.Text = GrdView.CurrentRow.Cells(0).Value
            GrdView.Visible = False
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If txtnim.Text = "" Then
            MsgBox("Silahkan cari telebih dahulu data yang akan di cetak... ")
            txtnim.Focus()
        Else
            CRV.SelectionFormula = "({command.no_keluar}) like'" & txtnim.Text & "'"
            RptTandaTerima1.Load("RptTandaTerima.rpt")
            CRV.ReportSource = RptTandaTerima1
            CRV.RefreshReport()
        End If
    End Sub
End Class