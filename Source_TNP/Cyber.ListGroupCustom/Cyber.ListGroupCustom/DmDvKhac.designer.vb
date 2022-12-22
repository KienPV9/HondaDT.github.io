<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmDvKhac
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
        Me.LabMa_PK = New System.Windows.Forms.Label()
        Me.TxtMa_DvKhac = New System.Windows.Forms.TextBox()
        Me.TxtTen_DvKhac = New System.Windows.Forms.TextBox()
        Me.LabTen_kho = New System.Windows.Forms.Label()
        Me.TxtTen_DvKhac2 = New System.Windows.Forms.TextBox()
        Me.Labten_Kho2 = New System.Windows.Forms.Label()
        Me.LblTk_DL = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.TxtDVT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGia = New ClsTextBox.txtTy_Gia()
        Me.TxtGia_nt2 = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 163)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 163)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 169)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 173)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 153)
        '
        'LabMa_PK
        '
        Me.LabMa_PK.Location = New System.Drawing.Point(5, 13)
        Me.LabMa_PK.Name = "LabMa_PK"
        Me.LabMa_PK.Size = New System.Drawing.Size(100, 18)
        Me.LabMa_PK.TabIndex = 10
        Me.LabMa_PK.Tag = "Code"
        Me.LabMa_PK.Text = "Mã dịch vụ"
        '
        'TxtMa_DvKhac
        '
        Me.TxtMa_DvKhac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_DvKhac.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_DvKhac.Location = New System.Drawing.Point(110, 12)
        Me.TxtMa_DvKhac.Name = "TxtMa_DvKhac"
        Me.TxtMa_DvKhac.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_DvKhac.TabIndex = 5
        '
        'TxtTen_DvKhac
        '
        Me.TxtTen_DvKhac.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DvKhac.Location = New System.Drawing.Point(110, 35)
        Me.TxtTen_DvKhac.Name = "TxtTen_DvKhac"
        Me.TxtTen_DvKhac.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_DvKhac.TabIndex = 6
        '
        'LabTen_kho
        '
        Me.LabTen_kho.Location = New System.Drawing.Point(5, 37)
        Me.LabTen_kho.Name = "LabTen_kho"
        Me.LabTen_kho.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_kho.TabIndex = 12
        Me.LabTen_kho.Tag = "Name"
        Me.LabTen_kho.Text = "Tên dịch vụ"
        '
        'TxtTen_DvKhac2
        '
        Me.TxtTen_DvKhac2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DvKhac2.Location = New System.Drawing.Point(110, 58)
        Me.TxtTen_DvKhac2.Name = "TxtTen_DvKhac2"
        Me.TxtTen_DvKhac2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_DvKhac2.TabIndex = 7
        '
        'Labten_Kho2
        '
        Me.Labten_Kho2.Location = New System.Drawing.Point(5, 59)
        Me.Labten_Kho2.Name = "Labten_Kho2"
        Me.Labten_Kho2.Size = New System.Drawing.Size(100, 17)
        Me.Labten_Kho2.TabIndex = 14
        Me.Labten_Kho2.Tag = "English name"
        Me.Labten_Kho2.Text = "Tên tiếng anh"
        '
        'LblTk_DL
        '
        Me.LblTk_DL.Location = New System.Drawing.Point(5, 108)
        Me.LblTk_DL.Name = "LblTk_DL"
        Me.LblTk_DL.Size = New System.Drawing.Size(100, 15)
        Me.LblTk_DL.TabIndex = 39
        Me.LblTk_DL.Tag = "Model car"
        Me.LblTk_DL.Text = "Mã kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(265, 109)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Kx.TabIndex = 38
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.FilterClient = ""
        Me.TxtMa_kx.FilterSQL = ""
        Me.TxtMa_kx.Location = New System.Drawing.Point(110, 106)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kx.TabIndex = 10
        Me.TxtMa_kx.Table_Name = ""
        '
        'TxtDVT
        '
        Me.TxtDVT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDVT.Location = New System.Drawing.Point(110, 82)
        Me.TxtDVT.Name = "TxtDVT"
        Me.TxtDVT.Size = New System.Drawing.Size(149, 21)
        Me.TxtDVT.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 449
        Me.Label5.Tag = "Unit"
        Me.Label5.Text = "Đơn vị tính"
        '
        'TxtGia
        '
        Me.TxtGia.AllowNegative = True
        Me.TxtGia.Flags = 7680
        Me.TxtGia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia.InputMask = "### ### ### ### ###"
        Me.TxtGia.Location = New System.Drawing.Point(319, 243)
        Me.TxtGia.MaxWholeDigits = 14
        Me.TxtGia.Name = "TxtGia"
        Me.TxtGia.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia.TabIndex = 451
        Me.TxtGia.Text = "1"
        Me.TxtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia.Visible = False
        '
        'TxtGia_nt2
        '
        Me.TxtGia_nt2.AllowNegative = True
        Me.TxtGia_nt2.Flags = 7680
        Me.TxtGia_nt2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt2.InputMask = "### ### ### ### ###"
        Me.TxtGia_nt2.Location = New System.Drawing.Point(390, 82)
        Me.TxtGia_nt2.MaxWholeDigits = 14
        Me.TxtGia_nt2.Name = "TxtGia_nt2"
        Me.TxtGia_nt2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt2.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt2.TabIndex = 9
        Me.TxtGia_nt2.Text = "1"
        Me.TxtGia_nt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt
        '
        Me.LabGia_nt.Location = New System.Drawing.Point(309, 83)
        Me.LabGia_nt.Name = "LabGia_nt"
        Me.LabGia_nt.Size = New System.Drawing.Size(80, 18)
        Me.LabGia_nt.TabIndex = 452
        Me.LabGia_nt.Tag = "Price "
        Me.LabGia_nt.Text = "Giá bán"
        '
        'DmDvKhac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 196)
        Me.Controls.Add(Me.TxtGia)
        Me.Controls.Add(Me.TxtGia_nt2)
        Me.Controls.Add(Me.LabGia_nt)
        Me.Controls.Add(Me.TxtDVT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblTk_DL)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.TxtTen_DvKhac2)
        Me.Controls.Add(Me.Labten_Kho2)
        Me.Controls.Add(Me.TxtTen_DvKhac)
        Me.Controls.Add(Me.LabTen_kho)
        Me.Controls.Add(Me.TxtMa_DvKhac)
        Me.Controls.Add(Me.LabMa_PK)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DmDvKhac"
        Me.Text = "Danh mục phụ kiện"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_PK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_DvKhac, 0)
        Me.Controls.SetChildIndex(Me.LabTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DvKhac, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kho2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DvKhac2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.LblTk_DL, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtDVT, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtGia, 0)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_PK As System.Windows.Forms.Label
    Friend WithEvents TxtMa_DvKhac As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_DvKhac As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_DvKhac2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_Kho2 As System.Windows.Forms.Label
    Friend WithEvents LblTk_DL As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtDVT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtGia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia_nt2 As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt As System.Windows.Forms.Label

End Class
