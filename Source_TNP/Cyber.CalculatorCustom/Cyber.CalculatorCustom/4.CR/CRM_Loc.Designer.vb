<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRM_Loc
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate()
        Me.CmbMa_Loai = New System.Windows.Forms.ComboBox()
        Me.LabMa_Loai = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.CmbMa_Ngay = New System.Windows.Forms.ComboBox()
        Me.LabMa_Ngay = New System.Windows.Forms.Label()
        Me.CmbTT_CS = New System.Windows.Forms.ComboBox()
        Me.LabTT_CS = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_ChienDich = New System.Windows.Forms.TextBox()
        Me.TxtMa_ChienDich = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 151)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(570, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(370, 161)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 7
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(472, 161)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 519
        Me.Label3.Tag = "Color"
        Me.Label3.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(206, 114)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Mau.TabIndex = 518
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
        Me.TxtMa_Mau.Location = New System.Drawing.Point(92, 110)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Mau.TabIndex = 5
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 517
        Me.Label4.Tag = "type car"
        Me.Label4.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(206, 91)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Kx.TabIndex = 516
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(92, 89)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kx.TabIndex = 4
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 523
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct2.Flags = 65536
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(92, 25)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "18/09/2011"
        Me.TxtNgay_Ct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct2.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 522
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Ngày nghiệm thu"
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct1.Flags = 65536
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(92, 4)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "18/09/2011"
        Me.TxtNgay_Ct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'CmbMa_Loai
        '
        Me.CmbMa_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Loai.FormattingEnabled = True
        Me.CmbMa_Loai.Location = New System.Drawing.Point(305, 26)
        Me.CmbMa_Loai.Name = "CmbMa_Loai"
        Me.CmbMa_Loai.Size = New System.Drawing.Size(267, 21)
        Me.CmbMa_Loai.TabIndex = 524
        '
        'LabMa_Loai
        '
        Me.LabMa_Loai.AutoSize = True
        Me.LabMa_Loai.Location = New System.Drawing.Point(223, 29)
        Me.LabMa_Loai.Name = "LabMa_Loai"
        Me.LabMa_Loai.Size = New System.Drawing.Size(72, 13)
        Me.LabMa_Loai.TabIndex = 525
        Me.LabMa_Loai.Tag = "Type"
        Me.LabMa_Loai.Text = "Loại đánh giá"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(92, 46)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Xe.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(5, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 1847
        Me.Label7.Tag = "License plate"
        Me.Label7.Text = "Biển số"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 1850
        Me.Label6.Tag = "Staff"
        Me.Label6.Text = "CVDV (TVBH)"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(206, 70)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Hs.TabIndex = 1849
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(92, 68)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Hs.TabIndex = 3
        Me.TxtMa_Hs.Table_Name = ""
        '
        'CmbMa_Ngay
        '
        Me.CmbMa_Ngay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Ngay.FormattingEnabled = True
        Me.CmbMa_Ngay.Location = New System.Drawing.Point(305, 48)
        Me.CmbMa_Ngay.Name = "CmbMa_Ngay"
        Me.CmbMa_Ngay.Size = New System.Drawing.Size(267, 21)
        Me.CmbMa_Ngay.TabIndex = 1851
        '
        'LabMa_Ngay
        '
        Me.LabMa_Ngay.AutoSize = True
        Me.LabMa_Ngay.Location = New System.Drawing.Point(223, 51)
        Me.LabMa_Ngay.Name = "LabMa_Ngay"
        Me.LabMa_Ngay.Size = New System.Drawing.Size(43, 13)
        Me.LabMa_Ngay.TabIndex = 1852
        Me.LabMa_Ngay.Tag = "Date (D)"
        Me.LabMa_Ngay.Text = "Ngày D"
        '
        'CmbTT_CS
        '
        Me.CmbTT_CS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTT_CS.ForeColor = System.Drawing.Color.Navy
        Me.CmbTT_CS.FormattingEnabled = True
        Me.CmbTT_CS.Location = New System.Drawing.Point(305, 4)
        Me.CmbTT_CS.Name = "CmbTT_CS"
        Me.CmbTT_CS.Size = New System.Drawing.Size(267, 21)
        Me.CmbTT_CS.TabIndex = 1853
        '
        'LabTT_CS
        '
        Me.LabTT_CS.AutoSize = True
        Me.LabTT_CS.Location = New System.Drawing.Point(223, 7)
        Me.LabTT_CS.Name = "LabTT_CS"
        Me.LabTT_CS.Size = New System.Drawing.Size(77, 13)
        Me.LabTT_CS.TabIndex = 1854
        Me.LabTT_CS.Tag = "Type"
        Me.LabTT_CS.Text = "Tình trạng C/S"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 1857
        Me.Label5.Tag = "Color"
        Me.Label5.Text = "Chiến dịch"
        '
        'TxtTen_ChienDich
        '
        Me.TxtTen_ChienDich.BackColor = System.Drawing.Color.White
        Me.TxtTen_ChienDich.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_ChienDich.Enabled = False
        Me.TxtTen_ChienDich.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChienDich.Location = New System.Drawing.Point(206, 135)
        Me.TxtTen_ChienDich.Name = "TxtTen_ChienDich"
        Me.TxtTen_ChienDich.ReadOnly = True
        Me.TxtTen_ChienDich.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_ChienDich.TabIndex = 1856
        Me.TxtTen_ChienDich.TabStop = False
        '
        'TxtMa_ChienDich
        '
        Me.TxtMa_ChienDich._ActilookupPopup = False
        Me.TxtMa_ChienDich.CyberActilookupPopup = True
        Me.TxtMa_ChienDich.Dv_ListDetail = Nothing
        Me.TxtMa_ChienDich.Dv_Master = Nothing
        Me.TxtMa_ChienDich.FilterClient = ""
        Me.TxtMa_ChienDich.FilterSQL = ""
        Me.TxtMa_ChienDich.Location = New System.Drawing.Point(92, 131)
        Me.TxtMa_ChienDich.Name = "TxtMa_ChienDich"
        Me.TxtMa_ChienDich.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ChienDich.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ChienDich.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ChienDich.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_ChienDich.TabIndex = 6
        Me.TxtMa_ChienDich.Table_Name = ""
        '
        'CRM_Loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 215)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_ChienDich)
        Me.Controls.Add(Me.TxtMa_ChienDich)
        Me.Controls.Add(Me.CmbTT_CS)
        Me.Controls.Add(Me.LabTT_CS)
        Me.Controls.Add(Me.CmbMa_Ngay)
        Me.Controls.Add(Me.LabMa_Ngay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.CmbMa_Loai)
        Me.Controls.Add(Me.LabMa_Loai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CRM_Loc"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.LabTT_CS, 0)
        Me.Controls.SetChildIndex(Me.CmbTT_CS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate
    Friend WithEvents CmbMa_Loai As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Loai As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents CmbMa_Ngay As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Ngay As System.Windows.Forms.Label
    Friend WithEvents CmbTT_CS As System.Windows.Forms.ComboBox
    Friend WithEvents LabTT_CS As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ChienDich As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_ChienDich As Cyber.SmLists.TxtLookup

End Class
