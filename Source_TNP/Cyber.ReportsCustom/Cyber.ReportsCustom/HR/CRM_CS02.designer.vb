<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRM_CS02
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
        Me.CbbMa_Ngay = New System.Windows.Forms.ComboBox()
        Me.LabMa_Ngay = New System.Windows.Forms.Label()
        Me.CbbMa_Loai = New System.Windows.Forms.ComboBox()
        Me.LabMa_Loai = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.LabMa_TH = New System.Windows.Forms.Label()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Cs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cs = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 263)
        Me.ButtExit.TabIndex = 12
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 224)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 227)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 263)
        Me.ButtOK.TabIndex = 11
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 205)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 202)
        Me.ChkVND.TabIndex = 9
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(241, 202)
        Me.ChkNT.TabIndex = 3
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 30)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 1
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 55)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 2
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(8, 37)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(8, 63)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 246)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbMa_Ngay
        '
        Me.CbbMa_Ngay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Ngay.FormattingEnabled = True
        Me.CbbMa_Ngay.Location = New System.Drawing.Point(319, 55)
        Me.CbbMa_Ngay.Name = "CbbMa_Ngay"
        Me.CbbMa_Ngay.Size = New System.Drawing.Size(267, 21)
        Me.CbbMa_Ngay.TabIndex = 4
        '
        'LabMa_Ngay
        '
        Me.LabMa_Ngay.AutoSize = True
        Me.LabMa_Ngay.Location = New System.Drawing.Point(241, 63)
        Me.LabMa_Ngay.Name = "LabMa_Ngay"
        Me.LabMa_Ngay.Size = New System.Drawing.Size(42, 13)
        Me.LabMa_Ngay.TabIndex = 1856
        Me.LabMa_Ngay.Tag = "Date (D)"
        Me.LabMa_Ngay.Text = "Ngày D"
        '
        'CbbMa_Loai
        '
        Me.CbbMa_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Loai.FormattingEnabled = True
        Me.CbbMa_Loai.Location = New System.Drawing.Point(319, 30)
        Me.CbbMa_Loai.Name = "CbbMa_Loai"
        Me.CbbMa_Loai.Size = New System.Drawing.Size(267, 21)
        Me.CbbMa_Loai.TabIndex = 3
        '
        'LabMa_Loai
        '
        Me.LabMa_Loai.AutoSize = True
        Me.LabMa_Loai.Location = New System.Drawing.Point(241, 37)
        Me.LabMa_Loai.Name = "LabMa_Loai"
        Me.LabMa_Loai.Size = New System.Drawing.Size(70, 13)
        Me.LabMa_Loai.TabIndex = 1854
        Me.LabMa_Loai.Tag = "Type"
        Me.LabMa_Loai.Text = "Loại đánh giá"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 1867
        Me.Label6.Tag = "Staff"
        Me.Label6.Text = "CVDV (TVBH)"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(209, 107)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(364, 14)
        Me.TxtTen_Hs.TabIndex = 1866
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(95, 103)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 6
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(8, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 1865
        Me.Label7.Tag = "License plate"
        Me.Label7.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 80)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 1864
        Me.Label3.Tag = "Color"
        Me.Label3.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(209, 178)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(364, 14)
        Me.TxtTen_Mau.TabIndex = 1863
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
        Me.TxtMa_Mau.Location = New System.Drawing.Point(95, 172)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Mau.TabIndex = 8
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 1862
        Me.Label4.Tag = "type car"
        Me.Label4.Text = "Kiểu xe"
        '
        'Txtten_Kx
        '
        Me.Txtten_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Kx.Enabled = False
        Me.Txtten_Kx.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Kx.Location = New System.Drawing.Point(209, 153)
        Me.Txtten_Kx.Name = "Txtten_Kx"
        Me.Txtten_Kx.ReadOnly = True
        Me.Txtten_Kx.Size = New System.Drawing.Size(364, 14)
        Me.Txtten_Kx.TabIndex = 1861
        Me.Txtten_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(95, 149)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kx.TabIndex = 7
        Me.TxtMa_Kx.Table_Name = ""
        '
        'LabMa_TH
        '
        Me.LabMa_TH.AutoSize = True
        Me.LabMa_TH.Location = New System.Drawing.Point(8, 10)
        Me.LabMa_TH.Name = "LabMa_TH"
        Me.LabMa_TH.Size = New System.Drawing.Size(77, 13)
        Me.LabMa_TH.TabIndex = 1869
        Me.LabMa_TH.Tag = "Group by"
        Me.LabMa_TH.Text = "Tổng hợp theo"
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(95, 6)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(491, 21)
        Me.CbbGroupByTH.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1872
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "NV CS/CR"
        '
        'TxtTen_Cs
        '
        Me.TxtTen_Cs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cs.Enabled = False
        Me.TxtTen_Cs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cs.Location = New System.Drawing.Point(209, 130)
        Me.TxtTen_Cs.Name = "TxtTen_Cs"
        Me.TxtTen_Cs.ReadOnly = True
        Me.TxtTen_Cs.Size = New System.Drawing.Size(364, 14)
        Me.TxtTen_Cs.TabIndex = 1871
        Me.TxtTen_Cs.TabStop = False
        '
        'TxtMa_Cs
        '
        Me.TxtMa_Cs._ActilookupPopup = False
        Me.TxtMa_Cs.CyberActilookupPopup = True
        Me.TxtMa_Cs.Dv_ListDetail = Nothing
        Me.TxtMa_Cs.Dv_Master = Nothing
        Me.TxtMa_Cs.FilterClient = ""
        Me.TxtMa_Cs.FilterSQL = ""
        Me.TxtMa_Cs.Location = New System.Drawing.Point(95, 126)
        Me.TxtMa_Cs.Name = "TxtMa_Cs"
        Me.TxtMa_Cs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Cs.TabIndex = 1870
        Me.TxtMa_Cs.Table_Name = ""
        '
        'CRM_CS01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 316)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Cs)
        Me.Controls.Add(Me.TxtMa_Cs)
        Me.Controls.Add(Me.LabMa_TH)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.CbbMa_Ngay)
        Me.Controls.Add(Me.LabMa_Ngay)
        Me.Controls.Add(Me.CbbMa_Loai)
        Me.Controls.Add(Me.LabMa_Loai)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "CRM_CS01"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cs, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbMa_Ngay As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Ngay As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Loai As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Loai As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_TH As System.Windows.Forms.Label
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cs As Cyber.SmLists.TxtLookup

End Class
