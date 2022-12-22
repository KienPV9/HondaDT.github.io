Imports System.Data.SqlClient
Public Class PPK
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
#End Region
#Region "Khai bao bien Paramater----------------------"
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"    
    Dim EditMa_TT, EditMa_PK, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_Phi_i, EditMa_HD_I, EditMa_SP_I, EditMa_Ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim Editma_Db_I, EditMa_Xe_I, EditMa_KX_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Lo, EditTen_PK, EditTen_Kho_I, EditDvt, EditSo_Luong, EditPT_CK, EditCK, EditT_TT_NT, EditT_TT, EditIs_KM, EditIs_Them, EditGia_Nt, EditGia, EditTien_Nt, EditTien, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView
    '------------------------------------    
    Dim EditBHMa_TT, EditBHTy_Le, EditBHTy_Le_CS, EditBHMa_BH, EditBHMa_LHBH, EditBHMa_Vitri, EditBHMa_Vv_I, EditBHMa_Phi_i, EditBHMa_HD_I, EditBHMa_SP_I, EditBHMa_Ku_I, EditBHMa_TTLN_i, EditBHMa_TTCP_i, EditBHMa_BP_I, EditBHMa_HS_I, EditBHMa_CD_I, EditBHMa_TD1_I, EditBHMa_TD2_I, EditBHMa_TD3_I, EditBHMa_TD4_I, EditBHMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditBHma_Db_I, EditBHMa_Xe_I, EditBHMa_KX_I, EditBHMa_Tuyen_I, EditBHMa_Ts, EditBHMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditBHMa_Lo, EditBHTen_BH, EditBHTen_LHBH, EditBHDvt, EditBHSo_Luong, EditBHPT_CK, EditBHCK, EditBHT_TT_NT, EditBHT_TT, EditBHIs_KM, EditBHIs_Them, EditBHGia_Nt, EditBHGia, EditBHTien_Nt, EditBHTien, EditBHDien_Giaii, EditBHSo_So, EditBHSo_Po, EditBHSo_Ro, EditBHSo_VT As New Cyber.Fill.CyberColumnGridView
    '------------------------------------    
    Dim EditKhacMa_TT, EditKhacMa_BH, EditKhacMa_LHBH, EditKhacMa_Vitri, EditKhacMa_Vv_I, EditKhacMa_Phi_i, EditKhacMa_HD_I, EditKhacMa_SP_I, EditKhacMa_Ku_I, EditKhacMa_TTLN_i, EditKhacMa_TTCP_i, EditKhacMa_BP_I, EditKhacMa_HS_I, EditKhacMa_CD_I, EditKhacMa_TD1_I, EditKhacMa_TD2_I, EditKhacMa_TD3_I, EditKhacMa_TD4_I, EditKhacMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditKhacma_Db_I, EditKhacMa_Xe_I, EditKhacMa_KX_I, EditKhacMa_Tuyen_I, EditKhacMa_Ts, EditKhacMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditKhacMa_DvKhac, EditKhacTen_DvKhac, EditKhacMa_Lo, EditKhacTen_BH, EditKhacTen_LHBH, EditKhacDvt, EditKhacSo_Luong, EditKhacPT_CK, EditKhacCK, EditKhacT_TT_NT, EditKhacT_TT, EditKhacIs_KM, EditKhacIs_Them, EditKhacGia_Nt, EditKhacGia, EditKhacTien_Nt, EditKhacTien, EditKhacDien_Giaii, EditKhacSo_So, EditKhacSo_Po, EditKhacSo_Ro, EditKhacSo_VT As New Cyber.Fill.CyberColumnGridView
    '------------------------------------
    Dim Dt_DetailBH, Dt_DetailtmpBH As New DataTable
    Dim Dv_DetailBH, Dv_DetailtmpBH As New DataView

    Dim Dt_DetailKhac, Dt_DetailtmpKhac As New DataTable
    Dim Dv_DetailKhac, Dv_DetailtmpKhac As New DataView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable

    Dim _Para_Ma_HD_H As String = ""
#End Region
    Private Sub PPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        V_MainSystemBH()
        V_MainSystemKHAC()
        GetRound()
        CmdNew.Select()
        V_LoadNew(sender, e)
    End Sub
#Region "Load And Set And Default"
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_Ma_HD_H.Trim = "" Then Exit Sub
        Dim nCount As Integer = 0
        Dim irow As Integer = -1
        Dim dtMasterRf, dtDetailRf, dtDetailBhRf, dtDetailKhacRf As DataTable

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultPPK", _Para_Ma_HD_H.ToString.Trim & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(1).Rows.Count = 1 Then

            M_Stt_Rec = DsTmp.Tables(1).Rows(0).Item("Stt_Rec")
            dtMasterRf = DsTmp.Tables(1)
            dtDetailRf = DsTmp.Tables(0)
            dtDetailBhRf = DsTmp.Tables(2)
            dtDetailKhacRf = DsTmp.Tables(3)
            '-------------------------------------
            nCount = Dt_Master.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_Master.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_Master.Rows(irow).Delete()
                    Dt_Master.AcceptChanges()
                End If
            Next
            nCount = Dt_Detail.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_Detail.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_Detail.Rows(irow).Delete()
                    Dt_Detail.AcceptChanges()
                End If
            Next
            nCount = Dt_DetailBH.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_DetailBH.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_DetailBH.Rows(irow).Delete()
                    Dt_DetailBH.AcceptChanges()
                End If
            Next
            nCount = Dt_DetailKhac.Rows.Count
            For irow = nCount - 1 To 0 Step -1
                If Dt_DetailKhac.Rows(irow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                    Dt_DetailKhac.Rows(irow).Delete()
                    Dt_DetailKhac.AcceptChanges()
                End If
            Next
            '-------------------------------------
            For irow = 0 To dtMasterRf.Rows.Count - 1
                Dt_Master.ImportRow(dtMasterRf.Rows(irow))
            Next
            For irow = 0 To dtDetailRf.Rows.Count - 1
                Dt_Detail.ImportRow(dtDetailRf.Rows(irow))
            Next
            For irow = 0 To dtDetailBhRf.Rows.Count - 1
                Dt_DetailBH.ImportRow(dtDetailBhRf.Rows(irow))
            Next
            For irow = 0 To dtDetailKhacRf.Rows.Count - 1
                Dt_DetailKhac.ImportRow(dtDetailKhacRf.Rows(irow))
            Next
            V_Databing()
            V_Edit(sender, e)
        Else
            V_New(sender, e)
            V_GetMaBP()
            If Not M_Mode = "M" Then Exit Sub
            If _Para_Ma_HD_H.Trim <> "" Then
                TxtMa_HD_H.Text = _Para_Ma_HD_H
                V_GetMa_HD_H(_Para_Ma_HD_H)
                Return
            End If
        End If
    End Sub
    Private Sub V_Load()
        V_Getdefault()
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)

        Dt_DetailBH = M_DsData.Tables(2)
        Dt_DetailtmpBH = Dt_DetailBH.Clone

        Dt_DetailKhac = M_DsData.Tables(3)
        Dt_DetailtmpKhac = Dt_DetailKhac.Clone

        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)

        Dv_DetailBH = New DataView(Dt_DetailBH)
        Dv_DetailtmpBH = New DataView(Dt_DetailtmpBH)

        Dv_DetailKhac = New DataView(Dt_DetailKhac)
        Dv_DetailtmpKhac = New DataView(Dt_DetailtmpKhac)

        Dv_Master = New DataView(Dt_Master)

        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)

        DetailBH.DataSource = Dv_DetailtmpBH
        Me.DetailBHGRV.GridControl = Me.DetailBH
        CyberFill.V_FillVoucher(DetailBHGRV, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailtmpBH, Me.DrDmct)

        DetailKhac.DataSource = Dv_DetailtmpKhac
        Me.DetailKhacGRV.GridControl = Me.DetailKhac
        CyberFill.V_FillVoucher(DetailKhacGRV, M_LAN, New DataView(M_DsHead.Tables(3)), Dv_DetailtmpKhac, Me.DrDmct)

        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)

        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)

        TxtT_So_Luong.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_So_Luong.InputMask)
        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_Tien.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien").ToString.Trim, TxtT_Tien.InputMask)

        TxtT_CK.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_CK.InputMask)
        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_TT_NT.InputMask)

        TxtT_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_BB.InputMask)
        TxtT_Mua_Them.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Mua_Them.InputMask)
        TxtT_KM.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_KM.InputMask)
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
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '--------------------------------------------------------------------------------------------
        _Para_Ma_HD_H = ""
        Try
            _Para_Ma_HD_H = M_Para(M_VT_PARA + 3).Trim
        Catch ex As Exception

        End Try
        '---------------------------------------------------------------------------------------------'

        'M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        M_Ma_Post = "3"
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

        '---
        If FixCol < DetailBHGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailBHGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

        DetailBHGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailBHGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

        '---
        If FixCol < DetailKhacGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailKhacGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

        DetailKhacGRV.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailKhacGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        EditMa_Lo.GetColumn(DetailGRV, "Ma_Lo")
        EditMa_PK.GetColumn(DetailGRV, "Ma_PK")
        EditMa_TT.GetColumn(Me.DetailGRV, "Ma_TT")

        EditTen_PK.GetColumn(DetailGRV, "Ten_PK")
        EditDvt.GetColumn(DetailGRV, "DVT")
        EditMa_Vitri.GetColumn(DetailGRV, "Ma_Vitri")

        EditMa_Kho_I.GetColumn(DetailGRV, "Ma_Kho_I")
        EditTen_Kho_I.GetColumn(DetailGRV, "Ten_Kho_I")

        EditDien_Giaii.GetColumn(DetailGRV, "Dien_Giai")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditGia_Nt.GetColumn(DetailGRV, "Gia_Nt")
        EditGia.GetColumn(DetailGRV, "Gia")
        EditTien_Nt.GetColumn(DetailGRV, "Tien_Nt")
        EditTien.GetColumn(DetailGRV, "Tien")

        EditPT_CK.GetColumn(DetailGRV, "PT_CK")
        EditCK.GetColumn(DetailGRV, "CK")
        EditT_TT_NT.GetColumn(DetailGRV, "T_TT_NT")
        EditT_TT.GetColumn(DetailGRV, "T_TT")
        EditIs_KM.GetColumn(DetailGRV, "Is_KM")
        EditIs_Them.GetColumn(DetailGRV, "Is_Them")

        EditMa_Vv_I.GetColumn(DetailGRV, "Ma_Vv_I")
        EditMa_Phi_i.GetColumn(DetailGRV, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRV, "Ma_HD_I")
        EditMa_SP_I.GetColumn(DetailGRV, "Ma_SP_I")
        EditMa_Ku_I.GetColumn(DetailGRV, "Ma_Ku_I")
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
        EditMa_Xe_I.GetColumn(DetailGRV, "Ma_Xe_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_Tuyen_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")
        ''---------------------------------------------------------------------------------------------
        EditBHMa_Lo.GetColumn(DetailBHGRV, "Ma_Lo")
        EditBHMa_BH.GetColumn(DetailBHGRV, "Ma_BH")
        EditBHMa_LHBH.GetColumn(DetailBHGRV, "Ma_LHBH")
        EditBHMa_TT.GetColumn(Me.DetailBHGRV, "Ma_TT")
        EditBHTy_Le.GetColumn(Me.DetailBHGRV, "Ty_Le")
        EditBHTy_Le_CS.GetColumn(Me.DetailBHGRV, "Ty_Le_CS")


        EditBHTen_BH.GetColumn(DetailBHGRV, "Ten_BH")
        EditBHTen_LHBH.GetColumn(DetailBHGRV, "Ten_LHBH")
        EditBHDvt.GetColumn(DetailBHGRV, "DVT")
        EditBHMa_Vitri.GetColumn(DetailBHGRV, "Ma_Vitri")

        EditBHDien_Giaii.GetColumn(DetailBHGRV, "Dien_Giaii")

        EditBHSo_Luong.GetColumn(DetailBHGRV, "So_Luong")
        EditBHGia_Nt.GetColumn(DetailBHGRV, "Gia_Nt")
        EditBHGia.GetColumn(DetailBHGRV, "Gia")
        EditBHTien_Nt.GetColumn(DetailBHGRV, "Tien_Nt")
        EditBHTien.GetColumn(DetailBHGRV, "Tien")

        EditBHPT_CK.GetColumn(DetailBHGRV, "PT_CK")
        EditBHCK.GetColumn(DetailBHGRV, "CK")
        EditBHT_TT_NT.GetColumn(DetailBHGRV, "T_TT_NT")
        EditBHT_TT.GetColumn(DetailBHGRV, "T_TT")
        EditBHIs_KM.GetColumn(DetailBHGRV, "Is_KM")
        EditBHIs_Them.GetColumn(DetailBHGRV, "Is_Them")

        EditBHMa_Vv_I.GetColumn(DetailBHGRV, "Ma_Vv_I")
        EditBHMa_Phi_i.GetColumn(DetailBHGRV, "Ma_Phi_I")
        EditBHMa_HD_I.GetColumn(DetailBHGRV, "Ma_HD_I")
        EditBHMa_SP_I.GetColumn(DetailBHGRV, "Ma_SP_I")
        EditBHMa_Ku_I.GetColumn(DetailBHGRV, "Ma_Ku_I")
        EditBHMa_TTLN_i.GetColumn(DetailBHGRV, "Ma_TTLN_I")
        EditBHMa_TTCP_i.GetColumn(DetailBHGRV, "Ma_TTCP_I")
        EditBHMa_BP_I.GetColumn(DetailBHGRV, "Ma_BP_I")
        EditBHMa_HS_I.GetColumn(DetailBHGRV, "Ma_Hs_I")
        EditBHMa_CD_I.GetColumn(DetailBHGRV, "Ma_CD_I")

        EditBHMa_TD1_I.GetColumn(DetailBHGRV, "Ma_TD1_I")
        EditBHMa_TD2_I.GetColumn(DetailBHGRV, "Ma_TD2_I")
        EditBHMa_TD3_I.GetColumn(DetailBHGRV, "Ma_TD3_I")
        EditBHMa_TD4_I.GetColumn(DetailBHGRV, "Ma_TD4_I")
        EditBHMa_TD5_I.GetColumn(DetailBHGRV, "Ma_TD5_I")

        EditBHSo_So.GetColumn(DetailBHGRV, "SO_SO")
        EditBHSo_Po.GetColumn(DetailBHGRV, "SO_PO")
        EditBHSo_Ro.GetColumn(DetailBHGRV, "SO_RO")
        EditBHSo_VT.GetColumn(DetailBHGRV, "SO_VT")

        EditBHma_Db_I.GetColumn(DetailBHGRV, "Ma_Db_I")
        EditBHMa_Xe_I.GetColumn(DetailBHGRV, "Ma_Xe_I")
        EditBHMa_Tuyen_I.GetColumn(DetailBHGRV, "Ma_TUYEN_I")
        EditBHMa_Ts.GetColumn(DetailBHGRV, "Ma_Ts")
        EditBHMa_Cc.GetColumn(DetailBHGRV, "Ma_Cc")
        ''---------------------------------------------------------------------------------------------

        EditKhacMa_Lo.GetColumn(DetailKhacGRV, "Ma_Lo")
        EditKhacMa_BH.GetColumn(DetailKhacGRV, "Ma_BH")
        EditKhacMa_LHBH.GetColumn(DetailKhacGRV, "Ma_LHBH")
        EditKhacMa_TT.GetColumn(Me.DetailKhacGRV, "Ma_TT")

        '
        EditKhacMa_DvKhac.GetColumn(Me.DetailKhacGRV, "Ma_DvKhac")
        EditKhacTen_DvKhac.GetColumn(Me.DetailKhacGRV, "Ten_DvKhac")

        EditKhacTen_BH.GetColumn(DetailKhacGRV, "Ten_BH")
        EditKhacTen_LHBH.GetColumn(DetailKhacGRV, "Ten_LHBH")
        EditKhacDvt.GetColumn(DetailKhacGRV, "DVT")
        EditKhacMa_Vitri.GetColumn(DetailKhacGRV, "Ma_Vitri")

        EditKhacDien_Giaii.GetColumn(DetailKhacGRV, "Dien_Giaii")

        EditKhacSo_Luong.GetColumn(DetailKhacGRV, "So_Luong")
        EditKhacGia_Nt.GetColumn(DetailKhacGRV, "Gia_Nt")
        EditKhacGia.GetColumn(DetailKhacGRV, "Gia")
        EditKhacTien_Nt.GetColumn(DetailKhacGRV, "Tien_Nt")
        EditKhacTien.GetColumn(DetailKhacGRV, "Tien")

        EditKhacPT_CK.GetColumn(DetailKhacGRV, "PT_CK")
        EditKhacCK.GetColumn(DetailKhacGRV, "CK")
        EditKhacT_TT_NT.GetColumn(DetailKhacGRV, "T_TT_NT")
        EditKhacT_TT.GetColumn(DetailKhacGRV, "T_TT")
        EditKhacIs_KM.GetColumn(DetailKhacGRV, "Is_KM")
        EditKhacIs_Them.GetColumn(DetailKhacGRV, "Is_Them")

        EditKhacMa_Vv_I.GetColumn(DetailKhacGRV, "Ma_Vv_I")
        EditKhacMa_Phi_i.GetColumn(DetailKhacGRV, "Ma_Phi_I")
        EditKhacMa_HD_I.GetColumn(DetailKhacGRV, "Ma_HD_I")
        EditKhacMa_SP_I.GetColumn(DetailKhacGRV, "Ma_SP_I")
        EditKhacMa_Ku_I.GetColumn(DetailKhacGRV, "Ma_Ku_I")
        EditKhacMa_TTLN_i.GetColumn(DetailKhacGRV, "Ma_TTLN_I")
        EditKhacMa_TTCP_i.GetColumn(DetailKhacGRV, "Ma_TTCP_I")
        EditKhacMa_BP_I.GetColumn(DetailKhacGRV, "Ma_BP_I")
        EditKhacMa_HS_I.GetColumn(DetailKhacGRV, "Ma_Hs_I")
        EditKhacMa_CD_I.GetColumn(DetailKhacGRV, "Ma_CD_I")

        EditKhacMa_TD1_I.GetColumn(DetailKhacGRV, "Ma_TD1_I")
        EditKhacMa_TD2_I.GetColumn(DetailKhacGRV, "Ma_TD2_I")
        EditKhacMa_TD3_I.GetColumn(DetailKhacGRV, "Ma_TD3_I")
        EditKhacMa_TD4_I.GetColumn(DetailKhacGRV, "Ma_TD4_I")
        EditKhacMa_TD5_I.GetColumn(DetailKhacGRV, "Ma_TD5_I")

        EditKhacSo_So.GetColumn(DetailKhacGRV, "SO_SO")
        EditKhacSo_Po.GetColumn(DetailKhacGRV, "SO_PO")
        EditKhacSo_Ro.GetColumn(DetailKhacGRV, "SO_RO")
        EditKhacSo_VT.GetColumn(DetailKhacGRV, "SO_VT")

        EditKhacma_Db_I.GetColumn(DetailKhacGRV, "Ma_Db_I")
        EditKhacMa_Xe_I.GetColumn(DetailKhacGRV, "Ma_Xe_I")
        EditKhacMa_Tuyen_I.GetColumn(DetailKhacGRV, "Ma_TUYEN_I")
        EditKhacMa_Ts.GetColumn(DetailKhacGRV, "Ma_Ts")
        EditKhacMa_Cc.GetColumn(DetailKhacGRV, "Ma_Cc")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_HD_H.Focus()
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
        V_AddHandler_DetailBH()
        V_AddHandler_DetailKhac()
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

        AddHandler DetailBHGRV.PopupMenuShowing, AddressOf MasterBHGRV_PopupMenuShowing
        AddHandler DetailBHGRV.KeyDown, AddressOf MasterBHGRV_KeyDown

        AddHandler DetailKhacGRV.PopupMenuShowing, AddressOf MasterKhacGRV_PopupMenuShowing
        AddHandler DetailKhacGRV.KeyDown, AddressOf MasterKhacGRV_KeyDown

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
        '
        AddHandler TxtGia_Xe_BH.Leave, AddressOf L_Gia_Xe_BH

        'Ma_TD3_H
        AddHandler TxtMa_TD3_H.CyberValiting, AddressOf V_Ma_TD3_H
        AddHandler TxtMa_TD3_H.CyberLeave, AddressOf L_Ma_TD3_H
        'Ma_HD_H
        AddHandler TxtMa_HD_H.CyberValiting, AddressOf V_Ma_HD_H
        AddHandler TxtMa_HD_H.CyberLeave, AddressOf L_Ma_HD_H      
        'Ma_Hs_H
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_HS_H
        'Ma_BP_H
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H       
        'Ma_GPK
        AddHandler TxtMa_GPK.CyberValiting, AddressOf V_Ma_GPK
        AddHandler TxtMa_GPK.CyberLeave, AddressOf L_Ma_GPK
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT                
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_Nt.Column Is Nothing Then AddHandler EditGia_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt.Column Is Nothing Then AddHandler EditTien_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditPT_CK.Column Is Nothing Then AddHandler EditPT_CK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCK.Column Is Nothing Then AddHandler EditCK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditT_TT_NT.Column Is Nothing Then AddHandler EditT_TT_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditT_TT.Column Is Nothing Then AddHandler EditT_TT.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditIs_KM.Column Is Nothing Then AddHandler EditIs_KM.EditColumn.Leave, AddressOf L_Is_Km
        If Not EditIs_Them.Column Is Nothing Then AddHandler EditIs_Them.EditColumn.Leave, AddressOf L_Is_Them

        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        '-------------------------------------       
        EditMa_Lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)

        EditMa_PK.V_ActiLookUpColumn(AddressOf V_Ma_PK, AddressOf L_Ma_PK)
        EditMa_TT.V_ActiLookUpColumn(AddressOf V_Ma_TT, AddressOf L_Ma_TT)

        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_i, AddressOf L_Ma_Kho_i)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_Phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_SP_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_Ku_I.V_ActiLookUpColumn(AddressOf V_Ma_Ku_i, AddressOf L_Ma_Ku_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_BP_i, AddressOf L_Ma_BP_i)
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
    Private Sub V_AddHandler_DetailBH()
        If Not EditBHSo_Luong.Column Is Nothing Then AddHandler EditBHSo_Luong.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHTy_Le.Column Is Nothing Then AddHandler EditBHTy_Le.EditColumn.Leave, AddressOf L_BH_Tinh_Toan

        If Not EditBHGia_Nt.Column Is Nothing Then AddHandler EditBHGia_Nt.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHGia.Column Is Nothing Then AddHandler EditBHGia.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHTien_Nt.Column Is Nothing Then AddHandler EditBHTien_Nt.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHTien.Column Is Nothing Then AddHandler EditBHTien.EditColumn.Leave, AddressOf L_BH_Tinh_Toan

        If Not EditBHPT_CK.Column Is Nothing Then AddHandler EditBHPT_CK.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHCK.Column Is Nothing Then AddHandler EditBHCK.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHT_TT_NT.Column Is Nothing Then AddHandler EditBHT_TT_NT.EditColumn.Leave, AddressOf L_BH_Tinh_Toan
        If Not EditBHT_TT.Column Is Nothing Then AddHandler EditBHT_TT.EditColumn.Leave, AddressOf L_BH_Tinh_Toan

        If Not EditBHIs_KM.Column Is Nothing Then AddHandler EditBHIs_KM.EditColumn.Leave, AddressOf L_BH_Is_Km
        If Not EditBHIs_Them.Column Is Nothing Then AddHandler EditBHIs_Them.EditColumn.Leave, AddressOf L_BH_Is_Them

        If Not EditBHDien_Giaii.Column Is Nothing Then AddHandler EditBHDien_Giaii.EditColumn.Enter, AddressOf E_BH_Dien_Giaii
        '-------------------------------------       
        EditBHMa_Lo.V_ActiLookUpColumn(AddressOf V_BH_Ma_Lo, AddressOf L_BH_Ma_Lo)

        EditBHMa_BH.V_ActiLookUpColumn(AddressOf V_BH_Ma_BH, AddressOf L_BH_Ma_BH)
        EditBHMa_LHBH.V_ActiLookUpColumn(AddressOf V_BH_Ma_LHBH, AddressOf L_BH_Ma_LHBH)

        EditBHMa_TT.V_ActiLookUpColumn(AddressOf V_BH_Ma_TT, AddressOf L_BH_Ma_TT)

        EditBHMa_Vitri.V_ActiLookUpColumn(AddressOf V_BH_Ma_Vitri, AddressOf L_BH_Ma_Vitri)
        EditBHMa_Vv_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Vv_i, AddressOf L_BH_Ma_Vv_i)
        EditBHMa_Phi_i.V_ActiLookUpColumn(AddressOf V_BH_Ma_Phi_i, AddressOf L_BH_Ma_Phi_i)
        EditBHMa_HD_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_HD_i, AddressOf L_BH_Ma_HD_i)
        EditBHMa_SP_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_SP_i, AddressOf L_BH_Ma_SP_i)
        EditBHMa_Ku_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Ku_i, AddressOf L_BH_Ma_Ku_i)
        EditBHMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_BH_Ma_TTLN_i, AddressOf L_BH_Ma_TTLN_i)
        EditBHMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_BH_Ma_TTCP_i, AddressOf L_BH_Ma_TTCP_i)
        EditBHMa_BP_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_BP_i, AddressOf L_BH_Ma_BP_i)
        EditBHMa_HS_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_HS_i, AddressOf L_BH_Ma_HS_i)
        EditBHMa_CD_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_CD_i, AddressOf L_BH_Ma_CD_i)
        EditBHMa_TD1_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_TD1_i, AddressOf L_BH_Ma_TD1_i)
        EditBHMa_TD2_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_TD2_i, AddressOf L_BH_Ma_TD2_i)
        EditBHMa_TD3_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_TD3_i, AddressOf L_BH_Ma_TD3_i)
        EditBHMa_TD4_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_TD4_i, AddressOf L_BH_Ma_TD4_i)
        EditBHMa_TD5_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_TD5_i, AddressOf L_BH_Ma_TD5_i)
        EditBHma_Db_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Db_i, AddressOf L_BH_Ma_Db_i)
        EditBHMa_Xe_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Xe_i, AddressOf L_BH_Ma_Xe_i)
        EditBHMa_KX_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Kx_i, AddressOf L_BH_Ma_Kx_i)
        EditBHMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_BH_Ma_Tuyen_i, AddressOf L_BH_Ma_Tuyen_i)
        EditBHMa_Ts.V_ActiLookUpColumn(AddressOf V_BH_Ma_Ts, AddressOf L_BH_Ma_Ts)
        EditBHMa_Cc.V_ActiLookUpColumn(AddressOf V_BH_Ma_Cc, AddressOf L_BH_Ma_Cc)
        If Not EditBHSo_So.Column Is Nothing Then AddHandler EditBHSo_So.EditColumn.Leave, AddressOf L_BH_So_So
        If Not EditBHSo_Po.Column Is Nothing Then AddHandler EditBHSo_Po.EditColumn.Leave, AddressOf L_BH_So_Po
        If Not EditBHSo_Ro.Column Is Nothing Then AddHandler EditBHSo_Ro.EditColumn.Leave, AddressOf L_BH_So_Ro
        If Not EditBHSo_VT.Column Is Nothing Then AddHandler EditBHSo_VT.EditColumn.Leave, AddressOf L_BH_So_VT
    End Sub
    Private Sub V_AddHandler_DetailKhac()
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

        If Not EditKhacDien_Giaii.Column Is Nothing Then AddHandler EditKhacDien_Giaii.EditColumn.Enter, AddressOf E_khac_Dien_Giaii
        '-------------------------------------
        EditKhacMa_Lo.V_ActiLookUpColumn(AddressOf V_khac_Ma_Lo, AddressOf L_khac_Ma_Lo)

        EditKhacMa_BH.V_ActiLookUpColumn(AddressOf V_khac_Ma_BH, AddressOf L_khac_Ma_BH)
        EditKhacMa_LHBH.V_ActiLookUpColumn(AddressOf V_khac_Ma_LHBH, AddressOf L_khac_Ma_LHBH)

        EditKhacMa_TT.V_ActiLookUpColumn(AddressOf V_khac_Ma_TT, AddressOf L_khac_Ma_TT)

        EditKhacMa_DvKhac.V_ActiLookUpColumn(AddressOf V_khac_Ma_DvKhac, AddressOf L_khac_Ma_DvKhac)

        EditKhacMa_Vitri.V_ActiLookUpColumn(AddressOf V_khac_Ma_Vitri, AddressOf L_khac_Ma_Vitri)
        EditKhacMa_Vv_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Vv_i, AddressOf L_khac_Ma_Vv_i)
        EditKhacMa_Phi_i.V_ActiLookUpColumn(AddressOf V_khac_Ma_Phi_i, AddressOf L_khac_Ma_Phi_i)
        EditKhacMa_HD_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_HD_i, AddressOf L_khac_Ma_HD_i)
        EditKhacMa_SP_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_SP_i, AddressOf L_khac_Ma_SP_i)
        EditKhacMa_Ku_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Ku_i, AddressOf L_khac_Ma_Ku_i)
        EditKhacMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_khac_Ma_TTLN_i, AddressOf L_khac_Ma_TTLN_i)
        EditKhacMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_khac_Ma_TTCP_i, AddressOf L_khac_Ma_TTCP_i)
        EditKhacMa_BP_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_BP_i, AddressOf L_khac_Ma_BP_i)
        EditKhacMa_HS_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_HS_i, AddressOf L_khac_Ma_HS_i)
        EditKhacMa_CD_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_CD_i, AddressOf L_khac_Ma_CD_i)
        EditKhacMa_TD1_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_TD1_i, AddressOf L_khac_Ma_TD1_i)
        EditKhacMa_TD2_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_TD2_i, AddressOf L_khac_Ma_TD2_i)
        EditKhacMa_TD3_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_TD3_i, AddressOf L_khac_Ma_TD3_i)
        EditKhacMa_TD4_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_TD4_i, AddressOf L_khac_Ma_TD4_i)
        EditKhacMa_TD5_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_TD5_i, AddressOf L_khac_Ma_TD5_i)
        EditKhacma_Db_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Db_i, AddressOf L_khac_Ma_Db_i)
        EditKhacMa_Xe_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Xe_i, AddressOf L_khac_Ma_Xe_i)
        EditKhacMa_KX_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Kx_i, AddressOf L_khac_Ma_Kx_i)
        EditKhacMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_khac_Ma_Tuyen_i, AddressOf L_khac_Ma_Tuyen_i)
        EditKhacMa_Ts.V_ActiLookUpColumn(AddressOf V_khac_Ma_Ts, AddressOf L_khac_Ma_Ts)
        EditKhacMa_Cc.V_ActiLookUpColumn(AddressOf V_khac_Ma_Cc, AddressOf L_khac_Ma_Cc)
        If Not EditKhacSo_So.Column Is Nothing Then AddHandler EditKhacSo_So.EditColumn.Leave, AddressOf L_khac_So_So
        If Not EditKhacSo_Po.Column Is Nothing Then AddHandler EditKhacSo_Po.EditColumn.Leave, AddressOf L_khac_So_Po
        If Not EditKhacSo_Ro.Column Is Nothing Then AddHandler EditKhacSo_Ro.EditColumn.Leave, AddressOf L_khac_So_Ro
        If Not EditKhacSo_VT.Column Is Nothing Then AddHandler EditKhacSo_VT.EditColumn.Leave, AddressOf L_khac_So_VT

        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler DetailBHGRV.RowCellStyle, AddressOf DetailBHGRV_RowCellStyle
        AddHandler DetailKhacGRV.RowCellStyle, AddressOf DetailKhacGRV_RowCellStyle
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailBHGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailBHGRV, Dt_DetailtmpBH, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailKhacGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailKhacGRV, Dt_DetailtmpKhac, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_NT()
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            EditTien.Visible = False
            EditGia.Visible = False
            TxtT_Tien.Visible = False
        Else
            EditTien.Visible = True
            EditGia.Visible = True
            TxtT_Tien.Visible = True
        End If
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
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

        Dt_DetailtmpBH.Clear()
        Dt_DetailtmpBH.AcceptChanges()
        For i = 0 To Dt_DetailBH.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailtmpBH.ImportRow(Dt_DetailBH.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        Dt_DetailtmpKhac.Clear()
        Dt_DetailtmpKhac.AcceptChanges()
        For i = 0 To Dt_DetailKhac.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailtmpKhac.ImportRow(Dt_DetailKhac.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next

        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
            DetailBHGRV.OptionsBehavior.Editable = True
            DetailKhacGRV.OptionsBehavior.Editable = True
        Else
            DetailGRV.OptionsBehavior.Editable = False
            DetailBHGRV.OptionsBehavior.Editable = False
            DetailKhacGRV.OptionsBehavior.Editable = False
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
#Region "Valid --- Ma_HD_H"
#Region "Valid --- Ma_GPK"
    Private Sub V_Ma_GPK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_GPK", "DmGPK", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_GPK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_GPK.Text = "" Then
            TxtTen_GPK.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_GPK.Text = DrReturn("Ma_GPK").ToString.Trim
            TxtTen_GPK.Text = DrReturn("ten_GPK").ToString.Trim
        Else
            TxtMa_GPK.Text = ""
            TxtTen_GPK.Text = ""
        End If
        If Not TxtMa_GPK.Text.Trim = "" Then V_GetMa_PK(TxtMa_GPK.Text.Trim)
    End Sub
    Private Sub V_GetMa_PK(ByVal _Ma_GPK As String)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPK_PBGHDXPPK", _Ngay_Ct.ToString("yyyyMMdd") + "#" + M_Stt_Rec + "#" + M_Ma_CT + "#" + M_Mode + "#" + _Ma_GPK + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If DsTmp.Tables.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        If DsTmp.Tables.Count <= 1 Then
            DsTmp.Dispose()
            Return
        End If
        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailTmp)
        Dt_DetailTmp.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRV)
        '-- khác
        Dt_DetailtmpKhac.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(2), Dt_DetailtmpKhac)
        Dt_DetailtmpKhac.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailKhacGRV)

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        For iRow As Integer = 0 To Dv_DetailtmpKhac.Count - 1
            V_khac_Tinh_Toan(iRow)
        Next
        CyberSupport.V_UpdateGRV(DetailGRV)
        CyberSupport.V_UpdateGRV(DetailKhacGRV)
        DsTmp.Dispose()
    End Sub
#End Region
    Private Sub V_GetMa_HD_H(ByVal _Ma_HD As String)
    End Sub
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
        Else
            TxtMa_HD_H.Text = ""
            TxtTen_HD_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TD3"
    Private Sub V_Ma_TD3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_TD3", "Dmtd3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_TD3_H.Text = "" Then
            TxtStt_Rec0_TD3.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3_H.Text = DrReturn("Ma_TD3").ToString.Trim
            TxtStt_Rec0_TD3.Text = DrReturn("Stt_Rec0").ToString.Trim
            TxtMa_HD_H.Text = DrReturn("Ma_HD").ToString.Trim
            TxtTen_HD_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "Ma_HD = N'" & TxtMa_HD_H.Text & "'", CyberSmlib)
        Else
            TxtMa_TD3_H.Text = ""
            TxtStt_Rec0_TD3.Text = ""
            TxtTen_HD_H.Text = ""
        End If
        V_GetHDX()
    End Sub
    Private Sub V_GetHDX() 'hieulv lấy thông tin từ hợp đồng để tính bảo hiểm vcx
        Dim dsTMp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEPPK_GetHDX", TxtMa_TD3_H.Text.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If dsTMp.Tables(0).Rows.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Columns.Contains("Gia_Niem_Yet") Then TxtGia_Niem_Yet.Double = dsTMp.Tables(0).Rows(0).Item("Gia_Niem_Yet")
        If dsTMp.Tables(0).Columns.Contains("CK") Then TxtCK.Double = dsTMp.Tables(0).Rows(0).Item("CK")
        If dsTMp.Tables(0).Columns.Contains("Gia_Xe_BH") Then TxtGia_Xe_BH.Double = dsTMp.Tables(0).Rows(0).Item("Gia_Xe_BH")
        '
        If dsTMp.Tables(0).Columns.Contains("So_Cho") Then TxtSo_Cho.Double = dsTMp.Tables(0).Rows(0).Item("So_Cho")
        If dsTMp.Tables(0).Columns.Contains("Tien_TNDS") Then TxtTien_TNDS.Double = dsTMp.Tables(0).Rows(0).Item("Tien_TNDS")
        dsTMp.Dispose()
    End Sub
#End Region
#Region "Valid --- Ma_BP_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn("Ma_BP").ToString.Trim
            TxtTen_BP_H.Text = DrReturn("ten_bp").ToString.Trim
        Else
            TxtMa_BP_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HS_H"
    Private Sub V_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
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
    Private Sub UpdateList()
        Dim nT_Tien_Nt As Decimal = 0
        Dim nT_Tien As Decimal = 0

        Dim nT_CK As Decimal = 0
        Dim nT_BB As Decimal = 0
        Dim nT_mua_Them As Decimal = 0
        Dim nT_KM As Decimal = 0

        Dim nT_So_Luong As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_Tien_Nt = nT_Tien_Nt + Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_Luong")

            nT_CK = nT_CK + Dv_DetailTmp.Item(iRow).Item("CK")
            If Dv_DetailTmp.Item(iRow).Item("Is_KM").ToString.Trim = "1" Then
                nT_KM = nT_KM + Dv_DetailTmp.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp.Item(iRow).Item("CK")
            Else
                If Dv_DetailTmp.Item(iRow).Item("Is_Them").ToString.Trim = "1" Then
                    nT_mua_Them = nT_mua_Them + Dv_DetailTmp.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp.Item(iRow).Item("CK")
                Else
                    nT_BB = nT_BB + Dv_DetailTmp.Item(iRow).Item("Tien_Nt") - Dv_DetailTmp.Item(iRow).Item("CK")
                End If
            End If
        Next
        'Cong bao hiem
        For iRow As Integer = 0 To Dv_DetailtmpBH.Count - 1
            nT_Tien_Nt = nT_Tien_Nt + Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailtmpBH.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailtmpBH.Item(iRow).Item("So_Luong")

            nT_CK = nT_CK + Dv_DetailtmpBH.Item(iRow).Item("CK")
            If Dv_DetailtmpBH.Item(iRow).Item("Is_KM").ToString.Trim = "1" Then
                nT_KM = nT_KM + Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpBH.Item(iRow).Item("CK")
            Else
                If Dv_DetailtmpBH.Item(iRow).Item("Is_Them").ToString.Trim = "1" Then
                    nT_mua_Them = nT_mua_Them + Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpBH.Item(iRow).Item("CK")
                Else
                    nT_BB = nT_BB + Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpBH.Item(iRow).Item("CK")
                End If
            End If
        Next
        'Cong khac
        For iRow As Integer = 0 To Dv_DetailtmpKhac.Count - 1
            nT_Tien_Nt = nT_Tien_Nt + Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailtmpKhac.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailtmpKhac.Item(iRow).Item("So_Luong")

            nT_CK = nT_CK + Dv_DetailtmpKhac.Item(iRow).Item("CK")
            If Dv_DetailtmpKhac.Item(iRow).Item("Is_KM").ToString.Trim = "1" Then
                nT_KM = nT_KM + Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpKhac.Item(iRow).Item("CK")
            Else
                If Dv_DetailtmpKhac.Item(iRow).Item("Is_Them").ToString.Trim = "1" Then
                    nT_mua_Them = nT_mua_Them + Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpKhac.Item(iRow).Item("CK")
                Else
                    nT_BB = nT_BB + Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") - Dv_DetailtmpKhac.Item(iRow).Item("CK")
                End If
            End If
        Next

        TxtT_Tien_NT.Double = nT_Tien_Nt
        TxtT_Tien.Double = nT_Tien
        TxtT_CK.Double = nT_CK
        TxtT_TT_NT.Double = nT_Tien_Nt - nT_CK

        TxtT_BB.Double = nT_BB
        TxtT_Mua_Them.Double = nT_mua_Them

        TxtT_KM.Double = nT_KM
        TxtT_So_Luong.Double = nT_So_Luong
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailTmp.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dim _Ck As Decimal = 0
        If Dt_DetailTmp.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_Nt") * Dv_DetailTmp.Item(iRow).Item("PT_CK") / 100, 0)
        If _Ck <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("CK") = _Ck
        Else
            _Ck = Dv_DetailTmp.Item(iRow).Item("CK")
        End If

        If Dt_DetailTmp.Columns.Contains("T_TT_NT") Then Dv_DetailTmp.Item(iRow).Item("T_TT_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt") - _Ck
        If Dt_DetailTmp.Columns.Contains("T_TT") Then Dv_DetailTmp.Item(iRow).Item("T_TT") = Dv_DetailTmp.Item(iRow).Item("Tien") - _Ck
        Dv_DetailTmp.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub L_Is_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailTmp.Item(iRow).Item("Is_Them") = 0
        Dv_DetailTmp.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub L_Is_Them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailTmp.Item(iRow).Item("Is_Them") = 0
        Dv_DetailTmp.Item(iRow).EndEdit()

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
    End Sub
    Private Sub V_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailGRV)
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
#Region "L_Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_TT") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------
        UpdateList()
        DetailGRV.UpdateCurrentRow()
        '-------------------------------------------------------------------
    End Sub
#End Region
    Private Sub V_Ma_PK(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_PK", "DmPKPKD", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_PK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1

        If DrReturn Is Nothing Then
            iRow = DetailGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("Ma_PK").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        'Dim _Ma_PK As String = DrReturn.Item("Ma_PK")

        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_PK") = DrReturn("Ma_PK")
        If Dt_DetailTmp.Columns.Contains("ten_PK") And DrReturn.Table.Columns.Contains("ten_PK") Then Dv_DetailTmp.Item(iRow).Item("ten_PK") = DrReturn("Ten_PK")
        If Dt_DetailTmp.Columns.Contains("DVT") And DrReturn.Table.Columns.Contains("DVT") Then Dv_DetailTmp.Item(iRow).Item("DVT") = DrReturn("DVT")

        If Dt_DetailTmp.Columns.Contains("Ma_Kho_I") And DrReturn.Table.Columns.Contains("Ma_Kho") Then
            If Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim = "" Then Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I") = DrReturn("Ma_Kho")
        End If

        If Dt_DetailTmp.Columns.Contains("Ma_Vitri") And DrReturn.Table.Columns.Contains("Ma_Vitri") Then
            If Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim = "" Then Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = DrReturn("Ma_Vitri")
        End If
        If Dt_DetailTmp.Columns.Contains("Ma_TT") And DrReturn.Table.Columns.Contains("Ma_TT") Then
            If Dv_DetailTmp.Item(iRow).Item("Ma_TT").ToString.Trim = "" Then Dv_DetailTmp.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT")
        End If

        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPricePK(iRow)
        V_SetSD(iRow)
    End Sub
    Private Sub V_SetPricePK(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _ma_HD As String = ""
        _ma_HD = TxtMa_HD_H.Text.Trim

        CyberSmodb.GetValueData(Dv_DetailTmp.Item(iRow), _strF, _strV, "Ten_PK")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPricePK_PBG_HDX", _ma_HD + "#" + M_Stt_Rec + "#" + M_Ma_CT + "#" + M_Mode + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _strF + "#" + _strV + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)

        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Not Dstmp.Tables(0).Columns.Contains("Status") Then
            Dstmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(1).Rows(0), Dv_DetailTmp, iRow)
        V_Tinh_Toan(iRow)
        Dstmp.Dispose()
    End Sub
    Private Sub V_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRV)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
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
        Dim _Ma_PK As String = Dv_DetailTmp.Item(iRow).Item("Ma_PK").ToString.Trim
        Dim _Ma_Kho As String = ""
        Dim _Ma_Vitri As String = ""
        If Dt_DetailTmp.Columns.Contains("Ma_Kho_I") Then _Ma_Kho = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim()
        If Dt_DetailTmp.Columns.Contains("Ma_Vitri") Then _Ma_Vitri = Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim()
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_Lo").ToString.Trim, "")

        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_PK, _Ma_Kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If Dt_DetailTmp.Columns.Contains("Ton13") Then Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Ma_Vitri") And _Return.Table.Columns.Contains("Ma_Vitri") Then Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = _Return("Ma_Vitri")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor") And _Return.Table.Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = _Return.Item("BackColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor2") And _Return.Table.Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = _Return.Item("BackColor2")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ForeColor") And _Return.Table.Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = _Return.Item("ForeColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Bold") And _Return.Table.Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = _Return.Item("Bold")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Underline") And _Return.Table.Columns.Contains("Underline") Then Dv_DetailTmp.Item(iRow).Item("Underline") = _Return.Item("Underline")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Italic") And _Return.Table.Columns.Contains("Italic") Then Dv_DetailTmp.Item(iRow).Item("Italic") = _Return.Item("Italic")

            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
    Private Sub L_Gia_Xe_BH(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim Gia_Niem_Yet As Decimal = TxtGia_Niem_Yet.Double
        Dim CK As Decimal = TxtCK.Double
        Dim Gia_Xe_BH As Decimal = TxtGia_Xe_BH.Double
        'không cho sửa giá nhỏ hơn giá niêm yết - km tiền mặt theo csbh (hieulv)
        If Gia_Xe_BH < Gia_Niem_Yet - CK And Gia_Xe_BH <> 0 Then

            MsgBox("Giá trị xe bảo hiểm nhỏ hơn Giá niêm yết - khuyến mại tiền mặt", MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            TxtGia_Xe_BH.Double = Gia_Niem_Yet
        End If

        For iRow As Integer = 0 To Dv_DetailtmpBH.Count - 1
            V_BH_Tinh_Toan(iRow)
        Next
        Dv_DetailtmpBH.Table.AcceptChanges()
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
        CyberVoucher.V_FormatSo_POBE(Dv_DetailTmp, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
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
#Region "Valid - Detail - bao Hiem======================================="
#Region "Valid - Detail - Core"
    Private Sub BH_UpdateList()       
    End Sub
    Private Sub V_BH_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        'hieulv: Tự động tính toán tỷ lệ bảo hiểm
        Dim Gia_Xe_BH As Decimal = TxtGia_Xe_BH.Double
        Dim Ma_LHBH As String = Dv_DetailtmpBH.Item(iRow).Item("Ma_LHBH").ToString.Trim
        Dim Ma_BH As String = Dv_DetailtmpBH.Item(iRow).Item("Ma_BH").ToString.Trim
        Dim _Gia_Xe_BH As String = TxtGia_Xe_BH.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        If Gia_Xe_BH > 0 And Ma_LHBH = "VCX" And Ma_BH <> "" Then
            Dim dsTMp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEPPK_GetDMTyLeBH", Ma_BH.Trim + "#" + _Gia_Xe_BH.Trim + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
            If dsTMp.Tables(0).Rows.Count < 1 Then
                dsTMp.Dispose()
                Exit Sub
            End If
            Dv_DetailtmpBH.Item(iRow).BeginEdit()
            Dv_DetailtmpBH.Item(iRow).Item("Ty_Le_CS") = dsTMp.Tables(0).Rows(0).Item("Ty_Le")
            Dv_DetailtmpBH.Item(iRow).Item("Ty_Le") = IIf(Dv_DetailtmpBH.Item(iRow).Item("Ty_Le") <= Dv_DetailtmpBH.Item(iRow).Item("Ty_Le_CS"), Dv_DetailtmpBH.Item(iRow).Item("Ty_Le_CS"), Dv_DetailtmpBH.Item(iRow).Item("Ty_Le"))
            Dv_DetailtmpBH.Item(iRow).EndEdit()
        End If

        If Dv_DetailtmpBH.Item(iRow).Item("Ty_Le") <> 0 And Ma_LHBH = "VCX" Then
            Dv_DetailtmpBH.Item(iRow).BeginEdit()
            Dv_DetailtmpBH.Item(iRow).Item("Gia_Nt") = CyberSupport.V_Round(Dv_DetailtmpBH.Item(iRow).Item("Ty_Le") * Gia_Xe_BH / 100, M_R_TIEN_NT)
            Dv_DetailtmpBH.Item(iRow).EndEdit()
        End If
        '--------------------------------------------------------------------------------
        If Dv_DetailtmpBH.Item(iRow).Item("So_Luong") * Dv_DetailtmpBH.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailtmpBH.Item(iRow).BeginEdit()
            Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailtmpBH.Item(iRow).Item("So_Luong") * Dv_DetailtmpBH.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailtmpBH.Item(iRow).EndEdit()
        End If
        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailtmpBH.Item(iRow).Item("Tien") = Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt")
            Dv_DetailtmpBH.Item(iRow).Item("Gia") = Dv_DetailtmpBH.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailtmpBH.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_TIEN)
            Dv_DetailtmpBH.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailtmpBH.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailtmpBH.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------

        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        Dim _Ck As Decimal = 0
        If Dt_DetailtmpBH.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") * Dv_DetailtmpBH.Item(iRow).Item("PT_CK") / 100, 0)
        If _Ck <> 0 Then
            Dv_DetailtmpBH.Item(iRow).Item("CK") = _Ck
        Else
            _Ck = Dv_DetailtmpBH.Item(iRow).Item("CK")
        End If

        If Dt_DetailtmpBH.Columns.Contains("T_TT_NT") Then Dv_DetailtmpBH.Item(iRow).Item("T_TT_NT") = Dv_DetailtmpBH.Item(iRow).Item("Tien_Nt") - _Ck
        If Dt_DetailtmpBH.Columns.Contains("T_TT") Then Dv_DetailtmpBH.Item(iRow).Item("T_TT") = Dv_DetailtmpBH.Item(iRow).Item("Tien") - _Ck
        Dv_DetailtmpBH.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        CyberSupport.V_UpdateGRV(DetailBHGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_BH_Is_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        If Dv_DetailtmpBH.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailtmpBH.Item(iRow).Item("Is_Them") = 0
        Dv_DetailtmpBH.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailBHGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_BH_Is_Them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        If Dv_DetailtmpBH.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailtmpBH.Item(iRow).Item("Is_Them") = 0
        Dv_DetailtmpBH.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailBHGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_BH_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailBHGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailBHGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailBHGRV)
        V_BH_Tinh_Toan(iRow)
        UpdateList()
    End Sub
    Private Sub V_BH_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub E_BH_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailtmpBH.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailtmpBH.Item(iRow).BeginEdit()
            Dv_DetailtmpBH.Item(iRow).Item("Dien_Giaii") = TxtDien_Giai.Text
            Dv_DetailtmpBH.Item(iRow).EndEdit()
        End If
        DetailBHGRV.ShowEditor()
    End Sub
#End Region
#Region "Vat tu kho/Vitri - "
    Private Sub V_BH_Ma_Lo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Lo(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Lo(M_Mode, M_Ma_CT, sender, DetailBHGRV)
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
#Region "L_Ma_TT"
    Private Sub V_BH_Ma_TT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailtmpBH.Item(iRow).BeginEdit()
            Dv_DetailtmpBH.Item(iRow)("Ma_TT") = ""
            Dv_DetailtmpBH.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        Dv_DetailtmpBH.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT").ToString.Trim
        Dv_DetailtmpBH.Item(iRow).EndEdit()
        '-------------------------------------------------------------------
        BH_UpdateList()
        DetailBHGRV.UpdateCurrentRow()      
    End Sub
#End Region
    Private Sub V_BH_Ma_BH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_BH", "DmBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailtmpBH.Item(iRow).Item("Ma_BH").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailtmpBH.Item(iRow).Delete()
                    Dv_DetailtmpBH.Table.AcceptChanges()
                    BH_UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        'Dim _Ma_PK As String = DrReturn.Item("Ma_PK")

        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        Dv_DetailtmpBH.Item(iRow).Item("Ma_BH") = DrReturn("Ma_BH")
        If Dt_DetailtmpBH.Columns.Contains("ten_BH") And DrReturn.Table.Columns.Contains("ten_BH") Then Dv_DetailtmpBH.Item(iRow).Item("ten_BH") = DrReturn("Ten_BH")
        Dv_DetailtmpBH.Item(iRow).EndEdit()
        Dv_DetailtmpBH.Table.AcceptChanges()
        V_BH_Tinh_Toan(iRow)

    End Sub

    Private Sub V_BH_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_LHBH", "DmLHBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If DrReturn Is Nothing Then
            iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
            Dv_DetailtmpBH.Item(iRow).Item("Ma_LHBH") = ""
            If Dt_DetailtmpBH.Columns.Contains("Ten_LHBH") Then Dv_DetailtmpBH.Item(iRow).Item("Ten_LHBH") = ""
            Exit Sub
        End If


        If iRow < 0 Then Exit Sub

        Dv_DetailtmpBH.Item(iRow).BeginEdit()
        Dv_DetailtmpBH.Item(iRow).Item("Ma_LHBH") = DrReturn("Ma_LHBH")
        If Dt_DetailtmpBH.Columns.Contains("Ten_LHBH") And DrReturn.Table.Columns.Contains("Ten_LHBH") Then Dv_DetailtmpBH.Item(iRow).Item("Ten_LHBH") = DrReturn("Ten_LHBH")
        If Dv_DetailtmpBH.Item(iRow).Item("Gia_NT") = 0 And DrReturn("Ma_LHBH") = "TNDS" Then
            Dv_DetailtmpBH.Item(iRow).Item("Gia_NT") = TxtTien_TNDS.Double
        End If
        Dv_DetailtmpBH.Item(iRow).EndEdit()
        Dv_DetailtmpBH.Table.AcceptChanges()
        V_BH_Tinh_Toan(iRow)

    End Sub
    Private Sub V_BH_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailBHGRV)
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_BH_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberVoucher.V_FormatSo_So(Dv_DetailtmpBH, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_BH_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_PO(Dv_DetailtmpBH, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_BH_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberVoucher.V_FormatSo_Ro(Dv_DetailtmpBH, iRow, AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_Ct, CmbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)


    End Sub
    Private Sub L_BH_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailBHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberVoucher.V_FormatSo_VT(Dv_DetailtmpBH, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Detail - Add On"
    Private Sub V_BH_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Db_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kx_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Tuyen_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Tuyen_i(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Ts(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ts(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ts(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
    Private Sub V_BH_Ma_Cc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cc(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_BH_Ma_Cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cc(M_Mode, M_Ma_CT, sender, DetailBHGRV)
    End Sub
#End Region
#End Region
#Region "Valid - Detail -Khac======================================="
#Region "Valid - Detail - Core"
    Private Sub Khac_UpdateList()        
    End Sub
    Private Sub V_khac_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------
        If Dv_DetailtmpKhac.Item(iRow).Item("So_Luong") * Dv_DetailtmpKhac.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailtmpKhac.Item(iRow).BeginEdit()
            Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailtmpKhac.Item(iRow).Item("So_Luong") * Dv_DetailtmpKhac.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailtmpKhac.Item(iRow).EndEdit()
        End If
        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailtmpKhac.Item(iRow).Item("Tien") = Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt")
            Dv_DetailtmpKhac.Item(iRow).Item("Gia") = Dv_DetailtmpKhac.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailtmpKhac.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_TIEN)
            Dv_DetailtmpKhac.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailtmpKhac.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------

        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        Dim _Ck As Decimal = 0
        If Dt_DetailtmpKhac.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") * Dv_DetailtmpKhac.Item(iRow).Item("PT_CK") / 100, 0)
        If _Ck <> 0 Then
            Dv_DetailtmpKhac.Item(iRow).Item("CK") = _Ck
        Else
            _Ck = Dv_DetailtmpKhac.Item(iRow).Item("CK")
        End If

        If Dt_DetailtmpKhac.Columns.Contains("T_TT_NT") Then Dv_DetailtmpKhac.Item(iRow).Item("T_TT_NT") = Dv_DetailtmpKhac.Item(iRow).Item("Tien_Nt") - _Ck
        If Dt_DetailtmpKhac.Columns.Contains("T_TT") Then Dv_DetailtmpKhac.Item(iRow).Item("T_TT") = Dv_DetailtmpKhac.Item(iRow).Item("Tien") - _Ck
        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        '------------------------------------------------------------------------------------------------
        CyberSupport.V_UpdateGRV(DetailKhacGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_khac_Is_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        If Dv_DetailtmpKhac.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailtmpKhac.Item(iRow).Item("Is_Them") = 0
        Dv_DetailtmpKhac.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailKhacGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_khac_Is_Them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return

        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        If Dv_DetailtmpKhac.Item(iRow).Item("Is_Km").ToString.Trim = "1" Then Dv_DetailtmpKhac.Item(iRow).Item("Is_Them") = 0
        Dv_DetailtmpKhac.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailKhacGRV)
        BH_UpdateList()
    End Sub
    Private Sub L_khac_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailKhacGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailKhacGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailKhacGRV)
        V_khac_Tinh_Toan(iRow)
        UpdateList()
    End Sub
    Private Sub V_khac_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub E_khac_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailtmpKhac.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailtmpKhac.Item(iRow).BeginEdit()
            Dv_DetailtmpKhac.Item(iRow).Item("Dien_Giaii") = TxtDien_Giai.Text
            Dv_DetailtmpKhac.Item(iRow).EndEdit()
        End If
        DetailKhacGRV.ShowEditor()
    End Sub
#End Region
#Region "Vat tu kho/Vitri - "
    Private Sub V_khac_Ma_Lo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Lo(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Lo(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
#Region "L_Khac_Ma_DvKhac"
    Private Sub V_khac_Ma_DvKhac(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_DvKhac", "DmDvKhac", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_DvKhac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailtmpKhac.Item(iRow).BeginEdit()
            Dv_DetailtmpKhac.Item(iRow)("Ma_DvKhac") = ""
            Dv_DetailtmpKhac.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        Dv_DetailtmpKhac.Item(iRow).Item("Ma_DvKhac") = DrReturn("Ma_DvKhac").ToString.Trim
        Dv_DetailtmpKhac.Item(iRow).Item("Ten_DvKhac") = DrReturn("Ten_DvKhac").ToString.Trim
        Dv_DetailtmpKhac.Item(iRow).Item("GIA_NT") = DrReturn("GIA_NT2").ToString.Trim

        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        '-------------------------------------------------------------------
        V_khac_Tinh_Toan(iRow)
        Khac_UpdateList()
        DetailKhacGRV.UpdateCurrentRow()
        '-------------------------------------------------------------------
    End Sub
#End Region

#Region "L_Ma_TT"
    Private Sub V_khac_Ma_TT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailtmpKhac.Item(iRow).BeginEdit()
            Dv_DetailtmpKhac.Item(iRow)("Ma_TT") = ""
            Dv_DetailtmpKhac.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        Dv_DetailtmpKhac.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT").ToString.Trim
        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        '-------------------------------------------------------------------
        BH_UpdateList()
        DetailKhacGRV.UpdateCurrentRow()
        '-------------------------------------------------------------------
    End Sub
#End Region
    Private Sub V_khac_Ma_BH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_BH", "DmBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailtmpKhac.Item(iRow).Item("Ma_BH").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailtmpKhac.Item(iRow).Delete()
                    Dv_DetailtmpKhac.Table.AcceptChanges()
                    BH_UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        'Dim _Ma_PK As String = DrReturn.Item("Ma_PK")

        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        Dv_DetailtmpKhac.Item(iRow).Item("Ma_BH") = DrReturn("Ma_BH")
        If Dt_DetailtmpKhac.Columns.Contains("ten_BH") And DrReturn.Table.Columns.Contains("ten_BH") Then Dv_DetailtmpKhac.Item(iRow).Item("ten_BH") = DrReturn("Ten_BH")
        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        Dv_DetailtmpKhac.Table.AcceptChanges()
    End Sub
    Private Sub V_khac_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_LHBH", "DmLHBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailtmpKhac.Item(iRow).Item("Ma_LHBH").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailtmpKhac.Item(iRow).Delete()
                    Dv_DetailtmpKhac.Table.AcceptChanges()
                    BH_UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If

        'Dim _Ma_PK As String = DrReturn.Item("Ma_PK")

        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dv_DetailtmpKhac.Item(iRow).BeginEdit()
        Dv_DetailtmpKhac.Item(iRow).Item("Ma_LHBH") = DrReturn("Ma_LHBH")
        If Dt_DetailtmpKhac.Columns.Contains("Ten_LHBH") And DrReturn.Table.Columns.Contains("Ten_LHBH") Then Dv_DetailtmpKhac.Item(iRow).Item("Ten_LHBH") = DrReturn("Ten_LHBH")
        Dv_DetailtmpKhac.Item(iRow).EndEdit()
        Dv_DetailtmpKhac.Table.AcceptChanges()
    End Sub
    Private Sub V_khac_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_khac_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberVoucher.V_FormatSo_So(Dv_DetailtmpKhac, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub L_khac_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_PO(Dv_DetailtmpKhac, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_khac_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_FormatSo_Ro(Dv_DetailtmpKhac, iRow, AppConn, osysvar, M_Ma_CT, "S", M_Mode, _Ngay_Ct, CmbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)

    End Sub
    Private Sub L_khac_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberVoucher.V_FormatSo_VT(Dv_DetailtmpKhac, iRow, AppConn, SysVar, M_Ma_CT, CmbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, CmbMa_TTCP_H, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Detail - Add On"
    Private Sub V_khac_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Ku_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_BP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Db_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Xe_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kx_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Tuyen_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Tuyen_i(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Ts(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ts(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ts(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
    End Sub
    Private Sub V_khac_Ma_Cc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cc(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_khac_Ma_Cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cc(M_Mode, M_Ma_CT, sender, DetailKhacGRV)
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

        VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
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
        Dim mnItemsF5 As New MenuItem(If(M_LAN = "V", "Chọn phiếu nhập", "Select Receipt"), AddressOf V_ShortF5, Keys.F5)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF5)
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
    Private Sub V_MainSystemBH()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemBH, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemBH, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailBHGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterBHGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_BH_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_BH_ShortDeleteItem, Nothing, True, False))

            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.FocusedRowHandle
        V_AddItemBH(iRow)
        iRow = Dv_DetailtmpBH.Count - 1
        CyberFill.V_ForcusCell(Dv_DetailtmpBH, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailtmpBH, AppConn) Then Exit Sub
        Dv_DetailtmpBH.Delete(iRow)
        Dv_DetailtmpBH.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_MainSystemKHAC()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemKHAC, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemKHAC, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailKhacGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterKhacGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_Khac_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_Khac_ShortDeleteItem, Nothing, True, False))

            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemKHAC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.FocusedRowHandle
        V_AddItemKHAC(iRow)
        iRow = Dv_DetailtmpKhac.Count - 1
        CyberFill.V_ForcusCell(Dv_DetailtmpKhac, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemKHAC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailtmpKhac, AppConn) Then Exit Sub
        Dv_DetailtmpKhac.Delete(iRow)
        Dv_DetailtmpKhac.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_ShortF5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim _Ma_PK As String = ""
        Dim _Ma_Kho As String = ""
        Dim _Ma_Lo As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        If Dt_DetailTmp.Columns.Contains("Ma_PK") Then _Ma_PK = Dv_DetailTmp.Item(iRow).Item("Ma_PK")
        If Dt_DetailTmp.Columns.Contains("Ma_Kho_I") Then _Ma_Kho = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I")
        If Dt_DetailTmp.Columns.Contains("Ma_Lo") Then _Ma_Lo = Dv_DetailTmp.Item(iRow).Item("Ma_Lo")
        Dim Drv_Return As DataRowView = CyberVoucher.V_Loc_PN_DD(AppConn, osysvar, M_LAN, M_Para, M_Mode, _Ma_PK, _Ma_Lo, _Ma_Kho, _Ngay_Ct, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, _
                                    CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberVoucher, CyberLoading)
        If Drv_Return Is Nothing Then Exit Sub
        If Drv_Return.DataView.Table.Columns.Contains("Gia_Nt_PN") And Dv_DetailTmp.Table.Columns.Contains("Gia_Nt") Then
            Dv_DetailTmp.BeginInit()
            Dv_DetailTmp.Item(iRow).Item("Gia_Nt") = Drv_Return.Item("Gia_Nt_PN")
            Dv_DetailTmp.EndInit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()
        V_Tinh_Toan(iRow)
        UpdateList()
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
    Private Sub V_BH_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.FocusedRowHandle
        V_AddItemBH(iRow)
    End Sub
    Private Sub V_BH_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailBHGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailtmpBH, AppConn, DetailBHGRV) Then Exit Sub
        Dv_DetailtmpBH.Delete(iRow)
        Dv_DetailtmpBH.Table.AcceptChanges()
        BH_UpdateList()
    End Sub
    Private Sub V_Khac_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.FocusedRowHandle
        V_AddItemKHAC(iRow)
    End Sub
    Private Sub V_Khac_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailKhacGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailtmpKhac, AppConn, DetailKhacGRV) Then Exit Sub
        Dv_DetailtmpKhac.Delete(iRow)
        Dv_DetailtmpKhac.Table.AcceptChanges()
        BH_UpdateList()
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
        DetailBHGRV.PostEditor()
        DetailKhacGRV.PostEditor()

        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailtmpBH.Table.AcceptChanges()
        Dv_DetailtmpKhac.Table.AcceptChanges()

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
        CyberInput.V_Save_Default_TTCP(Dt_DetailtmpBH, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailtmpKhac, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
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
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailtmpBH, Dt_DetailtmpKhac}, {M_Ct, M_Ph, "CTPPKBH", "CTPPKKHAC"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CmbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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
        '---------------------------------------------------
        '---Update BH
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailtmpBH, iRow)
                Catch ex As Exception
                End Try
            Next
        End If

        '---Xoa trong DetailBH
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailBH, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailBH.Load(Dt_DetailtmpBH.CreateDataReader)
        '---------------------------------------------------
        '---Update Khac
        If DsSave.Tables.Count >= 5 Then
            For iRow As Integer = 0 To DsSave.Tables(4).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(4).Rows(iRow), Dt_DetailtmpKhac, iRow)
                Catch ex As Exception
                End Try
            Next
        End If

        '---Xoa trong Detailkhac
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailKhac, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailKhac.Load(Dt_DetailtmpBH.CreateDataReader)
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
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailtmpBH, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailtmpKhac, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,TEN_KH", "Ten_PK,Ten_Kho_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        ''----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, txtSo_ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        ''----------------------------------------------------------------------------------------------------------------------

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
            If Dt_DetailTmp.Rows(iRow).Item("Ma_PK").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailtmpBH.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailtmpBH.Rows(iRow).Item("Ma_BH").ToString.Trim = "" Or Dt_DetailtmpBH.Rows(iRow).Item("Ma_LHBH").ToString.Trim = "" Then
                Dt_DetailtmpBH.Rows(iRow).Delete()
                Dt_DetailtmpBH.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailtmpKhac.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailtmpKhac.Rows(iRow).Item("Ma_DvKhac").ToString.Trim = "" Then
                Dt_DetailtmpKhac.Rows(iRow).Delete()
                Dt_DetailtmpKhac.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()

        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailtmpBH.Rows.Count - 1
            Dt_DetailtmpBH.Rows(iRow).BeginEdit()
            Dt_DetailtmpBH.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailtmpBH.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailtmpBH.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailtmpBH.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailtmpBH.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailtmpBH.Rows(iRow).EndEdit()
        Next
        Dt_DetailtmpBH.AcceptChanges()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailtmpKhac.Rows.Count - 1
            Dt_DetailtmpKhac.Rows(iRow).BeginEdit()
            Dt_DetailtmpKhac.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailtmpKhac.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailtmpKhac.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailtmpKhac.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            Dt_DetailtmpKhac.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailtmpKhac.Rows(iRow).EndEdit()
        Next
        Dt_DetailtmpKhac.AcceptChanges()

        'If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        '-----------------------------------------------------------------------------------------------------
        Dim _DtPh As DataTable = Dt_Master.Clone
        Dim _DrPh As DataRow = _DtPh.NewRow
        _DrPh.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrPh)
        CyberSmodb.AddValueToRow(_DrPh, Me)
        If _DtPh.Columns.Contains("Stt_Rec") Then _DrPh.Item("Stt_Rec") = M_Stt_Rec
        If _DtPh.Columns.Contains("Ma_Ct") Then _DrPh.Item("Ma_Ct") = M_Ma_CT
        If _DtPh.Columns.Contains("Ma_Dvcs") Then _DrPh.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrPh.EndEdit()
        _DtPh.Rows.Add(_DrPh)
        _DtPh.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsTmpSave As DataSet = CyberSmodb.V_ChkAndSaveVoucher(Mode, M_Stt_Rec, M_Ma_CT, _Ngay_Ct, TxtMa_Dvcs.Text, M_User_Name, {M_Ph, M_Ct, "CTPPKBH", "CTPPKKHac"}, {_DtPh, Dt_DetailTmp, Dt_DetailtmpBH, Dt_DetailtmpKhac}, AppConn, osysvar, M_LAN, "", CyberSmlib, CyberSupport)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmpSave.Tables(0), osysvar, M_LAN)
        If Not _Return Then
            DsTmpSave.Dispose()
            Return False
        End If
        '-------------------------------------------------------------------------------------------------------------------
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
        '-------------------------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailBH, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailKhac, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailtmpBH.Rows.Count - 1
            Dt_DetailBH.ImportRow(Dt_DetailtmpBH.Rows(i))
        Next

        For i As Integer = 0 To Dt_DetailtmpKhac.Rows.Count - 1
            Dt_DetailKhac.ImportRow(Dt_DetailtmpKhac.Rows(i))
        Next
        Return True
    End Function
    Private Function Add2Database_Luu_New() As Boolean
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
    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)
        M_Mode = "M"
        V_Databing()
        V_GetMaBP()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = M_Dien_Giai
        V_New()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        CyberSmodb.SetValueFromCombox(CmbMa_TTCP_H, M_Ma_TTCP_H)
    End Sub
    Private Sub V_GetMaBP()
        Dim dsTMp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetBpHs", M_User_Name)
        If dsTMp.Tables.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Rows.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Columns.Contains("Ma_BP_H") Then If TxtMa_BP_H.Text.Trim = "" Then TxtMa_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_BP_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Bp_H") Then If TxtTen_BP_H.Text.Trim = "" Then TxtTen_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Bp_H")
        If dsTMp.Tables(0).Columns.Contains("Ma_Hs_H") Then If TxtMa_Hs_H.Text.Trim = "" Then TxtMa_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_HS_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Hs_H") Then If TxtTen_Hs_H.Text.Trim = "" Then TxtTen_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Hs_H")
        dsTMp.Dispose()
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

        If Dt_DetailtmpBH.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailtmpBH.NewRow()
            DrCurren = Dt_DetailtmpBH.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailtmpBH.Rows.Add(DrCurren)
            Dt_DetailtmpBH.AcceptChanges()
        End If

        If Dt_DetailtmpKhac.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailtmpKhac.NewRow()
            DrCurren = Dt_DetailtmpKhac.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailtmpKhac.Rows.Add(DrCurren)
            Dt_DetailtmpKhac.AcceptChanges()
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
    Private Sub MasterBHGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailBHGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailBHGRV.RowCount - 1
        Dim iRowRowFocus As Integer = DetailBHGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailBHGRV.VisibleColumns.IndexOf(DetailBHGRV.FocusedColumn)
        Dim iRowOld As Integer = DetailBHGRV.GetFocusedDataSourceRowIndex        
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemBH(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemBH(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailtmpBH.Item(iRow) Else DrvOld = Nothing
        Dv_DetailtmpBH.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailtmpBH.Table.Rows(Dv_DetailtmpBH.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailtmpBH.Table.Rows(Dv_DetailtmpBH.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(2)))
        BH_CarrOn(Dv_DetailtmpBH.Table.Rows(Dv_DetailtmpBH.Table.Rows.Count - 1))
        BH_UpdateList()
        iRow = Dv_DetailtmpBH.Count - 1
        CyberFill.V_ForcusCell(DetailBHGRV, iRow, 0)
    End Sub
    Private Sub BH_CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub MasterKhacGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailKhacGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailKhacGRV.RowCount - 1
        Dim iRowRowFocus As Integer = DetailKhacGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailKhacGRV.VisibleColumns.IndexOf(DetailKhacGRV.FocusedColumn)
        Dim iRowOld As Integer = DetailKhacGRV.GetFocusedDataSourceRowIndex
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemKHAC(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub

    Private Sub V_AddItemKHAC(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailtmpKhac.Item(iRow) Else DrvOld = Nothing
        Dv_DetailtmpKhac.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailtmpKhac.Table.Rows(Dv_DetailtmpKhac.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailtmpKhac.Table.Rows(Dv_DetailtmpKhac.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(3)))
        Khac_CarrOn(Dv_DetailtmpKhac.Table.Rows(Dv_DetailtmpKhac.Table.Rows.Count - 1))
        Khac_UpdateList()
        iRow = Dv_DetailtmpKhac.Count - 1
        CyberFill.V_ForcusCell(DetailKhacGRV, iRow, 0)
    End Sub
    Private Sub Khac_CarrOn(ByVal DvNew As DataRow)
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
        TxtMa_HD_H.ReadOnly = True
        TxtMa_HD_H.Enabled = False

        TxtT_So_Luong.ReadOnly = True
        TxtT_Tien_NT.ReadOnly = True
        TxtT_Tien.ReadOnly = True

        TxtT_CK.ReadOnly = True
        TxtT_TT_NT.ReadOnly = True

        TxtT_BB.ReadOnly = True
        TxtT_Mua_Them.ReadOnly = True
        TxtT_KM.ReadOnly = True

        TxtGia_Niem_Yet.ReadOnly = True
        TxtCK.ReadOnly = True

        TxtSo_Cho.Enabled = False
        TxtTien_TNDS.Enabled = False
        TxtGia_Niem_Yet.Enabled = False
        TxtCK.Enabled = False

        TxtTen_HD_H.ReadOnly = True
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

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

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


