<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXuatWord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXuatWord))
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
        Me.CmdPriview.Visible = False
        '
        'CmdPrint
        '
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(387, 96)
        Me.CmdPrint.Text = "&Nhận"
        '
        'CmdModify
        '
        Me.CmdModify.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdModify.Appearance.Options.UseForeColor = True
        Me.CmdModify.Location = New System.Drawing.Point(2, 95)
        Me.CmdModify.Visible = False
        '
        'TxtSo_lien
        '
        Me.TxtSo_lien.Visible = False
        '
        'TxtSo_Ct_Goc
        '
        Me.TxtSo_Ct_Goc.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(427, 70)
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Visible = False
        '
        'FrmXuatWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 129)
        Me.Name = "FrmXuatWord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
