<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMQLKHTN_Chuyen_Doi
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
        Me.CbbUser_Name = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        CType(Me.CbbUser_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 248)
        Me.GroupBoxLine.Size = New System.Drawing.Size(800, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(600, 258)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(702, 258)
        '
        'CbbUser_Name
        '
        Me.CbbUser_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbUser_Name.EditValue = ""
        Me.CbbUser_Name.Location = New System.Drawing.Point(1, 0)
        Me.CbbUser_Name.Name = "CbbUser_Name"
        Me.CbbUser_Name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CbbUser_Name.Properties.Appearance.Options.UseFont = True
        Me.CbbUser_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.CbbUser_Name.Properties.DropDownRows = 30
        Me.CbbUser_Name.Size = New System.Drawing.Size(800, 26)
        Me.CbbUser_Name.TabIndex = 2089
        '
        'CRMQLKHTN_Chuyen_Doi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(804, 312)
        Me.Controls.Add(Me.CbbUser_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CRMQLKHTN_Chuyen_Doi"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbUser_Name, 0)
        CType(Me.CbbUser_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbUser_Name As DevExpress.XtraEditors.CheckedComboBoxEdit

End Class
