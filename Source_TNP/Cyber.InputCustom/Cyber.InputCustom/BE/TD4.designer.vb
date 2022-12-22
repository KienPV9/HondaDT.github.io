<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TD4
    Inherits Cyber.From.Frmvoucher

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
        Me.CmbMa_GD = New System.Windows.Forms.ComboBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabMa_Quyen = New System.Windows.Forms.Label()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.TxtSo_Ct = New System.Windows.Forms.TextBox()
        Me.LabMa_NT = New System.Windows.Forms.Label()
        Me.TxtTy_Gia = New ClsTextBox.txtTy_Gia()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtMa_NT = New System.Windows.Forms.TextBox()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabTy_gia = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_SO_LUONG = New ClsTextBox.txtTien_NT()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.TxtTen_Hs_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_H = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGio_CT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ve = New ClsTextBox.txtDate()
        Me.LabNgay_Ve = New System.Windows.Forms.Label()
        Me.LabGio_Ve = New System.Windows.Forms.Label()
        Me.TxtGio_Ve = New System.Windows.Forms.TextBox()
        Me.LabMa_khoN = New System.Windows.Forms.Label()
        Me.TxtTen_KhoN = New System.Windows.Forms.TextBox()
        Me.TxtMa_KhoN = New Cyber.SmLists.TxtLookup()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_Kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kho = New Cyber.SmLists.TxtLookup()
        Me.ChkIs_Dc = New System.Windows.Forms.CheckBox()
        Me.TxtTen_GD = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_BL = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Hs_BL = New System.Windows.Forms.TextBox()
        Me.LabMa_HS_H = New System.Windows.Forms.Label()
        Me.ChkBL_TT = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtT_CL_TT = New ClsTextBox.txtTien_NT()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtT_Da_TT = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_HD_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_HD_H = New Cyber.SmLists.TxtLookup()
        Me.labLy_Do = New System.Windows.Forms.Label()
        Me.CmbLoai_Ly_Do = New System.Windows.Forms.ComboBox()
        Me.TxtLy_Do = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_TD3_H = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TD3_H = New System.Windows.Forms.TextBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KhoN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_BL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TD3_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEdit
        '
        Me.CmdEdit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdEdit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEdit.Appearance.Options.UseBackColor = True
        Me.CmdEdit.Appearance.Options.UseFont = True
        Me.CmdEdit.Appearance.Options.UseForeColor = True
        Me.CmdEdit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdEdit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdEdit.Location = New System.Drawing.Point(239, 536)
        Me.CmdEdit.Margin = New System.Windows.Forms.Padding(4)
        '
        'CmdSave
        '
        Me.CmdSave.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSave.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSave.Appearance.Options.UseBackColor = True
        Me.CmdSave.Appearance.Options.UseFont = True
        Me.CmdSave.Appearance.Options.UseForeColor = True
        Me.CmdSave.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSave.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSave.Location = New System.Drawing.Point(-1, 536)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSave.TabIndex = 15
        '
        'CmdView
        '
        Me.CmdView.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdView.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdView.Appearance.Options.UseBackColor = True
        Me.CmdView.Appearance.Options.UseFont = True
        Me.CmdView.Appearance.Options.UseForeColor = True
        Me.CmdView.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdView.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdView.Location = New System.Drawing.Point(478, 536)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdView.TabIndex = 21
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 517)
        Me.LabMa_Post.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'CmdSms
        '
        Me.CmdSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSms.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSms.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSms.Appearance.Options.UseBackColor = True
        Me.CmdSms.Appearance.Options.UseFont = True
        Me.CmdSms.Appearance.Options.UseForeColor = True
        Me.CmdSms.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSms.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSms.Location = New System.Drawing.Point(809, 535)
        Me.CmdSms.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSms.TabIndex = 24
        '
        'CmdImport
        '
        Me.CmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdImport.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdImport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdImport.Appearance.Options.UseBackColor = True
        Me.CmdImport.Appearance.Options.UseFont = True
        Me.CmdImport.Appearance.Options.UseForeColor = True
        Me.CmdImport.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdImport.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdImport.Location = New System.Drawing.Point(854, 535)
        Me.CmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdImport.TabIndex = 25
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 513)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Post.TabIndex = 14
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseBackColor = True
        Me.CmdExit.Appearance.Options.UseFont = True
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdExit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(637, 536)
        Me.CmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdExit.TabIndex = 23
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseBackColor = True
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSearch.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSearch.Location = New System.Drawing.Point(558, 536)
        Me.CmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSearch.TabIndex = 22
        '
        'CmdCopy
        '
        Me.CmdCopy.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCopy.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCopy.Appearance.Options.UseBackColor = True
        Me.CmdCopy.Appearance.Options.UseFont = True
        Me.CmdCopy.Appearance.Options.UseForeColor = True
        Me.CmdCopy.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCopy.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCopy.Location = New System.Drawing.Point(399, 536)
        Me.CmdCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCopy.TabIndex = 20
        '
        'CmdDelete
        '
        Me.CmdDelete.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdDelete.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdDelete.Appearance.Options.UseBackColor = True
        Me.CmdDelete.Appearance.Options.UseFont = True
        Me.CmdDelete.Appearance.Options.UseForeColor = True
        Me.CmdDelete.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdDelete.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdDelete.Location = New System.Drawing.Point(319, 536)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdDelete.TabIndex = 19
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseBackColor = True
        Me.CmdPrint.Appearance.Options.UseFont = True
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPrint.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(159, 536)
        Me.CmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPrint.TabIndex = 17
        '
        'CmdNew
        '
        Me.CmdNew.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdNew.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdNew.Appearance.Options.UseBackColor = True
        Me.CmdNew.Appearance.Options.UseFont = True
        Me.CmdNew.Appearance.Options.UseForeColor = True
        Me.CmdNew.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdNew.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdNew.Location = New System.Drawing.Point(79, 536)
        Me.CmdNew.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNew.TabIndex = 16
        '
        'CmdCancel
        '
        Me.CmdCancel.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCancel.Appearance.Options.UseBackColor = True
        Me.CmdCancel.Appearance.Options.UseFont = True
        Me.CmdCancel.Appearance.Options.UseForeColor = True
        Me.CmdCancel.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCancel.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCancel.Location = New System.Drawing.Point(239, 536)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.TabIndex = 18
        '
        'CmdPhan_Bo
        '
        Me.CmdPhan_Bo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdPhan_Bo.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPhan_Bo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPhan_Bo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPhan_Bo.Appearance.Options.UseBackColor = True
        Me.CmdPhan_Bo.Appearance.Options.UseFont = True
        Me.CmdPhan_Bo.Appearance.Options.UseForeColor = True
        Me.CmdPhan_Bo.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPhan_Bo.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(748, 535)
        Me.CmdPhan_Bo.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(-103, 462)
        Me.TxtUser_id.Margin = New System.Windows.Forms.Padding(4)
        '
        'CmbMa_GD
        '
        Me.CmbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_GD.FormattingEnabled = True
        Me.CmbMa_GD.Location = New System.Drawing.Point(263, 33)
        Me.CmbMa_GD.Name = "CmbMa_GD"
        Me.CmbMa_GD.Size = New System.Drawing.Size(323, 23)
        Me.CmbMa_GD.TabIndex = 33
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(478, 35)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Quyen.TabIndex = 4
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(404, 39)
        Me.LabMa_Quyen.Name = "LabMa_Quyen"
        Me.LabMa_Quyen.Size = New System.Drawing.Size(55, 13)
        Me.LabMa_Quyen.TabIndex = 145
        Me.LabMa_Quyen.Tag = "Book no."
        Me.LabMa_Quyen.Text = "Quyển số"
        Me.LabMa_Quyen.Visible = False
        '
        'LabNgay_LCt
        '
        Me.LabNgay_LCt.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_LCt.Location = New System.Drawing.Point(1, 42)
        Me.LabNgay_LCt.Name = "LabNgay_LCt"
        Me.LabNgay_LCt.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_LCt.TabIndex = 144
        Me.LabNgay_LCt.Tag = "Create date"
        Me.LabNgay_LCt.Text = "Ngày Lập"
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(1, 62)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày ra"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(158, 164)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(346, 37)
        Me.TxtDien_Giai.TabIndex = 27
        Me.TxtDien_Giai.TabStop = False
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(82, 176)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(72, 14)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Reason"
        Me.LabDien_Giai.Text = "Lý do"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(170, 38)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(71, 15)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Voucher style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.AutoSize = True
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(337, 62)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(48, 13)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số phiếu"
        '
        'TxtSo_Ct
        '
        Me.TxtSo_Ct.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ct.Location = New System.Drawing.Point(391, 59)
        Me.TxtSo_Ct.Name = "TxtSo_Ct"
        Me.TxtSo_Ct.Size = New System.Drawing.Size(112, 21)
        Me.TxtSo_Ct.TabIndex = 3
        Me.TxtSo_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_NT
        '
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(774, 42)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
        Me.LabMa_NT.Visible = False
        '
        'TxtTy_Gia
        '
        Me.TxtTy_Gia.AllowNegative = True
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(835, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 32
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTy_Gia.Visible = False
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(80, 37)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_LCt.TabIndex = 0
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(80, 59)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_Ct.TabIndex = 1
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(835, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 31
        Me.TxtMa_NT.TabStop = False
        Me.TxtMa_NT.Visible = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(1, 276)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(928, 231)
        Me.Detail.TabIndex = 13
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
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
        'LabTy_gia
        '
        Me.LabTy_gia.BackColor = System.Drawing.Color.Transparent
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(774, 61)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(55, 17)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        Me.LabTy_gia.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(10, 82)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(912, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(306, 481)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien_NT.TabIndex = 158
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT.Visible = False
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(434, 481)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_Tien.TabIndex = 159
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien.Visible = False
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(212, 487)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(78, 14)
        Me.LabT_TT_NT.TabIndex = 160
        Me.LabT_TT_NT.Tag = "Total"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        Me.LabT_TT_NT.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(74, 541)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Dvcs.TabIndex = 161
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(47, 541)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 162
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'TxtLenh_RO
        '
        Me.TxtLenh_RO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_RO.Location = New System.Drawing.Point(686, 37)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(22, 21)
        Me.TxtLenh_RO.TabIndex = 168
        Me.TxtLenh_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_RO.Visible = False
        '
        'TxtLenh_PO
        '
        Me.TxtLenh_PO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_PO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_PO.Location = New System.Drawing.Point(658, 37)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(22, 21)
        Me.TxtLenh_PO.TabIndex = 4
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(714, 37)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(22, 21)
        Me.TxtLenh_SO.TabIndex = 172
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(44, 487)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(78, 14)
        Me.LabT_So_Luong.TabIndex = 175
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng số lượng"
        Me.LabT_So_Luong.Visible = False
        '
        'TxtT_SO_LUONG
        '
        Me.TxtT_SO_LUONG.AllowNegative = True
        Me.TxtT_SO_LUONG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_SO_LUONG.BackColor = System.Drawing.Color.White
        Me.TxtT_SO_LUONG.Flags = 7680
        Me.TxtT_SO_LUONG.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_SO_LUONG.InputMask = "### ### ### ### ###.#"
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(134, 481)
        Me.TxtT_SO_LUONG.MaxWholeDigits = 16
        Me.TxtT_SO_LUONG.Name = "TxtT_SO_LUONG"
        Me.TxtT_SO_LUONG.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.ReadOnly = True
        Me.TxtT_SO_LUONG.Size = New System.Drawing.Size(75, 20)
        Me.TxtT_SO_LUONG.TabIndex = 174
        Me.TxtT_SO_LUONG.Text = "0.0"
        Me.TxtT_SO_LUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_SO_LUONG.Visible = False
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(630, 37)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(22, 21)
        Me.TxtLenh_Vt.TabIndex = 250
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'TxtTen_Hs_H
        '
        Me.TxtTen_Hs_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_H.Enabled = False
        Me.TxtTen_Hs_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Hs_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_H.Location = New System.Drawing.Point(269, 203)
        Me.TxtTen_Hs_H.Name = "TxtTen_Hs_H"
        Me.TxtTen_Hs_H.ReadOnly = True
        Me.TxtTen_Hs_H.Size = New System.Drawing.Size(235, 20)
        Me.TxtTen_Hs_H.TabIndex = 256
        Me.TxtTen_Hs_H.TabStop = False
        '
        'TxtMa_Hs_H
        '
        Me.TxtMa_Hs_H._ActilookupPopup = False
        Me.TxtMa_Hs_H.CyberActilookupPopup = True
        Me.TxtMa_Hs_H.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_H.Dv_Master = Nothing
        Me.TxtMa_Hs_H.FilterClient = ""
        Me.TxtMa_Hs_H.FilterSQL = ""
        Me.TxtMa_Hs_H.Location = New System.Drawing.Point(158, 203)
        Me.TxtMa_Hs_H.Name = "TxtMa_Hs_H"
        Me.TxtMa_Hs_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Hs_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Hs_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_H.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa_Hs_H.TabIndex = 28
        Me.TxtMa_Hs_H.Table_Name = ""
        Me.TxtMa_Hs_H.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(82, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 255
        Me.Label5.Tag = "Employee"
        Me.Label5.Text = "Nhân viên"
        '
        'TxtTen_BP_H
        '
        Me.TxtTen_BP_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_BP_H.Enabled = False
        Me.TxtTen_BP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP_H.Location = New System.Drawing.Point(269, 226)
        Me.TxtTen_BP_H.Name = "TxtTen_BP_H"
        Me.TxtTen_BP_H.ReadOnly = True
        Me.TxtTen_BP_H.Size = New System.Drawing.Size(235, 20)
        Me.TxtTen_BP_H.TabIndex = 254
        Me.TxtTen_BP_H.TabStop = False
        '
        'TxtMa_BP_H
        '
        Me.TxtMa_BP_H._ActilookupPopup = False
        Me.TxtMa_BP_H.CyberActilookupPopup = True
        Me.TxtMa_BP_H.Dv_ListDetail = Nothing
        Me.TxtMa_BP_H.Dv_Master = Nothing
        Me.TxtMa_BP_H.FilterClient = ""
        Me.TxtMa_BP_H.FilterSQL = ""
        Me.TxtMa_BP_H.Location = New System.Drawing.Point(158, 226)
        Me.TxtMa_BP_H.Name = "TxtMa_BP_H"
        Me.TxtMa_BP_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_BP_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP_H.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa_BP_H.TabIndex = 29
        Me.TxtMa_BP_H.Table_Name = ""
        Me.TxtMa_BP_H.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(82, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 253
        Me.Label4.Tag = "Dept."
        Me.Label4.Text = "Bộ phận"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(171, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 258
        Me.Label1.Tag = "Go out time"
        Me.Label1.Text = "Giờ ra"
        '
        'TxtGio_CT
        '
        Me.TxtGio_CT.BackColor = System.Drawing.Color.White
        Me.TxtGio_CT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGio_CT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGio_CT.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_CT.Location = New System.Drawing.Point(263, 59)
        Me.TxtGio_CT.Name = "TxtGio_CT"
        Me.TxtGio_CT.Size = New System.Drawing.Size(54, 21)
        Me.TxtGio_CT.TabIndex = 2
        Me.TxtGio_CT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(82, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 259
        Me.Label2.Tag = "VIN Id"
        Me.Label2.Text = "Số khung"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(158, 140)
        Me.TxtMa_Xe.Multiline = True
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(346, 20)
        Me.TxtMa_Xe.TabIndex = 26
        Me.TxtMa_Xe.TabStop = False
        '
        'TxtNgay_Ve
        '
        Me.TxtNgay_Ve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Ve.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ve.Flags = 65536
        Me.TxtNgay_Ve.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ve.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ve.isEmpty = True
        Me.TxtNgay_Ve.Location = New System.Drawing.Point(584, 90)
        Me.TxtNgay_Ve.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ve.MaxLength = 10
        Me.TxtNgay_Ve.Name = "TxtNgay_Ve"
        Me.TxtNgay_Ve.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ve.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ve.ReadOnly = True
        Me.TxtNgay_Ve.ShowDayBeforeMonth = False
        Me.TxtNgay_Ve.Size = New System.Drawing.Size(92, 21)
        Me.TxtNgay_Ve.TabIndex = 6
        Me.TxtNgay_Ve.Text = "18/09/2011"
        Me.TxtNgay_Ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ve.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'LabNgay_Ve
        '
        Me.LabNgay_Ve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabNgay_Ve.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ve.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ve.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ve.Location = New System.Drawing.Point(520, 94)
        Me.LabNgay_Ve.Name = "LabNgay_Ve"
        Me.LabNgay_Ve.Size = New System.Drawing.Size(74, 13)
        Me.LabNgay_Ve.TabIndex = 262
        Me.LabNgay_Ve.Tag = "Comebakc prediction"
        Me.LabNgay_Ve.Text = "Dự kiến về"
        '
        'LabGio_Ve
        '
        Me.LabGio_Ve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabGio_Ve.BackColor = System.Drawing.Color.Transparent
        Me.LabGio_Ve.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabGio_Ve.ForeColor = System.Drawing.Color.Navy
        Me.LabGio_Ve.Location = New System.Drawing.Point(730, 94)
        Me.LabGio_Ve.Name = "LabGio_Ve"
        Me.LabGio_Ve.Size = New System.Drawing.Size(52, 13)
        Me.LabGio_Ve.TabIndex = 264
        Me.LabGio_Ve.Tag = "Comeback time"
        Me.LabGio_Ve.Text = "Giờ về"
        '
        'TxtGio_Ve
        '
        Me.TxtGio_Ve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGio_Ve.BackColor = System.Drawing.Color.White
        Me.TxtGio_Ve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGio_Ve.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGio_Ve.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_Ve.Location = New System.Drawing.Point(788, 90)
        Me.TxtGio_Ve.Name = "TxtGio_Ve"
        Me.TxtGio_Ve.Size = New System.Drawing.Size(88, 21)
        Me.TxtGio_Ve.TabIndex = 7
        Me.TxtGio_Ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_khoN
        '
        Me.LabMa_khoN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_khoN.AutoSize = True
        Me.LabMa_khoN.Location = New System.Drawing.Point(520, 230)
        Me.LabMa_khoN.Name = "LabMa_khoN"
        Me.LabMa_khoN.Size = New System.Drawing.Size(53, 13)
        Me.LabMa_khoN.TabIndex = 270
        Me.LabMa_khoN.Tag = "Import"
        Me.LabMa_khoN.Text = "Kho nhập"
        '
        'TxtTen_KhoN
        '
        Me.TxtTen_KhoN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_KhoN.BackColor = System.Drawing.Color.White
        Me.TxtTen_KhoN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KhoN.Location = New System.Drawing.Point(669, 226)
        Me.TxtTen_KhoN.Name = "TxtTen_KhoN"
        Me.TxtTen_KhoN.ReadOnly = True
        Me.TxtTen_KhoN.Size = New System.Drawing.Size(254, 20)
        Me.TxtTen_KhoN.TabIndex = 269
        Me.TxtTen_KhoN.TabStop = False
        '
        'TxtMa_KhoN
        '
        Me.TxtMa_KhoN._ActilookupPopup = False
        Me.TxtMa_KhoN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_KhoN.CyberActilookupPopup = True
        Me.TxtMa_KhoN.Dv_ListDetail = Nothing
        Me.TxtMa_KhoN.Dv_Master = Nothing
        Me.TxtMa_KhoN.FilterClient = ""
        Me.TxtMa_KhoN.FilterSQL = ""
        Me.TxtMa_KhoN.Location = New System.Drawing.Point(584, 226)
        Me.TxtMa_KhoN.Name = "TxtMa_KhoN"
        Me.TxtMa_KhoN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KhoN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KhoN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KhoN.Size = New System.Drawing.Size(81, 20)
        Me.TxtMa_KhoN.TabIndex = 12
        Me.TxtMa_KhoN.Table_Name = ""
        Me.TxtMa_KhoN.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_kho.AutoSize = True
        Me.LabMa_kho.Location = New System.Drawing.Point(520, 207)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(49, 13)
        Me.LabMa_kho.TabIndex = 268
        Me.LabMa_kho.Tag = "Export"
        Me.LabMa_kho.Text = "Kho xuất"
        '
        'TxtTen_Kho
        '
        Me.TxtTen_Kho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kho.Location = New System.Drawing.Point(669, 203)
        Me.TxtTen_Kho.Name = "TxtTen_Kho"
        Me.TxtTen_Kho.ReadOnly = True
        Me.TxtTen_Kho.Size = New System.Drawing.Size(254, 20)
        Me.TxtTen_Kho.TabIndex = 267
        Me.TxtTen_Kho.TabStop = False
        '
        'TxtMa_Kho
        '
        Me.TxtMa_Kho._ActilookupPopup = False
        Me.TxtMa_Kho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Kho.CyberActilookupPopup = True
        Me.TxtMa_Kho.Dv_ListDetail = Nothing
        Me.TxtMa_Kho.Dv_Master = Nothing
        Me.TxtMa_Kho.FilterClient = ""
        Me.TxtMa_Kho.FilterSQL = ""
        Me.TxtMa_Kho.Location = New System.Drawing.Point(584, 203)
        Me.TxtMa_Kho.Name = "TxtMa_Kho"
        Me.TxtMa_Kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kho.Size = New System.Drawing.Size(81, 20)
        Me.TxtMa_Kho.TabIndex = 11
        Me.TxtMa_Kho.Table_Name = ""
        Me.TxtMa_Kho.TabStop = False
        '
        'ChkIs_Dc
        '
        Me.ChkIs_Dc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_Dc.AutoSize = True
        Me.ChkIs_Dc.Location = New System.Drawing.Point(520, 175)
        Me.ChkIs_Dc.Name = "ChkIs_Dc"
        Me.ChkIs_Dc.Size = New System.Drawing.Size(97, 17)
        Me.ChkIs_Dc.TabIndex = 10
        Me.ChkIs_Dc.Tag = "Stock transfer"
        Me.ChkIs_Dc.Text = "Chuyển kho xe"
        Me.ChkIs_Dc.UseVisualStyleBackColor = True
        '
        'TxtTen_GD
        '
        Me.TxtTen_GD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_GD.BackColor = System.Drawing.Color.White
        Me.TxtTen_GD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_GD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_GD.Location = New System.Drawing.Point(835, 169)
        Me.TxtTen_GD.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_GD.Name = "TxtTen_GD"
        Me.TxtTen_GD.Size = New System.Drawing.Size(63, 23)
        Me.TxtTen_GD.TabIndex = 1785
        Me.TxtTen_GD.Visible = False
        '
        'TxtMa_Hs_BL
        '
        Me.TxtMa_Hs_BL._ActilookupPopup = False
        Me.TxtMa_Hs_BL.CyberActilookupPopup = True
        Me.TxtMa_Hs_BL.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_BL.Dv_Master = Nothing
        Me.TxtMa_Hs_BL.FilterClient = ""
        Me.TxtMa_Hs_BL.FilterSQL = ""
        Me.TxtMa_Hs_BL.Location = New System.Drawing.Point(158, 249)
        Me.TxtMa_Hs_BL.Name = "TxtMa_Hs_BL"
        Me.TxtMa_Hs_BL.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs_BL.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_BL.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs_BL.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_BL.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Hs_BL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_BL.Size = New System.Drawing.Size(107, 22)
        Me.TxtMa_Hs_BL.TabIndex = 30
        Me.TxtMa_Hs_BL.Table_Name = ""
        Me.TxtMa_Hs_BL.TabStop = False
        '
        'TxtTen_Hs_BL
        '
        Me.TxtTen_Hs_BL.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_BL.Enabled = False
        Me.TxtTen_Hs_BL.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_BL.Location = New System.Drawing.Point(269, 250)
        Me.TxtTen_Hs_BL.Name = "TxtTen_Hs_BL"
        Me.TxtTen_Hs_BL.ReadOnly = True
        Me.TxtTen_Hs_BL.Size = New System.Drawing.Size(235, 20)
        Me.TxtTen_Hs_BL.TabIndex = 1787
        Me.TxtTen_Hs_BL.TabStop = False
        Me.TxtTen_Hs_BL.Tag = ""
        '
        'LabMa_HS_H
        '
        Me.LabMa_HS_H.AutoSize = True
        Me.LabMa_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_HS_H.ForeColor = System.Drawing.Color.Red
        Me.LabMa_HS_H.Location = New System.Drawing.Point(35, 254)
        Me.LabMa_HS_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_HS_H.Name = "LabMa_HS_H"
        Me.LabMa_HS_H.Size = New System.Drawing.Size(120, 13)
        Me.LabMa_HS_H.TabIndex = 18
        Me.LabMa_HS_H.Tag = "Sponsor"
        Me.LabMa_HS_H.Text = "Người bảo lãnh (BL)"
        '
        'ChkBL_TT
        '
        Me.ChkBL_TT.AutoSize = True
        Me.ChkBL_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBL_TT.ForeColor = System.Drawing.Color.Red
        Me.ChkBL_TT.Location = New System.Drawing.Point(16, 253)
        Me.ChkBL_TT.Name = "ChkBL_TT"
        Me.ChkBL_TT.Size = New System.Drawing.Size(15, 14)
        Me.ChkBL_TT.TabIndex = 18
        Me.ChkBL_TT.TabStop = False
        Me.ChkBL_TT.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(707, 515)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 1795
        Me.Label16.Tag = "Remaining"
        Me.Label16.Text = "Còn lại"
        '
        'TxtT_CL_TT
        '
        Me.TxtT_CL_TT.AllowNegative = True
        Me.TxtT_CL_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_CL_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_CL_TT.Flags = 7680
        Me.TxtT_CL_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_CL_TT.InputMask = "### ### ### ### ###"
        Me.TxtT_CL_TT.Location = New System.Drawing.Point(763, 513)
        Me.TxtT_CL_TT.MaxWholeDigits = 14
        Me.TxtT_CL_TT.Name = "TxtT_CL_TT"
        Me.TxtT_CL_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CL_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CL_TT.ReadOnly = True
        Me.TxtT_CL_TT.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_CL_TT.TabIndex = 1794
        Me.TxtT_CL_TT.TabStop = False
        Me.TxtT_CL_TT.Text = "0"
        Me.TxtT_CL_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(482, 515)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 16)
        Me.Label17.TabIndex = 1793
        Me.Label17.Tag = "Total received"
        Me.Label17.Text = "Đã thanh toán"
        '
        'TxtT_Da_TT
        '
        Me.TxtT_Da_TT.AllowNegative = True
        Me.TxtT_Da_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Da_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_Da_TT.Flags = 7680
        Me.TxtT_Da_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Da_TT.InputMask = "### ### ### ### ###"
        Me.TxtT_Da_TT.Location = New System.Drawing.Point(569, 513)
        Me.TxtT_Da_TT.MaxWholeDigits = 14
        Me.TxtT_Da_TT.Name = "TxtT_Da_TT"
        Me.TxtT_Da_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Da_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Da_TT.ReadOnly = True
        Me.TxtT_Da_TT.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_Da_TT.TabIndex = 1792
        Me.TxtT_Da_TT.TabStop = False
        Me.TxtT_Da_TT.Text = "0"
        Me.TxtT_Da_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(240, 515)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 1791
        Me.Label3.Tag = "Total receivable"
        Me.Label3.Text = "Tổng phải thanh toán"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###"
        Me.TxtT_TT.Location = New System.Drawing.Point(354, 513)
        Me.TxtT_TT.MaxWholeDigits = 14
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(123, 20)
        Me.TxtT_TT.TabIndex = 1790
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(62, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 1796
        Me.Label6.Tag = "Contract no."
        Me.Label6.Text = "Số hợp đồng"
        '
        'TxtTen_HD_H
        '
        Me.TxtTen_HD_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_HD_H.Enabled = False
        Me.TxtTen_HD_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HD_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD_H.Location = New System.Drawing.Point(268, 90)
        Me.TxtTen_HD_H.Name = "TxtTen_HD_H"
        Me.TxtTen_HD_H.ReadOnly = True
        Me.TxtTen_HD_H.Size = New System.Drawing.Size(235, 20)
        Me.TxtTen_HD_H.TabIndex = 1798
        Me.TxtTen_HD_H.TabStop = False
        '
        'TxtMa_HD_H
        '
        Me.TxtMa_HD_H._ActilookupPopup = False
        Me.TxtMa_HD_H.CyberActilookupPopup = True
        Me.TxtMa_HD_H.Dv_ListDetail = Nothing
        Me.TxtMa_HD_H.Dv_Master = Nothing
        Me.TxtMa_HD_H.FilterClient = ""
        Me.TxtMa_HD_H.FilterSQL = ""
        Me.TxtMa_HD_H.Location = New System.Drawing.Point(158, 90)
        Me.TxtMa_HD_H.Name = "TxtMa_HD_H"
        Me.TxtMa_HD_H.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_HD_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HD_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD_H.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_HD_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HD_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HD_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HD_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD_H.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa_HD_H.TabIndex = 4
        Me.TxtMa_HD_H.Table_Name = ""
        '
        'labLy_Do
        '
        Me.labLy_Do.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labLy_Do.AutoSize = True
        Me.labLy_Do.Enabled = False
        Me.labLy_Do.Location = New System.Drawing.Point(520, 119)
        Me.labLy_Do.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labLy_Do.Name = "labLy_Do"
        Me.labLy_Do.Size = New System.Drawing.Size(33, 13)
        Me.labLy_Do.TabIndex = 1799
        Me.labLy_Do.Tag = "Reason"
        Me.labLy_Do.Text = "Lý do"
        Me.labLy_Do.Visible = False
        '
        'CmbLoai_Ly_Do
        '
        Me.CmbLoai_Ly_Do.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbLoai_Ly_Do.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoai_Ly_Do.FormattingEnabled = True
        Me.CmbLoai_Ly_Do.Location = New System.Drawing.Point(584, 115)
        Me.CmbLoai_Ly_Do.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbLoai_Ly_Do.Name = "CmbLoai_Ly_Do"
        Me.CmbLoai_Ly_Do.Size = New System.Drawing.Size(136, 21)
        Me.CmbLoai_Ly_Do.TabIndex = 8
        Me.CmbLoai_Ly_Do.Visible = False
        '
        'TxtLy_Do
        '
        Me.TxtLy_Do.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLy_Do.Enabled = False
        Me.TxtLy_Do.Location = New System.Drawing.Point(584, 140)
        Me.TxtLy_Do.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLy_Do.Name = "TxtLy_Do"
        Me.TxtLy_Do.Size = New System.Drawing.Size(338, 20)
        Me.TxtLy_Do.TabIndex = 9
        Me.TxtLy_Do.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(62, 116)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 1796
        Me.Label7.Tag = "Car no."
        Me.Label7.Text = "Số thứ tự xe"
        '
        'TxtMa_TD3_H
        '
        Me.TxtMa_TD3_H._ActilookupPopup = False
        Me.TxtMa_TD3_H.CyberActilookupPopup = True
        Me.TxtMa_TD3_H.Dv_ListDetail = Nothing
        Me.TxtMa_TD3_H.Dv_Master = Nothing
        Me.TxtMa_TD3_H.FilterClient = ""
        Me.TxtMa_TD3_H.FilterSQL = ""
        Me.TxtMa_TD3_H.Location = New System.Drawing.Point(158, 115)
        Me.TxtMa_TD3_H.Name = "TxtMa_TD3_H"
        Me.TxtMa_TD3_H.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_TD3_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_TD3_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TD3_H.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_TD3_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_TD3_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TD3_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_TD3_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_TD3_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TD3_H.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa_TD3_H.TabIndex = 5
        Me.TxtMa_TD3_H.Table_Name = ""
        '
        'TxtTen_TD3_H
        '
        Me.TxtTen_TD3_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_TD3_H.Enabled = False
        Me.TxtTen_TD3_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TD3_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TD3_H.Location = New System.Drawing.Point(268, 115)
        Me.TxtTen_TD3_H.Name = "TxtTen_TD3_H"
        Me.TxtTen_TD3_H.ReadOnly = True
        Me.TxtTen_TD3_H.Size = New System.Drawing.Size(235, 20)
        Me.TxtTen_TD3_H.TabIndex = 1798
        Me.TxtTen_TD3_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(665, 5)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(59, 15)
        Me.LabMa_TTCP_H.TabIndex = 2154
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(730, 2)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2153
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'TD4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(930, 592)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.TxtLy_Do)
        Me.Controls.Add(Me.CmbLoai_Ly_Do)
        Me.Controls.Add(Me.labLy_Do)
        Me.Controls.Add(Me.TxtTen_TD3_H)
        Me.Controls.Add(Me.TxtMa_TD3_H)
        Me.Controls.Add(Me.TxtTen_HD_H)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_HD_H)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtT_CL_TT)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtT_Da_TT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.ChkBL_TT)
        Me.Controls.Add(Me.TxtMa_Hs_BL)
        Me.Controls.Add(Me.TxtTen_Hs_BL)
        Me.Controls.Add(Me.LabMa_HS_H)
        Me.Controls.Add(Me.TxtTen_GD)
        Me.Controls.Add(Me.ChkIs_Dc)
        Me.Controls.Add(Me.LabMa_khoN)
        Me.Controls.Add(Me.TxtTen_KhoN)
        Me.Controls.Add(Me.TxtMa_KhoN)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_Kho)
        Me.Controls.Add(Me.TxtMa_Kho)
        Me.Controls.Add(Me.LabGio_Ve)
        Me.Controls.Add(Me.TxtGio_Ve)
        Me.Controls.Add(Me.TxtNgay_Ve)
        Me.Controls.Add(Me.LabNgay_Ve)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGio_CT)
        Me.Controls.Add(Me.TxtTen_Hs_H)
        Me.Controls.Add(Me.TxtMa_Hs_H)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_BP_H)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_SO_LUONG)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CmbMa_GD)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabMa_Quyen)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.TxtSo_Ct)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(920, 595)
        Me.Name = "TD4"
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.CmdPhan_Bo, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.CmdNew, 0)
        Me.Controls.SetChildIndex(Me.CmdSave, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdEdit, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.CmdDelete, 0)
        Me.Controls.SetChildIndex(Me.CmdCopy, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.CmdExit, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdImport, 0)
        Me.Controls.SetChildIndex(Me.CmdSms, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdView, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtT_SO_LUONG, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_CT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ve, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ve, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_Ve, 0)
        Me.Controls.SetChildIndex(Me.LabGio_Ve, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KhoN, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KhoN, 0)
        Me.Controls.SetChildIndex(Me.LabMa_khoN, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Dc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_GD, 0)
        Me.Controls.SetChildIndex(Me.LabMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_BL, 0)
        Me.Controls.SetChildIndex(Me.ChkBL_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Da_TT, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CL_TT, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD_H, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD_H, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TD3_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TD3_H, 0)
        Me.Controls.SetChildIndex(Me.labLy_Do, 0)
        Me.Controls.SetChildIndex(Me.CmbLoai_Ly_Do, 0)
        Me.Controls.SetChildIndex(Me.TxtLy_Do, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KhoN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_BL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TD3_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Quyen As System.Windows.Forms.Label
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ct As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_NT As System.Windows.Forms.Label
    Friend WithEvents TxtTy_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_NT As System.Windows.Forms.TextBox
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabTy_gia As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_SO As System.Windows.Forms.TextBox
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_SO_LUONG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Hs_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtGio_CT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_Ve As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ve As System.Windows.Forms.Label
    Friend WithEvents LabGio_Ve As System.Windows.Forms.Label
    Friend WithEvents TxtGio_Ve As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_khoN As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KhoN As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KhoN As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kho As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkIs_Dc As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_GD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_BL As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Hs_BL As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_HS_H As System.Windows.Forms.Label
    Friend WithEvents ChkBL_TT As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtT_CL_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Da_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HD_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HD_H As Cyber.SmLists.TxtLookup
    Friend WithEvents labLy_Do As System.Windows.Forms.Label
    Friend WithEvents CmbLoai_Ly_Do As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLy_Do As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_TD3_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TD3_H As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox

End Class
