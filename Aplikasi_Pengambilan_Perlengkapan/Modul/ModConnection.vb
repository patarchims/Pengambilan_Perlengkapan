Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Net.NetworkInformation
Module ModConnection
    Public server As String
    Public ds As New DataSet
    Public dtData As New Data.DataTable
    Public conn As New MySqlConnection
    Public sqlcommand As New MySqlCommand
    Public sqlcommand1 As New MySqlCommand
    Public sqlcommand2 As New MySqlCommand
    Public sqladapter As New MySqlDataAdapter 'RD Sql adapter
    Public Konfirmasi As MsgBoxResult
    Public Dr As MySqlDataReader
    Public Dr1 As MySqlDataReader
    Public Cur As New Form
    Public sql, sql1 As String
    Public sqlDetail, sqldelete As String

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function
    Public Sub cekkoneksi()
        server = "SERVER= localhost; USERID= root; password=; database=db_perlengkapan; Convert Zero Datetime=true; "
        conn.ConnectionString = server
        conn.Open()
    End Sub
    Public Sub tutupkoneksi()
        With conn
            .Dispose()
            .Close()
        End With
    End Sub
    Public Sub KOneksiAwal()
        Try
            server = "SERVER= localhost; USERID= root; password=; database=db_perlengkapan; Convert Zero Datetime=true; "
            conn.ConnectionString = server
            conn.Open()
        Catch
            MsgBox("Tidak Terkoneksi Dengan Database. Pastikan Komputer Anda Terkoneksi Internet", MsgBoxStyle.Information, "Database")
            End
        End Try
    End Sub
End Module
