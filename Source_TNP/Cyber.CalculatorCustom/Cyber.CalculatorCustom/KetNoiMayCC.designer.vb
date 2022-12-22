<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KetNoiMayCC
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
        Me.CmbbImportExcel = New System.Windows.Forms.Button()
        Me.Master1 = New DevExpress.XtraGrid.GridControl()
        Me.Master1GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_May = New System.Windows.Forms.TextBox()
        Me.TxtMa_May = New Cyber.SmLists.TxtLookup()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.CmdGetData = New System.Windows.Forms.Button()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ct = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_May.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 492)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1093, 8)
        Me.GroupBoxLine.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(893, 502)
        Me.ButtOK.TabIndex = 13
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Lưu dữ liệu"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(995, 502)
        Me.ButtExit.TabIndex = 14
        '
        'CmbbImportExcel
        '
        Me.CmbbImportExcel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmbbImportExcel.Location = New System.Drawing.Point(344, 82)
        Me.CmbbImportExcel.Name = "CmbbImportExcel"
        Me.CmbbImportExcel.Size = New System.Drawing.Size(104, 36)
        Me.CmbbImportExcel.TabIndex = 11
        Me.CmbbImportExcel.Tag = "&Import Excel"
        Me.CmbbImportExcel.Text = "&Import Excel"
        Me.CmbbImportExcel.UseVisualStyleBackColor = True
        '
        'Master1
        '
        Me.Master1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1.Location = New System.Drawing.Point(0, 124)
        Me.Master1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master1.MainView = Me.Master1GRV
        Me.Master1.Name = "Master1"
        Me.Master1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master1.Size = New System.Drawing.Size(1094, 371)
        Me.Master1.TabIndex = 12
        Me.Master1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master1GRV})
        '
        'Master1GRV
        '
        Me.Master1GRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master1GRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master1GRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master1GRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1GRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master1GRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master1GRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master1GRV.GridControl = Me.Master1
        Me.Master1GRV.GroupRowHeight = 30
        Me.Master1GRV.Name = "Master1GRV"
        Me.Master1GRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master1GRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master1GRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master1GRV.OptionsView.ColumnAutoWidth = False
        Me.Master1GRV.OptionsView.ShowGroupPanel = False
        Me.Master1GRV.RowHeight = 21
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 514
        Me.Label2.Tag = "Warehouse"
        Me.Label2.Text = "Máy chấm công"
        '
        'TxtTen_May
        '
        Me.TxtTen_May.BackColor = System.Drawing.Color.White
        Me.TxtTen_May.Enabled = False
        Me.TxtTen_May.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_May.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_May.Location = New System.Drawing.Point(225, 31)
        Me.TxtTen_May.Name = "TxtTen_May"
        Me.TxtTen_May.ReadOnly = True
        Me.TxtTen_May.Size = New System.Drawing.Size(373, 22)
        Me.TxtTen_May.TabIndex = 15
        Me.TxtTen_May.TabStop = False
        '
        'TxtMa_May
        '
        Me.TxtMa_May._ActilookupPopup = False
        Me.TxtMa_May.CyberActilookupPopup = True
        Me.TxtMa_May.Dv_ListDetail = Nothing
        Me.TxtMa_May.Dv_Master = Nothing
        Me.TxtMa_May.FilterClient = ""
        Me.TxtMa_May.FilterSQL = ""
        Me.TxtMa_May.Location = New System.Drawing.Point(96, 31)
        Me.TxtMa_May.Name = "TxtMa_May"
        Me.TxtMa_May.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_May.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_May.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_May.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_May.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_May.Size = New System.Drawing.Size(124, 20)
        Me.TxtMa_May.TabIndex = 1
        Me.TxtMa_May.Table_Name = ""
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(225, 82)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(113, 36)
        Me.CmbbXuatExcel.TabIndex = 10
        Me.CmbbXuatExcel.Tag = "&Export Excel"
        Me.CmbbXuatExcel.Text = "&Export Excel"
        Me.CmbbXuatExcel.UseVisualStyleBackColor = True
        '
        'CmdGetData
        '
        Me.CmdGetData.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGetData.Location = New System.Drawing.Point(95, 82)
        Me.CmdGetData.Name = "CmdGetData"
        Me.CmdGetData.Size = New System.Drawing.Size(124, 36)
        Me.CmdGetData.TabIndex = 7
        Me.CmdGetData.Tag = "Get data and Count Mip"
        Me.CmdGetData.Text = "Lấy dữ liệu in/out"
        Me.CmdGetData.UseVisualStyleBackColor = True
        '
        'TxtIP
        '
        Me.TxtIP.BackColor = System.Drawing.Color.White
        Me.TxtIP.Enabled = False
        Me.TxtIP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIP.ForeColor = System.Drawing.Color.Navy
        Me.TxtIP.Location = New System.Drawing.Point(96, 54)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.ReadOnly = True
        Me.TxtIP.Size = New System.Drawing.Size(124, 22)
        Me.TxtIP.TabIndex = 2
        Me.TxtIP.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 14)
        Me.Label1.TabIndex = 516
        Me.Label1.Tag = "Warehouse"
        Me.Label1.Text = "Địa chỉ IP/Port"
        '
        'TxtPort
        '
        Me.TxtPort.BackColor = System.Drawing.Color.White
        Me.TxtPort.Enabled = False
        Me.TxtPort.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPort.ForeColor = System.Drawing.Color.Navy
        Me.TxtPort.Location = New System.Drawing.Point(225, 54)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.ReadOnly = True
        Me.TxtPort.Size = New System.Drawing.Size(113, 22)
        Me.TxtPort.TabIndex = 517
        Me.TxtPort.TabStop = False
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Flags = 0
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNgay_Ct.IsAllowResize = False
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(96, 7)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(124, 21)
        Me.TxtNgay_Ct.TabIndex = 0
        Me.TxtNgay_Ct.Value = "28/12/2021"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 520
        Me.Label3.Tag = "Warehouse"
        Me.Label3.Text = "Ngày lấy"
        '
        'KetNoiMayCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1097, 556)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdGetData)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Controls.Add(Me.TxtTen_May)
        Me.Controls.Add(Me.TxtMa_May)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Master1)
        Me.Controls.Add(Me.CmbbImportExcel)
        Me.Name = "KetNoiMayCC"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.CmbbImportExcel, 0)
        Me.Controls.SetChildIndex(Me.Master1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_May, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_May, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdGetData, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtIP, 0)
        Me.Controls.SetChildIndex(Me.TxtPort, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_May.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbbImportExcel As System.Windows.Forms.Button
    Friend WithEvents Master1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master1GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_May As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_May As Cyber.SmLists.TxtLookup
    Friend WithEvents CmbbXuatExcel As System.Windows.Forms.Button
    Friend WithEvents CmdGetData As System.Windows.Forms.Button
    Friend WithEvents TxtIP As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtPort As Windows.Forms.TextBox
    Friend WithEvents TxtNgay_Ct As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
