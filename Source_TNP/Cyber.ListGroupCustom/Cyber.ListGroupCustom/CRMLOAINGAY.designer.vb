<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMLOAINGAY
    Inherits Cyber.From.FrmList

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
        Me.LabMa_LHTT = New System.Windows.Forms.Label()
        Me.TxtMa_ngay = New System.Windows.Forms.TextBox()
        Me.TxtTen_ngay = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT = New System.Windows.Forms.Label()
        Me.TxtTen_ngay2 = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_loai = New System.Windows.Forms.TextBox()
        Me.TxtCrmMa_loai = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSo_ngay = New ClsTextBox.txtTien_NT()
        CType(Me.TxtCrmMa_loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(525, 154)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(423, 154)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(317, 160)
        Me.TxtMa_Dvcs.TabIndex = 8
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(101, 164)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 144)
        Me.GroupBoxLine.Size = New System.Drawing.Size(623, 9)
        Me.GroupBoxLine.TabIndex = 6
        '
        'LabMa_LHTT
        '
        Me.LabMa_LHTT.Location = New System.Drawing.Point(10, 38)
        Me.LabMa_LHTT.Name = "LabMa_LHTT"
        Me.LabMa_LHTT.Size = New System.Drawing.Size(77, 16)
        Me.LabMa_LHTT.TabIndex = 10
        Me.LabMa_LHTT.Tag = "Code"
        Me.LabMa_LHTT.Text = "Mã ngày"
        '
        'TxtMa_ngay
        '
        Me.TxtMa_ngay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ngay.Location = New System.Drawing.Point(101, 34)
        Me.TxtMa_ngay.Name = "TxtMa_ngay"
        Me.TxtMa_ngay.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_ngay.TabIndex = 1
        '
        'TxtTen_ngay
        '
        Me.TxtTen_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ngay.Location = New System.Drawing.Point(101, 57)
        Me.TxtTen_ngay.Name = "TxtTen_ngay"
        Me.TxtTen_ngay.Size = New System.Drawing.Size(506, 21)
        Me.TxtTen_ngay.TabIndex = 2
        '
        'LabTen_LHTT
        '
        Me.LabTen_LHTT.Location = New System.Drawing.Point(10, 62)
        Me.LabTen_LHTT.Name = "LabTen_LHTT"
        Me.LabTen_LHTT.Size = New System.Drawing.Size(77, 16)
        Me.LabTen_LHTT.TabIndex = 12
        Me.LabTen_LHTT.Tag = "Name"
        Me.LabTen_LHTT.Text = "Tên ngày"
        '
        'TxtTen_ngay2
        '
        Me.TxtTen_ngay2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ngay2.Location = New System.Drawing.Point(101, 80)
        Me.TxtTen_ngay2.Name = "TxtTen_ngay2"
        Me.TxtTen_ngay2.Size = New System.Drawing.Size(506, 21)
        Me.TxtTen_ngay2.TabIndex = 3
        '
        'LabTen_LHTT2
        '
        Me.LabTen_LHTT2.Location = New System.Drawing.Point(10, 84)
        Me.LabTen_LHTT2.Name = "LabTen_LHTT2"
        Me.LabTen_LHTT2.Size = New System.Drawing.Size(77, 16)
        Me.LabTen_LHTT2.TabIndex = 14
        Me.LabTen_LHTT2.Tag = "English name"
        Me.LabTen_LHTT2.Text = "Tên tiếng anh"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Mã loại"
        '
        'TxtTen_loai
        '
        Me.TxtTen_loai.BackColor = System.Drawing.Color.White
        Me.TxtTen_loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_loai.Enabled = False
        Me.TxtTen_loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_loai.Location = New System.Drawing.Point(253, 16)
        Me.TxtTen_loai.Name = "TxtTen_loai"
        Me.TxtTen_loai.ReadOnly = True
        Me.TxtTen_loai.Size = New System.Drawing.Size(354, 14)
        Me.TxtTen_loai.TabIndex = 32
        Me.TxtTen_loai.TabStop = False
        '
        'TxtCrmMa_loai
        '
        Me.TxtCrmMa_loai._ActilookupPopup = False
        Me.TxtCrmMa_loai.CyberActilookupPopup = True
        Me.TxtCrmMa_loai.Dv_ListDetail = Nothing
        Me.TxtCrmMa_loai.Dv_Master = Nothing
        Me.TxtCrmMa_loai.FilterClient = ""
        Me.TxtCrmMa_loai.FilterSQL = ""
        Me.TxtCrmMa_loai.Location = New System.Drawing.Point(101, 13)
        Me.TxtCrmMa_loai.Name = "TxtCrmMa_loai"
        Me.TxtCrmMa_loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtCrmMa_loai.Properties.Appearance.Options.UseForeColor = True
        Me.TxtCrmMa_loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtCrmMa_loai.Size = New System.Drawing.Size(149, 20)
        Me.TxtCrmMa_loai.TabIndex = 0
        Me.TxtCrmMa_loai.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Tag = "English name"
        Me.Label1.Text = "Số ngày"
        '
        'TxtSo_ngay
        '
        Me.TxtSo_ngay.AllowNegative = True
        Me.TxtSo_ngay.BackColor = System.Drawing.Color.White
        Me.TxtSo_ngay.Enabled = False
        Me.TxtSo_ngay.Flags = 7680
        Me.TxtSo_ngay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ngay.InputMask = " ###"
        Me.TxtSo_ngay.Location = New System.Drawing.Point(101, 103)
        Me.TxtSo_ngay.MaxWholeDigits = 4
        Me.TxtSo_ngay.Name = "TxtSo_ngay"
        Me.TxtSo_ngay.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_ngay.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_ngay.Size = New System.Drawing.Size(148, 21)
        Me.TxtSo_ngay.TabIndex = 4
        Me.TxtSo_ngay.Text = "0"
        Me.TxtSo_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CRMLOAINGAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(627, 187)
        Me.Controls.Add(Me.TxtSo_ngay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_loai)
        Me.Controls.Add(Me.TxtCrmMa_loai)
        Me.Controls.Add(Me.TxtTen_ngay2)
        Me.Controls.Add(Me.LabTen_LHTT2)
        Me.Controls.Add(Me.TxtTen_ngay)
        Me.Controls.Add(Me.LabTen_LHTT)
        Me.Controls.Add(Me.TxtMa_ngay)
        Me.Controls.Add(Me.LabMa_LHTT)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CRMLOAINGAY"
        Me.Text = "Danh mục loại hình chăm sóc"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ngay, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ngay, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ngay2, 0)
        Me.Controls.SetChildIndex(Me.TxtCrmMa_loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_loai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ngay, 0)
        CType(Me.TxtCrmMa_loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_ngay As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_ngay As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ngay2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtCrmMa_loai As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_ngay As ClsTextBox.txtTien_NT

End Class
