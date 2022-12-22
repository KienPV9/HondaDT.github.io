<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDX_Huy
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
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TxtNgay_Huy = New ClsTextBox.txtDate()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TxtTien_Tra_Coc = New ClsTextBox.txtTien_NT()
        Me.CmbMa_LyDoTL = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ChkIs_Huy = New System.Windows.Forms.CheckBox()
        Me.TxtSo_Bien_Ban = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkIs_TM = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkIs_CK = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_TK_NC = New System.Windows.Forms.TextBox()
        Me.TxtTK_NC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNH_NC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNH_TC1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLD_NHTC1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLD_NHTC2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNH_TC2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTien_KHTT = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 414)
        Me.GroupBoxLine.Size = New System.Drawing.Size(631, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(431, 424)
        Me.ButtOK.TabIndex = 17
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(533, 424)
        Me.ButtExit.TabIndex = 18
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(234, 424)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(31, 21)
        Me.TxtStt_Rec.TabIndex = 1977
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Navy
        Me.Label78.Location = New System.Drawing.Point(0, 57)
        Me.Label78.Margin = New System.Windows.Forms.Padding(0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(106, 18)
        Me.Label78.TabIndex = 2144
        Me.Label78.Tag = "Day"
        Me.Label78.Text = "Ngày thanh lý"
        '
        'TxtNgay_Huy
        '
        Me.TxtNgay_Huy.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Huy.Flags = 65536
        Me.TxtNgay_Huy.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Huy.isEmpty = True
        Me.TxtNgay_Huy.Location = New System.Drawing.Point(113, 56)
        Me.TxtNgay_Huy.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Huy.MaxLength = 10
        Me.TxtNgay_Huy.Name = "TxtNgay_Huy"
        Me.TxtNgay_Huy.RangeMax = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Huy.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Huy.ShowDayBeforeMonth = False
        Me.TxtNgay_Huy.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_Huy.TabIndex = 2
        Me.TxtNgay_Huy.Text = "__/__/____"
        Me.TxtNgay_Huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Huy.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(0, 135)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(70, 15)
        Me.Label60.TabIndex = 2148
        Me.Label60.Tag = "Invoice rate"
        Me.Label60.Text = "Tiền trả cọc"
        '
        'TxtTien_Tra_Coc
        '
        Me.TxtTien_Tra_Coc.AllowNegative = True
        Me.TxtTien_Tra_Coc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTien_Tra_Coc.Flags = 7680
        Me.TxtTien_Tra_Coc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Tra_Coc.InputMask = "### ### ### ###"
        Me.TxtTien_Tra_Coc.Location = New System.Drawing.Point(113, 133)
        Me.TxtTien_Tra_Coc.MaxWholeDigits = 11
        Me.TxtTien_Tra_Coc.Name = "TxtTien_Tra_Coc"
        Me.TxtTien_Tra_Coc.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Tra_Coc.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Tra_Coc.Size = New System.Drawing.Size(128, 20)
        Me.TxtTien_Tra_Coc.TabIndex = 5
        Me.TxtTien_Tra_Coc.Text = "0"
        Me.TxtTien_Tra_Coc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbMa_LyDoTL
        '
        Me.CmbMa_LyDoTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_LyDoTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_LyDoTL.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_LyDoTL.FormattingEnabled = True
        Me.CmbMa_LyDoTL.Location = New System.Drawing.Point(113, 80)
        Me.CmbMa_LyDoTL.Name = "CmbMa_LyDoTL"
        Me.CmbMa_LyDoTL.Size = New System.Drawing.Size(511, 23)
        Me.CmbMa_LyDoTL.TabIndex = 3
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Navy
        Me.Label73.Location = New System.Drawing.Point(0, 83)
        Me.Label73.Margin = New System.Windows.Forms.Padding(0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(81, 15)
        Me.Label73.TabIndex = 2164
        Me.Label73.Tag = "Bank"
        Me.Label73.Text = "Lý do thanh lý"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(113, 106)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(511, 20)
        Me.TxtDien_Giai.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(0, 109)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 15)
        Me.Label16.TabIndex = 2166
        Me.Label16.Tag = "Note"
        Me.Label16.Text = "Ghi chú"
        '
        'ChkIs_Huy
        '
        Me.ChkIs_Huy.AutoSize = True
        Me.ChkIs_Huy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_Huy.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_Huy.Location = New System.Drawing.Point(113, 9)
        Me.ChkIs_Huy.Name = "ChkIs_Huy"
        Me.ChkIs_Huy.Size = New System.Drawing.Size(114, 19)
        Me.ChkIs_Huy.TabIndex = 0
        Me.ChkIs_Huy.Tag = "Cancellation"
        Me.ChkIs_Huy.Text = "Hủy hợp đồng"
        Me.ChkIs_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkIs_Huy.UseVisualStyleBackColor = True
        '
        'TxtSo_Bien_Ban
        '
        Me.TxtSo_Bien_Ban.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSo_Bien_Ban.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Bien_Ban.Location = New System.Drawing.Point(113, 34)
        Me.TxtSo_Bien_Ban.Name = "TxtSo_Bien_Ban"
        Me.TxtSo_Bien_Ban.Size = New System.Drawing.Size(128, 20)
        Me.TxtSo_Bien_Ban.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2168
        Me.Label1.Tag = "Note"
        Me.Label1.Text = "Số biên bản"
        '
        'ChkIs_TM
        '
        Me.ChkIs_TM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_TM.AutoSize = True
        Me.ChkIs_TM.BackColor = System.Drawing.Color.Transparent
        Me.ChkIs_TM.ForeColor = System.Drawing.Color.Navy
        Me.ChkIs_TM.Location = New System.Drawing.Point(114, 182)
        Me.ChkIs_TM.Name = "ChkIs_TM"
        Me.ChkIs_TM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkIs_TM.Size = New System.Drawing.Size(42, 17)
        Me.ChkIs_TM.TabIndex = 6
        Me.ChkIs_TM.Text = "TM"
        Me.ChkIs_TM.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkIs_TM.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(0, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 2170
        Me.Label2.Tag = "Invoice rate"
        Me.Label2.Text = "Hình thức nhận cọc"
        '
        'ChkIs_CK
        '
        Me.ChkIs_CK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_CK.AutoSize = True
        Me.ChkIs_CK.BackColor = System.Drawing.Color.Transparent
        Me.ChkIs_CK.ForeColor = System.Drawing.Color.Navy
        Me.ChkIs_CK.Location = New System.Drawing.Point(186, 182)
        Me.ChkIs_CK.Name = "ChkIs_CK"
        Me.ChkIs_CK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkIs_CK.Size = New System.Drawing.Size(40, 17)
        Me.ChkIs_CK.TabIndex = 7
        Me.ChkIs_CK.Text = "CK"
        Me.ChkIs_CK.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkIs_CK.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(22, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2172
        Me.Label3.Tag = "Invoice rate"
        Me.Label3.Text = "Tên TK"
        '
        'TxtTen_TK_NC
        '
        Me.TxtTen_TK_NC.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK_NC.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK_NC.Location = New System.Drawing.Point(106, 205)
        Me.TxtTen_TK_NC.Name = "TxtTen_TK_NC"
        Me.TxtTen_TK_NC.Size = New System.Drawing.Size(479, 20)
        Me.TxtTen_TK_NC.TabIndex = 8
        '
        'TxtTK_NC
        '
        Me.TxtTK_NC.BackColor = System.Drawing.Color.White
        Me.TxtTK_NC.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK_NC.Location = New System.Drawing.Point(106, 231)
        Me.TxtTK_NC.Name = "TxtTK_NC"
        Me.TxtTK_NC.Size = New System.Drawing.Size(479, 20)
        Me.TxtTK_NC.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(22, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 2174
        Me.Label4.Tag = "Invoice rate"
        Me.Label4.Text = "Tài khoản"
        '
        'TxtNH_NC
        '
        Me.TxtNH_NC.BackColor = System.Drawing.Color.White
        Me.TxtNH_NC.ForeColor = System.Drawing.Color.Navy
        Me.TxtNH_NC.Location = New System.Drawing.Point(106, 257)
        Me.TxtNH_NC.Name = "TxtNH_NC"
        Me.TxtNH_NC.Size = New System.Drawing.Size(479, 20)
        Me.TxtNH_NC.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(22, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 2176
        Me.Label5.Tag = "Invoice rate"
        Me.Label5.Text = "Ngân hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(0, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 2178
        Me.Label6.Tag = "Invoice rate"
        Me.Label6.Text = "Thông tin ngân hàng"
        '
        'TxtNH_TC1
        '
        Me.TxtNH_TC1.BackColor = System.Drawing.Color.White
        Me.TxtNH_TC1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNH_TC1.Location = New System.Drawing.Point(106, 312)
        Me.TxtNH_TC1.Name = "TxtNH_TC1"
        Me.TxtNH_TC1.Size = New System.Drawing.Size(479, 20)
        Me.TxtNH_TC1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(22, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 2179
        Me.Label7.Tag = "Invoice rate"
        Me.Label7.Text = "Ngân hàng 1"
        '
        'TxtLD_NHTC1
        '
        Me.TxtLD_NHTC1.BackColor = System.Drawing.Color.White
        Me.TxtLD_NHTC1.ForeColor = System.Drawing.Color.Navy
        Me.TxtLD_NHTC1.Location = New System.Drawing.Point(106, 338)
        Me.TxtLD_NHTC1.Name = "TxtLD_NHTC1"
        Me.TxtLD_NHTC1.Size = New System.Drawing.Size(479, 20)
        Me.TxtLD_NHTC1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(22, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 2181
        Me.Label8.Tag = "Invoice rate"
        Me.Label8.Text = "Lý do"
        '
        'TxtLD_NHTC2
        '
        Me.TxtLD_NHTC2.BackColor = System.Drawing.Color.White
        Me.TxtLD_NHTC2.ForeColor = System.Drawing.Color.Navy
        Me.TxtLD_NHTC2.Location = New System.Drawing.Point(106, 390)
        Me.TxtLD_NHTC2.Name = "TxtLD_NHTC2"
        Me.TxtLD_NHTC2.Size = New System.Drawing.Size(479, 20)
        Me.TxtLD_NHTC2.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(22, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 2185
        Me.Label9.Tag = "Invoice rate"
        Me.Label9.Text = "Lý do"
        '
        'TxtNH_TC2
        '
        Me.TxtNH_TC2.BackColor = System.Drawing.Color.White
        Me.TxtNH_TC2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNH_TC2.Location = New System.Drawing.Point(106, 364)
        Me.TxtNH_TC2.Name = "TxtNH_TC2"
        Me.TxtNH_TC2.Size = New System.Drawing.Size(479, 20)
        Me.TxtNH_TC2.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(22, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 2183
        Me.Label10.Tag = "Invoice rate"
        Me.Label10.Text = "Ngân hàng 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(277, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 15)
        Me.Label11.TabIndex = 2187
        Me.Label11.Tag = "Invoice rate"
        Me.Label11.Text = "Tiền khách hàng đã thanh toán"
        '
        'TxtTien_KHTT
        '
        Me.TxtTien_KHTT.AllowNegative = True
        Me.TxtTien_KHTT.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TxtTien_KHTT.Flags = 7680
        Me.TxtTien_KHTT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_KHTT.InputMask = "### ### ### ###"
        Me.TxtTien_KHTT.Location = New System.Drawing.Point(459, 133)
        Me.TxtTien_KHTT.MaxWholeDigits = 11
        Me.TxtTien_KHTT.Name = "TxtTien_KHTT"
        Me.TxtTien_KHTT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_KHTT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_KHTT.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_KHTT.TabIndex = 2186
        Me.TxtTien_KHTT.Text = "0"
        Me.TxtTien_KHTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HDX_Huy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(635, 478)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTien_KHTT)
        Me.Controls.Add(Me.TxtLD_NHTC2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNH_TC2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtLD_NHTC1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNH_TC1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNH_NC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTK_NC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_TK_NC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChkIs_CK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkIs_TM)
        Me.Controls.Add(Me.TxtSo_Bien_Ban)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkIs_Huy)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmbMa_LyDoTL)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.TxtTien_Tra_Coc)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.TxtNgay_Huy)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HDX_Huy"
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Huy, 0)
        Me.Controls.SetChildIndex(Me.Label78, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Tra_Coc, 0)
        Me.Controls.SetChildIndex(Me.Label60, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label73, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_LyDoTL, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Huy, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Bien_Ban, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_TM, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_CK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK_NC, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTK_NC, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtNH_NC, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNH_TC1, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtLD_NHTC1, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNH_TC2, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtLD_NHTC2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_KHTT, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStt_Rec As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents TxtNgay_Huy As ClsTextBox.txtDate
    Friend WithEvents Label60 As Label
    Friend WithEvents TxtTien_Tra_Coc As ClsTextBox.txtTien_NT
    Friend WithEvents CmbMa_LyDoTL As ComboBox
    Friend WithEvents Label73 As Label
    Friend WithEvents TxtDien_Giai As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ChkIs_Huy As CheckBox
    Friend WithEvents TxtSo_Bien_Ban As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkIs_TM As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkIs_CK As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTen_TK_NC As TextBox
    Friend WithEvents TxtTK_NC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNH_NC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNH_TC1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLD_NHTC1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLD_NHTC2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNH_TC2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTien_KHTT As ClsTextBox.txtTien_NT
End Class
