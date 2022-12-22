Public Class IMPORTDM
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbMa_DM As New DataTable
    Dim DvMaster, DvHeader As New DataView
    Dim M_Ma_DM As String
    Private Sub ROCLOSE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct1.Value = Now.Date
        Me.Save_OK = False
        V_Load("DMVT")
        CyberFill.V_FillComBoxDefaul(CbbM_Ma_DM, tbMa_DM, "Ma_DM", IIf(Me.Lan = "V", "Ten_DM", "Ten_DM2"), "Ngam_Dinh")
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load(_Ma_DM As String)
        TxtNgay_Ct1.Value = Now
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_IMPORTDM_HIEULV", _Ma_DM + "#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbMaster = DsData.Tables(0)
        tbHeader = DsData.Tables(1)
        tbMa_DM = DsData.Tables(2)

        DvMaster = New DataView(tbMaster)
        DvHeader = New DataView(tbHeader)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile
        AddHandler CmdCheck.Click, AddressOf V_CheckData
        AddHandler CbbM_Ma_DM.SelectedValueChanged, AddressOf V_Ma_DM
    End Sub
    Private Sub V_Ma_DM(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Load(CbbM_Ma_DM.SelectedValue.ToString)
    End Sub
    Private Sub V_CheckData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Return As Boolean = True
        'Check detail
        Dim strFieldDetail As String = ""
        Dim strValueDetail As String = ""
        For i As Integer = 0 To tbMaster.Rows.Count - 1
            CyberSmodb.GetValueData(tbMaster.Rows(i), strFieldDetail, strValueDetail, "")
            Dim DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_IMPORTDM_Check", CbbM_Ma_DM.SelectedValue.ToString & "#" &
            strFieldDetail & "#" & strValueDetail & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            _Return = CyberSupport.V_MsgChk(DsChk.Tables(0), Sysvar, M_LAN)
            tbMaster.Rows(i).Item("Import_Check_Status") = DsChk.Tables(0).Rows(0).Item("Note")
            DsChk.Dispose()
            If Not _Return Then Exit For
        Next
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim dt As Date
        dt = TxtNgay_Ct1.Value
        '----------------------------------------------------------------------------
        For i As Integer = 0 To tbMaster.Rows.Count - 1
            tbMaster.Rows(i).BeginEdit()
            If tbMaster.Columns.Contains("Ma_Dvcs") Then tbMaster.Rows(i).Item("Ma_Dvcs") = M_Ma_Dvcs
            If tbMaster.Columns.Contains("Acti") Then tbMaster.Rows(i).Item("Acti") = 1
            tbMaster.Rows(i).EndEdit()
        Next
        '----------------------------------------------------------------------------       
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_LAN)
        tbMaster.AcceptChanges()
        CyberSmodb.SetNotNullTable(tbMaster)
        tbMaster.AcceptChanges()
        '---------------------------------------------------------------------------------------------------------       
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo." + CbbM_Ma_DM.SelectedValue.ToString + " WITH (NOLOCK) WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtDmImport As DataTable = DsTmp.Tables(0).Copy
        DsTmp.Dispose()
        CyberSmodb.SQLTbToTb(tbMaster, DtDmImport)
        '---------------------------------------------------------------------------------------------------------       
        Dim smKey As String = " Ma_Dvcs = N'" + M_Ma_Dvcs + "' AND 1 = 0 "
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Me.Sysvar, M_User_Name, DtDmImport, CbbM_Ma_DM.SelectedValue.ToString, "S", smKey)
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_IMPORTDM_SAVE_HIEULV", CbbM_Ma_DM.SelectedValue.ToString + "#" & M_Ma_Dvcs & "#" & M_User_Name)

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
        For Each dr As DataRow In tbImport.Select()  '"Ma_vt<>''"
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
End Class
