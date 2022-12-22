Public Class RO_DTDVGT
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _DtLoai_Phieu, _Dt_GD, _Dt_post1, _Dt_post2, _DtGroup, _DtGroupct, _DtMa_TT As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 4).Trim
        ChkIs_All.Checked = True
        ChkIs_C.Checked = False
        ChkIs_I.Checked = False
        ChkIs_W.Checked = False
        ChkIs_N.Checked = False

        TxtNh_CtCv1.Text = Me.Para(Me.VT_PARA + 5).Trim

        V_AddMenuShorcut()
        V_Load()
        ' V_VisibleCT()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------


        'Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        '_DtMa_TT = _DsMa_TT.Tables(0).Copy
        'CyberFill.V_FillComBoxDefaul(Me.Ma_TT, _DtMa_TT, "Nhom", "Ten_nhom")

        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy

        Dim _Ma_Post_Min As String = _Dt_post1.Rows(0).Item("Ma_Post")
        Dim _Ma_Post_Max As String = _Dt_post2.Rows(_Dt_post2.Rows.Count - 1).Item("Ma_Post")

        If _Dt_post1.Select("Ma_Post = '" + M_Ma_Post1.Trim + "'").Length = 0 Then M_Ma_Post1 = _Ma_Post_Min
        If _Dt_post2.Select("Ma_Post = '" + M_Ma_Post2.Trim + "'").Length = 0 Then M_Ma_Post2 = _Ma_Post_Max

        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)
        '--------------------------------------------------------------------

        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)


        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_hs", "Dmhs", "(Ma_hs = N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)
        If TxtNh_CtCv1.Text.Trim = "" Then TxtTen_Nh_Cv1.Text = "" Else TxtTen_Nh_Cv1.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_nh", "DmNhcv", "(loai_nh = 1 AND Ma_nh = N'" + TxtNh_CtCv1.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)

    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        '-- Nh_Cv1
        AddHandler TxtNh_CtCv1.CyberValiting, AddressOf V_Nh_Cv1
        AddHandler TxtNh_CtCv1.CyberLeave, AddressOf L_Nh_Cv1

        AddHandler ChkIs_All.Click, AddressOf V_Is_All
        AddHandler ChkIs_C.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_I.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_N.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_W.Click, AddressOf V_Ma_TT

    End Sub
    Private Sub V_Is_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkIs_All.Checked Then
            ChkIs_C.Checked = False
            ChkIs_I.Checked = False
            ChkIs_N.Checked = False
            ChkIs_W.Checked = False
        Else
            If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
                ChkIs_C.Checked = True
            End If
        End If
    End Sub
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
            ChkIs_C.Checked = True
        End If
        ChkIs_All.Checked = False
        'If ChkIs_C.Checked And ChkIs_I.Checked And ChkIs_N.Checked And ChkIs_W.Checked Then
        '    ChkIs_All.Checked = False
        'End If
    End Sub
#End Region
#Region "Valid"
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
#Region "Vali --- Nh_Cv1"
    Private Sub V_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CtCv1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCtCV", "Loai_Nh=1", "1=1")
    End Sub
    Private Sub L_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CtCv1.Text = "" Then
            TxtTen_Nh_Cv1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CtCv1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtNh_CtCv1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Cv1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CtCv1.Text = ""
            TxtTen_Nh_Cv1.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        'Dim M_Ma_TT_Filter As String = Me.Ma_TT.SelectedValue.ToString.Trim
        Dim M_Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim M_Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        'M_strParameterStore = M_strParameterStore & "#" & M_Ma_TT_Filter
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_All.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_C.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_I.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_N.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_W.Checked, "1", "0")

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CtCv1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post2_Filter
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
