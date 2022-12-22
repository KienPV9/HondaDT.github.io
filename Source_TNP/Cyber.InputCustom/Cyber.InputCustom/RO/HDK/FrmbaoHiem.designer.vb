<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmbaoHiem
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
        Me.TxtE_Mail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNgay_NL = New ClsTextBox.txtDate()
        Me.CbbMa_BH_NL = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNgay_VC = New ClsTextBox.txtDate()
        Me.CbbMa_BH_VC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNgay_DS = New ClsTextBox.txtDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbbMa_BH_DS = New System.Windows.Forms.ComboBox()
        Me.TxtDt_LX = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.LblDia_Chi = New System.Windows.Forms.Label()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.lblMa_kh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkNl_Dl = New System.Windows.Forms.CheckBox()
        Me.ChkVc_Dl = New System.Windows.Forms.CheckBox()
        Me.ChkDs_Dl = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 191)
        Me.GroupBoxLine.Size = New System.Drawing.Size(652, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(452, 201)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(554, 201)
        '
        'TxtE_Mail
        '
        Me.TxtE_Mail.BackColor = System.Drawing.Color.White
        Me.TxtE_Mail.ForeColor = System.Drawing.Color.Navy
        Me.TxtE_Mail.Location = New System.Drawing.Point(378, 94)
        Me.TxtE_Mail.Name = "TxtE_Mail"
        Me.TxtE_Mail.Size = New System.Drawing.Size(274, 20)
        Me.TxtE_Mail.TabIndex = 315
        Me.TxtE_Mail.Tag = ""
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(317, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 333
        Me.Label9.Tag = "E-Mail"
        Me.Label9.Text = "E-Mail"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(317, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 332
        Me.Label7.Tag = "Driver tel"
        Me.Label7.Text = "Đơn vị BH"
        '
        'TxtNgay_NL
        '
        Me.TxtNgay_NL.BackColor = System.Drawing.Color.White
        Me.TxtNgay_NL.Flags = 65536
        Me.TxtNgay_NL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_NL.isEmpty = True
        Me.TxtNgay_NL.Location = New System.Drawing.Point(111, 163)
        Me.TxtNgay_NL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_NL.MaxLength = 10
        Me.TxtNgay_NL.Name = "TxtNgay_NL"
        Me.TxtNgay_NL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_NL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_NL.ShowDayBeforeMonth = False
        Me.TxtNgay_NL.Size = New System.Drawing.Size(101, 20)
        Me.TxtNgay_NL.TabIndex = 320
        Me.TxtNgay_NL.Text = "18/09/2011"
        Me.TxtNgay_NL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_NL.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'CbbMa_BH_NL
        '
        Me.CbbMa_BH_NL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BH_NL.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BH_NL.FormattingEnabled = True
        Me.CbbMa_BH_NL.Location = New System.Drawing.Point(378, 163)
        Me.CbbMa_BH_NL.Name = "CbbMa_BH_NL"
        Me.CbbMa_BH_NL.Size = New System.Drawing.Size(274, 21)
        Me.CbbMa_BH_NL.TabIndex = 321
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(317, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 331
        Me.Label6.Tag = "Driver tel"
        Me.Label6.Text = "Đơn vị BH"
        '
        'TxtNgay_VC
        '
        Me.TxtNgay_VC.BackColor = System.Drawing.Color.White
        Me.TxtNgay_VC.Flags = 65536
        Me.TxtNgay_VC.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_VC.isEmpty = True
        Me.TxtNgay_VC.Location = New System.Drawing.Point(111, 140)
        Me.TxtNgay_VC.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_VC.MaxLength = 10
        Me.TxtNgay_VC.Name = "TxtNgay_VC"
        Me.TxtNgay_VC.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_VC.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_VC.ShowDayBeforeMonth = False
        Me.TxtNgay_VC.Size = New System.Drawing.Size(101, 20)
        Me.TxtNgay_VC.TabIndex = 318
        Me.TxtNgay_VC.Text = "18/09/2011"
        Me.TxtNgay_VC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_VC.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'CbbMa_BH_VC
        '
        Me.CbbMa_BH_VC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BH_VC.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BH_VC.FormattingEnabled = True
        Me.CbbMa_BH_VC.Location = New System.Drawing.Point(378, 140)
        Me.CbbMa_BH_VC.Name = "CbbMa_BH_VC"
        Me.CbbMa_BH_VC.Size = New System.Drawing.Size(274, 21)
        Me.CbbMa_BH_VC.TabIndex = 319
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(317, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 330
        Me.Label5.Tag = "Driver tel"
        Me.Label5.Text = "Đơn vị BH"
        '
        'TxtNgay_DS
        '
        Me.TxtNgay_DS.BackColor = System.Drawing.Color.White
        Me.TxtNgay_DS.Flags = 65536
        Me.TxtNgay_DS.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_DS.isEmpty = True
        Me.TxtNgay_DS.Location = New System.Drawing.Point(111, 117)
        Me.TxtNgay_DS.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_DS.MaxLength = 10
        Me.TxtNgay_DS.Name = "TxtNgay_DS"
        Me.TxtNgay_DS.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_DS.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_DS.ShowDayBeforeMonth = False
        Me.TxtNgay_DS.Size = New System.Drawing.Size(101, 20)
        Me.TxtNgay_DS.TabIndex = 316
        Me.TxtNgay_DS.Text = "18/09/2011"
        Me.TxtNgay_DS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_DS.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(4, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 329
        Me.Label3.Tag = "Driver tel"
        Me.Label3.Text = "Bảo hiểm lái phụ"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(4, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 328
        Me.Label2.Tag = "Driver tel"
        Me.Label2.Text = "Bảo hiểm vật chất"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 327
        Me.Label1.Tag = "Driver tel"
        Me.Label1.Text = "Bảo hiểm nhân sự"
        '
        'CbbMa_BH_DS
        '
        Me.CbbMa_BH_DS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BH_DS.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BH_DS.FormattingEnabled = True
        Me.CbbMa_BH_DS.Location = New System.Drawing.Point(378, 117)
        Me.CbbMa_BH_DS.Name = "CbbMa_BH_DS"
        Me.CbbMa_BH_DS.Size = New System.Drawing.Size(274, 21)
        Me.CbbMa_BH_DS.TabIndex = 317
        '
        'TxtDt_LX
        '
        Me.TxtDt_LX.BackColor = System.Drawing.Color.White
        Me.TxtDt_LX.ForeColor = System.Drawing.Color.Navy
        Me.TxtDt_LX.Location = New System.Drawing.Point(111, 94)
        Me.TxtDt_LX.Name = "TxtDt_LX"
        Me.TxtDt_LX.Size = New System.Drawing.Size(142, 20)
        Me.TxtDt_LX.TabIndex = 314
        Me.TxtDt_LX.Tag = ""
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(4, 97)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 326
        Me.Label11.Tag = "Driver tel"
        Me.Label11.Text = "ĐT Lái xe"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Thoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(111, 71)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(142, 20)
        Me.TxtDien_Thoai.TabIndex = 313
        Me.TxtDien_Thoai.Tag = ""
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(4, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 325
        Me.Label8.Tag = "Tel"
        Me.Label8.Text = "Điện thoại"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(111, 2)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(142, 20)
        Me.TxtMa_Xe.TabIndex = 310
        Me.TxtMa_Xe.Tag = ""
        '
        'LblDia_Chi
        '
        Me.LblDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LblDia_Chi.Location = New System.Drawing.Point(4, 51)
        Me.LblDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDia_Chi.Name = "LblDia_Chi"
        Me.LblDia_Chi.Size = New System.Drawing.Size(98, 15)
        Me.LblDia_Chi.TabIndex = 323
        Me.LblDia_Chi.Tag = "Address"
        Me.LblDia_Chi.Text = "Địa chỉ"
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Chi.Location = New System.Drawing.Point(111, 48)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(543, 20)
        Me.TxtDia_Chi.TabIndex = 312
        Me.TxtDia_Chi.Tag = ""
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(111, 25)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.Size = New System.Drawing.Size(543, 20)
        Me.TxtTen_kh.TabIndex = 311
        Me.TxtTen_kh.Tag = ""
        '
        'lblMa_kh
        '
        Me.lblMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.lblMa_kh.Location = New System.Drawing.Point(4, 28)
        Me.lblMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMa_kh.Name = "lblMa_kh"
        Me.lblMa_kh.Size = New System.Drawing.Size(98, 15)
        Me.lblMa_kh.TabIndex = 322
        Me.lblMa_kh.Tag = "Customer"
        Me.lblMa_kh.Text = "Khách hàng"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(4, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 324
        Me.Label4.Tag = "Type (R/O)"
        Me.Label4.Text = "Biển số"
        '
        'ChkNl_Dl
        '
        Me.ChkNl_Dl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNl_Dl.AutoSize = True
        Me.ChkNl_Dl.Location = New System.Drawing.Point(218, 166)
        Me.ChkNl_Dl.Name = "ChkNl_Dl"
        Me.ChkNl_Dl.Size = New System.Drawing.Size(89, 17)
        Me.ChkNl_Dl.TabIndex = 1936
        Me.ChkNl_Dl.TabStop = False
        Me.ChkNl_Dl.Tag = "Disc"
        Me.ChkNl_Dl.Text = "Mua tại đại lý"
        Me.ChkNl_Dl.UseVisualStyleBackColor = True
        '
        'ChkVc_Dl
        '
        Me.ChkVc_Dl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkVc_Dl.AutoSize = True
        Me.ChkVc_Dl.Location = New System.Drawing.Point(218, 143)
        Me.ChkVc_Dl.Name = "ChkVc_Dl"
        Me.ChkVc_Dl.Size = New System.Drawing.Size(89, 17)
        Me.ChkVc_Dl.TabIndex = 1935
        Me.ChkVc_Dl.TabStop = False
        Me.ChkVc_Dl.Tag = "Disc"
        Me.ChkVc_Dl.Text = "Mua tại đại lý"
        Me.ChkVc_Dl.UseVisualStyleBackColor = True
        '
        'ChkDs_Dl
        '
        Me.ChkDs_Dl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDs_Dl.AutoSize = True
        Me.ChkDs_Dl.Location = New System.Drawing.Point(218, 120)
        Me.ChkDs_Dl.Name = "ChkDs_Dl"
        Me.ChkDs_Dl.Size = New System.Drawing.Size(89, 17)
        Me.ChkDs_Dl.TabIndex = 1934
        Me.ChkDs_Dl.TabStop = False
        Me.ChkDs_Dl.Tag = "Disc"
        Me.ChkDs_Dl.Text = "Mua tại đại lý"
        Me.ChkDs_Dl.UseVisualStyleBackColor = True
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(244, 201)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(142, 20)
        Me.TxtMa_Dvcs.TabIndex = 1937
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'FrmbaoHiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(656, 255)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.ChkNl_Dl)
        Me.Controls.Add(Me.ChkVc_Dl)
        Me.Controls.Add(Me.ChkDs_Dl)
        Me.Controls.Add(Me.TxtE_Mail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNgay_NL)
        Me.Controls.Add(Me.CbbMa_BH_NL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNgay_VC)
        Me.Controls.Add(Me.CbbMa_BH_VC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNgay_DS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbMa_BH_DS)
        Me.Controls.Add(Me.TxtDt_LX)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.LblDia_Chi)
        Me.Controls.Add(Me.TxtDia_Chi)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.lblMa_kh)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmbaoHiem"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblMa_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.LblDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtDt_LX, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_BH_DS, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_DS, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_BH_VC, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_VC, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_BH_NL, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_NL, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtE_Mail, 0)
        Me.Controls.SetChildIndex(Me.ChkDs_Dl, 0)
        Me.Controls.SetChildIndex(Me.ChkVc_Dl, 0)
        Me.Controls.SetChildIndex(Me.ChkNl_Dl, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtE_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_NL As ClsTextBox.txtDate
    Friend WithEvents CbbMa_BH_NL As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_VC As ClsTextBox.txtDate
    Friend WithEvents CbbMa_BH_VC As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_DS As ClsTextBox.txtDate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_BH_DS As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDt_LX As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents LblDia_Chi As System.Windows.Forms.Label
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents lblMa_kh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkNl_Dl As System.Windows.Forms.CheckBox
    Friend WithEvents ChkVc_Dl As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDs_Dl As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox

End Class
