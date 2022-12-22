Imports System.Windows.Forms

Public Class FrmLogfile
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_Head_HisLogin, Dt_Data_HisLogin, Dt_Head_HisVoucher, Dt_Data_HisVoucher, Dt_Head_HisSmList, Dt_Data_HisSmList, Dt_Head_HisReport, Dt_Data_HisReport As DataTable
    Dim Dv_Head_HisLogin, Dv_Data_HisLogin, Dv_Head_HisVoucher, Dv_Data_HisVoucher, Dv_Head_HisSmList, Dv_Data_HisSmList, Dv_Head_HisReport, Dv_Data_HisReport As DataView
    Dim M_Add_Title As String = ""
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Private Sub FrmLogfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        osysvar = Me.Sysvar
        M_LAN = Me.Lan
        TxtNgay_Ct1.Value = Now.Date()
        TxtNgay_Ct2.Value = Now.Date().AddHours(23).AddMinutes(59)
        V_Load("1")
        V_AddHandler()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load(ByVal status)
        '--Load dữ liệu ban đầu 
        Dim Dt1 As DateTime = TxtNgay_Ct1.Value
        Dim Dt2 As DateTime = TxtNgay_Ct2.Value

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmViewLog", status + "#" + Dt1.ToString("yyyyMMdd HH:mm") & "#" & Dt2.ToString("yyyyMMdd HH:mm") & "#" & TxtUser.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If status = "1" Then

            Dt_Head_HisLogin = Dstmp.Tables(4)
            Dt_Head_HisVoucher = Dstmp.Tables(5)
            Dt_Head_HisSmList = Dstmp.Tables(6)
            Dt_Head_HisReport = Dstmp.Tables(7)

            Dt_Data_HisLogin = Dstmp.Tables(0)
            Dt_Data_HisVoucher = Dstmp.Tables(1)
            Dt_Data_HisSmList = Dstmp.Tables(2)
            Dt_Data_HisReport = Dstmp.Tables(3)

            Dv_Data_HisLogin = New DataView(Dt_Data_HisLogin)
            Dv_Data_HisVoucher = New DataView(Dt_Data_HisVoucher)
            Dv_Data_HisSmList = New DataView(Dt_Data_HisSmList)
            Dv_Data_HisReport = New DataView(Dt_Data_HisReport)

            Dv_Head_HisLogin = New DataView(Dt_Head_HisLogin)
            Dv_Head_HisVoucher = New DataView(Dt_Head_HisVoucher)
            Dv_Head_HisSmList = New DataView(Dt_Head_HisSmList)
            Dv_Head_HisReport = New DataView(Dt_Head_HisReport)

            CyberFill.V_FillVoucher(MasterHisLoginGRV, M_LAN, Dv_Head_HisLogin, Dv_Data_HisLogin, Nothing)
            CyberFill.V_FillVoucher(MasterHisVoucherGRV, M_LAN, Dv_Head_HisVoucher, Dv_Data_HisVoucher, Nothing)
            CyberFill.V_FillVoucher(MasterHisSmListGRV, M_LAN, Dv_Head_HisSmList, Dv_Data_HisSmList, Nothing)
            CyberFill.V_FillVoucher(MasterHisReportGRV, M_LAN, Dv_Head_HisReport, Dv_Data_HisReport, Nothing)

        Else
            Dt_Data_HisLogin.Clear()
            Dt_Data_HisVoucher.Clear()
            Dt_Data_HisSmList.Clear()
            Dt_Data_HisReport.Clear()
            Dt_Data_HisLogin.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_Data_HisVoucher.Load(Dstmp.Tables(1).CreateDataReader)
            Dt_Data_HisSmList.Load(Dstmp.Tables(2).CreateDataReader)
            Dt_Data_HisReport.Load(Dstmp.Tables(3).CreateDataReader)
        End If
    End Sub
    Private Sub V_ReFresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Load("0")
    End Sub
    Private Sub V_AddHandler()
        AddHandler CmdSearch.Click, AddressOf V_ReFresh

        AddHandler MasterHisLoginGRV.RowCellStyle, AddressOf MasterHisLoginGRV_RowCellStyle
        AddHandler MasterHisVoucherGRV.RowCellStyle, AddressOf MasterHisVoucherGRV_RowCellStyle
        AddHandler MasterHisSmListGRV.RowCellStyle, AddressOf MasterHisSmListGRV_RowCellStyle
        AddHandler MasterHisReportGRV.RowCellStyle, AddressOf MasterHisReportGRV_RowCellStyle

        AddHandler MasterHisLoginGRV.PopupMenuShowing, AddressOf MasterHisLoginGRV_PopupMenuShowing
        AddHandler MasterHisVoucherGRV.PopupMenuShowing, AddressOf MasterHisVoucherGRV_PopupMenuShowing
        AddHandler MasterHisSmListGRV.PopupMenuShowing, AddressOf MasterHisSmListGRV_PopupMenuShowing
        AddHandler MasterHisReportGRV.PopupMenuShowing, AddressOf MasterHisReportGRV_PopupMenuShowing

        '--User
        AddHandler TxtUser.CyberValiting, AddressOf V_Username
        AddHandler TxtUser.CyberLeave, AddressOf L_Username

    End Sub
#Region "Valid User"
    Private Sub V_Username(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtUser.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "User_name", "Userinfo", "1=1", "1=1")
    End Sub
    Private Sub L_Username(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtUser.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtUser.Text = DrReturn.Item("User_name")
            TxtComment.Text = DrReturn.Item("Comment")
        Else
            TxtUser.Text = ""
            TxtComment.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
    Private Sub MasterHisLoginGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterHisLoginGRV, Dt_Data_HisLogin, Me.Font)
    End Sub
    Private Sub MasterHisVoucherGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterHisVoucherGRV, Dt_Data_HisVoucher, Me.Font)
    End Sub
    Private Sub MasterHisSmListGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterHisSmListGRV, Dt_Data_HisSmList, Me.Font)
    End Sub
    Private Sub MasterHisReportGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterHisVoucherGRV, Dt_Data_HisReport, Me.Font)
    End Sub
    Private Sub MasterHisLoginGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_login, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisVoucherGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_Voucher, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisSmListGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_SmList, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterHisReportGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_ReFresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_Report, Shortcut.F11, My.Resources.edit_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
#End Region
#Region "Export  + Exit"
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Export_login(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN TRUY CẬP PHẦN MỀM"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterHisLoginGRV, _Dv_Title, Dv_Data_HisLogin, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_Voucher(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN CHỨNG TỪ"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterHisVoucherGRV, _Dv_Title, Dv_Data_HisVoucher, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_SmList(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN DANH MỤC"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterHisSmListGRV, _Dv_Title, Dv_Data_HisSmList, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_Report(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH TÀI KHOẢN THAO TÁC TRÊN BÁO CÁO"
        Dim _Tu_Ngay As String = "Từ ngày" & TxtNgay_Ct1.Text & " đến ngày" & TxtNgay_Ct2.Text
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterHisReportGRV, _Dv_Title, Dv_Data_HisReport, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
#End Region
End Class
