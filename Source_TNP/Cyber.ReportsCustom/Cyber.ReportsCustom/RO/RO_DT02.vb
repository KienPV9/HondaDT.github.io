Public Class RO_DT02
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _DtLoai_Phieu, _DtGroup, _DtGroupct, _DtMa_TT As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Ma_Ct As String = "DT0"
    Dim M_Loai_TH As String = "0"
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        ChkIs_All.Checked = True
        ChkIs_C.Checked = False
        ChkIs_I.Checked = False
        ChkIs_W.Checked = False
        ChkIs_N.Checked = False

        V_Load()
        V_VisibleCT()
        V_Addhander()
        V_LoadMa_GD(New System.Object, New System.EventArgs)
    End Sub
#Region "Load"
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked = True Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.Ma_TT, _DtMa_TT, "Nhom", "Ten_nhom")

        Dim _DsGroup As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTHRO", M_Ma_CT + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _DtGroup = _DsGroup.Tables(0).Copy
        _DtGroupct = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _DtGroup, "Ma", "Ten", "Default")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _DtGroupct, "Ma", "Ten")
        _DsGroup.Dispose()
        '--------------------------------------------------------------------
        '--loai lenh
        Dim _DsLoai_Phieu As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'HDK_HDM_HDP' AND Acti = N'1'#ID")
        _DtLoai_Phieu = _DsLoai_Phieu.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_Phieu, _DtLoai_Phieu, "Nhom", "Ten_nhom")
        _DsLoai_Phieu.Dispose()
        '--------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)
        If TxtMa_KX.Text.Trim = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Kx", "DmKx", "(Ma_kx= N'" + TxtMa_KX.Text.Trim + "')", CyberSmLib)
        If TxtMa_vt.Text.Trim = "" Then TxtTen_vt.Text = "" Else TxtTen_vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmLib)
        If TxtMa_CV.Text.Trim = "" Then TxtTen_CV.Text = "" Else TxtTen_CV.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Cv", "DmCv", "(Ma_cv= N'" + TxtMa_CV.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '
        AddHandler CbbLoai_Phieu.SelectedValueChanged, AddressOf V_LoadMa_GD
        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        '-- nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        '-- nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        '-- nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
        '-- ma cv
        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_cv
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_cv
        '-- nh_cv1
        AddHandler TxtNh_CV1.CyberValiting, AddressOf V_Nh_Cv1
        AddHandler TxtNh_CV1.CyberLeave, AddressOf L_Nh_Cv1
        '-- nh_cv2
        AddHandler TxtNh_CV2.CyberValiting, AddressOf V_Nh_Cv2
        AddHandler TxtNh_CV2.CyberLeave, AddressOf L_Nh_Cv2
        '-- nh_cv3
        AddHandler TxtNh_CV3.CyberValiting, AddressOf V_Nh_Cv3
        AddHandler TxtNh_CV3.CyberLeave, AddressOf L_Nh_Cv3
        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        '-- ma_kx
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx

        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK

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
            'Txtten_nh_Vt1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt1.Text = ""
            'Txtten_nh_Vt1.Text = ""
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
            'Txtten_nh_Vt2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt2.Text = ""
            'Txtten_nh_Vt2.Text = ""
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
            'Txtten_nh_Vt3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt3.Text = ""
            'Txtten_nh_Vt3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_CV"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CV.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Cv", "DmCv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
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
#Region "Valid --- Nh_Cv1"
    Private Sub V_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CV1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhCv", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CV1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CV1.Text = DrReturn.Item("ma_nh")
            'Txtten_nh_Cv1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CV1.Text = ""
            'Txtten_nh_Cv1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Cv2"
    Private Sub V_Nh_Cv2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CV2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhCv", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_Cv2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CV2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CV2.Text = DrReturn.Item("ma_nh")
            'Txtten_nh_Cv2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CV2.Text = ""
            'Txtten_nh_Cv2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Cv3"
    Private Sub V_Nh_Cv3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CV3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhCv", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_Cv3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_CV3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CV3.Text = DrReturn.Item("ma_nh")
            'Txtten_nh_Cv3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CV3.Text = ""
            'Txtten_nh_Cv3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        If CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim = "" Then
            MsgBox("Chưa chọn tổng hợp theo tiêu thức nào", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim = "" Then
            MsgBox("Chưa chọn tiêu thức chi tiết", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByCT.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim.ToUpper = CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim.ToUpper Then
            MsgBox("Hai tiêu thức tổng hợp và chi tiết không thể giống nhau", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_TH_Filter As String = Me.CbbGroupByTH.SelectedValue.ToString.Trim
        Dim M_Ma_TT_Filter As String = Me.Ma_TT.SelectedValue.ToString.Trim
        Dim _Ma_CT_Filter As String = Me.CbbLoai_Phieu.SelectedValue.ToString.Trim
        Dim M_Ma_GD_Filter As String = Me.CbbMa_GD.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = M_TH_Filter
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_All.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_C.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_I.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_N.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_W.Checked, "1", "0")
        ''M_strParameterStore = M_strParameterStore & "#" & M_Ma_TT_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_CT_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_GD_Filter
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CV.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CV1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CV2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CV3.Text.Trim
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
