<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDC
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
        Me.CmbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabDia_Chi = New System.Windows.Forms.Label()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.TxtOng_Ba = New System.Windows.Forms.TextBox()
        Me.LabOng_ba = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.TxtSo_Ct = New System.Windows.Forms.TextBox()
        Me.LabMa_kh = New System.Windows.Forms.Label()
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
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_TT_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ChkPx_Gia_DD = New System.Windows.Forms.CheckBox()
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_So_Luong = New ClsTextBox.txtTien_NT()
        Me.TxtTen_KhVAT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDia_ChiVAT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_So_Thue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_H = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Nx = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nx = New System.Windows.Forms.Label()
        Me.TxtTen_VtThue = New System.Windows.Forms.TextBox()
        Me.LabTen_vtthue = New System.Windows.Forms.Label()
        Me.TxtHT_TT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSo_Seri = New System.Windows.Forms.TextBox()
        Me.LabT_Tien_NT = New System.Windows.Forms.Label()
        Me.LabT_Thue_NT = New System.Windows.Forms.Label()
        Me.TxtT_Thue = New ClsTextBox.txtTien_NT()
        Me.TxtT_thue_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtT_Tien2 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT2 = New ClsTextBox.txtTien_NT()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtT_CK = New ClsTextBox.txtTien_NT()
        Me.TxtT_CK_Nt = New ClsTextBox.txtTien_NT()
        Me.TxtTk_Thue_Co = New Cyber.SmLists.TxtLookup()
        Me.LabTk_Thue_No = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtThue_Suat = New ClsTextBox.txtTien_NT()
        Me.TxtMa_Thue = New System.Windows.Forms.TextBox()
        Me.LabTk_Thue_Co = New System.Windows.Forms.Label()
        Me.ChkSua_Thue = New System.Windows.Forms.CheckBox()
        Me.ChkSua_TkThue = New System.Windows.Forms.CheckBox()
        Me.ChkSua_CK = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtHan_TT = New ClsTextBox.txtTien_NT()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ChkSua_Thue_CK = New System.Windows.Forms.CheckBox()
        Me.TxtTk_Thue_No = New Cyber.SmLists.TxtLookup()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.TxtTen_HD_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_HD_H = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNgay_CtHD = New ClsTextBox.txtDate()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtMa_Tra_Cuu = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtSo_seriHD = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtSo_HDDT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtMau_VATHD = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtEmailHDDT = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtNoteHDDT = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.TxtTen_TD3_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_TD3_H = New Cyber.SmLists.TxtLookup()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtMa_NH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NH = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtTien_Vay = New ClsTextBox.txtTien_NT()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtT_BB = New ClsTextBox.txtTien_NT()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TxtT_Km_Khac = New ClsTextBox.txtTien_NT()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TxtT_Moi_Gioi = New ClsTextBox.txtTien_NT()
        Me.TxtT_KM = New ClsTextBox.txtTien_NT()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtT_CP = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Cmt = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtNoi_Cap_Cmt = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TxtNgay_CMT = New ClsTextBox.txtDate()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CmbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtNgay_Gx = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Nx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Thue_Co.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Thue_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TD3_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_NH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(239, 565)
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
        Me.CmdSave.Location = New System.Drawing.Point(-1, 565)
        Me.CmdSave.TabIndex = 17
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
        Me.CmdView.Location = New System.Drawing.Point(478, 565)
        Me.CmdView.TabIndex = 23
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(11, 547)
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
        Me.CmdSms.Location = New System.Drawing.Point(971, 565)
        Me.CmdSms.TabIndex = 26
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
        Me.CmdImport.Location = New System.Drawing.Point(1015, 565)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(80, 542)
        Me.CbbMa_Post.TabIndex = 16
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
        Me.CmdExit.Location = New System.Drawing.Point(637, 565)
        Me.CmdExit.TabIndex = 25
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
        Me.CmdSearch.Location = New System.Drawing.Point(558, 565)
        Me.CmdSearch.TabIndex = 24
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
        Me.CmdCopy.Location = New System.Drawing.Point(399, 565)
        Me.CmdCopy.TabIndex = 22
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
        Me.CmdDelete.Location = New System.Drawing.Point(319, 565)
        Me.CmdDelete.TabIndex = 21
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
        Me.CmdPrint.Location = New System.Drawing.Point(159, 565)
        Me.CmdPrint.TabIndex = 19
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
        Me.CmdNew.Location = New System.Drawing.Point(79, 565)
        Me.CmdNew.TabIndex = 18
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
        Me.CmdCancel.Location = New System.Drawing.Point(239, 565)
        Me.CmdCancel.TabIndex = 20
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
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(910, 564)
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(790, 570)
        '
        'CmbMa_GD
        '
        Me.CmbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_GD.FormattingEnabled = True
        Me.CmbMa_GD.Location = New System.Drawing.Point(242, 33)
        Me.CmbMa_GD.Name = "CmbMa_GD"
        Me.CmbMa_GD.Size = New System.Drawing.Size(136, 23)
        Me.CmbMa_GD.TabIndex = 21
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(1, 215)
        Me.LabDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDia_Chi.Name = "LabDia_Chi"
        Me.LabDia_Chi.Size = New System.Drawing.Size(78, 14)
        Me.LabDia_Chi.TabIndex = 146
        Me.LabDia_Chi.Tag = "Address"
        Me.LabDia_Chi.Text = "Địa chỉ"
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Chi.Location = New System.Drawing.Point(85, 212)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(473, 20)
        Me.TxtDia_Chi.TabIndex = 5
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(730, 38)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(23, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
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
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(630, 212)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(427, 20)
        Me.TxtDien_Giai.TabIndex = 10
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(558, 216)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(69, 14)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Note"
        Me.LabDien_Giai.Text = "Diễn giải"
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
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'TxtOng_Ba
        '
        Me.TxtOng_Ba.BackColor = System.Drawing.Color.White
        Me.TxtOng_Ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtOng_Ba.ForeColor = System.Drawing.Color.Navy
        Me.TxtOng_Ba.Location = New System.Drawing.Point(85, 233)
        Me.TxtOng_Ba.Name = "TxtOng_Ba"
        Me.TxtOng_Ba.Size = New System.Drawing.Size(176, 20)
        Me.TxtOng_Ba.TabIndex = 6
        '
        'LabOng_ba
        '
        Me.LabOng_ba.BackColor = System.Drawing.Color.Transparent
        Me.LabOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.LabOng_ba.Location = New System.Drawing.Point(1, 237)
        Me.LabOng_ba.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOng_ba.Name = "LabOng_ba"
        Me.LabOng_ba.Size = New System.Drawing.Size(78, 14)
        Me.LabOng_ba.TabIndex = 136
        Me.LabOng_ba.Tag = "Receiver"
        Me.LabOng_ba.Text = "Người mua"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(170, 61)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(71, 13)
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
        Me.TxtSo_Ct.Location = New System.Drawing.Point(242, 59)
        Me.TxtSo_Ct.Name = "TxtSo_Ct"
        Me.TxtSo_Ct.Size = New System.Drawing.Size(136, 21)
        Me.TxtSo_Ct.TabIndex = 2
        Me.TxtSo_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_kh
        '
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(1, 193)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(78, 14)
        Me.LabMa_kh.TabIndex = 133
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Đối tượng (KH)"
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(905, 42)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
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
        Me.TxtTy_Gia.Location = New System.Drawing.Point(969, 59)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(88, 21)
        Me.TxtTy_Gia.TabIndex = 20
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(85, 37)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(80, 21)
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
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(85, 59)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(80, 21)
        Me.TxtNgay_Ct.TabIndex = 1
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
        Me.TxtMa_NT.Location = New System.Drawing.Point(969, 37)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(88, 21)
        Me.TxtMa_NT.TabIndex = 19
        Me.TxtMa_NT.TabStop = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(1, 326)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(1057, 129)
        Me.Detail.TabIndex = 15
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
        Me.LabTy_gia.Location = New System.Drawing.Point(905, 61)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(55, 17)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(198, 190)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(360, 20)
        Me.TxtTen_Kh.TabIndex = 155
        Me.TxtTen_Kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(85, 190)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Kh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(111, 20)
        Me.TxtMa_Kh.TabIndex = 4
        Me.TxtMa_Kh.Table_Name = ""
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(10, 137)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(1043, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_TT_NT
        '
        Me.TxtT_TT_NT.AllowNegative = True
        Me.TxtT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT_NT.Flags = 7680
        Me.TxtT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT_NT.Location = New System.Drawing.Point(334, 542)
        Me.TxtT_TT_NT.MaxWholeDigits = 16
        Me.TxtT_TT_NT.Name = "TxtT_TT_NT"
        Me.TxtT_TT_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT_NT.ReadOnly = True
        Me.TxtT_TT_NT.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_TT_NT.TabIndex = 158
        Me.TxtT_TT_NT.TabStop = False
        Me.TxtT_TT_NT.Text = "1.0"
        Me.TxtT_TT_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT.Location = New System.Drawing.Point(446, 542)
        Me.TxtT_TT.MaxWholeDigits = 16
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_TT.TabIndex = 159
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "1.0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(252, 546)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(79, 14)
        Me.LabT_TT_NT.TabIndex = 160
        Me.LabT_TT_NT.Tag = "Total"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(1029, 570)
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(1002, 570)
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
        'ChkPx_Gia_DD
        '
        Me.ChkPx_Gia_DD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPx_Gia_DD.AutoSize = True
        Me.ChkPx_Gia_DD.Location = New System.Drawing.Point(774, 328)
        Me.ChkPx_Gia_DD.Name = "ChkPx_Gia_DD"
        Me.ChkPx_Gia_DD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPx_Gia_DD.Size = New System.Drawing.Size(282, 17)
        Me.ChkPx_Gia_DD.TabIndex = 167
        Me.ChkPx_Gia_DD.TabStop = False
        Me.ChkPx_Gia_DD.Tag = "Output directly price for material in avg method"
        Me.ChkPx_Gia_DD.Text = "Xuất theo giá đích danh cho vật tư tính giá trung bình"
        Me.ChkPx_Gia_DD.UseVisualStyleBackColor = True
        Me.ChkPx_Gia_DD.Visible = False
        '
        'TxtLenh_RO
        '
        Me.TxtLenh_RO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_RO.Location = New System.Drawing.Point(704, 38)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(23, 21)
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
        Me.TxtLenh_PO.Location = New System.Drawing.Point(655, 38)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(23, 21)
        Me.TxtLenh_PO.TabIndex = 170
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(630, 38)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(23, 21)
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
        Me.LabT_So_Luong.Location = New System.Drawing.Point(11, 459)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(70, 14)
        Me.LabT_So_Luong.TabIndex = 175
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng số lượng"
        '
        'TxtT_So_Luong
        '
        Me.TxtT_So_Luong.AllowNegative = True
        Me.TxtT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_So_Luong.BackColor = System.Drawing.Color.White
        Me.TxtT_So_Luong.Flags = 7680
        Me.TxtT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_So_Luong.InputMask = "### ### ### ### ###.#"
        Me.TxtT_So_Luong.Location = New System.Drawing.Point(84, 457)
        Me.TxtT_So_Luong.MaxWholeDigits = 16
        Me.TxtT_So_Luong.Name = "TxtT_So_Luong"
        Me.TxtT_So_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_So_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_So_Luong.ReadOnly = True
        Me.TxtT_So_Luong.Size = New System.Drawing.Size(116, 20)
        Me.TxtT_So_Luong.TabIndex = 174
        Me.TxtT_So_Luong.Text = "0.0"
        Me.TxtT_So_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_KhVAT
        '
        Me.TxtTen_KhVAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_KhVAT.BackColor = System.Drawing.Color.White
        Me.TxtTen_KhVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KhVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KhVAT.Location = New System.Drawing.Point(630, 234)
        Me.TxtTen_KhVAT.Name = "TxtTen_KhVAT"
        Me.TxtTen_KhVAT.Size = New System.Drawing.Size(427, 20)
        Me.TxtTen_KhVAT.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(558, 259)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 178
        Me.Label1.Tag = "Address VAT"
        Me.Label1.Text = "Địa chỉ VAT"
        '
        'TxtDia_ChiVAT
        '
        Me.TxtDia_ChiVAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDia_ChiVAT.BackColor = System.Drawing.Color.White
        Me.TxtDia_ChiVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_ChiVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_ChiVAT.Location = New System.Drawing.Point(630, 256)
        Me.TxtDia_ChiVAT.Name = "TxtDia_ChiVAT"
        Me.TxtDia_ChiVAT.Size = New System.Drawing.Size(427, 20)
        Me.TxtDia_ChiVAT.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(558, 237)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 177
        Me.Label2.Tag = "Name VAT"
        Me.Label2.Text = "Tên VAT"
        '
        'TxtMa_So_Thue
        '
        Me.TxtMa_So_Thue.BackColor = System.Drawing.Color.White
        Me.TxtMa_So_Thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_So_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_So_Thue.Location = New System.Drawing.Point(336, 233)
        Me.TxtMa_So_Thue.Name = "TxtMa_So_Thue"
        Me.TxtMa_So_Thue.Size = New System.Drawing.Size(222, 20)
        Me.TxtMa_So_Thue.TabIndex = 7
        Me.TxtMa_So_Thue.Text = "0101419580-1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(262, 237)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 181
        Me.Label3.Tag = "Receiver"
        Me.Label3.Text = "Mã số thuế"
        '
        'TxtTen_BP_H
        '
        Me.TxtTen_BP_H.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_BP_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_BP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP_H.Location = New System.Drawing.Point(747, 277)
        Me.TxtTen_BP_H.Name = "TxtTen_BP_H"
        Me.TxtTen_BP_H.ReadOnly = True
        Me.TxtTen_BP_H.Size = New System.Drawing.Size(310, 20)
        Me.TxtTen_BP_H.TabIndex = 184
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
        Me.TxtMa_BP_H.Location = New System.Drawing.Point(630, 277)
        Me.TxtMa_BP_H.Name = "TxtMa_BP_H"
        Me.TxtMa_BP_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_BP_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_BP_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_BP_H.TabIndex = 13
        Me.TxtMa_BP_H.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(558, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 183
        Me.Label4.Tag = "Cus code"
        Me.Label4.Text = "Bộ phận"
        '
        'TxtTen_Hs_H
        '
        Me.TxtTen_Hs_H.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Hs_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Hs_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_H.Location = New System.Drawing.Point(747, 298)
        Me.TxtTen_Hs_H.Name = "TxtTen_Hs_H"
        Me.TxtTen_Hs_H.ReadOnly = True
        Me.TxtTen_Hs_H.Size = New System.Drawing.Size(310, 20)
        Me.TxtTen_Hs_H.TabIndex = 187
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
        Me.TxtMa_Hs_H.Location = New System.Drawing.Point(630, 298)
        Me.TxtMa_Hs_H.Name = "TxtMa_Hs_H"
        Me.TxtMa_Hs_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Hs_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Hs_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Hs_H.TabIndex = 14
        Me.TxtMa_Hs_H.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(558, 305)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 186
        Me.Label5.Tag = "Cus code"
        Me.Label5.Text = "Nhân viên"
        '
        'TxtTen_Nx
        '
        Me.TxtTen_Nx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nx.Location = New System.Drawing.Point(198, 255)
        Me.TxtTen_Nx.Name = "TxtTen_Nx"
        Me.TxtTen_Nx.ReadOnly = True
        Me.TxtTen_Nx.Size = New System.Drawing.Size(360, 20)
        Me.TxtTen_Nx.TabIndex = 190
        Me.TxtTen_Nx.TabStop = False
        '
        'TxtMa_Nx
        '
        Me.TxtMa_Nx._ActilookupPopup = False
        Me.TxtMa_Nx.CyberActilookupPopup = True
        Me.TxtMa_Nx.Dv_ListDetail = Nothing
        Me.TxtMa_Nx.Dv_Master = Nothing
        Me.TxtMa_Nx.FilterClient = ""
        Me.TxtMa_Nx.FilterSQL = ""
        Me.TxtMa_Nx.Location = New System.Drawing.Point(85, 255)
        Me.TxtMa_Nx.Name = "TxtMa_Nx"
        Me.TxtMa_Nx.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Nx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Nx.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Nx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Nx.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Nx.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Nx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Nx.Size = New System.Drawing.Size(111, 20)
        Me.TxtMa_Nx.TabIndex = 8
        Me.TxtMa_Nx.Table_Name = ""
        '
        'LabMa_Nx
        '
        Me.LabMa_Nx.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Nx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabMa_Nx.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Nx.Location = New System.Drawing.Point(1, 261)
        Me.LabMa_Nx.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_Nx.Name = "LabMa_Nx"
        Me.LabMa_Nx.Size = New System.Drawing.Size(78, 14)
        Me.LabMa_Nx.TabIndex = 189
        Me.LabMa_Nx.Tag = "Acc credit"
        Me.LabMa_Nx.Text = "Tk Nợ"
        '
        'TxtTen_VtThue
        '
        Me.TxtTen_VtThue.BackColor = System.Drawing.Color.White
        Me.TxtTen_VtThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_VtThue.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_VtThue.Location = New System.Drawing.Point(85, 276)
        Me.TxtTen_VtThue.Name = "TxtTen_VtThue"
        Me.TxtTen_VtThue.Size = New System.Drawing.Size(473, 20)
        Me.TxtTen_VtThue.TabIndex = 9
        '
        'LabTen_vtthue
        '
        Me.LabTen_vtthue.BackColor = System.Drawing.Color.Transparent
        Me.LabTen_vtthue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTen_vtthue.ForeColor = System.Drawing.Color.Navy
        Me.LabTen_vtthue.Location = New System.Drawing.Point(1, 283)
        Me.LabTen_vtthue.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTen_vtthue.Name = "LabTen_vtthue"
        Me.LabTen_vtthue.Size = New System.Drawing.Size(76, 14)
        Me.LabTen_vtthue.TabIndex = 192
        Me.LabTen_vtthue.Tag = "Googs"
        Me.LabTen_vtthue.Text = "Nhóm hàng"
        '
        'TxtHT_TT
        '
        Me.TxtHT_TT.BackColor = System.Drawing.Color.White
        Me.TxtHT_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtHT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtHT_TT.Location = New System.Drawing.Point(450, 38)
        Me.TxtHT_TT.Name = "TxtHT_TT"
        Me.TxtHT_TT.Size = New System.Drawing.Size(108, 20)
        Me.TxtHT_TT.TabIndex = 193
        Me.TxtHT_TT.Text = "TM/CK"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(381, 41)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 14)
        Me.Label8.TabIndex = 194
        Me.Label8.Tag = "Receiver"
        Me.Label8.Text = "Thanh toán"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(381, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 196
        Me.Label9.Tag = "Seri"
        Me.Label9.Text = "Số Seri"
        '
        'TxtSo_Seri
        '
        Me.TxtSo_Seri.BackColor = System.Drawing.Color.White
        Me.TxtSo_Seri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Seri.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Seri.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Seri.Location = New System.Drawing.Point(450, 59)
        Me.TxtSo_Seri.Name = "TxtSo_Seri"
        Me.TxtSo_Seri.Size = New System.Drawing.Size(108, 21)
        Me.TxtSo_Seri.TabIndex = 195
        Me.TxtSo_Seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_Tien_NT
        '
        Me.LabT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_Tien_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Tien_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Tien_NT.Location = New System.Drawing.Point(252, 459)
        Me.LabT_Tien_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Tien_NT.Name = "LabT_Tien_NT"
        Me.LabT_Tien_NT.Size = New System.Drawing.Size(79, 14)
        Me.LabT_Tien_NT.TabIndex = 202
        Me.LabT_Tien_NT.Tag = "Pay cash"
        Me.LabT_Tien_NT.Text = "Tổng vốn"
        '
        'LabT_Thue_NT
        '
        Me.LabT_Thue_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_Thue_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Thue_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_Thue_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Thue_NT.Location = New System.Drawing.Point(252, 501)
        Me.LabT_Thue_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Thue_NT.Name = "LabT_Thue_NT"
        Me.LabT_Thue_NT.Size = New System.Drawing.Size(79, 14)
        Me.LabT_Thue_NT.TabIndex = 201
        Me.LabT_Thue_NT.Tag = "Total tax"
        Me.LabT_Thue_NT.Text = "Tiền thuế"
        '
        'TxtT_Thue
        '
        Me.TxtT_Thue.AllowNegative = True
        Me.TxtT_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Thue.BackColor = System.Drawing.Color.White
        Me.TxtT_Thue.Flags = 7680
        Me.TxtT_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Thue.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Thue.Location = New System.Drawing.Point(446, 499)
        Me.TxtT_Thue.MaxWholeDigits = 16
        Me.TxtT_Thue.Name = "TxtT_Thue"
        Me.TxtT_Thue.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Thue.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Thue.ReadOnly = True
        Me.TxtT_Thue.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_Thue.TabIndex = 200
        Me.TxtT_Thue.TabStop = False
        Me.TxtT_Thue.Text = "1.0"
        Me.TxtT_Thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_thue_NT
        '
        Me.TxtT_thue_NT.AllowNegative = True
        Me.TxtT_thue_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_thue_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_thue_NT.Flags = 7680
        Me.TxtT_thue_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_thue_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_thue_NT.Location = New System.Drawing.Point(334, 499)
        Me.TxtT_thue_NT.MaxWholeDigits = 16
        Me.TxtT_thue_NT.Name = "TxtT_thue_NT"
        Me.TxtT_thue_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_thue_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_thue_NT.ReadOnly = True
        Me.TxtT_thue_NT.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_thue_NT.TabIndex = 199
        Me.TxtT_thue_NT.TabStop = False
        Me.TxtT_thue_NT.Text = "1.0"
        Me.TxtT_thue_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(446, 457)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_Tien.TabIndex = 198
        Me.TxtT_Tien.TabStop = False
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(334, 457)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_Tien_NT.TabIndex = 197
        Me.TxtT_Tien_NT.TabStop = False
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(252, 480)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 14)
        Me.Label10.TabIndex = 205
        Me.Label10.Tag = "Pay cash"
        Me.Label10.Text = "Tổng hàng"
        '
        'TxtT_Tien2
        '
        Me.TxtT_Tien2.AllowNegative = True
        Me.TxtT_Tien2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien2.Flags = 7680
        Me.TxtT_Tien2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien2.Location = New System.Drawing.Point(446, 478)
        Me.TxtT_Tien2.MaxWholeDigits = 16
        Me.TxtT_Tien2.Name = "TxtT_Tien2"
        Me.TxtT_Tien2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien2.ReadOnly = True
        Me.TxtT_Tien2.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_Tien2.TabIndex = 204
        Me.TxtT_Tien2.TabStop = False
        Me.TxtT_Tien2.Text = "1.0"
        Me.TxtT_Tien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien_NT2
        '
        Me.TxtT_Tien_NT2.AllowNegative = True
        Me.TxtT_Tien_NT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT2.Flags = 7680
        Me.TxtT_Tien_NT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT2.Location = New System.Drawing.Point(334, 478)
        Me.TxtT_Tien_NT2.MaxWholeDigits = 16
        Me.TxtT_Tien_NT2.Name = "TxtT_Tien_NT2"
        Me.TxtT_Tien_NT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.ReadOnly = True
        Me.TxtT_Tien_NT2.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_Tien_NT2.TabIndex = 203
        Me.TxtT_Tien_NT2.TabStop = False
        Me.TxtT_Tien_NT2.Text = "1.0"
        Me.TxtT_Tien_NT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(252, 522)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 14)
        Me.Label11.TabIndex = 208
        Me.Label11.Tag = "Total tax"
        Me.Label11.Text = "Chiết khấu"
        '
        'TxtT_CK
        '
        Me.TxtT_CK.AllowNegative = True
        Me.TxtT_CK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_CK.BackColor = System.Drawing.Color.White
        Me.TxtT_CK.Flags = 7680
        Me.TxtT_CK.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_CK.InputMask = "### ### ### ### ###.#"
        Me.TxtT_CK.Location = New System.Drawing.Point(446, 520)
        Me.TxtT_CK.MaxWholeDigits = 16
        Me.TxtT_CK.Name = "TxtT_CK"
        Me.TxtT_CK.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CK.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CK.ReadOnly = True
        Me.TxtT_CK.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_CK.TabIndex = 207
        Me.TxtT_CK.TabStop = False
        Me.TxtT_CK.Text = "1.0"
        Me.TxtT_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_CK_Nt
        '
        Me.TxtT_CK_Nt.AllowNegative = True
        Me.TxtT_CK_Nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_CK_Nt.BackColor = System.Drawing.Color.White
        Me.TxtT_CK_Nt.Flags = 7680
        Me.TxtT_CK_Nt.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_CK_Nt.InputMask = "### ### ### ### ###.#"
        Me.TxtT_CK_Nt.Location = New System.Drawing.Point(334, 520)
        Me.TxtT_CK_Nt.MaxWholeDigits = 16
        Me.TxtT_CK_Nt.Name = "TxtT_CK_Nt"
        Me.TxtT_CK_Nt.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CK_Nt.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CK_Nt.ReadOnly = True
        Me.TxtT_CK_Nt.Size = New System.Drawing.Size(109, 20)
        Me.TxtT_CK_Nt.TabIndex = 206
        Me.TxtT_CK_Nt.TabStop = False
        Me.TxtT_CK_Nt.Text = "1.0"
        Me.TxtT_CK_Nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTk_Thue_Co
        '
        Me.TxtTk_Thue_Co._ActilookupPopup = False
        Me.TxtTk_Thue_Co.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTk_Thue_Co.CyberActilookupPopup = True
        Me.TxtTk_Thue_Co.Dv_ListDetail = Nothing
        Me.TxtTk_Thue_Co.Dv_Master = Nothing
        Me.TxtTk_Thue_Co.FilterClient = ""
        Me.TxtTk_Thue_Co.FilterSQL = ""
        Me.TxtTk_Thue_Co.Location = New System.Drawing.Point(84, 520)
        Me.TxtTk_Thue_Co.Name = "TxtTk_Thue_Co"
        Me.TxtTk_Thue_Co.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Thue_Co.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Thue_Co.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Thue_Co.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Thue_Co.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Thue_Co.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Thue_Co.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Thue_Co.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk_Thue_Co.TabIndex = 209
        Me.TxtTk_Thue_Co.Table_Name = ""
        Me.TxtTk_Thue_Co.TabStop = False
        '
        'LabTk_Thue_No
        '
        Me.LabTk_Thue_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTk_Thue_No.BackColor = System.Drawing.Color.Transparent
        Me.LabTk_Thue_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTk_Thue_No.ForeColor = System.Drawing.Color.Navy
        Me.LabTk_Thue_No.Location = New System.Drawing.Point(11, 501)
        Me.LabTk_Thue_No.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTk_Thue_No.Name = "LabTk_Thue_No"
        Me.LabTk_Thue_No.Size = New System.Drawing.Size(70, 13)
        Me.LabTk_Thue_No.TabIndex = 210
        Me.LabTk_Thue_No.Tag = "Acc Credit Tax"
        Me.LabTk_Thue_No.Text = "TK thuế nợ"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(11, 480)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 212
        Me.Label13.Tag = "Tax Acc"
        Me.Label13.Text = "Thuế suất"
        '
        'TxtThue_Suat
        '
        Me.TxtThue_Suat.AllowNegative = True
        Me.TxtThue_Suat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtThue_Suat.BackColor = System.Drawing.Color.White
        Me.TxtThue_Suat.Flags = 7680
        Me.TxtThue_Suat.ForeColor = System.Drawing.Color.Navy
        Me.TxtThue_Suat.InputMask = "###"
        Me.TxtThue_Suat.Location = New System.Drawing.Point(138, 478)
        Me.TxtThue_Suat.MaxWholeDigits = 10
        Me.TxtThue_Suat.Name = "TxtThue_Suat"
        Me.TxtThue_Suat.RangeMax = 1.7976931348623157E+308R
        Me.TxtThue_Suat.RangeMin = -1.7976931348623157E+308R
        Me.TxtThue_Suat.ReadOnly = True
        Me.TxtThue_Suat.Size = New System.Drawing.Size(42, 20)
        Me.TxtThue_Suat.TabIndex = 213
        Me.TxtThue_Suat.TabStop = False
        Me.TxtThue_Suat.Text = "0"
        Me.TxtThue_Suat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMa_Thue
        '
        Me.TxtMa_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Thue.BackColor = System.Drawing.Color.White
        Me.TxtMa_Thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Thue.Location = New System.Drawing.Point(84, 478)
        Me.TxtMa_Thue.Name = "TxtMa_Thue"
        Me.TxtMa_Thue.Size = New System.Drawing.Size(52, 20)
        Me.TxtMa_Thue.TabIndex = 214
        Me.TxtMa_Thue.Text = "10"
        '
        'LabTk_Thue_Co
        '
        Me.LabTk_Thue_Co.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTk_Thue_Co.BackColor = System.Drawing.Color.Transparent
        Me.LabTk_Thue_Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabTk_Thue_Co.ForeColor = System.Drawing.Color.Navy
        Me.LabTk_Thue_Co.Location = New System.Drawing.Point(11, 522)
        Me.LabTk_Thue_Co.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTk_Thue_Co.Name = "LabTk_Thue_Co"
        Me.LabTk_Thue_Co.Size = New System.Drawing.Size(70, 13)
        Me.LabTk_Thue_Co.TabIndex = 216
        Me.LabTk_Thue_Co.Tag = "Acc debit Tax"
        Me.LabTk_Thue_Co.Text = "TK thuế có"
        '
        'ChkSua_Thue
        '
        Me.ChkSua_Thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_Thue.AutoSize = True
        Me.ChkSua_Thue.Location = New System.Drawing.Point(811, 478)
        Me.ChkSua_Thue.Name = "ChkSua_Thue"
        Me.ChkSua_Thue.Size = New System.Drawing.Size(71, 17)
        Me.ChkSua_Thue.TabIndex = 217
        Me.ChkSua_Thue.TabStop = False
        Me.ChkSua_Thue.Tag = "Total tax"
        Me.ChkSua_Thue.Text = "Tiền thuế"
        Me.ChkSua_Thue.UseVisualStyleBackColor = True
        '
        'ChkSua_TkThue
        '
        Me.ChkSua_TkThue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_TkThue.AutoSize = True
        Me.ChkSua_TkThue.Location = New System.Drawing.Point(811, 516)
        Me.ChkSua_TkThue.Name = "ChkSua_TkThue"
        Me.ChkSua_TkThue.Size = New System.Drawing.Size(100, 17)
        Me.ChkSua_TkThue.TabIndex = 218
        Me.ChkSua_TkThue.TabStop = False
        Me.ChkSua_TkThue.Tag = "Maturity tax"
        Me.ChkSua_TkThue.Text = "Hạch toán thuế"
        Me.ChkSua_TkThue.UseVisualStyleBackColor = True
        '
        'ChkSua_CK
        '
        Me.ChkSua_CK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_CK.AutoSize = True
        Me.ChkSua_CK.Location = New System.Drawing.Point(811, 535)
        Me.ChkSua_CK.Name = "ChkSua_CK"
        Me.ChkSua_CK.Size = New System.Drawing.Size(105, 17)
        Me.ChkSua_CK.TabIndex = 219
        Me.ChkSua_CK.TabStop = False
        Me.ChkSua_CK.Tag = "Discount"
        Me.ChkSua_CK.Text = "Nhập chiết khấu"
        Me.ChkSua_CK.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(972, 495)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 14)
        Me.Label15.TabIndex = 221
        Me.Label15.Tag = "Total"
        Me.Label15.Text = "Hạn thanh toán"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtHan_TT
        '
        Me.TxtHan_TT.AllowNegative = True
        Me.TxtHan_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHan_TT.BackColor = System.Drawing.Color.White
        Me.TxtHan_TT.Flags = 7680
        Me.TxtHan_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtHan_TT.InputMask = "### ###"
        Me.TxtHan_TT.Location = New System.Drawing.Point(975, 514)
        Me.TxtHan_TT.MaxWholeDigits = 5
        Me.TxtHan_TT.Name = "TxtHan_TT"
        Me.TxtHan_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtHan_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtHan_TT.ReadOnly = True
        Me.TxtHan_TT.Size = New System.Drawing.Size(38, 20)
        Me.TxtHan_TT.TabIndex = 220
        Me.TxtHan_TT.Text = "0"
        Me.TxtHan_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(1016, 515)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 222
        Me.Label16.Tag = "Day"
        Me.Label16.Text = "Ngày"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(185, 480)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 18)
        Me.Label17.TabIndex = 223
        Me.Label17.Tag = "%"
        Me.Label17.Text = "%"
        '
        'ChkSua_Thue_CK
        '
        Me.ChkSua_Thue_CK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSua_Thue_CK.AutoSize = True
        Me.ChkSua_Thue_CK.Location = New System.Drawing.Point(811, 497)
        Me.ChkSua_Thue_CK.Name = "ChkSua_Thue_CK"
        Me.ChkSua_Thue_CK.Size = New System.Drawing.Size(124, 17)
        Me.ChkSua_Thue_CK.TabIndex = 224
        Me.ChkSua_Thue_CK.TabStop = False
        Me.ChkSua_Thue_CK.Tag = "Tax after discount"
        Me.ChkSua_Thue_CK.Text = "Thuế sau chiết khấu"
        Me.ChkSua_Thue_CK.UseVisualStyleBackColor = True
        '
        'TxtTk_Thue_No
        '
        Me.TxtTk_Thue_No._ActilookupPopup = False
        Me.TxtTk_Thue_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTk_Thue_No.CyberActilookupPopup = True
        Me.TxtTk_Thue_No.Dv_ListDetail = Nothing
        Me.TxtTk_Thue_No.Dv_Master = Nothing
        Me.TxtTk_Thue_No.FilterClient = ""
        Me.TxtTk_Thue_No.FilterSQL = ""
        Me.TxtTk_Thue_No.Location = New System.Drawing.Point(84, 499)
        Me.TxtTk_Thue_No.Name = "TxtTk_Thue_No"
        Me.TxtTk_Thue_No.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Thue_No.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Thue_No.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Thue_No.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Thue_No.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Thue_No.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Thue_No.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Thue_No.Size = New System.Drawing.Size(116, 20)
        Me.TxtTk_Thue_No.TabIndex = 225
        Me.TxtTk_Thue_No.Table_Name = ""
        Me.TxtTk_Thue_No.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(790, 459)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 98)
        Me.GroupBox1.TabIndex = 227
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "Option"
        Me.GroupBox1.Text = "Tùy chọn"
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(679, 38)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(23, 21)
        Me.TxtLenh_Vt.TabIndex = 243
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'TxtTen_HD_H
        '
        Me.TxtTen_HD_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_HD_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HD_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD_H.Location = New System.Drawing.Point(198, 169)
        Me.TxtTen_HD_H.Name = "TxtTen_HD_H"
        Me.TxtTen_HD_H.ReadOnly = True
        Me.TxtTen_HD_H.Size = New System.Drawing.Size(360, 20)
        Me.TxtTen_HD_H.TabIndex = 246
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
        Me.TxtMa_HD_H.Location = New System.Drawing.Point(85, 169)
        Me.TxtMa_HD_H.Name = "TxtMa_HD_H"
        Me.TxtMa_HD_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HD_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HD_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HD_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HD_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD_H.Size = New System.Drawing.Size(111, 20)
        Me.TxtMa_HD_H.TabIndex = 244
        Me.TxtMa_HD_H.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(1, 172)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 245
        Me.Label6.Tag = "Contract"
        Me.Label6.Text = "Hợp đồng"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1052, 8)
        Me.GroupBox2.TabIndex = 1900
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(1, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 14)
        Me.Label7.TabIndex = 1901
        Me.Label7.Tag = "Googs"
        Me.Label7.Text = "Hóa đơn điện tử"
        '
        'TxtNgay_CtHD
        '
        Me.TxtNgay_CtHD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_CtHD.Flags = 65536
        Me.TxtNgay_CtHD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CtHD.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_CtHD.isEmpty = True
        Me.TxtNgay_CtHD.Location = New System.Drawing.Point(450, 118)
        Me.TxtNgay_CtHD.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CtHD.MaxLength = 10
        Me.TxtNgay_CtHD.Name = "TxtNgay_CtHD"
        Me.TxtNgay_CtHD.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CtHD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CtHD.ReadOnly = True
        Me.TxtNgay_CtHD.ShowDayBeforeMonth = False
        Me.TxtNgay_CtHD.Size = New System.Drawing.Size(108, 21)
        Me.TxtNgay_CtHD.TabIndex = 1914
        Me.TxtNgay_CtHD.Text = "18/09/2011"
        Me.TxtNgay_CtHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_CtHD.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(372, 121)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 1915
        Me.Label21.Tag = "Voucher date"
        Me.Label21.Text = "Ngày HĐĐT"
        '
        'TxtMa_Tra_Cuu
        '
        Me.TxtMa_Tra_Cuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Tra_Cuu.BackColor = System.Drawing.Color.White
        Me.TxtMa_Tra_Cuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Tra_Cuu.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Tra_Cuu.Location = New System.Drawing.Point(910, 118)
        Me.TxtMa_Tra_Cuu.Name = "TxtMa_Tra_Cuu"
        Me.TxtMa_Tra_Cuu.Size = New System.Drawing.Size(147, 20)
        Me.TxtMa_Tra_Cuu.TabIndex = 1913
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(837, 121)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 14)
        Me.Label18.TabIndex = 1912
        Me.Label18.Tag = "Name VAT"
        Me.Label18.Text = "Mã tra cứu"
        '
        'TxtSo_seriHD
        '
        Me.TxtSo_seriHD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_seriHD.BackColor = System.Drawing.Color.White
        Me.TxtSo_seriHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSo_seriHD.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_seriHD.Location = New System.Drawing.Point(910, 97)
        Me.TxtSo_seriHD.Name = "TxtSo_seriHD"
        Me.TxtSo_seriHD.Size = New System.Drawing.Size(147, 20)
        Me.TxtSo_seriHD.TabIndex = 1911
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(837, 100)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 14)
        Me.Label19.TabIndex = 1910
        Me.Label19.Tag = "Name VAT"
        Me.Label19.Text = "Ký hiệu"
        '
        'TxtSo_HDDT
        '
        Me.TxtSo_HDDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_HDDT.BackColor = System.Drawing.Color.White
        Me.TxtSo_HDDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSo_HDDT.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_HDDT.Location = New System.Drawing.Point(630, 118)
        Me.TxtSo_HDDT.Name = "TxtSo_HDDT"
        Me.TxtSo_HDDT.Size = New System.Drawing.Size(109, 20)
        Me.TxtSo_HDDT.TabIndex = 1909
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(558, 121)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 14)
        Me.Label14.TabIndex = 1908
        Me.Label14.Tag = "Name VAT"
        Me.Label14.Text = "Số HĐ"
        '
        'TxtMau_VATHD
        '
        Me.TxtMau_VATHD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMau_VATHD.BackColor = System.Drawing.Color.White
        Me.TxtMau_VATHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMau_VATHD.ForeColor = System.Drawing.Color.Blue
        Me.TxtMau_VATHD.Location = New System.Drawing.Point(630, 97)
        Me.TxtMau_VATHD.Name = "TxtMau_VATHD"
        Me.TxtMau_VATHD.Size = New System.Drawing.Size(109, 20)
        Me.TxtMau_VATHD.TabIndex = 1907
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(558, 100)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 1906
        Me.Label12.Tag = "Name VAT"
        Me.Label12.Text = "Mẫu số HĐ"
        '
        'TxtEmailHDDT
        '
        Me.TxtEmailHDDT.BackColor = System.Drawing.Color.White
        Me.TxtEmailHDDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtEmailHDDT.ForeColor = System.Drawing.Color.Blue
        Me.TxtEmailHDDT.Location = New System.Drawing.Point(85, 118)
        Me.TxtEmailHDDT.Name = "TxtEmailHDDT"
        Me.TxtEmailHDDT.Size = New System.Drawing.Size(286, 20)
        Me.TxtEmailHDDT.TabIndex = 1902
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(1, 121)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 14)
        Me.Label20.TabIndex = 1905
        Me.Label20.Tag = "Googs"
        Me.Label20.Text = "Email Nhận HĐ"
        '
        'TxtNoteHDDT
        '
        Me.TxtNoteHDDT.BackColor = System.Drawing.Color.White
        Me.TxtNoteHDDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNoteHDDT.ForeColor = System.Drawing.Color.Blue
        Me.TxtNoteHDDT.Location = New System.Drawing.Point(85, 97)
        Me.TxtNoteHDDT.Name = "TxtNoteHDDT"
        Me.TxtNoteHDDT.Size = New System.Drawing.Size(473, 20)
        Me.TxtNoteHDDT.TabIndex = 1903
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(1, 100)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 14)
        Me.Label22.TabIndex = 1904
        Me.Label22.Tag = "Googs"
        Me.Label22.Text = "Note HĐ ĐT"
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(991, 543)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2133
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'TxtTen_TD3_H
        '
        Me.TxtTen_TD3_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_TD3_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TD3_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TD3_H.Location = New System.Drawing.Point(198, 147)
        Me.TxtTen_TD3_H.Name = "TxtTen_TD3_H"
        Me.TxtTen_TD3_H.ReadOnly = True
        Me.TxtTen_TD3_H.Size = New System.Drawing.Size(360, 20)
        Me.TxtTen_TD3_H.TabIndex = 2136
        Me.TxtTen_TD3_H.TabStop = False
        '
        'TxtMa_TD3_H
        '
        Me.TxtMa_TD3_H._ActilookupPopup = False
        Me.TxtMa_TD3_H.CyberActilookupPopup = True
        Me.TxtMa_TD3_H.Dv_ListDetail = Nothing
        Me.TxtMa_TD3_H.Dv_Master = Nothing
        Me.TxtMa_TD3_H.FilterClient = ""
        Me.TxtMa_TD3_H.FilterSQL = ""
        Me.TxtMa_TD3_H.Location = New System.Drawing.Point(85, 147)
        Me.TxtMa_TD3_H.Name = "TxtMa_TD3_H"
        Me.TxtMa_TD3_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_TD3_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TD3_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_TD3_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TD3_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_TD3_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_TD3_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TD3_H.Size = New System.Drawing.Size(111, 20)
        Me.TxtMa_TD3_H.TabIndex = 3
        Me.TxtMa_TD3_H.Table_Name = ""
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(1, 150)
        Me.Label23.Margin = New System.Windows.Forms.Padding(0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 14)
        Me.Label23.TabIndex = 2135
        Me.Label23.Tag = "Contract detail"
        Me.Label23.Text = "Xe theo HĐ"
        '
        'TxtMa_NH
        '
        Me.TxtMa_NH._ActilookupPopup = False
        Me.TxtMa_NH.CyberActilookupPopup = True
        Me.TxtMa_NH.Dv_ListDetail = Nothing
        Me.TxtMa_NH.Dv_Master = Nothing
        Me.TxtMa_NH.FilterClient = ""
        Me.TxtMa_NH.FilterSQL = ""
        Me.TxtMa_NH.Location = New System.Drawing.Point(630, 147)
        Me.TxtMa_NH.Name = "TxtMa_NH"
        Me.TxtMa_NH.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_NH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NH.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_NH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_NH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_NH.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_NH.TabIndex = 2137
        Me.TxtMa_NH.Table_Name = ""
        '
        'TxtTen_NH
        '
        Me.TxtTen_NH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_NH.BackColor = System.Drawing.Color.White
        Me.TxtTen_NH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_NH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NH.Location = New System.Drawing.Point(747, 147)
        Me.TxtTen_NH.Name = "TxtTen_NH"
        Me.TxtTen_NH.Size = New System.Drawing.Size(310, 20)
        Me.TxtTen_NH.TabIndex = 2138
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(561, 150)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 13)
        Me.Label26.TabIndex = 2139
        Me.Label26.Tag = "Bank"
        Me.Label26.Text = "NH trả góp"
        '
        'TxtTien_Vay
        '
        Me.TxtTien_Vay.AllowNegative = True
        Me.TxtTien_Vay.BackColor = System.Drawing.Color.White
        Me.TxtTien_Vay.Flags = 7680
        Me.TxtTien_Vay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Vay.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_Vay.Location = New System.Drawing.Point(630, 169)
        Me.TxtTien_Vay.MaxWholeDigits = 16
        Me.TxtTien_Vay.Name = "TxtTien_Vay"
        Me.TxtTien_Vay.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Vay.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Vay.Size = New System.Drawing.Size(116, 20)
        Me.TxtTien_Vay.TabIndex = 2140
        Me.TxtTien_Vay.TabStop = False
        Me.TxtTien_Vay.Text = "1.0"
        Me.TxtTien_Vay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(561, 169)
        Me.Label24.Margin = New System.Windows.Forms.Padding(0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 2141
        Me.Label24.Tag = "Value Bank"
        Me.Label24.Text = "GT trả góp"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(574, 479)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 13)
        Me.Label28.TabIndex = 2151
        Me.Label28.Tag = "Required accs, ins"
        Me.Label28.Text = "PK, BH Bắt buộc"
        '
        'TxtT_BB
        '
        Me.TxtT_BB.AllowNegative = True
        Me.TxtT_BB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_BB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtT_BB.Flags = 7680
        Me.TxtT_BB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtT_BB.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_BB.InputMask = "### ### ### ### ### ###"
        Me.TxtT_BB.Location = New System.Drawing.Point(676, 477)
        Me.TxtT_BB.MaxWholeDigits = 17
        Me.TxtT_BB.Name = "TxtT_BB"
        Me.TxtT_BB.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_BB.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_BB.Size = New System.Drawing.Size(109, 21)
        Me.TxtT_BB.TabIndex = 2150
        Me.TxtT_BB.TabStop = False
        Me.TxtT_BB.Text = "0"
        Me.TxtT_BB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(574, 459)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 13)
        Me.Label25.TabIndex = 2149
        Me.Label25.Tag = "Promotion"
        Me.Label25.Text = "Khuyến mại PK, BH"
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(574, 523)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(68, 13)
        Me.Label40.TabIndex = 2148
        Me.Label40.Tag = "Others"
        Me.Label40.Text = "Chi phí khác"
        '
        'TxtT_Km_Khac
        '
        Me.TxtT_Km_Khac.AllowNegative = True
        Me.TxtT_Km_Khac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Km_Khac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtT_Km_Khac.Flags = 7680
        Me.TxtT_Km_Khac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtT_Km_Khac.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Km_Khac.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Km_Khac.Location = New System.Drawing.Point(676, 519)
        Me.TxtT_Km_Khac.MaxWholeDigits = 17
        Me.TxtT_Km_Khac.Name = "TxtT_Km_Khac"
        Me.TxtT_Km_Khac.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Km_Khac.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Km_Khac.ReadOnly = True
        Me.TxtT_Km_Khac.Size = New System.Drawing.Size(109, 21)
        Me.TxtT_Km_Khac.TabIndex = 2144
        Me.TxtT_Km_Khac.TabStop = False
        Me.TxtT_Km_Khac.Text = "0"
        Me.TxtT_Km_Khac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(574, 502)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 13)
        Me.Label39.TabIndex = 2147
        Me.Label39.Tag = "Brokage"
        Me.Label39.Text = "Môi giới"
        '
        'TxtT_Moi_Gioi
        '
        Me.TxtT_Moi_Gioi.AllowNegative = True
        Me.TxtT_Moi_Gioi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Moi_Gioi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtT_Moi_Gioi.Flags = 7680
        Me.TxtT_Moi_Gioi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtT_Moi_Gioi.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Moi_Gioi.InputMask = "### ### ### ### ### ###"
        Me.TxtT_Moi_Gioi.Location = New System.Drawing.Point(676, 498)
        Me.TxtT_Moi_Gioi.MaxWholeDigits = 17
        Me.TxtT_Moi_Gioi.Name = "TxtT_Moi_Gioi"
        Me.TxtT_Moi_Gioi.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Moi_Gioi.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Moi_Gioi.ReadOnly = True
        Me.TxtT_Moi_Gioi.Size = New System.Drawing.Size(109, 21)
        Me.TxtT_Moi_Gioi.TabIndex = 2143
        Me.TxtT_Moi_Gioi.TabStop = False
        Me.TxtT_Moi_Gioi.Text = "0"
        Me.TxtT_Moi_Gioi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_KM
        '
        Me.TxtT_KM.AllowNegative = True
        Me.TxtT_KM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_KM.Flags = 7680
        Me.TxtT_KM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtT_KM.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KM.InputMask = "### ### ### ### ### ###"
        Me.TxtT_KM.Location = New System.Drawing.Point(676, 457)
        Me.TxtT_KM.MaxWholeDigits = 17
        Me.TxtT_KM.Name = "TxtT_KM"
        Me.TxtT_KM.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KM.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KM.Size = New System.Drawing.Size(109, 21)
        Me.TxtT_KM.TabIndex = 2142
        Me.TxtT_KM.TabStop = False
        Me.TxtT_KM.Text = "0"
        Me.TxtT_KM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(574, 547)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 13)
        Me.Label29.TabIndex = 2146
        Me.Label29.Tag = "Total"
        Me.Label29.Text = "Tổng cộng"
        '
        'TxtT_CP
        '
        Me.TxtT_CP.AllowNegative = True
        Me.TxtT_CP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_CP.BackColor = System.Drawing.Color.Lavender
        Me.TxtT_CP.Flags = 7680
        Me.TxtT_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtT_CP.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_CP.InputMask = "### ### ### ### ### ###"
        Me.TxtT_CP.Location = New System.Drawing.Point(676, 541)
        Me.TxtT_CP.MaxWholeDigits = 17
        Me.TxtT_CP.Name = "TxtT_CP"
        Me.TxtT_CP.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_CP.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_CP.ReadOnly = True
        Me.TxtT_CP.Size = New System.Drawing.Size(109, 21)
        Me.TxtT_CP.TabIndex = 2145
        Me.TxtT_CP.TabStop = False
        Me.TxtT_CP.Text = "0"
        Me.TxtT_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Cmt
        '
        Me.TxtSo_Cmt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_Cmt.BackColor = System.Drawing.Color.White
        Me.TxtSo_Cmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSo_Cmt.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Cmt.Location = New System.Drawing.Point(835, 169)
        Me.TxtSo_Cmt.Name = "TxtSo_Cmt"
        Me.TxtSo_Cmt.Size = New System.Drawing.Size(222, 20)
        Me.TxtSo_Cmt.TabIndex = 2152
        Me.TxtSo_Cmt.Text = "0101419580-1"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(751, 171)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 14)
        Me.Label27.TabIndex = 2153
        Me.Label27.Tag = "Receiver"
        Me.Label27.Text = "Số CMT"
        '
        'TxtNoi_Cap_Cmt
        '
        Me.TxtNoi_Cap_Cmt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNoi_Cap_Cmt.BackColor = System.Drawing.Color.White
        Me.TxtNoi_Cap_Cmt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Cap_Cmt.Location = New System.Drawing.Point(835, 190)
        Me.TxtNoi_Cap_Cmt.Name = "TxtNoi_Cap_Cmt"
        Me.TxtNoi_Cap_Cmt.Size = New System.Drawing.Size(222, 20)
        Me.TxtNoi_Cap_Cmt.TabIndex = 2157
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Navy
        Me.Label79.Location = New System.Drawing.Point(751, 189)
        Me.Label79.Margin = New System.Windows.Forms.Padding(0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(71, 14)
        Me.Label79.TabIndex = 2156
        Me.Label79.Tag = "Location"
        Me.Label79.Text = "Nơi cấp"
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Navy
        Me.Label78.Location = New System.Drawing.Point(561, 189)
        Me.Label78.Margin = New System.Windows.Forms.Padding(0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(58, 14)
        Me.Label78.TabIndex = 2155
        Me.Label78.Tag = "Day"
        Me.Label78.Text = "Ngày cấp"
        '
        'TxtNgay_CMT
        '
        Me.TxtNgay_CMT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_CMT.Flags = 65536
        Me.TxtNgay_CMT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CMT.isEmpty = True
        Me.TxtNgay_CMT.Location = New System.Drawing.Point(630, 190)
        Me.TxtNgay_CMT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CMT.MaxLength = 10
        Me.TxtNgay_CMT.Name = "TxtNgay_CMT"
        Me.TxtNgay_CMT.RangeMax = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CMT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CMT.ReadOnly = True
        Me.TxtNgay_CMT.ShowDayBeforeMonth = False
        Me.TxtNgay_CMT.Size = New System.Drawing.Size(112, 20)
        Me.TxtNgay_CMT.TabIndex = 2154
        Me.TxtNgay_CMT.Text = "__/__/____"
        Me.TxtNgay_CMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_CMT.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(701, 4)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(155, 20)
        Me.LabMa_TTCP_H.TabIndex = 2159
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbMa_TTCP_H
        '
        Me.CmbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TTCP_H.FormattingEnabled = True
        Me.CmbMa_TTCP_H.Location = New System.Drawing.Point(863, 1)
        Me.CmbMa_TTCP_H.Name = "CmbMa_TTCP_H"
        Me.CmbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CmbMa_TTCP_H.TabIndex = 2158
        Me.CmbMa_TTCP_H.TabStop = False
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(558, 61)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 2161
        Me.Label30.Tag = "Delivered"
        Me.Label30.Text = "Ngày G.Xe"
        '
        'TxtNgay_Gx
        '
        Me.TxtNgay_Gx.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Gx.Flags = 0
        Me.TxtNgay_Gx.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Gx.ForeColor = System.Drawing.Color.Red
        Me.TxtNgay_Gx.IsAllowResize = False
        Me.TxtNgay_Gx.Location = New System.Drawing.Point(630, 59)
        Me.TxtNgay_Gx.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Gx.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Gx.MaxLength = 10
        Me.TxtNgay_Gx.Name = "TxtNgay_Gx"
        Me.TxtNgay_Gx.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Gx.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Gx.ShowDayBeforeMonth = False
        Me.TxtNgay_Gx.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_Gx.TabIndex = 7136
        Me.TxtNgay_Gx.Value = "20/08/2021 14:38"
        '
        'HDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1062, 621)
        Me.Controls.Add(Me.TxtNgay_Gx)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CmbMa_TTCP_H)
        Me.Controls.Add(Me.TxtNoi_Cap_Cmt)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.TxtNgay_CMT)
        Me.Controls.Add(Me.TxtSo_Cmt)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtT_BB)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.TxtT_Km_Khac)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TxtT_Moi_Gioi)
        Me.Controls.Add(Me.TxtT_KM)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtT_CP)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtTien_Vay)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtMa_NH)
        Me.Controls.Add(Me.TxtTen_NH)
        Me.Controls.Add(Me.TxtTen_TD3_H)
        Me.Controls.Add(Me.TxtMa_TD3_H)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.TxtNgay_CtHD)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtMa_Tra_Cuu)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtSo_seriHD)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtSo_HDDT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtMau_VATHD)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtEmailHDDT)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtNoteHDDT)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtTen_HD_H)
        Me.Controls.Add(Me.TxtMa_HD_H)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.TxtTk_Thue_No)
        Me.Controls.Add(Me.ChkSua_Thue_CK)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtHan_TT)
        Me.Controls.Add(Me.ChkSua_CK)
        Me.Controls.Add(Me.ChkSua_TkThue)
        Me.Controls.Add(Me.ChkSua_Thue)
        Me.Controls.Add(Me.LabTk_Thue_Co)
        Me.Controls.Add(Me.TxtMa_Thue)
        Me.Controls.Add(Me.TxtThue_Suat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTk_Thue_Co)
        Me.Controls.Add(Me.LabTk_Thue_No)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtT_CK)
        Me.Controls.Add(Me.TxtT_CK_Nt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtT_Tien2)
        Me.Controls.Add(Me.TxtT_Tien_NT2)
        Me.Controls.Add(Me.LabT_Tien_NT)
        Me.Controls.Add(Me.LabT_Thue_NT)
        Me.Controls.Add(Me.TxtT_Thue)
        Me.Controls.Add(Me.TxtT_thue_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSo_Seri)
        Me.Controls.Add(Me.TxtHT_TT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_VtThue)
        Me.Controls.Add(Me.LabTen_vtthue)
        Me.Controls.Add(Me.TxtTen_Nx)
        Me.Controls.Add(Me.TxtMa_Nx)
        Me.Controls.Add(Me.LabMa_Nx)
        Me.Controls.Add(Me.TxtTen_Hs_H)
        Me.Controls.Add(Me.TxtMa_Hs_H)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_BP_H)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_So_Thue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_KhVAT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDia_ChiVAT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_So_Luong)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.ChkPx_Gia_DD)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.TxtT_TT_NT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CmbMa_GD)
        Me.Controls.Add(Me.LabDia_Chi)
        Me.Controls.Add(Me.TxtDia_Chi)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.TxtOng_Ba)
        Me.Controls.Add(Me.LabOng_ba)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.TxtSo_Ct)
        Me.Controls.Add(Me.LabMa_kh)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "HDC"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.LabOng_ba, 0)
        Me.Controls.SetChildIndex(Me.TxtOng_Ba, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.LabDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.ChkPx_Gia_DD, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_ChiVAT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KhVAT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_So_Thue, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Nx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nx, 0)
        Me.Controls.SetChildIndex(Me.LabTen_vtthue, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_VtThue, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtHT_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Seri, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.TxtT_thue_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Thue, 0)
        Me.Controls.SetChildIndex(Me.LabT_Thue_NT, 0)
        Me.Controls.SetChildIndex(Me.LabT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien2, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CK_Nt, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CK, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.LabTk_Thue_No, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Thue_Co, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtThue_Suat, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Thue, 0)
        Me.Controls.SetChildIndex(Me.LabTk_Thue_Co, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_Thue, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_TkThue, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_CK, 0)
        Me.Controls.SetChildIndex(Me.TxtHan_TT, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_Thue_CK, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Thue_No, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD_H, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.CmdPhan_Bo, 0)
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
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.TxtNoteHDDT, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.TxtEmailHDDT, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtMau_VATHD, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HDDT, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_seriHD, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Tra_Cuu, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CtHD, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TD3_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TD3_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NH, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Vay, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.TxtT_CP, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KM, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Moi_Gioi, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Km_Khac, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.TxtT_BB, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Cmt, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CMT, 0)
        Me.Controls.SetChildIndex(Me.Label78, 0)
        Me.Controls.SetChildIndex(Me.Label79, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Cap_Cmt, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Gx, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Nx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Thue_Co.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Thue_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TD3_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_NH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabDia_Chi As System.Windows.Forms.Label
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents TxtOng_Ba As System.Windows.Forms.TextBox
    Friend WithEvents LabOng_ba As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ct As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kh As System.Windows.Forms.Label
    Friend WithEvents LabMa_NT As System.Windows.Forms.Label
    Friend WithEvents TxtTy_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_NT As System.Windows.Forms.TextBox
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabTy_gia As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_TT_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ChkPx_Gia_DD As System.Windows.Forms.CheckBox
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_SO As System.Windows.Forms.TextBox
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_So_Luong As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTen_KhVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDia_ChiVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_So_Thue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Nx As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nx As System.Windows.Forms.Label
    Friend WithEvents TxtTen_VtThue As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_vtthue As System.Windows.Forms.Label
    Friend WithEvents TxtHT_TT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Seri As System.Windows.Forms.TextBox
    Friend WithEvents LabT_Tien_NT As System.Windows.Forms.Label
    Friend WithEvents LabT_Thue_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_Thue As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_thue_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tien2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT2 As ClsTextBox.txtTien_NT
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtT_CK As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_CK_Nt As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTk_Thue_Co As Cyber.SmLists.TxtLookup
    Friend WithEvents LabTk_Thue_No As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtThue_Suat As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_Thue As System.Windows.Forms.TextBox
    Friend WithEvents LabTk_Thue_Co As System.Windows.Forms.Label
    Friend WithEvents ChkSua_Thue As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSua_TkThue As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSua_CK As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtHan_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ChkSua_Thue_CK As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTk_Thue_No As Cyber.SmLists.TxtLookup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_HD_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HD_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CtHD As ClsTextBox.txtDate
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Tra_Cuu As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_seriHD As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_HDDT As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtMau_VATHD As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtEmailHDDT As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtNoteHDDT As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_TD3_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TD3_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_NH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NH As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_Vay As ClsTextBox.txtTien_NT
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtT_BB As ClsTextBox.txtTien_NT
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Km_Khac As ClsTextBox.txtTien_NT
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TxtT_Moi_Gioi As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_KM As ClsTextBox.txtTien_NT
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtT_CP As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Cmt As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtNoi_Cap_Cmt As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CMT As ClsTextBox.txtDate
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Gx As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH

End Class
