Public Class frmReportPenerimaPerlengkapan

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If cboBulan.Text = "" Or CboTahun.Text = "" Then
            MsgBox("Silahkan Pilih Terlebih Dahulu, Bulan atau Tahun..")
        Else
            CRV.SelectionFormula = "Year({Command.tgl_keluar})=" & Val(CboTahun.Text) & " and Month({Command.tgl_keluar})=" & Val(cboBulan.Text)
            ReportPenerima1.Load("ReportPenerima.rpt")
            CRV.ReportSource = ReportPenerima1
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub frmReportPenerimaPerlengkapan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        Tahun()
        Bulan()
    End Sub
    Sub Tahun()
        CboTahun.Items.Clear()
        CboTahun.Items.Add("")
        CboTahun.Items.Add("2010")
        CboTahun.Items.Add("2011")
        CboTahun.Items.Add("2012")
        CboTahun.Items.Add("2013")
        CboTahun.Items.Add("2014")
        CboTahun.Items.Add("2015")
        CboTahun.Items.Add("2016")
        CboTahun.Items.Add("2017")
        CboTahun.Items.Add("2018")
        CboTahun.Items.Add("2019")
        CboTahun.Items.Add("2020")
        CboTahun.Items.Add("2021")
    End Sub
    Sub Bulan()
        cboBulan.Items.Clear()
        With cboBulan.Items
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
            .Add("7")
            .Add("8")
            .Add("9")
            .Add("10")
            .Add("11")
            .Add("12")
        End With
    End Sub
End Class