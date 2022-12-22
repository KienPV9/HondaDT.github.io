<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTinhDD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTinhDD))
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.ChkHachToan = New System.Windows.Forms.CheckBox()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MasterKcVt = New DevExpress.XtraGrid.GridControl()
        Me.MasterKcVTGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MasterDdVT = New DevExpress.XtraGrid.GridControl()
        Me.MasterDdVTGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CmdTinhToan = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MasterKcVt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterKcVTGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.MasterDdVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDdVTGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 502)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1024, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(814, 430)
        Me.ButtOK.TabIndex = 9
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(916, 7)
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(102, 33)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(132, 21)
        Me.CbbM_Nam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(102, 9)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(132, 21)
        Me.CbbM_Thang1.TabIndex = 1
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(46, 12)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(38, 13)
        Me.LabM_month1.TabIndex = 0
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Tháng"
        '
        'ChkHachToan
        '
        Me.ChkHachToan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHachToan.AutoSize = True
        Me.ChkHachToan.ForeColor = System.Drawing.Color.Navy
        Me.ChkHachToan.Location = New System.Drawing.Point(665, 43)
        Me.ChkHachToan.Name = "ChkHachToan"
        Me.ChkHachToan.Size = New System.Drawing.Size(273, 17)
        Me.ChkHachToan.TabIndex = 7
        Me.ChkHachToan.Tag = "Acc debit"
        Me.ChkHachToan.Text = "Bạn có tạo phiếu hạch toán kết chuyển hay không?"
        Me.ChkHachToan.UseVisualStyleBackColor = True
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
        Me.TabPage2.Controls.Add(Me.MasterKcVt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kết chuyển trong kỳ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MasterKcVt
        '
        Me.MasterKcVt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterKcVt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterKcVt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterKcVt.Location = New System.Drawing.Point(3, 3)
        Me.MasterKcVt.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterKcVt.MainView = Me.MasterKcVTGRV
        Me.MasterKcVt.Name = "MasterKcVt"
        Me.MasterKcVt.Size = New System.Drawing.Size(1016, 439)
        Me.MasterKcVt.TabIndex = 13
        Me.MasterKcVt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterKcVTGRV})
        '
        'MasterKcVTGRV
        '
        Me.MasterKcVTGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterKcVTGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterKcVTGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterKcVTGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterKcVTGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterKcVTGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterKcVTGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterKcVTGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterKcVTGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterKcVTGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterKcVTGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterKcVTGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterKcVTGRV.GridControl = Me.MasterKcVt
        Me.MasterKcVTGRV.GroupRowHeight = 30
        Me.MasterKcVTGRV.Name = "MasterKcVTGRV"
        Me.MasterKcVTGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterKcVTGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterKcVTGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterKcVTGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterKcVTGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterKcVTGRV.OptionsView.ShowAutoFilterRow = True
        Me.MasterKcVTGRV.OptionsView.ShowGroupPanel = False
        Me.MasterKcVTGRV.RowHeight = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MasterDdVT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1022, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dở dang vật tư, phụ tùng"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MasterDdVT
        '
        Me.MasterDdVT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterDdVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterDdVT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDdVT.Location = New System.Drawing.Point(0, 0)
        Me.MasterDdVT.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterDdVT.MainView = Me.MasterDdVTGRV
        Me.MasterDdVT.Name = "MasterDdVT"
        Me.MasterDdVT.Size = New System.Drawing.Size(1100, 419)
        Me.MasterDdVT.TabIndex = 12
        Me.MasterDdVT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterDdVTGRV})
        '
        'MasterDdVTGRV
        '
        Me.MasterDdVTGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterDdVTGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterDdVTGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterDdVTGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterDdVTGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterDdVTGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterDdVTGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterDdVTGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterDdVTGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDdVTGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterDdVTGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterDdVTGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterDdVTGRV.GridControl = Me.MasterDdVT
        Me.MasterDdVTGRV.GroupRowHeight = 30
        Me.MasterDdVTGRV.Name = "MasterDdVTGRV"
        Me.MasterDdVTGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterDdVTGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterDdVTGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterDdVTGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterDdVTGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterDdVTGRV.OptionsView.ShowAutoFilterRow = True
        Me.MasterDdVTGRV.OptionsView.ShowGroupPanel = False
        Me.MasterDdVTGRV.RowHeight = 21
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 471)
        Me.TabControl1.TabIndex = 8
        '
        'CmdTinhToan
        '
        Me.CmdTinhToan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTinhToan.Image = CType(resources.GetObject("CmdTinhToan.Image"), System.Drawing.Image)
        Me.CmdTinhToan.Location = New System.Drawing.Point(665, 7)
        Me.CmdTinhToan.Name = "CmdTinhToan"
        Me.CmdTinhToan.Size = New System.Drawing.Size(123, 30)
        Me.CmdTinhToan.TabIndex = 46
        Me.CmdTinhToan.Text = "Tính toán"
        '
        'CmdRefresh
        '
        Me.CmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRefresh.Image = CType(resources.GetObject("CmdRefresh.Image"), System.Drawing.Image)
        Me.CmdRefresh.Location = New System.Drawing.Point(791, 7)
        Me.CmdRefresh.Name = "CmdRefresh"
        Me.CmdRefresh.Size = New System.Drawing.Size(123, 30)
        Me.CmdRefresh.TabIndex = 47
        Me.CmdRefresh.Text = "Làm tươi dữ liệu"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1028, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'FrmTinhDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1028, 566)
        Me.Controls.Add(Me.CmdRefresh)
        Me.Controls.Add(Me.CmdTinhToan)
        Me.Controls.Add(Me.ChkHachToan)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmTinhDD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.ChkHachToan, 0)
        Me.Controls.SetChildIndex(Me.CmdTinhToan, 0)
        Me.Controls.SetChildIndex(Me.CmdRefresh, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MasterKcVt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterKcVTGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MasterDdVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDdVTGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents ChkHachToan As Windows.Forms.CheckBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents CmdTinhToan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MasterDdVT As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterDdVTGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterKcVt As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterKcVTGRV As DevExpress.XtraGrid.Views.Grid.GridView
End Class
