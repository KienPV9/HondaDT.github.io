Public Class BCDV01
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _DtMa_TT, _DtLoai_Phieu, _Dsstatus1 As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub ROHDKBK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_GD = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 5).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
        V_LoadMa_GD(New System.Object, New System.EventArgs)
    End Sub
#Region "Load"
#Region "Chi tiet theo"
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------------------------------------------------------------------------

        Dim _DsLoai_Phieu As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'HDM' AND Acti = N'1'#ID")
        _DtLoai_Phieu = _DsLoai_Phieu.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_Phieu, _DtLoai_Phieu, "Nhom", "Ten_nhom")
        _DsLoai_Phieu.Dispose()

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMa_TT, _DtMa_TT, "Nhom", "Ten_nhom")
        _DsMa_TT.Dispose()

        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)

        Dim _Dsstatus As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_Status", Me.Ma_Dvcs)
        _Dsstatus1 = _Dsstatus.Tables(0).Copy
        _Dsstatus1.Dispose()
        CyberFill.V_FillComBoxValue(Me.CmbStatus, _Dsstatus1, "ma_post", "Ten_post")
        '--------------------------------------------------------------------------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Txtma_kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_kh)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)

        If Txtma_kh.Text.Trim = "" Then TxtTen_kh.Text = "" Else TxtTen_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "(Ma_kh = N'" + Txtma_kh.Text.Trim + "')", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        '-- ma BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        '-- ma xe

        AddHandler Txtma_xe.CyberValiting, AddressOf V_Ma_xe
        AddHandler Txtma_xe.CyberLeave, AddressOf L_Ma_xe
        'AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        'AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe

        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx

        RemoveHandler CbbLoai_Phieu.SelectedValueChanged, AddressOf V_LoadMa_GD
        AddHandler CbbLoai_Phieu.SelectedValueChanged, AddressOf V_LoadMa_GD


        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt

        '-- ma Vt
        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_Cv
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_Cv

        '-- nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        '-- nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        '-- nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3

    End Sub
    Private Sub V_LoadMa_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Ct As String = ""
        Try
            _Ma_Ct = CbbLoai_Phieu.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        CyberMe.V_GetMaGD(AppConn, _Ma_Ct, CbbMa_GD, CyberSmLib, CyberFill)
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Cv"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Cv", "DmCv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Cv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_Cv")
            TxtTen_CV.Text = DrReturn.Item("Ten_Cv")
        Else
            TxtMa_CV.Text = ""
            TxtTen_CV.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("ma_nh")
        Else
            TxtNh_Vt1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("ma_nh")
        Else
            TxtNh_Vt2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("ma_nh")
        Else
            TxtNh_Vt3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_xe", "Dmxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_xe.Text = DrReturn.Item("Ma_xe")
        Else
            Txtma_xe.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BP.Text = "" Then
            TxtTen_BP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value


        Dim _Ma_CT_Filter As String = Me.CbbLoai_Phieu.SelectedValue.ToString.Trim
        Dim _Ma_GD_Filter As String = Me.CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_TT_Filter As String = Me.CbbMa_TT.SelectedValue.ToString.Trim
        Dim _Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim _Ma_Status_Filter As String = Me.CmbStatus.SelectedValue.ToString.Trim
        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim




        Dim M_strParameterStore As String = _Ma_CT_Filter + "#" + _Ma_GD_Filter
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _Ma_TT_Filter
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post2_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Status_Filter
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CV.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Dvcs_Filter
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
