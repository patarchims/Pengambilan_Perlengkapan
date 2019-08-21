<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TandaTerima
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClosed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RptTandaTerima1 = New Aplikasi_Pengambilan_Perlengkapan.RptTandaTerima()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClosed)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 50)
        Me.Panel1.TabIndex = 27
        '
        'lblClosed
        '
        Me.lblClosed.BackColor = System.Drawing.Color.Crimson
        Me.lblClosed.Font = New System.Drawing.Font("Franklin Gothic Medium", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblClosed.Location = New System.Drawing.Point(722, 0)
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
        Me.Label1.Size = New System.Drawing.Size(284, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CETAK BUKTI PENERIMAAN BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 50)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.RptTandaTerima1
        Me.CRV.Size = New System.Drawing.Size(781, 471)
        Me.CRV.TabIndex = 29
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TandaTerima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 521)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TandaTerima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TandaTerima"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblClosed As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RptTandaTerima1 As Aplikasi_Pengambilan_Perlengkapan.RptTandaTerima
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
