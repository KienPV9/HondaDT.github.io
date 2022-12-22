<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogfile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogfile))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MasterHisVoucher = New DevExpress.XtraGrid.GridControl()
        Me.MasterHisVoucherGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MasterHisLogin = New DevExpress.XtraGrid.GridControl()
        Me.MasterHisLoginGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MasterHisSmList = New DevExpress.XtraGrid.GridControl()
        Me.MasterHisSmListGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MasterHisReport = New DevExpress.XtraGrid.GridControl()
        Me.MasterHisReportGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        Me.TxtUser = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_Ct2 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MasterHisVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterHisVoucherGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.MasterHisLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterHisLoginGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.MasterHisSmList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterHisSmListGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.MasterHisReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterHisReportGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 497)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1186, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(976, 393)
        Me.ButtOK.TabIndex = 9
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseFont = True
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1078, 7)
        Me.ButtExit.TabIndex = 9
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MasterHisVoucher)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lịch sử thay đổi chứng từ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MasterHisVoucher
        '
        Me.MasterHisVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterHisVoucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterHisVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisVoucher.Location = New System.Drawing.Point(3, 3)
        Me.MasterHisVoucher.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterHisVoucher.MainView = Me.MasterHisVoucherGRV
        Me.MasterHisVoucher.Name = "MasterHisVoucher"
        Me.MasterHisVoucher.Size = New System.Drawing.Size(1016, 324)
        Me.MasterHisVoucher.TabIndex = 10
        Me.MasterHisVoucher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterHisVoucherGRV, Me.GridView3})
        '
        'MasterHisVoucherGRV
        '
        Me.MasterHisVoucherGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.MasterHisVoucherGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.MasterHisVoucherGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MasterHisVoucherGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.MasterHisVoucherGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterHisVoucherGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.MasterHisVoucherGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterHisVoucherGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterHisVoucherGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterHisVoucherGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MasterHisVoucherGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.MasterHisVoucherGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterHisVoucherGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisVoucherGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterHisVoucherGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterHisVoucherGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterHisVoucherGRV.GridControl = Me.MasterHisVoucher
        Me.MasterHisVoucherGRV.GroupRowHeight = 30
        Me.MasterHisVoucherGRV.Name = "MasterHisVoucherGRV"
        Me.MasterHisVoucherGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterHisVoucherGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterHisVoucherGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterHisVoucherGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterHisVoucherGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterHisVoucherGRV.OptionsView.ShowGroupPanel = False
        Me.MasterHisVoucherGRV.OptionsView.ShowViewCaption = True
        Me.MasterHisVoucherGRV.RowHeight = 21
        Me.MasterHisVoucherGRV.ViewCaption = " "
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.MasterHisVoucher
        Me.GridView3.Name = "GridView3"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MasterHisLogin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1184, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lịch sử đăng nhập"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MasterHisLogin
        '
        Me.MasterHisLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterHisLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterHisLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisLogin.Location = New System.Drawing.Point(3, 3)
        Me.MasterHisLogin.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterHisLogin.MainView = Me.MasterHisLoginGRV
        Me.MasterHisLogin.Name = "MasterHisLogin"
        Me.MasterHisLogin.Size = New System.Drawing.Size(1178, 417)
        Me.MasterHisLogin.TabIndex = 0
        Me.MasterHisLogin.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterHisLoginGRV, Me.GridView4})
        '
        'MasterHisLoginGRV
        '
        Me.MasterHisLoginGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.MasterHisLoginGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.MasterHisLoginGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MasterHisLoginGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.MasterHisLoginGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterHisLoginGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.MasterHisLoginGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterHisLoginGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterHisLoginGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterHisLoginGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MasterHisLoginGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.MasterHisLoginGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterHisLoginGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisLoginGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterHisLoginGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterHisLoginGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterHisLoginGRV.GridControl = Me.MasterHisLogin
        Me.MasterHisLoginGRV.GroupRowHeight = 30
        Me.MasterHisLoginGRV.Name = "MasterHisLoginGRV"
        Me.MasterHisLoginGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterHisLoginGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterHisLoginGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterHisLoginGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterHisLoginGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterHisLoginGRV.OptionsView.ShowGroupPanel = False
        Me.MasterHisLoginGRV.OptionsView.ShowViewCaption = True
        Me.MasterHisLoginGRV.RowHeight = 21
        Me.MasterHisLoginGRV.ViewCaption = " "
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.MasterHisLogin
        Me.GridView4.Name = "GridView4"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1192, 449)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MasterHisSmList)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1022, 330)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lịch sử thay đổi danh mục"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MasterHisSmList
        '
        Me.MasterHisSmList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterHisSmList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterHisSmList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisSmList.Location = New System.Drawing.Point(0, 0)
        Me.MasterHisSmList.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterHisSmList.MainView = Me.MasterHisSmListGRV
        Me.MasterHisSmList.Name = "MasterHisSmList"
        Me.MasterHisSmList.Size = New System.Drawing.Size(1022, 330)
        Me.MasterHisSmList.TabIndex = 11
        Me.MasterHisSmList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterHisSmListGRV, Me.GridView8})
        '
        'MasterHisSmListGRV
        '
        Me.MasterHisSmListGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.MasterHisSmListGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.MasterHisSmListGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MasterHisSmListGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.MasterHisSmListGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterHisSmListGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.MasterHisSmListGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterHisSmListGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterHisSmListGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterHisSmListGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MasterHisSmListGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.MasterHisSmListGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterHisSmListGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisSmListGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterHisSmListGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterHisSmListGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterHisSmListGRV.GridControl = Me.MasterHisSmList
        Me.MasterHisSmListGRV.GroupRowHeight = 30
        Me.MasterHisSmListGRV.Name = "MasterHisSmListGRV"
        Me.MasterHisSmListGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterHisSmListGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterHisSmListGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterHisSmListGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterHisSmListGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterHisSmListGRV.OptionsView.ShowGroupPanel = False
        Me.MasterHisSmListGRV.OptionsView.ShowViewCaption = True
        Me.MasterHisSmListGRV.RowHeight = 21
        Me.MasterHisSmListGRV.ViewCaption = " "
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.MasterHisSmList
        Me.GridView8.Name = "GridView8"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.MasterHisReport)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1022, 330)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Lịch sử truy cập báo cáo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MasterHisReport
        '
        Me.MasterHisReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterHisReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterHisReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisReport.Location = New System.Drawing.Point(0, 0)
        Me.MasterHisReport.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterHisReport.MainView = Me.MasterHisReportGRV
        Me.MasterHisReport.Name = "MasterHisReport"
        Me.MasterHisReport.Size = New System.Drawing.Size(1022, 330)
        Me.MasterHisReport.TabIndex = 11
        Me.MasterHisReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterHisReportGRV, Me.GridView6})
        '
        'MasterHisReportGRV
        '
        Me.MasterHisReportGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.MasterHisReportGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.MasterHisReportGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MasterHisReportGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.MasterHisReportGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterHisReportGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.MasterHisReportGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterHisReportGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterHisReportGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterHisReportGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.MasterHisReportGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.MasterHisReportGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterHisReportGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterHisReportGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterHisReportGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterHisReportGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterHisReportGRV.GridControl = Me.MasterHisReport
        Me.MasterHisReportGRV.GroupRowHeight = 30
        Me.MasterHisReportGRV.Name = "MasterHisReportGRV"
        Me.MasterHisReportGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterHisReportGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterHisReportGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterHisReportGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterHisReportGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterHisReportGRV.OptionsView.ShowGroupPanel = False
        Me.MasterHisReportGRV.OptionsView.ShowViewCaption = True
        Me.MasterHisReportGRV.RowHeight = 21
        Me.MasterHisReportGRV.ViewCaption = " "
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.MasterHisReport
        Me.GridView6.Name = "GridView6"
        '
        'CmdSearch
        '
        Me.CmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(965, 7)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(107, 30)
        Me.CmdSearch.TabIndex = 8
        Me.CmdSearch.Text = "Tra cứu"
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Manager = Me.BarManager1
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1190, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 529)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1190, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 529)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1190, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 529)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thời gian từ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Tài khoản"
        '
        'TxtComment
        '
        Me.TxtComment.BackColor = System.Drawing.Color.White
        Me.TxtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtComment.ForeColor = System.Drawing.Color.Navy
        Me.TxtComment.Location = New System.Drawing.Point(204, 29)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.ReadOnly = True
        Me.TxtComment.Size = New System.Drawing.Size(207, 20)
        Me.TxtComment.TabIndex = 6
        Me.TxtComment.TabStop = False
        '
        'TxtUser
        '
        Me.TxtUser._ActilookupPopup = False
        Me.TxtUser.CyberActilookupPopup = True
        Me.TxtUser.Dv_ListDetail = Nothing
        Me.TxtUser.Dv_Master = Nothing
        Me.TxtUser.FilterClient = ""
        Me.TxtUser.FilterSQL = ""
        Me.TxtUser.Location = New System.Drawing.Point(77, 29)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtUser.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser.Properties.Appearance.Options.UseFont = True
        Me.TxtUser.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUser.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtUser.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtUser.Size = New System.Drawing.Size(124, 20)
        Me.TxtUser.TabIndex = 5
        Me.TxtUser.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "đến"
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(77, 5)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_Ct1.TabIndex = 1
        Me.TxtNgay_Ct1.Value = "12/06/2020 13:11"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(287, 5)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_Ct2.TabIndex = 3
        Me.TxtNgay_Ct2.Value = "12/06/2020 13:11"
        '
        'FrmUsageHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1190, 529)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtComment)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmUsageHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtComment, 0)
        Me.Controls.SetChildIndex(Me.TxtUser, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MasterHisVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterHisVoucherGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MasterHisLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterHisLoginGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.MasterHisSmList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterHisSmListGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.MasterHisReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterHisReportGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents MasterHisVoucher As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterHisVoucherGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents MasterHisLogin As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterHisLoginGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents CmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Friend WithEvents MasterHisSmList As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterHisSmListGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterHisReport As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterHisReportGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtComment As Windows.Forms.TextBox
    Friend WithEvents TxtUser As SmLists.TxtLookup
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_Ct1 As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
End Class
