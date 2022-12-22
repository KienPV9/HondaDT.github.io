Imports System.Windows.Forms

Public Class DMGPK
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DT_DetailTmp, Dt_HeadVT, Dt_DmCt, DT_DetailTmp2, Dt_HeadVT2 As DataTable
    Dim Dv_DetailTmp, Dv_HeadVT, Dv_DmCt, Dv_DetailTmp2, Dv_HeadVT2 As DataView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT = "C"
    Dim Lan As String = "V"
    Dim Ma_GPKOld As String
    Dim EditMa_PK, EditTen_Pk, EditDVt As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditGia_nt, EditTien, EditTien_nt, EditCK, EditPt_CK, EditT_TT_NT, EditT_TT, EditIs_KM, EditGia As New Cyber.Fill.CyberColumnGridView
    Dim EditKhacMa_Lo, EditKhacTen_BH, EditKhacTen_LHBH, EditKhacDvt, EditKhacSo_Luong, EditKhacPT_CK, EditKhacCK, EditKhacT_TT_NT, EditKhacT_TT, EditKhacIs_KM, EditKhacIs_Them, EditKhacGia_Nt, EditKhacGia, EditKhacTien_Nt, EditKhacTien, EditKhacDien_Giaii, EditKhacSo_So, EditKhacSo_Po, EditKhacSo_Ro, EditKhacSo_VT As New Cyber.Fill.CyberColumnGridView
    Private Sub DMGPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        V_GetColumn()

        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        V_MainSystem()

        V_AddHandler_Detail()
        V_AddHandMaster()
        If Mode = "M" Then
            Ma_GPKOld = ""
            TxtMa_GPK.Enabled = True
        Else
            Ma_GPKOld = TxtMa_GPK.Text.Trim
            TxtMa_GPK.Enabled = False
        End If
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kx", "DMkx", "(Ma_kx =  N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtDmGPK", TxtMa_GPK.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailTmp = DsTmp.Tables(0).Copy
        Dt_HeadVT = DsTmp.Tables(1).Copy
        Dt_DmCt = DsTmp.Tables(2).Copy

        DT_DetailTmp2 = DsTmp.Tables(3).Copy
        Dt_HeadVT2 = DsTmp.Tables(4).Copy

        Dv_DetailTmp = New DataView(DT_DetailTmp)
        Dv_HeadVT = New DataView(Dt_HeadVT)
        Dv_DmCt = New DataView(Dt_DmCt)

        Dv_DetailTmp2 = New DataView(DT_DetailTmp2)
        Dv_HeadVT2 = New DataView(Dt_HeadVT2)

        '========= FillData to Gridview 
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, Dv_HeadVT, Dv_DetailTmp, Dt_DmCt.Rows(0))
        CyberFill.V_FillVoucher(DetailGRV2, M_LAN, Dv_HeadVT2, Dv_DetailTmp2, Dt_DmCt.Rows(0))
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsManl As New Windows.Forms.ContextMenu

        Dim mnItemsMail2 = New Windows.Forms.ContextMenu
        Dim mnItemsManl2 As New Windows.Forms.ContextMenu

        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsF4_2 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem2, Keys.F4)
        Dim mnItemsF8_2 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem2, Keys.F8)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)

        mnItemsMail2.MenuItems.Add(mnItemsF4_2)
        mnItemsMail2.MenuItems.Add(mnItemsF8_2)

        DetailGRV.GridControl.ContextMenu = mnItemsMail
        DetailGRV2.GridControl.ContextMenu = mnItemsMail2
        Me.ContextMenu = mnItemsManl
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

    End Sub
    Private Sub V_GetColumn()

        EditMa_PK.GetColumn(DetailGRV, "Ma_PK")
        EditTen_Pk.GetColumn(DetailGRV, "Ten_PK")
        EditDVt.GetColumn(DetailGRV, "DVT")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditGia_nt.GetColumn(DetailGRV, "Gia_NT")
        EditGia.GetColumn(DetailGRV, "Gia")
        EditTien_nt.GetColumn(DetailGRV, "TIEN_NT")
        EditTien.GetColumn(DetailGRV, "TIEN")

        EditPt_CK.GetColumn(DetailGRV, "PT_CK")
        EditCK.GetColumn(DetailGRV, "CK")
        EditT_TT_NT.GetColumn(DetailGRV, "T_TT_NT")
        EditT_TT.GetColumn(DetailGRV, "T_TT")
        EditIs_KM.GetColumn(DetailGRV, "Is_KM")
        '-----

        EditKhacGia_Nt.GetColumn(DetailGRV2, "Gia_Nt")
        EditKhacGia.GetColumn(DetailGRV2, "Gia")
        EditKhacTien_Nt.GetColumn(DetailGRV2, "Tien_Nt")
        EditKhacTien.GetColumn(DetailGRV2, "Tien")

        EditKhacPT_CK.GetColumn(DetailGRV2, "PT_CK")
        EditKhacCK.GetColumn(DetailGRV2, "CK")
        EditKhacT_TT_NT.GetColumn(DetailGRV2, "T_TT_NT")
        EditKhacT_TT.GetColumn(DetailGRV2, "T_TT")
        EditKhacIs_KM.GetColumn(DetailGRV2, "Is_KM")
        EditKhacIs_Them.GetColumn(DetailGRV2, "Is_Them")
        EditKhacSo_Luong.GetColumn(DetailGRV2, "SO_LUONG")

    End Sub
    Private Sub V_AddHandMaster()

        AddHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx
        ' Enter dòng cuối
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        AddHandler DetailGRV2.KeyDown, AddressOf MasterGRV_KeyDown2

    End Sub
    Private Sub V_AddHandler_Detail()
        EditTen_Pk.ColumnReadOnly = True
        EditDVt.ColumnReadOnly = True

        EditMa_PK.V_ActiLookUpColumn(AddressOf V_Ma_Pk, AddressOf L_Ma_Pk)

        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditGia_nt.Column Is Nothing Then AddHandler EditGia_nt.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien_nt.Column Is Nothing Then AddHandler EditTien_nt.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf V_Tinh_Toan

        If Not EditPt_CK.Column Is Nothing Then AddHandler EditPt_CK.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditCK.Column Is Nothing Then AddHandler EditCK.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditT_TT_NT.Column Is Nothing Then AddHandler EditT_TT_NT.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditT_TT.Column Is Nothing Then AddHandler EditT_TT.EditColumn.Leave, AddressOf V_Tinh_Toan

        If Not EditIs_KM.Column Is Nothing Then AddHandler EditIs_KM.EditColumn.Leave, AddressOf V_Is_Km
        '------ tab khác
        If Not EditKhacSo_Luong.Column Is Nothing Then AddHandler EditKhacSo_Luong.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacGia_Nt.Column Is Nothing Then AddHandler EditKhacGia_Nt.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacGia.Column Is Nothing Then AddHandler EditKhacGia.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacTien_Nt.Column Is Nothing Then AddHandler EditKhacTien_Nt.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacTien.Column Is Nothing Then AddHandler EditKhacTien.EditColumn.Leave, AddressOf L_khac_Tinh_Toan

        If Not EditKhacPT_CK.Column Is Nothing Then AddHandler EditKhacPT_CK.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacCK.Column Is Nothing Then AddHandler EditKhacCK.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacT_TT_NT.Column Is Nothing Then AddHandler EditKhacT_TT_NT.EditColumn.Leave, AddressOf L_khac_Tinh_Toan
        If Not EditKhacT_TT.Column Is Nothing Then AddHandler EditKhacT_TT.EditColumn.Leave, AddressOf L_khac_Tinh_Toan

        If Not EditKhacIs_KM.Column Is Nothing Then AddHandler EditKhacIs_KM.EditColumn.Leave, AddressOf L_khac_Is_Km
        If Not EditKhacIs_Them.Column Is Nothing Then AddHandler EditKhacIs_Them.EditColumn.Leave, AddressOf L_khac_Is_Them
    End Sub
    Private Sub UpdateList()
        Dim nT_Tien_NT As Decimal = 0
        Dim nT_Tien As Decimal = 0

        Dim nT_CK As Decimal = 0
        Dim nT_BB As Decimal = 0
        Dim nT_KM As Decimal = 0
        Dim nT_KM2 As Decimal = 0

        Dim nT_So_Luong As Decimal = 0
        Dim nT_mua_Them As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_Tien_NT = nT_Tien_NT + Dv_DetailTmp.Item(iRow).Item("Tien_NT")
            nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_Luong")

            nT_CK = nT_CK + Dv_DetailTmp.Item(iRow).Item("CK")
            If Dv_DetailTmp.Item(iRow).Item("Is_KM").ToString.Trim = "1" Then
                nT_KM = nT_KM + Dv_DetailTmp.Item(iRow).Item("Tien_NT") - Dv_DetailTmp.Item(iRow).Item("CK")
            End If
        Next
        For iRow As Integer = 0 To Dv_DetailTmp2.Count - 1
            nT_Tien_NT = nT_Tien_NT + Dv_DetailTmp2.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailTmp2.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp2.Item(iRow).Item("So_Luong")

            nT_CK = nT_CK + Dv_DetailTmp2.Item(iRow).Item("CK")
            If Dv_DetailTmp2.Item(iRow).Item("Is_KM").ToString.Trim = "1" Then
                nT_KM2 = nT_KM2 + Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp2.Item(iRow).Item("CK")
            Else
                If Dv_DetailTmp2.Item(iRow).Item("Is_Them").ToString.Trim = "1" Then
                    nT_mua_Them = nT_mua_Them + Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp2.Item(iRow).Item("CK")
                Else
                    nT_BB = nT_BB + Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp2.Item(iRow).Item("CK")
                End If
            End If
        Next

        TxtT_Tien_NT.Double = nT_Tien_NT
        TxtT_CK.Double = nT_CK
        TxtT_TT_NT.Double = nT_Tien_NT - nT_CK


        nT_BB = nT_Tien_NT - nT_CK - nT_KM

        TxtT_BB.Double = nT_BB
        TxtT_KM.Double = nT_KM + nT_KM2
        TxtT_SO_LUONG.Double = nT_So_Luong

    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "F4/F8-Vat tu"
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortAddItem2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV2.FocusedRowHandle
        V_AddItem2(iRow)
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
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
        UpdateList()
    End Sub
    Private Sub V_AddItem2(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailTmp2
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadVT2)
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailTmp2.Count - 1
        CyberFill.V_ForcusCell(DetailGRV2, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, Appconn) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_ShortDeleteItem2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV2.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp2, Appconn) Then Exit Sub
        Dv_DetailTmp2.Delete(iRow)
        Dv_DetailTmp2.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub MasterGRV_KeyDown2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem2(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub

#End Region
#Region "Ma_pk"

    Private Sub V_Ma_Pk(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Pk", "DmPk", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Pk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_pk") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_pk") = ""
            Dv_DetailTmp.Item(iRow).Item("Dvt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Pk As String = "", _DVT As String = "", _Ten_Pk As String = ""
        Dim _Gia_nt As Decimal = 0

        _Ma_Pk = DrReturn("Ma_pk").ToString.Trim
        _Ten_Pk = DrReturn("Ten_Pk").ToString.Trim
        _DVT = DrReturn("DVT").ToString.Trim
        _Gia_nt = DrReturn("Gia_nt").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Pk") = _Ma_Pk
        Dv_DetailTmp.Item(iRow).Item("Ten_Pk") = _Ten_Pk
        Dv_DetailTmp.Item(iRow).Item("DVT") = _DVT
        Dv_DetailTmp.Item(iRow).Item("Gia_nt") = _Gia_nt
        Dv_DetailTmp.Item(iRow).EndEdit()

        '-----------------------------------------------------------------------------------------------------------
        Tinh_TienPT(iRow)
        UpdateList()
        '-----------------------------------------------------------------------------------------------------------
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub Tinh_TienPT(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 1
        nTy_Gia = 1
        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_nt") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien_nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia_nt"), 0)
        End If

        Dim _Ck As Decimal = 0
        If DT_DetailTmp.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_NT") * Dv_DetailTmp.Item(iRow).Item("PT_CK") / 100, 0)
        If _Ck <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("CK") = _Ck
        Else
            _Ck = Dv_DetailTmp.Item(iRow).Item("CK")
        End If

        If DT_DetailTmp.Columns.Contains("T_TT_NT") Then Dv_DetailTmp.Item(iRow).Item("T_TT_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_NT") - _Ck
        If DT_DetailTmp.Columns.Contains("T_TT") Then Dv_DetailTmp.Item(iRow).Item("T_TT") = Dv_DetailTmp.Item(iRow).Item("Tien") - _Ck
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------
        UpdateList()
    End Sub
    Private Sub V_Is_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Mode = "S") Then Exit Sub
        UpdateList()
    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailTmp.AcceptChanges()
        Tinh_TienPT(iRow)
    End Sub
#End Region
#Region "Vali --- Ma_kx"
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

#End Region
#End Region
#Region "Khác"
    Private Sub L_khac_Is_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV2.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailTmp2.Item(iRow).BeginEdit()
        If Dv_DetailTmp2.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailTmp2.Item(iRow).Item("Is_Them") = 0
        Dv_DetailTmp2.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRV2)
    End Sub
    Private Sub L_khac_Is_Them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV2.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailTmp2.Item(iRow).BeginEdit()
        If Dv_DetailTmp2.Item(iRow).Item("Is_Them").ToString.Trim = "1" Then Dv_DetailTmp2.Item(iRow).Item("Is_Km") = 0
        Dv_DetailTmp2.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRV2)
    End Sub
    Private Sub L_khac_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV2.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV2.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV2.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV2)
        V_khac_Tinh_Toan(iRow)
        UpdateList()
    End Sub
    Private Sub V_khac_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = 1
        '--------------------------------------------------------------------------------
        If Dv_DetailTmp2.Item(iRow).Item("So_Luong") * Dv_DetailTmp2.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailTmp2.Item(iRow).BeginEdit()
            Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailTmp2.Item(iRow).Item("So_Luong") * Dv_DetailTmp2.Item(iRow).Item("Gia_Nt"))
            Dv_DetailTmp2.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp2.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailTmp2.Item(iRow).Item("Tien") = Dv_DetailTmp2.Item(iRow).Item("Tien_Nt")
            Dv_DetailTmp2.Item(iRow).Item("Gia") = Dv_DetailTmp2.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailTmp2.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") * nTy_Gia)
            Dv_DetailTmp2.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailTmp2.Item(iRow).Item("Gia_Nt") * nTy_Gia)
        End If
        Dv_DetailTmp2.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------

        Dv_DetailTmp2.Item(iRow).BeginEdit()
        Dim _Ck As Decimal = 0
        If DT_DetailTmp2.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") * Dv_DetailTmp2.Item(iRow).Item("PT_CK") / 100, 0)
        If _Ck <> 0 Then
            Dv_DetailTmp2.Item(iRow).Item("CK") = _Ck
        Else
            _Ck = Dv_DetailTmp2.Item(iRow).Item("CK")
        End If

        If DT_DetailTmp2.Columns.Contains("T_TT_NT") Then Dv_DetailTmp2.Item(iRow).Item("T_TT_NT") = Dv_DetailTmp2.Item(iRow).Item("Tien_Nt") - _Ck
        If DT_DetailTmp2.Columns.Contains("T_TT") Then Dv_DetailTmp2.Item(iRow).Item("T_TT") = Dv_DetailTmp2.Item(iRow).Item("Tien") - _Ck
        Dv_DetailTmp2.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        CyberSupport.V_UpdateGRV(DetailGRV2)
        '-- BH_UpdateList()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_GPK.Text = _Value

        CyberSmodb.AddValueToRow(Me.DrNew, Me)

        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        Dim nCount As Integer = 0
        nCount = DT_DetailTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            If DT_DetailTmp.Rows(i).Item("Ma_PK").ToString.Trim = "" Then
                DT_DetailTmp.Rows(i).Delete()
                DT_DetailTmp.AcceptChanges()
            End If
        Next

        '===================================== 
        For i = 0 To DT_DetailTmp.Rows.Count - 1
            DT_DetailTmp.Rows(i).BeginEdit()
            DT_DetailTmp.Rows(i).Item("Ma_GPK") = TxtMa_GPK.Text.Trim
            DT_DetailTmp.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailTmp.Rows(i).EndEdit()
        Next

        For i = 0 To DT_DetailTmp2.Rows.Count - 1
            DT_DetailTmp2.Rows(i).BeginEdit()
            DT_DetailTmp2.Rows(i).Item("Ma_GPK") = TxtMa_GPK.Text.Trim
            DT_DetailTmp2.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailTmp2.Rows(i).EndEdit()
        Next

        '=====================================
        'If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailTmp, "CtDmGPK", Mode, "Ma_GPK = N'" + Ma_GPKOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailTmp2, "DMGPKKhac", Mode, "Ma_GPK = N'" + Ma_GPKOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay 
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region


End Class
