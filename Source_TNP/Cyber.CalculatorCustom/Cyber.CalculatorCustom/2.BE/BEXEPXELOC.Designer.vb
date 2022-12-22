<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEXEPXELOC
    Inherits Cyber.From.FrmCalculator

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
        Me.CbbM_Nam1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_HD1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_HD1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_HD3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_HD3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh_HD2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_HD2 = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_HD = New System.Windows.Forms.TextBox()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.CbbM_Nam2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_HD1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_HD3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_HD2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 210)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(632, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(432, 220)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(534, 220)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 11
        '
        'CbbM_Nam1
        '
        Me.CbbM_Nam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam1.FormattingEnabled = True
        Me.CbbM_Nam1.Location = New System.Drawing.Point(259, 2)
        Me.CbbM_Nam1.Name = "CbbM_Nam1"
        Me.CbbM_Nam1.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Nam1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(84, 2)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(3, 7)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(50, 13)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(84, 26)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 507
        Me.Label1.Tag = "Month to"
        Me.Label1.Text = "Đến tháng"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 510
        Me.Label4.Tag = "Type car"
        Me.Label4.Text = "Kiểu xe"
        '
        'Txtten_Kx
        '
        Me.Txtten_Kx.BackColor = System.Drawing.Color.White
        Me.Txtten_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Kx.Enabled = False
        Me.Txtten_Kx.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Kx.Location = New System.Drawing.Point(200, 51)
        Me.Txtten_Kx.Name = "Txtten_Kx"
        Me.Txtten_Kx.ReadOnly = True
        Me.Txtten_Kx.Size = New System.Drawing.Size(370, 13)
        Me.Txtten_Kx.TabIndex = 509
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
        Me.TxtMa_Kx.Location = New System.Drawing.Point(84, 51)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kx.TabIndex = 3
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 513
        Me.Label3.Tag = "Color"
        Me.Label3.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(200, 73)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_Mau.TabIndex = 512
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
        Me.TxtMa_Mau.Location = New System.Drawing.Point(84, 73)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Mau.TabIndex = 4
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 532
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 531
        Me.Label6.Tag = "Group 1"
        Me.Label6.Text = "Nhóm 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 530
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Nhóm 2"
        '
        'TxtTen_Nh_HD1
        '
        Me.TxtTen_Nh_HD1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh_HD1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_HD1.Enabled = False
        Me.TxtTen_Nh_HD1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_HD1.Location = New System.Drawing.Point(200, 142)
        Me.TxtTen_Nh_HD1.Name = "TxtTen_Nh_HD1"
        Me.TxtTen_Nh_HD1.ReadOnly = True
        Me.TxtTen_Nh_HD1.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_Nh_HD1.TabIndex = 529
        Me.TxtTen_Nh_HD1.TabStop = False
        '
        'TxtNh_HD1
        '
        Me.TxtNh_HD1._ActilookupPopup = False
        Me.TxtNh_HD1.CyberActilookupPopup = True
        Me.TxtNh_HD1.Dv_ListDetail = Nothing
        Me.TxtNh_HD1.Dv_Master = Nothing
        Me.TxtNh_HD1.FilterClient = ""
        Me.TxtNh_HD1.FilterSQL = ""
        Me.TxtNh_HD1.Location = New System.Drawing.Point(84, 142)
        Me.TxtNh_HD1.Name = "TxtNh_HD1"
        Me.TxtNh_HD1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_HD1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_HD1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_HD1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNh_HD1.TabIndex = 7
        Me.TxtNh_HD1.Table_Name = ""
        '
        'TxtTen_Nh_HD3
        '
        Me.TxtTen_Nh_HD3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh_HD3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_HD3.Enabled = False
        Me.TxtTen_Nh_HD3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_HD3.Location = New System.Drawing.Point(200, 187)
        Me.TxtTen_Nh_HD3.Name = "TxtTen_Nh_HD3"
        Me.TxtTen_Nh_HD3.ReadOnly = True
        Me.TxtTen_Nh_HD3.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_Nh_HD3.TabIndex = 528
        Me.TxtTen_Nh_HD3.TabStop = False
        '
        'TxtNh_HD3
        '
        Me.TxtNh_HD3._ActilookupPopup = False
        Me.TxtNh_HD3.CyberActilookupPopup = True
        Me.TxtNh_HD3.Dv_ListDetail = Nothing
        Me.TxtNh_HD3.Dv_Master = Nothing
        Me.TxtNh_HD3.FilterClient = ""
        Me.TxtNh_HD3.FilterSQL = ""
        Me.TxtNh_HD3.Location = New System.Drawing.Point(84, 187)
        Me.TxtNh_HD3.Name = "TxtNh_HD3"
        Me.TxtNh_HD3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_HD3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_HD3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_HD3.Size = New System.Drawing.Size(110, 20)
        Me.TxtNh_HD3.TabIndex = 9
        Me.TxtNh_HD3.Table_Name = ""
        '
        'TxtTen_Nh_HD2
        '
        Me.TxtTen_Nh_HD2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh_HD2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_HD2.Enabled = False
        Me.TxtTen_Nh_HD2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_HD2.Location = New System.Drawing.Point(200, 165)
        Me.TxtTen_Nh_HD2.Name = "TxtTen_Nh_HD2"
        Me.TxtTen_Nh_HD2.ReadOnly = True
        Me.TxtTen_Nh_HD2.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_Nh_HD2.TabIndex = 527
        Me.TxtTen_Nh_HD2.TabStop = False
        '
        'TxtNh_HD2
        '
        Me.TxtNh_HD2._ActilookupPopup = False
        Me.TxtNh_HD2.CyberActilookupPopup = True
        Me.TxtNh_HD2.Dv_ListDetail = Nothing
        Me.TxtNh_HD2.Dv_Master = Nothing
        Me.TxtNh_HD2.FilterClient = ""
        Me.TxtNh_HD2.FilterSQL = ""
        Me.TxtNh_HD2.Location = New System.Drawing.Point(84, 165)
        Me.TxtNh_HD2.Name = "TxtNh_HD2"
        Me.TxtNh_HD2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_HD2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_HD2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_HD2.Size = New System.Drawing.Size(110, 20)
        Me.TxtNh_HD2.TabIndex = 8
        Me.TxtNh_HD2.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 535
        Me.Label7.Tag = "Contract"
        Me.Label7.Text = "Hợp đồng"
        '
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.Color.White
        Me.TxtTen_HD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HD.Enabled = False
        Me.TxtTen_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD.Location = New System.Drawing.Point(200, 119)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.ReadOnly = True
        Me.TxtTen_HD.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_HD.TabIndex = 534
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
        Me.TxtMa_HD.Location = New System.Drawing.Point(84, 119)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_HD.TabIndex = 6
        Me.TxtMa_HD.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 538
        Me.Label9.Tag = "Customer"
        Me.Label9.Text = "Khách hàng"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(200, 95)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(370, 13)
        Me.TxtTen_KH.TabIndex = 537
        Me.TxtTen_KH.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(84, 95)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kh.TabIndex = 5
        Me.TxtMa_Kh.Table_Name = ""
        '
        'CbbM_Nam2
        '
        Me.CbbM_Nam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam2.FormattingEnabled = True
        Me.CbbM_Nam2.Location = New System.Drawing.Point(259, 26)
        Me.CbbM_Nam2.Name = "CbbM_Nam2"
        Me.CbbM_Nam2.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Nam2.TabIndex = 539
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 540
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'BEXEPXELOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(636, 274)
        Me.Controls.Add(Me.CbbM_Nam2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nh_HD1)
        Me.Controls.Add(Me.TxtNh_HD1)
        Me.Controls.Add(Me.TxtTen_Nh_HD3)
        Me.Controls.Add(Me.TxtNh_HD3)
        Me.Controls.Add(Me.TxtTen_Nh_HD2)
        Me.Controls.Add(Me.TxtNh_HD2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbM_Nam1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BEXEPXELOC"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_HD2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_HD2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_HD3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_HD3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_HD1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_HD1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam2, 0)
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_HD1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_HD3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_HD2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh_HD1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_HD1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_HD3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_HD3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh_HD2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_HD2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HD As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents CbbM_Nam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
