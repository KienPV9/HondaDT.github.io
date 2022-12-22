<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BEKhoXeTong
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtten_nhKX3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtten_nhkx2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx2 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtten_nhKX1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx1 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Kx3 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 219)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 180)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 183)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 219)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 161)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 158)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 158)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.isEmpty = True
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(95, 9)
        Me.TxtM_Ngay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct.MaxLength = 10
        Me.TxtM_Ngay_Ct.Name = "TxtM_Ngay_Ct"
        Me.TxtM_Ngay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct.TabIndex = 0
        Me.TxtM_Ngay_Ct.Text = "__/__/____"
        Me.TxtM_Ngay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(2, 12)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(32, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date "
        Me.LabM_Ngay_Ct1.Text = "Ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 202)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 448
        Me.Label3.Tag = "Staff"
        Me.Label3.Text = "Nhân viên"
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Enabled = False
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(216, 35)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(353, 14)
        Me.TxtTen_HS.TabIndex = 447
        Me.TxtTen_HS.TabStop = False
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(94, 33)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HS.TabIndex = 1
        Me.TxtMa_HS.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 446
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm kiểu xe 3"
        '
        'txtten_nhKX3
        '
        Me.txtten_nhKX3.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nhKX3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nhKX3.Enabled = False
        Me.txtten_nhKX3.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nhKX3.Location = New System.Drawing.Point(215, 127)
        Me.txtten_nhKX3.Name = "txtten_nhKX3"
        Me.txtten_nhKX3.ReadOnly = True
        Me.txtten_nhKX3.Size = New System.Drawing.Size(353, 14)
        Me.txtten_nhKX3.TabIndex = 445
        Me.txtten_nhKX3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 444
        Me.Label7.Tag = "Group 2"
        Me.Label7.Text = "Nhóm kiểu xe 2"
        '
        'txtten_nhkx2
        '
        Me.txtten_nhkx2.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nhkx2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nhkx2.Enabled = False
        Me.txtten_nhkx2.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nhkx2.Location = New System.Drawing.Point(215, 104)
        Me.txtten_nhkx2.Name = "txtten_nhkx2"
        Me.txtten_nhkx2.ReadOnly = True
        Me.txtten_nhkx2.Size = New System.Drawing.Size(353, 14)
        Me.txtten_nhkx2.TabIndex = 443
        Me.txtten_nhkx2.TabStop = False
        '
        'TxtNh_Kx2
        '
        Me.TxtNh_Kx2._ActilookupPopup = False
        Me.TxtNh_Kx2.CyberActilookupPopup = True
        Me.TxtNh_Kx2.Dv_ListDetail = Nothing
        Me.TxtNh_Kx2.Dv_Master = Nothing
        Me.TxtNh_Kx2.FilterClient = ""
        Me.TxtNh_Kx2.FilterSQL = ""
        Me.TxtNh_Kx2.Location = New System.Drawing.Point(93, 101)
        Me.TxtNh_Kx2.Name = "TxtNh_Kx2"
        Me.TxtNh_Kx2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx2.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx2.TabIndex = 4
        Me.TxtNh_Kx2.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 442
        Me.Label5.Tag = "Group 1"
        Me.Label5.Text = "Nhóm kiểu xe 1"
        '
        'txtten_nhKX1
        '
        Me.txtten_nhKX1.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nhKX1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nhKX1.Enabled = False
        Me.txtten_nhKX1.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nhKX1.Location = New System.Drawing.Point(215, 82)
        Me.txtten_nhKX1.Name = "txtten_nhKX1"
        Me.txtten_nhKX1.ReadOnly = True
        Me.txtten_nhKX1.Size = New System.Drawing.Size(353, 14)
        Me.txtten_nhKX1.TabIndex = 441
        Me.txtten_nhKX1.TabStop = False
        '
        'TxtNh_Kx1
        '
        Me.TxtNh_Kx1._ActilookupPopup = False
        Me.TxtNh_Kx1.CyberActilookupPopup = True
        Me.TxtNh_Kx1.Dv_ListDetail = Nothing
        Me.TxtNh_Kx1.Dv_Master = Nothing
        Me.TxtNh_Kx1.FilterClient = ""
        Me.TxtNh_Kx1.FilterSQL = ""
        Me.TxtNh_Kx1.Location = New System.Drawing.Point(93, 79)
        Me.TxtNh_Kx1.Name = "TxtNh_Kx1"
        Me.TxtNh_Kx1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx1.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx1.TabIndex = 3
        Me.TxtNh_Kx1.Table_Name = ""
        '
        'TxtNh_Kx3
        '
        Me.TxtNh_Kx3._ActilookupPopup = False
        Me.TxtNh_Kx3.CyberActilookupPopup = True
        Me.TxtNh_Kx3.Dv_ListDetail = Nothing
        Me.TxtNh_Kx3.Dv_Master = Nothing
        Me.TxtNh_Kx3.FilterClient = ""
        Me.TxtNh_Kx3.FilterSQL = ""
        Me.TxtNh_Kx3.Location = New System.Drawing.Point(93, 124)
        Me.TxtNh_Kx3.Name = "TxtNh_Kx3"
        Me.TxtNh_Kx3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx3.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx3.TabIndex = 5
        Me.TxtNh_Kx3.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(2, 60)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 440
        Me.LabMa_Cc.Tag = "Car type"
        Me.LabMa_Cc.Text = "Mã kiểu xe"
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Enabled = False
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(215, 59)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(353, 14)
        Me.TxtTen_kx.TabIndex = 439
        Me.TxtTen_kx.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(93, 56)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_KX.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_KX.TabIndex = 2
        Me.TxtMa_KX.Table_Name = ""
        '
        'BEKhoXeTong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtten_nhKX3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtten_nhkx2)
        Me.Controls.Add(Me.TxtNh_Kx2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtten_nhKX1)
        Me.Controls.Add(Me.TxtNh_Kx1)
        Me.Controls.Add(Me.TxtNh_Kx3)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.Name = "BEKhoXeTong"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.txtten_nhKX1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.txtten_nhkx2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtten_nhKX3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_HS As TextBox
    Friend WithEvents TxtMa_HS As SmLists.TxtLookup
    Friend WithEvents Label8 As Label
    Friend WithEvents txtten_nhKX3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtten_nhkx2 As TextBox
    Friend WithEvents TxtNh_Kx2 As SmLists.TxtLookup
    Friend WithEvents Label5 As Label
    Friend WithEvents txtten_nhKX1 As TextBox
    Friend WithEvents TxtNh_Kx1 As SmLists.TxtLookup
    Friend WithEvents TxtNh_Kx3 As SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As Label
    Friend WithEvents TxtTen_kx As TextBox
    Friend WithEvents TxtMa_KX As SmLists.TxtLookup
End Class
