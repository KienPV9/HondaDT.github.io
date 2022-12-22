<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmNhSC
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.TxtMa_Nh = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(545, 111)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(443, 111)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(337, 117)
        Me.TxtMa_Dvcs.TabIndex = 3
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.Size = New System.Drawing.Size(643, 9)
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 14)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(88, 13)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Free 1"
        Me.LabMa_TD1.Text = "Mã nhóm"
        '
        'TxtMa_Nh
        '
        Me.TxtMa_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Nh.Location = New System.Drawing.Point(101, 11)
        Me.TxtMa_Nh.Name = "TxtMa_Nh"
        Me.TxtMa_Nh.Size = New System.Drawing.Size(161, 21)
        Me.TxtMa_Nh.TabIndex = 0
        '
        'TxtTen_Nh
        '
        Me.TxtTen_Nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh.Location = New System.Drawing.Point(101, 35)
        Me.TxtTen_Nh.Name = "TxtTen_Nh"
        Me.TxtTen_Nh.Size = New System.Drawing.Size(534, 21)
        Me.TxtTen_Nh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "Free 1"
        Me.Label1.Text = "Tên nhóm"
        '
        'DmNhSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 144)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh)
        Me.Controls.Add(Me.TxtMa_Nh)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Name = "DmNhSC"
        Me.Text = "Danh mục cấp bậc tuyển dụng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Nh As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
