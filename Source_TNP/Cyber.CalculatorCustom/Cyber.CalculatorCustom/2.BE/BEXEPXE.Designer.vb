<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEXEPXE
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Master_1 = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV_1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmbbMa_Mau = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbbMa_Kx = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdSms = New System.Windows.Forms.Button()
        Me.CmdAuto = New System.Windows.Forms.Button()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.cmdUnSelectAll = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PopupMenuMasterGrid_1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 488)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1597, 15)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1397, 499)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1499, 499)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Navy
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Master)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Master_1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1203, 499)
        Me.SplitContainer1.SplitterDistance = 897
        Me.SplitContainer1.TabIndex = 45
        '
        'Master
        '
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(0, 0)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(897, 499)
        Me.Master.TabIndex = 3
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsBehavior.Editable = False
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelect = True
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowAutoFilterRow = True
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'Master_1
        '
        Me.Master_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_1.Location = New System.Drawing.Point(0, 0)
        Me.Master_1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_1.MainView = Me.MasterGRV_1
        Me.Master_1.Name = "Master_1"
        Me.Master_1.Size = New System.Drawing.Size(302, 499)
        Me.Master_1.TabIndex = 4
        Me.Master_1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV_1})
        '
        'MasterGRV_1
        '
        Me.MasterGRV_1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow
        Me.MasterGRV_1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV_1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV_1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV_1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV_1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV_1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV_1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV_1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV_1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV_1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV_1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV_1.GridControl = Me.Master_1
        Me.MasterGRV_1.GroupRowHeight = 30
        Me.MasterGRV_1.Name = "MasterGRV_1"
        Me.MasterGRV_1.OptionsBehavior.Editable = False
        Me.MasterGRV_1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV_1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV_1.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV_1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV_1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.MasterGRV_1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV_1.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV_1.OptionsView.ShowAutoFilterRow = True
        Me.MasterGRV_1.OptionsView.ShowGroupPanel = False
        Me.MasterGRV_1.RowHeight = 21
        '
        'CmbbMa_Mau
        '
        Me.CmbbMa_Mau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_Mau.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_Mau.FormattingEnabled = True
        Me.CmbbMa_Mau.Location = New System.Drawing.Point(339, 3)
        Me.CmbbMa_Mau.Name = "CmbbMa_Mau"
        Me.CmbbMa_Mau.Size = New System.Drawing.Size(191, 21)
        Me.CmbbMa_Mau.TabIndex = 1769
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(282, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 1768
        Me.Label1.Tag = "Color"
        Me.Label1.Text = "Màu xe"
        '
        'CmbbMa_Kx
        '
        Me.CmbbMa_Kx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_Kx.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_Kx.FormattingEnabled = True
        Me.CmbbMa_Kx.Location = New System.Drawing.Point(81, 3)
        Me.CmbbMa_Kx.Name = "CmbbMa_Kx"
        Me.CmbbMa_Kx.Size = New System.Drawing.Size(191, 21)
        Me.CmbbMa_Kx.TabIndex = 1770
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(9, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 1767
        Me.Label8.Tag = "Type car"
        Me.Label8.Text = "Kiểu xe"
        '
        'CmdSms
        '
        Me.CmdSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSms.Location = New System.Drawing.Point(366, 499)
        Me.CmdSms.Name = "CmdSms"
        Me.CmdSms.Size = New System.Drawing.Size(95, 30)
        Me.CmdSms.TabIndex = 1777
        Me.CmdSms.TabStop = False
        Me.CmdSms.Tag = "SMS"
        Me.CmdSms.Text = "SMS"
        Me.CmdSms.UseVisualStyleBackColor = True
        Me.CmdSms.Visible = False
        '
        'CmdAuto
        '
        Me.CmdAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmdAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdAuto.Location = New System.Drawing.Point(273, 499)
        Me.CmdAuto.Name = "CmdAuto"
        Me.CmdAuto.Size = New System.Drawing.Size(89, 30)
        Me.CmdAuto.TabIndex = 1776
        Me.CmdAuto.Tag = "&Auto-assign"
        Me.CmdAuto.Text = "Gán tự động"
        Me.CmdAuto.Visible = False
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmdSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSelectAll.Location = New System.Drawing.Point(92, 499)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(89, 30)
        Me.cmdSelectAll.TabIndex = 1775
        Me.cmdSelectAll.Tag = "&Select all"
        Me.cmdSelectAll.Text = "Chọn toàn bộ"
        Me.cmdSelectAll.Visible = False
        '
        'cmdUnSelectAll
        '
        Me.cmdUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmdUnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUnSelectAll.Location = New System.Drawing.Point(182, 499)
        Me.cmdUnSelectAll.Name = "cmdUnSelectAll"
        Me.cmdUnSelectAll.Size = New System.Drawing.Size(89, 30)
        Me.cmdUnSelectAll.TabIndex = 1774
        Me.cmdUnSelectAll.Tag = "&Deselect"
        Me.cmdUnSelectAll.Text = "Gỡ chọn"
        Me.cmdUnSelectAll.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmdRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRefresh.Location = New System.Drawing.Point(4, 499)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(89, 30)
        Me.cmdRefresh.TabIndex = 1773
        Me.cmdRefresh.Tag = "&Refresh"
        Me.cmdRefresh.Text = "&Làm tươi"
        Me.cmdRefresh.Visible = False
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1205, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 553)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1205, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 553)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1205, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 553)
        '
        'PopupMenuMasterGrid_1
        '
        Me.PopupMenuMasterGrid_1.Manager = Me.BarManager1
        Me.PopupMenuMasterGrid_1.Name = "PopupMenuMasterGrid_1"
        '
        'BEXEPXE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1205, 553)
        Me.Controls.Add(Me.CmdSms)
        Me.Controls.Add(Me.CmdAuto)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.cmdUnSelectAll)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.CmbbMa_Mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CmbbMa_Kx)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BEXEPXE"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.cmdRefresh, 0)
        Me.Controls.SetChildIndex(Me.cmdUnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.cmdSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmdAuto, 0)
        Me.Controls.SetChildIndex(Me.CmdSms, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Master_1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV_1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmbbMa_Mau As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbbMa_Kx As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmdSms As System.Windows.Forms.Button
    Friend WithEvents CmdAuto As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PopupMenuMasterGrid_1 As DevExpress.XtraBars.PopupMenu

End Class
