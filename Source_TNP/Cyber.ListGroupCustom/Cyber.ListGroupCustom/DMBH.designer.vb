<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMBH
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
        Me.LabMa_BH = New System.Windows.Forms.Label()
        Me.TxtMa_BH = New System.Windows.Forms.TextBox()
        Me.TxtTen_Bh = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh = New System.Windows.Forms.Label()
        Me.TxtTen_Bh2 = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Bh1 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Bh2 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Bh3 = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Bh4 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Bh5 = New Cyber.SmLists.TxtLookup()
        Me.TxtTL_MG = New ClsTextBox.txtTien_NT()
        Me.LabPt_Hh_Tv = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbMa_Muc = New System.Windows.Forms.ComboBox()
        Me.ChbIs_LienKet = New System.Windows.Forms.CheckBox()
        Me.TxtMST = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtNh_Bh1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Bh2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Bh3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Bh4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Bh5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 296)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 296)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 302)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 306)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 286)
        Me.GroupBoxLine.TabIndex = 8
        '
        'LabMa_BH
        '
        Me.LabMa_BH.Location = New System.Drawing.Point(5, 115)
        Me.LabMa_BH.Name = "LabMa_BH"
        Me.LabMa_BH.Size = New System.Drawing.Size(107, 15)
        Me.LabMa_BH.TabIndex = 10
        Me.LabMa_BH.Tag = "Code"
        Me.LabMa_BH.Text = "Mã bảo hiểm"
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Location = New System.Drawing.Point(110, 114)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_BH.TabIndex = 5
        '
        'TxtTen_Bh
        '
        Me.TxtTen_Bh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bh.Location = New System.Drawing.Point(110, 137)
        Me.TxtTen_Bh.Name = "TxtTen_Bh"
        Me.TxtTen_Bh.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Bh.TabIndex = 6
        '
        'LabTen_Bh
        '
        Me.LabTen_Bh.Location = New System.Drawing.Point(5, 139)
        Me.LabTen_Bh.Name = "LabTen_Bh"
        Me.LabTen_Bh.Size = New System.Drawing.Size(107, 15)
        Me.LabTen_Bh.TabIndex = 12
        Me.LabTen_Bh.Tag = "Name"
        Me.LabTen_Bh.Text = "Tên bảo hiểm"
        '
        'TxtTen_Bh2
        '
        Me.TxtTen_Bh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bh2.Location = New System.Drawing.Point(110, 160)
        Me.TxtTen_Bh2.Name = "TxtTen_Bh2"
        Me.TxtTen_Bh2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Bh2.TabIndex = 7
        '
        'LabTen_Bh2
        '
        Me.LabTen_Bh2.Location = New System.Drawing.Point(5, 161)
        Me.LabTen_Bh2.Name = "LabTen_Bh2"
        Me.LabTen_Bh2.Size = New System.Drawing.Size(107, 15)
        Me.LabTen_Bh2.TabIndex = 14
        Me.LabTen_Bh2.Tag = "English name"
        Me.LabTen_Bh2.Text = "Địa chỉ"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(5, 4)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(99, 16)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(263, 6)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh1.TabIndex = 23
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_Bh1
        '
        Me.TxtNh_Bh1._ActilookupPopup = False
        Me.TxtNh_Bh1.CyberActilookupPopup = True
        Me.TxtNh_Bh1.Dv_ListDetail = Nothing
        Me.TxtNh_Bh1.Dv_Master = Nothing
        Me.TxtNh_Bh1.FilterClient = ""
        Me.TxtNh_Bh1.FilterSQL = ""
        Me.TxtNh_Bh1.Location = New System.Drawing.Point(110, 4)
        Me.TxtNh_Bh1.Name = "TxtNh_Bh1"
        Me.TxtNh_Bh1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Bh1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Bh1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Bh1.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_Bh1.TabIndex = 0
        Me.TxtNh_Bh1.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Nhóm 2"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(263, 28)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh2.TabIndex = 26
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_Bh2
        '
        Me.TxtNh_Bh2._ActilookupPopup = False
        Me.TxtNh_Bh2.CyberActilookupPopup = True
        Me.TxtNh_Bh2.Dv_ListDetail = Nothing
        Me.TxtNh_Bh2.Dv_Master = Nothing
        Me.TxtNh_Bh2.FilterClient = ""
        Me.TxtNh_Bh2.FilterSQL = ""
        Me.TxtNh_Bh2.Location = New System.Drawing.Point(110, 26)
        Me.TxtNh_Bh2.Name = "TxtNh_Bh2"
        Me.TxtNh_Bh2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Bh2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Bh2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Bh2.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_Bh2.TabIndex = 1
        Me.TxtNh_Bh2.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(263, 50)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh3.TabIndex = 29
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_Bh3
        '
        Me.TxtNh_Bh3._ActilookupPopup = False
        Me.TxtNh_Bh3.CyberActilookupPopup = True
        Me.TxtNh_Bh3.Dv_ListDetail = Nothing
        Me.TxtNh_Bh3.Dv_Master = Nothing
        Me.TxtNh_Bh3.FilterClient = ""
        Me.TxtNh_Bh3.FilterSQL = ""
        Me.TxtNh_Bh3.Location = New System.Drawing.Point(110, 48)
        Me.TxtNh_Bh3.Name = "TxtNh_Bh3"
        Me.TxtNh_Bh3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Bh3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Bh3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Bh3.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_Bh3.TabIndex = 2
        Me.TxtNh_Bh3.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Tag = "Group 4"
        Me.Label3.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(263, 72)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh4.TabIndex = 32
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_Bh4
        '
        Me.TxtNh_Bh4._ActilookupPopup = False
        Me.TxtNh_Bh4.CyberActilookupPopup = True
        Me.TxtNh_Bh4.Dv_ListDetail = Nothing
        Me.TxtNh_Bh4.Dv_Master = Nothing
        Me.TxtNh_Bh4.FilterClient = ""
        Me.TxtNh_Bh4.FilterSQL = ""
        Me.TxtNh_Bh4.Location = New System.Drawing.Point(110, 70)
        Me.TxtNh_Bh4.Name = "TxtNh_Bh4"
        Me.TxtNh_Bh4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Bh4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Bh4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Bh4.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_Bh4.TabIndex = 3
        Me.TxtNh_Bh4.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Tag = "Group 5"
        Me.Label4.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(263, 94)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh5.TabIndex = 35
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_Bh5
        '
        Me.TxtNh_Bh5._ActilookupPopup = False
        Me.TxtNh_Bh5.CyberActilookupPopup = True
        Me.TxtNh_Bh5.Dv_ListDetail = Nothing
        Me.TxtNh_Bh5.Dv_Master = Nothing
        Me.TxtNh_Bh5.FilterClient = ""
        Me.TxtNh_Bh5.FilterSQL = ""
        Me.TxtNh_Bh5.Location = New System.Drawing.Point(110, 92)
        Me.TxtNh_Bh5.Name = "TxtNh_Bh5"
        Me.TxtNh_Bh5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Bh5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Bh5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Bh5.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_Bh5.TabIndex = 4
        Me.TxtNh_Bh5.Table_Name = ""
        '
        'TxtTL_MG
        '
        Me.TxtTL_MG.AllowNegative = True
        Me.TxtTL_MG.Flags = 7680
        Me.TxtTL_MG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTL_MG.ForeColor = System.Drawing.Color.Navy
        Me.TxtTL_MG.InputMask = "### ### ### ### ###"
        Me.TxtTL_MG.Location = New System.Drawing.Point(110, 206)
        Me.TxtTL_MG.MaxWholeDigits = 14
        Me.TxtTL_MG.Name = "TxtTL_MG"
        Me.TxtTL_MG.RangeMax = 1.7976931348623157E+308R
        Me.TxtTL_MG.RangeMin = -1.7976931348623157E+308R
        Me.TxtTL_MG.Size = New System.Drawing.Size(149, 21)
        Me.TxtTL_MG.TabIndex = 9
        Me.TxtTL_MG.Text = "0"
        Me.TxtTL_MG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabPt_Hh_Tv
        '
        Me.LabPt_Hh_Tv.Location = New System.Drawing.Point(5, 210)
        Me.LabPt_Hh_Tv.Name = "LabPt_Hh_Tv"
        Me.LabPt_Hh_Tv.Size = New System.Drawing.Size(107, 15)
        Me.LabPt_Hh_Tv.TabIndex = 443
        Me.LabPt_Hh_Tv.Tag = "" & Global.Microsoft.VisualBasic.ChrW(13) & "Percent 1"
        Me.LabPt_Hh_Tv.Text = "Tỷ lệ môi giới "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 444
        Me.Label5.Tag = "Leave"
        Me.Label5.Text = "Mức ưu tiên"
        '
        'CmbMa_Muc
        '
        Me.CmbMa_Muc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Muc.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Muc.FormattingEnabled = True
        Me.CmbMa_Muc.Location = New System.Drawing.Point(110, 233)
        Me.CmbMa_Muc.Name = "CmbMa_Muc"
        Me.CmbMa_Muc.Size = New System.Drawing.Size(149, 21)
        Me.CmbMa_Muc.TabIndex = 10
        '
        'ChbIs_LienKet
        '
        Me.ChbIs_LienKet.AutoSize = True
        Me.ChbIs_LienKet.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChbIs_LienKet.ForeColor = System.Drawing.Color.Navy
        Me.ChbIs_LienKet.Location = New System.Drawing.Point(110, 260)
        Me.ChbIs_LienKet.Name = "ChbIs_LienKet"
        Me.ChbIs_LienKet.Size = New System.Drawing.Size(152, 17)
        Me.ChbIs_LienKet.TabIndex = 11
        Me.ChbIs_LienKet.Tag = "Customer"
        Me.ChbIs_LienKet.Text = "Là đơn vị bảo hiểm liên kết"
        '
        'TxtMST
        '
        Me.TxtMST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMST.ForeColor = System.Drawing.Color.Navy
        Me.TxtMST.Location = New System.Drawing.Point(110, 184)
        Me.TxtMST.Name = "TxtMST"
        Me.TxtMST.Size = New System.Drawing.Size(149, 21)
        Me.TxtMST.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 447
        Me.Label6.Tag = "Code"
        Me.Label6.Text = "Mã số thuế"
        '
        'DMBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 329)
        Me.Controls.Add(Me.TxtMST)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChbIs_LienKet)
        Me.Controls.Add(Me.CmbMa_Muc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTL_MG)
        Me.Controls.Add(Me.LabPt_Hh_Tv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_Bh5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_Bh4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_Bh3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_Bh2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_Bh1)
        Me.Controls.Add(Me.TxtTen_Bh2)
        Me.Controls.Add(Me.LabTen_Bh2)
        Me.Controls.Add(Me.TxtTen_Bh)
        Me.Controls.Add(Me.LabTen_Bh)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_BH)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMBH"
        Me.Text = "Danh mục bảo hiểm"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bh, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bh2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Bh1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Bh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Bh3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Bh4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Bh5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabPt_Hh_Tv, 0)
        Me.Controls.SetChildIndex(Me.TxtTL_MG, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Muc, 0)
        Me.Controls.SetChildIndex(Me.ChbIs_LienKet, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMST, 0)
        CType(Me.TxtNh_Bh1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Bh2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Bh3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Bh4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Bh5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_BH As System.Windows.Forms.Label
    Friend WithEvents TxtMa_BH As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Bh As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Bh2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Bh1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Bh2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Bh3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Bh4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Bh5 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTL_MG As ClsTextBox.txtTien_NT
    Friend WithEvents LabPt_Hh_Tv As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_Muc As System.Windows.Forms.ComboBox
    Friend WithEvents ChbIs_LienKet As Windows.Forms.CheckBox
    Friend WithEvents TxtMST As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
