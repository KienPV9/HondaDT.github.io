Public Class DMXE
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
        V_LoadNam_SX()

        V_Load_Nghe_nghiep()

        V_Load()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        TxtMa_xe.Focus()
    End Sub
#Region "LoadTinh_Quan_Xa"
    Private Sub V_Load_Nghe_nghiep()
        _Dt_Nghe_Nghiep.Columns.Add("Nghe_Nghiep")
        _Dt_Nghe_Nghiep.Columns.Add("Ten")
        _Dt_Nghe_Nghiep.Columns.Add("Ten2")
        _Dt_Nghe_Nghiep.Columns.Add("Default")
        
        _Dt_Nghe_Nghiep.Rows.Add("", "Chưa xác định", "Non", "1")
        _Dt_Nghe_Nghiep.Rows.Add("1", "Bác sỹ", "Bác sỹ", "0")
        _Dt_Nghe_Nghiep.Rows.Add("2", "Giáo viên", "Giáo viên", "0")
        _Dt_Nghe_Nghiep.Rows.Add("3", "Công An", "Công An", "0")
        _Dt_Nghe_Nghiep.Rows.Add("4", "Quân đội", "Quân đội", "0")

        CyberFill.V_FillComBoxDefaul(CbbNghe_Nghiep, _Dt_Nghe_Nghiep, "Nghe_Nghiep", "Ten", "Ngam_Dinh")

    End Sub
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
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")

        CyberFill.V_FillComBoxDefaul(CbbVai_Tro, Dt_vai_tro, "Vai_Tro", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, Dt_HTLL, "MA_HTLL", "Ten_HTLL", "Ngam_Dinh")

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
    Sub V_LoadNam_SX()
        tbNam = CreateName()
        CyberFill.V_FillComBoxDefaul(Cmbnam_sx, tbNam, "Nam", "Ten_Nam", "Ngam_Dinh")
    End Sub
#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_Kh.Text.Trim <> "" Then If TxtMa_Kh.Text.Trim.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then TxtNgay_mua.Value = Now.Date
    End Sub
    Private Sub V_AddhanderMaster()
        AddHandler TxtMa_xe.KeyPress, AddressOf TxtCodeError_KeyPress
        '---TInh thanh
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        '--Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler Txtso_khung.Leave, AddressOf V_So_khung
        AddHandler Txtso_may.Leave, AddressOf V_So_May
        '------------------------
        AddHandler Txtdien_thoai.Leave, AddressOf V_Dien_Thoai
        AddHandler Txtfax.Leave, AddressOf V_Fax
        AddHandler TxtTen_Kh.Leave, AddressOf V_Ten_kh
        AddHandler Txtdia_chi.Leave, AddressOf V_Dia_Chi
        AddHandler TxtTen_khvat.Leave, AddressOf V_Ten_khVat
        AddHandler txtdia_chivat.Leave, AddressOf V_Dia_ChiVat
        '------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_So_khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M") Then Exit Sub
        If Txtso_khung.Text.Trim = "" Then Exit Sub
        Dim Dt As Date = Now.Date
        Dim DsSo_Khung As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SOHDKGetSo_Khung", Txtso_khung.Text + "#" + _
        Dt.ToString("yyyyMMdd") + "#" + "".Trim + "#" + "HDK" + "#" + "".ToString.Trim + "#" + Me.Mode + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)
        If DsSo_Khung.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            DsSo_Khung.Dispose()
            Exit Sub
        End If
        If DsSo_Khung.Tables(1).Rows.Count < 1 Then
            DsSo_Khung.Dispose()
            Exit Sub
        End If
        V_Fill_TT(DsSo_Khung.Tables(1).Rows(0), "2")
        DsSo_Khung.Dispose()
    End Sub
    Private Sub V_So_May(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M") Then Exit Sub
        If Txtso_may.Text.Trim = "" Then Exit Sub
        Dim Dt As Date = Now.Date
        Dim DsSo_May As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SOHDKGetSo_May", Txtso_may.Text + "#" + _
        Dt.ToString("yyyyMMdd") + "#" + "".Trim + "#" + "HDK" + "#" + "2".Trim + "#" + Me.Mode + "#" + TxtMa_Dvcs.Text + "#" + M_User_Name)

        If DsSo_May.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            DsSo_May.Dispose()
            Exit Sub
        End If
        If DsSo_May.Tables(1).Rows.Count < 1 Then
            DsSo_May.Dispose()
            Exit Sub
        End If
        V_Fill_TT(DsSo_May.Tables(1).Rows(0), "3")
        DsSo_May.Dispose()
    End Sub
    Private Sub V_Fill_TT(ByVal Dr As DataRow, ByVal Is_Xe As String)

        If Dr Is Nothing Then Exit Sub
        If V_IsFieldExist("Ma_Xe", Dr) Then
            If Is_Xe = "1" Then TxtMa_xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "2" And TxtMa_xe.Text.Trim = "" Then TxtMa_xe.Text = Dr.Item("Ma_Xe").ToString.Trim
            If Is_Xe = "3" And TxtMa_xe.Text.Trim = "" Then TxtMa_xe.Text = Dr.Item("Ma_Xe").ToString.Trim
        End If

        If V_IsFieldExist("So_khung", Dr) And Txtso_khung.Text.Trim = "" Then Txtso_khung.Text = Dr.Item("So_khung").ToString.Trim

        If V_IsFieldExist("So_May", Dr) And Txtso_may.Text.Trim = "" Then Txtso_may.Text = Dr.Item("So_May").ToString.Trim
        If V_IsFieldExist("Ma_Mau", Dr) And Cmbma_mau.SelectedValue.ToString.Trim = "" Then
            Cmbma_mau.SelectedValue = Dr.Item("Ma_Mau").ToString.Trim
        End If
        If V_IsFieldExist("Ma_Kx", Dr) And CmbMa_kx.SelectedValue.ToString.Trim = "" Then
            CmbMa_kx.SelectedValue = Dr.Item("Ma_Kx").ToString.Trim
        End If
        If V_IsFieldExist("E_Mail", Dr) Then If Not Dr.Item("E_mail").ToString.Trim = "" Then txtE_mail.Text = Dr.Item("E_mail").ToString.Trim
        If V_IsFieldExist("Ma_Nthat", Dr) Then If Not Dr.Item("Ma_Nthat").ToString.Trim = "" Then TxtMa_nthat.Text = Dr.Item("Ma_Nthat").ToString.Trim

        If V_IsFieldExist("Ten_Kh", Dr) Then If Not Dr.Item("Ten_Kh").ToString.Trim = "" Then TxtTen_Kh.Text = Dr.Item("Ten_Kh").ToString.Trim
        If V_IsFieldExist("Dia_Chi", Dr) Then If Not Dr.Item("Dia_Chi").ToString.Trim = "" Then Txtdia_chi.Text = Dr.Item("Dia_Chi").ToString.Trim

        If V_IsFieldExist("Ten_KhVAT", Dr) Then If Not Dr.Item("Ten_KhVAT").ToString.Trim = "" Then TxtTen_khvat.Text = Dr.Item("Ten_KhVAT").ToString.Trim
        If V_IsFieldExist("Dia_ChiVAT", Dr) Then If Not Dr.Item("Dia_ChiVAT").ToString.Trim = "" Then txtdia_chivat.Text = Dr.Item("Dia_ChiVAT").ToString.Trim
        If V_IsFieldExist("Ma_So_Thue", Dr) Then If Not Dr.Item("Ma_So_Thue").ToString.Trim = "" Then Txtma_so_thue.Text = Dr.Item("Ma_So_Thue").ToString.Trim
        If V_IsFieldExist("Ten_Lx", Dr) Then If Not Dr.Item("Ten_Lx").ToString.Trim = "" Then Txtten_lx.Text = Dr.Item("Ten_Lx").ToString.Trim

        If V_IsFieldExist("Ma_TP", Dr) Then If Not Dr.Item("Ma_TP").ToString.Trim = "" Then CmbMa_TP.SelectedValue = Dr.Item("Ma_TP").ToString.Trim
        If V_IsFieldExist("Ma_Quan", Dr) Then If Not Dr.Item("Ma_Quan").ToString.Trim = "" Then CmbMa_Quan.SelectedValue = Dr.Item("Ma_Quan").ToString.Trim
        If V_IsFieldExist("Ma_Xa", Dr) Then If Not Dr.Item("Ma_Xa").ToString.Trim = "" Then CmbMa_Xa.SelectedValue = Dr.Item("Ma_Xa").ToString.Trim

        If V_IsFieldExist("Dien_Thoai", Dr) Then If Not Dr.Item("Dien_Thoai").ToString.Trim = "" Then Txtdien_thoai.Text = Dr.Item("Dien_Thoai").ToString.Trim
        If V_IsFieldExist("Dt_LX", Dr) Then If Not Dr.Item("Dt_LX").ToString.Trim = "" Then Txtdt_lx.Text = Dr.Item("Dt_LX").ToString.Trim
        If V_IsFieldExist("Fax", Dr) Then If Not Dr.Item("Fax").ToString.Trim = "" Then Txtfax.Text = Dr.Item("Fax").ToString.Trim

        If V_IsFieldExist("Ngay_Sinh", Dr) Then
            Dim _Ngay_Sinh As Date = Dr.Item("Ngay_Sinh")
            If Not _Ngay_Sinh.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Sinh.Value = Dr.Item("Ngay_Sinh")
        End If
        Cmbnam_sx.SelectedValue = Dr.Item("Nam_Sx").ToString.Trim
        V_Fax(New System.Object, New System.EventArgs)
        V_Dien_Thoai(New System.Object, New System.EventArgs)
        V_Ten_kh(New System.Object, New System.EventArgs)
        V_Dia_Chi(New System.Object, New System.EventArgs)
        V_Ten_khVat(New System.Object, New System.EventArgs)
        V_Dia_ChiVat(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_Fax(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtfax.Text = CyberVoucher.V_FormatDT(Txtfax.Text)
        If Txtdien_thoai.Text = "" Then Txtdien_thoai.Text = Txtfax.Text
        If Txtdt_lx.Text = "" Then Txtdt_lx.Text = Txtfax.Text
    End Sub
    Private Sub V_Dien_Thoai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtdien_thoai.Text = CyberVoucher.V_FormatDT(Txtdien_thoai.Text)
        If Txtdt_lx.Text = "" Then Txtdt_lx.Text = Txtdien_thoai.Text
        If Txtfax.Text = "" Then Txtfax.Text = Txtdien_thoai.Text
    End Sub
    Private Sub V_Ten_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTen_khvat.Text = IIf(TxtTen_khvat.Text.Trim <> "", TxtTen_khvat.Text, TxtTen_Kh.Text)
    End Sub
    Private Sub V_Dia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtdia_chivat.Text = IIf(txtdia_chivat.Text.Trim <> "", txtdia_chivat.Text, Txtdia_chi.Text)
    End Sub
    Private Sub V_Ten_khVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTen_Kh.Text = IIf(TxtTen_Kh.Text.Trim <> "", TxtTen_Kh.Text, TxtTen_khvat.Text)
    End Sub
    Private Sub V_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtdia_chi.Text = IIf(Txtdia_chi.Text.Trim <> "", Txtdia_chi.Text, txtdia_chivat.Text)
    End Sub
    Private Function V_IsFieldExist(ByVal Field_Name As String, ByVal Dr As DataRow) As Boolean
        Dim _Return As Boolean = False
        If Dr Is Nothing Then Return False
        Field_Name = Field_Name.Trim
        If Dr.Table.Columns.Contains(Field_Name) Then _Return = True
        V_IsFieldExist = _Return
    End Function
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not DrReturn Is Nothing Then TxtMa_KH.Text = DrReturn.Item("Ma_KH")
        If TxtMa_Kh.Text = "" Then
            'TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_Kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh.Text = ""
            'TxtTen_Kh.Text = ""
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
