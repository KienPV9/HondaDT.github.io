<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMCKDV
    Inherits Cyber.From.FrmList

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
        Me.TxtNgay_Ct = New ClsTextBox.txtDate1()
        Me.Chkis_thanhtoan = New System.Windows.Forms.CheckBox()
        Me.TxtNgan_hang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtgui_thu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtcong_no_kt = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtSo_CV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdThang = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdnam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTien = New ClsTextBox.txtTien_NT()
        Me.LabPt_Hh_Tv = New System.Windows.Forms.Label()
        Me.Txtghi_chu = New System.Windows.Forms.TextBox()
        Me.LabTen_Bh2 = New System.Windows.Forms.Label()
        Me.TxtNoi_Dung = New System.Windows.Forms.TextBox()
        Me.lab1 = New System.Windows.Forms.Label()
        Me.TxtMa = New System.Windows.Forms.TextBox()
        Me.LabMa_BH = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTra_khac = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 314)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 314)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 320)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 324)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 304)
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Flags = 0
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.IsAllowResize = False
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(512, 12)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(116, 21)
        Me.TxtNgay_Ct.TabIndex = 462
        Me.TxtNgay_Ct.Text = "__/__/____"
        Me.TxtNgay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Chkis_thanhtoan
        '
        Me.Chkis_thanhtoan.AutoSize = True
        Me.Chkis_thanhtoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkis_thanhtoan.ForeColor = System.Drawing.Color.Navy
        Me.Chkis_thanhtoan.Location = New System.Drawing.Point(97, 281)
        Me.Chkis_thanhtoan.Name = "Chkis_thanhtoan"
        Me.Chkis_thanhtoan.Size = New System.Drawing.Size(103, 19)
        Me.Chkis_thanhtoan.TabIndex = 472
        Me.Chkis_thanhtoan.Tag = "Stop following"
        Me.Chkis_thanhtoan.Text = "Đã thanh toán"
        Me.Chkis_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chkis_thanhtoan.UseVisualStyleBackColor = True
        '
        'TxtNgan_hang
        '
        Me.TxtNgan_hang.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgan_hang.Location = New System.Drawing.Point(97, 163)
        Me.TxtNgan_hang.Name = "TxtNgan_hang"
        Me.TxtNgan_hang.Size = New System.Drawing.Size(672, 21)
        Me.TxtNgan_hang.TabIndex = 467
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 482
        Me.Label4.Tag = "English name"
        Me.Label4.Text = "Số TK ngân hàng"
        '
        'Txtgui_thu
        '
        Me.Txtgui_thu.ForeColor = System.Drawing.Color.Navy
        Me.Txtgui_thu.Location = New System.Drawing.Point(97, 141)
        Me.Txtgui_thu.Name = "Txtgui_thu"
        Me.Txtgui_thu.Size = New System.Drawing.Size(672, 21)
        Me.Txtgui_thu.TabIndex = 466
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 481
        Me.Label3.Tag = "English name"
        Me.Label3.Text = "Mã gửi thư"
        '
        'Txtcong_no_kt
        '
        Me.Txtcong_no_kt.AllowNegative = True
        Me.Txtcong_no_kt.Flags = 7680
        Me.Txtcong_no_kt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Txtcong_no_kt.ForeColor = System.Drawing.Color.Navy
        Me.Txtcong_no_kt.InputMask = "### ### ### ### ###"
        Me.Txtcong_no_kt.Location = New System.Drawing.Point(97, 231)
        Me.Txtcong_no_kt.MaxWholeDigits = 14
        Me.Txtcong_no_kt.Name = "Txtcong_no_kt"
        Me.Txtcong_no_kt.RangeMax = 1.7976931348623157E+308R
        Me.Txtcong_no_kt.RangeMin = -1.7976931348623157E+308R
        Me.Txtcong_no_kt.Size = New System.Drawing.Size(149, 21)
        Me.Txtcong_no_kt.TabIndex = 469
        Me.Txtcong_no_kt.Text = "0"
        Me.Txtcong_no_kt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 480
        Me.Label2.Tag = "" & Global.Microsoft.VisualBasic.ChrW(13) & "Percent 1"
        Me.Label2.Text = "Công nợ KT"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(458, 14)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_CD.TabIndex = 479
        Me.LabMa_CD.Tag = "Date voucher"
        Me.LabMa_CD.Text = "Ngày"
        '
        'TxtSo_CV
        '
        Me.TxtSo_CV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_CV.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_CV.Location = New System.Drawing.Point(97, 58)
        Me.TxtSo_CV.Name = "TxtSo_CV"
        Me.TxtSo_CV.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_CV.TabIndex = 464
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 478
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Số CV"
        '
        'CmdThang
        '
        Me.CmdThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdThang.ForeColor = System.Drawing.Color.Navy
        Me.CmdThang.FormattingEnabled = True
        Me.CmdThang.Location = New System.Drawing.Point(325, 12)
        Me.CmdThang.Name = "CmdThang"
        Me.CmdThang.Size = New System.Drawing.Size(96, 21)
        Me.CmdThang.TabIndex = 461
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(262, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 477
        Me.Label7.Tag = "Leave"
        Me.Label7.Text = "Tháng"
        '
        'cmdnam
        '
        Me.cmdnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdnam.ForeColor = System.Drawing.Color.Navy
        Me.cmdnam.FormattingEnabled = True
        Me.cmdnam.Location = New System.Drawing.Point(97, 12)
        Me.cmdnam.Name = "cmdnam"
        Me.cmdnam.Size = New System.Drawing.Size(89, 21)
        Me.cmdnam.TabIndex = 460
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 476
        Me.Label6.Tag = "Leave"
        Me.Label6.Text = "Năm"
        '
        'TxtTien
        '
        Me.TxtTien.AllowNegative = True
        Me.TxtTien.Flags = 7680
        Me.TxtTien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien.InputMask = "### ### ### ### ###"
        Me.TxtTien.Location = New System.Drawing.Point(97, 186)
        Me.TxtTien.MaxWholeDigits = 14
        Me.TxtTien.Name = "TxtTien"
        Me.TxtTien.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien.Size = New System.Drawing.Size(149, 21)
        Me.TxtTien.TabIndex = 468
        Me.TxtTien.Text = "0"
        Me.TxtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabPt_Hh_Tv
        '
        Me.LabPt_Hh_Tv.Location = New System.Drawing.Point(12, 190)
        Me.LabPt_Hh_Tv.Name = "LabPt_Hh_Tv"
        Me.LabPt_Hh_Tv.Size = New System.Drawing.Size(107, 15)
        Me.LabPt_Hh_Tv.TabIndex = 475
        Me.LabPt_Hh_Tv.Tag = "" & Global.Microsoft.VisualBasic.ChrW(13) & "Percent 1"
        Me.LabPt_Hh_Tv.Text = "Số Tiền"
        '
        'Txtghi_chu
        '
        Me.Txtghi_chu.ForeColor = System.Drawing.Color.Navy
        Me.Txtghi_chu.Location = New System.Drawing.Point(97, 254)
        Me.Txtghi_chu.Name = "Txtghi_chu"
        Me.Txtghi_chu.Size = New System.Drawing.Size(672, 21)
        Me.Txtghi_chu.TabIndex = 471
        '
        'LabTen_Bh2
        '
        Me.LabTen_Bh2.Location = New System.Drawing.Point(12, 255)
        Me.LabTen_Bh2.Name = "LabTen_Bh2"
        Me.LabTen_Bh2.Size = New System.Drawing.Size(107, 15)
        Me.LabTen_Bh2.TabIndex = 474
        Me.LabTen_Bh2.Tag = "English name"
        Me.LabTen_Bh2.Text = "Ghi chú"
        '
        'TxtNoi_Dung
        '
        Me.TxtNoi_Dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Dung.Location = New System.Drawing.Point(97, 81)
        Me.TxtNoi_Dung.Multiline = True
        Me.TxtNoi_Dung.Name = "TxtNoi_Dung"
        Me.TxtNoi_Dung.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNoi_Dung.Size = New System.Drawing.Size(672, 58)
        Me.TxtNoi_Dung.TabIndex = 465
        '
        'lab1
        '
        Me.lab1.Location = New System.Drawing.Point(12, 102)
        Me.lab1.Name = "lab1"
        Me.lab1.Size = New System.Drawing.Size(107, 15)
        Me.lab1.TabIndex = 473
        Me.lab1.Tag = "Name"
        Me.lab1.Text = "Nội dung"
        '
        'TxtMa
        '
        Me.TxtMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa.Location = New System.Drawing.Point(97, 35)
        Me.TxtMa.Name = "TxtMa"
        Me.TxtMa.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa.TabIndex = 463
        '
        'LabMa_BH
        '
        Me.LabMa_BH.Location = New System.Drawing.Point(12, 36)
        Me.LabMa_BH.Name = "LabMa_BH"
        Me.LabMa_BH.Size = New System.Drawing.Size(107, 15)
        Me.LabMa_BH.TabIndex = 470
        Me.LabMa_BH.Tag = "Code"
        Me.LabMa_BH.Text = "Mã số"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 483
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Trả khác"
        '
        'TxtTra_khac
        '
        Me.TxtTra_khac.ForeColor = System.Drawing.Color.Navy
        Me.TxtTra_khac.Location = New System.Drawing.Point(97, 208)
        Me.TxtTra_khac.Name = "TxtTra_khac"
        Me.TxtTra_khac.Size = New System.Drawing.Size(672, 21)
        Me.TxtTra_khac.TabIndex = 484
        '
        'DMCKDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 347)
        Me.Controls.Add(Me.TxtTra_khac)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.Chkis_thanhtoan)
        Me.Controls.Add(Me.TxtNgan_hang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtgui_thu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtcong_no_kt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.TxtSo_CV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdThang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdnam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTien)
        Me.Controls.Add(Me.LabPt_Hh_Tv)
        Me.Controls.Add(Me.Txtghi_chu)
        Me.Controls.Add(Me.LabTen_Bh2)
        Me.Controls.Add(Me.TxtNoi_Dung)
        Me.Controls.Add(Me.lab1)
        Me.Controls.Add(Me.TxtMa)
        Me.Controls.Add(Me.LabMa_BH)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMCKDV"
        Me.Text = "Danh mục công ty"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa, 0)
        Me.Controls.SetChildIndex(Me.lab1, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.LabTen_Bh2, 0)
        Me.Controls.SetChildIndex(Me.Txtghi_chu, 0)
        Me.Controls.SetChildIndex(Me.LabPt_Hh_Tv, 0)
        Me.Controls.SetChildIndex(Me.TxtTien, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.cmdnam, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CmdThang, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_CV, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtcong_no_kt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Txtgui_thu, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNgan_hang, 0)
        Me.Controls.SetChildIndex(Me.Chkis_thanhtoan, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTra_khac, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate1
    Friend WithEvents Chkis_thanhtoan As Windows.Forms.CheckBox
    Friend WithEvents TxtNgan_hang As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txtgui_thu As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Txtcong_no_kt As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LabMa_CD As Windows.Forms.Label
    Friend WithEvents TxtSo_CV As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CmdThang As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents cmdnam As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtTien As ClsTextBox.txtTien_NT
    Friend WithEvents LabPt_Hh_Tv As Windows.Forms.Label
    Friend WithEvents Txtghi_chu As Windows.Forms.TextBox
    Friend WithEvents LabTen_Bh2 As Windows.Forms.Label
    Friend WithEvents TxtNoi_Dung As Windows.Forms.TextBox
    Friend WithEvents lab1 As Windows.Forms.Label
    Friend WithEvents TxtMa As Windows.Forms.TextBox
    Friend WithEvents LabMa_BH As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtTra_khac As Windows.Forms.TextBox
End Class
