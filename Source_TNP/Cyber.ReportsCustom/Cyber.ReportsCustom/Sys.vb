Imports Cyber.Smreports
Imports System.Data.SqlClient
Public Class Sys
    Public oReportFormLib As Cyber.Smreports.FrmRepports_Banded
    Dim M_Para As String()
    Public M_Loai_BC As String = "VND"
    Public oSysVar As New Collection()
    Public M_strParameterStore As String = ""
    Public M_strFieldValue As String = ""
    Public M_strFieldName As String = ""
    Public M_Loai_DK_Loc As String = "0"
    Public Sub main()
        'Dim M_Para As String()
        'Dim abc As String
        'abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLSO1"
        ''abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLCD1"
        'M_Para = abc.Trim.Split("#")
        'Initvao1(M_Para)
    End Sub
    Public Function V_GetFrmFilter(ByVal Cp_Name As String, ByVal status As String) As Cyber.From.FilterReport
        Dim _Return As Cyber.From.FilterReport = Nothing

        Select Case Cp_Name.ToString.Trim.ToUpper
            Case "CP_SYSTH1_BAN_LOC_TEN_THU_TUC_O_DAY".Trim.ToUpper
                _Return = New SysTH1
            '--CYBERSOFT Cho Phép bạn Hiệu chỉnh ở phần này

            Case "CP_RO_DD01_KT".Trim.ToUpper
                _Return = New RO_DD01

            Case "CP_RO_TLHTDV_KeToan".Trim.ToUpper
                _Return = New DVKT

            Case "CP_BCNS26".Trim.ToUpper
                _Return = New BCNS09
            Case "CP_BE_KHTN_TKNHOM".Trim.ToUpper
                _Return = New BE_KHTN_TK
            Case "CP_BE_KHTN_TKPHONG".Trim.ToUpper
                _Return = New SysMonth
            Case "CP_BEHDXBK1_KT_2".Trim.ToUpper
                _Return = New BEHDXBK1_KT2
            Case "CP_BE_CSKH_SALE".Trim.ToUpper
                _Return = New BE_CSKH_SALE
            Case "CP_BE_LOINHUANKD".Trim.ToUpper
                _Return = New SysYear
            Case "CP_BCCSKH04".Trim.ToUpper
                _Return = New BCCSKH04_Detail
            Case "CP_BEHDXBK1_LUUCOC".Trim.ToUpper
                _Return = New BEHDXBK1
            Case "CP_BCNS05".Trim.ToUpper, "CP_BCNS14".Trim.ToUpper
                _Return = New BCNS05

            Case "CP_BCDV61".Trim.ToUpper
                _Return = New Nam

            Case "CP_RO_HD01N".Trim.ToUpper
                _Return = New RO_HD01N

            Case "CP_BCDV59".Trim.ToUpper
                _Return = New BCDV59

            Case "CP_GLSO1".Trim.ToUpper
                _Return = New FGLSO1_KH
            Case "CP_BEHDXBK1_KT".Trim.ToUpper
                _Return = New BEHDXBK1_KT
                    'HR ------------------------------------------------------------------------------------------------------------------------------
            Case "CP_BE_KHTN04_NOT", "CP_BE_KHTN03_NOT"
                _Return = New BE_KHTN04_NOT
            Case "CP_BECD2_KD".Trim.ToUpper
                _Return = New BECD2
            Case "CP_NHAPXUAT_VPP".Trim.ToUpper, "CP_DENGHI_VPP".Trim.ToUpper
                _Return = New NhapXuatVPP
            Case "CP_BCDV91", "CP_BCDV91A"
                _Return = New RO_HD01
            Case "CP_BE_KHNAM_PK".Trim.ToUpper, "CP_BE_KHNAM_BH".Trim.ToUpper
                _Return = New BE_KH04N
            Case "CP_BE_KH03".Trim.ToUpper
                _Return = New SysMonthToMonth

            Case "CP_BCNS01".Trim.ToUpper
                _Return = New BCNS01

            Case "CP_BCNS02".Trim.ToUpper, "CP_BCNS03".Trim.ToUpper, "CP_BCNS04".Trim.ToUpper, "CP_BCNS10".Trim.ToUpper _
                , "CP_BCNS11".Trim.ToUpper, "CP_BCNS46".Trim.ToUpper
                _Return = New BCNS03
                '- --19/06/2022
            Case "CP_TH_KPIT".Trim.ToUpper
                _Return = New TH_KPIT
            Case "CP_TH_KPIQ".Trim.ToUpper
                _Return = New TH_KPIQ
            Case "CP_BCNS06".Trim.ToUpper
                _Return = New BCNS06
            Case "CP_BCNS08".Trim.ToUpper
                _Return = New BCNS08
            Case "CP_BCNS09".Trim.ToUpper
                _Return = New BCNS09
            Case "CP_BCNS12".Trim.ToUpper
                _Return = New BCNS12
            Case "CP_BCNS_CC".Trim.ToUpper, "CP_BCNS_CC3".Trim.ToUpper
                _Return = New BangChamCong
            Case "CP_BCNS_CC2".Trim.ToUpper
                _Return = New HrDateToDate
            Case "CP_CRM_CS02".Trim.ToUpper
                _Return = New CRM_CS02
            Case "CP_KQKD_BE_KT".Trim.ToUpper
                _Return = New SysDateToDate
            Case "CP_BCDV60".Trim.ToUpper
                _Return = New Nam
                '    'BE ------------------------------------------------------------------------------------------------------------------------------
            Case "CP_BE_KH04".Trim.ToUpper, "CP_BE_KH05".Trim.ToUpper, "CP_BE_KH07".Trim.ToUpper, "CP_BE_KH08".Trim.ToUpper, "CP_BE_KH09".Trim.ToUpper, "CP_BE_KH10".Trim.ToUpper _
                , "CP_BE_THUONG".Trim.ToUpper, "CP_BE_HHCS".Trim.ToUpper
                _Return = New BE_KH04
            Case "CP_BE_KH04Q".Trim.ToUpper, "CP_BE_KH05Q".Trim.ToUpper
                _Return = New BE_KH04Q
            Case "CP_BE_KH04N".Trim.ToUpper, "CP_BE_KH05N".Trim.ToUpper, "CP_BE_KHNAM".Trim.ToUpper, "CP_BE_KHNAM_TH".Trim.ToUpper
                _Return = New BE_KH04N
            Case "CP_BE_KH09".Trim.ToUpper, "CP_BE_KH10".Trim.ToUpper, "CP_TONGHOPHHCS".Trim.ToUpper
                _Return = New BE_KH04
            Case "CP_BK_KPI".Trim.ToUpper
                _Return = New BE_KPI
            Case "CP_BEHDCTH1"
                _Return = New BEHDCTH1
            Case "CP_BCXHD_Tinh".Trim.ToUpper
                _Return = New XHDTINH
            Case "CP_BE_HDC02".Trim.ToUpper
                _Return = New BE_KHTN10
            Case "CP_BEHDCBK1".Trim.ToUpper
                _Return = New BEHDCBK1
            Case "CP_BEKQKD_HDC".Trim.ToUpper, "CP_BEKQKD_HDC_Detail".Trim.ToUpper
                _Return = New BEHDCTH1
            Case "CP_BEHDXBK1_HHMG".Trim.ToUpper, "CP_BEHDXBK1".Trim.ToUpper
                _Return = New BEHDXBK1
            Case "CP_BEHDXBK1_HUY".Trim.ToUpper
                _Return = New BEHDXBK1_Huy
            Case "CP_BEQT_CP".Trim.ToUpper
                _Return = New SysMonthToMonth
            Case "CP_BCNS42".Trim.ToUpper
                _Return = New HrToDate

            Case "CP_BCQTTCKT".Trim.ToUpper
                _Return = New QTTCKT01
            Case "CP_BCDV58", "CP_BCDV59".Trim.ToUpper
                _Return = New BCDV58
            Case "CP_BENGAY_HOPDONG".Trim.ToUpper, "CP_BENGAY_HOADON".Trim.ToUpper, "CP_BENGAY_HDTHEODOI".Trim.ToUpper _
                , "CP_BENGAY_KQBH_TVBH".Trim.ToUpper, "CP_BENGAY_KQBH_TEAM".Trim.ToUpper, "CP_BENGAY_HDTHEODOI_TEAM".Trim.ToUpper
                _Return = New SysDate

            Case "CP_BEPNHBANK".Trim.ToUpper
                _Return = New BEPNHBANK
            Case "CP_BEPNHBANK_TH".Trim.ToUpper
                _Return = New BEPNHBANK_TH
            Case "CP_BEHDXBK1_BANK".Trim.ToUpper
                _Return = New BEHDXGN1_BANK
            Case "CP_BE_KH11".Trim.ToUpper
                _Return = New BEKH11

            Case "CP_GLCD5_HD".Trim.ToUpper
                _Return = New GLCD5_HD
            Case "CP_BCPTSL_Model".Trim.ToUpper, "CP_BCPTSL_Tinh".Trim.ToUpper, "CP_BCPTSLThang".Trim.ToUpper
                _Return = New BCPTSLThang

            Case "CP_BE_DKDK".Trim.ToUpper
                _Return = New BEDKDK
            Case "CP_BE_THBGPK".Trim.ToUpper
                _Return = New BE_THBGPK

            Case "CP_DTDT".Trim.ToUpper
                _Return = New DTDT
                'Case "CP_BESO1".Trim.ToUpper, "CP_BEXSO1".Trim.ToUpper
                '    _Return = New BESO1
                'Case "CP_BETH1".Trim.ToUpper, "CP_BEBK11".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BECD1".Trim.ToUpper, "CP_BEXCD1".Trim.ToUpper
                '    _Return = New BECD1
                'Case "CP_BEBK1"
                '    _Return = New BETH1
                'Case "CP_BEBK1".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BEXTH1".Trim.ToUpper, "CP_BEXBK1".Trim.ToUpper, "CP_BEXBK11".Trim.ToUpper, "CP_BEXBK12".Trim.ToUpper, "CP_BEBK12".Trim.ToUpper
                '    _Return = New BEXTH1
                'Case "CP_BECD2".Trim.ToUpper, "CP_BEXCD2".Trim.ToUpper
                '    _Return = New BECD2
                'Case "CP_BEKQKD_HDC".Trim.ToUpper, "CP_BEKQKD_HDC_DETAIL"
                '    _Return = New BEKQKD_HDC
                'Case "CP_BEKQKD_HDX".Trim.ToUpper, "CP_BEKQKD_HDX_DETAIL"
                '    _Return = New BEKQKD_HDX
                'Case "CP_BEKH6_HDX_HDC".Trim.ToUpper, "CP_BEKH6_HDX_HDC_DETAIL"
                '    _Return = New BEKH6_HDX_HDC 

                '    'RO ------------------------------------------------------------------------------------------------------------------------------
            Case "CP_RO_DTGV".Trim.ToUpper
                _Return = New RO_DT02
            Case "CP_GLSO1DV".Trim.ToUpper
                _Return = New FGLSO1DV
            Case "CP_BCDV01"
                _Return = New BCDV01
            Case "CP_RO_99"
                _Return = New RO_99
            Case "CP_BCDV02"
                _Return = New BCDV02
            Case "CP_BCDV03"
                _Return = New BCDV03
            Case "CP_BCDV04"
                _Return = New BCDV04
            Case "CP_BCDV05"
                _Return = New BCDV05
            Case "CP_BCDV06"
                _Return = New BCDV06
            Case "CP_RO_BH01"
                _Return = New BH01
            Case "CP_BCDV10"
                _Return = New BCDV10
            Case "CP_BCDV09"
                _Return = New BCDV09
            Case "CP_BCDV13"
                _Return = New BCDV13
            Case "CP_RO_BKHIEUSUATKTV"
                _Return = New BKHieuSuatKTV
            Case "CP_RO_THHIEUSUATKTV"
                _Return = New THHieuSuatKTV
            Case "CP_INBK1"
                _Return = New INBK1
            Case "CP_BKHVN".Trim.ToUpper
                _Return = New BKHVN
            Case "CP_BKYCMH".Trim.ToUpper
                _Return = New BKYCMH
            Case "CP_BCDV13_CT"
                _Return = New BCDV13_CT
            Case "CP_BCDV99".Trim.ToUpper
                _Return = New BCDV99
    'HUNGLV
            Case "CP_BCNS41".Trim.ToUpper, "CP_BCNS42".Trim.ToUpper
                _Return = New HrDateToDate
            Case "CP_BCNS_CC4".Trim.ToUpper
                _Return = New BCNS_CC4
            Case "CP_BCDV17"
                _Return = New BCDV17
            Case "CP_RO_DT_DVGT", "CP_RO_DT_DVGT01"
                _Return = New RO_DTDVGT
            Case "CP_BKDMXE".Trim.ToUpper
                _Return = New BKDMXE
            Case "CP_RO_HDM01".Trim.ToUpper
                _Return = New RO_HDM01
            Case "CP_RO_HDM02".Trim.ToUpper
                _Return = New RO_HDM02

            Case "CP_RO_KH01".Trim.ToUpper, "CP_RO_KH02".Trim.ToUpper
                _Return = New Nam
            Case "CP_BCDV13_CT"
                _Return = New BCDV13_CT
            Case "CP_BCDV27", "CP_BCDV19"
                _Return = New BCDV24
            Case "CP_BCDV17"
                _Return = New BCDV17
            Case "CP_RO_KH03"
                _Return = New SysDate
            Case "CP_RO_KH04"
                _Return = New SysMonth
                'hieulv
            Case "CP_BCNS03B".Trim.ToUpper, "CP_BCNS19".Trim.ToUpper
                _Return = New BCNS01
            Case "CP_BK_CSBH".Trim.ToUpper
                _Return = New BE_CSBH
                'hieulv
            Case "CP_BCNS39".Trim.ToUpper
                _Return = New BCNS39
                'hieulv
            Case "CP_BCNS03B".Trim.ToUpper
                _Return = New BCNS01
            Case "CP_IMCD1_VPP".Trim.ToUpper
                _Return = New IMCD1_VPP
            Case "CP_BCNS_CC2".Trim.ToUpper
                _Return = New HrDateToDate
                'SONNt
            Case "CP_BE_DUTHUCHI"
                _Return = New SysDate
            Case "CP_BCDV37"
                _Return = New BCDV24
            Case "CP_BCDV33"
                _Return = New BCDV13
            Case "CP_BCDV43"
                _Return = New RO_HD01
            Case "CP_BCDV24"
                _Return = New RO_HD01
            Case "CP_BCDV29"
                _Return = New BCDV24
            Case "CP_BCDV41".Trim.ToUpper
                _Return = New BCDV41
            Case "CP_BCCSKH02".Trim.ToUpper
                _Return = New BCCSKH02
            Case "CP_BCCSKH04".Trim.ToUpper, "CP_BCCSKH06".Trim.ToUpper, "CP_BCCSKH07".Trim.ToUpper, "CP_BCCSKH08".Trim.ToUpper,
                "CP_BCCSKH08_Detail".Trim.ToUpper, "CP_BCCSKH09_Detail".Trim.ToUpper, "CP_BCCSKH10_Detail".Trim.ToUpper,
                 "CP_BCCSKH11_Detail".Trim.ToUpper, "CP_BCCSKH12_Detail".Trim.ToUpper, "CP_BCCSKH13_Detail".Trim.ToUpper
                _Return = New BCCSKH04
            Case "CP_BEPNGAY_BANXE".Trim.ToUpper
                _Return = New BEPNGAY_BANXE
            Case "CP_BK_LDN".Trim.ToUpper
                _Return = New BK_LDN
            Case "CP_BE_PRTROL".Trim.ToUpper
                _Return = New BK_PNL
                '--KIENPV
            Case "CP_BCDV07_01".Trim.ToUpper
                _Return = New BCDV13
            Case "CP_BE_KHO_XE_TONG".Trim.ToUpper, "CP_BE_KHO_XE_HO".Trim.ToUpper, "CP_BE_KHO_XE_TONG1".Trim.ToUpper
                _Return = New BEKhoXeTong
            Case "CP_BCNS44".Trim.ToUpper
                _Return = New BCNS44
            Case "CP_BCNS45".Trim.ToUpper
                _Return = New BCNS45
            Case "CP_BCDV88".Trim.ToUpper
                _Return = New BCDV88
            Case "CP_BE_XHD_NGAY".Trim.ToUpper
                _Return = New SysDate
                '    'RO RVR (Xe vao ra) 
                'Case "CP_RORVRBK1", "CP_RORVRTH1"
                '    _Return = New RORVRBK1
                'Case "CP_RORVRXeTon".ToUpper.Trim
                '    _Return = New RORVRXeTon
                '    'RO -HDK-HDP-HDM (Bao cao theo lenh sua chua)
                'Case "CP_ROHDKBK1"
                '    _Return = New ROHDKBK1
                'Case "CP_ROHDKTH1"
                '    _Return = New ROHDKTH1
                'Case "CP_ROBCTH_HDK", "CP_ROBCTH_HDK_DETAIL"
                '    _Return = New ROBCTHHDK
                '    'RO HDS ------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_ROBCTH_HDS", "CP_ROBCTH_HDS_DETAIL"
                '    _Return = New ROBCTHHDS
                '    'RO PT5------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_ROPT5BK1", "CP_ROPT5TH1"
                '    _Return = New ROPT5BK1
            Case "CP_KD_PKT".Trim.ToUpper
                _Return = New KD_PKT
            Case Else
                _Return = Nothing
        End Select


        V_GetFrmFilter = _Return
    End Function
    'Public Function Initvao(ByVal _Para As String()) As Boolean
    '    M_Para = _Para
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '    Dim K_Tmp As String = M_Para(1).Trim
    '    Dim K_System As String = M_Para(2).Trim
    '    Dim K_Repo As String = M_Para(3).Trim
    '    Dim K_Repo_Nt As String = M_Para(4).Trim
    '    Dim M_CYBER_VER As String = M_Para(5).Trim
    '    Dim M_User_Name As String = M_Para(6).Trim
    '    Dim M_Comment As String = M_Para(7).Trim
    '    Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '    Dim M_User_ID As String = M_Para(9).Trim
    '    Dim M_Menu_ID0 As String = M_Para(10).Trim
    '    Dim M_Bar As String = M_Para(11).Trim
    '    Dim M_Bar2 As String = M_Para(12).Trim
    '    Dim M_LAN As String = M_Para(13).Trim
    '    Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '    Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim FrmFilter As Cyber.From.FilterReport
    '    FrmFilter = V_GetFrmFilter(M_Cp_Name, "1")

    '    Dim CyberSmLib As New Cyber.SmLib.Sys
    '    Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '    oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.Para = M_Para
    '    FrmFilter.sysvar = oSysVar
    '    FrmFilter.AppConn = Appconn
    '    FrmFilter.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    M_Loai_BC = IIf(M_LAN = "V", "VND", "NT")
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.ShowDialog()
    '    If Not FrmFilter.is_continue Then Return False
    '    M_Loai_DK_Loc = "0"
    '    M_strParameterStore = FrmFilter.Tag.ToString
    '    V_Loaddata(M_Cp_Name, M_strParameterStore, oReportFormLib, "1", M_Loai_DK_Loc, FrmFilter)
    '    Return True
    'End Function
    'Private Sub V_Loaddata(ByVal sCp_name As String, ByVal strParastore As String, ByVal oReportFormLib As Cyber.Smreports.FrmRepports_Banded, ByVal loadtype As String, ByVal Loai_DK_Loc As String, Optional ByVal FrmFilter As Form = Nothing)
    '    oReportFormLib = New Cyber.Smreports.FrmRepports_Banded
    '    If FrmFilter Is Nothing Then oReportFormLib.FrmFilter = Nothing Else oReportFormLib.FrmFilter = FrmFilter
    '    oReportFormLib.SysVar = oSysVar
    '    oReportFormLib.Para = M_Para
    '    oReportFormLib.Loai_BC = M_Loai_BC
    '    oReportFormLib.Cp_name = sCp_name
    '    oReportFormLib.strParastore = strParastore
    '    oReportFormLib.strFieldValue = M_strFieldValue
    '    oReportFormLib.strFieldName = M_strFieldName
    '    oReportFormLib.Ma_Dvcs = M_Para(14).Trim ' M_Ma_Dvcs
    '    oReportFormLib.User_name = M_Para(6).Trim ' M_User_Name
    '    oReportFormLib.Loai_DK_Loc = Loai_DK_Loc
    '    oReportFormLib.Lan = M_Para(13).Trim ' M_LAN
    '    AddHandler oReportFormLib.DetailReport, AddressOf V_Detail
    '    AddHandler oReportFormLib.QuickDetailReport, AddressOf V_QuickDetail
    '    oReportFormLib.ShowDialog()
    'End Sub
    '#Region "Detail Reports"
    '    Sub V_Detail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameDetail As String, ByVal strParasource As String, ByVal strParasourceDetail As String, ByVal DrvDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        If DrvDetail Is Nothing Then Exit Sub
    '        If cpname.Trim = "" Or cpnameDetail.Trim = "" Then Exit Sub
    '        Dim oReportFrm As New Cyber.Smreports.FrmRepports_Banded
    '        Dim frm As Cyber.From.FilterReport
    '        frm = V_GetFrmFilter(cpnameDetail, "0")
    '        Dim _ParaNew As String() = V_GetPara(cpnameDetail, M_Para, strParasource)
    '        Dim _ParaOld As String() = M_Para
    '        M_Para = _ParaNew
    '        '--------------------------------------------------------------------------------------------------------------------
    '        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '        Dim K_Tmp As String = M_Para(1).Trim
    '        Dim K_System As String = M_Para(2).Trim
    '        Dim K_Repo As String = M_Para(3).Trim
    '        Dim K_Repo_Nt As String = M_Para(4).Trim
    '        Dim M_CYBER_VER As String = M_Para(5).Trim
    '        Dim M_User_Name As String = M_Para(6).Trim
    '        Dim M_Comment As String = M_Para(7).Trim
    '        Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '        Dim M_User_ID As String = M_Para(9).Trim
    '        Dim M_Menu_ID0 As String = M_Para(10).Trim
    '        Dim M_Bar As String = M_Para(11).Trim
    '        Dim M_Bar2 As String = M_Para(12).Trim
    '        Dim M_LAN As String = M_Para(13).Trim
    '        Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '        Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '        '--------------------------------------------------------------------------------------------------------------------

    '        If Not frm Is Nothing Then
    '            frm.Tag = strParasourceDetail
    '            frm.Para = M_Para
    '            frm.sysvar = oSysVar
    '            Dim CyberSmLib As New Cyber.SmLib.Sys
    '            Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '            'Dim oSysVar As New Collection()
    '            oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '            frm.AppConn = Appconn
    '            frm.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '        End If
    '        V_Loaddata(cpnameDetail, strParasourceDetail, oReportFrm, "1", Loai_DK_Loc, frm)
    '        M_Para = _ParaOld
    '    End Sub
    '    Sub V_QuickDetail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameQDetail As String, ByVal strParasource As String, ByVal strParasourceQDetail As String, ByVal DrvQDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        V_Detail(sender, e, cpname, cpnameQDetail, strParasource, strParasourceQDetail, DrvQDetail, Loai_DK_Loc)
    '    End Sub
    '#End Region
#Region "Add On F8/F9/F10/F11/F12"
    Public Function V_F8(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String) As Boolean
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F9(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F10(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F11(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F12(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
#End Region
#Region "Support"
    Public Sub V_LoadLoai_BC(ByVal chkVND As CheckBox, ByVal chkNT As CheckBox, Optional ByVal _LAN As String = "V")
        If _LAN.Trim = "V" Then
            chkVND.Checked = True
            chkNT.Checked = False
        Else
            chkVND.Checked = False
            chkNT.Checked = True
        End If
    End Sub
    Public Function GetLoai_BC(ByVal chkVND As CheckBox) As String
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function GetLoai_BC(ByVal chkVND As CheckBox, ByVal chk2 As CheckBox) As String
        If chkVND.Checked And chk2.Checked Then Return ""
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing) As DataTable
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _Ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_SysGetGD", _Ma_Ct)
        V_GetMaGD = _Ds.Tables(0).Copy
        _Ds.Dispose()
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, ByVal _Cbb As ComboBox, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing) As DataTable
        Dim _Dt As DataTable = V_GetMaGD(_App, _Ma_Ct, CyberSmlib)
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        CyberFill.V_FillComBoxDefaul(_Cbb, _Dt, "Ma_GD", "ten_GD")
    End Function
    Public Function V_GetValueCombox(ByVal _Cbb As ComboBox) As String
        Dim _Return As String = ""
        Try
            _Return = _Cbb.SelectedValue.ToString.Trim
        Catch ex As Exception
            _Return = ""
        End Try
        V_GetValueCombox = _Return
    End Function
#End Region
End Class

