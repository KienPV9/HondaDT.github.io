<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMHTTT
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
        Me.TxtMa_HTTT = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HTTT = New System.Windows.Forms.TextBox()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_HTTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "Mã HTTT"
        '
        'TxtMa_HTTT
        '
        Me.TxtMa_HTTT._ActilookupPopup = False
        Me.TxtMa_HTTT.CyberActilookupPopup = True
        Me.TxtMa_HTTT.Dv_ListDetail = Nothing
        Me.TxtMa_HTTT.Dv_Master = Nothing
        Me.TxtMa_HTTT.FilterClient = ""
        Me.TxtMa_HTTT.FilterSQL = ""
        Me.TxtMa_HTTT.Location = New System.Drawing.Point(92, 17)
        Me.TxtMa_HTTT.Name = "TxtMa_HTTT"
        Me.TxtMa_HTTT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HTTT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HTTT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HTTT.Size = New System.Drawing.Size(169, 20)
        Me.TxtMa_HTTT.TabIndex = 0
        Me.TxtMa_HTTT.Table_Name = ""
        '
        'TxtTen_HTTT
        '
        Me.TxtTen_HTTT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_HTTT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HTTT.Location = New System.Drawing.Point(92, 40)
        Me.TxtTen_HTTT.Name = "TxtTen_HTTT"
        Me.TxtTen_HTTT.Size = New System.Drawing.Size(459, 21)
        Me.TxtTen_HTTT.TabIndex = 1
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(15, 43)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(75, 14)
        Me.LabMa_Nh1.TabIndex = 376
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Tên HTTT"
        '
        'DMHTTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 125)
        Me.Controls.Add(Me.TxtTen_HTTT)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtMa_HTTT)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMHTTT"
        Me.Text = "Danh mục cặp vé"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HTTT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HTTT, 0)
        CType(Me.TxtMa_HTTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HTTT As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HTTT As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label

End Class
