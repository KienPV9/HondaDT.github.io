Public Class Frm_KPI
    Dim M_Stt_Rec As String = "M"
    Dim M_Dien_giai_GNPT As String = ""
    Dim M_Ngay_ct As Date
    Dim M_GioCt As String = ""
    Dim M_Mode As String = ""
    Dim M_Ngay_ct_PDC As String = ""
    Dim M_GioCt_PDC As String = ""
    Dim M_Dien_giai_GNPT_PDC As String = ""
    Dim Is_oK As String = "0"
    Dim Ma_post_PDC As String
    '-------------------------------
    Dim Dt_Detail, Dt_DetailTmp, tbHeader As New DataTable
    Dim Dv_Detail, Dv_DetailTmp, DvHeader As New DataView
#Region "Columns Edit"
    Dim EditMa_lo, EditTk_VT As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditGNPT_OK, EditGNPT_NotOK, EditMa_Kho_I, EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim Editma_Db_I, EditMa_Xe_I, EditMa_KX_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditTen_Vt, EditDvt, EditTen_kho_i, EditTen_Tk_VT, EditSo_Luong, EditGia_NT0, EditGia0, EditGia_NT, EditTien_NT0, EditTien0, EditCP_NT, EditCP, EditGia, EditTien_NT, EditTien, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Dim EditNoi_Dung_i As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim editma_chucvu, editma_chucdanh, editis_nghi, editDiem_KPI, editSL_VP, editDiem_tru, editDiem_con_lai, editSL_VP_QL, editDiem_tru_QL, editDiem_con_lai_QL As New Cyber.Fill.CyberColumnGridView

#End Region
#Region "khai bao bien property"
    Public Property Dien_giai_GNPT() As String
        Get
            Dien_giai_GNPT = M_Dien_giai_GNPT
        End Get
        Set(ByVal Value As String)
            M_Dien_giai_GNPT = Value
        End Set
    End Property
    Public Property Ngay_ct() As Date
        Get
            Ngay_ct = M_Ngay_ct
        End Get
        Set(ByVal Value As Date)
            M_Ngay_ct = Value
        End Set
    End Property
    Public Property GioCt() As String
        Get
            GioCt = M_GioCt
        End Get
        Set(ByVal Value As String)
            M_GioCt = Value
        End Set
    End Property
    '-------------------------
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Public Property Dien_giai_GNPT_PDC() As String
        Get
            Dien_giai_GNPT_PDC = M_Dien_giai_GNPT_PDC
        End Get
        Set(ByVal Value As String)
            M_Dien_giai_GNPT_PDC = Value
        End Set
    End Property
    Public Property Ngay_ct_PDC() As String
        Get
            Ngay_ct_PDC = M_Ngay_ct_PDC
        End Get
        Set(ByVal Value As String)
            M_Ngay_ct_PDC = Value
        End Set
    End Property
    Public Property GioCt_PDC() As String
        Get
            GioCt_PDC = M_GioCt_PDC
        End Get
        Set(ByVal Value As String)
            M_GioCt_PDC = Value
        End Set
    End Property
    Public Property Is_ok_pDC() As String
        Get
            Is_ok_pDC = Is_oK
        End Get
        Set(ByVal Value As String)
            Is_oK = Value
        End Set
    End Property
    Public Property Ma_Post() As String
        Get
            Ma_Post = Ma_post_PDC
        End Get
        Set(ByVal Value As String)
            Ma_post_PDC = Value
        End Set
    End Property
#End Region
    Private Sub Frm_BGX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtDien_giai_GNPT.Text = Me.Dien_giai_GNPT
        TxtGio_Ctu.Text = Me.GioCt
        If Me.GioCt = "" Then TxtGio_Ctu.Text = CyberVoucher.V_GetTG(TxtGio_Ctu.Text, 0)

        TxtNgay_Ct.Value = Me.Ngay_ct
        If Me.Ngay_ct = Date.Parse("01/01/1900") Then TxtNgay_Ct.Value = Now.Date
        '----
        V_Load()
        V_GetColumn()
        V_MainSystem()
        V_AddHandler()
        V_AddHandler_Detail()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsSave As New MenuItem("Chọn tất cả (Ctrl+A)", AddressOf V_Selected, Keys.Control + Keys.A)
        Dim mnItemsPrint As New MenuItem("Bỏ chọn (Ctrl+U)", AddressOf V_UnSelected, Keys.Control + Keys.U)

        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail
    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_LoadDataXN_KPI", M_Stt_Rec.ToString.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        '---------------------
        Dt_Detail = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        Dt_DetailTmp = Dt_Detail.Clone
        '-------------------------------------
        Dv_Detail = New DataView(Dt_Detail)
        DvHeader = New DataView(tbHeader)
        Dv_DetailTmp = New DataView(Dt_Detail)
        '-------------------------------------
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, DvHeader, Dv_DetailTmp, Nothing)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_AddHandler()
        'master
        AddHandler TxtGio_Ctu.Leave, AddressOf L_Gio_CT
        AddHandler ButtOK.Click, AddressOf V_Nhan

        'system
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        'detail
        'If Not EditGNPT_OK.Column Is Nothing Then AddHandler EditGNPT_OK.EditColumn.EditValueChanged, AddressOf L_Xac_Nhan_OK
        'If Not EditGNPT_NotOK.Column Is Nothing Then AddHandler EditGNPT_NotOK.EditColumn.EditValueChanged, AddressOf L_Xac_Nhan_NotOK

        AddHandler DetailGRV.RowCellStyle, AddressOf Master1GRV_RowCellStyle

        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
    End Sub
    Private Sub V_AddHandler_Detail()
        '---Add On
        If Not editSL_VP.Column Is Nothing Then AddHandler editSL_VP.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_con_lai.Column Is Nothing Then AddHandler editDiem_con_lai.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_tru.Column Is Nothing Then AddHandler editDiem_tru.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editSL_VP_QL.Column Is Nothing Then AddHandler editSL_VP_QL.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_con_lai_QL.Column Is Nothing Then AddHandler editDiem_con_lai_QL.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_tru_QL.Column Is Nothing Then AddHandler editDiem_tru_QL.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not editDiem_KPI.Column Is Nothing Then AddHandler editDiem_KPI.EditColumn.Leave, AddressOf L_Tinh_Toan

        'AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất cả", "Select all"), AddressOf V_Selected, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Bỏ chọn tất cả", "UnSelect all"), AddressOf V_UnSelected, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Diem_con_lai") = Dv_DetailTmp.Item(iRow).Item("Diem_KPI") - Dv_DetailTmp.Item(iRow).Item("Diem_tru")
        Dv_DetailTmp.Item(iRow).Item("Diem_con_lai_QL") = Dv_DetailTmp.Item(iRow).Item("Diem_KPI") - Dv_DetailTmp.Item(iRow).Item("Diem_tru_QL")
        Dv_DetailTmp.Item(iRow).EndEdit()
        '
        Dv_DetailTmp.Table.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRV)
    End Sub

    Private Sub V_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow, nCount As Integer
        nCount = Dv_DetailTmp.Table.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            Dv_DetailTmp.Item(iRow).Item("SL_VP_QL") = Dv_DetailTmp.Item(iRow).Item("SL_VP")
            Dv_DetailTmp.Item(iRow).Item("Diem_Tru_QL") = Dv_DetailTmp.Item(iRow).Item("Diem_Tru")
            Dv_DetailTmp.Item(iRow).Item("Diem_Con_Lai_QL") = Dv_DetailTmp.Item(iRow).Item("Diem_Con_Lai")
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Sub V_UnSelected(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow, nCount As Integer
        nCount = Dv_DetailTmp.Table.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            Dv_DetailTmp.Item(iRow).Item("SL_VP_QL") = 0
            Dv_DetailTmp.Item(iRow).Item("Diem_Tru_QL") = 0
            Dv_DetailTmp.Item(iRow).Item("Diem_Con_Lai_QL") = 0
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Sub V_GetColumn()

        EditTen_Vt.GetColumn(DetailGRV, "Ten_VT")
        EditMa_lo.GetColumn(DetailGRV, "Ma_Lo")
        EditDvt.GetColumn(DetailGRV, "DVT")

        EditMa_Kho_I.GetColumn(DetailGRV, "Ma_kho_I")
        EditTen_kho_i.GetColumn(DetailGRV, "TEN_KHo_I")

        EditTk_VT.GetColumn(DetailGRV, "TK_VT")
        EditTen_Tk_VT.GetColumn(DetailGRV, "TEN_TK_VT")

        EditDien_Giaii.GetColumn(DetailGRV, "DIEN_GIAII")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")

        EditGia_NT0.GetColumn(DetailGRV, "Gia_NT0")
        EditGia0.GetColumn(DetailGRV, "Gia0")

        EditTien_NT0.GetColumn(DetailGRV, "TIEN_NT0")
        EditTien0.GetColumn(DetailGRV, "TIEN0")

        EditCP_NT.GetColumn(DetailGRV, "CP_NT")
        EditCP.GetColumn(DetailGRV, "CP")

        EditGia_NT.GetColumn(DetailGRV, "Gia_NT")
        EditGia.GetColumn(DetailGRV, "Gia")

        EditTien_NT.GetColumn(DetailGRV, "TIEN_NT")
        EditTien.GetColumn(DetailGRV, "TIEN")
        '
        editDiem_con_lai.GetColumn(DetailGRV, "Diem_con_lai")
        editDiem_KPI.GetColumn(DetailGRV, "Diem_KPI")
        editDiem_tru.GetColumn(DetailGRV, "Diem_tru")
        editSL_VP.GetColumn(DetailGRV, "SL_VP")
        editSL_VP_QL.GetColumn(DetailGRV, "SL_VP_QL")
        editDiem_con_lai_QL.GetColumn(DetailGRV, "Diem_con_lai_QL")
        editDiem_tru_QL.GetColumn(DetailGRV, "Diem_tru_QL")


        EditMa_Vv_I.GetColumn(DetailGRV, "Ma_Vv_I")
        EditMa_phi_i.GetColumn(DetailGRV, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRV, "Ma_HD_I")
        EditMa_Sp_I.GetColumn(DetailGRV, "Ma_SP_I")
        EditMa_ku_I.GetColumn(DetailGRV, "Ma_KU_I")
        EditMa_TTLN_i.GetColumn(DetailGRV, "Ma_TTLN_I")
        EditMa_TTCP_i.GetColumn(DetailGRV, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRV, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRV, "Ma_Hs_I")
        EditMa_CD_I.GetColumn(DetailGRV, "Ma_CD_I")

        EditMa_TD1_I.GetColumn(DetailGRV, "Ma_TD1_I")
        EditMa_TD2_I.GetColumn(DetailGRV, "Ma_TD2_I")
        EditMa_TD3_I.GetColumn(DetailGRV, "Ma_TD3_I")
        EditMa_TD4_I.GetColumn(DetailGRV, "Ma_TD4_I")
        EditMa_TD5_I.GetColumn(DetailGRV, "Ma_TD5_I")

        EditSo_So.GetColumn(DetailGRV, "SO_SO")
        EditSo_Po.GetColumn(DetailGRV, "SO_PO")
        EditSo_Ro.GetColumn(DetailGRV, "SO_RO")
        EditSo_VT.GetColumn(DetailGRV, "SO_VT")

        Editma_Db_I.GetColumn(DetailGRV, "Ma_Db_I")
        EditMa_Xe_I.GetColumn(DetailGRV, "MA_XE_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_TUYEN_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")
        '----------------------------
        EditNoi_Dung_i.GetColumn(DetailGRV, "Noi_Dung_i")
    End Sub
#Region "Cmd..."
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub Master1GRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_Detail, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        DetailGRV.PostEditor()
        Dim strReplace As String = "!~!$!~!"

        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"ctkpi"}, {Dv_DetailTmp.Table}, strReplace) '.V_ConvertDataToXML(Dv_DetailTmp)
        Dim _ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_SaveDataXN_KPI", M_Stt_Rec.ToString.Trim & "#" & strXML.ToString.Trim & "#" & strReplace.ToString.Trim _
          & "#" & TxtGio_Ctu.Text.Trim & "#" & _ngay_Ct.ToString("yyyyMMdd") & "#" & TxtDien_giai_GNPT.Text.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        If Not CyberSupport.V_MsgChk(DsData.Tables(0), Sysvar, "V") Then Exit Sub
        Me.Close()
    End Sub
    Private Sub L_Gio_CT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtGio_Ctu.Text <> "" Then
            TxtGio_Ctu.Text = CyberVoucher.V_GetTG(System.Text.RegularExpressions.Regex.Replace(TxtGio_Ctu.Text, "[^\d]", " "), 0)
        End If
    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRV.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRV.VisibleColumns.IndexOf(DetailGRV.FocusedColumn)
        Dim iRowOld As Integer = DetailGRV.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            'V_AddItem(iRowOld) '' Cot cuoi cung them dong
            SendKeys.Send("^{Tab}")
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
End Class
