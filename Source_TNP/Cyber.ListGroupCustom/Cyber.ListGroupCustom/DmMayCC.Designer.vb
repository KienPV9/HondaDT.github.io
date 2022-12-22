<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMMayCC
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
        Me.TxtTen_may = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_may = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.cbbMa_dvcs = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(449, 132)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(347, 132)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(241, 138)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(8, 140)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 122)
        Me.GroupBoxLine.Size = New System.Drawing.Size(547, 9)
        '
        'LabMa_Bp
        '
        Me.LabMa_Bp.Location = New System.Drawing.Point(9, 6)
        Me.LabMa_Bp.Name = "LabMa_Bp"
        Me.LabMa_Bp.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Bp.TabIndex = 10
        Me.LabMa_Bp.Tag = "Code"
        Me.LabMa_Bp.Text = "Mã máy"
        '
        'TxtTen_may
        '
        Me.TxtTen_may.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_may.Location = New System.Drawing.Point(110, 28)
        Me.TxtTen_may.Name = "TxtTen_may"
        Me.TxtTen_may.Size = New System.Drawing.Size(431, 21)
        Me.TxtTen_may.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(9, 30)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên máy"
        '
        'TxtIP
        '
        Me.TxtIP.ForeColor = System.Drawing.Color.Navy
        Me.TxtIP.Location = New System.Drawing.Point(110, 50)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(163, 21)
        Me.TxtIP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "Địa chỉ IP"
        '
        'TxtMa_may
        '
        Me.TxtMa_may.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_may.Location = New System.Drawing.Point(110, 6)
        Me.TxtMa_may.Name = "TxtMa_may"
        Me.TxtMa_may.Size = New System.Drawing.Size(163, 21)
        Me.TxtMa_may.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Tag = "English name"
        Me.Label2.Text = "Port"
        '
        'TxtPort
        '
        Me.TxtPort.ForeColor = System.Drawing.Color.Navy
        Me.TxtPort.Location = New System.Drawing.Point(110, 72)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(163, 21)
        Me.TxtPort.TabIndex = 45
        '
        'cbbMa_dvcs
        '
        Me.cbbMa_dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMa_dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cbbMa_dvcs.ForeColor = System.Drawing.Color.Navy
        Me.cbbMa_dvcs.FormattingEnabled = True
        Me.cbbMa_dvcs.Location = New System.Drawing.Point(110, 96)
        Me.cbbMa_dvcs.Name = "cbbMa_dvcs"
        Me.cbbMa_dvcs.Size = New System.Drawing.Size(431, 21)
        Me.cbbMa_dvcs.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Tag = "English name"
        Me.Label3.Text = "Đơn vị cơ sở"
        '
        'DMMayCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 165)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbMa_dvcs)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_may)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_may)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.LabMa_Bp)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMMayCC"
        Me.Text = "Danh mục máy chấm công"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_may, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtIP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_may, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtPort, 0)
        Me.Controls.SetChildIndex(Me.cbbMa_dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Bp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_may As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtIP As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtMa_may As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtPort As Windows.Forms.TextBox
    Friend WithEvents cbbMa_dvcs As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
