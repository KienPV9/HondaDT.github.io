<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserName_DnDongTK
    Inherits Cyber.From.FrmCalculator

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
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.CbbMa_Post = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_DN = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS_DN = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtUser_Name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTen_Bp = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.CbbMa_Dvcs = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMa_HS = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCreatedDate = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_Ct = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        CType(Me.TxtMa_HS_DN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 169)
        Me.GroupBoxLine.Size = New System.Drawing.Size(937, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(737, 179)
        Me.ButtOK.TabIndex = 10
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(839, 179)
        Me.ButtExit.TabIndex = 11
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.Location = New System.Drawing.Point(68, 179)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(100, 20)
        Me.TxtStt_Rec.TabIndex = 45
        Me.TxtStt_Rec.Visible = False
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post.FormattingEnabled = True
        Me.CbbMa_Post.Location = New System.Drawing.Point(592, 27)
        Me.CbbMa_Post.Name = "CbbMa_Post"
        Me.CbbMa_Post.Size = New System.Drawing.Size(347, 23)
        Me.CbbMa_Post.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(495, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 2197
        Me.Label9.Tag = "Company"
        Me.Label9.Text = "Mức xử lý"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(495, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 2195
        Me.Label8.Tag = "Suplies"
        Me.Label8.Text = "Ghi chú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(2, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2194
        Me.Label2.Tag = "Suplies"
        Me.Label2.Text = "Email"
        '
        'TxtTen_Hs_DN
        '
        Me.TxtTen_Hs_DN.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_DN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs_DN.Enabled = False
        Me.TxtTen_Hs_DN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_DN.Location = New System.Drawing.Point(727, 56)
        Me.TxtTen_Hs_DN.Name = "TxtTen_Hs_DN"
        Me.TxtTen_Hs_DN.ReadOnly = True
        Me.TxtTen_Hs_DN.Size = New System.Drawing.Size(208, 13)
        Me.TxtTen_Hs_DN.TabIndex = 2182
        Me.TxtTen_Hs_DN.TabStop = False
        '
        'TxtMa_HS_DN
        '
        Me.TxtMa_HS_DN._ActilookupPopup = False
        Me.TxtMa_HS_DN.CyberActilookupPopup = True
        Me.TxtMa_HS_DN.Dv_ListDetail = Nothing
        Me.TxtMa_HS_DN.Dv_Master = Nothing
        Me.TxtMa_HS_DN.FilterClient = ""
        Me.TxtMa_HS_DN.FilterSQL = ""
        Me.TxtMa_HS_DN.Location = New System.Drawing.Point(592, 53)
        Me.TxtMa_HS_DN.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_HS_DN.Name = "TxtMa_HS_DN"
        Me.TxtMa_HS_DN.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_HS_DN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_HS_DN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_DN.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_HS_DN.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_DN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_DN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_DN.Size = New System.Drawing.Size(128, 22)
        Me.TxtMa_HS_DN.TabIndex = 7
        Me.TxtMa_HS_DN.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(495, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 2193
        Me.Label7.Tag = "Suplies"
        Me.Label7.Text = "Người đề nghị"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.ForeColor = System.Drawing.Color.Navy
        Me.txtPassword.Location = New System.Drawing.Point(99, 123)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(343, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(2, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 2192
        Me.Label6.Tag = "Request"
        Me.Label6.Text = "Mật khẩu đề xuất"
        '
        'TxtUser_Name
        '
        Me.TxtUser_Name.BackColor = System.Drawing.Color.White
        Me.TxtUser_Name.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser_Name.Location = New System.Drawing.Point(99, 101)
        Me.TxtUser_Name.Name = "TxtUser_Name"
        Me.TxtUser_Name.Size = New System.Drawing.Size(343, 20)
        Me.TxtUser_Name.TabIndex = 4
        Me.TxtUser_Name.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(2, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2191
        Me.Label5.Tag = "Request"
        Me.Label5.Text = "Tài khoản đề xuất"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(80, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 2189
        Me.Label3.Tag = "Request"
        Me.Label3.Text = "(*)"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.ForeColor = System.Drawing.Color.Navy
        Me.TxtEmail.Location = New System.Drawing.Point(99, 79)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(343, 20)
        Me.TxtEmail.TabIndex = 3
        Me.TxtEmail.Tag = ""
        '
        'TxtTen_Bp
        '
        Me.TxtTen_Bp.BackColor = System.Drawing.Color.White
        Me.TxtTen_Bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Bp.Enabled = False
        Me.TxtTen_Bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp.Location = New System.Drawing.Point(234, 58)
        Me.TxtTen_Bp.Name = "TxtTen_Bp"
        Me.TxtTen_Bp.ReadOnly = True
        Me.TxtTen_Bp.Size = New System.Drawing.Size(208, 13)
        Me.TxtTen_Bp.TabIndex = 2179
        Me.TxtTen_Bp.TabStop = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp._ActilookupPopup = False
        Me.TxtMa_Bp.CyberActilookupPopup = True
        Me.TxtMa_Bp.Dv_ListDetail = Nothing
        Me.TxtMa_Bp.Dv_Master = Nothing
        Me.TxtMa_Bp.FilterClient = ""
        Me.TxtMa_Bp.FilterSQL = ""
        Me.TxtMa_Bp.Location = New System.Drawing.Point(99, 53)
        Me.TxtMa_Bp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_Bp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp.Size = New System.Drawing.Size(128, 22)
        Me.TxtMa_Bp.TabIndex = 2
        Me.TxtMa_Bp.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(2, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 2188
        Me.Label1.Tag = "Suplies"
        Me.Label1.Text = "Mã bộ phận"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(234, 33)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(208, 13)
        Me.TxtTen_Hs.TabIndex = 2177
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(99, 28)
        Me.TxtMa_Hs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_Hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_Hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(128, 22)
        Me.TxtMa_Hs.TabIndex = 1
        Me.TxtMa_Hs.Table_Name = ""
        '
        'CbbMa_Dvcs
        '
        Me.CbbMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Dvcs.FormattingEnabled = True
        Me.CbbMa_Dvcs.Location = New System.Drawing.Point(99, 2)
        Me.CbbMa_Dvcs.Name = "CbbMa_Dvcs"
        Me.CbbMa_Dvcs.Size = New System.Drawing.Size(343, 23)
        Me.CbbMa_Dvcs.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(2, 6)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 15)
        Me.Label14.TabIndex = 2187
        Me.Label14.Tag = "Company"
        Me.Label14.Text = "Đơn vị"
        '
        'lblMa_HS
        '
        Me.lblMa_HS.AutoSize = True
        Me.lblMa_HS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMa_HS.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_HS.Location = New System.Drawing.Point(2, 32)
        Me.lblMa_HS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_HS.Name = "lblMa_HS"
        Me.lblMa_HS.Size = New System.Drawing.Size(81, 15)
        Me.lblMa_HS.TabIndex = 2186
        Me.lblMa_HS.Tag = "Suplies"
        Me.lblMa_HS.Text = "Mã nhân viên"
        '
        'txtDien_giai
        '
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(592, 76)
        Me.txtDien_giai.Multiline = True
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(343, 67)
        Me.txtDien_giai.TabIndex = 8
        Me.txtDien_giai.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(82, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 2190
        Me.Label4.Tag = "Request"
        Me.Label4.Text = "(*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(495, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 7156
        Me.Label10.Tag = "Date from"
        Me.Label10.Text = "Ngày lập"
        '
        'TxtCreatedDate
        '
        Me.TxtCreatedDate.Flags = 0
        Me.TxtCreatedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtCreatedDate.IsAllowResize = False
        Me.TxtCreatedDate.Location = New System.Drawing.Point(794, -1)
        Me.TxtCreatedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtCreatedDate.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtCreatedDate.MaxLength = 10
        Me.TxtCreatedDate.Name = "TxtCreatedDate"
        Me.TxtCreatedDate.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtCreatedDate.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtCreatedDate.ShowDayBeforeMonth = False
        Me.TxtCreatedDate.Size = New System.Drawing.Size(145, 26)
        Me.TxtCreatedDate.TabIndex = 7157
        Me.TxtCreatedDate.Value = "12/06/2020 14:13"
        Me.TxtCreatedDate.Visible = False
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Flags = 0
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNgay_Ct.IsAllowResize = False
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(592, -1)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(128, 26)
        Me.TxtNgay_Ct.TabIndex = 7158
        Me.TxtNgay_Ct.Value = "12/06/2020"
        '
        'FrmUserName_DnDongTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(941, 233)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.TxtCreatedDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbbMa_Post)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Hs_DN)
        Me.Controls.Add(Me.TxtMa_HS_DN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtUser_Name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTen_Bp)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.CbbMa_Dvcs)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblMa_HS)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Name = "FrmUserName_DnDongTK"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.lblMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtEmail, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_Name, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_DN, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_DN, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtCreatedDate, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        CType(Me.TxtMa_HS_DN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents CbbMa_Post As Windows.Forms.ComboBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_DN As Windows.Forms.TextBox
    Friend WithEvents TxtMa_HS_DN As SmLists.TxtLookup
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtPassword As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtUser_Name As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtEmail As Windows.Forms.TextBox
    Friend WithEvents TxtTen_Bp As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As SmLists.TxtLookup
    Friend WithEvents CbbMa_Dvcs As Windows.Forms.ComboBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents lblMa_HS As Windows.Forms.Label
    Friend WithEvents txtDien_giai As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtCreatedDate As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_Ct As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
End Class
