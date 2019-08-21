Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Net.NetworkInformation
Imports JS_FlatMaterialUI.CustomMessageBox

Public Class Splash

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = ""
        'Timer1.Stop()
        'Dim mac As String
        'mac = getMacAddress()
        'sql = "Select * From mac_address where name='CLIENT-1'"
        'sqlcommand = New MySqlCommand(sql, conn)
        ''Dr.Close()
        'Dr = sqlcommand.ExecuteReader
        'Dr.Read()
        Timer1.Start()
        'If Dr.Item("pc_mac") <> (mac) Or Dr.Item("pc_mac") = "" Then
        '    'MsgBox("Lisensi Sudah Kadaluarsa, Silahkan Hubungi Patramore IT", MsgBoxStyle.Information, "LISENSI APLIKASI")
        '    ShowMessageBox("Lisensi Aplikasi Anda Sudah Kadaluarsa, Silahkan Hubungi Patramore IT.", "Peringatan", MessageBoxType.Warning)
        '    End
        'Else
        '    Timer1.Start()
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label4.Text = "Membaca modul.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label4.Text = "Mengaktifkan modul."
        ElseIf (ProgressBar1.Value = 40) Then
            Label4.Text = "Memulai modul.."
        ElseIf (ProgressBar1.Value = 60) Then
            Label4.Text = "Memuat modules.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label4.Text = "Selesai memuat modul.."
        ElseIf (ProgressBar1.Value = 100) Then
            Menu_Utama.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub


End Class