Imports JS_FlatMaterialUI.CustomMessageBox
Public Class Login

    Private Sub LblCLosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCLosed.Click
        End
    End Sub

    Private Sub LblCLosed_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblCLosed.MouseEnter
        LblCLosed.BackColor = Color.Crimson
    End Sub

    Private Sub LblCLosed_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblCLosed.MouseLeave
        LblCLosed.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub btnLogin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.GotFocus
        btnLogin.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub btnLogin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.LostFocus
        btnLogin.BackColor = Color.FromArgb(0, 211, 91)
    End Sub

    Private Sub btnLogin_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(4, 137, 60)
    End Sub

    Private Sub btnLogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(0, 211, 91)
    End Sub
    Sub Bersih()
        txtpassword.Text = ""
        txtusername.Text = ""
    End Sub

    Sub Login()
        If Len(Trim(txtusername.Text)) = 0 Then
            'MessageBox.Show("Username Belum diinput", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ShowMessageBox("username Belum diinput", "Warning", MessageBoxType.Warning)
            txtusername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtpassword.Text)) = 0 Then
            'MessageBox.Show("Username Password Belum diinput", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ShowMessageBox("Password Belum diinput", "Warning", MessageBoxType.Warning)
            txtusername.Focus()
            Exit Sub
        End If

        On Error Resume Next

        Dr.Close()
        cekkoneksi()
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand("Select * from users Where username='" & txtusername.Text & "' and password='" & Encrypt(txtpassword.Text) & "'", conn)
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then

            ShowMessageBox("Maaf, Username atau Password Anda Salah", "Error", MessageBoxType.Critical)
            Dr.Close()
            tutupkoneksi()
            Bersih()
            txtusername.Focus()
            Exit Sub
        ElseIf Dr.Item("user_type") = "Administrator" Then
            cekkoneksi()
            sql = "INSERT INTO logs values ('" & txtusername.Text & "','Administrator','" & System.DateTime.Now & "')"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            tutupkoneksi()
            cekkoneksi()
            sqlcommand.ExecuteNonQuery()
            tutupkoneksi()

            'Menu_Utama.Panel_Menu.Controls.Clear()
            Menu_Utama.LblUser_Type.Text = Dr.Item("user_type")
            Menu_Utama.LblUser_Type.Text = "Administrator"
            Menu_Utama.Lbl_User.Text = Dr.Item("username")
            Menu_Utama.Lbl_User.Text = Me.txtusername.Text
            Splash.Show()
            Me.Hide()
            'Menu_Admin.TopLevel = False
            'Menu_Utama.Panel_Menu.Controls.Add(Menu_Admin)
            'Menu_Admin.Show()
            'Me.Hide()
            'ElseIf Dr.Item("user_type") = "User" Then
            '    cekkoneksi()
            '    sql = "INSERT INTO logs values ('" & txtusername.Text & "','User','" & System.DateTime.Now & "')"
            '    sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            '    tutupkoneksi()
            '    cekkoneksi()
            '    sqlcommand.ExecuteNonQuery()
            '    tutupkoneksi()

            '    Menu_Utama.Show()
            '    Menu_Utama.LblUser_Type.Text = Dr.Item("user_type")
            '    Menu_Utama.Lbl_User.Text = Dr.Item("username")
            '    Menu_Utama.Panel_Menu.Controls.Clear()
            '    Menu_User.TopLevel = False
            '    Menu_Utama.Panel_Menu.Controls.Add(Menu_User)
            '    Menu_User.Show()
            '    'frmSplash.Show()
            '    'Menu_Utama.show()
            '    Me.Hide()
        End If
    End Sub

    Private Sub txtusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.GotFocus
        txtusername.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txtusername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.LostFocus
        txtusername.BackColor = Color.FromArgb(207, 208, 215)
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub txtpassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.GotFocus
        txtpassword.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub txtpassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.LostFocus
        txtpassword.BackColor = Color.FromArgb(207, 208, 215)
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class