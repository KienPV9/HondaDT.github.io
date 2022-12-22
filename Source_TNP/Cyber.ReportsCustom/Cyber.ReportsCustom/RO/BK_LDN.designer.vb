<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BK_LDN
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSo_DNTT = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_bp = New System.Windows.Forms.TextBox()
        Me.TxtMa_bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Loai_DN = New System.Windows.Forms.TextBox()
        Me.TxtMa_Loai_DN = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_GD = New System.Windows.Forms.TextBox()
        Me.TxtMa_GD = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtSo_DNTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Loai_DN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_GD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(513, 206)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(92, 174)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(521, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 177)
        Me.Label1.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(409, 206)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(6, 155)
        Me.LabLoai_NT.TabIndex = 14
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(92, 153)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(212, 153)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 5)
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
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(342, 5)
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
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(6, 13)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(245, 13)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 194)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(610, 9)
        Me.GroupBoxLine.TabIndex = 19
        Me.GroupBoxLine.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 509
        Me.Label11.Tag = "License Plate"
        Me.Label11.Text = "Số DNTT"
        '
        'TxtSo_DNTT
        '
        Me.TxtSo_DNTT._ActilookupPopup = False
        Me.TxtSo_DNTT.CyberActilookupPopup = True
        Me.TxtSo_DNTT.Dv_ListDetail = Nothing
        Me.TxtSo_DNTT.Dv_Master = Nothing
        Me.TxtSo_DNTT.FilterClient = ""
        Me.TxtSo_DNTT.FilterSQL = ""
        Me.TxtSo_DNTT.Location = New System.Drawing.Point(95, 98)
        Me.TxtSo_DNTT.Name = "TxtSo_DNTT"
        Me.TxtSo_DNTT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_DNTT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtSo_DNTT.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtSo_DNTT.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtSo_DNTT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSo_DNTT.Size = New System.Drawing.Size(116, 20)
        Me.TxtSo_DNTT.TabIndex = 5
        Me.TxtSo_DNTT.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 528
        Me.Label2.Tag = "License Plate"
        Me.Label2.Text = "Loại đề nghị"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 529
        Me.Label3.Tag = "License Plate"
        Me.Label3.Text = "Bộ phận đề nghị"
        '
        'TxtTen_bp
        '
        Me.TxtTen_bp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_bp.Enabled = False
        Me.TxtTen_bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_bp.Location = New System.Drawing.Point(217, 32)
        Me.TxtTen_bp.Name = "TxtTen_bp"
        Me.TxtTen_bp.ReadOnly = True
        Me.TxtTen_bp.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_bp.TabIndex = 533
        Me.TxtTen_bp.TabStop = False
        '
        'TxtMa_bp
        '
        Me.TxtMa_bp._ActilookupPopup = False
        Me.TxtMa_bp.CyberActilookupPopup = True
        Me.TxtMa_bp.Dv_ListDetail = Nothing
        Me.TxtMa_bp.Dv_Master = Nothing
        Me.TxtMa_bp.FilterClient = ""
        Me.TxtMa_bp.FilterSQL = ""
        Me.TxtMa_bp.Location = New System.Drawing.Point(95, 29)
        Me.TxtMa_bp.Name = "TxtMa_bp"
        Me.TxtMa_bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_bp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_bp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_bp.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_bp.TabIndex = 2
        Me.TxtMa_bp.Table_Name = ""
        '
        'TxtTen_Loai_DN
        '
        Me.TxtTen_Loai_DN.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Loai_DN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai_DN.Enabled = False
        Me.TxtTen_Loai_DN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai_DN.Location = New System.Drawing.Point(216, 55)
        Me.TxtTen_Loai_DN.Name = "TxtTen_Loai_DN"
        Me.TxtTen_Loai_DN.ReadOnly = True
        Me.TxtTen_Loai_DN.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Loai_DN.TabIndex = 535
        Me.TxtTen_Loai_DN.TabStop = False
        '
        'TxtMa_Loai_DN
        '
        Me.TxtMa_Loai_DN._ActilookupPopup = False
        Me.TxtMa_Loai_DN.CyberActilookupPopup = True
        Me.TxtMa_Loai_DN.Dv_ListDetail = Nothing
        Me.TxtMa_Loai_DN.Dv_Master = Nothing
        Me.TxtMa_Loai_DN.FilterClient = ""
        Me.TxtMa_Loai_DN.FilterSQL = ""
        Me.TxtMa_Loai_DN.Location = New System.Drawing.Point(95, 52)
        Me.TxtMa_Loai_DN.Name = "TxtMa_Loai_DN"
        Me.TxtMa_Loai_DN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai_DN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Loai_DN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Loai_DN.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Loai_DN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Loai_DN.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Loai_DN.TabIndex = 3
        Me.TxtMa_Loai_DN.Table_Name = ""
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(217, 124)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Hs.TabIndex = 538
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(95, 121)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HS.TabIndex = 6
        Me.TxtMa_HS.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 537
        Me.Label4.Tag = "License Plate"
        Me.Label4.Text = "Nhân viên"
        '
        'TxtTen_GD
        '
        Me.TxtTen_GD.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_GD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_GD.Enabled = False
        Me.TxtTen_GD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_GD.Location = New System.Drawing.Point(216, 78)
        Me.TxtTen_GD.Name = "TxtTen_GD"
        Me.TxtTen_GD.ReadOnly = True
        Me.TxtTen_GD.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_GD.TabIndex = 541
        Me.TxtTen_GD.TabStop = False
        '
        'TxtMa_GD
        '
        Me.TxtMa_GD._ActilookupPopup = False
        Me.TxtMa_GD.CyberActilookupPopup = True
        Me.TxtMa_GD.Dv_ListDetail = Nothing
        Me.TxtMa_GD.Dv_Master = Nothing
        Me.TxtMa_GD.FilterClient = ""
        Me.TxtMa_GD.FilterSQL = ""
        Me.TxtMa_GD.Location = New System.Drawing.Point(95, 75)
        Me.TxtMa_GD.Name = "TxtMa_GD"
        Me.TxtMa_GD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_GD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_GD.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_GD.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_GD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_GD.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_GD.TabIndex = 4
        Me.TxtMa_GD.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 540
        Me.Label5.Tag = "License Plate"
        Me.Label5.Text = "Loại phiếu"
        '
        'BK_LDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(617, 259)
        Me.Controls.Add(Me.TxtTen_GD)
        Me.Controls.Add(Me.TxtMa_GD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Loai_DN)
        Me.Controls.Add(Me.TxtMa_Loai_DN)
        Me.Controls.Add(Me.TxtTen_bp)
        Me.Controls.Add(Me.TxtMa_bp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSo_DNTT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BK_LDN"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_DNTT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai_DN, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai_DN, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_GD, 0)
        CType(Me.TxtSo_DNTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Loai_DN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_GD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_DNTT As SmLists.TxtLookup
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_bp As TextBox
    Friend WithEvents TxtMa_bp As SmLists.TxtLookup
    Friend WithEvents TxtTen_Loai_DN As TextBox
    Friend WithEvents TxtMa_Loai_DN As SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As TextBox
    Friend WithEvents TxtMa_HS As SmLists.TxtLookup
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTen_GD As TextBox
    Friend WithEvents TxtMa_GD As SmLists.TxtLookup
    Friend WithEvents Label5 As Label
End Class
