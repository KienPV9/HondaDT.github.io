<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCPTSLThang
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
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(482, 102)
        Me.ButtExit.TabIndex = 5
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(82, 50)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(500, 21)
        Me.CBBMa_Dvcs.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.Text = "Đơn vị"
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(363, 102)
        Me.ButtOK.TabIndex = 4
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabLoai_NT.Location = New System.Drawing.Point(14, 122)
        Me.LabLoai_NT.Visible = False
        '
        'ChkVND
        '
        Me.ChkVND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkVND.Location = New System.Drawing.Point(99, 121)
        Me.ChkVND.TabIndex = 9
        Me.ChkVND.Visible = False
        '
        'ChkNT
        '
        Me.ChkNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkNT.Location = New System.Drawing.Point(209, 121)
        Me.ChkNT.TabIndex = 10
        Me.ChkNT.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 77)
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
        Me.Cmbnam.Location = New System.Drawing.Point(82, 22)
        Me.Cmbnam.Name = "Cmbnam"
        Me.Cmbnam.Size = New System.Drawing.Size(134, 21)
        Me.Cmbnam.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 7182
        Me.Label6.Text = "Năm"
        '
        'BCPTSLThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 158)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmbnam)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BCPTSLThang"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents txtTen_tuyen As Label
    Friend WithEvents txtten_hs As Label
    Friend WithEvents Cmbnam As ComboBox
    Friend WithEvents Label6 As Label
End Class
