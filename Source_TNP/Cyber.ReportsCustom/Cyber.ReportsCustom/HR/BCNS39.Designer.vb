<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCNS39
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
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtMa_Cty = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Cty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkIs_Nghi = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Cty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 165)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 126)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 129)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 165)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 104)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 104)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 105)
        Me.ChkNT.TabIndex = 6
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(110, 9)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 0
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(24, 12)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 148)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_Cty
        '
        Me.TxtMa_Cty._ActilookupPopup = False
        Me.TxtMa_Cty.CyberActilookupPopup = True
        Me.TxtMa_Cty.Dv_ListDetail = Nothing
        Me.TxtMa_Cty.Dv_Master = Nothing
        Me.TxtMa_Cty.FilterClient = ""
        Me.TxtMa_Cty.FilterSQL = ""
        Me.TxtMa_Cty.Location = New System.Drawing.Point(110, 33)
        Me.TxtMa_Cty.Name = "TxtMa_Cty"
        Me.TxtMa_Cty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Cty.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cty.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Cty.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cty.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cty.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Cty.TabIndex = 1
        Me.TxtMa_Cty.Table_Name = ""
        '
        'TxtTen_Cty
        '
        Me.TxtTen_Cty.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Cty.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cty.Location = New System.Drawing.Point(228, 37)
        Me.TxtTen_Cty.Name = "TxtTen_Cty"
        Me.TxtTen_Cty.ReadOnly = True
        Me.TxtTen_Cty.Size = New System.Drawing.Size(363, 13)
        Me.TxtTen_Cty.TabIndex = 148
        Me.TxtTen_Cty.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Công ty"
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(110, 56)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_BP.TabIndex = 2
        Me.TxtMa_BP.Table_Name = ""
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(227, 60)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(363, 13)
        Me.TxtTen_BP.TabIndex = 154
        Me.TxtTen_BP.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Tag = "Customer"
        Me.Label3.Text = "Bộ phận"
        '
        'ChkIs_Nghi
        '
        Me.ChkIs_Nghi.AutoSize = True
        Me.ChkIs_Nghi.Location = New System.Drawing.Point(110, 81)
        Me.ChkIs_Nghi.Name = "ChkIs_Nghi"
        Me.ChkIs_Nghi.Size = New System.Drawing.Size(153, 17)
        Me.ChkIs_Nghi.TabIndex = 3
        Me.ChkIs_Nghi.Text = "Lấy nhân viên đã nghỉ việc"
        Me.ChkIs_Nghi.UseVisualStyleBackColor = True
        '
        'BCNS39
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 218)
        Me.Controls.Add(Me.ChkIs_Nghi)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_Cty)
        Me.Controls.Add(Me.TxtTen_Cty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Name = "BCNS39"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cty, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cty, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Nghi, 0)
        CType(Me.TxtMa_Cty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_Cty As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Cty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_BP As SmLists.TxtLookup
    Friend WithEvents TxtTen_BP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkIs_Nghi As CheckBox
End Class
