<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRQLKHTN_Ban
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTien_ban = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnam_Sx = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CmbMa_Kx = New System.Windows.Forms.ComboBox()
        Me.CmbMa_Mau = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbMa_TT = New System.Windows.Forms.ComboBox()
        Me.LblDia_Chi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_TT = New System.Windows.Forms.TextBox()
        Me.txtten_Mau = New System.Windows.Forms.TextBox()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.Txtten_TT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 134)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(572, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(372, 144)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(474, 144)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(361, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 1970
        Me.Label3.Tag = "Price"
        Me.Label3.Text = "Giá bán"
        '
        'TxtTien_ban
        '
        Me.TxtTien_ban.AllowNegative = True
        Me.TxtTien_ban.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_ban.BackColor = System.Drawing.Color.White
        Me.TxtTien_ban.Flags = 7680
        Me.TxtTien_ban.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_ban.InputMask = "## ### ### ### ### ###"
        Me.TxtTien_ban.Location = New System.Drawing.Point(441, 77)
        Me.TxtTien_ban.MaxWholeDigits = 16
        Me.TxtTien_ban.Name = "TxtTien_ban"
        Me.TxtTien_ban.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_ban.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_ban.Size = New System.Drawing.Size(133, 20)
        Me.TxtTien_ban.TabIndex = 6
        Me.TxtTien_ban.Text = "0"
        Me.TxtTien_ban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(361, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 1969
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm sản xuất"
        '
        'Txtnam_Sx
        '
        Me.Txtnam_Sx.BackColor = System.Drawing.Color.White
        Me.Txtnam_Sx.ForeColor = System.Drawing.Color.Navy
        Me.Txtnam_Sx.Location = New System.Drawing.Point(441, 54)
        Me.Txtnam_Sx.Name = "Txtnam_Sx"
        Me.Txtnam_Sx.Size = New System.Drawing.Size(133, 20)
        Me.Txtnam_Sx.TabIndex = 5
        Me.Txtnam_Sx.Tag = ""
        '
        'Label27
        '
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(7, 79)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 16)
        Me.Label27.TabIndex = 1968
        Me.Label27.Tag = "Colour"
        Me.Label27.Text = "Màu xe"
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 56)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 16)
        Me.Label26.TabIndex = 1967
        Me.Label26.Tag = "Model car"
        Me.Label26.Text = "Loại xe"
        '
        'CmbMa_Kx
        '
        Me.CmbMa_Kx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Kx.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Kx.FormattingEnabled = True
        Me.CmbMa_Kx.Location = New System.Drawing.Point(79, 54)
        Me.CmbMa_Kx.Name = "CmbMa_Kx"
        Me.CmbMa_Kx.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_Kx.TabIndex = 2
        '
        'CmbMa_Mau
        '
        Me.CmbMa_Mau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Mau.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Mau.FormattingEnabled = True
        Me.CmbMa_Mau.Location = New System.Drawing.Point(79, 77)
        Me.CmbMa_Mau.Name = "CmbMa_Mau"
        Me.CmbMa_Mau.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_Mau.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 1966
        Me.Label1.Tag = "Result"
        Me.Label1.Text = "Kết quả"
        '
        'CmbMa_TT
        '
        Me.CmbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TT.FormattingEnabled = True
        Me.CmbMa_TT.Location = New System.Drawing.Point(79, 100)
        Me.CmbMa_TT.Name = "CmbMa_TT"
        Me.CmbMa_TT.Size = New System.Drawing.Size(189, 21)
        Me.CmbMa_TT.TabIndex = 4
        '
        'LblDia_Chi
        '
        Me.LblDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LblDia_Chi.Location = New System.Drawing.Point(7, 37)
        Me.LblDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDia_Chi.Name = "LblDia_Chi"
        Me.LblDia_Chi.Size = New System.Drawing.Size(67, 15)
        Me.LblDia_Chi.TabIndex = 1965
        Me.LblDia_Chi.Tag = "Note"
        Me.LblDia_Chi.Text = "Ghi chú"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(7, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 1964
        Me.Label5.Tag = "Content"
        Me.Label5.Text = "Nội dung"
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.BackColor = System.Drawing.Color.White
        Me.TxtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(79, 31)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(495, 20)
        Me.TxtGhi_Chu.TabIndex = 1
        Me.TxtGhi_Chu.Tag = ""
        '
        'TxtNote
        '
        Me.TxtNote.BackColor = System.Drawing.Color.White
        Me.TxtNote.ForeColor = System.Drawing.Color.Navy
        Me.TxtNote.Location = New System.Drawing.Point(79, 9)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(495, 20)
        Me.TxtNote.TabIndex = 0
        Me.TxtNote.Tag = ""
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Location = New System.Drawing.Point(59, 148)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Size = New System.Drawing.Size(70, 20)
        Me.TxtMa_kx.TabIndex = 1971
        Me.TxtMa_kx.Tag = ""
        Me.TxtMa_kx.Visible = False
        '
        'TxtMa_mau
        '
        Me.TxtMa_mau.BackColor = System.Drawing.Color.White
        Me.TxtMa_mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Location = New System.Drawing.Point(150, 148)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Size = New System.Drawing.Size(70, 20)
        Me.TxtMa_mau.TabIndex = 1972
        Me.TxtMa_mau.Tag = ""
        Me.TxtMa_mau.Visible = False
        '
        'TxtMa_TT
        '
        Me.TxtMa_TT.BackColor = System.Drawing.Color.White
        Me.TxtMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TT.Location = New System.Drawing.Point(237, 149)
        Me.TxtMa_TT.Name = "TxtMa_TT"
        Me.TxtMa_TT.Size = New System.Drawing.Size(70, 20)
        Me.TxtMa_TT.TabIndex = 1973
        Me.TxtMa_TT.Tag = ""
        Me.TxtMa_TT.Visible = False
        '
        'txtten_Mau
        '
        Me.txtten_Mau.BackColor = System.Drawing.Color.White
        Me.txtten_Mau.ForeColor = System.Drawing.Color.Navy
        Me.txtten_Mau.Location = New System.Drawing.Point(301, 149)
        Me.txtten_Mau.Name = "txtten_Mau"
        Me.txtten_Mau.Size = New System.Drawing.Size(49, 20)
        Me.txtten_Mau.TabIndex = 1976
        Me.txtten_Mau.Tag = ""
        Me.txtten_Mau.Visible = False
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(246, 149)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.Size = New System.Drawing.Size(49, 20)
        Me.TxtTen_Kx.TabIndex = 1975
        Me.TxtTen_Kx.Tag = ""
        Me.TxtTen_Kx.Visible = False
        '
        'Txtten_TT
        '
        Me.Txtten_TT.BackColor = System.Drawing.Color.White
        Me.Txtten_TT.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_TT.Location = New System.Drawing.Point(192, 149)
        Me.Txtten_TT.Name = "Txtten_TT"
        Me.Txtten_TT.Size = New System.Drawing.Size(49, 20)
        Me.Txtten_TT.TabIndex = 1974
        Me.Txtten_TT.Tag = ""
        Me.Txtten_TT.Visible = False
        '
        'CRQLKHTN_Ban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 198)
        Me.Controls.Add(Me.txtten_Mau)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.Txtten_TT)
        Me.Controls.Add(Me.TxtMa_TT)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTien_ban)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnam_Sx)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.CmbMa_Kx)
        Me.Controls.Add(Me.CmbMa_Mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMa_TT)
        Me.Controls.Add(Me.LblDia_Chi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.TxtNote)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CRQLKHTN_Ban"
        Me.Text = "Giao dịch hàng ngày"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNote, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.LblDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Txtnam_Sx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_ban, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Txtten_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.txtten_Mau, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_ban As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtnam_Sx As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_Kx As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMa_Mau As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents LblDia_Chi As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TT As System.Windows.Forms.TextBox
    Friend WithEvents txtten_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_TT As System.Windows.Forms.TextBox

End Class
