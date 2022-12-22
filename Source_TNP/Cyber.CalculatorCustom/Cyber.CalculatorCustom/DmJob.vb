Imports System.Windows.Forms
Imports MayChamCong
Public Class DmJob
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbThamSo As New DataTable
    Dim DtThang, DtNam As DataTable
    Dim DvMaster, DvHeader As New DataView
    Dim _ChamCong As MayChamCong.mayChamcong
    Private Sub ROTINHMIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim mnItemsMail = New ContextMenu
        'Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        'Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)
        'mnItemsMail.MenuItems.Add(mnItemsF4)
        'mnItemsMail.MenuItems.Add(mnItemsF8)
        'Me.ContextMenu = mnItemsMail
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOADDATAJob", TxtMa_Hs.Text.Trim & "#" & TxtMa_Phan_He.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbHeader = DsData.Tables(0)
        tbMaster = DsData.Tables(1)
        DvHeader = New DataView(tbHeader)
        DvMaster = New DataView(tbMaster)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
        ' 
        TxtNgay_Ct.Value = Date.Now()
        '-----------------------------------------------------------------------
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmbbImportExcel.Click, AddressOf V_ImportExcel
        AddHandler CmdGetData.Click, AddressOf V_LoadData
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
    End Sub
#Region "Cmd..."
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberLoading.V_ShowWailtForm("V")
        'Xóa dữ liệu
        Dim _strField As String = "", _strValue As String = ""
        Dim Ngay_ct As Date = TxtNgay_Ct.Value
        'CyberSmodb.GetValueControler(Me, _strField, _strValue)
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOADDATAJob_Delete", "" & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        ''update ttin
        'For i = 0 To tbMaster.Rows.Count() - 1
        '    tbMaster.Rows(i).Item("Ngay_Lay") = Ngay_ct
        '    tbMaster.Rows(i).Item("Ma_Dvcs") = Me.M_Ma_Dvcs
        'Next
        'tbMaster.AcceptChanges()
        'hieulv đổ cả table lên để save
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Sysvar, M_User_Name, tbMaster, "DmJob_Temp", "S", "1 = 1", False)
        '
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOADDATAJob_Save", "" & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        MsgBox("Đã lưu dữ liệu", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        CyberLoading.V_CloseWailtForm()

        V_Load()
    End Sub
    Private Sub V_ImportExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, Master1GRV, tbMaster, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        tbMaster.Clear()
        For Each dr As DataRow In tbImport.Select("1=1")
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "NGÀY " & Date.Now.ToShortDateString
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Master1GRV, _Dv_Title, DvMaster, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_ChamCong.xls")
    End Sub
    Private Sub V_LoadData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        CyberLoading.V_ShowWailtForm("V")

        V_Load()
        '
        CyberLoading.V_CloseWailtForm()
    End Sub
#End Region
#Region "Valid Master"
#End Region
End Class
