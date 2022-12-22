<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K05))
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.LabT_kh01 = New System.Windows.Forms.Label()
        Me.TxtT_KH01 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien2 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT2 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien3 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien_NT3 = New ClsTextBox.txtTien_NT()
        Me.TxtT_Ps = New ClsTextBox.txtTien_NT()
        Me.TxtT_Ps_NT = New ClsTextBox.txtTien_NT()
        Me.txtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.txtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbNam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbThang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.TxtT_KH02 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh02 = New System.Windows.Forms.Label()
        Me.TxtT_KH03 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh03 = New System.Windows.Forms.Label()
        Me.TxtT_KH04 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh04 = New System.Windows.Forms.Label()
        Me.TxtT_KH05 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh05 = New System.Windows.Forms.Label()
        Me.TxtT_SO_LUONG = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT1 = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT2 = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT3 = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT4 = New ClsTextBox.txtTien_NT()
        Me.TxtT_KH06 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh06 = New System.Windows.Forms.Label()
        Me.TxtT_KH07 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh07 = New System.Windows.Forms.Label()
        Me.TxtT_KH08 = New ClsTextBox.txtTien_NT()
        Me.LabT_kh08 = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CmdLoadDmhs = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(244, 526)
        Me.CmdEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.CmdSave.Location = New System.Drawing.Point(4, 526)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdSave.TabIndex = 10
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
        Me.CmdView.Location = New System.Drawing.Point(483, 526)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdView.TabIndex = 16
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(16, 509)
        Me.LabMa_Post.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.CmdSms.Location = New System.Drawing.Point(992, 526)
        Me.CmdSms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdSms.TabIndex = 20
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
        Me.CmdImport.Location = New System.Drawing.Point(1037, 526)
        Me.CmdImport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(86, 503)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbbMa_Post.TabIndex = 9
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
        Me.CmdExit.Location = New System.Drawing.Point(643, 526)
        Me.CmdExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdExit.TabIndex = 18
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
        Me.CmdSearch.Location = New System.Drawing.Point(563, 526)
        Me.CmdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdSearch.TabIndex = 17
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
        Me.CmdCopy.Location = New System.Drawing.Point(404, 526)
        Me.CmdCopy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdCopy.TabIndex = 15
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
        Me.CmdDelete.Location = New System.Drawing.Point(324, 526)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdDelete.TabIndex = 14
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
        Me.CmdPrint.Location = New System.Drawing.Point(164, 526)
        Me.CmdPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdPrint.TabIndex = 12
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
        Me.CmdNew.Location = New System.Drawing.Point(84, 526)
        Me.CmdNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdNew.TabIndex = 11
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
        Me.CmdCancel.Location = New System.Drawing.Point(244, 526)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdCancel.TabIndex = 13
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
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(931, 526)
        Me.CmdPhan_Bo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdPhan_Bo.TabIndex = 19
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(648, 529)
        Me.TxtUser_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUser_id.TabIndex = 18
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(258, 33)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(158, 23)
        Me.CbbMa_GD.TabIndex = 2
        '
        'LabNgay_LCt
        '
        Me.LabNgay_LCt.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_LCt.Location = New System.Drawing.Point(2, 42)
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
        Me.LabNgay_Ct.Location = New System.Drawing.Point(2, 61)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(78, 13)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày c.từ"
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(640, 96)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(64, 15)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Note"
        Me.LabDien_Giai.Text = "Diễn giải"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(182, 37)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(70, 15)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Voucher style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(182, 61)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(70, 13)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số kế hoạch"
        '
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(258, 59)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(158, 21)
        Me.txtSo_ct.TabIndex = 3
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(2, 145)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(1081, 324)
        Me.Detail.TabIndex = 9
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
        Me.DetailGRV.OptionsView.ShowAutoFilterRow = True
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(0, 82)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(1083, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Enabled = False
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(22, 20)
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
        Me.TxtT_Tien.Enabled = False
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(752, 538)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(39, 20)
        Me.TxtT_Tien.TabIndex = 159
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien.Visible = False
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.AutoSize = True
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Enabled = False
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(735, 545)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(59, 13)
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
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(824, 532)
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(797, 532)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 21
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'LabT_kh01
        '
        Me.LabT_kh01.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh01.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh01.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh01.Location = New System.Drawing.Point(252, 474)
        Me.LabT_kh01.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh01.Name = "LabT_kh01"
        Me.LabT_kh01.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh01.TabIndex = 175
        Me.LabT_kh01.Tag = "Total"
        Me.LabT_kh01.Text = "Tổng số lượng"
        Me.LabT_kh01.Visible = False
        '
        'TxtT_KH01
        '
        Me.TxtT_KH01.AllowNegative = True
        Me.TxtT_KH01.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH01.BackColor = System.Drawing.Color.White
        Me.TxtT_KH01.Flags = 7680
        Me.TxtT_KH01.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH01.InputMask = "### ### ### ### ###"
        Me.TxtT_KH01.Location = New System.Drawing.Point(346, 474)
        Me.TxtT_KH01.MaxWholeDigits = 14
        Me.TxtT_KH01.Name = "TxtT_KH01"
        Me.TxtT_KH01.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH01.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH01.ReadOnly = True
        Me.TxtT_KH01.Size = New System.Drawing.Size(102, 20)
        Me.TxtT_KH01.TabIndex = 174
        Me.TxtT_KH01.Text = "0"
        Me.TxtT_KH01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH01.Visible = False
        '
        'TxtT_Tien2
        '
        Me.TxtT_Tien2.AllowNegative = True
        Me.TxtT_Tien2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien2.Enabled = False
        Me.TxtT_Tien2.Flags = 7680
        Me.TxtT_Tien2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien2.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Tien2.MaxWholeDigits = 16
        Me.TxtT_Tien2.Name = "TxtT_Tien2"
        Me.TxtT_Tien2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien2.ReadOnly = True
        Me.TxtT_Tien2.Size = New System.Drawing.Size(68, 20)
        Me.TxtT_Tien2.TabIndex = 252
        Me.TxtT_Tien2.Text = "1.0"
        Me.TxtT_Tien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien2.Visible = False
        '
        'TxtT_Tien_NT2
        '
        Me.TxtT_Tien_NT2.AllowNegative = True
        Me.TxtT_Tien_NT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT2.Enabled = False
        Me.TxtT_Tien_NT2.Flags = 7680
        Me.TxtT_Tien_NT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT2.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Tien_NT2.MaxWholeDigits = 16
        Me.TxtT_Tien_NT2.Name = "TxtT_Tien_NT2"
        Me.TxtT_Tien_NT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT2.ReadOnly = True
        Me.TxtT_Tien_NT2.Size = New System.Drawing.Size(85, 20)
        Me.TxtT_Tien_NT2.TabIndex = 251
        Me.TxtT_Tien_NT2.Text = "1.0"
        Me.TxtT_Tien_NT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT2.Visible = False
        '
        'TxtT_Tien3
        '
        Me.TxtT_Tien3.AllowNegative = True
        Me.TxtT_Tien3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien3.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien3.Enabled = False
        Me.TxtT_Tien3.Flags = 7680
        Me.TxtT_Tien3.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien3.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien3.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Tien3.MaxWholeDigits = 16
        Me.TxtT_Tien3.Name = "TxtT_Tien3"
        Me.TxtT_Tien3.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien3.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien3.ReadOnly = True
        Me.TxtT_Tien3.Size = New System.Drawing.Size(55, 20)
        Me.TxtT_Tien3.TabIndex = 254
        Me.TxtT_Tien3.Text = "1.0"
        Me.TxtT_Tien3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien3.Visible = False
        '
        'TxtT_Tien_NT3
        '
        Me.TxtT_Tien_NT3.AllowNegative = True
        Me.TxtT_Tien_NT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT3.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT3.Enabled = False
        Me.TxtT_Tien_NT3.Flags = 7680
        Me.TxtT_Tien_NT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT3.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT3.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Tien_NT3.MaxWholeDigits = 16
        Me.TxtT_Tien_NT3.Name = "TxtT_Tien_NT3"
        Me.TxtT_Tien_NT3.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT3.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT3.ReadOnly = True
        Me.TxtT_Tien_NT3.Size = New System.Drawing.Size(68, 20)
        Me.TxtT_Tien_NT3.TabIndex = 253
        Me.TxtT_Tien_NT3.Text = "1.0"
        Me.TxtT_Tien_NT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT3.Visible = False
        '
        'TxtT_Ps
        '
        Me.TxtT_Ps.AllowNegative = True
        Me.TxtT_Ps.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Ps.BackColor = System.Drawing.Color.White
        Me.TxtT_Ps.Enabled = False
        Me.TxtT_Ps.Flags = 7680
        Me.TxtT_Ps.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Ps.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Ps.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Ps.MaxWholeDigits = 16
        Me.TxtT_Ps.Name = "TxtT_Ps"
        Me.TxtT_Ps.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Ps.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Ps.ReadOnly = True
        Me.TxtT_Ps.Size = New System.Drawing.Size(32, 20)
        Me.TxtT_Ps.TabIndex = 256
        Me.TxtT_Ps.Text = "1.0"
        Me.TxtT_Ps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Ps.Visible = False
        '
        'TxtT_Ps_NT
        '
        Me.TxtT_Ps_NT.AllowNegative = True
        Me.TxtT_Ps_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Ps_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Ps_NT.Enabled = False
        Me.TxtT_Ps_NT.Flags = 7680
        Me.TxtT_Ps_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Ps_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Ps_NT.Location = New System.Drawing.Point(777, 533)
        Me.TxtT_Ps_NT.MaxWholeDigits = 16
        Me.TxtT_Ps_NT.Name = "TxtT_Ps_NT"
        Me.TxtT_Ps_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Ps_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Ps_NT.ReadOnly = True
        Me.TxtT_Ps_NT.Size = New System.Drawing.Size(41, 20)
        Me.TxtT_Ps_NT.TabIndex = 255
        Me.TxtT_Ps_NT.Text = "1.0"
        Me.TxtT_Ps_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Ps_NT.Visible = False
        '
        'txtTen_HS_H
        '
        Me.txtTen_HS_H.BackColor = System.Drawing.Color.White
        Me.txtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_HS_H.Location = New System.Drawing.Point(167, 115)
        Me.txtTen_HS_H.Name = "txtTen_HS_H"
        Me.txtTen_HS_H.ReadOnly = True
        Me.txtTen_HS_H.Size = New System.Drawing.Size(455, 20)
        Me.txtTen_HS_H.TabIndex = 9
        Me.txtTen_HS_H.TabStop = False
        '
        'txtMa_HS_H
        '
        Me.txtMa_HS_H._ActilookupPopup = False
        Me.txtMa_HS_H.CyberActilookupPopup = True
        Me.txtMa_HS_H.Dv_ListDetail = Nothing
        Me.txtMa_HS_H.Dv_Master = Nothing
        Me.txtMa_HS_H.FilterClient = Nothing
        Me.txtMa_HS_H.FilterSQL = Nothing
        Me.txtMa_HS_H.Location = New System.Drawing.Point(80, 115)
        Me.txtMa_HS_H.Name = "txtMa_HS_H"
        Me.txtMa_HS_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_HS_H.Properties.Appearance.Options.UseFont = True
        Me.txtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_HS_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMa_HS_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_HS_H.Size = New System.Drawing.Size(82, 20)
        Me.txtMa_HS_H.TabIndex = 7
        Me.txtMa_HS_H.Table_Name = Nothing
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(2, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 261
        Me.Label5.Tag = "Employee"
        Me.Label5.Text = "Nhân viên"
        '
        'txtTen_BP_H
        '
        Me.txtTen_BP_H.BackColor = System.Drawing.Color.White
        Me.txtTen_BP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BP_H.Location = New System.Drawing.Point(167, 93)
        Me.txtTen_BP_H.Name = "txtTen_BP_H"
        Me.txtTen_BP_H.ReadOnly = True
        Me.txtTen_BP_H.Size = New System.Drawing.Size(455, 20)
        Me.txtTen_BP_H.TabIndex = 7
        Me.txtTen_BP_H.TabStop = False
        '
        'TxtMa_Bp_H
        '
        Me.TxtMa_Bp_H._ActilookupPopup = False
        Me.TxtMa_Bp_H.CyberActilookupPopup = True
        Me.TxtMa_Bp_H.Dv_ListDetail = Nothing
        Me.TxtMa_Bp_H.Dv_Master = Nothing
        Me.TxtMa_Bp_H.FilterClient = Nothing
        Me.TxtMa_Bp_H.FilterSQL = Nothing
        Me.TxtMa_Bp_H.Location = New System.Drawing.Point(80, 93)
        Me.TxtMa_Bp_H.Name = "TxtMa_Bp_H"
        Me.TxtMa_Bp_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp_H.Size = New System.Drawing.Size(82, 20)
        Me.TxtMa_Bp_H.TabIndex = 6
        Me.TxtMa_Bp_H.Table_Name = Nothing
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(2, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 259
        Me.Label4.Tag = "Dept."
        Me.Label4.Text = "Bộ phận"
        '
        'CbbNam
        '
        Me.CbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbNam.ForeColor = System.Drawing.Color.Navy
        Me.CbbNam.FormattingEnabled = True
        Me.CbbNam.Location = New System.Drawing.Point(512, 58)
        Me.CbbNam.Name = "CbbNam"
        Me.CbbNam.Size = New System.Drawing.Size(110, 21)
        Me.CbbNam.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 513
        Me.Label3.Tag = "Year"
        Me.Label3.Text = "Năm"
        '
        'CbbThang
        '
        Me.CbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbThang.ForeColor = System.Drawing.Color.Navy
        Me.CbbThang.FormattingEnabled = True
        Me.CbbThang.Location = New System.Drawing.Point(512, 34)
        Me.CbbThang.Name = "CbbThang"
        Me.CbbThang.Size = New System.Drawing.Size(110, 21)
        Me.CbbThang.TabIndex = 4
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(440, 37)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(38, 13)
        Me.LabM_month1.TabIndex = 512
        Me.LabM_month1.Tag = "Month"
        Me.LabM_month1.Text = "Tháng"
        '
        'txtDien_giai
        '
        Me.txtDien_giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(705, 93)
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDien_giai.Size = New System.Drawing.Size(378, 20)
        Me.txtDien_giai.TabIndex = 8
        '
        'TxtT_KH02
        '
        Me.TxtT_KH02.AllowNegative = True
        Me.TxtT_KH02.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH02.BackColor = System.Drawing.Color.White
        Me.TxtT_KH02.Flags = 7680
        Me.TxtT_KH02.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH02.InputMask = "### ### ### ### ###"
        Me.TxtT_KH02.Location = New System.Drawing.Point(536, 474)
        Me.TxtT_KH02.MaxWholeDigits = 14
        Me.TxtT_KH02.Name = "TxtT_KH02"
        Me.TxtT_KH02.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH02.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH02.ReadOnly = True
        Me.TxtT_KH02.Size = New System.Drawing.Size(102, 20)
        Me.TxtT_KH02.TabIndex = 174
        Me.TxtT_KH02.Text = "0"
        Me.TxtT_KH02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH02.Visible = False
        '
        'LabT_kh02
        '
        Me.LabT_kh02.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh02.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh02.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh02.Location = New System.Drawing.Point(451, 474)
        Me.LabT_kh02.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh02.Name = "LabT_kh02"
        Me.LabT_kh02.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh02.TabIndex = 175
        Me.LabT_kh02.Tag = "Total"
        Me.LabT_kh02.Text = "Tổng số lượng"
        Me.LabT_kh02.Visible = False
        '
        'TxtT_KH03
        '
        Me.TxtT_KH03.AllowNegative = True
        Me.TxtT_KH03.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH03.BackColor = System.Drawing.Color.White
        Me.TxtT_KH03.Flags = 7680
        Me.TxtT_KH03.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH03.InputMask = "### ### ### ### ###"
        Me.TxtT_KH03.Location = New System.Drawing.Point(749, 474)
        Me.TxtT_KH03.MaxWholeDigits = 14
        Me.TxtT_KH03.Name = "TxtT_KH03"
        Me.TxtT_KH03.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH03.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH03.ReadOnly = True
        Me.TxtT_KH03.Size = New System.Drawing.Size(105, 20)
        Me.TxtT_KH03.TabIndex = 174
        Me.TxtT_KH03.Text = "0"
        Me.TxtT_KH03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH03.Visible = False
        '
        'LabT_kh03
        '
        Me.LabT_kh03.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh03.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh03.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh03.Location = New System.Drawing.Point(663, 474)
        Me.LabT_kh03.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh03.Name = "LabT_kh03"
        Me.LabT_kh03.Size = New System.Drawing.Size(86, 15)
        Me.LabT_kh03.TabIndex = 175
        Me.LabT_kh03.Tag = "Total"
        Me.LabT_kh03.Text = "Tổng số lượng"
        Me.LabT_kh03.Visible = False
        '
        'TxtT_KH04
        '
        Me.TxtT_KH04.AllowNegative = True
        Me.TxtT_KH04.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH04.BackColor = System.Drawing.Color.White
        Me.TxtT_KH04.Flags = 7680
        Me.TxtT_KH04.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH04.InputMask = "### ### ### ### ###"
        Me.TxtT_KH04.Location = New System.Drawing.Point(943, 474)
        Me.TxtT_KH04.MaxWholeDigits = 14
        Me.TxtT_KH04.Name = "TxtT_KH04"
        Me.TxtT_KH04.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH04.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH04.ReadOnly = True
        Me.TxtT_KH04.Size = New System.Drawing.Size(92, 20)
        Me.TxtT_KH04.TabIndex = 174
        Me.TxtT_KH04.Text = "0"
        Me.TxtT_KH04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH04.Visible = False
        '
        'LabT_kh04
        '
        Me.LabT_kh04.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh04.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh04.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh04.Location = New System.Drawing.Point(857, 474)
        Me.LabT_kh04.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh04.Name = "LabT_kh04"
        Me.LabT_kh04.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh04.TabIndex = 175
        Me.LabT_kh04.Tag = "Total"
        Me.LabT_kh04.Text = "Tổng số lượng"
        Me.LabT_kh04.Visible = False
        '
        'TxtT_KH05
        '
        Me.TxtT_KH05.AllowNegative = True
        Me.TxtT_KH05.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH05.BackColor = System.Drawing.Color.White
        Me.TxtT_KH05.Flags = 7680
        Me.TxtT_KH05.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH05.InputMask = "### ### ### ### ###"
        Me.TxtT_KH05.Location = New System.Drawing.Point(346, 499)
        Me.TxtT_KH05.MaxWholeDigits = 14
        Me.TxtT_KH05.Name = "TxtT_KH05"
        Me.TxtT_KH05.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH05.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH05.ReadOnly = True
        Me.TxtT_KH05.Size = New System.Drawing.Size(102, 20)
        Me.TxtT_KH05.TabIndex = 174
        Me.TxtT_KH05.Text = "0"
        Me.TxtT_KH05.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH05.Visible = False
        '
        'LabT_kh05
        '
        Me.LabT_kh05.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh05.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh05.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh05.Location = New System.Drawing.Point(252, 501)
        Me.LabT_kh05.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh05.Name = "LabT_kh05"
        Me.LabT_kh05.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh05.TabIndex = 175
        Me.LabT_kh05.Tag = "Total"
        Me.LabT_kh05.Text = "Tổng số lượng"
        Me.LabT_kh05.Visible = False
        '
        'TxtT_SO_LUONG
        '
        Me.TxtT_SO_LUONG.AllowNegative = True
        Me.TxtT_SO_LUONG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_SO_LUONG.BackColor = System.Drawing.Color.White
        Me.TxtT_SO_LUONG.Flags = 7680
        Me.TxtT_SO_LUONG.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_SO_LUONG.InputMask = "### ### ### ### ###.#"
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(328, 502)
        Me.TxtT_SO_LUONG.MaxWholeDigits = 16
        Me.TxtT_SO_LUONG.Name = "TxtT_SO_LUONG"
        Me.TxtT_SO_LUONG.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.ReadOnly = True
        Me.TxtT_SO_LUONG.Size = New System.Drawing.Size(74, 20)
        Me.TxtT_SO_LUONG.TabIndex = 174
        Me.TxtT_SO_LUONG.Text = "0.0"
        Me.TxtT_SO_LUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT1
        '
        Me.TxtTien_NT1.AllowNegative = True
        Me.TxtTien_NT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_NT1.BackColor = System.Drawing.Color.White
        Me.TxtTien_NT1.Flags = 7680
        Me.TxtTien_NT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT1.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_NT1.Location = New System.Drawing.Point(483, 500)
        Me.TxtTien_NT1.MaxWholeDigits = 16
        Me.TxtTien_NT1.Name = "TxtTien_NT1"
        Me.TxtTien_NT1.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT1.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT1.ReadOnly = True
        Me.TxtTien_NT1.Size = New System.Drawing.Size(74, 20)
        Me.TxtTien_NT1.TabIndex = 174
        Me.TxtTien_NT1.Text = "0.0"
        Me.TxtTien_NT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT2
        '
        Me.TxtTien_NT2.AllowNegative = True
        Me.TxtTien_NT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_NT2.BackColor = System.Drawing.Color.White
        Me.TxtTien_NT2.Flags = 7680
        Me.TxtTien_NT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT2.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_NT2.Location = New System.Drawing.Point(643, 500)
        Me.TxtTien_NT2.MaxWholeDigits = 16
        Me.TxtTien_NT2.Name = "TxtTien_NT2"
        Me.TxtTien_NT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT2.ReadOnly = True
        Me.TxtTien_NT2.Size = New System.Drawing.Size(74, 20)
        Me.TxtTien_NT2.TabIndex = 174
        Me.TxtTien_NT2.Text = "0.0"
        Me.TxtTien_NT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT3
        '
        Me.TxtTien_NT3.AllowNegative = True
        Me.TxtTien_NT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_NT3.BackColor = System.Drawing.Color.White
        Me.TxtTien_NT3.Flags = 7680
        Me.TxtTien_NT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT3.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_NT3.Location = New System.Drawing.Point(797, 499)
        Me.TxtTien_NT3.MaxWholeDigits = 16
        Me.TxtTien_NT3.Name = "TxtTien_NT3"
        Me.TxtTien_NT3.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT3.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT3.ReadOnly = True
        Me.TxtTien_NT3.Size = New System.Drawing.Size(74, 20)
        Me.TxtTien_NT3.TabIndex = 174
        Me.TxtTien_NT3.Text = "0.0"
        Me.TxtTien_NT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT4
        '
        Me.TxtTien_NT4.AllowNegative = True
        Me.TxtTien_NT4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_NT4.BackColor = System.Drawing.Color.White
        Me.TxtTien_NT4.Flags = 7680
        Me.TxtTien_NT4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT4.InputMask = "### ### ### ### ###.#"
        Me.TxtTien_NT4.Location = New System.Drawing.Point(950, 499)
        Me.TxtTien_NT4.MaxWholeDigits = 16
        Me.TxtTien_NT4.Name = "TxtTien_NT4"
        Me.TxtTien_NT4.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT4.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT4.ReadOnly = True
        Me.TxtTien_NT4.Size = New System.Drawing.Size(74, 20)
        Me.TxtTien_NT4.TabIndex = 174
        Me.TxtTien_NT4.Text = "0.0"
        Me.TxtTien_NT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_KH06
        '
        Me.TxtT_KH06.AllowNegative = True
        Me.TxtT_KH06.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH06.BackColor = System.Drawing.Color.White
        Me.TxtT_KH06.Flags = 7680
        Me.TxtT_KH06.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH06.InputMask = "### ### ### ### ###"
        Me.TxtT_KH06.Location = New System.Drawing.Point(536, 499)
        Me.TxtT_KH06.MaxWholeDigits = 14
        Me.TxtT_KH06.Name = "TxtT_KH06"
        Me.TxtT_KH06.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH06.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH06.ReadOnly = True
        Me.TxtT_KH06.Size = New System.Drawing.Size(102, 20)
        Me.TxtT_KH06.TabIndex = 174
        Me.TxtT_KH06.Text = "0"
        Me.TxtT_KH06.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH06.Visible = False
        '
        'LabT_kh06
        '
        Me.LabT_kh06.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh06.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh06.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh06.Location = New System.Drawing.Point(451, 501)
        Me.LabT_kh06.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh06.Name = "LabT_kh06"
        Me.LabT_kh06.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh06.TabIndex = 175
        Me.LabT_kh06.Tag = "Total"
        Me.LabT_kh06.Text = "Tổng số lượng"
        Me.LabT_kh06.Visible = False
        '
        'TxtT_KH07
        '
        Me.TxtT_KH07.AllowNegative = True
        Me.TxtT_KH07.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH07.BackColor = System.Drawing.Color.White
        Me.TxtT_KH07.Flags = 7680
        Me.TxtT_KH07.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH07.InputMask = "### ### ### ### ###"
        Me.TxtT_KH07.Location = New System.Drawing.Point(749, 500)
        Me.TxtT_KH07.MaxWholeDigits = 14
        Me.TxtT_KH07.Name = "TxtT_KH07"
        Me.TxtT_KH07.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH07.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH07.ReadOnly = True
        Me.TxtT_KH07.Size = New System.Drawing.Size(105, 20)
        Me.TxtT_KH07.TabIndex = 174
        Me.TxtT_KH07.Text = "0"
        Me.TxtT_KH07.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH07.Visible = False
        '
        'LabT_kh07
        '
        Me.LabT_kh07.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh07.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh07.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh07.Location = New System.Drawing.Point(663, 502)
        Me.LabT_kh07.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh07.Name = "LabT_kh07"
        Me.LabT_kh07.Size = New System.Drawing.Size(86, 15)
        Me.LabT_kh07.TabIndex = 175
        Me.LabT_kh07.Tag = "Total"
        Me.LabT_kh07.Text = "Tổng số lượng"
        Me.LabT_kh07.Visible = False
        '
        'TxtT_KH08
        '
        Me.TxtT_KH08.AllowNegative = True
        Me.TxtT_KH08.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_KH08.BackColor = System.Drawing.Color.White
        Me.TxtT_KH08.Flags = 7680
        Me.TxtT_KH08.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_KH08.InputMask = "### ### ### ### ###"
        Me.TxtT_KH08.Location = New System.Drawing.Point(943, 500)
        Me.TxtT_KH08.MaxWholeDigits = 14
        Me.TxtT_KH08.Name = "TxtT_KH08"
        Me.TxtT_KH08.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_KH08.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_KH08.ReadOnly = True
        Me.TxtT_KH08.Size = New System.Drawing.Size(92, 20)
        Me.TxtT_KH08.TabIndex = 174
        Me.TxtT_KH08.Text = "0"
        Me.TxtT_KH08.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_KH08.Visible = False
        '
        'LabT_kh08
        '
        Me.LabT_kh08.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_kh08.BackColor = System.Drawing.Color.Transparent
        Me.LabT_kh08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_kh08.ForeColor = System.Drawing.Color.Navy
        Me.LabT_kh08.Location = New System.Drawing.Point(857, 502)
        Me.LabT_kh08.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_kh08.Name = "LabT_kh08"
        Me.LabT_kh08.Size = New System.Drawing.Size(78, 15)
        Me.LabT_kh08.TabIndex = 175
        Me.LabT_kh08.Tag = "Total"
        Me.LabT_kh08.Text = "Tổng số lượng"
        Me.LabT_kh08.Visible = False
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(886, 1)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2199
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(777, 2)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(106, 19)
        Me.LabMa_TTCP_H.TabIndex = 2200
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdLoadDmhs
        '
        Me.CmdLoadDmhs.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdLoadDmhs.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdLoadDmhs.Appearance.Options.UseFont = True
        Me.CmdLoadDmhs.Appearance.Options.UseForeColor = True
        Me.CmdLoadDmhs.Image = CType(resources.GetObject("CmdLoadDmhs.Image"), System.Drawing.Image)
        Me.CmdLoadDmhs.Location = New System.Drawing.Point(705, 115)
        Me.CmdLoadDmhs.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdLoadDmhs.Name = "CmdLoadDmhs"
        Me.CmdLoadDmhs.Size = New System.Drawing.Size(178, 29)
        Me.CmdLoadDmhs.TabIndex = 2201
        Me.CmdLoadDmhs.Text = "&Lấy danh sách TVBH"
        '
        'K05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1083, 583)
        Me.Controls.Add(Me.CmdLoadDmhs)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.CbbNam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbThang)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.txtTen_HS_H)
        Me.Controls.Add(Me.txtMa_HS_H)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_Bp_H)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabT_kh08)
        Me.Controls.Add(Me.LabT_kh07)
        Me.Controls.Add(Me.LabT_kh06)
        Me.Controls.Add(Me.LabT_kh05)
        Me.Controls.Add(Me.LabT_kh04)
        Me.Controls.Add(Me.LabT_kh03)
        Me.Controls.Add(Me.LabT_kh02)
        Me.Controls.Add(Me.LabT_kh01)
        Me.Controls.Add(Me.TxtT_KH08)
        Me.Controls.Add(Me.TxtT_KH07)
        Me.Controls.Add(Me.TxtT_KH06)
        Me.Controls.Add(Me.TxtT_KH05)
        Me.Controls.Add(Me.TxtT_KH04)
        Me.Controls.Add(Me.TxtT_KH03)
        Me.Controls.Add(Me.TxtT_KH02)
        Me.Controls.Add(Me.TxtT_KH01)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtT_Ps)
        Me.Controls.Add(Me.TxtT_Ps_NT)
        Me.Controls.Add(Me.TxtT_Tien3)
        Me.Controls.Add(Me.TxtT_Tien_NT3)
        Me.Controls.Add(Me.TxtT_Tien2)
        Me.Controls.Add(Me.TxtT_Tien_NT2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(947, 557)
        Me.Name = "K05"
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien3, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Ps_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Ps, 0)
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
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH01, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH02, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH03, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH04, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH05, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH06, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH07, 0)
        Me.Controls.SetChildIndex(Me.TxtT_KH08, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh01, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh02, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh03, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh04, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh05, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh06, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh07, 0)
        Me.Controls.SetChildIndex(Me.LabT_kh08, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.txtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbThang, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbNam, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.CmdLoadDmhs, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabT_kh01 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH01 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien_NT3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Ps As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Ps_NT As ClsTextBox.txtTien_NT
    Friend WithEvents txtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_HS_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbNam As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbThang As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents TxtT_KH02 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh02 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH03 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh03 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH04 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh04 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH05 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh05 As System.Windows.Forms.Label
    Friend WithEvents TxtT_SO_LUONG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT4 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_KH06 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh06 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH07 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh07 As System.Windows.Forms.Label
    Friend WithEvents TxtT_KH08 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_kh08 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label
    Friend WithEvents CmdLoadDmhs As DevExpress.XtraEditors.SimpleButton
End Class
