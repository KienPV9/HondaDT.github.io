<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMCTKM
    Inherits Cyber.From.FrmList

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
        Me.LabMa_Bp = New System.Windows.Forms.Label()
        Me.TxtTEN_ct = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtTEN_ct2 = New System.Windows.Forms.TextBox()
        Me.LabTen_BP2 = New System.Windows.Forms.Label()
        Me.Txtdia_diem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMA_ct = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 109)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 109)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 115)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 119)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 99)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 6)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã chương trình"
        '
        'TxtTEN_ct
        '
        Me.TxtTEN_ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtTEN_ct.Location = New System.Drawing.Point(110, 28)
        Me.TxtTEN_ct.Name = "TxtTEN_ct"
        Me.TxtTEN_ct.Size = New System.Drawing.Size(672, 21)
        Me.TxtTEN_ct.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên chương trình"
        '
        'TxtTEN_ct2
        '
        Me.TxtTEN_ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTEN_ct2.Location = New System.Drawing.Point(110, 51)
        Me.TxtTEN_ct2.Name = "TxtTEN_ct2"
        Me.TxtTEN_ct2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTEN_ct2.TabIndex = 2
        '
        'LabTen_BP2
        '
        Me.LabTen_BP2.Location = New System.Drawing.Point(5, 52)
        Me.LabTen_BP2.Name = "LabTen_BP2"
        Me.LabTen_BP2.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP2.TabIndex = 14
        Me.LabTen_BP2.Tag = "English name"
        Me.LabTen_BP2.Text = "Tên Tiếng Anh"
        '
        'Txtdia_diem
        '
        Me.Txtdia_diem.ForeColor = System.Drawing.Color.Navy
        Me.Txtdia_diem.Location = New System.Drawing.Point(110, 73)
        Me.Txtdia_diem.Name = "Txtdia_diem"
        Me.Txtdia_diem.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtdia_diem.Size = New System.Drawing.Size(672, 21)
        Me.Txtdia_diem.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Địa điểm áp dụng"
        '
        'TxtMA_ct
        '
        Me.TxtMA_ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtMA_ct.Location = New System.Drawing.Point(110, 6)
        Me.TxtMA_ct.Name = "TxtMA_ct"
        Me.TxtMA_ct.Size = New System.Drawing.Size(149, 21)
        Me.TxtMA_ct.TabIndex = 1
        '
        'DMCTKM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 142)
        Me.Controls.Add(Me.TxtMA_ct)
        Me.Controls.Add(Me.Txtdia_diem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTEN_ct2)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.TxtTEN_ct)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMCTKM"
        Me.Text = "Danh mục loại văn bản"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTEN_ct, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.TxtTEN_ct2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Txtdia_diem, 0)
        Me.Controls.SetChildIndex(Me.TxtMA_ct, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTEN_ct As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtTEN_ct2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label
    Friend WithEvents Txtdia_diem As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtMA_ct As Windows.Forms.TextBox
End Class
