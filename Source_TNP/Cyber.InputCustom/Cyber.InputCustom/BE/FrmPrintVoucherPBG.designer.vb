<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintVoucherPBG
    Inherits Cyber.From.FrmPrintVoucher

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
        Me.CbbSttRec0 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(480, 143)
        '
        'CmdPriview
        '
        Me.CmdPriview.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPriview.Appearance.Options.UseForeColor = True
        Me.CmdPriview.Location = New System.Drawing.Point(387, 143)
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(293, 143)
        '
        'CmdModify
        '
        Me.CmdModify.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdModify.Appearance.Options.UseForeColor = True
        Me.CmdModify.Location = New System.Drawing.Point(2, 142)
        '
        'CbbSttRec0
        '
        Me.CbbSttRec0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbSttRec0.ForeColor = System.Drawing.Color.Navy
        Me.CbbSttRec0.FormattingEnabled = True
        Me.CbbSttRec0.Location = New System.Drawing.Point(135, 89)
        Me.CbbSttRec0.Name = "CbbSttRec0"
        Me.CbbSttRec0.Size = New System.Drawing.Size(179, 21)
        Me.CbbSttRec0.TabIndex = 221
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 226
        Me.Label1.Tag = "Cus code"
        Me.Label1.Text = "Dòng chi tiết"
        '
        'FrmPrintVoucherPBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbSttRec0)
        Me.Name = "FrmPrintVoucherPBG"
        Me.Controls.SetChildIndex(Me.txtTitle1, 0)
        Me.Controls.SetChildIndex(Me.txtTitle2, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_In, 0)
        Me.Controls.SetChildIndex(Me.LabMa_In, 0)
        Me.Controls.SetChildIndex(Me.CmdExit, 0)
        Me.Controls.SetChildIndex(Me.CmdPriview, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdModify, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct_Goc, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_lien, 0)
        Me.Controls.SetChildIndex(Me.CbbSttRec0, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbSttRec0 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
End Class
