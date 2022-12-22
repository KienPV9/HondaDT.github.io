<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMLoaiDT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_LoaiDT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_LoaiDT = New System.Windows.Forms.TextBox()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_LoaiDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(451, 89)
        Me.ButtExit.TabIndex = 4
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(345, 89)
        Me.ButtOK.TabIndex = 3
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(46, 94)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(38, 21)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(92, 102)
        Me.ChkActi.TabIndex = 6
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 69)
        Me.GroupBoxLine.Size = New System.Drawing.Size(559, 2)
        Me.GroupBoxLine.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Mã loại DT"
        '
        'TxtMa_LoaiDT
        '
        Me.TxtMa_LoaiDT._ActilookupPopup = False
        Me.TxtMa_LoaiDT.CyberActilookupPopup = True
        Me.TxtMa_LoaiDT.Dv_ListDetail = Nothing
        Me.TxtMa_LoaiDT.Dv_Master = Nothing
        Me.TxtMa_LoaiDT.FilterClient = ""
        Me.TxtMa_LoaiDT.FilterSQL = ""
        Me.TxtMa_LoaiDT.Location = New System.Drawing.Point(92, 17)
        Me.TxtMa_LoaiDT.Name = "TxtMa_LoaiDT"
        Me.TxtMa_LoaiDT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LoaiDT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_LoaiDT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_LoaiDT.Size = New System.Drawing.Size(169, 20)
        Me.TxtMa_LoaiDT.TabIndex = 0
        Me.TxtMa_LoaiDT.Table_Name = ""
        '
        'TxtTen_LoaiDT
        '
        Me.TxtTen_LoaiDT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_LoaiDT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LoaiDT.Location = New System.Drawing.Point(92, 40)
        Me.TxtTen_LoaiDT.Name = "TxtTen_LoaiDT"
        Me.TxtTen_LoaiDT.Size = New System.Drawing.Size(459, 21)
        Me.TxtTen_LoaiDT.TabIndex = 1
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(15, 43)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(75, 14)
        Me.LabMa_Nh1.TabIndex = 376
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Tên loại DT"
        '
        'DMLoaiDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 125)
        Me.Controls.Add(Me.TxtTen_LoaiDT)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtMa_LoaiDT)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMLoaiDT"
        Me.Text = "Danh mục cặp vé"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LoaiDT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LoaiDT, 0)
        CType(Me.TxtMa_LoaiDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_LoaiDT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_LoaiDT As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label

End Class
