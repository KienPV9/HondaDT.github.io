<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BE_KHTN_TK
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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNh_Hs1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.LabM_Thang = New System.Windows.Forms.Label()
        CType(Me.TxtNh_Hs1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 127)
        Me.ButtExit.TabIndex = 6
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 88)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 91)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 127)
        Me.ButtOK.TabIndex = 5
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 69)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 66)
        Me.ChkVND.TabIndex = 3
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(219, 66)
        Me.ChkNT.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 110)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(95, 11)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(114, 21)
        Me.CbbM_Nam.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'TxtNh_Hs1
        '
        Me.TxtNh_Hs1._ActilookupPopup = False
        Me.TxtNh_Hs1.CyberActilookupPopup = True
        Me.TxtNh_Hs1.Dv_ListDetail = Nothing
        Me.TxtNh_Hs1.Dv_Master = Nothing
        Me.TxtNh_Hs1.FilterClient = ""
        Me.TxtNh_Hs1.FilterSQL = ""
        Me.TxtNh_Hs1.Location = New System.Drawing.Point(95, 36)
        Me.TxtNh_Hs1.Name = "TxtNh_Hs1"
        Me.TxtNh_Hs1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNh_Hs1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Hs1.Properties.Appearance.Options.UseFont = True
        Me.TxtNh_Hs1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Hs1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Hs1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Hs1.TabIndex = 2
        Me.TxtNh_Hs1.Table_Name = ""
        '
        'TxtTen_Nh
        '
        Me.TxtTen_Nh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh.Location = New System.Drawing.Point(212, 40)
        Me.TxtTen_Nh.Name = "TxtTen_Nh"
        Me.TxtTen_Nh.ReadOnly = True
        Me.TxtTen_Nh.Size = New System.Drawing.Size(363, 13)
        Me.TxtTen_Nh.TabIndex = 151
        Me.TxtTen_Nh.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 150
        Me.Label3.Tag = "Customer"
        Me.Label3.Text = "Nhóm hồ sơ 1"
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(308, 12)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Thang.TabIndex = 1
        '
        'LabM_Thang
        '
        Me.LabM_Thang.AutoSize = True
        Me.LabM_Thang.Location = New System.Drawing.Point(223, 15)
        Me.LabM_Thang.Name = "LabM_Thang"
        Me.LabM_Thang.Size = New System.Drawing.Size(37, 13)
        Me.LabM_Thang.TabIndex = 153
        Me.LabM_Thang.Tag = "Month"
        Me.LabM_Thang.Text = "Tháng"
        '
        'BE_KHTN_TK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 180)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.LabM_Thang)
        Me.Controls.Add(Me.TxtNh_Hs1)
        Me.Controls.Add(Me.TxtTen_Nh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Name = "BE_KHTN_TK"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Hs1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Thang, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        CType(Me.TxtNh_Hs1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_Hs1 As SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbbM_Thang As ComboBox
    Friend WithEvents LabM_Thang As Label
End Class
