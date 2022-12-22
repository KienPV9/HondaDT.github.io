Public Class IMCD1_VPP
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable
    Private Sub IMCD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function

    Private Sub V_Load()
        CyberFill.V_FillComBoxDefaul(Me.cbbTinh_dc, _DtGroupBy, "Tinh_dc", "Ten_DC", "Ngam_Dinh")
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_kho)
        TxtMa_Cc.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Cc)

        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Cc.Text.Trim = "" Then TxtTen_Cc.Text = "" Else TxtTen_Cc.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Cc", "DmCc", "(Ma_Cc= N'" + TxtMa_Cc.Text.Trim + "')", CyberSmLib)

        If TxtNh_Cc1.Text.Trim = "" Then txtten_nh_cc1.Text = "" Else txtten_nh_cc1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Cc1.Text.Trim + "')", CyberSmLib)
        If TxtNh_Cc2.Text.Trim = "" Then txtten_nh_cc2.Text = "" Else txtten_nh_cc2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Cc2.Text.Trim + "')", CyberSmLib)
        If TxtNh_Cc3.Text.Trim = "" Then txtten_nh_cc3.Text = "" Else txtten_nh_cc3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Cc3.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma_kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo

        '--Ma_Cc
        AddHandler TxtMa_Cc.CyberValiting, AddressOf V_Ma_Cc
        AddHandler TxtMa_Cc.CyberLeave, AddressOf L_Ma_Cc
        '-- Tk vt
        AddHandler TxtTk_Cc.CyberValiting, AddressOf V_Tk_Cc
        AddHandler TxtTk_Cc.CyberLeave, AddressOf L_Tk_Cc
        '--Vt1
        RemoveHandler TxtNh_Cc1.CyberValiting, AddressOf V_NH_Cc1
        RemoveHandler TxtNh_Cc1.CyberLeave, AddressOf L_NH_Cc1
        AddHandler TxtNh_Cc1.CyberValiting, AddressOf V_NH_Cc1
        AddHandler TxtNh_Cc1.CyberLeave, AddressOf L_NH_Cc1
        '--VT2
        RemoveHandler TxtNh_Cc2.CyberValiting, AddressOf V_NH_Cc2
        RemoveHandler TxtNh_Cc2.CyberLeave, AddressOf L_NH_Cc2
        AddHandler TxtNh_Cc2.CyberValiting, AddressOf V_NH_Cc2
        AddHandler TxtNh_Cc2.CyberLeave, AddressOf L_NH_Cc2
        '--VT3
        RemoveHandler TxtNh_Cc3.CyberValiting, AddressOf V_NH_Cc3
        RemoveHandler TxtNh_Cc3.CyberLeave, AddressOf L_NH_Cc3
        AddHandler TxtNh_Cc3.CyberValiting, AddressOf V_NH_Cc3
        AddHandler TxtNh_Cc3.CyberLeave, AddressOf L_NH_Cc3
    End Sub


#End Region
#Region "Valid"
#Region "Valid --- Ma_KHo"
    Private Sub V_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KHo", "DmKHo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Cc"
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cc.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Cc", "DmCc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cc.Text = DrReturn.Item("Ma_Cc")
            TxtTen_Cc.Text = DrReturn.Item("Ten_Cc")
        Else
            TxtMa_Cc.Text = ""
            TxtTen_Cc.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---TK_Cc"
    Private Sub V_Tk_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Cc.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Cc.Text = DrReturn.Item("tk0")
            txtten_tk_cc.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk_Cc.Text = ""
            txtten_tk_cc.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_Cc1"
    Private Sub V_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhCc", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Cc1.Text = "" Then
            txtten_nh_cc1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cc1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc1.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_cc1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc1.Text = ""
            txtten_nh_cc1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Cc2"
    Private Sub V_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhCc", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Cc2.Text = "" Then
            txtten_nh_cc2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cc2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc2.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_cc2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc2.Text = ""
            txtten_nh_cc2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Cc3"
    Private Sub V_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Cc3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhCc", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Cc3.Text = "" Then
            txtten_nh_cc3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cc3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc3.Text = DrReturn.Item("Ma_Nh")
            txtten_nh_cc3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc3.Text = ""
            txtten_nh_cc3.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = ""
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cc.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Cc.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & cbbTinh_dc.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup1.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup2.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & If(ChkGroup3.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & Me.Para(Me.VT_PARA + 1).ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
