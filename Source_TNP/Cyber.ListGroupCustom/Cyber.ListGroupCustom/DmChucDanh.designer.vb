<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmChucDanh
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_ChucDanh2 = New System.Windows.Forms.TextBox()
        Me.TxtMa_ChucDanh = New System.Windows.Forms.TextBox()
        Me.TxtTen_ChucDanh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.CmbCap = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ChkIs_Dv_Admin = New System.Windows.Forms.CheckBox()
        Me.ChkIs_DV_Dieu_phoi = New System.Windows.Forms.CheckBox()
        Me.ChkIs_DV_KTV_SDS = New System.Windows.Forms.CheckBox()
        Me.ChkIs_DV_KTV_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkIs_DV_CVDV = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Kd_Admin = New System.Windows.Forms.CheckBox()
        Me.ChkIs_KD_TP = New System.Windows.Forms.CheckBox()
        Me.ChkIs_KD_TVBH = New System.Windows.Forms.CheckBox()
        Me.TxtTieu_Chuan_TD = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMo_Ta_CV = New System.Windows.Forms.RichTextBox()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(545, 455)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(443, 455)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(337, 461)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 465)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 445)
        Me.GroupBoxLine.Size = New System.Drawing.Size(643, 9)
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 14)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(88, 13)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Free 1"
        Me.LabMa_TD1.Text = "Mã chức danh"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Tag = "Free 1"
        Me.Label6.Text = "Tên tiếng anh "
        '
        'TxtTen_ChucDanh2
        '
        Me.TxtTen_ChucDanh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChucDanh2.Location = New System.Drawing.Point(101, 60)
        Me.TxtTen_ChucDanh2.Name = "TxtTen_ChucDanh2"
        Me.TxtTen_ChucDanh2.Size = New System.Drawing.Size(534, 21)
        Me.TxtTen_ChucDanh2.TabIndex = 2
        '
        'TxtMa_ChucDanh
        '
        Me.TxtMa_ChucDanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ChucDanh.Location = New System.Drawing.Point(101, 11)
        Me.TxtMa_ChucDanh.Name = "TxtMa_ChucDanh"
        Me.TxtMa_ChucDanh.Size = New System.Drawing.Size(161, 21)
        Me.TxtMa_ChucDanh.TabIndex = 0
        '
        'TxtTen_ChucDanh
        '
        Me.TxtTen_ChucDanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChucDanh.Location = New System.Drawing.Point(101, 35)
        Me.TxtTen_ChucDanh.Name = "TxtTen_ChucDanh"
        Me.TxtTen_ChucDanh.Size = New System.Drawing.Size(534, 21)
        Me.TxtTen_ChucDanh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "Free 1"
        Me.Label1.Text = "Tên chức danh"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Tag = "Department"
        Me.Label5.Text = "Bộ phận/Phòng"
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.Color.White
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Enabled = False
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(253, 86)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_BP.TabIndex = 55
        Me.TxtTen_BP.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(101, 83)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_BP.TabIndex = 3
        Me.TxtMa_BP.Table_Name = ""
        '
        'CmbCap
        '
        Me.CmbCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCap.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbCap.ForeColor = System.Drawing.Color.Navy
        Me.CmbCap.FormattingEnabled = True
        Me.CmbCap.Items.AddRange(New Object() {"Đang làm việc", "Đã chấm dứt hợp đồng lao động"})
        Me.CmbCap.Location = New System.Drawing.Point(101, 107)
        Me.CmbCap.Name = "CmbCap"
        Me.CmbCap.Size = New System.Drawing.Size(149, 21)
        Me.CmbCap.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(7, 109)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 18)
        Me.Label25.TabIndex = 374
        Me.Label25.Tag = "Working status"
        Me.Label25.Text = "Phân cấp"
        '
        'ChkIs_Dv_Admin
        '
        Me.ChkIs_Dv_Admin.AutoSize = True
        Me.ChkIs_Dv_Admin.Location = New System.Drawing.Point(298, 158)
        Me.ChkIs_Dv_Admin.Name = "ChkIs_Dv_Admin"
        Me.ChkIs_Dv_Admin.Size = New System.Drawing.Size(92, 17)
        Me.ChkIs_Dv_Admin.TabIndex = 380
        Me.ChkIs_Dv_Admin.Text = "Admin dịch vụ"
        Me.ChkIs_Dv_Admin.UseVisualStyleBackColor = True
        '
        'ChkIs_DV_Dieu_phoi
        '
        Me.ChkIs_DV_Dieu_phoi.AutoSize = True
        Me.ChkIs_DV_Dieu_phoi.Location = New System.Drawing.Point(432, 135)
        Me.ChkIs_DV_Dieu_phoi.Name = "ChkIs_DV_Dieu_phoi"
        Me.ChkIs_DV_Dieu_phoi.Size = New System.Drawing.Size(94, 17)
        Me.ChkIs_DV_Dieu_phoi.TabIndex = 377
        Me.ChkIs_DV_Dieu_phoi.Text = "Điều phối viên"
        Me.ChkIs_DV_Dieu_phoi.UseVisualStyleBackColor = True
        '
        'ChkIs_DV_KTV_SDS
        '
        Me.ChkIs_DV_KTV_SDS.AutoSize = True
        Me.ChkIs_DV_KTV_SDS.Location = New System.Drawing.Point(432, 181)
        Me.ChkIs_DV_KTV_SDS.Name = "ChkIs_DV_KTV_SDS"
        Me.ChkIs_DV_KTV_SDS.Size = New System.Drawing.Size(73, 17)
        Me.ChkIs_DV_KTV_SDS.TabIndex = 382
        Me.ChkIs_DV_KTV_SDS.Text = "KTV SCDS"
        Me.ChkIs_DV_KTV_SDS.UseVisualStyleBackColor = True
        '
        'ChkIs_DV_KTV_SCC
        '
        Me.ChkIs_DV_KTV_SCC.AutoSize = True
        Me.ChkIs_DV_KTV_SCC.Location = New System.Drawing.Point(432, 158)
        Me.ChkIs_DV_KTV_SCC.Name = "ChkIs_DV_KTV_SCC"
        Me.ChkIs_DV_KTV_SCC.Size = New System.Drawing.Size(67, 17)
        Me.ChkIs_DV_KTV_SCC.TabIndex = 379
        Me.ChkIs_DV_KTV_SCC.Text = "KTV SCC"
        Me.ChkIs_DV_KTV_SCC.UseVisualStyleBackColor = True
        '
        'ChkIs_DV_CVDV
        '
        Me.ChkIs_DV_CVDV.AutoSize = True
        Me.ChkIs_DV_CVDV.Location = New System.Drawing.Point(298, 135)
        Me.ChkIs_DV_CVDV.Name = "ChkIs_DV_CVDV"
        Me.ChkIs_DV_CVDV.Size = New System.Drawing.Size(97, 17)
        Me.ChkIs_DV_CVDV.TabIndex = 376
        Me.ChkIs_DV_CVDV.Text = "Cố vấn dịch vụ"
        Me.ChkIs_DV_CVDV.UseVisualStyleBackColor = True
        '
        'ChkIs_Kd_Admin
        '
        Me.ChkIs_Kd_Admin.AutoSize = True
        Me.ChkIs_Kd_Admin.Location = New System.Drawing.Point(101, 158)
        Me.ChkIs_Kd_Admin.Name = "ChkIs_Kd_Admin"
        Me.ChkIs_Kd_Admin.Size = New System.Drawing.Size(77, 17)
        Me.ChkIs_Kd_Admin.TabIndex = 381
        Me.ChkIs_Kd_Admin.Text = "Sale admin"
        Me.ChkIs_Kd_Admin.UseVisualStyleBackColor = True
        '
        'ChkIs_KD_TP
        '
        Me.ChkIs_KD_TP.AutoSize = True
        Me.ChkIs_KD_TP.Location = New System.Drawing.Point(99, 181)
        Me.ChkIs_KD_TP.Name = "ChkIs_KD_TP"
        Me.ChkIs_KD_TP.Size = New System.Drawing.Size(110, 17)
        Me.ChkIs_KD_TP.TabIndex = 378
        Me.ChkIs_KD_TP.Text = "Trưởng phòng KD"
        Me.ChkIs_KD_TP.UseVisualStyleBackColor = True
        '
        'ChkIs_KD_TVBH
        '
        Me.ChkIs_KD_TVBH.AutoSize = True
        Me.ChkIs_KD_TVBH.Location = New System.Drawing.Point(101, 135)
        Me.ChkIs_KD_TVBH.Name = "ChkIs_KD_TVBH"
        Me.ChkIs_KD_TVBH.Size = New System.Drawing.Size(108, 17)
        Me.ChkIs_KD_TVBH.TabIndex = 375
        Me.ChkIs_KD_TVBH.Text = "Tư vấn bán hàng"
        Me.ChkIs_KD_TVBH.UseVisualStyleBackColor = True
        '
        'TxtTieu_Chuan_TD
        '
        Me.TxtTieu_Chuan_TD.Location = New System.Drawing.Point(99, 204)
        Me.TxtTieu_Chuan_TD.Name = "TxtTieu_Chuan_TD"
        Me.TxtTieu_Chuan_TD.Size = New System.Drawing.Size(536, 115)
        Me.TxtTieu_Chuan_TD.TabIndex = 5
        Me.TxtTieu_Chuan_TD.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 45)
        Me.Label2.TabIndex = 418
        Me.Label2.Tag = "Working status"
        Me.Label2.Text = "Tiêu chuẩn tuyển dụng"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 45)
        Me.Label3.TabIndex = 420
        Me.Label3.Tag = "Working status"
        Me.Label3.Text = "Mô tả Công việc"
        '
        'TxtMo_Ta_CV
        '
        Me.TxtMo_Ta_CV.Location = New System.Drawing.Point(99, 324)
        Me.TxtMo_Ta_CV.Name = "TxtMo_Ta_CV"
        Me.TxtMo_Ta_CV.Size = New System.Drawing.Size(536, 115)
        Me.TxtMo_Ta_CV.TabIndex = 6
        Me.TxtMo_Ta_CV.Text = ""
        '
        'DmChucDanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 488)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMo_Ta_CV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTieu_Chuan_TD)
        Me.Controls.Add(Me.ChkIs_Dv_Admin)
        Me.Controls.Add(Me.ChkIs_DV_Dieu_phoi)
        Me.Controls.Add(Me.ChkIs_DV_KTV_SDS)
        Me.Controls.Add(Me.ChkIs_DV_KTV_SCC)
        Me.Controls.Add(Me.ChkIs_DV_CVDV)
        Me.Controls.Add(Me.ChkIs_Kd_Admin)
        Me.Controls.Add(Me.ChkIs_KD_TP)
        Me.Controls.Add(Me.ChkIs_KD_TVBH)
        Me.Controls.Add(Me.CmbCap)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_ChucDanh)
        Me.Controls.Add(Me.TxtMa_ChucDanh)
        Me.Controls.Add(Me.TxtTen_ChucDanh2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Name = "DmChucDanh"
        Me.Text = "Danh mục hiệu lực vụ việc"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChucDanh2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ChucDanh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChucDanh, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.CmbCap, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_KD_TVBH, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_KD_TP, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Kd_Admin, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_DV_CVDV, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_DV_KTV_SCC, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_DV_KTV_SDS, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_DV_Dieu_phoi, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Dv_Admin, 0)
        Me.Controls.SetChildIndex(Me.TxtTieu_Chuan_TD, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMo_Ta_CV, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ChucDanh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_ChucDanh As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_ChucDanh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtTen_BP As Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As SmLists.TxtLookup
    Friend WithEvents CmbCap As Windows.Forms.ComboBox
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents ChkIs_Dv_Admin As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_DV_Dieu_phoi As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_DV_KTV_SDS As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_DV_KTV_SCC As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_DV_CVDV As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Kd_Admin As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_KD_TP As Windows.Forms.CheckBox
    Friend WithEvents ChkIs_KD_TVBH As Windows.Forms.CheckBox
    Friend WithEvents TxtTieu_Chuan_TD As Windows.Forms.RichTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtMo_Ta_CV As Windows.Forms.RichTextBox
End Class
