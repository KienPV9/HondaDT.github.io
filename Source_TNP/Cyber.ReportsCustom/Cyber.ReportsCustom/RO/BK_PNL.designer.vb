<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BK_PNL
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_bp = New System.Windows.Forms.TextBox()
        Me.TxtMa_bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HD = New System.Windows.Forms.TextBox()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TD3 = New System.Windows.Forms.TextBox()
        Me.TxtMa_TD3 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(513, 175)
        Me.ButtExit.TabIndex = 6
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(92, 143)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(521, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 146)
        Me.Label1.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(409, 175)
        Me.ButtOK.TabIndex = 5
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(6, 124)
        Me.LabLoai_NT.TabIndex = 14
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(92, 122)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(212, 122)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(103, 5)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 163)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(610, 9)
        Me.GroupBoxLine.TabIndex = 19
        Me.GroupBoxLine.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 528
        Me.Label2.Tag = "License Plate"
        Me.Label2.Text = "Hợp đồng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 38)
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
        Me.TxtTen_bp.Location = New System.Drawing.Point(225, 39)
        Me.TxtTen_bp.Name = "TxtTen_bp"
        Me.TxtTen_bp.ReadOnly = True
        Me.TxtTen_bp.Size = New System.Drawing.Size(362, 14)
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
        Me.TxtMa_bp.Location = New System.Drawing.Point(103, 36)
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
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HD.Enabled = False
        Me.TxtTen_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD.Location = New System.Drawing.Point(224, 65)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.ReadOnly = True
        Me.TxtTen_HD.Size = New System.Drawing.Size(362, 14)
        Me.TxtTen_HD.TabIndex = 535
        Me.TxtTen_HD.TabStop = False
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = ""
        Me.TxtMa_HD.FilterSQL = ""
        Me.TxtMa_HD.Location = New System.Drawing.Point(103, 62)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HD.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HD.TabIndex = 3
        Me.TxtMa_HD.Table_Name = ""
        '
        'TxtTen_TD3
        '
        Me.TxtTen_TD3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TD3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TD3.Enabled = False
        Me.TxtTen_TD3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TD3.Location = New System.Drawing.Point(224, 91)
        Me.TxtTen_TD3.Name = "TxtTen_TD3"
        Me.TxtTen_TD3.ReadOnly = True
        Me.TxtTen_TD3.Size = New System.Drawing.Size(363, 14)
        Me.TxtTen_TD3.TabIndex = 538
        Me.TxtTen_TD3.TabStop = False
        '
        'TxtMa_TD3
        '
        Me.TxtMa_TD3._ActilookupPopup = False
        Me.TxtMa_TD3.CyberActilookupPopup = True
        Me.TxtMa_TD3.Dv_ListDetail = Nothing
        Me.TxtMa_TD3.Dv_Master = Nothing
        Me.TxtMa_TD3.FilterClient = ""
        Me.TxtMa_TD3.FilterSQL = ""
        Me.TxtMa_TD3.Location = New System.Drawing.Point(103, 88)
        Me.TxtMa_TD3.Name = "TxtMa_TD3"
        Me.TxtMa_TD3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TD3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TD3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_TD3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_TD3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TD3.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_TD3.TabIndex = 4
        Me.TxtMa_TD3.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 537
        Me.Label4.Tag = "License Plate"
        Me.Label4.Text = "Hợp đồng chi tiết"
        '
        'BK_PNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(617, 228)
        Me.Controls.Add(Me.TxtTen_TD3)
        Me.Controls.Add(Me.TxtMa_TD3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.TxtTen_bp)
        Me.Controls.Add(Me.TxtMa_bp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BK_PNL"
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
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TD3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TD3, 0)
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_bp As TextBox
    Friend WithEvents TxtMa_bp As SmLists.TxtLookup
    Friend WithEvents TxtTen_HD As TextBox
    Friend WithEvents TxtMa_HD As SmLists.TxtLookup
    Friend WithEvents TxtTen_TD3 As TextBox
    Friend WithEvents TxtMa_TD3 As SmLists.TxtLookup
    Friend WithEvents Label4 As Label
End Class
