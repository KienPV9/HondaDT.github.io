Imports System.Data.SqlClient
Public Class Sys
    Public Function Initvao(ByVal M_Para As String()) As Boolean
        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        Dim M_CP_Name As String = M_Para(M_VT_PARA + 1).Trim
        Dim M_User_Name As String = M_Para(6).Trim
        Dim M_Lan As String = M_Para(13).Trim
        Dim M_Ma_Dvcs As String = M_Para(14).Trim
        Dim M_Bar As String = M_Para(11).Trim
        Dim M_Bar2 As String = M_Para(12).Trim
        Dim _Title As String = "Đang thực hiện: " + M_Bar
        Dim _Title2 As String = "Processing: " + M_Bar2
        '------------------------------------------------------------------------------------------------------
        If M_CP_Name = "TOI_DIEU_HUONG_SANG_BAN_CHUAN" Then Return False
        '------------------------------------------------------------------------------------------------------
        '--CYBERSOFT Cho Phép bạn Hiệu chỉnh ở phần này
        '------------------------------------------------------------------------------------------------------
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim CyberSupport As New Cyber.Support.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        Dim CyberSmlistSys As New Cyber.SmLists.Sys
        Dim CyberSmodb As New Cyber.Smodb.Sys
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim CyberLoading = New Cyber.Loading.Loading
        Dim Appconn As SqlConnection = CyberSmlib.GetConn()
        Dim oSysvar As Collection = CyberSmlib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
        M_CP_Name = M_CP_Name.Trim.ToUpper

        Dim Frm As Cyber.From.FrmCalculator
        Select Case M_CP_Name.ToUpper
            Case "CP_ROSHD".ToUpper.ToString
                Frm = New ROSHD
            Case "CP_IMPORTDM_HIEULV".ToUpper.ToString
                Frm = New IMPORTDM
            Case "CP_ROSHD_Lenh".ToUpper.ToString
                Frm = New ROSHD_Lenh

            Case "CP_RO_TinhDD".ToUpper.ToString
                Frm = New FrmTinhDD

            Case "CP_ROSNK".ToUpper.ToString
                Frm = New ROSNK
            Case "CP_ROSDMVT".ToUpper.ToString
                Frm = New ROSDMVT
            Case "CP_ROSHD_DK".ToUpper.ToString
                Frm = New ROSHD_DK
            Case "CP_LOADDATAMAYCC".ToUpper.ToString
                Frm = New KetNoiMayCC
            Case "CP_LOADDATAJOB".ToUpper.ToString
                Frm = New DmJob
            Case "CP_SmUserDNCapTK".ToUpper.ToString
                Frm = New FrmUserName
            Case "CP_BELapKHGX_Load".ToUpper.ToString
                Frm = New BELapKHGX_Filter
            Case "CP_LOADCDKHTN".ToUpper.ToString
                Frm = New CDKHTN
            Case "CP_HR_TINHPHEP".ToUpper.ToString
                Frm = New TinhPhepNam
            Case "CP_BE_KHO_XE_LOAD".ToUpper.ToString
                Frm = New KhoXeTong
            Case "CP_UPDATEGIA2".ToUpper.ToString
                Frm = New RoUpdateGia
                'Case "CP_BEXEPXE".ToUpper.ToString
                '    Frm = New BEXEPXELOC
                  'hieulv 07-05-22: Tao chuc nang de cap nhat bien so xe moi
            Case "CP_BELAPKHGX_BIENSO".ToUpper.ToString
                Frm = New CapBienSo_Filter
            Case "CP_CRMQLLLLOAD".ToUpper.ToString
                If M_Para(M_VT_PARA + 3).ToString.Trim.ToUpper = "70" Then
                    Frm = New CRM_SK_Loc
                Else
                    Frm = New CRM_Loc
                End If
            Case Else
                Return False
        End Select
        '    ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        '    Dim Frm = New Ha
        '    Frm.Lan = M_Lan
        '    Frm.Para = M_Para
        '    Frm.Sysvar = oSysvar
        '    Frm.AppConn = Appconn
        '    Frm.CyberSmlib = CyberSmlib
        '    Frm.CyberSupport = CyberSupport
        '    Frm.CyberFill = CyberFill
        '    Frm.CyberSmlistSys = CyberSmlistSys
        '    Frm.CyberSmodb = CyberSmodb
        '    Frm.CyberExport = CyberEport
        '    Frm.CyberVoucher = CyberVoucher
        '    Frm.CyberLoading = CyberLoading
        '    Return True
        'End If

        ''-------------------SM
        'If M_CP_Name = "CP_Maintain".ToUpper.Trim Then Frm = New FrmMaintain '---Bảo trì và kiểm tra số liệu
        ''-------------------PK3/Pk4
        'If M_CP_Name = "CP_GLCTPK3Loc".Trim.ToUpper Then Frm = New FrmNam
        'If M_CP_Name = "CP_GLCTPK4Loc".Trim.ToUpper Then Frm = New GLCTPK4LOC
        'If M_CP_Name = "CP_GLCTPK8".Trim.ToUpper Then Frm = New ThangToThangTk
        'If M_CP_Name = "CP_GLClosing".Trim.ToUpper Then Frm = New ThangToThang
        ''-------------------Chuyen doi so du
        'If M_CP_Name = "CP_ConvertNextYear".Trim.ToUpper Then Frm = New ConvertNextYear
        'If M_CP_Name = "CP_ConvertNextYear".Trim.ToUpper Then M_CP_Name = M_CP_Name.Trim & M_Para(M_VT_PARA + 2).Trim
        ''-------------------Tinh gia von
        'If M_CP_Name = "CP_InGiaCost".ToUpper.Trim Then Frm = New InGiaCost '---
        ''-------------------Tinh gia von cong cu dung cu
        'If M_CP_Name = "CP_ImGiaCost".ToUpper.Trim Then Frm = New ImGiaCost '---
        'If M_CP_Name = "CP_IMTINHPB".ToUpper.Trim Then Frm = New ImTinhPB
        'If M_CP_Name = "CP_IMbtpbCC".ToUpper.Trim Then Frm = New IMBTPBCC '---Tao but toan khau hao
        'If M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then Frm = New IMThoiPbLoc '---Thoi phan bo cong cu dung cu
        ''-------------------Tai san
        'If M_CP_Name = "CP_FATINHKH".ToUpper.Trim Then Frm = New FATinhKh
        'If M_CP_Name = "CP_Fabtpbts".ToUpper.Trim Then Frm = New FABTPBTS '---Tao but toan khau hao
        'If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Then Frm = New FaSuaKHLoc '---ĐIều chỉnh khấu hao tài sản cố định
        'If M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---ĐIều chỉnh khấu hao tài sản cố định
        'If M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---ĐIều chỉnh Giam tai san co dinh
        'If M_CP_Name = "CP_FaDcTsLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---Dieu chuyen tai san
        'If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then Frm = New FATgNgLoc '---Dieu chuyen tai san

        ''-------------------Gia thanh san xuat
        'If M_CP_Name = "CP_COTINHGT".ToUpper.Trim Then Frm = New COTinhGT '---Tinh gia thanh san xuat
        'If M_CP_Name = "CP_COTINHAPGIA".ToUpper.Trim Then Frm = New COTinhApGia '---Tinh gia thanh san xuat
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        ''-----Ket thuc phan ke toan
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_BHHDLDCLOC".ToUpper.Trim Then Frm = New BHHDLDCLOC '---Tinh gia thanh san xuat
        ''-----Ket thuc phan phan he ban hang
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_VTTraCuuTon".ToUpper.Trim Then Frm = New VTTraCuuTon '---Tinh gia thanh san xuat

        ''-----Ket thuc phan phan ton kho
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        ''----Phan hệ quản lý sửa chữa
        'If M_CP_Name = "CP_ROTRANLOC".Trim.ToUpper Then Frm = New ROTRAN
        'If M_CP_Name = "CP_ROCLOSE".Trim.ToUpper Then Frm = New ROCLOSE
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        Frm.Lan = M_Lan
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading

        Frm.ShowDialog()
        CyberSmlib.FlushMemorySave()
        If Not Frm.Save_OK Then Return True
        ''--------------
        Dim M_strParameterStore As String = Frm.Tag.ToString.Trim
        If M_strParameterStore.Trim = "" Then Return True
        If M_CP_Name = "CP_BEXEPXE".ToUpper.Trim Then M_strParameterStore = "1#" + M_strParameterStore
        'hieulv
        If M_CP_Name = "CP_CRMQLLLLOAD".ToUpper.Trim Then M_strParameterStore = "1##" + M_strParameterStore

        'If M_CP_Name = "CP_BEXEPXEMAIN".ToUpper.Trim Then M_strParameterStore = "1#" + M_strParameterStore
        'If M_CP_Name = "CP_BEXEPXE".ToUpper.Trim Then M_CP_Name = "CP_BEXEPXEMAIN"
        'If M_CP_Name = "CP_ROQLGNHD".ToUpper.Trim Then M_strParameterStore = "1" & "#" & M_strParameterStore
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
        Dim DsCalculator As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, M_strParameterStore)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_CRMQLLLLoad".Trim.ToUpper Then
            ''If M_Para(M_VT_PARA + 2).ToString.Trim.ToUpper = "CA" Then Frm = New CRM_Xem_Loc_RO
            ''If M_Para(M_VT_PARA + 2).ToString.Trim.ToUpper = "CS" Then Frm = New CRM_Xem_Loc_CS
            Dim Frm1 As New CRM_Xem
            Frm1.strLoc = Frm.Tag.ToString.Trim
            '-------------
            Frm1.Loai = Frm.Key_Sub3.ToString.Trim
            Frm1.Ma_Loai = Frm.Key_Sub4.ToString.Trim
            Frm1.Ma_Ngay = Frm.Key_Sub5.ToString.Trim

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            'Exit Function
            Return True
        End If
        'If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Or M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Or M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Or M_CP_Name = "CP_FaDcTsLoc".ToUpper.Trim Or M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then
        '    Dim _Dt_Master, _Dt_Head As DataTable
        '    _Dt_Master = DsCalculator.Tables(0).Copy
        '    _Dt_Head = DsCalculator.Tables(1).Copy

        '    Dim Frm1 As FaSuaKHXem
        '    Frm1 = New FaSuaKHXem
        '    Dim M_CP_UPdate As String = ""
        '    If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaSuaKhUPDATE"
        '    If M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaThoiKHUpdate"
        '    If M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaGiamTsUpdate"
        '    If M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then M_CP_UPdate = "CP_ImThoiPBUpdate"

        '    Frm1.strLoc = M_strParameterStore
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.ShowDialog()
        '    Return True
        'End If
        ''------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then
        '    Dim _Dt_Master, _Dt_Head As DataTable
        '    _Dt_Master = DsCalculator.Tables(0).Copy
        '    _Dt_Head = DsCalculator.Tables(1).Copy


        '    Dim Frm1 As FATgNgXem
        '    Frm1 = New FATgNgXem
        '    Dim M_CP_UPdate As String = ""

        '    If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaTgNgUpDate"

        '    Frm1.strLoc = M_strParameterStore
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.ShowDialog()
        '    Return True
        'End If

        ''------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_GLCTPK3Loc".ToUpper.Trim Then
        '    Dim _Dt_Master, _Dt_Head As DataTable
        '    _Dt_Master = DsCalculator.Tables(0).Copy
        '    _Dt_Head = DsCalculator.Tables(1).Copy
        '    Dim Frm1 As GLCTPK3
        '    Frm1 = New GLCTPK3
        '    Dim M_CP_UPdate As String = ""
        '    If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaSuaKhUPDATE"
        '    If M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaThoiKHUpdate"
        '    If M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaGiamTsUpdate"

        '    Frm1.Nam = Frm.Nam
        '    Frm1.strLoc = M_strParameterStore
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.ShowDialog()
        '    Return True
        'End If
        ''------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_GLCTPK4Loc".ToUpper.Trim Then
        '    Dim _Dt_Master, _Dt_Head As DataTable
        '    _Dt_Master = DsCalculator.Tables(0).Copy
        '    _Dt_Head = DsCalculator.Tables(1).Copy
        '    Dim Frm1 As GLCTPK4
        '    Frm1 = New GLCTPK4
        '    Dim M_CP_UPdate As String = ""

        '    Frm1.Nam = Frm.Nam
        '    Frm1.strLoc = M_strParameterStore
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.ShowDialog()
        '    Return True
        'End If
        ''--------------------------------------------------------------------------------------------------------------------------------------------------------
        ''----Ban Hang
        'If M_CP_Name = "CP_BHHDLDCLOC".ToUpper.Trim Then

        '    Dim Frm1 As BHHDLDCLOCXEM
        '    Frm1 = New BHHDLDCLOCXEM

        '    Dim M_CP_UPdate As String = "CP_BHHDLDCUPDATE"

        '    Frm1.Nam = Frm.Nam
        '    Frm1.strLoc = M_strParameterStore
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.ShowDialog()
        '    Return True
        'End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_MsgChk(DsCalculator.Tables(0), oSysvar, M_Para(13).Trim)
        Return True
    End Function

End Class
