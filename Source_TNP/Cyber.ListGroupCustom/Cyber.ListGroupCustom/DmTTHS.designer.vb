<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmTTHS
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
        Me.TxtSo_Khung = New System.Windows.Forms.TextBox()
        Me.TxtTT_HoSo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(372, 117)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(270, 117)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(164, 123)
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
        Me.GroupBoxLine.Size = New System.Drawing.Size(470, 9)
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 14)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(88, 13)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Free 1"
        Me.LabMa_TD1.Text = "Số khung"
        '
        'TxtSo_Khung
        '
        Me.TxtSo_Khung.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Khung.Location = New System.Drawing.Point(101, 11)
        Me.TxtSo_Khung.Name = "TxtSo_Khung"
        Me.TxtSo_Khung.Size = New System.Drawing.Size(161, 21)
        Me.TxtSo_Khung.TabIndex = 0
        '
        'TxtTT_HoSo
        '
        Me.TxtTT_HoSo.ForeColor = System.Drawing.Color.Navy
        Me.TxtTT_HoSo.Location = New System.Drawing.Point(101, 35)
        Me.TxtTT_HoSo.Name = "TxtTT_HoSo"
        Me.TxtTT_HoSo.Size = New System.Drawing.Size(161, 21)
        Me.TxtTT_HoSo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Tag = "Free 1"
        Me.Label1.Text = "Tình trạng"
        '
        'DmTTHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTT_HoSo)
        Me.Controls.Add(Me.TxtSo_Khung)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Name = "DmTTHS"
        Me.Text = "Danh mục tình trạng hồ sơ"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Khung, 0)
        Me.Controls.SetChildIndex(Me.TxtTT_HoSo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Khung As System.Windows.Forms.TextBox
    Friend WithEvents TxtTT_HoSo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
