<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TD2
    Inherits Cyber.From.Frmvoucher

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
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
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
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.LblDien_Giai = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_BL = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_Hs_H = New Cyber.SmLists.TxtLookup()
        Me.TxtChuc_Vu_BL = New System.Windows.Forms.TextBox()
        Me.Labchuc_Vu_BL = New System.Windows.Forms.Label()
        Me.TxtChuc_Vu = New System.Windows.Forms.TextBox()
        Me.Labchuc_Vu = New System.Windows.Forms.Label()
        Me.LabSo_BL = New System.Windows.Forms.Label()
        Me.TxtSo_BL = New System.Windows.Forms.TextBox()
        Me.LabNgay_HH = New System.Windows.Forms.Label()
        Me.TxtNgay_HH = New ClsTextBox.txtDate()
        Me.LabNgay_BL = New System.Windows.Forms.Label()
        Me.TxtNgay_BL = New ClsTextBox.txtDate()
        Me.TxtTen_Hs_BL = New System.Windows.Forms.TextBox()
        Me.LabMa_Hs_BL = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_H = New System.Windows.Forms.TextBox()
        Me.LabMa_HS_H = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGio_CT = New System.Windows.Forms.TextBox()
        Me.txtTen_Lx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOng_ba = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtT_CL_TT = New ClsTextBox.txtTien_NT()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtT_Da_TT = New ClsTextBox.txtTien_NT()
        Me.txtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp_H = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Bp_H = New System.Windows.Forms.Label()
        Me.ChkBL_TT = New System.Windows.Forms.CheckBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.ChkKH_KS = New System.Windows.Forms.CheckBox()
        Me.TxtMa_HS_I = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_HS_C = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDien_Giai_I = New System.Windows.Forms.TextBox()
        Me.TxtCL_I = New ClsTextBox.txtTien_NT()
        Me.TxtMa_kh_I = New Cyber.SmLists.TxtLookup()
        Me.txtTen_KH_I = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkBL_I = New System.Windows.Forms.CheckBox()
        Me.txtTen_Hs_I = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDien_giai_C = New System.Windows.Forms.TextBox()
        Me.TxtCL_C = New ClsTextBox.txtTien_NT()
        Me.TxtMa_kh_C = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kh_C = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkBL_C = New System.Windows.Forms.CheckBox()
        Me.TxtTen_Hs_C = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMa_HS_N = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_HS_W = New Cyber.SmLists.TxtLookup()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDien_Giai_N = New System.Windows.Forms.TextBox()
        Me.TxtCL_N = New ClsTextBox.txtTien_NT()
        Me.TxtMa_Kh_N = New Cyber.SmLists.TxtLookup()
        Me.txtTen_KH_N = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkBL_N = New System.Windows.Forms.CheckBox()
        Me.txtTen_Hs_N = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDien_giai_W = New System.Windows.Forms.TextBox()
        Me.TxtCL_W = New ClsTextBox.txtTien_NT()
        Me.TxtMa_Kh_W = New Cyber.SmLists.TxtLookup()
        Me.txtTen_KH_W = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkBl_W = New System.Windows.Forms.CheckBox()
        Me.txtTen_HS_W = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSo_Thu_Tu = New System.Windows.Forms.TextBox()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_BL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_I.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kh_I.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kh_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_N.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_W.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh_N.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh_W.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(239, 531)
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
        Me.CmdSave.Location = New System.Drawing.Point(-1, 531)
        Me.CmdSave.TabIndex = 22
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
        Me.CmdView.Location = New System.Drawing.Point(478, 531)
        Me.CmdView.TabIndex = 24
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 513)
        '
        'CmdSms
        '
        Me.CmdSms.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSms.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSms.Appearance.Options.UseBackColor = True
        Me.CmdSms.Appearance.Options.UseFont = True
        Me.CmdSms.Appearance.Options.UseForeColor = True
        Me.CmdSms.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSms.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSms.Location = New System.Drawing.Point(901, 531)
        Me.CmdSms.TabIndex = 23
        '
        'CmdImport
        '
        Me.CmdImport.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdImport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdImport.Appearance.Options.UseBackColor = True
        Me.CmdImport.Appearance.Options.UseFont = True
        Me.CmdImport.Appearance.Options.UseForeColor = True
        Me.CmdImport.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdImport.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdImport.Location = New System.Drawing.Point(945, 531)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 508)
        Me.CbbMa_Post.TabIndex = 17
        Me.CbbMa_Post.TabStop = False
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
        Me.CmdExit.Location = New System.Drawing.Point(637, 531)
        Me.CmdExit.TabIndex = 26
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
        Me.CmdSearch.Location = New System.Drawing.Point(558, 531)
        Me.CmdSearch.TabIndex = 25
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
        Me.CmdCopy.Location = New System.Drawing.Point(399, 531)
        Me.CmdCopy.TabIndex = 23
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
        Me.CmdDelete.Location = New System.Drawing.Point(319, 531)
        Me.CmdDelete.TabIndex = 22
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
        Me.CmdPrint.Location = New System.Drawing.Point(159, 531)
        Me.CmdPrint.TabIndex = 20
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
        Me.CmdNew.Location = New System.Drawing.Point(79, 531)
        Me.CmdNew.TabIndex = 19
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
        Me.CmdCancel.Location = New System.Drawing.Point(239, 531)
        Me.CmdCancel.TabIndex = 21
        '
        'CmdPhan_Bo
        '
        Me.CmdPhan_Bo.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPhan_Bo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPhan_Bo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPhan_Bo.Appearance.Options.UseBackColor = True
        Me.CmdPhan_Bo.Appearance.Options.UseFont = True
        Me.CmdPhan_Bo.Appearance.Options.UseForeColor = True
        Me.CmdPhan_Bo.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPhan_Bo.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(840, 530)
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(807, 567)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(281, 32)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(300, 23)
        Me.CbbMa_GD.TabIndex = 21
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
        Me.LabNgay_Ct.Location = New System.Drawing.Point(1, 61)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày c.từ"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(200, 38)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(71, 15)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(361, 64)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(71, 13)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số phiếu"
        '
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(451, 59)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(130, 21)
        Me.txtSo_ct.TabIndex = 2
        Me.txtSo_ct.TabStop = False
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(835, 42)
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
        Me.TxtTy_Gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(900, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 20
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
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(117, 21)
        Me.TxtNgay_LCt.TabIndex = 0
        Me.TxtNgay_LCt.TabStop = False
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
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(117, 21)
        Me.TxtNgay_Ct.TabIndex = 1
        Me.TxtNgay_Ct.TabStop = False
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_NT.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(900, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 19
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
        Me.Detail.Location = New System.Drawing.Point(1, 312)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(988, 191)
        Me.Detail.TabIndex = 20
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
        Me.LabTy_gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTy_gia.BackColor = System.Drawing.Color.Transparent
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(835, 61)
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
        Me.GroupBoxLine.Size = New System.Drawing.Size(973, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(959, 536)
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(932, 536)
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
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(245, 507)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(110, 16)
        Me.LabT_So_Luong.TabIndex = 175
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng phải thanh toán"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###"
        Me.TxtT_TT.Location = New System.Drawing.Point(355, 505)
        Me.TxtT_TT.MaxWholeDigits = 14
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(115, 20)
        Me.TxtT_TT.TabIndex = 174
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblDien_Giai
        '
        Me.LblDien_Giai.AutoSize = True
        Me.LblDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LblDien_Giai.Location = New System.Drawing.Point(37, 363)
        Me.LblDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDien_Giai.Name = "LblDien_Giai"
        Me.LblDien_Giai.Size = New System.Drawing.Size(48, 13)
        Me.LblDien_Giai.TabIndex = 336
        Me.LblDien_Giai.Tag = "Explaination"
        Me.LblDien_Giai.Text = "Diễn giải"
        Me.LblDien_Giai.Visible = False
        '
        'txtDien_giai
        '
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(116, 359)
        Me.txtDien_giai.Multiline = True
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(397, 42)
        Me.txtDien_giai.TabIndex = 1
        Me.txtDien_giai.TabStop = False
        Me.txtDien_giai.Visible = False
        '
        'TxtMa_Hs_BL
        '
        Me.TxtMa_Hs_BL._ActilookupPopup = False
        Me.TxtMa_Hs_BL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Hs_BL.CyberActilookupPopup = True
        Me.TxtMa_Hs_BL.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_BL.Dv_Master = Nothing
        Me.TxtMa_Hs_BL.FilterClient = ""
        Me.TxtMa_Hs_BL.FilterSQL = ""
        Me.TxtMa_Hs_BL.Location = New System.Drawing.Point(525, 381)
        Me.TxtMa_Hs_BL.Name = "TxtMa_Hs_BL"
        Me.TxtMa_Hs_BL.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs_BL.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_BL.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs_BL.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_BL.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Hs_BL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_BL.Size = New System.Drawing.Size(111, 22)
        Me.TxtMa_Hs_BL.TabIndex = 3
        Me.TxtMa_Hs_BL.Table_Name = ""
        Me.TxtMa_Hs_BL.Visible = False
        '
        'TxtMa_Hs_H
        '
        Me.TxtMa_Hs_H._ActilookupPopup = False
        Me.TxtMa_Hs_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Hs_H.CyberActilookupPopup = True
        Me.TxtMa_Hs_H.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_H.Dv_Master = Nothing
        Me.TxtMa_Hs_H.FilterClient = ""
        Me.TxtMa_Hs_H.FilterSQL = ""
        Me.TxtMa_Hs_H.Location = New System.Drawing.Point(525, 333)
        Me.TxtMa_Hs_H.Name = "TxtMa_Hs_H"
        Me.TxtMa_Hs_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_H.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Hs_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_H.Size = New System.Drawing.Size(111, 22)
        Me.TxtMa_Hs_H.TabIndex = 2
        Me.TxtMa_Hs_H.Table_Name = ""
        Me.TxtMa_Hs_H.Visible = False
        '
        'TxtChuc_Vu_BL
        '
        Me.TxtChuc_Vu_BL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChuc_Vu_BL.BackColor = System.Drawing.Color.White
        Me.TxtChuc_Vu_BL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtChuc_Vu_BL.ForeColor = System.Drawing.Color.Navy
        Me.TxtChuc_Vu_BL.Location = New System.Drawing.Point(525, 407)
        Me.TxtChuc_Vu_BL.Name = "TxtChuc_Vu_BL"
        Me.TxtChuc_Vu_BL.Size = New System.Drawing.Size(361, 20)
        Me.TxtChuc_Vu_BL.TabIndex = 5
        Me.TxtChuc_Vu_BL.Tag = ""
        Me.TxtChuc_Vu_BL.Visible = False
        '
        'Labchuc_Vu_BL
        '
        Me.Labchuc_Vu_BL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labchuc_Vu_BL.AutoSize = True
        Me.Labchuc_Vu_BL.ForeColor = System.Drawing.Color.Navy
        Me.Labchuc_Vu_BL.Location = New System.Drawing.Point(425, 410)
        Me.Labchuc_Vu_BL.Margin = New System.Windows.Forms.Padding(0)
        Me.Labchuc_Vu_BL.Name = "Labchuc_Vu_BL"
        Me.Labchuc_Vu_BL.Size = New System.Drawing.Size(47, 13)
        Me.Labchuc_Vu_BL.TabIndex = 362
        Me.Labchuc_Vu_BL.Tag = "Order out"
        Me.Labchuc_Vu_BL.Text = "Chức vụ"
        Me.Labchuc_Vu_BL.Visible = False
        '
        'TxtChuc_Vu
        '
        Me.TxtChuc_Vu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChuc_Vu.BackColor = System.Drawing.Color.White
        Me.TxtChuc_Vu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtChuc_Vu.ForeColor = System.Drawing.Color.Navy
        Me.TxtChuc_Vu.Location = New System.Drawing.Point(525, 357)
        Me.TxtChuc_Vu.Name = "TxtChuc_Vu"
        Me.TxtChuc_Vu.Size = New System.Drawing.Size(361, 20)
        Me.TxtChuc_Vu.TabIndex = 4
        Me.TxtChuc_Vu.Tag = ""
        Me.TxtChuc_Vu.Visible = False
        '
        'Labchuc_Vu
        '
        Me.Labchuc_Vu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labchuc_Vu.AutoSize = True
        Me.Labchuc_Vu.ForeColor = System.Drawing.Color.Navy
        Me.Labchuc_Vu.Location = New System.Drawing.Point(425, 360)
        Me.Labchuc_Vu.Margin = New System.Windows.Forms.Padding(0)
        Me.Labchuc_Vu.Name = "Labchuc_Vu"
        Me.Labchuc_Vu.Size = New System.Drawing.Size(47, 13)
        Me.Labchuc_Vu.TabIndex = 361
        Me.Labchuc_Vu.Tag = "Order out"
        Me.Labchuc_Vu.Text = "Chức vụ"
        Me.Labchuc_Vu.Visible = False
        '
        'LabSo_BL
        '
        Me.LabSo_BL.ForeColor = System.Drawing.Color.Navy
        Me.LabSo_BL.Location = New System.Drawing.Point(236, 410)
        Me.LabSo_BL.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSo_BL.Name = "LabSo_BL"
        Me.LabSo_BL.Size = New System.Drawing.Size(57, 13)
        Me.LabSo_BL.TabIndex = 360
        Me.LabSo_BL.Tag = "Guar no"
        Me.LabSo_BL.Text = "Số BL"
        Me.LabSo_BL.Visible = False
        '
        'TxtSo_BL
        '
        Me.TxtSo_BL.BackColor = System.Drawing.Color.White
        Me.TxtSo_BL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_BL.Enabled = False
        Me.TxtSo_BL.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_BL.Location = New System.Drawing.Point(318, 406)
        Me.TxtSo_BL.Name = "TxtSo_BL"
        Me.TxtSo_BL.Size = New System.Drawing.Size(195, 20)
        Me.TxtSo_BL.TabIndex = 9
        Me.TxtSo_BL.Tag = ""
        Me.TxtSo_BL.Visible = False
        '
        'LabNgay_HH
        '
        Me.LabNgay_HH.AutoSize = True
        Me.LabNgay_HH.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_HH.Location = New System.Drawing.Point(37, 402)
        Me.LabNgay_HH.Margin = New System.Windows.Forms.Padding(0)
        Me.LabNgay_HH.Name = "LabNgay_HH"
        Me.LabNgay_HH.Size = New System.Drawing.Size(66, 13)
        Me.LabNgay_HH.TabIndex = 359
        Me.LabNgay_HH.Tag = "Date end guar"
        Me.LabNgay_HH.Text = "Ngày hết BL"
        Me.LabNgay_HH.Visible = False
        '
        'TxtNgay_HH
        '
        Me.TxtNgay_HH.BackColor = System.Drawing.Color.White
        Me.TxtNgay_HH.Flags = 65536
        Me.TxtNgay_HH.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HH.isEmpty = True
        Me.TxtNgay_HH.Location = New System.Drawing.Point(115, 431)
        Me.TxtNgay_HH.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HH.MaxLength = 10
        Me.TxtNgay_HH.Name = "TxtNgay_HH"
        Me.TxtNgay_HH.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HH.ShowDayBeforeMonth = False
        Me.TxtNgay_HH.Size = New System.Drawing.Size(111, 20)
        Me.TxtNgay_HH.TabIndex = 8
        Me.TxtNgay_HH.Text = "18/09/2011"
        Me.TxtNgay_HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_HH.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_HH.Visible = False
        '
        'LabNgay_BL
        '
        Me.LabNgay_BL.AutoSize = True
        Me.LabNgay_BL.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_BL.Location = New System.Drawing.Point(37, 409)
        Me.LabNgay_BL.Margin = New System.Windows.Forms.Padding(0)
        Me.LabNgay_BL.Name = "LabNgay_BL"
        Me.LabNgay_BL.Size = New System.Drawing.Size(62, 13)
        Me.LabNgay_BL.TabIndex = 358
        Me.LabNgay_BL.Tag = "Guar Regis date"
        Me.LabNgay_BL.Text = "Ngày ký BL"
        Me.LabNgay_BL.Visible = False
        '
        'TxtNgay_BL
        '
        Me.TxtNgay_BL.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BL.Flags = 65536
        Me.TxtNgay_BL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_BL.isEmpty = True
        Me.TxtNgay_BL.Location = New System.Drawing.Point(116, 405)
        Me.TxtNgay_BL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_BL.MaxLength = 10
        Me.TxtNgay_BL.Name = "TxtNgay_BL"
        Me.TxtNgay_BL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_BL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BL.ShowDayBeforeMonth = False
        Me.TxtNgay_BL.Size = New System.Drawing.Size(111, 20)
        Me.TxtNgay_BL.TabIndex = 7
        Me.TxtNgay_BL.Text = "18/09/2011"
        Me.TxtNgay_BL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_BL.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_BL.Visible = False
        '
        'TxtTen_Hs_BL
        '
        Me.TxtTen_Hs_BL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Hs_BL.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_BL.Enabled = False
        Me.TxtTen_Hs_BL.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_BL.Location = New System.Drawing.Point(640, 381)
        Me.TxtTen_Hs_BL.Name = "TxtTen_Hs_BL"
        Me.TxtTen_Hs_BL.ReadOnly = True
        Me.TxtTen_Hs_BL.Size = New System.Drawing.Size(247, 20)
        Me.TxtTen_Hs_BL.TabIndex = 348
        Me.TxtTen_Hs_BL.Tag = ""
        Me.TxtTen_Hs_BL.Visible = False
        '
        'LabMa_Hs_BL
        '
        Me.LabMa_Hs_BL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_Hs_BL.AutoSize = True
        Me.LabMa_Hs_BL.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Hs_BL.Location = New System.Drawing.Point(425, 386)
        Me.LabMa_Hs_BL.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_Hs_BL.Name = "LabMa_Hs_BL"
        Me.LabMa_Hs_BL.Size = New System.Drawing.Size(65, 13)
        Me.LabMa_Hs_BL.TabIndex = 357
        Me.LabMa_Hs_BL.Tag = "Guar Regis"
        Me.LabMa_Hs_BL.Text = "Người ký BL"
        Me.LabMa_Hs_BL.Visible = False
        '
        'TxtTen_Hs_H
        '
        Me.TxtTen_Hs_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Hs_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_H.Enabled = False
        Me.TxtTen_Hs_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_H.Location = New System.Drawing.Point(640, 333)
        Me.TxtTen_Hs_H.Name = "TxtTen_Hs_H"
        Me.TxtTen_Hs_H.ReadOnly = True
        Me.TxtTen_Hs_H.Size = New System.Drawing.Size(247, 20)
        Me.TxtTen_Hs_H.TabIndex = 345
        Me.TxtTen_Hs_H.Tag = ""
        Me.TxtTen_Hs_H.Visible = False
        '
        'LabMa_HS_H
        '
        Me.LabMa_HS_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_HS_H.AutoSize = True
        Me.LabMa_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_HS_H.Location = New System.Drawing.Point(425, 338)
        Me.LabMa_HS_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_HS_H.Name = "LabMa_HS_H"
        Me.LabMa_HS_H.Size = New System.Drawing.Size(101, 13)
        Me.LabMa_HS_H.TabIndex = 356
        Me.LabMa_HS_H.Tag = "Sponsor"
        Me.LabMa_HS_H.Text = "Người bảo lãnh (BL)"
        Me.LabMa_HS_H.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(200, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 364
        Me.Label3.Tag = "Voucher no."
        Me.Label3.Text = "Giờ lập"
        '
        'TxtGio_CT
        '
        Me.TxtGio_CT.BackColor = System.Drawing.Color.White
        Me.TxtGio_CT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGio_CT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGio_CT.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_CT.Location = New System.Drawing.Point(282, 59)
        Me.TxtGio_CT.Name = "TxtGio_CT"
        Me.TxtGio_CT.Size = New System.Drawing.Size(73, 21)
        Me.TxtGio_CT.TabIndex = 363
        Me.TxtGio_CT.TabStop = False
        Me.TxtGio_CT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen_Lx
        '
        Me.txtTen_Lx.BackColor = System.Drawing.Color.White
        Me.txtTen_Lx.Enabled = False
        Me.txtTen_Lx.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Lx.Location = New System.Drawing.Point(281, 92)
        Me.txtTen_Lx.Name = "txtTen_Lx"
        Me.txtTen_Lx.Size = New System.Drawing.Size(300, 20)
        Me.txtTen_Lx.TabIndex = 366
        Me.txtTen_Lx.Tag = ""
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(80, 92)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(117, 20)
        Me.TxtMa_Xe.TabIndex = 3
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 367
        Me.Label4.Tag = "Car number"
        Me.Label4.Text = "Biển số"
        '
        'lblOng_ba
        '
        Me.lblOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.lblOng_ba.Location = New System.Drawing.Point(200, 95)
        Me.lblOng_ba.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOng_ba.Name = "lblOng_ba"
        Me.lblOng_ba.Size = New System.Drawing.Size(57, 15)
        Me.lblOng_ba.TabIndex = 368
        Me.lblOng_ba.Tag = "Driver name"
        Me.lblOng_ba.Text = "Lái xe"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(676, 507)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 384
        Me.Label16.Tag = "Total"
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
        Me.TxtT_CL_TT.Location = New System.Drawing.Point(723, 505)
        Me.TxtT_CL_TT.MaxWholeDigits = 14
        Me.TxtT_CL_TT.Name = "TxtT_CL_TT"
        Me.TxtT_CL_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CL_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CL_TT.ReadOnly = True
        Me.TxtT_CL_TT.Size = New System.Drawing.Size(115, 20)
        Me.TxtT_CL_TT.TabIndex = 383
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
        Me.Label17.Location = New System.Drawing.Point(474, 509)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 16)
        Me.Label17.TabIndex = 382
        Me.Label17.Tag = "Total"
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
        Me.TxtT_Da_TT.Location = New System.Drawing.Point(558, 505)
        Me.TxtT_Da_TT.MaxWholeDigits = 14
        Me.TxtT_Da_TT.Name = "TxtT_Da_TT"
        Me.TxtT_Da_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Da_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Da_TT.ReadOnly = True
        Me.TxtT_Da_TT.Size = New System.Drawing.Size(115, 20)
        Me.TxtT_Da_TT.TabIndex = 381
        Me.TxtT_Da_TT.TabStop = False
        Me.TxtT_Da_TT.Text = "0"
        Me.TxtT_Da_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen_BP_H
        '
        Me.txtTen_BP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_BP_H.BackColor = System.Drawing.Color.White
        Me.txtTen_BP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BP_H.Location = New System.Drawing.Point(640, 428)
        Me.txtTen_BP_H.Name = "txtTen_BP_H"
        Me.txtTen_BP_H.ReadOnly = True
        Me.txtTen_BP_H.Size = New System.Drawing.Size(247, 20)
        Me.txtTen_BP_H.TabIndex = 387
        Me.txtTen_BP_H.TabStop = False
        Me.txtTen_BP_H.Visible = False
        '
        'TxtMa_Bp_H
        '
        Me.TxtMa_Bp_H._ActilookupPopup = False
        Me.TxtMa_Bp_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Bp_H.CyberActilookupPopup = True
        Me.TxtMa_Bp_H.Dv_ListDetail = Nothing
        Me.TxtMa_Bp_H.Dv_Master = Nothing
        Me.TxtMa_Bp_H.FilterClient = ""
        Me.TxtMa_Bp_H.FilterSQL = ""
        Me.TxtMa_Bp_H.Location = New System.Drawing.Point(525, 428)
        Me.TxtMa_Bp_H.Name = "TxtMa_Bp_H"
        Me.TxtMa_Bp_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp_H.Size = New System.Drawing.Size(111, 20)
        Me.TxtMa_Bp_H.TabIndex = 6
        Me.TxtMa_Bp_H.Table_Name = ""
        Me.TxtMa_Bp_H.Visible = False
        '
        'LabMa_Bp_H
        '
        Me.LabMa_Bp_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_Bp_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Bp_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_Bp_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Bp_H.Location = New System.Drawing.Point(425, 432)
        Me.LabMa_Bp_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_Bp_H.Name = "LabMa_Bp_H"
        Me.LabMa_Bp_H.Size = New System.Drawing.Size(69, 14)
        Me.LabMa_Bp_H.TabIndex = 386
        Me.LabMa_Bp_H.Tag = "Cus code"
        Me.LabMa_Bp_H.Text = "Phòng ban"
        Me.LabMa_Bp_H.Visible = False
        '
        'ChkBL_TT
        '
        Me.ChkBL_TT.AutoSize = True
        Me.ChkBL_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBL_TT.ForeColor = System.Drawing.Color.Red
        Me.ChkBL_TT.Location = New System.Drawing.Point(318, 449)
        Me.ChkBL_TT.Name = "ChkBL_TT"
        Me.ChkBL_TT.Size = New System.Drawing.Size(141, 17)
        Me.ChkBL_TT.TabIndex = 388
        Me.ChkBL_TT.Text = "Bảo lãnh thanh toán"
        Me.ChkBL_TT.UseVisualStyleBackColor = True
        Me.ChkBL_TT.Visible = False
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(930, 508)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2133
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.SystemColors.Control
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(660, 6)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(144, 17)
        Me.LabMa_TTCP_H.TabIndex = 2165
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(807, 2)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(182, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2164
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'ChkKH_KS
        '
        Me.ChkKH_KS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkKH_KS.AutoSize = True
        Me.ChkKH_KS.Enabled = False
        Me.ChkKH_KS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKH_KS.ForeColor = System.Drawing.Color.Navy
        Me.ChkKH_KS.Location = New System.Drawing.Point(605, 95)
        Me.ChkKH_KS.Name = "ChkKH_KS"
        Me.ChkKH_KS.Size = New System.Drawing.Size(112, 17)
        Me.ChkKH_KS.TabIndex = 2166
        Me.ChkKH_KS.Tag = "Contract customer"
        Me.ChkKH_KS.Text = "Khách hàng ký sổ"
        Me.ChkKH_KS.UseVisualStyleBackColor = True
        '
        'TxtMa_HS_I
        '
        Me.TxtMa_HS_I._ActilookupPopup = False
        Me.TxtMa_HS_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_HS_I.CyberActilookupPopup = True
        Me.TxtMa_HS_I.Dv_ListDetail = Nothing
        Me.TxtMa_HS_I.Dv_Master = Nothing
        Me.TxtMa_HS_I.FilterClient = ""
        Me.TxtMa_HS_I.FilterSQL = ""
        Me.TxtMa_HS_I.Location = New System.Drawing.Point(641, 162)
        Me.TxtMa_HS_I.Name = "TxtMa_HS_I"
        Me.TxtMa_HS_I.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_I.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_I.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_I.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_I.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_HS_I.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_I.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_HS_I.TabIndex = 10
        Me.TxtMa_HS_I.Table_Name = ""
        '
        'TxtMa_HS_C
        '
        Me.TxtMa_HS_C._ActilookupPopup = False
        Me.TxtMa_HS_C.CyberActilookupPopup = True
        Me.TxtMa_HS_C.Dv_ListDetail = Nothing
        Me.TxtMa_HS_C.Dv_Master = Nothing
        Me.TxtMa_HS_C.FilterClient = ""
        Me.TxtMa_HS_C.FilterSQL = ""
        Me.TxtMa_HS_C.Location = New System.Drawing.Point(80, 162)
        Me.TxtMa_HS_C.Name = "TxtMa_HS_C"
        Me.TxtMa_HS_C.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_C.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_C.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_C.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_HS_C.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_C.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_HS_C.TabIndex = 6
        Me.TxtMa_HS_C.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(564, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2186
        Me.Label5.Tag = "Guar no"
        Me.Label5.Text = "Ghi chú"
        '
        'txtDien_Giai_I
        '
        Me.txtDien_Giai_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDien_Giai_I.BackColor = System.Drawing.Color.White
        Me.txtDien_Giai_I.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDien_Giai_I.Enabled = False
        Me.txtDien_Giai_I.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_Giai_I.Location = New System.Drawing.Point(641, 186)
        Me.txtDien_Giai_I.Name = "txtDien_Giai_I"
        Me.txtDien_Giai_I.Size = New System.Drawing.Size(347, 20)
        Me.txtDien_Giai_I.TabIndex = 11
        Me.txtDien_Giai_I.Tag = ""
        '
        'TxtCL_I
        '
        Me.TxtCL_I.AllowNegative = True
        Me.TxtCL_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCL_I.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCL_I.Flags = 7680
        Me.TxtCL_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCL_I.ForeColor = System.Drawing.Color.Navy
        Me.TxtCL_I.InputMask = "### ### ### ### ###"
        Me.TxtCL_I.Location = New System.Drawing.Point(839, 115)
        Me.TxtCL_I.MaxWholeDigits = 14
        Me.TxtCL_I.Name = "TxtCL_I"
        Me.TxtCL_I.RangeMax = 1.7976931348623157E+308R
        Me.TxtCL_I.RangeMin = -1.7976931348623157E+308R
        Me.TxtCL_I.ReadOnly = True
        Me.TxtCL_I.Size = New System.Drawing.Size(149, 20)
        Me.TxtCL_I.TabIndex = 2185
        Me.TxtCL_I.TabStop = False
        Me.TxtCL_I.Text = "0"
        Me.TxtCL_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_kh_I
        '
        Me.TxtMa_kh_I._ActilookupPopup = False
        Me.TxtMa_kh_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_kh_I.CyberActilookupPopup = True
        Me.TxtMa_kh_I.Dv_ListDetail = Nothing
        Me.TxtMa_kh_I.Dv_Master = Nothing
        Me.TxtMa_kh_I.FilterClient = ""
        Me.TxtMa_kh_I.FilterSQL = ""
        Me.TxtMa_kh_I.Location = New System.Drawing.Point(641, 138)
        Me.TxtMa_kh_I.Name = "TxtMa_kh_I"
        Me.TxtMa_kh_I.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_kh_I.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kh_I.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_kh_I.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kh_I.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_kh_I.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kh_I.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_kh_I.TabIndex = 9
        Me.TxtMa_kh_I.Table_Name = ""
        '
        'txtTen_KH_I
        '
        Me.txtTen_KH_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_KH_I.BackColor = System.Drawing.Color.White
        Me.txtTen_KH_I.Enabled = False
        Me.txtTen_KH_I.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_KH_I.Location = New System.Drawing.Point(762, 139)
        Me.txtTen_KH_I.Name = "txtTen_KH_I"
        Me.txtTen_KH_I.ReadOnly = True
        Me.txtTen_KH_I.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_KH_I.TabIndex = 2183
        Me.txtTen_KH_I.TabStop = False
        Me.txtTen_KH_I.Tag = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(564, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 2184
        Me.Label6.Tag = "Customer in debt"
        Me.Label6.Text = "Đối tượng"
        '
        'ChkBL_I
        '
        Me.ChkBL_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBL_I.AutoSize = True
        Me.ChkBL_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBL_I.ForeColor = System.Drawing.Color.Red
        Me.ChkBL_I.Location = New System.Drawing.Point(564, 120)
        Me.ChkBL_I.Name = "ChkBL_I"
        Me.ChkBL_I.Size = New System.Drawing.Size(131, 17)
        Me.ChkBL_I.TabIndex = 8
        Me.ChkBL_I.Tag = "Payment guarantee"
        Me.ChkBL_I.Text = "Bảo lãnh bảo hiểm"
        Me.ChkBL_I.UseVisualStyleBackColor = True
        '
        'txtTen_Hs_I
        '
        Me.txtTen_Hs_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_Hs_I.BackColor = System.Drawing.Color.White
        Me.txtTen_Hs_I.Enabled = False
        Me.txtTen_Hs_I.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Hs_I.Location = New System.Drawing.Point(762, 163)
        Me.txtTen_Hs_I.Name = "txtTen_Hs_I"
        Me.txtTen_Hs_I.ReadOnly = True
        Me.txtTen_Hs_I.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_Hs_I.TabIndex = 2181
        Me.txtTen_Hs_I.TabStop = False
        Me.txtTen_Hs_I.Tag = ""
        Me.txtTen_Hs_I.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(564, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 2182
        Me.Label7.Tag = "Sponsor"
        Me.Label7.Text = "Người XN"
        Me.Label7.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2180
        Me.Label2.Tag = "Guar no"
        Me.Label2.Text = "Ghi chú"
        '
        'txtDien_giai_C
        '
        Me.txtDien_giai_C.BackColor = System.Drawing.Color.White
        Me.txtDien_giai_C.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDien_giai_C.Enabled = False
        Me.txtDien_giai_C.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai_C.Location = New System.Drawing.Point(80, 186)
        Me.txtDien_giai_C.Name = "txtDien_giai_C"
        Me.txtDien_giai_C.Size = New System.Drawing.Size(347, 20)
        Me.txtDien_giai_C.TabIndex = 7
        Me.txtDien_giai_C.Tag = ""
        '
        'TxtCL_C
        '
        Me.TxtCL_C.AllowNegative = True
        Me.TxtCL_C.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCL_C.Flags = 7680
        Me.TxtCL_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCL_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtCL_C.InputMask = "### ### ### ### ###"
        Me.TxtCL_C.Location = New System.Drawing.Point(282, 115)
        Me.TxtCL_C.MaxWholeDigits = 14
        Me.TxtCL_C.Name = "TxtCL_C"
        Me.TxtCL_C.RangeMax = 1.7976931348623157E+308R
        Me.TxtCL_C.RangeMin = -1.7976931348623157E+308R
        Me.TxtCL_C.ReadOnly = True
        Me.TxtCL_C.Size = New System.Drawing.Size(145, 20)
        Me.TxtCL_C.TabIndex = 2179
        Me.TxtCL_C.TabStop = False
        Me.TxtCL_C.Text = "0"
        Me.TxtCL_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_kh_C
        '
        Me.TxtMa_kh_C._ActilookupPopup = False
        Me.TxtMa_kh_C.CyberActilookupPopup = True
        Me.TxtMa_kh_C.Dv_ListDetail = Nothing
        Me.TxtMa_kh_C.Dv_Master = Nothing
        Me.TxtMa_kh_C.FilterClient = ""
        Me.TxtMa_kh_C.FilterSQL = ""
        Me.TxtMa_kh_C.Location = New System.Drawing.Point(80, 138)
        Me.TxtMa_kh_C.Name = "TxtMa_kh_C"
        Me.TxtMa_kh_C.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_kh_C.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kh_C.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_kh_C.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kh_C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_kh_C.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kh_C.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_kh_C.TabIndex = 5
        Me.TxtMa_kh_C.Table_Name = ""
        '
        'TxtTen_kh_C
        '
        Me.TxtTen_kh_C.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh_C.Enabled = False
        Me.TxtTen_kh_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh_C.Location = New System.Drawing.Point(201, 139)
        Me.TxtTen_kh_C.Name = "TxtTen_kh_C"
        Me.TxtTen_kh_C.ReadOnly = True
        Me.TxtTen_kh_C.Size = New System.Drawing.Size(226, 20)
        Me.TxtTen_kh_C.TabIndex = 2177
        Me.TxtTen_kh_C.TabStop = False
        Me.TxtTen_kh_C.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2178
        Me.Label1.Tag = "Customer in debt"
        Me.Label1.Text = "Đối tượng"
        '
        'ChkBL_C
        '
        Me.ChkBL_C.AutoSize = True
        Me.ChkBL_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBL_C.ForeColor = System.Drawing.Color.Red
        Me.ChkBL_C.Location = New System.Drawing.Point(8, 119)
        Me.ChkBL_C.Name = "ChkBL_C"
        Me.ChkBL_C.Size = New System.Drawing.Size(147, 17)
        Me.ChkBL_C.TabIndex = 4
        Me.ChkBL_C.Tag = "Payment guarantee"
        Me.ChkBL_C.Text = "Bảo lãnh khách hàng"
        Me.ChkBL_C.UseVisualStyleBackColor = True
        '
        'TxtTen_Hs_C
        '
        Me.TxtTen_Hs_C.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_C.Enabled = False
        Me.TxtTen_Hs_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_C.Location = New System.Drawing.Point(201, 163)
        Me.TxtTen_Hs_C.Name = "TxtTen_Hs_C"
        Me.TxtTen_Hs_C.ReadOnly = True
        Me.TxtTen_Hs_C.Size = New System.Drawing.Size(226, 20)
        Me.TxtTen_Hs_C.TabIndex = 2175
        Me.TxtTen_Hs_C.TabStop = False
        Me.TxtTen_Hs_C.Tag = ""
        Me.TxtTen_Hs_C.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2176
        Me.Label8.Tag = "Sponsor"
        Me.Label8.Text = "Người XN"
        Me.Label8.UseWaitCursor = True
        '
        'TxtMa_HS_N
        '
        Me.TxtMa_HS_N._ActilookupPopup = False
        Me.TxtMa_HS_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_HS_N.CyberActilookupPopup = True
        Me.TxtMa_HS_N.Dv_ListDetail = Nothing
        Me.TxtMa_HS_N.Dv_Master = Nothing
        Me.TxtMa_HS_N.FilterClient = ""
        Me.TxtMa_HS_N.FilterSQL = ""
        Me.TxtMa_HS_N.Location = New System.Drawing.Point(641, 262)
        Me.TxtMa_HS_N.Name = "TxtMa_HS_N"
        Me.TxtMa_HS_N.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_N.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_N.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_N.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_N.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_HS_N.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_N.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_HS_N.TabIndex = 18
        Me.TxtMa_HS_N.Table_Name = ""
        '
        'TxtMa_HS_W
        '
        Me.TxtMa_HS_W._ActilookupPopup = False
        Me.TxtMa_HS_W.CyberActilookupPopup = True
        Me.TxtMa_HS_W.Dv_ListDetail = Nothing
        Me.TxtMa_HS_W.Dv_Master = Nothing
        Me.TxtMa_HS_W.FilterClient = ""
        Me.TxtMa_HS_W.FilterSQL = ""
        Me.TxtMa_HS_W.Location = New System.Drawing.Point(79, 262)
        Me.TxtMa_HS_W.Name = "TxtMa_HS_W"
        Me.TxtMa_HS_W.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_W.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_W.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_W.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_W.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_HS_W.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_W.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_HS_W.TabIndex = 14
        Me.TxtMa_HS_W.Table_Name = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1001, 8)
        Me.GroupBox2.TabIndex = 2207
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(564, 290)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 2206
        Me.Label9.Tag = "Guar no"
        Me.Label9.Text = "Ghi chú"
        '
        'txtDien_Giai_N
        '
        Me.txtDien_Giai_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDien_Giai_N.BackColor = System.Drawing.Color.White
        Me.txtDien_Giai_N.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDien_Giai_N.Enabled = False
        Me.txtDien_Giai_N.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_Giai_N.Location = New System.Drawing.Point(641, 286)
        Me.txtDien_Giai_N.Name = "txtDien_Giai_N"
        Me.txtDien_Giai_N.Size = New System.Drawing.Size(347, 20)
        Me.txtDien_Giai_N.TabIndex = 19
        Me.txtDien_Giai_N.Tag = ""
        '
        'TxtCL_N
        '
        Me.TxtCL_N.AllowNegative = True
        Me.TxtCL_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCL_N.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCL_N.Flags = 7680
        Me.TxtCL_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCL_N.ForeColor = System.Drawing.Color.Navy
        Me.TxtCL_N.InputMask = "### ### ### ### ###"
        Me.TxtCL_N.Location = New System.Drawing.Point(839, 215)
        Me.TxtCL_N.MaxWholeDigits = 14
        Me.TxtCL_N.Name = "TxtCL_N"
        Me.TxtCL_N.RangeMax = 1.7976931348623157E+308R
        Me.TxtCL_N.RangeMin = -1.7976931348623157E+308R
        Me.TxtCL_N.ReadOnly = True
        Me.TxtCL_N.Size = New System.Drawing.Size(149, 20)
        Me.TxtCL_N.TabIndex = 2205
        Me.TxtCL_N.TabStop = False
        Me.TxtCL_N.Text = "0"
        Me.TxtCL_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Kh_N
        '
        Me.TxtMa_Kh_N._ActilookupPopup = False
        Me.TxtMa_Kh_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Kh_N.CyberActilookupPopup = True
        Me.TxtMa_Kh_N.Dv_ListDetail = Nothing
        Me.TxtMa_Kh_N.Dv_Master = Nothing
        Me.TxtMa_Kh_N.FilterClient = ""
        Me.TxtMa_Kh_N.FilterSQL = ""
        Me.TxtMa_Kh_N.Location = New System.Drawing.Point(641, 238)
        Me.TxtMa_Kh_N.Name = "TxtMa_Kh_N"
        Me.TxtMa_Kh_N.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh_N.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh_N.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh_N.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh_N.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Kh_N.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh_N.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_Kh_N.TabIndex = 17
        Me.TxtMa_Kh_N.Table_Name = ""
        '
        'txtTen_KH_N
        '
        Me.txtTen_KH_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_KH_N.BackColor = System.Drawing.Color.White
        Me.txtTen_KH_N.Enabled = False
        Me.txtTen_KH_N.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_KH_N.Location = New System.Drawing.Point(762, 239)
        Me.txtTen_KH_N.Name = "txtTen_KH_N"
        Me.txtTen_KH_N.ReadOnly = True
        Me.txtTen_KH_N.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_KH_N.TabIndex = 2203
        Me.txtTen_KH_N.TabStop = False
        Me.txtTen_KH_N.Tag = ""
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(564, 244)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 2204
        Me.Label10.Tag = "Customer in debt"
        Me.Label10.Text = "Đối tượng"
        '
        'ChkBL_N
        '
        Me.ChkBL_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBL_N.AutoSize = True
        Me.ChkBL_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBL_N.ForeColor = System.Drawing.Color.Red
        Me.ChkBL_N.Location = New System.Drawing.Point(564, 220)
        Me.ChkBL_N.Name = "ChkBL_N"
        Me.ChkBL_N.Size = New System.Drawing.Size(115, 17)
        Me.ChkBL_N.TabIndex = 16
        Me.ChkBL_N.Tag = "Payment guarantee"
        Me.ChkBL_N.Text = "Bảo lãnh nội bộ"
        Me.ChkBL_N.UseVisualStyleBackColor = True
        '
        'txtTen_Hs_N
        '
        Me.txtTen_Hs_N.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_Hs_N.BackColor = System.Drawing.Color.White
        Me.txtTen_Hs_N.Enabled = False
        Me.txtTen_Hs_N.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Hs_N.Location = New System.Drawing.Point(762, 263)
        Me.txtTen_Hs_N.Name = "txtTen_Hs_N"
        Me.txtTen_Hs_N.ReadOnly = True
        Me.txtTen_Hs_N.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_Hs_N.TabIndex = 2201
        Me.txtTen_Hs_N.TabStop = False
        Me.txtTen_Hs_N.Tag = ""
        Me.txtTen_Hs_N.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(564, 267)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 2202
        Me.Label11.Tag = "Sponsor"
        Me.Label11.Text = "Người XN"
        Me.Label11.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(6, 290)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 2200
        Me.Label12.Tag = "Guar no"
        Me.Label12.Text = "Ghi chú"
        '
        'txtDien_giai_W
        '
        Me.txtDien_giai_W.BackColor = System.Drawing.Color.White
        Me.txtDien_giai_W.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDien_giai_W.Enabled = False
        Me.txtDien_giai_W.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai_W.Location = New System.Drawing.Point(79, 286)
        Me.txtDien_giai_W.Name = "txtDien_giai_W"
        Me.txtDien_giai_W.Size = New System.Drawing.Size(347, 20)
        Me.txtDien_giai_W.TabIndex = 15
        Me.txtDien_giai_W.Tag = ""
        '
        'TxtCL_W
        '
        Me.TxtCL_W.AllowNegative = True
        Me.TxtCL_W.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCL_W.Flags = 7680
        Me.TxtCL_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCL_W.ForeColor = System.Drawing.Color.Navy
        Me.TxtCL_W.InputMask = "### ### ### ### ###"
        Me.TxtCL_W.Location = New System.Drawing.Point(281, 215)
        Me.TxtCL_W.MaxWholeDigits = 14
        Me.TxtCL_W.Name = "TxtCL_W"
        Me.TxtCL_W.RangeMax = 1.7976931348623157E+308R
        Me.TxtCL_W.RangeMin = -1.7976931348623157E+308R
        Me.TxtCL_W.ReadOnly = True
        Me.TxtCL_W.Size = New System.Drawing.Size(145, 20)
        Me.TxtCL_W.TabIndex = 2199
        Me.TxtCL_W.TabStop = False
        Me.TxtCL_W.Text = "0"
        Me.TxtCL_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Kh_W
        '
        Me.TxtMa_Kh_W._ActilookupPopup = False
        Me.TxtMa_Kh_W.CyberActilookupPopup = True
        Me.TxtMa_Kh_W.Dv_ListDetail = Nothing
        Me.TxtMa_Kh_W.Dv_Master = Nothing
        Me.TxtMa_Kh_W.FilterClient = ""
        Me.TxtMa_Kh_W.FilterSQL = ""
        Me.TxtMa_Kh_W.Location = New System.Drawing.Point(79, 238)
        Me.TxtMa_Kh_W.Name = "TxtMa_Kh_W"
        Me.TxtMa_Kh_W.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh_W.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh_W.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh_W.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh_W.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Kh_W.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh_W.Size = New System.Drawing.Size(117, 22)
        Me.TxtMa_Kh_W.TabIndex = 13
        Me.TxtMa_Kh_W.Table_Name = ""
        '
        'txtTen_KH_W
        '
        Me.txtTen_KH_W.BackColor = System.Drawing.Color.White
        Me.txtTen_KH_W.Enabled = False
        Me.txtTen_KH_W.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_KH_W.Location = New System.Drawing.Point(200, 239)
        Me.txtTen_KH_W.Name = "txtTen_KH_W"
        Me.txtTen_KH_W.ReadOnly = True
        Me.txtTen_KH_W.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_KH_W.TabIndex = 2197
        Me.txtTen_KH_W.TabStop = False
        Me.txtTen_KH_W.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(6, 244)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 2198
        Me.Label13.Tag = "Customer in debt"
        Me.Label13.Text = "Đối tượng"
        '
        'ChkBl_W
        '
        Me.ChkBl_W.AutoSize = True
        Me.ChkBl_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBl_W.ForeColor = System.Drawing.Color.Red
        Me.ChkBl_W.Location = New System.Drawing.Point(7, 219)
        Me.ChkBl_W.Name = "ChkBl_W"
        Me.ChkBl_W.Size = New System.Drawing.Size(108, 17)
        Me.ChkBl_W.TabIndex = 12
        Me.ChkBl_W.Tag = "Payment guarantee"
        Me.ChkBl_W.Text = "Bảo lãnh hãng"
        Me.ChkBl_W.UseVisualStyleBackColor = True
        '
        'txtTen_HS_W
        '
        Me.txtTen_HS_W.BackColor = System.Drawing.Color.White
        Me.txtTen_HS_W.Enabled = False
        Me.txtTen_HS_W.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_HS_W.Location = New System.Drawing.Point(200, 263)
        Me.txtTen_HS_W.Name = "txtTen_HS_W"
        Me.txtTen_HS_W.ReadOnly = True
        Me.txtTen_HS_W.Size = New System.Drawing.Size(226, 20)
        Me.txtTen_HS_W.TabIndex = 2195
        Me.txtTen_HS_W.TabStop = False
        Me.txtTen_HS_W.Tag = ""
        Me.txtTen_HS_W.UseWaitCursor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(6, 267)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 2196
        Me.Label14.Tag = "Sponsor"
        Me.Label14.Text = "Người XN"
        Me.Label14.UseWaitCursor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(598, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 2209
        Me.Label15.Tag = "Voucher no."
        Me.Label15.Text = "Số thứ tự"
        '
        'TxtSo_Thu_Tu
        '
        Me.TxtSo_Thu_Tu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSo_Thu_Tu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Thu_Tu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Thu_Tu.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Thu_Tu.Location = New System.Drawing.Point(688, 59)
        Me.TxtSo_Thu_Tu.Name = "TxtSo_Thu_Tu"
        Me.TxtSo_Thu_Tu.Size = New System.Drawing.Size(130, 21)
        Me.TxtSo_Thu_Tu.TabIndex = 4
        Me.TxtSo_Thu_Tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 587)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtSo_Thu_Tu)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtMa_HS_N)
        Me.Controls.Add(Me.TxtMa_HS_W)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDien_Giai_N)
        Me.Controls.Add(Me.TxtCL_N)
        Me.Controls.Add(Me.TxtMa_Kh_N)
        Me.Controls.Add(Me.txtTen_KH_N)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ChkBL_N)
        Me.Controls.Add(Me.txtTen_Hs_N)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDien_giai_W)
        Me.Controls.Add(Me.TxtCL_W)
        Me.Controls.Add(Me.TxtMa_Kh_W)
        Me.Controls.Add(Me.txtTen_KH_W)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ChkBl_W)
        Me.Controls.Add(Me.txtTen_HS_W)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtMa_HS_I)
        Me.Controls.Add(Me.TxtMa_HS_C)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDien_Giai_I)
        Me.Controls.Add(Me.TxtCL_I)
        Me.Controls.Add(Me.TxtMa_kh_I)
        Me.Controls.Add(Me.txtTen_KH_I)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChkBL_I)
        Me.Controls.Add(Me.txtTen_Hs_I)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDien_giai_C)
        Me.Controls.Add(Me.TxtCL_C)
        Me.Controls.Add(Me.TxtMa_kh_C)
        Me.Controls.Add(Me.TxtTen_kh_C)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkBL_C)
        Me.Controls.Add(Me.TxtTen_Hs_C)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChkKH_KS)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.ChkBL_TT)
        Me.Controls.Add(Me.txtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_Bp_H)
        Me.Controls.Add(Me.LabMa_Bp_H)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtT_CL_TT)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtT_Da_TT)
        Me.Controls.Add(Me.lblOng_ba)
        Me.Controls.Add(Me.txtTen_Lx)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtGio_CT)
        Me.Controls.Add(Me.TxtMa_Hs_BL)
        Me.Controls.Add(Me.TxtMa_Hs_H)
        Me.Controls.Add(Me.TxtChuc_Vu_BL)
        Me.Controls.Add(Me.Labchuc_Vu_BL)
        Me.Controls.Add(Me.TxtChuc_Vu)
        Me.Controls.Add(Me.Labchuc_Vu)
        Me.Controls.Add(Me.LabSo_BL)
        Me.Controls.Add(Me.TxtSo_BL)
        Me.Controls.Add(Me.LabNgay_HH)
        Me.Controls.Add(Me.TxtNgay_HH)
        Me.Controls.Add(Me.LabNgay_BL)
        Me.Controls.Add(Me.TxtNgay_BL)
        Me.Controls.Add(Me.TxtTen_Hs_BL)
        Me.Controls.Add(Me.LabMa_Hs_BL)
        Me.Controls.Add(Me.TxtTen_Hs_H)
        Me.Controls.Add(Me.LabMa_HS_H)
        Me.Controls.Add(Me.LblDien_Giai)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.KeyPreview = True
        Me.Name = "TD2"
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
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.LblDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.LabMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BL, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_HH, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_BL, 0)
        Me.Controls.SetChildIndex(Me.LabSo_BL, 0)
        Me.Controls.SetChildIndex(Me.Labchuc_Vu, 0)
        Me.Controls.SetChildIndex(Me.TxtChuc_Vu, 0)
        Me.Controls.SetChildIndex(Me.Labchuc_Vu_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtChuc_Vu_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_BL, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_CT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.lblOng_ba, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Da_TT, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CL_TT, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.ChkBL_TT, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.ChkKH_KS, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_C, 0)
        Me.Controls.SetChildIndex(Me.ChkBL_C, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh_C, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kh_C, 0)
        Me.Controls.SetChildIndex(Me.TxtCL_C, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai_C, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Hs_I, 0)
        Me.Controls.SetChildIndex(Me.ChkBL_I, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtTen_KH_I, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kh_I, 0)
        Me.Controls.SetChildIndex(Me.TxtCL_I, 0)
        Me.Controls.SetChildIndex(Me.txtDien_Giai_I, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_C, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_I, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtTen_HS_W, 0)
        Me.Controls.SetChildIndex(Me.ChkBl_W, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtTen_KH_W, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh_W, 0)
        Me.Controls.SetChildIndex(Me.TxtCL_W, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai_W, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Hs_N, 0)
        Me.Controls.SetChildIndex(Me.ChkBL_N, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtTen_KH_N, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh_N, 0)
        Me.Controls.SetChildIndex(Me.TxtCL_N, 0)
        Me.Controls.SetChildIndex(Me.txtDien_Giai_N, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_W, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_N, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Thu_Tu, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_BL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_I.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kh_I.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kh_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_N.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_W.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh_N.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh_W.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
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
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents LblDien_Giai As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_BL As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_Hs_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtChuc_Vu_BL As System.Windows.Forms.TextBox
    Friend WithEvents Labchuc_Vu_BL As System.Windows.Forms.Label
    Friend WithEvents TxtChuc_Vu As System.Windows.Forms.TextBox
    Friend WithEvents Labchuc_Vu As System.Windows.Forms.Label
    Friend WithEvents LabSo_BL As System.Windows.Forms.Label
    Friend WithEvents TxtSo_BL As System.Windows.Forms.TextBox
    Friend WithEvents LabNgay_HH As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HH As ClsTextBox.txtDate
    Friend WithEvents LabNgay_BL As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BL As ClsTextBox.txtDate
    Friend WithEvents TxtTen_Hs_BL As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Hs_BL As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_H As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_HS_H As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGio_CT As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOng_ba As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtT_CL_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Da_TT As ClsTextBox.txtTien_NT
    Friend WithEvents txtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp_H As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Bp_H As System.Windows.Forms.Label
    Friend WithEvents ChkBL_TT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents ChkKH_KS As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_HS_I As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_HS_C As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDien_Giai_I As System.Windows.Forms.TextBox
    Friend WithEvents TxtCL_I As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_kh_I As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_KH_I As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkBL_I As System.Windows.Forms.CheckBox
    Friend WithEvents txtTen_Hs_I As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtCL_C As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_kh_C As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kh_C As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkBL_C As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_Hs_C As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HS_N As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_HS_W As Cyber.SmLists.TxtLookup
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDien_Giai_N As System.Windows.Forms.TextBox
    Friend WithEvents TxtCL_N As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_Kh_N As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_KH_N As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkBL_N As System.Windows.Forms.CheckBox
    Friend WithEvents txtTen_Hs_N As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai_W As System.Windows.Forms.TextBox
    Friend WithEvents TxtCL_W As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_Kh_W As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_KH_W As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkBl_W As System.Windows.Forms.CheckBox
    Friend WithEvents txtTen_HS_W As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSo_Thu_Tu As TextBox
End Class
