<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BECD2
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
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.CmbTinh_Dc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkGroup3 = New System.Windows.Forms.CheckBox()
        Me.ChkGroup1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkGroup2 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx2 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Kx1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Kx1 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Kx3 = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(539, 314)
        Me.ButtExit.TabIndex = 20
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(120, 275)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(521, 21)
        Me.CBBMa_Dvcs.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 278)
        Me.Label1.TabIndex = 16
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(435, 314)
        Me.ButtOK.TabIndex = 19
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 256)
        Me.LabLoai_NT.TabIndex = 13
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(120, 253)
        Me.ChkVND.TabIndex = 14
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(227, 253)
        Me.ChkNT.TabIndex = 15
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 297)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(636, 9)
        Me.GroupBoxLine.TabIndex = 18
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(10, 53)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(41, 13)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_Kho
        '
        Me.TxtTen_Kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kho.Enabled = False
        Me.TxtTen_Kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kho.Location = New System.Drawing.Point(241, 52)
        Me.TxtTen_Kho.Name = "TxtTen_Kho"
        Me.TxtTen_Kho.ReadOnly = True
        Me.TxtTen_Kho.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Kho.TabIndex = 193
        Me.TxtTen_Kho.TabStop = False
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho._ActilookupPopup = False
        Me.TxtMa_Kho.CyberActilookupPopup = True
        Me.TxtMa_Kho.Dv_ListDetail = Nothing
        Me.TxtMa_Kho.Dv_Master = Nothing
        Me.TxtMa_Kho.FilterClient = ""
        Me.TxtMa_Kho.FilterSQL = ""
        Me.TxtMa_Kho.Location = New System.Drawing.Point(120, 49)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kho.TabIndex = 2
        Me.TxtMa_Kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.AutoSize = True
        Me.LabMa_Cc.Location = New System.Drawing.Point(10, 74)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(58, 13)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Car type"
        Me.LabMa_Cc.Text = "Mã kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(241, 73)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Kx.TabIndex = 196
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(120, 70)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kx.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Kx.TabIndex = 3
        Me.TxtMa_Kx.Table_Name = ""
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 30)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 201
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 7)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(120, 26)
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
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(120, 3)
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
        'CmbTinh_Dc
        '
        Me.CmbTinh_Dc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTinh_Dc.ForeColor = System.Drawing.Color.Navy
        Me.CmbTinh_Dc.FormattingEnabled = True
        Me.CmbTinh_Dc.Location = New System.Drawing.Point(120, 199)
        Me.CmbTinh_Dc.Name = "CmbTinh_Dc"
        Me.CmbTinh_Dc.Size = New System.Drawing.Size(220, 21)
        Me.CmbTinh_Dc.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 270
        Me.Label12.Tag = "Transfer arising stock"
        Me.Label12.Text = "Tính điều chuyển kho"
        '
        'ChkGroup3
        '
        Me.ChkGroup3.AutoSize = True
        Me.ChkGroup3.Location = New System.Drawing.Point(486, 229)
        Me.ChkGroup3.Name = "ChkGroup3"
        Me.ChkGroup3.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup3.TabIndex = 12
        Me.ChkGroup3.Tag = "Group 3"
        Me.ChkGroup3.Text = "Theo nhóm 3"
        Me.ChkGroup3.UseVisualStyleBackColor = True
        '
        'ChkGroup1
        '
        Me.ChkGroup1.AutoSize = True
        Me.ChkGroup1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ChkGroup1.Location = New System.Drawing.Point(120, 229)
        Me.ChkGroup1.Name = "ChkGroup1"
        Me.ChkGroup1.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup1.TabIndex = 10
        Me.ChkGroup1.Tag = "Group 1"
        Me.ChkGroup1.Text = "Theo nhóm 1"
        Me.ChkGroup1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 269
        Me.Label13.Tag = "Group by"
        Me.Label13.Text = "Nhóm theo"
        '
        'ChkGroup2
        '
        Me.ChkGroup2.AutoSize = True
        Me.ChkGroup2.Location = New System.Drawing.Point(304, 229)
        Me.ChkGroup2.Name = "ChkGroup2"
        Me.ChkGroup2.Size = New System.Drawing.Size(88, 17)
        Me.ChkGroup2.TabIndex = 11
        Me.ChkGroup2.Tag = "Group 2"
        Me.ChkGroup2.Text = "Theo nhóm 2"
        Me.ChkGroup2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 265
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm kiểu xe 3"
        '
        'TxtTen_Nh_Kx3
        '
        Me.TxtTen_Nh_Kx3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx3.Enabled = False
        Me.TxtTen_Nh_Kx3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx3.Location = New System.Drawing.Point(241, 179)
        Me.TxtTen_Nh_Kx3.Name = "TxtTen_Nh_Kx3"
        Me.TxtTen_Nh_Kx3.ReadOnly = True
        Me.TxtTen_Nh_Kx3.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Nh_Kx3.TabIndex = 264
        Me.TxtTen_Nh_Kx3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 263
        Me.Label7.Tag = "Group 2"
        Me.Label7.Text = "Nhóm kiểu xe 2"
        '
        'TxtTen_Nh_Kx2
        '
        Me.TxtTen_Nh_Kx2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx2.Enabled = False
        Me.TxtTen_Nh_Kx2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx2.Location = New System.Drawing.Point(241, 158)
        Me.TxtTen_Nh_Kx2.Name = "TxtTen_Nh_Kx2"
        Me.TxtTen_Nh_Kx2.ReadOnly = True
        Me.TxtTen_Nh_Kx2.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Nh_Kx2.TabIndex = 262
        Me.TxtTen_Nh_Kx2.TabStop = False
        '
        'TxtNh_Kx2
        '
        Me.TxtNh_Kx2._ActilookupPopup = False
        Me.TxtNh_Kx2.CyberActilookupPopup = True
        Me.TxtNh_Kx2.Dv_ListDetail = Nothing
        Me.TxtNh_Kx2.Dv_Master = Nothing
        Me.TxtNh_Kx2.FilterClient = ""
        Me.TxtNh_Kx2.FilterSQL = ""
        Me.TxtNh_Kx2.Location = New System.Drawing.Point(120, 155)
        Me.TxtNh_Kx2.Name = "TxtNh_Kx2"
        Me.TxtNh_Kx2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx2.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx2.TabIndex = 7
        Me.TxtNh_Kx2.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 261
        Me.Label5.Tag = "Group 1"
        Me.Label5.Text = "Nhóm kiểu xe 1"
        '
        'TxtTen_Nh_Kx1
        '
        Me.TxtTen_Nh_Kx1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Kx1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Kx1.Enabled = False
        Me.TxtTen_Nh_Kx1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Kx1.Location = New System.Drawing.Point(241, 137)
        Me.TxtTen_Nh_Kx1.Name = "TxtTen_Nh_Kx1"
        Me.TxtTen_Nh_Kx1.ReadOnly = True
        Me.TxtTen_Nh_Kx1.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Nh_Kx1.TabIndex = 260
        Me.TxtTen_Nh_Kx1.TabStop = False
        '
        'TxtNh_Kx1
        '
        Me.TxtNh_Kx1._ActilookupPopup = False
        Me.TxtNh_Kx1.CyberActilookupPopup = True
        Me.TxtNh_Kx1.Dv_ListDetail = Nothing
        Me.TxtNh_Kx1.Dv_Master = Nothing
        Me.TxtNh_Kx1.FilterClient = ""
        Me.TxtNh_Kx1.FilterSQL = ""
        Me.TxtNh_Kx1.Location = New System.Drawing.Point(120, 134)
        Me.TxtNh_Kx1.Name = "TxtNh_Kx1"
        Me.TxtNh_Kx1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx1.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx1.TabIndex = 6
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
        Me.TxtNh_Kx3.Location = New System.Drawing.Point(120, 176)
        Me.TxtNh_Kx3.Name = "TxtNh_Kx3"
        Me.TxtNh_Kx3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Kx3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Kx3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_Kx3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_Kx3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Kx3.Size = New System.Drawing.Size(116, 20)
        Me.TxtNh_Kx3.TabIndex = 8
        Me.TxtNh_Kx3.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 256
        Me.Label6.Tag = "Color"
        Me.Label6.Text = "Mã màu "
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(241, 93)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(398, 14)
        Me.TxtTen_Mau.TabIndex = 255
        Me.TxtTen_Mau.TabStop = False
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(120, 91)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Mau.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Mau.TabIndex = 4
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 271
        Me.Label2.Tag = "VIN"
        Me.Label2.Text = "Số khung"
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.Location = New System.Drawing.Point(120, 112)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(116, 21)
        Me.TxtSo_Khung.TabIndex = 5
        '
        'BECD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(643, 367)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbTinh_Dc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ChkGroup3)
        Me.Controls.Add(Me.ChkGroup1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ChkGroup2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Nh_Kx3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_Nh_Kx2)
        Me.Controls.Add(Me.TxtNh_Kx2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nh_Kx1)
        Me.Controls.Add(Me.TxtNh_Kx1)
        Me.Controls.Add(Me.TxtNh_Kx3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BECD2"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Kx3, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup2, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup1, 0)
        Me.Controls.SetChildIndex(Me.ChkGroup3, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.CmbTinh_Dc, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Kx3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents CmbTinh_Dc As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChkGroup3 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGroup1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkGroup2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_Kx1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Kx1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_Kx3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox

End Class
