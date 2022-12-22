Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class TinhPhepNam
    Dim M_Cp_Name As String
    Dim DtThang, DtNam As DataTable
    Dim Dt_Master1, Dt_Head1 As DataTable
    Dim DtDvcs, DtTTCP As DataTable
    Dim Dv_Master1, Dv_Head1 As DataView
    Dim DrReturn, DrReturn02 As DataRow
    Dim vTbTTCP As DataView
    Dim DsLookup, DsLookup02 As DataSet
    Dim M_Http_Api As String
    Private Sub ApiSAPNS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Cp_Name = "CP_HR_TinhPHEP"
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")

        AddHandler ButtOK.Click, AddressOf V_Nhan
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        '--------------------------------------------------------------------
        DtDvcs = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmDvcs", "Ma_Dvcs", "1 =1", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, DtDvcs, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)

        V_LoadDatatabse("0")
        'V_MainSystem()
        AddHander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load Nam - Thang"
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year
        Dim _Nam As String
        Dim _Default As String
        For i As Integer = 2022 To 2030 '_CurYear - 5 To _CurYear + 5
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim
            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, _Nam, _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#End Region
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsSave As New MenuItem("Chọn tất cả (Ctrl+A)", AddressOf V_Selected, Keys.Control + Keys.A)
        Dim mnItemsPrint As New MenuItem("Bỏ chọn (Ctrl+U)", AddressOf V_UnSelected, Keys.Control + Keys.U)

        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow, nCount As Integer
        nCount = Dv_Master1.Table.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            Dv_Master1.Item(iRow).Item("TAG") = 1
        Next
        Dv_Master1.Table.AcceptChanges()
    End Sub
    Private Sub V_UnSelected(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow, nCount As Integer
        nCount = Dv_Master1.Table.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            Dv_Master1.Item(iRow).Item("TAG") = 0
        Next
        Dv_Master1.Table.AcceptChanges()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
    End Sub
    Private Sub V_LoadDatatabse(ByVal _Status As String)
        '
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HR_TinhPHEP", _Status.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim & "#" & TxtMa_Bp.Text.Trim & "#" & CBBMa_Dvcs.SelectedValue.ToString.Trim & "#" & M_User_Name)
        If _Status = "0" Then
            Dt_Head1 = _DsTmp.Tables(0).Copy
            Dt_Master1 = _DsTmp.Tables(1).Copy
            '--
            Dv_Head1 = New DataView(Dt_Head1)
            Dv_Master1 = New DataView(Dt_Master1)
            '------------------------------------------>>>>>>>>>>>>>>>>>>>>>>>>>>
            Detail1.DataSource = Dv_Master1
            Me.DetailGRV1.GridControl = Me.Detail1
            '------------------------------------------>>>>>>>>>>>>>>>>>>>>>>>>>>
            CyberFill.V_FillReports(DetailGRV1, Me.Lan, Dv_Head1, Dv_Master1)
        Else
            Dim nCount As Integer = _DsTmp.Tables.Count
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(nCount - 1))
            '1
            Dt_Master1.Clear()
            For i = 0 To _DsTmp.Tables(1).Rows.Count - 1
                Dt_Master1.ImportRow(_DsTmp.Tables(1).Rows(i))
            Next
            Dt_Master1.AcceptChanges()
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        'Me.Close()
    End Sub
#Region "AddHandler"
    Private Sub AddHander()
        AddHandler CmdTinhPhep.Click, AddressOf V_TinhPhep
        AddHandler CmdChuyenPhep.Click, AddressOf V_ChuyenPhep
        AddHandler CmdExport.Click, AddressOf V_XuatExcel
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_BP
    End Sub
    'Private Sub v_ma_dvcs(sender As Object, e As EventArgs)
    '    V_LoadDatatabse("1")
    'End Sub
#End Region
#Region "Vali --- Master"
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_BP")
            TxtTen_Bp.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_TinhPhep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HR_TinhPHEP_Calcu", CbbM_Nam.SelectedValue.ToString.Trim & "#" & CBBMa_Dvcs.SelectedValue.ToString.Trim & "#" & M_User_Name)
        CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar, M_LAN)
        V_LoadDatatabse("1")
    End Sub
    Private Sub V_ChuyenPhep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HR_TinhPHEP_Chuyen", CbbM_Nam.SelectedValue.ToString.Trim & "#" & CBBMa_Dvcs.SelectedValue.ToString.Trim & "#" & M_User_Name)
        CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar, M_LAN)
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatatabse("1")
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = ""
        _Title = _Title.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, "")
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.DetailGRV1, _Dv_Title, Dv_Head1, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
#End Region
End Class
