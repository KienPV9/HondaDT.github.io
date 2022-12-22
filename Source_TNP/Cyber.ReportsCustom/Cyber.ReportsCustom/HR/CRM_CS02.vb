Imports Cyber.ReportsCustom
Public Class CRM_CS02
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DtGroup, Dt_Loai, Dt_Ngay_D As DataTable
    Dim DvGroup, Dv_Loai, Dv_Ngay_D As DataView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_GetData()

        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_GetData()
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Dim _Loai As String = Me.Para(M_VT_PARA + 2).ToString.Trim
        Dim _Ma_Loai As String = Me.Para(M_VT_PARA + 3).ToString.Trim
        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_CS01_Filter", _Loai + "#" + _Ma_Loai + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)

        If DsTmp.Tables.Count >= 1 Then DtGroup = DsTmp.Tables(0).Copy
        If DsTmp.Tables.Count >= 2 Then Dt_Loai = DsTmp.Tables(1).Copy
        If DsTmp.Tables.Count >= 3 Then Dt_Ngay_D = DsTmp.Tables(2).Copy

        If Not Dt_Loai Is Nothing Then If Dt_Loai.Rows.Count = 0 Then Dt_Loai = Nothing
        If Not Dt_Ngay_D Is Nothing Then If Dt_Ngay_D.Rows.Count = 0 Then Dt_Ngay_D = Nothing

        If Not Dt_Loai Is Nothing Then Dv_Loai = New DataView(Dt_Loai)
        If Not Dt_Ngay_D Is Nothing Then Dv_Ngay_D = New DataView(Dt_Ngay_D)
        If Not DtGroup Is Nothing Then DvGroup = New DataView(DtGroup)

        If Not Dv_Loai Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CbbGroupByTH, DtGroup, "Ma", "Ten", "Default")
            CbbGroupByTH.Visible = True
            LabMa_TH.Visible = True
        Else
            CbbGroupByTH.Visible = False
            LabMa_TH.Visible = False
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------
        If Not Dv_Loai Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CbbMa_Loai, Dv_Loai, "Ma_Loai", If(Me.LAN = "V", "Ten_Loai", "Ten_Loai2"), "Ngam_Dinh")
            CbbMa_Loai.Visible = True
            LabMa_Loai.Visible = True
        Else
            CbbMa_Loai.Visible = False
            LabMa_Loai.Visible = False
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------
        If Not Dv_Ngay_D Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CbbMa_Ngay, Dv_Ngay_D, "Ma_Ngay", If(Me.LAN = "V", "Ten_Ngay", "Ten_Ngay2"), "Ngam_Dinh")
            CbbMa_Ngay.Visible = True
            LabMa_Ngay.Visible = True
        Else
            CbbMa_Ngay.Visible = False
            LabMa_Ngay.Visible = False
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------
        V_Ma_Loai(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dv_Loai Is Nothing Then Return
        If Dv_Ngay_D Is Nothing Then Return
        Dim _Ma_Loai As String = CyberSmodb.GetvalueFromCombox(CbbMa_Loai).ToString.Trim
        Dim _StrFilter As String = "1=1"
        If Not _Ma_Loai = "" Then
            _StrFilter = " Ma_Loai = '' OR Ma_Loai = '" + _Ma_Loai + "'"
        End If
        Try
            Dv_Ngay_D.RowFilter = _StrFilter
        Catch ex As Exception

        End Try

    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CbbMa_Loai.SelectedIndexChanged, AddressOf V_Ma_Loai

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau

    End Sub
#End Region
#Region "Vali --- Ma_Cs"
    Private Sub V_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Cs.Text = "" Then
            TxtTen_Cs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cs.Text = DrReturn.Item("Ma_HS")
            TxtTen_Cs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            Txtten_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_kx")
            Txtten_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            Txtten_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Loai As String = ""
        Dim _Ma_Loai As String = ""
        Dim _Ma_Ngay As String = ""

        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Try
            _Loai = Me.Para(M_VT_PARA + 2).ToString.Trim.ToUpper()
        Catch ex As Exception

        End Try

        Dim _Ma_TH As String = CyberSmodb.GetvalueFromCombox(CbbGroupByTH)
        _Ma_Loai = CyberSmodb.GetvalueFromCombox(CbbMa_Loai)
        _Ma_Ngay = CyberSmodb.GetvalueFromCombox(CbbMa_Ngay)

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ma_TH & "#" & _Loai & "#" & _Ma_Loai.Trim & "#" & _Ma_Ngay & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim

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
