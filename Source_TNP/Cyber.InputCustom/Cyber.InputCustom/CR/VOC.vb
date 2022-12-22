Imports System.Data.SqlClient
Public Class VOC
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim M_Ma_THue As String
    Dim _tbTiep_Nhan, _tbMuc_Do, _tbTrach_Nhiem, _tbHai_Long As DataTable
    Public vTbTiep_nhan, vTbMuc_do, vTbTrach_nhiem, vtbHai_long As DataView
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"    
    Dim EditMa_Lv, EditTen_LV, EditMa_VD, EditMa_BPHH, EditTen_BPHH, EditMa_CTVD, EditTen_CTVD, EditNgay_TT, EditDien_GiaiTTCT As New Cyber.Fill.CyberColumnGridView
    Dim EditDien_GiaiNNKN, EditMa_Hs_i, EditMa_BP_i, EditMa_Loi_NN, EditTen_Loi_NN As New Cyber.Fill.CyberColumnGridView
    Dim EditDien_GiaiHGQ, EditNgay_GQ, EditDien_GiaiTTGQ As New Cyber.Fill.CyberColumnGridView
    Dim EditThac_Mac, EditTra_Loi, EditMa_LvTM, EditTen_LVTM, EditMa_VDTM, EditTen_VDTM As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable

    Dim M_Ma_Hl_Ngam_Dinh As String = ""
    Dim M_Ma_MD_Ngam_Dinh As String = ""
    Dim M_Ma_TN_Ngam_Dinh As String = ""
    Dim M_Ma_Tiep_nhan_Ngam_Dinh As String = ""
    Dim Dt_DetailTTCT, Dt_DetailNNKN, Dt_DetailHGQ, Dt_DetailTTGQ, Dt_DetailTMYC, Dt_DetailRKN, Dt_DetailTTCTtmp, Dt_DetailNNKNtmp, Dt_DetailHGQtmp, Dt_DetailTTGQtmp, Dt_DetailTMYCtmp, Dt_DetailRKNtmp, _Dt_Bp_Hs As New DataTable
    Dim Dv_DetailTTCT, Dv_DetailNNKN, Dv_DetailHGQ, Dv_DetailTTGQ, Dv_DetailTMYC, Dv_DetailRKN, Dv_DetailTTCTTmp, Dv_DetailNNKNtmp, Dv_DetailHGQtmp, Dv_DetailTTGQtmp, Dv_DetailTMYCtmp, Dv_DetailRKNtmp As New DataView

#End Region
    Private Sub VOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_GetColumn()
        V_AddHandler()
        V_LoadTTGQ("1")
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        GetRound()
        CmdNew.Select()
        V_LoadNew(sender, e)
    End Sub
#Region "Load And Set And Default"

    Dim _Para_So_RO As String = ""
    Dim _Para_Ma_Hd As String = ""


    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec <> "" Then Exit Sub
        If _Para_So_RO = "" And _Para_Ma_Hd = "" Then Exit Sub

        V_New(sender, e)
        If Not M_Mode = "M" Then Exit Sub

        If _Para_So_RO <> "" Then
            TxtLenh_RO.Text = _Para_So_RO
            CmbMa_GD.SelectedValue = "1"
            L_Lenh_Ro(sender, e)
            Return
        End If

        If _Para_Ma_Hd <> "" Then
            TxtMa_HD_H.Text = _Para_Ma_Hd
            CmbMa_GD.SelectedValue = "3"
            L_Ma_HD_H(sender, e)
            Return
        End If
    End Sub
    Dim Dt_headTTGQ As DataTable
    Dim Dv_headTTGQ As DataView

    Private Sub V_LoadTTGQ(ByVal Status As String)

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOC_TTGQFromKN", Status + "#" + M_Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        If Status = "1" Then
            Dt_DetailTTGQtmp = Dstmp.Tables(0).Copy
            Dt_headTTGQ = Dstmp.Tables(1).Copy
            Dv_DetailTTGQtmp = New DataView(Dt_DetailTTGQtmp)
            Dv_headTTGQ = New DataView(Dt_headTTGQ)

            DetailTTGQ.DataSource = Dv_DetailTTGQtmp
            Me.DetailGRVTTGQ.GridControl = Me.DetailTTGQ
            CyberFill.V_FillVoucher(DetailGRVTTGQ, M_LAN, Dv_headTTGQ, Dv_DetailTTGQtmp, Me.DrDmct)
        Else
            Dt_DetailTTGQtmp.Clear()
            CyberSmodb.SQLTbToTb(Dstmp.Tables(0), Dt_DetailTTGQtmp)

            Dt_DetailTTGQtmp.AcceptChanges()
        End If
        Dstmp.Dispose()
        UpdateList()
    End Sub
    Private Sub V_loadMa_Hs()
        Dim Ds_Bp_HS As New DataSet
        Ds_Bp_HS = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetBpHs", M_User_Name.ToString().Trim())
        CyberSmodb.SetNotNullTable(Ds_Bp_HS.Tables(0))
        TxtMa_BPTN.Text = Ds_Bp_HS.Tables(0).Rows(0).Item("Ma_Hs_H")
        TxtTen_BPTN.Text = Ds_Bp_HS.Tables(0).Rows(0).Item("Ten_Hs_H")
        TxtMa_BP_H.Text = Ds_Bp_HS.Tables(0).Rows(0).Item("Ma_BP_H")
        TxtTen_BP_H.Text = Ds_Bp_HS.Tables(0).Rows(0).Item("Ten_BP_H")

    End Sub
    Private Sub V_Load()
        V_Getdefault()
        '--GridKNYC
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        ' Ph
        Dt_Master = M_DsData.Tables(1)
        '--GridTTCT
        Dt_DetailTTCT = M_DsData.Tables(2)
        Dt_DetailTTCTtmp = Dt_DetailTTCT.Clone
        '--GridNNKN
        Dt_DetailNNKN = M_DsData.Tables(3)
        Dt_DetailNNKNtmp = Dt_DetailNNKN.Clone
        '--GridTTGQ
        Dt_DetailTTGQ = M_DsData.Tables(4)
        Dt_DetailTTGQtmp = Dt_DetailTTGQ.Clone
        '--GridKNYC
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        '--GridTTCT
        Dv_DetailTTCT = New DataView(Dt_DetailTTCT)
        Dv_DetailTTCTTmp = New DataView(Dt_DetailTTCTtmp)
        '--GridNNKN
        Dv_DetailNNKN = New DataView(Dt_DetailNNKN)
        Dv_DetailNNKNtmp = New DataView(Dt_DetailNNKNtmp)
        '--GridTTGQ
        Dv_DetailTTGQ = New DataView(Dt_DetailTTGQ)
        Dv_DetailTTGQtmp = New DataView(Dt_DetailTTGQtmp)
        ' Ph
        Dv_Master = New DataView(Dt_Master)

        DetailKNYC.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.DetailKNYC
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)

        DetailTTCT.DataSource = Dv_DetailTTCTTmp
        Me.DetailGRVTTCT.GridControl = Me.DetailTTCT
        CyberFill.V_FillVoucher(DetailGRVTTCT, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailTTCTTmp, Me.DrDmct)

        DetailNNKN.DataSource = Dv_DetailNNKNtmp
        Me.DetailGRVNNKN.GridControl = Me.DetailNNKN
        CyberFill.V_FillVoucher(DetailGRVNNKN, M_LAN, New DataView(M_DsHead.Tables(3)), Dv_DetailNNKNtmp, Me.DrDmct)

        DetailTTGQ.DataSource = Dv_DetailTTGQtmp
        Me.DetailGRVTTGQ.GridControl = Me.DetailTTGQ
        CyberFill.V_FillVoucher(DetailGRVTTGQ, M_LAN, New DataView(M_DsHead.Tables(4)), Dv_DetailTTGQtmp, Me.DrDmct)

        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
    End Sub
    Private Sub V_Getdefault()
        M_strFilter = Me.strFilter
        M_DrDmct = Me.DrDmct
        M_Ph = M_DrDmct.Item("M_Ph").ToString.Trim
        M_Ct = M_DrDmct.Item("M_Ct").ToString.Trim

        osysvar = Me.SysVar
        M_Stt_Rec = Me.Stt_Rec
        M_LAN = Me.Lan
        M_Para = Me.Para
        AppConn = Me.AppConn
        M_DsData = Me.DsData
        M_DsHead = Me.DsHead
        M_DsLookUp = Me.DsLookup

        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        K_Tmp = M_Para(1).Trim
        K_System = M_Para(2).Trim
        K_Repo = M_Para(3).Trim
        K_Repo_Nt = M_Para(4).Trim
        M_CYBER_VER = M_Para(5).Trim
        M_User_Name = M_Para(6).Trim
        M_Comment = M_Para(7).Trim
        M_is_Admin = CType(M_Para(8), Boolean)
        M_User_ID = M_Para(9).Trim
        M_Menu_ID0 = M_Para(10).Trim
        M_Bar = M_Para(11).Trim
        M_Bar2 = M_Para(12).Trim
        M_LAN = M_Para(13).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_GD = M_Para(M_VT_PARA + 1).Trim
        M_Ma_CT = M_Para(M_VT_PARA + 2).Trim
        M_Ma_THue = M_Para(M_VT_PARA + 3).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        _Para_Ma_Hd = ""
        Try
            _Para_Ma_Hd = M_Para(M_VT_PARA + 4).Trim
        Catch ex As Exception

        End Try
        _Para_So_RO = ""
        Try
            _Para_So_RO = M_Para(M_VT_PARA + 5).Trim
        Catch ex As Exception

        End Try
        V_LoadDefaultVOC()
        '---------------------------------------------------------------------------------------------'
        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Tk_No = DrDmct.Item("M_Tk_No").ToString.Trim
        M_Tk_Co = DrDmct.Item("M_Tk_Co").ToString.Trim
        M_Tk_Thue = DrDmct.Item("M_Tk_Thue").ToString.Trim
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        If M_Tk_No.Trim <> "" Then M_Ten_Tk_No = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_No.Trim + "'", CyberSmlib) Else M_Ten_Tk_No = ""
        If M_Tk_Co.Trim <> "" Then M_Ten_Tk_Co = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Co.Trim + "'", CyberSmlib) Else M_Ten_Tk_Co = ""
        If M_Tk_Thue.Trim <> "" Then M_Ten_Tk_Thue = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "Dmtk", "Tk = N'" + M_Tk_Thue.Trim + "'", CyberSmlib) Else M_Ten_Tk_Thue = ""

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CmbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

        V_LoadDefault()
    End Sub
    Private Sub V_LoadDefaultVOC()
        Dim DsVOC As New DataSet
        DsVOC = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOC_GetDefault", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        _tbMuc_Do = DsVOC.Tables(0).Copy
        vTbMuc_do = New DataView(_tbMuc_Do)

        _tbHai_Long = DsVOC.Tables(1).Copy
        vtbHai_long = New DataView(_tbHai_Long)

        _tbTrach_Nhiem = DsVOC.Tables(2).Copy
        vTbTrach_nhiem = New DataView(_tbTrach_Nhiem)

        _tbTiep_Nhan = DsVOC.Tables(3).Copy
        vTbTiep_nhan = New DataView(_tbTiep_Nhan)
        _Dt_Bp_Hs = DsVOC.Tables(4).Copy
        DsVOC.Dispose()
        '--------------------------------------------------------------------------------------------
        '=========== FillCombox
        CyberFill.V_FillComBoxValue(CmbHai_Long, vtbHai_long, "ma_HL", "Ten_HL", "")
        CyberFill.V_FillComBoxValue(CmbMuc_Do, vTbMuc_do, "Ma_Md", "Ten_Md", "")
        CyberFill.V_FillComBoxValue(CmbTiep_Nhan, vTbTiep_nhan, "Ma_Tiep_nhan", "Ten_Tiep_nhan", "")
        CyberFill.V_FillComBoxDefaul(CmbTrach_Nhiem, vTbTrach_nhiem, "Ma_TN", "Ten_TN", "Ngam_Dinh")

        '--------------------------------------------------------------------------------------------
        If _tbTrach_Nhiem.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To _tbTrach_Nhiem.Rows.Count - 1
                If _tbTrach_Nhiem.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_TN_Ngam_Dinh = _tbTrach_Nhiem.Rows(i).Item("ma_TN").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If _tbHai_Long.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To _tbHai_Long.Rows.Count - 1
                If _tbHai_Long.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Hl_Ngam_Dinh = _tbHai_Long.Rows(i).Item("ma_HL").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If _tbMuc_Do.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To _tbMuc_Do.Rows.Count - 1
                If _tbMuc_Do.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_MD_Ngam_Dinh = _tbMuc_Do.Rows(i).Item("ma_MD").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If _tbTiep_Nhan.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To _tbTiep_Nhan.Rows.Count - 1
                If _tbTiep_Nhan.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Tiep_nhan_Ngam_Dinh = _tbTiep_Nhan.Rows(i).Item("Ma_Tiep_Nhan").ToString.Trim
                    Exit For
                End If
            Next
        End If
        '---------------------------------------------------------------------------------------------'
        If _Dt_Bp_Hs.Columns.Contains("Ma_Hs_H") Then TxtMa_BPTN.Text = _Dt_Bp_Hs.Rows(0).Item("Ma_Hs_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_Hs_H") Then TxtTen_BPTN.Text = _Dt_Bp_Hs.Rows(0).Item("Ten_Hs_H")
        If _Dt_Bp_Hs.Columns.Contains("Ma_BP_H") Then TxtMa_BP_H.Text = _Dt_Bp_Hs.Rows(0).Item("Ma_BP_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_BP_H") Then TxtTen_BP_H.Text = _Dt_Bp_Hs.Rows(0).Item("Ten_BP_H")
    End Sub
    Private Sub V_SetProperty()
        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")

        If FixCol < DetailGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

        If FixCol < DetailGRVTTCT.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVTTCT.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVTTCT.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVTTCT.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        '--GridKNYC
        EditMa_lv.GetColumn(DetailGRV, "Ma_Lv")
        EditTen_LV.GetColumn(DetailGRV, "Ten_LV")
        EditMa_VD.GetColumn(DetailGRV, "Ma_VD")
        EditMa_BPHH.GetColumn(DetailGRV, "Ma_BPHH")
        EditMa_CTVD.GetColumn(DetailGRV, "Ma_CTVD")
        '--GridNNKN
        EditMa_BP_i.GetColumn(DetailGRVNNKN, "Ma_BP_I")
        EditMa_Hs_i.GetColumn(DetailGRVNNKN, "Ma_Hs_I")
        EditMa_Loi_NN.GetColumn(DetailGRVNNKN, "Ma_loi_NN")

    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtLenh_RO.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtLenh_RO.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
        AddHandler Me.KeyDown, AddressOf FrmMain_KeyDown
        '---
        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdNew.Click, AddressOf V_New
        AddHandler CmdEdit.Click, AddressOf V_Edit
        AddHandler CmdDelete.Click, AddressOf V_Delete
        AddHandler CmdCancel.Click, AddressOf V_Cancel
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdView.Click, AddressOf V_View
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler CmdExit.Click, AddressOf V_Exit

        AddHandler CmdImport.Click, AddressOf V_Import
        AddHandler CmdCopy.Click, AddressOf V_Copy
        '---
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        AddHandler DetailGRVTTCT.PopupMenuShowing, AddressOf MasterGRVTTCT_PopupMenuShowing
        AddHandler DetailGRVTTCT.KeyDown, AddressOf MasterGRVTTCT_KeyDown
        '---
        AddHandler DetailGRVNNKN.PopupMenuShowing, AddressOf MasterGRVNNKN_PopupMenuShowing
        AddHandler DetailGRVNNKN.KeyDown, AddressOf MasterGRVNNKN_KeyDown

        '---
        AddHandler DetailGRVTTGQ.PopupMenuShowing, AddressOf MasterGRVTTGQ_PopupMenuShowing
        AddHandler DetailGRVTTGQ.KeyDown, AddressOf MasterGRVTTGQ_KeyDown

        '---
        AddHandler CmbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro

        AddHandler CmdSo_Khung.Click, AddressOf V_So_Khung
        AddHandler CmdMa_Xe.Click, AddressOf V_Ma_Xe
        '
        'Ma_BPTN
        AddHandler TxtMa_BPTN.CyberValiting, AddressOf V_Ma_BPTN
        AddHandler TxtMa_BPTN.CyberLeave, AddressOf L_Ma_BPTN
        'Ma_BP_H
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H
        'DL_Bx
        AddHandler TxtDL_Bx.CyberValiting, AddressOf V_DL_Bx
        AddHandler TxtDL_Bx.CyberLeave, AddressOf L_DL_Bx
        'DL_Dv
        AddHandler TxtDL_Dv.CyberValiting, AddressOf V_DL_Dv
        AddHandler TxtDL_Dv.CyberLeave, AddressOf L_DL_Dv
        'Ma_HD_H        
        AddHandler TxtMa_HD_H.CyberValiting, AddressOf V_Ma_HD_H
        AddHandler TxtMa_HD_H.CyberLeave, AddressOf L_Ma_HD_H

        AddHandler TxtNgay_Dong.Leave, AddressOf V_Tinh_So_Ngay
        AddHandler TxtThoi_Gian.Leave, AddressOf V_Tinh_So_Ngay
    End Sub
    Private Sub V_AddHandler_Detail()       
        EditMa_Lv.V_ActiLookUpColumn(AddressOf V_Ma_Lv, AddressOf L_Ma_Lv)
        EditMa_BPHH.V_ActiLookUpColumn(AddressOf V_Ma_BPHH, AddressOf L_Ma_BPHH)
        EditMa_CTVD.V_ActiLookUpColumn(AddressOf V_Ma_CTVD, AddressOf L_Ma_CTVD)
        EditMa_VD.V_ActiLookUpColumn(AddressOf V_Ma_VD, AddressOf L_Ma_VD)
        '---
        EditMa_BP_i.V_ActiLookUpColumn(AddressOf V_Ma_BP_i, AddressOf L_Ma_BP_i)
        EditMa_Hs_i.V_ActiLookUpColumn(AddressOf V_Ma_Hs_i, AddressOf L_Ma_Hs_i)        
    End Sub
    Private Sub VisibleColumnMa_NT()
    End Sub
    Private Sub VisibleColumnMa_GD()
    End Sub
    Protected Overrides Sub V_Databing()
        Dim i As Integer
        Dim Drv As DataRowView
        Drv = Nothing

        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next
        CyberSmodb.SetValueTObj(Me, Drv)
        If Drv Is Nothing Then
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            CmbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
            CmbHai_Long.SelectedIndex = 0
            CmbTrach_Nhiem.SelectedIndex = 0
            CmbMuc_Do.SelectedIndex = 0
            CmbTiep_Nhan.SelectedIndex = 0
        End If
        Dt_DetailTmp.Clear()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        Dt_DetailTmp.AcceptChanges()

        'thông tin cần thiết
        Dt_DetailTTCTtmp.Clear()
        For i = 0 To Dt_DetailTTCT.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTTCTtmp.ImportRow(Dt_DetailTTCT.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        Dt_DetailTTCTtmp.AcceptChanges()

        'nguyên nhân khiếu nại
        Dt_DetailNNKNtmp.Clear()
        For i = 0 To Dt_DetailNNKN.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailNNKNtmp.ImportRow(Dt_DetailNNKN.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        Dt_DetailNNKNtmp.AcceptChanges()

        '-----------------------------------------------------------------------------------------------
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
        V_LoadTTGQ("1")
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            DetailGRVTTCT.OptionsBehavior.Editable = True

            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
            DetailGRVTTCT.OptionsBehavior.Editable = False
        End If
        If M_Mode = "M" Then CmbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
        SetTxt()
    End Sub
    Private Sub V_GetDateVoucher(ByVal _Mode As String, ByRef _Ngay_Ct As Date, ByRef _Ngay_LCT As Date)
        Dim _DtReturn As DataTable = CyberSupport.V_GetDateVoucher(_Mode, _Ngay_Ct, _Ngay_LCT, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        If _DtReturn Is Nothing Then Exit Sub Else If _DtReturn.Rows.Count <= 0 Then Exit Sub
        If Not _DtReturn.Columns.Contains("Status") Then Exit Sub
        If _DtReturn.Rows(0).Item("Status").ToString.Trim = "N" Then Exit Sub
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_LCt.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_Ct.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_Ct.Value
        _Ngay_LCT = TxtNgay_Ct.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And TxtSo_Ct.Text.Trim <> "" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Master"
#Region "Lenh/SO/Po/Ro/Vt"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_GetSo_SO(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_SO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_GetSo_PO(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_PO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_RO.Text = CyberVoucher.V_GetSo_Ro(M_Ma_CT, "S", M_Mode, _Dt, TxtLenh_RO.Text, M_Ma_Dvcs)
        If Not TxtLenh_RO.Text.Trim = "" Then L_VOCGetThongTin()
    End Sub
    Private Sub L_VOCGetThongTin()
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD_H.Text = "" And TxtLenh_RO.Text = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value

        Dim _Ma_GD As String = ""
        Try
            _Ma_GD = CmbMa_GD.SelectedValue
        Catch ex As Exception
        End Try

        Dim _StrF As String = ""
        Dim _StrV As String = ""
        CyberSmodb.GetValueControler(Me, _StrF, _StrV)

        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOC_GetInfo", M_Mode & "#" & M_Stt_Rec.Trim & "#" & M_Ma_CT & "#" & _Dt.ToString("yyyyMMdd") & "#" & _
                                                                   _Ma_GD & "#" & _
                                                                    _StrF & "#" & _
                                                                    _StrV & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If _Dstmp.Tables.Count = 0 Then
            _Dstmp.Dispose()
            Exit Sub
        End If

        For i As Integer = 0 To _Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(_Dstmp.Tables(i))
        Next

        If Not CyberSupport.V_MsgChk(_Dstmp.Tables(0), osysvar, M_LAN) Then
            _Dstmp.Dispose()
            Exit Sub
        End If

        If _Dstmp.Tables.Count = 1 Then
            _Dstmp.Dispose()
            Exit Sub
        End If

        If _Dstmp.Tables(1).Rows.Count = 0 Then
            _Dstmp.Dispose()
            Exit Sub
        End If
        If _Dstmp.Tables(1).Columns.Contains("Ma_DLbx") Then TxtDL_Bx.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_DLbx").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ma_DLdv") Then TxtDL_Dv.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_DLdv").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("ten_kh") Then TxtTen_Kh.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_KH").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Dia_Chi") Then TxtDia_Chi.Text = _Dstmp.Tables(1).Rows(0).Item("Dia_Chi")
        If _Dstmp.Tables(1).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_Xe")
        If _Dstmp.Tables(1).Columns.Contains("Ma_tvbh") Then TxtMa_TVBH.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_tvbh").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_tvbh") Then TxtTen_TVBH.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_tvbh").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ma_Hs") Then TxtMa_Hs.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_Hs").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_cvdv") Then TxtCVDV.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_cvdv").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ma_Kx") Then TxtMa_Kx.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_Kx").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_Kx") Then TxtTen_Kx.Text = _Dstmp.Tables(1).Rows(0).Item("ten_Kx").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("So_Km") Then TxtSo_Km.Text = _Dstmp.Tables(1).Rows(0).Item("So_Km").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Dien_Thoai") Then TxtDien_Thoai.Text = _Dstmp.Tables(1).Rows(0).Item("Dien_Thoai").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_LX") Then TxtTen_Lx.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_LX").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("DT_LX") Then TxtDT_LX.Text = _Dstmp.Tables(1).Rows(0).Item("DT_LX").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("So_khung") Then TxtSo_Khung.Text = _Dstmp.Tables(1).Rows(0).Item("So_khung").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_Xe").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("KTV") Then TxtKTV.Text = _Dstmp.Tables(1).Rows(0).Item("KTV").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ngay_mua") Then TxtNgay_Mua.Value = _Dstmp.Tables(1).Rows(0).Item("Ngay_mua")
        If _Dstmp.Tables(1).Columns.Contains("Ma_to") Then TxtMa_To.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_to").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_to") Then TxtTen_To.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_to").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ma_tobh") Then TxtMa_toBH.Text = _Dstmp.Tables(1).Rows(0).Item("Ma_tobh").ToString.Trim
        If _Dstmp.Tables(1).Columns.Contains("Ten_toBh") Then TxtTen_ToBH.Text = _Dstmp.Tables(1).Rows(0).Item("Ten_toBH").ToString.Trim

        Dim nCount As Integer = Dt_DetailTTCTtmp.Rows.Count
        For i = nCount - 1 To 0 Step -1
            Dt_DetailTTCTtmp.Rows(i).Delete()
            Dt_DetailTTCTtmp.AcceptChanges()
        Next
        CyberSmodb.SetNotNullTable(_Dstmp.Tables(2))
        CyberSmodb.SQLTbToTb(_Dstmp.Tables(2), Dt_DetailTTCTtmp)
        _Dstmp.Dispose()
        UpdateList()
    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_VT.Text = CyberVoucher.V_GetSo_VT(M_Ma_CT, CmbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_VT.Text, TxtMa_Dvcs.Text)
    End Sub
#End Region
#Region "Valid - Ma_BPTN"
    Private Sub V_Ma_BPTN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_BPTN.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BPTN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BPTN.Text = "" Then
            TxtTen_BPTN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BPTN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BPTN.Text = DrReturn.Item("Ma_Hs")
            TxtTen_BPTN.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_BPTN.Text = ""
            TxtTen_BPTN.Text = ""
        End If
    End Sub
#End Region
#Region "Valid - Ma_BP_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_BP_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP_H.Text = DrReturn.Item("Ten_bp")
        Else
            TxtMa_BP_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- DL_Bx"
    Private Sub V_DL_Bx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtDL_Bx.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_DL", "DmDaiLy", "1=1", "1=1")
    End Sub
    Private Sub L_DL_Bx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtDL_Bx.Text = "" Then
            TxtDL_Bx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtDL_Bx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtDL_Bx.Text = DrReturn.Item("Ma_DL")
        Else
            TxtDL_Bx.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- DL_Dv"
    Private Sub V_DL_Dv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtDL_Dv.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_DL", "DmDaiLy", "1=1", "1=1")
    End Sub
    Private Sub L_DL_Dv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtDL_Dv.Text = "" Then
            TxtDL_Dv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtDL_Dv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtDL_Dv.Text = DrReturn.Item("Ma_DL")
        Else
            TxtDL_Dv.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HD_H"
    Private Sub V_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HD_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD_H.Text = "" Then
            Exit Sub
        End If
        DrReturn = TxtMa_HD_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD_H.Text = DrReturn.Item("Ma_HD")
        End If
        If Not TxtMa_HD_H.Text.Trim = "" Then L_VOCGetThongTin()
    End Sub
#End Region
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_Tien_NT2 As Decimal = 0
        Dim nT_Tien2 As Decimal = 0

        Dim nT_Tien_NT As Decimal = 0
        Dim nT_Tien As Decimal = 0
        Dim nT_TT_NT As Decimal = 0
        Dim nT_TT As Decimal = 0
        Dim nT_Tien_RO As Decimal = 0

        Dim nT_So_Luong As Decimal = 0


    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)

        V_Tinh_Toan(iRow)
    End Sub
    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = TxtDien_Giai.Text
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        DetailGRV.ShowEditor()
    End Sub
#End Region
#Region "Vat tu kho/Vitri - "
    Private Sub V_Ma_Lo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Lo(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Lo(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Ma_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("MA_VT").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _TK_VT As String = DrReturn.Item("TK_Vt")
        Dim _TK_DT As String = DrReturn.Item("TK_DT")
        Dim _Tk_Gv As String = DrReturn.Item("Tk_Gv")
        Dim _Tk_CK As String = If(DrReturn.Table.Columns.Contains("TK_CK"), DrReturn.Item("Tk_CK"), "")
        Dim _Ma_kho As String = DrReturn.Item("Ma_kho")
        Dim _Ma_Vitri As String = DrReturn.Item("Ma_Vitri")

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tk_VT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim = "", _TK_VT, Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_DT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_DT").ToString.Trim = "", _TK_DT, Dv_DetailTmp.Item(iRow).Item("Tk_DT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_GV") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_GV").ToString.Trim = "", _Tk_Gv, Dv_DetailTmp.Item(iRow).Item("TK_GV").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_CK") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_CK").ToString.Trim = "", _Tk_CK, Dv_DetailTmp.Item(iRow).Item("Tk_CK").ToString.Trim)

        Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I").ToString.Trim = "", _Ma_kho, Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim = "", _Ma_Vitri, Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim)
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPriceSales(iRow)
        V_SetSD(iRow)
        UpdateList()

    End Sub
    Private Sub V_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetPriceSales(iRow)
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim
        Dim _Ma_kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _Ma_Vitri As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
    Private Sub V_SetPriceSales(ByVal iRow As Integer)
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_SO(Dv_DetailTmp, iRow, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_PO(Dv_DetailTmp, iRow, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_Ro(Dv_DetailTmp, iRow, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_VT(Dv_DetailTmp, iRow, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
#End Region
#Region "Valid - Detail - Add On"
    Private Sub V_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    'Private Sub V_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    CyberSupport.V_Ma_BP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    'End Sub
    'Private Sub L_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CyberSupport.L_Ma_BP_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    'End Sub
    'Private Sub V_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    'End Sub
    'Private Sub L_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    'End Sub
    Private Sub V_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Db_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kx_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Tuyen_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Tuyen_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Ts(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ts(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ts(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cc(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cc(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
    Private Sub V_Ma_Lv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Lv", "CRMDMLVKN", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("Ma_Lv").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Lv") = DrReturn.Item("Ma_Lv").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ten_LV") = DrReturn.Item("Ten_Lv").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_Ma_BPHH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ma_Lv As String = Dv_DetailTmp.Item(iRow).Item("Ma_Lv").ToString.Trim
        Dim _ma_vd As String = Dv_DetailTmp.Item(iRow).Item("Ma_VD").ToString.Trim
        '
        CyberSupport.V_Lookup("Ma_BPHH", "CRMDMBPHH", "Ma_Lv = '" + _Ma_Lv + "' AND Ma_VD = '" + _ma_vd + "'", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_BPHH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_BPHH") = ""
            Dv_DetailTmp.Item(iRow)("Ten_BPHH") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_BPHH") = DrReturn.Item("Ma_BPHH").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ten_BPHH") = DrReturn.Item("Ten_BPHH").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()

        If Dv_DetailTmp.Item(iRow).Item("Ma_BPHH") = "" Then
            Dv_DetailTmp.Item(iRow).Item("Ten_BPHH") = ""
        End If

        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_Ma_CTVD(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ma_Lv As String = Dv_DetailTmp.Item(iRow).Item("Ma_Lv").ToString.Trim
        Dim _ma_vd As String = Dv_DetailTmp.Item(iRow).Item("Ma_VD").ToString.Trim
        Dim _Ma_BPhh As String = Dv_DetailTmp.Item(iRow).Item("Ma_BPHH").ToString.Trim
        '
        CyberSupport.V_Lookup("Ma_CTVD", "CRMDMCTVDKN", "Ma_Lv = '" + _Ma_Lv + "' AND Ma_VD = '" + _ma_vd + "' AND Ma_BPHH = '" + _Ma_BPhh + "' ", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)

    End Sub
    Private Sub L_Ma_CTVD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_ctvd") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_ctvd") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_ctvd") = DrReturn.Item("Ma_ctvd").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ten_ctvd") = DrReturn.Item("Ten_ctvd").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()

        If Dv_DetailTmp.Item(iRow).Item("Ma_ctvd") = "" Then
            Dv_DetailTmp.Item(iRow).Item("Ma_ctvd") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_ctvd") = ""
        End If

        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_Ma_VD(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ma_Lv As String = Dv_DetailTmp.Item(iRow).Item("Ma_Lv").ToString.Trim
        '
        CyberSupport.V_Lookup("Ma_VD", "CRMDMVDKN", "Ma_Lv='" + _Ma_Lv + "'", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_VD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_VD") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_VD") = DrReturn.Item("Ma_VD").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ten_VD") = DrReturn.Item("Ten_VD").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()

        If Dv_DetailTmp.Item(iRow).Item("Ma_VD") = "" Then
            Dv_DetailTmp.Item(iRow).Item("Ten_VD") = ""
        End If

        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub


    Private Sub V_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVNNKN)
    End Sub
    Private Sub V_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVNNKN)
    End Sub
#End Region
#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Tính số ngày giải quyết"
    Private Sub V_Tinh_So_Ngay(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_dong As Date = TxtNgay_Dong.Value
        Dim _thoi_gian As Double = TxtThoi_Gian.Double
        Dim _muc_do As String = CmbMuc_Do.SelectedValue
        Dim _so_ngay As Double
        If _Ngay_dong >= _Ngay_LCt Then
            _so_ngay = DateDiff(DateInterval.Day, _Ngay_LCt, _Ngay_dong) - _thoi_gian

            TxtSo_Ngay.Double = _so_ngay
            ' dưới 5 ngày là đạt 
            If _muc_do = "01" Then
                If _so_ngay <= 5 Then
                    ChkIs_dat.Checked = True
                    ChkIs_Kd.Checked = False
                    TxtLy_Do2.Enabled = False
                Else
                    ChkIs_dat.Checked = False
                    ChkIs_Kd.Checked = True
                    TxtLy_Do2.Enabled = True
                End If
            Else
                If _so_ngay <= 15 Then
                    ChkIs_dat.Checked = True
                    ChkIs_Kd.Checked = False
                    TxtLy_Do2.Enabled = False
                Else
                    ChkIs_dat.Checked = False
                    ChkIs_Kd.Checked = True
                    TxtLy_Do2.Enabled = True
                End If
            End If
        End If
    End Sub
#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        Me.DetailKNYC.ContextMenu = mnItemsMail
        '---
        Dim mnItemsMail_TTCT = New ContextMenu
        'Dim mnItemsF4_TTCT As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem_TTCT, Keys.F4)
        Dim mnItemsF8_TTCT As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem_TTCT, Keys.F8)
        'mnItemsMail_TTCT.MenuItems.Add(mnItemsF4_TTCT)
        mnItemsMail_TTCT.MenuItems.Add(mnItemsF8_TTCT)
        Me.DetailTTCT.ContextMenu = mnItemsMail_TTCT
        '---
        Dim mnItemsMail_NNKN = New ContextMenu
        'Dim mnItemsF4_NNKN As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem_NNKN, Keys.F4)
        Dim mnItemsF8_NNKN As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem_NNKN, Keys.F8)
        'mnItemsMail_NNKN.MenuItems.Add(mnItemsF4_NNKN)
        mnItemsMail_NNKN.MenuItems.Add(mnItemsF8_NNKN)
        Me.DetailNNKN.ContextMenu = mnItemsMail_NNKN


        '---
        Dim mnItemsMail0 = New ContextMenu
        Dim mnItemsSave As New MenuItem("Lưu chứng tư", AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem("In chứng từ", AddressOf V_ShortPrint, Keys.Control + Keys.P)
        mnItemsMail0.MenuItems.Add(mnItemsSave)
        mnItemsMail0.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail0
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn phiếu nhập", "Add item"), AddressOf V_ShortF5, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            ' PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub MasterGRVTTCT_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn phiếu nhập", "Add item"), AddressOf V_ShortF5, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem_TTCT, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem_TTCT, Nothing, True, False))
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub MasterGRVNNKN_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn phiếu nhập", "Add item"), AddressOf V_ShortF5, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem_NNKN, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem_NNKN, Nothing, True, False))
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub MasterGRVTTGQ_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn phiếu nhập", "Add item"), AddressOf V_ShortF5, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem_TTGQ, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem_TTGQ, Nothing, True, False))
            'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub V_ShortF5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim _Ma_Vt As String = ""
        Dim _Ma_kho As String = ""
        Dim _Ma_Lo As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        If Dt_DetailTmp.Columns.Contains("Ma_Vt") Then _Ma_Vt = Dv_DetailTmp.Item(iRow).Item("Ma_VT")
        If Dt_DetailTmp.Columns.Contains("Ma_Kho_I") Then _Ma_kho = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I")
        If Dt_DetailTmp.Columns.Contains("Ma_Lo") Then _Ma_Lo = Dv_DetailTmp.Item(iRow).Item("Ma_Lo")
        Dim Drv_Return As DataRowView = CyberVoucher.V_Loc_PN_DD(AppConn, osysvar, M_LAN, M_Para, M_Mode, _Ma_Vt, _Ma_Lo, _Ma_kho, _Ngay_Ct, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, _
                                    CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberVoucher, CyberLoading)
        If Drv_Return Is Nothing Then Exit Sub
        If Drv_Return.DataView.Table.Columns.Contains("Gia_NT_PN") And Dv_DetailTmp.Table.Columns.Contains("Gia_NT") Then
            Dv_DetailTmp.BeginInit()
            Dv_DetailTmp.Item(iRow).Item("Gia_NT") = Drv_Return.Item("Gia_NT_PN")
            Dv_DetailTmp.EndInit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()
        V_Tinh_Toan(iRow)
        UpdateList()
    End Sub
#Region "Add, Delete Grid ..."
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRV) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    '---
    Private Sub V_ShortAddItem_TTCT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTCT.FocusedRowHandle
        V_AddItemTTCT(iRow)
    End Sub
    Private Sub V_ShortDeleteItem_TTCT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTCT.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTTCTTmp, AppConn, DetailGRVTTCT) Then Exit Sub
        Dv_DetailTTCTTmp.Delete(iRow)
        Dv_DetailTTCTTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    '---
    Private Sub V_ShortAddItem_NNKN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVNNKN.FocusedRowHandle
        V_AddItemNNKN(iRow)
    End Sub
    Private Sub V_ShortDeleteItem_NNKN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVNNKN.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailNNKNtmp, AppConn, DetailGRVNNKN) Then Exit Sub
        Dv_DetailNNKNtmp.Delete(iRow)
        Dv_DetailNNKNtmp.Table.AcceptChanges()
        UpdateList()
    End Sub

    '---
    Private Sub V_ShortAddItem_TTGQ(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTGQ.FocusedRowHandle
        V_AddItemTTGQ(iRow)
    End Sub
    Private Sub V_ShortDeleteItem_TTGQ(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTGQ.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTTGQtmp, AppConn, DetailGRVTTGQ) Then Exit Sub
        Dv_DetailTTGQtmp.Delete(iRow)
        Dv_DetailTTGQtmp.Table.AcceptChanges()
        UpdateList()
    End Sub



#End Region
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "X") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Me.CmdPrint.Enabled Then V_Print(sender, e)
    End Sub
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode.Trim = "X" Then If e.KeyValue = 27 Then V_Exit(sender, e)
        If M_Mode.Trim = "X" Then
            Select Case e.KeyValue
                Case 33 'Pageup
                    V_Prev(sender, e)
                Case 34 'PageDown
                    V_NEXT(sender, e)
                Case 35 'End
                    V_Bottom(sender, e)
                Case 36 'Home
                    V_Top(sender, e)
            End Select
        End If
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String) As Boolean
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Dt, _Mode, _Ma_Post, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, osysvar, CyberSmlib)
    End Function
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        DetailGRVNNKN.PostEditor()
        DetailGRVTTCT.PostEditor()
        DetailGRVTTGQ.PostEditor()

        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailNNKNtmp.Table.AcceptChanges()
        Dv_DetailTTCTTmp.Table.AcceptChanges()
        Dv_DetailTTGQtmp.Table.AcceptChanges()

        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailTTGQtmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu

        '----------------------------------------------------------------------------------------------------------------------
        Dim DrMasterOld As DataRow
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            DrMasterOld = CyberSmodb.V_CopyDataRow(drMaster)

            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailNNKNtmp, Dt_DetailTTCTtmp, Dt_DetailTTGQtmp}, {M_Ct, M_Ph, "CTVOCNNKN", "CTVOCTTCT", "CTVOCTTGQ"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CmbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
            If M_Mode = "S" And Not DrMasterOld Is Nothing Then CyberSmodb.V_UpdateRowtoRow(DrMasterOld, Dt_Master, CrrRow)
            Return
        End If
        '---------------------------------------------------
        '---Update Head
        If DsSave.Tables.Count >= 2 Then
            If DsSave.Tables(1).Rows.Count > 0 Then
                CyberSmodb.SetValueTObj_1(Me, DsSave.Tables(1).Rows(0)) '----Chi set Những trường có dữ liệu
                CyberSmodb.AddValueToRow(drMaster, Me)
                drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
                drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
                drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            End If
        End If
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '---------------------------------------------------
        '---Update Chi tiet
        If DsSave.Tables.Count >= 3 Then
            For iRow As Integer = 0 To DsSave.Tables(2).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(2).Rows(iRow), Dt_DetailTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_Detail.Load(Dt_DetailTmp.CreateDataReader)

        '---Update Chi tiet
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailNNKNtmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailNNKN.Load(Dt_DetailNNKNtmp.CreateDataReader)


        '---Update Chi tiet
        If DsSave.Tables.Count >= 5 Then
            For iRow As Integer = 0 To DsSave.Tables(4).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(4).Rows(iRow), Dt_DetailTTCTtmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailTTCT.Load(Dt_DetailTTCTtmp.CreateDataReader)

        '---Update Chi tiet
        If DsSave.Tables.Count >= 6 Then
            For iRow As Integer = 0 To DsSave.Tables(5).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(5).Rows(iRow), Dt_DetailTTGQtmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailTTGQ.Load(Dt_DetailTTGQtmp.CreateDataReader)

        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Sub V_Save_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        DetailGRVTTCT.PostEditor()
        Dv_DetailTTCTTmp.Table.AcceptChanges()
        DetailGRVNNKN.PostEditor()
        Dv_DetailNNKNtmp.Table.AcceptChanges()
        DetailGRVTTGQ.PostEditor()
        Dv_DetailTTGQtmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CmbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,TEN_KH", "TEN_VT,TEN_KHO_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        Dim _strField As String = ""
        Dim _strvalue As String = ""
        Dim CP_ChkInPut_Vt As String = "CP_SysChkVoucherInput" & M_Ma_CT.Trim
        Dim CP_ChkInPut_NNKN As String = "CP_SysChkVoucherInput" & M_Ma_CT.Trim & "_NNKN"
        CyberSmodb.GetValueControler(Me, _strField, _strvalue)

        If Dt_DetailTmp.Rows.Count > 0 Then If Not CyberSupport.ChkVoucherInput1(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CmbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, CP_ChkInPut_Vt, _strField, _strvalue, "MA_KH,MA_XE,TEN_VTTHUE,TK_THUE_NO,TK_THUE_CO,SUA_TKTHUE", "STT,TEN_VT,DVT,SO_LUONG,GIA_NT2,TIEN_NT2", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        If Dt_DetailNNKNtmp.Rows.Count > 0 Then If Not CyberSupport.ChkVoucherInput1(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CmbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailNNKNtmp, CP_ChkInPut_NNKN, _strField, _strvalue, "MA_KH,MA_XE,TEN_VTTHUE,TK_THUE_NO,TK_THUE_CO,SUA_TKTHUE", "SO_RO,DIEN_GIAI_I,TONG_TIEN,TIEN_DAXUAT,TIEN", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub

        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------

        Add2Database() '--Save To SQL:

        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Function ChkVsave() As Boolean
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count

        UpdateList()
        '---------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            If Dt_DetailTmp.Columns.Contains("Ma_Hs_I") Then If TxtMa_BPTN.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Hs_I") = TxtMa_BPTN.Text.Trim
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()

        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_VT.Text)
        UpdateList()
        ChkVsave = True
    End Function
    Private Sub Add2Database()
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        '---Save Combobox
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else

            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        'drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailTTCT, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTTCTtmp.Rows.Count - 1
            Dt_DetailTTCT.ImportRow(Dt_DetailTTCTtmp.Rows(i))
        Next
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailNNKN, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailNNKNtmp.Rows.Count - 1
            Dt_DetailNNKN.ImportRow(Dt_DetailNNKNtmp.Rows(i))
        Next


        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------

        '---Save: TO SQL
        If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))

        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTTCTtmp, "CTVOCTTCT", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailNNKNtmp, "CTVOCNNKN", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTTGQtmp, "CTVOCTTGQ", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub

        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        Dim Frm As Cyber.From.FrmCopy
        Frm = New FrmCopy
        Frm.Para = M_Para
        Frm.Lan = M_LAN
        Frm.Sysvar = osysvar
        Frm.DrDmct = Me.DrDmct
        Frm.So_CT = ""
        Frm.Ngay_CT = Now.Date
        Frm.Ngay_LCT = Now.Date
        Frm.SysApp = AppConn
        Frm.Ma_Dvcs = TxtMa_Dvcs.Text
        Frm.Stt_Rec = M_Stt_Rec
        Frm.ShowDialog()

        If Not Frm.Ok_Copy Then
            M_Stt_Rec = M_Stt_RecOld
            Exit Sub
        End If
        Dim _Ngay_Ct_Copy As Date = Frm.TxtNgay_Ct.Value
        Dim _Ngay_LCt_Copy As Date = Frm.TxtNgay_LCt.Value
        Dim _So_Ct_Copy As String = Frm.txtSo_ct.Text
        Dim _Ma_Quyen_Copy As String = Frm.TxtMa_Quyen.Text

        Dim I As Integer
        For I = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(I).BeginEdit()
            Dt_DetailTmp.Rows(I).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(I).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(I).Item("So_Ct") = _So_Ct_Copy
            Dt_DetailTmp.Rows(I).EndEdit()
        Next

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtSo_Ct.Text = _So_Ct_Copy.Trim
        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        M_Mode = "M"
        V_Databing()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        '--------------
        If TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = M_Dien_Giai
        TxtNgay_Dong.Text = "01/01/1900"
        TxtNgay_Mua.Text = "01/01/1900"
        TxtNgay_Gui.Text = "01/01/1900"
        TxtNgay_Hen1.Text = "01/01/1900"
        TxtNgay_Hen2.Text = "01/01/1900"
        TxtNgay_Hen3.Text = "01/01/1900"
        TxtNgay_Hen4.Text = "01/01/1900"
        TxtNgay_CSGoi.Text = "01/01/1900"
        CbbMa_Post.SelectedValue = "3"
        V_New()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        V_GetNgamDinh()
        V_loadMa_Hs()

        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If
        If Dt_DetailTTCTtmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTTCTtmp.NewRow()
            DrCurren = Dt_DetailTTCTtmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTTCTtmp.Rows.Add(DrCurren)
            Dt_DetailTTCTtmp.AcceptChanges()
        End If
        If Dt_DetailNNKNtmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailNNKNtmp.NewRow()
            DrCurren = Dt_DetailNNKNtmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailNNKNtmp.Rows.Add(DrCurren)
            Dt_DetailNNKNtmp.AcceptChanges()
        End If
    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        M_Mode = "S"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("S")
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("D") Then Exit Sub
        Dim iMasterRow As Integer = -1
        For iRow As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                iMasterRow = iRow
                Exit For
            End If
        Next
        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub
        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailTTCT, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailNNKN, M_Stt_Rec)
        'CyberSupport.V_DeleteTableVoucher(Dt_DetailTTGQ, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("D")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_Rec = M_Stt_RecOld
        V_Databing()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub
        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberSupport.V_ExitVoucher(osysvar, M_LAN) Then Exit Sub
        Me.Close()
    End Sub
    Private Sub V_GetNgamDinh()
        Try
            CmbHai_Long.SelectedValue = M_Ma_Hl_Ngam_Dinh
        Catch ex As Exception
        End Try
        Try
            CmbMuc_Do.SelectedValue = M_Ma_MD_Ngam_Dinh
        Catch ex As Exception
        End Try
        Try
            CmbTrach_Nhiem.SelectedValue = M_Ma_TN_Ngam_Dinh
        Catch ex As Exception
        End Try
        Try
            CmbTiep_Nhan.SelectedValue = M_Ma_Tiep_nhan_Ngam_Dinh
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_So_Khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_VOCGetROHD()
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_VOCGetROHD()
    End Sub
    Private Sub V_VOCGetROHD()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _ma_GD As String = CmbMa_GD.SelectedValue.ToString.Trim
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOC_GetROHD", M_Mode + "#" + M_Stt_Rec + "#" + _ma_GD + "#" + TxtLenh_RO.Text + "#" + TxtMa_HD_H.Text + "#" + TxtMa_Xe.Text + "#" + TxtSo_Khung.Text + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If _DsTmp.Tables.Count = 0 Then
            _DsTmp.Dispose()
            Exit Sub
        End If

        If _DsTmp.Tables(0).Rows.Count = 0 Then
            _DsTmp.Dispose()
            Exit Sub
        End If

        If _DsTmp.Tables(0).Columns.Contains("Lenh_RO") Then TxtLenh_RO.Text = _DsTmp.Tables(0).Rows(0).Item("Lenh_RO").ToString.Trim
        If _DsTmp.Tables(0).Columns.Contains("Ma_HD_H") Then TxtMa_HD_H.Text = _DsTmp.Tables(0).Rows(0).Item("Ma_HD_H").ToString.Trim
        ''If _DsTmp.Tables(0).Columns.Contains("Ten_HD_H") Then TxtTen_HD_H.Text = _DsTmp.Tables(0).Rows(0).Item("Ten_HD_H").ToString.Trim

        If _DsTmp.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = _DsTmp.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim
        If _DsTmp.Tables(0).Columns.Contains("So_Khung") Then TxtSo_Khung.Text = _DsTmp.Tables(0).Rows(0).Item("So_Khung").ToString.Trim

        If Not TxtMa_HD_H.Text.Trim = "" Then L_VOCGetThongTin()
        If Not TxtLenh_RO.Text.Trim = "" Then L_VOCGetThongTin()
    End Sub
#End Region
#Region "Add Or Detete Item"
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
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
    End Sub
    '---
    Private Sub MasterGRVTTCT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRVTTCT.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRVTTCT.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRVTTCT.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRVTTCT.VisibleColumns.IndexOf(DetailGRVTTCT.FocusedColumn)
        Dim iRowOld As Integer = DetailGRVTTCT.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemTTCT(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemTTCT(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTTCTTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTTCTTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTTCTTmp.Table.Rows(Dv_DetailTTCTTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTTCTTmp.Table.Rows(Dv_DetailTTCTTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(2)))
        CarrOn(Dv_DetailTTCTTmp.Table.Rows(Dv_DetailTTCTTmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTTCTTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVTTCT, iRow, 0)
    End Sub
    '---
    Private Sub MasterGRVNNKN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRVNNKN.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRVNNKN.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRVNNKN.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRVNNKN.VisibleColumns.IndexOf(DetailGRVNNKN.FocusedColumn)
        Dim iRowOld As Integer = DetailGRVNNKN.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemNNKN(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemNNKN(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailNNKNtmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailNNKNtmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailNNKNtmp.Table.Rows(Dv_DetailNNKNtmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailNNKNtmp.Table.Rows(Dv_DetailNNKNtmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(3)))
        CarrOn(Dv_DetailNNKNtmp.Table.Rows(Dv_DetailNNKNtmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailNNKNtmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVNNKN, iRow, 0)
    End Sub
    '---
    Private Sub MasterGRVTTGQ_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRVTTGQ.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRVTTGQ.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRVTTGQ.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRVTTGQ.VisibleColumns.IndexOf(DetailGRVTTGQ.FocusedColumn)
        Dim iRowOld As Integer = DetailGRVTTGQ.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemTTGQ(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemTTGQ(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTTGQtmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTTGQtmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTTGQtmp.Table.Rows(Dv_DetailTTGQtmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTTGQtmp.Table.Rows(Dv_DetailTTGQtmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(4)))
        CarrOn(Dv_DetailTTGQtmp.Table.Rows(Dv_DetailTTGQtmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTTGQtmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVTTGQ, iRow, 0)
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRV, Dt_DetailTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Sub SetTxt()
    End Sub
#End Region
#Region "TTCP Default and New/Save _TTCP"
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DtTTCP As DataTable
    Dim M_Ma_TTCP_H As String = ""
    Dim M_Ten_TTCP_H As String = ""
    Dim M_Ten_TTCP2_H As String = ""

    Dim M_Ma_TTLN_H As String = ""
    Dim M_Ten_TTLN_H As String = ""
    Dim M_Ten_TTLN2_H As String = ""

    Dim M_Ma_Hs_H As String = ""
    Dim M_Ten_HS_H As String = ""
    Dim M_Ten_HS2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CbbMa_TTCP_H.Visible = M_Is_Visible_TTCP
        If M_Is_Visible_TTCP And DrDmct.Table.Columns.Contains("CaptionTTCP") Then If DrDmct.Item("CaptionTTCP").ToString.Trim <> "" Then LabMa_TTCP_H.Text = DrDmct.Item("CaptionTTCP").ToString.Trim

        If M_Is_Visible_TTCP Then
            Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

            If DsTmp.Tables.Count = 0 Then
                M_Is_Visible_TTCP = False
                DsTmp.Dispose()
                Return
            End If

            If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP_H") Then M_Ten_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP2_H") Then M_Ten_TTCP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_Hs_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_Hs_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub



#End Region
End Class


