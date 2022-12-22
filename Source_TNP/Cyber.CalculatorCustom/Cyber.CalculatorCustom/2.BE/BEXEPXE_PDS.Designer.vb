<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEXEPXE_PDS
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
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.TxtGio_YC = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNgay_YC = New ClsTextBox.txtDate()
        Me.txtTen_Kx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSo_May = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT = New ClsTextBox.txtDate()
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 193)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(885, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(619, 206)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(755, 206)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.BackColor = System.Drawing.Color.White
        Me.TxtGhi_Chu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGhi_Chu.ForeColor = System.Drawing.Color.Red
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(129, 117)
        Me.TxtGhi_Chu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGhi_Chu.Multiline = True
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.ReadOnly = True
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(746, 80)
        Me.TxtGhi_Chu.TabIndex = 1834
        Me.TxtGhi_Chu.TabStop = False
        Me.TxtGhi_Chu.Tag = ""
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(9, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 1833
        Me.Label5.Tag = "Request"
        Me.Label5.Text = "Yêu cầu"
        '
        'txtDien_giai
        '
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(129, 87)
        Me.txtDien_giai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(745, 22)
        Me.txtDien_giai.TabIndex = 1824
        Me.txtDien_giai.Tag = ""
        '
        'TxtGio_YC
        '
        Me.TxtGio_YC.BackColor = System.Drawing.Color.White
        Me.TxtGio_YC.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_YC.Location = New System.Drawing.Point(717, 59)
        Me.TxtGio_YC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGio_YC.Name = "TxtGio_YC"
        Me.TxtGio_YC.Size = New System.Drawing.Size(157, 22)
        Me.TxtGio_YC.TabIndex = 1823
        Me.TxtGio_YC.Tag = ""
        Me.TxtGio_YC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(579, 63)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 18)
        Me.Label16.TabIndex = 1832
        Me.Label16.Tag = "At time"
        Me.Label16.Text = "Giờ làm"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(579, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 1831
        Me.Label3.Tag = "Date PSD"
        Me.Label3.Text = "Ngày làm PDS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNgay_YC
        '
        Me.TxtNgay_YC.BackColor = System.Drawing.Color.White
        Me.TxtNgay_YC.Flags = 65536
        Me.TxtNgay_YC.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_YC.isEmpty = True
        Me.TxtNgay_YC.Location = New System.Drawing.Point(717, 33)
        Me.TxtNgay_YC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_YC.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_YC.MaxLength = 10
        Me.TxtNgay_YC.Name = "TxtNgay_YC"
        Me.TxtNgay_YC.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_YC.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_YC.ShowDayBeforeMonth = False
        Me.TxtNgay_YC.Size = New System.Drawing.Size(157, 22)
        Me.TxtNgay_YC.TabIndex = 1822
        Me.TxtNgay_YC.Text = "18/09/2011"
        Me.TxtNgay_YC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_YC.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'txtTen_Kx
        '
        Me.txtTen_Kx.BackColor = System.Drawing.Color.White
        Me.txtTen_Kx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Kx.Location = New System.Drawing.Point(129, 59)
        Me.txtTen_Kx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTen_Kx.Name = "txtTen_Kx"
        Me.txtTen_Kx.ReadOnly = True
        Me.txtTen_Kx.Size = New System.Drawing.Size(268, 22)
        Me.txtTen_Kx.TabIndex = 1829
        Me.txtTen_Kx.TabStop = False
        Me.txtTen_Kx.Tag = ""
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 1830
        Me.Label2.Tag = "Type car"
        Me.Label2.Text = "Loại xe"
        '
        'TxtSo_May
        '
        Me.TxtSo_May.BackColor = System.Drawing.Color.White
        Me.TxtSo_May.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_May.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_May.Location = New System.Drawing.Point(129, 33)
        Me.TxtSo_May.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_May.Name = "TxtSo_May"
        Me.TxtSo_May.ReadOnly = True
        Me.TxtSo_May.Size = New System.Drawing.Size(268, 22)
        Me.TxtSo_May.TabIndex = 1827
        Me.TxtSo_May.TabStop = False
        Me.TxtSo_May.Tag = ""
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 1828
        Me.Label1.Tag = "Machine number"
        Me.Label1.Text = "Số máy"
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(579, 10)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(131, 17)
        Me.Label19.TabIndex = 1826
        Me.Label19.Tag = "Create date"
        Me.Label19.Text = "Ngày lập"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNgay_CT
        '
        Me.TxtNgay_CT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_CT.Flags = 65536
        Me.TxtNgay_CT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT.isEmpty = True
        Me.TxtNgay_CT.Location = New System.Drawing.Point(717, 6)
        Me.TxtNgay_CT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_CT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT.MaxLength = 10
        Me.TxtNgay_CT.Name = "TxtNgay_CT"
        Me.TxtNgay_CT.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT.ShowDayBeforeMonth = False
        Me.TxtNgay_CT.Size = New System.Drawing.Size(157, 22)
        Me.TxtNgay_CT.TabIndex = 1821
        Me.TxtNgay_CT.Text = "18/09/2011"
        Me.TxtNgay_CT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_CT.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.BackColor = System.Drawing.Color.White
        Me.TxtSo_Khung.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(129, 6)
        Me.TxtSo_Khung.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(268, 22)
        Me.TxtSo_Khung.TabIndex = 1820
        Me.TxtSo_Khung.Tag = ""
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 1825
        Me.Label4.Tag = "Frame number"
        Me.Label4.Text = "Số khung"
        '
        'BEXEPXE_PDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(891, 272)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.TxtGio_YC)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNgay_YC)
        Me.Controls.Add(Me.txtTen_Kx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSo_May)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtNgay_CT)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BEXEPXE_PDS"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_May, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_YC, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_YC, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents TxtGio_YC As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_YC As ClsTextBox.txtDate
    Friend WithEvents txtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_May As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT As ClsTextBox.txtDate
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
