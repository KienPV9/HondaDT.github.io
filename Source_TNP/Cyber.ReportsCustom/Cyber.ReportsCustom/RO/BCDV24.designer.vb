<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCDV24
    Inherits Cyber.From.FilterReport

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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Cmbnam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbThang = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 107)
        Me.ButtExit.TabIndex = 4
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(82, 56)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(500, 21)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.Text = "Đơn vị"
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(384, 107)
        Me.ButtOK.TabIndex = 3
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabLoai_NT.Location = New System.Drawing.Point(25, 106)
        '
        'ChkVND
        '
        Me.ChkVND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkVND.Location = New System.Drawing.Point(110, 105)
        Me.ChkVND.TabIndex = 9
        '
        'ChkNT
        '
        Me.ChkNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkNT.Location = New System.Drawing.Point(220, 105)
        Me.ChkNT.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(14, 87)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 17
        Me.GroupBoxLine.TabStop = False
        '
        'Cmbnam
        '
        Me.Cmbnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbnam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Cmbnam.ForeColor = System.Drawing.Color.Navy
        Me.Cmbnam.FormattingEnabled = True
        Me.Cmbnam.Location = New System.Drawing.Point(82, 7)
        Me.Cmbnam.Name = "Cmbnam"
        Me.Cmbnam.Size = New System.Drawing.Size(129, 21)
        Me.Cmbnam.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 7182
        Me.Label6.Text = "Năm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7184
        Me.Label2.Text = "Tháng"
        '
        'CmbThang
        '
        Me.CmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbThang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbThang.ForeColor = System.Drawing.Color.Navy
        Me.CmbThang.FormattingEnabled = True
        Me.CmbThang.Location = New System.Drawing.Point(82, 31)
        Me.CmbThang.Name = "CmbThang"
        Me.CmbThang.Size = New System.Drawing.Size(129, 21)
        Me.CmbThang.TabIndex = 1
        '
        'BCDV17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 149)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbThang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmbnam)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BCDV17"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Cmbnam, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CmbThang, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents txtTen_tuyen As Label
    Friend WithEvents txtten_hs As Label
    Friend WithEvents Cmbnam As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbThang As ComboBox
End Class
