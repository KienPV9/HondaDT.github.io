<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDX_LuuCoc
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
        Me.TxtNgay_LuuCoc = New ClsTextBox.txtDate()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ChkIs_LuuCoc = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTien_KHTT = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 103)
        Me.GroupBoxLine.Size = New System.Drawing.Size(631, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(431, 113)
        Me.ButtOK.TabIndex = 17
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(533, 113)
        Me.ButtExit.TabIndex = 18
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(234, 113)
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
        Me.Label78.Location = New System.Drawing.Point(-1, 38)
        Me.Label78.Margin = New System.Windows.Forms.Padding(0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(106, 18)
        Me.Label78.TabIndex = 2144
        Me.Label78.Tag = "Day"
        Me.Label78.Text = "Ngày lưu cọc"
        '
        'TxtNgay_LuuCoc
        '
        Me.TxtNgay_LuuCoc.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LuuCoc.Flags = 65536
        Me.TxtNgay_LuuCoc.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LuuCoc.isEmpty = True
        Me.TxtNgay_LuuCoc.Location = New System.Drawing.Point(112, 37)
        Me.TxtNgay_LuuCoc.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LuuCoc.MaxLength = 10
        Me.TxtNgay_LuuCoc.Name = "TxtNgay_LuuCoc"
        Me.TxtNgay_LuuCoc.RangeMax = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LuuCoc.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LuuCoc.ShowDayBeforeMonth = False
        Me.TxtNgay_LuuCoc.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_LuuCoc.TabIndex = 2
        Me.TxtNgay_LuuCoc.Text = "__/__/____"
        Me.TxtNgay_LuuCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LuuCoc.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(112, 63)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(511, 20)
        Me.TxtDien_Giai.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(-1, 66)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 15)
        Me.Label16.TabIndex = 2166
        Me.Label16.Tag = "Note"
        Me.Label16.Text = "Lý do lưu cọc"
        '
        'ChkIs_LuuCoc
        '
        Me.ChkIs_LuuCoc.AutoSize = True
        Me.ChkIs_LuuCoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_LuuCoc.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_LuuCoc.Location = New System.Drawing.Point(112, 12)
        Me.ChkIs_LuuCoc.Name = "ChkIs_LuuCoc"
        Me.ChkIs_LuuCoc.Size = New System.Drawing.Size(78, 19)
        Me.ChkIs_LuuCoc.TabIndex = 0
        Me.ChkIs_LuuCoc.Tag = "Cancellation"
        Me.ChkIs_LuuCoc.Text = "Lưu Cọc"
        Me.ChkIs_LuuCoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkIs_LuuCoc.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(276, 37)
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
        Me.TxtTien_KHTT.Location = New System.Drawing.Point(458, 37)
        Me.TxtTien_KHTT.MaxWholeDigits = 11
        Me.TxtTien_KHTT.Name = "TxtTien_KHTT"
        Me.TxtTien_KHTT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_KHTT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_KHTT.Size = New System.Drawing.Size(112, 20)
        Me.TxtTien_KHTT.TabIndex = 2186
        Me.TxtTien_KHTT.Text = "0"
        Me.TxtTien_KHTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HDX_LuuCoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(635, 167)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTien_KHTT)
        Me.Controls.Add(Me.ChkIs_LuuCoc)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.TxtNgay_LuuCoc)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HDX_LuuCoc"
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LuuCoc, 0)
        Me.Controls.SetChildIndex(Me.Label78, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_LuuCoc, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_KHTT, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStt_Rec As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents TxtNgay_LuuCoc As ClsTextBox.txtDate
    Friend WithEvents TxtDien_Giai As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ChkIs_LuuCoc As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTien_KHTT As ClsTextBox.txtTien_NT
End Class
