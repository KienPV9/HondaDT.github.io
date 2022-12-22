Imports System.Data.SqlClient
Imports Cyber.InputGL.Sys
Public Class PNK_Loc
    Dim CyberInput As New Cyber.Input.Sys
    Dim strFilter As String
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim EditM_Tag, EditD_Tag As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Public Property ma_Ct() As String
        Get
            ma_Ct = M_ma_Ct
        End Get
        Set(ByVal Value As String)
            M_ma_Ct = Value
        End Set
    End Property
    Public Property Return_Tb1() As DataTable
        Get
            Return_Tb1 = M_Return_Tb1
        End Get
        Set(ByVal Value As DataTable)
            M_Return_Tb1 = Value
        End Set
    End Property
    Public Property Return_Tb2() As DataTable
        Get
            Return_Tb2 = M_Return_Tb2
        End Get
        Set(ByVal Value As DataTable)
            M_Return_Tb2 = Value
        End Set
    End Property
    Dim M_Return_Tb1, M_Return_Tb2 As DataTable
    Dim M_Stt_rec, M_ma_Ct As String
    Dim DtTable1, DtTable2, DtHTable1, DtHTable2 As DataTable
    Dim DvTable1, DvTable2, DvHTable1, DvHTable2 As DataView
    Private Sub PNK_Loc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = "Loc phieu nhap kho theo don hang"
        V_Load()
        V_GetColumn()
        TxtMa_Kh.Focus()
        '------------------------------------------------------------------------------------

        RemoveHandler MasterGRV.FocusedRowChanged, AddressOf V_MasterGRV_Change
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        RemoveHandler CmdLoc_POD.Click, AddressOf V_Loc

        AddHandler MasterGRV.FocusedRowChanged, AddressOf V_MasterGRV_Change
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CmdLoc_POD.Click, AddressOf V_Loc
        '------------------------------------------------------------------------------------

        'Detail
        If Not EditM_Tag Is Nothing Then AddHandler EditM_Tag.EditColumn.EditValueChanged, AddressOf V_Master_Tag
        If Not EditD_Tag Is Nothing Then AddHandler EditD_Tag.EditColumn.EditValueChanged, AddressOf V_Detail_Tag
    End Sub
    Private Sub V_Load()
        TxtNgay_CT1.Value = Now.Date
        TxtNgay_CT2.Value = Now.Date
        V_Loaddatatabase("0")
        V_FillDataToGridview(MasterGRV, M_LAN, DvHTable1, DvTable1)
        V_FillDataToGridview(DetailGRV, M_LAN, DvHTable2, DvTable2)
        V_Tinh_Tong()
    End Sub
    Sub V_Loaddatatabase(ByVal _Type As String)
        Dim _Dt1 As Date = TxtNgay_CT1.Value
        Dim _Dt2 As Date = TxtNgay_CT2.Value
        Dim _DsTmp As DataSet = CyberInput.V_GetPNKFromPOD(AppConn, CyberSmlib, _Type, _Dt1.ToString("yyyyMMdd"), _Dt2.ToString("yyyyMMdd"), TxtLenh_PO.Text, TxtMa_Kh.Text, M_Stt_rec, M_ma_Ct, M_Ma_Dvcs, M_User_Name)

        If _Type.Trim = "0" Then
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(0))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(1))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(2))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(3))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(4))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(5))
            '------------------------------------------------------------------
            Return_Tb1 = _DsTmp.Tables(0).Copy
            '------------------------------------------------------------------
            DtTable1 = _DsTmp.Tables(1).Copy
            DtTable2 = _DsTmp.Tables(2).Copy

            DtHTable1 = _DsTmp.Tables(3).Copy
            DtHTable2 = _DsTmp.Tables(4).Copy

            DvTable1 = New DataView(DtTable1)
            DvTable2 = New DataView(DtTable2)

            DvHTable1 = New DataView(DtHTable1)
            DvHTable2 = New DataView(DtHTable2)

        Else
            Dim nCount As Integer = _DsTmp.Tables.Count
            If Not CyberSupport.V_MsgChk(_DsTmp.Tables(nCount - 1), Me.Sysvar) Then Exit Sub

            CyberSmodb.SetNotNullTable(_DsTmp.Tables(0))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(1))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(2))
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(3))
            '------------------------------------------------------------------
            Return_Tb1 = _DsTmp.Tables(0).Copy
            '------------------------------------------------------------------
            nCount = DtTable1.Rows.Count - 1
            For i As Integer = nCount To 0 Step -1
                DtTable1.Rows(i).Delete()
            Next
            DtTable1.AcceptChanges()
            '----------------------
            For i = 0 To _DsTmp.Tables(1).Rows.Count - 1
                DtTable1.ImportRow(_DsTmp.Tables(1).Rows(i))
            Next
            DtTable1.AcceptChanges()
            '------------------------------------------------------------------
            nCount = DtTable2.Rows.Count - 1
            For i As Integer = nCount To 0 Step -1
                DtTable2.Rows(i).Delete()
            Next
            DtTable2.AcceptChanges()
            '----------------------
            For i = 0 To _DsTmp.Tables(2).Rows.Count - 1
                DtTable2.ImportRow(_DsTmp.Tables(2).Rows(i))
            Next
            DtTable2.AcceptChanges()
        End If
    End Sub
#Region "Grid..."
    Private Sub V_GetColumn()
        EditM_Tag.GetColumn(MasterGRV, "TAG")
        EditD_Tag.GetColumn(DetailGRV, "TAG")
    End Sub
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        GRV.GridControl.DataSource = Nothing
        'GRV.OptionsBehavior.Editable = False
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub

    Private Sub V_MasterGRV_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_BilldtingRo(MasterGRV, DvTable1, DvTable2)
    End Sub
    Private Sub V_BilldtingRo(ByVal MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        If MasterGRV.GetFocusedRow Is Nothing Then Exit Sub
        If Not Dv_DetailTmp.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not Dv_Master.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Dv_Master.Table.Rows.Count < 1 Then Exit Sub
        If Dv_Master.Table.Columns.Count < 1 Then Exit Sub
        Dim filter As String = "1=1"
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = MasterGRV.GetFocusedRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                filter = "Stt_Rec='" + selectedRow("Stt_Rec").ToString() + "'"
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try
    End Sub
    Private Sub V_Master_Tag(ByVal sender As Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        Dim iRow As Integer = 0
        Dim _Stt_Rec As String
        Dim _Status As Boolean
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        _Status = DvTable1.Item(iRow).Item("Tag")
        _Stt_Rec = DvTable1.Item(iRow).Item("Stt_Rec")
        V_Detail(_Status, _Stt_Rec)
        V_Tinh_Tong()
    End Sub
    Private Sub V_Detail_Tag(ByVal sender As Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        DetailGRV.PostEditor()
        V_Tinh_Tong()
    End Sub
    Private Sub V_Detail(ByVal status As Boolean, ByVal SttRec As String)
        Dim i As Integer
        For i = 0 To DtTable2.Rows.Count - 1
            If DtTable2.Rows(i).Item("Stt_Rec").ToString.Trim = SttRec.Trim Then
                DtTable2.Rows(i).BeginEdit()
                DtTable2.Rows(i).Item("Tag") = status
                DtTable2.Rows(i).EndEdit()
                DtTable2.AcceptChanges()
            End If
        Next
    End Sub
    Private Sub V_Tinh_Tong()
        MasterGRV.PostEditor()
        DetailGRV.PostEditor()
        Dim nT_Tien0, nT_Thue_Nt, nT_TT_NT, nT_So_Luong As Decimal
        Dim iRow, i As Integer
        nT_Tien0 = 0
        nT_Thue_Nt = 0
        nT_TT_NT = 0
        nT_So_Luong = 0
        For iRow = 0 To DvTable1.Count - 1
            If DvTable1.Item(iRow).Item("Tag").ToString.Trim = "True" Then
                For i = 0 To DvTable2.Count - 1
                    If DvTable2.Item(i).Item("Tag").ToString.Trim = "True" And DvTable2.Item(i).Item("Stt_Rec").ToString.Trim = DvTable1.Item(iRow).Item("Stt_Rec").ToString.Trim Then
                        nT_Tien0 = nT_Tien0 + DvTable2.Item(i).Item("Tien_nt0")
                        nT_Thue_Nt = nT_Thue_Nt + DvTable2.Item(i).Item("Thue_nt")
                        nT_So_Luong = nT_So_Luong + DvTable2.Item(i).Item("So_Luong")
                    End If
                Next
            End If
        Next

        nT_TT_NT = nT_Tien0 + nT_Thue_Nt
        TxtT_Tien_NT0.Double = nT_Tien0
        TxtT_Thue_NT.Double = nT_Thue_Nt
        TxtT_TT_NT.Double = nT_TT_NT
        TxtT_SO_LUONG.Double = nT_So_Luong
        TxtT_Tien_NT0.Refresh()
        TxtT_Thue_NT.Refresh()
        TxtT_TT_NT.Refresh()
        TxtT_SO_LUONG.Refresh()
    End Sub
#End Region
#Region "Valid..."
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""

        End If
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Click ..."
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Return_Tb2 = DtTable2.Clone
        For i As Integer = 0 To DtTable1.Rows.Count - 1
            If DtTable1.Rows(i).Item("Tag").ToString.Trim.ToUpper = "1" Or DtTable1.Rows(i).Item("Tag").ToString.Trim.ToUpper = "TRUE" Then
                For j As Integer = 0 To DtTable2.Rows.Count - 1
                    If (DtTable2.Rows(j).Item("Tag").ToString.Trim.ToUpper = "1" Or DtTable2.Rows(j).Item("Tag").ToString.Trim.ToUpper = "TRUE") And DtTable2.Rows(j).Item("Stt_Rec").ToString.Trim = DtTable1.Rows(i).Item("Stt_Rec").ToString Then
                        Return_Tb2.ImportRow(DtTable2.Rows(j))
                    End If
                Next
            End If
        Next
        Return_Tb2.AcceptChanges()
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
    Private Sub V_Loc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtMa_Kh.Text.Trim = "" Then
        '    MsgBox("Phải chọn khách hàng trước khi lọc phiếu", 16, M_CYBER_VER)
        '    TxtMa_Kh.Focus()
        '    Exit Sub
        'End If
        V_Loaddatatabase("1")
        V_Tinh_Tong()
    End Sub
#End Region
End Class
