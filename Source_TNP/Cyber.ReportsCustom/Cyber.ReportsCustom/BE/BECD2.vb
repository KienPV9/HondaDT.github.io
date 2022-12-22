Public Class BECD2
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable
    Private Sub BECD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_Dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function
    Private Sub V_Load()
        CyberFill.V_FillComBoxDefaul(Me.CmbTinh_Dc, _DtGroupBy, "Tinh_dc", "Ten_DC", "Ngam_Dinh")
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kho)
        TxtMa_Kx.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kx)
        TxtMa_Mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Mau)
        TxtSo_Khung.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_Khung)

        TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_kho", "DmKho", "(Ma_Kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmLib)
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "(Ma_KX = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmLib)
        TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauxe", "(Ma_Mau = N'" + TxtMa_Mau.Text.Trim + "')", CyberSmLib)

        TxtNh_Kx1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhKx", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhKx", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kx2.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhKx", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kx3.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        'Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        'Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        'Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1
        'Nh_Kx2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_Kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_Kx2
        'Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_Kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_Kx3
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kho", "DmKho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_Kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx1.Text = "" Then
            TxtTen_Nh_Kx1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh_Kx1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx2"
    Private Sub V_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx2.Text = "" Then
            TxtTen_Nh_Kx2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            TxtTen_Nh_Kx2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx3"
    Private Sub V_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx3.Text = "" Then
            TxtTen_Nh_Kx3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            TxtTen_Nh_Kx3.Text = ""
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
        M_strParameterStore = TxtMa_Kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Khung.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbTinh_Dc.SelectedValue.ToString.Trim
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
