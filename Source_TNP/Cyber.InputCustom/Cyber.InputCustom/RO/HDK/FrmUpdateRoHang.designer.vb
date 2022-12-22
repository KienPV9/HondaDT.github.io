<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateRoHang
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
        Me.TxtSo_Ro_Hang = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 51)
        Me.GroupBoxLine.Size = New System.Drawing.Size(481, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(281, 61)
        Me.ButtOK.TabIndex = 1
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(383, 61)
        Me.ButtExit.TabIndex = 2
        '
        'TxtSo_Ro_Hang
        '
        Me.TxtSo_Ro_Hang.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro_Hang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro_Hang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro_Hang.ForeColor = System.Drawing.Color.Red
        Me.TxtSo_Ro_Hang.Location = New System.Drawing.Point(118, 19)
        Me.TxtSo_Ro_Hang.Name = "TxtSo_Ro_Hang"
        Me.TxtSo_Ro_Hang.Size = New System.Drawing.Size(187, 21)
        Me.TxtSo_Ro_Hang.TabIndex = 0
        Me.TxtSo_Ro_Hang.Tag = ""
        Me.TxtSo_Ro_Hang.Text = "01.S15000001"
        Me.TxtSo_Ro_Hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(12, 23)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 15)
        Me.Label16.TabIndex = 1976
        Me.Label16.Tag = "Hãng"
        Me.Label16.Text = "Số lệnh hãng"
        '
        'FrmUpdateRoHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(485, 115)
        Me.Controls.Add(Me.TxtSo_Ro_Hang)
        Me.Controls.Add(Me.Label16)
        Me.Name = "FrmUpdateRoHang"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro_Hang, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSo_Ro_Hang As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
