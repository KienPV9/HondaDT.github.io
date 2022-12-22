<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMLoaiVB
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
        Me.TxtTEN_Loai = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtTEN_Loai2 = New System.Windows.Forms.TextBox()
        Me.LabTen_BP2 = New System.Windows.Forms.Label()
        Me.TxtGHI_CHU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMA_Loai = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 111)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 111)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 117)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(5, 6)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã Loại"
        '
        'TxtTEN_Loai
        '
        Me.TxtTEN_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTEN_Loai.Location = New System.Drawing.Point(110, 28)
        Me.TxtTEN_Loai.Name = "TxtTEN_Loai"
        Me.TxtTEN_Loai.Size = New System.Drawing.Size(672, 21)
        Me.TxtTEN_Loai.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên Loại"
        '
        'TxtTEN_Loai2
        '
        Me.TxtTEN_Loai2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTEN_Loai2.Location = New System.Drawing.Point(110, 51)
        Me.TxtTEN_Loai2.Name = "TxtTEN_Loai2"
        Me.TxtTEN_Loai2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTEN_Loai2.TabIndex = 2
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
        'TxtGHI_CHU
        '
        Me.TxtGHI_CHU.ForeColor = System.Drawing.Color.Navy
        Me.TxtGHI_CHU.Location = New System.Drawing.Point(110, 73)
        Me.TxtGHI_CHU.Name = "TxtGHI_CHU"
        Me.TxtGHI_CHU.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtGHI_CHU.Size = New System.Drawing.Size(672, 21)
        Me.TxtGHI_CHU.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Ghi chú"
        '
        'TxtMA_Loai
        '
        Me.TxtMA_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtMA_Loai.Location = New System.Drawing.Point(110, 6)
        Me.TxtMA_Loai.Name = "TxtMA_Loai"
        Me.TxtMA_Loai.Size = New System.Drawing.Size(149, 21)
        Me.TxtMA_Loai.TabIndex = 1
        '
        'DMLNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 144)
        Me.Controls.Add(Me.TxtMA_Loai)
        Me.Controls.Add(Me.TxtGHI_CHU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTEN_Loai2)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.TxtTEN_Loai)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMLNL"
        Me.Text = "Danh mục loại văn bản"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTEN_Loai, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.TxtTEN_Loai2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtGHI_CHU, 0)
        Me.Controls.SetChildIndex(Me.TxtMA_Loai, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTEN_Loai As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtTEN_Loai2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label
    Friend WithEvents TxtGHI_CHU As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtMA_Loai As Windows.Forms.TextBox
End Class
