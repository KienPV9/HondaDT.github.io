﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BCDV88

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
        Me.CmdThang = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 127)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(82, 62)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(498, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.Text = "Đơn vị"
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(384, 127)
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabLoai_NT.Location = New System.Drawing.Point(7, 89)
        Me.LabLoai_NT.Size = New System.Drawing.Size(69, 16)
        '
        'ChkVND
        '
        Me.ChkVND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkVND.Location = New System.Drawing.Point(80, 89)
        Me.ChkVND.TabIndex = 9
        '
        'ChkNT
        '
        Me.ChkNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkNT.Location = New System.Drawing.Point(185, 88)
        Me.ChkNT.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(12, 111)
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
        Me.Cmbnam.Location = New System.Drawing.Point(82, 13)
        Me.Cmbnam.Name = "Cmbnam"
        Me.Cmbnam.Size = New System.Drawing.Size(112, 21)
        Me.Cmbnam.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 7182
        Me.Label6.Text = "Năm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7184
        Me.Label2.Text = "Tháng"
        '
        'CmdThang
        '
        Me.CmdThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdThang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmdThang.ForeColor = System.Drawing.Color.Navy
        Me.CmdThang.FormattingEnabled = True
        Me.CmdThang.Location = New System.Drawing.Point(82, 37)
        Me.CmdThang.Name = "CmdThang"
        Me.CmdThang.Size = New System.Drawing.Size(112, 21)
        Me.CmdThang.TabIndex = 7183
        '
        'BCDV88
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 169)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdThang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmbnam)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "BCDV88"
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
        Me.Controls.SetChildIndex(Me.CmdThang, 0)
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
    Friend WithEvents CmdThang As ComboBox
End Class