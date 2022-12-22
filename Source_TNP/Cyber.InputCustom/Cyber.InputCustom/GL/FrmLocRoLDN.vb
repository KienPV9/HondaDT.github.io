Public Class FrmLocRoLDN
#Region "Get or Set Property----------------------"
    Public Property TL_MG As Decimal
        Get
            Return M_TL_MG
        End Get
        Set(ByVal value As Decimal)
            M_TL_MG = value
        End Set
    End Property
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
    Public Property Ma_BH() As String
        Get
            Return M_Ma_BH
        End Get
        Set(ByVal value As String)
            M_Ma_BH = value
        End Set
    End Property
    Public Property Ma_GD() As String
        Get
            Return M_Ma_GD
        End Get
        Set(ByVal value As String)
            M_Ma_GD = value
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
    Dim M_TL_MG As Decimal = 10
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_BH As String = ""
    Dim M_Ma_GD As String = "1"
    Dim M_So_Ro As String = ""
    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable

    Dim DrReturn As DataRow
#End Region
    Private Sub FrmLocRo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,Ten_Post,Ten_Post2,'0' as Ngam_Dinh FROM dbo.DmPost WHERE Ma_Ct =N'HDK' AND Ma_Post > N'1' ORDER BY Ma_Post#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_Post = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        For i As Integer = 0 To Dt_Post.Rows.Count - 1
            Dt_Post.Rows(i).BeginEdit()
            If Dt_Post.Rows(i).Item("Ma_Post").ToString.Trim = "6" Then Dt_Post.Rows(i).Item("Ngam_Dinh") = "1" Else Dt_Post.Rows(i).Item("Ngam_Dinh") = "0"
            Dt_Post.Rows(i).EndEdit()
        Next
        CyberFill.V_FillComBoxDefaul(CbbMa_Post, Dt_Post, "Ma_Post", "ten_Post", "Ngam_Dinh")
        V_Load()
        V_GetColumn()
        Me.Text = "Chọn lệnh sửa chữa"
        V_AddHander()
        V_LoadTotal()

        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(MasterGRV, "tag")
    End Sub
    Private Sub V_AddHander()

        If Not EditMasterTag.Column Is Nothing Then AddHandler EditMasterTag.EditColumn.EditValueChanged, AddressOf V_Chon

        
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        AddMenu()
        CyberFill.V_GridviewRowCellStyle(MasterGRV)

        AddHandler TxtLenh_RO.Leave, AddressOf L_So_Lenh
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdLoc_Ro.Click, AddressOf V_LocRo
        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
    End Sub
    Private Sub AddMenu()
        Dim mnItemsMail = New ContextMenu
        'Dim mnItemsF3 As New MenuItem("Xem chi tiết chứng từ", Events, Keys.F3)
        Dim mnItemsSelectAll As New MenuItem("Chọn toàn bộ", AddressOf V_SelectAllRo, Shortcut.CtrlA)
        Dim mnItemsRemoveAll As New MenuItem("Bỏ chọn ", AddressOf V_RemoveAllRo, Shortcut.CtrlU)

        mnItemsMail.MenuItems.Add(mnItemsSelectAll)
        mnItemsMail.MenuItems.Add(mnItemsRemoveAll)
        MasterGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_SelectAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = "1"
            Dt_Master.Rows(i).EndEdit()
        Next
        Dt_Master.AcceptChanges()
        V_LoadTotal()
    End Sub
    Private Sub V_RemoveAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = "0"
            Dt_Master.Rows(i).EndEdit()
        Next
        Dt_Master.AcceptChanges()
        V_LoadTotal()
    End Sub

#Region "Valid --- Ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_BH.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_BH.Text = "" Then
            TxtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn("Ma_BH").ToString.Trim
            TxtTen_BH.Text = DrReturn("ten_BH").ToString.Trim

        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
#End Region
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        TxtMa_BH.Text = M_Ma_BH
        TxtTL_MG.Double = M_TL_MG
        TxtTen_BH.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_BH", "DmBh", "Ma_BH = N'" + TxtMa_BH.Text + "'", CyberSmlib)
        V_LoadDatabase("1")
    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value, _Ngay_Ct2 As Date = TxtNgay_Ct2.Value
        'Dim strFiled = "", strValues As String = ""
        'CyberSmodb.GetValueControler(Me, strFiled, strValues, "")
        Dim _Ma_TT As String = "I"

        If M_Ma_GD = "1" Then _Ma_TT = "I"
        If M_Ma_GD = "2" Then _Ma_TT = "C"

        Dim _Ma_Post As String = ""
        Try
            _Ma_Post = CbbMa_Post.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        'Dim DsLenh_RO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTBHToLDN", Status & "#" & _Ma_TT & "#" & "#" & "" + _
        '                                                              _Ngay_Ct1.ToString("yyyyMMdd") & "#" + _Ngay_Ct2.ToString("yyyyMMdd") & "#" & _Ma_Post + "#" & _
        '                                                              M_Stt_rec & "#" & M_Ma_Ct & "#" & M_Mode & "#" & TxtMa_BH.Text & "#" & _
        '                                                              TxtLenh_RO.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim DsLenh_RO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetTBHToLDN", Status & "#" & _Ma_TT & "#" & "" & "#" & _
                                                                    _Ngay_Ct1.ToString("yyyyMMdd") & "#" + _Ngay_Ct2.ToString("yyyyMMdd") & "#" & _Ma_Post + "#" & _
                                                                    M_Stt_rec & "#" & M_Ma_Ct & "#" & M_Mode & "#" & "" & "#" & TxtMa_BH.Text & "#" & _
                                                                    TxtLenh_RO.Text & "#" & TxtTL_MG.Text.Replace(" ", "").Replace(",", "") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        For i = 0 To DsLenh_RO.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsLenh_RO.Tables(i))
        Next
        If Status = "1" Then
            Dt_Master = DsLenh_RO.Tables(0)
            Dt_head = DsLenh_RO.Tables(1)
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
        Else
            Dt_Master.Clear()
            CyberSmodb.SQLTbToTb(DsLenh_RO.Tables(0), Dt_Master)
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
#End Region
#Region "Tinh toan"
    Private Sub V_Chon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        MasterGRV.UpdateCurrentRow()

        Dim selectedRow = MasterGRV.GetFocusedRow


        Dim _Tag As String = "0"
        Dim _Rec_Ro As String = ""

        'Try
        '    _Rec_Ro = selectedRow("Rec_Ro").ToString.Trim
        'Catch ex As Exception

        'End Try
        'Try
        '    _Tag = selectedRow("Tag").ToString.Trim
        'Catch ex As Exception
        'End Try


        'dtMasterRo.AcceptChanges()
        V_LoadTotal()
    End Sub
    Private Sub V_LoadTotal()
        Dim T_CV_NTn, T_Thue_CV_NTn, T_Tien_Nt2n, T_Thue_NTn, T_TT_NTn As Decimal
        T_CV_NTn = 0
        T_Thue_CV_NTn = 0
        T_Tien_Nt2n = 0
        T_Thue_NTn = 0
        T_TT_NTn = 0

    End Sub
#End Region
    Private Sub L_So_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_Ct As Date = TxtNgay_Ct1.Value
        TxtLenh_RO.Text = CyberVoucher.V_GetSo_RO(M_Ma_Ct, "S", M_Mode, _Ngay_Ct, TxtLenh_RO.Text, M_Ma_Dvcs)
    End Sub
    Private Sub V_LocRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        'Dim _Master_Return As DataTable = Dt_Master.Clone
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            'If _Master_Return.Rows.Count = 0 Then _Master_Return.ImportRow(dtMasterRo.Rows(i))
            'Dim _Rec_RO As String = dtMasterRo.Rows(i).Item("Rec_RO").ToString.Trim.ToUpper
        Next
        Me.Master_Return = Dt_Master
        'Me.Master_Return = _Master_Return
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
