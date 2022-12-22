Imports System.Windows.Forms

Public Class DMSC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim EditMa_Vitri, EditMa_Vt, EditMa_CV, EditMa_NVKD, EditTen_Vt, EditTen_Vt3, EditDVt, EditMa_kho_i, EditTon13, EditTen_kho_i, EditMa_TT, _
          EditMa_Vv_i, EditMa_Hd_i, EditMa_phi_I, EditMa_Sp_i, EditMa_ku_I, EditMa_TTLN_I, EditMa_TTCP_I, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditTien2, EditGia2 As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TD1_i, EditMa_TD2_i, EditMa_TD3_i, EditMa_TD4_i, EditMa_TD5_i As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_CVCv, EditTen_CVCv, EditTen_CV3Cv, EditMa_TTCv, EditMa_CtcvCv, EditGio_TCCV, EditGia_CVCV, EditTien_CVCv, EditPT_Ck_ICv, EditCk_ICv, EditThue_SuatCv, _
        EditThueCV, EditMa_KTV_ICv, EditLANCv As New Cyber.Fill.CyberColumnGridView


    Dim DT_DetailTmp, DT_DetailCVTmp, Dt_HeadVT, Dt_HeadCV, Dt_DmCt As DataTable
    Dim Dv_DetailTmp, Dv_DetailCVTmp, Dv_HeadVT, Dv_HeadCV, Dv_DmCt As DataView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT As String = "C"
    Dim Lan As String = "V"
    Dim Ma_SCOld, Ma_DvcsOld As String
    Private Sub DMSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        V_GetColumn()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        V_MainSystem()
        V_MainSystemCv()

        V_AddHandler_Detail()
        V_AddHandMaster()
        UpdateList()
        If Mode = "M" Then
            Ma_SCOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_SCOld = TxtMa_SC.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kx", "DmKx", "( Ma_kx = N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCTSC", TxtMa_SC.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailTmp = DsTmp.Tables(0).Copy
        DT_DetailCVTmp = DsTmp.Tables(1).Copy
        Dt_HeadVT = DsTmp.Tables(2).Copy
        Dt_HeadCV = DsTmp.Tables(3).Copy
        Dt_DmCt = DsTmp.Tables(4).Copy

        Dv_DetailTmp = New DataView(DT_DetailTmp)
        Dv_DetailCVTmp = New DataView(DT_DetailCVTmp)
        Dv_HeadVT = New DataView(Dt_HeadVT)
        Dv_HeadCV = New DataView(Dt_HeadCV)
        Dv_DmCt = New DataView(Dt_DmCt)


        '========= FillData to Gridview Vt
        DetailVt.DataSource = Dv_DetailTmp
        Me.DetailGRVVt.GridControl = Me.DetailVt
        CyberFill.V_FillVoucher(DetailGRVVt, M_LAN, Dv_HeadVT, Dv_DetailTmp, Dt_DmCt.Rows(0))
        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCVTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, Dv_HeadCV, Dv_DetailCVTmp, Dt_DmCt.Rows(0))

        If Me.Mode = "M" Then CmbCap_SC.SelectedValue = "0"
        If CmbCap_SC.Text.Trim = "" Then CmbCap_SC.SelectedValue = "0"
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsManl As New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVVt.GridControl.ContextMenu = mnItemsMail
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub V_MainSystemCv()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItemCv, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItemCv, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub MasterGRVCv_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

    End Sub
    Private Sub CreateTabe()
       
        Dim DtTCap_SC As New DataTable

        DtTCap_SC.Columns.Add("Cap_SC", GetType(String))
        DtTCap_SC.Columns.Add("Ten", GetType(String))
        DtTCap_SC.Rows.Add("1", IIf(M_LAN = "V", "Bảo dưỡng 1K", "Account is correct warehouse"))
        DtTCap_SC.Rows.Add("2", IIf(M_LAN = "V", "Bảo dưỡng cấp nhỏ", "Account is correct warehouse"))
        DtTCap_SC.Rows.Add("3", IIf(M_LAN = "V", "Bảo dưỡng cấp trung bình", "Account is correct warehouse"))
        DtTCap_SC.Rows.Add("4", IIf(M_LAN = "V", "Bảo dưỡng cấp trung bình nhỏ", "Account is correct warehouse"))
        DtTCap_SC.Rows.Add("5", IIf(M_LAN = "V", "Bảo dưỡng cấp lớn", "Account is correct warehouse"))
        CyberFill.V_FillComBoxDefaul(Me.CmbCap_SC, DtTCap_SC, "Cap_sc", "Ten")

    End Sub
    Private Sub V_GetColumn()
        EditMa_Vitri.GetColumn(DetailGRVVt, "Ma_vitri")
        EditMa_NVKD.GetColumn(Me.DetailGRVVt, "Ma_NVKD")
        EditMa_Vt.GetColumn(Me.DetailGRVVt, "Ma_Vt")
        EditMa_CV.GetColumn(Me.DetailGRVVt, "Ma_CV")

        EditTen_Vt.GetColumn(Me.DetailGRVVt, "Ten_Vt")
        EditTen_Vt3.GetColumn(Me.DetailGRVVt, "Ten_Vt3")
        EditDVt.GetColumn(Me.DetailGRVVt, "DVT")
        EditTon13.GetColumn(Me.DetailGRVVt, "Ton13")
        EditMa_kho_i.GetColumn(Me.DetailGRVVt, "Ma_kho_I")
        EditTen_kho_i.GetColumn(Me.DetailGRVVt, "Ten_kho_I")
        EditMa_TT.GetColumn(Me.DetailGRVVt, "Ma_TT")

        EditMa_Vv_i.GetColumn(DetailGRVVt, "Ma_Vv_I")
        EditMa_phi_I.GetColumn(DetailGRVVt, "Ma_Phi_I")
        EditMa_Hd_i.GetColumn(DetailGRVVt, "Ma_HD_I")
        EditMa_Sp_i.GetColumn(DetailGRVVt, "Ma_SP_I")
        EditMa_ku_I.GetColumn(DetailGRVVt, "Ma_KU_I")
        EditMa_TTLN_I.GetColumn(DetailGRVVt, "Ma_TTLN_I")
        EditMa_TTCP_I.GetColumn(DetailGRVVt, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRVVt, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRVVt, "Ma_Hs_I")
        EditMa_CD_I.GetColumn(DetailGRVVt, "Ma_CD_I")

        EditMa_TD1_i.GetColumn(DetailGRVVt, "Ma_TD1_I")
        EditMa_TD2_i.GetColumn(DetailGRVVt, "Ma_TD2_I")
        EditMa_TD3_i.GetColumn(DetailGRVVt, "Ma_TD3_I")
        EditMa_TD4_i.GetColumn(DetailGRVVt, "Ma_TD4_I")
        EditMa_TD5_i.GetColumn(DetailGRVVt, "Ma_TD5_I")

        EditSo_Luong.GetColumn(Me.DetailGRVVt, "So_luong")
        EditGia2.GetColumn(Me.DetailGRVVt, "Gia2")
        EditTien2.GetColumn(Me.DetailGRVVt, "Tien2")

        '---------------------------------------------------------------------------------
        ' Cong Viec
        EditMa_CVCv.GetColumn(Me.DetailGRVCv, "Ma_CV")
        EditTen_CVCv.GetColumn(Me.DetailGRVCv, "Ten_Cv")
        EditTen_CV3Cv.GetColumn(Me.DetailGRVCv, "Ten_Cv3")
        EditMa_TTCv.GetColumn(Me.DetailGRVCv, "Ma_TT")
        EditMa_CtcvCv.GetColumn(Me.DetailGRVCv, "Ma_Ctcv")

        EditGio_TCCV.GetColumn(Me.DetailGRVCv, "Gio_TC")
        EditGia_CVCV.GetColumn(Me.DetailGRVCv, "Gia_CV")
        EditTien_CVCv.GetColumn(Me.DetailGRVCv, "Tien_CV")

        EditPT_Ck_ICv.GetColumn(Me.DetailGRVCv, "PT_Ck_I")
        EditCk_ICv.GetColumn(Me.DetailGRVCv, "Ck_I")

        EditThue_SuatCv.GetColumn(Me.DetailGRVCv, "Thue_Suat")
        EditThueCV.GetColumn(Me.DetailGRVCv, "Thue")
        EditMa_KTV_ICv.GetColumn(Me.DetailGRVCv, "Ma_Ktv_I")
        EditLANCv.GetColumn(Me.DetailGRVCv, "LAN")
    End Sub
    Private Sub V_AddHandMaster()
        AddHandler DetailGRVVt.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRVCv.PopupMenuShowing, AddressOf MasterGRVCv_PopupMenuShowing
        AddHandler DetailGRVVt.KeyDown, AddressOf MasterGRV_KeyDown
        AddHandler DetailGRVCv.KeyDown, AddressOf MasterGRVCv_KeyDown

        AddHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx
        '--
        AddHandler TxtMa_NhomSC.CyberValiting, AddressOf V_Ma_NHSC
        AddHandler TxtMa_NhomSC.CyberLeave, AddressOf L_Ma_NHSC
    End Sub
    Private Sub V_AddHandler_Detail()
        EditTen_Vt.ColumnReadOnly = True
        EditDVt.ColumnReadOnly = True

        EditMa_Vt.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)

        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditTien2.Column Is Nothing Then AddHandler EditTien2.EditColumn.Leave, AddressOf V_Tinh_ToanPT

        'If Not EditPt_Ck_i.Column Is Nothing Then AddHandler EditPt_Ck_i.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        'If Not EditCk_i.Column Is Nothing Then AddHandler EditCk_i.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        'If Not EditThue_Suat.Column Is Nothing Then AddHandler EditThue_Suat.EditColumn.Leave, AddressOf V_Tinh_ToanPT



        'EditMa_CV.V_ActiLookUpColumn(AddressOf V_Ma_CvVt, AddressOf L_Ma_CvVt)
        'EditMa_TT.V_ActiLookUpColumn(AddressOf V_Ma_TT, AddressOf L_Ma_TT)

        '---Add On
        '================== Coong viec
        EditTen_CVCv.ColumnReadOnly = False
        EditLANCv.ColumnReadOnly = True

        If Not EditGio_TCCV.Column Is Nothing Then AddHandler EditGio_TCCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditGia_CVCV.Column Is Nothing Then AddHandler EditGia_CVCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_CVCv.Column Is Nothing Then AddHandler EditTien_CVCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        'If Not EditPT_Ck_ICv.Column Is Nothing Then AddHandler EditPT_Ck_ICv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        'If Not EditCk_ICv.Column Is Nothing Then AddHandler EditCk_ICv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        'If Not EditThue_SuatCv.Column Is Nothing Then AddHandler EditThue_SuatCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        'If Not EditPT_Ck_ICv.Column Is Nothing Then AddHandler EditPT_Ck_ICv.EditColumn.Enter, AddressOf E_CK_CV
        'If Not EditCk_ICv.Column Is Nothing Then AddHandler EditCk_ICv.EditColumn.Enter, AddressOf E_CK_CV
        'If Not EditPt_Ck_i.Column Is Nothing Then AddHandler EditPt_Ck_i.EditColumn.Enter, AddressOf E_CK_VT
        'If Not EditCk_i.Column Is Nothing Then AddHandler EditCk_i.EditColumn.Enter, AddressOf E_CK_VT

        EditMa_CVCv.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        EditMa_CtcvCv.V_ActiLookUpColumn(AddressOf V_Ma_CtCv, AddressOf L_Ma_CtCv)
        'EditMa_TTCv.V_ActiLookUpColumn(AddressOf V_Ma_TTCV, AddressOf L_Ma_TTCV)
        'EditMa_KTV_ICv.V_ActiLookUpColumn(AddressOf V_Ma_KTV_ICV, AddressOf L_Ma_KTV_ICV)

    End Sub
    Private Sub UpdateList()
        Dim nT_CV As Decimal = 0
        Dim nT_Tien2 As Decimal = 0
        Dim nT_Gio_TC As Decimal = 0

        For i As Integer = 0 To DT_DetailCVTmp.Rows.Count - 1
            nT_CV = nT_CV + DT_DetailCVTmp.Rows(i).Item("Tien_CV")
            nT_Gio_TC = nT_Gio_TC + DT_DetailCVTmp.Rows(i).Item("Gio_TC")
        Next
        For i As Integer = 0 To DT_DetailTmp.Rows.Count - 1
            nT_Tien2 = nT_Tien2 + DT_DetailTmp.Rows(i).Item("Tien2")
        Next
        TxtT_CV.Double = nT_CV
        TxtT_Tien2.Double = nT_Tien2
        TxtTong_Cong.Double = nT_CV + nT_Tien2
        TxtTong_Gio.Double = nT_Gio_TC
    End Sub
#End Region
#Region "Valid"
#Region "F4/F8-Vat tu"
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailTmp
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadVT)
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVVt, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, Appconn) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
#Region "Ma_Vt"
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(Me.Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
    End Sub
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Vt", "DmVt", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_vt") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_VT") = ""
            Dv_DetailTmp.Item(iRow).Item("Dvt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_VT As String = "", _DVT As String = "", _Ten_VT As String = ""
        Dim _Gia2 As Decimal = 0

        _Ma_VT = DrReturn("Ma_vt").ToString.Trim
        _Ten_VT = DrReturn("Ten_VT").ToString.Trim
        _DVT = DrReturn("DVT").ToString.Trim

        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Vt") = _Ma_VT
        Dv_DetailTmp.Item(iRow).Item("Ten_vt") = _Ten_VT
        Dv_DetailTmp.Item(iRow).Item("DVT") = _DVT
        Dv_DetailTmp.Item(iRow).EndEdit()

        '-----------------------------------------------------------------------------------------------------------
        Tinh_Gia2(iRow)
        Tinh_TienPT(iRow)
        UpdateList()
        '-----------------------------------------------------------------------------------------------------------
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub Tinh_Gia2(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub

        Dim _Gia2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia2")
        Dim _Ma_vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt")
        Dim _Ma_Kho As String = ""
        Dim _Ngay_Ct As Date = Now.Date
        '-----------------------------------------------------------------------------------------------------------
        Dim dsGia2 As New DataSet
        dsGia2 = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetHDKGia2", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT.Trim & "#" & "" & "#" & Me.Mode & "#" & _
                                                    "S" & "#" & "2" & "#" & _Ma_vt.Trim & "#" & _Ma_Kho.Trim + "#" & M_Ma_TT & "#" & _
                                                    _Gia2.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)
        _Gia2 = dsGia2.Tables(0).Rows(0).Item("Gia2")
        dsGia2.Dispose()
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Gia2") = _Gia2
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub Tinh_TienPT(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 1
        nTy_Gia = 1
        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2"), 0)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanPT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailTmp.AcceptChanges()
        Tinh_TienPT(iRow)
    End Sub
#End Region
#Region "F4/F8-Cong Viec"
#End Region
    Private Sub V_ShortAddItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItemCv(iRow)
        iRow = Dv_DetailCVTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
    End Sub
    Private Sub V_AddItemCv(Optional ByVal iRow As Integer = -1)

        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailCVTmp

        '===================================
        If iRow > 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadCV)
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCVTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCv(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCVTmp, Appconn) Then Exit Sub
        Dv_DetailCVTmp.Delete(iRow)
        Dv_DetailCVTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRVCv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCv(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
#Region "CV"
    Private Sub V_Tinh_ToanCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailCVTmp.AcceptChanges()
        Tinh_TienCV(iRow)
    End Sub
    Private Sub Tinh_TienCV(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 0
        nTy_Gia = 1
        'Chiet Khau---------------------------------------------------------------------------------------
        'Tinh Tiền Cong viec ---------------------------------------------------------------------------------------
        If Dv_DetailCVTmp.Table.Columns.Contains("Gia_CV") And Dv_DetailCVTmp.Table.Columns.Contains("Gio_TC") And Dv_DetailCVTmp.Table.Columns.Contains("Tien_CV") Then
            If Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCVTmp.Item(iRow).Item("Gio_TC") <> 0 Then
                Dv_DetailCVTmp.Item(iRow).BeginEdit()
                Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCVTmp.Item(iRow).Item("Gio_TC"), 0)
                Dv_DetailCVTmp.Item(iRow).EndEdit()
            End If
        End If
        '---------- Tinh thue
        UpdateList()
    End Sub
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCVTmp.Item(iRow).Item("Ma_Cv") = ""
            Dv_DetailCVTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailCVTmp.Item(iRow).EndEdit()
            DetailGRVVt.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_DetailCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCVTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        Dv_DetailCVTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv").ToString.Trim
        If DrReturn.Table.Columns.Contains("Gio_TC") Then
            If Dv_DetailCVTmp.Table.Columns.Contains("Gio_TC") Then
                Dv_DetailCVTmp.Item(iRow).Item("Gio_TC") = IIf(Dv_DetailCVTmp.Item(iRow).Item("Gio_TC") <> 0, Dv_DetailCVTmp.Item(iRow).Item("Gio_TC"), DrReturn("Gio_TC"))
            End If
        End If

        If DrReturn.Table.Columns.Contains("Gia_CV") Then
            If Dv_DetailCVTmp.Table.Columns.Contains("Gia_CV") Then
                Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") = IIf(Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") <> 0, Dv_DetailCVTmp.Item(iRow).Item("Gia_CV"), DrReturn("Gia_CV"))
            End If
        End If

        Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") = IIf(Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") <> 0, Dv_DetailCVTmp.Item(iRow).Item("Tien_CV"), DrReturn("Tien_CV"))
        Dv_DetailCVTmp.Item(iRow).EndEdit()
        Tinh_TienCV(iRow)
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCVTmp.Item(iRow)("Ma_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCVTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") = IIf(Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") <> 0, Dv_DetailCVTmp.Item(iRow).Item("Tien_CV"), DrReturn("Tien_CV"))
        Dv_DetailCVTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"

    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("Ma_kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_kx.Text = ""
        End If
    End Sub
    Private Sub V_Ma_NHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DmNhSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NhomSC.Text = DrReturn.Item("Ma_nh")
        Else
            TxtMa_kx.Text = ""
        End If
    End Sub

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_SC.Text = _Value

        CyberSmodb.AddValueToRow(Me.DrNew, Me)

        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        Dim nCount As Integer = 0
        nCount = DT_DetailTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            If DT_DetailTmp.Rows(i).Item("Ma_VT").ToString.Trim = "" Then
                DT_DetailTmp.Rows(i).Delete()
                DT_DetailTmp.AcceptChanges()
            End If
        Next

        nCount = DT_DetailCVTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            If DT_DetailCVTmp.Rows(i).Item("Ma_CV").ToString.Trim = "" Then
                DT_DetailCVTmp.Rows(i).Delete()
                DT_DetailCVTmp.AcceptChanges()
            End If
        Next
        If DT_DetailTmp.Rows.Count = 0 And DT_DetailCVTmp.Rows.Count = 0 Then
            MsgBox("Bạn chưa nhập liệu chi tiết gói công việc hoặc vật tư phụ tùng thay thế", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If
        '=====================================
        For i = 0 To DT_DetailTmp.Rows.Count - 1
            DT_DetailTmp.Rows(i).BeginEdit()
            DT_DetailTmp.Rows(i).Item("Ma_Sc") = TxtMa_SC.Text.Trim
            DT_DetailTmp.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailTmp.Rows(i).EndEdit()
        Next
        For i = 0 To DT_DetailCVTmp.Rows.Count - 1
            DT_DetailCVTmp.Rows(i).BeginEdit()
            DT_DetailCVTmp.Rows(i).Item("Ma_Sc") = TxtMa_SC.Text.Trim
            DT_DetailCVTmp.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailCVTmp.Rows(i).EndEdit()
        Next
        '=====================================
        'If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailTmp, "CTVTSC", Mode, "Ma_SC =N'" + Ma_SCOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailCVTmp, "CTCVSC", Mode, "Ma_SC=N'" + Ma_SCOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class

