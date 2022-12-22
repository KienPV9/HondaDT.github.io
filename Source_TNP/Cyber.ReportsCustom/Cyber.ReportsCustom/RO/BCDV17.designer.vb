<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCDV17
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
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.Txtten_hs = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 143)
        Me.ButtExit.TabIndex = 6
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(82, 78)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(500, 21)
        Me.CBBMa_Dvcs.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(11, 78)
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.Text = "Đơn vị"
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(384, 143)
        Me.ButtOK.TabIndex = 5
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(14, 123)
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
        Me.CmbThang.TabIndex = 2
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(82, 54)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(129, 20)
        Me.TxtMa_Hs.TabIndex = 3
        Me.TxtMa_Hs.Table_Name = ""
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(9, 57)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(25, 13)
        Me.LabM_Tk.TabIndex = 7186
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "KTV"
        '
        'Txtten_hs
        '
        Me.Txtten_hs.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_hs.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_hs.Location = New System.Drawing.Point(217, 59)
        Me.Txtten_hs.Name = "Txtten_hs"
        Me.Txtten_hs.ReadOnly = True
        Me.Txtten_hs.Size = New System.Drawing.Size(365, 13)
        Me.Txtten_hs.TabIndex = 7187
        Me.Txtten_hs.TabStop = False
        '
        'BCDV17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 185)
        Me.Controls.Add(Me.Txtten_hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.LabM_Tk)
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
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Txtten_hs, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents txtTen_tuyen As Label
    Friend WithEvents Cmbnam As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbThang As ComboBox
    Friend WithEvents TxtMa_Hs As SmLists.TxtLookup
    Friend WithEvents LabM_Tk As Label
    Friend WithEvents Txtten_hs As TextBox
End Class
