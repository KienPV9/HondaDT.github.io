<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BE_THBGPK
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
        Me.TxtMa_PK = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_PK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMa_Nh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_PK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Nh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(486, 116)
        Me.ButtExit.TabIndex = 7
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 80)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 83)
        Me.Label1.TabIndex = 22
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(380, 116)
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 61)
        Me.LabLoai_NT.TabIndex = 21
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 58)
        Me.ChkVND.TabIndex = 11
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(219, 58)
        Me.ChkNT.TabIndex = 12
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 101)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(586, 9)
        Me.GroupBoxLine.TabIndex = 23
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_PK
        '
        Me.TxtMa_PK._ActilookupPopup = False
        Me.TxtMa_PK.CyberActilookupPopup = True
        Me.TxtMa_PK.Dv_ListDetail = Nothing
        Me.TxtMa_PK.Dv_Master = Nothing
        Me.TxtMa_PK.FilterClient = ""
        Me.TxtMa_PK.FilterSQL = ""
        Me.TxtMa_PK.Location = New System.Drawing.Point(95, 27)
        Me.TxtMa_PK.Name = "TxtMa_PK"
        Me.TxtMa_PK.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_PK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_PK.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_PK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_PK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_PK.Size = New System.Drawing.Size(104, 20)
        Me.TxtMa_PK.TabIndex = 3
        Me.TxtMa_PK.Table_Name = ""
        '
        'TxtTen_PK
        '
        Me.TxtTen_PK.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_PK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_PK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_PK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_PK.Location = New System.Drawing.Point(204, 31)
        Me.TxtTen_PK.Name = "TxtTen_PK"
        Me.TxtTen_PK.ReadOnly = True
        Me.TxtTen_PK.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_PK.TabIndex = 10
        Me.TxtTen_PK.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "Department"
        Me.Label4.Text = "Phụ kiện"
        '
        'TxtMa_Nh
        '
        Me.TxtMa_Nh._ActilookupPopup = False
        Me.TxtMa_Nh.CyberActilookupPopup = True
        Me.TxtMa_Nh.Dv_ListDetail = Nothing
        Me.TxtMa_Nh.Dv_Master = Nothing
        Me.TxtMa_Nh.FilterClient = ""
        Me.TxtMa_Nh.FilterSQL = ""
        Me.TxtMa_Nh.Location = New System.Drawing.Point(95, 5)
        Me.TxtMa_Nh.Name = "TxtMa_Nh"
        Me.TxtMa_Nh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Nh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Nh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Nh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Nh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Nh.Size = New System.Drawing.Size(104, 20)
        Me.TxtMa_Nh.TabIndex = 2
        Me.TxtMa_Nh.Table_Name = ""
        '
        'TxtTen_Nh
        '
        Me.TxtTen_Nh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh.Location = New System.Drawing.Point(204, 9)
        Me.TxtTen_Nh.Name = "TxtTen_Nh"
        Me.TxtTen_Nh.ReadOnly = True
        Me.TxtTen_Nh.Size = New System.Drawing.Size(385, 13)
        Me.TxtTen_Nh.TabIndex = 8
        Me.TxtTen_Nh.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "Sale"
        Me.Label5.Text = "Nhóm PK"
        '
        'BE_THBGPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(593, 171)
        Me.Controls.Add(Me.TxtMa_PK)
        Me.Controls.Add(Me.TxtTen_PK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_Nh)
        Me.Controls.Add(Me.TxtTen_Nh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BE_THBGPK"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Nh, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_PK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_PK, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_PK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Nh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_PK As SmLists.TxtLookup
    Friend WithEvents TxtTen_PK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMa_Nh As SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh As TextBox
    Friend WithEvents Label5 As Label
End Class
