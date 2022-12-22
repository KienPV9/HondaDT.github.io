<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RO_DT02
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.CbbGroupByCT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ma_TT = New System.Windows.Forms.ComboBox()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.ChkDetail_OK = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbLoai_Phieu = New System.Windows.Forms.ComboBox()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNh_Vt3 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt1 = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNh_CV3 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_CV2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_CV1 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_CV = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTen_CV = New System.Windows.Forms.TextBox()
        Me.ChkIs_All = New System.Windows.Forms.CheckBox()
        Me.ChkIs_N = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.ChkIs_I = New System.Windows.Forms.CheckBox()
        Me.ChkIs_C = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CV3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CV2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CV1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(571, 370)
        Me.ButtExit.TabIndex = 22
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 335)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(560, 21)
        Me.CBBMa_Dvcs.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 338)
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(467, 370)
        Me.ButtOK.TabIndex = 21
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 321)
        Me.LabLoai_NT.Size = New System.Drawing.Size(46, 13)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 318)
        Me.ChkVND.TabIndex = 18
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(221, 318)
        Me.ChkNT.TabIndex = 19
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 47)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 3
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(317, 47)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(102, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 4
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 51)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(229, 51)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 353)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(668, 9)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 386
        Me.Label3.Tag = "Group by"
        Me.Label3.Text = "Tổng hợp theo"
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(107, 0)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(560, 21)
        Me.CbbGroupByTH.TabIndex = 0
        '
        'CbbGroupByCT
        '
        Me.CbbGroupByCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByCT.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByCT.FormattingEnabled = True
        Me.CbbGroupByCT.Location = New System.Drawing.Point(221, 23)
        Me.CbbGroupByCT.Name = "CbbGroupByCT"
        Me.CbbGroupByCT.Size = New System.Drawing.Size(446, 21)
        Me.CbbGroupByCT.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 443
        Me.Label6.Tag = "Payments"
        Me.Label6.Text = "Thanh toán"
        Me.Label6.Visible = False
        '
        'Ma_TT
        '
        Me.Ma_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ma_TT.ForeColor = System.Drawing.Color.Navy
        Me.Ma_TT.FormattingEnabled = True
        Me.Ma_TT.Location = New System.Drawing.Point(107, 379)
        Me.Ma_TT.Name = "Ma_TT"
        Me.Ma_TT.Size = New System.Drawing.Size(213, 21)
        Me.Ma_TT.TabIndex = 17
        Me.Ma_TT.Visible = False
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(15, 74)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(78, 13)
        Me.LabMa_Hs.TabIndex = 475
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(235, 74)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Hs.TabIndex = 453
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(107, 71)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 5
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 515
        Me.Label10.Tag = "Type car"
        Me.Label10.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(235, 96)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Kx.TabIndex = 514
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(107, 93)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_KX.TabIndex = 6
        Me.TxtMa_KX.Table_Name = ""
        '
        'ChkDetail_OK
        '
        Me.ChkDetail_OK.AutoSize = True
        Me.ChkDetail_OK.Location = New System.Drawing.Point(107, 26)
        Me.ChkDetail_OK.Name = "ChkDetail_OK"
        Me.ChkDetail_OK.Size = New System.Drawing.Size(85, 17)
        Me.ChkDetail_OK.TabIndex = 1
        Me.ChkDetail_OK.Tag = "Detail"
        Me.ChkDetail_OK.Text = "Chi tiết theo"
        Me.ChkDetail_OK.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 520
        Me.Label9.Tag = "Type"
        Me.Label9.Text = "Loại lệnh"
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(455, 207)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_GD.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 519
        Me.Label2.Tag = "Command"
        Me.Label2.Text = "Lệnh"
        '
        'CbbLoai_Phieu
        '
        Me.CbbLoai_Phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Phieu.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Phieu.FormattingEnabled = True
        Me.CbbLoai_Phieu.Location = New System.Drawing.Point(107, 207)
        Me.CbbLoai_Phieu.Name = "CbbLoai_Phieu"
        Me.CbbLoai_Phieu.Size = New System.Drawing.Size(213, 21)
        Me.CbbLoai_Phieu.TabIndex = 15
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(235, 118)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_vt.TabIndex = 523
        Me.TxtTen_vt.TabStop = False
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.EditValue = ""
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(107, 115)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_vt.TabIndex = 7
        Me.TxtMa_vt.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 522
        Me.Label4.Tag = "Supplies "
        Me.Label4.Text = "Mã vật tư"
        '
        'TxtNh_Vt3
        '
        Me.TxtNh_Vt3._ActilookupPopup = False
        Me.TxtNh_Vt3.CyberActilookupPopup = True
        Me.TxtNh_Vt3.Dv_ListDetail = Nothing
        Me.TxtNh_Vt3.Dv_Master = Nothing
        Me.TxtNh_Vt3.FilterClient = ""
        Me.TxtNh_Vt3.FilterSQL = ""
        Me.TxtNh_Vt3.Location = New System.Drawing.Point(553, 138)
        Me.TxtNh_Vt3.Name = "TxtNh_Vt3"
        Me.TxtNh_Vt3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt3.TabIndex = 10
        Me.TxtNh_Vt3.Table_Name = ""
        '
        'TxtNh_Vt2
        '
        Me.TxtNh_Vt2._ActilookupPopup = False
        Me.TxtNh_Vt2.CyberActilookupPopup = True
        Me.TxtNh_Vt2.Dv_ListDetail = Nothing
        Me.TxtNh_Vt2.Dv_Master = Nothing
        Me.TxtNh_Vt2.FilterClient = ""
        Me.TxtNh_Vt2.FilterSQL = ""
        Me.TxtNh_Vt2.Location = New System.Drawing.Point(317, 138)
        Me.TxtNh_Vt2.Name = "TxtNh_Vt2"
        Me.TxtNh_Vt2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt2.Size = New System.Drawing.Size(102, 20)
        Me.TxtNh_Vt2.TabIndex = 9
        Me.TxtNh_Vt2.Table_Name = ""
        '
        'TxtNh_Vt1
        '
        Me.TxtNh_Vt1._ActilookupPopup = False
        Me.TxtNh_Vt1.CyberActilookupPopup = True
        Me.TxtNh_Vt1.Dv_ListDetail = Nothing
        Me.TxtNh_Vt1.Dv_Master = Nothing
        Me.TxtNh_Vt1.FilterClient = ""
        Me.TxtNh_Vt1.FilterSQL = ""
        Me.TxtNh_Vt1.Location = New System.Drawing.Point(107, 138)
        Me.TxtNh_Vt1.Name = "TxtNh_Vt1"
        Me.TxtNh_Vt1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt1.TabIndex = 8
        Me.TxtNh_Vt1.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(474, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 529
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm vật tư 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(229, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 528
        Me.Label13.Tag = "Group 2"
        Me.Label13.Text = "Nhóm vật tư 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 527
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Nhóm vật tư 1"
        '
        'TxtNh_CV3
        '
        Me.TxtNh_CV3._ActilookupPopup = False
        Me.TxtNh_CV3.CyberActilookupPopup = True
        Me.TxtNh_CV3.Dv_ListDetail = Nothing
        Me.TxtNh_CV3.Dv_Master = Nothing
        Me.TxtNh_CV3.FilterClient = ""
        Me.TxtNh_CV3.FilterSQL = ""
        Me.TxtNh_CV3.Location = New System.Drawing.Point(553, 183)
        Me.TxtNh_CV3.Name = "TxtNh_CV3"
        Me.TxtNh_CV3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CV3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CV3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CV3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CV3.TabIndex = 14
        Me.TxtNh_CV3.Table_Name = ""
        '
        'TxtNh_CV2
        '
        Me.TxtNh_CV2._ActilookupPopup = False
        Me.TxtNh_CV2.CyberActilookupPopup = True
        Me.TxtNh_CV2.Dv_ListDetail = Nothing
        Me.TxtNh_CV2.Dv_Master = Nothing
        Me.TxtNh_CV2.FilterClient = ""
        Me.TxtNh_CV2.FilterSQL = ""
        Me.TxtNh_CV2.Location = New System.Drawing.Point(317, 183)
        Me.TxtNh_CV2.Name = "TxtNh_CV2"
        Me.TxtNh_CV2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CV2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CV2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CV2.Size = New System.Drawing.Size(102, 20)
        Me.TxtNh_CV2.TabIndex = 13
        Me.TxtNh_CV2.Table_Name = ""
        '
        'TxtNh_CV1
        '
        Me.TxtNh_CV1._ActilookupPopup = False
        Me.TxtNh_CV1.CyberActilookupPopup = True
        Me.TxtNh_CV1.Dv_ListDetail = Nothing
        Me.TxtNh_CV1.Dv_Master = Nothing
        Me.TxtNh_CV1.FilterClient = ""
        Me.TxtNh_CV1.FilterSQL = ""
        Me.TxtNh_CV1.Location = New System.Drawing.Point(107, 183)
        Me.TxtNh_CV1.Name = "TxtNh_CV1"
        Me.TxtNh_CV1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CV1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CV1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CV1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CV1.TabIndex = 12
        Me.TxtNh_CV1.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(474, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 537
        Me.Label5.Tag = "Group 3"
        Me.Label5.Text = "Nhóm CV3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 536
        Me.Label7.Tag = "Group 2"
        Me.Label7.Text = "Nhóm CV2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 535
        Me.Label11.Tag = "Group 1"
        Me.Label11.Text = "Nhóm CV1"
        '
        'TxtMa_CV
        '
        Me.TxtMa_CV._ActilookupPopup = False
        Me.TxtMa_CV.CyberActilookupPopup = True
        Me.TxtMa_CV.Dv_ListDetail = Nothing
        Me.TxtMa_CV.Dv_Master = Nothing
        Me.TxtMa_CV.EditValue = ""
        Me.TxtMa_CV.FilterClient = ""
        Me.TxtMa_CV.FilterSQL = ""
        Me.TxtMa_CV.Location = New System.Drawing.Point(107, 160)
        Me.TxtMa_CV.Name = "TxtMa_CV"
        Me.TxtMa_CV.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CV.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CV.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_CV.TabIndex = 11
        Me.TxtMa_CV.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(15, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 531
        Me.Label12.Tag = "Supplies "
        Me.Label12.Text = "Mã công việc"
        '
        'TxtTen_CV
        '
        Me.TxtTen_CV.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_CV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_CV.Enabled = False
        Me.TxtTen_CV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CV.Location = New System.Drawing.Point(235, 163)
        Me.TxtTen_CV.Name = "TxtTen_CV"
        Me.TxtTen_CV.ReadOnly = True
        Me.TxtTen_CV.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_CV.TabIndex = 538
        Me.TxtTen_CV.TabStop = False
        '
        'ChkIs_All
        '
        Me.ChkIs_All.AutoSize = True
        Me.ChkIs_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_All.Location = New System.Drawing.Point(107, 238)
        Me.ChkIs_All.Name = "ChkIs_All"
        Me.ChkIs_All.Size = New System.Drawing.Size(154, 17)
        Me.ChkIs_All.TabIndex = 621
        Me.ChkIs_All.Text = "Tất cả loại hình thanh toán"
        Me.ChkIs_All.UseVisualStyleBackColor = True
        '
        'ChkIs_N
        '
        Me.ChkIs_N.AutoSize = True
        Me.ChkIs_N.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_N.Location = New System.Drawing.Point(329, 281)
        Me.ChkIs_N.Name = "ChkIs_N"
        Me.ChkIs_N.Size = New System.Drawing.Size(130, 17)
        Me.ChkIs_N.TabIndex = 625
        Me.ChkIs_N.Text = "Nội bộ thanh toán (N)"
        Me.ChkIs_N.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_W.Location = New System.Drawing.Point(107, 281)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(148, 17)
        Me.ChkIs_W.TabIndex = 623
        Me.ChkIs_W.Text = "Bảo hành thanh toán (W)"
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'ChkIs_I
        '
        Me.ChkIs_I.AutoSize = True
        Me.ChkIs_I.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_I.Location = New System.Drawing.Point(329, 259)
        Me.ChkIs_I.Name = "ChkIs_I"
        Me.ChkIs_I.Size = New System.Drawing.Size(140, 17)
        Me.ChkIs_I.TabIndex = 624
        Me.ChkIs_I.Text = "Bảo hiểm thanh toán (I)"
        Me.ChkIs_I.UseVisualStyleBackColor = True
        '
        'ChkIs_C
        '
        Me.ChkIs_C.AutoSize = True
        Me.ChkIs_C.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_C.Location = New System.Drawing.Point(107, 259)
        Me.ChkIs_C.Name = "ChkIs_C"
        Me.ChkIs_C.Size = New System.Drawing.Size(156, 17)
        Me.ChkIs_C.TabIndex = 622
        Me.ChkIs_C.Text = "Khách hàng thanh toán (C)"
        Me.ChkIs_C.UseVisualStyleBackColor = True
        '
        'RO_DT02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(675, 423)
        Me.Controls.Add(Me.ChkIs_All)
        Me.Controls.Add(Me.ChkIs_N)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.ChkIs_I)
        Me.Controls.Add(Me.ChkIs_C)
        Me.Controls.Add(Me.TxtTen_CV)
        Me.Controls.Add(Me.TxtNh_CV3)
        Me.Controls.Add(Me.TxtNh_CV2)
        Me.Controls.Add(Me.TxtNh_CV1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtMa_CV)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNh_Vt3)
        Me.Controls.Add(Me.TxtNh_Vt2)
        Me.Controls.Add(Me.TxtNh_Vt1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbLoai_Phieu)
        Me.Controls.Add(Me.ChkDetail_OK)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Ma_TT)
        Me.Controls.Add(Me.CbbGroupByCT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "RO_DT02"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByCT, 0)
        Me.Controls.SetChildIndex(Me.Ma_TT, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.ChkDetail_OK, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Phieu, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt3, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CV, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CV1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CV2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_CV3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CV, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_All, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CV3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CV2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CV1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents CbbGroupByCT As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ma_TT As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkDetail_OK As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbbMa_GD As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbbLoai_Phieu As ComboBox
    Friend WithEvents TxtTen_vt As TextBox
    Friend WithEvents TxtMa_vt As SmLists.TxtLookup
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNh_Vt3 As SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt2 As SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt1 As SmLists.TxtLookup
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtNh_CV3 As SmLists.TxtLookup
    Friend WithEvents TxtNh_CV2 As SmLists.TxtLookup
    Friend WithEvents TxtNh_CV1 As SmLists.TxtLookup
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtMa_CV As SmLists.TxtLookup
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTen_CV As TextBox
    Friend WithEvents ChkIs_All As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_N As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_W As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_I As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_C As System.Windows.Forms.CheckBox
End Class
