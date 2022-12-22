Public Class FrmLocRo
#Region "Get or Set Property----------------------"
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Return M_Mode
        End Get
        Set(ByVal value As String)
            M_Mode = value
        End Set
    End Property
    Public Property Ma_Thue() As String
        Get
            Return M_Ma_Thue
        End Get
        Set(ByVal value As String)
            M_Ma_Thue = value
        End Set
    End Property
    Public Property Ma_TT() As String
        Get
            Return M_Ma_TT
        End Get
        Set(ByVal value As String)
            M_Ma_TT = value
        End Set
    End Property
    Public Property So_Ro() As String
        Get
            Return M_So_Ro
        End Get
        Set(ByVal value As String)
            M_So_Ro = value
        End Set
    End Property
    Public Property Master_Return() As DataTable
        Get
            Master_Return = M_Master_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Master_Return = Value
        End Set
    End Property
    Public Property Vt_Return() As DataTable
        Get
            Vt_Return = M_Vt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Vt_Return = Value
        End Set
    End Property
    Public Property CV_Return() As DataTable
        Get
            CV_Return = M_Cv_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Cv_Return = Value
        End Set
    End Property
    Public Property _Ds_LoolUp() As DataSet
        Get
            _Ds_LoolUp = DsLookup
        End Get
        Set(ByVal Value As DataSet)
            DsLookup = Value
        End Set
    End Property
#End Region
#Region "Bien----------------------"
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_Thue As String = "10"
    Dim M_Ma_TT As String = "C"
    Dim M_So_Ro As String = ""
    Dim DsLookup As New DataSet
    Dim tbMaster As New DataTable
    Dim dtMasterRo, dtMasterHeaderRo As New DataTable
    Dim vdtMasterRo, vdtMasterHeaderRo As New DataView

    Dim dtDetailCvRo, dtDetailHeaderCvRo As New DataTable
    Dim vdtDetailCvRo, vdtDetailHeaderCvRo As New DataView

    Dim dtDetailVtRo, dtDetailHeaderVtRo As New DataTable
    Dim vdtDetailVtRo, vdtDetailHeaderVtRo As New DataView
    Dim EditMasterTag, EditDetailCvTag, EditDetailVtTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, M_Vt_Return, M_Cv_Return As DataTable
    Dim DrReturn As DataRow
#End Region
    Dim M_ma_TTCP As String = ""
    Private Sub FrmLocRo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_GetColumn()
        Me.Text = "Chọn lệnh sửa chữa"
        V_AddHander()
        V_LoadTotal()
        CbbMa_TT.Enabled = False
        CbbMa_Thue.Enabled = False
        M_ma_TTCP = CyberSupport.V_GetDefault_TTCP("HDS", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(DetailGRVRo_Master, "tag")
        EditDetailCvTag.GetColumn(DetailGRVRo_DetailCv, "tag")
        EditDetailVtTag.GetColumn(DetailGRVRo_DetailVt, "tag")
    End Sub
    Private Sub V_AddHander()
        If Not EditMasterTag.Column Is Nothing Then AddHandler EditMasterTag.EditColumn.EditValueChanged, AddressOf V_Chon
        If Not EditDetailCvTag.Column Is Nothing Then AddHandler EditDetailCvTag.EditColumn.EditValueChanged, AddressOf V_ChonCv
        If Not EditDetailVtTag.Column Is Nothing Then AddHandler EditDetailVtTag.EditColumn.EditValueChanged, AddressOf V_ChonVt

        AddHandler TxtLenh_RO.Leave, AddressOf L_So_Lenh

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdLoc_Ro.Click, AddressOf V_LocRo
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        AddMenu()
        AddHandler DetailGRVRo_Master.FocusedRowChanged, AddressOf DetailGRVRo_Master_FocusedRowChanged
        CyberFill.V_GridviewRowCellStyle(DetailGRVRo_Master)

        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH

    End Sub
    Private Sub AddMenu()
        Dim mnItemsMail = New ContextMenu
        'Dim mnItemsF3 As New MenuItem("Xem chi tiết chứng từ", Events, Keys.F3)
        Dim mnItemsSelectAll As New MenuItem("Chọn toàn bộ", AddressOf V_SelectAllRo, Shortcut.CtrlA)
        Dim mnItemsRemoveAll As New MenuItem("Bỏ chọn ", AddressOf V_RemoveAllRo, Shortcut.CtrlU)

        mnItemsMail.MenuItems.Add(mnItemsSelectAll)
        mnItemsMail.MenuItems.Add(mnItemsRemoveAll)
        DetailGRVRo_Master.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_SelectAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To dtMasterRo.Rows.Count - 1
            dtMasterRo.Rows(i).BeginEdit()
            dtMasterRo.Rows(i).Item("Tag") = "1"
            dtMasterRo.Rows(i).EndEdit()
        Next
        For i As Integer = 0 To dtDetailVtRo.Rows.Count - 1
            dtDetailVtRo.Rows(i).BeginEdit()
            dtDetailVtRo.Rows(i).Item("Tag") = "1"
            dtDetailVtRo.Rows(i).EndEdit()
        Next
        For i As Integer = 0 To dtDetailCvRo.Rows.Count - 1
            dtDetailCvRo.Rows(i).BeginEdit()
            dtDetailCvRo.Rows(i).Item("Tag") = "1"
            dtDetailCvRo.Rows(i).EndEdit()
        Next
        dtMasterRo.AcceptChanges()
        dtDetailVtRo.AcceptChanges()
        dtDetailCvRo.AcceptChanges()
        V_LoadTotal()
    End Sub
    Private Sub V_RemoveAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To dtMasterRo.Rows.Count - 1
            dtMasterRo.Rows(i).BeginEdit()
            dtMasterRo.Rows(i).Item("Tag") = "0"
            dtMasterRo.Rows(i).EndEdit()
        Next
        For i As Integer = 0 To dtDetailVtRo.Rows.Count - 1
            dtDetailVtRo.Rows(i).BeginEdit()
            dtDetailVtRo.Rows(i).Item("Tag") = "0"
            dtDetailVtRo.Rows(i).EndEdit()
        Next
        For i As Integer = 0 To dtDetailCvRo.Rows.Count - 1
            dtDetailCvRo.Rows(i).BeginEdit()
            dtDetailCvRo.Rows(i).Item("Tag") = "0"
            dtDetailCvRo.Rows(i).EndEdit()
        Next
        dtMasterRo.AcceptChanges()
        dtDetailVtRo.AcceptChanges()
        dtDetailCvRo.AcceptChanges()
        V_LoadTotal()
    End Sub

#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn("Ma_kh").ToString.Trim
            TxtTen_kh.Text = DrReturn("ten_kh").ToString.Trim

        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub
#End Region
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, DetailGRVRo_Master)
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        'TxtSo_Ro.Text = M_So_Ro
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetLoaiTT", M_Ma_Ct.Trim + "#" + M_User_Name)
        Dim tbDmTT = Dstmp.Tables(0).Copy
        Dim tbDmThue As DataTable = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmThue", "Ma_thue", "Ma_Thue IN ('00','05','10','20') ", CyberSmlib)
        CyberFill.V_FillComBoxValue(CbbMa_TT, tbDmTT, "Ma_TT", "Ten_TT", M_Ma_TT)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Thue, tbDmThue, "Ma_Thue", "Ma_Thue", M_Ma_Thue)
        Dstmp.Dispose()
        V_LoadDatabase("1")
        V_LoadHeaderGridview()
    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value, _Ngay_Ct2 As Date = TxtNgay_Ct2.Value
        Dim strFiled = "", strValues As String = ""
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")

        Dim DsLenh_RO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetdetailHDSDefault", Status + "#" + "2" + "#" & M_Stt_rec & "#" & M_Ma_Ct & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd") & "#" & M_Mode & "#" & strFiled & "#" & strValues & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsLenh_RO.Tables(0), Me.Sysvar, Me.Lan) Then
            DsLenh_RO.Dispose()
            Exit Sub
        End If

        tbMaster = DsLenh_RO.Tables(0)
        For i = 0 To DsLenh_RO.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsLenh_RO.Tables(i))
        Next
        V_BingDataTableToDataTable(Status, DsLenh_RO.Tables(1), dtMasterRo, vdtMasterRo)
        V_BingDataTableToDataTable(Status, DsLenh_RO.Tables(2), dtDetailCvRo, vdtDetailCvRo)
        V_BingDataTableToDataTable(Status, DsLenh_RO.Tables(3), dtDetailVtRo, vdtDetailVtRo)
        DsLenh_RO.Dispose()
        If Not Status.Trim = "1" Then V_Chon(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_LoadHeaderGridview()
        Dim DsHeader As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDetailHeadHDS", M_Ma_Ct.Trim + "#" + M_User_Name)
        '========== Fill datatable
        V_BingDataTableToDataTable("1", DsHeader.Tables(0), dtMasterHeaderRo, vdtMasterHeaderRo)
        V_BingDataTableToDataTable("1", DsHeader.Tables(2), dtDetailHeaderCvRo, vdtDetailHeaderCvRo)
        V_BingDataTableToDataTable("1", DsHeader.Tables(1), dtDetailHeaderVtRo, vdtDetailHeaderVtRo)
        '========== Fill gridview
        V_FillDataToGridview(DetailGRVRo_Master, M_LAN, vdtMasterHeaderRo, vdtMasterRo)
        V_FillDataToGridview(DetailGRVRo_DetailCv, M_LAN, vdtDetailHeaderCvRo, vdtDetailCvRo)
        V_FillDataToGridview(DetailGRVRo_DetailVt, M_LAN, vdtDetailHeaderVtRo, vdtDetailVtRo)
        DsHeader.Dispose()
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
    Private Sub V_BingDataTableToDataTable(ByVal Status As String, ByRef Dt_Data_Nguon As DataTable, ByRef Dt_Data_Dich As DataTable, ByRef Dv_Data_Dich As DataView)
        If Status.Trim = "1" Then
            Dt_Data_Dich = Dt_Data_Nguon.Copy
            Dv_Data_Dich = New DataView(Dt_Data_Dich)
            Exit Sub
        End If
        Dt_Data_Dich.Clear()
        For i As Integer = 0 To Dt_Data_Nguon.Rows.Count - 1
            Dt_Data_Dich.ImportRow(Dt_Data_Nguon.Rows(i))
        Next
    End Sub
#End Region
#Region "Tinh toan"
    Private Sub V_ChonCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVRo_DetailCv.PostEditor()
        Dim selectedRow = DetailGRVRo_Master.GetFocusedRow
        Dim _Rec_Ro As String = ""
        Try
            _Rec_Ro = selectedRow("Rec_Ro").ToString.Trim
        Catch ex As Exception

        End Try
        TotalItem(_Rec_Ro)
        V_LoadTotal()
    End Sub
    Private Sub V_ChonVt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVRo_DetailVt.PostEditor()
        Dim selectedRow = DetailGRVRo_Master.GetFocusedRow

        Dim _Rec_Ro As String = ""
        Try
            _Rec_Ro = selectedRow("Rec_Ro").ToString.Trim
        Catch ex As Exception
        End Try
        TotalItem(_Rec_Ro)
        V_LoadTotal()
    End Sub
    Private Sub V_Chon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVRo_Master.PostEditor()
        DetailGRVRo_Master.UpdateCurrentRow()

        Dim selectedRow = DetailGRVRo_Master.GetFocusedRow


        Dim _Tag As String = "0"
        Dim _Rec_Ro As String = ""
        Try
            _Rec_Ro = selectedRow("Rec_Ro").ToString.Trim
        Catch ex As Exception

        End Try
        Try
            _Tag = selectedRow("Tag").ToString.Trim
        Catch ex As Exception
        End Try


        'dtMasterRo.AcceptChanges()

        V_Detial(IIf(_Tag <> "1", "0", "1"), _Rec_Ro)

        TotalItem(_Rec_Ro)

        V_LoadTotal()
    End Sub
    Private Sub DetailGRVRo_Master_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim selectedRow = DetailGRVRo_Master.GetFocusedRow
        Dim _stt_Rec As String = ""
        If selectedRow Is Nothing Then TxtSo_Lenh_HT.Text = "" Else TxtSo_Lenh_HT.Text = selectedRow("So_RO").ToString.Trim
        If selectedRow Is Nothing Then _stt_Rec = "" Else _stt_Rec = selectedRow("Rec_Ro").ToString.Trim

        V_BilldtingRo(sender, vdtMasterRo, vdtDetailCvRo)
        V_BilldtingRo(sender, vdtMasterRo, vdtDetailVtRo)
        TotalItem(_stt_Rec)

    End Sub
    Private Sub V_BilldtingRo(ByVal MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        If MasterGRV.GetFocusedRow Is Nothing Then Exit Sub
        If Not Dv_DetailTmp.Table.Columns.Contains("Rec_Ro") Then Exit Sub
        If Not Dv_Master.Table.Columns.Contains("Rec_Ro") Then Exit Sub
        If Dv_Master.Table.Rows.Count < 1 Then Exit Sub
        If Dv_Master.Table.Columns.Count < 1 Then Exit Sub
        Dim filter As String = "1=1"
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = MasterGRV.GetFocusedRow
            If (Not String.IsNullOrEmpty(selectedRow("Rec_Ro").ToString)) Then
                filter = "Rec_Ro='" + selectedRow("Rec_Ro").ToString() + "'"
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try
    End Sub
    Private Sub V_Detial(ByVal status As String, ByVal _Rec_Ro As String)
        _Rec_Ro = _Rec_Ro.Trim
        dtDetailCvRo.AcceptChanges()
        dtDetailVtRo.AcceptChanges()

        For Each Dr As DataRow In dtDetailCvRo.Select("Rec_Ro='" & _Rec_Ro & "'")
            Dr.BeginEdit()
            Dr("tag") = status
            Dr.EndEdit()
        Next
        For Each dr As DataRow In dtDetailVtRo.Select("Rec_Ro='" & _Rec_Ro & "'")
            dr.BeginEdit()
            dr("tag") = status
            dr.EndEdit()
        Next

        dtDetailCvRo.AcceptChanges()
        dtDetailVtRo.AcceptChanges()
    End Sub
    Private Sub TotalItem(ByVal _Rec_Ro As String)
        Dim T_CV As Decimal = 0
        Dim T_Thue_CV As Decimal = 0
        Dim T_Tien2 As Decimal = 0
        Dim T_Thue As Decimal = 0
        Dim T_TT As Decimal = 0
        _Rec_Ro = _Rec_Ro.Trim

        dtDetailCvRo.AcceptChanges()
        dtDetailVtRo.AcceptChanges()
        For Each drCv As DataRow In dtDetailCvRo.Select("Tag='1' AND Rec_Ro ='" + _Rec_Ro.ToString.Trim + "'")
            T_CV = T_CV + drCv("Tien_Hang")
            T_Thue_CV = T_Thue_CV + drCv("Thue")
        Next
        For Each drVt As DataRow In dtDetailVtRo.Select("Tag='1' AND Rec_Ro ='" + _Rec_Ro.ToString.Trim + "'")
            T_Tien2 = T_Tien2 + drVt("Tien_Hang")
            T_Thue = T_Thue + drVt("Thue")
        Next

        TxtT_CV.Double = T_CV
        TxtT_Thue_CV.Double = T_Thue_CV
        TxtT_Tien2.Double = T_Tien2
        TxtT_Thue.Double = T_Thue
        TxtT_TT.Double = T_CV + T_Thue_CV + T_Tien2 + T_Thue
    End Sub
    Private Sub V_LoadTotal()
        Dim T_CV_NTn, T_Thue_CV_NTn, T_Tien_Nt2n, T_Thue_NTn, T_TT_NTn As Decimal
        T_CV_NTn = 0
        T_Thue_CV_NTn = 0
        T_Tien_Nt2n = 0
        T_Thue_NTn = 0
        T_TT_NTn = 0

        For Each dr As DataRow In dtMasterRo.Select("Tag ='1'")
            For Each drcv As DataRow In dtDetailCvRo.Select("Tag= '1' And Rec_Ro='" & dr("Rec_RO").ToString.Trim & "'")
                T_CV_NTn = T_CV_NTn + drcv("Tien_Hang")
                T_Thue_CV_NTn = T_Thue_CV_NTn + drcv("Thue")
            Next
            For Each drVt As DataRow In dtDetailVtRo.Select("Tag='1' And Rec_Ro='" & dr("Rec_Ro").ToString.Trim & "'")
                T_Tien_Nt2n = T_Tien_Nt2n + drVt("Tien_Hang")
                T_Thue_NTn = T_Thue_NTn + drVt("Thue")
            Next
        Next

        T_TT_NTn = T_CV_NTn + T_Tien_Nt2n + T_Thue_CV_NTn + T_Thue_NTn
        TxtT_CV_N.Text = T_CV_NTn
        TxtT_Thue_CV_N.Text = T_Thue_CV_NTn
        TxtT_Tien2_N.Text = T_Tien_Nt2n
        TxtT_Thue_N.Text = T_Thue_NTn
        TxtT_TT_N.Text = T_TT_NTn
    End Sub
#End Region
    Private Sub L_So_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_Ct As Date = TxtNgay_Ct1.Value
        TxtLenh_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, M_Ma_Ct, "S", M_Mode, _Ngay_Ct, TxtLenh_RO.Text, M_ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
    End Sub
    Private Sub V_LocRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("2")
        If dtMasterRo.Rows.Count = 0 Then

        End If
        'Exit Sub
        Dim selectedRow = DetailGRVRo_Master.GetFocusedRow
        Dim _Rec_Ro As String = ""
        Try
            _Rec_Ro = selectedRow("Rec_Ro").ToString.Trim
        Catch ex As Exception
        End Try
        TotalItem(_Rec_Ro)
        V_LoadTotal()
        'V_Chon(sender, e)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        'Dim _Master_Return As DataTable = tbMaster.Clone
        Dim _VT_Return As DataTable = dtDetailVtRo.Clone
        Dim _CV_Return As DataTable = dtDetailCvRo.Clone


        For i As Integer = 0 To dtMasterRo.Rows.Count - 1

            If Not dtMasterRo.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            ' If _Master_Return.Rows.Count = 0 Then _Master_Return.ImportRow(dtMasterRo.Rows(i))

            Dim _Rec_RO As String = dtMasterRo.Rows(i).Item("Rec_RO").ToString.Trim.ToUpper

            For iRowVt = 0 To dtDetailVtRo.Rows.Count - 1
                If Not dtDetailVtRo.Rows(iRowVt).Item("Tag").ToString.Trim = "1" Then Continue For
                If Not dtDetailVtRo.Rows(iRowVt).Item("Rec_RO").ToString.Trim.ToUpper = _Rec_RO Then Continue For

                _VT_Return.ImportRow(dtDetailVtRo.Rows(iRowVt))

            Next

            For iRowCv = 0 To dtDetailCvRo.Rows.Count - 1
                If Not dtDetailCvRo.Rows(iRowCv).Item("Tag").ToString.Trim = "1" Then Continue For
                If Not dtDetailCvRo.Rows(iRowCv).Item("Rec_RO").ToString.Trim.ToUpper = _Rec_RO Then Continue For
                _CV_Return.ImportRow(dtDetailCvRo.Rows(iRowCv))
            Next
        Next

        Me.Master_Return = tbMaster
        'Me.Master_Return = _Master_Return

        Me.Vt_Return = _VT_Return
        Me.CV_Return = _CV_Return

        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
