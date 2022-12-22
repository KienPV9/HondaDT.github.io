Public Class hopdong22
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa, TbKx, TbMau, tbNam, Dt_vai_tro, Dt_HTLL As DataTable
    Private vTbTP, vTbQuan, vTbXa As DataView
    Private _Load_TP As Boolean = False
    Private _Dt_Nghe_Nghiep As New DataTable
    Private Sub FDMXE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        V_LoadTinh_Quan_Xa()
        V_LoadMa_Kx()
        V_LoadMa_Mau()


        V_Load()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "LoadTinh_Quan_Xa"

    Private Sub V_LoadTinh_Quan_Xa()
        'Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetDefaultHDK", "HDK".Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        TbTP = DsTb.Tables(0).Copy
        TbQuan = DsTb.Tables(1).Copy
        TbXa = DsTb.Tables(2).Copy

        Dt_vai_tro = DsTb.Tables(3).Copy
        Dt_HTLL = DsTb.Tables(4).Copy
        DsTb.Dispose()

        vTbTP = New DataView(TbTP)
        vTbQuan = New DataView(TbQuan)
        vTbXa = New DataView(TbXa)
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")

    End Sub
    Private Function GetTab(ByVal Tb_name As String, Optional ByVal Order As String = "1=1", Optional ByVal Key As String = "1=1") As DataTable
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetTable", Tb_name + "#" + Key + "#" + Order)
        GetTab = DsTb.Tables(0).Copy
    End Function
#Region "Thành phố Quận xã"
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP()
    End Sub
    Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan()
    End Sub
    Private Sub V_Ma_TP()
        vTbQuan.RowFilter = "Ma_TP = '" + CmbMa_TP.SelectedValue + "'"
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
    Private Sub V_Ma_Quan()
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
#End Region
#End Region
#Region "LoadMa_Kx"
    Private Sub V_LoadMa_Kx()
        Dim DsTbkx As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetCombox", "Dmkx#1=1#ma_kx#" & M_User_Name)
        TbKx = DsTbkx.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_kx, TbKx, "Ma_Kx", "Ten_Kx", "")
    End Sub
    Private Sub V_LoadMa_Mau()
        Dim DsTbmau As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetCombox", "DmMauxe#1=1#ma_Mau#" & M_User_Name)
        TbMau = DsTbmau.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.Cmbma_mau, TbMau, "Ma_mau", "Ten_Mau", "")
    End Sub



    Private Function CreateName() As DataTable

        Dim tbYear As New DataTable
        tbYear.Columns.Add("Nam", GetType(String))
        tbYear.Columns.Add("Ten_Nam", GetType(String))
        tbYear.Columns.Add("Ngam_Dinh", GetType(String))
        Dim _Year As String = Now.Year.ToString.Trim
        Dim _Ngam_Dinh As String = "0"
        tbYear.Rows.Add(0.ToString.Trim, IIf(M_LAN = "V", "Không xác định", "Unnow "), "1")
        For i As Integer = 1995 To _Year + 5
            'If i = _Year Then _Ngam_Dinh = "1" Else _Ngam_Dinh = "0"
            tbYear.Rows.Add(i.ToString.Trim, IIf(M_LAN = "V", "Năm " + i.ToString.Trim, "Year " + i.ToString.Trim), _Ngam_Dinh)
        Next
        Return tbYear
    End Function

#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Txtma_TVBH.Text.Trim <> "" Then If Txtma_TVBH.Text.Trim.Trim = "" Then TxtTen_TVBH.Text = "" Else TxtTen_TVBH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "(Ma_hs = N'" + Txtma_TVBH.Text.Trim + "')", CyberSmlib)
    End Sub
    Private Sub V_AddhanderMaster()
        '---TInh thanh
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        '--Ma_Kh
        AddHandler Txtma_TVBH.CyberValiting, AddressOf V_Ma_hs
        AddHandler Txtma_TVBH.CyberLeave, AddressOf L_Ma_hs
        'AddHandler Txtso_khung.Leave, AddressOf V_So_khung
        'AddHandler Txtso_may.Leave, AddressOf V_So_May
        '------------------------
        '------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"

    Private Function V_IsFieldExist(ByVal Field_Name As String, ByVal Dr As DataRow) As Boolean
        Dim _Return As Boolean = False
        If Dr Is Nothing Then Return False
        Field_Name = Field_Name.Trim
        If Dr.Table.Columns.Contains(Field_Name) Then _Return = True
        V_IsFieldExist = _Return
    End Function
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_TVBH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_hs", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_TVBH.Text = "" Then
            TxtTen_TVBH.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_TVBH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_TVBH.Text = DrReturn.Item("Ma_HS")
            TxtTen_TVBH.Text = DrReturn.Item("Ten_HS")
        Else
            Txtma_TVBH.Text = ""
            TxtTen_TVBH.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        'Dim DsGenCode As New DataSet
        'DsGenCode = V_GetCode(Mode, M_Ma_Dvcs, M_User_Name)
        'If Not DsGenCode Is Nothing Then TxtMa_xe.Text = DsGenCode.Tables(0).Rows(0).Item("Value").ToString.Trim
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
