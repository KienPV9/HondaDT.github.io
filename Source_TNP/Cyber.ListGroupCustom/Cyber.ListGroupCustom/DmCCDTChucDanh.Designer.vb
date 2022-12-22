<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMCCDTChucDanh
    Inherits Cyber.From.FrmList

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.LabTen_BP2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_chucdanh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_chucdanh = New System.Windows.Forms.TextBox()
        Me.TxtMa_ccdt = New Cyber.SmLists.TxtLookup()
        Me.Txtghi_chu = New System.Windows.Forms.TextBox()
        Me.TxtTen_ccdt = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_chucdanh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_ccdt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 109)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 109)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 115)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 119)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 99)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 8)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã chức danh"
        '
        'LabTen_BP2
        '
        Me.LabTen_BP2.Location = New System.Drawing.Point(5, 37)
        Me.LabTen_BP2.Name = "LabTen_BP2"
        Me.LabTen_BP2.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP2.TabIndex = 14
        Me.LabTen_BP2.Tag = "English name"
        Me.LabTen_BP2.Text = "Mã chứng chỉ ĐT"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Ghi Chú"
        '
        'TxtMa_chucdanh
        '
        Me.TxtMa_chucdanh._ActilookupPopup = False
        Me.TxtMa_chucdanh.CyberActilookupPopup = True
        Me.TxtMa_chucdanh.Dv_ListDetail = Nothing
        Me.TxtMa_chucdanh.Dv_Master = Nothing
        Me.TxtMa_chucdanh.FilterClient = ""
        Me.TxtMa_chucdanh.FilterSQL = ""
        Me.TxtMa_chucdanh.Location = New System.Drawing.Point(110, 7)
        Me.TxtMa_chucdanh.Name = "TxtMa_chucdanh"
        Me.TxtMa_chucdanh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_chucdanh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_chucdanh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_chucdanh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_chucdanh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_chucdanh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_chucdanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_chucdanh.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_chucdanh.TabIndex = 0
        Me.TxtMa_chucdanh.Table_Name = ""
        '
        'TxtTen_chucdanh
        '
        Me.TxtTen_chucdanh.Enabled = False
        Me.TxtTen_chucdanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_chucdanh.Location = New System.Drawing.Point(274, 7)
        Me.TxtTen_chucdanh.Name = "TxtTen_chucdanh"
        Me.TxtTen_chucdanh.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtTen_chucdanh.Size = New System.Drawing.Size(498, 21)
        Me.TxtTen_chucdanh.TabIndex = 1
        '
        'TxtMa_ccdt
        '
        Me.TxtMa_ccdt._ActilookupPopup = False
        Me.TxtMa_ccdt.CyberActilookupPopup = True
        Me.TxtMa_ccdt.Dv_ListDetail = Nothing
        Me.TxtMa_ccdt.Dv_Master = Nothing
        Me.TxtMa_ccdt.FilterClient = ""
        Me.TxtMa_ccdt.FilterSQL = ""
        Me.TxtMa_ccdt.Location = New System.Drawing.Point(110, 33)
        Me.TxtMa_ccdt.Name = "TxtMa_ccdt"
        Me.TxtMa_ccdt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_ccdt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ccdt.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_ccdt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ccdt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_ccdt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_ccdt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ccdt.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_ccdt.TabIndex = 2
        Me.TxtMa_ccdt.Table_Name = ""
        '
        'Txtghi_chu
        '
        Me.Txtghi_chu.ForeColor = System.Drawing.Color.Navy
        Me.Txtghi_chu.Location = New System.Drawing.Point(110, 60)
        Me.Txtghi_chu.Name = "Txtghi_chu"
        Me.Txtghi_chu.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtghi_chu.Size = New System.Drawing.Size(662, 21)
        Me.Txtghi_chu.TabIndex = 5
        '
        'TxtTen_ccdt
        '
        Me.TxtTen_ccdt.Enabled = False
        Me.TxtTen_ccdt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ccdt.Location = New System.Drawing.Point(274, 33)
        Me.TxtTen_ccdt.Name = "TxtTen_ccdt"
        Me.TxtTen_ccdt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtTen_ccdt.Size = New System.Drawing.Size(498, 21)
        Me.TxtTen_ccdt.TabIndex = 3
        '
        'DMCCDTChucDanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 142)
        Me.Controls.Add(Me.Txtghi_chu)
        Me.Controls.Add(Me.TxtTen_ccdt)
        Me.Controls.Add(Me.TxtMa_ccdt)
        Me.Controls.Add(Me.TxtTen_chucdanh)
        Me.Controls.Add(Me.TxtMa_chucdanh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMCCDTChucDanh"
        Me.Text = "Danh mục chứng chỉ đào tạo theo chứng danh"
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_chucdanh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_chucdanh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ccdt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ccdt, 0)
        Me.Controls.SetChildIndex(Me.Txtghi_chu, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtMa_chucdanh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_ccdt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtMa_chucdanh As SmLists.TxtLookup
    Friend WithEvents TxtTen_chucdanh As Windows.Forms.TextBox
    Friend WithEvents TxtMa_ccdt As SmLists.TxtLookup
    Friend WithEvents Txtghi_chu As Windows.Forms.TextBox
    Friend WithEvents TxtTen_ccdt As Windows.Forms.TextBox
End Class
