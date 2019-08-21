Public Class TandaTerima

    Private Sub lblClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClosed.Click
        Me.Close()
    End Sub
    Private Sub lblClosed_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseEnter
        lblClosed.BackColor = Color.Crimson
    End Sub

    Private Sub lblClosed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClosed.MouseLeave
        lblClosed.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub TandaTerima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        'CRV.SelectionFormula = "({cabang})='" & Val(cboCabang.Text) & "'"
        CRV.SelectionFormula = "({command.no_keluar}) like'" & Pengambilan_Barang.lblNoPengambilan.Text & "'"
        RptTandaTerima1.Load("RptTandaTerima.rpt")
        CRV.ReportSource = RptTandaTerima1
        CRV.RefreshReport()
        Pengambilan_Barang.Bersih()
        Pengambilan_Barang.TampilGridBarangKeluar()
    End Sub
End Class