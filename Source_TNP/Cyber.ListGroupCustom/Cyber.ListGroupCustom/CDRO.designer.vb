<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDRO
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
        Me.TxtDu_Co_nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No_nt1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_Co1 = New ClsTextBox.txtTien_NT()
        Me.TxtDu_No1 = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSo_hd = New System.Windows.Forms.TextBox()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 186)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 186)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(147, 28)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 196)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 176)
        Me.GroupBoxLine.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 18)
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
        Me.TxtNam.Location = New System.Drawing.Point(147, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'TxtDu_Co_nt1
        '
        Me.TxtDu_Co_nt1.AllowNegative = True
        Me.TxtDu_Co_nt1.Flags = 7680
        Me.TxtDu_Co_nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co_nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_nt1.Location = New System.Drawing.Point(534, 294)
        Me.TxtDu_Co_nt1.MaxWholeDigits = 17
        Me.TxtDu_Co_nt1.Name = "TxtDu_Co_nt1"
        Me.TxtDu_Co_nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_nt1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_Co_nt1.TabIndex = 12
        Me.TxtDu_Co_nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_nt1.Text = "0.00"
        Me.TxtDu_Co_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_Co_nt1.Visible = False
        '
        'TxtDu_No_nt1
        '
        Me.TxtDu_No_nt1.AllowNegative = True
        Me.TxtDu_No_nt1.Flags = 7680
        Me.TxtDu_No_nt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_nt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No_nt1.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_nt1.Location = New System.Drawing.Point(534, 270)
        Me.TxtDu_No_nt1.MaxWholeDigits = 17
        Me.TxtDu_No_nt1.Name = "TxtDu_No_nt1"
        Me.TxtDu_No_nt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_nt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_nt1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_No_nt1.TabIndex = 11
        Me.TxtDu_No_nt1.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_nt1.Text = "0.00"
        Me.TxtDu_No_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_No_nt1.Visible = False
        '
        'TxtDu_Co1
        '
        Me.TxtDu_Co1.AllowNegative = True
        Me.TxtDu_Co1.Flags = 7680
        Me.TxtDu_Co1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_Co1.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co1.Location = New System.Drawing.Point(534, 249)
        Me.TxtDu_Co1.MaxWholeDigits = 14
        Me.TxtDu_Co1.Name = "TxtDu_Co1"
        Me.TxtDu_Co1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_Co1.TabIndex = 10
        Me.TxtDu_Co1.Text = "0"
        Me.TxtDu_Co1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_Co1.Visible = False
        '
        'TxtDu_No1
        '
        Me.TxtDu_No1.AllowNegative = True
        Me.TxtDu_No1.Flags = 7680
        Me.TxtDu_No1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No1.ForeColor = System.Drawing.Color.Blue
        Me.TxtDu_No1.InputMask = "### ### ### ### ###"
        Me.TxtDu_No1.Location = New System.Drawing.Point(534, 226)
        Me.TxtDu_No1.MaxWholeDigits = 14
        Me.TxtDu_No1.Name = "TxtDu_No1"
        Me.TxtDu_No1.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No1.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No1.Size = New System.Drawing.Size(146, 21)
        Me.TxtDu_No1.TabIndex = 9
        Me.TxtDu_No1.Text = "0"
        Me.TxtDu_No1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_No1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(377, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 269
        Me.Label1.Tag = "Y.starts credit balance(FC)"
        Me.Label1.Text = "Dư có đầu năm (NT)"
        Me.Label1.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(377, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 268
        Me.Label5.Tag = "Y.starts credit balance(VND)"
        Me.Label5.Text = "Dư có đầu năm  (VNĐ)"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(377, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 18)
        Me.Label6.TabIndex = 267
        Me.Label6.Tag = "Y.starts debt balance(FC)"
        Me.Label6.Text = "Dư nợ đầu năm (NT)"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(377, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 266
        Me.Label7.Tag = "Y.starts debt balance(VND)"
        Me.Label7.Text = "Dư nợ đầu năm (VNĐ)"
        Me.Label7.Visible = False
        '
        'TxtDu_Co_NT00
        '
        Me.TxtDu_Co_NT00.AllowNegative = True
        Me.TxtDu_Co_NT00.Flags = 7680
        Me.TxtDu_Co_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Location = New System.Drawing.Point(147, 238)
        Me.TxtDu_Co_NT00.MaxWholeDigits = 17
        Me.TxtDu_Co_NT00.Name = "TxtDu_Co_NT00"
        Me.TxtDu_Co_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co_NT00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co_NT00.TabIndex = 8
        Me.TxtDu_Co_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_Co_NT00.Text = "0.00"
        Me.TxtDu_Co_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_Co_NT00.Visible = False
        '
        'TxtDu_No_NT00
        '
        Me.TxtDu_No_NT00.AllowNegative = True
        Me.TxtDu_No_NT00.Flags = 7680
        Me.TxtDu_No_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Location = New System.Drawing.Point(147, 214)
        Me.TxtDu_No_NT00.MaxWholeDigits = 17
        Me.TxtDu_No_NT00.Name = "TxtDu_No_NT00"
        Me.TxtDu_No_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_NT00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_No_NT00.TabIndex = 7
        Me.TxtDu_No_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Text = "0.00"
        Me.TxtDu_No_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu_No_NT00.Visible = False
        '
        'TxtDu_Co00
        '
        Me.TxtDu_Co00.AllowNegative = True
        Me.TxtDu_Co00.Flags = 7680
        Me.TxtDu_Co00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_Co00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_Co00.InputMask = "### ### ### ### ###"
        Me.TxtDu_Co00.Location = New System.Drawing.Point(546, 147)
        Me.TxtDu_Co00.MaxWholeDigits = 14
        Me.TxtDu_Co00.Name = "TxtDu_Co00"
        Me.TxtDu_Co00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_Co00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_Co00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_Co00.TabIndex = 7
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
        Me.TxtDu_no00.Location = New System.Drawing.Point(147, 147)
        Me.TxtDu_no00.MaxWholeDigits = 14
        Me.TxtDu_no00.Name = "TxtDu_no00"
        Me.TxtDu_no00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_no00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_no00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_no00.TabIndex = 6
        Me.TxtDu_no00.Text = "0"
        Me.TxtDu_no00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 265
        Me.Label4.Tag = "Open credit balance(FC)"
        Me.Label4.Text = "Dư có đầu kỳ (NT)"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(404, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 264
        Me.Label2.Tag = "Open credit balance(VND)"
        Me.Label2.Text = "Dư có đầu kỳ (VNĐ)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Open debt balance(FC)"
        Me.Label3.Text = "Dư nợ đầu kỳ (NT)"
        Me.Label3.Visible = False
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
        Me.lbMa_Phi.Location = New System.Drawing.Point(5, 53)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(132, 18)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Account"
        Me.lbMa_Phi.Text = "Tài khoản"
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbTen_phi2.ForeColor = System.Drawing.Color.Navy
        Me.lbTen_phi2.Location = New System.Drawing.Point(5, 149)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(132, 18)
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
        Me.Txtten_DVCS.Location = New System.Drawing.Point(290, 31)
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
        Me.Label11.Location = New System.Drawing.Point(5, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 18)
        Me.Label11.TabIndex = 272
        Me.Label11.Tag = "Acc unit"
        Me.Label11.Text = "Đơn vị hạch toán"
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
        Me.TxtTK.TabIndex = 2
        Me.TxtTK.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(5, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(469, 22)
        Me.Label12.TabIndex = 11
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(147, 75)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_KH.TabIndex = 3
        Me.TxtMa_KH.Table_Name = ""
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(290, 78)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(488, 14)
        Me.TxtTen_KH.TabIndex = 279
        Me.TxtTen_KH.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(5, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 18)
        Me.Label9.TabIndex = 280
        Me.Label9.Tag = "Account"
        Me.Label9.Text = "Khách hàng"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(5, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 18)
        Me.Label13.TabIndex = 282
        Me.Label13.Tag = "Year"
        Me.Label13.Text = "Số R/O"
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.BackColor = System.Drawing.Color.White
        Me.TxtSo_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(147, 98)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_RO.TabIndex = 4
        Me.TxtSo_RO.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 284
        Me.Label8.Tag = "Year"
        Me.Label8.Text = "Số HĐ"
        '
        'TxtSo_hd
        '
        Me.TxtSo_hd.BackColor = System.Drawing.Color.White
        Me.TxtSo_hd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_hd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_hd.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_hd.Location = New System.Drawing.Point(147, 123)
        Me.TxtSo_hd.Name = "TxtSo_hd"
        Me.TxtSo_hd.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_hd.TabIndex = 5
        Me.TxtSo_hd.TabStop = False
        '
        'CDRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 219)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtSo_hd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtDu_Co_nt1)
        Me.Controls.Add(Me.TxtDu_No_nt1)
        Me.Controls.Add(Me.TxtDu_Co1)
        Me.Controls.Add(Me.TxtDu_No1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
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
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CDRO"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ RO"
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
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_nt1, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_Co_nt1, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_hd, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtDu_Co_nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No_nt1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_Co1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtDu_No1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_hd As System.Windows.Forms.TextBox

End Class
