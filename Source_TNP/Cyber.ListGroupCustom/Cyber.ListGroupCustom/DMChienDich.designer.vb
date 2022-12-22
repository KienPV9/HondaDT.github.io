<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMChienDich
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.TxtMa_ChienDich = New System.Windows.Forms.TextBox()
        Me.TxtTen_ChienDich = New System.Windows.Forms.TextBox()
        Me.LabTen_TD1 = New System.Windows.Forms.Label()
        Me.TxtTen_ChienDich2 = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNgay_BD = New ClsTextBox.txtDate()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New ClsTextBox.txtDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DetailSK = New DevExpress.XtraGrid.GridControl()
        Me.DetailSKGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DetailVT = New DevExpress.XtraGrid.GridControl()
        Me.DetailVTGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DetailCV = New DevExpress.XtraGrid.GridControl()
        Me.DetailCVGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtNgay_CS = New ClsTextBox.txtDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdImport = New DevExpress.XtraEditors.SimpleButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DetailSK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailSKGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DetailVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailVTGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DetailCV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailCVGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(944, 578)
        Me.ButtExit.TabIndex = 11
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(842, 578)
        Me.ButtOK.TabIndex = 10
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(736, 584)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 588)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 568)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1042, 9)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.AutoSize = True
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 8)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(71, 13)
        Me.LabMa_TD1.TabIndex = 9
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã chiến dịch"
        '
        'TxtMa_ChienDich
        '
        Me.TxtMa_ChienDich.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_ChienDich.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ChienDich.Location = New System.Drawing.Point(111, 4)
        Me.TxtMa_ChienDich.Name = "TxtMa_ChienDich"
        Me.TxtMa_ChienDich.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_ChienDich.TabIndex = 0
        '
        'TxtTen_ChienDich
        '
        Me.TxtTen_ChienDich.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChienDich.Location = New System.Drawing.Point(111, 28)
        Me.TxtTen_ChienDich.Name = "TxtTen_ChienDich"
        Me.TxtTen_ChienDich.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_ChienDich.TabIndex = 1
        '
        'LabTen_TD1
        '
        Me.LabTen_TD1.AutoSize = True
        Me.LabTen_TD1.Location = New System.Drawing.Point(7, 32)
        Me.LabTen_TD1.Name = "LabTen_TD1"
        Me.LabTen_TD1.Size = New System.Drawing.Size(75, 13)
        Me.LabTen_TD1.TabIndex = 8
        Me.LabTen_TD1.Tag = "Name"
        Me.LabTen_TD1.Text = "Tên chiến dịch"
        '
        'TxtTen_ChienDich2
        '
        Me.TxtTen_ChienDich2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChienDich2.Location = New System.Drawing.Point(111, 52)
        Me.TxtTen_ChienDich2.Name = "TxtTen_ChienDich2"
        Me.TxtTen_ChienDich2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_ChienDich2.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.AutoSize = True
        Me.Labten_TD12.Location = New System.Drawing.Point(7, 56)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(73, 13)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "English name"
        Me.Labten_TD12.Text = "Tên tiếng anh"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(111, 128)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(672, 21)
        Me.TxtDien_Giai.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "Explain"
        Me.Label1.Text = "Diên giải"
        '
        'txtNgay_BD
        '
        Me.txtNgay_BD.Flags = 65536
        Me.txtNgay_BD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_BD.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_BD.isEmpty = True
        Me.txtNgay_BD.Location = New System.Drawing.Point(111, 76)
        Me.txtNgay_BD.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_BD.MaxLength = 10
        Me.txtNgay_BD.Name = "txtNgay_BD"
        Me.txtNgay_BD.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_BD.ShowDayBeforeMonth = False
        Me.txtNgay_BD.Size = New System.Drawing.Size(149, 21)
        Me.txtNgay_BD.TabIndex = 3
        Me.txtNgay_BD.Text = "07/11/2017"
        Me.txtNgay_BD.Value = New Date(2017, 11, 7, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Date from"
        Me.Label2.Text = "Hệu lực từ ngày"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.Flags = 65536
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.isEmpty = True
        Me.TxtNgay_KT.Location = New System.Drawing.Point(375, 76)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_KT.TabIndex = 4
        Me.TxtNgay_KT.Text = "07/11/2017"
        Me.TxtNgay_KT.Value = New Date(2017, 11, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(308, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Tag = "Date to"
        Me.Label3.Text = "Đến ngày"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 164)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1044, 391)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DetailSK)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1036, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "Car info"
        Me.TabPage1.Text = "Thông tin xe"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DetailSK
        '
        Me.DetailSK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailSK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailSK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailSK.Location = New System.Drawing.Point(3, 3)
        Me.DetailSK.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailSK.MainView = Me.DetailSKGRV
        Me.DetailSK.Name = "DetailSK"
        Me.DetailSK.Size = New System.Drawing.Size(1030, 359)
        Me.DetailSK.TabIndex = 11
        Me.DetailSK.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailSKGRV})
        '
        'DetailSKGRV
        '
        Me.DetailSKGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailSKGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailSKGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailSKGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailSKGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailSKGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailSKGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailSKGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailSKGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailSKGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailSKGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailSKGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailSKGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailSKGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailSKGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailSKGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailSKGRV.GridControl = Me.DetailSK
        Me.DetailSKGRV.GroupRowHeight = 30
        Me.DetailSKGRV.Name = "DetailSKGRV"
        Me.DetailSKGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailSKGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailSKGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailSKGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailSKGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailSKGRV.OptionsView.ShowGroupPanel = False
        Me.DetailSKGRV.OptionsView.ShowViewCaption = True
        Me.DetailSKGRV.RowHeight = 21
        Me.DetailSKGRV.ViewCaption = "F4: Thêm dòng - F8: Xóa dòng - Ctr + Tab: Rời nhập chi tiết"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DetailVT)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1036, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "Supplies"
        Me.TabPage2.Text = "Vật tư"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DetailVT
        '
        Me.DetailVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailVT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailVT.Location = New System.Drawing.Point(3, 3)
        Me.DetailVT.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailVT.MainView = Me.DetailVTGRV
        Me.DetailVT.Name = "DetailVT"
        Me.DetailVT.Size = New System.Drawing.Size(1030, 359)
        Me.DetailVT.TabIndex = 11
        Me.DetailVT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailVTGRV})
        '
        'DetailVTGRV
        '
        Me.DetailVTGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailVTGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailVTGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailVTGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailVTGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailVTGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailVTGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailVTGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailVTGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailVTGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailVTGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailVTGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailVTGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailVTGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailVTGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailVTGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailVTGRV.GridControl = Me.DetailVT
        Me.DetailVTGRV.GroupRowHeight = 30
        Me.DetailVTGRV.Name = "DetailVTGRV"
        Me.DetailVTGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailVTGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailVTGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailVTGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailVTGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailVTGRV.OptionsView.ShowGroupPanel = False
        Me.DetailVTGRV.OptionsView.ShowViewCaption = True
        Me.DetailVTGRV.RowHeight = 21
        Me.DetailVTGRV.ViewCaption = "F4: Thêm dòng - F8: Xóa dòng - Ctr + Tab: Rời nhập chi tiết"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DetailCV)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1036, 365)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "Jobs"
        Me.TabPage3.Text = "Công việc"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DetailCV
        '
        Me.DetailCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailCV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailCV.Location = New System.Drawing.Point(3, 3)
        Me.DetailCV.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailCV.MainView = Me.DetailCVGRV
        Me.DetailCV.Name = "DetailCV"
        Me.DetailCV.Size = New System.Drawing.Size(1030, 359)
        Me.DetailCV.TabIndex = 11
        Me.DetailCV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailCVGRV})
        '
        'DetailCVGRV
        '
        Me.DetailCVGRV.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailCVGRV.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailCVGRV.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailCVGRV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailCVGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailCVGRV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailCVGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailCVGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailCVGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailCVGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailCVGRV.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailCVGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailCVGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailCVGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailCVGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailCVGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailCVGRV.GridControl = Me.DetailCV
        Me.DetailCVGRV.GroupRowHeight = 30
        Me.DetailCVGRV.Name = "DetailCVGRV"
        Me.DetailCVGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailCVGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailCVGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailCVGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailCVGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailCVGRV.OptionsView.ShowGroupPanel = False
        Me.DetailCVGRV.OptionsView.ShowViewCaption = True
        Me.DetailCVGRV.RowHeight = 21
        Me.DetailCVGRV.ViewCaption = "F4: Thêm dòng - F8: Xóa dòng - Ctr + Tab: Rời nhập chi tiết"
        '
        'TxtNgay_CS
        '
        Me.TxtNgay_CS.Flags = 65536
        Me.TxtNgay_CS.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CS.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CS.isEmpty = True
        Me.TxtNgay_CS.Location = New System.Drawing.Point(111, 102)
        Me.TxtNgay_CS.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CS.MaxLength = 10
        Me.TxtNgay_CS.Name = "TxtNgay_CS"
        Me.TxtNgay_CS.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CS.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CS.ShowDayBeforeMonth = False
        Me.TxtNgay_CS.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_CS.TabIndex = 5
        Me.TxtNgay_CS.Text = "07/11/2017"
        Me.TxtNgay_CS.Value = New Date(2017, 11, 7, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Tag = "Date from"
        Me.Label4.Text = "Ngày dự kiến gọi"
        '
        'CmdImport
        '
        Me.CmdImport.Location = New System.Drawing.Point(969, 128)
        Me.CmdImport.Name = "CmdImport"
        Me.CmdImport.Size = New System.Drawing.Size(65, 35)
        Me.CmdImport.TabIndex = 24
        Me.CmdImport.Text = "Import Xe"
        '
        'DMChienDich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1046, 611)
        Me.Controls.Add(Me.CmdImport)
        Me.Controls.Add(Me.TxtNgay_CS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNgay_BD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_ChienDich2)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.TxtTen_ChienDich)
        Me.Controls.Add(Me.LabTen_TD1)
        Me.Controls.Add(Me.TxtMa_ChienDich)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMChienDich"
        Me.Text = "Danh mục nguồn vốn"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChienDich2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CS, 0)
        Me.Controls.SetChildIndex(Me.CmdImport, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DetailSK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailSKGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DetailVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailVTGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DetailCV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailCVGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_ChienDich As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_ChienDich As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ChienDich2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNgay_BD As ClsTextBox.txtDate
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As ClsTextBox.txtDate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DetailSK As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailSKGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DetailVT As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailVTGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DetailCV As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailCVGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtNgay_CS As ClsTextBox.txtDate
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdImport As DevExpress.XtraEditors.SimpleButton

End Class
