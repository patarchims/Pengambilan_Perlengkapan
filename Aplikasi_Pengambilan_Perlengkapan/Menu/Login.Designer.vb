<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblCLosed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 462)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 435)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "patarchims@gmail.com"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(18, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 3)
        Me.Panel2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patramore Junior IT"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(57, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 219)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Patramore"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.Location = New System.Drawing.Point(411, 372)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 49)
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(322, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 36)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(322, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 36)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(328, 214)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(281, 31)
        Me.txtusername.TabIndex = 15
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(328, 302)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(281, 31)
        Me.txtpassword.TabIndex = 16
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(328, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 39)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Login System"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCLosed
        '
        Me.LblCLosed.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LblCLosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCLosed.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCLosed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblCLosed.Location = New System.Drawing.Point(569, -3)
        Me.LblCLosed.Name = "LblCLosed"
        Me.LblCLosed.Size = New System.Drawing.Size(60, 48)
        Me.LblCLosed.TabIndex = 20
        Me.LblCLosed.Text = "X"
        Me.LblCLosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 462)
        Me.Controls.Add(Me.LblCLosed)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblCLosed As System.Windows.Forms.Label
End Class
