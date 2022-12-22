Imports System.Windows.Forms
Public Class DMTS
    '==============================================
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbCtdmts, tbCtPtts, tbCTPB As New DataTable
    Dim DvCtdmts, DvCtPtts, DvCTPB As New DataView
    Dim DvNvH, DvHTH, DvTTH, DvPTH, DvPB As New DataView
    '==============================================
    Dim Ma_tsOld, Ma_DvcsOld As String
    Dim T_Nguyen_Gia, T_Gt_Da_Kh, T_GT_CL, T_Gt_kh_Ky As Decimal
    '===============================================
    Dim EditNVMa_NV, EditNVMa_Tang, EditNVGt_da_kh, EditNVGt_kh_ky, EditNVNguyen_gia, EditNVGt_Cl, EditNVThang_Kh, EditNVNgay_Tang, EditNVNgay_kh, EditMa_giam, EditStt_Rec0, EditNVTk_co, EditNVTk_no As New Cyber.Fill.CyberColumnGridView

    Dim EditNVMa_phi, EditNVMa_vv, EditNVMa_hd, EditNVMa_sp, EditNVMa_KU, _
        EditNVMa_TTLN, EditNVMa_TTCP, EditNVMa_Bp, EditNVMa_HS, EditNVMa_Cd, EditNVMa_Db, EditNVMa_Xe, EditNVMa_Kx, EditNVMa_Tuyen, _
        EditNVMa_TD1, EditNVMa_TD2, EditNVMa_TD3, EditNVMa_TD4, EditNVMa_TD5 As New Cyber.Fill.CyberColumnGridView
    'hieulv
    Dim EditMa_Bp, EditMa_phi, EditMa_Hd, EditTK As New Cyber.Fill.CyberColumnGridView

    Dim EditHTMa_NV, EditHTMa_Tang, EditHTMa_bpts, EditHTGt_da_kh, EditHTGt_kh_ky, EditHTNguyen_gia, EditHTTk_co, EditHTTk_no, _
        EditHTMa_phi, EditHTMa_vv, EditHTMa_hd, EditHTMa_sp, EditHTMa_KU, _
        EditHTMa_TTLN, EditHTMa_TTCP, EditHTMa_Bp, EditHTMa_HS, EditHTMa_Cd, EditHTMa_Db, EditHTMa_Xe, EditHTMa_Kx, EditHTMa_Tuyen, _
        EditHTMa_TD1, EditHTMa_TD2, EditHTMa_TD3, EditHTMa_TD4, EditHTMa_TD5 As New Cyber.Fill.CyberColumnGridView

    Dim EditTTMa_NV, EditTTMa_bpts, EditTTGt_Cl, EditTTNgay_Tang, EditTTNgay_kh, EditTTNguyen_gia As New Cyber.Fill.CyberColumnGridView
    Dim EditTinh_kh As New Cyber.Fill.CyberColumnGridView

    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        V_Load_Ctdmts(Mode, TxtMa_Ts.Text.Trim, TxtMa_Dvcs.Text.Trim)
        V_GetColumns()

        V_AddHandlerDetail()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_Ts.Focus()

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        'CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        If Mode = "M" Then
            Ma_tsOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_tsOld = TxtMa_Ts.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Ts, TxtNh_TS1, TxtNh_TS2, TxtNh_TS3, TxtNh_TS4, TxtNh_TS5)
        V_MenuNguonVon()
        V_MenuPhu_Tung()
        V_MenuPB()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTS", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TS1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTS", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TS2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTS", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TS3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTS", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TS4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTS", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TS5.Text.Trim + "')", CyberSmlib)

        Txtten_loai.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_loai", "Dmplts", "(Ma_loai = N'" + Txtma_loai.Text.Trim + "')", CyberSmlib)
        txtTen_Tk_Ts.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ts.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then Cmbloai_ts.SelectedValue = "1"
        If Me.Mode = "M" Then CbbLoai_KH.SelectedValue = "2"
        If Cmbloai_ts.Text.Trim = "" Then Cmbloai_ts.SelectedValue = "1"
        If CbbLoai_KH.Text.Trim = "" Then CbbLoai_KH.SelectedValue = "2"
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_loai
        RemoveHandler Txtma_loai.CyberValiting, AddressOf V_Ma_loai
        RemoveHandler Txtma_loai.CyberLeave, AddressOf L_Ma_loai
        AddHandler Txtma_loai.CyberValiting, AddressOf V_Ma_loai
        AddHandler Txtma_loai.CyberLeave, AddressOf L_Ma_loai
        '-- TK_ts
        RemoveHandler TxtTk_Ts.CyberValiting, AddressOf V_Tk_ts
        RemoveHandler TxtTk_Ts.CyberLeave, AddressOf L_Tk_ts
        AddHandler TxtTk_Ts.CyberValiting, AddressOf V_Tk_ts
        AddHandler TxtTk_Ts.CyberLeave, AddressOf L_Tk_ts
        '--TD11
        RemoveHandler TxtNh_TS1.CyberValiting, AddressOf V_Nh_TS1
        RemoveHandler TxtNh_TS1.CyberLeave, AddressOf L_Nh_TS1
        AddHandler TxtNh_TS1.CyberValiting, AddressOf V_Nh_TS1
        AddHandler TxtNh_TS1.CyberLeave, AddressOf L_Nh_TS1
        '--TD12
        RemoveHandler TxtNh_TS2.CyberValiting, AddressOf V_Nh_TS2
        RemoveHandler TxtNh_TS2.CyberLeave, AddressOf L_Nh_TS2
        AddHandler TxtNh_TS2.CyberValiting, AddressOf V_Nh_TS2
        AddHandler TxtNh_TS2.CyberLeave, AddressOf L_Nh_TS2
        '--TD13
        RemoveHandler TxtNh_TS3.CyberValiting, AddressOf V_Nh_TS3
        RemoveHandler TxtNh_TS3.CyberLeave, AddressOf L_Nh_TS3
        AddHandler TxtNh_TS3.CyberValiting, AddressOf V_Nh_TS3
        AddHandler TxtNh_TS3.CyberLeave, AddressOf L_Nh_TS3
        '--TD14
        RemoveHandler TxtNh_TS4.CyberValiting, AddressOf V_Nh_TS4
        RemoveHandler TxtNh_TS4.CyberLeave, AddressOf L_Nh_TS4
        AddHandler TxtNh_TS4.CyberValiting, AddressOf V_Nh_TS4
        AddHandler TxtNh_TS4.CyberLeave, AddressOf L_Nh_TS4
        '--TD15
        RemoveHandler TxtNh_TS5.CyberValiting, AddressOf V_Nh_TS5
        RemoveHandler TxtNh_TS5.CyberLeave, AddressOf L_Nh_TS5
        AddHandler TxtNh_TS5.CyberValiting, AddressOf V_Nh_TS5
        AddHandler TxtNh_TS5.CyberLeave, AddressOf L_Nh_TS5
        ' Enter dòng cuối
        AddHandler DetailGRVNguon_Von.KeyDown, AddressOf DetailGRVNguon_Von_KeyDown
        AddHandler DetailGRVPhu_tung_Ts.KeyDown, AddressOf DetailGRVPhu_tung_Ts_KeyDown
        AddHandler DetailGRVPB.KeyDown, AddressOf DetailGRVPB_KeyDown
    End Sub
    Private Sub V_AddHandlerDetail()
        'EditHTTk_no.V_ActiLookUpColumn(AddressOf V_HTTk_no, AddressOf L_HTTk_no)
        EditNVMa_NV.V_ActiLookUpColumn(AddressOf V_NVMa_NV, AddressOf L_NVMa_NV)
        EditNVMa_Tang.V_ActiLookUpColumn(AddressOf V_NVMa_Tang, AddressOf L_NVMa_Tang)
        If Not EditNVNguyen_gia.Column Is Nothing Then AddHandler EditNVNguyen_gia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditNVGt_da_kh.Column Is Nothing Then AddHandler EditNVGt_da_kh.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditNVGt_Cl.Column Is Nothing Then AddHandler EditNVGt_Cl.EditColumn.Leave, AddressOf L_Tinh_Toan
        EditNVGt_Cl.ColumnReadOnly = True
        EditNVGt_Cl.ColumnReadOnly = True

        If Not EditNVGt_kh_ky.Column Is Nothing Then AddHandler EditNVGt_kh_ky.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditNVThang_Kh.Column Is Nothing Then AddHandler EditNVThang_Kh.EditColumn.Leave, AddressOf L_Tinh_Toan

        EditNVNgay_Tang.ColumnReadOnly = False
        EditNVNgay_kh.ColumnReadOnly = False

        EditNVGt_da_kh.ColumnReadOnly = False

        EditNVGt_kh_ky.ColumnReadOnly = False
        EditNVGt_Cl.ColumnReadOnly = True

        '-----------------ABC
        EditNVMa_vv.V_ActiLookUpColumn(AddressOf V_NVMa_Vv, AddressOf L_NVMa_Vv)
        EditNVMa_phi.V_ActiLookUpColumn(AddressOf V_NVMa_phi, AddressOf L_NVMa_phi)
        EditNVMa_hd.V_ActiLookUpColumn(AddressOf V_NVMa_Hd, AddressOf L_NVMa_Hd)
        EditNVMa_sp.V_ActiLookUpColumn(AddressOf V_NVMa_Sp, AddressOf L_NVMa_Sp)
        EditNVMa_KU.V_ActiLookUpColumn(AddressOf V_NVMa_Ku, AddressOf L_NVMa_Ku)


        EditNVMa_TTLN.V_ActiLookUpColumn(AddressOf V_NVMa_TTLN, AddressOf L_NVMa_TTLN)
        EditNVMa_TTCP.V_ActiLookUpColumn(AddressOf V_NVMa_TTCP, AddressOf L_NVMa_TTCP)
        EditNVMa_Bp.V_ActiLookUpColumn(AddressOf V_NVMa_Bp, AddressOf L_NVMa_Bp)
        EditNVMa_HS.V_ActiLookUpColumn(AddressOf V_NVMa_HS, AddressOf L_NVMa_Hs)
        EditNVMa_Cd.V_ActiLookUpColumn(AddressOf V_NVMa_Cd, AddressOf L_NVMa_Cd)
        EditNVMa_Db.V_ActiLookUpColumn(AddressOf V_NVMa_Db, AddressOf L_NVMa_Db)


        EditNVMa_TD1.V_ActiLookUpColumn(AddressOf V_NVMa_TD1, AddressOf L_NVMa_TD1)
        EditNVMa_TD2.V_ActiLookUpColumn(AddressOf V_NVMa_TD2, AddressOf L_NVMa_TD2)
        EditNVMa_TD3.V_ActiLookUpColumn(AddressOf V_NVMa_TD3, AddressOf L_NVMa_TD3)
        EditNVMa_TD4.V_ActiLookUpColumn(AddressOf V_NVMa_TD4, AddressOf L_NVMa_TD4)
        EditNVMa_TD5.V_ActiLookUpColumn(AddressOf V_NVMa_TD5, AddressOf L_NVMa_TD5)


        EditNVMa_Xe.V_ActiLookUpColumn(AddressOf V_NVMa_Xe, AddressOf L_NVMa_Xe)
        EditNVMa_Kx.V_ActiLookUpColumn(AddressOf V_NVMa_Kx, AddressOf L_NVMa_Kx)
        EditNVMa_Tuyen.V_ActiLookUpColumn(AddressOf V_NVMa_Tuyen, AddressOf L_NVMa_Tuyen)
        '-----------------

        '-------------------------Hach toan
        EditHTTk_no.V_ActiLookUpColumn(AddressOf V_HTTk_no, AddressOf L_HTTk_no)
        EditHTTk_co.V_ActiLookUpColumn(AddressOf V_HTTk_Co, AddressOf L_HTTk_Co)

        EditMa_giam.V_ActiLookUpColumn(AddressOf V_Ma_giam, AddressOf L_Ma_giam)

        EditHTMa_vv.V_ActiLookUpColumn(AddressOf V_HTMa_Vv, AddressOf L_HTMa_Vv)
        EditHTMa_phi.V_ActiLookUpColumn(AddressOf V_HTMa_phi, AddressOf L_HTMa_phi)
        EditHTMa_hd.V_ActiLookUpColumn(AddressOf V_HTMa_Hd, AddressOf L_HTMa_Hd)
        EditHTMa_sp.V_ActiLookUpColumn(AddressOf V_HTMa_Sp, AddressOf L_HTMa_Sp)
        EditHTMa_KU.V_ActiLookUpColumn(AddressOf V_HTMa_KU, AddressOf L_HTMa_KU)


        EditHTMa_TTLN.V_ActiLookUpColumn(AddressOf V_HTMa_TTLN, AddressOf L_HTMa_TTLN)
        EditHTMa_TTCP.V_ActiLookUpColumn(AddressOf V_HTMa_TTCP, AddressOf L_HTMa_TTCP)
        EditHTMa_Bp.V_ActiLookUpColumn(AddressOf V_HTMa_Bp, AddressOf L_HTMa_Bp)
        EditHTMa_HS.V_ActiLookUpColumn(AddressOf V_HTMa_HS, AddressOf L_HTMa_Hs)
        EditHTMa_Cd.V_ActiLookUpColumn(AddressOf V_HTMa_Cd, AddressOf L_HTMa_Cd)
        EditHTMa_Db.V_ActiLookUpColumn(AddressOf V_HTMa_Db, AddressOf L_HTMa_Db)


        EditHTMa_TD1.V_ActiLookUpColumn(AddressOf V_HTMa_TD1, AddressOf L_HTMa_TD1)
        EditHTMa_TD2.V_ActiLookUpColumn(AddressOf V_HTMa_TD2, AddressOf L_HTMa_TD2)
        EditHTMa_TD3.V_ActiLookUpColumn(AddressOf V_HTMa_TD3, AddressOf L_HTMa_TD3)
        EditHTMa_TD4.V_ActiLookUpColumn(AddressOf V_HTMa_TD4, AddressOf L_HTMa_TD4)
        EditHTMa_TD5.V_ActiLookUpColumn(AddressOf V_HTMa_TD5, AddressOf L_HTMa_TD5)


        EditHTMa_Xe.V_ActiLookUpColumn(AddressOf V_HTMa_Xe, AddressOf L_HTMa_Xe)
        EditHTMa_Kx.V_ActiLookUpColumn(AddressOf V_HTMa_Kx, AddressOf L_HTMa_Kx)
        EditHTMa_Tuyen.V_ActiLookUpColumn(AddressOf V_HTMa_Tuyen, AddressOf L_HTMa_Tuyen)

        EditHTMa_NV.ColumnReadOnly = True
        EditHTMa_Tang.ColumnReadOnly = True
        EditHTMa_bpts.ColumnReadOnly = True
        EditHTGt_da_kh.ColumnReadOnly = True
        EditHTGt_kh_ky.ColumnReadOnly = True
        EditHTNguyen_gia.ColumnReadOnly = True

        ' Trang thai
        EditTTMa_NV.ColumnReadOnly = True
        EditTTMa_bpts.ColumnReadOnly = True
        EditTTGt_Cl.ColumnReadOnly = True
        EditTTNgay_kh.ColumnReadOnly = True
        EditTTNgay_Tang.ColumnReadOnly = True
        'hieulv
        EditMa_Bp.V_ActiLookUpColumn(AddressOf V_Ma_Bp, AddressOf L_Ma_Bp)
        EditMa_Hd.V_ActiLookUpColumn(AddressOf V_Ma_HD, AddressOf L_Ma_HD)
        EditMa_phi.V_ActiLookUpColumn(AddressOf V_Ma_phi, AddressOf L_Ma_phi)
        EditTK.V_ActiLookUpColumn(AddressOf V_tk, AddressOf L_tk)

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub CreateTabe()
        Dim Dtloaits As New DataTable
        Dtloaits.Columns.Add("Loai_ts", GetType(String))
        Dtloaits.Columns.Add("Ten", GetType(String))
        Dtloaits.Rows.Add("1", IIf(M_LAN = "V", "Tài sản cố định hữu hình", "Level 1"))
        Dtloaits.Rows.Add("2", IIf(M_LAN = "V", "Tài sản cố định vô hình", "Level 2"))
        Dtloaits.Rows.Add("3", IIf(M_LAN = "V", "Tài sản cố định thuê tài chính", "Level 3"))
        Dtloaits.Rows.Add("4", IIf(M_LAN = "V", "Tài sản cố định bất động sản đầu tư", "Level 4"))
        CyberFill.V_FillComBoxDefaul(Me.Cmbloai_ts, Dtloaits, "Loai_ts", "Ten")

        Dim DtloaiKh As New DataTable
        DtloaiKh.Columns.Add("Loai_kh", GetType(String))
        DtloaiKh.Columns.Add("Ten", GetType(String))
        DtloaiKh.Rows.Add("1", IIf(M_LAN = "V", "Tính khấu hao theo ngày", "Level 1"))
        DtloaiKh.Rows.Add("2", IIf(M_LAN = "V", "Tính khấu hao theo tháng", "Level 2"))
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_KH, DtloaiKh, "Loai_kh", "Ten")
    End Sub
    Sub V_Load_Ctdmts(ByVal M_Mode As String, ByVal sMa_Ts As String, ByVal sMa_Dvcs As String)
        Dim DsFilterTsCd As New DataSet
        sMa_Ts = sMa_Ts.Trim
        sMa_Dvcs = sMa_Dvcs.Trim
        M_Mode = M_Mode.Trim
        DsFilterTsCd = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtdmts", sMa_Ts & "#" & sMa_Dvcs & "#" & M_Mode)
        tbCtdmts = DsFilterTsCd.Tables(0)
        tbCtPtts = DsFilterTsCd.Tables(1)
        'hieulv them TAB Khai bao phan bo TSCD
        tbCTPB = DsFilterTsCd.Tables(6)
        DvCTPB = New DataView(tbCTPB)
        DvPB = New DataView(DsFilterTsCd.Tables(7))

        DvCtdmts = New DataView(tbCtdmts)
        DvCtPtts = New DataView(tbCtPtts)

        DvNvH = New DataView(DsFilterTsCd.Tables(2))
        DvHTH = New DataView(DsFilterTsCd.Tables(3))
        DvTTH = New DataView(DsFilterTsCd.Tables(4))
        DvPTH = New DataView(DsFilterTsCd.Tables(5))
        CyberFill.V_FillVoucher(DetailGRVNguon_Von, M_LAN, DvNvH, DvCtdmts, Nothing)
        CyberFill.V_FillVoucher(DetailGRVHach_toan, M_LAN, DvHTH, DvCtdmts, Nothing)
        CyberFill.V_FillVoucher(DetailGRVTrang_Thai_Ts, M_LAN, DvTTH, DvCtdmts, Nothing)
        CyberFill.V_FillVoucher(DetailGRVPhu_tung_Ts, M_LAN, DvPTH, DvCtPtts, Nothing)
        '
        CyberFill.V_FillVoucher(DetailGRVPB, M_LAN, DvPB, DvCTPB, Nothing)
    End Sub
    Sub V_GetColumns()

        EditTinh_kh.GetColumn(DetailGRVNguon_Von, "Tinh_kh")
        EditNVMa_NV.GetColumn(DetailGRVNguon_Von, "Ma_NV")
        EditNVMa_Tang.GetColumn(DetailGRVNguon_Von, "Ma_Tang")
        EditStt_Rec0.GetColumn(DetailGRVNguon_Von, "Stt_rec0")

        EditNVGt_da_kh.GetColumn(DetailGRVNguon_Von, "Gt_da_kh")
        EditNVGt_kh_ky.GetColumn(DetailGRVNguon_Von, "Gt_kh_ky")
        EditNVNguyen_gia.GetColumn(DetailGRVNguon_Von, "Nguyen_gia")
        EditNVGt_Cl.GetColumn(DetailGRVNguon_Von, "GT_CL")
        EditNVThang_Kh.GetColumn(DetailGRVNguon_Von, "Thang_kh")
        EditNVNgay_Tang.GetColumn(DetailGRVNguon_Von, "Ngay_tang")
        EditNVNgay_kh.GetColumn(DetailGRVNguon_Von, "Ngay_kh")
        EditNVTk_no.GetColumn(DetailGRVNguon_Von, "Tk_no")
        EditNVTk_co.GetColumn(DetailGRVNguon_Von, "Tk_co")
        EditMa_giam.GetColumn(DetailGRVTrang_Thai_Ts, "Ma_giam")

        '------------------------------
        EditNVMa_vv.GetColumn(DetailGRVNguon_Von, "Ma_vv")
        EditNVMa_phi.GetColumn(DetailGRVNguon_Von, "Ma_phi")
        EditNVMa_hd.GetColumn(DetailGRVNguon_Von, "Ma_hd")
        EditNVMa_sp.GetColumn(DetailGRVNguon_Von, "Ma_sp")
        EditNVMa_KU.GetColumn(DetailGRVNguon_Von, "Ma_KU")

        EditNVMa_TTLN.GetColumn(DetailGRVNguon_Von, "Ma_TTLN")
        EditNVMa_TTCP.GetColumn(DetailGRVNguon_Von, "Ma_TTCP")
        EditNVMa_Bp.GetColumn(DetailGRVNguon_Von, "Ma_Bp")
        EditNVMa_HS.GetColumn(DetailGRVNguon_Von, "Ma_HS")
        EditNVMa_KU.GetColumn(DetailGRVNguon_Von, "Ma_KU")
        EditNVMa_Cd.GetColumn(DetailGRVNguon_Von, "Ma_Cd")
        EditNVMa_Db.GetColumn(DetailGRVNguon_Von, "Ma_Db")


        EditNVMa_TD1.GetColumn(DetailGRVNguon_Von, "Ma_TD1")
        EditNVMa_TD2.GetColumn(DetailGRVNguon_Von, "Ma_TD2")
        EditNVMa_TD3.GetColumn(DetailGRVNguon_Von, "Ma_TD3")
        EditNVMa_TD4.GetColumn(DetailGRVNguon_Von, "Ma_TD4")
        EditNVMa_TD5.GetColumn(DetailGRVNguon_Von, "Ma_TD5")


        EditNVMa_Xe.GetColumn(DetailGRVNguon_Von, "Ma_Xe")
        EditNVMa_Kx.GetColumn(DetailGRVNguon_Von, "Ma_Kx")
        EditNVMa_Tuyen.GetColumn(DetailGRVNguon_Von, "Ma_Tuyen")

        '------------------------------ Hach toan
        EditHTTk_no.GetColumn(DetailGRVHach_toan, "Tk_no")
        EditHTTk_co.GetColumn(DetailGRVHach_toan, "Tk_co")

        EditHTMa_vv.GetColumn(DetailGRVHach_toan, "Ma_vv")
        EditHTMa_phi.GetColumn(DetailGRVHach_toan, "Ma_phi")
        EditHTMa_hd.GetColumn(DetailGRVHach_toan, "Ma_hd")
        EditHTMa_sp.GetColumn(DetailGRVHach_toan, "Ma_sp")
        EditHTMa_KU.GetColumn(DetailGRVHach_toan, "Ma_KU")

        EditHTMa_TTLN.GetColumn(DetailGRVHach_toan, "Ma_TTLN")
        EditHTMa_TTCP.GetColumn(DetailGRVHach_toan, "Ma_TTCP")
        EditHTMa_Bp.GetColumn(DetailGRVHach_toan, "Ma_Bp")
        EditHTMa_HS.GetColumn(DetailGRVHach_toan, "Ma_HS")
        EditHTMa_KU.GetColumn(DetailGRVHach_toan, "Ma_KU")
        EditHTMa_Cd.GetColumn(DetailGRVHach_toan, "Ma_Cd")
        EditHTMa_Db.GetColumn(DetailGRVHach_toan, "Ma_Db")


        EditHTMa_TD1.GetColumn(DetailGRVHach_toan, "Ma_TD1")
        EditHTMa_TD2.GetColumn(DetailGRVHach_toan, "Ma_TD2")
        EditHTMa_TD3.GetColumn(DetailGRVHach_toan, "Ma_TD3")
        EditHTMa_TD4.GetColumn(DetailGRVHach_toan, "Ma_TD4")
        EditHTMa_TD5.GetColumn(DetailGRVHach_toan, "Ma_TD5")

        
        EditHTMa_Xe.GetColumn(DetailGRVHach_toan, "Ma_Xe")
        EditHTMa_Kx.GetColumn(DetailGRVHach_toan, "Ma_Kx")
        EditHTMa_Tuyen.GetColumn(DetailGRVHach_toan, "Ma_Tuyen")


        EditHTMa_NV.GetColumn(DetailGRVHach_toan, "Ma_NV")
        EditHTMa_Tang.GetColumn(DetailGRVHach_toan, "Ma_Tang")
        EditHTMa_bpts.GetColumn(DetailGRVHach_toan, "Ma_bpts")
        EditHTGt_da_kh.GetColumn(DetailGRVHach_toan, "Gt_da_kh")
        EditHTGt_kh_ky.GetColumn(DetailGRVHach_toan, "Gt_kh_ky")
        EditHTNguyen_gia.GetColumn(DetailGRVHach_toan, "Nguyen_gia")

        ' Trang thai
        EditTTMa_NV.GetColumn(DetailGRVTrang_Thai_Ts, "Ma_Nv")
        EditTTMa_bpts.GetColumn(DetailGRVTrang_Thai_Ts, "Ma_bpts")
        EditTTGt_Cl.GetColumn(DetailGRVTrang_Thai_Ts, "GT_CL")
        EditTTNgay_Tang.GetColumn(DetailGRVTrang_Thai_Ts, "Ngay_tang")
        EditTTNgay_kh.GetColumn(DetailGRVTrang_Thai_Ts, "Ngay_kh")
        EditTTNguyen_gia.GetColumn(DetailGRVTrang_Thai_Ts, "Nguyen_gia")
        'hieulv
        EditMa_Bp.GetColumn(DetailGRVPB, "Ma_BP")
        EditMa_Hd.GetColumn(DetailGRVPB, "Ma_HD")
        EditMa_phi.GetColumn(DetailGRVPB, "Ma_Phi")
        EditTK.GetColumn(DetailGRVPB, "TK")

    End Sub
    Sub UpdateList()
        Dim i As Integer
        T_Nguyen_Gia = 0
        T_Gt_Da_Kh = 0
        T_GT_CL = 0
        T_Gt_kh_Ky = 0

        For i = 0 To tbCtdmts.Rows.Count - 1
            T_Nguyen_Gia = T_Nguyen_Gia + tbCtdmts.Rows(i).Item("Nguyen_Gia")
            T_Gt_Da_Kh = T_Gt_Da_Kh + tbCtdmts.Rows(i).Item("Gt_Da_Kh")
            'T_GT_CL = T_GT_CL + tbCtdmts.Rows(i).Item("GT_CL")
            T_Gt_kh_Ky = T_Gt_kh_Ky + tbCtdmts.Rows(i).Item("Gt_kh_Ky")
        Next
        T_GT_CL = T_Nguyen_Gia - T_Gt_Da_Kh
        TxtT_Nguyen_Gia.Text = T_Nguyen_Gia
        TxtT_Gt_Da_kh.Text = T_Gt_Da_Kh
        TxtT_GT_CL.Text = T_GT_CL
        TxtT_gt_kh_Ky.Text = T_Gt_kh_Ky

        TxtT_Nguyen_Gia.Refresh()
        TxtT_Gt_Da_kh.Refresh()
        TxtT_GT_CL.Refresh()
        TxtT_gt_kh_Ky.Refresh()
    End Sub
#Region "Menu Gridview"
    Private Sub V_MenuNguonVon()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItemNguon_Von, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItemNguon_Von, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVNguon_Von.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_MenuPhu_Tung()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItemPhu_tung_Ts, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItemPhu_tung_Ts, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVPhu_tung_Ts.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_MenuPB()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItemPB, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItemPB, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVPB.GridControl.ContextMenu = mnItemsMail
    End Sub
#End Region
#End Region
#Region "Valid"
#Region "Vali --- Ma_loai"
    Private Sub V_Ma_loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_loai.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_loai", "Dmplts", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_loai.Text = "" Then
            Txtten_loai.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_loai.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_loai.Text = DrReturn.Item("Ma_loai")
            Txtten_loai.Text = DrReturn.Item("Ten_loai")
        Else
            Txtma_loai.Text = ""
            Txtten_loai.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_ts"
    Private Sub V_Tk_ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ts.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ts.Text = "" Then
            txtTen_Tk_Ts.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ts.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ts.Text = DrReturn.Item("TK")
            txtTen_Tk_Ts.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ts.Text = ""
            txtTen_Tk_Ts.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD1"
    Private Sub V_Nh_TS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TS1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTS", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_TS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TS1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TS1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TS1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TS1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Nh_TS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TS2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTS", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_TS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TS2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TS2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TS2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TS2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Nh_TS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TS3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTS", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_TS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TS3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TS3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TS3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TS3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Nh_TS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TS4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTS", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_TS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TS4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TS4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TS4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Nh_TS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TS5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTS", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_TS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TS5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TS5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TS5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TS5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Ts.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        '=======================================
        If Not ChkEmpty(TxtMa_Ts) Then Exit Sub
        If Not ChkEmpty(TxtTen_ts) Then Exit Sub
        If Not ChkEmpty(TxtTk_Ts) Then Exit Sub
        Dim nCount, i As Integer
        nCount = tbCtdmts.Rows.Count - 1
        ' CTDMTS
        For i = nCount To 0 Step -1
            If tbCtdmts.Rows(i).Item("Ma_NV").ToString.Trim = "" Then
                tbCtdmts.Rows(i).Delete()
                tbCtdmts.AcceptChanges()
            End If
        Next

        '--- Check nhap chi tiet
        nCount = tbCtdmts.Rows.Count
        If nCount = 0 Then
            MsgBox(IIf(M_LAN = "V", "Chưa vào chi tiết tài sản. Không lưu được!", "No details on asset. Do not save it!"), 64, M_CYBER_VER)
            Exit Sub
        End If
        '--- Set Cac Gia tri Null
        For i = 0 To tbCtdmts.Rows.Count - 1
            tbCtdmts.Rows(i).BeginEdit()
            If tbCtdmts.Rows(i).Item("Ma_Giam").ToString.Trim = "" Then
                tbCtdmts.Rows(i).Item("Ngay_Giam") = Convert.ToDateTime("1900.01.01")
            End If
            tbCtdmts.Rows(i).EndEdit()
        Next
        For i = 0 To tbCtdmts.Rows.Count - 1
            tbCtdmts.Rows(i).BeginEdit()
            If tbCtdmts.Rows(i).Item("Ngay_Giam") Is DBNull.Value Then
                tbCtdmts.Rows(i).Item("Ngay_Giam") = Convert.ToDateTime("1900.01.01")
                tbCtdmts.Rows(i).Item("Ma_Giam") = ""
                tbCtdmts.Rows(i).Item("SO_CT") = ""
                tbCtdmts.Rows(i).Item("Ly_Do") = ""
            End If
            tbCtdmts.Rows(i).EndEdit()
        Next
        tbCtdmts.AcceptChanges()
        For i = 0 To tbCtdmts.Rows.Count - 1
            tbCtdmts.Rows(i).BeginEdit()
            If tbCtdmts.Rows(i).Item("Ngay_Giam") = Convert.ToDateTime("1900.01.01") Then
                tbCtdmts.Rows(i).Item("Ma_Giam") = ""
                tbCtdmts.Rows(i).Item("SO_CT") = ""
                tbCtdmts.Rows(i).Item("Ly_Do") = ""
            End If
            tbCtdmts.Rows(i).EndEdit()
        Next
        tbCtdmts.AcceptChanges()
        For i = 0 To tbCtdmts.Rows.Count - 1
            tbCtdmts.Rows(i).BeginEdit()
            If tbCtdmts.Rows(i).Item("Ngay_Tang") Is DBNull.Value Then
                tbCtdmts.Rows(i).Item("Ngay_Tang") = Convert.ToDateTime("1900.01.01")
            End If
            If tbCtdmts.Rows(i).Item("Ngay_KH") Is DBNull.Value Then
                tbCtdmts.Rows(i).Item("Ngay_KH") = Convert.ToDateTime("1900.01.01")
            End If
            tbCtdmts.Rows(i).EndEdit()
        Next
        tbCtdmts.AcceptChanges()
        '--- Set Cac Gia tri Null
        Dim DemMaxStt0 As Integer = 0
        For i = 0 To tbCtdmts.Rows.Count - 1
            tbCtdmts.Rows(i).BeginEdit()
            tbCtdmts.Rows(i).Item("Stt_Rec0") = Strings.Right("0000" + (i + 1).ToString.Trim, 4)
            tbCtdmts.Rows(i).Item("Stt0") = Strings.Right("00" + (i + 1).ToString.Trim, 2)
            tbCtdmts.Rows(i).Item("Ma_TS") = TxtMa_Ts.Text.Trim
            tbCtdmts.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            tbCtdmts.Rows(i).EndEdit()
            tbCtdmts.AcceptChanges()
        Next

        'Dim dsmaxstt0 As New DataSet
        'MsgBox(1)
        'For i = 0 To tbCtdmts.Rows.Count - 1
        '    MsgBox(i)
        '    tbCtdmts.Rows(i).BeginEdit()
        '    If tbCtdmts.Rows(i).Item("Stt0").ToString.Trim = "" Then
        '        dsmaxstt0 = Nothing
        '        dsmaxstt0 = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FAGetStt0", DemMaxStt0.ToString.Trim + "#" + TxtMa_Ts.Text.Trim + "#" + TxtMa_Dvcs.Text.Trim)
        '        tbCtdmts.Rows(i).Item("Stt0") = dsmaxstt0.Tables(0).Rows(0).Item("Stt0").ToString.Trim
        '        tbCtdmts.Rows(i).Item("Stt_Rec0") = dsmaxstt0.Tables(0).Rows(0).Item("Stt_Rec0").ToString.Trim
        '        DemMaxStt0 = dsmaxstt0.Tables(0).Rows(0).Item("Dem")
        '    End If
        '    tbCtdmts.Rows(i).Item("Ma_TS") = TxtMa_Ts.Text.Trim
        '    tbCtdmts.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
        '    tbCtdmts.Rows(i).EndEdit()
        '    tbCtdmts.AcceptChanges()
        'Next
        'dsmaxstt0.Dispose()
        ' CTPTTS
        nCount = tbCtPtts.Rows.Count - 1
        For i = nCount To 0 Step -1
            If tbCtPtts.Rows(i).Item("Ten_PTTs").ToString.Trim = "" Then
                tbCtPtts.Rows(i).Delete()
                tbCtPtts.AcceptChanges()
            End If
        Next

        For i = 0 To tbCtPtts.Rows.Count - 1
            tbCtPtts.Rows(i).BeginEdit()
            tbCtPtts.Rows(i).Item("Ma_TS") = TxtMa_Ts.Text.Trim
            tbCtPtts.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            tbCtPtts.Rows(i).EndEdit()
        Next
        'Tab Phân bổ khấu hao
        For i = 0 To tbCTPB.Rows.Count - 1
            tbCTPB.Rows(i).BeginEdit()
            tbCTPB.Rows(i).Item("Stt_Rec0") = Strings.Right("0000" + (i + 1).ToString.Trim, 4)
            tbCTPB.Rows(i).Item("Ma_TS") = TxtMa_Ts.Text.Trim
            tbCTPB.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            tbCTPB.Rows(i).EndEdit()
            tbCTPB.AcceptChanges()
        Next
        '=====================================
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, tbCtdmts, "CTDMTS", Mode, " Ma_Ts  =N'" + Ma_tsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, tbCtPtts, "CTPTTS", Mode, " Ma_Ts  =N'" + Ma_tsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, tbCTPB, "CTDMTSPB", Mode, " Ma_Ts  =N'" + Ma_tsOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Valid - Detail - Add On"
#Region "Nguồn vốn"
    Private Sub V_NVMa_NV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NV", "DmNV", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_NV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVNguon_Von.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_NV") = ""
            Exit Sub
        End If
        drvCurren("Ma_NV") = DrReturn("Ma_NV")
        DetailGRVNguon_Von.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Tang(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tg_Ts", "DmTgTS", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Tang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVNguon_Von.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Tang") = ""
            Exit Sub
        End If
        drvCurren("Ma_Tang") = DrReturn("Ma_Tg_Ts")
        DetailGRVNguon_Von.UpdateCurrentRow()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        DetailGRVNguon_Von.PostEditor()

        tbCtdmts.AcceptChanges()
        Dim iRow As Integer = -1
        iRow = DetailGRVNguon_Von.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVNguon_Von.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRVNguon_Von)
        V_Tinh_Toan(iRow)

    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        tbCtdmts.Rows(iRow).BeginEdit()
        tbCtdmts.Rows(iRow).Item("GT_CL") = tbCtdmts.Rows(iRow).Item("Nguyen_Gia") - tbCtdmts.Rows(iRow).Item("Gt_Da_kh")
        tbCtdmts.Rows(iRow).EndEdit()

        If tbCtdmts.Rows(iRow).Item("Thang_KH") <> 0 And tbCtdmts.Rows(iRow).Item("GT_kh_ky") = 0 Then
            tbCtdmts.Rows(iRow).BeginEdit()
            tbCtdmts.Rows(iRow).Item("GT_kh_ky") = CyberSupport.V_Round(tbCtdmts.Rows(iRow).Item("Nguyen_Gia") / tbCtdmts.Rows(iRow).Item("Thang_KH"), 0)
            tbCtdmts.Rows(iRow).EndEdit()
        End If
        UpdateList()
    End Sub
#End Region
#Region "Tab Phân bổ khấu hao"
    Private Sub V_Ma_phi(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVPB.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Phi") = ""
            Exit Sub
        End If
        drvCurren("Ma_Phi") = DrReturn("Ma_Phi")
        DetailGRVPB.UpdateCurrentRow()
    End Sub
    Private Sub V_tk(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_tk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVPB.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("TK") = ""
            Exit Sub
        End If
        drvCurren("TK") = DrReturn("TK")
        DetailGRVPB.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVPB.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Bp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Bp") = DrReturn("Ma_Bp")
        DetailGRVPB.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVPB.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_HD") = ""
            Exit Sub
        End If
        drvCurren("Ma_HD") = DrReturn("Ma_HD")
        DetailGRVPB.UpdateCurrentRow()
    End Sub
#End Region
#Region " NV --- Vv/Phi/HD...."
    Private Sub V_NVMa_Vv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Vv") = ""
            Exit Sub
        End If
        drvCurren("Ma_Vv") = DrReturn("Ma_Vv")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_phi(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Phi") = ""
            Exit Sub
        End If
        drvCurren("Ma_Phi") = DrReturn("Ma_Phi")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Hd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hd", "DmHd", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hd") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hd") = DrReturn("Ma_Hd")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Sp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Sp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Sp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Sp") = DrReturn("Ma_Sp")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Ku(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Ku(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Ku") = ""
            Exit Sub
        End If
        drvCurren("Ma_Ku") = DrReturn("Ma_Ku")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub

#End Region
#Region " NV --- TTLN/TTCP/..."
    Private Sub V_NVMa_TTLN(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTLN") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTLN") = DrReturn("Ma_TTLN")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_TTCP(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTCP") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTCP") = DrReturn("Ma_TTCP")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Bp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Bp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Bp") = DrReturn("Ma_Bp")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_HS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hs") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hs") = DrReturn("Ma_Hs")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Cd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cd", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Cd") = ""
            Exit Sub
        End If
        drvCurren("Ma_Cd") = DrReturn("Ma_Cd")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Db(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Db", "DmDb", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Db") = ""
            Exit Sub
        End If
        drvCurren("Ma_Db") = DrReturn("Ma_Db")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region " NV --- TD1..."
    Private Sub V_NVMa_TD1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD1") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD1") = DrReturn("Ma_TD1")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_TD2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD2") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD2") = DrReturn("Ma_TD2")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_TD3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD3") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD3") = DrReturn("Ma_TD3")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_TD4(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD4") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD4") = DrReturn("Ma_TD4")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_TD5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD5") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD5") = DrReturn("Ma_TD5")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region " NV --- Xe/Tuyen/KX"
    Private Sub V_NVMa_Xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Xe") = ""
            Exit Sub
        End If
        drvCurren("Ma_Xe") = DrReturn("Ma_Xe")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Kx(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Kx") = ""
            Exit Sub
        End If
        drvCurren("Ma_Kx") = DrReturn("Ma_Kx")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_NVMa_Tuyen(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tuyen", "DmTuyen", "1=1", "1=1")
    End Sub
    Private Sub L_NVMa_Tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Tuyen") = ""
            Exit Sub
        End If
        drvCurren("Ma_Tuyen") = DrReturn("Ma_Tuyen")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region "Hạch toán"
    Private Sub V_HTTk_no(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_HTTk_no(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Tk_No") = ""
            Exit Sub
        End If
        drvCurren("Tk_No") = DrReturn("tk")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTTk_Co(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_HTTk_Co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Tk_Co") = ""
            Exit Sub
        End If
        drvCurren("Tk_Co") = DrReturn("tk")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region "Vv/Phi/HD...."
    Private Sub V_HTMa_Vv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Vv") = ""
            Exit Sub
        End If
        drvCurren("Ma_Vv") = DrReturn("Ma_Vv")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_phi(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Phi") = ""
            Exit Sub
        End If
        drvCurren("Ma_Phi") = DrReturn("Ma_Phi")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Hd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hd", "DmHd", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hd") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hd") = DrReturn("Ma_Hd")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Sp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Sp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Sp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Sp") = DrReturn("Ma_Sp")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Ku(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Ku(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Ku") = ""
            Exit Sub
        End If
        drvCurren("Ma_Ku") = DrReturn("Ma_Ku")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub

#End Region
#Region "TTLN/TTCP/..."
    Private Sub V_HTMa_TTLN(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTLN") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTLN") = DrReturn("Ma_TTLN")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_TTCP(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTCP") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTCP") = DrReturn("Ma_TTCP")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Bp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Bp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Bp") = DrReturn("Ma_Bp")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_HS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hs") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hs") = DrReturn("Ma_Hs")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Cd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cd", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Cd") = ""
            Exit Sub
        End If
        drvCurren("Ma_Cd") = DrReturn("Ma_Cd")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Db(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Db", "DmDb", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Db") = ""
            Exit Sub
        End If
        drvCurren("Ma_Db") = DrReturn("Ma_Db")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region "TD1..."
    Private Sub V_HTMa_TD1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD1") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD1") = DrReturn("Ma_TD1")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_TD2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD2") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD2") = DrReturn("Ma_TD2")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_TD3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD3") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD3") = DrReturn("Ma_TD3")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_TD4(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD4") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD4") = DrReturn("Ma_TD4")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_TD5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD5") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD5") = DrReturn("Ma_TD5")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region "Xe/Tuyen/KX"
    Private Sub V_HTMa_Xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Xe") = ""
            Exit Sub
        End If
        drvCurren("Ma_Xe") = DrReturn("Ma_Xe")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Kx(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Kx") = ""
            Exit Sub
        End If
        drvCurren("Ma_Kx") = DrReturn("Ma_Kx")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
    Private Sub V_HTMa_Tuyen(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tuyen", "DmTuyen", "1=1", "1=1")
    End Sub
    Private Sub L_HTMa_Tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Tuyen") = ""
            Exit Sub
        End If
        drvCurren("Ma_Tuyen") = DrReturn("Ma_Tuyen")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#Region "Giam tai san"
    Private Sub V_Ma_giam(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tg_Ts", "DmTgTS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_giam(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVHach_toan.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_giam") = ""
            Exit Sub
        End If
        drvCurren("Ma_giam") = DrReturn("Ma_Tg_Ts")
        DetailGRVHach_toan.UpdateCurrentRow()
    End Sub
#End Region
#End Region
#Region "Add/Delete"
    Sub V_ShortAddItemNguon_Von(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVNguon_Von.FocusedRowHandle
        V_AddItemNguon_Von(iRow)
    End Sub
    Private Sub V_AddItemNguon_Von(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = DvCtdmts.Item(iRow) Else DrvOld = Nothing
        DvCtdmts.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1), DvNvH)
        'CyberSupport.SetCarryOn(DrvOld, DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1), DvHTH)
        'CyberSupport.SetCarryOn(DrvOld, DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1), DvTTH)
        CarrOnNguonVon(DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1))
        UpdateList()
        iRow = DvCtdmts.Count - 1
        CyberFill.V_ForcusCell(DetailGRVNguon_Von, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemNguon_Von(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVNguon_Von.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCtdmts, Appconn) Then Exit Sub
        DvCtdmts.Delete(iRow)
        DvCtdmts.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub CarrOnNguonVon(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_tang") = Now.Date
        DvNew.Item("Ngay_Kh") = Now.Date
    End Sub
    Sub V_ShortAddItemPhu_tung_Ts(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPhu_tung_Ts.FocusedRowHandle
        DetailGRVNguon_Von.PostEditor()
        V_AddItemPhu_tung_Ts(iRow)
    End Sub
    Private Sub V_AddItemPhu_tung_Ts(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView

        If iRow > 0 Then DrvOld = DvCtPtts.Item(iRow) Else DrvOld = Nothing

        DvCtPtts.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvCtPtts.Table.Rows(DvCtPtts.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCtPtts.Table.Rows(DvCtPtts.Table.Rows.Count - 1), DvPTH)
        CarrOnPhu_tung_Ts(DvCtdmts.Table.Rows(DvCtdmts.Table.Rows.Count - 1))
        UpdateList()
        iRow = DvCtPtts.Count - 1
        If iRow > 0 Then CyberFill.V_ForcusCell(DetailGRVPhu_tung_Ts, iRow, 0)
    End Sub
    Private Sub CarrOnPhu_tung_Ts(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub V_ShortDeleteItemPhu_tung_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPhu_tung_Ts.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCtPtts, Appconn) Then Exit Sub
        DvCtPtts.Delete(iRow)
        DvCtPtts.Table.AcceptChanges()
        UpdateList()
    End Sub
#Region "Tab phân bổ khấu hao"
    Sub V_ShortAddItemPB(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPB.FocusedRowHandle
        DetailGRVPB.PostEditor()
        V_AddItemPB(iRow)
    End Sub
    Private Sub V_AddItemPB(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow > 0 Then DrvOld = DvCTPB.Item(iRow) Else DrvOld = Nothing

        DvCTPB.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvCTPB.Table.Rows(DvCTPB.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCTPB.Table.Rows(DvCTPB.Table.Rows.Count - 1), DvPB)
        CarrOnPB(DvCTPB.Table.Rows(DvCTPB.Table.Rows.Count - 1))
        UpdateList()
        iRow = DvCTPB.Count - 1
        If iRow > 0 Then CyberFill.V_ForcusCell(DetailGRVPB, iRow, 0)
    End Sub
    Private Sub CarrOnPB(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub V_ShortDeleteItemPB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVPB.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCTPB, Appconn) Then Exit Sub
        DvCTPB.Delete(iRow)
        DvCTPB.Table.AcceptChanges()
        UpdateList()
    End Sub
#End Region
#End Region
#Region "Enter Dong cuoi"
    Private Sub DetailGRVNguon_Von_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            V_AddItemNguon_Von(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub DetailGRVPhu_tung_Ts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            V_AddItemPhu_tung_Ts(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub DetailGRVPB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            V_AddItemPB(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
End Class
