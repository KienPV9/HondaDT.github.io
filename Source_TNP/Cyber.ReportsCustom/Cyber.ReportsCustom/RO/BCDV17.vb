Public Class BCDV17
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet, _DsGroup As DataSet, _GroupByTH As DataTable
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Private TbTP, TbQuan, TbXa, TbKx, TbMau, tbNam, Dt_vai_tro, Dt_HTLL As DataTable



    Private Sub KPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set


        'If TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Xe)
        '----
        CyberSmodb.GetValueToControler(Me)
        V_LoadThangNam()
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--Ma_Xe
        'AddHandler TxtMa_Xe.CyberValiting, AddressOf V_Ma_Xe
        'AddHandler TxtMa_Xe.CyberLeave, AddressOf L_Ma_Xe
        'AddHandler TxtMa_depot.CyberValiting, AddressOf V_Ma_depot
        'AddHandler TxtMa_depot.CyberLeave, AddressOf L_Ma_depot
        'AddHandler TxtMa_tuyen.CyberValiting, AddressOf V_Ma_tuyen
        'AddHandler TxtMa_tuyen.CyberLeave, AddressOf L_Ma_tuyen
        'AddHandler txtMa_chi_tieu.CyberValiting, AddressOf V_Ma_chi_tieu
        'AddHandler txtMa_chi_tieu.CyberLeave, AddressOf L_Ma_tieu
        '--Ma_Station

        'AddHandler cmdV_Listxe.Click, AddressOf V_Listxe
        '--Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_hs

    End Sub
#End Region
    'Private Sub V_Listxe(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim str As String

    '    str = CyberSupport.V_GetStrSelectList(AppConn, Me.sysvar, Me.Para, "CP_GetListSelectListxe", "Dmxedv#" & TxtMa_Xe.Text.Trim & "#" & "" & "#" & Me.Ma_Dvcs & "#" & Me.User_Name, Me.LAN)

    '    If str Is Nothing Then Exit Sub
    '    TxtMa_Xe.Text = str
    'End Sub

    Private Sub V_LoadThangNam()
        'CBBMa_Dvcs.SelectedValue = M_Ma_DVCS
        Dim Nam, Thang As DataTable
        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_Loadnam", "")
        Nam = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.Cmbnam, Nam, "Ma_nam", "ten_nam", "")

        Dim DsTmp1 As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_Loadthang", "")
        Thang = DsTmp1.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbThang, Thang, "Ma_thang", "ten_thang", "NGAM_DINH")
        'Thang = DsTmp.Tables(1).Copy
        'CyberFill.V_FillComBoxDefaul(Me.cmbThang, Thang, "Ma_Thang", "Ten_Thang", "")
        'cmbThang.Text = Month(Now.Date)
        Cmbnam.SelectedValue = Year(Now.Date)
    End Sub


#Region "Valid"
    'Private Sub V_Ma_Xe(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '    TxtMa_Xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Xe", "Dmxe", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    DrReturn = TxtMa_Xe.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_Xe.Text = DrReturn.Item("Ma_Xe")

    '    Else
    '        TxtMa_Xe.Text = ""

    '        Exit Sub
    '    End If
    '    'V_LoadDatatabse("1")
    'End Sub
    'Private Sub V_Ma_depot(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '    TxtMa_depot.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_ttcp", "Dmttcp", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_depot(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    DrReturn = TxtMa_depot.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_depot.Text = DrReturn.Item("Ma_ttcp")
    '        txtten_depot.Text = DrReturn.Item("Ten_TTCP")
    '    Else
    '        TxtMa_depot.Text = ""
    '        txtten_depot.Text = ""

    '        Exit Sub
    '    End If
    '    'V_LoadDatatabse("1")
    'End Sub
    'Private Sub V_Ma_tuyen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '    TxtMa_tuyen.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Tuyen", "Dmtuyen", "1=1", "1=1")
    'End Sub
    'Private Sub L_Ma_tuyen(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    DrReturn = TxtMa_tuyen.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtMa_tuyen.Text = DrReturn.Item("Ma_tuyen")
    '        txtTen_tuyen1.Text = DrReturn.Item("Ten_tuyen")

    '    Else
    '        TxtMa_tuyen.Text = ""
    '        txtTen_tuyen1.Text = ""

    '        Exit Sub
    '    End If
    '    'V_LoadDatatabse("1")
    'End Sub

#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_hs")
            txtten_hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            txtten_hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#End Region

#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------

        Dim strFiled = "", strValues As String = ""
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_Nam As String = Me.Cmbnam.SelectedValue.ToString.Trim
        Dim M_thang As String = Me.CmbThang.SelectedValue.ToString.Trim
        'Dim M_Thang As String = Me.cmbThang.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = M_Nam
        M_strParameterStore = M_strParameterStore & "#" & M_thang
        'M_strParameterStore = M_strParameterStore & "#" & txtMa_chi_tieu.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim

        '-----------------------------------------------------------------------------

        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub



    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
