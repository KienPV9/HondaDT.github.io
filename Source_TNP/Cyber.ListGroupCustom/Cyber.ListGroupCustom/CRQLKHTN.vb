Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class CRQLKHTN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa, tbTNHN, tbLHKH, tbGT, tbKX, tbPTLH, tbDT, tbTTKH, tbKhmua, tbhttt, tbmau As DataTable
    Private vTbTP, vTbQuan, vTbXa As DataView
    Private _Load_TP As Boolean = False

    '----------Dung
    Private DsDL As New DataSet
    Private TbDL As New DataTable
    Private TbHDL As New DataTable

    Private DsGiaoDich As New DataSet
    Private TbGiaoDich As New DataTable
    Private TbHGiaoDich As New DataTable

    Private DsMua As New DataSet
    Private TbMua As New DataTable
    Private TbHMua As New DataTable

    Private DsBan As New DataSet
    Private TbBan As New DataTable
    Private TbHBan As New DataTable

    Private DsLaiThu As New DataSet
    Private TbLaiThu As New DataTable
    Private TbHLaiThu As New DataTable
    Private Sub FDKHTN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtTVBH_QL.Text = ""
        _Load_TP = False
        V_GetChkErro()
        'V_LoadTinh_Quan_Xa()
        V_LoadMa_TTHN()
        V_LoadMa_LHKH()
        V_LoadMa_PTLH()
        V_LoadMa_DTuoi()
        V_LoadMa_GT()
        V_LoadMa_TTKH()
        V_LoadMa_HTTT()
        V_LoadMa_KHMUA()
        V_LoadMa_Kx()
        'V_LoadMa_Mau()
        V_Load()
        V_LoadMa_Mau()

        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        If Me.Mode.Trim = "M" Then TxtDT1.Focus() Else txtOng_Ba.Focus()
        If Me.Mode.Trim = "M" Then TxtComment.Text = M_Comment.ToUpper Else TxtComment.Text = CyberSmodb.SQLGetvalue(Appconn, "Comment", "UserInfo", "[User_Name] = N'" + TxtUser_Name.Text.Trim + "'", CyberSmlib)
        V_GetTVBH_QL()

        If Me.Mode.Trim = "M" Then TxtUser_Name.Text = M_User_Name
        If Me.Mode.Trim = "M" Then txtNgay_DKKH.Value = Now.Date
        If Me.Mode.Trim = "M" Then TxtDT1.Enabled = True Else TxtDT1.Enabled = False
        TxtId_Kh.Enabled = False

        TxtComment.Text = "[ " + TxtComment.Text.ToUpper.Trim + " ]"
        If Me.Mode.Trim = "M" Then ButtChuyen_Doi.Visible = False Else ButtChuyen_Doi.Visible = True
        'V_LoadMenu()
        If Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
        TxtId_Kh.Enabled = False
        txtNgay_DKKH.Enabled = False
        TxtDia_Chi.Enabled = False
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "LoadTinh_Quan_Xa"
    'Private Sub V_LoadTinh_Quan_Xa()
    '    Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
    '    TbTP = DsTb.Tables(0).Copy
    '    TbQuan = DsTb.Tables(1).Copy
    '    TbXa = DsTb.Tables(2).Copy

    '    vTbTP = New DataView(TbTP)
    '    vTbQuan = New DataView(TbQuan)
    '    vTbXa = New DataView(TbXa)
    '    CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP")
    '    CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")
    '    CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")
    'End Sub
    Private Function GetTab(ByVal Tb_name As String, Optional ByVal Order As String = "1=1", Optional ByVal Key As String = "1=1") As DataTable
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetTable", Tb_name + "#" + Key + "#" + Order)
        GetTab = DsTb.Tables(0).Copy
    End Function
    'Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    V_Ma_TP(False)
    '    V_Ma_Quan(False)
    'End Sub
    'Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    V_Ma_Quan(False)
    'End Sub
    'Private Sub V_Ma_xa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    V_Ma_Xa(False)
    'End Sub
    'Private Sub V_Ma_TP(ByVal Load As Boolean)
    '    If Load Then
    '        CmbMa_TP.SelectedValue = TxtMa_TP.Text.Trim
    '    Else
    '        TxtMa_TP.Text = CmbMa_TP.SelectedValue.ToString.Trim
    '    End If
    '    vTbQuan.RowFilter = "Ma_Tp = '" & TxtMa_TP.Text.Trim & "'"
    'End Sub
    'Private Sub V_Ma_Quan(ByVal Load As Boolean)
    '    If Load Then
    '        CmbMa_Quan.SelectedValue = TxtMa_Quan.Text.Trim
    '    Else
    '        TxtMa_Quan.Text = CmbMa_Quan.SelectedValue.ToString.Trim
    '    End If
    '    vTbXa.RowFilter = "Ma_Quan = '" & TxtMa_Quan.Text.Trim() & "'"
    'End Sub
    'Private Sub V_Ma_Xa(ByVal Load As Boolean)
    '    If Load Then
    '        CmbMa_Xa.SelectedValue = TxtMa_Xa.Text.Trim
    '    Else
    '        TxtMa_Xa.Text = CmbMa_Xa.SelectedValue.ToString.Trim
    '    End If
    'End Sub
#End Region
#Region "LoadCombobox"
    Private Sub V_LoadMa_TTHN()

        Dim DsTbTTHN As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_TTHN#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbTNHN = DsTbTTHN.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_TTHN, tbTNHN, "Ma_TTHN", "Ten_TTHN")
        'CyberFill.V_FillComBoxDefaul(Me.CmbMa_TTHN, tbTNHN, "Ma_TTHN", "Ten_TTHN", "01")
        CmbMa_TTHN.SelectedIndex = 1
    End Sub
    Private Sub V_LoadMa_LHKH()
        Dim DstbLHKH As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_LHKH#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbLHKH = DstbLHKH.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_LHKH, tbLHKH, "Ma_LHKH", "Ten_LHKH")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_LHKH, tbLHKH, "Ma_LHKH", "Ten_LHKH")

    End Sub
    Private Sub V_LoadMa_GT()
        Dim DsTbGT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_GT##" & M_User_Name)
        tbGT = DsTbGT.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_GT, tbGT, "Ma_GT", "Ten_GT")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_GT, tbGT, "Ma_GT", "Ten_GT")
    End Sub
    Private Sub V_LoadMa_DTuoi()
        Dim DsTbDT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_DTuoi##" & M_User_Name)
        tbDT = DsTbDT.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_DTuoi, tbDT, "Ma_DTuoi", "Ten_DTuoi")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_DTuoi, tbDT, "Ma_DTuoi", "Ten_DTuoi")
    End Sub
    Private Sub V_LoadMa_PTLH()
        Dim DsTbGT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_PTLH##" & M_User_Name)
        tbPTLH = DsTbGT.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_PTLH, tbPTLH, "Ma_PTLH", "TEN_PTLH")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_PTLH, tbPTLH, "Ma_PTLH", "TEN_PTLH")
    End Sub
    Private Sub V_LoadMa_TTKH()
        Dim DsTbTTKH As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_TTKH##" & M_User_Name)
        tbTTKH = DsTbTTKH.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_TTKH, tbTTKH, "Ma_TTKH", "Ten_TTKH")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TTKH, tbTTKH, "Ma_TTKH", "Ten_TTKH")
    End Sub
    Private Sub V_LoadMa_HTTT()
        Dim DsTbhttt As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_HTTT##" & M_User_Name)
        tbhttt = DsTbhttt.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_HTTT, tbhttt, "Ma_HTTT", "Ten_HTTT")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_HTTT, tbhttt, "Ma_HTTT", "Ten_HTTT")
    End Sub
    Private Sub V_LoadMa_KHMUA()
        Dim DsTbkhmua As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_KHMUA##" & M_User_Name)
        tbKhmua = DsTbkhmua.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_KHMUA, tbKhmua, "Ma_KHMUA", "Ten_KHMUA")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_KHMUA, tbKhmua, "Ma_KHMUA", "Ten_KHMUA")

    End Sub
    Private Sub V_LoadMa_Kx()
        Dim DsTbkx As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_Kx##" & M_User_Name)
        tbKX = DsTbkx.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_Kx, tbKX, "Ma_Kx", "Ten_Kx")
        'CyberFill.V_FillComBoxDefaul(Me.CmbMa_Kx, tbKX, "Ma_Kx", "Ten_Kx")

    End Sub
    Private Sub V_LoadMa_Mau()
        'Dim DsTbma_mau As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_Mau##" & M_User_Name)
        'tbmau = DsTbma_mau.Tables(0).Copy
        'CyberFill.V_FillComBoxValue(Me.CmbMa_Mau, tbmau, "Ma_Mau", "Ten_Mau")
        'CyberFill.V_FillComBoxDefaul(Me.CmbMa_Mau, tbmau, "Ma_Mau", "Ten_Mau")
        Dim _ma_Kx As String = ""
        Dim _ma_Mau As String = TxtMa_Mau.Text
        Try
            _ma_Kx = CmbMa_Kx.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        V_FillMa_Mau(_ma_Kx, _ma_Mau, "1")
    End Sub
#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        '================Dung
        DsDL = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_DL", TxtId_Kh.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsGiaoDich = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_GiaoDich", TxtId_Kh.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsMua = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_Mua", TxtId_Kh.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsBan = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_Ban", TxtId_Kh.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsLaiThu = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_LaiThu", TxtId_Kh.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        TbDL = New DataTable
        TbHDL = New DataTable

        TbDL = DsDL.Tables(0)
        TbHDL = DsDL.Tables(1)

        TbGiaoDich = New DataTable
        TbHGiaoDich = New DataTable
        TbGiaoDich = DsGiaoDich.Tables(0)
        TbHGiaoDich = DsGiaoDich.Tables(1)


        TbMua = New DataTable
        TbHMua = New DataTable
        TbMua = DsMua.Tables(0)
        TbHMua = DsMua.Tables(1)

        TbBan = New DataTable
        TbHBan = New DataTable
        TbBan = DsBan.Tables(0)
        TbHBan = DsBan.Tables(1)

        TbLaiThu = New DataTable
        TbHLaiThu = New DataTable
        TbLaiThu = DsLaiThu.Tables(0)
        TbHLaiThu = DsLaiThu.Tables(1)
        '================End Dung
        If TxtMa_TP.Text.Trim = "" Then TxtTen_TP.Text = "" Else TxtTen_TP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TP", "DmTP", "(Ma_TP = N'" + TxtMa_TP.Text.Trim + "')", CyberSmlib)
        If TxtMa_Quan.Text.Trim = "" Then TxtTen_Quan.Text = "" Else TxtTen_Quan.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Quan", "DmQuan", "(Ma_Quan = N'" + TxtMa_Quan.Text.Trim + "')", CyberSmlib)
        If TxtMa_Xa.Text.Trim = "" Then TxtTen_xa.Text = "" Else TxtTen_xa.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Xa", "DmXa", "(Ma_Xa = N'" + TxtMa_Xa.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Protected Sub V_AddhanderMaster()
        AddHandler TxtId_Kh.KeyPress, AddressOf TxtCodeError_KeyPress

        AddHandler txtOng_Ba.Leave, AddressOf V_Ong_Ba
        AddHandler TxtDT1.Leave, AddressOf V_DT1
        AddHandler TxtDT2.Leave, AddressOf V_DT2
        AddHandler TxtDT3.Leave, AddressOf V_DT3
        AddHandler TxtTen_kh.Leave, AddressOf V_Ten_kh
        AddHandler TxtDia_Chi.Leave, AddressOf V_Dia_Chi
        AddHandler TxtTen_khVAT.Leave, AddressOf V_Ten_khVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf V_Dia_ChiVat
        '
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP

        AddHandler TxtMa_Quan.CyberValiting, AddressOf V_Ma_Quan
        AddHandler TxtMa_Quan.CyberLeave, AddressOf L_Ma_Quan

        AddHandler TxtMa_Xa.CyberValiting, AddressOf V_Ma_Xa
        AddHandler TxtMa_Xa.CyberLeave, AddressOf L_Ma_Xa

        AddHandler TxtDia_Chi_Nha.Leave, AddressOf V_Dia_chi_Nha
        ''---TInh thanh
        'AddHandler CmbMa_TP.SelectedValueChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        'AddHandler CmbMa_Quan.SelectedValueChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        'AddHandler CmbMa_Xa.SelectedValueChanged, AddressOf V_Ma_xa_SelectedIndexChanged
        '-------------
        AddHandler ButtDL.Click, AddressOf V_DL
        AddHandler ButtGiaoDich.Click, AddressOf V_GiaoDich
        AddHandler ButtMua.Click, AddressOf V_Mua
        AddHandler ButtBan.Click, AddressOf V_Ban
        AddHandler ButtLaiThu.Click, AddressOf V_LaiThu
        '-------------
        AddHandler ButtHD.Click, AddressOf V_HD
        AddHandler ButtSC.Click, AddressOf V_SC
        AddHandler ButtPK.Click, AddressOf V_PK
        AddHandler ButtCS.Click, AddressOf V_CS
        '-------------
        AddHandler ButtChuyen_Doi.Click, AddressOf V_Chuyen_Doi
        AddHandler CmbMa_Kx.SelectedIndexChanged, AddressOf V_Ma_Kx_SelectedIndexChanged
        AddHandler CmbMa_Kx.SelectedValueChanged, AddressOf V_Ma_Kx_SelectedIndexChanged

        AddHandler CmdTao_BG.Click, AddressOf V_Tao_BG
        AddHandler CmdTao_HD.Click, AddressOf V_Tao_HD
    End Sub
#End Region
#Region "Mau xe"
    Private Sub V_Ma_Kx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ma_Kx As String = ""
        Dim _ma_Mau As String = ""
        Try
            _ma_Kx = CmbMa_Kx.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        Try
            _ma_Mau = CmbbMa_Mau1.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        V_FillMa_Mau(_ma_Kx, _ma_Mau, "0")
    End Sub
    Private Sub V_FillMa_Mau(ByVal _Ma_Kx As String, ByVal _Ma_Mau As String, ByVal _Load As String)
        'Dim DsTbma_mau As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_KX_MAU", _Ma_Kx & "#" + _Ma_Mau & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If _Load = "1" Then
            tbmau = V_GetTbMau(_Ma_Kx, _Ma_Mau)
            CyberFill.V_FillComBoxDefaul(Me.CmbbMa_Mau1, tbmau, "Ma_Mau", "Ten_Mau", "Ngam_Dinh")
        Else
            Dim _DT As DataTable = V_GetTbMau(_Ma_Kx, _Ma_Mau)
            tbmau.Clear()
            For i As Integer = 0 To _DT.Rows.Count - 1
                tbmau.ImportRow(_DT.Rows(i))
            Next
            tbmau.AcceptChanges()
            Try
                CmbbMa_Mau1.SelectedValue = _Ma_Mau
            Catch ex As Exception

            End Try
        End If


    End Sub
    Private Function V_GetTbMau(ByVal _ma_kx As String, ByVal _Ma_Mau As String) As DataTable
        Dim DsTbma_mau As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQL_KX_MAU", _ma_kx & "#" + _Ma_Mau & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Dt As DataTable = DsTbma_mau.Tables(0).Copy
        DsTbma_mau.Dispose()
        V_GetTbMau = _Dt
    End Function
#End Region
#Region "Valid"
   
    Private Sub V_Ong_Ba(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTen_kh.Text = "" Then TxtTen_kh.Text = txtOng_Ba.Text
    End Sub
    Private Sub V_DT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtDT2.Text = "" Then TxtDT2.Text = TxtDT1.Text
        If TxtDT3.Text = "" Then TxtDT3.Text = TxtDT1.Text
        '--SONNT: 04/04/22 thêm cảnh báo trùng số điện thoại
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CheckNoteQLKHTN", TxtDT1.Text + "#" + Mode + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count > 0 Then
            lblNote.Text = Dstmp.Tables(0).Rows(0).Item("Comment").ToString.Trim
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_DT2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtDT1.Text = "" Then TxtDT1.Text = TxtDT2.Text
        If TxtDT3.Text = "" Then TxtDT3.Text = TxtDT2.Text
    End Sub
    Private Sub V_DT3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtDT1.Text = "" Then TxtDT1.Text = TxtDT3.Text
        If TxtDT2.Text = "" Then TxtDT2.Text = TxtDT3.Text
    End Sub
    Private Sub V_Ten_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim <> "", TxtTen_khVAT.Text, TxtTen_kh.Text)
    End Sub
    Private Sub V_Dia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
    End Sub
    Private Sub V_Ten_khVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTen_kh.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, TxtTen_khVAT.Text)
    End Sub
    Private Sub V_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim <> "", TxtDia_Chi.Text, TxtDia_ChiVAT.Text)
    End Sub
#End Region
#Region "Vali --- Dia chi"
    Private Sub V_Dia_Chi_Nha()
        Ghep_dia_Chi()
    End Sub
    Private Sub V_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TP", "DmTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TP.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP.Text = DrReturn.Item("Ten_TP")
        Else
            TxtMa_TP.Text = ""
            TxtTen_TP.Text = ""
            TxtMa_Quan.Text = ""
            TxtTen_Quan.Text = ""
            TxtMa_Xa.Text = ""
            TxtTen_xa.Text = ""
        End If
        Ghep_dia_Chi()
    End Sub
    Private Sub V_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text.Trim = "" Then Exit Sub
        Dim _filter As String = "(Ma_TP = '" + TxtMa_TP.Text.Trim + "')"
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Quan", "DmQuan", "1=1", _filter)
    End Sub
    Private Sub L_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Quan.Text = DrReturn.Item("Ma_Quan")
            TxtTen_Quan.Text = DrReturn.Item("Ten_Quan")
        Else
            TxtMa_Quan.Text = ""
            TxtTen_Quan.Text = ""
            TxtMa_Xa.Text = ""
            TxtTen_xa.Text = ""
        End If
        Ghep_dia_Chi()
    End Sub
    Private Sub V_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text.Trim = "" Or TxtMa_Quan.Text.Trim = "" Then
            Exit Sub
        End If
        Dim _filter As String = "(Ma_Quan = '" + TxtMa_Quan.Text.Trim + "')"
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xa", "DmXa", "1=1", _filter)
    End Sub
    Private Sub L_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xa.Text = DrReturn.Item("Ma_Xa")
            TxtTen_xa.Text = DrReturn.Item("Ten_Xa")
        Else
            TxtMa_Xa.Text = ""
            TxtTen_xa.Text = ""
        End If
        Ghep_dia_Chi()
    End Sub
    Private Sub Ghep_dia_Chi()
        Dim _dia_chi_full As String = ""
        _dia_chi_full = TxtDia_Chi_Nha.Text.Trim + ", " + TxtTen_xa.Text.Trim + ", " + TxtTen_Quan.Text.Trim + ", " + TxtTen_TP.Text.Trim
        TxtDia_Chi.Text = _dia_chi_full
        'TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
    End Sub
#End Region
#Region "ClickButton Add"
    Private Sub V_DL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsDL, "CRQLKHTN_DL", TbDL, "Danh sách đặt lịch hẹn : F3 - Sửa/ F4 - Thêm, F8 - Xóa")
    End Sub
    Private Sub V_GiaoDich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsGiaoDich, "CRQLKHTN_GD", TbGiaoDich, "Quá trình giao dịch : F3 - Sửa/ F4 - Thêm, F8 - Xóa")
    End Sub
    Private Sub V_Mua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsMua, "CRQLKHTN_Mua", TbMua, "Nhu cầu mua : F3 - Sửa/ F4 - Thêm, F8 - Xóa")
    End Sub
    Private Sub V_Ban(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsBan, "CRQLKHTN_Ban", TbBan, "Nhu cầu bán : F3 - Sửa/ F4 - Thêm, F8 - Xóa")
    End Sub
    Private Sub V_LaiThu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsLaiThu, "CRQLKHTN_LT", TbLaiThu, "Đăng ký lái thử : F3 - Sửa/ F4 - Thêm, F8 - Xóa")
    End Sub
    Private Sub V_LoadFromAndUpdatData(ByVal _DsHs As DataSet, ByVal TableName As String, ByVal TbDetail As DataTable, Optional ByVal _Title As String = "")
        Dim Frm As New CRQLTN_Xem
        Frm._Title = _Title
        Frm.ShowInTaskbar = False
        Frm.V_InVao(Appconn, M_Para, oSysvar, _DsHs, TableName, Mode)

        Frm.ShowDialog()
        If Frm.Save_OK = False Then Exit Sub

        TbDetail.Clear()
        CyberSmodb.SQLTbToTb(Frm.Dt_DetailTmp, TbDetail)

        For iRow As Integer = 0 To TbDetail.Rows.Count - 1
            TbDetail.BeginInit()
            TbDetail.Rows(iRow)("Id_Kh") = TxtId_Kh.Text.Trim
            TbDetail.Rows(iRow)("Id_Item") = CyberSupport.GetStt_Rec0(iRow + 1)
            TbDetail.EndInit()
            'TbDetail.Rows(iRow)("ma_Dvcs") = M_Ma_Dvcs
        Next
        TbDetail.AcceptChanges()
    End Sub
#End Region
#Region "ClickButton View"
    Private Sub V_Chuyen_Doi(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _ID_KH As String = TxtId_Kh.Text.Trim
        If _ID_KH.Trim = "" Then Exit Sub
        Dim Frm As New CRMQLKHTN_Chuyen_Doi
        Frm.Id_kh = _ID_KH
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = Nothing
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Return

    End Sub
    Private Sub V_GetTVBH_QL()
        If Mode.Trim = "M" Then
            TxtTVBH_QL.Text = TxtComment.Text
            Exit Sub
        End If
        Dim StrSQL As String = "SELECT TOP 1 Comment FROm dbo.Userinfo WHERE ([USER_NAME] IN (SELECT TOP 1 M_User_Name_N FROM dbo.CRQLKHTNChuyen_Doi WHERE Id_kh = N'" + TxtId_Kh.Text.Trim + "' ORDER BY [Date] DESC))"
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", StrSQL + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        TxtTVBH_QL.Text = ""
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count > 0 Then
            TxtTVBH_QL.Text = Dstmp.Tables(0).Rows(0).Item("Comment").ToString.Trim
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem_KQ("HD", "Hợp đồng ký kết")
    End Sub
    Private Sub V_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem_KQ("SC", "Thông tin sửa chữa")
    End Sub
    Private Sub V_PK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem_KQ("PK", "Thông tin mua phụ kiện")
    End Sub
    Private Sub V_CS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Xem_KQ("CS", "Thông tin chăm sóc khách hàng")
    End Sub
    Private Sub V_Xem_KQ(ByVal _Loai As String, ByVal _Title As String)
        Dim _ID_KH As String = TxtId_Kh.Text.Trim
        If _ID_KH.Trim = "" Then Exit Sub
        If Me.Mode.ToString.Trim = "M" Then Exit Sub
        Dim Frm As New CRQLTN_Xem_KQ
        Frm._Loai = _Loai
        Frm._Title = _Title
        Frm._ID_KH = _ID_KH
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = Nothing
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtMa_Mau.Text = ""
        Try
            TxtMa_Mau.Text = CmbbMa_Mau1.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtId_Kh.Text = _Value
        If TxtUser_Name.Text = "" Or Me.Mode.Trim = "M" Then TxtUser_Name.Text = M_User_Name
        If Me.Mode.Trim = "M" Then V_GetNgay_Gio()


        'If TxtId_Kh.Text.Trim = "" Then TxtId_Kh.Text = TxtDT1.Text.Trim.Replace(" ", "").Trim(".")
        'TxtId_Kh.Text = TxtId_Kh.Text.Trim.Replace(" ", "").Trim(".")

        'If M_Ma_Dvcs.Trim <> "" Then
        '    If TxtId_Kh.Text.Trim = "" Then TxtId_Kh.Text = M_Ma_Dvcs & "." & TxtDT1.Text.Trim.Replace(" ", "").Trim(".")
        '    TxtId_Kh.Text = TxtId_Kh.Text.Trim.Replace(" ", "").Trim(".")
        'Else
        '    If TxtId_Kh.Text.Trim = "" Then TxtId_Kh.Text = TxtDT1.Text.Trim.Replace(" ", "").Trim(".")
        'End If

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        Update_id_kh(TbDL, TxtId_Kh.Text)
        Update_id_kh(TbGiaoDich, TxtId_Kh.Text)
        Update_id_kh(TbMua, TxtId_Kh.Text)
        Update_id_kh(TbBan, TxtId_Kh.Text)
        Update_id_kh(TbLaiThu, TxtId_Kh.Text)

        Dim _id_Kh As String = ""
        If Me.Mode = "S" Then
            _id_Kh = Me.DrOld.Item("id_Kh").ToString.Trim
        End If
        '============= Save 
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbDL, "CRQLKHTN_DL", Me.Mode, "Id_Kh = N'" + _id_Kh.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbGiaoDich, "CRQLKHTN_GD", Me.Mode, "Id_Kh = N'" + _id_Kh.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbMua, "CRQLKHTN_Mua", Me.Mode, "Id_Kh = N'" + _id_Kh.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbBan, "CRQLKHTN_Ban", Me.Mode, "Id_Kh = N'" + _id_Kh.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbLaiThu, "CRQLKHTN_LT ", Me.Mode, "Id_Kh = N'" + _id_Kh.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Function V_CRQLKHTNChkSave() As Boolean

        Dim _StrF As String = ""
        Dim _StrV As String = ""
        Dim _Id_khOld As String = ""
        Try
            _Id_khOld = Me.DrOld.Item("Id_kh").ToString.Trim()
        Catch ex As Exception
        End Try
        CyberSmodb.GetValueControler(Me, _StrF, _StrV)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNChkSave", _StrF + "#" + _StrV + "#" + _Id_khOld + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), oSysvar, M_LAN) Then
            Dstmp.Dispose()
            Return False
        End If
        If Dstmp.Tables(0).Columns.Contains("Id_KH") Then TxtId_Kh.Text = Dstmp.Tables(0).Rows(0).Item("Id_KH").ToString.Trim
        Dstmp.Dispose()
        Return True
    End Function
    Private Sub V_GetNgay_Gio()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetCurrenDate", M_Ma_Dvcs + "#" + M_User_Name)
        TxtNgay_Tao.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_HT")
        txtNgay_DKKH.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_HT")
        TxtGio_Tao.Text = Dstmp.Tables(0).Rows(0).Item("Gio_HT")
        Dstmp.Dispose()
    End Sub
    Private Sub Update_id_kh(ByRef _Tb As DataTable, ByVal _Id_Kh As String)
        If _Tb Is Nothing Then Exit Sub
        If Not _Tb.Columns.Contains("Id_Kh") Then Exit Sub

        For i As Integer = 0 To _Tb.Rows.Count - 1
            _Tb.Rows(i).BeginEdit()
            _Tb.Rows(i).Item("Id_Kh") = _Id_Kh
            _Tb.Rows(i).EndEdit()
        Next
        _Tb.AcceptChanges()
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Tao/HD/ Bao gia"
    Dim ProccessList As New Collection
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
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
    Private Sub V_Tao_BG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Id_Kh As String = TxtId_Kh.Text.Trim
        Dim _So_BG As String = ""

        If _Id_Kh.Trim = "" Then Return
        Dim strAddParar As String = "4#PBG#" & _Id_Kh & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.M_Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_Tao_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Id_Kh As String = TxtId_Kh.Text.Trim
        Dim _So_BG As String = ""

        If _Id_Kh.Trim = "" Then Return
        Dim strAddParar As String = "4#HDX#" & _Id_Kh & "#" & _So_BG & "#"
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.M_Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
End Class