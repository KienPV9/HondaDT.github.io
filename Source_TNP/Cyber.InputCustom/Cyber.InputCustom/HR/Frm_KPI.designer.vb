<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_KPI
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
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtUser_id = New System.Windows.Forms.TextBox()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtSTT_rec = New System.Windows.Forms.TextBox()
        Me.LabTieuDe = New System.Windows.Forms.Label()
        Me.TxtDien_giai_GNPT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSo_PLV = New System.Windows.Forms.TextBox()
        Me.TxtSTT_rec_PLV = New System.Windows.Forms.TextBox()
        Me.TxtGio_Ctu = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 437)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(915, 8)
        Me.GroupBoxLine.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(705, 446)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 4
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Xác nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(811, 446)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 5
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(0, 88)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(917, 352)
        Me.Detail.TabIndex = 3
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
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUser_id.BackColor = System.Drawing.Color.White
        Me.TxtUser_id.Enabled = False
        Me.TxtUser_id.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser_id.Location = New System.Drawing.Point(822, 27)
        Me.TxtUser_id.Name = "TxtUser_id"
        Me.TxtUser_id.ReadOnly = True
        Me.TxtUser_id.Size = New System.Drawing.Size(71, 20)
        Me.TxtUser_id.TabIndex = 528
        Me.TxtUser_id.TabStop = False
        Me.TxtUser_id.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Enabled = False
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(822, 7)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(71, 20)
        Me.TxtMa_Dvcs.TabIndex = 529
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtSTT_rec
        '
        Me.TxtSTT_rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSTT_rec.BackColor = System.Drawing.Color.White
        Me.TxtSTT_rec.Enabled = False
        Me.TxtSTT_rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtSTT_rec.Location = New System.Drawing.Point(822, 48)
        Me.TxtSTT_rec.Name = "TxtSTT_rec"
        Me.TxtSTT_rec.ReadOnly = True
        Me.TxtSTT_rec.Size = New System.Drawing.Size(71, 20)
        Me.TxtSTT_rec.TabIndex = 530
        Me.TxtSTT_rec.TabStop = False
        Me.TxtSTT_rec.Visible = False
        '
        'LabTieuDe
        '
        Me.LabTieuDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTieuDe.BackColor = System.Drawing.Color.Transparent
        Me.LabTieuDe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTieuDe.ForeColor = System.Drawing.Color.Navy
        Me.LabTieuDe.Location = New System.Drawing.Point(2, 9)
        Me.LabTieuDe.Name = "LabTieuDe"
        Me.LabTieuDe.Size = New System.Drawing.Size(915, 21)
        Me.LabTieuDe.TabIndex = 531
        Me.LabTieuDe.Tag = "Voucher date"
        Me.LabTieuDe.Text = "Xác nhận điểm KPI"
        Me.LabTieuDe.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtDien_giai_GNPT
        '
        Me.TxtDien_giai_GNPT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDien_giai_GNPT.BackColor = System.Drawing.Color.White
        Me.TxtDien_giai_GNPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_giai_GNPT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_giai_GNPT.Location = New System.Drawing.Point(136, 63)
        Me.TxtDien_giai_GNPT.Name = "TxtDien_giai_GNPT"
        Me.TxtDien_giai_GNPT.Size = New System.Drawing.Size(779, 21)
        Me.TxtDien_giai_GNPT.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(9, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 17)
        Me.Label12.TabIndex = 533
        Me.Label12.Tag = "Cus code"
        Me.Label12.Text = "Ghi chú"
        '
        'txtSo_PLV
        '
        Me.txtSo_PLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_PLV.BackColor = System.Drawing.Color.White
        Me.txtSo_PLV.Enabled = False
        Me.txtSo_PLV.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_PLV.Location = New System.Drawing.Point(745, 7)
        Me.txtSo_PLV.Name = "txtSo_PLV"
        Me.txtSo_PLV.ReadOnly = True
        Me.txtSo_PLV.Size = New System.Drawing.Size(71, 20)
        Me.txtSo_PLV.TabIndex = 540
        Me.txtSo_PLV.TabStop = False
        Me.txtSo_PLV.Visible = False
        '
        'TxtSTT_rec_PLV
        '
        Me.TxtSTT_rec_PLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSTT_rec_PLV.BackColor = System.Drawing.Color.White
        Me.TxtSTT_rec_PLV.Enabled = False
        Me.TxtSTT_rec_PLV.ForeColor = System.Drawing.Color.Navy
        Me.TxtSTT_rec_PLV.Location = New System.Drawing.Point(745, 28)
        Me.TxtSTT_rec_PLV.Name = "TxtSTT_rec_PLV"
        Me.TxtSTT_rec_PLV.ReadOnly = True
        Me.TxtSTT_rec_PLV.Size = New System.Drawing.Size(71, 20)
        Me.TxtSTT_rec_PLV.TabIndex = 543
        Me.TxtSTT_rec_PLV.TabStop = False
        Me.TxtSTT_rec_PLV.Visible = False
        '
        'TxtGio_Ctu
        '
        Me.TxtGio_Ctu.BackColor = System.Drawing.Color.White
        Me.TxtGio_Ctu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGio_Ctu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_Ctu.Location = New System.Drawing.Point(136, 40)
        Me.TxtGio_Ctu.Name = "TxtGio_Ctu"
        Me.TxtGio_Ctu.Size = New System.Drawing.Size(47, 21)
        Me.TxtGio_Ctu.TabIndex = 0
        Me.TxtGio_Ctu.Tag = ""
        Me.TxtGio_Ctu.Text = "24:44"
        Me.TxtGio_Ctu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(184, 40)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(73, 22)
        Me.TxtNgay_Ct.TabIndex = 1
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 2176
        Me.Label1.Tag = "Cus code"
        Me.Label1.Text = "T.gian xác nhận"
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'Frm_BGX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(920, 501)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGio_Ctu)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.TxtSTT_rec_PLV)
        Me.Controls.Add(Me.txtSo_PLV)
        Me.Controls.Add(Me.TxtDien_giai_GNPT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtSTT_rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtUser_id)
        Me.Controls.Add(Me.LabTieuDe)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_BGX"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.LabTieuDe, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtSTT_rec, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_giai_GNPT, 0)
        Me.Controls.SetChildIndex(Me.txtSo_PLV, 0)
        Me.Controls.SetChildIndex(Me.TxtSTT_rec_PLV, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_Ctu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtUser_id As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Dvcs As Windows.Forms.TextBox
    Friend WithEvents TxtSTT_rec As Windows.Forms.TextBox
    Friend WithEvents LabTieuDe As Label
    Friend WithEvents TxtDien_giai_GNPT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSo_PLV As TextBox
    Friend WithEvents TxtSTT_rec_PLV As TextBox
    Friend WithEvents TxtGio_Ctu As TextBox
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents Label1 As Label
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
End Class
