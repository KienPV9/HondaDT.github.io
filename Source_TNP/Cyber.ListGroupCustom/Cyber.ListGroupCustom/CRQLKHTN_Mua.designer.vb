<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRQLKHTN_Mua
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
        Me.TxtNgay_Gx = New ClsTextBox.txtDate()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CmbMa_KHMUA = New System.Windows.Forms.ComboBox()
        Me.Cmbma_HTTT = New System.Windows.Forms.ComboBox()
        Me.CmbMa_Kx = New System.Windows.Forms.ComboBox()
        Me.CmbMa_Mau = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDia_Chi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.CmbMa_TT = New System.Windows.Forms.ComboBox()
        Me.Txtten_TT = New System.Windows.Forms.TextBox()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.txtten_Mau = New System.Windows.Forms.TextBox()
        Me.txtTen_HTTT = New System.Windows.Forms.TextBox()
        Me.TxtTen_khMua = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 121)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(572, 11)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(372, 131)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(474, 131)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'TxtNgay_Gx
        '
        Me.TxtNgay_Gx.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Gx.Flags = 65536
        Me.TxtNgay_Gx.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Gx.isEmpty = True
        Me.TxtNgay_Gx.Location = New System.Drawing.Point(385, 99)
        Me.TxtNgay_Gx.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Gx.MaxLength = 10
        Me.TxtNgay_Gx.Name = "TxtNgay_Gx"
        Me.TxtNgay_Gx.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Gx.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Gx.ShowDayBeforeMonth = False
        Me.TxtNgay_Gx.Size = New System.Drawing.Size(99, 20)
        Me.TxtNgay_Gx.TabIndex = 7
        Me.TxtNgay_Gx.Text = "18/09/2011"
        Me.TxtNgay_Gx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Gx.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(272, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 1969
        Me.Label2.Tag = "Expected delivery date"
        Me.Label2.Text = "Ngày dự kiến giao xe"
        '
        'Label29
        '
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(272, 77)
        Me.Label29.Margin = New System.Windows.Forms.Padding(0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 20)
        Me.Label29.TabIndex = 1968
        Me.Label29.Tag = "Time to buy"
        Me.Label29.Text = "KH Mua"
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(272, 54)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(107, 20)
        Me.Label28.TabIndex = 1967
        Me.Label28.Tag = "Payment type"
        Me.Label28.Text = "Thanh toán"
        '
        'Label27
        '
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(3, 75)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 20)
        Me.Label27.TabIndex = 1966
        Me.Label27.Tag = "Colour"
        Me.Label27.Text = "Màu xe"
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(3, 52)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 20)
        Me.Label26.TabIndex = 1965
        Me.Label26.Tag = "Model car"
        Me.Label26.Text = "Loại xe"
        '
        'CmbMa_KHMUA
        '
        Me.CmbMa_KHMUA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_KHMUA.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_KHMUA.FormattingEnabled = True
        Me.CmbMa_KHMUA.Location = New System.Drawing.Point(385, 75)
        Me.CmbMa_KHMUA.Name = "CmbMa_KHMUA"
        Me.CmbMa_KHMUA.Size = New System.Drawing.Size(186, 21)
        Me.CmbMa_KHMUA.TabIndex = 6
        '
        'Cmbma_HTTT
        '
        Me.Cmbma_HTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbma_HTTT.ForeColor = System.Drawing.Color.Navy
        Me.Cmbma_HTTT.FormattingEnabled = True
        Me.Cmbma_HTTT.Location = New System.Drawing.Point(385, 51)
        Me.Cmbma_HTTT.Name = "Cmbma_HTTT"
        Me.Cmbma_HTTT.Size = New System.Drawing.Size(186, 21)
        Me.Cmbma_HTTT.TabIndex = 5
        '
        'CmbMa_Kx
        '
        Me.CmbMa_Kx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Kx.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Kx.FormattingEnabled = True
        Me.CmbMa_Kx.Location = New System.Drawing.Point(75, 51)
        Me.CmbMa_Kx.Name = "CmbMa_Kx"
        Me.CmbMa_Kx.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_Kx.TabIndex = 2
        '
        'CmbMa_Mau
        '
        Me.CmbMa_Mau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Mau.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Mau.FormattingEnabled = True
        Me.CmbMa_Mau.Location = New System.Drawing.Point(75, 75)
        Me.CmbMa_Mau.Name = "CmbMa_Mau"
        Me.CmbMa_Mau.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_Mau.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(3, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 1964
        Me.Label1.Tag = "Result"
        Me.Label1.Text = "Kết quả"
        '
        'LblDia_Chi
        '
        Me.LblDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LblDia_Chi.Location = New System.Drawing.Point(3, 35)
        Me.LblDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDia_Chi.Name = "LblDia_Chi"
        Me.LblDia_Chi.Size = New System.Drawing.Size(67, 18)
        Me.LblDia_Chi.TabIndex = 1963
        Me.LblDia_Chi.Tag = "Note"
        Me.LblDia_Chi.Text = "Ghi chú"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(3, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 1962
        Me.Label5.Tag = "Content"
        Me.Label5.Text = "Nội dung"
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.BackColor = System.Drawing.Color.White
        Me.TxtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(75, 29)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(495, 20)
        Me.TxtGhi_Chu.TabIndex = 1
        Me.TxtGhi_Chu.Tag = ""
        '
        'TxtNote
        '
        Me.TxtNote.BackColor = System.Drawing.Color.White
        Me.TxtNote.ForeColor = System.Drawing.Color.Navy
        Me.TxtNote.Location = New System.Drawing.Point(75, 7)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(495, 20)
        Me.TxtNote.TabIndex = 0
        Me.TxtNote.Tag = ""
        '
        'CmbMa_TT
        '
        Me.CmbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TT.FormattingEnabled = True
        Me.CmbMa_TT.Location = New System.Drawing.Point(75, 98)
        Me.CmbMa_TT.Name = "CmbMa_TT"
        Me.CmbMa_TT.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_TT.TabIndex = 4
        '
        'Txtten_TT
        '
        Me.Txtten_TT.BackColor = System.Drawing.Color.White
        Me.Txtten_TT.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_TT.Location = New System.Drawing.Point(21, 136)
        Me.Txtten_TT.Name = "Txtten_TT"
        Me.Txtten_TT.Size = New System.Drawing.Size(49, 20)
        Me.Txtten_TT.TabIndex = 1970
        Me.Txtten_TT.Tag = ""
        Me.Txtten_TT.Visible = False
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(75, 136)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.Size = New System.Drawing.Size(49, 20)
        Me.TxtTen_Kx.TabIndex = 1971
        Me.TxtTen_Kx.Tag = ""
        Me.TxtTen_Kx.Visible = False
        '
        'txtten_Mau
        '
        Me.txtten_Mau.BackColor = System.Drawing.Color.White
        Me.txtten_Mau.ForeColor = System.Drawing.Color.Navy
        Me.txtten_Mau.Location = New System.Drawing.Point(130, 136)
        Me.txtten_Mau.Name = "txtten_Mau"
        Me.txtten_Mau.Size = New System.Drawing.Size(49, 20)
        Me.txtten_Mau.TabIndex = 1972
        Me.txtten_Mau.Tag = ""
        Me.txtten_Mau.Visible = False
        '
        'txtTen_HTTT
        '
        Me.txtTen_HTTT.BackColor = System.Drawing.Color.White
        Me.txtTen_HTTT.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_HTTT.Location = New System.Drawing.Point(185, 139)
        Me.txtTen_HTTT.Name = "txtTen_HTTT"
        Me.txtTen_HTTT.Size = New System.Drawing.Size(49, 20)
        Me.txtTen_HTTT.TabIndex = 1973
        Me.txtTen_HTTT.Tag = ""
        Me.txtTen_HTTT.Visible = False
        '
        'TxtTen_khMua
        '
        Me.TxtTen_khMua.BackColor = System.Drawing.Color.White
        Me.TxtTen_khMua.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khMua.Location = New System.Drawing.Point(240, 136)
        Me.TxtTen_khMua.Name = "TxtTen_khMua"
        Me.TxtTen_khMua.Size = New System.Drawing.Size(49, 20)
        Me.TxtTen_khMua.TabIndex = 1974
        Me.TxtTen_khMua.Tag = ""
        Me.TxtTen_khMua.Visible = False
        '
        'CRQLKHTN_Mua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 185)
        Me.Controls.Add(Me.TxtTen_khMua)
        Me.Controls.Add(Me.txtTen_HTTT)
        Me.Controls.Add(Me.txtten_Mau)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.Txtten_TT)
        Me.Controls.Add(Me.CmbMa_TT)
        Me.Controls.Add(Me.TxtNgay_Gx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.CmbMa_KHMUA)
        Me.Controls.Add(Me.Cmbma_HTTT)
        Me.Controls.Add(Me.CmbMa_Kx)
        Me.Controls.Add(Me.CmbMa_Mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDia_Chi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.TxtNote)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CRQLKHTN_Mua"
        Me.Text = "Giao dịch hàng ngày"
        Me.Controls.SetChildIndex(Me.TxtNote, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.LblDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Cmbma_HTTT, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_KHMUA, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Gx, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Txtten_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.txtten_Mau, 0)
        Me.Controls.SetChildIndex(Me.txtTen_HTTT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khMua, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_Gx As ClsTextBox.txtDate
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_KHMUA As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbma_HTTT As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMa_Kx As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMa_Mau As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDia_Chi As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents CmbMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents Txtten_TT As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents txtten_Mau As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_HTTT As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_khMua As System.Windows.Forms.TextBox

End Class
