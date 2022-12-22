<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMDGNV
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
        Me.TxtTen_Chitieu = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.Txtghi_chu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_Chitieu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtdiem = New ClsTextBox.txtTien_NT()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbMa_ND = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbMa_nhom = New System.Windows.Forms.ComboBox()
        Me.TxtTen_ND = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(626, 154)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(524, 154)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(418, 160)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 164)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 144)
        Me.GroupBoxLine.Size = New System.Drawing.Size(724, 9)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 52)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã Chỉ tiêu"
        '
        'TxtTen_Chitieu
        '
        Me.TxtTen_Chitieu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Chitieu.Location = New System.Drawing.Point(110, 74)
        Me.TxtTen_Chitieu.Name = "TxtTen_Chitieu"
        Me.TxtTen_Chitieu.Size = New System.Drawing.Size(614, 21)
        Me.TxtTen_Chitieu.TabIndex = 3
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 76)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên Chỉ tiêu"
        '
        'Txtghi_chu
        '
        Me.Txtghi_chu.ForeColor = System.Drawing.Color.Navy
        Me.Txtghi_chu.Location = New System.Drawing.Point(110, 118)
        Me.Txtghi_chu.Name = "Txtghi_chu"
        Me.Txtghi_chu.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtghi_chu.Size = New System.Drawing.Size(614, 21)
        Me.Txtghi_chu.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Ghi chú"
        '
        'TxtMa_Chitieu
        '
        Me.TxtMa_Chitieu.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Chitieu.Location = New System.Drawing.Point(110, 52)
        Me.TxtMa_Chitieu.Name = "TxtMa_Chitieu"
        Me.TxtMa_Chitieu.Size = New System.Drawing.Size(163, 21)
        Me.TxtMa_Chitieu.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Tag = "English name"
        Me.Label4.Text = "Điểm chuẩn ĐG"
        '
        'Txtdiem
        '
        Me.Txtdiem.AllowNegative = True
        Me.Txtdiem.BackColor = System.Drawing.Color.White
        Me.Txtdiem.Flags = 7680
        Me.Txtdiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdiem.ForeColor = System.Drawing.Color.Navy
        Me.Txtdiem.InputMask = "########"
        Me.Txtdiem.Location = New System.Drawing.Point(110, 96)
        Me.Txtdiem.MaxWholeDigits = 7
        Me.Txtdiem.Name = "Txtdiem"
        Me.Txtdiem.RangeMax = 1.7976931348623157E+308R
        Me.Txtdiem.RangeMin = -1.7976931348623157E+308R
        Me.Txtdiem.Size = New System.Drawing.Size(163, 20)
        Me.Txtdiem.TabIndex = 4
        Me.Txtdiem.TabStop = False
        Me.Txtdiem.Text = "0"
        Me.Txtdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Tag = "English name"
        Me.Label6.Text = "Nội dung ĐG"
        '
        'CmbMa_ND
        '
        Me.CmbMa_ND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_ND.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbMa_ND.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_ND.FormattingEnabled = True
        Me.CmbMa_ND.Location = New System.Drawing.Point(110, 29)
        Me.CmbMa_ND.Name = "CmbMa_ND"
        Me.CmbMa_ND.Size = New System.Drawing.Size(163, 21)
        Me.CmbMa_ND.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Tag = "English name"
        Me.Label7.Text = "Đối tượng"
        '
        'CmbMa_nhom
        '
        Me.CmbMa_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_nhom.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbMa_nhom.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_nhom.FormattingEnabled = True
        Me.CmbMa_nhom.Location = New System.Drawing.Point(110, 6)
        Me.CmbMa_nhom.Name = "CmbMa_nhom"
        Me.CmbMa_nhom.Size = New System.Drawing.Size(163, 21)
        Me.CmbMa_nhom.TabIndex = 0
        '
        'TxtTen_ND
        '
        Me.TxtTen_ND.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ND.Location = New System.Drawing.Point(279, 32)
        Me.TxtTen_ND.Name = "TxtTen_ND"
        Me.TxtTen_ND.Size = New System.Drawing.Size(163, 21)
        Me.TxtTen_ND.TabIndex = 52
        Me.TxtTen_ND.Visible = False
        '
        'DMDGNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 187)
        Me.Controls.Add(Me.TxtTen_ND)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbMa_ND)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbMa_nhom)
        Me.Controls.Add(Me.Txtdiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_Chitieu)
        Me.Controls.Add(Me.Txtghi_chu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Chitieu)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMDGNV"
        Me.Text = "Danh mục chỉ tiêu KPI"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Chitieu, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Txtghi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Chitieu, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Txtdiem, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_nhom, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_ND, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ND, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Chitieu As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents Txtghi_chu As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtMa_Chitieu As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txtdiem As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents CmbMa_ND As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents CmbMa_nhom As Windows.Forms.ComboBox
    Friend WithEvents TxtTen_ND As Windows.Forms.TextBox
End Class
