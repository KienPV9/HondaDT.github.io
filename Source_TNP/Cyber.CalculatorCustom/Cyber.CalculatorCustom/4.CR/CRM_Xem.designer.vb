<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRM_Xem
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
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.ComFilter = New System.Windows.Forms.ComboBox()
        Me.CmbbSms = New System.Windows.Forms.Button()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.CmbbSelectAll = New System.Windows.Forms.Button()
        Me.CmbbUnSelectAll = New System.Windows.Forms.Button()
        Me.CmbbXuatExcelx = New System.Windows.Forms.Button()
        Me.CmdCap_Nhap_Km = New System.Windows.Forms.Button()
        Me.CmbRefresh = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 417)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(984, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(790, 389)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.Size = New System.Drawing.Size(94, 30)
        Me.ButtOK.TabIndex = 6
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(886, 389)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
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
        Me.barDockControlTop.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 443)
        Me.barDockControlBottom.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 443)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(988, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 443)
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(1, 1)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(985, 369)
        Me.Master.TabIndex = 50
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
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelect = True
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
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
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(155, 375)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(349, 20)
        Me.TxtSearch.TabIndex = 1787
        '
        'ComFilter
        '
        Me.ComFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComFilter.ForeColor = System.Drawing.Color.Navy
        Me.ComFilter.FormattingEnabled = True
        Me.ComFilter.Location = New System.Drawing.Point(1, 373)
        Me.ComFilter.Name = "ComFilter"
        Me.ComFilter.Size = New System.Drawing.Size(148, 21)
        Me.ComFilter.TabIndex = 1786
        '
        'CmbbSms
        '
        Me.CmbbSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbSms.Location = New System.Drawing.Point(509, 396)
        Me.CmbbSms.Name = "CmbbSms"
        Me.CmbbSms.Size = New System.Drawing.Size(99, 24)
        Me.CmbbSms.TabIndex = 1793
        Me.CmbbSms.TabStop = False
        Me.CmbbSms.Tag = "SMS"
        Me.CmbbSms.Text = "SMS"
        Me.CmbbSms.UseVisualStyleBackColor = True
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbXuatExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(306, 396)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(100, 24)
        Me.CmbbXuatExcel.TabIndex = 1792
        Me.CmbbXuatExcel.Tag = "&ExportExcel(xls)"
        Me.CmbbXuatExcel.Text = "To Excel (xls)"
        '
        'CmbbSelectAll
        '
        Me.CmbbSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbSelectAll.Location = New System.Drawing.Point(103, 396)
        Me.CmbbSelectAll.Name = "CmbbSelectAll"
        Me.CmbbSelectAll.Size = New System.Drawing.Size(100, 24)
        Me.CmbbSelectAll.TabIndex = 1796
        Me.CmbbSelectAll.Tag = "&Select all"
        Me.CmbbSelectAll.Text = "&Chọn toàn bộ"
        '
        'CmbbUnSelectAll
        '
        Me.CmbbUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbUnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbUnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbUnSelectAll.Location = New System.Drawing.Point(205, 396)
        Me.CmbbUnSelectAll.Name = "CmbbUnSelectAll"
        Me.CmbbUnSelectAll.Size = New System.Drawing.Size(100, 24)
        Me.CmbbUnSelectAll.TabIndex = 1795
        Me.CmbbUnSelectAll.Tag = "&Deselect"
        Me.CmbbUnSelectAll.Text = "&Gỡ chọn"
        '
        'CmbbXuatExcelx
        '
        Me.CmbbXuatExcelx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcelx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbXuatExcelx.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbXuatExcelx.Location = New System.Drawing.Point(408, 396)
        Me.CmbbXuatExcelx.Name = "CmbbXuatExcelx"
        Me.CmbbXuatExcelx.Size = New System.Drawing.Size(100, 24)
        Me.CmbbXuatExcelx.TabIndex = 1801
        Me.CmbbXuatExcelx.Tag = "&ExportExcel(xlsx)"
        Me.CmbbXuatExcelx.Text = "To Excel (xlsx)"
        '
        'CmdCap_Nhap_Km
        '
        Me.CmdCap_Nhap_Km.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCap_Nhap_Km.Location = New System.Drawing.Point(790, 389)
        Me.CmdCap_Nhap_Km.Name = "CmdCap_Nhap_Km"
        Me.CmdCap_Nhap_Km.Size = New System.Drawing.Size(94, 30)
        Me.CmdCap_Nhap_Km.TabIndex = 1940
        Me.CmdCap_Nhap_Km.TabStop = False
        Me.CmdCap_Nhap_Km.Tag = "&EnterKM"
        Me.CmdCap_Nhap_Km.Text = "&Cập nhập số km"
        Me.CmdCap_Nhap_Km.UseVisualStyleBackColor = True
        '
        'CmbRefresh
        '
        Me.CmbRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbRefresh.Location = New System.Drawing.Point(-1, 397)
        Me.CmbRefresh.Name = "CmbRefresh"
        Me.CmbRefresh.Size = New System.Drawing.Size(100, 23)
        Me.CmbRefresh.TabIndex = 1956
        '
        'CRM_Xem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(988, 443)
        Me.Controls.Add(Me.CmbRefresh)
        Me.Controls.Add(Me.CmdCap_Nhap_Km)
        Me.Controls.Add(Me.CmbbXuatExcelx)
        Me.Controls.Add(Me.CmbbSelectAll)
        Me.Controls.Add(Me.CmbbUnSelectAll)
        Me.Controls.Add(Me.CmbbSms)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.ComFilter)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CRM_Xem"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.ComFilter, 0)
        Me.Controls.SetChildIndex(Me.TxtSearch, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.CmbbSms, 0)
        Me.Controls.SetChildIndex(Me.CmbbUnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcelx, 0)
        Me.Controls.SetChildIndex(Me.CmdCap_Nhap_Km, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmbRefresh, 0)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComFilter As System.Windows.Forms.ComboBox
    Friend WithEvents CmbbSms As System.Windows.Forms.Button
    Friend WithEvents CmbbXuatExcel As System.Windows.Forms.Button
    Friend WithEvents CmbbSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmbbUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmbbXuatExcelx As System.Windows.Forms.Button
    Friend WithEvents CmdCap_Nhap_Km As System.Windows.Forms.Button
    Friend WithEvents CmbRefresh As DevExpress.XtraEditors.SimpleButton

End Class
