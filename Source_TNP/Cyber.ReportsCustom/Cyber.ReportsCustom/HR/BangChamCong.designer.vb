<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BangChamCong
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_bp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(486, 127)
        Me.ButtExit.TabIndex = 7
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 90)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 93)
        Me.Label1.TabIndex = 22
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(380, 127)
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 71)
        Me.LabLoai_NT.TabIndex = 21
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 68)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(219, 68)
        Me.ChkNT.TabIndex = 12
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(10, 14)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(37, 13)
        Me.LabM_month1.TabIndex = 16
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Tháng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 112)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(586, 9)
        Me.GroupBoxLine.TabIndex = 23
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(95, 9)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(104, 21)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(281, 9)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Nam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'TxtMa_bp
        '
        Me.TxtMa_bp._ActilookupPopup = False
        Me.TxtMa_bp.CyberActilookupPopup = True
        Me.TxtMa_bp.Dv_ListDetail = Nothing
        Me.TxtMa_bp.Dv_Master = Nothing
        Me.TxtMa_bp.FilterClient = ""
        Me.TxtMa_bp.FilterSQL = ""
        Me.TxtMa_bp.Location = New System.Drawing.Point(95, 33)
        Me.TxtMa_bp.Name = "TxtMa_bp"
        Me.TxtMa_bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_bp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_bp.Size = New System.Drawing.Size(104, 20)
        Me.TxtMa_bp.TabIndex = 3
        Me.TxtMa_bp.Table_Name = ""
        '
        'TxtTen_bp
        '
        Me.TxtTen_bp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_bp.Location = New System.Drawing.Point(204, 37)
        Me.TxtTen_bp.Name = "TxtTen_bp"
        Me.TxtTen_bp.ReadOnly = True
        Me.TxtTen_bp.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_bp.TabIndex = 10
        Me.TxtTen_bp.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "Department"
        Me.Label4.Text = "Phòng ban"
        '
        'BangChamCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(593, 182)
        Me.Controls.Add(Me.TxtMa_bp)
        Me.Controls.Add(Me.TxtTen_bp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BangChamCong"
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_bp, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_bp As SmLists.TxtLookup
    Friend WithEvents TxtTen_bp As TextBox
    Friend WithEvents Label4 As Label
End Class
