<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BEKH11
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 166)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 127)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 130)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 166)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 108)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 105)
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 105)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 9)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 30)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 12)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 38)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 149)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(95, 55)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_HS.TabIndex = 3
        Me.TxtMa_HS.Table_Name = ""
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(213, 59)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(377, 13)
        Me.TxtTen_HS.TabIndex = 4
        Me.TxtTen_HS.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Tag = "Sale"
        Me.Label5.Text = "TVBH"
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(95, 78)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_BP.TabIndex = 5
        Me.TxtMa_BP.Table_Name = ""
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(213, 82)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(377, 13)
        Me.TxtTen_BP.TabIndex = 6
        Me.TxtTen_BP.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Tag = "Sale"
        Me.Label2.Text = "Bộ phận"
        '
        'BEKH11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 219)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "BEKH11"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_HS As SmLists.TxtLookup
    Friend WithEvents TxtTen_HS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMa_BP As SmLists.TxtLookup
    Friend WithEvents TxtTen_BP As TextBox
    Friend WithEvents Label2 As Label
End Class
