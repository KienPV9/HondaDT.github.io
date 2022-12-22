<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HR9
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
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabMa_Quyen = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.TxtSo_Ct = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.txtSo_Seri0 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.TxtNgay_HL1 = New ClsTextBox.txtDate()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtdien_giai = New System.Windows.Forms.TextBox()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdOK = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabT_Tien_NT = New System.Windows.Forms.Label()
        Me.TxtSo_Ngay_Nghi = New ClsTextBox.txtTien_NT()
        Me.LblNgay_KT_TS = New System.Windows.Forms.Label()
        Me.TxtNgay_KTN = New ClsTextBox.txtDate1()
        Me.LblNgay_BDTS = New System.Windows.Forms.Label()
        Me.txtNgay_BDN = New ClsTextBox.txtDate1()
        Me.TxtTen_Cty = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cty = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Chucvu = New System.Windows.Forms.TextBox()
        Me.TxtMa_Chucvu = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Bp_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp_H = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNgay_NV = New ClsTextBox.txtDate1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSo_Du_Phep = New ClsTextBox.txtTien_NT()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Chucvu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CmdEdit.Location = New System.Drawing.Point(243, 517)
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
        Me.CmdSave.Location = New System.Drawing.Point(3, 517)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSave.TabIndex = 14
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
        Me.CmdView.Location = New System.Drawing.Point(482, 517)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdView.TabIndex = 21
        '
        'LabMa_Post
        '
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(5, 480)
        Me.LabMa_Post.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post.TabIndex = 19
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
        Me.CmdSms.Location = New System.Drawing.Point(1130, 546)
        Me.CmdSms.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSms.TabIndex = 15
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
        Me.CmdImport.Location = New System.Drawing.Point(1067, 546)
        Me.CmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdImport.TabIndex = 23
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Location = New System.Drawing.Point(65, 474)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Post.TabIndex = 15
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
        Me.CmdExit.Location = New System.Drawing.Point(641, 517)
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
        Me.CmdSearch.Location = New System.Drawing.Point(562, 517)
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
        Me.CmdCopy.Location = New System.Drawing.Point(403, 517)
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
        Me.CmdDelete.Location = New System.Drawing.Point(323, 517)
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
        Me.CmdPrint.Location = New System.Drawing.Point(163, 517)
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
        Me.CmdNew.Location = New System.Drawing.Point(83, 517)
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
        Me.CmdCancel.Location = New System.Drawing.Point(243, 517)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.TabIndex = 18
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
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(933, 547)
        Me.CmdPhan_Bo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPhan_Bo.TabIndex = 21
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(933, 551)
        Me.TxtUser_id.Margin = New System.Windows.Forms.Padding(4)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(377, 34)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(165, 22)
        Me.CbbMa_GD.TabIndex = 1
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(1105, 33)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(1137, 39)
        Me.LabMa_Quyen.Name = "LabMa_Quyen"
        Me.LabMa_Quyen.Size = New System.Drawing.Size(55, 13)
        Me.LabMa_Quyen.TabIndex = 145
        Me.LabMa_Quyen.Tag = "Book no."
        Me.LabMa_Quyen.Text = "Quyển số"
        Me.LabMa_Quyen.Visible = False
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(11, 34)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(91, 22)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày chứng từ"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(290, 34)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(74, 15)
        Me.lblLoai_ct.TabIndex = 21
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại "
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(290, 62)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(81, 19)
        Me.lblSo_ct.TabIndex = 22
        Me.lblSo_ct.Tag = "No."
        Me.lblSo_ct.Text = "Số chứng từ"
        '
        'TxtSo_Ct
        '
        Me.TxtSo_Ct.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ct.Location = New System.Drawing.Point(377, 59)
        Me.TxtSo_Ct.Name = "TxtSo_Ct"
        Me.TxtSo_Ct.Size = New System.Drawing.Size(165, 22)
        Me.TxtSo_Ct.TabIndex = 3
        Me.TxtSo_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(124, 34)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(134, 22)
        Me.TxtNgay_Ct.TabIndex = 0
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(1093, 551)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(21, 21)
        Me.TxtMa_Dvcs.TabIndex = 24
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(1065, 551)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(21, 21)
        Me.TxtStt_Rec.TabIndex = 22
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
        Me.TxtLenh_RO.Location = New System.Drawing.Point(1128, 31)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(59, 21)
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
        Me.TxtLenh_PO.Location = New System.Drawing.Point(1140, 36)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(59, 21)
        Me.TxtLenh_PO.TabIndex = 170
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(1129, 33)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(58, 21)
        Me.TxtLenh_Vt.TabIndex = 242
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(1156, 524)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2128
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(1137, 55)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(43, 21)
        Me.TxtLenh_SO.TabIndex = 172
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'txtSo_Seri0
        '
        Me.txtSo_Seri0.BackColor = System.Drawing.Color.White
        Me.txtSo_Seri0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_Seri0.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtSo_Seri0.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_Seri0.Location = New System.Drawing.Point(1098, 35)
        Me.txtSo_Seri0.Name = "txtSo_Seri0"
        Me.txtSo_Seri0.Size = New System.Drawing.Size(105, 21)
        Me.txtSo_Seri0.TabIndex = 5
        Me.txtSo_Seri0.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(910, 3)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(194, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2163
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(795, 6)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(106, 19)
        Me.LabMa_TTCP_H.TabIndex = 2164
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNgay_HL1
        '
        Me.TxtNgay_HL1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_HL1.Flags = 65536
        Me.TxtNgay_HL1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_HL1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL1.isEmpty = True
        Me.TxtNgay_HL1.Location = New System.Drawing.Point(124, 59)
        Me.TxtNgay_HL1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL1.MaxLength = 10
        Me.TxtNgay_HL1.Name = "TxtNgay_HL1"
        Me.TxtNgay_HL1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL1.ReadOnly = True
        Me.TxtNgay_HL1.ShowDayBeforeMonth = False
        Me.TxtNgay_HL1.Size = New System.Drawing.Size(134, 22)
        Me.TxtNgay_HL1.TabIndex = 2
        Me.TxtNgay_HL1.Text = "18/09/2011"
        Me.TxtNgay_HL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_HL1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(4, 241)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(1106, 226)
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(34, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 2185
        Me.Label2.Tag = "Content"
        Me.Label2.Text = "Ghi chú"
        '
        'Txtdien_giai
        '
        Me.Txtdien_giai.BackColor = System.Drawing.Color.White
        Me.Txtdien_giai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdien_giai.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txtdien_giai.ForeColor = System.Drawing.Color.Navy
        Me.Txtdien_giai.Location = New System.Drawing.Point(124, 213)
        Me.Txtdien_giai.Name = "Txtdien_giai"
        Me.Txtdien_giai.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtdien_giai.Size = New System.Drawing.Size(468, 22)
        Me.Txtdien_giai.TabIndex = 12
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(12, 87)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(1095, 8)
        Me.GroupBoxLine.TabIndex = 156
        Me.GroupBoxLine.TabStop = False
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(668, 43)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_LCt.TabIndex = 2188
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_LCt.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 2190
        Me.Label4.Tag = "Voucher date"
        Me.Label4.Text = "Ngày hiệu lực"
        '
        'CmdOK
        '
        Me.CmdOK.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CmdOK.Appearance.Options.UseFont = True
        Me.CmdOK.Appearance.Options.UseForeColor = True
        Me.CmdOK.Location = New System.Drawing.Point(599, 190)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(97, 26)
        Me.CmdOK.TabIndex = 11
        Me.CmdOK.Text = "&Tạo chi tiết"
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(243, 94)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(207, 20)
        Me.TxtTen_HS_H.TabIndex = 2197
        Me.TxtTen_HS_H.TabStop = False
        '
        'TxtMa_HS_H
        '
        Me.TxtMa_HS_H._ActilookupPopup = False
        Me.TxtMa_HS_H.CyberActilookupPopup = True
        Me.TxtMa_HS_H.Dv_ListDetail = Nothing
        Me.TxtMa_HS_H.Dv_Master = Nothing
        Me.TxtMa_HS_H.FilterClient = ""
        Me.TxtMa_HS_H.FilterSQL = ""
        Me.TxtMa_HS_H.Location = New System.Drawing.Point(125, 94)
        Me.TxtMa_HS_H.Name = "TxtMa_HS_H"
        Me.TxtMa_HS_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_HS_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_HS_H.TabIndex = 4
        Me.TxtMa_HS_H.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(32, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 2196
        Me.Label1.Tag = "Cus code"
        Me.Label1.Text = "Nhân viên"
        '
        'LabT_Tien_NT
        '
        Me.LabT_Tien_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Tien_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Tien_NT.Location = New System.Drawing.Point(455, 191)
        Me.LabT_Tien_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Tien_NT.Name = "LabT_Tien_NT"
        Me.LabT_Tien_NT.Size = New System.Drawing.Size(78, 14)
        Me.LabT_Tien_NT.TabIndex = 2213
        Me.LabT_Tien_NT.Tag = "Pay cash"
        Me.LabT_Tien_NT.Text = "Số ngày nghỉ"
        '
        'TxtSo_Ngay_Nghi
        '
        Me.TxtSo_Ngay_Nghi.AllowNegative = True
        Me.TxtSo_Ngay_Nghi.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ngay_Nghi.Flags = 7680
        Me.TxtSo_Ngay_Nghi.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay_Nghi.InputMask = "### ### ### ### ###.#"
        Me.TxtSo_Ngay_Nghi.Location = New System.Drawing.Point(536, 190)
        Me.TxtSo_Ngay_Nghi.MaxWholeDigits = 16
        Me.TxtSo_Ngay_Nghi.Name = "TxtSo_Ngay_Nghi"
        Me.TxtSo_Ngay_Nghi.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay_Nghi.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay_Nghi.ReadOnly = True
        Me.TxtSo_Ngay_Nghi.Size = New System.Drawing.Size(56, 20)
        Me.TxtSo_Ngay_Nghi.TabIndex = 10
        Me.TxtSo_Ngay_Nghi.Text = "1.0"
        Me.TxtSo_Ngay_Nghi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblNgay_KT_TS
        '
        Me.LblNgay_KT_TS.BackColor = System.Drawing.Color.Transparent
        Me.LblNgay_KT_TS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblNgay_KT_TS.ForeColor = System.Drawing.Color.Navy
        Me.LblNgay_KT_TS.Location = New System.Drawing.Point(250, 193)
        Me.LblNgay_KT_TS.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNgay_KT_TS.Name = "LblNgay_KT_TS"
        Me.LblNgay_KT_TS.Size = New System.Drawing.Size(78, 14)
        Me.LblNgay_KT_TS.TabIndex = 2212
        Me.LblNgay_KT_TS.Tag = "Cus code"
        Me.LblNgay_KT_TS.Text = "Ngày KT"
        '
        'TxtNgay_KTN
        '
        Me.TxtNgay_KTN.Flags = 65536
        Me.TxtNgay_KTN.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KTN.IsAllowResize = False
        Me.TxtNgay_KTN.isEmpty = True
        Me.TxtNgay_KTN.Location = New System.Drawing.Point(334, 190)
        Me.TxtNgay_KTN.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KTN.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_KTN.MaxLength = 10
        Me.TxtNgay_KTN.Name = "TxtNgay_KTN"
        Me.TxtNgay_KTN.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_KTN.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KTN.ShowDayBeforeMonth = False
        Me.TxtNgay_KTN.Size = New System.Drawing.Size(116, 20)
        Me.TxtNgay_KTN.TabIndex = 9
        Me.TxtNgay_KTN.Text = "07/09/2011"
        Me.TxtNgay_KTN.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'LblNgay_BDTS
        '
        Me.LblNgay_BDTS.BackColor = System.Drawing.Color.Transparent
        Me.LblNgay_BDTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblNgay_BDTS.ForeColor = System.Drawing.Color.Navy
        Me.LblNgay_BDTS.Location = New System.Drawing.Point(31, 193)
        Me.LblNgay_BDTS.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNgay_BDTS.Name = "LblNgay_BDTS"
        Me.LblNgay_BDTS.Size = New System.Drawing.Size(78, 14)
        Me.LblNgay_BDTS.TabIndex = 2211
        Me.LblNgay_BDTS.Tag = "Cus code"
        Me.LblNgay_BDTS.Text = "Ngày BĐ"
        '
        'txtNgay_BDN
        '
        Me.txtNgay_BDN.Flags = 65536
        Me.txtNgay_BDN.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_BDN.IsAllowResize = False
        Me.txtNgay_BDN.isEmpty = True
        Me.txtNgay_BDN.Location = New System.Drawing.Point(124, 190)
        Me.txtNgay_BDN.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNgay_BDN.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_BDN.MaxLength = 10
        Me.txtNgay_BDN.Name = "txtNgay_BDN"
        Me.txtNgay_BDN.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtNgay_BDN.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_BDN.ShowDayBeforeMonth = False
        Me.txtNgay_BDN.Size = New System.Drawing.Size(116, 20)
        Me.txtNgay_BDN.TabIndex = 8
        Me.txtNgay_BDN.Text = "07/09/2011"
        Me.txtNgay_BDN.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtTen_Cty
        '
        Me.TxtTen_Cty.BackColor = System.Drawing.Color.White
        Me.TxtTen_Cty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Cty.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cty.Location = New System.Drawing.Point(242, 167)
        Me.TxtTen_Cty.Name = "TxtTen_Cty"
        Me.TxtTen_Cty.ReadOnly = True
        Me.TxtTen_Cty.Size = New System.Drawing.Size(350, 20)
        Me.TxtTen_Cty.TabIndex = 2210
        Me.TxtTen_Cty.TabStop = False
        '
        'TxtMa_Cty
        '
        Me.TxtMa_Cty._ActilookupPopup = False
        Me.TxtMa_Cty.CyberActilookupPopup = True
        Me.TxtMa_Cty.Dv_ListDetail = Nothing
        Me.TxtMa_Cty.Dv_Master = Nothing
        Me.TxtMa_Cty.FilterClient = ""
        Me.TxtMa_Cty.FilterSQL = ""
        Me.TxtMa_Cty.Location = New System.Drawing.Point(124, 167)
        Me.TxtMa_Cty.Name = "TxtMa_Cty"
        Me.TxtMa_Cty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Cty.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cty.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Cty.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cty.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Cty.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Cty.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cty.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Cty.TabIndex = 7
        Me.TxtMa_Cty.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(31, 170)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 14)
        Me.Label11.TabIndex = 2209
        Me.Label11.Tag = "Cus code"
        Me.Label11.Text = "Công ty"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(31, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 2208
        Me.Label8.Tag = "Cus code"
        Me.Label8.Text = "Chức vụ"
        '
        'TxtTen_Chucvu
        '
        Me.TxtTen_Chucvu.BackColor = System.Drawing.Color.White
        Me.TxtTen_Chucvu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Chucvu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Chucvu.Location = New System.Drawing.Point(242, 141)
        Me.TxtTen_Chucvu.Name = "TxtTen_Chucvu"
        Me.TxtTen_Chucvu.ReadOnly = True
        Me.TxtTen_Chucvu.Size = New System.Drawing.Size(350, 20)
        Me.TxtTen_Chucvu.TabIndex = 2207
        Me.TxtTen_Chucvu.TabStop = False
        '
        'TxtMa_Chucvu
        '
        Me.TxtMa_Chucvu._ActilookupPopup = False
        Me.TxtMa_Chucvu.CyberActilookupPopup = True
        Me.TxtMa_Chucvu.Dv_ListDetail = Nothing
        Me.TxtMa_Chucvu.Dv_Master = Nothing
        Me.TxtMa_Chucvu.FilterClient = ""
        Me.TxtMa_Chucvu.FilterSQL = ""
        Me.TxtMa_Chucvu.Location = New System.Drawing.Point(124, 141)
        Me.TxtMa_Chucvu.Name = "TxtMa_Chucvu"
        Me.TxtMa_Chucvu.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Chucvu.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Chucvu.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Chucvu.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Chucvu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Chucvu.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Chucvu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Chucvu.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Chucvu.TabIndex = 6
        Me.TxtMa_Chucvu.Table_Name = ""
        '
        'TxtTen_Bp_H
        '
        Me.TxtTen_Bp_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_Bp_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Bp_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Bp_H.Location = New System.Drawing.Point(242, 116)
        Me.TxtTen_Bp_H.Name = "TxtTen_Bp_H"
        Me.TxtTen_Bp_H.ReadOnly = True
        Me.TxtTen_Bp_H.Size = New System.Drawing.Size(350, 20)
        Me.TxtTen_Bp_H.TabIndex = 2206
        Me.TxtTen_Bp_H.TabStop = False
        '
        'TxtMa_Bp_H
        '
        Me.TxtMa_Bp_H._ActilookupPopup = False
        Me.TxtMa_Bp_H.CyberActilookupPopup = True
        Me.TxtMa_Bp_H.Dv_ListDetail = Nothing
        Me.TxtMa_Bp_H.Dv_Master = Nothing
        Me.TxtMa_Bp_H.FilterClient = ""
        Me.TxtMa_Bp_H.FilterSQL = ""
        Me.TxtMa_Bp_H.Location = New System.Drawing.Point(124, 116)
        Me.TxtMa_Bp_H.Name = "TxtMa_Bp_H"
        Me.TxtMa_Bp_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp_H.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp_H.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Bp_H.TabIndex = 5
        Me.TxtMa_Bp_H.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(31, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 2205
        Me.Label6.Tag = "Cus code"
        Me.Label6.Text = "Bộ phận"
        '
        'TxtNgay_NV
        '
        Me.TxtNgay_NV.Flags = 65536
        Me.TxtNgay_NV.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_NV.IsAllowResize = False
        Me.TxtNgay_NV.isEmpty = True
        Me.TxtNgay_NV.Location = New System.Drawing.Point(124, 190)
        Me.TxtNgay_NV.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_NV.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_NV.MaxLength = 10
        Me.TxtNgay_NV.Name = "TxtNgay_NV"
        Me.TxtNgay_NV.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_NV.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_NV.ShowDayBeforeMonth = False
        Me.TxtNgay_NV.Size = New System.Drawing.Size(116, 20)
        Me.TxtNgay_NV.TabIndex = 2202
        Me.TxtNgay_NV.Text = "07/09/2011"
        Me.TxtNgay_NV.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(455, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 2215
        Me.Label3.Tag = "Pay cash"
        Me.Label3.Text = "Số dư phép"
        '
        'TxtSo_Du_Phep
        '
        Me.TxtSo_Du_Phep.AllowNegative = True
        Me.TxtSo_Du_Phep.BackColor = System.Drawing.Color.Yellow
        Me.TxtSo_Du_Phep.Flags = 7680
        Me.TxtSo_Du_Phep.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Du_Phep.InputMask = "### ### ### ### ###.#"
        Me.TxtSo_Du_Phep.Location = New System.Drawing.Point(535, 94)
        Me.TxtSo_Du_Phep.MaxWholeDigits = 16
        Me.TxtSo_Du_Phep.Name = "TxtSo_Du_Phep"
        Me.TxtSo_Du_Phep.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Du_Phep.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Du_Phep.ReadOnly = True
        Me.TxtSo_Du_Phep.Size = New System.Drawing.Size(56, 20)
        Me.TxtSo_Du_Phep.TabIndex = 2214
        Me.TxtSo_Du_Phep.TabStop = False
        Me.TxtSo_Du_Phep.Text = "1.0"
        Me.TxtSo_Du_Phep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HR9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1112, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_Du_Phep)
        Me.Controls.Add(Me.LabT_Tien_NT)
        Me.Controls.Add(Me.TxtSo_Ngay_Nghi)
        Me.Controls.Add(Me.LblNgay_KT_TS)
        Me.Controls.Add(Me.TxtNgay_KTN)
        Me.Controls.Add(Me.LblNgay_BDTS)
        Me.Controls.Add(Me.txtNgay_BDN)
        Me.Controls.Add(Me.TxtTen_Cty)
        Me.Controls.Add(Me.TxtMa_Cty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Chucvu)
        Me.Controls.Add(Me.TxtMa_Chucvu)
        Me.Controls.Add(Me.TxtTen_Bp_H)
        Me.Controls.Add(Me.TxtMa_Bp_H)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNgay_NV)
        Me.Controls.Add(Me.TxtTen_HS_H)
        Me.Controls.Add(Me.TxtMa_HS_H)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.Txtdien_giai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtNgay_HL1)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.txtSo_Seri0)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.TxtSo_Ct)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabMa_Quyen)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1022, 597)
        Me.Name = "HR9"
        Me.Controls.SetChildIndex(Me.LabMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.txtSo_Seri0, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL1, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtdien_giai, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
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
        Me.Controls.SetChildIndex(Me.CmdOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_NV, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Bp_H, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Chucvu, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Chucvu, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cty, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cty, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_BDN, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_BDTS, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KTN, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_KT_TS, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay_Nghi, 0)
        Me.Controls.SetChildIndex(Me.LabT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Du_Phep, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Chucvu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Quyen As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents TxtLenh_SO As TextBox
    Friend WithEvents txtSo_Seri0 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CbbMa_TTCP_H As ComboBox
    Friend WithEvents LabMa_TTCP_H As Label
    Friend WithEvents TxtNgay_HL1 As ClsTextBox.txtDate
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtdien_giai As TextBox
    Friend WithEvents GroupBoxLine As GroupBox
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents Label4 As Label
    Friend WithEvents CmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtTen_HS_H As TextBox
    Friend WithEvents TxtMa_HS_H As SmLists.TxtLookup
    Friend WithEvents Label1 As Label
    Friend WithEvents LabT_Tien_NT As Label
    Friend WithEvents TxtSo_Ngay_Nghi As ClsTextBox.txtTien_NT
    Friend WithEvents LblNgay_KT_TS As Label
    Friend WithEvents TxtNgay_KTN As ClsTextBox.txtDate1
    Friend WithEvents LblNgay_BDTS As Label
    Friend WithEvents txtNgay_BDN As ClsTextBox.txtDate1
    Friend WithEvents TxtTen_Cty As TextBox
    Friend WithEvents TxtMa_Cty As SmLists.TxtLookup
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTen_Chucvu As TextBox
    Friend WithEvents TxtMa_Chucvu As SmLists.TxtLookup
    Friend WithEvents TxtTen_Bp_H As TextBox
    Friend WithEvents TxtMa_Bp_H As SmLists.TxtLookup
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNgay_NV As ClsTextBox.txtDate1
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSo_Du_Phep As ClsTextBox.txtTien_NT
End Class
