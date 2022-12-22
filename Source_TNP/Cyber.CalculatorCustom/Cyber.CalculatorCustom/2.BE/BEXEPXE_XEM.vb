Imports System.Drawing
Imports System.Windows.Forms

Public Class BEXEPXE_XEM
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
    Dim ProccessList As New Collection
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_MA_KX As String = ""
    Dim M_MA_Mau As String = ""
   

    Dim M_DsDataLoc As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_head, Dt_Master, Dt_Dmct, Dt_Filter1, Dt_Filter0, Dt_Color As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct, DV_Filter1, DV_Filter0, Dv_Color As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys

    Dim EditSo_Hang As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Khung As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KH As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_KH As New Cyber.Fill.CyberColumnGridView
    Dim EditOng_Ba As New Cyber.Fill.CyberColumnGridView

    Dim EditTen_KX As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KX As New Cyber.Fill.CyberColumnGridView

    Dim M_Bar As String
    Dim M_Bar2 As String
    Dim _Tab_Boolean As Boolean = False
    Dim Dt_DmKx As DataTable
    Dim Dt_DmMau As DataTable

    Dim _Bold As Boolean = False
    Dim _BackColor As Boolean = False
    Dim _BackColor2 As Boolean = False
    Dim _Forecolor As Boolean = False
    Dim _FieldBold As String = ""
    Dim _FieldBackColor As String = ""
    Dim _FieldBackColor2 As String = ""
    Dim _FieldForecolor As String = ""
    Private Sub BEXEPXE_XEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim
        Me.Save_OK = False
        Me.Tag = ""
        '-----------------------------------------------------------------
        V_Load()
        '-----------------------------------------------------------------
        V_SetColor()
        '-----------------------------------------------------------------
        V_GetColorBold()
        V_FilldatatoGridview()
        V_GetColumn()
        V_AddHandler_Master()
        V_AddHandler_Detail()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        Dt_DmKx = CyberSmodb.OpenTable(AppConn, Nothing, "DmKx", "1", CyberSmlib)
        Dt_DmMau = CyberSmodb.OpenTable(AppConn, Nothing, "DmMauxe", "1", CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)

        V_Tinh_Toan_Tong()
    End Sub
#Region "Load data"
    Private Sub V_Load()
        Dt_Master = DsDataLoc.Tables(0).Copy
        Dt_Dmct = DsDataLoc.Tables(1).Copy
        Dt_head = DsDataLoc.Tables(2).Copy
        If DsDataLoc.Tables.Count >= 4 Then Dt_Color = DsDataLoc.Tables(3).Copy
        Dv_Master = New DataView(Dt_Master)
        Dv_Dmct = New DataView(Dt_Dmct)
        Dv_head = New DataView(Dt_head)
        DrDmct = Dt_Dmct.Rows(0)
        If Dv_Master.Table.Columns.Contains("Tag") Then _Tab_Boolean = True


        Dt_Filter0 = New DataTable
        Dt_Filter1 = New DataTable

        Dt_Filter1.Columns.Add("Field_Name")
        Dt_Filter1.Columns.Add("Field_Type")

        Dt_Filter0.Columns.Add("Ma")
        Dt_Filter0.Columns.Add("Ten")
        Dt_Filter0.Columns.Add("Default")


        Dim _Field_Name As String = ""
        Dim _Field_Head As String = ""
        Dim _Field_Type As String = ""
        Dt_Filter0.Rows.Add("", "Tất cả", "0")

        For i As Integer = 1 To Dt_head.Rows.Count - 1
            _Field_Name = Dt_head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        DV_Filter0 = New DataView(Dt_Filter0)
        DV_Filter1 = New DataView(Dt_Filter1)
    End Sub
    Private Sub V_SetColor()

        If Dt_Color Is Nothing Then Return
        If Not Dt_Color.Columns.Contains("Ma_Color") Or Not Dt_Color.Columns.Contains("Ten_Color") Or Not Dt_Color.Columns.Contains("BackColor") Or Not Dt_Color.Columns.Contains("ForeColor") Then Return
        If Dt_Color.Rows.Count = 0 Then Return

        Dim _Ma_Color As String = ""
        Dim _Ten_Color As String = ""
        Dim _BackColor As String = ""
        Dim _BackColor2 As String = ""
        Dim _ForeColor As String = ""
        For i As Integer = 0 To Dt_Color.Rows.Count - 1
            _BackColor2 = ""
            _Ma_Color = Dt_Color.Rows(i).Item("Ma_Color").ToString.Trim.ToUpper
            _Ten_Color = Dt_Color.Rows(i).Item("Ten_Color").ToString.Trim


            _BackColor = Dt_Color.Rows(i).Item("BackColor").ToString.Trim.ToUpper
            If Dt_Color.Columns.Contains("BackColor2") Then _BackColor2 = Dt_Color.Rows(i).Item("BackColor2").ToString.Trim
            _ForeColor = Dt_Color.Rows(i).Item("ForeColor").ToString.Trim.ToUpper

            Select Case _Ma_Color
                Case "01".ToUpper
                    Lb01.Visible = True
                    Lab01.Visible = True
                    If _Ten_Color <> "" Then Lab01.Text = _Ten_Color
                    If _BackColor <> "" Then Lb01.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb01.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb01.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "02".ToUpper
                    Lb02.Visible = True
                    Lab02.Visible = True
                    If _Ten_Color <> "" Then Lab02.Text = _Ten_Color
                    If _BackColor <> "" Then Lb02.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb02.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb02.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "03".ToUpper
                    Lb03.Visible = True
                    Lab03.Visible = True
                    If _Ten_Color <> "" Then Lab03.Text = _Ten_Color
                    If _BackColor <> "" Then Lb03.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb03.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb03.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "04".ToUpper
                    Lb04.Visible = True
                    Lab04.Visible = True
                    If _Ten_Color <> "" Then Lab04.Text = _Ten_Color
                    If _BackColor <> "" Then Lb04.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb04.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb04.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "05".ToUpper
                    Lb05.Visible = True
                    Lab05.Visible = True
                    If _Ten_Color <> "" Then Lab05.Text = _Ten_Color
                    If _BackColor <> "" Then Lb05.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb05.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb05.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "06".ToUpper
                    Lb06.Visible = True
                    Lab06.Visible = True
                    If _Ten_Color <> "" Then Lab06.Text = _Ten_Color
                    If _BackColor <> "" Then Lb06.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb06.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb06.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "07".ToUpper
                    Lb07.Visible = True
                    Lab07.Visible = True
                    If _Ten_Color <> "" Then Lab07.Text = _Ten_Color
                    If _BackColor <> "" Then Lb07.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb07.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb07.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "08".ToUpper
                    Lb08.Visible = True
                    Lab08.Visible = True
                    If _Ten_Color <> "" Then Lab08.Text = _Ten_Color
                    If _BackColor <> "" Then Lb08.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb08.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb08.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "09".ToUpper
                    Lb09.Visible = True
                    Lab09.Visible = True
                    If _Ten_Color <> "" Then Lab09.Text = _Ten_Color
                    If _BackColor <> "" Then Lb09.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb09.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb09.ForeColor = CyberColor.GetForeColor(_ForeColor)
                Case "10".ToUpper
                    Lb10.Visible = True
                    Lab10.Visible = True
                    If _Ten_Color <> "" Then Lab10.Text = _Ten_Color
                    If _BackColor <> "" Then Lb10.Appearance.BackColor = CyberColor.GetBackColor(_BackColor)
                    If _BackColor2 <> "" Then Lb10.Appearance.BackColor2 = CyberColor.GetBackColor(_BackColor2)
                    If _ForeColor <> "" Then Lb10.ForeColor = CyberColor.GetForeColor(_ForeColor)
            End Select
        Next
    End Sub
    Private Sub V_Tinh_Toan_Tong()
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim n3 As Integer = 0
        Dim n4 As Integer = 0
        Dim n5 As Integer = 0
        Dim n6 As Integer = 0
        Dim n7 As Integer = 0
        Dim n8 As Integer = 0
        Dim n9 As Integer = 0
        Dim n10 As Integer = 0

        For i As Integer = 0 To Dv_Master.Count - 1
            If Not Dt_Master.Columns.Contains("Ma_Color") Then Continue For
            Select Case Dv_Master.Item(i).Item("Ma_Color").ToString.Trim
                Case "01"
                    n1 = n1 + 1
                Case "02"
                    n2 = n2 + 1
                Case "03"
                    n3 = n3 + 1
                Case "04"
                    n4 = n4 + 1
                Case "05"
                    n5 = n5 + 1
                Case "06"
                    n6 = n6 + 1
                Case "07"
                    n7 = n7 + 1
                Case "08"
                    n8 = n8 + 1
                Case "09"
                    n9 = n9 + 1
                Case "10"
                    n10 = n10 + 1
            End Select
        Next


        If n1 <> 0 Then Lb01.Text = n1 Else Lb01.Text = ""
        If n2 <> 0 Then Lb02.Text = n2 Else Lb02.Text = ""
        If n3 <> 0 Then Lb03.Text = n3 Else Lb03.Text = ""
        If n4 <> 0 Then Lb04.Text = n4 Else Lb04.Text = ""
        If n5 <> 0 Then Lb05.Text = n5 Else Lb05.Text = ""
        If n6 <> 0 Then Lb06.Text = n6 Else Lb06.Text = ""
        If n7 <> 0 Then Lb07.Text = n7 Else Lb07.Text = ""
        If n8 <> 0 Then Lb08.Text = n8 Else Lb08.Text = ""
        If n9 <> 0 Then Lb09.Text = n9 Else Lb09.Text = ""
        If n10 <> 0 Then Lb10.Text = n10 Else Lb10.Text = ""
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
    Private Sub V_GetColumn()

        EditMa_KH.GetColumn(MasterGRV, "MA_KH")
        EditTen_KH.GetColumn(MasterGRV, "TEN_KH")
        EditOng_Ba.GetColumn(MasterGRV, "Ong_Ba")

        EditMa_KX.GetColumn(MasterGRV, "MA_KX")
        EditTen_KX.GetColumn(MasterGRV, "TEN_KX")
        EditSo_Khung.GetColumn(MasterGRV, "So_Khung")
        EditSo_Hang.GetColumn(MasterGRV, "So_Hang")
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

    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_Loc, strLoc)
        CyberSmodb.SetNotNullTable(Dstmp.Tables(0))
        Dim nCount As Integer = Dt_Master.Rows.Count - 1
        For i = nCount To 0 Step -1
            Dt_Master.Rows(i).Delete()
        Next
        Dt_Master.AcceptChanges()
        For i = 0 To Dstmp.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(Dstmp.Tables(0).Rows(i))
        Next
        Dt_Master.AcceptChanges()
        V_Tinh_Toan_Tong()
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler_Master()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle

        RemoveHandler ButtExit.Click, AddressOf V_Exit
        RemoveHandler CmbbRefresh.Click, AddressOf V_Refresh
        RemoveHandler CmbbXepXe.Click, AddressOf V_XepXeCMD
        RemoveHandler CmbbPrint.Click, AddressOf V_Print
        RemoveHandler CmbbInBien_Ban.Click, AddressOf V_PrintHDX
        RemoveHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        RemoveHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        RemoveHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll
        RemoveHandler CmbbSms.Click, AddressOf V_SMS
        RemoveHandler TxtSearch.TextChanged, AddressOf V_Search

        '--------------------------------------------------------------------------
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '--------------------------------------------------------------------------
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CmbbRefresh.Click, AddressOf V_Refresh
        AddHandler CmbbXepXe.Click, AddressOf V_XepXeCMD
        AddHandler CmbbPrint.Click, AddressOf V_Print
        AddHandler CmbbInBien_Ban.Click, AddressOf V_PrintHDX
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll
        AddHandler CmbbSms.Click, AddressOf V_SMS
        AddHandler TxtSearch.TextChanged, AddressOf V_Search
    End Sub
    Private Sub V_AddHandler_Detail()


        RemoveHandler EditMa_KH.EditColumn.Click, AddressOf V_F3_KH
        RemoveHandler EditTen_KH.EditColumn.Click, AddressOf V_F3_KH
        RemoveHandler EditOng_Ba.EditColumn.Click, AddressOf V_F3_KH
        RemoveHandler EditMa_KX.EditColumn.Click, AddressOf V_F3_KX
        RemoveHandler EditTen_KX.EditColumn.Click, AddressOf V_F3_KX
        RemoveHandler EditSo_Khung.EditColumn.Click, AddressOf V_XepXe
        RemoveHandler EditSo_Hang.EditColumn.Click, AddressOf V_XepXe_So_Hang

        AddHandler EditMa_KH.EditColumn.Click, AddressOf V_F3_KH
        AddHandler EditTen_KH.EditColumn.Click, AddressOf V_F3_KH
        AddHandler EditOng_Ba.EditColumn.Click, AddressOf V_F3_KH
        AddHandler EditMa_KX.EditColumn.Click, AddressOf V_F3_KX
        AddHandler EditTen_KX.EditColumn.Click, AddressOf V_F3_KX
        AddHandler EditSo_Khung.EditColumn.Click, AddressOf V_XepXe
        AddHandler EditSo_Hang.EditColumn.Click, AddressOf V_XepXe_So_Hang
    End Sub
    Private Sub V_PDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        If _Stt_Rec.Trim = "" Then Return
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return


        Dim FrmF3 As New BEXEPXE_PDS
        FrmF3.Drv = _Drv
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_F3_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex


        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        If _Stt_Rec.Trim = "" Then Return
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_PHHDX", _Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(0).Rows.Count <= 0 Then
            CyberSupport.V_MsgChk("N", "Y", "Dữ liệu đã bị xóa, bạn xem lại dữ liệu", Me.Sysvar, Me.M_LAN)
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        Dim _Dr As DataRow = DsTmp.Tables(0).Copy.Rows(0)
        Dim FrmF3 As New BEXEPXE_KHF3
        FrmF3.Dr = _Dr
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        'FrmF3.Drv = _Drv
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub
        _Drv = FrmF3.Drv
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv_Master, iRow, _Drv)
        MasterGRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(MasterGRV, rowView)
        MasterGRV.FocusedRowHandle = iCol
        MasterGRV.ClearSelection()
        MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Sub V_F3_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_CTHDX", _Stt_Rec & "#" & _Stt_Rec0 & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(0).Rows.Count <= 0 Then
            CyberSupport.V_MsgChk("N", "Y", "Dữ liệu đã bị xóa, bạn xem lại dữ liệu", Me.Sysvar, Me.M_LAN)
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()

        Dim _Dr As DataRow = DsTmp.Tables(0).Copy.Rows(0)
        Dim FrmF3 As New BEXEPXE_KXF3

        FrmF3.Dr = _Dr
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        'FrmF3.Drv = _Drv
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub
        _Drv = FrmF3.Drv
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv_Master, iRow, _Drv)
        MasterGRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(MasterGRV, rowView)
        MasterGRV.FocusedRowHandle = iCol
        MasterGRV.ClearSelection()
        MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_F3_DKHD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        If _Stt_Rec.Trim = "" Then Return
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct")
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
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
    Private Sub V_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)

        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")
        If _Stt_Rec.Trim = "" Then Return
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

        Dim _So_Khung As String = _Drv.Item("So_Khung")
        Dim _Ma_HD As String = _Drv.Item("Ma_HD")
        If _So_Khung.ToString.Trim = "" Then Exit Sub

        If MsgBox("Bạn có chắc muốn giải phóng xe này không ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Exit Sub
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_SKF8", _Ma_HD & "#" & _Stt_Rec & "#" & _Stt_Rec0 & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        If DsTmp.Tables(1).Rows.Count = 0 Then Exit Sub
        _Drv = New DataView(DsTmp.Tables(1).Copy).Item(0)
        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv_Master, iRow, _Drv)
        MasterGRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(MasterGRV, rowView)
        MasterGRV.FocusedRowHandle = iCol
        MasterGRV.ClearSelection()
        MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        CyberSmlib.FlushMemorySave()
    End Sub
#End Region
#Region "Event - Nut Lenh"
    Private Sub V_XepXe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If V_XepXe(iRow) Then V_Refresh(sender, e)
    End Sub
    Private Sub V_XepXeCMD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dv_Master.Count <= 0 Then Exit Sub
        If V_XepXe(-1) Then V_Refresh(sender, e)
    End Sub
    Private Function V_XepXE(ByVal iRow As Integer) As Boolean


        'Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        'Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        'If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return False


        Dim frm1 As BEXEPXE
        frm1 = New BEXEPXE
        frm1.Lan = M_LAN
        frm1.Para = Me.Para
        frm1.Sysvar = Me.Sysvar
        frm1.AppConn = AppConn
        frm1.CyberSmlib = CyberSmlib
        frm1.CyberSupport = CyberSupport
        frm1.CyberFill = CyberFill
        frm1.CyberSmlistSys = CyberSmlistSys
        frm1.CyberSmodb = CyberSmodb
        'frm1.CyberExport = Me.CyberEport
        frm1.CyberVoucher = CyberVoucher
        frm1.CyberLoading = CyberLoading
        'frm1.DsDataLoc = DsCalculator
        ' frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        frm1.Key_Sub1 = Me.Key_Sub1.ToString.Trim
        frm1.Key_Sub2 = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Kx = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Mau = Me.Key_Sub1.ToString.Trim

        frm1.Ma_Kx_ND = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Mau_ND = Me.Key_Sub1.ToString.Trim

        frm1.Thang1 = Me.Thang1.ToUpper.Trim
        frm1.Thang2 = Me.Thang2.ToUpper.Trim
        frm1.Nam = Me.Nam.ToUpper.Trim

        frm1.Nam1 = Me.Nam1.ToUpper.Trim
        frm1.Nam2 = Me.Nam2.ToUpper.Trim

        frm1.DmKx = Dt_DmKx
        frm1.DmMau = Dt_DmMau
        frm1.Stt_Rec = ""
        frm1.Stt_Rec0 = ""
        If iRow >= 0 Then
            Dim _Drv As DataRowView = Dv_Master.Item(iRow)
            frm1.Ma_Kx = _Drv.Item("Ma_KX").ToString.Trim
            frm1.Ma_Mau = _Drv.Item("Ma_Mau").ToString.Trim
            frm1.Stt_Rec = _Drv.Item("Stt_Rec").ToString.Trim
            frm1.Stt_Rec0 = _Drv.Item("Stt_Rec0").ToString.Trim
        End If
        Dim iRow_ND As Integer = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow_ND >= 0 Then
            Dim _Drv As DataRowView = Dv_Master.Item(iRow_ND)
            frm1.Ma_Kx_ND = _Drv.Item("Ma_KX").ToString.Trim
            frm1.Ma_Mau_ND = _Drv.Item("Ma_Mau").ToString.Trim
        End If
        frm1.ShowInTaskbar = False
        frm1.ShowDialog()
        Return frm1.Save_OK
    End Function
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = True Else Dv_Master.Item(i).Item("Tag") = "1"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
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
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0

        _Filter = ""
        _FieldName = ComFilter.SelectedValue.ToString.Trim
        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        If _Value <> "" Then _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, DV_Filter1, _FieldName, _Value, "%")
        _Filter1 = "1=1"
        'If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        ''MasterGRV.ActiveFilterString = _Filter
        ''MasterGRV.FocusedRowHandle = 0
        Try
            Dv_Master.RowFilter = _Filter
        Catch ex As Exception

        End Try

        V_Tinh_Toan_Tong()

    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "Event - Xếp xe số hãng"
    Private Sub V_XepXe_So_Hang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex

        If iRow < 0 Then Exit Sub
        If V_XepXe_So_Hang(iRow) Then V_Refresh(sender, e)
    End Sub
    Private Sub V_XepXe_So_HangCMD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dv_Master.Count <= 0 Then Exit Sub
        If V_XepXe_So_Hang(-1) Then V_Refresh(sender, e)
    End Sub
    Private Function V_XepXE_So_Hang(ByVal iRow As Integer) As Boolean

        'Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        'Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")

        'If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return False

        Dim frm1 As BEXEPXE_SoHang
        frm1 = New BEXEPXE_SoHang
        frm1.Lan = M_LAN
        frm1.Para = Me.Para
        frm1.Sysvar = Me.Sysvar
        frm1.AppConn = AppConn
        frm1.CyberSmlib = CyberSmlib
        frm1.CyberSupport = CyberSupport
        frm1.CyberFill = CyberFill
        frm1.CyberSmlistSys = CyberSmlistSys
        frm1.CyberSmodb = CyberSmodb
        'frm1.CyberExport = Me.CyberEport
        frm1.CyberVoucher = CyberVoucher
        frm1.CyberLoading = CyberLoading
        'frm1.DsDataLoc = DsCalculator
        ' frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        frm1.Key_Sub1 = Me.Key_Sub1.ToString.Trim
        frm1.Key_Sub2 = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Kx = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Mau = Me.Key_Sub1.ToString.Trim

        frm1.Ma_Kx_ND = Me.Key_Sub1.ToString.Trim
        frm1.Ma_Mau_ND = Me.Key_Sub1.ToString.Trim

        frm1.Thang1 = Me.Thang1.ToUpper.Trim
        frm1.Thang2 = Me.Thang2.ToUpper.Trim
        frm1.Nam = Me.Nam.ToUpper.Trim

        frm1.Nam1 = Me.Nam1.ToUpper.Trim
        frm1.Nam2 = Me.Nam2.ToUpper.Trim

        frm1.DmKx = Dt_DmKx
        frm1.DmMau = Dt_DmMau
        frm1.Stt_Rec = ""
        frm1.Stt_Rec0 = ""
        If iRow >= 0 Then
            Dim _Drv As DataRowView = Dv_Master.Item(iRow)
            frm1.Ma_Kx = _Drv.Item("Ma_KX").ToString.Trim
            frm1.Ma_Mau = _Drv.Item("Ma_Mau").ToString.Trim
            frm1.Stt_Rec = _Drv.Item("Stt_Rec").ToString.Trim
            frm1.Stt_Rec0 = _Drv.Item("Stt_Rec0").ToString.Trim
        End If
        Dim iRow_ND As Integer = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow_ND >= 0 Then
            Dim _Drv As DataRowView = Dv_Master.Item(iRow_ND)
            frm1.Ma_Kx_ND = _Drv.Item("Ma_KX").ToString.Trim
            frm1.Ma_Mau_ND = _Drv.Item("Ma_Mau").ToString.Trim
        End If
        frm1.ShowInTaskbar = False
        frm1.ShowDialog()
        Return frm1.Save_OK
    End Function
#End Region
#Region "Print "
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")
        Dim _Ma_CT As String = _Drv.Item("Ma_CT")
        Dim _Ma_Post As String = _Drv.Item("Ma_Post")
        If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

        Dim _Ngay_CT As String = _Drv.Item("Ngay_CT")
        If _Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("P", _Ngay_CT, _Ma_Post, _Stt_Rec, _Ma_CT) Then Exit Sub
        CyberVoucher.V_PrintVocuher(AppConn, Me.Sysvar, Nothing, _Stt_Rec, _Ngay_CT, _Ma_Post, M_LAN, Me.Para, DrDmct, _Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_PrintHDX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        If Not Dt_Master.Columns.Contains("Ma_CT") Then Return
        If Not Dt_Master.Columns.Contains("Stt_Rec") Then Return
        If Not Dt_Master.Columns.Contains("Stt_Rec0") Then Return

        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct")
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Stt_Rec0 As String = _Drv.Item("Stt_Rec0")
        If _Ma_Ct.Trim = "" Then Return
        If _Stt_Rec.Trim = "" Then Return

        CyberVoucher.V_PrintVoucherAll(AppConn, Sysvar, _Ma_Ct, _Stt_Rec, _Stt_Rec0, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_IN_Bien_Ban(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_In As String = ""
        Dim _Loai_in As String = ""
        Dim _Ma_HD As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        Dim _So_khung As String = ""
        Dim _Ma_KX As String = ""
        Dim _Ma_Mau As String = ""

        ' GetMa_IN_InFor(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau)
        Lua_Chon_IN(_Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau)
        If _Ma_In.Trim = "" Or _Loai_in = "" Then Exit Sub
        '--- Get WaterMark
        Dim DrMaterMark As DataRow = CyberVoucher.GetWaterMark(AppConn, _Stt_Rec, "00", "HDX", M_Ma_Dvcs, M_User_Name, CyberSmlib)
        Dim _IsWaterMark As Boolean = False
        Dim _WaterMark As String = ""
        If Not DrMaterMark Is Nothing Then
            If DrMaterMark.Table.Columns.Contains("IsWaterMark") Then If DrMaterMark.Item("IsWaterMark").ToString.Trim = "1" Then _IsWaterMark = True Else _IsWaterMark = False
            If DrMaterMark.Table.Columns.Contains("WaterMark") Then _WaterMark = DrMaterMark.Item("WaterMark").ToString
        End If
        V_PRIN_Bien_Ban(_Ma_In, _Loai_in, _IsWaterMark, _WaterMark)
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_PRIN_Bien_Ban(ByVal _Ma_In As String, ByVal _Loai_in As String, ByVal _IsWaterMark As Boolean, ByVal _WaterMark As String)

        Dim _Ma_HD As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        Dim _So_khung As String = ""
        Dim _Ma_KX As String = ""
        Dim _Ma_Mau As String = ""
        If Not _Tab_Boolean Then
            Dim iRow As Integer = -1
            iRow = MasterGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            _Ma_HD = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            _So_khung = Dv_Master.Item(iRow).Item("So_khung").ToString.Trim
            _Ma_KX = Dv_Master.Item(iRow).Item("Ma_Kx").ToString.Trim
            _Ma_Mau = Dv_Master.Item(iRow).Item("ma_Mau").ToString.Trim
            If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return

            V_PRIN_Bien_Ban("1", _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------------------------
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        Dim nCountTag As Integer = 0
        For i = 0 To Dv_Master.Count - 1
            If _Type Then
                If Dv_Master.Item(i).Item("Tag") = True Then
                    nCountTag = nCountTag + 1
                End If
            Else
                If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Then
                    nCountTag = nCountTag + 1
                End If
            End If
        Next
        If nCountTag = 0 Then
            Dim iRow As Integer = -1
            iRow = MasterGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            _Ma_HD = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            _So_khung = Dv_Master.Item(iRow).Item("So_khung").ToString.Trim
            _Ma_KX = Dv_Master.Item(iRow).Item("Ma_Kx").ToString.Trim
            _Ma_Mau = Dv_Master.Item(iRow).Item("ma_Mau").ToString.Trim
            If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Return
            V_PRIN_Bien_Ban("1", _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------------------------
        Dim _Lan As Integer = 0
        For i = 0 To Dv_Master.Count - 1
            If _Type Then
                If Dv_Master.Item(i).Item("Tag") = True Then
                    _Ma_HD = Dv_Master.Item(i).Item("Ma_HD").ToString.Trim
                    _Stt_Rec = Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim
                    _Stt_Rec0 = Dv_Master.Item(i).Item("Stt_Rec0").ToString.Trim
                    _So_khung = Dv_Master.Item(i).Item("So_khung").ToString.Trim
                    _Ma_KX = Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim
                    _Ma_Mau = Dv_Master.Item(i).Item("ma_Mau").ToString.Trim
                    _Lan = _Lan + 1
                    If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Continue For
                    V_PRIN_Bien_Ban(_Lan, _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
                    If _Loai_in = "3" Then Exit Sub
                End If
            Else
                If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Then
                    _Ma_HD = Dv_Master.Item(i).Item("Ma_HD").ToString.Trim
                    _Stt_Rec = Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim
                    _Stt_Rec0 = Dv_Master.Item(i).Item("Stt_Rec0").ToString.Trim
                    _So_khung = Dv_Master.Item(i).Item("So_khung").ToString.Trim
                    _Ma_KX = Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim
                    _Ma_Mau = Dv_Master.Item(i).Item("ma_Mau").ToString.Trim
                    _Lan = _Lan + 1
                    If _Stt_Rec.Trim = "" Or _Stt_Rec0.Trim = "" Then Continue For
                    V_PRIN_Bien_Ban(_Lan, _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
                    If _Loai_in = "3" Then Exit Sub
                End If
            End If
        Next

    End Sub
    Private Sub V_PRIN_Bien_Ban(ByVal _Lan_In As Integer, ByVal _Ma_In As String, ByVal _Loai_in As String, ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, _
                                ByVal _So_khung As String, ByVal _ma_Kx As String, ByVal _ma_Mau As String, ByVal _IsWaterMark As Boolean, ByVal _WaterMark As String)
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_PRINT", _Ma_In & "#" & _Ma_HD & "#" & _Stt_Rec & "#" & _Stt_Rec0 & "#" & _ma_Kx & "#" & _ma_Mau & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Report_Name As String = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        Dim _Title As String = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        Dim CyberPrint As New Cyber.Print.Sys
        CyberPrint.CyberPrintReport(AppConn, _Loai_in, _Report_Name, DsPrint, _Title, _Title, Me.Sysvar, Me.Para, M_Ma_Dvcs, _IsWaterMark, _WaterMark, Me.Lan, True, True)
        DsPrint.Dispose()
    End Sub
    Private Sub Lua_Chon_IN(ByRef _Ma_In As String, ByRef _Loai_In As String, ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, ByVal _So_khung As String, ByVal _ma_Kx As String, ByVal _ma_Mau As String)
        If Dv_Master.Count <= 0 Then
            _Ma_In = ""
            _Loai_In = ""

            Exit Sub
        End If
        Dim frm1 As BEXEPXE_IN_BB
        frm1 = New BEXEPXE_IN_BB

        frm1.Lan = M_LAN
        frm1.Para = Me.Para
        frm1.Sysvar = Me.Sysvar
        frm1.AppConn = AppConn
        frm1.CyberSmlib = CyberSmlib
        frm1.CyberSupport = CyberSupport
        frm1.CyberFill = CyberFill
        frm1.CyberSmlistSys = CyberSmlistSys
        frm1.CyberSmodb = CyberSmodb
        'frm1.CyberExport = Me.CyberEport
        frm1.CyberVoucher = CyberVoucher
        frm1.CyberLoading = CyberLoading
        'frm1.DsDataLoc = DsCalculator
        ' frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        frm1.Key_Sub1 = Me.Key_Sub1.ToString.Trim
        frm1.Key_Sub2 = Me.Key_Sub1.ToString.Trim
        frm1.Thang1 = Me.Thang1.ToUpper.Trim
        frm1.Thang2 = Me.Thang2.ToUpper.Trim
        frm1.Nam = Me.Nam.ToUpper.Trim
        frm1.ShowInTaskbar = False
        '-----------------------------------------------------------------------------------
        frm1.Ma_HD = _Ma_HD
        frm1.Stt_Rec = _Stt_Rec
        frm1.Stt_Rec0 = _Stt_Rec0
        frm1.So_Khung = _So_khung
        frm1.Ma_Kx = _ma_Kx
        frm1.Ma_Mau = _ma_Mau
        '-----------------------------------------------------------------------------------
        frm1.ShowDialog()
        If Not frm1.Save_OK Then
            _Ma_In = ""
            _Loai_In = ""
            Exit Sub
        End If
        _Ma_In = frm1.Key_Sub1.ToString.Trim
        _Loai_In = frm1.Key_Sub2.ToString.Trim
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String, ByVal _Ngay_CT As Date, ByVal _Ma_Post As String, ByVal _Stt_Rec As String, ByVal _Ma_CT As String) As Boolean
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Ngay_CT, _Mode, _Ma_Post, _Stt_Rec, _Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, Me.Sysvar, CyberSmlib)
    End Function
#End Region
#Region "Event"
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
    Dim icong As Integer = 1
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)

        Dim i As Integer = e.RowHandle

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

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gửi tin nhắn", "SMS"), AddressOf V_SMS, Nothing, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xếp xe", "Refresh"), AddressOf V_XepXeCMD, Shortcut.F4, My.Resources.apply_16x16, True, True)).BeginGroup = False
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Yêu cầu làm PDS", "Refresh"), AddressOf V_PDS, Nothing, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Giải phóng xếp xe", "Refresh"), AddressOf V_F8, Shortcut.F8, My.Resources.cancel_16x16, True, True)).BeginGroup = True
        '-----------------------
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Sửa thông tin khách hàng", "Edit"), AddressOf V_F3_KH, Shortcut.CtrlF3, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Sửa thông tin xe", "Edit"), AddressOf V_F3_KX, Shortcut.CtrlF4, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem điều kiện HĐ", "Edit"), AddressOf V_F3_DKHD, Shortcut.F3, Nothing, True, True)).BeginGroup = False


        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In ĐKHĐ", "Refresh"), AddressOf V_Print, Shortcut.F7, My.Resources.Preview_16_IN, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In các biên bản", "Prints"), AddressOf V_PrintHDX, Shortcut.F10, My.Resources.apply_16x16, True, True)).BeginGroup = False

        '--- End Tuy chọn
        If _Tab_Boolean Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn chứng từ", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        End If
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
#End Region
End Class
