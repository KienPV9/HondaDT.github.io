Public Class BEKhoXeTong
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub SysDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()

        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct.Value = Now.Date
        'TxtM_Ngay_Ct.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx
        '
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        '--VT2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        '--VT3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        '
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx1"
    Private Sub V_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx1.Text = "" Then
            txtten_nhKX1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            txtten_nhKX1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx2"
    Private Sub V_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx2.Text = "" Then
            txtten_nhkx2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            txtten_nhkx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            txtten_nhkx2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx3"
    Private Sub V_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx3.Text = "" Then
            txtten_nhKX3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            txtten_nhKX3.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx3.Text.Trim

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
