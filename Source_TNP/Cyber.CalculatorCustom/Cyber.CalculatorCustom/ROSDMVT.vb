Imports System.Windows.Forms
Imports System.Drawing

Public Class ROSDMVT
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbHeader_DaXuat As New DataTable
    Dim DvMaster, DvHeader, DvHeader_DaXuat As New DataView
    Dim DsTmpDetal As New DataSet

    Dim Dt_Ro, Dt_Ro_H As DataTable
    Dim Dv_Ro, Dv_Ro_H As DataView


    Dim Dt_Ro1, Dt_Ro_H1 As DataTable
    Dim Dv_Ro1, Dv_Ro_H1 As DataView

    Dim _SL_Xuat_Pick, _SL_Xuat As Double
    Dim M_Stt_Rec, M_Stt_Rec0 As String
    Dim _StrSave As String = ""
    Dim Dt_Timer_Data As DataTable
    '--------
    Dim M_Chk_Defa As String = ""
    Dim M_Ma_TTCP As String = ""

#Region "Columns Edit"
    Dim EditMa_VT, EditMa_Kho_I, EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_Vt, EditDvt, EditSL_Ton, EditSL_RO, EditSL_Xuat, EditSL_Da_Xuat, EditSL_Xuat_Pick, EditStt_rec0, EditSL_Da_Xuat_Pick, EditSL_CL, EditGia2, EditThue, EditTien2, EditSo_RO, Editma_cv, EditTen_cv3, Editma_ctcv, EditGhi_chu, Editso_ct0, Editngay_ct0, Editma_ct, EditFtag, EditNgay_DK As New Cyber.Fill.CyberColumnGridView



#End Region
    Private Sub ROXPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '---------------------------------------------------------------------------------------------
        V_Load()
        '---------------------------------------------------------------------------------------------
        V_GetColumn()
        '---------------------------------------------------------------------------------------------
        'V_LoadDatases_Ngam_Dinh()
        '---------------------------------------------------------------------------------------------
        V_AddHandler()
        '---------------------------------------------------------------------------------------------
        V_Fill_Data()
        '---------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '---------------------------------------------------------------------------------------------
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP("PKH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)

    End Sub
    Private Sub V_Fill_Data()
        'CyberFill.V_FillComBoxDefaul(CbbTime_Data, Dt_Timer_Data, "Tg", "Ten_TG", "Ngam_Dinh")
    End Sub

#Region "Load and System...."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_RO
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile

        'AddHandler CmDanh_Sach.Click, AddressOf V_Sanh_Sach
        'AddHandler CmdXemPhieuXuat.Click, AddressOf V_XemPhieuXuat
        AddHandler DetailGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler CmdOK.Click, AddressOf V_danh_sach
        AddHandler CmdUpdate.Click, AddressOf V_Update
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_vt_1
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_vt_1
        AddHandler TxtNh_vt.CyberValiting, AddressOf V_Ma_nh
        AddHandler TxtNh_vt.CyberLeave, AddressOf L_Ma_nh
        'AddHandler TxtMa_HS_H.CyberValiting, AddressOf V_Ma_Hs_H
        'AddHandler TxtMa_HS_H.CyberLeave, AddressOf L_Ma_Hs_H
    End Sub
    Private Sub V_AddHandler_Detail()
        AddHandler DetailGRV.PopupMenuShowing, AddressOf DetailGRV_PopupMenuShowing
        AddHandler DetailGRV1.PopupMenuShowing, AddressOf DetailGRV1_PopupMenuShowing
        '--------------------------

        '--------------------------
        AddHandler DetailGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler DetailGRV1.RowCellStyle, AddressOf MasterGRV_RowCellStyle

        AddHandler DetailGRV1.FocusedRowChanged, AddressOf V_DetailGRV1_FocusedRowChanged
        Editma_cv.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        Editma_ctcv.V_ActiLookUpColumn(AddressOf V_Ma_Ctcv, AddressOf L_Ma_Ctcv)
        EditMa_VT.V_ActiLookUpColumn(AddressOf V_Ma_vt, AddressOf L_Ma_vt)

        '--------------------------
    End Sub
#End Region
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", "M", "HDK", M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup("M", "HDK", sender, True)
        If DrReturn Is Nothing Then
            Dv_Ro.Item(iRow).BeginEdit()
            Dv_Ro.Item(iRow).Item("Ma_Cv") = ""
            DetailGRV.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_Ro.Item(iRow).BeginEdit()
        Dv_Ro.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        Dv_Ro.Item(iRow).EndEdit()

        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_vt", "Dmvt", "1=1", "1=1", "M", "HDK", M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup("M", "HDK", sender, True)
        If DrReturn Is Nothing Then
            Dv_Ro.Item(iRow).BeginEdit()
            Dv_Ro.Item(iRow).Item("Ma_vt") = ""
            DetailGRV.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_Ro.Item(iRow).BeginEdit()
        Dv_Ro.Item(iRow).Item("Ma_vt") = DrReturn("Ma_vt").ToString.Trim
        Dv_Ro.Item(iRow).Item("Ten_vt") = DrReturn("Ten_vt").ToString.Trim

        Dv_Ro.Item(iRow).EndEdit()

        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Ctcv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Ctcv", "Dmctcv", "1=1", "1=1", "M", "HDK", M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ctcv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup("M", "HDK", sender, True)
        If DrReturn Is Nothing Then
            Dv_Ro.Item(iRow).BeginEdit()
            Dv_Ro.Item(iRow).Item("Ma_Ctcv") = ""
            DetailGRV.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_Ro.Item(iRow).BeginEdit()
        Dv_Ro.Item(iRow).Item("Ma_Ctcv") = DrReturn("Ma_Ctcv").ToString.Trim
        Dv_Ro.Item(iRow).EndEdit()

        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_DetailGRV1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        If DetailGRV1.RowCount = 0 Then Exit Sub
        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("Ten_nh").ToString()
        Dim _Dt As Date = Now.Date
        ' TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()

    End Sub
    Private Sub V_DetailGRV1_FocusedRowChanged(ByVal DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("So_Ro").ToString()
    End Sub


    Private Sub V_Load()


        V_Loaddatatabse("1", "")
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, Dv_Ro_H, Dv_Ro)
        DetailGRV.GridControl.DataSource = Dv_Ro
        ''--- Load luoi RO
        V_LoadRo("3", "4")
        CyberFill.V_FillVoucher(DetailGRV1, M_LAN, Dv_Ro_H1, Dv_Ro1)
        DetailGRV1.GridControl.DataSource = Dv_Ro1
        '-----------------------------------------------------
        If DetailGRV1.RowCount = 0 Then Exit Sub

        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("Ten_nh").ToString()
        Dim _Dt As Date = Now.Date

        ' TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_LoadRo(ByVal _Load As String, ByVal _Load1 As String)
        _Load = "3"
        _Load1 = "4"


        Dim DsTmpRO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetROSDMVTDetail1", _Load + "#" + _Load1 + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name)

        For i As Integer = 0 To DsTmpRO.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmpRO.Tables(i))
        Next
        Dt_Ro1 = DsTmpRO.Tables(0).Copy
        Dt_Ro_H1 = DsTmpRO.Tables(1).Copy
        Dv_Ro1 = New DataView(Dt_Ro1)
        Dv_Ro_H1 = New DataView(Dt_Ro_H1)
        DsTmpRO.Dispose()
        Dt_Ro1.Clear()
        CyberSmodb.SQLTbToTb(DsTmpRO.Tables(0), Dt_Ro1)
    End Sub

    Private Sub V_Loaddatatabse(ByVal _Status As String, ByVal _So_Ro As String)
        Dim _Pick As String = ""
        'If ChkPick.Checked = True Then _Pick = "1"

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetROSDMVTDetail", _Status + "#" + _So_Ro + "#" + _Pick + "#" + IIf(Chkis_Hd.Checked, "1", "0") + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name)

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If _Status = "1" Then

            Dt_Ro = DsTmp.Tables(1).Copy
            Dt_Ro_H = DsTmp.Tables(2).Copy
            Dv_Ro = New DataView(Dt_Ro)
            Dv_Ro_H = New DataView(Dt_Ro_H)
            DsTmp.Dispose()
            Exit Sub
        End If

        Dt_Ro.Clear()

        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_Ro)

        If DsTmp.Tables(0).Columns.Contains("Nh_Vt") Then TxtNh_vt.Text = DsTmp.Tables(0).Rows(0).Item("nh_Vt")

        If DsTmp.Tables(0).Columns.Contains("Ten_nh") Then TxtTen_nh.Text = DsTmp.Tables(0).Rows(0).Item("Ten_nh")
        If DsTmp.Tables(0).Columns.Contains("Ma_vt") Then TxtMa_Vt.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Vt")

        If DsTmp.Tables(0).Columns.Contains("Ten_vt") Then TxtTen_Vt.Text = DsTmp.Tables(0).Rows(0).Item("Ten_vt")
        TxtVi_tri.Text = ""

        'If DsTmp.Tables(0).Columns.Contains("Dien_giai") Then TxtDien_giai.Text = DsTmp.Tables(0).Rows(0).Item("Dien_giai")

        CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()

    End Sub
    Private Sub V_SelectFile(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, DetailGRV, Dt_Ro, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        Dt_Ro.Clear()

        For Each dr As DataRow In tbImport.Select("Ma_vt<>''")
            Dt_Ro.ImportRow(dr)
        Next
        Dt_Ro.AcceptChanges()
        For i As Integer = 0 To Dt_Ro.Rows.Count - 1
            Dt_Ro.Rows(i).BeginEdit()
            Dt_Ro.Rows(i).Item("FTag") = "1"
            Dt_Ro.Rows(i).EndEdit()
        Next

        Dt_Ro.AcceptChanges()
        DetailGRV1.UpdateCurrentRow()
    End Sub
    Private Sub L_So_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = Now.Date
        ' TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_ReFresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _So_Ro As String = TxtSo_Ro.Text.Trim
        If _So_Ro = "" Then Exit Sub
        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_ReFresh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadRo("3", "4")
        CyberFill.V_FillVoucher(DetailGRV1, M_LAN, Dv_Ro_H1, Dv_Ro1)
        DetailGRV1.GridControl.DataSource = Dv_Ro1
        UpdateList()
    End Sub

    Private Sub V_SelectAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dt_Ro.Rows.Count - 1
            Dt_Ro.Rows(i).BeginEdit()
            Dt_Ro.Rows(i).Item("FTag") = "1"
            Dt_Ro.Rows(i).EndEdit()
        Next
        Dt_Ro.AcceptChanges()
        DetailGRV1.UpdateCurrentRow()

    End Sub
    Private Sub V_RemoveAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dt_Ro.Rows.Count - 1
            Dt_Ro.Rows(i).BeginEdit()
            Dt_Ro.Rows(i).Item("FTag") = "0"
            Dt_Ro.Rows(i).EndEdit()
        Next
        Dt_Ro.AcceptChanges()
        DetailGRV1.UpdateCurrentRow()

    End Sub
    Private Sub V_GetColumn()
        EditMa_VT.GetColumn(DetailGRV, "Ma_VT")
        EditTen_Vt.GetColumn(DetailGRV, "Ten_VT")
        EditDvt.GetColumn(DetailGRV, "Dvt")
        EditSL_RO.GetColumn(DetailGRV, "SL_RO")
        EditSL_Xuat.GetColumn(DetailGRV, "SL_Xuat")
        EditSL_Da_Xuat.GetColumn(DetailGRV, "SL_Da_Xuat")
        EditSL_Xuat_Pick.GetColumn(DetailGRV, "SL_Xuat_Pick")
        EditSL_Da_Xuat_Pick.GetColumn(DetailGRV, "SL_Da_Xuat_Pick")
        EditGia2.GetColumn(DetailGRV, "Gia2")
        EditThue.GetColumn(DetailGRV, "Thue")
        EditSo_RO.GetColumn(DetailGRV, "SO_RO")
        Editma_cv.GetColumn(DetailGRV, "Ma_cv")
        EditTen_cv3.GetColumn(DetailGRV, "Ten_cv3")
        Editma_ctcv.GetColumn(DetailGRV, "Ma_ctcv")
        EditStt_rec0.GetColumn(DetailGRV, "Stt_rec0")
        EditGhi_chu.GetColumn(DetailGRV, "Ghi_chu")
        Editso_ct0.GetColumn(DetailGRV, "So_ct0")
        Editngay_ct0.GetColumn(DetailGRV, "Ngay_ct0")
        Editma_ct.GetColumn(DetailGRV, "ma_ct")
        EditFtag.GetColumn(DetailGRV, "Ftag")
        EditNgay_DK.GetColumn(DetailGRV, "Ngay_DK")
        EditGhi_chu.GetColumn(DetailGRV, "Ghi_chu")

    End Sub
    Private Sub DetailGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuChoGRV.ItemLinks.Clear()
        PopupMenuChoGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Cập nhật vị trí vật tư", AddressOf V_CongViec, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenuChoGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_ReFresh, Nothing, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenuChoGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Chọn tất cả", AddressOf V_SelectAllRo, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenuChoGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Bỏ chọn tất cả", AddressOf V_RemoveAllRo, Nothing, Nothing, True, True), True).BeginGroup = True


        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub DetailGRV1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuChoGRV.ItemLinks.Clear()

        PopupMenuChoGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_ReFresh1, Nothing, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim Dt_Master As New DataTable
        Dim vDt_Master As New DataView
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim CyberColor As New Cyber.Color.Sys
        Grid = sender

        If Grid.DataSource.GetType.Name.Trim.ToUpper = "DATAVIEW" Then
            vDt_Master = Grid.DataSource
            Dt_Master = vDt_Master.Table
        Else
            Dt_Master = Grid.DataSource
        End If

        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If

        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub V_CongViec(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = Tao_Px("1", -1)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
    End Sub
    Private Function Tao_Px(ByVal _Loai As String, ByVal iRow As Integer) As String

        _StrSave = ""
        Dim j As Integer = 0
        Dim nCount As Integer = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Ro.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "',N'" & Dv_Ro.Item(i).Item("Ftag").ToString.Trim & "',N'" & Dv_Ro.Item(i).Item("MA_VITRI").ToString.Trim & "'"
        Next
        If _StrSave = "" Then Return ""

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ApprolSDMVT", _Loai + "#" + _StrSave & "#" & TxtVi_tri.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Stt_Rec As String = ""

        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) = True Then
            _Stt_Rec = DsTmp.Tables(0).Rows(0).Item("Stt_Rec")
            DsTmp.Dispose()
        End If
        MsgBox("Cập nhật thông tin thành công !", MsgBoxStyle.OkOnly, "Sửa vị trí vật tư")

        Return _Stt_Rec
    End Function

    Private Sub V_History_Xuat1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("1")
    End Sub
    Private Sub V_History_Xuat2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("2")
    End Sub
    Private Sub V_History_Xuat3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("3")
    End Sub
    Private Sub V_History_Xuat(ByVal _Loai As String)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        Dim _ma_VT As String = ""
        Dim _So_RO As String = TxtSo_Ro.Text.Trim
        Dim _Stt_Rec As String = ""
        If iRow >= 0 Then _ma_VT = Dv_Ro.Item(iRow).Item("Ma_Vt")

        Dim _Title As String = "LỊCH SỬ XUẤT KHO"
        Dim _Cp_name As String
        Dim _StrFilter As String = ""
        Dim M_Ma_CT As String = "PXK"

        _StrFilter = _Loai & "#" & _So_RO.Trim & "#" & _ma_VT.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim
        _Cp_name = "CP_RoXemLichsuPX"
        _Title = "LỊCH SỬ XUẤT KHO"

        If _Loai = "3" Then
            M_Ma_CT = "PIC"
            _Cp_name = "CP_RoXemLichsuPIC"
        End If
        '--------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_XemPhieuXuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _So_Ro As String = TxtSo_Ro.Text.Trim
        Dim _Stt_Rec As String = ""

        If _So_Ro = "" Then Exit Sub
        Dim _Title As String = "DANH SÁCH XE SỬA CHỮA XONG"
        Dim _Cp_name As String
        Dim _StrFilter As String = ""
        Dim M_Ma_CT As String = "HDK"

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 1 Stt_Rec FROM dbo.Ph89 WITH (NOLOCK) WHERE So_Ro  = '" + _So_Ro + "'")
        If Dstmp.Tables(0).Rows.Count > 0 Then _Stt_Rec = Dstmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
        Dstmp.Dispose()

        _StrFilter = _Stt_Rec.Trim + "#" + _So_Ro.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim
        _Cp_name = "CP_RoXemPX"
        _Title = "TÌNH HÌNH XUẤT KHO"
        '--------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Ma_vt_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "ma_vt", "DMvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vt.Text = "" Then
            TxtTen_Vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_Vt.Text = DrReturn.Item("Ten_vt")

        Else
            TxtMa_Vt.Text = ""
            TxtTen_Vt.Text = ""


        End If
        If TxtMa_Vt.Text = "" Then
            TxtTen_Vt.Text = ""

            Exit Sub
        End If
    End Sub
    Private Sub V_Ma_nh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_vt.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "ma_nh", "DMnhvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_nh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_vt.Text = "" Then
            TxtTen_nh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_vt.Text = DrReturn.Item("ma_nh")
            TxtTen_nh.Text = DrReturn.Item("Ten_nh")

        Else
            TxtNh_vt.Text = ""
            TxtTen_nh.Text = ""


        End If
        If TxtNh_vt.Text = "" Then
            TxtTen_nh.Text = ""

            Exit Sub
        End If
    End Sub
    Private Sub V_danh_sach(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim _status As String = "1"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetROSDMVTDetail_Search", _status & "#" & TxtMa_Vt.Text.ToString.Trim & "#" & TxtNh_vt.Text.ToString.Trim & "#" & IIf(Chkis_Hd.Checked, "1", "0") & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name)

        'If ChkPick.Checked = True Then _Pick = "1"

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))

        Next


        Dt_Ro.Clear()

        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_Ro)
        'If DsTmp.Tables(0).Columns.Contains("so_ro") Then TxtSo_Ro.Text = DsTmp.Tables(0).Rows(0).Item("so_ro")
        TxtSo_Ro.Text = ""
        Dt_Ro.AcceptChanges()
        CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()

    End Sub

    Private Sub V_Update(ByVal sender As System.Object, ByVal e As System.EventArgs)

        V_CongViec(sender, e)



    End Sub




    'Private Sub V_Sanh_Sach(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Frm As New ROSNKFilter
    '    Frm.Lan = M_LAN
    '    Frm.Para = Me.Para
    '    Frm.Sysvar = Me.Sysvar
    '    Frm.AppConn = AppConn
    '    Frm.CyberSmlib = CyberSmlib
    '    Frm.CyberSupport = CyberSupport
    '    Frm.CyberFill = CyberFill
    '    Frm.CyberSmlistSys = CyberSmlistSys
    '    Frm.CyberSmodb = CyberSmodb
    '    Frm.CyberExport = Nothing
    '    Frm.CyberVoucher = CyberVoucher
    '    Frm.CyberLoading = CyberLoading
    '    Frm.ShowInTaskbar = False
    '    Frm.ShowDialog()
    '    If Not Frm.Save_OK Then Exit Sub
    '    Dim _strParameterStore As String = Frm.Tag.ToString.Trim
    '    Dim _Stt_rec As String = ""

    '    Dim _Cp_name As String = "CP_ROSNKFilter"
    '    Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _Cp_name, "1#" + _strParameterStore)

    '    Dim _Dt_master As DataTable = DsTmp.Tables(0).Copy
    '    Dim _Dt_Detail As DataTable = DsTmp.Tables(1).Copy
    '    Dim _Dt_masterH As DataTable = DsTmp.Tables(2).Copy
    '    Dim _Dt_DetailH As DataTable = DsTmp.Tables(3).Copy

    '    Dim _Dv_master As DataView = New DataView(_Dt_master)
    '    Dim _Dv_Detail As DataView = New DataView(_Dt_Detail)
    '    Dim _Dv_masterH As DataView = New DataView(_Dt_masterH)
    '    Dim _Dv_DetailH As DataView = New DataView(_Dt_DetailH)

    '    If _Dt_master.Rows.Count <= 0 Then
    '        DsTmp.Dispose()
    '        Exit Sub
    '    End If

    '    _Stt_rec = _Dv_master.Item(0).Item("Stt_Rec").ToString.Trim

    '    Dim FrmX As New ROSNKView
    '    '------------------------------------------------
    '    FrmX.strLoc = "0#" + _strParameterStore
    '    FrmX.Cp_Loc = _Cp_name
    '    FrmX.Dt_Master = _Dt_master
    '    FrmX.Dt_Detail = _Dt_Detail
    '    FrmX.Dt_MasterH = _Dt_masterH
    '    FrmX.Dt_DetailH = _Dt_DetailH
    '    FrmX.Title = "Xem lệnh nhập kho"
    '    FrmX.Stt_Rec = _Stt_rec
    '    '-------------------------------------------------
    '    FrmX.Lan = M_LAN
    '    FrmX.Para = Me.Para
    '    FrmX.Sysvar = Me.Sysvar
    '    FrmX.AppConn = AppConn
    '    FrmX.CyberSmlib = CyberSmlib
    '    FrmX.CyberSupport = CyberSupport
    '    FrmX.CyberFill = CyberFill
    '    FrmX.CyberSmlistSys = CyberSmlistSys
    '    FrmX.CyberSmodb = CyberSmodb
    '    FrmX.CyberExport = Nothing
    '    FrmX.CyberVoucher = CyberVoucher
    '    FrmX.CyberLoading = CyberLoading
    '    'FrmX.ShowInTaskbar = False
    '    FrmX.ShowDialog()

    '    If Not Frm.Save_OK Then
    '        DsTmp.Dispose()
    '        Exit Sub
    '    End If

    '    Dim _Dr_View_Return As DataRowView = FrmX.Dr_View_Return
    '    If _Dr_View_Return Is Nothing Then
    '        DsTmp.Dispose()
    '        Exit Sub
    '    End If
    '    If _Dr_View_Return.DataView.Table.Columns.Contains("Ma_kh") Then
    '        TxtSo_Ro.Text = _Dr_View_Return.Item("Ma_kh").ToString.Trim
    '        L_So_RO(sender, e)
    '    End If

    '    DsTmp.Dispose()

    'End Sub
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_Tien2 As Decimal = 0
        'Dim nT_Thue As Decimal = 0
        'Dim nT_TT As Decimal = 0
        'For iRow As Integer = 0 To Dv_Ro.Count() - 1
        '    nT_Tien2 = nT_Tien2 + Dv_Ro.Item(iRow).Item("Tien2")
        '    nT_Thue = nT_Thue + Dv_Ro.Item(iRow).Item("Thue")
        'Next

        'nT_TT = nT_Tien2 + nT_Thue
        'TxtT_Tien2.Double = nT_Tien2
        'TxtT_thue.Double = nT_Thue
        'TxtT_TT.Double = nT_TT
    End Sub
#End Region


    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not ChkRightsVoucher("P") Then Exit Sub
        'If M_Stt_Rec.Trim = "" Then Exit Sub
        'Dim _Dt As Date = TxtNgay_Ct.Value
        'Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        'CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

        'CyberVoucher.V_PrintVocuher(AppConn, Sysvar, Nothing, _Stt_Rec, _Dt, _Ma_Post, M_LAN, Para, DrDmct, "PXK", M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

    End Sub

#Region "Vali --- Ma_Hs_H"

#End Region
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub V_Chks(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text = "" Then Exit Sub
        ''abc
        V_LoadRo("3", "4")

    End Sub

#End Region

End Class

