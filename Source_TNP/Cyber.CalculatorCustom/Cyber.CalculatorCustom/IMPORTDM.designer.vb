<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMPORTDM
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
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.CmdSelectFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.Master1 = New DevExpress.XtraGrid.GridControl()
        Me.Master1GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CbbM_Ma_DM = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdCheck = New System.Windows.Forms.Button()
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 492)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(978, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(778, 502)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(880, 502)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 65)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(72, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 507
        Me.LabM_Ngay_Ct1.Tag = "Date"
        Me.LabM_Ngay_Ct1.Text = "Ngày hiệu lực"
        Me.LabM_Ngay_Ct1.Visible = False
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(103, 61)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.Visible = False
        '
        'CmdSelectFile
        '
        Me.CmdSelectFile.Location = New System.Drawing.Point(863, 0)
        Me.CmdSelectFile.Name = "CmdSelectFile"
        Me.CmdSelectFile.Size = New System.Drawing.Size(113, 31)
        Me.CmdSelectFile.TabIndex = 2
        Me.CmdSelectFile.Tag = "Select file"
        Me.CmdSelectFile.Text = "Chọn File"
        Me.CmdSelectFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 510
        Me.Label1.Tag = "File Excel "
        Me.Label1.Text = "File Excel "
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(344, 2)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.ReadOnly = True
        Me.TxtFileName.Size = New System.Drawing.Size(503, 20)
        Me.TxtFileName.TabIndex = 1
        '
        'Master1
        '
        Me.Master1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1.Location = New System.Drawing.Point(0, 32)
        Me.Master1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master1.MainView = Me.Master1GRV
        Me.Master1.Name = "Master1"
        Me.Master1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master1.Size = New System.Drawing.Size(979, 463)
        Me.Master1.TabIndex = 513
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
        Me.Master1GRV.OptionsBehavior.Editable = False
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
        'CbbM_Ma_DM
        '
        Me.CbbM_Ma_DM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Ma_DM.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Ma_DM.FormattingEnabled = True
        Me.CbbM_Ma_DM.Location = New System.Drawing.Point(101, 2)
        Me.CbbM_Ma_DM.Name = "CbbM_Ma_DM"
        Me.CbbM_Ma_DM.Size = New System.Drawing.Size(180, 21)
        Me.CbbM_Ma_DM.TabIndex = 514
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 515
        Me.Label2.Tag = "Year select"
        Me.Label2.Text = "Chọn danh mục"
        '
        'CmdCheck
        '
        Me.CmdCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCheck.Location = New System.Drawing.Point(658, 502)
        Me.CmdCheck.Name = "CmdCheck"
        Me.CmdCheck.Size = New System.Drawing.Size(113, 31)
        Me.CmdCheck.TabIndex = 516
        Me.CmdCheck.Tag = "Select file"
        Me.CmdCheck.Text = "Kiểm tra dữ liệu"
        Me.CmdCheck.UseVisualStyleBackColor = True
        '
        'IMPORTDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(982, 556)
        Me.Controls.Add(Me.CmdCheck)
        Me.Controls.Add(Me.CbbM_Ma_DM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Master1)
        Me.Controls.Add(Me.TxtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdSelectFile)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "IMPORTDM"
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.CmdSelectFile, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtFileName, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Ma_DM, 0)
        Me.Controls.SetChildIndex(Me.CmdCheck, 0)
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents CmdSelectFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Master1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master1GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CbbM_Ma_DM As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CmdCheck As Windows.Forms.Button
End Class
