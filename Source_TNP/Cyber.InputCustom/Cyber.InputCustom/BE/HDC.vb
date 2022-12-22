Imports System.Data.SqlClient
Public Class HDC
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim M_HT_TT, M_Ma_Thue As String
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"
    Dim EditMa_Lo, EditTk_VT, EditTk_DT, EditTk_GV, EditTk_CK As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Kx, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_Phi_i, EditMa_HD_I, EditMa_SP_I, EditMa_Ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_Hs_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim Editma_Db_I, EditMa_Xe_I, EditMa_Kx_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditGia_Nt2, EditGia2, EditGia_Nt, EditTien_Nt2, EditTien2, EditPT_CK, EditCK_NT, EditCK, EditGia, EditTien_Nt, EdtTien, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_Kx, EditDvt, EditTen_Kho_I, EditTen_Tk_VT, EditTen_Tk_DT, EditTen_Tk_CK, EditTen_Tk_GV, EditTien As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Mau, EditTen_Mau, EditSo_Khung, EditSo_May As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub HDC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        GetRound()
        CmdNew.Select()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)

        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Master = New DataView(Dt_Master)

        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)

        TxtT_So_Luong.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_So_Luong.InputMask)

        TxtT_Tien_NT2.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Tien_NT2.InputMask)
        TxtT_Tien2.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_Tien2.InputMask)

        TxtT_thue_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_thue_NT.InputMask)
        TxtT_Thue.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_Thue.InputMask)

        TxtT_CK_Nt.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_CK_Nt.InputMask)
        TxtT_CK.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_CK.InputMask)

        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_Tien.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_Tien.InputMask)

        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_TT_NT.InputMask)
        TxtT_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_TT.InputMask)

        TxtT_KM.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_KM.InputMask)
        TxtT_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_BB.InputMask)
        TxtT_Moi_Gioi.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Moi_Gioi.InputMask)
        TxtT_Km_Khac.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Km_Khac.InputMask)
        TxtT_CP.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_CP.InputMask)
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
        M_HT_TT = M_Para(M_VT_PARA + 4).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Tk_No = DrDmct.Item("M_Tk_No").ToString.Trim
        M_Tk_Co = DrDmct.Item("M_Tk_Co").ToString.Trim
        M_Tk_Thue = DrDmct.Item("M_Tk_Thue").ToString.Trim
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        If M_Tk_No.Trim <> "" Then M_Ten_Tk_No = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "DmTk", "Tk = N'" + M_Tk_No.Trim + "'", CyberSmlib) Else M_Ten_Tk_No = ""
        If M_Tk_Co.Trim <> "" Then M_Ten_Tk_Co = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "DmTk", "Tk = N'" + M_Tk_Co.Trim + "'", CyberSmlib) Else M_Ten_Tk_Co = ""
        If M_Tk_Thue.Trim <> "" Then M_Ten_Tk_Thue = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "DmTk", "Tk = N'" + M_Tk_Thue.Trim + "'", CyberSmlib) Else M_Ten_Tk_Thue = ""

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CmbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

        V_LoadDefault()
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
    End Sub
    Private Sub V_GetColumn()
        EditMa_Lo.GetColumn(DetailGRV, "Ma_Lo")
        EditMa_Kx.GetColumn(DetailGRV, "Ma_Kx")
        EditTen_Kx.GetColumn(DetailGRV, "Ten_Kx")

        EditDvt.GetColumn(DetailGRV, "Dvt")
        EditSo_Khung.GetColumn(DetailGRV, "So_Khung")
        EditSo_May.GetColumn(DetailGRV, "So_May")

        EditMa_Mau.GetColumn(DetailGRV, "Ma_Mau")
        EditTen_Mau.GetColumn(DetailGRV, "Ten_Mau")

        EditMa_Vitri.GetColumn(DetailGRV, "Ma_Vitri")

        EditMa_Kho_I.GetColumn(DetailGRV, "Ma_Kho_I")
        EditTen_Kho_I.GetColumn(DetailGRV, "Ten_Kho_I")

        EditTk_VT.GetColumn(DetailGRV, "Tk_Vt")
        EditTen_Tk_VT.GetColumn(DetailGRV, "Ten_Tk_Vt")

        EditTk_DT.GetColumn(DetailGRV, "Tk_DT")
        EditTen_Tk_DT.GetColumn(DetailGRV, "Ten_Tk_DT")

        EditTk_CK.GetColumn(DetailGRV, "Tk_CK")
        EditTen_Tk_CK.GetColumn(DetailGRV, "Ten_Tk_CK")

        EditTk_GV.GetColumn(DetailGRV, "Tk_GV")
        EditTen_Tk_GV.GetColumn(DetailGRV, "Ten_Tk_GV")

        EditDien_Giaii.GetColumn(DetailGRV, "Dien_Giaii")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")

        EditGia_Nt2.GetColumn(DetailGRV, "Gia_Nt2")
        EditGia2.GetColumn(DetailGRV, "Gia2")

        EditTien_Nt2.GetColumn(DetailGRV, "Tien_Nt2")
        EditTien2.GetColumn(DetailGRV, "Tien2")

        EditPT_CK.GetColumn(DetailGRV, "PT_CK")

        EditCK_NT.GetColumn(DetailGRV, "CK_NT")
        EditCK.GetColumn(DetailGRV, "CK")

        EditGia_Nt.GetColumn(DetailGRV, "Gia_Nt")
        EditGia.GetColumn(DetailGRV, "Gia")

        EditTien_Nt.GetColumn(DetailGRV, "Tien_Nt")
        EditTien.GetColumn(DetailGRV, "Tien")

        EditMa_Vv_I.GetColumn(DetailGRV, "Ma_Vv_I")
        EditMa_Phi_i.GetColumn(DetailGRV, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRV, "Ma_HD_I")
        EditMa_SP_I.GetColumn(DetailGRV, "Ma_SP_I")
        EditMa_Ku_I.GetColumn(DetailGRV, "Ma_Ku_I")
        EditMa_TTLN_i.GetColumn(DetailGRV, "Ma_TTLN_I")
        EditMa_TTCP_i.GetColumn(DetailGRV, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRV, "Ma_BP_I")
        EditMa_Hs_I.GetColumn(DetailGRV, "Ma_Hs_I")
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
        EditMa_Xe_I.GetColumn(DetailGRV, "Ma_Xe_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_Tuyen_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtOng_Ba.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_Nt")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_Gia_Nt")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.ToUpper.Trim = osysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            M_R_GIA_NT = M_R_GIA
            M_R_TIEN_NT = M_R_TIEN
        End If
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
        AddHandler CmbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia

        'Ma_TD3
        AddHandler TxtMa_TD3_H.CyberValiting, AddressOf V_Ma_TD3_H
        AddHandler TxtMa_TD3_H.CyberLeave, AddressOf L_Ma_TD3_H
        'Ma_HD
        AddHandler TxtMa_HD_H.CyberValiting, AddressOf V_Ma_HD_H
        AddHandler TxtMa_HD_H.CyberLeave, AddressOf L_Ma_HD_H
        'Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtTen_KhVAT.Leave, AddressOf L_Ten_KhVAT
        AddHandler TxtDia_ChiVAT.Leave, AddressOf L_Ten_KhVAT
        AddHandler TxtDia_Chi.Leave, AddressOf L_Dia_Chi
        'Ma_NH
        AddHandler TxtMa_NH.CyberValiting, AddressOf V_Ma_NH
        AddHandler TxtMa_NH.CyberLeave, AddressOf L_Ma_NH
        'Ma_Nx
        AddHandler TxtMa_Nx.CyberValiting, AddressOf V_Ma_Nx
        AddHandler TxtMa_Nx.CyberLeave, AddressOf L_Ma_Nx
        'Ma_BP_H
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H
        'Ma_Hs_H
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_Hs_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_Hs_H
        'Ma_Thue
        AddHandler TxtMa_Thue.Leave, AddressOf L_Ma_THue
        'TK_Thue_Co
        AddHandler TxtTk_Thue_Co.CyberValiting, AddressOf V_Tk_Thue_Co
        AddHandler TxtTk_Thue_Co.CyberLeave, AddressOf L_Tk_Thue_Co
        'TK_Thue_No
        AddHandler TxtTk_Thue_No.CyberValiting, AddressOf V_Tk_Thue_no
        AddHandler TxtTk_Thue_No.CyberLeave, AddressOf L_Tk_Thue_No
        '---------
        AddHandler ChkPx_Gia_DD.CheckedChanged, AddressOf V_Px_Gia_DD
        AddHandler ChkSua_TkThue.CheckedChanged, AddressOf V_Sua_TkThue
        AddHandler ChkSua_Thue.CheckedChanged, AddressOf V_Sua_Thue
        AddHandler ChkSua_Thue_CK.CheckedChanged, AddressOf V_Sua_Thue_CK
        AddHandler ChkSua_CK.CheckedChanged, AddressOf V_Sua_Ck
        '------------
        AddHandler TxtT_CK_Nt.Leave, AddressOf L_T_CK_NT
        AddHandler TxtT_CK_Nt.Enter, AddressOf E_T_CK_NT
        AddHandler TxtT_thue_NT.Leave, AddressOf L_T_Thue_NT
        AddHandler TxtT_thue_NT.Enter, AddressOf E_T_Thue_NT
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_Nt2.Column Is Nothing Then AddHandler EditGia_Nt2.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt2.Column Is Nothing Then AddHandler EditTien_Nt2.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien2.Column Is Nothing Then AddHandler EditTien2.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditPT_CK.Column Is Nothing Then AddHandler EditPT_CK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCK_NT.Column Is Nothing Then AddHandler EditCK_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCK.Column Is Nothing Then AddHandler EditCK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_Nt.Column Is Nothing Then AddHandler EditGia_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt.Column Is Nothing Then AddHandler EditTien_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii

        '-------------------------------------
        EditTk_VT.V_ActiLookUpColumn(AddressOf V_Tk_VT, AddressOf L_Tk_VT)
        EditTk_DT.V_ActiLookUpColumn(AddressOf V_Tk_DT, AddressOf L_Tk_DT)
        EditTk_CK.V_ActiLookUpColumn(AddressOf V_Tk_CK, AddressOf L_Tk_CK)
        EditTk_GV.V_ActiLookUpColumn(AddressOf V_Tk_GV, AddressOf L_Tk_GV)
        '-------------------------------------
        'Vat tu-kho
        EditMa_Lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)
        EditMa_Kx.V_ActiLookUpColumn(AddressOf V_Ma_Kx, AddressOf L_Ma_Kx)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)

        If Not EditTen_Kx.Column Is Nothing Then EditTen_Kx.EditColumn.ReadOnly = True
        If Not EditTen_Mau.Column Is Nothing Then EditTen_Mau.EditColumn.ReadOnly = True
        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_I, AddressOf L_Ma_Kho_I)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        '-------------------------------------
        If Not EditSo_Khung.Column Is Nothing Then AddHandler EditSo_Khung.EditColumn.Leave, AddressOf L_So_Khung
        If Not EditSo_May.Column Is Nothing Then AddHandler EditSo_May.EditColumn.Leave, AddressOf L_So_May
        '-------------------------------------
        'Add On
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_Phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)

        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)

        EditMa_SP_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_Ku_I.V_ActiLookUpColumn(AddressOf V_Ma_Ku_i, AddressOf L_Ma_Ku_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_BP_i, AddressOf L_Ma_BP_i)
        EditMa_Hs_I.V_ActiLookUpColumn(AddressOf V_Ma_Hs_i, AddressOf L_Ma_Hs_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)
        Editma_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_i, AddressOf L_Ma_Db_i)
        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_i, AddressOf L_Ma_Xe_i)

        EditMa_Kx_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
        EditMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_Ma_Tuyen_i, AddressOf L_Ma_Tuyen_i)
        EditMa_Ts.V_ActiLookUpColumn(AddressOf V_Ma_Ts, AddressOf L_Ma_Ts)
        EditMa_Cc.V_ActiLookUpColumn(AddressOf V_Ma_Cc, AddressOf L_Ma_Cc)

        If Not EditSo_So.Column Is Nothing Then AddHandler EditSo_So.EditColumn.Leave, AddressOf L_So_So
        If Not EditSo_Po.Column Is Nothing Then AddHandler EditSo_Po.EditColumn.Leave, AddressOf L_So_Po
        If Not EditSo_Ro.Column Is Nothing Then AddHandler EditSo_Ro.EditColumn.Leave, AddressOf L_So_Ro
        If Not EditSo_VT.Column Is Nothing Then AddHandler EditSo_VT.EditColumn.Leave, AddressOf L_So_VT
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_NT()
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            If Not EditTien2 Is Nothing Then EditTien2.Visible = False
            If Not EditGia2 Is Nothing Then EditGia2.Visible = False
            If Not EditCK Is Nothing Then EditCK.Visible = False
            If Not EditTien Is Nothing Then EditTien.Visible = False
            If Not EditGia Is Nothing Then EditGia.Visible = False

            TxtT_Tien.Visible = False
            TxtT_Tien2.Visible = False
            TxtT_Thue.Visible = False
            TxtT_CK.Visible = False
            TxtT_TT.Visible = False
        Else
            If Not EditTien2 Is Nothing Then EditTien2.Visible = True
            If Not EditGia2 Is Nothing Then EditGia2.Visible = True
            If Not EditCK Is Nothing Then EditCK.Visible = True
            If Not EditTien Is Nothing Then EditTien.Visible = True
            If Not EditGia Is Nothing Then EditGia.Visible = True
            TxtT_Tien.Visible = True
            TxtT_Tien2.Visible = True
            TxtT_Thue.Visible = True
            TxtT_CK.Visible = True
            TxtT_TT.Visible = True
        End If
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
            TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CmbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()

        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
        Dim _Chk As Boolean = ChkPx_Gia_DD.Checked
        If Not EditGia Is Nothing Then EditGia.ColumnReadOnly = Not _Chk
        If Not EditGia_Nt Is Nothing Then EditGia_Nt.ColumnReadOnly = Not _Chk
        If Not EditTien Is Nothing Then EditTien.ColumnReadOnly = Not _Chk
        If Not EditTien_Nt Is Nothing Then EditTien_Nt.ColumnReadOnly = Not _Chk

        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, TxtMa_Nx.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CmbMa_GD.Enabled = False
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
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#Region "Valid --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi"), TxtDia_Chi.Text)
            If TxtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ong_Ba") Then TxtOng_Ba.Text = DrReturn.Item("Ong_Ba")
            If TxtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Doi_Tac") Then TxtOng_Ba.Text = DrReturn.Item("Doi_Tac")
            If TxtHan_TT.Double = 0 Then If DrReturn.Table.Columns.Contains("Han_TT") Then TxtHan_TT.Double = DrReturn.Item("Han_TT")

            If TxtMa_So_Thue.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ma_So_Thue") Then TxtMa_So_Thue.Text = DrReturn.Item("Ma_So_Thue")
            If TxtTen_KhVAT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ten_KhVAT") Then TxtTen_KhVAT.Text = DrReturn.Item("Ten_KhVAT")
            If TxtDia_ChiVAT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Dia_ChiVAT") Then TxtDia_ChiVAT.Text = DrReturn.Item("Dia_ChiVAT")
            If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = TxtTen_Kh.Text
            If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
            If TxtEmailHDDT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("E_Mail") Then TxtEmailHDDT.Text = DrReturn.Item("E_Mail").ToString.Trim

            '-----------------------------------------------------------------------------------------------------------
            If TxtMa_BP_H.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("Ma_BP") Then TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
                If TxtMa_BP_H.Text.Trim <> "" Then TxtTen_BP_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP = N'" + TxtMa_BP_H.Text.Trim + "')", CyberSmlib)

            End If
            '-----------------------------------------------------------------------------------------------------------
            If TxtMa_Hs_H.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("Ma_Hs") Then TxtMa_Hs_H.Text = DrReturn.Item("Ma_Hs")
                If TxtMa_Hs_H.Text.Trim <> "" Then TxtTen_Hs_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "DmHS", "(Ma_Hs = N'" + TxtMa_Hs_H.Text.Trim + "')", CyberSmlib)
            End If
            '-----------------------------------------------------------------------------------------------------------
            If TxtMa_Nx.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("TK") Then TxtMa_Nx.Text = DrReturn.Item("TK")
                If TxtMa_Nx.Text.Trim <> "" Then TxtTen_Nx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk", "DmTk", "(TK = N'" + TxtMa_Nx.Text.Trim + "')", CyberSmlib)
                If TxtTen_Nx.Text.Trim = "" Then TxtMa_Nx.Text = ""
            End If
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If

        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            TxtDia_Chi.Text = ""
            Exit Sub
        End If
        V_GetTk_Thue_No()
        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, TxtMa_Nx.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Ten_KhVAT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = TxtTen_Kh.Text
        If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
    End Sub
    Private Sub L_Dia_Chi(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtDia_Chi.Text = CyberInput.GetDia_Chi(TxtMa_Kh.Text, TxtDia_Chi.Text, M_Ma_CT, M_Mode, AppConn, CyberSmlib, CyberSmodb)
    End Sub
#End Region
#Region "Valid --- Ma_NH"
    Private Sub V_Ma_NH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_NH.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_NH", "DmNhTraGop", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NH.Text = "" Then
            TxtTen_NH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_NH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NH.Text = DrReturn.Item("Ma_NH")
            TxtTen_NH.Text = DrReturn.Item("Ten_NH")
        End If
        If TxtMa_NH.Text = "" Then
            TxtTen_NH.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TD3_H"
    Private Sub V_Ma_TD3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_TD3_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_TD3_H.Text = "" Then
            TxtTen_TD3_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TD3_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3_H.Text = DrReturn.Item("Ma_TD3")
            TxtTen_TD3_H.Text = DrReturn.Item("Ten_TD3")
        End If
        If Not TxtMa_TD3_H.Text.Trim = "" Then CP_GetHDCFromMa_HD()
    End Sub
    Private Sub CP_GetHDCFromMa_HD()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        Dim _strField As String = "", _StrValue As String = ""
        Dim dsTMp As DataSet
        Dim _strF As String = ""
        Dim _strV As String = ""
        CyberSmodb.GetValueControler(Me, _strF, _strV)
        dsTMp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDCFromMa_HD", _strF & "#" & _strV & "#" & TxtMa_TD3_H.Text & "#" & TxtMa_HD_H.Text & "#" & M_Mode & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & CmbMa_GD.SelectedValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim nCount As Integer = dsTMp.Tables.Count
        If nCount <= 0 Then
            dsTMp.Dispose()
            Exit Sub
        End If

        If Not CyberSupport.V_MsgChk(dsTMp.Tables(nCount - 1), osysvar, M_LAN) Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If nCount <= 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If

        Dim Dt As DataTable = dsTMp.Tables(0)
        CyberSmodb.SetNotNullTable(Dt)
        '--- Up thong tin
        If Dt.Rows.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If Dt.Columns.Contains("Ma_TD3_H") Then TxtMa_TD3_H.Text = Dt.Rows(0).Item("Ma_TD3_H")
        If Dt.Columns.Contains("Ten_TD3_H") Then TxtTen_TD3_H.Text = Dt.Rows(0).Item("Ten_TD3_H")

        If Dt.Columns.Contains("Ma_HD_H") Then TxtMa_HD_H.Text = Dt.Rows(0).Item("Ma_HD_H")
        If Dt.Columns.Contains("Ten_HD_H") Then TxtTen_HD_H.Text = Dt.Rows(0).Item("Ten_HD_H")

        If Dt.Columns.Contains("Ma_Nx") Then TxtMa_Nx.Text = Dt.Rows(0).Item("Ma_Nx")
        If Dt.Columns.Contains("Ten_Nx") Then TxtTen_Nx.Text = Dt.Rows(0).Item("Ten_Nx")

        If Dt.Columns.Contains("Ma_Kh") And TxtMa_Kh.Text.Trim = "" Then TxtMa_Kh.Text = Dt.Rows(0).Item("Ma_Kh")
        If Dt.Columns.Contains("ong_ba") And TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = Dt.Rows(0).Item("ong_ba")
        If Dt.Columns.Contains("Ten_Kh") And TxtTen_Kh.Text.Trim = "" Then TxtTen_Kh.Text = Dt.Rows(0).Item("Ten_Kh")
        If Dt.Columns.Contains("Dia_Chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = Dt.Rows(0).Item("Dia_Chi")

        If Dt.Columns.Contains("Ten_KhVAT") And TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = Dt.Rows(0).Item("Ten_KhVAT")
        If Dt.Columns.Contains("Dia_ChiVAT") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = Dt.Rows(0).Item("Dia_ChiVAT")
        If Dt.Columns.Contains("Ma_So_Thue") And TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = Dt.Rows(0).Item("Ma_So_Thue")

        If Dt.Columns.Contains("So_Cmt") And TxtSo_Cmt.Text.Trim = "" Then TxtSo_Cmt.Text = Dt.Rows(0).Item("So_Cmt")
        If Dt.Columns.Contains("Ngay_Cmt") Then TxtNgay_CMT.Value = Dt.Rows(0).Item("Ngay_Cmt")
        If Dt.Columns.Contains("Noi_cap_CMT") And TxtNoi_Cap_Cmt.Text.Trim = "" Then TxtNoi_Cap_Cmt.Text = Dt.Rows(0).Item("Noi_cap_CMT")

        If Dt.Columns.Contains("Dien_Giai") Then TxtDien_Giai.Text = Dt.Rows(0).Item("Dien_Giai")

        If Dt.Columns.Contains("Ma_Hs_H") Then TxtMa_Hs_H.Text = Dt.Rows(0).Item("Ma_Hs_H")
        If Dt.Columns.Contains("Ten_Hs_H") Then TxtTen_Hs_H.Text = Dt.Rows(0).Item("Ten_Hs_H")
        If Dt.Columns.Contains("Ma_BP_H") Then TxtMa_BP_H.Text = Dt.Rows(0).Item("Ma_BP_H")
        If Dt.Columns.Contains("Ten_BP_H") Then TxtTen_BP_H.Text = Dt.Rows(0).Item("Ten_BP_H")

        If Dt.Columns.Contains("T_KM") Then TxtT_KM.Double = Dt.Rows(0).Item("T_KM")
        If Dt.Columns.Contains("T_BB") Then TxtT_BB.Double = Dt.Rows(0).Item("T_BB")
        If Dt.Columns.Contains("T_Moi_Gioi") Then TxtT_Moi_Gioi.Double = Dt.Rows(0).Item("T_Moi_Gioi")
        If Dt.Columns.Contains("T_Km_Khac") Then TxtT_Km_Khac.Double = Dt.Rows(0).Item("T_Km_Khac")
        If Dt.Columns.Contains("T_CP") Then TxtT_CP.Double = Dt.Rows(0).Item("T_CP")

        'hieulv
        If Dt.Columns.Contains("Ma_NH") Then TxtMa_NH.Text = Dt.Rows(0).Item("Ma_NH")
        If Dt.Columns.Contains("Ten_NH") Then TxtTen_NH.Text = Dt.Rows(0).Item("Ten_NH")

        If nCount <= 2 Then
            dsTMp.Dispose()
            Exit Sub
        End If

        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        CyberSmodb.SQLTbToTb(dsTMp.Tables(1), Dt_DetailTmp)
        UpdateList()
        dsTMp.Dispose()
    End Sub
#End Region
#Region "Valid --- Ma_HD_H"
    Private Sub V_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HD_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD_H.Text = "" Then
            TxtTen_HD_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD_H.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD_H.Text = DrReturn.Item("Ten_HD")
        End If
        If Not TxtMa_HD_H.Text.Trim = "" Then CP_GetHDCFromMa_HD()

    End Sub
    Private Sub CP_GetHDCFromHDX()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD_H.Text = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value

        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDCFromHDX", M_Mode & "#" & M_Stt_Rec.Trim & "#" & M_Ma_CT & "#" & _Dt.ToString("yyyyMMdd") & "#" & TxtMa_HD_H.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To _DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(i))
        Next
        If _DsTmp.Tables.Count <= 1 Then
            _DsTmp.Dispose()
            Exit Sub
        End If
        If _DsTmp.Tables(0).Rows.Count < 1 Or _DsTmp.Tables(1).Rows.Count < 1 Then
            _DsTmp.Dispose()
            Exit Sub
        End If
        If Not _DsTmp.Tables(0).Columns.Contains("Status") Or Not _DsTmp.Tables(0).Columns.Contains("Msg") Or Not _DsTmp.Tables(0).Columns.Contains("Note") Then
            _DsTmp.Dispose()
            Exit Sub
        End If
        If Not CyberSupport.V_MsgChk(_DsTmp.Tables(0), SysVar) Then
            _DsTmp.Dispose()
            Exit Sub
        End If
        '--------------------------------------------------------------------------
        If _DsTmp.Tables(1).Columns.Contains("Ma_Kh") Then If TxtMa_Kh.Text.Trim = "" Then TxtMa_Kh.Text = _DsTmp.Tables(1).Rows(0).Item("Ma_Kh")
        If _DsTmp.Tables(1).Columns.Contains("Ten_Kh") Then TxtTen_Kh.Text = _DsTmp.Tables(1).Rows(0).Item("Ten_Kh")
        If _DsTmp.Tables(1).Columns.Contains("Ten_KhVAT") Then If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = _DsTmp.Tables(1).Rows(0).Item("Ten_KhVAT")
        If _DsTmp.Tables(1).Columns.Contains("Dia_ChiVAT") Then If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = _DsTmp.Tables(1).Rows(0).Item("Dia_ChiVAT")
        If _DsTmp.Tables(1).Columns.Contains("Ma_So_Thue") Then If TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = _DsTmp.Tables(1).Rows(0).Item("Ma_So_Thue")

        If _DsTmp.Tables(1).Columns.Contains("Ma_HD_H") Then TxtMa_HD_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ma_HD_H")
        If _DsTmp.Tables(1).Columns.Contains("Ten_HD_H") Then TxtTen_HD_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ten_HD_H")

        If _DsTmp.Tables(1).Columns.Contains("Ma_BP_H") Then If TxtMa_BP_H.Text.Trim = "" Then TxtMa_BP_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ma_BP_H")
        If _DsTmp.Tables(1).Columns.Contains("Ten_BP_H") Then TxtTen_BP_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ten_BP_H")
        If _DsTmp.Tables(1).Columns.Contains("Ma_Hs_H") Then If TxtMa_Hs_H.Text.Trim = "" Then TxtMa_Hs_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ma_Hs_H")
        If _DsTmp.Tables(1).Columns.Contains("Ten_Hs_H") Then TxtTen_Hs_H.Text = _DsTmp.Tables(1).Rows(0).Item("Ten_Hs_H")
        If _DsTmp.Tables(1).Columns.Contains("Ong_Ba") Then If TxtOng_Ba.Text = "" Then TxtOng_Ba.Text = _DsTmp.Tables(1).Rows(0).Item("Ong_Ba")
        If _DsTmp.Tables(1).Columns.Contains("Dien_Giai") Then If TxtDien_Giai.Text = "" Then TxtDien_Giai.Text = _DsTmp.Tables(1).Rows(0).Item("Dien_Giai")
        '--------------------------------------------------------------------------
        If _DsTmp.Tables.Count = 2 Then
            _DsTmp.Dispose()
            Exit Sub
        End If
        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(_DsTmp.Tables(2), Dt_DetailTmp)
        Dt_DetailTmp.AcceptChanges()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        _DsTmp.Dispose()
        UpdateList()
    End Sub
#End Region
#Region "Valid --- Ma_Nx"
    Private Sub V_Ma_Nx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Nx.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTk", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Nx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Nx.Text = "" Then
            TxtTen_Nx.Text = ""
            V_GetTk_Thue_No()
            Exit Sub
        End If
        DrReturn = TxtMa_Nx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Nx.Text = DrReturn.Item("Tk")
            TxtTen_Nx.Text = DrReturn.Item("Ten_Tk")
        End If
        If TxtMa_Nx.Text = "" Then
            V_GetTk_Thue_No()
            TxtTen_Nx.Text = ""
            V_GetTk_Thue_No()
            Exit Sub
        End If
        V_GetTk_Thue_No()
        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, TxtMa_Nx.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid --- Ma_BP_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_BP_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP_H.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Hs_H"
    Private Sub V_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Thue"
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Thue.Text = "" Then
            TxtThue_Suat.Double = 0
            UpdateList()
            Exit Sub
        End If
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Thue.Text, "Ma_Thue", "DmThue", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then
            TxtThue_Suat.Double = 0
            UpdateList()
            Exit Sub
        Else
            TxtThue_Suat.Double = DrReturn.Item("Thue_Suat")
            TxtMa_Thue.Text = DrReturn.Item("Ma_Thue")
            If ChkSua_TkThue.Checked Then
                If TxtTk_Thue_Co.Text.Trim = "" Then TxtTk_Thue_Co.Text = DrReturn.Item("Tk_Thue_Co")
            Else
                TxtTk_Thue_Co.Text = DrReturn.Item("Tk_Thue_Co")
            End If

            UpdateList()
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk_Thue_no"
    Private Sub V_Tk_Thue_no(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk_Thue_No.ReadOnly Then Exit Sub
        TxtTk_Thue_No.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTk", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Thue_No(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Then
            V_GetTk_Thue_No()
            Exit Sub
        End If

        If TxtTk_Thue_No.Text = "" Then Exit Sub
        DrReturn = TxtTk_Thue_No.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTk_Thue_No.Text = DrReturn.Item("Tk")
    End Sub
#End Region
#Region "Valid --- Tk_Thue_Co"
    Private Sub V_Tk_Thue_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk_Thue_Co.ReadOnly Then Exit Sub
        TxtTk_Thue_Co.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTk", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Thue_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Then
            V_GetTk_Thue_Co()
            Exit Sub
        End If
        DrReturn = TxtTk_Thue_Co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTk_Thue_Co.Text = DrReturn.Item("Tk")
    End Sub
#End Region
#Region "Phieu xuat gia dich danh Sua/HT thue/Tien thue/Chiet khau"
    Private Sub V_Px_Gia_DD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Chk As Boolean = ChkPx_Gia_DD.Checked
        If Not EditGia Is Nothing Then EditGia.ColumnReadOnly = Not _Chk
        If Not EditGia_Nt Is Nothing Then EditGia_Nt.ColumnReadOnly = Not _Chk
        If Not EditTien Is Nothing Then EditTien.ColumnReadOnly = Not _Chk
        If Not EditTien_Nt Is Nothing Then EditTien_Nt.ColumnReadOnly = Not _Chk

        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
    End Sub
    Private Sub V_GetTk_Thue_No()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Or TxtTk_Thue_No.Text.Trim = "" Then TxtTk_Thue_No.Text = TxtMa_Nx.Text
    End Sub
    Private Sub V_GetTk_Thue_Co()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Or TxtTk_Thue_Co.Text.Trim = "" Then
            DrReturn = CyberSmodb.SQLGetRow(AppConn, "DmThue", "Ma_Thue = N'" + TxtMa_Thue.Text.Trim + "'", CyberSmlib)
            If DrReturn Is Nothing Then Exit Sub
            TxtTk_Thue_Co.Text = DrReturn.Item("Tk_Thue_Co")
            TxtThue_Suat.Double = DrReturn.Item("Thue_Suat")
            UpdateList()
        End If
    End Sub
    Private Sub V_Sua_TkThue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Then
            TxtTk_Thue_Co.ReadOnly = True
            TxtTk_Thue_No.ReadOnly = True
            V_GetTk_Thue_No()
            V_GetTk_Thue_Co()
            Exit Sub
        End If
        TxtTk_Thue_No.ReadOnly = False
        TxtTk_Thue_Co.ReadOnly = False
        TxtTk_Thue_Co.Focus()
    End Sub
    Private Sub V_Sua_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_Thue.Checked Then
            TxtT_thue_NT.ReadOnly = True
        Else
            TxtT_thue_NT.ReadOnly = False
            TxtT_thue_NT.Focus()
        End If
        UpdateList()
    End Sub
    Private Sub V_Sua_Thue_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        UpdateList()
    End Sub
    Private Sub V_Sua_Ck(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_CK.Checked Then
            TxtT_CK_Nt.ReadOnly = True
            For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
                V_Tinh_Toan(iRow)
            Next
            UpdateList()
        Else
            TxtT_CK_Nt.ReadOnly = False
            UpdateList()
            TxtT_CK_Nt.Focus()
        End If
    End Sub
    Private Sub L_T_CK_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_CK.Checked Then
            TxtT_CK_Nt.ReadOnly = True
        Else
            TxtT_CK_Nt.ReadOnly = False
            V_Phan_Bo_Tien()
        End If
        UpdateList()
    End Sub
    Private Sub E_T_CK_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If Not Me.ChkSua_CK.Checked Then SendKeys.Send("{Tab}")
    End Sub
    Private Sub L_T_Thue_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        UpdateList()
    End Sub
    Private Sub E_T_Thue_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If Not Me.ChkSua_Thue.Checked Then SendKeys.Send("{Tab}")
    End Sub
#End Region
#Region "Lenh/SO/Po/Ro/Vt"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_FormatSo_So(AppConn, osysvar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_SO.Text, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_FormatSo_PO(AppConn, osysvar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_PO.Text, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_RO.Text, CmbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_Vt.Text = CyberVoucher.V_FormatSo_VT(AppConn, osysvar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_Vt.Text, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub V_Tinh_Thue_CK()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim nTy_Gia As Decimal = V_GetTyGia()
        Dim nT_Tien_Nt2 As Decimal = TxtT_Tien_NT2.Double
        Dim nT_Tien2 As Decimal = TxtT_Tien2.Double
        Dim nT_Thue_Nt As Decimal = TxtT_thue_NT.Double
        Dim nT_Thue As Decimal = TxtT_Thue.Double
        Dim nT_Ck_Nt As Decimal = 0
        Dim nT_Ck As Decimal = 0
        If Not ChkSua_CK.Checked Then
            For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
                nT_Ck_Nt = nT_Ck_Nt + Dv_DetailTmp.Item(iRow).Item("CK_NT")
                nT_Ck = nT_Ck + Dv_DetailTmp.Item(iRow).Item("CK_NT")
            Next
            TxtT_CK_Nt.Double = nT_Ck_Nt
            TxtT_CK.Double = nT_Ck
        End If

        nT_Ck_Nt = TxtT_CK_Nt.Double
        nT_Ck = TxtT_CK.Double

        If Not ChkSua_Thue.Checked Then
            Dim nThue_Suat As Decimal = TxtThue_Suat.Double
            Dim nT_Tien_Hang_NT As Decimal = TxtT_Tien_NT2.Double
            If ChkSua_Thue_CK.Checked Then nT_Tien_Hang_NT = nT_Tien_Hang_NT - nT_Ck_Nt
            nT_Thue_Nt = CyberSupport.V_Round(nT_Tien_Hang_NT * nThue_Suat / 100, M_R_TIEN_NT)
            TxtT_thue_NT.Double = nT_Thue_Nt
            TxtT_thue_NT.Refresh()
        End If

        nT_Thue_Nt = TxtT_thue_NT.Double
        nT_Ck_Nt = TxtT_CK_Nt.Double

        If nTy_Gia <> 1 Then
            nT_Thue = CyberSupport.V_Round(nT_Thue_Nt * nTy_Gia, M_R_TIEN)
            nT_Ck = CyberSupport.V_Round(nT_Ck_Nt * nTy_Gia, M_R_TIEN)
        Else
            nT_Thue = nT_Thue_Nt
            nT_Ck = nT_Ck_Nt
        End If
        TxtT_Thue.Double = nT_Thue
        TxtT_CK.Double = nT_Ck
    End Sub
    Private Sub UpdateList()
        Dim nT_Tien_Nt2 As Decimal = 0
        Dim nT_Tien2 As Decimal = 0

        Dim nT_Tien_Nt As Decimal = 0
        Dim nT_Tien As Decimal = 0
        Dim nT_TT_NT As Decimal = 0
        Dim nT_TT As Decimal = 0

        Dim nT_KM As Decimal = 0
        Dim nT_BB As Decimal = 0
        Dim nT_Moi_gioi As Decimal = 0
        Dim nT_Km_khac As Decimal = 0
        Dim nT_CP As Decimal = 0

        Dim nT_So_Luong As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_Tien_Nt = nT_Tien_Nt + Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien")
            nT_Tien_Nt2 = nT_Tien_Nt2 + Dv_DetailTmp.Item(iRow).Item("Tien_Nt2")
            nT_Tien2 = nT_Tien2 + Dv_DetailTmp.Item(iRow).Item("Tien2")
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_Luong")

            If Dt_DetailTmp.Columns.Contains("Km_Pk") Then nT_KM = nT_KM + Dv_DetailTmp.Item(iRow).Item("Km_Pk")
            If Dt_DetailTmp.Columns.Contains("Km_BH") Then nT_KM = nT_KM + Dv_DetailTmp.Item(iRow).Item("Km_BH")

            If Dt_DetailTmp.Columns.Contains("Bh_BB") Then nT_BB = nT_BB + Dv_DetailTmp.Item(iRow).Item("Bh_BB")
            If Dt_DetailTmp.Columns.Contains("Moi_Gioi") Then nT_Moi_gioi = nT_Moi_gioi + Dv_DetailTmp.Item(iRow).Item("Moi_Gioi")
            If Dt_DetailTmp.Columns.Contains("Km_Khac") Then nT_Km_khac = nT_Km_khac + Dv_DetailTmp.Item(iRow).Item("Km_Khac")


        Next
        nT_CP = nT_KM + nT_BB + nT_Moi_gioi + nT_Km_khac

        TxtT_So_Luong.Double = nT_So_Luong
        TxtT_Tien_NT.Double = nT_Tien_Nt
        TxtT_Tien.Double = nT_Tien
        TxtT_Tien_NT2.Double = nT_Tien_Nt2
        TxtT_Tien2.Double = nT_Tien2
        '----------------------------------------------------------------------
        V_Tinh_Thue_CK()
        '----------------------------------------------------------------------
        Dim nT_Thue_NT As Decimal = TxtT_thue_NT.Double
        Dim nT_Thue As Decimal = TxtT_Thue.Double

        Dim nT_CK_NT As Decimal = TxtT_CK_Nt.Double
        Dim nT_CK As Decimal = TxtT_CK.Double

        nT_TT_NT = nT_Tien_Nt2 + nT_Thue_NT - nT_CK_NT
        nT_TT = nT_Tien2 + nT_Thue - nT_CK
        TxtT_TT_NT.Double = nT_TT_NT
        TxtT_TT.Double = nT_TT
        '----------------------------------------------------------------------
        TxtT_KM.Double = nT_KM
        TxtT_BB.Double = nT_BB
        '--TxtT_Moi_Gioi.Double = nT_Moi_gioi
        TxtT_Km_Khac.Double = nT_Km_khac
        TxtT_CP.Double = nT_CP
        '----------------------------------------------------------------------
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '--------------------------------------------------------------------------------
        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt2") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt2"), M_R_TIEN_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt2") = 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") = 0
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '--------------------------------------------------------------------------------
        '--- Phan chiet khau
        If Not ChkSua_CK.Checked Then

            If Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") * Dv_DetailTmp.Item(iRow).Item("PT_CK") <> 0 Then
                Dv_DetailTmp.Item(iRow).BeginEdit()
                Dv_DetailTmp.Item(iRow).Item("CK_NT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") * Dv_DetailTmp.Item(iRow).Item("PT_CK") / 100, M_R_TIEN_NT)
                Dv_DetailTmp.Item(iRow).EndEdit()
            End If
            If Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") * Dv_DetailTmp.Item(iRow).Item("PT_CK") = 0 Then
                Dv_DetailTmp.Item(iRow).BeginEdit()
                Dv_DetailTmp.Item(iRow).Item("CK_NT") = 0
                Dv_DetailTmp.Item(iRow).EndEdit()
            End If

        End If
        '--------------------------------------------------------------------------------
        '----------------VND
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If nTy_Gia = 1 Then
            Dv_DetailTmp.Item(iRow).Item("Tien2") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt2")
            Dv_DetailTmp.Item(iRow).Item("Gia2") = Dv_DetailTmp.Item(iRow).Item("Gia_Nt2")
            If Not ChkSua_CK.Checked Then Dv_DetailTmp.Item(iRow).Item("CK") = Dv_DetailTmp.Item(iRow).Item("CK_NT")
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailTmp.Item(iRow).Item("Tien2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Gia2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia_Nt2") * nTy_Gia, M_R_GIA)
            If Not ChkSua_CK.Checked Then Dv_DetailTmp.Item(iRow).Item("CK") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("CK_NT") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
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
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
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
#Region "Ma_Kx/Ma_Mau/Vitri - "
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
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        CyberSupport.V_Lookup("Ma_Kx", "DmKx", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ma_Kx") = ""
            Dt_DetailTmp.Rows(iRow).Item("Ten_Kx") = ""
            Dt_DetailTmp.Rows(iRow).EndEdit()
            Exit Sub
        Else
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ma_Kx") = DrReturn("Ma_Kx").ToString.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ten_Kx") = DrReturn("Ten_Kx" + IIf(M_LAN = "V", "", "2")).ToString.Trim
        End If

        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _TK_VT As String = DrReturn.Item("TK_Vt")
        Dim _TK_DT As String = DrReturn.Item("TK_DT")
        Dim _Tk_Gv As String = DrReturn.Item("Tk_Gv")
        Dim _Tk_CK As String = If(DrReturn.Table.Columns.Contains("TK_CK"), DrReturn.Item("Tk_CK"), "")
        Dim _Ma_Kho As String = DrReturn.Item("Ma_Kho")
        Dim _Ma_Vitri As String = DrReturn.Item("Ma_Vitri")

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tk_VT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim = "", _TK_VT, Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_DT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_DT").ToString.Trim = "", _TK_DT, Dv_DetailTmp.Item(iRow).Item("Tk_DT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_GV") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_GV").ToString.Trim = "", _Tk_Gv, Dv_DetailTmp.Item(iRow).Item("TK_GV").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Tk_CK") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_CK").ToString.Trim = "", _Tk_CK, Dv_DetailTmp.Item(iRow).Item("Tk_CK").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim = "", _Ma_Kho, Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim)

        If Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri") Then Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim = "", _Ma_Vitri, Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim)
        If Dv_DetailTmp.Table.Columns.Contains("So_Cho") And DrReturn.Table.Columns.Contains("So_Cho") Then Dv_DetailTmp.Item(iRow).Item("So_Cho") = DrReturn.Item("So_Cho")
        If Dv_DetailTmp.Table.Columns.Contains("Xuat_Xu") And DrReturn.Table.Columns.Contains("Xuat_Xu") Then Dv_DetailTmp.Item(iRow).Item("Xuat_Xu") = DrReturn.Item("Xuat_Xu")
        If Dv_DetailTmp.Table.Columns.Contains("Quy_Cach") And DrReturn.Table.Columns.Contains("Quy_Cach") Then Dv_DetailTmp.Item(iRow).Item("Quy_Cach") = DrReturn.Item("Quy_Cach")
        If Dv_DetailTmp.Table.Columns.Contains("Dung_Tich") And DrReturn.Table.Columns.Contains("Dung_Tich") Then Dv_DetailTmp.Item(iRow).Item("Dung_Tich") = DrReturn.Item("Dung_Tich")
        If Dv_DetailTmp.Table.Columns.Contains("Model_Code") And DrReturn.Table.Columns.Contains("Model_Code") Then Dv_DetailTmp.Item(iRow).Item("Xuat_Xu") = DrReturn.Item("Model_Code")

        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPriceXeSales(iRow, "3")
        V_SetSD(iRow)
        UpdateList()
    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_Kx As String = ""
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then _Ma_Kx = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" + _Ma_Kx + "'"
        CyberSupport.V_Lookup("Ma_Mau", "DmMauKx", "1=1", _FilterClient, M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau") Then Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau") = DrReturn("Ma_Mau").ToString.Trim
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau") Then
                If DrReturn.Table.Columns.Contains("Ten_Mau") Then
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = DrReturn("Ten_Mau").ToString.Trim
                Else
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" + DrReturn("Ma_Mau").ToString.Trim + "')", CyberSmlib)
                End If
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPriceXeSales(iRow, "4")
        V_SetSD(iRow)
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub L_So_Khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("So_Khung").ToString.Trim = "" Then Exit Sub
        V_SetPriceXeSales(iRow, "1")
    End Sub
    Private Sub L_So_May(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("So_May").ToString.Trim = "" Then Exit Sub
        V_SetPriceXeSales(iRow, "2")
    End Sub
    Private Sub V_Ma_Kho_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        ' V_SetPriceXeSales(iRow,"5")
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
        Dim _Ma_Kx As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        Dim _Ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _Ma_Vitri As String = If(Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri"), Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim, "")
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_Lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "XE", M_Mode, _Ma_Kx, _Ma_Kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If Dt_DetailTmp.Columns.Contains("Ton13") Then Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ma_Vitri") And _Return.Table.Columns.Contains("ma_Vitri") Then Dv_DetailTmp.Item(iRow).Item("ma_Vitri") = _Return("ma_Vitri")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor") And _Return.Table.Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = _Return.Item("BackColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor2") And _Return.Table.Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = _Return.Item("BackColor2")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ForeColor") And _Return.Table.Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = _Return.Item("ForeColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Bold") And _Return.Table.Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = _Return.Item("Bold")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Underline") And _Return.Table.Columns.Contains("Underline") Then Dv_DetailTmp.Item(iRow).Item("Underline") = _Return.Item("Underline")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Italic") And _Return.Table.Columns.Contains("Italic") Then Dv_DetailTmp.Item(iRow).Item("Italic") = _Return.Item("Italic")


            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
    Private Sub V_SetPriceXeSales(ByVal iRow As Integer, ByVal _Loai As String)
        '_Loai:  1 - So _khung, 2 - So May, 3 - Ma_Kx,  4 - Ma_Mau, 5 -  Ma_Kho
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub

        Dim _Ma_Kx As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        Dim _Ma_Mau As String = Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim

        Dim _So_Khung As String = Dv_DetailTmp.Item(iRow).Item("So_Khung").ToString.Trim
        Dim _So_May As String = Dv_DetailTmp.Item(iRow).Item("So_May").ToString.Trim

        Dim _So_Luong As Decimal = 1 'Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Dim _Gia_Nt2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_Nt2")
        Dim _Tien_Nt2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Tien_Nt2")
        Dim _Stt_Rec0 As String = Dv_DetailTmp.Item(iRow).Item("Stt_Rec0").ToString.Trim
        Dim _Stt_Rec0_HDX As String = Dv_DetailTmp.Item(iRow).Item("Stt_Rec0_HDX").ToString.Trim
        Dim _Ma_Kh As String = TxtMa_Kh.Text
        Dim _Ma_HD As String = TxtMa_HD_H.Text
        Dim _ngay_Ct As Date = TxtNgay_Ct.Value

        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPriceXeSalesHDC", _Loai + "#" + _So_Khung.Trim + "#" + _So_May.Trim + "#" + _
                                                                                _Ma_Kx.Trim + "#" + _Ma_Mau.Trim + "#" + _
                                                                       _Ma_Kh + "#" + _Ma_HD + "#" + _ngay_Ct.ToString("yyyyMMdd") + "#" + _
        _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_Nt2.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt2.ToString.Trim.Replace(",", ".") + "#" + _
        M_Mode.Trim + "#" + _Stt_Rec0 + "#" + _Stt_Rec0_HDX + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

        If DsgetPrice.Tables.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If
        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If

        Dim _DtGia As DataTable = DsgetPrice.Tables(0)

        Dv_DetailTmp.Item(iRow).BeginEdit()
        If _DtGia.Columns.Contains("So_Luong") Then Dv_DetailTmp.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
        If _DtGia.Columns.Contains("Gia_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Gia_Nt2") = _DtGia.Rows(0).Item("Gia_Nt2")
        If _DtGia.Columns.Contains("Tien_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") = _DtGia.Rows(0).Item("Tien_Nt2")
        '----------------------------------------------------------------------------
        If _DtGia.Columns.Contains("Ma_Kx") And Dt_DetailTmp.Columns.Contains("Ma_Kx") Then Dv_DetailTmp.Item(iRow).Item("Ma_Kx") = _DtGia.Rows(0).Item("Ma_Kx")
        If _DtGia.Columns.Contains("Ten_Kx") And Dt_DetailTmp.Columns.Contains("Ten_Kx") Then Dv_DetailTmp.Item(iRow).Item("Ten_Kx") = _DtGia.Rows(0).Item("Ten_Kx")
        If _DtGia.Columns.Contains("Ma_Mau") And Dt_DetailTmp.Columns.Contains("Ma_Mau") Then Dv_DetailTmp.Item(iRow).Item("Ma_Mau") = _DtGia.Rows(0).Item("Ma_Mau")
        If _DtGia.Columns.Contains("Ten_Mau") And Dt_DetailTmp.Columns.Contains("Ten_Mau") Then Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = _DtGia.Rows(0).Item("Ten_Mau")
        If _DtGia.Columns.Contains("So_Khung") And Dt_DetailTmp.Columns.Contains("So_Khung") Then Dv_DetailTmp.Item(iRow).Item("So_Khung") = _DtGia.Rows(0).Item("So_Khung")
        If _DtGia.Columns.Contains("So_May") And Dt_DetailTmp.Columns.Contains("So_May") Then Dv_DetailTmp.Item(iRow).Item("So_May") = _DtGia.Rows(0).Item("So_May")
        '----------------------------------------------------------------------------
        If _DtGia.Columns.Contains("TK_VT") And Dt_DetailTmp.Columns.Contains("TK_VT") Then Dv_DetailTmp.Item(iRow).Item("TK_VT") = _DtGia.Rows(0).Item("TK_VT")
        If _DtGia.Columns.Contains("Tk_DT") And Dt_DetailTmp.Columns.Contains("Tk_DT") Then Dv_DetailTmp.Item(iRow).Item("Tk_DT") = _DtGia.Rows(0).Item("Tk_DT")
        If _DtGia.Columns.Contains("Tk_GV") And Dt_DetailTmp.Columns.Contains("Tk_GV") Then Dv_DetailTmp.Item(iRow).Item("Tk_GV") = _DtGia.Rows(0).Item("Tk_GV")
        If _DtGia.Columns.Contains("Tk_CK") And Dt_DetailTmp.Columns.Contains("Tk_CK") Then Dv_DetailTmp.Item(iRow).Item("Tk_CK") = _DtGia.Rows(0).Item("Tk_CK")
        '----------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        DsgetPrice.Dispose()
        V_Tinh_Toan(iRow)
    End Sub
    'Private Sub V_SetPriceXeSales(ByVal iRow As Integer)
    '    If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
    '    If iRow < 0 Then Exit Sub
    '    Dim _Ma_Kx As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
    '    Dim _Ma_Mau As String = Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim
    '    Dim _So_Luong As Decimal = 1 'Dv_DetailTmp.Item(iRow).Item("So_Luong")
    '    Dim _Gia_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_Nt2")
    '    Dim _Tien_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Tien_Nt2")
    '    Dim _Dat_Coc As Decimal = 0
    '    Dim _Ma_Kh As String = TxtMa_Kh.Text
    '    Dim _ngay_Ct As Date = TxtNgay_Ct.Value
    '    Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPriceXeSales", _Ma_Kx.Trim + "#" + _Ma_Mau.Trim + "#" + _Ma_Kh + "#" + _
    '    _ngay_Ct.ToString("yyyyMMdd") + "#" + _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_Nt.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt.ToString.Trim.Replace(",", ".") + "#" + _
    '    _Dat_Coc.ToString.Trim.Replace(",", ".") + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

    '    If DsgetPrice.Tables(0).Rows.Count <= 0 Then
    '        DsgetPrice.Dispose()
    '        Exit Sub
    '    End If

    '    Dim _DtGia As DataTable = DsgetPrice.Tables(0)
    '    Dv_DetailTmp.Item(iRow).BeginEdit()
    '    'If _DtGia.Columns.Contains("So_Luong") Then Dv_DetailTmp.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
    '    If _DtGia.Columns.Contains("Gia_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Gia_Nt2") = _DtGia.Rows(0).Item("Gia_Nt2")
    '    If _DtGia.Columns.Contains("Tien_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Tien_Nt2") = _DtGia.Rows(0).Item("Tien_Nt2")

    '    Dv_DetailTmp.Item(iRow).EndEdit()
    '    Dv_DetailTmp.Table.AcceptChanges()
    '    DsgetPrice.Dispose()
    '    V_Tinh_Toan(iRow)
    'End Sub
#End Region
#Region "Tai khoan "
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Tk_DT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Dt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Dt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Tk_CK(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_CK(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_CK(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Tk_GV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Gv(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Gv(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_So(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_PO(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_Ro(Dv_DetailTmp, iRow, AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_Ct, CmbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_VT(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
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
    Private Sub V_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub V_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
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
#Region "Ty gia -  Ngoai te"
    Private Sub L_Ma_NT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, DsLookup, TxtMa_NT.Text, "Ma_NT", "DmNT", DrReturn, "1=1", "1=1", "1")
        If Not DrReturn Is Nothing Then TxtMa_NT.Text = DrReturn.Item("Ma_NT") Else TxtMa_NT.Text = ""
        Dim Dt As Date = TxtNgay_Ct.Value
        TxtTy_Gia.Double = CyberSupport.GetRate(Dt, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        GetRound()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
        VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRV)
        DetailGRV.RefreshData()
    End Sub
    Private Function V_GetTyGia() As Decimal
        Dim nTy_Gia As Decimal = TxtTy_Gia.Double
        If nTy_Gia = 0 Then nTy_Gia = 1
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_MA_NT0")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.ToUpper.Trim Then TxtTy_Gia.Double = 1
        TxtTy_Gia.Double = nTy_Gia
        V_GetTyGia = nTy_Gia
    End Function
#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)

        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
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
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Mode = "X" Then Exit Sub
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
        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        ''If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
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
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailVaTTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        V_Phan_Bo_Tien()
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
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, "", M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        ''V_SetFocus("L")
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Save_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
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
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailVaTTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        V_Phan_Bo_Tien()
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CmbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,Ten_Kh", "Ten_Kx,Ten_Kho_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------

        If Not Add2Database() Then Return
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
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_Kx").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)

            If Dt_DetailTmp.Columns.Contains("Ma_HD_I") Then If TxtMa_HD_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I") = TxtMa_HD_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_TD3_I") Then If TxtMa_TD3_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_TD3_I") = TxtMa_TD3_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_BP_I") Then If TxtMa_BP_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_BP_I") = TxtMa_BP_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Hs_I") Then If TxtMa_Hs_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Hs_I") = TxtMa_Hs_H.Text.Trim
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        UpdateList()
        ChkVsave = True
    End Function
    Private Sub V_Phan_Bo_Tien()
        If ChkSua_CK.Checked Then
            CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_Nt2", "Ck_Nt", TxtT_CK_Nt.Double, M_R_TIEN_NT)
            CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_Nt2", "Ck", TxtT_CK.Double, M_R_TIEN)
        End If
        CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_Nt2", "Thue_Nt", TxtT_thue_NT.Double, M_R_TIEN_NT)
        CyberSupport.Phan_Bo(Dt_DetailTmp, "Tien_Nt2", "Thue", TxtT_Thue.Double, M_R_TIEN)
    End Sub
    Private Function Add2Database() As Boolean
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
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
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
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)

        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
    Private Sub Add2Database_Luu()
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
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
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
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL
        If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
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
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        TxtSo_Ct.Text = _So_Ct_Copy.Trim
        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

        TxtNgay_CtHD.Value = TxtNgay_Ct.Value
        TxtNoteHDDT.Text = ""
        TxtMau_VATHD.Text = ""
        TxtSo_seriHD.Text = ""
        TxtSo_HDDT.Text = ""
        TxtMa_Tra_Cuu.Text = ""
        TxtEmailHDDT.Text = ""

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
        If TxtMa_Nx.Text.Trim = "" Then
            TxtMa_Nx.Text = M_Tk_No
            TxtTen_Nx.Text = M_Ten_Tk_No
        End If
        If TxtHT_TT.Text.Trim = "" Then TxtHT_TT.Text = M_HT_TT
        '----------------------------------------------------------
        V_New()

        ''TxtNgay_Gx.Value = Now.Date
        TxtNgay_Gx.Value = Now
        '----------------------------------------------------------
        TxtNgay_CMT.Value = New Date(1900, 1, 1)
        TxtNgay_CtHD.Value = New Date(1900, 1, 1)
        '----------------------------------------------------------
        If TxtMa_Thue.Text = "" Then TxtMa_Thue.Text = M_Ma_THue

        V_GetTk_Thue_No()
        V_GetTk_Thue_Co()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        '----------------------------------------------------------------------------
        CyberSmodb.SetValueFromCombox(CmbMa_TTCP_H, M_Ma_TTCP_H)
        '----------------------------------------------------------------------------
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
            DrCurren.Item("So_Luong") = 1
            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
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
        If Not chkCherDeleteHDDT("D") Then Exit Sub
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
    Function chkCherDeleteHDDT(ByVal Status As String) As Boolean
        If DrDmct.Table.Columns.Contains("HDDT") = False Then Return True
        If DrDmct("HDDT").ToString.Trim <> "1" Then Return True

        Dim dsReturn As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_InvoiceChekDeleteVoucher", M_Ma_CT & "#" & M_Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If dsReturn.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper = "N" Then
            MsgBox(dsReturn.Tables(0).Rows(0)("Note").ToString.Trim, MsgBoxStyle.Critical, osysvar("M_CYBER_VER"))
            dsReturn.Dispose()
            Return False
        End If
        dsReturn.Dispose()
        Return True
    End Function
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
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
        DvNew.Item("So_Luong") = 1
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
    Private Sub SetTxt()
        TxtT_So_Luong.ReadOnly = True

        TxtT_Tien_NT.ReadOnly = True
        TxtT_Tien.ReadOnly = True

        TxtThue_Suat.ReadOnly = True

        TxtT_Tien_NT2.ReadOnly = True
        TxtT_Tien2.ReadOnly = True

        TxtT_thue_NT.ReadOnly = True
        TxtT_Thue.ReadOnly = True

        TxtT_CK_Nt.ReadOnly = True
        TxtT_CK.ReadOnly = True

        TxtT_TT_NT.ReadOnly = True
        TxtT_TT.ReadOnly = True

        TxtTen_Kh.ReadOnly = True
        TxtTen_BP_H.ReadOnly = True
        TxtTen_Hs_H.ReadOnly = True
        TxtTen_Nx.ReadOnly = True

        If M_Mode = "M" Or M_Mode = "S" Then
            If ChkSua_CK.Checked Then TxtT_CK_Nt.ReadOnly = False
            If ChkSua_Thue.Checked Then TxtT_thue_NT.ReadOnly = False
        End If

        TxtNgay_CtHD.ReadOnly = True
        TxtNoteHDDT.ReadOnly = True
        TxtMau_VATHD.ReadOnly = True
        TxtSo_seriHD.ReadOnly = True
        TxtSo_HDDT.ReadOnly = True
        TxtMa_Tra_Cuu.ReadOnly = True

        TxtT_KM.ReadOnly = True
        TxtT_BB.ReadOnly = True
        TxtT_Moi_Gioi.ReadOnly = True
        TxtT_Km_Khac.ReadOnly = True
        TxtT_CP.ReadOnly = True
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
    Dim M_Ten_Hs_H As String = ""
    Dim M_Ten_Hs2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CmbMa_TTCP_H.Visible = M_Is_Visible_TTCP
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
            If DsTmp.Tables(0).Columns.Contains("Ten_Hs_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_Hs_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_Hs2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_Hs2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CmbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub
#End Region
End Class