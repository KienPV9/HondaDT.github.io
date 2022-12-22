<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEXEPXE_IN_BB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BEXEPXE_IN_BB))
        Me.CbbPrint = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdModify = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdPriview = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 94)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(752, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(485, 106)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 1
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(621, 106)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 3
        '
        'CbbPrint
        '
        Me.CbbPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbPrint.ForeColor = System.Drawing.Color.Navy
        Me.CbbPrint.FormattingEnabled = True
        Me.CbbPrint.Location = New System.Drawing.Point(144, 11)
        Me.CbbPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbPrint.Name = "CbbPrint"
        Me.CbbPrint.Size = New System.Drawing.Size(608, 24)
        Me.CbbPrint.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(8, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 1786
        Me.Label8.Tag = "Type of print"
        Me.Label8.Text = "Chọn loại in"
        '
        'CmdModify
        '
        Me.CmdModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdModify.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdModify.Appearance.Options.UseForeColor = True
        Me.CmdModify.Image = CType(resources.GetObject("CmdModify.Image"), System.Drawing.Image)
        Me.CmdModify.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.CmdModify.Location = New System.Drawing.Point(0, 103)
        Me.CmdModify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdModify.Name = "CmdModify"
        Me.CmdModify.Size = New System.Drawing.Size(123, 38)
        Me.CmdModify.TabIndex = 1789
        Me.CmdModify.Tag = "&Modify"
        Me.CmdModify.Text = "&Sửa đổi"
        '
        'CmdPrint
        '
        Me.CmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.CmdPrint.Location = New System.Drawing.Point(373, 103)
        Me.CmdPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(123, 38)
        Me.CmdPrint.TabIndex = 2
        Me.CmdPrint.Tag = "&Print"
        Me.CmdPrint.Text = "&In"
        '
        'CmdPriview
        '
        Me.CmdPriview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPriview.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPriview.Appearance.Options.UseForeColor = True
        Me.CmdPriview.Image = CType(resources.GetObject("CmdPriview.Image"), System.Drawing.Image)
        Me.CmdPriview.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.CmdPriview.Location = New System.Drawing.Point(499, 103)
        Me.CmdPriview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdPriview.Name = "CmdPriview"
        Me.CmdPriview.Size = New System.Drawing.Size(123, 38)
        Me.CmdPriview.TabIndex = 1
        Me.CmdPriview.Tag = "&Priview"
        Me.CmdPriview.Text = "&Xem"
        '
        'BEXEPXE_IN_BB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(757, 172)
        Me.Controls.Add(Me.CmdModify)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.CmdPriview)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CbbPrint)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimizeBox = False
        Me.Name = "BEXEPXE_IN_BB"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbPrint, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.CmdPriview, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdModify, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbPrint As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents CmdModify As DevExpress.XtraEditors.SimpleButton
    Public WithEvents CmdPrint As DevExpress.XtraEditors.SimpleButton
    Public WithEvents CmdPriview As DevExpress.XtraEditors.SimpleButton

End Class
