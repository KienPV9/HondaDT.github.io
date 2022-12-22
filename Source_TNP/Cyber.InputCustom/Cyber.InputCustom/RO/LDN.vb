Imports System.Data.SqlClient
Public Class LDN
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

    Dim EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim Editma_Db_I, EditMa_Xe_I, EditMa_KX_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditTien_NT, EditTien, EditThue_NT, EditThue, EditT_TT_NT, EditT_TT, EditThue_Suat, EditMa_Thue, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    'Dim EditTen_HD_I, EditMoi_Gioi, EditT_Phai_Thu, EditT_Da_Thu, EditT_CL_TT, EditT_RO, EditT_RO_C, EditT_RO_I, EditT_RO_W, EditT_RO_N, EditT_HD_VAT, EditDN_TT, EditDN_Da_TT, EditDN_CL_TT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Dim EditTen_HD_I, EditMoi_Gioi, EditNgay_HD, EditNgay_PT, EditTien_HD, EditTien_PT As New Cyber.Fill.CyberColumnGridView
    Dim EditSO_HD, EditLN_TT, EditSO_HANG, EDITTIEN_C, EDITTIEN_n, Editten_hs_UL, EditMA_KH_I, EditTen_KH_I, EditTen_GDV, EditDT_GDV, EditMa_HS_UL, EditSO_CT_bh, EditTen_bh, EditTien_ung, EditTen_CVDV, Editten_KH As New Cyber.Fill.CyberColumnGridView
    Dim Editma_LHBH_i, EditLoai_xe, EditNgay_BH, EditNgay_DH, EditSo_DH, EditSo_DT_GDV As New Cyber.Fill.CyberColumnGridView
    Dim EditChi_Phi_GDV, EditDoanh_Thu_GDV, EditLoi_Nhuan_GDV, EditSo_DH_CP, EditSo_Phieu_Thu, EditSo_Hoa_Don, EditHinh_Thuc_TT, EditDu_Chi_HH, EditSTT_REC_BH, EditTien_HH, EditSo_VAT, EditSo_Lo_Hang, EditSo_Cong_TT As New Cyber.Fill.CyberColumnGridView
    Dim EditNguoi_MG, EditDC_MG, EditDT_MG, EditCMT_MG, EditNoi_Cap_Cmt_Mg, Editis_GC, Editstt_rec0_BH, EditNOTE_I, Editso_dh_nk As New Cyber.Fill.CyberColumnGridView
    Dim EditNgay_Mua, EditSo_Luong, EditDvt, EditGia_NT, EditGhi_Chu_I, EditTien_nt_truoc, EditDoanh_Thu_sau_GDV As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
    Dim DtPHstru As New DataTable
#End Region

    Private Sub LDN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        '------------------------------
        V_GetStrus()
        '------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        GetRound()
        CmdNew.Focus()
        '--------------------------------------
        V_LoadNew(sender, e)
        L_Chuyen_Khoan(sender, e)
        '--------------------------------------
    End Sub
#Region "Load And Set And Default"
    Dim _Para_So_Ct_TBH As String = ""
    Dim _Para_Ma_HD_HDX As String = ""
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_So_Ct_TBH.Trim = "" And _Para_Ma_HD_HDX = "" Then Exit Sub
        If _Para_So_Ct_TBH <> "" Then

            V_New(sender, e)
            If Not M_Mode = "M" Then Exit Sub
            CbbMa_GD.SelectedValue = "1"
            L_Ma_GD(sender, e)

            TxtSo_Ct_TBH.Text = _Para_So_Ct_TBH

            V_So_Ct_TBH(sender, e)
            Return
        End If

        If _Para_Ma_HD_HDX <> "" Then

            V_New(sender, e)
            If Not M_Mode = "M" Then Exit Sub

            CbbMa_GD.SelectedValue = "4"
            L_Ma_GD(sender, e)

            TxtMa_Hd_H.Text = _Para_Ma_HD_HDX
            V_Ma_HD_H(New System.Object, New System.ComponentModel.CancelEventArgs)
            L_Ma_HD_H(New System.Object, New System.ComponentModel.CancelEventArgs)

            Return
        End If

    End Sub

    Private Sub V_GetStrus()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.PHLDN WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtPHstru = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
    End Sub
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

        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_Tien.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien.InputMask)

        TxtT_thue_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_thue_NT.InputMask)
        TxtT_Thue.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue.InputMask)

        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_TT_NT.InputMask)
        TxtT_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT.InputMask)
        V_LoadNam()
    End Sub
    Private Sub V_LoadNam()
        Dim tbNam, tbthang As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
        tbNam = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.cmbNam, tbNam, "Ma_nam", "Ten_nam", "")
        tbthang = DsTmp.Tables(1).Copy
        CyberFill.V_FillComBoxValue(Me.cmdthang, tbthang, "Ma_thang", "Ten_thang", "")
        cmbNam.Text = Year(Now.Date)
        cmdthang.Text = Month(Now.Date)
    End Sub
    Private Sub V_Ngay_DK()
        TxtNgay_DK.Value = DateAdd(DateInterval.Day, 10, TxtNgay_Ct.Value)

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
        _Para_So_Ct_TBH = M_Para(M_VT_PARA + 4).Trim
        _Para_Ma_HD_HDX = M_Para(M_VT_PARA + 5).Trim

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
        '--DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "' AND Acti = 1 ", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        Dim _Ma_GD As DataTable
        Dim DtMaGD As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadGD_LDN", M_Ma_Dvcs & "#" & M_User_Name)
        _Ma_GD = DtMaGD.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, _Ma_GD, "Ma_GD", "Ten_GD", "Ten_GD2")

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

        '---
        EditDien_Giaii.GetColumn(DetailGRV, "DIEN_GIAII")
        EditTien_NT.GetColumn(DetailGRV, "TIEN_NT")
        EditTien.GetColumn(DetailGRV, "TIEN")

        EditThue_NT.GetColumn(DetailGRV, "Thue_NT")
        EditThue.GetColumn(DetailGRV, "Thue")


        EditT_TT_NT.GetColumn(DetailGRV, "T_TT_NT")
        EditT_TT.GetColumn(DetailGRV, "T_TT")

        EditThue_Suat.GetColumn(DetailGRV, "Thue_Suat")
        EditMa_Thue.GetColumn(DetailGRV, "Ma_Thue")
        '---------------------------
        EditSo_Ro.GetColumn(DetailGRV, "So_Ro")

        EditMoi_Gioi.GetColumn(DetailGRV, "Moi_Gioi")
        EditNgay_HD.GetColumn(DetailGRV, "Ngay_HD")
        EditNgay_PT.GetColumn(DetailGRV, "Ngay_PT")
        EditTien_HD.GetColumn(DetailGRV, "Tien_HD")
        EditTien_PT.GetColumn(DetailGRV, "Tien_PT")


        EditMa_Vv_I.GetColumn(DetailGRV, "Ma_Vv_I")
        EditMa_phi_i.GetColumn(DetailGRV, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRV, "Ma_HD_I")
        EditTen_HD_I.GetColumn(DetailGRV, "Ten_HD_I")

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
        'EditSo_Ro.GetColumn(DetailGRV, "SO_RO")
        EditSo_VT.GetColumn(DetailGRV, "SO_VT")

        Editma_Db_I.GetColumn(DetailGRV, "Ma_Db_I")
        EditMa_Xe_I.GetColumn(DetailGRV, "MA_XE_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_TUYEN_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")

        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")
        EditSO_HD.GetColumn(DetailGRV, "sO_hd")
        EditLN_TT.GetColumn(DetailGRV, "ln_tt")
        EditSO_HANG.GetColumn(DetailGRV, "SO_HANG")
        EDITTIEN_C.GetColumn(DetailGRV, "TIEn_C")
        EDITTIEN_n.GetColumn(DetailGRV, "TIEN_N")
        EditMA_KH_I.GetColumn(DetailGRV, "Ma_kh_i")
        EditTen_KH_I.GetColumn(DetailGRV, "Ten_Kh_i")
        EditDT_GDV.GetColumn(DetailGRV, "DT_GDV")
        EditTen_GDV.GetColumn(DetailGRV, "Ten_GDV")
        EditTen_bh.GetColumn(DetailGRV, "Ten_bh")
        EditSO_CT_bh.GetColumn(DetailGRV, "So_ct_bh")
        EditTien_ung.GetColumn(DetailGRV, "Tien_ung")
        EditMa_HS_UL.GetColumn(DetailGRV, "Ma_HS_UL")
        Editten_hs_UL.GetColumn(DetailGRV, "ten_hs_UL")

        EditTen_CVDV.GetColumn(DetailGRV, "ten_cvdv")
        Editten_KH.GetColumn(DetailGRV, "ten_KH")
        'moi gioi
        EditNguoi_MG.GetColumn(DetailGRV, "Nguoi_MG")
        EditDC_MG.GetColumn(DetailGRV, "DC_MG")
        EditDT_MG.GetColumn(DetailGRV, "DT_MG")
        EditCMT_MG.GetColumn(DetailGRV, "CMT_MG")
        EditNoi_Cap_Cmt_Mg.GetColumn(DetailGRV, "Noi_Cap_Cmt_Mg")

        '------------------------
        EditLoai_xe.GetColumn(DetailGRV, "Loai_xe")
        EditNgay_BH.GetColumn(DetailGRV, "Ngay_BH")
        Editma_LHBH_i.GetColumn(DetailGRV, "ma_LHBH_i")
        EditSo_DH.GetColumn(DetailGRV, "So_DH")
        EditSo_DH_CP.GetColumn(DetailGRV, "So_DH_CP")
        EditNgay_DH.GetColumn(DetailGRV, "Ngay_DH")
        EditSo_DT_GDV.GetColumn(DetailGRV, "So_DT_GDV")

        EditChi_Phi_GDV.GetColumn(DetailGRV, "Chi_Phi_GDV")
        EditDoanh_Thu_GDV.GetColumn(DetailGRV, "Doanh_Thu_GDV")
        EditLoi_Nhuan_GDV.GetColumn(DetailGRV, "Loi_Nhuan_GDV")
        EditSo_Phieu_Thu.GetColumn(DetailGRV, "So_Phieu_Thu")
        EditSo_Hoa_Don.GetColumn(DetailGRV, "So_Hoa_Don")
        EditHinh_Thuc_TT.GetColumn(DetailGRV, "Hinh_Thuc_TT")
        EditDu_Chi_HH.GetColumn(DetailGRV, "Du_Chi_HH")
        EditSTT_REC_BH.GetColumn(DetailGRV, "STT_REC_BH")
        EditNOTE_I.GetColumn(DetailGRV, "NOTE_I")
        EditTien_HH.GetColumn(DetailGRV, "Tien_HH")
        EditSo_VAT.GetColumn(DetailGRV, "So_VAT")
        EditSo_Lo_Hang.GetColumn(DetailGRV, "So_Lo_Hang")
        EditSo_Cong_TT.GetColumn(DetailGRV, "So_Cong_TT")
        Editis_GC.GetColumn(DetailGRV, "is_GC")
        Editstt_rec0_BH.GetColumn(DetailGRV, "stt_rec0_BH")
        Editso_dh_nk.GetColumn(DetailGRV, "so_dh_nk")
        'hieulv
        EditNgay_Mua.GetColumn(DetailGRV, "Ngay_Mua")
        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditDvt.GetColumn(DetailGRV, "Dvt")
        EditGia_NT.GetColumn(DetailGRV, "Gia_NT")
        EditGhi_Chu_I.GetColumn(DetailGRV, "Ghi_Chu_I")
        EditTien_nt_truoc.GetColumn(DetailGRV, "Tien_nt_truoc")

        EditDoanh_Thu_sau_GDV.GetColumn(DetailGRV, "Doanh_Thu_sau_GDV")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
        End Select
        TxtMa_Dnchi.Focus()
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
        AddHandler ChkIs_CK.CheckedChanged, AddressOf L_Chuyen_Khoan
        '----------------------------------------------------------------------------------------------------------
        AddHandler CmdE_Mail_KH.Click, AddressOf V_E_MaiL_KH
        AddHandler CmdE_Mail_Duyet.Click, AddressOf V_E_Mail_Duyet
        AddHandler CmdXem_Duyet.Click, AddressOf V_Xem_Duyet
        AddHandler CmdChon_Lenh.Click, AddressOf V_Chon_Lenh

    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub L_Chuyen_Khoan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkIs_CK.Checked = False Then
            LabSTK.Visible = False
            LabNgan_hang.Visible = False
            TxtMa_NH.Visible = False
            TxtTen_NH.Visible = False
            TxtSo_TK.Visible = False
            TxtTen_Nguoi_Nhan.Visible = False
            LabTen_Nguoi_Nhan.Visible = False
        Else
            LabSTK.Visible = True
            LabNgan_hang.Visible = True
            TxtMa_NH.Visible = True
            TxtTen_NH.Visible = True
            TxtSo_TK.Visible = True
            TxtTen_Nguoi_Nhan.Visible = True
            LabTen_Nguoi_Nhan.Visible = True
        End If
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia
        '--Dnchi
        AddHandler TxtMa_Dnchi.CyberValiting, AddressOf V_Ma_Dnchi
        AddHandler TxtMa_Dnchi.CyberLeave, AddressOf L_Ma_Dnchi
        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        '--SODN
        'AddHandler TxtSoDNTT_OLD.CyberValiting, AddressOf V_Ma_DNTT
        'AddHandler TxtSoDNTT_OLD.CyberLeave, AddressOf L_Ma_DNTT
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So
        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT
        '--Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberLeave, AddressOf L_Ma_BP_H
        '--Ma_HS_H
        AddHandler txtMa_HS_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler txtMa_HS_H.CyberLeave, AddressOf L_Ma_HS_H

        AddHandler TxtMa_Hd_H.CyberValiting, AddressOf V_Ma_HD_H
        AddHandler TxtMa_Hd_H.CyberLeave, AddressOf L_Ma_HD_H

        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_Bh
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_Bh

        AddHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH

        AddHandler TxtTL_MG.Leave, AddressOf L_TL_MG
        AddHandler TxtSo_Ct_TBH.Leave, AddressOf V_So_Ct_TBH

        AddHandler CmdOK.Click, AddressOf V_loadNV
        AddHandler CmdLoc.Click, AddressOf V_load_HU
        AddHandler TxtMa_NH.CyberValiting, AddressOf V_Ma_NH
        AddHandler TxtMa_NH.CyberLeave, AddressOf L_Ma_NH
        AddHandler CmdE_Mail_KH.Click, AddressOf V_E_MaiL_KH

    End Sub
    Private Sub V_AddHandler_Detail()
        'hieulv
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_NT.Column Is Nothing Then AddHandler EditGia_NT.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditTien_NT.Column Is Nothing Then AddHandler EditTien_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditThue_Suat.Column Is Nothing Then AddHandler EditThue_Suat.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue_NT.Column Is Nothing Then AddHandler EditThue_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThue.Column Is Nothing Then AddHandler EditThue.EditColumn.Leave, AddressOf L_Tinh_Toan


        If Not EditT_TT_NT.Column Is Nothing Then AddHandler EditT_TT_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditT_TT.Column Is Nothing Then AddHandler EditT_TT.EditColumn.Leave, AddressOf L_Tinh_Toan

        EditMa_Thue.V_ActiLookUpColumn(AddressOf V_Ma_Thue, AddressOf L_Ma_Thue)


        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii

        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_Sp_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_ku_I.V_ActiLookUpColumn(AddressOf V_Ma_KU_i, AddressOf L_Ma_KU_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_HS_UL.V_ActiLookUpColumn(AddressOf V_Ma_HS_UL, AddressOf L_Ma_HS_UL)

        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        'EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)
        Editma_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_i, AddressOf L_Ma_Db_i)
        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_i, AddressOf L_Ma_Xe_i)
        EditMa_KX_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
        EditMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_Ma_Tuyen_i, AddressOf L_Ma_Tuyen_i)
        EditMa_Ts.V_ActiLookUpColumn(AddressOf V_Ma_Ts, AddressOf L_Ma_Ts)
        EditMa_Cc.V_ActiLookUpColumn(AddressOf V_Ma_Cc, AddressOf L_Ma_Cc)
        EditMA_KH_I.V_ActiLookUpColumn(AddressOf V_Ma_kh_i, AddressOf L_Ma_kh_i)
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
            EditTien.Visible = False
            EditThue.Visible = False
            EditT_TT.Visible = False

            TxtT_TT.Visible = False
            TxtT_Thue.Visible = False
            TxtT_Tien.Visible = False

        Else
            EditTien.Visible = True
            EditThue.Visible = True
            EditT_TT.Visible = True

            TxtT_TT.Visible = True
            TxtT_Thue.Visible = True
            TxtT_Tien.Visible = True
        End If

        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
    End Sub
    Private Sub VisibleColumnMa_GD()
        Dim _Ma_GD As String = "1"
        Try
            _Ma_GD = CbbMa_GD.SelectedValue.ToString.Trim.ToUpper
        Catch ex As Exception

        End Try
        '
        LabMa_HD_H.Visible = False
        TxtMa_Hd_H.Visible = False
        txtTen_Hd_H.Visible = False
        LabMa_BH.Visible = False
        TxtMa_BH.Visible = False
        TxtTen_BH.Visible = False
        LabTL_MG.Visible = False
        Lab_PTTL_MG.Visible = False
        TxtTL_MG.Visible = False
        CmdChon_Lenh.Visible = False
        LabSo_Ct_TBH.Visible = False
        TxtSo_Ct_TBH.Visible = False
        TxtMa_LHBH.Visible = False
        TxtTen_LHBH.Visible = False
        LabLHBH.Visible = False

        ChkGia_Cong.Visible = False
        LabND_CK.Visible = False
        TxtND_CK.Visible = False
        TxtSo_DT_GDV.Visible = False
        LabSo_DT_GDV.Visible = False
        cmbNam.Visible = False
        cmdthang.Visible = False
        Labelthang.Visible = False
        Labelnam.Visible = False
        'detail
        EditSo_Ro.Visible = False
        EditMa_HD_I.Visible = False
        EditTen_HD_I.Visible = False
        EditMa_TD4_I.Visible = False

        EditMoi_Gioi.Visible = False
        EditSo_Ro.Visible = False
        EditMoi_Gioi.Visible = False
        EditNgay_HD.Visible = False
        EditTien_HD.Visible = False
        EditNgay_PT.Visible = False
        EditTien_PT.Visible = False
        EditTen_HD_I.Visible = False

        EditMa_TD3_I.Visible = False
        EditSO_HD.Visible = False
        EditLN_TT.Visible = False
        EditSO_HANG.Visible = False
        EDITTIEN_C.Visible = False
        EDITTIEN_n.Visible = False

        EditMA_KH_I.Visible = False
        EditTen_KH_I.Visible = False
        EditTen_GDV.Visible = False
        EditDT_GDV.Visible = False
        EditSO_CT_bh.Visible = False

        EditTen_CVDV.Visible = False
        Editten_KH.Visible = False
        EditMa_Xe_I.Visible = False
        EditTen_bh.Visible = False
        EditThue_Suat.Visible = False
        EditThue_NT.Visible = False

        EditMa_HS_UL.Visible = False
        Editten_hs_UL.Visible = False
        EditTien_ung.Visible = False
        Editten_hs_UL.Visible = False

        EditMa_Xe_I.Visible = False

        Editma_LHBH_i.Visible = False
        EditLoai_xe.Visible = False
        EditNgay_BH.Visible = False
        EditNgay_DH.Visible = False
        EditSo_DH.Visible = False
        EditSo_DH_CP.Visible = False
        EditSo_DT_GDV.Visible = False
        EditSO_HD.Visible = False

        EditChi_Phi_GDV.Visible = False
        EditDoanh_Thu_GDV.Visible = False
        EditLoi_Nhuan_GDV.Visible = False
        EditSo_Phieu_Thu.Visible = False
        EditSo_Hoa_Don.Visible = False
        EditHinh_Thuc_TT.Visible = False
        EditDu_Chi_HH.Visible = False
        EditSTT_REC_BH.Visible = False
        EditTien_HH.Visible = False
        EditNOTE_I.Visible = False

        EditSo_VAT.Visible = False
        EditSo_Lo_Hang.Visible = False
        EditSo_Cong_TT.Visible = False
        'moi gioi
        EditNguoi_MG.Visible = False
        EditDC_MG.Visible = False
        EditDT_MG.Visible = False
        EditCMT_MG.Visible = False
        EditNoi_Cap_Cmt_Mg.Visible = False
        Editis_GC.Visible = False
        Editstt_rec0_BH.Visible = False
        Editso_dh_nk.Visible = False
        '
        EditNgay_Mua.Visible = False
        EditSo_Luong.Visible = False
        EditDvt.Visible = False
        EditGia_NT.Visible = False
        EditGhi_Chu_I.Visible = False
        EditTien_nt_truoc.Visible = False
        EditDoanh_Thu_sau_GDV.Visible = False
        ' Set Visible của control theo thủ tục
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SetVisible_LDN", _Ma_GD & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        '
        For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
            'moi_gioi
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNguoi_MG" Then EditNguoi_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDC_MG" Then EditDC_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDT_MG" Then EditDT_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditCMT_MG" Then EditCMT_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNoi_Cap_Cmt_Mg" Then EditNoi_Cap_Cmt_Mg.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            '
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabMa_HD_H" Then LabMa_HD_H.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtMa_Hd_H" Then TxtMa_Hd_H.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "txtTen_Hd_H" Then txtTen_Hd_H.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabMa_BH" Then LabMa_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtMa_BH" Then TxtMa_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtTen_BH" Then TxtTen_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabTL_MG" Then LabTL_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Lab_PTTL_MG" Then Lab_PTTL_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtTL_MG" Then TxtTL_MG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "CmdChon_Lenh" Then CmdChon_Lenh.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabSo_Ct_TBH" Then LabSo_Ct_TBH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtSo_Ct_TBH" Then TxtSo_Ct_TBH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtTen_LHBH" Then TxtTen_LHBH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtMa_LHBH" Then TxtMa_LHBH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabLHBH" Then LabLHBH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabSTK" Then LabSTK.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabNgan_hang" Then LabNgan_hang.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtSo_TK" Then TxtSo_TK.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtMa_NH" Then TxtMa_NH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtTen_NH" Then TxtTen_NH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtTen_Nguoi_Nhan" Then TxtTen_Nguoi_Nhan.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabTen_Nguoi_Nhan" Then LabTen_Nguoi_Nhan.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")



            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "ChkGia_Cong" Then ChkGia_Cong.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabND_CK" Then LabND_CK.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtND_CK" Then TxtND_CK.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "TxtSo_DT_GDV" Then TxtSo_DT_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "LabSo_DT_GDV" Then LabSo_DT_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "cmdthang" Then cmdthang.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "cmbNam" Then cmbNam.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Labelnam" Then Labelnam.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Labelthang" Then Labelthang.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            'detail
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Ro" Then EditSo_Ro.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_HD_I" Then EditMa_HD_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_HD_I" Then EditTen_HD_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMoi_Gioi" Then EditMoi_Gioi.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Ro" Then EditSo_Ro.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMoi_Gioi" Then EditMoi_Gioi.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNgay_HD" Then EditNgay_HD.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTien_HD" Then EditTien_HD.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNgay_PT" Then EditNgay_PT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTien_PT" Then EditTien_PT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_HD_I" Then EditTen_HD_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_TD3_I" Then EditMa_TD3_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSO_HD" Then EditSO_HD.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditLN_TT" Then EditLN_TT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSO_HANG" Then EditSO_HANG.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EDITTIEN_C" Then EDITTIEN_C.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EDITTIEN_n" Then EDITTIEN_n.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMA_KH_I" Then EditMA_KH_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_KH_I" Then EditTen_KH_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_GDV" Then EditTen_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDT_GDV" Then EditDT_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSO_CT_bh" Then EditSO_CT_bh.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_CVDV" Then EditTen_CVDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editten_KH" Then Editten_KH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_Xe_I" Then EditMa_Xe_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTen_bh" Then EditTen_bh.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditThue_Suat" Then EditThue_Suat.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditThue_NT" Then EditThue_NT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_HS_UL" Then EditMa_HS_UL.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editten_hs_UL" Then Editten_hs_UL.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTien_ung" Then EditTien_ung.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editten_hs_UL" Then Editten_hs_UL.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_Xe_I" Then EditMa_Xe_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDien_Giaii" Then EditDien_Giaii.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNgay_BH" Then EditNgay_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditLoai_xe" Then EditLoai_xe.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editma_LHBH_i" Then Editma_LHBH_i.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSO_DH" Then EditSo_DH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_DH_CP" Then EditSo_DH_CP.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNgay_DH" Then EditNgay_DH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_DT_GDV" Then EditSo_DT_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditChi_Phi_GDV" Then EditChi_Phi_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDoanh_Thu_GDV" Then EditDoanh_Thu_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDoanh_Thu_sau_GDV" Then EditDoanh_Thu_sau_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditLoi_Nhuan_GDV" Then EditLoi_Nhuan_GDV.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Phieu_Thu" Then EditSo_Phieu_Thu.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Hoa_Don" Then EditSo_Hoa_Don.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditHinh_Thuc_TT" Then EditHinh_Thuc_TT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDu_Chi_HH" Then EditDu_Chi_HH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSTT_REC_BH" Then EditSTT_REC_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTien_HH" Then EditTien_HH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Cong_TT" Then EditSo_Cong_TT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_VAT" Then EditSo_VAT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Lo_Hang" Then EditSo_Lo_Hang.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditMa_TD4_I" Then EditMa_TD4_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editis_GC" Then Editis_GC.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editstt_rec0_BH" Then Editstt_rec0_BH.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNOTE_I" Then EditNOTE_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "Editso_dh_nk" Then Editso_dh_nk.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            'hieulv
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditNgay_Mua" Then EditNgay_Mua.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditSo_Luong" Then EditSo_Luong.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditDvt" Then EditDvt.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditGia_NT" Then EditGia_NT.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditGhi_Chu_I" Then EditGhi_Chu_I.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")
            If DsTmp.Tables(0).Rows(i).Item("Ten_Control") = "EditTien_nt_truoc" Then EditTien_nt_truoc.Visible = DsTmp.Tables(0).Rows(i).Item("IsVisible")

        Next


        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
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
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()

        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
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
            '--If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then txtSo_ct.ReadOnly = True Else txtSo_ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True

        If M_Mode = "S" Then TxtMa_Dnchi.Enabled = False
        If M_Mode = "M" Then TxtMa_Dnchi.Enabled = True

        '-- If M_Mode = "S" Then TxtNgay_Ct.Enabled = False
        If M_Mode = "M" Then TxtNgay_Ct.Enabled = True

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
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And txtSo_ct.Text.Trim <> "" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
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
    Private Sub V_loadNV_Old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtNgay_Ct.Value
        Dim ma_gd As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim StrField As String = ""
        Dim StrValue As String = ""
        CyberSmodb.GetValueControler(Me, StrField, StrValue)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetData_LDN", StrField & "#" & StrValue & "#" & ma_gd & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & Dt1.ToString("yyyyMMdd") & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next

        'them phan check status 
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.SysVar, Me.Lan) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        '
        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailTmp)
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_loadNV(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Ma_KH As String = TxtMa_Kh.Text
        Dim _Ma_BH As String = TxtMa_BH.Text
        Dim _Ma_LHBH As String = TxtMa_LHBH.Text
        Dim _Gia_Cong As Boolean = ChkGia_Cong.Checked
        Dim _Thang As Integer = cmdthang.SelectedValue
        Dim _Nam As Integer = cmbNam.SelectedValue

        Dim frm As New FrmLocLDN
        frm._Ds_LoolUp = DsLookup
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Sysvar = osysvar
        frm.AppConn = AppConn
        frm.CyberSmlib = CyberSmlib
        frm.CyberSupport = CyberSupport
        frm.CyberFill = CyberFill
        frm.CyberSmlistSys = CyberSmlistSys
        frm.CyberSmodb = CyberSmodb
        frm.CyberExport = Nothing
        frm.CyberVoucher = CyberVoucher
        frm.CyberLoading = CyberLoading
        frm.ShowInTaskbar = False
        frm.Stt_rec = M_Stt_Rec
        frm.Ma_Ct = M_Ma_CT
        frm.Mode = M_Mode
        frm.Ma_KH = _Ma_KH
        frm.Ma_BH = _Ma_BH
        frm.Ma_LHBH = _Ma_LHBH
        frm.Gia_Cong = _Gia_Cong
        frm.nam = _Nam
        frm.thang = _Thang

        frm.Ma_GD = CbbMa_GD.SelectedValue.ToString.Trim
        frm.ShowDialog()
        If Not frm.Save_OK Then Exit Sub
        Dim Dt As DataTable = frm.Master_Return

        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(Dt, Dt_DetailTmp)

        Dv_DetailTmp.Table.AcceptChanges()
        DetailGRV.UpdateCurrentRow()
        UpdateList()

    End Sub

    Private Sub V_load_Hu(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Frm As New ROXPTFilter
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.SysVar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        Dim _strParameterStore As String = Frm.Tag.ToString.Trim
        Dim _Stt_rec As String = ""

        Dim _Cp_name As String = "CP_ROLDNFilter"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _Cp_name, "1#" + _strParameterStore)

        Dim _Dt_master As DataTable = DsTmp.Tables(0).Copy
        Dim _Dt_Detail As DataTable = DsTmp.Tables(1).Copy
        Dim _Dt_masterH As DataTable = DsTmp.Tables(2).Copy
        Dim _Dt_DetailH As DataTable = DsTmp.Tables(3).Copy

        Dim _Dv_master As DataView = New DataView(_Dt_master)
        Dim _Dv_Detail As DataView = New DataView(_Dt_Detail)
        Dim _Dv_masterH As DataView = New DataView(_Dt_masterH)
        Dim _Dv_DetailH As DataView = New DataView(_Dt_DetailH)

        If _Dt_master.Rows.Count <= 0 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        _Stt_rec = _Dv_master.Item(0).Item("Stt_Rec").ToString.Trim

        Dim FrmX As New ROXPTView
        '------------------------------------------------
        FrmX.strLoc = "0#" + _strParameterStore
        FrmX.Cp_Loc = _Cp_name
        FrmX.Dt_Master = _Dt_master
        FrmX.Dt_Detail = _Dt_Detail
        FrmX.Dt_MasterH = _Dt_masterH
        FrmX.Dt_DetailH = _Dt_DetailH
        FrmX.Title = "Tìm hoàn ứng cho đề nghị"
        FrmX.Stt_Rec = _Stt_rec
        '-------------------------------------------------
        FrmX.Lan = M_LAN
        FrmX.Para = Me.Para
        FrmX.Sysvar = Me.SysVar
        FrmX.AppConn = AppConn
        FrmX.CyberSmlib = CyberSmlib
        FrmX.CyberSupport = CyberSupport
        FrmX.CyberFill = CyberFill
        FrmX.CyberSmlistSys = CyberSmlistSys
        FrmX.CyberSmodb = CyberSmodb
        FrmX.CyberExport = Nothing
        FrmX.CyberVoucher = CyberVoucher
        FrmX.CyberLoading = CyberLoading
        'FrmX.ShowInTaskbar = False
        FrmX.ShowDialog()

        If Not Frm.Save_OK Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dim _Dr_View_Return As DataRowView = FrmX.Dr_View_Return
        If _Dr_View_Return Is Nothing Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If _Dr_View_Return.DataView.Table.Columns.Contains("So_ct") Then
            TxtSoDNTT_OLD.Text = _Dr_View_Return.Item("So_ct").ToString.Trim
            L_So_Ro(sender, e)
        End If

        DsTmp.Dispose()

    End Sub

    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "ma_kh", "DMKH", "1=1", "1=1")
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
            TxtMa_NH.Text = DrReturn.Item("Ma_NH")
            TxtTen_NH.Text = DrReturn.Item("Ten_NH")
            TxtSo_TK.Text = DrReturn.Item("so_tk")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""
            TxtMa_NH.Text = ""
            TxtTen_NH.Text = ""
            TxtSo_TK.Text = ""

        End If
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            TxtDia_Chi.Text = ""
            TxtMa_NH.Text = ""
            TxtTen_NH.Text = ""
            TxtSo_TK.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "SODNTT"
    'Private Sub V_Ma_DNTT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    TxtSoDNTT_OLD.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "so_ct", "DmSoDNTT", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_DNTT(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    If TxtSoDNTT_OLD.Text = "" Then
    '        TxtTen_kh.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = TxtSoDNTT_OLD.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtSoDNTT_OLD.Text = DrReturn.Item("so_ct")
    '    Else
    '        TxtSoDNTT_OLD.Text = ""

    '    End If
    '    If TxtSoDNTT_OLD.Text = "" Then
    '        Exit Sub
    '    End If
    'End Sub
#End Region
#Region "Valid --- Ma_Bh"
    Private Sub V_Ma_Bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Bh", "DmBh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_Bh")
            TxtTen_BH.Text = DrReturn.Item("Ten_Bh")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
    Private Sub V_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_LHBH", "DmLHBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHBH.Text = DrReturn.Item("Ma_LHBh")
            TxtTen_LHBH.Text = DrReturn.Item("Ten_LHBh")
        Else
            TxtMa_LHBH.Text = ""
            TxtTen_LHBH.Text = ""
        End If
    End Sub

    Private Sub V_Ma_NH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_NH", "DmNhTraGop", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NH.Text = DrReturn.Item("Ma_NH")
            TxtTen_NH.Text = DrReturn.Item("Ten_NH")
        Else
            TxtMa_NH.Text = ""
            TxtTen_NH.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HD_H"
    Private Sub V_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Hd_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_hd", "Dmhd", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hd_H.Text = "" Then
            txtTen_Hd_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hd_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hd_H.Text = DrReturn.Item("Ma_hd")
            txtTen_Hd_H.Text = DrReturn.Item("Ten_hd")
        End If
        If Not TxtMa_Hd_H.Text.Trim = "" Then V_SetMa_HD_I()
    End Sub
#End Region
#Region "Valid --- Ma_Dnchi"
    Private Sub V_Ma_Dnchi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Dnchi.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Dnchi", "DmDnchi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Dnchi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Dnchi.Text = "" Then
            TxtTen_DnChi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Dnchi.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Dnchi.Text = DrReturn.Item("Ma_Dnchi")
            TxtTen_DnChi.Text = DrReturn.Item("Ten_Dnchi")

        Else
            TxtMa_Dnchi.Text = ""
            TxtTen_DnChi.Text = ""

        End If
        If TxtMa_Dnchi.Text = "" Then
            TxtTen_DnChi.Text = ""
            Exit Sub
        End If
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
#Region "Lenh/SO/Po/Ro/Vt"
    Private Sub L_Lenh_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_SO.Text = CyberVoucher.V_GetSo_SO(M_Ma_CT, CbbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_SO.Text, TxtMa_Dvcs.Text)

    End Sub
    Private Sub L_Lenh_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_PO.Text = CyberVoucher.V_GetSo_PO(M_Ma_CT, CbbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_PO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_RO.Text = CyberVoucher.V_GetSo_RO(M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtLenh_RO.Text, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_Lenh_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtLenh_Vt.Text = CyberVoucher.V_GetSo_VT(M_Ma_CT, CbbMa_GD.SelectedValue, CbbMa_Post.SelectedValue, _Dt, TxtLenh_Vt.Text, TxtMa_Dvcs.Text)
    End Sub
#End Region
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Thue", "DMThue", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)

    End Sub
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Thue") = ""
            Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = 0
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Thue") = DrReturn("Ma_Thue").ToString.Trim
            Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = DrReturn("Thue_Suat")
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()
        DetailGRV.UpdateCurrentRow()
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub UpdateList()
        Dim nT_Tien_NT As Decimal = 0
        Dim nT_Tien As Decimal = 0

        Dim nT_Thue_NT As Decimal = 0
        Dim nT_Thue As Decimal = 0

        Dim nT_TT_NT As Decimal = 0
        Dim nT_TT As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_Tien_NT = nT_Tien_NT + Dv_DetailTmp.Item(iRow).Item("Tien_NT")
            nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien_NT")

            nT_Thue_NT = nT_Thue_NT + Dv_DetailTmp.Item(iRow).Item("Thue_NT")
            nT_Thue = nT_Thue + Dv_DetailTmp.Item(iRow).Item("Tien_NT")

            nT_TT_NT = nT_TT_NT + Dv_DetailTmp.Item(iRow).Item("Tien_NT") + Dv_DetailTmp.Item(iRow).Item("Thue_NT")
            nT_TT = nT_TT + Dv_DetailTmp.Item(iRow).Item("Tien_NT") + Dv_DetailTmp.Item(iRow).Item("Thue_NT")
        Next

        'nT_TT = nT_Tien + nT_Thue
        'nT_TT_NT = nT_Tien_NT + nT_Thue_NT

        TxtT_Tien_NT.Double = nT_Tien_NT
        TxtT_Tien.Double = nT_Tien

        TxtT_thue_NT.Double = nT_Thue_NT
        TxtT_Thue.Double = nT_Thue

        TxtT_TT_NT.Double = nT_TT_NT
        TxtT_TT.Double = nT_TT

        TxtT_TT_NT.Refresh()
        TxtT_TT.Refresh()
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------------------------------'
        '--- Tinh toan
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        'hieulv

        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_NT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT"), M_R_TIEN)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If


        If Dv_DetailTmp.Item(iRow).Item("Tien_PT") * TxtTL_MG.Double <> 0 And (_Ma_GD = "1" Or _Ma_GD = "2") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_NT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_PT") * TxtTL_MG.Double / 100, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        '--------------------------------------------------------------------------------------------------------'
        '--- Tinh toan

        If Dv_DetailTmp.Item(iRow).Item("Tien_NT") * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Thue_NT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_NT") * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") / 100, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '--------------------------------------------------------------------------------------------------------'

        If Not (Dv_DetailTmp.Item(iRow).Item("Tien_NT") = 0 And Dv_DetailTmp.Item(iRow).Item("Thue_NT") = 0) Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("T_TT_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_NT") + Dv_DetailTmp.Item(iRow).Item("Thue_NT")
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If


        '--------------------------------------------------------------------------------------------------------'
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If nTy_Gia <> 1 Then
            Dv_DetailTmp.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_NT") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Thue") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Thue_NT") * nTy_Gia, M_R_TIEN)
        Else
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien_NT")
            Dv_DetailTmp.Item(iRow).Item("Thue") = Dv_DetailTmp.Item(iRow).Item("Thue_NT")
        End If

        '--------------------------------------------------------------------------------------------------------'
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("T_TT") = Dv_DetailTmp.Item(iRow).Item("Tien") + Dv_DetailTmp.Item(iRow).Item("Thue")
        Dv_DetailTmp.Item(iRow).EndEdit()
        '--------------------------------------------------------------------------------------------------------'

        Dv_DetailTmp.Item(iRow).EndEdit()
        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub

    Private Sub L_TL_MG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtTL_MG.Double = 0 Then Return
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
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
    Private Sub V_Tk_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_I(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_I(ByVal sender As System.Object, ByVal e As System.EventArgs)

        DrReturn = CyberSupport.L_Tk_I(M_Mode, M_Ma_CT, sender, DetailGRV)
        If DrReturn Is Nothing Then
            Dim iRow As Integer = -1
            iRow = DetailGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("TK_I").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
        End If
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
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = txtDien_giai.Text
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        DetailGRV.ShowEditor()

    End Sub
#End Region
#Region "Vat tu kho - "
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Ma_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
#Region "So_So/So_PO/So_RO/So_VT"
    Private Sub L_So_So(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_SO(Dv_DetailTmp, iRow, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_So_Po(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_PO(Dv_DetailTmp, iRow, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        'CyberVoucher.V_GetSo_RO(Dv_DetailTmp, iRow, M_Ma_CT, "S", M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
        CyberVoucher.V_GetSo_RO(Dv_DetailTmp, iRow, M_Ma_CT, "S", M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
        V_GetDetailFromHDS(iRow)
    End Sub
    Private Sub L_So_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        CyberVoucher.V_GetSo_VT(Dv_DetailTmp, iRow, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Ngay_Ct, TxtMa_Dvcs.Text)
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
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_GetDetailMa_HD(iRow)

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
    Private Sub V_Ma_Hs_UL(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DMhs", "1=1", "Ma_bp = '" + TxtMa_Bp_H.Text + "'", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub

    Private Sub L_Ma_Hs_UL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        Dim iRow As Integer = -1

        If DrReturn Is Nothing Then
            Exit Sub
        End If
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("ma_hs_UL") = DrReturn("ma_hs")
        Dv_DetailTmp.Item(iRow).Item("ten_hs_UL") = DrReturn("ten_hs")


        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
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
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_GetDetailMa_Td3(iRow)
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

        If Not txtSo_ct.Text.Trim = "" Then
            V_Ngay_DK()
            Exit Sub
        End If
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        V_Ngay_DK()
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
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
        DetailGRV.PostEditor()
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
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, txtSo_ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster)}, {M_Ct, M_Ph}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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
                drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
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
        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,TEN_KH", "TEN_TK_I,TEN_KH_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, txtSo_ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
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
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        '---------------------------------------------------------------------------------
        nCount = Dt_DetailTmp.Rows.Count
        'For iRow = nCount - 1 To 0 Step -1
        'If _Ma_GD = "1" Or _Ma_GD = "2" Then
        '    If Dt_DetailTmp.Rows(iRow).Item("Stt_Rec_HD").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("Stt_Rec_PT").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("So_Ro").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("Tien_NT") = 0 Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'End If

        'If _Ma_GD = "3" Then
        '    If Dt_DetailTmp.Rows(iRow).Item("Stt_Rec_HD").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("Stt_Rec_PT").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("So_Ro").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("Tien_NT") = 0 Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'End If


        'If _Ma_GD = "7" Or _Ma_GD = "8" Then
        '    If Dt_DetailTmp.Rows(iRow).Item("Dien_Giaii").ToString.Trim = "" Or Dt_DetailTmp.Rows(iRow).Item("Tien_NT") = 0 Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'End If
        'If _Ma_GD = "89" Then
        '    If Dt_DetailTmp.Rows(iRow).Item("Ma_xe_i") = "" Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'End If
        'If _Ma_GD = "90" Then
        '    If Dt_DetailTmp.Rows(iRow).Item("Ma_hs_UL") = "" Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'End If
        'Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)

            If Dt_DetailTmp.Columns.Contains("Ma_Bp_I") Then If TxtMa_Bp_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Bp_I") = TxtMa_Bp_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_HS_I") Then If txtMa_HS_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HS_I") = txtMa_HS_H.Text.Trim
            If Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I").ToString = "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I") = TxtMa_Hd_H.Text.Trim


            If Dt_DetailTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_GD") Then Dt_DetailTmp.Rows(iRow).Item("Ma_GD") = _Ma_GD
            'Select Case _Ma_GD
            '    Case "1", "2", "3" '---De nghi theo R/O
            '        Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I") = ""

            '    Case Else
            '        Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I") = ""
            '        Dt_DetailTmp.Rows(iRow).Item("So_RO") = ""
            '        Dt_DetailTmp.Rows(iRow).Item("Stt_rec_PT") = ""
            '        Dt_DetailTmp.Rows(iRow).Item("Stt_Rec_HD") = ""
            '        Dt_DetailTmp.Rows(iRow).Item("Ngay_PT") = New Date(1900, 1, 1, 0, 0, 0, 0)
            '        Dt_DetailTmp.Rows(iRow).Item("Ngay_HD") = New Date(1900, 1, 1, 0, 0, 0, 0)
            'End Select
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        ''---------------------------------------------------------------------------------
        'nCount = Dt_DetailTmp.Rows.Count
        'For iRow = nCount - 1 To 0 Step -1
        '    Select Case _Ma_GD
        '        Case "1", "2"
        '            If Dt_DetailTmp.Rows(iRow).Item("So_RO").ToString.Trim = "" Or (Dt_DetailTmp.Rows(iRow).Item("Tien_NT") = 0 And Dt_DetailTmp.Rows(iRow).Item("Thue_NT") = 0 And Dt_DetailTmp.Rows(iRow).Item("T_TT_NT") = 0) Then
        '                Dt_DetailTmp.Rows(iRow).Delete()
        '                Dt_DetailTmp.AcceptChanges()
        '            End If

        '        Case "89"
        '            If Dt_DetailTmp.Rows(iRow).Item("Ma_XE_I").ToString.Trim = "" Then
        '                Dt_DetailTmp.Rows(iRow).Delete()
        '                Dt_DetailTmp.AcceptChanges()
        '            End If
        '        Case "90"
        '            If Dt_DetailTmp.Rows(iRow).Item("Ma_hs_UL").ToString.Trim = "" Then
        '                Dt_DetailTmp.Rows(iRow).Delete()
        '                Dt_DetailTmp.AcceptChanges()
        '            End If
        '        Case Else
        '            If Dt_DetailTmp.Rows(iRow).Item("Tien_NT") = 0 Then
        '                Dt_DetailTmp.Rows(iRow).Delete()
        '                Dt_DetailTmp.AcceptChanges()
        '            End If
        '    End Select

        'Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        '---------------------------------------------------------------------------------

        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        '----------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------
        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        '-----------------------------------------------------------------------------------------------------
        Dim _DtPH As DataTable = DtPHstru.Clone
        Dim _DrPh As DataRow = _DtPH.NewRow
        _DrPh.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrPh)
        CyberSmodb.AddValueToRow(_DrPh, Me)
        If DtPHstru.Columns.Contains("Stt_Rec") Then _DrPh.Item("Stt_Rec") = M_Stt_Rec
        If DtPHstru.Columns.Contains("Ma_Ct") Then _DrPh.Item("Ma_Ct") = M_Ma_CT
        If DtPHstru.Columns.Contains("Ma_Dvcs") Then _DrPh.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrPh.EndEdit()
        _DtPH.Rows.Add(_DrPh)
        _DtPH.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsTmpSave As DataSet = CyberSmodb.V_ChkAndSaveVoucher(Mode, M_Stt_Rec, M_Ma_CT, _Ngay_Ct, TxtMa_Dvcs.Text, M_User_Name, {"PHLND", "CTLDN"}, {_DtPH, Dt_DetailTmp}, AppConn, osysvar, M_LAN, "", CyberSmlib, CyberSupport)
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-------------------------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
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
        ''-----------------------------------------------------------------------------------------------------
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
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
        If CbbMa_GD.SelectedValue.ToString.Trim = "1" Then
            Dim _Title As String = If(M_LAN = "V", "Chứng từ thanh toán theo hóa đơn không copy được", "Payment vouchers are invoiced not copy")
            MsgBox(_Title, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            Exit Sub '---KHong Copy thanh toan theo hoa don
        End If
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
        txtSo_ct.Text = _So_Ct_Copy.Trim
        V_Ngay_DK()
        V_LoadNam()
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
        If txtDien_giai.Text.Trim = "" Then txtDien_giai.Text = M_Dien_Giai
        TxtTL_MG.Double = 10

        V_New()
        CbbMa_Post.SelectedValue = "3"
        '
        txtMa_HS_H.Text = M_Ma_HS_H
        txtTen_HS_H.Text = M_Ten_HS_H
        TxtMa_Bp_H.Text = M_Ma_BP_H
        txtTen_BP_H.Text = M_Ten_BP_H
        V_Ngay_DK()
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

        If Not V_ChkDelete() Then Return

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
    Private Function V_ChkDelete() As Boolean
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkDeleteLDN", M_Stt_Rec + "#" + M_Ma_CT + "#" + M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, M_LAN)
        DsTmp.Dispose()
        Return _Return
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

        '------Khong cho them dong khi ma_Gd =1,2: Thu theo hoa don
        Dim _ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        If _ma_GD = "1" Or _ma_GD = "2" Then Return
        '------Khong cho them dong khi ma_Gd =1,2: Thu theo hoa don


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
        TxtT_Tien_NT.ReadOnly = True
        TxtT_Tien.ReadOnly = True

        TxtT_thue_NT.ReadOnly = True
        TxtT_Thue.ReadOnly = True

        TxtT_TT_NT.ReadOnly = True
        TxtT_TT.ReadOnly = True

        TxtTen_DnChi.ReadOnly = True
        TxtTen_DnChi.ReadOnly = True
    End Sub
#End Region
#Region "E Mail And Approval"
    '----------------------------------------------------------------------------------------------------------
    'AddHandler CmdE_Mail_KH.Click, AddressOf V_E_MaiL_KH
    'AddHandler CmdE_Mail_Duyet.Click, AddressOf V_E_MaiL_Duyet
    Private Sub V_E_MaiL_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _LoaiMail As String = "1"
        '---_LoaiMail = 0/ Xin phe duyet
        CyberSupport.V_SendEmailVoucher(AppConn, osysvar, M_Para, M_LAN, _LoaiMail, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, True, True, False)
    End Sub
    Private Sub V_E_MaiL_Duyet(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _LoaiMail As String = "0"
        '---_LoaiMail = 0/ Xin phe duyet
        CyberSupport.V_SendEmailVoucher(AppConn, osysvar, M_Para, M_LAN, _LoaiMail, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, False, False, True)
    End Sub

    Private Sub V_Xem_Duyet(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Return
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub


        ''CyberInput.
        Dim _StrFilter As String = M_Stt_Rec.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim
        Dim _Title As String = "Tình trạng duyệt đề nghị"
        Dim _So_Ro As String = ""
        Dim _Cp_name As String = "CP_LDNXemDuyet"

        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, osysvar, M_LAN, M_Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)


    End Sub
#End Region
#Region "Tính bảo hiểm/Tính Hợp đồng"
    Private Sub V_Chon_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        Dim _Ma_Gd As String = CbbMa_GD.SelectedValue.ToString.Trim
        If Not (_Ma_Gd.Trim = "1" Or _Ma_Gd.Trim = "2") Then Return

        Dim _Ma_BH As String = TxtMa_BH.Text
        Dim _TL_MG As Decimal = TxtTL_MG.Double

        Dim frm As New FrmLocRoLDN
        frm._Ds_LoolUp = DsLookup
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Sysvar = osysvar
        frm.AppConn = AppConn
        frm.CyberSmlib = CyberSmlib
        frm.CyberSupport = CyberSupport
        frm.CyberFill = CyberFill
        frm.CyberSmlistSys = CyberSmlistSys
        frm.CyberSmodb = CyberSmodb
        frm.CyberExport = Nothing
        frm.CyberVoucher = CyberVoucher
        frm.CyberLoading = CyberLoading
        frm.ShowInTaskbar = False
        frm.Stt_rec = M_Stt_Rec
        frm.Ma_Ct = M_Ma_CT
        frm.Mode = M_Mode
        frm.Ma_BH = TxtMa_BH.Text
        frm.Ma_GD = CbbMa_GD.SelectedValue.ToString.Trim
        frm.TL_MG = _TL_MG
        'frm.Ma_Thue = M_Ma_Thue
        'frm.Ma_TT = M_Ma_TT
        frm.ShowDialog()
        If Not frm.Save_OK Then Exit Sub
        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(frm.Master_Return, Dt_DetailTmp)
        Dt_DetailTmp.AcceptChanges()
        UpdateList()

    End Sub
    Private Sub V_GetDetailFromHDS(ByVal iRow As Decimal)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Return
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        If Not _Ma_GD.Trim = "3" Then Return
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_Ct.Value
        Dim _Ma_post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _So_Ro As String = Dv_DetailTmp.Item(iRow).Item("So_Ro").ToString.Trim
        Dim _Ma_HD As String = Dv_DetailTmp.Item(iRow).Item("Ma_HD_I").ToString.Trim
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Tl_MD As String = TxtTL_MG.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")

        If _So_Ro.Trim = "" Then Return

        CyberSmodb.GetValueData(Dv_DetailTmp.Item(iRow), _strF, _strV, "Ten_Kx,Ten_mau")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDSToLDN", M_Mode.Trim + "#" + txtSo_ct.Text.Trim + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _Ma_GD + "#" + M_Ma_CT + "#" + _
                                                                   M_Stt_Rec + "#" + _So_Ro + "#" + _Ma_HD + "#" + _Tl_MD + "#" + _strF + "#" + _strV + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(0).Rows(0), Dv_DetailTmp, iRow)
        V_Tinh_Toan(iRow)
        UpdateList()
        '--------------------------------------------------------------------------------------


        '--------------------------------------------------------------------------------------
        Dstmp.Dispose()
        Return
    End Sub
    Private Sub V_So_Ct_TBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_GetDetailFromTBH()
    End Sub
    Private Sub V_GetDetailFromTBH()
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        If Not (_Ma_GD = "1" Or _Ma_GD = "2") Then Return
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_Ct.Value
        Dim _Ma_post As String = CbbMa_Post.SelectedValue.ToString.Trim

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTBHToLDN", "0" & "#" & "I" & "#" & _Para_So_Ct_TBH & "#" & _
                                                                     _Ngay_Ct1.ToString("yyyyMMdd") & "#" + _Ngay_Ct2.ToString("yyyyMMdd") & "#" & _Ma_post + "#" & _
                                                                     M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & TxtMa_Kh.Text & "#" & TxtMa_BH.Text & "#" & _
                                                                     TxtLenh_RO.Text & "#" & TxtTL_MG.Text.Replace(" ", "").Replace(",", "") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next
        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        Dt_DetailTmp.Clear()
        CyberSmodb.SQLTbToTb(Dstmp.Tables(0), Dt_DetailTmp)
        Dt_DetailTmp.AcceptChanges()
        UpdateList()
        '--------------------------------------------------------------------------------------
        For iRow As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            V_Tinh_Toan(iRow)
        Next
        '--------------------------------------------------------------------------------------
        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        '--------------------------------------------------------------------------------------
        If Dstmp.Tables(1).Columns.Contains("Ma_Kh") And TxtMa_Kh.Text.Trim = "" Then TxtMa_Kh.Text = Dstmp.Tables(1).Rows(0).Item("Ma_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("ten_Kh") And TxtTen_kh.Text.Trim = "" Then TxtTen_kh.Text = Dstmp.Tables(1).Rows(0).Item("ten_Kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("dia_chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = Dstmp.Tables(1).Rows(0).Item("dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ong_ba") And txtOng_ba.Text.Trim = "" Then txtOng_ba.Text = Dstmp.Tables(1).Rows(0).Item("Ong_ba").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_Bp_H") And TxtMa_Bp_H.Text.Trim = "" Then TxtMa_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Bp_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_BP_H") And txtTen_BP_H.Text.Trim = "" Then txtTen_BP_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_BP_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_HS_H") And txtMa_HS_H.Text.Trim = "" Then txtMa_HS_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_HS_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_HS_H") And txtTen_HS_H.Text.Trim = "" Then txtTen_HS_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_HS_H").ToString.Trim
    End Sub
    Private Sub V_GetDetailMa_HD(ByVal iRow As Decimal)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Return
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim


        Dim _So_Ro As String = Dv_DetailTmp.Item(iRow).Item("So_Ro").ToString.Trim
        Dim _Ma_HD As String = Dv_DetailTmp.Item(iRow).Item("Ma_HD_I").ToString.Trim
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Tl_MD As String = TxtTL_MG.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")

        If _Ma_HD.Trim = "" Then Return

        CyberSmodb.GetValueData(Dv_DetailTmp.Item(iRow), _strF, _strV, "Ten_Kx,Ten_mau")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHdcToLDN", M_Mode.Trim + "#" + txtSo_ct.Text.Trim + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _Ma_GD + "#" + M_Ma_CT + "#" +
                                                                   M_Stt_Rec + "#" + _So_Ro + "#" + _Ma_HD + "#" + _Tl_MD + "#" + _strF + "#" + _strV + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(0).Rows(0), Dv_DetailTmp, iRow)
        V_Tinh_Toan(iRow)
        '--------------------------------------------------------------------------------------
        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Columns.Contains("Ma_Kh") And TxtMa_Kh.Text.Trim = "" Then TxtMa_Kh.Text = Dstmp.Tables(1).Rows(0).Item("Ma_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("ten_Kh") And TxtTen_kh.Text.Trim = "" Then TxtTen_kh.Text = Dstmp.Tables(1).Rows(0).Item("ten_Kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("dia_chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = Dstmp.Tables(1).Rows(0).Item("dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ong_ba") And txtOng_ba.Text.Trim = "" Then txtOng_ba.Text = Dstmp.Tables(1).Rows(0).Item("Ong_ba").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_Bp_H") And TxtMa_Bp_H.Text.Trim = "" Then TxtMa_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Bp_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_BP_H") And txtTen_BP_H.Text.Trim = "" Then txtTen_BP_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_BP_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_HS_H") And txtMa_HS_H.Text.Trim = "" Then txtMa_HS_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_HS_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_HS_H") And txtTen_HS_H.Text.Trim = "" Then txtTen_HS_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_HS_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_Nguoi_nhan") And TxtTen_Nguoi_Nhan.Text.Trim = "" Then TxtTen_Nguoi_Nhan.Text = Dstmp.Tables(1).Rows(0).Item("Ten_Nguoi_nhan").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("So_TK") And TxtSo_TK.Text.Trim = "" Then TxtSo_TK.Text = Dstmp.Tables(1).Rows(0).Item("So_TK").ToString.Trim

        '--------------------------------------------------------------------------------------
        Dstmp.Dispose()
    End Sub
    Private Sub V_GetDetailMa_Td3(ByVal iRow As Decimal)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Return
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim


        Dim _So_Ro As String = Dv_DetailTmp.Item(iRow).Item("So_Ro").ToString.Trim
        Dim _Ma_HD As String = Dv_DetailTmp.Item(iRow).Item("Ma_HD_I").ToString.Trim
        Dim _Ma_Td3 As String = Dv_DetailTmp.Item(iRow).Item("Ma_TD3_I").ToString.Trim
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Tl_MD As String = TxtTL_MG.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")

        If _Ma_Td3.Trim = "" Then Return

        CyberSmodb.GetValueData(Dv_DetailTmp.Item(iRow), _strF, _strV, "Ten_Kx,Ten_mau")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetMoiGoiFromMa_Td3", M_Mode.Trim + "#" + txtSo_ct.Text.Trim + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _Ma_GD + "#" + M_Ma_CT + "#" +
                                                                   M_Stt_Rec + "#" + _So_Ro + "#" + _Ma_HD + "#" + _Tl_MD + "#" + _strF + "#" + _strV + "#" + _Ma_Td3 + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(0).Rows(0), Dv_DetailTmp, iRow)
        V_Tinh_Toan(iRow)
        '--------------------------------------------------------------------------------------
        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        '--------------------------------------------------------------------------------------
        Dstmp.Dispose()
    End Sub
    Private Sub V_SetMa_HD_I()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hd_H.Text = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            Dv_DetailTmp.Item(iRow).BeginEdit()

            If Dt_DetailTmp.Columns.Contains("ma_Hd_I") Then Dv_DetailTmp.Item(iRow).Item("Ma_Hd_i") = TxtMa_Hd_H.Text

            Dv_DetailTmp.Item(iRow).EndEdit()
        Next
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_GetDetailMa_HD(iRow)

        Next
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

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_HS_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_BP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
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

