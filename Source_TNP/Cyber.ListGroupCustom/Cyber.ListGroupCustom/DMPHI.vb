Public Class DMPHI
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMPHI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_Phi.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Phi, TxtNh_Phi1, TxtNh_Phi2, TxtNh_Phi3, TxtNh_Phi4, TxtNh_Phi5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_Phi1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhphi", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Phi1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Phi2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhphi", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Phi2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Phi3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhphi", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Phi3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Phi4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhphi", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Phi4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Phi5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhphi", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Phi5.Text.Trim + "')", CyberSmlib)
        If TxtTen_TK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Phi.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Phi.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Phi1
        RemoveHandler TxtNh_Phi1.CyberValiting, AddressOf V_NH_PHI1
        RemoveHandler TxtNh_Phi1.CyberLeave, AddressOf L_NH_PHI1
        AddHandler TxtNh_Phi1.CyberValiting, AddressOf V_NH_PHI1
        AddHandler TxtNh_Phi1.CyberLeave, AddressOf L_NH_PHI1
        '--Phi2
        RemoveHandler TxtNh_Phi2.CyberValiting, AddressOf V_NH_PHI2
        RemoveHandler TxtNh_Phi2.CyberLeave, AddressOf L_NH_PHI2
        AddHandler TxtNh_Phi2.CyberValiting, AddressOf V_NH_PHI2
        AddHandler TxtNh_Phi2.CyberLeave, AddressOf L_NH_PHI2
        '--Phi3
        RemoveHandler TxtNh_Phi3.CyberValiting, AddressOf V_NH_PHI3
        RemoveHandler TxtNh_Phi3.CyberLeave, AddressOf L_NH_PHI3
        AddHandler TxtNh_Phi3.CyberValiting, AddressOf V_NH_PHI3
        AddHandler TxtNh_Phi3.CyberLeave, AddressOf L_NH_PHI3
        '--Phi4
        RemoveHandler TxtNh_Phi4.CyberValiting, AddressOf V_NH_PHI4
        RemoveHandler TxtNh_Phi4.CyberLeave, AddressOf L_NH_PHI4
        AddHandler TxtNh_Phi4.CyberValiting, AddressOf V_NH_PHI4
        AddHandler TxtNh_Phi4.CyberLeave, AddressOf L_NH_PHI4
        '--Phi5
        RemoveHandler TxtNh_Phi5.CyberValiting, AddressOf V_NH_PHI5
        RemoveHandler TxtNh_Phi5.CyberLeave, AddressOf L_NH_PHI5
        AddHandler TxtNh_Phi5.CyberValiting, AddressOf V_NH_PHI5
        AddHandler TxtNh_Phi5.CyberLeave, AddressOf L_NH_PHI5

        '--TK
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
        '-- Chọn list tài khoản
        AddHandler CmdV_Ma_TK.Click, AddressOf V_Ma_TK_List

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Danh sách tài khoản"
    Private Sub V_Ma_tk_list(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, Me.Sysvar, M_Para, "CP_GetListSelect", "DMTK#" & TxtTk_List.Text.Trim & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        TxtTk_List.Text = str
    End Sub
#End Region
#Region "Vali --- NH_PHI1"
    Private Sub V_NH_PHI1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Phi1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhPHI", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_PHI1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Phi1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Phi1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_PHI2"
    Private Sub V_NH_PHI2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Phi2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhPHI", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_PHI2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Phi2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Phi2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_PHI3"
    Private Sub V_NH_PHI3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Phi3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhPHI", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_PHI3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Phi3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Phi3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_PHI4"
    Private Sub V_NH_PHI4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Phi4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhPHI", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_PHI4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Phi4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Phi4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_PHI5"
    Private Sub V_NH_PHI5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Phi5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhPHI", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_PHI5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Phi5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Phi5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Phi5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Phi5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk.Text = "" Then
            TxtTen_TK.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk.Text = ""
            TxtTen_TK.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Phi.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
