<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintVoucherHDX_STT
    Inherits Cyber.From.FrmPrintVoucher

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdDanh_Sach_STT_REC0 = New System.Windows.Forms.Button()
        Me.TxtStt_rec0 = New System.Windows.Forms.TextBox()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(898, 421)
        '
        'CmdPriview
        '
        Me.CmdPriview.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPriview.Appearance.Options.UseForeColor = True
        Me.CmdPriview.Location = New System.Drawing.Point(805, 421)
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(711, 421)
        '
        'CmdModify
        '
        Me.CmdModify.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdModify.Appearance.Options.UseForeColor = True
        Me.CmdModify.Location = New System.Drawing.Point(2, 420)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 226
        Me.Label1.Tag = "Cus code"
        Me.Label1.Text = "Dòng chi tiết"
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(6, 116)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.DetailGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(981, 276)
        Me.Master.TabIndex = 278
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
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
        Me.DetailGRV.GridControl = Me.Master
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
        'CmdDanh_Sach_STT_REC0
        '
        Me.CmdDanh_Sach_STT_REC0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDanh_Sach_STT_REC0.Location = New System.Drawing.Point(298, 89)
        Me.CmdDanh_Sach_STT_REC0.Name = "CmdDanh_Sach_STT_REC0"
        Me.CmdDanh_Sach_STT_REC0.Size = New System.Drawing.Size(35, 22)
        Me.CmdDanh_Sach_STT_REC0.TabIndex = 2181
        Me.CmdDanh_Sach_STT_REC0.Tag = "..."
        Me.CmdDanh_Sach_STT_REC0.Text = "..."
        Me.CmdDanh_Sach_STT_REC0.UseVisualStyleBackColor = True
        '
        'TxtStt_rec0
        '
        Me.TxtStt_rec0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtStt_rec0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_rec0.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_rec0.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_rec0.Location = New System.Drawing.Point(135, 89)
        Me.TxtStt_rec0.Name = "TxtStt_rec0"
        Me.TxtStt_rec0.Size = New System.Drawing.Size(157, 21)
        Me.TxtStt_rec0.TabIndex = 2180
        Me.TxtStt_rec0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmPrintVoucherHDX_STT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 454)
        Me.Controls.Add(Me.CmdDanh_Sach_STT_REC0)
        Me.Controls.Add(Me.TxtStt_rec0)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPrintVoucherHDX_STT"
        Me.Controls.SetChildIndex(Me.txtTitle1, 0)
        Me.Controls.SetChildIndex(Me.txtTitle2, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_In, 0)
        Me.Controls.SetChildIndex(Me.LabMa_In, 0)
        Me.Controls.SetChildIndex(Me.CmdExit, 0)
        Me.Controls.SetChildIndex(Me.CmdPriview, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdModify, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct_Goc, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_lien, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_rec0, 0)
        Me.Controls.SetChildIndex(Me.CmdDanh_Sach_STT_REC0, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmdDanh_Sach_STT_REC0 As Button
    Friend WithEvents TxtStt_rec0 As TextBox
End Class
