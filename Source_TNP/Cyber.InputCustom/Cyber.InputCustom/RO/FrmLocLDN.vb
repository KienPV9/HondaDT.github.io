Public Class FrmLocLDN
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
    Public Property Ma_KH() As String
        Get
            Return M_Ma_KH
        End Get
        Set(ByVal value As String)
            M_Ma_KH = value
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
    Public Property Ma_LHBH() As String
        Get
            Return M_Ma_LHBH
        End Get
        Set(ByVal value As String)
            M_Ma_LHBH = value
        End Set
    End Property
    Public Property Gia_Cong() As String
        Get
            Return M_Gia_Cong
        End Get
        Set(ByVal value As String)
            M_Gia_Cong = value
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
    Public Property nam() As String
        Get
            Return M_nam
        End Get
        Set(ByVal value As String)
            M_nam = value
        End Set
    End Property
    Public Property thang() As String
        Get
            Return M_thang
        End Get
        Set(ByVal value As String)
            M_thang = value
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
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_KH As String = ""
    Dim M_Ma_BH As String = ""
    Dim M_Ma_LHBH As String = ""
    Dim M_Gia_Cong As Boolean = False
    Dim M_Ma_GD As String = "1"
    Dim M_thang As Integer = 0
    Dim M_nam As Integer = 0

    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable
    Dim DtPost, DtMaGD As DataTable
    Dim DrReturn As DataRow
#End Region
    Private Sub FrmLocHDSTBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_Ct + "' AND Acti = 1 ", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,Ten_Post,Ten_Post2,'0' as Ngam_Dinh FROM dbo.DmPost WHERE Ma_Ct =N'HDS' AND Ma_Post > N'1' ORDER BY Ma_Post#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_Post = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        For i As Integer = 0 To Dt_Post.Rows.Count - 1
            Dt_Post.Rows(i).BeginEdit()
            If i = 0 Then Dt_Post.Rows(i).Item("Ngam_Dinh") = "1" Else Dt_Post.Rows(i).Item("Ngam_Dinh") = "0"
            Dt_Post.Rows(i).EndEdit()
        Next



        'CyberFill.V_FillComBoxDefaul(CbbMa_Post, Dt_Post, "Ma_Post", "ten_Post", "Ngam_Dinh")
        V_Load()
        V_GetColumn()

        'Me.Text = "Chọn hóa đơn bảo hiểm"

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
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdLoc_Ro.Click, AddressOf V_LocRo
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH

        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH

        AddHandler TxtMa_LHBH.CyberValiting, AddressOf V_Ma_LHBH
        AddHandler TxtMa_LHBH.CyberLeave, AddressOf L_Ma_LHBH

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
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
        MasterGRV.UpdateCurrentRow()
        V_LoadTotal()
    End Sub
    Private Sub V_RemoveAllRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = "0"
            Dt_Master.Rows(i).EndEdit()
        Next
        Dt_Master.AcceptChanges()
        MasterGRV.UpdateCurrentRow()
        V_LoadTotal()
    End Sub

#Region "Valid --- Ma_BH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_KH.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_KH.Text = "" Then
            TxtTen_KH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn("Ma_KH").ToString.Trim
            TxtTen_KH.Text = DrReturn("Ten_KH").ToString.Trim
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
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
            TxtTen_BH.Text = DrReturn("Ten_BH").ToString.Trim
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HD.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HD", "dmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HD.Text = "" Then
            TxtTen_Hd.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn("Ma_hd").ToString.Trim
            TxtTen_Hd.Text = DrReturn("Ten_hd").ToString.Trim
        Else
            TxtMa_HD.Text = ""
            TxtTen_Hd.Text = ""
        End If
    End Sub
    Private Sub V_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_LHBH.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_LHBH", "DmLHBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHBH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_LHBH.Text = "" Then
            TxtTen_LHBH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_LHBH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHBH.Text = DrReturn("Ma_LHBH").ToString.Trim
            TxtTen_LHBH.Text = DrReturn("Ten_LHBH").ToString.Trim
        Else
            TxtMa_LHBH.Text = ""
            TxtTen_LHBH.Text = ""
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
        TxtMa_KH.Text = M_Ma_KH
        TxtMa_BH.Text = M_Ma_BH
        TxtMa_LHBH.Text = M_Ma_LHBH
        ChkGia_Cong.Checked = M_Gia_Cong

        TxtTen_KH.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KH", "DmKH", "Ma_KH = N'" + TxtMa_KH.Text + "'", CyberSmlib)
        TxtTen_BH.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_BH", "DmBH", "Ma_BH = N'" + TxtMa_BH.Text + "'", CyberSmlib)
        TxtTen_LHBH.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_LHBH", "DmLHBH", "Ma_LHBH = N'" + TxtMa_LHBH.Text + "'", CyberSmlib)
        V_LoadNam()
        cmbNam.SelectedValue = M_nam
        cmdthang.SelectedValue = M_thang
        VisibleColumnMa_GD()
        V_LoadDatabase("1")
    End Sub
    Private Sub V_LoadNam()
        Dim tbNam, tbthang As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
        tbNam = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.cmbNam, tbNam, "Ma_nam", "Ten_nam", "")
        tbthang = DsTmp.Tables(1).Copy
        CyberFill.V_FillComBoxValue(Me.cmdthang, tbthang, "Ma_thang", "Ten_thang", "")
        cmbNam.Text = Year(Now.Date)
        cmdthang.Text = Month(Now.Date)
    End Sub

    Private Sub VisibleColumnMa_GD()


        If CbbMa_GD.SelectedValue = "96" Then
            TxtNgay_Ct1.Visible = False
            TxtNgay_Ct2.Visible = False
            cmbNam.Visible = True
            cmdthang.Visible = True
            Label1.Visible = False
            Label2.Visible = False

        Else
            TxtNgay_Ct1.Visible = True
            TxtNgay_Ct2.Visible = True
            cmbNam.Visible = False
            cmdthang.Visible = False
            Label5.Visible = False
            Label6.Visible = False
        End If

    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim Dt1 As Date = TxtNgay_Ct1.Value
        Dim Dt2 As Date = TxtNgay_Ct2.Value
        Dim ma_gd As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim StrField As String = ""
        Dim StrValue As String = ""
        CyberSmodb.GetValueControler(Me, StrField, StrValue)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetData_LDN", StrField & "#" & StrValue & "#" & ma_gd & "#" & M_Stt_rec & "#" & M_Ma_Ct & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd") & "#" & Status & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next

        'them phan check status 
        If Status = "0" Then
            If Not CyberSupport.V_MsgChk(DsTmp.Tables(1), Me.Sysvar, Me.Lan) Then
                DsTmp.Dispose()
                Exit Sub
            End If
        End If

        If Status = "1" Then
            Dt_Master = DsTmp.Tables(2)
            Dt_head = DsTmp.Tables(0)
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
        Else
            Dt_Master.Clear()
            CyberSmodb.SQLTbToTb(DsTmp.Tables(2), Dt_Master)
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
        MasterGRV.UpdateCurrentRow()
        V_LoadTotal()
    End Sub
    Private Sub V_LoadTotal()
        Dim nTien_Hang As Decimal = 0
        Dim nThue As Decimal = 0
        Dim nTong_Cong As Decimal = 0
        Dim nDa_Pb As Decimal = 0
        Dim nCl_PB As Decimal = 0

        For i As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Or Dv_Master.Item(i).Item("Tag").ToString.Trim.ToUpper = "True".Trim.ToUpper Then
                'nTien_Hang = nTien_Hang + Dv_Master.Item(i).Item("Tien_Hang")
                'nThue = nThue + Dv_Master.Item(i).Item("Thue")
                'nTong_Cong = nTong_Cong + Dv_Master.Item(i).Item("Tong_Cong")
                'nDa_Pb = nDa_Pb + Dv_Master.Item(i).Item("Da_Pb")
                'nCl_PB = nCl_PB + Dv_Master.Item(i).Item("Cl_PB")
            End If
        Next
        TxtT_Tien_Hang.Double = nTien_Hang
        TxtT_Thue.Double = nThue
        TxtT_Tong_Cong.Double = nTong_Cong
        TxtT_Da_Pb.Double = nDa_Pb
        TxtT_CL_PB.Double = nCl_PB

    End Sub
#End Region
    Private Sub V_LocRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        Dim _Master_Return As DataTable = Dt_Master.Clone

        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag").ToString.Trim = "1" Then Continue For
            _Master_Return.ImportRow(Dt_Master.Rows(i))
        Next

        Me.Master_Return = _Master_Return
        'Me.Master_Return = _Master_Return
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
