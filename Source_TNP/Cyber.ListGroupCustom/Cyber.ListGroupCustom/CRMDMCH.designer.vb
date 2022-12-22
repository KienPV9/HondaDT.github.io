<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMDMCH
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
        Me.TxtMa_Ch = New System.Windows.Forms.TextBox()
        Me.TxtTen_Ch = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT = New System.Windows.Forms.Label()
        Me.TxtTen_Ch2 = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Ch1 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Ch2 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Ch3 = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Ch4 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Ch5 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Loai = New System.Windows.Forms.TextBox()
        Me.Txtma_Loai = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkIS_Nguon = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtNh_Ch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Ch2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Ch3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Ch4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Ch5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_Loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(419, 241)
        Me.ButtExit.TabIndex = 11
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(317, 241)
        Me.ButtOK.TabIndex = 10
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(211, 247)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(12, 248)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 231)
        Me.GroupBoxLine.Size = New System.Drawing.Size(517, 9)
        '
        'LabMa_LHTT
        '
        Me.LabMa_LHTT.Location = New System.Drawing.Point(9, 144)
        Me.LabMa_LHTT.Name = "LabMa_LHTT"
        Me.LabMa_LHTT.Size = New System.Drawing.Size(92, 18)
        Me.LabMa_LHTT.TabIndex = 10
        Me.LabMa_LHTT.Tag = "Code"
        Me.LabMa_LHTT.Text = "Mã câu hỏi"
        '
        'TxtMa_Ch
        '
        Me.TxtMa_Ch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ch.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ch.Location = New System.Drawing.Point(101, 143)
        Me.TxtMa_Ch.Name = "TxtMa_Ch"
        Me.TxtMa_Ch.Size = New System.Drawing.Size(113, 21)
        Me.TxtMa_Ch.TabIndex = 6
        '
        'TxtTen_Ch
        '
        Me.TxtTen_Ch.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ch.Location = New System.Drawing.Point(101, 166)
        Me.TxtTen_Ch.Name = "TxtTen_Ch"
        Me.TxtTen_Ch.Size = New System.Drawing.Size(413, 21)
        Me.TxtTen_Ch.TabIndex = 7
        '
        'LabTen_LHTT
        '
        Me.LabTen_LHTT.Location = New System.Drawing.Point(9, 168)
        Me.LabTen_LHTT.Name = "LabTen_LHTT"
        Me.LabTen_LHTT.Size = New System.Drawing.Size(92, 18)
        Me.LabTen_LHTT.TabIndex = 12
        Me.LabTen_LHTT.Tag = "Name"
        Me.LabTen_LHTT.Text = "Tên câu hỏi"
        '
        'TxtTen_Ch2
        '
        Me.TxtTen_Ch2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ch2.Location = New System.Drawing.Point(101, 189)
        Me.TxtTen_Ch2.Name = "TxtTen_Ch2"
        Me.TxtTen_Ch2.Size = New System.Drawing.Size(413, 21)
        Me.TxtTen_Ch2.TabIndex = 8
        '
        'LabTen_LHTT2
        '
        Me.LabTen_LHTT2.Location = New System.Drawing.Point(9, 190)
        Me.LabTen_LHTT2.Name = "LabTen_LHTT2"
        Me.LabTen_LHTT2.Size = New System.Drawing.Size(92, 18)
        Me.LabTen_LHTT2.TabIndex = 14
        Me.LabTen_LHTT2.Tag = "English name"
        Me.LabTen_LHTT2.Text = "Tên tiếng anh"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(9, 33)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(92, 18)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(220, 36)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Nh1.TabIndex = 23
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_Ch1
        '
        Me.TxtNh_Ch1._ActilookupPopup = False
        Me.TxtNh_Ch1.CyberActilookupPopup = True
        Me.TxtNh_Ch1.Dv_ListDetail = Nothing
        Me.TxtNh_Ch1.Dv_Master = Nothing
        Me.TxtNh_Ch1.FilterClient = ""
        Me.TxtNh_Ch1.FilterSQL = ""
        Me.TxtNh_Ch1.Location = New System.Drawing.Point(101, 33)
        Me.TxtNh_Ch1.Name = "TxtNh_Ch1"
        Me.TxtNh_Ch1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Ch1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Ch1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Ch1.Size = New System.Drawing.Size(113, 20)
        Me.TxtNh_Ch1.TabIndex = 1
        Me.TxtNh_Ch1.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Nhóm 2"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(220, 58)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Nh2.TabIndex = 26
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_Ch2
        '
        Me.TxtNh_Ch2._ActilookupPopup = False
        Me.TxtNh_Ch2.CyberActilookupPopup = True
        Me.TxtNh_Ch2.Dv_ListDetail = Nothing
        Me.TxtNh_Ch2.Dv_Master = Nothing
        Me.TxtNh_Ch2.FilterClient = ""
        Me.TxtNh_Ch2.FilterSQL = ""
        Me.TxtNh_Ch2.Location = New System.Drawing.Point(101, 55)
        Me.TxtNh_Ch2.Name = "TxtNh_Ch2"
        Me.TxtNh_Ch2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Ch2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Ch2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Ch2.Size = New System.Drawing.Size(113, 20)
        Me.TxtNh_Ch2.TabIndex = 2
        Me.TxtNh_Ch2.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(220, 80)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Nh3.TabIndex = 29
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_Ch3
        '
        Me.TxtNh_Ch3._ActilookupPopup = False
        Me.TxtNh_Ch3.CyberActilookupPopup = True
        Me.TxtNh_Ch3.Dv_ListDetail = Nothing
        Me.TxtNh_Ch3.Dv_Master = Nothing
        Me.TxtNh_Ch3.FilterClient = ""
        Me.TxtNh_Ch3.FilterSQL = ""
        Me.TxtNh_Ch3.Location = New System.Drawing.Point(101, 77)
        Me.TxtNh_Ch3.Name = "TxtNh_Ch3"
        Me.TxtNh_Ch3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Ch3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Ch3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Ch3.Size = New System.Drawing.Size(113, 20)
        Me.TxtNh_Ch3.TabIndex = 3
        Me.TxtNh_Ch3.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Tag = "Group 4"
        Me.Label3.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(220, 102)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Nh4.TabIndex = 32
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_Ch4
        '
        Me.TxtNh_Ch4._ActilookupPopup = False
        Me.TxtNh_Ch4.CyberActilookupPopup = True
        Me.TxtNh_Ch4.Dv_ListDetail = Nothing
        Me.TxtNh_Ch4.Dv_Master = Nothing
        Me.TxtNh_Ch4.FilterClient = ""
        Me.TxtNh_Ch4.FilterSQL = ""
        Me.TxtNh_Ch4.Location = New System.Drawing.Point(101, 99)
        Me.TxtNh_Ch4.Name = "TxtNh_Ch4"
        Me.TxtNh_Ch4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Ch4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Ch4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Ch4.Size = New System.Drawing.Size(113, 20)
        Me.TxtNh_Ch4.TabIndex = 4
        Me.TxtNh_Ch4.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Tag = "Group 5"
        Me.Label4.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(220, 120)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Nh5.TabIndex = 35
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_Ch5
        '
        Me.TxtNh_Ch5._ActilookupPopup = False
        Me.TxtNh_Ch5.CyberActilookupPopup = True
        Me.TxtNh_Ch5.Dv_ListDetail = Nothing
        Me.TxtNh_Ch5.Dv_Master = Nothing
        Me.TxtNh_Ch5.FilterClient = ""
        Me.TxtNh_Ch5.FilterSQL = ""
        Me.TxtNh_Ch5.Location = New System.Drawing.Point(101, 121)
        Me.TxtNh_Ch5.Name = "TxtNh_Ch5"
        Me.TxtNh_Ch5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Ch5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Ch5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Ch5.Size = New System.Drawing.Size(113, 20)
        Me.TxtNh_Ch5.TabIndex = 5
        Me.TxtNh_Ch5.Table_Name = ""
        '
        'TxtTen_Loai
        '
        Me.TxtTen_Loai.BackColor = System.Drawing.Color.White
        Me.TxtTen_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai.Enabled = False
        Me.TxtTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai.Location = New System.Drawing.Point(220, 10)
        Me.TxtTen_Loai.Name = "TxtTen_Loai"
        Me.TxtTen_Loai.ReadOnly = True
        Me.TxtTen_Loai.Size = New System.Drawing.Size(294, 14)
        Me.TxtTen_Loai.TabIndex = 39
        Me.TxtTen_Loai.TabStop = False
        '
        'Txtma_Loai
        '
        Me.Txtma_Loai._ActilookupPopup = False
        Me.Txtma_Loai.CyberActilookupPopup = True
        Me.Txtma_Loai.Dv_ListDetail = Nothing
        Me.Txtma_Loai.Dv_Master = Nothing
        Me.Txtma_Loai.FilterClient = ""
        Me.Txtma_Loai.FilterSQL = ""
        Me.Txtma_Loai.Location = New System.Drawing.Point(101, 7)
        Me.Txtma_Loai.Name = "Txtma_Loai"
        Me.Txtma_Loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Loai.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_Loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_Loai.Size = New System.Drawing.Size(113, 20)
        Me.Txtma_Loai.TabIndex = 0
        Me.Txtma_Loai.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Tag = "Type"
        Me.Label5.Text = "Phân loại"
        '
        'chkIS_Nguon
        '
        Me.chkIS_Nguon.AutoSize = True
        Me.chkIS_Nguon.Location = New System.Drawing.Point(101, 214)
        Me.chkIS_Nguon.Name = "chkIS_Nguon"
        Me.chkIS_Nguon.Size = New System.Drawing.Size(95, 17)
        Me.chkIS_Nguon.TabIndex = 2094
        Me.chkIS_Nguon.Text = "Câu hỏi Online"
        Me.chkIS_Nguon.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(217, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 18)
        Me.Label6.TabIndex = 2095
        Me.Label6.Tag = "Name"
        Me.Label6.Text = "Lưu ý: Dành cho câu hỏi sự kiện"
        '
        'CRMDMCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(521, 274)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkIS_Nguon)
        Me.Controls.Add(Me.TxtTen_Loai)
        Me.Controls.Add(Me.Txtma_Loai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_Ch5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_Ch4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_Ch3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_Ch2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_Ch1)
        Me.Controls.Add(Me.TxtTen_Ch2)
        Me.Controls.Add(Me.LabTen_LHTT2)
        Me.Controls.Add(Me.TxtTen_Ch)
        Me.Controls.Add(Me.LabTen_LHTT)
        Me.Controls.Add(Me.TxtMa_Ch)
        Me.Controls.Add(Me.LabMa_LHTT)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CRMDMCH"
        Me.Text = "Danh mục loại hình thanh toán"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ch, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ch, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ch2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Ch1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Ch2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Ch3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Ch4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Ch5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai, 0)
        Me.Controls.SetChildIndex(Me.chkIS_Nguon, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        CType(Me.TxtNh_Ch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Ch2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Ch3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Ch4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Ch5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_Loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Ch As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Ch As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Ch2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Ch1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Ch2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Ch3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Ch4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Ch5 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Loai As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkIS_Nguon As Windows.Forms.CheckBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
