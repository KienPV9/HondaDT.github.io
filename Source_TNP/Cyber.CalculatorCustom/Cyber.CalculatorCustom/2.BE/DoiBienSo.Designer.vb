<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoiBienSo
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
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStt_Rec0 = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe_New = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 65)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(290, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(91, 78)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 7
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(193, 78)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 8
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.BackColor = System.Drawing.Color.White
        Me.TxtSo_Khung.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(357, 6)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.ReadOnly = True
        Me.TxtSo_Khung.Size = New System.Drawing.Size(202, 20)
        Me.TxtSo_Khung.TabIndex = 1820
        Me.TxtSo_Khung.Tag = ""
        Me.TxtSo_Khung.Visible = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(262, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 1825
        Me.Label4.Tag = "Frame number"
        Me.Label4.Text = "Số khung"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(17, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2104
        Me.Label3.Tag = "Contract Number"
        Me.Label3.Text = "Biển số hiện tại"
        '
        'TxtStt_Rec0
        '
        Me.TxtStt_Rec0.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec0.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec0.Location = New System.Drawing.Point(641, 10)
        Me.TxtStt_Rec0.Name = "TxtStt_Rec0"
        Me.TxtStt_Rec0.ReadOnly = True
        Me.TxtStt_Rec0.Size = New System.Drawing.Size(121, 20)
        Me.TxtStt_Rec0.TabIndex = 2105
        Me.TxtStt_Rec0.Tag = ""
        Me.TxtStt_Rec0.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(641, 32)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(121, 20)
        Me.TxtStt_Rec.TabIndex = 2106
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(118, 6)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(121, 20)
        Me.TxtMa_Xe.TabIndex = 2103
        Me.TxtMa_Xe.Tag = ""
        '
        'TxtMa_Xe_New
        '
        Me.TxtMa_Xe_New.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMa_Xe_New.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe_New.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe_New.Location = New System.Drawing.Point(118, 29)
        Me.TxtMa_Xe_New.Name = "TxtMa_Xe_New"
        Me.TxtMa_Xe_New.Size = New System.Drawing.Size(121, 20)
        Me.TxtMa_Xe_New.TabIndex = 1
        Me.TxtMa_Xe_New.Tag = ""
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 2108
        Me.Label1.Tag = "Contract Number"
        Me.Label1.Text = "Biển số mới"
        '
        'DoiBienSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(295, 131)
        Me.Controls.Add(Me.TxtMa_Xe_New)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtStt_Rec0)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DoiBienSo"
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec0, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe_New, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec0 As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe_New As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
