<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowseSupplier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrdSupplier = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClosed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GrdSupplier)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 196)
        Me.Panel3.TabIndex = 22
        '
        'GrdSupplier
        '
        Me.GrdSupplier.AllowUserToAddRows = False
        Me.GrdSupplier.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.GrdSupplier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdSupplier.BackgroundColor = System.Drawing.Color.White
        Me.GrdSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrdSupplier.ColumnHeadersHeight = 24
        Me.GrdSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdSupplier.DefaultCellStyle = DataGridViewCellStyle3
        Me.GrdSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdSupplier.EnableHeadersVisualStyles = False
        Me.GrdSupplier.GridColor = System.Drawing.Color.White
        Me.GrdSupplier.Location = New System.Drawing.Point(0, 0)
        Me.GrdSupplier.Margin = New System.Windows.Forms.Padding(5)
        Me.GrdSupplier.MultiSelect = False
        Me.GrdSupplier.Name = "GrdSupplier"
        Me.GrdSupplier.ReadOnly = True
        Me.GrdSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSupplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdSupplier.RowHeadersWidth = 30
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.GrdSupplier.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrdSupplier.RowTemplate.Height = 18
        Me.GrdSupplier.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrdSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdSupplier.Size = New System.Drawing.Size(601, 194)
        Me.GrdSupplier.TabIndex = 300
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(229, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(277, 54)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(329, 26)
        Me.txtcari.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClosed)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 50)
        Me.Panel1.TabIndex = 25
        '
        'lblClosed
        '
        Me.lblClosed.BackColor = System.Drawing.Color.Crimson
        Me.lblClosed.Font = New System.Drawing.Font("Franklin Gothic Medium", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblClosed.Location = New System.Drawing.Point(553, 0)
        Me.lblClosed.Name = "lblClosed"
        Me.lblClosed.Size = New System.Drawing.Size(59, 50)
        Me.lblClosed.TabIndex = 3
        Me.lblClosed.Text = "X"
        Me.lblClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Data Supplier"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBrowseSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(612, 287)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBrowseSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBrowseSupplier"
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblClosed As System.Windows.Forms.Label
    Friend WithEvents GrdSupplier As System.Windows.Forms.DataGridView
End Class
