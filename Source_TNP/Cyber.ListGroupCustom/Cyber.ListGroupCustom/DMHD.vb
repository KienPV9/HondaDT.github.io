Public Class DMHD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_HD.Value = Now.Date
        TxtNgay_HD1.Value = Now.Date
        TxtNgay_HD2.Value = Now.Date
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_HD, TxtNh_HD1, TxtNh_HD2, TxtNh_HD3, TxtNh_HD4, TxtNh_HD5)
        TxtMa_HD.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_HD1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_HD1.Text.Trim + "')", CyberSmlib)
        If TxtNh_HD2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_HD2.Text.Trim + "')", CyberSmlib)
        If TxtNh_HD3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_HD3.Text.Trim + "')", CyberSmlib)
        If TxtNh_HD4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_HD4.Text.Trim + "')", CyberSmlib)
        If TxtNh_HD5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_HD5.Text.Trim + "')", CyberSmlib)

        If TxtMa_KH.Text.Trim.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)
        If TxtMa_BpKD.Text.Trim = "" Then TxtTen_BpKD.Text = "" Else TxtTen_BpKD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_bp", "Dmbp", "(Ma_Bp = N'" + TxtMa_BpKD.Text.Trim + "')", CyberSmlib)
        If TxtMa_HSKD.Text.Trim = "" Then TxtTen_HSKD.Text = "" Else TxtTen_HSKD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_HSKD.Text.Trim + "')", CyberSmlib)
        If Txtma_BpTH.Text.Trim = "" Then TxtTen_BpTH.Text = "" Else TxtTen_BpTH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_bp", "Dmbp", "(Ma_bp = N'" + Txtma_BpTH.Text.Trim + "')", CyberSmlib)
        If TxtMa_HSTH.Text.Trim = "" Then TxtTen_HSTH.Text = "" Else TxtTen_HSTH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_HSTH.Text.Trim + "')", CyberSmlib)



        If Me.Mode.ToString.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Dim Dt As Date = TxtNgay_HD1.Value
        Dim Dt1 As Date = TxtNgay_HD1.Value
        Dim Dt2 As Date = TxtNgay_HD1.Value

        If Dt1.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_HD.Value = Now.Date
        If Dt1.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_HD1.Value = Now.Date
        If Dt2.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_HD2.Value = Now.Date
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_HD.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_HD.KeyPress, AddressOf TxtCodeError_KeyPress
        '--HD1
        RemoveHandler TxtNh_HD1.CyberValiting, AddressOf V_NH_HD1
        RemoveHandler TxtNh_HD1.CyberLeave, AddressOf L_NH_HD1
        AddHandler TxtNh_HD1.CyberValiting, AddressOf V_NH_HD1
        AddHandler TxtNh_HD1.CyberLeave, AddressOf L_NH_HD1
        '--HD2
        RemoveHandler TxtNh_HD2.CyberValiting, AddressOf V_NH_HD2
        RemoveHandler TxtNh_HD2.CyberLeave, AddressOf L_NH_HD2
        AddHandler TxtNh_HD2.CyberValiting, AddressOf V_NH_HD2
        AddHandler TxtNh_HD2.CyberLeave, AddressOf L_NH_HD2
        '--HD3
        RemoveHandler TxtNh_HD3.CyberValiting, AddressOf V_NH_HD3
        RemoveHandler TxtNh_HD3.CyberLeave, AddressOf L_NH_HD3
        AddHandler TxtNh_HD3.CyberValiting, AddressOf V_NH_HD3
        AddHandler TxtNh_HD3.CyberLeave, AddressOf L_NH_HD3
        '--HD4
        RemoveHandler TxtNh_HD4.CyberValiting, AddressOf V_NH_HD4
        RemoveHandler TxtNh_HD4.CyberLeave, AddressOf L_NH_HD4
        AddHandler TxtNh_HD4.CyberValiting, AddressOf V_NH_HD4
        AddHandler TxtNh_HD4.CyberLeave, AddressOf L_NH_HD4
        '--HD5
        RemoveHandler TxtNh_HD5.CyberValiting, AddressOf V_NH_HD5
        RemoveHandler TxtNh_HD5.CyberLeave, AddressOf L_NH_HD5
        AddHandler TxtNh_HD5.CyberValiting, AddressOf V_NH_HD5
        AddHandler TxtNh_HD5.CyberLeave, AddressOf L_NH_HD5
        '--MA_KH
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH

        '--MA_BPKD
        RemoveHandler TxtMa_BpKD.CyberValiting, AddressOf V_Ma_BPKD
        RemoveHandler TxtMa_BpKD.CyberLeave, AddressOf L_Ma_BPKD
        AddHandler TxtMa_BpKD.CyberValiting, AddressOf V_Ma_BPKD
        AddHandler TxtMa_BpKD.CyberLeave, AddressOf L_Ma_BPKD
        '--MA_HSKD
        RemoveHandler TxtMa_HSKD.CyberValiting, AddressOf V_MA_HSKD
        RemoveHandler TxtMa_HSKD.CyberLeave, AddressOf L_MA_HSKD
        AddHandler TxtMa_HSKD.CyberValiting, AddressOf V_MA_HSKD
        AddHandler TxtMa_HSKD.CyberLeave, AddressOf L_MA_HSKD
        '--MA_BPTH
        RemoveHandler Txtma_BpTH.CyberValiting, AddressOf V_MA_BPTH
        RemoveHandler Txtma_BpTH.CyberLeave, AddressOf L_MA_BPTH
        AddHandler Txtma_BpTH.CyberValiting, AddressOf V_MA_BPTH
        AddHandler Txtma_BpTH.CyberLeave, AddressOf L_MA_BPTH
        '--MA_HSTH
        RemoveHandler TxtMa_HSTH.CyberValiting, AddressOf V_MA_HSTH
        RemoveHandler TxtMa_HSTH.CyberLeave, AddressOf L_MA_HSTH
        AddHandler TxtMa_HSTH.CyberValiting, AddressOf V_MA_HSTH
        AddHandler TxtMa_HSTH.CyberLeave, AddressOf L_MA_HSTH
        '--MA_NT
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_MA_NT
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_MA_NT
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_MA_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_MA_NT



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_HD1"
    Private Sub V_NH_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD2"
    Private Sub V_NH_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD3"
    Private Sub V_NH_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD4"
    Private Sub V_NH_HD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_HD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD5"
    Private Sub V_NH_HD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_HD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BPKD"
    Private Sub V_Ma_BPKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BpKD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BPKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_BpKD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BpKD.Text = DrReturn.Item("Ma_BP")
            TxtTen_BpKD.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BpKD.Text = ""
            TxtTen_BpKD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_HSKD"
    Private Sub V_MA_HSKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HSKD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_MA_HSKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HSKD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HSKD.Text = DrReturn.Item("Ma_HS")
            TxtTen_HSKD.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HSKD.Text = ""
            TxtTen_HSKD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_BPTH"
    Private Sub V_MA_BPTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_BpTH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_MA_BPTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = Txtma_BpTH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_BpTH.Text = DrReturn.Item("Ma_BP")
            TxtTen_BpTH.Text = DrReturn.Item("Ten_BP")
        Else
            Txtma_BpTH.Text = ""
            TxtTen_BpTH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_HSTH"
    Private Sub V_MA_HSTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HSTH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_MA_HSTH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HSTH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HSTH.Text = DrReturn.Item("Ma_HS")
            TxtTen_HSTH.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HSTH.Text = ""
            TxtTen_HSTH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- MA_NT"
    Private Sub V_MA_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NT", "DMNT", "1=1", "1=1")
    End Sub
    Private Sub L_MA_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
        Else
            TxtMa_NT.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_HD.Text = _Value
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