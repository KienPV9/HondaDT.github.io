<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDX_Vay
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
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TxtNgay_Gui_Bank = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_TBCV = New ClsTextBox.txtDate()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TxtTien_Vay = New ClsTextBox.txtTien_NT()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TxtNgay_GN = New ClsTextBox.txtDate()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_Chi = New ClsTextBox.txtDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTien_GN = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTien_TVBH = New ClsTextBox.txtTien_NT()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTien_TNBH = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTien_TPBH = New ClsTextBox.txtTien_NT()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTien_HoTro = New ClsTextBox.txtTien_NT()
        Me.CmbMa_Nh = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 201)
        Me.GroupBoxLine.Size = New System.Drawing.Size(631, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(431, 211)
        Me.ButtOK.TabIndex = 12
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(533, 211)
        Me.ButtExit.TabIndex = 13
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(234, 211)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(31, 21)
        Me.TxtStt_Rec.TabIndex = 1977
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Navy
        Me.Label78.Location = New System.Drawing.Point(-1, 43)
        Me.Label78.Margin = New System.Windows.Forms.Padding(0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(106, 18)
        Me.Label78.TabIndex = 2144
        Me.Label78.Tag = "Day"
        Me.Label78.Text = "Ngày gửi Bank"
        '
        'TxtNgay_Gui_Bank
        '
        Me.TxtNgay_Gui_Bank.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Gui_Bank.Flags = 65536
        Me.TxtNgay_Gui_Bank.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Gui_Bank.isEmpty = True
        Me.TxtNgay_Gui_Bank.Location = New System.Drawing.Point(112, 42)
        Me.TxtNgay_Gui_Bank.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Gui_Bank.MaxLength = 10
        Me.TxtNgay_Gui_Bank.Name = "TxtNgay_Gui_Bank"
        Me.TxtNgay_Gui_Bank.RangeMax = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Gui_Bank.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Gui_Bank.ShowDayBeforeMonth = False
        Me.TxtNgay_Gui_Bank.Size = New System.Drawing.Size(112, 20)
        Me.TxtNgay_Gui_Bank.TabIndex = 1
        Me.TxtNgay_Gui_Bank.Text = "__/__/____"
        Me.TxtNgay_Gui_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Gui_Bank.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(-1, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 2146
        Me.Label1.Tag = "Day"
        Me.Label1.Text = "Ngày TBCV"
        '
        'TxtNgay_TBCV
        '
        Me.TxtNgay_TBCV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_TBCV.Flags = 65536
        Me.TxtNgay_TBCV.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_TBCV.isEmpty = True
        Me.TxtNgay_TBCV.Location = New System.Drawing.Point(112, 65)
        Me.TxtNgay_TBCV.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_TBCV.MaxLength = 10
        Me.TxtNgay_TBCV.Name = "TxtNgay_TBCV"
        Me.TxtNgay_TBCV.RangeMax = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_TBCV.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_TBCV.ShowDayBeforeMonth = False
        Me.TxtNgay_TBCV.Size = New System.Drawing.Size(112, 20)
        Me.TxtNgay_TBCV.TabIndex = 2
        Me.TxtNgay_TBCV.Text = "__/__/____"
        Me.TxtNgay_TBCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_TBCV.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(-1, 91)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(51, 15)
        Me.Label60.TabIndex = 2148
        Me.Label60.Tag = "Invoice rate"
        Me.Label60.Text = "Tiền vay"
        '
        'TxtTien_Vay
        '
        Me.TxtTien_Vay.AllowNegative = True
        Me.TxtTien_Vay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTien_Vay.Flags = 7680
        Me.TxtTien_Vay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Vay.InputMask = "### ### ### ###"
        Me.TxtTien_Vay.Location = New System.Drawing.Point(112, 88)
        Me.TxtTien_Vay.MaxWholeDigits = 11
        Me.TxtTien_Vay.Name = "TxtTien_Vay"
        Me.TxtTien_Vay.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Vay.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Vay.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_Vay.TabIndex = 3
        Me.TxtTien_Vay.Text = "0"
        Me.TxtTien_Vay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Navy
        Me.Label71.Location = New System.Drawing.Point(-1, 113)
        Me.Label71.Margin = New System.Windows.Forms.Padding(0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(89, 15)
        Me.Label71.TabIndex = 2150
        Me.Label71.Tag = "Issued date"
        Me.Label71.Text = "Ngày giải ngân"
        '
        'TxtNgay_GN
        '
        Me.TxtNgay_GN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_GN.Flags = 65536
        Me.TxtNgay_GN.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_GN.isEmpty = True
        Me.TxtNgay_GN.Location = New System.Drawing.Point(112, 111)
        Me.TxtNgay_GN.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_GN.MaxLength = 10
        Me.TxtNgay_GN.Name = "TxtNgay_GN"
        Me.TxtNgay_GN.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_GN.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_GN.ShowDayBeforeMonth = False
        Me.TxtNgay_GN.Size = New System.Drawing.Size(112, 20)
        Me.TxtNgay_GN.TabIndex = 4
        Me.TxtNgay_GN.Text = "__/__/____"
        Me.TxtNgay_GN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_GN.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(402, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 2152
        Me.Label2.Tag = "Issued date"
        Me.Label2.Text = "Ngày bank chi HH"
        '
        'TxtNgay_Chi
        '
        Me.TxtNgay_Chi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Chi.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Chi.Enabled = False
        Me.TxtNgay_Chi.Flags = 65536
        Me.TxtNgay_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Chi.isEmpty = True
        Me.TxtNgay_Chi.Location = New System.Drawing.Point(511, 41)
        Me.TxtNgay_Chi.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Chi.MaxLength = 10
        Me.TxtNgay_Chi.Name = "TxtNgay_Chi"
        Me.TxtNgay_Chi.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Chi.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Chi.ReadOnly = True
        Me.TxtNgay_Chi.ShowDayBeforeMonth = False
        Me.TxtNgay_Chi.Size = New System.Drawing.Size(112, 20)
        Me.TxtNgay_Chi.TabIndex = 6
        Me.TxtNgay_Chi.Text = "__/__/____"
        Me.TxtNgay_Chi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Chi.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(-1, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 2154
        Me.Label3.Tag = "Invoice rate"
        Me.Label3.Text = "Tiền giải ngân"
        '
        'TxtTien_GN
        '
        Me.TxtTien_GN.AllowNegative = True
        Me.TxtTien_GN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTien_GN.Flags = 7680
        Me.TxtTien_GN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_GN.InputMask = "### ### ### ###"
        Me.TxtTien_GN.Location = New System.Drawing.Point(112, 134)
        Me.TxtTien_GN.MaxWholeDigits = 11
        Me.TxtTien_GN.Name = "TxtTien_GN"
        Me.TxtTien_GN.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_GN.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_GN.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_GN.TabIndex = 5
        Me.TxtTien_GN.Text = "0"
        Me.TxtTien_GN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(402, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 2156
        Me.Label4.Tag = "Invoice rate"
        Me.Label4.Text = "Tiền TVBH"
        '
        'TxtTien_TVBH
        '
        Me.TxtTien_TVBH.AllowNegative = True
        Me.TxtTien_TVBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_TVBH.BackColor = System.Drawing.Color.White
        Me.TxtTien_TVBH.Enabled = False
        Me.TxtTien_TVBH.Flags = 7680
        Me.TxtTien_TVBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_TVBH.InputMask = "### ###"
        Me.TxtTien_TVBH.Location = New System.Drawing.Point(511, 65)
        Me.TxtTien_TVBH.MaxWholeDigits = 5
        Me.TxtTien_TVBH.Name = "TxtTien_TVBH"
        Me.TxtTien_TVBH.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_TVBH.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_TVBH.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_TVBH.TabIndex = 7
        Me.TxtTien_TVBH.Text = "0"
        Me.TxtTien_TVBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(402, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 2158
        Me.Label5.Tag = "Invoice rate"
        Me.Label5.Text = "Tiền TN TVBH"
        '
        'TxtTien_TNBH
        '
        Me.TxtTien_TNBH.AllowNegative = True
        Me.TxtTien_TNBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_TNBH.BackColor = System.Drawing.Color.White
        Me.TxtTien_TNBH.Enabled = False
        Me.TxtTien_TNBH.Flags = 7680
        Me.TxtTien_TNBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_TNBH.InputMask = "### ###"
        Me.TxtTien_TNBH.Location = New System.Drawing.Point(511, 88)
        Me.TxtTien_TNBH.MaxWholeDigits = 5
        Me.TxtTien_TNBH.Name = "TxtTien_TNBH"
        Me.TxtTien_TNBH.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_TNBH.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_TNBH.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_TNBH.TabIndex = 8
        Me.TxtTien_TNBH.Text = "0"
        Me.TxtTien_TNBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(402, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 2160
        Me.Label6.Tag = "Invoice rate"
        Me.Label6.Text = "Tiền TP TVBH"
        '
        'TxtTien_TPBH
        '
        Me.TxtTien_TPBH.AllowNegative = True
        Me.TxtTien_TPBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_TPBH.BackColor = System.Drawing.Color.White
        Me.TxtTien_TPBH.Enabled = False
        Me.TxtTien_TPBH.Flags = 7680
        Me.TxtTien_TPBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_TPBH.InputMask = "### ###"
        Me.TxtTien_TPBH.Location = New System.Drawing.Point(511, 109)
        Me.TxtTien_TPBH.MaxWholeDigits = 5
        Me.TxtTien_TPBH.Name = "TxtTien_TPBH"
        Me.TxtTien_TPBH.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_TPBH.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_TPBH.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_TPBH.TabIndex = 9
        Me.TxtTien_TPBH.Text = "0"
        Me.TxtTien_TPBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(402, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 2162
        Me.Label7.Tag = "Invoice rate"
        Me.Label7.Text = "Tiền NV hỗ trợ"
        '
        'TxtTien_HoTro
        '
        Me.TxtTien_HoTro.AllowNegative = True
        Me.TxtTien_HoTro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_HoTro.BackColor = System.Drawing.Color.White
        Me.TxtTien_HoTro.Enabled = False
        Me.TxtTien_HoTro.Flags = 7680
        Me.TxtTien_HoTro.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_HoTro.InputMask = "### ###"
        Me.TxtTien_HoTro.Location = New System.Drawing.Point(511, 131)
        Me.TxtTien_HoTro.MaxWholeDigits = 5
        Me.TxtTien_HoTro.Name = "TxtTien_HoTro"
        Me.TxtTien_HoTro.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_HoTro.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_HoTro.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_HoTro.TabIndex = 10
        Me.TxtTien_HoTro.Text = "0"
        Me.TxtTien_HoTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbMa_Nh
        '
        Me.CmbMa_Nh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Nh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_Nh.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Nh.FormattingEnabled = True
        Me.CmbMa_Nh.Location = New System.Drawing.Point(112, 16)
        Me.CmbMa_Nh.Name = "CmbMa_Nh"
        Me.CmbMa_Nh.Size = New System.Drawing.Size(511, 23)
        Me.CmbMa_Nh.TabIndex = 0
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Navy
        Me.Label73.Location = New System.Drawing.Point(-1, 20)
        Me.Label73.Margin = New System.Windows.Forms.Padding(0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(72, 15)
        Me.Label73.TabIndex = 2164
        Me.Label73.Tag = "Bank"
        Me.Label73.Text = "NH Trả Góp"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(112, 157)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(511, 20)
        Me.TxtDien_Giai.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(-1, 160)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 15)
        Me.Label16.TabIndex = 2166
        Me.Label16.Tag = "Note"
        Me.Label16.Text = "Ghi chú"
        '
        'HDX_Vay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(635, 265)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmbMa_Nh)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTien_HoTro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTien_TPBH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTien_TNBH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTien_TVBH)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTien_GN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNgay_Chi)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.TxtNgay_GN)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.TxtTien_Vay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_TBCV)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.TxtNgay_Gui_Bank)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HDX_Vay"
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Gui_Bank, 0)
        Me.Controls.SetChildIndex(Me.Label78, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_TBCV, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Vay, 0)
        Me.Controls.SetChildIndex(Me.Label60, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_GN, 0)
        Me.Controls.SetChildIndex(Me.Label71, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Chi, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_GN, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_TVBH, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_TNBH, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_TPBH, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_HoTro, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label73, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Nh, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStt_Rec As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents TxtNgay_Gui_Bank As ClsTextBox.txtDate
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNgay_TBCV As ClsTextBox.txtDate
    Friend WithEvents Label60 As Label
    Friend WithEvents TxtTien_Vay As ClsTextBox.txtTien_NT
    Friend WithEvents Label71 As Label
    Friend WithEvents TxtNgay_GN As ClsTextBox.txtDate
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNgay_Chi As ClsTextBox.txtDate
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTien_GN As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTien_TVBH As ClsTextBox.txtTien_NT
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTien_TNBH As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTien_TPBH As ClsTextBox.txtTien_NT
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTien_HoTro As ClsTextBox.txtTien_NT
    Friend WithEvents CmbMa_Nh As ComboBox
    Friend WithEvents Label73 As Label
    Friend WithEvents TxtDien_Giai As TextBox
    Friend WithEvents Label16 As Label
End Class
