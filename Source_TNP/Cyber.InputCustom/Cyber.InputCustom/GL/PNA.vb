Imports System.Data.SqlClient
Public Class PNA
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim _Para_so_XK As String = ""

#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim M_Ma_THue, M_Mau_BC As String
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_lo, EditTk_VT As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditMa_VT, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim Editma_Db_I, EditMa_Xe_I, EditMa_KX_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditTen_Vt, EditDvt, EditTen_kho_i, EditTen_Tk_VT, EditSo_Luong, EditGia_NT0, EditGia0, EditGia_NT, EditTien_NT0, EditTien0, EditCP_NT, EditCP, EditGia, EditTien_NT, EditTien, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If M_Stt_Rec = "" Then V_LoadNew(sender, e)
    End Sub
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_so_XK.Trim = "" Then Exit Sub
        V_New(sender, e)
        If Not M_Mode = "M" Then Exit Sub
        Txtso_XK.Text = _Para_so_XK

        V_XK(sender, e)
        V_New()
    End Sub
    Private Sub V_XK(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_XK1("1")
    End Sub

    Private Sub V_XK1(ByVal status As String)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Txtso_XK.Text = "" Then Exit Sub
        Dim strField As String = ""
        Dim strValue As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberSmodb.GetValueControler(Me, strField, strValue)
        Dim dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPNAFromPXK", _Ngay_Ct.ToString("yyyyMMdd") + "#" + M_Ma_CT.Trim + "#" + M_Stt_Rec + "#" + M_Mode + "#" + strField + "#" + strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        For i As Integer = 0 To dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(dstmp.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(dstmp.Tables(0), osysvar, M_LAN) Then
            If dstmp.Tables(0).Columns.Contains("So_XK") Then Txtso_XK.Text = dstmp.Tables(0).Rows(0).Item("So_XK").ToString.Trim
            dstmp.Dispose()
            Exit Sub
        End If

        '------------------------------------------------------------------------------------------------------------------------------------------
        '--------------        
        If dstmp.Tables(2).Rows.Count <= 0 Then
            dstmp.Dispose()
            Exit Sub
        End If

        Dt_DetailTmp.Clear()
        CyberSmodb.SetNotNullTable(dstmp.Tables(2))
        CyberSmodb.SQLTbToTb(dstmp.Tables(2), Dt_DetailTmp)
        dstmp.Dispose()

        UpdateList()
        CyberSmlib.FlushMemory()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)
        Dt_DetailVat = M_DsData.Tables(2)
        Dt_DetailVatTmp = Dt_DetailVat.Clone
        '-------------------------------------
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Master = New DataView(Dt_Master)

        Dv_DetailVat = New DataView(Dt_DetailVat)
        Dv_DetailVatTmp = New DataView(Dt_DetailVatTmp)
        '-------------------------------------
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)

        TxtT_SO_LUONG.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_SO_LUONG.InputMask)

        TxtT_Tien_NT0.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_NT0.InputMask)
        TxtT_Tien0.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien0.InputMask)

        TxtT_CP_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_CP_NT.InputMask)
        TxtT_CP.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_CP.InputMask)



        TxtT_thue_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_thue_NT.InputMask)
        TxtT_Thue.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue.InputMask)

        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_Tien.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien.InputMask)

        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_TT_NT.InputMask)
        TxtT_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT.InputMask)

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
        'M_Ma_THue = M_Para(M_VT_PARA + 3).Trim
        'M_Mau_BC = M_Para(M_VT_PARA + 4).Trim
        _Para_so_XK = ""
        Try
            _Para_so_XK = M_Para(M_VT_PARA + 3).Trim
        Catch ex As Exception

        End Try
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
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
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

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
        EditMa_lo.GetColumn(DetailGRV, "Ma_Lo")
        EditMa_VT.GetColumn(DetailGRV, "Ma_VT")
        EditTen_Vt.GetColumn(DetailGRV, "Ten_VT")

        EditDvt.GetColumn(DetailGRV, "DVT")
        EditMa_Vitri.GetColumn(DetailGRV, "ma_Vitri")

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
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else txtOng_ba.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
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
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
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
        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtTen_KhVAT.Leave, AddressOf L_Ten_KhVAT
        AddHandler TxtDia_ChiVAT.Leave, AddressOf L_Ten_KhVAT
        AddHandler TxtDia_Chi.Leave, AddressOf L_Dia_Chi
        '--Ma_NX
        AddHandler txtMa_NX.CyberValiting, AddressOf V_Ma_NX
        AddHandler txtMa_NX.CyberLeave, AddressOf L_Ma_NX
        '--Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberLeave, AddressOf L_Ma_BP_H
        '--Ma_HS_H
        AddHandler txtMa_HS_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler txtMa_HS_H.CyberLeave, AddressOf L_Ma_HS_H
        '--Ma_Thue
        AddHandler TxtT_CP_NT.Leave, AddressOf L_T_CP_NT
        '--Mau_BC
        AddHandler TxtMau_BC.Leave, AddressOf L_Mau_BC
        '--Ma_Thue
        AddHandler TxtMa_Thue.Leave, AddressOf L_Ma_THue
        '--So_Hd_Gtgt
        AddHandler TxtSo_Hd_Gtgt.Leave, AddressOf L_So_Hd_Gtgt
        '--TK_Thue_Co
        AddHandler TxtTk_Thue_Co.CyberValiting, AddressOf V_Tk_Thue_Co
        AddHandler TxtTk_Thue_Co.CyberLeave, AddressOf L_Tk_Thue_Co
        '--TK_Thue_No
        AddHandler TxtTk_Thue_No.CyberValiting, AddressOf V_Tk_Thue_no
        AddHandler TxtTk_Thue_No.CyberLeave, AddressOf L_Tk_Thue_No
        '----------------------------------------------------------------------------------------------------------
        AddHandler ChkSua_TkThue.CheckedChanged, AddressOf V_Sua_TkThue
        AddHandler ChkSua_Thue.CheckedChanged, AddressOf V_Sua_Thue
        AddHandler ChkSua_Thue_CP.CheckedChanged, AddressOf V_Sua_Thue_CP
        '----------------------------------------------------------------------------------------------------------
        AddHandler ChkSua_CP.CheckedChanged, AddressOf V_Sua_CP
        AddHandler ChkPB_CP_SL.CheckedChanged, AddressOf V_PB_CP_SL
        AddHandler ChkPB_CP_Tien.CheckedChanged, AddressOf V_PB_CP_Tien
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtT_thue_NT.Leave, AddressOf L_T_Thue_NT
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_VT.Leave, AddressOf L_Lenh_VT
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditGia_NT0.Column Is Nothing Then AddHandler EditGia_NT0.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia0.Column Is Nothing Then AddHandler EditGia0.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditTien_NT0.Column Is Nothing Then AddHandler EditTien_NT0.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien0.Column Is Nothing Then AddHandler EditTien0.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditCP_NT.Column Is Nothing Then AddHandler EditCP_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCP.Column Is Nothing Then AddHandler EditCP.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditGia_NT.Column Is Nothing Then AddHandler EditGia_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditTien_NT.Column Is Nothing Then AddHandler EditTien_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan
        '----------------------------------------------------------------------------------------------------------
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        '----------------------------------------------------------------------------------------------------------
        EditTk_VT.V_ActiLookUpColumn(AddressOf V_Tk_VT, AddressOf L_Tk_VT)
        EditMa_lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)
        EditMa_VT.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_i, AddressOf L_Ma_Kho_i)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        '------------------------------------
        '---Add On
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_Sp_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_ku_I.V_ActiLookUpColumn(AddressOf V_Ma_KU_i, AddressOf L_Ma_KU_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)

        Editma_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_i, AddressOf L_Ma_Db_i)
        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_i, AddressOf L_Ma_Xe_i)
        EditMa_KX_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
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
            EditTien0.Visible = False
            EditGia0.Visible = False
            EditCP.Visible = False
            EditTien.Visible = False
            EditGia.Visible = False

            TxtT_Tien0.Visible = False
            TxtT_CP.Visible = False
            TxtT_Tien.Visible = False

            TxtT_Thue.Visible = False
            TxtT_TT.Visible = False
        Else
            EditTien0.Visible = True
            EditGia0.Visible = True
            EditCP.Visible = True
            EditTien.Visible = True
            EditGia.Visible = True
            TxtT_Tien0.Visible = True
            TxtT_CP.Visible = True
            TxtT_Tien.Visible = True
            TxtT_Thue.Visible = True
            TxtT_TT.Visible = True
        End If
        SetFoCusGRV()
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
            CbbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        '------------------------------------
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '------------------------------------
        Dt_DetailVatTmp.Clear()
        Dt_DetailVatTmp.AcceptChanges()

        For i = 0 To Dt_DetailVat.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailVatTmp.ImportRow(Dt_DetailVat.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '------------------------------------
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
        V_Sua_CP(New System.Object, New System.EventArgs)
        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, txtMa_NX.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
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
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
        SetTxt()
        SetFoCusGRV()
    End Sub
    Private Sub SetFoCusGRV()

        '---Chiet Khau
        Dim _Chk As Boolean = ChkSua_CP.Checked
        ChkPB_CP_SL.Visible = _Chk
        ChkPB_CP_Tien.Visible = _Chk
        LabPb_CP_SL_Tien.Visible = _Chk

        If Not (M_Mode = "S" Or M_Mode = "M") Then Exit Sub
        EditCP.ColumnReadOnly = _Chk
        EditCP_NT.ColumnReadOnly = _Chk
        CyberFill.SetFoCusGRV(DetailGRV, "CP", _Chk)
        CyberFill.SetFoCusGRV(DetailGRV, "CP_NT", _Chk)
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
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi"), TxtDia_Chi.Text)
            If txtOng_ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ong_Ba") Then txtOng_ba.Text = DrReturn.Item("Ong_Ba")
            If txtOng_ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Doi_Tac") Then txtOng_ba.Text = DrReturn.Item("Doi_Tac")
            If TxtHan_TT.Double = 0 Then If DrReturn.Table.Columns.Contains("han_TT") Then TxtHan_TT.Double = DrReturn.Item("han_TT")

            If TxtMa_So_Thue.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ma_So_Thue") Then TxtMa_So_Thue.Text = DrReturn.Item("Ma_So_Thue")
            If TxtTen_KhVAT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("ten_KhVAT") Then TxtTen_KhVAT.Text = DrReturn.Item("ten_KhVAT")
            If TxtDia_ChiVAT.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Dia_ChiVAT") Then TxtDia_ChiVAT.Text = DrReturn.Item("Dia_ChiVAT")
            If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = TxtTen_kh.Text
            If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
            '-----------------------------------------------------------------------------------------------------------
            If TxtMa_Bp_H.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("Ma_BP") Then TxtMa_Bp_H.Text = DrReturn.Item("Ma_BP")
                If TxtMa_Bp_H.Text.Trim <> "" Then txtTen_BP_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP = N'" + TxtMa_Bp_H.Text.Trim + "')", CyberSmlib)

            End If
            '-----------------------------------------------------------------------------------------------------------
            If txtMa_HS_H.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("Ma_HS") Then txtMa_HS_H.Text = DrReturn.Item("Ma_HS")
                If txtMa_HS_H.Text.Trim <> "" Then txtTen_HS_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS = N'" + txtMa_HS_H.Text.Trim + "')", CyberSmlib)
            End If
            '-----------------------------------------------------------------------------------------------------------
            If txtMa_NX.Text.Trim = "" Then
                If DrReturn.Table.Columns.Contains("TK") Then txtMa_NX.Text = DrReturn.Item("TK")
                If txtMa_NX.Text.Trim <> "" Then txtTen_NX.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TK", "DmTK", "(TK = N'" + txtMa_NX.Text.Trim + "')", CyberSmlib)
                If txtTen_NX.Text.Trim = "" Then txtMa_NX.Text = ""
            End If
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""

        End If
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            TxtDia_Chi.Text = ""
            V_GetTk_Thue_Co()
            Exit Sub
        End If
        V_GetTk_Thue_Co()
        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, txtMa_NX.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Ten_KhVAT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = TxtTen_kh.Text
        If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
    End Sub
    Private Sub L_Dia_Chi(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtDia_Chi.Text = CyberInput.GetDia_Chi(TxtMa_Kh.Text, TxtDia_Chi.Text, M_Ma_CT, M_Mode, AppConn, CyberSmlib, CyberSmodb)
    End Sub
#End Region
#Region "Valid --- Ma_NX"
    Private Sub V_Ma_NX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        txtMa_NX.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtMa_NX.Text = "" Then
            txtTen_NX.Text = ""
            V_GetTk_Thue_Co()
            Exit Sub
        End If
        DrReturn = txtMa_NX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtMa_NX.Text = DrReturn.Item("Tk")
            txtTen_NX.Text = DrReturn.Item("Ten_TK")
        End If
        If txtMa_NX.Text = "" Then
            txtTen_NX.Text = ""
            V_GetTk_Thue_Co()
            Exit Sub
        End If
        V_GetTk_Thue_Co()
        CyberSupport.V_SetSD(StatusFooter1, AppConn, "KT", M_Mode, txtMa_NX.Text, TxtMa_Kh.Text, "", "", M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid --- Ma_BP_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Bp_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Bp_H.Text = "" Then
            txtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp_H.Text = DrReturn.Item("Ma_BP")
            txtTen_BP_H.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Bp_H.Text = ""
            txtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HS_H"
    Private Sub V_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        txtMa_HS_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If txtMa_HS_H.Text = "" Then
            txtTen_HS_H.Text = ""
            Exit Sub
        End If
        DrReturn = txtMa_HS_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtMa_HS_H.Text = DrReturn.Item("Ma_HS")
            txtTen_HS_H.Text = DrReturn.Item("Ten_HS")
        Else
            txtMa_HS_H.Text = ""
            txtTen_HS_H.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Thue"
#Region "Valid --- Tk_Thue_no"
    Private Sub V_Tk_Thue_no(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk_Thue_No.ReadOnly Then Exit Sub
        TxtTk_Thue_No.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Thue_No(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk_Thue_No.Text = "" Then
            V_GetTk_Thue_No()
            Exit Sub
        End If
        DrReturn = TxtTk_Thue_No.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTk_Thue_No.Text = DrReturn.Item("Tk")
    End Sub
#End Region
#Region "Valid --- Tk_Thue_Co"
    Private Sub V_Tk_Thue_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTk_Thue_Co.ReadOnly Then Exit Sub
        TxtTk_Thue_Co.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Tk", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Thue_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = TxtTk_Thue_Co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTk_Thue_Co.Text = DrReturn.Item("Tk")
        V_GetTk_Thue_Co()
    End Sub
#End Region
    Private Sub L_Mau_BC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMau_BC.Text = "" Then
            TxtMau_BC.Text = M_Mau_BC
            Exit Sub
        End If
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMau_BC.Text, "Mau_BC", "DmMauVAT", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then
            TxtMau_BC.Text = M_Mau_BC
            Exit Sub
        Else
            TxtMau_BC.Text = DrReturn.Item("mau_Bc")
            Exit Sub
        End If
    End Sub
    Private Sub L_Ma_THue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Thue.Text = "" Then
            TxtThue_Suat.Double = 0
            TxtTk_Thue_No.Text = ""
            'TxtTk_Thue_Co.Text = ""
            V_GetSo_HD_GTGT()
            V_Tinh_Tien()
            UpdateList()
            Exit Sub
        End If
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Thue.Text, "ma_Thue", "Dmthue", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then
            TxtThue_Suat.Double = 0
            TxtTk_Thue_No.Text = ""
            'TxtTk_Thue_Co.Text = ""
            V_GetSo_HD_GTGT()
            V_Tinh_Tien()
            UpdateList()
            Exit Sub
        Else
            TxtThue_Suat.Double = DrReturn.Item("thue_Suat")
            TxtMa_Thue.Text = DrReturn.Item("ma_Thue")
            TxtTk_Thue_No.Text = DrReturn.Item("Tk_Thue_No")
            'TxtTk_Thue_Co.Text = DrReturn.Item("Tk_Thue_Co")
            V_GetSo_HD_GTGT()
            V_Tinh_Tien()
            UpdateList()
            Exit Sub
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
        If ChkSua_Thue.Checked Then
            V_GetVatInput()
            V_GetSo_HD_GTGT()
        End If
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_Sua_Thue_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_GetTk_Thue_Co()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_TkThue.Checked Or TxtTk_Thue_Co.Text.Trim = "" Then TxtTk_Thue_Co.Text = txtMa_NX.Text
    End Sub
    Private Sub V_GetTk_Thue_No()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSua_Thue.Checked Or TxtTk_Thue_No.Text.Trim = "" Then
            DrReturn = CyberSmodb.SQLGetRow(AppConn, "DmThue", "Ma_THue = N'" + TxtMa_Thue.Text.Trim + "'", CyberSmlib)
            If DrReturn Is Nothing Then Exit Sub
            TxtTk_Thue_No.Text = DrReturn.Item("Tk_Thue_No")
            TxtThue_Suat.Double = DrReturn.Item("Thue_Suat")
            UpdateList()
        End If
    End Sub
    Private Sub L_T_Thue_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub L_So_Hd_Gtgt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_GetSo_HD_GTGT()
        If ChkSua_Thue.Checked Then V_GetVatInput()
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_GetSo_HD_GTGT()
        If TxtMa_Thue.Text.ToUpper = "KT" Then
            TxtSo_Hd_Gtgt.Double = 0
            Exit Sub
        End If
        If ChkSua_Thue.Checked Then TxtSo_Hd_Gtgt.Double = Dv_DetailVatTmp.Count
        If TxtSo_Hd_Gtgt.Double <= 0 Then TxtSo_Hd_Gtgt.Double = 1
    End Sub
#Region "VAT"
    Private Sub V_GetVatInput()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _So_Ct As String = TxtSo_Ct.Text
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Ma_Dvcs As String = M_Ma_Dvcs.Trim
        Dim _DtVat As DataTable = Dt_DetailVatTmp.Copy
        Dim _Ty_Gia As Decimal = V_GetTyGia()
        Dim _Ma_NT As String = TxtMa_NT.Text.Trim
        V_AddVat(_DtVat, _Ma_Post, _Ngay_Ct, _Ngay_LCt, _Ma_NT, _Ty_Gia)
        Dim _DvVat As DataView = New DataView(_DtVat)
        Dim _ReturnVat As Boolean
        _ReturnVat = CyberVoucher.V_GetVatInput(AppConn, osysvar, M_LAN, M_Para, _Ma_NT, _Ty_Gia, M_Mode, M_Stt_Rec, M_Ma_CT, _Ngay_Ct, _Ngay_LCt, _Ma_Post, DrDmct, _Ma_Dvcs, M_User_Name, _DtVat, DsData, DsHead, DsLookup)
        If Not _ReturnVat Then Exit Sub
        V_AddVat(_DtVat, Dt_DetailVatTmp)

        UpdateTk_Thue_No()
        UpdateList()
    End Sub
    Private Sub V_AddVat(ByRef _DtVat As DataTable, ByVal _Ma_Post As String, ByVal _Ngay_Ct As Date, ByVal _Ngay_LCt As Date, ByVal _Ma_NT As String, ByVal _Ty_GIa As Decimal)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If _DtVat.Rows.Count > 0 Then Exit Sub

        Dim _Ma_KH As String = TxtMa_Kh.Text
        Dim _Ten_khVAT As String = TxtTen_KhVAT.Text
        Dim _Dia_ChiVAT As String = TxtDia_ChiVAT.Text
        Dim _Ma_So_Thue As String = TxtMa_So_Thue.Text

        Dim _So_Ct0 As String = TxtSo_Ct0.Text
        Dim _So_Seri0 As String = txtSo_Seri0.Text
        Dim _Ngay_Ct0 As Date = TxtNgay_Ct0.Value

        Dim _Dien_Giai As String = txtDien_giai.Text
        Dim _Ten_vtthue As String = TxtTen_vtthue.Text

        Dim _Tk_Thue_No As String = TxtTk_Thue_No.Text
        Dim _Tk_Du As String = TxtTk_Thue_Co.Text

        Dim nCountSo_Detail As Integer = Dt_DetailTmp.Rows.Count
        Dim nCountSo_Hd_Gtgt As Integer = TxtSo_Hd_Gtgt.Double
        Dim _ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim

        Dim _T_Tien_NT As Decimal = If(ChkSua_Thue_CP.Checked, TxtT_Tien_NT.Double, TxtT_Tien_NT0.Double)
        Dim _T_Tien As Decimal = If(ChkSua_Thue_CP.Checked, TxtT_Tien.Double, TxtT_Tien0.Double)

        If nCountSo_Detail = nCountSo_Hd_Gtgt And nCountSo_Hd_Gtgt > 1 Then
            For iRow As Integer = 0 To nCountSo_Detail - 1
                Dim _DrVat As DataRow
                _DrVat = _DtVat.NewRow
                CyberSmodb.SetValueBlankRow(_DrVat)
                CyberSmodb.AddValueToRow(_DrVat, Me)

                _DrVat.Item("Mau_BC") = TxtMau_BC.Text
                _DrVat.Item("Ma_Dvcs") = M_Ma_Dvcs
                _DrVat.Item("Ma_Ct") = M_Ma_CT.Trim
                _DrVat.Item("Stt_Rec") = M_Stt_Rec
                _DrVat.Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
                _DrVat.Item("Ma_Post") = _Ma_Post
                _DrVat.Item("Ma_NT") = _Ma_NT
                _DrVat.Item("Ty_Gia") = _Ty_GIa
                _DrVat.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
                _DrVat.Item("Ngay_Ct") = _Ngay_Ct

                _DrVat.Item("Ngay_Ct0") = _Ngay_Ct0
                _DrVat.Item("So_Ct0") = _So_Ct0
                _DrVat.Item("So_Seri0") = _So_Seri0

                _DrVat.Item("Ghi_Chu") = _Dien_Giai
                _DrVat.Item("Tk_Thue_No") = _Tk_Thue_No
                _DrVat.Item("Tk_Du") = _Tk_Du
                _DrVat.Item("Ma_Thue") = TxtMa_Thue.Text
                _DrVat.Item("Thue_Suat") = TxtThue_Suat.Double


                If ChkSua_Thue_CP.Checked Then
                    _T_Tien_NT = Dt_DetailTmp.Rows(iRow).Item("Tien_NT0") + Dt_DetailTmp.Rows(iRow).Item("CP_NT")
                    _T_Tien = Dt_DetailTmp.Rows(iRow).Item("Tien0") + Dt_DetailTmp.Rows(iRow).Item("CP")
                Else
                    _T_Tien_NT = Dt_DetailTmp.Rows(iRow).Item("Tien_NT0")
                    _T_Tien = Dt_DetailTmp.Rows(iRow).Item("Tien0")
                End If

                _DrVat.Item("Ma_kh") = _Ma_KH
                _DrVat.Item("Ghi_Chu") = _Dien_Giai
                _DrVat.Item("Ten_VT") = _Ten_vtthue

                _DrVat.Item("T_Tien_NT") = _T_Tien_NT
                _DrVat.Item("T_Tien") = _T_Tien
                _DrVat.Item("T_TT_NT") = _T_Tien_NT
                _DrVat.Item("T_TT") = _T_Tien

                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_Vv") = Dt_DetailTmp.Rows(iRow).Item("Ma_VV_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_HD") = Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_SP") = Dt_DetailTmp.Rows(iRow).Item("Ma_SP_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_Phi") = Dt_DetailTmp.Rows(iRow).Item("Ma_Phi_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_KU") = Dt_DetailTmp.Rows(iRow).Item("Ma_KU_I")

                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TTLN") = Dt_DetailTmp.Rows(iRow).Item("Ma_TTLN_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TTCP") = Dt_DetailTmp.Rows(iRow).Item("Ma_TTCP_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_CD") = Dt_DetailTmp.Rows(iRow).Item("Ma_CD_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_BP") = Dt_DetailTmp.Rows(iRow).Item("Ma_BP_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_HS") = Dt_DetailTmp.Rows(iRow).Item("Ma_HS_I")

                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD1") = Dt_DetailTmp.Rows(iRow).Item("Ma_TD1_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD2") = Dt_DetailTmp.Rows(iRow).Item("Ma_TD2_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD3") = Dt_DetailTmp.Rows(iRow).Item("Ma_TD3_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD4") = Dt_DetailTmp.Rows(iRow).Item("Ma_TD4_I")
                If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD5") = Dt_DetailTmp.Rows(iRow).Item("Ma_TD5_I")


                _DtVat.Rows.Add(_DrVat)

            Next
        Else
            Dim _DrVat As DataRow
            _DrVat = _DtVat.NewRow
            CyberSmodb.SetValueBlankRow(_DrVat)
            CyberSmodb.AddValueToRow(_DrVat, Me)
            _DrVat.Item("Mau_BC") = TxtMau_BC.Text
            _DrVat.Item("Ma_Dvcs") = M_Ma_Dvcs
            _DrVat.Item("Ma_Ct") = M_Ma_CT.Trim
            _DrVat.Item("Stt_Rec") = M_Stt_Rec
            _DrVat.Item("Stt_Rec0") = "0001"
            _DrVat.Item("Ma_Post") = _Ma_Post
            _DrVat.Item("Ma_NT") = _Ma_NT
            _DrVat.Item("Ty_Gia") = _Ty_GIa

            _DrVat.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            _DrVat.Item("Ngay_Ct") = _Ngay_Ct
            _DrVat.Item("Ngay_Ct0") = _Ngay_Ct0
            _DrVat.Item("So_Ct0") = _So_Ct0
            _DrVat.Item("So_Seri0") = _So_Seri0

            _DrVat.Item("Tk_Thue_No") = _Tk_Thue_No
            _DrVat.Item("Tk_Du") = _Tk_Du
            _DrVat.Item("Ma_Thue") = TxtMa_Thue.Text
            _DrVat.Item("Thue_Suat") = TxtThue_Suat.Double

            _DrVat.Item("Ma_kh") = _Ma_KH
            _DrVat.Item("Ghi_Chu") = _Dien_Giai
            _DrVat.Item("Ten_VT") = _Ten_vtthue

            _DrVat.Item("T_Tien_NT") = _T_Tien_NT
            _DrVat.Item("T_Tien") = _T_Tien
            _DrVat.Item("T_TT_NT") = _T_Tien_NT
            _DrVat.Item("T_TT") = _T_Tien

            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_Vv") = Dt_DetailTmp.Rows(0).Item("Ma_VV_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_HD") = Dt_DetailTmp.Rows(0).Item("Ma_HD_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_SP") = Dt_DetailTmp.Rows(0).Item("Ma_SP_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_Phi") = Dt_DetailTmp.Rows(0).Item("Ma_Phi_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_KU") = Dt_DetailTmp.Rows(0).Item("Ma_Ku_I")

            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TTLN") = Dt_DetailTmp.Rows(0).Item("Ma_TTLN_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TTCP") = Dt_DetailTmp.Rows(0).Item("Ma_TTCP_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_CD") = Dt_DetailTmp.Rows(0).Item("Ma_CD_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_BP") = Dt_DetailTmp.Rows(0).Item("Ma_BP_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_HS") = Dt_DetailTmp.Rows(0).Item("Ma_HS_I")

            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD1") = Dt_DetailTmp.Rows(0).Item("Ma_TD1_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD2") = Dt_DetailTmp.Rows(0).Item("Ma_TD2_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD3") = Dt_DetailTmp.Rows(0).Item("Ma_TD3_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD4") = Dt_DetailTmp.Rows(0).Item("Ma_TD4_I")
            If nCountSo_Detail > 0 Then _DrVat.Item("Ma_TD5") = Dt_DetailTmp.Rows(0).Item("Ma_TD5_I")

            _DtVat.Rows.Add(_DrVat)

        End If
        _DtVat.AcceptChanges()
    End Sub
    Private Sub V_AddVat(ByVal _DtVat As DataTable, ByVal _DtVatTmp As DataTable)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        For iRow As Integer = 0 To _DtVat.Rows.Count - 1
            _DtVat.Rows(iRow).BeginEdit()
            _DtVat.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text
            _DtVat.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            _DtVat.Rows(iRow).Item("Ma_CT") = M_Ma_CT
            _DtVat.Rows(iRow).Item("So_Ct") = TxtSo_Ct.Text
            _DtVat.Rows(iRow).Item("Ngay_CT") = _Ngay_CT
            _DtVat.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue
            _DtVat.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            _DtVat.Rows(iRow).EndEdit()
        Next
        CyberSmodb.DeleteDatatable(_DtVatTmp, "1=1")
        For iRow As Integer = 0 To _DtVat.Rows.Count - 1
            _DtVatTmp.ImportRow(_DtVat.Rows(iRow))
        Next
        _DtVatTmp.AcceptChanges()
    End Sub
    Private Sub UpdateTk_Thue_No()
        TxtSo_Hd_Gtgt.Double = Dt_DetailVatTmp.Rows.Count
        If Dt_DetailVatTmp.Rows.Count = 0 Then
            TxtTk_Thue_No.Text = ""
            Exit Sub
        End If
        If ChkSua_TkThue.Checked Then Exit Sub

        Dim _Tk_Thue_No As String = ""
        Dim _Chk As Boolean = False
        For iRow As Integer = 0 To Dt_DetailVatTmp.Rows.Count - 1
            If _Tk_Thue_No = "" Then _Tk_Thue_No = Dt_DetailVatTmp.Rows(iRow).Item("Tk_Thue_No").ToString.Trim
            If Dt_DetailVatTmp.Rows(iRow).Item("Tk_Thue_No").ToString.Trim.ToUpper = TxtTk_Thue_No.Text.Trim.ToUpper Then _Chk = True
        Next
        If Not _Chk And _Tk_Thue_No.Trim <> "" Then TxtTk_Thue_No.Text = _Tk_Thue_No
    End Sub
#End Region
#Region "Lenh/SO/Po/Ro/Vt"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_FormatSo_So(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_SO.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_FormatSo_PO(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_PO.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_RO.Text, CbbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_Vt.Text = CyberVoucher.V_FormatSo_VT(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_Vt.Text, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#End Region
#Region "Chi phi"
    Private Sub L_T_CP_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_Sua_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        '----Set ReadOnly lai cac Cot
        SetFoCusGRV()
        If ChkSua_CP.Checked Then
            TxtT_CP_NT.ReadOnly = False
            TxtT_CP_NT.Focus()
        Else
            TxtT_CP_NT.ReadOnly = True
        End If
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_PB_CP_SL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkPB_CP_SL.Checked = True Then ChkPB_CP_Tien.Checked = False Else ChkPB_CP_Tien.Checked = True
        V_Tinh_Tien()
        UpdateList()
    End Sub
    Private Sub V_PB_CP_Tien(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkPB_CP_Tien.Checked = True Then ChkPB_CP_SL.Checked = False Else ChkPB_CP_SL.Checked = True
        V_Tinh_Tien()
        UpdateList()
    End Sub
#End Region
#Region "Phan bo"
    Private Sub V_Phan_Bo_CP()
        If ChkSua_CP.Checked Then
            If ChkPB_CP_SL.Checked Then
                CyberSupport.Phan_Bo(Dt_DetailTmp, "So_luong", "CP_NT", TxtT_CP_NT.Double, M_R_TIEN_NT)
                CyberSupport.Phan_Bo(Dt_DetailTmp, "So_luong", "CP", TxtT_CP.Double, M_R_TIEN)
            Else
                CyberSupport.Phan_Bo(Dt_DetailTmp, "TIEN_NT0", "CP_NT", TxtT_CP_NT.Double, M_R_TIEN_NT)
                CyberSupport.Phan_Bo(Dt_DetailTmp, "TIEN_NT0", "CP", TxtT_CP.Double, M_R_TIEN)
            End If
        End If
    End Sub
    Private Sub V_Phan_Bo_Thue()
        CyberSupport.Phan_Bo(Dt_DetailTmp, "TIEN_NT", "Thue_Nt", TxtT_thue_NT.Double, M_R_TIEN_NT)
        CyberSupport.Phan_Bo(Dt_DetailTmp, "TIEN_NT", "Thue", TxtT_Thue.Double, M_R_TIEN)
    End Sub
    Private Sub V_Phan_Bo_Tien()
        V_Phan_Bo_CP()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_NT0") + Dv_DetailTmp.Item(iRow).Item("CP_NT")
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien0") + Dv_DetailTmp.Item(iRow).Item("CP")
            Dv_DetailTmp.Item(iRow).EndEdit()
        Next
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            If Dv_DetailTmp.Item(iRow).Item("So_Luong") <> 0 Then
                Dv_DetailTmp.Item(iRow).BeginEdit()
                Dv_DetailTmp.Item(iRow).Item("Gia_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_NT") / Dv_DetailTmp.Item(iRow).Item("So_Luong")
                Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Tien") / Dv_DetailTmp.Item(iRow).Item("So_Luong")
                Dv_DetailTmp.Item(iRow).EndEdit()
            End If

        Next
        '--------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Table.AcceptChanges()
        V_Phan_Bo_Thue()
    End Sub
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_TIEN_NT0 As Decimal = 0
        Dim nT_TIEN0 As Decimal = 0

        Dim nT_Tien_NT As Decimal = 0
        Dim nT_Tien As Decimal = 0

        Dim nT_CP_NT As Decimal = 0
        Dim nT_CP As Decimal = 0

        Dim nT_TT_NT As Decimal = 0
        Dim nT_TT As Decimal = 0
        Dim nT_So_Luong As Decimal = 0

        Dim nTy_Gia As Decimal = TxtTy_Gia.Double

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_TIEN_NT0 = nT_TIEN_NT0 + CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("TIEN_NT0"), M_R_TIEN_NT)
            nT_TIEN0 = nT_TIEN0 + CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("TIEN0"), M_R_TIEN)

            nT_CP_NT = nT_CP_NT + Dv_DetailTmp.Item(iRow).Item("CP_NT")
            nT_CP = nT_CP + Dv_DetailTmp.Item(iRow).Item("CP")

            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Next

        If ChkSua_CP.Checked Then
            If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.ToUpper = osysvar("M_MA_NT0").ToString.Trim.ToUpper Then
                TxtT_CP.Double = TxtT_CP_NT.Double
            Else
                TxtT_CP.Double = TxtT_CP_NT.Double * nTy_Gia
            End If
            nT_CP_NT = TxtT_CP_NT.Double
            nT_CP = TxtT_CP.Double
        End If

        TxtT_SO_LUONG.Double = nT_So_Luong
        nT_Tien_NT = nT_TIEN_NT0 + nT_CP_NT
        nT_Tien = nT_TIEN0 + nT_CP

        TxtT_Tien_NT0.Double = nT_TIEN_NT0
        TxtT_Tien0.Double = nT_TIEN0

        TxtT_CP_NT.Double = nT_CP_NT
        TxtT_CP.Double = nT_CP

        TxtT_Tien_NT.Double = nT_Tien_NT
        TxtT_Tien.Double = nT_Tien

        '----------------------------------------------------------------------
        Dim nT_Thue_NT As Decimal = TxtT_thue_NT.Double
        Dim nT_Thue As Decimal = TxtT_Thue.Double

        nT_TT_NT = CyberSupport.V_Round(nT_Tien_NT + nT_Thue_NT, M_R_TIEN_NT)
        nT_TT = CyberSupport.V_Round(nT_Tien + nT_Thue, M_R_TIEN_NT)
        TxtT_TT_NT.Double = nT_TT_NT
        TxtT_TT.Double = nT_TT

    End Sub
    Private Sub V_Tinh_Tien()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim nTy_Gia As Decimal = TxtTy_Gia.Double
        Dim nThue_Suat As Decimal = TxtThue_Suat.Double
        Dim nTien_Hang As Decimal = 0
        Dim nTien_Hang_NT As Decimal = 0
        Dim nT_Thue_Nt As Decimal = 0
        Dim nT_Thue As Decimal = 0
        '--------------------------------Tinh 
        If ChkSua_CP.Checked Then TxtT_CP.Double = TxtT_CP_NT.Double * nTy_Gia
        V_Phan_Bo_CP()
        '--------------------------------Tinh Thue
        If Not ChkSua_Thue.Checked Then
            nTien_Hang_NT = TxtT_Tien_NT0.Double
            nTien_Hang = TxtT_Tien0.Double
            If ChkSua_Thue_CP.Checked Then nTien_Hang_NT = nTien_Hang_NT + TxtT_CP_NT.Text
            If ChkSua_Thue_CP.Checked Then nTien_Hang = nTien_Hang + TxtT_CP.Text

            nT_Thue_Nt = nTien_Hang_NT * nThue_Suat / 100
            nT_Thue = nTien_Hang * nThue_Suat / 100
            TxtT_thue_NT.Double = nT_Thue_Nt
            TxtT_Thue.Double = nT_Thue
        Else
            nT_Thue_Nt = 0
            nT_Thue = 0
            For i As Integer = 0 To Dt_DetailVaTTmp.Rows.Count - 1
                nT_Thue_Nt = nT_Thue_Nt + Dt_DetailVaTTmp.Rows(i).Item("T_Thue_NT")
                nT_Thue = nT_Thue + Dt_DetailVaTTmp.Rows(i).Item("T_Thue")
            Next
            TxtT_thue_NT.Double = nT_Thue_Nt
            TxtT_Thue.Double = nT_Thue
        End If
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        Dim _tien_sua_tay = Dv_DetailTmp.Item(iRow).Item("TIEN_NT0")
        '--------------------------------------------------------------------------------
        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT0") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            'hieulv cho phep sua thanh tien chenh lech 10 đồng
            If Math.Abs(_tien_sua_tay - Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT0")) > 10 Then
                Dv_DetailTmp.Item(iRow).Item("TIEN_NT0") = Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT0")
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '--------------------------------------------------------------------------------
        '----------------VND
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If nTy_Gia = 1 Then
            Dv_DetailTmp.Item(iRow).Item("TIEN0") = Dv_DetailTmp.Item(iRow).Item("TIEN_NT0")
            Dv_DetailTmp.Item(iRow).Item("Gia0") = Dv_DetailTmp.Item(iRow).Item("Gia_NT0")
            Dv_DetailTmp.Item(iRow).Item("CP") = Dv_DetailTmp.Item(iRow).Item("CP_NT")
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_NT")
        Else
            Dv_DetailTmp.Item(iRow).Item("TIEN0") = Dv_DetailTmp.Item(iRow).Item("TIEN_NT0") * nTy_Gia
            Dv_DetailTmp.Item(iRow).Item("Gia0") = Dv_DetailTmp.Item(iRow).Item("Gia_NT0") * nTy_Gia
            Dv_DetailTmp.Item(iRow).Item("CP") = Dv_DetailTmp.Item(iRow).Item("CP_NT") * nTy_Gia
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_NT") * nTy_Gia
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tien_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_NT0") + Dv_DetailTmp.Item(iRow).Item("CP_NT")
        Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien0") + Dv_DetailTmp.Item(iRow).Item("CP")
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRV)
        V_Tinh_Toan(iRow)
        V_Tinh_Tien()
    End Sub
    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = txtDien_giai.Text
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
        Dim _Ma_kho As String = DrReturn.Item("Ma_kho")
        Dim _Ma_Vitri As String = DrReturn.Item("Ma_Vitri")

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tk_VT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim = "", _TK_VT, Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I").ToString.Trim = "", _Ma_kho, Dv_DetailTmp.Item(iRow).Item("Ma_KHo_I").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim = "", _Ma_Vitri, Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim)
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPricePurChase(iRow)
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
        V_SetPricePurChase(iRow)
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
        Dim _Ma_Vitri As String = If(Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri"), Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim, "")
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
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
    Private Sub V_SetPricePurChase(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim
        Dim _ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _So_Luong As Decimal = Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Dim _Gia_NT As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_NT0")
        Dim _Tien_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Tien_NT0")
        Dim _Ma_kh As String = TxtMa_Kh.Text
        Dim _ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPricePurchase", _ma_Vt.Trim + "#" + _ma_Kho.Trim + "#" + _Ma_kh + "#" + _
        _ngay_Ct.ToString("yyyyMMdd") + "#" + _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_NT.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt.ToString.Trim.Replace(",", ".") + "#" + _
         M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If

        Dim _DtGia As DataTable = DsgetPrice.Tables(0)
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If _DtGia.Columns.Contains("So_Luong") Then Dv_DetailTmp.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
        If _DtGia.Columns.Contains("Gia_NT0") Then Dv_DetailTmp.Item(iRow).Item("Gia_NT0") = _DtGia.Rows(0).Item("Gia_NT0")
        If _DtGia.Columns.Contains("Tien_Nt0") Then Dv_DetailTmp.Item(iRow).Item("Tien_Nt0") = _DtGia.Rows(0).Item("Tien_Nt0")
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        DsgetPrice.Dispose()
        V_Tinh_Toan(iRow)
    End Sub
#End Region
#Region "Tai khoan "
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_So(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_PO(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_Ro(Dv_DetailTmp, iRow, AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_Ct, CbbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_VT(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CbbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
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
    Private Sub V_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        UpdateList()
        Dv_DetailTmp.Table.AcceptChanges()
        VisibleColumnMa_NT()
        V_Tinh_Tien()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        UpdateList()
        Dv_DetailTmp.Table.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRV)
        DetailGRV.RefreshData()
        V_Tinh_Tien()
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
        Dv_DetailVaTTmp.Table.AcceptChanges()
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
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailVaTTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        V_Sua_CP(sender, e)
        V_PB_CP_SL(sender, e)
        V_PB_CP_Tien(sender, e)
        V_Phan_Bo_Tien()
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
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailVaTTmp}, {M_Ct, M_Ph, "CTGT30"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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

        '---Update VAT
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailVaTTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---------------------------------------------------
        '---Xoa trong DetailVat
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailVat, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailVat.Load(Dt_DetailVaTTmp.CreateDataReader)

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
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailVaTTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        V_Sua_CP(sender, e)
        V_PB_CP_SL(sender, e)
        V_PB_CP_Tien(sender, e)

        '----------------------------------------------------------------------------------------------------------------------
        V_Phan_Bo_Tien()
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,TEN_KH", "TEN_VT,TEN_KHO_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
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
            If Dt_DetailTmp.Rows(iRow).Item("Ma_VT").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("Tk_Thue_I") = TxtTk_Thue_No.Text
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            If TxtMa_Bp_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Bp_I") = TxtMa_Bp_H.Text.Trim
            If txtMa_HS_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HS_I") = txtMa_HS_H.Text.Trim
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next

        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        '-----VAT
        V_CreateVAT()
        For iRow = 0 To Dt_DetailVatTmp.Rows.Count - 1
            Dt_DetailVatTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailVatTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailVatTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailVatTmp.Columns.Contains("Ngay_LCt") Then Dt_DetailVatTmp.Rows(iRow).Item("Ngay_LCt") = TxtNgay_LCt.Value
            Dt_DetailVatTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailVatTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailVatTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString
            Dt_DetailVatTmp.Rows(iRow).Item("Ma_CT") = M_Ma_CT
            Dt_DetailVatTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text
            Dt_DetailVatTmp.Rows(iRow).Item("Tk_Du") = TxtTk_Thue_Co.Text
            If Dt_DetailVaTTmp.Rows(iRow).Item("Tk_Thue_no").ToString.Trim = "" Then Dt_DetailVaTTmp.Rows(iRow).Item("Tk_Thue_no") = TxtTk_Thue_No.Text
            If Dt_DetailVaTTmp.Columns.Contains("NonVAT") Then Dt_DetailVaTTmp.Rows(iRow).Item("NonVAT") = IIf(ChkNonVAT.Checked, "1", "0")
        Next
        UpdateTk_Thue_No()
        '-----

        UpdateList()
        ChkVsave = True
    End Function
    Private Sub V_CreateVAT()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkSua_Thue.Checked Then Exit Sub
        Dim nCountSo_Detail As Integer = Dv_DetailTmp.Count
        Dt_DetailVatTmp.Clear()
        '---Add 1 Ban ghi
        Dim drMaster As DataRow
        drMaster = Dt_DetailVatTmp.NewRow
        CyberSmodb.SetValueBlankRow(drMaster)
        CyberSmodb.AddValueToRow(drMaster, Me)
        drMaster.Item("Stt_Rec") = M_Stt_Rec
        drMaster.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        drMaster.Item("Stt_Rec0") = "0001"
        drMaster.Item("Ten_Vt") = TxtTen_vtthue.Text
        drMaster.Item("Tk_Du") = TxtTk_Thue_Co.Text
        drMaster.Item("Ghi_Chu") = txtDien_giai.Text
        drMaster.Item("Mau_BC") = TxtMau_BC.Text
        drMaster.Item("Ma_Thue") = TxtMa_Thue.Text
        drMaster.Item("Thue_Suat") = TxtThue_Suat.Double


        If TxtTen_KhVAT.Text.Trim <> "" Then drMaster.Item("ten_kh") = TxtTen_KhVAT.Text
        If TxtDia_ChiVAT.Text.Trim <> "" Then drMaster.Item("Dia_Chi") = TxtDia_ChiVAT.Text

        drMaster.Item("T_Thue_NT") = TxtT_thue_NT.Double
        drMaster.Item("T_Thue") = TxtT_Thue.Double
        If ChkSua_Thue_CP.Checked Then

            drMaster.Item("T_Tien_NT") = TxtT_Tien_NT.Double
            drMaster.Item("T_Tien") = TxtT_Tien.Double

        Else
            drMaster.Item("T_Tien_NT") = TxtT_Tien_NT0.Double
            drMaster.Item("T_Tien") = TxtT_Tien0.Double
        End If
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '----------------------------------------------------------------------------
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_Vv") = Dt_DetailTmp.Rows(0).Item("Ma_VV_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_HD") = Dt_DetailTmp.Rows(0).Item("Ma_HD_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_SP") = Dt_DetailTmp.Rows(0).Item("Ma_SP_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_Phi") = Dt_DetailTmp.Rows(0).Item("Ma_Phi_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_KU") = Dt_DetailTmp.Rows(0).Item("Ma_Ku_I")

        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TTLN") = Dt_DetailTmp.Rows(0).Item("Ma_TTLN_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TTCP") = Dt_DetailTmp.Rows(0).Item("Ma_TTCP_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_CD") = Dt_DetailTmp.Rows(0).Item("Ma_CD_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_BP") = Dt_DetailTmp.Rows(0).Item("Ma_BP_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_HS") = Dt_DetailTmp.Rows(0).Item("Ma_HS_I")

        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TD1") = Dt_DetailTmp.Rows(0).Item("Ma_TD1_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TD2") = Dt_DetailTmp.Rows(0).Item("Ma_TD2_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TD3") = Dt_DetailTmp.Rows(0).Item("Ma_TD3_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TD4") = Dt_DetailTmp.Rows(0).Item("Ma_TD4_I")
        If nCountSo_Detail > 0 Then drMaster.Item("Ma_TD5") = Dt_DetailTmp.Rows(0).Item("Ma_TD5_I")
        '----------------------------------------------------------------------------
        Dt_DetailVatTmp.Rows.Add(drMaster)
        Dt_DetailVatTmp.AcceptChanges()
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
        '---Xoa trong DetailVat
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailVat, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailVaTTmp.Rows.Count - 1
            Dt_DetailVat.ImportRow(Dt_DetailVaTTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailVaTTmp}, {M_Ct, M_Ph, "CTGT30"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailVaTTmp, "CTGT30", M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
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
        If txtDien_giai.Text.Trim = "" Then txtDien_giai.Text = M_Dien_Giai
        If TxtMau_BC.Text.Trim = "" Then TxtMau_BC.Text = M_Mau_BC
        If txtMa_NX.Text.Trim = "" Then
            txtMa_NX.Text = M_Tk_Co
            txtTen_NX.Text = M_Ten_Tk_Co
        End If
        '--------------
        V_New()
        '--------------
        ChkSua_CP.Checked = True
        ChkPB_CP_SL.Checked = False
        ChkPB_CP_Tien.Checked = True
        ChkSua_Thue_CP.Checked = True
        '--------------
        TxtNgay_Ct0.Value = Now.Date
        If TxtMa_Thue.Text = "" Then TxtMa_Thue.Text = M_Ma_THue
        V_GetTk_Thue_No()
        V_GetTk_Thue_Co()
        TxtSo_Hd_Gtgt.Double = 1
        '--------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")

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
            TxtTk_Thue_No.Text = 1331
            TxtMa_Thue.Text = 10
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
        CyberSupport.V_DeleteTableVoucher(Dt_DetailVat, M_Stt_Rec)

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
        TxtT_SO_LUONG.ReadOnly = True

        TxtT_Tien_NT.ReadOnly = True
        TxtT_Tien.ReadOnly = True

        TxtThue_Suat.ReadOnly = True

        TxtT_Tien_NT0.ReadOnly = True
        TxtT_Tien0.ReadOnly = True

        TxtT_thue_NT.ReadOnly = True
        TxtT_Thue.ReadOnly = True

        TxtT_TT_NT.ReadOnly = True
        TxtT_TT.ReadOnly = True

        TxtTen_kh.ReadOnly = True
        txtTen_BP_H.ReadOnly = True
        txtTen_HS_H.ReadOnly = True
        txtTen_NX.ReadOnly = True

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

    Dim M_Ma_HS_H As String = ""
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

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
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


