Public Class BK_LDN
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _GroupByTH, _GroupByCT As DataTable
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim _DtGroupBy, _Dsstatus1 As DataTable
    Dim CyberVoucher As New Cyber.Voucher.Sys

    Private Sub BH01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'M_Ma_Post1 = Me.Para(Me.VT_PARA + 2).Trim
        'M_Ma_Post2 = Me.Para(Me.VT_PARA + 3).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", "HDI" & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        'txtMa_KX.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, txtMa_KX)
        'TxtMa_mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_mau)

        'If txtMa_KX.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kx", "DmKx", "(Ma_kx = N'" + txtMa_KX.Text.Trim + "')", CyberSmLib)
        'If TxtMa_mau.Text.Trim = "" Then txtTen_Mau.Text = "" Else txtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_mau", "Dmmauxe", "(Ma_mau= N'" + TxtMa_mau.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--bộ phận đề nghị
        AddHandler TxtMa_bp.CyberValiting, AddressOf V_Ma_bp
        AddHandler TxtMa_bp.CyberLeave, AddressOf L_Ma_bp
        '-- loại đề nghị
        AddHandler TxtMa_Loai_DN.CyberValiting, AddressOf V_Ma_Loai_DN
        AddHandler TxtMa_Loai_DN.CyberLeave, AddressOf L_Ma_Loai_DN
        '--Hồ sơ đề nghị
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
        '--Loại giao dịch
        AddHandler TxtMa_GD.CyberValiting, AddressOf V_Ma_GD
        AddHandler TxtMa_GD.CyberLeave, AddressOf L_Ma_GD
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- bộ phận đề nghị"
    Private Sub V_Ma_bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_bp", "dmbp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_bp.Text = DrReturn.Item("Ma_bp")
            TxtTen_bp.Text = DrReturn.Item("Ten_bp")
        Else
            TxtMa_bp.Text = ""
            TxtTen_bp.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Mã GD"
    Private Sub V_Ma_GD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_GD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_bp", "DmMaGD", "Acti = '1' AND Ma_CT = 'LDN'", "1=1")
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_GD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_GD.Text = DrReturn.Item("Ma_GD")
            TxtTen_GD.Text = DrReturn.Item("Ten_GD")
        Else
            TxtMa_GD.Text = ""
            TxtTen_GD.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Hồ sơ"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS.Text = ""
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- loại đề nghị"
    Private Sub V_Ma_Loai_DN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Loai_DN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_DnChi", "DMDNCHI", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Loai_DN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Loai_DN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Loai_DN.Text = DrReturn.Item("Ma_DnChi")
            TxtTen_Loai_DN.Text = DrReturn.Item("Ten_DnChi")
        Else
            TxtMa_Loai_DN.Text = ""
            TxtTen_Loai_DN.Text = ""
            Exit Sub
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
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Loai_DN.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_GD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_DNTT.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
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
