<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMHHGD
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
        Me.TxtTen_GDV = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtSDT_GDV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_MG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSDT_MG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(449, 116)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(347, 116)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(241, 122)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(8, 124)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 106)
        Me.GroupBoxLine.Size = New System.Drawing.Size(547, 9)
        '
        'TxtTen_GDV
        '
        Me.TxtTen_GDV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_GDV.Location = New System.Drawing.Point(110, 11)
        Me.TxtTen_GDV.Name = "TxtTen_GDV"
        Me.TxtTen_GDV.Size = New System.Drawing.Size(431, 21)
        Me.TxtTen_GDV.TabIndex = 0
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(9, 13)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên Giám định"
        '
        'TxtSDT_GDV
        '
        Me.TxtSDT_GDV.ForeColor = System.Drawing.Color.Navy
        Me.TxtSDT_GDV.Location = New System.Drawing.Point(110, 33)
        Me.TxtSDT_GDV.Name = "TxtSDT_GDV"
        Me.TxtSDT_GDV.Size = New System.Drawing.Size(163, 21)
        Me.TxtSDT_GDV.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "SĐT Giám định"
        '
        'TxtTen_MG
        '
        Me.TxtTen_MG.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_MG.Location = New System.Drawing.Point(110, 55)
        Me.TxtTen_MG.Name = "TxtTen_MG"
        Me.TxtTen_MG.Size = New System.Drawing.Size(431, 21)
        Me.TxtTen_MG.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Tag = "Name"
        Me.Label2.Text = "Tên Môi Giới"
        '
        'TxtSDT_MG
        '
        Me.TxtSDT_MG.ForeColor = System.Drawing.Color.Navy
        Me.TxtSDT_MG.Location = New System.Drawing.Point(110, 77)
        Me.TxtSDT_MG.Name = "TxtSDT_MG"
        Me.TxtSDT_MG.Size = New System.Drawing.Size(163, 21)
        Me.TxtSDT_MG.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Tag = "Name"
        Me.Label3.Text = "SĐT Môi giới"
        '
        'DMHHGD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 149)
        Me.Controls.Add(Me.TxtSDT_MG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_MG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSDT_GDV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_GDV)
        Me.Controls.Add(Me.LabTen_BP)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMHHGD"
        Me.Text = "Danh mục Giám định viên - Môi giới"
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_GDV, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSDT_GDV, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_MG, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtSDT_MG, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_GDV As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtSDT_GDV As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtTen_MG As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtSDT_MG As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
