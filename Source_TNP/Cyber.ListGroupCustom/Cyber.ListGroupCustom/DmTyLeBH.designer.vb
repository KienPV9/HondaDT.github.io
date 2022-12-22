<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmTyLeBH
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
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.TxtTien_Xe_Tu = New ClsTextBox.txtTy_Gia()
        Me.TxtTy_Le = New ClsTextBox.txtTy_Gia()
        Me.TxtTien_Xe_Den = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.Labgia2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(507, 128)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(405, 128)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(308, 208)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 137)
        Me.ChkActi.TabIndex = 15
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 118)
        Me.GroupBoxLine.Size = New System.Drawing.Size(605, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(3, 29)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(100, 16)
        Me.LabMa_kho.TabIndex = 21
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã ĐVBH"
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(278, 29)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(329, 14)
        Me.TxtTen_BH.TabIndex = 384
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(125, 26)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_BH.TabIndex = 1
        Me.TxtMa_BH.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(4, 5)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 17)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.IsAllowResize = False
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(125, 1)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtTien_Xe_Tu
        '
        Me.TxtTien_Xe_Tu.AllowNegative = True
        Me.TxtTien_Xe_Tu.Flags = 7680
        Me.TxtTien_Xe_Tu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_Xe_Tu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Xe_Tu.InputMask = "### ### ### ###"
        Me.TxtTien_Xe_Tu.Location = New System.Drawing.Point(125, 52)
        Me.TxtTien_Xe_Tu.MaxWholeDigits = 11
        Me.TxtTien_Xe_Tu.Name = "TxtTien_Xe_Tu"
        Me.TxtTien_Xe_Tu.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Xe_Tu.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Xe_Tu.Size = New System.Drawing.Size(149, 21)
        Me.TxtTien_Xe_Tu.TabIndex = 2
        Me.TxtTien_Xe_Tu.Text = "1"
        Me.TxtTien_Xe_Tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTy_Le
        '
        Me.TxtTy_Le.AllowNegative = True
        Me.TxtTy_Le.Flags = 7680
        Me.TxtTy_Le.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Le.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Le.InputMask = "### ### ###.####"
        Me.TxtTy_Le.Location = New System.Drawing.Point(125, 77)
        Me.TxtTy_Le.MaxWholeDigits = 13
        Me.TxtTy_Le.Name = "TxtTy_Le"
        Me.TxtTy_Le.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Le.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Le.Size = New System.Drawing.Size(149, 21)
        Me.TxtTy_Le.TabIndex = 4
        Me.TxtTy_Le.Text = "1.00"
        Me.TxtTy_Le.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_Xe_Den
        '
        Me.TxtTien_Xe_Den.AllowNegative = True
        Me.TxtTien_Xe_Den.Flags = 7680
        Me.TxtTien_Xe_Den.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien_Xe_Den.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Xe_Den.InputMask = "### ### ### ###"
        Me.TxtTien_Xe_Den.Location = New System.Drawing.Point(389, 55)
        Me.TxtTien_Xe_Den.MaxWholeDigits = 11
        Me.TxtTien_Xe_Den.Name = "TxtTien_Xe_Den"
        Me.TxtTien_Xe_Den.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Xe_Den.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Xe_Den.Size = New System.Drawing.Size(149, 21)
        Me.TxtTien_Xe_Den.TabIndex = 3
        Me.TxtTien_Xe_Den.Text = "1"
        Me.TxtTien_Xe_Den.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(3, 55)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Pretax price"
        Me.LabGia_nt2.Text = "Giá trị xe từ"
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.Location = New System.Drawing.Point(4, 79)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(121, 17)
        Me.LabGia_nt3.TabIndex = 31
        Me.LabGia_nt3.Tag = "Price before tax"
        Me.LabGia_nt3.Text = "Tỷ lệ bảo hiểm (%)"
        '
        'Labgia2
        '
        Me.Labgia2.Location = New System.Drawing.Point(292, 55)
        Me.Labgia2.Name = "Labgia2"
        Me.Labgia2.Size = New System.Drawing.Size(91, 17)
        Me.Labgia2.TabIndex = 5
        Me.Labgia2.Tag = "Pretax price VND"
        Me.Labgia2.Text = "Giá trị xe đến"
        '
        'DmTyLeBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 161)
        Me.Controls.Add(Me.Labgia2)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.TxtTien_Xe_Den)
        Me.Controls.Add(Me.TxtTy_Le)
        Me.Controls.Add(Me.TxtTien_Xe_Tu)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmTyLeBH"
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Xe_Tu, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Le, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Xe_Den, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labgia2, 0)
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents TxtTien_Xe_Tu As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtTy_Le As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtTien_Xe_Den As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents Labgia2 As System.Windows.Forms.Label

End Class
