<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDTK30
    Inherits Cyber.From.FrmList

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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNgay_Ct = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.tXTSo_ct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtty_Gia = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbNo_Co = New System.Windows.Forms.ComboBox()
        Me.TxtMa_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_NT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NT = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtHan_TT = New ClsTextBox.txtTien_NT()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.Txtten_Ct = New System.Windows.Forms.TextBox()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNgay_DK = New ClsTextBox.txtDate()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(622, 346)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(520, 346)
        Me.ButtOK.TabIndex = 15
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(140, 7)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 356)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 336)
        Me.GroupBoxLine.Size = New System.Drawing.Size(720, 9)
        Me.GroupBoxLine.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(9, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 270
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "Mã hạch toán"
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###"
        Me.TxtT_Tien.Location = New System.Drawing.Point(140, 264)
        Me.TxtT_Tien.MaxWholeDigits = 14
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.Size = New System.Drawing.Size(135, 21)
        Me.TxtT_Tien.TabIndex = 12
        Me.TxtT_Tien.Tag = "### ### ### ### ###.##"
        Me.TxtT_Tien.Text = "0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(9, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Total (VND)"
        Me.Label3.Text = "Tổng tiền (VNĐ)"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(290, 130)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_TK.TabIndex = 260
        Me.TxtTen_TK.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(9, 129)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(100, 18)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Account"
        Me.lbMa_Phi.Text = "Tài khoản công nợ"
        '
        'TxtTK
        '
        Me.TxtTK._ActilookupPopup = False
        Me.TxtTK.CyberActilookupPopup = True
        Me.TxtTK.Dv_ListDetail = Nothing
        Me.TxtTK.Dv_Master = Nothing
        Me.TxtTK.FilterClient = ""
        Me.TxtTK.FilterSQL = ""
        Me.TxtTK.Location = New System.Drawing.Point(140, 127)
        Me.TxtTK.Name = "TxtTK"
        Me.TxtTK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK.Size = New System.Drawing.Size(135, 20)
        Me.TxtTK.TabIndex = 6
        Me.TxtTK.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(5, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(469, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(9, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Currency"
        Me.Label8.Text = "Loại tiền"
        '
        'txtNgay_Ct
        '
        Me.txtNgay_Ct.Flags = 65536
        Me.txtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_Ct.isEmpty = True
        Me.txtNgay_Ct.Location = New System.Drawing.Point(140, 58)
        Me.txtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_Ct.MaxLength = 10
        Me.txtNgay_Ct.Name = "txtNgay_Ct"
        Me.txtNgay_Ct.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_Ct.ShowDayBeforeMonth = False
        Me.txtNgay_Ct.Size = New System.Drawing.Size(135, 21)
        Me.txtNgay_Ct.TabIndex = 2
        Me.txtNgay_Ct.Text = "__/__/____"
        Me.txtNgay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 279
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "Ngày hạch toán"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(140, 173)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(570, 21)
        Me.TxtDien_Giai.TabIndex = 8
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(9, 177)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(87, 15)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Explain"
        Me.LabMa_CD.Text = "Diễn giải"
        '
        'tXTSo_ct
        '
        Me.tXTSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tXTSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.tXTSo_ct.Location = New System.Drawing.Point(140, 81)
        Me.tXTSo_ct.Name = "tXTSo_ct"
        Me.tXTSo_ct.Size = New System.Drawing.Size(135, 21)
        Me.tXTSo_ct.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 283
        Me.Label5.Tag = "Voucher No."
        Me.Label5.Text = "Số chứng từ"
        '
        'Txtty_Gia
        '
        Me.Txtty_Gia.AllowNegative = True
        Me.Txtty_Gia.Flags = 7680
        Me.Txtty_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Txtty_Gia.ForeColor = System.Drawing.Color.Navy
        Me.Txtty_Gia.InputMask = "### ### ### ### ###"
        Me.Txtty_Gia.Location = New System.Drawing.Point(140, 241)
        Me.Txtty_Gia.MaxWholeDigits = 14
        Me.Txtty_Gia.Name = "Txtty_Gia"
        Me.Txtty_Gia.RangeMax = 1.7976931348623157E+308R
        Me.Txtty_Gia.RangeMin = -1.7976931348623157E+308R
        Me.Txtty_Gia.Size = New System.Drawing.Size(135, 21)
        Me.Txtty_Gia.TabIndex = 11
        Me.Txtty_Gia.Tag = "### ### ### ### ###.##"
        Me.Txtty_Gia.Text = "0"
        Me.Txtty_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(140, 218)
        Me.TxtT_Tien_NT.MaxWholeDigits = 14
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(135, 21)
        Me.TxtT_Tien_NT.TabIndex = 10
        Me.TxtT_Tien_NT.Tag = "### ### ### ### ###.##"
        Me.TxtT_Tien_NT.Text = "0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Open credit balance(FC)"
        Me.Label2.Text = "Tỷ giá"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(9, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Total (Currency)"
        Me.Label6.Text = "Tổng tiền NT"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 289
        Me.Label4.Tag = "Time for payment"
        Me.Label4.Text = "Hạn thanh toán"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 290
        Me.Label7.Tag = "Debt/Credit"
        Me.Label7.Text = "Theo dõi nợ có"
        '
        'CbbNo_Co
        '
        Me.CbbNo_Co.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbNo_Co.FormattingEnabled = True
        Me.CbbNo_Co.Items.AddRange(New Object() {"0", "1"})
        Me.CbbNo_Co.Location = New System.Drawing.Point(140, 311)
        Me.CbbNo_Co.Name = "CbbNo_Co"
        Me.CbbNo_Co.Size = New System.Drawing.Size(135, 21)
        Me.CbbNo_Co.TabIndex = 14
        '
        'TxtMa_kh
        '
        Me.TxtMa_kh._ActilookupPopup = False
        Me.TxtMa_kh.CyberActilookupPopup = True
        Me.TxtMa_kh.Dv_ListDetail = Nothing
        Me.TxtMa_kh.Dv_Master = Nothing
        Me.TxtMa_kh.FilterClient = ""
        Me.TxtMa_kh.FilterSQL = ""
        Me.TxtMa_kh.Location = New System.Drawing.Point(140, 104)
        Me.TxtMa_kh.Name = "TxtMa_kh"
        Me.TxtMa_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kh.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_kh.TabIndex = 5
        Me.TxtMa_kh.Table_Name = ""
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(290, 107)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_kh.TabIndex = 294
        Me.TxtTen_kh.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(9, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 18)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Customer"
        Me.Label11.Text = "Khách  hàng"
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT._ActilookupPopup = False
        Me.TxtMa_NT.CyberActilookupPopup = True
        Me.TxtMa_NT.Dv_ListDetail = Nothing
        Me.TxtMa_NT.Dv_Master = Nothing
        Me.TxtMa_NT.FilterClient = ""
        Me.TxtMa_NT.FilterSQL = ""
        Me.TxtMa_NT.Location = New System.Drawing.Point(140, 196)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NT.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_NT.TabIndex = 9
        Me.TxtMa_NT.Table_Name = ""
        '
        'TxtTen_NT
        '
        Me.TxtTen_NT.BackColor = System.Drawing.Color.White
        Me.TxtTen_NT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NT.Location = New System.Drawing.Point(290, 199)
        Me.TxtTen_NT.Name = "TxtTen_NT"
        Me.TxtTen_NT.ReadOnly = True
        Me.TxtTen_NT.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_NT.TabIndex = 297
        Me.TxtTen_NT.TabStop = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ct.Location = New System.Drawing.Point(140, 34)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.ReadOnly = True
        Me.TxtMa_Ct.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Ct.TabIndex = 1
        Me.TxtMa_Ct.TabStop = False
        '
        'TxtHan_TT
        '
        Me.TxtHan_TT.AllowNegative = True
        Me.TxtHan_TT.Flags = 7680
        Me.TxtHan_TT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtHan_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtHan_TT.InputMask = "### ###"
        Me.TxtHan_TT.Location = New System.Drawing.Point(140, 288)
        Me.TxtHan_TT.MaxWholeDigits = 5
        Me.TxtHan_TT.Name = "TxtHan_TT"
        Me.TxtHan_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtHan_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtHan_TT.Size = New System.Drawing.Size(135, 21)
        Me.TxtHan_TT.TabIndex = 13
        Me.TxtHan_TT.Tag = "### ### ### ### ###.##"
        Me.TxtHan_TT.Text = "0"
        Me.TxtHan_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(291, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 291
        Me.Label9.Tag = "Producing process"
        Me.Label9.Text = "1-Nợ, 0-Có"
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(9, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 18)
        Me.Label13.TabIndex = 299
        Me.Label13.Tag = "Voucher ID"
        Me.Label13.Text = "Mã chứng từ"
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(281, 10)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_Dvcs.TabIndex = 300
        Me.TxtTen_Dvcs.TabStop = False
        '
        'Txtten_Ct
        '
        Me.Txtten_Ct.BackColor = System.Drawing.Color.White
        Me.Txtten_Ct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtten_Ct.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Ct.Location = New System.Drawing.Point(285, 41)
        Me.Txtten_Ct.Name = "Txtten_Ct"
        Me.Txtten_Ct.ReadOnly = True
        Me.Txtten_Ct.Size = New System.Drawing.Size(427, 14)
        Me.Txtten_Ct.TabIndex = 301
        Me.Txtten_Ct.TabStop = False
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(520, 81)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 16
        Me.TxtNam.TabStop = False
        Me.TxtNam.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(389, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 17)
        Me.Label14.TabIndex = 302
        Me.Label14.Tag = "Year"
        Me.Label14.Text = "Năm"
        Me.Label14.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(380, 220)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(135, 21)
        Me.TxtStt_Rec.TabIndex = 304
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(140, 149)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_Ro.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(9, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 15)
        Me.Label15.TabIndex = 306
        Me.Label15.Tag = "Voucher No."
        Me.Label15.Text = "Số RO"
        '
        'TxtNgay_DK
        '
        Me.TxtNgay_DK.Flags = 65536
        Me.TxtNgay_DK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_DK.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_DK.isEmpty = True
        Me.TxtNgay_DK.Location = New System.Drawing.Point(520, 58)
        Me.TxtNgay_DK.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_DK.MaxLength = 10
        Me.TxtNgay_DK.Name = "TxtNgay_DK"
        Me.TxtNgay_DK.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_DK.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_DK.ShowDayBeforeMonth = False
        Me.TxtNgay_DK.Size = New System.Drawing.Size(135, 21)
        Me.TxtNgay_DK.TabIndex = 307
        Me.TxtNgay_DK.Text = "__/__/____"
        Me.TxtNgay_DK.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(389, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 15)
        Me.Label16.TabIndex = 308
        Me.Label16.Tag = "Date"
        Me.Label16.Text = "Ngày Dự Kiến"
        '
        'CDTK30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(724, 379)
        Me.Controls.Add(Me.TxtNgay_DK)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtten_Ct)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtHan_TT)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTen_NT)
        Me.Controls.Add(Me.TxtMa_kh)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbbNo_Co)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtty_Gia)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tXTSo_ct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.txtNgay_Ct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CDTK30"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.tXTSo_ct, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.Txtty_Gia, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbNo_Co, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtHan_TT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_DK, 0)
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents tXTSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtty_Gia As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbNo_Co As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_NT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtHan_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtSo_Ro As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents TxtNgay_DK As ClsTextBox.txtDate
    Friend WithEvents Label16 As Windows.Forms.Label
End Class
