Imports System.Data.SqlClient
Public Class HDX
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim TbTP, TbQuan, TbXa As New DataTable
    Dim Dt_DetailPK, Dt_DetailtmpPK As New DataTable
    Dim Dv_DetailPK, Dv_DetailtmpPK As New DataView
    Public vTbTP, vTbQuan, vTbXa As DataView
#End Region
#Region "Khai bao bien Paramater----------------------"
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys
#End Region
#Region "Columns Edit"
    Dim EditMa_Lo, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_Phi_i, EditMa_HD_I, EditMa_SP_I, EditMa_Ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Db_I, EditMa_Xe_I, EditMa_Kx_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditGia_Nt, EditGia, EditTien_Nt, EditTien, EditThu_Them, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_CSBH, EditMa_Kx, EditMa_Mau, EditTen_Kx, EditTen_Mau, EditNgay_Gx As New Cyber.Fill.CyberColumnGridView
    Dim EditNgay1, EditNgay2, EditNgay3, EditNgay4, EditGt1, EditGt2, EditGt3, EditGt4 As New Cyber.Fill.CyberColumnGridView
    Dim EditPT_CK, EditCK, EditT_TT_NT, EditT_TT, EditMoi_Gioi, EditMoi_Gioi_Tn, EditKm_PK, EditKm_BH, EditKm_Khac, EditPk_BB, EditBH_BB, EditKhac_BB As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Pk, EditTen_Pk, EditDvtpk, EditSo_luongPK, EditGiaPK, EditGia_NtPK, EditTienPK, EditTien_NtPK, EditCOTCUOIPK As New Cyber.Fill.CyberColumnGridView
    Dim EditPT_CKPK, EditCKPK, EditT_TT_NTPK, EditT_TTPK, EditLuong_TVBH As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Mau_Nt, EditTen_Mau_Nt As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable

    Dim M_Ma_HTLL_Ngam_Dinh As String = ""
    Dim M_Ma_MDSD_Ngam_Dinh As String = ""
    Dim M_Ma_HTMX_Ngam_Dinh As String = ""
    Dim M_Ma_DKGX_Ngam_Dinh As String = ""
    Dim M_Ky_HD_Ngam_Dinh As String = ""
    Dim M_Cv_Ky_HD_Ngam_Dinh As String = ""
    Dim M_Tk_Nh_Ngam_Dinh As String = ""

    Dim Dt_HTLL, Dt_MDSD, Dt_HTMX, Dt_DKGX, Dt_Ky_HD, Dt_TK_NH As DataTable

    Dim _Para_So_BG As String = ""
    Dim _Para_Id_KH As String = ""

    Dim M_Ma_TP_Ngam_Dinh As String = ""
    Dim M_Ma_Quan_Ngam_Dinh As String = ""
    Dim M_Ma_Xa_Ngam_Dinh As String = ""
    Dim _ViviBlePK As Boolean = False
#End Region
    Private Sub HDX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        V_MainSystemPK()
        GetRound()
        CmdNew.Select()
        V_LoadNew(sender, e)
        If _ViviBlePK = False Then
            Dim ntab As Integer = TabControl1.TabCount - 1
            For i As Integer = ntab To 0 Step -1
                If TabControl1.TabPages(i).Name.Trim.ToUpper = "Tab_PK".Trim.ToUpper Then
                    TabControl1.TabPages.Remove(TabControl1.TabPages(i))
                End If
            Next
            LabT_PK_NT.Visible = False
            TxtT_PK_NT.Visible = False
        End If

        LabT_Vuot_khung.Visible = Dt_DetailTmp.Columns.Contains("Vuot_Khung")
        TxtT_Vuot_Khung.Visible = Dt_DetailTmp.Columns.Contains("Vuot_Khung")
    End Sub
#Region "Load And Set And Default"
    Private Sub V_LoadNew(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _Para_So_BG.Trim = "" And _Para_Id_KH.Trim = "" Then Exit Sub
        V_New(sender, e)
        V_GetMaBP()
        If Not M_Mode = "M" Then Exit Sub

        TxtSo_BG.Text = _Para_So_BG
        TxtID_KH.Text = _Para_Id_KH
        If _Para_So_BG.Trim.Trim <> "" Then
            L_So_BG(sender, e)
            Return
        End If
        If _Para_Id_KH.Trim <> "" Then
            'L_ID_KH(sender, e)
            V_Get_Id_kh()
            Return
        End If
    End Sub
    Private Sub V_Load()
        V_Getdefault()
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)

        Dt_DetailPK = M_DsData.Tables(2)
        Dt_DetailtmpPK = Dt_DetailPK.Clone

        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_DetailPK = New DataView(Dt_DetailPK)
        Dv_DetailtmpPK = New DataView(Dt_DetailtmpPK)
        Dv_Master = New DataView(Dt_Master)

        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        '-------------
        DetailPK.DataSource = Dv_DetailtmpPK
        Me.DetailGRVPK.GridControl = Me.DetailPK
        CyberFill.V_FillVoucher(DetailGRVPK, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailtmpPK, Me.DrDmct)

        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)
        TxtT_So_Luong.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_So_Luong.InputMask)

        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_CK.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_CK.InputMask)
        TxtT_TT_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_TT_NT.InputMask)
        TxtT_GG_CS.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_GG_CS.InputMask)
        TxtT_Vuot_Khung.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Vuot_Khung.InputMask)

        TxtT_Km_PK.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Km_PK.InputMask)
        TxtT_Moi_Gioi.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Moi_Gioi.InputMask)
        TxtT_Km_BH.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Km_BH.InputMask)
        TxtT_Km_Khac.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Km_Khac.InputMask)
        TxtT_KM.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_KM.InputMask)

        TxtT_PK_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_PK_BB.InputMask)
        TxtT_BH_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_BH_BB.InputMask)
        TxtT_khac_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_khac_BB.InputMask)
        TxtT_BB.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_BB.InputMask)
        TxtT_PK_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_PK_NT.InputMask)

        TxtT_Gt1.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Gt1.InputMask)
        TxtT_Gt2.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Gt2.InputMask)
        TxtT_Gt3.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Gt3.InputMask)
        TxtT_Gt4.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Gt4.InputMask)
        TxtT_Thu_Them.InputMask = IIf(DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim <> "", DrDmct.Item("M_IP_MK_Tien_Nt").ToString.Trim, TxtT_Thu_Them.InputMask)
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
        '---------------------------------------------------------------------------------------------'
        _Para_Id_KH = ""
        Try
            _Para_Id_KH = M_Para(M_VT_PARA + 3).Trim
        Catch ex As Exception

        End Try
        _Para_So_BG = ""
        Try
            _Para_So_BG = M_Para(M_VT_PARA + 4).Trim
        Catch ex As Exception

        End Try

        V_LoadDefaultHDX()
        '--------------------------------------------------------------------------------------------
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
    Private Sub V_LoadDefaultHDX()
        Dim DsTpQuanXa As New DataSet
        DsTpQuanXa = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultHDX", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        TbTP = DsTpQuanXa.Tables(0).Copy
        vTbTP = New DataView(TbTP)

        TbQuan = DsTpQuanXa.Tables(1).Copy
        vTbQuan = New DataView(TbQuan)

        TbXa = DsTpQuanXa.Tables(2).Copy
        vTbXa = New DataView(TbXa)

        Dt_HTLL = DsTpQuanXa.Tables(3).Copy
        Dt_Ky_HD = DsTpQuanXa.Tables(4).Copy

        Dt_MDSD = DsTpQuanXa.Tables(5).Copy
        Dt_HTMX = DsTpQuanXa.Tables(6).Copy
        Dt_DKGX = DsTpQuanXa.Tables(7).Copy

        'Tk_Nh
        Dt_TK_NH = DsTpQuanXa.Tables(8).Copy
        DsTpQuanXa.Dispose()
        '--------------------------------------------------------------------------------------------
        '=========== FillCombox
        CyberFill.V_FillComBoxValue(CmbMa_TP, vTbTP, "ma_Tp", "Ten_Tp", "")
        CyberFill.V_FillComBoxValue(CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan", "")
        CyberFill.V_FillComBoxValue(CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa", "")
        '------------
        'CyberFill.V_FillComBoxDefaul(CmbVai_Tro, Dt_vai_tro, "Vai_Tro", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, Dt_HTLL, "MA_HTLL", "Ten_HTLL", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_MDSD, Dt_MDSD, "MA_MDSD", "Ten_MDSD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTMX, Dt_HTMX, "MA_HTMX", "Ten_HTMX", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_DKGX, Dt_DKGX, "MA_DKGX", "Ten_DKGX", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CmbKy_HD, Dt_Ky_HD, "MA_HS", "Ten_Hs", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbCv_Ky_KD, Dt_Ky_HD, "Chuc_Vu", "Chuc_Vu", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CmbMa_Nh, Dt_TK_NH, "Ma_NH", "Ten_NH", "Ngam_Dinh")
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
        If Dt_HTLL.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_HTLL.Rows.Count - 1
                If Dt_HTLL.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_HTLL_Ngam_Dinh = Dt_HTLL.Rows(i).Item("Ma_HTLL").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_Ky_HD.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_Ky_HD.Rows.Count - 1
                If Dt_Ky_HD.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ky_HD_Ngam_Dinh = Dt_Ky_HD.Rows(i).Item("Ma_Hs").ToString.Trim
                    M_Cv_Ky_HD_Ngam_Dinh = Dt_Ky_HD.Rows(i).Item("Chuc_Vu").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_MDSD.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_MDSD.Rows.Count - 1
                If Dt_MDSD.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_MDSD_Ngam_Dinh = Dt_MDSD.Rows(i).Item("Ma_MDSD").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_HTMX.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_HTMX.Rows.Count - 1
                If Dt_HTMX.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_HTMX_Ngam_Dinh = Dt_HTMX.Rows(i).Item("Ma_HTMX").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_DKGX.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_DKGX.Rows.Count - 1
                If Dt_DKGX.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_DKGX_Ngam_Dinh = Dt_DKGX.Rows(i).Item("Ma_DKGX").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If Dt_TK_NH.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_TK_NH.Rows.Count - 1
                If Dt_TK_NH.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Tk_Nh_Ngam_Dinh = Dt_TK_NH.Rows(i).Item("Ma_Nh").ToString.Trim
                    Exit For
                End If
            Next
        End If
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
        If FixCol < DetailGRVPK.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVPK.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

        DetailGRVPK.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVPK.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

    End Sub
    Private Sub V_GetColumn()
        EditMa_Lo.GetColumn(DetailGRV, "Ma_Lo")
        EditMa_Vitri.GetColumn(DetailGRV, "Ma_Vitri")

        EditMa_CSBH.GetColumn(DetailGRV, "Ma_CSBH")

        EditMa_Kx.GetColumn(DetailGRV, "Ma_Kx")
        EditMa_Mau.GetColumn(DetailGRV, "Ma_Mau")

        EditTen_Kx.GetColumn(DetailGRV, "Ten_Kx")
        EditTen_Mau.GetColumn(DetailGRV, "Ten_Mau")
        EditNgay_Gx.GetColumn(DetailGRV, "Ngay_Gx")

        EditNgay1.GetColumn(DetailGRV, "Ngay1")
        EditNgay2.GetColumn(DetailGRV, "Ngay2")
        EditNgay3.GetColumn(DetailGRV, "Ngay3")
        EditNgay4.GetColumn(DetailGRV, "Ngay4")

        EditGt1.GetColumn(DetailGRV, "Gt1")
        EditGt2.GetColumn(DetailGRV, "Gt2")
        EditGt3.GetColumn(DetailGRV, "Gt3")
        EditGt4.GetColumn(DetailGRV, "Gt4")

        EditPT_CK.GetColumn(DetailGRV, "PT_CK")
        EditCK.GetColumn(DetailGRV, "CK")
        EditT_TT_NT.GetColumn(DetailGRV, "T_TT_NT")
        EditT_TT.GetColumn(DetailGRV, "T_TT")

        EditKm_PK.GetColumn(DetailGRV, "Km_PK")
        EditKm_BH.GetColumn(DetailGRV, "Km_BH")
        EditMoi_Gioi.GetColumn(DetailGRV, "Moi_Gioi")
        EditLuong_TVBH.GetColumn(DetailGRV, "Luong_TVBH")

        EditMoi_Gioi_Tn.GetColumn(DetailGRV, "Moi_Gioi_Tn")
        EditKm_Khac.GetColumn(DetailGRV, "km_khac")

        EditPk_BB.GetColumn(DetailGRV, "Pk_BB")
        EditBH_BB.GetColumn(DetailGRV, "BH_BB")
        EditKhac_BB.GetColumn(DetailGRV, "Khac_BB")

        EditMa_Pk.GetColumn(DetailGRVPK, "Ma_Pk")
        EditTen_Pk.GetColumn(DetailGRVPK, "Ten_Pk")
        EditSo_luongPK.GetColumn(DetailGRVPK, "So_luong")
        EditGia_NtPK.GetColumn(DetailGRVPK, "Gia_Nt")
        EditTienPK.GetColumn(DetailGRVPK, "Tien")
        EditTien_NtPK.GetColumn(DetailGRVPK, "Tien_Nt")

        EditGiaPK.GetColumn(DetailGRVPK, "Gia")
        EditDvtpk.GetColumn(DetailGRVPK, "Dvt")

        EditPT_CKPK.GetColumn(DetailGRVPK, "PT_CK")
        EditCKPK.GetColumn(DetailGRVPK, "Ck")
        EditT_TT_NTPK.GetColumn(DetailGRVPK, "T_TT_NT")
        EditT_TTPK.GetColumn(DetailGRVPK, "T_TT")

        EditMa_Kho_I.GetColumn(DetailGRV, "Ma_Kho_I")
        EditDien_Giaii.GetColumn(DetailGRV, "Dien_Giaii")

        EditSo_Luong.GetColumn(DetailGRV, "So_Luong")
        EditGia_Nt.GetColumn(DetailGRV, "Gia_Nt")
        EditGia.GetColumn(DetailGRV, "Gia")
        EditTien_Nt.GetColumn(DetailGRV, "Tien_Nt")
        EditTien.GetColumn(DetailGRV, "Tien")

        EditThu_Them.GetColumn(DetailGRV, "Thu_Them")

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

        EditMa_Db_I.GetColumn(DetailGRV, "Ma_Db_I")
        EditMa_Xe_I.GetColumn(DetailGRV, "MA_XE_I")
        EditMa_Tuyen_I.GetColumn(DetailGRV, "Ma_Tuyen_I")
        EditMa_Ts.GetColumn(DetailGRV, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRV, "Ma_Cc")
        EditMa_Mau_Nt.GetColumn(DetailGRV, "Ma_Mau_Nt")
        EditTen_Mau_Nt.GetColumn(DetailGRV, "Ten_Mau_Nt")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                '  If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
                TxtID_KH.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtOng_Ba.Focus()
                TxtTen_Kh.Focus()
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
        AddHandler CmdPrintAll.Click, AddressOf V_In_HD
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

        AddHandler CmdXem_TT.Click, AddressOf V_Xem_TT
        '---
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        AddHandler DetailGRVPK.PopupMenuShowing, AddressOf MasterGRVPK_PopupMenuShowing
        AddHandler DetailGRVPK.KeyDown, AddressOf MasterGRVPK_KeyDown
        '---
        AddHandler CmbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_quan_SelectedIndexChanged

        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia
        'ID_KH
        AddHandler TxtID_KH.CyberValiting, AddressOf V_ID_KH
        AddHandler TxtID_KH.CyberLeave, AddressOf L_ID_KH
        ''Ma_Kh
        'AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        'AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtTen_Kh.Leave, AddressOf L_Ten_Kh
        AddHandler TxtDia_Chi.Leave, AddressOf L_Dia_Chi

        AddHandler TxtDien_Thoai.Leave, AddressOf L_Dien_Thoai
        AddHandler TxtFax.Leave, AddressOf L_Fax

        AddHandler TxtOng_Ba.Leave, AddressOf L_Ong_Ba
        AddHandler TxtTen_Kh.Leave, AddressOf L_Ten_Kh

        AddHandler TxtTen_KhVAT.Leave, AddressOf L_Ten_KhVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf L_Dia_ChiVat
        'Ma_BP_H
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_Bp_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_bp_H
        'Ma_Hs_H
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_HS_H
        'Ma_SK
        AddHandler TxtMa_SK.CyberValiting, AddressOf V_Ma_SK
        AddHandler TxtMa_SK.CyberLeave, AddressOf L_Ma_SK
        'Ma_GPK
        AddHandler TxtMa_GPK.CyberValiting, AddressOf V_Ma_GPK
        AddHandler TxtMa_GPK.CyberLeave, AddressOf L_Ma_GPK
        'Ma_LHKH
        AddHandler TxtMa_LHKH.CyberValiting, AddressOf V_Ma_LHKH
        AddHandler TxtMa_LHKH.CyberLeave, AddressOf L_Ma_LHKH
        'Nh_HD1
        AddHandler TxtNh_HD1.CyberValiting, AddressOf V_Nh_HD1
        AddHandler TxtNh_HD1.CyberLeave, AddressOf L_Nh_HD1
        'Nh_HD2
        AddHandler TxtNh_HD2.CyberValiting, AddressOf V_Nh_HD2
        AddHandler TxtNh_HD2.CyberLeave, AddressOf L_Nh_HD2
        'Nh_HD3
        AddHandler TxtNh_HD3.CyberValiting, AddressOf V_Nh_HD3
        AddHandler TxtNh_HD3.CyberLeave, AddressOf L_Nh_HD3
        '----------------------------------------------------------------------------------------------------------
        AddHandler CbmSo_BG.Click, AddressOf V_Chon_So_BG

        AddHandler TxtSo_BG.Leave, AddressOf L_So_BG
        AddHandler TxtMa_HD_H.Leave, AddressOf L_Ma_Hd_H
        AddHandler TxtDT_LX.Leave, AddressOf L_DT_LX
        '
        AddHandler CmdVay.Click, AddressOf V_UpdateVayNH

        AddHandler CmdHuy_HD.Click, AddressOf V_Huy_Hd
        AddHandler CmdLuuCoc.Click, AddressOf V_Luu_Coc

        'AddHandler lblMa_kh.Click, AddressOf V_Ma_KH_Click
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtLenh_SO.Leave, AddressOf L_Lenh_So

        AddHandler TxtLenh_PO.Leave, AddressOf L_Lenh_Po
        AddHandler TxtLenh_RO.Leave, AddressOf L_Lenh_Ro
        AddHandler TxtLenh_Vt.Leave, AddressOf L_Lenh_VT
        '----------------------------------------------------------------------------------------------------------
        AddHandler CmdPhu_Kien.Click, AddressOf V_Phu_Kien
        AddHandler CmdE_Mail_KH.Click, AddressOf V_E_MaiL_KH
        AddHandler CmdE_Mail_Duyet.Click, AddressOf V_E_MaiL_Duyet
        '----------------------------------------------------------------------------------------------------------
        AddHandler CmdTao_DN.Click, AddressOf V_Tao_De_nghi
        '
        AddHandler ChkIs_DonHang.CheckedChanged, AddressOf V_Chk_Is_DonHang
        '-----------------
        AddHandler ChkTra_Thang.CheckedChanged, AddressOf V_Chk_Tra_Thang
        AddHandler ChkTra_Gop.CheckedChanged, AddressOf V_Chk_Tra_Gop
        AddHandler ChkTra_Thue_Mua.CheckedChanged, AddressOf V_Chk_Tra_Thue_Mua
        AddHandler ChkTra_Cham.CheckedChanged, AddressOf V_Chk_Tra_Cham
        AddHandler CmbKy_HD.SelectedValueChanged, AddressOf V_CbbKy_Hd
        AddHandler BttXuat_Word.Click, AddressOf V_XuatWord
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_Nt.Column Is Nothing Then AddHandler EditGia_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt.Column Is Nothing Then AddHandler EditTien_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThu_Them.Column Is Nothing Then AddHandler EditThu_Them.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditNgay_Gx.Column Is Nothing Then AddHandler EditNgay_Gx.EditColumn.Leave, AddressOf V_Ngay_Gx

        If Not EditPT_CK.Column Is Nothing Then AddHandler EditPT_CK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditCK.Column Is Nothing Then AddHandler EditCK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditT_TT_NT.Column Is Nothing Then AddHandler EditT_TT_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditT_TT.Column Is Nothing Then AddHandler EditT_TT.EditColumn.Leave, AddressOf L_Tinh_Toan


        If Not EditKm_PK.Column Is Nothing Then AddHandler EditKm_PK.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditKm_BH.Column Is Nothing Then AddHandler EditKm_BH.EditColumn.Leave, AddressOf L_Tinh_Toan
        'If Not EditMoi_Gioi.Column Is Nothing Then AddHandler EditMoi_Gioi.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditLuong_TVBH.Column Is Nothing Then AddHandler EditLuong_TVBH.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditMoi_Gioi_Tn.Column Is Nothing Then AddHandler EditMoi_Gioi_Tn.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditKm_Khac.Column Is Nothing Then AddHandler EditKm_Khac.EditColumn.Leave, AddressOf L_Tinh_Toan

        If Not EditPk_BB.Column Is Nothing Then AddHandler EditPk_BB.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditBH_BB.Column Is Nothing Then AddHandler EditBH_BB.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditKhac_BB.Column Is Nothing Then AddHandler EditKhac_BB.EditColumn.Leave, AddressOf L_Tinh_Toan

        'If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii
        '-------------------------------------
        EditMa_CSBH.V_ActiLookUpColumn(AddressOf V_Ma_CSBH, AddressOf L_Ma_CSBH)

        EditMa_Kx.V_ActiLookUpColumn(AddressOf V_Ma_Kx, AddressOf L_Ma_Kx)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)
        EditMa_Mau_Nt.V_ActiLookUpColumn(AddressOf V_Ma_Mau_Nt, AddressOf L_Ma_Mau_Nt)
        If Not EditTen_Kx.Column Is Nothing Then EditTen_Kx.EditColumn.ReadOnly = True
        If Not EditTen_Mau.Column Is Nothing Then EditTen_Mau.EditColumn.ReadOnly = True

        If Not EditNgay1.Column Is Nothing Then AddHandler EditNgay1.EditColumn.Leave, AddressOf V_Ngay1
        If Not EditNgay2.Column Is Nothing Then AddHandler EditNgay2.EditColumn.Leave, AddressOf V_Ngay2
        If Not EditNgay3.Column Is Nothing Then AddHandler EditNgay3.EditColumn.Leave, AddressOf V_Ngay3
        If Not EditNgay4.Column Is Nothing Then AddHandler EditNgay4.EditColumn.Leave, AddressOf V_Ngay4

        If Not EditGt1.Column Is Nothing Then AddHandler EditGt1.EditColumn.Leave, AddressOf V_Gt1
        If Not EditGt2.Column Is Nothing Then AddHandler EditGt2.EditColumn.Leave, AddressOf V_Gt2
        If Not EditGt3.Column Is Nothing Then AddHandler EditGt3.EditColumn.Leave, AddressOf V_Gt3
        If Not EditGt4.Column Is Nothing Then AddHandler EditGt4.EditColumn.Leave, AddressOf V_Gt4

        EditMa_Pk.V_ActiLookUpColumn(AddressOf V_Ma_Pk, AddressOf L_Ma_Pk)
        If Not EditGia_NtPK.Column Is Nothing Then AddHandler EditGia_NtPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK
        If Not EditTien_NtPK.Column Is Nothing Then AddHandler EditTien_NtPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK
        If Not EditSo_luongPK.Column Is Nothing Then AddHandler EditSo_luongPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK

        If Not EditPT_CKPK.Column Is Nothing Then AddHandler EditPT_CKPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK
        If Not EditCKPK.Column Is Nothing Then AddHandler EditCKPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK
        If Not EditT_TT_NTPK.Column Is Nothing Then AddHandler EditT_TT_NTPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK
        If Not EditT_TTPK.Column Is Nothing Then AddHandler EditT_TTPK.EditColumn.Leave, AddressOf L_Tinh_ToanPK

        EditMa_Lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)

        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_i, AddressOf L_Ma_Kho_i)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_Phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_SP_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_Ku_I.V_ActiLookUpColumn(AddressOf V_Ma_Ku_i, AddressOf L_Ma_Ku_i)
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
        EditMa_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_I, AddressOf L_Ma_Db_I)
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
        AddHandler DetailGRVPK.RowCellStyle, AddressOf DetailGRVPK_RowCellStyle
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVPK_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVPK, Dt_DetailtmpPK, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_NT()
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            EditTien.Visible = False
            EditGia.Visible = False
        Else
            EditTien.Visible = True
            EditGia.Visible = True
        End If
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
    End Sub
    Private Sub VisibleColumnMa_GD()
    End Sub
    Private Sub V_Chk_Is_DonHang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If ChkIs_DonHang.Checked = True Then
        '    TxtLenh_SO.Enabled = True
        'Else
        '    TxtLenh_SO.Text = ""
        '    TxtLenh_SO.Enabled = False
        'End If

    End Sub
    Private Sub V_Chk_Tra_Thang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkTra_Thang.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If
    End Sub
    Private Sub V_CbbKy_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Vt_Cv_Ky_HD.RowFilter = "Ma_Hs = '" + CmbKy_HD.SelectedValue + "'"
    End Sub
    Private Sub V_Chk_Tra_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkTra_Gop.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Thang.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If
    End Sub
    Private Sub V_Chk_Tra_Thue_Mua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkTra_Thue_Mua.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thang.Checked = False
        End If
    End Sub
    Private Sub V_Chk_Tra_Cham(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkTra_Cham.Checked = True Then
            ChkTra_Thang.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If
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
        Dt_DetailtmpPK.Clear()
        Dt_DetailtmpPK.AcceptChanges()
        For i = 0 To Dt_DetailPK.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailtmpPK.ImportRow(Dt_DetailPK.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        M_Count = Dt_DetailTmp.Rows.Count
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
        If Not Drv Is Nothing Then V_SelectTP_Quan_Xa(Drv.Item("Ma_TP"), Drv.Item("Ma_Quan"), Drv.Item("Ma_Xa"))
    End Sub
    Private Sub V_SelectTP_Quan_Xa(ByVal _Ma_TP As String, ByVal _Ma_Quan As String, ByVal _Ma_Xa As String)
        Try
            CmbMa_TP.SelectedValue = _Ma_TP.Trim
        Catch ex As Exception
        End Try
        Try
            CmbMa_Quan.SelectedValue = _Ma_Quan.Trim
        Catch ex As Exception
        End Try
        Try
            CmbMa_Xa.SelectedValue = _Ma_Xa.Trim
        Catch ex As Exception

        End Try
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRV.OptionsBehavior.Editable = True
            DetailGRVPK.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
            TxtLenh_SO.Enabled = False
        Else
            DetailGRV.OptionsBehavior.Editable = False
            DetailGRVPK.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CmbMa_GD.Enabled = False
        If M_Mode = "M" Then CmbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRV, M_Mode)
        CyberFill.SetFoCusGRV(DetailGRVPK, M_Mode)
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
#Region "Xem thông tin xe"
    Private Sub V_Xem_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New FrmXemTT

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

        frm.ShowDialog()
        If Not frm.Save_OK Then Exit Sub
    End Sub
#End Region
#Region "Valid - Master"
    Private Sub V_TaoHD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec = "" Then Exit Sub
        Dim _DsLoc As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintHDX_HD", M_Stt_Rec & "#" & M_Ma_Dvcs & "#" + M_User_Name.ToString.Trim)
        If Not CyberSupport.V_MsgChk(_DsLoc.Tables(0), SysVar, M_LAN) Then
            _DsLoc.Dispose()
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        Dim _File_Name As String = _DsLoc.Tables(0).Rows(0).Item("File_Name").ToString.Trim
        Dim _File_Path As String = _DsLoc.Tables(0).Rows(0).Item("File_Path").ToString.Trim
        Dim _Path_Help As String = Application.StartupPath.ToString.Trim & "\Help\HD_Ban_Xe\"

        Dim K_Temp As String = Me.Para(1).ToString
        Dim _File_Name_Full As String = _Path_Help + _File_Name.Trim
        Dim isOpenW As Boolean = True
        If Not My.Computer.FileSystem.FileExists(_File_Name_Full) Then
            MsgBox("Không tồn tại tệp mẫu báo cáo, Bạn liên hệ với nhà cung cấp", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            _DsLoc.Dispose()
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        '------------------------------------------------------------------
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberLoading = New Cyber.Loading.Loading
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện tạo báo cáo thuyết minh", "Đang thực hiện tạo báo cáo thuyết minh", Me.Lan)

        CyberEport.WordReplaceText(isOpenW, _Path_Help.Trim & _File_Name, _DsLoc.Tables(0).Rows(0).Item("FullWord_Saves").ToString.Trim, _DsLoc.Tables(1), osysvar, M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        '------------------------------------------------------------------
        _DsLoc.Dispose()
        CyberSmlib.FlushMemorySave()
    End Sub
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#Region "Valid Id/Ten_Kh/Dia_Chi/Dien_Thoai/--- "
    Private Sub L_Fax(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        If TxtDien_Thoai.Text = "" Then TxtDien_Thoai.Text = TxtFax.Text
        If TxtDT_LX.Text = "" Then TxtDT_LX.Text = TxtFax.Text
    End Sub
    Private Sub L_Dien_Thoai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        If TxtDT_LX.Text = "" Then TxtDT_LX.Text = TxtDien_Thoai.Text
        If TxtDT_LH.Text = "" Then TxtDT_LH.Text = TxtDien_Thoai.Text
        'If TxtFax.Text = "" Then TxtFax.Text = TxtDien_Thoai.Text
    End Sub
    Private Sub L_Ong_Ba(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        If TxtOng_Ba.Text.Trim <> "" Then
            TxtTen_Kh.Text = IIf(TxtTen_Kh.Text.Trim <> "", TxtTen_Kh.Text, TxtOng_Ba.Text)
            TxtTen_KhVAT.Text = IIf(TxtTen_KhVAT.Text.Trim <> "", TxtTen_KhVAT.Text, TxtOng_Ba.Text)
        Else
            TxtOng_Ba.Text = IIf(TxtTen_Kh.Text.Trim <> "", TxtTen_Kh.Text, TxtOng_Ba.Text)
        End If
    End Sub
    Private Sub L_Ten_KhVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtTen_Kh.Text = IIf(TxtTen_Kh.Text.Trim <> "", TxtTen_Kh.Text, TxtTen_KhVAT.Text)
        TxtTen_Kh_LH.Text = IIf(TxtTen_Kh_LH.Text.Trim <> "", TxtTen_Kh_LH.Text, TxtTen_KhVAT.Text)

    End Sub
    Private Sub L_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim <> "", TxtDia_Chi.Text, TxtDia_ChiVAT.Text)
    End Sub
    Private Sub L_DT_LX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        If TxtDien_Thoai.Text = "" Then TxtDien_Thoai.Text = TxtDT_LX.Text
        'If TxtFax.Text = "" Then TxtFax.Text = TxtDT_LX.Text

        If TxtDT_LH.Text = "" Then TxtDT_LH.Text = TxtDT_LX.Text
    End Sub
    Private Sub V_Ma_KH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If TxtMa_Kh.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMKH", "Ma_KH= N'" & TxtMa_Kh.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_KH#", TxtMa_Kh.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
        'If Dr.Item("Ma_KH").ToString.Trim = TxtMa_Kh.Text.Trim Then V_Fill_TT(Dr, "1")
        'L_Ma_Kh(sender, e)
    End Sub
#End Region
#Region "So bao gia"
    Private Function V_GetFormtSO_BG_PBG(ByVal _So_BG As String, ByVal _Ma_Dvcs As String, ByVal _Ngay_Ct As Date, Optional ByVal _app As SqlConnection = Nothing, Optional ByVal Cybersmlib As Cyber.SmLib.Sys = Nothing) As String

        _Ma_Dvcs = _Ma_Dvcs.Trim
        _So_BG = _So_BG.Trim

        Dim _Len As Integer = 11
        If Not _Ma_Dvcs.Trim = "" Then _Len = _Len + Len(_Ma_Dvcs) + 1
        If Len(_So_BG) >= _Len Then
            Return Strings.Left(_So_BG.Trim, _Len)
        End If
        _So_BG = Strings.Right("0000" + _So_BG, 4)
        _So_BG = Strings.Right(_Ngay_Ct.Year.ToString.Trim, 4) + Strings.Right(("00" + Strings.Right(_Ngay_Ct.Month.ToString.Trim, 2)), 2) + "." + _So_BG
        If Not _Ma_Dvcs.Trim = "" Then _So_BG = _Ma_Dvcs.Trim + "." + _So_BG
        Return _So_BG
    End Function
    Private Sub V_UpdateVayNH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkTra_Gop.Checked = False Then Exit Sub

        If M_Stt_Rec.Trim = "" Then Exit Sub

        Dim _Stt_rec As String = TxtStt_Rec.Text.Trim

        Dim Frm As New HDX_Vay
        Frm.Stt_rec = _Stt_rec
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
        If Not Frm.Save_OK Then Exit Sub
        _Stt_rec = Frm.Stt_rec

    End Sub
    Private Sub V_Huy_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub

        Dim _Stt_rec As String = TxtStt_Rec.Text.Trim
        Dim _huy As Integer = IIf(ChkHuy.Checked, 1, 0)

        Dim Frm As New HDX_Huy
        Frm.Stt_rec = _Stt_rec
        Frm.Is_Huy = _huy
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
        If Not Frm.Save_OK Then Exit Sub
        _Stt_rec = Frm.Stt_rec
        _huy = Frm.Is_Huy
        If Frm.Save_OK = True Then
            V_Refresh(Frm.Stt_rec)
        End If
    End Sub
    Private Sub V_Luu_Coc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub

        Dim _Stt_rec As String = TxtStt_Rec.Text.Trim
        Dim _LuuCoc As Integer = IIf(ChkLuuCoc.Checked, 1, 0)

        Dim Frm As New HDX_LuuCoc
        Frm.Stt_rec = _Stt_rec
        Frm.Is_LuuCoc = _LuuCoc
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
        If Not Frm.Save_OK Then Exit Sub
        _Stt_rec = Frm.Stt_rec
        _LuuCoc = Frm.Is_LuuCoc
        If Frm.Save_OK = True Then
            V_Refresh(Frm.Stt_rec)
        End If
    End Sub
    Private Sub V_Refresh(_Stt_rec As String)
        If _Stt_rec.Trim = "" Then Exit Sub
        Dim M_strFilter As String = "1###" & _Stt_rec & "#19000101#19000101#0#9#" & M_Ma_CT.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim DsTempRefresh As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Filter" + M_Ma_CT.Trim, M_strFilter)

        For i As Integer = 0 To DsTempRefresh.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTempRefresh.Tables(i))
        Next
        Dim _Update As Boolean = False
        If DsTempRefresh.Tables(1).Rows.Count >= 1 Then
            M_Stt_Rec = DsTempRefresh.Tables(1).Rows(0).Item("Stt_Rec").ToString.Trim
            For iRow As Integer = 0 To Dt_Master.Rows.Count - 1
                If Dt_Master.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                    CyberSmodb.V_UpdateRowtoRow(DsTempRefresh.Tables(1).Rows(0), Dt_Master, iRow)
                    _Update = True
                    Exit For
                End If
            Next
        End If
        If Not _Update Then
            DsTempRefresh.Dispose()
            Exit Sub
        End If

        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)

        For iRow As Integer = 0 To DsTempRefresh.Tables(0).Rows.Count - 1
            Dt_Detail.ImportRow(DsTempRefresh.Tables(0).Rows(iRow))
        Next
        V_Databing()
        DsTempRefresh.Dispose()
    End Sub
    Private Sub V_Chon_So_BG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'str = CyberSupport.V_GetStrSelectList(AppConn, osysvar, M_Para, "CP_GetListSelect", "PHPBG#" & TxtSo_BG.Text.Trim & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        Dim Dr As DataRow = CyberSupport.V_GetDatarowOneSelectList(AppConn, osysvar, M_Para, "CP_GetListSelect", "PHPBG#" & TxtSo_BG.Text.Trim & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If Dr Is Nothing Then Return
        If Dr.Table.Columns.Contains("Ma") Then TxtSo_BG.Text = Dr.Item("Ma").ToString
        L_So_BG(sender, e)
    End Sub
    Private Sub L_So_BG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtSo_BG.Text = "" Then Exit Sub

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_BG.Text = V_GetFormtSO_BG_PBG(TxtSo_BG.Text, M_Ma_Dvcs, _Ngay_Ct)

        Dim DsPBG As DataSet
        Dim strField As String = ""
        Dim strValue As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue)
        DsPBG = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeGetFromPBGTOHDX", _Ngay_Ct.ToString("yyyyMMdd") + "#" + M_Ma_CT.Trim + "#" + M_Stt_Rec + "#" + M_Mode + "#" + strField + "#" + strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        '------------------------------------------------------------------------------------------------------------------------------------------
        For i As Integer = 0 To DsPBG.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsPBG.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsPBG.Tables(0), osysvar, M_LAN) Then
            If DsPBG.Tables(0).Columns.Contains("So_BG") Then TxtSo_BG.Text = DsPBG.Tables(0).Rows(0).Item("So_Bg").ToString.Trim
            DsPBG.Dispose()
            Exit Sub
        End If

        '------------------------------------------------------------------------------------------------------------------------------------------
        If DsPBG.Tables(1).Columns.Contains("Dt_Lx") And TxtDT_LX.Text.Trim = "" Then TxtDT_LX.Text = DsPBG.Tables(1).Rows(0).Item("DT_LX")
        If DsPBG.Tables(1).Columns.Contains("Ten_Kh") And TxtTen_Kh.Text.Trim = "" Then TxtTen_Kh.Text = DsPBG.Tables(1).Rows(0).Item("Ten_Kh")
        If DsPBG.Tables(1).Columns.Contains("Dia_Chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = DsPBG.Tables(1).Rows(0).Item("Dia_Chi")
        If DsPBG.Tables(1).Columns.Contains("Ong_Ba") And TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = DsPBG.Tables(1).Rows(0).Item("Ong_Ba")
        If DsPBG.Tables(1).Columns.Contains("Ten_KhVat") And TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = DsPBG.Tables(1).Rows(0).Item("Ten_KhVat")
        If DsPBG.Tables(1).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsPBG.Tables(1).Rows(0).Item("Dia_ChiVat")

        If DsPBG.Tables(1).Columns.Contains("Ma_So_Thue") And TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = DsPBG.Tables(1).Rows(0).Item("Ma_So_Thue")
        If DsPBG.Tables(1).Columns.Contains("E_Mail") And TxtE_Mail.Text.Trim = "" Then TxtE_Mail.Text = DsPBG.Tables(1).Rows(0).Item("E_Mail")

        Dim _Dt As Date = TxtNgay_Sinh.Value
        If DsPBG.Tables(1).Columns.Contains("Ngay_Sinh") And _Dt.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Sinh.Value = DsPBG.Tables(1).Rows(0).Item("Ngay_Sinh")
        If DsPBG.Tables(1).Columns.Contains("So_CMT") And TxtSo_CMT.Text.Trim = "" Then TxtSo_CMT.Text = DsPBG.Tables(1).Rows(0).Item("So_CMT")
        If DsPBG.Tables(1).Columns.Contains("Dien_Thoai") And TxtDien_Thoai.Text.Trim = "" Then TxtDien_Thoai.Text = DsPBG.Tables(1).Rows(0).Item("Dien_Thoai")
        If DsPBG.Tables(1).Columns.Contains("Fax") And TxtFax.Text.Trim = "" Then TxtFax.Text = DsPBG.Tables(1).Rows(0).Item("Fax")
        If DsPBG.Tables(1).Columns.Contains("Ngay_CMT_KH") And TxtNgay_CMT.Text.Trim = "" Then TxtNgay_CMT.Text = DsPBG.Tables(1).Rows(0).Item("Ngay_CMT_KH")
        If DsPBG.Tables(1).Columns.Contains("Noi_Cap_Cmt_Kh") And TxtNgay_CMT.Text.Trim = "" Then TxtNgay_CMT.Text = DsPBG.Tables(1).Rows(0).Item("Noi_Cap_Cmt_Kh")
        If DsPBG.Tables(1).Columns.Contains("Ten_Kh_LH") And TxtTen_Kh_LH.Text.Trim = "" Then TxtTen_Kh_LH.Text = DsPBG.Tables(1).Rows(0).Item("Ten_Kh_LH")
        If DsPBG.Tables(1).Columns.Contains("DC_LH") And TxtDC_LH.Text.Trim = "" Then TxtDC_LH.Text = DsPBG.Tables(1).Rows(0).Item("DC_LH")
        If DsPBG.Tables(1).Columns.Contains("DT_LH") And TxtDT_LH.Text.Trim = "" Then TxtDT_LH.Text = DsPBG.Tables(1).Rows(0).Item("DT_LH")


        If DsPBG.Tables(1).Columns.Contains("Trai_San") Then ChkTrai_San.Checked = DsPBG.Tables(1).Rows(0).Item("Trai_San").ToString.Trim = "1"
        If DsPBG.Tables(1).Columns.Contains("Dan_kinh") Then ChkDan_kinh.Checked = DsPBG.Tables(1).Rows(0).Item("Dan_kinh").ToString.Trim = "1"
        If DsPBG.Tables(1).Columns.Contains("Ca_Nhan") Then ChkCa_Nhan.Checked = DsPBG.Tables(1).Rows(0).Item("Ca_Nhan").ToString.Trim = "1"

        If DsPBG.Tables(1).Columns.Contains("Tra_Thang") Then ChkTra_Thang.Checked = DsPBG.Tables(1).Rows(0).Item("Tra_Thang").ToString.Trim = "1"
        If DsPBG.Tables(1).Columns.Contains("Tra_Gop") Then ChkTra_Gop.Checked = DsPBG.Tables(1).Rows(0).Item("Tra_Gop").ToString.Trim = "1"
        If DsPBG.Tables(1).Columns.Contains("Tra_Thue_mua") Then ChkTra_Thue_Mua.Checked = DsPBG.Tables(1).Rows(0).Item("Tra_Thue_mua").ToString.Trim = "1"
        If DsPBG.Tables(1).Columns.Contains("Tra_Cham") Then ChkTra_Cham.Checked = DsPBG.Tables(1).Rows(0).Item("Tra_Cham").ToString.Trim = "1"

        '------------------------------------------------------------------------------------------------------------------------------------------
        If DsPBG.Tables(1).Rows.Count > 0 Then
            If DsPBG.Tables(1).Columns.Contains("Ma_TP") Then
                If DsPBG.Tables(1).Rows(0).Item("Ma_TP").ToString.Trim <> "" Then
                    Try
                        CmbMa_TP.SelectedValue = DsPBG.Tables(1).Rows(0).Item("Ma_TP").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
            If DsPBG.Tables(1).Columns.Contains("Ma_Quan") Then
                If DsPBG.Tables(1).Rows(0).Item("Ma_Quan").ToString.Trim <> "" Then
                    Try
                        CmbMa_Quan.SelectedValue = DsPBG.Tables(1).Rows(0).Item("Ma_Quan").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
            If DsPBG.Tables(1).Columns.Contains("Ma_Xa") Then
                If DsPBG.Tables(1).Rows(0).Item("Ma_Xa").ToString.Trim <> "" Then
                    Try
                        CmbMa_Xa.SelectedValue = DsPBG.Tables(1).Rows(0).Item("Ma_Xa").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------
        '--Diện thoại
        L_DT_LX(New System.Object, New System.ComponentModel.CancelEventArgs)
        '------------------------------------------------------------------------------------------------------------------------------------------
        '--------------Insert Chi tiết các xe mua        
        If DsPBG.Tables(2).Rows.Count <= 0 Then
            DsPBG.Dispose()
            Exit Sub
        End If

        Dt_DetailTmp.Clear()
        CyberSmodb.SetNotNullTable(DsPBG.Tables(2))
        CyberSmodb.SQLTbToTb(DsPBG.Tables(2), Dt_DetailTmp)
        DsPBG.Dispose()

        UpdateList()
        CyberSmlib.FlushMemory()
    End Sub
#End Region
#Region "Thành phố Quận xã"
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP()
    End Sub
    Private Sub V_Ma_quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
#Region "Valid --- Id_kh"
    Private Sub V_ID_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtID_KH.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "ID_KH", "CRQLKHTN", "1=1", "1=1")
    End Sub
    Private Sub L_ID_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtID_KH.Text = "" Then
            'TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtID_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtID_KH.Text = DrReturn.Item("id_Kh")
        Else
            TxtID_KH.Text = ""
            'TxtTen_Kh.Text = ""
        End If
        V_Get_Id_kh()
    End Sub
    Private Sub V_Get_Id_kh()
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtID_KH.Text = "" Then Exit Sub

        Dim DsKHTN As DataSet
        Dim strField As String = ""
        Dim strValue As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue)
        DsKHTN = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeGetFromCRQLKHTNHDX", M_Ma_CT.Trim + "#" + M_Stt_Rec + "#" + M_Mode + "#" + strField + "#" + strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        '------------------------------------------------------------------------------------------------------------------------------------------
        If DsKHTN.Tables.Count < 1 Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        If DsKHTN.Tables(0).Rows.Count < 1 Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        If Not DsKHTN.Tables(0).Columns.Contains("Status") Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        If Not DsKHTN.Tables(0).Columns.Contains("Msg") Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        If Not DsKHTN.Tables(0).Columns.Contains("Note") Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        'If DsKHTN.Tables(0).Columns.Contains("Id_kh") Then TxtId_KH.Text = DsKHTN.Tables(0).Rows(0).Item("Id_kh")
        If DsKHTN.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then MsgBox(DsKHTN.Tables(0).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, osysvar("M_Cyber_Ver"))
        If DsKHTN.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            DsKHTN.Dispose()
            Exit Sub
        End If

        If DsKHTN.Tables.Count < 2 Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------
        'hieulv
        If DsKHTN.Tables(1).Columns.Contains("Ma_KH") Then TxtMa_Kh.Text = DsKHTN.Tables(1).Rows(0).Item("Ma_Kh")

        If DsKHTN.Tables(1).Columns.Contains("Dt_Lx") And TxtDT_LX.Text.Trim = "" Then TxtDT_LX.Text = DsKHTN.Tables(1).Rows(0).Item("DT_LX")
        If DsKHTN.Tables(1).Columns.Contains("Ten_Kh") And TxtTen_Kh.Text.Trim = "" Then TxtTen_Kh.Text = DsKHTN.Tables(1).Rows(0).Item("Ten_Kh")
        If DsKHTN.Tables(1).Columns.Contains("Dia_Chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = DsKHTN.Tables(1).Rows(0).Item("Dia_Chi")
        If DsKHTN.Tables(1).Columns.Contains("Chuc_Vu") And TxtChuc_Vu.Text.Trim = "" Then TxtChuc_Vu.Text = DsKHTN.Tables(1).Rows(0).Item("Chuc_Vu")
        If DsKHTN.Tables(1).Columns.Contains("Ong_Ba") And TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = DsKHTN.Tables(1).Rows(0).Item("Ong_Ba")
        If DsKHTN.Tables(1).Columns.Contains("Ten_KhVat") And TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = DsKHTN.Tables(1).Rows(0).Item("Ten_KhVat")
        If DsKHTN.Tables(1).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsKHTN.Tables(1).Rows(0).Item("Dia_ChiVat")

        If DsKHTN.Tables(1).Columns.Contains("Ma_So_Thue") And TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = DsKHTN.Tables(1).Rows(0).Item("Ma_So_Thue")
        If DsKHTN.Tables(1).Columns.Contains("E_Mail") And TxtE_Mail.Text.Trim = "" Then TxtE_Mail.Text = DsKHTN.Tables(1).Rows(0).Item("E_Mail")
        Dim _Dt As Date = TxtNgay_Sinh.Value
        If DsKHTN.Tables(1).Columns.Contains("Ngay_Sinh") And _Dt.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Sinh.Value = DsKHTN.Tables(1).Rows(0).Item("Ngay_Sinh")
        If DsKHTN.Tables(1).Columns.Contains("Ngay_Sinh") Then TxtNgay_Sinh.Value = DsKHTN.Tables(1).Rows(0).Item("Ngay_Sinh")
        If DsKHTN.Tables(1).Columns.Contains("Ma_PTLH") Then CmbMa_HTLL.SelectedValue = DsKHTN.Tables(1).Rows(0).Item("Ma_PTLH")
        Dim _Dt_CMT As Date = TxtNgay_CMT.Value
        If DsKHTN.Tables(1).Columns.Contains("So_CMT") And TxtSo_CMT.Text.Trim = "" Then TxtSo_CMT.Text = DsKHTN.Tables(1).Rows(0).Item("So_CMT")
        If DsKHTN.Tables(1).Columns.Contains("Dien_Thoai") And TxtDien_Thoai.Text.Trim = "" Then TxtDien_Thoai.Text = DsKHTN.Tables(1).Rows(0).Item("Dien_Thoai")
        If DsKHTN.Tables(1).Columns.Contains("Fax") And TxtFax.Text.Trim = "" Then TxtFax.Text = DsKHTN.Tables(1).Rows(0).Item("Fax")
        If DsKHTN.Tables(1).Columns.Contains("Ngay_CMT_KH") And _Dt_CMT.ToString("yyyyMMdd") = "19000101" Then TxtNgay_CMT.Text = DsKHTN.Tables(1).Rows(0).Item("Ngay_CMT_KH")
        If DsKHTN.Tables(1).Columns.Contains("Noi_Cap_Cmt_Kh") And TxtNoi_Cap_Cmt.Text.Trim = "" Then TxtNoi_Cap_Cmt.Text = DsKHTN.Tables(1).Rows(0).Item("Noi_Cap_Cmt_Kh")
        If DsKHTN.Tables(1).Columns.Contains("Ten_Kh_LH") And TxtTen_Kh_LH.Text.Trim = "" Then TxtTen_Kh_LH.Text = DsKHTN.Tables(1).Rows(0).Item("Ten_Kh_LH")
        If DsKHTN.Tables(1).Columns.Contains("DC_LH") And TxtDC_LH.Text.Trim = "" Then TxtDC_LH.Text = DsKHTN.Tables(1).Rows(0).Item("DC_LH")
        If DsKHTN.Tables(1).Columns.Contains("DT_LH") And TxtDT_LH.Text.Trim = "" Then TxtDT_LH.Text = DsKHTN.Tables(1).Rows(0).Item("DT_LH")

        If DsKHTN.Tables(1).Columns.Contains("DT_LH") And TxtNguoi_MG.Text.Trim = "" Then TxtNguoi_MG.Text = DsKHTN.Tables(1).Rows(0).Item("Nguoi_MG")
        If DsKHTN.Tables(1).Columns.Contains("DT_LH") And TxtDC_MG.Text.Trim = "" Then TxtDC_MG.Text = DsKHTN.Tables(1).Rows(0).Item("DC_MG")
        If DsKHTN.Tables(1).Columns.Contains("DT_LH") And TxtDT_MG.Text.Trim = "" Then TxtDT_MG.Text = DsKHTN.Tables(1).Rows(0).Item("DT_MG")
        '------------------------------------------------------------------------------------------------------------------------------------------

        If DsKHTN.Tables(1).Rows.Count > 0 Then
            If DsKHTN.Tables(1).Columns.Contains("Ma_TP") Then
                If DsKHTN.Tables(1).Rows(0).Item("Ma_TP").ToString.Trim <> "" Then
                    Try
                        CmbMa_TP.SelectedValue = DsKHTN.Tables(1).Rows(0).Item("Ma_TP").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
            If DsKHTN.Tables(1).Columns.Contains("Ma_Quan") Then
                If DsKHTN.Tables(1).Rows(0).Item("Ma_Quan").ToString.Trim <> "" Then
                    Try
                        CmbMa_Quan.SelectedValue = DsKHTN.Tables(1).Rows(0).Item("Ma_Quan").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
            If DsKHTN.Tables(1).Columns.Contains("Ma_Xa") Then
                If DsKHTN.Tables(1).Rows(0).Item("Ma_Xa").ToString.Trim <> "" Then
                    Try
                        CmbMa_Xa.SelectedValue = DsKHTN.Tables(1).Rows(0).Item("Ma_Xa").ToString.Trim
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------
        '--Diện thoại
        L_DT_LX(New System.Object, New System.ComponentModel.CancelEventArgs)
        '------------------------------------------------------------------------------------------------------------------------------------------
        '--------------Insert Chi tiết các xe mua
        If DsKHTN.Tables.Count < 3 Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        If DsKHTN.Tables(2).Rows.Count <= 0 Then
            DsKHTN.Dispose()
            Exit Sub
        End If

        Dim nInsert As Boolean = False
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_Kx").ToString.Trim <> "" Then
                nInsert = True
                Exit For
            End If
        Next
        If nInsert Then
            DsKHTN.Dispose()
            Exit Sub
        End If
        For iRow = nCount - 1 To 0 Step -1
            Dt_DetailTmp.Rows(iRow).Delete()
            Dt_DetailTmp.AcceptChanges()
        Next
        CyberSmodb.SetNotNullTable(DsKHTN.Tables(2))
        CyberSmodb.SQLTbToTb(DsKHTN.Tables(2), Dt_DetailTmp)
        DsKHTN.Dispose()
        'For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
        '    V_SetPriceXeSales(iRow)
        'Next
        UpdateList()
        CyberSmlib.FlushMemory()
        '-ID_KH

        'Ma_TP()
    End Sub
#End Region
#Region "Valid --- Ma_Kh"
    'Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    TxtMa_Kh.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '    If TxtMa_Kh.Text = "" Then
    '        'TxtTen_Kh.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = TxtMa_Kh.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
    '        TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")

    '        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi"), TxtDia_Chi.Text)

    '        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim = "", DrReturn.Item("Dia_ChiVat"), TxtDia_Chi.Text)
    '        TxtTen_KhVAT.Text = IIf(TxtTen_KhVAT.Text.Trim = "", DrReturn.Item("Ten_KhVat"), TxtTen_Kh.Text)
    '        TxtMa_So_Thue.Text = IIf(TxtMa_So_Thue.Text.Trim = "", DrReturn.Item("Ma_So_Thue"), TxtMa_So_Thue.Text)
    '        TxtDien_Thoai.Text = IIf(TxtDien_Thoai.Text.Trim = "", DrReturn.Item("Dien_Thoai"), TxtDien_Thoai.Text)
    '        If TxtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ong_Ba") Then TxtOng_Ba.Text = DrReturn.Item("Ong_Ba")
    '        If TxtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Doi_Tac") Then TxtOng_Ba.Text = DrReturn.Item("Doi_Tac")
    '    Else
    '        TxtMa_Kh.Text = ""
    '        'TxtTen_Kh.Text = ""
    '    End If

    'End Sub
    Private Sub L_Ten_Kh(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If TxtMa_Kh.Text <> "" Then TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "Ma_Kh = N'" + TxtMa_Kh.Text.Trim + "'", CyberSmlib)
        TxtTen_KhVAT.Text = IIf(TxtTen_KhVAT.Text.Trim <> "", TxtTen_KhVAT.Text, TxtTen_Kh.Text)
        TxtOng_Ba.Text = IIf(TxtOng_Ba.Text.Trim <> "", TxtOng_Ba.Text, TxtTen_Kh.Text)
        TxtOng_Ba.Text = IIf(TxtOng_Ba.Text.Trim <> "", TxtOng_Ba.Text, TxtTen_KhVAT.Text)
        TxtTen_Kh_LH.Text = IIf(TxtTen_Kh_LH.Text.Trim <> "", TxtTen_Kh_LH.Text, TxtTen_Kh.Text)
        TxtTen_Kh_LH.Text = IIf(TxtTen_Kh_LH.Text.Trim <> "", TxtTen_Kh_LH.Text, TxtTen_KhVAT.Text)
    End Sub
    Private Sub L_Dia_Chi(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'If TxtMa_Kh.Text <> "" Then TxtDia_Chi.Text = CyberInput.GetDia_Chi(TxtMa_Kh.Text, TxtDia_Chi.Text, M_Ma_CT, M_Mode, AppConn, CyberSmlib, CyberSmodb)
        If TxtMa_Kh.Text <> "" And TxtDia_Chi.Text = "" Then TxtDia_Chi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "Ma_Kh = N'" + TxtMa_Kh.Text + "'", CyberSmlib)
        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
        TxtDC_LH.Text = IIf(TxtDC_LH.Text.Trim <> "", TxtDC_LH.Text, TxtDia_Chi.Text)
        TxtDC_LH.Text = IIf(TxtDC_LH.Text.Trim <> "", TxtDC_LH.Text, TxtDia_ChiVAT.Text)
    End Sub
#End Region
#Region "Valid --- Ma_Sk"
    Private Sub V_Ma_SK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_SK", "DmSk", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_SK.Text = "" Then
            TxtTen_SK.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SK.Text = DrReturn("Ma_Sk").ToString.Trim
            TxtTen_SK.Text = DrReturn("ten_sk").ToString.Trim
        Else
            TxtMa_SK.Text = ""
            TxtTen_SK.Text = ""
        End If

    End Sub
#End Region
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
        If Not TxtMa_GPK.Text.Trim = "" Then V_GetMa_Pk(TxtMa_GPK.Text.Trim)
    End Sub
    Private Sub V_GetMa_Pk(ByVal _Ma_GPK As String)
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
        Dt_DetailtmpPK.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailtmpPK)
        Dt_DetailtmpPK.AcceptChanges()
        CyberSupport.V_UpdateGRV(DetailGRVPK)
        For iRow As Integer = 0 To Dv_DetailtmpPK.Count - 1
            V_Tinh_ToanPK(iRow)
        Next
        CyberSupport.V_UpdateGRV(DetailGRVPK)
        DsTmp.Dispose()
    End Sub

#End Region
#Region "Valid --- Ma_LHKH"
    Private Sub V_Ma_LHKH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_LHKH", "DmLHKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHKH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_LHKH.Text = "" Then
            TxtTen_LHKH.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHKH.Text = DrReturn("Ma_lhkh").ToString.Trim
            TxtTen_LHKH.Text = DrReturn("ten_lhkh").ToString.Trim
        Else
            TxtMa_LHKH.Text = ""
            TxtTen_LHKH.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_bp"
    Private Sub V_Ma_Bp_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_bp", "Dmbp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_bp_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn("Ma_bp").ToString.Trim
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
        TxtMa_Hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "Ma_BP='" + TxtMa_BP_H.Text.Trim + "'")
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
#End Region
#Region "Valid --- Nh_hd1"
    Private Sub V_Nh_HD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_HD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtNh_HD1.Text = "" Then
            TxtTen_Nh_HD1.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD1.Text = DrReturn("Ma_nh").ToString.Trim
            TxtTen_Nh_HD1.Text = DrReturn("ten_nh").ToString.Trim
        Else
            TxtNh_HD1.Text = ""
            TxtTen_Nh_HD1.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Nh_hd2"
    Private Sub V_Nh_HD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_HD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtNh_HD2.Text = "" Then
            TxtTen_Nh_HD2.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD2.Text = DrReturn("Ma_nh").ToString.Trim
            TxtTen_Nh_HD2.Text = DrReturn("ten_nh").ToString.Trim
        Else
            TxtNh_HD2.Text = ""
            TxtTen_Nh_HD2.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Nh_hd3"
    Private Sub V_Nh_HD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_HD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtNh_HD3.Text = "" Then
            TxtTen_Nh_HD3.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD3.Text = DrReturn("Ma_nh").ToString.Trim
            TxtTen_Nh_HD3.Text = DrReturn("ten_nh").ToString.Trim
        Else
            TxtNh_HD3.Text = ""
            TxtTen_Nh_HD3.Text = ""
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
#Region "Ma_Hd_H"
    Private Sub L_Ma_Hd_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD_H.Text.ToString.Length < 3 Then
            TxtMa_HD_H.Text = M_Ma_Dvcs & "." & TxtMa_HD_H.Text.ToString
        Else
            TxtMa_HD_H.Text = IIf(TxtMa_HD_H.Text.ToString.Trim.Substring(0, 3) = M_Ma_Dvcs & ".", TxtMa_HD_H.Text.ToString.Trim, M_Ma_Dvcs & "." & TxtMa_HD_H.Text.ToString.Trim)
        End If

    End Sub

#End Region
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_Thu_them As Decimal = 0
        Dim nT_Tien_Nt As Decimal = 0
        Dim nT_Tien As Decimal = 0

        Dim nT_PK_BB As Decimal = 0
        Dim nT_BH_BB As Decimal = 0
        Dim nT_Khac_BB As Decimal = 0
        Dim nT_BB As Decimal = 0

        Dim nT_Ck As Decimal = 0

        Dim nT_Km_PK As Decimal = 0
        Dim nT_Km_BH As Decimal = 0
        Dim nT_Moi_Gioi As Decimal = 0
        Dim nT_Km_khac As Decimal = 0
        Dim nT_Km As Decimal = 0

        Dim T_PK_NT As Decimal = 0

        Dim nT_GT1 As Decimal = 0
        Dim nT_GT2 As Decimal = 0
        Dim nT_GT3 As Decimal = 0
        Dim nT_GT4 As Decimal = 0
        Dim nT_Gg_CS As Decimal = 0
        Dim nT_Vuot_khung As Decimal = 0
        Dim T_Luong_TVBH As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            nT_Tien_Nt = nT_Tien_Nt + Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
            nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien")

            nT_PK_BB = nT_PK_BB + Dv_DetailTmp.Item(iRow).Item("PK_BB")
            nT_BH_BB = nT_BH_BB + Dv_DetailTmp.Item(iRow).Item("BH_BB")
            nT_Khac_BB = nT_Khac_BB + Dv_DetailTmp.Item(iRow).Item("Khac_BB")

            nT_Ck = nT_Ck + Dv_DetailTmp.Item(iRow).Item("Ck")

            nT_Km_PK = nT_Km_PK + Dv_DetailTmp.Item(iRow).Item("Km_PK")
            nT_Km_BH = nT_Km_BH + Dv_DetailTmp.Item(iRow).Item("Km_BH")
            nT_Moi_Gioi = nT_Moi_Gioi + Dv_DetailTmp.Item(iRow).Item("Moi_gioi")
            nT_Km_khac = nT_Km_khac + Dv_DetailTmp.Item(iRow).Item("Km_khac")

            nT_GT1 = nT_GT1 + Dv_DetailTmp.Item(iRow).Item("Gt1")
            nT_GT2 = nT_GT2 + Dv_DetailTmp.Item(iRow).Item("Gt2")
            nT_GT3 = nT_GT3 + Dv_DetailTmp.Item(iRow).Item("Gt3")
            nT_GT4 = nT_GT4 + Dv_DetailTmp.Item(iRow).Item("Gt4")

            T_Luong_TVBH = T_Luong_TVBH + Dv_DetailTmp.Item(iRow).Item("Luong_TVBH")

            nT_Thu_them = nT_Thu_them + Dv_DetailTmp.Item(iRow).Item("Thu_Them")
            If Dt_DetailTmp.Columns.Contains("Gg_CS") Then nT_Gg_CS = nT_Gg_CS + Dv_DetailTmp.Item(iRow).Item("GG_CS")
            If Dt_DetailTmp.Columns.Contains("Vuot_khung") Then nT_Vuot_khung = nT_Vuot_khung + Dv_DetailTmp.Item(iRow).Item("Vuot_khung")
        Next

        TxtT_Tien_NT.Double = nT_Tien_Nt
        TxtT_CK.Double = nT_Ck
        TxtT_TT_NT.Double = nT_Tien_Nt - nT_Ck

        TxtT_PK_BB.Double = nT_PK_BB
        TxtT_BH_BB.Double = nT_BH_BB
        TxtT_khac_BB.Double = nT_Khac_BB
        TxtT_BB.Double = nT_PK_BB + nT_BH_BB + nT_Khac_BB

        TxtT_Km_PK.Double = nT_Km_PK
        TxtT_Km_BH.Double = nT_Km_BH
        TxtT_Moi_Gioi.Double = nT_Moi_Gioi
        TxtT_Km_Khac.Double = nT_Km_khac
        TxtT_KM.Double = nT_Km_PK + nT_Km_BH + nT_Moi_Gioi + nT_Km_khac

        TxtT_Gt1.Double = nT_GT1
        TxtT_Gt2.Double = nT_GT2
        TxtT_Gt3.Double = nT_GT3
        TxtT_Gt4.Double = nT_GT4
        TxtT_Thu_Them.Double = nT_Thu_them
        TxtT_Luong_TVBH.Double = T_Luong_TVBH

        'Phụ kiện
        Dim nT_NT_PK As Decimal = 0
        Dim nT_SL_PK As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailtmpPK.Count - 1
            nT_NT_PK = nT_NT_PK + Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt")
            If Dt_DetailtmpPK.Columns.Contains("CK") Then nT_NT_PK = nT_NT_PK - Dv_DetailtmpPK.Item(iRow).Item("CK")
            nT_SL_PK = nT_SL_PK + Dv_DetailtmpPK.Item(iRow).Item("So_Luong")
        Next
        TxtT_PK_NT.Double = nT_NT_PK
        TxtT_So_Luong.Double = nT_SL_PK
        TxtT_Vuot_Khung.Double = nT_Vuot_khung
        TxtT_GG_CS.Double = nT_Gg_CS
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = V_GetTyGia()
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
        If Dt_DetailTmp.Columns.Contains("CK") Then
            If _Ck <> 0 Then
                Dv_DetailTmp.Item(iRow).Item("CK") = _Ck
            Else
                _Ck = Dv_DetailTmp.Item(iRow).Item("CK")
            End If
        End If
        If Dt_DetailTmp.Columns.Contains("T_TT_NT") Then Dv_DetailTmp.Item(iRow).Item("T_TT_NT") = Dv_DetailTmp.Item(iRow).Item("Tien_Nt") - _Ck
        If Dt_DetailTmp.Columns.Contains("T_TT") Then Dv_DetailTmp.Item(iRow).Item("T_TT") = Dv_DetailTmp.Item(iRow).Item("Tien") - _Ck

        ''--hieulv 04-05-2022: sửa công thức giảm giá cs
        'If Dt_DetailTmp.Columns.Contains("Gg_CS") And Dt_DetailTmp.Columns.Contains("Vuot_Khung") Then
        '    Dv_DetailTmp.Item(iRow).Item("Vuot_Khung") = Dv_DetailTmp.Item(iRow).Item("Ck") + Dv_DetailTmp.Item(iRow).Item("Km_PK") * 0.7 + Dv_DetailTmp.Item(iRow).Item("Km_BH") + Dv_DetailTmp.Item(iRow).Item("Moi_gioi") + Dv_DetailTmp.Item(iRow).Item("Km_khac") - Dv_DetailTmp.Item(iRow).Item("Gg_CS")
        'End If
        '--hieulv 16-06-2022: sửa công thức giảm giá cs
        If Dt_DetailTmp.Columns.Contains("Gg_CS") And Dt_DetailTmp.Columns.Contains("Vuot_Khung") Then
            Dv_DetailTmp.Item(iRow).Item("Vuot_Khung") = Dv_DetailTmp.Item(iRow).Item("Ck") + Dv_DetailTmp.Item(iRow).Item("Km_PK") + Dv_DetailTmp.Item(iRow).Item("Km_BH") + Dv_DetailTmp.Item(iRow).Item("Moi_gioi") + Dv_DetailTmp.Item(iRow).Item("Km_khac") - Dv_DetailTmp.Item(iRow).Item("Gg_CS")
        End If
        '----
        Dv_DetailTmp.Item(iRow).EndEdit()
        '----------------------------------------------------------------------------------------------
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
        V_Gt1(New System.Object, New System.EventArgs)
        V_Tinh_Toan(iRow)
    End Sub
#Region "Phụ kiện"
    Private Sub V_Tinh_ToanPK(ByVal iRow As Integer)
        If iRow < 0 Then
            Exit Sub
        End If
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------
        If Dv_DetailtmpPK.Item(iRow).Item("So_Luong") * Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt") <> 0 Then
            Dv_DetailtmpPK.Item(iRow).BeginEdit()
            Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt") = CyberSupport.V_Round(Dv_DetailtmpPK.Item(iRow).Item("So_Luong") * Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt"), M_R_TIEN_NT)
            Dv_DetailtmpPK.Item(iRow).EndEdit()
        End If
        Dv_DetailtmpPK.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailtmpPK.Item(iRow).Item("Tien") = Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt")
            Dv_DetailtmpPK.Item(iRow).Item("Gia") = Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt")
        Else
            Dv_DetailtmpPK.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt") * nTy_Gia, M_R_TIEN)
            Dv_DetailtmpPK.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailtmpPK.Item(iRow).EndEdit()

        '----------------------------------------------------------------------------------------------

        Dv_DetailtmpPK.Item(iRow).BeginEdit()
        Dim _Ck As Decimal = 0
        If Dt_DetailtmpPK.Columns.Contains("PT_CK") Then _Ck = CyberSupport.V_Round(Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt") * Dv_DetailtmpPK.Item(iRow).Item("PT_CK") / 100, 0)
        If Dt_DetailtmpPK.Columns.Contains("CK") Then
            If _Ck <> 0 Then
                Dv_DetailtmpPK.Item(iRow).Item("CK") = _Ck
            Else
                _Ck = Dv_DetailtmpPK.Item(iRow).Item("CK")
            End If
        End If
        If Dt_DetailtmpPK.Columns.Contains("T_TT_NT") Then Dv_DetailtmpPK.Item(iRow).Item("T_TT_NT") = Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt") - _Ck
        If Dt_DetailtmpPK.Columns.Contains("T_TT") Then Dv_DetailtmpPK.Item(iRow).Item("T_TT") = Dv_DetailtmpPK.Item(iRow).Item("Tien") - _Ck
        Dv_DetailtmpPK.Item(iRow).EndEdit()
        '----------------------------------------------------------------------------------------------

        CyberSupport.V_UpdateGRV(DetailGRVPK)
        UpdateList()
    End Sub
    Private Sub L_Tinh_ToanPK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVPK.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRVPK.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVPK.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRVPK)
        V_Tinh_ToanPK(iRow)
    End Sub
#End Region
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
    Private Sub V_SetPriceXeSales(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        CyberSmodb.GetValueData(Dv_DetailTmp.Item(iRow), _strF, _strV, "Ten_Kx,Ten_Mau")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPriceXeSalesCSBH", M_Stt_Rec + "#" + M_Ma_CT + "#" + M_Mode + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _strF + "#" + _strV + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)

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
    Private Sub V_SetPriceXeSales_Luu(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Kx As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        Dim _Ma_Mau As String = Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim
        Dim _So_Luong As Decimal = 1 'Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Dim _Gia_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_Nt")
        Dim _Tien_Nt As Decimal = Dv_DetailTmp.Item(iRow).Item("Tien_Nt")
        Dim _Dat_Coc As Decimal = Dv_DetailTmp.Item(iRow).Item("Gt1")
        Dim _Ma_Kh As String = TxtMa_Kh.Text
        Dim _ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPriceXeSales", _Ma_Kx.Trim + "#" + _Ma_Mau.Trim + "#" + _Ma_Kh + "#" +
        _ngay_Ct.ToString("yyyyMMdd") + "#" + _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_Nt.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt.ToString.Trim.Replace(",", ".") + "#" +
        _Dat_Coc.ToString.Trim.Replace(",", ".") + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If

        Dim _DtGia As DataTable = DsgetPrice.Tables(0)
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If _DtGia.Columns.Contains("Gia_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Gia_Nt") = _DtGia.Rows(0).Item("Gia_Nt2")
        If _DtGia.Columns.Contains("Tien_Nt2") Then Dv_DetailTmp.Item(iRow).Item("Tien_Nt") = _DtGia.Rows(0).Item("Tien_Nt2")
        If _DtGia.Columns.Contains("Ck") And Dt_DetailTmp.Columns.Contains("Ck") Then Dv_DetailTmp.Item(iRow).Item("Ck") = _DtGia.Rows(0).Item("Ck")
        If _DtGia.Columns.Contains("PK_BB") And Dt_DetailTmp.Columns.Contains("PK_BB") Then Dv_DetailTmp.Item(iRow).Item("PK_BB") = _DtGia.Rows(0).Item("PK_BB")

        If _DtGia.Columns.Contains("MOI_GIOI") And Dt_DetailTmp.Columns.Contains("MOI_GIOI") Then Dv_DetailTmp.Item(iRow).Item("MOI_GIOI") = _DtGia.Rows(0).Item("MOI_GIOI")
        If _DtGia.Columns.Contains("Km_PK") And Dt_DetailTmp.Columns.Contains("Km_PK") Then Dv_DetailTmp.Item(iRow).Item("Km_PK") = _DtGia.Rows(0).Item("Km_PK")
        If _DtGia.Columns.Contains("KM_KHAC") And Dt_DetailTmp.Columns.Contains("KM_KHAC") Then Dv_DetailTmp.Item(iRow).Item("KM_KHAC") = _DtGia.Rows(0).Item("KM_KHAC")
        If _DtGia.Columns.Contains("GT1") And Dt_DetailTmp.Columns.Contains("GT1") Then Dv_DetailTmp.Item(iRow).Item("GT1") = _DtGia.Rows(0).Item("GT1")
        If _DtGia.Columns.Contains("GT2") And Dt_DetailTmp.Columns.Contains("GT2") Then Dv_DetailTmp.Item(iRow).Item("GT2") = _DtGia.Rows(0).Item("GT2")

        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        DsgetPrice.Dispose()
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ngay_Gx As Date
        Dim _Ngay_CT As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = ""
        Try
            _Ma_Post = CbbMa_Post.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        Dim _Ma_Kx As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        Dim _Ma_Mau As String = Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim
        _Ngay_Gx = Dv_DetailTmp.Item(iRow).Item("Ngay_Gx")

        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BESoDuXE_HDX", M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & _Ma_Post & "#" & _Ma_Kx & "#" & _Ma_Mau & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & _Ngay_Gx.ToString("yyyyMMdd") & "#" & TxtMa_Dvcs.Text & "#" & M_User_Name)

        Dim _Ton13 As Decimal = 0
        Dim _Note13 As String = ""

        If _Dstmp.Tables.Count = 0 Then
            _Dstmp.Dispose()
            Exit Sub
        End If

        If _Dstmp.Tables(0).Rows.Count = 0 Then
            _Dstmp.Dispose()
            Exit Sub
        End If

        If _Dstmp.Tables(0).Columns.Contains("Ton13") Then _Ton13 = _Dstmp.Tables(0).Rows(0).Item("Ton13")
        If _Dstmp.Tables(0).Columns.Contains("Note13") Then _Note13 = _Dstmp.Tables(0).Rows(0).Item("Note13").ToString.Trim

        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ton13") = _Ton13
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Not _Note13.Trim = "" Then StatusFooter1.Text = _Note13
        _Dstmp.Dispose()
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
    Private Sub V_Ma_CSBH(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        CyberSupport.V_Lookup("Ma_CSBH", "DmCSBH", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CSBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)

        If DrReturn Is Nothing Then
            If Dv_DetailTmp.Item(iRow).Item("Ma_CSBH").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    'UpdateList()
                    SendKeys.Send("^{TAB}")
                    Exit Sub
                End If
            End If
            Exit Sub
        End If

        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_CSBH") = DrReturn("Ma_CSBH").ToString.Trim
        If Dv_DetailTmp.Table.Columns.Contains("Ten_CSBH") And DrReturn.Table.Columns.Contains("Ten_CSBH") Then Dv_DetailTmp.Item(iRow).Item("Ten_CSBH") = DrReturn("Ten_CSBH").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()

        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPriceXeSales(iRow)
        V_SetSD(iRow)
        V_GetNgay1()
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        CyberSupport.V_Lookup("Ma_Kx", "Dmkx", " 1=1 AND Is_KD = N'1'", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Kx") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_Kx") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Kx") = DrReturn("Ma_Kx").ToString.Trim
            Dv_DetailTmp.Item(iRow).Item("Ten_Kx") = DrReturn("Ten_Kx").ToString.Trim
            If Dv_DetailTmp.Table.Columns.Contains("So_Cho") And DrReturn.Table.Columns.Contains("So_Cho") Then Dv_DetailTmp.Item(iRow).Item("So_Cho") = DrReturn.Item("So_Cho")
            If Dv_DetailTmp.Table.Columns.Contains("Xuat_Xu") And DrReturn.Table.Columns.Contains("Xuat_Xu") Then Dv_DetailTmp.Item(iRow).Item("Xuat_Xu") = DrReturn.Item("Xuat_Xu")
            If Dv_DetailTmp.Table.Columns.Contains("Quy_Cach") And DrReturn.Table.Columns.Contains("Quy_Cach") Then Dv_DetailTmp.Item(iRow).Item("Quy_Cach") = DrReturn.Item("Quy_Cach")
            If Dv_DetailTmp.Table.Columns.Contains("Dung_Tich") And DrReturn.Table.Columns.Contains("Dung_Tich") Then Dv_DetailTmp.Item(iRow).Item("Dung_Tich") = DrReturn.Item("Dung_Tich")
            If Dv_DetailTmp.Table.Columns.Contains("Model_Code") And DrReturn.Table.Columns.Contains("Model_Code") Then Dv_DetailTmp.Item(iRow).Item("Xuat_Xu") = DrReturn.Item("Model_Code")
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetPriceXeSales(iRow)
        V_SetSD(iRow)
        V_GetNgay1()
        DetailGRV.UpdateCurrentRow()
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
            'Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = DrReturn("Ten_Mau").ToString.Trim
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
        V_SetPriceXeSales(iRow)
        V_SetSD(iRow)
        V_GetNgay1()
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Mau_Nt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_Kx As String = ""
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then _Ma_Kx = Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" + _Ma_Kx + "'"
        CyberSupport.V_Lookup("Ma_Mau_Nt", "DmMauNtKx", "1=1", _FilterClient, M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Mau_Nt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)

        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau_Nt") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau_Nt") Then Dv_DetailTmp.Item(iRow).Item("Ten_Mau_Nt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Mau_Nt") = DrReturn("Ma_Mau_Nt").ToString.Trim
            'Dv_DetailTmp.Item(iRow).Item("Ten_Mau") = DrReturn("Ten_Mau").ToString.Trim
            If Dv_DetailTmp.Table.Columns.Contains("Ten_Mau_Nt") Then
                If DrReturn.Table.Columns.Contains("Ten_Mau_Nt") Then
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau_Nt") = DrReturn("Ten_Mau").ToString.Trim
                Else
                    Dv_DetailTmp.Item(iRow).Item("Ten_Mau_Nt") = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauXeNt", "(Ma_Mau_Nt = N'" + DrReturn("Ma_Mau_Nt").ToString.Trim + "')", CyberSmlib)
                End If
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Table.AcceptChanges()

        V_SetPriceXeSales(iRow)
        V_SetSD(iRow)
        V_GetNgay1()
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ngay_Gx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        V_SetSD(iRow)
        V_GetNgay1()
        Dt_DetailTmp.AcceptChanges()
    End Sub
#Region "Tính ngày đặt cọc"
    Private Sub V_GetNgay1()
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        Dim Dt As Date = TxtNgay_Ct.Value
        Dim D1 As Date = Dv_DetailTmp.Item(iRow).Item("Ngay1")
        Dim D2 As Date = Dv_DetailTmp.Item(iRow).Item("Ngay_Gx")
        Dim _Ma_CSBH As String = If(Dt_DetailTmp.Columns.Contains("Ma_CSBH"), Dv_DetailTmp.Item(iRow).Item("Ma_CSBH").ToString.Trim, "")
        Dim _Ma_Kx As String = If(Dt_DetailTmp.Columns.Contains("Ma_Kx"), Dv_DetailTmp.Item(iRow).Item("Ma_Kx").ToString.Trim, "")
        Dim _Ma_Mau As String = If(Dt_DetailTmp.Columns.Contains("Ma_Mau"), Dv_DetailTmp.Item(iRow).Item("Ma_Mau").ToString.Trim, "")


        Dim DsGia_Ban As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDXGetNgayDatCoc", _Ma_CSBH & "#" & _Ma_Kx & "#" & _Ma_Mau & "#" & M_Stt_Rec & "#" &
               M_Ma_CT & "#" & M_Mode & "#" & Dt.ToString("yyyyMMdd") & "#" & D2.ToString("yyyyMMdd") & "#" & D1.ToString("yyyyMMdd") & "#" & IIf(ChkCa_Nhan.Checked, "1", "0") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dt_DetailTmp.Rows(iRow).BeginEdit()
        Dt_DetailTmp.Rows(iRow).Item("Ngay1") = DsGia_Ban.Tables(0).Rows(0).Item("Ngay1")
        Dt_DetailTmp.Rows(iRow).EndEdit()
    End Sub
#End Region
#Region "Ngay 1-2-3-4.."
    Private Sub V_Ngay1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_Ngay2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_Ngay3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_Ngay4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
#End Region
#Region "Gt 1-2-3-4.."
    Private Sub V_Gt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
        If (Dt_DetailTmp.Rows(iRow).Item("Gt1") + Dt_DetailTmp.Rows(iRow).Item("Gt2") + Dt_DetailTmp.Rows(iRow).Item("Gt3") + Dt_DetailTmp.Rows(iRow).Item("Gt4")) <>
            (Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck")) Then
            '----
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            If Dt_DetailTmp.Rows(iRow).Item("Gt2") <> 0 Or Dt_DetailTmp.Rows(iRow).Item("Gt2") <> Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") - Dt_DetailTmp.Rows(iRow).Item("Gt3") Then
                Dt_DetailTmp.Rows(iRow).Item("Gt2") = Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") - Dt_DetailTmp.Rows(iRow).Item("Gt3")
            Else
                Dt_DetailTmp.Rows(iRow).Item("Gt2") = Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") - Dt_DetailTmp.Rows(iRow).Item("Gt3")
            End If

            Dt_DetailTmp.Rows(iRow).EndEdit()
            '----
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            'Dt_DetailTmp.Rows(iRow).Item("Gt3") = 0
            Dt_DetailTmp.Rows(iRow).Item("Gt4") = 0
            Dt_DetailTmp.Rows(iRow).EndEdit()
        End If

        If Dt_DetailTmp.Rows(iRow).Item("Ngay1") < TxtNgay_Ct.Value Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ngay1") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).EndEdit()
        End If
        If Dt_DetailTmp.Rows(iRow).Item("Ngay2") < Dt_DetailTmp.Rows(iRow).Item("Ngay1") Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ngay2") = Dt_DetailTmp.Rows(iRow).Item("Ngay1")
            Dt_DetailTmp.Rows(iRow).EndEdit()

        End If
        If Dt_DetailTmp.Rows(iRow).Item("Ngay3") < Dt_DetailTmp.Rows(iRow).Item("Ngay2") Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ngay3") = Dt_DetailTmp.Rows(iRow).Item("Ngay2")
            Dt_DetailTmp.Rows(iRow).EndEdit()

        End If
        If Dt_DetailTmp.Rows(iRow).Item("Ngay4") < Dt_DetailTmp.Rows(iRow).Item("Ngay3") Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ngay4") = Dt_DetailTmp.Rows(iRow).Item("Ngay3")
            Dt_DetailTmp.Rows(iRow).EndEdit()

        End If
        UpdateList()
    End Sub
    Private Sub V_Gt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If

        Dt_DetailTmp.AcceptChanges()
        If (Dt_DetailTmp.Rows(iRow).Item("Gt1") + Dt_DetailTmp.Rows(iRow).Item("Gt2") + Dt_DetailTmp.Rows(iRow).Item("Gt3") + Dt_DetailTmp.Rows(iRow).Item("Gt4")) <>
            (Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck")) Then
            '----
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            If Dt_DetailTmp.Rows(iRow).Item("Gt2") <> 0 Then
                Dt_DetailTmp.Rows(iRow).Item("Gt3") = Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") - Dt_DetailTmp.Rows(iRow).Item("Gt2")
            Else
                Dt_DetailTmp.Rows(iRow).Item("Gt2") = Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") - Dt_DetailTmp.Rows(iRow).Item("Gt3")
            End If

            Dt_DetailTmp.Rows(iRow).EndEdit()
            '----
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            'Dt_DetailTmp.Rows(iRow).Item("Gt3") = 0
            Dt_DetailTmp.Rows(iRow).Item("Gt4") = 0
            Dt_DetailTmp.Rows(iRow).EndEdit()
        End If
        UpdateList()
    End Sub
    Private Sub V_Gt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
        If Dt_DetailTmp.Rows(iRow).Item("Gt2") < Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Gt3") = Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1")
            Dt_DetailTmp.Rows(iRow).EndEdit()
        ElseIf Dt_DetailTmp.Rows(iRow).Item("Gt2") > Dt_DetailTmp.Rows(iRow).Item("Tien_Nt") - Dt_DetailTmp.Rows(iRow).Item("Ck") - Dt_DetailTmp.Rows(iRow).Item("Gt1") Then

            Dt_DetailTmp.Rows(iRow).Item("Gt2") = 0
        End If
        UpdateList()
    End Sub
    Private Sub V_Gt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Exit Sub
        End If
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_Ma_Pk(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Pk", "DmPk", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Pk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        Dim iRow As Integer = -1
        iRow = DetailGRVPK.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dt_DetailtmpPK.Rows(iRow).BeginEdit()
            Dt_DetailtmpPK.Rows(iRow).Item("Ma_Pk") = ""
            Dt_DetailtmpPK.Rows(iRow).Item("Ten_Pk") = ""
            Dt_DetailtmpPK.Rows(iRow).Item("Dvt") = ""
            Dt_DetailtmpPK.Rows(iRow).EndEdit()
            Exit Sub
        Else
            Dt_DetailtmpPK.Rows(iRow).BeginEdit()
            Dt_DetailtmpPK.Rows(iRow).Item("Ma_Pk") = DrReturn("Ma_Pk").ToString.Trim
            Dt_DetailtmpPK.Rows(iRow).Item("Ten_Pk") = DrReturn("Ten_Pk" + IIf(M_LAN = "V", "", "2")).ToString.Trim
            Dt_DetailtmpPK.Rows(iRow).Item("Dvt") = DrReturn("Dvt").ToString.Trim
        End If
        V_SetPricePK(iRow)
        Dt_DetailtmpPK.AcceptChanges()
        DetailGRVPK.UpdateCurrentRow()
    End Sub
    Private Sub V_SetPricePK(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _ma_HD As String = ""
        _ma_HD = TxtMa_HD_H.Text.Trim

        CyberSmodb.GetValueData(Dv_DetailtmpPK.Item(iRow), _strF, _strV, "Ten_Pk")
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
        CyberSmodb.V_UpdateRowtoRow(Dstmp.Tables(1).Rows(0), Dv_DetailtmpPK, iRow)
        V_Tinh_ToanPK(iRow)
        Dstmp.Dispose()

    End Sub

    Private Sub V_SetPricePK_LUU(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Pk As String = Dv_DetailtmpPK.Item(iRow).Item("Ma_Pk").ToString.Trim
        Dim _So_Luong As Decimal = Dv_DetailtmpPK.Item(iRow).Item("So_Luong")
        Dim _Gia_Nt As Decimal = Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt")
        Dim _Tien_Nt As Decimal = Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt")
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ma_Kh As String = TxtMa_Kh.Text
        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPricePK", _Ma_Pk.Trim + "#" + _Ma_Kh + "#" +
        _Ngay_Ct.ToString("yyyyMMdd") + "#" + _So_Luong.ToString.Trim.Replace(",", ".") + "#" + _Gia_Nt.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt.ToString.Trim.Replace(",", ".") + "#" +
        M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Ma_CT.Trim + "#" + TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)

        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If
        Dim _DtGia As DataTable = DsgetPrice.Tables(0)
        Dv_DetailtmpPK.Item(iRow).BeginEdit()

        If _DtGia.Columns.Contains("So_Luong") Then Dv_DetailtmpPK.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
        If _DtGia.Columns.Contains("Gia_Nt") Then Dv_DetailtmpPK.Item(iRow).Item("Gia_Nt") = _DtGia.Rows(0).Item("Gia_Nt")
        If _DtGia.Columns.Contains("Tien_Nt") Then Dv_DetailtmpPK.Item(iRow).Item("Tien_Nt") = _DtGia.Rows(0).Item("Tien_Nt")
        Dv_DetailtmpPK.Item(iRow).EndEdit()
        DsgetPrice.Dispose()
        Dv_DetailtmpPK.Table.AcceptChanges()
        V_Tinh_ToanPK(iRow)
    End Sub
#End Region
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
    Private Sub V_Ma_Db_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Db_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        V_GetNgay1()
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
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        For iRow = 0 To Dv_DetailTmp.Count - 1
            V_SetPriceXeSales(iRow)
        Next
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
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
        Dim mnItemsF5 As New MenuItem("Tạo xe Fleet", AddressOf V_Tao_nhieu_Xe, Keys.F5)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)
        'Dim mnItemsPrint_Rec0 As New MenuItem(If(M_LAN = "V", "In các biên bản của từng xe", "Delete row"), AddressOf V_ShortPrint_Rec0, Keys.F10)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF5)

        mnItemsMail.MenuItems.Add(mnItemsF8)
        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        'mnItemsMail.MenuItems.Add(mnItemsPrint_Rec0)

        DetailGRV.GridControl.ContextMenu = mnItemsMail

        Me.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo nhiều xe", "Add items"), AddressOf V_Tao_nhieu_Xe, Nothing, True, False))

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_Tao_nhieu_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim Dr As DataRow = Dt_DetailTmp.Rows(iRow)
        If Dr.Item("Ma_Kx").ToString.Trim = "" Or Dr.Item("Ma_Mau").ToString.Trim = "" Then Exit Sub

        Dim Frm As New Tao_nhieu_Xe
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = osysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        'Frm.CyberExport = CyberEport
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim Sl_Copy As Decimal = Frm.txtSL_COPY.Double
        If Not Frm.Save_OK Or Sl_Copy <= 0 Then Exit Sub
        '----------------------------------
        For i As Integer = 1 To Sl_Copy
            Dt_DetailTmp.ImportRow(Dr)
        Next
        UpdateList()

        '----------------------------------
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
    Private Sub V_ShortPrint_Rec0(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec = "" Then Return
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec0 As String = Dv_DetailTmp.Item(iRow).Item("Stt_Rec0")
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintHDX_30", M_Stt_Rec + "#" + "30" + "#" + M_User_Name + "#" + _Stt_Rec0)
        Dim CyberPrint As New Cyber.Print.Sys

        Dim _Dt As DataTable = DsPrint.Tables(0).Copy
        DsPrint.Tables.Remove(DsPrint.Tables(0))

        Dim _PrintDialog As New System.Windows.Forms.PrintDialog
        CyberPrint.CyberPrintReportcustomer(_PrintDialog, AppConn, "PREVIEW", _Dt.Rows(0).Item("Repo_Name"), DsPrint, _Dt.Rows(0).Item("M_Title"), _Dt.Rows(0).Item("M_Title"), osysvar, M_Para, M_Ma_Dvcs)
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
#Region "Mainform Phụ kiện"
    Private Sub V_MainSystemPK()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemPK, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemPK, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVPK.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVPK_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemPK, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemPK, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_ImportPK, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemPK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPK.FocusedRowHandle
        V_AddItemPK(iRow)
        iRow = Dv_DetailtmpPK.Count - 1
        CyberFill.V_ForcusCell(DetailGRVPK, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemPK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPK.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailtmpPK, AppConn) Then Exit Sub
        Dv_DetailtmpPK.Delete(iRow)
        Dv_DetailtmpPK.Table.AcceptChanges()
        UpdateList()
    End Sub
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRV.PostEditor()
        DetailGRV.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailtmpPK.Table.AcceptChanges()

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
        If Not V_ChkHuy() Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        ''V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        'Dim _StrMF As String = ""
        'Dim _StrMV As String = ""
        'V_GetNoMa_HDVoucherAuto(_StrMF, _StrMV)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailtmpPK, M_Is_Visible_TTCP, CmbMa_TTCP_H, M_Ma_CT, CyberSmodb)

        If TxtMa_HD_KH.Text.Trim = "" Then TxtMa_HD_KH.Text = TxtMa_HD_H.Text
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
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailtmpPK}, {M_Ct, M_Ph, "CTHDXPK"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CmbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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

        '---Update PK
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailtmpPK, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---------------------------------------------------
        '---Xoa trong DetailPK

        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailPK, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailPK.Load(Dt_DetailtmpPK.CreateDataReader)
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
        DetailGRVPK.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailtmpPK.Table.AcceptChanges()
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
        'V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        Dim _StrMF As String = ""
        Dim _StrMV As String = ""
        V_GetNoMa_HDVoucherAuto(_StrMF, _StrMV)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsaveHDX(_StrMF, _StrMV) Then Exit Sub '2019.04.01'
        '----------------------------------------------------------------------------------------------------------------------
        ' 
        'If Not ChkVHDXDKGX(M_Mode) Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,Ten_Kh", "TEN_VT,Ten_KhO_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
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
    Private Sub V_GetNoMa_HDVoucherAuto(ByRef strField As String, ByRef strValue As String)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dim _Ma_Kx As String = If(Dt_DetailTmp.Rows.Count > 0, Dv_DetailTmp.Item(0).Item("Ma_Kx"), "")
        Dim _Dt As Date = TxtNgay_Ct.Value

        CyberSmodb.GetValueControler(Me, strField, strValue, "Ten_LHKH,Ten_GPK,Ten_Sk,Ten_Nh_HD1,Ten_Nh_HD2,Ten_Nh_HD3,Ten_BP_H,Ten_HS_H")

        Dim DsGet As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDXGetNoMa_HDVoucherAuto", M_Stt_Rec & "#" & M_Mode & "#" & _Dt.ToString("yyyyMMdd") & "#" &
        _Ma_Kx & "#" & strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsGet.Tables.Count < 2 Then
            DsGet.Dispose()
            Exit Sub
        End If
        If Not DsGet.Tables(0).Columns.Contains("status") Or Not DsGet.Tables(0).Columns.Contains("Msg") Or Not DsGet.Tables(0).Columns.Contains("Note") Then
            DsGet.Dispose()
            Exit Sub
        End If
        If DsGet.Tables(0).Rows.Count <= 0 Then
            DsGet.Dispose()
            Exit Sub
        End If
        If Not CyberSupport.V_MsgChk(DsGet.Tables(0), osysvar, M_LAN) Then
            DsGet.Dispose()
            Exit Sub
        End If
        If DsGet.Tables(1).Columns.Contains("Ma_HD_H") Then TxtMa_HD_H.Text = DsGet.Tables(1).Rows(0).Item("Ma_HD_H").ToString.Trim
        If DsGet.Tables(1).Columns.Contains("So_CT") Then TxtSo_Ct.Text = DsGet.Tables(1).Rows(0).Item("So_CT").ToString.Trim
    End Sub
    Private Function ChkVsaveHDX(ByVal _strMF As String, ByVal _strMV As String) As Boolean
        Dim _Return As Boolean = False

        Dim _strDetail As String = ""
        Dim _Dt As Date
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _ma_Post
        'ing = ""
        _ma_Post = CbbMa_Post.SelectedValue.ToString

        For i = 0 To Dv_DetailTmp.Count - 1
            _strDetail = _strDetail + "; INSERT ChkDKHD_HDX SELECT N'" + (i + 1).ToString.Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Stt_Rec0").ToString.Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Ma_CSBH").ToString.Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Ma_Kx").ToString.Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Ma_Mau").ToString.Trim + "'"

            _Dt = Dv_DetailTmp.Item(i).Item("Ngay_Gx")
            _strDetail = _strDetail + ", N'" + _Dt.ToString("yyyyMMdd").Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Tien_Nt").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"

            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("PK_BB").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("BH_BB").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("KHAC_BB").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"



            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Ck").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("MOI_GIOI").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Km_PK").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("KM_KHAC").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"

            _Dt = Dv_DetailTmp.Item(i).Item("Ngay1")
            _strDetail = _strDetail + ", N'" + _Dt.ToString("yyyyMMdd").Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("GT1").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"

            _Dt = Dv_DetailTmp.Item(i).Item("Ngay2")
            _strDetail = _strDetail + ", N'" + _Dt.ToString("yyyyMMdd").Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("GT2").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"

            _Dt = Dv_DetailTmp.Item(i).Item("Ngay3")
            _strDetail = _strDetail + ", N'" + _Dt.ToString("yyyyMMdd").Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("GT3").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"

            _Dt = Dv_DetailTmp.Item(i).Item("Ngay4")
            _strDetail = _strDetail + ", N'" + _Dt.ToString("yyyyMMdd").Trim + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("GT4").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            _strDetail = _strDetail + ", N'" + Dv_DetailTmp.Item(i).Item("Ma_HD_I").ToString.Trim + "'"
        Next
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkSaveHDX", _strMF & "#" & _strMV & "#" & _strDetail & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Stt_Rec & "#" & _ma_Post & "#" & M_Mode & "#" & M_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name)


        Dim _Note As String = DsTmp.Tables(0).Rows(0).Item("Note").ToString.Trim
        Dim _Status As String = DsTmp.Tables(0).Rows(0).Item("Status").ToString.Trim
        Dim _Msg As String = DsTmp.Tables(0).Rows(0).Item("Msg").ToString.Trim
        Dim _Option As Boolean = False

        If DsTmp.Tables(0).Columns.Contains("Option") Then
            _Option = DsTmp.Tables(0).Rows(0).Item("Option").ToString.Trim() = "Y"
        End If

        If _Option Then
            _Return = CyberSupport.V_MsgChk(_Status, _Msg, _Note, osysvar, True)
        Else
            _Return = CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, M_LAN)
        End If


        If _Return And DsTmp.Tables(0).Columns.Contains("Ma_Post") Then
            _ma_Post = DsTmp.Tables(0).Rows(0).Item("Ma_Post").ToString
            Try
                CbbMa_Post.SelectedValue = _ma_Post
            Catch ex As Exception
            End Try
        End If
        DsTmp.Dispose()
        ChkVsaveHDX = _Return
    End Function
    Private Function ChkVHDXDKGX(ByVal _Mode As String) As Boolean
        Dim _Return As Boolean = True
        Dim strMa_Kx As String = ""
        Dim strMa_Mau As String = ""
        Dim strNgay_Gx As String = ""
        Dim _Ma_GD As String = CmbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Dt As Date

        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            _Dt = Dt_DetailTmp.Rows(i).Item("Ngay_Gx")
            strMa_Kx = strMa_Kx + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Ma_Kx").ToString.Trim
            strMa_Mau = strMa_Mau + IIf(i = 0, "", "!~!") + Dt_DetailTmp.Rows(i).Item("Ma_Mau").ToString.Trim
            strNgay_Gx = strNgay_Gx + IIf(i = 0, "", "!~!") + _Dt.ToString("yyyyMMdd").Trim
        Next
        _Dt = TxtNgay_Ct.Value
        Dim DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEHDXChkNgay_Gx",
        Dt_DetailTmp.Rows.Count.ToString.Trim & "#" & strMa_Kx & "#" & strMa_Mau & "#" & strNgay_Gx & "#" &
        _Dt.ToString("yyyyMMdd") & "#" & M_Stt_Rec & "#" & _Ma_Post & "#" & _Ma_GD & "#" & _Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = CyberSupport.V_MsgChk(DsChk.Tables(0), osysvar, M_LAN)
        DsChk.Dispose()
        ChkVHDXDKGX = _Return
    End Function
    Private Function V_ChkHuy() As Boolean
        If ChkHuy.Checked Then
            If MsgBox("Điều kiện hợp đồng này lựa chọn hủy toàn bộ,Bạn có hủy không", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, SysVar("M_CYBER_VER")) = MsgBoxResult.Ok Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
    Private Function ChkVsave() As Boolean

        If Not TxtDia_ChiVAT.Visible Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
        If Not TxtTen_KhVAT.Visible Then TxtTen_KhVAT.Text = TxtTen_Kh.Text

        If Not ChkTra_Thang.Checked And Not ChkTra_Gop.Checked And Not ChkTra_Thue_Mua.Checked And Not ChkTra_Cham.Checked Then
            MsgBox("Bạn chưa chọn loại hình thanh toán", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            Return False
        End If
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_Kx").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailtmpPK.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailtmpPK.Rows(iRow).Item("Ma_Pk").ToString.Trim = "" Then
                Dt_DetailtmpPK.Rows(iRow).Delete()
                Dt_DetailtmpPK.AcceptChanges()
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
            If Dt_DetailTmp.Columns.Contains("Ma_HD_I") Then If TxtMa_HD_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HD_I") = TxtMa_HD_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Bp_I") Then If TxtMa_BP_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_Bp_I") = TxtMa_BP_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_HS_I") Then If TxtMa_Hs_H.Text.Trim <> "" Then Dt_DetailTmp.Rows(iRow).Item("Ma_HS_I") = TxtMa_Hs_H.Text.Trim
            If ChkHuy.Checked Then
                If Dt_DetailTmp.Columns.Contains("Huy_CT") Then Dt_DetailTmp.Rows(iRow).Item("Huy_CT") = "1"
            Else
                If Dt_DetailTmp.Columns.Contains("Huy_CT") Then Dt_DetailTmp.Rows(iRow).Item("Huy_CT") = "0"
            End If

            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        For iRow = 0 To Dt_DetailtmpPK.Rows.Count - 1
            Dt_DetailtmpPK.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailtmpPK.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailtmpPK.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailtmpPK.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)

            If Dt_DetailtmpPK.Columns.Contains("Ma_HD_I") Then If TxtMa_HD_H.Text.Trim <> "" Then Dt_DetailtmpPK.Rows(iRow).Item("Ma_HD_I") = TxtMa_HD_H.Text.Trim
            If Dt_DetailtmpPK.Columns.Contains("Ma_Bp_I") Then If TxtMa_BP_H.Text.Trim <> "" Then Dt_DetailtmpPK.Rows(iRow).Item("Ma_Bp_I") = TxtMa_BP_H.Text.Trim
            If Dt_DetailtmpPK.Columns.Contains("Ma_HS_I") Then If TxtMa_Hs_H.Text.Trim <> "" Then Dt_DetailtmpPK.Rows(iRow).Item("Ma_HS_I") = TxtMa_Hs_H.Text.Trim
        Next
        Dt_DetailtmpPK.AcceptChanges()
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False
        '---Update: So_RO/So_PO/So_SO
        CyberSupport.V_SaveLenh(Dv_DetailTmp, TxtLenh_RO.Text, TxtLenh_PO.Text, TxtLenh_SO.Text, TxtLenh_Vt.Text)
        UpdateList()
        ChkVsave = True
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
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        'If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        'If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailPK, "Stt_Rec = '" + M_Stt_Rec + "'")


        CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        CyberSmodb.DeleteDatatable(Dt_DetailPK, "Stt_Rec = '" + M_Stt_Rec + "'")


        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next

        For i As Integer = 0 To Dt_DetailtmpPK.Rows.Count - 1
            Dt_DetailPK.ImportRow(Dt_DetailtmpPK.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailtmpPK}, {M_Ct, M_Ph, "CTHDXPK"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)

        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'If M_Ct.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailtmpPK, "CTHDXPK", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
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
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailPK, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailtmpPK.Rows.Count - 1
            Dt_DetailPK.ImportRow(Dt_DetailtmpPK.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL
        If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        If M_Ct.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailtmpPK, "CTHDXPK", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
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
        For iRow = 0 To Dt_DetailtmpPK.Rows.Count - 1
            Dt_DetailtmpPK.Rows(iRow).BeginEdit()
            Dt_DetailtmpPK.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailtmpPK.Rows(iRow).Item("Lan") = 1
            Dt_DetailtmpPK.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailtmpPK.Rows(iRow).EndEdit()
        Next


        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        TxtSo_Ct.Text = _So_Ct_Copy.Trim
        V_GetMaBPCopy()

        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

    End Sub
    Private Sub V_GetMaBPCopy()
        Dim dsTMp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetBpHs", M_User_Name)
        If dsTMp.Tables.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Rows.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Columns.Contains("Ma_Bp_H") Then TxtMa_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_Bp_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Bp_H") Then TxtTen_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Bp_H")
        If dsTMp.Tables(0).Columns.Contains("Ma_Hs_H") Then TxtMa_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_HS_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Hs_H") Then TxtTen_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Hs_H")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "0" Then TxtNgay_LCt.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_HH.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        dsTMp.Dispose()
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
        ChkHuy.Checked = False

        CbbMa_Post.SelectedValue = "2"

        TxtTL_TT.Double = 100
        V_New()
        '----------------------------------------------------------
        TxtNgay_Sinh.Value = New Date(1900, 1, 1)
        TxtNgay_CMT.Value = New Date(1900, 1, 1)
        TxtNgay_Cmt_MG.Value = New Date(1900, 1, 1)
        '----------------------------------------------------------
        V_GetMaBP()
        V_GetNgamDinh()
        '----------------------------------------------------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        ChkLoai()
        CyberSmodb.SetValueFromCombox(CmbMa_TTCP_H, M_Ma_TTCP_H)
        CbbMa_Post.Enabled = False
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
        If dsTMp.Tables(0).Columns.Contains("Ma_Bp_H") Then If TxtMa_BP_H.Text.Trim = "" Then TxtMa_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_Bp_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Bp_H") Then If TxtTen_BP_H.Text.Trim = "" Then TxtTen_BP_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Bp_H")
        If dsTMp.Tables(0).Columns.Contains("Ma_Hs_H") Then If TxtMa_Hs_H.Text.Trim = "" Then TxtMa_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ma_HS_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Hs_H") Then If TxtTen_Hs_H.Text.Trim = "" Then TxtTen_Hs_H.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Hs_H")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_Lct").ToString.Trim = "0" Then TxtNgay_LCt.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_HH.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        dsTMp.Dispose()
    End Sub
    Private Sub V_GetNgamDinh()
        CmbMa_TP.SelectedValue = ""
        If M_Ma_TP_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_TP.SelectedValue = M_Ma_TP_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If

        CmbMa_Quan.SelectedValue = ""
        If M_Ma_Quan_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_Quan.SelectedValue = M_Ma_Quan_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If

        CmbMa_Xa.SelectedValue = ""
        If M_Ma_Xa_Ngam_Dinh.Trim <> "" Then
            Try
                CmbMa_Xa.SelectedValue = M_Ma_Xa_Ngam_Dinh
            Catch ex As Exception
            End Try
        End If
        Try
            CmbMa_HTLL.SelectedValue = M_Ma_HTLL_Ngam_Dinh
        Catch ex As Exception
        End Try

        Try
            CmbMa_MDSD.SelectedValue = M_Ma_MDSD_Ngam_Dinh
        Catch ex As Exception
        End Try

        Try
            CmbMa_HTMX.SelectedValue = M_Ma_HTMX_Ngam_Dinh
        Catch ex As Exception
        End Try

        Try
            CmbMa_DKGX.SelectedValue = M_Ma_DKGX_Ngam_Dinh
        Catch ex As Exception
        End Try

        Try
            CmbMa_Nh.SelectedValue = M_Tk_Nh_Ngam_Dinh
        Catch ex As Exception
        End Try

        Try
            CmbKy_HD.SelectedValue = M_Ky_HD_Ngam_Dinh

        Catch ex As Exception
        End Try

        Try
            CmbCv_Ky_KD.SelectedValue = M_Cv_Ky_HD_Ngam_Dinh
        Catch ex As Exception
        End Try

        'If M_Mode.Trim = "M" Then TxtDia_DiemGX.Text = "Tại địa chỉ bên bán"
    End Sub
    Private Sub ChkLoai()
        ChkTra_Thang.Checked = True
        ChkTra_Gop.Checked = False
        ChkTra_Thue_Mua.Checked = False
        ChkTra_Cham.Checked = False
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            If Not M_Tk_No.Trim = "" Then
                DrCurren.Item("Ma_Nx_I") = M_Tk_No.Trim
                If DrCurren.Table.Columns.Contains("Ten_Nx_I") Then DrCurren.Item("Ten_Nx_I") = M_Ten_Tk_No.Trim
            End If

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If
        If Dt_DetailtmpPK.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailtmpPK.NewRow()
            DrCurren = Dt_DetailtmpPK.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"
            Dt_DetailtmpPK.Rows.Add(DrCurren)
            Dt_DetailtmpPK.AcceptChanges()
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
        If Not V_ChkDelete() Then Exit Sub

        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub

        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailPK, M_Stt_Rec)

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
        Dim _Return As Boolean = True
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkDeleteHDX", M_Stt_Rec & "#" & M_Ma_CT & "#" & TxtMa_Dvcs.Text & "#" & M_User_Name)

        'If TxtMa_Hd_H.Text.Trim = "" Then Return _Return
        'Dim _DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "BEXEPXE#MA_HD = N'" & TxtMa_Hd_H.Text.Trim & "'#Ma_HD")
        'If _DsChk.Tables(0).Rows.Count > 0 Then _Return = False
        '_DsChk.Dispose()
        _Return = CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, M_LAN)
        V_ChkDelete = _Return
    End Function
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        'If M_Stt_Rec.Trim = "" Then Exit Sub
        'Dim _Dt As Date = TxtNgay_Ct.Value
        'Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        'CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec = "" Then Exit Sub
        Dim DtMaIn As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetPrintVoucher", M_Ma_CT + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtMaIn = DsTmp.Tables(0).Copy
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim Frm As FrmPrintVoucherHDX_STT

        Frm = New FrmPrintVoucherHDX_STT
        'Frm.User_Name = Me.M_User_Name
        Frm.AppConn = Me.AppConn
        Frm.Lan = Me.M_LAN
        Frm.Sysvar = Me.SysVar
        Frm.Stt_Rec = Me.Stt_Rec
        Frm.DtMaIn = DtMaIn
        Frm.Para = Me.M_Para
        Frm.DrDmct = Me.DrDmct
        Frm.ShowDialog()
        If Frm.ReturnOk = False Then Return
        Dim CyberPrint As New Cyber.Print.Sys
        Dim _Type As String = Frm.Loai_In
        Dim printsetting As New Windows.Forms.PrintDialog
        Dim ReportName As String
        Dim Print As New DataSet
        Dim _dsPrint As DataSet
        _dsPrint = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintHDX", Frm.Key_Sub1 & "#" & M_Stt_Rec & "#" & Frm.Ma_In & "#" & M_User_Name)
        ReportName = _dsPrint.Tables(0).Rows(0)("Repo_Name")
        For i = 1 To _dsPrint.Tables.Count - 1
            Print.Tables.Add(_dsPrint.Tables(i).Copy)
        Next

        CyberPrint.CyberPrintReport(AppConn, IIf(_Type = "PREVIEW", "1", IIf(_Type = "PRINT", "2", "3")), ReportName, Print, Frm.Title1, Frm.Title2, osysvar, M_Para, M_Ma_Dvcs)
    End Sub
    Private Sub V_XuatWord(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim


        Dim frm As New FrmXuatWord
        frm.AppConn = AppConn
        frm.Sysvar = osysvar
        frm.Lan = M_LAN
        frm.Para = M_Para
        frm.Mode = M_Mode
        frm.Stt_Rec = M_Stt_Rec
        frm.Ma_CT = M_Ma_CT
        frm.DrDmct = DrDmct
        frm.Ma_Dvcs = M_Ma_Dvcs
        frm.User_name = M_User_Name
        frm.ShowDialog()
        If Not frm.ReturnOk Then Exit Sub
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
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(2)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        If iRow >= 0 Then
            Dim _Dt As Date = Dv_DetailTmp.Table.Rows(iRow).Item("Ngay_Gx")
            If _Dt.ToString("yyyyMMdd") = "19000101" Then
                Dv_DetailTmp.Table.Rows(iRow).BeginEdit()
                Dv_DetailTmp.Table.Rows(iRow).Item("Ngay_Gx") = TxtNgay_Ct.Value
                Dv_DetailTmp.Table.Rows(iRow).EndEdit()
            End If
            If IsDBNull(_Dt) Then
                Dv_DetailTmp.Table.Rows(iRow).BeginEdit()
                Dv_DetailTmp.Table.Rows(iRow).Item("Ngay_Gx") = TxtNgay_Ct.Value
                Dv_DetailTmp.Table.Rows(iRow).EndEdit()
            End If
        End If
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
#Region "Add Or Detete Item Phụ kiện"
    Private Sub MasterGRVPK_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex        
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemPK(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemPK(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailtmpPK
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow > 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnPK(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        UpdateList()
    End Sub
    Private Sub CarrOnPK(ByVal DvNew As DataRow)
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
    Private Sub V_ImportPK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVPK, Dt_DetailtmpPK, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailtmpPK.Clear()
        Dt_DetailtmpPK.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailtmpPK.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailtmpPK.AcceptChanges()
    End Sub
    Private Sub SetTxt()
        TxtT_So_Luong.ReadOnly = True
        TxtT_Tien_NT.ReadOnly = True
        TxtT_Thu_Them.ReadOnly = True
        TxtT_CK.ReadOnly = True
        TxtT_TT_NT.ReadOnly = True

        TxtT_Km_PK.ReadOnly = True
        TxtT_Km_BH.ReadOnly = True
        TxtT_Moi_Gioi.ReadOnly = True
        TxtT_Km_Khac.ReadOnly = True
        TxtT_KM.ReadOnly = True

        TxtT_PK_BB.ReadOnly = True
        TxtT_BH_BB.ReadOnly = True
        TxtT_khac_BB.ReadOnly = True
        TxtT_BB.ReadOnly = True

        TxtT_PK_NT.ReadOnly = True

        TxtT_Gt1.ReadOnly = True
        TxtT_Gt2.ReadOnly = True
        TxtT_Gt3.ReadOnly = True
        TxtT_Gt4.ReadOnly = True

        'TxtT_Tien.ReadOnly = True
        'TxtTen_Kh.ReadOnly = True
        TxtSo_Ct.ReadOnly = True

        TxtTen_BP_H.ReadOnly = True
        TxtTen_Hs_H.ReadOnly = True

        TxtTen_LHKH.ReadOnly = True
        TxtTen_SK.ReadOnly = True
        TxtTen_GPK.ReadOnly = True

        TxtTen_Nh_HD1.ReadOnly = True
        TxtTen_Nh_HD2.ReadOnly = True
        TxtTen_Nh_HD3.ReadOnly = True

        TxtT_GG_CS.ReadOnly = True
        TxtT_Vuot_Khung.ReadOnly = True

        CmbCv_Ky_KD.Enabled = False

        ChkHuy.Enabled = False
    End Sub
#End Region
#Region "E Mail And Approval/Print Ho so"   
    Private Sub V_In_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _Stt_Rec0 As String = ""
        Dim iRow As Integer = -1
        iRow = DetailGRV.FocusedRowHandle
        If iRow >= 0 Then _Stt_Rec0 = Dv_DetailTmp.Item(iRow).Item("Stt_Rec0")
        CyberVoucher.V_PrintVoucherAll(AppConn, osysvar, M_Ma_CT, M_Stt_Rec, _Stt_Rec0, M_LAN, Me.Para, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Dim ProccessList As New Collection
    Private Sub KillProce()
        Try
            Dim op As Process
            For i As Integer = ProccessList.Count To 1 Step -1
                op = ProccessList(i)
                If Not op Is Nothing Then
                    If Not op.HasExited() Then
                        op.Kill()
                        ProccessList.Remove(i)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
    Private Sub V_Phu_Kien(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _Ma_HD_H As String = TxtMa_HD_H.Text.Trim
        If _Ma_HD_H.Trim = "" Then Return

        Dim strAddParar As String = "4#PPK#" & _Ma_HD_H & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
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
#End Region
#Region "Tạo đề nghị thanh toán"
    Private Sub V_Tao_De_nghi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _Ma_HD As String = TxtMa_HD_H.Text.Trim
        If _Ma_HD.Trim = "" Then Return
        Dim strAddParar As String = "4#LDN#10#" & "" & "#" & _Ma_HD & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
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



