Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class KhoXeTong
    Dim M_Cp_Name As String
    Dim DtThang, DtNam As DataTable
    Dim Dt_Master1, Dt_Head1 As DataTable
    Dim DtDvcs, DtTTCP As DataTable
    Dim Dv_Master1, Dv_Head1 As DataView
    Dim DrReturn, DrReturn02 As DataRow
    Dim vTbTTCP As DataView
    Dim DsLookup, DsLookup02 As DataSet
    Dim M_Http_Api As String
    Dim _Bold As Boolean = False
    Dim _BackColor As Boolean = False
    Dim _BackColor2 As Boolean = False
    Dim _Forecolor As Boolean = False
    Dim _FieldBold As String = ""
    Dim _FieldBackColor As String = ""
    Dim _FieldBackColor2 As String = ""
    Dim _FieldForecolor As String = ""
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub ApiSAPNS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Cp_Name = "CP_BE_KHO_XE_LOAD"
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
        '-----------------------------------------------------------------
        V_GetColorBold()
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
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If _Bold Then
                Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
                If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
            End If
            If _BackColor Then
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If _BackColor2 Then
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                If Not _categoryBackColor2.Trim = "" Then e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If

            If _Forecolor Then
                Dim _categoryForeColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldForecolor).ToString.Trim
                e.Appearance.ForeColor = CyberColor.GetForeColor(_categoryForeColor)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If

    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()

        '-----------------------
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Cập nhật Hồ sơ", "Refresh"), AddressOf V_NhapHoSo, Nothing, Nothing, True, True)).BeginGroup = False

        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub V_NhapHoSo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master1.Item(iRow)
        Dim _TT_HoSo As String = _Drv.Item("TT_HoSo")

        Dim _So_Khung As String = _Drv.Item("So_Khung")

        If _So_Khung.Trim = "" Then Return

        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, Me.Para, Sysvar, AppConn, "DMTTHS", "So_Khung='" & _So_Khung & "'" _
                                                     , "SO_KHUNG#TT_HOSO#ACTI", _So_Khung.Trim + "#" + _TT_HoSo.Trim + "#1", True)
        If Dr Is Nothing Then Exit Sub

        Dv_Master1.Item(iRow).Item("TT_HoSo") = Dr.Item("TT_HoSo").ToString.Trim

        MasterGRV.UpdateCurrentRow()
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_GetColorBold()
        If Dt_Master1.Columns.Contains("Backcolor") Then
            _BackColor = True
            _FieldBackColor = Dt_Master1.Columns("Backcolor").ColumnName
        End If
        If Dt_Master1.Columns.Contains("Backcolor2") Then
            _BackColor2 = True
            _FieldBackColor2 = Dt_Master1.Columns("Backcolor2").ColumnName
        End If
        If Dt_Master1.Columns.Contains("Forecolor") Then
            _Forecolor = True
            _FieldForecolor = Dt_Master1.Columns("Forecolor").ColumnName
        End If

        If Dt_Master1.Columns.Contains("Bold") Then
            _Bold = True
            _FieldBold = Dt_Master1.Columns("Bold").ColumnName
        End If
    End Sub
    Private Sub V_Load()
    End Sub
    Private Sub V_LoadDatatabse(ByVal _Status As String)
        '
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BE_KHO_XE_LOAD", _Status.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim & "#" & TxtMa_Hs.Text.Trim & "#" & CBBMa_Dvcs.SelectedValue.ToString.Trim & "#" & M_User_Name)
        If _Status = "0" Then
            Dt_Head1 = _DsTmp.Tables(0).Copy
            Dt_Master1 = _DsTmp.Tables(1).Copy
            '--
            Dv_Head1 = New DataView(Dt_Head1)
            Dv_Master1 = New DataView(Dt_Master1)
            '------------------------------------------>>>>>>>>>>>>>>>>>>>>>>>>>>
            Master.DataSource = Dv_Master1
            Me.MasterGRV.GridControl = Me.Master
            '------------------------------------------>>>>>>>>>>>>>>>>>>>>>>>>>>
            CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_Head1, Dv_Master1)
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
        AddHandler CmdExport.Click, AddressOf V_XuatExcel
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_BP
        '
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing

    End Sub
    'Private Sub v_ma_dvcs(sender As Object, e As EventArgs)
    '    V_LoadDatatabse("1")
    'End Sub
#End Region
#Region "Vali --- Master"
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_BP")
            TxtTen_Hs.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
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
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterGRV, _Dv_Title, Dv_Head1, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
#End Region
End Class
