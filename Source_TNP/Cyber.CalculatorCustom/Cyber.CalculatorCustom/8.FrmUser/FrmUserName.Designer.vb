<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserName
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserName))
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.CmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtNgay_ct2 = New ClsTextBox.txtDate1()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.CbbMa_Dvcs = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMa_HS = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Master_DNCapMK = New DevExpress.XtraGrid.GridControl()
        Me.Master_DNCapMKGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Master_DNCapTK = New DevExpress.XtraGrid.GridControl()
        Me.Master_DNCapTKGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabUserName = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Master_DNDongTK = New DevExpress.XtraGrid.GridControl()
        Me.Master_DNDongTKGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Master_DNCapMK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_DNCapMKGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Master_DNCapTK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_DNCapTKGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUserName.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Master_DNDongTK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_DNDongTKGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 435)
        Me.GroupBoxLine.Size = New System.Drawing.Size(960, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(760, 412)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(862, 412)
        Me.ButtExit.Visible = False
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager1
        Me.PopupMenu.Name = "PopupMenu"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(964, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 466)
        Me.barDockControlBottom.Size = New System.Drawing.Size(964, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 466)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(964, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 466)
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(239, 60)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(208, 13)
        Me.TxtTen_Hs.TabIndex = 7156
        Me.TxtTen_Hs.TabStop = False
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(453, 45)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(119, 32)
        Me.CmdSearch.TabIndex = 4
        Me.CmdSearch.Tag = "&Search"
        Me.CmdSearch.Text = "&Tìm kiếm"
        '
        'TxtNgay_ct2
        '
        Me.TxtNgay_ct2.Flags = 0
        Me.TxtNgay_ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ct2.IsAllowResize = False
        Me.TxtNgay_ct2.isEmpty = True
        Me.TxtNgay_ct2.Location = New System.Drawing.Point(319, 6)
        Me.TxtNgay_ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_ct2.MaxLength = 10
        Me.TxtNgay_ct2.Name = "TxtNgay_ct2"
        Me.TxtNgay_ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_ct2.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_ct2.TabIndex = 1
        Me.TxtNgay_ct2.Text = "__/__/____"
        Me.TxtNgay_ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(104, 6)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7155
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7154
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(104, 55)
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
        Me.TxtMa_Hs.TabIndex = 3
        Me.TxtMa_Hs.Table_Name = ""
        '
        'CbbMa_Dvcs
        '
        Me.CbbMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Dvcs.FormattingEnabled = True
        Me.CbbMa_Dvcs.Location = New System.Drawing.Point(104, 29)
        Me.CbbMa_Dvcs.Name = "CbbMa_Dvcs"
        Me.CbbMa_Dvcs.Size = New System.Drawing.Size(343, 23)
        Me.CbbMa_Dvcs.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(7, 33)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 15)
        Me.Label14.TabIndex = 7153
        Me.Label14.Tag = "Company"
        Me.Label14.Text = "Đơn vị"
        '
        'lblMa_HS
        '
        Me.lblMa_HS.AutoSize = True
        Me.lblMa_HS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMa_HS.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_HS.Location = New System.Drawing.Point(7, 59)
        Me.lblMa_HS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_HS.Name = "lblMa_HS"
        Me.lblMa_HS.Size = New System.Drawing.Size(81, 15)
        Me.lblMa_HS.TabIndex = 7152
        Me.lblMa_HS.Tag = "Suplies"
        Me.lblMa_HS.Text = "Mã nhân viên"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Master_DNCapMK)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(954, 331)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Danh sách ĐN cấp mật khẩu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Master_DNCapMK
        '
        Me.Master_DNCapMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_DNCapMK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_DNCapMK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNCapMK.Location = New System.Drawing.Point(3, 3)
        Me.Master_DNCapMK.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_DNCapMK.MainView = Me.Master_DNCapMKGRV
        Me.Master_DNCapMK.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_DNCapMK.Name = "Master_DNCapMK"
        Me.Master_DNCapMK.Size = New System.Drawing.Size(948, 325)
        Me.Master_DNCapMK.TabIndex = 447
        Me.Master_DNCapMK.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_DNCapMKGRV, Me.GridView3, Me.GridView4})
        '
        'Master_DNCapMKGRV
        '
        Me.Master_DNCapMKGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_DNCapMKGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_DNCapMKGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_DNCapMKGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_DNCapMKGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_DNCapMKGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_DNCapMKGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_DNCapMKGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_DNCapMKGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNCapMKGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_DNCapMKGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_DNCapMKGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_DNCapMKGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_DNCapMKGRV.GridControl = Me.Master_DNCapMK
        Me.Master_DNCapMKGRV.GroupRowHeight = 30
        Me.Master_DNCapMKGRV.Name = "Master_DNCapMKGRV"
        Me.Master_DNCapMKGRV.OptionsBehavior.Editable = False
        Me.Master_DNCapMKGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_DNCapMKGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_DNCapMKGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_DNCapMKGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_DNCapMKGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_DNCapMKGRV.OptionsView.ShowGroupPanel = False
        Me.Master_DNCapMKGRV.RowHeight = 22
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.Master_DNCapMK
        Me.GridView3.Name = "GridView3"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Master_DNCapMK
        Me.GridView4.Name = "GridView4"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Master_DNCapTK)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(954, 331)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh sách ĐN cấp tài khoản"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Master_DNCapTK
        '
        Me.Master_DNCapTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_DNCapTK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_DNCapTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNCapTK.Location = New System.Drawing.Point(3, 3)
        Me.Master_DNCapTK.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_DNCapTK.MainView = Me.Master_DNCapTKGRV
        Me.Master_DNCapTK.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_DNCapTK.Name = "Master_DNCapTK"
        Me.Master_DNCapTK.Size = New System.Drawing.Size(948, 325)
        Me.Master_DNCapTK.TabIndex = 446
        Me.Master_DNCapTK.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_DNCapTKGRV, Me.GridView8, Me.GridView7, Me.GridView1})
        '
        'Master_DNCapTKGRV
        '
        Me.Master_DNCapTKGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_DNCapTKGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_DNCapTKGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_DNCapTKGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_DNCapTKGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_DNCapTKGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_DNCapTKGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_DNCapTKGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_DNCapTKGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNCapTKGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_DNCapTKGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_DNCapTKGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_DNCapTKGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_DNCapTKGRV.GridControl = Me.Master_DNCapTK
        Me.Master_DNCapTKGRV.GroupRowHeight = 30
        Me.Master_DNCapTKGRV.Name = "Master_DNCapTKGRV"
        Me.Master_DNCapTKGRV.OptionsBehavior.Editable = False
        Me.Master_DNCapTKGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_DNCapTKGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_DNCapTKGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_DNCapTKGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_DNCapTKGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_DNCapTKGRV.OptionsView.ShowGroupPanel = False
        Me.Master_DNCapTKGRV.RowHeight = 22
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.Master_DNCapTK
        Me.GridView8.Name = "GridView8"
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.Master_DNCapTK
        Me.GridView7.Name = "GridView7"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Master_DNCapTK
        Me.GridView1.Name = "GridView1"
        '
        'TabUserName
        '
        Me.TabUserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabUserName.Controls.Add(Me.TabPage1)
        Me.TabUserName.Controls.Add(Me.TabPage2)
        Me.TabUserName.Controls.Add(Me.TabPage3)
        Me.TabUserName.Location = New System.Drawing.Point(2, 84)
        Me.TabUserName.Name = "TabUserName"
        Me.TabUserName.SelectedIndex = 0
        Me.TabUserName.Size = New System.Drawing.Size(962, 357)
        Me.TabUserName.TabIndex = 45
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Master_DNDongTK)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(954, 331)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Danh sách ĐN đóng tài khoản"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Master_DNDongTK
        '
        Me.Master_DNDongTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_DNDongTK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_DNDongTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNDongTK.Location = New System.Drawing.Point(3, 3)
        Me.Master_DNDongTK.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_DNDongTK.MainView = Me.Master_DNDongTKGRV
        Me.Master_DNDongTK.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_DNDongTK.Name = "Master_DNDongTK"
        Me.Master_DNDongTK.Size = New System.Drawing.Size(948, 325)
        Me.Master_DNDongTK.TabIndex = 448
        Me.Master_DNDongTK.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_DNDongTKGRV, Me.GridView5, Me.GridView6})
        '
        'Master_DNDongTKGRV
        '
        Me.Master_DNDongTKGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_DNDongTKGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_DNDongTKGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_DNDongTKGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_DNDongTKGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_DNDongTKGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_DNDongTKGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_DNDongTKGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_DNDongTKGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DNDongTKGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_DNDongTKGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_DNDongTKGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_DNDongTKGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_DNDongTKGRV.GridControl = Me.Master_DNDongTK
        Me.Master_DNDongTKGRV.GroupRowHeight = 30
        Me.Master_DNDongTKGRV.Name = "Master_DNDongTKGRV"
        Me.Master_DNDongTKGRV.OptionsBehavior.Editable = False
        Me.Master_DNDongTKGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_DNDongTKGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_DNDongTKGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_DNDongTKGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_DNDongTKGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_DNDongTKGRV.OptionsView.ShowGroupPanel = False
        Me.Master_DNDongTKGRV.RowHeight = 22
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.Master_DNDongTK
        Me.GridView5.Name = "GridView5"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.Master_DNDongTK
        Me.GridView6.Name = "GridView6"
        '
        'FrmUserName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(964, 466)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.TxtNgay_ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.CbbMa_Dvcs)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblMa_HS)
        Me.Controls.Add(Me.TabUserName)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmUserName"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TabUserName, 0)
        Me.Controls.SetChildIndex(Me.lblMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ct2, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Master_DNCapMK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_DNCapMKGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Master_DNCapTK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_DNCapTKGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUserName.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Master_DNDongTK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_DNDongTKGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TxtTen_Hs As Windows.Forms.TextBox
    Friend WithEvents CmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtNgay_ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_Hs As SmLists.TxtLookup
    Friend WithEvents CbbMa_Dvcs As Windows.Forms.ComboBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents lblMa_HS As Windows.Forms.Label
    Friend WithEvents TabUserName As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents Master_DNCapTK As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_DNCapTKGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Master_DNCapMK As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_DNCapMKGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents Master_DNDongTK As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_DNDongTKGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
