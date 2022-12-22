<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmLyDoTL
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_LyDoTL2 = New System.Windows.Forms.TextBox()
        Me.TxtMa_LyDoTL = New System.Windows.Forms.TextBox()
        Me.TxtTen_LyDoTL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(545, 117)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(443, 117)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(337, 123)
        Me.TxtMa_Dvcs.TabIndex = 3
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 127)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 107)
        Me.GroupBoxLine.Size = New System.Drawing.Size(643, 9)
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 14)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(88, 13)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Free 1"
        Me.LabMa_TD1.Text = "Mã lý do"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Tag = "Free 1"
        Me.Label6.Text = "Tên tiếng anh "
        '
        'TxtTen_LyDoTL2
        '
        Me.TxtTen_LyDoTL2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LyDoTL2.Location = New System.Drawing.Point(101, 60)
        Me.TxtTen_LyDoTL2.Name = "TxtTen_LyDoTL2"
        Me.TxtTen_LyDoTL2.Size = New System.Drawing.Size(534, 21)
        Me.TxtTen_LyDoTL2.TabIndex = 2
        '
        'TxtMa_LyDoTL
        '
        Me.TxtMa_LyDoTL.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LyDoTL.Location = New System.Drawing.Point(101, 11)
        Me.TxtMa_LyDoTL.Name = "TxtMa_LyDoTL"
        Me.TxtMa_LyDoTL.Size = New System.Drawing.Size(161, 21)
        Me.TxtMa_LyDoTL.TabIndex = 0
        '
        'TxtTen_LyDoTL
        '
        Me.TxtTen_LyDoTL.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LyDoTL.Location = New System.Drawing.Point(101, 35)
        Me.TxtTen_LyDoTL.Name = "TxtTen_LyDoTL"
        Me.TxtTen_LyDoTL.Size = New System.Drawing.Size(534, 21)
        Me.TxtTen_LyDoTL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "Free 1"
        Me.Label1.Text = "Tên lý do"
        '
        'DmLyDoTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_LyDoTL)
        Me.Controls.Add(Me.TxtMa_LyDoTL)
        Me.Controls.Add(Me.TxtTen_LyDoTL2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Name = "DmLyDoTL"
        Me.Text = "Danh mục hiệu lực vụ việc"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LyDoTL2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LyDoTL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LyDoTL, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_LyDoTL2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_LyDoTL As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_LyDoTL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
