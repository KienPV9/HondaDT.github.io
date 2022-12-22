<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tao_nhieu_Xe
    Inherits Cyber.From.FrmCalculator

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSL_COPY = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 58)
        Me.GroupBoxLine.Size = New System.Drawing.Size(325, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(125, 68)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(227, 68)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1989
        Me.Label2.Tag = "Total"
        Me.Label2.Text = "Số lượng xe copy"
        '
        'txtSL_COPY
        '
        Me.txtSL_COPY.AllowNegative = True
        Me.txtSL_COPY.BackColor = System.Drawing.Color.White
        Me.txtSL_COPY.Flags = 7680
        Me.txtSL_COPY.ForeColor = System.Drawing.Color.Navy
        Me.txtSL_COPY.InputMask = "###"
        Me.txtSL_COPY.Location = New System.Drawing.Point(101, 12)
        Me.txtSL_COPY.MaxWholeDigits = 2
        Me.txtSL_COPY.Name = "txtSL_COPY"
        Me.txtSL_COPY.RangeMax = 1.7976931348623157E+308R
        Me.txtSL_COPY.RangeMin = -1.7976931348623157E+308R
        Me.txtSL_COPY.Size = New System.Drawing.Size(108, 20)
        Me.txtSL_COPY.TabIndex = 1986
        Me.txtSL_COPY.Text = "0"
        Me.txtSL_COPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tao_nhieu_Xe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(329, 122)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSL_COPY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tao_nhieu_Xe"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.txtSL_COPY, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSL_COPY As ClsTextBox.txtTien_NT

End Class
