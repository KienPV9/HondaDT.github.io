<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMSK
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.TxtMa_Sk = New System.Windows.Forms.TextBox()
        Me.TxtTen_Sk = New System.Windows.Forms.TextBox()
        Me.LabTen_TD1 = New System.Windows.Forms.Label()
        Me.TxtTen_Sk2 = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTien_Du_Tru = New ClsTextBox.txtTien_NT()
        Me.TxtNoi_Dung = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDia_Diem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtThoi_Gian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 186)
        Me.ButtExit.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 186)
        Me.ButtOK.TabIndex = 9
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 192)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 196)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 176)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 8)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(94, 18)
        Me.LabMa_TD1.TabIndex = 9
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã sự kiện"
        '
        'TxtMa_Sk
        '
        Me.TxtMa_Sk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Sk.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Sk.Location = New System.Drawing.Point(110, 7)
        Me.TxtMa_Sk.Name = "TxtMa_Sk"
        Me.TxtMa_Sk.Size = New System.Drawing.Size(120, 21)
        Me.TxtMa_Sk.TabIndex = 0
        '
        'TxtTen_Sk
        '
        Me.TxtTen_Sk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Sk.Location = New System.Drawing.Point(110, 30)
        Me.TxtTen_Sk.Name = "TxtTen_Sk"
        Me.TxtTen_Sk.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Sk.TabIndex = 1
        '
        'LabTen_TD1
        '
        Me.LabTen_TD1.Location = New System.Drawing.Point(7, 32)
        Me.LabTen_TD1.Name = "LabTen_TD1"
        Me.LabTen_TD1.Size = New System.Drawing.Size(94, 16)
        Me.LabTen_TD1.TabIndex = 8
        Me.LabTen_TD1.Tag = "Name"
        Me.LabTen_TD1.Text = "Tên sự kiện"
        '
        'TxtTen_Sk2
        '
        Me.TxtTen_Sk2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Sk2.Location = New System.Drawing.Point(110, 53)
        Me.TxtTen_Sk2.Name = "TxtTen_Sk2"
        Me.TxtTen_Sk2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Sk2.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(7, 54)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(94, 17)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "English name"
        Me.Labten_TD12.Text = "Tên tiếng anh"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 14)
        Me.Label8.TabIndex = 2181
        Me.Label8.Tag = "Total"
        Me.Label8.Text = "Dự trù CP"
        '
        'TxtTien_Du_Tru
        '
        Me.TxtTien_Du_Tru.AllowNegative = True
        Me.TxtTien_Du_Tru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTien_Du_Tru.BackColor = System.Drawing.Color.White
        Me.TxtTien_Du_Tru.Flags = 7680
        Me.TxtTien_Du_Tru.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_Du_Tru.InputMask = "### ### ### ###"
        Me.TxtTien_Du_Tru.Location = New System.Drawing.Point(111, 144)
        Me.TxtTien_Du_Tru.MaxWholeDigits = 11
        Me.TxtTien_Du_Tru.Name = "TxtTien_Du_Tru"
        Me.TxtTien_Du_Tru.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_Du_Tru.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_Du_Tru.ReadOnly = True
        Me.TxtTien_Du_Tru.Size = New System.Drawing.Size(119, 21)
        Me.TxtTien_Du_Tru.TabIndex = 6
        Me.TxtTien_Du_Tru.Text = "1"
        Me.TxtTien_Du_Tru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNoi_Dung
        '
        Me.TxtNoi_Dung.BackColor = System.Drawing.Color.White
        Me.TxtNoi_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNoi_Dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtNoi_Dung.Location = New System.Drawing.Point(111, 122)
        Me.TxtNoi_Dung.Name = "TxtNoi_Dung"
        Me.TxtNoi_Dung.Size = New System.Drawing.Size(670, 20)
        Me.TxtNoi_Dung.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 2180
        Me.Label7.Tag = "Reason"
        Me.Label7.Text = "Nội dung"
        '
        'TxtDia_Diem
        '
        Me.TxtDia_Diem.BackColor = System.Drawing.Color.White
        Me.TxtDia_Diem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDia_Diem.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Diem.Location = New System.Drawing.Point(110, 99)
        Me.TxtDia_Diem.Name = "TxtDia_Diem"
        Me.TxtDia_Diem.Size = New System.Drawing.Size(671, 20)
        Me.TxtDia_Diem.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(7, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 2179
        Me.Label6.Tag = "Reason"
        Me.Label6.Text = "Địa điểm"
        '
        'TxtThoi_Gian
        '
        Me.TxtThoi_Gian.BackColor = System.Drawing.Color.White
        Me.TxtThoi_Gian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtThoi_Gian.ForeColor = System.Drawing.Color.Navy
        Me.TxtThoi_Gian.Location = New System.Drawing.Point(110, 77)
        Me.TxtThoi_Gian.Name = "TxtThoi_Gian"
        Me.TxtThoi_Gian.Size = New System.Drawing.Size(671, 20)
        Me.TxtThoi_Gian.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(7, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 2178
        Me.Label4.Tag = "Reason"
        Me.Label4.Text = "Thời gian"
        '
        'DMSK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 241)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTien_Du_Tru)
        Me.Controls.Add(Me.TxtNoi_Dung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDia_Diem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtThoi_Gian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Sk2)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.TxtTen_Sk)
        Me.Controls.Add(Me.LabTen_TD1)
        Me.Controls.Add(Me.TxtMa_Sk)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMSK"
        Me.Text = "Danh mục nguồn vốn"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Sk, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Sk, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Sk2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtThoi_Gian, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_Diem, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_Du_Tru, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Sk As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Sk As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Sk2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtTien_Du_Tru As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNoi_Dung As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtDia_Diem As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtThoi_Gian As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
