Imports Cyber.Support
Public Class HDP
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_DsData, M_DsHead, Ds, M_DsLookUp As DataSet
    Dim Dt_DetailCv, Dt_DetailCvTmp As New DataTable
    Dim Dv_DetailCv, Dv_DetailCvTmp As New DataView
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView
#End Region
#Region "Khai bao bien Dll"
    Dim CyberFrom As New Cyber.From.Sys
    Dim CyberInput As New Cyber.Input.Sys
#End Region
#Region "Columns Edit"
    Dim EditMa_Vitri, EditMa_Vt, EditMa_CVVt, EditMa_CtCVVT, EditMa_NVKD, EditTen_Vt, EditTen_Vt3, EditDVt, EditMa_kho_i, EditTon13, EditTen_kho_i, EditMa_TT, _
         EditMa_Vv_i, EditMa_Hd_i, EditMa_phi_I, EditMa_Sp_i, EditMa_ku_I, EditMa_TTLN_I, EditMa_TTCP_I, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditTien2, EditTien0, EditGia_TK, EditGia2, EditCk_i, _
        EditPt_Ck_i, EditThue_Suat, EditThue, EditTien_BH, EditThue_BH, EditLAN, EditSl_TD_I As New Cyber.Fill.CyberColumnGridView
    Dim Editma_KTV_I, EditMa_TD1_i, EditMa_TD2_i, EditMa_TD3_i, EditMa_TD4_i, EditMa_TD5_i As New Cyber.Fill.CyberColumnGridView
    '-------------------------------------------
    Dim EditMa_CVCv, EditTen_CVCv, EditTIEN_CV0Cv, EditTen_CV3Cv, EditMa_TTCv, EditMa_CtcvCv, EditGia_CVCV, EditGio_TCCV, EditTien_CVCv, EditPT_Ck_ICv, EditCk_ICv, EditThue_SuatCv, _
        EditThueCV, EditTien_BHCv, EditThue_BHCv, EditLANCv As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Hd_iCV, EditMa_Vv_iCV, EditMa_phi_iCV, EditMa_Sp_iCV, EditMa_ku_iCV, EditMa_TTLN_iCV, EditMa_TTCP_iCV, EditMa_BP_iCV, EditMa_HS_iCV, EditMa_CD_iCV As New Cyber.Fill.CyberColumnGridView
    Dim Editma_KTV_ICV, EditMa_TD1_iCV, EditMa_TD2_iCV, EditMa_TD3_iCV, EditMa_TD4_iCV, EditMa_TD5_iCV As New Cyber.Fill.CyberColumnGridView
    '-------------------------------------------
    '---Dieu chinh
    Dim EditDC_I, EditPT_DC_I, EditDC_ICV, EditPT_DC_ICV As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Ktv_SCV, EditMa_Ktv_SVT As New Cyber.Fill.CyberColumnGridView
    Dim EditSua_Thue, EditSua_ThueCV As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_kh_I, EditTen_kh_I As New Cyber.Fill.CyberColumnGridView
    '-------------------------------------------
    Dim DtPH89Xestru, DtPH89stru, DtDmXestru As DataTable
#End Region
#Region "Khai bao bien Private"
    Dim M_Ma_Hs As String = ""
    Dim M_Ten_Hs As String = ""
    Dim M_Ma_BP As String = ""
    Dim M_Ten_BP As String = ""

    Dim M_Ct, M_Ph As String
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
    Dim DrReturn As DataRow
    Dim M_Ma_Kx, M_Ma_Mau, M_MA_TP, M_Ma_TT As String
    Dim M_Stt_RecCopy As String
    Dim M_Ma_TP_Ngam_Dinh As String = ""
    Dim M_Ma_Quan_Ngam_Dinh As String = ""
    Dim M_Ma_Xa_Ngam_Dinh As String = ""

    Dim M_Vai_Tro_Ngam_Dinh As String = ""
    Dim M_Ma_HTLL_Ngam_Dinh As String = ""
    Dim Dt_vai_tro, Dt_HTLL As DataTable
    Dim SysvarRO As Collection
#End Region
    Private Sub HDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct.Value = Now.Date
        TxtNgay_NT.Value = Now.Date
        TxtNgay_KT.Value = Now.Date
        ' Txtngay_Hen.Value = Now.Date
        V_Load()
        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        '------------------------------
        V_GetColumn()
        V_AddHandler()
        '------------------------------
        V_LoadPTTheoHD("1")
        '------------------------------
        V_Databing()
        '------------------------------
        V_GetStrus()
        '------------------------------
        M_Mode = "X"
        'CyberSmodb.SetListFixLengthEnabled(Me, M_Ph, AppConn, Me.Mode, M_User_Name, CyberSmlib)
        M_Count = Dt_Master.Rows.Count
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        V_MainSystemCv()
        GetRound()
        CmdNew.Select()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_GetStrus()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.PH89Xe WITH (NOLOCK) WHERE 1=0;SELECT TOP 0 * FROM dbo.PH89 WITH (NOLOCK) WHERE 1=0;SELECT TOP 0 * FROM dbo.Dmxe WITH (NOLOCK) WHERE 1=0  #" + M_Ma_Dvcs + "#" + M_User_Name)
        DtPH89Xestru = Dstmp.Tables(0).Copy
        DtPH89stru = Dstmp.Tables(1).Copy
        DtDmXestru = Dstmp.Tables(2).Copy
        Dstmp.Dispose()
    End Sub
    Dim Dt_DetailPKHDTmp, Dt_headPKHD As DataTable
    Dim Dv_DetailPKHDTmp, Dv_headPKHD As DataView
    Private Sub V_LoadPTTheoHD(ByVal Status As String)
        Dim _Ma_HD As String = TxtMa_td3_H.Text
        Dim _Loai As String = IIf(ChkIs_PK_BB_KM.Checked, "1", "0")

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDPHDMFromHDX", Status + "#" + _Loai + "#" + _Ma_HD + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next
        If Status = "1" Then
            Dt_DetailPKHDTmp = Dstmp.Tables(0).Copy
            Dt_headPKHD = Dstmp.Tables(1).Copy
            Dv_DetailPKHDTmp = New DataView(Dt_DetailPKHDTmp)
            Dv_headPKHD = New DataView(Dt_headPKHD)

            DetailPKHD.DataSource = Dv_DetailPKHDTmp
            Me.DetailPKHDGRV.GridControl = Me.DetailPKHD
            CyberFill.V_FillVoucher(DetailPKHDGRV, M_LAN, Dv_headPKHD, Dv_DetailPKHDTmp, Me.DrDmct)
        Else
            Dt_DetailPKHDTmp.Clear()
            Dt_DetailPKHDTmp.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_DetailPKHDTmp.AcceptChanges()
        End If
        Dstmp.Dispose()
        UpdateList()
    End Sub
    Private Sub L_HDMGetThongTinHDX()
        Dim _Ma_HD As String = TxtMa_td3_H.Text
        Dim _Loai As String = IIf(ChkIs_PK_BB_KM.Checked, "1", "0")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HDMFromHDX", _Loai + "#" + M_Mode + "#" + _Ma_HD + "#" + M_Ma_Dvcs + "#" + M_User_Name)
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
        If Dstmp.Tables(1).Columns.Contains("Ten_kh") Then TxtTen_kh.Text = Dstmp.Tables(1).Rows(0).Item("Ten_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dia_chi") Then TxtDia_Chi.Text = Dstmp.Tables(1).Rows(0).Item("Dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_khVat") Then TxtTen_khVAT.Text = Dstmp.Tables(1).Rows(0).Item("Ten_kh").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dia_chiVat") Then TxtDia_ChiVAT.Text = Dstmp.Tables(1).Rows(0).Item("Dia_chi").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_so_thue") Then TxtMa_So_Thue.Text = Dstmp.Tables(1).Rows(0).Item("Ma_so_thue").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ong_ba") Then txtTen_Lx.Text = Dstmp.Tables(1).Rows(0).Item("Ong_ba").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dt_LH") Then TxtDt_LX.Text = Dstmp.Tables(1).Rows(0).Item("Dt_LH").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_kx") Then TxtMa_Kx.Text = Dstmp.Tables(1).Rows(0).Item("Ma_kx").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_mau") Then TxtMa_Mau.Text = Dstmp.Tables(1).Rows(0).Item("Ma_mau").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_Hs_H") Then TxtMa_Hs_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Hs_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_Hs_h") Then TxtTen_Hs_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_Hs_h").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_bp_H") Then TxtMa_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ma_bp_H").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_bp_h") Then TxtTen_Bp_H.Text = Dstmp.Tables(1).Rows(0).Item("Ten_bp_h").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Xuat_xu") Then TxtXuat_Xu.Text = Dstmp.Tables(1).Rows(0).Item("Xuat_xu").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Dien_giai") Then txtDien_giai.Text = Dstmp.Tables(1).Rows(0).Item("Dien_Giai").ToString.Trim
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
    Private Sub V_Load()
        V_Getdefault()
        ' Vật tư
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        ' Công việc
        Dt_DetailCv = M_DsData.Tables(2)
        Dt_DetailCvTmp = Dt_DetailCv.Clone
        ' Ph
        Dt_Master = M_DsData.Tables(1)
        ' Vật tư
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        ' Công việc
        Dv_DetailCv = New DataView(Dt_DetailCv)
        Dv_DetailCvTmp = New DataView(Dt_DetailCvTmp)


        ' Ph
        Dv_Master = New DataView(Dt_Master)
        '========= FillData to Gridview Vt
        DetailVt.DataSource = Dv_DetailTmp
        Me.DetailGRVVt.GridControl = Me.DetailVt
        CyberFill.V_FillVoucher(DetailGRVVt, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCvTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailCvTmp, Me.DrDmct)
        '=========== FillCombox
        V_nam()
        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)
        '--------------------------------------------
        TxtDat_Coc.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtDat_Coc.InputMask)
        TxtT_DC_CV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_DC_CV.InputMask)
        TxtT_DC_VT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_DC_VT.InputMask)

        '--------------------------------------------
        TxtT_CV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_CV.InputMask)
        TxtT_CK_CV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_CK_CV.InputMask)
        TxtT_Thue_CV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue_CV.InputMask)

        TxtT_TT_CV.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT_CV.InputMask)
        TxtT_Tien2.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien2.InputMask)
        TxtT_CK_VT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_CK_VT.InputMask)
        TxtT_Thue_VT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Thue_VT.InputMask)
        TxtT_TT_VT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT_VT.InputMask)
        TxtMoi_Gioi.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtMoi_Gioi.InputMask)
        TxtHH_BH.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtHH_BH.InputMask)

        TxtT_I.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_I.InputMask)
        TxtT_W.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_W.InputMask)
        TxtT_N.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_N.InputMask)
        TxtT_C.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_C.InputMask)
        TxtT_TT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_TT.InputMask)
        '--------------------------------------------
    End Sub
    Private Sub V_Nam()
        Dim tbNam As New DataTable
        tbNam.Columns.Add("Nam")
        Dim _R_C As Decimal = Now.Year + 1
        For i = 1995 To _R_C
            tbNam.Rows.Add(i.ToString.Trim)
        Next
        CyberFill.V_FillComBoxValue(CmbNam_Sx, tbNam, "Nam", "Nam", Date.Now.Year.ToString)
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
        M_Ma_Kx = M_Para(M_VT_PARA + 3).Trim
        M_Ma_Mau = M_Para(M_VT_PARA + 4).Trim
        M_MA_TP = M_Para(M_VT_PARA + 5).Trim
        M_Ma_TT = M_Para(M_VT_PARA + 6).Trim
        M_Stt_Rec = M_Para(M_VT_PARA + 7).Trim

        ''---------------------------------------------------------------------------------------------'
        'Dim DsTpQuanXa As New DataSet
        'DsTpQuanXa = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTPQuanXa", M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        'TbTP = DsTpQuanXa.Tables(0).Copy
        'vTbTP = New DataView(TbTP)

        'TbQuan = DsTpQuanXa.Tables(1).Copy
        'vTbQuan = New DataView(TbQuan)

        'TbXa = DsTpQuanXa.Tables(2).Copy
        'vTbXa = New DataView(TbXa)

        'DsTpQuanXa.Dispose()

        ''=========== FillCombox
        'CyberFill.V_FillComBoxValue(CmbMa_TP, vTbTP, "ma_Tp", "Ten_Tp", "")
        'CyberFill.V_FillComBoxValue(CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan", "")
        'CyberFill.V_FillComBoxValue(CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa", "")

        ''--------------------------------------------------------------------------------------------
        'If TbTP.Columns.Contains("Ngam_Dinh") Then
        '    For i As Integer = 0 To TbTP.Rows.Count - 1
        '        If TbTP.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
        '            M_Ma_TP_Ngam_Dinh = TbTP.Rows(i).Item("ma_TP").ToString.Trim
        '            Exit For
        '        End If
        '    Next
        'End If
        'If TbQuan.Columns.Contains("Ngam_Dinh") Then
        '    For i As Integer = 0 To TbQuan.Rows.Count - 1
        '        If TbQuan.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
        '            M_Ma_Quan_Ngam_Dinh = TbQuan.Rows(i).Item("ma_Quan").ToString.Trim
        '            Exit For
        '        End If
        '    Next
        'End If
        'If TbXa.Columns.Contains("Ngam_Dinh") Then
        '    For i As Integer = 0 To TbXa.Rows.Count - 1
        '        If TbXa.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
        '            M_Ma_Xa_Ngam_Dinh = TbXa.Rows(i).Item("ma_Xa").ToString.Trim
        '            Exit For
        '        End If
        '    Next
        'End If
        ''---------------------------------------------------------------------------------------------'
        V_LoadDefaultHDK()
        ''---------------------------------------------------------------------------------------------'
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
        '---------------------------------------------------------------------------------------------'
        V_LoadDefault()
        '---------------------------------------------------------------------------------------------'
    End Sub
    Private Sub V_LoadDefaultHDK()
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
        '---------------------------------------------------------------------------------------------'
    End Sub
    Private Sub V_SetProperty()
        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")
        If FixCol < DetailGRVVt.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVVt.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVVt.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVVt.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

        If FixCol < DetailGRVCv.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVCv.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVCv.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVCv.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

    End Sub
    Private Sub V_GetColumn()

        EditMa_kh_I.GetColumn(Me.DetailGRVVt, "Ma_kh_I")
        EditTen_kh_I.GetColumn(Me.DetailGRVVt, "Ten_kh_I")

        EditMa_Vitri.GetColumn(DetailGRVVt, "Ma_vitri")
        EditMa_NVKD.GetColumn(Me.DetailGRVVt, "Ma_NVKD")
        EditMa_Vt.GetColumn(Me.DetailGRVVt, "Ma_Vt")
        EditMa_CVVt.GetColumn(Me.DetailGRVVt, "Ma_CV")
        EditMa_CtCVVT.GetColumn(Me.DetailGRVVt, "Ma_Ctcv")

        EditTen_Vt.GetColumn(Me.DetailGRVVt, "Ten_Vt")
        EditTen_Vt3.GetColumn(Me.DetailGRVVt, "Ten_Vt3")
        EditDVt.GetColumn(Me.DetailGRVVt, "DVT")
        EditTon13.GetColumn(Me.DetailGRVVt, "Ton13")
        EditMa_kho_i.GetColumn(Me.DetailGRVVt, "Ma_kho_I")
        EditTen_kho_i.GetColumn(Me.DetailGRVVt, "Ten_kho_I")
        EditMa_TT.GetColumn(Me.DetailGRVVt, "Ma_TT")

        Editma_KTV_I.GetColumn(DetailGRVVt, "Ma_KTV_I")
        EditMa_Vv_i.GetColumn(DetailGRVVt, "Ma_Vv_I")
        EditMa_phi_I.GetColumn(DetailGRVVt, "Ma_Phi_I")
        EditMa_Hd_i.GetColumn(DetailGRVVt, "Ma_HD_I")
        EditMa_Sp_i.GetColumn(DetailGRVVt, "Ma_SP_I")
        EditMa_ku_I.GetColumn(DetailGRVVt, "Ma_KU_I")
        EditMa_TTLN_I.GetColumn(DetailGRVVt, "Ma_TTLN_I")
        EditMa_TTCP_I.GetColumn(DetailGRVVt, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRVVt, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRVVt, "Ma_Hs_I")
        EditMa_CD_I.GetColumn(DetailGRVVt, "Ma_CD_I")

        EditMa_TD1_i.GetColumn(DetailGRVVt, "Ma_TD1_I")
        EditMa_TD2_i.GetColumn(DetailGRVVt, "Ma_TD2_I")
        EditMa_TD3_i.GetColumn(DetailGRVVt, "Ma_TD3_I")
        EditMa_TD4_i.GetColumn(DetailGRVVt, "Ma_TD4_I")
        EditMa_TD5_i.GetColumn(DetailGRVVt, "Ma_TD5_I")

        EditSo_Luong.GetColumn(Me.DetailGRVVt, "So_luong")
        EditGia2.GetColumn(Me.DetailGRVVt, "Gia2")
        EditGia_TK.GetColumn(Me.DetailGRVVt, "Gia_Tk")

        EditTien2.GetColumn(Me.DetailGRVVt, "Tien2")
        EditTien0.GetColumn(Me.DetailGRVVt, "Tien0")
        EditCk_i.GetColumn(Me.DetailGRVVt, "Ck_i")
        EditPt_Ck_i.GetColumn(Me.DetailGRVVt, "Pt_Ck_i")

        '---Dieu chinh
        EditDC_I.GetColumn(Me.DetailGRVVt, "Dc_i")
        EditPT_DC_I.GetColumn(Me.DetailGRVVt, "Pt_Dc_i")

        EditThue_Suat.GetColumn(Me.DetailGRVVt, "Thue_Suat")
        EditThue.GetColumn(Me.DetailGRVVt, "Thue")
        EditSua_Thue.GetColumn(Me.DetailGRVVt, "Sua_Thue")

        EditThue_BH.GetColumn(Me.DetailGRVVt, "Thue_BH")
        EditTien_BH.GetColumn(Me.DetailGRVVt, "Tien_BH")

        EditSl_TD_I.GetColumn(Me.DetailGRVVt, "Sl_TD_I")
        EditLAN.GetColumn(Me.DetailGRVVt, "Lan")
        '---------------------------------------------------------------------------------
        EditMa_CVCv.GetColumn(Me.DetailGRVCv, "Ma_CV")
        EditTen_CVCv.GetColumn(Me.DetailGRVCv, "Ten_Cv")
        EditTIEN_CV0Cv.GetColumn(Me.DetailGRVCv, "Ten_Cv0")

        EditTen_CV3Cv.GetColumn(Me.DetailGRVCv, "Ten_Cv3")
        EditMa_TTCv.GetColumn(Me.DetailGRVCv, "Ma_TT")
        EditMa_CtcvCv.GetColumn(Me.DetailGRVCv, "Ma_Ctcv")

        EditGia_CVCV.GetColumn(Me.DetailGRVCv, "Gia_CV")
        EditGio_TCCV.GetColumn(Me.DetailGRVCv, "Gio_TC")
        EditTien_CVCv.GetColumn(Me.DetailGRVCv, "Tien_CV")

        EditPT_Ck_ICv.GetColumn(Me.DetailGRVCv, "PT_Ck_I")
        EditCk_ICv.GetColumn(Me.DetailGRVCv, "Ck_I")
        EditThueCV.GetColumn(Me.DetailGRVCv, "Thue")

        '---Dieu chinh
        EditDC_ICV.GetColumn(Me.DetailGRVCv, "Dc_i")
        EditPT_DC_ICV.GetColumn(Me.DetailGRVCv, "Pt_Dc_i")

        EditThue_SuatCv.GetColumn(Me.DetailGRVCv, "Thue_Suat")
        EditSua_ThueCV.GetColumn(Me.DetailGRVCv, "Sua_Thue")
        EditThue_BHCv.GetColumn(Me.DetailGRVCv, "Thue_BH")
        EditTien_BHCv.GetColumn(Me.DetailGRVCv, "Tien_BH")

        EditLANCv.GetColumn(Me.DetailGRVCv, "LAN")

        Editma_KTV_ICV.GetColumn(DetailGRVCv, "Ma_KTV_I")
        EditMa_Vv_iCV.GetColumn(DetailGRVCv, "Ma_Vv_I")
        EditMa_phi_iCV.GetColumn(DetailGRVCv, "Ma_Phi_I")
        EditMa_Hd_iCV.GetColumn(DetailGRVCv, "Ma_HD_I")
        EditMa_Sp_iCV.GetColumn(DetailGRVCv, "Ma_SP_I")
        EditMa_ku_iCV.GetColumn(DetailGRVCv, "Ma_KU_I")
        EditMa_TTLN_iCV.GetColumn(DetailGRVCv, "Ma_TTLN_I")
        EditMa_TTCP_iCV.GetColumn(DetailGRVCv, "Ma_TTCP_I")
        EditMa_BP_iCV.GetColumn(DetailGRVCv, "Ma_BP_I")
        EditMa_HS_iCV.GetColumn(DetailGRVCv, "Ma_Hs_I")
        EditMa_CD_iCV.GetColumn(DetailGRVCv, "Ma_CD_I")

        EditMa_TD1_iCV.GetColumn(DetailGRVCv, "Ma_TD1_I")
        EditMa_TD2_iCV.GetColumn(DetailGRVCv, "Ma_TD2_I")
        EditMa_TD3_iCV.GetColumn(DetailGRVCv, "Ma_TD3_I")
        EditMa_TD4_iCV.GetColumn(DetailGRVCv, "Ma_TD4_I")
        EditMa_TD5_iCV.GetColumn(DetailGRVCv, "Ma_TD5_I")

        EditMa_Ktv_SVT.GetColumn(Me.DetailGRVVt, "Ma_KTV_S")
        EditMa_Ktv_SCV.GetColumn(Me.DetailGRVCv, "Ma_KTV_S")

    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        TxtMa_Xe.Select()
        If _Loai = "L" Then CmdPrint.Select()


        'Select Case _Loai
        '    Case "M"
        '        If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Kh.Focus()
        '    Case "S"
        '        'If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else txtOng_ba.Focus()
        '    Case "L"
        '        CmdPrint.Select()
        'End Select
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
        AddHandler DetailGRVVt.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRVVt.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        AddHandler DetailGRVCv.PopupMenuShowing, AddressOf MasterGRVCv_PopupMenuShowing
        AddHandler DetailGRVCv.KeyDown, AddressOf MasterGRVCv_KeyDown
        '---
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
        '------------------------------------
        AddHandler CmdXem_Giao_Xe.Click, AddressOf V_Xem_Giao_Xe
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_Ct.Enter, AddressOf V_Ngay_Ct
        AddHandler txtSo_ct.GotFocus, AddressOf V_So_Ct
        AddHandler TxtTy_Gia.Enter, AddressOf E_Ty_GIa
        AddHandler TxtTy_Gia.Leave, AddressOf V_Ty_GIa
        '----------------------------------------------------------------------------------------------------------
        '--Ma_HD
        AddHandler TxtMa_HD_H.CyberValiting, AddressOf V_Ma_HD_H
        AddHandler TxtMa_HD_H.CyberLeave, AddressOf L_Ma_HD_H
        '--Ma_td3_H
        AddHandler TxtMa_td3_H.CyberValiting, AddressOf V_ma_td3_H
        AddHandler TxtMa_td3_H.CyberLeave, AddressOf L_ma_td3_H

        '--Ma_Hs
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_HS_H

        '--Ma_BP
        AddHandler TxtMa_Bp_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_Bp_H.CyberLeave, AddressOf L_Ma_BP_H
        '----------------------------------------------------------------------------------------------------------
        '--Ma_SC
        AddHandler TxtMa_SC.CyberValiting, AddressOf V_Ma_Sc
        AddHandler TxtMa_SC.CyberLeave, AddressOf L_Ma_Sc

        '--KX
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        '--Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        '--Sk
        AddHandler TxtMa_ChienDich.CyberValiting, AddressOf V_Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberLeave, AddressOf L_Ma_ChienDich
        '--Sk
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_Bh
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_Bh
        '--LhSc
        AddHandler TxtMa_LHSC.CyberValiting, AddressOf V_Ma_LhSC
        AddHandler TxtMa_LHSC.CyberLeave, AddressOf L_Ma_LhSC
        '--LhKh
        AddHandler TxtMa_LHKH.CyberValiting, AddressOf V_Ma_LhKh
        AddHandler TxtMa_LHKH.CyberLeave, AddressOf L_Ma_LhKh
        '---The Vip
        AddHandler TxtThe_Vip.CyberValiting, AddressOf V_The_Vip
        AddHandler TxtThe_Vip.CyberLeave, AddressOf L_The_Vip
        '-- Ma_xe
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click
        AddHandler TxtSo_khung.Leave, AddressOf V_So_khung
        AddHandler TxtSo_May.Leave, AddressOf V_So_May
        '----------------------------------------------------------------------------------------------------------
        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtDien_Thoai.Leave, AddressOf V_Dien_Thoai
        AddHandler TxtFax.Leave, AddressOf V_Fax
        AddHandler TxtTen_kh.Leave, AddressOf V_Ten_kh
        AddHandler TxtDia_Chi.Leave, AddressOf V_Dia_Chi
        AddHandler TxtTen_khVAT.Leave, AddressOf V_Ten_khVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf V_Dia_ChiVat
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtGio_NT.Leave, AddressOf V_Gio_NT
        AddHandler TxtGio_BD.Leave, AddressOf V_Gio_BD
        AddHandler TxtGio_KT.Leave, AddressOf V_Gio_KT
        AddHandler TxtGio_HenKT.Leave, AddressOf V_Gio_HenKT
        '----------------------------------------------------------------------------------------------------------
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------------
        'AddHandler ChkBSCC.CheckedChanged, AddressOf V_Chk_SSC
        'AddHandler ChkBDS.CheckedChanged, AddressOf V_Chk_DS

        AddHandler ChkCV.CheckedChanged, AddressOf V_Chk_CV
        AddHandler ChkVT.CheckedChanged, AddressOf V_Chk_VT
        AddHandler ChkBH.CheckedChanged, AddressOf V_Chk_BH
        ' AddHandler ChkIs_Hen.CheckedChanged, AddressOf V_Is_Hen
        '----------------------------------------------------------------------------------------------------------
        '-- Begin Edit 2019.07.07
        AddHandler TxtT_N.Leave, AddressOf V_T_CK_NB
        AddHandler ChkNB.CheckedChanged, AddressOf V_Chk_NB

        AddHandler TxtT_W.Leave, AddressOf V_T_CK_WH
        AddHandler ChkWH.CheckedChanged, AddressOf V_Chk_WH

        '-- End Edit 2019.07.07
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtT_CK_CV.Leave, AddressOf V_T_CK_CV
        AddHandler TxtT_CK_VT.Leave, AddressOf V_T_CK_VT

        AddHandler TxtT_I.Leave, AddressOf V_T_CK_BH
        AddHandler TxtDT_GDV.Leave, AddressOf V_DT_GDV
        AddHandler TxtDT_MG.Leave, AddressOf V_DT_MG
        '----------------------------------------------------------------------------------------------------------
        '-- Option
        AddHandler CmdDanh_Sach_Goi.Click, AddressOf V_Danh_sach_Goi
        '-- Option
        AddHandler CmdXemPhieuXuat.Click, AddressOf V_XemPhieuXuat
        AddHandler CmdXemXechosuachua.Click, AddressOf V_XemChosuahua
        AddHandler CmdXemXesuachuaXong.Click, AddressOf V_Xemsuahuaxong
        AddHandler CmdDSLich_Hen.Click, AddressOf V_Ds_Dat_Lich
        AddHandler CmdDat_Lich.Click, AddressOf V_Dat_Lich

        AddHandler CmdLich_Su.Click, AddressOf V_Lich_Su
        AddHandler CmdNghiem_Thu.Click, AddressOf V_Nghiemthu
        '----------------------------------------------------------------------------------------------------------
        'Add On 2017.11.03
        AddHandler EditMa_Ktv_SVT.EditColumn.Click, AddressOf V_Ma_KTV_SVT
        AddHandler EditMa_Ktv_SCV.EditColumn.Click, AddressOf V_Ma_KTV_SCV
        AddHandler CmdUpdateRo_hang.Click, AddressOf V_UpdateRoHang
        '----------------------------------------------------------------------------------------------------------
        'Add On 2019.04.212
        AddHandler CmdToa_Dieu_Chuyen.Click, AddressOf V_Tao_Dieu_Chuyen
        AddHandler CmbTra_cuu.Click, AddressOf V_Tra_Cuu
    End Sub
    Private Sub V_AddHandler_Detail()
        EditTen_Vt.ColumnReadOnly = True
        EditDVt.ColumnReadOnly = True
        EditTon13.ColumnReadOnly = True
        EditGia_TK.ColumnReadOnly = True
        EditTen_kho_i.ColumnReadOnly = True
        EditLAN.ColumnReadOnly = True

        If Not EditTen_Vt3.Column Is Nothing Then AddHandler EditTen_Vt3.EditColumn.Leave, AddressOf V_Ten_Vt3

        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditTien2.Column Is Nothing Then AddHandler EditTien2.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditTien0.Column Is Nothing Then AddHandler EditTien0.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditPt_Ck_i.Column Is Nothing Then AddHandler EditPt_Ck_i.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditCk_i.Column Is Nothing Then AddHandler EditCk_i.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        '---Dieu chinh
        If Not EditPT_DC_I.Column Is Nothing Then AddHandler EditPT_DC_I.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditDC_I.Column Is Nothing Then AddHandler EditDC_I.EditColumn.Leave, AddressOf V_Tinh_ToanPT

        If Not EditThue_Suat.Column Is Nothing Then AddHandler EditThue_Suat.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditSua_Thue.Column Is Nothing Then AddHandler EditSua_Thue.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditThue.Column Is Nothing Then AddHandler EditThue.EditColumn.Leave, AddressOf V_Tinh_ToanPT


        If Not EditThue_BH.Column Is Nothing Then AddHandler EditThue_BH.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditTien_BH.Column Is Nothing Then AddHandler EditTien_BH.EditColumn.Leave, AddressOf V_Tinh_ToanPT

        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        EditMa_NVKD.V_ActiLookUpColumn(AddressOf V_Ma_NVKD, AddressOf L_Ma_NVKD)
        EditMa_Vt.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        EditMa_kh_I.V_ActiLookUpColumn(AddressOf V_Ma_kh_i, AddressOf L_Ma_kh_i)

        EditMa_CVVt.V_ActiLookUpColumn(AddressOf V_Ma_CvVt, AddressOf L_Ma_CvVt)
        EditMa_CtCVVT.V_ActiLookUpColumn(AddressOf V_Ma_CtCvVT, AddressOf L_Ma_CtCvVT)
        EditMa_TT.V_ActiLookUpColumn(AddressOf V_Ma_TT, AddressOf L_Ma_TT)

        EditMa_kho_i.V_ActiLookUpColumn(AddressOf V_Ma_Kho_I, AddressOf L_Ma_Kho_I)



        '---Add On
        Editma_KTV_I.V_ActiLookUpColumn(AddressOf V_Ma_KTV_I, AddressOf L_Ma_KTV_I)
        EditMa_Vv_i.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_phi_I.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_Hd_i.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_Sp_i.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_ku_I.V_ActiLookUpColumn(AddressOf V_Ma_KU_i, AddressOf L_Ma_KU_i)
        EditMa_TTLN_I.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_I.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_i.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_i.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_i.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_i.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_i.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)

        '================== Coong viec
        EditTen_CVCv.ColumnReadOnly = True
        EditLANCv.ColumnReadOnly = True

        If Not EditGia_CVCV.Column Is Nothing Then AddHandler EditGia_CVCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditGio_TCCV.Column Is Nothing Then AddHandler EditGio_TCCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_CVCv.Column Is Nothing Then AddHandler EditTien_CVCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTIEN_CV0Cv.Column Is Nothing Then AddHandler EditTIEN_CV0Cv.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPT_Ck_ICv.Column Is Nothing Then AddHandler EditPT_Ck_ICv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditCk_ICv.Column Is Nothing Then AddHandler EditCk_ICv.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        '---Dieu chinh
        If Not EditPT_DC_ICV.Column Is Nothing Then AddHandler EditPT_DC_ICV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditDC_ICV.Column Is Nothing Then AddHandler EditDC_ICV.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditThue_SuatCv.Column Is Nothing Then AddHandler EditThue_SuatCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditSua_ThueCV.Column Is Nothing Then AddHandler EditSua_ThueCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditThueCV.Column Is Nothing Then AddHandler EditThueCV.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditThue_BHCv.Column Is Nothing Then AddHandler EditThue_BHCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_BHCv.Column Is Nothing Then AddHandler EditThue_BHCv.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPT_Ck_ICv.Column Is Nothing Then AddHandler EditPT_Ck_ICv.EditColumn.Enter, AddressOf E_CK_CV

        If Not EditCk_ICv.Column Is Nothing Then AddHandler EditCk_ICv.EditColumn.Enter, AddressOf E_CK_CV
        If Not EditPt_Ck_i.Column Is Nothing Then AddHandler EditPt_Ck_i.EditColumn.Enter, AddressOf E_CK_VT
        If Not EditCk_i.Column Is Nothing Then AddHandler EditCk_i.EditColumn.Enter, AddressOf E_CK_VT

        EditMa_CVCv.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        EditMa_CtcvCv.V_ActiLookUpColumn(AddressOf V_Ma_CtCv, AddressOf L_Ma_CtCv)
        EditMa_TTCv.V_ActiLookUpColumn(AddressOf V_Ma_TTCV, AddressOf L_Ma_TTCV)

        Editma_KTV_ICV.V_ActiLookUpColumn(AddressOf V_Ma_KTV_ICV, AddressOf L_Ma_KTV_ICV)
        EditMa_Vv_iCV.V_ActiLookUpColumn(AddressOf V_Ma_Vv_iCV, AddressOf L_Ma_Vv_iCV)
        EditMa_phi_iCV.V_ActiLookUpColumn(AddressOf V_Ma_Phi_iCV, AddressOf L_Ma_Phi_iCV)
        EditMa_Hd_iCV.V_ActiLookUpColumn(AddressOf V_Ma_HD_iCV, AddressOf L_Ma_HD_iCV)
        EditMa_Sp_iCV.V_ActiLookUpColumn(AddressOf V_Ma_SP_iCV, AddressOf L_Ma_SP_iCV)
        EditMa_ku_iCV.V_ActiLookUpColumn(AddressOf V_Ma_KU_iCV, AddressOf L_Ma_KU_iCV)
        EditMa_TTLN_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_iCV, AddressOf L_Ma_TTLN_iCV)
        EditMa_TTCP_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_iCV, AddressOf L_Ma_TTCP_iCV)
        EditMa_BP_iCV.V_ActiLookUpColumn(AddressOf V_Ma_Bp_iCV, AddressOf L_Ma_Bp_iCV)
        EditMa_HS_iCV.V_ActiLookUpColumn(AddressOf V_Ma_HS_iCV, AddressOf L_Ma_HS_iCV)
        EditMa_CD_iCV.V_ActiLookUpColumn(AddressOf V_Ma_CD_iCV, AddressOf L_Ma_CD_iCV)
        EditMa_TD1_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TD1_iCV, AddressOf L_Ma_TD1_iCV)
        EditMa_TD2_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TD2_iCV, AddressOf L_Ma_TD2_iCV)
        EditMa_TD3_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TD3_iCV, AddressOf L_Ma_TD3_iCV)
        EditMa_TD4_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TD4_iCV, AddressOf L_Ma_TD4_iCV)
        EditMa_TD5_iCV.V_ActiLookUpColumn(AddressOf V_Ma_TD5_iCV, AddressOf L_Ma_TD5_iCV)

        '-------------------------------------------------------------------
        AddHandler DetailGRVVt.RowCellStyle, AddressOf DetailGRVVT_RowCellStyle
        AddHandler DetailGRVCv.RowCellStyle, AddressOf DetailGRVCV_RowCellStyle

        '-------------------------------------------------------------------
        AddHandler TxtPT_Moi_Gioi.Leave, AddressOf V_PT_Moi_Gioi
        AddHandler TxtMoi_Gioi.Leave, AddressOf V_PT_Moi_Gioi

        AddHandler TxtPT_HH_BH.Leave, AddressOf V_PT_HH_BH
        AddHandler TxtHH_BH.Leave, AddressOf V_PT_HH_BH

        AddHandler TxtPT_Dat_Coc.Leave, AddressOf V_PT_Dat_Coc
        AddHandler TxtDat_Coc.Leave, AddressOf V_PT_Dat_Coc

    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRVVT_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVVt, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVCV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVCv, Dt_DetailCvTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub VisibleColumnMa_GD()

    End Sub
    Private Sub VisibleColumnMa_NT()
        'If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
        '    EditTien.Visible = False
        '    EditGia.Visible = False
        'Else
        '    EditTien.Visible = True
        '    EditGia.Visible = True
        'End If
        CyberFill.SetFoCusGRV(DetailGRVVt, M_Mode)
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
        '-----------------------------------------------------------------------------------------------
        CyberSmodb.SetValueTObj(Me, Drv)
        '-----------------------------------------------------------------------------------------------
        CyberSmodb.V_SetDatabing(Me, AppConn, M_Ma_CT, M_Stt_Rec, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib)
        '-----------------------------------------------------------------------------------------------
        If Drv Is Nothing Then
            TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CbbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        '-----------------------------------------------------------------------------------------------
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '-----------------------------------------------------------------------------------------------
        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()
        For i = 0 To Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailCvTmp.ImportRow(Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '-----------------------------------------------------------------------------------------------
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        M_Count = Dt_DetailTmp.Rows.Count
        UpdateList()
        'V_GetAndSetChkbSCC_DS_ALL("0")
        '-----------------------------------------------------------------------------------------------
        V_Diem_Tich_Luy()
        '-----------------------------------------------------------------------------------------------
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
        If Not Drv Is Nothing Then V_SelectTP_Quan_Xa(Drv.Item("Ma_TP"), Drv.Item("Ma_Quan"), Drv.Item("Ma_Xa"))
        '-----------------------------------------------------------------------------------------------
        V_SetDatabingMa_KTV()
        '-----------------------------------------------------------------------------------------------
        V_LoadPTTheoHD("0")
        '-----------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_ShortRefresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Mode = "X" Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        'If Me.CmdPrint.Enabled Then V_Print(sender, e)
        Dim M_strFilter As String = "1###" & M_Stt_Rec & "#19000101#19000101#0#9#" & M_Ma_CT.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name
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
        CyberSupport.V_DeleteTableVoucher(Dt_DetailCv, M_Stt_Rec)

        For iRow As Integer = 0 To DsTempRefresh.Tables(0).Rows.Count - 1
            Dt_Detail.ImportRow(DsTempRefresh.Tables(0).Rows(iRow))
        Next

        For iRow As Integer = 0 To DsTempRefresh.Tables(2).Rows.Count - 1
            Dt_DetailCv.ImportRow(DsTempRefresh.Tables(2).Rows(iRow))
        Next

        V_Databing()
        DsTempRefresh.Dispose()
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

            DetailGRVVt.OptionsBehavior.ReadOnly = False
            DetailGRVCv.OptionsBehavior.ReadOnly = False

            DetailGRVVt.OptionsBehavior.Editable = True
            DetailGRVCv.OptionsBehavior.Editable = True

            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then txtSo_ct.ReadOnly = True Else txtSo_ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRVVt.OptionsBehavior.ReadOnly = True
            DetailGRVCv.OptionsBehavior.ReadOnly = True

            DetailGRVVt.OptionsBehavior.Editable = False
            DetailGRVCv.OptionsBehavior.Editable = False

        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRVVt, M_Mode)
        CyberFill.SetFoCusGRV(DetailGRVCv, M_Mode)
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
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
    End Sub
#End Region
#Region "Valid - Master"
#Region "Valid --- Ma_HD_H/Ma_Bp_H/Ma_HS_H"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Bp_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
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
        TxtMa_Hs_H.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            TxtMa_Bp_H.Text = ""
            TxtTen_Bp_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_HS")
            TxtMa_Bp_H.Text = DrReturn.Item("Ma_Bp")
            If TxtMa_Bp_H.Text <> "" Then TxtTen_Bp_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Bp", "DmBp", "Ma_Bp = N'" + TxtMa_Bp_H.Text.Trim + "'", CyberSmlib)
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
            TxtMa_Bp_H.Text = ""
            TxtTen_Bp_H.Text = ""
        End If
    End Sub
    Private Sub ChkIs_PK_BB_KM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkIs_PK_BB_KM.CheckedChanged
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_LoadPTTheoHD("0")
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
            TxtTen_Hd_H.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD_H.Text = ""
            TxtTen_Hd_H.Text = ""
        End If
        V_LoadPTTheoHD("0")

    End Sub
    Private Sub V_ma_td3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "ma_td3", "Dmtd3", "1=1", "1=1")
    End Sub
    Private Sub L_ma_td3_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_td3_H.Text = DrReturn.Item("ma_td3")
            TxtTen_Hd_H.Text = DrReturn.Item("Ten_td3")
            TxtMa_HD_H.Text = DrReturn.Item("Ma_Hd")
        Else
            TxtMa_td3_H.Text = ""
            TxtTen_Hd_H.Text = ""
            TxtMa_HD_H.Text = ""
        End If
        V_LoadPTTheoHD("1")
        If Not TxtMa_td3_H.Text = "" Then L_HDMGetThongTinHDX()
    End Sub
#End Region
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#Region "Danh sách gói sửa chữa"
    Private Sub V_Danh_sach_Goi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(AppConn, osysvar, M_Para, "CP_GetListSelect", "DmSC#" & TxtMa_SC.Text.Trim & "#" & M_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        V_UPDATE_GOISCs(str)
    End Sub
    Private Sub V_UPDATE_GOISCs(ByVal _ma_Sc As String)
        Dim nCountCV As Integer = 0, nCountVt As Integer = 0
        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            If Dt_DetailCvTmp.Rows(i).Item("Ma_Cv").ToString.Trim <> "" Then nCountCV = nCountCV + 1
        Next

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_VT").ToString.Trim <> "" Then nCountVt = nCountVt + 1
        Next
        If nCountCV + nCountVt <> 0 Then Exit Sub
        If _ma_Sc.Trim = "" Then Exit Sub

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROUpdateMa_SCs", TxtMa_Kx.Text.Trim & "#" & TxtMa_Xe.Text & "#" & _Ma_GD & "#" & _Ma_Post & "#" & _ma_Sc & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), SysVar, M_LAN) Or DsTmp.Tables.Count < 3 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dt_DetailTmp.Clear()
        Dt_DetailCvTmp.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailCvTmp)
        CyberSmodb.SQLTbToTb(DsTmp.Tables(2), Dt_DetailTmp)
        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Tinh_TienCV(i)
        Next

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            Tinh_TienPT(i)
        Next
        UpdateList()
        DsTmp.Dispose()

    End Sub
#End Region
#Region "Valid --- Ma_Sc"
    Private Sub V_Ma_Sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Sc", "DmSc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtMa_SC.Text = DrReturn.Item("Ma_Sc") Else TxtMa_SC.Text = ""
        If TxtMa_SC.Text.Trim <> "" Then V_UPDATE_GOISC()
    End Sub
    Private Sub V_UPDATE_GOISC()
        Dim nCountCV As Integer = 0, nCountVt As Integer = 0
        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            If Dt_DetailCvTmp.Rows(i).Item("Ma_Cv").ToString.Trim <> "" Then nCountCV = nCountCV + 1
        Next

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_VT").ToString.Trim <> "" Then nCountVt = nCountVt + 1
        Next
        If nCountCV + nCountVt <> 0 Then Exit Sub

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROUpdateMa_SC", TxtMa_Kx.Text.Trim & "#" & TxtMa_Xe.Text & "#" & _Ma_GD & "#" & _Ma_Post & "#" & TxtMa_SC.Text.Trim & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), SysVar, M_LAN) Or DsTmp.Tables.Count < 3 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dt_DetailTmp.Clear()
        Dt_DetailCvTmp.Clear()
        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailCvTmp)
        CyberSmodb.SQLTbToTb(DsTmp.Tables(2), Dt_DetailTmp)
        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Tinh_TienCV(i)
        Next

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            Tinh_TienPT(i)
        Next
        UpdateList()
        DsTmp.Dispose()
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_kX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_KX")
            TxtTen_Kx.Text = DrReturn.Item("Ten_KX")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_mau", "DMmauxe", "1=1", "1=1")
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
#Region "Valid --- Ma_ChienDich"
    Private Sub V_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_ChienDich", "DmChienDich", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ChienDich.Text = DrReturn.Item("Ma_ChienDich")
            TxtTen_ChienDich.Text = DrReturn.Item("Ten_ChienDich")
        Else
            TxtMa_ChienDich.Text = ""
            TxtTen_ChienDich.Text = ""
        End If
    End Sub
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
            Txtten_BH.Text = DrReturn.Item("Ten_Bh")
        Else
            TxtMa_BH.Text = ""
            Txtten_BH.Text = ""
        End If
    End Sub

#End Region
#Region "Valid --- Ma_LhSC"
    Private Sub V_Ma_LhSC(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Lhsc", "DmLhSc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LhSC(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHSC.Text = DrReturn.Item("Ma_Lhsc")
            TxtTen_LHSC.Text = DrReturn.Item("Ten_Lhsc")
        Else
            TxtMa_LHSC.Text = ""
            TxtTen_LHSC.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_LhKh"
    Private Sub V_Ma_LhKh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_LhKh", "DmLhKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LhKh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHKH.Text = DrReturn.Item("Ma_LhKh")
            TxtTen_LHKH.Text = DrReturn.Item("Ten_LhKh")
        Else
            TxtMa_LHKH.Text = ""
            TxtTen_LHKH.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- The Vip"
    Private Sub V_The_Vip(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _ma_Xe As String = TxtMa_Xe.Text.Trim
        Dim _Key As String = "1=1"
        If _ma_Xe.Trim <> "" Then _Key = "Ma_Xe = '" + _ma_Xe.Trim + "'"
        'sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_The", "DmTheVip", "1=1", "1=1")
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_The", "DmTheVip", "1=1", _Key)
    End Sub
    Private Sub L_The_Vip(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtThe_Vip.Text = DrReturn.Item("Ma_The")
        Else
            TxtThe_Vip.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Xe/So_khung"
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
        If Dr.Item("Ma_Xe").ToString.Trim = TxtMa_Xe.Text.Trim Then V_Fill_TT(Dr, "1")
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, M_Para, osysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim)
        If Dr Is Nothing Then Exit Sub
        V_Fill_TT(Dr, "1")
        '----------------------------------------------------------------------------------------------
        V_Diem_Tich_Luy()
        '----------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_So_khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not (M_Mode = "M") Then Exit Sub
        If TxtSo_khung.Text.Trim = "" Then Exit Sub
        Dim Dt As Date = TxtNgay_Ct.Value
        Dim DsSo_Khung As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SOHDKGetSo_Khung", TxtSo_khung.Text + "#" + _
        Dt.ToString("yyyyMMdd") + "#" + M_Stt_Rec.Trim + "#" + M_Ma_CT + "#" + CbbMa_Post.SelectedValue.ToString.Trim + "#" + M_Mode + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)
        If DsSo_Khung.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            DsSo_Khung.Dispose()
            Exit Sub
        End If
        If DsSo_Khung.Tables(1).Rows.Count < 1 Then
            DsSo_Khung.Dispose()
            Exit Sub
        End If
        V_Fill_TT(DsSo_Khung.Tables(1).Rows(0), "2")
        DsSo_Khung.Dispose()
    End Sub
    Private Sub V_So_May(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not (M_Mode = "M") Then Exit Sub
        If TxtSo_May.Text.Trim = "" Then Exit Sub
        Dim Dt As Date = TxtNgay_Ct.Value
        Dim DsSo_May As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SOHDKGetSo_May", TxtSo_May.Text + "#" + _
        Dt.ToString("yyyyMMdd") + "#" + M_Stt_Rec.Trim + "#" + M_Ma_CT + "#" + CbbMa_Post.SelectedValue.ToString.Trim + "#" + M_Mode + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)

        If DsSo_May.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            DsSo_May.Dispose()
            Exit Sub
        End If

        If DsSo_May.Tables(1).Rows.Count < 1 Then
            DsSo_May.Dispose()
            Exit Sub
        End If
        ' V_Fill_TT(DsSo_May.Tables(1).Rows(0), "3")
        DsSo_May.Dispose()
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

        If M_Mode = "M" And V_IsFieldExist("So_Km", Dr) And Is_Xe = "1" Then TxtSo_Km_Cu.Double = Dr.Item("So_Km")

        If V_IsFieldExist("E_Mail", Dr) Then If Not Dr.Item("E_mail").ToString.Trim = "" Then TxtE_mail.Text = Dr.Item("E_mail").ToString.Trim
        If V_IsFieldExist("Ma_Nthat", Dr) Then If Not Dr.Item("Ma_Nthat").ToString.Trim = "" Then TxtMa_nthat.Text = Dr.Item("Ma_Nthat").ToString.Trim

        If V_IsFieldExist("Ten_Kh", Dr) Then If Not Dr.Item("Ten_Kh").ToString.Trim = "" Then TxtTen_kh.Text = Dr.Item("Ten_Kh").ToString.Trim
        If V_IsFieldExist("Dia_Chi", Dr) Then If Not Dr.Item("Dia_Chi").ToString.Trim = "" Then TxtDia_Chi.Text = Dr.Item("Dia_Chi").ToString.Trim

        If V_IsFieldExist("Ten_KhVAT", Dr) Then If Not Dr.Item("Ten_KhVAT").ToString.Trim = "" Then TxtTen_khVAT.Text = Dr.Item("Ten_KhVAT").ToString.Trim
        If V_IsFieldExist("Dia_ChiVAT", Dr) Then If Not Dr.Item("Dia_ChiVAT").ToString.Trim = "" Then TxtDia_ChiVAT.Text = Dr.Item("Dia_ChiVAT").ToString.Trim
        If V_IsFieldExist("Ma_So_Thue", Dr) Then If Not Dr.Item("Ma_So_Thue").ToString.Trim = "" Then TxtMa_So_Thue.Text = Dr.Item("Ma_So_Thue").ToString.Trim
        If V_IsFieldExist("Ten_Lx", Dr) Then If Not Dr.Item("Ten_Lx").ToString.Trim = "" Then txtTen_Lx.Text = Dr.Item("Ten_Lx").ToString.Trim

        
        If V_IsFieldExist("Dien_Thoai", Dr) Then If Not Dr.Item("Dien_Thoai").ToString.Trim = "" Then TxtDien_Thoai.Text = Dr.Item("Dien_Thoai").ToString.Trim
        If V_IsFieldExist("Dt_LX", Dr) Then If Not Dr.Item("Dt_LX").ToString.Trim = "" Then TxtDt_LX.Text = Dr.Item("Dt_LX").ToString.Trim
        If V_IsFieldExist("Fax", Dr) Then If Not Dr.Item("Fax").ToString.Trim = "" Then TxtFax.Text = Dr.Item("Fax").ToString.Trim

        
        If V_IsFieldExist("Ma_hd_H", Dr) Then If Not Dr.Item("Ma_hd_H").ToString.Trim = "" Then TxtMa_HD_H.Text = Dr.Item("Ma_hd_H").ToString.Trim
        If V_IsFieldExist("Ma_Td3_H", Dr) Then If Not Dr.Item("Ma_Td3_H").ToString.Trim = "" Then TxtMa_td3_H.Text = Dr.Item("Ma_Td3_H").ToString.Trim


        If V_IsFieldExist("Xuat_Xu", Dr) Then If Not Dr.Item("Xuat_Xu").ToString.Trim = "" Then TxtXuat_Xu.Text = Dr.Item("Xuat_Xu").ToString.Trim
        If V_IsFieldExist("Dai_Ly", Dr) Then If Not Dr.Item("Dai_Ly").ToString.Trim = "" Then TxtDai_Ly.Text = Dr.Item("Dai_Ly").ToString.Trim

        If V_IsFieldExist("Nam_Sx", Dr) And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbNam_Sx, Dr.Item("Nam_Sx").ToString.Trim)
        If V_IsFieldExist("Ma_TP", Dr) Then If Not Dr.Item("Ma_TP").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_TP, Dr.Item("Ma_TP").ToString.Trim)
        If V_IsFieldExist("Ma_Quan", Dr) Then If Not Dr.Item("Ma_Quan").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_Quan, Dr.Item("Ma_Quan").ToString.Trim)
        If V_IsFieldExist("Ma_Xa", Dr) Then If Not Dr.Item("Ma_Xa").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_Xa, Dr.Item("Ma_Xa").ToString.Trim)

        If V_IsFieldExist("Vai_Tro", Dr) Then If Not Dr.Item("Vai_Tro").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbVai_Tro, Dr.Item("Vai_Tro").ToString.Trim)
        If V_IsFieldExist("Ma_HTLL", Dr) Then If Not Dr.Item("Ma_HTLL").ToString.Trim = "" And M_Mode = "M" Then CyberSmodb.SetValueFromCombox(CmbMa_HTLL, Dr.Item("Ma_HTLL").ToString.Trim)


        V_Fax(New System.Object, New System.EventArgs)
        V_Dien_Thoai(New System.Object, New System.EventArgs)
        V_Ten_kh(New System.Object, New System.EventArgs)
        V_Dia_Chi(New System.Object, New System.EventArgs)
        V_Ten_khVat(New System.Object, New System.EventArgs)
        V_Dia_ChiVat(New System.Object, New System.EventArgs)
    End Sub
    Private Function V_IsFieldExist(ByVal Field_Name As String, ByVal Dr As DataRow) As Boolean
        Dim _Return As Boolean = False
        If Dr Is Nothing Then Return False
        Field_Name = Field_Name.Trim
        If Dr.Table.Columns.Contains(Field_Name) Then _Return = True
        V_IsFieldExist = _Return
    End Function
#End Region
#Region "Khach hang"
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
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi").ToString.Trim, TxtDia_Chi.Text)
            TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim = "", DrReturn.Item("Ten_KHVat").ToString.Trim, TxtTen_khVAT.Text)
            TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim = "", DrReturn.Item("Dia_ChiVat").ToString.Trim, TxtDia_ChiVAT.Text)

            txtTen_Lx.Text = IIf(txtTen_Lx.Text.Trim = "", DrReturn.Item("Ong_ba").ToString.Trim, TxtTen_kh.Text)

            TxtDien_Thoai.Text = IIf(TxtDien_Thoai.Text.Trim = "", DrReturn.Item("Dien_Thoai").ToString.Trim, TxtDien_Thoai.Text)
            TxtDt_LX.Text = IIf(TxtDt_LX.Text.Trim = "", DrReturn.Item("Dien_Thoai").ToString.Trim, TxtDt_LX.Text)
            TxtFax.Text = IIf(TxtFax.Text.Trim = "", DrReturn.Item("Fax").ToString.Trim, TxtFax.Text)

            TxtE_mail.Text = IIf(TxtE_mail.Text.Trim = "", DrReturn.Item("E_Mail").ToString.Trim, TxtE_mail.Text)
            TxtMa_So_Thue.Text = IIf(TxtMa_So_Thue.Text.Trim = "", DrReturn.Item("Ma_So_Thue").ToString.Trim, TxtMa_So_Thue.Text)

            TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text = "", DrReturn("Ten_kh").ToString.Trim, TxtTen_khVAT.Text)
            TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text = "", DrReturn("Dia_Chi").ToString.Trim, TxtDia_ChiVAT.Text)
        Else
            TxtMa_Kh.Text = ""
            'TxtTen_kh.Text = ""
        End If
        'If TxtMa_Kh.Text = "" Then
        '    'TxtTen_kh.Text = ""
        '    'TxtDia_Chi.Text = ""
        '    'txtTen_Lx.Text = ""
        '    Exit Sub
        'End If
    End Sub
    Private Sub V_Fax(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'TxtFax.Text = SmlibLookup.dirlib.ClsVoucherRO.V_FormatDT(TxtFax.Text)
        If TxtDien_Thoai.Text = "" Then TxtDien_Thoai.Text = TxtFax.Text
        If TxtDt_LX.Text = "" Then TxtDt_LX.Text = TxtFax.Text
    End Sub
    Private Sub V_Dien_Thoai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        TxtDien_Thoai.Text = CyberVoucher.V_FormatDT(TxtDien_Thoai.Text)
        If TxtDt_LX.Text = "" Then TxtDt_LX.Text = TxtDien_Thoai.Text
        If TxtFax.Text = "" Then TxtFax.Text = TxtDien_Thoai.Text
    End Sub
    Private Sub V_Ten_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim <> "", TxtTen_khVAT.Text, TxtTen_kh.Text)
    End Sub
    Private Sub V_Dia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
    End Sub
    Private Sub V_Ten_khVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        TxtTen_kh.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, TxtTen_khVAT.Text)
    End Sub
    Private Sub V_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim <> "", TxtDia_Chi.Text, TxtDia_ChiVAT.Text)
    End Sub
#End Region
#Region "CheckBox"
    Private Sub V_T_CK_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim nCount As Integer = 0
        Dim nT_T_CV, nT_CK_CV As Decimal
        Dim i As Integer
        nT_T_CV = TxtT_CV.Double
        nT_CK_CV = TxtT_CK_CV.Double
        nCount = Dt_DetailCvTmp.Rows.Count
        '------------------------------------------------------------------------------
        '--- 1 KHong co noi dung cong viec sua chua
        If nCount <= 0 Then
            nT_CK_CV = 0
            TxtT_CK_CV.Double = nT_CK_CV
            TxtT_CK_CV.Refresh()
            UpdateList()
            Exit Sub
        End If
        '------------------------------------------------------------------------------
        '--- 2 Nhap vao chi tiet vao
        If Not ChkCV.Checked Then
            nT_CK_CV = 0
            For i = 0 To nCount - 1
                nT_CK_CV = nT_CK_CV + Dt_DetailCvTmp.Rows(i).Item("CK_I")
            Next
            TxtT_CK_CV.Double = nT_CK_CV
            TxtT_CK_CV.Refresh()
            UpdateList()
            Exit Sub
        End If
        '------------------------------------------------------------------------------
        '--- 3 Phan bo
        For i = 0 To nCount - 1
            Dt_DetailCvTmp.Rows(i).BeginEdit()
            Dt_DetailCvTmp.Rows(i).Item("PT_Ck_I") = 0
            Dt_DetailCvTmp.Rows(i).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges()
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "I,C", "Tien_Cv", "CK_I", nT_CK_CV, 0)
        ' Tinh lai thue
        For i = 0 To nCount - 1
            TinhThue_CV(i)
        Next
        '------------------------------------------------------------------------------
        UpdateList()
    End Sub
    Private Sub V_T_CK_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim nCount As Integer = 0
        Dim nT_T_VT, nT_CK_VT As Decimal
        Dim i As Integer

        nT_T_VT = TxtT_Tien2.Double
        nT_CK_VT = TxtT_CK_VT.Double
        nCount = Dt_DetailTmp.Rows.Count
        '------------------------------------------------------------------------------
        '--- 1 KHong co vat tu phu tung nao
        If nCount <= 0 Then
            nT_CK_VT = 0
            TxtT_CK_VT.Double = nT_CK_VT
            TxtT_CK_VT.Refresh()
            UpdateList()
            Exit Sub
        End If
        '------------------------------------------------------------------------------
        '--- 2 Nhap vao chi tiet vao
        If Not ChkVT.Checked Then
            nT_CK_VT = 0
            For i = 0 To nCount - 1
                nT_CK_VT = nT_CK_VT + Dt_DetailTmp.Rows(i).Item("CK_I")
            Next
            TxtT_CK_VT.Double = nT_CK_VT
            TxtT_CK_VT.Refresh()
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
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Tien2", "CK_I", nT_CK_VT, 0)
        ' Tinh thue Vat tu
        For i = 0 To nCount - 1
            TinhThue_VT(i)
        Next
        UpdateList()
    End Sub
    Private Sub V_T_CK_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim nCountCv, nCountVT As Integer
        Dim i As Integer
        nCountCv = Dt_DetailCvTmp.Rows.Count
        nCountVT = Dt_DetailTmp.Rows.Count

        If Not ChkBH.Checked Then
            For i = 0 To nCountCv - 1
                Dt_DetailCvTmp.Rows(i).BeginEdit()
                Dt_DetailCvTmp.Rows(i).Item("Thue_BH") = 0
                Dt_DetailCvTmp.Rows(i).Item("Tien_BH") = 0
                Dt_DetailCvTmp.Rows(i).EndEdit()
            Next
            Dt_DetailCvTmp.AcceptChanges()
            For i = 0 To nCountVT - 1
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
        '----Reset  I ===>C
        For i = 0 To nCountCv - 1
            Dt_DetailCvTmp.Rows(i).BeginEdit()
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailCvTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailCvTmp.Rows(i).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges() ' Tinh lai
        '----Reset  I ===>C
        V_T_CK_CV(sender, e)
        For i = 0 To nCountVT - 1
            Dt_DetailTmp.Rows(i).BeginEdit()
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailTmp.Rows(i).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------------
        V_T_CK_VT(sender, e) ' Tinh lai
        V_T_CK_CV(sender, e) ' Tinh lai
        '---------------------------------------------------------------------------------------

        Dim nT_Tien2 As Decimal = 0
        Dim nT_CV As Decimal = 0
        Dim nT_Thue_Cv As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_CK_CV As Decimal = 0
        Dim nT_CK_Vt As Decimal = 0

        Dim nT_Tien_BH As Decimal = 0
        Dim nT_Thue_BH As Decimal = 0

        Dim nT_Tien_BH_VT As Decimal = 0
        Dim nT_Tien_BH_CV As Decimal = 0
        Dim nT_Thue_BH_VT As Decimal = 0
        Dim nT_Thue_BH_CV As Decimal = 0

        For i = 0 To nCountCv - 1
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_CV = nT_CV + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") + Dt_DetailCvTmp.Rows(i).Item("DC_I")
                nT_Thue_Cv = nT_Thue_Cv + Dt_DetailCvTmp.Rows(i).Item("Thue")
                nT_CK_CV = nT_CK_CV + Dt_DetailCvTmp.Rows(i).Item("CK_I")
            End If
        Next
        For i = 0 To nCountVT - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_Tien2 = nT_Tien2 + Dt_DetailTmp.Rows(i).Item("Tien2") + Dt_DetailTmp.Rows(i).Item("DC_I")
                nT_Thue = nT_Thue + Dt_DetailTmp.Rows(i).Item("Thue")
                nT_CK_Vt = nT_CK_Vt + Dt_DetailTmp.Rows(i).Item("CK_I")
            End If
        Next
        '--------------------------------------------------------------------------------------------------------
        ' Tinh ra thue bao hiem va tien hang bao hiem phai tra
        If (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt) <> 0 Then
            nT_Thue_BH = CyberSupport.V_Round(TxtT_I.Double * (nT_Thue_Cv + nT_Thue) / (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt), 0)
        Else
            TxtT_I.Double = 0
            TxtT_I.Refresh()
            UpdateList()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------
        nT_Tien_BH = TxtT_I.Double - nT_Thue_BH
        ' Tinh thue cua cong viec, thue cua vat tu : Bao hiem phai tra
        If (nT_Thue_Cv + nT_Thue) <> 0 Then nT_Thue_BH_CV = CyberSupport.V_Round((nT_Thue_BH * nT_Thue_Cv) / (nT_Thue_Cv + nT_Thue), 0)
        nT_Thue_BH_VT = nT_Thue_BH - nT_Thue_BH_CV
        ' Tinh tien cua cong viec, tien cua vat tu : Bao hiem phai tra
        If (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt) <> 0 Then nT_Tien_BH_CV = CyberSupport.V_Round((nT_Tien_BH * (nT_CV - nT_CK_CV)) / (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt), 0)
        nT_Tien_BH_VT = nT_Tien_BH - nT_Tien_BH_CV
        ' Phan Bo tien cong viec cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "I,C", "Tien_CV0", "Tien_BH", nT_Tien_BH_CV, 0)
        ' PHan bo thue cong viec cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "I,C", "Thue", "Thue_BH", nT_Thue_BH_CV, 0)
        ' Phan Bo tien vat tu cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Tien0", "Tien_BH", nT_Tien_BH_VT, 0)
        ' PHan bo thue vat tu cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "I,C", "Thue", "Thue_BH", nT_Thue_BH_VT, 0)
        UpdateList()
    End Sub
    Private Sub V_T_CK_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim nCountCv, nCountVT As Integer
        Dim i As Integer
        nCountCv = Dt_DetailCvTmp.Rows.Count
        nCountVT = Dt_DetailTmp.Rows.Count

        If Not ChkNB.Checked Then
            For i = 0 To nCountCv - 1
                Dt_DetailCvTmp.Rows(i).BeginEdit()
                Dt_DetailCvTmp.Rows(i).Item("Thue_NB") = 0
                Dt_DetailCvTmp.Rows(i).Item("Tien_NB") = 0
                Dt_DetailCvTmp.Rows(i).EndEdit()
            Next
            Dt_DetailCvTmp.AcceptChanges()
            For i = 0 To nCountVT - 1
                Dt_DetailTmp.Rows(i).BeginEdit()
                Dt_DetailTmp.Rows(i).Item("Thue_NB") = 0
                Dt_DetailTmp.Rows(i).Item("Tien_NB") = 0
                Dt_DetailTmp.Rows(i).EndEdit()
            Next
            Dt_DetailTmp.AcceptChanges()
            UpdateList()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------
        '----Reset  N ===>C
        For i = 0 To nCountCv - 1
            Dt_DetailCvTmp.Rows(i).BeginEdit()
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "N" Or Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailCvTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailCvTmp.Rows(i).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges() ' Tinh lai
        '----Reset  N ===>C
        V_T_CK_CV(sender, e)
        For i = 0 To nCountVT - 1
            Dt_DetailTmp.Rows(i).BeginEdit()
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "N" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailTmp.Rows(i).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------------
        V_T_CK_VT(sender, e) ' Tinh lai
        V_T_CK_CV(sender, e) ' Tinh lai
        '---------------------------------------------------------------------------------------

        Dim nT_Tien2 As Decimal = 0
        Dim nT_CV As Decimal = 0
        Dim nT_Thue_Cv As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_CK_CV As Decimal = 0
        Dim nT_CK_Vt As Decimal = 0

        Dim nT_Tien_NB As Decimal = 0
        Dim nT_Thue_NB As Decimal = 0

        Dim nT_Tien_NB_VT As Decimal = 0
        Dim nT_Tien_NB_CV As Decimal = 0
        Dim nT_Thue_NB_VT As Decimal = 0
        Dim nT_Thue_NB_CV As Decimal = 0

        For i = 0 To nCountCv - 1
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_CV = nT_CV + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") + Dt_DetailCvTmp.Rows(i).Item("DC_I")
                nT_Thue_Cv = nT_Thue_Cv + Dt_DetailCvTmp.Rows(i).Item("Thue")
                nT_CK_CV = nT_CK_CV + Dt_DetailCvTmp.Rows(i).Item("CK_I")
            End If
        Next
        For i = 0 To nCountVT - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_Tien2 = nT_Tien2 + Dt_DetailTmp.Rows(i).Item("Tien2") + Dt_DetailTmp.Rows(i).Item("DC_I")
                nT_Thue = nT_Thue + Dt_DetailTmp.Rows(i).Item("Thue")
                nT_CK_Vt = nT_CK_Vt + Dt_DetailTmp.Rows(i).Item("CK_I")
            End If
        Next
        '--------------------------------------------------------------------------------------------------------
        ' Tinh ra thue Nội bộ va tien hang Nội bộ phai tra
        If (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt) <> 0 Then
            nT_Thue_NB = CyberSupport.V_Round(TxtT_N.Double * (nT_Thue_Cv + nT_Thue) / (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt), 0)
        Else
            TxtT_N.Double = 0
            TxtT_N.Refresh()
            UpdateList()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------
        nT_Tien_NB = TxtT_N.Double - nT_Thue_NB
        ' Tinh thue cua cong viec, thue cua vat tu : nội bộ phai tra
        If (nT_Thue_Cv + nT_Thue) <> 0 Then nT_Thue_NB_CV = CyberSupport.V_Round((nT_Thue_NB * nT_Thue_Cv) / (nT_Thue_Cv + nT_Thue), 0)
        nT_Thue_NB_VT = nT_Thue_NB - nT_Thue_NB_CV
        ' Tinh tien cua cong viec, tien cua vat tu : Nội bộ phai tra
        If (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt) <> 0 Then nT_Tien_NB_CV = CyberSupport.V_Round((nT_Tien_NB * (nT_CV - nT_CK_CV)) / (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt), 0)
        nT_Tien_NB_VT = nT_Tien_NB - nT_Tien_NB_CV

        ' Phan Bo tien cong viec cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "N,C", "Tien_CV0", "Tien_NB", nT_Tien_NB_CV, 0)
        ' PHan bo thue cong viec cho Nội bộ phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "N,C", "Thue", "Thue_NB", nT_Thue_NB_CV, 0)
        ' Phan Bo tien vat tu cho Nội bộ phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "N,C", "Tien0", "Tien_NB", nT_Tien_NB_VT, 0)
        ' PHan bo thue vat tu cho Nội bộ phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "N,C", "Thue", "Thue_NB", nT_Thue_NB_VT, 0)
        UpdateList()
    End Sub
    Private Sub V_T_CK_WH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim nCountCv, nCountVT As Integer
        Dim i As Integer
        nCountCv = Dt_DetailCvTmp.Rows.Count
        nCountVT = Dt_DetailTmp.Rows.Count

        If Not ChkWH.Checked Then
            For i = 0 To nCountCv - 1
                Dt_DetailCvTmp.Rows(i).BeginEdit()
                Dt_DetailCvTmp.Rows(i).Item("Thue_WH") = 0
                Dt_DetailCvTmp.Rows(i).Item("Tien_WH") = 0
                Dt_DetailCvTmp.Rows(i).EndEdit()
            Next
            Dt_DetailCvTmp.AcceptChanges()
            For i = 0 To nCountVT - 1
                Dt_DetailTmp.Rows(i).BeginEdit()
                Dt_DetailTmp.Rows(i).Item("Thue_WH") = 0
                Dt_DetailTmp.Rows(i).Item("Tien_WH") = 0
                Dt_DetailTmp.Rows(i).EndEdit()
            Next
            Dt_DetailTmp.AcceptChanges()
            UpdateList()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------
        '----Reset  W ===>C
        For i = 0 To nCountCv - 1
            Dt_DetailCvTmp.Rows(i).BeginEdit()
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Or Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailCvTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailCvTmp.Rows(i).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges() ' Tinh lai
        '----Reset  W ===>C
        V_T_CK_CV(sender, e)
        For i = 0 To nCountVT - 1
            Dt_DetailTmp.Rows(i).BeginEdit()
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "" Then
                Dt_DetailTmp.Rows(i).Item("Ma_TT") = "C"
            End If
            Dt_DetailTmp.Rows(i).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------------
        V_T_CK_VT(sender, e) ' Tinh lai
        V_T_CK_CV(sender, e) ' Tinh lai
        '---------------------------------------------------------------------------------------

        Dim nT_Tien2 As Decimal = 0
        Dim nT_CV As Decimal = 0
        Dim nT_Thue_Cv As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_CK_CV As Decimal = 0
        Dim nT_CK_Vt As Decimal = 0

        Dim nT_Tien_WH As Decimal = 0
        Dim nT_Thue_WH As Decimal = 0

        Dim nT_Tien_WH_VT As Decimal = 0
        Dim nT_Tien_WH_CV As Decimal = 0
        Dim nT_Thue_WH_VT As Decimal = 0
        Dim nT_Thue_WH_CV As Decimal = 0

        For i = 0 To nCountCv - 1
            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_CV = nT_CV + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") + Dt_DetailCvTmp.Rows(i).Item("DC_I")
                nT_Thue_Cv = nT_Thue_Cv + Dt_DetailCvTmp.Rows(i).Item("Thue")
                nT_CK_CV = nT_CK_CV + Dt_DetailCvTmp.Rows(i).Item("CK_I")
            End If
        Next
        For i = 0 To nCountVT - 1
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C" Then
                nT_Tien2 = nT_Tien2 + Dt_DetailTmp.Rows(i).Item("Tien2") + Dt_DetailTmp.Rows(i).Item("DC_I")
                nT_Thue = nT_Thue + Dt_DetailTmp.Rows(i).Item("Thue")
                nT_CK_Vt = nT_CK_Vt + Dt_DetailTmp.Rows(i).Item("CK_I")
            End If
        Next
        '--------------------------------------------------------------------------------------------------------
        ' Tinh ra thue Bảo hành va tien hang Bảo hành phai tra
        If (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt) <> 0 Then
            nT_Thue_WH = CyberSupport.V_Round(TxtT_W.Double * (nT_Thue_Cv + nT_Thue) / (nT_Tien2 + nT_CV + nT_Thue_Cv + nT_Thue - nT_CK_CV - nT_CK_Vt), 0)
        Else
            TxtT_W.Double = 0
            TxtT_W.Refresh()
            UpdateList()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------
        nT_Tien_WH = TxtT_W.Double - nT_Thue_WH
        ' Tinh thue cua cong viec, thue cua vat tu : Bảo hành phai tra
        If (nT_Thue_Cv + nT_Thue) <> 0 Then nT_Thue_WH_CV = CyberSupport.V_Round((nT_Thue_WH * nT_Thue_Cv) / (nT_Thue_Cv + nT_Thue), 0)
        nT_Thue_WH_VT = nT_Thue_WH - nT_Thue_WH_CV
        ' Tinh tien cua cong viec, tien cua vat tu : Bảo hành phai tra
        If (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt) <> 0 Then nT_Tien_WH_CV = CyberSupport.V_Round((nT_Tien_WH * (nT_CV - nT_CK_CV)) / (nT_Tien2 + nT_CV - nT_CK_CV - nT_CK_Vt), 0)
        nT_Tien_WH_VT = nT_Tien_WH - nT_Tien_WH_CV

        ' Phan Bo tien cong viec cho bao hiem phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "W,C", "Tien_CV0", "Tien_WH", nT_Tien_WH_CV, 0)
        ' PHan bo thue cong viec cho Bảo hành phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailCvTmp, "Ma_TT", "W,C", "Thue", "Thue_WH", nT_Thue_WH_CV, 0)
        ' Phan Bo tien vat tu cho Bảo hành phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "W,C", "Tien0", "Tien_WH", nT_Tien_WH_VT, 0)
        ' PHan bo thue vat tu cho Bảo hành phai tra
        CyberSupport.Phan_BoFieldKey(Dt_DetailTmp, "Ma_TT", "W,C", "Thue", "Thue_WH", nT_Thue_WH_VT, 0)
        UpdateList()
    End Sub
    Private Sub V_Chk_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkCV.Checked Then TxtT_CK_CV.ReadOnly = False Else TxtT_CK_CV.ReadOnly = True
        If ChkCV.Checked Then TxtT_CK_CV.Focus()
        V_T_CK_CV(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub V_Chk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkVT.Checked Then TxtT_CK_VT.ReadOnly = False Else TxtT_CK_VT.ReadOnly = True
        If ChkVT.Checked Then TxtT_CK_VT.Focus()
        V_T_CK_VT(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub V_Chk_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If ChkBH.Checked Then TxtT_I.ReadOnly = False Else TxtT_I.ReadOnly = True
        If ChkBH.Checked Then TxtT_I.Focus()
        V_T_CK_BH(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub V_Chk_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        If ChkNB.Checked Then TxtT_N.ReadOnly = False Else TxtT_N.ReadOnly = True
        If ChkNB.Checked Then TxtT_N.Focus()
        V_T_CK_NB(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub V_Chk_WH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        If ChkWH.Checked Then TxtT_W.ReadOnly = False Else TxtT_W.ReadOnly = True
        If ChkWH.Checked Then TxtT_W.Focus()
        V_T_CK_WH(sender, e)
        SetTxt()
        UpdateList()
    End Sub
    Private Sub E_CK_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If ChkCV.Checked Then SendKeys.Send("{Tab}")
    End Sub
    Private Sub E_CK_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If ChkVT.Checked Then SendKeys.Send("{Tab}")
    End Sub
#End Region
#Region "Giờ"
    Private Sub V_Gio_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_BD.Text = CyberVoucher.V_GetTG(TxtGio_BD.Text, 0)
    End Sub
    Private Sub V_Gio_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_KT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 0)
    End Sub
    Private Sub V_Gio_HenKT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_HenKT.Text = CyberVoucher.V_GetTG(TxtGio_HenKT.Text, 0)
    End Sub
    Private Sub V_Gio_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_NT.Text = CyberVoucher.V_GetTG(TxtGio_NT.Text, 0)
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
#Region "Option"
    Private Sub V_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _Date As Date = New Date(1900, 1, 1)
        Dim _Loai_SC As String = "1"
        If ChkSCC.Checked Then _Loai_SC = "1" Else If ChkSDS.Checked Then _Loai_SC = "2"
        Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP_H, "DLH", "M", "HEN", _Loai_SC, "", "", M_Ma_Hs, "", TxtMa_Xe.Text, "", "", _Date, _Date, AppConn, SysVar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Ds_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'V_Xem("LH", "")
        '@M_Load NVARCHAR(10) 
        ',@M_Kieu_Xem NVARCHAR(50) = N'TIEN_DO' ----HEN,TIEN_DO
        ',@M_Loai_SC NVARCHAR(1) = N'1'	
        ',@M_Stt_Rec NVARCHAR(30)
        ',@M_Ma_Xe NVARCHAR(30) 
        ',@M_Ma_Hs NVARCHAR(30) 
        ',@M_Ngay_CT1 SMALLDATETIME 
        ',@M_Ngay_CT2 SMALLDATETIME 
        ',@M_tb_Return NVARCHAR(200)
        ',@M_Ma_DVCS NVARCHAR(50)
        ',@M_User_Name NVARCHAR(100)
        ''CyberSupport.V_WorkView("CP_WorkDLH", "", "DANH SÁCH LỊCH HẸN SỬA CHỮA", True, M_Ma_Dvcs, M_User_Name, AppConn, osysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        Dim CyberWork As New Cyber.Workprogress.Sys
        CyberWork.V_Xem_Ds_Hen("HEN", "1", "", TxtMa_Xe.Text, M_Ma_Hs, Now.Date, Now.Date, True, AppConn, SysVar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Lich_Su(ByVal sender As System.Object, ByVal e As System.EventArgs)
         Dim _Ma_Xe As String = TxtMa_Xe.Text
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, M_Ma_CT, M_Stt_Rec, AppConn, Me.SysVar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_XemPhieuXuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem("PX", "")
    End Sub
    Private Sub V_XemChosuahua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem("SC", "")
    End Sub
    Private Sub V_Xemsuahuaxong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem("SX", "")
    End Sub
    Private Sub V_Xem_Giao_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode.Trim = "M" Or M_Mode.Trim = "S" Then Return
        V_Xem("GX", "")
    End Sub
    Private Sub V_Xem(ByVal _Loai_Xem As String, ByVal _StrFilter As String)
        If _Loai_Xem = "PX" And TxtSo_Ro.Text.Trim = "" Then Exit Sub
        Dim _Title As String = "DANH SÁCH XE SỬA CHỮA XONG"
        Dim _Cp_name As String
        If _StrFilter = "" Then _StrFilter = M_Stt_Rec.Trim + "#" + TxtSo_Ro.Text.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim
        Select Case _Loai_Xem
            Case "PX"
                _Cp_name = "CP_RoXemPX"
                _Title = "TÌNH HÌNH XUẤT KHO"
            Case "SC"
                _Cp_name = "CP_RoChosuachua"
                _Title = "DANH SÁCH XE CHỜ SỬA CHỮA"
            Case "SX"
                _Cp_name = "CP_RosuachuaXong"
                _Title = "DANH SÁCH XE SỬA CHỮA XONG"
            Case "LH"
                _Cp_name = "CP_WorkDLH"
                _Title = "DANH SÁCH LỊCH HẸN SỬA CHỮA"
                _StrFilter = "HEN#1#" + "" + "#" + "" + "#" + M_Ma_Hs + "#" + "19000101" + "#" + "19000101" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name
            Case "GX"
                _Cp_name = "CP_ROHDKXemGX"
                _Title = "XEM QÚA TRÌNH ĐIỀU CHỈNH THỜI GIAN GIAO XE"
            Case Else
                _Cp_name = "CP_RoXemXeHDK"
        End Select
        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, osysvar, M_LAN, M_Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        '--------------------------------------------------------------------------------------------------------------------------
    End Sub
#End Region
#End Region
#Region " Danh sach KTV_S/Update So lenh hang"
    Private Sub V_UpdateRoHang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub

        Dim _So_Ro_hang As String = TxtSo_Ro_Hang.Text

        Dim Frm As New FrmUpdateRoHang
        Frm.So_Ro_hang = _So_Ro_hang
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
        _So_Ro_hang = Frm.So_Ro_hang


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_UpdateRohangHDK", _So_Ro_hang & "#" & M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), SysVar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        TxtSo_Ro_Hang.Text = _So_Ro_hang
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = M_Stt_Rec.ToUpper.Trim Then
                Dt_Master.Rows(i).BeginEdit()
                Dt_Master.Rows(i).Item("So_Ro_Hang") = _So_Ro_hang.Trim
                Dt_Master.Rows(i).EndEdit()
                Dt_Master.AcceptChanges()
                Exit For
            End If
        Next

    End Sub
    Private Sub V_Ma_KTV_SVT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        If Not Dt_DetailTmp.Columns.Contains("Ma_KTV_S") Then Exit Sub
        Dim _iRow As Integer = -1
        _iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        Dim str As String
        Dim _ma_Ktv_s As String = Dv_DetailTmp.Item(_iRow).Item("Ma_KTV_S")
        Dim strTen As String = ""
        If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_S") Then strTen = Dv_DetailTmp.Item(_iRow).Item("ten_KTV_S")

        str = GetKTV(_ma_Ktv_s, strTen)
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            UpdateKTV(_iRow, str, strTen, "VT")
            Exit Sub
        End If

        'If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""

        Dv_DetailTmp.Item(_iRow).BeginEdit()
        Dv_DetailTmp.Item(_iRow).Item("Ma_KTV_S") = str
        If Dv_DetailTmp.Table.Columns.Contains("ten_KTV_S") Then Dv_DetailTmp.Item(_iRow).Item("ten_KTV_S") = strTen
        Dv_DetailTmp.Item(_iRow).EndEdit()

        For i As Integer = 0 To Dv_DetailTmp.Count - 1
            Dv_DetailTmp.Item(i).BeginEdit()
            Dv_DetailTmp.Item(i).Item("Ma_KTV_S") = IIf(Dv_DetailTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "", str, Dv_DetailTmp.Item(i).Item("Ma_KTV_S"))

            If Dv_DetailTmp.Table.Columns.Contains("ten_KTV_S") Then
                Dv_DetailTmp.Item(i).Item("ten_KTV_S") = IIf(Dv_DetailTmp.Item(i).Item("ten_KTV_S").ToString.Trim = "", strTen, Dv_DetailTmp.Item(i).Item("ten_KTV_S"))
            End If

            Dv_DetailTmp.Item(i).EndEdit()
        Next

        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_KTV_SCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim

        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        If Not Dt_DetailCvTmp.Columns.Contains("Ma_KTV_S") Then Exit Sub
        Dim _iRow As Integer = -1
        _iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        Dim str As String
        Dim _ma_Ktv_s As String = Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S")

        Dim strTen As String = ""
        If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_S") Then strTen = Dv_DetailCvTmp.Item(_iRow).Item("ten_KTV_S")

        str = GetKTV(_ma_Ktv_s, strTen)

        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            UpdateKTV(_iRow, str, strTen, "CV")
            Exit Sub
        End If

        'If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""

        Dv_DetailCvTmp.Item(_iRow).BeginEdit()
        Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S") = str
        If Dv_DetailCvTmp.Table.Columns.Contains("ten_KTV_S") Then Dv_DetailCvTmp.Item(_iRow).Item("ten_KTV_S") = strTen
        Dv_DetailCvTmp.Item(_iRow).EndEdit()

        For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
            Dv_DetailCvTmp.Item(i).BeginEdit()
            Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S") = IIf(Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "", str, Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S"))
            If Dv_DetailCvTmp.Table.Columns.Contains("ten_KTV_S") Then
                Dv_DetailCvTmp.Item(i).Item("ten_KTV_S") = IIf(Dv_DetailCvTmp.Item(i).Item("ten_KTV_S").ToString.Trim = "", strTen, Dv_DetailCvTmp.Item(i).Item("ten_KTV_S"))
            End If
            Dv_DetailCvTmp.Item(i).EndEdit()
        Next
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub UpdateKTV(ByVal _iRow As Integer, ByVal _Ma_KTV_S As String, ByVal _Ten_KTV_S As String, ByVal Loai As String)
        If Dv_DetailCvTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "CV" Then

                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCvTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCvTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailCvTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailCvTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailCvTmp.Item(_iRow).BeginEdit()
                Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCvTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailCvTmp.Item(_iRow).EndEdit()
                '-------------
                For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
                    If Not Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailCvTmp.Item(i).BeginEdit()
                    Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCvTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailCvTmp.Item(i).EndEdit()
                Next
                DetailGRVCv.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_DetailCv.Rows.Count - 1
                '    If Not Dt_DetailCv.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_DetailCv.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_DetailCv.Rows(iRow).BeginEdit()
                '    Dt_DetailCv.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_DetailCv.Rows(iRow).EndEdit()
                'Next
                'Dt_DetailCv.AcceptChanges()
            End If
        End If
        '--------------------------------------------------------
        If Dv_DetailTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "VT" Then
                '
                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailTmp.Item(_iRow).BeginEdit()
                Dv_DetailTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_Detail.Columns.Contains("Ten_KTV_S") Then Dv_DetailTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailTmp.Item(_iRow).EndEdit()

                '------------
                For i = 0 To Dv_DetailTmp.Count - 1
                    If Not Dv_DetailTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailTmp.Item(i).BeginEdit()
                    Dv_DetailTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_Detail.Columns.Contains("Ten_KTV_S") Then Dv_DetailTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailTmp.Item(i).EndEdit()
                Next
                DetailGRVVt.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_Detail.Rows.Count - 1
                '    If Not Dt_Detail.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_Detail.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_Detail.Rows(iRow).BeginEdit()
                '    Dt_Detail.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_Detail.Rows(iRow).EndEdit()
                'Next
                'Dt_Detail.AcceptChanges()
            End If
        End If
    End Sub
    Private Sub V_SetDatabingMa_KTV()
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not Dt_Detail.Columns.Contains("Ma_KTV_S") And Not Dt_DetailCv.Columns.Contains("Ma_KTV_S") Then Exit Sub

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetKTVSHDK", M_Stt_Rec & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        '---------------------------------------------------
        Dim _Stt_Rec0 As String = ""
        Dim _Ma_Ktv_S As String = ""
        Dim _ten_KTV_S As String = ""

        If Dt_Detail.Columns.Contains("Ma_KTV_S") Then
            For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
                _Stt_Rec0 = DsTmp.Tables(0).Rows(i).Item("Stt_Rec0").ToString.Trim
                _Ma_Ktv_S = DsTmp.Tables(0).Rows(i).Item("Ma_KTV_S").ToString.Trim
                If DsTmp.Tables(0).Columns.Contains("Ten_KTV_S") Then _ten_KTV_S = DsTmp.Tables(0).Rows(i).Item("Ten_KTV_S").ToString.Trim Else _ten_KTV_S = ""

                For j As Integer = 0 To Dv_DetailTmp.Count - 1
                    If Not Dv_DetailTmp.Item(j).Item("Stt_rec0").ToString.Trim.ToUpper = _Stt_Rec0.Trim.Trim.ToUpper Then Continue For
                    Dv_DetailTmp.Item(j).BeginEdit()
                    Dv_DetailTmp.Item(j).Item("Ma_KTV_S") = _Ma_Ktv_S
                    If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_S") Then Dv_DetailTmp.Item(j).Item("Ten_KTV_S") = _ten_KTV_S

                    Dv_DetailTmp.Item(j).EndEdit()
                    DetailGRVVt.UpdateCurrentRow()
                    Exit For
                Next
            Next
        End If
        '---------------------------------------------------
        _Stt_Rec0 = ""
        _Ma_Ktv_S = ""
        _ten_KTV_S = ""

        If Dt_DetailCv.Columns.Contains("Ma_KTV_S") Then
            For i As Integer = 0 To DsTmp.Tables(1).Rows.Count - 1
                _Stt_Rec0 = DsTmp.Tables(1).Rows(i).Item("Stt_Rec0").ToString.Trim
                _Ma_Ktv_S = DsTmp.Tables(1).Rows(i).Item("Ma_KTV_S").ToString.Trim
                If DsTmp.Tables(1).Columns.Contains("Ten_KTV_S") Then _ten_KTV_S = DsTmp.Tables(1).Rows(i).Item("Ten_KTV_S").ToString.Trim Else _ten_KTV_S = ""

                For j As Integer = 0 To Dv_DetailCvTmp.Count - 1
                    If Not Dv_DetailCvTmp.Item(j).Item("Stt_rec0").ToString.Trim.ToUpper = _Stt_Rec0.Trim.Trim.ToUpper Then Continue For
                    Dv_DetailCvTmp.Item(j).BeginEdit()
                    Dv_DetailCvTmp.Item(j).Item("Ma_KTV_S") = _Ma_Ktv_S
                    If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_S") Then Dv_DetailCvTmp.Item(j).Item("Ten_KTV_S") = _ten_KTV_S
                    Dv_DetailCvTmp.Item(j).EndEdit()
                    DetailGRVCv.UpdateCurrentRow()
                    Exit For
                Next
            Next
        End If

        DsTmp.Dispose()
    End Sub
    Private Function GetKTV(ByVal _Ma_KTV As String, ByRef _Ten_KTV As String) As String
        GetKTV = CyberSupport.V_GetStrSelectList(AppConn, osysvar, M_Para, "CP_GetListSelect", "DMKTVSC#" & _Ma_KTV & "#" & M_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN, _Ten_KTV)
    End Function
    Private Sub V_SaveMa_KTV_S()
        If Not Dt_Detail.Columns.Contains("Ma_KTV_S") And Not Dt_DetailCv.Columns.Contains("Ma_KTV_S") Then Exit Sub
        Dim DsTmp As DataSet
        Dim strsql As String = ""
        strsql = ""
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            If Dt_DetailTmp.Columns.Contains("Ma_Ktv_s") Then
                strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailTmp.Item(iRow).Item("Stt_Rec0") + "',N'" + Dv_DetailTmp.Item(iRow).Item("Ma_KTv_S").ToString.Trim + "'"
            End If
        Next
        For iRow As Integer = 0 To Dv_DetailCvTmp.Count - 1
            If Dt_DetailCvTmp.Columns.Contains("Ma_Ktv_s") Then
                strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCvTmp.Item(iRow).Item("Stt_Rec0") + "',N'" + Dv_DetailCvTmp.Item(iRow).Item("Ma_KTv_S").ToString.Trim + "'"
            End If
        Next
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", M_Mode & "#" & "" & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
    End Sub
#End Region
#Region "Valid - Tag Vật tư phụ tùng"
#Region "Valid - Tinh toan"
   Private Sub UpdateList()
        Dim i As Integer
        Dim nT_So_Luong As Decimal = 0

        Dim nT_Tien2 As Decimal = 0
        Dim nT_CV As Decimal = 0
        Dim nT_Thue_VT As Decimal = 0
        Dim nT_Thue_CV As Decimal = 0

        Dim nT_Ck_VT As Decimal = 0
        Dim nT_Ck_CV As Decimal = 0
        '---Dieu chinh
        Dim nT_DC_VT As Decimal = 0
        Dim nT_DC_CV As Decimal = 0

        Dim nT_I As Decimal = 0
        Dim nT_W As Decimal = 0
        Dim nT_N As Decimal = 0
        Dim nT_C As Decimal = 0

        For i = 0 To Dt_DetailTmp.Rows.Count - 1
            If Dt_DetailTmp.Rows(i).RowState = DataRowState.Deleted Then
                Continue For
            End If



            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Then
                nT_I = nT_I + Dt_DetailTmp.Rows(i).Item("Tien2") - Dt_DetailTmp.Rows(i).Item("CK_I") + Dt_DetailTmp.Rows(i).Item("Thue") + Dt_DetailTmp.Rows(i).Item("Dc_I")
            End If
            If Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Then
                nT_W = nT_W + Dt_DetailTmp.Rows(i).Item("Tien2") - Dt_DetailTmp.Rows(i).Item("CK_I") + Dt_DetailTmp.Rows(i).Item("Thue") + Dt_DetailTmp.Rows(i).Item("Dc_I")
            End If

            If Not (Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C") Then
                nT_N = nT_N + Dt_DetailTmp.Rows(i).Item("Tien2") - Dt_DetailTmp.Rows(i).Item("CK_I") + Dt_DetailTmp.Rows(i).Item("Thue") + Dt_DetailTmp.Rows(i).Item("Dc_I")
            End If

            nT_Ck_VT = nT_Ck_VT + Dt_DetailTmp.Rows(i).Item("Ck_I")
            nT_So_Luong = nT_So_Luong + Dt_DetailTmp.Rows(i).Item("So_Luong")
            nT_Tien2 = nT_Tien2 + Dt_DetailTmp.Rows(i).Item("Tien2")
            nT_Thue_VT = nT_Thue_VT + Dt_DetailTmp.Rows(i).Item("Thue")
            nT_DC_VT = nT_DC_VT + Dt_DetailTmp.Rows(i).Item("Dc_I")
        Next
        '----------------------------------------------------------------------------
        txtT_So_Luong.Double = nT_So_Luong
        '----------------------------------------------------------------------------
        For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
            If Dt_DetailCvTmp.Rows(i).RowState = DataRowState.Deleted Then Continue For



            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Then
                nT_I = nT_I + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") - Dt_DetailCvTmp.Rows(i).Item("CK_I") + Dt_DetailCvTmp.Rows(i).Item("Thue") + Dt_DetailCvTmp.Rows(i).Item("Dc_I")
            End If

            If Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Then
                nT_W = nT_W + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") - Dt_DetailCvTmp.Rows(i).Item("CK_I") + Dt_DetailCvTmp.Rows(i).Item("Thue") + Dt_DetailCvTmp.Rows(i).Item("Dc_I")
            End If

            If Not (Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "W" Or Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "I" Or Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim.ToUpper = "C") Then
                nT_N = nT_N + Dt_DetailCvTmp.Rows(i).Item("Tien_CV") - Dt_DetailCvTmp.Rows(i).Item("CK_I") + Dt_DetailCvTmp.Rows(i).Item("Thue") + Dt_DetailCvTmp.Rows(i).Item("Dc_I")
            End If

            nT_Ck_CV = nT_Ck_CV + Dt_DetailCvTmp.Rows(i).Item("Ck_I")
            nT_CV = nT_CV + Dt_DetailCvTmp.Rows(i).Item("Tien_CV")
            nT_Thue_CV = nT_Thue_CV + Dt_DetailCvTmp.Rows(i).Item("Thue")
            nT_DC_CV = nT_DC_CV + Dt_DetailCvTmp.Rows(i).Item("Dc_I")
        Next
        '------------------------------------------   Chiet khau_VT
        If ChkVT.Checked Then nT_Ck_VT = TxtT_CK_VT.Double Else TxtT_CK_VT.Double = nT_Ck_VT
        '------------------------------------------   Chiet khau_CV
        If ChkCV.Checked Then nT_Ck_CV = TxtT_CK_CV.Double Else TxtT_CK_CV.Double = nT_Ck_CV
        '------------------------------------------   Bao hiem
        If ChkBH.Checked Then nT_I = TxtT_I.Double Else TxtT_I.Double = nT_I

        If ChkNB.Checked Then nT_N = TxtT_N.Double Else TxtT_N.Double = nT_N
        If ChkWH.Checked Then nT_W = TxtT_W.Double Else TxtT_W.Double = nT_W
        '------------------------------------------ Noi bo thanh toan, Bao hanh thanh toan("Hang")
        TxtT_W.Double = nT_W
        TxtT_N.Double = nT_N
        '------------------------------------------------------------------------------------
        TxtT_DC_CV.Double = nT_DC_CV
        TxtT_DC_VT.Double = nT_DC_VT
        '------------------------------------------------------------------------------------
        TxtT_CV.Double = nT_CV
        TxtT_Thue_CV.Double = nT_Thue_CV
        TxtT_TT_CV.Double = nT_CV + nT_Thue_CV - nT_Ck_CV + nT_DC_CV

        TxtT_Tien2.Double = nT_Tien2
        TxtT_Thue_VT.Double = nT_Thue_VT
        TxtT_TT_VT.Double = nT_Tien2 + nT_Thue_VT - nT_Ck_VT + nT_DC_VT
        '------------------------------------------
        TxtT_C.Double = nT_Tien2 + nT_Thue_VT + nT_CV + nT_Thue_CV - nT_Ck_VT - nT_Ck_CV - nT_I - nT_W - nT_N + nT_DC_VT + nT_DC_CV
        TxtT_TT.Double = TxtT_I.Double + TxtT_W.Double + TxtT_N.Double + TxtT_C.Double
        '------------------------------------------------------------------------------------
        V_PT_Moi_Gioi(New System.Object, New System.EventArgs)
        V_PT_HH_BH(New System.Object, New System.EventArgs)
        V_PT_Dat_Coc(New System.Object, New System.EventArgs)
    End Sub
    Private Sub Tinh_Gia2(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Gia_TK As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia_TK")
        Dim _Gia2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia2")
        Dim _Ma_vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt")
        Dim _Ma_Kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I")
        Dim _Ma_TT As String = Dv_DetailTmp.Item(iRow).Item("Ma_TT")
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        '-----------------------------------------------------------------------------------------------------------
        Dim dsGia2 As New DataSet
        dsGia2 = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetHDKGia2", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT.Trim & "#" & M_Stt_Rec & "#" & M_Mode & "#" & _
                                                    _Ma_GD & "#" & _Ma_Post & "#" & _Ma_vt.Trim & "#" & _Ma_Kho.Trim + "#" & _Ma_TT & "#" & _
                                                    _Gia2.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)
        _Gia2 = dsGia2.Tables(0).Rows(0).Item("Gia2")
        _Gia_TK = dsGia2.Tables(0).Rows(0).Item("Gia_TK")

        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Gia2") = _Gia2
        If Dt_DetailTmp.Columns.Contains("Gia_TK") Then Dv_DetailTmp.Item(iRow).Item("Gia_TK") = _Gia_TK
        If Dt_DetailTmp.Columns.Contains("BackColor") And dsGia2.Tables(0).Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = dsGia2.Tables(0).Rows(0).Item("BackColor")
        If Dt_DetailTmp.Columns.Contains("BackColor2") And dsGia2.Tables(0).Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = dsGia2.Tables(0).Rows(0).Item("BackColor2")
        If Dt_DetailTmp.Columns.Contains("ForeColor") And dsGia2.Tables(0).Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = dsGia2.Tables(0).Rows(0).Item("ForeColor")
        If Dt_DetailTmp.Columns.Contains("Bold") And dsGia2.Tables(0).Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = dsGia2.Tables(0).Rows(0).Item("Bold")
        Dv_DetailTmp.Item(iRow).EndEdit()

        dsGia2.Dispose()
        '-----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim
        Dim _Ma_kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _Ma_Vitri As String = If(Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri"), Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim, "")
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        'If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
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
        'End If
    End Sub
    Private Sub V_Tinh_ToanPT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVVt.PostEditor()
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        Tinh_TienPT(iRow)
    End Sub
    Private Sub Tinh_TienPT(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 0
        If TxtTy_Gia.Text.Trim = "0" Or TxtTy_Gia.Text.Trim = "" Or TxtMa_NT.Text.Trim = osysvar("M_Ma_Nt0").ToString.Trim Then
            TxtTy_Gia.Text = 1
            TxtTy_Gia.Refresh()
        End If
        nTy_Gia = CType(TxtTy_Gia.Text.Replace(" ", ""), Decimal)
        nTy_Gia = 1

        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2"), 0)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------

        'Chiet Khau---------------------------------------------------------------------------------------
        If ChkVT.Checked Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0
            Dv_DetailTmp.Item(iRow).Item("CK_I") = 0
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If Not ChkVT.Checked Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If CyberSupport.ChkFieldKey(Dv_DetailTmp.Item(iRow).Item("Ma_TT"), "I,C") Then
                Dv_DetailTmp.Item(iRow).Item("CK_I") = IIf(Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0, Dv_DetailTmp.Item(iRow).Item("CK_I"), _
                     CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien2") * Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") / 100, 0))
            Else
                Dv_DetailTmp.Item(iRow).Item("PT_Ck_I") = 0
                Dv_DetailTmp.Item(iRow).Item("CK_I") = 0
            End If
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        If ChkVT.Checked Then V_T_CK_VT(New System.Object, New System.EventArgs)
        If ChkBH.Checked Then V_T_CK_BH(New System.Object, New System.EventArgs)
        '---Dieu chinh
        Dv_DetailTmp.Item(iRow).BeginEdit()
        'hieulv dieu chinh cach tinh
        'Dv_DetailTmp.Item(iRow).Item("DC_I") = IIf(Dv_DetailTmp.Item(iRow).Item("PT_DC_I") = 0, Dv_DetailTmp.Item(iRow).Item("DC_I"), CyberSupport.V_Round((Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I")) * Dv_DetailTmp.Item(iRow).Item("PT_DC_I") / 100, 0))
        Dv_DetailTmp.Item(iRow).Item("DC_I") = IIf(Dv_DetailTmp.Item(iRow).Item("PT_DC_I") = 0, Dv_DetailTmp.Item(iRow).Item("DC_I"), CyberSupport.V_Round((Dv_DetailTmp.Item(iRow).Item("Tien2")) * Dv_DetailTmp.Item(iRow).Item("PT_DC_I") / 100, 0))
        Dv_DetailTmp.Item(iRow).EndEdit()
        '----------------------------- Thue,Tien0
        TinhThue_VT(iRow)
        '-----------------------------
        UpdateList()
    End Sub
     Private Sub TinhThue_VT(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dt_DetailTmp.Columns.Contains("Sua_Thue") Then
            If Dv_DetailTmp.Item(iRow).Item("Sua_Thue").ToString.Trim <> "1" Then
                Dv_DetailTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I") + Dv_DetailTmp.Item(iRow).Item("DC_I")) * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
                'Else
                '    Dv_DetailTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I") + Dv_DetailTmp.Item(iRow).Item("DC_I")) * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
            End If
        Else
            Dv_DetailTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I") + Dv_DetailTmp.Item(iRow).Item("DC_I")) * Dv_DetailTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
        End If

        If Dt_DetailTmp.Columns.Contains("Tien0") Then Dv_DetailTmp.Item(iRow).Item("Tien0") = Dv_DetailTmp.Item(iRow).Item("Tien2") - Dv_DetailTmp.Item(iRow).Item("CK_I") + Dv_DetailTmp.Item(iRow).Item("DC_I")
        Dv_DetailTmp.Item(iRow).EndEdit()

    End Sub
#End Region
#Region "Ma_Kh_I"
    Private Sub V_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_kh_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_kh_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_kh_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
#End Region
#Region "Ma_Vt"
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Vt", "DmVt", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
        'If M_Ma_CT = "HDM" Then
        '    CyberSupport.V_Lookup("Ma_Vt", "DmVt", "(Nh_vt2 = '02' OR Nh_vt2 = '05') AND Acti = '1'", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
        'Else
        '    CyberSupport.V_Lookup("Ma_Vt", "DmVt", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
        'End If
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_vt") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_VT") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_VT3") = ""
            Dv_DetailTmp.Item(iRow).Item("Dvt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_kho_i As String = "", _Ma_VT As String = "", _DVT As String = "", _Ten_VT As String = "", _Thue_Suat As Decimal = 0
        Dim _Gia2 As Decimal = 0
        _Ma_VT = DrReturn("Ma_vt").ToString.Trim
        _Ten_VT = DrReturn("Ten_VT").ToString.Trim
        _DVT = DrReturn("DVT").ToString.Trim
        _Ma_kho_i = DrReturn("Ma_kho").ToString.Trim
        _Thue_Suat = DrReturn("Thue_Suat").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Vt") = _Ma_VT
        Dv_DetailTmp.Item(iRow).Item("Ten_vt") = _Ten_VT
        Dv_DetailTmp.Item(iRow).Item("DVT") = _DVT
        Dv_DetailTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT").ToString.Trim <> "", Dv_DetailTmp.Item(iRow).Item("Ma_TT"), M_Ma_TT)
        Dv_DetailTmp.Item(iRow).Item("Ma_kho_i") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_kho_i").ToString.Trim = "", _Ma_kho_i, Dv_DetailTmp.Item(iRow).Item("Ma_kho_i"))
        Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = 0, _Thue_Suat, Dv_DetailTmp.Item(iRow).Item("Thue_Suat"))
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------------------------------------------------------
        If Dv_DetailTmp.Item(iRow).Item("Ten_vt3").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ten_vt3") = _Ten_VT
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If

        '-----------------------------------------------------------------------------------------------------------
        Tinh_Gia2(iRow)
        Tinh_TienPT(iRow)
        UpdateList()
        '-----------------------------------------------------------------------------------------------------------
        V_SetSD(iRow)
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ten_Vt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailTmp.AcceptChanges()
        If Dt_DetailTmp.Rows(iRow).Item("Ten_vt3").ToString.Trim = "" Then
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Ten_vt3") = Dt_DetailTmp.Rows(iRow).Item("Ten_vt")
            Dt_DetailTmp.Rows(iRow).EndEdit()
        End If
        Dt_DetailTmp.AcceptChanges()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CvVt"
    Private Sub V_Ma_CvVt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "DmCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CvVt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_Cv") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CtCvVT"
    Private Sub V_Ma_CtCvVT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CtCvVT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        'Dv_DetailTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailTmp.Item(iRow).Item("Thue_Suat") <> 0, Dv_DetailTmp.Item(iRow).Item("Thue_Suat"), DrReturn("Thue_Suat"))
        'Dv_DetailTmp.Item(iRow).Item("Tien_CV") = IIf(Dv_DetailTmp.Item(iRow).Item("Tien_CV") <> 0, Dv_DetailTmp.Item(iRow).Item("Tien_CV"), DrReturn("Tien_CV"))
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region

#Region "Ma_Kho_I"
    Private Sub V_Ma_Kho_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_kho", "DmKho", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_Kho_i") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Kho_i") = DrReturn("Ma_Kho").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------
        'Tinh_Gia2(iRow)
        'Tinh_TienPT(iRow)
        'UpdateList()
        'DetailGRVVt.UpdateCurrentRow()
        '-------------------------------------------------------------------
        V_SetSD(iRow)
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region
#Region "L_Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
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
        If ChkBH.Checked Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailTmp.Item(iRow).Item("Ma_TT") = "I", "C", Dv_DetailTmp.Item(iRow).Item("Ma_TT"))
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        '-------------------------------------------------------------------
        Tinh_Gia2(iRow)
        Tinh_TienPT(iRow)
        UpdateList()
        DetailGRVVt.UpdateCurrentRow()
        '-------------------------------------------------------------------
    End Sub
#End Region
#Region "Ma_Vv_i/Phi...TD1/Td2.../TD5 = Cua cong viec sua chua"
    Private Sub V_Ma_KTV_ICV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DmKTV", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KTV_ICV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow)("Ma_KTV_I") = ""
            If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_KTV_I") = ""
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_KTV_I") = DrReturn("Ma_hs").ToString.Trim
        If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_KTV_I") = DrReturn("Ten_hs").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Vv_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_Phi_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_HD_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_SP_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_KU_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KU_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TTLN_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TTCP_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_Bp_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_HS_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_CD_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TD1_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TD2_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TD3_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TD4_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_Ma_TD5_iCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_iCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
#End Region
#Region "Ma_Vv_i/Phi...TD1/Td2.../TD5"
    Private Sub V_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DmKTV", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_KTV_I") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailTmp.Item(iRow).Item("Ten_KTV_I") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_KTV_I") = DrReturn("Ma_hs").ToString.Trim
        If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailTmp.Item(iRow).Item("Ten_KTV_I") = DrReturn("Ten_hs").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_NVKD(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("MD_HS", "DmHs", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_NVKD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_NVKD") = ""
            Exit Sub
        Else
            Dv_DetailTmp.Item(iRow)("Ma_NVKD") = DrReturn("MD_HS")
        End If
        Dt_DetailTmp.AcceptChanges()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
#End Region
#End Region
#Region "Valid - Tag Công việc"
#Region "Valid - Tinh toan cong viec"
    Private Sub V_Tinh_ToanCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVCv.PostEditor()
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailCvTmp.AcceptChanges()
        Tinh_TienCV(iRow)
    End Sub
    Private Sub Tinh_TienCV(ByVal iRow As Integer)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 0
        If TxtTy_Gia.Text.Trim = "0" Or TxtTy_Gia.Text.Trim = "" Or TxtMa_NT.Text.Trim = osysvar("M_Ma_Nt0").ToString.Trim Then
            TxtTy_Gia.Text = 1
            TxtTy_Gia.Refresh()
        End If
        nTy_Gia = CType(TxtTy_Gia.Text.Replace(" ", ""), Decimal)
        nTy_Gia = 1
        'Tinh Tiền Cong viec ---------------------------------------------------------------------------------------
        If Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") <> 0 Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCvTmp.Item(iRow).Item("Gio_TC"), 0)
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        'Chiet Khau---------------------------------------------------------------------------------------
        If ChkCV.Checked Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") = 0
            Dv_DetailCvTmp.Item(iRow).Item("Ck_I") = 0
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        If Not ChkCV.Checked Then
            '--------- Tinh Chiet Khau
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            If CyberSupport.ChkFieldKey(Dv_DetailCvTmp.Item(iRow).Item("Ma_TT"), "I,C") Then
                Dv_DetailCvTmp.Item(iRow).Item("Ck_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") = 0, Dv_DetailCvTmp.Item(iRow).Item("Ck_I"), CyberSupport.V_Round(Dv_DetailCvTmp.Item(iRow).Item("Tien_Cv") * Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") / 100, 0))
            Else
                Dv_DetailCvTmp.Item(iRow).Item("PT_Ck_I") = 0
                Dv_DetailCvTmp.Item(iRow).Item("Ck_I") = 0
            End If
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        If ChkCV.Checked Then V_T_CK_CV(New System.Object, New System.EventArgs)
        '---Dieu chinh
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        'hieulv doi lai cach tinh tien dieu chinh
        'Dv_DetailCvTmp.Item(iRow).Item("DC_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("PT_DC_I") = 0, Dv_DetailCvTmp.Item(iRow).Item("DC_I"), CyberSupport.V_Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_Cv") - Dv_DetailCvTmp.Item(iRow).Item("CK_I")) * Dv_DetailCvTmp.Item(iRow).Item("PT_DC_I") / 100, 0))
        Dv_DetailCvTmp.Item(iRow).Item("DC_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("PT_DC_I") = 0, Dv_DetailCvTmp.Item(iRow).Item("DC_I"), CyberSupport.V_Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_Cv")) * Dv_DetailCvTmp.Item(iRow).Item("PT_DC_I") / 100, 0))
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        '---------- Tinh thue
        TinhThue_CV(iRow)
        UpdateList()

    End Sub
    Private Sub TinhThue_CV(ByVal iRow As Integer)

        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        If Dt_DetailCvTmp.Columns.Contains("Sua_Thue") Then
            If Dv_DetailCvTmp.Item(iRow).Item("Sua_Thue").ToString.Trim <> "1" Then
                Dv_DetailCvTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") - Dv_DetailCvTmp.Item(iRow).Item("CK_I") + Dv_DetailCvTmp.Item(iRow).Item("DC_I")) * Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
                'Else
                '    Dv_DetailCvTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") - Dv_DetailCvTmp.Item(iRow).Item("CK_I") + Dv_DetailCvTmp.Item(iRow).Item("DC_I")) * Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
            End If
        Else
            Dv_DetailCvTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") - Dv_DetailCvTmp.Item(iRow).Item("CK_I") + Dv_DetailCvTmp.Item(iRow).Item("DC_I")) * Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") / 100, 0, MidpointRounding.AwayFromZero)
        End If


        If Dt_DetailCvTmp.Columns.Contains("Tien_CV0") Then Dv_DetailCvTmp.Item(iRow).Item("Tien_CV0") = Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") - Dv_DetailCvTmp.Item(iRow).Item("CK_I") + Dv_DetailCvTmp.Item(iRow).Item("DC_I")
        Dv_DetailCvTmp.Item(iRow).EndEdit()

    End Sub
#End Region
#Region "Ma_Cv"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = ""
            Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailCvTmp.Item(iRow).Item("Ma_TT") = ""
            Dv_DetailCvTmp.Item(iRow).EndEdit()
            DetailGRVVt.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Ma_TT").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("Ma_TT"), M_Ma_TT)
        Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv" + IIf(M_LAN = "V", "", "2")).ToString.Trim
        Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3"), DrReturn("Ten_Cv" + IIf(M_LAN = "V", "", "2")).ToString.Trim)
        Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I"), DrReturn("Ma_Hs").ToString.Trim)


        'Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat"), DrReturn("Thue_Suat"))
        'If Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = DrReturn("Gia_CV")
        'If Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = DrReturn("Gio_TC")
        'If Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = DrReturn("Tien_CV")
        Dv_DetailCvTmp.Item(iRow).EndEdit()

        If Not V_Update_Gio_TC(iRow) Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat"), DrReturn("Thue_Suat"))
            If Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = DrReturn("Gia_CV")
            If Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = DrReturn("Gio_TC")
            If Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = 0 Then Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = DrReturn("Tien_CV")
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If

        Tinh_TienCV(iRow)
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Function V_Update_Gio_TC(ByVal _iRow As Integer) As Boolean
        Dim _Return As Boolean = False
        If _iRow < 0 Then Return _Return
        If Not (M_Mode = "M" Or M_Mode = "S") Then Return _Return
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        Dim _So_Khung As String = TxtSo_khung.Text
        Dim _So_May As String = TxtSo_May.Text
        Dim _ma_Kx As String = TxtMa_Kx.Text
        Dim _ma_Mau As String = TxtMa_Mau.Text
        Dim _Str As String = "INSERT CTGetCVCYBER SELECT N'" + Dv_DetailCvTmp.Item(_iRow).Item("Ma_Cv").ToString.Trim + "'"
        _Str = _Str + ",N'" + Dv_DetailCvTmp.Item(_iRow).Item("Ma_CTCv").ToString.Trim + "'"
        _Str = _Str + ",N'" + Dv_DetailCvTmp.Item(_iRow).Item("Gio_TC").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
        _Str = _Str + ",N'" + Dv_DetailCvTmp.Item(_iRow).Item("Gia_CV").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
        _Str = _Str + ",N'" + Dv_DetailCvTmp.Item(_iRow).Item("CK_I").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
        _Str = _Str + ",N'" + Dv_DetailCvTmp.Item(_iRow).Item("Tien_CV").ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROUpdateGioTC", _Ma_Xe + "#" + _So_Khung + "#" + _So_May + "#" + _ma_Kx + "#" + _ma_Mau + "#" + _Str + "#" + M_Ma_CT + "#" + M_Mode + "#" + M_Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If _DsTmp.Tables.Count = 0 Then
            _DsTmp.Dispose()
            Return _Return
        End If

        If _DsTmp.Tables(0).Rows.Count = 0 Then
            _DsTmp.Dispose()
            Return _Return
        End If
        CyberSmodb.V_UpdateRowtoRow(_DsTmp.Tables(0).Rows(0), Dv_DetailCvTmp, _iRow)
        DetailGRVCv.UpdateCurrentRow()
        _DsTmp.Dispose()
        _Return = True
        Return _Return
    End Function
#End Region
#Region "Ma_CtCv"
    Private Sub V_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow)("Ma_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        If DrReturn.Table.Columns.Contains("Thue_Suat") Then Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat"), DrReturn("Thue_Suat"))
        If DrReturn.Table.Columns.Contains("Tien_CV") Then Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Tien_CV"), DrReturn("Tien_CV"))
        If DrReturn.Table.Columns.Contains("Gio_TC") Then Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Gio_TC"), DrReturn("Gio_TC"))
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        Tinh_TienCV(iRow)
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_TTCV"
    Private Sub V_Ma_TTCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_TT", "DmTT", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow)("Ma_TT") = ""
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_TT") = DrReturn("Ma_TT").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        If ChkBH.Checked Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Ma_TT") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Ma_TT") = "I", "C", Dv_DetailCvTmp.Item(iRow).Item("Ma_TT"))
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        Tinh_TienCV(iRow)
        V_T_CK_CV(New System.Object, New System.EventArgs)
        V_T_CK_BH(New System.Object, New System.EventArgs)
        UpdateList()
        DetailGRVCv.UpdateCurrentRow()
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
        'txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        'txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        'txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Ty gia -  Ngoai te"
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)

    End Sub
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
    Private Sub E_Ty_GIa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then
            SendKeys.Send("{Tab}")
            Exit Sub
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_Nt0").ToString.Trim.ToUpper Then
            TxtTy_Gia.Text = 1
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub V_Ty_GIa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        With Me
            If .TxtTy_Gia.Text.Trim = "0" Or .TxtTy_Gia.Text.Trim = "" Or .TxtMa_NT.Text.Trim = osysvar("M_Ma_Nt0").ToString.Trim Then
                .TxtTy_Gia.Text = 1
                .TxtTy_Gia.Refresh()
            End If
        End With
        UpdateList()
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
        Dim mnItemsManl As New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)
        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)
        Dim mnItemsRefresh As New MenuItem(If(M_LAN = "V", "Refresh", "Refresh"), AddressOf V_ShortRefresh, Keys.F5)


        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        DetailGRVVt.GridControl.ContextMenu = mnItemsMail

        mnItemsManl.MenuItems.Add(mnItemsSave)
        mnItemsManl.MenuItems.Add(mnItemsPrint)
        mnItemsManl.MenuItems.Add(mnItemsRefresh)

        Me.ContextMenu = mnItemsManl
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
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRVVt) Then Exit Sub
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
#Region "Mainform Cong Viec"
    Private Sub V_MainSystemCv()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemCv, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemCv, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVCv_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_ImportCv, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItemCv(iRow)
        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCvTmp, AppConn, DetailGRVCv) Then Exit Sub
        Dv_DetailCvTmp.Delete(iRow)
        Dv_DetailCvTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVVt.PostEditor()
        DetailGRVCv.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailCvTmp.Table.AcceptChanges()

        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        ''V_GetAndSetChkbSCC_DS_ALL("1")
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        V_T_CK_BH(New System.Object, New System.EventArgs)
        V_T_CK_NB(New System.Object, New System.EventArgs)
        V_T_CK_WH(New System.Object, New System.EventArgs)
        '----------------------------------------------------------------------------------------------------------------------
        If ChkSCC.Checked And Not ChkSDS.Checked Then TxtLoai_SC.Text = "1"
        If Not ChkSCC.Checked And ChkSDS.Checked Then TxtLoai_SC.Text = "2"
        If ChkSCC.Checked And ChkSDS.Checked Then TxtLoai_SC.Text = "3"
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailCvTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        V_Chk_BH(sender, e)
        V_Chk_CV(sender, e)
        V_Chk_VT(sender, e)

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
        '----Ph89Xe
        Dim _DtPh89Xe As DataTable = DtPH89Xestru.Clone
        Dim _DrPh89Xe As DataRow = _DtPh89Xe.NewRow
        _DrPh89Xe.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrPh89Xe)
        CyberSmodb.AddValueToRow(_DrPh89Xe, Me)
        If DtPH89Xestru.Columns.Contains("Stt_Rec") Then _DrPh89Xe.Item("Stt_Rec") = M_Stt_Rec
        If DtPH89Xestru.Columns.Contains("Ma_Ct") Then _DrPh89Xe.Item("Ma_Ct") = M_Ma_CT
        If DtPH89Xestru.Columns.Contains("Ma_Dvcs") Then _DrPh89Xe.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrPh89Xe.EndEdit()
        _DtPh89Xe.Rows.Add(_DrPh89Xe)
        _DtPh89Xe.AcceptChanges()
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
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp, _DtPh89Xe, _DtDmxeXe}, {M_Ct, M_Ph, "CTGT40", "PH89XE", "DMXE"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
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

        '---Update CV
        If DsSave.Tables.Count >= 4 Then
            For iRow As Integer = 0 To DsSave.Tables(3).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(3).Rows(iRow), Dt_DetailCvTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---------------------------------------------------
        '---Xoa trong DetailCV
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_DetailCv.Load(Dt_DetailCvTmp.CreateDataReader)
        '----------------------------------------------------------------------------------------------------------------------
        If SysvarRO("M_UP_BH_XE").ToString.Trim = "1" And M_Ma_CT.Trim.ToUpper = "HDK" And TxtMa_Xe.Text.Trim <> "" Then
            If CbbMa_Post.SelectedValue.ToString.Trim = "2" And M_Mode = "M" Then V_Thamsobaohiem(M_Ma_CT, TxtMa_Xe.Text, TxtTen_kh.Text, TxtDia_Chi.Text, TxtDien_Thoai.Text, TxtDt_LX.Text)
        End If
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_DetailTmp.Rows.Count
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Save_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVVt.PostEditor()
        DetailGRVCv.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailCvTmp.Table.AcceptChanges()
        '-----------------------------------------------------------------------------------------------
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()

        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        'V_GetAndSetChkbSCC_DS_ALL("1")
        '----------------------------------------------------------------------------------------------------------------------
        'Begin 2019.07.07: Tính lưu cho tiền bảo hiểm, Tiền Bảo hành, tiền Nội bộ thanh toán
        V_T_CK_BH(New System.Object, New System.EventArgs)
        V_T_CK_NB(New System.Object, New System.EventArgs)
        V_T_CK_WH(New System.Object, New System.EventArgs)
        'End 2019.07.07: Tính lưu cho tiền bảo hiểm, Tiền Bảo hành, tiền Nội bộ thanh toán
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        'V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        V_Chk_BH(sender, e)
        V_Chk_CV(sender, e)
        V_Chk_VT(sender, e)
        ''----------------------------------------------------------------------------------------------------------------------
        ''----------------------------------------------------------------------------------------------------------------------
        If Not Add2Database() Then Return
        '----------------------------------------------------------------------------------------------------------------------
        V_SaveMa_KTV_S()
        '----------------------------------------------------------------------------------------------------------------------
        Dim _M_Mode_Luu As String = M_Mode.Trim.ToUpper
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        '----------------------------------------------------------------------------------------------------------------------
        If SysvarRO("M_UP_BH_XE").ToString.Trim = "1" And M_Ma_CT.Trim.ToUpper = "HDK" And TxtMa_Xe.Text.Trim <> "" Then
            If CbbMa_Post.SelectedValue.ToString.Trim = "2" And _M_Mode_Luu = "M" Then V_Thamsobaohiem(M_Ma_CT, TxtMa_Xe.Text, TxtTen_kh.Text, TxtDia_Chi.Text, TxtDien_Thoai.Text, TxtDt_LX.Text)
        End If
        '----------------------------------------------------------------------------------------------------------------------
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
        nCount = Dt_DetailCvTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailCvTmp.Rows(iRow).Item("Ma_Cv").ToString.Trim = "" Then
                Dt_DetailCvTmp.Rows(iRow).Delete()
                Dt_DetailCvTmp.AcceptChanges()
            End If
        Next
        UpdateList()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailTmp.Columns.Contains("So_BG") Then Dt_DetailTmp.Rows(iRow).Item("So_BG") = TxtSo_BG.Text
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value

            If Dt_DetailTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_GD") Then Dt_DetailTmp.Rows(iRow).Item("Ma_GD") = CbbMa_GD.SelectedValue.ToString.Trim

            If Dt_DetailTmp.Columns.Contains("MA_HD_I") Then If Not TxtMa_HD_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_HD_I") = TxtMa_HD_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("MA_BP_I") Then If Not TxtMa_Bp_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_BP_I") = TxtMa_Bp_H.Text.Trim
            If Dt_DetailTmp.Columns.Contains("MA_HS_I") Then If Not TxtMa_Hs_H.Text.Trim = "" Then Dt_DetailTmp.Rows(iRow).Item("MA_HS_I") = TxtMa_Hs_H.Text.Trim

            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailCvTmp.Columns.Contains("So_BG") Then Dt_DetailCvTmp.Rows(iRow).Item("So_BG") = TxtSo_BG.Text
            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value

            If Dt_DetailCvTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_GD") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_GD") = CbbMa_GD.SelectedValue.ToString.Trim

            If Dt_DetailCvTmp.Columns.Contains("MA_HD_I") Then If Not TxtMa_HD_H.Text.Trim = "" Then Dt_DetailCvTmp.Rows(iRow).Item("MA_HD_I") = TxtMa_HD_H.Text.Trim
            If Dt_DetailCvTmp.Columns.Contains("MA_BP_I") Then If Not TxtMa_Bp_H.Text.Trim = "" Then Dt_DetailCvTmp.Rows(iRow).Item("MA_BP_I") = TxtMa_Bp_H.Text.Trim
            If Dt_DetailCvTmp.Columns.Contains("MA_HS_I") Then If Not TxtMa_Hs_H.Text.Trim = "" Then Dt_DetailCvTmp.Rows(iRow).Item("MA_HS_I") = TxtMa_Hs_H.Text.Trim

            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)
        Next
        Dt_DetailCvTmp.AcceptChanges()
        '---------------------------------------------------------------------------------
        If Dt_DetailTmp.Rows.Count < 1 And Dt_DetailCvTmp.Rows.Count < 1 Then
            MsgBox("bạn chưa nhập chi tiết!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            Return False
        End If
        '---------------------------------------------------------------------------------
        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        '-----------------------------------------------------------------------------------------------------
        '----Ph89
        Dim _DtPH89 As DataTable = DtPH89stru.Clone
        Dim _DrPh89 As DataRow = _DtPH89.NewRow
        _DrPh89.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrPh89)
        CyberSmodb.AddValueToRow(_DrPh89, Me)
        If DtPH89stru.Columns.Contains("Stt_Rec") Then _DrPh89.Item("Stt_Rec") = M_Stt_Rec
        If DtPH89stru.Columns.Contains("Ma_Ct") Then _DrPh89.Item("Ma_Ct") = M_Ma_CT
        If DtPH89stru.Columns.Contains("Ma_Dvcs") Then _DrPh89.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrPh89.EndEdit()
        _DtPH89.Rows.Add(_DrPh89)
        _DtPH89.AcceptChanges()
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
        '----Ph89Xe
        Dim _DtPh89Xe As DataTable = DtPH89Xestru.Clone
        Dim _DrPh89Xe As DataRow = _DtPh89Xe.NewRow
        _DrPh89Xe.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrPh89Xe)
        CyberSmodb.AddValueToRow(_DrPh89Xe, Me)
        If DtPH89Xestru.Columns.Contains("Stt_Rec") Then _DrPh89Xe.Item("Stt_Rec") = M_Stt_Rec
        If DtPH89Xestru.Columns.Contains("Ma_Ct") Then _DrPh89Xe.Item("Ma_Ct") = M_Ma_CT
        If DtPH89Xestru.Columns.Contains("Ma_Dvcs") Then _DrPh89Xe.Item("Ma_Dvcs") = TxtMa_Dvcs.Text
        _DrPh89Xe.EndEdit()
        _DtPh89Xe.Rows.Add(_DrPh89Xe)
        _DtPh89Xe.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim DsTmpSave As DataSet = CyberSmodb.V_ChkAndSaveVoucher(Mode, M_Stt_Rec, M_Ma_CT, _Ngay_Ct, TxtMa_Dvcs.Text, M_User_Name, {"PH89", "CT89", "CTGT40", "DmXe", "PH89Xe"}, {_DtPH89, Dt_DetailTmp, Dt_DetailCvTmp, _DtDmxeXe, _DtPh89Xe}, AppConn, osysvar, M_LAN, "CP_ChkAndSaveVoucherHDP", CyberSmlib, CyberSupport)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmpSave.Tables(0), osysvar, M_LAN)
        If Not _Return Then
            DsTmpSave.Dispose()
            Return False
        End If

        If DsTmpSave.Tables(0).Columns.Contains("Ngay_CT") Then TxtNgay_Ct.Value = DsTmpSave.Tables(0).Rows(0).Item("Ngay_CT")
        If DsTmpSave.Tables(0).Columns.Contains("Ngay_LCT") Then TxtNgay_LCt.Value = DsTmpSave.Tables(0).Rows(0).Item("Ngay_LCT")
        If DsTmpSave.Tables(0).Columns.Contains("Ma_Post") Then
            Try
                CbbMa_Post.SelectedValue = DsTmpSave.Tables(0).Rows(0).Item("Ma_Post").ToString.Trim
            Catch ex As Exception
            End Try
        End If

        If DsTmpSave.Tables(0).Columns.Contains("So_RO") Then TxtSo_Ro.Text = DsTmpSave.Tables(0).Rows(0).Item("So_Ro").ToString.Trim
        If DsTmpSave.Tables(0).Columns.Contains("So_RO_Hang") Then TxtSo_Ro_Hang.Text = DsTmpSave.Tables(0).Rows(0).Item("So_RO_Hang").ToString.Trim
        If DsTmpSave.Tables(0).Columns.Contains("So_BG") Then TxtSo_BG.Text = DsTmpSave.Tables(0).Rows(0).Item("So_BG").ToString.Trim


        If DsTmpSave.Tables(0).Columns.Contains("Gio_NT") Then TxtGio_NT.Text = DsTmpSave.Tables(0).Rows(0).Item("Gio_NT").ToString.Trim
        If DsTmpSave.Tables(0).Columns.Contains("Ngay_NT") Then TxtNgay_NT.Value = DsTmpSave.Tables(0).Rows(0).Item("Ngay_NT")

        If DsTmpSave.Tables(0).Columns.Contains("Gio_BD") Then TxtGio_BD.Text = DsTmpSave.Tables(0).Rows(0).Item("Gio_BD").ToString.Trim
        If DsTmpSave.Tables(0).Columns.Contains("Gio_KT") Then TxtGio_KT.Text = DsTmpSave.Tables(0).Rows(0).Item("Gio_KT").ToString.Trim
        If DsTmpSave.Tables(0).Columns.Contains("Ngay_KT") Then TxtNgay_KT.Value = DsTmpSave.Tables(0).Rows(0).Item("Ngay_KT")
        If DsTmpSave.Tables(0).Columns.Contains("Gio_HenKT") Then TxtGio_HenKT.Text = DsTmpSave.Tables(0).Rows(0).Item("Gio_HenKT").ToString.Trim


        If DsTmpSave.Tables(0).Columns.Contains("TE") Then CHKTE.Checked = (DsTmpSave.Tables(0).Rows(0).Item("TE").ToString.Trim = "1")
        If DsTmpSave.Tables(0).Columns.Contains("TL") Then ChkTL.Checked = (DsTmpSave.Tables(0).Rows(0).Item("TL").ToString.Trim = "1")
        If DsTmpSave.Tables(0).Columns.Contains("TA") Then ChkTA.Checked = (DsTmpSave.Tables(0).Rows(0).Item("TA").ToString.Trim = "1")

        '--Update vao chi tiet
        For j As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(j).BeginEdit()
            If Dt_DetailTmp.Columns.Contains("So_Ro") Then Dt_DetailTmp.Rows(j).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailTmp.Columns.Contains("So_BG") Then Dt_DetailTmp.Rows(j).Item("So_BG") = TxtSo_BG.Text
            If Dt_DetailTmp.Columns.Contains("Ngay_Ct") Then Dt_DetailTmp.Rows(j).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailTmp.Columns.Contains("Ngay_LCt") Then Dt_DetailTmp.Rows(j).Item("Ngay_LCt") = TxtNgay_LCt.Value

            If Dt_DetailTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailTmp.Rows(j).Item("Ma_Dvcs") = TxtMa_Dvcs.Text
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(j).Item("Ma_Post") = CbbMa_Post.SelectedValue
            Dt_DetailTmp.Rows(j).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()
        For j As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(j).BeginEdit()
            If Dt_DetailCvTmp.Columns.Contains("So_Ro") Then Dt_DetailCvTmp.Rows(j).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailCvTmp.Columns.Contains("So_BG") Then Dt_DetailCvTmp.Rows(j).Item("So_BG") = TxtSo_BG.Text
            If Dt_DetailCvTmp.Columns.Contains("Ngay_Ct") Then Dt_DetailCvTmp.Rows(j).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailCvTmp.Columns.Contains("Ngay_LCt") Then Dt_DetailCvTmp.Rows(j).Item("Ngay_LCt") = TxtNgay_LCt.Value

            If Dt_DetailCvTmp.Columns.Contains("Ma_Dvcs") Then Dt_DetailCvTmp.Rows(j).Item("Ma_Dvcs") = TxtMa_Dvcs.Text
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(j).Item("Ma_Post") = CbbMa_Post.SelectedValue
            Dt_DetailCvTmp.Rows(j).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges()
        '-------------------------------------------------------------------------------------------------------------------------
        '----Lan sua chua
        For iRow As Integer = 0 To DsTmpSave.Tables(1).Rows.Count - 1
            For j As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
                If DsTmpSave.Tables(1).Rows(iRow).Item("Stt_Rec0").ToString = Dt_DetailTmp.Rows(j).Item("Stt_Rec0").ToString Then
                    Dt_DetailTmp.Rows(j).BeginEdit()
                    Dt_DetailTmp.Rows(j).Item("lan") = DsTmpSave.Tables(1).Rows(iRow).Item("Lan")
                    Dt_DetailTmp.Rows(j).EndEdit()
                    Exit For
                End If
            Next
        Next
        Dt_DetailTmp.AcceptChanges()
        For iRow As Integer = 0 To DsTmpSave.Tables(2).Rows.Count - 1
            For j As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
                If DsTmpSave.Tables(2).Rows(iRow).Item("Stt_Rec0").ToString = Dt_DetailCvTmp.Rows(j).Item("Stt_Rec0").ToString Then
                    Dt_DetailCvTmp.Rows(j).BeginEdit()
                    Dt_DetailCvTmp.Rows(j).Item("lan") = DsTmpSave.Tables(2).Rows(iRow).Item("Lan")
                    Dt_DetailCvTmp.Rows(j).EndEdit()
                    Exit For
                End If
            Next
        Next
        Dt_DetailCvTmp.AcceptChanges()
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
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next

        Return True
    End Function
    Private Sub V_Thamsobaohiem(ByVal _ma_Ct As String, ByVal _Ma_Xe As String, ByVal _Ten_kh As String, ByVal _Dia_Chi As String, ByVal _Dien_Thoai As String, ByVal _DT_Lx As String)
        ''If Not (M_Ma_CT = "HDK") Then Exit Sub
        Dim dsBaohiem As DataSet
        'dsBaohiem = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetNgayBH", M_Ma_CT.Trim + "#" + TxtMa_Xe.Text + "#" + TxtTen_kh.Text + "#" + TxtDia_Chi.Text + "#" + TxtDien_Thoai.Text + "#" + TxtDt_LX.Text)
        dsBaohiem = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetNgayBH", _ma_Ct.Trim + "#" + _Ma_Xe.Trim + "#" + _Ten_kh.Trim + "#" + _Dia_Chi.Trim + "#" + _Dien_Thoai.Trim + "#" + _DT_Lx.Trim)

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
    Private Function ChkSaveDelete(ByVal _Mode As String, Optional ByVal strField As String = "", Optional ByVal strValue As String = "") As Boolean

        Dim _Ma_Xe = TxtMa_Xe.Text.Trim
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        If strField.Trim = "" And strValue.Trim = "" Then CyberSmodb.GetValueControler(Me, strField, strValue)

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkSaveDeleter" & M_Ma_CT.Trim, strField & "#" & strValue & "#" & _Ma_Xe & "#" & _
                                                                  _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT & "#" & _
                                                                  TxtSo_Ro.Text.Trim.Replace("#", "") & "#" & TxtSo_BG.Text.Trim.Replace("#", "") & "#" & _
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
        If _Mode = "S" And CbbMa_Post.SelectedValue.ToString.Trim <> "1" Then
            If Not ChkDetailHDK(strField, strValue) Then
                Dstmp.Dispose()
                Return False
            End If
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------
        If _Mode.Trim = "M" And Dstmp.Tables(0).Columns.Contains("So_RO") Then TxtSo_Ro.Text = Dstmp.Tables(0).Rows(0).Item("So_RO").ToString.Trim
        If _Mode.Trim = "M" And Dstmp.Tables(0).Columns.Contains("So_BG") Then TxtSo_BG.Text = Dstmp.Tables(0).Rows(0).Item("So_BG").ToString.Trim
        If _Mode.Trim = "M" And Dstmp.Tables(0).Columns.Contains("So_Ro_Hang") Then TxtSo_Ro_Hang.Text = Dstmp.Tables(0).Rows(0).Item("So_Ro_Hang").ToString.Trim
        Dstmp.Dispose()
        '--------------------------------------------------------------------------------------------------------------------------------------------
        For iRow As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        For iRow As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.BeginInit()
            Dt_DetailCvTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            Dt_DetailCvTmp.Rows(iRow).EndEdit()
        Next
        '--------------------------------------------------------------------------------------------------------------------------------------------
        ChkSaveDelete = True
    End Function
    Function ChkDetailHDK(ByVal _strField As String, ByVal _strValue As String) As Boolean
        Dim nCountVt, nCountCv, i As Integer
        Dim strCVMa_CV As String = ""
        Dim strCVMa_TT As String = ""
        Dim strCVTien_CV As String = ""
        Dim strCVCK_CV As String = ""
        Dim strCVThue_CV As String = ""
        Dim strCVTien_BH_CV As String = ""
        Dim strCVThue_BH_CV As String = ""

        Dim strVTMa_Vt As String = ""
        Dim strVTMa_Kho As String = ""
        Dim strVTMa_TT As String = ""
        Dim strVTSo_luong As String = ""
        Dim strVTGia2 As String = ""
        Dim strVTTien2 As String = ""
        Dim strVTCK_VT As String = ""
        Dim strVTThue_VT As String = ""
        Dim strVTTien_BH_VT As String = ""
        Dim strVTThue_BH_VT As String = ""

        If _strField.Trim = "" And _strValue.Trim = "" Then CyberSmodb.GetValueControler(Me, _strField, _strValue)

        nCountCv = Dt_DetailCvTmp.Rows.Count
        nCountVt = Dt_DetailTmp.Rows.Count
        For i = 0 To nCountCv - 1
            strCVMa_CV = strCVMa_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Ma_CV").ToString.Trim
            strCVMa_TT = strCVMa_TT + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Ma_TT").ToString.Trim
            strCVTien_CV = strCVTien_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Tien_CV").ToString.Trim.Replace(",", "").Replace(" ", "")
            strCVCK_CV = strCVCK_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("CK_I").ToString.Trim.Replace(",", "").Replace(" ", "")
            strCVThue_CV = strCVThue_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Thue").ToString.Trim.Replace(",", "").Replace(" ", "")
            strCVTien_BH_CV = strCVTien_BH_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Tien_BH").ToString.Trim.Replace(",", "").Replace(" ", "")
            strCVThue_BH_CV = strCVThue_BH_CV + IIf(i = 0, "", "!~!") & Dt_DetailCvTmp.Rows(i).Item("Thue_BH").ToString.Trim.Replace(",", "").Replace(" ", "")
        Next
        For i = 0 To nCountVt - 1
            strVTMa_Vt = strVTMa_Vt + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Ma_Vt").ToString.Trim
            strVTMa_Kho = strVTMa_Kho + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Ma_Kho_I").ToString.Trim
            strVTMa_TT = strVTMa_TT + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Ma_TT").ToString.Trim
            strVTSo_luong = strVTSo_luong + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("So_luong").ToString.Trim
            strVTGia2 = strVTGia2 + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Gia2").ToString.Trim
            strVTTien2 = strVTTien2 + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Tien2").ToString.Trim
            strVTCK_VT = strVTCK_VT + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("CK_I").ToString.Trim
            strVTThue_VT = strVTThue_VT + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Thue").ToString.Trim
            strVTTien_BH_VT = strVTTien_BH_VT + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Tien_BH").ToString.Trim
            strVTThue_BH_VT = strVTThue_BH_VT + IIf(i = 0, "", "!~!") & Dt_DetailTmp.Rows(i).Item("Thue_BH").ToString.Trim
        Next

        Dim DstmChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkDetailHDK", M_Ma_CT & "#" & M_Stt_Rec & "#" & M_Mode & "#" & M_Ma_GD & "#" & CbbMa_Post.SelectedValue.ToString.Trim & "#" & TxtSo_Ro.Text & "#" & _strField & "#" & _strValue & "#" & _
        nCountVt.ToString.Trim.Replace(" ", "") & "#" & nCountCv.ToString.Trim.Replace(" ", "") & "#" & strCVMa_CV & "#" & strCVMa_TT & "#" & strCVTien_CV & "#" & strCVCK_CV & "#" & strCVThue_CV & "#" & strCVTien_BH_CV & "#" & strCVThue_BH_CV & "#" & _
        strVTMa_Vt & "#" & strVTMa_Kho & "#" & strVTMa_TT & "#" & strVTSo_luong & "#" & strVTGia2 & "#" & strVTTien2 & "#" & strVTCK_VT & "#" & strVTThue_VT & "#" & strVTTien_BH_VT & "#" & strVTThue_BH_VT & "#" & _
        M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(DstmChk.Tables(0), SysVar, M_LAN) Then
            DstmChk.Dispose()
            ChkDetailHDK = False
            Exit Function
        End If
        DstmChk.Dispose()
        ChkDetailHDK = True
    End Function
    Private Sub UpdateLanSuaChua(ByVal tbname As DataTable, ByVal tbname1 As DataTable, ByVal M_Mode As String)
        Dim dstmpLan As New DataSet
        Dim Lan As Integer = 0
        Dim iRow As Integer
        dstmpLan = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetRoLanBS", M_Mode.Trim + "#" + M_Ma_CT.Trim + "#" + M_Stt_Rec.Trim + "#" + M_User_Name.Trim)
        Lan = dstmpLan.Tables(0).Rows(0).Item("Lan")
        dstmpLan.Dispose()

        iRow = tbname.Rows.Count
        For i = 0 To iRow - 1
            If tbname.Rows(i).Item("Lan") = 0 Then
                tbname.Rows(i).BeginEdit()
                tbname.Rows(i).Item("Lan") = Lan
                tbname.Rows(i).EndEdit()
                tbname.AcceptChanges()
            End If
        Next
        iRow = tbname1.Rows.Count
        For i = 0 To iRow - 1
            If tbname1.Rows(i).Item("Lan") = 0 Then
                tbname1.Rows(i).BeginEdit()
                tbname1.Rows(i).Item("Lan") = Lan
                tbname1.Rows(i).EndEdit()
                tbname1.AcceptChanges()
            End If
        Next
    End Sub
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
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp}, {M_Ct, M_Ph, "CTGT40"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)

        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL

        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        ''V_CyberSaveToSQL()

        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")

        '' CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''  CyberVoucher.V_SaveRoToDmxe(AppConn, drMaster, M_Mode, M_Ma_CT, M_Stt_Rec, M_User_Name, osysvar)
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
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL

        CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'V_CyberSaveToSQL()

        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")

        ' CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '  CyberVoucher.V_SaveRoToDmxe(AppConn, drMaster, M_Mode, M_Ma_CT, M_Stt_Rec, M_User_Name, osysvar)
    End Sub
    Private Sub V_Thamsobaohiem_LUU()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not (M_Mode = "M") Then Exit Sub
        If Not (M_Ma_CT = "HDK") Then Exit Sub

        If CbbMa_Post.SelectedValue.ToString.Trim <> "2" Then Exit Sub
        Dim dsBaohiem As DataSet
        dsBaohiem = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetNgayBH", M_Ma_CT.Trim + "#" + TxtMa_Xe.Text + "#" + TxtTen_kh.Text + "#" + TxtDia_Chi.Text + "#" + TxtDien_Thoai.Text + "#" + TxtDt_LX.Text)
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
        Frm.ShowDialog()
        dsBaohiem.Dispose()
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub
        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)
        Dim M_So_Bg As String = ""
        M_So_Bg = TxtSo_BG.Text.Trim
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
        '------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(iRow).Item("Lan") = 1
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        '------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Tinh_Gia2(iRow)
            Tinh_TienPT(iRow)
        Next
        '------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).BeginEdit()
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailCvTmp.Rows(iRow).Item("Lan") = 1
            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailCvTmp.Rows(iRow).EndEdit()
        Next

        TxtSo_Ro.Text = ""
        TxtSo_BG.Text = ""

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        txtSo_ct.Text = _So_Ct_Copy.Trim
        txtStt_rec_Ra.Text = ""
        txtStt_Rec_TD.Text = ""


        V_GetNgamDinhCopy()

        TxtNgay_NT.Value = New Date(1900, 1, 1)
        TxtGio_NT.Text = ""
        TxtNgay_Gx.Value = New Date(1900, 1, 1)

        'TxtGio_BD.Text = Strings.Right("00" + Now.Hour.ToString.Trim, 2) + Strings.Right("00" + Now.Minute.ToString.Trim, 2)
        'TxtGio_KT.Text = Strings.Right("00" + Now.AddHours(2).Hour.ToString.Trim, 2) + Strings.Right("00" + Now.Minute.ToString.Trim, 2)
        'TxtGio_HenKT.Text = Strings.Right("00" + Now.AddHours(2).Hour.ToString.Trim, 2) + Strings.Right("00" + Now.AddMinutes(15).Minute.ToString.Trim, 2)

        'TxtNgay_KT.Value = Now.Date
        'TxtNgay_NT.Value = Now.Date

        M_Mode = "M"
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_GetNgamDinhCopy()
        '----------------------------------------------------------------------------
        TxtGio_BD.Text = CyberVoucher.V_GetTG("", 0)
        TxtGio_KT.Text = CyberVoucher.V_GetTG(TxtGio_BD.Text, 120)
        TxtGio_NT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 5)
        TxtGio_HenKT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 15)
        '----------------------------------------------------------------------------
        TxtNgay_KT.Value = Now.Date
        TxtNgay_NT.Value = Now.Date
        CbbMa_Post.SelectedValue = "2"
        '----------------------------------------------------------------------------
        'If M_Ma_TP_Ngam_Dinh.Trim <> "" Then
        '    Try
        '        CmbMa_TP.SelectedValue = M_Ma_TP_Ngam_Dinh
        '    Catch ex As Exception
        '    End Try
        'End If
        'If M_Ma_Quan_Ngam_Dinh.Trim <> "" Then
        '    Try
        '        CmbMa_Quan.SelectedValue = M_Ma_Quan_Ngam_Dinh
        '    Catch ex As Exception
        '    End Try
        'End If
        'If M_Ma_Xa_Ngam_Dinh.Trim <> "" Then
        '    Try
        '        CmbMa_Xa.SelectedValue = M_Ma_Xa_Ngam_Dinh
        '    Catch ex As Exception
        '    End Try
        'End If

        'Try
        '    CmbVai_Tro.SelectedValue = M_Vai_Tro_Ngam_Dinh
        'Catch ex As Exception
        'End Try
        'Try
        '    CmbMa_HTLL.SelectedValue = M_Ma_HTLL_Ngam_Dinh
        'Catch ex As Exception
        'End Try
        '----------------------------------------------------------------------------
        TxtMa_Hs_H.Text = M_Ma_Hs
        TxtTen_Hs_H.Text = M_Ten_Hs
        TxtMa_Bp_H.Text = M_Ma_BP
        TxtTen_Bp_H.Text = M_Ten_BP
        '----------------------------------------------------------------------------
    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)
        M_Mode = "M"
        V_Databing()
        '----------------------------------------------------------------------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If txtDien_giai.Text.Trim = "" Then txtDien_giai.Text = M_Dien_Giai
        TxtNgay_Ct.Value = Now.Date
        TxtNgay_LCt.Value = Now.Date
        TxtMa_NT.Text = M_Ma_Nt
        If txtDien_giai.Text = "" And M_Ma_CT = "HDM" Then txtDien_giai.Text = "Lắp phụ kiện"
        '----------------------------------------------------------------------------
        V_New()

        '----------------------------------------------------------------------------
        V_GetNgamDinh()
        TxtNgay_NT.Value = New Date(1900, 1, 1)
        TxtNgay_Gx.Value = New Date(1900, 1, 1)
        TxtGio_NT.Text = ""
        '----------------------------------------------------------------------------
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        TxtMa_Xe.Select()
        '----------------------------------------------------------------------------
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
        '----------------------------------------------------------------------------

    End Sub
    Private Sub V_GetNgamDinh()
        '----------------------------------------------------------------------------
        TxtGio_BD.Text = CyberVoucher.V_GetTG("", 0)
        TxtGio_KT.Text = CyberVoucher.V_GetTG(TxtGio_BD.Text, 120)
        TxtGio_NT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 5)
        TxtGio_HenKT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 15)
        '----------------------------------------------------------------------------
        TxtNgay_KT.Value = Now.Date
        TxtNgay_NT.Value = Now.Date
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
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Stt_Rec0") = "001"
            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If
        If Dt_DetailCvTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailCvTmp.NewRow()
            DrCurren = Dt_DetailCvTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Stt_Rec0") = "001"
            Dt_DetailCvTmp.Rows.Add(DrCurren)
            Dt_DetailCvTmp.AcceptChanges()
        End If
    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        '---Refresh rồi với sửa: 2019.05.12 --  Begin
        V_ShortRefresh(sender, e)
        '---Refresh rồi với sửa: 2019.05.12 -- End

        M_Mode = "S"
        V_SetEnabled(Me, M_Mode, Dt_Master)
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
        CyberSupport.V_DeleteTableVoucher(Dt_DetailCv, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        V_SetEnabled(Me, M_Mode, Dt_Master)
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
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        'M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        M_Stt_Rec = CyberFrom.V_ViewVoucher2(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, Dv_DetailCv, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub

        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        'If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher2(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, Dv_DetailCv, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)

        V_Databing()
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

        M_Mode = "X"
        V_SetEnabled(Me, M_Mode, Dt_Master)
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
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
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
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailTmp
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVVt, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Add Or Detete Item Cong Viec"
    Private Sub MasterGRVCv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCv(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemCv(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailCvTmp
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCv(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Addon"
    'V_Nghiemthu
    Private Sub V_Nghiemthu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If CbbMa_Post.SelectedValue.ToString.Trim = "1" Then Exit Sub
        Dim Dt_Return As DataTable = CyberSupport.V_Nghiem_Thu(AppConn, SysVar, M_Para, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, False, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading)
        If Dt_Return Is Nothing Then Return
        If Dt_Return.Rows.Count = 0 Then Return
        CyberSmodb.SetValueTObj_1(Me, Dt_Return.Rows(0)) '----Chi set Những trường có dữ liệu
        Dim CrrRow As Integer = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
        If CrrRow < 0 Then Return
        CyberSmodb.V_UpdateRowtoRow(Dt_Return.Rows(0), Dt_Master, CrrRow)

    End Sub
#End Region
#Region "Cài đặt thêm menu "
    Protected Overrides Sub AddCustomMenu_Header()
        'Dim MenuSua_Xong As New Cyber.SmLib.CyberMenuPopup(Nothing, 0, IIf(Lan = "V", "Thông tin Sổ kho11111", ""), Nothing, Nothing, True, False)
        'MyBase.PopupMenuMaster.AddItem(MenuSua_Xong)
        'V_CreateMenuContext("Minh", AddressOf V_Test, Nothing)
        MyBase.AddCustomMenu_Header()

        V_CreateMenuContext("Xem phiếu xuất", AddressOf V_XemPhieuXuat, Nothing)
        V_CreateMenuContext("Xem lịch sửa sửa chữa", AddressOf V_Lich_Su, Nothing)
        V_CreateMenuContext("Đặt lịch hẹn", AddressOf V_Dat_Lich, Nothing)

        V_CreateMenuContext("Xem Sửa xong", AddressOf V_Xemsuahuaxong, Nothing)
        V_CreateMenuContext("Xem Chờ sửa chữa", AddressOf V_XemChosuahua, Nothing)
    End Sub 'MINHDC
#End Region
#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVVt, Dt_DetailTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_ImportCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVCv, Dt_DetailCvTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailCvTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailCvTmp.AcceptChanges()
    End Sub
    Private Sub SetTxt()
        'TxtTen_kh.ReadOnly = True
        TxtSo_Ro.ReadOnly = True
        TxtSo_BG.ReadOnly = True

        If M_Mode = "S" Then TxtMa_Xe.Enabled = False Else TxtMa_Xe.Enabled = True

        TxtT_CV.ReadOnly = True
        TxtT_CK_CV.ReadOnly = True
        TxtT_Thue_CV.ReadOnly = True
        TxtT_TT_CV.ReadOnly = True

        TxtT_Tien2.ReadOnly = True
        TxtT_CK_VT.ReadOnly = True
        TxtT_Thue_VT.ReadOnly = True
        TxtT_TT_VT.ReadOnly = True

        TxtT_I.ReadOnly = True
        TxtT_W.ReadOnly = True
        TxtT_N.ReadOnly = True
        TxtT_C.ReadOnly = True
        TxtT_TT.ReadOnly = True
        TxtTen_Hd_H.ReadOnly = True
        TxtTen_Hs_H.ReadOnly = True
        TxtTen_Hs_H.ReadOnly = True

        If M_Mode = "M" Or M_Mode = "S" Then
            If ChkCV.Checked Then TxtT_CK_CV.ReadOnly = False
            If ChkVT.Checked Then TxtT_CK_VT.ReadOnly = False
            If ChkBH.Checked Then TxtT_I.ReadOnly = False

            If ChkBH.Checked Then TxtT_I.ReadOnly = False
            '---------------Begin 2019.07.07
            If ChkNB.Checked Then TxtT_N.ReadOnly = False
            If ChkWH.Checked Then TxtT_W.ReadOnly = False
            '---------------End 2019.07.07

        End If

        '---Dieu chinh
        TxtT_DC_CV.ReadOnly = True
        TxtT_DC_VT.ReadOnly = True

        Me.Bar_Approval.Enabled = False

    End Sub
#End Region
#Region "Môi giới/Hoa hồng bảo hiểm/Đặt cọc"
    Private Sub V_PT_Moi_Gioi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtPT_Moi_Gioi.Double = 0 Then Return
        TxtMoi_Gioi.Double = CyberSupport.V_Round(TxtT_C.Double * TxtPT_Moi_Gioi.Double / 100, 0)

    End Sub
    Private Sub V_PT_HH_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtPT_HH_BH.Double = 0 Then Return
        TxtHH_BH.Double = CyberSupport.V_Round(TxtT_I.Double * TxtPT_HH_BH.Double / 100, 0)
    End Sub
    Private Sub V_PT_Dat_Coc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtPT_Dat_Coc.Double = 0 Then Return
        TxtDat_Coc.Double = CyberSupport.V_Round(TxtT_C.Double * TxtPT_Dat_Coc.Double / 100, 0)

    End Sub
#End Region
#Region "Tich diem"
    Private Sub V_Diem_Tich_Luy()
        ''If (Not M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Return
        If TxtMa_Xe.Text = "" Then
            TxtDiem_Luy_Ke.Double = 0
            TxtDiem_Ro.Double = 0
            Return
        End If
        Dim _Dt As DataTable = CyberSupport.V_Diem_Tich_Luy(AppConn, TxtMa_Xe.Text, "", TxtSo_Ro.Text, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        TxtDiem_Luy_Ke.Double = 0
        TxtDiem_Ro.Double = 0
        If Not _Dt Is Nothing Then If _Dt.Rows.Count > 0 And _Dt.Columns.Contains("Diem_Ro") Then TxtDiem_Ro.Double = _Dt.Rows(0).Item("Diem_Ro")
        If Not _Dt Is Nothing Then If _Dt.Rows.Count > 0 And _Dt.Columns.Contains("Diem_Luy_Ke") Then TxtDiem_Luy_Ke.Double = _Dt.Rows(0).Item("Diem_Luy_Ke")
    End Sub
    Private Sub V_Tra_Cuu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_Tra_Cuu_Diem(AppConn, Me.Para, osysvar, M_LAN, M_Ma_Dvcs, M_User_Name, TxtMa_Xe.Text, CyberSmlib, CyberFill, CyberSupport, CyberSmodb, CyberSmlistSys, CyberLoading)
    End Sub
#End Region
#Region "Tạo điều chuyển"
    Dim ProccessList As New Collection
    Private Sub V_Tao_Dieu_Chuyen()
        Dim _So_ro As String = TxtSo_Ro.Text.Trim
        If _So_ro = "" Then Exit Sub
        Dim strAddParar As String = "4#PXE#10#0208#0201#" + _So_ro + "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "E Mail And Approval/Print Ho so"
    '----------------------------------------------------------------------------------------------------------
    Private Sub V_In_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Mode = "M" Or M_Mode = "S" Then Return
        If M_Stt_Rec.Trim = "" Then Return
        Dim _Stt_Rec0 As String = ""
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.FocusedRowHandle
        If iRow >= 0 Then _Stt_Rec0 = Dv_DetailTmp.Item(iRow).Item("Stt_Rec0")
        If iRow < 0 Then
            iRow = DetailGRVCv.FocusedRowHandle
            _Stt_Rec0 = Dv_DetailCvTmp.Item(iRow).Item("Stt_Rec0")
        End If

        CyberVoucher.V_PrintVoucherAll(AppConn, osysvar, M_Ma_CT, M_Stt_Rec, _Stt_Rec0, M_LAN, Me.Para, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    'Private Sub KillProce()
    '    Try
    '        Dim op As Process
    '        For i As Integer = ProccessList.Count To 1 Step -1
    '            op = ProccessList(i)
    '            If Not op Is Nothing Then
    '                If Not op.HasExited() Then
    '                    op.Kill()
    '                    ProccessList.Remove(i)
    '                End If
    '            End If
    '        Next
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    KillProce()
    'End Sub
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
