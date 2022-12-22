<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDKHTN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDKHTN))
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDT1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_xa = New System.Windows.Forms.TextBox()
        Me.TxtMa_xa = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_quan = New System.Windows.Forms.TextBox()
        Me.TxtMa_quan = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs_c = New System.Windows.Forms.TextBox()
        Me.TxtTen_tp = New System.Windows.Forms.TextBox()
        Me.TxtMa_tp = New Cyber.SmLists.TxtLookup()
        Me.Txtma_hs_c = New Cyber.SmLists.TxtLookup()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LabMa_kh = New System.Windows.Forms.Label()
        Me.LabDia_Chi = New System.Windows.Forms.Label()
        Me.TxtLoai_kh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTen_hs_n = New System.Windows.Forms.TextBox()
        Me.TxtMa_hs_n = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmdLoadData = New System.Windows.Forms.Button()
        Me.CmdRemoveAll = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtMa_xa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_quan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_tp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_hs_c.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtMa_hs_n.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 454)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1013, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(794, 464)
        Me.ButtOK.Size = New System.Drawing.Size(115, 30)
        Me.ButtOK.TabIndex = 3
        Me.ButtOK.Text = "&Chuyển đổi"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(915, 464)
        Me.ButtExit.TabIndex = 4
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(0, 203)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1015, 254)
        Me.Master.TabIndex = 506
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 518)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1017, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 518)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1017, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 518)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDT1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtTen_xa)
        Me.GroupBox1.Controls.Add(Me.TxtMa_xa)
        Me.GroupBox1.Controls.Add(Me.TxtTen_quan)
        Me.GroupBox1.Controls.Add(Me.TxtMa_quan)
        Me.GroupBox1.Controls.Add(Me.TxtTen_hs_c)
        Me.GroupBox1.Controls.Add(Me.TxtTen_tp)
        Me.GroupBox1.Controls.Add(Me.TxtMa_tp)
        Me.GroupBox1.Controls.Add(Me.Txtma_hs_c)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.LabMa_kh)
        Me.GroupBox1.Controls.Add(Me.LabDia_Chi)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 182)
        Me.GroupBox1.TabIndex = 2051
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin người chuyển đổi"
        '
        'txtDT1
        '
        Me.txtDT1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDT1.Location = New System.Drawing.Point(100, 150)
        Me.txtDT1.Name = "txtDT1"
        Me.txtDT1.Size = New System.Drawing.Size(108, 21)
        Me.txtDT1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 2057
        Me.Label2.Tag = "Address"
        Me.Label2.Text = "Đ.thoại KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 2056
        Me.Label1.Tag = "Address"
        Me.Label1.Text = "Xã/Phường"
        '
        'TxtTen_xa
        '
        Me.TxtTen_xa.BackColor = System.Drawing.Color.White
        Me.TxtTen_xa.Enabled = False
        Me.TxtTen_xa.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_xa.Location = New System.Drawing.Point(210, 126)
        Me.TxtTen_xa.Name = "TxtTen_xa"
        Me.TxtTen_xa.ReadOnly = True
        Me.TxtTen_xa.Size = New System.Drawing.Size(302, 21)
        Me.TxtTen_xa.TabIndex = 2055
        Me.TxtTen_xa.TabStop = False
        '
        'TxtMa_xa
        '
        Me.TxtMa_xa._ActilookupPopup = False
        Me.TxtMa_xa.CyberActilookupPopup = True
        Me.TxtMa_xa.Dv_ListDetail = Nothing
        Me.TxtMa_xa.Dv_Master = Nothing
        Me.TxtMa_xa.FilterClient = ""
        Me.TxtMa_xa.FilterSQL = ""
        Me.TxtMa_xa.Location = New System.Drawing.Point(100, 126)
        Me.TxtMa_xa.Name = "TxtMa_xa"
        Me.TxtMa_xa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_xa.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xa.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_xa.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_xa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_xa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_xa.Size = New System.Drawing.Size(108, 22)
        Me.TxtMa_xa.TabIndex = 3
        Me.TxtMa_xa.Table_Name = ""
        '
        'TxtTen_quan
        '
        Me.TxtTen_quan.BackColor = System.Drawing.Color.White
        Me.TxtTen_quan.Enabled = False
        Me.TxtTen_quan.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quan.Location = New System.Drawing.Point(210, 102)
        Me.TxtTen_quan.Name = "TxtTen_quan"
        Me.TxtTen_quan.ReadOnly = True
        Me.TxtTen_quan.Size = New System.Drawing.Size(302, 21)
        Me.TxtTen_quan.TabIndex = 2053
        Me.TxtTen_quan.TabStop = False
        '
        'TxtMa_quan
        '
        Me.TxtMa_quan._ActilookupPopup = False
        Me.TxtMa_quan.CyberActilookupPopup = True
        Me.TxtMa_quan.Dv_ListDetail = Nothing
        Me.TxtMa_quan.Dv_Master = Nothing
        Me.TxtMa_quan.FilterClient = ""
        Me.TxtMa_quan.FilterSQL = ""
        Me.TxtMa_quan.Location = New System.Drawing.Point(100, 102)
        Me.TxtMa_quan.Name = "TxtMa_quan"
        Me.TxtMa_quan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_quan.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_quan.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_quan.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_quan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_quan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_quan.Size = New System.Drawing.Size(108, 22)
        Me.TxtMa_quan.TabIndex = 2
        Me.TxtMa_quan.Table_Name = ""
        '
        'TxtTen_hs_c
        '
        Me.TxtTen_hs_c.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs_c.Enabled = False
        Me.TxtTen_hs_c.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs_c.Location = New System.Drawing.Point(210, 24)
        Me.TxtTen_hs_c.Name = "TxtTen_hs_c"
        Me.TxtTen_hs_c.ReadOnly = True
        Me.TxtTen_hs_c.Size = New System.Drawing.Size(302, 21)
        Me.TxtTen_hs_c.TabIndex = 2047
        Me.TxtTen_hs_c.TabStop = False
        '
        'TxtTen_tp
        '
        Me.TxtTen_tp.BackColor = System.Drawing.Color.White
        Me.TxtTen_tp.Enabled = False
        Me.TxtTen_tp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_tp.Location = New System.Drawing.Point(210, 78)
        Me.TxtTen_tp.Name = "TxtTen_tp"
        Me.TxtTen_tp.ReadOnly = True
        Me.TxtTen_tp.Size = New System.Drawing.Size(302, 21)
        Me.TxtTen_tp.TabIndex = 2051
        Me.TxtTen_tp.TabStop = False
        '
        'TxtMa_tp
        '
        Me.TxtMa_tp._ActilookupPopup = False
        Me.TxtMa_tp.CyberActilookupPopup = True
        Me.TxtMa_tp.Dv_ListDetail = Nothing
        Me.TxtMa_tp.Dv_Master = Nothing
        Me.TxtMa_tp.FilterClient = ""
        Me.TxtMa_tp.FilterSQL = ""
        Me.TxtMa_tp.Location = New System.Drawing.Point(100, 78)
        Me.TxtMa_tp.Name = "TxtMa_tp"
        Me.TxtMa_tp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_tp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_tp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_tp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_tp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_tp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_tp.Size = New System.Drawing.Size(108, 22)
        Me.TxtMa_tp.TabIndex = 1
        Me.TxtMa_tp.Table_Name = ""
        '
        'Txtma_hs_c
        '
        Me.Txtma_hs_c._ActilookupPopup = False
        Me.Txtma_hs_c.CyberActilookupPopup = True
        Me.Txtma_hs_c.Dv_ListDetail = Nothing
        Me.Txtma_hs_c.Dv_Master = Nothing
        Me.Txtma_hs_c.FilterClient = ""
        Me.Txtma_hs_c.FilterSQL = ""
        Me.Txtma_hs_c.Location = New System.Drawing.Point(100, 24)
        Me.Txtma_hs_c.Name = "Txtma_hs_c"
        Me.Txtma_hs_c.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtma_hs_c.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_hs_c.Properties.Appearance.Options.UseFont = True
        Me.Txtma_hs_c.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_hs_c.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.Txtma_hs_c.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_hs_c.Size = New System.Drawing.Size(108, 22)
        Me.Txtma_hs_c.TabIndex = 0
        Me.Txtma_hs_c.Table_Name = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(6, 28)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 15)
        Me.Label32.TabIndex = 2042
        Me.Label32.Tag = "Cus code"
        Me.Label32.Text = "User chuyển"
        '
        'LabMa_kh
        '
        Me.LabMa_kh.AutoSize = True
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(6, 82)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(49, 15)
        Me.LabMa_kh.TabIndex = 2044
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Tỉnh/TP"
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.AutoSize = True
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(6, 105)
        Me.LabDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDia_Chi.Name = "LabDia_Chi"
        Me.LabDia_Chi.Size = New System.Drawing.Size(75, 15)
        Me.LabDia_Chi.TabIndex = 2046
        Me.LabDia_Chi.Tag = "Address"
        Me.LabDia_Chi.Text = "Quận/Huyện"
        '
        'TxtLoai_kh
        '
        Me.TxtLoai_kh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoai_kh.Location = New System.Drawing.Point(626, 78)
        Me.TxtLoai_kh.Name = "TxtLoai_kh"
        Me.TxtLoai_kh.Size = New System.Drawing.Size(108, 20)
        Me.TxtLoai_kh.TabIndex = 4
        Me.TxtLoai_kh.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(737, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 2059
        Me.Label4.Tag = "Address"
        Me.Label4.Text = "(A,B,C)"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(547, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2058
        Me.Label3.Tag = "Address"
        Me.Label3.Text = "Loại KH"
        Me.Label3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.TxtTen_hs_n)
        Me.GroupBox2.Controls.Add(Me.TxtMa_hs_n)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(533, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 68)
        Me.GroupBox2.TabIndex = 2053
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin người nhận chuyển đổi"
        '
        'TxtTen_hs_n
        '
        Me.TxtTen_hs_n.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs_n.Enabled = False
        Me.TxtTen_hs_n.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs_n.Location = New System.Drawing.Point(195, 24)
        Me.TxtTen_hs_n.Name = "TxtTen_hs_n"
        Me.TxtTen_hs_n.ReadOnly = True
        Me.TxtTen_hs_n.Size = New System.Drawing.Size(271, 21)
        Me.TxtTen_hs_n.TabIndex = 2047
        Me.TxtTen_hs_n.TabStop = False
        '
        'TxtMa_hs_n
        '
        Me.TxtMa_hs_n._ActilookupPopup = False
        Me.TxtMa_hs_n.CyberActilookupPopup = True
        Me.TxtMa_hs_n.Dv_ListDetail = Nothing
        Me.TxtMa_hs_n.Dv_Master = Nothing
        Me.TxtMa_hs_n.FilterClient = ""
        Me.TxtMa_hs_n.FilterSQL = ""
        Me.TxtMa_hs_n.Location = New System.Drawing.Point(85, 24)
        Me.TxtMa_hs_n.Name = "TxtMa_hs_n"
        Me.TxtMa_hs_n.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_hs_n.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs_n.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_hs_n.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs_n.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_hs_n.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs_n.Size = New System.Drawing.Size(108, 22)
        Me.TxtMa_hs_n.TabIndex = 0
        Me.TxtMa_hs_n.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(5, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 2042
        Me.Label7.Tag = "Cus code"
        Me.Label7.Text = "User nhận"
        '
        'CmdLoadData
        '
        Me.CmdLoadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLoadData.Location = New System.Drawing.Point(533, 119)
        Me.CmdLoadData.Name = "CmdLoadData"
        Me.CmdLoadData.Size = New System.Drawing.Size(100, 30)
        Me.CmdLoadData.TabIndex = 0
        Me.CmdLoadData.Text = "&Lọc dữ liệu"
        Me.CmdLoadData.UseVisualStyleBackColor = True
        '
        'CmdRemoveAll
        '
        Me.CmdRemoveAll.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdRemoveAll.Appearance.Options.UseForeColor = True
        Me.CmdRemoveAll.Image = CType(resources.GetObject("CmdRemoveAll.Image"), System.Drawing.Image)
        Me.CmdRemoveAll.Location = New System.Drawing.Point(731, 119)
        Me.CmdRemoveAll.Name = "CmdRemoveAll"
        Me.CmdRemoveAll.Size = New System.Drawing.Size(91, 30)
        Me.CmdRemoveAll.TabIndex = 2
        Me.CmdRemoveAll.Tag = "&Deselect"
        Me.CmdRemoveAll.Text = "&Không chọn"
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSelectAll.Appearance.Options.UseForeColor = True
        Me.CmdSelectAll.Image = CType(resources.GetObject("CmdSelectAll.Image"), System.Drawing.Image)
        Me.CmdSelectAll.Location = New System.Drawing.Point(636, 119)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(91, 30)
        Me.CmdSelectAll.TabIndex = 1
        Me.CmdSelectAll.Tag = "&Seleect"
        Me.CmdSelectAll.Text = "&Chọn all"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 16)
        Me.Label5.TabIndex = 2058
        Me.Label5.Tag = "Address"
        Me.Label5.Text = "Điều kiện lọc chuyển đổi"
        '
        'CDKHTN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1017, 518)
        Me.Controls.Add(Me.CmdRemoveAll)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.Controls.Add(Me.TxtLoai_kh)
        Me.Controls.Add(Me.CmdLoadData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "CDKHTN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CmdLoadData, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai_kh, 0)
        Me.Controls.SetChildIndex(Me.CmdSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmdRemoveAll, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtMa_xa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_quan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_tp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_hs_c.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtMa_hs_n.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_xa As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_xa As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_quan As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_quan As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_hs_c As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_tp As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_tp As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtma_hs_c As Cyber.SmLists.TxtLookup
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents LabMa_kh As System.Windows.Forms.Label
    Friend WithEvents LabDia_Chi As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTen_hs_n As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_hs_n As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdLoadData As System.Windows.Forms.Button
    Friend WithEvents TxtLoai_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdRemoveAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdSelectAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDT1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
End Class
