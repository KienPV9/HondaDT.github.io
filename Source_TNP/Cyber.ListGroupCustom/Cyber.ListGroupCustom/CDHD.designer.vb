<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDHD
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
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtDu_Co_NT00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_NT00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co00 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_no00 = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.Txtten_DVCS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_NT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_TD3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TD3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTien_DaTT = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 328)
        Me.ButtExit.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 328)
        Me.ButtOK.TabIndex = 9
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(147, 27)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 338)
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 318)
        Me.GroupBoxLine.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(5, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 17)
        Me.Label10.TabIndex = 270
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(147, 2)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'TxtDu_Co_NT00
        '
        Me.TxtDu_Co_NT00.AllowNegative = True
        Me.TxtDu_Co_NT00.Flags = 7680
        Me.TxtDu_Co_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Location = New System.Drawing.Point(147, 267)
        Me.TxtDu_Co_NT00.MaxWholeDigits = 17
        Me.TxtDu_Co_NT00.Name = "TxtDu_Co_NT00"
        Me.TxtDu_Co_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co_NT00.TabIndex = 6
        Me.TxtDu_Co_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Text = "0.00"
        Me.TxtDu_Co_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_No_NT00
        '
        Me.TxtDu_No_NT00.AllowNegative = True
        Me.TxtDu_No_NT00.Flags = 7680
        Me.TxtDu_No_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Location = New System.Drawing.Point(147, 243)
        Me.TxtDu_No_NT00.MaxWholeDigits = 17
        Me.TxtDu_No_NT00.Name = "TxtDu_No_NT00"
        Me.TxtDu_No_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_NT00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_No_NT00.TabIndex = 5
        Me.TxtDu_No_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Text = "0.00"
        Me.TxtDu_No_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_Co00
        '
        Me.TxtDu_Co00.AllowNegative = True
        Me.TxtDu_Co00.Flags = 7680
        Me.TxtDu_Co00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co00.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co00.Location = New System.Drawing.Point(147, 220)
        Me.TxtDu_Co00.MaxWholeDigits = 14
        Me.TxtDu_Co00.Name = "TxtDu_Co00"
        Me.TxtDu_Co00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co00.TabIndex = 4
        Me.TxtDu_Co00.Text = "0"
        Me.TxtDu_Co00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDu_no00
        '
        Me.TxtDu_no00.AllowNegative = True
        Me.TxtDu_no00.Flags = 7680
        Me.TxtDu_no00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_no00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_no00.InputMask = "### ### ### ### ###"
        Me.TxtDu_no00.Location = New System.Drawing.Point(147, 197)
        Me.TxtDu_no00.MaxWholeDigits = 14
        Me.TxtDu_no00.Name = "TxtDu_no00"
        Me.TxtDu_no00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_no00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_no00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_no00.TabIndex = 3
        Me.TxtDu_no00.Text = "0"
        Me.TxtDu_no00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 265
        Me.Label4.Tag = "Open credit balance(FC)"
        Me.Label4.Text = "Dư có đầu kỳ (NT)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 264
        Me.Label2.Tag = "Open credit balance(VND)"
        Me.Label2.Text = "Dư có đầu kỳ (VNĐ)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Open debt balance(FC)"
        Me.Label3.Text = "Dư nợ đầu kỳ (NT)"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(290, 55)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_TK.TabIndex = 260
        Me.TxtTen_TK.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(5, 52)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(132, 17)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Account"
        Me.lbMa_Phi.Text = "Tài khoản"
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbTen_phi2.ForeColor = System.Drawing.Color.Navy
        Me.lbTen_phi2.Location = New System.Drawing.Point(5, 199)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(132, 17)
        Me.lbTen_phi2.TabIndex = 261
        Me.lbTen_phi2.Tag = "Open debt balance(VND)"
        Me.lbTen_phi2.Text = "Dư nợ đầu kỳ (VNĐ)"
        '
        'Txtten_DVCS
        '
        Me.Txtten_DVCS.BackColor = System.Drawing.Color.White
        Me.Txtten_DVCS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_DVCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtten_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_DVCS.Location = New System.Drawing.Point(290, 30)
        Me.Txtten_DVCS.Name = "Txtten_DVCS"
        Me.Txtten_DVCS.ReadOnly = True
        Me.Txtten_DVCS.Size = New System.Drawing.Size(488, 14)
        Me.Txtten_DVCS.TabIndex = 271
        Me.Txtten_DVCS.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(5, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 17)
        Me.Label11.TabIndex = 272
        Me.Label11.Tag = "Acc unit"
        Me.Label11.Text = "Đơn vị hạch toán"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 9)
        Me.GroupBox1.TabIndex = 273
        Me.GroupBox1.TabStop = False
        '
        'TxtTK
        '
        Me.TxtTK._ActilookupPopup = False
        Me.TxtTK.CyberActilookupPopup = True
        Me.TxtTK.Dv_ListDetail = Nothing
        Me.TxtTK.Dv_Master = Nothing
        Me.TxtTK.FilterClient = ""
        Me.TxtTK.FilterSQL = ""
        Me.TxtTK.Location = New System.Drawing.Point(147, 52)
        Me.TxtTK.Name = "TxtTK"
        Me.TxtTK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK.Size = New System.Drawing.Size(135, 20)
        Me.TxtTK.TabIndex = 0
        Me.TxtTK.Table_Name = ""
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT._ActilookupPopup = False
        Me.TxtMa_NT.CyberActilookupPopup = True
        Me.TxtMa_NT.Dv_ListDetail = Nothing
        Me.TxtMa_NT.Dv_Master = Nothing
        Me.TxtMa_NT.FilterClient = ""
        Me.TxtMa_NT.FilterSQL = ""
        Me.TxtMa_NT.Location = New System.Drawing.Point(147, 75)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_NT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NT.Properties.ReadOnly = True
        Me.TxtMa_NT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NT.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_NT.TabIndex = 1
        Me.TxtMa_NT.Table_Name = ""
        '
        'TxtTen_NT
        '
        Me.TxtTen_NT.BackColor = System.Drawing.Color.White
        Me.TxtTen_NT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NT.Location = New System.Drawing.Point(290, 78)
        Me.TxtTen_NT.Name = "TxtTen_NT"
        Me.TxtTen_NT.ReadOnly = True
        Me.TxtTen_NT.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_NT.TabIndex = 276
        Me.TxtTen_NT.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 17)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Currency"
        Me.Label8.Text = "Ngoại tệ"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = ""
        Me.TxtMa_HD.FilterSQL = ""
        Me.TxtMa_HD.Location = New System.Drawing.Point(147, 99)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_HD.TabIndex = 2
        Me.TxtMa_HD.Table_Name = ""
        '
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.Color.White
        Me.TxtTen_HD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD.Location = New System.Drawing.Point(290, 102)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.ReadOnly = True
        Me.TxtTen_HD.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_HD.TabIndex = 279
        Me.TxtTen_HD.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(5, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 280
        Me.Label9.Tag = "Contract"
        Me.Label9.Text = "Hợp đồng"
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(147, 122)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_Kh.TabIndex = 281
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(290, 125)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_Kh.TabIndex = 282
        Me.TxtTen_Kh.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 283
        Me.Label1.Tag = "Customer"
        Me.Label1.Text = "Khách hàng"
        '
        'TxtMa_TD3
        '
        Me.TxtMa_TD3._ActilookupPopup = False
        Me.TxtMa_TD3.CyberActilookupPopup = True
        Me.TxtMa_TD3.Dv_ListDetail = Nothing
        Me.TxtMa_TD3.Dv_Master = Nothing
        Me.TxtMa_TD3.FilterClient = ""
        Me.TxtMa_TD3.FilterSQL = ""
        Me.TxtMa_TD3.Location = New System.Drawing.Point(148, 144)
        Me.TxtMa_TD3.Name = "TxtMa_TD3"
        Me.TxtMa_TD3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TD3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TD3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TD3.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_TD3.TabIndex = 284
        Me.TxtMa_TD3.Table_Name = ""
        '
        'TxtTen_TD3
        '
        Me.TxtTen_TD3.BackColor = System.Drawing.Color.White
        Me.TxtTen_TD3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TD3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_TD3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TD3.Location = New System.Drawing.Point(291, 147)
        Me.TxtTen_TD3.Name = "TxtTen_TD3"
        Me.TxtTen_TD3.ReadOnly = True
        Me.TxtTen_TD3.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_TD3.TabIndex = 285
        Me.TxtTen_TD3.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 286
        Me.Label5.Tag = "Free 3"
        Me.Label5.Text = "Mã tự do 3"
        '
        'TxtTien_DaTT
        '
        Me.TxtTien_DaTT.AllowNegative = True
        Me.TxtTien_DaTT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTien_DaTT.Flags = 7680
        Me.TxtTien_DaTT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_DaTT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_DaTT.InputMask = "### ### ### ### ###"
        Me.TxtTien_DaTT.Location = New System.Drawing.Point(147, 291)
        Me.TxtTien_DaTT.MaxWholeDigits = 14
        Me.TxtTien_DaTT.Name = "TxtTien_DaTT"
        Me.TxtTien_DaTT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_DaTT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_DaTT.Size = New System.Drawing.Size(135, 21)
        Me.TxtTien_DaTT.TabIndex = 7
        Me.TxtTien_DaTT.Tag = "### ### ### ### ###.##"
        Me.TxtTien_DaTT.Text = "0"
        Me.TxtTien_DaTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(5, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 21)
        Me.Label6.TabIndex = 288
        Me.Label6.Tag = "Open credit balance(FC)"
        Me.Label6.Text = "Tiền KH đã thanh toán"
        '
        'CDHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.TxtTien_DaTT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMa_TD3)
        Me.Controls.Add(Me.TxtTen_TD3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTen_NT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtDu_Co_NT00)
        Me.Controls.Add(Me.TxtDu_No_NT00)
        Me.Controls.Add(Me.TxtDu_Co00)
        Me.Controls.Add(Me.TxtDu_no00)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.KeyPreview = True
        Me.Name = "CDHD"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_no00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TD3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TD3, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_DaTT, 0)
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TD3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtDu_Co_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_no00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label
    Friend WithEvents Txtten_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_NT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HD As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_TD3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TD3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_DaTT As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
