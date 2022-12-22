Imports System.Windows.Forms

Public Class ROXPTView
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
    Public Property Dt_Master() As DataTable
        Get
            Return M_Dt_Master
        End Get
        Set(ByVal value As DataTable)
            M_Dt_Master = value
        End Set
    End Property
    Public Property Dt_Detail() As DataTable
        Get
            Return M_Dt_Detail
        End Get
        Set(ByVal value As DataTable)
            M_Dt_Detail = value
        End Set
    End Property
    Public Property Dt_MasterH() As DataTable
        Get
            Return M_Dt_MasterH
        End Get
        Set(ByVal value As DataTable)
            M_Dt_MasterH = value
        End Set
    End Property
    Public Property Dt_DetailH() As DataTable
        Get
            Return M_Dt_DetailH
        End Get
        Set(ByVal value As DataTable)
            M_Dt_DetailH = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return M_Title
        End Get
        Set(ByVal value As String)
            M_Title = value
        End Set
    End Property
    Public Property Stt_Rec() As String
        Get
            Return M_Stt_Rec
        End Get
        Set(ByVal value As String)
            M_Stt_Rec = value
        End Set
    End Property
    Public Property Dr_View_Return() As DataRowView
        Get
            Return M_Dr_View_Return
        End Get
        Set(ByVal value As DataRowView)
            M_Dr_View_Return = value
        End Set
    End Property
    Dim M_Dr_View_Return As DataRowView
    Dim M_Title As String = ""
    Dim M_strLoc As String = ""
    Dim M_strFilter As String = ""
    Dim M_Cp_Loc As String = ""
    Dim M_Stt_Rec As String = ""

    Dim M_Dt_Master As DataTable
    Dim M_Dt_Detail As DataTable
    Dim M_Dt_MasterH As DataTable
    Dim M_Dt_DetailH As DataTable

    Dim M_Dv_Master As DataView
    Dim M_Dv_Detail As DataView
    Dim M_Dv_MasterH As DataView
    Dim M_Dv_DetailH As DataView

    Dim Dt_DetailTmp As DataTable
    Dim Dv_DetailTmp As DataView

    Dim _Filter As String = "1=1"

    Private Sub ROXPTViewr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Dv_Master = New DataView(M_Dt_Master)
        M_Dv_Detail = New DataView(M_Dt_Detail)
        M_Dv_MasterH = New DataView(M_Dt_MasterH)
        M_Dv_DetailH = New DataView(M_Dt_DetailH)
        V_Load(sender, e)
        Me.Save_OK = True
        'AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing

        CyberSupport.Translaste(Me, M_LAN, True)
        If M_Title.Trim = "" Then Me.Text = "Xem chứng từ chưa xuất".ToUpper.Trim Else Me.Text = M_Title.ToUpper.Trim
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub Frmvoucher_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim _With As Decimal = Me.Width - 30
        'Dim _With As Decimal = Me.Width - 30
        Dim _With1 As Decimal = 0
        'Dim _With2 As Decimal = 0
        If _With > 10 Then
            _With1 = _With / 2
            '   _With2 = _With / 2
            StatusFooter1.Width = _With1
            StatusFooter2.Width = _With1
        End If
        StatusFooter2.Visible = True
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        '  Dim rowHandle As Integer = e.HitInfo.RowHandle
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuMasterGrid.ItemLinks.Clear()

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "làm tươi dữ liệu", "Reresh"), AddressOf V_ReFresh, Shortcut.CtrlF5, My.Resources.refresh2_16x16, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, My.Resources.cancel_16x16, True, True)).BeginGroup = True
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub

    Private Sub V_ReFresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        Dim _Stt_Rec As String = ""
        If iRow >= 0 Then _Stt_Rec = M_Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim CyberLoading As New Cyber.Loading.Loading
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_lan)

        Dim DsRefresh As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_Loc, M_strLoc)
        For i As Integer = 0 To DsRefresh.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsRefresh.Tables(i))
        Next

        Dt_Master.Clear()
        For i As Integer = 0 To DsRefresh.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(DsRefresh.Tables(0).Rows(i))
        Next
        '------------------------------
        Dt_DetailTmp.Clear()
        For i As Integer = 0 To DsRefresh.Tables(1).Rows.Count - 1
            Dt_DetailTmp.ImportRow(DsRefresh.Tables(1).Rows(i))
        Next

        DsRefresh.Dispose()

        Dim _RowIndex As Integer = SearchCureenCell(_Stt_Rec)
        If _RowIndex > 0 Then MasterGRV.FocusedRowHandle = _RowIndex
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

        FillDetailGRV(sender, e)
        CyberSmlib.FlushMemory()
    End Sub
    Private Sub V_Load(ByVal sender As Object, ByVal e As EventArgs)

        Dt_DetailTmp = M_Dv_Detail.Table.Copy
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_DetailTmp.RowFilter = _Filter

        Master.DataSource = M_Dv_Master
        Me.MasterGRV.GridControl = Me.Master

        CyberFill.V_FillVoucherView(MasterGRV, M_LAN, M_Dv_MasterH, M_Dv_Master)

        Dim _RowIndex As Integer = SearchCureenCell(M_Stt_Rec)
        If _RowIndex > 0 Then MasterGRV.FocusedRowHandle = _RowIndex
        '--------------End Set Row Curren
        FillDetailGRV(sender, e)

    End Sub
    Private Sub FillDetailGRV(ByVal sender As Object, ByVal e As EventArgs)
        Binding_PositionChanged(sender, e)
        Dim currency As CurrencyManager
        currency = Me.BindingContext(Me.MasterGRV.DataSource)
        AddHandler currency.PositionChanged, AddressOf Binding_PositionChanged
        '---------------------------
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucherView(DetailGRV, M_LAN, M_Dv_DetailH, Dv_DetailTmp)
    End Sub
    Private Sub Binding_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim filter As String = Nothing
        Dim selectedRow As DataRowView = Nothing

        Try
            If (M_Dv_Master.Table.Rows.Count() <> Nothing And M_Dv_Master.Table.Columns.Count > 0) Then
                selectedRow = CType(Me.BindingContext(MasterGRV.DataSource).Current, DataRowView)
            End If
            If (Not String.IsNullOrEmpty(selectedRow("stt_rec").ToString)) Then

                filter = "stt_rec='" + selectedRow("stt_rec").ToString() + "'"
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try

    End Sub
    Private Function SearchCureenCell(ByVal _Stt_Rec As String) As Integer
        Dim _Retunr As Integer = -1

        For iRow As Integer = 0 To MasterGRV.RowCount - 1
            If M_Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_Rec.Trim.ToUpper Then
                _Retunr = iRow
                Exit For
            End If
        Next
        SearchCureenCell = _Retunr
    End Function
    Private Sub V_close()
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then
            Me.M_Dr_View_Return = Nothing
        Else
            Me.M_Dr_View_Return = M_Dv_Master.Item(iRow)
        End If
    End Sub

    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CyberSmlib.FlushMemorySave()
        V_close()
        Me.Save_OK = True
        Me.Close()
    End Sub
    Private Sub ROXPTView_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        V_close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_close()
        Me.Save_OK = True
        '-----------------------------------------------------------------------------
        'Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
