<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_DTDVGT
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkIs_N = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.ChkIs_I = New System.Windows.Forms.CheckBox()
        Me.ChkIs_C = New System.Windows.Forms.CheckBox()
        Me.ChkIs_All = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Cv1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_CtCv1 = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_CtCv1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(571, 237)
        Me.ButtExit.TabIndex = 18
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 200)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(560, 21)
        Me.CBBMa_Dvcs.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 203)
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(467, 237)
        Me.ButtOK.TabIndex = 17
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(14, 186)
        Me.LabLoai_NT.Size = New System.Drawing.Size(46, 13)
        Me.LabLoai_NT.TabIndex = 20
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 183)
        Me.ChkVND.TabIndex = 14
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(220, 183)
        Me.ChkNT.TabIndex = 15
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 3)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(321, 3)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(16, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(251, 7)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 220)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(668, 9)
        Me.GroupBoxLine.TabIndex = 21
        Me.GroupBoxLine.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 439
        Me.Label4.Tag = "Loại giao dịch"
        Me.Label4.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(453, 146)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(210, 21)
        Me.CbbMa_post2.TabIndex = 13
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(107, 146)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_Post1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 438
        Me.Label7.Tag = "Type"
        Me.Label7.Text = "Mức xử lý từ"
        '
        'ChkIs_N
        '
        Me.ChkIs_N.AutoSize = True
        Me.ChkIs_N.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_N.Location = New System.Drawing.Point(329, 122)
        Me.ChkIs_N.Name = "ChkIs_N"
        Me.ChkIs_N.Size = New System.Drawing.Size(130, 17)
        Me.ChkIs_N.TabIndex = 11
        Me.ChkIs_N.Text = "Nội bộ thanh toán (N)"
        Me.ChkIs_N.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_W.Location = New System.Drawing.Point(107, 122)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(148, 17)
        Me.ChkIs_W.TabIndex = 9
        Me.ChkIs_W.Text = "Bảo hành thanh toán (W)"
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'ChkIs_I
        '
        Me.ChkIs_I.AutoSize = True
        Me.ChkIs_I.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_I.Location = New System.Drawing.Point(329, 100)
        Me.ChkIs_I.Name = "ChkIs_I"
        Me.ChkIs_I.Size = New System.Drawing.Size(140, 17)
        Me.ChkIs_I.TabIndex = 10
        Me.ChkIs_I.Text = "Bảo hiểm thanh toán (I)"
        Me.ChkIs_I.UseVisualStyleBackColor = True
        '
        'ChkIs_C
        '
        Me.ChkIs_C.AutoSize = True
        Me.ChkIs_C.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_C.Location = New System.Drawing.Point(107, 100)
        Me.ChkIs_C.Name = "ChkIs_C"
        Me.ChkIs_C.Size = New System.Drawing.Size(156, 17)
        Me.ChkIs_C.TabIndex = 8
        Me.ChkIs_C.Text = "Khách hàng thanh toán (C)"
        Me.ChkIs_C.UseVisualStyleBackColor = True
        '
        'ChkIs_All
        '
        Me.ChkIs_All.AutoSize = True
        Me.ChkIs_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ChkIs_All.Location = New System.Drawing.Point(107, 79)
        Me.ChkIs_All.Name = "ChkIs_All"
        Me.ChkIs_All.Size = New System.Drawing.Size(154, 17)
        Me.ChkIs_All.TabIndex = 7
        Me.ChkIs_All.Text = "Tất cả loại hình thanh toán"
        Me.ChkIs_All.UseVisualStyleBackColor = True
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(107, 53)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 6
        Me.TxtMa_Hs.Table_Name = ""
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(235, 56)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Hs.TabIndex = 550
        Me.TxtTen_Hs.TabStop = False
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(15, 56)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(78, 13)
        Me.LabMa_Hs.TabIndex = 551
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 554
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "Nhóm công việc"
        '
        'TxtTen_Nh_Cv1
        '
        Me.TxtTen_Nh_Cv1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Cv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Cv1.Enabled = False
        Me.TxtTen_Nh_Cv1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Cv1.Location = New System.Drawing.Point(235, 32)
        Me.TxtTen_Nh_Cv1.Name = "TxtTen_Nh_Cv1"
        Me.TxtTen_Nh_Cv1.ReadOnly = True
        Me.TxtTen_Nh_Cv1.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Nh_Cv1.TabIndex = 553
        Me.TxtTen_Nh_Cv1.TabStop = False
        '
        'TxtNh_CtCv1
        '
        Me.TxtNh_CtCv1._ActilookupPopup = False
        Me.TxtNh_CtCv1.CyberActilookupPopup = True
        Me.TxtNh_CtCv1.Dv_ListDetail = Nothing
        Me.TxtNh_CtCv1.Dv_Master = Nothing
        Me.TxtNh_CtCv1.FilterClient = ""
        Me.TxtNh_CtCv1.FilterSQL = ""
        Me.TxtNh_CtCv1.Location = New System.Drawing.Point(107, 29)
        Me.TxtNh_CtCv1.Name = "TxtNh_CtCv1"
        Me.TxtNh_CtCv1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_CtCv1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_CtCv1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_CtCv1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_CtCv1.TabIndex = 3
        Me.TxtNh_CtCv1.Table_Name = ""
        '
        'RO_DTDVGT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(675, 290)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nh_Cv1)
        Me.Controls.Add(Me.TxtNh_CtCv1)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.ChkIs_All)
        Me.Controls.Add(Me.ChkIs_N)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.ChkIs_I)
        Me.Controls.Add(Me.ChkIs_C)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "RO_DTDVGT"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_All, 0)
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
        Me.Controls.SetChildIndex(Me.TxtNh_CtCv1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Cv1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_CtCv1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_N As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_W As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_I As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_C As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_All As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Hs As SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs As TextBox
    Friend WithEvents LabMa_Hs As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTen_Nh_Cv1 As TextBox
    Friend WithEvents TxtNh_CtCv1 As SmLists.TxtLookup
End Class
