<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMCD1_VPP
    Inherits Cyber.From.FilterReport

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Cc = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cc = New Cyber.SmLists.TxtLookup()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.cbbTinh_dc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkGroup3 = New System.Windows.Forms.CheckBox()
        Me.ChkGroup1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkGroup2 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtten_nh_cc3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtten_nh_cc2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Cc2 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtten_nh_cc1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Cc1 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Cc3 = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtten_tk_cc = New System.Windows.Forms.TextBox()
        Me.TxtTk_Cc = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(539, 298)
        Me.ButtExit.TabIndex = 16
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(120, 259)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(521, 21)
        Me.CBBMa_Dvcs.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 262)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(435, 298)
        Me.ButtOK.TabIndex = 15
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 240)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(120, 237)
        Me.ChkVND.TabIndex = 12
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(227, 237)
        Me.ChkNT.TabIndex = 13
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 281)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(636, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(10, 51)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(241, 51)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_kho.TabIndex = 193
        Me.TxtTen_kho.TabStop = False
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(120, 48)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_kho.TabIndex = 2
        Me.TxtMa_kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(10, 72)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Tool"
        Me.LabMa_Cc.Text = "Mã công cụ"
        '
        'TxtTen_Cc
        '
        Me.TxtTen_Cc.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cc.Enabled = False
        Me.TxtTen_Cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cc.Location = New System.Drawing.Point(241, 73)
        Me.TxtTen_Cc.Name = "TxtTen_Cc"
        Me.TxtTen_Cc.ReadOnly = True
        Me.TxtTen_Cc.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Cc.TabIndex = 196
        Me.TxtTen_Cc.TabStop = False
        '
        'TxtMa_Cc
        '
        Me.TxtMa_Cc._ActilookupPopup = False
        Me.TxtMa_Cc.CyberActilookupPopup = True
        Me.TxtMa_Cc.Dv_ListDetail = Nothing
        Me.TxtMa_Cc.Dv_Master = Nothing
        Me.TxtMa_Cc.FilterClient = ""
        Me.TxtMa_Cc.FilterSQL = ""
        Me.TxtMa_Cc.Location = New System.Drawing.Point(120, 70)
        Me.TxtMa_Cc.Name = "TxtMa_Cc"
        Me.TxtMa_Cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Cc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cc.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Cc.TabIndex = 3
        Me.TxtMa_Cc.Table_Name = ""
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 28)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 201
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 5)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 200
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(120, 25)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(120, 2)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cbbTinh_dc
        '
        Me.cbbTinh_dc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTinh_dc.ForeColor = System.Drawing.Color.Navy
        Me.cbbTinh_dc.FormattingEnabled = True
        Me.cbbTinh_dc.Location = New System.Drawing.Point(120, 185)
        Me.cbbTinh_dc.Name = "cbbTinh_dc"
        Me.cbbTinh_dc.Size = New System.Drawing.Size(220, 21)
        Me.cbbTinh_dc.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(10, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 270
        Me.Label12.Tag = "Transfer arising stock"
        Me.Label12.Text = "Tính điều chuyển kho"
        '
        'ChkGroup3
        '
        Me.ChkGroup3.AutoSize = True
        Me.ChkGroup3.Location = New System.Drawing.Point(486, 214)
        Me.ChkGroup3.Name = "ChkGroup3"
        Me.ChkGroup3.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup3.TabIndex = 11
        Me.ChkGroup3.Tag = "Group 3"
        Me.ChkGroup3.Text = "Theo nhóm 3"
        Me.ChkGroup3.UseVisualStyleBackColor = True
        '
        'ChkGroup1
        '
        Me.ChkGroup1.AutoSize = True
        Me.ChkGroup1.Location = New System.Drawing.Point(120, 214)
        Me.ChkGroup1.Name = "ChkGroup1"
        Me.ChkGroup1.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup1.TabIndex = 9
        Me.ChkGroup1.Tag = "Group 1"
        Me.ChkGroup1.Text = "Theo nhóm 1"
        Me.ChkGroup1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(10, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 269
        Me.Label13.Tag = "Group by"
        Me.Label13.Text = "Nhóm theo"
        '
        'ChkGroup2
        '
        Me.ChkGroup2.AutoSize = True
        Me.ChkGroup2.Location = New System.Drawing.Point(304, 214)
        Me.ChkGroup2.Name = "ChkGroup2"
        Me.ChkGroup2.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup2.TabIndex = 10
        Me.ChkGroup2.Tag = "Group 2"
        Me.ChkGroup2.Text = "Theo nhóm 2"
        Me.ChkGroup2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 265
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm công cụ 3"
        '
        'txtten_nh_cc3
        '
        Me.txtten_nh_cc3.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nh_cc3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_cc3.Enabled = False
        Me.txtten_nh_cc3.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_cc3.Location = New System.Drawing.Point(241, 164)
        Me.txtten_nh_cc3.Name = "txtten_nh_cc3"
        Me.txtten_nh_cc3.ReadOnly = True
        Me.txtten_nh_cc3.Size = New System.Drawing.Size(370, 14)
        Me.txtten_nh_cc3.TabIndex = 264
        Me.txtten_nh_cc3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 263
        Me.Label7.Tag = "Group 2"
        Me.Label7.Text = "Nhóm công cụ 2"
        '
        'txtten_nh_cc2
        '
        Me.txtten_nh_cc2.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nh_cc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_cc2.Enabled = False
        Me.txtten_nh_cc2.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_cc2.Location = New System.Drawing.Point(241, 141)
        Me.txtten_nh_cc2.Name = "txtten_nh_cc2"
        Me.txtten_nh_cc2.ReadOnly = True
        Me.txtten_nh_cc2.Size = New System.Drawing.Size(370, 14)
        Me.txtten_nh_cc2.TabIndex = 262
        Me.txtten_nh_cc2.TabStop = False
        '
        'TxtNh_Cc2
        '
        Me.TxtNh_Cc2._ActilookupPopup = False
        Me.TxtNh_Cc2.CyberActilookupPopup = True
        Me.TxtNh_Cc2.Dv_ListDetail = Nothing
        Me.TxtNh_Cc2.Dv_Master = Nothing
        Me.TxtNh_Cc2.FilterClient = ""
        Me.TxtNh_Cc2.FilterSQL = ""
        Me.TxtNh_Cc2.Location = New System.Drawing.Point(120, 138)
        Me.TxtNh_Cc2.Name = "TxtNh_Cc2"
        Me.TxtNh_Cc2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Cc2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Cc2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc2.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Cc2.TabIndex = 6
        Me.TxtNh_Cc2.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 261
        Me.Label5.Tag = "Group 1"
        Me.Label5.Text = "Nhóm công cụ 1"
        '
        'txtten_nh_cc1
        '
        Me.txtten_nh_cc1.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_nh_cc1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_nh_cc1.Enabled = False
        Me.txtten_nh_cc1.ForeColor = System.Drawing.Color.Navy
        Me.txtten_nh_cc1.Location = New System.Drawing.Point(241, 119)
        Me.txtten_nh_cc1.Name = "txtten_nh_cc1"
        Me.txtten_nh_cc1.ReadOnly = True
        Me.txtten_nh_cc1.Size = New System.Drawing.Size(370, 14)
        Me.txtten_nh_cc1.TabIndex = 260
        Me.txtten_nh_cc1.TabStop = False
        '
        'TxtNh_Cc1
        '
        Me.TxtNh_Cc1._ActilookupPopup = False
        Me.TxtNh_Cc1.CyberActilookupPopup = True
        Me.TxtNh_Cc1.Dv_ListDetail = Nothing
        Me.TxtNh_Cc1.Dv_Master = Nothing
        Me.TxtNh_Cc1.FilterClient = ""
        Me.TxtNh_Cc1.FilterSQL = ""
        Me.TxtNh_Cc1.Location = New System.Drawing.Point(120, 116)
        Me.TxtNh_Cc1.Name = "TxtNh_Cc1"
        Me.TxtNh_Cc1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Cc1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Cc1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc1.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Cc1.TabIndex = 5
        Me.TxtNh_Cc1.Table_Name = ""
        '
        'TxtNh_Cc3
        '
        Me.TxtNh_Cc3._ActilookupPopup = False
        Me.TxtNh_Cc3.CyberActilookupPopup = True
        Me.TxtNh_Cc3.Dv_ListDetail = Nothing
        Me.TxtNh_Cc3.Dv_Master = Nothing
        Me.TxtNh_Cc3.FilterClient = ""
        Me.TxtNh_Cc3.FilterSQL = ""
        Me.TxtNh_Cc3.Location = New System.Drawing.Point(120, 161)
        Me.TxtNh_Cc3.Name = "TxtNh_Cc3"
        Me.TxtNh_Cc3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Cc3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Cc3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc3.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Cc3.TabIndex = 7
        Me.TxtNh_Cc3.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 256
        Me.Label6.Tag = "Account"
        Me.Label6.Text = "Tk công cụ"
        '
        'txtten_tk_cc
        '
        Me.txtten_tk_cc.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_tk_cc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_tk_cc.Enabled = False
        Me.txtten_tk_cc.ForeColor = System.Drawing.Color.Navy
        Me.txtten_tk_cc.Location = New System.Drawing.Point(241, 96)
        Me.txtten_tk_cc.Name = "txtten_tk_cc"
        Me.txtten_tk_cc.ReadOnly = True
        Me.txtten_tk_cc.Size = New System.Drawing.Size(370, 14)
        Me.txtten_tk_cc.TabIndex = 255
        Me.txtten_tk_cc.TabStop = False
        '
        'TxtTk_Cc
        '
        Me.TxtTk_Cc._ActilookupPopup = False
        Me.TxtTk_Cc.CyberActilookupPopup = True
        Me.TxtTk_Cc.Dv_ListDetail = Nothing
        Me.TxtTk_Cc.Dv_Master = Nothing
        Me.TxtTk_Cc.FilterClient = ""
        Me.TxtTk_Cc.FilterSQL = ""
        Me.TxtTk_Cc.Location = New System.Drawing.Point(120, 93)
        Me.TxtTk_Cc.Name = "TxtTk_Cc"
        Me.TxtTk_Cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Cc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Cc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Cc.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk_Cc.TabIndex = 4
        Me.TxtTk_Cc.Table_Name = ""
        '
        'IMCD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(643, 351)
        Me.Controls.Add(Me.cbbTinh_dc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ChkGroup3)
        Me.Controls.Add(Me.ChkGroup1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ChkGroup2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtten_nh_cc3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtten_nh_cc2)
        Me.Controls.Add(Me.TxtNh_Cc2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtten_nh_cc1)
        Me.Controls.Add(Me.TxtNh_Cc1)
        Me.Controls.Add(Me.TxtNh_Cc3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtten_tk_cc)
        Me.Controls.Add(Me.TxtTk_Cc)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Cc)
        Me.Controls.Add(Me.TxtMa_Cc)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "IMCD1"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cc, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Cc, 0)
        Me.Controls.SetChildIndex(Me.txtten_tk_cc, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc1, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_cc1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc2, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_cc2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtten_nh_cc3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup2, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup1, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup3, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cbbTinh_dc, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cc As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cc As Cyber.SmLists.TxtLookup
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents cbbTinh_dc As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChkGroup3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGroup1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkGroup2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_cc3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_cc2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Cc2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtten_nh_cc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Cc1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_Cc3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtten_tk_cc As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Cc As Cyber.SmLists.TxtLookup

End Class
