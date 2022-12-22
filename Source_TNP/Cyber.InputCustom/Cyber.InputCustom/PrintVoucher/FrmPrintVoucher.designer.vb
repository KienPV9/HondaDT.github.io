<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintVoucher
    Inherits Cyber.From.FrmPrintVoucher

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
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(480, 96)
        '
        'CmdPriview
        '
        Me.CmdPriview.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPriview.Appearance.Options.UseForeColor = True
        Me.CmdPriview.Location = New System.Drawing.Point(387, 96)
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(293, 96)
        '
        'CmdModify
        '
        Me.CmdModify.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdModify.Appearance.Options.UseForeColor = True
        Me.CmdModify.Location = New System.Drawing.Point(2, 95)
        '
        'FrmPrintVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 129)
        Me.Name = "FrmPrintVoucher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
