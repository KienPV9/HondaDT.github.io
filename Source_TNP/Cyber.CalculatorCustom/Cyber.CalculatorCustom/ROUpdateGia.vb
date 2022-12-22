Public Class RoUpdateGia
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader As New DataTable
    Dim DvMaster, DvHeader As New DataView
    Private Sub ROCLOSE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct1.Value = Now.Date
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
        TxtNgay_Ct1.Value = Now
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGetListDmGia2", M_Ma_Dvcs & "#" & M_User_Name)
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        DvMaster = New DataView(tbMaster)
        DvHeader = New DataView(tbHeader)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim dt As Date
        dt = TxtNgay_Ct1.Value
        '----------------------------------------------------------------------------
        For i As Integer = 0 To tbMaster.Rows.Count - 1
            tbMaster.Rows(i).BeginEdit()
            If tbMaster.Columns.Contains("Ma_Dvcs") Then tbMaster.Rows(i).Item("Ma_Dvcs") = M_Ma_Dvcs
            If tbMaster.Columns.Contains("Ngay_Ban") Then tbMaster.Rows(i).Item("Ngay_Ban") = dt
            If tbMaster.Columns.Contains("Gia") And tbMaster.Columns.Contains("Gia_NT") Then tbMaster.Rows(i).Item("Gia") = tbMaster.Rows(i).Item("Gia_NT")
            If tbMaster.Columns.Contains("Gia2") And tbMaster.Columns.Contains("Gia_NT2") Then tbMaster.Rows(i).Item("Gia2") = tbMaster.Rows(i).Item("Gia_NT2")
            If tbMaster.Columns.Contains("Gia3") And tbMaster.Columns.Contains("Gia_NT3") Then tbMaster.Rows(i).Item("Gia3") = tbMaster.Rows(i).Item("Gia_NT3")
            tbMaster.Rows(i).EndEdit()
        Next
        '----------------------------------------------------------------------------       
        Dim dsChekUpdate As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_RoChkUpdateGia2", dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(dsChekUpdate.Tables(0), Me.Sysvar, M_LAN) Then
            dsChekUpdate.Dispose()
            Exit Sub
        End If
        dsChekUpdate.Dispose()
        '---------------------------------------------------------------------------------------------------------
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_LAN)
        tbMaster.AcceptChanges()
        CyberSmodb.SetNotNullTable(tbMaster)
        tbMaster.AcceptChanges()
        '---------------------------------------------------------------------------------------------------------       
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.DmGia2 WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtDmGia2 As DataTable = DsTmp.Tables(0).Copy
        DsTmp.Dispose()
        CyberSmodb.SQLTbToTb(tbMaster, DtDmGia2)
        '---------------------------------------------------------------------------------------------------------       
        'Dim smKey As String = " [Ngay_Ban] = N'" + dt.ToString("yyyyMMdd") + "' AND Ma_Dvcs = N'" + M_Ma_Dvcs + "'"
        'CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, tbMaster, "DmGia2", "S", smKey)
        Dim smKey As String = " 1=1 "
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtDmGia2, "DmGia2_MEMO", "S", smKey)
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_UpdateDmVtAndDmGia2", "2#S##" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        '----------------------------------------------------------------------------       
        MsgBox("Đã thực hiện xong", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_SelectFile(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, Master1GRV, tbMaster, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        For Each dr As DataRow In tbImport.Select("Ma_vt<>''")
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
End Class
