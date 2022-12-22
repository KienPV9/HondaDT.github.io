<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PBG_Vay
    Inherits Cyber.From.FrmCalculator

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
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtRate_VAY = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRate_TraTruoc = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 56)
        Me.GroupBoxLine.Size = New System.Drawing.Size(494, 8)
        Me.GroupBoxLine.TabIndex = 3
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(294, 66)
        Me.ButtOK.TabIndex = 4
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(396, 66)
        Me.ButtExit.TabIndex = 5
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(97, 66)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(31, 21)
        Me.TxtStt_Rec.TabIndex = 1977
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'TxtRate_VAY
        '
        Me.TxtRate_VAY.AllowNegative = True
        Me.TxtRate_VAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRate_VAY.Flags = 7680
        Me.TxtRate_VAY.ForeColor = System.Drawing.Color.Navy
        Me.TxtRate_VAY.InputMask = "### ### ### ###"
        Me.TxtRate_VAY.Location = New System.Drawing.Point(142, 12)
        Me.TxtRate_VAY.MaxWholeDigits = 11
        Me.TxtRate_VAY.Name = "TxtRate_VAY"
        Me.TxtRate_VAY.RangeMax = 1.7976931348623157E+308R
        Me.TxtRate_VAY.RangeMin = -1.7976931348623157E+308R
        Me.TxtRate_VAY.Size = New System.Drawing.Size(112, 20)
        Me.TxtRate_VAY.TabIndex = 5
        Me.TxtRate_VAY.Text = "0"
        Me.TxtRate_VAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(7, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Tag = "Invoice rate"
        Me.Label3.Text = "% ngân hàng cho vay"
        '
        'TxtRate_TraTruoc
        '
        Me.TxtRate_TraTruoc.AllowNegative = True
        Me.TxtRate_TraTruoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRate_TraTruoc.Flags = 7680
        Me.TxtRate_TraTruoc.ForeColor = System.Drawing.Color.Navy
        Me.TxtRate_TraTruoc.InputMask = "### ### ### ###"
        Me.TxtRate_TraTruoc.Location = New System.Drawing.Point(351, 12)
        Me.TxtRate_TraTruoc.MaxWholeDigits = 11
        Me.TxtRate_TraTruoc.Name = "TxtRate_TraTruoc"
        Me.TxtRate_TraTruoc.RangeMax = 1.7976931348623157E+308R
        Me.TxtRate_TraTruoc.RangeMin = -1.7976931348623157E+308R
        Me.TxtRate_TraTruoc.Size = New System.Drawing.Size(112, 20)
        Me.TxtRate_TraTruoc.TabIndex = 2
        Me.TxtRate_TraTruoc.Text = "0"
        Me.TxtRate_TraTruoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(270, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "Invoice rate"
        Me.Label1.Text = "% trả trước"
        '
        'PBG_Vay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(498, 120)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtRate_TraTruoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtRate_VAY)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PBG_Vay"
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtRate_VAY, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtRate_TraTruoc, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStt_Rec As TextBox
    Friend WithEvents TxtRate_VAY As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRate_TraTruoc As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As Label
End Class
