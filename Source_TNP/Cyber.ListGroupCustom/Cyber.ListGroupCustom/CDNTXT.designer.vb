<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDNTXT
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
        Me.TxtTien_NT = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtTien = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Luong = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSo_ct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.txtNgay_ct = New ClsTextBox.txtDate()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec0 = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(622, 178)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(520, 178)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(140, 8)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 188)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 168)
        Me.GroupBoxLine.Size = New System.Drawing.Size(720, 9)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtTien_NT
        '
        Me.TxtTien_NT.AllowNegative = True
        Me.TxtTien_NT.Flags = 7680
        Me.TxtTien_NT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT.InputMask = "### ### ### ### ###"
        Me.TxtTien_NT.Location = New System.Drawing.Point(140, 146)
        Me.TxtTien_NT.MaxWholeDigits = 14
        Me.TxtTien_NT.Name = "TxtTien_NT"
        Me.TxtTien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT.Size = New System.Drawing.Size(135, 21)
        Me.TxtTien_NT.TabIndex = 8
        Me.TxtTien_NT.Tag = "0"
        Me.TxtTien_NT.Text = "0"
        Me.TxtTien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(14, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Opening balance"
        Me.Label3.Text = "Dư đầu kỳ (Giá trị)"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(285, 103)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_vt.TabIndex = 260
        Me.TxtTen_vt.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(14, 102)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(100, 17)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Supplies"
        Me.lbMa_Phi.Text = "Vật tư"
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(140, 100)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_vt.TabIndex = 4
        Me.TxtMa_vt.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(0, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(308, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(14, 33)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Date voucher"
        Me.LabMa_CD.Text = "Ngày chứng từ"
        '
        'TxtTien
        '
        Me.TxtTien.AllowNegative = True
        Me.TxtTien.Flags = 7680
        Me.TxtTien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien.InputMask = "### ### ### ### ###"
        Me.TxtTien.Location = New System.Drawing.Point(485, 146)
        Me.TxtTien.MaxWholeDigits = 14
        Me.TxtTien.Name = "TxtTien"
        Me.TxtTien.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien.Size = New System.Drawing.Size(135, 21)
        Me.TxtTien.TabIndex = 7
        Me.TxtTien.Tag = "0"
        Me.TxtTien.Text = "0"
        Me.TxtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTien.Visible = False
        '
        'TxtSo_Luong
        '
        Me.TxtSo_Luong.AllowNegative = True
        Me.TxtSo_Luong.Flags = 7680
        Me.TxtSo_Luong.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Luong.InputMask = "### ### ### ###.##"
        Me.TxtSo_Luong.Location = New System.Drawing.Point(140, 122)
        Me.TxtSo_Luong.MaxWholeDigits = 14
        Me.TxtSo_Luong.Name = "TxtSo_Luong"
        Me.TxtSo_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Luong.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_Luong.TabIndex = 6
        Me.TxtSo_Luong.Tag = "0"
        Me.TxtSo_Luong.Text = "0"
        Me.TxtSo_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(359, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance VND"
        Me.Label2.Text = "Dư đầu kỳ VND (giá trị)"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(14, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(140, 78)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_kho.TabIndex = 3
        Me.TxtMa_kho.Table_Name = ""
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(285, 81)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_kho.TabIndex = 294
        Me.TxtTen_kho.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(14, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Warehouse"
        Me.Label11.Text = "Mã kho"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(14, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Mã hạch toán"
        '
        'TxtSo_ct
        '
        Me.TxtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ct.Location = New System.Drawing.Point(140, 56)
        Me.TxtSo_ct.Name = "TxtSo_ct"
        Me.TxtSo_ct.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_ct.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 303
        Me.Label1.Tag = "Voucher No."
        Me.Label1.Text = "Số chứng từ"
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(285, 11)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_Dvcs.TabIndex = 304
        Me.TxtTen_Dvcs.TabStop = False
        '
        'txtNgay_ct
        '
        Me.txtNgay_ct.Flags = 65536
        Me.txtNgay_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_ct.isEmpty = True
        Me.txtNgay_ct.Location = New System.Drawing.Point(140, 33)
        Me.txtNgay_ct.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_ct.MaxLength = 10
        Me.txtNgay_ct.Name = "txtNgay_ct"
        Me.txtNgay_ct.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_ct.ShowDayBeforeMonth = False
        Me.txtNgay_ct.Size = New System.Drawing.Size(135, 21)
        Me.txtNgay_ct.TabIndex = 1
        Me.txtNgay_ct.Text = "__/__/____"
        Me.txtNgay_ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(597, 58)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 306
        Me.TxtNam.TabStop = False
        Me.TxtNam.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(490, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 17)
        Me.Label14.TabIndex = 305
        Me.Label14.Tag = "Year"
        Me.Label14.Text = "Năm"
        Me.Label14.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(430, 182)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(71, 21)
        Me.TxtStt_Rec.TabIndex = 307
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ct.Location = New System.Drawing.Point(298, 178)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.ReadOnly = True
        Me.TxtMa_Ct.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_Ct.TabIndex = 308
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Visible = False
        '
        'TxtStt_Rec0
        '
        Me.TxtStt_Rec0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec0.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec0.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec0.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec0.Location = New System.Drawing.Point(383, 182)
        Me.TxtStt_Rec0.Name = "TxtStt_Rec0"
        Me.TxtStt_Rec0.ReadOnly = True
        Me.TxtStt_Rec0.Size = New System.Drawing.Size(71, 21)
        Me.TxtStt_Rec0.TabIndex = 309
        Me.TxtStt_Rec0.TabStop = False
        Me.TxtStt_Rec0.Visible = False
        '
        'CDNTXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(724, 211)
        Me.Controls.Add(Me.TxtStt_Rec0)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtSo_ct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNgay_ct)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTien)
        Me.Controls.Add(Me.TxtSo_Luong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.TxtTien_NT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CDNTXT"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtTien, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_ct, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec0, 0)
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_vt As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents TxtTien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Luong As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents txtNgay_ct As ClsTextBox.txtDate
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec0 As System.Windows.Forms.TextBox

End Class
