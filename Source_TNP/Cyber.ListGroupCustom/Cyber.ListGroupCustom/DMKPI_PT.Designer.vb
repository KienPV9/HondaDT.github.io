<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMKPI_PT
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
        Me.TxtTen_Chitieu = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.Txtghi_chu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtten_Chitieu2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_Chitieu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 109)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 109)
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
        Me.LabMa_Bp.Text = "Mã Chỉ tiêu"
        '
        'TxtTen_Chitieu
        '
        Me.TxtTen_Chitieu.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Chitieu.Location = New System.Drawing.Point(110, 28)
        Me.TxtTen_Chitieu.Name = "TxtTen_Chitieu"
        Me.TxtTen_Chitieu.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Chitieu.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên Chỉ tiêu"
        '
        'Txtghi_chu
        '
        Me.Txtghi_chu.ForeColor = System.Drawing.Color.Navy
        Me.Txtghi_chu.Location = New System.Drawing.Point(110, 72)
        Me.Txtghi_chu.Name = "Txtghi_chu"
        Me.Txtghi_chu.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtghi_chu.Size = New System.Drawing.Size(672, 21)
        Me.Txtghi_chu.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Ghi chú"
        '
        'Txtten_Chitieu2
        '
        Me.Txtten_Chitieu2.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Chitieu2.Location = New System.Drawing.Point(110, 50)
        Me.Txtten_Chitieu2.Name = "Txtten_Chitieu2"
        Me.Txtten_Chitieu2.Size = New System.Drawing.Size(672, 21)
        Me.Txtten_Chitieu2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "Tên Tiếng Anh"
        '
        'TxtMa_Chitieu
        '
        Me.TxtMa_Chitieu.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Chitieu.Location = New System.Drawing.Point(110, 6)
        Me.TxtMa_Chitieu.Name = "TxtMa_Chitieu"
        Me.TxtMa_Chitieu.Size = New System.Drawing.Size(163, 21)
        Me.TxtMa_Chitieu.TabIndex = 0
        '
        'DMKPI_PT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 142)
        Me.Controls.Add(Me.TxtMa_Chitieu)
        Me.Controls.Add(Me.Txtten_Chitieu2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtghi_chu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Chitieu)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMKPI_PT"
        Me.Text = "Danh mục chỉ tiêu KPI"
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Chitieu, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Txtghi_chu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Chitieu2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Chitieu, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Chitieu As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents Txtghi_chu As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Txtten_Chitieu2 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_Chitieu As Windows.Forms.TextBox
End Class
