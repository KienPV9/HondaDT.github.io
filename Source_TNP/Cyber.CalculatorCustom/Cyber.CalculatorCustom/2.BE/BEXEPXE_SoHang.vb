Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Public Class BEXEPXE_SoHang
#Region "AddProperty"
    Public Property strLoc() As String
        Get
            strLoc = M_strLoc
        End Get
        Set(ByVal Value As String)
            M_strLoc = Value
        End Set
    End Property
    Public Property Cp_Loc() As String
        Get
            Cp_Loc = M_Cp_Loc
        End Get
        Set(ByVal Value As String)
            M_Cp_Loc = Value
        End Set
    End Property
    Public Property Cp_Update() As String
        Get
            Cp_Update = M_Cp_Update
        End Get
        Set(ByVal Value As String)
            M_Cp_Update = Value
        End Set
    End Property
    Public Property DsDataLoc() As DataSet
        Get
            DsDataLoc = M_DsDataLoc
        End Get
        Set(ByVal Value As DataSet)
            M_DsDataLoc = Value
        End Set
    End Property
    Public Property Ma_Kx() As String
        Get
            Ma_Kx = M_MA_KX
        End Get
        Set(ByVal Value As String)
            M_MA_KX = Value
        End Set
    End Property
    Public Property Ma_Mau() As String
        Get
            Ma_Mau = M_MA_Mau
        End Get
        Set(ByVal Value As String)
            M_MA_Mau = Value
        End Set
    End Property
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Public Property Stt_Rec0() As String
        Get
            Stt_Rec0 = M_Stt_Rec0
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec0 = Value
        End Set
    End Property
    Public Property DmKx() As DataTable
        Get
            DmKx = M_DmKx
        End Get
        Set(ByVal Value As DataTable)
            M_DmKx = Value
        End Set
    End Property
    Public Property DmMau() As DataTable
        Get
            DmMau = M_DmMau
        End Get
        Set(ByVal Value As DataTable)
            M_DmMau = Value
        End Set
    End Property
    Public Property Ma_Kx_ND() As String
        Get
            Ma_Kx_ND = M_MA_KX_ND
        End Get
        Set(ByVal Value As String)
            M_MA_KX_ND = Value
        End Set
    End Property
    Public Property Ma_Mau_ND() As String
        Get
            Ma_Mau_ND = M_MA_Mau_ND
        End Get
        Set(ByVal Value As String)
            M_MA_Mau_ND = Value
        End Set
    End Property
#End Region
#Region "Declare "
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_DmKx As DataTable
    Dim M_DmMau As DataTable

    Dim M_Stt_Rec As String = ""
    Dim M_Stt_Rec0 As String = ""
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_MA_KX As String = ""
    Dim M_MA_Mau As String = ""

    Dim M_MA_KX_ND As String = ""
    Dim M_MA_Mau_ND As String = ""

    Dim M_DsDataLoc As DataSet

    Dim Dt_head, Dt_Master, Dt_Dmct As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct As DataView

    Dim Dt_head_1, Dt_Master_1, Dt_Dmct_1 As DataTable
    Dim Dv_head_1, Dv_Master_1, Dv_Dmct_1 As DataView

    Dim DrDmct As DataRow
    Dim DrDmct_1 As DataRow
    Dim _Tab_Boolean As Boolean = False
    Dim _Tab_Boolean_1 As Boolean = False

    Dim _Bold As Boolean = False
    Dim _BackColor As Boolean = False
    Dim _BackColor2 As Boolean = False
    Dim _Forecolor As Boolean = False
    Dim _FieldBold As String = ""
    Dim _FieldBackColor As String = ""
    Dim _FieldBackColor2 As String = ""
    Dim _FieldForecolor As String = ""

#End Region
    Private Sub BEXEPXE_SoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()

        V_GetColorBold()

        V_AddHander()
        V_DragDropGridview()
        Me.Text = "XẾP SỐ HÃNG CHO CÁC HỢP ĐỒNG  - KÉO DI CHUỘT TỪ DỮ LIỆU SỐ KHUNG VÀO SỐ BẢNG DỮ LIỆU HỢP ĐỒNG"
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load and Fill"
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_FilldatatoGridview()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Dim FixCol As Integer = -1
        Try
            FixCol = Dt_Dmct.Rows(0).Item("ColFrozen_Master")
        Catch ex As Exception
        End Try

        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        '-----------------------------------------------------------------
    End Sub
    Private Sub V_FilldatatoGridview_1()
        CyberFill.V_FillReports(MasterGRV_1, Me.Lan, Dv_head_1, Dv_Master_1)
        Master_1.DataSource = Dv_Master_1
        Me.MasterGRV_1.GridControl = Me.Master_1
        MasterGRV_1.OptionsView.ShowViewCaption = False
        MasterGRV_1.OptionsSelection.MultiSelect = False
        Me.MasterGRV_1.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Dim FixCol_1 As Integer = -1
        Try
            FixCol_1 = Dt_Dmct_1.Rows(0).Item("ColFrozen_Master")
        Catch ex As Exception
        End Try

        If FixCol_1 < MasterGRV_1.Columns.Count And FixCol_1 > 0 Then
            For iCol = 0 To FixCol_1
                MasterGRV_1.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
    End Sub
    Private Sub V_Load()
        If M_MA_KX_ND.ToString.Trim = "" And DmKx.Rows.Count > 0 Then M_MA_KX_ND = DmKx.Rows(0).Item("ma_KX").ToString.Trim
        If M_MA_Mau_ND.ToString.Trim = "" And DmMau.Rows.Count > 0 Then M_MA_Mau_ND = DmMau.Rows(0).Item("Ma_Mau").ToString.Trim
        If DmKx.Select("Ma_Kx = '" + M_MA_KX_ND.Trim + "'").Length = 0 And DmKx.Rows.Count > 0 Then M_MA_KX_ND = DmKx.Rows(0).Item("ma_KX").ToString.Trim
        CyberFill.V_FillComBoxValue(CmbbMa_Kx, DmKx, "Ma_Kx", "Ten_Kx", M_MA_KX_ND)
        CyberFill.V_FillComBoxValue(CmbbMa_Mau, DmMau, "Ma_Mau", "Ten_Mau", M_MA_Mau_ND)
        If Not M_MA_KX.Trim = "" Then CmbbMa_Kx.Enabled = False
        If Not M_MA_Mau.Trim = "" Then CmbbMa_Mau.Enabled = False
        V_Loaddatabases("1")
    End Sub
    Private Sub V_Loaddatabases(ByVal status)
        Dim _Ma_KX As String = CmbbMa_Kx.SelectedValue.ToString.Trim
        Dim _Ma_Mau As String = CmbbMa_Mau.SelectedValue.ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe", status.ToString + "#0#2#" + Me.Thang1.ToString + "#" + Me.Nam1.ToString.Trim + "#" + Me.Thang2.ToString + "#" + Me.Nam2.ToString + "#" + Me.Stt_Rec + "#" + Me.Stt_Rec0 + "#" + _Ma_KX + "#" + _Ma_Mau + "#" + _
                                                         "" + "#" + "" + "#" + "" + "#" + "" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If status = "1" Then
            Dt_Master = DsTmp.Tables(0).Copy
            Dt_Dmct = DsTmp.Tables(1).Copy
            Dt_head = DsTmp.Tables(2).Copy
            Dv_Master = New DataView(Dt_Master)
            Dv_Dmct = New DataView(Dt_Dmct)
            Dv_head = New DataView(Dt_head)
            DrDmct = Dt_Dmct.Rows(0)
            If Dv_Master.Table.Columns.Contains("Tag") Then _Tab_Boolean = True
            V_FilldatatoGridview()
            DsTmp.Dispose()

            V_Loaddatabases_SK(status)
            Exit Sub
        End If
        Dt_Master.Clear()
        For i = 0 To DsTmp.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(DsTmp.Tables(0).Rows(i))
        Next
        Dt_Master.AcceptChanges()
        DsTmp.Dispose()

        '---------------------------------------------------------------------------------------------------
        V_Loaddatabases_SK(status)
    End Sub
    Private Sub V_GetColorBold()
        If Dt_Master.Columns.Contains("Backcolor") Then
            _BackColor = True
            _FieldBackColor = Dt_Master.Columns("Backcolor").ColumnName
        End If
        If Dt_Master.Columns.Contains("Backcolor2") Then
            _BackColor2 = True
            _FieldBackColor2 = Dt_Master.Columns("Backcolor2").ColumnName
        End If
        If Dt_Master.Columns.Contains("Forecolor") Then
            _Forecolor = True
            _FieldForecolor = Dt_Master.Columns("Forecolor").ColumnName
        End If

        If Dt_Master.Columns.Contains("Bold") Then
            _Bold = True
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
        End If
    End Sub
    Private Sub V_Loaddatabases_SK(ByVal status As String)
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then
            Dim _Drv As DataRowView = Dv_Master.Item(iRow)
            _Stt_Rec = _Drv.Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = _Drv.Item("Stt_Rec0").ToString.Trim
        End If

        Dim DsTmp_1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_SoHang", status.ToString + "#" + _Stt_Rec + "#" + _Stt_Rec0 + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If status = "1" Then

            Dt_Master_1 = DsTmp_1.Tables(0).Copy
            Dt_Dmct_1 = DsTmp_1.Tables(1).Copy
            Dt_head_1 = DsTmp_1.Tables(2).Copy
            Dv_Master_1 = New DataView(Dt_Master_1)
            Dv_Dmct_1 = New DataView(Dt_Dmct_1)
            Dv_head_1 = New DataView(Dt_head_1)
            DrDmct_1 = Dt_Dmct_1.Rows(0)
            If Dv_Master_1.Table.Columns.Contains("Tag") Then _Tab_Boolean_1 = True
            DsTmp_1.Dispose()
            V_FilldatatoGridview_1()
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        Dt_Master_1.Clear()
        For i = 0 To DsTmp_1.Tables(0).Rows.Count - 1
            Dt_Master_1.ImportRow(DsTmp_1.Tables(0).Rows(i))
        Next
        Dt_Master_1.AcceptChanges()
        DsTmp_1.Dispose()
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_AddHander()
        '--------------------------
        AddHandler MasterGRV.RowCellClick, AddressOf V_MasterGRV_RowCellClick
        AddHandler MasterGRV_1.RowCellClick, AddressOf V_MasterGRV_RowCellClick
        '--------------------------

        '--------------------------
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        '--------------------------
        AddHandler MasterGRV_1.RowCellStyle, AddressOf MasterGRV_1_RowCellStyle
        AddHandler MasterGRV_1.PopupMenuShowing, AddressOf MasterGRV_1_PopupMenuShowing
        '--------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler cmdRefresh.Click, AddressOf V_Refresh
        AddHandler cmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler cmdUnSelectAll.Click, AddressOf V_RemoveAll
        AddHandler CmdAuto.Click, AddressOf V_Auto
        '--------------------------
        AddHandler CmbbMa_Kx.SelectedIndexChanged, AddressOf V_Ma_Kx_SelectedIndexChanged
        AddHandler CmbbMa_Mau.SelectedIndexChanged, AddressOf V_Ma_Mau_SelectedIndexChanged

    End Sub
    Private Sub V_DragDropGridview()
        _keothatrongGrid = New ObjectDragDrop(Master, Nothing)
        _keotha2Grid = New ObjectDragDrop(Master_1, Master)
        AddHandler Master.DragDrop, AddressOf Master_DragDrop

    End Sub
#End Region
#Region "Event DragDrop"
    Dim _keothatrongGrid As New ObjectDragDrop
    Dim _keotha2Grid As New ObjectDragDrop
    Dim ABC As Integer = 0
    Private Sub Master_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim IRow_Master As Integer = -1
        Dim grid As GridControl = TryCast(sender, GridControl)
        Dim gridview As GridView = TryCast(grid.MainView, GridView)
        Dim _Dr_Master_1 As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        If _Dr_Master_1 Is Nothing Then Exit Sub
        Dim hitInfo As GridHitInfo = gridview.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
        IRow_Master = hitInfo.RowHandle
        If IRow_Master < 0 Then Exit Sub
        Dim _Ma_HD As String = Dv_Master.Item(IRow_Master).Item("Ma_HD").ToString.Trim
        Dim _Stt_Rec As String = Dv_Master.Item(IRow_Master).Item("Stt_Rec").ToString.Trim
        Dim _Stt_Rec0 As String = Dv_Master.Item(IRow_Master).Item("Stt_Rec0").ToString.Trim
        Dim _So_Hang As String = _Dr_Master_1.Item("So_Hang").ToString.Trim

        If Not V_Xep_Xe(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_Hang, IRow_Master, "0") Then
            _keothatrongGrid._ActiDraDrop = False
            _keotha2Grid._ActiDraDrop = False
            Exit Sub
        End If

        '---------END UPDATE-----------------------------------------------------
        _keothatrongGrid._ActiDraDrop = False
        _keotha2Grid._ActiDraDrop = False
        CyberSmlib.FlushMemorySave()

    End Sub
#End Region
#Region " Combobox SelectedIndexChanged  Event "
    Private Sub V_Ma_Kx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases("0")
    End Sub
    Private Sub V_Ma_Mau_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases("0")
    End Sub
#End Region
#Region "Event - Nut Lenh"
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases("0")
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function V_Xep_Xe(ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, ByVal _So_Hang As String, ByVal IRow_Master As Integer, ByVal _All As String) As Boolean
        If _Ma_HD.Trim = "" Or _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Or _So_Hang.Trim = "" Then Return False

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEXEPXESH_SAVE_SoHang", _Ma_HD & "#" & _Stt_Rec & "#" & _Stt_Rec0 & "#" & _So_Hang & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, Me.Lan) Then
            Dstmp.Dispose()
            If _All = "0" Then CyberSmlib.FlushMemorySave()
            Return False
        End If
        If Dstmp.Tables(1).Rows.Count <= 0 Then
            Dstmp.Dispose()
            If _All = "0" Then CyberSmlib.FlushMemorySave()
            Return False
        End If
        '---------BG UPDATE-----------------------------------------------------
        Dim _Drv As DataRowView
        _Drv = New DataView(Dstmp.Tables(1).Copy).Item(0)
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv_Master, IRow_Master, _Drv)
        MasterGRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(MasterGRV, rowView)
        MasterGRV.FocusedRowHandle = iCol
        MasterGRV.ClearSelection()
        MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        Dstmp.Dispose()
        If _All = "0" Then V_Refresh_Master_1(New System.Object, New System.EventArgs)
        If _All = "0" Then CyberSmlib.FlushMemorySave()
        Me.Save_OK = True
        Return True
    End Function
    Private Sub V_Auto(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dv_Master_1.Count <= 0 Then Exit Sub
        If Dv_Master.Count <= 0 Then Exit Sub
        If MsgBox("Bạn thực hiện gán dữ liệu tự đồng số hãng không?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Exit Sub
        Dim iRow_1 As Integer = 0
        For iRow As Integer = 0 To Dv_Master.Count - 1
            Dim _Ma_HD As String = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            Dim _Stt_Rec0 As String = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            Dim _So_hang As String = Dv_Master.Item(iRow).Item("So_hang").ToString.Trim
            If Not _So_hang.Trim = "" Then Continue For
            iRow_1 = iRow_1 + 1
            If iRow_1 >= Dv_Master_1.Count Then Exit For
            Dim _So_Hang_Save As String = Dv_Master_1.Item(iRow_1).Item("So_hang").ToString.Trim
            V_Xep_Xe(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_Hang_Save, iRow, "1")
        Next
        V_Refresh_Master_1(sender, e)
        CyberSmlib.FlushMemorySave()
        Me.Save_OK = True
    End Sub
    Private Sub V_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If MsgBox("Bạn thực hiện giải phóng xếp số hãng cho hợp đồng này không? ", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.No Then Exit Sub
        Dim _Ma_HD As String = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
        Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim _Stt_Rec0 As String = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
        Dim _So_Hang As String = Dv_Master.Item(iRow).Item("So_Hang").ToString.Trim
        V_F8(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_Hang, iRow, "0")
        V_Refresh_Master_1(sender, e)
    End Sub
    Private Sub V_F8ALL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Bạn thực hiện giải phóng toàn bộ xếp số hãng không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.No Then Exit Sub
        For iRow As Integer = 0 To Dv_Master.Count - 1
            Dim _Ma_HD As String = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            Dim _Stt_Rec0 As String = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            Dim _So_Hang As String = Dv_Master.Item(iRow).Item("So_Hang").ToString.Trim
            V_F8(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_Hang, iRow, "1")
        Next
        V_Refresh_Master_1(sender, e)
    End Sub
    Private Function V_F8(ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, ByVal _So_Hang As String, ByVal IRow_Master As Integer, ByVal _all As String) As Boolean
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_DELETE_SoHang", _Ma_HD & "#" & _Stt_Rec & "#" & _Stt_Rec0 & "#" & _So_Hang & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If _all = "0" Then
            If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, Me.Lan) Then Return False
        Else
            If Dstmp.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then Return False
        End If
        If Dstmp.Tables(1).Rows.Count <= 0 Then Return False
        '---------BG UPDATE-----------------------------------------------------
        Dim _Drv As DataRowView
        _Drv = New DataView(Dstmp.Tables(1).Copy).Item(0)
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv_Master, IRow_Master, _Drv)
        MasterGRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(MasterGRV, rowView)
        MasterGRV.FocusedRowHandle = iCol
        MasterGRV.ClearSelection()
        MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        Dstmp.Dispose()
        Me.Save_OK = True
        Return True
    End Function
    Private Sub V_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Ma_CT As String = _Drv.Item("Ma_CT")
        Dim _Dien_Thoai As String = _Drv.Item("Dien_Thoai")
        If _Stt_Rec.Trim <> "" Then CyberSupport.V_Sms(AppConn, Me.Para, Me.Sysvar, M_LAN, _Stt_Rec, _Ma_CT, M_Ma_Dvcs, M_User_Name, _Dien_Thoai, "", CyberSmlib, CyberSmodb)
    End Sub
    Private Sub V_Refresh_Master_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases_SK("0")
    End Sub
#End Region
#Region "Event Master"
    Private Sub V_MasterGRV_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
        If e.Column.ColumnEdit Is Nothing Then Exit Sub
        If e.Column.ReadOnly = True Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        If e.Column.ColumnEdit.GetType.Name.Trim.ToUpper = "RepositoryItemCheckEdit".Trim.ToUpper Then
            If _Tab_Boolean Then
                Grid.SetRowCellValue(e.RowHandle, e.Column, IIf(e.CellValue = True, False, True))
            Else
                Grid.SetRowCellValue(e.RowHandle, e.Column, IIf(e.CellValue = "1", "0", "1"))
            End If
        End If
    End Sub
    Private Sub V_MasterGRV_1RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
        If e.Column.ColumnEdit Is Nothing Then Exit Sub
        If e.Column.ReadOnly = True Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        If e.Column.ColumnEdit.GetType.Name.Trim.ToUpper = "RepositoryItemCheckEdit".Trim.ToUpper Then
            If _Tab_Boolean_1 Then
                Grid.SetRowCellValue(e.RowHandle, e.Column, IIf(e.CellValue = True, False, True))
            Else
                Grid.SetRowCellValue(e.RowHandle, e.Column, IIf(e.CellValue = "1", "0", "1"))
            End If
        End If
    End Sub
    Private Function FindRowHandleByRowObject(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Object) As Integer
        Dim I As Integer
        If Not row Is Nothing Then
            For I = 0 To view.DataRowCount - 1
                If row.Equals(view.GetRow(I)) Then
                    Return I
                End If
            Next
        End If
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
    End Function
    Private Function V_UpdateItem(ByVal Dv As DataView, ByVal iRow As Decimal, ByVal DrvUp As DataRowView) As DataRowView
        If iRow < 0 Then Return Nothing
        Dim iCol As Integer
        Dim _Fieldname As String
        Dim Drv As DataRowView
        Drv = Dv.Item(iRow)
        Drv.BeginEdit()
        For iCol = 0 To Dv.Table.Columns.Count - 1
            _Fieldname = Dv.Table.Columns(iCol).ColumnName
            If DrvUp.DataView.Table.Columns.Contains(_Fieldname) Then
                Drv.Item(_Fieldname) = DrvUp.Item(_Fieldname)
            End If
        Next
        Drv.EndEdit()
        Dv.Table.AcceptChanges()
        Return Drv
    End Function
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
                e.Appearance.ForeColor = CyberColor.GetForeColorDefault(_categoryForeColor)
            End If

        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If

        'If Dt_Master.Columns.Contains("Bold") Then
        '    Dim _FieldBold As String = ""
        '    _FieldBold = Dt_Master.Columns("Bold").ColumnName
        '    Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
        '    If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        'End If
        'If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
        '    If Dt_Master.Columns.Contains("BackColor") Then
        '        Dim _FieldBackColor As String = ""
        '        _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
        '        Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
        '        e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
        '    End If
        '    If Dt_Master.Columns.Contains("BackColor2") Then
        '        Dim _FieldBackColor2 As String = ""
        '        _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
        '        Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
        '        e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
        '    End If
        'Else
        '    e.Appearance.BackColor = System.Drawing.Color.Silver
        'End If

    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gửi tin nhắn", "SMS"), AddressOf V_SMS, Nothing, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Giải phóng xếp cho 1 hợp đồng", "Delete"), AddressOf V_F8, Shortcut.F8, My.Resources.cancel_16x16, True, True)).BeginGroup = False

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Giải phóng xếp toàn bộ hợp đồng", "Delete All"), AddressOf V_F8ALL, Shortcut.CtrlF8, My.Resources.cancel_16x16, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gán tự động toàn bộ các hợp đồng", "Approval Auto"), AddressOf V_Auto, Shortcut.CtrlF4, My.Resources.apply_16x16, True, True)).BeginGroup = True
        '--- End Tuy chọn
        'If _Tab_Boolean_1 Then
        '    PopupMenuMasterGrid_1.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn chứng từ", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        '    PopupMenuMasterGrid_1.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        'End If
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
    Private Sub MasterGRV_1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master_1.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master_1.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV_1.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master_1.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master_1.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV_1.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master_1.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master_1.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV_1.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub MasterGRV_1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid_1.ItemLinks.Clear()
        PopupMenuMasterGrid_1.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Master_1, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid_1.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid_1.ShowPopup(Control.MousePosition)

        'End If
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        Me.Close()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
End Class
'Public Class ObjectDragDrop
'    Dim downHitInfo As GridHitInfo = Nothing
'    Dim _GridDrag As New DevExpress.XtraGrid.GridControl
'    Dim _GridDrop As New DevExpress.XtraGrid.GridControl
'    Dim _GrvDrag As New GridView
'    Dim _GrvDrop As New GridView
'    Public _ActiDraDrop As Boolean = False
'    Public Sub New()
'    End Sub
'    Public Sub New(ByVal Grid_keo As DevExpress.XtraGrid.GridControl, ByVal Grid_Tha As DevExpress.XtraGrid.GridControl)
'        _GridDrag = Grid_keo
'        _GridDrop = IIf(Grid_Tha Is Nothing, Grid_keo, Grid_Tha)
'        _GridDrop.AllowDrop = True
'        _GridDrag.AllowDrop = True
'        _GrvDrag = TryCast(_GridDrag.MainView, GridView)
'        _GrvDrop = TryCast(_GridDrop.MainView, GridView)
'        V_Addhandler()
'    End Sub
'    Private Sub V_Addhandler()
'        AddHandler _GrvDrag.MouseMove, AddressOf view_MouseMove
'        AddHandler _GrvDrag.MouseDown, AddressOf view_MouseDown
'        AddHandler _GridDrop.DragOver, AddressOf grid_DragOver
'    End Sub
'    Private Sub view_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
'        _ActiDraDrop = False
'        Dim view As GridView = TryCast(sender, GridView)
'        downHitInfo = Nothing
'        Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
'        If Control.ModifierKeys <> Keys.None Then
'            Return
'        End If
'        If e.Button = MouseButtons.Left AndAlso hitInfo.RowHandle >= 0 Then
'            downHitInfo = hitInfo
'            _ActiDraDrop = True
'        End If
'    End Sub
'    Private Sub view_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
'        Dim view As GridView = TryCast(sender, GridView)
'        If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
'            Dim dragSize As Size = SystemInformation.DragSize
'            Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize)
'            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
'                Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
'                view.GridControl.DoDragDrop(row, DragDropEffects.Move)
'                downHitInfo = Nothing
'                DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
'            End If
'        End If
'    End Sub
'    Private Sub grid_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
'        If e.Data.GetDataPresent(GetType(DataRow)) Then
'            e.Effect = DragDropEffects.Move
'        Else
'            e.Effect = DragDropEffects.None
'        End If
'    End Sub
'End Class
