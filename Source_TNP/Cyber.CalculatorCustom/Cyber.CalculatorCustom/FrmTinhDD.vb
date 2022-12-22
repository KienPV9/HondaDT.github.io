Imports System.Windows.Forms

Public Class FrmTinhDD
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim Dt_Head_DD, Dt_Data_DD, Dt_Head_KC, Dt_Data_KC As DataTable
    Dim Dv_Head_DD, Dv_Data_DD, Dv_Head_KC, Dv_Data_Kc As DataView
    Dim M_Add_Title As String = ""
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Private Sub FrmTinhDD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Getdefault()
        V_FillThangNam()
        ChkHachToan.Checked = True
        V_Load("1")
        V_AddHandler()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#Region "Load And Set And Default"
    Private Sub V_FillThangNam()
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
    End Sub
    Private Sub V_Load(ByVal status As String)
        '--Load dữ liệu ban đầu 
        Dim _Thang As String = CbbM_Thang1.SelectedValue.ToString.Trim
        Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim

        '---------
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RO_TinhDD", status & "#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next
        If status = "1" Then
            Dt_Data_DD = Dstmp.Tables(0)
            Dt_Data_KC = Dstmp.Tables(1)

            Dt_Head_DD = Dstmp.Tables(2)
            Dt_Head_KC = Dstmp.Tables(3)


            Dv_Data_DD = New DataView(Dt_Data_DD)
            Dv_Data_Kc = New DataView(Dt_Data_KC)

            Dv_Head_DD = New DataView(Dt_Head_DD)
            Dv_Head_KC = New DataView(Dt_Head_KC)

            CyberFill.V_FillVoucher(MasterDdVTGRV, M_LAN, Dv_Head_DD, Dv_Data_DD, Nothing)
            CyberFill.V_FillVoucher(MasterKcVTGRV, M_LAN, Dv_Head_KC, Dv_Data_Kc, Nothing)
        Else
            Dt_Data_DD.Clear()
            Dt_Data_KC.Clear()

            Dt_Data_DD.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_Data_KC.Load(Dstmp.Tables(1).CreateDataReader)
        End If
        'kienpv
        For i As Integer = 0 To MasterDdVTGRV.Columns.Count - 1
            MasterDdVTGRV.Columns(i).OptionsFilter.AllowAutoFilter = True
            MasterDdVTGRV.Columns(i).OptionsFilter.AllowFilter = True
            MasterDdVTGRV.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next
        For i As Integer = 0 To MasterKcVTGRV.Columns.Count - 1
            MasterKcVTGRV.Columns(i).OptionsFilter.AllowAutoFilter = True
            MasterKcVTGRV.Columns(i).OptionsFilter.AllowFilter = True
            MasterKcVTGRV.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next
    End Sub
    Private Sub V_Getdefault()
        osysvar = Me.Sysvar
        M_LAN = Me.Lan
    End Sub
    Private Sub V_AddHandler()
        AddHandler CmdTinhToan.Click, AddressOf V_Tinh_Toan
        AddHandler CmdRefresh.Click, AddressOf V_Refresh
        AddHandler MasterDdVTGRV.RowCellStyle, AddressOf MasterDdVTGRV_RowCellStyle
        AddHandler MasterKcVTGRV.RowCellStyle, AddressOf MasterKcVTGRV_RowCellStyle

        AddHandler MasterDdVTGRV.PopupMenuShowing, AddressOf MasterDdVTGRV_PopupMenuShowing
        AddHandler MasterKcVTGRV.PopupMenuShowing, AddressOf MasterKcVTGRV_PopupMenuShowing

    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function

    Private Sub MasterDdVTGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterDdVTGRV, Dt_Data_DD, Me.Font)
    End Sub
    Private Sub MasterKcVTGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterKcVTGRV, Dt_Data_KC, Me.Font)
    End Sub

    Private Sub MasterDdVTGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_DD, Shortcut.F11, Nothing, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterKcVTGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, Nothing, True, True), False).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_Export_KC, Shortcut.F11, Nothing, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
#End Region
#Region "Tính toán/Refresh/ExportToExcel"
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Is_HT As String = IIf(ChkHachToan.Checked, "1", "0")
        Dim _Thang As String = CbbM_Thang1.SelectedValue.ToString.Trim
        Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RO_TinhDD_TinhToan", _Is_HT & "#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        Dstmp.Dispose()
        V_Load("0")
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Load("0")
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Export_DD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH LỆNH DỞ DANG TRONG THÁNG"
        Dim _Tu_Ngay As String = "THÁNG" & CbbM_Thang1.SelectedValue.ToString.Trim & " NĂM" & Me.CbbM_Nam.SelectedValue.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterDdVTGRV, _Dv_Title, Dv_Data_DD, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)

    End Sub
    Private Sub V_Export_KC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = "DANH SÁCH LỆNH ĐƯỢC KẾT CHUYỂN GIÁ VỐN TRONG KỲ"
        Dim _Tu_Ngay As String = "THÁNG" & CbbM_Thang1.SelectedValue.ToString.Trim & " NĂM" & Me.CbbM_Nam.SelectedValue.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterKcVTGRV, _Dv_Title, Dv_Data_Kc, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
#End Region
End Class
