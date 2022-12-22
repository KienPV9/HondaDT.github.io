<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintVoucherHDK
    Inherits Cyber.From.FrmPrintVoucher

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtLanBS = New ClsTextBox.txtTien_NT()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbMa_TT = New System.Windows.Forms.ComboBox()
        Me.CbbLoai_IN = New System.Windows.Forms.ComboBox()
        Me.ChkLanBS = New System.Windows.Forms.CheckBox()
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
        'TxtLanBS
        '
        Me.TxtLanBS.AllowNegative = True
        Me.TxtLanBS.BackColor = System.Drawing.Color.White
        Me.TxtLanBS.Flags = 7680
        Me.TxtLanBS.ForeColor = System.Drawing.Color.Navy
        Me.TxtLanBS.InputMask = "##"
        Me.TxtLanBS.Location = New System.Drawing.Point(533, 116)
        Me.TxtLanBS.MaxWholeDigits = 1
        Me.TxtLanBS.Name = "TxtLanBS"
        Me.TxtLanBS.RangeMax = 1.7976931348623157E+308R
        Me.TxtLanBS.RangeMin = -1.7976931348623157E+308R
        Me.TxtLanBS.Size = New System.Drawing.Size(39, 20)
        Me.TxtLanBS.TabIndex = 224
        Me.TxtLanBS.Text = "1"
        Me.TxtLanBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(386, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 225
        Me.Label7.Tag = "Cus code"
        Me.Label7.Text = "Bổ sung lần"
        '
        'CbbMa_TT
        '
        Me.CbbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TT.FormattingEnabled = True
        Me.CbbMa_TT.Location = New System.Drawing.Point(393, 89)
        Me.CbbMa_TT.Name = "CbbMa_TT"
        Me.CbbMa_TT.Size = New System.Drawing.Size(179, 21)
        Me.CbbMa_TT.TabIndex = 222
        '
        'CbbLoai_IN
        '
        Me.CbbLoai_IN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_IN.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_IN.FormattingEnabled = True
        Me.CbbLoai_IN.Location = New System.Drawing.Point(135, 89)
        Me.CbbLoai_IN.Name = "CbbLoai_IN"
        Me.CbbLoai_IN.Size = New System.Drawing.Size(179, 21)
        Me.CbbLoai_IN.TabIndex = 221
        '
        'ChkLanBS
        '
        Me.ChkLanBS.AutoSize = True
        Me.ChkLanBS.Location = New System.Drawing.Point(135, 116)
        Me.ChkLanBS.Name = "ChkLanBS"
        Me.ChkLanBS.Size = New System.Drawing.Size(165, 17)
        Me.ChkLanBS.TabIndex = 223
        Me.ChkLanBS.Tag = "Print for all additional"
        Me.ChkLanBS.Text = "In cho tất cả các lần bổ sung"
        Me.ChkLanBS.UseVisualStyleBackColor = True
        '
        'FrmPrintVoucherHDK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 176)
        Me.Controls.Add(Me.TxtLanBS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbbMa_TT)
        Me.Controls.Add(Me.CbbLoai_IN)
        Me.Controls.Add(Me.ChkLanBS)
        Me.Name = "FrmPrintVoucherHDK"
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
        Me.Controls.SetChildIndex(Me.ChkLanBS, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_IN, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtLanBS, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLanBS As ClsTextBox.txtTien_NT
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents CbbLoai_IN As System.Windows.Forms.ComboBox
    Friend WithEvents ChkLanBS As System.Windows.Forms.CheckBox

End Class
