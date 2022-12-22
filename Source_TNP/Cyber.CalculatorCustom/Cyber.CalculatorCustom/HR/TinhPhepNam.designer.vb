<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TinhPhepNam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TinhPhepNam))
        Me.DetailGrid = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Detail1 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdTinhPhep = New DevExpress.XtraEditors.SimpleButton()
        Me.CBBMa_Dvcs = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdExport = New DevExpress.XtraEditors.SimpleButton()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Bp = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdChuyenPhep = New DevExpress.XtraEditors.SimpleButton()
        Me.DetailGrid.SuspendLayout()
        Me.Tab1.SuspendLayout()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 426)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(866, 16)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(760, 437)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.Size = New System.Drawing.Size(108, 30)
        Me.ButtOK.Text = "&Đẩy dữ liệu"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(958, 413)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        '
        'DetailGrid
        '
        Me.DetailGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailGrid.Controls.Add(Me.Tab1)
        Me.DetailGrid.Location = New System.Drawing.Point(2, 76)
        Me.DetailGrid.Name = "DetailGrid"
        Me.DetailGrid.Padding = New System.Drawing.Point(0, 0)
        Me.DetailGrid.SelectedIndex = 0
        Me.DetailGrid.Size = New System.Drawing.Size(866, 364)
        Me.DetailGrid.TabIndex = 9
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Detail1)
        Me.Tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(858, 338)
        Me.Tab1.TabIndex = 1
        Me.Tab1.Tag = "List"
        Me.Tab1.Text = "Danh sách"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'Detail1
        '
        Me.Detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail1.Location = New System.Drawing.Point(3, 3)
        Me.Detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail1.MainView = Me.DetailGRV1
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Size = New System.Drawing.Size(852, 332)
        Me.Detail1.TabIndex = 0
        Me.Detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV1, Me.GridView7})
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
        Me.DetailGRV1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV1.GridControl = Me.Detail1
        Me.DetailGRV1.GroupRowHeight = 30
        Me.DetailGRV1.Name = "DetailGRV1"
        Me.DetailGRV1.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV1.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV1.OptionsView.ShowGroupPanel = False
        Me.DetailGRV1.RowHeight = 21
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.Detail1
        Me.GridView7.Name = "GridView7"
        '
        'CmdTinhPhep
        '
        Me.CmdTinhPhep.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTinhPhep.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdTinhPhep.Appearance.Options.UseFont = True
        Me.CmdTinhPhep.Appearance.Options.UseForeColor = True
        Me.CmdTinhPhep.Image = Global.Cyber.CalculatorCustom.My.Resources.Resources.apply_16x16
        Me.CmdTinhPhep.Location = New System.Drawing.Point(653, 6)
        Me.CmdTinhPhep.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdTinhPhep.Name = "CmdTinhPhep"
        Me.CmdTinhPhep.Size = New System.Drawing.Size(127, 30)
        Me.CmdTinhPhep.TabIndex = 8
        Me.CmdTinhPhep.Text = "Tính phép năm"
        Me.CmdTinhPhep.Visible = False
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.CBBMa_Dvcs.FormattingEnabled = True
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(84, 3)
        Me.CBBMa_Dvcs.Name = "CBBMa_Dvcs"
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(348, 21)
        Me.CBBMa_Dvcs.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Tag = "Staff"
        Me.Label1.Text = "Đơn vị"
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.Image = Global.Cyber.CalculatorCustom.My.Resources.Resources.refresh2_16x16
        Me.CmdSearch.Location = New System.Drawing.Point(439, 37)
        Me.CmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(105, 30)
        Me.CmdSearch.TabIndex = 5
        Me.CmdSearch.Text = "&Lọc dữ liệu"
        '
        'CmdExport
        '
        Me.CmdExport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdExport.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CmdExport.Appearance.Options.UseFont = True
        Me.CmdExport.Appearance.Options.UseForeColor = True
        Me.CmdExport.Image = CType(resources.GetObject("CmdExport.Image"), System.Drawing.Image)
        Me.CmdExport.Location = New System.Drawing.Point(784, 37)
        Me.CmdExport.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(79, 31)
        Me.CmdExport.TabIndex = 64
        Me.CmdExport.Text = "&Export"
        Me.CmdExport.Visible = False
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(84, 26)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(99, 21)
        Me.CbbM_Nam.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 527
        Me.Label3.Tag = "Year"
        Me.Label3.Text = "Năm"
        '
        'TxtTen_Bp
        '
        Me.TxtTen_Bp.BackColor = System.Drawing.Color.White
        Me.TxtTen_Bp.Enabled = False
        Me.TxtTen_Bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp.Location = New System.Drawing.Point(189, 50)
        Me.TxtTen_Bp.Name = "TxtTen_Bp"
        Me.TxtTen_Bp.ReadOnly = True
        Me.TxtTen_Bp.Size = New System.Drawing.Size(243, 20)
        Me.TxtTen_Bp.TabIndex = 529
        Me.TxtTen_Bp.TabStop = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp._ActilookupPopup = False
        Me.TxtMa_Bp.CyberActilookupPopup = True
        Me.TxtMa_Bp.Dv_ListDetail = Nothing
        Me.TxtMa_Bp.Dv_Master = Nothing
        Me.TxtMa_Bp.FilterClient = ""
        Me.TxtMa_Bp.FilterSQL = ""
        Me.TxtMa_Bp.Location = New System.Drawing.Point(84, 50)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp.Size = New System.Drawing.Size(99, 20)
        Me.TxtMa_Bp.TabIndex = 4
        Me.TxtMa_Bp.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 530
        Me.Label4.Tag = "Warehouse"
        Me.Label4.Text = "Bộ phận"
        '
        'CmdChuyenPhep
        '
        Me.CmdChuyenPhep.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdChuyenPhep.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdChuyenPhep.Appearance.Options.UseFont = True
        Me.CmdChuyenPhep.Appearance.Options.UseForeColor = True
        Me.CmdChuyenPhep.Image = Global.Cyber.CalculatorCustom.My.Resources.Resources.apply_16x16
        Me.CmdChuyenPhep.Location = New System.Drawing.Point(547, 37)
        Me.CmdChuyenPhep.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdChuyenPhep.Name = "CmdChuyenPhep"
        Me.CmdChuyenPhep.Size = New System.Drawing.Size(112, 30)
        Me.CmdChuyenPhep.TabIndex = 531
        Me.CmdChuyenPhep.Text = "&Chuyển phép"
        '
        'TinhPhepNam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(868, 467)
        Me.Controls.Add(Me.CmdChuyenPhep)
        Me.Controls.Add(Me.TxtTen_Bp)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdExport)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBBMa_Dvcs)
        Me.Controls.Add(Me.CmdTinhPhep)
        Me.Controls.Add(Me.DetailGrid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TinhPhepNam"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.DetailGrid, 0)
        Me.Controls.SetChildIndex(Me.CmdTinhPhep, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.CmdExport, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp, 0)
        Me.Controls.SetChildIndex(Me.CmdChuyenPhep, 0)
        Me.DetailGrid.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetailGrid As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmdTinhPhep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBBMa_Dvcs As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CbbM_Nam As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtTen_Bp As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As SmLists.TxtLookup
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents CmdChuyenPhep As DevExpress.XtraEditors.SimpleButton
End Class
