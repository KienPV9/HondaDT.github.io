<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLocLDN
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
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblMa_kh = New System.Windows.Forms.Label()
        Me.CmdLoc_Ro = New System.Windows.Forms.Button()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtT_CL_PB = New ClsTextBox.txtTien_NT()
        Me.TxtT_Da_Pb = New ClsTextBox.txtTien_NT()
        Me.TxtT_Thue = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_Hang = New ClsTextBox.txtTien_NT()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblTong_Cong = New System.Windows.Forms.Label()
        Me.TxtT_Tong_Cong = New ClsTextBox.txtTien_NT()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.ChkGia_Cong = New System.Windows.Forms.CheckBox()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.LabBao_Hiem = New System.Windows.Forms.Label()
        Me.TxtTen_LHBH = New System.Windows.Forms.TextBox()
        Me.TxtMa_LHBH = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Hd = New System.Windows.Forms.TextBox()
        Me.cmdthang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbNam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 466)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1109, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(905, 480)
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1011, 480)
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(238, 29)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(97, 22)
        Me.TxtMa_KH.TabIndex = 3
        Me.TxtMa_KH.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 382
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 381
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct2.Flags = 65536
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(65, 30)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(81, 20)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "18/09/2011"
        Me.TxtNgay_Ct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct2.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct1.Flags = 65536
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(65, 5)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(81, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "18/09/2011"
        Me.TxtNgay_Ct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'GridView6
        '
        Me.GridView6.Name = "GridView6"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'lblMa_kh
        '
        Me.lblMa_kh.AutoSize = True
        Me.lblMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_kh.Location = New System.Drawing.Point(164, 33)
        Me.lblMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_kh.Name = "lblMa_kh"
        Me.lblMa_kh.Size = New System.Drawing.Size(53, 13)
        Me.lblMa_kh.TabIndex = 380
        Me.lblMa_kh.Tag = "Customer"
        Me.lblMa_kh.Text = "Đối tượng"
        '
        'CmdLoc_Ro
        '
        Me.CmdLoc_Ro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdLoc_Ro.ForeColor = System.Drawing.Color.Navy
        Me.CmdLoc_Ro.Location = New System.Drawing.Point(984, 78)
        Me.CmdLoc_Ro.Name = "CmdLoc_Ro"
        Me.CmdLoc_Ro.Size = New System.Drawing.Size(117, 24)
        Me.CmdLoc_Ro.TabIndex = 7
        Me.CmdLoc_Ro.TabStop = False
        Me.CmdLoc_Ro.Tag = "Acce&ptance"
        Me.CmdLoc_Ro.Text = "&Lọc Phiếu"
        Me.CmdLoc_Ro.UseVisualStyleBackColor = True
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(345, 31)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(253, 20)
        Me.TxtTen_KH.TabIndex = 377
        Me.TxtTen_KH.Tag = ""
        '
        'GridView7
        '
        Me.GridView7.Name = "GridView7"
        '
        'GridView8
        '
        Me.GridView8.Name = "GridView8"
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(1, 106)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1110, 361)
        Me.Master.TabIndex = 8
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'TxtT_CL_PB
        '
        Me.TxtT_CL_PB.AllowNegative = True
        Me.TxtT_CL_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_CL_PB.BackColor = System.Drawing.Color.White
        Me.TxtT_CL_PB.Flags = 7680
        Me.TxtT_CL_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_CL_PB.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_CL_PB.InputMask = "### ### ### ### ### ###"
        Me.TxtT_CL_PB.Location = New System.Drawing.Point(666, 490)
        Me.TxtT_CL_PB.MaxWholeDigits = 17
        Me.TxtT_CL_PB.Name = "TxtT_CL_PB"
        Me.TxtT_CL_PB.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CL_PB.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CL_PB.ReadOnly = True
        Me.TxtT_CL_PB.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_CL_PB.TabIndex = 2082
        Me.TxtT_CL_PB.TabStop = False
        Me.TxtT_CL_PB.Text = "0"
        Me.TxtT_CL_PB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_CL_PB.Visible = False
        '
        'TxtT_Da_Pb
        '
        Me.TxtT_Da_Pb.AllowNegative = True
        Me.TxtT_Da_Pb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Da_Pb.BackColor = System.Drawing.Color.White
        Me.TxtT_Da_Pb.Flags = 7680
        Me.TxtT_Da_Pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Da_Pb.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_Da_Pb.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Da_Pb.Location = New System.Drawing.Point(540, 490)
        Me.TxtT_Da_Pb.MaxWholeDigits = 17
        Me.TxtT_Da_Pb.Name = "TxtT_Da_Pb"
        Me.TxtT_Da_Pb.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Da_Pb.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Da_Pb.ReadOnly = True
        Me.TxtT_Da_Pb.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Da_Pb.TabIndex = 2081
        Me.TxtT_Da_Pb.TabStop = False
        Me.TxtT_Da_Pb.Text = "0"
        Me.TxtT_Da_Pb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Da_Pb.Visible = False
        '
        'TxtT_Thue
        '
        Me.TxtT_Thue.AllowNegative = True
        Me.TxtT_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Thue.BackColor = System.Drawing.Color.White
        Me.TxtT_Thue.Flags = 7680
        Me.TxtT_Thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Thue.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_Thue.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Thue.Location = New System.Drawing.Point(286, 490)
        Me.TxtT_Thue.MaxWholeDigits = 17
        Me.TxtT_Thue.Name = "TxtT_Thue"
        Me.TxtT_Thue.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Thue.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Thue.ReadOnly = True
        Me.TxtT_Thue.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Thue.TabIndex = 2079
        Me.TxtT_Thue.TabStop = False
        Me.TxtT_Thue.Text = "0"
        Me.TxtT_Thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Thue.Visible = False
        '
        'TxtT_Tien_Hang
        '
        Me.TxtT_Tien_Hang.AllowNegative = True
        Me.TxtT_Tien_Hang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_Hang.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_Hang.Flags = 7680
        Me.TxtT_Tien_Hang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tien_Hang.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_Tien_Hang.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Tien_Hang.Location = New System.Drawing.Point(154, 490)
        Me.TxtT_Tien_Hang.MaxWholeDigits = 17
        Me.TxtT_Tien_Hang.Name = "TxtT_Tien_Hang"
        Me.TxtT_Tien_Hang.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_Hang.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_Hang.ReadOnly = True
        Me.TxtT_Tien_Hang.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Tien_Hang.TabIndex = 2080
        Me.TxtT_Tien_Hang.TabStop = False
        Me.TxtT_Tien_Hang.Text = "0"
        Me.TxtT_Tien_Hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_Hang.Visible = False
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(689, 475)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 2078
        Me.Label29.Tag = "Costs total"
        Me.Label29.Text = "Còn lại phân bổ"
        Me.Label29.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(554, 475)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 13)
        Me.Label28.TabIndex = 2077
        Me.Label28.Tag = "Parts tax"
        Me.Label28.Text = "Đã phân bổ"
        Me.Label28.Visible = False
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(426, 475)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 13)
        Me.Label27.TabIndex = 2076
        Me.Label27.Tag = "Parts cash"
        Me.Label27.Text = "Tổng cộng"
        Me.Label27.Visible = False
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(305, 475)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 2075
        Me.Label26.Tag = "Payment tax"
        Me.Label26.Text = "Thuế "
        Me.Label26.Visible = False
        '
        'LblTong_Cong
        '
        Me.LblTong_Cong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTong_Cong.AutoSize = True
        Me.LblTong_Cong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTong_Cong.ForeColor = System.Drawing.Color.Blue
        Me.LblTong_Cong.Location = New System.Drawing.Point(181, 475)
        Me.LblTong_Cong.Name = "LblTong_Cong"
        Me.LblTong_Cong.Size = New System.Drawing.Size(55, 13)
        Me.LblTong_Cong.TabIndex = 2074
        Me.LblTong_Cong.Tag = "Payment cash"
        Me.LblTong_Cong.Text = "Tiền hàng"
        Me.LblTong_Cong.Visible = False
        '
        'TxtT_Tong_Cong
        '
        Me.TxtT_Tong_Cong.AllowNegative = True
        Me.TxtT_Tong_Cong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tong_Cong.BackColor = System.Drawing.Color.White
        Me.TxtT_Tong_Cong.Flags = 7680
        Me.TxtT_Tong_Cong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tong_Cong.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_Tong_Cong.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Tong_Cong.Location = New System.Drawing.Point(412, 490)
        Me.TxtT_Tong_Cong.MaxWholeDigits = 17
        Me.TxtT_Tong_Cong.Name = "TxtT_Tong_Cong"
        Me.TxtT_Tong_Cong.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tong_Cong.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tong_Cong.ReadOnly = True
        Me.TxtT_Tong_Cong.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Tong_Cong.TabIndex = 2083
        Me.TxtT_Tong_Cong.TabStop = False
        Me.TxtT_Tong_Cong.Text = "0"
        Me.TxtT_Tong_Cong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tong_Cong.Visible = False
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Enabled = False
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(238, 2)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(234, 23)
        Me.CbbMa_GD.TabIndex = 2
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(165, 6)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(71, 15)
        Me.lblLoai_ct.TabIndex = 2085
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'ChkGia_Cong
        '
        Me.ChkGia_Cong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkGia_Cong.AutoSize = True
        Me.ChkGia_Cong.Enabled = False
        Me.ChkGia_Cong.Location = New System.Drawing.Point(65, 57)
        Me.ChkGia_Cong.Name = "ChkGia_Cong"
        Me.ChkGia_Cong.Size = New System.Drawing.Size(69, 17)
        Me.ChkGia_Cong.TabIndex = 6
        Me.ChkGia_Cong.TabStop = False
        Me.ChkGia_Cong.Tag = "Total tax"
        Me.ChkGia_Cong.Text = "Gia công"
        Me.ChkGia_Cong.UseVisualStyleBackColor = True
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(345, 55)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(253, 20)
        Me.TxtTen_BH.TabIndex = 2208
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(238, 55)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_BH.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(97, 20)
        Me.TxtMa_BH.TabIndex = 4
        Me.TxtMa_BH.Table_Name = ""
        '
        'LabBao_Hiem
        '
        Me.LabBao_Hiem.BackColor = System.Drawing.Color.Transparent
        Me.LabBao_Hiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabBao_Hiem.ForeColor = System.Drawing.Color.Navy
        Me.LabBao_Hiem.Location = New System.Drawing.Point(164, 58)
        Me.LabBao_Hiem.Margin = New System.Windows.Forms.Padding(0)
        Me.LabBao_Hiem.Name = "LabBao_Hiem"
        Me.LabBao_Hiem.Size = New System.Drawing.Size(89, 14)
        Me.LabBao_Hiem.TabIndex = 2207
        Me.LabBao_Hiem.Tag = "Cus code"
        Me.LabBao_Hiem.Text = "Bảo hiểm"
        '
        'TxtTen_LHBH
        '
        Me.TxtTen_LHBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_LHBH.BackColor = System.Drawing.Color.White
        Me.TxtTen_LHBH.Enabled = False
        Me.TxtTen_LHBH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_LHBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LHBH.Location = New System.Drawing.Point(816, 55)
        Me.TxtTen_LHBH.Name = "TxtTen_LHBH"
        Me.TxtTen_LHBH.ReadOnly = True
        Me.TxtTen_LHBH.Size = New System.Drawing.Size(285, 20)
        Me.TxtTen_LHBH.TabIndex = 2214
        Me.TxtTen_LHBH.TabStop = False
        '
        'TxtMa_LHBH
        '
        Me.TxtMa_LHBH._ActilookupPopup = False
        Me.TxtMa_LHBH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_LHBH.CyberActilookupPopup = True
        Me.TxtMa_LHBH.Dv_ListDetail = Nothing
        Me.TxtMa_LHBH.Dv_Master = Nothing
        Me.TxtMa_LHBH.FilterClient = ""
        Me.TxtMa_LHBH.FilterSQL = ""
        Me.TxtMa_LHBH.Location = New System.Drawing.Point(709, 55)
        Me.TxtMa_LHBH.Name = "TxtMa_LHBH"
        Me.TxtMa_LHBH.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_LHBH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LHBH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_LHBH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_LHBH.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_LHBH.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_LHBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_LHBH.Size = New System.Drawing.Size(97, 20)
        Me.TxtMa_LHBH.TabIndex = 5
        Me.TxtMa_LHBH.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(601, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 2213
        Me.Label4.Tag = "Cus code"
        Me.Label4.Text = "Loại hình bảo hiểm"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = ""
        Me.TxtMa_HD.FilterSQL = ""
        Me.TxtMa_HD.Location = New System.Drawing.Point(238, 81)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(97, 22)
        Me.TxtMa_HD.TabIndex = 2215
        Me.TxtMa_HD.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(164, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2217
        Me.Label3.Tag = "Customer"
        Me.Label3.Text = "Hợp đồng"
        '
        'TxtTen_Hd
        '
        Me.TxtTen_Hd.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hd.Enabled = False
        Me.TxtTen_Hd.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hd.Location = New System.Drawing.Point(345, 83)
        Me.TxtTen_Hd.Name = "TxtTen_Hd"
        Me.TxtTen_Hd.ReadOnly = True
        Me.TxtTen_Hd.Size = New System.Drawing.Size(253, 20)
        Me.TxtTen_Hd.TabIndex = 2216
        Me.TxtTen_Hd.Tag = ""
        '
        'cmdthang
        '
        Me.cmdthang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdthang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmdthang.ForeColor = System.Drawing.Color.Navy
        Me.cmdthang.FormattingEnabled = True
        Me.cmdthang.Location = New System.Drawing.Point(65, 76)
        Me.cmdthang.Name = "cmdthang"
        Me.cmdthang.Size = New System.Drawing.Size(81, 21)
        Me.cmdthang.TabIndex = 2219
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(11, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 2221
        Me.Label5.Tag = "Voucher date"
        Me.Label5.Text = "Tháng"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbNam
        '
        Me.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmbNam.ForeColor = System.Drawing.Color.Navy
        Me.cmbNam.FormattingEnabled = True
        Me.cmbNam.Location = New System.Drawing.Point(65, 53)
        Me.cmbNam.Name = "cmbNam"
        Me.cmbNam.Size = New System.Drawing.Size(81, 21)
        Me.cmbNam.TabIndex = 2218
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(14, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 2220
        Me.Label6.Tag = "Voucher date"
        Me.Label6.Text = "Năm"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmLocLDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1113, 534)
        Me.Controls.Add(Me.cmdthang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbNam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Hd)
        Me.Controls.Add(Me.TxtTen_LHBH)
        Me.Controls.Add(Me.TxtMa_LHBH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabBao_Hiem)
        Me.Controls.Add(Me.ChkGia_Cong)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.TxtT_CL_PB)
        Me.Controls.Add(Me.TxtT_Da_Pb)
        Me.Controls.Add(Me.TxtT_Thue)
        Me.Controls.Add(Me.TxtT_Tien_Hang)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.LblTong_Cong)
        Me.Controls.Add(Me.TxtT_Tong_Cong)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.lblMa_kh)
        Me.Controls.Add(Me.CmdLoc_Ro)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Name = "FrmLocLDN"
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.CmdLoc_Ro, 0)
        Me.Controls.SetChildIndex(Me.lblMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tong_Cong, 0)
        Me.Controls.SetChildIndex(Me.LblTong_Cong, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_Hang, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Thue, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Da_Pb, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CL_PB, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.ChkGia_Cong, 0)
        Me.Controls.SetChildIndex(Me.LabBao_Hiem, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LHBH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LHBH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hd, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.cmbNam, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.cmdthang, 0)
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblMa_kh As System.Windows.Forms.Label
    Friend WithEvents CmdLoc_Ro As System.Windows.Forms.Button
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_CL_PB As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Da_Pb As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Thue As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_Hang As ClsTextBox.txtTien_NT
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblTong_Cong As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tong_Cong As ClsTextBox.txtTien_NT
    Friend WithEvents CbbMa_GD As ComboBox
    Friend WithEvents lblLoai_ct As Label
    Friend WithEvents ChkGia_Cong As CheckBox
    Friend WithEvents TxtTen_BH As TextBox
    Friend WithEvents TxtMa_BH As SmLists.TxtLookup
    Friend WithEvents LabBao_Hiem As Label
    Friend WithEvents TxtTen_LHBH As TextBox
    Friend WithEvents TxtMa_LHBH As SmLists.TxtLookup
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMa_HD As SmLists.TxtLookup
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_Hd As TextBox
    Friend WithEvents cmdthang As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbNam As ComboBox
    Friend WithEvents Label6 As Label
End Class
