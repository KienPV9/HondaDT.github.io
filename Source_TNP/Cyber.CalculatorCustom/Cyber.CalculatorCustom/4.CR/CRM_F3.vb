Imports System.Windows.Forms
Public Class CRM_F3
#Region "AddProperty"
    Dim M_Loai As String
    Public Property Loai() As String
        Get
            Loai = M_Loai
        End Get
        Set(ByVal Value As String)
            M_Loai = Value
        End Set
    End Property
    Dim M_Ma_Loai As String
    Public Property Ma_Loai() As String
        Get
            Ma_Loai = M_Ma_Loai
        End Get
        Set(ByVal Value As String)
            M_Ma_Loai = Value
        End Set
    End Property
    Dim M_Ma_Ngay As String
    Public Property Ma_Ngay() As String
        Get
            Ma_Ngay = M_Ma_Ngay
        End Get
        Set(ByVal Value As String)
            M_Ma_Ngay = Value
        End Set
    End Property
    Dim M_Ma_Get As String
    Public Property Ma_Get() As String
        Get
            Ma_Get = M_Ma_Get
        End Get
        Set(ByVal Value As String)
            M_Ma_Get = Value
        End Set
    End Property
    Dim M_Ma_Get1 As String
    Public Property Ma_Get1() As String
        Get
            Ma_Get1 = M_Ma_Get1
        End Get
        Set(ByVal Value As String)
            M_Ma_Get1 = Value
        End Set
    End Property
    Dim M_Drv_Load As DataRowView
    Public Property Drv_Load() As DataRowView
        Get
            Drv_Load = M_Drv_Load
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv_Load = Value
        End Set
    End Property
#End Region
#Region "Declare "
    'Dim CyberCalculatorUserControlMa_CH As Cyber.Calculator.UserControlMa_CH
    'Dim CyberCalculator As New Cyber.Calculator.Sys

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_HTLL As DataTable
    Dim _Dt_KQ1, _Dt_KQ2, _Dt_KQ3 As DataTable

    Dim _Dt_Ly_Do1, _Dt_Ly_Do2, _Dt_Ly_Do3 As DataTable
    Dim _Dv_Ly_Do1, _Dv_Ly_Do2, _Dv_Ly_Do3 As DataView
    Dim _Dt_Gx As DataTable
    Dim _Dt_LHGx As DataTable
    Dim _Dv_LHGx As DataView
    Dim _Dt_DMCH, _Dt_TL, _DT_CRMQLLLCT As DataTable

#End Region
    Private Sub CRM_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_LL_Lan1.Value = Now.Date
        TxtNgay_LL_Lan2.Value = Now.Date
        TxtNgay_LL_Lan3.Value = Now.Date
        '--------------------------------------------------------------------
        
        V_Load()
        '--------------------------------------------------------------------
        V_Addhander()
        '--------------------------------------------------------------------
        V_Load_Lan2_Lan3()
        '--------------------------------------------------------------------
        V_HeadThongTinGD()
        '--------------------------------------------------------------------
        V_AddPanel()
        '--------------------------------------------------------------------
        V_Lan2(New System.Object, New System.EventArgs)
        V_Lan3(New System.Object, New System.EventArgs)
        '--------------------------------------------------------------------
        'Me.Text = Me.Key_Sub2.ToString.Trim
        'Me.ButtAttach.Image = Global.Cyber.Calculator.My.Resources.Resources.attachment_16x16
        '--------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '--------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLLoadInfo", M_Ma_Get + "#" + M_Ma_Get1 + "#" + M_Loai + "#" + M_Ma_Loai + "#" + M_Ma_Ngay + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        Dim iTb As Integer = 0
        _Dt_DMCH = Dstmp.Tables(iTb).Copy()
        iTb = iTb + 1

        _Dt_TL = Dstmp.Tables(iTb).Copy()
        iTb = iTb + 1

        _DT_CRMQLLLCT = Dstmp.Tables(iTb).Clone
        iTb = iTb + 1
        '---------------------------------------------------------------------------------------
        _Dt_HTLL = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        _Dt_KQ1 = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        _Dt_KQ2 = _Dt_KQ1.Copy
        _Dt_KQ3 = _Dt_KQ1.Copy

        _Dt_Ly_Do1 = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        _Dt_Ly_Do2 = _Dt_Ly_Do1.Copy
        _Dt_Ly_Do3 = _Dt_Ly_Do1.Copy
        '-----------------------------

        _Dt_Gx = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        _Dt_LHGx = Dstmp.Tables(iTb).Copy()
        iTb = iTb + 1

        '---------------------------------------------------------------------------------------
        _Dv_Ly_Do1 = New DataView(_Dt_Ly_Do1)
        _Dv_Ly_Do2 = New DataView(_Dt_Ly_Do2)
        _Dv_Ly_Do3 = New DataView(_Dt_Ly_Do3)
        _Dv_LHGx = New DataView(_Dt_LHGx)
        '----------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, _Dt_HTLL, "Ma_HTLL", "Ten_HTLL", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_KQ1, _Dt_KQ1, "MA_KQ", "Ten_KQ", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_KQ2, _Dt_KQ2, "MA_KQ", "Ten_KQ", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_KQ3, _Dt_KQ3, "MA_KQ", "Ten_KQ", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbLy_Do1, _Dv_Ly_Do1, "Ly_Do", "Ten_Ly_Do", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbLy_Do2, _Dv_Ly_Do2, "Ly_Do", "Ten_Ly_Do", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbLy_Do3, _Dv_Ly_Do3, "Ly_Do", "Ten_Ly_Do", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_GX, _Dt_Gx, "Ma_GX", "Ten_Gx", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_LHGX, _Dv_LHGx, "Ma_LHGX", "Ten_LHGX", "Ngam_Dinh")

        CyberSmodb.SetValueTObj(Me, M_Drv_Load)

        V_FilterLy_Do(CmbMa_KQ1, _Dv_Ly_Do1)
        V_FilterLy_Do(CmbMa_KQ2, _Dv_Ly_Do2)
        V_FilterLy_Do(CmbMa_KQ3, _Dv_Ly_Do3)
        V_FilterGX()

        CyberSmodb.SetValueFromCombox(CmbLy_Do1, M_Drv_Load.Item("Ly_Do1"))
        CyberSmodb.SetValueFromCombox(CmbLy_Do2, M_Drv_Load.Item("Ly_Do2"))
        CyberSmodb.SetValueFromCombox(CmbLy_Do3, M_Drv_Load.Item("Ly_Do3"))

        Dstmp.Dispose()
    End Sub
    Private Sub V_FilterGX()
        If _Dv_LHGx Is Nothing Then Return
        Dim _Ma_Gx As String = CyberSmodb.GetvalueFromCombox(CbbMa_GX)
        Dim _Filter As String = "1=1"
        If _Dv_LHGx.Table.Columns.Contains("Ma_Gx") Then _Filter = "Ma_Gx = '" + _Ma_Gx + "'"
        Try
            _Dv_LHGx.RowFilter = _Filter
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_FilterLy_Do(ByVal CbbKQ As System.Windows.Forms.ComboBox, ByRef _Dv As DataView)
        If _Dv Is Nothing Then Return
        Dim _Ma_KQ As String = CyberSmodb.GetvalueFromCombox(CbbKQ)
        Dim _Filter As String = "1=1"
        If _Dv.Table.Columns.Contains("Ma_KQ") Then _Filter = "Ma_KQ = '" + _Ma_KQ + "'"
        Try
            _Dv.RowFilter = _Filter
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler CmbSms.Click, AddressOf V_Sms
        AddHandler CmdLich_Su.Click, AddressOf V_Lich_Su
        AddHandler CmdDat_Lich.Click, AddressOf V_Dat_Lich
        AddHandler CmdDSLich_Hen.Click, AddressOf V_Ds_Dat_Lich
        AddHandler CmdHan_BH.Click, AddressOf V_Han_BH
        AddHandler CmdAttach.Click, AddressOf V_Attach
        AddHandler CmdCap_Nhap_Km.Click, AddressOf V_Cap_Nhap_Km

        AddHandler CmbbKhieu_Nai.Click, AddressOf V_Khieu_Nai
        AddHandler CmbbThac_Mac.Click, AddressOf V_Thac_Mac

        '------------------------------------------------------------------------
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler CbbMa_GX.SelectedValueChanged, AddressOf V_Ma_Gx
        AddHandler TxtMa_CS.CyberValiting, AddressOf V_Ma_CS
        AddHandler TxtMa_CS.CyberLeave, AddressOf L_Ma_CS
        '------------------------------------------------------------------------
        AddHandler ChkLan2.CheckedChanged, AddressOf V_Lan2
        AddHandler ChkLan3.CheckedChanged, AddressOf V_Lan3
        AddHandler TxtTg_LL_Lan1.Leave, AddressOf V_Tg_LL_Lan1
        AddHandler TxtTg_LL_Lan2.Leave, AddressOf V_Tg_LL_Lan2
        AddHandler TxtTg_LL_Lan3.Leave, AddressOf V_Tg_LL_Lan3
        AddHandler CmbMa_KQ1.SelectedValueChanged, AddressOf V_Ma_KQ1
        AddHandler CmbMa_KQ2.SelectedValueChanged, AddressOf V_Ma_KQ2
        AddHandler CmbMa_KQ3.SelectedValueChanged, AddressOf V_Ma_KQ3
    End Sub
#Region "Ma_CS/Ma_GX/Ma_Xe/Caption_Ma_HD/Add Control Panel"
    Private Sub V_Ma_CS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CS.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CS.Text = "" Then
            TxtTen_Cs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CS.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Cs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_CS.Text = ""
            TxtTen_Cs.Text = ""
        End If
    End Sub
    Private Sub V_Ma_Gx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterGX()
    End Sub
    Private Sub V_HeadThongTinGD()
        Dim _Ma_Phan_He As String = TxtMa_Phan_He.Text.Trim
        'If M_Loai = "BE" Then
        '    LabelNgay1.Text = "Ngày HĐ"
        '    LabelNgay2.Text = "Ngày giao xe"
        '    LabelMa_Get.Text = "Mã HĐ"
        'Else
        '    LabelNgay1.Text = "Lệnh ngày"
        '    LabelNgay2.Text = "Nghiệm thu"
        '    LabelMa_Get.Text = "Số R/0"
        '    TxtMa_Xe.ReadOnly = True
        '    TxtSo_Km.ReadOnly = True
        'End If
        If _Ma_Phan_He = "BE" Then
            LabelNgay1.Text = "Ngày HĐ"
            LabelNgay2.Text = "Ngày giao xe"
            LabelMa_Get.Text = "Mã HĐ"
        Else
            LabelNgay1.Text = "Lệnh ngày"
            LabelNgay2.Text = "Nghiệm thu"
            LabelMa_Get.Text = "Số R/0"
            TxtMa_Xe.ReadOnly = True
            TxtSo_Km.ReadOnly = True
        End If
        If TxtTg_LL_Lan1.Text = "" Then TxtTg_LL_Lan1.Text = CyberVoucher.V_GetTG(Strings.Right("00" + Now.Hour.ToString, 2) & Strings.Right("00" + Now.Minute.ToString.Trim, 2), 0)
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
    Private Sub V_AddPanel()
        Dim CyberColor As New Cyber.Color.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        For i As Integer = _Dt_DMCH.Rows.Count - 1 To 0 Step -1
            'Dim _Ma_CH As New UserControlMa_CH
            Dim _Ma_CH As New Cyber.Calculator.UserControlMa_CH
            _Ma_CH.Name = "ALLPANELMA_CH_" + i.ToString.Trim
            _Ma_CH.Dock = Windows.Forms.DockStyle.Top
            _Ma_CH.V_load(_Dt_DMCH.Rows(i), _Dt_TL, CyberColor, CyberFill)
            _Ma_CH.Visible = True
            PanMa_CH.Controls.Add(_Ma_CH)
        Next
    End Sub
#End Region
#Region "Nút lệnh Sms/LSSC/Attach/DL Hẹn,..Cập nhập Số Km"
    Private Sub V_Sms(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Ct As String = ""
        Dim _Tele As String = txtDien_Thoai.Text
        Dim _Sms As String = ""
        CyberSupport.V_Sms(AppConn, Para, Sysvar, Me.Lan, M_Ma_Get1, _Ma_Ct, M_Ma_Dvcs, M_User_Name, _Tele, _Sms, CyberSmlib, CyberSmodb)
    End Sub
    Private Sub V_Lich_Su(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_Stt_Rec As String = ""
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", M_Stt_Rec, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_Ma_Hs As String = ""
        Dim M_Ten_Hs As String = ""

        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _Date As Date = New Date(1900, 1, 1)
        Dim _Loai_SC As String = "1"
        Dim M_Ma_TTCP_H As String = CyberSupport.V_GetDefault_TTCP("DLH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP_H, "DLH", "M", "HEN", _Loai_SC, "", "", M_Ma_Hs, "", TxtMa_Xe.Text, "", "", _Date, _Date, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Ds_Dat_Lich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _StrFilter As String = "HEN#1#" & "" & "#" & TxtMa_Xe.Text & "#" & "" & "#" & "19000101" & "#" & "19000101" & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim _Title As String = "DANH SÁCH LỊCH HẸN SỬA CHỮA"
        'CyberSupport.V_WorkView("CP_WorkDLH", _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        CyberWork.V_Xem_Ds_Hen("HEN", "1", "", TxtMa_Xe.Text, "", Now.Date, Now.Date, True, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Han_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Thamsobaohiem("HDK", TxtMa_Xe.Text, txtTen_kh.Text, TxtDia_Chi.Text, txtDien_Thoai.Text, txtDien_Thoai.Text)
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
        'Dim Frm As New FrmbaoHiem
        Dim Frm As New Cyber.Input.FrmbaoHiem

        Frm._Dr = dsBaohiem.Tables(0).Rows(0)
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Sysvar
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
    Private Sub V_Attach(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Get1.Text.Trim <> "" Then CyberSupport.V_AttachFile(AppConn, Me.Para, Me.Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name, TxtMa_Get1.Text.Trim, "")
    End Sub
    Private Sub V_Cap_Nhap_Km(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_DmSokmXe(AppConn, Sysvar, Me.Para, TxtMa_Xe.Text, M_LAN, False, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading)
    End Sub
    Private Sub V_Khieu_Nai(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _So_Ro As String = ""
        Dim _Ma_HD As String = ""
        Dim _Ma_GD As String = ""
        If M_Ma_Loai = "25" Then
            _Ma_GD = "3"
            _Ma_HD = TxtMa_Get1.Text.Trim
            _So_Ro = ""
        Else

            _Ma_GD = "1"
            _So_Ro = TxtMa_Get1.Text.Trim
            _Ma_HD = ""
        End If

        Dim strAddParar As String = _Ma_GD & "#VOC#10#" & _Ma_HD & "#" & _So_Ro & "#" & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)


    End Sub
    Private Sub V_Thac_mac(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _So_Ro As String = ""
        Dim _Ma_HD As String = ""
        Dim _Ma_GD As String = ""
        If M_Ma_Loai = "25" Then
            _Ma_GD = "3"
            _Ma_HD = TxtMa_Get1.Text.Trim
            _So_Ro = ""
        Else

            _Ma_GD = "1"
            _So_Ro = TxtMa_Get1.Text.Trim
            _Ma_HD = ""
        End If

        Dim strAddParar As String = _Ma_GD & "#VOD#10#" & _Ma_HD & "#" & _So_Ro & "#" & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)

    End Sub
#End Region
#Region "------ KQ"
    Private Sub V_Ma_KQ1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterLy_Do(CmbMa_KQ1, _Dv_Ly_Do1)
    End Sub
    Private Sub V_Ma_KQ2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterLy_Do(CmbMa_KQ2, _Dv_Ly_Do2)
    End Sub
    Private Sub V_Ma_KQ3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterLy_Do(CmbMa_KQ3, _Dv_Ly_Do3)
    End Sub
#End Region
#Region "------ Lan 2; Lan 3"
    Private Sub V_Load_Lan2_Lan3()
        V_Enabled_Lan2()
        V_Enabled_Lan3()
    End Sub
    Private Sub V_Lan2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Enabled_Lan2()
        If Not ChkLan2.Checked Then Exit Sub
        If TxtTg_LL_Lan2.Text.Trim = "" Then TxtTg_LL_Lan2.Text = CyberVoucher.V_GetTG(TxtTg_LL_Lan2.Text, 0)
    End Sub
    Private Sub V_Lan3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Enabled_Lan3()
        If Not ChkLan3.Checked Then Exit Sub
        If TxtTg_LL_Lan3.Text.Trim = "" Then TxtTg_LL_Lan3.Text = CyberVoucher.V_GetTG(TxtTg_LL_Lan3.Text, 0)
    End Sub
    Private Sub V_Enabled_Lan2()
        Dim _En As Boolean = ChkLan2.Checked
        TxtNgay_LL_Lan2.Enabled = _En
        TxtTg_LL_Lan2.Enabled = _En
        TxtTg_LL_Lan2.Enabled = _En
        CmbMa_KQ2.Enabled = _En
        TxtDien_Giai_Lan2.Enabled = _En
        CmbLy_Do2.Enabled = _En
        If Not _En Then
            ChkLan3.Checked = False
            V_Enabled_Lan3()
        End If
        ChkLan3.Enabled = _En
    End Sub
    Private Sub V_Enabled_Lan3()
        Dim _En As Boolean = ChkLan3.Checked
        TxtNgay_LL_Lan3.Enabled = _En
        TxtTg_LL_Lan3.Enabled = _En
        CmbMa_KQ3.Enabled = _En
        CmbLy_Do2.Enabled = _En
        TxtDien_Giai_Lan3.Enabled = _En
    End Sub
    Private Sub V_Tg_LL_Lan1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTg_LL_Lan1.Text = CyberVoucher.V_GetTG(TxtTg_LL_Lan1.Text, 0)
    End Sub
    Private Sub V_Tg_LL_Lan2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTg_LL_Lan2.Text = CyberVoucher.V_GetTG(TxtTg_LL_Lan2.Text, 0)
    End Sub
    Private Sub V_Tg_LL_Lan3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTg_LL_Lan3.Text = CyberVoucher.V_GetTG(TxtTg_LL_Lan3.Text, 0)
    End Sub
#End Region
#Region "------ Save/Close"
    Public M_Dt_Return As DataTable
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        '---------------------------------------------------------------------------------------------------------
        ' If Not Add2Database() Then Exit Sub
        '---------------------------------------------------------------------------------------------------------
        Dim _PH As DataTable = Drv_Load.DataView.Table.Clone

        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        drMaster = _PH.NewRow
        drMaster.BeginEdit()
        CyberSmodb.SetValueBlankRow(drMaster)
        CyberSmodb.AddValueToRow(drMaster, Me)
        drMaster.Item("Ma_Get") = M_Ma_Get
        drMaster.EndEdit()
        _PH.Rows.Add(drMaster)
        _PH.AcceptChanges()

        _DT_CRMQLLLCT.Clear()
        V_ControlToData()


        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"CRMQLLL", "CRMQLLLCT"}, {CyberSmodb.V_ConvertDrToTb(drMaster), _DT_CRMQLLLCT})


        Dim M_strParameterStore As String = M_Loai + "#" + M_Ma_Loai + "#" + M_Ma_Ngay + "#" + M_Ma_Get + "#" + M_Ma_Get1 + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLSave", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            DsTmp.Dispose()
            Exit Sub
        Else
            Me.Tag = M_Ma_Get
            Me.M_Dt_Return = DsTmp.Tables(0).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
        End If
        '---------------------------------------------------------------------------------------------------------
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    '    Private Function Add2Database() As Boolean
    '        Dim _Dt As DataTable = Drv.DataView.Table.Clone
    '        Dim _DrSave As DataRow = _Dt.NewRow
    '        CyberSmodb.SetValueBlankRow(_DrSave)
    '        Dim _Colname As String = ""

    '        For i = 0 To _Dt.Columns.Count - 1
    '            _Colname = _Dt.Columns(i).ColumnName
    '            _DrSave.Item(_Colname) = Drv.Item(_Colname)
    '        Next
    '        CyberSmodb.AddValueToRow(_DrSave, Me)
    '        _DrSave.Item("Ma_Dvcs") = M_Ma_Dvcs
    '        _DrSave.Item("User_id") = M_User_ID.Trim
    '        _Dt.Rows.Add(_DrSave)
    '        '---------------------------------------
    '        Dim _Ngay_Ct As Date = TxtNgay1.Value
    '        Dim _strDate As String = _Ngay_Ct.ToString("yyyyMMdd")
    '        Dim _Ma_Loai As String = Drv.Item("Ma_Loai").ToString.Trim
    '        Dim _Ma_Get As String = Drv.Item("Ma_Get").ToString.Trim
    '        Dim _Ma_HS As String = "" 'Drv.Item("Ma_HS").ToString.Trim
    '        Dim _Ma_Xe As String = "" 'Drv.Item("Ma_Xe").ToString.Trim
    '        Dim _Ma_Kx As String = "" 'Drv.Item("Ma_Kx").ToString.Trim
    '        Dim _Ma_Mau As String = "" 'Drv.Item("Ma_Mau").ToString.Trim
    '        '---------------------------------------
    '        Dim _Key As String = "(Ma_Loai = N'" + _Ma_Loai.Trim + "') AND (Ma_Get = N'" + _Ma_Get.Trim + "')"
    '        If Not CyberSmodb.V_SaveToSQL(AppConn, Me.Sysvar, M_User_Name, _DrSave, "CRMQLLL", "S", _Key) Then Return False
    '        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLLoad", "0#" + M_Ma_Loai + "#" + _strDate + "#" + _strDate + "#" + _Ma_Get + "#" + "#" + _Ma_HS + _Ma_Xe + "#" + _Ma_Kx + "#" + _Ma_Mau + "#" + M_Ma_Dvcs + "#" + M_User_Name)
    '        If DsTmp.Tables.Count <= 0 Then
    '            DsTmp.Dispose()
    '            Return False
    '        End If
    '        If DsTmp.Tables(0).Rows.Count <= 0 Then
    '            DsTmp.Dispose()
    '            Return False
    '        End If

    '        Dim _Drv_Return As DataRowView
    '        Dim _Dt_Return As DataTable = DsTmp.Tables(0).Copy
    '        M_Drv = New DataView(_Dt_Return).Item(0)
    '        Me.Drv = New DataView(_Dt_Return).Item(0)
    '        DsTmp.Dispose()
    '        Return True
    '    End Function
    Private Sub V_ControlToData()
        For i = 0 To PanMa_CH.Controls.Count - 1
            If Not PanMa_CH.Controls(i).Name.Contains("ALLPANELMA_CH_") Then Continue For
            Dim _Dr As DataRow = _DT_CRMQLLLCT.NewRow
            V_ControlToData(_Dr, PanMa_CH.Controls(i))
            _Dr.Item("Ma_Get") = Drv_Load.Item("Ma_Get").ToString.Trim
            _Dr.Item("Ma_Loai") = M_Ma_Loai
            _DT_CRMQLLLCT.Rows.Add(_Dr)
        Next
        _DT_CRMQLLLCT.AcceptChanges()
    End Sub
    Private Sub V_ControlToData(ByVal DR As DataRow, ByVal CtrPan As Control)
        For Each dc As DataColumn In DR.Table.Columns

            For Each ctr As Object In CtrPan.Controls
                If ctr.Name.Substring(3).ToString().Trim().ToUpper() <> dc.ColumnName.Trim.ToUpper() Then Continue For
                Select Case ctr.GetType.Name.ToString().ToUpper()
                    Case "TXTDATE", "TXTDATE1"
                        DR(dc.ColumnName) = ctr.value
                    Case "TXTTIEN"
                        DR(dc.ColumnName) = ctr.SelectedValue
                    Case "COMBOBOX"
                        Try
                            DR(dc.ColumnName) = ctr.SelectedValue.ToString.Trim
                        Catch ex As Exception
                        End Try
                    Case "CHECKBOX"
                        DR(dc.ColumnName) = IIf(ctr.Checked, "1", "0")
                    Case Else
                        DR(dc.ColumnName) = ctr.Text.Trim
                End Select


            Next
        Next
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
#End Region
End Class

