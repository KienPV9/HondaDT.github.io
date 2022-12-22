<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ROSDMVT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ROSDMVT))
        Me.LabLenh_RO = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.CmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PopupMenuChoGRV = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.CmDanh_Sach = New System.Windows.Forms.Button()
        Me.Detail1 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdSelectFile = New System.Windows.Forms.Button()
        Me.Chkis_Hd = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtVi_tri = New System.Windows.Forms.TextBox()
        Me.TxtNh_vt = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_nh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        Me.lblMa_kh = New System.Windows.Forms.Label()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.CmdOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TxtNh_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 498)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1483, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1283, 502)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1385, 502)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        Me.ButtExit.Visible = False
        '
        'LabLenh_RO
        '
        Me.LabLenh_RO.AutoSize = True
        Me.LabLenh_RO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_RO.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LabLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_RO.Location = New System.Drawing.Point(174, 34)
        Me.LabLenh_RO.Name = "LabLenh_RO"
        Me.LabLenh_RO.Size = New System.Drawing.Size(96, 17)
        Me.LabLenh_RO.TabIndex = 1804
        Me.LabLenh_RO.Tag = "R/O"
        Me.LabLenh_RO.Text = "Nhóm vật tư"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(274, 30)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(411, 26)
        Me.TxtSo_Ro.TabIndex = 2
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CmdUpdate.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdUpdate.Appearance.Options.UseFont = True
        Me.CmdUpdate.Appearance.Options.UseForeColor = True
        Me.CmdUpdate.Image = CType(resources.GetObject("CmdUpdate.Image"), System.Drawing.Image)
        Me.CmdUpdate.Location = New System.Drawing.Point(691, 108)
        Me.CmdUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(114, 36)
        Me.CmdUpdate.TabIndex = 2204
        Me.CmdUpdate.Text = "&Cập Nhật"
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(1290, 508)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(68, 17)
        Me.LabT_TT_NT.TabIndex = 1811
        Me.LabT_TT_NT.Tag = "Total All"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT.Location = New System.Drawing.Point(1363, 506)
        Me.TxtT_TT.MaxWholeDigits = 16
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_TT.TabIndex = 1810
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "1.0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 556)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 556)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1252, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 556)
        '
        'PopupMenuChoGRV
        '
        Me.PopupMenuChoGRV.Manager = Me.BarManager1
        Me.PopupMenuChoGRV.Name = "PopupMenuChoGRV"
        '
        'CmDanh_Sach
        '
        Me.CmDanh_Sach.Location = New System.Drawing.Point(87, 29)
        Me.CmDanh_Sach.Name = "CmDanh_Sach"
        Me.CmDanh_Sach.Size = New System.Drawing.Size(183, 47)
        Me.CmDanh_Sach.TabIndex = 3
        Me.CmDanh_Sach.Tag = "List RO has not exported out of stock"
        Me.CmDanh_Sach.Text = "Danh sách nhà cung cấp"
        Me.CmDanh_Sach.UseVisualStyleBackColor = True
        Me.CmDanh_Sach.Visible = False
        '
        'Detail1
        '
        Me.Detail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail1.Location = New System.Drawing.Point(3, 1)
        Me.Detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail1.MainView = Me.DetailGRV1
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Size = New System.Drawing.Size(289, 474)
        Me.Detail1.TabIndex = 7125
        Me.Detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV1})
        '
        'DetailGRV1
        '
        Me.DetailGRV1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV1.GridControl = Me.Detail1
        Me.DetailGRV1.GroupRowHeight = 30
        Me.DetailGRV1.Name = "DetailGRV1"
        Me.DetailGRV1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV1.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV1.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV1.OptionsView.ShowGroupPanel = False
        Me.DetailGRV1.RowHeight = 21
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(3, 186)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(938, 289)
        Me.Detail.TabIndex = 1817
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 9)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtFileName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdSelectFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chkis_Hd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtVi_tri)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtNh_vt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_nh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtMa_Vt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMa_kh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_Vt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdOK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Detail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSo_Ro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabLenh_RO)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Detail1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CmDanh_Sach)
        Me.SplitContainer1.Size = New System.Drawing.Size(1243, 497)
        Me.SplitContainer1.SplitterDistance = 944
        Me.SplitContainer1.TabIndex = 7130
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(177, 151)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.ReadOnly = True
        Me.TxtFileName.Size = New System.Drawing.Size(508, 20)
        Me.TxtFileName.TabIndex = 7136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7138
        Me.Label4.Tag = "File Excel "
        Me.Label4.Text = "Import Excel"
        '
        'CmdSelectFile
        '
        Me.CmdSelectFile.Location = New System.Drawing.Point(691, 149)
        Me.CmdSelectFile.Name = "CmdSelectFile"
        Me.CmdSelectFile.Size = New System.Drawing.Size(113, 31)
        Me.CmdSelectFile.TabIndex = 7137
        Me.CmdSelectFile.Tag = "Select file"
        Me.CmdSelectFile.Text = "Chọn File"
        Me.CmdSelectFile.UseVisualStyleBackColor = True
        '
        'Chkis_Hd
        '
        Me.Chkis_Hd.AutoSize = True
        Me.Chkis_Hd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkis_Hd.ForeColor = System.Drawing.Color.Red
        Me.Chkis_Hd.Location = New System.Drawing.Point(405, 108)
        Me.Chkis_Hd.Name = "Chkis_Hd"
        Me.Chkis_Hd.Size = New System.Drawing.Size(72, 17)
        Me.Chkis_Hd.TabIndex = 7135
        Me.Chkis_Hd.Tag = "Group 1 "
        Me.Chkis_Hd.Text = "Có vị trí"
        Me.Chkis_Hd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(141, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 13)
        Me.Label3.TabIndex = 2210
        Me.Label3.Tag = "Customer"
        Me.Label3.Text = "Nếu nhập vị trí ở đây thì hệ thống sẽ cập nhật đồng bộ cho những vật tư được chọn" &
    ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(174, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2209
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Vị Trí"
        '
        'TxtVi_tri
        '
        Me.TxtVi_tri.BackColor = System.Drawing.Color.White
        Me.TxtVi_tri.ForeColor = System.Drawing.Color.Navy
        Me.TxtVi_tri.Location = New System.Drawing.Point(274, 106)
        Me.TxtVi_tri.Name = "TxtVi_tri"
        Me.TxtVi_tri.Size = New System.Drawing.Size(125, 20)
        Me.TxtVi_tri.TabIndex = 2208
        Me.TxtVi_tri.Tag = ""
        '
        'TxtNh_vt
        '
        Me.TxtNh_vt._ActilookupPopup = False
        Me.TxtNh_vt.CyberActilookupPopup = True
        Me.TxtNh_vt.Dv_ListDetail = Nothing
        Me.TxtNh_vt.Dv_Master = Nothing
        Me.TxtNh_vt.FilterClient = ""
        Me.TxtNh_vt.FilterSQL = ""
        Me.TxtNh_vt.Location = New System.Drawing.Point(274, 58)
        Me.TxtNh_vt.Name = "TxtNh_vt"
        Me.TxtNh_vt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNh_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_vt.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_vt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtNh_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_vt.Size = New System.Drawing.Size(125, 22)
        Me.TxtNh_vt.TabIndex = 2205
        Me.TxtNh_vt.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(174, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2207
        Me.Label1.Tag = "Customer"
        Me.Label1.Text = "Nhóm vật tư"
        '
        'TxtTen_nh
        '
        Me.TxtTen_nh.BackColor = System.Drawing.Color.White
        Me.TxtTen_nh.Enabled = False
        Me.TxtTen_nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_nh.Location = New System.Drawing.Point(405, 59)
        Me.TxtTen_nh.Name = "TxtTen_nh"
        Me.TxtTen_nh.ReadOnly = True
        Me.TxtTen_nh.Size = New System.Drawing.Size(280, 20)
        Me.TxtTen_nh.TabIndex = 2206
        Me.TxtTen_nh.Tag = ""
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(274, 82)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(125, 22)
        Me.TxtMa_Vt.TabIndex = 2201
        Me.TxtMa_Vt.Table_Name = ""
        '
        'lblMa_kh
        '
        Me.lblMa_kh.AutoSize = True
        Me.lblMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_kh.Location = New System.Drawing.Point(174, 89)
        Me.lblMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_kh.Name = "lblMa_kh"
        Me.lblMa_kh.Size = New System.Drawing.Size(52, 13)
        Me.lblMa_kh.TabIndex = 2203
        Me.lblMa_kh.Tag = "Customer"
        Me.lblMa_kh.Text = "Mã vật tư"
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(405, 83)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(280, 20)
        Me.TxtTen_Vt.TabIndex = 2202
        Me.TxtTen_Vt.Tag = ""
        '
        'CmdOK
        '
        Me.CmdOK.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.CmdOK.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdOK.Appearance.Options.UseFont = True
        Me.CmdOK.Appearance.Options.UseForeColor = True
        Me.CmdOK.Image = CType(resources.GetObject("CmdOK.Image"), System.Drawing.Image)
        Me.CmdOK.Location = New System.Drawing.Point(553, 108)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(125, 36)
        Me.CmdOK.TabIndex = 2200
        Me.CmdOK.Text = "&Tìm Kiếm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(402, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 1839
        Me.Label6.Tag = "Date to"
        Me.Label6.Text = "Thông tin tìm kiếm"
        '
        'ROSDMVT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 556)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ROSDMVT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TxtNh_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabLenh_RO As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenuChoGRV As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CmDanh_Sach As System.Windows.Forms.Button
    Friend WithEvents Detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents TxtMa_Vt As SmLists.TxtLookup
    Friend WithEvents lblMa_kh As Windows.Forms.Label
    Friend WithEvents TxtTen_Vt As Windows.Forms.TextBox
    Friend WithEvents CmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents CmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtVi_tri As Windows.Forms.TextBox
    Friend WithEvents TxtNh_vt As SmLists.TxtLookup
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtTen_nh As Windows.Forms.TextBox
    Friend WithEvents Chkis_Hd As Windows.Forms.CheckBox
    Friend WithEvents TxtFileName As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents CmdSelectFile As Windows.Forms.Button
End Class
