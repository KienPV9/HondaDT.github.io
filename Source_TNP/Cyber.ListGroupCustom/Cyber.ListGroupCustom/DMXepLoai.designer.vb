<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMXepLoai
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
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.TxtTen_xeploai = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_XepLoai = New System.Windows.Forms.TextBox()
        Me.Txtdiem = New ClsTextBox.txtTien_NT()
        Me.ChkNgam_dinh = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(423, 111)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(321, 111)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(215, 117)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(42, 116)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.Size = New System.Drawing.Size(521, 9)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 6)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã xếp loại"
        '
        'TxtTen_xeploai
        '
        Me.TxtTen_xeploai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_xeploai.Location = New System.Drawing.Point(110, 30)
        Me.TxtTen_xeploai.Name = "TxtTen_xeploai"
        Me.TxtTen_xeploai.Size = New System.Drawing.Size(410, 21)
        Me.TxtTen_xeploai.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 32)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên xếp loại"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "Điểm"
        '
        'TxtMa_XepLoai
        '
        Me.TxtMa_XepLoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_XepLoai.Location = New System.Drawing.Point(110, 6)
        Me.TxtMa_XepLoai.Name = "TxtMa_XepLoai"
        Me.TxtMa_XepLoai.Size = New System.Drawing.Size(163, 21)
        Me.TxtMa_XepLoai.TabIndex = 0
        '
        'Txtdiem
        '
        Me.Txtdiem.AllowNegative = True
        Me.Txtdiem.BackColor = System.Drawing.Color.White
        Me.Txtdiem.Flags = 7680
        Me.Txtdiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdiem.ForeColor = System.Drawing.Color.Navy
        Me.Txtdiem.InputMask = "########"
        Me.Txtdiem.Location = New System.Drawing.Point(110, 54)
        Me.Txtdiem.MaxWholeDigits = 7
        Me.Txtdiem.Name = "Txtdiem"
        Me.Txtdiem.RangeMax = 1.7976931348623157E+308R
        Me.Txtdiem.RangeMin = -1.7976931348623157E+308R
        Me.Txtdiem.Size = New System.Drawing.Size(110, 20)
        Me.Txtdiem.TabIndex = 2
        Me.Txtdiem.TabStop = False
        Me.Txtdiem.Text = "0"
        Me.Txtdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkNgam_dinh
        '
        Me.ChkNgam_dinh.AutoSize = True
        Me.ChkNgam_dinh.Location = New System.Drawing.Point(110, 79)
        Me.ChkNgam_dinh.Name = "ChkNgam_dinh"
        Me.ChkNgam_dinh.Size = New System.Drawing.Size(76, 17)
        Me.ChkNgam_dinh.TabIndex = 3
        Me.ChkNgam_dinh.Text = "Ngầm định"
        Me.ChkNgam_dinh.UseVisualStyleBackColor = True
        '
        'DMXepLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 144)
        Me.Controls.Add(Me.ChkNgam_dinh)
        Me.Controls.Add(Me.Txtdiem)
        Me.Controls.Add(Me.TxtMa_XepLoai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_xeploai)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMXepLoai"
        Me.Text = "Danh mục chỉ tiêu KPI"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_xeploai, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_XepLoai, 0)
        Me.Controls.SetChildIndex(Me.Txtdiem, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_dinh, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_xeploai As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_XepLoai As Windows.Forms.TextBox
    Friend WithEvents Txtdiem As ClsTextBox.txtTien_NT
    Friend WithEvents ChkNgam_dinh As Windows.Forms.CheckBox
End Class
