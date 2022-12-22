Imports System.Windows.Forms

Public Class CRMQLKHTN_Chuyen_Doi
#Region "AddProperty"
    Public Property Id_kh() As String
        Get
            Id_kh = M_Id_kh
        End Get
        Set(ByVal Value As String)
            M_Id_kh = Value
        End Set
    End Property
#End Region
    Public _User_name_Return As String = ""
    Dim M_Id_kh As String = ""
    Dim _Dt_UserName As DataTable
    Private Sub CRMQLKHTN_Chuyen_Doi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = "Chuyển đổi nhân viên quản lý"
        AddHandler ButtOK.Click, AddressOf V_Nhan
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQL_Change", Id_kh + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        _Dt_UserName = _DsTmp.Tables(0).Copy
        _DsTmp.Dispose()
        CbbUser_Name.Properties.DataSource = _Dt_UserName
        CbbUser_Name.Properties.DisplayMember = _Dt_UserName.Columns("Comment").ColumnName
        CbbUser_Name.Properties.ValueMember = _Dt_UserName.Columns("User_Name").ColumnName
        CbbUser_Name.CheckAll()
        For i As Integer = 0 To CbbUser_Name.Properties.Items.Count - 1
            If _Dt_UserName.Rows(i).Item("Chk").ToString.Trim = "1" Then CbbUser_Name.Properties.Items(i).CheckState = CheckState.Checked Else CbbUser_Name.Properties.Items(i).CheckState = Not CheckState.Checked
        Next
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _strUserName As String = ""
        For Each Item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In CbbUser_Name.Properties.Items
            If Item.CheckState = CheckState.Checked Then
                _strUserName = _strUserName + ";INSERT DSUserName SELECT N'" + Item.Value.ToString.Trim + "'"
            End If
        Next
        Dim DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQL_SaveChange", M_Id_kh + "#" + _strUserName + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsSave.Tables(0), Me.Sysvar, M_LAN) Then
            DsSave.Dispose()
            Exit Sub
        End If
        ''_User_name_Return = CbbUser_Name.sele
        DsSave.Dispose()
        Me.Close()
    End Sub
End Class
