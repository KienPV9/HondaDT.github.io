Imports System.Data.SqlClient
Public Class HDI
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet

#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim TbTP, TbQuan, TbXa, TbKX, TbMau_xe As New DataTable
    Public vTbTP, vTbQuan, vTbXa, vTbKX, vTbMau_Xe As DataView
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_Nx_I, EditMa_kh_I, EditTen_kh_I, EditMa_TT As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim Editma_Db_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditTen_Nx_I As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_LhBh, EditMa_BH, EditDien_Giaii As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditGia2, EditTien2, EditCk_i, EditPt_Ck_i, EditMa_Thue, EditThue_Suat, EditThue, EditTien_BH, EditThue_BH As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Dim EditTien_HHTV, EditTien_HHCTY, EditPT_HH_TV, EditGia3, EditPT_HH_CTY, EditNgay_bd, EditPt_mg, EditTien_MG As New Cyber.Fill.CyberColumnGridView

#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
    Dim Dt_vai_tro, Dt_HTLL As DataTable
    

    Dim SysvarRO As Collection
    Dim M_Ma_TP_Ngam_Dinh As String = ""
    Dim M_Ma_Quan_Ngam_Dinh As String = ""
    Dim M_Ma_Xa_Ngam_Dinh As String = ""
    Dim M_Vai_Tro_Ngam_Dinh As String = ""
    Dim M_Ma_HTLL_Ngam_Dinh As String = ""

    Dim M_Ma_Hs As String = ""
    Dim M_Ten_Hs As String = ""
    Dim M_Ma_BP As String = ""
    Dim M_Ten_BP As String = ""
#End Region
    Dim DtDmXestru As DataTable

    Private Sub HDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        '------------------------------
        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        '------------------------------
        V_GetColumn()
        '------------------------------
        V_AddHandler()
        '------------------------------
        V_Databing()
        '------------------------------
        V_GetStrus()
        '------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        '------------------------------
        V_MainSystem()
        GetRound()
        CmdNew.Select()
        '------------------------------
    End Sub
#Region "Load And Set And Default"
    Private Sub V_GetStrus()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.Dmxe WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtDmXestru = Dstmp.Tables(0).Copy
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
        V_nam()

        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)
        TxtT_Tien2.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien2.InputMask)

        TxtT_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT.InputMask)
        TxtT_Tien2.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien2.InputMask)
        TxtT_CK.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_CK.InputMask)
        TxtT_Thue.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue.InputMask)

        TxtT_HH_TV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_HH_TV.InputMask)
        TxtT_HH_CTY.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_HH_CTY.InputMask)
        TxtT_HH.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_HH.InputMask)
        TxtMoi_Gioi.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtMoi_Gioi.InputMask)

        TxtT_I.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_I.InputMask)
        TxtT_W.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_W.InputMask)
        TxtT_N.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_N.InputMask)
        TxtT_C.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_C.InputMask)
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
        V_LoadDefaultHDI()
        '---------------------------------------------------------------------------------------------'
        V_LoadDefault()
        '---------------------------------------------------------------------------------------------'

    End Sub
    Private Sub V_LoadDefaultHDI()
        Dim _Dt_Bp_Hs As DataTable
        Dim DsTpQuanXa As New DataSet
        DsTpQuanXa = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultHDK", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        TbTP = DsTpQuanXa.Tables(0).Copy
        vTbTP = New DataView(TbTP)

        TbQuan = DsTpQuanXa.Tables(1).Copy
        vTbQuan = New DataView(TbQuan)

        TbXa = DsTpQuanXa.Tables(2).Copy
        vTbXa = New DataView(TbXa)

        Dt_vai_tro = DsTpQuanXa.Tables(3).Copy
        Dt_HTLL = DsTpQuanXa.Tables(4).Copy
        _Dt_Bp_Hs = DsTpQuanXa.Tables(5).Copy
        DsTpQuanXa.Dispose()
        '--------------------------------------------------------------------------------------------
        '=========== FillCombox
        CyberFill.V_FillComBoxValue(CmbMa_TP, vTbTP, "ma_Tp", "Ten_Tp", "")
        CyberFill.V_FillComBoxValue(CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan", "")
        CyberFill.V_FillComBoxValue(CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa", "")
        '------------
        CyberFill.V_FillComBoxDefaul(CmbVai_Tro, Dt_vai_tro, "Vai_Tro", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, Dt_HTLL, "MA_HTLL", "Ten_HTLL", "Ngam_Dinh")

        '--------------------------------------------------------------------------------------------
        If TbTP.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbTP.Rows.Count - 1
                If TbTP.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_TP_Ngam_Dinh = TbTP.Rows(i).Item("ma_TP").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If TbQuan.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbQuan.Rows.Count - 1
                If TbQuan.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Quan_Ngam_Dinh = TbQuan.Rows(i).Item("ma_Quan").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If TbXa.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbXa.Rows.Count - 1
                If TbXa.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Xa_Ngam_Dinh = TbXa.Rows(i).Item("ma_Xa").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If Dt_vai_tro.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_vai_tro.Rows.Count - 1
                If Dt_vai_tro.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Vai_Tro_Ngam_Dinh = Dt_vai_tro.Rows(i).Item("Vai_Tro").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_HTLL.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_HTLL.Rows.Count - 1
                If Dt_HTLL.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_HTLL_Ngam_Dinh = Dt_HTLL.Rows(i).Item("Ma_HTLL").ToString.Trim
                    Exit For
                End If
            Next
        End If
        '---------------------------------------------------------------------------------------------'
        If _Dt_Bp_Hs.Columns.Contains("Ma_Hs_H") Then M_Ma_Hs = _Dt_Bp_Hs.Rows(0).Item("Ma_HS_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_Hs_H") Then M_Ten_Hs = _Dt_Bp_Hs.Rows(0).Item("Ten_Hs_H")
        If _Dt_Bp_Hs.Columns.Contains("Ma_BP_H") Then M_Ma_BP = _Dt_Bp_Hs.Rows(0).Item("Ma_BP_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_BP_H") Then M_Ten_BP = _Dt_Bp_Hs.Rows(0).Item("Ten_BP_H")

        '---------------------------------------------------------------------------------------------'
        SysvarRO = CyberSmlib.IniSysVarCustomer(AppConn, M_Ma_Dvcs, M_User_Name, "SysvarRo")
    End Sub
    Private Sub V_nam()
        Dim tbNam As New DataTable
        tbNam.Columns.Add("Nam")
        Dim _R_C As Decimal = Now.Year + 1
        For i = 1995 To _R_C
            tbNam.Rows.Add(i.ToString.Trim)
        Next
        CyberFill.V_FillComBoxValue(CmbNam_Sx, tbNam, "Nam", "Nam", Date.Now.Year.ToString)
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

        EditMa_BH.GetColumn(DetailGRV, "Ma_BH")
        EditMa_LhBh.GetColumn(DetailGRV, "Ma_LhBh")
        EditMa_TT.GetColumn(DetailGRV, "Ma_TT")

        EditMa_Nx_I.GetColumn(DetailGRV, "Ma_Nx_I")
        EditTen_Nx_I.GetColumn(DetailGRV, "TEN_Nx_I")
        EditDien_Giaii.GetColumn(DetailGRV, "DIEN_GIAII")
        '----------------------------------------------------------------------------------------
        EditNgay_bd.GetColumn(DetailGRV, "Ngay_bd")
        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditGia2.GetColumn(DetailGRV, "Gia2")
        EditGia3.GetColumn(DetailGRV, "Gia3")
        EditTien2.GetColumn(DetailGRV, "Tien2")

        EditCk_i.GetColumn(Me.DetailGRV, "Ck_i")
        EditPt_Ck_i.GetColumn(Me.DetailGRV, "Pt_Ck_i")
        EditThue.GetColumn(Me.DetailGRV, "Thue")
        EditThue_Suat.GetColumn(Me.DetailGRV, "Thue_Suat")
        EditMa_Thue.GetColumn(Me.DetailGRV, "Ma_Thue")


        EditThue_BH.GetColumn(Me.DetailGRV, "Thue_BH")
        EditTien_BH.GetColumn(Me.DetailGRV, "Tien_BH")

        EditTien_HHTV.GetColumn(Me.DetailGRV, "Tien_HHTV")
        EditTien_HHCTY.GetColumn(Me.DetailGRV, "Tien_HHCTY")
        EditPT_HH_TV.GetColumn(Me.DetailGRV, "PT_HH_TV")
        EditPT_HH_CTY.GetColumn(Me.DetailGRV, "PT_HH_CTY")
        EditPt_mg.GetColumn(Me.DetailGRV, "Pt_Mg")
        '----------------------------------------------------------------------------------------
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

        Editma_Db_I.GetColumn(DetailGRV, "Ma_Db_I")
        EditTien_MG.GetColumn(DetailGRV, "Tien_MG")

        EditMa_kh_I.GetColumn(DetailGRV, "MA_KH_I")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
                TxtNgay_Ct.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
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
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia

        AddHandler TxtMa_DVBH_H.CyberValiting, AddressOf V_Ma_DVBH_H
        AddHandler TxtMa_DVBH_H.CyberLeave, AddressOf L_Ma_DVBH_H

        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtDia_Chi.Leave, AddressOf L_Dia_Chi
        AddHandler TxtTen_kh.Leave, AddressOf L_Ten_kh
        AddHandler TxtTen_khVAT.Leave, AddressOf L_Ten_khVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf L_Dia_ChiVat
        'TP-Quan-phuong
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged

        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        'Hd
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        '----------------------------------------------------------------------------------------------------------
        '--Ma_HD
        AddHandler TxtMa_Td3_H.CyberValiting, AddressOf V_Ma_Td3_H
        AddHandler TxtMa_Td3_H.CyberLeave, AddressOf L_Ma_Td3_H

        '--Ma_Hs
        AddHandler TxtMa_hs_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_hs_H.CyberLeave, AddressOf L_Ma_HS_H

        '--Ma_BP
        AddHandler TxtMa_Bp_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberLeave, AddressOf L_Ma_BP_H

        '----------------------------------------------------------------------------------------------------------
        AddHandler ChkCK.CheckedChanged, AddressOf V_ChkCK
        AddHandler ChkBH.CheckedChanged, AddressOf V_Chk_BH
        AddHandler TxtT_I.Leave, AddressOf V_T_BH
        AddHandler TxtT_CK.Leave, AddressOf V_T_CK

        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler TxtSo_RO.Leave, AddressOf V_SO_Ro
        AddHandler txtDien_Thoai.Leave, AddressOf L_Dien_Thoai
        AddHandler TxtDt_LX.Leave, AddressOf L_DT_LX
        AddHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtDT_GDV.Leave, AddressOf V_DT_GDV
        AddHandler TxtDT_MG.Leave, AddressOf V_DT_MG

        '----------------------------------------------------------------------------------------------------------
        AddHandler CmdDSLich_Hen.Click, AddressOf V_Ds_Dat_Lich
        AddHandler CmdDat_Lich.Click, AddressOf V_Dat_Lich
        AddHandler CmdHan_BH.Click, AddressOf V_Han_BH
        AddHandler CmdLich_Su.Click, AddressOf V_Lich_Su
        '----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_AddHandler_Detail()

        '----------------------------------------------------------------------------------------
        If Not EditNgay_bd.Column Is Nothing Then AddHandler EditNgay_bd.EditColumn.Leave, AddressOf V_Ngay_bd
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien2.Column Is Nothing Then AddHandler EditTien2.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditCk_i.Column Is Nothing Then AddHandler EditCk_i.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditPt_Ck_i.Column Is Nothing Then AddHandler EditPt_Ck_i.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditThue.Column Is Nothing Then AddHandler EditThue.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditThue_Suat.Column Is Nothing Then AddHandler EditThue_Suat.EditColumn.Leave, AddressOf V_Tinh_Toan
        EditMa_Thue.V_ActiLookUpColumn(AddressOf V_Ma_Thue, AddressOf L_Ma_Thue)

        If Not EditThue_BH.Column Is Nothing Then AddHandler EditThue_BH.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien_BH.Column Is Nothing Then AddHandler EditTien_BH.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien_HHTV.Column Is Nothing Then AddHandler EditTien_HHTV.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTien_HHCTY.Column Is Nothing Then AddHandler EditTien_HHCTY.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditPT_HH_TV.Column Is Nothing Then AddHandler EditPT_HH_TV.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditPT_HH_CTY.Column Is Nothing Then AddHandler EditPT_HH_CTY.EditColumn.Leave, AddressOf V_Tinh_Toan

        '-------------------------------------
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        EditMa_BH.V_ActiLookUpColumn(AddressOf V_Ma_BH, AddressOf L_Ma_BH)
        EditMa_LhBh.V_ActiLookUpColumn(AddressOf V_Tk_Ma_LhBh, AddressOf L_Tk_Ma_LhBh)
        EditMa_TT.V_ActiLookUpColumn(AddressOf V_Ma_TT, AddressOf L_Ma_TT)

        EditMa_Nx_I.V_ActiLookUpColumn(AddressOf V_Ma_Nx_I, AddressOf L_Ma_Nx_I)
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
        EditMa_kh_I.V_ActiLookUpColumn(AddressOf V_Ma_kh_i, AddressOf L_Ma_kh_i)
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

    Private Sub VisibleColumnMa_NT()
        'If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
        'Else
        'End If
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
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then txtSo_ct.ReadOnly = True Else txtSo_ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRV.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
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
        'DrReturn = Nothing
        'CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        'If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#Region "Valid --- DVBH_H"
#Region "Valid --- Ma_BH_H"
    Private Sub V_Ma_DVBH_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BH", "DMBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_DVBH_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_DVBH_H.Text = DrReturn.Item("Ma_BH")
            TxtTen_DVBH_H.Text = DrReturn.Item("Ten_BH")
        Else
            TxtMa_DVBH_H.Text = ""
            TxtTen_DVBH_H.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi"), TxtDia_Chi.Text)
            txtDien_Thoai.Text = IIf(txtDien_Thoai.Text.Trim = "", DrReturn.Item("Dien_Thoai").ToString.Trim, txtDien_Thoai.Text)
            txtMa_So_Thue.Text = IIf(txtMa_So_Thue.Text.Trim = "", DrReturn.Item("Ma_So_Thue").ToString.Trim, txtMa_So_Thue.Text)
        Else
            TxtMa_Kh.Text = ""
            'TxtTen_kh.Text = ""
        End If
    End Sub
    Private Sub L_Dia_Chi(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtDia_Chi.Text = CyberInput.GetDia_Chi(TxtMa_Kh.Text, TxtDia_Chi.Text, M_Ma_CT, M_Mode, AppConn, CyberSmlib, CyberSmodb)
        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
    End Sub
    Sub L_Ten_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim <> "", TxtTen_khVAT.Text, TxtTen_kh.Text)
    End Sub
    Sub L_Ten_khVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtTen_kh.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, TxtTen_khVAT.Text)
    End Sub
    Sub L_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim <> "", TxtDia_Chi.Text, TxtDia_ChiVAT.Text)
    End Sub
#End Region
#Region "Valid --- Ma_HD_H/Ma_Bp_H/Ma_HS_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Bp_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Bp_H.Text = "" Then
            TxtTen_Bp_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp_H.Text = DrReturn.Item("Ma_BP")
            TxtTen_Bp_H.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Bp_H.Text = ""
            TxtTen_Bp_H.Text = ""
        End If
    End Sub
    Private Sub V_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "Ma_BP = '" + TxtMa_Bp_H.Text + "'")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
    Private Sub V_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD_H.Text = DrReturn.Item("Ma_HD")
            'TxtTen_HD_H.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD_H.Text = ""
            'TxtTen_TD_H.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Td3_H"
    Private Sub V_Ma_Td3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Td3", "Dmtd3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Td3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Td3_H.Text = DrReturn.Item("Ma_Td3")
            ''TxtTen_TD3_H.Text = DrReturn.Item("Ten_Td3")
            TxtMa_HD_H.Text = DrReturn.Item("Ma_Hd")
        Else
            TxtMa_Td3_H.Text = ""
            ''TxtTen_TD3_H.Text = ""
            TxtMa_HD_H.Text = ""
        End If
        If Not TxtMa_Td3_H.Text = "" Then L_HDIGetThongTinHDX()

    End Sub
    Private Sub L_HDIGetThongTinHDX()
        Dim _Ma_HD As String = TxtMa_Td3_H.Text
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDIFromHDX", "1#" + M_Mode + "#" + _Ma_HD + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Exit Sub
        End If

        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, M_LAN) Then
            Dstmp.Dispose()
            Exit Sub
        End If

        If Dstmp.Tables.Count = 1 Then
            Dstmp.Dispose()
            Exit Sub
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Exit Sub
        End If
        If Dstmp.Tables(1).Columns.Contains("So_khung") Then TxtSo_khung.Text = Dstmp.Tables(1).Rows(0).Item("So_khung").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("So_May") Then TxtSo_May.Text = Dstmp.Tables(1).Rows(0).Item("So_May").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_kh") Then TxtTen_kh.Text = Dstmp.Tables(1).Rows(0).Item("Ten_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dia_chi") Then TxtDia_Chi.Text = Dstmp.Tables(1).Rows(0).Item("Dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_khVat") Then TxtTen_khVAT.Text = Dstmp.Tables(1).Rows(0).Item("Ten_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dia_chiVat") Then TxtDia_ChiVAT.Text = Dstmp.Tables(1).Rows(0).Item("Dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_so_thue") Then txtMa_So_Thue.Text = Dstmp.Tables(1).Rows(0).Item("Ma_so_thue").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ong_ba") Then txtTen_Lx.Text = Dstmp.Tables(1).Rows(0).Item("Ong_ba").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dt_LH") Then TxtDt_LX.Text = Dstmp.Tables(1).Rows(0).Item("Dt_LH").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_kx") Then TxtMa_Kx.Text = Dstmp.Tables(1).Rows(0).Item("Ma_kx").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_mau") Then TxtMa_Mau.Text = Dstmp.Tables(1).Rows(0).Item("Ma_mau").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_kx") Then TxtTen_Kx.Text = Dstmp.Tables(1).Rows(0).Item("Ten_kx").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_mau") Then TxtTen_Mau.Text = Dstmp.Tables(1).Rows(0).Item("Ten_mau").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_Hs_H") Then TxtMa_hs_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Hs_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_Hs_h") Then TxtTen_Hs_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_Hs_h").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_bp_H") Then TxtMa_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_bp_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_bp_h") Then TxtTen_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_bp_h").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Gia_xe") Then TxtGT_Xe.Text = Dstmp.Tables(1).Rows(0).Item("Gia_xe").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("ngan_hang") Then TxtNgan_hang.Text = Dstmp.Tables(1).Rows(0).Item("ngan_hang").ToString.Trim
        Dim nCount As Integer = Dt_DetailTmp.Rows.Count
        For i = nCount - 1 To 0 Step -1
            Dt_DetailTmp.Rows(i).Delete()
            Dt_DetailTmp.AcceptChanges()
        Next
        CyberSmodb.SetNotNullTable(Dstmp.Tables(2))
        CyberSmodb.SQLTbToTb(Dstmp.Tables(2), Dt_DetailTmp)
        Dstmp.Dispose()
        UpdateList()

    End Sub
#End Region
#Region "Valid --- Ma_KX"
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_KX")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#Region "=====GDV Va MG"
    Private Sub V_DT_GDV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dsTmp As DataSet
        dsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetNameForTele", TxtDT_GDV.Text.Trim.Replace("#", "") + "#" + TxtTen_GDV.Text.Trim.Replace("#", ""))
        TxtTen_GDV.Text = dsTmp.Tables(0).Rows(0).Item("Name").ToString
    End Sub
    Private Sub V_DT_MG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dsTmp As DataSet
        dsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetNameForTele", TxtDT_MG.Text.Trim.Replace("#", "") + "#" + TxtTen_MG.Text.Trim.Replace("#", ""))
        TxtTen_MG.Text = dsTmp.Tables(0).Rows(0).Item("Name").ToString
    End Sub
#End Region
#Region "Thành phố Quận xã"
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP()
    End Sub
    Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan()
    End Sub
    Private Sub V_Ma_TP()
        vTbQuan.RowFilter = "Ma_TP = '" + CmbMa_TP.SelectedValue + "'"
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
    Private Sub V_Ma_Quan()
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
#End Region
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
        If Dr.Item("Ma_Xe").ToString.Trim = TxtMa_Xe.Text.Trim Then V_Fill_TT(Dr, "1")
    End Sub
    Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub

        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim)

        If Dr Is Nothing Then Exit Sub
        V_Fill_TT(Dr, "1")
    End Sub
    Private Sub V_SO_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        TxtSo_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, osysvar, M_Ma_CT, CbbMa_GD.SelectedValue, M_Mode, _Dt, TxtSo_RO.Text, CbbMa_TTCP_H, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)

    End Sub
    Sub L_Dien_Thoai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        txtDien_Thoai.Text = CyberVoucher.V_FormatDT(txtDien_Thoai.Text)
        If TxtDt_LX.Text = "" Then TxtDt_LX.Text = txtDien_Thoai.Text
    End Sub
    Sub L_DT_LX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtDt_LX.Text = CyberVoucher.V_FormatDT(TxtDt_LX.Text)
        If txtDien_Thoai.Text = "" Then txtDien_Thoai.Text = TxtDt_LX.Text

    End Sub
    Private Sub V_Fill_TT(ByVal Dr As DataRow, ByVal Is_Xe As String)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Dr Is Nothing Then Exit Sub

        If V_IsFieldExist("Ma_Xe", Dr) Then
            If Is_Xe = "1" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "2" And TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "3" And TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = Dr.Item("Ma_Xe").ToString.Trim
        End If

        If V_IsFieldExist("So_khung", Dr) Then TxtSo_khung.Text = Dr.Item("So_khung").ToString.Trim
        If V_IsFieldExist("So_May", Dr) Then TxtSo_May.Text = Dr.Item("So_May").ToString.Trim
        If V_IsFieldExist("Ma_Mau", Dr) Then
            TxtMa_Mau.Text = Dr.Item("Ma_Mau").ToString.Trim
            TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauxe", "Ma_Mau = N'" + TxtMa_Mau.Text.Trim + "'", CyberSmlib)
        End If
        If V_IsFieldExist("Ma_Kx", Dr) Then
            TxtMa_Kx.Text = Dr.Item("Ma_Kx").ToString.Trim
            TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmlib)
        End If

        If V_IsFieldExist("Ma_Nthat", Dr) Then If Not Dr.Item("Ma_Nthat").ToString.Trim = "" Then TxtMa_nthat.Text = Dr.Item("Ma_Nthat").ToString.Trim

        If V_IsFieldExist("Ten_Kh", Dr) Then If Not Dr.Item("Ten_Kh").ToString.Trim = "" Then TxtTen_kh.Text = Dr.Item("Ten_Kh").ToString.Trim
        If V_IsFieldExist("Dia_Chi", Dr) Then If Not Dr.Item("Dia_Chi").ToString.Trim = "" Then TxtDia_Chi.Text = Dr.Item("Dia_Chi").ToString.Trim

        If V_IsFieldExist("Ten_KhVAT", Dr) Then If Not Dr.Item("Ten_KhVAT").ToString.Trim = "" Then TxtTen_khVAT.Text = Dr.Item("Ten_KhVAT").ToString.Trim
        If V_IsFieldExist("Dia_ChiVAT", Dr) Then If Not Dr.Item("Dia_ChiVAT").ToString.Trim = "" Then TxtDia_ChiVAT.Text = Dr.Item("Dia_ChiVAT").ToString.Trim
        If V_IsFieldExist("Ma_So_Thue", Dr) Then If Not Dr.Item("Ma_So_Thue").ToString.Trim = "" Then txtMa_So_Thue.Text = Dr.Item("Ma_So_Thue").ToString.Trim
        If V_IsFieldExist("Ten_Lx", Dr) Then If Not Dr.Item("Ten_Lx").ToString.Trim = "" Then txtTen_Lx.Text = Dr.Item("Ten_Lx").ToString.Trim


        If V_IsFieldExist("Dien_Thoai", Dr) Then If Not Dr.Item("Dien_Thoai").ToString.Trim = "" Then txtDien_Thoai.Text = Dr.Item("Dien_Thoai").ToString.Trim
        If V_IsFieldExist("Dt_LX", Dr) Then If Not Dr.Item("Dt_LX").ToString.Trim = "" Then TxtDt_LX.Text = Dr.Item("Dt_LX").ToString.Trim
        If V_IsFieldExist("Fax", Dr) Then If Not Dr.Item("Fax").ToString.Trim = "" Then TxtFax.Text = Dr.Item("Fax").ToString.Trim

        If V_IsFieldExist("Nam_Sx", Dr) And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbNam_Sx, Dr.Item("Nam_Sx").ToString.Trim)
        If V_IsFieldExist("Ma_TP", Dr) Then If Not Dr.Item("Ma_TP").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_TP, Dr.Item("Ma_TP").ToString.Trim)
        If V_IsFieldExist("Ma_Quan", Dr) Then If Not Dr.Item("Ma_Quan").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_Quan, Dr.Item("Ma_Quan").ToString.Trim)
        If V_IsFieldExist("Ma_Xa", Dr) Then If Not Dr.Item("Ma_Xa").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_Xa, Dr.Item("Ma_Xa").ToString.Trim)

        If V_IsFieldExist("Vai_Tro", Dr) Then If Not Dr.Item("Vai_Tro").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbVai_Tro, Dr.Item("Vai_Tro").ToString.Trim)
        If V_IsFieldExist("Ma_HTLL", Dr) Then If Not Dr.Item("Ma_HTLL").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_HTLL, Dr.Item("Ma_HTLL").ToString.Trim)


        'V_Fax(New System.Object, New System.EventArgs)
        'V_Dien_Thoai(New System.Object, New System.EventArgs)
        'V_Ten_kh(New System.Object, New System.EventArgs)
        'V_Dia_Chi(New System.Object, New System.EventArgs)
        'V_Ten_khVat(New System.Object, New System.EventArgs)
        'V_Dia_ChiVat(New System.Object, New System.EventArgs)
    End Sub
    Private Function V_IsFieldExist(ByVal Field_Name As String, ByVal Dr As DataRow) As Boolean
        Dim _Return As Boolean = False
        If Dr Is Nothing Then Return False
        Field_Name = Field_Name.Trim
        If Dr.Table.Columns.Contains(Field_Name) Then _Return = True
        V_IsFieldExist = _Return
    End Function
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()

        Dim nT_Tien2 As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_CK As Decimal = 0
        Dim nT_HH_TV As Decimal = 0
        Dim nT_HH_Cty As Decimal = 0
        Dim nT_HH As Decimal = 0
        Dim nT_TT As Decimal = 0
        Dim nT_So_Luong As Decimal = 0
        Dim nT_Moi_Gioi As Decimal = 0

        Dim nT_I As Decimal = 0
        Dim nT_W As Decimal = 0
        Dim nT_N As Decimal = 0
        Dim nT_C As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_luong")
            nT_Tien2 = nT_Tien2 + Dv_DetailTmp.Item(iRow).Item("Tien2")
            nT_CK = nT_CK + Dv_DetailTmp.Item(iRow).Item("CK_I")
            nT_Thue = nT_Thue + Dv_DetailTmp.Item(iRow).Item("Thue")

            nT_HH_TV = nT_HH_TV + Dv_DetailTmp.Item(iRow).Item("Tien_HHTV")
            nT_HH_Cty = nT_HH_Cty + Dv_DetailTmp.Item(iRow).Item("Tien_HHCTY")
            nT_Moi_Gioi = nT_Moi_Gioi + Dv_DetailTmp.Item(iRow).Item("Tien_MG")

            If Dt_DetailTmp.Rows(iRow).Item("Ma_TT").ToString.Trim.ToUpper = "I" Then
                nT_I = nT_I + Dt_DetailTmp.Rows(iRow).Item("Tien2") - Dt_DetailTmp.Rows(iRow).Item("CK_I") + Dt_DetailTmp.Rows(iRow).Item("Thue")
            End If

            If Dt_DetailTmp.Rows(iRow).Item("Ma_TT").ToString.Trim.ToUpper = "W" Then
                nT_W = nT_W + Dt_DetailTmp.Rows(iRow).Item("Tien2") - Dt_DetailTmp.Rows(iRow).Item("CK_I") + Dt_DetailTmp.Rows(iRow).Item("Thue")
            End If

            If Not (Dt_DetailTmp.Rows(iRow).Item("Ma_TT").ToString.Trim.ToUpper = "W" Or Dt_DetailTmp.Rows(iRow).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailTmp.Rows(iRow).Item("Ma_TT").ToString.Trim.ToUpper = "C") Then
                nT_N = nT_N + Dt_DetailTmp.Rows(iRow).Item("Tien2") - Dt_DetailTmp.Rows(iRow).Item("CK_I") + Dt_DetailTmp.Rows(iRow).Item("Thue")
            End If
        Next
        '------------------------------------------------------------------------------------
        If ChkCK.Checked Then nT_CK = TxtT_CK.Double Else TxtT_CK.Double = nT_CK
        If ChkBH.Checked Then nT_I = TxtT_I.Double Else TxtT_I.Double = nT_I
        '------------------------------------------------------------------------------------
        TxtT_W.Double = nT_W
        TxtT_I.Double = nT_I + nT_N
        '------------------------------------------------------------------------------------
        nT_TT = nT_Tien2 - nT_CK + nT_Thue
        nT_HH = nT_HH_TV + nT_HH_Cty

        txtT_So_Luong.Double = nT_So_Luong
        TxtT_Tien2.Double = nT_Tien2

        TxtT_CK.Double = nT_CK
        TxtT_Thue.Double = nT_Thue

        TxtT_TT.Double = nT_TT
        TxtT_HH_TV.Double = nT_HH_TV
        TxtT_HH_CTY.Double = nT_HH_Cty
        TxtT_HH.Double = nT_HH
        TxtMoi_Gioi.Double = nT_Moi_Gioi

        txtT_So_Luong.Refresh()
        TxtT_C.Double = nT_Tien2 + nT_Thue - nT_CK - nT_I - nT_W - nT_N
    End Sub
    Private Sub Tinh_Gia2(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If iRow < 0 Then Exit Sub
        'Dim _Gia_TK As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_TK")
        'Dim _Gia2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia2")
        'Dim _Ma_vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt")
        'Dim _Ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I")
        'Dim _Ma_TT As String = Dv_DetailTmp.Item(iRow).Item("Ma_TT")
        'Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        'Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        'Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        ''-----------------------------------------------------------------------------------------------------------
        'Dim dsGia2 As New DataSet
        'dsGia2 = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDKGia2", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT.Trim & "#" & M_Stt_Rec & "#" & M_Mode & "#" & _
        '                                            _Ma_GD & "#" & _Ma_Post & "#" & _Ma_vt.Trim & "#" & _Ma_Kho.Trim + "#" & _Ma_TT & "#" & _
        '                                            _Gia2.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)
        '_Gia2 = dsGia2.Tables(0).Rows(0).Item("Gia2")
        '_Gia_TK = dsGia2.Tables(0).Rows(0).Item("Gia_TK")
        'dsGia2.Dispose()
        ''-----------------------------------------------------------------------------------------------------------
        'Dv_DetailTmp.Item(iRow).BeginEdit()
        'Dv_DetailTmp.Item(iRow).Item("Gia2") = _Gia2
        'If Dt_DetailTmp.Columns.Contains("Gia_TK") Then Dv_DetailTmp.Item(iRow).Item("Gia_TK") = _Gia_TK
        'Dv_DetailTmp.Item(iRow).EndEdit()
        ''-----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_Ngay_bd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim _Ngay_bd As Date = Dv_DetailTmp.Item(iRow).Item("Ngay_bd")
        Dim _SO_LUONG As Double = Dv_DetailTmp.Item(iRow).Item("SO_LUONG")
        Dim _Thang As Integer = 12 * _SO_LUONG
        Dim _Ngay_Kt As Date = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, _Thang, _Ngay_bd))

        If _SO_LUONG = 0 Then Exit Sub

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ngay_kt") = _Ngay_Kt
        Dv_DetailTmp.Item(iRow).EndEdit()
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("Gia3") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Gia2") = CyberSupport.V_Round(100 * (Dv_DetailTmp.Item(iRow).Item("Gia3") / (100 + Dv_DetailTmp.Item(iRow).Item("THue_suat"))), 2)
        End If
        Dv_DetailTmp.Item(iRow).Item("Tien2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia2"), 0)
        Dv_DetailTmp.Item(iRow).EndEdit()

        'Chiet Khau---------------------------------------------------------------------------------------
        If ChkCK.Checked Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0
            Dv_DetailTmp.Item(iRow).Item("CK_I") = 0
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Not ChkCK.Checked Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If CyberSupport.ChkFieldKey(Dv_DetailTmp.Item(iRow).Item("Ma_TT"), "I,C") Then
                Dv_DetailTmp.Item(iRow).Item("CK_I") = IIf(Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0, Dv_DetailTmp.Item(iRow).Item("CK_I"), CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien2") * Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") / 100, 0))
            Else
                Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0
                Dv_DetailTmp.Item(iRow).Item("CK_I") = 0
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '-------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tien0") = Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I")
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------
        TinhThue(iRow)
        '-------------------------------------------------------------------------------------------------
        If ChkCK.Checked Then V_T_CK(New System.Object, New System.EventArgs)
        If ChkBH.Checked Then V_T_BH(New System.Object, New System.EventArgs)

        '-------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tien_HHCTY") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("PT_HH_CTY") / 100 * (Dv_DetailTmp.Item(iRow).Item("Tien2")), M_R_TIEN_NT) - Dv_DetailTmp.Item(iRow).Item("CK_I")
        Dv_DetailTmp.Item(iRow).Item("Tien_HHTV") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("PT_HH_TV") / 100 * (Dv_DetailTmp.Item(iRow).Item("Tien2")), M_R_TIEN_NT)
        Dv_DetailTmp.Item(iRow).Item("Tien_MG") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("PT_MG") / 100 * (Dv_DetailTmp.Item(iRow).Item("Tien2")), M_R_TIEN_NT)
        Dv_DetailTmp.Item(iRow).Item("Tien_BH") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_BH") / 100 * (Dv_DetailTmp.Item(iRow).Item("Tien2")), M_R_TIEN_NT)

        Dv_DetailTmp.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub V_T_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim nCount As Integer = 0
        Dim nT_T, nT_CK As Decimal
        Dim i As Integer

        nT_T = TxtT_Tien2.Double
        nT_CK = TxtT_CK.Double
        nCount = Dt_DetailTmp.Rows.Count
        '------------------------------------------------------------------------------
        '--- 1 KHong co vat tu phu tung nao
        If nCount <= 0 Then
            nT_CK = 0
            TxtT_CK.Double = nT_CK
            TxtT_CK.Refresh()
            UpdateList()
            Exit Sub
        End If
        '------------------------------------------------------------------------------
        '--- 2 Nhap vao chi tiet vao
        If Not ChkCK.Checked Then
            nT_CK = 0
            For i = 0 To nCount - 1
                nT_CK = nT_CK + Dt_DetailTmp.Rows(i).Item("CK_I")
            Next
            TxtT_CK.Double = nT_CK
            TxtT_CK.Refresh()
            UpdateList()
            Exit Sub
        End If
        '------------------------------------------------------------------------------
        '--- 3 Phan bo
        For i = 0 To nCount - 1
            Dt_DetailTmp.Rows(i).BeginEdit()
            Dt_DetailTmp.Rows(i).Item("PT_Ck_I") = 0
            Dt_DetailTmp.Rows(i).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Tien2", "CK_I", nT_CK, 0)
        ' Tinh thue Vat tu
        For i = 0 To nCount - 1
            TinhThue(i)
        Next
        UpdateList()
    End Sub
    Private Sub V_Chk_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkBH.Checked Then TxtT_I.ReadOnly = False Else TxtT_I.ReadOnly = True
        If ChkBH.Checked Then TxtT_I.Focus()
        V_T_BH(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub V_T_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim nCount As Integer
        Dim i As Integer

        nCount = Dt_DetailTmp.Rows.Count

        If Not ChkBH.Checked Then
            For i = 0 To nCount - 1
                Dt_DetailTmp.Rows(i).BeginEdit()
                Dt_DetailTmp.Rows(i).Item("Thue_BH") = 0
                Dt_DetailTmp.Rows(i).Item("Tien_BH") = 0
                Dt_DetailTmp.Rows(i).EndEdit()
            Next
            Dt_DetailTmp.AcceptChanges()
            UpdateList()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------
        For i = 0 To nCount - 1
            Dt_DetailTmp.Rows(i).BeginEdit()
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailTmp.Rows(i).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------------
        V_T_CK(sender, e) ' Tinh lai
        '---------------------------------------------------------------------------------------
        Dim nT_Tien2 As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_CK As Decimal = 0

        Dim nT_Tien_BH As Decimal = 0
        Dim nT_Thue_BH As Decimal = 0
        '---------------------------------------------------------------------------------------
        For i = 0 To nCount - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_Tien2 = nT_Tien2 + Dt_DetailTmp.Rows(i).Item("Tien2")
                nT_Thue = nT_Thue + Dt_DetailTmp.Rows(i).Item("Thue")
                nT_CK = nT_CK + Dt_DetailTmp.Rows(i).Item("CK_I")
            End If
        Next
        '--------------------------------------------------------------------------------------------------------
        ' Tinh ra thue bao hiem va tien hang bao hiem phai tra
        If (nT_Tien2 + nT_Thue) <> 0 Then
            nT_Thue_BH = CyberSupport.V_Round(TxtT_I.Double * (nT_Thue) / (nT_Tien2 + nT_Thue - nT_CK), 0)
        Else
            TxtT_I.Double = 0
            TxtT_I.Refresh()
            UpdateList()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------
        nT_Tien_BH = TxtT_I.Double - nT_Thue_BH
        ' Phan Bo tien vat tu cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Tien0", "Tien_BH", nT_Tien_BH, 0)
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Tien0", "Thue_BH", nT_Thue_BH, 0)
        UpdateList()
    End Sub
    Private Sub V_ChkCK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkCK.Checked Then TxtT_CK.ReadOnly = False Else TxtT_CK.ReadOnly = True
        If ChkCK.Checked Then TxtT_CK.Focus()
        V_T_CK(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub TinhThue(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tien0") = Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I")
        Dv_DetailTmp.Item(iRow).EndEdit()

        If Dv_DetailTmp.Item(iRow).Item("Tien0") * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Thue") = CyberSupport.V_Round((Dv_DetailTmp.Item(iRow).Item("Tien0") * Dv_DetailTmp.Item(iRow).Item("Thue_Suat")) / 100, 0)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
#End Region
#Region "Ma_Kh_I"
    Private Sub V_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        'If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
        '    Dv_DetailTmp.Item(iRow).BeginEdit()
        '    Dv_DetailTmp.Item(iRow).EndEdit()
        'End If
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
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        'sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
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
        Dim _Tk_SPDD As String = DrReturn.Item("Tk_SPDD")
        Dim _ma_Nx_I As String = _Tk_SPDD

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Tk_VT") = IIf(Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim = "", _TK_VT, Dv_DetailTmp.Item(iRow).Item("Tk_VT").ToString.Trim)
        Dv_DetailTmp.Item(iRow).Item("Ma_Nx_I") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_Nx_I").ToString.Trim = "", _ma_Nx_I, Dv_DetailTmp.Item(iRow).Item("Ma_Nx_I").ToString.Trim)
        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetSD(iRow)
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
#End Region
#Region "Tai khoan "
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Tk_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Tk_Vt(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
    Private Sub V_Ma_Nx_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Nx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Nx_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Nx_i(M_Mode, M_Ma_CT, sender, DetailGRV)
    End Sub
#End Region
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
        'If ChkBH.Checked Then
        '    Dv_DetailTmp.Item(iRow).BeginEdit()
        '    Dv_DetailTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "I", "C", Dv_DetailTmp.Item(iRow).Item("Ma_TT"))
        '    Dv_DetailTmp.Item(iRow).EndEdit()
        'End If
        '-------------------------------------------------------------------
        Tinh_Gia2(iRow)
        V_Tinh_Toan(iRow)
        UpdateList()
        DetailGRV.UpdateCurrentRow()
        '-------------------------------------------------------------------
    End Sub
#End Region
#Region "LHBH "
    Private Sub V_Tk_Ma_LhBh(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        CyberSupport.V_Lookup("Ma_LHBH", "DmLhBh", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Tk_Ma_LhBh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_LHBH") = ""
            Dv_DetailTmp.Item(iRow)("Ten_LhBh") = ""
            Dv_DetailTmp.Item(iRow)("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow)("Ma_TT") = "", "C", Dv_DetailTmp.Item(iRow)("Ma_TT"))
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow)("Ma_LhBh") = DrReturn("Ma_LhBh").ToString.Trim
        Dv_DetailTmp.Item(iRow)("Ten_LhBh") = DrReturn("Ten_LhBh").ToString.Trim

        Dv_DetailTmp.Item(iRow)("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow)("Ma_TT") = "", "C", Dv_DetailTmp.Item(iRow)("Ma_TT"))
        GetPT_HH(M_Stt_Rec, Dv_DetailTmp.Item(iRow).Item("Ma_LHBH"), Dv_DetailTmp.Item(iRow).Item("Ma_BH"), Dv_DetailTmp.Item(iRow).Item("Ma_TT"), Dv_DetailTmp.Item(iRow).Item("pt_hh_tv"), Dv_DetailTmp.Item(iRow).Item("pt_hh_cty"), iRow)
        V_Tinh_Toan(iRow)
    End Sub

#End Region
#Region "Ma_BH "
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        CyberSupport.V_Lookup("Ma_Thue", "Dmthue", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If Not DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).Item("Ma_Thue") = DrReturn.Item("Ma_Thue")
            Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = DrReturn.Item("Thue_Suat")
        Else
            Dv_DetailTmp.Item(iRow).Item("Ma_Thue") = ""
            Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = 0
        End If
        V_Tinh_Toan(iRow)
    End Sub

    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        CyberSupport.V_Lookup("Ma_BH", "DmBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode <> "S" And M_Mode <> "M" Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).Item("Ma_BH") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_BH") = ""
            Dv_DetailTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "", "C", Dv_DetailTmp.Item(iRow).Item("Ma_TT"))
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_BH") = DrReturn.Item("Ma_BH").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ten_BH") = DrReturn.Item("ten_BH").ToString.Trim
        Dv_DetailTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "", "C", Dv_DetailTmp.Item(iRow).Item("Ma_TT"))
        Dv_DetailTmp.Item(iRow).EndEdit()

        GetPT_HH(M_Stt_Rec, Dv_DetailTmp.Item(iRow).Item("Ma_LHBH"), Dv_DetailTmp.Item(iRow).Item("Ma_BH"), Dv_DetailTmp.Item(iRow).Item("Ma_TT"), Dv_DetailTmp.Item(iRow).Item("pt_hh_tv"), Dv_DetailTmp.Item(iRow).Item("pt_hh_cty"), iRow)
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub GetPT_HH(ByVal stt_rec As String, ByVal Ma_LHBH As String, ByVal Ma_BH As String, ByVal Ma_TT As String, ByVal PT_HH_TV As Decimal, ByVal PT_HH_CTY As Decimal, ByVal iRow As Decimal)
        Dim DsTienPTHH As DataSet
        Dim Dt As Date
        Dt = TxtNgay_Ct.Value
        Dim iTai_tung As Integer = 0
        If ChkTai_tung.Checked Then
            iTai_tung = 1
        End If
        Dim iLien_ket As Integer = 0
        'If ChkLien_ket.Checked Then
        '    iLien_ket = 1
        'End If
        DsTienPTHH = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetPTHHBH", stt_rec.Trim + "#" + iLien_ket.ToString.Trim + "#" + _
                                                        iTai_tung.ToString.Trim + "#" + Ma_LHBH + "#" + Ma_BH + "#" + Ma_TT + "#" + _
        TxtGT_Xe.Double.ToString.Trim.Replace(" ", "").Replace(",", ".") + "#" + _
        PT_HH_CTY.ToString.Trim.Replace(" ", "").Replace(",", ".") + "#" + _
        PT_HH_CTY.ToString.Trim.Replace(" ", "").Replace(",", ".") + "#" + _
        Dt.ToString("yyyyMMdd") + "#" + M_Mode + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Pt_Hh_Tv") = DsTienPTHH.Tables(0).Rows(0).Item("pt_hh_tv")
        Dv_DetailTmp.Item(iRow).Item("Pt_Hh_Cty") = DsTienPTHH.Tables(0).Rows(0).Item("pt_hh_cty")
        Dv_DetailTmp.Item(iRow).EndEdit()
        DsTienPTHH.Dispose()
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

        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
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
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, DsLookUp, TxtMa_NT.Text, "Ma_NT", "DmNT", DrReturn, "1=1", "1=1", "1")
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
        '----------------------------------------------------------------------------------------------------------------------
        '----DmXe
        Dim _DtDmxeXe As DataTable = DtDmXestru.Clone
        Dim _DrDmxeXe As DataRow = _DtDmxeXe.NewRow
        _DrDmxeXe.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrDmxeXe)
        CyberSmodb.AddValueToRow(_DrDmxeXe, Me)
        If DtDmXestru.Columns.Contains("Stt_Rec") Then _DrDmxeXe.Item("Stt_Rec") = M_Stt_Rec
        If DtDmXestru.Columns.Contains("Ma_Ct") Then _DrDmxeXe.Item("Ma_Ct") = M_Ma_CT
        If DtDmXestru.Columns.Contains("Ma_Dvcs") Then _DrDmxeXe.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrDmxeXe.EndEdit()
        _DtDmxeXe.Rows.Add(_DrDmxeXe)
        _DtDmxeXe.AcceptChanges()
        '----------------------------------------------------------------------------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), _DtDmxeXe}, {M_Ct, M_Ph, "DMXE"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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
        '---------------------------------------------------
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
        'For iRow = nCount - 1 To 0 Step -1
        '    If Dt_DetailTmp.Rows(iRow).Item("MA_LHBH").ToString.Trim = "" Then
        '        Dt_DetailTmp.Rows(iRow).Delete()
        '        Dt_DetailTmp.AcceptChanges()
        '    End If
        'Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            If Dt_DetailTmp.Columns.Contains("MA_HD_I") Then
                If Not TxtMa_Td3_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_HD_I") = TxtMa_Td3_H.Text.Trim
            End If
            If Dt_DetailTmp.Columns.Contains("MA_BP_I") Then
                If Not TxtMa_Bp_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_BP_I") = TxtMa_Bp_H.Text.Trim
            End If
            If Dt_DetailTmp.Columns.Contains("MA_HS_I") Then
                If Not TxtMa_hs_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_HS_I") = TxtMa_hs_H.Text.Trim
            End If

            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        UpdateList()
        ChkVsave = True
    End Function
    Private Function ChkSaveDelete(ByVal _Mode As String, Optional ByVal strField As String = "", Optional ByVal strValue As String = "") As Boolean

        Dim _Ma_Xe = TxtMa_Xe.Text.Trim
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        If strField.Trim = "" And strValue.Trim = "" Then CyberSmodb.GetValueControler(Me, strField, strValue)

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkSaveDeleterHDI", strField & "#" & strValue & "#" & _Ma_Xe & "#" & _
                                                                  _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT & "#" & _
                                                                  TxtSo_RO.Text.Trim.Replace("#", "") & "#" & TxtSo_RO.Text.Trim.Replace("#", "") & "#" & _
                                                                  M_Stt_Rec & "#" & _Ma_Post & "#" & _Ma_GD & "#" & _
                                                                  _Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
            Dstmp.Dispose()
            Return False
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------
        If _Mode.Trim = "D" Then
            Dstmp.Dispose()
            Return True
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------
        If _Mode.Trim = "M" And Dstmp.Tables(0).Columns.Contains("So_RO") Then TxtSo_RO.Text = Dstmp.Tables(0).Rows(0).Item("So_RO").ToString.Trim
        If _Mode.Trim = "M" And Dstmp.Tables(0).Columns.Contains("So_BG") Then TxtSo_Bg.Text = Dstmp.Tables(0).Rows(0).Item("So_BG").ToString.Trim
        Dstmp.Dispose()
        '--------------------------------------------------------------------------------------------------------------------------------------------
        For iRow As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        '--------------------------------------------------------------------------------------------------------------------------------------------
        ChkSaveDelete = True
    End Function
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
        V_New()
        '----------------------------------------------------------------------------
        V_GetNgamDinh()
        '----------------------------------------------------------------------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        '----------------------------------------------------------------------------
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
        '----------------------------------------------------------------------------

    End Sub
    Private Sub V_GetNgamDinh()
        '----------------------------------------------------------------------------
        '----------------------------------------------------------------------------
        CbbMa_Post.SelectedValue = "2"
        '----------------------------------------------------------------------------
        If M_Ma_TP_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_TP.SelectedValue = M_Ma_TP_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If
        If M_Ma_Quan_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_Quan.SelectedValue = M_Ma_Quan_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If
        If M_Ma_Xa_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_Xa.SelectedValue = M_Ma_Xa_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If

        Try
            CmbVai_Tro.SelectedValue = M_Vai_Tro_Ngam_Dinh
        Catch ex As Exception
        End Try
        Try
            CmbMa_HTLL.SelectedValue = M_Ma_HTLL_Ngam_Dinh
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------
        TxtMa_Hs_H.Text = M_Ma_Hs
        TxtTen_Hs_H.Text = M_Ten_Hs
        TxtMa_Bp_H.Text = M_Ma_BP
        TxtTen_Bp_H.Text = M_Ten_BP
        '----------------------------------------------------------------------------
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            If Not M_Tk_Co.Trim = "" Then
                If DrCurren.Table.Columns.Contains("Ma_Nx_I") Then DrCurren.Item("Ma_Nx_I") = M_Tk_Co.Trim
                If DrCurren.Table.Columns.Contains("Ten_Nx_I") Then DrCurren.Item("Ten_Nx_I") = M_Ten_Tk_Co.Trim
            End If

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"
            DrCurren.Item("Stt_Rec0") = "0001"
            DrCurren.Item("So_luong") = 1
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
        If Not ChkSaveDelete("D") Then Exit Sub
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

        TxtSo_khung.ReadOnly = True
        TxtSo_May.ReadOnly = True

        TxtT_Tien2.ReadOnly = True
        TxtT_I.ReadOnly = True
        TxtT_W.ReadOnly = True
        TxtT_N.ReadOnly = True
        TxtT_C.ReadOnly = True
        TxtT_TT.ReadOnly = True

        TxtT_CK.ReadOnly = True
        TxtT_Thue.ReadOnly = True
        TxtT_HH_TV.ReadOnly = True
        TxtT_HH_CTY.ReadOnly = True
        TxtT_HH.ReadOnly = True


        TxtSo_RO.ReadOnly = True
        TxtSo_Bg.ReadOnly = True

        If M_Mode = "M" Or M_Mode = "S" Then
            If ChkCK.Checked Then TxtT_CK.ReadOnly = False
            If ChkBH.Checked Then TxtT_I.ReadOnly = False
        End If
        Me.Bar_Approval.Enabled = False
    End Sub
#End Region
#Region "Option: LSSC/hen/"
    Private Sub V_Han_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Thamsobaohiem(M_Ma_CT, TxtMa_Xe.Text, TxtTen_kh.Text, TxtDia_Chi.Text, TxtDien_Thoai.Text, TxtDt_LX.Text)
    End Sub
    Private Sub V_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _Date As Date = New Date(1900, 1, 1)
        Dim _Loai_SC As String = "1"

        Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP_H, "DLH", "M", "HEN", _Loai_SC, "", "", M_Ma_Hs, "", TxtMa_Xe.Text, "", "", _Date, _Date, AppConn, SysVar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Ds_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberWork As New Cyber.Workprogress.Sys
        CyberSupport.V_WorkView("CP_WorkDLH", "", "DANH SÁCH LỊCH HẸN SỬA CHỮA", True, M_Ma_Dvcs, M_User_Name, AppConn, osysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Lich_Su(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, M_Ma_CT, M_Stt_Rec, AppConn, Me.SysVar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Thamsobaohiem(ByVal _ma_Ct As String, ByVal _Ma_Xe As String, ByVal _Ten_kh As String, ByVal _Dia_Chi As String, ByVal _Dien_Thoai As String, ByVal _DT_Lx As String)
        ''If Not (M_Ma_CT = "HDK") Then Exit Sub
        Dim dsBaohiem As DataSet

        dsBaohiem = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetNgayBH", _ma_Ct.Trim + "#" + _Ma_Xe.Trim + "#" + _Ten_kh.Trim + "#" + _Dia_Chi.Trim + "#" + _Dien_Thoai.Trim + "#" + _DT_Lx.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If dsBaohiem.Tables(0).Rows.Count < 1 Then Exit Sub
        If dsBaohiem.Tables(0).Rows(0).Item("Status").ToString.Trim.ToUpper = "N" Then
            dsBaohiem.Dispose()
            Exit Sub
        End If
        Dim Frm As New FrmbaoHiem
        Frm._Dr = dsBaohiem.Tables(0).Rows(0)
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = osysvar
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
        dsBaohiem.Dispose()
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