Public Class DMDMNL
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMDMNL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_kx.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKX", "(Ma_kx = N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        If TxtMa_vt.Text.Trim = "" Then TxtTen_vt.Text = "" Else TxtTen_vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vt", "Dmvt", "(Ma_vt = N'" + TxtMa_vt.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
#End Region
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        '--Ma_Kx
        RemoveHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_Kx

        '--Ma_vt
        RemoveHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        RemoveHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_kx.Text = "" Then
            TxtTen_kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("Ma_kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX1"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_vt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If TxtMa_vt.Text = "" Then
            TxtTen_vt.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
