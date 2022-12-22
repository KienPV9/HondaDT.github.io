Imports System.Windows.Forms

Public Class DMChienDich
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbCtDmChienDich, tbSK, tbVT, tbCV As New DataTable
    Dim DvCtDmChienDich As New DataView
    Dim DvSK, DvVT, DvCV As New DataView
    Dim DvSKH, DvVTH, DvCVH As New DataView
    Dim Ma_ChienDichOld, Ma_DvcsOld As String

    Dim CyberExport As New Cyber.Export.Sys

    Dim EditMa_xe, EditLoai_Xe, EditMa_KX, EditTen_Kx, EditMa_Mau, EditTen_Mau, EditSo_Khung, EditSo_May, EditLoai_Dong_Co, EditSo_Dong_Co As New Cyber.Fill.CyberColumnGridView
    Dim EditDai_Ly_Ban, EditXuat_Xuong, EditGhi_Chu, EditMa_CV, EditTen_CV, EditMa_CTCV, EditTen_CTCV As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_VT, EditPart_no, EditTen_Vt, EditDvt, EditSo_Luong, EditMa_Kho, EditMa_Vitri As New Cyber.Fill.CyberColumnGridView

    Private Sub DMChienDich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        If Mode = "M" Then
            Ma_ChienDichOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_ChienDichOld = TxtMa_ChienDich.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If


        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_ChienDich.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        'CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'txtNgay_BD.Value = Now.Date
        'TxtNgay_KT.Value = Now.Date.AddMonths(1)

        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_ChienDich)

        V_Load_CtDmChienDich(Mode, TxtMa_ChienDich.Text.Trim, TxtMa_Dvcs.Text.Trim)
        V_GetColumns()

        V_AddHandlerDetail()
        V_Menu_SK()
        V_Menu_VT()
        V_Menu_CV()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        ' Enter dòng cuối
        AddHandler DetailSKGRV.KeyDown, AddressOf DetailGRV_SK_KeyDown
        AddHandler DetailVTGRV.KeyDown, AddressOf DetailGRV_VT_KeyDown
        AddHandler DetailCVGRV.KeyDown, AddressOf DetailGRV_CV_KeyDown
    End Sub
    Private Sub V_AddHandlerDetail()

        EditLoai_Xe.V_ActiLookUpColumn(AddressOf V_Loai_Xe, AddressOf L_Loai_Xe)
        EditMa_KX.V_ActiLookUpColumn(AddressOf V_Ma_Kx, AddressOf L_Ma_Kx)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)

        EditMa_VT.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        EditMa_CV.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        EditMa_CTCV.V_ActiLookUpColumn(AddressOf V_Ma_CTCV, AddressOf L_Ma_CTCV)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
    Private Sub V_Load_CtDmChienDich(ByVal M_Mode As String, ByVal sMa_ChienDich As String, ByVal sMa_Dvcs As String)
        Dim DsFilterChienDich As New DataSet
        sMa_ChienDich = sMa_ChienDich.Trim
        sMa_Dvcs = sMa_Dvcs.Trim
        M_Mode = M_Mode.Trim
        DsFilterChienDich = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtDmChienDich", M_Mode & "#" & sMa_ChienDich & "#" & TxtMa_Dvcs.Text & "#" & M_User_Name)

        tbSK = DsFilterChienDich.Tables(0)
        tbVT = DsFilterChienDich.Tables(1)
        tbCV = DsFilterChienDich.Tables(2)

        DvSK = New DataView(tbSK)
        DvVT = New DataView(tbVT)
        DvCV = New DataView(tbCV)

        DvSKH = New DataView(DsFilterChienDich.Tables(3))
        DvCVH = New DataView(DsFilterChienDich.Tables(4))
        DvVTH = New DataView(DsFilterChienDich.Tables(5))
        CyberFill.V_FillVoucher(DetailSKGRV, M_LAN, DvSKH, DvSK, Nothing)
        CyberFill.V_FillVoucher(DetailVTGRV, M_LAN, DvVTH, DvVT, Nothing)
        CyberFill.V_FillVoucher(DetailCVGRV, M_LAN, DvCVH, DvCV, Nothing)

    End Sub
    Private Sub V_GetColumns()
        EditMa_xe.GetColumn(DetailSKGRV, "Ma_xe")
        EditLoai_Xe.GetColumn(DetailSKGRV, "Loai_Xe")
        EditMa_KX.GetColumn(DetailSKGRV, "Ma_KX")
        EditTen_Kx.GetColumn(DetailSKGRV, "Ten_KX")
        EditMa_Mau.GetColumn(DetailSKGRV, "Ma_Mau")
        EditTen_Mau.GetColumn(DetailSKGRV, "Ten_Mau")
        EditSo_Khung.GetColumn(DetailSKGRV, "So_Khung")
        EditSo_May.GetColumn(DetailSKGRV, "So_May")
        EditLoai_Dong_Co.GetColumn(DetailSKGRV, "Loai_Dong_Co")
        EditSo_Dong_Co.GetColumn(DetailSKGRV, "So_Dong_Co")
        EditDai_Ly_Ban.GetColumn(DetailSKGRV, "Dai_Ly_Ban")
        EditXuat_Xuong.GetColumn(DetailSKGRV, "Xuat_Xuong")
        EditGhi_Chu.GetColumn(DetailSKGRV, "Ghi_Chu")

        EditMa_CV.GetColumn(DetailCVGRV, "Ma_CV")
        EditTen_CV.GetColumn(DetailCVGRV, "Ten_CV")
        EditMa_CTCV.GetColumn(DetailCVGRV, "Ma_CTCV")
        EditTen_CTCV.GetColumn(DetailCVGRV, "Ten_CTCV")

        EditMa_VT.GetColumn(DetailVTGRV, "Ma_VT")
        EditPart_no.GetColumn(DetailVTGRV, "Part_no")
        EditTen_Vt.GetColumn(DetailVTGRV, "Ten_Vt")
        EditDvt.GetColumn(DetailVTGRV, "Dvt")
        EditSo_Luong.GetColumn(DetailVTGRV, "So_Luong")
        EditMa_Kho.GetColumn(DetailVTGRV, "Ma_Kho")
        EditMa_Vitri.GetColumn(DetailVTGRV, "Ma_Vitri")

    End Sub
#Region "Valid"
#Region "Loai_Xe"
    Private Sub V_Loai_Xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "1=1")
    End Sub
    Private Sub L_Loai_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailSKGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Loai_Xe") = ""
            Exit Sub
        End If
        drvCurren("Loai_Xe") = DrReturn("Ma_Nh")
        DetailSKGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_KX"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailSKGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_KX") = ""
            drvCurren("Ten_KX") = ""
            Exit Sub
        End If
        drvCurren("Ma_KX") = DrReturn("Ma_KX")
        drvCurren("Ten_KX") = DrReturn("Ten_KX")
        DetailSKGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailSKGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Mau") = ""
            drvCurren("Ten_Mau") = ""
            Exit Sub
        End If
        drvCurren("Ma_Mau") = DrReturn("Ma_Mau")
        drvCurren("Ten_Mau") = DrReturn("Ten_Mau")
        DetailSKGRV.UpdateCurrentRow()
    End Sub
#End Region

#Region "Ma_VT"

    Private Sub V_Ma_VT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_VT", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailVTGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_VT") = ""
            drvCurren("Ten_VT") = ""
            drvCurren("DVT") = ""
            Exit Sub
        End If

        drvCurren("Ma_VT") = DrReturn("Ma_VT")
        drvCurren("Ten_VT") = DrReturn("Ten_VT")
        drvCurren("DVT") = DrReturn("DVT")
        DetailVTGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CV"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_CV", "Dmcv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailCVGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_CV") = ""
            drvCurren("Ten_CV") = ""
            Exit Sub
        End If
        drvCurren("Ma_CV") = DrReturn("Ma_CV")
        drvCurren("Ten_CV") = DrReturn("Ten_CV")
        DetailCVGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CTCV"
    Private Sub V_Ma_CTCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_CTCV", "DmCTCV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CTCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailCVGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_CTCV") = ""
            drvCurren("Ten_CTCV") = ""
            Exit Sub
        End If
        drvCurren("Ma_CTCV") = DrReturn("Ma_CTCV")
        drvCurren("Ten_CTCV") = DrReturn("Ten_CTCV")
        DetailCVGRV.UpdateCurrentRow()
    End Sub
#End Region

#End Region
#Region "Menu Gridview"
    Private Sub V_Menu_SK()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem_SK, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem_SK, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailSKGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_Menu_VT()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem_VT, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem_VT, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailVTGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_Menu_CV()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem_CV, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem_CV, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailCVGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
#End Region
#Region "Add/Delete"
    Sub V_ShortAddItem_SK(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailSKGRV.FocusedRowHandle
        V_AddItem_SK(iRow)
    End Sub
    Private Sub V_AddItem_SK(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = DvSK.Item(iRow) Else DrvOld = Nothing
        DvSK.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvSK.Table.Rows(DvSK.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvSK.Table.Rows(DvSK.Table.Rows.Count - 1), DvSKH)
        'CyberSupport.SetCarryOn(DrvOld, DvSK.Table.Rows(DvSK.Table.Rows.Count - 1), DvHTH)
        'CyberSupport.SetCarryOn(DrvOld, DvSK.Table.Rows(DvSK.Table.Rows.Count - 1), DvTTH)
        CarrOn_SK(DvSK.Table.Rows(DvSK.Table.Rows.Count - 1))
        'UpdateList()
        iRow = DvSK.Count - 1
        CyberFill.V_ForcusCell(DetailSKGRV, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItem_SK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailSKGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvSK, Appconn) Then Exit Sub
        DvSK.Delete(iRow)
        DvSK.Table.AcceptChanges()
        '  UpdateList()
    End Sub
    Private Sub CarrOn_SK(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_tang") = Now.Date
        'DvNew.Item("Ngay_Kh") = Now.Date
    End Sub
    Sub V_ShortAddItem_VT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailVTGRV.FocusedRowHandle
        DetailSKGRV.PostEditor()
        V_AddItem_Vt(iRow)
    End Sub
    Private Sub V_AddItem_Vt(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView

        If iRow > 0 Then DrvOld = DvVT.Item(iRow) Else DrvOld = Nothing

        DvVT.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvVT.Table.Rows(DvVT.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvVT.Table.Rows(DvVT.Table.Rows.Count - 1), DvVTH)
        CarrOn_VT(DvVT.Table.Rows(DvVT.Table.Rows.Count - 1))
        ' UpdateList()
        iRow = DvVT.Count - 1
        If iRow > 0 Then CyberFill.V_ForcusCell(DetailVTGRV, iRow, 0)
    End Sub
    Private Sub CarrOn_VT(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub V_ShortDeleteItem_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailVTGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvVT, Appconn) Then Exit Sub
        DvVT.Delete(iRow)
        DvVT.Table.AcceptChanges()
        'UpdateList()
    End Sub

    Sub V_ShortAddItem_CV(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailCVGRV.FocusedRowHandle
        DetailSKGRV.PostEditor()
        V_AddItem_CV(iRow)
    End Sub
    Private Sub V_AddItem_CV(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView

        If iRow > 0 Then DrvOld = DvCV.Item(iRow) Else DrvOld = Nothing

        DvCV.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvCV.Table.Rows(DvCV.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCV.Table.Rows(DvCV.Table.Rows.Count - 1), DvCVH)
        CarrOn_CV(DvCV.Table.Rows(DvCV.Table.Rows.Count - 1))
        ' UpdateList()
        iRow = DvCV.Count - 1
        If iRow > 0 Then CyberFill.V_ForcusCell(DetailCVGRV, iRow, 0)
    End Sub
    Private Sub CarrOn_CV(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub V_ShortDeleteItem_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailCVGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCV, Appconn) Then Exit Sub
        DvCV.Delete(iRow)
        DvCV.Table.AcceptChanges()
        'UpdateList()
    End Sub
#End Region
#Region "Enter Dong cuoi"
    Private Sub DetailGRV_SK_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        Dim iCoumnVisible As Integer = Grid.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = Grid.RowCount - 1
        Dim iRowRowFocus As Integer = Grid.FocusedRowHandle
        Dim iColumnRowFocus As Integer = Grid.VisibleColumns.IndexOf(Grid.FocusedColumn)
        Dim iRowOld As Integer = Grid.GetFocusedDataSourceRowIndex

        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem_SK(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub DetailGRV_VT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        Dim iCoumnVisible As Integer = Grid.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = Grid.RowCount - 1
        Dim iRowRowFocus As Integer = Grid.FocusedRowHandle
        Dim iColumnRowFocus As Integer = Grid.VisibleColumns.IndexOf(Grid.FocusedColumn)
        Dim iRowOld As Integer = Grid.GetFocusedDataSourceRowIndex

        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem_Vt(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub DetailGRV_CV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        Dim iCoumnVisible As Integer = Grid.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = Grid.RowCount - 1
        Dim iRowRowFocus As Integer = Grid.FocusedRowHandle
        Dim iColumnRowFocus As Integer = Grid.VisibleColumns.IndexOf(Grid.FocusedColumn)
        Dim iRowOld As Integer = Grid.GetFocusedDataSourceRowIndex

        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem_CV(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_ChienDich.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)

        Dim nCount, i As Integer
        nCount = tbSK.Rows.Count - 1
        ' CTDMTS
        For i = nCount To 0 Step -1
            If tbSK.Rows(i).Item("Ma_Xe").ToString.Trim = "" Then
                tbSK.Rows(i).Delete()
                tbSK.AcceptChanges()
            End If
            tbSK.Rows(i).Item("Ma_ChienDich") = TxtMa_ChienDich.Text.Trim
        Next

        '--- Check nhap chi tiet VT
        nCount = tbVT.Rows.Count - 1
        For i = nCount To 0 Step -1
            If tbVT.Rows(i).Item("Ma_VT").ToString.Trim = "" Then
                tbVT.Rows(i).Delete()
                tbVT.AcceptChanges()
            End If
            tbVT.Rows(i).Item("Ma_ChienDich") = TxtMa_ChienDich.Text.Trim
        Next

        '--- Check nhap chi tiet CV
        nCount = tbCV.Rows.Count - 1

        For i = nCount To 0 Step -1
            If tbCV.Rows(i).Item("Ma_CV").ToString.Trim = "" Then
                tbCV.Rows(i).Delete()
                tbCV.AcceptChanges()

            End If
            tbCV.Rows(i).Item("Ma_ChienDich") = TxtMa_ChienDich.Text.Trim
        Next

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        CyberSmodb.V_SaveHToSQL(Appconn, oSysvar, M_User_Name, tbSK, "DmChienDichSK", Mode, "ma_ChienDich  = N'" + Ma_ChienDichOld + "'")
        CyberSmodb.V_SaveHToSQL(Appconn, oSysvar, M_User_Name, tbVT, "DmChienDichVT", Mode, "ma_ChienDich  = N'" + Ma_ChienDichOld + "'")
        CyberSmodb.V_SaveHToSQL(Appconn, oSysvar, M_User_Name, tbCV, "DmChienDichCV", Mode, "ma_ChienDich  = N'" + Ma_ChienDichOld + "'")

        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Import DS Xe"
    Private Sub CmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImport.Click
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(Appconn, Me.oSysvar, Me.M_Para, DetailSKGRV, tbSK, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        tbSK.Clear()
        tbSK.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            tbSK.ImportRow(TbImport.Rows(i))
        Next
        tbSK.AcceptChanges()
    End Sub
#End Region
End Class
