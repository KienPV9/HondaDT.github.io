<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMGIACV
    Inherits Cyber.From.FrmList

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
        Me.LabMa_Db = New System.Windows.Forms.Label()
        Me.LabMa_KH = New System.Windows.Forms.Label()
        Me.TxtTen_cv = New System.Windows.Forms.TextBox()
        Me.TxtMa_CV = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_ctcv = New System.Windows.Forms.TextBox()
        Me.TxtMa_ctcv = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_ban = New ClsTextBox.txtDate1()
        Me.TxtGia_nt2 = New ClsTextBox.txtTy_Gia()
        Me.TxtGia_nt3 = New ClsTextBox.txtTy_Gia()
        Me.TxtGia3 = New ClsTextBox.txtTy_Gia()
        Me.Txtgia2 = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.Labgia3 = New System.Windows.Forms.Label()
        Me.Labgia2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_ctcv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(693, 165)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(591, 165)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(401, 227)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 174)
        Me.ChkActi.TabIndex = 15
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 155)
        Me.GroupBoxLine.Size = New System.Drawing.Size(791, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_Db
        '
        Me.LabMa_Db.Location = New System.Drawing.Point(5, 12)
        Me.LabMa_Db.Name = "LabMa_Db"
        Me.LabMa_Db.Size = New System.Drawing.Size(100, 16)
        Me.LabMa_Db.TabIndex = 22
        Me.LabMa_Db.Tag = "Add code"
        Me.LabMa_Db.Text = "Mã công việc"
        '
        'LabMa_KH
        '
        Me.LabMa_KH.Location = New System.Drawing.Point(5, 34)
        Me.LabMa_KH.Name = "LabMa_KH"
        Me.LabMa_KH.Size = New System.Drawing.Size(116, 16)
        Me.LabMa_KH.TabIndex = 23
        Me.LabMa_KH.Tag = "Customer code"
        Me.LabMa_KH.Text = "Mã công việc chi tiết"
        '
        'TxtTen_cv
        '
        Me.TxtTen_cv.BackColor = System.Drawing.Color.White
        Me.TxtTen_cv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_cv.Enabled = False
        Me.TxtTen_cv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_cv.Location = New System.Drawing.Point(278, 11)
        Me.TxtTen_cv.Name = "TxtTen_cv"
        Me.TxtTen_cv.ReadOnly = True
        Me.TxtTen_cv.Size = New System.Drawing.Size(512, 14)
        Me.TxtTen_cv.TabIndex = 386
        Me.TxtTen_cv.TabStop = False
        '
        'TxtMa_CV
        '
        Me.TxtMa_CV._ActilookupPopup = False
        Me.TxtMa_CV.CyberActilookupPopup = True
        Me.TxtMa_CV.Dv_ListDetail = Nothing
        Me.TxtMa_CV.Dv_Master = Nothing
        Me.TxtMa_CV.FilterClient = ""
        Me.TxtMa_CV.FilterSQL = ""
        Me.TxtMa_CV.Location = New System.Drawing.Point(126, 6)
        Me.TxtMa_CV.Name = "TxtMa_CV"
        Me.TxtMa_CV.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CV.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CV.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_CV.TabIndex = 2
        Me.TxtMa_CV.Table_Name = ""
        '
        'TxtTen_ctcv
        '
        Me.TxtTen_ctcv.BackColor = System.Drawing.Color.White
        Me.TxtTen_ctcv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_ctcv.Enabled = False
        Me.TxtTen_ctcv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ctcv.Location = New System.Drawing.Point(278, 33)
        Me.TxtTen_ctcv.Name = "TxtTen_ctcv"
        Me.TxtTen_ctcv.ReadOnly = True
        Me.TxtTen_ctcv.Size = New System.Drawing.Size(512, 14)
        Me.TxtTen_ctcv.TabIndex = 388
        Me.TxtTen_ctcv.TabStop = False
        '
        'TxtMa_ctcv
        '
        Me.TxtMa_ctcv._ActilookupPopup = False
        Me.TxtMa_ctcv.CyberActilookupPopup = True
        Me.TxtMa_ctcv.Dv_ListDetail = Nothing
        Me.TxtMa_ctcv.Dv_Master = Nothing
        Me.TxtMa_ctcv.FilterClient = ""
        Me.TxtMa_ctcv.FilterSQL = ""
        Me.TxtMa_ctcv.Location = New System.Drawing.Point(126, 30)
        Me.TxtMa_ctcv.Name = "TxtMa_ctcv"
        Me.TxtMa_ctcv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ctcv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ctcv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ctcv.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_ctcv.TabIndex = 3
        Me.TxtMa_ctcv.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(4, 57)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 17)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_ban
        '
        Me.TxtNgay_ban.Flags = 65536
        Me.TxtNgay_ban.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ban.IsAllowResize = False
        Me.TxtNgay_ban.isEmpty = True
        Me.TxtNgay_ban.Location = New System.Drawing.Point(125, 53)
        Me.TxtNgay_ban.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ban.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_ban.MaxLength = 10
        Me.TxtNgay_ban.Name = "TxtNgay_ban"
        Me.TxtNgay_ban.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_ban.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_ban.ShowDayBeforeMonth = False
        Me.TxtNgay_ban.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_ban.TabIndex = 9
        Me.TxtNgay_ban.Text = "07/09/2011"
        Me.TxtNgay_ban.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtGia_nt2
        '
        Me.TxtGia_nt2.AllowNegative = True
        Me.TxtGia_nt2.Flags = 7680
        Me.TxtGia_nt2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt2.InputMask = "### ### ###.##"
        Me.TxtGia_nt2.Location = New System.Drawing.Point(125, 76)
        Me.TxtGia_nt2.MaxWholeDigits = 11
        Me.TxtGia_nt2.Name = "TxtGia_nt2"
        Me.TxtGia_nt2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt2.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt2.TabIndex = 10
        Me.TxtGia_nt2.Text = "1.00"
        Me.TxtGia_nt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia_nt3
        '
        Me.TxtGia_nt3.AllowNegative = True
        Me.TxtGia_nt3.Flags = 7680
        Me.TxtGia_nt3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt3.InputMask = "### ### ###.##"
        Me.TxtGia_nt3.Location = New System.Drawing.Point(125, 99)
        Me.TxtGia_nt3.MaxWholeDigits = 11
        Me.TxtGia_nt3.Name = "TxtGia_nt3"
        Me.TxtGia_nt3.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt3.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt3.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt3.TabIndex = 11
        Me.TxtGia_nt3.Text = "1.00"
        Me.TxtGia_nt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia3
        '
        Me.TxtGia3.AllowNegative = True
        Me.TxtGia3.Flags = 7680
        Me.TxtGia3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia3.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia3.InputMask = "### ### ###.##"
        Me.TxtGia3.Location = New System.Drawing.Point(511, 99)
        Me.TxtGia3.MaxWholeDigits = 11
        Me.TxtGia3.Name = "TxtGia3"
        Me.TxtGia3.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia3.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia3.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia3.TabIndex = 13
        Me.TxtGia3.Text = "1.00"
        Me.TxtGia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia3.Visible = False
        '
        'Txtgia2
        '
        Me.Txtgia2.AllowNegative = True
        Me.Txtgia2.Flags = 7680
        Me.Txtgia2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtgia2.ForeColor = System.Drawing.Color.Navy
        Me.Txtgia2.InputMask = "### ### ###.##"
        Me.Txtgia2.Location = New System.Drawing.Point(511, 76)
        Me.Txtgia2.MaxWholeDigits = 11
        Me.Txtgia2.Name = "Txtgia2"
        Me.Txtgia2.RangeMax = 1.7976931348623157E+308R
        Me.Txtgia2.RangeMin = -1.7976931348623157E+308R
        Me.Txtgia2.Size = New System.Drawing.Size(149, 21)
        Me.Txtgia2.TabIndex = 11
        Me.Txtgia2.Text = "1.00"
        Me.Txtgia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtgia2.Visible = False
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(3, 79)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Giá bán trước thuế (NT)"
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.Location = New System.Drawing.Point(4, 101)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt3.TabIndex = 31
        Me.LabGia_nt3.Tag = "Price before tax"
        Me.LabGia_nt3.Text = "Giá bán sau thuế (NT)"
        '
        'Labgia3
        '
        Me.Labgia3.Location = New System.Drawing.Point(380, 101)
        Me.Labgia3.Name = "Labgia3"
        Me.Labgia3.Size = New System.Drawing.Size(110, 17)
        Me.Labgia3.TabIndex = 413
        Me.Labgia3.Tag = "Price before tax VND"
        Me.Labgia3.Text = "Giá sau thuế (VND)"
        Me.Labgia3.Visible = False
        '
        'Labgia2
        '
        Me.Labgia2.Location = New System.Drawing.Point(379, 79)
        Me.Labgia2.Name = "Labgia2"
        Me.Labgia2.Size = New System.Drawing.Size(110, 17)
        Me.Labgia2.TabIndex = 412
        Me.Labgia2.Tag = "Pretax price VND"
        Me.Labgia2.Text = "Giá trước thuế (VND)"
        Me.Labgia2.Visible = False
        '
        'DMGIACV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(795, 198)
        Me.Controls.Add(Me.Labgia3)
        Me.Controls.Add(Me.Labgia2)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.TxtGia3)
        Me.Controls.Add(Me.Txtgia2)
        Me.Controls.Add(Me.TxtGia_nt3)
        Me.Controls.Add(Me.TxtGia_nt2)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_ban)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_ctcv)
        Me.Controls.Add(Me.TxtMa_ctcv)
        Me.Controls.Add(Me.TxtTen_cv)
        Me.Controls.Add(Me.TxtMa_CV)
        Me.Controls.Add(Me.LabMa_KH)
        Me.Controls.Add(Me.LabMa_Db)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMGIACV"
        Me.Controls.SetChildIndex(Me.LabMa_Db, 0)
        Me.Controls.SetChildIndex(Me.LabMa_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_cv, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ctcv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ctcv, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.Txtgia2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia3, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labgia2, 0)
        Me.Controls.SetChildIndex(Me.Labgia3, 0)
        CType(Me.TxtMa_CV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_ctcv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Db As System.Windows.Forms.Label
    Friend WithEvents LabMa_KH As System.Windows.Forms.Label
    Friend WithEvents TxtTen_cv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CV As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_ctcv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_ctcv As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_ban As ClsTextBox.txtDate1
    Friend WithEvents TxtGia_nt2 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia_nt3 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia3 As ClsTextBox.txtTy_Gia
    Friend WithEvents Txtgia2 As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents Labgia3 As System.Windows.Forms.Label
    Friend WithEvents Labgia2 As System.Windows.Forms.Label

End Class
